// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class SortUserHeaders extends $tea.Model {
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

export class SortUserRequest extends $tea.Model {
  dingOrgId?: number;
  userIdList?: string[];
  sortType?: number;
  static names(): { [key: string]: string } {
    return {
      dingOrgId: 'dingOrgId',
      userIdList: 'userIdList',
      sortType: 'sortType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOrgId: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
      sortType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SortUserResponseBody extends $tea.Model {
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

export class SortUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SortUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SortUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactHideSettingsHeaders extends $tea.Model {
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

export class ListContactHideSettingsRequest extends $tea.Model {
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

export class ListContactHideSettingsResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  list?: ListContactHideSettingsResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      list: { 'type': 'array', 'itemType': ListContactHideSettingsResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListContactHideSettingsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListContactHideSettingsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListContactHideSettingsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideSettingHeaders extends $tea.Model {
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

export class UpdateContactHideSettingRequest extends $tea.Model {
  name?: string;
  description?: string;
  objectStaffIds?: string[];
  objectDeptIds?: number[];
  objectTagIds?: number[];
  excludeStaffIds?: string[];
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  active?: boolean;
  id?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      description: 'description',
      objectStaffIds: 'objectStaffIds',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      excludeStaffIds: 'excludeStaffIds',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      active: 'active',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      description: 'string',
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      active: 'boolean',
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideSettingResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateContactHideSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateContactHideSettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateContactHideSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttrbuteVisibilitySettingHeaders extends $tea.Model {
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

export class UpdateEmpAttrbuteVisibilitySettingRequest extends $tea.Model {
  id?: number;
  name?: string;
  description?: string;
  objectStaffIds?: string[];
  objectDeptIds?: number[];
  objectTagIds?: number[];
  hideFields?: string[];
  excludeStaffIds?: string[];
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      description: 'description',
      objectStaffIds: 'objectStaffIds',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      hideFields: 'hideFields',
      excludeStaffIds: 'excludeStaffIds',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      description: 'string',
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      hideFields: { 'type': 'array', 'itemType': 'string' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      active: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttrbuteVisibilitySettingResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateEmpAttrbuteVisibilitySettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateEmpAttrbuteVisibilitySettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateEmpAttrbuteVisibilitySettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteEmpAttributeVisibilityHeaders extends $tea.Model {
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

export class DeleteEmpAttributeVisibilityResponse extends $tea.Model {
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

export class SearchDepartmentHeaders extends $tea.Model {
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

export class SearchDepartmentRequest extends $tea.Model {
  dingOrgId?: number;
  queryWord?: string;
  offset?: number;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      dingOrgId: 'dingOrgId',
      queryWord: 'queryWord',
      offset: 'offset',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOrgId: 'number',
      queryWord: 'string',
      offset: 'number',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDepartmentResponseBody extends $tea.Model {
  hasMore?: boolean;
  totalCount?: number;
  list?: number[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      totalCount: 'totalCount',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      totalCount: 'number',
      list: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchDepartmentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchDepartmentResponseBody,
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

export class ListSeniorSettingsHeaders extends $tea.Model {
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

export class ListSeniorSettingsRequest extends $tea.Model {
  seniorStaffId?: string;
  static names(): { [key: string]: string } {
    return {
      seniorStaffId: 'seniorStaffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      seniorStaffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSeniorSettingsResponseBody extends $tea.Model {
  seniorStaffId?: string;
  protectScenes?: string[];
  seniorWhiteList?: ListSeniorSettingsResponseBodySeniorWhiteList[];
  static names(): { [key: string]: string } {
    return {
      seniorStaffId: 'seniorStaffId',
      protectScenes: 'protectScenes',
      seniorWhiteList: 'seniorWhiteList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      seniorStaffId: 'string',
      protectScenes: { 'type': 'array', 'itemType': 'string' },
      seniorWhiteList: { 'type': 'array', 'itemType': ListSeniorSettingsResponseBodySeniorWhiteList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSeniorSettingsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSeniorSettingsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSeniorSettingsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityHeaders extends $tea.Model {
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

export class ListEmpAttributeVisibilityRequest extends $tea.Model {
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

export class ListEmpAttributeVisibilityResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextCursor?: number;
  list?: ListEmpAttributeVisibilityResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextCursor: 'nextCursor',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextCursor: 'number',
      list: { 'type': 'array', 'itemType': ListEmpAttributeVisibilityResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListEmpAttributeVisibilityResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListEmpAttributeVisibilityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserHeaders extends $tea.Model {
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

export class SearchUserRequest extends $tea.Model {
  dingOrgId?: number;
  queryWord?: string;
  offset?: number;
  size?: number;
  static names(): { [key: string]: string } {
    return {
      dingOrgId: 'dingOrgId',
      queryWord: 'queryWord',
      offset: 'offset',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOrgId: 'number',
      queryWord: 'string',
      offset: 'number',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserResponseBody extends $tea.Model {
  hasMore?: boolean;
  totalCount?: number;
  list?: string[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      totalCount: 'totalCount',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      totalCount: 'number',
      list: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranslateFileJobResultHeaders extends $tea.Model {
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

export class GetTranslateFileJobResultRequest extends $tea.Model {
  jobId?: string;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranslateFileJobResultResponseBody extends $tea.Model {
  status?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTranslateFileJobResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTranslateFileJobResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTranslateFileJobResultResponseBody,
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

export class DeleteContactHideSettingHeaders extends $tea.Model {
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

export class DeleteContactHideSettingResponse extends $tea.Model {
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

export class UpdateUserOwnnessHeaders extends $tea.Model {
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

export class UpdateUserOwnnessRequest extends $tea.Model {
  ownenssType?: number;
  id?: number;
  startTime?: number;
  endTime?: number;
  deletedFlag?: number;
  static names(): { [key: string]: string } {
    return {
      ownenssType: 'ownenssType',
      id: 'id',
      startTime: 'startTime',
      endTime: 'endTime',
      deletedFlag: 'deletedFlag',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownenssType: 'number',
      id: 'number',
      startTime: 'number',
      endTime: 'number',
      deletedFlag: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserOwnnessResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUserOwnnessResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateUserOwnnessResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateUserOwnnessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationUnionIdByUnionIdHeaders extends $tea.Model {
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

export class GetMigrationUnionIdByUnionIdRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationUnionIdByUnionIdResponseBody extends $tea.Model {
  migrationUnionIdList?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      migrationUnionIdList: 'migrationUnionIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationUnionIdList: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationUnionIdByUnionIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMigrationUnionIdByUnionIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMigrationUnionIdByUnionIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingIdByMigrationDingIdHeaders extends $tea.Model {
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

export class GetDingIdByMigrationDingIdRequest extends $tea.Model {
  migrationDingId?: string;
  static names(): { [key: string]: string } {
    return {
      migrationDingId: 'migrationDingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationDingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingIdByMigrationDingIdResponseBody extends $tea.Model {
  dingId?: string;
  static names(): { [key: string]: string } {
    return {
      dingId: 'dingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingIdByMigrationDingIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetDingIdByMigrationDingIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetDingIdByMigrationDingIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCooperateOrgInviteInfoHeaders extends $tea.Model {
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

export class GetCooperateOrgInviteInfoResponseBody extends $tea.Model {
  inviteUrl?: string;
  static names(): { [key: string]: string } {
    return {
      inviteUrl: 'inviteUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCooperateOrgInviteInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCooperateOrgInviteInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCooperateOrgInviteInfoResponseBody,
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

export class TranslateFileHeaders extends $tea.Model {
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

export class TranslateFileRequest extends $tea.Model {
  dingTokenGrantType?: number;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  medias?: { [key: string]: string };
  outputFileName?: string;
  unionId?: string;
  requestId?: string;
  eagleEyeTraceId?: string;
  static names(): { [key: string]: string } {
    return {
      dingTokenGrantType: 'dingTokenGrantType',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      medias: 'medias',
      outputFileName: 'outputFileName',
      unionId: 'unionId',
      requestId: 'RequestId',
      eagleEyeTraceId: 'eagleEyeTraceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingTokenGrantType: 'number',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      medias: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      outputFileName: 'string',
      unionId: 'string',
      requestId: 'string',
      eagleEyeTraceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TranslateFileResponseBody extends $tea.Model {
  jobId?: string;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TranslateFileResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: TranslateFileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TranslateFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSeniorSettingHeaders extends $tea.Model {
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

export class UpdateSeniorSettingRequest extends $tea.Model {
  seniorStaffId?: string;
  open?: boolean;
  permitStaffIds?: string[];
  permitDeptIds?: number[];
  permitTagIds?: number[];
  protectScenes?: string[];
  static names(): { [key: string]: string } {
    return {
      seniorStaffId: 'seniorStaffId',
      open: 'open',
      permitStaffIds: 'permitStaffIds',
      permitDeptIds: 'permitDeptIds',
      permitTagIds: 'permitTagIds',
      protectScenes: 'protectScenes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      seniorStaffId: 'string',
      open: 'boolean',
      permitStaffIds: { 'type': 'array', 'itemType': 'string' },
      permitDeptIds: { 'type': 'array', 'itemType': 'number' },
      permitTagIds: { 'type': 'array', 'itemType': 'number' },
      protectScenes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSeniorSettingResponse extends $tea.Model {
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

export class CreateCooperateOrgHeaders extends $tea.Model {
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

export class CreateCooperateOrgRequest extends $tea.Model {
  orgName?: string;
  logoMediaId?: string;
  industryCode?: number;
  static names(): { [key: string]: string } {
    return {
      orgName: 'orgName',
      logoMediaId: 'logoMediaId',
      industryCode: 'industryCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgName: 'string',
      logoMediaId: 'string',
      industryCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCooperateOrgResponseBody extends $tea.Model {
  cooperateCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      cooperateCorpId: 'cooperateCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cooperateCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCooperateOrgResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCooperateOrgResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateCooperateOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationDingIdByDingIdHeaders extends $tea.Model {
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

export class GetMigrationDingIdByDingIdRequest extends $tea.Model {
  dingId?: string;
  static names(): { [key: string]: string } {
    return {
      dingId: 'dingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationDingIdByDingIdResponseBody extends $tea.Model {
  migrationDingIdList?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      migrationDingIdList: 'migrationDingIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationDingIdList: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMigrationDingIdByDingIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMigrationDingIdByDingIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMigrationDingIdByDingIdResponseBody,
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

export class TransformToExclusiveAccountHeaders extends $tea.Model {
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

export class TransformToExclusiveAccountRequest extends $tea.Model {
  transformType?: string;
  idpDingTalk?: boolean;
  loginId?: string;
  initPassword?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      transformType: 'transformType',
      idpDingTalk: 'idpDingTalk',
      loginId: 'loginId',
      initPassword: 'initPassword',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      transformType: 'string',
      idpDingTalk: 'boolean',
      loginId: 'string',
      initPassword: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransformToExclusiveAccountResponse extends $tea.Model {
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

export class GetUnionIdByMigrationUnionIdHeaders extends $tea.Model {
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

export class GetUnionIdByMigrationUnionIdRequest extends $tea.Model {
  migrationUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      migrationUnionId: 'migrationUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      migrationUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUnionIdByMigrationUnionIdResponseBody extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUnionIdByMigrationUnionIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUnionIdByMigrationUnionIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUnionIdByMigrationUnionIdResponseBody,
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

export class ListContactHideSettingsResponseBodyList extends $tea.Model {
  name?: string;
  description?: string;
  objectStaffIds?: string[];
  objectDeptIds?: number[];
  objectTagIds?: number[];
  excludeStaffIds?: string[];
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  active?: boolean;
  id?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      description: 'description',
      objectStaffIds: 'objectStaffIds',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      excludeStaffIds: 'excludeStaffIds',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      active: 'active',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      description: 'string',
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      active: 'boolean',
      id: 'number',
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

export class ListSeniorSettingsResponseBodySeniorWhiteList extends $tea.Model {
  id?: string;
  type?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      type: 'type',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      type: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListEmpAttributeVisibilityResponseBodyList extends $tea.Model {
  id?: number;
  gmtCreate?: string;
  gmtModified?: string;
  name?: string;
  description?: string;
  objectStaffIds?: string[];
  objectDeptIds?: number[];
  objectTagIds?: number[];
  hideFields?: string[];
  excludeStaffIds?: string[];
  excludeDeptIds?: number[];
  excludeTagIds?: number[];
  active?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      name: 'name',
      description: 'description',
      objectStaffIds: 'objectStaffIds',
      objectDeptIds: 'objectDeptIds',
      objectTagIds: 'objectTagIds',
      hideFields: 'hideFields',
      excludeStaffIds: 'excludeStaffIds',
      excludeDeptIds: 'excludeDeptIds',
      excludeTagIds: 'excludeTagIds',
      active: 'active',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      gmtCreate: 'string',
      gmtModified: 'string',
      name: 'string',
      description: 'string',
      objectStaffIds: { 'type': 'array', 'itemType': 'string' },
      objectDeptIds: { 'type': 'array', 'itemType': 'number' },
      objectTagIds: { 'type': 'array', 'itemType': 'number' },
      hideFields: { 'type': 'array', 'itemType': 'string' },
      excludeStaffIds: { 'type': 'array', 'itemType': 'string' },
      excludeDeptIds: { 'type': 'array', 'itemType': 'number' },
      excludeTagIds: { 'type': 'array', 'itemType': 'number' },
      active: 'boolean',
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async sortUser(request: SortUserRequest): Promise<SortUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SortUserHeaders({ });
    return await this.sortUserWithOptions(request, headers, runtime);
  }

  async sortUserWithOptions(request: SortUserRequest, headers: SortUserHeaders, runtime: $Util.RuntimeOptions): Promise<SortUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
    }

    if (!Util.isUnset(request.sortType)) {
      body["sortType"] = request.sortType;
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
    return $tea.cast<SortUserResponse>(await this.doROARequest("SortUser", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/users/sort`, "json", req, runtime), new SortUserResponse({}));
  }

  async listContactHideSettings(request: ListContactHideSettingsRequest): Promise<ListContactHideSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListContactHideSettingsHeaders({ });
    return await this.listContactHideSettingsWithOptions(request, headers, runtime);
  }

  async listContactHideSettingsWithOptions(request: ListContactHideSettingsRequest, headers: ListContactHideSettingsHeaders, runtime: $Util.RuntimeOptions): Promise<ListContactHideSettingsResponse> {
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
    return $tea.cast<ListContactHideSettingsResponse>(await this.doROARequest("ListContactHideSettings", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/contactHideSettings`, "json", req, runtime), new ListContactHideSettingsResponse({}));
  }

  async updateContactHideSetting(request: UpdateContactHideSettingRequest): Promise<UpdateContactHideSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateContactHideSettingHeaders({ });
    return await this.updateContactHideSettingWithOptions(request, headers, runtime);
  }

  async updateContactHideSettingWithOptions(request: UpdateContactHideSettingRequest, headers: UpdateContactHideSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateContactHideSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.objectStaffIds)) {
      body["objectStaffIds"] = request.objectStaffIds;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

    if (!Util.isUnset(request.excludeStaffIds)) {
      body["excludeStaffIds"] = request.excludeStaffIds;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.active)) {
      body["active"] = request.active;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
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
    return $tea.cast<UpdateContactHideSettingResponse>(await this.doROARequest("UpdateContactHideSetting", "contact_1.0", "HTTP", "PUT", "AK", `/v1.0/contact/contactHideSettings`, "json", req, runtime), new UpdateContactHideSettingResponse({}));
  }

  async updateEmpAttrbuteVisibilitySetting(request: UpdateEmpAttrbuteVisibilitySettingRequest): Promise<UpdateEmpAttrbuteVisibilitySettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateEmpAttrbuteVisibilitySettingHeaders({ });
    return await this.updateEmpAttrbuteVisibilitySettingWithOptions(request, headers, runtime);
  }

  async updateEmpAttrbuteVisibilitySettingWithOptions(request: UpdateEmpAttrbuteVisibilitySettingRequest, headers: UpdateEmpAttrbuteVisibilitySettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateEmpAttrbuteVisibilitySettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.objectStaffIds)) {
      body["objectStaffIds"] = request.objectStaffIds;
    }

    if (!Util.isUnset(request.objectDeptIds)) {
      body["objectDeptIds"] = request.objectDeptIds;
    }

    if (!Util.isUnset(request.objectTagIds)) {
      body["objectTagIds"] = request.objectTagIds;
    }

    if (!Util.isUnset(request.hideFields)) {
      body["hideFields"] = request.hideFields;
    }

    if (!Util.isUnset(request.excludeStaffIds)) {
      body["excludeStaffIds"] = request.excludeStaffIds;
    }

    if (!Util.isUnset(request.excludeDeptIds)) {
      body["excludeDeptIds"] = request.excludeDeptIds;
    }

    if (!Util.isUnset(request.excludeTagIds)) {
      body["excludeTagIds"] = request.excludeTagIds;
    }

    if (!Util.isUnset(request.active)) {
      body["active"] = request.active;
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
    return $tea.cast<UpdateEmpAttrbuteVisibilitySettingResponse>(await this.doROARequest("UpdateEmpAttrbuteVisibilitySetting", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/staffAttributes/visibilitySettings`, "json", req, runtime), new UpdateEmpAttrbuteVisibilitySettingResponse({}));
  }

  async deleteEmpAttributeVisibility(settingId: string): Promise<DeleteEmpAttributeVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteEmpAttributeVisibilityHeaders({ });
    return await this.deleteEmpAttributeVisibilityWithOptions(settingId, headers, runtime);
  }

  async deleteEmpAttributeVisibilityWithOptions(settingId: string, headers: DeleteEmpAttributeVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteEmpAttributeVisibilityResponse> {
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
    return $tea.cast<DeleteEmpAttributeVisibilityResponse>(await this.doROARequest("DeleteEmpAttributeVisibility", "contact_1.0", "HTTP", "DELETE", "AK", `/v1.0/contact/staffAttributes/visibilitySettings/${settingId}`, "none", req, runtime), new DeleteEmpAttributeVisibilityResponse({}));
  }

  async searchDepartment(request: SearchDepartmentRequest): Promise<SearchDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchDepartmentHeaders({ });
    return await this.searchDepartmentWithOptions(request, headers, runtime);
  }

  async searchDepartmentWithOptions(request: SearchDepartmentRequest, headers: SearchDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<SearchDepartmentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.queryWord)) {
      body["queryWord"] = request.queryWord;
    }

    if (!Util.isUnset(request.offset)) {
      body["offset"] = request.offset;
    }

    if (!Util.isUnset(request.size)) {
      body["size"] = request.size;
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
    return $tea.cast<SearchDepartmentResponse>(await this.doROARequest("SearchDepartment", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/departments/search`, "json", req, runtime), new SearchDepartmentResponse({}));
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

  async listSeniorSettings(request: ListSeniorSettingsRequest): Promise<ListSeniorSettingsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSeniorSettingsHeaders({ });
    return await this.listSeniorSettingsWithOptions(request, headers, runtime);
  }

  async listSeniorSettingsWithOptions(request: ListSeniorSettingsRequest, headers: ListSeniorSettingsHeaders, runtime: $Util.RuntimeOptions): Promise<ListSeniorSettingsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.seniorStaffId)) {
      query["seniorStaffId"] = request.seniorStaffId;
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
    return $tea.cast<ListSeniorSettingsResponse>(await this.doROARequest("ListSeniorSettings", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/seniorSettings`, "json", req, runtime), new ListSeniorSettingsResponse({}));
  }

  async listEmpAttributeVisibility(request: ListEmpAttributeVisibilityRequest): Promise<ListEmpAttributeVisibilityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListEmpAttributeVisibilityHeaders({ });
    return await this.listEmpAttributeVisibilityWithOptions(request, headers, runtime);
  }

  async listEmpAttributeVisibilityWithOptions(request: ListEmpAttributeVisibilityRequest, headers: ListEmpAttributeVisibilityHeaders, runtime: $Util.RuntimeOptions): Promise<ListEmpAttributeVisibilityResponse> {
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
    return $tea.cast<ListEmpAttributeVisibilityResponse>(await this.doROARequest("ListEmpAttributeVisibility", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/staffAttributes/visibilitySettings`, "json", req, runtime), new ListEmpAttributeVisibilityResponse({}));
  }

  async searchUser(request: SearchUserRequest): Promise<SearchUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchUserHeaders({ });
    return await this.searchUserWithOptions(request, headers, runtime);
  }

  async searchUserWithOptions(request: SearchUserRequest, headers: SearchUserHeaders, runtime: $Util.RuntimeOptions): Promise<SearchUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.queryWord)) {
      body["queryWord"] = request.queryWord;
    }

    if (!Util.isUnset(request.offset)) {
      body["offset"] = request.offset;
    }

    if (!Util.isUnset(request.size)) {
      body["size"] = request.size;
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
    return $tea.cast<SearchUserResponse>(await this.doROARequest("SearchUser", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/users/search`, "json", req, runtime), new SearchUserResponse({}));
  }

  async getTranslateFileJobResult(request: GetTranslateFileJobResultRequest): Promise<GetTranslateFileJobResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTranslateFileJobResultHeaders({ });
    return await this.getTranslateFileJobResultWithOptions(request, headers, runtime);
  }

  async getTranslateFileJobResultWithOptions(request: GetTranslateFileJobResultRequest, headers: GetTranslateFileJobResultHeaders, runtime: $Util.RuntimeOptions): Promise<GetTranslateFileJobResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobId)) {
      query["jobId"] = request.jobId;
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
    return $tea.cast<GetTranslateFileJobResultResponse>(await this.doROARequest("GetTranslateFileJobResult", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/files/translateResults`, "json", req, runtime), new GetTranslateFileJobResultResponse({}));
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

  async deleteContactHideSetting(settingId: string): Promise<DeleteContactHideSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteContactHideSettingHeaders({ });
    return await this.deleteContactHideSettingWithOptions(settingId, headers, runtime);
  }

  async deleteContactHideSettingWithOptions(settingId: string, headers: DeleteContactHideSettingHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteContactHideSettingResponse> {
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
    return $tea.cast<DeleteContactHideSettingResponse>(await this.doROARequest("DeleteContactHideSetting", "contact_1.0", "HTTP", "DELETE", "AK", `/v1.0/contact/contactHideSettings/${settingId}`, "none", req, runtime), new DeleteContactHideSettingResponse({}));
  }

  async updateUserOwnness(userId: string, request: UpdateUserOwnnessRequest): Promise<UpdateUserOwnnessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUserOwnnessHeaders({ });
    return await this.updateUserOwnnessWithOptions(userId, request, headers, runtime);
  }

  async updateUserOwnnessWithOptions(userId: string, request: UpdateUserOwnnessRequest, headers: UpdateUserOwnnessHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUserOwnnessResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ownenssType)) {
      body["ownenssType"] = request.ownenssType;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.deletedFlag)) {
      body["deletedFlag"] = request.deletedFlag;
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
    return $tea.cast<UpdateUserOwnnessResponse>(await this.doROARequest("UpdateUserOwnness", "contact_1.0", "HTTP", "PUT", "AK", `/v1.0/contact/user/${userId}/ownness`, "json", req, runtime), new UpdateUserOwnnessResponse({}));
  }

  async getMigrationUnionIdByUnionId(request: GetMigrationUnionIdByUnionIdRequest): Promise<GetMigrationUnionIdByUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMigrationUnionIdByUnionIdHeaders({ });
    return await this.getMigrationUnionIdByUnionIdWithOptions(request, headers, runtime);
  }

  async getMigrationUnionIdByUnionIdWithOptions(request: GetMigrationUnionIdByUnionIdRequest, headers: GetMigrationUnionIdByUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetMigrationUnionIdByUnionIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<GetMigrationUnionIdByUnionIdResponse>(await this.doROARequest("GetMigrationUnionIdByUnionId", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds`, "json", req, runtime), new GetMigrationUnionIdByUnionIdResponse({}));
  }

  async getDingIdByMigrationDingId(request: GetDingIdByMigrationDingIdRequest): Promise<GetDingIdByMigrationDingIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingIdByMigrationDingIdHeaders({ });
    return await this.getDingIdByMigrationDingIdWithOptions(request, headers, runtime);
  }

  async getDingIdByMigrationDingIdWithOptions(request: GetDingIdByMigrationDingIdRequest, headers: GetDingIdByMigrationDingIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingIdByMigrationDingIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.migrationDingId)) {
      query["migrationDingId"] = request.migrationDingId;
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
    return $tea.cast<GetDingIdByMigrationDingIdResponse>(await this.doROARequest("GetDingIdByMigrationDingId", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/orgAccount/getDingIdByMigrationDingIds`, "json", req, runtime), new GetDingIdByMigrationDingIdResponse({}));
  }

  async getCooperateOrgInviteInfo(cooperateCorpId: string): Promise<GetCooperateOrgInviteInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCooperateOrgInviteInfoHeaders({ });
    return await this.getCooperateOrgInviteInfoWithOptions(cooperateCorpId, headers, runtime);
  }

  async getCooperateOrgInviteInfoWithOptions(cooperateCorpId: string, headers: GetCooperateOrgInviteInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetCooperateOrgInviteInfoResponse> {
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
    return $tea.cast<GetCooperateOrgInviteInfoResponse>(await this.doROARequest("GetCooperateOrgInviteInfo", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/cooperateCorps/${cooperateCorpId}/inviteInfos`, "json", req, runtime), new GetCooperateOrgInviteInfoResponse({}));
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

  async translateFile(request: TranslateFileRequest): Promise<TranslateFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TranslateFileHeaders({ });
    return await this.translateFileWithOptions(request, headers, runtime);
  }

  async translateFileWithOptions(request: TranslateFileRequest, headers: TranslateFileHeaders, runtime: $Util.RuntimeOptions): Promise<TranslateFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.medias)) {
      body["medias"] = request.medias;
    }

    if (!Util.isUnset(request.outputFileName)) {
      body["outputFileName"] = request.outputFileName;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

    if (!Util.isUnset(request.requestId)) {
      body["RequestId"] = request.requestId;
    }

    if (!Util.isUnset(request.eagleEyeTraceId)) {
      body["eagleEyeTraceId"] = request.eagleEyeTraceId;
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
    return $tea.cast<TranslateFileResponse>(await this.doROARequest("TranslateFile", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/files/translate`, "json", req, runtime), new TranslateFileResponse({}));
  }

  async updateSeniorSetting(request: UpdateSeniorSettingRequest): Promise<UpdateSeniorSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSeniorSettingHeaders({ });
    return await this.updateSeniorSettingWithOptions(request, headers, runtime);
  }

  async updateSeniorSettingWithOptions(request: UpdateSeniorSettingRequest, headers: UpdateSeniorSettingHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSeniorSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.seniorStaffId)) {
      body["seniorStaffId"] = request.seniorStaffId;
    }

    if (!Util.isUnset(request.open)) {
      body["open"] = request.open;
    }

    if (!Util.isUnset(request.permitStaffIds)) {
      body["permitStaffIds"] = request.permitStaffIds;
    }

    if (!Util.isUnset(request.permitDeptIds)) {
      body["permitDeptIds"] = request.permitDeptIds;
    }

    if (!Util.isUnset(request.permitTagIds)) {
      body["permitTagIds"] = request.permitTagIds;
    }

    if (!Util.isUnset(request.protectScenes)) {
      body["protectScenes"] = request.protectScenes;
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
    return $tea.cast<UpdateSeniorSettingResponse>(await this.doROARequest("UpdateSeniorSetting", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/seniorSettings`, "none", req, runtime), new UpdateSeniorSettingResponse({}));
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

  async createCooperateOrg(request: CreateCooperateOrgRequest): Promise<CreateCooperateOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCooperateOrgHeaders({ });
    return await this.createCooperateOrgWithOptions(request, headers, runtime);
  }

  async createCooperateOrgWithOptions(request: CreateCooperateOrgRequest, headers: CreateCooperateOrgHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCooperateOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.orgName)) {
      body["orgName"] = request.orgName;
    }

    if (!Util.isUnset(request.logoMediaId)) {
      body["logoMediaId"] = request.logoMediaId;
    }

    if (!Util.isUnset(request.industryCode)) {
      body["industryCode"] = request.industryCode;
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
    return $tea.cast<CreateCooperateOrgResponse>(await this.doROARequest("CreateCooperateOrg", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/cooperateCorps`, "json", req, runtime), new CreateCooperateOrgResponse({}));
  }

  async getMigrationDingIdByDingId(request: GetMigrationDingIdByDingIdRequest): Promise<GetMigrationDingIdByDingIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMigrationDingIdByDingIdHeaders({ });
    return await this.getMigrationDingIdByDingIdWithOptions(request, headers, runtime);
  }

  async getMigrationDingIdByDingIdWithOptions(request: GetMigrationDingIdByDingIdRequest, headers: GetMigrationDingIdByDingIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetMigrationDingIdByDingIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingId)) {
      query["dingId"] = request.dingId;
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
    return $tea.cast<GetMigrationDingIdByDingIdResponse>(await this.doROARequest("GetMigrationDingIdByDingId", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/orgAccount/getMigrationDingIdByDingIds`, "json", req, runtime), new GetMigrationDingIdByDingIdResponse({}));
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

  async transformToExclusiveAccount(request: TransformToExclusiveAccountRequest): Promise<TransformToExclusiveAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransformToExclusiveAccountHeaders({ });
    return await this.transformToExclusiveAccountWithOptions(request, headers, runtime);
  }

  async transformToExclusiveAccountWithOptions(request: TransformToExclusiveAccountRequest, headers: TransformToExclusiveAccountHeaders, runtime: $Util.RuntimeOptions): Promise<TransformToExclusiveAccountResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.transformType)) {
      body["transformType"] = request.transformType;
    }

    if (!Util.isUnset(request.idpDingTalk)) {
      body["idpDingTalk"] = request.idpDingTalk;
    }

    if (!Util.isUnset(request.loginId)) {
      body["loginId"] = request.loginId;
    }

    if (!Util.isUnset(request.initPassword)) {
      body["initPassword"] = request.initPassword;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<TransformToExclusiveAccountResponse>(await this.doROARequest("TransformToExclusiveAccount", "contact_1.0", "HTTP", "POST", "AK", `/v1.0/contact/orgAccount/transformToExclusiveAccounts`, "none", req, runtime), new TransformToExclusiveAccountResponse({}));
  }

  async getUnionIdByMigrationUnionId(request: GetUnionIdByMigrationUnionIdRequest): Promise<GetUnionIdByMigrationUnionIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUnionIdByMigrationUnionIdHeaders({ });
    return await this.getUnionIdByMigrationUnionIdWithOptions(request, headers, runtime);
  }

  async getUnionIdByMigrationUnionIdWithOptions(request: GetUnionIdByMigrationUnionIdRequest, headers: GetUnionIdByMigrationUnionIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetUnionIdByMigrationUnionIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.migrationUnionId)) {
      query["migrationUnionId"] = request.migrationUnionId;
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
    return $tea.cast<GetUnionIdByMigrationUnionIdResponse>(await this.doROARequest("GetUnionIdByMigrationUnionId", "contact_1.0", "HTTP", "GET", "AK", `/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds`, "json", req, runtime), new GetUnionIdByMigrationUnionIdResponse({}));
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

}
