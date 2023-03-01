// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  body: QueryBlackboardSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryBlackboardSpaceResponseBody,
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


  async queryBlackboardSpace(request: QueryBlackboardSpaceRequest): Promise<QueryBlackboardSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBlackboardSpaceHeaders({ });
    return await this.queryBlackboardSpaceWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryBlackboardSpaceResponse>(await this.doROARequest("QueryBlackboardSpace", "blackboard_1.0", "HTTP", "GET", "AK", `/v1.0/blackboard/spaces`, "json", req, runtime), new QueryBlackboardSpaceResponse({}));
  }

}
