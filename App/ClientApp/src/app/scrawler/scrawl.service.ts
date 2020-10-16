import { Injectable, Inject } from '@angular/core';
import { from, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Scrawltext } from "../interfaces/scrawltext";

@Injectable({
  providedIn: 'root'
})
export class ScrawlService {

    private inputString: string;

    public scrawledText : Scrawltext;
    public outputString: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

    }

    public getInput() { 
        this.http.get<Scrawltext>(this.baseUrl + 'numtotextservice').toPromise().then(result => {
            this.scrawledText = result as Scrawltext;
          });
    }

    public setInput(fromForm: string) {        
        return this.http.post<Scrawltext>(this.baseUrl + 'numtotextservice', fromForm);
    }


}
