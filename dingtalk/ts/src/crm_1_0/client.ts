// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryAllCustomerHeaders extends $tea.Model {
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

export class QueryAllCustomerRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingCorpId?: string;
  dingSuiteKey?: string;
  operatorUserId?: string;
  maxResults?: number;
  nextToken?: string;
  objectType?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingCorpId: 'dingCorpId',
      dingSuiteKey: 'dingSuiteKey',
      operatorUserId: 'operatorUserId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      objectType: 'objectType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingCorpId: 'string',
      dingSuiteKey: 'string',
      operatorUserId: 'string',
      maxResults: 'number',
      nextToken: 'string',
      objectType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBody extends $tea.Model {
  result?: QueryAllCustomerResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryAllCustomerResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResultValuesPermission extends $tea.Model {
  participantStaffIds?: string[];
  ownerStaffIds?: string[];
  static names(): { [key: string]: string } {
    return {
      participantStaffIds: 'participantStaffIds',
      ownerStaffIds: 'ownerStaffIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      participantStaffIds: { 'type': 'array', 'itemType': 'string' },
      ownerStaffIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResultValues extends $tea.Model {
  creatorNick?: string;
  modifyTime?: string;
  creatorUserId?: string;
  instanceId?: string;
  data?: { [key: string]: any };
  extendData?: { [key: string]: any };
  createTime?: string;
  orgId?: number;
  objectType?: string;
  permission?: QueryAllCustomerResponseBodyResultValuesPermission;
  processOutResult?: string;
  processInstanceStatus?: string;
  static names(): { [key: string]: string } {
    return {
      creatorNick: 'creatorNick',
      modifyTime: 'modifyTime',
      creatorUserId: 'creatorUserId',
      instanceId: 'instanceId',
      data: 'data',
      extendData: 'extendData',
      createTime: 'createTime',
      orgId: 'orgId',
      objectType: 'objectType',
      permission: 'permission',
      processOutResult: 'processOutResult',
      processInstanceStatus: 'processInstanceStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorNick: 'string',
      modifyTime: 'string',
      creatorUserId: 'string',
      instanceId: 'string',
      data: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      extendData: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      createTime: 'string',
      orgId: 'number',
      objectType: 'string',
      permission: QueryAllCustomerResponseBodyResultValuesPermission,
      processOutResult: 'string',
      processInstanceStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllCustomerResponseBodyResult extends $tea.Model {
  nextToken?: string;
  values?: QueryAllCustomerResponseBodyResultValues[];
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      values: 'values',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      values: { 'type': 'array', 'itemType': QueryAllCustomerResponseBodyResultValues },
      maxResults: 'number',
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


  async queryAllCustomer(request: QueryAllCustomerRequest): Promise<QueryAllCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllCustomerHeaders({ });
    return await this.queryAllCustomerWithOptions(request, headers, runtime);
  }

  async queryAllCustomerWithOptions(request: QueryAllCustomerRequest, headers: QueryAllCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.objectType)) {
      body["objectType"] = request.objectType;
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
    return $tea.cast<QueryAllCustomerResponse>(await this.doROARequest("QueryAllCustomer", "crm_1.0", "HTTP", "POST", "AK", `/v1.0/crm/customerInstances`, "json", req, runtime), new QueryAllCustomerResponse({}));
  }

}
