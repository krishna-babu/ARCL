import { ArclService } from './../../services/arcl.service';
import { Team } from './../../models/models';
import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';

@Component({
  selector: 'page-teams',
  templateUrl: 'teams.html'
})
export class TeamsPage {
  teams:Team[];
  
  constructor(public navCtrl: NavController, private arclService: ArclService) {
    this.arclService.getAllTeams().then((teams) => { this.teams = teams; });
  }

  public itemClicked($event, item){
    
  }
}
