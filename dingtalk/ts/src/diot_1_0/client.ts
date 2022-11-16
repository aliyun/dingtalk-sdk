// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BatchDeleteDeviceHeaders extends $tea.Model {
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

export class BatchDeleteDeviceRequest extends $tea.Model {
  corpId?: string;
  deviceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deviceIds: 'deviceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deviceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteDeviceResponseBody extends $tea.Model {
  deviceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceIds: 'deviceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchDeleteDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchDeleteDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceHeaders extends $tea.Model {
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

export class BatchRegisterDeviceRequest extends $tea.Model {
  corpId?: string;
  devices?: BatchRegisterDeviceRequestDevices[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      devices: 'devices',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      devices: { 'type': 'array', 'itemType': BatchRegisterDeviceRequestDevices },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceResponseBody extends $tea.Model {
  deviceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceIds: 'deviceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchRegisterDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchRegisterDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterEventTypeHeaders extends $tea.Model {
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

export class BatchRegisterEventTypeRequest extends $tea.Model {
  corpId?: string;
  eventTypes?: BatchRegisterEventTypeRequestEventTypes[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      eventTypes: 'eventTypes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      eventTypes: { 'type': 'array', 'itemType': BatchRegisterEventTypeRequestEventTypes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterEventTypeResponseBody extends $tea.Model {
  eventTypes?: string[];
  static names(): { [key: string]: string } {
    return {
      eventTypes: 'eventTypes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventTypes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterEventTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchRegisterEventTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchRegisterEventTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateDeviceHeaders extends $tea.Model {
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

export class BatchUpdateDeviceRequest extends $tea.Model {
  corpId?: string;
  devices?: BatchUpdateDeviceRequestDevices[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      devices: 'devices',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      devices: { 'type': 'array', 'itemType': BatchUpdateDeviceRequestDevices },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateDeviceResponseBody extends $tea.Model {
  deviceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deviceIds: 'deviceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchUpdateDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchUpdateDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindSystemHeaders extends $tea.Model {
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

export class BindSystemRequest extends $tea.Model {
  authCode?: string;
  clientId?: string;
  clientName?: string;
  corpId?: string;
  extraData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
      clientId: 'clientId',
      clientName: 'clientName',
      corpId: 'corpId',
      extraData: 'extraData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
      clientId: 'string',
      clientName: 'string',
      corpId: 'string',
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindSystemResponseBody extends $tea.Model {
  clientId?: string;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      clientId: 'clientId',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clientId: 'string',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindSystemResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BindSystemResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BindSystemResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceConferenceHeaders extends $tea.Model {
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

export class DeviceConferenceRequest extends $tea.Model {
  confTitle?: string;
  conferenceId?: string;
  conferencePassword?: string;
  deviceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      confTitle: 'confTitle',
      conferenceId: 'conferenceId',
      conferencePassword: 'conferencePassword',
      deviceIds: 'deviceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      confTitle: 'string',
      conferenceId: 'string',
      conferencePassword: 'string',
      deviceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceConferenceResponseBody extends $tea.Model {
  conferenceId?: string;
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeviceConferenceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeviceConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushEventHeaders extends $tea.Model {
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

export class PushEventRequest extends $tea.Model {
  corpId?: string;
  deviceId?: string;
  eventId?: string;
  eventName?: string;
  eventType?: string;
  extraData?: { [key: string]: any };
  location?: string;
  msg?: string;
  occurrenceTime?: number;
  picUrls?: string[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deviceId: 'deviceId',
      eventId: 'eventId',
      eventName: 'eventName',
      eventType: 'eventType',
      extraData: 'extraData',
      location: 'location',
      msg: 'msg',
      occurrenceTime: 'occurrenceTime',
      picUrls: 'picUrls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deviceId: 'string',
      eventId: 'string',
      eventName: 'string',
      eventType: 'string',
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      location: 'string',
      msg: 'string',
      occurrenceTime: 'number',
      picUrls: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushEventResponseBody extends $tea.Model {
  eventId?: string;
  static names(): { [key: string]: string } {
    return {
      eventId: 'eventId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PushEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PushEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceHeaders extends $tea.Model {
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

export class QueryDeviceRequest extends $tea.Model {
  corpId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceResponseBody extends $tea.Model {
  data?: QueryDeviceResponseBodyData[];
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': QueryDeviceResponseBodyData },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEventHeaders extends $tea.Model {
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

export class QueryEventRequest extends $tea.Model {
  corpId?: string;
  deviceIdList?: string[];
  endTime?: number;
  eventId?: string;
  eventStatusList?: number[];
  eventTypeList?: string[];
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deviceIdList: 'deviceIdList',
      endTime: 'endTime',
      eventId: 'eventId',
      eventStatusList: 'eventStatusList',
      eventTypeList: 'eventTypeList',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deviceIdList: { 'type': 'array', 'itemType': 'string' },
      endTime: 'number',
      eventId: 'string',
      eventStatusList: { 'type': 'array', 'itemType': 'number' },
      eventTypeList: { 'type': 'array', 'itemType': 'string' },
      pageNumber: 'number',
      pageSize: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEventResponseBody extends $tea.Model {
  data?: QueryEventResponseBodyData[];
  pageNumber?: number;
  pageSize?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': QueryEventResponseBodyData },
      pageNumber: 'number',
      pageSize: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEventResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryEventResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterDeviceHeaders extends $tea.Model {
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

export class RegisterDeviceRequest extends $tea.Model {
  corpId?: string;
  deviceName?: string;
  deviceStatus?: number;
  deviceType?: string;
  deviceTypeName?: string;
  id?: string;
  liveUrls?: RegisterDeviceRequestLiveUrls;
  location?: string;
  nickName?: string;
  parentId?: string;
  productType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deviceName: 'deviceName',
      deviceStatus: 'deviceStatus',
      deviceType: 'deviceType',
      deviceTypeName: 'deviceTypeName',
      id: 'id',
      liveUrls: 'liveUrls',
      location: 'location',
      nickName: 'nickName',
      parentId: 'parentId',
      productType: 'productType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deviceName: 'string',
      deviceStatus: 'number',
      deviceType: 'string',
      deviceTypeName: 'string',
      id: 'string',
      liveUrls: RegisterDeviceRequestLiveUrls,
      location: 'string',
      nickName: 'string',
      parentId: 'string',
      productType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterDeviceResponseBody extends $tea.Model {
  deviceId?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterDeviceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RegisterDeviceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RegisterDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceRequestDevicesLiveUrls extends $tea.Model {
  flv?: string;
  hls?: string;
  rtmp?: string;
  static names(): { [key: string]: string } {
    return {
      flv: 'flv',
      hls: 'hls',
      rtmp: 'rtmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flv: 'string',
      hls: 'string',
      rtmp: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceRequestDevices extends $tea.Model {
  deviceId?: string;
  deviceName?: string;
  deviceStatus?: number;
  deviceType?: string;
  deviceTypeName?: string;
  extraData?: { [key: string]: any };
  liveUrls?: BatchRegisterDeviceRequestDevicesLiveUrls;
  location?: string;
  parentId?: string;
  productType?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      deviceStatus: 'deviceStatus',
      deviceType: 'deviceType',
      deviceTypeName: 'deviceTypeName',
      extraData: 'extraData',
      liveUrls: 'liveUrls',
      location: 'location',
      parentId: 'parentId',
      productType: 'productType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'string',
      deviceName: 'string',
      deviceStatus: 'number',
      deviceType: 'string',
      deviceTypeName: 'string',
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      liveUrls: BatchRegisterDeviceRequestDevicesLiveUrls,
      location: 'string',
      parentId: 'string',
      productType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterEventTypeRequestEventTypes extends $tea.Model {
  eventType?: string;
  eventTypeName?: string;
  static names(): { [key: string]: string } {
    return {
      eventType: 'eventType',
      eventTypeName: 'eventTypeName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventType: 'string',
      eventTypeName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateDeviceRequestDevicesLiveUrls extends $tea.Model {
  flv?: string;
  hls?: string;
  rtmp?: string;
  static names(): { [key: string]: string } {
    return {
      flv: 'flv',
      hls: 'hls',
      rtmp: 'rtmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flv: 'string',
      hls: 'string',
      rtmp: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchUpdateDeviceRequestDevices extends $tea.Model {
  deviceId?: string;
  deviceName?: string;
  deviceStatus?: number;
  extraData?: { [key: string]: any };
  liveUrls?: BatchUpdateDeviceRequestDevicesLiveUrls;
  location?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      deviceStatus: 'deviceStatus',
      extraData: 'extraData',
      liveUrls: 'liveUrls',
      location: 'location',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'string',
      deviceName: 'string',
      deviceStatus: 'number',
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      liveUrls: BatchUpdateDeviceRequestDevicesLiveUrls,
      location: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceResponseBodyDataLiveUrls extends $tea.Model {
  flv?: string;
  hls?: string;
  rtmp?: string;
  static names(): { [key: string]: string } {
    return {
      flv: 'flv',
      hls: 'hls',
      rtmp: 'rtmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flv: 'string',
      hls: 'string',
      rtmp: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDeviceResponseBodyData extends $tea.Model {
  deviceId?: string;
  deviceName?: string;
  deviceStatus?: number;
  deviceType?: string;
  deviceTypeName?: string;
  liveUrls?: QueryDeviceResponseBodyDataLiveUrls;
  location?: string;
  parentId?: string;
  productType?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      deviceStatus: 'deviceStatus',
      deviceType: 'deviceType',
      deviceTypeName: 'deviceTypeName',
      liveUrls: 'liveUrls',
      location: 'location',
      parentId: 'parentId',
      productType: 'productType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'string',
      deviceName: 'string',
      deviceStatus: 'number',
      deviceType: 'string',
      deviceTypeName: 'string',
      liveUrls: QueryDeviceResponseBodyDataLiveUrls,
      location: 'string',
      parentId: 'string',
      productType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEventResponseBodyData extends $tea.Model {
  eventId?: string;
  eventName?: string;
  eventStatus?: number;
  eventType?: string;
  msg?: string;
  occurrenceTime?: number;
  picUrls?: string[];
  static names(): { [key: string]: string } {
    return {
      eventId: 'eventId',
      eventName: 'eventName',
      eventStatus: 'eventStatus',
      eventType: 'eventType',
      msg: 'msg',
      occurrenceTime: 'occurrenceTime',
      picUrls: 'picUrls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventId: 'string',
      eventName: 'string',
      eventStatus: 'number',
      eventType: 'string',
      msg: 'string',
      occurrenceTime: 'number',
      picUrls: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterDeviceRequestLiveUrls extends $tea.Model {
  flv?: string;
  hls?: string;
  rtmp?: string;
  static names(): { [key: string]: string } {
    return {
      flv: 'flv',
      hls: 'hls',
      rtmp: 'rtmp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flv: 'string',
      hls: 'string',
      rtmp: 'string',
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


  async batchDeleteDevice(request: BatchDeleteDeviceRequest): Promise<BatchDeleteDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchDeleteDeviceHeaders({ });
    return await this.batchDeleteDeviceWithOptions(request, headers, runtime);
  }

  async batchDeleteDeviceWithOptions(request: BatchDeleteDeviceRequest, headers: BatchDeleteDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<BatchDeleteDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deviceIds)) {
      body["deviceIds"] = request.deviceIds;
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
    return $tea.cast<BatchDeleteDeviceResponse>(await this.doROARequest("BatchDeleteDevice", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/devices/remove`, "json", req, runtime), new BatchDeleteDeviceResponse({}));
  }

  async batchRegisterDevice(request: BatchRegisterDeviceRequest): Promise<BatchRegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRegisterDeviceHeaders({ });
    return await this.batchRegisterDeviceWithOptions(request, headers, runtime);
  }

  async batchRegisterDeviceWithOptions(request: BatchRegisterDeviceRequest, headers: BatchRegisterDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRegisterDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.devices)) {
      body["devices"] = request.devices;
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
    return $tea.cast<BatchRegisterDeviceResponse>(await this.doROARequest("BatchRegisterDevice", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/devices/registrations/batch`, "json", req, runtime), new BatchRegisterDeviceResponse({}));
  }

  async batchRegisterEventType(request: BatchRegisterEventTypeRequest): Promise<BatchRegisterEventTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRegisterEventTypeHeaders({ });
    return await this.batchRegisterEventTypeWithOptions(request, headers, runtime);
  }

  async batchRegisterEventTypeWithOptions(request: BatchRegisterEventTypeRequest, headers: BatchRegisterEventTypeHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRegisterEventTypeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.eventTypes)) {
      body["eventTypes"] = request.eventTypes;
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
    return $tea.cast<BatchRegisterEventTypeResponse>(await this.doROARequest("BatchRegisterEventType", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/eventTypes/registrations/batch`, "json", req, runtime), new BatchRegisterEventTypeResponse({}));
  }

  async batchUpdateDevice(request: BatchUpdateDeviceRequest): Promise<BatchUpdateDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateDeviceHeaders({ });
    return await this.batchUpdateDeviceWithOptions(request, headers, runtime);
  }

  async batchUpdateDeviceWithOptions(request: BatchUpdateDeviceRequest, headers: BatchUpdateDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<BatchUpdateDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.devices)) {
      body["devices"] = request.devices;
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
    return $tea.cast<BatchUpdateDeviceResponse>(await this.doROARequest("BatchUpdateDevice", "diot_1.0", "HTTP", "PUT", "AK", `/v1.0/diot/devices/batch`, "json", req, runtime), new BatchUpdateDeviceResponse({}));
  }

  async bindSystem(request: BindSystemRequest): Promise<BindSystemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BindSystemHeaders({ });
    return await this.bindSystemWithOptions(request, headers, runtime);
  }

  async bindSystemWithOptions(request: BindSystemRequest, headers: BindSystemHeaders, runtime: $Util.RuntimeOptions): Promise<BindSystemResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.clientId)) {
      body["clientId"] = request.clientId;
    }

    if (!Util.isUnset(request.clientName)) {
      body["clientName"] = request.clientName;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extraData)) {
      body["extraData"] = request.extraData;
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
    return $tea.cast<BindSystemResponse>(await this.doROARequest("BindSystem", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/systems/bind`, "json", req, runtime), new BindSystemResponse({}));
  }

  async deviceConference(request: DeviceConferenceRequest): Promise<DeviceConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeviceConferenceHeaders({ });
    return await this.deviceConferenceWithOptions(request, headers, runtime);
  }

  async deviceConferenceWithOptions(request: DeviceConferenceRequest, headers: DeviceConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<DeviceConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.confTitle)) {
      body["confTitle"] = request.confTitle;
    }

    if (!Util.isUnset(request.conferenceId)) {
      body["conferenceId"] = request.conferenceId;
    }

    if (!Util.isUnset(request.conferencePassword)) {
      body["conferencePassword"] = request.conferencePassword;
    }

    if (!Util.isUnset(request.deviceIds)) {
      body["deviceIds"] = request.deviceIds;
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
    return $tea.cast<DeviceConferenceResponse>(await this.doROARequest("DeviceConference", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/deviceConferences/initiate`, "json", req, runtime), new DeviceConferenceResponse({}));
  }

  async pushEvent(request: PushEventRequest): Promise<PushEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushEventHeaders({ });
    return await this.pushEventWithOptions(request, headers, runtime);
  }

  async pushEventWithOptions(request: PushEventRequest, headers: PushEventHeaders, runtime: $Util.RuntimeOptions): Promise<PushEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.eventId)) {
      body["eventId"] = request.eventId;
    }

    if (!Util.isUnset(request.eventName)) {
      body["eventName"] = request.eventName;
    }

    if (!Util.isUnset(request.eventType)) {
      body["eventType"] = request.eventType;
    }

    if (!Util.isUnset(request.extraData)) {
      body["extraData"] = request.extraData;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.msg)) {
      body["msg"] = request.msg;
    }

    if (!Util.isUnset(request.occurrenceTime)) {
      body["occurrenceTime"] = request.occurrenceTime;
    }

    if (!Util.isUnset(request.picUrls)) {
      body["picUrls"] = request.picUrls;
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
    return $tea.cast<PushEventResponse>(await this.doROARequest("PushEvent", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/events/push`, "json", req, runtime), new PushEventResponse({}));
  }

  async queryDevice(request: QueryDeviceRequest): Promise<QueryDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceHeaders({ });
    return await this.queryDeviceWithOptions(request, headers, runtime);
  }

  async queryDeviceWithOptions(request: QueryDeviceRequest, headers: QueryDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDeviceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryDeviceResponse>(await this.doROARequest("QueryDevice", "diot_1.0", "HTTP", "GET", "AK", `/v1.0/diot/devices`, "json", req, runtime), new QueryDeviceResponse({}));
  }

  async queryEvent(request: QueryEventRequest): Promise<QueryEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEventHeaders({ });
    return await this.queryEventWithOptions(request, headers, runtime);
  }

  async queryEventWithOptions(request: QueryEventRequest, headers: QueryEventHeaders, runtime: $Util.RuntimeOptions): Promise<QueryEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deviceIdList)) {
      body["deviceIdList"] = request.deviceIdList;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.eventId)) {
      body["eventId"] = request.eventId;
    }

    if (!Util.isUnset(request.eventStatusList)) {
      body["eventStatusList"] = request.eventStatusList;
    }

    if (!Util.isUnset(request.eventTypeList)) {
      body["eventTypeList"] = request.eventTypeList;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
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
    return $tea.cast<QueryEventResponse>(await this.doROARequest("QueryEvent", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/events/query`, "json", req, runtime), new QueryEventResponse({}));
  }

  async registerDevice(request: RegisterDeviceRequest): Promise<RegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterDeviceHeaders({ });
    return await this.registerDeviceWithOptions(request, headers, runtime);
  }

  async registerDeviceWithOptions(request: RegisterDeviceRequest, headers: RegisterDeviceHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterDeviceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deviceName)) {
      body["deviceName"] = request.deviceName;
    }

    if (!Util.isUnset(request.deviceStatus)) {
      body["deviceStatus"] = request.deviceStatus;
    }

    if (!Util.isUnset(request.deviceType)) {
      body["deviceType"] = request.deviceType;
    }

    if (!Util.isUnset(request.deviceTypeName)) {
      body["deviceTypeName"] = request.deviceTypeName;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset($tea.toMap(request.liveUrls))) {
      body["liveUrls"] = request.liveUrls;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.nickName)) {
      body["nickName"] = request.nickName;
    }

    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.productType)) {
      body["productType"] = request.productType;
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
    return $tea.cast<RegisterDeviceResponse>(await this.doROARequest("RegisterDevice", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/devices/register`, "json", req, runtime), new RegisterDeviceResponse({}));
  }

}
