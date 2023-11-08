// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class MemberModelMapValue extends $tea.Model {
  unionId?: string;
  conferenceId?: string;
  userNick?: string;
  joinTime?: number;
  leaveTime?: number;
  duration?: number;
  attendStatus?: number;
  host?: boolean;
  coHost?: boolean;
  outerOrgMember?: boolean;
  pstnJoin?: boolean;
  deviceType?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      conferenceId: 'conferenceId',
      userNick: 'userNick',
      joinTime: 'joinTime',
      leaveTime: 'leaveTime',
      duration: 'duration',
      attendStatus: 'attendStatus',
      host: 'host',
      coHost: 'coHost',
      outerOrgMember: 'outerOrgMember',
      pstnJoin: 'pstnJoin',
      deviceType: 'deviceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      conferenceId: 'string',
      userNick: 'string',
      joinTime: 'number',
      leaveTime: 'number',
      duration: 'number',
      attendStatus: 'number',
      host: 'boolean',
      coHost: 'boolean',
      outerOrgMember: 'boolean',
      pstnJoin: 'boolean',
      deviceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelScheduleConferenceHeaders extends $tea.Model {
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

export class CancelScheduleConferenceRequest extends $tea.Model {
  creatorUnionId?: string;
  scheduleConferenceId?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      scheduleConferenceId: 'scheduleConferenceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      scheduleConferenceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelScheduleConferenceResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelScheduleConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CancelScheduleConferenceResponseBody;
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
      body: CancelScheduleConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceHeaders extends $tea.Model {
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

export class CloseVideoConferenceRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceResponseBody extends $tea.Model {
  cause?: string;
  code?: number;
  static names(): { [key: string]: string } {
    return {
      cause: 'cause',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cause: 'string',
      code: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CloseVideoConferenceResponseBody;
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
      body: CloseVideoConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CohostsHeaders extends $tea.Model {
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

export class CohostsRequest extends $tea.Model {
  action?: string;
  userList?: CohostsRequestUserList[];
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      userList: { 'type': 'array', 'itemType': CohostsRequestUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CohostsResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CohostsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CohostsResponseBody;
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
      body: CohostsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScheduleConferenceHeaders extends $tea.Model {
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

export class CreateScheduleConferenceRequest extends $tea.Model {
  creatorUnionId?: string;
  endTime?: number;
  startTime?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      endTime: 'endTime',
      startTime: 'startTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      endTime: 'number',
      startTime: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScheduleConferenceResponseBody extends $tea.Model {
  phones?: string[];
  requestId?: string;
  roomCode?: string;
  scheduleConferenceId?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      phones: 'phones',
      requestId: 'requestId',
      roomCode: 'roomCode',
      scheduleConferenceId: 'scheduleConferenceId',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      phones: { 'type': 'array', 'itemType': 'string' },
      requestId: 'string',
      roomCode: 'string',
      scheduleConferenceId: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScheduleConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateScheduleConferenceResponseBody;
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
      body: CreateScheduleConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceHeaders extends $tea.Model {
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

export class CreateVideoConferenceRequest extends $tea.Model {
  confTitle?: string;
  inviteCaller?: boolean;
  inviteUserIds?: string[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      confTitle: 'confTitle',
      inviteCaller: 'inviteCaller',
      inviteUserIds: 'inviteUserIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      confTitle: 'string',
      inviteCaller: 'boolean',
      inviteUserIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceResponseBody extends $tea.Model {
  conferenceId?: string;
  conferencePassword?: string;
  externalLinkUrl?: string;
  hostPassword?: string;
  phoneNumbers?: string[];
  roomCode?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      conferencePassword: 'conferencePassword',
      externalLinkUrl: 'externalLinkUrl',
      hostPassword: 'hostPassword',
      phoneNumbers: 'phoneNumbers',
      roomCode: 'roomCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      conferencePassword: 'string',
      externalLinkUrl: 'string',
      hostPassword: 'string',
      phoneNumbers: { 'type': 'array', 'itemType': 'string' },
      roomCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateVideoConferenceResponseBody;
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
      body: CreateVideoConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FocusHeaders extends $tea.Model {
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

export class FocusRequest extends $tea.Model {
  action?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FocusResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FocusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: FocusResponseBody;
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
      body: FocusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDataByConferenceIdHeaders extends $tea.Model {
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

export class GetConfDataByConferenceIdRequest extends $tea.Model {
  realData?: boolean;
  static names(): { [key: string]: string } {
    return {
      realData: 'realData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      realData: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDataByConferenceIdResponseBody extends $tea.Model {
  conferenceId?: string;
  creatorId?: string;
  creatorNick?: string;
  deptName?: string;
  endTime?: number;
  freeType?: string;
  scene?: string;
  startTime?: number;
  timeLength?: number;
  title?: string;
  userCount?: number;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      creatorId: 'creatorId',
      creatorNick: 'creatorNick',
      deptName: 'deptName',
      endTime: 'endTime',
      freeType: 'freeType',
      scene: 'scene',
      startTime: 'startTime',
      timeLength: 'timeLength',
      title: 'title',
      userCount: 'userCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      creatorId: 'string',
      creatorNick: 'string',
      deptName: 'string',
      endTime: 'number',
      freeType: 'string',
      scene: 'string',
      startTime: 'number',
      timeLength: 'number',
      title: 'string',
      userCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDataByConferenceIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetConfDataByConferenceIdResponseBody;
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
      body: GetConfDataByConferenceIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDetailDataHeaders extends $tea.Model {
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

export class GetConfDetailDataRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  nick?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      nick: 'nick',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      nick: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDetailDataResponseBody extends $tea.Model {
  list?: GetConfDetailDataResponseBodyList[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': GetConfDetailDataResponseBodyList },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDetailDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetConfDetailDataResponseBody;
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
      body: GetConfDetailDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHistoryConfDataListHeaders extends $tea.Model {
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

export class GetHistoryConfDataListRequest extends $tea.Model {
  creatorNike?: string;
  endTime?: number;
  freeType?: string;
  maxResults?: number;
  nextToken?: string;
  realData?: boolean;
  scene?: string;
  startTime?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      creatorNike: 'creatorNike',
      endTime: 'endTime',
      freeType: 'freeType',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      realData: 'realData',
      scene: 'scene',
      startTime: 'startTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorNike: 'string',
      endTime: 'number',
      freeType: 'string',
      maxResults: 'number',
      nextToken: 'string',
      realData: 'boolean',
      scene: 'string',
      startTime: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHistoryConfDataListResponseBody extends $tea.Model {
  list?: GetHistoryConfDataListResponseBodyList[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': GetHistoryConfDataListResponseBodyList },
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHistoryConfDataListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetHistoryConfDataListResponseBody;
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
      body: GetHistoryConfDataListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserMetricDataHeaders extends $tea.Model {
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

export class GetUserMetricDataRequest extends $tea.Model {
  beginTime?: number;
  endTime?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'number',
      endTime: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserMetricDataResponseBody extends $tea.Model {
  metricDataList?: GetUserMetricDataResponseBodyMetricDataList[];
  static names(): { [key: string]: string } {
    return {
      metricDataList: 'metricDataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      metricDataList: { 'type': 'array', 'itemType': GetUserMetricDataResponseBodyMetricDataList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserMetricDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserMetricDataResponseBody;
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
      body: GetUserMetricDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InviteUsersHeaders extends $tea.Model {
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

export class InviteUsersRequest extends $tea.Model {
  inviteeList?: InviteUsersRequestInviteeList[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      inviteeList: 'inviteeList',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteeList: { 'type': 'array', 'itemType': InviteUsersRequestInviteeList },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InviteUsersResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InviteUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InviteUsersResponseBody;
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
      body: InviteUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class KickMembersHeaders extends $tea.Model {
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

export class KickMembersRequest extends $tea.Model {
  forbiddenRejoin?: boolean;
  userList?: KickMembersRequestUserList[];
  static names(): { [key: string]: string } {
    return {
      forbiddenRejoin: 'forbiddenRejoin',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      forbiddenRejoin: 'boolean',
      userList: { 'type': 'array', 'itemType': KickMembersRequestUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class KickMembersResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class KickMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: KickMembersResponseBody;
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
      body: KickMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MuteAllHeaders extends $tea.Model {
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

export class MuteAllRequest extends $tea.Model {
  action?: string;
  forceMute?: boolean;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      forceMute: 'forceMute',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      forceMute: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MuteAllResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MuteAllResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: MuteAllResponseBody;
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
      body: MuteAllResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MuteMembersHeaders extends $tea.Model {
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

export class MuteMembersRequest extends $tea.Model {
  action?: string;
  userList?: MuteMembersRequestUserList[];
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      userList: { 'type': 'array', 'itemType': MuteMembersRequestUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MuteMembersResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MuteMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: MuteMembersResponseBody;
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
      body: MuteMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextHeaders extends $tea.Model {
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

export class QueryCloudRecordTextRequest extends $tea.Model {
  direction?: string;
  maxResults?: number;
  nextToken?: number;
  startTime?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      direction: 'direction',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      startTime: 'startTime',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      direction: 'string',
      maxResults: 'number',
      nextToken: 'number',
      startTime: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBody extends $tea.Model {
  hasMore?: boolean;
  paragraphList?: QueryCloudRecordTextResponseBodyParagraphList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      paragraphList: 'paragraphList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      paragraphList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCloudRecordTextResponseBody;
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
      body: QueryCloudRecordTextResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoHeaders extends $tea.Model {
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

export class QueryCloudRecordVideoRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoResponseBody extends $tea.Model {
  videoList?: QueryCloudRecordVideoResponseBodyVideoList[];
  static names(): { [key: string]: string } {
    return {
      videoList: 'videoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      videoList: { 'type': 'array', 'itemType': QueryCloudRecordVideoResponseBodyVideoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCloudRecordVideoResponseBody;
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
      body: QueryCloudRecordVideoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoPlayInfoHeaders extends $tea.Model {
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

export class QueryCloudRecordVideoPlayInfoRequest extends $tea.Model {
  mediaId?: string;
  regionId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      regionId: 'regionId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      regionId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoPlayInfoResponseBody extends $tea.Model {
  duration?: number;
  fileSize?: number;
  mp4FileUrl?: string;
  playUrl?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      fileSize: 'fileSize',
      mp4FileUrl: 'mp4FileUrl',
      playUrl: 'playUrl',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      fileSize: 'number',
      mp4FileUrl: 'string',
      playUrl: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoPlayInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCloudRecordVideoPlayInfoResponseBody;
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
      body: QueryCloudRecordVideoPlayInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoHeaders extends $tea.Model {
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

export class QueryConferenceInfoResponseBody extends $tea.Model {
  confInfo?: QueryConferenceInfoResponseBodyConfInfo;
  static names(): { [key: string]: string } {
    return {
      confInfo: 'confInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      confInfo: QueryConferenceInfoResponseBodyConfInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryConferenceInfoResponseBody;
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
      body: QueryConferenceInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchHeaders extends $tea.Model {
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

export class QueryConferenceInfoBatchRequest extends $tea.Model {
  conferenceIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      conferenceIdList: 'conferenceIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBody extends $tea.Model {
  infos?: QueryConferenceInfoBatchResponseBodyInfos[];
  static names(): { [key: string]: string } {
    return {
      infos: 'infos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      infos: { 'type': 'array', 'itemType': QueryConferenceInfoBatchResponseBodyInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryConferenceInfoBatchResponseBody;
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
      body: QueryConferenceInfoBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceMembersHeaders extends $tea.Model {
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

export class QueryConferenceMembersRequest extends $tea.Model {
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

export class QueryConferenceMembersResponseBody extends $tea.Model {
  memberModels?: QueryConferenceMembersResponseBodyMemberModels[];
  nextToken?: string;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      memberModels: 'memberModels',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberModels: { 'type': 'array', 'itemType': QueryConferenceMembersResponseBodyMemberModels },
      nextToken: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryConferenceMembersResponseBody;
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
      body: QueryConferenceMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConferenceHeaders extends $tea.Model {
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

export class QueryScheduleConferenceRequest extends $tea.Model {
  requestUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      requestUnionId: 'requestUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConferenceResponseBody extends $tea.Model {
  endTime?: number;
  phones?: string[];
  requestId?: string;
  roomCode?: string;
  scheduleConferenceId?: string;
  startTime?: number;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      phones: 'phones',
      requestId: 'requestId',
      roomCode: 'roomCode',
      scheduleConferenceId: 'scheduleConferenceId',
      startTime: 'startTime',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      phones: { 'type': 'array', 'itemType': 'string' },
      requestId: 'string',
      roomCode: 'string',
      scheduleConferenceId: 'string',
      startTime: 'number',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryScheduleConferenceResponseBody;
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
      body: QueryScheduleConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConferenceInfoHeaders extends $tea.Model {
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

export class QueryScheduleConferenceInfoRequest extends $tea.Model {
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

export class QueryScheduleConferenceInfoResponseBody extends $tea.Model {
  conferenceList?: QueryScheduleConferenceInfoResponseBodyConferenceList[];
  nextToken?: string;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      conferenceList: 'conferenceList',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceList: { 'type': 'array', 'itemType': QueryScheduleConferenceInfoResponseBodyConferenceList },
      nextToken: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConferenceInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryScheduleConferenceInfoResponseBody;
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
      body: QueryScheduleConferenceInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserOnGoingConferenceHeaders extends $tea.Model {
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

export class QueryUserOnGoingConferenceRequest extends $tea.Model {
  operatorUnionId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUnionId: 'operatorUnionId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUnionId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserOnGoingConferenceResponseBody extends $tea.Model {
  memberModelMap?: { [key: string]: MemberModelMapValue };
  onGoingConfIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      memberModelMap: 'memberModelMap',
      onGoingConfIdList: 'onGoingConfIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberModelMap: { 'type': 'map', 'keyType': 'string', 'valueType': MemberModelMapValue },
      onGoingConfIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserOnGoingConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserOnGoingConferenceResponseBody;
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
      body: QueryUserOnGoingConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudRecordHeaders extends $tea.Model {
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

export class StartCloudRecordRequest extends $tea.Model {
  mode?: string;
  smallWindowPosition?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      mode: 'mode',
      smallWindowPosition: 'smallWindowPosition',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mode: 'string',
      smallWindowPosition: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudRecordResponseBody extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: StartCloudRecordResponseBody;
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
      body: StartCloudRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartStreamOutHeaders extends $tea.Model {
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

export class StartStreamOutRequest extends $tea.Model {
  mode?: string;
  needHostJoin?: boolean;
  smallWindowPosition?: string;
  streamName?: string;
  streamUrlList?: string[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      mode: 'mode',
      needHostJoin: 'needHostJoin',
      smallWindowPosition: 'smallWindowPosition',
      streamName: 'streamName',
      streamUrlList: 'streamUrlList',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mode: 'string',
      needHostJoin: 'boolean',
      smallWindowPosition: 'string',
      streamName: 'string',
      streamUrlList: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartStreamOutResponseBody extends $tea.Model {
  failStreamMap?: { [key: string]: any };
  successStreamMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      failStreamMap: 'failStreamMap',
      successStreamMap: 'successStreamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failStreamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      successStreamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartStreamOutResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: StartStreamOutResponseBody;
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
      body: StartStreamOutResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudRecordHeaders extends $tea.Model {
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

export class StopCloudRecordRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudRecordResponseBody extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: StopCloudRecordResponseBody;
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
      body: StopCloudRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopStreamOutHeaders extends $tea.Model {
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

export class StopStreamOutRequest extends $tea.Model {
  stopAllStream?: boolean;
  streamId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      stopAllStream: 'stopAllStream',
      streamId: 'streamId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      stopAllStream: 'boolean',
      streamId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopStreamOutResponseBody extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopStreamOutResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: StopStreamOutResponseBody;
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
      body: StopStreamOutResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConferenceHeaders extends $tea.Model {
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

export class UpdateScheduleConferenceRequest extends $tea.Model {
  creatorUnionId?: string;
  endTime?: number;
  scheduleConferenceId?: string;
  startTime?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      endTime: 'endTime',
      scheduleConferenceId: 'scheduleConferenceId',
      startTime: 'startTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      endTime: 'number',
      scheduleConferenceId: 'string',
      startTime: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConferenceResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateScheduleConferenceResponseBody;
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
      body: UpdateScheduleConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceExtInfoHeaders extends $tea.Model {
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

export class UpdateVideoConferenceExtInfoResponseBody extends $tea.Model {
  case?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      case: 'case',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      case: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceExtInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateVideoConferenceExtInfoResponseBody;
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
      body: UpdateVideoConferenceExtInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceSettingHeaders extends $tea.Model {
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

export class UpdateVideoConferenceSettingRequest extends $tea.Model {
  allowUnmuteSelf?: boolean;
  autoTransferHost?: boolean;
  forbiddenShareScreen?: boolean;
  lockConference?: boolean;
  muteAll?: boolean;
  onlyInternalEmployeesJoin?: boolean;
  static names(): { [key: string]: string } {
    return {
      allowUnmuteSelf: 'allowUnmuteSelf',
      autoTransferHost: 'autoTransferHost',
      forbiddenShareScreen: 'forbiddenShareScreen',
      lockConference: 'lockConference',
      muteAll: 'muteAll',
      onlyInternalEmployeesJoin: 'onlyInternalEmployeesJoin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allowUnmuteSelf: 'boolean',
      autoTransferHost: 'boolean',
      forbiddenShareScreen: 'boolean',
      lockConference: 'boolean',
      muteAll: 'boolean',
      onlyInternalEmployeesJoin: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceSettingResponseBody extends $tea.Model {
  case?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      case: 'case',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      case: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateVideoConferenceSettingResponseBody;
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
      body: UpdateVideoConferenceSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CohostsRequestUserList extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDetailDataResponseBodyList extends $tea.Model {
  belongOrg?: string;
  conferenceId?: string;
  deviceType?: string;
  duration?: number;
  joinTime?: number;
  leaveTime?: number;
  networkQuality?: string;
  nick?: string;
  role?: string;
  sessionId?: string;
  status?: string;
  unionId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      belongOrg: 'belongOrg',
      conferenceId: 'conferenceId',
      deviceType: 'deviceType',
      duration: 'duration',
      joinTime: 'joinTime',
      leaveTime: 'leaveTime',
      networkQuality: 'networkQuality',
      nick: 'nick',
      role: 'role',
      sessionId: 'sessionId',
      status: 'status',
      unionId: 'unionId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongOrg: 'string',
      conferenceId: 'string',
      deviceType: 'string',
      duration: 'number',
      joinTime: 'number',
      leaveTime: 'number',
      networkQuality: 'string',
      nick: 'string',
      role: 'string',
      sessionId: 'string',
      status: 'string',
      unionId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHistoryConfDataListResponseBodyList extends $tea.Model {
  conferenceId?: string;
  creatorId?: string;
  creatorNick?: string;
  deptName?: string;
  endTime?: number;
  freeType?: string;
  scene?: string;
  startTime?: number;
  timeLength?: number;
  title?: string;
  userCount?: number;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      creatorId: 'creatorId',
      creatorNick: 'creatorNick',
      deptName: 'deptName',
      endTime: 'endTime',
      freeType: 'freeType',
      scene: 'scene',
      startTime: 'startTime',
      timeLength: 'timeLength',
      title: 'title',
      userCount: 'userCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      creatorId: 'string',
      creatorNick: 'string',
      deptName: 'string',
      endTime: 'number',
      freeType: 'string',
      scene: 'string',
      startTime: 'number',
      timeLength: 'number',
      title: 'string',
      userCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserMetricDataResponseBodyMetricDataList extends $tea.Model {
  audioPlayLevel?: string;
  audioRecLevel?: string;
  audioRecvBitRate?: string;
  audioSendBitRate?: string;
  cameraRecvBitRate?: string;
  cameraRecvFrame?: string;
  cameraRecvResolutionActual?: string;
  cameraSendBitRate?: string;
  cameraSendFrame?: string;
  cameraSendResolutionActual?: string;
  lostRate?: string;
  recvBitRate?: string;
  roundTripTime?: string;
  screenRecvBitRate?: string;
  screenRecvFrame?: string;
  screenRecvResolutionActual?: string;
  screenSendBitRate?: string;
  screenSendFrame?: string;
  screenSendResolutionActual?: string;
  sendBitRate?: string;
  timestamp?: number;
  static names(): { [key: string]: string } {
    return {
      audioPlayLevel: 'audioPlayLevel',
      audioRecLevel: 'audioRecLevel',
      audioRecvBitRate: 'audioRecvBitRate',
      audioSendBitRate: 'audioSendBitRate',
      cameraRecvBitRate: 'cameraRecvBitRate',
      cameraRecvFrame: 'cameraRecvFrame',
      cameraRecvResolutionActual: 'cameraRecvResolutionActual',
      cameraSendBitRate: 'cameraSendBitRate',
      cameraSendFrame: 'cameraSendFrame',
      cameraSendResolutionActual: 'cameraSendResolutionActual',
      lostRate: 'lostRate',
      recvBitRate: 'recvBitRate',
      roundTripTime: 'roundTripTime',
      screenRecvBitRate: 'screenRecvBitRate',
      screenRecvFrame: 'screenRecvFrame',
      screenRecvResolutionActual: 'screenRecvResolutionActual',
      screenSendBitRate: 'screenSendBitRate',
      screenSendFrame: 'screenSendFrame',
      screenSendResolutionActual: 'screenSendResolutionActual',
      sendBitRate: 'sendBitRate',
      timestamp: 'timestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      audioPlayLevel: 'string',
      audioRecLevel: 'string',
      audioRecvBitRate: 'string',
      audioSendBitRate: 'string',
      cameraRecvBitRate: 'string',
      cameraRecvFrame: 'string',
      cameraRecvResolutionActual: 'string',
      cameraSendBitRate: 'string',
      cameraSendFrame: 'string',
      cameraSendResolutionActual: 'string',
      lostRate: 'string',
      recvBitRate: 'string',
      roundTripTime: 'string',
      screenRecvBitRate: 'string',
      screenRecvFrame: 'string',
      screenRecvResolutionActual: 'string',
      screenSendBitRate: 'string',
      screenSendFrame: 'string',
      screenSendResolutionActual: 'string',
      sendBitRate: 'string',
      timestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InviteUsersRequestInviteeList extends $tea.Model {
  nick?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class KickMembersRequestUserList extends $tea.Model {
  participantId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MuteMembersRequestUserList extends $tea.Model {
  participantId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      participantId: 'participantId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList extends $tea.Model {
  endTime?: number;
  startTime?: number;
  word?: string;
  wordId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
      word: 'word',
      wordId: 'wordId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
      word: 'string',
      wordId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphListSentenceList extends $tea.Model {
  endTime?: number;
  sentence?: string;
  startTime?: number;
  unionId?: string;
  wordList?: QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      sentence: 'sentence',
      startTime: 'startTime',
      unionId: 'unionId',
      wordList: 'wordList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      sentence: 'string',
      startTime: 'number',
      unionId: 'string',
      wordList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphListSentenceListWordList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordTextResponseBodyParagraphList extends $tea.Model {
  endTime?: number;
  nextTtoken?: number;
  nickName?: string;
  paragraph?: string;
  recordId?: number;
  sentenceList?: QueryCloudRecordTextResponseBodyParagraphListSentenceList[];
  startTime?: number;
  status?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      nextTtoken: 'nextTtoken',
      nickName: 'nickName',
      paragraph: 'paragraph',
      recordId: 'recordId',
      sentenceList: 'sentenceList',
      startTime: 'startTime',
      status: 'status',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      nextTtoken: 'number',
      nickName: 'string',
      paragraph: 'string',
      recordId: 'number',
      sentenceList: { 'type': 'array', 'itemType': QueryCloudRecordTextResponseBodyParagraphListSentenceList },
      startTime: 'number',
      status: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCloudRecordVideoResponseBodyVideoList extends $tea.Model {
  duration?: number;
  endTime?: number;
  fileSize?: number;
  mediaId?: string;
  recordId?: string;
  recordType?: number;
  regionId?: string;
  startTime?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      endTime: 'endTime',
      fileSize: 'fileSize',
      mediaId: 'mediaId',
      recordId: 'recordId',
      recordType: 'recordType',
      regionId: 'regionId',
      startTime: 'startTime',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      endTime: 'number',
      fileSize: 'number',
      mediaId: 'string',
      recordId: 'string',
      recordType: 'number',
      regionId: 'string',
      startTime: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoResponseBodyConfInfo extends $tea.Model {
  activeNum?: number;
  attendNum?: number;
  confDuration?: number;
  conferenceId?: string;
  creatorId?: string;
  creatorNick?: string;
  endTime?: number;
  externalLinkUrl?: string;
  invitedNum?: number;
  roomCode?: string;
  startTime?: number;
  status?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      activeNum: 'activeNum',
      attendNum: 'attendNum',
      confDuration: 'confDuration',
      conferenceId: 'conferenceId',
      creatorId: 'creatorId',
      creatorNick: 'creatorNick',
      endTime: 'endTime',
      externalLinkUrl: 'externalLinkUrl',
      invitedNum: 'invitedNum',
      roomCode: 'roomCode',
      startTime: 'startTime',
      status: 'status',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeNum: 'number',
      attendNum: 'number',
      confDuration: 'number',
      conferenceId: 'string',
      creatorId: 'string',
      creatorNick: 'string',
      endTime: 'number',
      externalLinkUrl: 'string',
      invitedNum: 'number',
      roomCode: 'string',
      startTime: 'number',
      status: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfosUserList extends $tea.Model {
  attendStatus?: number;
  cameraStatus?: number;
  micStatus?: number;
  nick?: string;
  rejectDescription?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      attendStatus: 'attendStatus',
      cameraStatus: 'cameraStatus',
      micStatus: 'micStatus',
      nick: 'nick',
      rejectDescription: 'rejectDescription',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendStatus: 'number',
      cameraStatus: 'number',
      micStatus: 'number',
      nick: 'string',
      rejectDescription: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfos extends $tea.Model {
  conferenceId?: string;
  mediaStatus?: number;
  startTime?: number;
  status?: number;
  title?: string;
  userList?: QueryConferenceInfoBatchResponseBodyInfosUserList[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      mediaStatus: 'mediaStatus',
      startTime: 'startTime',
      status: 'status',
      title: 'title',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      mediaStatus: 'number',
      startTime: 'number',
      status: 'number',
      title: 'string',
      userList: { 'type': 'array', 'itemType': QueryConferenceInfoBatchResponseBodyInfosUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceMembersResponseBodyMemberModels extends $tea.Model {
  attendStatus?: number;
  coHost?: boolean;
  conferenceId?: string;
  duration?: number;
  host?: boolean;
  joinTime?: number;
  leaveTime?: number;
  outerOrgMember?: boolean;
  pstnJoin?: boolean;
  unionId?: string;
  userNick?: string;
  static names(): { [key: string]: string } {
    return {
      attendStatus: 'attendStatus',
      coHost: 'coHost',
      conferenceId: 'conferenceId',
      duration: 'duration',
      host: 'host',
      joinTime: 'joinTime',
      leaveTime: 'leaveTime',
      outerOrgMember: 'outerOrgMember',
      pstnJoin: 'pstnJoin',
      unionId: 'unionId',
      userNick: 'userNick',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendStatus: 'number',
      coHost: 'boolean',
      conferenceId: 'string',
      duration: 'number',
      host: 'boolean',
      joinTime: 'number',
      leaveTime: 'number',
      outerOrgMember: 'boolean',
      pstnJoin: 'boolean',
      unionId: 'string',
      userNick: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConferenceInfoResponseBodyConferenceList extends $tea.Model {
  conferenceId?: string;
  endTime?: number;
  roomCode?: string;
  startTime?: number;
  status?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      endTime: 'endTime',
      roomCode: 'roomCode',
      startTime: 'startTime',
      status: 'status',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      endTime: 'number',
      roomCode: 'string',
      startTime: 'number',
      status: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async cancelScheduleConferenceWithOptions(request: CancelScheduleConferenceRequest, headers: CancelScheduleConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CancelScheduleConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.scheduleConferenceId)) {
      body["scheduleConferenceId"] = request.scheduleConferenceId;
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
      action: "CancelScheduleConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/scheduleConferences/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CancelScheduleConferenceResponse>(await this.execute(params, req, runtime), new CancelScheduleConferenceResponse({}));
  }

  async cancelScheduleConference(request: CancelScheduleConferenceRequest): Promise<CancelScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelScheduleConferenceHeaders({ });
    return await this.cancelScheduleConferenceWithOptions(request, headers, runtime);
  }

  async closeVideoConferenceWithOptions(conferenceId: string, request: CloseVideoConferenceRequest, headers: CloseVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CloseVideoConferenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "CloseVideoConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CloseVideoConferenceResponse>(await this.execute(params, req, runtime), new CloseVideoConferenceResponse({}));
  }

  async closeVideoConference(conferenceId: string, request: CloseVideoConferenceRequest): Promise<CloseVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseVideoConferenceHeaders({ });
    return await this.closeVideoConferenceWithOptions(conferenceId, request, headers, runtime);
  }

  async cohostsWithOptions(conferenceId: string, request: CohostsRequest, headers: CohostsHeaders, runtime: $Util.RuntimeOptions): Promise<CohostsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.userList)) {
      body["userList"] = request.userList;
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
      action: "Cohosts",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/coHosts/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CohostsResponse>(await this.execute(params, req, runtime), new CohostsResponse({}));
  }

  async cohosts(conferenceId: string, request: CohostsRequest): Promise<CohostsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CohostsHeaders({ });
    return await this.cohostsWithOptions(conferenceId, request, headers, runtime);
  }

  async createScheduleConferenceWithOptions(request: CreateScheduleConferenceRequest, headers: CreateScheduleConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateScheduleConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "CreateScheduleConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/scheduleConferences`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateScheduleConferenceResponse>(await this.execute(params, req, runtime), new CreateScheduleConferenceResponse({}));
  }

  async createScheduleConference(request: CreateScheduleConferenceRequest): Promise<CreateScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateScheduleConferenceHeaders({ });
    return await this.createScheduleConferenceWithOptions(request, headers, runtime);
  }

  async createVideoConferenceWithOptions(request: CreateVideoConferenceRequest, headers: CreateVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateVideoConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.confTitle)) {
      body["confTitle"] = request.confTitle;
    }

    if (!Util.isUnset(request.inviteCaller)) {
      body["inviteCaller"] = request.inviteCaller;
    }

    if (!Util.isUnset(request.inviteUserIds)) {
      body["inviteUserIds"] = request.inviteUserIds;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "CreateVideoConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateVideoConferenceResponse>(await this.execute(params, req, runtime), new CreateVideoConferenceResponse({}));
  }

  async createVideoConference(request: CreateVideoConferenceRequest): Promise<CreateVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVideoConferenceHeaders({ });
    return await this.createVideoConferenceWithOptions(request, headers, runtime);
  }

  async focusWithOptions(conferenceId: string, request: FocusRequest, headers: FocusHeaders, runtime: $Util.RuntimeOptions): Promise<FocusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "Focus",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/focus`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FocusResponse>(await this.execute(params, req, runtime), new FocusResponse({}));
  }

  async focus(conferenceId: string, request: FocusRequest): Promise<FocusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FocusHeaders({ });
    return await this.focusWithOptions(conferenceId, request, headers, runtime);
  }

  async getConfDataByConferenceIdWithOptions(conferenceId: string, request: GetConfDataByConferenceIdRequest, headers: GetConfDataByConferenceIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetConfDataByConferenceIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.realData)) {
      query["realData"] = request.realData;
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
      action: "GetConfDataByConferenceId",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConfDataByConferenceIdResponse>(await this.execute(params, req, runtime), new GetConfDataByConferenceIdResponse({}));
  }

  async getConfDataByConferenceId(conferenceId: string, request: GetConfDataByConferenceIdRequest): Promise<GetConfDataByConferenceIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfDataByConferenceIdHeaders({ });
    return await this.getConfDataByConferenceIdWithOptions(conferenceId, request, headers, runtime);
  }

  async getConfDetailDataWithOptions(conferenceId: string, request: GetConfDetailDataRequest, headers: GetConfDetailDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetConfDetailDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.nick)) {
      query["nick"] = request.nick;
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
      action: "GetConfDetailData",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConfDetailDataResponse>(await this.execute(params, req, runtime), new GetConfDetailDataResponse({}));
  }

  async getConfDetailData(conferenceId: string, request: GetConfDetailDataRequest): Promise<GetConfDetailDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfDetailDataHeaders({ });
    return await this.getConfDetailDataWithOptions(conferenceId, request, headers, runtime);
  }

  async getHistoryConfDataListWithOptions(request: GetHistoryConfDataListRequest, headers: GetHistoryConfDataListHeaders, runtime: $Util.RuntimeOptions): Promise<GetHistoryConfDataListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorNike)) {
      query["creatorNike"] = request.creatorNike;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.freeType)) {
      query["freeType"] = request.freeType;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.realData)) {
      query["realData"] = request.realData;
    }

    if (!Util.isUnset(request.scene)) {
      query["scene"] = request.scene;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      query["title"] = request.title;
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
      action: "GetHistoryConfDataList",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/histories/dataLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetHistoryConfDataListResponse>(await this.execute(params, req, runtime), new GetHistoryConfDataListResponse({}));
  }

  async getHistoryConfDataList(request: GetHistoryConfDataListRequest): Promise<GetHistoryConfDataListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetHistoryConfDataListHeaders({ });
    return await this.getHistoryConfDataListWithOptions(request, headers, runtime);
  }

  async getUserMetricDataWithOptions(conferenceId: string, request: GetUserMetricDataRequest, headers: GetUserMetricDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserMetricDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.beginTime)) {
      query["beginTime"] = request.beginTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetUserMetricData",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/metricDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserMetricDataResponse>(await this.execute(params, req, runtime), new GetUserMetricDataResponse({}));
  }

  async getUserMetricData(conferenceId: string, request: GetUserMetricDataRequest): Promise<GetUserMetricDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserMetricDataHeaders({ });
    return await this.getUserMetricDataWithOptions(conferenceId, request, headers, runtime);
  }

  async inviteUsersWithOptions(conferenceId: string, request: InviteUsersRequest, headers: InviteUsersHeaders, runtime: $Util.RuntimeOptions): Promise<InviteUsersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.inviteeList)) {
      body["inviteeList"] = request.inviteeList;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "InviteUsers",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/users/invite`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InviteUsersResponse>(await this.execute(params, req, runtime), new InviteUsersResponse({}));
  }

  async inviteUsers(conferenceId: string, request: InviteUsersRequest): Promise<InviteUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InviteUsersHeaders({ });
    return await this.inviteUsersWithOptions(conferenceId, request, headers, runtime);
  }

  async kickMembersWithOptions(conferenceId: string, request: KickMembersRequest, headers: KickMembersHeaders, runtime: $Util.RuntimeOptions): Promise<KickMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.forbiddenRejoin)) {
      body["forbiddenRejoin"] = request.forbiddenRejoin;
    }

    if (!Util.isUnset(request.userList)) {
      body["userList"] = request.userList;
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
      action: "KickMembers",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/members/kick`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<KickMembersResponse>(await this.execute(params, req, runtime), new KickMembersResponse({}));
  }

  async kickMembers(conferenceId: string, request: KickMembersRequest): Promise<KickMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new KickMembersHeaders({ });
    return await this.kickMembersWithOptions(conferenceId, request, headers, runtime);
  }

  async muteAllWithOptions(conferenceId: string, request: MuteAllRequest, headers: MuteAllHeaders, runtime: $Util.RuntimeOptions): Promise<MuteAllResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.forceMute)) {
      body["forceMute"] = request.forceMute;
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
      action: "MuteAll",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/allMembers/mute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MuteAllResponse>(await this.execute(params, req, runtime), new MuteAllResponse({}));
  }

  async muteAll(conferenceId: string, request: MuteAllRequest): Promise<MuteAllResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MuteAllHeaders({ });
    return await this.muteAllWithOptions(conferenceId, request, headers, runtime);
  }

  async muteMembersWithOptions(conferenceId: string, request: MuteMembersRequest, headers: MuteMembersHeaders, runtime: $Util.RuntimeOptions): Promise<MuteMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.userList)) {
      body["userList"] = request.userList;
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
      action: "MuteMembers",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/members/mute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MuteMembersResponse>(await this.execute(params, req, runtime), new MuteMembersResponse({}));
  }

  async muteMembers(conferenceId: string, request: MuteMembersRequest): Promise<MuteMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MuteMembersHeaders({ });
    return await this.muteMembersWithOptions(conferenceId, request, headers, runtime);
  }

  async queryCloudRecordTextWithOptions(conferenceId: string, request: QueryCloudRecordTextRequest, headers: QueryCloudRecordTextHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCloudRecordTextResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.direction)) {
      query["direction"] = request.direction;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryCloudRecordText",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/getTexts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCloudRecordTextResponse>(await this.execute(params, req, runtime), new QueryCloudRecordTextResponse({}));
  }

  async queryCloudRecordText(conferenceId: string, request: QueryCloudRecordTextRequest): Promise<QueryCloudRecordTextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordTextHeaders({ });
    return await this.queryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
  }

  async queryCloudRecordVideoWithOptions(conferenceId: string, request: QueryCloudRecordVideoRequest, headers: QueryCloudRecordVideoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCloudRecordVideoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryCloudRecordVideo",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/getVideos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCloudRecordVideoResponse>(await this.execute(params, req, runtime), new QueryCloudRecordVideoResponse({}));
  }

  async queryCloudRecordVideo(conferenceId: string, request: QueryCloudRecordVideoRequest): Promise<QueryCloudRecordVideoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoHeaders({ });
    return await this.queryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
  }

  async queryCloudRecordVideoPlayInfoWithOptions(conferenceId: string, request: QueryCloudRecordVideoPlayInfoRequest, headers: QueryCloudRecordVideoPlayInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCloudRecordVideoPlayInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mediaId)) {
      query["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.regionId)) {
      query["regionId"] = request.regionId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryCloudRecordVideoPlayInfo",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/videos/getPlayInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCloudRecordVideoPlayInfoResponse>(await this.execute(params, req, runtime), new QueryCloudRecordVideoPlayInfoResponse({}));
  }

  async queryCloudRecordVideoPlayInfo(conferenceId: string, request: QueryCloudRecordVideoPlayInfoRequest): Promise<QueryCloudRecordVideoPlayInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoPlayInfoHeaders({ });
    return await this.queryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
  }

  async queryConferenceInfoWithOptions(conferenceId: string, headers: QueryConferenceInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryConferenceInfoResponse> {
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
      action: "QueryConferenceInfo",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryConferenceInfoResponse>(await this.execute(params, req, runtime), new QueryConferenceInfoResponse({}));
  }

  async queryConferenceInfo(conferenceId: string): Promise<QueryConferenceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoHeaders({ });
    return await this.queryConferenceInfoWithOptions(conferenceId, headers, runtime);
  }

  async queryConferenceInfoBatchWithOptions(request: QueryConferenceInfoBatchRequest, headers: QueryConferenceInfoBatchHeaders, runtime: $Util.RuntimeOptions): Promise<QueryConferenceInfoBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conferenceIdList)) {
      body["conferenceIdList"] = request.conferenceIdList;
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
      action: "QueryConferenceInfoBatch",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryConferenceInfoBatchResponse>(await this.execute(params, req, runtime), new QueryConferenceInfoBatchResponse({}));
  }

  async queryConferenceInfoBatch(request: QueryConferenceInfoBatchRequest): Promise<QueryConferenceInfoBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoBatchHeaders({ });
    return await this.queryConferenceInfoBatchWithOptions(request, headers, runtime);
  }

  async queryConferenceMembersWithOptions(conferenceId: string, request: QueryConferenceMembersRequest, headers: QueryConferenceMembersHeaders, runtime: $Util.RuntimeOptions): Promise<QueryConferenceMembersResponse> {
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
      action: "QueryConferenceMembers",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryConferenceMembersResponse>(await this.execute(params, req, runtime), new QueryConferenceMembersResponse({}));
  }

  async queryConferenceMembers(conferenceId: string, request: QueryConferenceMembersRequest): Promise<QueryConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceMembersHeaders({ });
    return await this.queryConferenceMembersWithOptions(conferenceId, request, headers, runtime);
  }

  async queryScheduleConferenceWithOptions(scheduleConferenceId: string, request: QueryScheduleConferenceRequest, headers: QueryScheduleConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryScheduleConferenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.requestUnionId)) {
      query["requestUnionId"] = request.requestUnionId;
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
      action: "QueryScheduleConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/scheduleConferences/${scheduleConferenceId}/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryScheduleConferenceResponse>(await this.execute(params, req, runtime), new QueryScheduleConferenceResponse({}));
  }

  async queryScheduleConference(scheduleConferenceId: string, request: QueryScheduleConferenceRequest): Promise<QueryScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConferenceHeaders({ });
    return await this.queryScheduleConferenceWithOptions(scheduleConferenceId, request, headers, runtime);
  }

  async queryScheduleConferenceInfoWithOptions(scheduleConferenceId: string, request: QueryScheduleConferenceInfoRequest, headers: QueryScheduleConferenceInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryScheduleConferenceInfoResponse> {
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
      action: "QueryScheduleConferenceInfo",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/scheduleConferences/${scheduleConferenceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryScheduleConferenceInfoResponse>(await this.execute(params, req, runtime), new QueryScheduleConferenceInfoResponse({}));
  }

  async queryScheduleConferenceInfo(scheduleConferenceId: string, request: QueryScheduleConferenceInfoRequest): Promise<QueryScheduleConferenceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConferenceInfoHeaders({ });
    return await this.queryScheduleConferenceInfoWithOptions(scheduleConferenceId, request, headers, runtime);
  }

  async queryUserOnGoingConferenceWithOptions(request: QueryUserOnGoingConferenceRequest, headers: QueryUserOnGoingConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserOnGoingConferenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUnionId)) {
      query["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryUserOnGoingConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/users/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserOnGoingConferenceResponse>(await this.execute(params, req, runtime), new QueryUserOnGoingConferenceResponse({}));
  }

  async queryUserOnGoingConference(request: QueryUserOnGoingConferenceRequest): Promise<QueryUserOnGoingConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserOnGoingConferenceHeaders({ });
    return await this.queryUserOnGoingConferenceWithOptions(request, headers, runtime);
  }

  async startCloudRecordWithOptions(conferenceId: string, request: StartCloudRecordRequest, headers: StartCloudRecordHeaders, runtime: $Util.RuntimeOptions): Promise<StartCloudRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mode)) {
      body["mode"] = request.mode;
    }

    if (!Util.isUnset(request.smallWindowPosition)) {
      body["smallWindowPosition"] = request.smallWindowPosition;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "StartCloudRecord",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/start`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StartCloudRecordResponse>(await this.execute(params, req, runtime), new StartCloudRecordResponse({}));
  }

  async startCloudRecord(conferenceId: string, request: StartCloudRecordRequest): Promise<StartCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCloudRecordHeaders({ });
    return await this.startCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  async startStreamOutWithOptions(conferenceId: string, request: StartStreamOutRequest, headers: StartStreamOutHeaders, runtime: $Util.RuntimeOptions): Promise<StartStreamOutResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mode)) {
      body["mode"] = request.mode;
    }

    if (!Util.isUnset(request.needHostJoin)) {
      body["needHostJoin"] = request.needHostJoin;
    }

    if (!Util.isUnset(request.smallWindowPosition)) {
      body["smallWindowPosition"] = request.smallWindowPosition;
    }

    if (!Util.isUnset(request.streamName)) {
      body["streamName"] = request.streamName;
    }

    if (!Util.isUnset(request.streamUrlList)) {
      body["streamUrlList"] = request.streamUrlList;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "StartStreamOut",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/streamOuts/start`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<StartStreamOutResponse>(await this.execute(params, req, runtime), new StartStreamOutResponse({}));
  }

  async startStreamOut(conferenceId: string, request: StartStreamOutRequest): Promise<StartStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartStreamOutHeaders({ });
    return await this.startStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  async stopCloudRecordWithOptions(conferenceId: string, request: StopCloudRecordRequest, headers: StopCloudRecordHeaders, runtime: $Util.RuntimeOptions): Promise<StopCloudRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "StopCloudRecord",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/cloudRecords/stop`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StopCloudRecordResponse>(await this.execute(params, req, runtime), new StopCloudRecordResponse({}));
  }

  async stopCloudRecord(conferenceId: string, request: StopCloudRecordRequest): Promise<StopCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopCloudRecordHeaders({ });
    return await this.stopCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  async stopStreamOutWithOptions(conferenceId: string, request: StopStreamOutRequest, headers: StopStreamOutHeaders, runtime: $Util.RuntimeOptions): Promise<StopStreamOutResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.stopAllStream)) {
      body["stopAllStream"] = request.stopAllStream;
    }

    if (!Util.isUnset(request.streamId)) {
      body["streamId"] = request.streamId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "StopStreamOut",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/streamOuts/stop`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StopStreamOutResponse>(await this.execute(params, req, runtime), new StopStreamOutResponse({}));
  }

  async stopStreamOut(conferenceId: string, request: StopStreamOutRequest): Promise<StopStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopStreamOutHeaders({ });
    return await this.stopStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  async updateScheduleConferenceWithOptions(request: UpdateScheduleConferenceRequest, headers: UpdateScheduleConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateScheduleConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.scheduleConferenceId)) {
      body["scheduleConferenceId"] = request.scheduleConferenceId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "UpdateScheduleConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/scheduleConferences`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateScheduleConferenceResponse>(await this.execute(params, req, runtime), new UpdateScheduleConferenceResponse({}));
  }

  async updateScheduleConference(request: UpdateScheduleConferenceRequest): Promise<UpdateScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateScheduleConferenceHeaders({ });
    return await this.updateScheduleConferenceWithOptions(request, headers, runtime);
  }

  async updateVideoConferenceExtInfoWithOptions(conferenceId: string, headers: UpdateVideoConferenceExtInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVideoConferenceExtInfoResponse> {
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
      action: "UpdateVideoConferenceExtInfo",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/extInfo`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateVideoConferenceExtInfoResponse>(await this.execute(params, req, runtime), new UpdateVideoConferenceExtInfoResponse({}));
  }

  async updateVideoConferenceExtInfo(conferenceId: string): Promise<UpdateVideoConferenceExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceExtInfoHeaders({ });
    return await this.updateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
  }

  async updateVideoConferenceSettingWithOptions(conferenceId: string, request: UpdateVideoConferenceSettingRequest, headers: UpdateVideoConferenceSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVideoConferenceSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.allowUnmuteSelf)) {
      body["allowUnmuteSelf"] = request.allowUnmuteSelf;
    }

    if (!Util.isUnset(request.autoTransferHost)) {
      body["autoTransferHost"] = request.autoTransferHost;
    }

    if (!Util.isUnset(request.forbiddenShareScreen)) {
      body["forbiddenShareScreen"] = request.forbiddenShareScreen;
    }

    if (!Util.isUnset(request.lockConference)) {
      body["lockConference"] = request.lockConference;
    }

    if (!Util.isUnset(request.muteAll)) {
      body["muteAll"] = request.muteAll;
    }

    if (!Util.isUnset(request.onlyInternalEmployeesJoin)) {
      body["onlyInternalEmployeesJoin"] = request.onlyInternalEmployeesJoin;
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
      action: "UpdateVideoConferenceSetting",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateVideoConferenceSettingResponse>(await this.execute(params, req, runtime), new UpdateVideoConferenceSettingResponse({}));
  }

  async updateVideoConferenceSetting(conferenceId: string, request: UpdateVideoConferenceSettingRequest): Promise<UpdateVideoConferenceSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceSettingHeaders({ });
    return await this.updateVideoConferenceSettingWithOptions(conferenceId, request, headers, runtime);
  }

}
