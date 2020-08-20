import { JwtStorageService } from './jwt-storage.service';
import { Router } from '@angular/router';
import { Observable, BehaviorSubject } from 'rxjs';
import { Login } from './../../shared/models/login';
import { Injectable, Output, EventEmitter } from '@angular/core';
import { ApiService } from './api.service';
import * as jwt_decode from 'jwt-decode';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
  @Output() getLoggedInName: EventEmitter<any> = new EventEmitter();

isLoggedIn: BehaviorSubject<boolean>=new BehaviorSubject<boolean>(false);
  constructor(private apiService:ApiService, private router:Router,
    private jwtStorageService: JwtStorageService) { }
Login(login: Login):boolean{

    this.apiService.create('account/login', login).subscribe((response)=>{
      if (response) {
        console.log(response);
        this.jwtStorageService.saveToken(response.token);
        
        var decodedToken = jwt_decode(response.token); 
        var currentUser = JSON.stringify({ 
          isAdmin: 'Admin' === decodedToken['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'],
          id: decodedToken['nameid'],
          fullName: `${decodedToken['given_name']} ${decodedToken['family_name']}`});
       this.getLoggedInName.emit(decodedToken['given_name']);
        
      localStorage.setItem('currentUser',currentUser);
        this.isLoggedIn.next(true);
        this.router.navigate(['']);
        return true;
      }else{
        this.getLoggedInName.emit('');
        return false;
      }
    }
    );
    return false;
  }
logOut(){
  this.getLoggedInName.emit('');
  localStorage.setItem('currentUser', '');
  this.isLoggedIn.next(false);
}

get IsLoggedIn(){
  return this.isLoggedIn.asObservable();
}
}
