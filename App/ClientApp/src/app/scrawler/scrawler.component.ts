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
    }

    public submission()
    {
        this.insertRecord(this.returnOutput);
        // this.ss.setInput(this.returnOutput.value);
        // this.router.navigateByUrl('scrawler-result');
    }

    insertRecord(returnOutput: FormControl) {
        this.ss.setInput(returnOutput.value).subscribe(res => {
            this.refreshComponent(returnOutput);
            this.ss.getInput();
        }, err => { console.error(err); }
        );
    }
    

}
