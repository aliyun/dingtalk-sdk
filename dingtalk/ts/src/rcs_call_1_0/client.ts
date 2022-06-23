// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class RunCallUserHeaders extends $tea.Model {
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

export class RunCallUserRequest extends $tea.Model {
  authorizeCorpId?: string;
  authorizeUserId?: string;
  orderId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      authorizeCorpId: 'authorizeCorpId',
      authorizeUserId: 'authorizeUserId',
      orderId: 'orderId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorizeCorpId: 'string',
      authorizeUserId: 'string',
      orderId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RunCallUserResponseBody extends $tea.Model {
  success?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RunCallUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RunCallUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RunCallUserResponseBody,
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


  async runCallUser(request: RunCallUserRequest): Promise<RunCallUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RunCallUserHeaders({ });
    return await this.runCallUserWithOptions(request, headers, runtime);
  }

  async runCallUserWithOptions(request: RunCallUserRequest, headers: RunCallUserHeaders, runtime: $Util.RuntimeOptions): Promise<RunCallUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authorizeCorpId)) {
      query["authorizeCorpId"] = request.authorizeCorpId;
    }

    if (!Util.isUnset(request.authorizeUserId)) {
      query["authorizeUserId"] = request.authorizeUserId;
    }

    if (!Util.isUnset(request.orderId)) {
      query["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<RunCallUserResponse>(await this.doROARequest("RunCallUser", "rcsCall_1.0", "HTTP", "POST", "AK", `/v1.0/rcsCall/users/call`, "json", req, runtime), new RunCallUserResponse({}));
  }

}
