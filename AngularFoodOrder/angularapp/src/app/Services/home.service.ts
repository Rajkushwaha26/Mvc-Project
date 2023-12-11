import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Food } from '../FoodOrder/Models/food';
import { sample_data } from 'src/assets/data';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  

  constructor() { }
  getAll():Food[]{
    return sample_data
  }
  

  
}
