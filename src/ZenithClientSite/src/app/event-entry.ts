import { Event } from './event';

export class EventEntry {
    date: Date;
    events: Event[];

    constructor(date: Date, events: Event[]) {
        this.date = date;
        this.events = events;
    }
}