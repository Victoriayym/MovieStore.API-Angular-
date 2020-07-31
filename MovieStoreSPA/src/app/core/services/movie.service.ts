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
      return this.apiService.getALL(`${'/movies/genre/'}${genreId}`); }

    GetMovieDetails(movies: string, id: number): Observable<Movie> {
        return this.apiService.getOne(movies, id);}

    GetTopRatedMovies():Observable<Movie[]>{
      return this.apiService.getALL('toprated');}
    
}
  


