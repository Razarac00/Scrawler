import { Injectable, Inject } from '@angular/core';
import { from, Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { Scrawltext } from "../interfaces/scrawltext";

@Injectable({
  providedIn: 'root'
})
export class ScrawlService {

    private inputString: string;
    private basePath: string;

    public scrawledText : Scrawltext;
    public outputString: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.basePath = baseUrl;
        this.http.get<Scrawltext>(this.basePath + 'numtotextservice').toPromise().then(result => {
            this.scrawledText = result;
          }, error => console.error(error));
    }

    public getInput() { 
        // this.http.get<Scrawltext>(this.basePath + 'numtotextservice').toPromise().then(result => 
        //     this.scrawledText = result);
        return this.inputString + " " + this.scrawledText.RebuiltString + " " + this.scrawledText.OriginalString; 
    }

    public setInput(fromForm: string) {
        this.scrawledText.OriginalString = fromForm;
        this.inputString = fromForm; 

        this.http.post<Scrawltext>(this.basePath + 'numtotextservice', this.scrawledText).subscribe(res => {
            this.scrawledText = res;
            this.outputString = res.RebuiltString;
        }); //toPromise().then

        return this.http.post<Scrawltext>(this.basePath + 'numtotextservice', this.scrawledText);
        
    }


}
