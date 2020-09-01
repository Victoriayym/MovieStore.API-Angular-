import { AuthenticationService } from './../services/authentication.service';
import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
isLoggedIn$:Observable<boolean>;
userName:string;

  constructor(private authenticationService:AuthenticationService) { 
  }

  ngOnInit(): void {
    this.isLoggedIn$=this.authenticationService.isAuthenticated;
    this.authenticationService.currentUser.subscribe((user)=>{
      this.userName=user.given_name;
    });
  }
  logout(){
    this.authenticationService.logout();
  }
}
