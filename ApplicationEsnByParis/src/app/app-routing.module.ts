import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListPeopleGiftComponent } from './components/list-people-gift/list-people-gift.component';
import { ListPeopleComponent } from './components/list-people/list-people.component';

const routes: Routes = [{ path: "", component: ListPeopleComponent },
{path:"listpeoplegift", component:ListPeopleGiftComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
