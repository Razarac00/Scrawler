import { Injectable } from '@angular/core';
import { Scrawltext } from "../interfaces/scrawltext";

@Injectable({
  providedIn: 'root'
})
export class ScrawlResultService {

    public scrawltext: Scrawltext;

    constructor() { }
}
