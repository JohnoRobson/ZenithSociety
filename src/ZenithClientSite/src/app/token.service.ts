import { Injectable } from '@angular/core';

@Injectable()
export class TokenService {
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
}