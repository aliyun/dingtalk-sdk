// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      language: 'language',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      language: 'string',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  departmentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fromUnionOrg?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  order?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  parentDepartmentId?: number;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      fromUnionOrg: 'fromUnionOrg',
      order: 'order',
      parentDepartmentId: 'parentDepartmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      departmentName: 'string',
      fromUnionOrg: 'boolean',
      order: 'number',
      parentDepartmentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDeptResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDeptResponseBody;
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
      body: GetDeptResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  contactType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  departmentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  deptType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  feature?: string;
  static names(): { [key: string]: string } {
    return {
      contactType: 'contactType',
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      deptType: 'deptType',
      feature: 'feature',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactType: 'string',
      departmentId: 'number',
      departmentName: 'string',
      deptType: 'string',
      feature: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentDeptResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetResidentDeptResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  feature?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  roles?: GetResidentUserInfoResponseBodyRoles[];
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      feature: 'feature',
      name: 'name',
      roles: 'roles',
      unionId: 'unionId',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feature: 'string',
      name: 'string',
      roles: { 'type': 'array', 'itemType': GetResidentUserInfoResponseBodyRoles },
      unionId: 'string',
      userid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentUserInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetResidentUserInfoResponseBody;
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
      body: GetResidentUserInfoResponseBody,
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
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      language: 'language',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      language: 'string',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBody extends $tea.Model {
  active?: boolean;
  admin?: boolean;
  boss?: boolean;
  departmentIdList?: number[];
  departmentOrderSet?: GetUserResponseBodyDepartmentOrderSet[];
  exclusiveAccount?: boolean;
  exclusiveAccountType?: string;
  extension?: string;
  hiredDate?: number;
  jobNumber?: string;
  leaderInDepartment?: GetUserResponseBodyLeaderInDepartment[];
  managerUserId?: string;
  name?: string;
  realAuthed?: boolean;
  remark?: string;
  roleList?: GetUserResponseBodyRoleList[];
  senior?: boolean;
  title?: string;
  unionEmpExt?: GetUserResponseBodyUnionEmpExt;
  unionId?: string;
  userId?: string;
  workPlace?: string;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      admin: 'admin',
      boss: 'boss',
      departmentIdList: 'departmentIdList',
      departmentOrderSet: 'departmentOrderSet',
      exclusiveAccount: 'exclusiveAccount',
      exclusiveAccountType: 'exclusiveAccountType',
      extension: 'extension',
      hiredDate: 'hiredDate',
      jobNumber: 'jobNumber',
      leaderInDepartment: 'leaderInDepartment',
      managerUserId: 'managerUserId',
      name: 'name',
      realAuthed: 'realAuthed',
      remark: 'remark',
      roleList: 'roleList',
      senior: 'senior',
      title: 'title',
      unionEmpExt: 'unionEmpExt',
      unionId: 'unionId',
      userId: 'userId',
      workPlace: 'workPlace',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      admin: 'boolean',
      boss: 'boolean',
      departmentIdList: { 'type': 'array', 'itemType': 'number' },
      departmentOrderSet: { 'type': 'array', 'itemType': GetUserResponseBodyDepartmentOrderSet },
      exclusiveAccount: 'boolean',
      exclusiveAccountType: 'string',
      extension: 'string',
      hiredDate: 'number',
      jobNumber: 'string',
      leaderInDepartment: { 'type': 'array', 'itemType': GetUserResponseBodyLeaderInDepartment },
      managerUserId: 'string',
      name: 'string',
      realAuthed: 'boolean',
      remark: 'string',
      roleList: { 'type': 'array', 'itemType': GetUserResponseBodyRoleList },
      senior: 'boolean',
      title: 'string',
      unionEmpExt: GetUserResponseBodyUnionEmpExt,
      unionId: 'string',
      userId: 'string',
      workPlace: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserResponseBody;
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
      body: GetUserResponseBody,
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
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      language: 'language',
      subCorpId: 'subCorpId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      language: 'string',
      subCorpId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserByUnionIdResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  contactType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserByUnionIdResponseBody;
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
      body: GetUserByUnionIdResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  regionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  regionLocation?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 省份：PROVINCE;城市：CITY;县区：COUNTRY;乡镇：TOWN;村：VILLAGE
   */
  regionType?: string;
  static names(): { [key: string]: string } {
    return {
      regionId: 'regionId',
      regionLocation: 'regionLocation',
      regionType: 'regionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      regionId: 'string',
      regionLocation: 'string',
      regionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetVillageOrgInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetVillageOrgInfoResponseBody;
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
      body: GetVillageOrgInfoResponseBody,
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
  containAccessLimit?: boolean;
  cursor?: number;
  language?: string;
  orderField?: string;
  size?: number;
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      containAccessLimit: 'containAccessLimit',
      cursor: 'cursor',
      language: 'language',
      orderField: 'orderField',
      size: 'size',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      containAccessLimit: 'boolean',
      cursor: 'number',
      language: 'string',
      orderField: 'string',
      size: 'number',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptSimpleUsersResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  nextCursor?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  totalCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userList?: ListDeptSimpleUsersResponseBodyUserList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextCursor: 'number',
      totalCount: 'number',
      userList: { 'type': 'array', 'itemType': ListDeptSimpleUsersResponseBodyUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptSimpleUsersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListDeptSimpleUsersResponseBody;
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
      body: ListDeptSimpleUsersResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListDeptUserIdsResponseBody;
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
      body: ListDeptUserIdsResponseBody,
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
  containAccessLimit?: boolean;
  cursor?: number;
  language?: string;
  orderField?: string;
  size?: number;
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      containAccessLimit: 'containAccessLimit',
      cursor: 'cursor',
      language: 'language',
      orderField: 'orderField',
      size: 'size',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      containAccessLimit: 'boolean',
      cursor: 'number',
      language: 'string',
      orderField: 'string',
      size: 'number',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUsersResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  nextCursor?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userList?: ListDeptUsersResponseBodyUserList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextCursor: 'nextCursor',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextCursor: 'number',
      userList: { 'type': 'array', 'itemType': ListDeptUsersResponseBodyUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUsersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListDeptUsersResponseBody;
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
      body: ListDeptUsersResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByDeptResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  departmentIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      departmentIdList: 'departmentIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByDeptResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListParentByDeptResponseBody;
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
      body: ListParentByDeptResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  departmentIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      departmentIdList: 'departmentIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListParentByUserResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListParentByUserResponseBody;
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
      body: ListParentByUserResponseBody,
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
  /**
   * @example
   * 1
   */
  cursor?: number;
  role?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  size?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
      role: 'role',
      size: 'size',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'number',
      role: 'string',
      size: 'number',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  nextCursor?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userList?: ListResidentDeptUsersResponseBodyUserList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextCursor: 'nextCursor',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextCursor: 'number',
      userList: { 'type': 'array', 'itemType': ListResidentDeptUsersResponseBodyUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListResidentDeptUsersResponseBody;
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
      body: ListResidentDeptUsersResponseBody,
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
  /**
   * @example
   * 1
   */
  cursor?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  size?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
      size: 'size',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'number',
      size: 'number',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentSubDeptsResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  departmentList?: ListResidentSubDeptsResponseBodyDepartmentList[];
  /**
   * @remarks
   * This parameter is required.
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  nextCursor?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  total?: number;
  static names(): { [key: string]: string } {
    return {
      departmentList: 'departmentList',
      hasMore: 'hasMore',
      nextCursor: 'nextCursor',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentList: { 'type': 'array', 'itemType': ListResidentSubDeptsResponseBodyDepartmentList },
      hasMore: 'boolean',
      nextCursor: 'number',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentSubDeptsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListResidentSubDeptsResponseBody;
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
      body: ListResidentSubDeptsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  userList?: ListResidentUserInfosResponseBodyUserList[];
  static names(): { [key: string]: string } {
    return {
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userList: { 'type': 'array', 'itemType': ListResidentUserInfosResponseBodyUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListResidentUserInfosResponseBody;
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
      body: ListResidentUserInfosResponseBody,
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
  roleId?: number;
  size?: number;
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      offset: 'offset',
      roleId: 'roleId',
      size: 'size',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      offset: 'number',
      roleId: 'number',
      size: 'number',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSimpleUsersByRoleResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  nextCursor?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userList?: ListSimpleUsersByRoleResponseBodyUserList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextCursor: 'nextCursor',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextCursor: 'number',
      userList: { 'type': 'array', 'itemType': ListSimpleUsersByRoleResponseBodyUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSimpleUsersByRoleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSimpleUsersByRoleResponseBody;
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
      body: ListSimpleUsersByRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  /**
   * @remarks
   * This parameter is required.
   */
  isOnlyDirect?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  /**
   * @example
   * county|community
   */
  types?: string;
  static names(): { [key: string]: string } {
    return {
      isOnlyDirect: 'isOnlyDirect',
      subCorpId: 'subCorpId',
      types: 'types',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isOnlyDirect: 'boolean',
      subCorpId: 'string',
      types: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubCorpsResponseBody extends $tea.Model {
  corpList?: ListSubCorpsResponseBodyCorpList[];
  static names(): { [key: string]: string } {
    return {
      corpList: 'corpList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpList: { 'type': 'array', 'itemType': ListSubCorpsResponseBodyCorpList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubCorpsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSubCorpsResponseBody;
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
      body: ListSubCorpsResponseBody,
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
  /**
   * @example
   * zh_CN
   */
  language?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  subCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      language: 'language',
      subCorpId: 'subCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      language: 'string',
      subCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSubDeptResponseBody;
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
      body: ListSubDeptResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  departmentIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      departmentIdList: 'departmentIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptIdsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSubDeptIdsResponseBody;
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
      body: ListSubDeptIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentUserInfoResponseBodyRoles extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  roleId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  roleName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tagCode?: string;
  static names(): { [key: string]: string } {
    return {
      roleId: 'roleId',
      roleName: 'roleName',
      tagCode: 'tagCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleId: 'number',
      roleName: 'string',
      tagCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyDepartmentOrderSet extends $tea.Model {
  departmentId?: number;
  order?: number;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      order: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyLeaderInDepartment extends $tea.Model {
  departmentId?: number;
  leader?: boolean;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      leader: 'leader',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      leader: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserResponseBodyRoleList extends $tea.Model {
  groupName?: string;
  roleId?: number;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      roleId: 'roleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      roleId: 'number',
      roleName: 'string',
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

export class ListDeptSimpleUsersResponseBodyUserList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDeptUsersResponseBodyUserList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  active?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  departmentList?: number[];
  /**
   * @remarks
   * This parameter is required.
   */
  jobNumber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      departmentList: 'departmentList',
      jobNumber: 'jobNumber',
      name: 'name',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      departmentList: { 'type': 'array', 'itemType': 'number' },
      jobNumber: 'string',
      name: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponseBodyUserListRoles extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  tagCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tagId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  tagName?: string;
  static names(): { [key: string]: string } {
    return {
      tagCode: 'tagCode',
      tagId: 'tagId',
      tagName: 'tagName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagCode: 'string',
      tagId: 'number',
      tagName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentDeptUsersResponseBodyUserList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  feature?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  roles?: ListResidentDeptUsersResponseBodyUserListRoles[];
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      feature: 'feature',
      name: 'name',
      roles: 'roles',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feature: 'string',
      name: 'string',
      roles: { 'type': 'array', 'itemType': ListResidentDeptUsersResponseBodyUserListRoles },
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentSubDeptsResponseBodyDepartmentList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  departmentName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  superDepartmentId?: number;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      superDepartmentId: 'superDepartmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      departmentName: 'string',
      superDepartmentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosResponseBodyUserListRoles extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  tagCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  tagId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  tagName?: string;
  static names(): { [key: string]: string } {
    return {
      tagCode: 'tagCode',
      tagId: 'tagId',
      tagName: 'tagName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagCode: 'string',
      tagId: 'number',
      tagName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListResidentUserInfosResponseBodyUserList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  feature?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  roles?: ListResidentUserInfosResponseBodyUserListRoles[];
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      feature: 'feature',
      roles: 'roles',
      unionId: 'unionId',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      feature: 'string',
      roles: { 'type': 'array', 'itemType': ListResidentUserInfosResponseBodyUserListRoles },
      unionId: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSimpleUsersByRoleResponseBodyUserList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  jobNumber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      jobNumber: 'jobNumber',
      name: 'name',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobNumber: 'string',
      name: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubCorpsResponseBodyCorpList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  corpName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  industry?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 149 区县，148 乡镇街道，145 村， 150 社区， 151 小区
   */
  industryCode?: number;
  regionId?: string;
  /**
   * @example
   * 浙江省_杭州市_余杭区_仓前街道
   */
  regionLocation?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  regionType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      corpName: 'corpName',
      industry: 'industry',
      industryCode: 'industryCode',
      regionId: 'regionId',
      regionLocation: 'regionLocation',
      regionType: 'regionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      corpName: 'string',
      industry: 'string',
      industryCode: 'number',
      regionId: 'string',
      regionLocation: 'string',
      regionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubDeptResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
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
   * 获取部门详情
   * 
   * @param request - GetDeptRequest
   * @param headers - GetDeptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDeptResponse
   */
  async getDeptWithOptions(departmentId: string, request: GetDeptRequest, headers: GetDeptHeaders, runtime: $Util.RuntimeOptions): Promise<GetDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "GetDept",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/deptartments/${departmentId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetDeptResponse>(await this.execute(params, req, runtime), new GetDeptResponse({}));
  }

  /**
   * 获取部门详情
   * 
   * @param request - GetDeptRequest
   * @returns GetDeptResponse
   */
  async getDept(departmentId: string, request: GetDeptRequest): Promise<GetDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDeptHeaders({ });
    return await this.getDeptWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 居民通讯录获取部门信息
   * 
   * @param request - GetResidentDeptRequest
   * @param headers - GetResidentDeptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetResidentDeptResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetResidentDept",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/residentDepartments/departments/${departmentId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetResidentDeptResponse>(await this.execute(params, req, runtime), new GetResidentDeptResponse({}));
  }

  /**
   * 居民通讯录获取部门信息
   * 
   * @param request - GetResidentDeptRequest
   * @returns GetResidentDeptResponse
   */
  async getResidentDept(departmentId: string, request: GetResidentDeptRequest): Promise<GetResidentDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentDeptHeaders({ });
    return await this.getResidentDeptWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 居民通讯录获取部门下某个人的详细信息
   * 
   * @param request - GetResidentUserInfoRequest
   * @param headers - GetResidentUserInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetResidentUserInfoResponse
   */
  async getResidentUserInfoWithOptions(departmentId: string, userId: string, request: GetResidentUserInfoRequest, headers: GetResidentUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetResidentUserInfoResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetResidentUserInfo",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/residentDepartments/${departmentId}/users/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetResidentUserInfoResponse>(await this.execute(params, req, runtime), new GetResidentUserInfoResponse({}));
  }

  /**
   * 居民通讯录获取部门下某个人的详细信息
   * 
   * @param request - GetResidentUserInfoRequest
   * @returns GetResidentUserInfoResponse
   */
  async getResidentUserInfo(departmentId: string, userId: string, request: GetResidentUserInfoRequest): Promise<GetResidentUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentUserInfoHeaders({ });
    return await this.getResidentUserInfoWithOptions(departmentId, userId, request, headers, runtime);
  }

  /**
   * 查询用户详情
   * 
   * @param request - GetUserRequest
   * @param headers - GetUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserResponse
   */
  async getUserWithOptions(userId: string, request: GetUserRequest, headers: GetUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "GetUser",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/users/getByUserId`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserResponse>(await this.execute(params, req, runtime), new GetUserResponse({}));
  }

  /**
   * 查询用户详情
   * 
   * @param request - GetUserRequest
   * @returns GetUserResponse
   */
  async getUser(userId: string, request: GetUserRequest): Promise<GetUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHeaders({ });
    return await this.getUserWithOptions(userId, request, headers, runtime);
  }

  /**
   * 根据unionId查询用户详情
   * 
   * @param request - GetUserByUnionIdRequest
   * @param headers - GetUserByUnionIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserByUnionIdResponse
   */
  async getUserByUnionIdWithOptions(request: GetUserByUnionIdRequest, headers: GetUserByUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserByUnionIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetUserByUnionId",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/users/getByUnionId`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserByUnionIdResponse>(await this.execute(params, req, runtime), new GetUserByUnionIdResponse({}));
  }

  /**
   * 根据unionId查询用户详情
   * 
   * @param request - GetUserByUnionIdRequest
   * @returns GetUserByUnionIdResponse
   */
  async getUserByUnionId(request: GetUserByUnionIdRequest): Promise<GetUserByUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserByUnionIdHeaders({ });
    return await this.getUserByUnionIdWithOptions(request, headers, runtime);
  }

  /**
   * 获取对外开放的企业信息
   * 
   * @param headers - GetVillageOrgInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetVillageOrgInfoResponse
   */
  async getVillageOrgInfoWithOptions(subCorpId: string, headers: GetVillageOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetVillageOrgInfoResponse> {
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
      action: "GetVillageOrgInfo",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/corps/${subCorpId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetVillageOrgInfoResponse>(await this.execute(params, req, runtime), new GetVillageOrgInfoResponse({}));
  }

  /**
   * 获取对外开放的企业信息
   * @returns GetVillageOrgInfoResponse
   */
  async getVillageOrgInfo(subCorpId: string): Promise<GetVillageOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetVillageOrgInfoHeaders({ });
    return await this.getVillageOrgInfoWithOptions(subCorpId, headers, runtime);
  }

  /**
   * 查询部门下简略用户列表
   * 
   * @param request - ListDeptSimpleUsersRequest
   * @param headers - ListDeptSimpleUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListDeptSimpleUsersResponse
   */
  async listDeptSimpleUsersWithOptions(departmentId: string, request: ListDeptSimpleUsersRequest, headers: ListDeptSimpleUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListDeptSimpleUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.containAccessLimit)) {
      query["containAccessLimit"] = request.containAccessLimit;
    }

    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.orderField)) {
      query["orderField"] = request.orderField;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "ListDeptSimpleUsers",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/departments/${departmentId}/simpleUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListDeptSimpleUsersResponse>(await this.execute(params, req, runtime), new ListDeptSimpleUsersResponse({}));
  }

  /**
   * 查询部门下简略用户列表
   * 
   * @param request - ListDeptSimpleUsersRequest
   * @returns ListDeptSimpleUsersResponse
   */
  async listDeptSimpleUsers(departmentId: string, request: ListDeptSimpleUsersRequest): Promise<ListDeptSimpleUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDeptSimpleUsersHeaders({ });
    return await this.listDeptSimpleUsersWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 查询部门下userid列表
   * 
   * @param request - ListDeptUserIdsRequest
   * @param headers - ListDeptUserIdsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListDeptUserIdsResponse
   */
  async listDeptUserIdsWithOptions(departmentId: string, request: ListDeptUserIdsRequest, headers: ListDeptUserIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListDeptUserIdsResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListDeptUserIds",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/departments/${departmentId}/userIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListDeptUserIdsResponse>(await this.execute(params, req, runtime), new ListDeptUserIdsResponse({}));
  }

  /**
   * 查询部门下userid列表
   * 
   * @param request - ListDeptUserIdsRequest
   * @returns ListDeptUserIdsResponse
   */
  async listDeptUserIds(departmentId: string, request: ListDeptUserIdsRequest): Promise<ListDeptUserIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDeptUserIdsHeaders({ });
    return await this.listDeptUserIdsWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 查询部门下user完整信息
   * 
   * @param request - ListDeptUsersRequest
   * @param headers - ListDeptUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListDeptUsersResponse
   */
  async listDeptUsersWithOptions(departmentId: string, request: ListDeptUsersRequest, headers: ListDeptUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListDeptUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.containAccessLimit)) {
      query["containAccessLimit"] = request.containAccessLimit;
    }

    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.orderField)) {
      query["orderField"] = request.orderField;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "ListDeptUsers",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/departments/${departmentId}/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListDeptUsersResponse>(await this.execute(params, req, runtime), new ListDeptUsersResponse({}));
  }

  /**
   * 查询部门下user完整信息
   * 
   * @param request - ListDeptUsersRequest
   * @returns ListDeptUsersResponse
   */
  async listDeptUsers(departmentId: string, request: ListDeptUsersRequest): Promise<ListDeptUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDeptUsersHeaders({ });
    return await this.listDeptUsersWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 查询部门所有父部门列表
   * 
   * @param request - ListParentByDeptRequest
   * @param headers - ListParentByDeptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListParentByDeptResponse
   */
  async listParentByDeptWithOptions(request: ListParentByDeptRequest, headers: ListParentByDeptHeaders, runtime: $Util.RuntimeOptions): Promise<ListParentByDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "ListParentByDept",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/departments/listParentByDepartment`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListParentByDeptResponse>(await this.execute(params, req, runtime), new ListParentByDeptResponse({}));
  }

  /**
   * 查询部门所有父部门列表
   * 
   * @param request - ListParentByDeptRequest
   * @returns ListParentByDeptResponse
   */
  async listParentByDept(request: ListParentByDeptRequest): Promise<ListParentByDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListParentByDeptHeaders({ });
    return await this.listParentByDeptWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户所有父部门列表
   * 
   * @param request - ListParentByUserRequest
   * @param headers - ListParentByUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListParentByUserResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListParentByUser",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/departments/listParentByUser`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListParentByUserResponse>(await this.execute(params, req, runtime), new ListParentByUserResponse({}));
  }

  /**
   * 查询用户所有父部门列表
   * 
   * @param request - ListParentByUserRequest
   * @returns ListParentByUserResponse
   */
  async listParentByUser(request: ListParentByUserRequest): Promise<ListParentByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListParentByUserHeaders({ });
    return await this.listParentByUserWithOptions(request, headers, runtime);
  }

  /**
   * 居民通讯录获取部门下人员信息
   * 
   * @param request - ListResidentDeptUsersRequest
   * @param headers - ListResidentDeptUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListResidentDeptUsersResponse
   */
  async listResidentDeptUsersWithOptions(departmentId: string, request: ListResidentDeptUsersRequest, headers: ListResidentDeptUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListResidentDeptUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.role)) {
      query["role"] = request.role;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "ListResidentDeptUsers",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/residentDepartments/${departmentId}/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListResidentDeptUsersResponse>(await this.execute(params, req, runtime), new ListResidentDeptUsersResponse({}));
  }

  /**
   * 居民通讯录获取部门下人员信息
   * 
   * @param request - ListResidentDeptUsersRequest
   * @returns ListResidentDeptUsersResponse
   */
  async listResidentDeptUsers(departmentId: string, request: ListResidentDeptUsersRequest): Promise<ListResidentDeptUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListResidentDeptUsersHeaders({ });
    return await this.listResidentDeptUsersWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 居民通讯录获取子部门列表
   * 
   * @param request - ListResidentSubDeptsRequest
   * @param headers - ListResidentSubDeptsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListResidentSubDeptsResponse
   */
  async listResidentSubDeptsWithOptions(departmentId: string, request: ListResidentSubDeptsRequest, headers: ListResidentSubDeptsHeaders, runtime: $Util.RuntimeOptions): Promise<ListResidentSubDeptsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "ListResidentSubDepts",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/residentDepartments/${departmentId}/subDepartments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListResidentSubDeptsResponse>(await this.execute(params, req, runtime), new ListResidentSubDeptsResponse({}));
  }

  /**
   * 居民通讯录获取子部门列表
   * 
   * @param request - ListResidentSubDeptsRequest
   * @returns ListResidentSubDeptsResponse
   */
  async listResidentSubDepts(departmentId: string, request: ListResidentSubDeptsRequest): Promise<ListResidentSubDeptsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListResidentSubDeptsHeaders({ });
    return await this.listResidentSubDeptsWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 居民通讯录批量获取用户详细信息
   * 
   * @param tmpReq - ListResidentUserInfosRequest
   * @param headers - ListResidentUserInfosHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListResidentUserInfosResponse
   */
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListResidentUserInfos",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/residentUsers/getByUserIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListResidentUserInfosResponse>(await this.execute(params, req, runtime), new ListResidentUserInfosResponse({}));
  }

  /**
   * 居民通讯录批量获取用户详细信息
   * 
   * @param request - ListResidentUserInfosRequest
   * @returns ListResidentUserInfosResponse
   */
  async listResidentUserInfos(request: ListResidentUserInfosRequest): Promise<ListResidentUserInfosResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListResidentUserInfosHeaders({ });
    return await this.listResidentUserInfosWithOptions(request, headers, runtime);
  }

  /**
   * 根据角色获取用户列表
   * 
   * @param request - ListSimpleUsersByRoleRequest
   * @param headers - ListSimpleUsersByRoleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSimpleUsersByRoleResponse
   */
  async listSimpleUsersByRoleWithOptions(request: ListSimpleUsersByRoleRequest, headers: ListSimpleUsersByRoleHeaders, runtime: $Util.RuntimeOptions): Promise<ListSimpleUsersByRoleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.offset)) {
      query["offset"] = request.offset;
    }

    if (!Util.isUnset(request.roleId)) {
      query["roleId"] = request.roleId;
    }

    if (!Util.isUnset(request.size)) {
      query["size"] = request.size;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "ListSimpleUsersByRole",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/users/listByRole`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListSimpleUsersByRoleResponse>(await this.execute(params, req, runtime), new ListSimpleUsersByRoleResponse({}));
  }

  /**
   * 根据角色获取用户列表
   * 
   * @param request - ListSimpleUsersByRoleRequest
   * @returns ListSimpleUsersByRoleResponse
   */
  async listSimpleUsersByRole(request: ListSimpleUsersByRoleRequest): Promise<ListSimpleUsersByRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSimpleUsersByRoleHeaders({ });
    return await this.listSimpleUsersByRoleWithOptions(request, headers, runtime);
  }

  /**
   * 获取下级指定区域层级组织
   * 
   * @param request - ListSubCorpsRequest
   * @param headers - ListSubCorpsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSubCorpsResponse
   */
  async listSubCorpsWithOptions(request: ListSubCorpsRequest, headers: ListSubCorpsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubCorpsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isOnlyDirect)) {
      query["isOnlyDirect"] = request.isOnlyDirect;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
    }

    if (!Util.isUnset(request.types)) {
      query["types"] = request.types;
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
      action: "ListSubCorps",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/corps/subCorps`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListSubCorpsResponse>(await this.execute(params, req, runtime), new ListSubCorpsResponse({}));
  }

  /**
   * 获取下级指定区域层级组织
   * 
   * @param request - ListSubCorpsRequest
   * @returns ListSubCorpsResponse
   */
  async listSubCorps(request: ListSubCorpsRequest): Promise<ListSubCorpsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubCorpsHeaders({ });
    return await this.listSubCorpsWithOptions(request, headers, runtime);
  }

  /**
   * 查询子部门列表
   * 
   * @param request - ListSubDeptRequest
   * @param headers - ListSubDeptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSubDeptResponse
   */
  async listSubDeptWithOptions(departmentId: string, request: ListSubDeptRequest, headers: ListSubDeptHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.language)) {
      query["language"] = request.language;
    }

    if (!Util.isUnset(request.subCorpId)) {
      query["subCorpId"] = request.subCorpId;
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
      action: "ListSubDept",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/departments/${departmentId}/subDepartments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListSubDeptResponse>(await this.execute(params, req, runtime), new ListSubDeptResponse({}));
  }

  /**
   * 查询子部门列表
   * 
   * @param request - ListSubDeptRequest
   * @returns ListSubDeptResponse
   */
  async listSubDept(departmentId: string, request: ListSubDeptRequest): Promise<ListSubDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubDeptHeaders({ });
    return await this.listSubDeptWithOptions(departmentId, request, headers, runtime);
  }

  /**
   * 查询部门下的子部门ID列表，不会递归查询，只包含ID
   * 
   * @param request - ListSubDeptIdsRequest
   * @param headers - ListSubDeptIdsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSubDeptIdsResponse
   */
  async listSubDeptIdsWithOptions(departmentId: string, request: ListSubDeptIdsRequest, headers: ListSubDeptIdsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubDeptIdsResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListSubDeptIds",
      version: "village_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/village/departments/${departmentId}/subDepartmentIds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListSubDeptIdsResponse>(await this.execute(params, req, runtime), new ListSubDeptIdsResponse({}));
  }

  /**
   * 查询部门下的子部门ID列表，不会递归查询，只包含ID
   * 
   * @param request - ListSubDeptIdsRequest
   * @returns ListSubDeptIdsResponse
   */
  async listSubDeptIds(departmentId: string, request: ListSubDeptIdsRequest): Promise<ListSubDeptIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubDeptIdsHeaders({ });
    return await this.listSubDeptIdsWithOptions(departmentId, request, headers, runtime);
  }

}
