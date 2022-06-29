// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BatchAddInvoiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequest extends $tea.Model {
  generalInvoiceVOList?: BatchAddInvoiceRequestGeneralInvoiceVOList[];
  static names(): { [key: string]: string } {
    return {
      generalInvoiceVOList: 'generalInvoiceVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      generalInvoiceVOList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceResponseBody extends $tea.Model {
  result?: BatchAddInvoiceResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': BatchAddInvoiceResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchAddInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchAddInvoiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerRequest extends $tea.Model {
  creator?: string;
  description?: string;
  name?: string;
  purchaserAccount?: string;
  purchaserAddress?: string;
  purchaserBankName?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  static names(): { [key: string]: string } {
    return {
      creator: 'creator',
      description: 'description',
      name: 'name',
      purchaserAccount: 'purchaserAccount',
      purchaserAddress: 'purchaserAddress',
      purchaserBankName: 'purchaserBankName',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creator: 'string',
      description: 'string',
      name: 'string',
      purchaserAccount: 'string',
      purchaserAddress: 'string',
      purchaserBankName: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponseBody extends $tea.Model {
  customerCode?: string;
  static names(): { [key: string]: string } {
    return {
      customerCode: 'customerCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateReceiptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateReceiptRequest extends $tea.Model {
  receipts?: CreateReceiptRequestReceipts[];
  static names(): { [key: string]: string } {
    return {
      receipts: 'receipts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receipts: { 'type': 'array', 'itemType': CreateReceiptRequestReceipts },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateReceiptResponseBody extends $tea.Model {
  results?: CreateReceiptResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': CreateReceiptResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateReceiptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateReceiptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteReceiptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteReceiptRequest extends $tea.Model {
  receipts?: DeleteReceiptRequestReceipts[];
  static names(): { [key: string]: string } {
    return {
      receipts: 'receipts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receipts: { 'type': 'array', 'itemType': DeleteReceiptRequestReceipts },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteReceiptResponseBody extends $tea.Model {
  results?: DeleteReceiptResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': DeleteReceiptResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteReceiptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteReceiptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBookkeepingUserListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBookkeepingUserListResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBookkeepingUserListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetBookkeepingUserListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetBookkeepingUserListResponseBody,
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

export class GetCategoryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCategoryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCategoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerRequest extends $tea.Model {
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

export class GetCustomerResponseBody extends $tea.Model {
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCustomerResponseBody,
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
  amount?: string;
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
  body: GetFinanceAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetFinanceAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageRequest extends $tea.Model {
  endTime?: number;
  financeType?: string;
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  taxNo?: string;
  verifyStatus?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      financeType: 'financeType',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
      taxNo: 'taxNo',
      verifyStatus: 'verifyStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      financeType: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      startTime: 'number',
      taxNo: 'string',
      verifyStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBody extends $tea.Model {
  list?: GetInvoiceByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInvoiceByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInvoiceByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIsNewVersionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIsNewVersionResponseBody extends $tea.Model {
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

export class GetIsNewVersionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetIsNewVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetIsNewVersionResponseBody,
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
  corpId?: string;
  createTime?: number;
  creator?: string;
  description?: string;
  projectCode?: string;
  projectName?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createTime: 'createTime',
      creator: 'creator',
      description: 'description',
      projectCode: 'projectCode',
      projectName: 'projectName',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createTime: 'number',
      creator: 'string',
      description: 'string',
      projectCode: 'string',
      projectName: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProjectResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetProjectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: GetReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSupplierResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSupplierResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryCategoryByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: QueryCustomerByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCustomerByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerInfoRequest extends $tea.Model {
  name?: string;
  pageNumber?: number;
  pageSize?: number;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerInfoResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryCustomerInfoResponseBodyList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryCustomerInfoResponseBodyList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCustomerInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCustomerInfoResponseBody,
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
  body: QueryEnterpriseAccountByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryEnterpriseAccountByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInvoiceRelationCountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInvoiceRelationCountResponseBody extends $tea.Model {
  relationCountMap?: { [key: string]: number };
  static names(): { [key: string]: string } {
    return {
      relationCountMap: 'relationCountMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      relationCountMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInvoiceRelationCountResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryInvoiceRelationCountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryInvoiceRelationCountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionByUserIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionByUserIdRequest extends $tea.Model {
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

export class QueryPermissionByUserIdResponseBody extends $tea.Model {
  permissionDTOList?: QueryPermissionByUserIdResponseBodyPermissionDTOList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      permissionDTOList: 'permissionDTOList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      permissionDTOList: { 'type': 'array', 'itemType': QueryPermissionByUserIdResponseBodyPermissionDTOList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionByUserIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryPermissionByUserIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryPermissionByUserIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionRoleMemberHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionRoleMemberRequest extends $tea.Model {
  roleCodeList?: string[];
  static names(): { [key: string]: string } {
    return {
      roleCodeList: 'roleCodeList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleCodeList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionRoleMemberResponseBody extends $tea.Model {
  roleMemberMap?: { [key: string]: RoleMemberMapValue };
  static names(): { [key: string]: string } {
    return {
      roleMemberMap: 'roleMemberMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleMemberMap: { 'type': 'map', 'keyType': 'string', 'valueType': RoleMemberMapValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionRoleMemberResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryPermissionRoleMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryPermissionRoleMemberResponseBody,
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
  body: QueryProjectByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryProjectByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceRequest extends $tea.Model {
  endTime?: number;
  invoiceFilter?: QueryReceiptForInvoiceRequestInvoiceFilter;
  pageNumber?: number;
  pageSize?: number;
  receiptStatus?: string;
  startTime?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      invoiceFilter: 'invoiceFilter',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      receiptStatus: 'receiptStatus',
      startTime: 'startTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      invoiceFilter: QueryReceiptForInvoiceRequestInvoiceFilter,
      pageNumber: 'number',
      pageSize: 'number',
      receiptStatus: 'string',
      startTime: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceResponseBody extends $tea.Model {
  hasMore?: string;
  list?: QueryReceiptForInvoiceResponseBodyList[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'string',
      list: { 'type': 'array', 'itemType': QueryReceiptForInvoiceResponseBodyList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryReceiptForInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryReceiptForInvoiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsByPageRequest extends $tea.Model {
  endTime?: number;
  modelId?: string;
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  timeFilterField?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      modelId: 'modelId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
      timeFilterField: 'timeFilterField',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      modelId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      startTime: 'number',
      timeFilterField: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsByPageResponseBody extends $tea.Model {
  hasMore?: string;
  list?: QueryReceiptsByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'string',
      list: { 'type': 'array', 'itemType': QueryReceiptsByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryReceiptsByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryReceiptsByPageResponseBody,
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
  body: QuerySupplierByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QuerySupplierByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequest extends $tea.Model {
  blueGeneralInvoiceVO?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO;
  invoiceCode?: string;
  invoiceNo?: string;
  redGeneralInvoiceVO?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      blueGeneralInvoiceVO: 'blueGeneralInvoiceVO',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      redGeneralInvoiceVO: 'redGeneralInvoiceVO',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blueGeneralInvoiceVO: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO,
      invoiceCode: 'string',
      invoiceNo: 'string',
      redGeneralInvoiceVO: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO,
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusResponseBody extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInvoiceAbandonStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInvoiceAbandonStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequest extends $tea.Model {
  generalInvoiceVO?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO;
  invoiceCode?: string;
  invoiceNo?: string;
  receiptCode?: string;
  static names(): { [key: string]: string } {
    return {
      generalInvoiceVO: 'generalInvoiceVO',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      receiptCode: 'receiptCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      generalInvoiceVO: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO,
      invoiceCode: 'string',
      invoiceNo: 'string',
      receiptCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedResponseBody extends $tea.Model {
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

export class UpdateInvoiceAndReceiptRelatedResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInvoiceAndReceiptRelatedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInvoiceAndReceiptRelatedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusRequest extends $tea.Model {
  generalInvoiceVO?: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO;
  invoiceCode?: string;
  invoiceNo?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      generalInvoiceVO: 'generalInvoiceVO',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      generalInvoiceVO: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO,
      invoiceCode: 'string',
      invoiceNo: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusResponseBody extends $tea.Model {
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

export class UpdateInvoiceIgnoreStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInvoiceIgnoreStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInvoiceIgnoreStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVerifyStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVerifyStatusRequest extends $tea.Model {
  invoiceKeyVOList?: UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList[];
  verifyStatus?: string;
  static names(): { [key: string]: string } {
    return {
      invoiceKeyVOList: 'invoiceKeyVOList',
      verifyStatus: 'verifyStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoiceKeyVOList: { 'type': 'array', 'itemType': UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList },
      verifyStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVerifyStatusResponseBody extends $tea.Model {
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

export class UpdateInvoiceVerifyStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInvoiceVerifyStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInvoiceVerifyStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptRequest extends $tea.Model {
  receipts?: UpdateReceiptRequestReceipts[];
  static names(): { [key: string]: string } {
    return {
      receipts: 'receipts',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receipts: { 'type': 'array', 'itemType': UpdateReceiptRequestReceipts },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptResponseBody extends $tea.Model {
  results?: UpdateReceiptResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': UpdateReceiptResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateReceiptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RoleMemberMapValue extends $tea.Model {
  roleCode?: string;
  memberList?: RoleMemberMapValueMemberList[];
  static names(): { [key: string]: string } {
    return {
      roleCode: 'roleCode',
      memberList: 'memberList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleCode: 'string',
      memberList: { 'type': 'array', 'itemType': RoleMemberMapValueMemberList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVO extends $tea.Model {
  amount?: string;
  goodName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodName: 'goodName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetail extends $tea.Model {
  amount?: string;
  cardNo?: string;
  endDate?: string;
  goodsName?: string;
  revenueCode?: string;
  rowNo?: string;
  startDate?: string;
  taxAmount?: string;
  taxRate?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      cardNo: 'cardNo',
      endDate: 'endDate',
      goodsName: 'goodsName',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      startDate: 'startDate',
      taxAmount: 'taxAmount',
      taxRate: 'taxRate',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      cardNo: 'string',
      endDate: 'string',
      goodsName: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      startDate: 'string',
      taxAmount: 'string',
      taxRate: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVO extends $tea.Model {
  auctionUnit?: string;
  auctionUnitAddress?: string;
  auctionUnitBank?: string;
  auctionUnitTaxNo?: string;
  auctionUtilTel?: string;
  carModel?: string;
  cardNo?: string;
  registration?: string;
  transferVehicle?: string;
  usedCarAddress?: string;
  usedCarMarket?: string;
  usedCarMarketBank?: string;
  usedCarMarketPhone?: string;
  usedCarMarketTaxNo?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      auctionUnit: 'auctionUnit',
      auctionUnitAddress: 'auctionUnitAddress',
      auctionUnitBank: 'auctionUnitBank',
      auctionUnitTaxNo: 'auctionUnitTaxNo',
      auctionUtilTel: 'auctionUtilTel',
      carModel: 'carModel',
      cardNo: 'cardNo',
      registration: 'registration',
      transferVehicle: 'transferVehicle',
      usedCarAddress: 'usedCarAddress',
      usedCarMarket: 'usedCarMarket',
      usedCarMarketBank: 'usedCarMarketBank',
      usedCarMarketPhone: 'usedCarMarketPhone',
      usedCarMarketTaxNo: 'usedCarMarketTaxNo',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auctionUnit: 'string',
      auctionUnitAddress: 'string',
      auctionUnitBank: 'string',
      auctionUnitTaxNo: 'string',
      auctionUtilTel: 'string',
      carModel: 'string',
      cardNo: 'string',
      registration: 'string',
      transferVehicle: 'string',
      usedCarAddress: 'string',
      usedCarMarket: 'string',
      usedCarMarketBank: 'string',
      usedCarMarketPhone: 'string',
      usedCarMarketTaxNo: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVO extends $tea.Model {
  brand?: string;
  certificateNo?: string;
  engineNo?: string;
  idCardNo?: string;
  importCertificateNo?: string;
  inspectionListNo?: string;
  maxPassengers?: string;
  originPlace?: string;
  paymentVoucherNo?: string;
  taxAuthorityName?: string;
  taxAuthorityNo?: string;
  taxRate?: string;
  tonnage?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      brand: 'brand',
      certificateNo: 'certificateNo',
      engineNo: 'engineNo',
      idCardNo: 'idCardNo',
      importCertificateNo: 'importCertificateNo',
      inspectionListNo: 'inspectionListNo',
      maxPassengers: 'maxPassengers',
      originPlace: 'originPlace',
      paymentVoucherNo: 'paymentVoucherNo',
      taxAuthorityName: 'taxAuthorityName',
      taxAuthorityNo: 'taxAuthorityNo',
      taxRate: 'taxRate',
      tonnage: 'tonnage',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brand: 'string',
      certificateNo: 'string',
      engineNo: 'string',
      idCardNo: 'string',
      importCertificateNo: 'string',
      inspectionListNo: 'string',
      maxPassengers: 'string',
      originPlace: 'string',
      paymentVoucherNo: 'string',
      taxAuthorityName: 'string',
      taxAuthorityNo: 'string',
      taxRate: 'string',
      tonnage: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequestGeneralInvoiceVOList extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVO?: BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVO;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetail?: BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetail;
  sellerAddress?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  status?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVO?: BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVO;
  vehicleSaleDetailVO?: BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVO;
  verifyStatus?: string;
  voucherCode?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      amount: 'amount',
      amountWithTax: 'amountWithTax',
      checkCode: 'checkCode',
      checkTime: 'checkTime',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVO: 'generalInvoiceDetailVO',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetail: 'secondHandCarInvoiceDetail',
      sellerAddress: 'sellerAddress',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      status: 'status',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVO: 'usedVehicleSaleDetailVO',
      vehicleSaleDetailVO: 'vehicleSaleDetailVO',
      verifyStatus: 'verifyStatus',
      voucherCode: 'voucherCode',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      amount: 'string',
      amountWithTax: 'string',
      checkCode: 'string',
      checkTime: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVO: BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVO,
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetail: BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetail,
      sellerAddress: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      status: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVO: BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVO,
      vehicleSaleDetailVO: BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVO,
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceResponseBodyResult extends $tea.Model {
  errorKey?: string;
  errorMsg?: string;
  static names(): { [key: string]: string } {
    return {
      errorKey: 'errorKey',
      errorMsg: 'errorMsg',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorKey: 'string',
      errorMsg: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateReceiptRequestReceipts extends $tea.Model {
  amount?: string;
  categoryCode?: string;
  code?: string;
  createTime?: number;
  createUserId?: string;
  customerCode?: string;
  enterpriseAcountCode?: string;
  occurDate?: number;
  principalId?: string;
  projectCode?: string;
  receiptType?: number;
  remark?: string;
  supplierCode?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      categoryCode: 'categoryCode',
      code: 'code',
      createTime: 'createTime',
      createUserId: 'createUserId',
      customerCode: 'customerCode',
      enterpriseAcountCode: 'enterpriseAcountCode',
      occurDate: 'occurDate',
      principalId: 'principalId',
      projectCode: 'projectCode',
      receiptType: 'receiptType',
      remark: 'remark',
      supplierCode: 'supplierCode',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      categoryCode: 'string',
      code: 'string',
      createTime: 'number',
      createUserId: 'string',
      customerCode: 'string',
      enterpriseAcountCode: 'string',
      occurDate: 'number',
      principalId: 'string',
      projectCode: 'string',
      receiptType: 'number',
      remark: 'string',
      supplierCode: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateReceiptResponseBodyResults extends $tea.Model {
  code?: string;
  errorCode?: string;
  errorMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteReceiptRequestReceipts extends $tea.Model {
  code?: string;
  deleteUserId?: string;
  receiptType?: number;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      deleteUserId: 'deleteUserId',
      receiptType: 'receiptType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      deleteUserId: 'string',
      receiptType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteReceiptResponseBodyResults extends $tea.Model {
  code?: string;
  errorCode?: string;
  errorMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodName: 'goodName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail extends $tea.Model {
  amount?: string;
  cardNo?: string;
  endDate?: string;
  goodsName?: string;
  revenueCode?: string;
  rowNo?: string;
  startDate?: string;
  taxAmount?: string;
  taxRate?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      cardNo: 'cardNo',
      endDate: 'endDate',
      goodsName: 'goodsName',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      startDate: 'startDate',
      taxAmount: 'taxAmount',
      taxRate: 'taxRate',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      cardNo: 'string',
      endDate: 'string',
      goodsName: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      startDate: 'string',
      taxAmount: 'string',
      taxRate: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO extends $tea.Model {
  auctionUnit?: string;
  auctionUnitAddress?: string;
  auctionUnitBank?: string;
  auctionUnitTaxNo?: string;
  auctionUtilTel?: string;
  carModel?: string;
  cardNo?: string;
  registration?: string;
  transferVehicle?: string;
  usedCarAddress?: string;
  usedCarMarket?: string;
  usedCarMarketBank?: string;
  usedCarMarketPhone?: string;
  usedCarMarketTaxNo?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      auctionUnit: 'auctionUnit',
      auctionUnitAddress: 'auctionUnitAddress',
      auctionUnitBank: 'auctionUnitBank',
      auctionUnitTaxNo: 'auctionUnitTaxNo',
      auctionUtilTel: 'auctionUtilTel',
      carModel: 'carModel',
      cardNo: 'cardNo',
      registration: 'registration',
      transferVehicle: 'transferVehicle',
      usedCarAddress: 'usedCarAddress',
      usedCarMarket: 'usedCarMarket',
      usedCarMarketBank: 'usedCarMarketBank',
      usedCarMarketPhone: 'usedCarMarketPhone',
      usedCarMarketTaxNo: 'usedCarMarketTaxNo',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auctionUnit: 'string',
      auctionUnitAddress: 'string',
      auctionUnitBank: 'string',
      auctionUnitTaxNo: 'string',
      auctionUtilTel: 'string',
      carModel: 'string',
      cardNo: 'string',
      registration: 'string',
      transferVehicle: 'string',
      usedCarAddress: 'string',
      usedCarMarket: 'string',
      usedCarMarketBank: 'string',
      usedCarMarketPhone: 'string',
      usedCarMarketTaxNo: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBodyListVehicleSaleDetailVO extends $tea.Model {
  brand?: string;
  certificateNo?: string;
  engineNo?: string;
  idCardNo?: string;
  importCertificateNo?: string;
  maxPassengers?: string;
  originPlace?: string;
  paymentVoucherNo?: string;
  taxAuthorityName?: string;
  taxAuthorityNo?: string;
  taxRate?: string;
  tonnage?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      brand: 'brand',
      certificateNo: 'certificateNo',
      engineNo: 'engineNo',
      idCardNo: 'idCardNo',
      importCertificateNo: 'importCertificateNo',
      maxPassengers: 'maxPassengers',
      originPlace: 'originPlace',
      paymentVoucherNo: 'paymentVoucherNo',
      taxAuthorityName: 'taxAuthorityName',
      taxAuthorityNo: 'taxAuthorityNo',
      taxRate: 'taxRate',
      tonnage: 'tonnage',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brand: 'string',
      certificateNo: 'string',
      engineNo: 'string',
      idCardNo: 'string',
      importCertificateNo: 'string',
      maxPassengers: 'string',
      originPlace: 'string',
      paymentVoucherNo: 'string',
      taxAuthorityName: 'string',
      taxAuthorityNo: 'string',
      taxRate: 'string',
      tonnage: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBodyList extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList[];
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetail?: GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail[];
  sellerAddress?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  status?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVO?: GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO;
  vehicleSaleDetailVO?: GetInvoiceByPageResponseBodyListVehicleSaleDetailVO;
  verifyStatus?: string;
  voucherCode?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      amount: 'amount',
      amountWithTax: 'amountWithTax',
      checkCode: 'checkCode',
      checkTime: 'checkTime',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetail: 'secondHandCarInvoiceDetail',
      sellerAddress: 'sellerAddress',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      status: 'status',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVO: 'usedVehicleSaleDetailVO',
      vehicleSaleDetailVO: 'vehicleSaleDetailVO',
      verifyStatus: 'verifyStatus',
      voucherCode: 'voucherCode',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      amount: 'string',
      amountWithTax: 'string',
      checkCode: 'string',
      checkTime: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyListGeneralInvoiceDetailVOList },
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetail: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyListSecondHandCarInvoiceDetail },
      sellerAddress: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      status: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVO: GetInvoiceByPageResponseBodyListUsedVehicleSaleDetailVO,
      vehicleSaleDetailVO: GetInvoiceByPageResponseBodyListVehicleSaleDetailVO,
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
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
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerInfoResponseBodyList extends $tea.Model {
  code?: string;
  description?: string;
  name?: string;
  purchaserAccount?: string;
  purchaserAddress?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  purchaserrBankName?: string;
  status?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      description: 'description',
      name: 'name',
      purchaserAccount: 'purchaserAccount',
      purchaserAddress: 'purchaserAddress',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      purchaserrBankName: 'purchaserrBankName',
      status: 'status',
      userDefineCode: 'userDefineCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      description: 'string',
      name: 'string',
      purchaserAccount: 'string',
      purchaserAddress: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      purchaserrBankName: 'string',
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
      createTime: 'number',
      creator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionByUserIdResponseBodyPermissionDTOList extends $tea.Model {
  actionIdList?: string[];
  resourceIdentity?: string;
  static names(): { [key: string]: string } {
    return {
      actionIdList: 'actionIdList',
      resourceIdentity: 'resourceIdentity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionIdList: { 'type': 'array', 'itemType': 'string' },
      resourceIdentity: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProjectByPageResponseBodyList extends $tea.Model {
  corpId?: string;
  createTime?: number;
  creator?: string;
  description?: string;
  projectCode?: string;
  projectName?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      createTime: 'createTime',
      creator: 'creator',
      description: 'description',
      projectCode: 'projectCode',
      projectName: 'projectName',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      createTime: 'number',
      creator: 'string',
      description: 'string',
      projectCode: 'string',
      projectName: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceRequestInvoiceFilter extends $tea.Model {
  financeType?: string;
  relationStatus?: string;
  static names(): { [key: string]: string } {
    return {
      financeType: 'financeType',
      relationStatus: 'relationStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      financeType: 'string',
      relationStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceResponseBodyList extends $tea.Model {
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

export class QueryReceiptsByPageResponseBodyList extends $tea.Model {
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

export class QuerySupplierByPageResponseBodyList extends $tea.Model {
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVO extends $tea.Model {
  amount?: string;
  goodName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodName: 'goodName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetail extends $tea.Model {
  amount?: string;
  cardNo?: string;
  endDate?: string;
  goodsName?: string;
  revenueCode?: string;
  rowNo?: string;
  startDate?: string;
  taxAmount?: string;
  taxRate?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      cardNo: 'cardNo',
      endDate: 'endDate',
      goodsName: 'goodsName',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      startDate: 'startDate',
      taxAmount: 'taxAmount',
      taxRate: 'taxRate',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      cardNo: 'string',
      endDate: 'string',
      goodsName: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      startDate: 'string',
      taxAmount: 'string',
      taxRate: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVO extends $tea.Model {
  auctionUnit?: string;
  auctionUnitAddress?: string;
  auctionUnitBank?: string;
  auctionUnitTaxNo?: string;
  auctionUtilTel?: string;
  carModel?: string;
  cardNo?: string;
  registration?: string;
  transferVehicle?: string;
  usedCarAddress?: string;
  usedCarMarket?: string;
  usedCarMarketBank?: string;
  usedCarMarketPhone?: string;
  usedCarMarketTaxNo?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      auctionUnit: 'auctionUnit',
      auctionUnitAddress: 'auctionUnitAddress',
      auctionUnitBank: 'auctionUnitBank',
      auctionUnitTaxNo: 'auctionUnitTaxNo',
      auctionUtilTel: 'auctionUtilTel',
      carModel: 'carModel',
      cardNo: 'cardNo',
      registration: 'registration',
      transferVehicle: 'transferVehicle',
      usedCarAddress: 'usedCarAddress',
      usedCarMarket: 'usedCarMarket',
      usedCarMarketBank: 'usedCarMarketBank',
      usedCarMarketPhone: 'usedCarMarketPhone',
      usedCarMarketTaxNo: 'usedCarMarketTaxNo',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auctionUnit: 'string',
      auctionUnitAddress: 'string',
      auctionUnitBank: 'string',
      auctionUnitTaxNo: 'string',
      auctionUtilTel: 'string',
      carModel: 'string',
      cardNo: 'string',
      registration: 'string',
      transferVehicle: 'string',
      usedCarAddress: 'string',
      usedCarMarket: 'string',
      usedCarMarketBank: 'string',
      usedCarMarketPhone: 'string',
      usedCarMarketTaxNo: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVO extends $tea.Model {
  brand?: string;
  certificateNo?: string;
  engineNo?: string;
  idCardNo?: string;
  importCertificateNo?: string;
  maxPassengers?: string;
  originPlace?: string;
  paymentVoucherNo?: string;
  taxAuthorityName?: string;
  taxAuthorityNo?: string;
  taxRate?: string;
  tonnage?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      brand: 'brand',
      certificateNo: 'certificateNo',
      engineNo: 'engineNo',
      idCardNo: 'idCardNo',
      importCertificateNo: 'importCertificateNo',
      maxPassengers: 'maxPassengers',
      originPlace: 'originPlace',
      paymentVoucherNo: 'paymentVoucherNo',
      taxAuthorityName: 'taxAuthorityName',
      taxAuthorityNo: 'taxAuthorityNo',
      taxRate: 'taxRate',
      tonnage: 'tonnage',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brand: 'string',
      certificateNo: 'string',
      engineNo: 'string',
      idCardNo: 'string',
      importCertificateNo: 'string',
      maxPassengers: 'string',
      originPlace: 'string',
      paymentVoucherNo: 'string',
      taxAuthorityName: 'string',
      taxAuthorityNo: 'string',
      taxRate: 'string',
      tonnage: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVO?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVO;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetail?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetail;
  sellerAddress?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  status?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVO?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVO;
  vehicleSaleDetailVO?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVO;
  verifyStatus?: string;
  voucherCode?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      amount: 'amount',
      amountWithTax: 'amountWithTax',
      checkCode: 'checkCode',
      checkTime: 'checkTime',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVO: 'generalInvoiceDetailVO',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetail: 'secondHandCarInvoiceDetail',
      sellerAddress: 'sellerAddress',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      status: 'status',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVO: 'usedVehicleSaleDetailVO',
      vehicleSaleDetailVO: 'vehicleSaleDetailVO',
      verifyStatus: 'verifyStatus',
      voucherCode: 'voucherCode',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      amount: 'string',
      amountWithTax: 'string',
      checkCode: 'string',
      checkTime: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVO: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVO,
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetail: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetail,
      sellerAddress: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      status: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVO: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVO,
      vehicleSaleDetailVO: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVO,
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodName: 'goodName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetail extends $tea.Model {
  amount?: string;
  cardNo?: string;
  endDate?: string;
  goodsName?: string;
  revenueCode?: string;
  rowNo?: string;
  startDate?: string;
  taxAmount?: string;
  taxRate?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      cardNo: 'cardNo',
      endDate: 'endDate',
      goodsName: 'goodsName',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      startDate: 'startDate',
      taxAmount: 'taxAmount',
      taxRate: 'taxRate',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      cardNo: 'string',
      endDate: 'string',
      goodsName: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      startDate: 'string',
      taxAmount: 'string',
      taxRate: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVO extends $tea.Model {
  auctionUnit?: string;
  auctionUnitAddress?: string;
  auctionUnitBank?: string;
  auctionUnitTaxNo?: string;
  auctionUtilTel?: string;
  carModel?: string;
  cardNo?: string;
  registration?: string;
  transferVehicle?: string;
  usedCarAddress?: string;
  usedCarMarket?: string;
  usedCarMarketBank?: string;
  usedCarMarketPhone?: string;
  usedCarMarketTaxNo?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      auctionUnit: 'auctionUnit',
      auctionUnitAddress: 'auctionUnitAddress',
      auctionUnitBank: 'auctionUnitBank',
      auctionUnitTaxNo: 'auctionUnitTaxNo',
      auctionUtilTel: 'auctionUtilTel',
      carModel: 'carModel',
      cardNo: 'cardNo',
      registration: 'registration',
      transferVehicle: 'transferVehicle',
      usedCarAddress: 'usedCarAddress',
      usedCarMarket: 'usedCarMarket',
      usedCarMarketBank: 'usedCarMarketBank',
      usedCarMarketPhone: 'usedCarMarketPhone',
      usedCarMarketTaxNo: 'usedCarMarketTaxNo',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auctionUnit: 'string',
      auctionUnitAddress: 'string',
      auctionUnitBank: 'string',
      auctionUnitTaxNo: 'string',
      auctionUtilTel: 'string',
      carModel: 'string',
      cardNo: 'string',
      registration: 'string',
      transferVehicle: 'string',
      usedCarAddress: 'string',
      usedCarMarket: 'string',
      usedCarMarketBank: 'string',
      usedCarMarketPhone: 'string',
      usedCarMarketTaxNo: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVO extends $tea.Model {
  brand?: string;
  certificateNo?: string;
  engineNo?: string;
  idCardNo?: string;
  importCertificateNo?: string;
  maxPassengers?: string;
  originPlace?: string;
  paymentVoucherNo?: string;
  taxAuthorityName?: string;
  taxAuthorityNo?: string;
  taxRate?: string;
  tonnage?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      brand: 'brand',
      certificateNo: 'certificateNo',
      engineNo: 'engineNo',
      idCardNo: 'idCardNo',
      importCertificateNo: 'importCertificateNo',
      maxPassengers: 'maxPassengers',
      originPlace: 'originPlace',
      paymentVoucherNo: 'paymentVoucherNo',
      taxAuthorityName: 'taxAuthorityName',
      taxAuthorityNo: 'taxAuthorityNo',
      taxRate: 'taxRate',
      tonnage: 'tonnage',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brand: 'string',
      certificateNo: 'string',
      engineNo: 'string',
      idCardNo: 'string',
      importCertificateNo: 'string',
      maxPassengers: 'string',
      originPlace: 'string',
      paymentVoucherNo: 'string',
      taxAuthorityName: 'string',
      taxAuthorityNo: 'string',
      taxRate: 'string',
      tonnage: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetail?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetail;
  sellerAddress?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  status?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVO?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVO;
  vehicleSaleDetailVO?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVO;
  verifyStatus?: string;
  voucherCode?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      amount: 'amount',
      amountWithTax: 'amountWithTax',
      checkCode: 'checkCode',
      checkTime: 'checkTime',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetail: 'secondHandCarInvoiceDetail',
      sellerAddress: 'sellerAddress',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      status: 'status',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVO: 'usedVehicleSaleDetailVO',
      vehicleSaleDetailVO: 'vehicleSaleDetailVO',
      verifyStatus: 'verifyStatus',
      voucherCode: 'voucherCode',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      amount: 'string',
      amountWithTax: 'string',
      checkCode: 'string',
      checkTime: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList,
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetail: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetail,
      sellerAddress: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      status: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVO: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVO,
      vehicleSaleDetailVO: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVO,
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVO extends $tea.Model {
  amount?: string;
  goodName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodName: 'goodName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetail extends $tea.Model {
  amount?: string;
  cardNo?: string;
  endDate?: string;
  goodsName?: string;
  revenueCode?: string;
  rowNo?: string;
  startDate?: string;
  taxAmount?: string;
  taxRate?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      cardNo: 'cardNo',
      endDate: 'endDate',
      goodsName: 'goodsName',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      startDate: 'startDate',
      taxAmount: 'taxAmount',
      taxRate: 'taxRate',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      cardNo: 'string',
      endDate: 'string',
      goodsName: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      startDate: 'string',
      taxAmount: 'string',
      taxRate: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVO extends $tea.Model {
  auctionUnit?: string;
  auctionUnitAddress?: string;
  auctionUnitBank?: string;
  auctionUnitTaxNo?: string;
  auctionUtilTel?: string;
  carModel?: string;
  cardNo?: string;
  registration?: string;
  transferVehicle?: string;
  usedCarAddress?: string;
  usedCarMarket?: string;
  usedCarMarketBank?: string;
  usedCarMarketPhone?: string;
  usedCarMarketTaxNo?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      auctionUnit: 'auctionUnit',
      auctionUnitAddress: 'auctionUnitAddress',
      auctionUnitBank: 'auctionUnitBank',
      auctionUnitTaxNo: 'auctionUnitTaxNo',
      auctionUtilTel: 'auctionUtilTel',
      carModel: 'carModel',
      cardNo: 'cardNo',
      registration: 'registration',
      transferVehicle: 'transferVehicle',
      usedCarAddress: 'usedCarAddress',
      usedCarMarket: 'usedCarMarket',
      usedCarMarketBank: 'usedCarMarketBank',
      usedCarMarketPhone: 'usedCarMarketPhone',
      usedCarMarketTaxNo: 'usedCarMarketTaxNo',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auctionUnit: 'string',
      auctionUnitAddress: 'string',
      auctionUnitBank: 'string',
      auctionUnitTaxNo: 'string',
      auctionUtilTel: 'string',
      carModel: 'string',
      cardNo: 'string',
      registration: 'string',
      transferVehicle: 'string',
      usedCarAddress: 'string',
      usedCarMarket: 'string',
      usedCarMarketBank: 'string',
      usedCarMarketPhone: 'string',
      usedCarMarketTaxNo: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVO extends $tea.Model {
  brand?: string;
  certificateNo?: string;
  engineNo?: string;
  idCardNo?: string;
  importCertificateNo?: string;
  maxPassengers?: string;
  originPlace?: string;
  paymentVoucherNo?: string;
  taxAuthorityName?: string;
  taxAuthorityNo?: string;
  taxRate?: string;
  tonnage?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      brand: 'brand',
      certificateNo: 'certificateNo',
      engineNo: 'engineNo',
      idCardNo: 'idCardNo',
      importCertificateNo: 'importCertificateNo',
      maxPassengers: 'maxPassengers',
      originPlace: 'originPlace',
      paymentVoucherNo: 'paymentVoucherNo',
      taxAuthorityName: 'taxAuthorityName',
      taxAuthorityNo: 'taxAuthorityNo',
      taxRate: 'taxRate',
      tonnage: 'tonnage',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brand: 'string',
      certificateNo: 'string',
      engineNo: 'string',
      idCardNo: 'string',
      importCertificateNo: 'string',
      maxPassengers: 'string',
      originPlace: 'string',
      paymentVoucherNo: 'string',
      taxAuthorityName: 'string',
      taxAuthorityNo: 'string',
      taxRate: 'string',
      tonnage: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVO?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVO;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetail?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetail;
  sellerAddress?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  status?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVO?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVO;
  vehicleSaleDetailVO?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVO;
  verifyStatus?: string;
  voucherCode?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      amount: 'amount',
      amountWithTax: 'amountWithTax',
      checkCode: 'checkCode',
      checkTime: 'checkTime',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVO: 'generalInvoiceDetailVO',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetail: 'secondHandCarInvoiceDetail',
      sellerAddress: 'sellerAddress',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      status: 'status',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVO: 'usedVehicleSaleDetailVO',
      vehicleSaleDetailVO: 'vehicleSaleDetailVO',
      verifyStatus: 'verifyStatus',
      voucherCode: 'voucherCode',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      amount: 'string',
      amountWithTax: 'string',
      checkCode: 'string',
      checkTime: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVO: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVO,
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetail: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetail,
      sellerAddress: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      status: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVO: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVO,
      vehicleSaleDetailVO: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVO,
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodName: 'goodName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetail extends $tea.Model {
  amount?: string;
  cardNo?: string;
  endDate?: string;
  goodsName?: string;
  revenueCode?: string;
  rowNo?: string;
  startDate?: string;
  taxAmount?: string;
  taxRate?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      cardNo: 'cardNo',
      endDate: 'endDate',
      goodsName: 'goodsName',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      startDate: 'startDate',
      taxAmount: 'taxAmount',
      taxRate: 'taxRate',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      cardNo: 'string',
      endDate: 'string',
      goodsName: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      startDate: 'string',
      taxAmount: 'string',
      taxRate: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVO extends $tea.Model {
  auctionUnit?: string;
  auctionUnitAddress?: string;
  auctionUnitBank?: string;
  auctionUnitTaxNo?: string;
  auctionUtilTel?: string;
  carModel?: string;
  cardNo?: string;
  registration?: string;
  transferVehicle?: string;
  usedCarAddress?: string;
  usedCarMarket?: string;
  usedCarMarketBank?: string;
  usedCarMarketPhone?: string;
  usedCarMarketTaxNo?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      auctionUnit: 'auctionUnit',
      auctionUnitAddress: 'auctionUnitAddress',
      auctionUnitBank: 'auctionUnitBank',
      auctionUnitTaxNo: 'auctionUnitTaxNo',
      auctionUtilTel: 'auctionUtilTel',
      carModel: 'carModel',
      cardNo: 'cardNo',
      registration: 'registration',
      transferVehicle: 'transferVehicle',
      usedCarAddress: 'usedCarAddress',
      usedCarMarket: 'usedCarMarket',
      usedCarMarketBank: 'usedCarMarketBank',
      usedCarMarketPhone: 'usedCarMarketPhone',
      usedCarMarketTaxNo: 'usedCarMarketTaxNo',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      auctionUnit: 'string',
      auctionUnitAddress: 'string',
      auctionUnitBank: 'string',
      auctionUnitTaxNo: 'string',
      auctionUtilTel: 'string',
      carModel: 'string',
      cardNo: 'string',
      registration: 'string',
      transferVehicle: 'string',
      usedCarAddress: 'string',
      usedCarMarket: 'string',
      usedCarMarketBank: 'string',
      usedCarMarketPhone: 'string',
      usedCarMarketTaxNo: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVO extends $tea.Model {
  brand?: string;
  certificateNo?: string;
  engineNo?: string;
  idCardNo?: string;
  importCertificateNo?: string;
  maxPassengers?: string;
  originPlace?: string;
  paymentVoucherNo?: string;
  taxAuthorityName?: string;
  taxAuthorityNo?: string;
  taxRate?: string;
  tonnage?: string;
  vehicleNo?: string;
  vehicleType?: string;
  static names(): { [key: string]: string } {
    return {
      brand: 'brand',
      certificateNo: 'certificateNo',
      engineNo: 'engineNo',
      idCardNo: 'idCardNo',
      importCertificateNo: 'importCertificateNo',
      maxPassengers: 'maxPassengers',
      originPlace: 'originPlace',
      paymentVoucherNo: 'paymentVoucherNo',
      taxAuthorityName: 'taxAuthorityName',
      taxAuthorityNo: 'taxAuthorityNo',
      taxRate: 'taxRate',
      tonnage: 'tonnage',
      vehicleNo: 'vehicleNo',
      vehicleType: 'vehicleType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brand: 'string',
      certificateNo: 'string',
      engineNo: 'string',
      idCardNo: 'string',
      importCertificateNo: 'string',
      maxPassengers: 'string',
      originPlace: 'string',
      paymentVoucherNo: 'string',
      taxAuthorityName: 'string',
      taxAuthorityNo: 'string',
      taxRate: 'string',
      tonnage: 'string',
      vehicleNo: 'string',
      vehicleType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVO extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetail?: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetail;
  sellerAddress?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  status?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVO?: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVO;
  vehicleSaleDetailVO?: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVO;
  verifyStatus?: string;
  voucherCode?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      amount: 'amount',
      amountWithTax: 'amountWithTax',
      checkCode: 'checkCode',
      checkTime: 'checkTime',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetail: 'secondHandCarInvoiceDetail',
      sellerAddress: 'sellerAddress',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      status: 'status',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVO: 'usedVehicleSaleDetailVO',
      vehicleSaleDetailVO: 'vehicleSaleDetailVO',
      verifyStatus: 'verifyStatus',
      voucherCode: 'voucherCode',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      amount: 'string',
      amountWithTax: 'string',
      checkCode: 'string',
      checkTime: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOGeneralInvoiceDetailVOList,
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetail: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOSecondHandCarInvoiceDetail,
      sellerAddress: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      status: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVO: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOUsedVehicleSaleDetailVO,
      vehicleSaleDetailVO: UpdateInvoiceIgnoreStatusRequestGeneralInvoiceVOVehicleSaleDetailVO,
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList extends $tea.Model {
  invoiceCode?: string;
  invoiceNo?: string;
  static names(): { [key: string]: string } {
    return {
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoiceCode: 'string',
      invoiceNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptRequestReceipts extends $tea.Model {
  amount?: string;
  categoryCode?: string;
  code?: string;
  customerCode?: string;
  enterpriseAcountCode?: string;
  occurDate?: number;
  principalId?: string;
  projectCode?: string;
  receiptType?: number;
  remark?: string;
  supplierCode?: string;
  title?: string;
  updateTime?: number;
  updateUserId?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      categoryCode: 'categoryCode',
      code: 'code',
      customerCode: 'customerCode',
      enterpriseAcountCode: 'enterpriseAcountCode',
      occurDate: 'occurDate',
      principalId: 'principalId',
      projectCode: 'projectCode',
      receiptType: 'receiptType',
      remark: 'remark',
      supplierCode: 'supplierCode',
      title: 'title',
      updateTime: 'updateTime',
      updateUserId: 'updateUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      categoryCode: 'string',
      code: 'string',
      customerCode: 'string',
      enterpriseAcountCode: 'string',
      occurDate: 'number',
      principalId: 'string',
      projectCode: 'string',
      receiptType: 'number',
      remark: 'string',
      supplierCode: 'string',
      title: 'string',
      updateTime: 'number',
      updateUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptResponseBodyResults extends $tea.Model {
  code?: string;
  errorCode?: string;
  errorMsg?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      errorCode: 'string',
      errorMsg: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RoleMemberMapValueMemberList extends $tea.Model {
  userId?: string;
  nick?: string;
  avatarUrl?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      nick: 'nick',
      avatarUrl: 'avatarUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      nick: 'string',
      avatarUrl: 'string',
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


  async batchAddInvoice(request: BatchAddInvoiceRequest): Promise<BatchAddInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddInvoiceHeaders({ });
    return await this.batchAddInvoiceWithOptions(request, headers, runtime);
  }

  async batchAddInvoiceWithOptions(request: BatchAddInvoiceRequest, headers: BatchAddInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<BatchAddInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.generalInvoiceVOList)) {
      body["generalInvoiceVOList"] = request.generalInvoiceVOList;
    }

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
    return $tea.cast<BatchAddInvoiceResponse>(await this.doROARequest("BatchAddInvoice", "bizfinance_1.0", "HTTP", "POST", "AK", `/v1.0/bizfinance/invoices/batch`, "json", req, runtime), new BatchAddInvoiceResponse({}));
  }

  async createCustomer(request: CreateCustomerRequest): Promise<CreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomerHeaders({ });
    return await this.createCustomerWithOptions(request, headers, runtime);
  }

  async createCustomerWithOptions(request: CreateCustomerRequest, headers: CreateCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creator)) {
      body["creator"] = request.creator;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.purchaserAccount)) {
      body["purchaserAccount"] = request.purchaserAccount;
    }

    if (!Util.isUnset(request.purchaserAddress)) {
      body["purchaserAddress"] = request.purchaserAddress;
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
    return $tea.cast<CreateCustomerResponse>(await this.doROARequest("CreateCustomer", "bizfinance_1.0", "HTTP", "POST", "AK", `/v1.0/bizfinance/auxiliaries/customers`, "json", req, runtime), new CreateCustomerResponse({}));
  }

  async createReceipt(request: CreateReceiptRequest): Promise<CreateReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateReceiptHeaders({ });
    return await this.createReceiptWithOptions(request, headers, runtime);
  }

  async createReceiptWithOptions(request: CreateReceiptRequest, headers: CreateReceiptHeaders, runtime: $Util.RuntimeOptions): Promise<CreateReceiptResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.receipts)) {
      body["receipts"] = request.receipts;
    }

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
    return $tea.cast<CreateReceiptResponse>(await this.doROARequest("CreateReceipt", "bizfinance_1.0", "HTTP", "POST", "AK", `/v1.0/bizfinance/receipts`, "json", req, runtime), new CreateReceiptResponse({}));
  }

  async deleteReceipt(request: DeleteReceiptRequest): Promise<DeleteReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteReceiptHeaders({ });
    return await this.deleteReceiptWithOptions(request, headers, runtime);
  }

  async deleteReceiptWithOptions(request: DeleteReceiptRequest, headers: DeleteReceiptHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteReceiptResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.receipts)) {
      body["receipts"] = request.receipts;
    }

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
    return $tea.cast<DeleteReceiptResponse>(await this.doROARequest("DeleteReceipt", "bizfinance_1.0", "HTTP", "POST", "AK", `/v1.0/bizfinance/receipts/remove`, "json", req, runtime), new DeleteReceiptResponse({}));
  }

  async getBookkeepingUserList(): Promise<GetBookkeepingUserListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBookkeepingUserListHeaders({ });
    return await this.getBookkeepingUserListWithOptions(headers, runtime);
  }

  async getBookkeepingUserListWithOptions(headers: GetBookkeepingUserListHeaders, runtime: $Util.RuntimeOptions): Promise<GetBookkeepingUserListResponse> {
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
    return $tea.cast<GetBookkeepingUserListResponse>(await this.doROARequest("GetBookkeepingUserList", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/bookkeeping/users`, "json", req, runtime), new GetBookkeepingUserListResponse({}));
  }

  async getCategory(request: GetCategoryRequest): Promise<GetCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCategoryHeaders({ });
    return await this.getCategoryWithOptions(request, headers, runtime);
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
    return $tea.cast<GetCategoryResponse>(await this.doROARequest("GetCategory", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/categories/get`, "json", req, runtime), new GetCategoryResponse({}));
  }

  async getCustomer(request: GetCustomerRequest): Promise<GetCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCustomerHeaders({ });
    return await this.getCustomerWithOptions(request, headers, runtime);
  }

  async getCustomerWithOptions(request: GetCustomerRequest, headers: GetCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<GetCustomerResponse> {
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
    return $tea.cast<GetCustomerResponse>(await this.doROARequest("GetCustomer", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/customers/details`, "json", req, runtime), new GetCustomerResponse({}));
  }

  async getFinanceAccount(request: GetFinanceAccountRequest): Promise<GetFinanceAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFinanceAccountHeaders({ });
    return await this.getFinanceAccountWithOptions(request, headers, runtime);
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
    return $tea.cast<GetFinanceAccountResponse>(await this.doROARequest("GetFinanceAccount", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/financeAccounts/get`, "json", req, runtime), new GetFinanceAccountResponse({}));
  }

  async getInvoiceByPage(request: GetInvoiceByPageRequest): Promise<GetInvoiceByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInvoiceByPageHeaders({ });
    return await this.getInvoiceByPageWithOptions(request, headers, runtime);
  }

  async getInvoiceByPageWithOptions(request: GetInvoiceByPageRequest, headers: GetInvoiceByPageHeaders, runtime: $Util.RuntimeOptions): Promise<GetInvoiceByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.financeType)) {
      query["financeType"] = request.financeType;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.taxNo)) {
      query["taxNo"] = request.taxNo;
    }

    if (!Util.isUnset(request.verifyStatus)) {
      query["verifyStatus"] = request.verifyStatus;
    }

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
    return $tea.cast<GetInvoiceByPageResponse>(await this.doROARequest("GetInvoiceByPage", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/invoices`, "json", req, runtime), new GetInvoiceByPageResponse({}));
  }

  async getIsNewVersion(): Promise<GetIsNewVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIsNewVersionHeaders({ });
    return await this.getIsNewVersionWithOptions(headers, runtime);
  }

  async getIsNewVersionWithOptions(headers: GetIsNewVersionHeaders, runtime: $Util.RuntimeOptions): Promise<GetIsNewVersionResponse> {
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
    return $tea.cast<GetIsNewVersionResponse>(await this.doROARequest("GetIsNewVersion", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/accounts/uses`, "json", req, runtime), new GetIsNewVersionResponse({}));
  }

  async getProject(request: GetProjectRequest): Promise<GetProjectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProjectHeaders({ });
    return await this.getProjectWithOptions(request, headers, runtime);
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
    return $tea.cast<GetProjectResponse>(await this.doROARequest("GetProject", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/projects/get`, "json", req, runtime), new GetProjectResponse({}));
  }

  async getReceipt(request: GetReceiptRequest): Promise<GetReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetReceiptHeaders({ });
    return await this.getReceiptWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetReceiptResponse>(await this.doROARequest("GetReceipt", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/receipts/details`, "json", req, runtime), new GetReceiptResponse({}));
  }

  async getSupplier(request: GetSupplierRequest): Promise<GetSupplierResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSupplierHeaders({ });
    return await this.getSupplierWithOptions(request, headers, runtime);
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
    return $tea.cast<GetSupplierResponse>(await this.doROARequest("GetSupplier", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/suppliers/details`, "json", req, runtime), new GetSupplierResponse({}));
  }

  async queryCategoryByPage(request: QueryCategoryByPageRequest): Promise<QueryCategoryByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCategoryByPageHeaders({ });
    return await this.queryCategoryByPageWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryCategoryByPageResponse>(await this.doROARequest("QueryCategoryByPage", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/categories/list`, "json", req, runtime), new QueryCategoryByPageResponse({}));
  }

  async queryCustomerByPage(request: QueryCustomerByPageRequest): Promise<QueryCustomerByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerByPageHeaders({ });
    return await this.queryCustomerByPageWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryCustomerByPageResponse>(await this.doROARequest("QueryCustomerByPage", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/customers`, "json", req, runtime), new QueryCustomerByPageResponse({}));
  }

  async queryCustomerInfo(request: QueryCustomerInfoRequest): Promise<QueryCustomerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerInfoHeaders({ });
    return await this.queryCustomerInfoWithOptions(request, headers, runtime);
  }

  async queryCustomerInfoWithOptions(request: QueryCustomerInfoRequest, headers: QueryCustomerInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomerInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      query["name"] = request.name;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.purchaserTaxNo)) {
      query["purchaserTaxNo"] = request.purchaserTaxNo;
    }

    if (!Util.isUnset(request.purchaserTel)) {
      query["purchaserTel"] = request.purchaserTel;
    }

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
    return $tea.cast<QueryCustomerInfoResponse>(await this.doROARequest("QueryCustomerInfo", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/auxiliaries/customers`, "json", req, runtime), new QueryCustomerInfoResponse({}));
  }

  async queryEnterpriseAccountByPage(request: QueryEnterpriseAccountByPageRequest): Promise<QueryEnterpriseAccountByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryEnterpriseAccountByPageHeaders({ });
    return await this.queryEnterpriseAccountByPageWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryEnterpriseAccountByPageResponse>(await this.doROARequest("QueryEnterpriseAccountByPage", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/financeAccounts/list`, "json", req, runtime), new QueryEnterpriseAccountByPageResponse({}));
  }

  async queryInvoiceRelationCount(): Promise<QueryInvoiceRelationCountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInvoiceRelationCountHeaders({ });
    return await this.queryInvoiceRelationCountWithOptions(headers, runtime);
  }

  async queryInvoiceRelationCountWithOptions(headers: QueryInvoiceRelationCountHeaders, runtime: $Util.RuntimeOptions): Promise<QueryInvoiceRelationCountResponse> {
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
    return $tea.cast<QueryInvoiceRelationCountResponse>(await this.doROARequest("QueryInvoiceRelationCount", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/invoices/relationReceipts/counts`, "json", req, runtime), new QueryInvoiceRelationCountResponse({}));
  }

  async queryPermissionByUserId(request: QueryPermissionByUserIdRequest): Promise<QueryPermissionByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPermissionByUserIdHeaders({ });
    return await this.queryPermissionByUserIdWithOptions(request, headers, runtime);
  }

  async queryPermissionByUserIdWithOptions(request: QueryPermissionByUserIdRequest, headers: QueryPermissionByUserIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPermissionByUserIdResponse> {
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
    return $tea.cast<QueryPermissionByUserIdResponse>(await this.doROARequest("QueryPermissionByUserId", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/permissions`, "json", req, runtime), new QueryPermissionByUserIdResponse({}));
  }

  async queryPermissionRoleMember(request: QueryPermissionRoleMemberRequest): Promise<QueryPermissionRoleMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPermissionRoleMemberHeaders({ });
    return await this.queryPermissionRoleMemberWithOptions(request, headers, runtime);
  }

  async queryPermissionRoleMemberWithOptions(request: QueryPermissionRoleMemberRequest, headers: QueryPermissionRoleMemberHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPermissionRoleMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.roleCodeList)) {
      body["roleCodeList"] = request.roleCodeList;
    }

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
    return $tea.cast<QueryPermissionRoleMemberResponse>(await this.doROARequest("QueryPermissionRoleMember", "bizfinance_1.0", "HTTP", "POST", "AK", `/v1.0/bizfinance/roles/members/query`, "json", req, runtime), new QueryPermissionRoleMemberResponse({}));
  }

  async queryProjectByPage(request: QueryProjectByPageRequest): Promise<QueryProjectByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProjectByPageHeaders({ });
    return await this.queryProjectByPageWithOptions(request, headers, runtime);
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
    return $tea.cast<QueryProjectByPageResponse>(await this.doROARequest("QueryProjectByPage", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/projects/list`, "json", req, runtime), new QueryProjectByPageResponse({}));
  }

  async queryReceiptForInvoice(request: QueryReceiptForInvoiceRequest): Promise<QueryReceiptForInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptForInvoiceHeaders({ });
    return await this.queryReceiptForInvoiceWithOptions(request, headers, runtime);
  }

  async queryReceiptForInvoiceWithOptions(request: QueryReceiptForInvoiceRequest, headers: QueryReceiptForInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReceiptForInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset($tea.toMap(request.invoiceFilter))) {
      body["invoiceFilter"] = request.invoiceFilter;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.receiptStatus)) {
      body["receiptStatus"] = request.receiptStatus;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<QueryReceiptForInvoiceResponse>(await this.doROARequest("QueryReceiptForInvoice", "bizfinance_1.0", "HTTP", "POST", "AK", `/v1.0/bizfinance/invoices/receipts/query`, "json", req, runtime), new QueryReceiptForInvoiceResponse({}));
  }

  async queryReceiptsByPage(request: QueryReceiptsByPageRequest): Promise<QueryReceiptsByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptsByPageHeaders({ });
    return await this.queryReceiptsByPageWithOptions(request, headers, runtime);
  }

  async queryReceiptsByPageWithOptions(request: QueryReceiptsByPageRequest, headers: QueryReceiptsByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReceiptsByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.modelId)) {
      query["modelId"] = request.modelId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.timeFilterField)) {
      query["timeFilterField"] = request.timeFilterField;
    }

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
    return $tea.cast<QueryReceiptsByPageResponse>(await this.doROARequest("QueryReceiptsByPage", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/receipts`, "json", req, runtime), new QueryReceiptsByPageResponse({}));
  }

  async querySupplierByPage(request: QuerySupplierByPageRequest): Promise<QuerySupplierByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySupplierByPageHeaders({ });
    return await this.querySupplierByPageWithOptions(request, headers, runtime);
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
    return $tea.cast<QuerySupplierByPageResponse>(await this.doROARequest("QuerySupplierByPage", "bizfinance_1.0", "HTTP", "GET", "AK", `/v1.0/bizfinance/suppliers`, "json", req, runtime), new QuerySupplierByPageResponse({}));
  }

  async updateInvoiceAbandonStatus(request: UpdateInvoiceAbandonStatusRequest): Promise<UpdateInvoiceAbandonStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAbandonStatusHeaders({ });
    return await this.updateInvoiceAbandonStatusWithOptions(request, headers, runtime);
  }

  async updateInvoiceAbandonStatusWithOptions(request: UpdateInvoiceAbandonStatusRequest, headers: UpdateInvoiceAbandonStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceAbandonStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.blueGeneralInvoiceVO))) {
      body["blueGeneralInvoiceVO"] = request.blueGeneralInvoiceVO;
    }

    if (!Util.isUnset(request.invoiceCode)) {
      body["invoiceCode"] = request.invoiceCode;
    }

    if (!Util.isUnset(request.invoiceNo)) {
      body["invoiceNo"] = request.invoiceNo;
    }

    if (!Util.isUnset($tea.toMap(request.redGeneralInvoiceVO))) {
      body["redGeneralInvoiceVO"] = request.redGeneralInvoiceVO;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

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
    return $tea.cast<UpdateInvoiceAbandonStatusResponse>(await this.doROARequest("UpdateInvoiceAbandonStatus", "bizfinance_1.0", "HTTP", "PUT", "AK", `/v1.0/bizfinance/invoices/abandonStatus`, "json", req, runtime), new UpdateInvoiceAbandonStatusResponse({}));
  }

  async updateInvoiceAndReceiptRelated(request: UpdateInvoiceAndReceiptRelatedRequest): Promise<UpdateInvoiceAndReceiptRelatedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAndReceiptRelatedHeaders({ });
    return await this.updateInvoiceAndReceiptRelatedWithOptions(request, headers, runtime);
  }

  async updateInvoiceAndReceiptRelatedWithOptions(request: UpdateInvoiceAndReceiptRelatedRequest, headers: UpdateInvoiceAndReceiptRelatedHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceAndReceiptRelatedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.generalInvoiceVO))) {
      body["generalInvoiceVO"] = request.generalInvoiceVO;
    }

    if (!Util.isUnset(request.invoiceCode)) {
      body["invoiceCode"] = request.invoiceCode;
    }

    if (!Util.isUnset(request.invoiceNo)) {
      body["invoiceNo"] = request.invoiceNo;
    }

    if (!Util.isUnset(request.receiptCode)) {
      body["receiptCode"] = request.receiptCode;
    }

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
    return $tea.cast<UpdateInvoiceAndReceiptRelatedResponse>(await this.doROARequest("UpdateInvoiceAndReceiptRelated", "bizfinance_1.0", "HTTP", "PUT", "AK", `/v1.0/bizfinance/invoices/approvalReceipts`, "json", req, runtime), new UpdateInvoiceAndReceiptRelatedResponse({}));
  }

  async updateInvoiceIgnoreStatus(request: UpdateInvoiceIgnoreStatusRequest): Promise<UpdateInvoiceIgnoreStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceIgnoreStatusHeaders({ });
    return await this.updateInvoiceIgnoreStatusWithOptions(request, headers, runtime);
  }

  async updateInvoiceIgnoreStatusWithOptions(request: UpdateInvoiceIgnoreStatusRequest, headers: UpdateInvoiceIgnoreStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceIgnoreStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.generalInvoiceVO))) {
      body["generalInvoiceVO"] = request.generalInvoiceVO;
    }

    if (!Util.isUnset(request.invoiceCode)) {
      body["invoiceCode"] = request.invoiceCode;
    }

    if (!Util.isUnset(request.invoiceNo)) {
      body["invoiceNo"] = request.invoiceNo;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

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
    return $tea.cast<UpdateInvoiceIgnoreStatusResponse>(await this.doROARequest("UpdateInvoiceIgnoreStatus", "bizfinance_1.0", "HTTP", "PUT", "AK", `/v1.0/bizfinance/invoices/ignoreStatus`, "json", req, runtime), new UpdateInvoiceIgnoreStatusResponse({}));
  }

  async updateInvoiceVerifyStatus(request: UpdateInvoiceVerifyStatusRequest): Promise<UpdateInvoiceVerifyStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceVerifyStatusHeaders({ });
    return await this.updateInvoiceVerifyStatusWithOptions(request, headers, runtime);
  }

  async updateInvoiceVerifyStatusWithOptions(request: UpdateInvoiceVerifyStatusRequest, headers: UpdateInvoiceVerifyStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceVerifyStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.invoiceKeyVOList)) {
      body["invoiceKeyVOList"] = request.invoiceKeyVOList;
    }

    if (!Util.isUnset(request.verifyStatus)) {
      body["verifyStatus"] = request.verifyStatus;
    }

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
    return $tea.cast<UpdateInvoiceVerifyStatusResponse>(await this.doROARequest("UpdateInvoiceVerifyStatus", "bizfinance_1.0", "HTTP", "PUT", "AK", `/v1.0/bizfinance/invoices/verifyStatus`, "json", req, runtime), new UpdateInvoiceVerifyStatusResponse({}));
  }

  async updateReceipt(request: UpdateReceiptRequest): Promise<UpdateReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateReceiptHeaders({ });
    return await this.updateReceiptWithOptions(request, headers, runtime);
  }

  async updateReceiptWithOptions(request: UpdateReceiptRequest, headers: UpdateReceiptHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateReceiptResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.receipts)) {
      body["receipts"] = request.receipts;
    }

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
    return $tea.cast<UpdateReceiptResponse>(await this.doROARequest("UpdateReceipt", "bizfinance_1.0", "HTTP", "PUT", "AK", `/v1.0/bizfinance/receipts`, "json", req, runtime), new UpdateReceiptResponse({}));
  }

}
