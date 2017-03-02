import {
    AgregatedResult,
    BattingStatus,
    DeliveryInfo,
    Match,
    Player,
    PlayerAgregate,
    ScoringConfig,
    Team
} from '../models/models';
import { Injectable } from '@angular/core';

@Injectable()
export class ScoringService {
    baseUrl:"";

    mockTeam1: Team = {id:1, name:"Chennai Super Kings", imageUrl:"assets/demo/csk_logo.png"};
    mockTeam2: Team = {id:2, name:"Mumbai Indians", imageUrl:"assets/demo/mi_logo.png"};
    mockTeam3: Team = {id:3, name:"Team 3", imageUrl:""};
    mockTeam4: Team = {id:4, name:"Team 4", imageUrl:""};

    mockTeams:Team[] = 
     [ this.mockTeam1, this.mockTeam2, this.mockTeam3, this.mockTeam4 ];

    mockMatches:Match[] = 
     [
        {id:1, name:"Match 1", team1:this.mockTeam1, team2:this.mockTeam2, 
            address1:"", address2:"",matchTime: new Date(Date.now())},
        {id:2, name:"Match 2", team1:this.mockTeam3, team2:this.mockTeam4,
            address1:"", address2:"",matchTime: new Date(Date.now())}
    ];

    bobPlayer = new Player(1, "Bob");
    marleyPlayer = new Player(2,"Marley");

    public result : AgregatedResult;

    constructor() { }

    public config: ScoringConfig = new ScoringConfig();
    public agregate: AgregatedResult;
    public deliveries: DeliveryInfo[];
    private agregators: IScoreAgregator[] = [ 
        new BasicScoreAgregator(),
        new PlayerScoreAgregator()
    ];

    public getAllTeams():Promise<Team[]>{
        return new Promise<Team[]>((resolve,reject) => { resolve(this.mockTeams); });
    }

    public getAllMatches():Promise<Match[]>{
        return new Promise<Match[]>((resolve,reject) => { resolve(this.mockMatches); });
    }

    public load() : AgregatedResult {
        this.deliveries = new Array();
        this.agregate = new AgregatedResult(this.config.match);
        let existingDeliveries = this.getExistingDeliveries(this.config.match);


        // Calculate agregate if continuing from existing game
        for(var curDelivery of existingDeliveries){
            this.addDelivery(curDelivery);
            this.agregate.hasStarted = true;
        }

        return this.agregate;
    }

    private getExistingDeliveries(match: Match) : DeliveryInfo[] {
        var d1 = new DeliveryInfo();
        d1.basicScore = 1;
        d1.striker = this.bobPlayer;

        var d2 = new DeliveryInfo();
        d2.basicScore = 1;
        d2.striker = this.marleyPlayer;

        return [ d1, d2 ];
    }

    public addDelivery(delivery: DeliveryInfo){
        this.deliveries.push(delivery);
        
        for(var agregator of this.agregators){
            agregator.addDelivery(delivery, this.agregate);
        }

        return this.agregate;
    }

    public removeDelivery(delivery: DeliveryInfo){
        var index = this.deliveries.indexOf(delivery);
        if(index <0){
            throw "Delivery not found";
        }

        this.deliveries.splice(index, 1);

        for(var agregator of this.agregators){
            agregator.removeDelivery(delivery, this.agregate);
        }

        return this.agregate;
    }

    public updateDelivery(delivery: DeliveryInfo){
        this.removeDelivery(delivery);
        this.addDelivery(delivery);

        // have to handle other business scenarios

        return this.agregate;
    }
}

interface IScoreAgregator{
    addDelivery(delivery: DeliveryInfo, result: AgregatedResult);
    removeDelivery(delivery: DeliveryInfo, result: AgregatedResult);
}

class BasicScoreAgregator implements IScoreAgregator{
    public addDelivery(delivery: DeliveryInfo, result: AgregatedResult){
        result.basicScore += delivery.basicScore;
    }
    public removeDelivery(delivery: DeliveryInfo, result: AgregatedResult){
        result.basicScore -= delivery.basicScore;
    }
}

class PlayerScoreAgregator implements IScoreAgregator{
    public addDelivery(delivery: DeliveryInfo, result: AgregatedResult){
        var curPlayerAgregate = result.battingList.find(
            (pa) => { return pa.player.id == delivery.striker.id });

        if(!curPlayerAgregate){
            curPlayerAgregate = new PlayerAgregate();
            curPlayerAgregate.player = delivery.striker;
            curPlayerAgregate.battingStatus = BattingStatus.Batting;
            result.battingList.push(curPlayerAgregate);
        }
        
        curPlayerAgregate.score += delivery.basicScore;
    }
    public removeDelivery(delivery: DeliveryInfo, result: AgregatedResult){
        result.basicScore -= delivery.basicScore;
    }
}