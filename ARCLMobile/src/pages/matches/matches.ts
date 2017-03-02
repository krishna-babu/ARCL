import { ScoringService } from '../../services/scoringService';
import { ArclService } from './../../services/arcl.service';
import { Match } from './../../models/models';
import { Component } from '@angular/core';

import { NavController, NavParams  } from 'ionic-angular';

@Component({
  selector: 'page-matches',
  templateUrl: 'matches.html'
})
export class MatchesPage {
  private matches:Match[] = [];
  
  constructor(
    public navCtrl: NavController, 
    public params: NavParams, 
    private arclService: ArclService, 
    private scoringService: ScoringService) {
    
    this.arclService.getAllMatches().then((matches) => { this.matches = matches; });
  }

  public itemClicked(item){
    if(this.params.get("pageMode") == "scoring"){
        this.scoringService.config.match = item;
        this.navCtrl.pop();
    }
  }
}
