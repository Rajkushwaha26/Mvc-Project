import {Component} from "@angular/core";

@Component({
    selector:'first-component',
    templateUrl: './first.component.html'
})
export class FirstComponent
{
    doesExists=true;
    values="save";
    colorStyle:string = "color:blue;";
    greet:string= "Hello";
    twowayvariavle:string="Default value";

    save(event){
        console.log(event.target.value)
    }

}