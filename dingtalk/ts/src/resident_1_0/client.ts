// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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

}
