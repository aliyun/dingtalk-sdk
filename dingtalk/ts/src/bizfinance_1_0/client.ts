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

export class AppendRolePermissionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendRolePermissionRequest extends $tea.Model {
  rolePermissionItemList?: AppendRolePermissionRequestRolePermissionItemList[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      rolePermissionItemList: 'rolePermissionItemList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rolePermissionItemList: { 'type': 'array', 'itemType': AppendRolePermissionRequestRolePermissionItemList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendRolePermissionShrinkRequest extends $tea.Model {
  rolePermissionItemListShrink?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      rolePermissionItemListShrink: 'rolePermissionItemList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      rolePermissionItemListShrink: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AppendRolePermissionResponseBody extends $tea.Model {
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

export class AppendRolePermissionResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AppendRolePermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: AppendRolePermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  companyCode?: string;
  generalInvoiceVOList?: BatchAddInvoiceRequestGeneralInvoiceVOList[];
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      generalInvoiceVOList: 'generalInvoiceVOList',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      generalInvoiceVOList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOList },
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceResponseBody extends $tea.Model {
  errorResult?: BatchAddInvoiceResponseBodyErrorResult[];
  successResult?: BatchAddInvoiceResponseBodySuccessResult[];
  static names(): { [key: string]: string } {
    return {
      errorResult: 'errorResult',
      successResult: 'successResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorResult: { 'type': 'array', 'itemType': BatchAddInvoiceResponseBodyErrorResult },
      successResult: { 'type': 'array', 'itemType': BatchAddInvoiceResponseBodySuccessResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchAddInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchAddInvoiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateCustomerHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateCustomerRequest extends $tea.Model {
  createCustomerRequestList?: BatchCreateCustomerRequestCreateCustomerRequestList[];
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      createCustomerRequestList: 'createCustomerRequestList',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createCustomerRequestList: { 'type': 'array', 'itemType': BatchCreateCustomerRequestCreateCustomerRequestList },
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateCustomerResponseBody extends $tea.Model {
  errorResult?: BatchCreateCustomerResponseBodyErrorResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorResult: 'errorResult',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorResult: { 'type': 'array', 'itemType': BatchCreateCustomerResponseBodyErrorResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchCreateCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BatchCreateCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BatchCreateCustomerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindCompanyAccountantBookHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindCompanyAccountantBookRequest extends $tea.Model {
  accountantBookId?: string;
  companyCode?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      companyCode: 'companyCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookId: 'string',
      companyCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BindCompanyAccountantBookResponseBody extends $tea.Model {
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

export class BindCompanyAccountantBookResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: BindCompanyAccountantBookResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BindCompanyAccountantBookResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckVoucherStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckVoucherStatusRequest extends $tea.Model {
  companyCode?: string;
  endTime?: number;
  financeType?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  taxNo?: string;
  verifyStatus?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      endTime: 'endTime',
      financeType: 'financeType',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
      taxNo: 'taxNo',
      verifyStatus: 'verifyStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      endTime: 'number',
      financeType: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
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

export class CheckVoucherStatusResponseBody extends $tea.Model {
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

export class CheckVoucherStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CheckVoucherStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CheckVoucherStatusResponseBody,
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
  drawerEmail?: string;
  drawerTelephone?: string;
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
      drawerEmail: 'drawerEmail',
      drawerTelephone: 'drawerTelephone',
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
      drawerEmail: 'string',
      drawerTelephone: 'string',
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
  statusCode: number;
  body: CreateCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  body: CreateReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  body: DeleteReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  body: GetBookkeepingUserListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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

export class GetCustomerResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  request?: GetInvoiceByPageRequestRequest;
  static names(): { [key: string]: string } {
    return {
      request: 'request',
    };
  }

  static types(): { [key: string]: any } {
    return {
      request: GetInvoiceByPageRequestRequest,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageShrinkRequest extends $tea.Model {
  requestShrink?: string;
  static names(): { [key: string]: string } {
    return {
      requestShrink: 'request',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestShrink: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBody extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  result?: GetInvoiceByPageResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      result: GetInvoiceByPageResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetInvoiceByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  body: GetIsNewVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetIsNewVersionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultiCompanyInfoByCodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultiCompanyInfoByCodeResponseBody extends $tea.Model {
  advancedSettingList?: GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList[];
  companyCode?: string;
  companyName?: string;
  remark?: string;
  status?: string;
  taxNature?: string;
  taxNo?: string;
  static names(): { [key: string]: string } {
    return {
      advancedSettingList: 'advancedSettingList',
      companyCode: 'companyCode',
      companyName: 'companyName',
      remark: 'remark',
      status: 'status',
      taxNature: 'taxNature',
      taxNo: 'taxNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedSettingList: { 'type': 'array', 'itemType': GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList },
      companyCode: 'string',
      companyName: 'string',
      remark: 'string',
      status: 'string',
      taxNature: 'string',
      taxNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultiCompanyInfoByCodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetMultiCompanyInfoByCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetMultiCompanyInfoByCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProductHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProductRequest extends $tea.Model {
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

export class GetProductResponseBody extends $tea.Model {
  accountantBookIdList?: string[];
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
  specification?: string;
  status?: string;
  unit?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookIdList: 'accountantBookIdList',
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      specification: 'specification',
      status: 'status',
      unit: 'unit',
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
      specification: 'string',
      status: 'string',
      unit: 'string',
      userDefineCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProductResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetProductResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetProductResponseBody,
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
  statusCode: number;
  body: GetReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class GetYongYouOpenApiTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetYongYouOpenApiTokenRequest extends $tea.Model {
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

export class GetYongYouOpenApiTokenResponseBody extends $tea.Model {
  accessToken?: string;
  appName?: string;
  expiresIn?: string;
  refreshExpiresIn?: string;
  refreshToken?: string;
  scope?: string;
  sid?: string;
  yongyouOrgId?: string;
  yongyouUserId?: string;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'accessToken',
      appName: 'appName',
      expiresIn: 'expiresIn',
      refreshExpiresIn: 'refreshExpiresIn',
      refreshToken: 'refreshToken',
      scope: 'scope',
      sid: 'sid',
      yongyouOrgId: 'yongyouOrgId',
      yongyouUserId: 'yongyouUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      appName: 'string',
      expiresIn: 'string',
      refreshExpiresIn: 'string',
      refreshToken: 'string',
      scope: 'string',
      sid: 'string',
      yongyouOrgId: 'string',
      yongyouUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetYongYouOpenApiTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetYongYouOpenApiTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetYongYouOpenApiTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetYongYouOrgRelationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetYongYouOrgRelationResponseBody extends $tea.Model {
  chanjetCorpId?: string;
  chanjetUserId?: string;
  corpId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      chanjetCorpId: 'chanjetCorpId',
      chanjetUserId: 'chanjetUserId',
      corpId: 'corpId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chanjetCorpId: 'string',
      chanjetUserId: 'string',
      corpId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetYongYouOrgRelationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetYongYouOrgRelationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetYongYouOrgRelationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProfessionBenefitConsumeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProfessionBenefitConsumeRequest extends $tea.Model {
  benefitCode?: string;
  bizRequestId?: string;
  quota?: number;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
      bizRequestId: 'bizRequestId',
      quota: 'quota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
      bizRequestId: 'string',
      quota: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProfessionBenefitConsumeResponseBody extends $tea.Model {
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

export class ProfessionBenefitConsumeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ProfessionBenefitConsumeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ProfessionBenefitConsumeResponseBody,
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

export class QueryCompanyInvoiceRelationCountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyInvoiceRelationCountRequest extends $tea.Model {
  companyCode?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCompanyInvoiceRelationCountResponseBody extends $tea.Model {
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

export class QueryCompanyInvoiceRelationCountResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCompanyInvoiceRelationCountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryCompanyInvoiceRelationCountResponseBody,
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
  keyword?: string;
  pageNumber?: number;
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
  statusCode: number;
  body: QueryCustomerInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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

export class QueryFinanceCompanyInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFinanceCompanyInfoResponseBody extends $tea.Model {
  companyName?: string;
  taxNature?: string;
  taxNo?: string;
  static names(): { [key: string]: string } {
    return {
      companyName: 'companyName',
      taxNature: 'taxNature',
      taxNo: 'taxNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyName: 'string',
      taxNature: 'string',
      taxNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFinanceCompanyInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryFinanceCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryFinanceCompanyInfoResponseBody,
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
  statusCode: number;
  body: QueryInvoiceRelationCountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryInvoiceRelationCountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMultiCompanyInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMultiCompanyInfoResponseBody extends $tea.Model {
  list?: QueryMultiCompanyInfoResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': QueryMultiCompanyInfoResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMultiCompanyInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryMultiCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryMultiCompanyInfoResponseBody,
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
  statusCode: number;
  body: QueryPermissionByUserIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  statusCode: number;
  body: QueryPermissionRoleMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryPermissionRoleMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProductByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProductByPageRequest extends $tea.Model {
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

export class QueryProductByPageResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryProductByPageResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryProductByPageResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryProductByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryProductByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryProductByPageResponseBody,
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

export class QueryReceiptDetailForInvoiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptDetailForInvoiceRequest extends $tea.Model {
  instanceId?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptDetailForInvoiceResponseBody extends $tea.Model {
  result?: QueryReceiptDetailForInvoiceResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryReceiptDetailForInvoiceResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptDetailForInvoiceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryReceiptDetailForInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryReceiptDetailForInvoiceResponseBody,
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
  accountantBookId?: string;
  applyStatusList?: string[];
  bizStatusList?: string[];
  companyCode?: string;
  endTime?: number;
  pageNumber?: number;
  pageSize?: number;
  receiptStatusList?: string[];
  searchParams?: { [key: string]: string };
  startTime?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      applyStatusList: 'applyStatusList',
      bizStatusList: 'bizStatusList',
      companyCode: 'companyCode',
      endTime: 'endTime',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      receiptStatusList: 'receiptStatusList',
      searchParams: 'searchParams',
      startTime: 'startTime',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookId: 'string',
      applyStatusList: { 'type': 'array', 'itemType': 'string' },
      bizStatusList: { 'type': 'array', 'itemType': 'string' },
      companyCode: 'string',
      endTime: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      receiptStatusList: { 'type': 'array', 'itemType': 'string' },
      searchParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  statusCode: number;
  body: QueryReceiptForInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryReceiptForInvoiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoRequest extends $tea.Model {
  accountantBookId?: string;
  companyCode?: string;
  endTime?: number;
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  timeFilterField?: string;
  title?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      companyCode: 'companyCode',
      endTime: 'endTime',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      startTime: 'startTime',
      timeFilterField: 'timeFilterField',
      title: 'title',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookId: 'string',
      companyCode: 'string',
      endTime: 'number',
      pageNumber: 'number',
      pageSize: 'number',
      startTime: 'number',
      timeFilterField: 'string',
      title: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponseBody extends $tea.Model {
  hasMore?: string;
  list?: QueryReceiptsBaseInfoResponseBodyList[];
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
      list: { 'type': 'array', 'itemType': QueryReceiptsBaseInfoResponseBodyList },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryReceiptsBaseInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryReceiptsBaseInfoResponseBody,
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
  statusCode: number;
  body: QueryReceiptsByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryReceiptsByPageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRoleMemberByPageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRoleMemberByPageRequest extends $tea.Model {
  maxResults?: string;
  nextToken?: string;
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'string',
      nextToken: 'string',
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRoleMemberByPageResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryRoleMemberByPageResponseBodyList[];
  nextToken?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryRoleMemberByPageResponseBodyList },
      nextToken: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRoleMemberByPageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryRoleMemberByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryRoleMemberByPageResponseBody,
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

export class QueryUserRoleListResponseBody extends $tea.Model {
  roleVOList?: QueryUserRoleListResponseBodyRoleVOList[];
  static names(): { [key: string]: string } {
    return {
      roleVOList: 'roleVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleVOList: { 'type': 'array', 'itemType': QueryUserRoleListResponseBodyRoleVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserRoleListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryUserRoleListResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class UnbindApplyReceiptAndInvoiceRelatedHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnbindApplyReceiptAndInvoiceRelatedRequest extends $tea.Model {
  instanceId?: string;
  invoiceKeyVOList?: UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList[];
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      invoiceKeyVOList: 'invoiceKeyVOList',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      invoiceKeyVOList: { 'type': 'array', 'itemType': UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList },
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnbindApplyReceiptAndInvoiceRelatedResponseBody extends $tea.Model {
  batchUpdateInvoiceResponse?: UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse;
  errorInvoiceKeyVOList?: UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      batchUpdateInvoiceResponse: 'batchUpdateInvoiceResponse',
      errorInvoiceKeyVOList: 'errorInvoiceKeyVOList',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      batchUpdateInvoiceResponse: UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse,
      errorInvoiceKeyVOList: { 'type': 'array', 'itemType': UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnbindApplyReceiptAndInvoiceRelatedResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UnbindApplyReceiptAndInvoiceRelatedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UnbindApplyReceiptAndInvoiceRelatedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplyReceiptAndInvoiceRelatedHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplyReceiptAndInvoiceRelatedRequest extends $tea.Model {
  generalInvoiceVOList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList[];
  instanceId?: string;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      generalInvoiceVOList: 'generalInvoiceVOList',
      instanceId: 'instanceId',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      generalInvoiceVOList: { 'type': 'array', 'itemType': UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList },
      instanceId: 'string',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplyReceiptAndInvoiceRelatedResponseBody extends $tea.Model {
  batchUpdateInvoiceResponse?: UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse;
  errorInvoiceKeyVOList?: UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      batchUpdateInvoiceResponse: 'batchUpdateInvoiceResponse',
      errorInvoiceKeyVOList: 'errorInvoiceKeyVOList',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      batchUpdateInvoiceResponse: UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse,
      errorInvoiceKeyVOList: { 'type': 'array', 'itemType': UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplyReceiptAndInvoiceRelatedResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateApplyReceiptAndInvoiceRelatedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateApplyReceiptAndInvoiceRelatedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDigitalInvoiceOrgInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDigitalInvoiceOrgInfoRequest extends $tea.Model {
  digitalInvoiceType?: string[];
  isDigitalOrg?: boolean;
  location?: string;
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      digitalInvoiceType: 'digitalInvoiceType',
      isDigitalOrg: 'isDigitalOrg',
      location: 'location',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      digitalInvoiceType: { 'type': 'array', 'itemType': 'string' },
      isDigitalOrg: 'boolean',
      location: 'string',
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateDigitalInvoiceOrgInfoResponseBody extends $tea.Model {
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

export class UpdateDigitalInvoiceOrgInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateDigitalInvoiceOrgInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateDigitalInvoiceOrgInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFinanceCompanyInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFinanceCompanyInfoRequest extends $tea.Model {
  companyName?: string;
  taxNature?: string;
  taxNo?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      companyName: 'companyName',
      taxNature: 'taxNature',
      taxNo: 'taxNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyName: 'string',
      taxNature: 'string',
      taxNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFinanceCompanyInfoResponseBody extends $tea.Model {
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

export class UpdateFinanceCompanyInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateFinanceCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateFinanceCompanyInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFinanceMultiCompanyInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFinanceMultiCompanyInfoRequest extends $tea.Model {
  companyCode?: string;
  companyName?: string;
  taxNature?: string;
  taxNo?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      companyName: 'companyName',
      taxNature: 'taxNature',
      taxNo: 'taxNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      companyName: 'string',
      taxNature: 'string',
      taxNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateFinanceMultiCompanyInfoResponseBody extends $tea.Model {
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

export class UpdateFinanceMultiCompanyInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateFinanceMultiCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateFinanceMultiCompanyInfoResponseBody,
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
  blueInvoiceCode?: string;
  blueInvoiceNo?: string;
  blueInvoiceStatus?: string;
  companyCode?: string;
  operator?: string;
  redGeneralInvoiceVO?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO;
  redInvoiceCode?: string;
  redInvoiceNo?: string;
  redInvoiceStatus?: string;
  targetInvoice?: string;
  static names(): { [key: string]: string } {
    return {
      blueGeneralInvoiceVO: 'blueGeneralInvoiceVO',
      blueInvoiceCode: 'blueInvoiceCode',
      blueInvoiceNo: 'blueInvoiceNo',
      blueInvoiceStatus: 'blueInvoiceStatus',
      companyCode: 'companyCode',
      operator: 'operator',
      redGeneralInvoiceVO: 'redGeneralInvoiceVO',
      redInvoiceCode: 'redInvoiceCode',
      redInvoiceNo: 'redInvoiceNo',
      redInvoiceStatus: 'redInvoiceStatus',
      targetInvoice: 'targetInvoice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      blueGeneralInvoiceVO: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO,
      blueInvoiceCode: 'string',
      blueInvoiceNo: 'string',
      blueInvoiceStatus: 'string',
      companyCode: 'string',
      operator: 'string',
      redGeneralInvoiceVO: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO,
      redInvoiceCode: 'string',
      redInvoiceNo: 'string',
      redInvoiceStatus: 'string',
      targetInvoice: 'string',
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
  statusCode: number;
  body: UpdateInvoiceAbandonStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateInvoiceAbandonStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountPeriodHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountPeriodRequest extends $tea.Model {
  accountPeriod?: string;
  companyCode?: string;
  generalInvoiceVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList[];
  invoiceKeyVOList?: UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList[];
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      companyCode: 'companyCode',
      generalInvoiceVOList: 'generalInvoiceVOList',
      invoiceKeyVOList: 'invoiceKeyVOList',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      companyCode: 'string',
      generalInvoiceVOList: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList },
      invoiceKeyVOList: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList },
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountPeriodResponseBody extends $tea.Model {
  errorResult?: UpdateInvoiceAccountPeriodResponseBodyErrorResult[];
  successResult?: UpdateInvoiceAccountPeriodResponseBodySuccessResult[];
  static names(): { [key: string]: string } {
    return {
      errorResult: 'errorResult',
      successResult: 'successResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorResult: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodResponseBodyErrorResult },
      successResult: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodResponseBodySuccessResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountPeriodResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateInvoiceAccountPeriodResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateInvoiceAccountPeriodResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingPeriodDateHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingPeriodDateRequest extends $tea.Model {
  companyCode?: string;
  invoiceFinanceInfoVOList?: UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList[];
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      invoiceFinanceInfoVOList: 'invoiceFinanceInfoVOList',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      invoiceFinanceInfoVOList: { 'type': 'array', 'itemType': UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList },
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingPeriodDateResponseBody extends $tea.Model {
  result?: UpdateInvoiceAccountingPeriodDateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateInvoiceAccountingPeriodDateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingPeriodDateResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateInvoiceAccountingPeriodDateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateInvoiceAccountingPeriodDateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingStatusRequest extends $tea.Model {
  companyCode?: string;
  invoiceFinanceInfoVOList?: UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList[];
  operator?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      invoiceFinanceInfoVOList: 'invoiceFinanceInfoVOList',
      operator: 'operator',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      invoiceFinanceInfoVOList: { 'type': 'array', 'itemType': UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList },
      operator: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingStatusResponseBody extends $tea.Model {
  result?: UpdateInvoiceAccountingStatusResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateInvoiceAccountingStatusResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateInvoiceAccountingStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateInvoiceAccountingStatusResponseBody,
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
  operator?: string;
  receiptCode?: string;
  static names(): { [key: string]: string } {
    return {
      generalInvoiceVO: 'generalInvoiceVO',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      operator: 'operator',
      receiptCode: 'receiptCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      generalInvoiceVO: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO,
      invoiceCode: 'string',
      invoiceNo: 'string',
      operator: 'string',
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
  statusCode: number;
  body: UpdateInvoiceAndReceiptRelatedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  instanceId?: string;
  operator?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      operator: 'operator',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      operator: 'string',
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
  statusCode: number;
  body: UpdateInvoiceIgnoreStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
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
  companyCode?: string;
  deductStatus?: string;
  generalInvoiceVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList[];
  invoiceKeyVOList?: UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList[];
  operator?: string;
  verifyStatus?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      deductStatus: 'deductStatus',
      generalInvoiceVOList: 'generalInvoiceVOList',
      invoiceKeyVOList: 'invoiceKeyVOList',
      operator: 'operator',
      verifyStatus: 'verifyStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      deductStatus: 'string',
      generalInvoiceVOList: { 'type': 'array', 'itemType': UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList },
      invoiceKeyVOList: { 'type': 'array', 'itemType': UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList },
      operator: 'string',
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
  statusCode: number;
  body: UpdateInvoiceVerifyStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateInvoiceVerifyStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVoucherStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVoucherStatusRequest extends $tea.Model {
  accountantBookId?: string;
  actionType?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  operator?: string;
  voucherId?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      actionType: 'actionType',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      operator: 'operator',
      voucherId: 'voucherId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookId: 'string',
      actionType: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      operator: 'string',
      voucherId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVoucherStatusResponseBody extends $tea.Model {
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

export class UpdateInvoiceVoucherStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateInvoiceVoucherStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateInvoiceVoucherStatusResponseBody,
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
  statusCode: number;
  body: UpdateReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateReceiptResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptVoucherStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptVoucherStatusRequest extends $tea.Model {
  accountPeriod?: string;
  actionType?: string;
  operatorId?: string;
  receiptId?: string;
  voucherCode?: string;
  voucherId?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      actionType: 'actionType',
      operatorId: 'operatorId',
      receiptId: 'receiptId',
      voucherCode: 'voucherCode',
      voucherId: 'voucherId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      actionType: 'string',
      operatorId: 'string',
      receiptId: 'string',
      voucherCode: 'string',
      voucherId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateReceiptVoucherStatusResponseBody extends $tea.Model {
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

export class UpdateReceiptVoucherStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateReceiptVoucherStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpdateReceiptVoucherStatusResponseBody,
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

export class AppendRolePermissionRequestRolePermissionItemListPermissionList extends $tea.Model {
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

export class AppendRolePermissionRequestRolePermissionItemList extends $tea.Model {
  permissionList?: AppendRolePermissionRequestRolePermissionItemListPermissionList[];
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      permissionList: 'permissionList',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      permissionList: { 'type': 'array', 'itemType': AppendRolePermissionRequestRolePermissionItemListPermissionList },
      roleCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodsName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxPreType?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodsName: 'goodsName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxPreType: 'taxPreType',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodsName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxPreType: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList extends $tea.Model {
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

export class BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList extends $tea.Model {
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
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  reviewer?: string;
  secondHandCarInvoiceDetailList?: BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  sellerBankAccount?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
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
      drawerName: 'drawerName',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      imageUrl: 'imageUrl',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      reviewer: 'reviewer',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
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
      drawerName: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList },
      imageUrl: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      reviewer: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList },
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchAddInvoiceResponseBodyErrorResult extends $tea.Model {
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

export class BatchAddInvoiceResponseBodySuccessResult extends $tea.Model {
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

export class BatchCreateCustomerRequestCreateCustomerRequestList extends $tea.Model {
  description?: string;
  drawerEmail?: string;
  drawerTelephone?: string;
  name?: string;
  purchaserAccount?: string;
  purchaserAddress?: string;
  purchaserBankName?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      drawerEmail: 'drawerEmail',
      drawerTelephone: 'drawerTelephone',
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
      description: 'string',
      drawerEmail: 'string',
      drawerTelephone: 'string',
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

export class BatchCreateCustomerResponseBodyErrorResult extends $tea.Model {
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

export class GetInvoiceByPageRequestRequest extends $tea.Model {
  accountantBookId?: string;
  companyCode?: string;
  endTime?: number;
  financeType?: string;
  pageNumber?: number;
  pageSize?: number;
  startTime?: number;
  taxNo?: string;
  verifyStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      companyCode: 'companyCode',
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
      accountantBookId: 'string',
      companyCode: 'string',
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

export class GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodsName?: string;
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
      goodsName: 'goodsName',
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
      goodsName: 'string',
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

export class GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList extends $tea.Model {
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

export class GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList extends $tea.Model {
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

export class GetInvoiceByPageResponseBodyResultList extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList[];
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
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
  sellerAddress?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  status?: string;
  supplySign?: string;
  taxAmount?: string;
  transportFeeDetailVOList?: GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList[];
  usedVehicleSaleDetailVOList?: GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList[];
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
      invoiceStatus: 'invoiceStatus',
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
      sellerAddress: 'sellerAddress',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      status: 'status',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      transportFeeDetailVOList: 'transportFeeDetailVOList',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
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
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyResultListGeneralInvoiceDetailVOList },
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
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
      sellerAddress: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      status: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      transportFeeDetailVOList: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyResultListTransportFeeDetailVOList },
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyResultListUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyResultListVehicleSaleDetailVOList },
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageResponseBodyResult extends $tea.Model {
  hasMore?: string;
  list?: GetInvoiceByPageResponseBodyResultList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'string',
      list: { 'type': 'array', 'itemType': GetInvoiceByPageResponseBodyResultList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMultiCompanyInfoByCodeResponseBodyAdvancedSettingList extends $tea.Model {
  advancedSettingKey?: string;
  advancedSettingName?: string;
  endDate?: number;
  value?: boolean;
  static names(): { [key: string]: string } {
    return {
      advancedSettingKey: 'advancedSettingKey',
      advancedSettingName: 'advancedSettingName',
      endDate: 'endDate',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedSettingKey: 'string',
      advancedSettingName: 'string',
      endDate: 'number',
      value: 'boolean',
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

export class QueryCustomerInfoResponseBodyList extends $tea.Model {
  code?: string;
  contactAddress?: string;
  contactCompanyTelephone?: string;
  contactEmail?: string;
  contactName?: string;
  contactTelephone?: string;
  description?: string;
  drawerEmail?: string;
  drawerTelephone?: string;
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
      contactAddress: 'contactAddress',
      contactCompanyTelephone: 'contactCompanyTelephone',
      contactEmail: 'contactEmail',
      contactName: 'contactName',
      contactTelephone: 'contactTelephone',
      description: 'description',
      drawerEmail: 'drawerEmail',
      drawerTelephone: 'drawerTelephone',
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
      contactAddress: 'string',
      contactCompanyTelephone: 'string',
      contactEmail: 'string',
      contactName: 'string',
      contactTelephone: 'string',
      description: 'string',
      drawerEmail: 'string',
      drawerTelephone: 'string',
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

export class QueryMultiCompanyInfoResponseBodyListAdvancedSettingList extends $tea.Model {
  advancedSettingKey?: string;
  advancedSettingName?: string;
  endDate?: number;
  value?: boolean;
  static names(): { [key: string]: string } {
    return {
      advancedSettingKey: 'advancedSettingKey',
      advancedSettingName: 'advancedSettingName',
      endDate: 'endDate',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedSettingKey: 'string',
      advancedSettingName: 'string',
      endDate: 'number',
      value: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMultiCompanyInfoResponseBodyList extends $tea.Model {
  advancedSettingList?: QueryMultiCompanyInfoResponseBodyListAdvancedSettingList[];
  companyCode?: string;
  companyName?: string;
  createTime?: string;
  remark?: string;
  status?: string;
  taxNature?: string;
  taxNo?: string;
  static names(): { [key: string]: string } {
    return {
      advancedSettingList: 'advancedSettingList',
      companyCode: 'companyCode',
      companyName: 'companyName',
      createTime: 'createTime',
      remark: 'remark',
      status: 'status',
      taxNature: 'taxNature',
      taxNo: 'taxNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedSettingList: { 'type': 'array', 'itemType': QueryMultiCompanyInfoResponseBodyListAdvancedSettingList },
      companyCode: 'string',
      companyName: 'string',
      createTime: 'string',
      remark: 'string',
      status: 'string',
      taxNature: 'string',
      taxNo: 'string',
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

export class QueryProductByPageResponseBodyList extends $tea.Model {
  code?: string;
  createTime?: number;
  description?: string;
  name?: string;
  specification?: string;
  status?: string;
  unit?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      name: 'name',
      specification: 'specification',
      status: 'status',
      unit: 'unit',
      userDefineCode: 'userDefineCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      createTime: 'number',
      description: 'string',
      name: 'string',
      specification: 'string',
      status: 'string',
      unit: 'string',
      userDefineCode: 'string',
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

export class QueryReceiptDetailForInvoiceResponseBodyResultCreator extends $tea.Model {
  avatarUrl?: string;
  nick?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      nick: 'nick',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      nick: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptDetailForInvoiceResponseBodyResultCustomer extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList extends $tea.Model {
  amountWithTax?: string;
  amountWithoutTax?: string;
  discountAmount?: string;
  name?: string;
  quantity?: string;
  specification?: string;
  taxRate?: string;
  unit?: string;
  unitPriceWithTax?: string;
  unitPriceWithoutTax?: string;
  withTax?: boolean;
  static names(): { [key: string]: string } {
    return {
      amountWithTax: 'amountWithTax',
      amountWithoutTax: 'amountWithoutTax',
      discountAmount: 'discountAmount',
      name: 'name',
      quantity: 'quantity',
      specification: 'specification',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPriceWithTax: 'unitPriceWithTax',
      unitPriceWithoutTax: 'unitPriceWithoutTax',
      withTax: 'withTax',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amountWithTax: 'string',
      amountWithoutTax: 'string',
      discountAmount: 'string',
      name: 'string',
      quantity: 'string',
      specification: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPriceWithTax: 'string',
      unitPriceWithoutTax: 'string',
      withTax: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptDetailForInvoiceResponseBodyResult extends $tea.Model {
  accountantBookId?: string;
  amount?: string;
  applyStatus?: string;
  bizStatus?: string;
  businessId?: string;
  companyCode?: string;
  createTime?: string;
  creator?: QueryReceiptDetailForInvoiceResponseBodyResultCreator;
  customer?: QueryReceiptDetailForInvoiceResponseBodyResultCustomer;
  drawerEmail?: string;
  drawerTelephone?: string;
  invoiceType?: string;
  modelId?: string;
  productInfoList?: QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList[];
  purchaserAccount?: string;
  purchaserAddress?: string;
  purchaserBankName?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  receiptId?: string;
  recordTime?: string;
  remark?: string;
  source?: string;
  status?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      amount: 'amount',
      applyStatus: 'applyStatus',
      bizStatus: 'bizStatus',
      businessId: 'businessId',
      companyCode: 'companyCode',
      createTime: 'createTime',
      creator: 'creator',
      customer: 'customer',
      drawerEmail: 'drawerEmail',
      drawerTelephone: 'drawerTelephone',
      invoiceType: 'invoiceType',
      modelId: 'modelId',
      productInfoList: 'productInfoList',
      purchaserAccount: 'purchaserAccount',
      purchaserAddress: 'purchaserAddress',
      purchaserBankName: 'purchaserBankName',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      receiptId: 'receiptId',
      recordTime: 'recordTime',
      remark: 'remark',
      source: 'source',
      status: 'status',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookId: 'string',
      amount: 'string',
      applyStatus: 'string',
      bizStatus: 'string',
      businessId: 'string',
      companyCode: 'string',
      createTime: 'string',
      creator: QueryReceiptDetailForInvoiceResponseBodyResultCreator,
      customer: QueryReceiptDetailForInvoiceResponseBodyResultCustomer,
      drawerEmail: 'string',
      drawerTelephone: 'string',
      invoiceType: 'string',
      modelId: 'string',
      productInfoList: { 'type': 'array', 'itemType': QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList },
      purchaserAccount: 'string',
      purchaserAddress: 'string',
      purchaserBankName: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      receiptId: 'string',
      recordTime: 'string',
      remark: 'string',
      source: 'string',
      status: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceResponseBodyListCreator extends $tea.Model {
  avatarUrl?: string;
  nick?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      nick: 'nick',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      nick: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceResponseBodyListCustomer extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceResponseBodyListProductInfoList extends $tea.Model {
  amountWithTax?: string;
  amountWithoutTax?: string;
  discountAmount?: string;
  name?: string;
  quantity?: string;
  specification?: string;
  taxRate?: string;
  unit?: string;
  unitPriceWithTax?: string;
  unitPriceWithoutTax?: string;
  withTax?: boolean;
  static names(): { [key: string]: string } {
    return {
      amountWithTax: 'amountWithTax',
      amountWithoutTax: 'amountWithoutTax',
      discountAmount: 'discountAmount',
      name: 'name',
      quantity: 'quantity',
      specification: 'specification',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPriceWithTax: 'unitPriceWithTax',
      unitPriceWithoutTax: 'unitPriceWithoutTax',
      withTax: 'withTax',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amountWithTax: 'string',
      amountWithoutTax: 'string',
      discountAmount: 'string',
      name: 'string',
      quantity: 'string',
      specification: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPriceWithTax: 'string',
      unitPriceWithoutTax: 'string',
      withTax: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptForInvoiceResponseBodyList extends $tea.Model {
  accountantBookId?: string;
  amount?: string;
  applyStatus?: string;
  bizStatus?: string;
  businessId?: string;
  companyCode?: string;
  createTime?: string;
  creator?: QueryReceiptForInvoiceResponseBodyListCreator;
  customer?: QueryReceiptForInvoiceResponseBodyListCustomer;
  drawerEmail?: string;
  drawerTelephone?: string;
  invoiceType?: string;
  modelId?: string;
  productInfoList?: QueryReceiptForInvoiceResponseBodyListProductInfoList[];
  purchaserAccount?: string;
  purchaserAddress?: string;
  purchaserBankName?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  receiptId?: string;
  recordTime?: string;
  remark?: string;
  source?: string;
  status?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      amount: 'amount',
      applyStatus: 'applyStatus',
      bizStatus: 'bizStatus',
      businessId: 'businessId',
      companyCode: 'companyCode',
      createTime: 'createTime',
      creator: 'creator',
      customer: 'customer',
      drawerEmail: 'drawerEmail',
      drawerTelephone: 'drawerTelephone',
      invoiceType: 'invoiceType',
      modelId: 'modelId',
      productInfoList: 'productInfoList',
      purchaserAccount: 'purchaserAccount',
      purchaserAddress: 'purchaserAddress',
      purchaserBankName: 'purchaserBankName',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      receiptId: 'receiptId',
      recordTime: 'recordTime',
      remark: 'remark',
      source: 'source',
      status: 'status',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookId: 'string',
      amount: 'string',
      applyStatus: 'string',
      bizStatus: 'string',
      businessId: 'string',
      companyCode: 'string',
      createTime: 'string',
      creator: QueryReceiptForInvoiceResponseBodyListCreator,
      customer: QueryReceiptForInvoiceResponseBodyListCustomer,
      drawerEmail: 'string',
      drawerTelephone: 'string',
      invoiceType: 'string',
      modelId: 'string',
      productInfoList: { 'type': 'array', 'itemType': QueryReceiptForInvoiceResponseBodyListProductInfoList },
      purchaserAccount: 'string',
      purchaserAddress: 'string',
      purchaserBankName: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      receiptId: 'string',
      recordTime: 'string',
      remark: 'string',
      source: 'string',
      status: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponseBodyListCreator extends $tea.Model {
  avatarUrl?: string;
  nick?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      nick: 'nick',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      nick: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponseBodyListCustomer extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponseBodyListPrincipal extends $tea.Model {
  avatarUrl?: string;
  nick?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      nick: 'nick',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      nick: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponseBodyListProject extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponseBodyListSupplier extends $tea.Model {
  code?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryReceiptsBaseInfoResponseBodyList extends $tea.Model {
  accountantBookId?: string;
  amount?: string;
  businessId?: string;
  companyCode?: string;
  createTime?: string;
  creator?: QueryReceiptsBaseInfoResponseBodyListCreator;
  customer?: QueryReceiptsBaseInfoResponseBodyListCustomer;
  modelId?: string;
  principal?: QueryReceiptsBaseInfoResponseBodyListPrincipal;
  project?: QueryReceiptsBaseInfoResponseBodyListProject;
  receiptId?: string;
  recordTime?: string;
  remark?: string;
  source?: string;
  status?: string;
  supplier?: QueryReceiptsBaseInfoResponseBodyListSupplier;
  title?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      amount: 'amount',
      businessId: 'businessId',
      companyCode: 'companyCode',
      createTime: 'createTime',
      creator: 'creator',
      customer: 'customer',
      modelId: 'modelId',
      principal: 'principal',
      project: 'project',
      receiptId: 'receiptId',
      recordTime: 'recordTime',
      remark: 'remark',
      source: 'source',
      status: 'status',
      supplier: 'supplier',
      title: 'title',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountantBookId: 'string',
      amount: 'string',
      businessId: 'string',
      companyCode: 'string',
      createTime: 'string',
      creator: QueryReceiptsBaseInfoResponseBodyListCreator,
      customer: QueryReceiptsBaseInfoResponseBodyListCustomer,
      modelId: 'string',
      principal: QueryReceiptsBaseInfoResponseBodyListPrincipal,
      project: QueryReceiptsBaseInfoResponseBodyListProject,
      receiptId: 'string',
      recordTime: 'string',
      remark: 'string',
      source: 'string',
      status: 'string',
      supplier: QueryReceiptsBaseInfoResponseBodyListSupplier,
      title: 'string',
      voucherStatus: 'string',
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

export class QueryRoleMemberByPageResponseBodyList extends $tea.Model {
  avatarUrl?: string;
  nick?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarUrl: 'avatarUrl',
      nick: 'nick',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarUrl: 'string',
      nick: 'string',
      userId: 'string',
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

export class UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList extends $tea.Model {
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

export class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList extends $tea.Model {
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

export class UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse extends $tea.Model {
  invoiceKeyVOList?: UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList[];
  static names(): { [key: string]: string } {
    return {
      invoiceKeyVOList: 'invoiceKeyVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoiceKeyVOList: { 'type': 'array', 'itemType': UnbindApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnbindApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList extends $tea.Model {
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

export class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodsName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxPreType?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodsName: 'goodsName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxPreType: 'taxPreType',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodsName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxPreType: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList extends $tea.Model {
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

export class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOList extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  sellerBankAccount?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
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
      drawerName: 'drawerName',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      imageUrl: 'imageUrl',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
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
      drawerName: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList },
      imageUrl: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList },
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList extends $tea.Model {
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

export class UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponse extends $tea.Model {
  invoiceKeyVOList?: UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList[];
  static names(): { [key: string]: string } {
    return {
      invoiceKeyVOList: 'invoiceKeyVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoiceKeyVOList: { 'type': 'array', 'itemType': UpdateApplyReceiptAndInvoiceRelatedResponseBodyBatchUpdateInvoiceResponseInvoiceKeyVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApplyReceiptAndInvoiceRelatedResponseBodyErrorInvoiceKeyVOList extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodsName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxPreType?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodsName: 'goodsName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxPreType: 'taxPreType',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodsName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxPreType: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVO extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList[];
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  sellerBankAccount?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList[];
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
      drawerName: 'drawerName',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      imageUrl: 'imageUrl',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
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
      drawerName: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList },
      imageUrl: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOVehicleSaleDetailVOList },
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
  goodsName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxPreType?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodsName: 'goodsName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxPreType: 'taxPreType',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodsName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxPreType: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList[];
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  sellerBankAccount?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList[];
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
      drawerName: 'drawerName',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      imageUrl: 'imageUrl',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
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
      drawerName: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList },
      imageUrl: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOVehicleSaleDetailVOList },
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodsName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxPreType?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodsName: 'goodsName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxPreType: 'taxPreType',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodsName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxPreType: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList extends $tea.Model {
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

export class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  sellerBankAccount?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
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
      drawerName: 'drawerName',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      imageUrl: 'imageUrl',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
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
      drawerName: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList },
      imageUrl: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList },
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList extends $tea.Model {
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

export class UpdateInvoiceAccountPeriodResponseBodyErrorResult extends $tea.Model {
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

export class UpdateInvoiceAccountPeriodResponseBodySuccessResult extends $tea.Model {
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

export class UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList extends $tea.Model {
  accountingPeriodData?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  static names(): { [key: string]: string } {
    return {
      accountingPeriodData: 'accountingPeriodData',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountingPeriodData: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingPeriodDateResponseBodyResult extends $tea.Model {
  failCount?: number;
  failInvoices?: UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      failCount: 'failCount',
      failInvoices: 'failInvoices',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failCount: 'number',
      failInvoices: { 'type': 'array', 'itemType': UpdateInvoiceAccountingPeriodDateResponseBodyResultFailInvoices },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList extends $tea.Model {
  accountingStatus?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceType?: string;
  static names(): { [key: string]: string } {
    return {
      accountingStatus: 'accountingStatus',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountingStatus: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices extends $tea.Model {
  errorCode?: string;
  errorMsg?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  static names(): { [key: string]: string } {
    return {
      errorCode: 'errorCode',
      errorMsg: 'errorMsg',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorCode: 'string',
      errorMsg: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAccountingStatusResponseBodyResult extends $tea.Model {
  failCount?: number;
  failInvoices?: UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      failCount: 'failCount',
      failInvoices: 'failInvoices',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failCount: 'number',
      failInvoices: { 'type': 'array', 'itemType': UpdateInvoiceAccountingStatusResponseBodyResultFailInvoices },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails extends $tea.Model {
  carrier?: string;
  flightNumber?: string;
  flyDate?: string;
  flyFrom?: string;
  flyTime?: string;
  flyTo?: string;
  seat?: string;
  static names(): { [key: string]: string } {
    return {
      carrier: 'carrier',
      flightNumber: 'flightNumber',
      flyDate: 'flyDate',
      flyFrom: 'flyFrom',
      flyTime: 'flyTime',
      flyTo: 'flyTo',
      seat: 'seat',
    };
  }

  static types(): { [key: string]: any } {
    return {
      carrier: 'string',
      flightNumber: 'string',
      flyDate: 'string',
      flyFrom: 'string',
      flyTime: 'string',
      flyTo: 'string',
      seat: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodsName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxPreType?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodsName: 'goodsName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxPreType: 'taxPreType',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodsName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxPreType: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList extends $tea.Model {
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

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVO extends $tea.Model {
  accountPeriod?: string;
  agentCode?: string;
  amount?: string;
  amountWithTax?: string;
  caacDevelopmentFund?: string;
  checkCode?: string;
  checkTime?: string;
  city?: string;
  destination?: string;
  distance?: string;
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  entrance?: string;
  exit?: string;
  financeType?: string;
  flightItineraryDetails?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails[];
  fuelSurcharge?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList[];
  getOffTime?: string;
  getOnTime?: string;
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  issueBy?: string;
  machineCode?: string;
  oilFlag?: string;
  origin?: string;
  passenger?: string;
  passengerUserId?: string;
  payee?: string;
  printSerialNumber?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  seatClass?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  sellerBankAccount?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  serialNo?: string;
  startTime?: string;
  supplySign?: string;
  surcharge?: string;
  taxAmount?: string;
  trainNo?: string;
  travelDate?: string;
  usedVehicleSaleDetailVOList?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList[];
  verifyStatus?: string;
  voucherCode?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      agentCode: 'agentCode',
      amount: 'amount',
      amountWithTax: 'amountWithTax',
      caacDevelopmentFund: 'caacDevelopmentFund',
      checkCode: 'checkCode',
      checkTime: 'checkTime',
      city: 'city',
      destination: 'destination',
      distance: 'distance',
      drawerName: 'drawerName',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      entrance: 'entrance',
      exit: 'exit',
      financeType: 'financeType',
      flightItineraryDetails: 'flightItineraryDetails',
      fuelSurcharge: 'fuelSurcharge',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      getOffTime: 'getOffTime',
      getOnTime: 'getOnTime',
      imageUrl: 'imageUrl',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceType: 'invoiceType',
      issueBy: 'issueBy',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      origin: 'origin',
      passenger: 'passenger',
      passengerUserId: 'passengerUserId',
      payee: 'payee',
      printSerialNumber: 'printSerialNumber',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      seatClass: 'seatClass',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      serialNo: 'serialNo',
      startTime: 'startTime',
      supplySign: 'supplySign',
      surcharge: 'surcharge',
      taxAmount: 'taxAmount',
      trainNo: 'trainNo',
      travelDate: 'travelDate',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
      verifyStatus: 'verifyStatus',
      voucherCode: 'voucherCode',
      voucherStatus: 'voucherStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountPeriod: 'string',
      agentCode: 'string',
      amount: 'string',
      amountWithTax: 'string',
      caacDevelopmentFund: 'string',
      checkCode: 'string',
      checkTime: 'string',
      city: 'string',
      destination: 'string',
      distance: 'string',
      drawerName: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      entrance: 'string',
      exit: 'string',
      financeType: 'string',
      flightItineraryDetails: { 'type': 'array', 'itemType': UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails },
      fuelSurcharge: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList },
      getOffTime: 'string',
      getOnTime: 'string',
      imageUrl: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
      invoiceType: 'string',
      issueBy: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      origin: 'string',
      passenger: 'string',
      passengerUserId: 'string',
      payee: 'string',
      printSerialNumber: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      seatClass: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      serialNo: 'string',
      startTime: 'string',
      supplySign: 'string',
      surcharge: 'string',
      taxAmount: 'string',
      trainNo: 'string',
      travelDate: 'string',
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOVehicleSaleDetailVOList },
      verifyStatus: 'string',
      voucherCode: 'string',
      voucherStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList extends $tea.Model {
  amount?: string;
  goodsName?: string;
  quantity?: string;
  revenueCode?: string;
  rowNo?: string;
  specification?: string;
  taxAmount?: string;
  taxPre?: string;
  taxPreType?: string;
  taxRate?: string;
  unit?: string;
  unitPrice?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      goodsName: 'goodsName',
      quantity: 'quantity',
      revenueCode: 'revenueCode',
      rowNo: 'rowNo',
      specification: 'specification',
      taxAmount: 'taxAmount',
      taxPre: 'taxPre',
      taxPreType: 'taxPreType',
      taxRate: 'taxRate',
      unit: 'unit',
      unitPrice: 'unitPrice',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      goodsName: 'string',
      quantity: 'string',
      revenueCode: 'string',
      rowNo: 'string',
      specification: 'string',
      taxAmount: 'string',
      taxPre: 'string',
      taxPreType: 'string',
      taxRate: 'string',
      unit: 'string',
      unitPrice: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList extends $tea.Model {
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

export class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList extends $tea.Model {
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

export class UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList extends $tea.Model {
  accountPeriod?: string;
  amount?: string;
  amountWithTax?: string;
  checkCode?: string;
  checkTime?: string;
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  machineCode?: string;
  oilFlag?: string;
  payee?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  sellerBankAccount?: string;
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  supplySign?: string;
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
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
      drawerName: 'drawerName',
      drewDate: 'drewDate',
      electronicUrl: 'electronicUrl',
      financeType: 'financeType',
      fundType: 'fundType',
      generalInvoiceDetailVOList: 'generalInvoiceDetailVOList',
      imageUrl: 'imageUrl',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceType: 'invoiceType',
      machineCode: 'machineCode',
      oilFlag: 'oilFlag',
      payee: 'payee',
      processInstCode: 'processInstCode',
      processInstType: 'processInstType',
      purchaserAddress: 'purchaserAddress',
      purchaserBankAccount: 'purchaserBankAccount',
      purchaserBankNameAccount: 'purchaserBankNameAccount',
      purchaserName: 'purchaserName',
      purchaserTaxNo: 'purchaserTaxNo',
      purchaserTel: 'purchaserTel',
      remark: 'remark',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      supplySign: 'supplySign',
      taxAmount: 'taxAmount',
      usedVehicleSaleDetailVOList: 'usedVehicleSaleDetailVOList',
      vehicleSaleDetailVOList: 'vehicleSaleDetailVOList',
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
      drawerName: 'string',
      drewDate: 'string',
      electronicUrl: 'string',
      financeType: 'string',
      fundType: 'string',
      generalInvoiceDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList },
      imageUrl: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'string',
      invoiceType: 'string',
      machineCode: 'string',
      oilFlag: 'string',
      payee: 'string',
      processInstCode: 'string',
      processInstType: 'string',
      purchaserAddress: 'string',
      purchaserBankAccount: 'string',
      purchaserBankNameAccount: 'string',
      purchaserName: 'string',
      purchaserTaxNo: 'string',
      purchaserTel: 'string',
      remark: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      supplySign: 'string',
      taxAmount: 'string',
      usedVehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList },
      vehicleSaleDetailVOList: { 'type': 'array', 'itemType': UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList },
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


  async appendRolePermissionWithOptions(tmpReq: AppendRolePermissionRequest, headers: AppendRolePermissionHeaders, runtime: $Util.RuntimeOptions): Promise<AppendRolePermissionResponse> {
    Util.validateModel(tmpReq);
    let request = new AppendRolePermissionShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.rolePermissionItemList)) {
      request.rolePermissionItemListShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.rolePermissionItemList, "rolePermissionItemList", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.rolePermissionItemListShrink)) {
      query["rolePermissionItemList"] = request.rolePermissionItemListShrink;
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
      action: "AppendRolePermission",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/roles/permissions`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AppendRolePermissionResponse>(await this.execute(params, req, runtime), new AppendRolePermissionResponse({}));
  }

  async appendRolePermission(request: AppendRolePermissionRequest): Promise<AppendRolePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendRolePermissionHeaders({ });
    return await this.appendRolePermissionWithOptions(request, headers, runtime);
  }

  async batchAddInvoiceWithOptions(request: BatchAddInvoiceRequest, headers: BatchAddInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<BatchAddInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.generalInvoiceVOList)) {
      body["generalInvoiceVOList"] = request.generalInvoiceVOList;
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
      action: "BatchAddInvoice",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchAddInvoiceResponse>(await this.execute(params, req, runtime), new BatchAddInvoiceResponse({}));
  }

  async batchAddInvoice(request: BatchAddInvoiceRequest): Promise<BatchAddInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddInvoiceHeaders({ });
    return await this.batchAddInvoiceWithOptions(request, headers, runtime);
  }

  async batchCreateCustomerWithOptions(request: BatchCreateCustomerRequest, headers: BatchCreateCustomerHeaders, runtime: $Util.RuntimeOptions): Promise<BatchCreateCustomerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.createCustomerRequestList)) {
      body["createCustomerRequestList"] = request.createCustomerRequestList;
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
      action: "BatchCreateCustomer",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/auxiliaries/batch`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchCreateCustomerResponse>(await this.execute(params, req, runtime), new BatchCreateCustomerResponse({}));
  }

  async batchCreateCustomer(request: BatchCreateCustomerRequest): Promise<BatchCreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateCustomerHeaders({ });
    return await this.batchCreateCustomerWithOptions(request, headers, runtime);
  }

  async bindCompanyAccountantBookWithOptions(request: BindCompanyAccountantBookRequest, headers: BindCompanyAccountantBookHeaders, runtime: $Util.RuntimeOptions): Promise<BindCompanyAccountantBookResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountantBookId)) {
      query["accountantBookId"] = request.accountantBookId;
    }

    if (!Util.isUnset(request.companyCode)) {
      query["companyCode"] = request.companyCode;
    }

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
      action: "BindCompanyAccountantBook",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/companies/accountantBooks/bind`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BindCompanyAccountantBookResponse>(await this.execute(params, req, runtime), new BindCompanyAccountantBookResponse({}));
  }

  async bindCompanyAccountantBook(request: BindCompanyAccountantBookRequest): Promise<BindCompanyAccountantBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BindCompanyAccountantBookHeaders({ });
    return await this.bindCompanyAccountantBookWithOptions(request, headers, runtime);
  }

  async checkVoucherStatusWithOptions(request: CheckVoucherStatusRequest, headers: CheckVoucherStatusHeaders, runtime: $Util.RuntimeOptions): Promise<CheckVoucherStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.financeType)) {
      body["financeType"] = request.financeType;
    }

    if (!Util.isUnset(request.invoiceCode)) {
      body["invoiceCode"] = request.invoiceCode;
    }

    if (!Util.isUnset(request.invoiceNo)) {
      body["invoiceNo"] = request.invoiceNo;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.taxNo)) {
      body["taxNo"] = request.taxNo;
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
    let params = new $OpenApi.Params({
      action: "CheckVoucherStatus",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/checkVoucherStatus/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CheckVoucherStatusResponse>(await this.execute(params, req, runtime), new CheckVoucherStatusResponse({}));
  }

  async checkVoucherStatus(request: CheckVoucherStatusRequest): Promise<CheckVoucherStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckVoucherStatusHeaders({ });
    return await this.checkVoucherStatusWithOptions(request, headers, runtime);
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

    if (!Util.isUnset(request.drawerEmail)) {
      body["drawerEmail"] = request.drawerEmail;
    }

    if (!Util.isUnset(request.drawerTelephone)) {
      body["drawerTelephone"] = request.drawerTelephone;
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
    let params = new $OpenApi.Params({
      action: "CreateCustomer",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/auxiliaries/customers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCustomerResponse>(await this.execute(params, req, runtime), new CreateCustomerResponse({}));
  }

  async createCustomer(request: CreateCustomerRequest): Promise<CreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomerHeaders({ });
    return await this.createCustomerWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "CreateReceipt",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/receipts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateReceiptResponse>(await this.execute(params, req, runtime), new CreateReceiptResponse({}));
  }

  async createReceipt(request: CreateReceiptRequest): Promise<CreateReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateReceiptHeaders({ });
    return await this.createReceiptWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "DeleteReceipt",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/receipts/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteReceiptResponse>(await this.execute(params, req, runtime), new DeleteReceiptResponse({}));
  }

  async deleteReceipt(request: DeleteReceiptRequest): Promise<DeleteReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteReceiptHeaders({ });
    return await this.deleteReceiptWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetBookkeepingUserList",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/bookkeeping/users`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBookkeepingUserListResponse>(await this.execute(params, req, runtime), new GetBookkeepingUserListResponse({}));
  }

  async getBookkeepingUserList(): Promise<GetBookkeepingUserListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBookkeepingUserListHeaders({ });
    return await this.getBookkeepingUserListWithOptions(headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/categories/get`,
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
    let params = new $OpenApi.Params({
      action: "GetCustomer",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/customers/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCustomerResponse>(await this.execute(params, req, runtime), new GetCustomerResponse({}));
  }

  async getCustomer(request: GetCustomerRequest): Promise<GetCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCustomerHeaders({ });
    return await this.getCustomerWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/financeAccounts/get`,
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

  async getInvoiceByPageWithOptions(tmpReq: GetInvoiceByPageRequest, headers: GetInvoiceByPageHeaders, runtime: $Util.RuntimeOptions): Promise<GetInvoiceByPageResponse> {
    Util.validateModel(tmpReq);
    let request = new GetInvoiceByPageShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.request)) {
      request.requestShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.request, "request", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.requestShrink)) {
      query["request"] = request.requestShrink;
    }

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
      action: "GetInvoiceByPage",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInvoiceByPageResponse>(await this.execute(params, req, runtime), new GetInvoiceByPageResponse({}));
  }

  async getInvoiceByPage(request: GetInvoiceByPageRequest): Promise<GetInvoiceByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInvoiceByPageHeaders({ });
    return await this.getInvoiceByPageWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "GetIsNewVersion",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/accounts/uses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetIsNewVersionResponse>(await this.execute(params, req, runtime), new GetIsNewVersionResponse({}));
  }

  async getIsNewVersion(): Promise<GetIsNewVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIsNewVersionHeaders({ });
    return await this.getIsNewVersionWithOptions(headers, runtime);
  }

  async getMultiCompanyInfoByCodeWithOptions(companyCode: string, headers: GetMultiCompanyInfoByCodeHeaders, runtime: $Util.RuntimeOptions): Promise<GetMultiCompanyInfoByCodeResponse> {
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
      action: "GetMultiCompanyInfoByCode",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/multiCompanies/${companyCode}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMultiCompanyInfoByCodeResponse>(await this.execute(params, req, runtime), new GetMultiCompanyInfoByCodeResponse({}));
  }

  async getMultiCompanyInfoByCode(companyCode: string): Promise<GetMultiCompanyInfoByCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMultiCompanyInfoByCodeHeaders({ });
    return await this.getMultiCompanyInfoByCodeWithOptions(companyCode, headers, runtime);
  }

  async getProductWithOptions(request: GetProductRequest, headers: GetProductHeaders, runtime: $Util.RuntimeOptions): Promise<GetProductResponse> {
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
      action: "GetProduct",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/products`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetProductResponse>(await this.execute(params, req, runtime), new GetProductResponse({}));
  }

  async getProduct(request: GetProductRequest): Promise<GetProductResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProductHeaders({ });
    return await this.getProductWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/projects/get`,
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/receipts/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetReceiptResponse>(await this.execute(params, req, runtime), new GetReceiptResponse({}));
  }

  async getReceipt(request: GetReceiptRequest): Promise<GetReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetReceiptHeaders({ });
    return await this.getReceiptWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/suppliers/details`,
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

  async getYongYouOpenApiTokenWithOptions(request: GetYongYouOpenApiTokenRequest, headers: GetYongYouOpenApiTokenHeaders, runtime: $Util.RuntimeOptions): Promise<GetYongYouOpenApiTokenResponse> {
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
      action: "GetYongYouOpenApiToken",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/yongyou/token`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetYongYouOpenApiTokenResponse>(await this.execute(params, req, runtime), new GetYongYouOpenApiTokenResponse({}));
  }

  async getYongYouOpenApiToken(request: GetYongYouOpenApiTokenRequest): Promise<GetYongYouOpenApiTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetYongYouOpenApiTokenHeaders({ });
    return await this.getYongYouOpenApiTokenWithOptions(request, headers, runtime);
  }

  async getYongYouOrgRelationWithOptions(headers: GetYongYouOrgRelationHeaders, runtime: $Util.RuntimeOptions): Promise<GetYongYouOrgRelationResponse> {
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
      action: "GetYongYouOrgRelation",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/yongyou/relations`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetYongYouOrgRelationResponse>(await this.execute(params, req, runtime), new GetYongYouOrgRelationResponse({}));
  }

  async getYongYouOrgRelation(): Promise<GetYongYouOrgRelationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetYongYouOrgRelationHeaders({ });
    return await this.getYongYouOrgRelationWithOptions(headers, runtime);
  }

  async professionBenefitConsumeWithOptions(request: ProfessionBenefitConsumeRequest, headers: ProfessionBenefitConsumeHeaders, runtime: $Util.RuntimeOptions): Promise<ProfessionBenefitConsumeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      body["benefitCode"] = request.benefitCode;
    }

    if (!Util.isUnset(request.bizRequestId)) {
      body["bizRequestId"] = request.bizRequestId;
    }

    if (!Util.isUnset(request.quota)) {
      body["quota"] = request.quota;
    }

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
      action: "ProfessionBenefitConsume",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/professions/benefits/consume`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ProfessionBenefitConsumeResponse>(await this.execute(params, req, runtime), new ProfessionBenefitConsumeResponse({}));
  }

  async professionBenefitConsume(request: ProfessionBenefitConsumeRequest): Promise<ProfessionBenefitConsumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProfessionBenefitConsumeHeaders({ });
    return await this.professionBenefitConsumeWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/categories/list`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCategoryByPageResponse>(await this.execute(params, req, runtime), new QueryCategoryByPageResponse({}));
  }

  async queryCategoryByPage(request: QueryCategoryByPageRequest): Promise<QueryCategoryByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCategoryByPageHeaders({ });
    return await this.queryCategoryByPageWithOptions(request, headers, runtime);
  }

  async queryCompanyInvoiceRelationCountWithOptions(request: QueryCompanyInvoiceRelationCountRequest, headers: QueryCompanyInvoiceRelationCountHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCompanyInvoiceRelationCountResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      query["companyCode"] = request.companyCode;
    }

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
      action: "QueryCompanyInvoiceRelationCount",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/companyRelationReceipts/counts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCompanyInvoiceRelationCountResponse>(await this.execute(params, req, runtime), new QueryCompanyInvoiceRelationCountResponse({}));
  }

  async queryCompanyInvoiceRelationCount(request: QueryCompanyInvoiceRelationCountRequest): Promise<QueryCompanyInvoiceRelationCountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCompanyInvoiceRelationCountHeaders({ });
    return await this.queryCompanyInvoiceRelationCountWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/customers`,
      method: "GET",
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

  async queryCustomerInfoWithOptions(request: QueryCustomerInfoRequest, headers: QueryCustomerInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomerInfoResponse> {
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
      action: "QueryCustomerInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/auxiliaries/customers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCustomerInfoResponse>(await this.execute(params, req, runtime), new QueryCustomerInfoResponse({}));
  }

  async queryCustomerInfo(request: QueryCustomerInfoRequest): Promise<QueryCustomerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerInfoHeaders({ });
    return await this.queryCustomerInfoWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/financeAccounts/list`,
      method: "GET",
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

  async queryFinanceCompanyInfoWithOptions(headers: QueryFinanceCompanyInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFinanceCompanyInfoResponse> {
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
      action: "QueryFinanceCompanyInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/companies`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryFinanceCompanyInfoResponse>(await this.execute(params, req, runtime), new QueryFinanceCompanyInfoResponse({}));
  }

  async queryFinanceCompanyInfo(): Promise<QueryFinanceCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFinanceCompanyInfoHeaders({ });
    return await this.queryFinanceCompanyInfoWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryInvoiceRelationCount",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/relationReceipts/counts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryInvoiceRelationCountResponse>(await this.execute(params, req, runtime), new QueryInvoiceRelationCountResponse({}));
  }

  async queryInvoiceRelationCount(): Promise<QueryInvoiceRelationCountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInvoiceRelationCountHeaders({ });
    return await this.queryInvoiceRelationCountWithOptions(headers, runtime);
  }

  async queryMultiCompanyInfoWithOptions(headers: QueryMultiCompanyInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMultiCompanyInfoResponse> {
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
      action: "QueryMultiCompanyInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/multiCompanies`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMultiCompanyInfoResponse>(await this.execute(params, req, runtime), new QueryMultiCompanyInfoResponse({}));
  }

  async queryMultiCompanyInfo(): Promise<QueryMultiCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMultiCompanyInfoHeaders({ });
    return await this.queryMultiCompanyInfoWithOptions(headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryPermissionByUserId",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/permissions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPermissionByUserIdResponse>(await this.execute(params, req, runtime), new QueryPermissionByUserIdResponse({}));
  }

  async queryPermissionByUserId(request: QueryPermissionByUserIdRequest): Promise<QueryPermissionByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPermissionByUserIdHeaders({ });
    return await this.queryPermissionByUserIdWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryPermissionRoleMember",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/roles/members/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPermissionRoleMemberResponse>(await this.execute(params, req, runtime), new QueryPermissionRoleMemberResponse({}));
  }

  async queryPermissionRoleMember(request: QueryPermissionRoleMemberRequest): Promise<QueryPermissionRoleMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPermissionRoleMemberHeaders({ });
    return await this.queryPermissionRoleMemberWithOptions(request, headers, runtime);
  }

  async queryProductByPageWithOptions(request: QueryProductByPageRequest, headers: QueryProductByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryProductByPageResponse> {
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
      action: "QueryProductByPage",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/products/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryProductByPageResponse>(await this.execute(params, req, runtime), new QueryProductByPageResponse({}));
  }

  async queryProductByPage(request: QueryProductByPageRequest): Promise<QueryProductByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProductByPageHeaders({ });
    return await this.queryProductByPageWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/projects/list`,
      method: "GET",
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

  async queryReceiptDetailForInvoiceWithOptions(request: QueryReceiptDetailForInvoiceRequest, headers: QueryReceiptDetailForInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReceiptDetailForInvoiceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

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
      action: "QueryReceiptDetailForInvoice",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/receipts/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryReceiptDetailForInvoiceResponse>(await this.execute(params, req, runtime), new QueryReceiptDetailForInvoiceResponse({}));
  }

  async queryReceiptDetailForInvoice(request: QueryReceiptDetailForInvoiceRequest): Promise<QueryReceiptDetailForInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptDetailForInvoiceHeaders({ });
    return await this.queryReceiptDetailForInvoiceWithOptions(request, headers, runtime);
  }

  async queryReceiptForInvoiceWithOptions(request: QueryReceiptForInvoiceRequest, headers: QueryReceiptForInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReceiptForInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountantBookId)) {
      body["accountantBookId"] = request.accountantBookId;
    }

    if (!Util.isUnset(request.applyStatusList)) {
      body["applyStatusList"] = request.applyStatusList;
    }

    if (!Util.isUnset(request.bizStatusList)) {
      body["bizStatusList"] = request.bizStatusList;
    }

    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.receiptStatusList)) {
      body["receiptStatusList"] = request.receiptStatusList;
    }

    if (!Util.isUnset(request.searchParams)) {
      body["searchParams"] = request.searchParams;
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
    let params = new $OpenApi.Params({
      action: "QueryReceiptForInvoice",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/receipts/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryReceiptForInvoiceResponse>(await this.execute(params, req, runtime), new QueryReceiptForInvoiceResponse({}));
  }

  async queryReceiptForInvoice(request: QueryReceiptForInvoiceRequest): Promise<QueryReceiptForInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptForInvoiceHeaders({ });
    return await this.queryReceiptForInvoiceWithOptions(request, headers, runtime);
  }

  async queryReceiptsBaseInfoWithOptions(request: QueryReceiptsBaseInfoRequest, headers: QueryReceiptsBaseInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReceiptsBaseInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountantBookId)) {
      query["accountantBookId"] = request.accountantBookId;
    }

    if (!Util.isUnset(request.companyCode)) {
      query["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
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

    if (!Util.isUnset(request.title)) {
      query["title"] = request.title;
    }

    if (!Util.isUnset(request.voucherStatus)) {
      query["voucherStatus"] = request.voucherStatus;
    }

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
      action: "QueryReceiptsBaseInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/receipts/dataInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryReceiptsBaseInfoResponse>(await this.execute(params, req, runtime), new QueryReceiptsBaseInfoResponse({}));
  }

  async queryReceiptsBaseInfo(request: QueryReceiptsBaseInfoRequest): Promise<QueryReceiptsBaseInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptsBaseInfoHeaders({ });
    return await this.queryReceiptsBaseInfoWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "QueryReceiptsByPage",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/receipts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryReceiptsByPageResponse>(await this.execute(params, req, runtime), new QueryReceiptsByPageResponse({}));
  }

  async queryReceiptsByPage(request: QueryReceiptsByPageRequest): Promise<QueryReceiptsByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptsByPageHeaders({ });
    return await this.queryReceiptsByPageWithOptions(request, headers, runtime);
  }

  async queryRoleMemberByPageWithOptions(request: QueryRoleMemberByPageRequest, headers: QueryRoleMemberByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRoleMemberByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.roleCode)) {
      query["roleCode"] = request.roleCode;
    }

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
      action: "QueryRoleMemberByPage",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/roles/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRoleMemberByPageResponse>(await this.execute(params, req, runtime), new QueryRoleMemberByPageResponse({}));
  }

  async queryRoleMemberByPage(request: QueryRoleMemberByPageRequest): Promise<QueryRoleMemberByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRoleMemberByPageHeaders({ });
    return await this.queryRoleMemberByPageWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/suppliers`,
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

  async queryUserRoleListWithOptions(request: QueryUserRoleListRequest, headers: QueryUserRoleListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserRoleListResponse> {
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
      action: "QueryUserRoleList",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/users/roles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserRoleListResponse>(await this.execute(params, req, runtime), new QueryUserRoleListResponse({}));
  }

  async queryUserRoleList(request: QueryUserRoleListRequest): Promise<QueryUserRoleListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserRoleListHeaders({ });
    return await this.queryUserRoleListWithOptions(request, headers, runtime);
  }

  async unbindApplyReceiptAndInvoiceRelatedWithOptions(request: UnbindApplyReceiptAndInvoiceRelatedRequest, headers: UnbindApplyReceiptAndInvoiceRelatedHeaders, runtime: $Util.RuntimeOptions): Promise<UnbindApplyReceiptAndInvoiceRelatedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.invoiceKeyVOList)) {
      body["invoiceKeyVOList"] = request.invoiceKeyVOList;
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
      action: "UnbindApplyReceiptAndInvoiceRelated",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/unbind`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UnbindApplyReceiptAndInvoiceRelatedResponse>(await this.execute(params, req, runtime), new UnbindApplyReceiptAndInvoiceRelatedResponse({}));
  }

  async unbindApplyReceiptAndInvoiceRelated(request: UnbindApplyReceiptAndInvoiceRelatedRequest): Promise<UnbindApplyReceiptAndInvoiceRelatedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders({ });
    return await this.unbindApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
  }

  async updateApplyReceiptAndInvoiceRelatedWithOptions(request: UpdateApplyReceiptAndInvoiceRelatedRequest, headers: UpdateApplyReceiptAndInvoiceRelatedHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateApplyReceiptAndInvoiceRelatedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.generalInvoiceVOList)) {
      body["generalInvoiceVOList"] = request.generalInvoiceVOList;
    }

    if (!Util.isUnset(request.instanceId)) {
      body["instanceId"] = request.instanceId;
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
      action: "UpdateApplyReceiptAndInvoiceRelated",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/applyReceipts/relate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateApplyReceiptAndInvoiceRelatedResponse>(await this.execute(params, req, runtime), new UpdateApplyReceiptAndInvoiceRelatedResponse({}));
  }

  async updateApplyReceiptAndInvoiceRelated(request: UpdateApplyReceiptAndInvoiceRelatedRequest): Promise<UpdateApplyReceiptAndInvoiceRelatedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders({ });
    return await this.updateApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
  }

  async updateDigitalInvoiceOrgInfoWithOptions(request: UpdateDigitalInvoiceOrgInfoRequest, headers: UpdateDigitalInvoiceOrgInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateDigitalInvoiceOrgInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.digitalInvoiceType)) {
      body["digitalInvoiceType"] = request.digitalInvoiceType;
    }

    if (!Util.isUnset(request.isDigitalOrg)) {
      body["isDigitalOrg"] = request.isDigitalOrg;
    }

    if (!Util.isUnset(request.location)) {
      body["location"] = request.location;
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
      action: "UpdateDigitalInvoiceOrgInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/organizationInfos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateDigitalInvoiceOrgInfoResponse>(await this.execute(params, req, runtime), new UpdateDigitalInvoiceOrgInfoResponse({}));
  }

  async updateDigitalInvoiceOrgInfo(request: UpdateDigitalInvoiceOrgInfoRequest): Promise<UpdateDigitalInvoiceOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDigitalInvoiceOrgInfoHeaders({ });
    return await this.updateDigitalInvoiceOrgInfoWithOptions(request, headers, runtime);
  }

  async updateFinanceCompanyInfoWithOptions(request: UpdateFinanceCompanyInfoRequest, headers: UpdateFinanceCompanyInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateFinanceCompanyInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyName)) {
      query["companyName"] = request.companyName;
    }

    if (!Util.isUnset(request.taxNature)) {
      query["taxNature"] = request.taxNature;
    }

    if (!Util.isUnset(request.taxNo)) {
      query["taxNo"] = request.taxNo;
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
      action: "UpdateFinanceCompanyInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/companies`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateFinanceCompanyInfoResponse>(await this.execute(params, req, runtime), new UpdateFinanceCompanyInfoResponse({}));
  }

  async updateFinanceCompanyInfo(request: UpdateFinanceCompanyInfoRequest): Promise<UpdateFinanceCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFinanceCompanyInfoHeaders({ });
    return await this.updateFinanceCompanyInfoWithOptions(request, headers, runtime);
  }

  async updateFinanceMultiCompanyInfoWithOptions(request: UpdateFinanceMultiCompanyInfoRequest, headers: UpdateFinanceMultiCompanyInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateFinanceMultiCompanyInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      query["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.companyName)) {
      query["companyName"] = request.companyName;
    }

    if (!Util.isUnset(request.taxNature)) {
      query["taxNature"] = request.taxNature;
    }

    if (!Util.isUnset(request.taxNo)) {
      query["taxNo"] = request.taxNo;
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
      action: "UpdateFinanceMultiCompanyInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/multiCompanies`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateFinanceMultiCompanyInfoResponse>(await this.execute(params, req, runtime), new UpdateFinanceMultiCompanyInfoResponse({}));
  }

  async updateFinanceMultiCompanyInfo(request: UpdateFinanceMultiCompanyInfoRequest): Promise<UpdateFinanceMultiCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFinanceMultiCompanyInfoHeaders({ });
    return await this.updateFinanceMultiCompanyInfoWithOptions(request, headers, runtime);
  }

  async updateInvoiceAbandonStatusWithOptions(request: UpdateInvoiceAbandonStatusRequest, headers: UpdateInvoiceAbandonStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceAbandonStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.blueGeneralInvoiceVO)) {
      body["blueGeneralInvoiceVO"] = request.blueGeneralInvoiceVO;
    }

    if (!Util.isUnset(request.blueInvoiceCode)) {
      body["blueInvoiceCode"] = request.blueInvoiceCode;
    }

    if (!Util.isUnset(request.blueInvoiceNo)) {
      body["blueInvoiceNo"] = request.blueInvoiceNo;
    }

    if (!Util.isUnset(request.blueInvoiceStatus)) {
      body["blueInvoiceStatus"] = request.blueInvoiceStatus;
    }

    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.redGeneralInvoiceVO)) {
      body["redGeneralInvoiceVO"] = request.redGeneralInvoiceVO;
    }

    if (!Util.isUnset(request.redInvoiceCode)) {
      body["redInvoiceCode"] = request.redInvoiceCode;
    }

    if (!Util.isUnset(request.redInvoiceNo)) {
      body["redInvoiceNo"] = request.redInvoiceNo;
    }

    if (!Util.isUnset(request.redInvoiceStatus)) {
      body["redInvoiceStatus"] = request.redInvoiceStatus;
    }

    if (!Util.isUnset(request.targetInvoice)) {
      body["targetInvoice"] = request.targetInvoice;
    }

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
      action: "UpdateInvoiceAbandonStatus",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/abandonStatus`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceAbandonStatusResponse>(await this.execute(params, req, runtime), new UpdateInvoiceAbandonStatusResponse({}));
  }

  async updateInvoiceAbandonStatus(request: UpdateInvoiceAbandonStatusRequest): Promise<UpdateInvoiceAbandonStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAbandonStatusHeaders({ });
    return await this.updateInvoiceAbandonStatusWithOptions(request, headers, runtime);
  }

  async updateInvoiceAccountPeriodWithOptions(request: UpdateInvoiceAccountPeriodRequest, headers: UpdateInvoiceAccountPeriodHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceAccountPeriodResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountPeriod)) {
      body["accountPeriod"] = request.accountPeriod;
    }

    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.generalInvoiceVOList)) {
      body["generalInvoiceVOList"] = request.generalInvoiceVOList;
    }

    if (!Util.isUnset(request.invoiceKeyVOList)) {
      body["invoiceKeyVOList"] = request.invoiceKeyVOList;
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
      action: "UpdateInvoiceAccountPeriod",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/accountPeriods`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceAccountPeriodResponse>(await this.execute(params, req, runtime), new UpdateInvoiceAccountPeriodResponse({}));
  }

  async updateInvoiceAccountPeriod(request: UpdateInvoiceAccountPeriodRequest): Promise<UpdateInvoiceAccountPeriodResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAccountPeriodHeaders({ });
    return await this.updateInvoiceAccountPeriodWithOptions(request, headers, runtime);
  }

  async updateInvoiceAccountingPeriodDateWithOptions(request: UpdateInvoiceAccountingPeriodDateRequest, headers: UpdateInvoiceAccountingPeriodDateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceAccountingPeriodDateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.invoiceFinanceInfoVOList)) {
      body["invoiceFinanceInfoVOList"] = request.invoiceFinanceInfoVOList;
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
      action: "UpdateInvoiceAccountingPeriodDate",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/accounts/periodDates`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceAccountingPeriodDateResponse>(await this.execute(params, req, runtime), new UpdateInvoiceAccountingPeriodDateResponse({}));
  }

  async updateInvoiceAccountingPeriodDate(request: UpdateInvoiceAccountingPeriodDateRequest): Promise<UpdateInvoiceAccountingPeriodDateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAccountingPeriodDateHeaders({ });
    return await this.updateInvoiceAccountingPeriodDateWithOptions(request, headers, runtime);
  }

  async updateInvoiceAccountingStatusWithOptions(request: UpdateInvoiceAccountingStatusRequest, headers: UpdateInvoiceAccountingStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceAccountingStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.invoiceFinanceInfoVOList)) {
      body["invoiceFinanceInfoVOList"] = request.invoiceFinanceInfoVOList;
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
      action: "UpdateInvoiceAccountingStatus",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/accounts/statuses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceAccountingStatusResponse>(await this.execute(params, req, runtime), new UpdateInvoiceAccountingStatusResponse({}));
  }

  async updateInvoiceAccountingStatus(request: UpdateInvoiceAccountingStatusRequest): Promise<UpdateInvoiceAccountingStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAccountingStatusHeaders({ });
    return await this.updateInvoiceAccountingStatusWithOptions(request, headers, runtime);
  }

  async updateInvoiceAndReceiptRelatedWithOptions(request: UpdateInvoiceAndReceiptRelatedRequest, headers: UpdateInvoiceAndReceiptRelatedHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceAndReceiptRelatedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.generalInvoiceVO)) {
      body["generalInvoiceVO"] = request.generalInvoiceVO;
    }

    if (!Util.isUnset(request.invoiceCode)) {
      body["invoiceCode"] = request.invoiceCode;
    }

    if (!Util.isUnset(request.invoiceNo)) {
      body["invoiceNo"] = request.invoiceNo;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
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
    let params = new $OpenApi.Params({
      action: "UpdateInvoiceAndReceiptRelated",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/approvalReceipts`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceAndReceiptRelatedResponse>(await this.execute(params, req, runtime), new UpdateInvoiceAndReceiptRelatedResponse({}));
  }

  async updateInvoiceAndReceiptRelated(request: UpdateInvoiceAndReceiptRelatedRequest): Promise<UpdateInvoiceAndReceiptRelatedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAndReceiptRelatedHeaders({ });
    return await this.updateInvoiceAndReceiptRelatedWithOptions(request, headers, runtime);
  }

  async updateInvoiceIgnoreStatusWithOptions(request: UpdateInvoiceIgnoreStatusRequest, headers: UpdateInvoiceIgnoreStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceIgnoreStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instanceId)) {
      query["instanceId"] = request.instanceId;
    }

    if (!Util.isUnset(request.operator)) {
      query["operator"] = request.operator;
    }

    if (!Util.isUnset(request.status)) {
      query["status"] = request.status;
    }

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
      action: "UpdateInvoiceIgnoreStatus",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/ignoreStatus`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceIgnoreStatusResponse>(await this.execute(params, req, runtime), new UpdateInvoiceIgnoreStatusResponse({}));
  }

  async updateInvoiceIgnoreStatus(request: UpdateInvoiceIgnoreStatusRequest): Promise<UpdateInvoiceIgnoreStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceIgnoreStatusHeaders({ });
    return await this.updateInvoiceIgnoreStatusWithOptions(request, headers, runtime);
  }

  async updateInvoiceVerifyStatusWithOptions(request: UpdateInvoiceVerifyStatusRequest, headers: UpdateInvoiceVerifyStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceVerifyStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

    if (!Util.isUnset(request.deductStatus)) {
      body["deductStatus"] = request.deductStatus;
    }

    if (!Util.isUnset(request.generalInvoiceVOList)) {
      body["generalInvoiceVOList"] = request.generalInvoiceVOList;
    }

    if (!Util.isUnset(request.invoiceKeyVOList)) {
      body["invoiceKeyVOList"] = request.invoiceKeyVOList;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
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
    let params = new $OpenApi.Params({
      action: "UpdateInvoiceVerifyStatus",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/verifyStatus`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceVerifyStatusResponse>(await this.execute(params, req, runtime), new UpdateInvoiceVerifyStatusResponse({}));
  }

  async updateInvoiceVerifyStatus(request: UpdateInvoiceVerifyStatusRequest): Promise<UpdateInvoiceVerifyStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceVerifyStatusHeaders({ });
    return await this.updateInvoiceVerifyStatusWithOptions(request, headers, runtime);
  }

  async updateInvoiceVoucherStatusWithOptions(request: UpdateInvoiceVoucherStatusRequest, headers: UpdateInvoiceVoucherStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceVoucherStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountantBookId)) {
      body["accountantBookId"] = request.accountantBookId;
    }

    if (!Util.isUnset(request.actionType)) {
      body["actionType"] = request.actionType;
    }

    if (!Util.isUnset(request.invoiceCode)) {
      body["invoiceCode"] = request.invoiceCode;
    }

    if (!Util.isUnset(request.invoiceNo)) {
      body["invoiceNo"] = request.invoiceNo;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.voucherId)) {
      body["voucherId"] = request.voucherId;
    }

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
      action: "UpdateInvoiceVoucherStatus",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/invoices/vouchers/states`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceVoucherStatusResponse>(await this.execute(params, req, runtime), new UpdateInvoiceVoucherStatusResponse({}));
  }

  async updateInvoiceVoucherStatus(request: UpdateInvoiceVoucherStatusRequest): Promise<UpdateInvoiceVoucherStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceVoucherStatusHeaders({ });
    return await this.updateInvoiceVoucherStatusWithOptions(request, headers, runtime);
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
    let params = new $OpenApi.Params({
      action: "UpdateReceipt",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/receipts`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateReceiptResponse>(await this.execute(params, req, runtime), new UpdateReceiptResponse({}));
  }

  async updateReceipt(request: UpdateReceiptRequest): Promise<UpdateReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateReceiptHeaders({ });
    return await this.updateReceiptWithOptions(request, headers, runtime);
  }

  async updateReceiptVoucherStatusWithOptions(request: UpdateReceiptVoucherStatusRequest, headers: UpdateReceiptVoucherStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateReceiptVoucherStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountPeriod)) {
      body["accountPeriod"] = request.accountPeriod;
    }

    if (!Util.isUnset(request.actionType)) {
      body["actionType"] = request.actionType;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.receiptId)) {
      body["receiptId"] = request.receiptId;
    }

    if (!Util.isUnset(request.voucherCode)) {
      body["voucherCode"] = request.voucherCode;
    }

    if (!Util.isUnset(request.voucherId)) {
      body["voucherId"] = request.voucherId;
    }

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
      action: "UpdateReceiptVoucherStatus",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/vouchers/recepits`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateReceiptVoucherStatusResponse>(await this.execute(params, req, runtime), new UpdateReceiptVoucherStatusResponse({}));
  }

  async updateReceiptVoucherStatus(request: UpdateReceiptVoucherStatusRequest): Promise<UpdateReceiptVoucherStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateReceiptVoucherStatusHeaders({ });
    return await this.updateReceiptVoucherStatusWithOptions(request, headers, runtime);
  }

}
