// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding48143d56cd15327624f2f5cc6abecb85
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  usedAppDetailList?: AddRecentUserAppListRequestUsedAppDetailList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 642325391030949
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddRecentUserAppListResponseBody;
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
  /**
   * @example
   * SWAPP-XXX
   */
  appUuid?: string;
  /**
   * @example
   * 我的自定义工作台
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDingPortalDetailResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPluginPermissionPointResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPluginRuleCheckInfoResponseBody;
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
  /**
   * @example
   * corpId
   */
  ecologicalCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 首页 = WORK_HOME 全部页 = WORK_ALL_APP
   */
  groupType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListWorkBenchGroupResponseBody;
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
  /**
   * **if can be null:**
   * false
   */
  bizIdList?: string[];
  isAdded?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * full
   */
  modifyMode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5000000004278081/test
   */
  redDotRelationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * workbench_component
   */
  redDotType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0123465
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizIdList: 'bizIdList',
      isAdded: 'isAdded',
      modifyMode: 'modifyMode',
      redDotRelationId: 'redDotRelationId',
      redDotType: 'redDotType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizIdList: { 'type': 'array', 'itemType': 'string' },
      isAdded: 'boolean',
      modifyMode: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ModifyWorkbenchBadgeResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryComponentScopesResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryShortcutScopesResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  bizIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  redDotRelationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * workbench_component
   */
  redDotType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UndoDeletionResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2636835622
   */
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
  /**
   * @example
   * false
   */
  allVisible?: boolean;
  deptIds?: number[];
  /**
   * @example
   * 我的工作台页面
   */
  pageName?: string;
  /**
   * @example
   * XX-XX-XX
   */
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
  /**
   * @example
   * desc
   */
  componentId?: string;
  /**
   * @example
   * name
   */
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

  constructor(config: $OpenApi.Config) {
    super(config);
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 批量添加最近使用记录
   * 
   * @param request - AddRecentUserAppListRequest
   * @param headers - AddRecentUserAppListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddRecentUserAppListResponse
   */
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

  /**
   * 批量添加最近使用记录
   * 
   * @param request - AddRecentUserAppListRequest
   * @returns AddRecentUserAppListResponse
   */
  async addRecentUserAppList(request: AddRecentUserAppListRequest): Promise<AddRecentUserAppListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRecentUserAppListHeaders({ });
    return await this.addRecentUserAppListWithOptions(request, headers, runtime);
  }

  /**
   * 查询自定义工作台
   * 
   * @param headers - GetDingPortalDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDingPortalDetailResponse
   */
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

  /**
   * 查询自定义工作台
   * @returns GetDingPortalDetailResponse
   */
  async getDingPortalDetail(appUuid: string): Promise<GetDingPortalDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingPortalDetailHeaders({ });
    return await this.getDingPortalDetailWithOptions(appUuid, headers, runtime);
  }

  /**
   * 获取工作台插件的权限点
   * 
   * @param request - GetPluginPermissionPointRequest
   * @param headers - GetPluginPermissionPointHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPluginPermissionPointResponse
   */
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

  /**
   * 获取工作台插件的权限点
   * 
   * @param request - GetPluginPermissionPointRequest
   * @returns GetPluginPermissionPointResponse
   */
  async getPluginPermissionPoint(request: GetPluginPermissionPointRequest): Promise<GetPluginPermissionPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPluginPermissionPointHeaders({ });
    return await this.getPluginPermissionPointWithOptions(request, headers, runtime);
  }

  /**
   * 获取插件的校验规则
   * 
   * @param request - GetPluginRuleCheckInfoRequest
   * @param headers - GetPluginRuleCheckInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPluginRuleCheckInfoResponse
   */
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

  /**
   * 获取插件的校验规则
   * 
   * @param request - GetPluginRuleCheckInfoRequest
   * @returns GetPluginRuleCheckInfoResponse
   */
  async getPluginRuleCheckInfo(request: GetPluginRuleCheckInfoRequest): Promise<GetPluginRuleCheckInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPluginRuleCheckInfoHeaders({ });
    return await this.getPluginRuleCheckInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取工作台分组列表
   * 
   * @param request - ListWorkBenchGroupRequest
   * @param headers - ListWorkBenchGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListWorkBenchGroupResponse
   */
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

  /**
   * 获取工作台分组列表
   * 
   * @param request - ListWorkBenchGroupRequest
   * @returns ListWorkBenchGroupResponse
   */
  async listWorkBenchGroup(request: ListWorkBenchGroupRequest): Promise<ListWorkBenchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListWorkBenchGroupHeaders({ });
    return await this.listWorkBenchGroupWithOptions(request, headers, runtime);
  }

  /**
   * 工作台支持数字红点
   * 
   * @param request - ModifyWorkbenchBadgeRequest
   * @param headers - ModifyWorkbenchBadgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ModifyWorkbenchBadgeResponse
   */
  async modifyWorkbenchBadgeWithOptions(request: ModifyWorkbenchBadgeRequest, headers: ModifyWorkbenchBadgeHeaders, runtime: $Util.RuntimeOptions): Promise<ModifyWorkbenchBadgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizIdList)) {
      body["bizIdList"] = request.bizIdList;
    }

    if (!Util.isUnset(request.isAdded)) {
      body["isAdded"] = request.isAdded;
    }

    if (!Util.isUnset(request.modifyMode)) {
      body["modifyMode"] = request.modifyMode;
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

  /**
   * 工作台支持数字红点
   * 
   * @param request - ModifyWorkbenchBadgeRequest
   * @returns ModifyWorkbenchBadgeResponse
   */
  async modifyWorkbenchBadge(request: ModifyWorkbenchBadgeRequest): Promise<ModifyWorkbenchBadgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyWorkbenchBadgeHeaders({ });
    return await this.modifyWorkbenchBadgeWithOptions(request, headers, runtime);
  }

  /**
   * 工作台组件授权范围查询
   * 
   * @param headers - QueryComponentScopesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryComponentScopesResponse
   */
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

  /**
   * 工作台组件授权范围查询
   * @returns QueryComponentScopesResponse
   */
  async queryComponentScopes(componentId: string): Promise<QueryComponentScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryComponentScopesHeaders({ });
    return await this.queryComponentScopesWithOptions(componentId, headers, runtime);
  }

  /**
   * 查询快捷方式可见范围
   * 
   * @param headers - QueryShortcutScopesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryShortcutScopesResponse
   */
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

  /**
   * 查询快捷方式可见范围
   * @returns QueryShortcutScopesResponse
   */
  async queryShortcutScopes(shortcutKey: string): Promise<QueryShortcutScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryShortcutScopesHeaders({ });
    return await this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
  }

  /**
   * 工作台数字红点支持撤销已被删除的资源
   * 
   * @param request - UndoDeletionRequest
   * @param headers - UndoDeletionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UndoDeletionResponse
   */
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

  /**
   * 工作台数字红点支持撤销已被删除的资源
   * 
   * @param request - UndoDeletionRequest
   * @returns UndoDeletionResponse
   */
  async undoDeletion(request: UndoDeletionRequest): Promise<UndoDeletionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UndoDeletionHeaders({ });
    return await this.undoDeletionWithOptions(request, headers, runtime);
  }

  /**
   * 更新自定义工作台页面可见性
   * 
   * @param request - UpdateDingPortalPageScopeRequest
   * @param headers - UpdateDingPortalPageScopeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateDingPortalPageScopeResponse
   */
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

  /**
   * 更新自定义工作台页面可见性
   * 
   * @param request - UpdateDingPortalPageScopeRequest
   * @returns UpdateDingPortalPageScopeResponse
   */
  async updateDingPortalPageScope(pageUuid: string, appUuid: string, request: UpdateDingPortalPageScopeRequest): Promise<UpdateDingPortalPageScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDingPortalPageScopeHeaders({ });
    return await this.updateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
  }

}
