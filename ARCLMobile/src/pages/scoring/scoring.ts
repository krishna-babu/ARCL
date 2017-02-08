import { Match } from './../../models/models';
import { MatchesPage } from './../matches/matches';
import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-scoring',
  templateUrl: 'scoring.html'
})
export class ScoringPage {
  private scoringConfig: any = {
    match: Match
  };

  constructor(public navCtrl: NavController) {
    
  }

  public selectMatch(){
    this.navCtrl.push(MatchesPage, { pageMode:'scoring', scoringConfig: this.scoringConfig });
  }
}
