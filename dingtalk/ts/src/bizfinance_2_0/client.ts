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
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchDeleteReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCategoryResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFinanceAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: GetProjectResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSupplierResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCategoryByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCustomerByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryEnterpriseAccountByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class QueryInstancePaymentOrderDetailResponseBody extends $tea.Model {
  result?: QueryInstancePaymentOrderDetailResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryInstancePaymentOrderDetailResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryInstancePaymentOrderDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryProjectByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers: { [key: string]: string };
  statusCode: number;
  body: QuerySupplierByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  operator?: string;
  signOperateType?: string;
  static names(): { [key: string]: string } {
    return {
      bankCardNo: 'bankCardNo',
      operator: 'operator',
      signOperateType: 'signOperateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bankCardNo: 'string',
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
  headers: { [key: string]: string };
  statusCode: number;
  body: SignEnterpriseAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  outOrderNo?: string;
  payerBank?: UpdateInstanceOrderInfoRequestPayerBank;
  status?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      failReason: 'failReason',
      outOrderNo: 'outOrderNo',
      payerBank: 'payerBank',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failReason: 'string',
      outOrderNo: 'string',
      payerBank: UpdateInstanceOrderInfoRequestPayerBank,
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
  outOrderNo?: string;
  payerBankShrink?: string;
  status?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      failReason: 'failReason',
      outOrderNo: 'outOrderNo',
      payerBankShrink: 'payerBank',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failReason: 'string',
      outOrderNo: 'string',
      payerBankShrink: 'string',
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
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateInstanceOrderInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO extends $tea.Model {
  bankBranchCode?: string;
  bankBranchName?: string;
  bankCardNo?: string;
  bankCode?: string;
  bankName?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
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

export class QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO extends $tea.Model {
  bankOpenDTO?: QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO;
  static names(): { [key: string]: string } {
    return {
      bankOpenDTO: 'bankOpenDTO',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bankOpenDTO: QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTOBankOpenDTO,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO extends $tea.Model {
  bankBranchCode?: string;
  bankBranchName?: string;
  bankCardNo?: string;
  bankCode?: string;
  bankName?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
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

export class QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO extends $tea.Model {
  bankOpenDTO?: QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO;
  enterpriseAccountCode?: string;
  static names(): { [key: string]: string } {
    return {
      bankOpenDTO: 'bankOpenDTO',
      enterpriseAccountCode: 'enterpriseAccountCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bankOpenDTO: QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTOBankOpenDTO,
      enterpriseAccountCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancePaymentOrderDetailResponseBodyResult extends $tea.Model {
  amount?: string;
  instanceId?: string;
  payeeAccountDTO?: QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO;
  payerAccountDTO?: QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO;
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
      payeeAccountDTO: QueryInstancePaymentOrderDetailResponseBodyResultPayeeAccountDTO,
      payerAccountDTO: QueryInstancePaymentOrderDetailResponseBodyResultPayerAccountDTO,
      remark: 'string',
      usage: 'string',
      userId: 'string',
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

  async batchDeleteReceipt(request: BatchDeleteReceiptRequest): Promise<BatchDeleteReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchDeleteReceiptHeaders({ });
    return await this.batchDeleteReceiptWithOptions(request, headers, runtime);
  }

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

  async getCategory(request: GetCategoryRequest): Promise<GetCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCategoryHeaders({ });
    return await this.getCategoryWithOptions(request, headers, runtime);
  }

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

  async getFinanceAccount(request: GetFinanceAccountRequest): Promise<GetFinanceAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFinanceAccountHeaders({ });
    return await this.getFinanceAccountWithOptions(request, headers, runtime);
  }

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

  async getProject(request: GetProjectRequest): Promise<GetProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectHeaders({ });
    return await this.getProjectWithOptions(request, headers, runtime);
  }

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

  async getSupplier(request: GetSupplierRequest): Promise<GetSupplierResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSupplierHeaders({ });
    return await this.getSupplierWithOptions(request, headers, runtime);
  }

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

  async queryCategoryByPage(request: QueryCategoryByPageRequest): Promise<QueryCategoryByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCategoryByPageHeaders({ });
    return await this.queryCategoryByPageWithOptions(request, headers, runtime);
  }

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

  async queryCustomerByPage(request: QueryCustomerByPageRequest): Promise<QueryCustomerByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerByPageHeaders({ });
    return await this.queryCustomerByPageWithOptions(request, headers, runtime);
  }

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

  async queryEnterpriseAccountByPage(request: QueryEnterpriseAccountByPageRequest): Promise<QueryEnterpriseAccountByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEnterpriseAccountByPageHeaders({ });
    return await this.queryEnterpriseAccountByPageWithOptions(request, headers, runtime);
  }

  async queryInstancePaymentOrderDetailWithOptions(instanceId: string, headers: QueryInstancePaymentOrderDetailHeaders, runtime: $Util.RuntimeOptions): Promise<QueryInstancePaymentOrderDetailResponse> {
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

  async queryInstancePaymentOrderDetail(instanceId: string): Promise<QueryInstancePaymentOrderDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInstancePaymentOrderDetailHeaders({ });
    return await this.queryInstancePaymentOrderDetailWithOptions(instanceId, headers, runtime);
  }

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

  async queryProjectByPage(request: QueryProjectByPageRequest): Promise<QueryProjectByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProjectByPageHeaders({ });
    return await this.queryProjectByPageWithOptions(request, headers, runtime);
  }

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

  async querySupplierByPage(request: QuerySupplierByPageRequest): Promise<QuerySupplierByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySupplierByPageHeaders({ });
    return await this.querySupplierByPageWithOptions(request, headers, runtime);
  }

  async signEnterpriseAccountWithOptions(request: SignEnterpriseAccountRequest, headers: SignEnterpriseAccountHeaders, runtime: $Util.RuntimeOptions): Promise<SignEnterpriseAccountResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bankCardNo)) {
      query["bankCardNo"] = request.bankCardNo;
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

  async signEnterpriseAccount(request: SignEnterpriseAccountRequest): Promise<SignEnterpriseAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SignEnterpriseAccountHeaders({ });
    return await this.signEnterpriseAccountWithOptions(request, headers, runtime);
  }

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

    if (!Util.isUnset(request.outOrderNo)) {
      query["outOrderNo"] = request.outOrderNo;
    }

    if (!Util.isUnset(request.payerBankShrink)) {
      query["payerBank"] = request.payerBankShrink;
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

  async updateInstanceOrderInfo(instanceId: string, request: UpdateInstanceOrderInfoRequest): Promise<UpdateInstanceOrderInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceOrderInfoHeaders({ });
    return await this.updateInstanceOrderInfoWithOptions(instanceId, request, headers, runtime);
  }

}
