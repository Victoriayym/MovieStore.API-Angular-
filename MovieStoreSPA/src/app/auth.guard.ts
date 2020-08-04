import { LoginService } from './core/services/login.service';
import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';
import { Router} from '@angular/router';
@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    this.loginService.IsLoggedIn.subscribe((r)=>{
      if (r)
      {
        return true;}
      else
      {
        console.log("sss");
        this.router.navigate(["login"]);
        return false;
      } 
    });
    return true;
      
  }
  constructor(private loginService:LoginService, private router:Router){

  }
  
}
