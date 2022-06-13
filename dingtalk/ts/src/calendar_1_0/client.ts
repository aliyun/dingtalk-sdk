// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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

export class CheckInHeaders extends $tea.Model {
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

export class CheckInResponseBody extends $tea.Model {
  checkInTime?: number;
  static names(): { [key: string]: string } {
    return {
      checkInTime: 'checkInTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkInTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckInResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CheckInResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CheckInResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConvertLegacyEventIdHeaders extends $tea.Model {
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

export class ConvertLegacyEventIdRequest extends $tea.Model {
  legacyEventIds?: string[];
  static names(): { [key: string]: string } {
    return {
      legacyEventIds: 'legacyEventIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      legacyEventIds: { 'type': 'array', 'itemType': 'string' },
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

export class CreateAclsHeaders extends $tea.Model {
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

export class CreateAclsRequest extends $tea.Model {
  privilege?: string;
  scope?: CreateAclsRequestScope;
  sendMsg?: boolean;
  static names(): { [key: string]: string } {
    return {
      privilege: 'privilege',
      scope: 'scope',
      sendMsg: 'sendMsg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      privilege: 'string',
      scope: CreateAclsRequestScope,
      sendMsg: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAclsResponseBody extends $tea.Model {
  aclId?: string;
  privilege?: string;
  scope?: CreateAclsResponseBodyScope;
  static names(): { [key: string]: string } {
    return {
      aclId: 'aclId',
      privilege: 'privilege',
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aclId: 'string',
      privilege: 'string',
      scope: CreateAclsResponseBodyScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAclsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateAclsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateAclsResponseBody,
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
  attendees?: CreateEventRequestAttendees[];
  description?: string;
  end?: CreateEventRequestEnd;
  extra?: { [key: string]: string };
  isAllDay?: boolean;
  location?: CreateEventRequestLocation;
  onlineMeetingInfo?: CreateEventRequestOnlineMeetingInfo;
  recurrence?: CreateEventRequestRecurrence;
  reminders?: CreateEventRequestReminders[];
  start?: CreateEventRequestStart;
  summary?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      description: 'description',
      end: 'end',
      extra: 'extra',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      recurrence: 'recurrence',
      reminders: 'reminders',
      start: 'start',
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': CreateEventRequestAttendees },
      description: 'string',
      end: CreateEventRequestEnd,
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      isAllDay: 'boolean',
      location: CreateEventRequestLocation,
      onlineMeetingInfo: CreateEventRequestOnlineMeetingInfo,
      recurrence: CreateEventRequestRecurrence,
      reminders: { 'type': 'array', 'itemType': CreateEventRequestReminders },
      start: CreateEventRequestStart,
      summary: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBody extends $tea.Model {
  attendees?: CreateEventResponseBodyAttendees[];
  createTime?: string;
  description?: string;
  end?: CreateEventResponseBodyEnd;
  id?: string;
  isAllDay?: boolean;
  location?: CreateEventResponseBodyLocation;
  onlineMeetingInfo?: CreateEventResponseBodyOnlineMeetingInfo;
  organizer?: CreateEventResponseBodyOrganizer;
  recurrence?: CreateEventResponseBodyRecurrence;
  reminders?: CreateEventResponseBodyReminders[];
  start?: CreateEventResponseBodyStart;
  summary?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      recurrence: 'recurrence',
      reminders: 'reminders',
      start: 'start',
      summary: 'summary',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': CreateEventResponseBodyAttendees },
      createTime: 'string',
      description: 'string',
      end: CreateEventResponseBodyEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: CreateEventResponseBodyLocation,
      onlineMeetingInfo: CreateEventResponseBodyOnlineMeetingInfo,
      organizer: CreateEventResponseBodyOrganizer,
      recurrence: CreateEventResponseBodyRecurrence,
      reminders: { 'type': 'array', 'itemType': CreateEventResponseBodyReminders },
      start: CreateEventResponseBodyStart,
      summary: 'string',
      updateTime: 'string',
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

export class CreateSubscribedCalendarHeaders extends $tea.Model {
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

export class CreateSubscribedCalendarRequest extends $tea.Model {
  description?: string;
  managers?: string[];
  name?: string;
  subscribeScope?: CreateSubscribedCalendarRequestSubscribeScope;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      managers: 'managers',
      name: 'name',
      subscribeScope: 'subscribeScope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      managers: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      subscribeScope: CreateSubscribedCalendarRequestSubscribeScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubscribedCalendarResponseBody extends $tea.Model {
  calendarId?: string;
  static names(): { [key: string]: string } {
    return {
      calendarId: 'calendarId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      calendarId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubscribedCalendarResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateSubscribedCalendarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateSubscribedCalendarResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAclHeaders extends $tea.Model {
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

export class DeleteAclResponse extends $tea.Model {
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

export class DeleteSubscribedCalendarHeaders extends $tea.Model {
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

export class DeleteSubscribedCalendarResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSubscribedCalendarResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteSubscribedCalendarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteSubscribedCalendarResponseBody,
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
  password?: string;
  serverAddress?: string;
  username?: string;
  static names(): { [key: string]: string } {
    return {
      password: 'password',
      serverAddress: 'serverAddress',
      username: 'username',
    };
  }

  static types(): { [key: string]: any } {
    return {
      password: 'string',
      serverAddress: 'string',
      username: 'string',
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

export class GetEventRequest extends $tea.Model {
  maxAttendees?: number;
  static names(): { [key: string]: string } {
    return {
      maxAttendees: 'maxAttendees',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxAttendees: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBody extends $tea.Model {
  attendees?: GetEventResponseBodyAttendees[];
  createTime?: string;
  description?: string;
  end?: GetEventResponseBodyEnd;
  id?: string;
  isAllDay?: boolean;
  location?: GetEventResponseBodyLocation;
  onlineMeetingInfo?: GetEventResponseBodyOnlineMeetingInfo;
  organizer?: GetEventResponseBodyOrganizer;
  recurrence?: GetEventResponseBodyRecurrence;
  reminders?: GetEventResponseBodyReminders[];
  seriesMasterId?: string;
  start?: GetEventResponseBodyStart;
  status?: string;
  summary?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      recurrence: 'recurrence',
      reminders: 'reminders',
      seriesMasterId: 'seriesMasterId',
      start: 'start',
      status: 'status',
      summary: 'summary',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': GetEventResponseBodyAttendees },
      createTime: 'string',
      description: 'string',
      end: GetEventResponseBodyEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: GetEventResponseBodyLocation,
      onlineMeetingInfo: GetEventResponseBodyOnlineMeetingInfo,
      organizer: GetEventResponseBodyOrganizer,
      recurrence: GetEventResponseBodyRecurrence,
      reminders: { 'type': 'array', 'itemType': GetEventResponseBodyReminders },
      seriesMasterId: 'string',
      start: GetEventResponseBodyStart,
      status: 'string',
      summary: 'string',
      updateTime: 'string',
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
  endTime?: string;
  startTime?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      startTime: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
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

export class GetSignInListHeaders extends $tea.Model {
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

export class GetSignInListRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignInListResponseBody extends $tea.Model {
  nextToken?: string;
  users?: GetSignInListResponseBodyUsers[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      users: { 'type': 'array', 'itemType': GetSignInListResponseBodyUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignInListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSignInListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSignInListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignOutListHeaders extends $tea.Model {
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

export class GetSignOutListRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignOutListResponseBody extends $tea.Model {
  nextToken?: string;
  users?: GetSignOutListResponseBodyUsers[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      users: { 'type': 'array', 'itemType': GetSignOutListResponseBodyUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignOutListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSignOutListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSignOutListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSubscribedCalendarHeaders extends $tea.Model {
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

export class GetSubscribedCalendarResponseBody extends $tea.Model {
  author?: string;
  calendarId?: string;
  description?: string;
  managers?: string[];
  name?: string;
  subscribeScope?: GetSubscribedCalendarResponseBodySubscribeScope;
  static names(): { [key: string]: string } {
    return {
      author: 'author',
      calendarId: 'calendarId',
      description: 'description',
      managers: 'managers',
      name: 'name',
      subscribeScope: 'subscribeScope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      author: 'string',
      calendarId: 'string',
      description: 'string',
      managers: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      subscribeScope: GetSubscribedCalendarResponseBodySubscribeScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSubscribedCalendarResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSubscribedCalendarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSubscribedCalendarResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAclsHeaders extends $tea.Model {
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

export class ListAclsResponseBody extends $tea.Model {
  acls?: ListAclsResponseBodyAcls[];
  static names(): { [key: string]: string } {
    return {
      acls: 'acls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      acls: { 'type': 'array', 'itemType': ListAclsResponseBodyAcls },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAclsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAclsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAclsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAttendeesHeaders extends $tea.Model {
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

export class ListAttendeesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAttendeesResponseBody extends $tea.Model {
  attendees?: ListAttendeesResponseBodyAttendees[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': ListAttendeesResponseBodyAttendees },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAttendeesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAttendeesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAttendeesResponseBody,
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
  maxAttendees?: number;
  maxResults?: number;
  nextToken?: string;
  showDeleted?: boolean;
  syncToken?: string;
  timeMax?: string;
  timeMin?: string;
  static names(): { [key: string]: string } {
    return {
      maxAttendees: 'maxAttendees',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      showDeleted: 'showDeleted',
      syncToken: 'syncToken',
      timeMax: 'timeMax',
      timeMin: 'timeMin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxAttendees: 'number',
      maxResults: 'number',
      nextToken: 'string',
      showDeleted: 'boolean',
      syncToken: 'string',
      timeMax: 'string',
      timeMin: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBody extends $tea.Model {
  events?: ListEventsResponseBodyEvents[];
  nextToken?: string;
  syncToken?: string;
  static names(): { [key: string]: string } {
    return {
      events: 'events',
      nextToken: 'nextToken',
      syncToken: 'syncToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      events: { 'type': 'array', 'itemType': ListEventsResponseBodyEvents },
      nextToken: 'string',
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

export class ListEventsInstancesHeaders extends $tea.Model {
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

export class ListEventsInstancesRequest extends $tea.Model {
  maxAttendees?: number;
  maxResults?: number;
  seriesMasterId?: string;
  startRecurrenceId?: string;
  static names(): { [key: string]: string } {
    return {
      maxAttendees: 'maxAttendees',
      maxResults: 'maxResults',
      seriesMasterId: 'seriesMasterId',
      startRecurrenceId: 'startRecurrenceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxAttendees: 'number',
      maxResults: 'number',
      seriesMasterId: 'string',
      startRecurrenceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBody extends $tea.Model {
  events?: ListEventsInstancesResponseBodyEvents[];
  static names(): { [key: string]: string } {
    return {
      events: 'events',
    };
  }

  static types(): { [key: string]: any } {
    return {
      events: { 'type': 'array', 'itemType': ListEventsInstancesResponseBodyEvents },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListEventsInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListEventsInstancesResponseBody,
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
  maxAttendees?: number;
  maxResults?: number;
  nextToken?: string;
  timeMax?: string;
  timeMin?: string;
  static names(): { [key: string]: string } {
    return {
      maxAttendees: 'maxAttendees',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      timeMax: 'timeMax',
      timeMin: 'timeMin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxAttendees: 'number',
      maxResults: 'number',
      nextToken: 'string',
      timeMax: 'string',
      timeMin: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBody extends $tea.Model {
  events?: ListEventsViewResponseBodyEvents[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      events: 'events',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      events: { 'type': 'array', 'itemType': ListEventsViewResponseBodyEvents },
      nextToken: 'string',
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
  attendees?: PatchEventRequestAttendees[];
  description?: string;
  end?: PatchEventRequestEnd;
  extra?: { [key: string]: string };
  id?: string;
  isAllDay?: boolean;
  location?: PatchEventRequestLocation;
  recurrence?: PatchEventRequestRecurrence;
  reminders?: PatchEventRequestReminders[];
  start?: PatchEventRequestStart;
  summary?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      description: 'description',
      end: 'end',
      extra: 'extra',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      recurrence: 'recurrence',
      reminders: 'reminders',
      start: 'start',
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': PatchEventRequestAttendees },
      description: 'string',
      end: PatchEventRequestEnd,
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      id: 'string',
      isAllDay: 'boolean',
      location: PatchEventRequestLocation,
      recurrence: PatchEventRequestRecurrence,
      reminders: { 'type': 'array', 'itemType': PatchEventRequestReminders },
      start: PatchEventRequestStart,
      summary: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBody extends $tea.Model {
  attendees?: PatchEventResponseBodyAttendees[];
  createTime?: string;
  description?: string;
  end?: PatchEventResponseBodyEnd;
  id?: string;
  isAllDay?: boolean;
  location?: PatchEventResponseBodyLocation;
  organizer?: PatchEventResponseBodyOrganizer;
  recurrence?: PatchEventResponseBodyRecurrence;
  reminders?: PatchEventResponseBodyReminders[];
  start?: PatchEventResponseBodyStart;
  summary?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      organizer: 'organizer',
      recurrence: 'recurrence',
      reminders: 'reminders',
      start: 'start',
      summary: 'summary',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': PatchEventResponseBodyAttendees },
      createTime: 'string',
      description: 'string',
      end: PatchEventResponseBodyEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: PatchEventResponseBodyLocation,
      organizer: PatchEventResponseBodyOrganizer,
      recurrence: PatchEventResponseBodyRecurrence,
      reminders: { 'type': 'array', 'itemType': PatchEventResponseBodyReminders },
      start: PatchEventResponseBodyStart,
      summary: 'string',
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

export class SignInHeaders extends $tea.Model {
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

export class SignInResponseBody extends $tea.Model {
  checkInTime?: number;
  static names(): { [key: string]: string } {
    return {
      checkInTime: 'checkInTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkInTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignInResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SignInResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SignInResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignOutHeaders extends $tea.Model {
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

export class SignOutResponseBody extends $tea.Model {
  checkOutTime?: number;
  static names(): { [key: string]: string } {
    return {
      checkOutTime: 'checkOutTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkOutTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignOutResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SignOutResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SignOutResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubscribeCalendarHeaders extends $tea.Model {
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

export class SubscribeCalendarResponse extends $tea.Model {
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

export class UpdateSubscribedCalendarsHeaders extends $tea.Model {
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

export class UpdateSubscribedCalendarsRequest extends $tea.Model {
  description?: string;
  managers?: string[];
  name?: string;
  subscribeScope?: UpdateSubscribedCalendarsRequestSubscribeScope;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      managers: 'managers',
      name: 'name',
      subscribeScope: 'subscribeScope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      managers: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      subscribeScope: UpdateSubscribedCalendarsRequestSubscribeScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSubscribedCalendarsResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSubscribedCalendarsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateSubscribedCalendarsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateSubscribedCalendarsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAttendeeRequestAttendeesToAdd extends $tea.Model {
  id?: string;
  isOptional?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      isOptional: 'isOptional',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      isOptional: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAclsRequestScope extends $tea.Model {
  scopeType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      scopeType: 'scopeType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAclsResponseBodyScope extends $tea.Model {
  scopeType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      scopeType: 'scopeType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestAttendees extends $tea.Model {
  id?: string;
  isOptional?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      isOptional: 'isOptional',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      isOptional: 'boolean',
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

export class CreateEventRequestRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
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

export class CreateEventResponseBodyAttendees extends $tea.Model {
  displayName?: string;
  id?: string;
  isOptional?: boolean;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      isOptional: 'isOptional',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      isOptional: 'boolean',
      responseStatus: 'string',
      self: 'boolean',
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

export class CreateEventResponseBodyOnlineMeetingInfo extends $tea.Model {
  conferenceId?: string;
  extraInfo?: { [key: string]: any };
  type?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      extraInfo: 'extraInfo',
      type: 'type',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyOrganizer extends $tea.Model {
  displayName?: string;
  id?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBodyRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
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

export class CreateSubscribedCalendarRequestSubscribeScope extends $tea.Model {
  corpIds?: string[];
  openConversationIds?: string[];
  unionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      corpIds: 'corpIds',
      openConversationIds: 'openConversationIds',
      unionIds: 'unionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIds: { 'type': 'array', 'itemType': 'string' },
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      unionIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyAttendees extends $tea.Model {
  displayName?: string;
  id?: string;
  isOptional?: boolean;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      isOptional: 'isOptional',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      isOptional: 'boolean',
      responseStatus: 'string',
      self: 'boolean',
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

export class GetEventResponseBodyLocation extends $tea.Model {
  displayName?: string;
  meetingRooms?: string[];
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      meetingRooms: 'meetingRooms',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      meetingRooms: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyOnlineMeetingInfo extends $tea.Model {
  conferenceId?: string;
  extraInfo?: { [key: string]: any };
  type?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      extraInfo: 'extraInfo',
      type: 'type',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyOrganizer extends $tea.Model {
  displayName?: string;
  id?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
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

export class GetEventResponseBodyReminders extends $tea.Model {
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

export class GetScheduleResponseBodyScheduleInformationScheduleItems extends $tea.Model {
  end?: GetScheduleResponseBodyScheduleInformationScheduleItemsEnd;
  start?: GetScheduleResponseBodyScheduleInformationScheduleItemsStart;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      start: 'start',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: GetScheduleResponseBodyScheduleInformationScheduleItemsEnd,
      start: GetScheduleResponseBodyScheduleInformationScheduleItemsStart,
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleResponseBodyScheduleInformation extends $tea.Model {
  error?: string;
  scheduleItems?: GetScheduleResponseBodyScheduleInformationScheduleItems[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      error: 'error',
      scheduleItems: 'scheduleItems',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      error: 'string',
      scheduleItems: { 'type': 'array', 'itemType': GetScheduleResponseBodyScheduleInformationScheduleItems },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignInListResponseBodyUsers extends $tea.Model {
  checkInTime?: number;
  displayName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      checkInTime: 'checkInTime',
      displayName: 'displayName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkInTime: 'number',
      displayName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignOutListResponseBodyUsers extends $tea.Model {
  checkOutTime?: number;
  displayName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      checkOutTime: 'checkOutTime',
      displayName: 'displayName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkOutTime: 'number',
      displayName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSubscribedCalendarResponseBodySubscribeScope extends $tea.Model {
  corpIds?: string[];
  openConversationIds?: string[];
  unionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      corpIds: 'corpIds',
      openConversationIds: 'openConversationIds',
      unionIds: 'unionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIds: { 'type': 'array', 'itemType': 'string' },
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      unionIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAclsResponseBodyAclsScope extends $tea.Model {
  scopeType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      scopeType: 'scopeType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAclsResponseBodyAcls extends $tea.Model {
  aclId?: string;
  privilege?: string;
  scope?: ListAclsResponseBodyAclsScope;
  static names(): { [key: string]: string } {
    return {
      aclId: 'aclId',
      privilege: 'privilege',
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aclId: 'string',
      privilege: 'string',
      scope: ListAclsResponseBodyAclsScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAttendeesResponseBodyAttendees extends $tea.Model {
  displayName?: string;
  id?: string;
  isOptional?: boolean;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      isOptional: 'isOptional',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      isOptional: 'boolean',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListCalendarsResponseBodyResponseCalendars extends $tea.Model {
  description?: string;
  eTag?: string;
  id?: string;
  privilege?: string;
  summary?: string;
  timeZone?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      eTag: 'eTag',
      id: 'id',
      privilege: 'privilege',
      summary: 'summary',
      timeZone: 'timeZone',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      eTag: 'string',
      id: 'string',
      privilege: 'string',
      summary: 'string',
      timeZone: 'string',
      type: 'string',
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

export class ListEventsResponseBodyEventsAttendees extends $tea.Model {
  displayName?: string;
  id?: string;
  isOptional?: boolean;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      isOptional: 'isOptional',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      isOptional: 'boolean',
      responseStatus: 'string',
      self: 'boolean',
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

export class ListEventsResponseBodyEventsLocation extends $tea.Model {
  displayName?: string;
  meetingRooms?: string[];
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      meetingRooms: 'meetingRooms',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      meetingRooms: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsOnlineMeetingInfo extends $tea.Model {
  conferenceId?: string;
  extraInfo?: { [key: string]: any };
  type?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      extraInfo: 'extraInfo',
      type: 'type',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsOrganizer extends $tea.Model {
  displayName?: string;
  id?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
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

export class ListEventsResponseBodyEventsReminders extends $tea.Model {
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

export class ListEventsResponseBodyEvents extends $tea.Model {
  attendees?: ListEventsResponseBodyEventsAttendees[];
  createTime?: string;
  description?: string;
  end?: ListEventsResponseBodyEventsEnd;
  id?: string;
  isAllDay?: boolean;
  location?: ListEventsResponseBodyEventsLocation;
  onlineMeetingInfo?: ListEventsResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListEventsResponseBodyEventsOrganizer;
  recurrence?: ListEventsResponseBodyEventsRecurrence;
  reminders?: ListEventsResponseBodyEventsReminders[];
  seriesMasterId?: string;
  start?: ListEventsResponseBodyEventsStart;
  status?: string;
  summary?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      recurrence: 'recurrence',
      reminders: 'reminders',
      seriesMasterId: 'seriesMasterId',
      start: 'start',
      status: 'status',
      summary: 'summary',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': ListEventsResponseBodyEventsAttendees },
      createTime: 'string',
      description: 'string',
      end: ListEventsResponseBodyEventsEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: ListEventsResponseBodyEventsLocation,
      onlineMeetingInfo: ListEventsResponseBodyEventsOnlineMeetingInfo,
      organizer: ListEventsResponseBodyEventsOrganizer,
      recurrence: ListEventsResponseBodyEventsRecurrence,
      reminders: { 'type': 'array', 'itemType': ListEventsResponseBodyEventsReminders },
      seriesMasterId: 'string',
      start: ListEventsResponseBodyEventsStart,
      status: 'string',
      summary: 'string',
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsAttendees extends $tea.Model {
  displayName?: string;
  id?: string;
  isOptional?: boolean;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      isOptional: 'isOptional',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      isOptional: 'boolean',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsEnd extends $tea.Model {
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

export class ListEventsInstancesResponseBodyEventsLocation extends $tea.Model {
  displayName?: string;
  meetingRooms?: string[];
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      meetingRooms: 'meetingRooms',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      meetingRooms: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsOnlineMeetingInfo extends $tea.Model {
  conferenceId?: string;
  type?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      type: 'type',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      type: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsOrganizer extends $tea.Model {
  displayName?: string;
  id?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsRecurrence extends $tea.Model {
  pattern?: ListEventsInstancesResponseBodyEventsRecurrencePattern;
  range?: ListEventsInstancesResponseBodyEventsRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: ListEventsInstancesResponseBodyEventsRecurrencePattern,
      range: ListEventsInstancesResponseBodyEventsRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsReminders extends $tea.Model {
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

export class ListEventsInstancesResponseBodyEventsStart extends $tea.Model {
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

export class ListEventsInstancesResponseBodyEvents extends $tea.Model {
  attendees?: ListEventsInstancesResponseBodyEventsAttendees[];
  createTime?: string;
  description?: string;
  end?: ListEventsInstancesResponseBodyEventsEnd;
  id?: string;
  isAllDay?: boolean;
  location?: ListEventsInstancesResponseBodyEventsLocation;
  onlineMeetingInfo?: ListEventsInstancesResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListEventsInstancesResponseBodyEventsOrganizer;
  recurrence?: ListEventsInstancesResponseBodyEventsRecurrence;
  reminders?: ListEventsInstancesResponseBodyEventsReminders[];
  seriesMasterId?: string;
  start?: ListEventsInstancesResponseBodyEventsStart;
  status?: string;
  summary?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      recurrence: 'recurrence',
      reminders: 'reminders',
      seriesMasterId: 'seriesMasterId',
      start: 'start',
      status: 'status',
      summary: 'summary',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': ListEventsInstancesResponseBodyEventsAttendees },
      createTime: 'string',
      description: 'string',
      end: ListEventsInstancesResponseBodyEventsEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: ListEventsInstancesResponseBodyEventsLocation,
      onlineMeetingInfo: ListEventsInstancesResponseBodyEventsOnlineMeetingInfo,
      organizer: ListEventsInstancesResponseBodyEventsOrganizer,
      recurrence: ListEventsInstancesResponseBodyEventsRecurrence,
      reminders: { 'type': 'array', 'itemType': ListEventsInstancesResponseBodyEventsReminders },
      seriesMasterId: 'string',
      start: ListEventsInstancesResponseBodyEventsStart,
      status: 'string',
      summary: 'string',
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsAttendees extends $tea.Model {
  displayName?: string;
  id?: string;
  isOptional?: boolean;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      isOptional: 'isOptional',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      isOptional: 'boolean',
      responseStatus: 'string',
      self: 'boolean',
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

export class ListEventsViewResponseBodyEventsLocation extends $tea.Model {
  displayName?: string;
  meetingRooms?: string[];
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      meetingRooms: 'meetingRooms',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      meetingRooms: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsOnlineMeetingInfo extends $tea.Model {
  conferenceId?: string;
  extraInfo?: { [key: string]: any };
  type?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      extraInfo: 'extraInfo',
      type: 'type',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      extraInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      type: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsOrganizer extends $tea.Model {
  displayName?: string;
  id?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
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

export class ListEventsViewResponseBodyEvents extends $tea.Model {
  attendees?: ListEventsViewResponseBodyEventsAttendees[];
  createTime?: string;
  description?: string;
  end?: ListEventsViewResponseBodyEventsEnd;
  id?: string;
  isAllDay?: boolean;
  location?: ListEventsViewResponseBodyEventsLocation;
  onlineMeetingInfo?: ListEventsViewResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListEventsViewResponseBodyEventsOrganizer;
  recurrence?: ListEventsViewResponseBodyEventsRecurrence;
  seriesMasterId?: string;
  start?: ListEventsViewResponseBodyEventsStart;
  status?: string;
  summary?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      recurrence: 'recurrence',
      seriesMasterId: 'seriesMasterId',
      start: 'start',
      status: 'status',
      summary: 'summary',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': ListEventsViewResponseBodyEventsAttendees },
      createTime: 'string',
      description: 'string',
      end: ListEventsViewResponseBodyEventsEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: ListEventsViewResponseBodyEventsLocation,
      onlineMeetingInfo: ListEventsViewResponseBodyEventsOnlineMeetingInfo,
      organizer: ListEventsViewResponseBodyEventsOrganizer,
      recurrence: ListEventsViewResponseBodyEventsRecurrence,
      seriesMasterId: 'string',
      start: ListEventsViewResponseBodyEventsStart,
      status: 'string',
      summary: 'string',
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestAttendees extends $tea.Model {
  id?: string;
  isOptional?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      isOptional: 'isOptional',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      isOptional: 'boolean',
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

export class PatchEventRequestRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
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

export class PatchEventResponseBodyAttendees extends $tea.Model {
  displayName?: string;
  id?: string;
  isOptional?: boolean;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      isOptional: 'isOptional',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      isOptional: 'boolean',
      responseStatus: 'string',
      self: 'boolean',
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

export class PatchEventResponseBodyLocation extends $tea.Model {
  displayName?: string;
  meetingRooms?: string[];
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      meetingRooms: 'meetingRooms',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      meetingRooms: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyOrganizer extends $tea.Model {
  displayName?: string;
  id?: string;
  responseStatus?: string;
  self?: boolean;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      id: 'id',
      responseStatus: 'responseStatus',
      self: 'self',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      id: 'string',
      responseStatus: 'string',
      self: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBodyRecurrenceRange extends $tea.Model {
  endDate?: string;
  numberOfOccurrences?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      endDate: 'endDate',
      numberOfOccurrences: 'numberOfOccurrences',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endDate: 'string',
      numberOfOccurrences: 'number',
      type: 'string',
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

export class PatchEventResponseBodyReminders extends $tea.Model {
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

export class UpdateSubscribedCalendarsRequestSubscribeScope extends $tea.Model {
  corpIds?: string[];
  openConversationIds?: string[];
  unionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      corpIds: 'corpIds',
      openConversationIds: 'openConversationIds',
      unionIds: 'unionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIds: { 'type': 'array', 'itemType': 'string' },
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      unionIds: { 'type': 'array', 'itemType': 'string' },
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


  async addAttendee(userId: string, calendarId: string, eventId: string, request: AddAttendeeRequest): Promise<AddAttendeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAttendeeHeaders({ });
    return await this.addAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async addAttendeeWithOptions(userId: string, calendarId: string, eventId: string, request: AddAttendeeRequest, headers: AddAttendeeHeaders, runtime: $Util.RuntimeOptions): Promise<AddAttendeeResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendeesToAdd)) {
      body["attendeesToAdd"] = request.attendeesToAdd;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AddAttendeeResponse>(await this.doROARequest("AddAttendee", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees`, "none", req, runtime), new AddAttendeeResponse({}));
  }

  async checkIn(userId: string, calendarId: string, eventId: string): Promise<CheckInResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckInHeaders({ });
    return await this.checkInWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  async checkInWithOptions(userId: string, calendarId: string, eventId: string, headers: CheckInHeaders, runtime: $Util.RuntimeOptions): Promise<CheckInResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<CheckInResponse>(await this.doROARequest("CheckIn", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/checkIn`, "json", req, runtime), new CheckInResponse({}));
  }

  async convertLegacyEventId(userId: string, request: ConvertLegacyEventIdRequest): Promise<ConvertLegacyEventIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConvertLegacyEventIdHeaders({ });
    return await this.convertLegacyEventIdWithOptions(userId, request, headers, runtime);
  }

  async convertLegacyEventIdWithOptions(userId: string, request: ConvertLegacyEventIdRequest, headers: ConvertLegacyEventIdHeaders, runtime: $Util.RuntimeOptions): Promise<ConvertLegacyEventIdResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.legacyEventIds)) {
      body["legacyEventIds"] = request.legacyEventIds;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ConvertLegacyEventIdResponse>(await this.doROARequest("ConvertLegacyEventId", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/legacyEventIds/convert`, "json", req, runtime), new ConvertLegacyEventIdResponse({}));
  }

  async createAcls(userId: string, calendarId: string, request: CreateAclsRequest): Promise<CreateAclsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAclsHeaders({ });
    return await this.createAclsWithOptions(userId, calendarId, request, headers, runtime);
  }

  async createAclsWithOptions(userId: string, calendarId: string, request: CreateAclsRequest, headers: CreateAclsHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAclsResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.privilege)) {
      body["privilege"] = request.privilege;
    }

    if (!Util.isUnset($tea.toMap(request.scope))) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.sendMsg)) {
      body["sendMsg"] = request.sendMsg;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateAclsResponse>(await this.doROARequest("CreateAcls", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/acls`, "json", req, runtime), new CreateAclsResponse({}));
  }

  async createEvent(userId: string, calendarId: string, request: CreateEventRequest): Promise<CreateEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateEventHeaders({ });
    return await this.createEventWithOptions(userId, calendarId, request, headers, runtime);
  }

  async createEventWithOptions(userId: string, calendarId: string, request: CreateEventRequest, headers: CreateEventHeaders, runtime: $Util.RuntimeOptions): Promise<CreateEventResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendees)) {
      body["attendees"] = request.attendees;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset($tea.toMap(request.end))) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.extra)) {
      body["extra"] = request.extra;
    }

    if (!Util.isUnset(request.isAllDay)) {
      body["isAllDay"] = request.isAllDay;
    }

    if (!Util.isUnset($tea.toMap(request.location))) {
      body["location"] = request.location;
    }

    if (!Util.isUnset($tea.toMap(request.onlineMeetingInfo))) {
      body["onlineMeetingInfo"] = request.onlineMeetingInfo;
    }

    if (!Util.isUnset($tea.toMap(request.recurrence))) {
      body["recurrence"] = request.recurrence;
    }

    if (!Util.isUnset(request.reminders)) {
      body["reminders"] = request.reminders;
    }

    if (!Util.isUnset($tea.toMap(request.start))) {
      body["start"] = request.start;
    }

    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateEventResponse>(await this.doROARequest("CreateEvent", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events`, "json", req, runtime), new CreateEventResponse({}));
  }

  async createSubscribedCalendar(userId: string, request: CreateSubscribedCalendarRequest): Promise<CreateSubscribedCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSubscribedCalendarHeaders({ });
    return await this.createSubscribedCalendarWithOptions(userId, request, headers, runtime);
  }

  async createSubscribedCalendarWithOptions(userId: string, request: CreateSubscribedCalendarRequest, headers: CreateSubscribedCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSubscribedCalendarResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.managers)) {
      body["managers"] = request.managers;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset($tea.toMap(request.subscribeScope))) {
      body["subscribeScope"] = request.subscribeScope;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateSubscribedCalendarResponse>(await this.doROARequest("CreateSubscribedCalendar", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/subscribedCalendars`, "json", req, runtime), new CreateSubscribedCalendarResponse({}));
  }

  async deleteAcl(userId: string, calendarId: string, aclId: string): Promise<DeleteAclResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAclHeaders({ });
    return await this.deleteAclWithOptions(userId, calendarId, aclId, headers, runtime);
  }

  async deleteAclWithOptions(userId: string, calendarId: string, aclId: string, headers: DeleteAclHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAclResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    aclId = OpenApiUtil.getEncodeParam(aclId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<DeleteAclResponse>(await this.doROARequest("DeleteAcl", "calendar_1.0", "HTTP", "DELETE", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/acls/${aclId}`, "none", req, runtime), new DeleteAclResponse({}));
  }

  async deleteEvent(userId: string, calendarId: string, eventId: string): Promise<DeleteEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteEventHeaders({ });
    return await this.deleteEventWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  async deleteEventWithOptions(userId: string, calendarId: string, eventId: string, headers: DeleteEventHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteEventResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<DeleteEventResponse>(await this.doROARequest("DeleteEvent", "calendar_1.0", "HTTP", "DELETE", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`, "none", req, runtime), new DeleteEventResponse({}));
  }

  async deleteSubscribedCalendar(userId: string, calendarId: string): Promise<DeleteSubscribedCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSubscribedCalendarHeaders({ });
    return await this.deleteSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
  }

  async deleteSubscribedCalendarWithOptions(userId: string, calendarId: string, headers: DeleteSubscribedCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSubscribedCalendarResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<DeleteSubscribedCalendarResponse>(await this.doROARequest("DeleteSubscribedCalendar", "calendar_1.0", "HTTP", "DELETE", "AK", `/v1.0/calendar/users/${userId}/subscribedCalendars/${calendarId}`, "json", req, runtime), new DeleteSubscribedCalendarResponse({}));
  }

  async generateCaldavAccount(userId: string, request: GenerateCaldavAccountRequest): Promise<GenerateCaldavAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GenerateCaldavAccountHeaders({ });
    return await this.generateCaldavAccountWithOptions(userId, request, headers, runtime);
  }

  async generateCaldavAccountWithOptions(userId: string, request: GenerateCaldavAccountRequest, headers: GenerateCaldavAccountHeaders, runtime: $Util.RuntimeOptions): Promise<GenerateCaldavAccountResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.device)) {
      body["device"] = request.device;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingUid)) {
      realHeaders["dingUid"] = Util.toJSONString(headers.dingUid);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GenerateCaldavAccountResponse>(await this.doROARequest("GenerateCaldavAccount", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/caldavAccounts`, "json", req, runtime), new GenerateCaldavAccountResponse({}));
  }

  async getEvent(userId: string, calendarId: string, eventId: string, request: GetEventRequest): Promise<GetEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEventHeaders({ });
    return await this.getEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async getEventWithOptions(userId: string, calendarId: string, eventId: string, request: GetEventRequest, headers: GetEventHeaders, runtime: $Util.RuntimeOptions): Promise<GetEventResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxAttendees)) {
      query["maxAttendees"] = request.maxAttendees;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetEventResponse>(await this.doROARequest("GetEvent", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`, "json", req, runtime), new GetEventResponse({}));
  }

  async getSchedule(userId: string, request: GetScheduleRequest): Promise<GetScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetScheduleHeaders({ });
    return await this.getScheduleWithOptions(userId, request, headers, runtime);
  }

  async getScheduleWithOptions(userId: string, request: GetScheduleRequest, headers: GetScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<GetScheduleResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetScheduleResponse>(await this.doROARequest("GetSchedule", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/querySchedule`, "json", req, runtime), new GetScheduleResponse({}));
  }

  async getSignInList(userId: string, calendarId: string, eventId: string, request: GetSignInListRequest): Promise<GetSignInListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignInListHeaders({ });
    return await this.getSignInListWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async getSignInListWithOptions(userId: string, calendarId: string, eventId: string, request: GetSignInListRequest, headers: GetSignInListHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignInListResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetSignInListResponse>(await this.doROARequest("GetSignInList", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signin`, "json", req, runtime), new GetSignInListResponse({}));
  }

  async getSignOutList(userId: string, calendarId: string, eventId: string, request: GetSignOutListRequest): Promise<GetSignOutListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignOutListHeaders({ });
    return await this.getSignOutListWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async getSignOutListWithOptions(userId: string, calendarId: string, eventId: string, request: GetSignOutListRequest, headers: GetSignOutListHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignOutListResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetSignOutListResponse>(await this.doROARequest("GetSignOutList", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signOut`, "json", req, runtime), new GetSignOutListResponse({}));
  }

  async getSubscribedCalendar(userId: string, calendarId: string): Promise<GetSubscribedCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSubscribedCalendarHeaders({ });
    return await this.getSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
  }

  async getSubscribedCalendarWithOptions(userId: string, calendarId: string, headers: GetSubscribedCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<GetSubscribedCalendarResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetSubscribedCalendarResponse>(await this.doROARequest("GetSubscribedCalendar", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/subscribedCalendars/${calendarId}`, "json", req, runtime), new GetSubscribedCalendarResponse({}));
  }

  async listAcls(userId: string, calendarId: string): Promise<ListAclsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAclsHeaders({ });
    return await this.listAclsWithOptions(userId, calendarId, headers, runtime);
  }

  async listAclsWithOptions(userId: string, calendarId: string, headers: ListAclsHeaders, runtime: $Util.RuntimeOptions): Promise<ListAclsResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<ListAclsResponse>(await this.doROARequest("ListAcls", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/acls`, "json", req, runtime), new ListAclsResponse({}));
  }

  async listAttendees(userId: string, calendarId: string, eventId: string, request: ListAttendeesRequest): Promise<ListAttendeesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAttendeesHeaders({ });
    return await this.listAttendeesWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async listAttendeesWithOptions(userId: string, calendarId: string, eventId: string, request: ListAttendeesRequest, headers: ListAttendeesHeaders, runtime: $Util.RuntimeOptions): Promise<ListAttendeesResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let query : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListAttendeesResponse>(await this.doROARequest("ListAttendees", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees`, "json", req, runtime), new ListAttendeesResponse({}));
  }

  async listCalendars(userId: string): Promise<ListCalendarsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCalendarsHeaders({ });
    return await this.listCalendarsWithOptions(userId, headers, runtime);
  }

  async listCalendarsWithOptions(userId: string, headers: ListCalendarsHeaders, runtime: $Util.RuntimeOptions): Promise<ListCalendarsResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<ListCalendarsResponse>(await this.doROARequest("ListCalendars", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars`, "json", req, runtime), new ListCalendarsResponse({}));
  }

  async listEvents(userId: string, calendarId: string, request: ListEventsRequest): Promise<ListEventsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsHeaders({ });
    return await this.listEventsWithOptions(userId, calendarId, request, headers, runtime);
  }

  async listEventsWithOptions(userId: string, calendarId: string, request: ListEventsRequest, headers: ListEventsHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxAttendees)) {
      query["maxAttendees"] = request.maxAttendees;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.showDeleted)) {
      query["showDeleted"] = request.showDeleted;
    }

    if (!Util.isUnset(request.syncToken)) {
      query["syncToken"] = request.syncToken;
    }

    if (!Util.isUnset(request.timeMax)) {
      query["timeMax"] = request.timeMax;
    }

    if (!Util.isUnset(request.timeMin)) {
      query["timeMin"] = request.timeMin;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListEventsResponse>(await this.doROARequest("ListEvents", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events`, "json", req, runtime), new ListEventsResponse({}));
  }

  async listEventsInstances(userId: string, calendarId: string, request: ListEventsInstancesRequest): Promise<ListEventsInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsInstancesHeaders({ });
    return await this.listEventsInstancesWithOptions(userId, calendarId, request, headers, runtime);
  }

  async listEventsInstancesWithOptions(userId: string, calendarId: string, request: ListEventsInstancesRequest, headers: ListEventsInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsInstancesResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxAttendees)) {
      query["maxAttendees"] = request.maxAttendees;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.seriesMasterId)) {
      query["seriesMasterId"] = request.seriesMasterId;
    }

    if (!Util.isUnset(request.startRecurrenceId)) {
      query["startRecurrenceId"] = request.startRecurrenceId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListEventsInstancesResponse>(await this.doROARequest("ListEventsInstances", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/instances`, "json", req, runtime), new ListEventsInstancesResponse({}));
  }

  async listEventsView(userId: string, calendarId: string, request: ListEventsViewRequest): Promise<ListEventsViewResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsViewHeaders({ });
    return await this.listEventsViewWithOptions(userId, calendarId, request, headers, runtime);
  }

  async listEventsViewWithOptions(userId: string, calendarId: string, request: ListEventsViewRequest, headers: ListEventsViewHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsViewResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxAttendees)) {
      query["maxAttendees"] = request.maxAttendees;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.timeMax)) {
      query["timeMax"] = request.timeMax;
    }

    if (!Util.isUnset(request.timeMin)) {
      query["timeMin"] = request.timeMin;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListEventsViewResponse>(await this.doROARequest("ListEventsView", "calendar_1.0", "HTTP", "GET", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/eventsview`, "json", req, runtime), new ListEventsViewResponse({}));
  }

  async patchEvent(userId: string, calendarId: string, eventId: string, request: PatchEventRequest): Promise<PatchEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PatchEventHeaders({ });
    return await this.patchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async patchEventWithOptions(userId: string, calendarId: string, eventId: string, request: PatchEventRequest, headers: PatchEventHeaders, runtime: $Util.RuntimeOptions): Promise<PatchEventResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendees)) {
      body["attendees"] = request.attendees;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset($tea.toMap(request.end))) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.extra)) {
      body["extra"] = request.extra;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.isAllDay)) {
      body["isAllDay"] = request.isAllDay;
    }

    if (!Util.isUnset($tea.toMap(request.location))) {
      body["location"] = request.location;
    }

    if (!Util.isUnset($tea.toMap(request.recurrence))) {
      body["recurrence"] = request.recurrence;
    }

    if (!Util.isUnset(request.reminders)) {
      body["reminders"] = request.reminders;
    }

    if (!Util.isUnset($tea.toMap(request.start))) {
      body["start"] = request.start;
    }

    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<PatchEventResponse>(await this.doROARequest("PatchEvent", "calendar_1.0", "HTTP", "PUT", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`, "json", req, runtime), new PatchEventResponse({}));
  }

  async removeAttendee(userId: string, calendarId: string, eventId: string, request: RemoveAttendeeRequest): Promise<RemoveAttendeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveAttendeeHeaders({ });
    return await this.removeAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async removeAttendeeWithOptions(userId: string, calendarId: string, eventId: string, request: RemoveAttendeeRequest, headers: RemoveAttendeeHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveAttendeeResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendeesToRemove)) {
      body["attendeesToRemove"] = request.attendeesToRemove;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RemoveAttendeeResponse>(await this.doROARequest("RemoveAttendee", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees/batchRemove`, "none", req, runtime), new RemoveAttendeeResponse({}));
  }

  async respondEvent(userId: string, calendarId: string, eventId: string, request: RespondEventRequest): Promise<RespondEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RespondEventHeaders({ });
    return await this.respondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  async respondEventWithOptions(userId: string, calendarId: string, eventId: string, request: RespondEventRequest, headers: RespondEventHeaders, runtime: $Util.RuntimeOptions): Promise<RespondEventResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.responseStatus)) {
      body["responseStatus"] = request.responseStatus;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RespondEventResponse>(await this.doROARequest("RespondEvent", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/respond`, "none", req, runtime), new RespondEventResponse({}));
  }

  async signIn(userId: string, calendarId: string, eventId: string): Promise<SignInResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignInHeaders({ });
    return await this.signInWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  async signInWithOptions(userId: string, calendarId: string, eventId: string, headers: SignInHeaders, runtime: $Util.RuntimeOptions): Promise<SignInResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<SignInResponse>(await this.doROARequest("SignIn", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signin`, "json", req, runtime), new SignInResponse({}));
  }

  async signOut(userId: string, calendarId: string, eventId: string): Promise<SignOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignOutHeaders({ });
    return await this.signOutWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  async signOutWithOptions(userId: string, calendarId: string, eventId: string, headers: SignOutHeaders, runtime: $Util.RuntimeOptions): Promise<SignOutResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    eventId = OpenApiUtil.getEncodeParam(eventId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<SignOutResponse>(await this.doROARequest("SignOut", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signOut`, "json", req, runtime), new SignOutResponse({}));
  }

  async subscribeCalendar(userId: string, calendarId: string): Promise<SubscribeCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubscribeCalendarHeaders({ });
    return await this.subscribeCalendarWithOptions(userId, calendarId, headers, runtime);
  }

  async subscribeCalendarWithOptions(userId: string, calendarId: string, headers: SubscribeCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<SubscribeCalendarResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<SubscribeCalendarResponse>(await this.doROARequest("SubscribeCalendar", "calendar_1.0", "HTTP", "POST", "AK", `/v1.0/calendar/users/${userId}/calendars/${calendarId}/subscribe`, "none", req, runtime), new SubscribeCalendarResponse({}));
  }

  async updateSubscribedCalendars(calendarId: string, userId: string, request: UpdateSubscribedCalendarsRequest): Promise<UpdateSubscribedCalendarsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSubscribedCalendarsHeaders({ });
    return await this.updateSubscribedCalendarsWithOptions(calendarId, userId, request, headers, runtime);
  }

  async updateSubscribedCalendarsWithOptions(calendarId: string, userId: string, request: UpdateSubscribedCalendarsRequest, headers: UpdateSubscribedCalendarsHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSubscribedCalendarsResponse> {
    Util.validateModel(request);
    calendarId = OpenApiUtil.getEncodeParam(calendarId);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.managers)) {
      body["managers"] = request.managers;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset($tea.toMap(request.subscribeScope))) {
      body["subscribeScope"] = request.subscribeScope;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateSubscribedCalendarsResponse>(await this.doROARequest("UpdateSubscribedCalendars", "calendar_1.0", "HTTP", "PUT", "AK", `/v1.0/calendar/users/${userId}/subscribedCalendars/${calendarId}`, "json", req, runtime), new UpdateSubscribedCalendarsResponse({}));
  }

}
