import { Injectable } from '@angular/core';
import {AdalService} from 'adal-angular4';
import { authSettings } from './auth.service.config';
import { Router } from '@angular/router';
import {} from 'hellojs';
@Injectable()
export class AuthService {

  constructor(
    protected service: AdalService,
    private router: Router
    ) { }

  init() {
    authSettings.redirectUri = location.origin;
    this.service.handleWindowCallback();
  }

  login() {
    if (!this.service.userInfo.authenticated) {
      this.service.login();
    } else {
      this.router.navigate(['/news']);
    }
  }

  logout() {
    this.service.logOut();
  }
    get UserData(): adal.User {
      return this.service.userInfo;
    }
}
