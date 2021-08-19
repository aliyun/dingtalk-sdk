// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  userid?: string;
  tagName?: string;
  subType?: string;
  punchParam?: CreateApproveRequestPunchParam;
  approveId?: string;
  opUserid?: string;
  static names(): { [key: string]: string } {
    return {
      userid: 'userid',
      tagName: 'tagName',
      subType: 'subType',
      punchParam: 'punchParam',
      approveId: 'approveId',
      opUserid: 'opUserid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userid: 'string',
      tagName: 'string',
      subType: 'string',
      punchParam: CreateApproveRequestPunchParam,
      approveId: 'string',
      opUserid: 'string',
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
  userIds?: string[];
  userTimeRange?: CheckClosingAccountRequestUserTimeRange[];
  bizCode?: string;
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
      userTimeRange: 'userTimeRange',
      bizCode: 'bizCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
      userTimeRange: { 'type': 'array', 'itemType': CheckClosingAccountRequestUserTimeRange },
      bizCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckClosingAccountResponseBody extends $tea.Model {
  mesage?: string;
  code?: string;
  pass?: boolean;
  static names(): { [key: string]: string } {
    return {
      mesage: 'mesage',
      code: 'code',
      pass: 'pass',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mesage: 'string',
      code: 'string',
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
  opUserId?: string;
  groupKey?: string;
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      groupKey: 'groupKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      groupKey: 'string',
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
  scheduleInfos?: SyncScheduleInfoRequestScheduleInfos[];
  opUserId?: string;
  static names(): { [key: string]: string } {
    return {
      scheduleInfos: 'scheduleInfos',
      opUserId: 'opUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scheduleInfos: { 'type': 'array', 'itemType': SyncScheduleInfoRequestScheduleInfos },
      opUserId: 'string',
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
  opUserId?: string;
  groupKey?: string;
  deviceIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      groupKey: 'groupKey',
      deviceIdList: 'deviceIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      groupKey: 'string',
      deviceIdList: { 'type': 'array', 'itemType': 'number' },
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
  opUserId?: string;
  groupKey?: string;
  deviceIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      opUserId: 'opUserId',
      groupKey: 'groupKey',
      deviceIdList: 'deviceIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opUserId: 'string',
      groupKey: 'string',
      deviceIdList: { 'type': 'array', 'itemType': 'number' },
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
  corpId?: string;
  opUserId?: string;
  category?: string;
  resourceKey?: string;
  entityIds?: number[];
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      opUserId: 'opUserId',
      category: 'category',
      resourceKey: 'resourceKey',
      entityIds: 'entityIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      opUserId: 'string',
      category: 'string',
      resourceKey: 'string',
      entityIds: { 'type': 'array', 'itemType': 'number' },
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

export class CreateApproveRequestPunchParam extends $tea.Model {
  punchTime?: number;
  positionId?: string;
  positionType?: string;
  positionName?: string;
  static names(): { [key: string]: string } {
    return {
      punchTime: 'punchTime',
      positionId: 'positionId',
      positionType: 'positionType',
      positionName: 'positionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      punchTime: 'number',
      positionId: 'string',
      positionType: 'string',
      positionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckClosingAccountRequestUserTimeRange extends $tea.Model {
  startTime?: number;
  endTime?: number;
  static names(): { [key: string]: string } {
    return {
      startTime: 'startTime',
      endTime: 'endTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTime: 'number',
      endTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBodyResultHolidays extends $tea.Model {
  workDate?: number;
  holidayName?: string;
  holidayType?: string;
  realWorkDate?: number;
  static names(): { [key: string]: string } {
    return {
      workDate: 'workDate',
      holidayName: 'holidayName',
      holidayType: 'holidayType',
      realWorkDate: 'realWorkDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workDate: 'number',
      holidayName: 'string',
      holidayType: 'string',
      realWorkDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserHolidaysResponseBodyResult extends $tea.Model {
  userId?: string;
  holidays?: GetUserHolidaysResponseBodyResultHolidays[];
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      holidays: 'holidays',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      holidays: { 'type': 'array', 'itemType': GetUserHolidaysResponseBodyResultHolidays },
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

export class SyncScheduleInfoRequestScheduleInfos extends $tea.Model {
  planId?: number;
  wifiKeys?: string[];
  positionKeys?: string[];
  static names(): { [key: string]: string } {
    return {
      planId: 'planId',
      wifiKeys: 'wifiKeys',
      positionKeys: 'positionKeys',
    };
  }

  static types(): { [key: string]: any } {
    return {
      planId: 'number',
      wifiKeys: { 'type': 'array', 'itemType': 'string' },
      positionKeys: { 'type': 'array', 'itemType': 'string' },
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

export class GetClosingAccountsResponseBodyResultClosingAccountModel extends $tea.Model {
  closingDay?: number;
  closingHourMinutes?: number;
  startMonth?: number;
  startDay?: number;
  endMonth?: number;
  endDay?: number;
  static names(): { [key: string]: string } {
    return {
      closingDay: 'closingDay',
      closingHourMinutes: 'closingHourMinutes',
      startMonth: 'startMonth',
      startDay: 'startDay',
      endMonth: 'endMonth',
      endDay: 'endDay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      closingDay: 'number',
      closingHourMinutes: 'number',
      startMonth: 'number',
      startDay: 'number',
      endMonth: 'number',
      endDay: 'number',
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
  userId?: string;
  switchOn?: boolean;
  closingAccountModel?: GetClosingAccountsResponseBodyResultClosingAccountModel;
  unsealClosingAccountModel?: GetClosingAccountsResponseBodyResultUnsealClosingAccountModel;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      switchOn: 'switchOn',
      closingAccountModel: 'closingAccountModel',
      unsealClosingAccountModel: 'unsealClosingAccountModel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      switchOn: 'boolean',
      closingAccountModel: GetClosingAccountsResponseBodyResultClosingAccountModel,
      unsealClosingAccountModel: GetClosingAccountsResponseBodyResultUnsealClosingAccountModel,
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


  async createApprove(request: CreateApproveRequest): Promise<CreateApproveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateApproveHeaders({ });
    return await this.createApproveWithOptions(request, headers, runtime);
  }

  async createApproveWithOptions(request: CreateApproveRequest, headers: CreateApproveHeaders, runtime: $Util.RuntimeOptions): Promise<CreateApproveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
    }

    if (!Util.isUnset(request.tagName)) {
      body["tagName"] = request.tagName;
    }

    if (!Util.isUnset(request.subType)) {
      body["subType"] = request.subType;
    }

    if (!Util.isUnset($tea.toMap(request.punchParam))) {
      body["punchParam"] = request.punchParam;
    }

    if (!Util.isUnset(request.approveId)) {
      body["approveId"] = request.approveId;
    }

    if (!Util.isUnset(request.opUserid)) {
      body["opUserid"] = request.opUserid;
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
    return $tea.cast<CreateApproveResponse>(await this.doROARequest("CreateApprove", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/approves`, "json", req, runtime), new CreateApproveResponse({}));
  }

  async checkClosingAccount(request: CheckClosingAccountRequest): Promise<CheckClosingAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckClosingAccountHeaders({ });
    return await this.checkClosingAccountWithOptions(request, headers, runtime);
  }

  async checkClosingAccountWithOptions(request: CheckClosingAccountRequest, headers: CheckClosingAccountHeaders, runtime: $Util.RuntimeOptions): Promise<CheckClosingAccountResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    if (!Util.isUnset(request.userTimeRange)) {
      body["userTimeRange"] = request.userTimeRange;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
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
    return $tea.cast<CheckClosingAccountResponse>(await this.doROARequest("CheckClosingAccount", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/closingAccounts/status/query`, "json", req, runtime), new CheckClosingAccountResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetUserHolidaysResponse>(await this.doROARequest("GetUserHolidays", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/holidays`, "json", req, runtime), new GetUserHolidaysResponse({}));
  }

  async attendanceBleDevicesQuery(request: AttendanceBleDevicesQueryRequest): Promise<AttendanceBleDevicesQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesQueryHeaders({ });
    return await this.attendanceBleDevicesQueryWithOptions(request, headers, runtime);
  }

  async attendanceBleDevicesQueryWithOptions(request: AttendanceBleDevicesQueryRequest, headers: AttendanceBleDevicesQueryHeaders, runtime: $Util.RuntimeOptions): Promise<AttendanceBleDevicesQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.groupKey)) {
      body["groupKey"] = request.groupKey;
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
    return $tea.cast<AttendanceBleDevicesQueryResponse>(await this.doROARequestWithForm("AttendanceBleDevicesQuery", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/group/bledevices/query`, "json", req, runtime), new AttendanceBleDevicesQueryResponse({}));
  }

  async syncScheduleInfo(request: SyncScheduleInfoRequest): Promise<SyncScheduleInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncScheduleInfoHeaders({ });
    return await this.syncScheduleInfoWithOptions(request, headers, runtime);
  }

  async syncScheduleInfoWithOptions(request: SyncScheduleInfoRequest, headers: SyncScheduleInfoHeaders, runtime: $Util.RuntimeOptions): Promise<SyncScheduleInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.scheduleInfos)) {
      body["scheduleInfos"] = request.scheduleInfos;
    }

    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
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
    return $tea.cast<SyncScheduleInfoResponse>(await this.doROARequest("SyncScheduleInfo", "attendance_1.0", "HTTP", "PUT", "AK", `/v1.0/attendance/schedules/additionalInfo`, "none", req, runtime), new SyncScheduleInfoResponse({}));
  }

  async attendanceBleDevicesAdd(request: AttendanceBleDevicesAddRequest): Promise<AttendanceBleDevicesAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesAddHeaders({ });
    return await this.attendanceBleDevicesAddWithOptions(request, headers, runtime);
  }

  async attendanceBleDevicesAddWithOptions(request: AttendanceBleDevicesAddRequest, headers: AttendanceBleDevicesAddHeaders, runtime: $Util.RuntimeOptions): Promise<AttendanceBleDevicesAddResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.groupKey)) {
      body["groupKey"] = request.groupKey;
    }

    if (!Util.isUnset(request.deviceIdList)) {
      body["deviceIdList"] = request.deviceIdList;
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
    return $tea.cast<AttendanceBleDevicesAddResponse>(await this.doROARequest("AttendanceBleDevicesAdd", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/group/bledevices`, "json", req, runtime), new AttendanceBleDevicesAddResponse({}));
  }

  async attendanceBleDevicesRemove(request: AttendanceBleDevicesRemoveRequest): Promise<AttendanceBleDevicesRemoveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AttendanceBleDevicesRemoveHeaders({ });
    return await this.attendanceBleDevicesRemoveWithOptions(request, headers, runtime);
  }

  async attendanceBleDevicesRemoveWithOptions(request: AttendanceBleDevicesRemoveRequest, headers: AttendanceBleDevicesRemoveHeaders, runtime: $Util.RuntimeOptions): Promise<AttendanceBleDevicesRemoveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.groupKey)) {
      body["groupKey"] = request.groupKey;
    }

    if (!Util.isUnset(request.deviceIdList)) {
      body["deviceIdList"] = request.deviceIdList;
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
    return $tea.cast<AttendanceBleDevicesRemoveResponse>(await this.doROARequest("AttendanceBleDevicesRemove", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/group/bledevices/remove`, "json", req, runtime), new AttendanceBleDevicesRemoveResponse({}));
  }

  async checkWritePermission(request: CheckWritePermissionRequest): Promise<CheckWritePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckWritePermissionHeaders({ });
    return await this.checkWritePermissionWithOptions(request, headers, runtime);
  }

  async checkWritePermissionWithOptions(request: CheckWritePermissionRequest, headers: CheckWritePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<CheckWritePermissionResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.opUserId)) {
      body["opUserId"] = request.opUserId;
    }

    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.resourceKey)) {
      body["resourceKey"] = request.resourceKey;
    }

    if (!Util.isUnset(request.entityIds)) {
      body["entityIds"] = request.entityIds;
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
    return $tea.cast<CheckWritePermissionResponse>(await this.doROARequest("CheckWritePermission", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/writePermissions/query`, "json", req, runtime), new CheckWritePermissionResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetClosingAccountsResponse>(await this.doROARequest("GetClosingAccounts", "attendance_1.0", "HTTP", "POST", "AK", `/v1.0/attendance/closingAccounts/rules/query`, "json", req, runtime), new GetClosingAccountsResponse({}));
  }

}
