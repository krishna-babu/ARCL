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
    if(this.scoringConfig.match){
      this.agregate = this.scoringService.agregate;
    }
  }

  public bob2(){
    let d = new DeliveryInfo();
    d.striker = new Player(1,"Bob");
    d.basicScore = 2;

    this.scoringService.addDelivery(d);
  }

  public mar1(){
    let d = new DeliveryInfo();
    d.striker = new Player(2,"Marley");
    d.basicScore = 1;
    
    this.scoringService.addDelivery(d);
  }
}
