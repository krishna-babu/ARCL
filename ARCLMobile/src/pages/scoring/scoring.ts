import { Match, ScoringConfig } from './../../models/models';
import { MatchesPage } from './../matches/matches';
import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-scoring',
  templateUrl: 'scoring.html'
})
export class ScoringPage {
  public scoringConfig: ScoringConfig = new ScoringConfig();

  constructor(public navCtrl: NavController) {
    
  }

  public selectMatch(){
    this.navCtrl.push(MatchesPage, { pageMode:'scoring', scoringConfig: this.scoringConfig });
  }
}
