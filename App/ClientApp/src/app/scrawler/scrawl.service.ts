import { Injectable, Inject } from '@angular/core';
import { from } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ScrawlService {

    private inputString: string;

    public scrawledText : ScrawlText;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      http.get<ScrawlText>(baseUrl + 'numtotextservice').subscribe(result => {
        this.scrawledText = result;
      }, error => console.error(error));
    }

    public getInput() { 
        return this.inputString; 
    }

    public setInput(fromForm: string) { 
        this.inputString = fromForm; 
    }
}

interface ScrawlText {
    originalString: string;
    rebuiltString: string;
}
