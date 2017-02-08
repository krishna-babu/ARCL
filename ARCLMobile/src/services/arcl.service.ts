import { Team, Match } from './../models/models';
import { Injectable } from '@angular/core';

@Injectable()
export class ArclService {
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

    constructor() { }

    public getAllTeams():Promise<Team[]>{
        return new Promise<Team[]>((resolve,reject) => { resolve(this.mockTeams); });
    }

    public getAllMatches():Promise<Match[]>{
        return new Promise<Match[]>((resolve,reject) => { resolve(this.mockMatches); });
    }

}