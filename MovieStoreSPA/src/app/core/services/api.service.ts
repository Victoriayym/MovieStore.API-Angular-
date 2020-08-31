import {Injectable} from '@angular/core';
import {HttpClient, HttpErrorResponse, HttpHeaders} from '@angular/common/http';
import {Observable, throwError} from 'rxjs';
import {map, catchError} from 'rxjs/operators';
import {environment} from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private headers: HttpHeaders;

  //private readonly..., in angular we dont need it
  constructor(protected http:HttpClient) { 
    this.headers=new HttpHeaders();
    this.headers.append('Content-Type','application/json');
    //tell api that send information in JSON format
  }
  //get movies by genre
  //get all genres
  //get movies purchased by a user
  //http://localhost:54655/api/genres
  //rxjs library
  //publish/subscribe
  getALL(path:string): Observable<any[]>{
    //we need to append the common url with path that is being passed
    return this.http
      .get(`${environment.apiUrl}${path}`)
      .pipe(
        map((resp) => resp as any[])
        //map is the same as select in c# LINQ
        //1,2,3 select map(n=>n*n) =>1,4,9
        //1,2,3 where, filter (n=>n>2)=>3
        );
  }
  //get movie by movieId
  //get userinfo by id
  getOne(path: string, id:number): Observable<any>{
    return this.http
      .get(`${environment.apiUrl}${path}`+'/'+id)
      .pipe(
        map(resp => resp as any)
        );
  }
  create(path:string, resource: any): Observable<any> {
    return this.http.post(`${environment.apiUrl}${path}`,resource, {headers:this.headers})
    .pipe( map( response => response),
    catchError(this.handleError));
  }
  update(path: string, resource) {
    return this.http
      .put(
        `${environment.apiUrl}${path}` + '/' + resource.id,
        JSON.stringify({ isRead: true })
      )
      .pipe(
        map(response => response),
        catchError(this.handleError)
      );
  }

  delete(path: string, id) {
    return this.http.delete(`${environment.apiUrl}${path}` + '/' + id).pipe(
      map(response => response),
      catchError(this.handleError)
    );
  }
  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      // A client-side or network error occurred. Handle it accordingly.
      console.error('An error occurred:', error.error.message);
    } else {
      // The backend returned an unsuccessful response code.
      // The response body may contain clues as to what went wrong,
      console.log(error.error.errorMessage);
      console.error(
        `Backend returned code ${error.status}, ` + `body was: ${error.message}`
      );
    }
    // return an observable with a user-facing error message
    return throwError(error.error.errorMessage);

  }
  }
  //post some information
  //login, signup, create movie
  // <create(){

  // }
  //update user info
  //update movie by movie id
  // update(){

  // }
  //delete favorite movie
  // delete(){

  // }

//a service is nothing but a typescript class that has @injectable decorator,
//so that we can use it with Dependency Injection
