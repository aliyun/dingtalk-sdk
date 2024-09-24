// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class MetricMapValue extends $tea.Model {
  /**
   * @example
   * 1682562120000
   */
  timestamp?: number;
  /**
   * @example
   * 1145172
   */
  sendBitRate?: string;
  /**
   * @example
   * 111
   */
  recvBitRate?: string;
  /**
   * @example
   * 0
   */
  lostRate?: string;
  /**
   * @example
   * 20
   */
  roundTripTime?: string;
  /**
   * @example
   * 59103
   */
  audioSendBitRate?: string;
  /**
   * @example
   * 52939
   */
  audioRecvBitRate?: string;
  /**
   * @example
   * 25
   */
  audioRecLevel?: string;
  /**
   * @example
   * 27
   */
  audioPlayLevel?: string;
  /**
   * @example
   * 1145172
   */
  cameraSendBitRate?: string;
  /**
   * @example
   * 66160
   */
  cameraRecvBitRate?: string;
  /**
   * @example
   * 1920*1080
   */
  cameraSendResolutionActual?: string;
  /**
   * @example
   * 1920*1080
   */
  cameraRecvResolutionActual?: string;
  /**
   * @example
   * 20
   */
  cameraSendFrame?: string;
  /**
   * @example
   * 15701
   */
  screenSendBitRate?: string;
  /**
   * @example
   * 20
   */
  cameraRecvFrame?: string;
  /**
   * @example
   * 0
   */
  screenRecvBitRate?: string;
  /**
   * @example
   * 1920*1080
   */
  screenSendResolutionActual?: string;
  /**
   * @example
   * 1920*1080
   */
  screenRecvResolutionActual?: string;
  /**
   * @example
   * 14
   */
  screenSendFrame?: string;
  /**
   * @example
   * 0
   */
  screenRecvFrame?: string;
  /**
   * @example
   * 0
   */
  audioJitterMax?: string;
  /**
   * @example
   * 0
   */
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
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  unionId?: string;
  /**
   * @example
   * 654058f2411fe90147e68780
   */
  conferenceId?: string;
  /**
   * @example
   * 测试昵称
   */
  userNick?: string;
  /**
   * @example
   * 1699347295876
   */
  joinTime?: number;
  /**
   * @example
   * 1699347395876
   */
  leaveTime?: number;
  /**
   * @example
   * 100000
   */
  duration?: number;
  /**
   * @example
   * 1：初始化  2：呼叫中  3：活跃（在会）  4：入会失败（拒接等）  5：被踢  6：离会
   */
  attendStatus?: number;
  /**
   * @example
   * true：是  false：否
   */
  host?: boolean;
  /**
   * @example
   * true：是  false：否
   */
  coHost?: boolean;
  /**
   * @example
   * true：是  false：否
   */
  outerOrgMember?: boolean;
  /**
   * @example
   * true：是  false：否
   */
  pstnJoin?: boolean;
  /**
   * @example
   * Win Mac iOS Android
   */
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

export class AddRecordPermissionHeaders extends $tea.Model {
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

export class AddRecordPermissionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cloud_record
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lJcRnm39OsU4jlFFXXXXXXX
   */
  ownerUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lJcRnm39OsU4jlFVmRGXXXXX
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      ownerUnionId: 'ownerUnionId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      ownerUnionId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRecordPermissionResponseBody extends $tea.Model {
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

export class AddRecordPermissionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddRecordPermissionResponseBody;
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
      body: AddRecordPermissionResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qzR1iSMDvzR9iP7Pxxxxxxxxxxxx
   */
  creatorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2a489xxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 27SaQ3iiHLN0uwqcPisedfreNwiEiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * add
   */
  action?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COOLAPP-0-1026633886192127xxxB000W
   */
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  creatorUnionId?: string;
  /**
   * @example
   * bizData
   */
  extensionAppBizData?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f6fb627e-a7e8-403e-b1f8-26e85450f4a9
   */
  scheduleConferenceId?: string;
  /**
   * @example
   * true：使用 false：不使用
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qzR1iSMDvzR9iP7Pxxxxxxxxxxxx
   */
  creatorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1687928400000
   */
  endTime?: number;
  scheduleConfSettingModel?: CreateScheduleConferenceRequestScheduleConfSettingModel;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1687924800000
   */
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 预约会议标题
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      endTime: 'endTime',
      scheduleConfSettingModel: 'scheduleConfSettingModel',
      startTime: 'startTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      endTime: 'number',
      scheduleConfSettingModel: CreateScheduleConferenceRequestScheduleConfSettingModel,
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
  /**
   * @example
   * 838 722 xxxxx
   */
  roomCode?: string;
  /**
   * @example
   * 2a489c68-xxxx-xxxx-xxxx-xxxxxxxxxxxx
   */
  scheduleConferenceId?: string;
  /**
   * @example
   * https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XXX的视频会议
   */
  confTitle?: string;
  /**
   * @example
   * false
   * 
   * **if can be null:**
   * true
   */
  inviteCaller?: boolean;
  /**
   * **if can be null:**
   * true
   */
  inviteUserIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 27SaQ3iiHLN0uwqcPisedfreNwiEiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  action?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 6449d8a6414xxxxxxxx01464af9f0
   */
  conferenceId?: string;
  /**
   * @example
   * njMTqKo9xxxxEiE
   */
  creatorId?: string;
  /**
   * @example
   * 张三
   */
  creatorNick?: string;
  /**
   * @example
   * xxxx
   */
  deptName?: string;
  /**
   * @example
   * 1682561790000
   */
  endTime?: number;
  /**
   * @example
   * 0
   */
  freeType?: string;
  /**
   * @example
   * ding_talk
   */
  scene?: string;
  /**
   * @example
   * 1682561190000
   */
  startTime?: number;
  /**
   * @example
   * 600000
   */
  timeLength?: number;
  /**
   * @example
   * xxxxx测试会议
   */
  title?: string;
  /**
   * @example
   * 2
   */
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
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * xxx9uZ0bVGoqjxxxxxxxx
   */
  nextToken?: string;
  /**
   * @example
   * 张三
   */
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
  /**
   * @example
   * xxxxZ0bVGoqxxBGQbxdxxxx
   */
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
  /**
   * @example
   * 张三
   */
  creatorNike?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1682611199000
   */
  endTime?: number;
  /**
   * @example
   * 0
   */
  freeType?: string;
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * xxx9uZ0bVGoqjxxxxxxxx
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  realData?: boolean;
  /**
   * @example
   * ding_talk
   */
  scene?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1682524800000
   */
  startTime?: number;
  /**
   * @example
   * xxxxx视频会议
   */
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
  /**
   * @example
   * xxx9uZ0bVGoqjxxxxxxxx
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1682524800000
   */
  beginTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1682611199000
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * njMTqKo9iiyxxxxxxxxiEiE
   */
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
  /**
   * @example
   * qzR1iSMDvzR9iPXXXXXXXXXXXXXX
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lock
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * mute
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * mute
   */
  action?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  mediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  regionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 59886
   */
  duration?: number;
  /**
   * @example
   * 1127942
   */
  fileSize?: number;
  /**
   * @example
   * https://vod.mcs.dingtalk.com/faa1566c5bc24f21821ae2394f82db2e/8bbd1612e686462ab4717919f67bb721-b8531e0d534b2f9747a9fdfxxxxxxxxc-sd.mp4
   */
  mp4FileUrl?: string;
  /**
   * @example
   * https://vod.mcs.dingtalk.com/faa1566c5bc24f21821ae2394f82db2e/8bbd1612e686462ab4717919f67bb721-ab85cc044a163568c9485xxxxxxxx76d-sd.m3u8
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
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
  /**
   * @example
   * 123000000
   */
  nextToken?: string;
  /**
   * @example
   * 20
   */
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

export class QueryFlashMinutesSummaryHeaders extends $tea.Model {
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

export class QueryFlashMinutesSummaryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cloud_record
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lJcRnm39OsU4jlFVmRG9KXXXX
   */
  recorderUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      recorderUnionId: 'recorderUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      recorderUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFlashMinutesSummaryResponseBody extends $tea.Model {
  flashMinutesSummary?: QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary;
  static names(): { [key: string]: string } {
    return {
      flashMinutesSummary: 'flashMinutesSummary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flashMinutesSummary: QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFlashMinutesSummaryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryFlashMinutesSummaryResponseBody;
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
      body: QueryFlashMinutesSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesAudioHeaders extends $tea.Model {
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

export class QueryMinutesAudioRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class QueryMinutesAudioResponseBody extends $tea.Model {
  audioList?: QueryMinutesAudioResponseBodyAudioList[];
  static names(): { [key: string]: string } {
    return {
      audioList: 'audioList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      audioList: { 'type': 'array', 'itemType': QueryMinutesAudioResponseBodyAudioList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesAudioResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMinutesAudioResponseBody;
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
      body: QueryMinutesAudioResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryHeaders extends $tea.Model {
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

export class QueryMinutesSummaryRequest extends $tea.Model {
  summaryTypeList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 27SaQ3iiHLN0uwqcPisedfreNwiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      summaryTypeList: 'summaryTypeList',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      summaryTypeList: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponseBody extends $tea.Model {
  summary?: QueryMinutesSummaryResponseBodySummary;
  static names(): { [key: string]: string } {
    return {
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      summary: QueryMinutesSummaryResponseBodySummary,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMinutesSummaryResponseBody;
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
      body: QueryMinutesSummaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesTextHeaders extends $tea.Model {
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

export class QueryMinutesTextRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  direction?: string;
  maxResults?: number;
  nextToken?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      direction: 'direction',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      direction: 'string',
      maxResults: 'number',
      nextToken: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesTextResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * 1631172045153000_7940
   */
  nextToken?: string;
  paragraphList?: QueryMinutesTextResponseBodyParagraphList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      paragraphList: 'paragraphList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      paragraphList: { 'type': 'array', 'itemType': QueryMinutesTextResponseBodyParagraphList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesTextResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMinutesTextResponseBody;
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
      body: QueryMinutesTextResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecordMinutesUrlHeaders extends $tea.Model {
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

export class QueryRecordMinutesUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cloud_record
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lJcRnm39OsU4jlFVmRG9KXXXX
   */
  recorderUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      recorderUnionId: 'recorderUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      recorderUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecordMinutesUrlResponseBody extends $tea.Model {
  recordMinutesUrls?: QueryRecordMinutesUrlResponseBodyRecordMinutesUrls[];
  static names(): { [key: string]: string } {
    return {
      recordMinutesUrls: 'recordMinutesUrls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recordMinutesUrls: { 'type': 'array', 'itemType': QueryRecordMinutesUrlResponseBodyRecordMinutesUrls },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecordMinutesUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRecordMinutesUrlResponseBody;
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
      body: QueryRecordMinutesUrlResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qzR1iSMDvzR9iP7Pxxxxxxxxxxxx
   */
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
  /**
   * @example
   * 1687928400000
   */
  endTime?: number;
  phones?: string[];
  /**
   * @example
   * xxxxx
   */
  requestId?: string;
  /**
   * @example
   * 838 722 xxxxx
   */
  roomCode?: string;
  /**
   * @example
   * 2a489c68-xxxx-xxxx-xxxx-xxxxxxxxxxxx
   */
  scheduleConferenceId?: string;
  /**
   * @example
   * 1687924800000
   */
  startTime?: number;
  /**
   * @example
   * 预约会议标题
   */
  title?: string;
  /**
   * @example
   * https://meeting.dingtalk.com/j/Bsbp3ixxxxxUyJJ9
   */
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
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * 0
   * 
   * **if can be null:**
   * true
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
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
  /**
   * @example
   * 演讲
   */
  mode?: string;
  /**
   * @example
   * 左上
   */
  smallWindowPosition?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 27SaQ3iiHLN0uwqcPisedfreNwiEiE
   */
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

export class StartMinutesHeaders extends $tea.Model {
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

export class StartMinutesRequest extends $tea.Model {
  /**
   * @example
   * 左上
   */
  ownerUnionId?: string;
  /**
   * @example
   * true
   */
  recordAudio?: boolean;
  /**
   * @example
   * 27SaQ3iiHLN0uwqcPisedfreNwiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      ownerUnionId: 'ownerUnionId',
      recordAudio: 'recordAudio',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerUnionId: 'string',
      recordAudio: 'boolean',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartMinutesResponseBody extends $tea.Model {
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

export class StartMinutesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StartMinutesResponseBody;
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
      body: StartMinutesResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * grip
   */
  mode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  needHostJoin?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  smallWindowPosition?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 推流名称
   */
  streamName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  streamUrlList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 27SaQ3iiHLN0uwqcPisedfreNwiEiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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

export class StopMinutesHeaders extends $tea.Model {
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

export class StopMinutesRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class StopMinutesResponseBody extends $tea.Model {
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

export class StopMinutesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: StopMinutesResponseBody;
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
      body: StopMinutesResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  stopAllStream?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 27SaQ3iiHLN0uwqcPisedfreNwiEiE
   */
  streamId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  creatorUnionId?: string;
  scheduleConfSettingModel?: UpdateScheduleConfSettingsRequestScheduleConfSettingModel;
  /**
   * @example
   * f6fb627e-a7e8-403e-b1f8-26e85450f4a9
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qzR1iSMDvzR9iP7Pxxxxxxxxxxxx
   */
  creatorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1687928400000
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2a489xxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx
   */
  scheduleConferenceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1687924800000
   */
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 预约会议标题
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx
   */
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

export class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting extends $tea.Model {
  /**
   * @example
   * true：跟随 false：不跟随
   */
  isFollowHost?: boolean;
  /**
   * @example
   * grid：宫格模式,默认9宫格(3x3) speech：演讲者模式 full_screen：全屏模式 auto_grid：自动宫格模式，默认最大4x4宫格 screen_cast：屏幕共享模式，仅放置屏幕共享流 p2p：双人通话模式 full_screen_and_speaker：共享内容+发言人模式
   */
  mode?: string;
  /**
   * @example
   * 0：不自动开启 1：自动开启
   */
  recordAutoStart?: number;
  /**
   * @example
   * 0：我以主持人身份入会后自动开启 1：其他人以联席主持人身份入会后开启 2：任何人以任何身份入会后开启
   */
  recordAutoStartType?: number;
  static names(): { [key: string]: string } {
    return {
      isFollowHost: 'isFollowHost',
      mode: 'mode',
      recordAutoStart: 'recordAutoStart',
      recordAutoStartType: 'recordAutoStartType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isFollowHost: 'boolean',
      mode: 'string',
      recordAutoStart: 'number',
      recordAutoStartType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends $tea.Model {
  /**
   * @example
   * 0：不自动打开 1：仅主持人/联席主持人自动打开 2：全员自动打开
   */
  autoOpenMode?: number;
  /**
   * @example
   * COOLAPP-0-1026633886192127xxxB000W
   */
  coolAppCode?: string;
  /**
   * @example
   * bizData
   */
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

export class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting extends $tea.Model {
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  cloudRecordOwnerUnionId?: string;
  /**
   * @example
   * 0：未开启 1：开启
   */
  enableChat?: number;
  /**
   * @example
   * true：允许匿名登录入会 false：不允许匿名登录入会
   */
  enableWebAnonymousJoin?: boolean;
  /**
   * @example
   * 0：未开启 1：开启
   */
  joinBeforeHost?: number;
  /**
   * @example
   * 0：未开启 1：开启
   */
  lockMediaStatusMicMute?: number;
  /**
   * @example
   * 0：未开启 1：开启
   */
  lockNick?: number;
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  minutesOwnerUnionId?: string;
  moziConfExtensionAppSettings?: CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings[];
  pushAllMeetingRecords?: boolean;
  pushCloudRecordCard?: boolean;
  pushMinutesCard?: boolean;
  /**
   * @example
   * 0：未开启 1：开启
   */
  waitingRoom?: number;
  static names(): { [key: string]: string } {
    return {
      cloudRecordOwnerUnionId: 'cloudRecordOwnerUnionId',
      enableChat: 'enableChat',
      enableWebAnonymousJoin: 'enableWebAnonymousJoin',
      joinBeforeHost: 'joinBeforeHost',
      lockMediaStatusMicMute: 'lockMediaStatusMicMute',
      lockNick: 'lockNick',
      minutesOwnerUnionId: 'minutesOwnerUnionId',
      moziConfExtensionAppSettings: 'moziConfExtensionAppSettings',
      pushAllMeetingRecords: 'pushAllMeetingRecords',
      pushCloudRecordCard: 'pushCloudRecordCard',
      pushMinutesCard: 'pushMinutesCard',
      waitingRoom: 'waitingRoom',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cloudRecordOwnerUnionId: 'string',
      enableChat: 'number',
      enableWebAnonymousJoin: 'boolean',
      joinBeforeHost: 'number',
      lockMediaStatusMicMute: 'number',
      lockNick: 'number',
      minutesOwnerUnionId: 'string',
      moziConfExtensionAppSettings: { 'type': 'array', 'itemType': CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings },
      pushAllMeetingRecords: 'boolean',
      pushCloudRecordCard: 'boolean',
      pushMinutesCard: 'boolean',
      waitingRoom: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScheduleConferenceRequestScheduleConfSettingModel extends $tea.Model {
  cohostUnionIds?: string[];
  /**
   * @example
   * dingc02f685fa06381c44ac5d6980864d335
   */
  confAllowedCorpId?: string;
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  hostUnionId?: string;
  /**
   * @example
   * 0：取消锁定 1：锁定
   */
  lockRoom?: number;
  moziConfOpenRecordSetting?: CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting;
  moziConfVirtualExtraSetting?: CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting;
  /**
   * @example
   * -1：未开启 1：开启 6：超过6人自动开启静音
   */
  muteOnJoin?: number;
  /**
   * @example
   * 0：允许共享 1：禁止共享
   */
  screenShareForbidden?: number;
  static names(): { [key: string]: string } {
    return {
      cohostUnionIds: 'cohostUnionIds',
      confAllowedCorpId: 'confAllowedCorpId',
      hostUnionId: 'hostUnionId',
      lockRoom: 'lockRoom',
      moziConfOpenRecordSetting: 'moziConfOpenRecordSetting',
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
      moziConfOpenRecordSetting: CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting,
      moziConfVirtualExtraSetting: CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting,
      muteOnJoin: 'number',
      screenShareForbidden: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConfDetailDataResponseBodyList extends $tea.Model {
  /**
   * @example
   * true
   */
  belongOrg?: string;
  /**
   * @example
   * 6449d8a6414xxxxxxxx01464af9f0
   */
  conferenceId?: string;
  /**
   * @example
   * Mac
   */
  deviceType?: string;
  /**
   * @example
   * 974000
   */
  duration?: number;
  /**
   * @example
   * 1682561199000
   */
  joinTime?: number;
  /**
   * @example
   * 1682562173000
   */
  leaveTime?: number;
  /**
   * @example
   * -1
   */
  networkQuality?: string;
  /**
   * @example
   * 张三
   */
  nick?: string;
  /**
   * @example
   * 参会人
   */
  role?: string;
  /**
   * @example
   * xxxx
   */
  sessionId?: string;
  /**
   * @example
   * 已离开
   */
  status?: string;
  /**
   * @example
   * njMTqKo9xxxxEiE
   */
  unionId?: string;
  /**
   * @example
   * 6.1.1
   */
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
  /**
   * @example
   * 6449d8a6414xxxxxxxx01464af9f0
   */
  conferenceId?: string;
  /**
   * @example
   * njMTqKo9xxxxEiE
   */
  creatorId?: string;
  /**
   * @example
   * 张三
   */
  creatorNick?: string;
  /**
   * @example
   * xxxxx
   */
  deptName?: string;
  /**
   * @example
   * 1682561790000
   */
  endTime?: number;
  /**
   * @example
   * 0
   */
  freeType?: string;
  /**
   * @example
   * ding_talk
   */
  scene?: string;
  /**
   * @example
   * 1682561190000
   */
  startTime?: number;
  /**
   * @example
   * 600000
   */
  timeLength?: number;
  /**
   * @example
   * xxxxx视频会议
   */
  title?: string;
  /**
   * @example
   * 2
   */
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
  /**
   * @example
   * 27
   */
  audioPlayLevel?: string;
  /**
   * @example
   * 25
   */
  audioRecLevel?: string;
  /**
   * @example
   * 52939
   */
  audioRecvBitRate?: string;
  /**
   * @example
   * 59103
   */
  audioSendBitRate?: string;
  /**
   * @example
   * 66160
   */
  cameraRecvBitRate?: string;
  /**
   * @example
   * 20
   */
  cameraRecvFrame?: string;
  /**
   * @example
   * 1920*1080
   */
  cameraRecvResolutionActual?: string;
  /**
   * @example
   * 1145172
   */
  cameraSendBitRate?: string;
  /**
   * @example
   * 20
   */
  cameraSendFrame?: string;
  /**
   * @example
   * 1920*1080
   */
  cameraSendResolutionActual?: string;
  /**
   * @example
   * 0
   */
  lostRate?: string;
  /**
   * @example
   * 66160
   */
  recvBitRate?: string;
  /**
   * @example
   * 20
   */
  roundTripTime?: string;
  /**
   * @example
   * 0
   */
  screenRecvBitRate?: string;
  /**
   * @example
   * 0
   */
  screenRecvFrame?: string;
  /**
   * @example
   * 1920*1080
   */
  screenRecvResolutionActual?: string;
  /**
   * @example
   * 15701
   */
  screenSendBitRate?: string;
  /**
   * @example
   * 14
   */
  screenSendFrame?: string;
  /**
   * @example
   * 1920*1080
   */
  screenSendResolutionActual?: string;
  /**
   * @example
   * 1145172
   */
  sendBitRate?: string;
  /**
   * @example
   * 1682562120000
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试用户
   */
  nick?: string;
  /**
   * @example
   * qzR1iSMDvzR9kXXXXXXXx
   */
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
  /**
   * @example
   * false
   */
  inviteClient?: boolean;
  /**
   * @example
   * 测试电话用户
   */
  nick?: string;
  /**
   * @example
   * 1xxxxxxxxxx9
   */
  phoneNumber?: string;
  /**
   * @example
   * 86
   */
  statusCode?: string;
  static names(): { [key: string]: string } {
    return {
      inviteClient: 'inviteClient',
      nick: 'nick',
      phoneNumber: 'phoneNumber',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteClient: 'boolean',
      nick: 'string',
      phoneNumber: 'string',
      statusCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class KickMembersRequestUserList extends $tea.Model {
  /**
   * @example
   * 644272f14ba3311xxxxxxxxx
   */
  participantId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx
   */
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
  /**
   * @example
   * 644272f14ba3311xxxxxxxxx
   */
  participantId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qzR1iSMDvzR9iP7Pxxxxxxxxxxxxxxx
   */
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
  /**
   * @example
   * 7940
   */
  endTime?: number;
  /**
   * @example
   * 7940
   */
  startTime?: number;
  /**
   * @example
   * 这里
   */
  word?: string;
  /**
   * @example
   * 1631172050535000#0
   */
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
  /**
   * @example
   * 7940
   */
  endTime?: number;
  /**
   * @example
   * 这里是小钉
   */
  sentence?: string;
  /**
   * @example
   * 7940
   */
  startTime?: number;
  /**
   * @example
   * WFBkgJvt0xxxxSaA1jK4sgiEiE
   */
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
  /**
   * @example
   * 7940
   */
  endTime?: number;
  /**
   * @example
   * 1631172045153000
   */
  nextTtoken?: number;
  /**
   * @example
   * 小钉
   */
  nickName?: string;
  /**
   * @example
   * 嘿！你好，这里是小钉
   */
  paragraph?: string;
  /**
   * @example
   * 44444
   */
  recordId?: number;
  sentenceList?: QueryCloudRecordTextResponseBodyParagraphListSentenceList[];
  /**
   * @example
   * 7940
   */
  startTime?: number;
  /**
   * @example
   * 1
   */
  status?: number;
  /**
   * @example
   * WFBkgJvt0xxxxSaA1jK4sgiEiE
   */
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
  /**
   * @example
   * 59886
   */
  duration?: number;
  /**
   * @example
   * 1631172094000
   */
  endTime?: number;
  /**
   * @example
   * 1127942
   */
  fileSize?: number;
  /**
   * @example
   * faa1566c5bc24f21821ae2394f82db2e
   */
  mediaId?: string;
  /**
   * @example
   * 290882268xxx1172033231
   */
  recordId?: string;
  /**
   * @example
   * 0
   */
  recordType?: number;
  /**
   * @example
   * cn-shenzhen
   */
  regionId?: string;
  /**
   * @example
   * 1631172094000
   */
  startTime?: number;
  /**
   * @example
   * WFBkgJvtxxxxtSaA1jK4sgiEiE
   */
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

export class QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings extends $tea.Model {
  appCode?: string;
  appId?: string;
  autoOpenMode?: number;
  extensionAppBizData?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      appId: 'appId',
      autoOpenMode: 'autoOpenMode',
      extensionAppBizData: 'extensionAppBizData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      appId: 'string',
      autoOpenMode: 'number',
      extensionAppBizData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoResponseBodyConfInfo extends $tea.Model {
  /**
   * @example
   * 10
   */
  activeNum?: number;
  /**
   * @example
   * 15
   */
  attendNum?: number;
  bizType?: string;
  cloudRecordOwnerUnionId?: string;
  cloudRecordStatus?: number;
  /**
   * @example
   * 1000000
   */
  confDuration?: number;
  /**
   * @example
   * 6323d7568777190142ab9d10
   */
  conferenceId?: string;
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  creatorId?: string;
  /**
   * @example
   * 昵称
   */
  creatorNick?: string;
  endTime?: number;
  extensionAppSettings?: QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings[];
  /**
   * @example
   * https://meeting.dingtalk.com/app?roomCode=42726033559&token=1_7ac974ac-6e4f-47c3-b82b-bfb32fd94d2c
   */
  externalLinkUrl?: string;
  /**
   * @example
   * 20
   */
  invitedNum?: number;
  minutesOwnerUnionId?: string;
  minutesStatus?: number;
  /**
   * @example
   * 42726033559
   */
  roomCode?: string;
  scheduleConferenceId?: string;
  /**
   * @example
   * 1663293270000
   */
  startTime?: number;
  /**
   * @example
   * 1
   */
  status?: number;
  /**
   * @example
   * 标题
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      activeNum: 'activeNum',
      attendNum: 'attendNum',
      bizType: 'bizType',
      cloudRecordOwnerUnionId: 'cloudRecordOwnerUnionId',
      cloudRecordStatus: 'cloudRecordStatus',
      confDuration: 'confDuration',
      conferenceId: 'conferenceId',
      creatorId: 'creatorId',
      creatorNick: 'creatorNick',
      endTime: 'endTime',
      extensionAppSettings: 'extensionAppSettings',
      externalLinkUrl: 'externalLinkUrl',
      invitedNum: 'invitedNum',
      minutesOwnerUnionId: 'minutesOwnerUnionId',
      minutesStatus: 'minutesStatus',
      roomCode: 'roomCode',
      scheduleConferenceId: 'scheduleConferenceId',
      startTime: 'startTime',
      status: 'status',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeNum: 'number',
      attendNum: 'number',
      bizType: 'string',
      cloudRecordOwnerUnionId: 'string',
      cloudRecordStatus: 'number',
      confDuration: 'number',
      conferenceId: 'string',
      creatorId: 'string',
      creatorNick: 'string',
      endTime: 'number',
      extensionAppSettings: { 'type': 'array', 'itemType': QueryConferenceInfoResponseBodyConfInfoExtensionAppSettings },
      externalLinkUrl: 'string',
      invitedNum: 'number',
      minutesOwnerUnionId: 'string',
      minutesStatus: 'number',
      roomCode: 'string',
      scheduleConferenceId: 'string',
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
  /**
   * @example
   * 0-未定义,1-初始化,2-加入中,3-在会,4-加入失败,5,被踢出,6-离开
   */
  attendStatus?: number;
  /**
   * @example
   * 0-初始化，1-关闭，2-打开
   */
  cameraStatus?: number;
  /**
   * @example
   * 0-初始化，1-关闭，2-打开
   */
  micStatus?: number;
  nick?: string;
  /**
   * @example
   * 抱歉，正在开会
   */
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
  /**
   * @example
   * 0-正常，1-麦克风静音，2-摄像头关闭，4-强制全员静音
   */
  mediaStatus?: number;
  startTime?: number;
  /**
   * @example
   * 0-初始化，1-会议结束，2-会议开始
   */
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
  /**
   * @example
   * 6
   */
  attendStatus?: number;
  coHost?: boolean;
  /**
   * @example
   * 6323d7562b18000142ab9d10
   */
  conferenceId?: string;
  duration?: number;
  host?: boolean;
  joinTime?: number;
  leaveTime?: number;
  outerOrgMember?: boolean;
  pstnJoin?: boolean;
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  unionId?: string;
  /**
   * @example
   * 昵称
   */
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

export class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary extends $tea.Model {
  end?: number;
  headline?: string;
  id?: number;
  start?: number;
  summary?: string;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      headline: 'headline',
      id: 'id',
      start: 'start',
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: 'number',
      headline: 'string',
      id: 'number',
      start: 'number',
      summary: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFlashMinutesSummaryResponseBodyFlashMinutesSummary extends $tea.Model {
  status?: number;
  summary?: QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary[];
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
      summary: { 'type': 'array', 'itemType': QueryFlashMinutesSummaryResponseBodyFlashMinutesSummarySummary },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesAudioResponseBodyAudioList extends $tea.Model {
  /**
   * @example
   * 59886
   */
  duration?: number;
  /**
   * @example
   * 1631172094000
   */
  endTime?: number;
  /**
   * @example
   * 1127942
   */
  fileSize?: number;
  /**
   * @example
   * https://xxx-hangzhou.oss-cn-hangzhou.aliyuncs.com/record_xxxx.mp3?Expires=1718045081&OSSAccessKeyId=TMP.3KdwHtvZxopmwacMZEdyb4WHLVmbArrNRB9CTKnR1MaJgmRjdmZczs6Rip66cgKgk2HhQon1yygvBnbY3uqEaZNeHBLcBa&Signature=OFWyAIY%2FdlzfwM9wIfEaKoAudkxxxxx
   */
  playUrl?: string;
  /**
   * @example
   * 290882268xxx1172033231
   */
  recordId?: string;
  /**
   * @example
   * 1631172094000
   */
  startTime?: number;
  /**
   * @example
   * WFBkgJvtxxxxtSaA1jK4sgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      endTime: 'endTime',
      fileSize: 'fileSize',
      playUrl: 'playUrl',
      recordId: 'recordId',
      startTime: 'startTime',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      endTime: 'number',
      fileSize: 'number',
      playUrl: 'string',
      recordId: 'string',
      startTime: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponseBodySummaryActions extends $tea.Model {
  end?: number;
  id?: number;
  sentenceId?: number;
  start?: number;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      id: 'id',
      sentenceId: 'sentenceId',
      start: 'start',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: 'number',
      id: 'number',
      sentenceId: 'number',
      start: 'number',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponseBodySummaryAutoChapters extends $tea.Model {
  end?: number;
  headline?: string;
  id?: number;
  start?: number;
  summary?: string;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      headline: 'headline',
      id: 'id',
      start: 'start',
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: 'number',
      headline: 'string',
      id: 'number',
      start: 'number',
      summary: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponseBodySummaryConversationalSummary extends $tea.Model {
  speakerId?: string;
  speakerName?: string;
  summary?: string;
  static names(): { [key: string]: string } {
    return {
      speakerId: 'speakerId',
      speakerName: 'speakerName',
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      speakerId: 'string',
      speakerName: 'string',
      summary: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponseBodySummaryKeySentences extends $tea.Model {
  end?: number;
  id?: number;
  sentenceId?: number;
  start?: number;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      end: 'end',
      id: 'id',
      sentenceId: 'sentenceId',
      start: 'start',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      end: 'number',
      id: 'number',
      sentenceId: 'number',
      start: 'number',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary extends $tea.Model {
  answer?: string;
  question?: string;
  sentenceIdsOfAnswer?: number[];
  sentenceIdsOfQuestion?: number[];
  static names(): { [key: string]: string } {
    return {
      answer: 'answer',
      question: 'question',
      sentenceIdsOfAnswer: 'sentenceIdsOfAnswer',
      sentenceIdsOfQuestion: 'sentenceIdsOfQuestion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      answer: 'string',
      question: 'string',
      sentenceIdsOfAnswer: { 'type': 'array', 'itemType': 'number' },
      sentenceIdsOfQuestion: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesSummaryResponseBodySummary extends $tea.Model {
  actions?: QueryMinutesSummaryResponseBodySummaryActions[];
  autoChapters?: QueryMinutesSummaryResponseBodySummaryAutoChapters[];
  conversationalSummary?: QueryMinutesSummaryResponseBodySummaryConversationalSummary[];
  keySentences?: QueryMinutesSummaryResponseBodySummaryKeySentences[];
  keywords?: string[];
  paragraphSummary?: string;
  questionsAnsweringSummary?: QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary[];
  static names(): { [key: string]: string } {
    return {
      actions: 'actions',
      autoChapters: 'autoChapters',
      conversationalSummary: 'conversationalSummary',
      keySentences: 'keySentences',
      keywords: 'keywords',
      paragraphSummary: 'paragraphSummary',
      questionsAnsweringSummary: 'questionsAnsweringSummary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actions: { 'type': 'array', 'itemType': QueryMinutesSummaryResponseBodySummaryActions },
      autoChapters: { 'type': 'array', 'itemType': QueryMinutesSummaryResponseBodySummaryAutoChapters },
      conversationalSummary: { 'type': 'array', 'itemType': QueryMinutesSummaryResponseBodySummaryConversationalSummary },
      keySentences: { 'type': 'array', 'itemType': QueryMinutesSummaryResponseBodySummaryKeySentences },
      keywords: { 'type': 'array', 'itemType': 'string' },
      paragraphSummary: 'string',
      questionsAnsweringSummary: { 'type': 'array', 'itemType': QueryMinutesSummaryResponseBodySummaryQuestionsAnsweringSummary },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesTextResponseBodyParagraphListSentenceListWordList extends $tea.Model {
  /**
   * @example
   * 7940
   */
  endTime?: number;
  /**
   * @example
   * 7940
   */
  startTime?: number;
  /**
   * @example
   * 这里
   */
  word?: string;
  /**
   * @example
   * 1631172050535000#0
   */
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

export class QueryMinutesTextResponseBodyParagraphListSentenceList extends $tea.Model {
  /**
   * @example
   * 7940
   */
  endTime?: number;
  /**
   * @example
   * 这里是小钉
   */
  sentence?: string;
  /**
   * @example
   * 7940
   */
  startTime?: number;
  /**
   * @example
   * WFBkgJvt0xxxxSaA1jK4sgiEiE
   */
  unionId?: string;
  wordList?: QueryMinutesTextResponseBodyParagraphListSentenceListWordList[];
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
      wordList: { 'type': 'array', 'itemType': QueryMinutesTextResponseBodyParagraphListSentenceListWordList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMinutesTextResponseBodyParagraphList extends $tea.Model {
  /**
   * @example
   * 7940
   */
  endTime?: number;
  /**
   * @example
   * 小钉
   */
  nickName?: string;
  /**
   * @example
   * 嘿！你好，这里是小钉
   */
  paragraph?: string;
  paragraphId?: number;
  /**
   * @example
   * 44444
   */
  recordId?: number;
  sentenceList?: QueryMinutesTextResponseBodyParagraphListSentenceList[];
  /**
   * @example
   * 7940
   */
  startTime?: number;
  /**
   * @example
   * WFBkgJvt0xxxxSaA1jK4sgiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      nickName: 'nickName',
      paragraph: 'paragraph',
      paragraphId: 'paragraphId',
      recordId: 'recordId',
      sentenceList: 'sentenceList',
      startTime: 'startTime',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      nickName: 'string',
      paragraph: 'string',
      paragraphId: 'number',
      recordId: 'number',
      sentenceList: { 'type': 'array', 'itemType': QueryMinutesTextResponseBodyParagraphListSentenceList },
      startTime: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecordMinutesUrlResponseBodyRecordMinutesUrls extends $tea.Model {
  recordMinutesUrl?: string;
  static names(): { [key: string]: string } {
    return {
      recordMinutesUrl: 'recordMinutesUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      recordMinutesUrl: 'string',
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

export class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting extends $tea.Model {
  /**
   * @example
   * true：跟随 false：不跟随
   */
  isFollowHost?: boolean;
  /**
   * @example
   * grid：宫格模式,默认9宫格(3x3) speech：演讲者模式 full_screen：全屏模式 auto_grid：自动宫格模式，默认最大4x4宫格 screen_cast：屏幕共享模式，仅放置屏幕共享流 p2p：双人通话模式 full_screen_and_speaker：共享内容+发言人模式
   */
  mode?: string;
  /**
   * @example
   * 0：不自动开启 1：自动开启
   */
  recordAutoStart?: number;
  /**
   * @example
   * 0：我以主持人身份入会后自动开启 1：其他人以联席主持人身份入会后开启 2：任何人以任何身份入会后开启
   */
  recordAutoStartType?: number;
  static names(): { [key: string]: string } {
    return {
      isFollowHost: 'isFollowHost',
      mode: 'mode',
      recordAutoStart: 'recordAutoStart',
      recordAutoStartType: 'recordAutoStartType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isFollowHost: 'boolean',
      mode: 'string',
      recordAutoStart: 'number',
      recordAutoStartType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings extends $tea.Model {
  /**
   * @example
   * 0：不自动打开 1：仅主持人/联席主持人自动打开 2：全员自动打开
   */
  autoOpenMode?: number;
  /**
   * @example
   * COOLAPP-0-1026633886192127xxxB000W
   */
  coolAppCode?: string;
  /**
   * @example
   * bizData
   */
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
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  cloudRecordOwnerUnionId?: string;
  /**
   * @example
   * 0：未开启 1：开启
   */
  enableChat?: number;
  /**
   * @example
   * true：允许匿名登录入会 false：不允许匿名登录入会
   */
  enableWebAnonymousJoin?: boolean;
  /**
   * @example
   * 0：未开启 1：开启
   */
  joinBeforeHost?: number;
  /**
   * @example
   * 0：未开启 1：开启
   */
  lockMediaStatusMicMute?: number;
  /**
   * @example
   * 0：未开启 1：开启
   */
  lockNick?: number;
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  minutesOwnerUnionId?: string;
  moziConfExtensionAppSettings?: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings[];
  pushAllMeetingRecords?: boolean;
  pushCloudRecordCard?: boolean;
  pushMinutesCard?: boolean;
  /**
   * @example
   * 0：未开启 1：开启
   */
  waitingRoom?: number;
  static names(): { [key: string]: string } {
    return {
      cloudRecordOwnerUnionId: 'cloudRecordOwnerUnionId',
      enableChat: 'enableChat',
      enableWebAnonymousJoin: 'enableWebAnonymousJoin',
      joinBeforeHost: 'joinBeforeHost',
      lockMediaStatusMicMute: 'lockMediaStatusMicMute',
      lockNick: 'lockNick',
      minutesOwnerUnionId: 'minutesOwnerUnionId',
      moziConfExtensionAppSettings: 'moziConfExtensionAppSettings',
      pushAllMeetingRecords: 'pushAllMeetingRecords',
      pushCloudRecordCard: 'pushCloudRecordCard',
      pushMinutesCard: 'pushMinutesCard',
      waitingRoom: 'waitingRoom',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cloudRecordOwnerUnionId: 'string',
      enableChat: 'number',
      enableWebAnonymousJoin: 'boolean',
      joinBeforeHost: 'number',
      lockMediaStatusMicMute: 'number',
      lockNick: 'number',
      minutesOwnerUnionId: 'string',
      moziConfExtensionAppSettings: { 'type': 'array', 'itemType': UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings },
      pushAllMeetingRecords: 'boolean',
      pushCloudRecordCard: 'boolean',
      pushMinutesCard: 'boolean',
      waitingRoom: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateScheduleConfSettingsRequestScheduleConfSettingModel extends $tea.Model {
  cohostUnionIds?: string[];
  /**
   * @example
   * dingc02f685fa06381c44ac5d6980864d335
   */
  confAllowedCorpId?: string;
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  hostUnionId?: string;
  /**
   * @example
   * 0：取消锁定 1：锁定
   */
  lockRoom?: number;
  moziConfOpenRecordSetting?: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting;
  moziConfVirtualExtraSetting?: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting;
  /**
   * @example
   * -1：未开启 1：开启 6：超过6人自动开启静音
   */
  muteOnJoin?: number;
  /**
   * @example
   * 0：允许共享 1：禁止共享
   */
  screenShareForbidden?: number;
  static names(): { [key: string]: string } {
    return {
      cohostUnionIds: 'cohostUnionIds',
      confAllowedCorpId: 'confAllowedCorpId',
      hostUnionId: 'hostUnionId',
      lockRoom: 'lockRoom',
      moziConfOpenRecordSetting: 'moziConfOpenRecordSetting',
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
      moziConfOpenRecordSetting: UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfOpenRecordSetting,
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
   * 增加闪记权限
   * 
   * @param request - AddRecordPermissionRequest
   * @param headers - AddRecordPermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddRecordPermissionResponse
   */
  async addRecordPermissionWithOptions(conferenceId: string, request: AddRecordPermissionRequest, headers: AddRecordPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<AddRecordPermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.ownerUnionId)) {
      body["ownerUnionId"] = request.ownerUnionId;
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
      action: "AddRecordPermission",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/flashMinutes/recordPermissions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddRecordPermissionResponse>(await this.execute(params, req, runtime), new AddRecordPermissionResponse({}));
  }

  /**
   * 增加闪记权限
   * 
   * @param request - AddRecordPermissionRequest
   * @returns AddRecordPermissionResponse
   */
  async addRecordPermission(conferenceId: string, request: AddRecordPermissionRequest): Promise<AddRecordPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRecordPermissionHeaders({ });
    return await this.addRecordPermissionWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 取消预约会议
   * 
   * @param request - CancelScheduleConferenceRequest
   * @param headers - CancelScheduleConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CancelScheduleConferenceResponse
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
   * 取消预约会议
   * 
   * @param request - CancelScheduleConferenceRequest
   * @returns CancelScheduleConferenceResponse
   */
  async cancelScheduleConference(request: CancelScheduleConferenceRequest): Promise<CancelScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelScheduleConferenceHeaders({ });
    return await this.cancelScheduleConferenceWithOptions(request, headers, runtime);
  }

  /**
   * 关闭视频会议
   * 
   * @param request - CloseVideoConferenceRequest
   * @param headers - CloseVideoConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CloseVideoConferenceResponse
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
   * 关闭视频会议
   * 
   * @param request - CloseVideoConferenceRequest
   * @returns CloseVideoConferenceResponse
   */
  async closeVideoConference(conferenceId: string, request: CloseVideoConferenceRequest): Promise<CloseVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseVideoConferenceHeaders({ });
    return await this.closeVideoConferenceWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 设置联席主持人
   * 
   * @param request - CohostsRequest
   * @param headers - CohostsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CohostsResponse
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
   * 设置联席主持人
   * 
   * @param request - CohostsRequest
   * @returns CohostsResponse
   */
  async cohosts(conferenceId: string, request: CohostsRequest): Promise<CohostsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CohostsHeaders({ });
    return await this.cohostsWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 创建专属短链
   * 
   * @param request - CreateCustomShortLinkRequest
   * @param headers - CreateCustomShortLinkHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateCustomShortLinkResponse
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
   * 创建专属短链
   * 
   * @param request - CreateCustomShortLinkRequest
   * @returns CreateCustomShortLinkResponse
   */
  async createCustomShortLink(request: CreateCustomShortLinkRequest): Promise<CreateCustomShortLinkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomShortLinkHeaders({ });
    return await this.createCustomShortLinkWithOptions(request, headers, runtime);
  }

  /**
   * 创建预约会议
   * 
   * @param request - CreateScheduleConferenceRequest
   * @param headers - CreateScheduleConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateScheduleConferenceResponse
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

    if (!Util.isUnset(request.scheduleConfSettingModel)) {
      body["scheduleConfSettingModel"] = request.scheduleConfSettingModel;
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
   * 创建预约会议
   * 
   * @param request - CreateScheduleConferenceRequest
   * @returns CreateScheduleConferenceResponse
   */
  async createScheduleConference(request: CreateScheduleConferenceRequest): Promise<CreateScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateScheduleConferenceHeaders({ });
    return await this.createScheduleConferenceWithOptions(request, headers, runtime);
  }

  /**
   * 创建视频会议
   * 
   * @param request - CreateVideoConferenceRequest
   * @param headers - CreateVideoConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateVideoConferenceResponse
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
   * 创建视频会议
   * 
   * @param request - CreateVideoConferenceRequest
   * @returns CreateVideoConferenceResponse
   */
  async createVideoConference(request: CreateVideoConferenceRequest): Promise<CreateVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVideoConferenceHeaders({ });
    return await this.createVideoConferenceWithOptions(request, headers, runtime);
  }

  /**
   * 设置全员看他
   * 
   * @param request - FocusRequest
   * @param headers - FocusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FocusResponse
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
   * 设置全员看他
   * 
   * @param request - FocusRequest
   * @returns FocusResponse
   */
  async focus(conferenceId: string, request: FocusRequest): Promise<FocusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FocusHeaders({ });
    return await this.focusWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 通过conferenceId获取指定音视频会议信息
   * 
   * @param request - GetConfDataByConferenceIdRequest
   * @param headers - GetConfDataByConferenceIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConfDataByConferenceIdResponse
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
   * 通过conferenceId获取指定音视频会议信息
   * 
   * @param request - GetConfDataByConferenceIdRequest
   * @returns GetConfDataByConferenceIdResponse
   */
  async getConfDataByConferenceId(conferenceId: string, request: GetConfDataByConferenceIdRequest): Promise<GetConfDataByConferenceIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfDataByConferenceIdHeaders({ });
    return await this.getConfDataByConferenceIdWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 通过conferenceId获取指定音视频会议成员信息
   * 
   * @param request - GetConfDetailDataRequest
   * @param headers - GetConfDetailDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConfDetailDataResponse
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
   * 通过conferenceId获取指定音视频会议成员信息
   * 
   * @param request - GetConfDetailDataRequest
   * @returns GetConfDetailDataResponse
   */
  async getConfDetailData(conferenceId: string, request: GetConfDetailDataRequest): Promise<GetConfDetailDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConfDetailDataHeaders({ });
    return await this.getConfDetailDataWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 获取音视频会议列表数据
   * 
   * @param request - GetHistoryConfDataListRequest
   * @param headers - GetHistoryConfDataListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetHistoryConfDataListResponse
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
   * 获取音视频会议列表数据
   * 
   * @param request - GetHistoryConfDataListRequest
   * @returns GetHistoryConfDataListResponse
   */
  async getHistoryConfDataList(request: GetHistoryConfDataListRequest): Promise<GetHistoryConfDataListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetHistoryConfDataListHeaders({ });
    return await this.getHistoryConfDataListWithOptions(request, headers, runtime);
  }

  /**
   * 通过conferenceId和unionId获取最新会议质量数据
   * 
   * @param request - GetUserLastMetricRequest
   * @param headers - GetUserLastMetricHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserLastMetricResponse
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
   * 通过conferenceId和unionId获取最新会议质量数据
   * 
   * @param request - GetUserLastMetricRequest
   * @returns GetUserLastMetricResponse
   */
  async getUserLastMetric(conferenceId: string, request: GetUserLastMetricRequest): Promise<GetUserLastMetricResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserLastMetricHeaders({ });
    return await this.getUserLastMetricWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
   * 
   * @param request - GetUserMetricDataRequest
   * @param headers - GetUserMetricDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserMetricDataResponse
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
   * 通过conferenceId和unionId获取指定音视频会议人员的会议质量数据
   * 
   * @param request - GetUserMetricDataRequest
   * @returns GetUserMetricDataResponse
   */
  async getUserMetricData(conferenceId: string, request: GetUserMetricDataRequest): Promise<GetUserMetricDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserMetricDataHeaders({ });
    return await this.getUserMetricDataWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 邀请其他人员
   * 
   * @param request - InviteUsersRequest
   * @param headers - InviteUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InviteUsersResponse
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
   * 邀请其他人员
   * 
   * @param request - InviteUsersRequest
   * @returns InviteUsersResponse
   */
  async inviteUsers(conferenceId: string, request: InviteUsersRequest): Promise<InviteUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InviteUsersHeaders({ });
    return await this.inviteUsersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 会议踢出成员
   * 
   * @param request - KickMembersRequest
   * @param headers - KickMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns KickMembersResponse
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
   * 会议踢出成员
   * 
   * @param request - KickMembersRequest
   * @returns KickMembersResponse
   */
  async kickMembers(conferenceId: string, request: KickMembersRequest): Promise<KickMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new KickMembersHeaders({ });
    return await this.kickMembersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 锁定会议
   * 
   * @param request - LockConferenceRequest
   * @param headers - LockConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LockConferenceResponse
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
   * 锁定会议
   * 
   * @param request - LockConferenceRequest
   * @returns LockConferenceResponse
   */
  async lockConference(conferenceId: string, request: LockConferenceRequest): Promise<LockConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LockConferenceHeaders({ });
    return await this.lockConferenceWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 会议全员静音或解除静音
   * 
   * @param request - MuteAllRequest
   * @param headers - MuteAllHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MuteAllResponse
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
   * 会议全员静音或解除静音
   * 
   * @param request - MuteAllRequest
   * @returns MuteAllResponse
   */
  async muteAll(conferenceId: string, request: MuteAllRequest): Promise<MuteAllResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MuteAllHeaders({ });
    return await this.muteAllWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 指定人员静音或取消静音
   * 
   * @param request - MuteMembersRequest
   * @param headers - MuteMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MuteMembersResponse
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
   * 指定人员静音或取消静音
   * 
   * @param request - MuteMembersRequest
   * @returns MuteMembersResponse
   */
  async muteMembers(conferenceId: string, request: MuteMembersRequest): Promise<MuteMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MuteMembersHeaders({ });
    return await this.muteMembersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询云录制文本信息
   * 
   * @param request - QueryCloudRecordTextRequest
   * @param headers - QueryCloudRecordTextHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCloudRecordTextResponse
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
   * 查询云录制文本信息
   * 
   * @param request - QueryCloudRecordTextRequest
   * @returns QueryCloudRecordTextResponse
   */
  async queryCloudRecordText(conferenceId: string, request: QueryCloudRecordTextRequest): Promise<QueryCloudRecordTextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordTextHeaders({ });
    return await this.queryCloudRecordTextWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询云录制视频
   * 
   * @param request - QueryCloudRecordVideoRequest
   * @param headers - QueryCloudRecordVideoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCloudRecordVideoResponse
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
   * 查询云录制视频
   * 
   * @param request - QueryCloudRecordVideoRequest
   * @returns QueryCloudRecordVideoResponse
   */
  async queryCloudRecordVideo(conferenceId: string, request: QueryCloudRecordVideoRequest): Promise<QueryCloudRecordVideoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoHeaders({ });
    return await this.queryCloudRecordVideoWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询云录制视频播放信息
   * 
   * @param request - QueryCloudRecordVideoPlayInfoRequest
   * @param headers - QueryCloudRecordVideoPlayInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCloudRecordVideoPlayInfoResponse
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
   * 查询云录制视频播放信息
   * 
   * @param request - QueryCloudRecordVideoPlayInfoRequest
   * @returns QueryCloudRecordVideoPlayInfoResponse
   */
  async queryCloudRecordVideoPlayInfo(conferenceId: string, request: QueryCloudRecordVideoPlayInfoRequest): Promise<QueryCloudRecordVideoPlayInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCloudRecordVideoPlayInfoHeaders({ });
    return await this.queryCloudRecordVideoPlayInfoWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询视频会议信息
   * 
   * @param headers - QueryConferenceInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryConferenceInfoResponse
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
   * 查询视频会议信息
   * @returns QueryConferenceInfoResponse
   */
  async queryConferenceInfo(conferenceId: string): Promise<QueryConferenceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoHeaders({ });
    return await this.queryConferenceInfoWithOptions(conferenceId, headers, runtime);
  }

  /**
   * 批量查询视频会议信息
   * 
   * @param request - QueryConferenceInfoBatchRequest
   * @param headers - QueryConferenceInfoBatchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryConferenceInfoBatchResponse
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
   * 批量查询视频会议信息
   * 
   * @param request - QueryConferenceInfoBatchRequest
   * @returns QueryConferenceInfoBatchResponse
   */
  async queryConferenceInfoBatch(request: QueryConferenceInfoBatchRequest): Promise<QueryConferenceInfoBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoBatchHeaders({ });
    return await this.queryConferenceInfoBatchWithOptions(request, headers, runtime);
  }

  /**
   * 查询视频会议成员
   * 
   * @param request - QueryConferenceMembersRequest
   * @param headers - QueryConferenceMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryConferenceMembersResponse
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
   * 查询视频会议成员
   * 
   * @param request - QueryConferenceMembersRequest
   * @returns QueryConferenceMembersResponse
   */
  async queryConferenceMembers(conferenceId: string, request: QueryConferenceMembersRequest): Promise<QueryConferenceMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceMembersHeaders({ });
    return await this.queryConferenceMembersWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询云录制摘要请求
   * 
   * @param request - QueryFlashMinutesSummaryRequest
   * @param headers - QueryFlashMinutesSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryFlashMinutesSummaryResponse
   */
  async queryFlashMinutesSummaryWithOptions(conferenceId: string, request: QueryFlashMinutesSummaryRequest, headers: QueryFlashMinutesSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFlashMinutesSummaryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.recorderUnionId)) {
      query["recorderUnionId"] = request.recorderUnionId;
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
      action: "QueryFlashMinutesSummary",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/flashMinutes/summaries`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryFlashMinutesSummaryResponse>(await this.execute(params, req, runtime), new QueryFlashMinutesSummaryResponse({}));
  }

  /**
   * 查询云录制摘要请求
   * 
   * @param request - QueryFlashMinutesSummaryRequest
   * @returns QueryFlashMinutesSummaryResponse
   */
  async queryFlashMinutesSummary(conferenceId: string, request: QueryFlashMinutesSummaryRequest): Promise<QueryFlashMinutesSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFlashMinutesSummaryHeaders({ });
    return await this.queryFlashMinutesSummaryWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询会议闪记的音频信息
   * 
   * @param request - QueryMinutesAudioRequest
   * @param headers - QueryMinutesAudioHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMinutesAudioResponse
   */
  async queryMinutesAudioWithOptions(conferenceId: string, request: QueryMinutesAudioRequest, headers: QueryMinutesAudioHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMinutesAudioResponse> {
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
      action: "QueryMinutesAudio",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/minutes/audioInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMinutesAudioResponse>(await this.execute(params, req, runtime), new QueryMinutesAudioResponse({}));
  }

  /**
   * 查询会议闪记的音频信息
   * 
   * @param request - QueryMinutesAudioRequest
   * @returns QueryMinutesAudioResponse
   */
  async queryMinutesAudio(conferenceId: string, request: QueryMinutesAudioRequest): Promise<QueryMinutesAudioResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMinutesAudioHeaders({ });
    return await this.queryMinutesAudioWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询会议闪记智能纪要
   * 
   * @param request - QueryMinutesSummaryRequest
   * @param headers - QueryMinutesSummaryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMinutesSummaryResponse
   */
  async queryMinutesSummaryWithOptions(conferenceId: string, request: QueryMinutesSummaryRequest, headers: QueryMinutesSummaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMinutesSummaryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.summaryTypeList)) {
      body["summaryTypeList"] = request.summaryTypeList;
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
      action: "QueryMinutesSummary",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/minutes/summaries/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMinutesSummaryResponse>(await this.execute(params, req, runtime), new QueryMinutesSummaryResponse({}));
  }

  /**
   * 查询会议闪记智能纪要
   * 
   * @param request - QueryMinutesSummaryRequest
   * @returns QueryMinutesSummaryResponse
   */
  async queryMinutesSummary(conferenceId: string, request: QueryMinutesSummaryRequest): Promise<QueryMinutesSummaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMinutesSummaryHeaders({ });
    return await this.queryMinutesSummaryWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询会议闪记文本信息
   * 
   * @param request - QueryMinutesTextRequest
   * @param headers - QueryMinutesTextHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMinutesTextResponse
   */
  async queryMinutesTextWithOptions(conferenceId: string, request: QueryMinutesTextRequest, headers: QueryMinutesTextHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMinutesTextResponse> {
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
      action: "QueryMinutesText",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/minutes/textInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMinutesTextResponse>(await this.execute(params, req, runtime), new QueryMinutesTextResponse({}));
  }

  /**
   * 查询会议闪记文本信息
   * 
   * @param request - QueryMinutesTextRequest
   * @returns QueryMinutesTextResponse
   */
  async queryMinutesText(conferenceId: string, request: QueryMinutesTextRequest): Promise<QueryMinutesTextResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMinutesTextHeaders({ });
    return await this.queryMinutesTextWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询闪记链接
   * 
   * @param request - QueryRecordMinutesUrlRequest
   * @param headers - QueryRecordMinutesUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRecordMinutesUrlResponse
   */
  async queryRecordMinutesUrlWithOptions(conferenceId: string, request: QueryRecordMinutesUrlRequest, headers: QueryRecordMinutesUrlHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRecordMinutesUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      query["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.recorderUnionId)) {
      query["recorderUnionId"] = request.recorderUnionId;
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
      action: "QueryRecordMinutesUrl",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/flashMinutes/recordUrls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRecordMinutesUrlResponse>(await this.execute(params, req, runtime), new QueryRecordMinutesUrlResponse({}));
  }

  /**
   * 查询闪记链接
   * 
   * @param request - QueryRecordMinutesUrlRequest
   * @returns QueryRecordMinutesUrlResponse
   */
  async queryRecordMinutesUrl(conferenceId: string, request: QueryRecordMinutesUrlRequest): Promise<QueryRecordMinutesUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRecordMinutesUrlHeaders({ });
    return await this.queryRecordMinutesUrlWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 查询预约会议设置
   * 
   * @param request - QueryScheduleConfSettingsRequest
   * @param headers - QueryScheduleConfSettingsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryScheduleConfSettingsResponse
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
   * 查询预约会议设置
   * 
   * @param request - QueryScheduleConfSettingsRequest
   * @returns QueryScheduleConfSettingsResponse
   */
  async queryScheduleConfSettings(request: QueryScheduleConfSettingsRequest): Promise<QueryScheduleConfSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConfSettingsHeaders({ });
    return await this.queryScheduleConfSettingsWithOptions(request, headers, runtime);
  }

  /**
   * 查询预约会议信息
   * 
   * @param request - QueryScheduleConferenceRequest
   * @param headers - QueryScheduleConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryScheduleConferenceResponse
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
   * 查询预约会议信息
   * 
   * @param request - QueryScheduleConferenceRequest
   * @returns QueryScheduleConferenceResponse
   */
  async queryScheduleConference(scheduleConferenceId: string, request: QueryScheduleConferenceRequest): Promise<QueryScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConferenceHeaders({ });
    return await this.queryScheduleConferenceWithOptions(scheduleConferenceId, request, headers, runtime);
  }

  /**
   * 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
   * 
   * @param request - QueryScheduleConferenceInfoRequest
   * @param headers - QueryScheduleConferenceInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryScheduleConferenceInfoResponse
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
   * 分页获取预约会议历史会议信息，当前仅返回最后一次的会议信息
   * 
   * @param request - QueryScheduleConferenceInfoRequest
   * @returns QueryScheduleConferenceInfoResponse
   */
  async queryScheduleConferenceInfo(scheduleConferenceId: string, request: QueryScheduleConferenceInfoRequest): Promise<QueryScheduleConferenceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScheduleConferenceInfoHeaders({ });
    return await this.queryScheduleConferenceInfoWithOptions(scheduleConferenceId, request, headers, runtime);
  }

  /**
   * 查询用户进行中会议
   * 
   * @param request - QueryUserOnGoingConferenceRequest
   * @param headers - QueryUserOnGoingConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUserOnGoingConferenceResponse
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
   * 查询用户进行中会议
   * 
   * @param request - QueryUserOnGoingConferenceRequest
   * @returns QueryUserOnGoingConferenceResponse
   */
  async queryUserOnGoingConference(request: QueryUserOnGoingConferenceRequest): Promise<QueryUserOnGoingConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserOnGoingConferenceHeaders({ });
    return await this.queryUserOnGoingConferenceWithOptions(request, headers, runtime);
  }

  /**
   * 开启云录制
   * 
   * @param request - StartCloudRecordRequest
   * @param headers - StartCloudRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StartCloudRecordResponse
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
   * 开启云录制
   * 
   * @param request - StartCloudRecordRequest
   * @returns StartCloudRecordResponse
   */
  async startCloudRecord(conferenceId: string, request: StartCloudRecordRequest): Promise<StartCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCloudRecordHeaders({ });
    return await this.startCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 开启会议闪记
   * 
   * @param request - StartMinutesRequest
   * @param headers - StartMinutesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StartMinutesResponse
   */
  async startMinutesWithOptions(conferenceId: string, request: StartMinutesRequest, headers: StartMinutesHeaders, runtime: $Util.RuntimeOptions): Promise<StartMinutesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ownerUnionId)) {
      body["ownerUnionId"] = request.ownerUnionId;
    }

    if (!Util.isUnset(request.recordAudio)) {
      body["recordAudio"] = request.recordAudio;
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
      action: "StartMinutes",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/minutes/start`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StartMinutesResponse>(await this.execute(params, req, runtime), new StartMinutesResponse({}));
  }

  /**
   * 开启会议闪记
   * 
   * @param request - StartMinutesRequest
   * @returns StartMinutesResponse
   */
  async startMinutes(conferenceId: string, request: StartMinutesRequest): Promise<StartMinutesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartMinutesHeaders({ });
    return await this.startMinutesWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 会议开始直播推流
   * 
   * @param request - StartStreamOutRequest
   * @param headers - StartStreamOutHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StartStreamOutResponse
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
   * 会议开始直播推流
   * 
   * @param request - StartStreamOutRequest
   * @returns StartStreamOutResponse
   */
  async startStreamOut(conferenceId: string, request: StartStreamOutRequest): Promise<StartStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartStreamOutHeaders({ });
    return await this.startStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 关闭云录制
   * 
   * @param request - StopCloudRecordRequest
   * @param headers - StopCloudRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StopCloudRecordResponse
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
   * 关闭云录制
   * 
   * @param request - StopCloudRecordRequest
   * @returns StopCloudRecordResponse
   */
  async stopCloudRecord(conferenceId: string, request: StopCloudRecordRequest): Promise<StopCloudRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopCloudRecordHeaders({ });
    return await this.stopCloudRecordWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 暂停会议闪记
   * 
   * @param request - StopMinutesRequest
   * @param headers - StopMinutesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StopMinutesResponse
   */
  async stopMinutesWithOptions(conferenceId: string, request: StopMinutesRequest, headers: StopMinutesHeaders, runtime: $Util.RuntimeOptions): Promise<StopMinutesResponse> {
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
      action: "StopMinutes",
      version: "conference_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/conference/videoConferences/${conferenceId}/minutes/pause`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<StopMinutesResponse>(await this.execute(params, req, runtime), new StopMinutesResponse({}));
  }

  /**
   * 暂停会议闪记
   * 
   * @param request - StopMinutesRequest
   * @returns StopMinutesResponse
   */
  async stopMinutes(conferenceId: string, request: StopMinutesRequest): Promise<StopMinutesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopMinutesHeaders({ });
    return await this.stopMinutesWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 会议停止直播推流
   * 
   * @param request - StopStreamOutRequest
   * @param headers - StopStreamOutHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns StopStreamOutResponse
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
   * 会议停止直播推流
   * 
   * @param request - StopStreamOutRequest
   * @returns StopStreamOutResponse
   */
  async stopStreamOut(conferenceId: string, request: StopStreamOutRequest): Promise<StopStreamOutResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopStreamOutHeaders({ });
    return await this.stopStreamOutWithOptions(conferenceId, request, headers, runtime);
  }

  /**
   * 更新预约会议设置
   * 
   * @param request - UpdateScheduleConfSettingsRequest
   * @param headers - UpdateScheduleConfSettingsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateScheduleConfSettingsResponse
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
   * 更新预约会议设置
   * 
   * @param request - UpdateScheduleConfSettingsRequest
   * @returns UpdateScheduleConfSettingsResponse
   */
  async updateScheduleConfSettings(request: UpdateScheduleConfSettingsRequest): Promise<UpdateScheduleConfSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateScheduleConfSettingsHeaders({ });
    return await this.updateScheduleConfSettingsWithOptions(request, headers, runtime);
  }

  /**
   * 更新预约会议
   * 
   * @param request - UpdateScheduleConferenceRequest
   * @param headers - UpdateScheduleConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateScheduleConferenceResponse
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
   * 更新预约会议
   * 
   * @param request - UpdateScheduleConferenceRequest
   * @returns UpdateScheduleConferenceResponse
   */
  async updateScheduleConference(request: UpdateScheduleConferenceRequest): Promise<UpdateScheduleConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateScheduleConferenceHeaders({ });
    return await this.updateScheduleConferenceWithOptions(request, headers, runtime);
  }

  /**
   * 更新会议额外信息
   * 
   * @param headers - UpdateVideoConferenceExtInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateVideoConferenceExtInfoResponse
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
   * 更新会议额外信息
   * @returns UpdateVideoConferenceExtInfoResponse
   */
  async updateVideoConferenceExtInfo(conferenceId: string): Promise<UpdateVideoConferenceExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceExtInfoHeaders({ });
    return await this.updateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
  }

  /**
   * 设置会议中的会议属性
   * 
   * @param request - UpdateVideoConferenceSettingRequest
   * @param headers - UpdateVideoConferenceSettingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateVideoConferenceSettingResponse
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
   * 设置会议中的会议属性
   * 
   * @param request - UpdateVideoConferenceSettingRequest
   * @returns UpdateVideoConferenceSettingResponse
   */
  async updateVideoConferenceSetting(conferenceId: string, request: UpdateVideoConferenceSettingRequest): Promise<UpdateVideoConferenceSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceSettingHeaders({ });
    return await this.updateVideoConferenceSettingWithOptions(conferenceId, request, headers, runtime);
  }

}
