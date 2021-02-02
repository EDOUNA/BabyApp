import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChilderenComponent } from './childeren.component';

describe('ChilderenComponent', () => {
  let component: ChilderenComponent;
  let fixture: ComponentFixture<ChilderenComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChilderenComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChilderenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
