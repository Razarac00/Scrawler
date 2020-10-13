import { Injectable } from '@angular/core';
import { from } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ScrawlService {

  private inputString: string;

  public getInput() { return this.inputString; }

  public setInput(fromForm: string) { this.inputString = fromForm; }
}
