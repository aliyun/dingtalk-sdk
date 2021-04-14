// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetDingMeBaseDataHeaders extends $tea.Model {
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

export class GetDingMeBaseDataRequest extends $tea.Model {
  appKey?: string;
  startDay?: string;
  endDay?: string;
  byDay?: boolean;
  static names(): { [key: string]: string } {
    return {
      appKey: 'appKey',
      startDay: 'startDay',
      endDay: 'endDay',
      byDay: 'byDay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appKey: 'string',
      startDay: 'string',
      endDay: 'string',
      byDay: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingMeBaseDataResponseBody extends $tea.Model {
  fromCache?: boolean;
  runtime?: number;
  rawset?: { [key: string]: string }[];
  tips?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      fromCache: 'fromCache',
      runtime: 'runtime',
      rawset: 'rawset',
      tips: 'tips',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fromCache: 'boolean',
      runtime: 'number',
      rawset: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'string' } },
      tips: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingMeBaseDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDingMeBaseDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDingMeBaseDataResponseBody,
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


  async getDingMeBaseData(request: GetDingMeBaseDataRequest): Promise<GetDingMeBaseDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingMeBaseDataHeaders({ });
    return await this.getDingMeBaseDataWithOptions(request, headers, runtime);
  }

  async getDingMeBaseDataWithOptions(request: GetDingMeBaseDataRequest, headers: GetDingMeBaseDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingMeBaseDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appKey)) {
      query["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.startDay)) {
      query["startDay"] = request.startDay;
    }

    if (!Util.isUnset(request.endDay)) {
      query["endDay"] = request.endDay;
    }

    if (!Util.isUnset(request.byDay)) {
      query["byDay"] = request.byDay;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetDingMeBaseDataResponse>(await this.doROARequest("GetDingMeBaseData", "dingmi_1.0", "HTTP", "GET", "AK", `/v1.0/dingmi/robots/data`, "json", req, runtime), new GetDingMeBaseDataResponse({}));
  }

}
