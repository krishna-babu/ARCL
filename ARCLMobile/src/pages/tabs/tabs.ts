import { ScoringConfigurationPage } from './../scoring/scoringConfig';
import { Component } from '@angular/core';

import { HomePage } from '../home/home';
import { TeamsPage } from '../teams/teams';

@Component({
  templateUrl: 'tabs.html'
})
export class TabsPage {
  // this tells the tabs component which Pages
  // should be each tab's root Page
  homeRoot: any = HomePage;
  scoringRoot: any = ScoringConfigurationPage;
  teamsRoot: any = TeamsPage;

  constructor() {

  }
}
