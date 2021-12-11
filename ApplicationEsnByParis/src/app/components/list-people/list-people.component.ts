import { Component, OnInit } from '@angular/core';
import { Person } from '../../models/Person';
import { PersonService } from '../../Services/PersonService';

@Component({
  selector: 'app-list-people',
  templateUrl: './list-people.component.html',
  styleUrls: ['./list-people.component.scss']
})
export class ListPeopleComponent implements OnInit {

  constructor(private _personService: PersonService) { }
 public people: Person[] = []

  ngOnInit(): void {
    this._personService.GellAllPeople().subscribe(res => {
      console.log(res);
    })

  }

}
