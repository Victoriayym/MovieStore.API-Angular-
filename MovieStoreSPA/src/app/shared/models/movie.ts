import { Genre } from './genre';
import { Cast } from './cast';
export interface Movie{
    id: number;
  title: string;
  overview: string;
  tagline: string;
  budget: number;
  revenue: number;
  imdbUrl: string;
  tmdbUrl: string;
  releaseDate: Date;
  runTime: number;
  price: number;
  favoritesCount: number;
  casts: Cast[];
  genres: Genre[];
}