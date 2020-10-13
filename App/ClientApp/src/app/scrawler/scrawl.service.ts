import { Injectable, Inject } from '@angular/core';
import { from } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ScrawlService {

    private inputString: string;
    private basePath: string;

    public scrawledText : ScrawlText;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.basePath = baseUrl;
        this.http.get<ScrawlText>(this.basePath + 'numtotextservice').subscribe(result => {
            this.scrawledText = result;
          }, error => console.error(error));
    }

    public getInput() { 
        return this.inputString + " " + this.scrawledText.rebuiltString + " " + this.scrawledText.originalString; 
    }

    public setInput(fromForm: string) {
        this.scrawledText.originalString = fromForm;
        this.http.post<ScrawlText>(this.basePath + 'numtotextservice', this.scrawledText).subscribe();
        this.inputString = fromForm; 
    }
}

interface ScrawlText {
    originalString: string;
    rebuiltString: string;
}
