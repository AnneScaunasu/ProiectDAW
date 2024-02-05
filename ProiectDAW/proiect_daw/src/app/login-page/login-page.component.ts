import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { BadreadsApiService } from '../badreads-api.service';

@Component({
  selector: 'app-login-page',
  standalone: true,
  imports: [],
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.css'
})
export class LoginPageComponent {
  username: string = '';
  passward: string = '';

  login() {}
}
