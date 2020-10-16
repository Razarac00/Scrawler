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

    constructor(private srs: ScrawlService, private router: Router) { 

    }

    ngOnInit() {
        this.returnResult = this.srs.getInput();
        this.rebuiltResult = this.srs.finalOutput;
    }

    public goBack()
    {
        this.router.navigateByUrl('scrawler');
    }

}
