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
  statusCode: number;
  body: RunCallUserResponseBody;
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
      body: RunCallUserResponseBody,
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
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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
    let params = new $OpenApi.Params({
      action: "RunCallUser",
      version: "rcsCall_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/rcsCall/users/call`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RunCallUserResponse>(await this.execute(params, req, runtime), new RunCallUserResponse({}));
  }

  async runCallUser(request: RunCallUserRequest): Promise<RunCallUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RunCallUserHeaders({ });
    return await this.runCallUserWithOptions(request, headers, runtime);
  }

}
