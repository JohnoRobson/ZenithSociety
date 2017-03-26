import { Event } from './event';

export const EVENTS: Event[] = [
    {
        eventId: 1,
        eventFromDate: new Date('2017-01-01T10:00:00'),
        eventToDate: new Date('2017-01-01T12:00:00'),
        enteredByUserName: 'a',
        activity: 'vaping',
        creationDate: new Date('2016-01-01T10:00:00'),
        isActive: true
    },

    {
        eventId: 2,
        eventFromDate: new Date('2017-01-03T12:00:00'),
        eventToDate: new Date('2017-01-03T13:00:00'),
        enteredByUserName: 'a',
        activity: 'water polo',
        creationDate: new Date('2017601-01T10:00:00'),
        isActive: true
    },

    {
        eventId: 3,
        eventFromDate: new Date('2017-01-03T14:00:00'),
        eventToDate: new Date('2017-01-03T15:00:00'),
        enteredByUserName: 'a',
        activity: 'vaping',
        creationDate: new Date('2017601-01T10:00:00'),
        isActive: true
    },
];