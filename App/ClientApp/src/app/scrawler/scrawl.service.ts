import { Injectable, Inject } from '@angular/core';
import { from } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Scrawltext } from "../interfaces/scrawltext";

@Injectable({
  providedIn: 'root'
})
export class ScrawlService {

    private inputString: string;
    private basePath: string;

    public scrawledText : Scrawltext;
    public finalOutput : string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.basePath = baseUrl;
        this.http.get<Scrawltext>(this.basePath + 'numtotextservice').subscribe(result => {
            this.scrawledText = result;
          }, error => console.error(error));
    }

    public getInput() { 
        return this.finalOutput; 
    }

    public setInput(fromForm: string) {
        this.scrawledText.originalString = fromForm;
        console.log("Set Input form has " + fromForm);

        this.inputString = fromForm; 

        return this.http.post<Scrawltext>(this.basePath + 'numtotextservice', this.scrawledText);
    }
}
