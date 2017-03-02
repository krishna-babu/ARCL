import { MatchesPage } from './../pages/matches/matches';
import { ScoringService } from './../services/scoringService';
import { ScoringConfigurationPage } from './../pages/scoring/scoringConfig';
import { ScoringPage } from './../pages/scoring/scoring';
import { ArclService } from './../services/arcl.service';
import { NgModule, ErrorHandler } from '@angular/core';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { MyApp } from './app.component';
import { AboutPage } from '../pages/about/about';
import { TeamsPage } from '../pages/teams/teams';
import { HomePage } from '../pages/home/home';
import { TabsPage } from '../pages/tabs/tabs';

@NgModule({
  declarations: [
    MyApp,
    AboutPage,
    TeamsPage,
    HomePage,
    TabsPage,
    ScoringConfigurationPage,
    ScoringPage,
    MatchesPage
  ],
  imports: [
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    TeamsPage,
    HomePage,
    TabsPage,
    ScoringConfigurationPage,
    MatchesPage,
    ScoringPage
  ],
  providers: [
    ArclService,
    ScoringService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
    ]
})
export class AppModule {}
