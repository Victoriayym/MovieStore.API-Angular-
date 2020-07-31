import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import {Movie} from 'src/app/shared/models/movie';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private apiService:ApiService) { }
    GetTopRevenueMovies():Observable<Movie[]>{
      return this.apiService.getALL('movies/toprevenue');}
    
    GetMoviesByGenre(genreId: number):Observable<Movie[]>{
      return this.apiService.getALL(`${'movies/genre/'}${genreId}`); }

    GetMovieDetails(movies: string, id: number): Observable<Movie> {
        return this.apiService.getOne(movies, id);}

    GetTopRatedMovies():Observable<Movie[]>{
      return this.apiService.getALL('toprated');}
    
}
//in bootstrap there are certain components that have dependency on other 3rd party JS libraries
//such as JQuery etc
//but when we install bootstrap in angular we dont wanna install JQuery or other 3rd party libraries bc they might
//have conflict with Angular and they might effect how DOM work properly


