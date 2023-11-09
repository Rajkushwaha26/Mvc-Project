import {Component} from "@angular/core";

@Component({
    selector:'first-component',
    templateUrl: './first.component.html'
})
export class FirstComponent
{
    c
    greet:string= "Hello";
    twowayvariavle:string="Default value";

    save(event){
        console.log(event.target.value)
    }

}