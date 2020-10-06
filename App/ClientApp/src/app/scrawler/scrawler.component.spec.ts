import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ScrawlerComponent } from './scrawler.component';

describe('ScrawlerComponent', () => {
  let component: ScrawlerComponent;
  let fixture: ComponentFixture<ScrawlerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ScrawlerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ScrawlerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
