import { ScoringService } from '../../services/scoringService';
import { AgregatedResult, ScoringConfig } from './../../models/models';
import { MatchesPage } from './../matches/matches';
import { Component } from '@angular/core';
import { ScoringPage } from './scoring';

import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-scoring-config',
  templateUrl: 'scoringConfig.html'
})
export class ScoringConfigurationPage {
  public scoringConfig: ScoringConfig;
  public agregate: AgregatedResult;

  constructor(public navCtrl: NavController, private scoringService: ScoringService) {
    this.scoringConfig = scoringService.config;
  }

  public selectMatch(){
    this.navCtrl.push(MatchesPage, { pageMode:'scoring' });
  }

  public startScoring(){
    this.navCtrl.push(ScoringPage);
  }

  ionViewWillEnter() {
    this.scoringConfig = this.scoringService.config;
    if(this.scoringConfig.match){
      this.agregate = this.scoringService.load();
    } 
  }
}
