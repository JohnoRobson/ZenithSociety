import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app.component';
import { EventService } from './event.service';
import { EventViewComponent } from './event-view.component';
import { EventEntryComponent } from './event-entry.component';
import { LoginComponent } from './login.component';
import { RegisterComponent } from './register.component';
import { TokenService } from './token.service';

@NgModule({
  declarations: [
    AppComponent,
    EventViewComponent,
    EventEntryComponent,
    LoginComponent,
    RegisterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule.forRoot([
    {
      path: '', redirectTo: '/events', pathMatch: 'full'
    },
    {
      path: 'events', component: EventViewComponent
    },
    {
      path: 'login', component: LoginComponent
    },
    {
      path: 'register', component: RegisterComponent
    },
    {
      path: 'events/:id', component: EventViewComponent,  canActivate: [TokenService]
    }
  ])
  ],
  providers: [ EventService, TokenService ],
  bootstrap: [ AppComponent ],
})

export class AppModule { }
