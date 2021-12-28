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
  eventId?: string;
  eventType?: string;
  eventName?: string;
  occurrenceTime?: number;
  deviceId?: string;
  location?: string;
  msg?: string;
  picUrls?: string[];
  extraData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      eventId: 'eventId',
      eventType: 'eventType',
      eventName: 'eventName',
      occurrenceTime: 'occurrenceTime',
      deviceId: 'deviceId',
      location: 'location',
      msg: 'msg',
      picUrls: 'picUrls',
      extraData: 'extraData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      eventId: 'string',
      eventType: 'string',
      eventName: 'string',
      occurrenceTime: 'number',
      deviceId: 'string',
      location: 'string',
      msg: 'string',
      picUrls: { 'type': 'array', 'itemType': 'string' },
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
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
  id?: string;
  deviceName?: string;
  nickName?: string;
  location?: string;
  deviceStatus?: number;
  deviceType?: string;
  deviceTypeName?: string;
  parentId?: string;
  productType?: string;
  liveUrl?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      deviceName: 'deviceName',
      nickName: 'nickName',
      location: 'location',
      deviceStatus: 'deviceStatus',
      deviceType: 'deviceType',
      deviceTypeName: 'deviceTypeName',
      parentId: 'parentId',
      productType: 'productType',
      liveUrl: 'liveUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'string',
      deviceName: 'string',
      nickName: 'string',
      location: 'string',
      deviceStatus: 'number',
      deviceType: 'string',
      deviceTypeName: 'string',
      parentId: 'string',
      productType: 'string',
      liveUrl: 'string',
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
  corpId?: string;
  authCode?: string;
  clientId?: string;
  clientName?: string;
  extraData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      authCode: 'authCode',
      clientId: 'clientId',
      clientName: 'clientName',
      extraData: 'extraData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      authCode: 'string',
      clientId: 'string',
      clientName: 'string',
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindSystemResponseBody extends $tea.Model {
  corpId?: string;
  clientId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      clientId: 'clientId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      clientId: 'string',
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

export class BatchRegisterDeviceRequestDevices extends $tea.Model {
  deviceId?: string;
  deviceName?: string;
  deviceStatus?: number;
  deviceType?: string;
  deviceTypeName?: string;
  productType?: string;
  liveUrl?: string;
  parentId?: string;
  location?: string;
  extraData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      deviceStatus: 'deviceStatus',
      deviceType: 'deviceType',
      deviceTypeName: 'deviceTypeName',
      productType: 'productType',
      liveUrl: 'liveUrl',
      parentId: 'parentId',
      location: 'location',
      extraData: 'extraData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'string',
      deviceName: 'string',
      deviceStatus: 'number',
      deviceType: 'string',
      deviceTypeName: 'string',
      productType: 'string',
      liveUrl: 'string',
      parentId: 'string',
      location: 'string',
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
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

export class BatchUpdateDeviceRequestDevices extends $tea.Model {
  deviceId?: string;
  deviceName?: string;
  location?: string;
  deviceStatus?: number;
  liveUrl?: string;
  extraData?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      location: 'location',
      deviceStatus: 'deviceStatus',
      liveUrl: 'liveUrl',
      extraData: 'extraData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'string',
      deviceName: 'string',
      location: 'string',
      deviceStatus: 'number',
      liveUrl: 'string',
      extraData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<BatchDeleteDeviceResponse>(await this.doROARequest("BatchDeleteDevice", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/devices/remove`, "json", req, runtime), new BatchDeleteDeviceResponse({}));
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

    if (!Util.isUnset(request.eventId)) {
      body["eventId"] = request.eventId;
    }

    if (!Util.isUnset(request.eventType)) {
      body["eventType"] = request.eventType;
    }

    if (!Util.isUnset(request.eventName)) {
      body["eventName"] = request.eventName;
    }

    if (!Util.isUnset(request.occurrenceTime)) {
      body["occurrenceTime"] = request.occurrenceTime;
    }

    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.msg)) {
      body["msg"] = request.msg;
    }

    if (!Util.isUnset(request.picUrls)) {
      body["picUrls"] = request.picUrls;
    }

    if (!Util.isUnset(request.extraData)) {
      body["extraData"] = request.extraData;
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
    return $tea.cast<PushEventResponse>(await this.doROARequest("PushEvent", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/events/push`, "json", req, runtime), new PushEventResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<DeviceConferenceResponse>(await this.doROARequest("DeviceConference", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/deviceConferences/initiate`, "json", req, runtime), new DeviceConferenceResponse({}));
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

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.deviceName)) {
      body["deviceName"] = request.deviceName;
    }

    if (!Util.isUnset(request.nickName)) {
      body["nickName"] = request.nickName;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
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

    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.productType)) {
      body["productType"] = request.productType;
    }

    if (!Util.isUnset(request.liveUrl)) {
      body["liveUrl"] = request.liveUrl;
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
    return $tea.cast<RegisterDeviceResponse>(await this.doROARequest("RegisterDevice", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/devices/register`, "json", req, runtime), new RegisterDeviceResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
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
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.clientId)) {
      body["clientId"] = request.clientId;
    }

    if (!Util.isUnset(request.clientName)) {
      body["clientName"] = request.clientName;
    }

    if (!Util.isUnset(request.extraData)) {
      body["extraData"] = request.extraData;
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
    return $tea.cast<BindSystemResponse>(await this.doROARequest("BindSystem", "diot_1.0", "HTTP", "POST", "AK", `/v1.0/diot/systems/bind`, "json", req, runtime), new BindSystemResponse({}));
  }

}
