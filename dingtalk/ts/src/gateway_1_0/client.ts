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

export class OpenConnectionRequest extends $tea.Model {
  clientId?: string;
  clientSecret?: string;
  localIp?: string;
  subscriptions?: OpenConnectionRequestSubscriptions[];
  static names(): { [key: string]: string } {
    return {
      clientId: 'clientId',
      clientSecret: 'clientSecret',
      localIp: 'localIp',
      subscriptions: 'subscriptions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clientId: 'string',
      clientSecret: 'string',
      localIp: 'string',
      subscriptions: { 'type': 'array', 'itemType': OpenConnectionRequestSubscriptions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenConnectionResponseBody extends $tea.Model {
  endpoint?: string;
  ticket?: string;
  static names(): { [key: string]: string } {
    return {
      endpoint: 'endpoint',
      ticket: 'ticket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endpoint: 'string',
      ticket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenConnectionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: OpenConnectionResponseBody;
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
      body: OpenConnectionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenConnectionRequestSubscriptions extends $tea.Model {
  topic?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      topic: 'topic',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      topic: 'string',
      type: 'string',
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


  async openConnectionWithOptions(request: OpenConnectionRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<OpenConnectionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.clientId)) {
      body["clientId"] = request.clientId;
    }

    if (!Util.isUnset(request.clientSecret)) {
      body["clientSecret"] = request.clientSecret;
    }

    if (!Util.isUnset(request.localIp)) {
      body["localIp"] = request.localIp;
    }

    if (!Util.isUnset(request.subscriptions)) {
      body["subscriptions"] = request.subscriptions;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "OpenConnection",
      version: "gateway_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/gateway/connections/open`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenConnectionResponse>(await this.execute(params, req, runtime), new OpenConnectionResponse({}));
  }

  async openConnection(request: OpenConnectionRequest): Promise<OpenConnectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.openConnectionWithOptions(request, headers, runtime);
  }

}
