import { Router } from '@angular/router';
import { Observable, BehaviorSubject } from 'rxjs';
import { Login } from './../../shared/models/login';
import { Injectable, Output, EventEmitter } from '@angular/core';
import { ApiService } from './api.service';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  @Output() getLoggedInName: EventEmitter<any> = new EventEmitter();

isLoggedIn: BehaviorSubject<boolean>=new BehaviorSubject<boolean>(false);
  constructor(private apiService:ApiService, private router:Router) { }
    Login(login: Login):boolean{
      this.apiService.create('account/login', login).subscribe((user)=>{
        if (user) {
          localStorage.setItem("currentUser", JSON.stringify(user));
          this.isLoggedIn.next(true);
          this.router.navigate(['']);
          return true;
        }else{
          return false;
        }
      }
      );
      return false;
    }
  logOut(){
    localStorage.setItem('currentUser', '');
    this.isLoggedIn.next(false);
  }
  
  get IsLoggedIn(){
    return this.isLoggedIn.asObservable();
  }
  }