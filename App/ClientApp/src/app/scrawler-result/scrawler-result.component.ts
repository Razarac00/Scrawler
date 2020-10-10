import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-scrawler-result',
  templateUrl: './scrawler-result.component.html',
  styleUrls: ['./scrawler-result.component.css']
})
export class ScrawlerResultComponent implements OnInit {

    public returnResult: string;

    constructor() { }

    ngOnInit() {
    }

    receiveResult($event) {
        this.returnResult = $event;
    }

}
