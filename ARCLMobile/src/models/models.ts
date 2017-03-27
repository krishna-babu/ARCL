export class Team {
    public id:number;
    public name:string;
    public imageUrl:string;
}

export class Match {
    public id:number;
    public name:string;
    public team1: Team;
    public team2: Team;
    public matchTime: Date;
    public address1: string;
    public address2: string;
}

export class ScoringConfig {
    public match: Match;
    public team1Members: Player[];
    public team2Members: Player[];
}

export class Player {
    constructor(
        public id: number,
        public name: string
    ){}
}

export enum BattingStatus {
    NotBatted = 0,
    Batting = 1,
    Out = 2
}

export class PlayerAgregate {
    public player: Player;
    public score: number = 0;
    public battingStatus:  BattingStatus = BattingStatus.NotBatted;
    public wickets: number = 0;
    public overs: number = 0;
}

export class DeliveryInfo {
    public id: number;
    
    public striker: Player;
    public nonStriker: Player;

    public bowler: Player;

    public basicScore: number;

    public extraScore: number;

    public next(): DeliveryInfo{
        let result: DeliveryInfo = new DeliveryInfo();
        
        result.striker = this.basicScore % 2 == 0 ? this.striker : this.nonStriker;
        result.nonStriker = this.basicScore % 2 == 0 ? this.nonStriker : this.striker;

        result.bowler = this.bowler;
        
        return result;
    }
}

export class AgregatedResult {
    constructor(
        private match: Match
        ){

    }

    public hasStarted: boolean = false;
    public basicScore: number = 0;
    public extras: number = 0;

    public battingList: PlayerAgregate[] = new Array();
    public bowlingList: PlayerAgregate[] = new Array();

    public totalScore() : number{
        return this.basicScore + this.extras;
    }
}

