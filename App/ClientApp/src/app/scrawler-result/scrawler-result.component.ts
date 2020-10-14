import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ScrawlService } from '../scrawler/scrawl.service';
import { ScrawlResultService } from './scrawl-result.service';

@Component({
  selector: 'app-scrawler-result',
  templateUrl: './scrawler-result.component.html',
  styleUrls: ['./scrawler-result.component.css']
})
export class ScrawlerResultComponent implements OnInit {

    public returnResult: string;
    public rebuiltResult: string;

    constructor(srs: ScrawlService, private router: Router) { 
        this.returnResult = srs.getInput();
        this.rebuiltResult = srs.scrawledText.RebuiltString;
    }

    ngOnInit() {
    }

    public goBack()
    {
        this.router.navigateByUrl('scrawler');
    }

}
