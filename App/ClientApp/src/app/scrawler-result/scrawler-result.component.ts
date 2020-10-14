import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { ScrawlService } from "../scrawler/scrawl.service";

@Component({
  selector: 'app-scrawler-result',
  templateUrl: './scrawler-result.component.html',
  styleUrls: ['./scrawler-result.component.css']
})
export class ScrawlerResultComponent implements OnInit {

    public returnResult: string;
    public rebuiltResult: string;

    constructor(ss: ScrawlService, private router: Router) { 
        this.returnResult = ss.getInput();
        this.rebuiltResult = ss.scrawledText.RebuiltString;
    }

    ngOnInit() {
    }

    public goBack()
    {
        this.router.navigateByUrl('scrawler');
    }

}
