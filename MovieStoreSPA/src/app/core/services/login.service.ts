import { Observable, BehaviorSubject } from 'rxjs';
import { Login } from './../../shared/models/login';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
@Injectable({
  providedIn: 'root'
})
export class LoginService {
isLoggedIn: BehaviorSubject<boolean>=new BehaviorSubject<boolean>(false);
  constructor(private apiService:ApiService) { }
  Login(login: Login):Observable<Login>{
    return this.apiService.create('account/login', login);
  }
logOut(){
  localStorage.setItem('currentUser', '');
  this.isLoggedIn.next(false);
}

get IsLoggedIn(){
  return this.isLoggedIn.asObservable();
}

}
