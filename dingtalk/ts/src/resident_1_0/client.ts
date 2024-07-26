// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @example
   * 1634630147
   */
  actionTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  isCircle?: boolean;
  /**
   * @example
   * rule_1
   */
  ruleCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 发动态
   */
  ruleName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  score?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 7645
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 第一网格组
   */
  departmentName?: string;
  /**
   * @example
   * true
   */
  isResidenceGroup?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddResidentDepartmentResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * A栋
   */
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
  /**
   * @example
   * 10005
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddResidentMemberResponseBody;
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
  /**
   * @example
   * 美好社区创景街道万通公寓
   */
  address?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  departmentId?: number;
  extField?: AddResidentUsersRequestExtField[];
  /**
   * @example
   * false
   */
  isLeaseholder?: boolean;
  /**
   * @example
   * 15612345678
   */
  mobile?: string;
  /**
   * @example
   * SELF
   * 
   * **if can be null:**
   * true
   */
  relateType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 王建国
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddResidentUsersResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  context?: string;
  mediaId?: string;
  sendTime?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateResidentBlackBoardResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * A栋
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * -7
   */
  parentDeptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * House
   */
  tagCode?: string;
  /**
   * @example
   * 2
   */
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
  /**
   * @example
   * 10005
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateSpaceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteResidentBlackBoardResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteResidentDepartmentResponseBody;
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
  /**
   * @example
   * 忘川路1号
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  delFailedDept?: DeleteSpaceResponseBodyDelFailedDept[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteSpaceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * chatd575783672bb40c005ba4e8b2*****ab
   */
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
  /**
   * @example
   * cidAX+2NwjqR3Y81Sxic5jtag==
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConversationIdResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * RESIDENCE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetIndustryTypeResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPropertyInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  allUserGroupOpenConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  allUserGroupOwnerUserId?: string;
  buildingArea?: number;
  cityId?: number;
  contactMode?: number;
  countyId?: number;
  deliveryTime?: number;
  location?: string;
  name?: string;
  projectManager?: GetResidentInfoResponseBodyProjectManager;
  /**
   * @remarks
   * This parameter is required.
   */
  propertyDeptGroupOpenConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetResidentInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  residentCropId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetResidentMembersInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROPERTY_STAFF_DEPT
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12343
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSpaceIdByTypeResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  referIds?: number[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSpacesInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SecurityManager
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListIndustryRoleUsersResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListPointRulesResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSubSpaceResponseBody;
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
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @example
   * 1652698991669
   */
  startTime?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListUncheckUsersResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListUserIndustryRolesResponseBody;
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
  /**
   * @example
   * 1631260866105
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  isCircle?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @example
   * 1630345050858
   */
  startTime?: number;
  /**
   * @example
   * 123
   * 
   * **if can be null:**
   * true
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3276
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  pointRecordList?: PagePointHistoryResponseBodyPointRecordList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * -1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PagePointHistoryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  /**
   * @example
   * 111112***
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveResidentMemberResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveResidentUserResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  residentCropId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchResidentResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 第一网格组
   */
  departmentName?: string;
  /**
   * @example
   * 1234
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateResideceGroupResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  departmentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 101户
   */
  departmentName?: string;
  /**
   * @example
   * false
   */
  destitute?: boolean;
  /**
   * @example
   * 第1网格
   */
  grid?: string;
  /**
   * @example
   * 16612345678
   */
  homeTel?: string;
  /**
   * @example
   * 1234
   */
  managerUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateResidenceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  context?: string;
  mediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateResidentBlackBoardResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试小区1
   */
  name?: string;
  provName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateResidentInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试小区1
   */
  residentUpdateInfo?: UpdateResidentMemberRequestResidentUpdateInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1212
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateResidentMemberResponseBody;
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
  /**
   * @example
   * 美好社区创景街道万通公寓
   */
  address?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  departmentId?: number;
  extField?: UpdateResidentUserRequestExtField[];
  /**
   * @example
   * false
   */
  isRetainOldDept?: boolean;
  /**
   * @example
   * 15612345678
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  oldDepartmentId?: number;
  /**
   * @example
   * SELF
   * 
   * **if can be null:**
   * true
   */
  relateType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 王建国
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateResidentUserResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * A栋
   */
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
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateSpaceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 11112
   */
  deptId?: number;
  /**
   * @example
   * true
   */
  isPropertyOwner?: boolean;
  /**
   * @example
   * {"startTime":1652358627106,"endTime":1652445027106}
   */
  memberDeptExtension?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 148********
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  name?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 性别
   */
  itemName?: string;
  /**
   * @example
   * 女
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 122222
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50
   */
  dayLimitTimes?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  extension?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  groupId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 排序Id
   */
  orderId?: number;
  /**
   * @example
   * rule_1
   */
  ruleCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 发动态
   */
  ruleName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  score?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
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
  /**
   * @example
   * 5345345
   */
  deptId?: number;
  /**
   * @example
   * "{\"startTime\":\"1654746593623\",\"endTime\":\"1656042593623\"}"
   */
  extension?: string;
  /**
   * @example
   * 1652683318162
   */
  gmtCreate?: number;
  /**
   * @example
   * 1652683318162
   */
  gmtModified?: number;
  /**
   * @example
   * true
   */
  isPropertyOwner?: boolean;
  /**
   * @example
   * 张工
   */
  name?: string;
  /**
   * @example
   * 1
   */
  status?: number;
  /**
   * @example
   * 312423423
   */
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
  /**
   * @example
   * 312423423
   */
  roleId?: number;
  /**
   * @example
   * 安保部经理
   */
  roleName?: string;
  /**
   * @example
   * SecurityManager
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

export class PagePointHistoryResponseBodyPointRecordList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1634630147
   */
  createAt?: number;
  /**
   * @example
   * rule_1
   */
  ruleCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 发动态
   */
  ruleName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  score?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 7653
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 11112
   */
  deptId?: number;
  /**
   * @example
   * true
   */
  isPropertyOwner?: boolean;
  /**
   * @example
   * {"startTime":1652358627106,"endTime":1652445027106}
   */
  memberDeptExtension?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 11123
   */
  oldDeptId?: number;
  /**
   * @example
   * 1
   */
  relateType?: string;
  /**
   * @example
   * 11123
   */
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
  /**
   * @example
   * 性别
   */
  itemName?: string;
  /**
   * @example
   * 女
   */
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
  /**
   * @example
   * 123.4
   */
  billingArea?: number;
  /**
   * @example
   * 123.4
   */
  buildingArea?: number;
  /**
   * @example
   * 当tagcode为Building的时候必填
   */
  buildingType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10005
   */
  deptId?: number;
  /**
   * @example
   * 12
   */
  floor?: string;
  /**
   * @example
   * 1
   */
  houseState?: number;
  /**
   * @example
   * 1
   */
  houseType?: number;
  /**
   * @example
   * 二单元
   */
  name?: string;
  parentDeptId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 空间类型标签code，House/Unit/Building/Partition
   */
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
   * 增加积分
   * 
   * @param request - AddPointRequest
   * @param headers - AddPointHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddPointResponse
   */
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

  /**
   * 增加积分
   * 
   * @param request - AddPointRequest
   * @returns AddPointResponse
   */
  async addPoint(request: AddPointRequest): Promise<AddPointResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPointHeaders({ });
    return await this.addPointWithOptions(request, headers, runtime);
  }

  /**
   * 增加组户
   * 
   * @param request - AddResidentDepartmentRequest
   * @param headers - AddResidentDepartmentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddResidentDepartmentResponse
   */
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

  /**
   * 增加组户
   * 
   * @param request - AddResidentDepartmentRequest
   * @returns AddResidentDepartmentResponse
   */
  async addResidentDepartment(request: AddResidentDepartmentRequest): Promise<AddResidentDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentDepartmentHeaders({ });
    return await this.addResidentDepartmentWithOptions(request, headers, runtime);
  }

  /**
   * 添加小区成员
   * 
   * @param request - AddResidentMemberRequest
   * @param headers - AddResidentMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddResidentMemberResponse
   */
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

  /**
   * 添加小区成员
   * 
   * @param request - AddResidentMemberRequest
   * @returns AddResidentMemberResponse
   */
  async addResidentMember(request: AddResidentMemberRequest): Promise<AddResidentMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentMemberHeaders({ });
    return await this.addResidentMemberWithOptions(request, headers, runtime);
  }

  /**
   * 新增居民
   * 
   * @param request - AddResidentUsersRequest
   * @param headers - AddResidentUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddResidentUsersResponse
   */
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

  /**
   * 新增居民
   * 
   * @param request - AddResidentUsersRequest
   * @returns AddResidentUsersResponse
   */
  async addResidentUsers(request: AddResidentUsersRequest): Promise<AddResidentUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddResidentUsersHeaders({ });
    return await this.addResidentUsersWithOptions(request, headers, runtime);
  }

  /**
   * 创建小区公告
   * 
   * @param request - CreateResidentBlackBoardRequest
   * @param headers - CreateResidentBlackBoardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateResidentBlackBoardResponse
   */
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

  /**
   * 创建小区公告
   * 
   * @param request - CreateResidentBlackBoardRequest
   * @returns CreateResidentBlackBoardResponse
   */
  async createResidentBlackBoard(request: CreateResidentBlackBoardRequest): Promise<CreateResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateResidentBlackBoardHeaders({ });
    return await this.createResidentBlackBoardWithOptions(request, headers, runtime);
  }

  /**
   * 创建小区空间，含分区，楼栋，单元，房屋等
   * 
   * @param request - CreateSpaceRequest
   * @param headers - CreateSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateSpaceResponse
   */
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

  /**
   * 创建小区空间，含分区，楼栋，单元，房屋等
   * 
   * @param request - CreateSpaceRequest
   * @returns CreateSpaceResponse
   */
  async createSpace(request: CreateSpaceRequest): Promise<CreateSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSpaceHeaders({ });
    return await this.createSpaceWithOptions(request, headers, runtime);
  }

  /**
   * 删除小区公告
   * 
   * @param request - DeleteResidentBlackBoardRequest
   * @param headers - DeleteResidentBlackBoardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteResidentBlackBoardResponse
   */
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

  /**
   * 删除小区公告
   * 
   * @param request - DeleteResidentBlackBoardRequest
   * @returns DeleteResidentBlackBoardResponse
   */
  async deleteResidentBlackBoard(request: DeleteResidentBlackBoardRequest): Promise<DeleteResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteResidentBlackBoardHeaders({ });
    return await this.deleteResidentBlackBoardWithOptions(request, headers, runtime);
  }

  /**
   * 删除组户信息
   * 
   * @param request - DeleteResidentDepartmentRequest
   * @param headers - DeleteResidentDepartmentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteResidentDepartmentResponse
   */
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

  /**
   * 删除组户信息
   * 
   * @param request - DeleteResidentDepartmentRequest
   * @returns DeleteResidentDepartmentResponse
   */
  async deleteResidentDepartment(request: DeleteResidentDepartmentRequest): Promise<DeleteResidentDepartmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteResidentDepartmentHeaders({ });
    return await this.deleteResidentDepartmentWithOptions(request, headers, runtime);
  }

  /**
   * 删除小区空间，含分区，楼栋，单元，房屋
   * 
   * @param request - DeleteSpaceRequest
   * @param headers - DeleteSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteSpaceResponse
   */
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

  /**
   * 删除小区空间，含分区，楼栋，单元，房屋
   * 
   * @param request - DeleteSpaceRequest
   * @returns DeleteSpaceResponse
   */
  async deleteSpace(request: DeleteSpaceRequest): Promise<DeleteSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSpaceHeaders({ });
    return await this.deleteSpaceWithOptions(request, headers, runtime);
  }

  /**
   * 获取指定群的openConversationId
   * 
   * @param request - GetConversationIdRequest
   * @param headers - GetConversationIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConversationIdResponse
   */
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

  /**
   * 获取指定群的openConversationId
   * 
   * @param request - GetConversationIdRequest
   * @returns GetConversationIdResponse
   */
  async getConversationId(request: GetConversationIdRequest): Promise<GetConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationIdHeaders({ });
    return await this.getConversationIdWithOptions(request, headers, runtime);
  }

  /**
   * 获取组织的行业类型
   * 
   * @param headers - GetIndustryTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetIndustryTypeResponse
   */
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

  /**
   * 获取组织的行业类型
   * @returns GetIndustryTypeResponse
   */
  async getIndustryType(): Promise<GetIndustryTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIndustryTypeHeaders({ });
    return await this.getIndustryTypeWithOptions(headers, runtime);
  }

  /**
   * 获取物业公司信息
   * 
   * @param request - GetPropertyInfoRequest
   * @param headers - GetPropertyInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPropertyInfoResponse
   */
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

  /**
   * 获取物业公司信息
   * 
   * @param request - GetPropertyInfoRequest
   * @returns GetPropertyInfoResponse
   */
  async getPropertyInfo(request: GetPropertyInfoRequest): Promise<GetPropertyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPropertyInfoHeaders({ });
    return await this.getPropertyInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取小区信息
   * 
   * @param request - GetResidentInfoRequest
   * @param headers - GetResidentInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetResidentInfoResponse
   */
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

  /**
   * 获取小区信息
   * 
   * @param request - GetResidentInfoRequest
   * @returns GetResidentInfoResponse
   */
  async getResidentInfo(request: GetResidentInfoRequest): Promise<GetResidentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentInfoHeaders({ });
    return await this.getResidentInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取小区人员信息，包括居民和物业人员
   * 
   * @param request - GetResidentMembersInfoRequest
   * @param headers - GetResidentMembersInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetResidentMembersInfoResponse
   */
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

  /**
   * 获取小区人员信息，包括居民和物业人员
   * 
   * @param request - GetResidentMembersInfoRequest
   * @returns GetResidentMembersInfoResponse
   */
  async getResidentMembersInfo(request: GetResidentMembersInfoRequest): Promise<GetResidentMembersInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetResidentMembersInfoHeaders({ });
    return await this.getResidentMembersInfoWithOptions(request, headers, runtime);
  }

  /**
   * 根据类型获取部门id
   * 
   * @param request - GetSpaceIdByTypeRequest
   * @param headers - GetSpaceIdByTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSpaceIdByTypeResponse
   */
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

  /**
   * 根据类型获取部门id
   * 
   * @param request - GetSpaceIdByTypeRequest
   * @returns GetSpaceIdByTypeResponse
   */
  async getSpaceIdByType(request: GetSpaceIdByTypeRequest): Promise<GetSpaceIdByTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceIdByTypeHeaders({ });
    return await this.getSpaceIdByTypeWithOptions(request, headers, runtime);
  }

  /**
   * 获取空间信息
   * 
   * @param request - GetSpacesInfoRequest
   * @param headers - GetSpacesInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSpacesInfoResponse
   */
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

  /**
   * 获取空间信息
   * 
   * @param request - GetSpacesInfoRequest
   * @returns GetSpacesInfoResponse
   */
  async getSpacesInfo(request: GetSpacesInfoRequest): Promise<GetSpacesInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpacesInfoHeaders({ });
    return await this.getSpacesInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取行业角色下的用户列表
   * 
   * @param request - ListIndustryRoleUsersRequest
   * @param headers - ListIndustryRoleUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListIndustryRoleUsersResponse
   */
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

  /**
   * 获取行业角色下的用户列表
   * 
   * @param request - ListIndustryRoleUsersRequest
   * @returns ListIndustryRoleUsersResponse
   */
  async listIndustryRoleUsers(request: ListIndustryRoleUsersRequest): Promise<ListIndustryRoleUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListIndustryRoleUsersHeaders({ });
    return await this.listIndustryRoleUsersWithOptions(request, headers, runtime);
  }

  /**
   * 查询组织维度配置的的积分规则
   * 
   * @param request - ListPointRulesRequest
   * @param headers - ListPointRulesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListPointRulesResponse
   */
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

  /**
   * 查询组织维度配置的的积分规则
   * 
   * @param request - ListPointRulesRequest
   * @returns ListPointRulesResponse
   */
  async listPointRules(request: ListPointRulesRequest): Promise<ListPointRulesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListPointRulesHeaders({ });
    return await this.listPointRulesWithOptions(request, headers, runtime);
  }

  /**
   * 获取子空间信息
   * 
   * @param request - ListSubSpaceRequest
   * @param headers - ListSubSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSubSpaceResponse
   */
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

  /**
   * 获取子空间信息
   * 
   * @param request - ListSubSpaceRequest
   * @returns ListSubSpaceResponse
   */
  async listSubSpace(request: ListSubSpaceRequest): Promise<ListSubSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSubSpaceHeaders({ });
    return await this.listSubSpaceWithOptions(request, headers, runtime);
  }

  /**
   * 获取未确认加入组织的用户
   * 
   * @param request - ListUncheckUsersRequest
   * @param headers - ListUncheckUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListUncheckUsersResponse
   */
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

  /**
   * 获取未确认加入组织的用户
   * 
   * @param request - ListUncheckUsersRequest
   * @returns ListUncheckUsersResponse
   */
  async listUncheckUsers(request: ListUncheckUsersRequest): Promise<ListUncheckUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUncheckUsersHeaders({ });
    return await this.listUncheckUsersWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户行业化角色
   * 
   * @param request - ListUserIndustryRolesRequest
   * @param headers - ListUserIndustryRolesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListUserIndustryRolesResponse
   */
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

  /**
   * 获取用户行业化角色
   * 
   * @param request - ListUserIndustryRolesRequest
   * @returns ListUserIndustryRolesResponse
   */
  async listUserIndustryRoles(request: ListUserIndustryRolesRequest): Promise<ListUserIndustryRolesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserIndustryRolesHeaders({ });
    return await this.listUserIndustryRolesWithOptions(request, headers, runtime);
  }

  /**
   * 查询数字区县居民积分流水
   * 
   * @param request - PagePointHistoryRequest
   * @param headers - PagePointHistoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PagePointHistoryResponse
   */
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

  /**
   * 查询数字区县居民积分流水
   * 
   * @param request - PagePointHistoryRequest
   * @returns PagePointHistoryResponse
   */
  async pagePointHistory(request: PagePointHistoryRequest): Promise<PagePointHistoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PagePointHistoryHeaders({ });
    return await this.pagePointHistoryWithOptions(request, headers, runtime);
  }

  /**
   * 从空间中删除人员
   * 
   * @param request - RemoveResidentMemberRequest
   * @param headers - RemoveResidentMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveResidentMemberResponse
   */
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

  /**
   * 从空间中删除人员
   * 
   * @param request - RemoveResidentMemberRequest
   * @returns RemoveResidentMemberResponse
   */
  async removeResidentMember(request: RemoveResidentMemberRequest): Promise<RemoveResidentMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveResidentMemberHeaders({ });
    return await this.removeResidentMemberWithOptions(request, headers, runtime);
  }

  /**
   * 从户内移除居民
   * 
   * @param request - RemoveResidentUserRequest
   * @param headers - RemoveResidentUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveResidentUserResponse
   */
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

  /**
   * 从户内移除居民
   * 
   * @param request - RemoveResidentUserRequest
   * @returns RemoveResidentUserResponse
   */
  async removeResidentUser(request: RemoveResidentUserRequest): Promise<RemoveResidentUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveResidentUserHeaders({ });
    return await this.removeResidentUserWithOptions(request, headers, runtime);
  }

  /**
   * 搜索指定人员
   * 
   * @param request - SearchResidentRequest
   * @param headers - SearchResidentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchResidentResponse
   */
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

  /**
   * 搜索指定人员
   * 
   * @param request - SearchResidentRequest
   * @returns SearchResidentResponse
   */
  async searchResident(request: SearchResidentRequest): Promise<SearchResidentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchResidentHeaders({ });
    return await this.searchResidentWithOptions(request, headers, runtime);
  }

  /**
   * 更新组信息
   * 
   * @param request - UpdateResideceGroupRequest
   * @param headers - UpdateResideceGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateResideceGroupResponse
   */
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

  /**
   * 更新组信息
   * 
   * @param request - UpdateResideceGroupRequest
   * @returns UpdateResideceGroupResponse
   */
  async updateResideceGroup(request: UpdateResideceGroupRequest): Promise<UpdateResideceGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResideceGroupHeaders({ });
    return await this.updateResideceGroupWithOptions(request, headers, runtime);
  }

  /**
   * 更新户信息
   * 
   * @param request - UpdateResidenceRequest
   * @param headers - UpdateResidenceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateResidenceResponse
   */
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

  /**
   * 更新户信息
   * 
   * @param request - UpdateResidenceRequest
   * @returns UpdateResidenceResponse
   */
  async updateResidence(request: UpdateResidenceRequest): Promise<UpdateResidenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidenceHeaders({ });
    return await this.updateResidenceWithOptions(request, headers, runtime);
  }

  /**
   * 更新小区公告
   * 
   * @param request - UpdateResidentBlackBoardRequest
   * @param headers - UpdateResidentBlackBoardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateResidentBlackBoardResponse
   */
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

  /**
   * 更新小区公告
   * 
   * @param request - UpdateResidentBlackBoardRequest
   * @returns UpdateResidentBlackBoardResponse
   */
  async updateResidentBlackBoard(request: UpdateResidentBlackBoardRequest): Promise<UpdateResidentBlackBoardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentBlackBoardHeaders({ });
    return await this.updateResidentBlackBoardWithOptions(request, headers, runtime);
  }

  /**
   * 更新小区信息
   * 
   * @param request - UpdateResidentInfoRequest
   * @param headers - UpdateResidentInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateResidentInfoResponse
   */
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

  /**
   * 更新小区信息
   * 
   * @param request - UpdateResidentInfoRequest
   * @returns UpdateResidentInfoResponse
   */
  async updateResidentInfo(request: UpdateResidentInfoRequest): Promise<UpdateResidentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentInfoHeaders({ });
    return await this.updateResidentInfoWithOptions(request, headers, runtime);
  }

  /**
   * 更新小区成员
   * 
   * @param request - UpdateResidentMemberRequest
   * @param headers - UpdateResidentMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateResidentMemberResponse
   */
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

  /**
   * 更新小区成员
   * 
   * @param request - UpdateResidentMemberRequest
   * @returns UpdateResidentMemberResponse
   */
  async updateResidentMember(request: UpdateResidentMemberRequest): Promise<UpdateResidentMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentMemberHeaders({ });
    return await this.updateResidentMemberWithOptions(request, headers, runtime);
  }

  /**
   * 更新居民信息
   * 
   * @param request - UpdateResidentUserRequest
   * @param headers - UpdateResidentUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateResidentUserResponse
   */
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

  /**
   * 更新居民信息
   * 
   * @param request - UpdateResidentUserRequest
   * @returns UpdateResidentUserResponse
   */
  async updateResidentUser(request: UpdateResidentUserRequest): Promise<UpdateResidentUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateResidentUserHeaders({ });
    return await this.updateResidentUserWithOptions(request, headers, runtime);
  }

  /**
   * 更新小区空间，含分区，楼栋，单元，房屋等信息
   * 
   * @param request - UpdateSpaceRequest
   * @param headers - UpdateSpaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateSpaceResponse
   */
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

  /**
   * 更新小区空间，含分区，楼栋，单元，房屋等信息
   * 
   * @param request - UpdateSpaceRequest
   * @returns UpdateSpaceResponse
   */
  async updateSpace(request: UpdateSpaceRequest): Promise<UpdateSpaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSpaceHeaders({ });
    return await this.updateSpaceWithOptions(request, headers, runtime);
  }

}
