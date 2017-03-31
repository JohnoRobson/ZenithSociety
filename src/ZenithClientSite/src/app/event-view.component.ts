import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Params } from '@angular/router';

import { Event } from './event';
import { EventService } from './event.service';
import { EventEntry } from './event-entry';
import { TokenService } from './token.service';

@Component({
  selector: 'event-view',
  templateUrl: './event-view.component.html',
  styleUrls: ['./event-view.component.css']
})

export class EventViewComponent implements OnInit {
    events: Event[];
    dates: Date[];
    entries: EventEntry[];
    id: number;
    nextId: number;
    previousId: number;
    isLoggedIn: boolean;

    constructor(private eventservice: EventService, private route: ActivatedRoute, private tokenService: TokenService) {}
    
    getEvents(): void {
        this.eventservice.getEvents().then(events => this.events = events).then(e => { this.getUniqueDatesForWeek(e)});
    }

    getUniqueDatesForWeek(events: Event[]): void {
        this.dates = [];
        this.convertStringsToDates();
        events.forEach(event => {
            if (!this.dates.some(d => this.convertDate(d) === this.convertDate(event.eventFromDate))) {
                this.dates.push(event.eventFromDate);
            }
        });
        this.generateEntries();
    }

    convertStringsToDates():void {
        this.events.forEach(e => {e.creationDate = new Date(e.creationDate);
                                    e.eventFromDate = new Date(e.eventFromDate);
                                        e.eventToDate = new Date(e.eventToDate)});
    }

    generateEntries(): void {
        this.entries = [];

        this.dates.forEach(date => {
            if (date.getTime() >= this.changeDateBy(this.getStartOfWeek(), (this.id * 7) - 1).getTime()
             && date.getTime() < this.changeDateBy(this.getEndOfWeek(), (this.id * 7)).getTime()) {
                this.entries.push(new EventEntry(date, this.getActivitiesInDay(date)));
             }
        });
    }

    getActivitiesInDay(date: Date): Event[] {
        var list = new Array();
        this.events.forEach(event => {
            if (this.convertDate(event.eventFromDate) === this.convertDate(date)) {
                list.push(event);
            }
        });
        return list;
    }

    convertDate(date: Date): string {
        var s: string = "";
        s = date.getFullYear().toString() + date.getMonth().toString() + date.getDate().toString();
        return s;
    }

    changeDateBy(date: Date, days: number): Date {
        date.setDate(date.getDate() + days);
        return date;
    }

    getStartOfWeek(): Date {
        var date = new Date();
        var curDay = date.getDay();
        var diff = date.getDate() - curDay + (curDay == 0 ? -6:1);
        return new Date(date.setDate(diff));
    }

    getEndOfWeek(): Date {
        return this.changeDateBy(this.getStartOfWeek(), 6);
    }

    ngOnInit(): void {
        this.isLoggedIn = this.tokenService.isLoggedIn();
        this.route.params
        .subscribe(param => {
            this.id = param['id'];
            if (this.id == undefined) {
                this.id = 0;
            }
            this.nextId = (this.id - 1);
            this.previousId = (Number(this.id) + 1);
        });
        this.getEvents();
    }
}