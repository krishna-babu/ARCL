import { AgregatedResult, DeliveryInfo, Player, ScoringConfig } from '../../models/models';
import { ScoringService } from '../../services/scoringService';
import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-scoring',
  templateUrl: 'scoring.html'
})
export class ScoringPage {
  public scoringConfig: ScoringConfig;
  public agregate: AgregatedResult;
  public currentDelivery: DeliveryInfo;

  constructor(public navCtrl: NavController, private scoringService: ScoringService) {
    this.scoringConfig = this.scoringService.config;
    this.agregate = this.scoringService.agregate;
    this.currentDelivery = new DeliveryInfo();

    // load temp players
    this.currentDelivery.striker = new Player(1,"Bob");
    this.currentDelivery.nonStriker = new Player(2,"Marley");

    this.currentDelivery.bowler = new Player(3,"Bowler");
  }

  public scoreClick(score: number){
    this.currentDelivery.basicScore = score;
    this.scoringService.addDelivery(this.currentDelivery);
    this.currentDelivery = this.currentDelivery.next();
  }
}
