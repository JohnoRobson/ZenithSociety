import { Component, OnInit, Input } from '@angular/core';

import { Event } from './event';
import { EventEntry } from './event-entry';
import { TokenService } from './token.service';

@Component({
  selector: 'event-entry',
  templateUrl: './event-entry.component.html'
})

export class EventEntryComponent {
    constructor(private tokenService: TokenService) {}
    @Input() entry: EventEntry;
}