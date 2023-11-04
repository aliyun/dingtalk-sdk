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

export class GetCallBackFaileResultHeaders extends $tea.Model {
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

export class GetCallBackFaileResultRequest extends $tea.Model {
  beginTime?: number;
  endTime?: number;
  static names(): { [key: string]: string } {
    return {
      beginTime: 'beginTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      beginTime: 'number',
      endTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCallBackFaileResultResponseBody extends $tea.Model {
  failedList?: GetCallBackFaileResultResponseBodyFailedList[];
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      failedList: 'failedList',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedList: { 'type': 'array', 'itemType': GetCallBackFaileResultResponseBodyFailedList },
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCallBackFaileResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCallBackFaileResultResponseBody;
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
      body: GetCallBackFaileResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppHeaders extends $tea.Model {
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

export class InstallAppRequest extends $tea.Model {
  appId?: number;
  corpId?: string;
  dingUserId?: string;
  suiteId?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      corpId: 'corpId',
      dingUserId: 'dingUserId',
      suiteId: 'suiteId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      corpId: 'string',
      dingUserId: 'string',
      suiteId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAppResponseBody extends $tea.Model {
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

export class InstallAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InstallAppResponseBody;
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
      body: InstallAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppHeaders extends $tea.Model {
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

export class InstallCoolAppRequest extends $tea.Model {
  appId?: number;
  coolAppCode?: string;
  corpId?: string;
  feature?: { [key: string]: any };
  installUid?: string;
  openConversationId?: string;
  options?: { [key: string]: any };
  suiteId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      coolAppCode: 'coolAppCode',
      corpId: 'corpId',
      feature: 'feature',
      installUid: 'installUid',
      openConversationId: 'openConversationId',
      options: 'options',
      suiteId: 'suiteId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      coolAppCode: 'string',
      corpId: 'string',
      feature: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      installUid: 'string',
      openConversationId: 'string',
      options: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      suiteId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppShrinkRequest extends $tea.Model {
  appId?: number;
  coolAppCode?: string;
  corpId?: string;
  featureShrink?: string;
  installUid?: string;
  openConversationId?: string;
  optionsShrink?: string;
  suiteId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      coolAppCode: 'coolAppCode',
      corpId: 'corpId',
      featureShrink: 'feature',
      installUid: 'installUid',
      openConversationId: 'openConversationId',
      optionsShrink: 'options',
      suiteId: 'suiteId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      coolAppCode: 'string',
      corpId: 'string',
      featureShrink: 'string',
      installUid: 'string',
      openConversationId: 'string',
      optionsShrink: 'string',
      suiteId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppResponseBody extends $tea.Model {
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

export class InstallCoolAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: InstallCoolAppResponseBody;
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
      body: InstallCoolAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RePushSuiteTicketRequest extends $tea.Model {
  suiteId?: number;
  suiteSecret?: string;
  static names(): { [key: string]: string } {
    return {
      suiteId: 'suiteId',
      suiteSecret: 'suiteSecret',
    };
  }

  static types(): { [key: string]: any } {
    return {
      suiteId: 'number',
      suiteSecret: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RePushSuiteTicketResponseBody extends $tea.Model {
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

export class RePushSuiteTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RePushSuiteTicketResponseBody;
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
      body: RePushSuiteTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCallBackFaileResultResponseBodyFailedList extends $tea.Model {
  callBackData?: string;
  callBackTag?: string;
  corpId?: string;
  eventTime?: number;
  static names(): { [key: string]: string } {
    return {
      callBackData: 'callBackData',
      callBackTag: 'callBackTag',
      corpId: 'corpId',
      eventTime: 'eventTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callBackData: 'string',
      callBackTag: 'string',
      corpId: 'string',
      eventTime: 'number',
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


  async getCallBackFaileResultWithOptions(request: GetCallBackFaileResultRequest, headers: GetCallBackFaileResultHeaders, runtime: $Util.RuntimeOptions): Promise<GetCallBackFaileResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.beginTime)) {
      query["beginTime"] = request.beginTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
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
      action: "GetCallBackFaileResult",
      version: "event_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/event/callbacks/failedResults`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCallBackFaileResultResponse>(await this.execute(params, req, runtime), new GetCallBackFaileResultResponse({}));
  }

  async getCallBackFaileResult(request: GetCallBackFaileResultRequest): Promise<GetCallBackFaileResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCallBackFaileResultHeaders({ });
    return await this.getCallBackFaileResultWithOptions(request, headers, runtime);
  }

  async installAppWithOptions(request: InstallAppRequest, headers: InstallAppHeaders, runtime: $Util.RuntimeOptions): Promise<InstallAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.dingUserId)) {
      query["dingUserId"] = request.dingUserId;
    }

    if (!Util.isUnset(request.suiteId)) {
      query["suiteId"] = request.suiteId;
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
      action: "InstallApp",
      version: "event_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/event/elm/apps/install`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallAppResponse>(await this.execute(params, req, runtime), new InstallAppResponse({}));
  }

  async installApp(request: InstallAppRequest): Promise<InstallAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallAppHeaders({ });
    return await this.installAppWithOptions(request, headers, runtime);
  }

  async installCoolAppWithOptions(tmpReq: InstallCoolAppRequest, headers: InstallCoolAppHeaders, runtime: $Util.RuntimeOptions): Promise<InstallCoolAppResponse> {
    Util.validateModel(tmpReq);
    let request = new InstallCoolAppShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.feature)) {
      request.featureShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.feature, "feature", "json");
    }

    if (!Util.isUnset(tmpReq.options)) {
      request.optionsShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.options, "options", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
    }

    if (!Util.isUnset(request.coolAppCode)) {
      query["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.featureShrink)) {
      query["feature"] = request.featureShrink;
    }

    if (!Util.isUnset(request.installUid)) {
      query["installUid"] = request.installUid;
    }

    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.optionsShrink)) {
      query["options"] = request.optionsShrink;
    }

    if (!Util.isUnset(request.suiteId)) {
      query["suiteId"] = request.suiteId;
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
      action: "InstallCoolApp",
      version: "event_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/event/elm/coolApps/install`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallCoolAppResponse>(await this.execute(params, req, runtime), new InstallCoolAppResponse({}));
  }

  async installCoolApp(request: InstallCoolAppRequest): Promise<InstallCoolAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallCoolAppHeaders({ });
    return await this.installCoolAppWithOptions(request, headers, runtime);
  }

  async rePushSuiteTicketWithOptions(request: RePushSuiteTicketRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<RePushSuiteTicketResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.suiteId)) {
      query["suiteId"] = request.suiteId;
    }

    if (!Util.isUnset(request.suiteSecret)) {
      query["suiteSecret"] = request.suiteSecret;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "RePushSuiteTicket",
      version: "event_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/event/suiteTicket/rePush`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RePushSuiteTicketResponse>(await this.execute(params, req, runtime), new RePushSuiteTicketResponse({}));
  }

  async rePushSuiteTicket(request: RePushSuiteTicketRequest): Promise<RePushSuiteTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.rePushSuiteTicketWithOptions(request, headers, runtime);
  }

}
