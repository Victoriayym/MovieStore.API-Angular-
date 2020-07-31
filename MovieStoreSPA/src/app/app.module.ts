import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import {HttpClientModule} from '@angular/common/http';
//3rd party libraries
import {
  NgbCarouselModule,
  NgbCollapseModule,
  NgbDropdownModule,
  NgbModalModule,
  NgbPaginationModule,
  NgbTabsetModule,
  NgbAlertModule
} from "@ng-bootstrap/ng-bootstrap";

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { GenresComponent } from './genres/genres.component';
import { HeaderComponent } from './core/layout/header.component';
import { LoginComponent } from './auth/login/login.component';
import { SignUpComponent } from './auth/sign-up/sign-up.component';
import { MovieDetailsComponent } from './movies/movie-details/movie-details.component';
import { MovieCardComponent } from './shared/components/movie-card/movie-card.component';
import { MovieListComponent } from './movies/movie-list/movie-list.component';

@NgModule({
  //Components, if you wanna a component in Angular
  // it should be inside at least one module
  declarations: [
    AppComponent,
    HomeComponent,
    GenresComponent,
    HeaderComponent,
    LoginComponent,
    SignUpComponent,
    MovieDetailsComponent,
    MovieCardComponent,
    MovieListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbCarouselModule,
    NgbCollapseModule,
    NgbDropdownModule,
    NgbModalModule,
    NgbPaginationModule,
    NgbTabsetModule,
    NgbAlertModule
  ],
// dependency injection
  providers: [],
  //we can select which component needs to be strated when 
  //application starts
  //main-->AppModule-->bootstrap Appcomponent
  bootstrap: [AppComponent]
})
//its and Typyscript class
//decorates are like attributes in C#
export class AppModule { }
//Every angular application should have at least one Module,
//by default when you create Angular app it will create AppModule
//Angular can have Multiple Modules and its a good practice to have
//multiple modules so that we can seperate our application
//into different modules
//we need to make Ajax calls from Angular to API to get data.
//XmlHttpRequest
//HttpClient -> it will use  XmlHttpRequest behind the scenes (Xhr)
//ASP.NET  --> Controller (MVC and API) --> Services (class libraries) --> Repositories(Class libraries, base repositories) --> Database
//We usually sperate our Angular application code in to different feature folders to organize and reuse our code properly
//http:locahost:4200/movies/2 --> MovieDetailsComponent
//Angular --> Components --> Services - HttpClient -> API (JSON)
 //--> Services will give that to Components and components will return model to the views, so that views can display that data