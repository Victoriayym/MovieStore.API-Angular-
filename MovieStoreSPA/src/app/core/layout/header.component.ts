import { LoginService } from './../services/login.service';
import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {
isLoggedIn$:Observable<boolean>;
currentUserStr=localStorage.getItem("currentUser");
currentUser=JSON.parse(this.currentUserStr);
  constructor(private loginService:LoginService) { 
    

  }

  ngOnInit(): void {
    this.isLoggedIn$=this.loginService.IsLoggedIn;
    
  }
  logout(){
    this.loginService.logOut();
  }
}
