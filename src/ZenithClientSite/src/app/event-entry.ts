import { Event } from './event';

export class EventEntry {
    date: Date;
    events: Event[];

    constructor(date: Date, events: Event[]) {
        this.date = date;
        this.events = events;
    }

    allAreInactive(): boolean {
        this.events.forEach(e => {if (e.isActive) {
            return false;
        }})
        return true;
    }
}