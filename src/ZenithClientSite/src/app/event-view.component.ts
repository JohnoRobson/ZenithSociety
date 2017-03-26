import { Component, OnInit } from '@angular/core';

import { Event } from './event';
import { EventService } from './event.service';
import { EventEntry } from './event-entry';

@Component({
  selector: 'event-view',
  templateUrl: './event-view.component.html',
  styleUrls: ['./event-view.component.css']
})

export class EventViewComponent {
    events: Event[];
    dates: Date[];
    entries: EventEntry[];

    constructor(private eventservice: EventService) {}
    
    getEvents(): void {
        this.eventservice.getEvents().then(events => this.events = events).then(e => this.getUniqueDatesForWeek(e));
    }

    getUniqueDatesForWeek(events: Event[]): void {
        this.dates = [];
        events.forEach(event => {
            if (!this.dates.some(d => this.convertDate(d) === this.convertDate(event.eventFromDate))) {
                this.dates.push(event.eventFromDate);
            }
        });
        this.generateEntries();
    }

    generateEntries(): void {
        this.entries = [];
        this.dates.forEach(date => {
            this.entries.push(new EventEntry(date, this.getActivitiesInDay(date)));
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

    ngOnInit(): void {
        this.getEvents();
    }
}