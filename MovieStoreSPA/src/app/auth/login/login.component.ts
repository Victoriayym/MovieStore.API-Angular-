import { AuthenticationService } from './../../core/services/authentication.service';
import { UserService } from './../../core/services/user.service';
import { Login } from './../../shared/models/login';
import { LoginService } from './../../core/services/login.service';
import { SignupService } from './../../core/services/signup.service';
import { Component, OnInit } from '@angular/core';
import {FormBuilder} from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { User } from 'src/app/shared/models/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  invalidLogin: boolean;//display message in the UI
  //you went to user/purchases page => it redirects to login page
  //after successfull login go back to original page that it comes from (user/purchases page)
  returnUrl: string;
  user:User;
  userLogin: Login = {
    email:'',
    password:''
  }
  constructor(
    private authService: AuthenticationService,
    private router: Router,
    private activatedRoute: ActivatedRoute
  ) {}
  ngOnInit() {
    this.authService.login(this.userLogin).subscribe((response) => {
      if (response) {
        // navigate to page retutn URL or Home page
        this.router.navigate(['']);
      } else {
        this.invalidLogin = true;
      }
    });
  }

  login(){
    console.log('sss');
  }
}
