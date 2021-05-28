// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateInnerAppHeaders extends $tea.Model {
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

export class CreateInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  ipWhiteList?: string[];
  scopeType?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
      ipWhiteList: 'ipWhiteList',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
      scopeType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInnerAppResponseBody extends $tea.Model {
  agentId?: number;
  appKey?: string;
  appSecret?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appKey: 'appKey',
      appSecret: 'appSecret',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appKey: 'string',
      appSecret: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerAppHeaders extends $tea.Model {
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

export class GetInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerAppResponseBody extends $tea.Model {
  agentId?: number;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  appKey?: string;
  appSecret?: string;
  ipWhiteList?: string[];
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
      appKey: 'appKey',
      appSecret: 'appSecret',
      ipWhiteList: 'ipWhiteList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
      appKey: 'string',
      appSecret: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCustomAppRoleHeaders extends $tea.Model {
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

export class RegisterCustomAppRoleRequest extends $tea.Model {
  opUserId?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCustomAppRoleResponseBody extends $tea.Model {
  roleId?: number;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCustomAppRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RegisterCustomAppRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RegisterCustomAppRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppRolesToMemberHeaders extends $tea.Model {
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

export class AddAppRolesToMemberRequest extends $tea.Model {
  opUserId?: string;
  memberId?: string;
  memberType?: string;
  roleList?: AddAppRolesToMemberRequestRoleList[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      memberId: 'memberId',
      memberType: 'memberType',
      roleList: 'roleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      memberId: 'string',
      memberType: 'string',
      roleList: { 'type': 'array', 'itemType': AddAppRolesToMemberRequestRoleList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppRolesToMemberResponseBody extends $tea.Model {
  result?: AddAppRolesToMemberResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': AddAppRolesToMemberResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppRolesToMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddAppRolesToMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddAppRolesToMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppRoleScopeByRoleIdHeaders extends $tea.Model {
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

export class GetAppRoleScopeByRoleIdResponseBody extends $tea.Model {
  roleName?: string;
  roleId?: number;
  scopeType?: string;
  deptIdList?: number[];
  userIdList?: string[];
  scopeVersion?: string;
  static names(): { [key: string]: string } {
    return {
      roleName: 'roleName',
      roleId: 'roleId',
      scopeType: 'scopeType',
      deptIdList: 'deptIdList',
      userIdList: 'userIdList',
      scopeVersion: 'scopeVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleName: 'string',
      roleId: 'number',
      scopeType: 'string',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      userIdList: { 'type': 'array', 'itemType': 'string' },
      scopeVersion: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAppRoleScopeByRoleIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAppRoleScopeByRoleIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAppRoleScopeByRoleIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRoleInfoByUserHeaders extends $tea.Model {
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

export class ListRoleInfoByUserResponseBody extends $tea.Model {
  result?: ListRoleInfoByUserResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListRoleInfoByUserResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRoleInfoByUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListRoleInfoByUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListRoleInfoByUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppHeaders extends $tea.Model {
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

export class ListInnerAppRequest extends $tea.Model {
  ecologicalCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      ecologicalCorpId: 'ecologicalCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ecologicalCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppResponseBody extends $tea.Model {
  appList?: ListInnerAppResponseBodyAppList[];
  static names(): { [key: string]: string } {
    return {
      appList: 'appList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appList: { 'type': 'array', 'itemType': ListInnerAppResponseBodyAppList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveMemberForAppRoleHeaders extends $tea.Model {
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

export class RemoveMemberForAppRoleRequest extends $tea.Model {
  opUserId?: string;
  scopeVersion?: number;
  deptIdList?: number[];
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      scopeVersion: 'scopeVersion',
      deptIdList: 'deptIdList',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      scopeVersion: 'number',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveMemberForAppRoleResponseBody extends $tea.Model {
  latestScopeVersion?: number;
  static names(): { [key: string]: string } {
    return {
      latestScopeVersion: 'latestScopeVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      latestScopeVersion: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveMemberForAppRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RemoveMemberForAppRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RemoveMemberForAppRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInnerAppHeaders extends $tea.Model {
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

export class UpdateInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  ipWhiteList?: string[];
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
      ipWhiteList: 'ipWhiteList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInnerAppResponseBody extends $tea.Model {
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

export class UpdateInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMemberToAppRoleHeaders extends $tea.Model {
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

export class AddMemberToAppRoleRequest extends $tea.Model {
  opUserId?: string;
  scopeVersion?: number;
  deptIdList?: number[];
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      scopeVersion: 'scopeVersion',
      deptIdList: 'deptIdList',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      scopeVersion: 'number',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMemberToAppRoleResponseBody extends $tea.Model {
  latestScopeVersion?: number;
  static names(): { [key: string]: string } {
    return {
      latestScopeVersion: 'latestScopeVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      latestScopeVersion: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMemberToAppRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddMemberToAppRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddMemberToAppRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAppRoleScopesHeaders extends $tea.Model {
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

export class ListAppRoleScopesRequest extends $tea.Model {
  nextToken?: number;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAppRoleScopesResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  dataList?: ListAppRoleScopesResponseBodyDataList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      dataList: 'dataList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      dataList: { 'type': 'array', 'itemType': ListAppRoleScopesResponseBodyDataList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAppRoleScopesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAppRoleScopesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAppRoleScopesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppToWorkBenchGroupHeaders extends $tea.Model {
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

export class AddAppToWorkBenchGroupRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  componentId?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
      componentId: 'componentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
      componentId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppToWorkBenchGroupResponseBody extends $tea.Model {
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

export class AddAppToWorkBenchGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddAppToWorkBenchGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddAppToWorkBenchGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RebuildRoleScopeForAppRoleHeaders extends $tea.Model {
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

export class RebuildRoleScopeForAppRoleRequest extends $tea.Model {
  opUserId?: string;
  scopeVersion?: number;
  scopeType?: string;
  deptIdList?: number[];
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      scopeVersion: 'scopeVersion',
      scopeType: 'scopeType',
      deptIdList: 'deptIdList',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      scopeVersion: 'number',
      scopeType: 'string',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RebuildRoleScopeForAppRoleResponseBody extends $tea.Model {
  latestScopeVersion?: number;
  static names(): { [key: string]: string } {
    return {
      latestScopeVersion: 'latestScopeVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      latestScopeVersion: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RebuildRoleScopeForAppRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RebuildRoleScopeForAppRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RebuildRoleScopeForAppRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAppRoleHeaders extends $tea.Model {
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

export class DeleteAppRoleRequest extends $tea.Model {
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAppRoleResponseBody extends $tea.Model {
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

export class DeleteAppRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteAppRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteAppRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInnerAppHeaders extends $tea.Model {
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

export class DeleteInnerAppRequest extends $tea.Model {
  opUnionId?: string;
  ecologicalCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
      ecologicalCorpId: 'ecologicalCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
      ecologicalCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInnerAppResponseBody extends $tea.Model {
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

export class DeleteInnerAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteInnerAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteInnerAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAppRoleInfoHeaders extends $tea.Model {
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

export class UpdateAppRoleInfoRequest extends $tea.Model {
  opUserId?: string;
  newRoleName?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      newRoleName: 'newRoleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      newRoleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAppRoleInfoResponseBody extends $tea.Model {
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

export class UpdateAppRoleInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateAppRoleInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateAppRoleInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppRolesToMemberRequestRoleList extends $tea.Model {
  roleId?: number;
  scopeVersion?: number;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
      scopeVersion: 'scopeVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'number',
      scopeVersion: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddAppRolesToMemberResponseBodyResult extends $tea.Model {
  roleId?: number;
  latestScopeVersion?: number;
  success?: boolean;
  subErrorCode?: string;
  subErrorMsg?: string;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
      latestScopeVersion: 'latestScopeVersion',
      success: 'success',
      subErrorCode: 'subErrorCode',
      subErrorMsg: 'subErrorMsg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'number',
      latestScopeVersion: 'number',
      success: 'boolean',
      subErrorCode: 'string',
      subErrorMsg: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRoleInfoByUserResponseBodyResult extends $tea.Model {
  roleName?: string;
  roleId?: number;
  static names(): { [key: string]: string } {
    return {
      roleName: 'roleName',
      roleId: 'roleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleName: 'string',
      roleId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppResponseBodyAppList extends $tea.Model {
  agentId?: number;
  name?: string;
  desc?: string;
  icon?: string;
  homepageLink?: string;
  pcHomepageLink?: string;
  ompLink?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      name: 'name',
      desc: 'desc',
      icon: 'icon',
      homepageLink: 'homepageLink',
      pcHomepageLink: 'pcHomepageLink',
      ompLink: 'ompLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      name: 'string',
      desc: 'string',
      icon: 'string',
      homepageLink: 'string',
      pcHomepageLink: 'string',
      ompLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAppRoleScopesResponseBodyDataList extends $tea.Model {
  roleName?: string;
  roleId?: number;
  scopeType?: string;
  deptIdList?: number[];
  userIdList?: string[];
  scopeVersion?: number;
  static names(): { [key: string]: string } {
    return {
      roleName: 'roleName',
      roleId: 'roleId',
      scopeType: 'scopeType',
      deptIdList: 'deptIdList',
      userIdList: 'userIdList',
      scopeVersion: 'scopeVersion',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleName: 'string',
      roleId: 'number',
      scopeType: 'string',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      userIdList: { 'type': 'array', 'itemType': 'string' },
      scopeVersion: 'number',
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


  async createInnerApp(request: CreateInnerAppRequest): Promise<CreateInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInnerAppHeaders({ });
    return await this.createInnerAppWithOptions(request, headers, runtime);
  }

  async createInnerAppWithOptions(request: CreateInnerAppRequest, headers: CreateInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInnerAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      body["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.homepageLink)) {
      body["homepageLink"] = request.homepageLink;
    }

    if (!Util.isUnset(request.pcHomepageLink)) {
      body["pcHomepageLink"] = request.pcHomepageLink;
    }

    if (!Util.isUnset(request.ompLink)) {
      body["ompLink"] = request.ompLink;
    }

    if (!Util.isUnset(request.ipWhiteList)) {
      body["ipWhiteList"] = request.ipWhiteList;
    }

    if (!Util.isUnset(request.scopeType)) {
      body["scopeType"] = request.scopeType;
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
    return $tea.cast<CreateInnerAppResponse>(await this.doROARequest("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps`, "json", req, runtime), new CreateInnerAppResponse({}));
  }

  async getInnerApp(agentId: string, request: GetInnerAppRequest): Promise<GetInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInnerAppHeaders({ });
    return await this.getInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async getInnerAppWithOptions(agentId: string, request: GetInnerAppRequest, headers: GetInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<GetInnerAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      query["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
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
    return $tea.cast<GetInnerAppResponse>(await this.doROARequest("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new GetInnerAppResponse({}));
  }

  async registerCustomAppRole(agentId: string, request: RegisterCustomAppRoleRequest): Promise<RegisterCustomAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterCustomAppRoleHeaders({ });
    return await this.registerCustomAppRoleWithOptions(agentId, request, headers, runtime);
  }

  async registerCustomAppRoleWithOptions(agentId: string, request: RegisterCustomAppRoleRequest, headers: RegisterCustomAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterCustomAppRoleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.roleName)) {
      body["roleName"] = request.roleName;
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
    return $tea.cast<RegisterCustomAppRoleResponse>(await this.doROARequest("RegisterCustomAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles`, "json", req, runtime), new RegisterCustomAppRoleResponse({}));
  }

  async addAppRolesToMember(agentId: string, request: AddAppRolesToMemberRequest): Promise<AddAppRolesToMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAppRolesToMemberHeaders({ });
    return await this.addAppRolesToMemberWithOptions(agentId, request, headers, runtime);
  }

  async addAppRolesToMemberWithOptions(agentId: string, request: AddAppRolesToMemberRequest, headers: AddAppRolesToMemberHeaders, runtime: $Util.RuntimeOptions): Promise<AddAppRolesToMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.memberId)) {
      body["memberId"] = request.memberId;
    }

    if (!Util.isUnset(request.memberType)) {
      body["memberType"] = request.memberType;
    }

    if (!Util.isUnset(request.roleList)) {
      body["roleList"] = request.roleList;
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
    return $tea.cast<AddAppRolesToMemberResponse>(await this.doROARequest("AddAppRolesToMember", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apps/${agentId}/members/roles`, "json", req, runtime), new AddAppRolesToMemberResponse({}));
  }

  async getAppRoleScopeByRoleId(agentId: string, roleId: string): Promise<GetAppRoleScopeByRoleIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAppRoleScopeByRoleIdHeaders({ });
    return await this.getAppRoleScopeByRoleIdWithOptions(agentId, roleId, headers, runtime);
  }

  async getAppRoleScopeByRoleIdWithOptions(agentId: string, roleId: string, headers: GetAppRoleScopeByRoleIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetAppRoleScopeByRoleIdResponse> {
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
    return $tea.cast<GetAppRoleScopeByRoleIdResponse>(await this.doROARequest("GetAppRoleScopeByRoleId", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/scopes`, "json", req, runtime), new GetAppRoleScopeByRoleIdResponse({}));
  }

  async listRoleInfoByUser(agentId: string, userId: string): Promise<ListRoleInfoByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRoleInfoByUserHeaders({ });
    return await this.listRoleInfoByUserWithOptions(agentId, userId, headers, runtime);
  }

  async listRoleInfoByUserWithOptions(agentId: string, userId: string, headers: ListRoleInfoByUserHeaders, runtime: $Util.RuntimeOptions): Promise<ListRoleInfoByUserResponse> {
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
    return $tea.cast<ListRoleInfoByUserResponse>(await this.doROARequest("ListRoleInfoByUser", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/users/${userId}/roles`, "json", req, runtime), new ListRoleInfoByUserResponse({}));
  }

  async listInnerApp(request: ListInnerAppRequest): Promise<ListInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListInnerAppHeaders({ });
    return await this.listInnerAppWithOptions(request, headers, runtime);
  }

  async listInnerAppWithOptions(request: ListInnerAppRequest, headers: ListInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<ListInnerAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
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
    return $tea.cast<ListInnerAppResponse>(await this.doROARequest("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps`, "json", req, runtime), new ListInnerAppResponse({}));
  }

  async removeMemberForAppRole(agentId: string, roleId: string, request: RemoveMemberForAppRoleRequest): Promise<RemoveMemberForAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveMemberForAppRoleHeaders({ });
    return await this.removeMemberForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async removeMemberForAppRoleWithOptions(agentId: string, roleId: string, request: RemoveMemberForAppRoleRequest, headers: RemoveMemberForAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveMemberForAppRoleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.scopeVersion)) {
      body["scopeVersion"] = request.scopeVersion;
    }

    if (!Util.isUnset(request.deptIdList)) {
      body["deptIdList"] = request.deptIdList;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<RemoveMemberForAppRoleResponse>(await this.doROARequest("RemoveMemberForAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/members/batchRemove`, "json", req, runtime), new RemoveMemberForAppRoleResponse({}));
  }

  async updateInnerApp(agentId: string, request: UpdateInnerAppRequest): Promise<UpdateInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInnerAppHeaders({ });
    return await this.updateInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async updateInnerAppWithOptions(agentId: string, request: UpdateInnerAppRequest, headers: UpdateInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInnerAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      body["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.homepageLink)) {
      body["homepageLink"] = request.homepageLink;
    }

    if (!Util.isUnset(request.pcHomepageLink)) {
      body["pcHomepageLink"] = request.pcHomepageLink;
    }

    if (!Util.isUnset(request.ompLink)) {
      body["ompLink"] = request.ompLink;
    }

    if (!Util.isUnset(request.ipWhiteList)) {
      body["ipWhiteList"] = request.ipWhiteList;
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
    return $tea.cast<UpdateInnerAppResponse>(await this.doROARequest("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new UpdateInnerAppResponse({}));
  }

  async addMemberToAppRole(agentId: string, roleId: string, request: AddMemberToAppRoleRequest): Promise<AddMemberToAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddMemberToAppRoleHeaders({ });
    return await this.addMemberToAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async addMemberToAppRoleWithOptions(agentId: string, roleId: string, request: AddMemberToAppRoleRequest, headers: AddMemberToAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<AddMemberToAppRoleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.scopeVersion)) {
      body["scopeVersion"] = request.scopeVersion;
    }

    if (!Util.isUnset(request.deptIdList)) {
      body["deptIdList"] = request.deptIdList;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<AddMemberToAppRoleResponse>(await this.doROARequest("AddMemberToAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/members`, "json", req, runtime), new AddMemberToAppRoleResponse({}));
  }

  async listAppRoleScopes(agentId: string, request: ListAppRoleScopesRequest): Promise<ListAppRoleScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAppRoleScopesHeaders({ });
    return await this.listAppRoleScopesWithOptions(agentId, request, headers, runtime);
  }

  async listAppRoleScopesWithOptions(agentId: string, request: ListAppRoleScopesRequest, headers: ListAppRoleScopesHeaders, runtime: $Util.RuntimeOptions): Promise<ListAppRoleScopesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
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
    return $tea.cast<ListAppRoleScopesResponse>(await this.doROARequest("ListAppRoleScopes", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/roles`, "json", req, runtime), new ListAppRoleScopesResponse({}));
  }

  async addAppToWorkBenchGroup(agentId: string, request: AddAppToWorkBenchGroupRequest): Promise<AddAppToWorkBenchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAppToWorkBenchGroupHeaders({ });
    return await this.addAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
  }

  async addAppToWorkBenchGroupWithOptions(agentId: string, request: AddAppToWorkBenchGroupRequest, headers: AddAppToWorkBenchGroupHeaders, runtime: $Util.RuntimeOptions): Promise<AddAppToWorkBenchGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      body["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.componentId)) {
      body["componentId"] = request.componentId;
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
    return $tea.cast<AddAppToWorkBenchGroupResponse>(await this.doROARequest("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/addToWorkBenchGroup`, "json", req, runtime), new AddAppToWorkBenchGroupResponse({}));
  }

  async rebuildRoleScopeForAppRole(agentId: string, roleId: string, request: RebuildRoleScopeForAppRoleRequest): Promise<RebuildRoleScopeForAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RebuildRoleScopeForAppRoleHeaders({ });
    return await this.rebuildRoleScopeForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async rebuildRoleScopeForAppRoleWithOptions(agentId: string, roleId: string, request: RebuildRoleScopeForAppRoleRequest, headers: RebuildRoleScopeForAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<RebuildRoleScopeForAppRoleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.scopeVersion)) {
      body["scopeVersion"] = request.scopeVersion;
    }

    if (!Util.isUnset(request.scopeType)) {
      body["scopeType"] = request.scopeType;
    }

    if (!Util.isUnset(request.deptIdList)) {
      body["deptIdList"] = request.deptIdList;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<RebuildRoleScopeForAppRoleResponse>(await this.doROARequest("RebuildRoleScopeForAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/scopes/rebuild`, "json", req, runtime), new RebuildRoleScopeForAppRoleResponse({}));
  }

  async deleteAppRole(agentId: string, roleId: string, request: DeleteAppRoleRequest): Promise<DeleteAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAppRoleHeaders({ });
    return await this.deleteAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async deleteAppRoleWithOptions(agentId: string, roleId: string, request: DeleteAppRoleRequest, headers: DeleteAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAppRoleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<DeleteAppRoleResponse>(await this.doROARequest("DeleteAppRole", "microApp_1.0", "HTTP", "DELETE", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}`, "json", req, runtime), new DeleteAppRoleResponse({}));
  }

  async deleteInnerApp(agentId: string, request: DeleteInnerAppRequest): Promise<DeleteInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInnerAppHeaders({ });
    return await this.deleteInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async deleteInnerAppWithOptions(agentId: string, request: DeleteInnerAppRequest, headers: DeleteInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteInnerAppResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUnionId)) {
      query["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
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
    return $tea.cast<DeleteInnerAppResponse>(await this.doROARequest("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new DeleteInnerAppResponse({}));
  }

  async updateAppRoleInfo(agentId: string, roleId: string, request: UpdateAppRoleInfoRequest): Promise<UpdateAppRoleInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateAppRoleInfoHeaders({ });
    return await this.updateAppRoleInfoWithOptions(agentId, roleId, request, headers, runtime);
  }

  async updateAppRoleInfoWithOptions(agentId: string, roleId: string, request: UpdateAppRoleInfoRequest, headers: UpdateAppRoleInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateAppRoleInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.newRoleName)) {
      body["newRoleName"] = request.newRoleName;
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
    return $tea.cast<UpdateAppRoleInfoResponse>(await this.doROARequest("UpdateAppRoleInfo", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}`, "json", req, runtime), new UpdateAppRoleInfoResponse({}));
  }

}
