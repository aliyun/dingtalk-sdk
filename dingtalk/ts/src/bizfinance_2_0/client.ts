// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BankGatewayInvokeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BankGatewayInvokeRequest extends $tea.Model {
  /**
   * @example
   * bankHttp
   */
  actionType?: string;
  inputData?: string;
  /**
   * @example
   * https://cdc.cmbchina.com/cdcserver/api/v2
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      inputData: 'inputData',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'string',
      inputData: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BankGatewayInvokeResponseBody extends $tea.Model {
  outputData?: string;
  static names(): { [key: string]: string } {
    return {
      outputData: 'outputData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outputData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BankGatewayInvokeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BankGatewayInvokeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BankGatewayInvokeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteReceiptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteReceiptRequest extends $tea.Model {
  instanceIdList?: string[];
  /**
   * @example
   * 504XX
   */
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      instanceIdList: 'instanceIdList',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceIdList: { 'type': 'array', 'itemType': 'string' },
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchDeleteReceiptResponseBody extends $tea.Model {
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

export class BatchDeleteReceiptResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchDeleteReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchDeleteReceiptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSyncBankReceiptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSyncBankReceiptRequest extends $tea.Model {
  body?: BatchSyncBankReceiptRequestBody[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': BatchSyncBankReceiptRequestBody },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSyncBankReceiptResponseBody extends $tea.Model {
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

export class BatchSyncBankReceiptResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchSyncBankReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchSyncBankReceiptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCategoryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCategoryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INCOME_XXX
   */
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCategoryResponseBody extends $tea.Model {
  accountantBookIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INCOME_XXX
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  isDir?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 汽车
   */
  name?: string;
  /**
   * @example
   * DIR_XXX
   */
  parentCode?: string;
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * valid
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * income
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookIdList: 'accountantBookIdList',
      code: 'code',
      isDir: 'isDir',
      name: 'name',
      parentCode: 'parentCode',
      remark: 'remark',
      status: 'status',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookIdList: { 'type': 'array', 'itemType': 'string' },
      code: 'string',
      isDir: 'boolean',
      name: 'string',
      parentCode: 'string',
      remark: 'string',
      status: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCategoryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCategoryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetCategoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFinanceAccountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFinanceAccountRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  accountCode?: string;
  static names(): { [key: string]: string } {
    return {
      accountCode: 'accountCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFinanceAccountResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  accountCode?: string;
  /**
   * @example
   * test@alipay.com
   */
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试
   */
  accountName?: string;
  accountRemark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  accountType?: string;
  accountantBookIdList?: string[];
  /**
   * @example
   * 50000.55
   */
  amount?: string;
  bankCode?: string;
  bankName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1631526550994
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcdef
   */
  creator?: string;
  static names(): { [key: string]: string } {
    return {
      accountCode: 'accountCode',
      accountId: 'accountId',
      accountName: 'accountName',
      accountRemark: 'accountRemark',
      accountType: 'accountType',
      accountantBookIdList: 'accountantBookIdList',
      amount: 'amount',
      bankCode: 'bankCode',
      bankName: 'bankName',
      createTime: 'createTime',
      creator: 'creator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountCode: 'string',
      accountId: 'string',
      accountName: 'string',
      accountRemark: 'string',
      accountType: 'string',
      accountantBookIdList: { 'type': 'array', 'itemType': 'string' },
      amount: 'string',
      bankCode: 'string',
      bankName: 'string',
      createTime: 'number',
      creator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFinanceAccountResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFinanceAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFinanceAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROJ-xxx
   */
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectResponseBody extends $tea.Model {
  accountantBookIdList?: string[];
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1631526550994
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * aaa
   */
  creator?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 和外部合作
   */
  description?: string;
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROJ-XXX
   */
  projectCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 外包项目
   */
  projectName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * valid
   */
  status?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookIdList: 'accountantBookIdList',
      code: 'code',
      createTime: 'createTime',
      creator: 'creator',
      description: 'description',
      name: 'name',
      projectCode: 'projectCode',
      projectName: 'projectName',
      status: 'status',
      userDefineCode: 'userDefineCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookIdList: { 'type': 'array', 'itemType': 'string' },
      code: 'string',
      createTime: 'number',
      creator: 'string',
      description: 'string',
      name: 'string',
      projectCode: 'string',
      projectName: 'string',
      status: 'string',
      userDefineCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetProjectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetReceiptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetReceiptRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 19b98a1c-5a31-4d78-9da7-0e347593820a
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * EM-1017F28E03350B1738B3000X
   */
  modelId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      modelId: 'modelId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      modelId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetReceiptResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234
   */
  appId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"operatorUserId":"015865244722391178","data":{"amount":{"amountStr":"566"},"code":"d0d54815-32c5-4b18-8391-e79713bba95e","payeeAt":1637251200000,"departmentCode":"-1","project":{"projectCode":"PROJ_101761F3FF6B21362ECA000N","projectName":"客户合作项目"},"principalId":"015865244722391178","enterpriseAccount":{},"approvedAt":1637305373000,"title":"地狱猫提交的智能财务-收款","createAt":1637305353000,"paymentAt":1637251200000,"supplier":{},"operateUserId":"015865244722391178","applicantEmployeeId":"015865244722391178","comment":"ffff","category":{"categoryCode":"INC_1016D6CB3C181E28F0120009","categoryName":"销售收入"},"customer":{"customerCode":"CUS_10178592ECEC2133C893000F","customerName":"钉钉"},"status":"agree"}}
   */
  data?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * EM-1017F28E03350B1738B3000X
   */
  modelId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * approval
   */
  source?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      data: 'data',
      modelId: 'modelId',
      source: 'source',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      data: 'string',
      modelId: 'string',
      source: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetReceiptResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetReceiptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSupplierHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSupplierRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUP_XXX
   */
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSupplierResponseBody extends $tea.Model {
  accountantBookIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUP_XXX
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1634786828686
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 原材料供应商
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX公司
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * valid
   */
  status?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookIdList: 'accountantBookIdList',
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      status: 'status',
      userDefineCode: 'userDefineCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookIdList: { 'type': 'array', 'itemType': 'string' },
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      status: 'string',
      userDefineCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSupplierResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSupplierResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetSupplierResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkCommonInvokeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkCommonInvokeRequest extends $tea.Model {
  /**
   * @example
   * TEST
   */
  bizType?: string;
  /**
   * @example
   * "{\"key\":\"value\"}"
   */
  data?: string;
  /**
   * @example
   * INOVKE_XXX
   */
  invokeId?: string;
  /**
   * @example
   * abc
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      data: 'data',
      invokeId: 'invokeId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      data: 'string',
      invokeId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkCommonInvokeResponseBody extends $tea.Model {
  bizType?: string;
  data?: string;
  invokeId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      data: 'data',
      invokeId: 'invokeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      data: 'string',
      invokeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LinkCommonInvokeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LinkCommonInvokeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: LinkCommonInvokeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderBillingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderBillingRequest extends $tea.Model {
  additionInfos?: OrderBillingRequestAdditionInfos[];
  /**
   * @example
   * abc
   */
  appKey?: string;
  applyPerson?: string;
  invoiceRemark?: string;
  /**
   * @example
   * VAT_NORMAL_E
   */
  invoiceType?: string;
  isNaturalPerson?: boolean;
  operator?: string;
  /**
   * @example
   * abc
   */
  orderId?: string;
  payee?: string;
  phone?: string;
  products?: OrderBillingRequestProducts[];
  /**
   * @example
   * 浙江省杭州市XXX街道
   */
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankName?: string;
  /**
   * @example
   * XXX公司
   */
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  reviewer?: string;
  signature?: string;
  taxSign?: number;
  static names(): { [key: string]: string } {
    return {
      additionInfos: 'additionInfos',
      appKey: 'appKey',
      applyPerson: 'applyPerson',
      invoiceRemark: 'invoiceRemark',
      invoiceType: 'invoiceType',
      isNaturalPerson: 'isNaturalPerson',
      operator: 'operator',
      orderId: 'orderId',
      payee: 'payee',
      phone: 'phone',
      products: 'products',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankName: 'purchaserBankName',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      reviewer: 'reviewer',
      signature: 'signature',
      taxSign: 'taxSign',
    };
  }

  static types(): { [key: string]: any } {
    return {
      additionInfos: { 'type': 'array', 'itemType': OrderBillingRequestAdditionInfos },
      appKey: 'string',
      applyPerson: 'string',
      invoiceRemark: 'string',
      invoiceType: 'string',
      isNaturalPerson: 'boolean',
      operator: 'string',
      orderId: 'string',
      payee: 'string',
      phone: 'string',
      products: { 'type': 'array', 'itemType': OrderBillingRequestProducts },
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankName: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      reviewer: 'string',
      signature: 'string',
      taxSign: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderBillingResponseBody extends $tea.Model {
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

export class OrderBillingResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OrderBillingResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: OrderBillingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCategoryByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCategoryByPageRequest extends $tea.Model {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCategoryByPageResponseBody extends $tea.Model {
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
   */
  list?: QueryCategoryByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryCategoryByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCategoryByPageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCategoryByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCategoryByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerByPageRequest extends $tea.Model {
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

export class QueryCustomerByPageResponseBody extends $tea.Model {
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
   */
  list?: QueryCustomerByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryCustomerByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerByPageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCustomerByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCustomerByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEnterpriseAccountByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEnterpriseAccountByPageRequest extends $tea.Model {
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

export class QueryEnterpriseAccountByPageResponseBody extends $tea.Model {
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
   */
  list?: QueryEnterpriseAccountByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryEnterpriseAccountByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEnterpriseAccountByPageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryEnterpriseAccountByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryEnterpriseAccountByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailRequest extends $tea.Model {
  /**
   * @example
   * abc
   */
  orderNo?: string;
  static names(): { [key: string]: string } {
    return {
      orderNo: 'orderNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponseBody extends $tea.Model {
  amount?: string;
  instanceId?: string;
  payeeAccountDTO?: QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO;
  payerAccountDTO?: QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO;
  remark?: string;
  usage?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      instanceId: 'instanceId',
      payeeAccountDTO: 'payeeAccountDTO',
      payerAccountDTO: 'payerAccountDTO',
      remark: 'remark',
      usage: 'usage',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      instanceId: 'string',
      payeeAccountDTO: QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO,
      payerAccountDTO: QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO,
      remark: 'string',
      usage: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryInstancePaymentOrderDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryInstancePaymentOrderDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectByPageRequest extends $tea.Model {
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

export class QueryProjectByPageResponseBody extends $tea.Model {
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
   */
  list?: QueryProjectByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryProjectByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectByPageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryProjectByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryProjectByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySupplierByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySupplierByPageRequest extends $tea.Model {
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

export class QuerySupplierByPageResponseBody extends $tea.Model {
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
   */
  list?: QuerySupplierByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QuerySupplierByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySupplierByPageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySupplierByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QuerySupplierByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRoleListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRoleListRequest extends $tea.Model {
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * 12312231231
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRoleListResponseBody extends $tea.Model {
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  financeEmpDeptOpenList?: QueryUserRoleListResponseBodyFinanceEmpDeptOpenList[];
  roleVOList?: QueryUserRoleListResponseBodyRoleVOList[];
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      financeEmpDeptOpenList: 'financeEmpDeptOpenList',
      roleVOList: 'roleVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      financeEmpDeptOpenList: { 'type': 'array', 'itemType': QueryUserRoleListResponseBodyFinanceEmpDeptOpenList },
      roleVOList: { 'type': 'array', 'itemType': QueryUserRoleListResponseBodyRoleVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRoleListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUserRoleListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUserRoleListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignEnterpriseAccountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignEnterpriseAccountRequest extends $tea.Model {
  /**
   * @example
   * 123
   */
  bankCardNo?: string;
  /**
   * @example
   * 123
   * 
   * **if can be null:**
   * true
   */
  bankOpenId?: string;
  /**
   * @example
   * COMM_UNIONPAY
   * 
   * **if can be null:**
   * true
   */
  channelType?: string;
  /**
   * @example
   * 123
   */
  operator?: string;
  /**
   * @example
   * signed
   */
  signOperateType?: string;
  static names(): { [key: string]: string } {
    return {
      bankCardNo: 'bankCardNo',
      bankOpenId: 'bankOpenId',
      channelType: 'channelType',
      operator: 'operator',
      signOperateType: 'signOperateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bankCardNo: 'string',
      bankOpenId: 'string',
      channelType: 'string',
      operator: 'string',
      signOperateType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SignEnterpriseAccountResponseBody extends $tea.Model {
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

export class SignEnterpriseAccountResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SignEnterpriseAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SignEnterpriseAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncReceiptRecallHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncReceiptRecallRequest extends $tea.Model {
  /**
   * @example
   * https:xxxx.pdf
   */
  fileDownloadUrl?: string;
  /**
   * @example
   * 1234.pdf
   */
  fileName?: string;
  /**
   * @example
   * 123
   */
  orderNo?: string;
  static names(): { [key: string]: string } {
    return {
      fileDownloadUrl: 'fileDownloadUrl',
      fileName: 'fileName',
      orderNo: 'orderNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileDownloadUrl: 'string',
      fileName: 'string',
      orderNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SyncReceiptRecallResponseBody extends $tea.Model {
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

export class SyncReceiptRecallResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SyncReceiptRecallResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SyncReceiptRecallResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceOrderInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceOrderInfoRequest extends $tea.Model {
  /**
   * @example
   * xxx错误
   */
  failReason?: string;
  /**
   * @example
   * abc
   */
  orderNo?: string;
  /**
   * @example
   * 123
   */
  outOrderNo?: string;
  payerBank?: UpdateInstanceOrderInfoRequestPayerBank;
  /**
   * @example
   * 1709691000682
   */
  paymentTime?: number;
  /**
   * @example
   * PAYING
   */
  status?: string;
  /**
   * @example
   * 123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      failReason: 'failReason',
      orderNo: 'orderNo',
      outOrderNo: 'outOrderNo',
      payerBank: 'payerBank',
      paymentTime: 'paymentTime',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failReason: 'string',
      orderNo: 'string',
      outOrderNo: 'string',
      payerBank: UpdateInstanceOrderInfoRequestPayerBank,
      paymentTime: 'number',
      status: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceOrderInfoShrinkRequest extends $tea.Model {
  /**
   * @example
   * xxx错误
   */
  failReason?: string;
  /**
   * @example
   * abc
   */
  orderNo?: string;
  /**
   * @example
   * 123
   */
  outOrderNo?: string;
  payerBankShrink?: string;
  /**
   * @example
   * 1709691000682
   */
  paymentTime?: number;
  /**
   * @example
   * PAYING
   */
  status?: string;
  /**
   * @example
   * 123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      failReason: 'failReason',
      orderNo: 'orderNo',
      outOrderNo: 'outOrderNo',
      payerBankShrink: 'payerBank',
      paymentTime: 'paymentTime',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failReason: 'string',
      orderNo: 'string',
      outOrderNo: 'string',
      payerBankShrink: 'string',
      paymentTime: 'number',
      status: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceOrderInfoResponseBody extends $tea.Model {
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

export class UpdateInstanceOrderInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInstanceOrderInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateInstanceOrderInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSyncBankReceiptRequestBody extends $tea.Model {
  /**
   * @example
   * https://xxxxx
   */
  fileDownloadUrl?: string;
  /**
   * @example
   * xxxx回单.pdf
   */
  fileName?: string;
  /**
   * @example
   * 2024000001902335
   */
  messageId?: string;
  /**
   * @example
   * detailId
   */
  messageIdType?: string;
  static names(): { [key: string]: string } {
    return {
      fileDownloadUrl: 'fileDownloadUrl',
      fileName: 'fileName',
      messageId: 'messageId',
      messageIdType: 'messageIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileDownloadUrl: 'string',
      fileName: 'string',
      messageId: 'string',
      messageIdType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderBillingRequestAdditionInfos extends $tea.Model {
  additionContent?: string;
  additionName?: string;
  dataType?: number;
  static names(): { [key: string]: string } {
    return {
      additionContent: 'additionContent',
      additionName: 'additionName',
      dataType: 'dataType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      additionContent: 'string',
      additionName: 'string',
      dataType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderBillingRequestProducts extends $tea.Model {
  /**
   * @example
   * 12.55
   */
  amountWithTax?: string;
  /**
   * @example
   * 面包
   */
  productName?: string;
  /**
   * @example
   * 5
   */
  quantity?: string;
  revenueCode?: string;
  specification?: string;
  /**
   * @example
   * 个
   */
  unit?: string;
  /**
   * @example
   * 19.99
   */
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amountWithTax: 'amountWithTax',
      productName: 'productName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      specification: 'specification',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amountWithTax: 'string',
      productName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      specification: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCategoryByPageResponseBodyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INCOME_XXX
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  isDir?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 汽车
   */
  name?: string;
  /**
   * @example
   * INCOM_XXX
   */
  parentCode?: string;
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * valid
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * income
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      isDir: 'isDir',
      name: 'name',
      parentCode: 'parentCode',
      remark: 'remark',
      status: 'status',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      isDir: 'boolean',
      name: 'string',
      parentCode: 'string',
      remark: 'string',
      status: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerByPageResponseBodyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CUS_XXX
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1634786828686
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 重要客户
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX有限公司
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * valid
   */
  status?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      status: 'status',
      userDefineCode: 'userDefineCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      status: 'string',
      userDefineCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryEnterpriseAccountByPageResponseBodyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12345
   */
  accountCode?: string;
  /**
   * @example
   * test@alipay.com
   */
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 网商银行
   */
  accountName?: string;
  /**
   * @example
   * test
   */
  accountRemark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  accountType?: string;
  /**
   * @example
   * 10000.33
   */
  amount?: string;
  bankCode?: string;
  bankName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1631526550994
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * aaa
   */
  creator?: string;
  static names(): { [key: string]: string } {
    return {
      accountCode: 'accountCode',
      accountId: 'accountId',
      accountName: 'accountName',
      accountRemark: 'accountRemark',
      accountType: 'accountType',
      amount: 'amount',
      bankCode: 'bankCode',
      bankName: 'bankName',
      createTime: 'createTime',
      creator: 'creator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountCode: 'string',
      accountId: 'string',
      accountName: 'string',
      accountRemark: 'string',
      accountType: 'string',
      amount: 'string',
      bankCode: 'string',
      bankName: 'string',
      createTime: 'number',
      creator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO extends $tea.Model {
  accountName?: string;
  bankBranchCode?: string;
  bankBranchName?: string;
  bankCardNo?: string;
  bankCode?: string;
  bankName?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      accountName: 'accountName',
      bankBranchCode: 'bankBranchCode',
      bankBranchName: 'bankBranchName',
      bankCardNo: 'bankCardNo',
      bankCode: 'bankCode',
      bankName: 'bankName',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountName: 'string',
      bankBranchCode: 'string',
      bankBranchName: 'string',
      bankCardNo: 'string',
      bankCode: 'string',
      bankName: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTO extends $tea.Model {
  bankOpenDTO?: QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO;
  static names(): { [key: string]: string } {
    return {
      bankOpenDTO: 'bankOpenDTO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bankOpenDTO: QueryInstancePaymentOrderDetailResponseBodyPayeeAccountDTOBankOpenDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO extends $tea.Model {
  accountName?: string;
  bankBranchCode?: string;
  bankBranchName?: string;
  bankCardNo?: string;
  bankCode?: string;
  bankName?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      accountName: 'accountName',
      bankBranchCode: 'bankBranchCode',
      bankBranchName: 'bankBranchName',
      bankCardNo: 'bankCardNo',
      bankCode: 'bankCode',
      bankName: 'bankName',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountName: 'string',
      bankBranchCode: 'string',
      bankBranchName: 'string',
      bankCardNo: 'string',
      bankCode: 'string',
      bankName: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTO extends $tea.Model {
  bankOpenDTO?: QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO;
  enterpriseAccountCode?: string;
  static names(): { [key: string]: string } {
    return {
      bankOpenDTO: 'bankOpenDTO',
      enterpriseAccountCode: 'enterpriseAccountCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bankOpenDTO: QueryInstancePaymentOrderDetailResponseBodyPayerAccountDTOBankOpenDTO,
      enterpriseAccountCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectByPageResponseBodyList extends $tea.Model {
  caode?: string;
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1631524595555
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * aaaa
   */
  creator?: string;
  /**
   * @example
   * 外派项目
   */
  description?: string;
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROJ-xxx
   */
  projectCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 外派项目
   */
  projectName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * valid
   */
  status?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      caode: 'caode',
      code: 'code',
      createTime: 'createTime',
      creator: 'creator',
      description: 'description',
      name: 'name',
      projectCode: 'projectCode',
      projectName: 'projectName',
      status: 'status',
      userDefineCode: 'userDefineCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      caode: 'string',
      code: 'string',
      createTime: 'number',
      creator: 'string',
      description: 'string',
      name: 'string',
      projectCode: 'string',
      projectName: 'string',
      status: 'string',
      userDefineCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySupplierByPageResponseBodyList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUP_XXX
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1634786828686
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 原材料供应商
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX供应商
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * valid
   */
  status?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      status: 'status',
      userDefineCode: 'userDefineCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      status: 'string',
      userDefineCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRoleListResponseBodyFinanceEmpDeptOpenList extends $tea.Model {
  cascadeDeptId?: string;
  deptId?: number;
  name?: string;
  superDeptId?: number;
  static names(): { [key: string]: string } {
    return {
      cascadeDeptId: 'cascadeDeptId',
      deptId: 'deptId',
      name: 'name',
      superDeptId: 'superDeptId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cascadeDeptId: 'string',
      deptId: 'number',
      name: 'string',
      superDeptId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRoleListResponseBodyRoleVOList extends $tea.Model {
  /**
   * @example
   * applicationManager
   */
  roleCode?: string;
  /**
   * @example
   * 应用管理员
   */
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      roleCode: 'roleCode',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleCode: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceOrderInfoRequestPayerBank extends $tea.Model {
  /**
   * @example
   * 64112222
   */
  cardNo?: string;
  /**
   * @example
   * 招商银行
   */
  name?: string;
  static names(): { [key: string]: string } {
    return {
      cardNo: 'cardNo',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardNo: 'string',
      name: 'string',
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
   * 银行接入层通用接口
   * 
   * @param request - BankGatewayInvokeRequest
   * @param headers - BankGatewayInvokeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BankGatewayInvokeResponse
   */
  async bankGatewayInvokeWithOptions(request: BankGatewayInvokeRequest, headers: BankGatewayInvokeHeaders, runtime: $Util.RuntimeOptions): Promise<BankGatewayInvokeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionType)) {
      body["actionType"] = request.actionType;
    }

    if (!Util.isUnset(request.inputData)) {
      body["inputData"] = request.inputData;
    }

    if (!Util.isUnset(request.url)) {
      body["url"] = request.url;
    }

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
      action: "BankGatewayInvoke",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/bankGateways/invoke`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BankGatewayInvokeResponse>(await this.execute(params, req, runtime), new BankGatewayInvokeResponse({}));
  }

  /**
   * 银行接入层通用接口
   * 
   * @param request - BankGatewayInvokeRequest
   * @returns BankGatewayInvokeResponse
   */
  async bankGatewayInvoke(request: BankGatewayInvokeRequest): Promise<BankGatewayInvokeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BankGatewayInvokeHeaders({ });
    return await this.bankGatewayInvokeWithOptions(request, headers, runtime);
  }

  /**
   * 批量删除智能财务单据
   * 
   * @param request - BatchDeleteReceiptRequest
   * @param headers - BatchDeleteReceiptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchDeleteReceiptResponse
   */
  async batchDeleteReceiptWithOptions(request: BatchDeleteReceiptRequest, headers: BatchDeleteReceiptHeaders, runtime: $Util.RuntimeOptions): Promise<BatchDeleteReceiptResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceIdList)) {
      body["instanceIdList"] = request.instanceIdList;
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
      action: "BatchDeleteReceipt",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/instances/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchDeleteReceiptResponse>(await this.execute(params, req, runtime), new BatchDeleteReceiptResponse({}));
  }

  /**
   * 批量删除智能财务单据
   * 
   * @param request - BatchDeleteReceiptRequest
   * @returns BatchDeleteReceiptResponse
   */
  async batchDeleteReceipt(request: BatchDeleteReceiptRequest): Promise<BatchDeleteReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchDeleteReceiptHeaders({ });
    return await this.batchDeleteReceiptWithOptions(request, headers, runtime);
  }

  /**
   * 批量同步银行回单
   * 
   * @param request - BatchSyncBankReceiptRequest
   * @param headers - BatchSyncBankReceiptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchSyncBankReceiptResponse
   */
  async batchSyncBankReceiptWithOptions(request: BatchSyncBankReceiptRequest, headers: BatchSyncBankReceiptHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSyncBankReceiptResponse> {
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
      body: Util.toArray(request.body),
    });
    let params = new $OpenApi.Params({
      action: "BatchSyncBankReceipt",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/receipts/batchSync`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchSyncBankReceiptResponse>(await this.execute(params, req, runtime), new BatchSyncBankReceiptResponse({}));
  }

  /**
   * 批量同步银行回单
   * 
   * @param request - BatchSyncBankReceiptRequest
   * @returns BatchSyncBankReceiptResponse
   */
  async batchSyncBankReceipt(request: BatchSyncBankReceiptRequest): Promise<BatchSyncBankReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSyncBankReceiptHeaders({ });
    return await this.batchSyncBankReceiptWithOptions(request, headers, runtime);
  }

  /**
   * 获取费用类别
   * 
   * @param request - GetCategoryRequest
   * @param headers - GetCategoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCategoryResponse
   */
  async getCategoryWithOptions(request: GetCategoryRequest, headers: GetCategoryHeaders, runtime: $Util.RuntimeOptions): Promise<GetCategoryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

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
      action: "GetCategory",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/categories`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCategoryResponse>(await this.execute(params, req, runtime), new GetCategoryResponse({}));
  }

  /**
   * 获取费用类别
   * 
   * @param request - GetCategoryRequest
   * @returns GetCategoryResponse
   */
  async getCategory(request: GetCategoryRequest): Promise<GetCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCategoryHeaders({ });
    return await this.getCategoryWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业账户
   * 
   * @param request - GetFinanceAccountRequest
   * @param headers - GetFinanceAccountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFinanceAccountResponse
   */
  async getFinanceAccountWithOptions(request: GetFinanceAccountRequest, headers: GetFinanceAccountHeaders, runtime: $Util.RuntimeOptions): Promise<GetFinanceAccountResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountCode)) {
      query["accountCode"] = request.accountCode;
    }

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
      action: "GetFinanceAccount",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/financeAccounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFinanceAccountResponse>(await this.execute(params, req, runtime), new GetFinanceAccountResponse({}));
  }

  /**
   * 获取企业账户
   * 
   * @param request - GetFinanceAccountRequest
   * @returns GetFinanceAccountResponse
   */
  async getFinanceAccount(request: GetFinanceAccountRequest): Promise<GetFinanceAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFinanceAccountHeaders({ });
    return await this.getFinanceAccountWithOptions(request, headers, runtime);
  }

  /**
   * 获取单条项目
   * 
   * @param request - GetProjectRequest
   * @param headers - GetProjectHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProjectResponse
   */
  async getProjectWithOptions(request: GetProjectRequest, headers: GetProjectHeaders, runtime: $Util.RuntimeOptions): Promise<GetProjectResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

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
      action: "GetProject",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/projects`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProjectResponse>(await this.execute(params, req, runtime), new GetProjectResponse({}));
  }

  /**
   * 获取单条项目
   * 
   * @param request - GetProjectRequest
   * @returns GetProjectResponse
   */
  async getProject(request: GetProjectRequest): Promise<GetProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectHeaders({ });
    return await this.getProjectWithOptions(request, headers, runtime);
  }

  /**
   * 获取智能财务单据详情
   * 
   * @param request - GetReceiptRequest
   * @param headers - GetReceiptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetReceiptResponse
   */
  async getReceiptWithOptions(request: GetReceiptRequest, headers: GetReceiptHeaders, runtime: $Util.RuntimeOptions): Promise<GetReceiptResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.modelId)) {
      query["modelId"] = request.modelId;
    }

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
      action: "GetReceipt",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/receipts/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetReceiptResponse>(await this.execute(params, req, runtime), new GetReceiptResponse({}));
  }

  /**
   * 获取智能财务单据详情
   * 
   * @param request - GetReceiptRequest
   * @returns GetReceiptResponse
   */
  async getReceipt(request: GetReceiptRequest): Promise<GetReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetReceiptHeaders({ });
    return await this.getReceiptWithOptions(request, headers, runtime);
  }

  /**
   * 获取智能财务应用内维护的供应商信息
   * 
   * @param request - GetSupplierRequest
   * @param headers - GetSupplierHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSupplierResponse
   */
  async getSupplierWithOptions(request: GetSupplierRequest, headers: GetSupplierHeaders, runtime: $Util.RuntimeOptions): Promise<GetSupplierResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

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
      action: "GetSupplier",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/suppliers/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSupplierResponse>(await this.execute(params, req, runtime), new GetSupplierResponse({}));
  }

  /**
   * 获取智能财务应用内维护的供应商信息
   * 
   * @param request - GetSupplierRequest
   * @returns GetSupplierResponse
   */
  async getSupplier(request: GetSupplierRequest): Promise<GetSupplierResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSupplierHeaders({ });
    return await this.getSupplierWithOptions(request, headers, runtime);
  }

  /**
   * 根据不同的bizType查询不同的数据
   * 
   * @param request - LinkCommonInvokeRequest
   * @param headers - LinkCommonInvokeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LinkCommonInvokeResponse
   */
  async linkCommonInvokeWithOptions(request: LinkCommonInvokeRequest, headers: LinkCommonInvokeHeaders, runtime: $Util.RuntimeOptions): Promise<LinkCommonInvokeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.data)) {
      body["data"] = request.data;
    }

    if (!Util.isUnset(request.invokeId)) {
      body["invokeId"] = request.invokeId;
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
      action: "LinkCommonInvoke",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/link/bizTypes/invoke`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LinkCommonInvokeResponse>(await this.execute(params, req, runtime), new LinkCommonInvokeResponse({}));
  }

  /**
   * 根据不同的bizType查询不同的数据
   * 
   * @param request - LinkCommonInvokeRequest
   * @returns LinkCommonInvokeResponse
   */
  async linkCommonInvoke(request: LinkCommonInvokeRequest): Promise<LinkCommonInvokeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LinkCommonInvokeHeaders({ });
    return await this.linkCommonInvokeWithOptions(request, headers, runtime);
  }

  /**
   * 订单开票
   * 
   * @param request - OrderBillingRequest
   * @param headers - OrderBillingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OrderBillingResponse
   */
  async orderBillingWithOptions(request: OrderBillingRequest, headers: OrderBillingHeaders, runtime: $Util.RuntimeOptions): Promise<OrderBillingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.additionInfos)) {
      body["additionInfos"] = request.additionInfos;
    }

    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.applyPerson)) {
      body["applyPerson"] = request.applyPerson;
    }

    if (!Util.isUnset(request.invoiceRemark)) {
      body["invoiceRemark"] = request.invoiceRemark;
    }

    if (!Util.isUnset(request.invoiceType)) {
      body["invoiceType"] = request.invoiceType;
    }

    if (!Util.isUnset(request.isNaturalPerson)) {
      body["isNaturalPerson"] = request.isNaturalPerson;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.payee)) {
      body["payee"] = request.payee;
    }

    if (!Util.isUnset(request.phone)) {
      body["phone"] = request.phone;
    }

    if (!Util.isUnset(request.products)) {
      body["products"] = request.products;
    }

    if (!Util.isUnset(request.purchaserAddress)) {
      body["purchaserAddress"] = request.purchaserAddress;
    }

    if (!Util.isUnset(request.purchaserBankAccount)) {
      body["purchaserBankAccount"] = request.purchaserBankAccount;
    }

    if (!Util.isUnset(request.purchaserBankName)) {
      body["purchaserBankName"] = request.purchaserBankName;
    }

    if (!Util.isUnset(request.purchaserName)) {
      body["purchaserName"] = request.purchaserName;
    }

    if (!Util.isUnset(request.purchaserTaxNo)) {
      body["purchaserTaxNo"] = request.purchaserTaxNo;
    }

    if (!Util.isUnset(request.purchaserTel)) {
      body["purchaserTel"] = request.purchaserTel;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.reviewer)) {
      body["reviewer"] = request.reviewer;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.taxSign)) {
      body["taxSign"] = request.taxSign;
    }

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
      action: "OrderBilling",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/billings/order`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OrderBillingResponse>(await this.execute(params, req, runtime), new OrderBillingResponse({}));
  }

  /**
   * 订单开票
   * 
   * @param request - OrderBillingRequest
   * @returns OrderBillingResponse
   */
  async orderBilling(request: OrderBillingRequest): Promise<OrderBillingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrderBillingHeaders({ });
    return await this.orderBillingWithOptions(request, headers, runtime);
  }

  /**
   * 批量获取费用类别
   * 
   * @param request - QueryCategoryByPageRequest
   * @param headers - QueryCategoryByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCategoryByPageResponse
   */
  async queryCategoryByPageWithOptions(request: QueryCategoryByPageRequest, headers: QueryCategoryByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCategoryByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
    }

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
      action: "QueryCategoryByPage",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/categories/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCategoryByPageResponse>(await this.execute(params, req, runtime), new QueryCategoryByPageResponse({}));
  }

  /**
   * 批量获取费用类别
   * 
   * @param request - QueryCategoryByPageRequest
   * @returns QueryCategoryByPageResponse
   */
  async queryCategoryByPage(request: QueryCategoryByPageRequest): Promise<QueryCategoryByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCategoryByPageHeaders({ });
    return await this.queryCategoryByPageWithOptions(request, headers, runtime);
  }

  /**
   * 分页批量获取智能财务应用内维护的客户信息
   * 
   * @param request - QueryCustomerByPageRequest
   * @param headers - QueryCustomerByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCustomerByPageResponse
   */
  async queryCustomerByPageWithOptions(request: QueryCustomerByPageRequest, headers: QueryCustomerByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomerByPageResponse> {
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
      action: "QueryCustomerByPage",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/customers/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCustomerByPageResponse>(await this.execute(params, req, runtime), new QueryCustomerByPageResponse({}));
  }

  /**
   * 分页批量获取智能财务应用内维护的客户信息
   * 
   * @param request - QueryCustomerByPageRequest
   * @returns QueryCustomerByPageResponse
   */
  async queryCustomerByPage(request: QueryCustomerByPageRequest): Promise<QueryCustomerByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerByPageHeaders({ });
    return await this.queryCustomerByPageWithOptions(request, headers, runtime);
  }

  /**
   * 批量获取企业账户
   * 
   * @param request - QueryEnterpriseAccountByPageRequest
   * @param headers - QueryEnterpriseAccountByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryEnterpriseAccountByPageResponse
   */
  async queryEnterpriseAccountByPageWithOptions(request: QueryEnterpriseAccountByPageRequest, headers: QueryEnterpriseAccountByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryEnterpriseAccountByPageResponse> {
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
      action: "QueryEnterpriseAccountByPage",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/financeAccounts/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryEnterpriseAccountByPageResponse>(await this.execute(params, req, runtime), new QueryEnterpriseAccountByPageResponse({}));
  }

  /**
   * 批量获取企业账户
   * 
   * @param request - QueryEnterpriseAccountByPageRequest
   * @returns QueryEnterpriseAccountByPageResponse
   */
  async queryEnterpriseAccountByPage(request: QueryEnterpriseAccountByPageRequest): Promise<QueryEnterpriseAccountByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEnterpriseAccountByPageHeaders({ });
    return await this.queryEnterpriseAccountByPageWithOptions(request, headers, runtime);
  }

  /**
   * 查询支付订单详情
   * 
   * @param request - QueryInstancePaymentOrderDetailRequest
   * @param headers - QueryInstancePaymentOrderDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryInstancePaymentOrderDetailResponse
   */
  async queryInstancePaymentOrderDetailWithOptions(instanceId: string, request: QueryInstancePaymentOrderDetailRequest, headers: QueryInstancePaymentOrderDetailHeaders, runtime: $Util.RuntimeOptions): Promise<QueryInstancePaymentOrderDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.orderNo)) {
      query["orderNo"] = request.orderNo;
    }

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
      action: "QueryInstancePaymentOrderDetail",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/instances/${instanceId}/paymentOrders/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryInstancePaymentOrderDetailResponse>(await this.execute(params, req, runtime), new QueryInstancePaymentOrderDetailResponse({}));
  }

  /**
   * 查询支付订单详情
   * 
   * @param request - QueryInstancePaymentOrderDetailRequest
   * @returns QueryInstancePaymentOrderDetailResponse
   */
  async queryInstancePaymentOrderDetail(instanceId: string, request: QueryInstancePaymentOrderDetailRequest): Promise<QueryInstancePaymentOrderDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInstancePaymentOrderDetailHeaders({ });
    return await this.queryInstancePaymentOrderDetailWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * 批量获取项目信息
   * 
   * @param request - QueryProjectByPageRequest
   * @param headers - QueryProjectByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryProjectByPageResponse
   */
  async queryProjectByPageWithOptions(request: QueryProjectByPageRequest, headers: QueryProjectByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryProjectByPageResponse> {
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
      action: "QueryProjectByPage",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/projects/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryProjectByPageResponse>(await this.execute(params, req, runtime), new QueryProjectByPageResponse({}));
  }

  /**
   * 批量获取项目信息
   * 
   * @param request - QueryProjectByPageRequest
   * @returns QueryProjectByPageResponse
   */
  async queryProjectByPage(request: QueryProjectByPageRequest): Promise<QueryProjectByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProjectByPageHeaders({ });
    return await this.queryProjectByPageWithOptions(request, headers, runtime);
  }

  /**
   * 分页批量获取智能财务应用内维护的供应商信息
   * 
   * @param request - QuerySupplierByPageRequest
   * @param headers - QuerySupplierByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySupplierByPageResponse
   */
  async querySupplierByPageWithOptions(request: QuerySupplierByPageRequest, headers: QuerySupplierByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySupplierByPageResponse> {
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
      action: "QuerySupplierByPage",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/suppliers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySupplierByPageResponse>(await this.execute(params, req, runtime), new QuerySupplierByPageResponse({}));
  }

  /**
   * 分页批量获取智能财务应用内维护的供应商信息
   * 
   * @param request - QuerySupplierByPageRequest
   * @returns QuerySupplierByPageResponse
   */
  async querySupplierByPage(request: QuerySupplierByPageRequest): Promise<QuerySupplierByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySupplierByPageHeaders({ });
    return await this.querySupplierByPageWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
   * 
   * @param request - QueryUserRoleListRequest
   * @param headers - QueryUserRoleListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUserRoleListResponse
   */
  async queryUserRoleListWithOptions(request: QueryUserRoleListRequest, headers: QueryUserRoleListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserRoleListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      query["companyCode"] = request.companyCode;
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
      action: "QueryUserRoleList",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/users/roles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserRoleListResponse>(await this.execute(params, req, runtime), new QueryUserRoleListResponse({}));
  }

  /**
   * 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
   * 
   * @param request - QueryUserRoleListRequest
   * @returns QueryUserRoleListResponse
   */
  async queryUserRoleList(request: QueryUserRoleListRequest): Promise<QueryUserRoleListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserRoleListHeaders({ });
    return await this.queryUserRoleListWithOptions(request, headers, runtime);
  }

  /**
   * 签约企业账户
   * 
   * @param request - SignEnterpriseAccountRequest
   * @param headers - SignEnterpriseAccountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SignEnterpriseAccountResponse
   */
  async signEnterpriseAccountWithOptions(request: SignEnterpriseAccountRequest, headers: SignEnterpriseAccountHeaders, runtime: $Util.RuntimeOptions): Promise<SignEnterpriseAccountResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bankCardNo)) {
      query["bankCardNo"] = request.bankCardNo;
    }

    if (!Util.isUnset(request.bankOpenId)) {
      query["bankOpenId"] = request.bankOpenId;
    }

    if (!Util.isUnset(request.channelType)) {
      query["channelType"] = request.channelType;
    }

    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

    if (!Util.isUnset(request.signOperateType)) {
      query["signOperateType"] = request.signOperateType;
    }

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
      action: "SignEnterpriseAccount",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/enterpriseAccounts/sign`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SignEnterpriseAccountResponse>(await this.execute(params, req, runtime), new SignEnterpriseAccountResponse({}));
  }

  /**
   * 签约企业账户
   * 
   * @param request - SignEnterpriseAccountRequest
   * @returns SignEnterpriseAccountResponse
   */
  async signEnterpriseAccount(request: SignEnterpriseAccountRequest): Promise<SignEnterpriseAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignEnterpriseAccountHeaders({ });
    return await this.signEnterpriseAccountWithOptions(request, headers, runtime);
  }

  /**
   * 发送银企支付回单文件信息
   * 
   * @param request - SyncReceiptRecallRequest
   * @param headers - SyncReceiptRecallHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SyncReceiptRecallResponse
   */
  async syncReceiptRecallWithOptions(request: SyncReceiptRecallRequest, headers: SyncReceiptRecallHeaders, runtime: $Util.RuntimeOptions): Promise<SyncReceiptRecallResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileDownloadUrl)) {
      query["fileDownloadUrl"] = request.fileDownloadUrl;
    }

    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.orderNo)) {
      query["orderNo"] = request.orderNo;
    }

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
      action: "SyncReceiptRecall",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/receipts/syncRecall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SyncReceiptRecallResponse>(await this.execute(params, req, runtime), new SyncReceiptRecallResponse({}));
  }

  /**
   * 发送银企支付回单文件信息
   * 
   * @param request - SyncReceiptRecallRequest
   * @returns SyncReceiptRecallResponse
   */
  async syncReceiptRecall(request: SyncReceiptRecallRequest): Promise<SyncReceiptRecallResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncReceiptRecallHeaders({ });
    return await this.syncReceiptRecallWithOptions(request, headers, runtime);
  }

  /**
   * 更新单据的支付状态
   * 
   * @param tmpReq - UpdateInstanceOrderInfoRequest
   * @param headers - UpdateInstanceOrderInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInstanceOrderInfoResponse
   */
  async updateInstanceOrderInfoWithOptions(instanceId: string, tmpReq: UpdateInstanceOrderInfoRequest, headers: UpdateInstanceOrderInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInstanceOrderInfoResponse> {
    Util.validateModel(tmpReq);
    let request = new UpdateInstanceOrderInfoShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.payerBank)) {
      request.payerBankShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.payerBank, "payerBank", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.failReason)) {
      query["failReason"] = request.failReason;
    }

    if (!Util.isUnset(request.orderNo)) {
      query["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.outOrderNo)) {
      query["outOrderNo"] = request.outOrderNo;
    }

    if (!Util.isUnset(request.payerBankShrink)) {
      query["payerBank"] = request.payerBankShrink;
    }

    if (!Util.isUnset(request.paymentTime)) {
      query["paymentTime"] = request.paymentTime;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
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
      action: "UpdateInstanceOrderInfo",
      version: "bizfinance_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/bizfinance/instances/${instanceId}/paymentOrders/states`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInstanceOrderInfoResponse>(await this.execute(params, req, runtime), new UpdateInstanceOrderInfoResponse({}));
  }

  /**
   * 更新单据的支付状态
   * 
   * @param request - UpdateInstanceOrderInfoRequest
   * @returns UpdateInstanceOrderInfoResponse
   */
  async updateInstanceOrderInfo(instanceId: string, request: UpdateInstanceOrderInfoRequest): Promise<UpdateInstanceOrderInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceOrderInfoHeaders({ });
    return await this.updateInstanceOrderInfoWithOptions(instanceId, request, headers, runtime);
  }

}
