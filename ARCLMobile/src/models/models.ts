export class Team{
    public id:number;
    public name:string;
    public imageUrl:string;
}

export class Match{
    public id:number;
    public name:string;
    public team1: Team;
    public team2: Team;
    public matchTime: Date;
    public address1: string;
    public address2: string;
}

export class ScoringConfig{
    public match: Match;
}