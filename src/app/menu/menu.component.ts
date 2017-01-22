import { Component } from '@angular/core';

@Component({
  selector: 'nav-bar',
  template: `
  <md-toolbar color="primary" class="md-elevation-z3">
  <span>{{appName}}</span>
  <span class="example-fill-remaining-space"></span>
  <span class="login-btn">zaloguj</span>
  </md-toolbar>
  `,
  styles:[
    'span { color: white; }',
    '.example-fill-remaining-space { flex: 1 1 auto; }',
    '.login-btn {font-size: 0.75em};'
    ]
  
  
})
export class MenuComponent {
  appName : string = 'FOOTBALL OLIMPIJSKI';
}
