import { User } from './../../shared/models/user';
import { UserService } from './../../core/services/user.service';
import { Purchases } from './../../shared/models/purchases';
import { Movie } from 'src/app/shared/models/movie';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-purchases',
  templateUrl: './purchases.component.html',
  styleUrls: ['./purchases.component.css']
})
export class PurchasesComponent implements OnInit {
 
 movies:Movie[];

  constructor(private userService:UserService) {
    let currentUserStr=localStorage.getItem("currentUser");
    let currentUser=JSON.parse(currentUserStr);
    this.userService.getPurchasedMovies(currentUser.id).subscribe(
      (p)=>{
        this.movies=p;
      }
  );
   }

  ngOnInit(): void {
  }

}
