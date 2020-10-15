import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Form, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { ScrawlService } from "./scrawl.service";
import { from, Observable } from 'rxjs';
import { Scrawltext } from '../interfaces/scrawltext';

@Component({
  selector: 'app-scrawler',
  templateUrl: './scrawler.component.html',
  styleUrls: ['./scrawler.component.css']
})
export class ScrawlerComponent { 

    public returnOutput = new FormControl('');
    public orig: string;
    public rebu: string;
    public st$: Observable<Scrawltext>;

    constructor(private ss: ScrawlService, private router: Router) 
    { 
    }

    public async submission()
    {
        const _this = this;
        this.st$ = this.ss.setInput(this.returnOutput.value);
        console.log(this.st$);
        await this.st$.toPromise().then(res => {
            console.log(res);
            this.rebu = res.RebuiltString;
            this.applyIt(res.RebuiltString);
            _this.rebu = res.RebuiltString;
            console.log(_this.rebu);
        });
        this.orig = this.ss.scrawledText.OriginalString;
        console.log(_this.rebu);
        // this.rebu = this.ss.scrawledText.RebuiltString;
        // this.router.navigateByUrl('scrawler-result');
    }

    applyIt(s: string) {
        this.rebu = s;
        console.log("made it here " + s);
    }
    

}
