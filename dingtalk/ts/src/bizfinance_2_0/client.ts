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
  actionType?: string;
  inputData?: string;
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
  code?: string;
  isDir?: boolean;
  name?: string;
  parentCode?: string;
  status?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookIdList: 'accountantBookIdList',
      code: 'code',
      isDir: 'isDir',
      name: 'name',
      parentCode: 'parentCode',
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
  accountCode?: string;
  accountId?: string;
  accountName?: string;
  accountRemark?: string;
  accountType?: string;
  accountantBookIdList?: string[];
  amount?: string;
  bankCode?: string;
  bankName?: string;
  createTime?: number;
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
  createTime?: number;
  creator?: string;
  description?: string;
  name?: string;
  projectCode?: string;
  projectName?: string;
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
  code?: string;
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
  appId?: string;
  data?: string;
  modelId?: string;
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
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
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
  bizType?: string;
  data?: string;
  invokeId?: string;
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
  pageNumber?: number;
  pageSize?: number;
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
  hasMore?: boolean;
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

export class QueryCustomerByPageResponseBody extends $tea.Model {
  hasMore?: boolean;
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

export class QueryEnterpriseAccountByPageResponseBody extends $tea.Model {
  hasMore?: boolean;
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

export class QueryProjectByPageResponseBody extends $tea.Model {
  hasMore?: boolean;
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

export class QuerySupplierByPageResponseBody extends $tea.Model {
  hasMore?: boolean;
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
  companyCode?: string;
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
  bankCardNo?: string;
  bankOpenId?: string;
  channelType?: string;
  operator?: string;
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
  fileDownloadUrl?: string;
  fileName?: string;
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
  failReason?: string;
  orderNo?: string;
  outOrderNo?: string;
  payerBank?: UpdateInstanceOrderInfoRequestPayerBank;
  paymentTime?: number;
  status?: string;
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
  failReason?: string;
  orderNo?: string;
  outOrderNo?: string;
  payerBankShrink?: string;
  paymentTime?: number;
  status?: string;
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
  fileDownloadUrl?: string;
  fileName?: string;
  messageId?: string;
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

export class QueryCategoryByPageResponseBodyList extends $tea.Model {
  code?: string;
  isDir?: boolean;
  name?: string;
  parentCode?: string;
  status?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      isDir: 'isDir',
      name: 'name',
      parentCode: 'parentCode',
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
      status: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerByPageResponseBodyList extends $tea.Model {
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
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
  accountCode?: string;
  accountId?: string;
  accountName?: string;
  accountRemark?: string;
  accountType?: string;
  amount?: string;
  bankCode?: string;
  bankName?: string;
  createTime?: number;
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
  createTime?: number;
  creator?: string;
  description?: string;
  name?: string;
  projectCode?: string;
  projectName?: string;
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
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
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
  roleCode?: string;
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
  cardNo?: string;
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


  /**
   * @summary 银行接入层通用接口
   *
   * @param request BankGatewayInvokeRequest
   * @param headers BankGatewayInvokeHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BankGatewayInvokeResponse
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
   * @summary 银行接入层通用接口
   *
   * @param request BankGatewayInvokeRequest
   * @return BankGatewayInvokeResponse
   */
  async bankGatewayInvoke(request: BankGatewayInvokeRequest): Promise<BankGatewayInvokeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BankGatewayInvokeHeaders({ });
    return await this.bankGatewayInvokeWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量删除智能财务单据
   *
   * @param request BatchDeleteReceiptRequest
   * @param headers BatchDeleteReceiptHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchDeleteReceiptResponse
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
   * @summary 批量删除智能财务单据
   *
   * @param request BatchDeleteReceiptRequest
   * @return BatchDeleteReceiptResponse
   */
  async batchDeleteReceipt(request: BatchDeleteReceiptRequest): Promise<BatchDeleteReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchDeleteReceiptHeaders({ });
    return await this.batchDeleteReceiptWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量同步银行回单
   *
   * @param request BatchSyncBankReceiptRequest
   * @param headers BatchSyncBankReceiptHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return BatchSyncBankReceiptResponse
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
   * @summary 批量同步银行回单
   *
   * @param request BatchSyncBankReceiptRequest
   * @return BatchSyncBankReceiptResponse
   */
  async batchSyncBankReceipt(request: BatchSyncBankReceiptRequest): Promise<BatchSyncBankReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSyncBankReceiptHeaders({ });
    return await this.batchSyncBankReceiptWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取费用类别
   *
   * @param request GetCategoryRequest
   * @param headers GetCategoryHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetCategoryResponse
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
   * @summary 获取费用类别
   *
   * @param request GetCategoryRequest
   * @return GetCategoryResponse
   */
  async getCategory(request: GetCategoryRequest): Promise<GetCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCategoryHeaders({ });
    return await this.getCategoryWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取企业账户
   *
   * @param request GetFinanceAccountRequest
   * @param headers GetFinanceAccountHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetFinanceAccountResponse
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
   * @summary 获取企业账户
   *
   * @param request GetFinanceAccountRequest
   * @return GetFinanceAccountResponse
   */
  async getFinanceAccount(request: GetFinanceAccountRequest): Promise<GetFinanceAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFinanceAccountHeaders({ });
    return await this.getFinanceAccountWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取单条项目
   *
   * @param request GetProjectRequest
   * @param headers GetProjectHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetProjectResponse
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
   * @summary 获取单条项目
   *
   * @param request GetProjectRequest
   * @return GetProjectResponse
   */
  async getProject(request: GetProjectRequest): Promise<GetProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectHeaders({ });
    return await this.getProjectWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取智能财务单据详情
   *
   * @param request GetReceiptRequest
   * @param headers GetReceiptHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetReceiptResponse
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
   * @summary 获取智能财务单据详情
   *
   * @param request GetReceiptRequest
   * @return GetReceiptResponse
   */
  async getReceipt(request: GetReceiptRequest): Promise<GetReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetReceiptHeaders({ });
    return await this.getReceiptWithOptions(request, headers, runtime);
  }

  /**
   * @summary 获取智能财务应用内维护的供应商信息
   *
   * @param request GetSupplierRequest
   * @param headers GetSupplierHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return GetSupplierResponse
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
   * @summary 获取智能财务应用内维护的供应商信息
   *
   * @param request GetSupplierRequest
   * @return GetSupplierResponse
   */
  async getSupplier(request: GetSupplierRequest): Promise<GetSupplierResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSupplierHeaders({ });
    return await this.getSupplierWithOptions(request, headers, runtime);
  }

  /**
   * @summary 根据不同的bizType查询不同的数据
   *
   * @param request LinkCommonInvokeRequest
   * @param headers LinkCommonInvokeHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return LinkCommonInvokeResponse
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
   * @summary 根据不同的bizType查询不同的数据
   *
   * @param request LinkCommonInvokeRequest
   * @return LinkCommonInvokeResponse
   */
  async linkCommonInvoke(request: LinkCommonInvokeRequest): Promise<LinkCommonInvokeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LinkCommonInvokeHeaders({ });
    return await this.linkCommonInvokeWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量获取费用类别
   *
   * @param request QueryCategoryByPageRequest
   * @param headers QueryCategoryByPageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCategoryByPageResponse
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
   * @summary 批量获取费用类别
   *
   * @param request QueryCategoryByPageRequest
   * @return QueryCategoryByPageResponse
   */
  async queryCategoryByPage(request: QueryCategoryByPageRequest): Promise<QueryCategoryByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCategoryByPageHeaders({ });
    return await this.queryCategoryByPageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页批量获取智能财务应用内维护的客户信息
   *
   * @param request QueryCustomerByPageRequest
   * @param headers QueryCustomerByPageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryCustomerByPageResponse
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
   * @summary 分页批量获取智能财务应用内维护的客户信息
   *
   * @param request QueryCustomerByPageRequest
   * @return QueryCustomerByPageResponse
   */
  async queryCustomerByPage(request: QueryCustomerByPageRequest): Promise<QueryCustomerByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerByPageHeaders({ });
    return await this.queryCustomerByPageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 批量获取企业账户
   *
   * @param request QueryEnterpriseAccountByPageRequest
   * @param headers QueryEnterpriseAccountByPageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryEnterpriseAccountByPageResponse
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
   * @summary 批量获取企业账户
   *
   * @param request QueryEnterpriseAccountByPageRequest
   * @return QueryEnterpriseAccountByPageResponse
   */
  async queryEnterpriseAccountByPage(request: QueryEnterpriseAccountByPageRequest): Promise<QueryEnterpriseAccountByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEnterpriseAccountByPageHeaders({ });
    return await this.queryEnterpriseAccountByPageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询支付订单详情
   *
   * @param request QueryInstancePaymentOrderDetailRequest
   * @param headers QueryInstancePaymentOrderDetailHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryInstancePaymentOrderDetailResponse
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
   * @summary 查询支付订单详情
   *
   * @param request QueryInstancePaymentOrderDetailRequest
   * @return QueryInstancePaymentOrderDetailResponse
   */
  async queryInstancePaymentOrderDetail(instanceId: string, request: QueryInstancePaymentOrderDetailRequest): Promise<QueryInstancePaymentOrderDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInstancePaymentOrderDetailHeaders({ });
    return await this.queryInstancePaymentOrderDetailWithOptions(instanceId, request, headers, runtime);
  }

  /**
   * @summary 批量获取项目信息
   *
   * @param request QueryProjectByPageRequest
   * @param headers QueryProjectByPageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryProjectByPageResponse
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
   * @summary 批量获取项目信息
   *
   * @param request QueryProjectByPageRequest
   * @return QueryProjectByPageResponse
   */
  async queryProjectByPage(request: QueryProjectByPageRequest): Promise<QueryProjectByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProjectByPageHeaders({ });
    return await this.queryProjectByPageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 分页批量获取智能财务应用内维护的供应商信息
   *
   * @param request QuerySupplierByPageRequest
   * @param headers QuerySupplierByPageHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QuerySupplierByPageResponse
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
   * @summary 分页批量获取智能财务应用内维护的供应商信息
   *
   * @param request QuerySupplierByPageRequest
   * @return QuerySupplierByPageResponse
   */
  async querySupplierByPage(request: QuerySupplierByPageRequest): Promise<QuerySupplierByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySupplierByPageHeaders({ });
    return await this.querySupplierByPageWithOptions(request, headers, runtime);
  }

  /**
   * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
   *
   * @param request QueryUserRoleListRequest
   * @param headers QueryUserRoleListHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return QueryUserRoleListResponse
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
   * @summary 查询用户角色成员，支持分页，可获取某个企业主体下的角色成员
   *
   * @param request QueryUserRoleListRequest
   * @return QueryUserRoleListResponse
   */
  async queryUserRoleList(request: QueryUserRoleListRequest): Promise<QueryUserRoleListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserRoleListHeaders({ });
    return await this.queryUserRoleListWithOptions(request, headers, runtime);
  }

  /**
   * @summary 签约企业账户
   *
   * @param request SignEnterpriseAccountRequest
   * @param headers SignEnterpriseAccountHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SignEnterpriseAccountResponse
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
   * @summary 签约企业账户
   *
   * @param request SignEnterpriseAccountRequest
   * @return SignEnterpriseAccountResponse
   */
  async signEnterpriseAccount(request: SignEnterpriseAccountRequest): Promise<SignEnterpriseAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignEnterpriseAccountHeaders({ });
    return await this.signEnterpriseAccountWithOptions(request, headers, runtime);
  }

  /**
   * @summary 发送银企支付回单文件信息
   *
   * @param request SyncReceiptRecallRequest
   * @param headers SyncReceiptRecallHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SyncReceiptRecallResponse
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
   * @summary 发送银企支付回单文件信息
   *
   * @param request SyncReceiptRecallRequest
   * @return SyncReceiptRecallResponse
   */
  async syncReceiptRecall(request: SyncReceiptRecallRequest): Promise<SyncReceiptRecallResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SyncReceiptRecallHeaders({ });
    return await this.syncReceiptRecallWithOptions(request, headers, runtime);
  }

  /**
   * @summary 更新单据的支付状态
   *
   * @param tmpReq UpdateInstanceOrderInfoRequest
   * @param headers UpdateInstanceOrderInfoHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateInstanceOrderInfoResponse
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
   * @summary 更新单据的支付状态
   *
   * @param request UpdateInstanceOrderInfoRequest
   * @return UpdateInstanceOrderInfoResponse
   */
  async updateInstanceOrderInfo(instanceId: string, request: UpdateInstanceOrderInfoRequest): Promise<UpdateInstanceOrderInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceOrderInfoHeaders({ });
    return await this.updateInstanceOrderInfoWithOptions(instanceId, request, headers, runtime);
  }

}
