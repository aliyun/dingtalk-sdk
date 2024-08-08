// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CloseDataDeliverHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseDataDeliverRequest extends $tea.Model {
  /**
   * @example
   * DELIVER-3e1a2d2f-fa76-45e8-XXXX-7fd29307c859
   */
  deliverId?: string;
  /**
   * @example
   * RT
   */
  dispatchingItemType?: string;
  static names(): { [key: string]: string } {
    return {
      deliverId: 'deliverId',
      dispatchingItemType: 'dispatchingItemType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deliverId: 'string',
      dispatchingItemType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseDataDeliverResponseBody extends $tea.Model {
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

export class CloseDataDeliverResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CloseDataDeliverResponseBody;
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
      body: CloseDataDeliverResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDataDeliverHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDataDeliverRequest extends $tea.Model {
  bizcode?: string;
  param?: string;
  userId?: string;
  dispatchingCycle?: string;
  dispatchingItemType?: string;
  dispatchingStartDate?: number;
  static names(): { [key: string]: string } {
    return {
      bizcode: 'bizcode',
      param: 'param',
      userId: 'userId',
      dispatchingCycle: 'dispatchingCycle',
      dispatchingItemType: 'dispatchingItemType',
      dispatchingStartDate: 'dispatchingStartDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizcode: 'string',
      param: 'string',
      userId: 'string',
      dispatchingCycle: 'string',
      dispatchingItemType: 'string',
      dispatchingStartDate: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDataDeliverResponseBody extends $tea.Model {
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

export class CreateDataDeliverResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateDataDeliverResponseBody;
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
      body: CreateDataDeliverResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScreenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScreenRequest extends $tea.Model {
  operatorId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateScreenResponseBody extends $tea.Model {
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

export class CreateScreenResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateScreenResponseBody;
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
      body: CreateScreenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAbnormalOperationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAbnormalOperationRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAbnormalOperationResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "DEPARTMENT": "xx",       "IN_REASON": "xx",       "OUT_DATE": "2006-12-07",       "OUT_DEPARTMENT": "xx",       "IN_DATE": "2006-12-07",       "OUT_REASON": "xx"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAbnormalOperationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAbnormalOperationResponseBody;
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
      body: GetAbnormalOperationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "LicenseNo": "梯4403331978",       "StartDate": "2022-05-10",       "Department": "深圳市市场监督管理局",       "Content": "注册代码:7;设备种类:电梯",       "LicenseName": "特种设备使用登记",       "EndDate": "2099-12-31"     },     {       "LicenseNo": "东水务审﹝2021﹞8267号",       "StartDate": "2021-06-11",       "Department": "东莞市水务局",       "Content": "水土保持方案审批准予行政许可决定",       "LicenseName": "",       "EndDate": "2026-12-31"     } ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativeLicensingResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAdministrativeLicensingResponseBody;
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
      body: GetAdministrativeLicensingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "DATE_COL": "xx",       "NUMBER": "xx",       "ILLEGAL_TYPE": "xx",       "DEPARTMENT": "xx",       "PUBLIC_DATE": "xx",       "CONTENT": "xx",       "BASED_ON":"xx",       "DESCRIPTION":"xx"      }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAdministrativePenaltiesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAdministrativePenaltiesResponseBody;
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
      body: GetAdministrativePenaltiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "ENT_NAME": "xx",       "LEGAL_NAME": "xx",       "ES_DATE": "2006-12-07",       "ENT_STATUS": "在营",       "REG_CAP": "1000万人民币",       "REC_CAP": "1000万人民币",       "SOCIAL_CREDIT_CODE": "91330108793696828A",       "LICENSE_NUMBER": "330108000000965",       "ORG_NO": "793696828",       "TAX_NUM": "91330108793696828A",       "ENT_TYPE": "有限责任公司(非自然人投资或控股的法人独资)",       "INDUSTRY_NAME_LV1": "租赁和商务服务业",       "INDUSTRY_NAME_LV2": "商务服务业",       "OP_FROM": "2006-12-07",       "OP_TO": "2036-12-06",       "COLLEGUES_NUM": "6",       "ENT_NAME_ENG": "Hangzhou Ali Baba Advertising Co.,Ltd.",       "FORMER_NAMES": "xx",       "REG_ORG": "xx",       "REG_ORG_PROVINCE": "浙江省",       "REG_ORG_CITY": "杭州市",       "REG_ORG_DISTRICT": "滨江区",       "STD_REG_CAP": 10000000     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBasicInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetBasicInfoResponseBody;
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
      body: GetBasicInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [{ "EntName":"企业名称", "BidTitle":"标文标题", "BidType":"招标方式", "RegionName":"地区", "BidIndustry":"标的所属行业", "PublicDate":"发布时间", "ProjectNum":"项目编号", "ProjectName":"项目名称", "ProjectAmount":"项目金额", "TenderEntName":"招标企业", "AgentEntName":"代理企业", "WinnerEntName":"中标企业", "Content":"正文", "InfoType":"标文类型", "SubType":"子类型", "OpeningTime":"开标时间" }]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBiddingInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetBiddingInfoResponseBody;
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
      body: GetBiddingInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "OperName": "李柯",       "EntStatus": "",       "EntName": "华为技术有限公司驻广州办事处",       "EsDate": ""     },     {       "OperName": "李实",       "EntStatus": "",       "EntName": "华为技术有限公司重庆分公司",       "EsDate": ""     } ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBranchInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetBranchInfoResponseBody;
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
      body: GetBranchInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordResponseBody extends $tea.Model {
  /**
   * @example
   * [         {             "Type":"投资人变更(包括出资额、出资方式、出资日期、投资人名称等)",             "ChangeDate":"2014-12-23",             "AfterContent":"股东名称:华为投资控股有限公司、出资额:3990813.182000、出资比例:100.000000;",             "BeforeContent":"股东名称:华为投资控股有限公司、出资额:3960813.182000、出资比例:100.000000;"         },         {             "Type":"期限变更(经营期限、营业期限、驻在期限、合伙期限等变更)",             "ChangeDate":"1997-12-04",             "AfterContent":"1987-09-15,2040-04-09",             "BeforeContent":"1987-09-15,1998-12-31"         } ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetChangeRecordResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetChangeRecordResponseBody;
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
      body: GetChangeRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataDeliverHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataDeliverRequest extends $tea.Model {
  /**
   * @example
   * DELIVER-3e1a2d2f-fa76-45e8-XXXX-7fd29307c859
   */
  deliverId?: string;
  /**
   * @example
   * RT
   */
  dispatchingItemType?: string;
  static names(): { [key: string]: string } {
    return {
      deliverId: 'deliverId',
      dispatchingItemType: 'dispatchingItemType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deliverId: 'string',
      dispatchingItemType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDataDeliverResponseBody extends $tea.Model {
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

export class GetDataDeliverResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDataDeliverResponseBody;
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
      body: GetDataDeliverResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [{ "EntName":"企业名称" "Number":"备案号" "Domain":"域名" "SiteName":"网站名称" "HomeUrl":"网站首页链接" "CheckDate":"备案日期" }]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDomainInfoResponseBody;
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
      body: GetDomainInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "InspectPlanId": "44030020191021",       "InspectTypeName": "定向",       "InspectPlanName": "2019能效标识生产企业计量监督抽查1",       "InspectItem": "",       "InspectResult": "",       "InspectDepartment": "深圳市市场监督管理局龙岗局",       "InspectDate": "2019-10-14",       "InspectTaskId": "44030020191021",       "InspectTaskName": "2019能效标识生产企业计量监督抽查1"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDoubleRandomResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDoubleRandomResponseBody;
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
      body: GetDoubleRandomResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "DEPARTMENT": "xx",       "ENT_NAME": "xx",       "EXEC_STATUS": "xx",       "PUNISH_BASIS": "xx",       "PUNISH_CONTENT": "xx",       "PUNISH_LAW": "xx",       "PUNISH_NUM": "xx",       "PUNISH_RES": "xx",       "PUNISH_DATE": "xx"      }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEnvironmentalPenaltiesResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetEnvironmentalPenaltiesResponseBody;
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
      body: GetEnvironmentalPenaltiesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventDataRequest extends $tea.Model {
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 819e50d7c32e9096
   */
  eventUid?: string;
  subId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      eventUid: 'eventUid',
      subId: 'subId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      eventUid: 'string',
      subId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventDataResponseBody extends $tea.Model {
  success?: string;
  value?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'string',
      value: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetEventDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetEventDataResponseBody;
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
      body: GetEventDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "STOCK_TYPE": "企业法人",       "STOCK_NAME": "xxx",       "STOCK_PERCENT": "100.00%",       "SHOULD_CAPI": "1000.0",       "SHOULD_CAPI_TIME": "2007-09-28"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetHolderInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetHolderInfoResponseBody;
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
      body: GetHolderInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "Status": "有效",       "Type": "专利",       "Pledgor": "齐风莲",       "Number": "91611024MA70X17M7E",       "Period": "2015年06月11日至2015年06月11日",       "PublicDate": "2015-06-18 00:00:00",       "Pawnee": "齐风莲",       "entName": "东兰县鸿发摩托车安全技术检验有限公司"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntellectualPropertyResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetIntellectualPropertyResponseBody;
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
      body: GetIntellectualPropertyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "InvestLicenseNo": "440301104818958",       "InvestStatus": "在营",       "InvestEsDate": "1998-11-25",       "InvestCreditCode": "914403007084643962",       "ShouldCap": "2000.0万人民币",       "EntName": "华为技术有限公司",       "InvestLegalName": "汤启兵",       "StockPercentage": "100.0%",       "InvestName": "深圳市华为技术服务有限公司",       "InvestRegCap": "2000.0万人民币"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvestmentAbroadResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInvestmentAbroadResponseBody;
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
      body: GetInvestmentAbroadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "DEPARTMENT": "xx",       "IN_REASON": "xx",       "OUT_DATE": "2006-12-07",       "OUT_DEPARTMENT": "xx",       "IN_DATE": "2006-12-07",       "OUT_REASON": "xx"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetJobInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetJobInfoResponseBody;
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
      body: GetJobInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [{"EntName":"企业名称", "PatentType":"专利类型", "PatentName":"专利名", "PatentStatus":"专利状态", "RequestNum":"申请号", "RequestDate":"申请日", "PublicNum":"公开(公告)号", "PublicDate":"公开(公告)日", "InventorList":"发明人", "PatenteeList":"专利权人", "CateNum":"分类号", "PrioNum":"优先权号", "PrioDate":"优先权日", "Agency":"专利代理机构", "Agent":"代理人", "Brief":"简要说明", "MainClaim":"主权项"}]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPatentInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPatentInfoResponseBody;
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
      body: GetPatentInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "JobTitle": "董事长",       "Name": "梁华"     },     {       "JobTitle": "副董事长",       "Name": "孟晚舟"     },     {       "JobTitle": "副董事长",       "Name": "徐直军"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPrincipalEmployeeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPrincipalEmployeeResponseBody;
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
      body: GetPrincipalEmployeeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "DEPARTMENT":"xx"       "END_DATE":"2017-01-04"       "ENT_NAME":"xx"       "QUALIFICATION"       "START_DATE":"2017-01-04"       "TAXPAYER_NUM":"11"       "JUDGE_DATE":"2017-05-04"      }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQeneralTaxpayerInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetQeneralTaxpayerInfoResponseBody;
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
      body: GetQeneralTaxpayerInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertResponseBody extends $tea.Model {
  /**
   * @example
   * [{"EntName":"企业名称", "CertType":"证书类型", "CertNum":"证书认证编号", "ValidStartDate":"有效期开始日期", "ValidEndDate":"有效期截止日期", "AuthorizeDate":"授权日期", "AuthorizeDepartment":"授权部门", "PubDate":"公示日期", "Province":"省份", "CertScope":"认证范围"} ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetQualificationCertResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetQualificationCertResponseBody;
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
      body: GetQualificationCertResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "IN_DATE": "xx",       "IN_DEPARTMENT": "xx",       "IN_REASON": "xx"      }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSeriousViolationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSeriousViolationResponseBody;
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
      body: GetSeriousViolationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightResponseBody extends $tea.Model {
  /**
   * @example
   * [{ "EntName:企业名称", "CopyNum:登记号", "TypeNum:分类号", "ShortName:作品简称", "CopyName:作品全称", "Version:版本号", "SuccessDate:创作完成日期", "FirstDate:首次发表日期", "ApprovalDate:登记批准日期" }]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSoftwareCopyrightResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSoftwareCopyrightResponseBody;
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
      body: GetSoftwareCopyrightResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoResponseBody extends $tea.Model {
  /**
   * @example
   * [{ "entName:企业名称", "trademarkName:商标名称", "regNum:商标注册号", "trademarkType:商标类型", "trademarkForm:商标形式", "trademarkStatus:商标状态", "applyDate:申请日期", "imageUrl:图片链接", "typeName:商标类型名", "period:专用权期限", "agent:代理人名称", "regPubNo:注册公告号", "regPubDate:注册公告日期", "firstPubNo:初审公告号", "firstPubDate:初审公告日期"}]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTrademarkInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTrademarkInfoResponseBody;
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
      body: GetTrademarkInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightResponseBody extends $tea.Model {
  /**
   * @example
   * [{ "EntName":"企业名称", "CopyName":"作品全称", "TypeName":"作品类别", "CopyNum":"登记号", "SuccessDate":"创作完成日期", "FirstDate":"首次发表日期", "ApprovalDate":"登记批准日期" }]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWorkCopyrightResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetWorkCopyrightResponseBody;
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
      body: GetWorkCopyrightResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDataDeliversHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDataDeliversRequest extends $tea.Model {
  /**
   * @example
   * RT
   */
  dispatchingItemType?: string;
  static names(): { [key: string]: string } {
    return {
      dispatchingItemType: 'dispatchingItemType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dispatchingItemType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListDataDeliversResponseBody extends $tea.Model {
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

export class ListDataDeliversResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListDataDeliversResponseBody;
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
      body: ListDataDeliversResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OperateChartConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OperateChartConfigRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  apiKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  corpId?: string;
  param?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8ABvoWxoelSxcxZBsF3MeWBDe5oi8jmFtU790jhpRoLrfJDWO8UDHbUqvTb3pQA5
   */
  ticket?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      apiKey: 'apiKey',
      corpId: 'corpId',
      param: 'param',
      ticket: 'ticket',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiKey: 'string',
      corpId: 'string',
      param: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      ticket: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OperateChartConfigResponseBody extends $tea.Model {
  result?: { [key: string]: string };
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OperateChartConfigResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OperateChartConfigResponseBody;
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
      body: OperateChartConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostCorpAuthInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PostCorpAuthInfoResponseBody extends $tea.Model {
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

export class PostCorpAuthInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PostCorpAuthInfoResponseBody;
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
      body: PostCorpAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryActiveUserStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryActiveUserStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryActiveUserStatisticalDataResponseBody;
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
      body: QueryActiveUserStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataRequest extends $tea.Model {
  pageNumber?: number;
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryAnhmdStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryAnhmdStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAnhmdStatisticalDataResponseBody;
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
      body: QueryAnhmdStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryApprovalStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryApprovalStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryApprovalStatisticalDataResponseBody;
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
      body: QueryApprovalStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryAttendanceStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryAttendanceStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAttendanceStatisticalDataResponseBody;
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
      body: QueryAttendanceStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryBlackboardStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryBlackboardStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBlackboardStatisticalDataResponseBody;
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
      body: QueryBlackboardStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryCalendarStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryCalendarStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCalendarStatisticalDataResponseBody;
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
      body: QueryCalendarStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryChartDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryChartDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ABC
   */
  ticket?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      ticket: 'ticket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      ticket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryChartDataResponseBody extends $tea.Model {
  result?: any[];
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'any' },
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryChartDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryChartDataResponseBody;
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
      body: QueryChartDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryCheckinStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryCheckinStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCheckinStatisticalDataResponseBody;
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
      body: QueryCheckinStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryCircleStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryCircleStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCircleStatisticalDataResponseBody;
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
      body: QueryCircleStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoResponseBody extends $tea.Model {
  code?: string;
  data?: { [key: string]: string }[];
  message?: string;
  requestId?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
      requestId: 'requestId',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'string' } },
      message: 'string',
      requestId: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyBasicInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCompanyBasicInfoResponseBody;
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
      body: QueryCompanyBasicInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  corpIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  statDates?: string[];
  static names(): { [key: string]: string } {
    return {
      corpIds: 'corpIds',
      statDates: 'statDates',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIds: { 'type': 'array', 'itemType': 'string' },
      statDates: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoResponseBody extends $tea.Model {
  arguments?: string[];
  result?: string;
  static names(): { [key: string]: string } {
    return {
      arguments: 'arguments',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      arguments: { 'type': 'array', 'itemType': 'string' },
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDigitalDistrictOrgInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDigitalDistrictOrgInfoResponseBody;
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
      body: QueryDigitalDistrictOrgInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDingReciveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDingReciveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDingReciveStatisticalDataResponseBody;
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
      body: QueryDingReciveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDingSendStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDingSendStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDingSendStatisticalDataResponseBody;
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
      body: QueryDingSendStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDocumentStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDocumentStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDocumentStatisticalDataResponseBody;
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
      body: QueryDocumentStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryDriveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryDriveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryDriveStatisticalDataResponseBody;
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
      body: QueryDriveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryEmployeeTypeStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryEmployeeTypeStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryEmployeeTypeStatisticalDataResponseBody;
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
      body: QueryEmployeeTypeStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceRequest extends $tea.Model {
  /**
   * @example
   * 123
   */
  deptId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220803
   */
  endDate?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * API-7fa754fd-f53e-46ee-9b77-898aa6eb590c
   */
  serviceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220801
   */
  startDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0234412313
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      endDate: 'endDate',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      serviceId: 'serviceId',
      startDate: 'startDate',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'string',
      endDate: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      serviceId: 'string',
      startDate: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryGeneralDataServiceResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryGeneralDataServiceResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGeneralDataServiceResponseBody;
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
      body: QueryGeneralDataServiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceBatchHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceBatchRequest extends $tea.Model {
  deptIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  endDate?: string;
  filters?: QueryGeneralDataServiceBatchRequestFilters[];
  /**
   * @remarks
   * This parameter is required.
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  serviceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  startDate?: string;
  userId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      endDate: 'endDate',
      filters: 'filters',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      serviceId: 'serviceId',
      startDate: 'startDate',
      userId: 'userId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'string' },
      endDate: 'string',
      filters: { 'type': 'array', 'itemType': QueryGeneralDataServiceBatchRequestFilters },
      pageNumber: 'number',
      pageSize: 'number',
      serviceId: 'string',
      startDate: 'string',
      userId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceBatchResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryGeneralDataServiceBatchResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryGeneralDataServiceBatchResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceBatchResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGeneralDataServiceBatchResponseBody;
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
      body: QueryGeneralDataServiceBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataUpdateDateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataUpdateDateRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  serviceId?: string;
  static names(): { [key: string]: string } {
    return {
      serviceId: 'serviceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      serviceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataUpdateDateResponseBody extends $tea.Model {
  success?: boolean;
  updateDate?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      updateDate: 'updateDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      updateDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataUpdateDateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGeneralDataUpdateDateResponseBody;
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
      body: QueryGeneralDataUpdateDateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryGroupLiveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryGroupLiveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupLiveStatisticalDataResponseBody;
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
      body: QueryGroupLiveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryGroupMessageStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryGroupMessageStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupMessageStatisticalDataResponseBody;
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
      body: QueryGroupMessageStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryHealthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryHealthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryHealthStatisticalDataResponseBody;
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
      body: QueryHealthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryMailStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryMailStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMailStatisticalDataResponseBody;
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
      body: QueryMailStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDataRequest extends $tea.Model {
  param?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDataResponseBody extends $tea.Model {
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

export class QueryOfficialDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOfficialDataResponseBody;
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
      body: QueryOfficialDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsRequest extends $tea.Model {
  /**
   * @example
   * ding3xxx__-PROC-42FF6625-9692-4003-B13C-307CAACEC354
   */
  dsId?: string;
  /**
   * @example
   * 12345
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dsId: 'dsId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dsId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponseBody extends $tea.Model {
  result?: QueryOfficialDatasetFieldsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOfficialDatasetFieldsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOfficialDatasetFieldsResponseBody;
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
      body: QueryOfficialDatasetFieldsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListRequest extends $tea.Model {
  keyword?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponseBody extends $tea.Model {
  result?: QueryOfficialDatasetListResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOfficialDatasetListResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOfficialDatasetListResponseBody;
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
      body: QueryOfficialDatasetListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataRequest extends $tea.Model {
  param?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataResponseBody extends $tea.Model {
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

export class QueryOfficialFormDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOfficialFormDataResponseBody;
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
      body: QueryOfficialFormDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataDirectHoloHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataDirectHoloRequest extends $tea.Model {
  param?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      param: 'param',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      param: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialFormDataDirectHoloResponseBody extends $tea.Model {
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

export class QueryOfficialFormDataDirectHoloResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOfficialFormDataDirectHoloResponseBody;
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
      body: QueryOfficialFormDataDirectHoloResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryOnlineUserStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryOnlineUserStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOnlineUserStatisticalDataResponseBody;
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
      body: QueryOnlineUserStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRedEnvelopeReciveStatisticalDataResponseBody;
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
      body: QueryRedEnvelopeReciveStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRedEnvelopeSendStatisticalDataResponseBody;
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
      body: QueryRedEnvelopeSendStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryReportStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryReportStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryReportStatisticalDataResponseBody;
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
      body: QueryReportStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenRequest extends $tea.Model {
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenResponseBody extends $tea.Model {
  result?: QueryScreenResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryScreenResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryScreenResponseBody;
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
      body: QueryScreenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenTemplateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenTemplateRequest extends $tea.Model {
  operatorId?: string;
  sample?: boolean;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
      sample: 'sample',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
      sample: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenTemplateResponseBody extends $tea.Model {
  result?: QueryScreenTemplateResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': QueryScreenTemplateResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenTemplateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryScreenTemplateResponseBody;
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
      body: QueryScreenTemplateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QuerySingleMessageStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QuerySingleMessageStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySingleMessageStatisticalDataResponseBody;
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
      body: QuerySingleMessageStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryTelMeetingStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryTelMeetingStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryTelMeetingStatisticalDataResponseBody;
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
      body: QueryTelMeetingStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryTodoStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryTodoStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryTodoStatisticalDataResponseBody;
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
      body: QueryTodoStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTotalDataCountServiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTotalDataCountServiceRequest extends $tea.Model {
  deptIds?: string[];
  /**
   * @example
   * 20240611
   */
  endDate?: string;
  pageNumber?: number;
  pageSize?: number;
  /**
   * @example
   * API-xxxx
   */
  serviceId?: string;
  /**
   * @example
   * 20240611
   */
  startDate?: string;
  /**
   * @example
   * 222
   */
  userId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptIds: 'deptIds',
      endDate: 'endDate',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      serviceId: 'serviceId',
      startDate: 'startDate',
      userId: 'userId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptIds: { 'type': 'array', 'itemType': 'string' },
      endDate: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      serviceId: 'string',
      startDate: 'string',
      userId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTotalDataCountServiceResponseBody extends $tea.Model {
  success?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTotalDataCountServiceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryTotalDataCountServiceResponseBody;
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
      body: QueryTotalDataCountServiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryVedioMeetingStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryVedioMeetingStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryVedioMeetingStatisticalDataResponseBody;
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
      body: QueryVedioMeetingStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydActiveDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydActiveDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydActiveDayStatisticalDataResponseBody;
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
      body: QueryYydActiveDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydActiveMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydActiveMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydActiveMonthStatisticalDataResponseBody;
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
      body: QueryYydActiveMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydActiveWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydActiveWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydActiveWeekStatisticalDataResponseBody;
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
      body: QueryYydActiveWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydAppDayStatisticalDataResponseBody;
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
      body: QueryYydAppDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydAppMonthStatisticalDataResponseBody;
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
      body: QueryYydAppMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppStdStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppStdStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydAppStdStatisticalDataResponseBody;
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
      body: QueryYydAppStdStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydAppWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydAppWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydAppWeekStatisticalDataResponseBody;
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
      body: QueryYydAppWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydCalendarDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydCalendarDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydCalendarDayStatisticalDataResponseBody;
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
      body: QueryYydCalendarDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydCalendarMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydCalendarMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydCalendarMonthStatisticalDataResponseBody;
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
      body: QueryYydCalendarMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydCalendarWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydCalendarWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydCalendarWeekStatisticalDataResponseBody;
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
      body: QueryYydCalendarWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydDingMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydDingMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydDingMsgDayStatisticalDataResponseBody;
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
      body: QueryYydDingMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydDingMsgMonthStatisticalDataResponseBody;
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
      body: QueryYydDingMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydDingMsgWeekStatisticalDataResponseBody;
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
      body: QueryYydDingMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydGroupMsgDayStatisticalDataResponseBody;
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
      body: QueryYydGroupMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydGroupMsgMonthStatisticalDataResponseBody;
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
      body: QueryYydGroupMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydGroupMsgWeekStatisticalDataResponseBody;
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
      body: QueryYydGroupMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydLogDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydLogDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydLogDayStatisticalDataResponseBody;
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
      body: QueryYydLogDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydLogMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydLogMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydLogMonthStatisticalDataResponseBody;
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
      body: QueryYydLogMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydLogWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydLogWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydLogWeekStatisticalDataResponseBody;
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
      body: QueryYydLogWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydMeetingDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydMeetingDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydMeetingDayStatisticalDataResponseBody;
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
      body: QueryYydMeetingDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydMeetingMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydMeetingMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydMeetingMonthStatisticalDataResponseBody;
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
      body: QueryYydMeetingMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydMeetingWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydMeetingWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydMeetingWeekStatisticalDataResponseBody;
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
      body: QueryYydMeetingWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydNoticeDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydNoticeDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydNoticeDayStatisticalDataResponseBody;
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
      body: QueryYydNoticeDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydNoticeMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydNoticeMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydNoticeMonthStatisticalDataResponseBody;
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
      body: QueryYydNoticeMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydNoticeWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydNoticeWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydNoticeWeekStatisticalDataResponseBody;
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
      body: QueryYydNoticeWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydSingleMsgDayStatisticalDataResponseBody;
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
      body: QueryYydSingleMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydSingleMsgMonthStatisticalDataResponseBody;
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
      body: QueryYydSingleMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydSingleMsgWeekStatisticalDataResponseBody;
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
      body: QueryYydSingleMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydToatlMsgDayStatisticalDataResponseBody;
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
      body: QueryYydToatlMsgDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydToatlMsgMonthStatisticalDataResponseBody;
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
      body: QueryYydToatlMsgMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydToatlMsgWeekStatisticalDataResponseBody;
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
      body: QueryYydToatlMsgWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTodoDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTodoDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydTodoDayStatisticalDataResponseBody;
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
      body: QueryYydTodoDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTodoMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTodoMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydTodoMonthStatisticalDataResponseBody;
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
      body: QueryYydTodoMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTodoWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTodoWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydTodoWeekStatisticalDataResponseBody;
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
      body: QueryYydTodoWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalDayStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalDayStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydTotalDayStatisticalDataResponseBody;
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
      body: QueryYydTotalDayStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalMonthStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalMonthStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydTotalMonthStatisticalDataResponseBody;
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
      body: QueryYydTotalMonthStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalStdStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalStdStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydTotalStdStatisticalDataResponseBody;
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
      body: QueryYydTotalStdStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  statDate?: string;
  static names(): { [key: string]: string } {
    return {
      statDate: 'statDate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      statDate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataResponseBody extends $tea.Model {
  dataList?: { [key: string]: any }[];
  metaList?: QueryYydTotalWeekStatisticalDataResponseBodyMetaList[];
  static names(): { [key: string]: string } {
    return {
      dataList: 'dataList',
      metaList: 'metaList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataList: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      metaList: { 'type': 'array', 'itemType': QueryYydTotalWeekStatisticalDataResponseBodyMetaList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryYydTotalWeekStatisticalDataResponseBody;
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
      body: QueryYydTotalWeekStatisticalDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  searchKey?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      searchKey: 'searchKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      searchKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyResponseBody extends $tea.Model {
  /**
   * @example
   * [     {       "ENT_NAME": "xx",       "SOCIAL_CREDIT_CODE": "xx",       "LICENSE_NUMBER": "xx",       "REG_CAP": "10000000.0",       "ES_DATE": "2006-12-07",       "LEGAL_NAME": "xx",       "ORG_NO": "xx",       "TAX_NUM": "xx",       "ENT_STATUS": "在营"     }   ]
   */
  data?: string;
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'string',
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchCompanyResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchCompanyResponseBody;
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
      body: SearchCompanyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataScreenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataScreenRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  screenId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ABC
   */
  ticket?: string;
  static names(): { [key: string]: string } {
    return {
      screenId: 'screenId',
      ticket: 'ticket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      screenId: 'string',
      ticket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncDataScreenResponseBody extends $tea.Model {
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

export class SyncDataScreenResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncDataScreenResponseBody;
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
      body: SyncDataScreenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUserStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAnhmdStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryApprovalStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAttendanceStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBlackboardStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCalendarStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCheckinStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCircleStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingReciveStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDingSendStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDocumentStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryDriveStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEmployeeTypeStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldDesc: 'fieldDesc',
      fieldId: 'fieldId',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldDesc: 'string',
      fieldId: 'string',
      fieldName: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceBatchRequestFilters extends $tea.Model {
  fieldId?: string;
  operator?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      fieldId: 'fieldId',
      operator: 'operator',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldId: 'string',
      operator: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGeneralDataServiceBatchResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  fieldDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      fieldDesc: 'fieldDesc',
      fieldId: 'fieldId',
      fieldName: 'fieldName',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldDesc: 'string',
      fieldId: 'string',
      fieldName: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupLiveStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMessageStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryHealthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMailStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponseBodyResultFields extends $tea.Model {
  displayName?: string;
  fieldId?: string;
  fieldType?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      fieldId: 'fieldId',
      fieldType: 'fieldType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      fieldId: 'string',
      fieldType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetFieldsResponseBodyResult extends $tea.Model {
  displayName?: string;
  dsId?: string;
  fields?: QueryOfficialDatasetFieldsResponseBodyResultFields[];
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      dsId: 'dsId',
      fields: 'fields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      dsId: 'string',
      fields: { 'type': 'array', 'itemType': QueryOfficialDatasetFieldsResponseBodyResultFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponseBodyResultRows extends $tea.Model {
  displayName?: string;
  dsId?: string;
  static names(): { [key: string]: string } {
    return {
      displayName: 'displayName',
      dsId: 'dsId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      displayName: 'string',
      dsId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOfficialDatasetListResponseBodyResult extends $tea.Model {
  rows?: QueryOfficialDatasetListResponseBodyResultRows[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      rows: 'rows',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rows: { 'type': 'array', 'itemType': QueryOfficialDatasetListResponseBodyResultRows },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOnlineUserStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeReciveStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRedEnvelopeSendStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReportStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenResponseBodyResult extends $tea.Model {
  operatePermission?: string;
  screenId?: number;
  screenName?: string;
  state?: string;
  thumbUrl?: string;
  static names(): { [key: string]: string } {
    return {
      operatePermission: 'operatePermission',
      screenId: 'screenId',
      screenName: 'screenName',
      state: 'state',
      thumbUrl: 'thumbUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatePermission: 'string',
      screenId: 'number',
      screenName: 'string',
      state: 'string',
      thumbUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScreenTemplateResponseBodyResult extends $tea.Model {
  previewUrl?: string;
  screenSize?: string;
  templateId?: string;
  templateName?: string;
  thumbUrl?: string;
  static names(): { [key: string]: string } {
    return {
      previewUrl: 'previewUrl',
      screenSize: 'screenSize',
      templateId: 'templateId',
      templateName: 'templateName',
      thumbUrl: 'thumbUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      previewUrl: 'string',
      screenSize: 'string',
      templateId: 'string',
      templateName: 'string',
      thumbUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleMessageStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTelMeetingStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryVedioMeetingStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydActiveWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppStdStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydAppWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydCalendarWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydDingMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydGroupMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydLogWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydMeetingWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydNoticeWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydSingleMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydToatlMsgWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTodoWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalDayStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalMonthStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalStdStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryYydTotalWeekStatisticalDataResponseBodyMetaList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  kpiCaliber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  kpiName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  period?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      kpiCaliber: 'kpiCaliber',
      kpiId: 'kpiId',
      kpiName: 'kpiName',
      period: 'period',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      kpiCaliber: 'string',
      kpiId: 'string',
      kpiName: 'string',
      period: 'string',
      unit: 'string',
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
   * 关闭数据投递任务
   * 
   * @param request - CloseDataDeliverRequest
   * @param headers - CloseDataDeliverHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CloseDataDeliverResponse
   */
  async closeDataDeliverWithOptions(request: CloseDataDeliverRequest, headers: CloseDataDeliverHeaders, runtime: $Util.RuntimeOptions): Promise<CloseDataDeliverResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deliverId)) {
      query["deliverId"] = request.deliverId;
    }

    if (!Util.isUnset(request.dispatchingItemType)) {
      query["dispatchingItemType"] = request.dispatchingItemType;
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
      action: "CloseDataDeliver",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dataDeliverServices/close`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CloseDataDeliverResponse>(await this.execute(params, req, runtime), new CloseDataDeliverResponse({}));
  }

  /**
   * 关闭数据投递任务
   * 
   * @param request - CloseDataDeliverRequest
   * @returns CloseDataDeliverResponse
   */
  async closeDataDeliver(request: CloseDataDeliverRequest): Promise<CloseDataDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseDataDeliverHeaders({ });
    return await this.closeDataDeliverWithOptions(request, headers, runtime);
  }

  /**
   * 创建数据投递
   * 
   * @param request - CreateDataDeliverRequest
   * @param headers - CreateDataDeliverHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateDataDeliverResponse
   */
  async createDataDeliverWithOptions(request: CreateDataDeliverRequest, headers: CreateDataDeliverHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDataDeliverResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizcode)) {
      query["bizcode"] = request.bizcode;
    }

    if (!Util.isUnset(request.dispatchingCycle)) {
      query["dispatchingCycle"] = request.dispatchingCycle;
    }

    if (!Util.isUnset(request.dispatchingItemType)) {
      query["dispatchingItemType"] = request.dispatchingItemType;
    }

    if (!Util.isUnset(request.dispatchingStartDate)) {
      query["dispatchingStartDate"] = request.dispatchingStartDate;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "CreateDataDeliver",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dataDeliveries`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateDataDeliverResponse>(await this.execute(params, req, runtime), new CreateDataDeliverResponse({}));
  }

  /**
   * 创建数据投递
   * 
   * @param request - CreateDataDeliverRequest
   * @returns CreateDataDeliverResponse
   */
  async createDataDeliver(request: CreateDataDeliverRequest): Promise<CreateDataDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDataDeliverHeaders({ });
    return await this.createDataDeliverWithOptions(request, headers, runtime);
  }

  /**
   * 新增数据大屏
   * 
   * @param request - CreateScreenRequest
   * @param headers - CreateScreenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateScreenResponse
   */
  async createScreenWithOptions(request: CreateScreenRequest, headers: CreateScreenHeaders, runtime: $Util.RuntimeOptions): Promise<CreateScreenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.templateId)) {
      query["templateId"] = request.templateId;
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
      action: "CreateScreen",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/screens`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateScreenResponse>(await this.execute(params, req, runtime), new CreateScreenResponse({}));
  }

  /**
   * 新增数据大屏
   * 
   * @param request - CreateScreenRequest
   * @returns CreateScreenResponse
   */
  async createScreen(request: CreateScreenRequest): Promise<CreateScreenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateScreenHeaders({ });
    return await this.createScreenWithOptions(request, headers, runtime);
  }

  /**
   * 工商-经营异常
   * 
   * @param request - GetAbnormalOperationRequest
   * @param headers - GetAbnormalOperationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAbnormalOperationResponse
   */
  async getAbnormalOperationWithOptions(request: GetAbnormalOperationRequest, headers: GetAbnormalOperationHeaders, runtime: $Util.RuntimeOptions): Promise<GetAbnormalOperationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetAbnormalOperation",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/abnormalOperations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAbnormalOperationResponse>(await this.execute(params, req, runtime), new GetAbnormalOperationResponse({}));
  }

  /**
   * 工商-经营异常
   * 
   * @param request - GetAbnormalOperationRequest
   * @returns GetAbnormalOperationResponse
   */
  async getAbnormalOperation(request: GetAbnormalOperationRequest): Promise<GetAbnormalOperationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAbnormalOperationHeaders({ });
    return await this.getAbnormalOperationWithOptions(request, headers, runtime);
  }

  /**
   * 获取工商-行政许可
   * 
   * @param request - GetAdministrativeLicensingRequest
   * @param headers - GetAdministrativeLicensingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAdministrativeLicensingResponse
   */
  async getAdministrativeLicensingWithOptions(request: GetAdministrativeLicensingRequest, headers: GetAdministrativeLicensingHeaders, runtime: $Util.RuntimeOptions): Promise<GetAdministrativeLicensingResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetAdministrativeLicensing",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/administrativeLicenses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAdministrativeLicensingResponse>(await this.execute(params, req, runtime), new GetAdministrativeLicensingResponse({}));
  }

  /**
   * 获取工商-行政许可
   * 
   * @param request - GetAdministrativeLicensingRequest
   * @returns GetAdministrativeLicensingResponse
   */
  async getAdministrativeLicensing(request: GetAdministrativeLicensingRequest): Promise<GetAdministrativeLicensingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAdministrativeLicensingHeaders({ });
    return await this.getAdministrativeLicensingWithOptions(request, headers, runtime);
  }

  /**
   * 负面-行政处罚
   * 
   * @param request - GetAdministrativePenaltiesRequest
   * @param headers - GetAdministrativePenaltiesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAdministrativePenaltiesResponse
   */
  async getAdministrativePenaltiesWithOptions(request: GetAdministrativePenaltiesRequest, headers: GetAdministrativePenaltiesHeaders, runtime: $Util.RuntimeOptions): Promise<GetAdministrativePenaltiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetAdministrativePenalties",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/administrativePenalties`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAdministrativePenaltiesResponse>(await this.execute(params, req, runtime), new GetAdministrativePenaltiesResponse({}));
  }

  /**
   * 负面-行政处罚
   * 
   * @param request - GetAdministrativePenaltiesRequest
   * @returns GetAdministrativePenaltiesResponse
   */
  async getAdministrativePenalties(request: GetAdministrativePenaltiesRequest): Promise<GetAdministrativePenaltiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAdministrativePenaltiesHeaders({ });
    return await this.getAdministrativePenaltiesWithOptions(request, headers, runtime);
  }

  /**
   * 工商-基础信息
   * 
   * @param request - GetBasicInfoRequest
   * @param headers - GetBasicInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetBasicInfoResponse
   */
  async getBasicInfoWithOptions(request: GetBasicInfoRequest, headers: GetBasicInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetBasicInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetBasicInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/businessBasicInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBasicInfoResponse>(await this.execute(params, req, runtime), new GetBasicInfoResponse({}));
  }

  /**
   * 工商-基础信息
   * 
   * @param request - GetBasicInfoRequest
   * @returns GetBasicInfoResponse
   */
  async getBasicInfo(request: GetBasicInfoRequest): Promise<GetBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBasicInfoHeaders({ });
    return await this.getBasicInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取经营-招投标信息
   * 
   * @param request - GetBiddingInfoRequest
   * @param headers - GetBiddingInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetBiddingInfoResponse
   */
  async getBiddingInfoWithOptions(request: GetBiddingInfoRequest, headers: GetBiddingInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetBiddingInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetBiddingInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/biddingInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBiddingInfoResponse>(await this.execute(params, req, runtime), new GetBiddingInfoResponse({}));
  }

  /**
   * 获取经营-招投标信息
   * 
   * @param request - GetBiddingInfoRequest
   * @returns GetBiddingInfoResponse
   */
  async getBiddingInfo(request: GetBiddingInfoRequest): Promise<GetBiddingInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBiddingInfoHeaders({ });
    return await this.getBiddingInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取工商-分支机构
   * 
   * @param request - GetBranchInfoRequest
   * @param headers - GetBranchInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetBranchInfoResponse
   */
  async getBranchInfoWithOptions(request: GetBranchInfoRequest, headers: GetBranchInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetBranchInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetBranchInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/branchInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBranchInfoResponse>(await this.execute(params, req, runtime), new GetBranchInfoResponse({}));
  }

  /**
   * 获取工商-分支机构
   * 
   * @param request - GetBranchInfoRequest
   * @returns GetBranchInfoResponse
   */
  async getBranchInfo(request: GetBranchInfoRequest): Promise<GetBranchInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBranchInfoHeaders({ });
    return await this.getBranchInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取工商-变更记录
   * 
   * @param request - GetChangeRecordRequest
   * @param headers - GetChangeRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetChangeRecordResponse
   */
  async getChangeRecordWithOptions(request: GetChangeRecordRequest, headers: GetChangeRecordHeaders, runtime: $Util.RuntimeOptions): Promise<GetChangeRecordResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetChangeRecord",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/changeRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetChangeRecordResponse>(await this.execute(params, req, runtime), new GetChangeRecordResponse({}));
  }

  /**
   * 获取工商-变更记录
   * 
   * @param request - GetChangeRecordRequest
   * @returns GetChangeRecordResponse
   */
  async getChangeRecord(request: GetChangeRecordRequest): Promise<GetChangeRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetChangeRecordHeaders({ });
    return await this.getChangeRecordWithOptions(request, headers, runtime);
  }

  /**
   * 获取投递任务信息
   * 
   * @param request - GetDataDeliverRequest
   * @param headers - GetDataDeliverHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDataDeliverResponse
   */
  async getDataDeliverWithOptions(request: GetDataDeliverRequest, headers: GetDataDeliverHeaders, runtime: $Util.RuntimeOptions): Promise<GetDataDeliverResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deliverId)) {
      query["deliverId"] = request.deliverId;
    }

    if (!Util.isUnset(request.dispatchingItemType)) {
      query["dispatchingItemType"] = request.dispatchingItemType;
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
      action: "GetDataDeliver",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dataDeliverServices/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDataDeliverResponse>(await this.execute(params, req, runtime), new GetDataDeliverResponse({}));
  }

  /**
   * 获取投递任务信息
   * 
   * @param request - GetDataDeliverRequest
   * @returns GetDataDeliverResponse
   */
  async getDataDeliver(request: GetDataDeliverRequest): Promise<GetDataDeliverResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDataDeliverHeaders({ });
    return await this.getDataDeliverWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识产权-域名信息
   * 
   * @param request - GetDomainInfoRequest
   * @param headers - GetDomainInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDomainInfoResponse
   */
  async getDomainInfoWithOptions(request: GetDomainInfoRequest, headers: GetDomainInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetDomainInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetDomainInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/domainInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDomainInfoResponse>(await this.execute(params, req, runtime), new GetDomainInfoResponse({}));
  }

  /**
   * 获取知识产权-域名信息
   * 
   * @param request - GetDomainInfoRequest
   * @returns GetDomainInfoResponse
   */
  async getDomainInfo(request: GetDomainInfoRequest): Promise<GetDomainInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDomainInfoHeaders({ });
    return await this.getDomainInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取工商-双随机抽查结果
   * 
   * @param request - GetDoubleRandomRequest
   * @param headers - GetDoubleRandomHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDoubleRandomResponse
   */
  async getDoubleRandomWithOptions(request: GetDoubleRandomRequest, headers: GetDoubleRandomHeaders, runtime: $Util.RuntimeOptions): Promise<GetDoubleRandomResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetDoubleRandom",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/doubleRandomness`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDoubleRandomResponse>(await this.execute(params, req, runtime), new GetDoubleRandomResponse({}));
  }

  /**
   * 获取工商-双随机抽查结果
   * 
   * @param request - GetDoubleRandomRequest
   * @returns GetDoubleRandomResponse
   */
  async getDoubleRandom(request: GetDoubleRandomRequest): Promise<GetDoubleRandomResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDoubleRandomHeaders({ });
    return await this.getDoubleRandomWithOptions(request, headers, runtime);
  }

  /**
   * 负面-环保处罚
   * 
   * @param request - GetEnvironmentalPenaltiesRequest
   * @param headers - GetEnvironmentalPenaltiesHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetEnvironmentalPenaltiesResponse
   */
  async getEnvironmentalPenaltiesWithOptions(request: GetEnvironmentalPenaltiesRequest, headers: GetEnvironmentalPenaltiesHeaders, runtime: $Util.RuntimeOptions): Promise<GetEnvironmentalPenaltiesResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetEnvironmentalPenalties",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/environmentalPenalties`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEnvironmentalPenaltiesResponse>(await this.execute(params, req, runtime), new GetEnvironmentalPenaltiesResponse({}));
  }

  /**
   * 负面-环保处罚
   * 
   * @param request - GetEnvironmentalPenaltiesRequest
   * @returns GetEnvironmentalPenaltiesResponse
   */
  async getEnvironmentalPenalties(request: GetEnvironmentalPenaltiesRequest): Promise<GetEnvironmentalPenaltiesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEnvironmentalPenaltiesHeaders({ });
    return await this.getEnvironmentalPenaltiesWithOptions(request, headers, runtime);
  }

  /**
   * 获取事件订阅的数据
   * 
   * @param request - GetEventDataRequest
   * @param headers - GetEventDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetEventDataResponse
   */
  async getEventDataWithOptions(request: GetEventDataRequest, headers: GetEventDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetEventDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.eventUid)) {
      body["eventUid"] = request.eventUid;
    }

    if (!Util.isUnset(request.subId)) {
      body["subId"] = request.subId;
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
      action: "GetEventData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/eventDatas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetEventDataResponse>(await this.execute(params, req, runtime), new GetEventDataResponse({}));
  }

  /**
   * 获取事件订阅的数据
   * 
   * @param request - GetEventDataRequest
   * @returns GetEventDataResponse
   */
  async getEventData(request: GetEventDataRequest): Promise<GetEventDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetEventDataHeaders({ });
    return await this.getEventDataWithOptions(request, headers, runtime);
  }

  /**
   * 工商-股东信息
   * 
   * @param request - GetHolderInfoRequest
   * @param headers - GetHolderInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetHolderInfoResponse
   */
  async getHolderInfoWithOptions(request: GetHolderInfoRequest, headers: GetHolderInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetHolderInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetHolderInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/shareholderInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetHolderInfoResponse>(await this.execute(params, req, runtime), new GetHolderInfoResponse({}));
  }

  /**
   * 工商-股东信息
   * 
   * @param request - GetHolderInfoRequest
   * @returns GetHolderInfoResponse
   */
  async getHolderInfo(request: GetHolderInfoRequest): Promise<GetHolderInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetHolderInfoHeaders({ });
    return await this.getHolderInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取工商-知识产权出质
   * 
   * @param request - GetIntellectualPropertyRequest
   * @param headers - GetIntellectualPropertyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetIntellectualPropertyResponse
   */
  async getIntellectualPropertyWithOptions(request: GetIntellectualPropertyRequest, headers: GetIntellectualPropertyHeaders, runtime: $Util.RuntimeOptions): Promise<GetIntellectualPropertyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetIntellectualProperty",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/intellectualProperties`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetIntellectualPropertyResponse>(await this.execute(params, req, runtime), new GetIntellectualPropertyResponse({}));
  }

  /**
   * 获取工商-知识产权出质
   * 
   * @param request - GetIntellectualPropertyRequest
   * @returns GetIntellectualPropertyResponse
   */
  async getIntellectualProperty(request: GetIntellectualPropertyRequest): Promise<GetIntellectualPropertyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIntellectualPropertyHeaders({ });
    return await this.getIntellectualPropertyWithOptions(request, headers, runtime);
  }

  /**
   * 获取工商-对外投资
   * 
   * @param request - GetInvestmentAbroadRequest
   * @param headers - GetInvestmentAbroadHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInvestmentAbroadResponse
   */
  async getInvestmentAbroadWithOptions(request: GetInvestmentAbroadRequest, headers: GetInvestmentAbroadHeaders, runtime: $Util.RuntimeOptions): Promise<GetInvestmentAbroadResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetInvestmentAbroad",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/abroadInvestments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInvestmentAbroadResponse>(await this.execute(params, req, runtime), new GetInvestmentAbroadResponse({}));
  }

  /**
   * 获取工商-对外投资
   * 
   * @param request - GetInvestmentAbroadRequest
   * @returns GetInvestmentAbroadResponse
   */
  async getInvestmentAbroad(request: GetInvestmentAbroadRequest): Promise<GetInvestmentAbroadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInvestmentAbroadHeaders({ });
    return await this.getInvestmentAbroadWithOptions(request, headers, runtime);
  }

  /**
   * 获取经营-招聘信息
   * 
   * @param request - GetJobInfoRequest
   * @param headers - GetJobInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetJobInfoResponse
   */
  async getJobInfoWithOptions(request: GetJobInfoRequest, headers: GetJobInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetJobInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetJobInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/jobInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetJobInfoResponse>(await this.execute(params, req, runtime), new GetJobInfoResponse({}));
  }

  /**
   * 获取经营-招聘信息
   * 
   * @param request - GetJobInfoRequest
   * @returns GetJobInfoResponse
   */
  async getJobInfo(request: GetJobInfoRequest): Promise<GetJobInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetJobInfoHeaders({ });
    return await this.getJobInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识产权-专利信息
   * 
   * @param request - GetPatentInfoRequest
   * @param headers - GetPatentInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPatentInfoResponse
   */
  async getPatentInfoWithOptions(request: GetPatentInfoRequest, headers: GetPatentInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPatentInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetPatentInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/patentInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPatentInfoResponse>(await this.execute(params, req, runtime), new GetPatentInfoResponse({}));
  }

  /**
   * 获取知识产权-专利信息
   * 
   * @param request - GetPatentInfoRequest
   * @returns GetPatentInfoResponse
   */
  async getPatentInfo(request: GetPatentInfoRequest): Promise<GetPatentInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPatentInfoHeaders({ });
    return await this.getPatentInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取工商-主要人员
   * 
   * @param request - GetPrincipalEmployeeRequest
   * @param headers - GetPrincipalEmployeeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPrincipalEmployeeResponse
   */
  async getPrincipalEmployeeWithOptions(request: GetPrincipalEmployeeRequest, headers: GetPrincipalEmployeeHeaders, runtime: $Util.RuntimeOptions): Promise<GetPrincipalEmployeeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetPrincipalEmployee",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/principalEmployees`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPrincipalEmployeeResponse>(await this.execute(params, req, runtime), new GetPrincipalEmployeeResponse({}));
  }

  /**
   * 获取工商-主要人员
   * 
   * @param request - GetPrincipalEmployeeRequest
   * @returns GetPrincipalEmployeeResponse
   */
  async getPrincipalEmployee(request: GetPrincipalEmployeeRequest): Promise<GetPrincipalEmployeeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPrincipalEmployeeHeaders({ });
    return await this.getPrincipalEmployeeWithOptions(request, headers, runtime);
  }

  /**
   * 经营-一般纳税人
   * 
   * @param request - GetQeneralTaxpayerInfoRequest
   * @param headers - GetQeneralTaxpayerInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetQeneralTaxpayerInfoResponse
   */
  async getQeneralTaxpayerInfoWithOptions(request: GetQeneralTaxpayerInfoRequest, headers: GetQeneralTaxpayerInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetQeneralTaxpayerInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetQeneralTaxpayerInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/generalTaxpayerInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetQeneralTaxpayerInfoResponse>(await this.execute(params, req, runtime), new GetQeneralTaxpayerInfoResponse({}));
  }

  /**
   * 经营-一般纳税人
   * 
   * @param request - GetQeneralTaxpayerInfoRequest
   * @returns GetQeneralTaxpayerInfoResponse
   */
  async getQeneralTaxpayerInfo(request: GetQeneralTaxpayerInfoRequest): Promise<GetQeneralTaxpayerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetQeneralTaxpayerInfoHeaders({ });
    return await this.getQeneralTaxpayerInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识产权-资质证书
   * 
   * @param request - GetQualificationCertRequest
   * @param headers - GetQualificationCertHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetQualificationCertResponse
   */
  async getQualificationCertWithOptions(request: GetQualificationCertRequest, headers: GetQualificationCertHeaders, runtime: $Util.RuntimeOptions): Promise<GetQualificationCertResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetQualificationCert",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/qualificationCerts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetQualificationCertResponse>(await this.execute(params, req, runtime), new GetQualificationCertResponse({}));
  }

  /**
   * 获取知识产权-资质证书
   * 
   * @param request - GetQualificationCertRequest
   * @returns GetQualificationCertResponse
   */
  async getQualificationCert(request: GetQualificationCertRequest): Promise<GetQualificationCertResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetQualificationCertHeaders({ });
    return await this.getQualificationCertWithOptions(request, headers, runtime);
  }

  /**
   * 负面-严重违法
   * 
   * @param request - GetSeriousViolationRequest
   * @param headers - GetSeriousViolationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSeriousViolationResponse
   */
  async getSeriousViolationWithOptions(request: GetSeriousViolationRequest, headers: GetSeriousViolationHeaders, runtime: $Util.RuntimeOptions): Promise<GetSeriousViolationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetSeriousViolation",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/seriousViolations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSeriousViolationResponse>(await this.execute(params, req, runtime), new GetSeriousViolationResponse({}));
  }

  /**
   * 负面-严重违法
   * 
   * @param request - GetSeriousViolationRequest
   * @returns GetSeriousViolationResponse
   */
  async getSeriousViolation(request: GetSeriousViolationRequest): Promise<GetSeriousViolationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSeriousViolationHeaders({ });
    return await this.getSeriousViolationWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识产权-软件著作权
   * 
   * @param request - GetSoftwareCopyrightRequest
   * @param headers - GetSoftwareCopyrightHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSoftwareCopyrightResponse
   */
  async getSoftwareCopyrightWithOptions(request: GetSoftwareCopyrightRequest, headers: GetSoftwareCopyrightHeaders, runtime: $Util.RuntimeOptions): Promise<GetSoftwareCopyrightResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetSoftwareCopyright",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/softwareCopyrights`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSoftwareCopyrightResponse>(await this.execute(params, req, runtime), new GetSoftwareCopyrightResponse({}));
  }

  /**
   * 获取知识产权-软件著作权
   * 
   * @param request - GetSoftwareCopyrightRequest
   * @returns GetSoftwareCopyrightResponse
   */
  async getSoftwareCopyright(request: GetSoftwareCopyrightRequest): Promise<GetSoftwareCopyrightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSoftwareCopyrightHeaders({ });
    return await this.getSoftwareCopyrightWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识产权-商标信息
   * 
   * @param request - GetTrademarkInfoRequest
   * @param headers - GetTrademarkInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTrademarkInfoResponse
   */
  async getTrademarkInfoWithOptions(request: GetTrademarkInfoRequest, headers: GetTrademarkInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetTrademarkInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetTrademarkInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/trademarkInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTrademarkInfoResponse>(await this.execute(params, req, runtime), new GetTrademarkInfoResponse({}));
  }

  /**
   * 获取知识产权-商标信息
   * 
   * @param request - GetTrademarkInfoRequest
   * @returns GetTrademarkInfoResponse
   */
  async getTrademarkInfo(request: GetTrademarkInfoRequest): Promise<GetTrademarkInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTrademarkInfoHeaders({ });
    return await this.getTrademarkInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取知识产权-作品著作权
   * 
   * @param request - GetWorkCopyrightRequest
   * @param headers - GetWorkCopyrightHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetWorkCopyrightResponse
   */
  async getWorkCopyrightWithOptions(request: GetWorkCopyrightRequest, headers: GetWorkCopyrightHeaders, runtime: $Util.RuntimeOptions): Promise<GetWorkCopyrightResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "GetWorkCopyright",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/workCopyrights`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWorkCopyrightResponse>(await this.execute(params, req, runtime), new GetWorkCopyrightResponse({}));
  }

  /**
   * 获取知识产权-作品著作权
   * 
   * @param request - GetWorkCopyrightRequest
   * @returns GetWorkCopyrightResponse
   */
  async getWorkCopyright(request: GetWorkCopyrightRequest): Promise<GetWorkCopyrightResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWorkCopyrightHeaders({ });
    return await this.getWorkCopyrightWithOptions(request, headers, runtime);
  }

  /**
   * 数据投递列表
   * 
   * @param request - ListDataDeliversRequest
   * @param headers - ListDataDeliversHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListDataDeliversResponse
   */
  async listDataDeliversWithOptions(request: ListDataDeliversRequest, headers: ListDataDeliversHeaders, runtime: $Util.RuntimeOptions): Promise<ListDataDeliversResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dispatchingItemType)) {
      query["dispatchingItemType"] = request.dispatchingItemType;
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
      action: "ListDataDelivers",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dataDeliverServices/lists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListDataDeliversResponse>(await this.execute(params, req, runtime), new ListDataDeliversResponse({}));
  }

  /**
   * 数据投递列表
   * 
   * @param request - ListDataDeliversRequest
   * @returns ListDataDeliversResponse
   */
  async listDataDelivers(request: ListDataDeliversRequest): Promise<ListDataDeliversResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListDataDeliversHeaders({ });
    return await this.listDataDeliversWithOptions(request, headers, runtime);
  }

  /**
   * 操作表格配置
   * 
   * @param request - OperateChartConfigRequest
   * @param headers - OperateChartConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OperateChartConfigResponse
   */
  async operateChartConfigWithOptions(request: OperateChartConfigRequest, headers: OperateChartConfigHeaders, runtime: $Util.RuntimeOptions): Promise<OperateChartConfigResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.apiKey)) {
      body["apiKey"] = request.apiKey;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
    }

    if (!Util.isUnset(request.ticket)) {
      body["ticket"] = request.ticket;
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
      action: "OperateChartConfig",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/chartConfigs/operate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OperateChartConfigResponse>(await this.execute(params, req, runtime), new OperateChartConfigResponse({}));
  }

  /**
   * 操作表格配置
   * 
   * @param request - OperateChartConfigRequest
   * @returns OperateChartConfigResponse
   */
  async operateChartConfig(request: OperateChartConfigRequest): Promise<OperateChartConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OperateChartConfigHeaders({ });
    return await this.operateChartConfigWithOptions(request, headers, runtime);
  }

  /**
   * 企业授权信息
   * 
   * @param headers - PostCorpAuthInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PostCorpAuthInfoResponse
   */
  async postCorpAuthInfoWithOptions(headers: PostCorpAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<PostCorpAuthInfoResponse> {
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
      action: "PostCorpAuthInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/corporations/authorize`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PostCorpAuthInfoResponse>(await this.execute(params, req, runtime), new PostCorpAuthInfoResponse({}));
  }

  /**
   * 企业授权信息
   * @returns PostCorpAuthInfoResponse
   */
  async postCorpAuthInfo(): Promise<PostCorpAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PostCorpAuthInfoHeaders({ });
    return await this.postCorpAuthInfoWithOptions(headers, runtime);
  }

  /**
   * 获取企业用户激活状态统计数据
   * 
   * @param request - QueryActiveUserStatisticalDataRequest
   * @param headers - QueryActiveUserStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryActiveUserStatisticalDataResponse
   */
  async queryActiveUserStatisticalDataWithOptions(request: QueryActiveUserStatisticalDataRequest, headers: QueryActiveUserStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryActiveUserStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryActiveUserStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/activeUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryActiveUserStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryActiveUserStatisticalDataResponse({}));
  }

  /**
   * 获取企业用户激活状态统计数据
   * 
   * @param request - QueryActiveUserStatisticalDataRequest
   * @returns QueryActiveUserStatisticalDataResponse
   */
  async queryActiveUserStatisticalData(request: QueryActiveUserStatisticalDataRequest): Promise<QueryActiveUserStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryActiveUserStatisticalDataHeaders({ });
    return await this.queryActiveUserStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取安恒密盾统计数据
   * 
   * @param request - QueryAnhmdStatisticalDataRequest
   * @param headers - QueryAnhmdStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAnhmdStatisticalDataResponse
   */
  async queryAnhmdStatisticalDataWithOptions(request: QueryAnhmdStatisticalDataRequest, headers: QueryAnhmdStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAnhmdStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryAnhmdStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/statisticDatas/anHmd`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAnhmdStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryAnhmdStatisticalDataResponse({}));
  }

  /**
   * 获取安恒密盾统计数据
   * 
   * @param request - QueryAnhmdStatisticalDataRequest
   * @returns QueryAnhmdStatisticalDataResponse
   */
  async queryAnhmdStatisticalData(request: QueryAnhmdStatisticalDataRequest): Promise<QueryAnhmdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAnhmdStatisticalDataHeaders({ });
    return await this.queryAnhmdStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业审批统计数据
   * 
   * @param request - QueryApprovalStatisticalDataRequest
   * @param headers - QueryApprovalStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryApprovalStatisticalDataResponse
   */
  async queryApprovalStatisticalDataWithOptions(request: QueryApprovalStatisticalDataRequest, headers: QueryApprovalStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryApprovalStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryApprovalStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/approvalData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryApprovalStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryApprovalStatisticalDataResponse({}));
  }

  /**
   * 获取企业审批统计数据
   * 
   * @param request - QueryApprovalStatisticalDataRequest
   * @returns QueryApprovalStatisticalDataResponse
   */
  async queryApprovalStatisticalData(request: QueryApprovalStatisticalDataRequest): Promise<QueryApprovalStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryApprovalStatisticalDataHeaders({ });
    return await this.queryApprovalStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业考勤统计数据
   * 
   * @param request - QueryAttendanceStatisticalDataRequest
   * @param headers - QueryAttendanceStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAttendanceStatisticalDataResponse
   */
  async queryAttendanceStatisticalDataWithOptions(request: QueryAttendanceStatisticalDataRequest, headers: QueryAttendanceStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAttendanceStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryAttendanceStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/attendanceData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAttendanceStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryAttendanceStatisticalDataResponse({}));
  }

  /**
   * 获取企业考勤统计数据
   * 
   * @param request - QueryAttendanceStatisticalDataRequest
   * @returns QueryAttendanceStatisticalDataResponse
   */
  async queryAttendanceStatisticalData(request: QueryAttendanceStatisticalDataRequest): Promise<QueryAttendanceStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAttendanceStatisticalDataHeaders({ });
    return await this.queryAttendanceStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业公告统计数据
   * 
   * @param request - QueryBlackboardStatisticalDataRequest
   * @param headers - QueryBlackboardStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBlackboardStatisticalDataResponse
   */
  async queryBlackboardStatisticalDataWithOptions(request: QueryBlackboardStatisticalDataRequest, headers: QueryBlackboardStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBlackboardStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryBlackboardStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/blackboardData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBlackboardStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryBlackboardStatisticalDataResponse({}));
  }

  /**
   * 获取企业公告统计数据
   * 
   * @param request - QueryBlackboardStatisticalDataRequest
   * @returns QueryBlackboardStatisticalDataResponse
   */
  async queryBlackboardStatisticalData(request: QueryBlackboardStatisticalDataRequest): Promise<QueryBlackboardStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBlackboardStatisticalDataHeaders({ });
    return await this.queryBlackboardStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业日程统计数据
   * 
   * @param request - QueryCalendarStatisticalDataRequest
   * @param headers - QueryCalendarStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCalendarStatisticalDataResponse
   */
  async queryCalendarStatisticalDataWithOptions(request: QueryCalendarStatisticalDataRequest, headers: QueryCalendarStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCalendarStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryCalendarStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/calendarData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCalendarStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryCalendarStatisticalDataResponse({}));
  }

  /**
   * 获取企业日程统计数据
   * 
   * @param request - QueryCalendarStatisticalDataRequest
   * @returns QueryCalendarStatisticalDataResponse
   */
  async queryCalendarStatisticalData(request: QueryCalendarStatisticalDataRequest): Promise<QueryCalendarStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCalendarStatisticalDataHeaders({ });
    return await this.queryCalendarStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取图表数据
   * 
   * @param request - QueryChartDataRequest
   * @param headers - QueryChartDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryChartDataResponse
   */
  async queryChartDataWithOptions(request: QueryChartDataRequest, headers: QueryChartDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryChartDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.ticket)) {
      body["ticket"] = request.ticket;
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
      action: "QueryChartData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/chartDatas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryChartDataResponse>(await this.execute(params, req, runtime), new QueryChartDataResponse({}));
  }

  /**
   * 获取图表数据
   * 
   * @param request - QueryChartDataRequest
   * @returns QueryChartDataResponse
   */
  async queryChartData(request: QueryChartDataRequest): Promise<QueryChartDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryChartDataHeaders({ });
    return await this.queryChartDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业签到统计数据
   * 
   * @param request - QueryCheckinStatisticalDataRequest
   * @param headers - QueryCheckinStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCheckinStatisticalDataResponse
   */
  async queryCheckinStatisticalDataWithOptions(request: QueryCheckinStatisticalDataRequest, headers: QueryCheckinStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCheckinStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryCheckinStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/checkinData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCheckinStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryCheckinStatisticalDataResponse({}));
  }

  /**
   * 获取企业签到统计数据
   * 
   * @param request - QueryCheckinStatisticalDataRequest
   * @returns QueryCheckinStatisticalDataResponse
   */
  async queryCheckinStatisticalData(request: QueryCheckinStatisticalDataRequest): Promise<QueryCheckinStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCheckinStatisticalDataHeaders({ });
    return await this.queryCheckinStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业全员圈统计数据
   * 
   * @param request - QueryCircleStatisticalDataRequest
   * @param headers - QueryCircleStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCircleStatisticalDataResponse
   */
  async queryCircleStatisticalDataWithOptions(request: QueryCircleStatisticalDataRequest, headers: QueryCircleStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCircleStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryCircleStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/circleData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCircleStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryCircleStatisticalDataResponse({}));
  }

  /**
   * 获取企业全员圈统计数据
   * 
   * @param request - QueryCircleStatisticalDataRequest
   * @returns QueryCircleStatisticalDataResponse
   */
  async queryCircleStatisticalData(request: QueryCircleStatisticalDataRequest): Promise<QueryCircleStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCircleStatisticalDataHeaders({ });
    return await this.queryCircleStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
   * 
   * @param request - QueryCompanyBasicInfoRequest
   * @param headers - QueryCompanyBasicInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCompanyBasicInfoResponse
   */
  async queryCompanyBasicInfoWithOptions(request: QueryCompanyBasicInfoRequest, headers: QueryCompanyBasicInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCompanyBasicInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

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
      action: "QueryCompanyBasicInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/companies/basicInfo`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCompanyBasicInfoResponse>(await this.execute(params, req, runtime), new QueryCompanyBasicInfoResponse({}));
  }

  /**
   * 通过企业名称/社会统一信用代码/工商注册号，查询企业的基本画像信息。
   * 
   * @param request - QueryCompanyBasicInfoRequest
   * @returns QueryCompanyBasicInfoResponse
   */
  async queryCompanyBasicInfo(request: QueryCompanyBasicInfoRequest): Promise<QueryCompanyBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCompanyBasicInfoHeaders({ });
    return await this.queryCompanyBasicInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取数字区县组织信息
   * 
   * @param request - QueryDigitalDistrictOrgInfoRequest
   * @param headers - QueryDigitalDistrictOrgInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDigitalDistrictOrgInfoResponse
   */
  async queryDigitalDistrictOrgInfoWithOptions(request: QueryDigitalDistrictOrgInfoRequest, headers: QueryDigitalDistrictOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDigitalDistrictOrgInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpIds)) {
      body["corpIds"] = request.corpIds;
    }

    if (!Util.isUnset(request.statDates)) {
      body["statDates"] = request.statDates;
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
      action: "QueryDigitalDistrictOrgInfo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/digitalCounty/orgInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryDigitalDistrictOrgInfoResponse>(await this.execute(params, req, runtime), new QueryDigitalDistrictOrgInfoResponse({}));
  }

  /**
   * 获取数字区县组织信息
   * 
   * @param request - QueryDigitalDistrictOrgInfoRequest
   * @returns QueryDigitalDistrictOrgInfoResponse
   */
  async queryDigitalDistrictOrgInfo(request: QueryDigitalDistrictOrgInfoRequest): Promise<QueryDigitalDistrictOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDigitalDistrictOrgInfoHeaders({ });
    return await this.queryDigitalDistrictOrgInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业DING接收及评论统计数据
   * 
   * @param request - QueryDingReciveStatisticalDataRequest
   * @param headers - QueryDingReciveStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDingReciveStatisticalDataResponse
   */
  async queryDingReciveStatisticalDataWithOptions(request: QueryDingReciveStatisticalDataRequest, headers: QueryDingReciveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDingReciveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryDingReciveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dingReciveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDingReciveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDingReciveStatisticalDataResponse({}));
  }

  /**
   * 获取企业DING接收及评论统计数据
   * 
   * @param request - QueryDingReciveStatisticalDataRequest
   * @returns QueryDingReciveStatisticalDataResponse
   */
  async queryDingReciveStatisticalData(request: QueryDingReciveStatisticalDataRequest): Promise<QueryDingReciveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDingReciveStatisticalDataHeaders({ });
    return await this.queryDingReciveStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业DING发送统计数据
   * 
   * @param request - QueryDingSendStatisticalDataRequest
   * @param headers - QueryDingSendStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDingSendStatisticalDataResponse
   */
  async queryDingSendStatisticalDataWithOptions(request: QueryDingSendStatisticalDataRequest, headers: QueryDingSendStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDingSendStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryDingSendStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dingSendData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDingSendStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDingSendStatisticalDataResponse({}));
  }

  /**
   * 获取企业DING发送统计数据
   * 
   * @param request - QueryDingSendStatisticalDataRequest
   * @returns QueryDingSendStatisticalDataResponse
   */
  async queryDingSendStatisticalData(request: QueryDingSendStatisticalDataRequest): Promise<QueryDingSendStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDingSendStatisticalDataHeaders({ });
    return await this.queryDingSendStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业文档统计数据
   * 
   * @param request - QueryDocumentStatisticalDataRequest
   * @param headers - QueryDocumentStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDocumentStatisticalDataResponse
   */
  async queryDocumentStatisticalDataWithOptions(request: QueryDocumentStatisticalDataRequest, headers: QueryDocumentStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDocumentStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryDocumentStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/documentData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDocumentStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDocumentStatisticalDataResponse({}));
  }

  /**
   * 获取企业文档统计数据
   * 
   * @param request - QueryDocumentStatisticalDataRequest
   * @returns QueryDocumentStatisticalDataResponse
   */
  async queryDocumentStatisticalData(request: QueryDocumentStatisticalDataRequest): Promise<QueryDocumentStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDocumentStatisticalDataHeaders({ });
    return await this.queryDocumentStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业钉盘统计数据
   * 
   * @param request - QueryDriveStatisticalDataRequest
   * @param headers - QueryDriveStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryDriveStatisticalDataResponse
   */
  async queryDriveStatisticalDataWithOptions(request: QueryDriveStatisticalDataRequest, headers: QueryDriveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryDriveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryDriveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/driveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryDriveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryDriveStatisticalDataResponse({}));
  }

  /**
   * 获取企业钉盘统计数据
   * 
   * @param request - QueryDriveStatisticalDataRequest
   * @returns QueryDriveStatisticalDataResponse
   */
  async queryDriveStatisticalData(request: QueryDriveStatisticalDataRequest): Promise<QueryDriveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryDriveStatisticalDataHeaders({ });
    return await this.queryDriveStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业员工类型统计数据
   * 
   * @param request - QueryEmployeeTypeStatisticalDataRequest
   * @param headers - QueryEmployeeTypeStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryEmployeeTypeStatisticalDataResponse
   */
  async queryEmployeeTypeStatisticalDataWithOptions(request: QueryEmployeeTypeStatisticalDataRequest, headers: QueryEmployeeTypeStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryEmployeeTypeStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryEmployeeTypeStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/employeeTypeData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryEmployeeTypeStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryEmployeeTypeStatisticalDataResponse({}));
  }

  /**
   * 获取企业员工类型统计数据
   * 
   * @param request - QueryEmployeeTypeStatisticalDataRequest
   * @returns QueryEmployeeTypeStatisticalDataResponse
   */
  async queryEmployeeTypeStatisticalData(request: QueryEmployeeTypeStatisticalDataRequest): Promise<QueryEmployeeTypeStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEmployeeTypeStatisticalDataHeaders({ });
    return await this.queryEmployeeTypeStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 数据资产平台数据服务接口
   * 
   * @param request - QueryGeneralDataServiceRequest
   * @param headers - QueryGeneralDataServiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGeneralDataServiceResponse
   */
  async queryGeneralDataServiceWithOptions(request: QueryGeneralDataServiceRequest, headers: QueryGeneralDataServiceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGeneralDataServiceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.endDate)) {
      query["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.serviceId)) {
      query["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.startDate)) {
      query["startDate"] = request.startDate;
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
      action: "QueryGeneralDataService",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/generalDataServices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGeneralDataServiceResponse>(await this.execute(params, req, runtime), new QueryGeneralDataServiceResponse({}));
  }

  /**
   * 数据资产平台数据服务接口
   * 
   * @param request - QueryGeneralDataServiceRequest
   * @returns QueryGeneralDataServiceResponse
   */
  async queryGeneralDataService(request: QueryGeneralDataServiceRequest): Promise<QueryGeneralDataServiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGeneralDataServiceHeaders({ });
    return await this.queryGeneralDataServiceWithOptions(request, headers, runtime);
  }

  /**
   * 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
   * 
   * @param request - QueryGeneralDataServiceBatchRequest
   * @param headers - QueryGeneralDataServiceBatchHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGeneralDataServiceBatchResponse
   */
  async queryGeneralDataServiceBatchWithOptions(request: QueryGeneralDataServiceBatchRequest, headers: QueryGeneralDataServiceBatchHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGeneralDataServiceBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.endDate)) {
      body["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.filters)) {
      body["filters"] = request.filters;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.serviceId)) {
      body["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.startDate)) {
      body["startDate"] = request.startDate;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "QueryGeneralDataServiceBatch",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dataServices/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGeneralDataServiceBatchResponse>(await this.execute(params, req, runtime), new QueryGeneralDataServiceBatchResponse({}));
  }

  /**
   * 数据资产平台数据服务接口(支持部门、员工维度批量拉取)
   * 
   * @param request - QueryGeneralDataServiceBatchRequest
   * @returns QueryGeneralDataServiceBatchResponse
   */
  async queryGeneralDataServiceBatch(request: QueryGeneralDataServiceBatchRequest): Promise<QueryGeneralDataServiceBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGeneralDataServiceBatchHeaders({ });
    return await this.queryGeneralDataServiceBatchWithOptions(request, headers, runtime);
  }

  /**
   * 数据资产平台数据服务接口(查询数据更新日期)
   * 
   * @param request - QueryGeneralDataUpdateDateRequest
   * @param headers - QueryGeneralDataUpdateDateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGeneralDataUpdateDateResponse
   */
  async queryGeneralDataUpdateDateWithOptions(request: QueryGeneralDataUpdateDateRequest, headers: QueryGeneralDataUpdateDateHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGeneralDataUpdateDateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.serviceId)) {
      query["serviceId"] = request.serviceId;
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
      action: "QueryGeneralDataUpdateDate",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dataUpdateDates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGeneralDataUpdateDateResponse>(await this.execute(params, req, runtime), new QueryGeneralDataUpdateDateResponse({}));
  }

  /**
   * 数据资产平台数据服务接口(查询数据更新日期)
   * 
   * @param request - QueryGeneralDataUpdateDateRequest
   * @returns QueryGeneralDataUpdateDateResponse
   */
  async queryGeneralDataUpdateDate(request: QueryGeneralDataUpdateDateRequest): Promise<QueryGeneralDataUpdateDateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGeneralDataUpdateDateHeaders({ });
    return await this.queryGeneralDataUpdateDateWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业群直播统计数据
   * 
   * @param request - QueryGroupLiveStatisticalDataRequest
   * @param headers - QueryGroupLiveStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupLiveStatisticalDataResponse
   */
  async queryGroupLiveStatisticalDataWithOptions(request: QueryGroupLiveStatisticalDataRequest, headers: QueryGroupLiveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupLiveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryGroupLiveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/groupLiveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupLiveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryGroupLiveStatisticalDataResponse({}));
  }

  /**
   * 获取企业群直播统计数据
   * 
   * @param request - QueryGroupLiveStatisticalDataRequest
   * @returns QueryGroupLiveStatisticalDataResponse
   */
  async queryGroupLiveStatisticalData(request: QueryGroupLiveStatisticalDataRequest): Promise<QueryGroupLiveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupLiveStatisticalDataHeaders({ });
    return await this.queryGroupLiveStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业群聊统计数据
   * 
   * @param request - QueryGroupMessageStatisticalDataRequest
   * @param headers - QueryGroupMessageStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupMessageStatisticalDataResponse
   */
  async queryGroupMessageStatisticalDataWithOptions(request: QueryGroupMessageStatisticalDataRequest, headers: QueryGroupMessageStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupMessageStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryGroupMessageStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/groupMessageData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupMessageStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryGroupMessageStatisticalDataResponse({}));
  }

  /**
   * 获取企业群聊统计数据
   * 
   * @param request - QueryGroupMessageStatisticalDataRequest
   * @returns QueryGroupMessageStatisticalDataResponse
   */
  async queryGroupMessageStatisticalData(request: QueryGroupMessageStatisticalDataRequest): Promise<QueryGroupMessageStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMessageStatisticalDataHeaders({ });
    return await this.queryGroupMessageStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业钉钉运动统计数据
   * 
   * @param request - QueryHealthStatisticalDataRequest
   * @param headers - QueryHealthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryHealthStatisticalDataResponse
   */
  async queryHealthStatisticalDataWithOptions(request: QueryHealthStatisticalDataRequest, headers: QueryHealthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryHealthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryHealthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/healtheUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryHealthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryHealthStatisticalDataResponse({}));
  }

  /**
   * 获取企业钉钉运动统计数据
   * 
   * @param request - QueryHealthStatisticalDataRequest
   * @returns QueryHealthStatisticalDataResponse
   */
  async queryHealthStatisticalData(request: QueryHealthStatisticalDataRequest): Promise<QueryHealthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryHealthStatisticalDataHeaders({ });
    return await this.queryHealthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业邮箱统计数据
   * 
   * @param request - QueryMailStatisticalDataRequest
   * @param headers - QueryMailStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMailStatisticalDataResponse
   */
  async queryMailStatisticalDataWithOptions(request: QueryMailStatisticalDataRequest, headers: QueryMailStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMailStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryMailStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/mailData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMailStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryMailStatisticalDataResponse({}));
  }

  /**
   * 获取企业邮箱统计数据
   * 
   * @param request - QueryMailStatisticalDataRequest
   * @returns QueryMailStatisticalDataResponse
   */
  async queryMailStatisticalData(request: QueryMailStatisticalDataRequest): Promise<QueryMailStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMailStatisticalDataHeaders({ });
    return await this.queryMailStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取官方数据集数据
   * 
   * @param request - QueryOfficialDataRequest
   * @param headers - QueryOfficialDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOfficialDataResponse
   */
  async queryOfficialDataWithOptions(request: QueryOfficialDataRequest, headers: QueryOfficialDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      query["param"] = request.param;
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
      action: "QueryOfficialData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialDataResponse>(await this.execute(params, req, runtime), new QueryOfficialDataResponse({}));
  }

  /**
   * 获取官方数据集数据
   * 
   * @param request - QueryOfficialDataRequest
   * @returns QueryOfficialDataResponse
   */
  async queryOfficialData(request: QueryOfficialDataRequest): Promise<QueryOfficialDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialDataHeaders({ });
    return await this.queryOfficialDataWithOptions(request, headers, runtime);
  }

  /**
   * ISV获取官方数据集字段信息
   * 
   * @param request - QueryOfficialDatasetFieldsRequest
   * @param headers - QueryOfficialDatasetFieldsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOfficialDatasetFieldsResponse
   */
  async queryOfficialDatasetFieldsWithOptions(request: QueryOfficialDatasetFieldsRequest, headers: QueryOfficialDatasetFieldsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialDatasetFieldsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dsId)) {
      query["dsId"] = request.dsId;
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
      action: "QueryOfficialDatasetFields",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datasetFields`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialDatasetFieldsResponse>(await this.execute(params, req, runtime), new QueryOfficialDatasetFieldsResponse({}));
  }

  /**
   * ISV获取官方数据集字段信息
   * 
   * @param request - QueryOfficialDatasetFieldsRequest
   * @returns QueryOfficialDatasetFieldsResponse
   */
  async queryOfficialDatasetFields(request: QueryOfficialDatasetFieldsRequest): Promise<QueryOfficialDatasetFieldsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialDatasetFieldsHeaders({ });
    return await this.queryOfficialDatasetFieldsWithOptions(request, headers, runtime);
  }

  /**
   * ISV获取官方数据集列表
   * 
   * @param request - QueryOfficialDatasetListRequest
   * @param headers - QueryOfficialDatasetListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOfficialDatasetListResponse
   */
  async queryOfficialDatasetListWithOptions(request: QueryOfficialDatasetListRequest, headers: QueryOfficialDatasetListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialDatasetListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      query["keyword"] = request.keyword;
    }

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
      action: "QueryOfficialDatasetList",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datasetLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialDatasetListResponse>(await this.execute(params, req, runtime), new QueryOfficialDatasetListResponse({}));
  }

  /**
   * ISV获取官方数据集列表
   * 
   * @param request - QueryOfficialDatasetListRequest
   * @returns QueryOfficialDatasetListResponse
   */
  async queryOfficialDatasetList(request: QueryOfficialDatasetListRequest): Promise<QueryOfficialDatasetListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialDatasetListHeaders({ });
    return await this.queryOfficialDatasetListWithOptions(request, headers, runtime);
  }

  /**
   * 获取官方数据集数据
   * 
   * @param request - QueryOfficialFormDataRequest
   * @param headers - QueryOfficialFormDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOfficialFormDataResponse
   */
  async queryOfficialFormDataWithOptions(request: QueryOfficialFormDataRequest, headers: QueryOfficialFormDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialFormDataResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "QueryOfficialFormData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialFormDataResponse>(await this.execute(params, req, runtime), new QueryOfficialFormDataResponse({}));
  }

  /**
   * 获取官方数据集数据
   * 
   * @param request - QueryOfficialFormDataRequest
   * @returns QueryOfficialFormDataResponse
   */
  async queryOfficialFormData(request: QueryOfficialFormDataRequest): Promise<QueryOfficialFormDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialFormDataHeaders({ });
    return await this.queryOfficialFormDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取HOLO中官方OA表单数据集数据
   * 
   * @param request - QueryOfficialFormDataDirectHoloRequest
   * @param headers - QueryOfficialFormDataDirectHoloHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOfficialFormDataDirectHoloResponse
   */
  async queryOfficialFormDataDirectHoloWithOptions(request: QueryOfficialFormDataDirectHoloRequest, headers: QueryOfficialFormDataDirectHoloHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOfficialFormDataDirectHoloResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.param)) {
      body["param"] = request.param;
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
      action: "QueryOfficialFormDataDirectHolo",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/oaDatas/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOfficialFormDataDirectHoloResponse>(await this.execute(params, req, runtime), new QueryOfficialFormDataDirectHoloResponse({}));
  }

  /**
   * 获取HOLO中官方OA表单数据集数据
   * 
   * @param request - QueryOfficialFormDataDirectHoloRequest
   * @returns QueryOfficialFormDataDirectHoloResponse
   */
  async queryOfficialFormDataDirectHolo(request: QueryOfficialFormDataDirectHoloRequest): Promise<QueryOfficialFormDataDirectHoloResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOfficialFormDataDirectHoloHeaders({ });
    return await this.queryOfficialFormDataDirectHoloWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业用户在线统计数据
   * 
   * @param request - QueryOnlineUserStatisticalDataRequest
   * @param headers - QueryOnlineUserStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOnlineUserStatisticalDataResponse
   */
  async queryOnlineUserStatisticalDataWithOptions(request: QueryOnlineUserStatisticalDataRequest, headers: QueryOnlineUserStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOnlineUserStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryOnlineUserStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/onlineUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOnlineUserStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryOnlineUserStatisticalDataResponse({}));
  }

  /**
   * 获取企业用户在线统计数据
   * 
   * @param request - QueryOnlineUserStatisticalDataRequest
   * @returns QueryOnlineUserStatisticalDataResponse
   */
  async queryOnlineUserStatisticalData(request: QueryOnlineUserStatisticalDataRequest): Promise<QueryOnlineUserStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOnlineUserStatisticalDataHeaders({ });
    return await this.queryOnlineUserStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业接收红包统计数据
   * 
   * @param request - QueryRedEnvelopeReciveStatisticalDataRequest
   * @param headers - QueryRedEnvelopeReciveStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRedEnvelopeReciveStatisticalDataResponse
   */
  async queryRedEnvelopeReciveStatisticalDataWithOptions(request: QueryRedEnvelopeReciveStatisticalDataRequest, headers: QueryRedEnvelopeReciveStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRedEnvelopeReciveStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryRedEnvelopeReciveStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/redEnvelopeReciveData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRedEnvelopeReciveStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryRedEnvelopeReciveStatisticalDataResponse({}));
  }

  /**
   * 获取企业接收红包统计数据
   * 
   * @param request - QueryRedEnvelopeReciveStatisticalDataRequest
   * @returns QueryRedEnvelopeReciveStatisticalDataResponse
   */
  async queryRedEnvelopeReciveStatisticalData(request: QueryRedEnvelopeReciveStatisticalDataRequest): Promise<QueryRedEnvelopeReciveStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRedEnvelopeReciveStatisticalDataHeaders({ });
    return await this.queryRedEnvelopeReciveStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业发送红包统计数据
   * 
   * @param request - QueryRedEnvelopeSendStatisticalDataRequest
   * @param headers - QueryRedEnvelopeSendStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRedEnvelopeSendStatisticalDataResponse
   */
  async queryRedEnvelopeSendStatisticalDataWithOptions(request: QueryRedEnvelopeSendStatisticalDataRequest, headers: QueryRedEnvelopeSendStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRedEnvelopeSendStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryRedEnvelopeSendStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/redEnvelopeSendData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRedEnvelopeSendStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryRedEnvelopeSendStatisticalDataResponse({}));
  }

  /**
   * 获取企业发送红包统计数据
   * 
   * @param request - QueryRedEnvelopeSendStatisticalDataRequest
   * @returns QueryRedEnvelopeSendStatisticalDataResponse
   */
  async queryRedEnvelopeSendStatisticalData(request: QueryRedEnvelopeSendStatisticalDataRequest): Promise<QueryRedEnvelopeSendStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRedEnvelopeSendStatisticalDataHeaders({ });
    return await this.queryRedEnvelopeSendStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业日志统计数据
   * 
   * @param request - QueryReportStatisticalDataRequest
   * @param headers - QueryReportStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryReportStatisticalDataResponse
   */
  async queryReportStatisticalDataWithOptions(request: QueryReportStatisticalDataRequest, headers: QueryReportStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReportStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryReportStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/reportData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryReportStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryReportStatisticalDataResponse({}));
  }

  /**
   * 获取企业日志统计数据
   * 
   * @param request - QueryReportStatisticalDataRequest
   * @returns QueryReportStatisticalDataResponse
   */
  async queryReportStatisticalData(request: QueryReportStatisticalDataRequest): Promise<QueryReportStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReportStatisticalDataHeaders({ });
    return await this.queryReportStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 查询数据大屏
   * 
   * @param request - QueryScreenRequest
   * @param headers - QueryScreenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryScreenResponse
   */
  async queryScreenWithOptions(request: QueryScreenRequest, headers: QueryScreenHeaders, runtime: $Util.RuntimeOptions): Promise<QueryScreenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
      action: "QueryScreen",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/screens`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryScreenResponse>(await this.execute(params, req, runtime), new QueryScreenResponse({}));
  }

  /**
   * 查询数据大屏
   * 
   * @param request - QueryScreenRequest
   * @returns QueryScreenResponse
   */
  async queryScreen(request: QueryScreenRequest): Promise<QueryScreenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScreenHeaders({ });
    return await this.queryScreenWithOptions(request, headers, runtime);
  }

  /**
   * 查询数据大屏模版
   * 
   * @param request - QueryScreenTemplateRequest
   * @param headers - QueryScreenTemplateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryScreenTemplateResponse
   */
  async queryScreenTemplateWithOptions(request: QueryScreenTemplateRequest, headers: QueryScreenTemplateHeaders, runtime: $Util.RuntimeOptions): Promise<QueryScreenTemplateResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.sample)) {
      query["sample"] = request.sample;
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
      action: "QueryScreenTemplate",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/screenTemplates`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryScreenTemplateResponse>(await this.execute(params, req, runtime), new QueryScreenTemplateResponse({}));
  }

  /**
   * 查询数据大屏模版
   * 
   * @param request - QueryScreenTemplateRequest
   * @returns QueryScreenTemplateResponse
   */
  async queryScreenTemplate(request: QueryScreenTemplateRequest): Promise<QueryScreenTemplateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScreenTemplateHeaders({ });
    return await this.queryScreenTemplateWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业单聊统计数据
   * 
   * @param request - QuerySingleMessageStatisticalDataRequest
   * @param headers - QuerySingleMessageStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySingleMessageStatisticalDataResponse
   */
  async querySingleMessageStatisticalDataWithOptions(request: QuerySingleMessageStatisticalDataRequest, headers: QuerySingleMessageStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySingleMessageStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QuerySingleMessageStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/singleMessagerData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySingleMessageStatisticalDataResponse>(await this.execute(params, req, runtime), new QuerySingleMessageStatisticalDataResponse({}));
  }

  /**
   * 获取企业单聊统计数据
   * 
   * @param request - QuerySingleMessageStatisticalDataRequest
   * @returns QuerySingleMessageStatisticalDataResponse
   */
  async querySingleMessageStatisticalData(request: QuerySingleMessageStatisticalDataRequest): Promise<QuerySingleMessageStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySingleMessageStatisticalDataHeaders({ });
    return await this.querySingleMessageStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业电话会议统计数据
   * 
   * @param request - QueryTelMeetingStatisticalDataRequest
   * @param headers - QueryTelMeetingStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryTelMeetingStatisticalDataResponse
   */
  async queryTelMeetingStatisticalDataWithOptions(request: QueryTelMeetingStatisticalDataRequest, headers: QueryTelMeetingStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTelMeetingStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryTelMeetingStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/telMeetingData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryTelMeetingStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryTelMeetingStatisticalDataResponse({}));
  }

  /**
   * 获取企业电话会议统计数据
   * 
   * @param request - QueryTelMeetingStatisticalDataRequest
   * @returns QueryTelMeetingStatisticalDataResponse
   */
  async queryTelMeetingStatisticalData(request: QueryTelMeetingStatisticalDataRequest): Promise<QueryTelMeetingStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTelMeetingStatisticalDataHeaders({ });
    return await this.queryTelMeetingStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业待办统计数据
   * 
   * @param request - QueryTodoStatisticalDataRequest
   * @param headers - QueryTodoStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryTodoStatisticalDataResponse
   */
  async queryTodoStatisticalDataWithOptions(request: QueryTodoStatisticalDataRequest, headers: QueryTodoStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTodoStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryTodoStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/todoUserData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryTodoStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryTodoStatisticalDataResponse({}));
  }

  /**
   * 获取企业待办统计数据
   * 
   * @param request - QueryTodoStatisticalDataRequest
   * @returns QueryTodoStatisticalDataResponse
   */
  async queryTodoStatisticalData(request: QueryTodoStatisticalDataRequest): Promise<QueryTodoStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTodoStatisticalDataHeaders({ });
    return await this.queryTodoStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 数据资产平台查询数据记录数
   * 
   * @param request - QueryTotalDataCountServiceRequest
   * @param headers - QueryTotalDataCountServiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryTotalDataCountServiceResponse
   */
  async queryTotalDataCountServiceWithOptions(request: QueryTotalDataCountServiceRequest, headers: QueryTotalDataCountServiceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTotalDataCountServiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptIds)) {
      body["deptIds"] = request.deptIds;
    }

    if (!Util.isUnset(request.endDate)) {
      body["endDate"] = request.endDate;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.serviceId)) {
      body["serviceId"] = request.serviceId;
    }

    if (!Util.isUnset(request.startDate)) {
      body["startDate"] = request.startDate;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
      action: "QueryTotalDataCountService",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/datas/totalCounts/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryTotalDataCountServiceResponse>(await this.execute(params, req, runtime), new QueryTotalDataCountServiceResponse({}));
  }

  /**
   * 数据资产平台查询数据记录数
   * 
   * @param request - QueryTotalDataCountServiceRequest
   * @returns QueryTotalDataCountServiceResponse
   */
  async queryTotalDataCountService(request: QueryTotalDataCountServiceRequest): Promise<QueryTotalDataCountServiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTotalDataCountServiceHeaders({ });
    return await this.queryTotalDataCountServiceWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业视频会议统计数据
   * 
   * @param request - QueryVedioMeetingStatisticalDataRequest
   * @param headers - QueryVedioMeetingStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryVedioMeetingStatisticalDataResponse
   */
  async queryVedioMeetingStatisticalDataWithOptions(request: QueryVedioMeetingStatisticalDataRequest, headers: QueryVedioMeetingStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryVedioMeetingStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryVedioMeetingStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/vedioMeetingData`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryVedioMeetingStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryVedioMeetingStatisticalDataResponse({}));
  }

  /**
   * 获取企业视频会议统计数据
   * 
   * @param request - QueryVedioMeetingStatisticalDataRequest
   * @returns QueryVedioMeetingStatisticalDataResponse
   */
  async queryVedioMeetingStatisticalData(request: QueryVedioMeetingStatisticalDataRequest): Promise<QueryVedioMeetingStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryVedioMeetingStatisticalDataHeaders({ });
    return await this.queryVedioMeetingStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉参谋活跃分析（按日统计）指标接口
   * 
   * @param request - QueryYydActiveDayStatisticalDataRequest
   * @param headers - QueryYydActiveDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydActiveDayStatisticalDataResponse
   */
  async queryYydActiveDayStatisticalDataWithOptions(request: QueryYydActiveDayStatisticalDataRequest, headers: QueryYydActiveDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydActiveDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydActiveDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydActiveDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydActiveDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydActiveDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉参谋活跃分析（按日统计）指标接口
   * 
   * @param request - QueryYydActiveDayStatisticalDataRequest
   * @returns QueryYydActiveDayStatisticalDataResponse
   */
  async queryYydActiveDayStatisticalData(request: QueryYydActiveDayStatisticalDataRequest): Promise<QueryYydActiveDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveDayStatisticalDataHeaders({ });
    return await this.queryYydActiveDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉参谋活跃分析（按月统计）指标接口
   * 
   * @param request - QueryYydActiveMonthStatisticalDataRequest
   * @param headers - QueryYydActiveMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydActiveMonthStatisticalDataResponse
   */
  async queryYydActiveMonthStatisticalDataWithOptions(request: QueryYydActiveMonthStatisticalDataRequest, headers: QueryYydActiveMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydActiveMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydActiveMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydActiveMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydActiveMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydActiveMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉参谋活跃分析（按月统计）指标接口
   * 
   * @param request - QueryYydActiveMonthStatisticalDataRequest
   * @returns QueryYydActiveMonthStatisticalDataResponse
   */
  async queryYydActiveMonthStatisticalData(request: QueryYydActiveMonthStatisticalDataRequest): Promise<QueryYydActiveMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveMonthStatisticalDataHeaders({ });
    return await this.queryYydActiveMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉参谋活跃分析（按周统计）指标接口
   * 
   * @param request - QueryYydActiveWeekStatisticalDataRequest
   * @param headers - QueryYydActiveWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydActiveWeekStatisticalDataResponse
   */
  async queryYydActiveWeekStatisticalDataWithOptions(request: QueryYydActiveWeekStatisticalDataRequest, headers: QueryYydActiveWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydActiveWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydActiveWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydActiveWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydActiveWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydActiveWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉参谋活跃分析（按周统计）指标接口
   * 
   * @param request - QueryYydActiveWeekStatisticalDataRequest
   * @returns QueryYydActiveWeekStatisticalDataResponse
   */
  async queryYydActiveWeekStatisticalData(request: QueryYydActiveWeekStatisticalDataRequest): Promise<QueryYydActiveWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydActiveWeekStatisticalDataHeaders({ });
    return await this.queryYydActiveWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋应用概况（按日统计）指标接口
   * 
   * @param request - QueryYydAppDayStatisticalDataRequest
   * @param headers - QueryYydAppDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydAppDayStatisticalDataResponse
   */
  async queryYydAppDayStatisticalDataWithOptions(request: QueryYydAppDayStatisticalDataRequest, headers: QueryYydAppDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydAppDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋应用概况（按日统计）指标接口
   * 
   * @param request - QueryYydAppDayStatisticalDataRequest
   * @returns QueryYydAppDayStatisticalDataResponse
   */
  async queryYydAppDayStatisticalData(request: QueryYydAppDayStatisticalDataRequest): Promise<QueryYydAppDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppDayStatisticalDataHeaders({ });
    return await this.queryYydAppDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋应用概况（按月统计）指标接口
   * 
   * @param request - QueryYydAppMonthStatisticalDataRequest
   * @param headers - QueryYydAppMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydAppMonthStatisticalDataResponse
   */
  async queryYydAppMonthStatisticalDataWithOptions(request: QueryYydAppMonthStatisticalDataRequest, headers: QueryYydAppMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydAppMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋应用概况（按月统计）指标接口
   * 
   * @param request - QueryYydAppMonthStatisticalDataRequest
   * @returns QueryYydAppMonthStatisticalDataResponse
   */
  async queryYydAppMonthStatisticalData(request: QueryYydAppMonthStatisticalDataRequest): Promise<QueryYydAppMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppMonthStatisticalDataHeaders({ });
    return await this.queryYydAppMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋应用概况（累计）指标接口
   * 
   * @param request - QueryYydAppStdStatisticalDataRequest
   * @param headers - QueryYydAppStdStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydAppStdStatisticalDataResponse
   */
  async queryYydAppStdStatisticalDataWithOptions(request: QueryYydAppStdStatisticalDataRequest, headers: QueryYydAppStdStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppStdStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydAppStdStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppStdDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppStdStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppStdStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋应用概况（累计）指标接口
   * 
   * @param request - QueryYydAppStdStatisticalDataRequest
   * @returns QueryYydAppStdStatisticalDataResponse
   */
  async queryYydAppStdStatisticalData(request: QueryYydAppStdStatisticalDataRequest): Promise<QueryYydAppStdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppStdStatisticalDataHeaders({ });
    return await this.queryYydAppStdStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋应用概况（按周统计）指标接口
   * 
   * @param request - QueryYydAppWeekStatisticalDataRequest
   * @param headers - QueryYydAppWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydAppWeekStatisticalDataResponse
   */
  async queryYydAppWeekStatisticalDataWithOptions(request: QueryYydAppWeekStatisticalDataRequest, headers: QueryYydAppWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydAppWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydAppWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydAppWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydAppWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydAppWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋应用概况（按周统计）指标接口
   * 
   * @param request - QueryYydAppWeekStatisticalDataRequest
   * @returns QueryYydAppWeekStatisticalDataResponse
   */
  async queryYydAppWeekStatisticalData(request: QueryYydAppWeekStatisticalDataRequest): Promise<QueryYydAppWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydAppWeekStatisticalDataHeaders({ });
    return await this.queryYydAppWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋会议日程分析（按日统计）指标接口
   * 
   * @param request - QueryYydCalendarDayStatisticalDataRequest
   * @param headers - QueryYydCalendarDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydCalendarDayStatisticalDataResponse
   */
  async queryYydCalendarDayStatisticalDataWithOptions(request: QueryYydCalendarDayStatisticalDataRequest, headers: QueryYydCalendarDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydCalendarDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydCalendarDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydCalendarDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydCalendarDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydCalendarDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋会议日程分析（按日统计）指标接口
   * 
   * @param request - QueryYydCalendarDayStatisticalDataRequest
   * @returns QueryYydCalendarDayStatisticalDataResponse
   */
  async queryYydCalendarDayStatisticalData(request: QueryYydCalendarDayStatisticalDataRequest): Promise<QueryYydCalendarDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarDayStatisticalDataHeaders({ });
    return await this.queryYydCalendarDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋会议日程分析（按月统计）指标接口
   * 
   * @param request - QueryYydCalendarMonthStatisticalDataRequest
   * @param headers - QueryYydCalendarMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydCalendarMonthStatisticalDataResponse
   */
  async queryYydCalendarMonthStatisticalDataWithOptions(request: QueryYydCalendarMonthStatisticalDataRequest, headers: QueryYydCalendarMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydCalendarMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydCalendarMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydCalendarMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydCalendarMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydCalendarMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋会议日程分析（按月统计）指标接口
   * 
   * @param request - QueryYydCalendarMonthStatisticalDataRequest
   * @returns QueryYydCalendarMonthStatisticalDataResponse
   */
  async queryYydCalendarMonthStatisticalData(request: QueryYydCalendarMonthStatisticalDataRequest): Promise<QueryYydCalendarMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarMonthStatisticalDataHeaders({ });
    return await this.queryYydCalendarMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋会议日程分析（按周统计）指标接口
   * 
   * @param request - QueryYydCalendarWeekStatisticalDataRequest
   * @param headers - QueryYydCalendarWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydCalendarWeekStatisticalDataResponse
   */
  async queryYydCalendarWeekStatisticalDataWithOptions(request: QueryYydCalendarWeekStatisticalDataRequest, headers: QueryYydCalendarWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydCalendarWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydCalendarWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydCalendarWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydCalendarWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydCalendarWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋会议日程分析（按周统计）指标接口
   * 
   * @param request - QueryYydCalendarWeekStatisticalDataRequest
   * @returns QueryYydCalendarWeekStatisticalDataResponse
   */
  async queryYydCalendarWeekStatisticalData(request: QueryYydCalendarWeekStatisticalDataRequest): Promise<QueryYydCalendarWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydCalendarWeekStatisticalDataHeaders({ });
    return await this.queryYydCalendarWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋钉消息分析（按日统计）指标接口
   * 
   * @param request - QueryYydDingMsgDayStatisticalDataRequest
   * @param headers - QueryYydDingMsgDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydDingMsgDayStatisticalDataResponse
   */
  async queryYydDingMsgDayStatisticalDataWithOptions(request: QueryYydDingMsgDayStatisticalDataRequest, headers: QueryYydDingMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydDingMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydDingMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydDingMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydDingMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydDingMsgDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋钉消息分析（按日统计）指标接口
   * 
   * @param request - QueryYydDingMsgDayStatisticalDataRequest
   * @returns QueryYydDingMsgDayStatisticalDataResponse
   */
  async queryYydDingMsgDayStatisticalData(request: QueryYydDingMsgDayStatisticalDataRequest): Promise<QueryYydDingMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgDayStatisticalDataHeaders({ });
    return await this.queryYydDingMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋钉消息分析（按月统计）指标接口
   * 
   * @param request - QueryYydDingMsgMonthStatisticalDataRequest
   * @param headers - QueryYydDingMsgMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydDingMsgMonthStatisticalDataResponse
   */
  async queryYydDingMsgMonthStatisticalDataWithOptions(request: QueryYydDingMsgMonthStatisticalDataRequest, headers: QueryYydDingMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydDingMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydDingMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydDingMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydDingMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydDingMsgMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋钉消息分析（按月统计）指标接口
   * 
   * @param request - QueryYydDingMsgMonthStatisticalDataRequest
   * @returns QueryYydDingMsgMonthStatisticalDataResponse
   */
  async queryYydDingMsgMonthStatisticalData(request: QueryYydDingMsgMonthStatisticalDataRequest): Promise<QueryYydDingMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydDingMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋钉消息分析（按周统计）指标接口
   * 
   * @param request - QueryYydDingMsgWeekStatisticalDataRequest
   * @param headers - QueryYydDingMsgWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydDingMsgWeekStatisticalDataResponse
   */
  async queryYydDingMsgWeekStatisticalDataWithOptions(request: QueryYydDingMsgWeekStatisticalDataRequest, headers: QueryYydDingMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydDingMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydDingMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydDingMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydDingMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydDingMsgWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋钉消息分析（按周统计）指标接口
   * 
   * @param request - QueryYydDingMsgWeekStatisticalDataRequest
   * @returns QueryYydDingMsgWeekStatisticalDataResponse
   */
  async queryYydDingMsgWeekStatisticalData(request: QueryYydDingMsgWeekStatisticalDataRequest): Promise<QueryYydDingMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydDingMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydDingMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋群聊分析（按日统计）指标接口
   * 
   * @param request - QueryYydGroupMsgDayStatisticalDataRequest
   * @param headers - QueryYydGroupMsgDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydGroupMsgDayStatisticalDataResponse
   */
  async queryYydGroupMsgDayStatisticalDataWithOptions(request: QueryYydGroupMsgDayStatisticalDataRequest, headers: QueryYydGroupMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydGroupMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydGroupMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydGroupMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydGroupMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydGroupMsgDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋群聊分析（按日统计）指标接口
   * 
   * @param request - QueryYydGroupMsgDayStatisticalDataRequest
   * @returns QueryYydGroupMsgDayStatisticalDataResponse
   */
  async queryYydGroupMsgDayStatisticalData(request: QueryYydGroupMsgDayStatisticalDataRequest): Promise<QueryYydGroupMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgDayStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋群聊分析（按月统计）指标接口
   * 
   * @param request - QueryYydGroupMsgMonthStatisticalDataRequest
   * @param headers - QueryYydGroupMsgMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydGroupMsgMonthStatisticalDataResponse
   */
  async queryYydGroupMsgMonthStatisticalDataWithOptions(request: QueryYydGroupMsgMonthStatisticalDataRequest, headers: QueryYydGroupMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydGroupMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydGroupMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydGroupMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydGroupMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydGroupMsgMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋群聊分析（按月统计）指标接口
   * 
   * @param request - QueryYydGroupMsgMonthStatisticalDataRequest
   * @returns QueryYydGroupMsgMonthStatisticalDataResponse
   */
  async queryYydGroupMsgMonthStatisticalData(request: QueryYydGroupMsgMonthStatisticalDataRequest): Promise<QueryYydGroupMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋群聊分析（按周统计）指标接口
   * 
   * @param request - QueryYydGroupMsgWeekStatisticalDataRequest
   * @param headers - QueryYydGroupMsgWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydGroupMsgWeekStatisticalDataResponse
   */
  async queryYydGroupMsgWeekStatisticalDataWithOptions(request: QueryYydGroupMsgWeekStatisticalDataRequest, headers: QueryYydGroupMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydGroupMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydGroupMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydGroupMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydGroupMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydGroupMsgWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋群聊分析（按周统计）指标接口
   * 
   * @param request - QueryYydGroupMsgWeekStatisticalDataRequest
   * @returns QueryYydGroupMsgWeekStatisticalDataResponse
   */
  async queryYydGroupMsgWeekStatisticalData(request: QueryYydGroupMsgWeekStatisticalDataRequest): Promise<QueryYydGroupMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydGroupMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydGroupMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋日志分析（按日统计）指标接口
   * 
   * @param request - QueryYydLogDayStatisticalDataRequest
   * @param headers - QueryYydLogDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydLogDayStatisticalDataResponse
   */
  async queryYydLogDayStatisticalDataWithOptions(request: QueryYydLogDayStatisticalDataRequest, headers: QueryYydLogDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydLogDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydLogDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydLogDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydLogDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydLogDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋日志分析（按日统计）指标接口
   * 
   * @param request - QueryYydLogDayStatisticalDataRequest
   * @returns QueryYydLogDayStatisticalDataResponse
   */
  async queryYydLogDayStatisticalData(request: QueryYydLogDayStatisticalDataRequest): Promise<QueryYydLogDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogDayStatisticalDataHeaders({ });
    return await this.queryYydLogDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋日志分析（按月统计）指标接口
   * 
   * @param request - QueryYydLogMonthStatisticalDataRequest
   * @param headers - QueryYydLogMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydLogMonthStatisticalDataResponse
   */
  async queryYydLogMonthStatisticalDataWithOptions(request: QueryYydLogMonthStatisticalDataRequest, headers: QueryYydLogMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydLogMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydLogMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydLogMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydLogMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydLogMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋日志分析（按月统计）指标接口
   * 
   * @param request - QueryYydLogMonthStatisticalDataRequest
   * @returns QueryYydLogMonthStatisticalDataResponse
   */
  async queryYydLogMonthStatisticalData(request: QueryYydLogMonthStatisticalDataRequest): Promise<QueryYydLogMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogMonthStatisticalDataHeaders({ });
    return await this.queryYydLogMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋日志分析（按周统计）指标接口
   * 
   * @param request - QueryYydLogWeekStatisticalDataRequest
   * @param headers - QueryYydLogWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydLogWeekStatisticalDataResponse
   */
  async queryYydLogWeekStatisticalDataWithOptions(request: QueryYydLogWeekStatisticalDataRequest, headers: QueryYydLogWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydLogWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydLogWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydLogWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydLogWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydLogWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋日志分析（按周统计）指标接口
   * 
   * @param request - QueryYydLogWeekStatisticalDataRequest
   * @returns QueryYydLogWeekStatisticalDataResponse
   */
  async queryYydLogWeekStatisticalData(request: QueryYydLogWeekStatisticalDataRequest): Promise<QueryYydLogWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydLogWeekStatisticalDataHeaders({ });
    return await this.queryYydLogWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋钉会议分析（按日统计）指标接口
   * 
   * @param request - QueryYydMeetingDayStatisticalDataRequest
   * @param headers - QueryYydMeetingDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydMeetingDayStatisticalDataResponse
   */
  async queryYydMeetingDayStatisticalDataWithOptions(request: QueryYydMeetingDayStatisticalDataRequest, headers: QueryYydMeetingDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydMeetingDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydMeetingDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydMeetingDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydMeetingDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydMeetingDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋钉会议分析（按日统计）指标接口
   * 
   * @param request - QueryYydMeetingDayStatisticalDataRequest
   * @returns QueryYydMeetingDayStatisticalDataResponse
   */
  async queryYydMeetingDayStatisticalData(request: QueryYydMeetingDayStatisticalDataRequest): Promise<QueryYydMeetingDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingDayStatisticalDataHeaders({ });
    return await this.queryYydMeetingDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋钉会议分析（按月统计）指标接口
   * 
   * @param request - QueryYydMeetingMonthStatisticalDataRequest
   * @param headers - QueryYydMeetingMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydMeetingMonthStatisticalDataResponse
   */
  async queryYydMeetingMonthStatisticalDataWithOptions(request: QueryYydMeetingMonthStatisticalDataRequest, headers: QueryYydMeetingMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydMeetingMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydMeetingMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydMeetingMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydMeetingMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydMeetingMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋钉会议分析（按月统计）指标接口
   * 
   * @param request - QueryYydMeetingMonthStatisticalDataRequest
   * @returns QueryYydMeetingMonthStatisticalDataResponse
   */
  async queryYydMeetingMonthStatisticalData(request: QueryYydMeetingMonthStatisticalDataRequest): Promise<QueryYydMeetingMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingMonthStatisticalDataHeaders({ });
    return await this.queryYydMeetingMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋钉会议分析（按周统计）指标接口
   * 
   * @param request - QueryYydMeetingWeekStatisticalDataRequest
   * @param headers - QueryYydMeetingWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydMeetingWeekStatisticalDataResponse
   */
  async queryYydMeetingWeekStatisticalDataWithOptions(request: QueryYydMeetingWeekStatisticalDataRequest, headers: QueryYydMeetingWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydMeetingWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydMeetingWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydMeetingWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydMeetingWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydMeetingWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋钉会议分析（按周统计）指标接口
   * 
   * @param request - QueryYydMeetingWeekStatisticalDataRequest
   * @returns QueryYydMeetingWeekStatisticalDataResponse
   */
  async queryYydMeetingWeekStatisticalData(request: QueryYydMeetingWeekStatisticalDataRequest): Promise<QueryYydMeetingWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydMeetingWeekStatisticalDataHeaders({ });
    return await this.queryYydMeetingWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋通知分析（按日统计）指标接口
   * 
   * @param request - QueryYydNoticeDayStatisticalDataRequest
   * @param headers - QueryYydNoticeDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydNoticeDayStatisticalDataResponse
   */
  async queryYydNoticeDayStatisticalDataWithOptions(request: QueryYydNoticeDayStatisticalDataRequest, headers: QueryYydNoticeDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydNoticeDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydNoticeDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydNoticeDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydNoticeDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydNoticeDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋通知分析（按日统计）指标接口
   * 
   * @param request - QueryYydNoticeDayStatisticalDataRequest
   * @returns QueryYydNoticeDayStatisticalDataResponse
   */
  async queryYydNoticeDayStatisticalData(request: QueryYydNoticeDayStatisticalDataRequest): Promise<QueryYydNoticeDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeDayStatisticalDataHeaders({ });
    return await this.queryYydNoticeDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋通知分析（按月统计）指标接口
   * 
   * @param request - QueryYydNoticeMonthStatisticalDataRequest
   * @param headers - QueryYydNoticeMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydNoticeMonthStatisticalDataResponse
   */
  async queryYydNoticeMonthStatisticalDataWithOptions(request: QueryYydNoticeMonthStatisticalDataRequest, headers: QueryYydNoticeMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydNoticeMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydNoticeMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydNoticeMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydNoticeMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydNoticeMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋通知分析（按月统计）指标接口
   * 
   * @param request - QueryYydNoticeMonthStatisticalDataRequest
   * @returns QueryYydNoticeMonthStatisticalDataResponse
   */
  async queryYydNoticeMonthStatisticalData(request: QueryYydNoticeMonthStatisticalDataRequest): Promise<QueryYydNoticeMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeMonthStatisticalDataHeaders({ });
    return await this.queryYydNoticeMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋通知分析（按周统计）指标接口
   * 
   * @param request - QueryYydNoticeWeekStatisticalDataRequest
   * @param headers - QueryYydNoticeWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydNoticeWeekStatisticalDataResponse
   */
  async queryYydNoticeWeekStatisticalDataWithOptions(request: QueryYydNoticeWeekStatisticalDataRequest, headers: QueryYydNoticeWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydNoticeWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydNoticeWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydNoticeWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydNoticeWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydNoticeWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋通知分析（按周统计）指标接口
   * 
   * @param request - QueryYydNoticeWeekStatisticalDataRequest
   * @returns QueryYydNoticeWeekStatisticalDataResponse
   */
  async queryYydNoticeWeekStatisticalData(request: QueryYydNoticeWeekStatisticalDataRequest): Promise<QueryYydNoticeWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydNoticeWeekStatisticalDataHeaders({ });
    return await this.queryYydNoticeWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋单聊分析（按日统计）指标接口
   * 
   * @param request - QueryYydSingleMsgDayStatisticalDataRequest
   * @param headers - QueryYydSingleMsgDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydSingleMsgDayStatisticalDataResponse
   */
  async queryYydSingleMsgDayStatisticalDataWithOptions(request: QueryYydSingleMsgDayStatisticalDataRequest, headers: QueryYydSingleMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydSingleMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydSingleMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydSingleMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydSingleMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydSingleMsgDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋单聊分析（按日统计）指标接口
   * 
   * @param request - QueryYydSingleMsgDayStatisticalDataRequest
   * @returns QueryYydSingleMsgDayStatisticalDataResponse
   */
  async queryYydSingleMsgDayStatisticalData(request: QueryYydSingleMsgDayStatisticalDataRequest): Promise<QueryYydSingleMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgDayStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋单聊分析（按月统计）指标接口
   * 
   * @param request - QueryYydSingleMsgMonthStatisticalDataRequest
   * @param headers - QueryYydSingleMsgMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydSingleMsgMonthStatisticalDataResponse
   */
  async queryYydSingleMsgMonthStatisticalDataWithOptions(request: QueryYydSingleMsgMonthStatisticalDataRequest, headers: QueryYydSingleMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydSingleMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydSingleMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydSingleMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydSingleMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydSingleMsgMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋单聊分析（按月统计）指标接口
   * 
   * @param request - QueryYydSingleMsgMonthStatisticalDataRequest
   * @returns QueryYydSingleMsgMonthStatisticalDataResponse
   */
  async queryYydSingleMsgMonthStatisticalData(request: QueryYydSingleMsgMonthStatisticalDataRequest): Promise<QueryYydSingleMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋单聊分析（按周统计）指标接口
   * 
   * @param request - QueryYydSingleMsgWeekStatisticalDataRequest
   * @param headers - QueryYydSingleMsgWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydSingleMsgWeekStatisticalDataResponse
   */
  async queryYydSingleMsgWeekStatisticalDataWithOptions(request: QueryYydSingleMsgWeekStatisticalDataRequest, headers: QueryYydSingleMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydSingleMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydSingleMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydSingleMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydSingleMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydSingleMsgWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋单聊分析（按周统计）指标接口
   * 
   * @param request - QueryYydSingleMsgWeekStatisticalDataRequest
   * @returns QueryYydSingleMsgWeekStatisticalDataResponse
   */
  async queryYydSingleMsgWeekStatisticalData(request: QueryYydSingleMsgWeekStatisticalDataRequest): Promise<QueryYydSingleMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydSingleMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydSingleMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋消息概览（按日统计）指标接口
   * 
   * @param request - QueryYydToatlMsgDayStatisticalDataRequest
   * @param headers - QueryYydToatlMsgDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydToatlMsgDayStatisticalDataResponse
   */
  async queryYydToatlMsgDayStatisticalDataWithOptions(request: QueryYydToatlMsgDayStatisticalDataRequest, headers: QueryYydToatlMsgDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydToatlMsgDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydToatlMsgDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydToatlMsgDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydToatlMsgDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydToatlMsgDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋消息概览（按日统计）指标接口
   * 
   * @param request - QueryYydToatlMsgDayStatisticalDataRequest
   * @returns QueryYydToatlMsgDayStatisticalDataResponse
   */
  async queryYydToatlMsgDayStatisticalData(request: QueryYydToatlMsgDayStatisticalDataRequest): Promise<QueryYydToatlMsgDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgDayStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋消息概览（按月统计）指标接口
   * 
   * @param request - QueryYydToatlMsgMonthStatisticalDataRequest
   * @param headers - QueryYydToatlMsgMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydToatlMsgMonthStatisticalDataResponse
   */
  async queryYydToatlMsgMonthStatisticalDataWithOptions(request: QueryYydToatlMsgMonthStatisticalDataRequest, headers: QueryYydToatlMsgMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydToatlMsgMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydToatlMsgMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydToatlMsgMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydToatlMsgMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydToatlMsgMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋消息概览（按月统计）指标接口
   * 
   * @param request - QueryYydToatlMsgMonthStatisticalDataRequest
   * @returns QueryYydToatlMsgMonthStatisticalDataResponse
   */
  async queryYydToatlMsgMonthStatisticalData(request: QueryYydToatlMsgMonthStatisticalDataRequest): Promise<QueryYydToatlMsgMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgMonthStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋消息概览（按周统计）指标接口
   * 
   * @param request - QueryYydToatlMsgWeekStatisticalDataRequest
   * @param headers - QueryYydToatlMsgWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydToatlMsgWeekStatisticalDataResponse
   */
  async queryYydToatlMsgWeekStatisticalDataWithOptions(request: QueryYydToatlMsgWeekStatisticalDataRequest, headers: QueryYydToatlMsgWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydToatlMsgWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydToatlMsgWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydToatlMsgWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydToatlMsgWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydToatlMsgWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋消息概览（按周统计）指标接口
   * 
   * @param request - QueryYydToatlMsgWeekStatisticalDataRequest
   * @returns QueryYydToatlMsgWeekStatisticalDataResponse
   */
  async queryYydToatlMsgWeekStatisticalData(request: QueryYydToatlMsgWeekStatisticalDataRequest): Promise<QueryYydToatlMsgWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydToatlMsgWeekStatisticalDataHeaders({ });
    return await this.queryYydToatlMsgWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋待办分析（按日统计）指标接口
   * 
   * @param request - QueryYydTodoDayStatisticalDataRequest
   * @param headers - QueryYydTodoDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydTodoDayStatisticalDataResponse
   */
  async queryYydTodoDayStatisticalDataWithOptions(request: QueryYydTodoDayStatisticalDataRequest, headers: QueryYydTodoDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTodoDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydTodoDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTodoDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTodoDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTodoDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋待办分析（按日统计）指标接口
   * 
   * @param request - QueryYydTodoDayStatisticalDataRequest
   * @returns QueryYydTodoDayStatisticalDataResponse
   */
  async queryYydTodoDayStatisticalData(request: QueryYydTodoDayStatisticalDataRequest): Promise<QueryYydTodoDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoDayStatisticalDataHeaders({ });
    return await this.queryYydTodoDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋待办分析（按月统计）指标接口
   * 
   * @param request - QueryYydTodoMonthStatisticalDataRequest
   * @param headers - QueryYydTodoMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydTodoMonthStatisticalDataResponse
   */
  async queryYydTodoMonthStatisticalDataWithOptions(request: QueryYydTodoMonthStatisticalDataRequest, headers: QueryYydTodoMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTodoMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydTodoMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTodoMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTodoMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTodoMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋待办分析（按月统计）指标接口
   * 
   * @param request - QueryYydTodoMonthStatisticalDataRequest
   * @returns QueryYydTodoMonthStatisticalDataResponse
   */
  async queryYydTodoMonthStatisticalData(request: QueryYydTodoMonthStatisticalDataRequest): Promise<QueryYydTodoMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoMonthStatisticalDataHeaders({ });
    return await this.queryYydTodoMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉数字参谋待办分析（按周统计）指标接口
   * 
   * @param request - QueryYydTodoWeekStatisticalDataRequest
   * @param headers - QueryYydTodoWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydTodoWeekStatisticalDataResponse
   */
  async queryYydTodoWeekStatisticalDataWithOptions(request: QueryYydTodoWeekStatisticalDataRequest, headers: QueryYydTodoWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTodoWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydTodoWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTodoWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTodoWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTodoWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉数字参谋待办分析（按周统计）指标接口
   * 
   * @param request - QueryYydTodoWeekStatisticalDataRequest
   * @returns QueryYydTodoWeekStatisticalDataResponse
   */
  async queryYydTodoWeekStatisticalData(request: QueryYydTodoWeekStatisticalDataRequest): Promise<QueryYydTodoWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTodoWeekStatisticalDataHeaders({ });
    return await this.queryYydTodoWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉参谋全局概览（按日统计）指标接口
   * 
   * @param request - QueryYydTotalDayStatisticalDataRequest
   * @param headers - QueryYydTotalDayStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydTotalDayStatisticalDataResponse
   */
  async queryYydTotalDayStatisticalDataWithOptions(request: QueryYydTotalDayStatisticalDataRequest, headers: QueryYydTotalDayStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalDayStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydTotalDayStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalDayDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalDayStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalDayStatisticalDataResponse({}));
  }

  /**
   * 亚运钉参谋全局概览（按日统计）指标接口
   * 
   * @param request - QueryYydTotalDayStatisticalDataRequest
   * @returns QueryYydTotalDayStatisticalDataResponse
   */
  async queryYydTotalDayStatisticalData(request: QueryYydTotalDayStatisticalDataRequest): Promise<QueryYydTotalDayStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalDayStatisticalDataHeaders({ });
    return await this.queryYydTotalDayStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉参谋全局概览（按月统计）指标接口
   * 
   * @param request - QueryYydTotalMonthStatisticalDataRequest
   * @param headers - QueryYydTotalMonthStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydTotalMonthStatisticalDataResponse
   */
  async queryYydTotalMonthStatisticalDataWithOptions(request: QueryYydTotalMonthStatisticalDataRequest, headers: QueryYydTotalMonthStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalMonthStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydTotalMonthStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalMonthDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalMonthStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalMonthStatisticalDataResponse({}));
  }

  /**
   * 亚运钉参谋全局概览（按月统计）指标接口
   * 
   * @param request - QueryYydTotalMonthStatisticalDataRequest
   * @returns QueryYydTotalMonthStatisticalDataResponse
   */
  async queryYydTotalMonthStatisticalData(request: QueryYydTotalMonthStatisticalDataRequest): Promise<QueryYydTotalMonthStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalMonthStatisticalDataHeaders({ });
    return await this.queryYydTotalMonthStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉参谋全局概览（累计）指标接口
   * 
   * @param request - QueryYydTotalStdStatisticalDataRequest
   * @param headers - QueryYydTotalStdStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydTotalStdStatisticalDataResponse
   */
  async queryYydTotalStdStatisticalDataWithOptions(request: QueryYydTotalStdStatisticalDataRequest, headers: QueryYydTotalStdStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalStdStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydTotalStdStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalStdDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalStdStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalStdStatisticalDataResponse({}));
  }

  /**
   * 亚运钉参谋全局概览（累计）指标接口
   * 
   * @param request - QueryYydTotalStdStatisticalDataRequest
   * @returns QueryYydTotalStdStatisticalDataResponse
   */
  async queryYydTotalStdStatisticalData(request: QueryYydTotalStdStatisticalDataRequest): Promise<QueryYydTotalStdStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalStdStatisticalDataHeaders({ });
    return await this.queryYydTotalStdStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 亚运钉参谋全局概览（按周统计）指标接口
   * 
   * @param request - QueryYydTotalWeekStatisticalDataRequest
   * @param headers - QueryYydTotalWeekStatisticalDataHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryYydTotalWeekStatisticalDataResponse
   */
  async queryYydTotalWeekStatisticalDataWithOptions(request: QueryYydTotalWeekStatisticalDataRequest, headers: QueryYydTotalWeekStatisticalDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryYydTotalWeekStatisticalDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.statDate)) {
      query["statDate"] = request.statDate;
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
      action: "QueryYydTotalWeekStatisticalData",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/yydTotalWeekDatas`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryYydTotalWeekStatisticalDataResponse>(await this.execute(params, req, runtime), new QueryYydTotalWeekStatisticalDataResponse({}));
  }

  /**
   * 亚运钉参谋全局概览（按周统计）指标接口
   * 
   * @param request - QueryYydTotalWeekStatisticalDataRequest
   * @returns QueryYydTotalWeekStatisticalDataResponse
   */
  async queryYydTotalWeekStatisticalData(request: QueryYydTotalWeekStatisticalDataRequest): Promise<QueryYydTotalWeekStatisticalDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryYydTotalWeekStatisticalDataHeaders({ });
    return await this.queryYydTotalWeekStatisticalDataWithOptions(request, headers, runtime);
  }

  /**
   * 通过关键词搜索企业
   * 
   * @param request - SearchCompanyRequest
   * @param headers - SearchCompanyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchCompanyResponse
   */
  async searchCompanyWithOptions(request: SearchCompanyRequest, headers: SearchCompanyHeaders, runtime: $Util.RuntimeOptions): Promise<SearchCompanyResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.searchKey)) {
      query["searchKey"] = request.searchKey;
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
      action: "SearchCompany",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/keywords/companies`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchCompanyResponse>(await this.execute(params, req, runtime), new SearchCompanyResponse({}));
  }

  /**
   * 通过关键词搜索企业
   * 
   * @param request - SearchCompanyRequest
   * @returns SearchCompanyResponse
   */
  async searchCompany(request: SearchCompanyRequest): Promise<SearchCompanyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchCompanyHeaders({ });
    return await this.searchCompanyWithOptions(request, headers, runtime);
  }

  /**
   * 同步数据大屏
   * 
   * @param request - SyncDataScreenRequest
   * @param headers - SyncDataScreenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncDataScreenResponse
   */
  async syncDataScreenWithOptions(request: SyncDataScreenRequest, headers: SyncDataScreenHeaders, runtime: $Util.RuntimeOptions): Promise<SyncDataScreenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.screenId)) {
      body["screenId"] = request.screenId;
    }

    if (!Util.isUnset(request.ticket)) {
      body["ticket"] = request.ticket;
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
      action: "SyncDataScreen",
      version: "datacenter_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/datacenter/dataScreens/sync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncDataScreenResponse>(await this.execute(params, req, runtime), new SyncDataScreenResponse({}));
  }

  /**
   * 同步数据大屏
   * 
   * @param request - SyncDataScreenRequest
   * @returns SyncDataScreenResponse
   */
  async syncDataScreen(request: SyncDataScreenRequest): Promise<SyncDataScreenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncDataScreenHeaders({ });
    return await this.syncDataScreenWithOptions(request, headers, runtime);
  }

}
