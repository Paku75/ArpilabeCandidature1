import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PersonneAddEditComponent } from './personne-add-edit.component';

describe('PersonneAddEditComponent', () => {
  let component: PersonneAddEditComponent;
  let fixture: ComponentFixture<PersonneAddEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PersonneAddEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PersonneAddEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
