import { TestBed } from '@angular/core/testing';

import { ScrawlResultService } from './scrawl-result.service';

describe('ScrawlResultService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ScrawlResultService = TestBed.get(ScrawlResultService);
    expect(service).toBeTruthy();
  });
});
