import { Injectable, Inject } from '@angular/core';
import { from, Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Scrawltext } from "../interfaces/scrawltext";

@Injectable({
  providedIn: 'root'
})
export class ScrawlService {

    private inputString: string;
    private stringifiedData: any;

    public scrawledText : Scrawltext;
    public outputString: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

    }

    public getInput() { 
        this.http.get<Scrawltext>(this.baseUrl + 'numtotextservice').toPromise().then(result => {
            console.log("in get input we have: " + result);
            this.scrawledText = result as Scrawltext;
          }, err => { console.error(err); }
          );
    }

    public setInput(fromForm: string) {  
        console.log("form value is " + fromForm); 
        this.scrawledText = {
            OriginalString: fromForm,
            RebuiltString: ""
        };
        this.stringifiedData = JSON.stringify(this.scrawledText);
        console.log("stringify: " + this.stringifiedData);   
        return this.http.post<Scrawltext>(this.baseUrl + 'numtotextservice', this.stringifiedData, this.setupHeaders());
    }

    private setupHeaders() {
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        const options = {
            headers: new HttpHeaders({
                'Content-Type': 'application/json'
            }),
            body: {}
        } 
        return options;
    }


}
