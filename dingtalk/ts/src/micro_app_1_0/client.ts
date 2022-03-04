// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  memberId?: string;
  memberType?: string;
  opUserId?: string;
  roleList?: AddAppRolesToMemberRequestRoleList[];
  static names(): { [key: string]: string } {
    return {
      memberId: 'memberId',
      memberType: 'memberType',
      opUserId: 'opUserId',
      roleList: 'roleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberId: 'string',
      memberType: 'string',
      opUserId: 'string',
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
  componentId?: string;
  ecologicalCorpId?: string;
  opUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      componentId: 'componentId',
      ecologicalCorpId: 'ecologicalCorpId',
      opUnionId: 'opUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentId: 'string',
      ecologicalCorpId: 'string',
      opUnionId: 'string',
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
  deptIdList?: number[];
  opUserId?: string;
  scopeVersion?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIdList: 'deptIdList',
      opUserId: 'opUserId',
      scopeVersion: 'scopeVersion',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      scopeVersion: 'number',
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

export class CreateApaasAppHeaders extends $tea.Model {
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

export class CreateApaasAppRequest extends $tea.Model {
  appDesc?: string;
  appIcon?: string;
  appName?: string;
  bizAppId?: string;
  homepageEditLink?: string;
  homepageLink?: string;
  isShortCut?: number;
  ompLink?: string;
  opUserId?: string;
  pcHomepageEditLink?: string;
  pcHomepageLink?: string;
  templateKey?: string;
  static names(): { [key: string]: string } {
    return {
      appDesc: 'appDesc',
      appIcon: 'appIcon',
      appName: 'appName',
      bizAppId: 'bizAppId',
      homepageEditLink: 'homepageEditLink',
      homepageLink: 'homepageLink',
      isShortCut: 'isShortCut',
      ompLink: 'ompLink',
      opUserId: 'opUserId',
      pcHomepageEditLink: 'pcHomepageEditLink',
      pcHomepageLink: 'pcHomepageLink',
      templateKey: 'templateKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appDesc: 'string',
      appIcon: 'string',
      appName: 'string',
      bizAppId: 'string',
      homepageEditLink: 'string',
      homepageLink: 'string',
      isShortCut: 'number',
      ompLink: 'string',
      opUserId: 'string',
      pcHomepageEditLink: 'string',
      pcHomepageLink: 'string',
      templateKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApaasAppResponseBody extends $tea.Model {
  agentId?: number;
  bizAppId?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      bizAppId: 'bizAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      bizAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApaasAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateApaasAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateApaasAppResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  desc?: string;
  homepageLink?: string;
  icon?: string;
  ipWhiteList?: string[];
  name?: string;
  ompLink?: string;
  opUnionId?: string;
  pcHomepageLink?: string;
  scopeType?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      homepageLink: 'homepageLink',
      icon: 'icon',
      ipWhiteList: 'ipWhiteList',
      name: 'name',
      ompLink: 'ompLink',
      opUnionId: 'opUnionId',
      pcHomepageLink: 'pcHomepageLink',
      scopeType: 'scopeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      homepageLink: 'string',
      icon: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      ompLink: 'string',
      opUnionId: 'string',
      pcHomepageLink: 'string',
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
  static names(): { [key: string]: string } {
    return {
      opUnionId: 'opUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUnionId: 'string',
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

export class GetApaasAppHeaders extends $tea.Model {
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

export class GetApaasAppResponseBody extends $tea.Model {
  agentId?: number;
  bizAppId?: string;
  publishStatus?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      bizAppId: 'bizAppId',
      publishStatus: 'publishStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      bizAppId: 'string',
      publishStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetApaasAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetApaasAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetApaasAppResponseBody,
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
  canManageRole?: boolean;
  deptIdList?: number[];
  roleId?: number;
  roleName?: string;
  scopeType?: string;
  scopeVersion?: string;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      canManageRole: 'canManageRole',
      deptIdList: 'deptIdList',
      roleId: 'roleId',
      roleName: 'roleName',
      scopeType: 'scopeType',
      scopeVersion: 'scopeVersion',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canManageRole: 'boolean',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      roleId: 'number',
      roleName: 'string',
      scopeType: 'string',
      scopeVersion: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
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
  ecologicalCorpId?: string;
  opUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      ecologicalCorpId: 'ecologicalCorpId',
      opUnionId: 'opUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ecologicalCorpId: 'string',
      opUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerAppResponseBody extends $tea.Model {
  agentId?: number;
  appKey?: string;
  appSecret?: string;
  desc?: string;
  homepageLink?: string;
  icon?: string;
  ipWhiteList?: string[];
  name?: string;
  ompLink?: string;
  pcHomepageLink?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appKey: 'appKey',
      appSecret: 'appSecret',
      desc: 'desc',
      homepageLink: 'homepageLink',
      icon: 'icon',
      ipWhiteList: 'ipWhiteList',
      name: 'name',
      ompLink: 'ompLink',
      pcHomepageLink: 'pcHomepageLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appKey: 'string',
      appSecret: 'string',
      desc: 'string',
      homepageLink: 'string',
      icon: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      ompLink: 'string',
      pcHomepageLink: 'string',
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

export class GetMicroAppScopeHeaders extends $tea.Model {
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

export class GetMicroAppScopeResponseBody extends $tea.Model {
  result?: GetMicroAppScopeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetMicroAppScopeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMicroAppScopeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMicroAppScopeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMicroAppScopeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMicroAppUserAccessHeaders extends $tea.Model {
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

export class GetMicroAppUserAccessResponseBody extends $tea.Model {
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

export class GetMicroAppUserAccessResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMicroAppUserAccessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMicroAppUserAccessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllAppHeaders extends $tea.Model {
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

export class ListAllAppResponseBody extends $tea.Model {
  appList?: ListAllAppResponseBodyAppList[];
  static names(): { [key: string]: string } {
    return {
      appList: 'appList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appList: { 'type': 'array', 'itemType': ListAllAppResponseBodyAppList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListAllAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListAllAppResponseBody,
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
  dataList?: ListAppRoleScopesResponseBodyDataList[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': ListAppRoleScopesResponseBodyDataList },
      hasMore: 'boolean',
      nextToken: 'number',
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

export class ListUserVilebleAppHeaders extends $tea.Model {
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

export class ListUserVilebleAppResponseBody extends $tea.Model {
  appList?: ListUserVilebleAppResponseBodyAppList[];
  static names(): { [key: string]: string } {
    return {
      appList: 'appList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appList: { 'type': 'array', 'itemType': ListUserVilebleAppResponseBodyAppList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVilebleAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListUserVilebleAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListUserVilebleAppResponseBody,
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
  deptIdList?: number[];
  opUserId?: string;
  scopeType?: string;
  scopeVersion?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIdList: 'deptIdList',
      opUserId: 'opUserId',
      scopeType: 'scopeType',
      scopeVersion: 'scopeVersion',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      scopeType: 'string',
      scopeVersion: 'number',
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
  canManageRole?: boolean;
  opUserId?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      canManageRole: 'canManageRole',
      opUserId: 'opUserId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canManageRole: 'boolean',
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

export class RemoveApaasAppHeaders extends $tea.Model {
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

export class RemoveApaasAppRequest extends $tea.Model {
  bizAppId?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizAppId: 'bizAppId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizAppId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveApaasAppResponseBody extends $tea.Model {
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

export class RemoveApaasAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RemoveApaasAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RemoveApaasAppResponseBody,
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
  deptIdList?: number[];
  opUserId?: string;
  scopeVersion?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIdList: 'deptIdList',
      opUserId: 'opUserId',
      scopeVersion: 'scopeVersion',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      scopeVersion: 'number',
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

export class SetMicroAppScopeHeaders extends $tea.Model {
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

export class SetMicroAppScopeRequest extends $tea.Model {
  addDeptIds?: number[];
  addRoleIds?: number[];
  addUserIds?: string[];
  delDeptIds?: number[];
  delRoleIds?: number[];
  delUserIds?: string[];
  onlyAdminVisible?: boolean;
  static names(): { [key: string]: string } {
    return {
      addDeptIds: 'addDeptIds',
      addRoleIds: 'addRoleIds',
      addUserIds: 'addUserIds',
      delDeptIds: 'delDeptIds',
      delRoleIds: 'delRoleIds',
      delUserIds: 'delUserIds',
      onlyAdminVisible: 'onlyAdminVisible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      addDeptIds: { 'type': 'array', 'itemType': 'number' },
      addRoleIds: { 'type': 'array', 'itemType': 'number' },
      addUserIds: { 'type': 'array', 'itemType': 'string' },
      delDeptIds: { 'type': 'array', 'itemType': 'number' },
      delRoleIds: { 'type': 'array', 'itemType': 'number' },
      delUserIds: { 'type': 'array', 'itemType': 'string' },
      onlyAdminVisible: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetMicroAppScopeResponseBody extends $tea.Model {
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

export class SetMicroAppScopeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SetMicroAppScopeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SetMicroAppScopeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApaasAppHeaders extends $tea.Model {
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

export class UpdateApaasAppRequest extends $tea.Model {
  appIcon?: string;
  appName?: string;
  appStatus?: number;
  bizAppId?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      appIcon: 'appIcon',
      appName: 'appName',
      appStatus: 'appStatus',
      bizAppId: 'bizAppId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appIcon: 'string',
      appName: 'string',
      appStatus: 'number',
      bizAppId: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApaasAppResponseBody extends $tea.Model {
  agentId?: number;
  bizAppId?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      bizAppId: 'bizAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      bizAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApaasAppResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateApaasAppResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateApaasAppResponseBody,
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
  canManageRole?: boolean;
  newRoleName?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      canManageRole: 'canManageRole',
      newRoleName: 'newRoleName',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canManageRole: 'boolean',
      newRoleName: 'string',
      opUserId: 'string',
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
  desc?: string;
  homepageLink?: string;
  icon?: string;
  ipWhiteList?: string[];
  name?: string;
  ompLink?: string;
  opUnionId?: string;
  pcHomepageLink?: string;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      homepageLink: 'homepageLink',
      icon: 'icon',
      ipWhiteList: 'ipWhiteList',
      name: 'name',
      ompLink: 'ompLink',
      opUnionId: 'opUnionId',
      pcHomepageLink: 'pcHomepageLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      homepageLink: 'string',
      icon: 'string',
      ipWhiteList: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      ompLink: 'string',
      opUnionId: 'string',
      pcHomepageLink: 'string',
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
  latestScopeVersion?: number;
  roleId?: number;
  subErrorCode?: string;
  subErrorMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      latestScopeVersion: 'latestScopeVersion',
      roleId: 'roleId',
      subErrorCode: 'subErrorCode',
      subErrorMsg: 'subErrorMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      latestScopeVersion: 'number',
      roleId: 'number',
      subErrorCode: 'string',
      subErrorMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMicroAppScopeResponseBodyResult extends $tea.Model {
  deptIds?: number[];
  onlyAdminVisible?: boolean;
  roleIds?: number[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      onlyAdminVisible: 'onlyAdminVisible',
      roleIds: 'roleIds',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      onlyAdminVisible: 'boolean',
      roleIds: { 'type': 'array', 'itemType': 'number' },
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAllAppResponseBodyAppList extends $tea.Model {
  agentId?: number;
  appId?: number;
  appStatus?: number;
  desc?: string;
  developType?: number;
  homepageLink?: string;
  icon?: string;
  name?: string;
  ompLink?: string;
  pcHomepageLink?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appId: 'appId',
      appStatus: 'appStatus',
      desc: 'desc',
      developType: 'developType',
      homepageLink: 'homepageLink',
      icon: 'icon',
      name: 'name',
      ompLink: 'ompLink',
      pcHomepageLink: 'pcHomepageLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appId: 'number',
      appStatus: 'number',
      desc: 'string',
      developType: 'number',
      homepageLink: 'string',
      icon: 'string',
      name: 'string',
      ompLink: 'string',
      pcHomepageLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAppRoleScopesResponseBodyDataList extends $tea.Model {
  canManageRole?: boolean;
  deptIdList?: number[];
  roleId?: number;
  roleName?: string;
  scopeType?: string;
  scopeVersion?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      canManageRole: 'canManageRole',
      deptIdList: 'deptIdList',
      roleId: 'roleId',
      roleName: 'roleName',
      scopeType: 'scopeType',
      scopeVersion: 'scopeVersion',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canManageRole: 'boolean',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      roleId: 'number',
      roleName: 'string',
      scopeType: 'string',
      scopeVersion: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListInnerAppResponseBodyAppList extends $tea.Model {
  agentId?: number;
  desc?: string;
  homepageLink?: string;
  icon?: string;
  name?: string;
  ompLink?: string;
  pcHomepageLink?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      desc: 'desc',
      homepageLink: 'homepageLink',
      icon: 'icon',
      name: 'name',
      ompLink: 'ompLink',
      pcHomepageLink: 'pcHomepageLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      desc: 'string',
      homepageLink: 'string',
      icon: 'string',
      name: 'string',
      ompLink: 'string',
      pcHomepageLink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListRoleInfoByUserResponseBodyResult extends $tea.Model {
  canManageRole?: boolean;
  roleId?: number;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      canManageRole: 'canManageRole',
      roleId: 'roleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canManageRole: 'boolean',
      roleId: 'number',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserVilebleAppResponseBodyAppList extends $tea.Model {
  agentId?: number;
  appId?: number;
  appStatus?: number;
  desc?: string;
  developType?: number;
  homepageLink?: string;
  icon?: string;
  name?: string;
  ompLink?: string;
  pcHomepageLink?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appId: 'appId',
      appStatus: 'appStatus',
      desc: 'desc',
      developType: 'developType',
      homepageLink: 'homepageLink',
      icon: 'icon',
      name: 'name',
      ompLink: 'ompLink',
      pcHomepageLink: 'pcHomepageLink',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appId: 'number',
      appStatus: 'number',
      desc: 'string',
      developType: 'number',
      homepageLink: 'string',
      icon: 'string',
      name: 'string',
      ompLink: 'string',
      pcHomepageLink: 'string',
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


  async addAppRolesToMember(agentId: string, request: AddAppRolesToMemberRequest): Promise<AddAppRolesToMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAppRolesToMemberHeaders({ });
    return await this.addAppRolesToMemberWithOptions(agentId, request, headers, runtime);
  }

  async addAppRolesToMemberWithOptions(agentId: string, request: AddAppRolesToMemberRequest, headers: AddAppRolesToMemberHeaders, runtime: $Util.RuntimeOptions): Promise<AddAppRolesToMemberResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.memberId)) {
      body["memberId"] = request.memberId;
    }

    if (!Util.isUnset(request.memberType)) {
      body["memberType"] = request.memberType;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.roleList)) {
      body["roleList"] = request.roleList;
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
    return $tea.cast<AddAppRolesToMemberResponse>(await this.doROARequest("AddAppRolesToMember", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apps/${agentId}/members/roles`, "json", req, runtime), new AddAppRolesToMemberResponse({}));
  }

  async addAppToWorkBenchGroup(agentId: string, request: AddAppToWorkBenchGroupRequest): Promise<AddAppToWorkBenchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAppToWorkBenchGroupHeaders({ });
    return await this.addAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
  }

  async addAppToWorkBenchGroupWithOptions(agentId: string, request: AddAppToWorkBenchGroupRequest, headers: AddAppToWorkBenchGroupHeaders, runtime: $Util.RuntimeOptions): Promise<AddAppToWorkBenchGroupResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.componentId)) {
      body["componentId"] = request.componentId;
    }

    if (!Util.isUnset(request.ecologicalCorpId)) {
      body["ecologicalCorpId"] = request.ecologicalCorpId;
    }

    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
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
    return $tea.cast<AddAppToWorkBenchGroupResponse>(await this.doROARequest("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/addToWorkBenchGroup`, "json", req, runtime), new AddAppToWorkBenchGroupResponse({}));
  }

  async addMemberToAppRole(agentId: string, roleId: string, request: AddMemberToAppRoleRequest): Promise<AddMemberToAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddMemberToAppRoleHeaders({ });
    return await this.addMemberToAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async addMemberToAppRoleWithOptions(agentId: string, roleId: string, request: AddMemberToAppRoleRequest, headers: AddMemberToAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<AddMemberToAppRoleResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    roleId = OpenApiUtil.getEncodeParam(roleId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIdList)) {
      body["deptIdList"] = request.deptIdList;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.scopeVersion)) {
      body["scopeVersion"] = request.scopeVersion;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<AddMemberToAppRoleResponse>(await this.doROARequest("AddMemberToAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/members`, "json", req, runtime), new AddMemberToAppRoleResponse({}));
  }

  async createApaasApp(request: CreateApaasAppRequest): Promise<CreateApaasAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateApaasAppHeaders({ });
    return await this.createApaasAppWithOptions(request, headers, runtime);
  }

  async createApaasAppWithOptions(request: CreateApaasAppRequest, headers: CreateApaasAppHeaders, runtime: $Util.RuntimeOptions): Promise<CreateApaasAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appDesc)) {
      body["appDesc"] = request.appDesc;
    }

    if (!Util.isUnset(request.appIcon)) {
      body["appIcon"] = request.appIcon;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.bizAppId)) {
      body["bizAppId"] = request.bizAppId;
    }

    if (!Util.isUnset(request.homepageEditLink)) {
      body["homepageEditLink"] = request.homepageEditLink;
    }

    if (!Util.isUnset(request.homepageLink)) {
      body["homepageLink"] = request.homepageLink;
    }

    if (!Util.isUnset(request.isShortCut)) {
      body["isShortCut"] = request.isShortCut;
    }

    if (!Util.isUnset(request.ompLink)) {
      body["ompLink"] = request.ompLink;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.pcHomepageEditLink)) {
      body["pcHomepageEditLink"] = request.pcHomepageEditLink;
    }

    if (!Util.isUnset(request.pcHomepageLink)) {
      body["pcHomepageLink"] = request.pcHomepageLink;
    }

    if (!Util.isUnset(request.templateKey)) {
      body["templateKey"] = request.templateKey;
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
    return $tea.cast<CreateApaasAppResponse>(await this.doROARequest("CreateApaasApp", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apaasApps`, "json", req, runtime), new CreateApaasAppResponse({}));
  }

  async createInnerApp(request: CreateInnerAppRequest): Promise<CreateInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInnerAppHeaders({ });
    return await this.createInnerAppWithOptions(request, headers, runtime);
  }

  async createInnerAppWithOptions(request: CreateInnerAppRequest, headers: CreateInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInnerAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.homepageLink)) {
      body["homepageLink"] = request.homepageLink;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.ipWhiteList)) {
      body["ipWhiteList"] = request.ipWhiteList;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.ompLink)) {
      body["ompLink"] = request.ompLink;
    }

    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.pcHomepageLink)) {
      body["pcHomepageLink"] = request.pcHomepageLink;
    }

    if (!Util.isUnset(request.scopeType)) {
      body["scopeType"] = request.scopeType;
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
    return $tea.cast<CreateInnerAppResponse>(await this.doROARequest("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps`, "json", req, runtime), new CreateInnerAppResponse({}));
  }

  async deleteAppRole(agentId: string, roleId: string, request: DeleteAppRoleRequest): Promise<DeleteAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAppRoleHeaders({ });
    return await this.deleteAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async deleteAppRoleWithOptions(agentId: string, roleId: string, request: DeleteAppRoleRequest, headers: DeleteAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAppRoleResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    roleId = OpenApiUtil.getEncodeParam(roleId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<DeleteAppRoleResponse>(await this.doROARequest("DeleteAppRole", "microApp_1.0", "HTTP", "DELETE", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}`, "json", req, runtime), new DeleteAppRoleResponse({}));
  }

  async deleteInnerApp(agentId: string, request: DeleteInnerAppRequest): Promise<DeleteInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInnerAppHeaders({ });
    return await this.deleteInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async deleteInnerAppWithOptions(agentId: string, request: DeleteInnerAppRequest, headers: DeleteInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteInnerAppResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    let query : {[key: string ]: any} = { };
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
    return $tea.cast<DeleteInnerAppResponse>(await this.doROARequest("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new DeleteInnerAppResponse({}));
  }

  async getApaasApp(bizAppId: string): Promise<GetApaasAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetApaasAppHeaders({ });
    return await this.getApaasAppWithOptions(bizAppId, headers, runtime);
  }

  async getApaasAppWithOptions(bizAppId: string, headers: GetApaasAppHeaders, runtime: $Util.RuntimeOptions): Promise<GetApaasAppResponse> {
    bizAppId = OpenApiUtil.getEncodeParam(bizAppId);
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
    return $tea.cast<GetApaasAppResponse>(await this.doROARequest("GetApaasApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apaasApps/${bizAppId}`, "json", req, runtime), new GetApaasAppResponse({}));
  }

  async getAppRoleScopeByRoleId(agentId: string, roleId: string): Promise<GetAppRoleScopeByRoleIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAppRoleScopeByRoleIdHeaders({ });
    return await this.getAppRoleScopeByRoleIdWithOptions(agentId, roleId, headers, runtime);
  }

  async getAppRoleScopeByRoleIdWithOptions(agentId: string, roleId: string, headers: GetAppRoleScopeByRoleIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetAppRoleScopeByRoleIdResponse> {
    agentId = OpenApiUtil.getEncodeParam(agentId);
    roleId = OpenApiUtil.getEncodeParam(roleId);
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
    return $tea.cast<GetAppRoleScopeByRoleIdResponse>(await this.doROARequest("GetAppRoleScopeByRoleId", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/scopes`, "json", req, runtime), new GetAppRoleScopeByRoleIdResponse({}));
  }

  async getInnerApp(agentId: string, request: GetInnerAppRequest): Promise<GetInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInnerAppHeaders({ });
    return await this.getInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async getInnerAppWithOptions(agentId: string, request: GetInnerAppRequest, headers: GetInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<GetInnerAppResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ecologicalCorpId)) {
      query["ecologicalCorpId"] = request.ecologicalCorpId;
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
    return $tea.cast<GetInnerAppResponse>(await this.doROARequest("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new GetInnerAppResponse({}));
  }

  async getMicroAppScope(agentId: string): Promise<GetMicroAppScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMicroAppScopeHeaders({ });
    return await this.getMicroAppScopeWithOptions(agentId, headers, runtime);
  }

  async getMicroAppScopeWithOptions(agentId: string, headers: GetMicroAppScopeHeaders, runtime: $Util.RuntimeOptions): Promise<GetMicroAppScopeResponse> {
    agentId = OpenApiUtil.getEncodeParam(agentId);
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
    return $tea.cast<GetMicroAppScopeResponse>(await this.doROARequest("GetMicroAppScope", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/scopes`, "json", req, runtime), new GetMicroAppScopeResponse({}));
  }

  async getMicroAppUserAccess(agentId: string, userId: string): Promise<GetMicroAppUserAccessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMicroAppUserAccessHeaders({ });
    return await this.getMicroAppUserAccessWithOptions(agentId, userId, headers, runtime);
  }

  async getMicroAppUserAccessWithOptions(agentId: string, userId: string, headers: GetMicroAppUserAccessHeaders, runtime: $Util.RuntimeOptions): Promise<GetMicroAppUserAccessResponse> {
    agentId = OpenApiUtil.getEncodeParam(agentId);
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<GetMicroAppUserAccessResponse>(await this.doROARequest("GetMicroAppUserAccess", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/users/${userId}/adminAccess`, "json", req, runtime), new GetMicroAppUserAccessResponse({}));
  }

  async listAllApp(): Promise<ListAllAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAllAppHeaders({ });
    return await this.listAllAppWithOptions(headers, runtime);
  }

  async listAllAppWithOptions(headers: ListAllAppHeaders, runtime: $Util.RuntimeOptions): Promise<ListAllAppResponse> {
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
    return $tea.cast<ListAllAppResponse>(await this.doROARequest("ListAllApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/allApps`, "json", req, runtime), new ListAllAppResponse({}));
  }

  async listAppRoleScopes(agentId: string, request: ListAppRoleScopesRequest): Promise<ListAppRoleScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAppRoleScopesHeaders({ });
    return await this.listAppRoleScopesWithOptions(agentId, request, headers, runtime);
  }

  async listAppRoleScopesWithOptions(agentId: string, request: ListAppRoleScopesRequest, headers: ListAppRoleScopesHeaders, runtime: $Util.RuntimeOptions): Promise<ListAppRoleScopesResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListAppRoleScopesResponse>(await this.doROARequest("ListAppRoleScopes", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/roles`, "json", req, runtime), new ListAppRoleScopesResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListInnerAppResponse>(await this.doROARequest("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps`, "json", req, runtime), new ListInnerAppResponse({}));
  }

  async listRoleInfoByUser(agentId: string, userId: string): Promise<ListRoleInfoByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListRoleInfoByUserHeaders({ });
    return await this.listRoleInfoByUserWithOptions(agentId, userId, headers, runtime);
  }

  async listRoleInfoByUserWithOptions(agentId: string, userId: string, headers: ListRoleInfoByUserHeaders, runtime: $Util.RuntimeOptions): Promise<ListRoleInfoByUserResponse> {
    agentId = OpenApiUtil.getEncodeParam(agentId);
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<ListRoleInfoByUserResponse>(await this.doROARequest("ListRoleInfoByUser", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/apps/${agentId}/users/${userId}/roles`, "json", req, runtime), new ListRoleInfoByUserResponse({}));
  }

  async listUserVilebleApp(userId: string): Promise<ListUserVilebleAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserVilebleAppHeaders({ });
    return await this.listUserVilebleAppWithOptions(userId, headers, runtime);
  }

  async listUserVilebleAppWithOptions(userId: string, headers: ListUserVilebleAppHeaders, runtime: $Util.RuntimeOptions): Promise<ListUserVilebleAppResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<ListUserVilebleAppResponse>(await this.doROARequest("ListUserVilebleApp", "microApp_1.0", "HTTP", "GET", "AK", `/v1.0/microApp/users/${userId}/apps`, "json", req, runtime), new ListUserVilebleAppResponse({}));
  }

  async rebuildRoleScopeForAppRole(agentId: string, roleId: string, request: RebuildRoleScopeForAppRoleRequest): Promise<RebuildRoleScopeForAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RebuildRoleScopeForAppRoleHeaders({ });
    return await this.rebuildRoleScopeForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async rebuildRoleScopeForAppRoleWithOptions(agentId: string, roleId: string, request: RebuildRoleScopeForAppRoleRequest, headers: RebuildRoleScopeForAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<RebuildRoleScopeForAppRoleResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    roleId = OpenApiUtil.getEncodeParam(roleId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIdList)) {
      body["deptIdList"] = request.deptIdList;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.scopeType)) {
      body["scopeType"] = request.scopeType;
    }

    if (!Util.isUnset(request.scopeVersion)) {
      body["scopeVersion"] = request.scopeVersion;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<RebuildRoleScopeForAppRoleResponse>(await this.doROARequest("RebuildRoleScopeForAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/scopes/rebuild`, "json", req, runtime), new RebuildRoleScopeForAppRoleResponse({}));
  }

  async registerCustomAppRole(agentId: string, request: RegisterCustomAppRoleRequest): Promise<RegisterCustomAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterCustomAppRoleHeaders({ });
    return await this.registerCustomAppRoleWithOptions(agentId, request, headers, runtime);
  }

  async registerCustomAppRoleWithOptions(agentId: string, request: RegisterCustomAppRoleRequest, headers: RegisterCustomAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterCustomAppRoleResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.canManageRole)) {
      body["canManageRole"] = request.canManageRole;
    }

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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RegisterCustomAppRoleResponse>(await this.doROARequest("RegisterCustomAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles`, "json", req, runtime), new RegisterCustomAppRoleResponse({}));
  }

  async removeApaasApp(request: RemoveApaasAppRequest): Promise<RemoveApaasAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveApaasAppHeaders({ });
    return await this.removeApaasAppWithOptions(request, headers, runtime);
  }

  async removeApaasAppWithOptions(request: RemoveApaasAppRequest, headers: RemoveApaasAppHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveApaasAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizAppId)) {
      body["bizAppId"] = request.bizAppId;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
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
    return $tea.cast<RemoveApaasAppResponse>(await this.doROARequest("RemoveApaasApp", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apaasApps/remove`, "json", req, runtime), new RemoveApaasAppResponse({}));
  }

  async removeMemberForAppRole(agentId: string, roleId: string, request: RemoveMemberForAppRoleRequest): Promise<RemoveMemberForAppRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveMemberForAppRoleHeaders({ });
    return await this.removeMemberForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
  }

  async removeMemberForAppRoleWithOptions(agentId: string, roleId: string, request: RemoveMemberForAppRoleRequest, headers: RemoveMemberForAppRoleHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveMemberForAppRoleResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    roleId = OpenApiUtil.getEncodeParam(roleId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIdList)) {
      body["deptIdList"] = request.deptIdList;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.scopeVersion)) {
      body["scopeVersion"] = request.scopeVersion;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
    return $tea.cast<RemoveMemberForAppRoleResponse>(await this.doROARequest("RemoveMemberForAppRole", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}/members/batchRemove`, "json", req, runtime), new RemoveMemberForAppRoleResponse({}));
  }

  async setMicroAppScope(agentId: string, request: SetMicroAppScopeRequest): Promise<SetMicroAppScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetMicroAppScopeHeaders({ });
    return await this.setMicroAppScopeWithOptions(agentId, request, headers, runtime);
  }

  async setMicroAppScopeWithOptions(agentId: string, request: SetMicroAppScopeRequest, headers: SetMicroAppScopeHeaders, runtime: $Util.RuntimeOptions): Promise<SetMicroAppScopeResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.addDeptIds)) {
      body["addDeptIds"] = request.addDeptIds;
    }

    if (!Util.isUnset(request.addRoleIds)) {
      body["addRoleIds"] = request.addRoleIds;
    }

    if (!Util.isUnset(request.addUserIds)) {
      body["addUserIds"] = request.addUserIds;
    }

    if (!Util.isUnset(request.delDeptIds)) {
      body["delDeptIds"] = request.delDeptIds;
    }

    if (!Util.isUnset(request.delRoleIds)) {
      body["delRoleIds"] = request.delRoleIds;
    }

    if (!Util.isUnset(request.delUserIds)) {
      body["delUserIds"] = request.delUserIds;
    }

    if (!Util.isUnset(request.onlyAdminVisible)) {
      body["onlyAdminVisible"] = request.onlyAdminVisible;
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
    return $tea.cast<SetMicroAppScopeResponse>(await this.doROARequest("SetMicroAppScope", "microApp_1.0", "HTTP", "POST", "AK", `/v1.0/microApp/apps/${agentId}/scopes`, "json", req, runtime), new SetMicroAppScopeResponse({}));
  }

  async updateApaasApp(request: UpdateApaasAppRequest): Promise<UpdateApaasAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateApaasAppHeaders({ });
    return await this.updateApaasAppWithOptions(request, headers, runtime);
  }

  async updateApaasAppWithOptions(request: UpdateApaasAppRequest, headers: UpdateApaasAppHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateApaasAppResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appIcon)) {
      body["appIcon"] = request.appIcon;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.appStatus)) {
      body["appStatus"] = request.appStatus;
    }

    if (!Util.isUnset(request.bizAppId)) {
      body["bizAppId"] = request.bizAppId;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
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
    return $tea.cast<UpdateApaasAppResponse>(await this.doROARequest("UpdateApaasApp", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apaasApps`, "json", req, runtime), new UpdateApaasAppResponse({}));
  }

  async updateAppRoleInfo(agentId: string, roleId: string, request: UpdateAppRoleInfoRequest): Promise<UpdateAppRoleInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateAppRoleInfoHeaders({ });
    return await this.updateAppRoleInfoWithOptions(agentId, roleId, request, headers, runtime);
  }

  async updateAppRoleInfoWithOptions(agentId: string, roleId: string, request: UpdateAppRoleInfoRequest, headers: UpdateAppRoleInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateAppRoleInfoResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    roleId = OpenApiUtil.getEncodeParam(roleId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.canManageRole)) {
      body["canManageRole"] = request.canManageRole;
    }

    if (!Util.isUnset(request.newRoleName)) {
      body["newRoleName"] = request.newRoleName;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
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
    return $tea.cast<UpdateAppRoleInfoResponse>(await this.doROARequest("UpdateAppRoleInfo", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apps/${agentId}/roles/${roleId}`, "json", req, runtime), new UpdateAppRoleInfoResponse({}));
  }

  async updateInnerApp(agentId: string, request: UpdateInnerAppRequest): Promise<UpdateInnerAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInnerAppHeaders({ });
    return await this.updateInnerAppWithOptions(agentId, request, headers, runtime);
  }

  async updateInnerAppWithOptions(agentId: string, request: UpdateInnerAppRequest, headers: UpdateInnerAppHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInnerAppResponse> {
    Util.validateModel(request);
    agentId = OpenApiUtil.getEncodeParam(agentId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.desc)) {
      body["desc"] = request.desc;
    }

    if (!Util.isUnset(request.homepageLink)) {
      body["homepageLink"] = request.homepageLink;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.ipWhiteList)) {
      body["ipWhiteList"] = request.ipWhiteList;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.ompLink)) {
      body["ompLink"] = request.ompLink;
    }

    if (!Util.isUnset(request.opUnionId)) {
      body["opUnionId"] = request.opUnionId;
    }

    if (!Util.isUnset(request.pcHomepageLink)) {
      body["pcHomepageLink"] = request.pcHomepageLink;
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
    return $tea.cast<UpdateInnerAppResponse>(await this.doROARequest("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", `/v1.0/microApp/apps/${agentId}`, "json", req, runtime), new UpdateInnerAppResponse({}));
  }

}
