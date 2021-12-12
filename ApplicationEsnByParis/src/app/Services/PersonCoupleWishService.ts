import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import { PersonCoupleWish } from "../models/PersonCoupleWish";
import { BaseService } from "./baseService";

@Injectable({
    providedIn: 'root',
})
export class PersonCoupleWishService extends BaseService {

    constructor(private _httpClient: HttpClient, _router: Router) {
        super();
    }

    public findAllPeopleWish(): Observable<Array<PersonCoupleWish>>{
        return this._httpClient.get<Array<PersonCoupleWish>>(this.serverString+"/FindAllPairPeopleWish")
    }
}