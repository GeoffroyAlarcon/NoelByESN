import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListPeopleComponent } from './components/list-people/list-people.component';
import { NavComponent } from './components/Share/nav/nav.component';
import { FooterComponent } from './components/Share/footer/footer.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HeaderComponent } from './components/Share/header/header.component';
import { HomePageComponent } from './home-page/home-page.component';
import { ListPeopleGiftComponent } from './components/list-people-gift/list-people-gift.component';
@NgModule({
  declarations: [
    AppComponent,
    ListPeopleComponent,
    NavComponent,
    FooterComponent,
    HeaderComponent,
    HomePageComponent,
    ListPeopleGiftComponent
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
