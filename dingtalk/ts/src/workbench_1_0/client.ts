// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class ListWorkBenchGroupHeaders extends $tea.Model {
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

export class ListWorkBenchGroupRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  groupType?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
      groupType: 'groupType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
      groupType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkBenchGroupResponseBody extends $tea.Model {
  groupList?: ListWorkBenchGroupResponseBodyGroupList[];
  static names(): { [key: string]: string } {
    return {
      groupList: 'groupList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupList: { 'type': 'array', 'itemType': ListWorkBenchGroupResponseBodyGroupList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkBenchGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListWorkBenchGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListWorkBenchGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryComponentScopesHeaders extends $tea.Model {
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

export class QueryComponentScopesResponseBody extends $tea.Model {
  userVisibleScopes?: string[];
  deptVisibleScopes?: number[];
  static names(): { [key: string]: string } {
    return {
      userVisibleScopes: 'userVisibleScopes',
      deptVisibleScopes: 'deptVisibleScopes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userVisibleScopes: { 'type': 'array', 'itemType': 'string' },
      deptVisibleScopes: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryComponentScopesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryComponentScopesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryComponentScopesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDingPortalPageScopeHeaders extends $tea.Model {
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

export class UpdateDingPortalPageScopeRequest extends $tea.Model {
  userids?: string[];
  deptIds?: number[];
  roleIds?: number[];
  allVisible?: boolean;
  static names(): { [key: string]: string } {
    return {
      userids: 'userids',
      deptIds: 'deptIds',
      roleIds: 'roleIds',
      allVisible: 'allVisible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userids: { 'type': 'array', 'itemType': 'string' },
      deptIds: { 'type': 'array', 'itemType': 'number' },
      roleIds: { 'type': 'array', 'itemType': 'number' },
      allVisible: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDingPortalPageScopeResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryShortcutScopesHeaders extends $tea.Model {
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

export class QueryShortcutScopesResponseBody extends $tea.Model {
  userVisibleScopes?: string[];
  deptVisibleScopes?: number[];
  static names(): { [key: string]: string } {
    return {
      userVisibleScopes: 'userVisibleScopes',
      deptVisibleScopes: 'deptVisibleScopes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userVisibleScopes: { 'type': 'array', 'itemType': 'string' },
      deptVisibleScopes: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryShortcutScopesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryShortcutScopesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryShortcutScopesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingPortalDetailHeaders extends $tea.Model {
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

export class GetDingPortalDetailResponseBody extends $tea.Model {
  appUuid?: string;
  dingPortalName?: string;
  pages?: GetDingPortalDetailResponseBodyPages[];
  static names(): { [key: string]: string } {
    return {
      appUuid: 'appUuid',
      dingPortalName: 'dingPortalName',
      pages: 'pages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUuid: 'string',
      dingPortalName: 'string',
      pages: { 'type': 'array', 'itemType': GetDingPortalDetailResponseBodyPages },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingPortalDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDingPortalDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDingPortalDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkBenchGroupResponseBodyGroupList extends $tea.Model {
  name?: string;
  componentId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      componentId: 'componentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      componentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingPortalDetailResponseBodyPages extends $tea.Model {
  pageUuid?: string;
  pageName?: string;
  userids?: string[];
  deptIds?: number[];
  roleIds?: number[];
  allVisible?: boolean;
  static names(): { [key: string]: string } {
    return {
      pageUuid: 'pageUuid',
      pageName: 'pageName',
      userids: 'userids',
      deptIds: 'deptIds',
      roleIds: 'roleIds',
      allVisible: 'allVisible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageUuid: 'string',
      pageName: 'string',
      userids: { 'type': 'array', 'itemType': 'string' },
      deptIds: { 'type': 'array', 'itemType': 'number' },
      roleIds: { 'type': 'array', 'itemType': 'number' },
      allVisible: 'boolean',
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


  async listWorkBenchGroup(request: ListWorkBenchGroupRequest): Promise<ListWorkBenchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListWorkBenchGroupHeaders({ });
    return await this.listWorkBenchGroupWithOptions(request, headers, runtime);
  }

  async listWorkBenchGroupWithOptions(request: ListWorkBenchGroupRequest, headers: ListWorkBenchGroupHeaders, runtime: $Util.RuntimeOptions): Promise<ListWorkBenchGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      query["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.groupType)) {
      query["groupType"] = request.groupType;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListWorkBenchGroupResponse>(await this.doROARequest("ListWorkBenchGroup", "workbench_1.0", "HTTP", "GET", "AK", `/v1.0/workbench/groups`, "json", req, runtime), new ListWorkBenchGroupResponse({}));
  }

  async queryComponentScopes(componentId: string): Promise<QueryComponentScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryComponentScopesHeaders({ });
    return await this.queryComponentScopesWithOptions(componentId, headers, runtime);
  }

  async queryComponentScopesWithOptions(componentId: string, headers: QueryComponentScopesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryComponentScopesResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryComponentScopesResponse>(await this.doROARequest("QueryComponentScopes", "workbench_1.0", "HTTP", "GET", "AK", `/v1.0/workbench/components/${componentId}/scopes`, "json", req, runtime), new QueryComponentScopesResponse({}));
  }

  async updateDingPortalPageScope(pageUuid: string, appUuid: string, request: UpdateDingPortalPageScopeRequest): Promise<UpdateDingPortalPageScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDingPortalPageScopeHeaders({ });
    return await this.updateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
  }

  async updateDingPortalPageScopeWithOptions(pageUuid: string, appUuid: string, request: UpdateDingPortalPageScopeRequest, headers: UpdateDingPortalPageScopeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateDingPortalPageScopeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userids)) {
      body["userids"] = request.userids;
    }

    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.roleIds)) {
      body["roleIds"] = request.roleIds;
    }

    if (!Util.isUnset(request.allVisible)) {
      body["allVisible"] = request.allVisible;
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
    return $tea.cast<UpdateDingPortalPageScopeResponse>(await this.doROARequest("UpdateDingPortalPageScope", "workbench_1.0", "HTTP", "PUT", "AK", `/v1.0/workbench/dingPortals/${appUuid}/pageScopes/${pageUuid}`, "none", req, runtime), new UpdateDingPortalPageScopeResponse({}));
  }

  async queryShortcutScopes(shortcutKey: string): Promise<QueryShortcutScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryShortcutScopesHeaders({ });
    return await this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
  }

  async queryShortcutScopesWithOptions(shortcutKey: string, headers: QueryShortcutScopesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryShortcutScopesResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryShortcutScopesResponse>(await this.doROARequest("QueryShortcutScopes", "workbench_1.0", "HTTP", "GET", "AK", `/v1.0/workbench/shortcuts/${shortcutKey}/scopes`, "json", req, runtime), new QueryShortcutScopesResponse({}));
  }

  async getDingPortalDetail(appUuid: string): Promise<GetDingPortalDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingPortalDetailHeaders({ });
    return await this.getDingPortalDetailWithOptions(appUuid, headers, runtime);
  }

  async getDingPortalDetailWithOptions(appUuid: string, headers: GetDingPortalDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingPortalDetailResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetDingPortalDetailResponse>(await this.doROARequest("GetDingPortalDetail", "workbench_1.0", "HTTP", "GET", "AK", `/v1.0/workbench/dingPortals/${appUuid}`, "json", req, runtime), new GetDingPortalDetailResponse({}));
  }

}
