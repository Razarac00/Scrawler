import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';

@Component({
  selector: 'app-scrawler',
  templateUrl: './scrawler.component.html',
  styleUrls: ['./scrawler.component.css']
})
export class ScrawlerComponent { //implements OnInit {

    public returnOutput: string;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) 
    { 
        http.get<string>(baseUrl + 'scrawler').subscribe(result => {
            this.returnOutput = result;
          }, error => console.error(error));
    }

    // ngOnInit() {
    // }



}
