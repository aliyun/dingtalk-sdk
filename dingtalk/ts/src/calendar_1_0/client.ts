// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddAttendeeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAttendeeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  attendeesToAdd?: AddAttendeeRequestAttendeesToAdd[];
  chatNotification?: boolean;
  pushNotification?: boolean;
  static names(): { [key: string]: string } {
    return {
      attendeesToAdd: 'attendeesToAdd',
      chatNotification: 'chatNotification',
      pushNotification: 'pushNotification',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendeesToAdd: { 'type': 'array', 'itemType': AddAttendeeRequestAttendeesToAdd },
      chatNotification: 'boolean',
      pushNotification: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAttendeeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMeetingRoomsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMeetingRoomsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  meetingRoomsToAdd?: AddMeetingRoomsRequestMeetingRoomsToAdd[];
  static names(): { [key: string]: string } {
    return {
      meetingRoomsToAdd: 'meetingRoomsToAdd',
    };
  }

  static types(): { [key: string]: any } {
    return {
      meetingRoomsToAdd: { 'type': 'array', 'itemType': AddMeetingRoomsRequestMeetingRoomsToAdd },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMeetingRoomsResponseBody extends $tea.Model {
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

export class AddMeetingRoomsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddMeetingRoomsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AddMeetingRoomsResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckInResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConvertLegacyEventIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @remarks
   * This parameter is required.
   */
  privilege?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  scope?: CreateAclsRequestScope;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAclsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateAclsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequest extends $tea.Model {
  attendees?: CreateEventRequestAttendees[];
  cardInstances?: CreateEventRequestCardInstances[];
  description?: string;
  end?: CreateEventRequestEnd;
  extra?: { [key: string]: string };
  isAllDay?: boolean;
  location?: CreateEventRequestLocation;
  onlineMeetingInfo?: CreateEventRequestOnlineMeetingInfo;
  recurrence?: CreateEventRequestRecurrence;
  reminders?: CreateEventRequestReminders[];
  richTextDescription?: CreateEventRequestRichTextDescription;
  /**
   * @remarks
   * This parameter is required.
   */
  start?: CreateEventRequestStart;
  /**
   * @remarks
   * This parameter is required.
   */
  summary?: string;
  uiConfigs?: CreateEventRequestUiConfigs[];
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      cardInstances: 'cardInstances',
      description: 'description',
      end: 'end',
      extra: 'extra',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      recurrence: 'recurrence',
      reminders: 'reminders',
      richTextDescription: 'richTextDescription',
      start: 'start',
      summary: 'summary',
      uiConfigs: 'uiConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': CreateEventRequestAttendees },
      cardInstances: { 'type': 'array', 'itemType': CreateEventRequestCardInstances },
      description: 'string',
      end: CreateEventRequestEnd,
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      isAllDay: 'boolean',
      location: CreateEventRequestLocation,
      onlineMeetingInfo: CreateEventRequestOnlineMeetingInfo,
      recurrence: CreateEventRequestRecurrence,
      reminders: { 'type': 'array', 'itemType': CreateEventRequestReminders },
      richTextDescription: CreateEventRequestRichTextDescription,
      start: CreateEventRequestStart,
      summary: 'string',
      uiConfigs: { 'type': 'array', 'itemType': CreateEventRequestUiConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponseBody extends $tea.Model {
  attendees?: CreateEventResponseBodyAttendees[];
  cardInstances?: CreateEventResponseBodyCardInstances[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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
  richTextDescription?: CreateEventResponseBodyRichTextDescription;
  /**
   * @remarks
   * This parameter is required.
   */
  start?: CreateEventResponseBodyStart;
  summary?: string;
  uiConfigs?: CreateEventResponseBodyUiConfigs[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      cardInstances: 'cardInstances',
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
      richTextDescription: 'richTextDescription',
      start: 'start',
      summary: 'summary',
      uiConfigs: 'uiConfigs',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': CreateEventResponseBodyAttendees },
      cardInstances: { 'type': 'array', 'itemType': CreateEventResponseBodyCardInstances },
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
      richTextDescription: CreateEventResponseBodyRichTextDescription,
      start: CreateEventResponseBodyStart,
      summary: 'string',
      uiConfigs: { 'type': 'array', 'itemType': CreateEventResponseBodyUiConfigs },
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeRequest extends $tea.Model {
  attendees?: CreateEventByMeRequestAttendees[];
  description?: string;
  end?: CreateEventByMeRequestEnd;
  extra?: { [key: string]: string };
  isAllDay?: boolean;
  location?: CreateEventByMeRequestLocation;
  onlineMeetingInfo?: CreateEventByMeRequestOnlineMeetingInfo;
  recurrence?: CreateEventByMeRequestRecurrence;
  reminders?: CreateEventByMeRequestReminders[];
  richTextDescription?: CreateEventByMeRequestRichTextDescription;
  /**
   * @remarks
   * This parameter is required.
   */
  start?: CreateEventByMeRequestStart;
  /**
   * @remarks
   * This parameter is required.
   */
  summary?: string;
  uiConfigs?: CreateEventByMeRequestUiConfigs[];
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
      richTextDescription: 'richTextDescription',
      start: 'start',
      summary: 'summary',
      uiConfigs: 'uiConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': CreateEventByMeRequestAttendees },
      description: 'string',
      end: CreateEventByMeRequestEnd,
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      isAllDay: 'boolean',
      location: CreateEventByMeRequestLocation,
      onlineMeetingInfo: CreateEventByMeRequestOnlineMeetingInfo,
      recurrence: CreateEventByMeRequestRecurrence,
      reminders: { 'type': 'array', 'itemType': CreateEventByMeRequestReminders },
      richTextDescription: CreateEventByMeRequestRichTextDescription,
      start: CreateEventByMeRequestStart,
      summary: 'string',
      uiConfigs: { 'type': 'array', 'itemType': CreateEventByMeRequestUiConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeResponseBody extends $tea.Model {
  attendees?: CreateEventByMeResponseBodyAttendees[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createTime?: string;
  description?: string;
  end?: CreateEventByMeResponseBodyEnd;
  id?: string;
  isAllDay?: boolean;
  location?: CreateEventByMeResponseBodyLocation;
  onlineMeetingInfo?: CreateEventByMeResponseBodyOnlineMeetingInfo;
  organizer?: CreateEventByMeResponseBodyOrganizer;
  recurrence?: CreateEventByMeResponseBodyRecurrence;
  reminders?: CreateEventByMeResponseBodyReminders[];
  richTextDescription?: CreateEventByMeResponseBodyRichTextDescription;
  /**
   * @remarks
   * This parameter is required.
   */
  start?: CreateEventByMeResponseBodyStart;
  summary?: string;
  uiConfigs?: CreateEventByMeResponseBodyUiConfigs[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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
      richTextDescription: 'richTextDescription',
      start: 'start',
      summary: 'summary',
      uiConfigs: 'uiConfigs',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': CreateEventByMeResponseBodyAttendees },
      createTime: 'string',
      description: 'string',
      end: CreateEventByMeResponseBodyEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: CreateEventByMeResponseBodyLocation,
      onlineMeetingInfo: CreateEventByMeResponseBodyOnlineMeetingInfo,
      organizer: CreateEventByMeResponseBodyOrganizer,
      recurrence: CreateEventByMeResponseBodyRecurrence,
      reminders: { 'type': 'array', 'itemType': CreateEventByMeResponseBodyReminders },
      richTextDescription: CreateEventByMeResponseBodyRichTextDescription,
      start: CreateEventByMeResponseBodyStart,
      summary: 'string',
      uiConfigs: { 'type': 'array', 'itemType': CreateEventByMeResponseBodyUiConfigs },
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateEventByMeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateEventByMeResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateSubscribedCalendarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEventRequest extends $tea.Model {
  pushNotification?: boolean;
  static names(): { [key: string]: string } {
    return {
      pushNotification: 'pushNotification',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pushNotification: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteSubscribedCalendarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GenerateCaldavAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  cardInstances?: GetEventResponseBodyCardInstances[];
  categories?: GetEventResponseBodyCategories[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createTime?: string;
  description?: string;
  end?: GetEventResponseBodyEnd;
  extendedProperties?: GetEventResponseBodyExtendedProperties;
  id?: string;
  isAllDay?: boolean;
  location?: GetEventResponseBodyLocation;
  meetingRooms?: GetEventResponseBodyMeetingRooms[];
  onlineMeetingInfo?: GetEventResponseBodyOnlineMeetingInfo;
  organizer?: GetEventResponseBodyOrganizer;
  originStart?: GetEventResponseBodyOriginStart;
  recurrence?: GetEventResponseBodyRecurrence;
  reminders?: GetEventResponseBodyReminders[];
  richTextDescription?: GetEventResponseBodyRichTextDescription;
  seriesMasterId?: string;
  start?: GetEventResponseBodyStart;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 已取消、删除的日程是cancelled
   */
  status?: string;
  summary?: string;
  uiConfigs?: GetEventResponseBodyUiConfigs[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      cardInstances: 'cardInstances',
      categories: 'categories',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      extendedProperties: 'extendedProperties',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      meetingRooms: 'meetingRooms',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      originStart: 'originStart',
      recurrence: 'recurrence',
      reminders: 'reminders',
      richTextDescription: 'richTextDescription',
      seriesMasterId: 'seriesMasterId',
      start: 'start',
      status: 'status',
      summary: 'summary',
      uiConfigs: 'uiConfigs',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': GetEventResponseBodyAttendees },
      cardInstances: { 'type': 'array', 'itemType': GetEventResponseBodyCardInstances },
      categories: { 'type': 'array', 'itemType': GetEventResponseBodyCategories },
      createTime: 'string',
      description: 'string',
      end: GetEventResponseBodyEnd,
      extendedProperties: GetEventResponseBodyExtendedProperties,
      id: 'string',
      isAllDay: 'boolean',
      location: GetEventResponseBodyLocation,
      meetingRooms: { 'type': 'array', 'itemType': GetEventResponseBodyMeetingRooms },
      onlineMeetingInfo: GetEventResponseBodyOnlineMeetingInfo,
      organizer: GetEventResponseBodyOrganizer,
      originStart: GetEventResponseBodyOriginStart,
      recurrence: GetEventResponseBodyRecurrence,
      reminders: { 'type': 'array', 'itemType': GetEventResponseBodyReminders },
      richTextDescription: GetEventResponseBodyRichTextDescription,
      seriesMasterId: 'string',
      start: GetEventResponseBodyStart,
      status: 'string',
      summary: 'string',
      uiConfigs: { 'type': 'array', 'itemType': GetEventResponseBodyUiConfigs },
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeetingRoomsScheduleHeaders extends $tea.Model {
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

export class GetMeetingRoomsScheduleRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  endTime?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  roomIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  startTime?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      roomIds: 'roomIds',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'string',
      roomIds: { 'type': 'array', 'itemType': 'string' },
      startTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeetingRoomsScheduleResponseBody extends $tea.Model {
  scheduleInformation?: GetMeetingRoomsScheduleResponseBodyScheduleInformation[];
  static names(): { [key: string]: string } {
    return {
      scheduleInformation: 'scheduleInformation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scheduleInformation: { 'type': 'array', 'itemType': GetMeetingRoomsScheduleResponseBodyScheduleInformation },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeetingRoomsScheduleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMeetingRoomsScheduleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetMeetingRoomsScheduleResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  endTime?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  startTime?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetScheduleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetScheduleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleByMeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleByMeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  endTime?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  startTime?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class GetScheduleByMeResponseBody extends $tea.Model {
  scheduleInformation?: GetScheduleByMeResponseBodyScheduleInformation[];
  static names(): { [key: string]: string } {
    return {
      scheduleInformation: 'scheduleInformation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scheduleInformation: { 'type': 'array', 'itemType': GetScheduleByMeResponseBodyScheduleInformation },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleByMeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetScheduleByMeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetScheduleByMeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignInLinkHeaders extends $tea.Model {
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

export class GetSignInLinkResponseBody extends $tea.Model {
  signInLink?: string;
  static names(): { [key: string]: string } {
    return {
      signInLink: 'signInLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      signInLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignInLinkResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignInLinkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSignInLinkResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * check_in
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignInListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSignInListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignOutLinkHeaders extends $tea.Model {
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

export class GetSignOutLinkResponseBody extends $tea.Model {
  signOutLink?: string;
  static names(): { [key: string]: string } {
    return {
      signOutLink: 'signOutLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      signOutLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignOutLinkResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignOutLinkResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSignOutLinkResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sign_out
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignOutListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSubscribedCalendarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAclsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAttendeesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListCalendarsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @example
   * 100
   */
  maxAttendees?: number;
  maxResults?: number;
  nextToken?: string;
  seriesMasterId?: string;
  showDeleted?: boolean;
  syncToken?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  timeMax?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  timeMin?: string;
  static names(): { [key: string]: string } {
    return {
      maxAttendees: 'maxAttendees',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      seriesMasterId: 'seriesMasterId',
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
      seriesMasterId: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListEventsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @example
   * 100
   */
  maxAttendees?: number;
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cnNTbW1YbxxxxdEgvdlQrQT09
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListEventsInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  timeMax?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListEventsViewResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListEventsViewResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeRequest extends $tea.Model {
  maxAttendees?: number;
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  timeMax?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class ListEventsViewByMeResponseBody extends $tea.Model {
  events?: ListEventsViewByMeResponseBodyEvents[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      events: 'events',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      events: { 'type': 'array', 'itemType': ListEventsViewByMeResponseBodyEvents },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListEventsViewByMeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListEventsViewByMeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInstancesHeaders extends $tea.Model {
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

export class ListInstancesRequest extends $tea.Model {
  /**
   * @example
   * 100
   */
  maxAttendees?: number;
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  timeMax?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class ListInstancesResponseBody extends $tea.Model {
  events?: ListInstancesResponseBodyEvents[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      events: 'events',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      events: { 'type': 'array', 'itemType': ListInstancesResponseBodyEvents },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInstancesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListInstancesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ListInstancesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MeetingRoomRespondHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  userAgent?: string;
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      userAgent: 'userAgent',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      userAgent: 'string',
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MeetingRoomRespondRequest extends $tea.Model {
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

export class MeetingRoomRespondResponseBody extends $tea.Model {
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

export class MeetingRoomRespondResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MeetingRoomRespondResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: MeetingRoomRespondResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequest extends $tea.Model {
  attendees?: PatchEventRequestAttendees[];
  cardInstances?: PatchEventRequestCardInstances[];
  description?: string;
  end?: PatchEventRequestEnd;
  extra?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  isAllDay?: boolean;
  location?: PatchEventRequestLocation;
  onlineMeetingInfo?: PatchEventRequestOnlineMeetingInfo;
  recurrence?: PatchEventRequestRecurrence;
  reminders?: PatchEventRequestReminders[];
  richTextDescription?: PatchEventRequestRichTextDescription;
  start?: PatchEventRequestStart;
  summary?: string;
  uiConfigs?: PatchEventRequestUiConfigs[];
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      cardInstances: 'cardInstances',
      description: 'description',
      end: 'end',
      extra: 'extra',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      onlineMeetingInfo: 'onlineMeetingInfo',
      recurrence: 'recurrence',
      reminders: 'reminders',
      richTextDescription: 'richTextDescription',
      start: 'start',
      summary: 'summary',
      uiConfigs: 'uiConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': PatchEventRequestAttendees },
      cardInstances: { 'type': 'array', 'itemType': PatchEventRequestCardInstances },
      description: 'string',
      end: PatchEventRequestEnd,
      extra: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      id: 'string',
      isAllDay: 'boolean',
      location: PatchEventRequestLocation,
      onlineMeetingInfo: PatchEventRequestOnlineMeetingInfo,
      recurrence: PatchEventRequestRecurrence,
      reminders: { 'type': 'array', 'itemType': PatchEventRequestReminders },
      richTextDescription: PatchEventRequestRichTextDescription,
      start: PatchEventRequestStart,
      summary: 'string',
      uiConfigs: { 'type': 'array', 'itemType': PatchEventRequestUiConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponseBody extends $tea.Model {
  attendees?: PatchEventResponseBodyAttendees[];
  cardInstances?: PatchEventResponseBodyCardInstances[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createTime?: string;
  description?: string;
  end?: PatchEventResponseBodyEnd;
  id?: string;
  isAllDay?: boolean;
  location?: PatchEventResponseBodyLocation;
  onlineMeetingInfo?: PatchEventResponseBodyOnlineMeetingInfo;
  organizer?: PatchEventResponseBodyOrganizer;
  recurrence?: PatchEventResponseBodyRecurrence;
  reminders?: PatchEventResponseBodyReminders[];
  richTextDescription?: PatchEventResponseBodyRichTextDescription;
  /**
   * @remarks
   * This parameter is required.
   */
  start?: PatchEventResponseBodyStart;
  summary?: string;
  uiConfigs?: PatchEventResponseBodyUiConfigs[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      cardInstances: 'cardInstances',
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
      richTextDescription: 'richTextDescription',
      start: 'start',
      summary: 'summary',
      uiConfigs: 'uiConfigs',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': PatchEventResponseBodyAttendees },
      cardInstances: { 'type': 'array', 'itemType': PatchEventResponseBodyCardInstances },
      createTime: 'string',
      description: 'string',
      end: PatchEventResponseBodyEnd,
      id: 'string',
      isAllDay: 'boolean',
      location: PatchEventResponseBodyLocation,
      onlineMeetingInfo: PatchEventResponseBodyOnlineMeetingInfo,
      organizer: PatchEventResponseBodyOrganizer,
      recurrence: PatchEventResponseBodyRecurrence,
      reminders: { 'type': 'array', 'itemType': PatchEventResponseBodyReminders },
      richTextDescription: PatchEventResponseBodyRichTextDescription,
      start: PatchEventResponseBodyStart,
      summary: 'string',
      uiConfigs: { 'type': 'array', 'itemType': PatchEventResponseBodyUiConfigs },
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PatchEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PatchEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveAttendeeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveMeetingRoomsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveMeetingRoomsRequest extends $tea.Model {
  meetingRoomsToRemove?: RemoveMeetingRoomsRequestMeetingRoomsToRemove[];
  static names(): { [key: string]: string } {
    return {
      meetingRoomsToRemove: 'meetingRoomsToRemove',
    };
  }

  static types(): { [key: string]: any } {
    return {
      meetingRoomsToRemove: { 'type': 'array', 'itemType': RemoveMeetingRoomsRequestMeetingRoomsToRemove },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveMeetingRoomsResponseBody extends $tea.Model {
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

export class RemoveMeetingRoomsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveMeetingRoomsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: RemoveMeetingRoomsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RespondEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RespondEventRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SignInResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SignOutResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xClientToken?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xClientToken: 'x-client-token',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xClientToken: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferEventRequest extends $tea.Model {
  isExitCalendar?: boolean;
  needNotifyViaO2O?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  newOrganizerId?: string;
  static names(): { [key: string]: string } {
    return {
      isExitCalendar: 'isExitCalendar',
      needNotifyViaO2O: 'needNotifyViaO2O',
      newOrganizerId: 'newOrganizerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isExitCalendar: 'boolean',
      needNotifyViaO2O: 'boolean',
      newOrganizerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferEventResponseBody extends $tea.Model {
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

export class TransferEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TransferEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: TransferEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsubscribeCalendarHeaders extends $tea.Model {
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

export class UnsubscribeCalendarResponseBody extends $tea.Model {
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

export class UnsubscribeCalendarResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UnsubscribeCalendarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UnsubscribeCalendarResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateSubscribedCalendarsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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

export class AddMeetingRoomsRequestMeetingRoomsToAdd extends $tea.Model {
  roomId?: string;
  static names(): { [key: string]: string } {
    return {
      roomId: 'roomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roomId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAclsRequestScope extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  scopeType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class CreateEventRequestCardInstances extends $tea.Model {
  outTrackId?: string;
  scenario?: string;
  static names(): { [key: string]: string } {
    return {
      outTrackId: 'outTrackId',
      scenario: 'scenario',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTrackId: 'string',
      scenario: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestEnd extends $tea.Model {
  /**
   * @example
   * 2020-01-01
   */
  date?: string;
  /**
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  dateTime?: string;
  /**
   * @example
   * Asia/Shanghai
   */
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
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class CreateEventRequestRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventRequestStart extends $tea.Model {
  /**
   * @example
   * 2020-01-01
   */
  date?: string;
  /**
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  dateTime?: string;
  /**
   * @example
   * Asia/Shanghai
   */
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

export class CreateEventRequestUiConfigs extends $tea.Model {
  uiName?: string;
  uiStatus?: string;
  static names(): { [key: string]: string } {
    return {
      uiName: 'uiName',
      uiStatus: 'uiStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uiName: 'string',
      uiStatus: 'string',
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

export class CreateEventResponseBodyCardInstances extends $tea.Model {
  outTrackId?: string;
  scenario?: string;
  static names(): { [key: string]: string } {
    return {
      outTrackId: 'outTrackId',
      scenario: 'scenario',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTrackId: 'string',
      scenario: 'string',
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
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class CreateEventResponseBodyRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
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

export class CreateEventResponseBodyUiConfigs extends $tea.Model {
  uiName?: string;
  uiStatus?: string;
  static names(): { [key: string]: string } {
    return {
      uiName: 'uiName',
      uiStatus: 'uiStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uiName: 'string',
      uiStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeRequestAttendees extends $tea.Model {
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

export class CreateEventByMeRequestEnd extends $tea.Model {
  /**
   * @example
   * 2020-01-01
   */
  date?: string;
  /**
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  dateTime?: string;
  /**
   * @example
   * Asia/Shanghai
   */
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

export class CreateEventByMeRequestLocation extends $tea.Model {
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

export class CreateEventByMeRequestOnlineMeetingInfo extends $tea.Model {
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

export class CreateEventByMeRequestRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeRequestRecurrenceRange extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class CreateEventByMeRequestRecurrence extends $tea.Model {
  pattern?: CreateEventByMeRequestRecurrencePattern;
  range?: CreateEventByMeRequestRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: CreateEventByMeRequestRecurrencePattern,
      range: CreateEventByMeRequestRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeRequestReminders extends $tea.Model {
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

export class CreateEventByMeRequestRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeRequestStart extends $tea.Model {
  /**
   * @example
   * 2020-01-01
   */
  date?: string;
  /**
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  dateTime?: string;
  /**
   * @example
   * Asia/Shanghai
   */
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

export class CreateEventByMeRequestUiConfigs extends $tea.Model {
  uiName?: string;
  uiStatus?: string;
  static names(): { [key: string]: string } {
    return {
      uiName: 'uiName',
      uiStatus: 'uiStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uiName: 'string',
      uiStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeResponseBodyAttendees extends $tea.Model {
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

export class CreateEventByMeResponseBodyEnd extends $tea.Model {
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

export class CreateEventByMeResponseBodyLocation extends $tea.Model {
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

export class CreateEventByMeResponseBodyOnlineMeetingInfo extends $tea.Model {
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

export class CreateEventByMeResponseBodyOrganizer extends $tea.Model {
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

export class CreateEventByMeResponseBodyRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeResponseBodyRecurrenceRange extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class CreateEventByMeResponseBodyRecurrence extends $tea.Model {
  pattern?: CreateEventByMeResponseBodyRecurrencePattern;
  range?: CreateEventByMeResponseBodyRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: CreateEventByMeResponseBodyRecurrencePattern,
      range: CreateEventByMeResponseBodyRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeResponseBodyReminders extends $tea.Model {
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

export class CreateEventByMeResponseBodyRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventByMeResponseBodyStart extends $tea.Model {
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

export class CreateEventByMeResponseBodyUiConfigs extends $tea.Model {
  uiName?: string;
  uiStatus?: string;
  static names(): { [key: string]: string } {
    return {
      uiName: 'uiName',
      uiStatus: 'uiStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uiName: 'string',
      uiStatus: 'string',
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

export class GetEventResponseBodyCardInstances extends $tea.Model {
  outTrackId?: string;
  scenario?: string;
  static names(): { [key: string]: string } {
    return {
      outTrackId: 'outTrackId',
      scenario: 'scenario',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTrackId: 'string',
      scenario: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyCategories extends $tea.Model {
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

export class GetEventResponseBodyExtendedPropertiesSharedProperties extends $tea.Model {
  belongCorpId?: string;
  sourceOpenCid?: string;
  static names(): { [key: string]: string } {
    return {
      belongCorpId: 'belongCorpId',
      sourceOpenCid: 'sourceOpenCid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongCorpId: 'string',
      sourceOpenCid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyExtendedProperties extends $tea.Model {
  sharedProperties?: GetEventResponseBodyExtendedPropertiesSharedProperties;
  static names(): { [key: string]: string } {
    return {
      sharedProperties: 'sharedProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sharedProperties: GetEventResponseBodyExtendedPropertiesSharedProperties,
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

export class GetEventResponseBodyMeetingRooms extends $tea.Model {
  displayName?: string;
  responseStatus?: string;
  roomId?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      roomId: 'roomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      responseStatus: 'string',
      roomId: 'string',
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

export class GetEventResponseBodyOriginStart extends $tea.Model {
  dateTime?: string;
  static names(): { [key: string]: string } {
    return {
      dateTime: 'dateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventResponseBodyRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class GetEventResponseBodyRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
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

export class GetEventResponseBodyUiConfigs extends $tea.Model {
  uiName?: string;
  uiStatus?: string;
  static names(): { [key: string]: string } {
    return {
      uiName: 'uiName',
      uiStatus: 'uiStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uiName: 'string',
      uiStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd extends $tea.Model {
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer extends $tea.Model {
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

export class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart extends $tea.Model {
  dateTime?: string;
  timeZone?: string;
  static names(): { [key: string]: string } {
    return {
      dateTime: 'dateTime',
      timeZone: 'timeZone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dateTime: 'string',
      timeZone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems extends $tea.Model {
  end?: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd;
  eventId?: string;
  organizer?: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer;
  start?: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart;
  /**
   * @example
   * BUSY
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      eventId: 'eventId',
      organizer: 'organizer',
      start: 'start',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsEnd,
      eventId: 'string',
      organizer: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsOrganizer,
      start: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItemsStart,
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMeetingRoomsScheduleResponseBodyScheduleInformation extends $tea.Model {
  error?: string;
  roomId?: string;
  scheduleItems?: GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems[];
  static names(): { [key: string]: string } {
    return {
      error: 'error',
      roomId: 'roomId',
      scheduleItems: 'scheduleItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      error: 'string',
      roomId: 'string',
      scheduleItems: { 'type': 'array', 'itemType': GetMeetingRoomsScheduleResponseBodyScheduleInformationScheduleItems },
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
  /**
   * @example
   * BUSY
   */
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

export class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd extends $tea.Model {
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

export class GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart extends $tea.Model {
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

export class GetScheduleByMeResponseBodyScheduleInformationScheduleItems extends $tea.Model {
  end?: GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd;
  start?: GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart;
  /**
   * @example
   * BUSY
   */
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
      end: GetScheduleByMeResponseBodyScheduleInformationScheduleItemsEnd,
      start: GetScheduleByMeResponseBodyScheduleInformationScheduleItemsStart,
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetScheduleByMeResponseBodyScheduleInformation extends $tea.Model {
  error?: string;
  scheduleItems?: GetScheduleByMeResponseBodyScheduleInformationScheduleItems[];
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
      scheduleItems: { 'type': 'array', 'itemType': GetScheduleByMeResponseBodyScheduleInformationScheduleItems },
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
  /**
   * @remarks
   * This parameter is required.
   */
  eTag?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  id?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  privilege?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  summary?: string;
  timeZone?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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

export class ListEventsResponseBodyEventsCategories extends $tea.Model {
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

export class ListEventsResponseBodyEventsExtendedPropertiesSharedProperties extends $tea.Model {
  belongCorpId?: string;
  sourceOpenCid?: string;
  static names(): { [key: string]: string } {
    return {
      belongCorpId: 'belongCorpId',
      sourceOpenCid: 'sourceOpenCid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongCorpId: 'string',
      sourceOpenCid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsExtendedProperties extends $tea.Model {
  sharedProperties?: ListEventsResponseBodyEventsExtendedPropertiesSharedProperties;
  static names(): { [key: string]: string } {
    return {
      sharedProperties: 'sharedProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sharedProperties: ListEventsResponseBodyEventsExtendedPropertiesSharedProperties,
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

export class ListEventsResponseBodyEventsMeetingRooms extends $tea.Model {
  displayName?: string;
  responseStatus?: string;
  roomId?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      roomId: 'roomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      responseStatus: 'string',
      roomId: 'string',
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

export class ListEventsResponseBodyEventsOriginStart extends $tea.Model {
  dateTime?: string;
  static names(): { [key: string]: string } {
    return {
      dateTime: 'dateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsResponseBodyEventsRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class ListEventsResponseBodyEventsRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
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
  categories?: ListEventsResponseBodyEventsCategories[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createTime?: string;
  description?: string;
  end?: ListEventsResponseBodyEventsEnd;
  extendedProperties?: ListEventsResponseBodyEventsExtendedProperties;
  id?: string;
  isAllDay?: boolean;
  location?: ListEventsResponseBodyEventsLocation;
  meetingRooms?: ListEventsResponseBodyEventsMeetingRooms[];
  onlineMeetingInfo?: ListEventsResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListEventsResponseBodyEventsOrganizer;
  originStart?: ListEventsResponseBodyEventsOriginStart;
  recurrence?: ListEventsResponseBodyEventsRecurrence;
  reminders?: ListEventsResponseBodyEventsReminders[];
  richTextDescription?: ListEventsResponseBodyEventsRichTextDescription;
  seriesMasterId?: string;
  start?: ListEventsResponseBodyEventsStart;
  status?: string;
  summary?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      categories: 'categories',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      extendedProperties: 'extendedProperties',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      meetingRooms: 'meetingRooms',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      originStart: 'originStart',
      recurrence: 'recurrence',
      reminders: 'reminders',
      richTextDescription: 'richTextDescription',
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
      categories: { 'type': 'array', 'itemType': ListEventsResponseBodyEventsCategories },
      createTime: 'string',
      description: 'string',
      end: ListEventsResponseBodyEventsEnd,
      extendedProperties: ListEventsResponseBodyEventsExtendedProperties,
      id: 'string',
      isAllDay: 'boolean',
      location: ListEventsResponseBodyEventsLocation,
      meetingRooms: { 'type': 'array', 'itemType': ListEventsResponseBodyEventsMeetingRooms },
      onlineMeetingInfo: ListEventsResponseBodyEventsOnlineMeetingInfo,
      organizer: ListEventsResponseBodyEventsOrganizer,
      originStart: ListEventsResponseBodyEventsOriginStart,
      recurrence: ListEventsResponseBodyEventsRecurrence,
      reminders: { 'type': 'array', 'itemType': ListEventsResponseBodyEventsReminders },
      richTextDescription: ListEventsResponseBodyEventsRichTextDescription,
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
  /**
   * @example
   * jack
   */
  displayName?: string;
  /**
   * @example
   * iiiP35sJaxxxxRKgiEiF
   */
  id?: string;
  isOptional?: boolean;
  /**
   * @example
   * accepted
   */
  responseStatus?: string;
  /**
   * @example
   * false
   */
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
  /**
   * @example
   * 2020-01-01
   */
  date?: string;
  /**
   * @example
   * 2020-01-01T11:15:30+08:00
   */
  dateTime?: string;
  /**
   * @example
   * Asia/Shanghai
   */
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

export class ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties extends $tea.Model {
  sourceOpenCid?: string;
  static names(): { [key: string]: string } {
    return {
      sourceOpenCid: 'sourceOpenCid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sourceOpenCid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsExtendedProperties extends $tea.Model {
  sharedProperties?: ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties;
  static names(): { [key: string]: string } {
    return {
      sharedProperties: 'sharedProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sharedProperties: ListEventsInstancesResponseBodyEventsExtendedPropertiesSharedProperties,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsInstancesResponseBodyEventsLocation extends $tea.Model {
  /**
   * @example
   * room 1-2-3
   */
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
  /**
   * @example
   * 5c4df21dxxxx-a6db402b9f3a"
   */
  conferenceId?: string;
  /**
   * @example
   * dingtalk
   */
  type?: string;
  /**
   * @example
   * dingtalk://dingtalkclient/page/videoCoxxxxndar?confId=5c4df21dxxxx2b9f3a&calendarId=92xxxx36
   */
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
  /**
   * @example
   * tony
   */
  displayName?: string;
  /**
   * @example
   * iiiP35sJaxxxxRKgiEiF
   */
  id?: string;
  /**
   * @example
   * accepted
   */
  responseStatus?: string;
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * 14
   */
  dayOfMonth?: number;
  /**
   * @example
   * sunday
   */
  daysOfWeek?: string;
  /**
   * @example
   * first
   */
  index?: string;
  /**
   * @example
   * 1
   */
  interval?: number;
  /**
   * @example
   * daily
   */
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  endDate?: string;
  /**
   * @example
   * 5
   */
  numberOfOccurrences?: number;
  /**
   * @example
   * noEnd
   */
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
  /**
   * @example
   * dingtalk
   */
  method?: string;
  /**
   * @example
   * 0
   */
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
  /**
   * @example
   * 2020-01-01
   */
  date?: string;
  /**
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  dateTime?: string;
  /**
   * @example
   * Asia/Shanghai
   */
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  createTime?: string;
  /**
   * @example
   * something about this event
   */
  description?: string;
  end?: ListEventsInstancesResponseBodyEventsEnd;
  extendedProperties?: ListEventsInstancesResponseBodyEventsExtendedProperties;
  /**
   * @example
   * cnNTbW1YbxxxxdEgvdlQrQT09
   */
  id?: string;
  /**
   * @example
   * false
   */
  isAllDay?: boolean;
  location?: ListEventsInstancesResponseBodyEventsLocation;
  onlineMeetingInfo?: ListEventsInstancesResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListEventsInstancesResponseBodyEventsOrganizer;
  recurrence?: ListEventsInstancesResponseBodyEventsRecurrence;
  reminders?: ListEventsInstancesResponseBodyEventsReminders[];
  /**
   * @example
   * cnNTbWxxxxaFJZdEgvdlQrQT09
   */
  seriesMasterId?: string;
  start?: ListEventsInstancesResponseBodyEventsStart;
  /**
   * @example
   * confirmed
   */
  status?: string;
  /**
   * @example
   * test event
   */
  summary?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2020-01-01T10:15:30+08:00
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      extendedProperties: 'extendedProperties',
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
      extendedProperties: ListEventsInstancesResponseBodyEventsExtendedProperties,
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

export class ListEventsViewResponseBodyEventsCategories extends $tea.Model {
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

export class ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties extends $tea.Model {
  belongCorpId?: string;
  sourceOpenCid?: string;
  static names(): { [key: string]: string } {
    return {
      belongCorpId: 'belongCorpId',
      sourceOpenCid: 'sourceOpenCid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongCorpId: 'string',
      sourceOpenCid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsExtendedProperties extends $tea.Model {
  sharedProperties?: ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties;
  static names(): { [key: string]: string } {
    return {
      sharedProperties: 'sharedProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sharedProperties: ListEventsViewResponseBodyEventsExtendedPropertiesSharedProperties,
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

export class ListEventsViewResponseBodyEventsMeetingRooms extends $tea.Model {
  displayName?: string;
  responseStatus?: string;
  roomId?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      roomId: 'roomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      responseStatus: 'string',
      roomId: 'string',
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

export class ListEventsViewResponseBodyEventsOriginStart extends $tea.Model {
  dateTime?: string;
  static names(): { [key: string]: string } {
    return {
      dateTime: 'dateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewResponseBodyEventsRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class ListEventsViewResponseBodyEventsRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
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
  categories?: ListEventsViewResponseBodyEventsCategories[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createTime?: string;
  description?: string;
  end?: ListEventsViewResponseBodyEventsEnd;
  extendedProperties?: ListEventsViewResponseBodyEventsExtendedProperties;
  id?: string;
  isAllDay?: boolean;
  location?: ListEventsViewResponseBodyEventsLocation;
  meetingRooms?: ListEventsViewResponseBodyEventsMeetingRooms[];
  onlineMeetingInfo?: ListEventsViewResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListEventsViewResponseBodyEventsOrganizer;
  originStart?: ListEventsViewResponseBodyEventsOriginStart;
  recurrence?: ListEventsViewResponseBodyEventsRecurrence;
  richTextDescription?: ListEventsViewResponseBodyEventsRichTextDescription;
  seriesMasterId?: string;
  start?: ListEventsViewResponseBodyEventsStart;
  status?: string;
  summary?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      categories: 'categories',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      extendedProperties: 'extendedProperties',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      meetingRooms: 'meetingRooms',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      originStart: 'originStart',
      recurrence: 'recurrence',
      richTextDescription: 'richTextDescription',
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
      categories: { 'type': 'array', 'itemType': ListEventsViewResponseBodyEventsCategories },
      createTime: 'string',
      description: 'string',
      end: ListEventsViewResponseBodyEventsEnd,
      extendedProperties: ListEventsViewResponseBodyEventsExtendedProperties,
      id: 'string',
      isAllDay: 'boolean',
      location: ListEventsViewResponseBodyEventsLocation,
      meetingRooms: { 'type': 'array', 'itemType': ListEventsViewResponseBodyEventsMeetingRooms },
      onlineMeetingInfo: ListEventsViewResponseBodyEventsOnlineMeetingInfo,
      organizer: ListEventsViewResponseBodyEventsOrganizer,
      originStart: ListEventsViewResponseBodyEventsOriginStart,
      recurrence: ListEventsViewResponseBodyEventsRecurrence,
      richTextDescription: ListEventsViewResponseBodyEventsRichTextDescription,
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

export class ListEventsViewByMeResponseBodyEventsAttendees extends $tea.Model {
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

export class ListEventsViewByMeResponseBodyEventsCategories extends $tea.Model {
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

export class ListEventsViewByMeResponseBodyEventsEnd extends $tea.Model {
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

export class ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties extends $tea.Model {
  belongCorpId?: string;
  sourceOpenCid?: string;
  static names(): { [key: string]: string } {
    return {
      belongCorpId: 'belongCorpId',
      sourceOpenCid: 'sourceOpenCid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongCorpId: 'string',
      sourceOpenCid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponseBodyEventsExtendedProperties extends $tea.Model {
  sharedProperties?: ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties;
  static names(): { [key: string]: string } {
    return {
      sharedProperties: 'sharedProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sharedProperties: ListEventsViewByMeResponseBodyEventsExtendedPropertiesSharedProperties,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponseBodyEventsLocation extends $tea.Model {
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

export class ListEventsViewByMeResponseBodyEventsMeetingRooms extends $tea.Model {
  displayName?: string;
  responseStatus?: string;
  roomId?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      roomId: 'roomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      responseStatus: 'string',
      roomId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo extends $tea.Model {
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

export class ListEventsViewByMeResponseBodyEventsOrganizer extends $tea.Model {
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

export class ListEventsViewByMeResponseBodyEventsOriginStart extends $tea.Model {
  dateTime?: string;
  static names(): { [key: string]: string } {
    return {
      dateTime: 'dateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponseBodyEventsRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
      index: 'string',
      interval: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponseBodyEventsRecurrenceRange extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class ListEventsViewByMeResponseBodyEventsRecurrence extends $tea.Model {
  pattern?: ListEventsViewByMeResponseBodyEventsRecurrencePattern;
  range?: ListEventsViewByMeResponseBodyEventsRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: ListEventsViewByMeResponseBodyEventsRecurrencePattern,
      range: ListEventsViewByMeResponseBodyEventsRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponseBodyEventsRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEventsViewByMeResponseBodyEventsStart extends $tea.Model {
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

export class ListEventsViewByMeResponseBodyEvents extends $tea.Model {
  attendees?: ListEventsViewByMeResponseBodyEventsAttendees[];
  categories?: ListEventsViewByMeResponseBodyEventsCategories[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createTime?: string;
  description?: string;
  end?: ListEventsViewByMeResponseBodyEventsEnd;
  extendedProperties?: ListEventsViewByMeResponseBodyEventsExtendedProperties;
  id?: string;
  isAllDay?: boolean;
  location?: ListEventsViewByMeResponseBodyEventsLocation;
  meetingRooms?: ListEventsViewByMeResponseBodyEventsMeetingRooms[];
  onlineMeetingInfo?: ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListEventsViewByMeResponseBodyEventsOrganizer;
  originStart?: ListEventsViewByMeResponseBodyEventsOriginStart;
  recurrence?: ListEventsViewByMeResponseBodyEventsRecurrence;
  richTextDescription?: ListEventsViewByMeResponseBodyEventsRichTextDescription;
  seriesMasterId?: string;
  start?: ListEventsViewByMeResponseBodyEventsStart;
  status?: string;
  summary?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      categories: 'categories',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      extendedProperties: 'extendedProperties',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      meetingRooms: 'meetingRooms',
      onlineMeetingInfo: 'onlineMeetingInfo',
      organizer: 'organizer',
      originStart: 'originStart',
      recurrence: 'recurrence',
      richTextDescription: 'richTextDescription',
      seriesMasterId: 'seriesMasterId',
      start: 'start',
      status: 'status',
      summary: 'summary',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendees: { 'type': 'array', 'itemType': ListEventsViewByMeResponseBodyEventsAttendees },
      categories: { 'type': 'array', 'itemType': ListEventsViewByMeResponseBodyEventsCategories },
      createTime: 'string',
      description: 'string',
      end: ListEventsViewByMeResponseBodyEventsEnd,
      extendedProperties: ListEventsViewByMeResponseBodyEventsExtendedProperties,
      id: 'string',
      isAllDay: 'boolean',
      location: ListEventsViewByMeResponseBodyEventsLocation,
      meetingRooms: { 'type': 'array', 'itemType': ListEventsViewByMeResponseBodyEventsMeetingRooms },
      onlineMeetingInfo: ListEventsViewByMeResponseBodyEventsOnlineMeetingInfo,
      organizer: ListEventsViewByMeResponseBodyEventsOrganizer,
      originStart: ListEventsViewByMeResponseBodyEventsOriginStart,
      recurrence: ListEventsViewByMeResponseBodyEventsRecurrence,
      richTextDescription: ListEventsViewByMeResponseBodyEventsRichTextDescription,
      seriesMasterId: 'string',
      start: ListEventsViewByMeResponseBodyEventsStart,
      status: 'string',
      summary: 'string',
      updateTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInstancesResponseBodyEventsAttendees extends $tea.Model {
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

export class ListInstancesResponseBodyEventsEnd extends $tea.Model {
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

export class ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties extends $tea.Model {
  belongCorpId?: string;
  sourceOpenCid?: string;
  static names(): { [key: string]: string } {
    return {
      belongCorpId: 'belongCorpId',
      sourceOpenCid: 'sourceOpenCid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongCorpId: 'string',
      sourceOpenCid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInstancesResponseBodyEventsExtendedProperties extends $tea.Model {
  sharedProperties?: ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties;
  static names(): { [key: string]: string } {
    return {
      sharedProperties: 'sharedProperties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sharedProperties: ListInstancesResponseBodyEventsExtendedPropertiesSharedProperties,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInstancesResponseBodyEventsLocation extends $tea.Model {
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

export class ListInstancesResponseBodyEventsMeetingRooms extends $tea.Model {
  displayName?: string;
  responseStatus?: string;
  roomId?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      responseStatus: 'responseStatus',
      roomId: 'roomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      responseStatus: 'string',
      roomId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInstancesResponseBodyEventsOnlineMeetingInfo extends $tea.Model {
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

export class ListInstancesResponseBodyEventsOrganizer extends $tea.Model {
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

export class ListInstancesResponseBodyEventsRecurrencePattern extends $tea.Model {
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

export class ListInstancesResponseBodyEventsRecurrenceRange extends $tea.Model {
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class ListInstancesResponseBodyEventsRecurrence extends $tea.Model {
  pattern?: ListInstancesResponseBodyEventsRecurrencePattern;
  range?: ListInstancesResponseBodyEventsRecurrenceRange;
  static names(): { [key: string]: string } {
    return {
      pattern: 'pattern',
      range: 'range',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pattern: ListInstancesResponseBodyEventsRecurrencePattern,
      range: ListInstancesResponseBodyEventsRecurrenceRange,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInstancesResponseBodyEventsReminders extends $tea.Model {
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

export class ListInstancesResponseBodyEventsStart extends $tea.Model {
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

export class ListInstancesResponseBodyEvents extends $tea.Model {
  attendees?: ListInstancesResponseBodyEventsAttendees[];
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  createTime?: string;
  description?: string;
  end?: ListInstancesResponseBodyEventsEnd;
  extendedProperties?: ListInstancesResponseBodyEventsExtendedProperties;
  id?: string;
  isAllDay?: boolean;
  location?: ListInstancesResponseBodyEventsLocation;
  meetingRooms?: ListInstancesResponseBodyEventsMeetingRooms[];
  onlineMeetingInfo?: ListInstancesResponseBodyEventsOnlineMeetingInfo;
  organizer?: ListInstancesResponseBodyEventsOrganizer;
  recurrence?: ListInstancesResponseBodyEventsRecurrence;
  reminders?: ListInstancesResponseBodyEventsReminders[];
  seriesMasterId?: string;
  start?: ListInstancesResponseBodyEventsStart;
  status?: string;
  summary?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      attendees: 'attendees',
      createTime: 'createTime',
      description: 'description',
      end: 'end',
      extendedProperties: 'extendedProperties',
      id: 'id',
      isAllDay: 'isAllDay',
      location: 'location',
      meetingRooms: 'meetingRooms',
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
      attendees: { 'type': 'array', 'itemType': ListInstancesResponseBodyEventsAttendees },
      createTime: 'string',
      description: 'string',
      end: ListInstancesResponseBodyEventsEnd,
      extendedProperties: ListInstancesResponseBodyEventsExtendedProperties,
      id: 'string',
      isAllDay: 'boolean',
      location: ListInstancesResponseBodyEventsLocation,
      meetingRooms: { 'type': 'array', 'itemType': ListInstancesResponseBodyEventsMeetingRooms },
      onlineMeetingInfo: ListInstancesResponseBodyEventsOnlineMeetingInfo,
      organizer: ListInstancesResponseBodyEventsOrganizer,
      recurrence: ListInstancesResponseBodyEventsRecurrence,
      reminders: { 'type': 'array', 'itemType': ListInstancesResponseBodyEventsReminders },
      seriesMasterId: 'string',
      start: ListInstancesResponseBodyEventsStart,
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
  email?: string;
  id?: string;
  isOptional?: boolean;
  static names(): { [key: string]: string } {
    return {
      email: 'email',
      id: 'id',
      isOptional: 'isOptional',
    };
  }

  static types(): { [key: string]: any } {
    return {
      email: 'string',
      id: 'string',
      isOptional: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PatchEventRequestCardInstances extends $tea.Model {
  outTrackId?: string;
  scenario?: string;
  static names(): { [key: string]: string } {
    return {
      outTrackId: 'outTrackId',
      scenario: 'scenario',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTrackId: 'string',
      scenario: 'string',
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

export class PatchEventRequestOnlineMeetingInfo extends $tea.Model {
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

export class PatchEventRequestRecurrencePattern extends $tea.Model {
  dayOfMonth?: number;
  daysOfWeek?: string;
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class PatchEventRequestRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
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

export class PatchEventRequestUiConfigs extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  uiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uiStatus?: string;
  static names(): { [key: string]: string } {
    return {
      uiName: 'uiName',
      uiStatus: 'uiStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uiName: 'string',
      uiStatus: 'string',
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

export class PatchEventResponseBodyCardInstances extends $tea.Model {
  outTrackId?: string;
  scenario?: string;
  static names(): { [key: string]: string } {
    return {
      outTrackId: 'outTrackId',
      scenario: 'scenario',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTrackId: 'string',
      scenario: 'string',
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

export class PatchEventResponseBodyOnlineMeetingInfo extends $tea.Model {
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
  firstDayOfWeek?: string;
  index?: string;
  interval?: number;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      dayOfMonth: 'dayOfMonth',
      daysOfWeek: 'daysOfWeek',
      firstDayOfWeek: 'firstDayOfWeek',
      index: 'index',
      interval: 'interval',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayOfMonth: 'number',
      daysOfWeek: 'string',
      firstDayOfWeek: 'string',
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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

export class PatchEventResponseBodyRichTextDescription extends $tea.Model {
  text?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
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

export class PatchEventResponseBodyUiConfigs extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  uiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uiStatus?: string;
  static names(): { [key: string]: string } {
    return {
      uiName: 'uiName',
      uiStatus: 'uiStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uiName: 'string',
      uiStatus: 'string',
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

export class RemoveMeetingRoomsRequestMeetingRoomsToRemove extends $tea.Model {
  roomId?: string;
  static names(): { [key: string]: string } {
    return {
      roomId: 'roomId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roomId: 'string',
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 新增日程参与人
   * 
   * @param request - AddAttendeeRequest
   * @param headers - AddAttendeeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddAttendeeResponse
   */
  async addAttendeeWithOptions(userId: string, calendarId: string, eventId: string, request: AddAttendeeRequest, headers: AddAttendeeHeaders, runtime: $Util.RuntimeOptions): Promise<AddAttendeeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendeesToAdd)) {
      body["attendeesToAdd"] = request.attendeesToAdd;
    }

    if (!Util.isUnset(request.chatNotification)) {
      body["chatNotification"] = request.chatNotification;
    }

    if (!Util.isUnset(request.pushNotification)) {
      body["pushNotification"] = request.pushNotification;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddAttendee",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<AddAttendeeResponse>(await this.execute(params, req, runtime), new AddAttendeeResponse({}));
  }

  /**
   * 新增日程参与人
   * 
   * @param request - AddAttendeeRequest
   * @returns AddAttendeeResponse
   */
  async addAttendee(userId: string, calendarId: string, eventId: string, request: AddAttendeeRequest): Promise<AddAttendeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAttendeeHeaders({ });
    return await this.addAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 添加会议室
   * 
   * @param request - AddMeetingRoomsRequest
   * @param headers - AddMeetingRoomsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddMeetingRoomsResponse
   */
  async addMeetingRoomsWithOptions(userId: string, calendarId: string, eventId: string, request: AddMeetingRoomsRequest, headers: AddMeetingRoomsHeaders, runtime: $Util.RuntimeOptions): Promise<AddMeetingRoomsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.meetingRoomsToAdd)) {
      body["meetingRoomsToAdd"] = request.meetingRoomsToAdd;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddMeetingRooms",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/meetingRooms`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddMeetingRoomsResponse>(await this.execute(params, req, runtime), new AddMeetingRoomsResponse({}));
  }

  /**
   * 添加会议室
   * 
   * @param request - AddMeetingRoomsRequest
   * @returns AddMeetingRoomsResponse
   */
  async addMeetingRooms(userId: string, calendarId: string, eventId: string, request: AddMeetingRoomsRequest): Promise<AddMeetingRoomsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddMeetingRoomsHeaders({ });
    return await this.addMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 签到
   * 
   * @param headers - CheckInHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckInResponse
   */
  async checkInWithOptions(userId: string, calendarId: string, eventId: string, headers: CheckInHeaders, runtime: $Util.RuntimeOptions): Promise<CheckInResponse> {
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
    let params = new $OpenApi.Params({
      action: "CheckIn",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/checkIn`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CheckInResponse>(await this.execute(params, req, runtime), new CheckInResponse({}));
  }

  /**
   * 签到
   * @returns CheckInResponse
   */
  async checkIn(userId: string, calendarId: string, eventId: string): Promise<CheckInResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckInHeaders({ });
    return await this.checkInWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  /**
   * 转换老版本的eventId
   * 
   * @param request - ConvertLegacyEventIdRequest
   * @param headers - ConvertLegacyEventIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConvertLegacyEventIdResponse
   */
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

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ConvertLegacyEventId",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/legacyEventIds/convert`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConvertLegacyEventIdResponse>(await this.execute(params, req, runtime), new ConvertLegacyEventIdResponse({}));
  }

  /**
   * 转换老版本的eventId
   * 
   * @param request - ConvertLegacyEventIdRequest
   * @returns ConvertLegacyEventIdResponse
   */
  async convertLegacyEventId(userId: string, request: ConvertLegacyEventIdRequest): Promise<ConvertLegacyEventIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConvertLegacyEventIdHeaders({ });
    return await this.convertLegacyEventIdWithOptions(userId, request, headers, runtime);
  }

  /**
   * 创建访问控制
   * 
   * @param request - CreateAclsRequest
   * @param headers - CreateAclsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateAclsResponse
   */
  async createAclsWithOptions(userId: string, calendarId: string, request: CreateAclsRequest, headers: CreateAclsHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAclsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.privilege)) {
      body["privilege"] = request.privilege;
    }

    if (!Util.isUnset(request.scope)) {
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
    let params = new $OpenApi.Params({
      action: "CreateAcls",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/acls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAclsResponse>(await this.execute(params, req, runtime), new CreateAclsResponse({}));
  }

  /**
   * 创建访问控制
   * 
   * @param request - CreateAclsRequest
   * @returns CreateAclsResponse
   */
  async createAcls(userId: string, calendarId: string, request: CreateAclsRequest): Promise<CreateAclsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAclsHeaders({ });
    return await this.createAclsWithOptions(userId, calendarId, request, headers, runtime);
  }

  /**
   * 创建日程
   * 
   * @param request - CreateEventRequest
   * @param headers - CreateEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateEventResponse
   */
  async createEventWithOptions(userId: string, calendarId: string, request: CreateEventRequest, headers: CreateEventHeaders, runtime: $Util.RuntimeOptions): Promise<CreateEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendees)) {
      body["attendees"] = request.attendees;
    }

    if (!Util.isUnset(request.cardInstances)) {
      body["cardInstances"] = request.cardInstances;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.end)) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.extra)) {
      body["extra"] = request.extra;
    }

    if (!Util.isUnset(request.isAllDay)) {
      body["isAllDay"] = request.isAllDay;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.onlineMeetingInfo)) {
      body["onlineMeetingInfo"] = request.onlineMeetingInfo;
    }

    if (!Util.isUnset(request.recurrence)) {
      body["recurrence"] = request.recurrence;
    }

    if (!Util.isUnset(request.reminders)) {
      body["reminders"] = request.reminders;
    }

    if (!Util.isUnset(request.richTextDescription)) {
      body["richTextDescription"] = request.richTextDescription;
    }

    if (!Util.isUnset(request.start)) {
      body["start"] = request.start;
    }

    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    if (!Util.isUnset(request.uiConfigs)) {
      body["uiConfigs"] = request.uiConfigs;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateEvent",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateEventResponse>(await this.execute(params, req, runtime), new CreateEventResponse({}));
  }

  /**
   * 创建日程
   * 
   * @param request - CreateEventRequest
   * @returns CreateEventResponse
   */
  async createEvent(userId: string, calendarId: string, request: CreateEventRequest): Promise<CreateEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateEventHeaders({ });
    return await this.createEventWithOptions(userId, calendarId, request, headers, runtime);
  }

  /**
   * 创建日程(me接口)
   * 
   * @param request - CreateEventByMeRequest
   * @param headers - CreateEventByMeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateEventByMeResponse
   */
  async createEventByMeWithOptions(calendarId: string, request: CreateEventByMeRequest, headers: CreateEventByMeHeaders, runtime: $Util.RuntimeOptions): Promise<CreateEventByMeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendees)) {
      body["attendees"] = request.attendees;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.end)) {
      body["end"] = request.end;
    }

    if (!Util.isUnset(request.extra)) {
      body["extra"] = request.extra;
    }

    if (!Util.isUnset(request.isAllDay)) {
      body["isAllDay"] = request.isAllDay;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.onlineMeetingInfo)) {
      body["onlineMeetingInfo"] = request.onlineMeetingInfo;
    }

    if (!Util.isUnset(request.recurrence)) {
      body["recurrence"] = request.recurrence;
    }

    if (!Util.isUnset(request.reminders)) {
      body["reminders"] = request.reminders;
    }

    if (!Util.isUnset(request.richTextDescription)) {
      body["richTextDescription"] = request.richTextDescription;
    }

    if (!Util.isUnset(request.start)) {
      body["start"] = request.start;
    }

    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    if (!Util.isUnset(request.uiConfigs)) {
      body["uiConfigs"] = request.uiConfigs;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateEventByMe",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/me/calendars/${calendarId}/events`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateEventByMeResponse>(await this.execute(params, req, runtime), new CreateEventByMeResponse({}));
  }

  /**
   * 创建日程(me接口)
   * 
   * @param request - CreateEventByMeRequest
   * @returns CreateEventByMeResponse
   */
  async createEventByMe(calendarId: string, request: CreateEventByMeRequest): Promise<CreateEventByMeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateEventByMeHeaders({ });
    return await this.createEventByMeWithOptions(calendarId, request, headers, runtime);
  }

  /**
   * 快速创建订阅日历
   * 
   * @param request - CreateSubscribedCalendarRequest
   * @param headers - CreateSubscribedCalendarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateSubscribedCalendarResponse
   */
  async createSubscribedCalendarWithOptions(userId: string, request: CreateSubscribedCalendarRequest, headers: CreateSubscribedCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSubscribedCalendarResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(request.subscribeScope)) {
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
    let params = new $OpenApi.Params({
      action: "CreateSubscribedCalendar",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/subscribedCalendars`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSubscribedCalendarResponse>(await this.execute(params, req, runtime), new CreateSubscribedCalendarResponse({}));
  }

  /**
   * 快速创建订阅日历
   * 
   * @param request - CreateSubscribedCalendarRequest
   * @returns CreateSubscribedCalendarResponse
   */
  async createSubscribedCalendar(userId: string, request: CreateSubscribedCalendarRequest): Promise<CreateSubscribedCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSubscribedCalendarHeaders({ });
    return await this.createSubscribedCalendarWithOptions(userId, request, headers, runtime);
  }

  /**
   * 删除访问控制
   * 
   * @param headers - DeleteAclHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteAclResponse
   */
  async deleteAclWithOptions(userId: string, calendarId: string, aclId: string, headers: DeleteAclHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAclResponse> {
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
    let params = new $OpenApi.Params({
      action: "DeleteAcl",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/acls/${aclId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<DeleteAclResponse>(await this.execute(params, req, runtime), new DeleteAclResponse({}));
  }

  /**
   * 删除访问控制
   * @returns DeleteAclResponse
   */
  async deleteAcl(userId: string, calendarId: string, aclId: string): Promise<DeleteAclResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAclHeaders({ });
    return await this.deleteAclWithOptions(userId, calendarId, aclId, headers, runtime);
  }

  /**
   * 删除指定日程
   * 
   * @param request - DeleteEventRequest
   * @param headers - DeleteEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteEventResponse
   */
  async deleteEventWithOptions(userId: string, calendarId: string, eventId: string, request: DeleteEventRequest, headers: DeleteEventHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteEventResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pushNotification)) {
      query["pushNotification"] = request.pushNotification;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteEvent",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<DeleteEventResponse>(await this.execute(params, req, runtime), new DeleteEventResponse({}));
  }

  /**
   * 删除指定日程
   * 
   * @param request - DeleteEventRequest
   * @returns DeleteEventResponse
   */
  async deleteEvent(userId: string, calendarId: string, eventId: string, request: DeleteEventRequest): Promise<DeleteEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteEventHeaders({ });
    return await this.deleteEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 删除指定订阅日历
   * 
   * @param headers - DeleteSubscribedCalendarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteSubscribedCalendarResponse
   */
  async deleteSubscribedCalendarWithOptions(userId: string, calendarId: string, headers: DeleteSubscribedCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSubscribedCalendarResponse> {
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
    let params = new $OpenApi.Params({
      action: "DeleteSubscribedCalendar",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/subscribedCalendars/${calendarId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteSubscribedCalendarResponse>(await this.execute(params, req, runtime), new DeleteSubscribedCalendarResponse({}));
  }

  /**
   * 删除指定订阅日历
   * @returns DeleteSubscribedCalendarResponse
   */
  async deleteSubscribedCalendar(userId: string, calendarId: string): Promise<DeleteSubscribedCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSubscribedCalendarHeaders({ });
    return await this.deleteSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
  }

  /**
   * 生成caldav账户
   * 
   * @param request - GenerateCaldavAccountRequest
   * @param headers - GenerateCaldavAccountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GenerateCaldavAccountResponse
   */
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
      realHeaders["dingUid"] = Util.toJSONString(headers.dingUid);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GenerateCaldavAccount",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/caldavAccounts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GenerateCaldavAccountResponse>(await this.execute(params, req, runtime), new GenerateCaldavAccountResponse({}));
  }

  /**
   * 生成caldav账户
   * 
   * @param request - GenerateCaldavAccountRequest
   * @returns GenerateCaldavAccountResponse
   */
  async generateCaldavAccount(userId: string, request: GenerateCaldavAccountRequest): Promise<GenerateCaldavAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GenerateCaldavAccountHeaders({ });
    return await this.generateCaldavAccountWithOptions(userId, request, headers, runtime);
  }

  /**
   * 查询日程列表
   * 
   * @param request - GetEventRequest
   * @param headers - GetEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetEventResponse
   */
  async getEventWithOptions(userId: string, calendarId: string, eventId: string, request: GetEventRequest, headers: GetEventHeaders, runtime: $Util.RuntimeOptions): Promise<GetEventResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetEvent",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEventResponse>(await this.execute(params, req, runtime), new GetEventResponse({}));
  }

  /**
   * 查询日程列表
   * 
   * @param request - GetEventRequest
   * @returns GetEventResponse
   */
  async getEvent(userId: string, calendarId: string, eventId: string, request: GetEventRequest): Promise<GetEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEventHeaders({ });
    return await this.getEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 查询会议室忙闲
   * 
   * @param request - GetMeetingRoomsScheduleRequest
   * @param headers - GetMeetingRoomsScheduleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMeetingRoomsScheduleResponse
   */
  async getMeetingRoomsScheduleWithOptions(userId: string, request: GetMeetingRoomsScheduleRequest, headers: GetMeetingRoomsScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<GetMeetingRoomsScheduleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.roomIds)) {
      body["roomIds"] = request.roomIds;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
    let params = new $OpenApi.Params({
      action: "GetMeetingRoomsSchedule",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/meetingRooms/schedules/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMeetingRoomsScheduleResponse>(await this.execute(params, req, runtime), new GetMeetingRoomsScheduleResponse({}));
  }

  /**
   * 查询会议室忙闲
   * 
   * @param request - GetMeetingRoomsScheduleRequest
   * @returns GetMeetingRoomsScheduleResponse
   */
  async getMeetingRoomsSchedule(userId: string, request: GetMeetingRoomsScheduleRequest): Promise<GetMeetingRoomsScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMeetingRoomsScheduleHeaders({ });
    return await this.getMeetingRoomsScheduleWithOptions(userId, request, headers, runtime);
  }

  /**
   * 查询闲忙
   * 
   * @param request - GetScheduleRequest
   * @param headers - GetScheduleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetScheduleResponse
   */
  async getScheduleWithOptions(userId: string, request: GetScheduleRequest, headers: GetScheduleHeaders, runtime: $Util.RuntimeOptions): Promise<GetScheduleResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetSchedule",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/querySchedule`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetScheduleResponse>(await this.execute(params, req, runtime), new GetScheduleResponse({}));
  }

  /**
   * 查询闲忙
   * 
   * @param request - GetScheduleRequest
   * @returns GetScheduleResponse
   */
  async getSchedule(userId: string, request: GetScheduleRequest): Promise<GetScheduleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetScheduleHeaders({ });
    return await this.getScheduleWithOptions(userId, request, headers, runtime);
  }

  /**
   * 查询闲忙(me接口）
   * 
   * @param request - GetScheduleByMeRequest
   * @param headers - GetScheduleByMeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetScheduleByMeResponse
   */
  async getScheduleByMeWithOptions(request: GetScheduleByMeRequest, headers: GetScheduleByMeHeaders, runtime: $Util.RuntimeOptions): Promise<GetScheduleByMeResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetScheduleByMe",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/me/schedules/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetScheduleByMeResponse>(await this.execute(params, req, runtime), new GetScheduleByMeResponse({}));
  }

  /**
   * 查询闲忙(me接口）
   * 
   * @param request - GetScheduleByMeRequest
   * @returns GetScheduleByMeResponse
   */
  async getScheduleByMe(request: GetScheduleByMeRequest): Promise<GetScheduleByMeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetScheduleByMeHeaders({ });
    return await this.getScheduleByMeWithOptions(request, headers, runtime);
  }

  /**
   * 获取签到链接
   * 
   * @param headers - GetSignInLinkHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignInLinkResponse
   */
  async getSignInLinkWithOptions(calendarId: string, userId: string, eventId: string, headers: GetSignInLinkHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignInLinkResponse> {
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
    let params = new $OpenApi.Params({
      action: "GetSignInLink",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signInLinks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSignInLinkResponse>(await this.execute(params, req, runtime), new GetSignInLinkResponse({}));
  }

  /**
   * 获取签到链接
   * @returns GetSignInLinkResponse
   */
  async getSignInLink(calendarId: string, userId: string, eventId: string): Promise<GetSignInLinkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignInLinkHeaders({ });
    return await this.getSignInLinkWithOptions(calendarId, userId, eventId, headers, runtime);
  }

  /**
   * 获取签到信息详情
   * 
   * @param request - GetSignInListRequest
   * @param headers - GetSignInListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignInListResponse
   */
  async getSignInListWithOptions(userId: string, calendarId: string, eventId: string, request: GetSignInListRequest, headers: GetSignInListHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignInListResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetSignInList",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signin`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSignInListResponse>(await this.execute(params, req, runtime), new GetSignInListResponse({}));
  }

  /**
   * 获取签到信息详情
   * 
   * @param request - GetSignInListRequest
   * @returns GetSignInListResponse
   */
  async getSignInList(userId: string, calendarId: string, eventId: string, request: GetSignInListRequest): Promise<GetSignInListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignInListHeaders({ });
    return await this.getSignInListWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 获取签退链接
   * 
   * @param headers - GetSignOutLinkHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignOutLinkResponse
   */
  async getSignOutLinkWithOptions(calendarId: string, userId: string, eventId: string, headers: GetSignOutLinkHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignOutLinkResponse> {
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
    let params = new $OpenApi.Params({
      action: "GetSignOutLink",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signOutLinks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSignOutLinkResponse>(await this.execute(params, req, runtime), new GetSignOutLinkResponse({}));
  }

  /**
   * 获取签退链接
   * @returns GetSignOutLinkResponse
   */
  async getSignOutLink(calendarId: string, userId: string, eventId: string): Promise<GetSignOutLinkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignOutLinkHeaders({ });
    return await this.getSignOutLinkWithOptions(calendarId, userId, eventId, headers, runtime);
  }

  /**
   * 获取签退信息详情
   * 
   * @param request - GetSignOutListRequest
   * @param headers - GetSignOutListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignOutListResponse
   */
  async getSignOutListWithOptions(userId: string, calendarId: string, eventId: string, request: GetSignOutListRequest, headers: GetSignOutListHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignOutListResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetSignOutList",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signOut`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSignOutListResponse>(await this.execute(params, req, runtime), new GetSignOutListResponse({}));
  }

  /**
   * 获取签退信息详情
   * 
   * @param request - GetSignOutListRequest
   * @returns GetSignOutListResponse
   */
  async getSignOutList(userId: string, calendarId: string, eventId: string, request: GetSignOutListRequest): Promise<GetSignOutListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignOutListHeaders({ });
    return await this.getSignOutListWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 获取指定订阅日历详情
   * 
   * @param headers - GetSubscribedCalendarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSubscribedCalendarResponse
   */
  async getSubscribedCalendarWithOptions(userId: string, calendarId: string, headers: GetSubscribedCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<GetSubscribedCalendarResponse> {
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
    let params = new $OpenApi.Params({
      action: "GetSubscribedCalendar",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/subscribedCalendars/${calendarId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSubscribedCalendarResponse>(await this.execute(params, req, runtime), new GetSubscribedCalendarResponse({}));
  }

  /**
   * 获取指定订阅日历详情
   * @returns GetSubscribedCalendarResponse
   */
  async getSubscribedCalendar(userId: string, calendarId: string): Promise<GetSubscribedCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSubscribedCalendarHeaders({ });
    return await this.getSubscribedCalendarWithOptions(userId, calendarId, headers, runtime);
  }

  /**
   * 获取访问控制列表
   * 
   * @param headers - ListAclsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAclsResponse
   */
  async listAclsWithOptions(userId: string, calendarId: string, headers: ListAclsHeaders, runtime: $Util.RuntimeOptions): Promise<ListAclsResponse> {
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
    let params = new $OpenApi.Params({
      action: "ListAcls",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/acls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAclsResponse>(await this.execute(params, req, runtime), new ListAclsResponse({}));
  }

  /**
   * 获取访问控制列表
   * @returns ListAclsResponse
   */
  async listAcls(userId: string, calendarId: string): Promise<ListAclsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAclsHeaders({ });
    return await this.listAclsWithOptions(userId, calendarId, headers, runtime);
  }

  /**
   * 分页获取参与人列表
   * 
   * @param request - ListAttendeesRequest
   * @param headers - ListAttendeesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAttendeesResponse
   */
  async listAttendeesWithOptions(userId: string, calendarId: string, eventId: string, request: ListAttendeesRequest, headers: ListAttendeesHeaders, runtime: $Util.RuntimeOptions): Promise<ListAttendeesResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "ListAttendees",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAttendeesResponse>(await this.execute(params, req, runtime), new ListAttendeesResponse({}));
  }

  /**
   * 分页获取参与人列表
   * 
   * @param request - ListAttendeesRequest
   * @returns ListAttendeesResponse
   */
  async listAttendees(userId: string, calendarId: string, eventId: string, request: ListAttendeesRequest): Promise<ListAttendeesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAttendeesHeaders({ });
    return await this.listAttendeesWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 日历本查询
   * 
   * @param headers - ListCalendarsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListCalendarsResponse
   */
  async listCalendarsWithOptions(userId: string, headers: ListCalendarsHeaders, runtime: $Util.RuntimeOptions): Promise<ListCalendarsResponse> {
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
    let params = new $OpenApi.Params({
      action: "ListCalendars",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListCalendarsResponse>(await this.execute(params, req, runtime), new ListCalendarsResponse({}));
  }

  /**
   * 日历本查询
   * @returns ListCalendarsResponse
   */
  async listCalendars(userId: string): Promise<ListCalendarsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListCalendarsHeaders({ });
    return await this.listCalendarsWithOptions(userId, headers, runtime);
  }

  /**
   * 查询日程列表
   * 
   * @param request - ListEventsRequest
   * @param headers - ListEventsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListEventsResponse
   */
  async listEventsWithOptions(userId: string, calendarId: string, request: ListEventsRequest, headers: ListEventsHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(request.seriesMasterId)) {
      query["seriesMasterId"] = request.seriesMasterId;
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
    let params = new $OpenApi.Params({
      action: "ListEvents",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListEventsResponse>(await this.execute(params, req, runtime), new ListEventsResponse({}));
  }

  /**
   * 查询日程列表
   * 
   * @param request - ListEventsRequest
   * @returns ListEventsResponse
   */
  async listEvents(userId: string, calendarId: string, request: ListEventsRequest): Promise<ListEventsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsHeaders({ });
    return await this.listEventsWithOptions(userId, calendarId, request, headers, runtime);
  }

  /**
   * 查询同一个循环日程序列下已生成的实例
   * 
   * @param request - ListEventsInstancesRequest
   * @param headers - ListEventsInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListEventsInstancesResponse
   */
  async listEventsInstancesWithOptions(userId: string, calendarId: string, request: ListEventsInstancesRequest, headers: ListEventsInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsInstancesResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "ListEventsInstances",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListEventsInstancesResponse>(await this.execute(params, req, runtime), new ListEventsInstancesResponse({}));
  }

  /**
   * 查询同一个循环日程序列下已生成的实例
   * 
   * @param request - ListEventsInstancesRequest
   * @returns ListEventsInstancesResponse
   */
  async listEventsInstances(userId: string, calendarId: string, request: ListEventsInstancesRequest): Promise<ListEventsInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsInstancesHeaders({ });
    return await this.listEventsInstancesWithOptions(userId, calendarId, request, headers, runtime);
  }

  /**
   * 查询日程视图列表以查看闲忙，展开循环日程
   * 
   * @param request - ListEventsViewRequest
   * @param headers - ListEventsViewHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListEventsViewResponse
   */
  async listEventsViewWithOptions(userId: string, calendarId: string, request: ListEventsViewRequest, headers: ListEventsViewHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsViewResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "ListEventsView",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/eventsview`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListEventsViewResponse>(await this.execute(params, req, runtime), new ListEventsViewResponse({}));
  }

  /**
   * 查询日程视图列表以查看闲忙，展开循环日程
   * 
   * @param request - ListEventsViewRequest
   * @returns ListEventsViewResponse
   */
  async listEventsView(userId: string, calendarId: string, request: ListEventsViewRequest): Promise<ListEventsViewResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsViewHeaders({ });
    return await this.listEventsViewWithOptions(userId, calendarId, request, headers, runtime);
  }

  /**
   * 查询日程视图列表以查看闲忙，展开循环日程(me接口）
   * 
   * @param request - ListEventsViewByMeRequest
   * @param headers - ListEventsViewByMeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListEventsViewByMeResponse
   */
  async listEventsViewByMeWithOptions(calendarId: string, request: ListEventsViewByMeRequest, headers: ListEventsViewByMeHeaders, runtime: $Util.RuntimeOptions): Promise<ListEventsViewByMeResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListEventsViewByMe",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/me/calendars/${calendarId}/eventsview`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListEventsViewByMeResponse>(await this.execute(params, req, runtime), new ListEventsViewByMeResponse({}));
  }

  /**
   * 查询日程视图列表以查看闲忙，展开循环日程(me接口）
   * 
   * @param request - ListEventsViewByMeRequest
   * @returns ListEventsViewByMeResponse
   */
  async listEventsViewByMe(calendarId: string, request: ListEventsViewByMeRequest): Promise<ListEventsViewByMeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEventsViewByMeHeaders({ });
    return await this.listEventsViewByMeWithOptions(calendarId, request, headers, runtime);
  }

  /**
   * 查询循环日程实例列表
   * 
   * @param request - ListInstancesRequest
   * @param headers - ListInstancesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListInstancesResponse
   */
  async listInstancesWithOptions(userId: string, calendarId: string, eventId: string, request: ListInstancesRequest, headers: ListInstancesHeaders, runtime: $Util.RuntimeOptions): Promise<ListInstancesResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "ListInstances",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/instances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListInstancesResponse>(await this.execute(params, req, runtime), new ListInstancesResponse({}));
  }

  /**
   * 查询循环日程实例列表
   * 
   * @param request - ListInstancesRequest
   * @returns ListInstancesResponse
   */
  async listInstances(userId: string, calendarId: string, eventId: string, request: ListInstancesRequest): Promise<ListInstancesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListInstancesHeaders({ });
    return await this.listInstancesWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 设置会议室在日程中的响应状态
   * 
   * @param request - MeetingRoomRespondRequest
   * @param headers - MeetingRoomRespondHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MeetingRoomRespondResponse
   */
  async meetingRoomRespondWithOptions(calendarId: string, userId: string, eventId: string, roomId: string, request: MeetingRoomRespondRequest, headers: MeetingRoomRespondHeaders, runtime: $Util.RuntimeOptions): Promise<MeetingRoomRespondResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.responseStatus)) {
      body["responseStatus"] = request.responseStatus;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.userAgent)) {
      realHeaders["userAgent"] = Util.toJSONString(headers.userAgent);
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "MeetingRoomRespond",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/meetingRooms/${roomId}/respond`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MeetingRoomRespondResponse>(await this.execute(params, req, runtime), new MeetingRoomRespondResponse({}));
  }

  /**
   * 设置会议室在日程中的响应状态
   * 
   * @param request - MeetingRoomRespondRequest
   * @returns MeetingRoomRespondResponse
   */
  async meetingRoomRespond(calendarId: string, userId: string, eventId: string, roomId: string, request: MeetingRoomRespondRequest): Promise<MeetingRoomRespondResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MeetingRoomRespondHeaders({ });
    return await this.meetingRoomRespondWithOptions(calendarId, userId, eventId, roomId, request, headers, runtime);
  }

  /**
   * 修改日程
   * 
   * @param request - PatchEventRequest
   * @param headers - PatchEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PatchEventResponse
   */
  async patchEventWithOptions(userId: string, calendarId: string, eventId: string, request: PatchEventRequest, headers: PatchEventHeaders, runtime: $Util.RuntimeOptions): Promise<PatchEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attendees)) {
      body["attendees"] = request.attendees;
    }

    if (!Util.isUnset(request.cardInstances)) {
      body["cardInstances"] = request.cardInstances;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.end)) {
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

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.onlineMeetingInfo)) {
      body["onlineMeetingInfo"] = request.onlineMeetingInfo;
    }

    if (!Util.isUnset(request.recurrence)) {
      body["recurrence"] = request.recurrence;
    }

    if (!Util.isUnset(request.reminders)) {
      body["reminders"] = request.reminders;
    }

    if (!Util.isUnset(request.richTextDescription)) {
      body["richTextDescription"] = request.richTextDescription;
    }

    if (!Util.isUnset(request.start)) {
      body["start"] = request.start;
    }

    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    if (!Util.isUnset(request.uiConfigs)) {
      body["uiConfigs"] = request.uiConfigs;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "PatchEvent",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PatchEventResponse>(await this.execute(params, req, runtime), new PatchEventResponse({}));
  }

  /**
   * 修改日程
   * 
   * @param request - PatchEventRequest
   * @returns PatchEventResponse
   */
  async patchEvent(userId: string, calendarId: string, eventId: string, request: PatchEventRequest): Promise<PatchEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PatchEventHeaders({ });
    return await this.patchEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 删除日程参与人
   * 
   * @param request - RemoveAttendeeRequest
   * @param headers - RemoveAttendeeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveAttendeeResponse
   */
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

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RemoveAttendee",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/attendees/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<RemoveAttendeeResponse>(await this.execute(params, req, runtime), new RemoveAttendeeResponse({}));
  }

  /**
   * 删除日程参与人
   * 
   * @param request - RemoveAttendeeRequest
   * @returns RemoveAttendeeResponse
   */
  async removeAttendee(userId: string, calendarId: string, eventId: string, request: RemoveAttendeeRequest): Promise<RemoveAttendeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveAttendeeHeaders({ });
    return await this.removeAttendeeWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 删除会议室
   * 
   * @param request - RemoveMeetingRoomsRequest
   * @param headers - RemoveMeetingRoomsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveMeetingRoomsResponse
   */
  async removeMeetingRoomsWithOptions(userId: string, calendarId: string, eventId: string, request: RemoveMeetingRoomsRequest, headers: RemoveMeetingRoomsHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveMeetingRoomsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.meetingRoomsToRemove)) {
      body["meetingRoomsToRemove"] = request.meetingRoomsToRemove;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RemoveMeetingRooms",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/meetingRooms/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveMeetingRoomsResponse>(await this.execute(params, req, runtime), new RemoveMeetingRoomsResponse({}));
  }

  /**
   * 删除会议室
   * 
   * @param request - RemoveMeetingRoomsRequest
   * @returns RemoveMeetingRoomsResponse
   */
  async removeMeetingRooms(userId: string, calendarId: string, eventId: string, request: RemoveMeetingRoomsRequest): Promise<RemoveMeetingRoomsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveMeetingRoomsHeaders({ });
    return await this.removeMeetingRoomsWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 回复日程邀请
   * 
   * @param request - RespondEventRequest
   * @param headers - RespondEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RespondEventResponse
   */
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

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RespondEvent",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/respond`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<RespondEventResponse>(await this.execute(params, req, runtime), new RespondEventResponse({}));
  }

  /**
   * 回复日程邀请
   * 
   * @param request - RespondEventRequest
   * @returns RespondEventResponse
   */
  async respondEvent(userId: string, calendarId: string, eventId: string, request: RespondEventRequest): Promise<RespondEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RespondEventHeaders({ });
    return await this.respondEventWithOptions(userId, calendarId, eventId, request, headers, runtime);
  }

  /**
   * 签到
   * 
   * @param headers - SignInHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SignInResponse
   */
  async signInWithOptions(userId: string, calendarId: string, eventId: string, headers: SignInHeaders, runtime: $Util.RuntimeOptions): Promise<SignInResponse> {
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
    let params = new $OpenApi.Params({
      action: "SignIn",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signin`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SignInResponse>(await this.execute(params, req, runtime), new SignInResponse({}));
  }

  /**
   * 签到
   * @returns SignInResponse
   */
  async signIn(userId: string, calendarId: string, eventId: string): Promise<SignInResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignInHeaders({ });
    return await this.signInWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  /**
   * 签退
   * 
   * @param headers - SignOutHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SignOutResponse
   */
  async signOutWithOptions(userId: string, calendarId: string, eventId: string, headers: SignOutHeaders, runtime: $Util.RuntimeOptions): Promise<SignOutResponse> {
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
    let params = new $OpenApi.Params({
      action: "SignOut",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/signOut`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SignOutResponse>(await this.execute(params, req, runtime), new SignOutResponse({}));
  }

  /**
   * 签退
   * @returns SignOutResponse
   */
  async signOut(userId: string, calendarId: string, eventId: string): Promise<SignOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignOutHeaders({ });
    return await this.signOutWithOptions(userId, calendarId, eventId, headers, runtime);
  }

  /**
   * 订阅公共日历
   * 
   * @param headers - SubscribeCalendarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SubscribeCalendarResponse
   */
  async subscribeCalendarWithOptions(userId: string, calendarId: string, headers: SubscribeCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<SubscribeCalendarResponse> {
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
    let params = new $OpenApi.Params({
      action: "SubscribeCalendar",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/subscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<SubscribeCalendarResponse>(await this.execute(params, req, runtime), new SubscribeCalendarResponse({}));
  }

  /**
   * 订阅公共日历
   * @returns SubscribeCalendarResponse
   */
  async subscribeCalendar(userId: string, calendarId: string): Promise<SubscribeCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubscribeCalendarHeaders({ });
    return await this.subscribeCalendarWithOptions(userId, calendarId, headers, runtime);
  }

  /**
   * 日程转让
   * 
   * @param request - TransferEventRequest
   * @param headers - TransferEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TransferEventResponse
   */
  async transferEventWithOptions(calendarId: string, userId: string, eventId: string, request: TransferEventRequest, headers: TransferEventHeaders, runtime: $Util.RuntimeOptions): Promise<TransferEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isExitCalendar)) {
      body["isExitCalendar"] = request.isExitCalendar;
    }

    if (!Util.isUnset(request.needNotifyViaO2O)) {
      body["needNotifyViaO2O"] = request.needNotifyViaO2O;
    }

    if (!Util.isUnset(request.newOrganizerId)) {
      body["newOrganizerId"] = request.newOrganizerId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xClientToken)) {
      realHeaders["x-client-token"] = Util.toJSONString(headers.xClientToken);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "TransferEvent",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/events/${eventId}/transfer`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TransferEventResponse>(await this.execute(params, req, runtime), new TransferEventResponse({}));
  }

  /**
   * 日程转让
   * 
   * @param request - TransferEventRequest
   * @returns TransferEventResponse
   */
  async transferEvent(calendarId: string, userId: string, eventId: string, request: TransferEventRequest): Promise<TransferEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransferEventHeaders({ });
    return await this.transferEventWithOptions(calendarId, userId, eventId, request, headers, runtime);
  }

  /**
   * 取消订阅公共日历
   * 
   * @param headers - UnsubscribeCalendarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UnsubscribeCalendarResponse
   */
  async unsubscribeCalendarWithOptions(userId: string, calendarId: string, headers: UnsubscribeCalendarHeaders, runtime: $Util.RuntimeOptions): Promise<UnsubscribeCalendarResponse> {
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
    let params = new $OpenApi.Params({
      action: "UnsubscribeCalendar",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/calendars/${calendarId}/unsubscribe`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnsubscribeCalendarResponse>(await this.execute(params, req, runtime), new UnsubscribeCalendarResponse({}));
  }

  /**
   * 取消订阅公共日历
   * @returns UnsubscribeCalendarResponse
   */
  async unsubscribeCalendar(userId: string, calendarId: string): Promise<UnsubscribeCalendarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsubscribeCalendarHeaders({ });
    return await this.unsubscribeCalendarWithOptions(userId, calendarId, headers, runtime);
  }

  /**
   * 更新指定订阅日历
   * 
   * @param request - UpdateSubscribedCalendarsRequest
   * @param headers - UpdateSubscribedCalendarsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateSubscribedCalendarsResponse
   */
  async updateSubscribedCalendarsWithOptions(calendarId: string, userId: string, request: UpdateSubscribedCalendarsRequest, headers: UpdateSubscribedCalendarsHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSubscribedCalendarsResponse> {
    Util.validateModel(request);
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

    if (!Util.isUnset(request.subscribeScope)) {
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
    let params = new $OpenApi.Params({
      action: "UpdateSubscribedCalendars",
      version: "calendar_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/calendar/users/${userId}/subscribedCalendars/${calendarId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateSubscribedCalendarsResponse>(await this.execute(params, req, runtime), new UpdateSubscribedCalendarsResponse({}));
  }

  /**
   * 更新指定订阅日历
   * 
   * @param request - UpdateSubscribedCalendarsRequest
   * @returns UpdateSubscribedCalendarsResponse
   */
  async updateSubscribedCalendars(calendarId: string, userId: string, request: UpdateSubscribedCalendarsRequest): Promise<UpdateSubscribedCalendarsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSubscribedCalendarsHeaders({ });
    return await this.updateSubscribedCalendarsWithOptions(calendarId, userId, request, headers, runtime);
  }

}
