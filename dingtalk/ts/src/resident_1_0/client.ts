// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetPropertyInfoHeaders extends $tea.Model {
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

export class GetPropertyInfoRequest extends $tea.Model {
  propertyCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      propertyCorpId: 'propertyCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      propertyCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPropertyInfoResponseBody extends $tea.Model {
  name?: string;
  orgId?: number;
  adminName?: string;
  adminUserId?: string;
  unifiedSocialCredit?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      orgId: 'orgId',
      adminName: 'adminName',
      adminUserId: 'adminUserId',
      unifiedSocialCredit: 'unifiedSocialCredit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      orgId: 'number',
      adminName: 'string',
      adminUserId: 'string',
      unifiedSocialCredit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPropertyInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPropertyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPropertyInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceIdByTypeHeaders extends $tea.Model {
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

export class GetSpaceIdByTypeRequest extends $tea.Model {
  departmentType?: string;
  static names(): { [key: string]: string } {
    return {
      departmentType: 'departmentType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceIdByTypeResponseBody extends $tea.Model {
  referId?: number;
  static names(): { [key: string]: string } {
    return {
      referId: 'referId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      referId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceIdByTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSpaceIdByTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSpaceIdByTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdHeaders extends $tea.Model {
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

export class GetConversationIdRequest extends $tea.Model {
  chatId?: string;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdResponseBody extends $tea.Model {
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetConversationIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetConversationIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubSpaceHeaders extends $tea.Model {
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

export class ListSubSpaceRequest extends $tea.Model {
  residentCorpId?: string;
  referId?: number;
  static names(): { [key: string]: string } {
    return {
      residentCorpId: 'residentCorpId',
      referId: 'referId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentCorpId: 'string',
      referId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubSpaceResponseBody extends $tea.Model {
  spaceList?: ListSubSpaceResponseBodySpaceList[];
  static names(): { [key: string]: string } {
    return {
      spaceList: 'spaceList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceList: { 'type': 'array', 'itemType': ListSubSpaceResponseBodySpaceList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSubSpaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSubSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResideceGroupHeaders extends $tea.Model {
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

export class UpdateResideceGroupRequest extends $tea.Model {
  managerUserId?: string;
  departmentName?: string;
  departmentId?: number;
  static names(): { [key: string]: string } {
    return {
      managerUserId: 'managerUserId',
      departmentName: 'departmentName',
      departmentId: 'departmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      managerUserId: 'string',
      departmentName: 'string',
      departmentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResideceGroupResponseBody extends $tea.Model {
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

export class UpdateResideceGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateResideceGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateResideceGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentInfoHeaders extends $tea.Model {
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

export class GetResidentInfoRequest extends $tea.Model {
  residentCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      residentCorpId: 'residentCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentInfoResponseBody extends $tea.Model {
  type?: number;
  location?: string;
  address?: string;
  provId?: number;
  buildingArea?: number;
  name?: string;
  telephone?: string;
  deliveryTime?: number;
  contactMode?: number;
  scopeEast?: string;
  scopeWest?: string;
  scopeSouth?: string;
  scopeNorth?: string;
  cityId?: number;
  countyId?: number;
  townId?: number;
  projectManager?: GetResidentInfoResponseBodyProjectManager;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      location: 'location',
      address: 'address',
      provId: 'provId',
      buildingArea: 'buildingArea',
      name: 'name',
      telephone: 'telephone',
      deliveryTime: 'deliveryTime',
      contactMode: 'contactMode',
      scopeEast: 'scopeEast',
      scopeWest: 'scopeWest',
      scopeSouth: 'scopeSouth',
      scopeNorth: 'scopeNorth',
      cityId: 'cityId',
      countyId: 'countyId',
      townId: 'townId',
      projectManager: 'projectManager',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'number',
      location: 'string',
      address: 'string',
      provId: 'number',
      buildingArea: 'number',
      name: 'string',
      telephone: 'string',
      deliveryTime: 'number',
      contactMode: 'number',
      scopeEast: 'string',
      scopeWest: 'string',
      scopeSouth: 'string',
      scopeNorth: 'string',
      cityId: 'number',
      countyId: 'number',
      townId: 'number',
      projectManager: GetResidentInfoResponseBodyProjectManager,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetResidentInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetResidentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResidentHeaders extends $tea.Model {
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

export class SearchResidentRequest extends $tea.Model {
  residentCropId?: string;
  searchWord?: string;
  static names(): { [key: string]: string } {
    return {
      residentCropId: 'residentCropId',
      searchWord: 'searchWord',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentCropId: 'string',
      searchWord: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResidentResponseBody extends $tea.Model {
  residenceList?: SearchResidentResponseBodyResidenceList[];
  static names(): { [key: string]: string } {
    return {
      residenceList: 'residenceList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residenceList: { 'type': 'array', 'itemType': SearchResidentResponseBodyResidenceList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResidentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchResidentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchResidentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentDepartmentHeaders extends $tea.Model {
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

export class AddResidentDepartmentRequest extends $tea.Model {
  isResidenceGroup?: boolean;
  departmentName?: string;
  parentDepartmentId?: number;
  static names(): { [key: string]: string } {
    return {
      isResidenceGroup: 'isResidenceGroup',
      departmentName: 'departmentName',
      parentDepartmentId: 'parentDepartmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isResidenceGroup: 'boolean',
      departmentName: 'string',
      parentDepartmentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentDepartmentResponseBody extends $tea.Model {
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

export class AddResidentDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddResidentDepartmentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddResidentDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagePointHistoryHeaders extends $tea.Model {
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

export class PagePointHistoryRequest extends $tea.Model {
  isCircle?: boolean;
  userId?: string;
  nextToken?: number;
  maxResults?: number;
  startTime?: number;
  endTime?: number;
  static names(): { [key: string]: string } {
    return {
      isCircle: 'isCircle',
      userId: 'userId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      startTime: 'startTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isCircle: 'boolean',
      userId: 'string',
      nextToken: 'number',
      maxResults: 'number',
      startTime: 'number',
      endTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagePointHistoryResponseBody extends $tea.Model {
  pointRecordList?: PagePointHistoryResponseBodyPointRecordList[];
  hasMore?: boolean;
  nextToken?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      pointRecordList: 'pointRecordList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pointRecordList: { 'type': 'array', 'itemType': PagePointHistoryResponseBodyPointRecordList },
      hasMore: 'boolean',
      nextToken: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagePointHistoryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: PagePointHistoryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: PagePointHistoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpacesInfoHeaders extends $tea.Model {
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

export class GetSpacesInfoRequest extends $tea.Model {
  residentCorpId?: string;
  referIds?: number[];
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      residentCorpId: 'residentCorpId',
      referIds: 'referIds',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentCorpId: 'string',
      referIds: { 'type': 'array', 'itemType': 'number' },
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpacesInfoResponseBody extends $tea.Model {
  spaceList?: GetSpacesInfoResponseBodySpaceList[];
  static names(): { [key: string]: string } {
    return {
      spaceList: 'spaceList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceList: { 'type': 'array', 'itemType': GetSpacesInfoResponseBodySpaceList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpacesInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSpacesInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSpacesInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentUserHeaders extends $tea.Model {
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

export class UpdateResidentUserRequest extends $tea.Model {
  address?: string;
  isRetainOldDept?: boolean;
  userName?: string;
  mobile?: string;
  departmentId?: number;
  extField?: UpdateResidentUserRequestExtField[];
  relateType?: string;
  userId?: string;
  oldDepartmentId?: number;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      isRetainOldDept: 'isRetainOldDept',
      userName: 'userName',
      mobile: 'mobile',
      departmentId: 'departmentId',
      extField: 'extField',
      relateType: 'relateType',
      userId: 'userId',
      oldDepartmentId: 'oldDepartmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      isRetainOldDept: 'boolean',
      userName: 'string',
      mobile: 'string',
      departmentId: 'number',
      extField: { 'type': 'array', 'itemType': UpdateResidentUserRequestExtField },
      relateType: 'string',
      userId: 'string',
      oldDepartmentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentUserResponseBody extends $tea.Model {
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

export class UpdateResidentUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateResidentUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateResidentUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteResidentBlackBoardHeaders extends $tea.Model {
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

export class DeleteResidentBlackBoardRequest extends $tea.Model {
  blackboardId?: string;
  static names(): { [key: string]: string } {
    return {
      blackboardId: 'blackboardId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blackboardId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteResidentBlackBoardResponseBody extends $tea.Model {
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

export class DeleteResidentBlackBoardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteResidentBlackBoardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteResidentBlackBoardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPointHeaders extends $tea.Model {
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

export class AddPointRequest extends $tea.Model {
  isCircle?: boolean;
  uuid?: string;
  userId?: string;
  ruleCode?: string;
  ruleName?: string;
  actionTime?: number;
  score?: number;
  static names(): { [key: string]: string } {
    return {
      isCircle: 'isCircle',
      uuid: 'uuid',
      userId: 'userId',
      ruleCode: 'ruleCode',
      ruleName: 'ruleName',
      actionTime: 'actionTime',
      score: 'score',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isCircle: 'boolean',
      uuid: 'string',
      userId: 'string',
      ruleCode: 'string',
      ruleName: 'string',
      actionTime: 'number',
      score: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPointResponse extends $tea.Model {
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

export class DeleteResidentDepartmentHeaders extends $tea.Model {
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

export class DeleteResidentDepartmentRequest extends $tea.Model {
  departmentId?: number;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteResidentDepartmentResponseBody extends $tea.Model {
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

export class DeleteResidentDepartmentResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteResidentDepartmentResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteResidentDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentUsersHeaders extends $tea.Model {
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

export class AddResidentUsersRequest extends $tea.Model {
  address?: string;
  isLeaseholder?: boolean;
  userName?: string;
  mobile?: string;
  departmentId?: number;
  extField?: AddResidentUsersRequestExtField[];
  relateType?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      isLeaseholder: 'isLeaseholder',
      userName: 'userName',
      mobile: 'mobile',
      departmentId: 'departmentId',
      extField: 'extField',
      relateType: 'relateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      isLeaseholder: 'boolean',
      userName: 'string',
      mobile: 'string',
      departmentId: 'number',
      extField: { 'type': 'array', 'itemType': AddResidentUsersRequestExtField },
      relateType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentUsersResponseBody extends $tea.Model {
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

export class AddResidentUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddResidentUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddResidentUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentMembersInfoHeaders extends $tea.Model {
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

export class GetResidentMembersInfoRequest extends $tea.Model {
  residentCropId?: string;
  userIdList?: string[];
  dingSuiteKey?: string;
  dingCorpId?: string;
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      residentCropId: 'residentCropId',
      userIdList: 'userIdList',
      dingSuiteKey: 'dingSuiteKey',
      dingCorpId: 'dingCorpId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentCropId: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
      dingSuiteKey: 'string',
      dingCorpId: 'string',
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentMembersInfoResponseBody extends $tea.Model {
  residenceList?: GetResidentMembersInfoResponseBodyResidenceList[];
  static names(): { [key: string]: string } {
    return {
      residenceList: 'residenceList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residenceList: { 'type': 'array', 'itemType': GetResidentMembersInfoResponseBodyResidenceList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentMembersInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetResidentMembersInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetResidentMembersInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveResidentUserHeaders extends $tea.Model {
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

export class RemoveResidentUserRequest extends $tea.Model {
  departmentId?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveResidentUserResponseBody extends $tea.Model {
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

export class RemoveResidentUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RemoveResidentUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RemoveResidentUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidenceHeaders extends $tea.Model {
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

export class UpdateResidenceRequest extends $tea.Model {
  managerUserId?: string;
  departmentName?: string;
  departmentId?: number;
  grid?: string;
  homeTel?: string;
  destitute?: boolean;
  parentDepartmentId?: number;
  static names(): { [key: string]: string } {
    return {
      managerUserId: 'managerUserId',
      departmentName: 'departmentName',
      departmentId: 'departmentId',
      grid: 'grid',
      homeTel: 'homeTel',
      destitute: 'destitute',
      parentDepartmentId: 'parentDepartmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      managerUserId: 'string',
      departmentName: 'string',
      departmentId: 'number',
      grid: 'string',
      homeTel: 'string',
      destitute: 'boolean',
      parentDepartmentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidenceResponseBody extends $tea.Model {
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

export class UpdateResidenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateResidenceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateResidenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResidentBlackBoardHeaders extends $tea.Model {
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

export class CreateResidentBlackBoardRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingCorpId?: string;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  title?: string;
  context?: string;
  mediaId?: string;
  sendTime?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingCorpId: 'dingCorpId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      title: 'title',
      context: 'context',
      mediaId: 'mediaId',
      sendTime: 'sendTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingCorpId: 'string',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      title: 'string',
      context: 'string',
      mediaId: 'string',
      sendTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResidentBlackBoardResponseBody extends $tea.Model {
  blackBoardId?: string;
  static names(): { [key: string]: string } {
    return {
      blackBoardId: 'blackBoardId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blackBoardId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateResidentBlackBoardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateResidentBlackBoardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateResidentBlackBoardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentBlackBoardHeaders extends $tea.Model {
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

export class UpdateResidentBlackBoardRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingCorpId?: string;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  title?: string;
  context?: string;
  mediaId?: string;
  blackboardId?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingCorpId: 'dingCorpId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      title: 'title',
      context: 'context',
      mediaId: 'mediaId',
      blackboardId: 'blackboardId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingCorpId: 'string',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      title: 'string',
      context: 'string',
      mediaId: 'string',
      blackboardId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentBlackBoardResponseBody extends $tea.Model {
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

export class UpdateResidentBlackBoardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateResidentBlackBoardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateResidentBlackBoardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPointRulesHeaders extends $tea.Model {
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

export class ListPointRulesRequest extends $tea.Model {
  isCircle?: boolean;
  static names(): { [key: string]: string } {
    return {
      isCircle: 'isCircle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isCircle: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPointRulesResponseBody extends $tea.Model {
  pointRuleList?: ListPointRulesResponseBodyPointRuleList[];
  static names(): { [key: string]: string } {
    return {
      pointRuleList: 'pointRuleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pointRuleList: { 'type': 'array', 'itemType': ListPointRulesResponseBodyPointRuleList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPointRulesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListPointRulesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListPointRulesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIndustryTypeHeaders extends $tea.Model {
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

export class GetIndustryTypeResponseBody extends $tea.Model {
  industryType?: string;
  static names(): { [key: string]: string } {
    return {
      industryType: 'industryType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      industryType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIndustryTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetIndustryTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetIndustryTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubSpaceResponseBodySpaceList extends $tea.Model {
  referId?: number;
  spaceName?: string;
  tagCode?: string;
  type?: string;
  floor?: string;
  isVirtual?: number;
  billingArea?: number;
  buildingArea?: number;
  houseState?: number;
  parentReferId?: number;
  static names(): { [key: string]: string } {
    return {
      referId: 'referId',
      spaceName: 'spaceName',
      tagCode: 'tagCode',
      type: 'type',
      floor: 'floor',
      isVirtual: 'isVirtual',
      billingArea: 'billingArea',
      buildingArea: 'buildingArea',
      houseState: 'houseState',
      parentReferId: 'parentReferId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      referId: 'number',
      spaceName: 'string',
      tagCode: 'string',
      type: 'string',
      floor: 'string',
      isVirtual: 'number',
      billingArea: 'number',
      buildingArea: 'number',
      houseState: 'number',
      parentReferId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentInfoResponseBodyProjectManager extends $tea.Model {
  userId?: string;
  userName?: string;
  avatar?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      userName: 'userName',
      avatar: 'avatar',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      userName: 'string',
      avatar: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResidentResponseBodyResidenceList extends $tea.Model {
  name?: string;
  relateType?: string;
  isPropertyOwner?: boolean;
  active?: boolean;
  extField?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      relateType: 'relateType',
      isPropertyOwner: 'isPropertyOwner',
      active: 'active',
      extField: 'extField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      relateType: 'string',
      isPropertyOwner: 'boolean',
      active: 'boolean',
      extField: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagePointHistoryResponseBodyPointRecordList extends $tea.Model {
  corpId?: string;
  userId?: string;
  score?: number;
  createAt?: number;
  uuid?: string;
  ruleCode?: string;
  ruleName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      score: 'score',
      createAt: 'createAt',
      uuid: 'uuid',
      ruleCode: 'ruleCode',
      ruleName: 'ruleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      userId: 'string',
      score: 'number',
      createAt: 'number',
      uuid: 'string',
      ruleCode: 'string',
      ruleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpacesInfoResponseBodySpaceList extends $tea.Model {
  referId?: number;
  spaceName?: string;
  tagCode?: string;
  type?: string;
  floor?: string;
  isVirtual?: number;
  billingArea?: number;
  buildingArea?: number;
  houseState?: number;
  parentReferId?: number;
  static names(): { [key: string]: string } {
    return {
      referId: 'referId',
      spaceName: 'spaceName',
      tagCode: 'tagCode',
      type: 'type',
      floor: 'floor',
      isVirtual: 'isVirtual',
      billingArea: 'billingArea',
      buildingArea: 'buildingArea',
      houseState: 'houseState',
      parentReferId: 'parentReferId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      referId: 'number',
      spaceName: 'string',
      tagCode: 'string',
      type: 'string',
      floor: 'string',
      isVirtual: 'number',
      billingArea: 'number',
      buildingArea: 'number',
      houseState: 'number',
      parentReferId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentUserRequestExtField extends $tea.Model {
  itemValue?: string;
  itemName?: string;
  static names(): { [key: string]: string } {
    return {
      itemValue: 'itemValue',
      itemName: 'itemName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemValue: 'string',
      itemName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentUsersRequestExtField extends $tea.Model {
  itemValue?: string;
  itemName?: string;
  static names(): { [key: string]: string } {
    return {
      itemValue: 'itemValue',
      itemName: 'itemName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemValue: 'string',
      itemName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentMembersInfoResponseBodyResidenceList extends $tea.Model {
  name?: string;
  relateType?: string;
  isPropertyOwner?: boolean;
  active?: boolean;
  extField?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      relateType: 'relateType',
      isPropertyOwner: 'isPropertyOwner',
      active: 'active',
      extField: 'extField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      relateType: 'string',
      isPropertyOwner: 'boolean',
      active: 'boolean',
      extField: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPointRulesResponseBodyPointRuleList extends $tea.Model {
  corpId?: string;
  score?: number;
  dayLimitTimes?: number;
  status?: number;
  ruleCode?: string;
  ruleName?: string;
  extension?: string;
  groupId?: number;
  orderId?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      score: 'score',
      dayLimitTimes: 'dayLimitTimes',
      status: 'status',
      ruleCode: 'ruleCode',
      ruleName: 'ruleName',
      extension: 'extension',
      groupId: 'groupId',
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      score: 'number',
      dayLimitTimes: 'number',
      status: 'number',
      ruleCode: 'string',
      ruleName: 'string',
      extension: 'string',
      groupId: 'number',
      orderId: 'number',
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


  async getPropertyInfo(request: GetPropertyInfoRequest): Promise<GetPropertyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPropertyInfoHeaders({ });
    return await this.getPropertyInfoWithOptions(request, headers, runtime);
  }

  async getPropertyInfoWithOptions(request: GetPropertyInfoRequest, headers: GetPropertyInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPropertyInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.propertyCorpId)) {
      query["propertyCorpId"] = request.propertyCorpId;
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
    return $tea.cast<GetPropertyInfoResponse>(await this.doROARequest("GetPropertyInfo", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/propertyInfos`, "json", req, runtime), new GetPropertyInfoResponse({}));
  }

  async getSpaceIdByType(request: GetSpaceIdByTypeRequest): Promise<GetSpaceIdByTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceIdByTypeHeaders({ });
    return await this.getSpaceIdByTypeWithOptions(request, headers, runtime);
  }

  async getSpaceIdByTypeWithOptions(request: GetSpaceIdByTypeRequest, headers: GetSpaceIdByTypeHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceIdByTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentType)) {
      query["departmentType"] = request.departmentType;
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
    return $tea.cast<GetSpaceIdByTypeResponse>(await this.doROARequest("GetSpaceIdByType", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/spaces/types`, "json", req, runtime), new GetSpaceIdByTypeResponse({}));
  }

  async getConversationId(request: GetConversationIdRequest): Promise<GetConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationIdHeaders({ });
    return await this.getConversationIdWithOptions(request, headers, runtime);
  }

  async getConversationIdWithOptions(request: GetConversationIdRequest, headers: GetConversationIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationIdResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatId)) {
      query["chatId"] = request.chatId;
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
    return $tea.cast<GetConversationIdResponse>(await this.doROARequest("GetConversationId", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/conversations`, "json", req, runtime), new GetConversationIdResponse({}));
  }

  async listSubSpace(request: ListSubSpaceRequest): Promise<ListSubSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubSpaceHeaders({ });
    return await this.listSubSpaceWithOptions(request, headers, runtime);
  }

  async listSubSpaceWithOptions(request: ListSubSpaceRequest, headers: ListSubSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubSpaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.residentCorpId)) {
      query["residentCorpId"] = request.residentCorpId;
    }

    if (!Util.isUnset(request.referId)) {
      query["referId"] = request.referId;
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
    return $tea.cast<ListSubSpaceResponse>(await this.doROARequest("ListSubSpace", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/spaces/subSpaces`, "json", req, runtime), new ListSubSpaceResponse({}));
  }

  async updateResideceGroup(request: UpdateResideceGroupRequest): Promise<UpdateResideceGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResideceGroupHeaders({ });
    return await this.updateResideceGroupWithOptions(request, headers, runtime);
  }

  async updateResideceGroupWithOptions(request: UpdateResideceGroupRequest, headers: UpdateResideceGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResideceGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.managerUserId)) {
      query["managerUserId"] = request.managerUserId;
    }

    if (!Util.isUnset(request.departmentName)) {
      query["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
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
    return $tea.cast<UpdateResideceGroupResponse>(await this.doROARequest("UpdateResideceGroup", "resident_1.0", "HTTP", "PUT", "AK", `/v1.0/resident/departments/updateResideceGroup`, "json", req, runtime), new UpdateResideceGroupResponse({}));
  }

  async getResidentInfo(request: GetResidentInfoRequest): Promise<GetResidentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentInfoHeaders({ });
    return await this.getResidentInfoWithOptions(request, headers, runtime);
  }

  async getResidentInfoWithOptions(request: GetResidentInfoRequest, headers: GetResidentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetResidentInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.residentCorpId)) {
      query["residentCorpId"] = request.residentCorpId;
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
    return $tea.cast<GetResidentInfoResponse>(await this.doROARequest("GetResidentInfo", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/residentInfos`, "json", req, runtime), new GetResidentInfoResponse({}));
  }

  async searchResident(request: SearchResidentRequest): Promise<SearchResidentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchResidentHeaders({ });
    return await this.searchResidentWithOptions(request, headers, runtime);
  }

  async searchResidentWithOptions(request: SearchResidentRequest, headers: SearchResidentHeaders, runtime: $Util.RuntimeOptions): Promise<SearchResidentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.residentCropId)) {
      query["residentCropId"] = request.residentCropId;
    }

    if (!Util.isUnset(request.searchWord)) {
      query["searchWord"] = request.searchWord;
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
    return $tea.cast<SearchResidentResponse>(await this.doROARequest("SearchResident", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/residences`, "json", req, runtime), new SearchResidentResponse({}));
  }

  async addResidentDepartment(request: AddResidentDepartmentRequest): Promise<AddResidentDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentDepartmentHeaders({ });
    return await this.addResidentDepartmentWithOptions(request, headers, runtime);
  }

  async addResidentDepartmentWithOptions(request: AddResidentDepartmentRequest, headers: AddResidentDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<AddResidentDepartmentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isResidenceGroup)) {
      query["isResidenceGroup"] = request.isResidenceGroup;
    }

    if (!Util.isUnset(request.departmentName)) {
      query["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.parentDepartmentId)) {
      query["parentDepartmentId"] = request.parentDepartmentId;
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
    return $tea.cast<AddResidentDepartmentResponse>(await this.doROARequest("AddResidentDepartment", "resident_1.0", "HTTP", "POST", "AK", `/v1.0/resident/departments`, "json", req, runtime), new AddResidentDepartmentResponse({}));
  }

  async pagePointHistory(request: PagePointHistoryRequest): Promise<PagePointHistoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PagePointHistoryHeaders({ });
    return await this.pagePointHistoryWithOptions(request, headers, runtime);
  }

  async pagePointHistoryWithOptions(request: PagePointHistoryRequest, headers: PagePointHistoryHeaders, runtime: $Util.RuntimeOptions): Promise<PagePointHistoryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isCircle)) {
      query["isCircle"] = request.isCircle;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
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
    return $tea.cast<PagePointHistoryResponse>(await this.doROARequest("PagePointHistory", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/points/records`, "json", req, runtime), new PagePointHistoryResponse({}));
  }

  async getSpacesInfo(request: GetSpacesInfoRequest): Promise<GetSpacesInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpacesInfoHeaders({ });
    return await this.getSpacesInfoWithOptions(request, headers, runtime);
  }

  async getSpacesInfoWithOptions(request: GetSpacesInfoRequest, headers: GetSpacesInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpacesInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.residentCorpId)) {
      body["residentCorpId"] = request.residentCorpId;
    }

    if (!Util.isUnset(request.referIds)) {
      body["referIds"] = request.referIds;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<GetSpacesInfoResponse>(await this.doROARequest("GetSpacesInfo", "resident_1.0", "HTTP", "POST", "AK", `/v1.0/resident/spaces/query`, "json", req, runtime), new GetSpacesInfoResponse({}));
  }

  async updateResidentUser(request: UpdateResidentUserRequest): Promise<UpdateResidentUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentUserHeaders({ });
    return await this.updateResidentUserWithOptions(request, headers, runtime);
  }

  async updateResidentUserWithOptions(request: UpdateResidentUserRequest, headers: UpdateResidentUserHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidentUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      query["address"] = request.address;
    }

    if (!Util.isUnset(request.isRetainOldDept)) {
      query["isRetainOldDept"] = request.isRetainOldDept;
    }

    if (!Util.isUnset(request.userName)) {
      query["userName"] = request.userName;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.extField)) {
      query["extField"] = request.extField;
    }

    if (!Util.isUnset(request.relateType)) {
      query["relateType"] = request.relateType;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.oldDepartmentId)) {
      query["oldDepartmentId"] = request.oldDepartmentId;
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
    return $tea.cast<UpdateResidentUserResponse>(await this.doROARequest("UpdateResidentUser", "resident_1.0", "HTTP", "PUT", "AK", `/v1.0/resident/users`, "json", req, runtime), new UpdateResidentUserResponse({}));
  }

  async deleteResidentBlackBoard(request: DeleteResidentBlackBoardRequest): Promise<DeleteResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteResidentBlackBoardHeaders({ });
    return await this.deleteResidentBlackBoardWithOptions(request, headers, runtime);
  }

  async deleteResidentBlackBoardWithOptions(request: DeleteResidentBlackBoardRequest, headers: DeleteResidentBlackBoardHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteResidentBlackBoardResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blackboardId)) {
      query["blackboardId"] = request.blackboardId;
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
    return $tea.cast<DeleteResidentBlackBoardResponse>(await this.doROARequest("DeleteResidentBlackBoard", "resident_1.0", "HTTP", "DELETE", "AK", `/v1.0/resident/blackboards`, "json", req, runtime), new DeleteResidentBlackBoardResponse({}));
  }

  async addPoint(request: AddPointRequest): Promise<AddPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPointHeaders({ });
    return await this.addPointWithOptions(request, headers, runtime);
  }

  async addPointWithOptions(request: AddPointRequest, headers: AddPointHeaders, runtime: $Util.RuntimeOptions): Promise<AddPointResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isCircle)) {
      query["isCircle"] = request.isCircle;
    }

    if (!Util.isUnset(request.uuid)) {
      query["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.ruleCode)) {
      query["ruleCode"] = request.ruleCode;
    }

    if (!Util.isUnset(request.ruleName)) {
      query["ruleName"] = request.ruleName;
    }

    if (!Util.isUnset(request.actionTime)) {
      query["actionTime"] = request.actionTime;
    }

    if (!Util.isUnset(request.score)) {
      query["score"] = request.score;
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
    return $tea.cast<AddPointResponse>(await this.doROARequest("AddPoint", "resident_1.0", "HTTP", "POST", "AK", `/v1.0/resident/points`, "none", req, runtime), new AddPointResponse({}));
  }

  async deleteResidentDepartment(request: DeleteResidentDepartmentRequest): Promise<DeleteResidentDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteResidentDepartmentHeaders({ });
    return await this.deleteResidentDepartmentWithOptions(request, headers, runtime);
  }

  async deleteResidentDepartmentWithOptions(request: DeleteResidentDepartmentRequest, headers: DeleteResidentDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteResidentDepartmentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
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
    return $tea.cast<DeleteResidentDepartmentResponse>(await this.doROARequest("DeleteResidentDepartment", "resident_1.0", "HTTP", "DELETE", "AK", `/v1.0/resident/departments`, "json", req, runtime), new DeleteResidentDepartmentResponse({}));
  }

  async addResidentUsers(request: AddResidentUsersRequest): Promise<AddResidentUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentUsersHeaders({ });
    return await this.addResidentUsersWithOptions(request, headers, runtime);
  }

  async addResidentUsersWithOptions(request: AddResidentUsersRequest, headers: AddResidentUsersHeaders, runtime: $Util.RuntimeOptions): Promise<AddResidentUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      query["address"] = request.address;
    }

    if (!Util.isUnset(request.isLeaseholder)) {
      query["isLeaseholder"] = request.isLeaseholder;
    }

    if (!Util.isUnset(request.userName)) {
      query["userName"] = request.userName;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.extField)) {
      query["extField"] = request.extField;
    }

    if (!Util.isUnset(request.relateType)) {
      query["relateType"] = request.relateType;
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
    return $tea.cast<AddResidentUsersResponse>(await this.doROARequest("AddResidentUsers", "resident_1.0", "HTTP", "POST", "AK", `/v1.0/resident/users`, "json", req, runtime), new AddResidentUsersResponse({}));
  }

  async getResidentMembersInfo(request: GetResidentMembersInfoRequest): Promise<GetResidentMembersInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentMembersInfoHeaders({ });
    return await this.getResidentMembersInfoWithOptions(request, headers, runtime);
  }

  async getResidentMembersInfoWithOptions(request: GetResidentMembersInfoRequest, headers: GetResidentMembersInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetResidentMembersInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.residentCropId)) {
      body["residentCropId"] = request.residentCropId;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
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
    return $tea.cast<GetResidentMembersInfoResponse>(await this.doROARequest("GetResidentMembersInfo", "resident_1.0", "HTTP", "POST", "AK", `/v1.0/resident/residences/query`, "json", req, runtime), new GetResidentMembersInfoResponse({}));
  }

  async removeResidentUser(request: RemoveResidentUserRequest): Promise<RemoveResidentUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveResidentUserHeaders({ });
    return await this.removeResidentUserWithOptions(request, headers, runtime);
  }

  async removeResidentUserWithOptions(request: RemoveResidentUserRequest, headers: RemoveResidentUserHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveResidentUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
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
    return $tea.cast<RemoveResidentUserResponse>(await this.doROARequest("RemoveResidentUser", "resident_1.0", "HTTP", "POST", "AK", `/v1.0/resident/users/remove`, "json", req, runtime), new RemoveResidentUserResponse({}));
  }

  async updateResidence(request: UpdateResidenceRequest): Promise<UpdateResidenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidenceHeaders({ });
    return await this.updateResidenceWithOptions(request, headers, runtime);
  }

  async updateResidenceWithOptions(request: UpdateResidenceRequest, headers: UpdateResidenceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.managerUserId)) {
      query["managerUserId"] = request.managerUserId;
    }

    if (!Util.isUnset(request.departmentName)) {
      query["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.grid)) {
      query["grid"] = request.grid;
    }

    if (!Util.isUnset(request.homeTel)) {
      query["homeTel"] = request.homeTel;
    }

    if (!Util.isUnset(request.destitute)) {
      query["destitute"] = request.destitute;
    }

    if (!Util.isUnset(request.parentDepartmentId)) {
      query["parentDepartmentId"] = request.parentDepartmentId;
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
    return $tea.cast<UpdateResidenceResponse>(await this.doROARequest("UpdateResidence", "resident_1.0", "HTTP", "PUT", "AK", `/v1.0/resident/departments/updateResidece`, "json", req, runtime), new UpdateResidenceResponse({}));
  }

  async createResidentBlackBoard(request: CreateResidentBlackBoardRequest): Promise<CreateResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateResidentBlackBoardHeaders({ });
    return await this.createResidentBlackBoardWithOptions(request, headers, runtime);
  }

  async createResidentBlackBoardWithOptions(request: CreateResidentBlackBoardRequest, headers: CreateResidentBlackBoardHeaders, runtime: $Util.RuntimeOptions): Promise<CreateResidentBlackBoardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.context)) {
      body["context"] = request.context;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.sendTime)) {
      body["sendTime"] = request.sendTime;
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
    return $tea.cast<CreateResidentBlackBoardResponse>(await this.doROARequest("CreateResidentBlackBoard", "resident_1.0", "HTTP", "POST", "AK", `/v1.0/resident/blackboards`, "json", req, runtime), new CreateResidentBlackBoardResponse({}));
  }

  async updateResidentBlackBoard(request: UpdateResidentBlackBoardRequest): Promise<UpdateResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentBlackBoardHeaders({ });
    return await this.updateResidentBlackBoardWithOptions(request, headers, runtime);
  }

  async updateResidentBlackBoardWithOptions(request: UpdateResidentBlackBoardRequest, headers: UpdateResidentBlackBoardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidentBlackBoardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.context)) {
      body["context"] = request.context;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.blackboardId)) {
      body["blackboardId"] = request.blackboardId;
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
    return $tea.cast<UpdateResidentBlackBoardResponse>(await this.doROARequest("UpdateResidentBlackBoard", "resident_1.0", "HTTP", "PUT", "AK", `/v1.0/resident/blackboards`, "json", req, runtime), new UpdateResidentBlackBoardResponse({}));
  }

  async listPointRules(request: ListPointRulesRequest): Promise<ListPointRulesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPointRulesHeaders({ });
    return await this.listPointRulesWithOptions(request, headers, runtime);
  }

  async listPointRulesWithOptions(request: ListPointRulesRequest, headers: ListPointRulesHeaders, runtime: $Util.RuntimeOptions): Promise<ListPointRulesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isCircle)) {
      query["isCircle"] = request.isCircle;
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
    return $tea.cast<ListPointRulesResponse>(await this.doROARequest("ListPointRules", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/points/rules`, "json", req, runtime), new ListPointRulesResponse({}));
  }

  async getIndustryType(): Promise<GetIndustryTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIndustryTypeHeaders({ });
    return await this.getIndustryTypeWithOptions(headers, runtime);
  }

  async getIndustryTypeWithOptions(headers: GetIndustryTypeHeaders, runtime: $Util.RuntimeOptions): Promise<GetIndustryTypeResponse> {
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
    return $tea.cast<GetIndustryTypeResponse>(await this.doROARequest("GetIndustryType", "resident_1.0", "HTTP", "GET", "AK", `/v1.0/resident/organizations/industryTypes`, "json", req, runtime), new GetIndustryTypeResponse({}));
  }

}
