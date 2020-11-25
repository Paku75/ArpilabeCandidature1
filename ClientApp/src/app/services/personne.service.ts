import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { retry, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Personne } from '../models/personne';

@Injectable({
  providedIn: 'root'
})
export class PersonneService {

  myAppUrl: string;
  myApiUrl: string;
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json; charset=utf-8'
    })
  };

  constructor(private http: HttpClient) {
    this.myAppUrl = environment.appUrl;
    this.myApiUrl = 'api/Personnes';
   }

   getPersonnes(): Observable<Personne[]> {
     return this.http.get<Personne[]>(this.myAppUrl + this.myApiUrl)
     .pipe(
       retry(1),
       catchError(this.errorHandler)
     );
   }

   getPersonne(id: number): Observable<Personne> {
    return this.http.get<Personne>(this.myAppUrl + this.myApiUrl + id)
    .pipe(
      retry(1),
      catchError(this.errorHandler)
    );
}

   savePersonne(Personne: any): Observable<Personne> {
    return this.http.post<Personne>(this.myAppUrl + this.myApiUrl, JSON.stringify(Personne), this.httpOptions)
    .pipe(
      retry(1),
      catchError(this.errorHandler)
    );
}

   updatePersonne(id: number, Personne: any): Observable<Personne> {
    return this.http.put<Personne>(this.myAppUrl + this.myApiUrl + id, JSON.stringify(Personne), this.httpOptions)
    .pipe(
      retry(1),
      catchError(this.errorHandler)
    );
}

   deletePersonne(id: number): Observable<Personne> {
    return this.http.delete<Personne>(this.myAppUrl + this.myApiUrl + id)
    .pipe(
      retry(1),
      catchError(this.errorHandler)
    );
}

   errorHandler(error: any) {
    let errorMessage = '';
    if (error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    console.log(errorMessage);
    return throwError(errorMessage);
  }
}
