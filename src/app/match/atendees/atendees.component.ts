import { Component, OnInit, Input } from '@angular/core';
import { User } from '../../user/user';

@Component({
  selector: 'app-atendees',
  templateUrl: './atendees.component.html',
  styleUrls: ['./atendees.component.css']
})
export class AtendeesComponent implements OnInit {
  atendees = [
    new User("Pusia P", "http://www.avatarsdb.com/avatars/ronaldo.jpg"),
    new User("50 Klosa", "http://www.avatarsdb.com/avatars/steven_gerrard.jpg"),
    new User("Zinedin Zidan", "http://www.avatarsdb.com/avatars/zinedine_zidane.jpg")
  ]

  constructor() { }

  ngOnInit() {
  }

  addAtendee(attendee: User) {
    this.atendees.push(attendee);
  }

  removeAtendee(attendee: User) {
    let index = this.atendees.indexOf(attendee);
    if (index > -1) {
      this.atendees.splice(index, 1);
    }
  }
}
