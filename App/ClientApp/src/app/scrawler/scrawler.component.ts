import { HttpClient } from '@angular/common/http';
import { Component, Inject, Output, EventEmitter } from '@angular/core';
import { Form, FormControl } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-scrawler',
  templateUrl: './scrawler.component.html',
  styleUrls: ['./scrawler.component.css']
})
export class ScrawlerComponent { 

    public returnOutput = new FormControl('');
    private baseUrl: string;
    @Output() resultEvent = new EventEmitter<string>();

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string, private router: Router) 
    { 
        baseUrl = this.baseUrl;
    }

    public submission()
    {
        // this.returnOutput.setValue('anything');
        // this.http.get<string>(this.baseUrl + 'scrawler').subscribe(result => {
        //     this.returnOutput.setValue(result);
        //   }, error => console.error(error));
        this.resultEvent.emit(this.returnOutput.value);
        this.router.navigateByUrl('scrawler-result');
    }
    

}
