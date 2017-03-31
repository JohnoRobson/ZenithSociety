import { Activity } from './activity';

export class Event {
    eventId: number;
    eventFromDate: Date;
    eventToDate: Date;
    enteredByUserName: string;
    activityId: number;
    activity: Activity;
    creationDate: Date;
    isActive: boolean;
}