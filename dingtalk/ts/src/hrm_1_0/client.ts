// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class ResultValue extends $tea.Model {
  status?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  createUserId?: string;
  ext?: AddHrmLegalEntityRequestExt;
  /**
   * @remarks
   * This parameter is required.
   */
  legalEntityName?: string;
  legalEntityShortName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  legalEntityStatus?: number;
  legalPersonName?: string;
  dingTenantId?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createUserId: 'createUserId',
      ext: 'ext',
      legalEntityName: 'legalEntityName',
      legalEntityShortName: 'legalEntityShortName',
      legalEntityStatus: 'legalEntityStatus',
      legalPersonName: 'legalPersonName',
      dingTenantId: 'dingTenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createUserId: 'string',
      ext: AddHrmLegalEntityRequestExt,
      legalEntityName: 'string',
      legalEntityShortName: 'string',
      legalEntityStatus: 'number',
      legalPersonName: 'string',
      dingTenantId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityResponseBody extends $tea.Model {
  result?: AddHrmLegalEntityResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AddHrmLegalEntityResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddHrmLegalEntityResponseBody;
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
      body: AddHrmLegalEntityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  /**
   * @remarks
   * This parameter is required.
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * manager123
   */
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

export class CreateRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRecordRequest extends $tea.Model {
  attachmentList?: CreateRecordRequestAttachmentList[];
  /**
   * @example
   * 908608088
   */
  deptId?: number;
  fieldList?: CreateRecordRequestFieldList[];
  groupList?: CreateRecordRequestGroupList[];
  /**
   * @example
   * xxx员工劳动合同电子签署
   */
  remark?: string;
  /**
   * @example
   * xxx有限公司
   */
  signLastLegalEntityName?: string;
  /**
   * @example
   * xxx有限公司
   */
  signLegalEntityName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CONTRACT
   */
  signSource?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 48510731071405348944
   */
  signStartUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 660658
   */
  signUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 9ad11eb3daa24a9692037079e0732f13
   */
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      attachmentList: 'attachmentList',
      deptId: 'deptId',
      fieldList: 'fieldList',
      groupList: 'groupList',
      remark: 'remark',
      signLastLegalEntityName: 'signLastLegalEntityName',
      signLegalEntityName: 'signLegalEntityName',
      signSource: 'signSource',
      signStartUserId: 'signStartUserId',
      signUserId: 'signUserId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachmentList: { 'type': 'array', 'itemType': CreateRecordRequestAttachmentList },
      deptId: 'number',
      fieldList: { 'type': 'array', 'itemType': CreateRecordRequestFieldList },
      groupList: { 'type': 'array', 'itemType': CreateRecordRequestGroupList },
      remark: 'string',
      signLastLegalEntityName: 'string',
      signLegalEntityName: 'string',
      signSource: 'string',
      signStartUserId: 'string',
      signUserId: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRecordResponseBody extends $tea.Model {
  result?: CreateRecordResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CreateRecordResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRecordResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateRecordResponseBody;
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
      body: CreateRecordResponseBody,
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
  /**
   * @example
   * manager231
   * 
   * **if can be null:**
   * false
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

export class ECertQueryResponseBody extends $tea.Model {
  /**
   * @example
   * 3300111192912113
   */
  certNO?: string;
  /**
   * @example
   * 1123124124124
   */
  employJobId?: string;
  /**
   * @example
   * 职务
   */
  employJobIdLabel?: string;
  /**
   * @example
   * 1231231232313123
   */
  employPositionId?: string;
  /**
   * @example
   * 职位
   */
  employPositionIdLabel?: string;
  /**
   * @example
   * 498192313
   */
  employPositionRankId?: string;
  /**
   * @example
   * 职级
   */
  employPositionRankIdLabel?: string;
  /**
   * @example
   * 2020-03-14
   */
  hiredDate?: string;
  /**
   * @example
   * 2021-03-14
   */
  lastWorkDay?: string;
  /**
   * @example
   * -1
   */
  mainDeptId?: number;
  /**
   * @example
   * 测试部门
   */
  mainDeptName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 李四
   */
  name?: string;
  /**
   * @example
   * 张三
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  appAgentId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldCode?: string;
  /**
   * @example
   * .png
   */
  fileSuffix?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "$iAEKAqNwbmcDBgTNAk"
   */
  mediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * admin123
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  appAgentId?: number;
  fieldFilterList?: string[];
  text2SelectConvert?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class GetFileTemplateListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListRequest extends $tea.Model {
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
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CONTRACT
   */
  signSource?: string;
  /**
   * @example
   * 1
   */
  templateStatus?: number;
  templateTypeList?: string[];
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      signSource: 'signSource',
      templateStatus: 'templateStatus',
      templateTypeList: 'templateTypeList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      signSource: 'string',
      templateStatus: 'number',
      templateTypeList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListResponseBody extends $tea.Model {
  result?: GetFileTemplateListResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetFileTemplateListResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFileTemplateListResponseBody;
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
      body: GetFileTemplateListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByIdRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  body?: string[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByIdResponseBody extends $tea.Model {
  result?: GetSignRecordByIdResponseBodyResult[];
  /**
   * @remarks
   * This parameter is required.
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetSignRecordByIdResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignRecordByIdResponseBody;
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
      body: GetSignRecordByIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByUserIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByUserIdRequest extends $tea.Model {
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
  signStatus?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 660658
   */
  signUserId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      signStatus: 'signStatus',
      signUserId: 'signUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      signStatus: { 'type': 'array', 'itemType': 'string' },
      signUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByUserIdResponseBody extends $tea.Model {
  result?: GetSignRecordByUserIdResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetSignRecordByUserIdResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByUserIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignRecordByUserIdResponseBody;
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
      body: GetSignRecordByUserIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmAuthResourcesQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmAuthResourcesQueryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  authResourceIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1231
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      authResourceIds: 'authResourceIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authResourceIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmAuthResourcesQueryResponseBody extends $tea.Model {
  result?: HrmAuthResourcesQueryResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': HrmAuthResourcesQueryResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmAuthResourcesQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmAuthResourcesQueryResponseBody;
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
      body: HrmAuthResourcesQueryResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
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

export class HrmCorpConfigQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmCorpConfigQueryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * policy
   */
  subType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hrm_ai
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      subType: 'subType',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subType: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmCorpConfigQueryResponseBody extends $tea.Model {
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

export class HrmCorpConfigQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmCorpConfigQueryResponseBody;
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
      body: HrmCorpConfigQueryResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  mail?: HrmMailSendRequestMail;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * /user/role/get
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"a":"b"}
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * /user/role/get
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16690147049882572
   */
  operationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1672542359000
   */
  regularDate?: number;
  /**
   * @example
   * 同意转正
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16690147049882572
   */
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
  /**
   * @remarks
   * This parameter is required.
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

export class HrmProcessTerminationAndHandoverHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTerminationAndHandoverRequest extends $tea.Model {
  /**
   * @example
   * user123
   */
  aflowHandOverUserId?: string;
  /**
   * @example
   * user123
   */
  dingPanHandoverUserId?: string;
  /**
   * @example
   * user123
   */
  directSubordinatesHandoverUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * aefadfadaewedad
   */
  dismissionMemo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  dismissionReason?: number;
  /**
   * @example
   * user123
   */
  docNoteHandoverUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1704074400000
   */
  lastWorkDate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 经理
   */
  optUserId?: string;
  /**
   * @example
   * user123
   */
  permissionHandoverUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2332
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      aflowHandOverUserId: 'aflowHandOverUserId',
      dingPanHandoverUserId: 'dingPanHandoverUserId',
      directSubordinatesHandoverUserId: 'directSubordinatesHandoverUserId',
      dismissionMemo: 'dismissionMemo',
      dismissionReason: 'dismissionReason',
      docNoteHandoverUserId: 'docNoteHandoverUserId',
      lastWorkDate: 'lastWorkDate',
      optUserId: 'optUserId',
      permissionHandoverUserId: 'permissionHandoverUserId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aflowHandOverUserId: 'string',
      dingPanHandoverUserId: 'string',
      directSubordinatesHandoverUserId: 'string',
      dismissionMemo: 'string',
      dismissionReason: 'number',
      docNoteHandoverUserId: 'string',
      lastWorkDate: 'number',
      optUserId: 'string',
      permissionHandoverUserId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmProcessTerminationAndHandoverResponseBody extends $tea.Model {
  /**
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

export class HrmProcessTerminationAndHandoverResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: HrmProcessTerminationAndHandoverResponseBody;
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
      body: HrmProcessTerminationAndHandoverResponseBody,
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
  /**
   * @example
   * aefadfadaewedad
   */
  jobIdAfterTransfer?: string;
  /**
   * @example
   * 123L
   */
  mainDeptIdAfterTransfer?: number;
  /**
   * @example
   * 232312312
   */
  operateUserId?: string;
  /**
   * @example
   * fasdfaddsadfa
   */
  positionIdAfterTransfer?: string;
  /**
   * @example
   * L1
   */
  positionLevelAfterTransfer?: string;
  /**
   * @example
   * 经理
   */
  positionNameAfterTransfer?: string;
  /**
   * @example
   * fasdfaddsadfa
   */
  rankIdAfterTransfer?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2332
   */
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
  /**
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 因个人原因离职
   */
  dismissionMemo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1672502400000
   */
  lastWorkDate?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * admin123
   */
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
  /**
   * @remarks
   * This parameter is required.
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dev  or online
   */
  env?: string;
  /**
   * @example
   * GET/POST
   */
  method?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abd123213
   */
  outerId?: string;
  params?: any;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * /user/role/get
   */
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

export class InvalidSignRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvalidSignRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  invalidUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  signRecordIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 作废测试
   */
  statusRemark?: string;
  static names(): { [key: string]: string } {
    return {
      invalidUserId: 'invalidUserId',
      signRecordIds: 'signRecordIds',
      statusRemark: 'statusRemark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invalidUserId: 'string',
      signRecordIds: { 'type': 'array', 'itemType': 'string' },
      statusRemark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvalidSignRecordsResponseBody extends $tea.Model {
  result?: InvalidSignRecordsResponseBodyResult;
  /**
   * @remarks
   * This parameter is required.
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: InvalidSignRecordsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvalidSignRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InvalidSignRecordsResponseBody;
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
      body: InvalidSignRecordsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  body?: MasterDataDeleteRequestBody[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * uk_12123
   */
  bizUK?: string;
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
  /**
   * @example
   * admin1234
   */
  optUserId?: string;
  queryParams?: MasterDataQueryRequestQueryParams[];
  /**
   * @remarks
   * This parameter is required.
   */
  relationIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PERFORMANCE
   */
  scopeCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  tenantId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * base
   */
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
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: MasterDataQueryResponseBodyResult[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  success?: boolean;
  /**
   * @example
   * 100
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  body?: MasterDataSaveRequestBody[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  entityCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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

export class MasterDatasGetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasGetRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * uk1231
   */
  objId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PERFORMANCE
   */
  scopeCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  tenantId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * base
   */
  viewEntityCode?: string;
  static names(): { [key: string]: string } {
    return {
      objId: 'objId',
      scopeCode: 'scopeCode',
      tenantId: 'tenantId',
      viewEntityCode: 'viewEntityCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      objId: 'string',
      scopeCode: 'string',
      tenantId: 'number',
      viewEntityCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasGetResponseBody extends $tea.Model {
  result?: MasterDatasGetResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: MasterDatasGetResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasGetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: MasterDatasGetResponseBody;
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
      body: MasterDatasGetResponseBody,
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
  /**
   * @example
   * uk_12123
   */
  bizUK?: string;
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
  queryParams?: MasterDatasQueryRequestQueryParams[];
  /**
   * @remarks
   * This parameter is required.
   */
  relationIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PERFORMANCE
   */
  scopeCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  tenantId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * base
   */
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
  /**
   * @example
   * 0
   */
  nextToken?: number;
  result?: MasterDatasQueryResponseBodyResult[];
  /**
   * @remarks
   * This parameter is required.
   */
  success?: boolean;
  /**
   * @example
   * 100
   */
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

export class OpenOemMicroAppHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenOemMicroAppRequest extends $tea.Model {
  /**
   * @example
   * 12
   */
  tenantId?: number;
  static names(): { [key: string]: string } {
    return {
      tenantId: 'tenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenantId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenOemMicroAppResponseBody extends $tea.Model {
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenOemMicroAppResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenOemMicroAppResponseBody;
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
      body: OpenOemMicroAppResponseBody,
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
  /**
   * @example
   * 20，最大为100，不填默认为100
   */
  maxResults?: number;
  /**
   * @example
   * 默认为0
   */
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
  /**
   * @example
   * 30
   */
  maxResults?: number;
  /**
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 工程师
   */
  jobName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20，最大为100
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

export class QueryMicroAppStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMicroAppStatusRequest extends $tea.Model {
  tenantIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      tenantIdList: 'tenantIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenantIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMicroAppStatusResponseBody extends $tea.Model {
  requestId?: string;
  result?: { [key: string]: ResultValue };
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: { 'type': 'map', 'keyType': 'string', 'valueType': ResultValue },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMicroAppStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMicroAppStatusResponseBody;
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
      body: QueryMicroAppStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMicroAppViewHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMicroAppViewRequest extends $tea.Model {
  tenantIdList?: number[];
  /**
   * @example
   * 2163515669935611
   */
  viewUserId?: string;
  static names(): { [key: string]: string } {
    return {
      tenantIdList: 'tenantIdList',
      viewUserId: 'viewUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tenantIdList: { 'type': 'array', 'itemType': 'number' },
      viewUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMicroAppViewResponseBody extends $tea.Model {
  requestId?: string;
  result?: { [key: string]: boolean };
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: { 'type': 'map', 'keyType': 'string', 'valueType': 'boolean' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMicroAppViewResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMicroAppViewResponseBody;
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
      body: QueryMicroAppViewResponseBody,
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
  /**
   * @example
   * 部门id
   */
  deptId?: number;
  inCategoryIds?: string[];
  inPositionIds?: string[];
  /**
   * @example
   * 职位名称
   */
  positionName?: string;
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

export class RevokeSignRecordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevokeSignRecordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  revokeUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  signRecordIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 撤销签署
   */
  statusRemark?: string;
  static names(): { [key: string]: string } {
    return {
      revokeUserId: 'revokeUserId',
      signRecordIds: 'signRecordIds',
      statusRemark: 'statusRemark',
    };
  }

  static types(): { [key: string]: any } {
    return {
      revokeUserId: 'string',
      signRecordIds: { 'type': 'array', 'itemType': 'string' },
      statusRemark: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevokeSignRecordsResponseBody extends $tea.Model {
  result?: RevokeSignRecordsResponseBodyResult;
  /**
   * @remarks
   * This parameter is required.
   */
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: RevokeSignRecordsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevokeSignRecordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RevokeSignRecordsResponseBody;
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
      body: RevokeSignRecordsResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1231
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sys05-contractType
   */
  fieldCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sys05
   */
  groupId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  labels?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * OPTIONS_ADD
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  agentId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  messageType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  receiverUserIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16690147049882572
   */
  sceneType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 同意转正
   */
  scope?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16690147049882572
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * training
   */
  category?: string;
  /**
   * @example
   * 时间戳
   */
  claimTime?: number;
  /**
   * @example
   * 这是一个新人培训任务
   */
  description?: string;
  /**
   * @example
   * 时间戳
   */
  finishTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fdagshfjhajl
   */
  outerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * running
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 新人学习任务
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * onboarding
   */
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
  /**
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
  /**
   * @example
   * 时间戳
   */
  claimTime?: number;
  /**
   * @example
   * 这是一个新人培训任务
   */
  description?: string;
  /**
   * @example
   * 时间戳
   */
  finishTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * fdagshfjhajl
   */
  outerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qweqweqwe
   */
  solutionInstanceId?: string;
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * running
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PERFORMANCE_TASK、TRAIN_TASK
   */
  taskType?: string;
  /**
   * @example
   * sdfasd2323sdaf
   */
  templateOuterId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 新人学习任务
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * onboarding
   */
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
  /**
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

export class SyncSolutionStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSolutionStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123456
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * start
   */
  solutionStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * onboarding_v2
   */
  solutionType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12
   */
  tenantId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      solutionStatus: 'solutionStatus',
      solutionType: 'solutionType',
      tenantId: 'tenantId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      solutionStatus: 'string',
      solutionType: 'string',
      tenantId: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncSolutionStatusResponseBody extends $tea.Model {
  /**
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

export class SyncSolutionStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncSolutionStatusResponseBody;
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
      body: SyncSolutionStatusResponseBody,
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
  /**
   * **if can be null:**
   * false
   */
  delete?: boolean;
  /**
   * @example
   * 培训、薪酬任务模版
   */
  des?: string;
  /**
   * @example
   * {\"key\":value}
   */
  ext?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 培训模版
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 23234
   */
  optUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 232332
   */
  outerId?: string;
  taskScopeVO?: SyncTaskTemplateRequestTaskScopeVO;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PERFORMANCE_TASK、TRAIN_TASK
   */
  taskType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * onboarding
   */
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

export class UpdateHrmLegalEntityNameHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityNameRequest extends $tea.Model {
  /**
   * @example
   * 57
   */
  dingTenantId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 公司2
   */
  legalEntityName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 公司1
   */
  originLegalEntityName?: string;
  static names(): { [key: string]: string } {
    return {
      dingTenantId: 'dingTenantId',
      legalEntityName: 'legalEntityName',
      originLegalEntityName: 'originLegalEntityName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingTenantId: 'number',
      legalEntityName: 'string',
      originLegalEntityName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityNameResponseBody extends $tea.Model {
  result?: UpdateHrmLegalEntityNameResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateHrmLegalEntityNameResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityNameResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateHrmLegalEntityNameResponseBody;
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
      body: UpdateHrmLegalEntityNameResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  /**
   * @example
   * 123
   */
  createUserId?: string;
  ext?: UpdateHrmLegalEntityWithoutNameRequestExt;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 公司1
   */
  legalEntityName?: string;
  /**
   * @example
   * 公1
   */
  legalEntityShortName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  legalEntityStatus?: number;
  /**
   * @example
   * 法人
   */
  legalPersonName?: string;
  /**
   * @example
   * 57
   */
  dingTenantId?: number;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createUserId: 'createUserId',
      ext: 'ext',
      legalEntityName: 'legalEntityName',
      legalEntityShortName: 'legalEntityShortName',
      legalEntityStatus: 'legalEntityStatus',
      legalPersonName: 'legalPersonName',
      dingTenantId: 'dingTenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createUserId: 'string',
      ext: UpdateHrmLegalEntityWithoutNameRequestExt,
      legalEntityName: 'string',
      legalEntityShortName: 'string',
      legalEntityStatus: 'number',
      legalPersonName: 'string',
      dingTenantId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameResponseBody extends $tea.Model {
  result?: UpdateHrmLegalEntityWithoutNameResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateHrmLegalEntityWithoutNameResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateHrmLegalEntityWithoutNameResponseBody;
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
      body: UpdateHrmLegalEntityWithoutNameResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmVersionRollBackStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmVersionRollBackStatusRequest extends $tea.Model {
  /**
   * @example
   * show
   */
  configValue?: string;
  /**
   * @example
   * 1231231232
   */
  optUserId?: string;
  static names(): { [key: string]: string } {
    return {
      configValue: 'configValue',
      optUserId: 'optUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      configValue: 'string',
      optUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmVersionRollBackStatusResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmVersionRollBackStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateHrmVersionRollBackStatusResponseBody;
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
      body: UpdateHrmVersionRollBackStatusResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  messageType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 16690147049882572
   */
  sceneType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 同意转正
   */
  scope?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class UploadAttachmentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadAttachmentRequest extends $tea.Model {
  /**
   * @example
   * @dsa8d87y7c8d8c
   */
  mediaId?: string;
  /**
   * @example
   * 16768800278994283
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadAttachmentResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadAttachmentResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UploadAttachmentResponseBody;
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
      body: UploadAttachmentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityRequestExtManageAddress extends $tea.Model {
  /**
   * @example
   * 110101
   */
  areaCode?: string;
  /**
   * @example
   * 东城区
   */
  areaName?: string;
  /**
   * @example
   * 123
   */
  cityCode?: string;
  /**
   * @example
   * 广州市
   */
  cityName?: string;
  /**
   * @example
   * 123
   */
  countryCode?: string;
  /**
   * @example
   * China
   */
  countryName?: string;
  /**
   * @example
   * 北京市东城区xx街道xx小区xx楼
   */
  detailAddress?: string;
  /**
   * @example
   * 1
   */
  globalAreaType?: string;
  /**
   * @example
   * 123
   */
  provinceCode?: string;
  /**
   * @example
   * 广东省
   */
  provinceName?: string;
  static names(): { [key: string]: string } {
    return {
      areaCode: 'areaCode',
      areaName: 'areaName',
      cityCode: 'cityCode',
      cityName: 'cityName',
      countryCode: 'countryCode',
      countryName: 'countryName',
      detailAddress: 'detailAddress',
      globalAreaType: 'globalAreaType',
      provinceCode: 'provinceCode',
      provinceName: 'provinceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      areaCode: 'string',
      areaName: 'string',
      cityCode: 'string',
      cityName: 'string',
      countryCode: 'string',
      countryName: 'string',
      detailAddress: 'string',
      globalAreaType: 'string',
      provinceCode: 'string',
      provinceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityRequestExtRegistrationAddress extends $tea.Model {
  /**
   * @example
   * 110101
   */
  areaCode?: string;
  /**
   * @example
   * 东城区
   */
  areaName?: string;
  /**
   * @example
   * 123
   */
  cityCode?: string;
  /**
   * @example
   * 广州市
   */
  cityName?: string;
  /**
   * @example
   * 123
   */
  countryCode?: string;
  /**
   * @example
   * China
   */
  countryName?: string;
  /**
   * @example
   * 北京市东城区xx街道xx小区xx楼
   */
  detailAddress?: string;
  /**
   * @example
   * 1
   */
  globalAreaType?: string;
  /**
   * @example
   * 123
   */
  provinceCode?: string;
  /**
   * @example
   * 广东省
   */
  provinceName?: string;
  static names(): { [key: string]: string } {
    return {
      areaCode: 'areaCode',
      areaName: 'areaName',
      cityCode: 'cityCode',
      cityName: 'cityName',
      countryCode: 'countryCode',
      countryName: 'countryName',
      detailAddress: 'detailAddress',
      globalAreaType: 'globalAreaType',
      provinceCode: 'provinceCode',
      provinceName: 'provinceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      areaCode: 'string',
      areaName: 'string',
      cityCode: 'string',
      cityName: 'string',
      countryCode: 'string',
      countryName: 'string',
      detailAddress: 'string',
      globalAreaType: 'string',
      provinceCode: 'string',
      provinceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityRequestExt extends $tea.Model {
  legalEntityEnName?: string;
  legalEntityEnShortName?: string;
  legalEntityType?: string;
  manageAddress?: AddHrmLegalEntityRequestExtManageAddress;
  registrationAddress?: AddHrmLegalEntityRequestExtRegistrationAddress;
  registrationDate?: number;
  unifiedSocialCreditCode?: string;
  /**
   * @example
   * 515200
   */
  zipCode?: string;
  static names(): { [key: string]: string } {
    return {
      legalEntityEnName: 'legalEntityEnName',
      legalEntityEnShortName: 'legalEntityEnShortName',
      legalEntityType: 'legalEntityType',
      manageAddress: 'manageAddress',
      registrationAddress: 'registrationAddress',
      registrationDate: 'registrationDate',
      unifiedSocialCreditCode: 'unifiedSocialCreditCode',
      zipCode: 'zipCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      legalEntityEnName: 'string',
      legalEntityEnShortName: 'string',
      legalEntityType: 'string',
      manageAddress: AddHrmLegalEntityRequestExtManageAddress,
      registrationAddress: AddHrmLegalEntityRequestExtRegistrationAddress,
      registrationDate: 'number',
      unifiedSocialCreditCode: 'string',
      zipCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmLegalEntityResponseBodyResult extends $tea.Model {
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @example
   * 2023-01-01
   */
  gmtCreate?: number;
  /**
   * @example
   * 2023-01-01
   */
  gmtModified?: number;
  /**
   * @example
   * 1234567
   */
  legalEntityId?: string;
  /**
   * @example
   * 公司1
   */
  legalEntityName?: string;
  /**
   * @example
   * 公1
   */
  legalEntityShortName?: string;
  /**
   * @example
   * 1
   */
  legalEntityStatus?: number;
  /**
   * @example
   * 法人
   */
  legalPersonName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      legalEntityId: 'legalEntityId',
      legalEntityName: 'legalEntityName',
      legalEntityShortName: 'legalEntityShortName',
      legalEntityStatus: 'legalEntityStatus',
      legalPersonName: 'legalPersonName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      legalEntityId: 'string',
      legalEntityName: 'string',
      legalEntityShortName: 'string',
      legalEntityStatus: 'number',
      legalPersonName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddHrmPreentryRequestGroupsSectionsEmpFieldVOList extends $tea.Model {
  /**
   * @example
   * sys01-birthTime
   */
  fieldCode?: string;
  /**
   * @example
   * 2020-10-10
   */
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
  /**
   * @example
   * 0
   */
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
  /**
   * @example
   * sys01
   */
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

export class CreateRecordRequestAttachmentList extends $tea.Model {
  /**
   * @example
   * attachment_profile
   */
  fieldCode?: string;
  /**
   * @example
   * 简历附件
   */
  fieldName?: string;
  /**
   * @example
   * DDAttachmentField
   */
  fieldType?: string;
  /**
   * @example
   * https://dt-staging-moka-public.oss-cn-zhangjiakou.aliyuncs.com/form/attachment/b32509e4a809cb4e18a72fc4aa75e655.pdf
   */
  fieldValue?: string;
  /**
   * @example
   * attachment
   */
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
      fieldValue: 'fieldValue',
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldType: 'string',
      fieldValue: 'string',
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRecordRequestFieldList extends $tea.Model {
  /**
   * @example
   * contract.contract_type
   */
  fieldCode?: string;
  /**
   * @example
   * 合同类型
   */
  fieldName?: string;
  /**
   * @example
   * DDSelectField
   */
  fieldType?: string;
  /**
   * @example
   * 劳动合同
   */
  fieldValue?: string;
  /**
   * @example
   * contract
   */
  groupId?: string;
  /**
   * @example
   * 劳动合同
   */
  optionId?: string;
  /**
   * @example
   * [{\"label\":\"劳动合同\",\"value\":\"劳动合同\"},{\"label\":\"保密协议\",\"value\":\"保密协议\"}]
   */
  options?: string;
  signRequired?: boolean;
  userCustomField?: boolean;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
      fieldValue: 'fieldValue',
      groupId: 'groupId',
      optionId: 'optionId',
      options: 'options',
      signRequired: 'signRequired',
      userCustomField: 'userCustomField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldType: 'string',
      fieldValue: 'string',
      groupId: 'string',
      optionId: 'string',
      options: 'string',
      signRequired: 'boolean',
      userCustomField: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRecordRequestGroupListFieldList extends $tea.Model {
  /**
   * @example
   * contract.contract_type
   */
  fieldCode?: string;
  /**
   * @example
   * 合同类型
   */
  fieldName?: string;
  /**
   * @example
   * DDSelectField
   */
  fieldType?: string;
  /**
   * @example
   * 劳动合同
   */
  fieldValue?: string;
  /**
   * @example
   * [{\"label\":\"劳动合同\",\"value\":\"劳动合同\"},{\"label\":\"培训协议\",\"value\":\"培训协议\"}]
   */
  options?: string;
  /**
   * @example
   * 劳动合同
   */
  optionId?: string;
  /**
   * @example
   * contract
   */
  groupId?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
      fieldValue: 'fieldValue',
      options: 'options',
      optionId: 'optionId',
      groupId: 'groupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      fieldName: 'string',
      fieldType: 'string',
      fieldValue: 'string',
      options: 'string',
      optionId: 'string',
      groupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRecordRequestGroupList extends $tea.Model {
  detailFlag?: boolean;
  fieldList?: CreateRecordRequestGroupListFieldList[][];
  /**
   * @example
   * family
   */
  groupId?: string;
  /**
   * @example
   * 家庭成员
   */
  groupName?: string;
  static names(): { [key: string]: string } {
    return {
      detailFlag: 'detailFlag',
      fieldList: 'fieldList',
      groupId: 'groupId',
      groupName: 'groupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detailFlag: 'boolean',
      fieldList: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': CreateRecordRequestGroupListFieldList } },
      groupId: 'string',
      groupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateRecordResponseBodyResult extends $tea.Model {
  details?: string;
  itemId?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      details: 'details',
      itemId: 'itemId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      details: 'string',
      itemId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList extends $tea.Model {
  /**
   * @example
   * 0
   */
  itemIndex?: number;
  /**
   * @example
   * 正式
   */
  label?: string;
  /**
   * @example
   * 3
   */
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
  /**
   * @example
   * sys01-employeeStatus
   */
  fieldCode?: string;
  /**
   * @example
   * 员工状态
   */
  fieldName?: string;
  fieldValueList?: GetEmployeeRosterByFieldResponseBodyResultFieldDataListFieldValueList[];
  /**
   * @example
   * sys01
   */
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
  /**
   * @example
   * ding20a11xxx
   */
  corpId?: string;
  fieldDataList?: GetEmployeeRosterByFieldResponseBodyResultFieldDataList[];
  unionId?: string;
  /**
   * @example
   * 042519
   */
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

export class GetFileTemplateListResponseBodyResultDataAttachmentList extends $tea.Model {
  /**
   * @example
   * 简历附件
   */
  desc?: string;
  /**
   * @example
   * attachment_profile
   */
  fieldCode?: string;
  /**
   * @example
   * 简历附件
   */
  fieldName?: string;
  /**
   * @example
   * DDAttachmentField
   */
  fieldType?: string;
  /**
   * @example
   * attachment
   */
  groupId?: string;
  signRequired?: boolean;
  userCustomField?: boolean;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
      groupId: 'groupId',
      signRequired: 'signRequired',
      userCustomField: 'userCustomField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      fieldCode: 'string',
      fieldName: 'string',
      fieldType: 'string',
      groupId: 'string',
      signRequired: 'boolean',
      userCustomField: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListResponseBodyResultDataFieldList extends $tea.Model {
  /**
   * @example
   * 真实姓名字段
   */
  desc?: string;
  /**
   * @example
   * esign_name
   */
  fieldCode?: string;
  /**
   * @example
   * 真实姓名
   */
  fieldName?: string;
  /**
   * @example
   * TextField
   */
  fieldType?: string;
  /**
   * @example
   * baseInfo
   */
  groupId?: string;
  signRequired?: boolean;
  userCustomField?: boolean;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
      groupId: 'groupId',
      signRequired: 'signRequired',
      userCustomField: 'userCustomField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      fieldCode: 'string',
      fieldName: 'string',
      fieldType: 'string',
      groupId: 'string',
      signRequired: 'boolean',
      userCustomField: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListResponseBodyResultDataGroupListFieldList extends $tea.Model {
  /**
   * @example
   * 家庭成员明细分组
   */
  desc?: string;
  /**
   * @example
   * family.member_name
   */
  fieldCode?: string;
  /**
   * @example
   * 成员姓名
   */
  fieldName?: string;
  /**
   * @example
   * TextField
   */
  fieldType?: string;
  /**
   * @example
   * family
   */
  groupId?: string;
  signRequired?: boolean;
  userCustomField?: boolean;
  static names(): { [key: string]: string } {
    return {
      desc: 'desc',
      fieldCode: 'fieldCode',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
      groupId: 'groupId',
      signRequired: 'signRequired',
      userCustomField: 'userCustomField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      desc: 'string',
      fieldCode: 'string',
      fieldName: 'string',
      fieldType: 'string',
      groupId: 'string',
      signRequired: 'boolean',
      userCustomField: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListResponseBodyResultDataGroupList extends $tea.Model {
  detailFlag?: boolean;
  fieldList?: GetFileTemplateListResponseBodyResultDataGroupListFieldList[];
  /**
   * @example
   * family
   */
  groupId?: string;
  /**
   * @example
   * 家庭成员
   */
  groupName?: string;
  static names(): { [key: string]: string } {
    return {
      detailFlag: 'detailFlag',
      fieldList: 'fieldList',
      groupId: 'groupId',
      groupName: 'groupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detailFlag: 'boolean',
      fieldList: { 'type': 'array', 'itemType': GetFileTemplateListResponseBodyResultDataGroupListFieldList },
      groupId: 'string',
      groupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListResponseBodyResultData extends $tea.Model {
  attachmentList?: GetFileTemplateListResponseBodyResultDataAttachmentList[];
  /**
   * @example
   * ding57935b18bfd13e9735c2f4657eb6378f
   */
  corpId?: string;
  fieldList?: GetFileTemplateListResponseBodyResultDataFieldList[];
  groupList?: GetFileTemplateListResponseBodyResultDataGroupList[];
  /**
   * @example
   * f3ed5402e3024febaed773b3ac19feb3
   */
  templateId?: string;
  templateInstName?: string;
  /**
   * @example
   * 劳动合同模板
   */
  templateName?: string;
  /**
   * @example
   * 1
   */
  templateSignStatus?: number;
  /**
   * @example
   * 1
   */
  templateStatus?: number;
  /**
   * @example
   * CONTRACT
   */
  templateType?: string;
  /**
   * @example
   * 合同模板
   */
  templateTypeName?: string;
  /**
   * @example
   * 24
   */
  tenantId?: number;
  static names(): { [key: string]: string } {
    return {
      attachmentList: 'attachmentList',
      corpId: 'corpId',
      fieldList: 'fieldList',
      groupList: 'groupList',
      templateId: 'templateId',
      templateInstName: 'templateInstName',
      templateName: 'templateName',
      templateSignStatus: 'templateSignStatus',
      templateStatus: 'templateStatus',
      templateType: 'templateType',
      templateTypeName: 'templateTypeName',
      tenantId: 'tenantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachmentList: { 'type': 'array', 'itemType': GetFileTemplateListResponseBodyResultDataAttachmentList },
      corpId: 'string',
      fieldList: { 'type': 'array', 'itemType': GetFileTemplateListResponseBodyResultDataFieldList },
      groupList: { 'type': 'array', 'itemType': GetFileTemplateListResponseBodyResultDataGroupList },
      templateId: 'string',
      templateInstName: 'string',
      templateName: 'string',
      templateSignStatus: 'number',
      templateStatus: 'number',
      templateType: 'string',
      templateTypeName: 'string',
      tenantId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileTemplateListResponseBodyResult extends $tea.Model {
  data?: GetFileTemplateListResponseBodyResultData[];
  /**
   * @remarks
   * This parameter is required.
   */
  hasMore?: boolean;
  /**
   * @example
   * 10
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetFileTemplateListResponseBodyResultData },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByIdResponseBodyResult extends $tea.Model {
  /**
   * @example
   * ding12345678
   */
  corpId?: string;
  /**
   * @example
   * 员工签署中
   */
  remark?: string;
  /**
   * @example
   * 1723534265000
   */
  signExpireTime?: number;
  /**
   * @example
   * xxxx-合同文件.pdf
   */
  signFileName?: string;
  /**
   * @example
   * 1723534265000
   */
  signFinishTime?: number;
  /**
   * @example
   * xxxx有限公司
   */
  signLegalEntityName?: string;
  /**
   * @example
   * 6fe06f57ab5a45078f3219be8fd829c6
   */
  signRecordId?: string;
  /**
   * @example
   * 1723534265000
   */
  signStartTime?: number;
  /**
   * @example
   * SIGNING
   */
  signStatus?: string;
  /**
   * @example
   * 签署中
   */
  signStatusRemarks?: string;
  /**
   * @example
   * CONTRACT
   */
  signTemplateType?: string;
  /**
   * @example
   * 400873120394
   */
  signUserId?: string;
  /**
   * @example
   * xiaoming
   */
  signUserName?: string;
  /**
   * @example
   * ON_LINE
   */
  signWay?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      remark: 'remark',
      signExpireTime: 'signExpireTime',
      signFileName: 'signFileName',
      signFinishTime: 'signFinishTime',
      signLegalEntityName: 'signLegalEntityName',
      signRecordId: 'signRecordId',
      signStartTime: 'signStartTime',
      signStatus: 'signStatus',
      signStatusRemarks: 'signStatusRemarks',
      signTemplateType: 'signTemplateType',
      signUserId: 'signUserId',
      signUserName: 'signUserName',
      signWay: 'signWay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      remark: 'string',
      signExpireTime: 'number',
      signFileName: 'string',
      signFinishTime: 'number',
      signLegalEntityName: 'string',
      signRecordId: 'string',
      signStartTime: 'number',
      signStatus: 'string',
      signStatusRemarks: 'string',
      signTemplateType: 'string',
      signUserId: 'string',
      signUserName: 'string',
      signWay: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByUserIdResponseBodyResultData extends $tea.Model {
  /**
   * @example
   * ding57935b18bfd13e9735c2f4657eb6378f
   */
  corpId?: string;
  /**
   * @example
   * 劳动合同电子签签署备注
   */
  remark?: string;
  /**
   * @example
   * 1720775436000
   */
  signExpireTime?: number;
  /**
   * @example
   * 小明-劳动合同-20240808.pdf
   */
  signFileName?: string;
  /**
   * @example
   * https://n.dingtalk.com/xxx
   */
  signFileUrl?: string;
  /**
   * @example
   * 1720775436000
   */
  signFinishTime?: number;
  /**
   * @example
   * xxx有限公司
   */
  signLegalEntityName?: string;
  /**
   * @example
   * 38bc7b69bb6a46b8a69b9001d5c0bdf3
   */
  signRecordId?: string;
  /**
   * @example
   * 1720775436000
   */
  signStartTime?: number;
  /**
   * @example
   * FINISHED
   */
  signStatus?: string;
  /**
   * @example
   * 法人公司未开通
   */
  signStatusRemarks?: string;
  /**
   * @example
   * CONTRACT
   */
  signTemplateType?: string;
  /**
   * @example
   * 660658
   */
  signUserId?: string;
  /**
   * @example
   * 小明
   */
  signUserName?: string;
  /**
   * @example
   * ON_LINE
   */
  signWay?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      remark: 'remark',
      signExpireTime: 'signExpireTime',
      signFileName: 'signFileName',
      signFileUrl: 'signFileUrl',
      signFinishTime: 'signFinishTime',
      signLegalEntityName: 'signLegalEntityName',
      signRecordId: 'signRecordId',
      signStartTime: 'signStartTime',
      signStatus: 'signStatus',
      signStatusRemarks: 'signStatusRemarks',
      signTemplateType: 'signTemplateType',
      signUserId: 'signUserId',
      signUserName: 'signUserName',
      signWay: 'signWay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      remark: 'string',
      signExpireTime: 'number',
      signFileName: 'string',
      signFileUrl: 'string',
      signFinishTime: 'number',
      signLegalEntityName: 'string',
      signRecordId: 'string',
      signStartTime: 'number',
      signStatus: 'string',
      signStatusRemarks: 'string',
      signTemplateType: 'string',
      signUserId: 'string',
      signUserName: 'string',
      signWay: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignRecordByUserIdResponseBodyResult extends $tea.Model {
  data?: GetSignRecordByUserIdResponseBodyResultData[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetSignRecordByUserIdResponseBodyResultData },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmAuthResourcesQueryResponseBodyResult extends $tea.Model {
  authorized?: boolean;
  /**
   * @example
   * /signSetting/manage/*
   */
  resourceId?: string;
  static names(): { [key: string]: string } {
    return {
      authorized: 'authorized',
      resourceId: 'resourceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorized: 'boolean',
      resourceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HrmMailSendRequestMailAttachments extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试.pdf
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @asdc12312
   */
  path?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * media
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 还有10分钟开始
   */
  alarmDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  alarmMinutes?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc@aaa.com
   */
  address?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 参会人1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc@aaa.com
   */
  address?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 系统
   */
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
  /**
   * @example
   * 会议描述
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1701692590881
   */
  endTime?: number;
  /**
   * @example
   * 会议室
   */
  location?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * REQUEST
   */
  method?: string;
  organizer?: HrmMailSendRequestMailMeetingOrganizer;
  /**
   * @example
   * 1
   */
  sequence?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1701692590881
   */
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试会议
   */
  summary?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * uuidssssss
   */
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
  /**
   * @example
   * abd@aaa.com,bcd@aaa.com,
   */
  bccAddress?: string;
  /**
   * @example
   * abd@aaa.com,bcd@aaa.com,
   */
  ccAddress?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 请及时填写请填写入职登记表
   */
  content?: string;
  meeting?: HrmMailSendRequestMailMeeting;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abd@aaa.com,bcd@aaa.com,
   */
  receiverAddress?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 智能人事入职
   */
  senderAlias?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 请填写入职登记表
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * biz222ddd
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hrm
   */
  mailAccountType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * tokenabcd
   */
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

export class InvalidSignRecordsResponseBodyResultFailItems extends $tea.Model {
  /**
   * @example
   * 1234566789
   */
  itemId?: string;
  /**
   * @example
   * 电子签状态变更不合法
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvalidSignRecordsResponseBodyResultSuccessItems extends $tea.Model {
  /**
   * @example
   * 123456789
   */
  itemId?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InvalidSignRecordsResponseBodyResult extends $tea.Model {
  failItems?: InvalidSignRecordsResponseBodyResultFailItems[];
  successItems?: InvalidSignRecordsResponseBodyResultSuccessItems[];
  static names(): { [key: string]: string } {
    return {
      failItems: 'failItems',
      successItems: 'successItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failItems: { 'type': 'array', 'itemType': InvalidSignRecordsResponseBodyResultFailItems },
      successItems: { 'type': 'array', 'itemType': InvalidSignRecordsResponseBodyResultSuccessItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDataDeleteRequestBodyFieldList extends $tea.Model {
  /**
   * @example
   * name
   */
  name?: string;
  /**
   * @example
   * 123
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * performance
   */
  scopeCode?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12312
   */
  bizTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * uk123
   */
  bizUk?: string;
  /**
   * @example
   * base
   */
  entityCode?: string;
  fieldList?: MasterDataDeleteRequestBodyFieldList[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * uk123
   */
  bizUK?: string;
  /**
   * @example
   * S0005
   */
  errorCode?: string;
  /**
   * @example
   * 主键冲突
   */
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
  /**
   * @example
   * EQUAL
   */
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
  /**
   * @example
   * performance_code
   */
  fieldCode?: string;
  /**
   * @example
   * AND
   */
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
  /**
   * @example
   * 100
   */
  key?: string;
  /**
   * @example
   * 100
   */
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
  /**
   * @example
   * performanceValue
   */
  fieldCode?: string;
  fieldDataVO?: MasterDataQueryResponseBodyResultViewEntityFieldVOListFieldDataVO;
  /**
   * @example
   * 绩效等级
   */
  fieldName?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * uk123123
   */
  outerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * admind123
   */
  relationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PERFORMANCE
   */
  scopeCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * base
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * name
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * performance
   */
  scopeCode?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12312
   */
  bizTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * uk123
   */
  bizUk?: string;
  /**
   * @example
   * base
   */
  entityCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldList?: MasterDataSaveRequestBodyFieldList[];
  /**
   * @remarks
   * This parameter is required.
   */
  scope?: MasterDataSaveRequestBodyScope;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user123
   */
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
  /**
   * @example
   * uk123
   */
  bizUk?: string;
  /**
   * @example
   * S0005
   */
  errorCode?: string;
  /**
   * @example
   * 主键冲突
   */
  errorMsg?: string;
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * true
   */
  hasData?: boolean;
  /**
   * @example
   * true
   */
  integrateDataAuth?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * "智能绩效"
   */
  name?: string;
  /**
   * @example
   * true
   */
  readAuth?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4
   */
  tenantId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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

export class MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO extends $tea.Model {
  /**
   * @example
   * 100
   */
  key?: string;
  /**
   * @example
   * 100
   */
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

export class MasterDatasGetResponseBodyResultViewEntityFieldVOList extends $tea.Model {
  /**
   * @example
   * performanceValue
   */
  fieldCode?: string;
  fieldDataVO?: MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO;
  /**
   * @example
   * 绩效等级
   */
  fieldName?: string;
  /**
   * @example
   * 1
   */
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
      fieldDataVO: MasterDatasGetResponseBodyResultViewEntityFieldVOListFieldDataVO,
      fieldName: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasGetResponseBodyResult extends $tea.Model {
  /**
   * @example
   * uk123123
   */
  objId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * admind123
   */
  relationId?: string;
  /**
   * @example
   * PERFORMANCE
   */
  scopeCode?: string;
  /**
   * @example
   * base
   */
  viewEntityCode?: string;
  viewEntityFieldVOList?: MasterDatasGetResponseBodyResultViewEntityFieldVOList[];
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
      viewEntityFieldVOList: { 'type': 'array', 'itemType': MasterDatasGetResponseBodyResultViewEntityFieldVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class MasterDatasQueryRequestQueryParamsConditionList extends $tea.Model {
  /**
   * @example
   * EQUAL
   */
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
  /**
   * @example
   * performance_code
   */
  fieldCode?: string;
  /**
   * @example
   * AND
   */
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
  /**
   * @example
   * 100
   */
  key?: string;
  /**
   * @example
   * 100
   */
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
  /**
   * @example
   * performanceValue
   */
  fieldCode?: string;
  fieldDataVO?: MasterDatasQueryResponseBodyResultViewEntityFieldVOListFieldDataVO;
  /**
   * @example
   * 绩效等级
   */
  fieldName?: string;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * uk123123
   */
  objId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * admind123
   */
  relationId?: string;
  /**
   * @example
   * PERFORMANCE
   */
  scopeCode?: string;
  /**
   * @example
   * base
   */
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
  /**
   * @example
   * 30
   */
  maxJobGrade?: number;
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 职务描述
   */
  jobDescription?: string;
  /**
   * @example
   * ac67286db74c48e28d787173ccc1a111
   */
  jobId?: string;
  /**
   * @example
   * 总裁
   */
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
  /**
   * @example
   * ac67286db74c48e28d787173ccc1a111
   */
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

export class RevokeSignRecordsResponseBodyResultFailItems extends $tea.Model {
  /**
   * @example
   * 6fe06f57ab5a45078f3219be8fd829c6
   */
  itemId?: string;
  /**
   * @example
   * 电子签状态变更不合法
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevokeSignRecordsResponseBodyResultSuccessItems extends $tea.Model {
  /**
   * @example
   * 6fe06f57ab5a45078f3219be8fd829c6
   */
  itemId?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RevokeSignRecordsResponseBodyResult extends $tea.Model {
  failItems?: RevokeSignRecordsResponseBodyResultFailItems[];
  successItems?: RevokeSignRecordsResponseBodyResultSuccessItems[];
  static names(): { [key: string]: string } {
    return {
      failItems: 'failItems',
      successItems: 'successItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failItems: { 'type': 'array', 'itemType': RevokeSignRecordsResponseBodyResultFailItems },
      successItems: { 'type': 'array', 'itemType': RevokeSignRecordsResponseBodyResultSuccessItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RosterMetaAvailableFieldListResponseBodyResult extends $tea.Model {
  /**
   * @example
   * sys01-employeeType
   */
  fieldCode?: string;
  /**
   * @example
   * 员工类型
   */
  fieldName?: string;
  /**
   * @example
   * DDSelectField
   */
  fieldType?: string;
  /**
   * @example
   * [{"value":"1","label":"男"},{"value":"2","label":"女"}]
   */
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

export class UpdateHrmLegalEntityNameResponseBodyResult extends $tea.Model {
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @example
   * 2023-08-08
   */
  gmtCreate?: number;
  /**
   * @example
   * 2023-08-08
   */
  gmtModified?: number;
  /**
   * @example
   * 111233
   */
  legalEntityId?: string;
  /**
   * @example
   * 公司2
   */
  legalEntityName?: string;
  /**
   * @example
   * 公2
   */
  legalEntityShortName?: string;
  /**
   * @example
   * 1
   */
  legalEntityStatus?: number;
  /**
   * @example
   * 法人1
   */
  legalPersonName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      legalEntityId: 'legalEntityId',
      legalEntityName: 'legalEntityName',
      legalEntityShortName: 'legalEntityShortName',
      legalEntityStatus: 'legalEntityStatus',
      legalPersonName: 'legalPersonName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      legalEntityId: 'string',
      legalEntityName: 'string',
      legalEntityShortName: 'string',
      legalEntityStatus: 'number',
      legalPersonName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameRequestExtManageAddress extends $tea.Model {
  /**
   * @example
   * 110101
   */
  areaCode?: string;
  /**
   * @example
   * 东城区
   */
  areaName?: string;
  /**
   * @example
   * 1234
   */
  cityCode?: string;
  /**
   * @example
   * 广州
   */
  cityName?: string;
  /**
   * @example
   * 123
   */
  countryCode?: string;
  /**
   * @example
   * China
   */
  countryName?: string;
  /**
   * @example
   * 北京市东城区xx街道xx小区xx楼
   */
  detailAddress?: string;
  /**
   * @example
   * 1
   */
  globalAreaType?: string;
  /**
   * @example
   * 123
   */
  provinceCode?: string;
  /**
   * @example
   * 广东
   */
  provinceName?: string;
  static names(): { [key: string]: string } {
    return {
      areaCode: 'areaCode',
      areaName: 'areaName',
      cityCode: 'cityCode',
      cityName: 'cityName',
      countryCode: 'countryCode',
      countryName: 'countryName',
      detailAddress: 'detailAddress',
      globalAreaType: 'globalAreaType',
      provinceCode: 'provinceCode',
      provinceName: 'provinceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      areaCode: 'string',
      areaName: 'string',
      cityCode: 'string',
      cityName: 'string',
      countryCode: 'string',
      countryName: 'string',
      detailAddress: 'string',
      globalAreaType: 'string',
      provinceCode: 'string',
      provinceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress extends $tea.Model {
  /**
   * @example
   * 110101
   */
  areaCode?: string;
  /**
   * @example
   * 东城区
   */
  areaName?: string;
  /**
   * @example
   * 1234
   */
  cityCode?: string;
  /**
   * @example
   * 广州
   */
  cityName?: string;
  /**
   * @example
   * 123
   */
  countryCode?: string;
  /**
   * @example
   * China
   */
  countryName?: string;
  /**
   * @example
   * 北京市东城区xx街道xx小区xx楼
   */
  detailAddress?: string;
  /**
   * @example
   * 1
   */
  globalAreaType?: string;
  /**
   * @example
   * 123
   */
  provinceCode?: string;
  /**
   * @example
   * 广东
   */
  provinceName?: string;
  static names(): { [key: string]: string } {
    return {
      areaCode: 'areaCode',
      areaName: 'areaName',
      cityCode: 'cityCode',
      cityName: 'cityName',
      countryCode: 'countryCode',
      countryName: 'countryName',
      detailAddress: 'detailAddress',
      globalAreaType: 'globalAreaType',
      provinceCode: 'provinceCode',
      provinceName: 'provinceName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      areaCode: 'string',
      areaName: 'string',
      cityCode: 'string',
      cityName: 'string',
      countryCode: 'string',
      countryName: 'string',
      detailAddress: 'string',
      globalAreaType: 'string',
      provinceCode: 'string',
      provinceName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameRequestExt extends $tea.Model {
  /**
   * @example
   * company
   */
  legalEntityEnName?: string;
  /**
   * @example
   * com
   */
  legalEntityEnShortName?: string;
  /**
   * @example
   * whollyOwned
   */
  legalEntityType?: string;
  manageAddress?: UpdateHrmLegalEntityWithoutNameRequestExtManageAddress;
  registrationAddress?: UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress;
  /**
   * @example
   * 2023-01-01
   */
  registrationDate?: number;
  /**
   * @example
   * 123456
   */
  unifiedSocialCreditCode?: string;
  /**
   * @example
   * 515200
   */
  zipCode?: string;
  static names(): { [key: string]: string } {
    return {
      legalEntityEnName: 'legalEntityEnName',
      legalEntityEnShortName: 'legalEntityEnShortName',
      legalEntityType: 'legalEntityType',
      manageAddress: 'manageAddress',
      registrationAddress: 'registrationAddress',
      registrationDate: 'registrationDate',
      unifiedSocialCreditCode: 'unifiedSocialCreditCode',
      zipCode: 'zipCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      legalEntityEnName: 'string',
      legalEntityEnShortName: 'string',
      legalEntityType: 'string',
      manageAddress: UpdateHrmLegalEntityWithoutNameRequestExtManageAddress,
      registrationAddress: UpdateHrmLegalEntityWithoutNameRequestExtRegistrationAddress,
      registrationDate: 'number',
      unifiedSocialCreditCode: 'string',
      zipCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHrmLegalEntityWithoutNameResponseBodyResult extends $tea.Model {
  /**
   * @example
   * ding123
   */
  corpId?: string;
  /**
   * @example
   * 2023-01-01
   */
  gmtCreate?: number;
  /**
   * @example
   * 2023-01-01
   */
  gmtModified?: number;
  /**
   * @example
   * 123456
   */
  legalEntityId?: string;
  /**
   * @example
   * 公司1
   */
  legalEntityName?: string;
  /**
   * @example
   * 公1
   */
  legalEntityShortName?: string;
  /**
   * @example
   * 1
   */
  legalEntityStatus?: number;
  /**
   * @example
   * 法人
   */
  legalPersonName?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      legalEntityId: 'legalEntityId',
      legalEntityName: 'legalEntityName',
      legalEntityShortName: 'legalEntityShortName',
      legalEntityStatus: 'legalEntityStatus',
      legalPersonName: 'legalPersonName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      gmtCreate: 'number',
      gmtModified: 'number',
      legalEntityId: 'string',
      legalEntityName: 'string',
      legalEntityShortName: 'string',
      legalEntityStatus: 'number',
      legalPersonName: 'string',
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
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 新增法人公司
   * 
   * @param request - AddHrmLegalEntityRequest
   * @param headers - AddHrmLegalEntityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddHrmLegalEntityResponse
   */
  async addHrmLegalEntityWithOptions(request: AddHrmLegalEntityRequest, headers: AddHrmLegalEntityHeaders, runtime: $Util.RuntimeOptions): Promise<AddHrmLegalEntityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingTenantId)) {
      query["dingTenantId"] = request.dingTenantId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.createUserId)) {
      body["createUserId"] = request.createUserId;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.legalEntityName)) {
      body["legalEntityName"] = request.legalEntityName;
    }

    if (!Util.isUnset(request.legalEntityShortName)) {
      body["legalEntityShortName"] = request.legalEntityShortName;
    }

    if (!Util.isUnset(request.legalEntityStatus)) {
      body["legalEntityStatus"] = request.legalEntityStatus;
    }

    if (!Util.isUnset(request.legalPersonName)) {
      body["legalPersonName"] = request.legalPersonName;
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
      action: "AddHrmLegalEntity",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/legalEntities/companies`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddHrmLegalEntityResponse>(await this.execute(params, req, runtime), new AddHrmLegalEntityResponse({}));
  }

  /**
   * 新增法人公司
   * 
   * @param request - AddHrmLegalEntityRequest
   * @returns AddHrmLegalEntityResponse
   */
  async addHrmLegalEntity(request: AddHrmLegalEntityRequest): Promise<AddHrmLegalEntityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddHrmLegalEntityHeaders({ });
    return await this.addHrmLegalEntityWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
   * 
   * @param request - AddHrmPreentryRequest
   * @param headers - AddHrmPreentryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddHrmPreentryResponse
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
   * 智能人事添加待入职员工信息(支持花名册数据和分组明细更新)
   * 
   * @param request - AddHrmPreentryRequest
   * @returns AddHrmPreentryResponse
   */
  async addHrmPreentry(request: AddHrmPreentryRequest): Promise<AddHrmPreentryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddHrmPreentryHeaders({ });
    return await this.addHrmPreentryWithOptions(request, headers, runtime);
  }

  /**
   * 创建电子签签署记录
   * 
   * @param request - CreateRecordRequest
   * @param headers - CreateRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateRecordResponse
   */
  async createRecordWithOptions(request: CreateRecordRequest, headers: CreateRecordHeaders, runtime: $Util.RuntimeOptions): Promise<CreateRecordResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attachmentList)) {
      body["attachmentList"] = request.attachmentList;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.fieldList)) {
      body["fieldList"] = request.fieldList;
    }

    if (!Util.isUnset(request.groupList)) {
      body["groupList"] = request.groupList;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.signLastLegalEntityName)) {
      body["signLastLegalEntityName"] = request.signLastLegalEntityName;
    }

    if (!Util.isUnset(request.signLegalEntityName)) {
      body["signLegalEntityName"] = request.signLegalEntityName;
    }

    if (!Util.isUnset(request.signSource)) {
      body["signSource"] = request.signSource;
    }

    if (!Util.isUnset(request.signStartUserId)) {
      body["signStartUserId"] = request.signStartUserId;
    }

    if (!Util.isUnset(request.signUserId)) {
      body["signUserId"] = request.signUserId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
      action: "CreateRecord",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/signCenters/records`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateRecordResponse>(await this.execute(params, req, runtime), new CreateRecordResponse({}));
  }

  /**
   * 创建电子签签署记录
   * 
   * @param request - CreateRecordRequest
   * @returns CreateRecordResponse
   */
  async createRecord(request: CreateRecordRequest): Promise<CreateRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateRecordHeaders({ });
    return await this.createRecordWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事设备市场管理
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeviceMarketManagerResponse
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
   * 智能人事设备市场管理
   * @returns DeviceMarketManagerResponse
   */
  async deviceMarketManager(): Promise<DeviceMarketManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.deviceMarketManagerWithOptions(headers, runtime);
  }

  /**
   * 智能人事设备定向管理接口
   * 
   * @param headers - map
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeviceMarketOrderManagerResponse
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
   * 智能人事设备定向管理接口
   * @returns DeviceMarketOrderManagerResponse
   */
  async deviceMarketOrderManager(): Promise<DeviceMarketOrderManagerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.deviceMarketOrderManagerWithOptions(headers, runtime);
  }

  /**
   * e签宝专有查询证件接口
   * 
   * @param request - ECertQueryRequest
   * @param headers - ECertQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ECertQueryResponse
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
   * e签宝专有查询证件接口
   * 
   * @param request - ECertQueryRequest
   * @returns ECertQueryResponse
   */
  async eCertQuery(request: ECertQueryRequest): Promise<ECertQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ECertQueryHeaders({ });
    return await this.eCertQueryWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事员工档案附件更新
   * 
   * @param request - EmployeeAttachmentUpdateRequest
   * @param headers - EmployeeAttachmentUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EmployeeAttachmentUpdateResponse
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
   * 智能人事员工档案附件更新
   * 
   * @param request - EmployeeAttachmentUpdateRequest
   * @returns EmployeeAttachmentUpdateResponse
   */
  async employeeAttachmentUpdate(request: EmployeeAttachmentUpdateRequest): Promise<EmployeeAttachmentUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EmployeeAttachmentUpdateHeaders({ });
    return await this.employeeAttachmentUpdateWithOptions(request, headers, runtime);
  }

  /**
   * 人事高级合同管理回退
   * 
   * @param request - EsignRollbackRequest
   * @param headers - EsignRollbackHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EsignRollbackResponse
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
   * 人事高级合同管理回退
   * 
   * @param request - EsignRollbackRequest
   * @returns EsignRollbackResponse
   */
  async esignRollback(request: EsignRollbackRequest): Promise<EsignRollbackResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EsignRollbackHeaders({ });
    return await this.esignRollbackWithOptions(request, headers, runtime);
  }

  /**
   * 获取员工花名册指定字段的信息，支持明细分组字段
   * 
   * @param request - GetEmployeeRosterByFieldRequest
   * @param headers - GetEmployeeRosterByFieldHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetEmployeeRosterByFieldResponse
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
   * 获取员工花名册指定字段的信息，支持明细分组字段
   * 
   * @param request - GetEmployeeRosterByFieldRequest
   * @returns GetEmployeeRosterByFieldResponse
   */
  async getEmployeeRosterByField(request: GetEmployeeRosterByFieldRequest): Promise<GetEmployeeRosterByFieldResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEmployeeRosterByFieldHeaders({ });
    return await this.getEmployeeRosterByFieldWithOptions(request, headers, runtime);
  }

  /**
   * 查询文件模板列表及文件模板内花名册字段
   * 
   * @param request - GetFileTemplateListRequest
   * @param headers - GetFileTemplateListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFileTemplateListResponse
   */
  async getFileTemplateListWithOptions(request: GetFileTemplateListRequest, headers: GetFileTemplateListHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileTemplateListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.signSource)) {
      body["signSource"] = request.signSource;
    }

    if (!Util.isUnset(request.templateStatus)) {
      body["templateStatus"] = request.templateStatus;
    }

    if (!Util.isUnset(request.templateTypeList)) {
      body["templateTypeList"] = request.templateTypeList;
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
      action: "GetFileTemplateList",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/fileTemplates/lists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFileTemplateListResponse>(await this.execute(params, req, runtime), new GetFileTemplateListResponse({}));
  }

  /**
   * 查询文件模板列表及文件模板内花名册字段
   * 
   * @param request - GetFileTemplateListRequest
   * @returns GetFileTemplateListResponse
   */
  async getFileTemplateList(request: GetFileTemplateListRequest): Promise<GetFileTemplateListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileTemplateListHeaders({ });
    return await this.getFileTemplateListWithOptions(request, headers, runtime);
  }

  /**
   * 通过签署记录id查询指定的电子签署记录
   * 
   * @param request - GetSignRecordByIdRequest
   * @param headers - GetSignRecordByIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignRecordByIdResponse
   */
  async getSignRecordByIdWithOptions(request: GetSignRecordByIdRequest, headers: GetSignRecordByIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignRecordByIdResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "GetSignRecordById",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/signCenters/records/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSignRecordByIdResponse>(await this.execute(params, req, runtime), new GetSignRecordByIdResponse({}));
  }

  /**
   * 通过签署记录id查询指定的电子签署记录
   * 
   * @param request - GetSignRecordByIdRequest
   * @returns GetSignRecordByIdResponse
   */
  async getSignRecordById(request: GetSignRecordByIdRequest): Promise<GetSignRecordByIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignRecordByIdHeaders({ });
    return await this.getSignRecordByIdWithOptions(request, headers, runtime);
  }

  /**
   * 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
   * 
   * @param request - GetSignRecordByUserIdRequest
   * @param headers - GetSignRecordByUserIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignRecordByUserIdResponse
   */
  async getSignRecordByUserIdWithOptions(request: GetSignRecordByUserIdRequest, headers: GetSignRecordByUserIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignRecordByUserIdResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.signStatus)) {
      body["signStatus"] = request.signStatus;
    }

    if (!Util.isUnset(request.signUserId)) {
      body["signUserId"] = request.signUserId;
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
      action: "GetSignRecordByUserId",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/signCenters/users/records/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSignRecordByUserIdResponse>(await this.execute(params, req, runtime), new GetSignRecordByUserIdResponse({}));
  }

  /**
   * 查询指定用户的电子签署记录，并返回签署记录的基本数据及已签署完成的文件预览地址
   * 
   * @param request - GetSignRecordByUserIdRequest
   * @returns GetSignRecordByUserIdResponse
   */
  async getSignRecordByUserId(request: GetSignRecordByUserIdRequest): Promise<GetSignRecordByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignRecordByUserIdHeaders({ });
    return await this.getSignRecordByUserIdWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事权限查询
   * 
   * @param request - HrmAuthResourcesQueryRequest
   * @param headers - HrmAuthResourcesQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmAuthResourcesQueryResponse
   */
  async hrmAuthResourcesQueryWithOptions(request: HrmAuthResourcesQueryRequest, headers: HrmAuthResourcesQueryHeaders, runtime: $Util.RuntimeOptions): Promise<HrmAuthResourcesQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authResourceIds)) {
      body["authResourceIds"] = request.authResourceIds;
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
      action: "HrmAuthResourcesQuery",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/authResources/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmAuthResourcesQueryResponse>(await this.execute(params, req, runtime), new HrmAuthResourcesQueryResponse({}));
  }

  /**
   * 智能人事权限查询
   * 
   * @param request - HrmAuthResourcesQueryRequest
   * @returns HrmAuthResourcesQueryResponse
   */
  async hrmAuthResourcesQuery(request: HrmAuthResourcesQueryRequest): Promise<HrmAuthResourcesQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmAuthResourcesQueryHeaders({ });
    return await this.hrmAuthResourcesQueryWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事权益查询
   * 
   * @param request - HrmBenefitQueryRequest
   * @param headers - HrmBenefitQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmBenefitQueryResponse
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
   * 智能人事权益查询
   * 
   * @param request - HrmBenefitQueryRequest
   * @returns HrmBenefitQueryResponse
   */
  async hrmBenefitQuery(request: HrmBenefitQueryRequest): Promise<HrmBenefitQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmBenefitQueryHeaders({ });
    return await this.hrmBenefitQueryWithOptions(request, headers, runtime);
  }

  /**
   * 查询企业配置信息
   * 
   * @param request - HrmCorpConfigQueryRequest
   * @param headers - HrmCorpConfigQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmCorpConfigQueryResponse
   */
  async hrmCorpConfigQueryWithOptions(request: HrmCorpConfigQueryRequest, headers: HrmCorpConfigQueryHeaders, runtime: $Util.RuntimeOptions): Promise<HrmCorpConfigQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subType)) {
      body["subType"] = request.subType;
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
      action: "HrmCorpConfigQuery",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/corp/configs/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmCorpConfigQueryResponse>(await this.execute(params, req, runtime), new HrmCorpConfigQueryResponse({}));
  }

  /**
   * 查询企业配置信息
   * 
   * @param request - HrmCorpConfigQueryRequest
   * @returns HrmCorpConfigQueryResponse
   */
  async hrmCorpConfigQuery(request: HrmCorpConfigQueryRequest): Promise<HrmCorpConfigQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmCorpConfigQueryHeaders({ });
    return await this.hrmCorpConfigQueryWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事邮件发送
   * 
   * @param request - HrmMailSendRequest
   * @param headers - HrmMailSendHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmMailSendResponse
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
   * 智能人事邮件发送
   * 
   * @param request - HrmMailSendRequest
   * @returns HrmMailSendResponse
   */
  async hrmMailSend(request: HrmMailSendRequest): Promise<HrmMailSendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmMailSendHeaders({ });
    return await this.hrmMailSendWithOptions(request, headers, runtime);
  }

  /**
   * 人事2.0支持Moka事件转发
   * 
   * @param request - HrmMokaEventRequest
   * @param headers - HrmMokaEventHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmMokaEventResponse
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
   * 人事2.0支持Moka事件转发
   * 
   * @param request - HrmMokaEventRequest
   * @returns HrmMokaEventResponse
   */
  async hrmMokaEvent(request: HrmMokaEventRequest): Promise<HrmMokaEventResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmMokaEventHeaders({ });
    return await this.hrmMokaEventWithOptions(request, headers, runtime);
  }

  /**
   * 人事2.0支持Moka接口转发
   * 
   * @param request - HrmMokaOapiRequest
   * @param headers - HrmMokaOapiHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmMokaOapiResponse
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
   * 人事2.0支持Moka接口转发
   * 
   * @param request - HrmMokaOapiRequest
   * @returns HrmMokaOapiResponse
   */
  async hrmMokaOapi(request: HrmMokaOapiRequest): Promise<HrmMokaOapiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmMokaOapiHeaders({ });
    return await this.hrmMokaOapiWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事转正接口
   * 
   * @param request - HrmProcessRegularRequest
   * @param headers - HrmProcessRegularHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmProcessRegularResponse
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
   * 智能人事转正接口
   * 
   * @param request - HrmProcessRegularRequest
   * @returns HrmProcessRegularResponse
   */
  async hrmProcessRegular(request: HrmProcessRegularRequest): Promise<HrmProcessRegularResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessRegularHeaders({ });
    return await this.hrmProcessRegularWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事离职和交接接口
   * 
   * @param request - HrmProcessTerminationAndHandoverRequest
   * @param headers - HrmProcessTerminationAndHandoverHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmProcessTerminationAndHandoverResponse
   */
  async hrmProcessTerminationAndHandoverWithOptions(request: HrmProcessTerminationAndHandoverRequest, headers: HrmProcessTerminationAndHandoverHeaders, runtime: $Util.RuntimeOptions): Promise<HrmProcessTerminationAndHandoverResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.aflowHandOverUserId)) {
      body["aflowHandOverUserId"] = request.aflowHandOverUserId;
    }

    if (!Util.isUnset(request.dingPanHandoverUserId)) {
      body["dingPanHandoverUserId"] = request.dingPanHandoverUserId;
    }

    if (!Util.isUnset(request.directSubordinatesHandoverUserId)) {
      body["directSubordinatesHandoverUserId"] = request.directSubordinatesHandoverUserId;
    }

    if (!Util.isUnset(request.dismissionMemo)) {
      body["dismissionMemo"] = request.dismissionMemo;
    }

    if (!Util.isUnset(request.dismissionReason)) {
      body["dismissionReason"] = request.dismissionReason;
    }

    if (!Util.isUnset(request.docNoteHandoverUserId)) {
      body["docNoteHandoverUserId"] = request.docNoteHandoverUserId;
    }

    if (!Util.isUnset(request.lastWorkDate)) {
      body["lastWorkDate"] = request.lastWorkDate;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
    }

    if (!Util.isUnset(request.permissionHandoverUserId)) {
      body["permissionHandoverUserId"] = request.permissionHandoverUserId;
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
      action: "HrmProcessTerminationAndHandover",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/processes/terminateAndHandOver`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<HrmProcessTerminationAndHandoverResponse>(await this.execute(params, req, runtime), new HrmProcessTerminationAndHandoverResponse({}));
  }

  /**
   * 智能人事离职和交接接口
   * 
   * @param request - HrmProcessTerminationAndHandoverRequest
   * @returns HrmProcessTerminationAndHandoverResponse
   */
  async hrmProcessTerminationAndHandover(request: HrmProcessTerminationAndHandoverRequest): Promise<HrmProcessTerminationAndHandoverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessTerminationAndHandoverHeaders({ });
    return await this.hrmProcessTerminationAndHandoverWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事调岗接口
   * 
   * @param request - HrmProcessTransferRequest
   * @param headers - HrmProcessTransferHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmProcessTransferResponse
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
   * 智能人事调岗接口
   * 
   * @param request - HrmProcessTransferRequest
   * @returns HrmProcessTransferResponse
   */
  async hrmProcessTransfer(request: HrmProcessTransferRequest): Promise<HrmProcessTransferResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessTransferHeaders({ });
    return await this.hrmProcessTransferWithOptions(request, headers, runtime);
  }

  /**
   * 修改员工最后一次离职信息
   * 
   * @param request - HrmProcessUpdateTerminationInfoRequest
   * @param headers - HrmProcessUpdateTerminationInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmProcessUpdateTerminationInfoResponse
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
   * 修改员工最后一次离职信息
   * 
   * @param request - HrmProcessUpdateTerminationInfoRequest
   * @returns HrmProcessUpdateTerminationInfoResponse
   */
  async hrmProcessUpdateTerminationInfo(request: HrmProcessUpdateTerminationInfoRequest): Promise<HrmProcessUpdateTerminationInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmProcessUpdateTerminationInfoHeaders({ });
    return await this.hrmProcessUpdateTerminationInfoWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事pts能力调用
   * 
   * @param request - HrmPtsServiceRequest
   * @param headers - HrmPtsServiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns HrmPtsServiceResponse
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
   * 智能人事pts能力调用
   * 
   * @param request - HrmPtsServiceRequest
   * @returns HrmPtsServiceResponse
   */
  async hrmPtsService(request: HrmPtsServiceRequest): Promise<HrmPtsServiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HrmPtsServiceHeaders({ });
    return await this.hrmPtsServiceWithOptions(request, headers, runtime);
  }

  /**
   * 作废签署记录
   * 
   * @param request - InvalidSignRecordsRequest
   * @param headers - InvalidSignRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InvalidSignRecordsResponse
   */
  async invalidSignRecordsWithOptions(request: InvalidSignRecordsRequest, headers: InvalidSignRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<InvalidSignRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.invalidUserId)) {
      body["invalidUserId"] = request.invalidUserId;
    }

    if (!Util.isUnset(request.signRecordIds)) {
      body["signRecordIds"] = request.signRecordIds;
    }

    if (!Util.isUnset(request.statusRemark)) {
      body["statusRemark"] = request.statusRemark;
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
      action: "InvalidSignRecords",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/signCenters/records/invalid`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InvalidSignRecordsResponse>(await this.execute(params, req, runtime), new InvalidSignRecordsResponse({}));
  }

  /**
   * 作废签署记录
   * 
   * @param request - InvalidSignRecordsRequest
   * @returns InvalidSignRecordsResponse
   */
  async invalidSignRecords(request: InvalidSignRecordsRequest): Promise<InvalidSignRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InvalidSignRecordsHeaders({ });
    return await this.invalidSignRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事主数据删除服务
   * 
   * @param request - MasterDataDeleteRequest
   * @param headers - MasterDataDeleteHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MasterDataDeleteResponse
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
   * 智能人事主数据删除服务
   * 
   * @param request - MasterDataDeleteRequest
   * @returns MasterDataDeleteResponse
   */
  async masterDataDelete(request: MasterDataDeleteRequest): Promise<MasterDataDeleteResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataDeleteHeaders({ });
    return await this.masterDataDeleteWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事主数据查询服务
   * 
   * @param request - MasterDataQueryRequest
   * @param headers - MasterDataQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MasterDataQueryResponse
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
   * 智能人事主数据查询服务
   * 
   * @param request - MasterDataQueryRequest
   * @returns MasterDataQueryResponse
   */
  async masterDataQuery(request: MasterDataQueryRequest): Promise<MasterDataQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataQueryHeaders({ });
    return await this.masterDataQueryWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事主数据保存服务
   * 
   * @param request - MasterDataSaveRequest
   * @param headers - MasterDataSaveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MasterDataSaveResponse
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
   * 智能人事主数据保存服务
   * 
   * @param request - MasterDataSaveRequest
   * @returns MasterDataSaveResponse
   */
  async masterDataSave(request: MasterDataSaveRequest): Promise<MasterDataSaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataSaveHeaders({ });
    return await this.masterDataSaveWithOptions(request, headers, runtime);
  }

  /**
   * 主数据中拥有某个领域数据的租户信息查询
   * 
   * @param request - MasterDataTenantQueyRequest
   * @param headers - MasterDataTenantQueyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MasterDataTenantQueyResponse
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
   * 主数据中拥有某个领域数据的租户信息查询
   * 
   * @param request - MasterDataTenantQueyRequest
   * @returns MasterDataTenantQueyResponse
   */
  async masterDataTenantQuey(request: MasterDataTenantQueyRequest): Promise<MasterDataTenantQueyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDataTenantQueyHeaders({ });
    return await this.masterDataTenantQueyWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事主数据根据ID获取
   * 
   * @param request - MasterDatasGetRequest
   * @param headers - MasterDatasGetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MasterDatasGetResponse
   */
  async masterDatasGetWithOptions(request: MasterDatasGetRequest, headers: MasterDatasGetHeaders, runtime: $Util.RuntimeOptions): Promise<MasterDatasGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.objId)) {
      body["objId"] = request.objId;
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
      action: "MasterDatasGet",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masterDatas/objects/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<MasterDatasGetResponse>(await this.execute(params, req, runtime), new MasterDatasGetResponse({}));
  }

  /**
   * 智能人事主数据根据ID获取
   * 
   * @param request - MasterDatasGetRequest
   * @returns MasterDatasGetResponse
   */
  async masterDatasGet(request: MasterDatasGetRequest): Promise<MasterDatasGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDatasGetHeaders({ });
    return await this.masterDatasGetWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事主数据查询服务
   * 
   * @param request - MasterDatasQueryRequest
   * @param headers - MasterDatasQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns MasterDatasQueryResponse
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
   * 智能人事主数据查询服务
   * 
   * @param request - MasterDatasQueryRequest
   * @returns MasterDatasQueryResponse
   */
  async masterDatasQuery(request: MasterDatasQueryRequest): Promise<MasterDatasQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new MasterDatasQueryHeaders({ });
    return await this.masterDatasQueryWithOptions(request, headers, runtime);
  }

  /**
   * oem 老用户数据迁移时，开通oem 应用
   * 
   * @param request - OpenOemMicroAppRequest
   * @param headers - OpenOemMicroAppHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenOemMicroAppResponse
   */
  async openOemMicroAppWithOptions(request: OpenOemMicroAppRequest, headers: OpenOemMicroAppHeaders, runtime: $Util.RuntimeOptions): Promise<OpenOemMicroAppResponse> {
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
    });
    let params = new $OpenApi.Params({
      action: "OpenOemMicroApp",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/oem/microApps/open`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenOemMicroAppResponse>(await this.execute(params, req, runtime), new OpenOemMicroAppResponse({}));
  }

  /**
   * oem 老用户数据迁移时，开通oem 应用
   * 
   * @param request - OpenOemMicroAppRequest
   * @returns OpenOemMicroAppResponse
   */
  async openOemMicroApp(request: OpenOemMicroAppRequest): Promise<OpenOemMicroAppResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenOemMicroAppHeaders({ });
    return await this.openOemMicroAppWithOptions(request, headers, runtime);
  }

  /**
   * 自定义入职流程数据查询
   * 
   * @param request - QueryCustomEntryProcessesRequest
   * @param headers - QueryCustomEntryProcessesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCustomEntryProcessesResponse
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
   * 自定义入职流程数据查询
   * 
   * @param request - QueryCustomEntryProcessesRequest
   * @returns QueryCustomEntryProcessesResponse
   */
  async queryCustomEntryProcesses(request: QueryCustomEntryProcessesRequest): Promise<QueryCustomEntryProcessesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomEntryProcessesHeaders({ });
    return await this.queryCustomEntryProcessesWithOptions(request, headers, runtime);
  }

  /**
   * 查询企业已离职员工列表
   * 
   * @param request - QueryDismissionStaffIdListRequest
   * @param headers - QueryDismissionStaffIdListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDismissionStaffIdListResponse
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
   * 查询企业已离职员工列表
   * 
   * @param request - QueryDismissionStaffIdListRequest
   * @returns QueryDismissionStaffIdListResponse
   */
  async queryDismissionStaffIdList(request: QueryDismissionStaffIdListRequest): Promise<QueryDismissionStaffIdListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDismissionStaffIdListHeaders({ });
    return await this.queryDismissionStaffIdListWithOptions(request, headers, runtime);
  }

  /**
   * 根据传入的staffId列表，批量查询员工的离职信息
   * 
   * @param tmpReq - QueryHrmEmployeeDismissionInfoRequest
   * @param headers - QueryHrmEmployeeDismissionInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryHrmEmployeeDismissionInfoResponse
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
   * 根据传入的staffId列表，批量查询员工的离职信息
   * 
   * @param request - QueryHrmEmployeeDismissionInfoRequest
   * @returns QueryHrmEmployeeDismissionInfoResponse
   */
  async queryHrmEmployeeDismissionInfo(request: QueryHrmEmployeeDismissionInfoRequest): Promise<QueryHrmEmployeeDismissionInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHrmEmployeeDismissionInfoHeaders({ });
    return await this.queryHrmEmployeeDismissionInfoWithOptions(request, headers, runtime);
  }

  /**
   * 分页查询企业的职级信息
   * 
   * @param request - QueryJobRanksRequest
   * @param headers - QueryJobRanksHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryJobRanksResponse
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
   * 分页查询企业的职级信息
   * 
   * @param request - QueryJobRanksRequest
   * @returns QueryJobRanksResponse
   */
  async queryJobRanks(request: QueryJobRanksRequest): Promise<QueryJobRanksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobRanksHeaders({ });
    return await this.queryJobRanksWithOptions(request, headers, runtime);
  }

  /**
   * 分页查询企业职务信息
   * 
   * @param request - QueryJobsRequest
   * @param headers - QueryJobsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryJobsResponse
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
   * 分页查询企业职务信息
   * 
   * @param request - QueryJobsRequest
   * @returns QueryJobsResponse
   */
  async queryJobs(request: QueryJobsRequest): Promise<QueryJobsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryJobsHeaders({ });
    return await this.queryJobsWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事查询微应用状态
   * 
   * @param request - QueryMicroAppStatusRequest
   * @param headers - QueryMicroAppStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMicroAppStatusResponse
   */
  async queryMicroAppStatusWithOptions(request: QueryMicroAppStatusRequest, headers: QueryMicroAppStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMicroAppStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantIdList)) {
      body["tenantIdList"] = request.tenantIdList;
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
      action: "QueryMicroAppStatus",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/microApps/statuses/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMicroAppStatusResponse>(await this.execute(params, req, runtime), new QueryMicroAppStatusResponse({}));
  }

  /**
   * 智能人事查询微应用状态
   * 
   * @param request - QueryMicroAppStatusRequest
   * @returns QueryMicroAppStatusResponse
   */
  async queryMicroAppStatus(request: QueryMicroAppStatusRequest): Promise<QueryMicroAppStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMicroAppStatusHeaders({ });
    return await this.queryMicroAppStatusWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事查询微应用可见性
   * 
   * @param request - QueryMicroAppViewRequest
   * @param headers - QueryMicroAppViewHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMicroAppViewResponse
   */
  async queryMicroAppViewWithOptions(request: QueryMicroAppViewRequest, headers: QueryMicroAppViewHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMicroAppViewResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.tenantIdList)) {
      body["tenantIdList"] = request.tenantIdList;
    }

    if (!Util.isUnset(request.viewUserId)) {
      body["viewUserId"] = request.viewUserId;
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
      action: "QueryMicroAppView",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/microApps/visibilities/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMicroAppViewResponse>(await this.execute(params, req, runtime), new QueryMicroAppViewResponse({}));
  }

  /**
   * 智能人事查询微应用可见性
   * 
   * @param request - QueryMicroAppViewRequest
   * @returns QueryMicroAppViewResponse
   */
  async queryMicroAppView(request: QueryMicroAppViewRequest): Promise<QueryMicroAppViewResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMicroAppViewHeaders({ });
    return await this.queryMicroAppViewWithOptions(request, headers, runtime);
  }

  /**
   * 分页查询企业职位信息
   * 
   * @param request - QueryPositionsRequest
   * @param headers - QueryPositionsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryPositionsResponse
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
   * 分页查询企业职位信息
   * 
   * @param request - QueryPositionsRequest
   * @returns QueryPositionsResponse
   */
  async queryPositions(request: QueryPositionsRequest): Promise<QueryPositionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPositionsHeaders({ });
    return await this.queryPositionsWithOptions(request, headers, runtime);
  }

  /**
   * 撤回电子签署中的签署记录
   * 
   * @param request - RevokeSignRecordsRequest
   * @param headers - RevokeSignRecordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RevokeSignRecordsResponse
   */
  async revokeSignRecordsWithOptions(request: RevokeSignRecordsRequest, headers: RevokeSignRecordsHeaders, runtime: $Util.RuntimeOptions): Promise<RevokeSignRecordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.revokeUserId)) {
      body["revokeUserId"] = request.revokeUserId;
    }

    if (!Util.isUnset(request.signRecordIds)) {
      body["signRecordIds"] = request.signRecordIds;
    }

    if (!Util.isUnset(request.statusRemark)) {
      body["statusRemark"] = request.statusRemark;
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
      action: "RevokeSignRecords",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/signCenters/records/revoke`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RevokeSignRecordsResponse>(await this.execute(params, req, runtime), new RevokeSignRecordsResponse({}));
  }

  /**
   * 撤回电子签署中的签署记录
   * 
   * @param request - RevokeSignRecordsRequest
   * @returns RevokeSignRecordsResponse
   */
  async revokeSignRecords(request: RevokeSignRecordsRequest): Promise<RevokeSignRecordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RevokeSignRecordsHeaders({ });
    return await this.revokeSignRecordsWithOptions(request, headers, runtime);
  }

  /**
   * 查询花名册中有权限的字段列表
   * 
   * @param request - RosterMetaAvailableFieldListRequest
   * @param headers - RosterMetaAvailableFieldListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RosterMetaAvailableFieldListResponse
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
   * 查询花名册中有权限的字段列表
   * 
   * @param request - RosterMetaAvailableFieldListRequest
   * @returns RosterMetaAvailableFieldListResponse
   */
  async rosterMetaAvailableFieldList(request: RosterMetaAvailableFieldListRequest): Promise<RosterMetaAvailableFieldListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RosterMetaAvailableFieldListHeaders({ });
    return await this.rosterMetaAvailableFieldListWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事花名册字段选项修改
   * 
   * @param request - RosterMetaFieldOptionsUpdateRequest
   * @param headers - RosterMetaFieldOptionsUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RosterMetaFieldOptionsUpdateResponse
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
   * 智能人事花名册字段选项修改
   * 
   * @param request - RosterMetaFieldOptionsUpdateRequest
   * @returns RosterMetaFieldOptionsUpdateResponse
   */
  async rosterMetaFieldOptionsUpdate(request: RosterMetaFieldOptionsUpdateRequest): Promise<RosterMetaFieldOptionsUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RosterMetaFieldOptionsUpdateHeaders({ });
    return await this.rosterMetaFieldOptionsUpdateWithOptions(request, headers, runtime);
  }

  /**
   * ISV发送卡片消息
   * 
   * @param request - SendIsvCardMessageRequest
   * @param headers - SendIsvCardMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendIsvCardMessageResponse
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
   * ISV发送卡片消息
   * 
   * @param request - SendIsvCardMessageRequest
   * @returns SendIsvCardMessageResponse
   */
  async sendIsvCardMessage(request: SendIsvCardMessageRequest): Promise<SendIsvCardMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendIsvCardMessageHeaders({ });
    return await this.sendIsvCardMessageWithOptions(request, headers, runtime);
  }

  /**
   * 初始化解决方案任务
   * 
   * @param request - SolutionTaskInitRequest
   * @param headers - SolutionTaskInitHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SolutionTaskInitResponse
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
   * 初始化解决方案任务
   * 
   * @param request - SolutionTaskInitRequest
   * @returns SolutionTaskInitResponse
   */
  async solutionTaskInit(request: SolutionTaskInitRequest): Promise<SolutionTaskInitResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SolutionTaskInitHeaders({ });
    return await this.solutionTaskInitWithOptions(request, headers, runtime);
  }

  /**
   * 保存解决方案任务
   * 
   * @param request - SolutionTaskSaveRequest
   * @param headers - SolutionTaskSaveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SolutionTaskSaveResponse
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
   * 保存解决方案任务
   * 
   * @param request - SolutionTaskSaveRequest
   * @returns SolutionTaskSaveResponse
   */
  async solutionTaskSave(request: SolutionTaskSaveRequest): Promise<SolutionTaskSaveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SolutionTaskSaveHeaders({ });
    return await this.solutionTaskSaveWithOptions(request, headers, runtime);
  }

  /**
   * 同步解决方案状态
   * 
   * @param request - SyncSolutionStatusRequest
   * @param headers - SyncSolutionStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncSolutionStatusResponse
   */
  async syncSolutionStatusWithOptions(request: SyncSolutionStatusRequest, headers: SyncSolutionStatusHeaders, runtime: $Util.RuntimeOptions): Promise<SyncSolutionStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.solutionStatus)) {
      body["solutionStatus"] = request.solutionStatus;
    }

    if (!Util.isUnset(request.solutionType)) {
      body["solutionType"] = request.solutionType;
    }

    if (!Util.isUnset(request.tenantId)) {
      body["tenantId"] = request.tenantId;
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
      action: "SyncSolutionStatus",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/solutions/statuses/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncSolutionStatusResponse>(await this.execute(params, req, runtime), new SyncSolutionStatusResponse({}));
  }

  /**
   * 同步解决方案状态
   * 
   * @param request - SyncSolutionStatusRequest
   * @returns SyncSolutionStatusResponse
   */
  async syncSolutionStatus(request: SyncSolutionStatusRequest): Promise<SyncSolutionStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncSolutionStatusHeaders({ });
    return await this.syncSolutionStatusWithOptions(request, headers, runtime);
  }

  /**
   * 同步解决方案任务模版
   * 
   * @param request - SyncTaskTemplateRequest
   * @param headers - SyncTaskTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncTaskTemplateResponse
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
   * 同步解决方案任务模版
   * 
   * @param request - SyncTaskTemplateRequest
   * @returns SyncTaskTemplateResponse
   */
  async syncTaskTemplate(request: SyncTaskTemplateRequest): Promise<SyncTaskTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncTaskTemplateHeaders({ });
    return await this.syncTaskTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 更新法人公司名称
   * 
   * @param request - UpdateHrmLegalEntityNameRequest
   * @param headers - UpdateHrmLegalEntityNameHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateHrmLegalEntityNameResponse
   */
  async updateHrmLegalEntityNameWithOptions(request: UpdateHrmLegalEntityNameRequest, headers: UpdateHrmLegalEntityNameHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateHrmLegalEntityNameResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingTenantId)) {
      query["dingTenantId"] = request.dingTenantId;
    }

    if (!Util.isUnset(request.legalEntityName)) {
      query["legalEntityName"] = request.legalEntityName;
    }

    if (!Util.isUnset(request.originLegalEntityName)) {
      query["originLegalEntityName"] = request.originLegalEntityName;
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
      action: "UpdateHrmLegalEntityName",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/legalEntities/companyNames`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateHrmLegalEntityNameResponse>(await this.execute(params, req, runtime), new UpdateHrmLegalEntityNameResponse({}));
  }

  /**
   * 更新法人公司名称
   * 
   * @param request - UpdateHrmLegalEntityNameRequest
   * @returns UpdateHrmLegalEntityNameResponse
   */
  async updateHrmLegalEntityName(request: UpdateHrmLegalEntityNameRequest): Promise<UpdateHrmLegalEntityNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateHrmLegalEntityNameHeaders({ });
    return await this.updateHrmLegalEntityNameWithOptions(request, headers, runtime);
  }

  /**
   * 更新法人公司
   * 
   * @param request - UpdateHrmLegalEntityWithoutNameRequest
   * @param headers - UpdateHrmLegalEntityWithoutNameHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateHrmLegalEntityWithoutNameResponse
   */
  async updateHrmLegalEntityWithoutNameWithOptions(request: UpdateHrmLegalEntityWithoutNameRequest, headers: UpdateHrmLegalEntityWithoutNameHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateHrmLegalEntityWithoutNameResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingTenantId)) {
      query["dingTenantId"] = request.dingTenantId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.createUserId)) {
      body["createUserId"] = request.createUserId;
    }

    if (!Util.isUnset(request.ext)) {
      body["ext"] = request.ext;
    }

    if (!Util.isUnset(request.legalEntityName)) {
      body["legalEntityName"] = request.legalEntityName;
    }

    if (!Util.isUnset(request.legalEntityShortName)) {
      body["legalEntityShortName"] = request.legalEntityShortName;
    }

    if (!Util.isUnset(request.legalEntityStatus)) {
      body["legalEntityStatus"] = request.legalEntityStatus;
    }

    if (!Util.isUnset(request.legalPersonName)) {
      body["legalPersonName"] = request.legalPersonName;
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
      action: "UpdateHrmLegalEntityWithoutName",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/masters/legalEntities/companies`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateHrmLegalEntityWithoutNameResponse>(await this.execute(params, req, runtime), new UpdateHrmLegalEntityWithoutNameResponse({}));
  }

  /**
   * 更新法人公司
   * 
   * @param request - UpdateHrmLegalEntityWithoutNameRequest
   * @returns UpdateHrmLegalEntityWithoutNameResponse
   */
  async updateHrmLegalEntityWithoutName(request: UpdateHrmLegalEntityWithoutNameRequest): Promise<UpdateHrmLegalEntityWithoutNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateHrmLegalEntityWithoutNameHeaders({ });
    return await this.updateHrmLegalEntityWithoutNameWithOptions(request, headers, runtime);
  }

  /**
   * 智能人事更新版本回退按钮状态
   * 
   * @param request - UpdateHrmVersionRollBackStatusRequest
   * @param headers - UpdateHrmVersionRollBackStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateHrmVersionRollBackStatusResponse
   */
  async updateHrmVersionRollBackStatusWithOptions(request: UpdateHrmVersionRollBackStatusRequest, headers: UpdateHrmVersionRollBackStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateHrmVersionRollBackStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.configValue)) {
      body["configValue"] = request.configValue;
    }

    if (!Util.isUnset(request.optUserId)) {
      body["optUserId"] = request.optUserId;
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
      action: "UpdateHrmVersionRollBackStatus",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/versions/rollbackButtons/statuses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateHrmVersionRollBackStatusResponse>(await this.execute(params, req, runtime), new UpdateHrmVersionRollBackStatusResponse({}));
  }

  /**
   * 智能人事更新版本回退按钮状态
   * 
   * @param request - UpdateHrmVersionRollBackStatusRequest
   * @returns UpdateHrmVersionRollBackStatusResponse
   */
  async updateHrmVersionRollBackStatus(request: UpdateHrmVersionRollBackStatusRequest): Promise<UpdateHrmVersionRollBackStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateHrmVersionRollBackStatusHeaders({ });
    return await this.updateHrmVersionRollBackStatusWithOptions(request, headers, runtime);
  }

  /**
   * ISV更新卡片消息
   * 
   * @param request - UpdateIsvCardMessageRequest
   * @param headers - UpdateIsvCardMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateIsvCardMessageResponse
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
   * ISV更新卡片消息
   * 
   * @param request - UpdateIsvCardMessageRequest
   * @returns UpdateIsvCardMessageResponse
   */
  async updateIsvCardMessage(request: UpdateIsvCardMessageRequest): Promise<UpdateIsvCardMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateIsvCardMessageHeaders({ });
    return await this.updateIsvCardMessageWithOptions(request, headers, runtime);
  }

  /**
   * 上传附件材料
   * 
   * @param request - UploadAttachmentRequest
   * @param headers - UploadAttachmentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UploadAttachmentResponse
   */
  async uploadAttachmentWithOptions(request: UploadAttachmentRequest, headers: UploadAttachmentHeaders, runtime: $Util.RuntimeOptions): Promise<UploadAttachmentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UploadAttachment",
      version: "hrm_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/hrm/attachments/upload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadAttachmentResponse>(await this.execute(params, req, runtime), new UploadAttachmentResponse({}));
  }

  /**
   * 上传附件材料
   * 
   * @param request - UploadAttachmentRequest
   * @returns UploadAttachmentResponse
   */
  async uploadAttachment(request: UploadAttachmentRequest): Promise<UploadAttachmentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadAttachmentHeaders({ });
    return await this.uploadAttachmentWithOptions(request, headers, runtime);
  }

}
