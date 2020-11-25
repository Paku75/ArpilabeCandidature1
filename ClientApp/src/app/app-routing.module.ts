import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PersonneAddEditComponent } from './personne-add-edit/personne-add-edit.component';
import { PersonneComponent } from './personne/personne.component';
import { PersonnesComponent } from './personnes/personnes.component';

const routes: Routes = [
  { path: '', component: PersonnesComponent, pathMatch: 'full' },
  { path: 'blogpost/:id', component: PersonneComponent },
  { path: 'add', component: PersonneAddEditComponent },
  { path: 'blogpost/edit/:id', component: PersonneAddEditComponent },
  { path: '**', redirectTo: '/' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
