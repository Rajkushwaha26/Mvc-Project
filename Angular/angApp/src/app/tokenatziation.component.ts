import {Component} from "@angular/core";
import {HttpClient} from "angular/common/http";
import { error } from "console";

@Component({
    selector:'token-demo',
    template:`<h1>Token Demo</h1>`
})

export class TokenDemo
{HttpHeaders= new HttpHeader
    constructor(private http:HttpClient)
    {
        let httpheaders:HttpHeaders = new this.HttpHeaders
        ({
            Accept:'application/json'
        });
        this.http.post<Idata>("https://8080-cfdbdbcbdfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/api/StudentApi",
        {name:'user1',password:'password'},
        {headers:httpheaders})
        .subscribe(token=>
            {console.log(token); this._token=token},
            error=>{
                console.log(error);
            })

            save(){

            }
        

    }
}

interface Idata{
    name:string
    password:string
}