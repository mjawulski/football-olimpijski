import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MaterialModule } from '@angular/material';
import { FlexLayoutModule } from '@angular/flex-layout';
import { ExpansionPanelsModule } from 'ng2-expansion-panels';

import { AppComponent } from './app.component';
import { MenuComponent } from './menu/menu.component';
import { MatchInfoComponent } from './match/match-info/match-info.component';
import { AtendeesComponent } from './match/atendees/atendees.component';
@NgModule({
  declarations: [
    AppComponent,
    MenuComponent,
    MatchInfoComponent,
    AtendeesComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    MaterialModule.forRoot(),
    FlexLayoutModule.forRoot(),
    ExpansionPanelsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
