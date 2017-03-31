import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Event } from './event';
import { Activity } from './activity';
import { TokenService } from './token.service';

@Injectable()
export class EventService {

    private URL = 'http://zenith-society-nj-core.azurewebsites.net/api/events';  // URL to web api
    private URL_ANON = 'http://zenith-society-nj-core.azurewebsites.net/api/events/anon'; 
    private activities: Map<number, Activity> = new Map<number, Activity>();

    constructor(private http: Http, private tokenService: TokenService) { }

    getEvents(): Promise<Event[]> {
        let headers: Headers = new Headers();
        headers.append('Access-Control-Allow-Headers', 'Content-Type');
        headers.append('Access-Control-Allow-Headers', 'X-Auth-Token');
        headers.append('Access-Control-Allow-Headers', 'Origin');
        headers.append('Access-Control-Allow-Headers', 'Authorization');
        headers.append('Authorization', 'Bearer ' + this.tokenService.getToken());
        headers.append('Accept', 'application/json');
        headers.append("Content-Type", "application/x-www-form-urlencoded");
        this.http.get(this.tokenService.isLoggedIn() ? this.URL : this.URL_ANON, headers).toPromise().then(response => console.log(response));
        let events: Promise<Event[]> = this.http.get(this.tokenService.isLoggedIn() ? this.URL : this.URL_ANON, headers)
               .toPromise()
               .then(response => response.json())
               .catch(this.handleError);
        if (events == undefined) {
            
        }

        return events;
    }

    private convertToEvents(input: JSON): Event[] {
        console.log(input);
        return null;
    }

    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}