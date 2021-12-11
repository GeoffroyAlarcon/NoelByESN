import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { Person } from "../models/Person";
@Injectable({
  providedIn: 'root',
})
export class PersonService {
 
  constructor(private _httpClient:HttpClient, _router:Router) {

  }

  public AddPerson(person: Person): void {
     this._httpClient.post <Person>("", person);
  }
  public DeletePerson(person: Person): void {
    this._httpClient.delete<Person>("" +person.id);
  }
  public UpdatePerson(person: Person): void {
    this._httpClient.put("", person);
  }
  public GellAllPeople(): Observable<Array<Person>> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json'
    })
    return this._httpClient.get < Array<Person>>("https://localhost:44358/getAllPerson", { headers: headers });
  }
}
