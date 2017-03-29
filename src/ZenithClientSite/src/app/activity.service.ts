import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Activity } from './activity';

@Injectable()
export class ActivityService {

    private URL = 'http://zenith-society-nj-core.azurewebsites.net/api/activities';  // URL to web api

    constructor(private http: Http) { }

    getActivities(): Promise<Activity[]> {
        let activities: Promise<Activity[]> = this.http.get(this.URL)
               .toPromise()
               .then(response => response.json() as Activity[])
               .catch(this.handleError);
        if (activities == undefined) {
            
        }

        return activities;
    }

    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}