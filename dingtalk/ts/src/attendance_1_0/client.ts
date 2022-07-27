// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddLeaveTypeHeaders extends $tea.Model {
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

export class AddLeaveTypeRequest extends $tea.Model {
  bizType?: string;
  extras?: string;
  hoursInPerDay?: number;
  leaveCertificate?: AddLeaveTypeRequestLeaveCertificate;
  leaveName?: string;
  leaveViewUnit?: string;
  naturalDayLeave?: boolean;
  submitTimeRule?: AddLeaveTypeRequestSubmitTimeRule;
  visibilityRules?: AddLeaveTypeRequestVisibilityRules[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      extras: 'extras',
      hoursInPerDay: 'hoursInPerDay',
      leaveCertificate: 'leaveCertificate',
      leaveName: 'leaveName',
      leaveViewUnit: 'leaveViewUnit',
      naturalDayLeave: 'naturalDayLeave',
      submitTimeRule: 'submitTimeRule',
      visibilityRules: 'visibilityRules',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      extras: 'string',
      hoursInPerDay: 'number',
      leaveCertificate: AddLeaveTypeRequestLeaveCertificate,
      leaveName: 'string',
      leaveViewUnit: 'string',
      naturalDayLeave: 'boolean',
      submitTimeRule: AddLeaveTypeRequestSubmitTimeRule,
      visibilityRules: { 'type': 'array', 'itemType': AddLeaveTypeRequestVisibilityRules },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeResponseBody extends $tea.Model {
  result?: AddLeaveTypeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AddLeaveTypeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddLeaveTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddLeaveTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesAddHeaders extends $tea.Model {
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

export class AttendanceBleDevicesAddRequest extends $tea.Model {
  deviceIdList?: number[];
  groupKey?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      deviceIdList: 'deviceIdList',
      groupKey: 'groupKey',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceIdList: { 'type': 'array', 'itemType': 'number' },
      groupKey: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesAddResponseBody extends $tea.Model {
  errorList?: AttendanceBleDevicesAddResponseBodyErrorList[];
  successList?: AttendanceBleDevicesAddResponseBodySuccessList[];
  static names(): { [key: string]: string } {
    return {
      errorList: 'errorList',
      successList: 'successList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorList: { 'type': 'array', 'itemType': AttendanceBleDevicesAddResponseBodyErrorList },
      successList: { 'type': 'array', 'itemType': AttendanceBleDevicesAddResponseBodySuccessList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesAddResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AttendanceBleDevicesAddResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AttendanceBleDevicesAddResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesQueryHeaders extends $tea.Model {
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

export class AttendanceBleDevicesQueryRequest extends $tea.Model {
  groupKey?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      groupKey: 'groupKey',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupKey: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesQueryResponseBody extends $tea.Model {
  result?: AttendanceBleDevicesQueryResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': AttendanceBleDevicesQueryResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesQueryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AttendanceBleDevicesQueryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AttendanceBleDevicesQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesRemoveHeaders extends $tea.Model {
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

export class AttendanceBleDevicesRemoveRequest extends $tea.Model {
  deviceIdList?: number[];
  groupKey?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      deviceIdList: 'deviceIdList',
      groupKey: 'groupKey',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceIdList: { 'type': 'array', 'itemType': 'number' },
      groupKey: 'string',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesRemoveResponseBody extends $tea.Model {
  errorList?: AttendanceBleDevicesRemoveResponseBodyErrorList[];
  successList?: number[];
  static names(): { [key: string]: string } {
    return {
      errorList: 'errorList',
      successList: 'successList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorList: { 'type': 'array', 'itemType': AttendanceBleDevicesRemoveResponseBodyErrorList },
      successList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesRemoveResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AttendanceBleDevicesRemoveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AttendanceBleDevicesRemoveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckClosingAccountHeaders extends $tea.Model {
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

export class CheckClosingAccountRequest extends $tea.Model {
  bizCode?: string;
  userIds?: string[];
  userTimeRange?: CheckClosingAccountRequestUserTimeRange[];
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      userIds: 'userIds',
      userTimeRange: 'userTimeRange',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
      userTimeRange: { 'type': 'array', 'itemType': CheckClosingAccountRequestUserTimeRange },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckClosingAccountResponseBody extends $tea.Model {
  code?: string;
  mesage?: string;
  pass?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      mesage: 'mesage',
      pass: 'pass',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      mesage: 'string',
      pass: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckClosingAccountResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CheckClosingAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CheckClosingAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckWritePermissionHeaders extends $tea.Model {
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

export class CheckWritePermissionRequest extends $tea.Model {
  category?: string;
  entityIds?: number[];
  opUserId?: string;
  resourceKey?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      entityIds: 'entityIds',
      opUserId: 'opUserId',
      resourceKey: 'resourceKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      entityIds: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
      resourceKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckWritePermissionResponseBody extends $tea.Model {
  entityPermissionMap?: { [key: string]: boolean };
  static names(): { [key: string]: string } {
    return {
      entityPermissionMap: 'entityPermissionMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      entityPermissionMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'boolean' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckWritePermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CheckWritePermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CheckWritePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApproveHeaders extends $tea.Model {
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

export class CreateApproveRequest extends $tea.Model {
  approveId?: string;
  opUserid?: string;
  punchParam?: CreateApproveRequestPunchParam;
  subType?: string;
  tagName?: string;
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      approveId: 'approveId',
      opUserid: 'opUserid',
      punchParam: 'punchParam',
      subType: 'subType',
      tagName: 'tagName',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveId: 'string',
      opUserid: 'string',
      punchParam: CreateApproveRequestPunchParam,
      subType: 'string',
      tagName: 'string',
      userid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApproveResponseBody extends $tea.Model {
  dingtalkApproveId?: string;
  static names(): { [key: string]: string } {
    return {
      dingtalkApproveId: 'dingtalkApproveId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingtalkApproveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApproveResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateApproveResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateApproveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWaterMarkTemplateHeaders extends $tea.Model {
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

export class DeleteWaterMarkTemplateRequest extends $tea.Model {
  formCode?: string;
  formContent?: string;
  openConversationId?: string;
  systemTemplate?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      formContent: 'formContent',
      openConversationId: 'openConversationId',
      systemTemplate: 'systemTemplate',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      formContent: 'string',
      openConversationId: 'string',
      systemTemplate: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteWaterMarkTemplateResponseBody extends $tea.Model {
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

export class DeleteWaterMarkTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteWaterMarkTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteWaterMarkTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DingTalkSecurityCheckHeaders extends $tea.Model {
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

export class DingTalkSecurityCheckRequest extends $tea.Model {
  clientVer?: string;
  platform?: string;
  platformVer?: string;
  sec?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      clientVer: 'clientVer',
      platform: 'platform',
      platformVer: 'platformVer',
      sec: 'sec',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clientVer: 'string',
      platform: 'string',
      platformVer: 'string',
      sec: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DingTalkSecurityCheckResponseBody extends $tea.Model {
  result?: DingTalkSecurityCheckResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: DingTalkSecurityCheckResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DingTalkSecurityCheckResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DingTalkSecurityCheckResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DingTalkSecurityCheckResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdjustmentsHeaders extends $tea.Model {
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

export class GetAdjustmentsRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdjustmentsResponseBody extends $tea.Model {
  result?: GetAdjustmentsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetAdjustmentsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdjustmentsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAdjustmentsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAdjustmentsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckInSchemaTemplateHeaders extends $tea.Model {
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

export class GetCheckInSchemaTemplateRequest extends $tea.Model {
  bizCode?: string;
  openConversationId?: string;
  sceneCode?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      openConversationId: 'openConversationId',
      sceneCode: 'sceneCode',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      openConversationId: 'string',
      sceneCode: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckInSchemaTemplateResponseBody extends $tea.Model {
  result?: GetCheckInSchemaTemplateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetCheckInSchemaTemplateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckInSchemaTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCheckInSchemaTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCheckInSchemaTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClosingAccountsHeaders extends $tea.Model {
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

export class GetClosingAccountsRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClosingAccountsResponseBody extends $tea.Model {
  result?: GetClosingAccountsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetClosingAccountsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClosingAccountsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetClosingAccountsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetClosingAccountsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveTypeHeaders extends $tea.Model {
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

export class GetLeaveTypeRequest extends $tea.Model {
  opUserId?: string;
  vacationSource?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      vacationSource: 'vacationSource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      vacationSource: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveTypeResponseBody extends $tea.Model {
  result?: GetLeaveTypeResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetLeaveTypeResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetLeaveTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetLeaveTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineHeaders extends $tea.Model {
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

export class GetMachineResponseBody extends $tea.Model {
  result?: GetMachineResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetMachineResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMachineResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMachineResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineUserHeaders extends $tea.Model {
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

export class GetMachineUserRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineUserResponseBody extends $tea.Model {
  result?: GetMachineUserResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetMachineUserResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMachineUserResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMachineUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOvertimeSettingHeaders extends $tea.Model {
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

export class GetOvertimeSettingRequest extends $tea.Model {
  overtimeSettingIds?: number[];
  static names(): { [key: string]: string } {
    return {
      overtimeSettingIds: 'overtimeSettingIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      overtimeSettingIds: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOvertimeSettingResponseBody extends $tea.Model {
  result?: GetOvertimeSettingResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetOvertimeSettingResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOvertimeSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOvertimeSettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOvertimeSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleOvertimeSettingHeaders extends $tea.Model {
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

export class GetSimpleOvertimeSettingRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleOvertimeSettingResponseBody extends $tea.Model {
  result?: GetSimpleOvertimeSettingResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetSimpleOvertimeSettingResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleOvertimeSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSimpleOvertimeSettingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSimpleOvertimeSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysHeaders extends $tea.Model {
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

export class GetUserHolidaysRequest extends $tea.Model {
  userIds?: string[];
  workDateFrom?: number;
  workDateTo?: number;
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
      workDateFrom: 'workDateFrom',
      workDateTo: 'workDateTo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
      workDateFrom: 'number',
      workDateTo: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBody extends $tea.Model {
  result?: GetUserHolidaysResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetUserHolidaysResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserHolidaysResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserHolidaysResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitAndGetLeaveALlocationQuotasHeaders extends $tea.Model {
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

export class InitAndGetLeaveALlocationQuotasRequest extends $tea.Model {
  leaveCode?: string;
  opUserId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      leaveCode: 'leaveCode',
      opUserId: 'opUserId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      leaveCode: 'string',
      opUserId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitAndGetLeaveALlocationQuotasResponseBody extends $tea.Model {
  result?: InitAndGetLeaveALlocationQuotasResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': InitAndGetLeaveALlocationQuotasResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitAndGetLeaveALlocationQuotasResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: InitAndGetLeaveALlocationQuotasResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: InitAndGetLeaveALlocationQuotasResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyWaterMarkTemplateHeaders extends $tea.Model {
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

export class ModifyWaterMarkTemplateRequest extends $tea.Model {
  formCode?: string;
  icon?: string;
  layoutDesignId?: string;
  schemaContent?: string;
  title?: string;
  waterMarkId?: string;
  openConversationId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      icon: 'icon',
      layoutDesignId: 'layoutDesignId',
      schemaContent: 'schemaContent',
      title: 'title',
      waterMarkId: 'waterMarkId',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      icon: 'string',
      layoutDesignId: 'string',
      schemaContent: 'string',
      title: 'string',
      waterMarkId: 'string',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyWaterMarkTemplateResponseBody extends $tea.Model {
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

export class ModifyWaterMarkTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ModifyWaterMarkTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ModifyWaterMarkTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveCreateHeaders extends $tea.Model {
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

export class ProcessApproveCreateRequest extends $tea.Model {
  approveId?: string;
  opUserId?: string;
  punchParam?: ProcessApproveCreateRequestPunchParam;
  subType?: string;
  tagName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      approveId: 'approveId',
      opUserId: 'opUserId',
      punchParam: 'punchParam',
      subType: 'subType',
      tagName: 'tagName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveId: 'string',
      opUserId: 'string',
      punchParam: ProcessApproveCreateRequestPunchParam,
      subType: 'string',
      tagName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveCreateResponseBody extends $tea.Model {
  result?: ProcessApproveCreateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ProcessApproveCreateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveCreateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ProcessApproveCreateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ProcessApproveCreateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCustomWaterMarkTemplateHeaders extends $tea.Model {
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

export class SaveCustomWaterMarkTemplateRequest extends $tea.Model {
  bizCode?: string;
  icon?: string;
  layoutDesignId?: string;
  sceneCode?: string;
  schemaContent?: string;
  title?: string;
  openConversationId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      icon: 'icon',
      layoutDesignId: 'layoutDesignId',
      sceneCode: 'sceneCode',
      schemaContent: 'schemaContent',
      title: 'title',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      icon: 'string',
      layoutDesignId: 'string',
      sceneCode: 'string',
      schemaContent: 'string',
      title: 'string',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCustomWaterMarkTemplateResponseBody extends $tea.Model {
  result?: SaveCustomWaterMarkTemplateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SaveCustomWaterMarkTemplateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCustomWaterMarkTemplateResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveCustomWaterMarkTemplateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveCustomWaterMarkTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncScheduleInfoHeaders extends $tea.Model {
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

export class SyncScheduleInfoRequest extends $tea.Model {
  opUserId?: string;
  scheduleInfos?: SyncScheduleInfoRequestScheduleInfos[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      scheduleInfos: 'scheduleInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      scheduleInfos: { 'type': 'array', 'itemType': SyncScheduleInfoRequestScheduleInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncScheduleInfoResponse extends $tea.Model {
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

export class UpdateLeaveTypeHeaders extends $tea.Model {
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

export class UpdateLeaveTypeRequest extends $tea.Model {
  bizType?: string;
  extras?: string;
  hoursInPerDay?: number;
  leaveCertificate?: UpdateLeaveTypeRequestLeaveCertificate;
  leaveCode?: string;
  leaveName?: string;
  leaveViewUnit?: string;
  naturalDayLeave?: boolean;
  submitTimeRule?: UpdateLeaveTypeRequestSubmitTimeRule;
  visibilityRules?: UpdateLeaveTypeRequestVisibilityRules[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      extras: 'extras',
      hoursInPerDay: 'hoursInPerDay',
      leaveCertificate: 'leaveCertificate',
      leaveCode: 'leaveCode',
      leaveName: 'leaveName',
      leaveViewUnit: 'leaveViewUnit',
      naturalDayLeave: 'naturalDayLeave',
      submitTimeRule: 'submitTimeRule',
      visibilityRules: 'visibilityRules',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      extras: 'string',
      hoursInPerDay: 'number',
      leaveCertificate: UpdateLeaveTypeRequestLeaveCertificate,
      leaveCode: 'string',
      leaveName: 'string',
      leaveViewUnit: 'string',
      naturalDayLeave: 'boolean',
      submitTimeRule: UpdateLeaveTypeRequestSubmitTimeRule,
      visibilityRules: { 'type': 'array', 'itemType': UpdateLeaveTypeRequestVisibilityRules },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeResponseBody extends $tea.Model {
  result?: UpdateLeaveTypeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateLeaveTypeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateLeaveTypeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateLeaveTypeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResultDurationSettingsValue extends $tea.Model {
  calcType?: number;
  durationType?: number;
  overtimeRedress?: boolean;
  settings?: { [key: string]: any };
  overtimeRedressBy?: string;
  vacationRate?: number;
  skipTime?: string;
  skipTimeByFrames?: ResultDurationSettingsValueSkipTimeByFrames[];
  skipTimeByDurations?: ResultDurationSettingsValueSkipTimeByDurations[];
  holidayPlanOvertimeRedress?: boolean;
  holidayPlanOvertimeRedressBy?: string;
  holidayPlanVacationRate?: number;
  static names(): { [key: string]: string } {
    return {
      calcType: 'calcType',
      durationType: 'durationType',
      overtimeRedress: 'overtimeRedress',
      settings: 'settings',
      overtimeRedressBy: 'overtimeRedressBy',
      vacationRate: 'vacationRate',
      skipTime: 'skipTime',
      skipTimeByFrames: 'skipTimeByFrames',
      skipTimeByDurations: 'skipTimeByDurations',
      holidayPlanOvertimeRedress: 'holidayPlanOvertimeRedress',
      holidayPlanOvertimeRedressBy: 'holidayPlanOvertimeRedressBy',
      holidayPlanVacationRate: 'holidayPlanVacationRate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      calcType: 'number',
      durationType: 'number',
      overtimeRedress: 'boolean',
      settings: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      overtimeRedressBy: 'string',
      vacationRate: 'number',
      skipTime: 'string',
      skipTimeByFrames: { 'type': 'array', 'itemType': ResultDurationSettingsValueSkipTimeByFrames },
      skipTimeByDurations: { 'type': 'array', 'itemType': ResultDurationSettingsValueSkipTimeByDurations },
      holidayPlanOvertimeRedress: 'boolean',
      holidayPlanOvertimeRedressBy: 'string',
      holidayPlanVacationRate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeRequestLeaveCertificate extends $tea.Model {
  duration?: number;
  enable?: boolean;
  promptInformation?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      enable: 'enable',
      promptInformation: 'promptInformation',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      enable: 'boolean',
      promptInformation: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeRequestSubmitTimeRule extends $tea.Model {
  enableTimeLimit?: boolean;
  timeType?: string;
  timeUnit?: string;
  timeValue?: number;
  static names(): { [key: string]: string } {
    return {
      enableTimeLimit: 'enableTimeLimit',
      timeType: 'timeType',
      timeUnit: 'timeUnit',
      timeValue: 'timeValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableTimeLimit: 'boolean',
      timeType: 'string',
      timeUnit: 'string',
      timeValue: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeRequestVisibilityRules extends $tea.Model {
  type?: string;
  visible?: string[];
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      visible: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeResponseBodyResultLeaveCertificate extends $tea.Model {
  duration?: number;
  enable?: boolean;
  promptInformation?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      enable: 'enable',
      promptInformation: 'promptInformation',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      enable: 'boolean',
      promptInformation: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeResponseBodyResultSubmitTimeRule extends $tea.Model {
  enableTimeLimit?: boolean;
  timeType?: string;
  timeUnit?: string;
  timeValue?: number;
  static names(): { [key: string]: string } {
    return {
      enableTimeLimit: 'enableTimeLimit',
      timeType: 'timeType',
      timeUnit: 'timeUnit',
      timeValue: 'timeValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableTimeLimit: 'boolean',
      timeType: 'string',
      timeUnit: 'string',
      timeValue: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeResponseBodyResultVisibilityRules extends $tea.Model {
  type?: string;
  visible?: string[];
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      visible: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLeaveTypeResponseBodyResult extends $tea.Model {
  bizType?: string;
  hoursInPerDay?: number;
  leaveCertificate?: AddLeaveTypeResponseBodyResultLeaveCertificate;
  leaveCode?: string;
  leaveName?: string;
  leaveViewUnit?: string;
  naturalDayLeave?: boolean;
  submitTimeRule?: AddLeaveTypeResponseBodyResultSubmitTimeRule;
  visibilityRules?: AddLeaveTypeResponseBodyResultVisibilityRules[];
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      hoursInPerDay: 'hoursInPerDay',
      leaveCertificate: 'leaveCertificate',
      leaveCode: 'leaveCode',
      leaveName: 'leaveName',
      leaveViewUnit: 'leaveViewUnit',
      naturalDayLeave: 'naturalDayLeave',
      submitTimeRule: 'submitTimeRule',
      visibilityRules: 'visibilityRules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      hoursInPerDay: 'number',
      leaveCertificate: AddLeaveTypeResponseBodyResultLeaveCertificate,
      leaveCode: 'string',
      leaveName: 'string',
      leaveViewUnit: 'string',
      naturalDayLeave: 'boolean',
      submitTimeRule: AddLeaveTypeResponseBodyResultSubmitTimeRule,
      visibilityRules: { 'type': 'array', 'itemType': AddLeaveTypeResponseBodyResultVisibilityRules },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesAddResponseBodyErrorListFailureList extends $tea.Model {
  deviceId?: number;
  deviceName?: string;
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'number',
      deviceName: 'string',
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesAddResponseBodyErrorList extends $tea.Model {
  code?: string;
  failureList?: AttendanceBleDevicesAddResponseBodyErrorListFailureList[];
  msg?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      failureList: 'failureList',
      msg: 'msg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      failureList: { 'type': 'array', 'itemType': AttendanceBleDevicesAddResponseBodyErrorListFailureList },
      msg: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesAddResponseBodySuccessList extends $tea.Model {
  deviceId?: number;
  deviceName?: string;
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'number',
      deviceName: 'string',
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesQueryResponseBodyResult extends $tea.Model {
  deviceId?: number;
  deviceName?: string;
  sn?: string;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      sn: 'sn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'number',
      deviceName: 'string',
      sn: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AttendanceBleDevicesRemoveResponseBodyErrorList extends $tea.Model {
  code?: string;
  failureList?: number[];
  msg?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      failureList: 'failureList',
      msg: 'msg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      failureList: { 'type': 'array', 'itemType': 'number' },
      msg: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckClosingAccountRequestUserTimeRange extends $tea.Model {
  endTime?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateApproveRequestPunchParam extends $tea.Model {
  positionId?: string;
  positionName?: string;
  positionType?: string;
  punchTime?: number;
  static names(): { [key: string]: string } {
    return {
      positionId: 'positionId',
      positionName: 'positionName',
      positionType: 'positionType',
      punchTime: 'punchTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      positionId: 'string',
      positionName: 'string',
      positionType: 'string',
      punchTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DingTalkSecurityCheckResponseBodyResult extends $tea.Model {
  hasRisk?: boolean;
  riskInfo?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      hasRisk: 'hasRisk',
      riskInfo: 'riskInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasRisk: 'boolean',
      riskInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdjustmentsResponseBodyResultItems extends $tea.Model {
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

export class GetAdjustmentsResponseBodyResult extends $tea.Model {
  items?: GetAdjustmentsResponseBodyResultItems[];
  pageNumber?: number;
  totalPage?: number;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      pageNumber: 'pageNumber',
      totalPage: 'totalPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': GetAdjustmentsResponseBodyResultItems },
      pageNumber: 'number',
      totalPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels extends $tea.Model {
  canModify?: boolean;
  formCode?: string;
  icon?: string;
  layoutDesign?: string;
  sceneCode?: string;
  schemaContent?: string;
  suiteKey?: string;
  systemTemplate?: boolean;
  title?: string;
  waterMarkId?: string;
  static names(): { [key: string]: string } {
    return {
      canModify: 'canModify',
      formCode: 'formCode',
      icon: 'icon',
      layoutDesign: 'layoutDesign',
      sceneCode: 'sceneCode',
      schemaContent: 'schemaContent',
      suiteKey: 'suiteKey',
      systemTemplate: 'systemTemplate',
      title: 'title',
      waterMarkId: 'waterMarkId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      canModify: 'boolean',
      formCode: 'string',
      icon: 'string',
      layoutDesign: 'string',
      sceneCode: 'string',
      schemaContent: 'string',
      suiteKey: 'string',
      systemTemplate: 'boolean',
      title: 'string',
      waterMarkId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckInSchemaTemplateResponseBodyResult extends $tea.Model {
  bizCode?: string;
  canModifyAndAddTemplate?: boolean;
  conversationAdmin?: boolean;
  customTemplateMaxSize?: number;
  openConversationId?: string;
  showStat?: boolean;
  templateDegrade?: boolean;
  waterMarkTemplateModels?: GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels[];
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      canModifyAndAddTemplate: 'canModifyAndAddTemplate',
      conversationAdmin: 'conversationAdmin',
      customTemplateMaxSize: 'customTemplateMaxSize',
      openConversationId: 'openConversationId',
      showStat: 'showStat',
      templateDegrade: 'templateDegrade',
      waterMarkTemplateModels: 'waterMarkTemplateModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      canModifyAndAddTemplate: 'boolean',
      conversationAdmin: 'boolean',
      customTemplateMaxSize: 'number',
      openConversationId: 'string',
      showStat: 'boolean',
      templateDegrade: 'boolean',
      waterMarkTemplateModels: { 'type': 'array', 'itemType': GetCheckInSchemaTemplateResponseBodyResultWaterMarkTemplateModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClosingAccountsResponseBodyResultClosingAccountModel extends $tea.Model {
  closingDay?: number;
  closingHourMinutes?: number;
  endDay?: number;
  endMonth?: number;
  startDay?: number;
  startMonth?: number;
  static names(): { [key: string]: string } {
    return {
      closingDay: 'closingDay',
      closingHourMinutes: 'closingHourMinutes',
      endDay: 'endDay',
      endMonth: 'endMonth',
      startDay: 'startDay',
      startMonth: 'startMonth',
    };
  }

  static types(): { [key: string]: any } {
    return {
      closingDay: 'number',
      closingHourMinutes: 'number',
      endDay: 'number',
      endMonth: 'number',
      startDay: 'number',
      startMonth: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClosingAccountsResponseBodyResultUnsealClosingAccountModel extends $tea.Model {
  invalidTimeStamp?: number;
  static names(): { [key: string]: string } {
    return {
      invalidTimeStamp: 'invalidTimeStamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invalidTimeStamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClosingAccountsResponseBodyResult extends $tea.Model {
  closingAccountModel?: GetClosingAccountsResponseBodyResultClosingAccountModel;
  switchOn?: boolean;
  unsealClosingAccountModel?: GetClosingAccountsResponseBodyResultUnsealClosingAccountModel;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      closingAccountModel: 'closingAccountModel',
      switchOn: 'switchOn',
      unsealClosingAccountModel: 'unsealClosingAccountModel',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      closingAccountModel: GetClosingAccountsResponseBodyResultClosingAccountModel,
      switchOn: 'boolean',
      unsealClosingAccountModel: GetClosingAccountsResponseBodyResultUnsealClosingAccountModel,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveTypeResponseBodyResultLeaveCertificate extends $tea.Model {
  duration?: number;
  enable?: boolean;
  promptInformation?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      enable: 'enable',
      promptInformation: 'promptInformation',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      enable: 'boolean',
      promptInformation: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveTypeResponseBodyResultSubmitTimeRule extends $tea.Model {
  enableTimeLimit?: boolean;
  timeType?: string;
  timeUnit?: string;
  timeValue?: number;
  static names(): { [key: string]: string } {
    return {
      enableTimeLimit: 'enableTimeLimit',
      timeType: 'timeType',
      timeUnit: 'timeUnit',
      timeValue: 'timeValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableTimeLimit: 'boolean',
      timeType: 'string',
      timeUnit: 'string',
      timeValue: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveTypeResponseBodyResultVisibilityRules extends $tea.Model {
  type?: string;
  visible?: string[];
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      visible: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveTypeResponseBodyResult extends $tea.Model {
  bizType?: string;
  hoursInPerDay?: number;
  leaveCertificate?: GetLeaveTypeResponseBodyResultLeaveCertificate;
  leaveCode?: string;
  leaveName?: string;
  leaveViewUnit?: string;
  naturalDayLeave?: boolean;
  source?: string;
  submitTimeRule?: GetLeaveTypeResponseBodyResultSubmitTimeRule;
  validityType?: string;
  validityValue?: string;
  visibilityRules?: GetLeaveTypeResponseBodyResultVisibilityRules[];
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      hoursInPerDay: 'hoursInPerDay',
      leaveCertificate: 'leaveCertificate',
      leaveCode: 'leaveCode',
      leaveName: 'leaveName',
      leaveViewUnit: 'leaveViewUnit',
      naturalDayLeave: 'naturalDayLeave',
      source: 'source',
      submitTimeRule: 'submitTimeRule',
      validityType: 'validityType',
      validityValue: 'validityValue',
      visibilityRules: 'visibilityRules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      hoursInPerDay: 'number',
      leaveCertificate: GetLeaveTypeResponseBodyResultLeaveCertificate,
      leaveCode: 'string',
      leaveName: 'string',
      leaveViewUnit: 'string',
      naturalDayLeave: 'boolean',
      source: 'string',
      submitTimeRule: GetLeaveTypeResponseBodyResultSubmitTimeRule,
      validityType: 'string',
      validityValue: 'string',
      visibilityRules: { 'type': 'array', 'itemType': GetLeaveTypeResponseBodyResultVisibilityRules },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineResponseBodyResultMachineBluetoothVO extends $tea.Model {
  address?: string;
  bluetoothCheckWithFace?: boolean;
  bluetoothDistanceMode?: string;
  bluetoothDistanceModeDesc?: string;
  bluetoothValue?: boolean;
  latitude?: number;
  limitUserDeviceCount?: boolean;
  longitude?: number;
  monitorLocationAbnormal?: boolean;
  userDeviceCount?: number;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      bluetoothCheckWithFace: 'bluetoothCheckWithFace',
      bluetoothDistanceMode: 'bluetoothDistanceMode',
      bluetoothDistanceModeDesc: 'bluetoothDistanceModeDesc',
      bluetoothValue: 'bluetoothValue',
      latitude: 'latitude',
      limitUserDeviceCount: 'limitUserDeviceCount',
      longitude: 'longitude',
      monitorLocationAbnormal: 'monitorLocationAbnormal',
      userDeviceCount: 'userDeviceCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      bluetoothCheckWithFace: 'boolean',
      bluetoothDistanceMode: 'string',
      bluetoothDistanceModeDesc: 'string',
      bluetoothValue: 'boolean',
      latitude: 'number',
      limitUserDeviceCount: 'boolean',
      longitude: 'number',
      monitorLocationAbnormal: 'boolean',
      userDeviceCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineResponseBodyResult extends $tea.Model {
  atmManagerList?: string[];
  devId?: number;
  deviceId?: string;
  deviceName?: string;
  deviceSn?: string;
  machineBluetoothVO?: GetMachineResponseBodyResultMachineBluetoothVO;
  maxFace?: number;
  netStatus?: string;
  productName?: string;
  productVersion?: string;
  voiceMode?: number;
  static names(): { [key: string]: string } {
    return {
      atmManagerList: 'atmManagerList',
      devId: 'devId',
      deviceId: 'deviceId',
      deviceName: 'deviceName',
      deviceSn: 'deviceSn',
      machineBluetoothVO: 'machineBluetoothVO',
      maxFace: 'maxFace',
      netStatus: 'netStatus',
      productName: 'productName',
      productVersion: 'productVersion',
      voiceMode: 'voiceMode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atmManagerList: { 'type': 'array', 'itemType': 'string' },
      devId: 'number',
      deviceId: 'string',
      deviceName: 'string',
      deviceSn: 'string',
      machineBluetoothVO: GetMachineResponseBodyResultMachineBluetoothVO,
      maxFace: 'number',
      netStatus: 'string',
      productName: 'string',
      productVersion: 'string',
      voiceMode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineUserResponseBodyResultUserList extends $tea.Model {
  hasFace?: boolean;
  name?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      hasFace: 'hasFace',
      name: 'name',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasFace: 'boolean',
      name: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMachineUserResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  nextToken?: string;
  userList?: GetMachineUserResponseBodyResultUserList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      userList: { 'type': 'array', 'itemType': GetMachineUserResponseBodyResultUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOvertimeSettingResponseBodyResultOvertimeDivisions extends $tea.Model {
  nextDayType?: string;
  previousDayType?: string;
  timeSplitPoint?: string;
  static names(): { [key: string]: string } {
    return {
      nextDayType: 'nextDayType',
      previousDayType: 'previousDayType',
      timeSplitPoint: 'timeSplitPoint',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextDayType: 'string',
      previousDayType: 'string',
      timeSplitPoint: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOvertimeSettingResponseBodyResultWarningSettings extends $tea.Model {
  action?: string;
  threshold?: number;
  time?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      threshold: 'threshold',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      threshold: 'number',
      time: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOvertimeSettingResponseBodyResult extends $tea.Model {
  default?: boolean;
  durationSettings?: { [key: string]: ResultDurationSettingsValue };
  id?: number;
  name?: string;
  overtimeDivisions?: GetOvertimeSettingResponseBodyResultOvertimeDivisions[];
  settingId?: number;
  stepType?: number;
  stepValue?: number;
  warningSettings?: GetOvertimeSettingResponseBodyResultWarningSettings[];
  workMinutesPerDay?: number;
  static names(): { [key: string]: string } {
    return {
      default: 'default',
      durationSettings: 'durationSettings',
      id: 'id',
      name: 'name',
      overtimeDivisions: 'overtimeDivisions',
      settingId: 'settingId',
      stepType: 'stepType',
      stepValue: 'stepValue',
      warningSettings: 'warningSettings',
      workMinutesPerDay: 'workMinutesPerDay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      default: 'boolean',
      durationSettings: { 'type': 'map', 'keyType': 'string', 'valueType': ResultDurationSettingsValue },
      id: 'number',
      name: 'string',
      overtimeDivisions: { 'type': 'array', 'itemType': GetOvertimeSettingResponseBodyResultOvertimeDivisions },
      settingId: 'number',
      stepType: 'number',
      stepValue: 'number',
      warningSettings: { 'type': 'array', 'itemType': GetOvertimeSettingResponseBodyResultWarningSettings },
      workMinutesPerDay: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleOvertimeSettingResponseBodyResultItems extends $tea.Model {
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

export class GetSimpleOvertimeSettingResponseBodyResult extends $tea.Model {
  items?: GetSimpleOvertimeSettingResponseBodyResultItems[];
  pageNumber?: number;
  totalPage?: number;
  static names(): { [key: string]: string } {
    return {
      items: 'items',
      pageNumber: 'pageNumber',
      totalPage: 'totalPage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      items: { 'type': 'array', 'itemType': GetSimpleOvertimeSettingResponseBodyResultItems },
      pageNumber: 'number',
      totalPage: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBodyResultHolidays extends $tea.Model {
  holidayName?: string;
  holidayType?: string;
  realWorkDate?: number;
  workDate?: number;
  static names(): { [key: string]: string } {
    return {
      holidayName: 'holidayName',
      holidayType: 'holidayType',
      realWorkDate: 'realWorkDate',
      workDate: 'workDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      holidayName: 'string',
      holidayType: 'string',
      realWorkDate: 'number',
      workDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBodyResult extends $tea.Model {
  holidays?: GetUserHolidaysResponseBodyResultHolidays[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      holidays: 'holidays',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      holidays: { 'type': 'array', 'itemType': GetUserHolidaysResponseBodyResultHolidays },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InitAndGetLeaveALlocationQuotasResponseBodyResult extends $tea.Model {
  endTime?: number;
  leaveCode?: string;
  quotaCycle?: string;
  quotaId?: string;
  quotaNumPerDay?: number;
  quotaNumPerHour?: number;
  startTime?: number;
  usedNumPerDay?: number;
  usedNumPerHour?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      leaveCode: 'leaveCode',
      quotaCycle: 'quotaCycle',
      quotaId: 'quotaId',
      quotaNumPerDay: 'quotaNumPerDay',
      quotaNumPerHour: 'quotaNumPerHour',
      startTime: 'startTime',
      usedNumPerDay: 'usedNumPerDay',
      usedNumPerHour: 'usedNumPerHour',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      leaveCode: 'string',
      quotaCycle: 'string',
      quotaId: 'string',
      quotaNumPerDay: 'number',
      quotaNumPerHour: 'number',
      startTime: 'number',
      usedNumPerDay: 'number',
      usedNumPerHour: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveCreateRequestPunchParam extends $tea.Model {
  positionId?: string;
  positionName?: string;
  positionType?: string;
  punchTime?: number;
  static names(): { [key: string]: string } {
    return {
      positionId: 'positionId',
      positionName: 'positionName',
      positionType: 'positionType',
      punchTime: 'punchTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      positionId: 'string',
      positionName: 'string',
      positionType: 'string',
      punchTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveCreateResponseBodyResult extends $tea.Model {
  dingtalkApproveId?: string;
  static names(): { [key: string]: string } {
    return {
      dingtalkApproveId: 'dingtalkApproveId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingtalkApproveId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCustomWaterMarkTemplateResponseBodyResult extends $tea.Model {
  formCode?: string;
  waterMarkId?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      waterMarkId: 'waterMarkId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      waterMarkId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncScheduleInfoRequestScheduleInfos extends $tea.Model {
  planId?: number;
  positionKeys?: string[];
  retainAttendanceCheck?: boolean;
  wifiKeys?: string[];
  static names(): { [key: string]: string } {
    return {
      planId: 'planId',
      positionKeys: 'positionKeys',
      retainAttendanceCheck: 'retainAttendanceCheck',
      wifiKeys: 'wifiKeys',
    };
  }

  static types(): { [key: string]: any } {
    return {
      planId: 'number',
      positionKeys: { 'type': 'array', 'itemType': 'string' },
      retainAttendanceCheck: 'boolean',
      wifiKeys: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeRequestLeaveCertificate extends $tea.Model {
  duration?: number;
  enable?: boolean;
  promptInformation?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      enable: 'enable',
      promptInformation: 'promptInformation',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      enable: 'boolean',
      promptInformation: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeRequestSubmitTimeRule extends $tea.Model {
  enableTimeLimit?: boolean;
  timeType?: string;
  timeUnit?: string;
  timeValue?: number;
  static names(): { [key: string]: string } {
    return {
      enableTimeLimit: 'enableTimeLimit',
      timeType: 'timeType',
      timeUnit: 'timeUnit',
      timeValue: 'timeValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableTimeLimit: 'boolean',
      timeType: 'string',
      timeUnit: 'string',
      timeValue: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeRequestVisibilityRules extends $tea.Model {
  type?: string;
  visible?: string[];
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      visible: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeResponseBodyResultLeaveCertificate extends $tea.Model {
  duration?: number;
  enable?: boolean;
  promptInformation?: string;
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      enable: 'enable',
      promptInformation: 'promptInformation',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      enable: 'boolean',
      promptInformation: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeResponseBodyResultSubmitTimeRule extends $tea.Model {
  enableTimeLimit?: boolean;
  timeType?: string;
  timeUnit?: string;
  timeValue?: number;
  static names(): { [key: string]: string } {
    return {
      enableTimeLimit: 'enableTimeLimit',
      timeType: 'timeType',
      timeUnit: 'timeUnit',
      timeValue: 'timeValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enableTimeLimit: 'boolean',
      timeType: 'string',
      timeUnit: 'string',
      timeValue: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeResponseBodyResultVisibilityRules extends $tea.Model {
  type?: string;
  visible?: string[];
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      visible: 'visible',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      visible: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLeaveTypeResponseBodyResult extends $tea.Model {
  bizType?: string;
  hoursInPerDay?: number;
  leaveCertificate?: UpdateLeaveTypeResponseBodyResultLeaveCertificate;
  leaveCode?: string;
  leaveName?: string;
  leaveViewUnit?: string;
  naturalDayLeave?: boolean;
  submitTimeRule?: UpdateLeaveTypeResponseBodyResultSubmitTimeRule;
  visibilityRules?: UpdateLeaveTypeResponseBodyResultVisibilityRules[];
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      hoursInPerDay: 'hoursInPerDay',
      leaveCertificate: 'leaveCertificate',
      leaveCode: 'leaveCode',
      leaveName: 'leaveName',
      leaveViewUnit: 'leaveViewUnit',
      naturalDayLeave: 'naturalDayLeave',
      submitTimeRule: 'submitTimeRule',
      visibilityRules: 'visibilityRules',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      hoursInPerDay: 'number',
      leaveCertificate: UpdateLeaveTypeResponseBodyResultLeaveCertificate,
      leaveCode: 'string',
      leaveName: 'string',
      leaveViewUnit: 'string',
      naturalDayLeave: 'boolean',
      submitTimeRule: UpdateLeaveTypeResponseBodyResultSubmitTimeRule,
      visibilityRules: { 'type': 'array', 'itemType': UpdateLeaveTypeResponseBodyResultVisibilityRules },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResultDurationSettingsValueSkipTimeByFrames extends $tea.Model {
  startTime?: string;
  endTime?: string;
  valid?: boolean;
  static names(): { [key: string]: string } {
    return {
      startTime: 'startTime',
      endTime: 'endTime',
      valid: 'valid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTime: 'string',
      endTime: 'string',
      valid: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResultDurationSettingsValueSkipTimeByDurations extends $tea.Model {
  duration?: number;
  minus?: number;
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      minus: 'minus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      minus: 'number',
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


  async addLeaveType(request: AddLeaveTypeRequest): Promise<AddLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLeaveTypeHeaders({ });
    return await this.addLeaveTypeWithOptions(request, headers, runtime);
  }

  async addLeaveTypeWithOptions(request: AddLeaveTypeRequest, headers: AddLeaveTypeHeaders, runtime: $Util.RuntimeOptions): Promise<AddLeaveTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.extras)) {
      body["extras"] = request.extras;
    }

    if (!Util.isUnset(request.hoursInPerDay)) {
      body["hoursInPerDay"] = request.hoursInPerDay;
    }

    if (!Util.isUnset($tea.toMap(request.leaveCertificate))) {
      body["leaveCertificate"] = request.leaveCertificate;
    }

    if (!Util.isUnset(request.leaveName)) {
      body["leaveName"] = request.leaveName;
    }

    if (!Util.isUnset(request.leaveViewUnit)) {
      body["leaveViewUnit"] = request.leaveViewUnit;
    }

    if (!Util.isUnset(request.naturalDayLeave)) {
      body["naturalDayLeave"] = request.naturalDayLeave;
    }

    if (!Util.isUnset($tea.toMap(request.submitTimeRule))) {
      body["submitTimeRule"] = request.submitTimeRule;
    }

    if (!Util.isUnset(request.visibilityRules)) {
      body["visibilityRules"] = request.visibilityRules;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AddLeaveTypeResponse>(await this.doROARequest("AddLeaveType", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/leaves/types`, "json", req, runtime), new AddLeaveTypeResponse({}));
  }

  async attendanceBleDevicesAdd(request: AttendanceBleDevicesAddRequest): Promise<AttendanceBleDevicesAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesAddHeaders({ });
    return await this.attendanceBleDevicesAddWithOptions(request, headers, runtime);
  }

  async attendanceBleDevicesAddWithOptions(request: AttendanceBleDevicesAddRequest, headers: AttendanceBleDevicesAddHeaders, runtime: $Util.RuntimeOptions): Promise<AttendanceBleDevicesAddResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceIdList)) {
      body["deviceIdList"] = request.deviceIdList;
    }

    if (!Util.isUnset(request.groupKey)) {
      body["groupKey"] = request.groupKey;
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
    return $tea.cast<AttendanceBleDevicesAddResponse>(await this.doROARequest("AttendanceBleDevicesAdd", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/group/bledevices`, "json", req, runtime), new AttendanceBleDevicesAddResponse({}));
  }

  async attendanceBleDevicesQuery(request: AttendanceBleDevicesQueryRequest): Promise<AttendanceBleDevicesQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesQueryHeaders({ });
    return await this.attendanceBleDevicesQueryWithOptions(request, headers, runtime);
  }

  async attendanceBleDevicesQueryWithOptions(request: AttendanceBleDevicesQueryRequest, headers: AttendanceBleDevicesQueryHeaders, runtime: $Util.RuntimeOptions): Promise<AttendanceBleDevicesQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupKey)) {
      body["groupKey"] = request.groupKey;
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
    return $tea.cast<AttendanceBleDevicesQueryResponse>(await this.doROARequestWithForm("AttendanceBleDevicesQuery", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/group/bledevices/query`, "json", req, runtime), new AttendanceBleDevicesQueryResponse({}));
  }

  async attendanceBleDevicesRemove(request: AttendanceBleDevicesRemoveRequest): Promise<AttendanceBleDevicesRemoveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesRemoveHeaders({ });
    return await this.attendanceBleDevicesRemoveWithOptions(request, headers, runtime);
  }

  async attendanceBleDevicesRemoveWithOptions(request: AttendanceBleDevicesRemoveRequest, headers: AttendanceBleDevicesRemoveHeaders, runtime: $Util.RuntimeOptions): Promise<AttendanceBleDevicesRemoveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deviceIdList)) {
      body["deviceIdList"] = request.deviceIdList;
    }

    if (!Util.isUnset(request.groupKey)) {
      body["groupKey"] = request.groupKey;
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
    return $tea.cast<AttendanceBleDevicesRemoveResponse>(await this.doROARequest("AttendanceBleDevicesRemove", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/group/bledevices/remove`, "json", req, runtime), new AttendanceBleDevicesRemoveResponse({}));
  }

  async checkClosingAccount(request: CheckClosingAccountRequest): Promise<CheckClosingAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckClosingAccountHeaders({ });
    return await this.checkClosingAccountWithOptions(request, headers, runtime);
  }

  async checkClosingAccountWithOptions(request: CheckClosingAccountRequest, headers: CheckClosingAccountHeaders, runtime: $Util.RuntimeOptions): Promise<CheckClosingAccountResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    if (!Util.isUnset(request.userTimeRange)) {
      body["userTimeRange"] = request.userTimeRange;
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
    return $tea.cast<CheckClosingAccountResponse>(await this.doROARequest("CheckClosingAccount", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/closingAccounts/status/query`, "json", req, runtime), new CheckClosingAccountResponse({}));
  }

  async checkWritePermission(request: CheckWritePermissionRequest): Promise<CheckWritePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckWritePermissionHeaders({ });
    return await this.checkWritePermissionWithOptions(request, headers, runtime);
  }

  async checkWritePermissionWithOptions(request: CheckWritePermissionRequest, headers: CheckWritePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<CheckWritePermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.entityIds)) {
      body["entityIds"] = request.entityIds;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.resourceKey)) {
      body["resourceKey"] = request.resourceKey;
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
    return $tea.cast<CheckWritePermissionResponse>(await this.doROARequest("CheckWritePermission", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/writePermissions/query`, "json", req, runtime), new CheckWritePermissionResponse({}));
  }

  async createApprove(request: CreateApproveRequest): Promise<CreateApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateApproveHeaders({ });
    return await this.createApproveWithOptions(request, headers, runtime);
  }

  async createApproveWithOptions(request: CreateApproveRequest, headers: CreateApproveHeaders, runtime: $Util.RuntimeOptions): Promise<CreateApproveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.approveId)) {
      body["approveId"] = request.approveId;
    }

    if (!Util.isUnset(request.opUserid)) {
      body["opUserid"] = request.opUserid;
    }

    if (!Util.isUnset($tea.toMap(request.punchParam))) {
      body["punchParam"] = request.punchParam;
    }

    if (!Util.isUnset(request.subType)) {
      body["subType"] = request.subType;
    }

    if (!Util.isUnset(request.tagName)) {
      body["tagName"] = request.tagName;
    }

    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
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
    return $tea.cast<CreateApproveResponse>(await this.doROARequest("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/approves`, "json", req, runtime), new CreateApproveResponse({}));
  }

  async deleteWaterMarkTemplate(request: DeleteWaterMarkTemplateRequest): Promise<DeleteWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWaterMarkTemplateHeaders({ });
    return await this.deleteWaterMarkTemplateWithOptions(request, headers, runtime);
  }

  async deleteWaterMarkTemplateWithOptions(request: DeleteWaterMarkTemplateRequest, headers: DeleteWaterMarkTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteWaterMarkTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      query["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.formContent)) {
      query["formContent"] = request.formContent;
    }

    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.systemTemplate)) {
      query["systemTemplate"] = request.systemTemplate;
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
    return $tea.cast<DeleteWaterMarkTemplateResponse>(await this.doROARequest("DeleteWaterMarkTemplate", "attendance_1.0", "HTTP", "DELETE", "AK", `/v1.0/attendance/watermarks/templates`, "json", req, runtime), new DeleteWaterMarkTemplateResponse({}));
  }

  async dingTalkSecurityCheck(request: DingTalkSecurityCheckRequest): Promise<DingTalkSecurityCheckResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DingTalkSecurityCheckHeaders({ });
    return await this.dingTalkSecurityCheckWithOptions(request, headers, runtime);
  }

  async dingTalkSecurityCheckWithOptions(request: DingTalkSecurityCheckRequest, headers: DingTalkSecurityCheckHeaders, runtime: $Util.RuntimeOptions): Promise<DingTalkSecurityCheckResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.clientVer)) {
      body["clientVer"] = request.clientVer;
    }

    if (!Util.isUnset(request.platform)) {
      body["platform"] = request.platform;
    }

    if (!Util.isUnset(request.platformVer)) {
      body["platformVer"] = request.platformVer;
    }

    if (!Util.isUnset(request.sec)) {
      body["sec"] = request.sec;
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
    return $tea.cast<DingTalkSecurityCheckResponse>(await this.doROARequest("DingTalkSecurityCheck", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/securities/check`, "json", req, runtime), new DingTalkSecurityCheckResponse({}));
  }

  async getAdjustments(request: GetAdjustmentsRequest): Promise<GetAdjustmentsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAdjustmentsHeaders({ });
    return await this.getAdjustmentsWithOptions(request, headers, runtime);
  }

  async getAdjustmentsWithOptions(request: GetAdjustmentsRequest, headers: GetAdjustmentsHeaders, runtime: $Util.RuntimeOptions): Promise<GetAdjustmentsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<GetAdjustmentsResponse>(await this.doROARequest("GetAdjustments", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/adjustments`, "json", req, runtime), new GetAdjustmentsResponse({}));
  }

  async getCheckInSchemaTemplate(request: GetCheckInSchemaTemplateRequest): Promise<GetCheckInSchemaTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCheckInSchemaTemplateHeaders({ });
    return await this.getCheckInSchemaTemplateWithOptions(request, headers, runtime);
  }

  async getCheckInSchemaTemplateWithOptions(request: GetCheckInSchemaTemplateRequest, headers: GetCheckInSchemaTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<GetCheckInSchemaTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.sceneCode)) {
      query["sceneCode"] = request.sceneCode;
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
    return $tea.cast<GetCheckInSchemaTemplateResponse>(await this.doROARequest("GetCheckInSchemaTemplate", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/watermarks/templates`, "json", req, runtime), new GetCheckInSchemaTemplateResponse({}));
  }

  async getClosingAccounts(request: GetClosingAccountsRequest): Promise<GetClosingAccountsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetClosingAccountsHeaders({ });
    return await this.getClosingAccountsWithOptions(request, headers, runtime);
  }

  async getClosingAccountsWithOptions(request: GetClosingAccountsRequest, headers: GetClosingAccountsHeaders, runtime: $Util.RuntimeOptions): Promise<GetClosingAccountsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
    return $tea.cast<GetClosingAccountsResponse>(await this.doROARequest("GetClosingAccounts", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/closingAccounts/rules/query`, "json", req, runtime), new GetClosingAccountsResponse({}));
  }

  async getLeaveType(request: GetLeaveTypeRequest): Promise<GetLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLeaveTypeHeaders({ });
    return await this.getLeaveTypeWithOptions(request, headers, runtime);
  }

  async getLeaveTypeWithOptions(request: GetLeaveTypeRequest, headers: GetLeaveTypeHeaders, runtime: $Util.RuntimeOptions): Promise<GetLeaveTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.vacationSource)) {
      query["vacationSource"] = request.vacationSource;
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
    return $tea.cast<GetLeaveTypeResponse>(await this.doROARequest("GetLeaveType", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/leaves/types`, "json", req, runtime), new GetLeaveTypeResponse({}));
  }

  async getMachine(devId: string): Promise<GetMachineResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMachineHeaders({ });
    return await this.getMachineWithOptions(devId, headers, runtime);
  }

  async getMachineWithOptions(devId: string, headers: GetMachineHeaders, runtime: $Util.RuntimeOptions): Promise<GetMachineResponse> {
    devId = OpenApiUtil.getEncodeParam(devId);
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
    return $tea.cast<GetMachineResponse>(await this.doROARequest("GetMachine", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/machines/${devId}`, "json", req, runtime), new GetMachineResponse({}));
  }

  async getMachineUser(devId: string, request: GetMachineUserRequest): Promise<GetMachineUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMachineUserHeaders({ });
    return await this.getMachineUserWithOptions(devId, request, headers, runtime);
  }

  async getMachineUserWithOptions(devId: string, request: GetMachineUserRequest, headers: GetMachineUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetMachineUserResponse> {
    Util.validateModel(request);
    devId = OpenApiUtil.getEncodeParam(devId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
    return $tea.cast<GetMachineUserResponse>(await this.doROARequest("GetMachineUser", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/machines/getUser/${devId}`, "json", req, runtime), new GetMachineUserResponse({}));
  }

  async getOvertimeSetting(request: GetOvertimeSettingRequest): Promise<GetOvertimeSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOvertimeSettingHeaders({ });
    return await this.getOvertimeSettingWithOptions(request, headers, runtime);
  }

  async getOvertimeSettingWithOptions(request: GetOvertimeSettingRequest, headers: GetOvertimeSettingHeaders, runtime: $Util.RuntimeOptions): Promise<GetOvertimeSettingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.overtimeSettingIds)) {
      body["overtimeSettingIds"] = request.overtimeSettingIds;
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
    return $tea.cast<GetOvertimeSettingResponse>(await this.doROARequest("GetOvertimeSetting", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/overtimeSettings/query`, "json", req, runtime), new GetOvertimeSettingResponse({}));
  }

  async getSimpleOvertimeSetting(request: GetSimpleOvertimeSettingRequest): Promise<GetSimpleOvertimeSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSimpleOvertimeSettingHeaders({ });
    return await this.getSimpleOvertimeSettingWithOptions(request, headers, runtime);
  }

  async getSimpleOvertimeSettingWithOptions(request: GetSimpleOvertimeSettingRequest, headers: GetSimpleOvertimeSettingHeaders, runtime: $Util.RuntimeOptions): Promise<GetSimpleOvertimeSettingResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
    return $tea.cast<GetSimpleOvertimeSettingResponse>(await this.doROARequest("GetSimpleOvertimeSetting", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/overtimeSettings`, "json", req, runtime), new GetSimpleOvertimeSettingResponse({}));
  }

  async getUserHolidays(request: GetUserHolidaysRequest): Promise<GetUserHolidaysResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHolidaysHeaders({ });
    return await this.getUserHolidaysWithOptions(request, headers, runtime);
  }

  async getUserHolidaysWithOptions(request: GetUserHolidaysRequest, headers: GetUserHolidaysHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserHolidaysResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    if (!Util.isUnset(request.workDateFrom)) {
      body["workDateFrom"] = request.workDateFrom;
    }

    if (!Util.isUnset(request.workDateTo)) {
      body["workDateTo"] = request.workDateTo;
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
    return $tea.cast<GetUserHolidaysResponse>(await this.doROARequest("GetUserHolidays", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/holidays`, "json", req, runtime), new GetUserHolidaysResponse({}));
  }

  async initAndGetLeaveALlocationQuotas(request: InitAndGetLeaveALlocationQuotasRequest): Promise<InitAndGetLeaveALlocationQuotasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitAndGetLeaveALlocationQuotasHeaders({ });
    return await this.initAndGetLeaveALlocationQuotasWithOptions(request, headers, runtime);
  }

  async initAndGetLeaveALlocationQuotasWithOptions(request: InitAndGetLeaveALlocationQuotasRequest, headers: InitAndGetLeaveALlocationQuotasHeaders, runtime: $Util.RuntimeOptions): Promise<InitAndGetLeaveALlocationQuotasResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.leaveCode)) {
      query["leaveCode"] = request.leaveCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
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
    return $tea.cast<InitAndGetLeaveALlocationQuotasResponse>(await this.doROARequest("InitAndGetLeaveALlocationQuotas", "attendance_1.0", "HTTP", "GET", "AK", `/v1.0/attendance/leaves/initializations/balances`, "json", req, runtime), new InitAndGetLeaveALlocationQuotasResponse({}));
  }

  async modifyWaterMarkTemplate(request: ModifyWaterMarkTemplateRequest): Promise<ModifyWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyWaterMarkTemplateHeaders({ });
    return await this.modifyWaterMarkTemplateWithOptions(request, headers, runtime);
  }

  async modifyWaterMarkTemplateWithOptions(request: ModifyWaterMarkTemplateRequest, headers: ModifyWaterMarkTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<ModifyWaterMarkTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.layoutDesignId)) {
      body["layoutDesignId"] = request.layoutDesignId;
    }

    if (!Util.isUnset(request.schemaContent)) {
      body["schemaContent"] = request.schemaContent;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.waterMarkId)) {
      body["waterMarkId"] = request.waterMarkId;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ModifyWaterMarkTemplateResponse>(await this.doROARequest("ModifyWaterMarkTemplate", "attendance_1.0", "HTTP", "PUT", "AK", `/v1.0/attendance/watermarks/templates`, "json", req, runtime), new ModifyWaterMarkTemplateResponse({}));
  }

  async processApproveCreate(request: ProcessApproveCreateRequest): Promise<ProcessApproveCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessApproveCreateHeaders({ });
    return await this.processApproveCreateWithOptions(request, headers, runtime);
  }

  async processApproveCreateWithOptions(request: ProcessApproveCreateRequest, headers: ProcessApproveCreateHeaders, runtime: $Util.RuntimeOptions): Promise<ProcessApproveCreateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.approveId)) {
      body["approveId"] = request.approveId;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset($tea.toMap(request.punchParam))) {
      body["punchParam"] = request.punchParam;
    }

    if (!Util.isUnset(request.subType)) {
      body["subType"] = request.subType;
    }

    if (!Util.isUnset(request.tagName)) {
      body["tagName"] = request.tagName;
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
    return $tea.cast<ProcessApproveCreateResponse>(await this.doROARequest("ProcessApproveCreate", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/workflows/checkInForms`, "json", req, runtime), new ProcessApproveCreateResponse({}));
  }

  async saveCustomWaterMarkTemplate(request: SaveCustomWaterMarkTemplateRequest): Promise<SaveCustomWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveCustomWaterMarkTemplateHeaders({ });
    return await this.saveCustomWaterMarkTemplateWithOptions(request, headers, runtime);
  }

  async saveCustomWaterMarkTemplateWithOptions(request: SaveCustomWaterMarkTemplateRequest, headers: SaveCustomWaterMarkTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<SaveCustomWaterMarkTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.layoutDesignId)) {
      body["layoutDesignId"] = request.layoutDesignId;
    }

    if (!Util.isUnset(request.sceneCode)) {
      body["sceneCode"] = request.sceneCode;
    }

    if (!Util.isUnset(request.schemaContent)) {
      body["schemaContent"] = request.schemaContent;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<SaveCustomWaterMarkTemplateResponse>(await this.doROARequest("SaveCustomWaterMarkTemplate", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/watermarks/templates`, "json", req, runtime), new SaveCustomWaterMarkTemplateResponse({}));
  }

  async syncScheduleInfo(request: SyncScheduleInfoRequest): Promise<SyncScheduleInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncScheduleInfoHeaders({ });
    return await this.syncScheduleInfoWithOptions(request, headers, runtime);
  }

  async syncScheduleInfoWithOptions(request: SyncScheduleInfoRequest, headers: SyncScheduleInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SyncScheduleInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.scheduleInfos)) {
      body["scheduleInfos"] = request.scheduleInfos;
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
    return $tea.cast<SyncScheduleInfoResponse>(await this.doROARequest("SyncScheduleInfo", "attendance_1.0", "HTTP", "PUT", "AK", `/v1.0/attendance/schedules/additionalInfo`, "none", req, runtime), new SyncScheduleInfoResponse({}));
  }

  async updateLeaveType(request: UpdateLeaveTypeRequest): Promise<UpdateLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateLeaveTypeHeaders({ });
    return await this.updateLeaveTypeWithOptions(request, headers, runtime);
  }

  async updateLeaveTypeWithOptions(request: UpdateLeaveTypeRequest, headers: UpdateLeaveTypeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateLeaveTypeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.extras)) {
      body["extras"] = request.extras;
    }

    if (!Util.isUnset(request.hoursInPerDay)) {
      body["hoursInPerDay"] = request.hoursInPerDay;
    }

    if (!Util.isUnset($tea.toMap(request.leaveCertificate))) {
      body["leaveCertificate"] = request.leaveCertificate;
    }

    if (!Util.isUnset(request.leaveCode)) {
      body["leaveCode"] = request.leaveCode;
    }

    if (!Util.isUnset(request.leaveName)) {
      body["leaveName"] = request.leaveName;
    }

    if (!Util.isUnset(request.leaveViewUnit)) {
      body["leaveViewUnit"] = request.leaveViewUnit;
    }

    if (!Util.isUnset(request.naturalDayLeave)) {
      body["naturalDayLeave"] = request.naturalDayLeave;
    }

    if (!Util.isUnset($tea.toMap(request.submitTimeRule))) {
      body["submitTimeRule"] = request.submitTimeRule;
    }

    if (!Util.isUnset(request.visibilityRules)) {
      body["visibilityRules"] = request.visibilityRules;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateLeaveTypeResponse>(await this.doROARequest("UpdateLeaveType", "attendance_1.0", "HTTP", "PUT", "AK", `/v1.0/attendance/leaves/types`, "json", req, runtime), new UpdateLeaveTypeResponse({}));
  }

}
