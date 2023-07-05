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

export class QueryBlackboardReadUnReadHeaders extends $tea.Model {
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

export class QueryBlackboardReadUnReadRequest extends $tea.Model {
  blackboardId?: string;
  maxResults?: number;
  nextToken?: string;
  operationUserId?: string;
  static names(): { [key: string]: string } {
    return {
      blackboardId: 'blackboardId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operationUserId: 'operationUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blackboardId: 'string',
      maxResults: 'number',
      nextToken: 'string',
      operationUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardReadUnReadResponseBody extends $tea.Model {
  nextToken?: string;
  users?: QueryBlackboardReadUnReadResponseBodyUsers[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      users: 'users',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      users: { 'type': 'array', 'itemType': QueryBlackboardReadUnReadResponseBodyUsers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardReadUnReadResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryBlackboardReadUnReadResponseBody;
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
      body: QueryBlackboardReadUnReadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardSpaceHeaders extends $tea.Model {
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

export class QueryBlackboardSpaceRequest extends $tea.Model {
  operationUserId?: string;
  static names(): { [key: string]: string } {
    return {
      operationUserId: 'operationUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operationUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardSpaceResponseBody extends $tea.Model {
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryBlackboardSpaceResponseBody;
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
      body: QueryBlackboardSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardReadUnReadResponseBodyUsers extends $tea.Model {
  read?: string;
  readTimestamp?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      read: 'read',
      readTimestamp: 'readTimestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      read: 'string',
      readTimestamp: 'number',
      userId: 'string',
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


  async queryBlackboardReadUnReadWithOptions(request: QueryBlackboardReadUnReadRequest, headers: QueryBlackboardReadUnReadHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBlackboardReadUnReadResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blackboardId)) {
      query["blackboardId"] = request.blackboardId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operationUserId)) {
      query["operationUserId"] = request.operationUserId;
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
      action: "QueryBlackboardReadUnRead",
      version: "blackboard_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/blackboard/readers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBlackboardReadUnReadResponse>(await this.execute(params, req, runtime), new QueryBlackboardReadUnReadResponse({}));
  }

  async queryBlackboardReadUnRead(request: QueryBlackboardReadUnReadRequest): Promise<QueryBlackboardReadUnReadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBlackboardReadUnReadHeaders({ });
    return await this.queryBlackboardReadUnReadWithOptions(request, headers, runtime);
  }

  async queryBlackboardSpaceWithOptions(request: QueryBlackboardSpaceRequest, headers: QueryBlackboardSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBlackboardSpaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operationUserId)) {
      query["operationUserId"] = request.operationUserId;
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
      action: "QueryBlackboardSpace",
      version: "blackboard_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/blackboard/spaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBlackboardSpaceResponse>(await this.execute(params, req, runtime), new QueryBlackboardSpaceResponse({}));
  }

  async queryBlackboardSpace(request: QueryBlackboardSpaceRequest): Promise<QueryBlackboardSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBlackboardSpaceHeaders({ });
    return await this.queryBlackboardSpaceWithOptions(request, headers, runtime);
  }

}
