import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListPeopleGiftComponent } from './list-people-gift.component';

describe('ListPeopleGiftComponent', () => {
  let component: ListPeopleGiftComponent;
  let fixture: ComponentFixture<ListPeopleGiftComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListPeopleGiftComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListPeopleGiftComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
