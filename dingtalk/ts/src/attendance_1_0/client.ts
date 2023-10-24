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
  freedomLeave?: boolean;
  hoursInPerDay?: number;
  leaveCertificate?: AddLeaveTypeRequestLeaveCertificate;
  leaveHourCeil?: string;
  leaveName?: string;
  leaveTimeCeil?: boolean;
  leaveTimeCeilMinUnit?: string;
  leaveViewUnit?: string;
  maxLeaveTime?: number;
  minLeaveHour?: number;
  naturalDayLeave?: boolean;
  paidLeave?: boolean;
  submitTimeRule?: AddLeaveTypeRequestSubmitTimeRule;
  visibilityRules?: AddLeaveTypeRequestVisibilityRules[];
  whenCanLeave?: string;
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      extras: 'extras',
      freedomLeave: 'freedomLeave',
      hoursInPerDay: 'hoursInPerDay',
      leaveCertificate: 'leaveCertificate',
      leaveHourCeil: 'leaveHourCeil',
      leaveName: 'leaveName',
      leaveTimeCeil: 'leaveTimeCeil',
      leaveTimeCeilMinUnit: 'leaveTimeCeilMinUnit',
      leaveViewUnit: 'leaveViewUnit',
      maxLeaveTime: 'maxLeaveTime',
      minLeaveHour: 'minLeaveHour',
      naturalDayLeave: 'naturalDayLeave',
      paidLeave: 'paidLeave',
      submitTimeRule: 'submitTimeRule',
      visibilityRules: 'visibilityRules',
      whenCanLeave: 'whenCanLeave',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      extras: 'string',
      freedomLeave: 'boolean',
      hoursInPerDay: 'number',
      leaveCertificate: AddLeaveTypeRequestLeaveCertificate,
      leaveHourCeil: 'string',
      leaveName: 'string',
      leaveTimeCeil: 'boolean',
      leaveTimeCeilMinUnit: 'string',
      leaveViewUnit: 'string',
      maxLeaveTime: 'number',
      minLeaveHour: 'number',
      naturalDayLeave: 'boolean',
      paidLeave: 'boolean',
      submitTimeRule: AddLeaveTypeRequestSubmitTimeRule,
      visibilityRules: { 'type': 'array', 'itemType': AddLeaveTypeRequestVisibilityRules },
      whenCanLeave: 'string',
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
  statusCode: number;
  body: AddLeaveTypeResponseBody;
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
  statusCode: number;
  body: AttendanceBleDevicesAddResponseBody;
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
  statusCode: number;
  body: AttendanceBleDevicesQueryResponseBody;
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
  statusCode: number;
  body: AttendanceBleDevicesRemoveResponseBody;
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
      body: AttendanceBleDevicesRemoveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchBossCheckHeaders extends $tea.Model {
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

export class BatchBossCheckRequest extends $tea.Model {
  models?: BatchBossCheckRequestModels[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      models: 'models',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      models: { 'type': 'array', 'itemType': BatchBossCheckRequestModels },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchBossCheckResponseBody extends $tea.Model {
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

export class BatchBossCheckResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchBossCheckResponseBody;
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
      body: BatchBossCheckResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CalculateDurationHeaders extends $tea.Model {
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

export class CalculateDurationRequest extends $tea.Model {
  bizType?: number;
  calculateModel?: number;
  durationUnit?: string;
  fromTime?: string;
  leaveCode?: string;
  toTime?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      calculateModel: 'calculateModel',
      durationUnit: 'durationUnit',
      fromTime: 'fromTime',
      leaveCode: 'leaveCode',
      toTime: 'toTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      calculateModel: 'number',
      durationUnit: 'string',
      fromTime: 'string',
      leaveCode: 'string',
      toTime: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CalculateDurationResponseBody extends $tea.Model {
  result?: CalculateDurationResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CalculateDurationResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CalculateDurationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CalculateDurationResponseBody;
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
      body: CalculateDurationResponseBody,
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
  statusCode: number;
  body: CheckClosingAccountResponseBody;
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
  statusCode: number;
  body: CheckWritePermissionResponseBody;
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
  statusCode: number;
  body: CreateApproveResponseBody;
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
  statusCode: number;
  body: DeleteWaterMarkTemplateResponseBody;
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
  statusCode: number;
  body: DingTalkSecurityCheckResponseBody;
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
      body: DingTalkSecurityCheckResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetATManageScopeHeaders extends $tea.Model {
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

export class GetATManageScopeRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetATManageScopeResponseBody extends $tea.Model {
  result?: GetATManageScopeResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetATManageScopeResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetATManageScopeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetATManageScopeResponseBody;
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
      body: GetATManageScopeResponseBody,
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
  result?: GetAdjustmentsResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetAdjustmentsResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdjustmentsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAdjustmentsResponseBody;
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
  statusCode: number;
  body: GetCheckInSchemaTemplateResponseBody;
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
      body: GetCheckInSchemaTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserHeaders extends $tea.Model {
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

export class GetCheckinRecordByUserRequest extends $tea.Model {
  endTime?: number;
  maxResults?: number;
  nextToken?: number;
  operatorUserId?: string;
  startTime?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operatorUserId: 'operatorUserId',
      startTime: 'startTime',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      maxResults: 'number',
      nextToken: 'number',
      operatorUserId: 'string',
      startTime: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponseBody extends $tea.Model {
  result?: GetCheckinRecordByUserResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetCheckinRecordByUserResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCheckinRecordByUserResponseBody;
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
      body: GetCheckinRecordByUserResponseBody,
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
  statusCode: number;
  body: GetClosingAccountsResponseBody;
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
      body: GetClosingAccountsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveRecordsHeaders extends $tea.Model {
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

export class GetLeaveRecordsRequest extends $tea.Model {
  leaveCode?: string;
  opUserId?: string;
  pageNumber?: number;
  pageSize?: number;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      leaveCode: 'leaveCode',
      opUserId: 'opUserId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      leaveCode: 'string',
      opUserId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveRecordsResponseBody extends $tea.Model {
  result?: GetLeaveRecordsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetLeaveRecordsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveRecordsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetLeaveRecordsResponseBody;
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
      body: GetLeaveRecordsResponseBody,
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
  statusCode: number;
  body: GetLeaveTypeResponseBody;
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
  statusCode: number;
  body: GetMachineResponseBody;
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
  statusCode: number;
  body: GetMachineUserResponseBody;
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
  statusCode: number;
  body: GetOvertimeSettingResponseBody;
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
      body: GetOvertimeSettingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftHeaders extends $tea.Model {
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

export class GetShiftRequest extends $tea.Model {
  opUserId?: string;
  shiftId?: number;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      shiftId: 'shiftId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      shiftId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponseBody extends $tea.Model {
  result?: GetShiftResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetShiftResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetShiftResponseBody;
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
      body: GetShiftResponseBody,
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
  result?: GetSimpleOvertimeSettingResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetSimpleOvertimeSettingResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleOvertimeSettingResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSimpleOvertimeSettingResponseBody;
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
  statusCode: number;
  body: GetUserHolidaysResponseBody;
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
      body: GetUserHolidaysResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddHeaders extends $tea.Model {
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

export class GroupAddRequest extends $tea.Model {
  adjustmentSettingId?: number;
  bleDeviceList?: GroupAddRequestBleDeviceList[];
  checkNeedHealthyCode?: boolean;
  defaultClassId?: number;
  disableCheckWhenRest?: boolean;
  disableCheckWithoutSchedule?: boolean;
  enableCameraCheck?: boolean;
  enableEmpSelectClass?: boolean;
  enableFaceCheck?: boolean;
  enableFaceStrictMode?: boolean;
  enableNextDay?: boolean;
  enableOutSideUpdateNormalCheck?: boolean;
  enableOutsideApply?: boolean;
  enableOutsideCameraCheck?: boolean;
  enableOutsideCheck?: boolean;
  enableOutsideRemark?: boolean;
  enablePositionBle?: boolean;
  enableTrimDistance?: boolean;
  forbidHideOutSideAddress?: boolean;
  freeCheckSetting?: GroupAddRequestFreeCheckSetting;
  freeCheckTypeId?: number;
  freecheckDayStartMinOffset?: number;
  freecheckWorkDays?: number[];
  groupId?: number;
  groupName?: string;
  managerList?: string[];
  members?: GroupAddRequestMembers[];
  modifyMember?: boolean;
  offset?: number;
  openCameraCheck?: boolean;
  openFaceCheck?: boolean;
  outsideCheckApproveModeId?: number;
  overtimeSettingId?: number;
  owner?: string;
  positions?: GroupAddRequestPositions[];
  resourcePermissionMap?: { [key: string]: any };
  shiftVOList?: GroupAddRequestShiftVOList[];
  skipHolidays?: boolean;
  specialDays?: string;
  trimDistance?: number;
  type?: string;
  wifis?: GroupAddRequestWifis[];
  workdayClassList?: number[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      adjustmentSettingId: 'adjustmentSettingId',
      bleDeviceList: 'bleDeviceList',
      checkNeedHealthyCode: 'checkNeedHealthyCode',
      defaultClassId: 'defaultClassId',
      disableCheckWhenRest: 'disableCheckWhenRest',
      disableCheckWithoutSchedule: 'disableCheckWithoutSchedule',
      enableCameraCheck: 'enableCameraCheck',
      enableEmpSelectClass: 'enableEmpSelectClass',
      enableFaceCheck: 'enableFaceCheck',
      enableFaceStrictMode: 'enableFaceStrictMode',
      enableNextDay: 'enableNextDay',
      enableOutSideUpdateNormalCheck: 'enableOutSideUpdateNormalCheck',
      enableOutsideApply: 'enableOutsideApply',
      enableOutsideCameraCheck: 'enableOutsideCameraCheck',
      enableOutsideCheck: 'enableOutsideCheck',
      enableOutsideRemark: 'enableOutsideRemark',
      enablePositionBle: 'enablePositionBle',
      enableTrimDistance: 'enableTrimDistance',
      forbidHideOutSideAddress: 'forbidHideOutSideAddress',
      freeCheckSetting: 'freeCheckSetting',
      freeCheckTypeId: 'freeCheckTypeId',
      freecheckDayStartMinOffset: 'freecheckDayStartMinOffset',
      freecheckWorkDays: 'freecheckWorkDays',
      groupId: 'groupId',
      groupName: 'groupName',
      managerList: 'managerList',
      members: 'members',
      modifyMember: 'modifyMember',
      offset: 'offset',
      openCameraCheck: 'openCameraCheck',
      openFaceCheck: 'openFaceCheck',
      outsideCheckApproveModeId: 'outsideCheckApproveModeId',
      overtimeSettingId: 'overtimeSettingId',
      owner: 'owner',
      positions: 'positions',
      resourcePermissionMap: 'resourcePermissionMap',
      shiftVOList: 'shiftVOList',
      skipHolidays: 'skipHolidays',
      specialDays: 'specialDays',
      trimDistance: 'trimDistance',
      type: 'type',
      wifis: 'wifis',
      workdayClassList: 'workdayClassList',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adjustmentSettingId: 'number',
      bleDeviceList: { 'type': 'array', 'itemType': GroupAddRequestBleDeviceList },
      checkNeedHealthyCode: 'boolean',
      defaultClassId: 'number',
      disableCheckWhenRest: 'boolean',
      disableCheckWithoutSchedule: 'boolean',
      enableCameraCheck: 'boolean',
      enableEmpSelectClass: 'boolean',
      enableFaceCheck: 'boolean',
      enableFaceStrictMode: 'boolean',
      enableNextDay: 'boolean',
      enableOutSideUpdateNormalCheck: 'boolean',
      enableOutsideApply: 'boolean',
      enableOutsideCameraCheck: 'boolean',
      enableOutsideCheck: 'boolean',
      enableOutsideRemark: 'boolean',
      enablePositionBle: 'boolean',
      enableTrimDistance: 'boolean',
      forbidHideOutSideAddress: 'boolean',
      freeCheckSetting: GroupAddRequestFreeCheckSetting,
      freeCheckTypeId: 'number',
      freecheckDayStartMinOffset: 'number',
      freecheckWorkDays: { 'type': 'array', 'itemType': 'number' },
      groupId: 'number',
      groupName: 'string',
      managerList: { 'type': 'array', 'itemType': 'string' },
      members: { 'type': 'array', 'itemType': GroupAddRequestMembers },
      modifyMember: 'boolean',
      offset: 'number',
      openCameraCheck: 'boolean',
      openFaceCheck: 'boolean',
      outsideCheckApproveModeId: 'number',
      overtimeSettingId: 'number',
      owner: 'string',
      positions: { 'type': 'array', 'itemType': GroupAddRequestPositions },
      resourcePermissionMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      shiftVOList: { 'type': 'array', 'itemType': GroupAddRequestShiftVOList },
      skipHolidays: 'boolean',
      specialDays: 'string',
      trimDistance: 'number',
      type: 'string',
      wifis: { 'type': 'array', 'itemType': GroupAddRequestWifis },
      workdayClassList: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddResponseBody extends $tea.Model {
  result?: GroupAddResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GroupAddResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GroupAddResponseBody;
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
      body: GroupAddResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupUpdateHeaders extends $tea.Model {
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

export class GroupUpdateRequest extends $tea.Model {
  adjustmentSettingId?: number;
  disableCheckWhenRest?: boolean;
  disableCheckWithoutSchedule?: boolean;
  enableCameraCheck?: boolean;
  enableEmpSelectClass?: boolean;
  enableFaceCheck?: boolean;
  enableFaceStrictMode?: boolean;
  enableOutSideUpdateNormalCheck?: boolean;
  enableOutsideApply?: boolean;
  enableOutsideCheck?: boolean;
  enableOutsideRemark?: boolean;
  enableTrimDistance?: boolean;
  forbidHideOutSideAddress?: boolean;
  freeCheckSetting?: GroupUpdateRequestFreeCheckSetting;
  freeCheckTypeId?: number;
  groupId?: number;
  groupName?: string;
  managerList?: string[];
  offset?: number;
  openCameraCheck?: boolean;
  openFaceCheck?: boolean;
  outsideCheckApproveModeId?: number;
  overtimeSettingId?: number;
  owner?: string;
  positions?: GroupUpdateRequestPositions[];
  resourcePermissionMap?: { [key: string]: any };
  shiftVOList?: GroupUpdateRequestShiftVOList[];
  skipHolidays?: boolean;
  trimDistance?: number;
  workdayClassList?: number[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      adjustmentSettingId: 'adjustmentSettingId',
      disableCheckWhenRest: 'disableCheckWhenRest',
      disableCheckWithoutSchedule: 'disableCheckWithoutSchedule',
      enableCameraCheck: 'enableCameraCheck',
      enableEmpSelectClass: 'enableEmpSelectClass',
      enableFaceCheck: 'enableFaceCheck',
      enableFaceStrictMode: 'enableFaceStrictMode',
      enableOutSideUpdateNormalCheck: 'enableOutSideUpdateNormalCheck',
      enableOutsideApply: 'enableOutsideApply',
      enableOutsideCheck: 'enableOutsideCheck',
      enableOutsideRemark: 'enableOutsideRemark',
      enableTrimDistance: 'enableTrimDistance',
      forbidHideOutSideAddress: 'forbidHideOutSideAddress',
      freeCheckSetting: 'freeCheckSetting',
      freeCheckTypeId: 'freeCheckTypeId',
      groupId: 'groupId',
      groupName: 'groupName',
      managerList: 'managerList',
      offset: 'offset',
      openCameraCheck: 'openCameraCheck',
      openFaceCheck: 'openFaceCheck',
      outsideCheckApproveModeId: 'outsideCheckApproveModeId',
      overtimeSettingId: 'overtimeSettingId',
      owner: 'owner',
      positions: 'positions',
      resourcePermissionMap: 'resourcePermissionMap',
      shiftVOList: 'shiftVOList',
      skipHolidays: 'skipHolidays',
      trimDistance: 'trimDistance',
      workdayClassList: 'workdayClassList',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adjustmentSettingId: 'number',
      disableCheckWhenRest: 'boolean',
      disableCheckWithoutSchedule: 'boolean',
      enableCameraCheck: 'boolean',
      enableEmpSelectClass: 'boolean',
      enableFaceCheck: 'boolean',
      enableFaceStrictMode: 'boolean',
      enableOutSideUpdateNormalCheck: 'boolean',
      enableOutsideApply: 'boolean',
      enableOutsideCheck: 'boolean',
      enableOutsideRemark: 'boolean',
      enableTrimDistance: 'boolean',
      forbidHideOutSideAddress: 'boolean',
      freeCheckSetting: GroupUpdateRequestFreeCheckSetting,
      freeCheckTypeId: 'number',
      groupId: 'number',
      groupName: 'string',
      managerList: { 'type': 'array', 'itemType': 'string' },
      offset: 'number',
      openCameraCheck: 'boolean',
      openFaceCheck: 'boolean',
      outsideCheckApproveModeId: 'number',
      overtimeSettingId: 'number',
      owner: 'string',
      positions: { 'type': 'array', 'itemType': GroupUpdateRequestPositions },
      resourcePermissionMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      shiftVOList: { 'type': 'array', 'itemType': GroupUpdateRequestShiftVOList },
      skipHolidays: 'boolean',
      trimDistance: 'number',
      workdayClassList: { 'type': 'array', 'itemType': 'number' },
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupUpdateResponseBody extends $tea.Model {
  result?: GroupUpdateResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GroupUpdateResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupUpdateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GroupUpdateResponseBody;
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
      body: GroupUpdateResponseBody,
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
  statusCode: number;
  body: InitAndGetLeaveALlocationQuotasResponseBody;
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
      body: InitAndGetLeaveALlocationQuotasResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApproveByUsersHeaders extends $tea.Model {
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

export class ListApproveByUsersRequest extends $tea.Model {
  bizTypes?: number[];
  fromDateTime?: number;
  toDateTime?: number;
  userIds?: string;
  static names(): { [key: string]: string } {
    return {
      bizTypes: 'bizTypes',
      fromDateTime: 'fromDateTime',
      toDateTime: 'toDateTime',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTypes: { 'type': 'array', 'itemType': 'number' },
      fromDateTime: 'number',
      toDateTime: 'number',
      userIds: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApproveByUsersResponseBody extends $tea.Model {
  result?: ListApproveByUsersResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListApproveByUsersResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListApproveByUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListApproveByUsersResponseBody;
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
      body: ListApproveByUsersResponseBody,
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
  statusCode: number;
  body: ModifyWaterMarkTemplateResponseBody;
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
  statusCode: number;
  body: ProcessApproveCreateResponseBody;
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
      body: ProcessApproveCreateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveFinishHeaders extends $tea.Model {
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

export class ProcessApproveFinishRequest extends $tea.Model {
  approveId?: string;
  jumpUrl?: string;
  overTimeToMore?: number;
  overtimeDuration?: string;
  subType?: string;
  tagName?: string;
  topCalculateApproveDurationParam?: ProcessApproveFinishRequestTopCalculateApproveDurationParam;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      approveId: 'approveId',
      jumpUrl: 'jumpUrl',
      overTimeToMore: 'overTimeToMore',
      overtimeDuration: 'overtimeDuration',
      subType: 'subType',
      tagName: 'tagName',
      topCalculateApproveDurationParam: 'topCalculateApproveDurationParam',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveId: 'string',
      jumpUrl: 'string',
      overTimeToMore: 'number',
      overtimeDuration: 'string',
      subType: 'string',
      tagName: 'string',
      topCalculateApproveDurationParam: ProcessApproveFinishRequestTopCalculateApproveDurationParam,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveFinishResponseBody extends $tea.Model {
  result?: ProcessApproveFinishResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ProcessApproveFinishResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveFinishResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ProcessApproveFinishResponseBody;
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
      body: ProcessApproveFinishResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReduceQuotaWithLeaveRecordHeaders extends $tea.Model {
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

export class ReduceQuotaWithLeaveRecordRequest extends $tea.Model {
  endTime?: number;
  leaveCode?: string;
  outerId?: string;
  quotaNum?: number;
  reason?: string;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      leaveCode: 'leaveCode',
      outerId: 'outerId',
      quotaNum: 'quotaNum',
      reason: 'reason',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      leaveCode: 'string',
      outerId: 'string',
      quotaNum: 'number',
      reason: 'string',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReduceQuotaWithLeaveRecordResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReduceQuotaWithLeaveRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ReduceQuotaWithLeaveRecordResponseBody;
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
      body: ReduceQuotaWithLeaveRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetainLeaveTypesHeaders extends $tea.Model {
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

export class RetainLeaveTypesRequest extends $tea.Model {
  leaveCodes?: string[];
  opUserId?: string;
  source?: number;
  static names(): { [key: string]: string } {
    return {
      leaveCodes: 'leaveCodes',
      opUserId: 'opUserId',
      source: 'source',
    };
  }

  static types(): { [key: string]: any } {
    return {
      leaveCodes: { 'type': 'array', 'itemType': 'string' },
      opUserId: 'string',
      source: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetainLeaveTypesResponseBody extends $tea.Model {
  result?: RetainLeaveTypesResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': RetainLeaveTypesResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetainLeaveTypesResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: RetainLeaveTypesResponseBody;
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
      body: RetainLeaveTypesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReverseTrialAdvancedLeaveHeaders extends $tea.Model {
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

export class ReverseTrialAdvancedLeaveRequest extends $tea.Model {
  opUserId?: string;
  servCode?: number;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      servCode: 'servCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      servCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReverseTrialAdvancedLeaveResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReverseTrialAdvancedLeaveResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ReverseTrialAdvancedLeaveResponseBody;
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
      body: ReverseTrialAdvancedLeaveResponseBody,
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
  statusCode: number;
  body: SaveCustomWaterMarkTemplateResponseBody;
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
  statusCode: number;
  body: UpdateLeaveTypeResponseBody;
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
      body: UpdateLeaveTypeResponseBody,
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

export class BatchBossCheckRequestModels extends $tea.Model {
  absentMin?: number;
  planId?: number;
  remark?: string;
  timeResult?: string;
  static names(): { [key: string]: string } {
    return {
      absentMin: 'absentMin',
      planId: 'planId',
      remark: 'remark',
      timeResult: 'timeResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      absentMin: 'number',
      planId: 'number',
      remark: 'string',
      timeResult: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CalculateDurationResponseBodyResultDurationDetail extends $tea.Model {
  date?: string;
  duration?: number;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      duration: 'duration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      duration: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CalculateDurationResponseBodyResult extends $tea.Model {
  duration?: number;
  durationDetail?: CalculateDurationResponseBodyResultDurationDetail[];
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      durationDetail: 'durationDetail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      durationDetail: { 'type': 'array', 'itemType': CalculateDurationResponseBodyResultDurationDetail },
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

export class GetATManageScopeResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  manageScope?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      manageScope: 'manageScope',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      manageScope: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdjustmentsResponseBodyResultItems extends $tea.Model {
  id?: number;
  name?: string;
  settingId?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      settingId: 'settingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      settingId: 'number',
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

export class GetCheckinRecordByUserResponseBodyResultPageListCustomDataList extends $tea.Model {
  key?: string;
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponseBodyResultPageList extends $tea.Model {
  checkinTime?: number;
  customDataList?: GetCheckinRecordByUserResponseBodyResultPageListCustomDataList[];
  detailPlace?: string;
  imageList?: string[];
  latitude?: string;
  longitude?: string;
  place?: string;
  remark?: string;
  userId?: string;
  visitUser?: string;
  static names(): { [key: string]: string } {
    return {
      checkinTime: 'checkinTime',
      customDataList: 'customDataList',
      detailPlace: 'detailPlace',
      imageList: 'imageList',
      latitude: 'latitude',
      longitude: 'longitude',
      place: 'place',
      remark: 'remark',
      userId: 'userId',
      visitUser: 'visitUser',
    };
  }

  static types(): { [key: string]: any } {
    return {
      checkinTime: 'number',
      customDataList: { 'type': 'array', 'itemType': GetCheckinRecordByUserResponseBodyResultPageListCustomDataList },
      detailPlace: 'string',
      imageList: { 'type': 'array', 'itemType': 'string' },
      latitude: 'string',
      longitude: 'string',
      place: 'string',
      remark: 'string',
      userId: 'string',
      visitUser: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCheckinRecordByUserResponseBodyResult extends $tea.Model {
  nextToken?: number;
  pageList?: GetCheckinRecordByUserResponseBodyResultPageList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      pageList: 'pageList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      pageList: { 'type': 'array', 'itemType': GetCheckinRecordByUserResponseBodyResultPageList },
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

export class GetLeaveRecordsResponseBodyResultLeaveRecords extends $tea.Model {
  calType?: string;
  endTime?: number;
  gmtCreate?: number;
  gmtModified?: number;
  leaveCode?: string;
  leaveReason?: string;
  leaveRecordType?: string;
  leaveStatus?: string;
  leaveViewUnit?: string;
  opUserId?: string;
  quotaId?: string;
  recordId?: string;
  recordNumPerDay?: number;
  recordNumPerHour?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      calType: 'calType',
      endTime: 'endTime',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      leaveCode: 'leaveCode',
      leaveReason: 'leaveReason',
      leaveRecordType: 'leaveRecordType',
      leaveStatus: 'leaveStatus',
      leaveViewUnit: 'leaveViewUnit',
      opUserId: 'opUserId',
      quotaId: 'quotaId',
      recordId: 'recordId',
      recordNumPerDay: 'recordNumPerDay',
      recordNumPerHour: 'recordNumPerHour',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      calType: 'string',
      endTime: 'number',
      gmtCreate: 'number',
      gmtModified: 'number',
      leaveCode: 'string',
      leaveReason: 'string',
      leaveRecordType: 'string',
      leaveStatus: 'string',
      leaveViewUnit: 'string',
      opUserId: 'string',
      quotaId: 'string',
      recordId: 'string',
      recordNumPerDay: 'number',
      recordNumPerHour: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveRecordsResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  leaveRecords?: GetLeaveRecordsResponseBodyResultLeaveRecords[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      leaveRecords: 'leaveRecords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      leaveRecords: { 'type': 'array', 'itemType': GetLeaveRecordsResponseBodyResultLeaveRecords },
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

export class GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs extends $tea.Model {
  extra?: number;
  late?: number;
  static names(): { [key: string]: string } {
    return {
      extra: 'extra',
      late: 'late',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extra: 'number',
      late: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponseBodyResultSectionsPunchesLateBackSetting extends $tea.Model {
  lateBackPairs?: GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs[];
  static names(): { [key: string]: string } {
    return {
      lateBackPairs: 'lateBackPairs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lateBackPairs: { 'type': 'array', 'itemType': GetShiftResponseBodyResultSectionsPunchesLateBackSettingLateBackPairs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponseBodyResultSectionsPunches extends $tea.Model {
  absenteeismLateMinutes?: number;
  across?: number;
  beginMin?: number;
  checkTime?: string;
  checkType?: string;
  endMin?: number;
  flexMinutes?: number[];
  freeCheck?: boolean;
  lateBackSetting?: GetShiftResponseBodyResultSectionsPunchesLateBackSetting;
  permitMinutes?: number;
  puncheId?: number;
  seriousLateMinutes?: number;
  static names(): { [key: string]: string } {
    return {
      absenteeismLateMinutes: 'absenteeismLateMinutes',
      across: 'across',
      beginMin: 'beginMin',
      checkTime: 'checkTime',
      checkType: 'checkType',
      endMin: 'endMin',
      flexMinutes: 'flexMinutes',
      freeCheck: 'freeCheck',
      lateBackSetting: 'lateBackSetting',
      permitMinutes: 'permitMinutes',
      puncheId: 'puncheId',
      seriousLateMinutes: 'seriousLateMinutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      absenteeismLateMinutes: 'number',
      across: 'number',
      beginMin: 'number',
      checkTime: 'string',
      checkType: 'string',
      endMin: 'number',
      flexMinutes: { 'type': 'array', 'itemType': 'number' },
      freeCheck: 'boolean',
      lateBackSetting: GetShiftResponseBodyResultSectionsPunchesLateBackSetting,
      permitMinutes: 'number',
      puncheId: 'number',
      seriousLateMinutes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponseBodyResultSectionsRests extends $tea.Model {
  across?: number;
  checkTime?: string;
  checkType?: string;
  restId?: number;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      checkTime: 'checkTime',
      checkType: 'checkType',
      restId: 'restId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      checkTime: 'string',
      checkType: 'string',
      restId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponseBodyResultSections extends $tea.Model {
  punches?: GetShiftResponseBodyResultSectionsPunches[];
  rests?: GetShiftResponseBodyResultSectionsRests[];
  sectionId?: number;
  static names(): { [key: string]: string } {
    return {
      punches: 'punches',
      rests: 'rests',
      sectionId: 'sectionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      punches: { 'type': 'array', 'itemType': GetShiftResponseBodyResultSectionsPunches },
      rests: { 'type': 'array', 'itemType': GetShiftResponseBodyResultSectionsRests },
      sectionId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponseBodyResultShiftSetting extends $tea.Model {
  attendDays?: string;
  corpId?: string;
  gmtCreate?: string;
  gmtModified?: string;
  shiftId?: number;
  shiftSettingId?: number;
  workTimeMinutes?: number;
  static names(): { [key: string]: string } {
    return {
      attendDays: 'attendDays',
      corpId: 'corpId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      shiftId: 'shiftId',
      shiftSettingId: 'shiftSettingId',
      workTimeMinutes: 'workTimeMinutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attendDays: 'string',
      corpId: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      shiftId: 'number',
      shiftSettingId: 'number',
      workTimeMinutes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetShiftResponseBodyResult extends $tea.Model {
  corpId?: string;
  id?: number;
  name?: string;
  owner?: string;
  sections?: GetShiftResponseBodyResultSections[];
  shiftGroupId?: number;
  shiftGroupName?: string;
  shiftSetting?: GetShiftResponseBodyResultShiftSetting;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      id: 'id',
      name: 'name',
      owner: 'owner',
      sections: 'sections',
      shiftGroupId: 'shiftGroupId',
      shiftGroupName: 'shiftGroupName',
      shiftSetting: 'shiftSetting',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      id: 'number',
      name: 'string',
      owner: 'string',
      sections: { 'type': 'array', 'itemType': GetShiftResponseBodyResultSections },
      shiftGroupId: 'number',
      shiftGroupName: 'string',
      shiftSetting: GetShiftResponseBodyResultShiftSetting,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleOvertimeSettingResponseBodyResultItems extends $tea.Model {
  id?: number;
  name?: string;
  settingId?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      name: 'name',
      settingId: 'settingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      name: 'string',
      settingId: 'number',
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

export class GroupAddRequestBleDeviceList extends $tea.Model {
  deviceId?: number;
  static names(): { [key: string]: string } {
    return {
      deviceId: 'deviceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deviceId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddRequestFreeCheckSettingFreeCheckGap extends $tea.Model {
  offOnCheckGapMinutes?: number;
  onOffCheckGapMinutes?: number;
  static names(): { [key: string]: string } {
    return {
      offOnCheckGapMinutes: 'offOnCheckGapMinutes',
      onOffCheckGapMinutes: 'onOffCheckGapMinutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      offOnCheckGapMinutes: 'number',
      onOffCheckGapMinutes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddRequestFreeCheckSetting extends $tea.Model {
  delimitOffsetMinutesBetweenDays?: number;
  freeCheckGap?: GroupAddRequestFreeCheckSettingFreeCheckGap;
  static names(): { [key: string]: string } {
    return {
      delimitOffsetMinutesBetweenDays: 'delimitOffsetMinutesBetweenDays',
      freeCheckGap: 'freeCheckGap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delimitOffsetMinutesBetweenDays: 'number',
      freeCheckGap: GroupAddRequestFreeCheckSettingFreeCheckGap,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddRequestMembers extends $tea.Model {
  role?: string;
  type?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      role: 'role',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      role: 'string',
      type: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddRequestPositions extends $tea.Model {
  address?: string;
  latitude?: string;
  longitude?: string;
  offset?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      latitude: 'latitude',
      longitude: 'longitude',
      offset: 'offset',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      latitude: 'string',
      longitude: 'string',
      offset: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddRequestShiftVOList extends $tea.Model {
  shiftId?: number;
  static names(): { [key: string]: string } {
    return {
      shiftId: 'shiftId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shiftId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddRequestWifis extends $tea.Model {
  macAddr?: string;
  ssid?: string;
  static names(): { [key: string]: string } {
    return {
      macAddr: 'macAddr',
      ssid: 'ssid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      macAddr: 'string',
      ssid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupAddResponseBodyResult extends $tea.Model {
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

export class GroupUpdateRequestFreeCheckSettingFreeCheckGap extends $tea.Model {
  offOnCheckGapMinutes?: number;
  onOffCheckGapMinutes?: number;
  static names(): { [key: string]: string } {
    return {
      offOnCheckGapMinutes: 'offOnCheckGapMinutes',
      onOffCheckGapMinutes: 'onOffCheckGapMinutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      offOnCheckGapMinutes: 'number',
      onOffCheckGapMinutes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupUpdateRequestFreeCheckSetting extends $tea.Model {
  delimitOffsetMinutesBetweenDays?: number;
  freeCheckGap?: GroupUpdateRequestFreeCheckSettingFreeCheckGap;
  static names(): { [key: string]: string } {
    return {
      delimitOffsetMinutesBetweenDays: 'delimitOffsetMinutesBetweenDays',
      freeCheckGap: 'freeCheckGap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delimitOffsetMinutesBetweenDays: 'number',
      freeCheckGap: GroupUpdateRequestFreeCheckSettingFreeCheckGap,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupUpdateRequestPositions extends $tea.Model {
  address?: string;
  latitude?: string;
  longitude?: string;
  offset?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      latitude: 'latitude',
      longitude: 'longitude',
      offset: 'offset',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      latitude: 'string',
      longitude: 'string',
      offset: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupUpdateRequestShiftVOList extends $tea.Model {
  shiftId?: number;
  static names(): { [key: string]: string } {
    return {
      shiftId: 'shiftId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      shiftId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupUpdateResponseBodyResult extends $tea.Model {
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

export class ListApproveByUsersResponseBodyResult extends $tea.Model {
  approveId?: string;
  beginTime?: string;
  bizType?: number;
  calculateModel?: number;
  durationUnit?: string;
  endTime?: string;
  subType?: string;
  tagName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      approveId: 'approveId',
      beginTime: 'beginTime',
      bizType: 'bizType',
      calculateModel: 'calculateModel',
      durationUnit: 'durationUnit',
      endTime: 'endTime',
      subType: 'subType',
      tagName: 'tagName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approveId: 'string',
      beginTime: 'string',
      bizType: 'number',
      calculateModel: 'number',
      durationUnit: 'string',
      endTime: 'string',
      subType: 'string',
      tagName: 'string',
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

export class ProcessApproveFinishRequestTopCalculateApproveDurationParam extends $tea.Model {
  bizType?: number;
  calculateModel?: number;
  durationUnit?: string;
  fromTime?: string;
  leaveCode?: string;
  toTime?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      calculateModel: 'calculateModel',
      durationUnit: 'durationUnit',
      fromTime: 'fromTime',
      leaveCode: 'leaveCode',
      toTime: 'toTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'number',
      calculateModel: 'number',
      durationUnit: 'string',
      fromTime: 'string',
      leaveCode: 'string',
      toTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveFinishResponseBodyResultDurationDetail extends $tea.Model {
  date?: string;
  duration?: number;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      duration: 'duration',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'string',
      duration: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessApproveFinishResponseBodyResult extends $tea.Model {
  duration?: number;
  durationDetail?: ProcessApproveFinishResponseBodyResultDurationDetail[];
  static names(): { [key: string]: string } {
    return {
      duration: 'duration',
      durationDetail: 'durationDetail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      duration: 'number',
      durationDetail: { 'type': 'array', 'itemType': ProcessApproveFinishResponseBodyResultDurationDetail },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetainLeaveTypesResponseBodyResultLeaveCertificate extends $tea.Model {
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

export class RetainLeaveTypesResponseBodyResultSubmitTimeRule extends $tea.Model {
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

export class RetainLeaveTypesResponseBodyResultVisibilityRules extends $tea.Model {
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

export class RetainLeaveTypesResponseBodyResult extends $tea.Model {
  bizType?: string;
  hoursInPerDay?: number;
  leaveCertificate?: RetainLeaveTypesResponseBodyResultLeaveCertificate;
  leaveCode?: string;
  leaveHourCeil?: string;
  leaveName?: string;
  leaveTimeCeil?: boolean;
  leaveTimeCeilMinUnit?: string;
  leaveViewUnit?: string;
  lieuDelayNum?: number;
  lieuDelayUnit?: string;
  maxLeaveTime?: number;
  minLeaveHour?: number;
  naturalDayLeave?: boolean;
  paidLeave?: boolean;
  submitTimeRule?: RetainLeaveTypesResponseBodyResultSubmitTimeRule;
  visibilityRules?: RetainLeaveTypesResponseBodyResultVisibilityRules[];
  whenCanLeave?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      hoursInPerDay: 'hoursInPerDay',
      leaveCertificate: 'leaveCertificate',
      leaveCode: 'leaveCode',
      leaveHourCeil: 'leaveHourCeil',
      leaveName: 'leaveName',
      leaveTimeCeil: 'leaveTimeCeil',
      leaveTimeCeilMinUnit: 'leaveTimeCeilMinUnit',
      leaveViewUnit: 'leaveViewUnit',
      lieuDelayNum: 'lieuDelayNum',
      lieuDelayUnit: 'lieuDelayUnit',
      maxLeaveTime: 'maxLeaveTime',
      minLeaveHour: 'minLeaveHour',
      naturalDayLeave: 'naturalDayLeave',
      paidLeave: 'paidLeave',
      submitTimeRule: 'submitTimeRule',
      visibilityRules: 'visibilityRules',
      whenCanLeave: 'whenCanLeave',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      hoursInPerDay: 'number',
      leaveCertificate: RetainLeaveTypesResponseBodyResultLeaveCertificate,
      leaveCode: 'string',
      leaveHourCeil: 'string',
      leaveName: 'string',
      leaveTimeCeil: 'boolean',
      leaveTimeCeilMinUnit: 'string',
      leaveViewUnit: 'string',
      lieuDelayNum: 'number',
      lieuDelayUnit: 'string',
      maxLeaveTime: 'number',
      minLeaveHour: 'number',
      naturalDayLeave: 'boolean',
      paidLeave: 'boolean',
      submitTimeRule: RetainLeaveTypesResponseBodyResultSubmitTimeRule,
      visibilityRules: { 'type': 'array', 'itemType': RetainLeaveTypesResponseBodyResultVisibilityRules },
      whenCanLeave: 'string',
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

    if (!Util.isUnset(request.freedomLeave)) {
      body["freedomLeave"] = request.freedomLeave;
    }

    if (!Util.isUnset(request.hoursInPerDay)) {
      body["hoursInPerDay"] = request.hoursInPerDay;
    }

    if (!Util.isUnset(request.leaveCertificate)) {
      body["leaveCertificate"] = request.leaveCertificate;
    }

    if (!Util.isUnset(request.leaveHourCeil)) {
      body["leaveHourCeil"] = request.leaveHourCeil;
    }

    if (!Util.isUnset(request.leaveName)) {
      body["leaveName"] = request.leaveName;
    }

    if (!Util.isUnset(request.leaveTimeCeil)) {
      body["leaveTimeCeil"] = request.leaveTimeCeil;
    }

    if (!Util.isUnset(request.leaveTimeCeilMinUnit)) {
      body["leaveTimeCeilMinUnit"] = request.leaveTimeCeilMinUnit;
    }

    if (!Util.isUnset(request.leaveViewUnit)) {
      body["leaveViewUnit"] = request.leaveViewUnit;
    }

    if (!Util.isUnset(request.maxLeaveTime)) {
      body["maxLeaveTime"] = request.maxLeaveTime;
    }

    if (!Util.isUnset(request.minLeaveHour)) {
      body["minLeaveHour"] = request.minLeaveHour;
    }

    if (!Util.isUnset(request.naturalDayLeave)) {
      body["naturalDayLeave"] = request.naturalDayLeave;
    }

    if (!Util.isUnset(request.paidLeave)) {
      body["paidLeave"] = request.paidLeave;
    }

    if (!Util.isUnset(request.submitTimeRule)) {
      body["submitTimeRule"] = request.submitTimeRule;
    }

    if (!Util.isUnset(request.visibilityRules)) {
      body["visibilityRules"] = request.visibilityRules;
    }

    if (!Util.isUnset(request.whenCanLeave)) {
      body["whenCanLeave"] = request.whenCanLeave;
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
    let params = new $OpenApi.Params({
      action: "AddLeaveType",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/leaves/types`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddLeaveTypeResponse>(await this.execute(params, req, runtime), new AddLeaveTypeResponse({}));
  }

  async addLeaveType(request: AddLeaveTypeRequest): Promise<AddLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLeaveTypeHeaders({ });
    return await this.addLeaveTypeWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "AttendanceBleDevicesAdd",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/group/bledevices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AttendanceBleDevicesAddResponse>(await this.execute(params, req, runtime), new AttendanceBleDevicesAddResponse({}));
  }

  async attendanceBleDevicesAdd(request: AttendanceBleDevicesAddRequest): Promise<AttendanceBleDevicesAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesAddHeaders({ });
    return await this.attendanceBleDevicesAddWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "AttendanceBleDevicesQuery",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/group/bledevices/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AttendanceBleDevicesQueryResponse>(await this.execute(params, req, runtime), new AttendanceBleDevicesQueryResponse({}));
  }

  async attendanceBleDevicesQuery(request: AttendanceBleDevicesQueryRequest): Promise<AttendanceBleDevicesQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesQueryHeaders({ });
    return await this.attendanceBleDevicesQueryWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "AttendanceBleDevicesRemove",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/group/bledevices/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AttendanceBleDevicesRemoveResponse>(await this.execute(params, req, runtime), new AttendanceBleDevicesRemoveResponse({}));
  }

  async attendanceBleDevicesRemove(request: AttendanceBleDevicesRemoveRequest): Promise<AttendanceBleDevicesRemoveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesRemoveHeaders({ });
    return await this.attendanceBleDevicesRemoveWithOptions(request, headers, runtime);
  }

  async batchBossCheckWithOptions(request: BatchBossCheckRequest, headers: BatchBossCheckHeaders, runtime: $Util.RuntimeOptions): Promise<BatchBossCheckResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.models)) {
      body["models"] = request.models;
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
    let params = new $OpenApi.Params({
      action: "BatchBossCheck",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/results/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchBossCheckResponse>(await this.execute(params, req, runtime), new BatchBossCheckResponse({}));
  }

  async batchBossCheck(request: BatchBossCheckRequest): Promise<BatchBossCheckResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchBossCheckHeaders({ });
    return await this.batchBossCheckWithOptions(request, headers, runtime);
  }

  async calculateDurationWithOptions(request: CalculateDurationRequest, headers: CalculateDurationHeaders, runtime: $Util.RuntimeOptions): Promise<CalculateDurationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.calculateModel)) {
      body["calculateModel"] = request.calculateModel;
    }

    if (!Util.isUnset(request.durationUnit)) {
      body["durationUnit"] = request.durationUnit;
    }

    if (!Util.isUnset(request.fromTime)) {
      body["fromTime"] = request.fromTime;
    }

    if (!Util.isUnset(request.leaveCode)) {
      body["leaveCode"] = request.leaveCode;
    }

    if (!Util.isUnset(request.toTime)) {
      body["toTime"] = request.toTime;
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
    let params = new $OpenApi.Params({
      action: "CalculateDuration",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/approvals/durations/calculate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CalculateDurationResponse>(await this.execute(params, req, runtime), new CalculateDurationResponse({}));
  }

  async calculateDuration(request: CalculateDurationRequest): Promise<CalculateDurationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CalculateDurationHeaders({ });
    return await this.calculateDurationWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CheckClosingAccount",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/closingAccounts/status/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CheckClosingAccountResponse>(await this.execute(params, req, runtime), new CheckClosingAccountResponse({}));
  }

  async checkClosingAccount(request: CheckClosingAccountRequest): Promise<CheckClosingAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckClosingAccountHeaders({ });
    return await this.checkClosingAccountWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CheckWritePermission",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/writePermissions/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CheckWritePermissionResponse>(await this.execute(params, req, runtime), new CheckWritePermissionResponse({}));
  }

  async checkWritePermission(request: CheckWritePermissionRequest): Promise<CheckWritePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckWritePermissionHeaders({ });
    return await this.checkWritePermissionWithOptions(request, headers, runtime);
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

    if (!Util.isUnset(request.punchParam)) {
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
    let params = new $OpenApi.Params({
      action: "CreateApprove",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/approves`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateApproveResponse>(await this.execute(params, req, runtime), new CreateApproveResponse({}));
  }

  async createApprove(request: CreateApproveRequest): Promise<CreateApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateApproveHeaders({ });
    return await this.createApproveWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "DeleteWaterMarkTemplate",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/watermarks/templates`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteWaterMarkTemplateResponse>(await this.execute(params, req, runtime), new DeleteWaterMarkTemplateResponse({}));
  }

  async deleteWaterMarkTemplate(request: DeleteWaterMarkTemplateRequest): Promise<DeleteWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWaterMarkTemplateHeaders({ });
    return await this.deleteWaterMarkTemplateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "DingTalkSecurityCheck",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/securities/check`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DingTalkSecurityCheckResponse>(await this.execute(params, req, runtime), new DingTalkSecurityCheckResponse({}));
  }

  async dingTalkSecurityCheck(request: DingTalkSecurityCheckRequest): Promise<DingTalkSecurityCheckResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DingTalkSecurityCheckHeaders({ });
    return await this.dingTalkSecurityCheckWithOptions(request, headers, runtime);
  }

  async getATManageScopeWithOptions(request: GetATManageScopeRequest, headers: GetATManageScopeHeaders, runtime: $Util.RuntimeOptions): Promise<GetATManageScopeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      action: "GetATManageScope",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/manageScopes`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetATManageScopeResponse>(await this.execute(params, req, runtime), new GetATManageScopeResponse({}));
  }

  async getATManageScope(request: GetATManageScopeRequest): Promise<GetATManageScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetATManageScopeHeaders({ });
    return await this.getATManageScopeWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetAdjustments",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/adjustments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAdjustmentsResponse>(await this.execute(params, req, runtime), new GetAdjustmentsResponse({}));
  }

  async getAdjustments(request: GetAdjustmentsRequest): Promise<GetAdjustmentsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAdjustmentsHeaders({ });
    return await this.getAdjustmentsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetCheckInSchemaTemplate",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/watermarks/templates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCheckInSchemaTemplateResponse>(await this.execute(params, req, runtime), new GetCheckInSchemaTemplateResponse({}));
  }

  async getCheckInSchemaTemplate(request: GetCheckInSchemaTemplateRequest): Promise<GetCheckInSchemaTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCheckInSchemaTemplateHeaders({ });
    return await this.getCheckInSchemaTemplateWithOptions(request, headers, runtime);
  }

  async getCheckinRecordByUserWithOptions(request: GetCheckinRecordByUserRequest, headers: GetCheckinRecordByUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetCheckinRecordByUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
      action: "GetCheckinRecordByUser",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/checkin/records/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCheckinRecordByUserResponse>(await this.execute(params, req, runtime), new GetCheckinRecordByUserResponse({}));
  }

  async getCheckinRecordByUser(request: GetCheckinRecordByUserRequest): Promise<GetCheckinRecordByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCheckinRecordByUserHeaders({ });
    return await this.getCheckinRecordByUserWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetClosingAccounts",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/closingAccounts/rules/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetClosingAccountsResponse>(await this.execute(params, req, runtime), new GetClosingAccountsResponse({}));
  }

  async getClosingAccounts(request: GetClosingAccountsRequest): Promise<GetClosingAccountsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetClosingAccountsHeaders({ });
    return await this.getClosingAccountsWithOptions(request, headers, runtime);
  }

  async getLeaveRecordsWithOptions(request: GetLeaveRecordsRequest, headers: GetLeaveRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetLeaveRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.leaveCode)) {
      body["leaveCode"] = request.leaveCode;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

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
    let params = new $OpenApi.Params({
      action: "GetLeaveRecords",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/vacations/records/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetLeaveRecordsResponse>(await this.execute(params, req, runtime), new GetLeaveRecordsResponse({}));
  }

  async getLeaveRecords(request: GetLeaveRecordsRequest): Promise<GetLeaveRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLeaveRecordsHeaders({ });
    return await this.getLeaveRecordsWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetLeaveType",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/leaves/types`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetLeaveTypeResponse>(await this.execute(params, req, runtime), new GetLeaveTypeResponse({}));
  }

  async getLeaveType(request: GetLeaveTypeRequest): Promise<GetLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLeaveTypeHeaders({ });
    return await this.getLeaveTypeWithOptions(request, headers, runtime);
  }

  async getMachineWithOptions(devId: string, headers: GetMachineHeaders, runtime: $Util.RuntimeOptions): Promise<GetMachineResponse> {
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
      action: "GetMachine",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/machines/${devId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetMachineResponse>(await this.execute(params, req, runtime), new GetMachineResponse({}));
  }

  async getMachine(devId: string): Promise<GetMachineResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMachineHeaders({ });
    return await this.getMachineWithOptions(devId, headers, runtime);
  }

  async getMachineUserWithOptions(devId: string, request: GetMachineUserRequest, headers: GetMachineUserHeaders, runtime: $Util.RuntimeOptions): Promise<GetMachineUserResponse> {
    Util.validateModel(request);
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
    let params = new $OpenApi.Params({
      action: "GetMachineUser",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/machines/getUser/${devId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetMachineUserResponse>(await this.execute(params, req, runtime), new GetMachineUserResponse({}));
  }

  async getMachineUser(devId: string, request: GetMachineUserRequest): Promise<GetMachineUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMachineUserHeaders({ });
    return await this.getMachineUserWithOptions(devId, request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetOvertimeSetting",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/overtimeSettings/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOvertimeSettingResponse>(await this.execute(params, req, runtime), new GetOvertimeSettingResponse({}));
  }

  async getOvertimeSetting(request: GetOvertimeSettingRequest): Promise<GetOvertimeSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOvertimeSettingHeaders({ });
    return await this.getOvertimeSettingWithOptions(request, headers, runtime);
  }

  async getShiftWithOptions(request: GetShiftRequest, headers: GetShiftHeaders, runtime: $Util.RuntimeOptions): Promise<GetShiftResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.shiftId)) {
      query["shiftId"] = request.shiftId;
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
      action: "GetShift",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/shifts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetShiftResponse>(await this.execute(params, req, runtime), new GetShiftResponse({}));
  }

  async getShift(request: GetShiftRequest): Promise<GetShiftResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShiftHeaders({ });
    return await this.getShiftWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetSimpleOvertimeSetting",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/overtimeSettings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSimpleOvertimeSettingResponse>(await this.execute(params, req, runtime), new GetSimpleOvertimeSettingResponse({}));
  }

  async getSimpleOvertimeSetting(request: GetSimpleOvertimeSettingRequest): Promise<GetSimpleOvertimeSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSimpleOvertimeSettingHeaders({ });
    return await this.getSimpleOvertimeSettingWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetUserHolidays",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/holidays`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserHolidaysResponse>(await this.execute(params, req, runtime), new GetUserHolidaysResponse({}));
  }

  async getUserHolidays(request: GetUserHolidaysRequest): Promise<GetUserHolidaysResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHolidaysHeaders({ });
    return await this.getUserHolidaysWithOptions(request, headers, runtime);
  }

  async groupAddWithOptions(request: GroupAddRequest, headers: GroupAddHeaders, runtime: $Util.RuntimeOptions): Promise<GroupAddResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.adjustmentSettingId)) {
      body["adjustmentSettingId"] = request.adjustmentSettingId;
    }

    if (!Util.isUnset(request.bleDeviceList)) {
      body["bleDeviceList"] = request.bleDeviceList;
    }

    if (!Util.isUnset(request.checkNeedHealthyCode)) {
      body["checkNeedHealthyCode"] = request.checkNeedHealthyCode;
    }

    if (!Util.isUnset(request.defaultClassId)) {
      body["defaultClassId"] = request.defaultClassId;
    }

    if (!Util.isUnset(request.disableCheckWhenRest)) {
      body["disableCheckWhenRest"] = request.disableCheckWhenRest;
    }

    if (!Util.isUnset(request.disableCheckWithoutSchedule)) {
      body["disableCheckWithoutSchedule"] = request.disableCheckWithoutSchedule;
    }

    if (!Util.isUnset(request.enableCameraCheck)) {
      body["enableCameraCheck"] = request.enableCameraCheck;
    }

    if (!Util.isUnset(request.enableEmpSelectClass)) {
      body["enableEmpSelectClass"] = request.enableEmpSelectClass;
    }

    if (!Util.isUnset(request.enableFaceCheck)) {
      body["enableFaceCheck"] = request.enableFaceCheck;
    }

    if (!Util.isUnset(request.enableFaceStrictMode)) {
      body["enableFaceStrictMode"] = request.enableFaceStrictMode;
    }

    if (!Util.isUnset(request.enableNextDay)) {
      body["enableNextDay"] = request.enableNextDay;
    }

    if (!Util.isUnset(request.enableOutSideUpdateNormalCheck)) {
      body["enableOutSideUpdateNormalCheck"] = request.enableOutSideUpdateNormalCheck;
    }

    if (!Util.isUnset(request.enableOutsideApply)) {
      body["enableOutsideApply"] = request.enableOutsideApply;
    }

    if (!Util.isUnset(request.enableOutsideCameraCheck)) {
      body["enableOutsideCameraCheck"] = request.enableOutsideCameraCheck;
    }

    if (!Util.isUnset(request.enableOutsideCheck)) {
      body["enableOutsideCheck"] = request.enableOutsideCheck;
    }

    if (!Util.isUnset(request.enableOutsideRemark)) {
      body["enableOutsideRemark"] = request.enableOutsideRemark;
    }

    if (!Util.isUnset(request.enablePositionBle)) {
      body["enablePositionBle"] = request.enablePositionBle;
    }

    if (!Util.isUnset(request.enableTrimDistance)) {
      body["enableTrimDistance"] = request.enableTrimDistance;
    }

    if (!Util.isUnset(request.forbidHideOutSideAddress)) {
      body["forbidHideOutSideAddress"] = request.forbidHideOutSideAddress;
    }

    if (!Util.isUnset(request.freeCheckSetting)) {
      body["freeCheckSetting"] = request.freeCheckSetting;
    }

    if (!Util.isUnset(request.freeCheckTypeId)) {
      body["freeCheckTypeId"] = request.freeCheckTypeId;
    }

    if (!Util.isUnset(request.freecheckDayStartMinOffset)) {
      body["freecheckDayStartMinOffset"] = request.freecheckDayStartMinOffset;
    }

    if (!Util.isUnset(request.freecheckWorkDays)) {
      body["freecheckWorkDays"] = request.freecheckWorkDays;
    }

    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.managerList)) {
      body["managerList"] = request.managerList;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.modifyMember)) {
      body["modifyMember"] = request.modifyMember;
    }

    if (!Util.isUnset(request.offset)) {
      body["offset"] = request.offset;
    }

    if (!Util.isUnset(request.openCameraCheck)) {
      body["openCameraCheck"] = request.openCameraCheck;
    }

    if (!Util.isUnset(request.openFaceCheck)) {
      body["openFaceCheck"] = request.openFaceCheck;
    }

    if (!Util.isUnset(request.outsideCheckApproveModeId)) {
      body["outsideCheckApproveModeId"] = request.outsideCheckApproveModeId;
    }

    if (!Util.isUnset(request.overtimeSettingId)) {
      body["overtimeSettingId"] = request.overtimeSettingId;
    }

    if (!Util.isUnset(request.owner)) {
      body["owner"] = request.owner;
    }

    if (!Util.isUnset(request.positions)) {
      body["positions"] = request.positions;
    }

    if (!Util.isUnset(request.resourcePermissionMap)) {
      body["resourcePermissionMap"] = request.resourcePermissionMap;
    }

    if (!Util.isUnset(request.shiftVOList)) {
      body["shiftVOList"] = request.shiftVOList;
    }

    if (!Util.isUnset(request.skipHolidays)) {
      body["skipHolidays"] = request.skipHolidays;
    }

    if (!Util.isUnset(request.specialDays)) {
      body["specialDays"] = request.specialDays;
    }

    if (!Util.isUnset(request.trimDistance)) {
      body["trimDistance"] = request.trimDistance;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.wifis)) {
      body["wifis"] = request.wifis;
    }

    if (!Util.isUnset(request.workdayClassList)) {
      body["workdayClassList"] = request.workdayClassList;
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
    let params = new $OpenApi.Params({
      action: "GroupAdd",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupAddResponse>(await this.execute(params, req, runtime), new GroupAddResponse({}));
  }

  async groupAdd(request: GroupAddRequest): Promise<GroupAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupAddHeaders({ });
    return await this.groupAddWithOptions(request, headers, runtime);
  }

  async groupUpdateWithOptions(request: GroupUpdateRequest, headers: GroupUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<GroupUpdateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.adjustmentSettingId)) {
      body["adjustmentSettingId"] = request.adjustmentSettingId;
    }

    if (!Util.isUnset(request.disableCheckWhenRest)) {
      body["disableCheckWhenRest"] = request.disableCheckWhenRest;
    }

    if (!Util.isUnset(request.disableCheckWithoutSchedule)) {
      body["disableCheckWithoutSchedule"] = request.disableCheckWithoutSchedule;
    }

    if (!Util.isUnset(request.enableCameraCheck)) {
      body["enableCameraCheck"] = request.enableCameraCheck;
    }

    if (!Util.isUnset(request.enableEmpSelectClass)) {
      body["enableEmpSelectClass"] = request.enableEmpSelectClass;
    }

    if (!Util.isUnset(request.enableFaceCheck)) {
      body["enableFaceCheck"] = request.enableFaceCheck;
    }

    if (!Util.isUnset(request.enableFaceStrictMode)) {
      body["enableFaceStrictMode"] = request.enableFaceStrictMode;
    }

    if (!Util.isUnset(request.enableOutSideUpdateNormalCheck)) {
      body["enableOutSideUpdateNormalCheck"] = request.enableOutSideUpdateNormalCheck;
    }

    if (!Util.isUnset(request.enableOutsideApply)) {
      body["enableOutsideApply"] = request.enableOutsideApply;
    }

    if (!Util.isUnset(request.enableOutsideCheck)) {
      body["enableOutsideCheck"] = request.enableOutsideCheck;
    }

    if (!Util.isUnset(request.enableOutsideRemark)) {
      body["enableOutsideRemark"] = request.enableOutsideRemark;
    }

    if (!Util.isUnset(request.enableTrimDistance)) {
      body["enableTrimDistance"] = request.enableTrimDistance;
    }

    if (!Util.isUnset(request.forbidHideOutSideAddress)) {
      body["forbidHideOutSideAddress"] = request.forbidHideOutSideAddress;
    }

    if (!Util.isUnset(request.freeCheckSetting)) {
      body["freeCheckSetting"] = request.freeCheckSetting;
    }

    if (!Util.isUnset(request.freeCheckTypeId)) {
      body["freeCheckTypeId"] = request.freeCheckTypeId;
    }

    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.managerList)) {
      body["managerList"] = request.managerList;
    }

    if (!Util.isUnset(request.offset)) {
      body["offset"] = request.offset;
    }

    if (!Util.isUnset(request.openCameraCheck)) {
      body["openCameraCheck"] = request.openCameraCheck;
    }

    if (!Util.isUnset(request.openFaceCheck)) {
      body["openFaceCheck"] = request.openFaceCheck;
    }

    if (!Util.isUnset(request.outsideCheckApproveModeId)) {
      body["outsideCheckApproveModeId"] = request.outsideCheckApproveModeId;
    }

    if (!Util.isUnset(request.overtimeSettingId)) {
      body["overtimeSettingId"] = request.overtimeSettingId;
    }

    if (!Util.isUnset(request.owner)) {
      body["owner"] = request.owner;
    }

    if (!Util.isUnset(request.positions)) {
      body["positions"] = request.positions;
    }

    if (!Util.isUnset(request.resourcePermissionMap)) {
      body["resourcePermissionMap"] = request.resourcePermissionMap;
    }

    if (!Util.isUnset(request.shiftVOList)) {
      body["shiftVOList"] = request.shiftVOList;
    }

    if (!Util.isUnset(request.skipHolidays)) {
      body["skipHolidays"] = request.skipHolidays;
    }

    if (!Util.isUnset(request.trimDistance)) {
      body["trimDistance"] = request.trimDistance;
    }

    if (!Util.isUnset(request.workdayClassList)) {
      body["workdayClassList"] = request.workdayClassList;
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
    let params = new $OpenApi.Params({
      action: "GroupUpdate",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/groups`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupUpdateResponse>(await this.execute(params, req, runtime), new GroupUpdateResponse({}));
  }

  async groupUpdate(request: GroupUpdateRequest): Promise<GroupUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupUpdateHeaders({ });
    return await this.groupUpdateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "InitAndGetLeaveALlocationQuotas",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/leaves/initializations/balances`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InitAndGetLeaveALlocationQuotasResponse>(await this.execute(params, req, runtime), new InitAndGetLeaveALlocationQuotasResponse({}));
  }

  async initAndGetLeaveALlocationQuotas(request: InitAndGetLeaveALlocationQuotasRequest): Promise<InitAndGetLeaveALlocationQuotasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitAndGetLeaveALlocationQuotasHeaders({ });
    return await this.initAndGetLeaveALlocationQuotasWithOptions(request, headers, runtime);
  }

  async listApproveByUsersWithOptions(request: ListApproveByUsersRequest, headers: ListApproveByUsersHeaders, runtime: $Util.RuntimeOptions): Promise<ListApproveByUsersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizTypes)) {
      body["bizTypes"] = request.bizTypes;
    }

    if (!Util.isUnset(request.fromDateTime)) {
      body["fromDateTime"] = request.fromDateTime;
    }

    if (!Util.isUnset(request.toDateTime)) {
      body["toDateTime"] = request.toDateTime;
    }

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
    let params = new $OpenApi.Params({
      action: "ListApproveByUsers",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/approvals/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListApproveByUsersResponse>(await this.execute(params, req, runtime), new ListApproveByUsersResponse({}));
  }

  async listApproveByUsers(request: ListApproveByUsersRequest): Promise<ListApproveByUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApproveByUsersHeaders({ });
    return await this.listApproveByUsersWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "ModifyWaterMarkTemplate",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/watermarks/templates`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ModifyWaterMarkTemplateResponse>(await this.execute(params, req, runtime), new ModifyWaterMarkTemplateResponse({}));
  }

  async modifyWaterMarkTemplate(request: ModifyWaterMarkTemplateRequest): Promise<ModifyWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyWaterMarkTemplateHeaders({ });
    return await this.modifyWaterMarkTemplateWithOptions(request, headers, runtime);
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

    if (!Util.isUnset(request.punchParam)) {
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
    let params = new $OpenApi.Params({
      action: "ProcessApproveCreate",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/workflows/checkInForms`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ProcessApproveCreateResponse>(await this.execute(params, req, runtime), new ProcessApproveCreateResponse({}));
  }

  async processApproveCreate(request: ProcessApproveCreateRequest): Promise<ProcessApproveCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessApproveCreateHeaders({ });
    return await this.processApproveCreateWithOptions(request, headers, runtime);
  }

  async processApproveFinishWithOptions(request: ProcessApproveFinishRequest, headers: ProcessApproveFinishHeaders, runtime: $Util.RuntimeOptions): Promise<ProcessApproveFinishResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.approveId)) {
      body["approveId"] = request.approveId;
    }

    if (!Util.isUnset(request.jumpUrl)) {
      body["jumpUrl"] = request.jumpUrl;
    }

    if (!Util.isUnset(request.overTimeToMore)) {
      body["overTimeToMore"] = request.overTimeToMore;
    }

    if (!Util.isUnset(request.overtimeDuration)) {
      body["overtimeDuration"] = request.overtimeDuration;
    }

    if (!Util.isUnset(request.subType)) {
      body["subType"] = request.subType;
    }

    if (!Util.isUnset(request.tagName)) {
      body["tagName"] = request.tagName;
    }

    if (!Util.isUnset(request.topCalculateApproveDurationParam)) {
      body["topCalculateApproveDurationParam"] = request.topCalculateApproveDurationParam;
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
    let params = new $OpenApi.Params({
      action: "ProcessApproveFinish",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/approvals/finish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ProcessApproveFinishResponse>(await this.execute(params, req, runtime), new ProcessApproveFinishResponse({}));
  }

  async processApproveFinish(request: ProcessApproveFinishRequest): Promise<ProcessApproveFinishResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessApproveFinishHeaders({ });
    return await this.processApproveFinishWithOptions(request, headers, runtime);
  }

  async reduceQuotaWithLeaveRecordWithOptions(unionId: string, request: ReduceQuotaWithLeaveRecordRequest, headers: ReduceQuotaWithLeaveRecordHeaders, runtime: $Util.RuntimeOptions): Promise<ReduceQuotaWithLeaveRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.leaveCode)) {
      body["leaveCode"] = request.leaveCode;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset(request.quotaNum)) {
      body["quotaNum"] = request.quotaNum;
    }

    if (!Util.isUnset(request.reason)) {
      body["reason"] = request.reason;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
      action: "ReduceQuotaWithLeaveRecord",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/users/${unionId}/vacations/records/modify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReduceQuotaWithLeaveRecordResponse>(await this.execute(params, req, runtime), new ReduceQuotaWithLeaveRecordResponse({}));
  }

  async reduceQuotaWithLeaveRecord(unionId: string, request: ReduceQuotaWithLeaveRecordRequest): Promise<ReduceQuotaWithLeaveRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReduceQuotaWithLeaveRecordHeaders({ });
    return await this.reduceQuotaWithLeaveRecordWithOptions(unionId, request, headers, runtime);
  }

  async retainLeaveTypesWithOptions(request: RetainLeaveTypesRequest, headers: RetainLeaveTypesHeaders, runtime: $Util.RuntimeOptions): Promise<RetainLeaveTypesResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.leaveCodes)) {
      body["leaveCodes"] = request.leaveCodes;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
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
      action: "RetainLeaveTypes",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/vacations/types/change`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RetainLeaveTypesResponse>(await this.execute(params, req, runtime), new RetainLeaveTypesResponse({}));
  }

  async retainLeaveTypes(request: RetainLeaveTypesRequest): Promise<RetainLeaveTypesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetainLeaveTypesHeaders({ });
    return await this.retainLeaveTypesWithOptions(request, headers, runtime);
  }

  async reverseTrialAdvancedLeaveWithOptions(request: ReverseTrialAdvancedLeaveRequest, headers: ReverseTrialAdvancedLeaveHeaders, runtime: $Util.RuntimeOptions): Promise<ReverseTrialAdvancedLeaveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.servCode)) {
      query["servCode"] = request.servCode;
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
      action: "ReverseTrialAdvancedLeave",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/leaves/reverse`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReverseTrialAdvancedLeaveResponse>(await this.execute(params, req, runtime), new ReverseTrialAdvancedLeaveResponse({}));
  }

  async reverseTrialAdvancedLeave(request: ReverseTrialAdvancedLeaveRequest): Promise<ReverseTrialAdvancedLeaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReverseTrialAdvancedLeaveHeaders({ });
    return await this.reverseTrialAdvancedLeaveWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SaveCustomWaterMarkTemplate",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/watermarks/templates`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveCustomWaterMarkTemplateResponse>(await this.execute(params, req, runtime), new SaveCustomWaterMarkTemplateResponse({}));
  }

  async saveCustomWaterMarkTemplate(request: SaveCustomWaterMarkTemplateRequest): Promise<SaveCustomWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveCustomWaterMarkTemplateHeaders({ });
    return await this.saveCustomWaterMarkTemplateWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "SyncScheduleInfo",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/schedules/additionalInfo`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<SyncScheduleInfoResponse>(await this.execute(params, req, runtime), new SyncScheduleInfoResponse({}));
  }

  async syncScheduleInfo(request: SyncScheduleInfoRequest): Promise<SyncScheduleInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncScheduleInfoHeaders({ });
    return await this.syncScheduleInfoWithOptions(request, headers, runtime);
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

    if (!Util.isUnset(request.leaveCertificate)) {
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

    if (!Util.isUnset(request.submitTimeRule)) {
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
    let params = new $OpenApi.Params({
      action: "UpdateLeaveType",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/leaves/types`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateLeaveTypeResponse>(await this.execute(params, req, runtime), new UpdateLeaveTypeResponse({}));
  }

  async updateLeaveType(request: UpdateLeaveTypeRequest): Promise<UpdateLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateLeaveTypeHeaders({ });
    return await this.updateLeaveTypeWithOptions(request, headers, runtime);
  }

}
