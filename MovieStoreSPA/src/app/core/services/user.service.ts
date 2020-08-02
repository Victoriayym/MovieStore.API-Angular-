import { ReviewListbyUser } from './../../shared/models/reviews';
import { Review } from './../../shared/models/review';
import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Purchase } from 'src/app/shared/models/purchase';
import { Observable } from 'rxjs';
import { Purchases } from 'src/app/shared/models/purchases';
import { Favorite } from 'src/app/shared/models/favorite';
import { map, tap } from 'rxjs/operators';
import { Movie } from 'src/app/shared/models/movie';
//d

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private apiService: ApiService) { }
  purchaseMovie(purchase: Purchase) {
    return this.apiService.create('/user/purchase', purchase);
  }

  Review(review: Review) {
    return this.apiService.create('/user/review', review);
  }

  getPurchasedMovies(id: number): Observable<Movie[]> {
    return this.apiService.getALL(`${'user/PurchasedMovies/'}${id}`);
  }

  getFavoritedMovies(id: number): Observable<Movie[]> {
    return this.apiService.getALL(`${'user/FavoritedMovies/'}${id}`);
  }

  ReviewListByUser(id: number): Observable<Purchases> {
    return this.apiService.getOne('User/ReviewListbyUser', id);
  }
  favoriteMovie(favorite: Favorite) {
    return this.apiService.create('/user/favorite', favorite);
  }
  unfavoriteMovie(removefavorite: Favorite) {
    return this.apiService.create('/user/removefavorite', removefavorite);
  }

  isMovieFavorited(userId: number, movieId: number): Observable<any> {
    return this.apiService.getALL(`${'/user/'}${userId}/movie/${movieId}${'/favorite'}`);
  }

  
}
