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

export class AddRecentUserAppListHeaders extends $tea.Model {
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

export class AddRecentUserAppListRequest extends $tea.Model {
  corpId?: string;
  usedAppDetailList?: AddRecentUserAppListRequestUsedAppDetailList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      usedAppDetailList: 'usedAppDetailList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      usedAppDetailList: { 'type': 'array', 'itemType': AddRecentUserAppListRequestUsedAppDetailList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRecentUserAppListResponseBody extends $tea.Model {
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

export class AddRecentUserAppListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddRecentUserAppListResponseBody;
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
      body: AddRecentUserAppListResponseBody,
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
  statusCode: number;
  body: GetDingPortalDetailResponseBody;
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
      body: GetDingPortalDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPluginPermissionPointHeaders extends $tea.Model {
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

export class GetPluginPermissionPointRequest extends $tea.Model {
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPluginPermissionPointResponseBody extends $tea.Model {
  permissionPointList?: string[];
  static names(): { [key: string]: string } {
    return {
      permissionPointList: 'permissionPointList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      permissionPointList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPluginPermissionPointResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPluginPermissionPointResponseBody;
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
      body: GetPluginPermissionPointResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPluginRuleCheckInfoHeaders extends $tea.Model {
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

export class GetPluginRuleCheckInfoRequest extends $tea.Model {
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPluginRuleCheckInfoResponseBody extends $tea.Model {
  packCode?: string;
  pluginRuleCheckDetail?: string;
  static names(): { [key: string]: string } {
    return {
      packCode: 'packCode',
      pluginRuleCheckDetail: 'pluginRuleCheckDetail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      packCode: 'string',
      pluginRuleCheckDetail: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPluginRuleCheckInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPluginRuleCheckInfoResponseBody;
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
      body: GetPluginRuleCheckInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  ecologicalCorpId?: string;
  groupType?: string;
  opUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      ecologicalCorpId: 'ecologicalCorpId',
      groupType: 'groupType',
      opUnionId: 'opUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ecologicalCorpId: 'string',
      groupType: 'string',
      opUnionId: 'string',
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
  statusCode: number;
  body: ListWorkBenchGroupResponseBody;
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
      body: ListWorkBenchGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyWorkbenchBadgeHeaders extends $tea.Model {
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

export class ModifyWorkbenchBadgeRequest extends $tea.Model {
  bizIdList?: string[];
  isAdded?: boolean;
  redDotRelationId?: string;
  redDotType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizIdList: 'bizIdList',
      isAdded: 'isAdded',
      redDotRelationId: 'redDotRelationId',
      redDotType: 'redDotType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizIdList: { 'type': 'array', 'itemType': 'string' },
      isAdded: 'boolean',
      redDotRelationId: 'string',
      redDotType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyWorkbenchBadgeResponseBody extends $tea.Model {
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

export class ModifyWorkbenchBadgeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ModifyWorkbenchBadgeResponseBody;
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
      body: ModifyWorkbenchBadgeResponseBody,
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
  deptVisibleScopes?: number[];
  userVisibleScopes?: string[];
  static names(): { [key: string]: string } {
    return {
      deptVisibleScopes: 'deptVisibleScopes',
      userVisibleScopes: 'userVisibleScopes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptVisibleScopes: { 'type': 'array', 'itemType': 'number' },
      userVisibleScopes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryComponentScopesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryComponentScopesResponseBody;
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
      body: QueryComponentScopesResponseBody,
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
  deptVisibleScopes?: number[];
  userVisibleScopes?: string[];
  static names(): { [key: string]: string } {
    return {
      deptVisibleScopes: 'deptVisibleScopes',
      userVisibleScopes: 'userVisibleScopes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptVisibleScopes: { 'type': 'array', 'itemType': 'number' },
      userVisibleScopes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryShortcutScopesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryShortcutScopesResponseBody;
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
      body: QueryShortcutScopesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UndoDeletionHeaders extends $tea.Model {
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

export class UndoDeletionRequest extends $tea.Model {
  bizIdList?: string[];
  redDotRelationId?: string;
  redDotType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizIdList: 'bizIdList',
      redDotRelationId: 'redDotRelationId',
      redDotType: 'redDotType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizIdList: { 'type': 'array', 'itemType': 'string' },
      redDotRelationId: 'string',
      redDotType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UndoDeletionResponseBody extends $tea.Model {
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

export class UndoDeletionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UndoDeletionResponseBody;
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
      body: UndoDeletionResponseBody,
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
  allVisible?: boolean;
  deptIds?: number[];
  roleIds?: number[];
  userids?: string[];
  static names(): { [key: string]: string } {
    return {
      allVisible: 'allVisible',
      deptIds: 'deptIds',
      roleIds: 'roleIds',
      userids: 'userids',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allVisible: 'boolean',
      deptIds: { 'type': 'array', 'itemType': 'number' },
      roleIds: { 'type': 'array', 'itemType': 'number' },
      userids: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDingPortalPageScopeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRecentUserAppListRequestUsedAppDetailList extends $tea.Model {
  agentId?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingPortalDetailResponseBodyPages extends $tea.Model {
  allVisible?: boolean;
  deptIds?: number[];
  pageName?: string;
  pageUuid?: string;
  roleIds?: number[];
  userids?: string[];
  static names(): { [key: string]: string } {
    return {
      allVisible: 'allVisible',
      deptIds: 'deptIds',
      pageName: 'pageName',
      pageUuid: 'pageUuid',
      roleIds: 'roleIds',
      userids: 'userids',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allVisible: 'boolean',
      deptIds: { 'type': 'array', 'itemType': 'number' },
      pageName: 'string',
      pageUuid: 'string',
      roleIds: { 'type': 'array', 'itemType': 'number' },
      userids: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListWorkBenchGroupResponseBodyGroupList extends $tea.Model {
  componentId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      componentId: 'componentId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentId: 'string',
      name: 'string',
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


  async addRecentUserAppListWithOptions(request: AddRecentUserAppListRequest, headers: AddRecentUserAppListHeaders, runtime: $Util.RuntimeOptions): Promise<AddRecentUserAppListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.usedAppDetailList)) {
      body["usedAppDetailList"] = request.usedAppDetailList;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddRecentUserAppList",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/components/recentUsed/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddRecentUserAppListResponse>(await this.execute(params, req, runtime), new AddRecentUserAppListResponse({}));
  }

  async addRecentUserAppList(request: AddRecentUserAppListRequest): Promise<AddRecentUserAppListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRecentUserAppListHeaders({ });
    return await this.addRecentUserAppListWithOptions(request, headers, runtime);
  }

  async getDingPortalDetailWithOptions(appUuid: string, headers: GetDingPortalDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingPortalDetailResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetDingPortalDetail",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/dingPortals/${appUuid}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetDingPortalDetailResponse>(await this.execute(params, req, runtime), new GetDingPortalDetailResponse({}));
  }

  async getDingPortalDetail(appUuid: string): Promise<GetDingPortalDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingPortalDetailHeaders({ });
    return await this.getDingPortalDetailWithOptions(appUuid, headers, runtime);
  }

  async getPluginPermissionPointWithOptions(request: GetPluginPermissionPointRequest, headers: GetPluginPermissionPointHeaders, runtime: $Util.RuntimeOptions): Promise<GetPluginPermissionPointResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
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
      action: "GetPluginPermissionPoint",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/plugins/permissions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetPluginPermissionPointResponse>(await this.execute(params, req, runtime), new GetPluginPermissionPointResponse({}));
  }

  async getPluginPermissionPoint(request: GetPluginPermissionPointRequest): Promise<GetPluginPermissionPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPluginPermissionPointHeaders({ });
    return await this.getPluginPermissionPointWithOptions(request, headers, runtime);
  }

  async getPluginRuleCheckInfoWithOptions(request: GetPluginRuleCheckInfoRequest, headers: GetPluginRuleCheckInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPluginRuleCheckInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
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
      action: "GetPluginRuleCheckInfo",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/plugins/validationRules`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetPluginRuleCheckInfoResponse>(await this.execute(params, req, runtime), new GetPluginRuleCheckInfoResponse({}));
  }

  async getPluginRuleCheckInfo(request: GetPluginRuleCheckInfoRequest): Promise<GetPluginRuleCheckInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPluginRuleCheckInfoHeaders({ });
    return await this.getPluginRuleCheckInfoWithOptions(request, headers, runtime);
  }

  async listWorkBenchGroupWithOptions(request: ListWorkBenchGroupRequest, headers: ListWorkBenchGroupHeaders, runtime: $Util.RuntimeOptions): Promise<ListWorkBenchGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.groupType)) {
      query["groupType"] = request.groupType;
    }

    if (!Util.isUnset(request.opUnionId)) {
      query["opUnionId"] = request.opUnionId;
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
      action: "ListWorkBenchGroup",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/groups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListWorkBenchGroupResponse>(await this.execute(params, req, runtime), new ListWorkBenchGroupResponse({}));
  }

  async listWorkBenchGroup(request: ListWorkBenchGroupRequest): Promise<ListWorkBenchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListWorkBenchGroupHeaders({ });
    return await this.listWorkBenchGroupWithOptions(request, headers, runtime);
  }

  async modifyWorkbenchBadgeWithOptions(request: ModifyWorkbenchBadgeRequest, headers: ModifyWorkbenchBadgeHeaders, runtime: $Util.RuntimeOptions): Promise<ModifyWorkbenchBadgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizIdList)) {
      body["bizIdList"] = request.bizIdList;
    }

    if (!Util.isUnset(request.isAdded)) {
      body["isAdded"] = request.isAdded;
    }

    if (!Util.isUnset(request.redDotRelationId)) {
      body["redDotRelationId"] = request.redDotRelationId;
    }

    if (!Util.isUnset(request.redDotType)) {
      body["redDotType"] = request.redDotType;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ModifyWorkbenchBadge",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/badges/modify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ModifyWorkbenchBadgeResponse>(await this.execute(params, req, runtime), new ModifyWorkbenchBadgeResponse({}));
  }

  async modifyWorkbenchBadge(request: ModifyWorkbenchBadgeRequest): Promise<ModifyWorkbenchBadgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyWorkbenchBadgeHeaders({ });
    return await this.modifyWorkbenchBadgeWithOptions(request, headers, runtime);
  }

  async queryComponentScopesWithOptions(componentId: string, headers: QueryComponentScopesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryComponentScopesResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "QueryComponentScopes",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/components/${componentId}/scopes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryComponentScopesResponse>(await this.execute(params, req, runtime), new QueryComponentScopesResponse({}));
  }

  async queryComponentScopes(componentId: string): Promise<QueryComponentScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryComponentScopesHeaders({ });
    return await this.queryComponentScopesWithOptions(componentId, headers, runtime);
  }

  async queryShortcutScopesWithOptions(shortcutKey: string, headers: QueryShortcutScopesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryShortcutScopesResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "QueryShortcutScopes",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/shortcuts/${shortcutKey}/scopes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryShortcutScopesResponse>(await this.execute(params, req, runtime), new QueryShortcutScopesResponse({}));
  }

  async queryShortcutScopes(shortcutKey: string): Promise<QueryShortcutScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryShortcutScopesHeaders({ });
    return await this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
  }

  async undoDeletionWithOptions(request: UndoDeletionRequest, headers: UndoDeletionHeaders, runtime: $Util.RuntimeOptions): Promise<UndoDeletionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizIdList)) {
      body["bizIdList"] = request.bizIdList;
    }

    if (!Util.isUnset(request.redDotRelationId)) {
      body["redDotRelationId"] = request.redDotRelationId;
    }

    if (!Util.isUnset(request.redDotType)) {
      body["redDotType"] = request.redDotType;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UndoDeletion",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/badges/undoDeleted`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UndoDeletionResponse>(await this.execute(params, req, runtime), new UndoDeletionResponse({}));
  }

  async undoDeletion(request: UndoDeletionRequest): Promise<UndoDeletionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UndoDeletionHeaders({ });
    return await this.undoDeletionWithOptions(request, headers, runtime);
  }

  async updateDingPortalPageScopeWithOptions(pageUuid: string, appUuid: string, request: UpdateDingPortalPageScopeRequest, headers: UpdateDingPortalPageScopeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateDingPortalPageScopeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.allVisible)) {
      body["allVisible"] = request.allVisible;
    }

    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.roleIds)) {
      body["roleIds"] = request.roleIds;
    }

    if (!Util.isUnset(request.userids)) {
      body["userids"] = request.userids;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateDingPortalPageScope",
      version: "workbench_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/workbench/dingPortals/${appUuid}/pageScopes/${pageUuid}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateDingPortalPageScopeResponse>(await this.execute(params, req, runtime), new UpdateDingPortalPageScopeResponse({}));
  }

  async updateDingPortalPageScope(pageUuid: string, appUuid: string, request: UpdateDingPortalPageScopeRequest): Promise<UpdateDingPortalPageScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDingPortalPageScopeHeaders({ });
    return await this.updateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
  }

}
