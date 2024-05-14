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

export class AddHrmPreentryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequest extends $tea.Model {
  agentId?: number;
  groups?: AddHrmPreentryRequestGroups[];
  mobile?: string;
  name?: string;
  needSendPreEntryMsg?: boolean;
  preEntryTime?: number;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      groups: 'groups',
      mobile: 'mobile',
      name: 'name',
      needSendPreEntryMsg: 'needSendPreEntryMsg',
      preEntryTime: 'preEntryTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      groups: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroups },
      mobile: 'string',
      name: 'string',
      needSendPreEntryMsg: 'boolean',
      preEntryTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryResponseBody extends $tea.Model {
  tmpUserId?: string;
  static names(): { [key: string]: string } {
    return {
      tmpUserId: 'tmpUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tmpUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddHrmPreentryResponseBody;
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
      body: AddHrmPreentryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceMarketManagerResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceMarketManagerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeviceMarketManagerResponseBody;
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
      body: DeviceMarketManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceMarketOrderManagerResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeviceMarketOrderManagerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeviceMarketOrderManagerResponseBody;
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
      body: DeviceMarketOrderManagerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ECertQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ECertQueryRequest extends $tea.Model {
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

export class ECertQueryResponseBody extends $tea.Model {
  certNO?: string;
  employJobId?: string;
  employJobIdLabel?: string;
  employPositionId?: string;
  employPositionIdLabel?: string;
  employPositionRankId?: string;
  employPositionRankIdLabel?: string;
  hiredDate?: string;
  lastWorkDay?: string;
  mainDeptId?: number;
  mainDeptName?: string;
  name?: string;
  realName?: string;
  terminationReasonPassive?: string[];
  terminationReasonVoluntary?: string[];
  static names(): { [key: string]: string } {
    return {
      certNO: 'certNO',
      employJobId: 'employJobId',
      employJobIdLabel: 'employJobIdLabel',
      employPositionId: 'employPositionId',
      employPositionIdLabel: 'employPositionIdLabel',
      employPositionRankId: 'employPositionRankId',
      employPositionRankIdLabel: 'employPositionRankIdLabel',
      hiredDate: 'hiredDate',
      lastWorkDay: 'lastWorkDay',
      mainDeptId: 'mainDeptId',
      mainDeptName: 'mainDeptName',
      name: 'name',
      realName: 'realName',
      terminationReasonPassive: 'terminationReasonPassive',
      terminationReasonVoluntary: 'terminationReasonVoluntary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certNO: 'string',
      employJobId: 'string',
      employJobIdLabel: 'string',
      employPositionId: 'string',
      employPositionIdLabel: 'string',
      employPositionRankId: 'string',
      employPositionRankIdLabel: 'string',
      hiredDate: 'string',
      lastWorkDay: 'string',
      mainDeptId: 'number',
      mainDeptName: 'string',
      name: 'string',
      realName: 'string',
      terminationReasonPassive: { 'type': 'array', 'itemType': 'string' },
      terminationReasonVoluntary: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ECertQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ECertQueryResponseBody;
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
      body: ECertQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmployeeAttachmentUpdateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmployeeAttachmentUpdateRequest extends $tea.Model {
  appAgentId?: number;
  fieldCode?: string;
  fileSuffix?: string;
  mediaId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appAgentId: 'appAgentId',
      fieldCode: 'fieldCode',
      fileSuffix: 'fileSuffix',
      mediaId: 'mediaId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appAgentId: 'number',
      fieldCode: 'string',
      fileSuffix: 'string',
      mediaId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmployeeAttachmentUpdateResponseBody extends $tea.Model {
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

export class EmployeeAttachmentUpdateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EmployeeAttachmentUpdateResponseBody;
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
      body: EmployeeAttachmentUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignRollbackHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignRollbackRequest extends $tea.Model {
  optUserId?: string;
  static names(): { [key: string]: string } {
    return {
      optUserId: 'optUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      optUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EsignRollbackResponseBody extends $tea.Model {
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

export class EsignRollbackResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EsignRollbackResponseBody;
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
      body: EsignRollbackResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldRequest extends $tea.Model {
  appAgentId?: number;
  fieldFilterList?: string[];
  text2SelectConvert?: boolean;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      appAgentId: 'appAgentId',
      fieldFilterList: 'fieldFilterList',
      text2SelectConvert: 'text2SelectConvert',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appAgentId: 'number',
      fieldFilterList: { 'type': 'array', 'itemType': 'string' },
      text2SelectConvert: 'boolean',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldResponseBody extends $tea.Model {
  result?: GetEmployeeRosterByFieldResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetEmployeeRosterByFieldResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetEmployeeRosterByFieldResponseBody;
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
      body: GetEmployeeRosterByFieldResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmBenefitQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmBenefitQueryRequest extends $tea.Model {
  benefitCodes?: string[];
  static names(): { [key: string]: string } {
    return {
      benefitCodes: 'benefitCodes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCodes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmBenefitQueryResponseBody extends $tea.Model {
  result?: any;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmBenefitQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmBenefitQueryResponseBody;
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
      body: HrmBenefitQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequest extends $tea.Model {
  mail?: HrmMailSendRequestMail;
  operator?: HrmMailSendRequestOperator;
  static names(): { [key: string]: string } {
    return {
      mail: 'mail',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mail: HrmMailSendRequestMail,
      operator: HrmMailSendRequestOperator,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendResponseBody extends $tea.Model {
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

export class HrmMailSendResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmMailSendResponseBody;
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
      body: HrmMailSendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMokaEventHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMokaEventRequest extends $tea.Model {
  bizId?: string;
  content?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMokaEventResponseBody extends $tea.Model {
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

export class HrmMokaEventResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmMokaEventResponseBody;
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
      body: HrmMokaEventResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMokaOapiHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMokaOapiRequest extends $tea.Model {
  apiCode?: string;
  params?: any;
  static names(): { [key: string]: string } {
    return {
      apiCode: 'apiCode',
      params: 'params',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiCode: 'string',
      params: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMokaOapiResponseBody extends $tea.Model {
  bizSuccess?: boolean;
  errorCode?: string;
  errorMsg?: string;
  result?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      bizSuccess: 'bizSuccess',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizSuccess: 'boolean',
      errorCode: 'string',
      errorMsg: 'string',
      result: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMokaOapiResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmMokaOapiResponseBody;
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
      body: HrmMokaOapiResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessRegularHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessRegularRequest extends $tea.Model {
  operationId?: string;
  regularDate?: number;
  remark?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      operationId: 'operationId',
      regularDate: 'regularDate',
      remark: 'remark',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operationId: 'string',
      regularDate: 'number',
      remark: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessRegularResponseBody extends $tea.Model {
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

export class HrmProcessRegularResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmProcessRegularResponseBody;
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
      body: HrmProcessRegularResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTransferHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTransferRequest extends $tea.Model {
  deptIdsAfterTransfer?: number[];
  jobIdAfterTransfer?: string;
  mainDeptIdAfterTransfer?: number;
  operateUserId?: string;
  positionIdAfterTransfer?: string;
  positionLevelAfterTransfer?: string;
  positionNameAfterTransfer?: string;
  rankIdAfterTransfer?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptIdsAfterTransfer: 'deptIdsAfterTransfer',
      jobIdAfterTransfer: 'jobIdAfterTransfer',
      mainDeptIdAfterTransfer: 'mainDeptIdAfterTransfer',
      operateUserId: 'operateUserId',
      positionIdAfterTransfer: 'positionIdAfterTransfer',
      positionLevelAfterTransfer: 'positionLevelAfterTransfer',
      positionNameAfterTransfer: 'positionNameAfterTransfer',
      rankIdAfterTransfer: 'rankIdAfterTransfer',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIdsAfterTransfer: { 'type': 'array', 'itemType': 'number' },
      jobIdAfterTransfer: 'string',
      mainDeptIdAfterTransfer: 'number',
      operateUserId: 'string',
      positionIdAfterTransfer: 'string',
      positionLevelAfterTransfer: 'string',
      positionNameAfterTransfer: 'string',
      rankIdAfterTransfer: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTransferResponseBody extends $tea.Model {
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

export class HrmProcessTransferResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmProcessTransferResponseBody;
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
      body: HrmProcessTransferResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessUpdateTerminationInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessUpdateTerminationInfoRequest extends $tea.Model {
  dismissionMemo?: string;
  lastWorkDate?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dismissionMemo: 'dismissionMemo',
      lastWorkDate: 'lastWorkDate',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dismissionMemo: 'string',
      lastWorkDate: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessUpdateTerminationInfoResponseBody extends $tea.Model {
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

export class HrmProcessUpdateTerminationInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmProcessUpdateTerminationInfoResponseBody;
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
      body: HrmProcessUpdateTerminationInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmPtsServiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmPtsServiceRequest extends $tea.Model {
  env?: string;
  method?: string;
  outerId?: string;
  params?: any;
  path?: string;
  static names(): { [key: string]: string } {
    return {
      env: 'env',
      method: 'method',
      outerId: 'outerId',
      params: 'params',
      path: 'path',
    };
  }

  static types(): { [key: string]: any } {
    return {
      env: 'string',
      method: 'string',
      outerId: 'string',
      params: 'any',
      path: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmPtsServiceResponseBody extends $tea.Model {
  bizSuccess?: boolean;
  errorCode?: string;
  errorMsg?: string;
  result?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      bizSuccess: 'bizSuccess',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizSuccess: 'boolean',
      errorCode: 'string',
      errorMsg: 'string',
      result: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmPtsServiceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmPtsServiceResponseBody;
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
      body: HrmPtsServiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteRequest extends $tea.Model {
  body?: MasterDataDeleteRequestBody[];
  tenantId?: number;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      tenantId: 'tenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': MasterDataDeleteRequestBody },
      tenantId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteResponseBody extends $tea.Model {
  allSuccess?: boolean;
  failResult?: MasterDataDeleteResponseBodyFailResult[];
  static names(): { [key: string]: string } {
    return {
      allSuccess: 'allSuccess',
      failResult: 'failResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allSuccess: 'boolean',
      failResult: { 'type': 'array', 'itemType': MasterDataDeleteResponseBodyFailResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MasterDataDeleteResponseBody;
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
      body: MasterDataDeleteResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryRequest extends $tea.Model {
  bizUK?: string;
  maxResults?: number;
  nextToken?: number;
  optUserId?: string;
  queryParams?: MasterDataQueryRequestQueryParams[];
  relationIds?: string[];
  scopeCode?: string;
  tenantId?: number;
  viewEntityCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizUK: 'bizUK',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      optUserId: 'optUserId',
      queryParams: 'queryParams',
      relationIds: 'relationIds',
      scopeCode: 'scopeCode',
      tenantId: 'tenantId',
      viewEntityCode: 'viewEntityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizUK: 'string',
      maxResults: 'number',
      nextToken: 'number',
      optUserId: 'string',
      queryParams: { 'type': 'array', 'itemType': MasterDataQueryRequestQueryParams },
      relationIds: { 'type': 'array', 'itemType': 'string' },
      scopeCode: 'string',
      tenantId: 'number',
      viewEntityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  result?: MasterDataQueryResponseBodyResult[];
  success?: boolean;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      result: 'result',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      result: { 'type': 'array', 'itemType': MasterDataQueryResponseBodyResult },
      success: 'boolean',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MasterDataQueryResponseBody;
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
      body: MasterDataQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequest extends $tea.Model {
  body?: MasterDataSaveRequestBody[];
  tenantId?: number;
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      tenantId: 'tenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': MasterDataSaveRequestBody },
      tenantId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveResponseBody extends $tea.Model {
  allSuccess?: boolean;
  failResult?: MasterDataSaveResponseBodyFailResult[];
  static names(): { [key: string]: string } {
    return {
      allSuccess: 'allSuccess',
      failResult: 'failResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      allSuccess: 'boolean',
      failResult: { 'type': 'array', 'itemType': MasterDataSaveResponseBodyFailResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MasterDataSaveResponseBody;
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
      body: MasterDataSaveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyRequest extends $tea.Model {
  entityCode?: string;
  scopeCode?: string;
  static names(): { [key: string]: string } {
    return {
      entityCode: 'entityCode',
      scopeCode: 'scopeCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      entityCode: 'string',
      scopeCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyResponseBody extends $tea.Model {
  result?: MasterDataTenantQueyResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': MasterDataTenantQueyResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MasterDataTenantQueyResponseBody;
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
      body: MasterDataTenantQueyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryRequest extends $tea.Model {
  bizUK?: string;
  maxResults?: number;
  nextToken?: number;
  queryParams?: MasterDatasQueryRequestQueryParams[];
  relationIds?: string[];
  scopeCode?: string;
  tenantId?: number;
  viewEntityCode?: string;
  static names(): { [key: string]: string } {
    return {
      bizUK: 'bizUK',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      queryParams: 'queryParams',
      relationIds: 'relationIds',
      scopeCode: 'scopeCode',
      tenantId: 'tenantId',
      viewEntityCode: 'viewEntityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizUK: 'string',
      maxResults: 'number',
      nextToken: 'number',
      queryParams: { 'type': 'array', 'itemType': MasterDatasQueryRequestQueryParams },
      relationIds: { 'type': 'array', 'itemType': 'string' },
      scopeCode: 'string',
      tenantId: 'number',
      viewEntityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  result?: MasterDatasQueryResponseBodyResult[];
  success?: boolean;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      result: 'result',
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      result: { 'type': 'array', 'itemType': MasterDatasQueryResponseBodyResult },
      success: 'boolean',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MasterDatasQueryResponseBody;
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
      body: MasterDatasQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  operateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      operateUserId: 'operateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      operateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryCustomEntryProcessesResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryCustomEntryProcessesResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCustomEntryProcessesResponseBody;
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
      body: QueryCustomEntryProcessesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDismissionStaffIdListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDismissionStaffIdListRequest extends $tea.Model {
  maxResults?: number;
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

export class QueryDismissionStaffIdListResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: number;
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'number',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDismissionStaffIdListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDismissionStaffIdListResponseBody;
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
      body: QueryDismissionStaffIdListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoRequest extends $tea.Model {
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

export class QueryHrmEmployeeDismissionInfoShrinkRequest extends $tea.Model {
  userIdListShrink?: string;
  static names(): { [key: string]: string } {
    return {
      userIdListShrink: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIdListShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponseBody extends $tea.Model {
  result?: QueryHrmEmployeeDismissionInfoResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryHrmEmployeeDismissionInfoResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryHrmEmployeeDismissionInfoResponseBody;
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
      body: QueryHrmEmployeeDismissionInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: number;
  rankCategoryId?: string;
  rankCode?: string;
  rankName?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      rankCategoryId: 'rankCategoryId',
      rankCode: 'rankCode',
      rankName: 'rankName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      rankCategoryId: 'string',
      rankCode: 'string',
      rankName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryJobRanksResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryJobRanksResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryJobRanksResponseBody;
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
      body: QueryJobRanksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsRequest extends $tea.Model {
  jobName?: string;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      jobName: 'jobName',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobName: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryJobsResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryJobsResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryJobsResponseBody;
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
      body: QueryJobsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsRequest extends $tea.Model {
  deptId?: number;
  inCategoryIds?: string[];
  inPositionIds?: string[];
  positionName?: string;
  maxResults?: number;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      inCategoryIds: 'inCategoryIds',
      inPositionIds: 'inPositionIds',
      positionName: 'positionName',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      inCategoryIds: { 'type': 'array', 'itemType': 'string' },
      inPositionIds: { 'type': 'array', 'itemType': 'string' },
      positionName: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryPositionsResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryPositionsResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryPositionsResponseBody;
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
      body: QueryPositionsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaAvailableFieldListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaAvailableFieldListRequest extends $tea.Model {
  appAgentId?: number;
  static names(): { [key: string]: string } {
    return {
      appAgentId: 'appAgentId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appAgentId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaAvailableFieldListResponseBody extends $tea.Model {
  result?: RosterMetaAvailableFieldListResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': RosterMetaAvailableFieldListResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaAvailableFieldListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RosterMetaAvailableFieldListResponseBody;
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
      body: RosterMetaAvailableFieldListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaFieldOptionsUpdateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaFieldOptionsUpdateRequest extends $tea.Model {
  appAgentId?: number;
  fieldCode?: string;
  groupId?: string;
  labels?: string[];
  modifyType?: string;
  static names(): { [key: string]: string } {
    return {
      appAgentId: 'appAgentId',
      fieldCode: 'fieldCode',
      groupId: 'groupId',
      labels: 'labels',
      modifyType: 'modifyType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appAgentId: 'number',
      fieldCode: 'string',
      groupId: 'string',
      labels: { 'type': 'array', 'itemType': 'string' },
      modifyType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaFieldOptionsUpdateResponseBody extends $tea.Model {
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

export class RosterMetaFieldOptionsUpdateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RosterMetaFieldOptionsUpdateResponseBody;
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
      body: RosterMetaFieldOptionsUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendIsvCardMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendIsvCardMessageRequest extends $tea.Model {
  agentId?: number;
  bizId?: string;
  messageType?: string;
  receiverUserIds?: string[];
  sceneType?: string;
  scope?: string;
  senderUserId?: string;
  valueMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      bizId: 'bizId',
      messageType: 'messageType',
      receiverUserIds: 'receiverUserIds',
      sceneType: 'sceneType',
      scope: 'scope',
      senderUserId: 'senderUserId',
      valueMap: 'valueMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      bizId: 'string',
      messageType: 'string',
      receiverUserIds: { 'type': 'array', 'itemType': 'string' },
      sceneType: 'string',
      scope: 'string',
      senderUserId: 'string',
      valueMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendIsvCardMessageResponseBody extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  hrmInteractiveCardSendResult?: SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      hrmInteractiveCardSendResult: 'hrmInteractiveCardSendResult',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      hrmInteractiveCardSendResult: SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendIsvCardMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendIsvCardMessageResponseBody;
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
      body: SendIsvCardMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskInitHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskInitRequest extends $tea.Model {
  category?: string;
  claimTime?: number;
  description?: string;
  finishTime?: number;
  outerId?: string;
  status?: string;
  title?: string;
  userId?: string;
  solutionType?: string;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      claimTime: 'claimTime',
      description: 'description',
      finishTime: 'finishTime',
      outerId: 'outerId',
      status: 'status',
      title: 'title',
      userId: 'userId',
      solutionType: 'solutionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      claimTime: 'number',
      description: 'string',
      finishTime: 'number',
      outerId: 'string',
      status: 'string',
      title: 'string',
      userId: 'string',
      solutionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskInitResponseBody extends $tea.Model {
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

export class SolutionTaskInitResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SolutionTaskInitResponseBody;
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
      body: SolutionTaskInitResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskSaveHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskSaveRequest extends $tea.Model {
  claimTime?: number;
  description?: string;
  finishTime?: number;
  outerId?: string;
  solutionInstanceId?: string;
  startTime?: number;
  status?: string;
  taskType?: string;
  templateOuterId?: string;
  title?: string;
  userId?: string;
  solutionType?: string;
  static names(): { [key: string]: string } {
    return {
      claimTime: 'claimTime',
      description: 'description',
      finishTime: 'finishTime',
      outerId: 'outerId',
      solutionInstanceId: 'solutionInstanceId',
      startTime: 'startTime',
      status: 'status',
      taskType: 'taskType',
      templateOuterId: 'templateOuterId',
      title: 'title',
      userId: 'userId',
      solutionType: 'solutionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      claimTime: 'number',
      description: 'string',
      finishTime: 'number',
      outerId: 'string',
      solutionInstanceId: 'string',
      startTime: 'number',
      status: 'string',
      taskType: 'string',
      templateOuterId: 'string',
      title: 'string',
      userId: 'string',
      solutionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SolutionTaskSaveResponseBody extends $tea.Model {
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

export class SolutionTaskSaveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SolutionTaskSaveResponseBody;
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
      body: SolutionTaskSaveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateRequest extends $tea.Model {
  delete?: boolean;
  des?: string;
  ext?: string;
  name?: string;
  optUserId?: string;
  outerId?: string;
  taskScopeVO?: SyncTaskTemplateRequestTaskScopeVO;
  taskType?: string;
  solutionType?: string;
  static names(): { [key: string]: string } {
    return {
      delete: 'delete',
      des: 'des',
      ext: 'ext',
      name: 'name',
      optUserId: 'optUserId',
      outerId: 'outerId',
      taskScopeVO: 'taskScopeVO',
      taskType: 'taskType',
      solutionType: 'solutionType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      delete: 'boolean',
      des: 'string',
      ext: 'string',
      name: 'string',
      optUserId: 'string',
      outerId: 'string',
      taskScopeVO: SyncTaskTemplateRequestTaskScopeVO,
      taskType: 'string',
      solutionType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateResponseBody extends $tea.Model {
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

export class SyncTaskTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncTaskTemplateResponseBody;
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
      body: SyncTaskTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvCardMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvCardMessageRequest extends $tea.Model {
  agentId?: number;
  bizId?: string;
  messageType?: string;
  sceneType?: string;
  scope?: string;
  valueMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      bizId: 'bizId',
      messageType: 'messageType',
      sceneType: 'sceneType',
      scope: 'scope',
      valueMap: 'valueMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      bizId: 'string',
      messageType: 'string',
      sceneType: 'string',
      scope: 'string',
      valueMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvCardMessageResponseBody extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvCardMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateIsvCardMessageResponseBody;
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
      body: UpdateIsvCardMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList extends $tea.Model {
  fieldCode?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroupsSections extends $tea.Model {
  empFieldVOList?: AddHrmPreentryRequestGroupsSectionsEmpFieldVOList[];
  oldIndex?: number;
  static names(): { [key: string]: string } {
    return {
      empFieldVOList: 'empFieldVOList',
      oldIndex: 'oldIndex',
    };
  }

  static types(): { [key: string]: any } {
    return {
      empFieldVOList: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroupsSectionsEmpFieldVOList },
      oldIndex: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroups extends $tea.Model {
  groupId?: string;
  sections?: AddHrmPreentryRequestGroupsSections[];
  static names(): { [key: string]: string } {
    return {
      groupId: 'groupId',
      sections: 'sections',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupId: 'string',
      sections: { 'type': 'array', 'itemType': AddHrmPreentryRequestGroupsSections },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList extends $tea.Model {
  itemIndex?: number;
  label?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      itemIndex: 'itemIndex',
      label: 'label',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemIndex: 'number',
      label: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldResponseBodyResultFieldDataList extends $tea.Model {
  fieldCode?: string;
  fieldName?: string;
  fieldValueList?: GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList[];
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldValueList: 'fieldValueList',
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldValueList: { 'type': 'array', 'itemType': GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList },
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldResponseBodyResult extends $tea.Model {
  corpId?: string;
  fieldDataList?: GetEmployeeRosterByFieldResponseBodyResultFieldDataList[];
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      fieldDataList: 'fieldDataList',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      fieldDataList: { 'type': 'array', 'itemType': GetEmployeeRosterByFieldResponseBodyResultFieldDataList },
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestMailAttachments extends $tea.Model {
  name?: string;
  path?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      path: 'path',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      path: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestMailMeetingAlarm extends $tea.Model {
  alarmDesc?: string;
  alarmMinutes?: number;
  alarmSummary?: string;
  static names(): { [key: string]: string } {
    return {
      alarmDesc: 'alarmDesc',
      alarmMinutes: 'alarmMinutes',
      alarmSummary: 'alarmSummary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alarmDesc: 'string',
      alarmMinutes: 'number',
      alarmSummary: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestMailMeetingAttendees extends $tea.Model {
  address?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestMailMeetingOrganizer extends $tea.Model {
  address?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestMailMeeting extends $tea.Model {
  alarm?: HrmMailSendRequestMailMeetingAlarm;
  attendees?: HrmMailSendRequestMailMeetingAttendees[];
  description?: string;
  endTime?: number;
  location?: string;
  method?: string;
  organizer?: HrmMailSendRequestMailMeetingOrganizer;
  sequence?: number;
  startTime?: number;
  summary?: string;
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      alarm: 'alarm',
      attendees: 'attendees',
      description: 'description',
      endTime: 'endTime',
      location: 'location',
      method: 'method',
      organizer: 'organizer',
      sequence: 'sequence',
      startTime: 'startTime',
      summary: 'summary',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alarm: HrmMailSendRequestMailMeetingAlarm,
      attendees: { 'type': 'array', 'itemType': HrmMailSendRequestMailMeetingAttendees },
      description: 'string',
      endTime: 'number',
      location: 'string',
      method: 'string',
      organizer: HrmMailSendRequestMailMeetingOrganizer,
      sequence: 'number',
      startTime: 'number',
      summary: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestMail extends $tea.Model {
  attachments?: HrmMailSendRequestMailAttachments[];
  bccAddress?: string;
  ccAddress?: string;
  content?: string;
  meeting?: HrmMailSendRequestMailMeeting;
  receiverAddress?: string;
  senderAlias?: string;
  subject?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      bccAddress: 'bccAddress',
      ccAddress: 'ccAddress',
      content: 'content',
      meeting: 'meeting',
      receiverAddress: 'receiverAddress',
      senderAlias: 'senderAlias',
      subject: 'subject',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': HrmMailSendRequestMailAttachments },
      bccAddress: 'string',
      ccAddress: 'string',
      content: 'string',
      meeting: HrmMailSendRequestMailMeeting,
      receiverAddress: 'string',
      senderAlias: 'string',
      subject: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestOperator extends $tea.Model {
  bizId?: string;
  mailAccountType?: string;
  token?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      mailAccountType: 'mailAccountType',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      mailAccountType: 'string',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteRequestBodyFieldList extends $tea.Model {
  name?: string;
  valueStr?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      valueStr: 'valueStr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      valueStr: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteRequestBodyScope extends $tea.Model {
  scopeCode?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      scopeCode: 'scopeCode',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeCode: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteRequestBody extends $tea.Model {
  bizTime?: number;
  bizUk?: string;
  entityCode?: string;
  fieldList?: MasterDataDeleteRequestBodyFieldList[];
  scope?: MasterDataDeleteRequestBodyScope;
  static names(): { [key: string]: string } {
    return {
      bizTime: 'bizTime',
      bizUk: 'bizUk',
      entityCode: 'entityCode',
      fieldList: 'fieldList',
      scope: 'scope',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTime: 'number',
      bizUk: 'string',
      entityCode: 'string',
      fieldList: { 'type': 'array', 'itemType': MasterDataDeleteRequestBodyFieldList },
      scope: MasterDataDeleteRequestBodyScope,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteResponseBodyFailResult extends $tea.Model {
  bizUK?: string;
  errorCode?: string;
  errorMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      bizUK: 'bizUK',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizUK: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryRequestQueryParamsConditionList extends $tea.Model {
  operate?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      operate: 'operate',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operate: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryRequestQueryParams extends $tea.Model {
  conditionList?: MasterDataQueryRequestQueryParamsConditionList[];
  fieldCode?: string;
  joinType?: string;
  static names(): { [key: string]: string } {
    return {
      conditionList: 'conditionList',
      fieldCode: 'fieldCode',
      joinType: 'joinType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conditionList: { 'type': 'array', 'itemType': MasterDataQueryRequestQueryParamsConditionList },
      fieldCode: 'string',
      joinType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBodyResultViewEntityFieldVOList extends $tea.Model {
  fieldCode?: string;
  fieldDataVO?: MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO;
  fieldName?: string;
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldDataVO: 'fieldDataVO',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldDataVO: MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO,
      fieldName: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataQueryResponseBodyResult extends $tea.Model {
  outerId?: string;
  relationId?: string;
  scopeCode?: string;
  viewEntityCode?: string;
  viewEntityFieldVOList?: MasterDataQueryResponseBodyResultViewEntityFieldVOList[];
  static names(): { [key: string]: string } {
    return {
      outerId: 'outerId',
      relationId: 'relationId',
      scopeCode: 'scopeCode',
      viewEntityCode: 'viewEntityCode',
      viewEntityFieldVOList: 'viewEntityFieldVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outerId: 'string',
      relationId: 'string',
      scopeCode: 'string',
      viewEntityCode: 'string',
      viewEntityFieldVOList: { 'type': 'array', 'itemType': MasterDataQueryResponseBodyResultViewEntityFieldVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequestBodyFieldList extends $tea.Model {
  name?: string;
  valueStr?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      valueStr: 'valueStr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      valueStr: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequestBodyScope extends $tea.Model {
  scopeCode?: string;
  version?: number;
  static names(): { [key: string]: string } {
    return {
      scopeCode: 'scopeCode',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      scopeCode: 'string',
      version: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveRequestBody extends $tea.Model {
  bizTime?: number;
  bizUk?: string;
  entityCode?: string;
  fieldList?: MasterDataSaveRequestBodyFieldList[];
  scope?: MasterDataSaveRequestBodyScope;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizTime: 'bizTime',
      bizUk: 'bizUk',
      entityCode: 'entityCode',
      fieldList: 'fieldList',
      scope: 'scope',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTime: 'number',
      bizUk: 'string',
      entityCode: 'string',
      fieldList: { 'type': 'array', 'itemType': MasterDataSaveRequestBodyFieldList },
      scope: MasterDataSaveRequestBodyScope,
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataSaveResponseBodyFailResult extends $tea.Model {
  bizUk?: string;
  errorCode?: string;
  errorMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      bizUk: 'bizUk',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizUk: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataTenantQueyResponseBodyResult extends $tea.Model {
  hasData?: boolean;
  integrateDataAuth?: boolean;
  name?: string;
  readAuth?: boolean;
  tenantId?: number;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      hasData: 'hasData',
      integrateDataAuth: 'integrateDataAuth',
      name: 'name',
      readAuth: 'readAuth',
      tenantId: 'tenantId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasData: 'boolean',
      integrateDataAuth: 'boolean',
      name: 'string',
      readAuth: 'boolean',
      tenantId: 'number',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryRequestQueryParamsConditionList extends $tea.Model {
  operate?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      operate: 'operate',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operate: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryRequestQueryParams extends $tea.Model {
  conditionList?: MasterDatasQueryRequestQueryParamsConditionList[];
  fieldCode?: string;
  joinType?: string;
  static names(): { [key: string]: string } {
    return {
      conditionList: 'conditionList',
      fieldCode: 'fieldCode',
      joinType: 'joinType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conditionList: { 'type': 'array', 'itemType': MasterDatasQueryRequestQueryParamsConditionList },
      fieldCode: 'string',
      joinType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO extends $tea.Model {
  key?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryResponseBodyResultViewEntityFieldVOList extends $tea.Model {
  fieldCode?: string;
  fieldDataVO?: MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO;
  fieldName?: string;
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldDataVO: 'fieldDataVO',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldDataVO: MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO,
      fieldName: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryResponseBodyResult extends $tea.Model {
  objId?: string;
  relationId?: string;
  scopeCode?: string;
  viewEntityCode?: string;
  viewEntityFieldVOList?: MasterDatasQueryResponseBodyResultViewEntityFieldVOList[];
  static names(): { [key: string]: string } {
    return {
      objId: 'objId',
      relationId: 'relationId',
      scopeCode: 'scopeCode',
      viewEntityCode: 'viewEntityCode',
      viewEntityFieldVOList: 'viewEntityFieldVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objId: 'string',
      relationId: 'string',
      scopeCode: 'string',
      viewEntityCode: 'string',
      viewEntityFieldVOList: { 'type': 'array', 'itemType': MasterDatasQueryResponseBodyResultViewEntityFieldVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomEntryProcessesResponseBodyList extends $tea.Model {
  formDesc?: string;
  formId?: string;
  formName?: string;
  shortUrl?: string;
  static names(): { [key: string]: string } {
    return {
      formDesc: 'formDesc',
      formId: 'formId',
      formName: 'formName',
      shortUrl: 'shortUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formDesc: 'string',
      formId: 'string',
      formName: 'string',
      shortUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList extends $tea.Model {
  deptId?: number;
  deptPath?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'dept_id',
      deptPath: 'dept_path',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      deptPath: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHrmEmployeeDismissionInfoResponseBodyResult extends $tea.Model {
  deptList?: QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList[];
  handoverUserId?: string;
  lastWorkDay?: number;
  mainDeptId?: number;
  mainDeptName?: string;
  name?: string;
  passiveReason?: string[];
  preStatus?: number;
  reasonMemo?: string;
  status?: number;
  userId?: string;
  voluntaryReason?: string[];
  static names(): { [key: string]: string } {
    return {
      deptList: 'deptList',
      handoverUserId: 'handoverUserId',
      lastWorkDay: 'lastWorkDay',
      mainDeptId: 'mainDeptId',
      mainDeptName: 'mainDeptName',
      name: 'name',
      passiveReason: 'passiveReason',
      preStatus: 'preStatus',
      reasonMemo: 'reasonMemo',
      status: 'status',
      userId: 'userId',
      voluntaryReason: 'voluntaryReason',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptList: { 'type': 'array', 'itemType': QueryHrmEmployeeDismissionInfoResponseBodyResultDeptList },
      handoverUserId: 'string',
      lastWorkDay: 'number',
      mainDeptId: 'number',
      mainDeptName: 'string',
      name: 'string',
      passiveReason: { 'type': 'array', 'itemType': 'string' },
      preStatus: 'number',
      reasonMemo: 'string',
      status: 'number',
      userId: 'string',
      voluntaryReason: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobRanksResponseBodyList extends $tea.Model {
  maxJobGrade?: number;
  minJobGrade?: number;
  rankCategoryId?: string;
  rankCode?: string;
  rankDescription?: string;
  rankId?: string;
  rankName?: string;
  static names(): { [key: string]: string } {
    return {
      maxJobGrade: 'maxJobGrade',
      minJobGrade: 'minJobGrade',
      rankCategoryId: 'rankCategoryId',
      rankCode: 'rankCode',
      rankDescription: 'rankDescription',
      rankId: 'rankId',
      rankName: 'rankName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxJobGrade: 'number',
      minJobGrade: 'number',
      rankCategoryId: 'string',
      rankCode: 'string',
      rankDescription: 'string',
      rankId: 'string',
      rankName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryJobsResponseBodyList extends $tea.Model {
  jobDescription?: string;
  jobId?: string;
  jobName?: string;
  static names(): { [key: string]: string } {
    return {
      jobDescription: 'jobDescription',
      jobId: 'jobId',
      jobName: 'jobName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobDescription: 'string',
      jobId: 'string',
      jobName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPositionsResponseBodyList extends $tea.Model {
  jobId?: string;
  positionCategoryId?: string;
  positionDes?: string;
  positionId?: string;
  positionName?: string;
  rankIdList?: string[];
  status?: number;
  static names(): { [key: string]: string } {
    return {
      jobId: 'jobId',
      positionCategoryId: 'positionCategoryId',
      positionDes: 'positionDes',
      positionId: 'positionId',
      positionName: 'positionName',
      rankIdList: 'rankIdList',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jobId: 'string',
      positionCategoryId: 'string',
      positionDes: 'string',
      positionId: 'string',
      positionName: 'string',
      rankIdList: { 'type': 'array', 'itemType': 'string' },
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaAvailableFieldListResponseBodyResult extends $tea.Model {
  fieldCode?: string;
  fieldName?: string;
  fieldType?: string;
  optionText?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
      optionText: 'optionText',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldType: 'string',
      optionText: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendIsvCardMessageResponseBodyHrmInteractiveCardSendResult extends $tea.Model {
  bizId?: string;
  errorCode?: string;
  errorMsg?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      errorCode: 'string',
      errorMsg: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncTaskTemplateRequestTaskScopeVO extends $tea.Model {
  deptIds?: number[];
  positionIds?: string[];
  roleIds?: string[];
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      positionIds: 'positionIds',
      roleIds: 'roleIds',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'number' },
      positionIds: { 'type': 'array', 'itemType': 'string' },
      roleIds: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
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
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
   *
   * @param request AddHrmPreentryRequest
   * @param headers AddHrmPreentryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return AddHrmPreentryResponse
   */
  async addHrmPreentryWithOptions(request: AddHrmPreentryRequest, headers: AddHrmPreentryHeaders, runtime: $Util.RuntimeOptions): Promise<AddHrmPreentryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.groups)) {
      body["groups"] = request.groups;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.needSendPreEntryMsg)) {
      body["needSendPreEntryMsg"] = request.needSendPreEntryMsg;
    }

    if (!Util.isUnset(request.preEntryTime)) {
      body["preEntryTime"] = request.preEntryTime;
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
      action: "AddHrmPreentry",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/preentries`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddHrmPreentryResponse>(await this.execute(params, req, runtime), new AddHrmPreentryResponse({}));
  }

  /**
   * @summary 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
   *
   * @param request AddHrmPreentryRequest
   * @return AddHrmPreentryResponse
   */
  async addHrmPreentry(request: AddHrmPreentryRequest): Promise<AddHrmPreentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddHrmPreentryHeaders({ });
    return await this.addHrmPreentryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事设备市场管理
   *
   * @param headers map
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeviceMarketManagerResponse
   */
  async deviceMarketManagerWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<DeviceMarketManagerResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "DeviceMarketManager",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/device/market/manager`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeviceMarketManagerResponse>(await this.execute(params, req, runtime), new DeviceMarketManagerResponse({}));
  }

  /**
   * @summary 智能人事设备市场管理
   *
   * @return DeviceMarketManagerResponse
   */
  async deviceMarketManager(): Promise<DeviceMarketManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.deviceMarketManagerWithOptions(headers, runtime);
  }

  /**
   * @summary 智能人事设备定向管理接口
   *
   * @param headers map
   * @param runtime runtime options for this request RuntimeOptions
   * @return DeviceMarketOrderManagerResponse
   */
  async deviceMarketOrderManagerWithOptions(headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<DeviceMarketOrderManagerResponse> {
    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
    });
    let params = new $OpenApi.Params({
      action: "DeviceMarketOrderManager",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/device/market/order/manager`,
      method: "GET",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeviceMarketOrderManagerResponse>(await this.execute(params, req, runtime), new DeviceMarketOrderManagerResponse({}));
  }

  /**
   * @summary 智能人事设备定向管理接口
   *
   * @return DeviceMarketOrderManagerResponse
   */
  async deviceMarketOrderManager(): Promise<DeviceMarketOrderManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.deviceMarketOrderManagerWithOptions(headers, runtime);
  }

  /**
   * @summary e签宝专有查询证件接口
   *
   * @param request ECertQueryRequest
   * @param headers ECertQueryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return ECertQueryResponse
   */
  async eCertQueryWithOptions(request: ECertQueryRequest, headers: ECertQueryHeaders, runtime: $Util.RuntimeOptions): Promise<ECertQueryResponse> {
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
      action: "ECertQuery",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/eCerts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ECertQueryResponse>(await this.execute(params, req, runtime), new ECertQueryResponse({}));
  }

  /**
   * @summary e签宝专有查询证件接口
   *
   * @param request ECertQueryRequest
   * @return ECertQueryResponse
   */
  async eCertQuery(request: ECertQueryRequest): Promise<ECertQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ECertQueryHeaders({ });
    return await this.eCertQueryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事员工档案附件更新
   *
   * @param request EmployeeAttachmentUpdateRequest
   * @param headers EmployeeAttachmentUpdateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return EmployeeAttachmentUpdateResponse
   */
  async employeeAttachmentUpdateWithOptions(request: EmployeeAttachmentUpdateRequest, headers: EmployeeAttachmentUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<EmployeeAttachmentUpdateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appAgentId)) {
      query["appAgentId"] = request.appAgentId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fieldCode)) {
      body["fieldCode"] = request.fieldCode;
    }

    if (!Util.isUnset(request.fileSuffix)) {
      body["fileSuffix"] = request.fileSuffix;
    }

    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "EmployeeAttachmentUpdate",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/employees/attachments`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EmployeeAttachmentUpdateResponse>(await this.execute(params, req, runtime), new EmployeeAttachmentUpdateResponse({}));
  }

  /**
   * @summary 智能人事员工档案附件更新
   *
   * @param request EmployeeAttachmentUpdateRequest
   * @return EmployeeAttachmentUpdateResponse
   */
  async employeeAttachmentUpdate(request: EmployeeAttachmentUpdateRequest): Promise<EmployeeAttachmentUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EmployeeAttachmentUpdateHeaders({ });
    return await this.employeeAttachmentUpdateWithOptions(request, headers, runtime);
  }

  /**
   * @summary 人事高级合同管理回退
   *
   * @param request EsignRollbackRequest
   * @param headers EsignRollbackHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return EsignRollbackResponse
   */
  async esignRollbackWithOptions(request: EsignRollbackRequest, headers: EsignRollbackHeaders, runtime: $Util.RuntimeOptions): Promise<EsignRollbackResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.optUserId)) {
      query["optUserId"] = request.optUserId;
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
      action: "EsignRollback",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/contracts/esign/rollback`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EsignRollbackResponse>(await this.execute(params, req, runtime), new EsignRollbackResponse({}));
  }

  /**
   * @summary 人事高级合同管理回退
   *
   * @param request EsignRollbackRequest
   * @return EsignRollbackResponse
   */
  async esignRollback(request: EsignRollbackRequest): Promise<EsignRollbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignRollbackHeaders({ });
    return await this.esignRollbackWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取员工花名册指定字段的信息，支持明细分组字段
   *
   * @param request GetEmployeeRosterByFieldRequest
   * @param headers GetEmployeeRosterByFieldHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetEmployeeRosterByFieldResponse
   */
  async getEmployeeRosterByFieldWithOptions(request: GetEmployeeRosterByFieldRequest, headers: GetEmployeeRosterByFieldHeaders, runtime: $Util.RuntimeOptions): Promise<GetEmployeeRosterByFieldResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appAgentId)) {
      body["appAgentId"] = request.appAgentId;
    }

    if (!Util.isUnset(request.fieldFilterList)) {
      body["fieldFilterList"] = request.fieldFilterList;
    }

    if (!Util.isUnset(request.text2SelectConvert)) {
      body["text2SelectConvert"] = request.text2SelectConvert;
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
      action: "GetEmployeeRosterByField",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/rosters/lists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEmployeeRosterByFieldResponse>(await this.execute(params, req, runtime), new GetEmployeeRosterByFieldResponse({}));
  }

  /**
   * @summary 获取员工花名册指定字段的信息，支持明细分组字段
   *
   * @param request GetEmployeeRosterByFieldRequest
   * @return GetEmployeeRosterByFieldResponse
   */
  async getEmployeeRosterByField(request: GetEmployeeRosterByFieldRequest): Promise<GetEmployeeRosterByFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmployeeRosterByFieldHeaders({ });
    return await this.getEmployeeRosterByFieldWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事权益查询
   *
   * @param request HrmBenefitQueryRequest
   * @param headers HrmBenefitQueryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmBenefitQueryResponse
   */
  async hrmBenefitQueryWithOptions(request: HrmBenefitQueryRequest, headers: HrmBenefitQueryHeaders, runtime: $Util.RuntimeOptions): Promise<HrmBenefitQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCodes)) {
      body["benefitCodes"] = request.benefitCodes;
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
      action: "HrmBenefitQuery",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/benefits/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmBenefitQueryResponse>(await this.execute(params, req, runtime), new HrmBenefitQueryResponse({}));
  }

  /**
   * @summary 智能人事权益查询
   *
   * @param request HrmBenefitQueryRequest
   * @return HrmBenefitQueryResponse
   */
  async hrmBenefitQuery(request: HrmBenefitQueryRequest): Promise<HrmBenefitQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmBenefitQueryHeaders({ });
    return await this.hrmBenefitQueryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事邮件发送
   *
   * @param request HrmMailSendRequest
   * @param headers HrmMailSendHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmMailSendResponse
   */
  async hrmMailSendWithOptions(request: HrmMailSendRequest, headers: HrmMailSendHeaders, runtime: $Util.RuntimeOptions): Promise<HrmMailSendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mail)) {
      body["mail"] = request.mail;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
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
      action: "HrmMailSend",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/mails/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmMailSendResponse>(await this.execute(params, req, runtime), new HrmMailSendResponse({}));
  }

  /**
   * @summary 智能人事邮件发送
   *
   * @param request HrmMailSendRequest
   * @return HrmMailSendResponse
   */
  async hrmMailSend(request: HrmMailSendRequest): Promise<HrmMailSendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmMailSendHeaders({ });
    return await this.hrmMailSendWithOptions(request, headers, runtime);
  }

  /**
   * @summary 人事2.0支持Moka事件转发
   *
   * @param request HrmMokaEventRequest
   * @param headers HrmMokaEventHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmMokaEventResponse
   */
  async hrmMokaEventWithOptions(request: HrmMokaEventRequest, headers: HrmMokaEventHeaders, runtime: $Util.RuntimeOptions): Promise<HrmMokaEventResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
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
      action: "HrmMokaEvent",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/moka/events/forward`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmMokaEventResponse>(await this.execute(params, req, runtime), new HrmMokaEventResponse({}));
  }

  /**
   * @summary 人事2.0支持Moka事件转发
   *
   * @param request HrmMokaEventRequest
   * @return HrmMokaEventResponse
   */
  async hrmMokaEvent(request: HrmMokaEventRequest): Promise<HrmMokaEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmMokaEventHeaders({ });
    return await this.hrmMokaEventWithOptions(request, headers, runtime);
  }

  /**
   * @summary 人事2.0支持Moka接口转发
   *
   * @param request HrmMokaOapiRequest
   * @param headers HrmMokaOapiHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmMokaOapiResponse
   */
  async hrmMokaOapiWithOptions(request: HrmMokaOapiRequest, headers: HrmMokaOapiHeaders, runtime: $Util.RuntimeOptions): Promise<HrmMokaOapiResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.apiCode)) {
      body["apiCode"] = request.apiCode;
    }

    if (!Util.isUnset(request.params)) {
      body["params"] = request.params;
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
      action: "HrmMokaOapi",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/moka/forward`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmMokaOapiResponse>(await this.execute(params, req, runtime), new HrmMokaOapiResponse({}));
  }

  /**
   * @summary 人事2.0支持Moka接口转发
   *
   * @param request HrmMokaOapiRequest
   * @return HrmMokaOapiResponse
   */
  async hrmMokaOapi(request: HrmMokaOapiRequest): Promise<HrmMokaOapiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmMokaOapiHeaders({ });
    return await this.hrmMokaOapiWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事转正接口
   *
   * @param request HrmProcessRegularRequest
   * @param headers HrmProcessRegularHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmProcessRegularResponse
   */
  async hrmProcessRegularWithOptions(request: HrmProcessRegularRequest, headers: HrmProcessRegularHeaders, runtime: $Util.RuntimeOptions): Promise<HrmProcessRegularResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operationId)) {
      body["operationId"] = request.operationId;
    }

    if (!Util.isUnset(request.regularDate)) {
      body["regularDate"] = request.regularDate;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
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
      action: "HrmProcessRegular",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/processes/regulars/become`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmProcessRegularResponse>(await this.execute(params, req, runtime), new HrmProcessRegularResponse({}));
  }

  /**
   * @summary 智能人事转正接口
   *
   * @param request HrmProcessRegularRequest
   * @return HrmProcessRegularResponse
   */
  async hrmProcessRegular(request: HrmProcessRegularRequest): Promise<HrmProcessRegularResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessRegularHeaders({ });
    return await this.hrmProcessRegularWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事调岗接口
   *
   * @param request HrmProcessTransferRequest
   * @param headers HrmProcessTransferHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmProcessTransferResponse
   */
  async hrmProcessTransferWithOptions(request: HrmProcessTransferRequest, headers: HrmProcessTransferHeaders, runtime: $Util.RuntimeOptions): Promise<HrmProcessTransferResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIdsAfterTransfer)) {
      body["deptIdsAfterTransfer"] = request.deptIdsAfterTransfer;
    }

    if (!Util.isUnset(request.jobIdAfterTransfer)) {
      body["jobIdAfterTransfer"] = request.jobIdAfterTransfer;
    }

    if (!Util.isUnset(request.mainDeptIdAfterTransfer)) {
      body["mainDeptIdAfterTransfer"] = request.mainDeptIdAfterTransfer;
    }

    if (!Util.isUnset(request.operateUserId)) {
      body["operateUserId"] = request.operateUserId;
    }

    if (!Util.isUnset(request.positionIdAfterTransfer)) {
      body["positionIdAfterTransfer"] = request.positionIdAfterTransfer;
    }

    if (!Util.isUnset(request.positionLevelAfterTransfer)) {
      body["positionLevelAfterTransfer"] = request.positionLevelAfterTransfer;
    }

    if (!Util.isUnset(request.positionNameAfterTransfer)) {
      body["positionNameAfterTransfer"] = request.positionNameAfterTransfer;
    }

    if (!Util.isUnset(request.rankIdAfterTransfer)) {
      body["rankIdAfterTransfer"] = request.rankIdAfterTransfer;
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
      action: "HrmProcessTransfer",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/processes/transfer`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmProcessTransferResponse>(await this.execute(params, req, runtime), new HrmProcessTransferResponse({}));
  }

  /**
   * @summary 智能人事调岗接口
   *
   * @param request HrmProcessTransferRequest
   * @return HrmProcessTransferResponse
   */
  async hrmProcessTransfer(request: HrmProcessTransferRequest): Promise<HrmProcessTransferResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessTransferHeaders({ });
    return await this.hrmProcessTransferWithOptions(request, headers, runtime);
  }

  /**
   * @summary 修改员工最后一次离职信息
   *
   * @param request HrmProcessUpdateTerminationInfoRequest
   * @param headers HrmProcessUpdateTerminationInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmProcessUpdateTerminationInfoResponse
   */
  async hrmProcessUpdateTerminationInfoWithOptions(request: HrmProcessUpdateTerminationInfoRequest, headers: HrmProcessUpdateTerminationInfoHeaders, runtime: $Util.RuntimeOptions): Promise<HrmProcessUpdateTerminationInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dismissionMemo)) {
      body["dismissionMemo"] = request.dismissionMemo;
    }

    if (!Util.isUnset(request.lastWorkDate)) {
      body["lastWorkDate"] = request.lastWorkDate;
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
      action: "HrmProcessUpdateTerminationInfo",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/processes/employees/terminations`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmProcessUpdateTerminationInfoResponse>(await this.execute(params, req, runtime), new HrmProcessUpdateTerminationInfoResponse({}));
  }

  /**
   * @summary 修改员工最后一次离职信息
   *
   * @param request HrmProcessUpdateTerminationInfoRequest
   * @return HrmProcessUpdateTerminationInfoResponse
   */
  async hrmProcessUpdateTerminationInfo(request: HrmProcessUpdateTerminationInfoRequest): Promise<HrmProcessUpdateTerminationInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessUpdateTerminationInfoHeaders({ });
    return await this.hrmProcessUpdateTerminationInfoWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事pts能力调用
   *
   * @param request HrmPtsServiceRequest
   * @param headers HrmPtsServiceHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return HrmPtsServiceResponse
   */
  async hrmPtsServiceWithOptions(request: HrmPtsServiceRequest, headers: HrmPtsServiceHeaders, runtime: $Util.RuntimeOptions): Promise<HrmPtsServiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.env)) {
      body["env"] = request.env;
    }

    if (!Util.isUnset(request.method)) {
      body["method"] = request.method;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset(request.params)) {
      body["params"] = request.params;
    }

    if (!Util.isUnset(request.path)) {
      body["path"] = request.path;
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
      action: "HrmPtsService",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/pts/request`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmPtsServiceResponse>(await this.execute(params, req, runtime), new HrmPtsServiceResponse({}));
  }

  /**
   * @summary 智能人事pts能力调用
   *
   * @param request HrmPtsServiceRequest
   * @return HrmPtsServiceResponse
   */
  async hrmPtsService(request: HrmPtsServiceRequest): Promise<HrmPtsServiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmPtsServiceHeaders({ });
    return await this.hrmPtsServiceWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事主数据删除服务
   *
   * @param request MasterDataDeleteRequest
   * @param headers MasterDataDeleteHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return MasterDataDeleteResponse
   */
  async masterDataDeleteWithOptions(request: MasterDataDeleteRequest, headers: MasterDataDeleteHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataDeleteResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantId)) {
      query["tenantId"] = request.tenantId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "MasterDataDelete",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/datas/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MasterDataDeleteResponse>(await this.execute(params, req, runtime), new MasterDataDeleteResponse({}));
  }

  /**
   * @summary 智能人事主数据删除服务
   *
   * @param request MasterDataDeleteRequest
   * @return MasterDataDeleteResponse
   */
  async masterDataDelete(request: MasterDataDeleteRequest): Promise<MasterDataDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataDeleteHeaders({ });
    return await this.masterDataDeleteWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事主数据查询服务
   *
   * @param request MasterDataQueryRequest
   * @param headers MasterDataQueryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return MasterDataQueryResponse
   */
  async masterDataQueryWithOptions(request: MasterDataQueryRequest, headers: MasterDataQueryHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizUK)) {
      body["bizUK"] = request.bizUK;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.queryParams)) {
      body["queryParams"] = request.queryParams;
    }

    if (!Util.isUnset(request.relationIds)) {
      body["relationIds"] = request.relationIds;
    }

    if (!Util.isUnset(request.scopeCode)) {
      body["scopeCode"] = request.scopeCode;
    }

    if (!Util.isUnset(request.tenantId)) {
      body["tenantId"] = request.tenantId;
    }

    if (!Util.isUnset(request.viewEntityCode)) {
      body["viewEntityCode"] = request.viewEntityCode;
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
      action: "MasterDataQuery",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/datas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MasterDataQueryResponse>(await this.execute(params, req, runtime), new MasterDataQueryResponse({}));
  }

  /**
   * @summary 智能人事主数据查询服务
   *
   * @param request MasterDataQueryRequest
   * @return MasterDataQueryResponse
   */
  async masterDataQuery(request: MasterDataQueryRequest): Promise<MasterDataQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataQueryHeaders({ });
    return await this.masterDataQueryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事主数据保存服务
   *
   * @param request MasterDataSaveRequest
   * @param headers MasterDataSaveHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return MasterDataSaveResponse
   */
  async masterDataSaveWithOptions(request: MasterDataSaveRequest, headers: MasterDataSaveHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataSaveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantId)) {
      query["tenantId"] = request.tenantId;
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "MasterDataSave",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/datas/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MasterDataSaveResponse>(await this.execute(params, req, runtime), new MasterDataSaveResponse({}));
  }

  /**
   * @summary 智能人事主数据保存服务
   *
   * @param request MasterDataSaveRequest
   * @return MasterDataSaveResponse
   */
  async masterDataSave(request: MasterDataSaveRequest): Promise<MasterDataSaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataSaveHeaders({ });
    return await this.masterDataSaveWithOptions(request, headers, runtime);
  }

  /**
   * @summary 主数据中拥有某个领域数据的租户信息查询
   *
   * @param request MasterDataTenantQueyRequest
   * @param headers MasterDataTenantQueyHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return MasterDataTenantQueyResponse
   */
  async masterDataTenantQueyWithOptions(request: MasterDataTenantQueyRequest, headers: MasterDataTenantQueyHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDataTenantQueyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.entityCode)) {
      query["entityCode"] = request.entityCode;
    }

    if (!Util.isUnset(request.scopeCode)) {
      query["scopeCode"] = request.scopeCode;
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
      action: "MasterDataTenantQuey",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/tenants`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MasterDataTenantQueyResponse>(await this.execute(params, req, runtime), new MasterDataTenantQueyResponse({}));
  }

  /**
   * @summary 主数据中拥有某个领域数据的租户信息查询
   *
   * @param request MasterDataTenantQueyRequest
   * @return MasterDataTenantQueyResponse
   */
  async masterDataTenantQuey(request: MasterDataTenantQueyRequest): Promise<MasterDataTenantQueyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataTenantQueyHeaders({ });
    return await this.masterDataTenantQueyWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事主数据查询服务
   *
   * @param request MasterDatasQueryRequest
   * @param headers MasterDatasQueryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return MasterDatasQueryResponse
   */
  async masterDatasQueryWithOptions(request: MasterDatasQueryRequest, headers: MasterDatasQueryHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDatasQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizUK)) {
      body["bizUK"] = request.bizUK;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.queryParams)) {
      body["queryParams"] = request.queryParams;
    }

    if (!Util.isUnset(request.relationIds)) {
      body["relationIds"] = request.relationIds;
    }

    if (!Util.isUnset(request.scopeCode)) {
      body["scopeCode"] = request.scopeCode;
    }

    if (!Util.isUnset(request.tenantId)) {
      body["tenantId"] = request.tenantId;
    }

    if (!Util.isUnset(request.viewEntityCode)) {
      body["viewEntityCode"] = request.viewEntityCode;
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
      action: "MasterDatasQuery",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masterDatas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MasterDatasQueryResponse>(await this.execute(params, req, runtime), new MasterDatasQueryResponse({}));
  }

  /**
   * @summary 智能人事主数据查询服务
   *
   * @param request MasterDatasQueryRequest
   * @return MasterDatasQueryResponse
   */
  async masterDatasQuery(request: MasterDatasQueryRequest): Promise<MasterDatasQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDatasQueryHeaders({ });
    return await this.masterDatasQueryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 自定义入职流程数据查询
   *
   * @param request QueryCustomEntryProcessesRequest
   * @param headers QueryCustomEntryProcessesHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCustomEntryProcessesResponse
   */
  async queryCustomEntryProcessesWithOptions(request: QueryCustomEntryProcessesRequest, headers: QueryCustomEntryProcessesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomEntryProcessesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.operateUserId)) {
      query["operateUserId"] = request.operateUserId;
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
      action: "QueryCustomEntryProcesses",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/customEntryProcesses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCustomEntryProcessesResponse>(await this.execute(params, req, runtime), new QueryCustomEntryProcessesResponse({}));
  }

  /**
   * @summary 自定义入职流程数据查询
   *
   * @param request QueryCustomEntryProcessesRequest
   * @return QueryCustomEntryProcessesResponse
   */
  async queryCustomEntryProcesses(request: QueryCustomEntryProcessesRequest): Promise<QueryCustomEntryProcessesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomEntryProcessesHeaders({ });
    return await this.queryCustomEntryProcessesWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询企业已离职员工列表
   *
   * @param request QueryDismissionStaffIdListRequest
   * @param headers QueryDismissionStaffIdListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryDismissionStaffIdListResponse
   */
  async queryDismissionStaffIdListWithOptions(request: QueryDismissionStaffIdListRequest, headers: QueryDismissionStaffIdListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDismissionStaffIdListResponse> {
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
      action: "QueryDismissionStaffIdList",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/employees/dismissions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDismissionStaffIdListResponse>(await this.execute(params, req, runtime), new QueryDismissionStaffIdListResponse({}));
  }

  /**
   * @summary 查询企业已离职员工列表
   *
   * @param request QueryDismissionStaffIdListRequest
   * @return QueryDismissionStaffIdListResponse
   */
  async queryDismissionStaffIdList(request: QueryDismissionStaffIdListRequest): Promise<QueryDismissionStaffIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDismissionStaffIdListHeaders({ });
    return await this.queryDismissionStaffIdListWithOptions(request, headers, runtime);
  }

  /**
   * @summary 根据传入的staffId列表，批量查询员工的离职信息
   *
   * @param tmpReq QueryHrmEmployeeDismissionInfoRequest
   * @param headers QueryHrmEmployeeDismissionInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryHrmEmployeeDismissionInfoResponse
   */
  async queryHrmEmployeeDismissionInfoWithOptions(tmpReq: QueryHrmEmployeeDismissionInfoRequest, headers: QueryHrmEmployeeDismissionInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHrmEmployeeDismissionInfoResponse> {
    Util.validateModel(tmpReq);
    let request = new QueryHrmEmployeeDismissionInfoShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.userIdList)) {
      request.userIdListShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.userIdList, "userIdList", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIdListShrink)) {
      query["userIdList"] = request.userIdListShrink;
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
      action: "QueryHrmEmployeeDismissionInfo",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/employees/dimissionInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryHrmEmployeeDismissionInfoResponse>(await this.execute(params, req, runtime), new QueryHrmEmployeeDismissionInfoResponse({}));
  }

  /**
   * @summary 根据传入的staffId列表，批量查询员工的离职信息
   *
   * @param request QueryHrmEmployeeDismissionInfoRequest
   * @return QueryHrmEmployeeDismissionInfoResponse
   */
  async queryHrmEmployeeDismissionInfo(request: QueryHrmEmployeeDismissionInfoRequest): Promise<QueryHrmEmployeeDismissionInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHrmEmployeeDismissionInfoHeaders({ });
    return await this.queryHrmEmployeeDismissionInfoWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页查询企业的职级信息
   *
   * @param request QueryJobRanksRequest
   * @param headers QueryJobRanksHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryJobRanksResponse
   */
  async queryJobRanksWithOptions(request: QueryJobRanksRequest, headers: QueryJobRanksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobRanksResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.rankCategoryId)) {
      query["rankCategoryId"] = request.rankCategoryId;
    }

    if (!Util.isUnset(request.rankCode)) {
      query["rankCode"] = request.rankCode;
    }

    if (!Util.isUnset(request.rankName)) {
      query["rankName"] = request.rankName;
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
      action: "QueryJobRanks",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/jobRanks`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryJobRanksResponse>(await this.execute(params, req, runtime), new QueryJobRanksResponse({}));
  }

  /**
   * @summary 分页查询企业的职级信息
   *
   * @param request QueryJobRanksRequest
   * @return QueryJobRanksResponse
   */
  async queryJobRanks(request: QueryJobRanksRequest): Promise<QueryJobRanksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobRanksHeaders({ });
    return await this.queryJobRanksWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页查询企业职务信息
   *
   * @param request QueryJobsRequest
   * @param headers QueryJobsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryJobsResponse
   */
  async queryJobsWithOptions(request: QueryJobsRequest, headers: QueryJobsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryJobsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jobName)) {
      query["jobName"] = request.jobName;
    }

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
      action: "QueryJobs",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/jobs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryJobsResponse>(await this.execute(params, req, runtime), new QueryJobsResponse({}));
  }

  /**
   * @summary 分页查询企业职务信息
   *
   * @param request QueryJobsRequest
   * @return QueryJobsResponse
   */
  async queryJobs(request: QueryJobsRequest): Promise<QueryJobsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobsHeaders({ });
    return await this.queryJobsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页查询企业职位信息
   *
   * @param request QueryPositionsRequest
   * @param headers QueryPositionsHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryPositionsResponse
   */
  async queryPositionsWithOptions(request: QueryPositionsRequest, headers: QueryPositionsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPositionsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.inCategoryIds)) {
      body["inCategoryIds"] = request.inCategoryIds;
    }

    if (!Util.isUnset(request.inPositionIds)) {
      body["inPositionIds"] = request.inPositionIds;
    }

    if (!Util.isUnset(request.positionName)) {
      body["positionName"] = request.positionName;
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
      action: "QueryPositions",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/positions/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPositionsResponse>(await this.execute(params, req, runtime), new QueryPositionsResponse({}));
  }

  /**
   * @summary 分页查询企业职位信息
   *
   * @param request QueryPositionsRequest
   * @return QueryPositionsResponse
   */
  async queryPositions(request: QueryPositionsRequest): Promise<QueryPositionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPositionsHeaders({ });
    return await this.queryPositionsWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询花名册中有权限的字段列表
   *
   * @param request RosterMetaAvailableFieldListRequest
   * @param headers RosterMetaAvailableFieldListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return RosterMetaAvailableFieldListResponse
   */
  async rosterMetaAvailableFieldListWithOptions(request: RosterMetaAvailableFieldListRequest, headers: RosterMetaAvailableFieldListHeaders, runtime: $Util.RuntimeOptions): Promise<RosterMetaAvailableFieldListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appAgentId)) {
      query["appAgentId"] = request.appAgentId;
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
      action: "RosterMetaAvailableFieldList",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/rosters/meta/authorities/fields`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RosterMetaAvailableFieldListResponse>(await this.execute(params, req, runtime), new RosterMetaAvailableFieldListResponse({}));
  }

  /**
   * @summary 查询花名册中有权限的字段列表
   *
   * @param request RosterMetaAvailableFieldListRequest
   * @return RosterMetaAvailableFieldListResponse
   */
  async rosterMetaAvailableFieldList(request: RosterMetaAvailableFieldListRequest): Promise<RosterMetaAvailableFieldListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RosterMetaAvailableFieldListHeaders({ });
    return await this.rosterMetaAvailableFieldListWithOptions(request, headers, runtime);
  }

  /**
   * @summary 智能人事花名册字段选项修改
   *
   * @param request RosterMetaFieldOptionsUpdateRequest
   * @param headers RosterMetaFieldOptionsUpdateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return RosterMetaFieldOptionsUpdateResponse
   */
  async rosterMetaFieldOptionsUpdateWithOptions(request: RosterMetaFieldOptionsUpdateRequest, headers: RosterMetaFieldOptionsUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<RosterMetaFieldOptionsUpdateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appAgentId)) {
      query["appAgentId"] = request.appAgentId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fieldCode)) {
      body["fieldCode"] = request.fieldCode;
    }

    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.labels)) {
      body["labels"] = request.labels;
    }

    if (!Util.isUnset(request.modifyType)) {
      body["modifyType"] = request.modifyType;
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
      action: "RosterMetaFieldOptionsUpdate",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/rosters/meta/fields/options`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RosterMetaFieldOptionsUpdateResponse>(await this.execute(params, req, runtime), new RosterMetaFieldOptionsUpdateResponse({}));
  }

  /**
   * @summary 智能人事花名册字段选项修改
   *
   * @param request RosterMetaFieldOptionsUpdateRequest
   * @return RosterMetaFieldOptionsUpdateResponse
   */
  async rosterMetaFieldOptionsUpdate(request: RosterMetaFieldOptionsUpdateRequest): Promise<RosterMetaFieldOptionsUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RosterMetaFieldOptionsUpdateHeaders({ });
    return await this.rosterMetaFieldOptionsUpdateWithOptions(request, headers, runtime);
  }

  /**
   * @summary ISV发送卡片消息
   *
   * @param request SendIsvCardMessageRequest
   * @param headers SendIsvCardMessageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SendIsvCardMessageResponse
   */
  async sendIsvCardMessageWithOptions(request: SendIsvCardMessageRequest, headers: SendIsvCardMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendIsvCardMessageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      query["agentId"] = request.agentId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.messageType)) {
      body["messageType"] = request.messageType;
    }

    if (!Util.isUnset(request.receiverUserIds)) {
      body["receiverUserIds"] = request.receiverUserIds;
    }

    if (!Util.isUnset(request.sceneType)) {
      body["sceneType"] = request.sceneType;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.senderUserId)) {
      body["senderUserId"] = request.senderUserId;
    }

    if (!Util.isUnset(request.valueMap)) {
      body["valueMap"] = request.valueMap;
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
      action: "SendIsvCardMessage",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/cardMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendIsvCardMessageResponse>(await this.execute(params, req, runtime), new SendIsvCardMessageResponse({}));
  }

  /**
   * @summary ISV发送卡片消息
   *
   * @param request SendIsvCardMessageRequest
   * @return SendIsvCardMessageResponse
   */
  async sendIsvCardMessage(request: SendIsvCardMessageRequest): Promise<SendIsvCardMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendIsvCardMessageHeaders({ });
    return await this.sendIsvCardMessageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 初始化解决方案任务
   *
   * @param request SolutionTaskInitRequest
   * @param headers SolutionTaskInitHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SolutionTaskInitResponse
   */
  async solutionTaskInitWithOptions(request: SolutionTaskInitRequest, headers: SolutionTaskInitHeaders, runtime: $Util.RuntimeOptions): Promise<SolutionTaskInitResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.solutionType)) {
      query["solutionType"] = request.solutionType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.claimTime)) {
      body["claimTime"] = request.claimTime;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.finishTime)) {
      body["finishTime"] = request.finishTime;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SolutionTaskInit",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/solutions/tasks/init`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SolutionTaskInitResponse>(await this.execute(params, req, runtime), new SolutionTaskInitResponse({}));
  }

  /**
   * @summary 初始化解决方案任务
   *
   * @param request SolutionTaskInitRequest
   * @return SolutionTaskInitResponse
   */
  async solutionTaskInit(request: SolutionTaskInitRequest): Promise<SolutionTaskInitResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SolutionTaskInitHeaders({ });
    return await this.solutionTaskInitWithOptions(request, headers, runtime);
  }

  /**
   * @summary 保存解决方案任务
   *
   * @param request SolutionTaskSaveRequest
   * @param headers SolutionTaskSaveHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SolutionTaskSaveResponse
   */
  async solutionTaskSaveWithOptions(request: SolutionTaskSaveRequest, headers: SolutionTaskSaveHeaders, runtime: $Util.RuntimeOptions): Promise<SolutionTaskSaveResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.solutionType)) {
      query["solutionType"] = request.solutionType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.claimTime)) {
      body["claimTime"] = request.claimTime;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.finishTime)) {
      body["finishTime"] = request.finishTime;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset(request.solutionInstanceId)) {
      body["solutionInstanceId"] = request.solutionInstanceId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.taskType)) {
      body["taskType"] = request.taskType;
    }

    if (!Util.isUnset(request.templateOuterId)) {
      body["templateOuterId"] = request.templateOuterId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SolutionTaskSave",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/solutions/tasks/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SolutionTaskSaveResponse>(await this.execute(params, req, runtime), new SolutionTaskSaveResponse({}));
  }

  /**
   * @summary 保存解决方案任务
   *
   * @param request SolutionTaskSaveRequest
   * @return SolutionTaskSaveResponse
   */
  async solutionTaskSave(request: SolutionTaskSaveRequest): Promise<SolutionTaskSaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SolutionTaskSaveHeaders({ });
    return await this.solutionTaskSaveWithOptions(request, headers, runtime);
  }

  /**
   * @summary 同步解决方案任务模版
   *
   * @param request SyncTaskTemplateRequest
   * @param headers SyncTaskTemplateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SyncTaskTemplateResponse
   */
  async syncTaskTemplateWithOptions(request: SyncTaskTemplateRequest, headers: SyncTaskTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<SyncTaskTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.solutionType)) {
      query["solutionType"] = request.solutionType;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.delete)) {
      body["delete"] = request.delete;
    }

    if (!Util.isUnset(request.des)) {
      body["des"] = request.des;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.outerId)) {
      body["outerId"] = request.outerId;
    }

    if (!Util.isUnset(request.taskScopeVO)) {
      body["taskScopeVO"] = request.taskScopeVO;
    }

    if (!Util.isUnset(request.taskType)) {
      body["taskType"] = request.taskType;
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
      action: "SyncTaskTemplate",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/solutions/tasks/templates/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncTaskTemplateResponse>(await this.execute(params, req, runtime), new SyncTaskTemplateResponse({}));
  }

  /**
   * @summary 同步解决方案任务模版
   *
   * @param request SyncTaskTemplateRequest
   * @return SyncTaskTemplateResponse
   */
  async syncTaskTemplate(request: SyncTaskTemplateRequest): Promise<SyncTaskTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncTaskTemplateHeaders({ });
    return await this.syncTaskTemplateWithOptions(request, headers, runtime);
  }

  /**
   * @summary ISV更新卡片消息
   *
   * @param request UpdateIsvCardMessageRequest
   * @param headers UpdateIsvCardMessageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateIsvCardMessageResponse
   */
  async updateIsvCardMessageWithOptions(request: UpdateIsvCardMessageRequest, headers: UpdateIsvCardMessageHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateIsvCardMessageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      query["agentId"] = request.agentId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.messageType)) {
      body["messageType"] = request.messageType;
    }

    if (!Util.isUnset(request.sceneType)) {
      body["sceneType"] = request.sceneType;
    }

    if (!Util.isUnset(request.scope)) {
      body["scope"] = request.scope;
    }

    if (!Util.isUnset(request.valueMap)) {
      body["valueMap"] = request.valueMap;
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
      action: "UpdateIsvCardMessage",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/cardMessages`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateIsvCardMessageResponse>(await this.execute(params, req, runtime), new UpdateIsvCardMessageResponse({}));
  }

  /**
   * @summary ISV更新卡片消息
   *
   * @param request UpdateIsvCardMessageRequest
   * @return UpdateIsvCardMessageResponse
   */
  async updateIsvCardMessage(request: UpdateIsvCardMessageRequest): Promise<UpdateIsvCardMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateIsvCardMessageHeaders({ });
    return await this.updateIsvCardMessageWithOptions(request, headers, runtime);
  }

}
