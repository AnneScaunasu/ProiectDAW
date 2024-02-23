import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { BadreadsApiService } from '../badreads-api.service';

@Component({
  selector: 'app-login-page',
  standalone: true,
  imports: [],
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.css'
})
export class LoginPageComponent {
  @Input() public username: string = '';
  @Input() public password: string = '';

  constructor(private service: BadreadsApiService) {}

  login() {
    if(this.username != '' && this.password != '' ) {
      this.service.getNormalUserWithCredentials(this.username, this.password);
    }
  }
}
