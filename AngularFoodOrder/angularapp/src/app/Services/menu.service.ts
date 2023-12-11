import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  constructor() { }

  getAllImage():string[]{
    return[
      'assets/images/p-1.jpg',
      'assets/images/p-2.jpg',
      'assets/images/p-3.jpg',
      'assets/images/p-4.jpg',
      'assets/images/p-5.jpg',
      'assets/images/p-6.jpg'
    ]
  }
}
