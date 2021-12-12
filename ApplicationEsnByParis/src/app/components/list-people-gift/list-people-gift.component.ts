import { Component, OnInit } from '@angular/core';
import { PersonCoupleWish } from 'src/app/models/PersonCoupleWish';
import { PersonCoupleWishService } from 'src/app/Services/PersonCoupleWishService';

@Component({
  selector: 'app-list-people-gift',
  templateUrl: './list-people-gift.component.html',
  styleUrls: ['./list-people-gift.component.scss']
})
export class ListPeopleGiftComponent implements OnInit {
personCoupleWish:PersonCoupleWish[]= []

  constructor( private _personCoupleWishService:PersonCoupleWishService) { }

  ngOnInit(): void {
  this._personCoupleWishService.findAllPeopleWish().subscribe(res =>{
    this.personCoupleWish= res;
  })
  }
generateList(){
  
}
}
