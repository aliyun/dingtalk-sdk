// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateDeviceCustomTemplateHeaders extends $tea.Model {
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

export class CreateDeviceCustomTemplateRequest extends $tea.Model {
  bgImgList?: string[];
  /**
   * @example
   * 1
   */
  bgType?: number;
  /**
   * @example
   * https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png
   */
  bgUrl?: string;
  /**
   * @example
   * 测试文本
   */
  customDoc?: string;
  desensitizeUserName?: boolean;
  deviceUnionIds?: string[];
  groupIds?: number[];
  hideServerCodeWhenProjecting?: boolean;
  instruction?: boolean;
  /**
   * @example
   * 1
   */
  isPicTop?: number;
  /**
   * @example
   * logo
   */
  logo?: string;
  /**
   * @example
   * 测试企业
   */
  orgName?: string;
  /**
   * @example
   * 10
   */
  picturePlayInterval?: number;
  roomIds?: string[];
  showCalendarCard?: boolean;
  showCalendarTitle?: boolean;
  showFunctionCard?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试模板
   */
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      bgImgList: 'bgImgList',
      bgType: 'bgType',
      bgUrl: 'bgUrl',
      customDoc: 'customDoc',
      desensitizeUserName: 'desensitizeUserName',
      deviceUnionIds: 'deviceUnionIds',
      groupIds: 'groupIds',
      hideServerCodeWhenProjecting: 'hideServerCodeWhenProjecting',
      instruction: 'instruction',
      isPicTop: 'isPicTop',
      logo: 'logo',
      orgName: 'orgName',
      picturePlayInterval: 'picturePlayInterval',
      roomIds: 'roomIds',
      showCalendarCard: 'showCalendarCard',
      showCalendarTitle: 'showCalendarTitle',
      showFunctionCard: 'showFunctionCard',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bgImgList: { 'type': 'array', 'itemType': 'string' },
      bgType: 'number',
      bgUrl: 'string',
      customDoc: 'string',
      desensitizeUserName: 'boolean',
      deviceUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupIds: { 'type': 'array', 'itemType': 'number' },
      hideServerCodeWhenProjecting: 'boolean',
      instruction: 'boolean',
      isPicTop: 'number',
      logo: 'string',
      orgName: 'string',
      picturePlayInterval: 'number',
      roomIds: { 'type': 'array', 'itemType': 'string' },
      showCalendarCard: 'boolean',
      showCalendarTitle: 'boolean',
      showFunctionCard: 'boolean',
      templateName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceCustomTemplateResponseBody extends $tea.Model {
  templateId?: number;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeviceCustomTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateDeviceCustomTemplateResponseBody;
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
      body: CreateDeviceCustomTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomHeaders extends $tea.Model {
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

export class CreateMeetingRoomRequest extends $tea.Model {
  enableCycleReservation?: boolean;
  /**
   * @example
   * 0
   */
  groupId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxIsvRoomId
   */
  isvRoomId?: string;
  reservationAuthority?: CreateMeetingRoomRequestReservationAuthority;
  /**
   * @example
   * 10
   */
  roomCapacity?: number;
  roomLabelIds?: number[];
  roomLocation?: CreateMeetingRoomRequestRoomLocation;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试会议室
   */
  roomName?: string;
  /**
   * @example
   * https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg
   */
  roomPicture?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.全员可用 1.仅管理员可用
   */
  roomStatus?: number;
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
      enableCycleReservation: 'enableCycleReservation',
      groupId: 'groupId',
      isvRoomId: 'isvRoomId',
      reservationAuthority: 'reservationAuthority',
      roomCapacity: 'roomCapacity',
      roomLabelIds: 'roomLabelIds',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStatus: 'roomStatus',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableCycleReservation: 'boolean',
      groupId: 'number',
      isvRoomId: 'string',
      reservationAuthority: CreateMeetingRoomRequestReservationAuthority,
      roomCapacity: 'number',
      roomLabelIds: { 'type': 'array', 'itemType': 'number' },
      roomLocation: CreateMeetingRoomRequestRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStatus: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomResponseBody extends $tea.Model {
  /**
   * @example
   * 0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed
   */
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateMeetingRoomResponseBody;
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
      body: CreateMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomControlPanelHeaders extends $tea.Model {
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

export class CreateMeetingRoomControlPanelRequest extends $tea.Model {
  extra?: CreateMeetingRoomControlPanelRequestExtra;
  /**
   * @remarks
   * This parameter is required.
   */
  roomConfig?: CreateMeetingRoomControlPanelRequestRoomConfig[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 25SDWxxxxxx
   */
  roomId?: string;
  /**
   * @example
   * 0
   */
  status?: number;
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
      extra: 'extra',
      roomConfig: 'roomConfig',
      roomId: 'roomId',
      status: 'status',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extra: CreateMeetingRoomControlPanelRequestExtra,
      roomConfig: { 'type': 'array', 'itemType': CreateMeetingRoomControlPanelRequestRoomConfig },
      roomId: 'string',
      status: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomControlPanelResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomControlPanelResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateMeetingRoomControlPanelResponseBody;
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
      body: CreateMeetingRoomControlPanelResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomGroupHeaders extends $tea.Model {
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

export class CreateMeetingRoomGroupRequest extends $tea.Model {
  /**
   * @example
   * 测试分组
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 172
   */
  parentGroupId?: number;
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
      groupName: 'groupName',
      parentGroupId: 'parentGroupId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      parentGroupId: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomGroupResponseBody extends $tea.Model {
  /**
   * @example
   * 172
   */
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateMeetingRoomGroupResponseBody;
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
      body: CreateMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceCustomTemplateHeaders extends $tea.Model {
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

export class DeleteDeviceCustomTemplateRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  templateId?: number;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDeviceCustomTemplateResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class DeleteDeviceCustomTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteDeviceCustomTemplateResponseBody;
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
      body: DeleteDeviceCustomTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomHeaders extends $tea.Model {
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

export class DeleteMeetingRoomRequest extends $tea.Model {
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

export class DeleteMeetingRoomResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class DeleteMeetingRoomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteMeetingRoomResponseBody;
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
      body: DeleteMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomControlPanelHeaders extends $tea.Model {
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

export class DeleteMeetingRoomControlPanelRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  roomIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * A1FAxxxxx
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      roomIds: 'roomIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roomIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomControlPanelResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomControlPanelResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteMeetingRoomControlPanelResponseBody;
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
      body: DeleteMeetingRoomControlPanelResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteMeetingRoomGroupHeaders extends $tea.Model {
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

export class DeleteMeetingRoomGroupRequest extends $tea.Model {
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

export class DeleteMeetingRoomGroupResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class DeleteMeetingRoomGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteMeetingRoomGroupResponseBody;
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
      body: DeleteMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateHeaders extends $tea.Model {
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

export class QueryDeviceCustomTemplateResponseBody extends $tea.Model {
  result?: QueryDeviceCustomTemplateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryDeviceCustomTemplateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDeviceCustomTemplateResponseBody;
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
      body: QueryDeviceCustomTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateListHeaders extends $tea.Model {
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

export class QueryDeviceCustomTemplateListResponseBody extends $tea.Model {
  result?: QueryDeviceCustomTemplateListResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryDeviceCustomTemplateListResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDeviceCustomTemplateListResponseBody;
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
      body: QueryDeviceCustomTemplateListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeHeaders extends $tea.Model {
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

export class QueryDeviceIpByCodeRequest extends $tea.Model {
  /**
   * @example
   * 1005F1K203604N000676
   */
  deviceSn?: string;
  static names(): { [key: string]: string } {
    return {
      deviceSn: 'deviceSn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceSn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeResponseBody extends $tea.Model {
  result?: QueryDeviceIpByCodeResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryDeviceIpByCodeResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDeviceIpByCodeResponseBody;
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
      body: QueryDeviceIpByCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDevicePropertiesHeaders extends $tea.Model {
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

export class QueryDevicePropertiesRequest extends $tea.Model {
  propertyNames?: string[];
  /**
   * @example
   * 1234
   */
  deviceId?: string;
  /**
   * @example
   * "lmvUrRkpboRrSMtgsiS9V3AiEiE"
   */
  deviceUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "lmvUrEjpboFrSMtgsiS9V3AiEiE"
   */
  operatorUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      propertyNames: 'propertyNames',
      deviceId: 'deviceId',
      deviceUnionId: 'deviceUnionId',
      operatorUnionId: 'operatorUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      propertyNames: { 'type': 'array', 'itemType': 'string' },
      deviceId: 'string',
      deviceUnionId: 'string',
      operatorUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDevicePropertiesResponseBody extends $tea.Model {
  result?: QueryDevicePropertiesResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryDevicePropertiesResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDevicePropertiesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDevicePropertiesResponseBody;
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
      body: QueryDevicePropertiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomHeaders extends $tea.Model {
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

export class QueryMeetingRoomRequest extends $tea.Model {
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

export class QueryMeetingRoomResponseBody extends $tea.Model {
  result?: QueryMeetingRoomResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryMeetingRoomResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMeetingRoomResponseBody;
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
      body: QueryMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomControlPanelListHeaders extends $tea.Model {
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

export class QueryMeetingRoomControlPanelListRequest extends $tea.Model {
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @example
   * 2iPOLxxxxx
   */
  roomId?: string;
  /**
   * @example
   * 2iPOLbpUNMLzB5LuwggiiqiPwiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      roomId: 'roomId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      roomId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomControlPanelListResponseBody extends $tea.Model {
  hasMore?: boolean;
  /**
   * @example
   * 0
   */
  nextToken?: number;
  result?: QueryMeetingRoomControlPanelListResponseBodyResult[];
  /**
   * @example
   * 10
   */
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      result: 'result',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      result: { 'type': 'array', 'itemType': QueryMeetingRoomControlPanelListResponseBodyResult },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomControlPanelListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMeetingRoomControlPanelListResponseBody;
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
      body: QueryMeetingRoomControlPanelListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomDeviceHeaders extends $tea.Model {
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

export class QueryMeetingRoomDeviceRequest extends $tea.Model {
  /**
   * @example
   * 1234
   */
  deviceId?: string;
  /**
   * @example
   * "lmvUrRkpboRrSMtgsiS9V3AiEiE"
   */
  deviceUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "lmvUrEjpboFrSMtgsiS9V3AiEiE"
   */
  operatorUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceUnionId: 'deviceUnionId',
      operatorUnionId: 'operatorUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'string',
      deviceUnionId: 'string',
      operatorUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomDeviceResponseBody extends $tea.Model {
  result?: QueryMeetingRoomDeviceResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryMeetingRoomDeviceResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomDeviceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMeetingRoomDeviceResponseBody;
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
      body: QueryMeetingRoomDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupHeaders extends $tea.Model {
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

export class QueryMeetingRoomGroupRequest extends $tea.Model {
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

export class QueryMeetingRoomGroupResponseBody extends $tea.Model {
  /**
   * @example
   * 172
   */
  groupId?: number;
  /**
   * @example
   * 测试分组
   */
  groupName?: string;
  /**
   * @example
   * 0
   */
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMeetingRoomGroupResponseBody;
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
      body: QueryMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupListHeaders extends $tea.Model {
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

export class QueryMeetingRoomGroupListRequest extends $tea.Model {
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

export class QueryMeetingRoomGroupListResponseBody extends $tea.Model {
  result?: QueryMeetingRoomGroupListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryMeetingRoomGroupListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMeetingRoomGroupListResponseBody;
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
      body: QueryMeetingRoomGroupListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListHeaders extends $tea.Model {
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

export class QueryMeetingRoomListRequest extends $tea.Model {
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * 124
   */
  nextToken?: number;
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
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * 123
   */
  nextToken?: number;
  result?: QueryMeetingRoomListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      result: { 'type': 'array', 'itemType': QueryMeetingRoomListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMeetingRoomListResponseBody;
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
      body: QueryMeetingRoomListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveSuperUserMeetingRoomHeaders extends $tea.Model {
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

export class RemoveSuperUserMeetingRoomRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed
   */
  roomId?: string;
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
      roomId: 'roomId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roomId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveSuperUserMeetingRoomResponseBody extends $tea.Model {
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

export class RemoveSuperUserMeetingRoomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveSuperUserMeetingRoomResponseBody;
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
      body: RemoveSuperUserMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetSuperUserMeetingRoomHeaders extends $tea.Model {
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

export class SetSuperUserMeetingRoomRequest extends $tea.Model {
  deptIdWhiteList?: number[];
  /**
   * @remarks
   * This parameter is required.
   */
  roomId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * OcMXXXXXM2eRogiEiE
   */
  unionId?: string;
  userIdWhiteList?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIdWhiteList: 'deptIdWhiteList',
      roomId: 'roomId',
      unionId: 'unionId',
      userIdWhiteList: 'userIdWhiteList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdWhiteList: { 'type': 'array', 'itemType': 'number' },
      roomId: 'string',
      unionId: 'string',
      userIdWhiteList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetSuperUserMeetingRoomResponseBody extends $tea.Model {
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

export class SetSuperUserMeetingRoomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SetSuperUserMeetingRoomResponseBody;
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
      body: SetSuperUserMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDeviceCustomTemplateHeaders extends $tea.Model {
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

export class UpdateDeviceCustomTemplateRequest extends $tea.Model {
  bgImgList?: string[];
  /**
   * @example
   * 1
   */
  bgType?: number;
  /**
   * @example
   * https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png
   */
  bgUrl?: string;
  /**
   * @example
   * 测试文本
   */
  customDoc?: string;
  /**
   * @example
   * true：脱敏 false：不脱敏
   */
  desensitizeUserName?: boolean;
  deviceUnionIds?: string[];
  groupIds?: number[];
  /**
   * @example
   * true：隐藏 false：不隐藏
   */
  hideServerCodeWhenProjecting?: boolean;
  /**
   * @example
   * true：显示 false：不显示
   */
  instruction?: boolean;
  /**
   * @example
   * 1
   */
  isPicTop?: number;
  /**
   * @example
   * logo
   */
  logo?: string;
  /**
   * @example
   * 测试企业
   */
  orgName?: string;
  /**
   * @example
   * 10
   */
  picturePlayInterval?: number;
  roomIds?: string[];
  /**
   * @example
   * true：展示 false：不展示
   */
  showCalendarCard?: boolean;
  /**
   * @example
   * true：展示 false：不展示
   */
  showCalendarTitle?: boolean;
  /**
   * @example
   * true：展示 false：不展示
   */
  showFunctionCard?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 89
   */
  templateId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试模板
   */
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      bgImgList: 'bgImgList',
      bgType: 'bgType',
      bgUrl: 'bgUrl',
      customDoc: 'customDoc',
      desensitizeUserName: 'desensitizeUserName',
      deviceUnionIds: 'deviceUnionIds',
      groupIds: 'groupIds',
      hideServerCodeWhenProjecting: 'hideServerCodeWhenProjecting',
      instruction: 'instruction',
      isPicTop: 'isPicTop',
      logo: 'logo',
      orgName: 'orgName',
      picturePlayInterval: 'picturePlayInterval',
      roomIds: 'roomIds',
      showCalendarCard: 'showCalendarCard',
      showCalendarTitle: 'showCalendarTitle',
      showFunctionCard: 'showFunctionCard',
      templateId: 'templateId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bgImgList: { 'type': 'array', 'itemType': 'string' },
      bgType: 'number',
      bgUrl: 'string',
      customDoc: 'string',
      desensitizeUserName: 'boolean',
      deviceUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupIds: { 'type': 'array', 'itemType': 'number' },
      hideServerCodeWhenProjecting: 'boolean',
      instruction: 'boolean',
      isPicTop: 'number',
      logo: 'string',
      orgName: 'string',
      picturePlayInterval: 'number',
      roomIds: { 'type': 'array', 'itemType': 'string' },
      showCalendarCard: 'boolean',
      showCalendarTitle: 'boolean',
      showFunctionCard: 'boolean',
      templateId: 'number',
      templateName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDeviceCustomTemplateResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class UpdateDeviceCustomTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateDeviceCustomTemplateResponseBody;
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
      body: UpdateDeviceCustomTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomHeaders extends $tea.Model {
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

export class UpdateMeetingRoomRequest extends $tea.Model {
  enableCycleReservation?: boolean;
  /**
   * @example
   * 0
   */
  groupId?: number;
  /**
   * @example
   * xxxIsvRoomId
   */
  isvRoomId?: string;
  reservationAuthority?: UpdateMeetingRoomRequestReservationAuthority;
  /**
   * @example
   * 10
   */
  roomCapacity?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed
   */
  roomId?: string;
  roomLabelIds?: number[];
  roomLocation?: UpdateMeetingRoomRequestRoomLocation;
  /**
   * @example
   * 测试会议室
   */
  roomName?: string;
  /**
   * @example
   * https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg
   */
  roomPicture?: string;
  /**
   * @example
   * 0.全员可用 1.仅管理员可用
   */
  roomStatus?: number;
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
      enableCycleReservation: 'enableCycleReservation',
      groupId: 'groupId',
      isvRoomId: 'isvRoomId',
      reservationAuthority: 'reservationAuthority',
      roomCapacity: 'roomCapacity',
      roomId: 'roomId',
      roomLabelIds: 'roomLabelIds',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStatus: 'roomStatus',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableCycleReservation: 'boolean',
      groupId: 'number',
      isvRoomId: 'string',
      reservationAuthority: UpdateMeetingRoomRequestReservationAuthority,
      roomCapacity: 'number',
      roomId: 'string',
      roomLabelIds: { 'type': 'array', 'itemType': 'number' },
      roomLocation: UpdateMeetingRoomRequestRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStatus: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class UpdateMeetingRoomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateMeetingRoomResponseBody;
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
      body: UpdateMeetingRoomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomGroupHeaders extends $tea.Model {
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

export class UpdateMeetingRoomGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 172
   */
  groupId?: number;
  /**
   * @example
   * 测试分组
   */
  groupName?: string;
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
      groupId: 'groupId',
      groupName: 'groupName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomGroupResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
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

export class UpdateMeetingRoomGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateMeetingRoomGroupResponseBody;
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
      body: UpdateMeetingRoomGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomRequestReservationAuthorityAuthorizedMembers extends $tea.Model {
  /**
   * @example
   * lPHhSZDLXXXXXXpBlC9lxLwiEiE
   */
  memberId?: string;
  /**
   * @example
   * 张三
   */
  memberName?: string;
  /**
   * @example
   * user
   */
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberName: 'memberName',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberName: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomRequestReservationAuthority extends $tea.Model {
  authorizedMembers?: CreateMeetingRoomRequestReservationAuthorityAuthorizedMembers[];
  static names(): { [key: string]: string } {
    return {
      authorizedMembers: 'authorizedMembers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorizedMembers: { 'type': 'array', 'itemType': CreateMeetingRoomRequestReservationAuthorityAuthorizedMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomRequestRoomLocation extends $tea.Model {
  /**
   * @example
   * xx市xx区xx路xx号
   */
  desc?: string;
  /**
   * @example
   * xxx公司
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomControlPanelRequestExtra extends $tea.Model {
  param?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      param: 'param',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateMeetingRoomControlPanelRequestRoomConfig extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * name
   */
  enName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.xxx.com
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 栗子xx
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 30
   */
  showTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  sort?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://www.taoxxx.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      enName: 'enName',
      icon: 'icon',
      name: 'name',
      showTime: 'showTime',
      sort: 'sort',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enName: 'string',
      icon: 'string',
      name: 'string',
      showTime: 'number',
      sort: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate extends $tea.Model {
  bgImageList?: string[];
  /**
   * @example
   * 1
   */
  bgType?: number;
  /**
   * @example
   * https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png
   */
  bgUrl?: string;
  /**
   * @example
   * 1
   */
  confSubType?: number;
  /**
   * @example
   * 1
   */
  confType?: number;
  /**
   * @example
   * dingc02f685faxxxxc44ac5d6980864d335
   */
  corpId?: string;
  /**
   * @example
   * 测试文本
   */
  customDoc?: string;
  /**
   * @example
   * true：脱敏 false：不脱敏
   */
  desensitizeUserName?: boolean;
  /**
   * @example
   * true：隐藏 false：不隐藏
   */
  hideServerCodeWhenProjecting?: boolean;
  /**
   * @example
   * true：显示 false：不显示
   */
  instruction?: boolean;
  /**
   * @example
   * 1
   */
  isPicTop?: number;
  /**
   * @example
   * logo
   */
  logo?: string;
  /**
   * @example
   * 测试企业
   */
  orgName?: string;
  /**
   * @example
   * 10
   */
  picturePlayInterval?: number;
  /**
   * @example
   * true：展示 false：不展示
   */
  showCalendarCard?: boolean;
  /**
   * @example
   * true：展示 false：不展示
   */
  showCalendarTitle?: boolean;
  /**
   * @example
   * true：展示 false：不展示
   */
  showFunctionCard?: boolean;
  /**
   * @example
   * 89
   */
  templateId?: number;
  /**
   * @example
   * 测试模板
   */
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      bgImageList: 'bgImageList',
      bgType: 'bgType',
      bgUrl: 'bgUrl',
      confSubType: 'confSubType',
      confType: 'confType',
      corpId: 'corpId',
      customDoc: 'customDoc',
      desensitizeUserName: 'desensitizeUserName',
      hideServerCodeWhenProjecting: 'hideServerCodeWhenProjecting',
      instruction: 'instruction',
      isPicTop: 'isPicTop',
      logo: 'logo',
      orgName: 'orgName',
      picturePlayInterval: 'picturePlayInterval',
      showCalendarCard: 'showCalendarCard',
      showCalendarTitle: 'showCalendarTitle',
      showFunctionCard: 'showFunctionCard',
      templateId: 'templateId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bgImageList: { 'type': 'array', 'itemType': 'string' },
      bgType: 'number',
      bgUrl: 'string',
      confSubType: 'number',
      confType: 'number',
      corpId: 'string',
      customDoc: 'string',
      desensitizeUserName: 'boolean',
      hideServerCodeWhenProjecting: 'boolean',
      instruction: 'boolean',
      isPicTop: 'number',
      logo: 'string',
      orgName: 'string',
      picturePlayInterval: 'number',
      showCalendarCard: 'boolean',
      showCalendarTitle: 'boolean',
      showFunctionCard: 'boolean',
      templateId: 'number',
      templateName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateResponseBodyResult extends $tea.Model {
  deviceCustomTemplate?: QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate;
  deviceUnionIds?: string[];
  groupIds?: number[];
  roomIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceCustomTemplate: 'deviceCustomTemplate',
      deviceUnionIds: 'deviceUnionIds',
      groupIds: 'groupIds',
      roomIds: 'roomIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCustomTemplate: QueryDeviceCustomTemplateResponseBodyResultDeviceCustomTemplate,
      deviceUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupIds: { 'type': 'array', 'itemType': 'number' },
      roomIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates extends $tea.Model {
  bgImageList?: string[];
  /**
   * @example
   * 1
   */
  bgType?: number;
  /**
   * @example
   * https://img.alicdn.com/imgextra/i2/O1CN01GWWCCR1y2D9D9EHej_!!6000000006520-2-tps-1920-470.png
   */
  bgUrl?: string;
  /**
   * @example
   * 1
   */
  confSubType?: number;
  /**
   * @example
   * 1
   */
  confType?: number;
  /**
   * @example
   * dingc02f685fxxxx81c44ac5d6980864d335
   */
  corpId?: string;
  /**
   * @example
   * 测试文本
   */
  customDoc?: string;
  /**
   * @example
   * true：脱敏 false：不脱敏
   */
  desensitizeUserName?: boolean;
  /**
   * @example
   * true：隐藏 false：不隐藏
   */
  hideServerCodeWhenProjecting?: boolean;
  /**
   * @example
   * true：显示 false：不显示
   */
  instruction?: boolean;
  /**
   * @example
   * 1
   */
  isPicTop?: number;
  /**
   * @example
   * logo
   */
  logo?: string;
  /**
   * @example
   * 测试企业
   */
  orgName?: string;
  /**
   * @example
   * 10
   */
  picturePlayInterval?: number;
  /**
   * @example
   * true：展示 false：不展示
   */
  showCalendarCard?: boolean;
  /**
   * @example
   * true：展示 false：不展示
   */
  showCalendarTitle?: boolean;
  /**
   * @example
   * true：展示 false：不展示
   */
  showFunctionCard?: boolean;
  /**
   * @example
   * 89
   */
  templateId?: number;
  /**
   * @example
   * 测试模板
   */
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      bgImageList: 'bgImageList',
      bgType: 'bgType',
      bgUrl: 'bgUrl',
      confSubType: 'confSubType',
      confType: 'confType',
      corpId: 'corpId',
      customDoc: 'customDoc',
      desensitizeUserName: 'desensitizeUserName',
      hideServerCodeWhenProjecting: 'hideServerCodeWhenProjecting',
      instruction: 'instruction',
      isPicTop: 'isPicTop',
      logo: 'logo',
      orgName: 'orgName',
      picturePlayInterval: 'picturePlayInterval',
      showCalendarCard: 'showCalendarCard',
      showCalendarTitle: 'showCalendarTitle',
      showFunctionCard: 'showFunctionCard',
      templateId: 'templateId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bgImageList: { 'type': 'array', 'itemType': 'string' },
      bgType: 'number',
      bgUrl: 'string',
      confSubType: 'number',
      confType: 'number',
      corpId: 'string',
      customDoc: 'string',
      desensitizeUserName: 'boolean',
      hideServerCodeWhenProjecting: 'boolean',
      instruction: 'boolean',
      isPicTop: 'number',
      logo: 'string',
      orgName: 'string',
      picturePlayInterval: 'number',
      showCalendarCard: 'boolean',
      showCalendarTitle: 'boolean',
      showFunctionCard: 'boolean',
      templateId: 'number',
      templateName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceCustomTemplateListResponseBodyResult extends $tea.Model {
  deviceCustomTemplates?: QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates[];
  deviceTemplateMap?: { [key: string]: string[] };
  groupIdTemplateMap?: { [key: string]: number[] };
  roomIdTemplateMap?: { [key: string]: string[] };
  static names(): { [key: string]: string } {
    return {
      deviceCustomTemplates: 'deviceCustomTemplates',
      deviceTemplateMap: 'deviceTemplateMap',
      groupIdTemplateMap: 'groupIdTemplateMap',
      roomIdTemplateMap: 'roomIdTemplateMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceCustomTemplates: { 'type': 'array', 'itemType': QueryDeviceCustomTemplateListResponseBodyResultDeviceCustomTemplates },
      deviceTemplateMap: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': 'string' } },
      groupIdTemplateMap: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': 'number' } },
      roomIdTemplateMap: { 'type': 'map', 'keyType': 'string', 'valueType': { 'type': 'array', 'itemType': 'string' } },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceIpByCodeResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 30.12.1.100
   */
  deviceIp?: string;
  static names(): { [key: string]: string } {
    return {
      deviceIp: 'deviceIp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceIp: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDevicePropertiesResponseBodyResult extends $tea.Model {
  /**
   * @example
   * "dev_app_status"
   */
  propertyName?: string;
  /**
   * @example
   * "idle"
   */
  propertyValue?: string;
  static names(): { [key: string]: string } {
    return {
      propertyName: 'propertyName',
      propertyValue: 'propertyValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      propertyName: 'string',
      propertyValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers extends $tea.Model {
  /**
   * @example
   * lPHhSZDLXXXXXXpBlC9lxLwiEiE
   */
  memberId?: string;
  /**
   * @example
   * 张三
   */
  memberName?: string;
  /**
   * @example
   * user
   */
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberName: 'memberName',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberName: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultReservationAuthority extends $tea.Model {
  authorizedMembers?: QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers[];
  static names(): { [key: string]: string } {
    return {
      authorizedMembers: 'authorizedMembers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorizedMembers: { 'type': 'array', 'itemType': QueryMeetingRoomResponseBodyResultReservationAuthorityAuthorizedMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultRoomGroup extends $tea.Model {
  /**
   * @example
   * 1
   */
  groupId?: number;
  /**
   * @example
   * 测试分组
   */
  groupName?: string;
  /**
   * @example
   * 0
   */
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultRoomLabels extends $tea.Model {
  labelId?: number;
  labelName?: string;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResultRoomLocation extends $tea.Model {
  /**
   * @example
   * xx市xx区xx街道xx号
   */
  desc?: string;
  /**
   * @example
   * xxx公司
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomResponseBodyResult extends $tea.Model {
  /**
   * @example
   * ding994a046bca84545935c2f4657eb6378f
   */
  corpId?: string;
  deviceUnionIds?: string[];
  enableCycleReservation?: boolean;
  /**
   * @example
   * xxxIsvRoomId
   */
  isvRoomId?: string;
  reservationAuthority?: QueryMeetingRoomResponseBodyResultReservationAuthority;
  /**
   * @example
   * 10
   */
  roomCapacity?: number;
  roomGroup?: QueryMeetingRoomResponseBodyResultRoomGroup;
  /**
   * @example
   * 0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed
   */
  roomId?: string;
  roomLabels?: QueryMeetingRoomResponseBodyResultRoomLabels[];
  roomLocation?: QueryMeetingRoomResponseBodyResultRoomLocation;
  /**
   * @example
   * 测试会议室
   */
  roomName?: string;
  /**
   * @example
   * https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg
   */
  roomPicture?: string;
  /**
   * @example
   * 01224148194623278976
   */
  roomStaffId?: string;
  /**
   * @example
   * 0.全员可用 1.仅管理员可用
   */
  roomStatus?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deviceUnionIds: 'deviceUnionIds',
      enableCycleReservation: 'enableCycleReservation',
      isvRoomId: 'isvRoomId',
      reservationAuthority: 'reservationAuthority',
      roomCapacity: 'roomCapacity',
      roomGroup: 'roomGroup',
      roomId: 'roomId',
      roomLabels: 'roomLabels',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStaffId: 'roomStaffId',
      roomStatus: 'roomStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deviceUnionIds: { 'type': 'array', 'itemType': 'string' },
      enableCycleReservation: 'boolean',
      isvRoomId: 'string',
      reservationAuthority: QueryMeetingRoomResponseBodyResultReservationAuthority,
      roomCapacity: 'number',
      roomGroup: QueryMeetingRoomResponseBodyResultRoomGroup,
      roomId: 'string',
      roomLabels: { 'type': 'array', 'itemType': QueryMeetingRoomResponseBodyResultRoomLabels },
      roomLocation: QueryMeetingRoomResponseBodyResultRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStaffId: 'string',
      roomStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig extends $tea.Model {
  /**
   * @example
   * name
   */
  enName?: string;
  /**
   * @example
   * https://www.taoxxxxx.com
   */
  icon?: string;
  /**
   * @example
   * 栗子xx
   */
  name?: string;
  /**
   * @example
   * 30
   */
  showTime?: number;
  /**
   * @example
   * 0
   */
  sort?: number;
  /**
   * @example
   * https://www.taoxxxxx.com
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      enName: 'enName',
      icon: 'icon',
      name: 'name',
      showTime: 'showTime',
      sort: 'sort',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enName: 'string',
      icon: 'string',
      name: 'string',
      showTime: 'number',
      sort: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomControlPanelListResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 1WADFxxxxxx
   */
  roomId?: string;
  roomIotConfig?: QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig[];
  static names(): { [key: string]: string } {
    return {
      roomId: 'roomId',
      roomIotConfig: 'roomIotConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roomId: 'string',
      roomIotConfig: { 'type': 'array', 'itemType': QueryMeetingRoomControlPanelListResponseBodyResultRoomIotConfig },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomDeviceResponseBodyResultControllers extends $tea.Model {
  /**
   * @example
   * "ding994a046bca84545935c2f4657eb6378f"
   */
  corpId?: string;
  /**
   * @example
   * 2345
   */
  deviceId?: string;
  /**
   * @example
   * "d8:2f:e6:d9:ab:5b"
   */
  deviceMac?: string;
  /**
   * @example
   * "AILABS_S3_T1"
   */
  deviceModel?: string;
  /**
   * @example
   * 会控平板_xxxx
   */
  deviceName?: string;
  /**
   * @example
   * 1190
   */
  deviceServiceId?: number;
  /**
   * @example
   * "02caa8169c80f74a2d375093a6107017"
   */
  deviceSn?: string;
  /**
   * @example
   * 空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline
   */
  deviceStatus?: string;
  /**
   * @example
   * 视频会议设备:"touyingyi"   设备控制器:"meetingaccessory"
   */
  deviceType?: string;
  /**
   * @example
   * "lmvUrRkpboRrSMtgsiS9V4AiEiE"
   */
  deviceUnionId?: string;
  /**
   * @example
   * "7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed"
   */
  openRoomId?: string;
  /**
   * @example
   * 234567
   */
  shareCode?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deviceId: 'deviceId',
      deviceMac: 'deviceMac',
      deviceModel: 'deviceModel',
      deviceName: 'deviceName',
      deviceServiceId: 'deviceServiceId',
      deviceSn: 'deviceSn',
      deviceStatus: 'deviceStatus',
      deviceType: 'deviceType',
      deviceUnionId: 'deviceUnionId',
      openRoomId: 'openRoomId',
      shareCode: 'shareCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deviceId: 'string',
      deviceMac: 'string',
      deviceModel: 'string',
      deviceName: 'string',
      deviceServiceId: 'number',
      deviceSn: 'string',
      deviceStatus: 'string',
      deviceType: 'string',
      deviceUnionId: 'string',
      openRoomId: 'string',
      shareCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomDeviceResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 1697198045000
   */
  activeTime?: number;
  controllers?: QueryMeetingRoomDeviceResponseBodyResultControllers[];
  /**
   * @example
   * "ding994a046bca84545935c2f4657eb6378f"
   */
  corpId?: string;
  /**
   * @example
   * lPHhSZDLXXXXXXpBlC9lxLwiEiE
   */
  creatorUnionId?: string;
  /**
   * @example
   * Smart Camera
   */
  devCamera?: string;
  /**
   * @example
   * false
   */
  devHdmi?: string;
  /**
   * @example
   * Microphone (2- Built-in Audio)
   */
  devMic?: string;
  /**
   * @example
   * false
   */
  devMirror?: string;
  /**
   * @example
   * 127.0.0.10
   */
  devNetIp?: string;
  /**
   * @example
   * net_wired
   */
  devNetType?: string;
  /**
   * @example
   * Speaker (2- Built-in Audio)
   */
  devVoice?: string;
  /**
   * @example
   * d4:aa:ee:e8:4d:55
   */
  devWifiMac?: string;
  /**
   * @example
   * d4:3a:ee:aa:45:85
   */
  devWireMac?: string;
  /**
   * @example
   * 1234
   */
  deviceId?: string;
  /**
   * @example
   * "14:85:7f:e5:f3:f3"
   */
  deviceMac?: string;
  /**
   * @example
   * winbox
   */
  deviceModel?: string;
  /**
   * @example
   * 钉钉会议设备_xxxx
   */
  deviceName?: string;
  /**
   * @example
   * 1204
   */
  deviceServiceId?: number;
  /**
   * @example
   * "02caa8169c80f74a2d375093a6107016"
   */
  deviceSn?: string;
  /**
   * @example
   * 空闲：idle  投屏中：projection   会议响铃中：conf_incoming   会议中：conf_running   使用白板中：white_board   离线: offline
   */
  deviceStatus?: string;
  /**
   * @example
   * 视频会议设备:"touyingyi"   设备控制器:"meetingaccessory"
   */
  deviceType?: string;
  /**
   * @example
   * "lmvUrRkpboRrSMtgsiS9V3AiEiE"
   */
  deviceUnionId?: string;
  /**
   * @example
   * LMVXXX.20XX0818
   */
  firmwareVersion?: string;
  /**
   * @example
   * "7263defed6b361fedf0fe6a3b578b96e808b09d6ca6282ed"
   */
  openRoomId?: string;
  /**
   * @example
   * 测试会议室
   */
  roomName?: string;
  /**
   * @example
   * 123456
   */
  shareCode?: string;
  /**
   * @example
   * sip13492
   */
  sipAccountName?: string;
  /**
   * @example
   * 7.14.1
   */
  softwareVersion?: string;
  static names(): { [key: string]: string } {
    return {
      activeTime: 'activeTime',
      controllers: 'controllers',
      corpId: 'corpId',
      creatorUnionId: 'creatorUnionId',
      devCamera: 'devCamera',
      devHdmi: 'devHdmi',
      devMic: 'devMic',
      devMirror: 'devMirror',
      devNetIp: 'devNetIp',
      devNetType: 'devNetType',
      devVoice: 'devVoice',
      devWifiMac: 'devWifiMac',
      devWireMac: 'devWireMac',
      deviceId: 'deviceId',
      deviceMac: 'deviceMac',
      deviceModel: 'deviceModel',
      deviceName: 'deviceName',
      deviceServiceId: 'deviceServiceId',
      deviceSn: 'deviceSn',
      deviceStatus: 'deviceStatus',
      deviceType: 'deviceType',
      deviceUnionId: 'deviceUnionId',
      firmwareVersion: 'firmwareVersion',
      openRoomId: 'openRoomId',
      roomName: 'roomName',
      shareCode: 'shareCode',
      sipAccountName: 'sipAccountName',
      softwareVersion: 'softwareVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeTime: 'number',
      controllers: { 'type': 'array', 'itemType': QueryMeetingRoomDeviceResponseBodyResultControllers },
      corpId: 'string',
      creatorUnionId: 'string',
      devCamera: 'string',
      devHdmi: 'string',
      devMic: 'string',
      devMirror: 'string',
      devNetIp: 'string',
      devNetType: 'string',
      devVoice: 'string',
      devWifiMac: 'string',
      devWireMac: 'string',
      deviceId: 'string',
      deviceMac: 'string',
      deviceModel: 'string',
      deviceName: 'string',
      deviceServiceId: 'number',
      deviceSn: 'string',
      deviceStatus: 'string',
      deviceType: 'string',
      deviceUnionId: 'string',
      firmwareVersion: 'string',
      openRoomId: 'string',
      roomName: 'string',
      shareCode: 'string',
      sipAccountName: 'string',
      softwareVersion: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomGroupListResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 172
   */
  groupId?: number;
  /**
   * @example
   * 测试分组
   */
  groupName?: string;
  /**
   * @example
   * 0
   */
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResultRoomGroup extends $tea.Model {
  /**
   * @example
   * 1
   */
  groupId?: number;
  /**
   * @example
   * 测试分组
   */
  groupName?: string;
  /**
   * @example
   * 0
   */
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      parentId: 'parentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'number',
      groupName: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResultRoomLabels extends $tea.Model {
  labelId?: number;
  labelName?: string;
  static names(): { [key: string]: string } {
    return {
      labelId: 'labelId',
      labelName: 'labelName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      labelId: 'number',
      labelName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResultRoomLocation extends $tea.Model {
  /**
   * @example
   * xx市xx区xx街道xx号
   */
  desc?: string;
  /**
   * @example
   * xxx公司
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMeetingRoomListResponseBodyResult extends $tea.Model {
  /**
   * @example
   * ding994a046bca84545935c2f4657eb6378f
   */
  corpId?: string;
  /**
   * @example
   * xxxIsvRoomId
   */
  isvRoomId?: string;
  /**
   * @example
   * 10
   */
  roomCapacity?: number;
  roomGroup?: QueryMeetingRoomListResponseBodyResultRoomGroup;
  /**
   * @example
   * 0ffb71843fbb7fc362cb1a0de97fd20b808b09d6ca6282ed
   */
  roomId?: string;
  roomLabels?: QueryMeetingRoomListResponseBodyResultRoomLabels[];
  roomLocation?: QueryMeetingRoomListResponseBodyResultRoomLocation;
  /**
   * @example
   * 测试会议室
   */
  roomName?: string;
  /**
   * @example
   * https://static.dingtalk.com/media/lADPDgfLPFjNPu3NAWjNAWg_360_360.jpg
   */
  roomPicture?: string;
  /**
   * @example
   * 01224148194623278976
   */
  roomStaffId?: string;
  /**
   * @example
   * 0.全员可用 1.仅管理员可用
   */
  roomStatus?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isvRoomId: 'isvRoomId',
      roomCapacity: 'roomCapacity',
      roomGroup: 'roomGroup',
      roomId: 'roomId',
      roomLabels: 'roomLabels',
      roomLocation: 'roomLocation',
      roomName: 'roomName',
      roomPicture: 'roomPicture',
      roomStaffId: 'roomStaffId',
      roomStatus: 'roomStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isvRoomId: 'string',
      roomCapacity: 'number',
      roomGroup: QueryMeetingRoomListResponseBodyResultRoomGroup,
      roomId: 'string',
      roomLabels: { 'type': 'array', 'itemType': QueryMeetingRoomListResponseBodyResultRoomLabels },
      roomLocation: QueryMeetingRoomListResponseBodyResultRoomLocation,
      roomName: 'string',
      roomPicture: 'string',
      roomStaffId: 'string',
      roomStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers extends $tea.Model {
  /**
   * @example
   * lPHhSZDLXXXXXXpBlC9lxLwiEiE
   */
  memberId?: string;
  /**
   * @example
   * 张三
   */
  memberName?: string;
  /**
   * @example
   * user
   */
  memberType?: string;
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberName: 'memberName',
      memberType: 'memberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberName: 'string',
      memberType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomRequestReservationAuthority extends $tea.Model {
  authorizedMembers?: UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers[];
  static names(): { [key: string]: string } {
    return {
      authorizedMembers: 'authorizedMembers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorizedMembers: { 'type': 'array', 'itemType': UpdateMeetingRoomRequestReservationAuthorityAuthorizedMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMeetingRoomRequestRoomLocation extends $tea.Model {
  /**
   * @example
   * xx市xx区xx路xx号
   */
  desc?: string;
  /**
   * @example
   * xxx公司
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      title: 'string',
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
   * 创建自定义屏幕模版
   * 
   * @param request - CreateDeviceCustomTemplateRequest
   * @param headers - CreateDeviceCustomTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateDeviceCustomTemplateResponse
   */
  async createDeviceCustomTemplateWithOptions(request: CreateDeviceCustomTemplateRequest, headers: CreateDeviceCustomTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeviceCustomTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bgImgList)) {
      body["bgImgList"] = request.bgImgList;
    }

    if (!Util.isUnset(request.bgType)) {
      body["bgType"] = request.bgType;
    }

    if (!Util.isUnset(request.bgUrl)) {
      body["bgUrl"] = request.bgUrl;
    }

    if (!Util.isUnset(request.customDoc)) {
      body["customDoc"] = request.customDoc;
    }

    if (!Util.isUnset(request.desensitizeUserName)) {
      body["desensitizeUserName"] = request.desensitizeUserName;
    }

    if (!Util.isUnset(request.deviceUnionIds)) {
      body["deviceUnionIds"] = request.deviceUnionIds;
    }

    if (!Util.isUnset(request.groupIds)) {
      body["groupIds"] = request.groupIds;
    }

    if (!Util.isUnset(request.hideServerCodeWhenProjecting)) {
      body["hideServerCodeWhenProjecting"] = request.hideServerCodeWhenProjecting;
    }

    if (!Util.isUnset(request.instruction)) {
      body["instruction"] = request.instruction;
    }

    if (!Util.isUnset(request.isPicTop)) {
      body["isPicTop"] = request.isPicTop;
    }

    if (!Util.isUnset(request.logo)) {
      body["logo"] = request.logo;
    }

    if (!Util.isUnset(request.orgName)) {
      body["orgName"] = request.orgName;
    }

    if (!Util.isUnset(request.picturePlayInterval)) {
      body["picturePlayInterval"] = request.picturePlayInterval;
    }

    if (!Util.isUnset(request.roomIds)) {
      body["roomIds"] = request.roomIds;
    }

    if (!Util.isUnset(request.showCalendarCard)) {
      body["showCalendarCard"] = request.showCalendarCard;
    }

    if (!Util.isUnset(request.showCalendarTitle)) {
      body["showCalendarTitle"] = request.showCalendarTitle;
    }

    if (!Util.isUnset(request.showFunctionCard)) {
      body["showFunctionCard"] = request.showFunctionCard;
    }

    if (!Util.isUnset(request.templateName)) {
      body["templateName"] = request.templateName;
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
      action: "CreateDeviceCustomTemplate",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices/screens/templates`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateDeviceCustomTemplateResponse>(await this.execute(params, req, runtime), new CreateDeviceCustomTemplateResponse({}));
  }

  /**
   * 创建自定义屏幕模版
   * 
   * @param request - CreateDeviceCustomTemplateRequest
   * @returns CreateDeviceCustomTemplateResponse
   */
  async createDeviceCustomTemplate(request: CreateDeviceCustomTemplateRequest): Promise<CreateDeviceCustomTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeviceCustomTemplateHeaders({ });
    return await this.createDeviceCustomTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 创建智能会议室
   * 
   * @param request - CreateMeetingRoomRequest
   * @param headers - CreateMeetingRoomHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateMeetingRoomResponse
   */
  async createMeetingRoomWithOptions(request: CreateMeetingRoomRequest, headers: CreateMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMeetingRoomResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.enableCycleReservation)) {
      body["enableCycleReservation"] = request.enableCycleReservation;
    }

    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.isvRoomId)) {
      body["isvRoomId"] = request.isvRoomId;
    }

    if (!Util.isUnset(request.reservationAuthority)) {
      body["reservationAuthority"] = request.reservationAuthority;
    }

    if (!Util.isUnset(request.roomCapacity)) {
      body["roomCapacity"] = request.roomCapacity;
    }

    if (!Util.isUnset(request.roomLabelIds)) {
      body["roomLabelIds"] = request.roomLabelIds;
    }

    if (!Util.isUnset(request.roomLocation)) {
      body["roomLocation"] = request.roomLocation;
    }

    if (!Util.isUnset(request.roomName)) {
      body["roomName"] = request.roomName;
    }

    if (!Util.isUnset(request.roomPicture)) {
      body["roomPicture"] = request.roomPicture;
    }

    if (!Util.isUnset(request.roomStatus)) {
      body["roomStatus"] = request.roomStatus;
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
      action: "CreateMeetingRoom",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/meetingrooms`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateMeetingRoomResponse>(await this.execute(params, req, runtime), new CreateMeetingRoomResponse({}));
  }

  /**
   * 创建智能会议室
   * 
   * @param request - CreateMeetingRoomRequest
   * @returns CreateMeetingRoomResponse
   */
  async createMeetingRoom(request: CreateMeetingRoomRequest): Promise<CreateMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMeetingRoomHeaders({ });
    return await this.createMeetingRoomWithOptions(request, headers, runtime);
  }

  /**
   * 创建智能会议室IOT配置
   * 
   * @param request - CreateMeetingRoomControlPanelRequest
   * @param headers - CreateMeetingRoomControlPanelHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateMeetingRoomControlPanelResponse
   */
  async createMeetingRoomControlPanelWithOptions(request: CreateMeetingRoomControlPanelRequest, headers: CreateMeetingRoomControlPanelHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMeetingRoomControlPanelResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extra)) {
      body["extra"] = request.extra;
    }

    if (!Util.isUnset(request.roomConfig)) {
      body["roomConfig"] = request.roomConfig;
    }

    if (!Util.isUnset(request.roomId)) {
      body["roomId"] = request.roomId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
      action: "CreateMeetingRoomControlPanel",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/panels`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateMeetingRoomControlPanelResponse>(await this.execute(params, req, runtime), new CreateMeetingRoomControlPanelResponse({}));
  }

  /**
   * 创建智能会议室IOT配置
   * 
   * @param request - CreateMeetingRoomControlPanelRequest
   * @returns CreateMeetingRoomControlPanelResponse
   */
  async createMeetingRoomControlPanel(request: CreateMeetingRoomControlPanelRequest): Promise<CreateMeetingRoomControlPanelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMeetingRoomControlPanelHeaders({ });
    return await this.createMeetingRoomControlPanelWithOptions(request, headers, runtime);
  }

  /**
   * 创建会议室分组
   * 
   * @param request - CreateMeetingRoomGroupRequest
   * @param headers - CreateMeetingRoomGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateMeetingRoomGroupResponse
   */
  async createMeetingRoomGroupWithOptions(request: CreateMeetingRoomGroupRequest, headers: CreateMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateMeetingRoomGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.parentGroupId)) {
      body["parentGroupId"] = request.parentGroupId;
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
      action: "CreateMeetingRoomGroup",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateMeetingRoomGroupResponse>(await this.execute(params, req, runtime), new CreateMeetingRoomGroupResponse({}));
  }

  /**
   * 创建会议室分组
   * 
   * @param request - CreateMeetingRoomGroupRequest
   * @returns CreateMeetingRoomGroupResponse
   */
  async createMeetingRoomGroup(request: CreateMeetingRoomGroupRequest): Promise<CreateMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateMeetingRoomGroupHeaders({ });
    return await this.createMeetingRoomGroupWithOptions(request, headers, runtime);
  }

  /**
   * 删除自定义屏幕模板
   * 
   * @param request - DeleteDeviceCustomTemplateRequest
   * @param headers - DeleteDeviceCustomTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteDeviceCustomTemplateResponse
   */
  async deleteDeviceCustomTemplateWithOptions(request: DeleteDeviceCustomTemplateRequest, headers: DeleteDeviceCustomTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDeviceCustomTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
      action: "DeleteDeviceCustomTemplate",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices/screens/templates/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDeviceCustomTemplateResponse>(await this.execute(params, req, runtime), new DeleteDeviceCustomTemplateResponse({}));
  }

  /**
   * 删除自定义屏幕模板
   * 
   * @param request - DeleteDeviceCustomTemplateRequest
   * @returns DeleteDeviceCustomTemplateResponse
   */
  async deleteDeviceCustomTemplate(request: DeleteDeviceCustomTemplateRequest): Promise<DeleteDeviceCustomTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDeviceCustomTemplateHeaders({ });
    return await this.deleteDeviceCustomTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 删除会议室
   * 
   * @param request - DeleteMeetingRoomRequest
   * @param headers - DeleteMeetingRoomHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteMeetingRoomResponse
   */
  async deleteMeetingRoomWithOptions(roomId: string, request: DeleteMeetingRoomRequest, headers: DeleteMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteMeetingRoomResponse> {
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
      action: "DeleteMeetingRoom",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/meetingRooms/${roomId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteMeetingRoomResponse>(await this.execute(params, req, runtime), new DeleteMeetingRoomResponse({}));
  }

  /**
   * 删除会议室
   * 
   * @param request - DeleteMeetingRoomRequest
   * @returns DeleteMeetingRoomResponse
   */
  async deleteMeetingRoom(roomId: string, request: DeleteMeetingRoomRequest): Promise<DeleteMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteMeetingRoomHeaders({ });
    return await this.deleteMeetingRoomWithOptions(roomId, request, headers, runtime);
  }

  /**
   * 删除会议室配置
   * 
   * @param request - DeleteMeetingRoomControlPanelRequest
   * @param headers - DeleteMeetingRoomControlPanelHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteMeetingRoomControlPanelResponse
   */
  async deleteMeetingRoomControlPanelWithOptions(request: DeleteMeetingRoomControlPanelRequest, headers: DeleteMeetingRoomControlPanelHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteMeetingRoomControlPanelResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.roomIds)) {
      body["roomIds"] = request.roomIds;
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
      action: "DeleteMeetingRoomControlPanel",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/panels/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteMeetingRoomControlPanelResponse>(await this.execute(params, req, runtime), new DeleteMeetingRoomControlPanelResponse({}));
  }

  /**
   * 删除会议室配置
   * 
   * @param request - DeleteMeetingRoomControlPanelRequest
   * @returns DeleteMeetingRoomControlPanelResponse
   */
  async deleteMeetingRoomControlPanel(request: DeleteMeetingRoomControlPanelRequest): Promise<DeleteMeetingRoomControlPanelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteMeetingRoomControlPanelHeaders({ });
    return await this.deleteMeetingRoomControlPanelWithOptions(request, headers, runtime);
  }

  /**
   * 删除会议室分组
   * 
   * @param request - DeleteMeetingRoomGroupRequest
   * @param headers - DeleteMeetingRoomGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteMeetingRoomGroupResponse
   */
  async deleteMeetingRoomGroupWithOptions(groupId: string, request: DeleteMeetingRoomGroupRequest, headers: DeleteMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteMeetingRoomGroupResponse> {
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
      action: "DeleteMeetingRoomGroup",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/groups/${groupId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteMeetingRoomGroupResponse>(await this.execute(params, req, runtime), new DeleteMeetingRoomGroupResponse({}));
  }

  /**
   * 删除会议室分组
   * 
   * @param request - DeleteMeetingRoomGroupRequest
   * @returns DeleteMeetingRoomGroupResponse
   */
  async deleteMeetingRoomGroup(groupId: string, request: DeleteMeetingRoomGroupRequest): Promise<DeleteMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteMeetingRoomGroupHeaders({ });
    return await this.deleteMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
  }

  /**
   * 查询自定义屏幕模板
   * 
   * @param headers - QueryDeviceCustomTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDeviceCustomTemplateResponse
   */
  async queryDeviceCustomTemplateWithOptions(templateId: string, headers: QueryDeviceCustomTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceCustomTemplateResponse> {
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
      action: "QueryDeviceCustomTemplate",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices/screens/templates/${templateId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDeviceCustomTemplateResponse>(await this.execute(params, req, runtime), new QueryDeviceCustomTemplateResponse({}));
  }

  /**
   * 查询自定义屏幕模板
   * @returns QueryDeviceCustomTemplateResponse
   */
  async queryDeviceCustomTemplate(templateId: string): Promise<QueryDeviceCustomTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceCustomTemplateHeaders({ });
    return await this.queryDeviceCustomTemplateWithOptions(templateId, headers, runtime);
  }

  /**
   * 查询自定义屏幕模板列表
   * 
   * @param headers - QueryDeviceCustomTemplateListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDeviceCustomTemplateListResponse
   */
  async queryDeviceCustomTemplateListWithOptions(headers: QueryDeviceCustomTemplateListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceCustomTemplateListResponse> {
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
      action: "QueryDeviceCustomTemplateList",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices/screens/templateLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDeviceCustomTemplateListResponse>(await this.execute(params, req, runtime), new QueryDeviceCustomTemplateListResponse({}));
  }

  /**
   * 查询自定义屏幕模板列表
   * @returns QueryDeviceCustomTemplateListResponse
   */
  async queryDeviceCustomTemplateList(): Promise<QueryDeviceCustomTemplateListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceCustomTemplateListHeaders({ });
    return await this.queryDeviceCustomTemplateListWithOptions(headers, runtime);
  }

  /**
   * 根据设备投屏码查询设备ip
   * 
   * @param request - QueryDeviceIpByCodeRequest
   * @param headers - QueryDeviceIpByCodeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDeviceIpByCodeResponse
   */
  async queryDeviceIpByCodeWithOptions(shareCode: string, request: QueryDeviceIpByCodeRequest, headers: QueryDeviceIpByCodeHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceIpByCodeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceSn)) {
      query["deviceSn"] = request.deviceSn;
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
      action: "QueryDeviceIpByCode",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices/shareCodes/${shareCode}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDeviceIpByCodeResponse>(await this.execute(params, req, runtime), new QueryDeviceIpByCodeResponse({}));
  }

  /**
   * 根据设备投屏码查询设备ip
   * 
   * @param request - QueryDeviceIpByCodeRequest
   * @returns QueryDeviceIpByCodeResponse
   */
  async queryDeviceIpByCode(shareCode: string, request: QueryDeviceIpByCodeRequest): Promise<QueryDeviceIpByCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceIpByCodeHeaders({ });
    return await this.queryDeviceIpByCodeWithOptions(shareCode, request, headers, runtime);
  }

  /**
   * 查询设备属性
   * 
   * @param request - QueryDevicePropertiesRequest
   * @param headers - QueryDevicePropertiesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDevicePropertiesResponse
   */
  async queryDevicePropertiesWithOptions(request: QueryDevicePropertiesRequest, headers: QueryDevicePropertiesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDevicePropertiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceId)) {
      query["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.deviceUnionId)) {
      query["deviceUnionId"] = request.deviceUnionId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      query["operatorUnionId"] = request.operatorUnionId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.propertyNames)) {
      body["propertyNames"] = request.propertyNames;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "QueryDeviceProperties",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices/properties/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDevicePropertiesResponse>(await this.execute(params, req, runtime), new QueryDevicePropertiesResponse({}));
  }

  /**
   * 查询设备属性
   * 
   * @param request - QueryDevicePropertiesRequest
   * @returns QueryDevicePropertiesResponse
   */
  async queryDeviceProperties(request: QueryDevicePropertiesRequest): Promise<QueryDevicePropertiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDevicePropertiesHeaders({ });
    return await this.queryDevicePropertiesWithOptions(request, headers, runtime);
  }

  /**
   * 查询会议室详情
   * 
   * @param request - QueryMeetingRoomRequest
   * @param headers - QueryMeetingRoomHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMeetingRoomResponse
   */
  async queryMeetingRoomWithOptions(roomId: string, request: QueryMeetingRoomRequest, headers: QueryMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomResponse> {
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
      action: "QueryMeetingRoom",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/meetingRooms/${roomId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMeetingRoomResponse>(await this.execute(params, req, runtime), new QueryMeetingRoomResponse({}));
  }

  /**
   * 查询会议室详情
   * 
   * @param request - QueryMeetingRoomRequest
   * @returns QueryMeetingRoomResponse
   */
  async queryMeetingRoom(roomId: string, request: QueryMeetingRoomRequest): Promise<QueryMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomHeaders({ });
    return await this.queryMeetingRoomWithOptions(roomId, request, headers, runtime);
  }

  /**
   * 获取会议室IOT配置列表
   * 
   * @param request - QueryMeetingRoomControlPanelListRequest
   * @param headers - QueryMeetingRoomControlPanelListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMeetingRoomControlPanelListResponse
   */
  async queryMeetingRoomControlPanelListWithOptions(request: QueryMeetingRoomControlPanelListRequest, headers: QueryMeetingRoomControlPanelListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomControlPanelListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.roomId)) {
      query["roomId"] = request.roomId;
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
      action: "QueryMeetingRoomControlPanelList",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/panels/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMeetingRoomControlPanelListResponse>(await this.execute(params, req, runtime), new QueryMeetingRoomControlPanelListResponse({}));
  }

  /**
   * 获取会议室IOT配置列表
   * 
   * @param request - QueryMeetingRoomControlPanelListRequest
   * @returns QueryMeetingRoomControlPanelListResponse
   */
  async queryMeetingRoomControlPanelList(request: QueryMeetingRoomControlPanelListRequest): Promise<QueryMeetingRoomControlPanelListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomControlPanelListHeaders({ });
    return await this.queryMeetingRoomControlPanelListWithOptions(request, headers, runtime);
  }

  /**
   * 查询设备信息
   * 
   * @param request - QueryMeetingRoomDeviceRequest
   * @param headers - QueryMeetingRoomDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMeetingRoomDeviceResponse
   */
  async queryMeetingRoomDeviceWithOptions(request: QueryMeetingRoomDeviceRequest, headers: QueryMeetingRoomDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomDeviceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceId)) {
      query["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.deviceUnionId)) {
      query["deviceUnionId"] = request.deviceUnionId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      query["operatorUnionId"] = request.operatorUnionId;
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
      action: "QueryMeetingRoomDevice",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMeetingRoomDeviceResponse>(await this.execute(params, req, runtime), new QueryMeetingRoomDeviceResponse({}));
  }

  /**
   * 查询设备信息
   * 
   * @param request - QueryMeetingRoomDeviceRequest
   * @returns QueryMeetingRoomDeviceResponse
   */
  async queryMeetingRoomDevice(request: QueryMeetingRoomDeviceRequest): Promise<QueryMeetingRoomDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomDeviceHeaders({ });
    return await this.queryMeetingRoomDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 查询会议室分组信息
   * 
   * @param request - QueryMeetingRoomGroupRequest
   * @param headers - QueryMeetingRoomGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMeetingRoomGroupResponse
   */
  async queryMeetingRoomGroupWithOptions(groupId: string, request: QueryMeetingRoomGroupRequest, headers: QueryMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomGroupResponse> {
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
      action: "QueryMeetingRoomGroup",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/groups/${groupId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMeetingRoomGroupResponse>(await this.execute(params, req, runtime), new QueryMeetingRoomGroupResponse({}));
  }

  /**
   * 查询会议室分组信息
   * 
   * @param request - QueryMeetingRoomGroupRequest
   * @returns QueryMeetingRoomGroupResponse
   */
  async queryMeetingRoomGroup(groupId: string, request: QueryMeetingRoomGroupRequest): Promise<QueryMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomGroupHeaders({ });
    return await this.queryMeetingRoomGroupWithOptions(groupId, request, headers, runtime);
  }

  /**
   * 查询会议室分组列表
   * 
   * @param request - QueryMeetingRoomGroupListRequest
   * @param headers - QueryMeetingRoomGroupListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMeetingRoomGroupListResponse
   */
  async queryMeetingRoomGroupListWithOptions(request: QueryMeetingRoomGroupListRequest, headers: QueryMeetingRoomGroupListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomGroupListResponse> {
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
      action: "QueryMeetingRoomGroupList",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/groupLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMeetingRoomGroupListResponse>(await this.execute(params, req, runtime), new QueryMeetingRoomGroupListResponse({}));
  }

  /**
   * 查询会议室分组列表
   * 
   * @param request - QueryMeetingRoomGroupListRequest
   * @returns QueryMeetingRoomGroupListResponse
   */
  async queryMeetingRoomGroupList(request: QueryMeetingRoomGroupListRequest): Promise<QueryMeetingRoomGroupListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomGroupListHeaders({ });
    return await this.queryMeetingRoomGroupListWithOptions(request, headers, runtime);
  }

  /**
   * 查询会议室列表
   * 
   * @param request - QueryMeetingRoomListRequest
   * @param headers - QueryMeetingRoomListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMeetingRoomListResponse
   */
  async queryMeetingRoomListWithOptions(request: QueryMeetingRoomListRequest, headers: QueryMeetingRoomListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMeetingRoomListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      action: "QueryMeetingRoomList",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/meetingRoomLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMeetingRoomListResponse>(await this.execute(params, req, runtime), new QueryMeetingRoomListResponse({}));
  }

  /**
   * 查询会议室列表
   * 
   * @param request - QueryMeetingRoomListRequest
   * @returns QueryMeetingRoomListResponse
   */
  async queryMeetingRoomList(request: QueryMeetingRoomListRequest): Promise<QueryMeetingRoomListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMeetingRoomListHeaders({ });
    return await this.queryMeetingRoomListWithOptions(request, headers, runtime);
  }

  /**
   * 取消会议室高级用户模式。
   * 
   * @param request - RemoveSuperUserMeetingRoomRequest
   * @param headers - RemoveSuperUserMeetingRoomHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveSuperUserMeetingRoomResponse
   */
  async removeSuperUserMeetingRoomWithOptions(request: RemoveSuperUserMeetingRoomRequest, headers: RemoveSuperUserMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveSuperUserMeetingRoomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.roomId)) {
      query["roomId"] = request.roomId;
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
      action: "RemoveSuperUserMeetingRoom",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/meetingRooms/superUsers/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveSuperUserMeetingRoomResponse>(await this.execute(params, req, runtime), new RemoveSuperUserMeetingRoomResponse({}));
  }

  /**
   * 取消会议室高级用户模式。
   * 
   * @param request - RemoveSuperUserMeetingRoomRequest
   * @returns RemoveSuperUserMeetingRoomResponse
   */
  async removeSuperUserMeetingRoom(request: RemoveSuperUserMeetingRoomRequest): Promise<RemoveSuperUserMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveSuperUserMeetingRoomHeaders({ });
    return await this.removeSuperUserMeetingRoomWithOptions(request, headers, runtime);
  }

  /**
   * 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
   * 
   * @param request - SetSuperUserMeetingRoomRequest
   * @param headers - SetSuperUserMeetingRoomHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SetSuperUserMeetingRoomResponse
   */
  async setSuperUserMeetingRoomWithOptions(request: SetSuperUserMeetingRoomRequest, headers: SetSuperUserMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<SetSuperUserMeetingRoomResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIdWhiteList)) {
      body["deptIdWhiteList"] = request.deptIdWhiteList;
    }

    if (!Util.isUnset(request.roomId)) {
      body["roomId"] = request.roomId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.userIdWhiteList)) {
      body["userIdWhiteList"] = request.userIdWhiteList;
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
      action: "SetSuperUserMeetingRoom",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/meetingRooms/superUsers/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetSuperUserMeetingRoomResponse>(await this.execute(params, req, runtime), new SetSuperUserMeetingRoomResponse({}));
  }

  /**
   * 设置会议室成为高级用户模式。只有设置在白名单里的人员或部门，才能呼叫此会议室。
   * 
   * @param request - SetSuperUserMeetingRoomRequest
   * @returns SetSuperUserMeetingRoomResponse
   */
  async setSuperUserMeetingRoom(request: SetSuperUserMeetingRoomRequest): Promise<SetSuperUserMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetSuperUserMeetingRoomHeaders({ });
    return await this.setSuperUserMeetingRoomWithOptions(request, headers, runtime);
  }

  /**
   * 更新自定义屏幕模板
   * 
   * @param request - UpdateDeviceCustomTemplateRequest
   * @param headers - UpdateDeviceCustomTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateDeviceCustomTemplateResponse
   */
  async updateDeviceCustomTemplateWithOptions(request: UpdateDeviceCustomTemplateRequest, headers: UpdateDeviceCustomTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateDeviceCustomTemplateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bgImgList)) {
      body["bgImgList"] = request.bgImgList;
    }

    if (!Util.isUnset(request.bgType)) {
      body["bgType"] = request.bgType;
    }

    if (!Util.isUnset(request.bgUrl)) {
      body["bgUrl"] = request.bgUrl;
    }

    if (!Util.isUnset(request.customDoc)) {
      body["customDoc"] = request.customDoc;
    }

    if (!Util.isUnset(request.desensitizeUserName)) {
      body["desensitizeUserName"] = request.desensitizeUserName;
    }

    if (!Util.isUnset(request.deviceUnionIds)) {
      body["deviceUnionIds"] = request.deviceUnionIds;
    }

    if (!Util.isUnset(request.groupIds)) {
      body["groupIds"] = request.groupIds;
    }

    if (!Util.isUnset(request.hideServerCodeWhenProjecting)) {
      body["hideServerCodeWhenProjecting"] = request.hideServerCodeWhenProjecting;
    }

    if (!Util.isUnset(request.instruction)) {
      body["instruction"] = request.instruction;
    }

    if (!Util.isUnset(request.isPicTop)) {
      body["isPicTop"] = request.isPicTop;
    }

    if (!Util.isUnset(request.logo)) {
      body["logo"] = request.logo;
    }

    if (!Util.isUnset(request.orgName)) {
      body["orgName"] = request.orgName;
    }

    if (!Util.isUnset(request.picturePlayInterval)) {
      body["picturePlayInterval"] = request.picturePlayInterval;
    }

    if (!Util.isUnset(request.roomIds)) {
      body["roomIds"] = request.roomIds;
    }

    if (!Util.isUnset(request.showCalendarCard)) {
      body["showCalendarCard"] = request.showCalendarCard;
    }

    if (!Util.isUnset(request.showCalendarTitle)) {
      body["showCalendarTitle"] = request.showCalendarTitle;
    }

    if (!Util.isUnset(request.showFunctionCard)) {
      body["showFunctionCard"] = request.showFunctionCard;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.templateName)) {
      body["templateName"] = request.templateName;
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
      action: "UpdateDeviceCustomTemplate",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/devices/screens/templates`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateDeviceCustomTemplateResponse>(await this.execute(params, req, runtime), new UpdateDeviceCustomTemplateResponse({}));
  }

  /**
   * 更新自定义屏幕模板
   * 
   * @param request - UpdateDeviceCustomTemplateRequest
   * @returns UpdateDeviceCustomTemplateResponse
   */
  async updateDeviceCustomTemplate(request: UpdateDeviceCustomTemplateRequest): Promise<UpdateDeviceCustomTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDeviceCustomTemplateHeaders({ });
    return await this.updateDeviceCustomTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 更新会议室信息
   * 
   * @param request - UpdateMeetingRoomRequest
   * @param headers - UpdateMeetingRoomHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateMeetingRoomResponse
   */
  async updateMeetingRoomWithOptions(request: UpdateMeetingRoomRequest, headers: UpdateMeetingRoomHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMeetingRoomResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.enableCycleReservation)) {
      body["enableCycleReservation"] = request.enableCycleReservation;
    }

    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.isvRoomId)) {
      body["isvRoomId"] = request.isvRoomId;
    }

    if (!Util.isUnset(request.reservationAuthority)) {
      body["reservationAuthority"] = request.reservationAuthority;
    }

    if (!Util.isUnset(request.roomCapacity)) {
      body["roomCapacity"] = request.roomCapacity;
    }

    if (!Util.isUnset(request.roomId)) {
      body["roomId"] = request.roomId;
    }

    if (!Util.isUnset(request.roomLabelIds)) {
      body["roomLabelIds"] = request.roomLabelIds;
    }

    if (!Util.isUnset(request.roomLocation)) {
      body["roomLocation"] = request.roomLocation;
    }

    if (!Util.isUnset(request.roomName)) {
      body["roomName"] = request.roomName;
    }

    if (!Util.isUnset(request.roomPicture)) {
      body["roomPicture"] = request.roomPicture;
    }

    if (!Util.isUnset(request.roomStatus)) {
      body["roomStatus"] = request.roomStatus;
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
      action: "UpdateMeetingRoom",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/meetingRooms`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateMeetingRoomResponse>(await this.execute(params, req, runtime), new UpdateMeetingRoomResponse({}));
  }

  /**
   * 更新会议室信息
   * 
   * @param request - UpdateMeetingRoomRequest
   * @returns UpdateMeetingRoomResponse
   */
  async updateMeetingRoom(request: UpdateMeetingRoomRequest): Promise<UpdateMeetingRoomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMeetingRoomHeaders({ });
    return await this.updateMeetingRoomWithOptions(request, headers, runtime);
  }

  /**
   * 更新会议室分组
   * 
   * @param request - UpdateMeetingRoomGroupRequest
   * @param headers - UpdateMeetingRoomGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateMeetingRoomGroupResponse
   */
  async updateMeetingRoomGroupWithOptions(request: UpdateMeetingRoomGroupRequest, headers: UpdateMeetingRoomGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMeetingRoomGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
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
      action: "UpdateMeetingRoomGroup",
      version: "rooms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rooms/groups`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateMeetingRoomGroupResponse>(await this.execute(params, req, runtime), new UpdateMeetingRoomGroupResponse({}));
  }

  /**
   * 更新会议室分组
   * 
   * @param request - UpdateMeetingRoomGroupRequest
   * @returns UpdateMeetingRoomGroupResponse
   */
  async updateMeetingRoomGroup(request: UpdateMeetingRoomGroupRequest): Promise<UpdateMeetingRoomGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMeetingRoomGroupHeaders({ });
    return await this.updateMeetingRoomGroupWithOptions(request, headers, runtime);
  }

}
