import { Component, OnInit } from '@angular/core';
import { UserService } from 'src/app/core/services/user.service';
import { Movie } from 'src/app/shared/models/movie';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.css']
})
export class FavoritesComponent implements OnInit {

  movies:Movie[];

  constructor(private userService:UserService) {
    let currentUserStr=localStorage.getItem("currentUser");
    let currentUser=JSON.parse(currentUserStr);
    this.userService.getFavoritedMovies(currentUser.id).subscribe(
      (p)=>{
        this.movies=p;
      }
  );
   }

  ngOnInit(): void {
  }

}
