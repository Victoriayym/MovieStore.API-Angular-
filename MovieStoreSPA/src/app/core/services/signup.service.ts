import { Observable } from 'rxjs';
import { Register } from './../../shared/models/register';
import { ApiService } from './api.service';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SignupService {

  constructor(private apiService:ApiService) { }
    RegisterUser(register: Register):Observable<Register>{
      return this.apiService.create('account/register', register);

    }

}
