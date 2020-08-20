import { Component, OnInit } from '@angular/core';
import { User } from 'src/app/shared/models/user';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent implements OnInit {
  currentUser:User;
  constructor() {
   let currentUserStr=localStorage.getItem("currentUser");
  console.log(currentUserStr);
   this.currentUser=JSON.parse(currentUserStr);
   }

  ngOnInit(): void {

  }

}
