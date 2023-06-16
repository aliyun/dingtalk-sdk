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

export class AddCallConfigHeaders extends $tea.Model {
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

export class AddCallConfigRequest extends $tea.Model {
  corpId?: string;
  isvToken?: string;
  phoneNumber?: string;
  scopeType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isvToken: 'isvToken',
      phoneNumber: 'phoneNumber',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isvToken: 'string',
      phoneNumber: 'string',
      scopeType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCallConfigResponseBody extends $tea.Model {
  token?: string;
  static names(): { [key: string]: string } {
    return {
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddCallConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddCallConfigResponseBody;
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
      body: AddCallConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DelCallConfigHeaders extends $tea.Model {
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

export class DelCallConfigRequest extends $tea.Model {
  corpId?: string;
  isvToken?: string;
  phoneNumber?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isvToken: 'isvToken',
      phoneNumber: 'phoneNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isvToken: 'string',
      phoneNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DelCallConfigResponseBody extends $tea.Model {
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

export class DelCallConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DelCallConfigResponseBody;
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
      body: DelCallConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCallConfigHeaders extends $tea.Model {
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

export class QueryCallConfigRequest extends $tea.Model {
  corpId?: string;
  isvToken?: string;
  phoneNumber?: string;
  scopeType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      isvToken: 'isvToken',
      phoneNumber: 'phoneNumber',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      isvToken: 'string',
      phoneNumber: 'string',
      scopeType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCallConfigResponseBody extends $tea.Model {
  result?: QueryCallConfigResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryCallConfigResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCallConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCallConfigResponseBody;
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
      body: QueryCallConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCallConfigResponseBodyResult extends $tea.Model {
  accountDomain?: string;
  accountId?: string;
  callInType?: number;
  callOutType?: number;
  createUid?: string;
  phoneNumber?: string;
  scopeType?: string;
  showType?: number;
  sourceType?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      accountDomain: 'accountDomain',
      accountId: 'accountId',
      callInType: 'callInType',
      callOutType: 'callOutType',
      createUid: 'createUid',
      phoneNumber: 'phoneNumber',
      scopeType: 'scopeType',
      showType: 'showType',
      sourceType: 'sourceType',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountDomain: 'string',
      accountId: 'string',
      callInType: 'number',
      callOutType: 'number',
      createUid: 'string',
      phoneNumber: 'string',
      scopeType: 'string',
      showType: 'number',
      sourceType: 'string',
      status: 'number',
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


  async addCallConfigWithOptions(request: AddCallConfigRequest, headers: AddCallConfigHeaders, runtime: $Util.RuntimeOptions): Promise<AddCallConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.isvToken)) {
      query["isvToken"] = request.isvToken;
    }

    if (!Util.isUnset(request.phoneNumber)) {
      query["phoneNumber"] = request.phoneNumber;
    }

    if (!Util.isUnset(request.scopeType)) {
      query["scopeType"] = request.scopeType;
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
      action: "AddCallConfig",
      version: "dingPhone_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingPhone/callConfigs`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddCallConfigResponse>(await this.execute(params, req, runtime), new AddCallConfigResponse({}));
  }

  async addCallConfig(request: AddCallConfigRequest): Promise<AddCallConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddCallConfigHeaders({ });
    return await this.addCallConfigWithOptions(request, headers, runtime);
  }

  async delCallConfigWithOptions(request: DelCallConfigRequest, headers: DelCallConfigHeaders, runtime: $Util.RuntimeOptions): Promise<DelCallConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.isvToken)) {
      query["isvToken"] = request.isvToken;
    }

    if (!Util.isUnset(request.phoneNumber)) {
      query["phoneNumber"] = request.phoneNumber;
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
      action: "DelCallConfig",
      version: "dingPhone_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingPhone/callConfigs`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DelCallConfigResponse>(await this.execute(params, req, runtime), new DelCallConfigResponse({}));
  }

  async delCallConfig(request: DelCallConfigRequest): Promise<DelCallConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DelCallConfigHeaders({ });
    return await this.delCallConfigWithOptions(request, headers, runtime);
  }

  async queryCallConfigWithOptions(request: QueryCallConfigRequest, headers: QueryCallConfigHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCallConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.isvToken)) {
      query["isvToken"] = request.isvToken;
    }

    if (!Util.isUnset(request.phoneNumber)) {
      query["phoneNumber"] = request.phoneNumber;
    }

    if (!Util.isUnset(request.scopeType)) {
      query["scopeType"] = request.scopeType;
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
      action: "QueryCallConfig",
      version: "dingPhone_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingPhone/callConfigs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCallConfigResponse>(await this.execute(params, req, runtime), new QueryCallConfigResponse({}));
  }

  async queryCallConfig(request: QueryCallConfigRequest): Promise<QueryCallConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCallConfigHeaders({ });
    return await this.queryCallConfigWithOptions(request, headers, runtime);
  }

}
