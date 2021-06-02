// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryResourceManagementMembersHeaders extends $tea.Model {
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

export class QueryResourceManagementMembersResponseBody extends $tea.Model {
  members?: QueryResourceManagementMembersResponseBodyMembers[];
  static names(): { [key: string]: string } {
    return {
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': QueryResourceManagementMembersResponseBodyMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryResourceManagementMembersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryResourceManagementMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryResourceManagementMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserManagementResourcesHeaders extends $tea.Model {
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

export class QueryUserManagementResourcesResponseBody extends $tea.Model {
  resourceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      resourceIds: 'resourceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resourceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserManagementResourcesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserManagementResourcesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserManagementResourcesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsHeaders extends $tea.Model {
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

export class ListManagementGroupsRequest extends $tea.Model {
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponseBody extends $tea.Model {
  nextToken?: number;
  hasMore?: boolean;
  groups?: ListManagementGroupsResponseBodyGroups[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      groups: 'groups',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      hasMore: 'boolean',
      groups: { 'type': 'array', 'itemType': ListManagementGroupsResponseBodyGroups },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListManagementGroupsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListManagementGroupsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupHeaders extends $tea.Model {
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

export class CreateManagementGroupRequest extends $tea.Model {
  groupName?: string;
  members?: CreateManagementGroupRequestMembers[];
  scope?: CreateManagementGroupRequestScope;
  resourceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      members: 'members',
      scope: 'scope',
      resourceIds: 'resourceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      members: { 'type': 'array', 'itemType': CreateManagementGroupRequestMembers },
      scope: CreateManagementGroupRequestScope,
      resourceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupResponseBody extends $tea.Model {
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateManagementGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateManagementGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupHeaders extends $tea.Model {
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

export class UpdateManagementGroupRequest extends $tea.Model {
  groupName?: string;
  members?: UpdateManagementGroupRequestMembers[];
  scope?: UpdateManagementGroupRequestScope;
  resourceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      members: 'members',
      scope: 'scope',
      resourceIds: 'resourceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      members: { 'type': 'array', 'itemType': UpdateManagementGroupRequestMembers },
      scope: UpdateManagementGroupRequestScope,
      resourceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupResponse extends $tea.Model {
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

export class DeleteManagementGroupHeaders extends $tea.Model {
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

export class DeleteManagementGroupResponse extends $tea.Model {
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

export class GetApplyInviteInfoHeaders extends $tea.Model {
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

export class GetApplyInviteInfoRequest extends $tea.Model {
  inviterUserId?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      inviterUserId: 'inviterUserId',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviterUserId: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoResponseBody extends $tea.Model {
  inviteSwitch?: boolean;
  searchNameInvite?: boolean;
  orgApplyCodeInvite?: boolean;
  linkInvite?: boolean;
  inviteUrl?: string;
  auditType?: number;
  empApplyJoinDept?: boolean;
  static names(): { [key: string]: string } {
    return {
      inviteSwitch: 'inviteSwitch',
      searchNameInvite: 'searchNameInvite',
      orgApplyCodeInvite: 'orgApplyCodeInvite',
      linkInvite: 'linkInvite',
      inviteUrl: 'inviteUrl',
      auditType: 'auditType',
      empApplyJoinDept: 'empApplyJoinDept',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteSwitch: 'boolean',
      searchNameInvite: 'boolean',
      orgApplyCodeInvite: 'boolean',
      linkInvite: 'boolean',
      inviteUrl: 'string',
      auditType: 'number',
      empApplyJoinDept: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApplyInviteInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetApplyInviteInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetApplyInviteInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataHeaders extends $tea.Model {
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

export class GetBranchAuthDataRequest extends $tea.Model {
  branchCorpId?: string;
  code?: string;
  body?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      branchCorpId: 'branchCorpId',
      code: 'code',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      branchCorpId: 'string',
      code: 'string',
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponseBody extends $tea.Model {
  result?: GetBranchAuthDataResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetBranchAuthDataResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetBranchAuthDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetBranchAuthDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLatestDingIndexHeaders extends $tea.Model {
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

export class GetLatestDingIndexResponseBody extends $tea.Model {
  statDate?: string;
  idxTotal?: number;
  idxEfficiency?: number;
  idxCarbon?: number;
  idxMonthlyAvg?: number;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
      idxTotal: 'idxTotal',
      idxEfficiency: 'idxEfficiency',
      idxCarbon: 'idxCarbon',
      idxMonthlyAvg: 'idxMonthlyAvg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
      idxTotal: 'number',
      idxEfficiency: 'number',
      idxCarbon: 'number',
      idxMonthlyAvg: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLatestDingIndexResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetLatestDingIndexResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetLatestDingIndexResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHeaders extends $tea.Model {
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

export class GetUserResponseBody extends $tea.Model {
  nick?: string;
  avatarUrl?: string;
  mobile?: string;
  openId?: string;
  unionId?: string;
  email?: string;
  stateCode?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      avatarUrl: 'avatarUrl',
      mobile: 'mobile',
      openId: 'openId',
      unionId: 'unionId',
      email: 'email',
      stateCode: 'stateCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      avatarUrl: 'string',
      mobile: 'string',
      openId: 'string',
      unionId: 'string',
      email: 'string',
      stateCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryResourceManagementMembersResponseBodyMembers extends $tea.Model {
  memberType?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      memberType: 'memberType',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberType: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponseBodyGroupsMembers extends $tea.Model {
  memberType?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      memberType: 'memberType',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberType: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponseBodyGroupsScope extends $tea.Model {
  scopeType?: number;
  deptIds?: number[];
  static names(): { [key: string]: string } {
    return {
      scopeType: 'scopeType',
      deptIds: 'deptIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeType: 'number',
      deptIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListManagementGroupsResponseBodyGroups extends $tea.Model {
  groupId?: string;
  groupName?: string;
  members?: ListManagementGroupsResponseBodyGroupsMembers[];
  scope?: ListManagementGroupsResponseBodyGroupsScope;
  resourceIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      groupName: 'groupName',
      members: 'members',
      scope: 'scope',
      resourceIds: 'resourceIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
      groupName: 'string',
      members: { 'type': 'array', 'itemType': ListManagementGroupsResponseBodyGroupsMembers },
      scope: ListManagementGroupsResponseBodyGroupsScope,
      resourceIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupRequestMembers extends $tea.Model {
  memberType?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      memberType: 'memberType',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberType: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateManagementGroupRequestScope extends $tea.Model {
  scopeType?: number;
  deptIds?: number[];
  static names(): { [key: string]: string } {
    return {
      scopeType: 'scopeType',
      deptIds: 'deptIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeType: 'number',
      deptIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupRequestMembers extends $tea.Model {
  memberType?: string;
  memberId?: string;
  static names(): { [key: string]: string } {
    return {
      memberType: 'memberType',
      memberId: 'memberId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberType: 'string',
      memberId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateManagementGroupRequestScope extends $tea.Model {
  scopeType?: number;
  deptIds?: number[];
  static names(): { [key: string]: string } {
    return {
      scopeType: 'scopeType',
      deptIds: 'deptIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeType: 'number',
      deptIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchAuthDataResponseBodyResult extends $tea.Model {
  fieldCode?: string;
  fieldName?: string;
  fieldValue?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldValue: 'fieldValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldValue: 'string',
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


  async queryResourceManagementMembers(resourceId: string): Promise<QueryResourceManagementMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryResourceManagementMembersHeaders({ });
    return await this.queryResourceManagementMembersWithOptions(resourceId, headers, runtime);
  }

  async queryResourceManagementMembersWithOptions(resourceId: string, headers: QueryResourceManagementMembersHeaders, runtime: $Util.RuntimeOptions): Promise<QueryResourceManagementMembersResponse> {
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
    return $tea.cast<QueryResourceManagementMembersResponse>(await this.doROARequest("QueryResourceManagementMembers", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/resources/${resourceId}/managementMembers`, "json", req, runtime), new QueryResourceManagementMembersResponse({}));
  }

  async queryUserManagementResources(userId: string): Promise<QueryUserManagementResourcesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserManagementResourcesHeaders({ });
    return await this.queryUserManagementResourcesWithOptions(userId, headers, runtime);
  }

  async queryUserManagementResourcesWithOptions(userId: string, headers: QueryUserManagementResourcesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserManagementResourcesResponse> {
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
    return $tea.cast<QueryUserManagementResourcesResponse>(await this.doROARequest("QueryUserManagementResources", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/users/${userId}/managemementResources`, "json", req, runtime), new QueryUserManagementResourcesResponse({}));
  }

  async listManagementGroups(request: ListManagementGroupsRequest): Promise<ListManagementGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListManagementGroupsHeaders({ });
    return await this.listManagementGroupsWithOptions(request, headers, runtime);
  }

  async listManagementGroupsWithOptions(request: ListManagementGroupsRequest, headers: ListManagementGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<ListManagementGroupsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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
    return $tea.cast<ListManagementGroupsResponse>(await this.doROARequest("ListManagementGroups", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/managementGroups`, "json", req, runtime), new ListManagementGroupsResponse({}));
  }

  async createManagementGroup(request: CreateManagementGroupRequest): Promise<CreateManagementGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateManagementGroupHeaders({ });
    return await this.createManagementGroupWithOptions(request, headers, runtime);
  }

  async createManagementGroupWithOptions(request: CreateManagementGroupRequest, headers: CreateManagementGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateManagementGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset($tea.toMap(request.scope))) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.resourceIds)) {
      body["resourceIds"] = request.resourceIds;
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
    return $tea.cast<CreateManagementGroupResponse>(await this.doROARequest("CreateManagementGroup", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/managementGroups`, "json", req, runtime), new CreateManagementGroupResponse({}));
  }

  async updateManagementGroup(groupId: string, request: UpdateManagementGroupRequest): Promise<UpdateManagementGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateManagementGroupHeaders({ });
    return await this.updateManagementGroupWithOptions(groupId, request, headers, runtime);
  }

  async updateManagementGroupWithOptions(groupId: string, request: UpdateManagementGroupRequest, headers: UpdateManagementGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateManagementGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset($tea.toMap(request.scope))) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.resourceIds)) {
      body["resourceIds"] = request.resourceIds;
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
    return $tea.cast<UpdateManagementGroupResponse>(await this.doROARequest("UpdateManagementGroup", "contact_1.0", "HTTP", "PUT", "AK", `/v1.0/contact/managementGroups/${groupId}`, "none", req, runtime), new UpdateManagementGroupResponse({}));
  }

  async deleteManagementGroup(groupId: string): Promise<DeleteManagementGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteManagementGroupHeaders({ });
    return await this.deleteManagementGroupWithOptions(groupId, headers, runtime);
  }

  async deleteManagementGroupWithOptions(groupId: string, headers: DeleteManagementGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteManagementGroupResponse> {
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
    return $tea.cast<DeleteManagementGroupResponse>(await this.doROARequest("DeleteManagementGroup", "contact_1.0", "HTTP", "DELETE", "AK", `/v1.0/contact/managementGroups/${groupId}`, "none", req, runtime), new DeleteManagementGroupResponse({}));
  }

  async getApplyInviteInfo(request: GetApplyInviteInfoRequest): Promise<GetApplyInviteInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApplyInviteInfoHeaders({ });
    return await this.getApplyInviteInfoWithOptions(request, headers, runtime);
  }

  async getApplyInviteInfoWithOptions(request: GetApplyInviteInfoRequest, headers: GetApplyInviteInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetApplyInviteInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.inviterUserId)) {
      query["inviterUserId"] = request.inviterUserId;
    }

    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
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
    return $tea.cast<GetApplyInviteInfoResponse>(await this.doROARequest("GetApplyInviteInfo", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/invites/infos`, "json", req, runtime), new GetApplyInviteInfoResponse({}));
  }

  async getBranchAuthData(request: GetBranchAuthDataRequest): Promise<GetBranchAuthDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBranchAuthDataHeaders({ });
    return await this.getBranchAuthDataWithOptions(request, headers, runtime);
  }

  async getBranchAuthDataWithOptions(request: GetBranchAuthDataRequest, headers: GetBranchAuthDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetBranchAuthDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.branchCorpId)) {
      query["branchCorpId"] = request.branchCorpId;
    }

    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    let body : {[key: string ]: string} = { };
    if (!Util.isUnset(request.body)) {
      body = request.body;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetBranchAuthDataResponse>(await this.doROARequest("GetBranchAuthData", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/branchAuthDatas/search`, "json", req, runtime), new GetBranchAuthDataResponse({}));
  }

  async getLatestDingIndex(): Promise<GetLatestDingIndexResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLatestDingIndexHeaders({ });
    return await this.getLatestDingIndexWithOptions(headers, runtime);
  }

  async getLatestDingIndexWithOptions(headers: GetLatestDingIndexHeaders, runtime: $Util.RuntimeOptions): Promise<GetLatestDingIndexResponse> {
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
    return $tea.cast<GetLatestDingIndexResponse>(await this.doROARequest("GetLatestDingIndex", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/dingIndexs`, "json", req, runtime), new GetLatestDingIndexResponse({}));
  }

  async getUser(unionId: string): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(unionId, headers, runtime);
  }

  async getUserWithOptions(unionId: string, headers: GetUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserResponse> {
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
    return $tea.cast<GetUserResponse>(await this.doROARequest("GetUser", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/users/${unionId}`, "json", req, runtime), new GetUserResponse({}));
  }

}
