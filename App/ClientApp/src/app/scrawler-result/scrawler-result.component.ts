import { Component, OnInit } from '@angular/core';
import { ScrawlService } from "../scrawler/scrawl.service";

@Component({
  selector: 'app-scrawler-result',
  templateUrl: './scrawler-result.component.html',
  styleUrls: ['./scrawler-result.component.css']
})
export class ScrawlerResultComponent implements OnInit {

    public returnResult: string;

    constructor(ss: ScrawlService) { 
        this.returnResult = ss.getInput();
    }

    ngOnInit() {
    }

}
