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
        let header: Headers = new Headers();
        header.set("Authentication", "Bearer " + this.tokenService.getToken);
        let events: Promise<Event[]> = this.http.get(this.tokenService.isLoggedIn ? this.URL : this.URL_ANON, header)
               .toPromise()
               .then(response => response.json() as Event[])
               .catch(this.handleError);

        if (events == undefined) {
            
        }

        return events;
    }

    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}