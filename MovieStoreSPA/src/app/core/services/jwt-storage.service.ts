import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class JwtStorageService {

  // localstorage and sessionstorage were introduced in HTML 5
  // cookies were there since the begining of HTML
  getToken(): string {
    return localStorage.getItem('token');
  }
  saveToken(token: string) {
    localStorage.setItem('token', token);
  }
  destroyToken() {
    localStorage.removeItem('token');
  }
}
