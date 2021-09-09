// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class RespondEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RespondEventRequest extends $tea.Model {
  responseStatus?: string;
  static names(): { [key: string]: string } {
    return {
      responseStatus: 'responseStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      responseStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RespondEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateCaldavAccountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingUid?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingUid: 'dingUid',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingUid: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateCaldavAccountRequest extends $tea.Model {
  device?: string;
  static names(): { [key: string]: string } {
    return {
      device: 'device',
    };
  }

  static types(): { [key: string]: any } {
    return {
      device: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateCaldavAccountResponseBody extends $tea.Model {
  serverAddress?: string;
  username?: string;
  password?: string;
  static names(): { [key: string]: string } {
    return {
      serverAddress: 'serverAddress',
      username: 'username',
      password: 'password',
    };
  }

  static types(): { [key: string]: any } {
    return {
      serverAddress: 'string',
      username: 'string',
      password: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GenerateCaldavAccountResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GenerateCaldavAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GenerateCaldavAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleRequest extends $tea.Model {
  userIds?: string[];
  startTime?: string;
  endTime?: string;
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
      startTime: 'startTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
      startTime: 'string',
      endTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleResponseBody extends $tea.Model {
  scheduleInformation?: GetScheduleResponseBodyScheduleInformation[];
  static names(): { [key: string]: string } {
    return {
      scheduleInformation: 'scheduleInformation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scheduleInformation: { 'type': 'array', 'itemType': GetScheduleResponseBodyScheduleInformation },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetScheduleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetScheduleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConvertLegacyEventIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingOrgId?: string;
  dingUid?: string;
  dingAccessTokenType?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingOrgId: 'dingOrgId',
      dingUid: 'dingUid',
      dingAccessTokenType: 'dingAccessTokenType',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingOrgId: 'string',
      dingUid: 'string',
      dingAccessTokenType: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConvertLegacyEventIdRequest extends $tea.Model {
  legacyEventIds?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      legacyEventIds: 'legacyEventIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      legacyEventIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConvertLegacyEventIdResponseBody extends $tea.Model {
  legacyEventIdMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      legacyEventIdMap: 'legacyEventIdMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      legacyEventIdMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConvertLegacyEventIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ConvertLegacyEventIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ConvertLegacyEventIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveAttendeeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveAttendeeRequest extends $tea.Model {
  attendeesToRemove?: RemoveAttendeeRequestAttendeesToRemove[];
  static names(): { [key: string]: string } {
    return {
      attendeesToRemove: 'attendeesToRemove',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendeesToRemove: { 'type': 'array', 'itemType': RemoveAttendeeRequestAttendeesToRemove },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveAttendeeResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAttendeeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAttendeeRequest extends $tea.Model {
  attendeesToAdd?: AddAttendeeRequestAttendeesToAdd[];
  static names(): { [key: string]: string } {
    return {
      attendeesToAdd: 'attendeesToAdd',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendeesToAdd: { 'type': 'array', 'itemType': AddAttendeeRequestAttendeesToAdd },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAttendeeResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequest extends $tea.Model {
  summary?: string;
  description?: string;
  start?: CreateEventRequestStart;
  end?: CreateEventRequestEnd;
  isAllDay?: boolean;
  recurrence?: CreateEventRequestRecurrence;
  attendees?: CreateEventRequestAttendees[];
  location?: CreateEventRequestLocation;
  reminders?: CreateEventRequestReminders[];
  onlineMeetingInfo?: CreateEventRequestOnlineMeetingInfo;
  extra?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      summary: 'summary',
      description: 'description',
      start: 'start',
      end: 'end',
      isAllDay: 'isAllDay',
      recurrence: 'recurrence',
      attendees: 'attendees',
      location: 'location',
      reminders: 'reminders',
      onlineMeetingInfo: 'onlineMeetingInfo',
      extra: 'extra',
    };
  }

  static types(): { [key: string]: any } {
    return {
      summary: 'string',
      description: 'string',
      start: CreateEventRequestStart,
      end: CreateEventRequestEnd,
      isAllDay: 'boolean',
      recurrence: CreateEventRequestRecurrence,
      attendees: { 'type': 'array', 'itemType': CreateEventRequestAttendees },
      location: CreateEventRequestLocation,
      reminders: { 'type': 'array', 'itemType': CreateEventRequestReminders },
      onlineMeetingInfo: CreateEventRequestOnlineMeetingInfo,
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBody extends $tea.Model {
  id?: string;
  summary?: string;
  description?: string;
  start?: CreateEventResponseBodyStart;
  end?: CreateEventResponseBodyEnd;
  isAllDay?: boolean;
  recurrence?: CreateEventResponseBodyRecurrence;
  attendees?: CreateEventResponseBodyAttendees[];
  organizer?: CreateEventResponseBodyOrganizer;
  location?: CreateEventResponseBodyLocation;
  reminders?: CreateEventResponseBodyReminders[];
  createTime?: string;
  updateTime?: string;
  onlineMeetingInfo?: CreateEventResponseBodyOnlineMeetingInfo;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      summary: 'summary',
      description: 'description',
      start: 'start',
      end: 'end',
      isAllDay: 'isAllDay',
      recurrence: 'recurrence',
      attendees: 'attendees',
      organizer: 'organizer',
      location: 'location',
      reminders: 'reminders',
      createTime: 'createTime',
      updateTime: 'updateTime',
      onlineMeetingInfo: 'onlineMeetingInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      summary: 'string',
      description: 'string',
      start: CreateEventResponseBodyStart,
      end: CreateEventResponseBodyEnd,
      isAllDay: 'boolean',
      recurrence: CreateEventResponseBodyRecurrence,
      attendees: { 'type': 'array', 'itemType': CreateEventResponseBodyAttendees },
      organizer: CreateEventResponseBodyOrganizer,
      location: CreateEventResponseBodyLocation,
      reminders: { 'type': 'array', 'itemType': CreateEventResponseBodyReminders },
      createTime: 'string',
      updateTime: 'string',
      onlineMeetingInfo: CreateEventResponseBodyOnlineMeetingInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCalendarsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCalendarsResponseBody extends $tea.Model {
  response?: ListCalendarsResponseBodyResponse;
  static names(): { [key: string]: string } {
    return {
      response: 'response',
    };
  }

  static types(): { [key: string]: any } {
    return {
      response: ListCalendarsResponseBodyResponse,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCalendarsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListCalendarsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListCalendarsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListReceiversHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListReceiversRequest extends $tea.Model {
  nextToken?: string;
  type?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      type: 'type',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      type: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListReceiversResponseBody extends $tea.Model {
  nextToken?: string;
  users?: ListReceiversResponseBodyUsers[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      users: { 'type': 'array', 'itemType': ListReceiversResponseBodyUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListReceiversResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListReceiversResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListReceiversResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsRequest extends $tea.Model {
  timeMin?: string;
  timeMax?: string;
  showDeleted?: boolean;
  maxResults?: number;
  nextToken?: string;
  syncToken?: string;
  static names(): { [key: string]: string } {
    return {
      timeMin: 'timeMin',
      timeMax: 'timeMax',
      showDeleted: 'showDeleted',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      syncToken: 'syncToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      timeMin: 'string',
      timeMax: 'string',
      showDeleted: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      syncToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBody extends $tea.Model {
  nextToken?: string;
  events?: ListEventsResponseBodyEvents[];
  syncToken?: string;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      events: 'events',
      syncToken: 'syncToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      events: { 'type': 'array', 'itemType': ListEventsResponseBodyEvents },
      syncToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListEventsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListEventsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewRequest extends $tea.Model {
  timeMin?: string;
  timeMax?: string;
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      timeMin: 'timeMin',
      timeMax: 'timeMax',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      timeMin: 'string',
      timeMax: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBody extends $tea.Model {
  nextToken?: string;
  events?: ListEventsViewResponseBodyEvents[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      events: 'events',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      events: { 'type': 'array', 'itemType': ListEventsViewResponseBodyEvents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListEventsViewResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListEventsViewResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBody extends $tea.Model {
  id?: string;
  summary?: string;
  description?: string;
  status?: string;
  start?: GetEventResponseBodyStart;
  end?: GetEventResponseBodyEnd;
  isAllDay?: boolean;
  recurrence?: GetEventResponseBodyRecurrence;
  attendees?: GetEventResponseBodyAttendees[];
  organizer?: GetEventResponseBodyOrganizer;
  location?: GetEventResponseBodyLocation;
  seriesMasterId?: string;
  createTime?: string;
  updateTime?: string;
  onlineMeetingInfo?: GetEventResponseBodyOnlineMeetingInfo;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      summary: 'summary',
      description: 'description',
      status: 'status',
      start: 'start',
      end: 'end',
      isAllDay: 'isAllDay',
      recurrence: 'recurrence',
      attendees: 'attendees',
      organizer: 'organizer',
      location: 'location',
      seriesMasterId: 'seriesMasterId',
      createTime: 'createTime',
      updateTime: 'updateTime',
      onlineMeetingInfo: 'onlineMeetingInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      summary: 'string',
      description: 'string',
      status: 'string',
      start: GetEventResponseBodyStart,
      end: GetEventResponseBodyEnd,
      isAllDay: 'boolean',
      recurrence: GetEventResponseBodyRecurrence,
      attendees: { 'type': 'array', 'itemType': GetEventResponseBodyAttendees },
      organizer: GetEventResponseBodyOrganizer,
      location: GetEventResponseBodyLocation,
      seriesMasterId: 'string',
      createTime: 'string',
      updateTime: 'string',
      onlineMeetingInfo: GetEventResponseBodyOnlineMeetingInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequest extends $tea.Model {
  summary?: string;
  id?: string;
  description?: string;
  start?: PatchEventRequestStart;
  end?: PatchEventRequestEnd;
  isAllDay?: boolean;
  recurrence?: PatchEventRequestRecurrence;
  attendees?: PatchEventRequestAttendees[];
  location?: PatchEventRequestLocation;
  extra?: { [key: string]: string };
  reminders?: PatchEventRequestReminders[];
  static names(): { [key: string]: string } {
    return {
      summary: 'summary',
      id: 'id',
      description: 'description',
      start: 'start',
      end: 'end',
      isAllDay: 'isAllDay',
      recurrence: 'recurrence',
      attendees: 'attendees',
      location: 'location',
      extra: 'extra',
      reminders: 'reminders',
    };
  }

  static types(): { [key: string]: any } {
    return {
      summary: 'string',
      id: 'string',
      description: 'string',
      start: PatchEventRequestStart,
      end: PatchEventRequestEnd,
      isAllDay: 'boolean',
      recurrence: PatchEventRequestRecurrence,
      attendees: { 'type': 'array', 'itemType': PatchEventRequestAttendees },
      location: PatchEventRequestLocation,
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      reminders: { 'type': 'array', 'itemType': PatchEventRequestReminders },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBody extends $tea.Model {
  id?: string;
  summary?: string;
  description?: string;
  start?: PatchEventResponseBodyStart;
  end?: PatchEventResponseBodyEnd;
  isAllDay?: boolean;
  recurrence?: PatchEventResponseBodyRecurrence;
  attendees?: PatchEventResponseBodyAttendees[];
  organizer?: PatchEventResponseBodyOrganizer;
  location?: PatchEventResponseBodyLocation;
  createTime?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      summary: 'summary',
      description: 'description',
      start: 'start',
      end: 'end',
      isAllDay: 'isAllDay',
      recurrence: 'recurrence',
      attendees: 'attendees',
      organizer: 'organizer',
      location: 'location',
      createTime: 'createTime',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      summary: 'string',
      description: 'string',
      start: PatchEventResponseBodyStart,
      end: PatchEventResponseBodyEnd,
      isAllDay: 'boolean',
      recurrence: PatchEventResponseBodyRecurrence,
      attendees: { 'type': 'array', 'itemType': PatchEventResponseBodyAttendees },
      organizer: PatchEventResponseBodyOrganizer,
      location: PatchEventResponseBodyLocation,
      createTime: 'string',
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PatchEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PatchEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleResponseBodyScheduleInformationScheduleItemsStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleResponseBodyScheduleInformationScheduleItemsEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleResponseBodyScheduleInformationScheduleItems extends $tea.Model {
  status?: string;
  start?: GetScheduleResponseBodyScheduleInformationScheduleItemsStart;
  end?: GetScheduleResponseBodyScheduleInformationScheduleItemsEnd;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      start: 'start',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
      start: GetScheduleResponseBodyScheduleInformationScheduleItemsStart,
      end: GetScheduleResponseBodyScheduleInformationScheduleItemsEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleResponseBodyScheduleInformation extends $tea.Model {
  userId?: string;
  error?: string;
  scheduleItems?: GetScheduleResponseBodyScheduleInformationScheduleItems[];
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      error: 'error',
      scheduleItems: 'scheduleItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      error: 'string',
      scheduleItems: { 'type': 'array', 'itemType': GetScheduleResponseBodyScheduleInformationScheduleItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveAttendeeRequestAttendeesToRemove extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAttendeeRequestAttendeesToAdd extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestRecurrencePattern extends $tea.Model {
  type?: string;
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestRecurrenceRange extends $tea.Model {
  type?: string;
  endDate?: string;
  numberOfOccurrences?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      endDate: 'string',
      numberOfOccurrences: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestRecurrence extends $tea.Model {
  pattern?: CreateEventRequestRecurrencePattern;
  range?: CreateEventRequestRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: CreateEventRequestRecurrencePattern,
      range: CreateEventRequestRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestAttendees extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestLocation extends $tea.Model {
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestReminders extends $tea.Model {
  method?: string;
  minutes?: number;
  static names(): { [key: string]: string } {
    return {
      method: 'method',
      minutes: 'minutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      method: 'string',
      minutes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestOnlineMeetingInfo extends $tea.Model {
  type?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyRecurrencePattern extends $tea.Model {
  type?: string;
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyRecurrenceRange extends $tea.Model {
  type?: string;
  endDate?: string;
  numberOfOccurrences?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      endDate: 'string',
      numberOfOccurrences: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyRecurrence extends $tea.Model {
  pattern?: CreateEventResponseBodyRecurrencePattern;
  range?: CreateEventResponseBodyRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: CreateEventResponseBodyRecurrencePattern,
      range: CreateEventResponseBodyRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyAttendees extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyOrganizer extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyLocation extends $tea.Model {
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyReminders extends $tea.Model {
  method?: string;
  minutes?: string;
  static names(): { [key: string]: string } {
    return {
      method: 'method',
      minutes: 'minutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      method: 'string',
      minutes: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyOnlineMeetingInfo extends $tea.Model {
  type?: string;
  conferenceId?: string;
  url?: string;
  extraInfo?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      conferenceId: 'conferenceId',
      url: 'url',
      extraInfo: 'extraInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      conferenceId: 'string',
      url: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCalendarsResponseBodyResponseCalendars extends $tea.Model {
  id?: string;
  summary?: string;
  description?: string;
  timeZone?: string;
  eTag?: string;
  type?: string;
  privilege?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      summary: 'summary',
      description: 'description',
      timeZone: 'timeZone',
      eTag: 'eTag',
      type: 'type',
      privilege: 'privilege',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      summary: 'string',
      description: 'string',
      timeZone: 'string',
      eTag: 'string',
      type: 'string',
      privilege: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCalendarsResponseBodyResponse extends $tea.Model {
  calendars?: ListCalendarsResponseBodyResponseCalendars[];
  static names(): { [key: string]: string } {
    return {
      calendars: 'calendars',
    };
  }

  static types(): { [key: string]: any } {
    return {
      calendars: { 'type': 'array', 'itemType': ListCalendarsResponseBodyResponseCalendars },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListReceiversResponseBodyUsers extends $tea.Model {
  id?: string;
  displayName?: string;
  checkInStatus?: number;
  checkInTime?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      checkInStatus: 'checkInStatus',
      checkInTime: 'checkInTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      checkInStatus: 'number',
      checkInTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsRecurrencePattern extends $tea.Model {
  type?: string;
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsRecurrenceRange extends $tea.Model {
  type?: string;
  endDate?: string;
  numberOfOccurrences?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      endDate: 'string',
      numberOfOccurrences: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsRecurrence extends $tea.Model {
  pattern?: ListEventsResponseBodyEventsRecurrencePattern;
  range?: ListEventsResponseBodyEventsRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: ListEventsResponseBodyEventsRecurrencePattern,
      range: ListEventsResponseBodyEventsRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsAttendees extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsOrganizer extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsLocation extends $tea.Model {
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsOnlineMeetingInfo extends $tea.Model {
  type?: string;
  conferenceId?: string;
  url?: string;
  extraInfo?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      conferenceId: 'conferenceId',
      url: 'url',
      extraInfo: 'extraInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      conferenceId: 'string',
      url: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEvents extends $tea.Model {
  id?: string;
  summary?: string;
  description?: string;
  start?: ListEventsResponseBodyEventsStart;
  end?: ListEventsResponseBodyEventsEnd;
  isAllDay?: boolean;
  recurrence?: ListEventsResponseBodyEventsRecurrence;
  attendees?: ListEventsResponseBodyEventsAttendees[];
  organizer?: ListEventsResponseBodyEventsOrganizer;
  location?: ListEventsResponseBodyEventsLocation;
  seriesMasterId?: string;
  createTime?: string;
  updateTime?: string;
  status?: string;
  onlineMeetingInfo?: ListEventsResponseBodyEventsOnlineMeetingInfo;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      summary: 'summary',
      description: 'description',
      start: 'start',
      end: 'end',
      isAllDay: 'isAllDay',
      recurrence: 'recurrence',
      attendees: 'attendees',
      organizer: 'organizer',
      location: 'location',
      seriesMasterId: 'seriesMasterId',
      createTime: 'createTime',
      updateTime: 'updateTime',
      status: 'status',
      onlineMeetingInfo: 'onlineMeetingInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      summary: 'string',
      description: 'string',
      start: ListEventsResponseBodyEventsStart,
      end: ListEventsResponseBodyEventsEnd,
      isAllDay: 'boolean',
      recurrence: ListEventsResponseBodyEventsRecurrence,
      attendees: { 'type': 'array', 'itemType': ListEventsResponseBodyEventsAttendees },
      organizer: ListEventsResponseBodyEventsOrganizer,
      location: ListEventsResponseBodyEventsLocation,
      seriesMasterId: 'string',
      createTime: 'string',
      updateTime: 'string',
      status: 'string',
      onlineMeetingInfo: ListEventsResponseBodyEventsOnlineMeetingInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsRecurrencePattern extends $tea.Model {
  type?: string;
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsRecurrenceRange extends $tea.Model {
  type?: string;
  endDate?: string;
  numberOfOccurrences?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      endDate: 'string',
      numberOfOccurrences: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsRecurrence extends $tea.Model {
  pattern?: ListEventsViewResponseBodyEventsRecurrencePattern;
  range?: ListEventsViewResponseBodyEventsRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: ListEventsViewResponseBodyEventsRecurrencePattern,
      range: ListEventsViewResponseBodyEventsRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsAttendees extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsOrganizer extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsLocation extends $tea.Model {
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsOnlineMeetingInfo extends $tea.Model {
  type?: string;
  conferenceId?: string;
  url?: string;
  extraInfo?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      conferenceId: 'conferenceId',
      url: 'url',
      extraInfo: 'extraInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      conferenceId: 'string',
      url: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEvents extends $tea.Model {
  id?: string;
  summary?: string;
  description?: string;
  start?: ListEventsViewResponseBodyEventsStart;
  end?: ListEventsViewResponseBodyEventsEnd;
  isAllDay?: boolean;
  recurrence?: ListEventsViewResponseBodyEventsRecurrence;
  attendees?: ListEventsViewResponseBodyEventsAttendees[];
  organizer?: ListEventsViewResponseBodyEventsOrganizer;
  location?: ListEventsViewResponseBodyEventsLocation;
  seriesMasterId?: string;
  createTime?: string;
  updateTime?: string;
  status?: string;
  onlineMeetingInfo?: ListEventsViewResponseBodyEventsOnlineMeetingInfo;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      summary: 'summary',
      description: 'description',
      start: 'start',
      end: 'end',
      isAllDay: 'isAllDay',
      recurrence: 'recurrence',
      attendees: 'attendees',
      organizer: 'organizer',
      location: 'location',
      seriesMasterId: 'seriesMasterId',
      createTime: 'createTime',
      updateTime: 'updateTime',
      status: 'status',
      onlineMeetingInfo: 'onlineMeetingInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      summary: 'string',
      description: 'string',
      start: ListEventsViewResponseBodyEventsStart,
      end: ListEventsViewResponseBodyEventsEnd,
      isAllDay: 'boolean',
      recurrence: ListEventsViewResponseBodyEventsRecurrence,
      attendees: { 'type': 'array', 'itemType': ListEventsViewResponseBodyEventsAttendees },
      organizer: ListEventsViewResponseBodyEventsOrganizer,
      location: ListEventsViewResponseBodyEventsLocation,
      seriesMasterId: 'string',
      createTime: 'string',
      updateTime: 'string',
      status: 'string',
      onlineMeetingInfo: ListEventsViewResponseBodyEventsOnlineMeetingInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyRecurrencePattern extends $tea.Model {
  type?: string;
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyRecurrenceRange extends $tea.Model {
  type?: string;
  endDate?: string;
  numberOfOccurrences?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      endDate: 'string',
      numberOfOccurrences: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyRecurrence extends $tea.Model {
  pattern?: GetEventResponseBodyRecurrencePattern;
  range?: GetEventResponseBodyRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: GetEventResponseBodyRecurrencePattern,
      range: GetEventResponseBodyRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyAttendees extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyOrganizer extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyLocation extends $tea.Model {
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyOnlineMeetingInfo extends $tea.Model {
  type?: string;
  conferenceId?: string;
  url?: string;
  extraInfo?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      conferenceId: 'conferenceId',
      url: 'url',
      extraInfo: 'extraInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      conferenceId: 'string',
      url: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestRecurrencePattern extends $tea.Model {
  type?: string;
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestRecurrenceRange extends $tea.Model {
  type?: string;
  endDate?: string;
  numberOfOccurrences?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      endDate: 'string',
      numberOfOccurrences: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestRecurrence extends $tea.Model {
  pattern?: PatchEventRequestRecurrencePattern;
  range?: PatchEventRequestRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: PatchEventRequestRecurrencePattern,
      range: PatchEventRequestRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestAttendees extends $tea.Model {
  id?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestLocation extends $tea.Model {
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestReminders extends $tea.Model {
  method?: string;
  minutes?: number;
  static names(): { [key: string]: string } {
    return {
      method: 'method',
      minutes: 'minutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      method: 'string',
      minutes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyStart extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyEnd extends $tea.Model {
  date?: string;
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyRecurrencePattern extends $tea.Model {
  type?: string;
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyRecurrenceRange extends $tea.Model {
  type?: string;
  endDate?: string;
  numberOfOccurrences?: number;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      endDate: 'string',
      numberOfOccurrences: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyRecurrence extends $tea.Model {
  pattern?: PatchEventResponseBodyRecurrencePattern;
  range?: PatchEventResponseBodyRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: PatchEventResponseBodyRecurrencePattern,
      range: PatchEventResponseBodyRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyAttendees extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyOrganizer extends $tea.Model {
  id?: string;
  displayName?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      displayName: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyLocation extends $tea.Model {
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async respondEvent(userId: string, calendarId: string, eventId: string, request: RespondEventRequest): Promise<RespondEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RespondEventHeaders({ });
    return await this.respondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async respondEventWithOptions(userId: string, calendarId: string, eventId: string, request: RespondEventRequest, headers: RespondEventHeaders, runtime: $Util.RuntimeOptions): Promise<RespondEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.responseStatus)) {
      body["responseStatus"] = request.responseStatus;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RespondEventResponse>(await this.doROARequest("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/respond`, "none", req, runtime), new RespondEventResponse({}));
  }

  async generateCaldavAccount(userId: string, request: GenerateCaldavAccountRequest): Promise<GenerateCaldavAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GenerateCaldavAccountHeaders({ });
    return await this.generateCaldavAccountWithOptions(userId, request, headers, runtime);
  }

  async generateCaldavAccountWithOptions(userId: string, request: GenerateCaldavAccountRequest, headers: GenerateCaldavAccountHeaders, runtime: $Util.RuntimeOptions): Promise<GenerateCaldavAccountResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.device)) {
      body["device"] = request.device;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingUid)) {
      realHeaders["dingUid"] = headers.dingUid;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GenerateCaldavAccountResponse>(await this.doROARequest("GenerateCaldavAccount", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/caldavAccounts`, "json", req, runtime), new GenerateCaldavAccountResponse({}));
  }

  async getSchedule(userId: string, request: GetScheduleRequest): Promise<GetScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetScheduleHeaders({ });
    return await this.getScheduleWithOptions(userId, request, headers, runtime);
  }

  async getScheduleWithOptions(userId: string, request: GetScheduleRequest, headers: GetScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<GetScheduleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetScheduleResponse>(await this.doROARequest("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/querySchedule`, "json", req, runtime), new GetScheduleResponse({}));
  }

  async convertLegacyEventId(userId: string, request: ConvertLegacyEventIdRequest): Promise<ConvertLegacyEventIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConvertLegacyEventIdHeaders({ });
    return await this.convertLegacyEventIdWithOptions(userId, request, headers, runtime);
  }

  async convertLegacyEventIdWithOptions(userId: string, request: ConvertLegacyEventIdRequest, headers: ConvertLegacyEventIdHeaders, runtime: $Util.RuntimeOptions): Promise<ConvertLegacyEventIdResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.legacyEventIds)) {
      body["legacyEventIds"] = request.legacyEventIds;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = headers.dingOrgId;
    }

    if (!Util.isUnset(headers.dingUid)) {
      realHeaders["dingUid"] = headers.dingUid;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = headers.dingAccessTokenType;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ConvertLegacyEventIdResponse>(await this.doROARequest("ConvertLegacyEventId", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/legacyEventIds/convert`, "json", req, runtime), new ConvertLegacyEventIdResponse({}));
  }

  async removeAttendee(userId: string, calendarId: string, eventId: string, request: RemoveAttendeeRequest): Promise<RemoveAttendeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveAttendeeHeaders({ });
    return await this.removeAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async removeAttendeeWithOptions(userId: string, calendarId: string, eventId: string, request: RemoveAttendeeRequest, headers: RemoveAttendeeHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveAttendeeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendeesToRemove)) {
      body["attendeesToRemove"] = request.attendeesToRemove;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RemoveAttendeeResponse>(await this.doROARequest("RemoveAttendee", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees/batchRemove`, "none", req, runtime), new RemoveAttendeeResponse({}));
  }

  async addAttendee(userId: string, calendarId: string, eventId: string, request: AddAttendeeRequest): Promise<AddAttendeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAttendeeHeaders({ });
    return await this.addAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async addAttendeeWithOptions(userId: string, calendarId: string, eventId: string, request: AddAttendeeRequest, headers: AddAttendeeHeaders, runtime: $Util.RuntimeOptions): Promise<AddAttendeeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendeesToAdd)) {
      body["attendeesToAdd"] = request.attendeesToAdd;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AddAttendeeResponse>(await this.doROARequest("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees`, "none", req, runtime), new AddAttendeeResponse({}));
  }

  async createEvent(userId: string, calendarId: string, request: CreateEventRequest): Promise<CreateEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateEventHeaders({ });
    return await this.createEventWithOptions(userId, calendarId, request, headers, runtime);
  }

  async createEventWithOptions(userId: string, calendarId: string, request: CreateEventRequest, headers: CreateEventHeaders, runtime: $Util.RuntimeOptions): Promise<CreateEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset($tea.toMap(request.start))) {
      body["start"] = request.start;
    }

    if (!Util.isUnset($tea.toMap(request.end))) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.isAllDay)) {
      body["isAllDay"] = request.isAllDay;
    }

    if (!Util.isUnset($tea.toMap(request.recurrence))) {
      body["recurrence"] = request.recurrence;
    }

    if (!Util.isUnset(request.attendees)) {
      body["attendees"] = request.attendees;
    }

    if (!Util.isUnset($tea.toMap(request.location))) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.reminders)) {
      body["reminders"] = request.reminders;
    }

    if (!Util.isUnset($tea.toMap(request.onlineMeetingInfo))) {
      body["onlineMeetingInfo"] = request.onlineMeetingInfo;
    }

    if (!Util.isUnset(request.extra)) {
      body["extra"] = request.extra;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateEventResponse>(await this.doROARequest("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events`, "json", req, runtime), new CreateEventResponse({}));
  }

  async listCalendars(userId: string): Promise<ListCalendarsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCalendarsHeaders({ });
    return await this.listCalendarsWithOptions(userId, headers, runtime);
  }

  async listCalendarsWithOptions(userId: string, headers: ListCalendarsHeaders, runtime: $Util.RuntimeOptions): Promise<ListCalendarsResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<ListCalendarsResponse>(await this.doROARequest("ListCalendars", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars`, "json", req, runtime), new ListCalendarsResponse({}));
  }

  async listReceivers(userId: string, calendarId: string, eventId: string, request: ListReceiversRequest): Promise<ListReceiversResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListReceiversHeaders({ });
    return await this.listReceiversWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async listReceiversWithOptions(userId: string, calendarId: string, eventId: string, request: ListReceiversRequest, headers: ListReceiversHeaders, runtime: $Util.RuntimeOptions): Promise<ListReceiversResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListReceiversResponse>(await this.doROARequest("ListReceivers", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/receivers`, "json", req, runtime), new ListReceiversResponse({}));
  }

  async deleteEvent(userId: string, calendarId: string, eventId: string): Promise<DeleteEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteEventHeaders({ });
    return await this.deleteEventWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  async deleteEventWithOptions(userId: string, calendarId: string, eventId: string, headers: DeleteEventHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteEventResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<DeleteEventResponse>(await this.doROARequest("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`, "none", req, runtime), new DeleteEventResponse({}));
  }

  async listEvents(userId: string, calendarId: string, request: ListEventsRequest): Promise<ListEventsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsHeaders({ });
    return await this.listEventsWithOptions(userId, calendarId, request, headers, runtime);
  }

  async listEventsWithOptions(userId: string, calendarId: string, request: ListEventsRequest, headers: ListEventsHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.timeMin)) {
      query["timeMin"] = request.timeMin;
    }

    if (!Util.isUnset(request.timeMax)) {
      query["timeMax"] = request.timeMax;
    }

    if (!Util.isUnset(request.showDeleted)) {
      query["showDeleted"] = request.showDeleted;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.syncToken)) {
      query["syncToken"] = request.syncToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListEventsResponse>(await this.doROARequest("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events`, "json", req, runtime), new ListEventsResponse({}));
  }

  async listEventsView(userId: string, calendarId: string, request: ListEventsViewRequest): Promise<ListEventsViewResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsViewHeaders({ });
    return await this.listEventsViewWithOptions(userId, calendarId, request, headers, runtime);
  }

  async listEventsViewWithOptions(userId: string, calendarId: string, request: ListEventsViewRequest, headers: ListEventsViewHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsViewResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.timeMin)) {
      query["timeMin"] = request.timeMin;
    }

    if (!Util.isUnset(request.timeMax)) {
      query["timeMax"] = request.timeMax;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListEventsViewResponse>(await this.doROARequest("ListEventsView", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/eventsview`, "json", req, runtime), new ListEventsViewResponse({}));
  }

  async getEvent(userId: string, calendarId: string, eventId: string): Promise<GetEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEventHeaders({ });
    return await this.getEventWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  async getEventWithOptions(userId: string, calendarId: string, eventId: string, headers: GetEventHeaders, runtime: $Util.RuntimeOptions): Promise<GetEventResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetEventResponse>(await this.doROARequest("GetEvent", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`, "json", req, runtime), new GetEventResponse({}));
  }

  async patchEvent(userId: string, calendarId: string, eventId: string, request: PatchEventRequest): Promise<PatchEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PatchEventHeaders({ });
    return await this.patchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async patchEventWithOptions(userId: string, calendarId: string, eventId: string, request: PatchEventRequest, headers: PatchEventHeaders, runtime: $Util.RuntimeOptions): Promise<PatchEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset($tea.toMap(request.start))) {
      body["start"] = request.start;
    }

    if (!Util.isUnset($tea.toMap(request.end))) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.isAllDay)) {
      body["isAllDay"] = request.isAllDay;
    }

    if (!Util.isUnset($tea.toMap(request.recurrence))) {
      body["recurrence"] = request.recurrence;
    }

    if (!Util.isUnset(request.attendees)) {
      body["attendees"] = request.attendees;
    }

    if (!Util.isUnset($tea.toMap(request.location))) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.extra)) {
      body["extra"] = request.extra;
    }

    if (!Util.isUnset(request.reminders)) {
      body["reminders"] = request.reminders;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<PatchEventResponse>(await this.doROARequest("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`, "json", req, runtime), new PatchEventResponse({}));
  }

}
