import { UserService } from './../../core/services/user.service';
import { Login } from './../../shared/models/login';
import { LoginService } from './../../core/services/login.service';
import { SignupService } from './../../core/services/signup.service';
import { Component, OnInit } from '@angular/core';
import {FormBuilder} from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
loginForm;
  constructor(private loginService:LoginService, private router:Router,
    private formbuilder: FormBuilder ) { 
      this.loginForm=formbuilder.group({
        email:'',
        password:''
      });
      
    }
onSubmit(login:Login){
  this.loginService.Login(login).subscribe(
    (l)=>{
        localStorage.setItem('currentUser', JSON.stringify(l));
        this.loginService.isLoggedIn.next(true);
        this.router.navigate(['']);
    }
  )
}

  ngOnInit(): void {

  }

}
