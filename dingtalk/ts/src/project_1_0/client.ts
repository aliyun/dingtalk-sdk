// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetDeptsByOrgIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingOrgId?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingOrgId: 'dingOrgId',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingOrgId: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdResponseBody extends $tea.Model {
  deptList?: GetDeptsByOrgIdResponseBodyDeptList[];
  hasMore?: boolean;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      deptList: 'deptList',
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptList: { 'type': 'array', 'itemType': GetDeptsByOrgIdResponseBodyDeptList },
      hasMore: 'boolean',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDeptsByOrgIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDeptsByOrgIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingOrgId?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingOrgId: 'dingOrgId',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingOrgId: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdRequest extends $tea.Model {
  maxResults?: number;
  needDept?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      needDept: 'needDept',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      needDept: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdResponseBody extends $tea.Model {
  empList?: GetEmpsByOrgIdResponseBodyEmpList[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      empList: 'empList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      empList: { 'type': 'array', 'itemType': GetEmpsByOrgIdResponseBodyEmpList },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetEmpsByOrgIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetEmpsByOrgIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingCorpId?: string;
  dingIsvOrgId?: string;
  dingOrgId?: string;
  dingSuiteKey?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingCorpId: 'dingCorpId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingCorpId: 'string',
      dingIsvOrgId: 'string',
      dingOrgId: 'string',
      dingSuiteKey: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayRequest extends $tea.Model {
  label?: string;
  static names(): { [key: string]: string } {
    return {
      label: 'label',
    };
  }

  static types(): { [key: string]: any } {
    return {
      label: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectGrayResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbProjectGrayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbProjectGrayResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  dingAccessTokenType?: string;
  dingCorpId?: string;
  dingIsvOrgId?: string;
  dingOrgId?: string;
  dingSuiteKey?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      dingAccessTokenType: 'dingAccessTokenType',
      dingCorpId: 'dingCorpId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingAccessTokenType: 'string',
      dingCorpId: 'string',
      dingIsvOrgId: 'string',
      dingOrgId: 'string',
      dingSuiteKey: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceResponseBody extends $tea.Model {
  installSource?: string;
  static names(): { [key: string]: string } {
    return {
      installSource: 'installSource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      installSource: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTbProjectSourceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTbProjectSourceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTbProjectSourceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptsByOrgIdResponseBodyDeptList extends $tea.Model {
  deptId?: number;
  name?: string;
  parentId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'dept_id',
      name: 'name',
      parentId: 'parent_id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      name: 'string',
      parentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmpsByOrgIdResponseBodyEmpList extends $tea.Model {
  avatar?: string;
  deptIdList?: number[];
  dingId?: string;
  name?: string;
  nick?: string;
  orgId?: number;
  position?: string;
  unionid?: string;
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      deptIdList: 'dept_id_list',
      dingId: 'dingId',
      name: 'name',
      nick: 'nick',
      orgId: 'orgId',
      position: 'position',
      unionid: 'unionid',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      dingId: 'string',
      name: 'string',
      nick: 'string',
      orgId: 'number',
      position: 'string',
      unionid: 'string',
      userid: 'string',
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


  async getDeptsByOrgId(request: GetDeptsByOrgIdRequest): Promise<GetDeptsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDeptsByOrgIdHeaders({ });
    return await this.getDeptsByOrgIdWithOptions(request, headers, runtime);
  }

  async getDeptsByOrgIdWithOptions(request: GetDeptsByOrgIdRequest, headers: GetDeptsByOrgIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetDeptsByOrgIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetDeptsByOrgIdResponse>(await this.doROARequest("GetDeptsByOrgId", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/orgs/depts`, "json", req, runtime), new GetDeptsByOrgIdResponse({}));
  }

  async getEmpsByOrgId(request: GetEmpsByOrgIdRequest): Promise<GetEmpsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmpsByOrgIdHeaders({ });
    return await this.getEmpsByOrgIdWithOptions(request, headers, runtime);
  }

  async getEmpsByOrgIdWithOptions(request: GetEmpsByOrgIdRequest, headers: GetEmpsByOrgIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmpsByOrgIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.needDept)) {
      query["needDept"] = request.needDept;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetEmpsByOrgIdResponse>(await this.doROARequest("GetEmpsByOrgId", "project_1.0", "HTTP", "GET", "AK", `/v1.0/project/orgs/employees`, "json", req, runtime), new GetEmpsByOrgIdResponse({}));
  }

  async getTbProjectGray(request: GetTbProjectGrayRequest): Promise<GetTbProjectGrayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectGrayHeaders({ });
    return await this.getTbProjectGrayWithOptions(request, headers, runtime);
  }

  async getTbProjectGrayWithOptions(request: GetTbProjectGrayRequest, headers: GetTbProjectGrayHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbProjectGrayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.label)) {
      body["label"] = request.label;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingCorpId)) {
      realHeaders["dingCorpId"] = Util.toJSONString(headers.dingCorpId);
    }

    if (!Util.isUnset(headers.dingIsvOrgId)) {
      realHeaders["dingIsvOrgId"] = Util.toJSONString(headers.dingIsvOrgId);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.dingSuiteKey)) {
      realHeaders["dingSuiteKey"] = Util.toJSONString(headers.dingSuiteKey);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetTbProjectGrayResponse>(await this.doROARequest("GetTbProjectGray", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/projects/gray`, "json", req, runtime), new GetTbProjectGrayResponse({}));
  }

  async getTbProjectSource(): Promise<GetTbProjectSourceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTbProjectSourceHeaders({ });
    return await this.getTbProjectSourceWithOptions(headers, runtime);
  }

  async getTbProjectSourceWithOptions(headers: GetTbProjectSourceHeaders, runtime: $Util.RuntimeOptions): Promise<GetTbProjectSourceResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.dingAccessTokenType)) {
      realHeaders["dingAccessTokenType"] = Util.toJSONString(headers.dingAccessTokenType);
    }

    if (!Util.isUnset(headers.dingCorpId)) {
      realHeaders["dingCorpId"] = Util.toJSONString(headers.dingCorpId);
    }

    if (!Util.isUnset(headers.dingIsvOrgId)) {
      realHeaders["dingIsvOrgId"] = Util.toJSONString(headers.dingIsvOrgId);
    }

    if (!Util.isUnset(headers.dingOrgId)) {
      realHeaders["dingOrgId"] = Util.toJSONString(headers.dingOrgId);
    }

    if (!Util.isUnset(headers.dingSuiteKey)) {
      realHeaders["dingSuiteKey"] = Util.toJSONString(headers.dingSuiteKey);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetTbProjectSourceResponse>(await this.doROARequest("GetTbProjectSource", "project_1.0", "HTTP", "POST", "AK", `/v1.0/project/projects/source`, "json", req, runtime), new GetTbProjectSourceResponse({}));
  }

}
