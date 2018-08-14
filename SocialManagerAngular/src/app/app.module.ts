import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HeaderComponent } from './_layout/header/header.component';
import { SideBarComponent } from './_layout/side-bar/side-bar.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { AngularMatrialModule } from './angular.matrial.module';
@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SideBarComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AngularMatrialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
