import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { PersonneService } from '../services/personne.service';
import { Personne } from '../models/personne';

@Component({
  selector: 'app-personnes',
  templateUrl: './personnes.component.html',
  styleUrls: ['./personnes.component.scss']
})
export class PersonnesComponent implements OnInit {
  personnes$: Observable<Personne[]>
  
  constructor(private personneService: PersonneService) { 

  }

  ngOnInit() {
    this.loadPersonnes();
  }

  loadPersonnes() {
    this.personnes$ = this.personneService.getPersonnes();
  }

  delete(id) {
    const ans = confirm('Voulez vous supprimer la personne num: ' + id);
    if (ans) {
      this.personneService.deletePersonne(id).subscribe((data) => {
        this.loadPersonnes();
      });
    }
  }
}
