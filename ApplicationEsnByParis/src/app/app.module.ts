import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddPersonComponent } from './components/add-person/add-person.component';
import { ListPeopleComponent } from './components/list-people/list-people.component';
import { GenarateCouplesComponent } from './components/genarate-couples/genarate-couples.component';
import { NavComponent } from './components/Share/nav/nav.component';
import { FooterComponent } from './components/Share/footer/footer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HeaderComponent } from './components/share/header/header.component';
import { HomePageComponent } from './home-page/home-page.component';
@NgModule({
  declarations: [
    AppComponent,
    AddPersonComponent,
    ListPeopleComponent,
    GenarateCouplesComponent,
    NavComponent,
    FooterComponent,
    HeaderComponent,
    HomePageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
