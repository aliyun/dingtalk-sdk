// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class OpenConnectionRequest extends $tea.Model {
  clientId?: string;
  clientSecret?: string;
  subscriptions?: OpenConnectionRequestSubscriptions[];
  static names(): { [key: string]: string } {
    return {
      clientId: 'clientId',
      clientSecret: 'clientSecret',
      subscriptions: 'subscriptions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clientId: 'string',
      clientSecret: 'string',
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
  body: OpenConnectionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async openConnection(request: OpenConnectionRequest): Promise<OpenConnectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.openConnectionWithOptions(request, headers, runtime);
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

    if (!Util.isUnset(request.subscriptions)) {
      body["subscriptions"] = request.subscriptions;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<OpenConnectionResponse>(await this.doROARequest("OpenConnection", "gateway_1.0", "HTTP", "POST", "AK", `/v1.0/gateway/connections/open`, "json", req, runtime), new OpenConnectionResponse({}));
  }

}
