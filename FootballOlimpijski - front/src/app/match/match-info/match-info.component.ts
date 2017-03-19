import { Component, OnInit } from '@angular/core';
import { User } from '../../user/user';

export class MatchInfo {
  date: string;
  venue: string;

  constructor(date: string, venue: string) {
    this.date = date;
    this.venue = venue;
  }
}

@Component({
  selector: 'match-info',
  templateUrl: './match-info.component.html',
  styleUrls: ['./match-info.component.css']
})
export class MatchInfoComponent implements OnInit {

  match: MatchInfo = new MatchInfo("22.01.2017 19:00", "Stadion olimpijski");
  user: User = new User("Majkel", "http://www.avatarsdb.com/avatars/david_beckham011.jpg");

  constructor() {
  }

  ngOnInit() {
  }

  get isAddButonDisabled(): boolean {
    return this.user.isAttendingToNextMatch;
  }
  get isRemoveButtonDisabled(): boolean {
    if (this.user.isAttendingToNextMatch === undefined || this.user.isAttendingToNextMatch === null) {
      return false;
    } else {
      return !this.user.isAttendingToNextMatch;
    }
  }

  setUserAttendace(isAttending: boolean){
    this.user.isAttendingToNextMatch = isAttending;
  }
}
