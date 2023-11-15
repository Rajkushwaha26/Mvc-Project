import { Injectable} from '@angular/core';
import { NgForm } from '@angular/forms';



@Injectable({
  providedIn:'root'
})
export class HelloworldService {

  sayHelloworld(){
    return "Helloworld";
  }
  

}
