import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PersonnesComponent } from './personnes/personnes.component';
import { PersonneComponent } from './personne/personne.component';
import { PersonneAddEditComponent } from './personne-add-edit/personne-add-edit.component';
import { PersonneService } from './services/personne.service';

@NgModule({
  declarations: [
    AppComponent,
    PersonnesComponent,
    PersonneComponent,
    PersonneAddEditComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [
    PersonneService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
