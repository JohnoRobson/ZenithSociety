import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';
import 'rxjs/add/operator/toPromise';

import { Event } from './event';
import { Activity } from './activity';
import { ActivityService } from './activity.service';

@Injectable()
export class EventService {

    private URL = 'http://zenith-society-nj-core.azurewebsites.net/api/events';  // URL to web api
    private activities: Map<number, Activity>;

    constructor(private http: Http, private activityService: ActivityService) { }

    getEvents(): Promise<Event[]> {
        let events: Promise<Event[]> = this.http.get(this.URL)
               .toPromise()
               .then(response => response.json() as Event[]).then()
               .catch(this.handleError);

        //this.activityService.getActivities().then(a => a.forEach(act => {this.activities.set(act.activityId, act)}));
this.activityService.getActivities().then(a => console.log(a));
        /*events.then(events => events.forEach(e => {
            e.activityName = this.activities.get(e.activityId).activityDescription;
        }));*/

        if (events == undefined) {
            
        }

        return events;
    }

    private handleError(error: any): Promise<any> {
        return Promise.reject(error.message || error);
    }
}