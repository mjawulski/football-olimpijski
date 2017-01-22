/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { AtendeesComponent } from './atendees.component';

describe('AtendeesComponent', () => {
  let component: AtendeesComponent;
  let fixture: ComponentFixture<AtendeesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AtendeesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AtendeesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
