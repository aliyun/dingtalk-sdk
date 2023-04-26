// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  actionTime?: number;
  isCircle?: boolean;
  ruleCode?: string;
  ruleName?: string;
  score?: number;
  userId?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      actionTime: 'actionTime',
      isCircle: 'isCircle',
      ruleCode: 'ruleCode',
      ruleName: 'ruleName',
      score: 'score',
      userId: 'userId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionTime: 'number',
      isCircle: 'boolean',
      ruleCode: 'string',
      ruleName: 'string',
      score: 'number',
      userId: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPointResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
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
  departmentName?: string;
  isResidenceGroup?: boolean;
  parentDepartmentId?: number;
  static names(): { [key: string]: string } {
    return {
      departmentName: 'departmentName',
      isResidenceGroup: 'isResidenceGroup',
      parentDepartmentId: 'parentDepartmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentName: 'string',
      isResidenceGroup: 'boolean',
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
  statusCode: number;
  body: AddResidentDepartmentResponseBody;
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
      body: AddResidentDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentMemberHeaders extends $tea.Model {
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

export class AddResidentMemberRequest extends $tea.Model {
  residentAddInfo?: AddResidentMemberRequestResidentAddInfo;
  static names(): { [key: string]: string } {
    return {
      residentAddInfo: 'residentAddInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentAddInfo: AddResidentMemberRequestResidentAddInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentMemberResponseBody extends $tea.Model {
  status?: number;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'number',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddResidentMemberResponseBody;
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
      body: AddResidentMemberResponseBody,
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
  departmentId?: number;
  extField?: AddResidentUsersRequestExtField[];
  isLeaseholder?: boolean;
  mobile?: string;
  relateType?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      departmentId: 'departmentId',
      extField: 'extField',
      isLeaseholder: 'isLeaseholder',
      mobile: 'mobile',
      relateType: 'relateType',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      departmentId: 'number',
      extField: { 'type': 'array', 'itemType': AddResidentUsersRequestExtField },
      isLeaseholder: 'boolean',
      mobile: 'string',
      relateType: 'string',
      userName: 'string',
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
  statusCode: number;
  body: AddResidentUsersResponseBody;
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
      body: AddResidentUsersResponseBody,
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
  context?: string;
  mediaId?: string;
  sendTime?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      context: 'context',
      mediaId: 'mediaId',
      sendTime: 'sendTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      context: 'string',
      mediaId: 'string',
      sendTime: 'string',
      title: 'string',
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
  statusCode: number;
  body: CreateResidentBlackBoardResponseBody;
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
      body: CreateResidentBlackBoardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSpaceHeaders extends $tea.Model {
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

export class CreateSpaceRequest extends $tea.Model {
  billingArea?: number;
  buildingArea?: number;
  floor?: string;
  houseState?: number;
  name?: string;
  parentDeptId?: string;
  tagCode?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      billingArea: 'billingArea',
      buildingArea: 'buildingArea',
      floor: 'floor',
      houseState: 'houseState',
      name: 'name',
      parentDeptId: 'parentDeptId',
      tagCode: 'tagCode',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      billingArea: 'number',
      buildingArea: 'number',
      floor: 'string',
      houseState: 'number',
      name: 'string',
      parentDeptId: 'string',
      tagCode: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSpaceResponseBody extends $tea.Model {
  deptId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateSpaceResponseBody;
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
      body: CreateSpaceResponseBody,
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
  statusCode: number;
  body: DeleteResidentBlackBoardResponseBody;
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
      body: DeleteResidentBlackBoardResponseBody,
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
  statusCode: number;
  body: DeleteResidentDepartmentResponseBody;
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
      body: DeleteResidentDepartmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSpaceHeaders extends $tea.Model {
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

export class DeleteSpaceRequest extends $tea.Model {
  deptIds?: number[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSpaceResponseBody extends $tea.Model {
  delFailedDept?: DeleteSpaceResponseBodyDelFailedDept[];
  delSuccessCount?: boolean;
  static names(): { [key: string]: string } {
    return {
      delFailedDept: 'delFailedDept',
      delSuccessCount: 'delSuccessCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delFailedDept: { 'type': 'array', 'itemType': DeleteSpaceResponseBodyDelFailedDept },
      delSuccessCount: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteSpaceResponseBody;
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
      body: DeleteSpaceResponseBody,
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
  statusCode: number;
  body: GetConversationIdResponseBody;
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
      body: GetConversationIdResponseBody,
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
  statusCode: number;
  body: GetIndustryTypeResponseBody;
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
      body: GetIndustryTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  adminName?: string;
  adminUserId?: string;
  name?: string;
  orgId?: number;
  unifiedSocialCredit?: string;
  static names(): { [key: string]: string } {
    return {
      adminName: 'adminName',
      adminUserId: 'adminUserId',
      name: 'name',
      orgId: 'orgId',
      unifiedSocialCredit: 'unifiedSocialCredit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adminName: 'string',
      adminUserId: 'string',
      name: 'string',
      orgId: 'number',
      unifiedSocialCredit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPropertyInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPropertyInfoResponseBody;
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
      body: GetPropertyInfoResponseBody,
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
  address?: string;
  allUserGroupOpenConversationId?: string;
  allUserGroupOwnerUserId?: string;
  buildingArea?: number;
  cityId?: number;
  contactMode?: number;
  countyId?: number;
  deliveryTime?: number;
  location?: string;
  name?: string;
  projectManager?: GetResidentInfoResponseBodyProjectManager;
  propertyDeptGroupOpenConversationId?: string;
  propertyDeptGroupOwnerUserId?: string;
  provId?: number;
  scopeEast?: string;
  scopeNorth?: string;
  scopeSouth?: string;
  scopeWest?: string;
  telephone?: string;
  townId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      allUserGroupOpenConversationId: 'allUserGroupOpenConversationId',
      allUserGroupOwnerUserId: 'allUserGroupOwnerUserId',
      buildingArea: 'buildingArea',
      cityId: 'cityId',
      contactMode: 'contactMode',
      countyId: 'countyId',
      deliveryTime: 'deliveryTime',
      location: 'location',
      name: 'name',
      projectManager: 'projectManager',
      propertyDeptGroupOpenConversationId: 'propertyDeptGroupOpenConversationId',
      propertyDeptGroupOwnerUserId: 'propertyDeptGroupOwnerUserId',
      provId: 'provId',
      scopeEast: 'scopeEast',
      scopeNorth: 'scopeNorth',
      scopeSouth: 'scopeSouth',
      scopeWest: 'scopeWest',
      telephone: 'telephone',
      townId: 'townId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      allUserGroupOpenConversationId: 'string',
      allUserGroupOwnerUserId: 'string',
      buildingArea: 'number',
      cityId: 'number',
      contactMode: 'number',
      countyId: 'number',
      deliveryTime: 'number',
      location: 'string',
      name: 'string',
      projectManager: GetResidentInfoResponseBodyProjectManager,
      propertyDeptGroupOpenConversationId: 'string',
      propertyDeptGroupOwnerUserId: 'string',
      provId: 'number',
      scopeEast: 'string',
      scopeNorth: 'string',
      scopeSouth: 'string',
      scopeWest: 'string',
      telephone: 'string',
      townId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetResidentInfoResponseBody;
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
      body: GetResidentInfoResponseBody,
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
  static names(): { [key: string]: string } {
    return {
      residentCropId: 'residentCropId',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentCropId: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
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
  statusCode: number;
  body: GetResidentMembersInfoResponseBody;
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
      body: GetResidentMembersInfoResponseBody,
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
  statusCode: number;
  body: GetSpaceIdByTypeResponseBody;
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
      body: GetSpaceIdByTypeResponseBody,
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
  referIds?: number[];
  residentCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      referIds: 'referIds',
      residentCorpId: 'residentCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      referIds: { 'type': 'array', 'itemType': 'number' },
      residentCorpId: 'string',
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
  statusCode: number;
  body: GetSpacesInfoResponseBody;
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
      body: GetSpacesInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListIndustryRoleUsersHeaders extends $tea.Model {
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

export class ListIndustryRoleUsersRequest extends $tea.Model {
  tagCode?: string;
  static names(): { [key: string]: string } {
    return {
      tagCode: 'tagCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tagCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListIndustryRoleUsersResponseBody extends $tea.Model {
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

export class ListIndustryRoleUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListIndustryRoleUsersResponseBody;
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
      body: ListIndustryRoleUsersResponseBody,
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
  statusCode: number;
  body: ListPointRulesResponseBody;
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
      body: ListPointRulesResponseBody,
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
  referId?: number;
  residentCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      referId: 'referId',
      residentCorpId: 'residentCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      referId: 'number',
      residentCorpId: 'string',
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
  statusCode: number;
  body: ListSubSpaceResponseBody;
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
      body: ListSubSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUncheckUsersHeaders extends $tea.Model {
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

export class ListUncheckUsersRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  startTime?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      startTime: 'startTime',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      startTime: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUncheckUsersResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  values?: ListUncheckUsersResponseBodyValues[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      values: 'values',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      values: { 'type': 'array', 'itemType': ListUncheckUsersResponseBodyValues },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUncheckUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListUncheckUsersResponseBody;
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
      body: ListUncheckUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserIndustryRolesHeaders extends $tea.Model {
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

export class ListUserIndustryRolesRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserIndustryRolesResponseBody extends $tea.Model {
  roleList?: ListUserIndustryRolesResponseBodyRoleList[];
  static names(): { [key: string]: string } {
    return {
      roleList: 'roleList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleList: { 'type': 'array', 'itemType': ListUserIndustryRolesResponseBodyRoleList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserIndustryRolesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListUserIndustryRolesResponseBody;
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
      body: ListUserIndustryRolesResponseBody,
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
  endTime?: number;
  isCircle?: boolean;
  maxResults?: number;
  nextToken?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      isCircle: 'isCircle',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      isCircle: 'boolean',
      maxResults: 'number',
      nextToken: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagePointHistoryResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  pointRecordList?: PagePointHistoryResponseBodyPointRecordList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      pointRecordList: 'pointRecordList',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      pointRecordList: { 'type': 'array', 'itemType': PagePointHistoryResponseBodyPointRecordList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PagePointHistoryResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PagePointHistoryResponseBody;
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
      body: PagePointHistoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveResidentMemberHeaders extends $tea.Model {
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

export class RemoveResidentMemberRequest extends $tea.Model {
  deptId?: number;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveResidentMemberResponseBody extends $tea.Model {
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

export class RemoveResidentMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RemoveResidentMemberResponseBody;
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
      body: RemoveResidentMemberResponseBody,
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
  statusCode: number;
  body: RemoveResidentUserResponseBody;
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
      body: RemoveResidentUserResponseBody,
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
  statusCode: number;
  body: SearchResidentResponseBody;
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
      body: SearchResidentResponseBody,
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
  departmentId?: number;
  departmentName?: string;
  managerUserId?: string;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      managerUserId: 'managerUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      departmentName: 'string',
      managerUserId: 'string',
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
  statusCode: number;
  body: UpdateResideceGroupResponseBody;
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
      body: UpdateResideceGroupResponseBody,
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
  departmentId?: number;
  departmentName?: string;
  destitute?: boolean;
  grid?: string;
  homeTel?: string;
  managerUserId?: string;
  parentDepartmentId?: number;
  static names(): { [key: string]: string } {
    return {
      departmentId: 'departmentId',
      departmentName: 'departmentName',
      destitute: 'destitute',
      grid: 'grid',
      homeTel: 'homeTel',
      managerUserId: 'managerUserId',
      parentDepartmentId: 'parentDepartmentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      departmentId: 'number',
      departmentName: 'string',
      destitute: 'boolean',
      grid: 'string',
      homeTel: 'string',
      managerUserId: 'string',
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
  statusCode: number;
  body: UpdateResidenceResponseBody;
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
      body: UpdateResidenceResponseBody,
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
  blackboardId?: string;
  context?: string;
  mediaId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      blackboardId: 'blackboardId',
      context: 'context',
      mediaId: 'mediaId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blackboardId: 'string',
      context: 'string',
      mediaId: 'string',
      title: 'string',
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
  statusCode: number;
  body: UpdateResidentBlackBoardResponseBody;
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
      body: UpdateResidentBlackBoardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentInfoHeaders extends $tea.Model {
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

export class UpdateResidentInfoRequest extends $tea.Model {
  address?: string;
  buildingArea?: number;
  cityName?: string;
  communityType?: number;
  countyName?: string;
  location?: string;
  name?: string;
  provName?: string;
  state?: number;
  telephone?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      buildingArea: 'buildingArea',
      cityName: 'cityName',
      communityType: 'communityType',
      countyName: 'countyName',
      location: 'location',
      name: 'name',
      provName: 'provName',
      state: 'state',
      telephone: 'telephone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      buildingArea: 'number',
      cityName: 'string',
      communityType: 'number',
      countyName: 'string',
      location: 'string',
      name: 'string',
      provName: 'string',
      state: 'number',
      telephone: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentInfoResponseBody extends $tea.Model {
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

export class UpdateResidentInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateResidentInfoResponseBody;
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
      body: UpdateResidentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentMemberHeaders extends $tea.Model {
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

export class UpdateResidentMemberRequest extends $tea.Model {
  residentUpdateInfo?: UpdateResidentMemberRequestResidentUpdateInfo;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      residentUpdateInfo: 'residentUpdateInfo',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      residentUpdateInfo: UpdateResidentMemberRequestResidentUpdateInfo,
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentMemberResponseBody extends $tea.Model {
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

export class UpdateResidentMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateResidentMemberResponseBody;
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
      body: UpdateResidentMemberResponseBody,
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
  departmentId?: number;
  extField?: UpdateResidentUserRequestExtField[];
  isRetainOldDept?: boolean;
  mobile?: string;
  oldDepartmentId?: number;
  relateType?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      departmentId: 'departmentId',
      extField: 'extField',
      isRetainOldDept: 'isRetainOldDept',
      mobile: 'mobile',
      oldDepartmentId: 'oldDepartmentId',
      relateType: 'relateType',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      departmentId: 'number',
      extField: { 'type': 'array', 'itemType': UpdateResidentUserRequestExtField },
      isRetainOldDept: 'boolean',
      mobile: 'string',
      oldDepartmentId: 'number',
      relateType: 'string',
      userId: 'string',
      userName: 'string',
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
  statusCode: number;
  body: UpdateResidentUserResponseBody;
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
      body: UpdateResidentUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSpaceHeaders extends $tea.Model {
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

export class UpdateSpaceRequest extends $tea.Model {
  spaceInfoVOList?: UpdateSpaceRequestSpaceInfoVOList[];
  static names(): { [key: string]: string } {
    return {
      spaceInfoVOList: 'spaceInfoVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      spaceInfoVOList: { 'type': 'array', 'itemType': UpdateSpaceRequestSpaceInfoVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSpaceResponseBody extends $tea.Model {
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

export class UpdateSpaceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateSpaceResponseBody;
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
      body: UpdateSpaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentMemberRequestResidentAddInfo extends $tea.Model {
  deptId?: number;
  isPropertyOwner?: boolean;
  memberDeptExtension?: { [key: string]: any };
  mobile?: string;
  name?: string;
  relateType?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      isPropertyOwner: 'isPropertyOwner',
      memberDeptExtension: 'memberDeptExtension',
      mobile: 'mobile',
      name: 'name',
      relateType: 'relateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      isPropertyOwner: 'boolean',
      memberDeptExtension: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      mobile: 'string',
      name: 'string',
      relateType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddResidentUsersRequestExtField extends $tea.Model {
  itemName?: string;
  itemValue?: string;
  static names(): { [key: string]: string } {
    return {
      itemName: 'itemName',
      itemValue: 'itemValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemName: 'string',
      itemValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSpaceResponseBodyDelFailedDept extends $tea.Model {
  deptId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentInfoResponseBodyProjectManager extends $tea.Model {
  avatar?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetResidentMembersInfoResponseBodyResidenceList extends $tea.Model {
  active?: boolean;
  extField?: string;
  isPropertyOwner?: boolean;
  name?: string;
  relateType?: string;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      extField: 'extField',
      isPropertyOwner: 'isPropertyOwner',
      name: 'name',
      relateType: 'relateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      extField: 'string',
      isPropertyOwner: 'boolean',
      name: 'string',
      relateType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpacesInfoResponseBodySpaceList extends $tea.Model {
  billingArea?: number;
  buildingArea?: number;
  floor?: string;
  houseState?: number;
  isVirtual?: number;
  parentReferId?: number;
  referId?: number;
  spaceName?: string;
  tagCode?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      billingArea: 'billingArea',
      buildingArea: 'buildingArea',
      floor: 'floor',
      houseState: 'houseState',
      isVirtual: 'isVirtual',
      parentReferId: 'parentReferId',
      referId: 'referId',
      spaceName: 'spaceName',
      tagCode: 'tagCode',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      billingArea: 'number',
      buildingArea: 'number',
      floor: 'string',
      houseState: 'number',
      isVirtual: 'number',
      parentReferId: 'number',
      referId: 'number',
      spaceName: 'string',
      tagCode: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListPointRulesResponseBodyPointRuleList extends $tea.Model {
  dayLimitTimes?: number;
  extension?: string;
  groupId?: number;
  orderId?: number;
  ruleCode?: string;
  ruleName?: string;
  score?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      dayLimitTimes: 'dayLimitTimes',
      extension: 'extension',
      groupId: 'groupId',
      orderId: 'orderId',
      ruleCode: 'ruleCode',
      ruleName: 'ruleName',
      score: 'score',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dayLimitTimes: 'number',
      extension: 'string',
      groupId: 'number',
      orderId: 'number',
      ruleCode: 'string',
      ruleName: 'string',
      score: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSubSpaceResponseBodySpaceList extends $tea.Model {
  billingArea?: number;
  buildingArea?: number;
  floor?: string;
  houseState?: number;
  isVirtual?: number;
  parentReferId?: number;
  referId?: number;
  spaceName?: string;
  tagCode?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      billingArea: 'billingArea',
      buildingArea: 'buildingArea',
      floor: 'floor',
      houseState: 'houseState',
      isVirtual: 'isVirtual',
      parentReferId: 'parentReferId',
      referId: 'referId',
      spaceName: 'spaceName',
      tagCode: 'tagCode',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      billingArea: 'number',
      buildingArea: 'number',
      floor: 'string',
      houseState: 'number',
      isVirtual: 'number',
      parentReferId: 'number',
      referId: 'number',
      spaceName: 'string',
      tagCode: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUncheckUsersResponseBodyValues extends $tea.Model {
  deptId?: number;
  extension?: string;
  gmtCreate?: number;
  gmtModified?: number;
  isPropertyOwner?: boolean;
  name?: string;
  status?: number;
  unionId?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      extension: 'extension',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      isPropertyOwner: 'isPropertyOwner',
      name: 'name',
      status: 'status',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      extension: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      isPropertyOwner: 'boolean',
      name: 'string',
      status: 'number',
      unionId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserIndustryRolesResponseBodyRoleList extends $tea.Model {
  roleId?: number;
  roleName?: string;
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

export class PagePointHistoryResponseBodyPointRecordList extends $tea.Model {
  createAt?: number;
  ruleCode?: string;
  ruleName?: string;
  score?: number;
  userId?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      createAt: 'createAt',
      ruleCode: 'ruleCode',
      ruleName: 'ruleName',
      score: 'score',
      userId: 'userId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createAt: 'number',
      ruleCode: 'string',
      ruleName: 'string',
      score: 'number',
      userId: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchResidentResponseBodyResidenceList extends $tea.Model {
  active?: boolean;
  extField?: string;
  isPropertyOwner?: boolean;
  name?: string;
  relateType?: string;
  static names(): { [key: string]: string } {
    return {
      active: 'active',
      extField: 'extField',
      isPropertyOwner: 'isPropertyOwner',
      name: 'name',
      relateType: 'relateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      active: 'boolean',
      extField: 'string',
      isPropertyOwner: 'boolean',
      name: 'string',
      relateType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentMemberRequestResidentUpdateInfo extends $tea.Model {
  deptId?: number;
  isPropertyOwner?: boolean;
  memberDeptExtension?: { [key: string]: string };
  name?: string;
  oldDeptId?: number;
  relateType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      isPropertyOwner: 'isPropertyOwner',
      memberDeptExtension: 'memberDeptExtension',
      name: 'name',
      oldDeptId: 'oldDeptId',
      relateType: 'relateType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      isPropertyOwner: 'boolean',
      memberDeptExtension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      name: 'string',
      oldDeptId: 'number',
      relateType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResidentUserRequestExtField extends $tea.Model {
  itemName?: string;
  itemValue?: string;
  static names(): { [key: string]: string } {
    return {
      itemName: 'itemName',
      itemValue: 'itemValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemName: 'string',
      itemValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSpaceRequestSpaceInfoVOList extends $tea.Model {
  billingArea?: number;
  buildingArea?: number;
  buildingType?: number;
  deptId?: number;
  floor?: string;
  houseState?: number;
  houseType?: number;
  name?: string;
  parentDeptId?: number;
  tagCode?: string;
  static names(): { [key: string]: string } {
    return {
      billingArea: 'billingArea',
      buildingArea: 'buildingArea',
      buildingType: 'buildingType',
      deptId: 'deptId',
      floor: 'floor',
      houseState: 'houseState',
      houseType: 'houseType',
      name: 'name',
      parentDeptId: 'parentDeptId',
      tagCode: 'tagCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      billingArea: 'number',
      buildingArea: 'number',
      buildingType: 'number',
      deptId: 'number',
      floor: 'string',
      houseState: 'number',
      houseType: 'number',
      name: 'string',
      parentDeptId: 'number',
      tagCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async addPointWithOptions(request: AddPointRequest, headers: AddPointHeaders, runtime: $Util.RuntimeOptions): Promise<AddPointResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionTime)) {
      query["actionTime"] = request.actionTime;
    }

    if (!Util.isUnset(request.isCircle)) {
      query["isCircle"] = request.isCircle;
    }

    if (!Util.isUnset(request.ruleCode)) {
      query["ruleCode"] = request.ruleCode;
    }

    if (!Util.isUnset(request.ruleName)) {
      query["ruleName"] = request.ruleName;
    }

    if (!Util.isUnset(request.score)) {
      query["score"] = request.score;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.uuid)) {
      query["uuid"] = request.uuid;
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
      action: "AddPoint",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/points`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddPointResponse>(await this.execute(params, req, runtime), new AddPointResponse({}));
  }

  async addPoint(request: AddPointRequest): Promise<AddPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPointHeaders({ });
    return await this.addPointWithOptions(request, headers, runtime);
  }

  async addResidentDepartmentWithOptions(request: AddResidentDepartmentRequest, headers: AddResidentDepartmentHeaders, runtime: $Util.RuntimeOptions): Promise<AddResidentDepartmentResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentName)) {
      query["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.isResidenceGroup)) {
      query["isResidenceGroup"] = request.isResidenceGroup;
    }

    if (!Util.isUnset(request.parentDepartmentId)) {
      query["parentDepartmentId"] = request.parentDepartmentId;
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
      action: "AddResidentDepartment",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/departments`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddResidentDepartmentResponse>(await this.execute(params, req, runtime), new AddResidentDepartmentResponse({}));
  }

  async addResidentDepartment(request: AddResidentDepartmentRequest): Promise<AddResidentDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentDepartmentHeaders({ });
    return await this.addResidentDepartmentWithOptions(request, headers, runtime);
  }

  async addResidentMemberWithOptions(request: AddResidentMemberRequest, headers: AddResidentMemberHeaders, runtime: $Util.RuntimeOptions): Promise<AddResidentMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.residentAddInfo)) {
      body["residentAddInfo"] = request.residentAddInfo;
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
      action: "AddResidentMember",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddResidentMemberResponse>(await this.execute(params, req, runtime), new AddResidentMemberResponse({}));
  }

  async addResidentMember(request: AddResidentMemberRequest): Promise<AddResidentMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentMemberHeaders({ });
    return await this.addResidentMemberWithOptions(request, headers, runtime);
  }

  async addResidentUsersWithOptions(request: AddResidentUsersRequest, headers: AddResidentUsersHeaders, runtime: $Util.RuntimeOptions): Promise<AddResidentUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      query["address"] = request.address;
    }

    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.extField)) {
      query["extField"] = request.extField;
    }

    if (!Util.isUnset(request.isLeaseholder)) {
      query["isLeaseholder"] = request.isLeaseholder;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.relateType)) {
      query["relateType"] = request.relateType;
    }

    if (!Util.isUnset(request.userName)) {
      query["userName"] = request.userName;
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
      action: "AddResidentUsers",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/users`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddResidentUsersResponse>(await this.execute(params, req, runtime), new AddResidentUsersResponse({}));
  }

  async addResidentUsers(request: AddResidentUsersRequest): Promise<AddResidentUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentUsersHeaders({ });
    return await this.addResidentUsersWithOptions(request, headers, runtime);
  }

  async createResidentBlackBoardWithOptions(request: CreateResidentBlackBoardRequest, headers: CreateResidentBlackBoardHeaders, runtime: $Util.RuntimeOptions): Promise<CreateResidentBlackBoardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.context)) {
      body["context"] = request.context;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.sendTime)) {
      body["sendTime"] = request.sendTime;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "CreateResidentBlackBoard",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/blackboards`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateResidentBlackBoardResponse>(await this.execute(params, req, runtime), new CreateResidentBlackBoardResponse({}));
  }

  async createResidentBlackBoard(request: CreateResidentBlackBoardRequest): Promise<CreateResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateResidentBlackBoardHeaders({ });
    return await this.createResidentBlackBoardWithOptions(request, headers, runtime);
  }

  async createSpaceWithOptions(request: CreateSpaceRequest, headers: CreateSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.billingArea)) {
      body["billingArea"] = request.billingArea;
    }

    if (!Util.isUnset(request.buildingArea)) {
      body["buildingArea"] = request.buildingArea;
    }

    if (!Util.isUnset(request.floor)) {
      body["floor"] = request.floor;
    }

    if (!Util.isUnset(request.houseState)) {
      body["houseState"] = request.houseState;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.parentDeptId)) {
      body["parentDeptId"] = request.parentDeptId;
    }

    if (!Util.isUnset(request.tagCode)) {
      body["tagCode"] = request.tagCode;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
      action: "CreateSpace",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/spaces`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSpaceResponse>(await this.execute(params, req, runtime), new CreateSpaceResponse({}));
  }

  async createSpace(request: CreateSpaceRequest): Promise<CreateSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSpaceHeaders({ });
    return await this.createSpaceWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteResidentBlackBoard",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/blackboards`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteResidentBlackBoardResponse>(await this.execute(params, req, runtime), new DeleteResidentBlackBoardResponse({}));
  }

  async deleteResidentBlackBoard(request: DeleteResidentBlackBoardRequest): Promise<DeleteResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteResidentBlackBoardHeaders({ });
    return await this.deleteResidentBlackBoardWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteResidentDepartment",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/departments`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteResidentDepartmentResponse>(await this.execute(params, req, runtime), new DeleteResidentDepartmentResponse({}));
  }

  async deleteResidentDepartment(request: DeleteResidentDepartmentRequest): Promise<DeleteResidentDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteResidentDepartmentHeaders({ });
    return await this.deleteResidentDepartmentWithOptions(request, headers, runtime);
  }

  async deleteSpaceWithOptions(request: DeleteSpaceRequest, headers: DeleteSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
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
      action: "DeleteSpace",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/spaces/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteSpaceResponse>(await this.execute(params, req, runtime), new DeleteSpaceResponse({}));
  }

  async deleteSpace(request: DeleteSpaceRequest): Promise<DeleteSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSpaceHeaders({ });
    return await this.deleteSpaceWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetConversationId",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/conversations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConversationIdResponse>(await this.execute(params, req, runtime), new GetConversationIdResponse({}));
  }

  async getConversationId(request: GetConversationIdRequest): Promise<GetConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationIdHeaders({ });
    return await this.getConversationIdWithOptions(request, headers, runtime);
  }

  async getIndustryTypeWithOptions(headers: GetIndustryTypeHeaders, runtime: $Util.RuntimeOptions): Promise<GetIndustryTypeResponse> {
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
      action: "GetIndustryType",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/organizations/industryTypes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetIndustryTypeResponse>(await this.execute(params, req, runtime), new GetIndustryTypeResponse({}));
  }

  async getIndustryType(): Promise<GetIndustryTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIndustryTypeHeaders({ });
    return await this.getIndustryTypeWithOptions(headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetPropertyInfo",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/propertyInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPropertyInfoResponse>(await this.execute(params, req, runtime), new GetPropertyInfoResponse({}));
  }

  async getPropertyInfo(request: GetPropertyInfoRequest): Promise<GetPropertyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPropertyInfoHeaders({ });
    return await this.getPropertyInfoWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetResidentInfo",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/residentInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetResidentInfoResponse>(await this.execute(params, req, runtime), new GetResidentInfoResponse({}));
  }

  async getResidentInfo(request: GetResidentInfoRequest): Promise<GetResidentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentInfoHeaders({ });
    return await this.getResidentInfoWithOptions(request, headers, runtime);
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
      action: "GetResidentMembersInfo",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/residences/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetResidentMembersInfoResponse>(await this.execute(params, req, runtime), new GetResidentMembersInfoResponse({}));
  }

  async getResidentMembersInfo(request: GetResidentMembersInfoRequest): Promise<GetResidentMembersInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentMembersInfoHeaders({ });
    return await this.getResidentMembersInfoWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "GetSpaceIdByType",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/spaces/types`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpaceIdByTypeResponse>(await this.execute(params, req, runtime), new GetSpaceIdByTypeResponse({}));
  }

  async getSpaceIdByType(request: GetSpaceIdByTypeRequest): Promise<GetSpaceIdByTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceIdByTypeHeaders({ });
    return await this.getSpaceIdByTypeWithOptions(request, headers, runtime);
  }

  async getSpacesInfoWithOptions(request: GetSpacesInfoRequest, headers: GetSpacesInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpacesInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.referIds)) {
      body["referIds"] = request.referIds;
    }

    if (!Util.isUnset(request.residentCorpId)) {
      body["residentCorpId"] = request.residentCorpId;
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
      action: "GetSpacesInfo",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/spaces/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpacesInfoResponse>(await this.execute(params, req, runtime), new GetSpacesInfoResponse({}));
  }

  async getSpacesInfo(request: GetSpacesInfoRequest): Promise<GetSpacesInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpacesInfoHeaders({ });
    return await this.getSpacesInfoWithOptions(request, headers, runtime);
  }

  async listIndustryRoleUsersWithOptions(request: ListIndustryRoleUsersRequest, headers: ListIndustryRoleUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListIndustryRoleUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tagCode)) {
      query["tagCode"] = request.tagCode;
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
      action: "ListIndustryRoleUsers",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/industryRoles/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListIndustryRoleUsersResponse>(await this.execute(params, req, runtime), new ListIndustryRoleUsersResponse({}));
  }

  async listIndustryRoleUsers(request: ListIndustryRoleUsersRequest): Promise<ListIndustryRoleUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListIndustryRoleUsersHeaders({ });
    return await this.listIndustryRoleUsersWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "ListPointRules",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/points/rules`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListPointRulesResponse>(await this.execute(params, req, runtime), new ListPointRulesResponse({}));
  }

  async listPointRules(request: ListPointRulesRequest): Promise<ListPointRulesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPointRulesHeaders({ });
    return await this.listPointRulesWithOptions(request, headers, runtime);
  }

  async listSubSpaceWithOptions(request: ListSubSpaceRequest, headers: ListSubSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<ListSubSpaceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.referId)) {
      query["referId"] = request.referId;
    }

    if (!Util.isUnset(request.residentCorpId)) {
      query["residentCorpId"] = request.residentCorpId;
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
      action: "ListSubSpace",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/spaces/subSpaces`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListSubSpaceResponse>(await this.execute(params, req, runtime), new ListSubSpaceResponse({}));
  }

  async listSubSpace(request: ListSubSpaceRequest): Promise<ListSubSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubSpaceHeaders({ });
    return await this.listSubSpaceWithOptions(request, headers, runtime);
  }

  async listUncheckUsersWithOptions(request: ListUncheckUsersRequest, headers: ListUncheckUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListUncheckUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
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
      action: "ListUncheckUsers",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/organizations/noJoinUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListUncheckUsersResponse>(await this.execute(params, req, runtime), new ListUncheckUsersResponse({}));
  }

  async listUncheckUsers(request: ListUncheckUsersRequest): Promise<ListUncheckUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUncheckUsersHeaders({ });
    return await this.listUncheckUsersWithOptions(request, headers, runtime);
  }

  async listUserIndustryRolesWithOptions(request: ListUserIndustryRolesRequest, headers: ListUserIndustryRolesHeaders, runtime: $Util.RuntimeOptions): Promise<ListUserIndustryRolesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      action: "ListUserIndustryRoles",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/users/industryRoles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListUserIndustryRolesResponse>(await this.execute(params, req, runtime), new ListUserIndustryRolesResponse({}));
  }

  async listUserIndustryRoles(request: ListUserIndustryRolesRequest): Promise<ListUserIndustryRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserIndustryRolesHeaders({ });
    return await this.listUserIndustryRolesWithOptions(request, headers, runtime);
  }

  async pagePointHistoryWithOptions(request: PagePointHistoryRequest, headers: PagePointHistoryHeaders, runtime: $Util.RuntimeOptions): Promise<PagePointHistoryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.isCircle)) {
      query["isCircle"] = request.isCircle;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
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
      action: "PagePointHistory",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/points/records`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PagePointHistoryResponse>(await this.execute(params, req, runtime), new PagePointHistoryResponse({}));
  }

  async pagePointHistory(request: PagePointHistoryRequest): Promise<PagePointHistoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PagePointHistoryHeaders({ });
    return await this.pagePointHistoryWithOptions(request, headers, runtime);
  }

  async removeResidentMemberWithOptions(request: RemoveResidentMemberRequest, headers: RemoveResidentMemberHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveResidentMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "RemoveResidentMember",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/members/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveResidentMemberResponse>(await this.execute(params, req, runtime), new RemoveResidentMemberResponse({}));
  }

  async removeResidentMember(request: RemoveResidentMemberRequest): Promise<RemoveResidentMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveResidentMemberHeaders({ });
    return await this.removeResidentMemberWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "RemoveResidentUser",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/users/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RemoveResidentUserResponse>(await this.execute(params, req, runtime), new RemoveResidentUserResponse({}));
  }

  async removeResidentUser(request: RemoveResidentUserRequest): Promise<RemoveResidentUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveResidentUserHeaders({ });
    return await this.removeResidentUserWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "SearchResident",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/residences`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchResidentResponse>(await this.execute(params, req, runtime), new SearchResidentResponse({}));
  }

  async searchResident(request: SearchResidentRequest): Promise<SearchResidentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchResidentHeaders({ });
    return await this.searchResidentWithOptions(request, headers, runtime);
  }

  async updateResideceGroupWithOptions(request: UpdateResideceGroupRequest, headers: UpdateResideceGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResideceGroupResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.departmentName)) {
      query["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.managerUserId)) {
      query["managerUserId"] = request.managerUserId;
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
      action: "UpdateResideceGroup",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/departments/updateResideceGroup`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateResideceGroupResponse>(await this.execute(params, req, runtime), new UpdateResideceGroupResponse({}));
  }

  async updateResideceGroup(request: UpdateResideceGroupRequest): Promise<UpdateResideceGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResideceGroupHeaders({ });
    return await this.updateResideceGroupWithOptions(request, headers, runtime);
  }

  async updateResidenceWithOptions(request: UpdateResidenceRequest, headers: UpdateResidenceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.departmentName)) {
      query["departmentName"] = request.departmentName;
    }

    if (!Util.isUnset(request.destitute)) {
      query["destitute"] = request.destitute;
    }

    if (!Util.isUnset(request.grid)) {
      query["grid"] = request.grid;
    }

    if (!Util.isUnset(request.homeTel)) {
      query["homeTel"] = request.homeTel;
    }

    if (!Util.isUnset(request.managerUserId)) {
      query["managerUserId"] = request.managerUserId;
    }

    if (!Util.isUnset(request.parentDepartmentId)) {
      query["parentDepartmentId"] = request.parentDepartmentId;
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
      action: "UpdateResidence",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/departments/updateResidece`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateResidenceResponse>(await this.execute(params, req, runtime), new UpdateResidenceResponse({}));
  }

  async updateResidence(request: UpdateResidenceRequest): Promise<UpdateResidenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidenceHeaders({ });
    return await this.updateResidenceWithOptions(request, headers, runtime);
  }

  async updateResidentBlackBoardWithOptions(request: UpdateResidentBlackBoardRequest, headers: UpdateResidentBlackBoardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidentBlackBoardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blackboardId)) {
      body["blackboardId"] = request.blackboardId;
    }

    if (!Util.isUnset(request.context)) {
      body["context"] = request.context;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      action: "UpdateResidentBlackBoard",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/blackboards`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateResidentBlackBoardResponse>(await this.execute(params, req, runtime), new UpdateResidentBlackBoardResponse({}));
  }

  async updateResidentBlackBoard(request: UpdateResidentBlackBoardRequest): Promise<UpdateResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentBlackBoardHeaders({ });
    return await this.updateResidentBlackBoardWithOptions(request, headers, runtime);
  }

  async updateResidentInfoWithOptions(request: UpdateResidentInfoRequest, headers: UpdateResidentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidentInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      body["address"] = request.address;
    }

    if (!Util.isUnset(request.buildingArea)) {
      body["buildingArea"] = request.buildingArea;
    }

    if (!Util.isUnset(request.cityName)) {
      body["cityName"] = request.cityName;
    }

    if (!Util.isUnset(request.communityType)) {
      body["communityType"] = request.communityType;
    }

    if (!Util.isUnset(request.countyName)) {
      body["countyName"] = request.countyName;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.provName)) {
      body["provName"] = request.provName;
    }

    if (!Util.isUnset(request.state)) {
      body["state"] = request.state;
    }

    if (!Util.isUnset(request.telephone)) {
      body["telephone"] = request.telephone;
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
      action: "UpdateResidentInfo",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/residences`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateResidentInfoResponse>(await this.execute(params, req, runtime), new UpdateResidentInfoResponse({}));
  }

  async updateResidentInfo(request: UpdateResidentInfoRequest): Promise<UpdateResidentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentInfoHeaders({ });
    return await this.updateResidentInfoWithOptions(request, headers, runtime);
  }

  async updateResidentMemberWithOptions(request: UpdateResidentMemberRequest, headers: UpdateResidentMemberHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidentMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.residentUpdateInfo)) {
      body["residentUpdateInfo"] = request.residentUpdateInfo;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "UpdateResidentMember",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/members`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateResidentMemberResponse>(await this.execute(params, req, runtime), new UpdateResidentMemberResponse({}));
  }

  async updateResidentMember(request: UpdateResidentMemberRequest): Promise<UpdateResidentMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentMemberHeaders({ });
    return await this.updateResidentMemberWithOptions(request, headers, runtime);
  }

  async updateResidentUserWithOptions(request: UpdateResidentUserRequest, headers: UpdateResidentUserHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResidentUserResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.address)) {
      query["address"] = request.address;
    }

    if (!Util.isUnset(request.departmentId)) {
      query["departmentId"] = request.departmentId;
    }

    if (!Util.isUnset(request.extField)) {
      query["extField"] = request.extField;
    }

    if (!Util.isUnset(request.isRetainOldDept)) {
      query["isRetainOldDept"] = request.isRetainOldDept;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.oldDepartmentId)) {
      query["oldDepartmentId"] = request.oldDepartmentId;
    }

    if (!Util.isUnset(request.relateType)) {
      query["relateType"] = request.relateType;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      query["userName"] = request.userName;
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
      action: "UpdateResidentUser",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/users`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateResidentUserResponse>(await this.execute(params, req, runtime), new UpdateResidentUserResponse({}));
  }

  async updateResidentUser(request: UpdateResidentUserRequest): Promise<UpdateResidentUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentUserHeaders({ });
    return await this.updateResidentUserWithOptions(request, headers, runtime);
  }

  async updateSpaceWithOptions(request: UpdateSpaceRequest, headers: UpdateSpaceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSpaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.spaceInfoVOList)) {
      body["spaceInfoVOList"] = request.spaceInfoVOList;
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
      action: "UpdateSpace",
      version: "resident_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/resident/spaces`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateSpaceResponse>(await this.execute(params, req, runtime), new UpdateSpaceResponse({}));
  }

  async updateSpace(request: UpdateSpaceRequest): Promise<UpdateSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSpaceHeaders({ });
    return await this.updateSpaceWithOptions(request, headers, runtime);
  }

}
