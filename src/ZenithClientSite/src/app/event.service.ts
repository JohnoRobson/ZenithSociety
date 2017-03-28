import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Event } from './event';

@Injectable()
export class EventService {

    private URL = 'http://zenith-society-nj-core.azurewebsites.net/api/events';  // URL to web api
    //private URL = 'http://localhost:5000/api/events';

    constructor(private http: Http) { }

    getEvents(): Promise<Event[]> {
        let events: Promise<Event[]> = this.http.get(this.URL)
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