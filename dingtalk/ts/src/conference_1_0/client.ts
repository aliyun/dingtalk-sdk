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

export class MetricMapValue extends $tea.Model {
  timestamp?: number;
  sendBitRate?: string;
  recvBitRate?: string;
  lostRate?: string;
  roundTripTime?: string;
  audioSendBitRate?: string;
  audioRecvBitRate?: string;
  audioRecLevel?: string;
  audioPlayLevel?: string;
  cameraSendBitRate?: string;
  cameraRecvBitRate?: string;
  cameraSendResolutionActual?: string;
  cameraRecvResolutionActual?: string;
  cameraSendFrame?: string;
  screenSendBitRate?: string;
  cameraRecvFrame?: string;
  screenRecvBitRate?: string;
  screenSendResolutionActual?: string;
  screenRecvResolutionActual?: string;
  screenSendFrame?: string;
  screenRecvFrame?: string;
  audioJitterMax?: string;
  audioJitterAvg?: string;
  static names(): { [key: string]: string } {
    return {
      timestamp: 'timestamp',
      sendBitRate: 'sendBitRate',
      recvBitRate: 'recvBitRate',
      lostRate: 'lostRate',
      roundTripTime: 'roundTripTime',
      audioSendBitRate: 'audioSendBitRate',
      audioRecvBitRate: 'audioRecvBitRate',
      audioRecLevel: 'audioRecLevel',
      audioPlayLevel: 'audioPlayLevel',
      cameraSendBitRate: 'cameraSendBitRate',
      cameraRecvBitRate: 'cameraRecvBitRate',
      cameraSendResolutionActual: 'cameraSendResolutionActual',
      cameraRecvResolutionActual: 'cameraRecvResolutionActual',
      cameraSendFrame: 'cameraSendFrame',
      screenSendBitRate: 'screenSendBitRate',
      cameraRecvFrame: 'cameraRecvFrame',
      screenRecvBitRate: 'screenRecvBitRate',
      screenSendResolutionActual: 'screenSendResolutionActual',
      screenRecvResolutionActual: 'screenRecvResolutionActual',
      screenSendFrame: 'screenSendFrame',
      screenRecvFrame: 'screenRecvFrame',
      audioJitterMax: 'audioJitterMax',
      audioJitterAvg: 'audioJitterAvg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      timestamp: 'number',
      sendBitRate: 'string',
      recvBitRate: 'string',
      lostRate: 'string',
      roundTripTime: 'string',
      audioSendBitRate: 'string',
      audioRecvBitRate: 'string',
      audioRecLevel: 'string',
      audioPlayLevel: 'string',
      cameraSendBitRate: 'string',
      cameraRecvBitRate: 'string',
      cameraSendResolutionActual: 'string',
      cameraRecvResolutionActual: 'string',
      cameraSendFrame: 'string',
      screenSendBitRate: 'string',
      cameraRecvFrame: 'string',
      screenRecvBitRate: 'string',
      screenSendResolutionActual: 'string',
      screenRecvResolutionActual: 'string',
      screenSendFrame: 'string',
      screenRecvFrame: 'string',
      audioJitterMax: 'string',
      audioJitterAvg: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CancelScheduleConferenceResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CloseVideoConferenceResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CohostsResponseBody;
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

export class CreateCustomShortLinkHeaders extends $tea.Model {
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

export class CreateCustomShortLinkRequest extends $tea.Model {
  coolAppCode?: string;
  creatorUnionId?: string;
  extensionAppBizData?: string;
  scheduleConferenceId?: string;
  useExtensionApp?: boolean;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      creatorUnionId: 'creatorUnionId',
      extensionAppBizData: 'extensionAppBizData',
      scheduleConferenceId: 'scheduleConferenceId',
      useExtensionApp: 'useExtensionApp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      creatorUnionId: 'string',
      extensionAppBizData: 'string',
      scheduleConferenceId: 'string',
      useExtensionApp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomShortLinkResponseBody extends $tea.Model {
  result?: CreateCustomShortLinkResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateCustomShortLinkResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomShortLinkResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCustomShortLinkResponseBody;
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
      body: CreateCustomShortLinkResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateScheduleConferenceResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateVideoConferenceResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FocusResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConfDataByConferenceIdResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConfDetailDataResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetHistoryConfDataListResponseBody;
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

export class GetUserLastMetricHeaders extends $tea.Model {
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

export class GetUserLastMetricRequest extends $tea.Model {
  unionIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      unionIdList: 'unionIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserLastMetricResponseBody extends $tea.Model {
  metricMap?: { [key: string]: MetricMapValue };
  static names(): { [key: string]: string } {
    return {
      metricMap: 'metricMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      metricMap: { 'type': 'map', 'keyType': 'string', 'valueType': MetricMapValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserLastMetricResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserLastMetricResponseBody;
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
      body: GetUserLastMetricResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserMetricDataResponseBody;
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
  phoneInviteeList?: InviteUsersRequestPhoneInviteeList[];
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      inviteeList: 'inviteeList',
      phoneInviteeList: 'phoneInviteeList',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteeList: { 'type': 'array', 'itemType': InviteUsersRequestInviteeList },
      phoneInviteeList: { 'type': 'array', 'itemType': InviteUsersRequestPhoneInviteeList },
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InviteUsersResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: KickMembersResponseBody;
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

export class LockConferenceHeaders extends $tea.Model {
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

export class LockConferenceRequest extends $tea.Model {
  action?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LockConferenceResponseBody extends $tea.Model {
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

export class LockConferenceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LockConferenceResponseBody;
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
      body: LockConferenceResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MuteAllResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MuteMembersResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCloudRecordTextResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCloudRecordVideoResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCloudRecordVideoPlayInfoResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryConferenceInfoResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryConferenceInfoBatchResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryConferenceMembersResponseBody;
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

export class QueryScheduleConfSettingsHeaders extends $tea.Model {
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

export class QueryScheduleConfSettingsRequest extends $tea.Model {
  scheduleConferenceId?: string;
  static names(): { [key: string]: string } {
    return {
      scheduleConferenceId: 'scheduleConferenceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scheduleConferenceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConfSettingsResponseBody extends $tea.Model {
  scheduleConfSettingModel?: QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel;
  static names(): { [key: string]: string } {
    return {
      scheduleConfSettingModel: 'scheduleConfSettingModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scheduleConfSettingModel: QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConfSettingsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryScheduleConfSettingsResponseBody;
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
      body: QueryScheduleConfSettingsResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryScheduleConferenceResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryScheduleConferenceInfoResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUserOnGoingConferenceResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StartCloudRecordResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StartStreamOutResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StopCloudRecordResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StopStreamOutResponseBody;
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

export class UpdateScheduleConfSettingsHeaders extends $tea.Model {
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

export class UpdateScheduleConfSettingsRequest extends $tea.Model {
  creatorUnionId?: string;
  scheduleConfSettingModel?: UpdateScheduleConfSettingsRequestScheduleConfSettingModel;
  scheduleConferenceId?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      scheduleConfSettingModel: 'scheduleConfSettingModel',
      scheduleConferenceId: 'scheduleConferenceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      scheduleConfSettingModel: UpdateScheduleConfSettingsRequestScheduleConfSettingModel,
      scheduleConferenceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConfSettingsResponseBody extends $tea.Model {
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

export class UpdateScheduleConfSettingsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateScheduleConfSettingsResponseBody;
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
      body: UpdateScheduleConfSettingsResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateScheduleConferenceResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateVideoConferenceExtInfoResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateVideoConferenceSettingResponseBody;
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

export class CreateCustomShortLinkResponseBodyResult extends $tea.Model {
  customShortLink?: string;
  static names(): { [key: string]: string } {
    return {
      customShortLink: 'customShortLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customShortLink: 'string',
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

export class InviteUsersRequestPhoneInviteeList extends $tea.Model {
  nick?: string;
  phoneNumber?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      phoneNumber: 'phoneNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      phoneNumber: 'string',
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

export class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends $tea.Model {
  autoOpenMode?: string;
  clientId?: string;
  coolAppCode?: string;
  extensionAppBizData?: string;
  static names(): { [key: string]: string } {
    return {
      autoOpenMode: 'autoOpenMode',
      clientId: 'clientId',
      coolAppCode: 'coolAppCode',
      extensionAppBizData: 'extensionAppBizData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoOpenMode: 'string',
      clientId: 'string',
      coolAppCode: 'string',
      extensionAppBizData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting extends $tea.Model {
  enableChat?: number;
  enableWebAnonymousJoin?: boolean;
  joinBeforeHost?: number;
  lockMediaStatusMicMute?: number;
  lockNick?: number;
  moziConfExtensionAppSettings?: QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings[];
  waitingRoom?: number;
  static names(): { [key: string]: string } {
    return {
      enableChat: 'enableChat',
      enableWebAnonymousJoin: 'enableWebAnonymousJoin',
      joinBeforeHost: 'joinBeforeHost',
      lockMediaStatusMicMute: 'lockMediaStatusMicMute',
      lockNick: 'lockNick',
      moziConfExtensionAppSettings: 'moziConfExtensionAppSettings',
      waitingRoom: 'waitingRoom',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableChat: 'number',
      enableWebAnonymousJoin: 'boolean',
      joinBeforeHost: 'number',
      lockMediaStatusMicMute: 'number',
      lockNick: 'number',
      moziConfExtensionAppSettings: { 'type': 'array', 'itemType': QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings },
      waitingRoom: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScheduleConfSettingsResponseBodyScheduleConfSettingModel extends $tea.Model {
  cohostUnionIds?: string[];
  confAllowedCorpId?: string;
  hostUnionId?: string;
  lockRoom?: number;
  moziConfVirtualExtraSetting?: QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting;
  muteOnJoin?: number;
  screenShareForbidden?: number;
  static names(): { [key: string]: string } {
    return {
      cohostUnionIds: 'cohostUnionIds',
      confAllowedCorpId: 'confAllowedCorpId',
      hostUnionId: 'hostUnionId',
      lockRoom: 'lockRoom',
      moziConfVirtualExtraSetting: 'moziConfVirtualExtraSetting',
      muteOnJoin: 'muteOnJoin',
      screenShareForbidden: 'screenShareForbidden',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cohostUnionIds: { 'type': 'array', 'itemType': 'string' },
      confAllowedCorpId: 'string',
      hostUnionId: 'string',
      lockRoom: 'number',
      moziConfVirtualExtraSetting: QueryScheduleConfSettingsResponseBodyScheduleConfSettingModelMoziConfVirtualExtraSetting,
      muteOnJoin: 'number',
      screenShareForbidden: 'number',
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

export class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends $tea.Model {
  autoOpenMode?: number;
  coolAppCode?: string;
  extensionAppBizData?: string;
  static names(): { [key: string]: string } {
    return {
      autoOpenMode: 'autoOpenMode',
      coolAppCode: 'coolAppCode',
      extensionAppBizData: 'extensionAppBizData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoOpenMode: 'number',
      coolAppCode: 'string',
      extensionAppBizData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting extends $tea.Model {
  enableChat?: number;
  enableWebAnonymousJoin?: boolean;
  joinBeforeHost?: number;
  lockMediaStatusMicMute?: number;
  lockNick?: number;
  moziConfExtensionAppSettings?: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings[];
  waitingRoom?: number;
  static names(): { [key: string]: string } {
    return {
      enableChat: 'enableChat',
      enableWebAnonymousJoin: 'enableWebAnonymousJoin',
      joinBeforeHost: 'joinBeforeHost',
      lockMediaStatusMicMute: 'lockMediaStatusMicMute',
      lockNick: 'lockNick',
      moziConfExtensionAppSettings: 'moziConfExtensionAppSettings',
      waitingRoom: 'waitingRoom',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableChat: 'number',
      enableWebAnonymousJoin: 'boolean',
      joinBeforeHost: 'number',
      lockMediaStatusMicMute: 'number',
      lockNick: 'number',
      moziConfExtensionAppSettings: { 'type': 'array', 'itemType': UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings },
      waitingRoom: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConfSettingsRequestScheduleConfSettingModel extends $tea.Model {
  cohostUnionIds?: string[];
  confAllowedCorpId?: string;
  hostUnionId?: string;
  lockRoom?: number;
  moziConfVirtualExtraSetting?: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting;
  muteOnJoin?: number;
  screenShareForbidden?: number;
  static names(): { [key: string]: string } {
    return {
      cohostUnionIds: 'cohostUnionIds',
      confAllowedCorpId: 'confAllowedCorpId',
      hostUnionId: 'hostUnionId',
      lockRoom: 'lockRoom',
      moziConfVirtualExtraSetting: 'moziConfVirtualExtraSetting',
      muteOnJoin: 'muteOnJoin',
      screenShareForbidden: 'screenShareForbidden',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cohostUnionIds: { 'type': 'array', 'itemType': 'string' },
      confAllowedCorpId: 'string',
      hostUnionId: 'string',
      lockRoom: 'number',
      moziConfVirtualExtraSetting: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting,
      muteOnJoin: 'number',
      screenShareForbidden: 'number',
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


  /**
   * @summary 取消预约会议
   *
   * @param request CancelScheduleConferenceRequest
   * @param headers CancelScheduleConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CancelScheduleConferenceResponse
   */
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

  /**
   * @summary 取消预约会议
   *
   * @param request CancelScheduleConferenceRequest
   * @return CancelScheduleConferenceResponse
   */
  async cancelScheduleConference(request: CancelScheduleConferenceRequest): Promise<CancelScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelScheduleConferenceHeaders({ });
    return await this.cancelScheduleConferenceWithOptions(request, headers, runtime);
  }

  /**
   * @summary 关闭视频会议
   *
   * @param request CloseVideoConferenceRequest
   * @param headers CloseVideoConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CloseVideoConferenceResponse
   */
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

  /**
   * @summary 关闭视频会议
   *
   * @param request CloseVideoConferenceRequest
   * @return CloseVideoConferenceResponse
   */
  async closeVideoConference(conferenceId: string, request: CloseVideoConferenceRequest): Promise<CloseVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseVideoConferenceHeaders({ });
    return await this.closeVideoConferenceWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 设置联席主持人
   *
   * @param request CohostsRequest
   * @param headers CohostsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CohostsResponse
   */
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

  /**
   * @summary 设置联席主持人
   *
   * @param request CohostsRequest
   * @return CohostsResponse
   */
  async cohosts(conferenceId: string, request: CohostsRequest): Promise<CohostsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CohostsHeaders({ });
    return await this.cohostsWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 创建专属短链
   *
   * @param request CreateCustomShortLinkRequest
   * @param headers CreateCustomShortLinkHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateCustomShortLinkResponse
   */
  async createCustomShortLinkWithOptions(request: CreateCustomShortLinkRequest, headers: CreateCustomShortLinkHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomShortLinkResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.extensionAppBizData)) {
      body["extensionAppBizData"] = request.extensionAppBizData;
    }

    if (!Util.isUnset(request.scheduleConferenceId)) {
      body["scheduleConferenceId"] = request.scheduleConferenceId;
    }

    if (!Util.isUnset(request.useExtensionApp)) {
      body["useExtensionApp"] = request.useExtensionApp;
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
      action: "CreateCustomShortLink",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/customShortLinks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCustomShortLinkResponse>(await this.execute(params, req, runtime), new CreateCustomShortLinkResponse({}));
  }

  /**
   * @summary 创建专属短链
   *
   * @param request CreateCustomShortLinkRequest
   * @return CreateCustomShortLinkResponse
   */
  async createCustomShortLink(request: CreateCustomShortLinkRequest): Promise<CreateCustomShortLinkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomShortLinkHeaders({ });
    return await this.createCustomShortLinkWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建预约会议
   *
   * @param request CreateScheduleConferenceRequest
   * @param headers CreateScheduleConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateScheduleConferenceResponse
   */
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

  /**
   * @summary 创建预约会议
   *
   * @param request CreateScheduleConferenceRequest
   * @return CreateScheduleConferenceResponse
   */
  async createScheduleConference(request: CreateScheduleConferenceRequest): Promise<CreateScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateScheduleConferenceHeaders({ });
    return await this.createScheduleConferenceWithOptions(request, headers, runtime);
  }

  /**
   * @summary 创建视频会议
   *
   * @param request CreateVideoConferenceRequest
   * @param headers CreateVideoConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return CreateVideoConferenceResponse
   */
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

  /**
   * @summary 创建视频会议
   *
   * @param request CreateVideoConferenceRequest
   * @return CreateVideoConferenceResponse
   */
  async createVideoConference(request: CreateVideoConferenceRequest): Promise<CreateVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVideoConferenceHeaders({ });
    return await this.createVideoConferenceWithOptions(request, headers, runtime);
  }

  /**
   * @summary 设置全员看他
   *
   * @param request FocusRequest
   * @param headers FocusHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return FocusResponse
   */
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

  /**
   * @summary 设置全员看他
   *
   * @param request FocusRequest
   * @return FocusResponse
   */
  async focus(conferenceId: string, request: FocusRequest): Promise<FocusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FocusHeaders({ });
    return await this.focusWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 通过conferenceId获取指定音视频会议信息
   *
   * @param request GetConfDataByConferenceIdRequest
   * @param headers GetConfDataByConferenceIdHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetConfDataByConferenceIdResponse
   */
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

  /**
   * @summary 通过conferenceId获取指定音视频会议信息
   *
   * @param request GetConfDataByConferenceIdRequest
   * @return GetConfDataByConferenceIdResponse
   */
  async getConfDataByConferenceId(conferenceId: string, request: GetConfDataByConferenceIdRequest): Promise<GetConfDataByConferenceIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfDataByConferenceIdHeaders({ });
    return await this.getConfDataByConferenceIdWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 通过conferenceId获取指定音视频会议成员信息
   *
   * @param request GetConfDetailDataRequest
   * @param headers GetConfDetailDataHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetConfDetailDataResponse
   */
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

  /**
   * @summary 通过conferenceId获取指定音视频会议成员信息
   *
   * @param request GetConfDetailDataRequest
   * @return GetConfDetailDataResponse
   */
  async getConfDetailData(conferenceId: string, request: GetConfDetailDataRequest): Promise<GetConfDetailDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfDetailDataHeaders({ });
    return await this.getConfDetailDataWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 获取音视频会议列表数据
   *
   * @param request GetHistoryConfDataListRequest
   * @param headers GetHistoryConfDataListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetHistoryConfDataListResponse
   */
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

  /**
   * @summary 获取音视频会议列表数据
   *
   * @param request GetHistoryConfDataListRequest
   * @return GetHistoryConfDataListResponse
   */
  async getHistoryConfDataList(request: GetHistoryConfDataListRequest): Promise<GetHistoryConfDataListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetHistoryConfDataListHeaders({ });
    return await this.getHistoryConfDataListWithOptions(request, headers, runtime);
  }

  /**
   * @summary 通过conferenceId和unionId获取最新会议质量数据
   *
   * @param request GetUserLastMetricRequest
   * @param headers GetUserLastMetricHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetUserLastMetricResponse
   */
  async getUserLastMetricWithOptions(conferenceId: string, request: GetUserLastMetricRequest, headers: GetUserLastMetricHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserLastMetricResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionIdList)) {
      body["unionIdList"] = request.unionIdList;
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
      action: "GetUserLastMetric",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/lastMetricDatas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserLastMetricResponse>(await this.execute(params, req, runtime), new GetUserLastMetricResponse({}));
  }

  /**
   * @summary 通过conferenceId和unionId获取最新会议质量数据
   *
   * @param request GetUserLastMetricRequest
   * @return GetUserLastMetricResponse
   */
  async getUserLastMetric(conferenceId: string, request: GetUserLastMetricRequest): Promise<GetUserLastMetricResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserLastMetricHeaders({ });
    return await this.getUserLastMetricWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
   *
   * @param request GetUserMetricDataRequest
   * @param headers GetUserMetricDataHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetUserMetricDataResponse
   */
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

  /**
   * @summary 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
   *
   * @param request GetUserMetricDataRequest
   * @return GetUserMetricDataResponse
   */
  async getUserMetricData(conferenceId: string, request: GetUserMetricDataRequest): Promise<GetUserMetricDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserMetricDataHeaders({ });
    return await this.getUserMetricDataWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 邀请其他人员
   *
   * @param request InviteUsersRequest
   * @param headers InviteUsersHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return InviteUsersResponse
   */
  async inviteUsersWithOptions(conferenceId: string, request: InviteUsersRequest, headers: InviteUsersHeaders, runtime: $Util.RuntimeOptions): Promise<InviteUsersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.inviteeList)) {
      body["inviteeList"] = request.inviteeList;
    }

    if (!Util.isUnset(request.phoneInviteeList)) {
      body["phoneInviteeList"] = request.phoneInviteeList;
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

  /**
   * @summary 邀请其他人员
   *
   * @param request InviteUsersRequest
   * @return InviteUsersResponse
   */
  async inviteUsers(conferenceId: string, request: InviteUsersRequest): Promise<InviteUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InviteUsersHeaders({ });
    return await this.inviteUsersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 会议踢出成员
   *
   * @param request KickMembersRequest
   * @param headers KickMembersHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return KickMembersResponse
   */
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

  /**
   * @summary 会议踢出成员
   *
   * @param request KickMembersRequest
   * @return KickMembersResponse
   */
  async kickMembers(conferenceId: string, request: KickMembersRequest): Promise<KickMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new KickMembersHeaders({ });
    return await this.kickMembersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 锁定会议
   *
   * @param request LockConferenceRequest
   * @param headers LockConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return LockConferenceResponse
   */
  async lockConferenceWithOptions(conferenceId: string, request: LockConferenceRequest, headers: LockConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<LockConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
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
      action: "LockConference",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/lock`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LockConferenceResponse>(await this.execute(params, req, runtime), new LockConferenceResponse({}));
  }

  /**
   * @summary 锁定会议
   *
   * @param request LockConferenceRequest
   * @return LockConferenceResponse
   */
  async lockConference(conferenceId: string, request: LockConferenceRequest): Promise<LockConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LockConferenceHeaders({ });
    return await this.lockConferenceWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 会议全员静音或解除静音
   *
   * @param request MuteAllRequest
   * @param headers MuteAllHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return MuteAllResponse
   */
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

  /**
   * @summary 会议全员静音或解除静音
   *
   * @param request MuteAllRequest
   * @return MuteAllResponse
   */
  async muteAll(conferenceId: string, request: MuteAllRequest): Promise<MuteAllResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MuteAllHeaders({ });
    return await this.muteAllWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 指定人员静音或取消静音
   *
   * @param request MuteMembersRequest
   * @param headers MuteMembersHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return MuteMembersResponse
   */
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

  /**
   * @summary 指定人员静音或取消静音
   *
   * @param request MuteMembersRequest
   * @return MuteMembersResponse
   */
  async muteMembers(conferenceId: string, request: MuteMembersRequest): Promise<MuteMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MuteMembersHeaders({ });
    return await this.muteMembersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 查询云录制文本信息
   *
   * @param request QueryCloudRecordTextRequest
   * @param headers QueryCloudRecordTextHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCloudRecordTextResponse
   */
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
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCloudRecordTextResponse>(await this.execute(params, req, runtime), new QueryCloudRecordTextResponse({}));
  }

  /**
   * @summary 查询云录制文本信息
   *
   * @param request QueryCloudRecordTextRequest
   * @return QueryCloudRecordTextResponse
   */
  async queryCloudRecordText(conferenceId: string, request: QueryCloudRecordTextRequest): Promise<QueryCloudRecordTextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordTextHeaders({ });
    return await this.queryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 查询云录制视频
   *
   * @param request QueryCloudRecordVideoRequest
   * @param headers QueryCloudRecordVideoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCloudRecordVideoResponse
   */
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
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCloudRecordVideoResponse>(await this.execute(params, req, runtime), new QueryCloudRecordVideoResponse({}));
  }

  /**
   * @summary 查询云录制视频
   *
   * @param request QueryCloudRecordVideoRequest
   * @return QueryCloudRecordVideoResponse
   */
  async queryCloudRecordVideo(conferenceId: string, request: QueryCloudRecordVideoRequest): Promise<QueryCloudRecordVideoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoHeaders({ });
    return await this.queryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 查询云录制视频播放信息
   *
   * @param request QueryCloudRecordVideoPlayInfoRequest
   * @param headers QueryCloudRecordVideoPlayInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCloudRecordVideoPlayInfoResponse
   */
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
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCloudRecordVideoPlayInfoResponse>(await this.execute(params, req, runtime), new QueryCloudRecordVideoPlayInfoResponse({}));
  }

  /**
   * @summary 查询云录制视频播放信息
   *
   * @param request QueryCloudRecordVideoPlayInfoRequest
   * @return QueryCloudRecordVideoPlayInfoResponse
   */
  async queryCloudRecordVideoPlayInfo(conferenceId: string, request: QueryCloudRecordVideoPlayInfoRequest): Promise<QueryCloudRecordVideoPlayInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoPlayInfoHeaders({ });
    return await this.queryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 查询视频会议信息
   *
   * @param headers QueryConferenceInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryConferenceInfoResponse
   */
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

  /**
   * @summary 查询视频会议信息
   *
   * @return QueryConferenceInfoResponse
   */
  async queryConferenceInfo(conferenceId: string): Promise<QueryConferenceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoHeaders({ });
    return await this.queryConferenceInfoWithOptions(conferenceId, headers, runtime);
  }

  /**
   * @summary 批量查询视频会议信息
   *
   * @param request QueryConferenceInfoBatchRequest
   * @param headers QueryConferenceInfoBatchHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryConferenceInfoBatchResponse
   */
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

  /**
   * @summary 批量查询视频会议信息
   *
   * @param request QueryConferenceInfoBatchRequest
   * @return QueryConferenceInfoBatchResponse
   */
  async queryConferenceInfoBatch(request: QueryConferenceInfoBatchRequest): Promise<QueryConferenceInfoBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoBatchHeaders({ });
    return await this.queryConferenceInfoBatchWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询视频会议成员
   *
   * @param request QueryConferenceMembersRequest
   * @param headers QueryConferenceMembersHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryConferenceMembersResponse
   */
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

  /**
   * @summary 查询视频会议成员
   *
   * @param request QueryConferenceMembersRequest
   * @return QueryConferenceMembersResponse
   */
  async queryConferenceMembers(conferenceId: string, request: QueryConferenceMembersRequest): Promise<QueryConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceMembersHeaders({ });
    return await this.queryConferenceMembersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 查询预约会议设置
   *
   * @param request QueryScheduleConfSettingsRequest
   * @param headers QueryScheduleConfSettingsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryScheduleConfSettingsResponse
   */
  async queryScheduleConfSettingsWithOptions(request: QueryScheduleConfSettingsRequest, headers: QueryScheduleConfSettingsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryScheduleConfSettingsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scheduleConferenceId)) {
      query["scheduleConferenceId"] = request.scheduleConferenceId;
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
      action: "QueryScheduleConfSettings",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/scheduleConferences/settings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryScheduleConfSettingsResponse>(await this.execute(params, req, runtime), new QueryScheduleConfSettingsResponse({}));
  }

  /**
   * @summary 查询预约会议设置
   *
   * @param request QueryScheduleConfSettingsRequest
   * @return QueryScheduleConfSettingsResponse
   */
  async queryScheduleConfSettings(request: QueryScheduleConfSettingsRequest): Promise<QueryScheduleConfSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConfSettingsHeaders({ });
    return await this.queryScheduleConfSettingsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询预约会议信息
   *
   * @param request QueryScheduleConferenceRequest
   * @param headers QueryScheduleConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryScheduleConferenceResponse
   */
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

  /**
   * @summary 查询预约会议信息
   *
   * @param request QueryScheduleConferenceRequest
   * @return QueryScheduleConferenceResponse
   */
  async queryScheduleConference(scheduleConferenceId: string, request: QueryScheduleConferenceRequest): Promise<QueryScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConferenceHeaders({ });
    return await this.queryScheduleConferenceWithOptions(scheduleConferenceId, request, headers, runtime);
  }

  /**
   * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
   *
   * @param request QueryScheduleConferenceInfoRequest
   * @param headers QueryScheduleConferenceInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryScheduleConferenceInfoResponse
   */
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

  /**
   * @summary 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
   *
   * @param request QueryScheduleConferenceInfoRequest
   * @return QueryScheduleConferenceInfoResponse
   */
  async queryScheduleConferenceInfo(scheduleConferenceId: string, request: QueryScheduleConferenceInfoRequest): Promise<QueryScheduleConferenceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConferenceInfoHeaders({ });
    return await this.queryScheduleConferenceInfoWithOptions(scheduleConferenceId, request, headers, runtime);
  }

  /**
   * @summary 查询用户进行中会议
   *
   * @param request QueryUserOnGoingConferenceRequest
   * @param headers QueryUserOnGoingConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryUserOnGoingConferenceResponse
   */
  async queryUserOnGoingConferenceWithOptions(request: QueryUserOnGoingConferenceRequest, headers: QueryUserOnGoingConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserOnGoingConferenceResponse> {
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

  /**
   * @summary 查询用户进行中会议
   *
   * @param request QueryUserOnGoingConferenceRequest
   * @return QueryUserOnGoingConferenceResponse
   */
  async queryUserOnGoingConference(request: QueryUserOnGoingConferenceRequest): Promise<QueryUserOnGoingConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserOnGoingConferenceHeaders({ });
    return await this.queryUserOnGoingConferenceWithOptions(request, headers, runtime);
  }

  /**
   * @summary 开启云录制
   *
   * @param request StartCloudRecordRequest
   * @param headers StartCloudRecordHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return StartCloudRecordResponse
   */
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

  /**
   * @summary 开启云录制
   *
   * @param request StartCloudRecordRequest
   * @return StartCloudRecordResponse
   */
  async startCloudRecord(conferenceId: string, request: StartCloudRecordRequest): Promise<StartCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCloudRecordHeaders({ });
    return await this.startCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 会议开始直播推流
   *
   * @param request StartStreamOutRequest
   * @param headers StartStreamOutHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return StartStreamOutResponse
   */
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

  /**
   * @summary 会议开始直播推流
   *
   * @param request StartStreamOutRequest
   * @return StartStreamOutResponse
   */
  async startStreamOut(conferenceId: string, request: StartStreamOutRequest): Promise<StartStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartStreamOutHeaders({ });
    return await this.startStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 关闭云录制
   *
   * @param request StopCloudRecordRequest
   * @param headers StopCloudRecordHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return StopCloudRecordResponse
   */
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

  /**
   * @summary 关闭云录制
   *
   * @param request StopCloudRecordRequest
   * @return StopCloudRecordResponse
   */
  async stopCloudRecord(conferenceId: string, request: StopCloudRecordRequest): Promise<StopCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopCloudRecordHeaders({ });
    return await this.stopCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 会议停止直播推流
   *
   * @param request StopStreamOutRequest
   * @param headers StopStreamOutHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return StopStreamOutResponse
   */
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

  /**
   * @summary 会议停止直播推流
   *
   * @param request StopStreamOutRequest
   * @return StopStreamOutResponse
   */
  async stopStreamOut(conferenceId: string, request: StopStreamOutRequest): Promise<StopStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopStreamOutHeaders({ });
    return await this.stopStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * @summary 更新预约会议设置
   *
   * @param request UpdateScheduleConfSettingsRequest
   * @param headers UpdateScheduleConfSettingsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateScheduleConfSettingsResponse
   */
  async updateScheduleConfSettingsWithOptions(request: UpdateScheduleConfSettingsRequest, headers: UpdateScheduleConfSettingsHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateScheduleConfSettingsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.scheduleConfSettingModel)) {
      body["scheduleConfSettingModel"] = request.scheduleConfSettingModel;
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
      action: "UpdateScheduleConfSettings",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/scheduleConferences/settings`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateScheduleConfSettingsResponse>(await this.execute(params, req, runtime), new UpdateScheduleConfSettingsResponse({}));
  }

  /**
   * @summary 更新预约会议设置
   *
   * @param request UpdateScheduleConfSettingsRequest
   * @return UpdateScheduleConfSettingsResponse
   */
  async updateScheduleConfSettings(request: UpdateScheduleConfSettingsRequest): Promise<UpdateScheduleConfSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateScheduleConfSettingsHeaders({ });
    return await this.updateScheduleConfSettingsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新预约会议
   *
   * @param request UpdateScheduleConferenceRequest
   * @param headers UpdateScheduleConferenceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateScheduleConferenceResponse
   */
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

  /**
   * @summary 更新预约会议
   *
   * @param request UpdateScheduleConferenceRequest
   * @return UpdateScheduleConferenceResponse
   */
  async updateScheduleConference(request: UpdateScheduleConferenceRequest): Promise<UpdateScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateScheduleConferenceHeaders({ });
    return await this.updateScheduleConferenceWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新会议额外信息
   *
   * @param headers UpdateVideoConferenceExtInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateVideoConferenceExtInfoResponse
   */
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

  /**
   * @summary 更新会议额外信息
   *
   * @return UpdateVideoConferenceExtInfoResponse
   */
  async updateVideoConferenceExtInfo(conferenceId: string): Promise<UpdateVideoConferenceExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceExtInfoHeaders({ });
    return await this.updateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
  }

  /**
   * @summary 设置会议中的会议属性
   *
   * @param request UpdateVideoConferenceSettingRequest
   * @param headers UpdateVideoConferenceSettingHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateVideoConferenceSettingResponse
   */
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

  /**
   * @summary 设置会议中的会议属性
   *
   * @param request UpdateVideoConferenceSettingRequest
   * @return UpdateVideoConferenceSettingResponse
   */
  async updateVideoConferenceSetting(conferenceId: string, request: UpdateVideoConferenceSettingRequest): Promise<UpdateVideoConferenceSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceSettingHeaders({ });
    return await this.updateVideoConferenceSettingWithOptions(conferenceId, request, headers, runtime);
  }

}
