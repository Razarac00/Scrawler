import { TestBed } from '@angular/core/testing';

import { ScrawlService } from './scrawl.service';

describe('ScrawlService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ScrawlService = TestBed.get(ScrawlService);
    expect(service).toBeTruthy();
  });
});
