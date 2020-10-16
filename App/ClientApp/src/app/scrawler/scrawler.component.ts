import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
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
export class ScrawlerComponent implements OnInit { 

    public returnOutput = new FormControl('');
    public orig: string;
    public rebu: string;

    constructor(private ss: ScrawlService, private router: Router) 
    { 
    }

    ngOnInit() {
        this.refreshComponent();
    }

    refreshComponent(returnOutput?: FormControl) {
        if (returnOutput != null) {
            returnOutput.reset;
        }
        console.log("Scrawled text on refresh: " + this.ss.scrawledText);
        this.ss.scrawledText = {
            OriginalString: "",
            RebuiltString: ""
        }
    }

    public async submission()
    {
        console.log("submission " + this.returnOutput.value);
        this.insertRecord(this.returnOutput);
        // this.ss.setInput(this.returnOutput.value);
        // this.router.navigateByUrl('scrawler-result');
    }

    async insertRecord(returnOutput: FormControl) {
        console.log("is the return output even here " + this.returnOutput.value);
        let finalr = await this.ss.setInput(this.returnOutput.value).toPromise();
        console.log("Please answer: " + finalr.OriginalString);
        await this.ss.setInput(this.returnOutput.value).toPromise().then(res => {
            console.log("insertRecord sub " + res.OriginalString + " and ro: " + this.returnOutput);
            console.log("from the form while inserting: " + this.returnOutput.value);
            this.refreshComponent(this.returnOutput);
            this.ss.getInput();
        }, err => { console.error(err); }
        );
    }
    

}
