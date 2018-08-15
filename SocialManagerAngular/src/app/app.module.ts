import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { HeaderComponent } from './_layout/header/header.component';
import { SideBarComponent } from './_layout/side-bar/side-bar.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { AngularMatrialModule } from './angular-matrial/angular.matrial.module';
import { UserSetingsComponent } from './components/user-setings/user-setings.component';
import { ClickOutsideModule } from 'ng-click-outside';
import { LoginComponent } from './pages/login/login.component';
import { RouterModule } from '@angular/router';
import { AppRouteModule } from './app-route.module';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SideBarComponent,
    UserSetingsComponent,
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AngularMatrialModule,
    ClickOutsideModule,
    AppRouteModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
