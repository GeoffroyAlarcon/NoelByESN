import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { Person } from "../models/Person";
import { BaseService } from "./baseService";
@Injectable({
  providedIn: 'root',
})
export class PersonService extends BaseService {

  constructor(private _httpClient: HttpClient, _router: Router) {
    super();
  }

  public AddPerson(person: Person): Observable<boolean> {
    return this._httpClient.post<boolean>(this.serverString + "/addperson", person);
  }
  public DeletePerson(personId: number): Observable<boolean> {
    return this._httpClient.delete<boolean>(this.serverString + "/deleteperson/" + personId);
  }
  public UpdatePerson(person: Person): Observable<boolean> {
    return this._httpClient.put<boolean>(this.serverString + "/updateperson", person);
  }
  public GellAllPeople(): Observable<Array<Person>> {
    const headers = new HttpHeaders({
      'Content-Type': 'application/json'
    })
    return this._httpClient.get<Array<Person>>(this.serverString + "/getAllPerson", { headers: headers });
  }
}
