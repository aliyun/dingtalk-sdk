// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryUserInfoHeaders extends $tea.Model {
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

export class QueryUserInfoResponseBody extends $tea.Model {
  content?: QueryUserInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryUserInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptHeaders extends $tea.Model {
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

export class QueryAllMemberByDeptRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBody extends $tea.Model {
  content?: QueryAllMemberByDeptResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllMemberByDeptResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllMemberByDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllMemberByDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRolesHeaders extends $tea.Model {
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

export class QueryUserRolesResponseBody extends $tea.Model {
  content?: QueryUserRolesResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserRolesResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupHeaders extends $tea.Model {
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

export class QueryAllGroupRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponseBody extends $tea.Model {
  content?: QueryAllGroupResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllGroupResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptHeaders extends $tea.Model {
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

export class QueryAllGroupsInDeptRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponseBody extends $tea.Model {
  content?: QueryAllGroupsInDeptResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllGroupsInDeptResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllGroupsInDeptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllGroupsInDeptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesHeaders extends $tea.Model {
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

export class QueryUserExtendValuesRequest extends $tea.Model {
  dingOrgId?: number;
  userIds?: string[];
  userExtendKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingOrgId: 'dingOrgId',
      userIds: 'userIds',
      userExtendKey: 'userExtendKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOrgId: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
      userExtendKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesResponseBody extends $tea.Model {
  content?: QueryUserExtendValuesResponseBodyContent[];
  totalCount?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalCount: 'totalCount',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserExtendValuesResponseBodyContent },
      totalCount: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserExtendValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserExtendValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoHeaders extends $tea.Model {
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

export class QueryDepartmentInfoResponseBody extends $tea.Model {
  content?: QueryDepartmentInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryDepartmentInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryDepartmentInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryDepartmentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserExtendInfoHeaders extends $tea.Model {
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

export class UpdateUserExtendInfoRequest extends $tea.Model {
  jobCode?: string;
  userProbCode?: string;
  jobStatusCode?: string[];
  comments?: string;
  static names(): { [key: string]: string } {
    return {
      jobCode: 'jobCode',
      userProbCode: 'userProbCode',
      jobStatusCode: 'jobStatusCode',
      comments: 'comments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobCode: 'string',
      userProbCode: 'string',
      jobStatusCode: { 'type': 'array', 'itemType': 'string' },
      comments: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserExtendInfoResponse extends $tea.Model {
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

export class QueryUserExtInfoHeaders extends $tea.Model {
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

export class QueryUserExtInfoResponseBody extends $tea.Model {
  content?: QueryUserExtInfoResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserExtInfoResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserExtInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserExtInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobCodeDictionaryHeaders extends $tea.Model {
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

export class QueryJobCodeDictionaryResponseBody extends $tea.Model {
  content?: QueryJobCodeDictionaryResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryJobCodeDictionaryResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobCodeDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryJobCodeDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryJobCodeDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostHeaders extends $tea.Model {
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

export class IndustryManufactureLabourCostRequest extends $tea.Model {
  processNo?: string;
  materialNo?: string;
  startTime?: number;
  endTime?: number;
  cursor?: number;
  pageNumber?: number;
  pageSize?: number;
  tokenGrantType?: number;
  orgId?: number;
  corpId?: string;
  isvOrgId?: string;
  suiteKey?: string;
  microappAgentId?: number;
  appIds?: number[];
  appId?: number;
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      processNo: 'processNo',
      materialNo: 'materialNo',
      startTime: 'startTime',
      endTime: 'endTime',
      cursor: 'cursor',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      tokenGrantType: 'tokenGrantType',
      orgId: 'orgId',
      corpId: 'corpId',
      isvOrgId: 'isvOrgId',
      suiteKey: 'suiteKey',
      microappAgentId: 'microappAgentId',
      appIds: 'appIds',
      appId: 'appId',
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processNo: 'string',
      materialNo: 'string',
      startTime: 'number',
      endTime: 'number',
      cursor: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      tokenGrantType: 'number',
      orgId: 'number',
      corpId: 'string',
      isvOrgId: 'string',
      suiteKey: 'string',
      microappAgentId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appId: 'number',
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostResponseBody extends $tea.Model {
  list?: IndustryManufactureLabourCostResponseBodyList[];
  hasMore?: boolean;
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      hasMore: 'hasMore',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': IndustryManufactureLabourCostResponseBodyList },
      hasMore: 'boolean',
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureLabourCostResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureLabourCostResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoHeaders extends $tea.Model {
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

export class QueryHospitalDistrictInfoRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoResponseBody extends $tea.Model {
  content?: QueryHospitalDistrictInfoResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryHospitalDistrictInfoResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHospitalDistrictInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHospitalDistrictInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetHeaders extends $tea.Model {
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

export class IndustryManufactureCostRecordListGetRequest extends $tea.Model {
  instanceId?: string;
  materialNo?: string;
  orderNo?: string;
  productionTaskNo?: string;
  startTime?: number;
  endTime?: number;
  cursor?: number;
  pageNumber?: number;
  pageSize?: number;
  tokenGrantType?: number;
  orgId?: number;
  corpId?: string;
  isvOrgId?: number;
  suiteKey?: string;
  microappAgentId?: number;
  appIds?: number[];
  appId?: number;
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      materialNo: 'materialNo',
      orderNo: 'orderNo',
      productionTaskNo: 'productionTaskNo',
      startTime: 'startTime',
      endTime: 'endTime',
      cursor: 'cursor',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      tokenGrantType: 'tokenGrantType',
      orgId: 'orgId',
      corpId: 'corpId',
      isvOrgId: 'isvOrgId',
      suiteKey: 'suiteKey',
      microappAgentId: 'microappAgentId',
      appIds: 'appIds',
      appId: 'appId',
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      materialNo: 'string',
      orderNo: 'string',
      productionTaskNo: 'string',
      startTime: 'number',
      endTime: 'number',
      cursor: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      tokenGrantType: 'number',
      orgId: 'number',
      corpId: 'string',
      isvOrgId: 'number',
      suiteKey: 'string',
      microappAgentId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appId: 'number',
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetResponseBody extends $tea.Model {
  list?: IndustryManufactureCostRecordListGetResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': IndustryManufactureCostRecordListGetResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureCostRecordListGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureCostRecordListGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupHeaders extends $tea.Model {
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

export class QueryAllMemberByGroupRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBody extends $tea.Model {
  content?: QueryAllMemberByGroupResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllMemberByGroupResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllMemberByGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllMemberByGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRolesHeaders extends $tea.Model {
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

export class QueryHospitalRolesResponseBody extends $tea.Model {
  content?: QueryHospitalRolesResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryHospitalRolesResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHospitalRolesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHospitalRolesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogHeaders extends $tea.Model {
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

export class QueryBizOptLogRequest extends $tea.Model {
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

export class QueryBizOptLogResponseBody extends $tea.Model {
  content?: QueryBizOptLogResponseBodyContent[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryBizOptLogResponseBodyContent },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryBizOptLogResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryBizOptLogResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoHeaders extends $tea.Model {
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

export class QueryHospitalRoleUserInfoRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoResponseBody extends $tea.Model {
  content?: QueryHospitalRoleUserInfoResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryHospitalRoleUserInfoResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryHospitalRoleUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryHospitalRoleUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserProbCodeDictionaryHeaders extends $tea.Model {
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

export class QueryUserProbCodeDictionaryResponseBody extends $tea.Model {
  content?: QueryUserProbCodeDictionaryResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryUserProbCodeDictionaryResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserProbCodeDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserProbCodeDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserProbCodeDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobStatusCodeDictionaryHeaders extends $tea.Model {
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

export class QueryJobStatusCodeDictionaryResponseBody extends $tea.Model {
  content?: QueryJobStatusCodeDictionaryResponseBodyContent[];
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryJobStatusCodeDictionaryResponseBodyContent },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobStatusCodeDictionaryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryJobStatusCodeDictionaryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryJobStatusCodeDictionaryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMedicalEventsHeaders extends $tea.Model {
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

export class QueryMedicalEventsResponseBody extends $tea.Model {
  content?: QueryMedicalEventsResponseBodyContent[];
  totalCount?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalCount: 'totalCount',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryMedicalEventsResponseBodyContent },
      totalCount: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMedicalEventsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMedicalEventsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMedicalEventsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListHeaders extends $tea.Model {
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

export class IndustryManufactureMaterialListRequest extends $tea.Model {
  tokenGrantType?: number;
  corpId?: string;
  pageSize?: number;
  endTime?: number;
  instanceId?: string;
  materialNo?: string;
  startTime?: number;
  microappAgentId?: number;
  cursor?: number;
  appName?: string;
  orgId?: number;
  appId?: number;
  suiteKey?: string;
  appIds?: number[];
  currentPage?: number;
  isvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      tokenGrantType: 'tokenGrantType',
      corpId: 'corpId',
      pageSize: 'pageSize',
      endTime: 'endTime',
      instanceId: 'instanceId',
      materialNo: 'materialNo',
      startTime: 'startTime',
      microappAgentId: 'microappAgentId',
      cursor: 'cursor',
      appName: 'appName',
      orgId: 'orgId',
      appId: 'appId',
      suiteKey: 'suiteKey',
      appIds: 'appIds',
      currentPage: 'currentPage',
      isvOrgId: 'isvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tokenGrantType: 'number',
      corpId: 'string',
      pageSize: 'number',
      endTime: 'number',
      instanceId: 'string',
      materialNo: 'string',
      startTime: 'number',
      microappAgentId: 'number',
      cursor: 'number',
      appName: 'string',
      orgId: 'number',
      appId: 'number',
      suiteKey: 'string',
      appIds: { 'type': 'array', 'itemType': 'number' },
      currentPage: 'number',
      isvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListResponseBody extends $tea.Model {
  list?: IndustryManufactureMaterialListResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': IndustryManufactureMaterialListResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureMaterialListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureMaterialListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetHeaders extends $tea.Model {
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

export class IndustryMmanufactureMaterialCostGetRequest extends $tea.Model {
  instanceId?: string;
  materialNo?: string;
  startTime?: number;
  endTime?: number;
  cursor?: number;
  pageNumber?: number;
  pageSize?: number;
  tokenGrantType?: number;
  orgId?: number;
  corpId?: string;
  isvOrgId?: number;
  suiteKey?: string;
  microappAgentId?: number;
  appIds?: number[];
  appId?: number;
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      materialNo: 'materialNo',
      startTime: 'startTime',
      endTime: 'endTime',
      cursor: 'cursor',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      tokenGrantType: 'tokenGrantType',
      orgId: 'orgId',
      corpId: 'corpId',
      isvOrgId: 'isvOrgId',
      suiteKey: 'suiteKey',
      microappAgentId: 'microappAgentId',
      appIds: 'appIds',
      appId: 'appId',
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      materialNo: 'string',
      startTime: 'number',
      endTime: 'number',
      cursor: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      tokenGrantType: 'number',
      orgId: 'number',
      corpId: 'string',
      isvOrgId: 'number',
      suiteKey: 'string',
      microappAgentId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appId: 'number',
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetResponseBody extends $tea.Model {
  list?: IndustryMmanufactureMaterialCostGetResponseBodyList[];
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
      list: { 'type': 'array', 'itemType': IndustryMmanufactureMaterialCostGetResponseBodyList },
      totalCount: 'number',
      nextCursor: 'number',
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryMmanufactureMaterialCostGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryMmanufactureMaterialCostGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetHeaders extends $tea.Model {
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

export class IndustryManufactureFeeListGetRequest extends $tea.Model {
  productionTaskNo?: string;
  materialNo?: string;
  type?: string;
  startTime?: number;
  endTime?: number;
  cursor?: number;
  pageNumber?: number;
  pageSize?: number;
  tokenGrantType?: number;
  orgId?: number;
  corpId?: string;
  isvOrgId?: number;
  suiteKey?: string;
  microappAgentId?: number;
  appIds?: number[];
  appId?: number;
  appName?: string;
  static names(): { [key: string]: string } {
    return {
      productionTaskNo: 'productionTaskNo',
      materialNo: 'materialNo',
      type: 'type',
      startTime: 'startTime',
      endTime: 'endTime',
      cursor: 'cursor',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      tokenGrantType: 'tokenGrantType',
      orgId: 'orgId',
      corpId: 'corpId',
      isvOrgId: 'isvOrgId',
      suiteKey: 'suiteKey',
      microappAgentId: 'microappAgentId',
      appIds: 'appIds',
      appId: 'appId',
      appName: 'appName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      productionTaskNo: 'string',
      materialNo: 'string',
      type: 'string',
      startTime: 'number',
      endTime: 'number',
      cursor: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      tokenGrantType: 'number',
      orgId: 'number',
      corpId: 'string',
      isvOrgId: 'number',
      suiteKey: 'string',
      microappAgentId: 'number',
      appIds: { 'type': 'array', 'itemType': 'number' },
      appId: 'number',
      appName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetResponseBody extends $tea.Model {
  list?: IndustryManufactureFeeListGetResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': IndustryManufactureFeeListGetResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IndustryManufactureFeeListGetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IndustryManufactureFeeListGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsHeaders extends $tea.Model {
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

export class QueryAllDoctorsRequest extends $tea.Model {
  pageSize?: number;
  pageNum?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNum: 'pageNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBody extends $tea.Model {
  content?: QueryAllDoctorsResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllDoctorsResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllDoctorsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllDoctorsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentHeaders extends $tea.Model {
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

export class QueryAllDepartmentRequest extends $tea.Model {
  pageSize?: number;
  pageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      pageSize: 'pageSize',
      pageNumber: 'pageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageSize: 'number',
      pageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBody extends $tea.Model {
  content?: QueryAllDepartmentResponseBodyContent[];
  totalPages?: number;
  totalCount?: number;
  currentPage?: number;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      totalPages: 'totalPages',
      totalCount: 'totalCount',
      currentPage: 'currentPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContent },
      totalPages: 'number',
      totalCount: 'number',
      currentPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAllDepartmentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryAllDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoHeaders extends $tea.Model {
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

export class QueryGroupInfoResponseBody extends $tea.Model {
  content?: QueryGroupInfoResponseBodyContent;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: QueryGroupInfoResponseBodyContent,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryGroupInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveUserExtendValuesHeaders extends $tea.Model {
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

export class SaveUserExtendValuesRequest extends $tea.Model {
  userExtendKey?: string;
  userExtendValue?: string;
  userDisplayName?: string;
  static names(): { [key: string]: string } {
    return {
      userExtendKey: 'userExtendKey',
      userExtendValue: 'userExtendValue',
      userDisplayName: 'userDisplayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userExtendKey: 'string',
      userExtendValue: 'string',
      userDisplayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveUserExtendValuesResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveUserExtendValuesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveUserExtendValuesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveUserExtendValuesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentJobStatus extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentUserProb extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentGroup extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  deptName?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
      deptName: 'deptName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
      deptName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentDept extends $tea.Model {
  id?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContentJobStatusList extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserInfoResponseBodyContent extends $tea.Model {
  uid?: string;
  userName?: string;
  job?: QueryUserInfoResponseBodyContentJob;
  jobNum?: string;
  jobStatus?: QueryUserInfoResponseBodyContentJobStatus;
  userProb?: QueryUserInfoResponseBodyContentUserProb;
  group?: QueryUserInfoResponseBodyContentGroup[];
  dept?: QueryUserInfoResponseBodyContentDept[];
  comments?: string;
  jobStatusList?: QueryUserInfoResponseBodyContentJobStatusList[];
  static names(): { [key: string]: string } {
    return {
      uid: 'uid',
      userName: 'userName',
      job: 'job',
      jobNum: 'jobNum',
      jobStatus: 'jobStatus',
      userProb: 'userProb',
      group: 'group',
      dept: 'dept',
      comments: 'comments',
      jobStatusList: 'jobStatusList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uid: 'string',
      userName: 'string',
      job: QueryUserInfoResponseBodyContentJob,
      jobNum: 'string',
      jobStatus: QueryUserInfoResponseBodyContentJobStatus,
      userProb: QueryUserInfoResponseBodyContentUserProb,
      group: { 'type': 'array', 'itemType': QueryUserInfoResponseBodyContentGroup },
      dept: { 'type': 'array', 'itemType': QueryUserInfoResponseBodyContentDept },
      comments: 'string',
      jobStatusList: { 'type': 'array', 'itemType': QueryUserInfoResponseBodyContentJobStatusList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByDeptResponseBodyContent extends $tea.Model {
  uid?: string;
  userName?: string;
  jobNum?: string;
  static names(): { [key: string]: string } {
    return {
      uid: 'uid',
      userName: 'userName',
      jobNum: 'jobNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uid: 'string',
      userName: 'string',
      jobNum: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRolesResponseBodyContent extends $tea.Model {
  roleCode?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      roleCode: 'roleCode',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleCode: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllGroupsInDeptResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtendValuesResponseBodyContent extends $tea.Model {
  userExtendKey?: string;
  userExtendValue?: string;
  userExtendDisplayName?: string;
  userCode?: string;
  static names(): { [key: string]: string } {
    return {
      userExtendKey: 'userExtendKey',
      userExtendValue: 'userExtendValue',
      userExtendDisplayName: 'userExtendDisplayName',
      userCode: 'userCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userExtendKey: 'string',
      userExtendValue: 'string',
      userExtendDisplayName: 'string',
      userCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentLeaderJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentLeader extends $tea.Model {
  name?: string;
  userId?: string;
  jobNumber?: string;
  job?: QueryDepartmentInfoResponseBodyContentLeaderJob;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      jobNumber: 'jobNumber',
      job: 'job',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      jobNumber: 'string',
      job: QueryDepartmentInfoResponseBodyContentLeaderJob,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentResidentLeaderJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContentResidentLeader extends $tea.Model {
  name?: string;
  userId?: string;
  jobNumber?: string;
  job?: QueryDepartmentInfoResponseBodyContentResidentLeaderJob;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      jobNumber: 'jobNumber',
      job: 'job',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      jobNumber: 'string',
      job: QueryDepartmentInfoResponseBodyContentResidentLeaderJob,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDepartmentInfoResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  leader?: QueryDepartmentInfoResponseBodyContentLeader;
  residentLeader?: QueryDepartmentInfoResponseBodyContentResidentLeader;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      leader: 'leader',
      residentLeader: 'residentLeader',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      leader: QueryDepartmentInfoResponseBodyContentLeader,
      residentLeader: QueryDepartmentInfoResponseBodyContentResidentLeader,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserExtInfoResponseBodyContent extends $tea.Model {
  userExtendKey?: string;
  userExtendValue?: string;
  userExtendDisplayName?: string;
  orgId?: string;
  status?: number;
  userCode?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      userExtendKey: 'userExtendKey',
      userExtendValue: 'userExtendValue',
      userExtendDisplayName: 'userExtendDisplayName',
      orgId: 'orgId',
      status: 'status',
      userCode: 'userCode',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userExtendKey: 'string',
      userExtendValue: 'string',
      userExtendDisplayName: 'string',
      orgId: 'string',
      status: 'number',
      userCode: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobCodeDictionaryResponseBodyContent extends $tea.Model {
  code?: string;
  category?: string;
  displayName?: string;
  doctorType?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      category: 'category',
      displayName: 'displayName',
      doctorType: 'doctorType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      category: 'string',
      displayName: 'string',
      doctorType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureLabourCostResponseBodyList extends $tea.Model {
  gmtCreate?: number;
  gmtModified?: number;
  corpId?: string;
  labourCostNo?: string;
  labourCostName?: string;
  processNo?: string;
  processName?: string;
  materialNo?: string;
  materialName?: string;
  qualifiedPrice?: number;
  unQualifiedPrice1?: number;
  unQualifiedReason1?: string;
  instanceId?: string;
  processCode?: string;
  ext?: string;
  unQualifiedReason2?: string;
  unQualifiedPrice2?: number;
  unQualifiedInfo?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      corpId: 'corpId',
      labourCostNo: 'labourCostNo',
      labourCostName: 'labourCostName',
      processNo: 'processNo',
      processName: 'processName',
      materialNo: 'materialNo',
      materialName: 'materialName',
      qualifiedPrice: 'qualifiedPrice',
      unQualifiedPrice1: 'unQualifiedPrice1',
      unQualifiedReason1: 'unQualifiedReason1',
      instanceId: 'instanceId',
      processCode: 'processCode',
      ext: 'ext',
      unQualifiedReason2: 'unQualifiedReason2',
      unQualifiedPrice2: 'unQualifiedPrice2',
      unQualifiedInfo: 'unQualifiedInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'number',
      gmtModified: 'number',
      corpId: 'string',
      labourCostNo: 'string',
      labourCostName: 'string',
      processNo: 'string',
      processName: 'string',
      materialNo: 'string',
      materialName: 'string',
      qualifiedPrice: 'number',
      unQualifiedPrice1: 'number',
      unQualifiedReason1: 'string',
      instanceId: 'string',
      processCode: 'string',
      ext: 'string',
      unQualifiedReason2: 'string',
      unQualifiedPrice2: 'number',
      unQualifiedInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalDistrictInfoResponseBodyContent extends $tea.Model {
  id?: number;
  districtName?: string;
  districtType?: number;
  parentDistrictId?: number;
  address?: string;
  deleted?: number;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      districtName: 'districtName',
      districtType: 'districtType',
      parentDistrictId: 'parentDistrictId',
      address: 'address',
      deleted: 'deleted',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      districtName: 'string',
      districtType: 'number',
      parentDistrictId: 'number',
      address: 'string',
      deleted: 'number',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureCostRecordListGetResponseBodyList extends $tea.Model {
  gmtCreate?: number;
  gmtModified?: number;
  corpId?: string;
  materialCostRecordNo?: string;
  instanceId?: string;
  materialNo?: string;
  materialName?: string;
  unit?: string;
  count?: number;
  type?: string;
  price?: number;
  orderNo?: string;
  productionTaskNo?: string;
  isDeleted?: string;
  ext?: string;
  memo?: string;
  realCount?: number;
  realPrice?: number;
  processCode?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      corpId: 'corpId',
      materialCostRecordNo: 'materialCostRecordNo',
      instanceId: 'instanceId',
      materialNo: 'materialNo',
      materialName: 'materialName',
      unit: 'unit',
      count: 'count',
      type: 'type',
      price: 'price',
      orderNo: 'orderNo',
      productionTaskNo: 'productionTaskNo',
      isDeleted: 'isDeleted',
      ext: 'ext',
      memo: 'memo',
      realCount: 'realCount',
      realPrice: 'realPrice',
      processCode: 'processCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'number',
      gmtModified: 'number',
      corpId: 'string',
      materialCostRecordNo: 'string',
      instanceId: 'string',
      materialNo: 'string',
      materialName: 'string',
      unit: 'string',
      count: 'number',
      type: 'string',
      price: 'number',
      orderNo: 'string',
      productionTaskNo: 'string',
      isDeleted: 'string',
      ext: 'string',
      memo: 'string',
      realCount: 'number',
      realPrice: 'number',
      processCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllMemberByGroupResponseBodyContent extends $tea.Model {
  uid?: string;
  userName?: string;
  jobNum?: string;
  static names(): { [key: string]: string } {
    return {
      uid: 'uid',
      userName: 'userName',
      jobNum: 'jobNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uid: 'string',
      userName: 'string',
      jobNum: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRolesResponseBodyContent extends $tea.Model {
  id?: number;
  gmtCreate?: string;
  isDeleted?: number;
  roleCode?: string;
  roleName?: string;
  remark?: string;
  sort?: number;
  readOnly?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      gmtCreate: 'gmtCreate',
      isDeleted: 'isDeleted',
      roleCode: 'roleCode',
      roleName: 'roleName',
      remark: 'remark',
      sort: 'sort',
      readOnly: 'readOnly',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      gmtCreate: 'string',
      isDeleted: 'number',
      roleCode: 'string',
      roleName: 'string',
      remark: 'string',
      sort: 'number',
      readOnly: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBizOptLogResponseBodyContent extends $tea.Model {
  id?: number;
  dataType?: number;
  bizType?: number;
  optTime?: number;
  optUserCode?: string;
  optUserName?: string;
  optJobNumber?: string;
  optType?: number;
  optBizType?: number;
  optObjectCode?: string;
  optObjectUserJobNo?: string;
  optObjectName?: string;
  optSuccess?: number;
  remark?: string;
  optBeforeData?: string;
  optAfterData?: string;
  optExtend?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      dataType: 'dataType',
      bizType: 'bizType',
      optTime: 'optTime',
      optUserCode: 'optUserCode',
      optUserName: 'optUserName',
      optJobNumber: 'optJobNumber',
      optType: 'optType',
      optBizType: 'optBizType',
      optObjectCode: 'optObjectCode',
      optObjectUserJobNo: 'optObjectUserJobNo',
      optObjectName: 'optObjectName',
      optSuccess: 'optSuccess',
      remark: 'remark',
      optBeforeData: 'optBeforeData',
      optAfterData: 'optAfterData',
      optExtend: 'optExtend',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      dataType: 'number',
      bizType: 'number',
      optTime: 'number',
      optUserCode: 'string',
      optUserName: 'string',
      optJobNumber: 'string',
      optType: 'number',
      optBizType: 'number',
      optObjectCode: 'string',
      optObjectUserJobNo: 'string',
      optObjectName: 'string',
      optSuccess: 'number',
      remark: 'string',
      optBeforeData: 'string',
      optAfterData: 'string',
      optExtend: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHospitalRoleUserInfoResponseBodyContent extends $tea.Model {
  userCode?: string;
  userName?: string;
  jobNumber?: string;
  roleCode?: string;
  roleName?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      userCode: 'userCode',
      userName: 'userName',
      jobNumber: 'jobNumber',
      roleCode: 'roleCode',
      roleName: 'roleName',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userCode: 'string',
      userName: 'string',
      jobNumber: 'string',
      roleCode: 'string',
      roleName: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserProbCodeDictionaryResponseBodyContent extends $tea.Model {
  code?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobStatusCodeDictionaryResponseBodyContent extends $tea.Model {
  code?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMedicalEventsResponseBodyContent extends $tea.Model {
  eventId?: number;
  code?: string;
  content?: string;
  static names(): { [key: string]: string } {
    return {
      eventId: 'eventId',
      code: 'code',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      eventId: 'number',
      code: 'string',
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureMaterialListResponseBodyList extends $tea.Model {
  corpId?: string;
  instanceId?: string;
  materialNo?: string;
  materialName?: string;
  specification?: string;
  type?: string;
  category?: string;
  unit?: string;
  ext?: string;
  processCode?: string;
  stockMaxWarn?: number;
  stockMinWarn?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      instanceId: 'instanceId',
      materialNo: 'materialNo',
      materialName: 'materialName',
      specification: 'specification',
      type: 'type',
      category: 'category',
      unit: 'unit',
      ext: 'ext',
      processCode: 'processCode',
      stockMaxWarn: 'stockMaxWarn',
      stockMinWarn: 'stockMinWarn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      instanceId: 'string',
      materialNo: 'string',
      materialName: 'string',
      specification: 'string',
      type: 'string',
      category: 'string',
      unit: 'string',
      ext: 'string',
      processCode: 'string',
      stockMaxWarn: 'number',
      stockMinWarn: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryMmanufactureMaterialCostGetResponseBodyList extends $tea.Model {
  gmtCreate?: number;
  gmtModified?: number;
  corpId?: string;
  materialCostNo?: string;
  instanceId?: string;
  materialNo?: string;
  materialName?: string;
  unit?: string;
  count?: number;
  price?: number;
  actPrice?: number;
  ext?: string;
  processCode?: string;
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      corpId: 'corpId',
      materialCostNo: 'materialCostNo',
      instanceId: 'instanceId',
      materialNo: 'materialNo',
      materialName: 'materialName',
      unit: 'unit',
      count: 'count',
      price: 'price',
      actPrice: 'actPrice',
      ext: 'ext',
      processCode: 'processCode',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'number',
      gmtModified: 'number',
      corpId: 'string',
      materialCostNo: 'string',
      instanceId: 'string',
      materialNo: 'string',
      materialName: 'string',
      unit: 'string',
      count: 'number',
      price: 'number',
      actPrice: 'number',
      ext: 'string',
      processCode: 'string',
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IndustryManufactureFeeListGetResponseBodyList extends $tea.Model {
  id?: number;
  gmtCreate?: number;
  gmtModified?: number;
  corpId?: string;
  productionTaskNo?: string;
  materialNo?: string;
  materialName?: string;
  count?: number;
  unit?: string;
  type?: string;
  amount?: string;
  perAmount?: number;
  isDeleted?: string;
  instanceId?: string;
  processCode?: string;
  ext?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      corpId: 'corpId',
      productionTaskNo: 'productionTaskNo',
      materialNo: 'materialNo',
      materialName: 'materialName',
      count: 'count',
      unit: 'unit',
      type: 'type',
      amount: 'amount',
      perAmount: 'perAmount',
      isDeleted: 'isDeleted',
      instanceId: 'instanceId',
      processCode: 'processCode',
      ext: 'ext',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      gmtCreate: 'number',
      gmtModified: 'number',
      corpId: 'string',
      productionTaskNo: 'string',
      materialNo: 'string',
      materialName: 'string',
      count: 'number',
      unit: 'string',
      type: 'string',
      amount: 'string',
      perAmount: 'number',
      isDeleted: 'string',
      instanceId: 'string',
      processCode: 'string',
      ext: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDoctorsResponseBodyContent extends $tea.Model {
  uid?: string;
  userName?: string;
  jobNum?: string;
  id?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  corpId?: string;
  userCode?: string;
  deptCode?: string;
  status?: number;
  assessGroupId?: string;
  assessGroupName?: string;
  static names(): { [key: string]: string } {
    return {
      uid: 'uid',
      userName: 'userName',
      jobNum: 'jobNum',
      id: 'id',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      corpId: 'corpId',
      userCode: 'userCode',
      deptCode: 'deptCode',
      status: 'status',
      assessGroupId: 'assessGroupId',
      assessGroupName: 'assessGroupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uid: 'string',
      userName: 'string',
      jobNum: 'string',
      id: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      corpId: 'string',
      userCode: 'string',
      deptCode: 'string',
      status: 'number',
      assessGroupId: 'string',
      assessGroupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList extends $tea.Model {
  id?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentDeptAndExtDepartment extends $tea.Model {
  id?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  corpId?: string;
  deptCode?: string;
  deptType?: number;
  deptStatus?: number;
  parentDeptCode?: string;
  deptOrder?: number;
  remark?: string;
  deptName?: string;
  name?: string;
  wardIdList?: QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList[];
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      corpId: 'corpId',
      deptCode: 'deptCode',
      deptType: 'deptType',
      deptStatus: 'deptStatus',
      parentDeptCode: 'parentDeptCode',
      deptOrder: 'deptOrder',
      remark: 'remark',
      deptName: 'deptName',
      name: 'name',
      wardIdList: 'wardIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      corpId: 'string',
      deptCode: 'string',
      deptType: 'number',
      deptStatus: 'number',
      parentDeptCode: 'string',
      deptOrder: 'number',
      remark: 'string',
      deptName: 'string',
      name: 'string',
      wardIdList: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContentDeptAndExtDepartmentWardIdList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos extends $tea.Model {
  id?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  corpId?: string;
  deptCode?: string;
  deptExtendKey?: string;
  deptExtendValue?: string;
  deptExtendDisplayName?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      corpId: 'corpId',
      deptCode: 'deptCode',
      deptExtendKey: 'deptExtendKey',
      deptExtendValue: 'deptExtendValue',
      deptExtendDisplayName: 'deptExtendDisplayName',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      corpId: 'string',
      deptCode: 'string',
      deptExtendKey: 'string',
      deptExtendValue: 'string',
      deptExtendDisplayName: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentDeptAndExt extends $tea.Model {
  department?: QueryAllDepartmentResponseBodyContentDeptAndExtDepartment;
  extendInfos?: QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos[];
  static names(): { [key: string]: string } {
    return {
      department: 'department',
      extendInfos: 'extendInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      department: QueryAllDepartmentResponseBodyContentDeptAndExtDepartment,
      extendInfos: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContentDeptAndExtExtendInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader extends $tea.Model {
  name?: string;
  userId?: string;
  jobNumber?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      jobNumber: 'jobNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      jobNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtListGroup extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  corpId?: string;
  leader?: QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader;
  deptStatus?: number;
  parentDeptCode?: string;
  remark?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      corpId: 'corpId',
      leader: 'leader',
      deptStatus: 'deptStatus',
      parentDeptCode: 'parentDeptCode',
      remark: 'remark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      corpId: 'string',
      leader: QueryAllDepartmentResponseBodyContentGroupAndExtListGroupLeader,
      deptStatus: 'number',
      parentDeptCode: 'string',
      remark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos extends $tea.Model {
  id?: number;
  gmtCreateStr?: string;
  gmtModifiedStr?: string;
  corpId?: string;
  deptCode?: string;
  deptExtendKey?: string;
  deptExtendValue?: string;
  deptExtendDisplayName?: string;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      gmtCreateStr: 'gmtCreateStr',
      gmtModifiedStr: 'gmtModifiedStr',
      corpId: 'corpId',
      deptCode: 'deptCode',
      deptExtendKey: 'deptExtendKey',
      deptExtendValue: 'deptExtendValue',
      deptExtendDisplayName: 'deptExtendDisplayName',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      gmtCreateStr: 'string',
      gmtModifiedStr: 'string',
      corpId: 'string',
      deptCode: 'string',
      deptExtendKey: 'string',
      deptExtendValue: 'string',
      deptExtendDisplayName: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContentGroupAndExtList extends $tea.Model {
  group?: QueryAllDepartmentResponseBodyContentGroupAndExtListGroup;
  extendInfos?: QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos[];
  static names(): { [key: string]: string } {
    return {
      group: 'group',
      extendInfos: 'extendInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      group: QueryAllDepartmentResponseBodyContentGroupAndExtListGroup,
      extendInfos: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContentGroupAndExtListExtendInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAllDepartmentResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  deptAndExt?: QueryAllDepartmentResponseBodyContentDeptAndExt;
  groupAndExtList?: QueryAllDepartmentResponseBodyContentGroupAndExtList[];
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptAndExt: 'deptAndExt',
      groupAndExtList: 'groupAndExtList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptAndExt: QueryAllDepartmentResponseBodyContentDeptAndExt,
      groupAndExtList: { 'type': 'array', 'itemType': QueryAllDepartmentResponseBodyContentGroupAndExtList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContentLeaderJob extends $tea.Model {
  code?: string;
  bizType?: string;
  category?: string;
  displayName?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      bizType: 'bizType',
      category: 'category',
      displayName: 'displayName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      bizType: 'string',
      category: 'string',
      displayName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContentLeader extends $tea.Model {
  name?: string;
  userId?: string;
  jobNumber?: string;
  job?: QueryGroupInfoResponseBodyContentLeaderJob;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      jobNumber: 'jobNumber',
      job: 'job',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      jobNumber: 'string',
      job: QueryGroupInfoResponseBodyContentLeaderJob,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoResponseBodyContent extends $tea.Model {
  id?: number;
  name?: string;
  deptId?: number;
  leader?: QueryGroupInfoResponseBodyContentLeader;
  startTime?: number;
  endTime?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      deptId: 'deptId',
      leader: 'leader',
      startTime: 'startTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      deptId: 'number',
      leader: QueryGroupInfoResponseBodyContentLeader,
      startTime: 'number',
      endTime: 'number',
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


  async queryUserInfo(userId: string): Promise<QueryUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserInfoHeaders({ });
    return await this.queryUserInfoWithOptions(userId, headers, runtime);
  }

  async queryUserInfoWithOptions(userId: string, headers: QueryUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserInfoResponse> {
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
    return $tea.cast<QueryUserInfoResponse>(await this.doROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/users/${userId}`, "json", req, runtime), new QueryUserInfoResponse({}));
  }

  async queryAllMemberByDept(deptId: string, request: QueryAllMemberByDeptRequest): Promise<QueryAllMemberByDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByDeptHeaders({ });
    return await this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllMemberByDeptWithOptions(deptId: string, request: QueryAllMemberByDeptRequest, headers: QueryAllMemberByDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllMemberByDeptResponse>(await this.doROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}/members`, "json", req, runtime), new QueryAllMemberByDeptResponse({}));
  }

  async queryUserRoles(userId: string): Promise<QueryUserRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserRolesHeaders({ });
    return await this.queryUserRolesWithOptions(userId, headers, runtime);
  }

  async queryUserRolesWithOptions(userId: string, headers: QueryUserRolesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserRolesResponse> {
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
    return $tea.cast<QueryUserRolesResponse>(await this.doROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/users/${userId}/roles`, "json", req, runtime), new QueryUserRolesResponse({}));
  }

  async queryAllGroup(request: QueryAllGroupRequest): Promise<QueryAllGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupHeaders({ });
    return await this.queryAllGroupWithOptions(request, headers, runtime);
  }

  async queryAllGroupWithOptions(request: QueryAllGroupRequest, headers: QueryAllGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllGroupResponse>(await this.doROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups`, "json", req, runtime), new QueryAllGroupResponse({}));
  }

  async queryAllGroupsInDept(deptId: string, request: QueryAllGroupsInDeptRequest): Promise<QueryAllGroupsInDeptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllGroupsInDeptHeaders({ });
    return await this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
  }

  async queryAllGroupsInDeptWithOptions(deptId: string, request: QueryAllGroupsInDeptRequest, headers: QueryAllGroupsInDeptHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllGroupsInDeptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllGroupsInDeptResponse>(await this.doROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}/groups`, "json", req, runtime), new QueryAllGroupsInDeptResponse({}));
  }

  async queryUserExtendValues(request: QueryUserExtendValuesRequest): Promise<QueryUserExtendValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserExtendValuesHeaders({ });
    return await this.queryUserExtendValuesWithOptions(request, headers, runtime);
  }

  async queryUserExtendValuesWithOptions(request: QueryUserExtendValuesRequest, headers: QueryUserExtendValuesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserExtendValuesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    if (!Util.isUnset(request.userExtendKey)) {
      body["userExtendKey"] = request.userExtendKey;
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
    return $tea.cast<QueryUserExtendValuesResponse>(await this.doROARequest("QueryUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/medicals/users/extends/query`, "json", req, runtime), new QueryUserExtendValuesResponse({}));
  }

  async queryDepartmentInfo(deptId: string): Promise<QueryDepartmentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDepartmentInfoHeaders({ });
    return await this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
  }

  async queryDepartmentInfoWithOptions(deptId: string, headers: QueryDepartmentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDepartmentInfoResponse> {
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
    return $tea.cast<QueryDepartmentInfoResponse>(await this.doROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments/${deptId}`, "json", req, runtime), new QueryDepartmentInfoResponse({}));
  }

  async updateUserExtendInfo(userId: string, request: UpdateUserExtendInfoRequest): Promise<UpdateUserExtendInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUserExtendInfoHeaders({ });
    return await this.updateUserExtendInfoWithOptions(userId, request, headers, runtime);
  }

  async updateUserExtendInfoWithOptions(userId: string, request: UpdateUserExtendInfoRequest, headers: UpdateUserExtendInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUserExtendInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobCode)) {
      body["jobCode"] = request.jobCode;
    }

    if (!Util.isUnset(request.userProbCode)) {
      body["userProbCode"] = request.userProbCode;
    }

    if (!Util.isUnset(request.jobStatusCode)) {
      body["jobStatusCode"] = request.jobStatusCode;
    }

    if (!Util.isUnset(request.comments)) {
      body["comments"] = request.comments;
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
    return $tea.cast<UpdateUserExtendInfoResponse>(await this.doROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", `/v1.0/industry/medicals/users/${userId}/extInfos`, "none", req, runtime), new UpdateUserExtendInfoResponse({}));
  }

  async queryUserExtInfo(userId: string): Promise<QueryUserExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserExtInfoHeaders({ });
    return await this.queryUserExtInfoWithOptions(userId, headers, runtime);
  }

  async queryUserExtInfoWithOptions(userId: string, headers: QueryUserExtInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserExtInfoResponse> {
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
    return $tea.cast<QueryUserExtInfoResponse>(await this.doROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/users/${userId}/extInfos`, "json", req, runtime), new QueryUserExtInfoResponse({}));
  }

  async queryJobCodeDictionary(): Promise<QueryJobCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobCodeDictionaryHeaders({ });
    return await this.queryJobCodeDictionaryWithOptions(headers, runtime);
  }

  async queryJobCodeDictionaryWithOptions(headers: QueryJobCodeDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobCodeDictionaryResponse> {
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
    return $tea.cast<QueryJobCodeDictionaryResponse>(await this.doROARequest("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/jobCodes`, "json", req, runtime), new QueryJobCodeDictionaryResponse({}));
  }

  async industryManufactureLabourCost(request: IndustryManufactureLabourCostRequest): Promise<IndustryManufactureLabourCostResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureLabourCostHeaders({ });
    return await this.industryManufactureLabourCostWithOptions(request, headers, runtime);
  }

  async industryManufactureLabourCostWithOptions(request: IndustryManufactureLabourCostRequest, headers: IndustryManufactureLabourCostHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureLabourCostResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processNo)) {
      body["processNo"] = request.processNo;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
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
    return $tea.cast<IndustryManufactureLabourCostResponse>(await this.doROARequest("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/labourCosts/query`, "json", req, runtime), new IndustryManufactureLabourCostResponse({}));
  }

  async queryHospitalDistrictInfo(request: QueryHospitalDistrictInfoRequest): Promise<QueryHospitalDistrictInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalDistrictInfoHeaders({ });
    return await this.queryHospitalDistrictInfoWithOptions(request, headers, runtime);
  }

  async queryHospitalDistrictInfoWithOptions(request: QueryHospitalDistrictInfoRequest, headers: QueryHospitalDistrictInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHospitalDistrictInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryHospitalDistrictInfoResponse>(await this.doROARequest("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/districts`, "json", req, runtime), new QueryHospitalDistrictInfoResponse({}));
  }

  async industryManufactureCostRecordListGet(request: IndustryManufactureCostRecordListGetRequest): Promise<IndustryManufactureCostRecordListGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureCostRecordListGetHeaders({ });
    return await this.industryManufactureCostRecordListGetWithOptions(request, headers, runtime);
  }

  async industryManufactureCostRecordListGetWithOptions(request: IndustryManufactureCostRecordListGetRequest, headers: IndustryManufactureCostRecordListGetHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureCostRecordListGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.productionTaskNo)) {
      body["productionTaskNo"] = request.productionTaskNo;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
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
    return $tea.cast<IndustryManufactureCostRecordListGetResponse>(await this.doROARequest("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/materialCostRecords/query`, "json", req, runtime), new IndustryManufactureCostRecordListGetResponse({}));
  }

  async queryAllMemberByGroup(groupId: string, request: QueryAllMemberByGroupRequest): Promise<QueryAllMemberByGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllMemberByGroupHeaders({ });
    return await this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
  }

  async queryAllMemberByGroupWithOptions(groupId: string, request: QueryAllMemberByGroupRequest, headers: QueryAllMemberByGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllMemberByGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllMemberByGroupResponse>(await this.doROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups/${groupId}/members`, "json", req, runtime), new QueryAllMemberByGroupResponse({}));
  }

  async queryHospitalRoles(): Promise<QueryHospitalRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalRolesHeaders({ });
    return await this.queryHospitalRolesWithOptions(headers, runtime);
  }

  async queryHospitalRolesWithOptions(headers: QueryHospitalRolesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHospitalRolesResponse> {
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
    return $tea.cast<QueryHospitalRolesResponse>(await this.doROARequest("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/roles`, "json", req, runtime), new QueryHospitalRolesResponse({}));
  }

  async queryBizOptLog(request: QueryBizOptLogRequest): Promise<QueryBizOptLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBizOptLogHeaders({ });
    return await this.queryBizOptLogWithOptions(request, headers, runtime);
  }

  async queryBizOptLogWithOptions(request: QueryBizOptLogRequest, headers: QueryBizOptLogHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBizOptLogResponse> {
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
    return $tea.cast<QueryBizOptLogResponse>(await this.doROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/bizOptLogs`, "json", req, runtime), new QueryBizOptLogResponse({}));
  }

  async queryHospitalRoleUserInfo(request: QueryHospitalRoleUserInfoRequest): Promise<QueryHospitalRoleUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHospitalRoleUserInfoHeaders({ });
    return await this.queryHospitalRoleUserInfoWithOptions(request, headers, runtime);
  }

  async queryHospitalRoleUserInfoWithOptions(request: QueryHospitalRoleUserInfoRequest, headers: QueryHospitalRoleUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHospitalRoleUserInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryHospitalRoleUserInfoResponse>(await this.doROARequest("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/roles/userInfos`, "json", req, runtime), new QueryHospitalRoleUserInfoResponse({}));
  }

  async queryUserProbCodeDictionary(): Promise<QueryUserProbCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserProbCodeDictionaryHeaders({ });
    return await this.queryUserProbCodeDictionaryWithOptions(headers, runtime);
  }

  async queryUserProbCodeDictionaryWithOptions(headers: QueryUserProbCodeDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserProbCodeDictionaryResponse> {
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
    return $tea.cast<QueryUserProbCodeDictionaryResponse>(await this.doROARequest("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/userProbCodes`, "json", req, runtime), new QueryUserProbCodeDictionaryResponse({}));
  }

  async queryJobStatusCodeDictionary(): Promise<QueryJobStatusCodeDictionaryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobStatusCodeDictionaryHeaders({ });
    return await this.queryJobStatusCodeDictionaryWithOptions(headers, runtime);
  }

  async queryJobStatusCodeDictionaryWithOptions(headers: QueryJobStatusCodeDictionaryHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobStatusCodeDictionaryResponse> {
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
    return $tea.cast<QueryJobStatusCodeDictionaryResponse>(await this.doROARequest("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/jobStatusCodes`, "json", req, runtime), new QueryJobStatusCodeDictionaryResponse({}));
  }

  async queryMedicalEvents(): Promise<QueryMedicalEventsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMedicalEventsHeaders({ });
    return await this.queryMedicalEventsWithOptions(headers, runtime);
  }

  async queryMedicalEventsWithOptions(headers: QueryMedicalEventsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMedicalEventsResponse> {
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
    return $tea.cast<QueryMedicalEventsResponse>(await this.doROARequest("QueryMedicalEvents", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/events`, "json", req, runtime), new QueryMedicalEventsResponse({}));
  }

  async industryManufactureMaterialList(request: IndustryManufactureMaterialListRequest): Promise<IndustryManufactureMaterialListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureMaterialListHeaders({ });
    return await this.industryManufactureMaterialListWithOptions(request, headers, runtime);
  }

  async industryManufactureMaterialListWithOptions(request: IndustryManufactureMaterialListRequest, headers: IndustryManufactureMaterialListHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureMaterialListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.currentPage)) {
      body["currentPage"] = request.currentPage;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
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
    return $tea.cast<IndustryManufactureMaterialListResponse>(await this.doROARequest("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/materials/query`, "json", req, runtime), new IndustryManufactureMaterialListResponse({}));
  }

  async industryMmanufactureMaterialCostGet(request: IndustryMmanufactureMaterialCostGetRequest): Promise<IndustryMmanufactureMaterialCostGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryMmanufactureMaterialCostGetHeaders({ });
    return await this.industryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
  }

  async industryMmanufactureMaterialCostGetWithOptions(request: IndustryMmanufactureMaterialCostGetRequest, headers: IndustryMmanufactureMaterialCostGetHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryMmanufactureMaterialCostGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
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
    return $tea.cast<IndustryMmanufactureMaterialCostGetResponse>(await this.doROARequest("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/base/materialCosts/query`, "json", req, runtime), new IndustryMmanufactureMaterialCostGetResponse({}));
  }

  async industryManufactureFeeListGet(request: IndustryManufactureFeeListGetRequest): Promise<IndustryManufactureFeeListGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IndustryManufactureFeeListGetHeaders({ });
    return await this.industryManufactureFeeListGetWithOptions(request, headers, runtime);
  }

  async industryManufactureFeeListGetWithOptions(request: IndustryManufactureFeeListGetRequest, headers: IndustryManufactureFeeListGetHeaders, runtime: $Util.RuntimeOptions): Promise<IndustryManufactureFeeListGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.productionTaskNo)) {
      body["productionTaskNo"] = request.productionTaskNo;
    }

    if (!Util.isUnset(request.materialNo)) {
      body["materialNo"] = request.materialNo;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.tokenGrantType)) {
      body["tokenGrantType"] = request.tokenGrantType;
    }

    if (!Util.isUnset(request.orgId)) {
      body["orgId"] = request.orgId;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.isvOrgId)) {
      body["isvOrgId"] = request.isvOrgId;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.microappAgentId)) {
      body["microappAgentId"] = request.microappAgentId;
    }

    if (!Util.isUnset(request.appIds)) {
      body["appIds"] = request.appIds;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.appName)) {
      body["appName"] = request.appName;
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
    return $tea.cast<IndustryManufactureFeeListGetResponse>(await this.doROARequest("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/manufactures/fees/query`, "json", req, runtime), new IndustryManufactureFeeListGetResponse({}));
  }

  async queryAllDoctors(request: QueryAllDoctorsRequest): Promise<QueryAllDoctorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDoctorsHeaders({ });
    return await this.queryAllDoctorsWithOptions(request, headers, runtime);
  }

  async queryAllDoctorsWithOptions(request: QueryAllDoctorsRequest, headers: QueryAllDoctorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllDoctorsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNum)) {
      query["pageNum"] = request.pageNum;
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
    return $tea.cast<QueryAllDoctorsResponse>(await this.doROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/doctors`, "json", req, runtime), new QueryAllDoctorsResponse({}));
  }

  async queryAllDepartment(request: QueryAllDepartmentRequest): Promise<QueryAllDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAllDepartmentHeaders({ });
    return await this.queryAllDepartmentWithOptions(request, headers, runtime);
  }

  async queryAllDepartmentWithOptions(request: QueryAllDepartmentRequest, headers: QueryAllDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAllDepartmentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
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
    return $tea.cast<QueryAllDepartmentResponse>(await this.doROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/departments`, "json", req, runtime), new QueryAllDepartmentResponse({}));
  }

  async queryGroupInfo(groupId: string): Promise<QueryGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupInfoHeaders({ });
    return await this.queryGroupInfoWithOptions(groupId, headers, runtime);
  }

  async queryGroupInfoWithOptions(groupId: string, headers: QueryGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupInfoResponse> {
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
    return $tea.cast<QueryGroupInfoResponse>(await this.doROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", `/v1.0/industry/medicals/groups/${groupId}`, "json", req, runtime), new QueryGroupInfoResponse({}));
  }

  async saveUserExtendValues(userId: string, request: SaveUserExtendValuesRequest): Promise<SaveUserExtendValuesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveUserExtendValuesHeaders({ });
    return await this.saveUserExtendValuesWithOptions(userId, request, headers, runtime);
  }

  async saveUserExtendValuesWithOptions(userId: string, request: SaveUserExtendValuesRequest, headers: SaveUserExtendValuesHeaders, runtime: $Util.RuntimeOptions): Promise<SaveUserExtendValuesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userExtendKey)) {
      query["userExtendKey"] = request.userExtendKey;
    }

    if (!Util.isUnset(request.userExtendValue)) {
      query["userExtendValue"] = request.userExtendValue;
    }

    if (!Util.isUnset(request.userDisplayName)) {
      query["userDisplayName"] = request.userDisplayName;
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
    return $tea.cast<SaveUserExtendValuesResponse>(await this.doROARequest("SaveUserExtendValues", "industry_1.0", "HTTP", "POST", "AK", `/v1.0/industry/medicals/users/${userId}/extends`, "json", req, runtime), new SaveUserExtendValuesResponse({}));
  }

}
