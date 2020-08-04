import { GenreService } from './../core/services/genre.service';
import { Component, OnInit } from '@angular/core';
import {Genre} from 'src/app/shared/models/genre';
@Component({
  selector: 'app-genres',
  templateUrl: './genres.component.html',
  styleUrls: ['./genres.component.css']
})
export class GenresComponent implements OnInit {

  genres:Genre[];
  constructor(private genreService:GenreService) { }
  //Page Life Cycle Hooks
  //Alt+shift f
  //Alt+O from angular2-switch extension
  ngOnInit() {
    //we want to initialize any data, call the API etc
    this.genreService.getAllGenres().subscribe((g)=>{
      this.genres=g;
      console.log('inside Genres Component init method');
      console.log(this.genres);
    });
  }
}
