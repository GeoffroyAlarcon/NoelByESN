import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GenarateCouplesComponent } from './genarate-couples.component';

describe('GenarateCouplesComponent', () => {
  let component: GenarateCouplesComponent;
  let fixture: ComponentFixture<GenarateCouplesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GenarateCouplesComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GenarateCouplesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
