import { Injectable, Inject } from '@angular/core';
import { Scrawltext } from "../interfaces/scrawltext";
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ScrawlResultService {
    private basePath: string;

    public scrawledText: Scrawltext;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { 
        this.basePath = baseUrl;
        this.http.get<Scrawltext>(this.basePath + 'numtotextservice').subscribe(result => {
            this.scrawledText = result;
          }, error => console.error(error));
    }

    public getInput() { 
        return this.scrawledText.RebuiltString + " " + this.scrawledText.OriginalString; 
    }
}
