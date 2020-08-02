
import { FavoritesComponent } from './account/favorites/favorites.component';
import { PurchasesComponent } from './account/purchases/purchases.component';
import { MovieListComponent } from './movies/movie-list/movie-list.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MovieDetailsComponent } from './movies/movie-details/movie-details.component';
import { LoginComponent } from './auth/login/login.component';
import { SignUpComponent } from './auth/sign-up/sign-up.component';
import { AppComponent } from './app.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'login',component:LoginComponent },
  {path:'sign-up',component:SignUpComponent },
  {path:'movie/:id', component:MovieDetailsComponent},
  {path:'app',component:AppComponent },
  {path:'movies/genre/:id', component:MovieListComponent},
  {path:'user/PurchasedMovies', component:PurchasesComponent},
  {path:'user/FavoritedMovies', component:FavoritesComponent}
 

];
//two ways to go to any URL, 1.type URL in the browser
//2.
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
