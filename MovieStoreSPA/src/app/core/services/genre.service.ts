import { Injectable } from '@angular/core';
import {ApiService} from './api.service';
import { Observable } from 'rxjs';
import {Genre} from 'src/app/shared/models/genre';
@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private apiService:ApiService ) { }
  getAllGenres():Observable<Genre[]>{
     //http://localhost:54655/api/genres
    return this.apiService.getALL('genres');
  }

}
