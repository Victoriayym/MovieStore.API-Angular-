import { Movie } from './../../models/movie';
import { Component, OnInit, Input } from '@angular/core';
@Component({
  selector: 'app-movie-card',
  templateUrl: './movie-card.component.html',
  styleUrls: ['./movie-card.component.css']
})
export class MovieCardComponent implements OnInit {
  @Input() movie: Movie;
  constructor() { }
  ngOnInit(): void {
  }
}
//two ways to share data between components
//for sending data from Parent Component to child component we use@input
//decorate for emitting data from child to parent we use @output decorator