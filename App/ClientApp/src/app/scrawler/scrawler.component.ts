import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { Form, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { ScrawlService } from "./scrawl.service";

@Component({
  selector: 'app-scrawler',
  templateUrl: './scrawler.component.html',
  styleUrls: ['./scrawler.component.css']
})
export class ScrawlerComponent { 

    public returnOutput = new FormControl('');

    constructor(private ss: ScrawlService, private router: Router) 
    { 
    }

    public submission()
    {
        this.ss.setInput(this.returnOutput.value).then(res => {
            console.log("Consumed on submission: " + res.OriginalString);

            this.router.navigateByUrl('scrawler-result');
        }).catch(err => {
            console.log("why are we here? Just to suffer?"); 
            console.error(err); 
        }
        );
        
    }
    

}
