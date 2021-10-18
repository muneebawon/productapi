import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule } from '@angular/common/http';
import {Observable } from 'rxjs';
import { environment } from './../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  constructor(private http:HttpClient) {
    console.log(environment.apiUrl);
   }

  public getProductList():Observable<any[]> {
    console.log("getProductList() -> Loading")
    return this.http.get<any>(environment.apiUrl);
  }
}
