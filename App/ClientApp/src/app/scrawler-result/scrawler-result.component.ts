import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ScrawlService } from '../scrawler/scrawl.service';
import { ScrawlResultService } from './scrawl-result.service';
import { Scrawltext } from "../interfaces/scrawltext";

@Component({
  selector: 'app-scrawler-result',
  templateUrl: './scrawler-result.component.html',
  styleUrls: ['./scrawler-result.component.css']
})
export class ScrawlerResultComponent implements OnInit {

    public returnResult: string;
    public rebuiltResult: string;

    constructor(private srs: ScrawlService, private router: Router) { 
        // this.returnResult = srs.getInput();
        // this.rebuiltResult = srs.scrawledText.RebuiltString;
    }

    ngOnInit() {
        this.srs.getInput();
        console.log("In scrawl result, " + this.srs.scrawledText.OriginalString);
    }

    public goBack()
    {
        this.router.navigateByUrl('scrawler');
    }

}
