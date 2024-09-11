// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * general_leave
   */
  bizType?: string;
  /**
   * @example
   * {"validity_type":"absolute_time","validity_value":"12-31"}
   */
  extras?: string;
  /**
   * @example
   * false
   */
  freedomLeave?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1000
   */
  hoursInPerDay?: number;
  leaveCertificate?: AddLeaveTypeRequestLeaveCertificate;
  /**
   * @example
   * up
   */
  leaveHourCeil?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 年假
   */
  leaveName?: string;
  /**
   * @example
   * false
   */
  leaveTimeCeil?: boolean;
  /**
   * @example
   * hour
   */
  leaveTimeCeilMinUnit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * day
   */
  leaveViewUnit?: string;
  /**
   * @example
   * 1
   */
  maxLeaveTime?: number;
  /**
   * @example
   * 2
   */
  minLeaveHour?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  naturalDayLeave?: boolean;
  /**
   * @example
   * false
   */
  paidLeave?: boolean;
  submitTimeRule?: AddLeaveTypeRequestSubmitTimeRule;
  visibilityRules?: AddLeaveTypeRequestVisibilityRules[];
  /**
   * @example
   * entry
   */
  whenCanLeave?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddLeaveTypeResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  deviceIdList?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 62001E1C5B9362D369D316DED25F3656
   */
  groupKey?: string;
  /**
   * @example
   * userId001
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AttendanceBleDevicesAddResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 62001E1C5B9XXXX369D316DED25FXXXX
   */
  groupKey?: string;
  /**
   * @example
   * userId001
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AttendanceBleDevicesQueryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  deviceIdList?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 62001E1C5B9362D369D316DED25F3656
   */
  groupKey?: string;
  /**
   * @example
   * userId001
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AttendanceBleDevicesRemoveResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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

export class BatchBossCheckResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchBossCheckResponseBody;
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
  /**
   * @example
   * 3
   */
  bizType?: number;
  /**
   * @example
   * 1
   */
  calculateModel?: number;
  /**
   * @example
   * day
   */
  durationUnit?: string;
  /**
   * @example
   * 2019-08-15
   */
  fromTime?: string;
  /**
   * @example
   * e2dsad-34dfa-2vas23da
   */
  leaveCode?: string;
  /**
   * @example
   * 2019-08-15
   */
  toTime?: string;
  /**
   * @example
   * manager123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CalculateDurationResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mesage?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckClosingAccountResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * GROUP
   */
  category?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  entityIds?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 050728xxx921
   */
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SCHEDULE
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckWritePermissionResponseBody;
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
  /**
   * @example
   * 341lkfjdkf
   */
  approveId?: string;
  /**
   * @example
   * 4243235dfd
   */
  opUserid?: string;
  punchParam?: CreateApproveRequestPunchParam;
  /**
   * @example
   * 年假
   */
  subType?: string;
  /**
   * @example
   * 请假
   */
  tagName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fdfi3435
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateApproveResponseBody;
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

export class DeleteLeaveRequestHeaders extends $tea.Model {
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

export class DeleteLeaveRequestRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * zxfgsdfsdfvsd
   */
  outerId?: string;
  static names(): { [key: string]: string } {
    return {
      outerId: 'outerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLeaveRequestResponseBody extends $tea.Model {
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

export class DeleteLeaveRequestResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteLeaveRequestResponseBody;
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
      body: DeleteLeaveRequestResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-292988B1-5064-4A42-9389-A76B97xxxxx
   */
  formCode?: string;
  /**
   * @example
   * {     \"items\":[         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"enableModifyPlace\",                 \"id\":\"enableModifyPlace-undefined\",                 \"value\":\"true\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"modifyPlaceDistance\",                 \"id\":\"modifyPlaceDistance-undefined\",                 \"value\":200             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"title\",                 \"id\":\"title-undefined\",                 \"value\":\"wofu1\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"titleBgColor\",                 \"id\":\"titleBgColor-undefined\",                 \"value\":\"#0089FF\"             }         }     ] }
   */
  formContent?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  systemTemplate?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manage123
   */
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
  /**
   * @example
   * PROC-292988B1-5064-4A42-9389-A76B97xxxxx
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

export class DeleteWaterMarkTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteWaterMarkTemplateResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 6.3.30
   */
  clientVer?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iOS
   */
  platform?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 15
   */
  platformVer?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"lbsWuaToken": "lbsWua","ddSec":"ddSec"}
   */
  sec?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DingTalkSecurityCheckResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetATManageScopeResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAdjustmentsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * water_mark_checkin
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567
   */
  openConversationId?: string;
  /**
   * @example
   * water_mark_checkin
   */
  sceneCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manage123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCheckInSchemaTemplateResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCheckinRecordByUserResponseBody;
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

export class GetClassWithDeletedHeaders extends $tea.Model {
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

export class GetClassWithDeletedResponseBody extends $tea.Model {
  result?: GetClassWithDeletedResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetClassWithDeletedResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClassWithDeletedResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetClassWithDeletedResponseBody;
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
      body: GetClassWithDeletedResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetClosingAccountsResponseBody;
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

export class GetColumnvalsHeaders extends $tea.Model {
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

export class GetColumnvalsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  columnIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1709222400000
   */
  fromDate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1711728000000
   */
  toDate?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      columnIdList: 'columnIdList',
      fromDate: 'fromDate',
      toDate: 'toDate',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      columnIdList: { 'type': 'array', 'itemType': 'string' },
      fromDate: 'number',
      toDate: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetColumnvalsResponseBody extends $tea.Model {
  result?: GetColumnvalsResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetColumnvalsResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetColumnvalsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetColumnvalsResponseBody;
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
      body: GetColumnvalsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f84a2dxxxx
   */
  leaveCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetLeaveRecordsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
  opUserId?: string;
  /**
   * @example
   * all
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetLeaveTypeResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMachineResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMachineUserResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOvertimeSettingResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetShiftResponseBody;
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

export class GetSimpleGroupsHeaders extends $tea.Model {
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

export class GetSimpleGroupsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
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
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBody extends $tea.Model {
  result?: GetSimpleGroupsResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetSimpleGroupsResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSimpleGroupsResponseBody;
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
      body: GetSimpleGroupsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSimpleOvertimeSettingResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  workDateFrom?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserHolidaysResponseBody;
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
  /**
   * @example
   * 123L
   */
  adjustmentSettingId?: number;
  bleDeviceList?: GroupAddRequestBleDeviceList[];
  /**
   * @example
   * true
   */
  checkNeedHealthyCode?: boolean;
  /**
   * @example
   * 1234
   */
  defaultClassId?: number;
  /**
   * @example
   * true
   */
  disableCheckWhenRest?: boolean;
  /**
   * @example
   * true
   */
  disableCheckWithoutSchedule?: boolean;
  /**
   * @example
   * true
   */
  enableCameraCheck?: boolean;
  /**
   * @example
   * true
   */
  enableEmpSelectClass?: boolean;
  /**
   * @example
   * true
   */
  enableFaceCheck?: boolean;
  /**
   * @example
   * true
   */
  enableFaceStrictMode?: boolean;
  /**
   * @example
   * true
   */
  enableNextDay?: boolean;
  /**
   * @example
   * true
   */
  enableOutSideUpdateNormalCheck?: boolean;
  /**
   * @example
   * true
   */
  enableOutsideApply?: boolean;
  /**
   * @example
   * true
   */
  enableOutsideCameraCheck?: boolean;
  /**
   * @example
   * true
   */
  enableOutsideCheck?: boolean;
  /**
   * @example
   * true
   */
  enableOutsideRemark?: boolean;
  enablePositionBle?: boolean;
  enableTrimDistance?: boolean;
  /**
   * @example
   * true
   */
  forbidHideOutSideAddress?: boolean;
  freeCheckSetting?: GroupAddRequestFreeCheckSetting;
  /**
   * @example
   * 0
   */
  freeCheckTypeId?: number;
  /**
   * @example
   * 240
   */
  freecheckDayStartMinOffset?: number;
  freecheckWorkDays?: number[];
  /**
   * @example
   * 123
   */
  groupId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 白班考勤
   */
  groupName?: string;
  managerList?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  members?: GroupAddRequestMembers[];
  /**
   * @example
   * true
   */
  modifyMember?: boolean;
  /**
   * @example
   * 500
   */
  offset?: number;
  onlyMachineCheck?: boolean;
  openCameraCheck?: boolean;
  /**
   * @example
   * true
   */
  openFaceCheck?: boolean;
  /**
   * @example
   * -1
   */
  outsideCheckApproveModeId?: number;
  /**
   * @example
   * 123L
   */
  overtimeSettingId?: number;
  /**
   * @example
   * 123dfdf
   */
  owner?: string;
  positions?: GroupAddRequestPositions[];
  resourcePermissionMap?: { [key: string]: any };
  shiftVOList?: GroupAddRequestShiftVOList[];
  /**
   * @example
   * true
   */
  skipHolidays?: boolean;
  /**
   * @example
   * {"onDuty":{1400000:123,1400001:123},"offDuty":[1400000,1400001]}
   */
  specialDays?: string;
  /**
   * @example
   * 100
   */
  trimDistance?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TURN
   */
  type?: string;
  wifis?: GroupAddRequestWifis[];
  workdayClassList?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123dfd
   */
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
      onlyMachineCheck: 'onlyMachineCheck',
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
      onlyMachineCheck: 'boolean',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GroupAddResponseBody;
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
  /**
   * @example
   * 123L
   */
  adjustmentSettingId?: number;
  /**
   * @example
   * true
   */
  disableCheckWhenRest?: boolean;
  /**
   * @example
   * true
   */
  disableCheckWithoutSchedule?: boolean;
  /**
   * @example
   * true
   */
  enableCameraCheck?: boolean;
  /**
   * @example
   * true
   */
  enableEmpSelectClass?: boolean;
  /**
   * @example
   * true
   */
  enableFaceCheck?: boolean;
  /**
   * @example
   * true
   */
  enableFaceStrictMode?: boolean;
  /**
   * @example
   * true
   */
  enableOutSideUpdateNormalCheck?: boolean;
  /**
   * @example
   * true
   */
  enableOutsideApply?: boolean;
  /**
   * @example
   * true
   */
  enableOutsideCheck?: boolean;
  /**
   * @example
   * true
   */
  enableOutsideRemark?: boolean;
  /**
   * @example
   * true
   */
  enableTrimDistance?: boolean;
  /**
   * @example
   * true
   */
  forbidHideOutSideAddress?: boolean;
  freeCheckSetting?: GroupUpdateRequestFreeCheckSetting;
  /**
   * @example
   * 0
   */
  freeCheckTypeId?: number;
  freecheckDayStartMinOffset?: number;
  /**
   * @example
   * 123
   */
  groupId?: number;
  /**
   * @example
   * 白班考勤
   */
  groupName?: string;
  managerList?: string[];
  /**
   * @example
   * 500
   */
  offset?: number;
  onlyMachineCheck?: boolean;
  openCameraCheck?: boolean;
  /**
   * @example
   * true
   */
  openFaceCheck?: boolean;
  /**
   * @example
   * -1
   */
  outsideCheckApproveModeId?: number;
  /**
   * @example
   * 123L
   */
  overtimeSettingId?: number;
  /**
   * @example
   * 123dfdf
   */
  owner?: string;
  positions?: GroupUpdateRequestPositions[];
  resourcePermissionMap?: { [key: string]: any };
  shiftVOList?: GroupUpdateRequestShiftVOList[];
  /**
   * @example
   * true
   */
  skipHolidays?: boolean;
  /**
   * @example
   * 100
   */
  trimDistance?: number;
  workdayClassList?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123dfd
   */
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
      freecheckDayStartMinOffset: 'freecheckDayStartMinOffset',
      groupId: 'groupId',
      groupName: 'groupName',
      managerList: 'managerList',
      offset: 'offset',
      onlyMachineCheck: 'onlyMachineCheck',
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
      freecheckDayStartMinOffset: 'number',
      groupId: 'number',
      groupName: 'string',
      managerList: { 'type': 'array', 'itemType': 'string' },
      offset: 'number',
      onlyMachineCheck: 'boolean',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GroupUpdateResponseBody;
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
  /**
   * @example
   * f84a2829-xxxx0653
   */
  leaveCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager1
   */
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager211
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InitAndGetLeaveALlocationQuotasResponseBody;
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
  /**
   * @example
   * 1678636800000
   */
  fromDateTime?: number;
  /**
   * @example
   * 1678636800000
   */
  toDateTime?: number;
  /**
   * @example
   * user1,user2
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListApproveByUsersResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROC-292988B1-5064-4A42-9389-A76B97xxxxx
   */
  formCode?: string;
  /**
   * @example
   * https://xx.xx.png
   */
  icon?: string;
  /**
   * @example
   * industry_dx_xx
   */
  layoutDesignId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * { \"items\":[ { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"enableModifyPlace\", \"id\":\"enableModifyPlace-undefined\", \"value\":\"true\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"modifyPlaceDistance\", \"id\":\"modifyPlaceDistance-undefined\", \"value\":200 } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"title\", \"id\":\"title-undefined\", \"value\":\"wofu1\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"titleBgColor\", \"id\":\"titleBgColor-undefined\", \"value\":\"#0089FF\" } } ] }
   */
  schemaContent?: string;
  /**
   * @example
   * 标题
   */
  title?: string;
  /**
   * @example
   * PROC-292988B1-5064-4A42-9389-A76B97xxxxx
   */
  waterMarkId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manage123
   */
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
  /**
   * @example
   * PROC-292988B1-5064-4A42-9389-A76B97xxxxx
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

export class ModifyWaterMarkTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ModifyWaterMarkTemplateResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 25c4c49f-cf3a-4ba1-b321-7defd93b7f89
   */
  approveId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user02
   */
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  punchParam?: ProcessApproveCreateRequestPunchParam;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * shiftGroup
   */
  subType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 请假
   */
  tagName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ProcessApproveCreateResponseBody;
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
  /**
   * @example
   * 1234abcd
   */
  approveId?: string;
  /**
   * @example
   * https://open.dingtalk.com/
   */
  jumpUrl?: string;
  /**
   * @example
   * 1
   */
  overTimeToMore?: number;
  /**
   * @example
   * 1.07
   */
  overtimeDuration?: string;
  /**
   * @example
   * 年假
   */
  subType?: string;
  /**
   * @example
   * 请假
   */
  tagName?: string;
  topCalculateApproveDurationParam?: ProcessApproveFinishRequestTopCalculateApproveDurationParam;
  /**
   * @example
   * manager123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ProcessApproveFinishResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * asdfaad-asdfadfa-asdfa
   */
  leaveCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123342345
   */
  outerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  quotaNum?: number;
  /**
   * @example
   * 家中有事请假1天
   */
  reason?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReduceQuotaWithLeaveRecordResponseBody;
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
  /**
   * @example
   * manager233
   */
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RetainLeaveTypesResponseBody;
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
  /**
   * @example
   * manager234
   */
  opUserId?: string;
  /**
   * @example
   * 1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReverseTrialAdvancedLeaveResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * water_mark_checkin
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://xx.xx.png
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * industry_dx_xx
   */
  layoutDesignId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * water_mark_checkin_open
   */
  sceneCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * { \"items\":[ { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"enableModifyPlace\", \"id\":\"enableModifyPlace-undefined\", \"value\":\"true\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"modifyPlaceDistance\", \"id\":\"modifyPlaceDistance-undefined\", \"value\":200 } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"title\", \"id\":\"title-undefined\", \"value\":\"wofu1\" } }, { \"componentName\":\"HiddenField\", \"props\":{ \"bizAlias\":\"titleBgColor\", \"id\":\"titleBgColor-undefined\", \"value\":\"#0089FF\" } } ] }
   */
  schemaContent?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 标题
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manage123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveCustomWaterMarkTemplateResponseBody;
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

export class ShiftAddHeaders extends $tea.Model {
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

export class ShiftAddRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 白班
   */
  name?: string;
  /**
   * @example
   * user01
   */
  owner?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  sections?: ShiftAddRequestSections[];
  /**
   * @example
   * 123
   */
  serviceId?: number;
  setting?: ShiftAddRequestSetting;
  /**
   * @example
   * 1234
   */
  shiftId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      owner: 'owner',
      sections: 'sections',
      serviceId: 'serviceId',
      setting: 'setting',
      shiftId: 'shiftId',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      owner: 'string',
      sections: { 'type': 'array', 'itemType': ShiftAddRequestSections },
      serviceId: 'number',
      setting: ShiftAddRequestSetting,
      shiftId: 'number',
      opUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShiftAddResponseBody extends $tea.Model {
  result?: ShiftAddResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ShiftAddResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShiftAddResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ShiftAddResponseBody;
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
      body: ShiftAddResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  opUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * general_leave
   */
  bizType?: string;
  /**
   * @example
   * {"validity_type":"absolute_time","validity_value":"12-31"}
   */
  extras?: string;
  /**
   * @example
   * 1000
   */
  hoursInPerDay?: number;
  leaveCertificate?: UpdateLeaveTypeRequestLeaveCertificate;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 047477ae-1009-4632-b8e9-e919ae5e7973
   */
  leaveCode?: string;
  /**
   * @example
   * 年假
   */
  leaveName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * day
   */
  leaveViewUnit?: string;
  /**
   * @example
   * true
   */
  naturalDayLeave?: boolean;
  submitTimeRule?: UpdateLeaveTypeRequestSubmitTimeRule;
  visibilityRules?: UpdateLeaveTypeRequestVisibilityRules[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user01
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateLeaveTypeResponseBody;
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
  /**
   * @example
   * 1
   */
  duration?: number;
  /**
   * @example
   * false
   */
  enable?: boolean;
  /**
   * @example
   * 请假文案
   */
  promptInformation?: string;
  /**
   * @example
   * hour
   */
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
  /**
   * @example
   * true
   */
  enableTimeLimit?: boolean;
  /**
   * @example
   * before
   */
  timeType?: string;
  /**
   * @example
   * day
   */
  timeUnit?: string;
  /**
   * @example
   * 2
   */
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
  /**
   * @example
   * staff
   */
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
  /**
   * @example
   * 1
   */
  duration?: number;
  /**
   * @example
   * false
   */
  enable?: boolean;
  /**
   * @example
   * 请假文案
   */
  promptInformation?: string;
  /**
   * @example
   * hour
   */
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
  /**
   * @example
   * false
   */
  enableTimeLimit?: boolean;
  /**
   * @example
   * before
   */
  timeType?: string;
  /**
   * @example
   * day
   */
  timeUnit?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * staff
   */
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
  /**
   * @example
   * general_leave
   */
  bizType?: string;
  /**
   * @example
   * 1000
   */
  hoursInPerDay?: number;
  leaveCertificate?: AddLeaveTypeResponseBodyResultLeaveCertificate;
  /**
   * @example
   * 037477ae-1009-4632-b8e9-e919ae5e7973
   */
  leaveCode?: string;
  /**
   * @example
   * 年假
   */
  leaveName?: string;
  /**
   * @example
   * day
   */
  leaveViewUnit?: string;
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * 3244523553
   */
  deviceId?: number;
  /**
   * @example
   * 蓝牙设备1
   */
  deviceName?: string;
  /**
   * @example
   * dfsgdsdgd
   */
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
  /**
   * @example
   * 400001
   */
  code?: string;
  failureList?: AttendanceBleDevicesAddResponseBodyErrorListFailureList[];
  /**
   * @example
   * error
   */
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
  /**
   * @example
   * 6567575
   */
  deviceId?: number;
  /**
   * @example
   * 蓝牙设备2
   */
  deviceName?: string;
  /**
   * @example
   * xfdfsdfgsdgfs
   */
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
  /**
   * @example
   * 34666777
   */
  deviceId?: number;
  /**
   * @example
   * 蓝牙设备
   */
  deviceName?: string;
  /**
   * @example
   * 12321kllksdf
   */
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
  /**
   * @example
   * 400001
   */
  code?: string;
  failureList?: number[];
  /**
   * @example
   * error
   */
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
  /**
   * @example
   * 1
   */
  absentMin?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  planId?: number;
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Normal
   */
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
  /**
   * @example
   * 2019-08-15
   */
  date?: string;
  /**
   * @example
   * 1.0
   */
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
  /**
   * @example
   * 2.0
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 120.023425_30.291465
   */
  positionId?: string;
  /**
   * @example
   * 余杭区五常街道
   */
  positionName?: string;
  /**
   * @example
   * gps
   */
  positionType?: string;
  /**
   * @example
   * 1614222064000
   */
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
  /**
   * @example
   * true
   */
  hasRisk?: boolean;
  /**
   * @example
   * {"riskTypeMinor":"bbbb""riskTypeMajor":"aaaa""riskTypeMsg":"ccc"}
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * partial
   */
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
  /**
   * @example
   * 1
   */
  id?: number;
  name?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * PROC-292988B1-5064-4A42-9389-xxxxx
   */
  formCode?: string;
  /**
   * @example
   * https://xx.xx.png
   */
  icon?: string;
  /**
   * @example
   * {     \"widgetName\":\"dd_watermark_xxx_xxx\",     \"miniAppId\":\"50000xxx\",     \"templateRule\":{         \"maxItems\":6,         \"canEditColor\":true,         \"canEditTitle\":true,         \"items\":[          ]     },     \"layoutDesignId\":\"industry_xx_xx\",     \"width\":\"111\" }
   */
  layoutDesign?: string;
  /**
   * @example
   * water_mark_checkin_open
   */
  sceneCode?: string;
  /**
   * @example
   * {     \"items\":[         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"enableModifyPlace\",                 \"id\":\"enableModifyPlace-undefined\",                 \"value\":\"true\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"modifyPlaceDistance\",                 \"id\":\"modifyPlaceDistance-undefined\",                 \"value\":200             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"title\",                 \"id\":\"title-undefined\",                 \"value\":\"wofu1\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"titleBgColor\",                 \"id\":\"titleBgColor-undefined\",                 \"value\":\"#0089FF\"             }         }     ] }
   */
  schemaContent?: string;
  /**
   * @example
   * suiteKey
   */
  suiteKey?: string;
  systemTemplate?: boolean;
  /**
   * @example
   * 标题
   */
  title?: string;
  /**
   * @example
   * PROC-292988B1-5064-4A42-9389-xxxxx
   */
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
  /**
   * @example
   * water_mark_checkin
   */
  bizCode?: string;
  canModifyAndAddTemplate?: boolean;
  conversationAdmin?: boolean;
  customTemplateMaxSize?: number;
  /**
   * @example
   * 1234567
   */
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

export class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin extends $tea.Model {
  /**
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 1970-01-01T12:00Z
   */
  checkTime?: string;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      checkTime: 'checkTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      checkTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd extends $tea.Model {
  /**
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 1970-01-01T13:00Z
   */
  checkTime?: string;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      checkTime: 'checkTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      checkTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClassWithDeletedResponseBodyResultClassSettingRestTimeList extends $tea.Model {
  begin?: GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin;
  end?: GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd;
  static names(): { [key: string]: string } {
    return {
      begin: 'begin',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      begin: GetClassWithDeletedResponseBodyResultClassSettingRestTimeListBegin,
      end: GetClassWithDeletedResponseBodyResultClassSettingRestTimeListEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClassWithDeletedResponseBodyResultClassSetting extends $tea.Model {
  /**
   * @example
   * 1
   */
  classSettingId?: number;
  restTimeList?: GetClassWithDeletedResponseBodyResultClassSettingRestTimeList[];
  static names(): { [key: string]: string } {
    return {
      classSettingId: 'classSettingId',
      restTimeList: 'restTimeList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classSettingId: 'number',
      restTimeList: { 'type': 'array', 'itemType': GetClassWithDeletedResponseBodyResultClassSettingRestTimeList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClassWithDeletedResponseBodyResultSectionsTimes extends $tea.Model {
  /**
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 10
   */
  beginMin?: number;
  /**
   * @example
   * 1970-01-01T09:00Z
   */
  checkTime?: string;
  /**
   * @example
   * OnDuty
   */
  checkType?: string;
  /**
   * @example
   * 10
   */
  endMin?: number;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      beginMin: 'beginMin',
      checkTime: 'checkTime',
      checkType: 'checkType',
      endMin: 'endMin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      beginMin: 'number',
      checkTime: 'string',
      checkType: 'string',
      endMin: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClassWithDeletedResponseBodyResultSections extends $tea.Model {
  times?: GetClassWithDeletedResponseBodyResultSectionsTimes[];
  static names(): { [key: string]: string } {
    return {
      times: 'times',
    };
  }

  static types(): { [key: string]: any } {
    return {
      times: { 'type': 'array', 'itemType': GetClassWithDeletedResponseBodyResultSectionsTimes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClassWithDeletedResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 1
   */
  classId?: number;
  classSetting?: GetClassWithDeletedResponseBodyResultClassSetting;
  /**
   * @example
   * ding1234
   */
  corpId?: string;
  /**
   * @example
   * 夜班
   */
  name?: string;
  sections?: GetClassWithDeletedResponseBodyResultSections[];
  workDays?: number[];
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      classSetting: 'classSetting',
      corpId: 'corpId',
      name: 'name',
      sections: 'sections',
      workDays: 'workDays',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      classSetting: GetClassWithDeletedResponseBodyResultClassSetting,
      corpId: 'string',
      name: 'string',
      sections: { 'type': 'array', 'itemType': GetClassWithDeletedResponseBodyResultSections },
      workDays: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetClosingAccountsResponseBodyResultClosingAccountModel extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  closingDay?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  closingHourMinutes?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  endDay?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  endMonth?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  startDay?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  closingAccountModel?: GetClosingAccountsResponseBodyResultClosingAccountModel;
  /**
   * @remarks
   * This parameter is required.
   */
  switchOn?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  unsealClosingAccountModel?: GetClosingAccountsResponseBodyResultUnsealClosingAccountModel;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class GetColumnvalsResponseBodyResultColumnDataColumnValues extends $tea.Model {
  /**
   * @example
   * 1709222400000
   */
  date?: number;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      date: 'date',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      date: 'number',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetColumnvalsResponseBodyResultColumnData extends $tea.Model {
  columnValues?: GetColumnvalsResponseBodyResultColumnDataColumnValues[];
  /**
   * @example
   * 0
   */
  fixedValue?: string;
  /**
   * @example
   * 129339038
   */
  id?: number;
  static names(): { [key: string]: string } {
    return {
      columnValues: 'columnValues',
      fixedValue: 'fixedValue',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      columnValues: { 'type': 'array', 'itemType': GetColumnvalsResponseBodyResultColumnDataColumnValues },
      fixedValue: 'string',
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetColumnvalsResponseBodyResult extends $tea.Model {
  columnData?: GetColumnvalsResponseBodyResultColumnData[];
  /**
   * @example
   * manager123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      columnData: 'columnData',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      columnData: { 'type': 'array', 'itemType': GetColumnvalsResponseBodyResultColumnData },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetLeaveRecordsResponseBodyResultLeaveRecords extends $tea.Model {
  /**
   * @example
   * add
   */
  calType?: string;
  /**
   * @example
   * 1753851001000
   */
  endTime?: number;
  /**
   * @example
   * 1653851001000
   */
  gmtCreate?: number;
  /**
   * @example
   * 1753851001000
   */
  gmtModified?: number;
  /**
   * @example
   * f84a2dxxxx
   */
  leaveCode?: string;
  /**
   * @example
   * 管理员导入
   */
  leaveReason?: string;
  /**
   * @example
   * update
   */
  leaveRecordType?: string;
  /**
   * @example
   * init
   */
  leaveStatus?: string;
  /**
   * @example
   * day
   */
  leaveViewUnit?: string;
  /**
   * @example
   * manage223
   */
  opUserId?: string;
  /**
   * @example
   * db1d74xxxxbaa
   */
  quotaId?: string;
  /**
   * @example
   * db1d74xxxxbaa
   */
  recordId?: string;
  /**
   * @example
   * 100
   */
  recordNumPerDay?: number;
  /**
   * @example
   * 100
   */
  recordNumPerHour?: number;
  /**
   * @example
   * 1653851001000
   */
  startTime?: number;
  /**
   * @example
   * user1
   */
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
  /**
   * @example
   * 1
   */
  duration?: number;
  /**
   * @example
   * false
   */
  enable?: boolean;
  /**
   * @example
   * 请假文案
   */
  promptInformation?: string;
  /**
   * @example
   * hour
   */
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
  /**
   * @example
   * false
   */
  enableTimeLimit?: boolean;
  /**
   * @example
   * before
   */
  timeType?: string;
  /**
   * @example
   * day
   */
  timeUnit?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * staff
   */
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
  /**
   * @example
   * general_leave
   */
  bizType?: string;
  /**
   * @example
   * 1000
   */
  hoursInPerDay?: number;
  leaveCertificate?: GetLeaveTypeResponseBodyResultLeaveCertificate;
  /**
   * @example
   * 037477ae-1009-4632-b8e9-e919ae5e7973
   */
  leaveCode?: string;
  /**
   * @example
   * 年假
   */
  leaveName?: string;
  /**
   * @example
   * day
   */
  leaveViewUnit?: string;
  /**
   * @example
   * true
   */
  naturalDayLeave?: boolean;
  /**
   * @example
   * external
   */
  source?: string;
  submitTimeRule?: GetLeaveTypeResponseBodyResultSubmitTimeRule;
  /**
   * @example
   * absolute_time
   */
  validityType?: string;
  /**
   * @example
   * 12-31
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 绿城-未来park
   */
  address?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  bluetoothCheckWithFace?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * default
   */
  bluetoothDistanceMode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 默认 (最远5-10米)
   */
  bluetoothDistanceModeDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  bluetoothValue?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 30.285871310763888
   */
  latitude?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  limitUserDeviceCount?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 120.01757758246528
   */
  longitude?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  monitorLocationAbnormal?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  atmManagerList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1406333705
   */
  devId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2078053438
   */
  deviceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 泱云❄️的体00056
   */
  deviceName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0601IFW201001N000056
   */
  deviceSn?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  machineBluetoothVO?: GetMachineResponseBodyResultMachineBluetoothVO;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10000
   */
  maxFace?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4
   */
  netStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * M1F
   */
  productName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.0.1-R-20200326.1543
   */
  productVersion?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  hasFace?: boolean;
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
  /**
   * @remarks
   * This parameter is required.
   */
  hasMore?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 0
   */
  across?: number;
  beginMin?: number;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 1970-01-01 19:00:00
   */
  checkTime?: string;
  /**
   * @example
   * OnDuty
   */
  checkType?: string;
  /**
   * @example
   * -1
   */
  endMin?: number;
  flexMinutes?: number[];
  freeCheck?: boolean;
  lateBackSetting?: GetShiftResponseBodyResultSectionsPunchesLateBackSetting;
  /**
   * @example
   * 0
   */
  permitMinutes?: number;
  /**
   * @example
   * 33928201
   */
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
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   */
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
  /**
   * @example
   * 12
   */
  attendDays?: string;
  /**
   * @example
   * dinge87f1xxxx
   */
  corpId?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2020-09-06 15:49:27
   */
  gmtCreate?: string;
  /**
   * @remarks
   * Use the UTC time format: yyyy-MM-ddTHH:mmZ
   * 
   * @example
   * 2020-09-06 15:49:27
   */
  gmtModified?: string;
  /**
   * @example
   * 678215070
   */
  shiftId?: number;
  /**
   * @example
   * 233840112
   */
  shiftSettingId?: number;
  /**
   * @example
   * 600
   */
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
  /**
   * @example
   * dinge87f1xxxx
   */
  corpId?: string;
  /**
   * @example
   * 678215070
   */
  id?: number;
  /**
   * @example
   * B
   */
  name?: string;
  /**
   * @example
   * user123
   */
  owner?: string;
  sections?: GetShiftResponseBodyResultSections[];
  shiftGroupId?: number;
  /**
   * @example
   * 考勤班
   */
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

export class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes extends $tea.Model {
  /**
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 1970-01-01T09:00Z
   */
  checkTime?: string;
  /**
   * @example
   * OnDuty
   */
  checkType?: string;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      checkTime: 'checkTime',
      checkType: 'checkType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      checkTime: 'string',
      checkType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections extends $tea.Model {
  times?: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes[];
  static names(): { [key: string]: string } {
    return {
      times: 'times',
    };
  }

  static types(): { [key: string]: any } {
    return {
      times: { 'type': 'array', 'itemType': GetSimpleGroupsResponseBodyResultGroupsSelectedClassSectionsTimes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin extends $tea.Model {
  /**
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 1970-01-01T12:00Z
   */
  checkTime?: string;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      checkTime: 'checkTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      checkTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd extends $tea.Model {
  /**
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 1970-01-01T13:00Z
   */
  checkTime?: string;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      checkTime: 'checkTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      checkTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList extends $tea.Model {
  begin?: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin;
  end?: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd;
  static names(): { [key: string]: string } {
    return {
      begin: 'begin',
      end: 'end',
    };
  }

  static types(): { [key: string]: any } {
    return {
      begin: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListBegin,
      end: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeListEnd,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting extends $tea.Model {
  /**
   * @example
   * 30
   */
  absenteeismLateMinutes?: number;
  /**
   * @example
   * 1
   */
  classSettingId?: number;
  /**
   * @example
   * Y
   */
  isOffDutyFreeCheck?: string;
  /**
   * @example
   * 10
   */
  permitLateMinutes?: number;
  restTimeList?: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList[];
  /**
   * @example
   * 20
   */
  seriousLateMinutes?: number;
  /**
   * @example
   * -1
   */
  workTimeMinutes?: number;
  static names(): { [key: string]: string } {
    return {
      absenteeismLateMinutes: 'absenteeismLateMinutes',
      classSettingId: 'classSettingId',
      isOffDutyFreeCheck: 'isOffDutyFreeCheck',
      permitLateMinutes: 'permitLateMinutes',
      restTimeList: 'restTimeList',
      seriousLateMinutes: 'seriousLateMinutes',
      workTimeMinutes: 'workTimeMinutes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      absenteeismLateMinutes: 'number',
      classSettingId: 'number',
      isOffDutyFreeCheck: 'string',
      permitLateMinutes: 'number',
      restTimeList: { 'type': 'array', 'itemType': GetSimpleGroupsResponseBodyResultGroupsSelectedClassSettingRestTimeList },
      seriousLateMinutes: 'number',
      workTimeMinutes: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResultGroupsSelectedClass extends $tea.Model {
  /**
   * @example
   * 20008010
   */
  classId?: number;
  /**
   * @example
   * 早班
   */
  className?: string;
  sections?: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections[];
  setting?: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting;
  static names(): { [key: string]: string } {
    return {
      classId: 'classId',
      className: 'className',
      sections: 'sections',
      setting: 'setting',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classId: 'number',
      className: 'string',
      sections: { 'type': 'array', 'itemType': GetSimpleGroupsResponseBodyResultGroupsSelectedClassSections },
      setting: GetSimpleGroupsResponseBodyResultGroupsSelectedClassSetting,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResultGroups extends $tea.Model {
  classesList?: string[];
  /**
   * @example
   * 111
   */
  defaultClassId?: number;
  deptIds?: number[];
  deptNameList?: string[];
  /**
   * @example
   * false
   */
  disableCheckWhenRest?: boolean;
  /**
   * @example
   * false
   */
  disableCheckWithoutSchedule?: boolean;
  /**
   * @example
   * false
   */
  enableEmpSelectClass?: boolean;
  /**
   * @example
   * 240
   */
  freeCheckDayStartMinOffset?: number;
  freecheckWorkDays?: number[];
  /**
   * @example
   * 20015047
   */
  groupId?: number;
  /**
   * @example
   * 固定排班
   */
  groupName?: string;
  /**
   * @example
   * false
   */
  isDefault?: boolean;
  /**
   * @example
   * 1,2
   */
  managerList?: string[];
  /**
   * @example
   * 1
   */
  memberCount?: number;
  /**
   * @example
   * 123
   */
  ownerUserId?: string;
  selectedClass?: GetSimpleGroupsResponseBodyResultGroupsSelectedClass[];
  /**
   * @example
   * FIXED
   */
  type?: string;
  userIds?: string[];
  workDayList?: string[];
  static names(): { [key: string]: string } {
    return {
      classesList: 'classesList',
      defaultClassId: 'defaultClassId',
      deptIds: 'deptIds',
      deptNameList: 'deptNameList',
      disableCheckWhenRest: 'disableCheckWhenRest',
      disableCheckWithoutSchedule: 'disableCheckWithoutSchedule',
      enableEmpSelectClass: 'enableEmpSelectClass',
      freeCheckDayStartMinOffset: 'freeCheckDayStartMinOffset',
      freecheckWorkDays: 'freecheckWorkDays',
      groupId: 'groupId',
      groupName: 'groupName',
      isDefault: 'isDefault',
      managerList: 'managerList',
      memberCount: 'memberCount',
      ownerUserId: 'ownerUserId',
      selectedClass: 'selectedClass',
      type: 'type',
      userIds: 'userIds',
      workDayList: 'workDayList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      classesList: { 'type': 'array', 'itemType': 'string' },
      defaultClassId: 'number',
      deptIds: { 'type': 'array', 'itemType': 'number' },
      deptNameList: { 'type': 'array', 'itemType': 'string' },
      disableCheckWhenRest: 'boolean',
      disableCheckWithoutSchedule: 'boolean',
      enableEmpSelectClass: 'boolean',
      freeCheckDayStartMinOffset: 'number',
      freecheckWorkDays: { 'type': 'array', 'itemType': 'number' },
      groupId: 'number',
      groupName: 'string',
      isDefault: 'boolean',
      managerList: { 'type': 'array', 'itemType': 'string' },
      memberCount: 'number',
      ownerUserId: 'string',
      selectedClass: { 'type': 'array', 'itemType': GetSimpleGroupsResponseBodyResultGroupsSelectedClass },
      type: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
      workDayList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleGroupsResponseBodyResult extends $tea.Model {
  /**
   * @example
   * []
   */
  groups?: GetSimpleGroupsResponseBodyResultGroups[];
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  static names(): { [key: string]: string } {
    return {
      groups: 'groups',
      hasMore: 'hasMore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groups: { 'type': 'array', 'itemType': GetSimpleGroupsResponseBodyResultGroups },
      hasMore: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSimpleOvertimeSettingResponseBodyResultItems extends $tea.Model {
  /**
   * @example
   * 1
   */
  id?: number;
  name?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 1311089987
   */
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
  /**
   * @example
   * 0
   */
  offOnCheckGapMinutes?: number;
  /**
   * @example
   * 0
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Attendance
   */
  role?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * StaffMember
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1212jfkd
   */
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
  /**
   * @example
   * 生物科技产业园区经二路21号
   */
  address?: string;
  /**
   * @example
   * 36.687495
   */
  latitude?: string;
  /**
   * @example
   * 101.750329
   */
  longitude?: string;
  /**
   * @example
   * 500
   */
  offset?: number;
  /**
   * @example
   * 青藏高原自然博物馆
   */
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
  /**
   * @example
   * 123
   */
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
  /**
   * @example
   * C0:E0:D0:E0:C0:0F
   */
  macAddr?: string;
  /**
   * @example
   * OFFICE-WiFi
   */
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
  /**
   * @example
   * 0
   */
  offOnCheckGapMinutes?: number;
  /**
   * @example
   * 0
   */
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
  /**
   * @example
   * 生物科技产业园区经二路21号
   */
  address?: string;
  /**
   * @example
   * 36.687495
   */
  latitude?: string;
  /**
   * @example
   * 101.750329
   */
  longitude?: string;
  /**
   * @example
   * 500
   */
  offset?: number;
  /**
   * @example
   * 青藏高原自然博物馆
   */
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
  /**
   * @example
   * 123
   */
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
  /**
   * @example
   * 1753851001000
   */
  endTime?: number;
  /**
   * @example
   * c00ced14-xxxxxd438748
   */
  leaveCode?: string;
  /**
   * @example
   * 2022
   */
  quotaCycle?: string;
  /**
   * @example
   * b13cc5b0--xxxx5b0
   */
  quotaId?: string;
  /**
   * @example
   * 700
   */
  quotaNumPerDay?: number;
  /**
   * @example
   * 800
   */
  quotaNumPerHour?: number;
  /**
   * @example
   * 1653851001000
   */
  startTime?: number;
  /**
   * @example
   * 200
   */
  usedNumPerDay?: number;
  /**
   * @example
   * 100
   */
  usedNumPerHour?: number;
  /**
   * @example
   * user1
   */
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
  /**
   * @example
   * 4850378c0ee83
   */
  approveId?: string;
  /**
   * @example
   * 2023-03-15 AM
   */
  beginTime?: string;
  /**
   * @example
   * 1
   */
  bizType?: number;
  /**
   * @example
   * 1
   */
  calculateModel?: number;
  /**
   * @example
   * hour
   */
  durationUnit?: string;
  /**
   * @example
   * 2023-03-15 AM
   */
  endTime?: string;
  /**
   * @example
   * 年假
   */
  subType?: string;
  /**
   * @example
   * 请假
   */
  tagName?: string;
  /**
   * @example
   * user1
   */
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
  /**
   * @example
   * longitude_latitude
   */
  positionId?: string;
  /**
   * @example
   * 未来park
   */
  positionName?: string;
  /**
   * @example
   * gps
   */
  positionType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1650511474978
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3534654765756234
   */
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
  /**
   * @example
   * 3
   */
  bizType?: number;
  /**
   * @example
   * 1
   */
  calculateModel?: number;
  /**
   * @example
   * day
   */
  durationUnit?: string;
  /**
   * @example
   * 2019-08-15
   */
  fromTime?: string;
  /**
   * @example
   * 3afdsf-143dsadw3-ad23
   */
  leaveCode?: string;
  /**
   * @example
   * 2019-08-15
   */
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
  /**
   * @example
   * 2019-08-15
   */
  date?: string;
  /**
   * @example
   * 1.0
   */
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
  /**
   * @example
   * 2.0
   */
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
  /**
   * @example
   * 2
   */
  duration?: number;
  enable?: boolean;
  /**
   * @example
   * leaveCertificate
   */
  promptInformation?: string;
  /**
   * @example
   * hour
   */
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
  /**
   * @example
   * after
   */
  timeType?: string;
  /**
   * @example
   * hour
   */
  timeUnit?: string;
  /**
   * @example
   * 10
   */
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
  /**
   * @example
   * dept
   */
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
  /**
   * @example
   * lieu_leave
   */
  bizType?: string;
  /**
   * @example
   * 8
   */
  hoursInPerDay?: number;
  leaveCertificate?: RetainLeaveTypesResponseBodyResultLeaveCertificate;
  /**
   * @example
   * 2e8b764e-7989-4b5d-ac64-xxxxx
   */
  leaveCode?: string;
  /**
   * @example
   * ""
   */
  leaveHourCeil?: string;
  /**
   * @example
   * 高级测试假期
   */
  leaveName?: string;
  leaveTimeCeil?: boolean;
  /**
   * @example
   * hour
   */
  leaveTimeCeilMinUnit?: string;
  /**
   * @example
   * hour
   */
  leaveViewUnit?: string;
  /**
   * @example
   * 30
   */
  lieuDelayNum?: number;
  /**
   * @example
   * day
   */
  lieuDelayUnit?: string;
  /**
   * @example
   * 24
   */
  maxLeaveTime?: number;
  /**
   * @example
   * 0.5
   */
  minLeaveHour?: number;
  naturalDayLeave?: boolean;
  paidLeave?: boolean;
  submitTimeRule?: RetainLeaveTypesResponseBodyResultSubmitTimeRule;
  visibilityRules?: RetainLeaveTypesResponseBodyResultVisibilityRules[];
  /**
   * @example
   * formal
   */
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
  /**
   * @example
   * PROC-292988B1-5064-4A42-9389-A76B97xxxxx
   */
  formCode?: string;
  /**
   * @example
   * PROC-292988B1-5064-4A42-9389-A76B97xxxxx
   */
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

export class ShiftAddRequestSectionsTimes extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 30
   */
  beginMin?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1714298274613
   */
  checkTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * OnDuty
   */
  checkType?: string;
  /**
   * @example
   * -1
   */
  endMin?: number;
  flexMinutes?: number[];
  freeCheck?: boolean;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      beginMin: 'beginMin',
      checkTime: 'checkTime',
      checkType: 'checkType',
      endMin: 'endMin',
      flexMinutes: 'flexMinutes',
      freeCheck: 'freeCheck',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      beginMin: 'number',
      checkTime: 'number',
      checkType: 'string',
      endMin: 'number',
      flexMinutes: { 'type': 'array', 'itemType': 'number' },
      freeCheck: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShiftAddRequestSections extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  times?: ShiftAddRequestSectionsTimes[];
  static names(): { [key: string]: string } {
    return {
      times: 'times',
    };
  }

  static types(): { [key: string]: any } {
    return {
      times: { 'type': 'array', 'itemType': ShiftAddRequestSectionsTimes },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShiftAddRequestSettingLateBackSettingSections extends $tea.Model {
  /**
   * @example
   * 120
   */
  extra?: number;
  /**
   * @example
   * 60
   */
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

export class ShiftAddRequestSettingLateBackSetting extends $tea.Model {
  enable?: boolean;
  sections?: ShiftAddRequestSettingLateBackSettingSections[];
  static names(): { [key: string]: string } {
    return {
      enable: 'enable',
      sections: 'sections',
    };
  }

  static types(): { [key: string]: any } {
    return {
      enable: 'boolean',
      sections: { 'type': 'array', 'itemType': ShiftAddRequestSettingLateBackSettingSections },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShiftAddRequestSettingTopRestTimeList extends $tea.Model {
  /**
   * @example
   * 0
   */
  across?: number;
  /**
   * @example
   * 1714298002940
   */
  checkTime?: number;
  /**
   * @example
   * OnDuty
   */
  checkType?: string;
  static names(): { [key: string]: string } {
    return {
      across: 'across',
      checkTime: 'checkTime',
      checkType: 'checkType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      across: 'number',
      checkTime: 'number',
      checkType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShiftAddRequestSetting extends $tea.Model {
  /**
   * @example
   * 60
   */
  absenteeismLateMinutes?: number;
  /**
   * @example
   * 0.8
   */
  attendDays?: number;
  /**
   * @example
   * 480
   */
  demandWorkTimeMinutes?: number;
  enableOutsideLateBack?: boolean;
  extras?: { [key: string]: any };
  isFlexible?: boolean;
  lateBackSetting?: ShiftAddRequestSettingLateBackSetting;
  /**
   * @example
   * 31
   */
  seriousLateMinutes?: number;
  /**
   * @example
   * temp:schedule:isv
   */
  tags?: string;
  topRestTimeList?: ShiftAddRequestSettingTopRestTimeList[];
  static names(): { [key: string]: string } {
    return {
      absenteeismLateMinutes: 'absenteeismLateMinutes',
      attendDays: 'attendDays',
      demandWorkTimeMinutes: 'demandWorkTimeMinutes',
      enableOutsideLateBack: 'enableOutsideLateBack',
      extras: 'extras',
      isFlexible: 'isFlexible',
      lateBackSetting: 'lateBackSetting',
      seriousLateMinutes: 'seriousLateMinutes',
      tags: 'tags',
      topRestTimeList: 'topRestTimeList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      absenteeismLateMinutes: 'number',
      attendDays: 'number',
      demandWorkTimeMinutes: 'number',
      enableOutsideLateBack: 'boolean',
      extras: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      isFlexible: 'boolean',
      lateBackSetting: ShiftAddRequestSettingLateBackSetting,
      seriousLateMinutes: 'number',
      tags: 'string',
      topRestTimeList: { 'type': 'array', 'itemType': ShiftAddRequestSettingTopRestTimeList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ShiftAddResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 白班
   */
  name?: string;
  /**
   * @example
   * 1111
   */
  shiftId?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      shiftId: 'shiftId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      shiftId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncScheduleInfoRequestScheduleInfos extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 1
   */
  duration?: number;
  /**
   * @example
   * false
   */
  enable?: boolean;
  /**
   * @example
   * 请假文案
   */
  promptInformation?: string;
  /**
   * @example
   * hour
   */
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
  /**
   * @example
   * true
   */
  enableTimeLimit?: boolean;
  /**
   * @example
   * before
   */
  timeType?: string;
  /**
   * @example
   * day
   */
  timeUnit?: string;
  /**
   * @example
   * 2
   */
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
  /**
   * @example
   * staff
   */
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
  /**
   * @example
   * 1
   */
  duration?: number;
  /**
   * @example
   * false
   */
  enable?: boolean;
  /**
   * @example
   * 请假文案
   */
  promptInformation?: string;
  /**
   * @example
   * hour
   */
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
  /**
   * @example
   * false
   */
  enableTimeLimit?: boolean;
  /**
   * @example
   * before
   */
  timeType?: string;
  /**
   * @example
   * day
   */
  timeUnit?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * staff
   */
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
  /**
   * @example
   * general_leave
   */
  bizType?: string;
  /**
   * @example
   * 1000
   */
  hoursInPerDay?: number;
  leaveCertificate?: UpdateLeaveTypeResponseBodyResultLeaveCertificate;
  /**
   * @example
   * 037477ae-1009-4632-b8e9-e919ae5e7973
   */
  leaveCode?: string;
  /**
   * @example
   * 年假
   */
  leaveName?: string;
  /**
   * @example
   * day
   */
  leaveViewUnit?: string;
  /**
   * @example
   * true
   */
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
   * 添加假期规则
   * 
   * @param request - AddLeaveTypeRequest
   * @param headers - AddLeaveTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddLeaveTypeResponse
   */
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

  /**
   * 添加假期规则
   * 
   * @param request - AddLeaveTypeRequest
   * @returns AddLeaveTypeResponse
   */
  async addLeaveType(request: AddLeaveTypeRequest): Promise<AddLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLeaveTypeHeaders({ });
    return await this.addLeaveTypeWithOptions(request, headers, runtime);
  }

  /**
   * 批量给考勤组添加蓝牙设备
   * 
   * @param request - AttendanceBleDevicesAddRequest
   * @param headers - AttendanceBleDevicesAddHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AttendanceBleDevicesAddResponse
   */
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

  /**
   * 批量给考勤组添加蓝牙设备
   * 
   * @param request - AttendanceBleDevicesAddRequest
   * @returns AttendanceBleDevicesAddResponse
   */
  async attendanceBleDevicesAdd(request: AttendanceBleDevicesAddRequest): Promise<AttendanceBleDevicesAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesAddHeaders({ });
    return await this.attendanceBleDevicesAddWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询蓝牙设备
   * 
   * @param request - AttendanceBleDevicesQueryRequest
   * @param headers - AttendanceBleDevicesQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AttendanceBleDevicesQueryResponse
   */
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

  /**
   * 批量查询蓝牙设备
   * 
   * @param request - AttendanceBleDevicesQueryRequest
   * @returns AttendanceBleDevicesQueryResponse
   */
  async attendanceBleDevicesQuery(request: AttendanceBleDevicesQueryRequest): Promise<AttendanceBleDevicesQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesQueryHeaders({ });
    return await this.attendanceBleDevicesQueryWithOptions(request, headers, runtime);
  }

  /**
   * 批量删除考勤组的蓝牙设备
   * 
   * @param request - AttendanceBleDevicesRemoveRequest
   * @param headers - AttendanceBleDevicesRemoveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AttendanceBleDevicesRemoveResponse
   */
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

  /**
   * 批量删除考勤组的蓝牙设备
   * 
   * @param request - AttendanceBleDevicesRemoveRequest
   * @returns AttendanceBleDevicesRemoveResponse
   */
  async attendanceBleDevicesRemove(request: AttendanceBleDevicesRemoveRequest): Promise<AttendanceBleDevicesRemoveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesRemoveHeaders({ });
    return await this.attendanceBleDevicesRemoveWithOptions(request, headers, runtime);
  }

  /**
   * 批量修改考勤结果
   * 
   * @param request - BatchBossCheckRequest
   * @param headers - BatchBossCheckHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchBossCheckResponse
   */
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

  /**
   * 批量修改考勤结果
   * 
   * @param request - BatchBossCheckRequest
   * @returns BatchBossCheckResponse
   */
  async batchBossCheck(request: BatchBossCheckRequest): Promise<BatchBossCheckResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchBossCheckHeaders({ });
    return await this.batchBossCheckWithOptions(request, headers, runtime);
  }

  /**
   * 预计算时长
   * 
   * @param request - CalculateDurationRequest
   * @param headers - CalculateDurationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CalculateDurationResponse
   */
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

  /**
   * 预计算时长
   * 
   * @param request - CalculateDurationRequest
   * @returns CalculateDurationResponse
   */
  async calculateDuration(request: CalculateDurationRequest): Promise<CalculateDurationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CalculateDurationHeaders({ });
    return await this.calculateDurationWithOptions(request, headers, runtime);
  }

  /**
   * 针对某些员工某段时间内封账状态的查询
   * 
   * @param request - CheckClosingAccountRequest
   * @param headers - CheckClosingAccountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckClosingAccountResponse
   */
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

  /**
   * 针对某些员工某段时间内封账状态的查询
   * 
   * @param request - CheckClosingAccountRequest
   * @returns CheckClosingAccountResponse
   */
  async checkClosingAccount(request: CheckClosingAccountRequest): Promise<CheckClosingAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckClosingAccountHeaders({ });
    return await this.checkClosingAccountWithOptions(request, headers, runtime);
  }

  /**
   * 考勤资源的写权限查询
   * 
   * @param request - CheckWritePermissionRequest
   * @param headers - CheckWritePermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckWritePermissionResponse
   */
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

  /**
   * 考勤资源的写权限查询
   * 
   * @param request - CheckWritePermissionRequest
   * @returns CheckWritePermissionResponse
   */
  async checkWritePermission(request: CheckWritePermissionRequest): Promise<CheckWritePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckWritePermissionHeaders({ });
    return await this.checkWritePermissionWithOptions(request, headers, runtime);
  }

  /**
   * 创建考勤打卡审批单
   * 
   * @param request - CreateApproveRequest
   * @param headers - CreateApproveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateApproveResponse
   */
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

  /**
   * 创建考勤打卡审批单
   * 
   * @param request - CreateApproveRequest
   * @returns CreateApproveResponse
   */
  async createApprove(request: CreateApproveRequest): Promise<CreateApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateApproveHeaders({ });
    return await this.createApproveWithOptions(request, headers, runtime);
  }

  /**
   * 撤销请假
   * 
   * @param request - DeleteLeaveRequestRequest
   * @param headers - DeleteLeaveRequestHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteLeaveRequestResponse
   */
  async deleteLeaveRequestWithOptions(unionId: string, request: DeleteLeaveRequestRequest, headers: DeleteLeaveRequestHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteLeaveRequestResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
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
      action: "DeleteLeaveRequest",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/users/${unionId}/vacations/records/revoke`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteLeaveRequestResponse>(await this.execute(params, req, runtime), new DeleteLeaveRequestResponse({}));
  }

  /**
   * 撤销请假
   * 
   * @param request - DeleteLeaveRequestRequest
   * @returns DeleteLeaveRequestResponse
   */
  async deleteLeaveRequest(unionId: string, request: DeleteLeaveRequestRequest): Promise<DeleteLeaveRequestResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteLeaveRequestHeaders({ });
    return await this.deleteLeaveRequestWithOptions(unionId, request, headers, runtime);
  }

  /**
   * 删除水印模板
   * 
   * @param request - DeleteWaterMarkTemplateRequest
   * @param headers - DeleteWaterMarkTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteWaterMarkTemplateResponse
   */
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

  /**
   * 删除水印模板
   * 
   * @param request - DeleteWaterMarkTemplateRequest
   * @returns DeleteWaterMarkTemplateResponse
   */
  async deleteWaterMarkTemplate(request: DeleteWaterMarkTemplateRequest): Promise<DeleteWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteWaterMarkTemplateHeaders({ });
    return await this.deleteWaterMarkTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 钉钉安全检查
   * 
   * @param request - DingTalkSecurityCheckRequest
   * @param headers - DingTalkSecurityCheckHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DingTalkSecurityCheckResponse
   */
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

  /**
   * 钉钉安全检查
   * 
   * @param request - DingTalkSecurityCheckRequest
   * @returns DingTalkSecurityCheckResponse
   */
  async dingTalkSecurityCheck(request: DingTalkSecurityCheckRequest): Promise<DingTalkSecurityCheckResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DingTalkSecurityCheckHeaders({ });
    return await this.dingTalkSecurityCheckWithOptions(request, headers, runtime);
  }

  /**
   * 查询管理员管理范围下的userid
   * 
   * @param request - GetATManageScopeRequest
   * @param headers - GetATManageScopeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetATManageScopeResponse
   */
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

  /**
   * 查询管理员管理范围下的userid
   * 
   * @param request - GetATManageScopeRequest
   * @returns GetATManageScopeResponse
   */
  async getATManageScope(request: GetATManageScopeRequest): Promise<GetATManageScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetATManageScopeHeaders({ });
    return await this.getATManageScopeWithOptions(request, headers, runtime);
  }

  /**
   * 获取补卡规则列表
   * 
   * @param request - GetAdjustmentsRequest
   * @param headers - GetAdjustmentsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAdjustmentsResponse
   */
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

  /**
   * 获取补卡规则列表
   * 
   * @param request - GetAdjustmentsRequest
   * @returns GetAdjustmentsResponse
   */
  async getAdjustments(request: GetAdjustmentsRequest): Promise<GetAdjustmentsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAdjustmentsHeaders({ });
    return await this.getAdjustmentsWithOptions(request, headers, runtime);
  }

  /**
   * 获取水印打卡模板
   * 
   * @param request - GetCheckInSchemaTemplateRequest
   * @param headers - GetCheckInSchemaTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCheckInSchemaTemplateResponse
   */
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

  /**
   * 获取水印打卡模板
   * 
   * @param request - GetCheckInSchemaTemplateRequest
   * @returns GetCheckInSchemaTemplateResponse
   */
  async getCheckInSchemaTemplate(request: GetCheckInSchemaTemplateRequest): Promise<GetCheckInSchemaTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCheckInSchemaTemplateHeaders({ });
    return await this.getCheckInSchemaTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 调用本接口，获取用户签到记录。
   * 
   * @param request - GetCheckinRecordByUserRequest
   * @param headers - GetCheckinRecordByUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCheckinRecordByUserResponse
   */
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

  /**
   * 调用本接口，获取用户签到记录。
   * 
   * @param request - GetCheckinRecordByUserRequest
   * @returns GetCheckinRecordByUserResponse
   */
  async getCheckinRecordByUser(request: GetCheckinRecordByUserRequest): Promise<GetCheckinRecordByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCheckinRecordByUserHeaders({ });
    return await this.getCheckinRecordByUserWithOptions(request, headers, runtime);
  }

  /**
   * 班次查询（包含已删除班次）
   * 
   * @param headers - GetClassWithDeletedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetClassWithDeletedResponse
   */
  async getClassWithDeletedWithOptions(classId: string, headers: GetClassWithDeletedHeaders, runtime: $Util.RuntimeOptions): Promise<GetClassWithDeletedResponse> {
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
      action: "GetClassWithDeleted",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/classWithDeleted/${classId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetClassWithDeletedResponse>(await this.execute(params, req, runtime), new GetClassWithDeletedResponse({}));
  }

  /**
   * 班次查询（包含已删除班次）
   * @returns GetClassWithDeletedResponse
   */
  async getClassWithDeleted(classId: string): Promise<GetClassWithDeletedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetClassWithDeletedHeaders({ });
    return await this.getClassWithDeletedWithOptions(classId, headers, runtime);
  }

  /**
   * 查询指定用户的封账规则
   * 
   * @param request - GetClosingAccountsRequest
   * @param headers - GetClosingAccountsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetClosingAccountsResponse
   */
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

  /**
   * 查询指定用户的封账规则
   * 
   * @param request - GetClosingAccountsRequest
   * @returns GetClosingAccountsResponse
   */
  async getClosingAccounts(request: GetClosingAccountsRequest): Promise<GetClosingAccountsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetClosingAccountsHeaders({ });
    return await this.getClosingAccountsWithOptions(request, headers, runtime);
  }

  /**
   * 获取多个用户的智能考勤报表的列值
   * 
   * @param request - GetColumnvalsRequest
   * @param headers - GetColumnvalsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetColumnvalsResponse
   */
  async getColumnvalsWithOptions(request: GetColumnvalsRequest, headers: GetColumnvalsHeaders, runtime: $Util.RuntimeOptions): Promise<GetColumnvalsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.columnIdList)) {
      body["columnIdList"] = request.columnIdList;
    }

    if (!Util.isUnset(request.fromDate)) {
      body["fromDate"] = request.fromDate;
    }

    if (!Util.isUnset(request.toDate)) {
      body["toDate"] = request.toDate;
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
      action: "GetColumnvals",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/columnValues/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetColumnvalsResponse>(await this.execute(params, req, runtime), new GetColumnvalsResponse({}));
  }

  /**
   * 获取多个用户的智能考勤报表的列值
   * 
   * @param request - GetColumnvalsRequest
   * @returns GetColumnvalsResponse
   */
  async getColumnvals(request: GetColumnvalsRequest): Promise<GetColumnvalsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetColumnvalsHeaders({ });
    return await this.getColumnvalsWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询员工假期余额变更记录
   * 
   * @param request - GetLeaveRecordsRequest
   * @param headers - GetLeaveRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetLeaveRecordsResponse
   */
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

  /**
   * 批量查询员工假期余额变更记录
   * 
   * @param request - GetLeaveRecordsRequest
   * @returns GetLeaveRecordsResponse
   */
  async getLeaveRecords(request: GetLeaveRecordsRequest): Promise<GetLeaveRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLeaveRecordsHeaders({ });
    return await this.getLeaveRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 查询假期规则列表
   * 
   * @param request - GetLeaveTypeRequest
   * @param headers - GetLeaveTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetLeaveTypeResponse
   */
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

  /**
   * 查询假期规则列表
   * 
   * @param request - GetLeaveTypeRequest
   * @returns GetLeaveTypeResponse
   */
  async getLeaveType(request: GetLeaveTypeRequest): Promise<GetLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetLeaveTypeHeaders({ });
    return await this.getLeaveTypeWithOptions(request, headers, runtime);
  }

  /**
   * 根据设备id获取考勤机信息
   * 
   * @param headers - GetMachineHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMachineResponse
   */
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

  /**
   * 根据设备id获取考勤机信息
   * @returns GetMachineResponse
   */
  async getMachine(devId: string): Promise<GetMachineResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMachineHeaders({ });
    return await this.getMachineWithOptions(devId, headers, runtime);
  }

  /**
   * 根据设备id获取员工信息
   * 
   * @param request - GetMachineUserRequest
   * @param headers - GetMachineUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMachineUserResponse
   */
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

  /**
   * 根据设备id获取员工信息
   * 
   * @param request - GetMachineUserRequest
   * @returns GetMachineUserResponse
   */
  async getMachineUser(devId: string, request: GetMachineUserRequest): Promise<GetMachineUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMachineUserHeaders({ });
    return await this.getMachineUserWithOptions(devId, request, headers, runtime);
  }

  /**
   * 批量获取加班规则设置
   * 
   * @param request - GetOvertimeSettingRequest
   * @param headers - GetOvertimeSettingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOvertimeSettingResponse
   */
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

  /**
   * 批量获取加班规则设置
   * 
   * @param request - GetOvertimeSettingRequest
   * @returns GetOvertimeSettingResponse
   */
  async getOvertimeSetting(request: GetOvertimeSettingRequest): Promise<GetOvertimeSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOvertimeSettingHeaders({ });
    return await this.getOvertimeSettingWithOptions(request, headers, runtime);
  }

  /**
   * 班次详情
   * 
   * @param request - GetShiftRequest
   * @param headers - GetShiftHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetShiftResponse
   */
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

  /**
   * 班次详情
   * 
   * @param request - GetShiftRequest
   * @returns GetShiftResponse
   */
  async getShift(request: GetShiftRequest): Promise<GetShiftResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetShiftHeaders({ });
    return await this.getShiftWithOptions(request, headers, runtime);
  }

  /**
   * 获取考勤组列表详情
   * 
   * @param request - GetSimpleGroupsRequest
   * @param headers - GetSimpleGroupsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSimpleGroupsResponse
   */
  async getSimpleGroupsWithOptions(request: GetSimpleGroupsRequest, headers: GetSimpleGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<GetSimpleGroupsResponse> {
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
      action: "GetSimpleGroups",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/groupDetails`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSimpleGroupsResponse>(await this.execute(params, req, runtime), new GetSimpleGroupsResponse({}));
  }

  /**
   * 获取考勤组列表详情
   * 
   * @param request - GetSimpleGroupsRequest
   * @returns GetSimpleGroupsResponse
   */
  async getSimpleGroups(request: GetSimpleGroupsRequest): Promise<GetSimpleGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSimpleGroupsHeaders({ });
    return await this.getSimpleGroupsWithOptions(request, headers, runtime);
  }

  /**
   * 加班规则列表
   * 
   * @param request - GetSimpleOvertimeSettingRequest
   * @param headers - GetSimpleOvertimeSettingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSimpleOvertimeSettingResponse
   */
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

  /**
   * 加班规则列表
   * 
   * @param request - GetSimpleOvertimeSettingRequest
   * @returns GetSimpleOvertimeSettingResponse
   */
  async getSimpleOvertimeSetting(request: GetSimpleOvertimeSettingRequest): Promise<GetSimpleOvertimeSettingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSimpleOvertimeSettingHeaders({ });
    return await this.getSimpleOvertimeSettingWithOptions(request, headers, runtime);
  }

  /**
   * 查询员工某段时间的假期
   * 
   * @param request - GetUserHolidaysRequest
   * @param headers - GetUserHolidaysHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserHolidaysResponse
   */
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

  /**
   * 查询员工某段时间的假期
   * 
   * @param request - GetUserHolidaysRequest
   * @returns GetUserHolidaysResponse
   */
  async getUserHolidays(request: GetUserHolidaysRequest): Promise<GetUserHolidaysResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserHolidaysHeaders({ });
    return await this.getUserHolidaysWithOptions(request, headers, runtime);
  }

  /**
   * 创建考勤组
   * 
   * @param request - GroupAddRequest
   * @param headers - GroupAddHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupAddResponse
   */
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

    if (!Util.isUnset(request.onlyMachineCheck)) {
      body["onlyMachineCheck"] = request.onlyMachineCheck;
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

  /**
   * 创建考勤组
   * 
   * @param request - GroupAddRequest
   * @returns GroupAddResponse
   */
  async groupAdd(request: GroupAddRequest): Promise<GroupAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupAddHeaders({ });
    return await this.groupAddWithOptions(request, headers, runtime);
  }

  /**
   * 修改考勤组
   * 
   * @param request - GroupUpdateRequest
   * @param headers - GroupUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupUpdateResponse
   */
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

    if (!Util.isUnset(request.freecheckDayStartMinOffset)) {
      body["freecheckDayStartMinOffset"] = request.freecheckDayStartMinOffset;
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

    if (!Util.isUnset(request.onlyMachineCheck)) {
      body["onlyMachineCheck"] = request.onlyMachineCheck;
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

  /**
   * 修改考勤组
   * 
   * @param request - GroupUpdateRequest
   * @returns GroupUpdateResponse
   */
  async groupUpdate(request: GroupUpdateRequest): Promise<GroupUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupUpdateHeaders({ });
    return await this.groupUpdateWithOptions(request, headers, runtime);
  }

  /**
   * 生态系统假期初始化查询余额接口
   * 
   * @param request - InitAndGetLeaveALlocationQuotasRequest
   * @param headers - InitAndGetLeaveALlocationQuotasHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InitAndGetLeaveALlocationQuotasResponse
   */
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

  /**
   * 生态系统假期初始化查询余额接口
   * 
   * @param request - InitAndGetLeaveALlocationQuotasRequest
   * @returns InitAndGetLeaveALlocationQuotasResponse
   */
  async initAndGetLeaveALlocationQuotas(request: InitAndGetLeaveALlocationQuotasRequest): Promise<InitAndGetLeaveALlocationQuotasResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InitAndGetLeaveALlocationQuotasHeaders({ });
    return await this.initAndGetLeaveALlocationQuotasWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户某段时间内同步到考勤的审批单信息
   * 
   * @param request - ListApproveByUsersRequest
   * @param headers - ListApproveByUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListApproveByUsersResponse
   */
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

  /**
   * 获取用户某段时间内同步到考勤的审批单信息
   * 
   * @param request - ListApproveByUsersRequest
   * @returns ListApproveByUsersResponse
   */
  async listApproveByUsers(request: ListApproveByUsersRequest): Promise<ListApproveByUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListApproveByUsersHeaders({ });
    return await this.listApproveByUsersWithOptions(request, headers, runtime);
  }

  /**
   * 修改水印模板
   * 
   * @param request - ModifyWaterMarkTemplateRequest
   * @param headers - ModifyWaterMarkTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ModifyWaterMarkTemplateResponse
   */
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

  /**
   * 修改水印模板
   * 
   * @param request - ModifyWaterMarkTemplateRequest
   * @returns ModifyWaterMarkTemplateResponse
   */
  async modifyWaterMarkTemplate(request: ModifyWaterMarkTemplateRequest): Promise<ModifyWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyWaterMarkTemplateHeaders({ });
    return await this.modifyWaterMarkTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 创建考勤打卡审批单
   * 
   * @param request - ProcessApproveCreateRequest
   * @param headers - ProcessApproveCreateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ProcessApproveCreateResponse
   */
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

  /**
   * 创建考勤打卡审批单
   * 
   * @param request - ProcessApproveCreateRequest
   * @returns ProcessApproveCreateResponse
   */
  async processApproveCreate(request: ProcessApproveCreateRequest): Promise<ProcessApproveCreateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessApproveCreateHeaders({ });
    return await this.processApproveCreateWithOptions(request, headers, runtime);
  }

  /**
   * 通知审批通过
   * 
   * @param request - ProcessApproveFinishRequest
   * @param headers - ProcessApproveFinishHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ProcessApproveFinishResponse
   */
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

  /**
   * 通知审批通过
   * 
   * @param request - ProcessApproveFinishRequest
   * @returns ProcessApproveFinishResponse
   */
  async processApproveFinish(request: ProcessApproveFinishRequest): Promise<ProcessApproveFinishResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessApproveFinishHeaders({ });
    return await this.processApproveFinishWithOptions(request, headers, runtime);
  }

  /**
   * 扣减员工假期余额
   * 
   * @param request - ReduceQuotaWithLeaveRecordRequest
   * @param headers - ReduceQuotaWithLeaveRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReduceQuotaWithLeaveRecordResponse
   */
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

  /**
   * 扣减员工假期余额
   * 
   * @param request - ReduceQuotaWithLeaveRecordRequest
   * @returns ReduceQuotaWithLeaveRecordResponse
   */
  async reduceQuotaWithLeaveRecord(unionId: string, request: ReduceQuotaWithLeaveRecordRequest): Promise<ReduceQuotaWithLeaveRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReduceQuotaWithLeaveRecordHeaders({ });
    return await this.reduceQuotaWithLeaveRecordWithOptions(unionId, request, headers, runtime);
  }

  /**
   * 修改假期规则来源
   * 
   * @param request - RetainLeaveTypesRequest
   * @param headers - RetainLeaveTypesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RetainLeaveTypesResponse
   */
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

  /**
   * 修改假期规则来源
   * 
   * @param request - RetainLeaveTypesRequest
   * @returns RetainLeaveTypesResponse
   */
  async retainLeaveTypes(request: RetainLeaveTypesRequest): Promise<RetainLeaveTypesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetainLeaveTypesHeaders({ });
    return await this.retainLeaveTypesWithOptions(request, headers, runtime);
  }

  /**
   * 提供给高级假期的试用订单回退
   * 
   * @param request - ReverseTrialAdvancedLeaveRequest
   * @param headers - ReverseTrialAdvancedLeaveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReverseTrialAdvancedLeaveResponse
   */
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

  /**
   * 提供给高级假期的试用订单回退
   * 
   * @param request - ReverseTrialAdvancedLeaveRequest
   * @returns ReverseTrialAdvancedLeaveResponse
   */
  async reverseTrialAdvancedLeave(request: ReverseTrialAdvancedLeaveRequest): Promise<ReverseTrialAdvancedLeaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReverseTrialAdvancedLeaveHeaders({ });
    return await this.reverseTrialAdvancedLeaveWithOptions(request, headers, runtime);
  }

  /**
   * 新增水印签到模板
   * 
   * @param request - SaveCustomWaterMarkTemplateRequest
   * @param headers - SaveCustomWaterMarkTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveCustomWaterMarkTemplateResponse
   */
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

  /**
   * 新增水印签到模板
   * 
   * @param request - SaveCustomWaterMarkTemplateRequest
   * @returns SaveCustomWaterMarkTemplateResponse
   */
  async saveCustomWaterMarkTemplate(request: SaveCustomWaterMarkTemplateRequest): Promise<SaveCustomWaterMarkTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveCustomWaterMarkTemplateHeaders({ });
    return await this.saveCustomWaterMarkTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 创建班次
   * 
   * @param request - ShiftAddRequest
   * @param headers - ShiftAddHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ShiftAddResponse
   */
  async shiftAddWithOptions(request: ShiftAddRequest, headers: ShiftAddHeaders, runtime: $Util.RuntimeOptions): Promise<ShiftAddResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      query["opUserId"] = request.opUserId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.owner)) {
      body["owner"] = request.owner;
    }

    if (!Util.isUnset(request.sections)) {
      body["sections"] = request.sections;
    }

    if (!Util.isUnset(request.serviceId)) {
      body["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.setting)) {
      body["setting"] = request.setting;
    }

    if (!Util.isUnset(request.shiftId)) {
      body["shiftId"] = request.shiftId;
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
      action: "ShiftAdd",
      version: "attendance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/attendance/shifts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ShiftAddResponse>(await this.execute(params, req, runtime), new ShiftAddResponse({}));
  }

  /**
   * 创建班次
   * 
   * @param request - ShiftAddRequest
   * @returns ShiftAddResponse
   */
  async shiftAdd(request: ShiftAddRequest): Promise<ShiftAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ShiftAddHeaders({ });
    return await this.shiftAddWithOptions(request, headers, runtime);
  }

  /**
   * 用于考勤排班附加信息，例如打卡位置，打卡wifi等
   * 
   * @param request - SyncScheduleInfoRequest
   * @param headers - SyncScheduleInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncScheduleInfoResponse
   */
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

  /**
   * 用于考勤排班附加信息，例如打卡位置，打卡wifi等
   * 
   * @param request - SyncScheduleInfoRequest
   * @returns SyncScheduleInfoResponse
   */
  async syncScheduleInfo(request: SyncScheduleInfoRequest): Promise<SyncScheduleInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncScheduleInfoHeaders({ });
    return await this.syncScheduleInfoWithOptions(request, headers, runtime);
  }

  /**
   * 更新假期规则
   * 
   * @param request - UpdateLeaveTypeRequest
   * @param headers - UpdateLeaveTypeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateLeaveTypeResponse
   */
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

  /**
   * 更新假期规则
   * 
   * @param request - UpdateLeaveTypeRequest
   * @returns UpdateLeaveTypeResponse
   */
  async updateLeaveType(request: UpdateLeaveTypeRequest): Promise<UpdateLeaveTypeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateLeaveTypeHeaders({ });
    return await this.updateLeaveTypeWithOptions(request, headers, runtime);
  }

}
