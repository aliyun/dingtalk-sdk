// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CheckUserTaskStatusHeaders extends $tea.Model {
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

export class CheckUserTaskStatusRequest extends $tea.Model {
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckUserTaskStatusResponseBody extends $tea.Model {
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

export class CheckUserTaskStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CheckUserTaskStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CheckUserTaskStatusResponseBody,
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


  async checkUserTaskStatus(request: CheckUserTaskStatusRequest): Promise<CheckUserTaskStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckUserTaskStatusHeaders({ });
    return await this.checkUserTaskStatusWithOptions(request, headers, runtime);
  }

  async checkUserTaskStatusWithOptions(request: CheckUserTaskStatusRequest, headers: CheckUserTaskStatusHeaders, runtime: $Util.RuntimeOptions): Promise<CheckUserTaskStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.provinceCode)) {
      body["provinceCode"] = request.provinceCode;
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
    return $tea.cast<CheckUserTaskStatusResponse>(await this.doROARequest("CheckUserTaskStatus", "occupationauth_1.0", "HTTP", "POST", "AK", `/v1.0/occupationauth/auths/userTasks`, "json", req, runtime), new CheckUserTaskStatusResponse({}));
  }

}
