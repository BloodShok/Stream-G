import { CanActivate, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';
import { Injectable } from '@angular/core';

@Injectable()
export class AuthorizationGuard implements CanActivate {
    constructor(
        private authService: AuthService,
        private router: Router
    ) { }

    canNavigatRoute: boolean;
    canActivate(): boolean {
        const logedInUser = this.authService.UserData;

        if (!this.isAuthenticated(logedInUser)) {
            this.router.navigate(['/login']);
            return false;
        }
        return true;
    }
   isAuthenticated(user: adal.User): boolean {
       return user.authenticated;
   }

}
