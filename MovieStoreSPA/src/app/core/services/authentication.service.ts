import { JwtStorageService } from './jwt-storage.service';
import { Observable, BehaviorSubject } from 'rxjs';
import { Login } from './../../shared/models/login';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { map, timestamp } from 'rxjs/operators';
import { User } from 'src/app/shared/models/user';
import { JwtHelperService } from "@auth0/angular-jwt";
@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {
  private currentUserSubject=new BehaviorSubject<User>({}as User);
  //create an instance of BS, hold value of User
  public currentUser=this.currentUserSubject.asObservable();
  //currentUser(component) can subscribe currentUserSubject(BS)
  private isAuthenticatedSubject=new BehaviorSubject<boolean>(false);
  public isAuthenticated=this.isAuthenticatedSubject.asObservable();
  private user:User;
  constructor(private apiService:ApiService, private jwtStorageService:JwtStorageService) { }
  login(userLogin: Login): Observable<boolean> {
    //call our API  http://localhost:58601/api/account/login
    //if username and password is valid from API, then call JWTstorageservice save Token
    //method, otherwise return false to the component
    return this.apiService.create('account/login', userLogin).pipe(
      map((response) => {
        if (response) {
          // store the token in local storage
          // decode the token and populate User Info
          this.jwtStorageService.saveToken(response.token);
          this.populateUserInfo();
          return true;
        }
        return false;
      })
    );
  }
  logout(){ //reset everything
//remove token from localstorage
//remove jwt from localstorage
    this.jwtStorageService.destroyToken();
    //set current user to an empty subject
    this.currentUserSubject.next({}as User);
    //set auth status to false
    this.isAuthenticatedSubject.next(false);
  }

  populateUserInfo(){
    if (this.jwtStorageService.getToken()){
      const token=this.jwtStorageService.getToken();
      const decodedToken=this.decodeToken();
      this.currentUserSubject.next(decodedToken);//push User into subject
      this.isAuthenticatedSubject.next(true);
    }
  }

  private decodeToken (): User{
      const token=this.jwtStorageService.getToken();
if (!token || new JwtHelperService().isTokenExpired(token)) {
        this.logout();
        return null;
      }
      const decodedToken=new JwtHelperService().decodeToken(token);
      this.user=decodedToken; //get decoded info in payload
      return this.user;
  }
getCurrentUser():User{
  return this.currentUserSubject.value; //get subject value
}

}