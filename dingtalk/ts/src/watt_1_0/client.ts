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

export class CheckInCrowdsByMobileRequest extends $tea.Model {
  crowdIds?: Buffer;
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      crowdIds: 'crowdIds',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      crowdIds: 'Buffer',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckInCrowdsByMobileResponseBody extends $tea.Model {
  data?: boolean;
  success?: boolean;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'boolean',
      success: 'boolean',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckInCrowdsByMobileResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CheckInCrowdsByMobileResponseBody;
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
      body: CheckInCrowdsByMobileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendBannerHeaders extends $tea.Model {
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

export class SendBannerRequest extends $tea.Model {
  content?: { [key: string]: any };
  endTime?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      endTime: 'endTime',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      endTime: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendBannerResponseBody extends $tea.Model {
  arguments?: any[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'any' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendBannerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendBannerResponseBody;
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
      body: SendBannerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPopupHeaders extends $tea.Model {
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

export class SendPopupRequest extends $tea.Model {
  content?: { [key: string]: any };
  endTime?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      endTime: 'endTime',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      endTime: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPopupResponseBody extends $tea.Model {
  arguments?: any[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'any' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPopupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendPopupResponseBody;
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
      body: SendPopupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendSearchShadeHeaders extends $tea.Model {
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

export class SendSearchShadeRequest extends $tea.Model {
  content?: { [key: string]: any };
  endTime?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      endTime: 'endTime',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      endTime: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendSearchShadeResponseBody extends $tea.Model {
  arguments?: any[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'any' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendSearchShadeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendSearchShadeResponseBody;
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
      body: SendSearchShadeResponseBody,
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
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async checkInCrowdsByMobileWithOptions(request: CheckInCrowdsByMobileRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<CheckInCrowdsByMobileResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.crowdIds)) {
      query["crowdIds"] = request.crowdIds;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "CheckInCrowdsByMobile",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/crowdIdentifications/query`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CheckInCrowdsByMobileResponse>(await this.execute(params, req, runtime), new CheckInCrowdsByMobileResponse({}));
  }

  async checkInCrowdsByMobile(request: CheckInCrowdsByMobileRequest): Promise<CheckInCrowdsByMobileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.checkInCrowdsByMobileWithOptions(request, headers, runtime);
  }

  async sendBannerWithOptions(request: SendBannerRequest, headers: SendBannerHeaders, runtime: $Util.RuntimeOptions): Promise<SendBannerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
      action: "SendBanner",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/banners/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendBannerResponse>(await this.execute(params, req, runtime), new SendBannerResponse({}));
  }

  async sendBanner(request: SendBannerRequest): Promise<SendBannerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendBannerHeaders({ });
    return await this.sendBannerWithOptions(request, headers, runtime);
  }

  async sendPopupWithOptions(request: SendPopupRequest, headers: SendPopupHeaders, runtime: $Util.RuntimeOptions): Promise<SendPopupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
      action: "SendPopup",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/popups/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendPopupResponse>(await this.execute(params, req, runtime), new SendPopupResponse({}));
  }

  async sendPopup(request: SendPopupRequest): Promise<SendPopupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendPopupHeaders({ });
    return await this.sendPopupWithOptions(request, headers, runtime);
  }

  async sendSearchShadeWithOptions(request: SendSearchShadeRequest, headers: SendSearchShadeHeaders, runtime: $Util.RuntimeOptions): Promise<SendSearchShadeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
      action: "SendSearchShade",
      version: "watt_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/watt/searchShades/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendSearchShadeResponse>(await this.execute(params, req, runtime), new SendSearchShadeResponse({}));
  }

  async sendSearchShade(request: SendSearchShadeRequest): Promise<SendSearchShadeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendSearchShadeHeaders({ });
    return await this.sendSearchShadeWithOptions(request, headers, runtime);
  }

}
