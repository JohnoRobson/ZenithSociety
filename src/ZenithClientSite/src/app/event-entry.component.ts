import { Component, OnInit, Input } from '@angular/core';

import { Event } from './event';
import { EventEntry } from './event-entry';

@Component({
  selector: 'event-entry',
  templateUrl: './event-entry.component.html'
})

export class EventEntryComponent {
    @Input() entry: EventEntry;
    //events = this.entry.events;
}