import { OverViewPipe } from './../../pipes/over-view.pipe';
import { Genre } from 'src/app/shared/models/genre';
import { MovieService } from './../../core/services/movie.service';
import { Movie } from './../../shared/models/movie';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { LoginService } from 'src/app/core/services/login.service';
import { Observable, BehaviorSubject } from 'rxjs';
import { Purchase } from 'src/app/shared/models/purchase';

@Component({
  selector: 'app-movie-details',
  templateUrl: './movie-details.component.html',
  styleUrls: ['./movie-details.component.css']
})
export class MovieDetailsComponent implements OnInit {
  movie: Movie;
  movieId:number;
  isLoggedIn$:Observable<boolean>;
  currentMoviePurchased:BehaviorSubject<boolean>=new BehaviorSubject<boolean>(false);
  currentUserStr=localStorage.getItem("currentUser");
  currentUser=JSON.parse(this.currentUserStr);

  constructor(private route: ActivatedRoute, private movieService:MovieService,
    private userService: UserService, private loginService:LoginService) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe((params) => {
      this.movieId = +params.get('id');
      this.movieService.GetMovieDetails(this.movieId).subscribe((m) => {
        this.movie = m;
        console.log(this.movieId);
        console.table(this.movie);
      });
    });
    this.isLoggedIn$=this.loginService.IsLoggedIn;
  }
  purchaseMovie(){
    let purchase:Purchase={
      movieId:this.movieId,
      userId:this.currentUser.id};
    this.userService.purchaseMovie(purchase).subscribe(
      (p)=>{
        this.currentMoviePurchased.next(true);
      }
    )
  }
}
