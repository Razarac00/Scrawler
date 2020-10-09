import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { Form, FormControl } from '@angular/forms';

@Component({
  selector: 'app-scrawler',
  templateUrl: './scrawler.component.html',
  styleUrls: ['./scrawler.component.css']
})
export class ScrawlerComponent { //implements OnInit {

    public returnOutput = new FormControl('');
    // private readonly baseUrl: string;

    // constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) 
    // { 
    //     baseUrl = this.baseUrl;
    // }
    constructor() {}

    // ngOnInit() {
    // }
    // public submission()
    // {
        // this.http.get<string>(this.baseUrl + 'scrawler').subscribe(result => {
        //     this.returnOutput = result;
        //   }, error => console.error(error));
    // }

}
