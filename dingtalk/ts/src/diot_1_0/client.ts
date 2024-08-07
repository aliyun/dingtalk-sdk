// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AyunOnlienTestRequest extends $tea.Model {
  reqId?: string;
  static names(): { [key: string]: string } {
    return {
      reqId: 'reqId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      reqId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AyunOnlienTestResponseBody extends $tea.Model {
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

export class AyunOnlienTestResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AyunOnlienTestResponseBody;
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
      body: AyunOnlienTestResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  /**
   * @example
   * ding12345
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchDeleteDeviceResponseBody;
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
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchRegisterDeviceResponseBody;
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
  /**
   * @example
   * ding12345
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchRegisterEventTypeResponseBody;
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
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchUpdateDeviceResponseBody;
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
  /**
   * @example
   * abcde12345
   */
  authCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * d12345
   */
  clientId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xx社区。
   */
  clientName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding12345
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * d12345
   */
  clientId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding12345
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BindSystemResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 设备的应急会议
   */
  confTitle?: string;
  /**
   * @example
   * 12345678
   */
  conferenceId?: string;
  /**
   * @example
   * 123456
   */
  conferencePassword?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 123456789
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeviceConferenceResponseBody;
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
      body: DeviceConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotMamaResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotMamaResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DiotMamaResponseBody;
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
      body: DiotMamaResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotMarketManagerTestResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotMarketManagerTestResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DiotMarketManagerTestResponseBody;
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
      body: DiotMarketManagerTestResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotSystemMarkTestResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotSystemMarkTestResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DiotSystemMarkTestResponseBody;
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
      body: DiotSystemMarkTestResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotMarketManagerResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DiotMarketManagerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DiotMarketManagerResponseBody;
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
      body: DiotMarketManagerResponseBody,
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
  /**
   * @example
   * ding123456
   */
  corpId?: string;
  /**
   * @example
   * 002
   */
  deviceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sj123456
   */
  eventId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 火焰告警
   */
  eventName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fireDetect
   */
  eventType?: string;
  extraData?: { [key: string]: any };
  /**
   * @example
   * 社区南门
   */
  location?: string;
  /**
   * @example
   * 社区南门发生火焰告警
   */
  msg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1638250958570
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PushEventResponseBody;
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
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  data?: QueryDeviceResponseBodyData[];
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @example
   * 40
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDeviceResponseBody;
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
      body: QueryDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDevicePkHeaders extends $tea.Model {
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

export class QueryDevicePkRequest extends $tea.Model {
  deviceId?: number;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDevicePkResponseBody extends $tea.Model {
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

export class QueryDevicePkResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDevicePkResponseBody;
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
      body: QueryDevicePkResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryEventResponseBody;
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
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 摄像头1
   */
  deviceName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  deviceStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Camera
   */
  deviceType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 摄像头
   */
  deviceTypeName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 002
   */
  id?: string;
  liveUrls?: RegisterDeviceRequestLiveUrls;
  /**
   * @example
   * 东南门
   */
  location?: string;
  /**
   * @example
   * 摄像头1
   */
  nickName?: string;
  /**
   * @example
   * 001
   */
  parentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CAMERA
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RegisterDeviceResponseBody;
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
      body: RegisterDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeDeviceResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeDeviceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpgradeDeviceResponseBody;
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
      body: UpgradeDeviceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WorkbenchTransformInfoResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class WorkbenchTransformInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: WorkbenchTransformInfoResponseBody;
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
      body: WorkbenchTransformInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRegisterDeviceRequestDevicesLiveUrls extends $tea.Model {
  /**
   * @example
   * https://abc.stream.flv
   */
  flv?: string;
  /**
   * @example
   * https://abc.stream.m3u8
   */
  hls?: string;
  /**
   * @example
   * rtmp://abc.stream
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 002
   */
  deviceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 摄像头002
   */
  deviceName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  deviceStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Camera
   */
  deviceType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 摄像头
   */
  deviceTypeName?: string;
  extraData?: { [key: string]: any };
  liveUrls?: BatchRegisterDeviceRequestDevicesLiveUrls;
  /**
   * @example
   * 社区南门
   */
  location?: string;
  /**
   * @example
   * 001
   */
  parentId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CAMERA
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fireDetect
   */
  eventType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 火焰告警
   */
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
  /**
   * @example
   * https://abc.stream.flv
   */
  flv?: string;
  /**
   * @example
   * https://abc.stream.m3u8
   */
  hls?: string;
  /**
   * @example
   * rtmp://abc.stream
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 002
   */
  deviceId?: string;
  /**
   * @example
   * 摄像头002
   */
  deviceName?: string;
  /**
   * @example
   * 0
   */
  deviceStatus?: number;
  extraData?: { [key: string]: any };
  liveUrls?: BatchUpdateDeviceRequestDevicesLiveUrls;
  /**
   * @example
   * 社区南门
   */
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
  /**
   * @example
   * https://abc.stream.flv
   */
  flv?: string;
  /**
   * @example
   * https://abc.stream.m3u8
   */
  hls?: string;
  /**
   * @example
   * rtmp://abc.stream
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  deviceId?: string;
  /**
   * @example
   * XX摄像头
   */
  deviceName?: string;
  /**
   * @example
   * 0
   */
  deviceStatus?: number;
  /**
   * @example
   * CAMERA
   */
  deviceType?: string;
  /**
   * @example
   * 摄像头
   */
  deviceTypeName?: string;
  liveUrls?: QueryDeviceResponseBodyDataLiveUrls;
  /**
   * @example
   * XX地址
   */
  location?: string;
  /**
   * @example
   * 123
   */
  parentId?: string;
  /**
   * @example
   * CAMERA
   */
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
  /**
   * @example
   * https://abc.stream.flv
   */
  flv?: string;
  /**
   * @example
   * https://abc.stream.m3u8
   */
  hls?: string;
  /**
   * @example
   * rtmp://abc.stream
   */
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * openAPI录入上线前的测试2
   * 
   * @param request - AyunOnlienTestRequest
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AyunOnlienTestResponse
   */
  async ayunOnlienTestWithOptions(request: AyunOnlienTestRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<AyunOnlienTestResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.reqId)) {
      query["reqId"] = request.reqId;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "AyunOnlienTest",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/ayunTest`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AyunOnlienTestResponse>(await this.execute(params, req, runtime), new AyunOnlienTestResponse({}));
  }

  /**
   * openAPI录入上线前的测试2
   * 
   * @param request - AyunOnlienTestRequest
   * @returns AyunOnlienTestResponse
   */
  async ayunOnlienTest(request: AyunOnlienTestRequest): Promise<AyunOnlienTestResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.ayunOnlienTestWithOptions(request, headers, runtime);
  }

  /**
   * 删除设备
   * 
   * @param request - BatchDeleteDeviceRequest
   * @param headers - BatchDeleteDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchDeleteDeviceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BatchDeleteDevice",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/devices/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchDeleteDeviceResponse>(await this.execute(params, req, runtime), new BatchDeleteDeviceResponse({}));
  }

  /**
   * 删除设备
   * 
   * @param request - BatchDeleteDeviceRequest
   * @returns BatchDeleteDeviceResponse
   */
  async batchDeleteDevice(request: BatchDeleteDeviceRequest): Promise<BatchDeleteDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchDeleteDeviceHeaders({ });
    return await this.batchDeleteDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 批量注册设备
   * 
   * @param request - BatchRegisterDeviceRequest
   * @param headers - BatchRegisterDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchRegisterDeviceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BatchRegisterDevice",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/devices/registrations/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchRegisterDeviceResponse>(await this.execute(params, req, runtime), new BatchRegisterDeviceResponse({}));
  }

  /**
   * 批量注册设备
   * 
   * @param request - BatchRegisterDeviceRequest
   * @returns BatchRegisterDeviceResponse
   */
  async batchRegisterDevice(request: BatchRegisterDeviceRequest): Promise<BatchRegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRegisterDeviceHeaders({ });
    return await this.batchRegisterDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 批量注册事件类型
   * 
   * @param request - BatchRegisterEventTypeRequest
   * @param headers - BatchRegisterEventTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchRegisterEventTypeResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BatchRegisterEventType",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/eventTypes/registrations/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchRegisterEventTypeResponse>(await this.execute(params, req, runtime), new BatchRegisterEventTypeResponse({}));
  }

  /**
   * 批量注册事件类型
   * 
   * @param request - BatchRegisterEventTypeRequest
   * @returns BatchRegisterEventTypeResponse
   */
  async batchRegisterEventType(request: BatchRegisterEventTypeRequest): Promise<BatchRegisterEventTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRegisterEventTypeHeaders({ });
    return await this.batchRegisterEventTypeWithOptions(request, headers, runtime);
  }

  /**
   * 批量修改设备
   * 
   * @param request - BatchUpdateDeviceRequest
   * @param headers - BatchUpdateDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchUpdateDeviceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BatchUpdateDevice",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/devices/batch`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchUpdateDeviceResponse>(await this.execute(params, req, runtime), new BatchUpdateDeviceResponse({}));
  }

  /**
   * 批量修改设备
   * 
   * @param request - BatchUpdateDeviceRequest
   * @returns BatchUpdateDeviceResponse
   */
  async batchUpdateDevice(request: BatchUpdateDeviceRequest): Promise<BatchUpdateDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchUpdateDeviceHeaders({ });
    return await this.batchUpdateDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 系统绑定
   * 
   * @param request - BindSystemRequest
   * @param headers - BindSystemHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BindSystemResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BindSystem",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/systems/bind`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BindSystemResponse>(await this.execute(params, req, runtime), new BindSystemResponse({}));
  }

  /**
   * 系统绑定
   * 
   * @param request - BindSystemRequest
   * @returns BindSystemResponse
   */
  async bindSystem(request: BindSystemRequest): Promise<BindSystemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BindSystemHeaders({ });
    return await this.bindSystemWithOptions(request, headers, runtime);
  }

  /**
   * 发起设备会议
   * 
   * @param request - DeviceConferenceRequest
   * @param headers - DeviceConferenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeviceConferenceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "DeviceConference",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/deviceConferences/initiate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeviceConferenceResponse>(await this.execute(params, req, runtime), new DeviceConferenceResponse({}));
  }

  /**
   * 发起设备会议
   * 
   * @param request - DeviceConferenceRequest
   * @returns DeviceConferenceResponse
   */
  async deviceConference(request: DeviceConferenceRequest): Promise<DeviceConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeviceConferenceHeaders({ });
    return await this.deviceConferenceWithOptions(request, headers, runtime);
  }

  /**
   * 钉钉物联Mama接口
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DiotMamaResponse
   */
  async diotMamaWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<DiotMamaResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "DiotMama",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DiotMamaResponse>(await this.execute(params, req, runtime), new DiotMamaResponse({}));
  }

  /**
   * 钉钉物联Mama接口
   * @returns DiotMamaResponse
   */
  async diotMama(): Promise<DiotMamaResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.diotMamaWithOptions(headers, runtime);
  }

  /**
   * diot官方市场处理
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DiotMarketManagerTestResponse
   */
  async diotMarketManagerTestWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<DiotMarketManagerTestResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "DiotMarketManagerTest",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/market/manager/test`,
      method: "PUT",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DiotMarketManagerTestResponse>(await this.execute(params, req, runtime), new DiotMarketManagerTestResponse({}));
  }

  /**
   * diot官方市场处理
   * @returns DiotMarketManagerTestResponse
   */
  async diotMarketManagerTest(): Promise<DiotMarketManagerTestResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.diotMarketManagerTestWithOptions(headers, runtime);
  }

  /**
   * 钉钉物联系统测试
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DiotSystemMarkTestResponse
   */
  async diotSystemMarkTestWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<DiotSystemMarkTestResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "DiotSystemMarkTest",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/sys/mark/test`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DiotSystemMarkTestResponse>(await this.execute(params, req, runtime), new DiotSystemMarkTestResponse({}));
  }

  /**
   * 钉钉物联系统测试
   * @returns DiotSystemMarkTestResponse
   */
  async diotSystemMarkTest(): Promise<DiotSystemMarkTestResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.diotSystemMarkTestWithOptions(headers, runtime);
  }

  /**
   * 钉钉物联市场管理
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DiotMarketManagerResponse
   */
  async diot_Market_ManagerWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<DiotMarketManagerResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "Diot_Market_Manager",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/market/manager`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DiotMarketManagerResponse>(await this.execute(params, req, runtime), new DiotMarketManagerResponse({}));
  }

  /**
   * 钉钉物联市场管理
   * @returns DiotMarketManagerResponse
   */
  async diot_Market_Manager(): Promise<DiotMarketManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.diot_Market_ManagerWithOptions(headers, runtime);
  }

  /**
   * 推送事件
   * 
   * @param request - PushEventRequest
   * @param headers - PushEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PushEventResponse
   */
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
    let params = new $OpenApi.Params({
      action: "PushEvent",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/events/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushEventResponse>(await this.execute(params, req, runtime), new PushEventResponse({}));
  }

  /**
   * 推送事件
   * 
   * @param request - PushEventRequest
   * @returns PushEventResponse
   */
  async pushEvent(request: PushEventRequest): Promise<PushEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushEventHeaders({ });
    return await this.pushEventWithOptions(request, headers, runtime);
  }

  /**
   * 查询设备
   * 
   * @param request - QueryDeviceRequest
   * @param headers - QueryDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDeviceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryDevice",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/devices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDeviceResponse>(await this.execute(params, req, runtime), new QueryDeviceResponse({}));
  }

  /**
   * 查询设备
   * 
   * @param request - QueryDeviceRequest
   * @returns QueryDeviceResponse
   */
  async queryDevice(request: QueryDeviceRequest): Promise<QueryDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDeviceHeaders({ });
    return await this.queryDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 查询硬件设备的PK值信息
   * 
   * @param request - QueryDevicePkRequest
   * @param headers - QueryDevicePkHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDevicePkResponse
   */
  async queryDevicePkWithOptions(request: QueryDevicePkRequest, headers: QueryDevicePkHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDevicePkResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
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
      action: "QueryDevicePk",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/devices/pkInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDevicePkResponse>(await this.execute(params, req, runtime), new QueryDevicePkResponse({}));
  }

  /**
   * 查询硬件设备的PK值信息
   * 
   * @param request - QueryDevicePkRequest
   * @returns QueryDevicePkResponse
   */
  async queryDevicePk(request: QueryDevicePkRequest): Promise<QueryDevicePkResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDevicePkHeaders({ });
    return await this.queryDevicePkWithOptions(request, headers, runtime);
  }

  /**
   * 查询事件
   * 
   * @param request - QueryEventRequest
   * @param headers - QueryEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryEventResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryEvent",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/events/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryEventResponse>(await this.execute(params, req, runtime), new QueryEventResponse({}));
  }

  /**
   * 查询事件
   * 
   * @param request - QueryEventRequest
   * @returns QueryEventResponse
   */
  async queryEvent(request: QueryEventRequest): Promise<QueryEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEventHeaders({ });
    return await this.queryEventWithOptions(request, headers, runtime);
  }

  /**
   * 注册设备
   * 
   * @param request - RegisterDeviceRequest
   * @param headers - RegisterDeviceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RegisterDeviceResponse
   */
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

    if (!Util.isUnset(request.liveUrls)) {
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
    let params = new $OpenApi.Params({
      action: "RegisterDevice",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/devices/register`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RegisterDeviceResponse>(await this.execute(params, req, runtime), new RegisterDeviceResponse({}));
  }

  /**
   * 注册设备
   * 
   * @param request - RegisterDeviceRequest
   * @returns RegisterDeviceResponse
   */
  async registerDevice(request: RegisterDeviceRequest): Promise<RegisterDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterDeviceHeaders({ });
    return await this.registerDeviceWithOptions(request, headers, runtime);
  }

  /**
   * 升级设备
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpgradeDeviceResponse
   */
  async upgradeDeviceWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<UpgradeDeviceResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "UpgradeDevice",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/upgrade/device`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpgradeDeviceResponse>(await this.execute(params, req, runtime), new UpgradeDeviceResponse({}));
  }

  /**
   * 升级设备
   * @returns UpgradeDeviceResponse
   */
  async upgradeDevice(): Promise<UpgradeDeviceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.upgradeDeviceWithOptions(headers, runtime);
  }

  /**
   * 获取工作台流转物联信息
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns WorkbenchTransformInfoResponse
   */
  async workbenchTransformInfoWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<WorkbenchTransformInfoResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "WorkbenchTransformInfo",
      version: "diot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/diot/workbench/transform`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<WorkbenchTransformInfoResponse>(await this.execute(params, req, runtime), new WorkbenchTransformInfoResponse({}));
  }

  /**
   * 获取工作台流转物联信息
   * @returns WorkbenchTransformInfoResponse
   */
  async workbenchTransformInfo(): Promise<WorkbenchTransformInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.workbenchTransformInfoWithOptions(headers, runtime);
  }

}
