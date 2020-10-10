import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ScrawlerResultComponent } from './scrawler-result.component';

describe('ScrawlerResultComponent', () => {
  let component: ScrawlerResultComponent;
  let fixture: ComponentFixture<ScrawlerResultComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ScrawlerResultComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScrawlerResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
