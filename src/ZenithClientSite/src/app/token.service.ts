import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot, CanActivate } from '@angular/router';

import {Observable} from 'rxjs/Observable';

@Injectable()
export class TokenService implements CanActivate {
    TOKEN_NAME: string = "zenithToken";

    getToken(): string {
        let token:string = localStorage.getItem(this.TOKEN_NAME);

        if (token == undefined) {
            return "";
        }

        return token;
    }

    setToken(token:string):void {
        localStorage.setItem(this.TOKEN_NAME, token);
    }

    isLoggedIn():boolean {
        return this.getToken().length > 0;
    }

    logOut(): void {
        localStorage.setItem(this.TOKEN_NAME, "");
    }

    canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Observable<boolean>|Promise<boolean>|boolean {
    return this.isLoggedIn();
  }
}