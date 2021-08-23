// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class ListSubCorpsHeaders extends $tea.Model {
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

export class ListSubCorpsRequest extends $tea.Model {
  types?: string;
  subCorpId?: string;
  isOnlyDirect?: boolean;
  static names(): { [key: string]: string } {
    return {
      types: 'types',
      subCorpId: 'subCorpId',
      isOnlyDirect: 'isOnlyDirect',
    };
  }

  static types(): { [key: string]: any } {
    return {
      types: 'string',
      subCorpId: 'string',
      isOnlyDirect: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubCorpsResponseBody extends $tea.Model {
  result?: ListSubCorpsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListSubCorpsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubCorpsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSubCorpsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSubCorpsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVillageOrgInfoHeaders extends $tea.Model {
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

export class GetVillageOrgInfoResponseBody extends $tea.Model {
  regionType?: string;
  regionId?: string;
  regionLocation?: string;
  static names(): { [key: string]: string } {
    return {
      regionType: 'regionType',
      regionId: 'regionId',
      regionLocation: 'regionLocation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      regionType: 'string',
      regionId: 'string',
      regionLocation: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVillageOrgInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetVillageOrgInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetVillageOrgInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersHeaders extends $tea.Model {
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

export class ListResidentDeptUsersRequest extends $tea.Model {
  subCorpId?: string;
  role?: string;
  cursor?: number;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      role: 'role',
      cursor: 'cursor',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      role: 'string',
      cursor: 'number',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponseBody extends $tea.Model {
  nextCursor?: number;
  hasMore?: boolean;
  list?: ListResidentDeptUsersResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      nextCursor: 'nextCursor',
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextCursor: 'number',
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListResidentDeptUsersResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListResidentDeptUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListResidentDeptUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptSimpleUsersHeaders extends $tea.Model {
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

export class ListDeptSimpleUsersRequest extends $tea.Model {
  cursor?: number;
  size?: number;
  containAccessLimit?: boolean;
  subCorpId?: string;
  language?: string;
  orderField?: string;
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
      size: 'size',
      containAccessLimit: 'containAccessLimit',
      subCorpId: 'subCorpId',
      language: 'language',
      orderField: 'orderField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'number',
      size: 'number',
      containAccessLimit: 'boolean',
      subCorpId: 'string',
      language: 'string',
      orderField: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptSimpleUsersResponseBody extends $tea.Model {
  list?: ListDeptSimpleUsersResponseBodyList[];
  totalCount?: number;
  nextCursor?: number;
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      totalCount: 'totalCount',
      nextCursor: 'nextCursor',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListDeptSimpleUsersResponseBodyList },
      totalCount: 'number',
      nextCursor: 'number',
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptSimpleUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListDeptSimpleUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListDeptSimpleUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserByUnionIdHeaders extends $tea.Model {
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

export class GetUserByUnionIdRequest extends $tea.Model {
  subCorpId?: string;
  unionId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      unionId: 'unionId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      unionId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserByUnionIdResponseBody extends $tea.Model {
  contactType?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      contactType: 'contactType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactType: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserByUnionIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserByUnionIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserByUnionIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentDeptHeaders extends $tea.Model {
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

export class GetResidentDeptRequest extends $tea.Model {
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentDeptResponseBody extends $tea.Model {
  deptId?: number;
  name?: string;
  deptType?: string;
  contactType?: string;
  feature?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      name: 'name',
      deptType: 'deptType',
      contactType: 'contactType',
      feature: 'feature',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      name: 'string',
      deptType: 'string',
      contactType: 'string',
      feature: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetResidentDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetResidentDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentUserInfoHeaders extends $tea.Model {
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

export class GetResidentUserInfoRequest extends $tea.Model {
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentUserInfoResponseBody extends $tea.Model {
  userid?: string;
  name?: string;
  roles?: GetResidentUserInfoResponseBodyRoles[];
  feature?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      userid: 'userid',
      name: 'name',
      roles: 'roles',
      feature: 'feature',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userid: 'string',
      name: 'string',
      roles: { 'type': 'array', 'itemType': GetResidentUserInfoResponseBodyRoles },
      feature: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetResidentUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetResidentUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptHeaders extends $tea.Model {
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

export class GetDeptRequest extends $tea.Model {
  subCorpId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptResponseBody extends $tea.Model {
  order?: number;
  deptId?: number;
  name?: string;
  parentId?: number;
  fromUnionOrg?: boolean;
  static names(): { [key: string]: string } {
    return {
      order: 'order',
      deptId: 'deptId',
      name: 'name',
      parentId: 'parentId',
      fromUnionOrg: 'fromUnionOrg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      order: 'number',
      deptId: 'number',
      name: 'string',
      parentId: 'number',
      fromUnionOrg: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByDeptHeaders extends $tea.Model {
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

export class ListParentByDeptRequest extends $tea.Model {
  subCorpId?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByDeptResponseBody extends $tea.Model {
  parentIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      parentIdList: 'parentIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListParentByDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListParentByDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUserIdsHeaders extends $tea.Model {
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

export class ListDeptUserIdsRequest extends $tea.Model {
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUserIdsResponseBody extends $tea.Model {
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUserIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListDeptUserIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListDeptUserIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSimpleUsersByRoleHeaders extends $tea.Model {
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

export class ListSimpleUsersByRoleRequest extends $tea.Model {
  offset?: number;
  size?: number;
  roleId?: number;
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      offset: 'offset',
      size: 'size',
      roleId: 'roleId',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      offset: 'number',
      size: 'number',
      roleId: 'number',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSimpleUsersByRoleResponseBody extends $tea.Model {
  list?: ListSimpleUsersByRoleResponseBodyList[];
  nextCursorString?: string;
  nextCursor?: number;
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursorString: 'nextCursorString',
      nextCursor: 'nextCursor',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListSimpleUsersByRoleResponseBodyList },
      nextCursorString: 'string',
      nextCursor: 'number',
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSimpleUsersByRoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSimpleUsersByRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSimpleUsersByRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentSubDeptsHeaders extends $tea.Model {
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

export class ListResidentSubDeptsRequest extends $tea.Model {
  subCorpId?: string;
  cursor?: number;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      cursor: 'cursor',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      cursor: 'number',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentSubDeptsResponseBody extends $tea.Model {
  list?: ListResidentSubDeptsResponseBodyList[];
  nextCursor?: number;
  hasMore?: boolean;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursor: 'nextCursor',
      hasMore: 'hasMore',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListResidentSubDeptsResponseBodyList },
      nextCursor: 'number',
      hasMore: 'boolean',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentSubDeptsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListResidentSubDeptsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListResidentSubDeptsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByUserHeaders extends $tea.Model {
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

export class ListParentByUserRequest extends $tea.Model {
  subCorpId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByUserResponseBody extends $tea.Model {
  parentDeptIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      parentDeptIdList: 'parentDeptIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      parentDeptIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListParentByUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListParentByUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptHeaders extends $tea.Model {
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

export class ListSubDeptRequest extends $tea.Model {
  subCorpId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptResponseBody extends $tea.Model {
  result?: ListSubDeptResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListSubDeptResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSubDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSubDeptResponseBody,
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

export class GetUserRequest extends $tea.Model {
  subCorpId?: string;
  language?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      language: 'language',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      language: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBody extends $tea.Model {
  userId?: string;
  unionId?: string;
  name?: string;
  avatar?: string;
  jobNumber?: string;
  title?: string;
  workPlace?: string;
  remark?: string;
  deptIdList?: number[];
  deptOrderSet?: GetUserResponseBodyDeptOrderSet[];
  extension?: string;
  hiredDate?: number;
  active?: boolean;
  realAuthed?: boolean;
  senior?: boolean;
  admin?: boolean;
  boss?: boolean;
  exclusiveAccount?: boolean;
  exclusiveAccountType?: string;
  leaderInDept?: GetUserResponseBodyLeaderInDept[];
  roleList?: GetUserResponseBodyRoleList[];
  unionEmpExt?: GetUserResponseBodyUnionEmpExt;
  managerUserId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      unionId: 'unionId',
      name: 'name',
      avatar: 'avatar',
      jobNumber: 'jobNumber',
      title: 'title',
      workPlace: 'workPlace',
      remark: 'remark',
      deptIdList: 'deptIdList',
      deptOrderSet: 'deptOrderSet',
      extension: 'extension',
      hiredDate: 'hiredDate',
      active: 'active',
      realAuthed: 'realAuthed',
      senior: 'senior',
      admin: 'admin',
      boss: 'boss',
      exclusiveAccount: 'exclusiveAccount',
      exclusiveAccountType: 'exclusiveAccountType',
      leaderInDept: 'leaderInDept',
      roleList: 'roleList',
      unionEmpExt: 'unionEmpExt',
      managerUserId: 'managerUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      unionId: 'string',
      name: 'string',
      avatar: 'string',
      jobNumber: 'string',
      title: 'string',
      workPlace: 'string',
      remark: 'string',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      deptOrderSet: { 'type': 'array', 'itemType': GetUserResponseBodyDeptOrderSet },
      extension: 'string',
      hiredDate: 'number',
      active: 'boolean',
      realAuthed: 'boolean',
      senior: 'boolean',
      admin: 'boolean',
      boss: 'boolean',
      exclusiveAccount: 'boolean',
      exclusiveAccountType: 'string',
      leaderInDept: { 'type': 'array', 'itemType': GetUserResponseBodyLeaderInDept },
      roleList: { 'type': 'array', 'itemType': GetUserResponseBodyRoleList },
      unionEmpExt: GetUserResponseBodyUnionEmpExt,
      managerUserId: 'string',
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

export class ListDeptUsersHeaders extends $tea.Model {
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

export class ListDeptUsersRequest extends $tea.Model {
  cursor?: number;
  size?: number;
  containAccessLimit?: boolean;
  subCorpId?: string;
  language?: string;
  orderField?: string;
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
      size: 'size',
      containAccessLimit: 'containAccessLimit',
      subCorpId: 'subCorpId',
      language: 'language',
      orderField: 'orderField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'number',
      size: 'number',
      containAccessLimit: 'boolean',
      subCorpId: 'string',
      language: 'string',
      orderField: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUsersResponseBody extends $tea.Model {
  list?: ListDeptUsersResponseBodyList[];
  nextCursor?: number;
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursor: 'nextCursor',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListDeptUsersResponseBodyList },
      nextCursor: 'number',
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListDeptUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListDeptUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosHeaders extends $tea.Model {
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

export class ListResidentUserInfosRequest extends $tea.Model {
  subCorpId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosShrinkRequest extends $tea.Model {
  subCorpId?: string;
  userIdsShrink?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
      userIdsShrink: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
      userIdsShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosResponseBody extends $tea.Model {
  result?: ListResidentUserInfosResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListResidentUserInfosResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListResidentUserInfosResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListResidentUserInfosResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptIdsHeaders extends $tea.Model {
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

export class ListSubDeptIdsRequest extends $tea.Model {
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptIdsResponseBody extends $tea.Model {
  deptIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      deptIdList: 'deptIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSubDeptIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSubDeptIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubCorpsResponseBodyResult extends $tea.Model {
  corpId?: string;
  name?: string;
  regionType?: string;
  regionId?: string;
  regionLocation?: string;
  industryCode?: number;
  industry?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      name: 'name',
      regionType: 'regionType',
      regionId: 'regionId',
      regionLocation: 'regionLocation',
      industryCode: 'industryCode',
      industry: 'industry',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      name: 'string',
      regionType: 'string',
      regionId: 'string',
      regionLocation: 'string',
      industryCode: 'number',
      industry: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponseBodyListRoles extends $tea.Model {
  id?: number;
  name?: string;
  tagCode?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      tagCode: 'tagCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      tagCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponseBodyList extends $tea.Model {
  userId?: string;
  name?: string;
  roles?: ListResidentDeptUsersResponseBodyListRoles[];
  feature?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
      roles: 'roles',
      feature: 'feature',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
      roles: { 'type': 'array', 'itemType': ListResidentDeptUsersResponseBodyListRoles },
      feature: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptSimpleUsersResponseBodyList extends $tea.Model {
  userId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentUserInfoResponseBodyRoles extends $tea.Model {
  id?: number;
  name?: string;
  tagCode?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      tagCode: 'tagCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      tagCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSimpleUsersByRoleResponseBodyList extends $tea.Model {
  userId?: string;
  unionId?: string;
  jobNumber?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      unionId: 'unionId',
      jobNumber: 'jobNumber',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      unionId: 'string',
      jobNumber: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentSubDeptsResponseBodyList extends $tea.Model {
  deptId?: number;
  name?: string;
  superId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      name: 'name',
      superId: 'superId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      name: 'string',
      superId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptResponseBodyResult extends $tea.Model {
  deptId?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyDeptOrderSet extends $tea.Model {
  deptId?: number;
  order?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      order: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyLeaderInDept extends $tea.Model {
  deptId?: number;
  leader?: boolean;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      leader: 'leader',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      leader: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyRoleList extends $tea.Model {
  id?: number;
  name?: string;
  groupName?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      groupName: 'groupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      groupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyUnionEmpExtUnionEmpMapList extends $tea.Model {
  corpId?: string;
  staffId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      staffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyUnionEmpExt extends $tea.Model {
  corpId?: string;
  staffId?: string;
  unionEmpMapList?: GetUserResponseBodyUnionEmpExtUnionEmpMapList[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      staffId: 'staffId',
      unionEmpMapList: 'unionEmpMapList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      staffId: 'string',
      unionEmpMapList: { 'type': 'array', 'itemType': GetUserResponseBodyUnionEmpExtUnionEmpMapList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUsersResponseBodyList extends $tea.Model {
  userId?: string;
  unionId?: string;
  jobNumber?: string;
  name?: string;
  deptIdList?: number[];
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      unionId: 'unionId',
      jobNumber: 'jobNumber',
      name: 'name',
      deptIdList: 'deptIdList',
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      unionId: 'string',
      jobNumber: 'string',
      name: 'string',
      deptIdList: { 'type': 'array', 'itemType': 'number' },
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosResponseBodyResultRoles extends $tea.Model {
  id?: number;
  name?: string;
  tagCode?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      tagCode: 'tagCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      tagCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosResponseBodyResult extends $tea.Model {
  userid?: string;
  name?: string;
  roles?: ListResidentUserInfosResponseBodyResultRoles[];
  feature?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      userid: 'userid',
      name: 'name',
      roles: 'roles',
      feature: 'feature',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userid: 'string',
      name: 'string',
      roles: { 'type': 'array', 'itemType': ListResidentUserInfosResponseBodyResultRoles },
      feature: 'string',
      unionId: 'string',
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


  async listSubCorps(request: ListSubCorpsRequest): Promise<ListSubCorpsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubCorpsHeaders({ });
    return await this.listSubCorpsWithOptions(request, headers, runtime);
  }

  async listSubCorpsWithOptions(request: ListSubCorpsRequest, headers: ListSubCorpsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubCorpsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.types)) {
      query["types"] = request.types;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.isOnlyDirect)) {
      query["isOnlyDirect"] = request.isOnlyDirect;
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
    return $tea.cast<ListSubCorpsResponse>(await this.doROARequest("ListSubCorps", "village_1.0", "HTTP", "POST", "AK", `/v1.0/village/corps/subCorps`, "json", req, runtime), new ListSubCorpsResponse({}));
  }

  async getVillageOrgInfo(subCorpId: string): Promise<GetVillageOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetVillageOrgInfoHeaders({ });
    return await this.getVillageOrgInfoWithOptions(subCorpId, headers, runtime);
  }

  async getVillageOrgInfoWithOptions(subCorpId: string, headers: GetVillageOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetVillageOrgInfoResponse> {
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
    return $tea.cast<GetVillageOrgInfoResponse>(await this.doROARequest("GetVillageOrgInfo", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/corps/${subCorpId}`, "json", req, runtime), new GetVillageOrgInfoResponse({}));
  }

  async listResidentDeptUsers(deptId: string, request: ListResidentDeptUsersRequest): Promise<ListResidentDeptUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListResidentDeptUsersHeaders({ });
    return await this.listResidentDeptUsersWithOptions(deptId, request, headers, runtime);
  }

  async listResidentDeptUsersWithOptions(deptId: string, request: ListResidentDeptUsersRequest, headers: ListResidentDeptUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListResidentDeptUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.role)) {
      query["role"] = request.role;
    }

    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
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
    return $tea.cast<ListResidentDeptUsersResponse>(await this.doROARequest("ListResidentDeptUsers", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/residentDepartments/${deptId}/users`, "json", req, runtime), new ListResidentDeptUsersResponse({}));
  }

  async listDeptSimpleUsers(deptId: string, request: ListDeptSimpleUsersRequest): Promise<ListDeptSimpleUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDeptSimpleUsersHeaders({ });
    return await this.listDeptSimpleUsersWithOptions(deptId, request, headers, runtime);
  }

  async listDeptSimpleUsersWithOptions(deptId: string, request: ListDeptSimpleUsersRequest, headers: ListDeptSimpleUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListDeptSimpleUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.containAccessLimit)) {
      query["containAccessLimit"] = request.containAccessLimit;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.orderField)) {
      query["orderField"] = request.orderField;
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
    return $tea.cast<ListDeptSimpleUsersResponse>(await this.doROARequest("ListDeptSimpleUsers", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/departments/${deptId}/simpleUsers`, "json", req, runtime), new ListDeptSimpleUsersResponse({}));
  }

  async getUserByUnionId(request: GetUserByUnionIdRequest): Promise<GetUserByUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserByUnionIdHeaders({ });
    return await this.getUserByUnionIdWithOptions(request, headers, runtime);
  }

  async getUserByUnionIdWithOptions(request: GetUserByUnionIdRequest, headers: GetUserByUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserByUnionIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetUserByUnionIdResponse>(await this.doROARequest("GetUserByUnionId", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/users/getByUnionId`, "json", req, runtime), new GetUserByUnionIdResponse({}));
  }

  async getResidentDept(departmentId: string, request: GetResidentDeptRequest): Promise<GetResidentDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentDeptHeaders({ });
    return await this.getResidentDeptWithOptions(departmentId, request, headers, runtime);
  }

  async getResidentDeptWithOptions(departmentId: string, request: GetResidentDeptRequest, headers: GetResidentDeptHeaders, runtime: $Util.RuntimeOptions): Promise<GetResidentDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
    return $tea.cast<GetResidentDeptResponse>(await this.doROARequest("GetResidentDept", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/residentDepartments/departments/${departmentId}`, "json", req, runtime), new GetResidentDeptResponse({}));
  }

  async getResidentUserInfo(deptId: string, userId: string, request: GetResidentUserInfoRequest): Promise<GetResidentUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentUserInfoHeaders({ });
    return await this.getResidentUserInfoWithOptions(deptId, userId, request, headers, runtime);
  }

  async getResidentUserInfoWithOptions(deptId: string, userId: string, request: GetResidentUserInfoRequest, headers: GetResidentUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetResidentUserInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
    return $tea.cast<GetResidentUserInfoResponse>(await this.doROARequest("GetResidentUserInfo", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/residentDepartments/${deptId}/users/${userId}`, "json", req, runtime), new GetResidentUserInfoResponse({}));
  }

  async getDept(departmentId: string, request: GetDeptRequest): Promise<GetDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDeptHeaders({ });
    return await this.getDeptWithOptions(departmentId, request, headers, runtime);
  }

  async getDeptWithOptions(departmentId: string, request: GetDeptRequest, headers: GetDeptHeaders, runtime: $Util.RuntimeOptions): Promise<GetDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetDeptResponse>(await this.doROARequest("GetDept", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/deptartments/${departmentId}`, "json", req, runtime), new GetDeptResponse({}));
  }

  async listParentByDept(request: ListParentByDeptRequest): Promise<ListParentByDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListParentByDeptHeaders({ });
    return await this.listParentByDeptWithOptions(request, headers, runtime);
  }

  async listParentByDeptWithOptions(request: ListParentByDeptRequest, headers: ListParentByDeptHeaders, runtime: $Util.RuntimeOptions): Promise<ListParentByDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
    return $tea.cast<ListParentByDeptResponse>(await this.doROARequest("ListParentByDept", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/departments/listParentByDepartment`, "json", req, runtime), new ListParentByDeptResponse({}));
  }

  async listDeptUserIds(deptId: string, request: ListDeptUserIdsRequest): Promise<ListDeptUserIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDeptUserIdsHeaders({ });
    return await this.listDeptUserIdsWithOptions(deptId, request, headers, runtime);
  }

  async listDeptUserIdsWithOptions(deptId: string, request: ListDeptUserIdsRequest, headers: ListDeptUserIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListDeptUserIdsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
    return $tea.cast<ListDeptUserIdsResponse>(await this.doROARequest("ListDeptUserIds", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/departments/${deptId}/userIds`, "json", req, runtime), new ListDeptUserIdsResponse({}));
  }

  async listSimpleUsersByRole(request: ListSimpleUsersByRoleRequest): Promise<ListSimpleUsersByRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSimpleUsersByRoleHeaders({ });
    return await this.listSimpleUsersByRoleWithOptions(request, headers, runtime);
  }

  async listSimpleUsersByRoleWithOptions(request: ListSimpleUsersByRoleRequest, headers: ListSimpleUsersByRoleHeaders, runtime: $Util.RuntimeOptions): Promise<ListSimpleUsersByRoleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.offset)) {
      query["offset"] = request.offset;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.roleId)) {
      query["roleId"] = request.roleId;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
    return $tea.cast<ListSimpleUsersByRoleResponse>(await this.doROARequest("ListSimpleUsersByRole", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/users/listByRole`, "json", req, runtime), new ListSimpleUsersByRoleResponse({}));
  }

  async listResidentSubDepts(deptId: string, request: ListResidentSubDeptsRequest): Promise<ListResidentSubDeptsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListResidentSubDeptsHeaders({ });
    return await this.listResidentSubDeptsWithOptions(deptId, request, headers, runtime);
  }

  async listResidentSubDeptsWithOptions(deptId: string, request: ListResidentSubDeptsRequest, headers: ListResidentSubDeptsHeaders, runtime: $Util.RuntimeOptions): Promise<ListResidentSubDeptsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
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
    return $tea.cast<ListResidentSubDeptsResponse>(await this.doROARequest("ListResidentSubDepts", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/residentDepartments/${deptId}/subDepartments`, "json", req, runtime), new ListResidentSubDeptsResponse({}));
  }

  async listParentByUser(request: ListParentByUserRequest): Promise<ListParentByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListParentByUserHeaders({ });
    return await this.listParentByUserWithOptions(request, headers, runtime);
  }

  async listParentByUserWithOptions(request: ListParentByUserRequest, headers: ListParentByUserHeaders, runtime: $Util.RuntimeOptions): Promise<ListParentByUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<ListParentByUserResponse>(await this.doROARequest("ListParentByUser", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/departments/listParentByUser`, "json", req, runtime), new ListParentByUserResponse({}));
  }

  async listSubDept(deptId: string, request: ListSubDeptRequest): Promise<ListSubDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubDeptHeaders({ });
    return await this.listSubDeptWithOptions(deptId, request, headers, runtime);
  }

  async listSubDeptWithOptions(deptId: string, request: ListSubDeptRequest, headers: ListSubDeptHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<ListSubDeptResponse>(await this.doROARequest("ListSubDept", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/departments/${deptId}/subDepartments`, "json", req, runtime), new ListSubDeptResponse({}));
  }

  async getUser(userId: string, request: GetUserRequest): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(userId, request, headers, runtime);
  }

  async getUserWithOptions(userId: string, request: GetUserRequest, headers: GetUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
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
    return $tea.cast<GetUserResponse>(await this.doROARequest("GetUser", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/users/getByUserId`, "json", req, runtime), new GetUserResponse({}));
  }

  async listDeptUsers(deptId: string, request: ListDeptUsersRequest): Promise<ListDeptUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDeptUsersHeaders({ });
    return await this.listDeptUsersWithOptions(deptId, request, headers, runtime);
  }

  async listDeptUsersWithOptions(deptId: string, request: ListDeptUsersRequest, headers: ListDeptUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListDeptUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.containAccessLimit)) {
      query["containAccessLimit"] = request.containAccessLimit;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.orderField)) {
      query["orderField"] = request.orderField;
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
    return $tea.cast<ListDeptUsersResponse>(await this.doROARequest("ListDeptUsers", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/departments/${deptId}/users`, "json", req, runtime), new ListDeptUsersResponse({}));
  }

  async listResidentUserInfos(request: ListResidentUserInfosRequest): Promise<ListResidentUserInfosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListResidentUserInfosHeaders({ });
    return await this.listResidentUserInfosWithOptions(request, headers, runtime);
  }

  async listResidentUserInfosWithOptions(tmpReq: ListResidentUserInfosRequest, headers: ListResidentUserInfosHeaders, runtime: $Util.RuntimeOptions): Promise<ListResidentUserInfosResponse> {
    Util.validateModel(tmpReq);
    let request = new ListResidentUserInfosShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.userIds)) {
      request.userIdsShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.userIds, "userIds", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.userIdsShrink)) {
      query["userIds"] = request.userIdsShrink;
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
    return $tea.cast<ListResidentUserInfosResponse>(await this.doROARequest("ListResidentUserInfos", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/residentUsers/getByUserIds`, "json", req, runtime), new ListResidentUserInfosResponse({}));
  }

  async listSubDeptIds(deptId: string, request: ListSubDeptIdsRequest): Promise<ListSubDeptIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubDeptIdsHeaders({ });
    return await this.listSubDeptIdsWithOptions(deptId, request, headers, runtime);
  }

  async listSubDeptIdsWithOptions(deptId: string, request: ListSubDeptIdsRequest, headers: ListSubDeptIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubDeptIdsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
    return $tea.cast<ListSubDeptIdsResponse>(await this.doROARequest("ListSubDeptIds", "village_1.0", "HTTP", "GET", "AK", `/v1.0/village/departments/${deptId}/subDepartmentIds`, "json", req, runtime), new ListSubDeptIdsResponse({}));
  }

}
