import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Component, OnInit } from '@angular/core';
import { TestBed } from '@angular/core/testing';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Person } from '../../models/Person';
import { PersonService } from '../../Services/PersonService';

@Component({
  selector: 'app-list-people',
  templateUrl: './list-people.component.html',
  styleUrls: ['./list-people.component.scss']
})
export class ListPeopleComponent implements OnInit {

  constructor(private _personService: PersonService, private formBuilder: FormBuilder) { }
 
  people: Person[] = []
  personForm: FormGroup = this.formBuilder.group({
    lastName: ["", Validators.required],
    firstName: ["", Validators.required]
  });
  IsSucess: boolean = false;
  isDanger: boolean = false;
  modeUpdateBool:boolean =false;
  modeUpdateInt: number = 0;
  firstNameByPersonId:string=""
  lastNameByPersonId:string=""
  ngOnInit(): void {
    this._personService.GellAllPeople().subscribe(res => {
      this.people = res;
    })
  }

  addPerson(): void {
    let person: Person = new Person();
    let formValue = this.personForm.value;
    person.lastName = formValue["lastName"];
    person.firstName = formValue["firstName"];
    this._personService.AddPerson(person).subscribe(res => {
      if (res == true) {
        this.personForm.reset();
        this.IsSucess=  true;
        this.isDanger = false;
      }
      else {
        this.isDanger = true;
        this.IsSucess = false;
      }
      this.ngOnInit();
    })
  }
modeUpdate(personId:number | undefined):void{
  if(!this.modeUpdateBool) {
  this.modeUpdateBool =true;
  this.modeUpdateInt = personId ??0;
  this.firstNameByPersonId= this.people.filter(elt => elt.id == personId!).map(elt=>elt.firstName).toString();
this.lastNameByPersonId= this.people.filter(elt => elt.id == personId!).map(elt=>elt.lastName).toString();

const trash = window.document.getElementsByClassName("trash")!
const edit = window.document.getElementsByClassName("edit_div");
for(var x = 0; x<edit.length; x++){
  edit[x].innerHTML="";
}
}
}

updatePerson(ngForm:NgForm):void{
  let formValue = ngForm.value;
let person:Person = new Person();
person.id = formValue["id"];
person.firstName= formValue["firstName"];
person.lastName= formValue["lastName"];
this._personService.UpdatePerson(person).subscribe(elt =>{
  this.modeUpdateBool = false;
  this;this.modeUpdateInt = 0;
this.ngOnInit();

})
}

deletePerson(personId:number |undefined):void{

this._personService.DeletePerson(personId ?? 0).subscribe(res=>{
if(res == true){
this.ngOnInit();
}
else{
 window.alert("problème lors de la supression du participant") 
}
});
}

}
