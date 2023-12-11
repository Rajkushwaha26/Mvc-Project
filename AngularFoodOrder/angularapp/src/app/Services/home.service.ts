import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  getAll(): import("../FoodOrder/Models/food").Food[] {
    throw new Error('Method not implemented.');
  }

  private url='';

  constructor(private http:HttpClient) { }
  httpoptions={headers:new HttpHeaders({ 'Context-type': 'application-type' })}

  
}
