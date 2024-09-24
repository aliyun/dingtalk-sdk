// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class RoleMemberMapValue extends $tea.Model {
  roleCode?: string;
  memberList?: RoleMemberMapValueMemberList[];
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  static names(): { [key: string]: string } {
    return {
      roleCode: 'roleCode',
      memberList: 'memberList',
      companyCode: 'companyCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      roleCode: 'string',
      memberList: { 'type': 'array', 'itemType': RoleMemberMapValueMemberList },
      companyCode: 'string',
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
  /**
   * @example
   * 5041234
   */
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
  /**
   * @example
   * 5041234
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AppendRolePermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  generalInvoiceVOList?: BatchAddInvoiceRequestGeneralInvoiceVOList[];
  /**
   * @example
   * abc
   */
  operator?: string;
  /**
   * @example
   * XXX
   */
  orderId?: string;
  /**
   * @example
   * APPROVAL
   */
  source?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      generalInvoiceVOList: 'generalInvoiceVOList',
      operator: 'operator',
      orderId: 'orderId',
      source: 'source',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      generalInvoiceVOList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOList },
      operator: 'string',
      orderId: 'string',
      source: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchAddInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 55001121
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchCreateCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class BeginConsumeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BeginConsumeRequest extends $tea.Model {
  /**
   * @example
   * B_SF2_INVOICE_OCR
   */
  benefitCode?: string;
  /**
   * @example
   * XXX
   */
  bizRequestId?: string;
  quota?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
      bizRequestId: 'bizRequestId',
      quota: 'quota',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
      bizRequestId: 'string',
      quota: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BeginConsumeResponseBody extends $tea.Model {
  result?: BeginConsumeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BeginConsumeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BeginConsumeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BeginConsumeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: BeginConsumeResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc
   */
  accountantBookId?: string;
  /**
   * @example
   * COM_DEFAULT
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BindCompanyAccountantBookResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class CancelConsumeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelConsumeRequest extends $tea.Model {
  /**
   * @example
   * B_SF2_INVOICE_OCR
   */
  benefitCode?: string;
  /**
   * @example
   * XXX
   */
  bizRequestId?: string;
  /**
   * @example
   * 1
   */
  quota?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
      bizRequestId: 'bizRequestId',
      quota: 'quota',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
      bizRequestId: 'string',
      quota: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelConsumeResponseBody extends $tea.Model {
  result?: CancelConsumeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CancelConsumeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelConsumeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CancelConsumeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CancelConsumeResponseBody,
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
  /**
   * @example
   * COM_DEFUALT
   */
  companyCode?: string;
  /**
   * @example
   * 1631526550994
   */
  endTime?: number;
  /**
   * @example
   * VAT_IN
   */
  financeType?: string;
  /**
   * @example
   * 3121234560
   */
  invoiceCode?: string;
  /**
   * @example
   * 1234567890
   */
  invoiceNo?: string;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 100
   */
  pageSize?: number;
  /**
   * @example
   * 1631526550994
   */
  startTime?: number;
  /**
   * @example
   * 12345678901
   */
  taxNo?: string;
  /**
   * @example
   * VERIFIED
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckVoucherStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class CommitConsumeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitConsumeRequest extends $tea.Model {
  /**
   * @example
   * B_SF2_INVOICE_OCR
   */
  benefitCode?: string;
  bizRequestId?: string;
  /**
   * @example
   * 1
   */
  quota?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
      bizRequestId: 'bizRequestId',
      quota: 'quota',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
      bizRequestId: 'string',
      quota: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitConsumeResponseBody extends $tea.Model {
  result?: CommitConsumeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CommitConsumeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitConsumeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CommitConsumeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CommitConsumeResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 55001121
   */
  creator?: string;
  /**
   * @example
   * abc
   */
  description?: string;
  /**
   * @example
   * www.abc.com
   */
  drawerEmail?: string;
  /**
   * @example
   * 12345678901
   */
  drawerTelephone?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  name?: string;
  /**
   * @example
   * abc
   */
  purchaserAccount?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  /**
   * @example
   * 建行
   */
  purchaserBankName?: string;
  /**
   * @example
   * 李四
   */
  purchaserName?: string;
  /**
   * @example
   * 1333
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 13333333333
   */
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
  /**
   * @example
   * CUS_xxxxxx
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetBookkeepingUserListResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CUS_XXXX
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

export class GetCustomerResponseBody extends $tea.Model {
  accountantBookIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CUS_XXXX
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCustomerResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class GetFormTemplateInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormTemplateInfoResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  receiptFormTemplateInfoList?: GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList[];
  static names(): { [key: string]: string } {
    return {
      receiptFormTemplateInfoList: 'receiptFormTemplateInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receiptFormTemplateInfoList: { 'type': 'array', 'itemType': GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormTemplateInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFormTemplateInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: GetFormTemplateInfoResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInvoiceByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetIsNewVersionResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * 钉钉
   */
  companyName?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @example
   * valid
   */
  status?: string;
  /**
   * @example
   * generalTaxpayer
   */
  taxNature?: string;
  /**
   * @example
   * 123456789012345
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMultiCompanyInfoByCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PROD-xxx
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

export class GetProductResponseBody extends $tea.Model {
  accountantBookIdList?: string[];
  /**
   * @example
   * PROD-xxx
   */
  code?: string;
  /**
   * @example
   * 1634786828686
   */
  createTime?: number;
  /**
   * @example
   * 和外部合作
   */
  description?: string;
  information?: string;
  /**
   * @example
   * 外包商品
   */
  name?: string;
  /**
   * @example
   * 规格型号
   */
  specification?: string;
  /**
   * @example
   * valid
   */
  status?: string;
  /**
   * @example
   * 个
   */
  unit?: string;
  userDefineCode?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookIdList: 'accountantBookIdList',
      code: 'code',
      createTime: 'createTime',
      description: 'description',
      information: 'information',
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
      information: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProductResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 50411123322
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

export class GetYongYouOpenApiTokenResponseBody extends $tea.Model {
  /**
   * @example
   * abc
   */
  accessToken?: string;
  /**
   * @example
   * accounting
   */
  appName?: string;
  /**
   * @example
   * 518400
   */
  expiresIn?: string;
  /**
   * @example
   * 2512799
   */
  refreshExpiresIn?: string;
  /**
   * @example
   * abc
   */
  refreshToken?: string;
  /**
   * @example
   * auth_all
   */
  scope?: string;
  /**
   * @example
   * abc
   */
  sid?: string;
  /**
   * @example
   * 123615862385832922
   */
  yongyouOrgId?: string;
  /**
   * @example
   * 391733693750254232
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetYongYouOpenApiTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * 20230731
   */
  chanjetCorpId?: string;
  /**
   * @example
   * 01162352501424064728
   */
  chanjetUserId?: string;
  /**
   * @example
   * ding9f50b15bccd16741
   */
  corpId?: string;
  /**
   * @example
   * 01162352501424064728
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetYongYouOrgRelationResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * SF_INVOICE
   */
  benefitCode?: string;
  /**
   * @example
   * 1234567890
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ProfessionBenefitConsumeResponseBody;
  static names(): { [key: string]: string } {
    return {
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

export class PushHistoricalReceiptsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushHistoricalReceiptsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizId?: string;
  endTime?: number;
  forcedIgnoreDup?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  formCodeList?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      endTime: 'endTime',
      forcedIgnoreDup: 'forcedIgnoreDup',
      formCodeList: 'formCodeList',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      endTime: 'number',
      forcedIgnoreDup: 'boolean',
      formCodeList: { 'type': 'array', 'itemType': 'string' },
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushHistoricalReceiptsResponseBody extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushHistoricalReceiptsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PushHistoricalReceiptsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PushHistoricalReceiptsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitRequest extends $tea.Model {
  /**
   * @example
   * B_SF2_INVOICE_CHECK_V2
   */
  benefitCode?: string;
  static names(): { [key: string]: string } {
    return {
      benefitCode: 'benefitCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      benefitCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitResponseBody extends $tea.Model {
  result?: QueryBenefitResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryBenefitResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBenefitResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBenefitResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryBenefitResponseBody,
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
  /**
   * @example
   * COM_DEFAULT
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCompanyInvoiceRelationCountResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 20
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

export class QueryCustomerInfoResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  list?: QueryCustomerInfoResponseBodyList[];
  /**
   * @example
   * 500
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCustomerInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryFinanceCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryInvoiceRelationCountResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMultiCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @remarks
   * This parameter is required.
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

export class QueryPermissionByUserIdResponseBody extends $tea.Model {
  companyCode?: string;
  permissionDTOList?: QueryPermissionByUserIdResponseBodyPermissionDTOList[];
  /**
   * @example
   * 123456789
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      permissionDTOList: 'permissionDTOList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      permissionDTOList: { 'type': 'array', 'itemType': QueryPermissionByUserIdResponseBodyPermissionDTOList },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPermissionByUserIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryPermissionByUserIdResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  roleCodeList?: string[];
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      roleCodeList: 'roleCodeList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryPermissionRoleMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryProductByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abcdefghijklmnopq
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryReceiptDetailForInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
  accountantBookId?: string;
  applyStatusList?: string[];
  bizStatusList?: string[];
  /**
   * @example
   * COM_DEFAULT
   */
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
  /**
   * @example
   * true
   */
  hasMore?: string;
  list?: QueryReceiptForInvoiceResponseBodyList[];
  /**
   * @example
   * 500
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryReceiptForInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
  accountantBookId?: string;
  amountEnd?: number;
  amountStart?: number;
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * 16000000
   */
  endTime?: number;
  /**
   * @example
   * 1
   */
  pageNumber?: number;
  /**
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @example
   * 16000000
   */
  startTime?: number;
  timeFilterField?: string;
  /**
   * @example
   * 收款单
   */
  title?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      amountEnd: 'amountEnd',
      amountStart: 'amountStart',
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
      amountEnd: 'number',
      amountStart: 'number',
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
  /**
   * @example
   * true
   */
  hasMore?: string;
  list?: QueryReceiptsBaseInfoResponseBodyList[];
  /**
   * @example
   * 500
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryReceiptsBaseInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * 1637658261363
   */
  endTime?: number;
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
   * 1637658261363
   */
  startTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * gmt_create
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  hasMore?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryReceiptsByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * 20
   */
  maxResults?: string;
  /**
   * @example
   * 0
   */
  nextToken?: string;
  /**
   * @example
   * financeManager
   */
  roleCode?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      roleCode: 'roleCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRoleMemberByPageResponseBody;
  static names(): { [key: string]: string } {
    return {
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
   * 12312231231
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

export class QueryUserRoleListResponseBody extends $tea.Model {
  financeEmpDeptOpenList?: QueryUserRoleListResponseBodyFinanceEmpDeptOpenList[];
  roleVOList?: QueryUserRoleListResponseBodyRoleVOList[];
  static names(): { [key: string]: string } {
    return {
      financeEmpDeptOpenList: 'financeEmpDeptOpenList',
      roleVOList: 'roleVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UnbindApplyReceiptAndInvoiceRelatedResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateApplyReceiptAndInvoiceRelatedResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * zhejiang
   */
  location?: string;
  /**
   * @example
   * 1234567
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateDigitalInvoiceOrgInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  taxOrInvoiceHasInit?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      companyName: 'companyName',
      taxNature: 'taxNature',
      taxNo: 'taxNo',
      taxOrInvoiceHasInit: 'taxOrInvoiceHasInit',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyName: 'string',
      taxNature: 'string',
      taxNo: 'string',
      taxOrInvoiceHasInit: 'boolean',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateFinanceCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉
   */
  companyName?: string;
  /**
   * @example
   * generalTaxpayer
   */
  taxNature?: string;
  /**
   * @example
   * 123456789012345
   */
  taxNo?: string;
  taxOrInvoiceHasInit?: boolean;
  /**
   * @example
   * 123
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      companyCode: 'companyCode',
      companyName: 'companyName',
      taxNature: 'taxNature',
      taxNo: 'taxNo',
      taxOrInvoiceHasInit: 'taxOrInvoiceHasInit',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      companyCode: 'string',
      companyName: 'string',
      taxNature: 'string',
      taxNo: 'string',
      taxOrInvoiceHasInit: 'boolean',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateFinanceMultiCompanyInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * abc
   */
  operator?: string;
  redGeneralInvoiceVO?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVO;
  redInvoiceCode?: string;
  /**
   * @example
   * abc
   */
  redInvoiceNo?: string;
  /**
   * @example
   * abc
   */
  redInvoiceStatus?: string;
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceAbandonStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
  accountPeriod?: string;
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  generalInvoiceVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOList[];
  invoiceKeyVOList?: UpdateInvoiceAccountPeriodRequestInvoiceKeyVOList[];
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceAccountPeriodResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  invoiceFinanceInfoVOList?: UpdateInvoiceAccountingPeriodDateRequestInvoiceFinanceInfoVOList[];
  /**
   * @example
   * 1234567
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceAccountingPeriodDateResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  invoiceFinanceInfoVOList?: UpdateInvoiceAccountingStatusRequestInvoiceFinanceInfoVOList[];
  /**
   * @example
   * 1234567
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceAccountingStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * code
   */
  invoiceCode?: string;
  /**
   * @example
   * 155
   */
  invoiceNo?: string;
  /**
   * @example
   * abc
   */
  operator?: string;
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceAndReceiptRelatedResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
  instanceId?: string;
  /**
   * @example
   * abc
   */
  operator?: string;
  /**
   * @example
   * IGNORE
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceIgnoreStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * DEDUCTED
   */
  deductStatus?: string;
  generalInvoiceVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOList[];
  invoiceKeyVOList?: UpdateInvoiceVerifyStatusRequestInvoiceKeyVOList[];
  /**
   * @example
   * abc
   */
  operator?: string;
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceVerifyStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * 123
   */
  accountantBookId?: string;
  /**
   * @example
   * ADD/DELETE
   */
  actionType?: string;
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
  invoiceNo?: string;
  /**
   * @example
   * 11011023488
   */
  operator?: string;
  /**
   * @example
   * abc
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInvoiceVoucherStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateReceiptResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
  accountPeriod?: string;
  /**
   * @example
   * add
   */
  actionType?: string;
  /**
   * @example
   * 0021241
   */
  operatorId?: string;
  /**
   * @example
   * abc
   */
  receiptId?: string;
  /**
   * @example
   * abc
   */
  voucherCode?: string;
  /**
   * @example
   * abc
   */
  voucherId?: string;
  /**
   * @example
   * 记-001
   */
  voucherNo?: string;
  static names(): { [key: string]: string } {
    return {
      accountPeriod: 'accountPeriod',
      actionType: 'actionType',
      operatorId: 'operatorId',
      receiptId: 'receiptId',
      voucherCode: 'voucherCode',
      voucherId: 'voucherId',
      voucherNo: 'voucherNo',
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
      voucherNo: 'string',
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateReceiptVoucherStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
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
  /**
   * @example
   * abc
   */
  userId?: string;
  /**
   * @example
   * 小明
   */
  nick?: string;
  /**
   * @example
   * https://xxxxxxx
   */
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
  /**
   * @example
   * /invoice
   */
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
  /**
   * @example
   * financeManager
   */
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
  /**
   * @example
   * abc
   */
  accountPeriod?: string;
  /**
   * @example
   * 100
   */
  amount?: string;
  /**
   * @example
   * 120
   */
  amountWithTax?: string;
  /**
   * @example
   * 1111
   */
  checkCode?: string;
  /**
   * @example
   * 2010-12-12
   */
  checkTime?: string;
  /**
   * @example
   * 张三
   */
  drawerName?: string;
  /**
   * @example
   * 2022-12-10
   */
  drewDate?: string;
  /**
   * @example
   * abc
   */
  electronicUrl?: string;
  fileId?: string;
  /**
   * @example
   * INPUT_VAT
   */
  financeType?: string;
  /**
   * @example
   * RED
   */
  fundType?: string;
  generalInvoiceDetailVOList?: BatchAddInvoiceRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  /**
   * @example
   * http://XXX.jpg
   */
  imageUrl?: string;
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
  invoiceNo?: string;
  /**
   * @example
   * abc
   */
  invoiceStatus?: string;
  /**
   * @example
   * INTPUT_VAT
   */
  invoiceType?: string;
  /**
   * @example
   * 1111
   */
  machineCode?: string;
  /**
   * @example
   * abc
   */
  oilFlag?: string;
  /**
   * @example
   * abc
   */
  payee?: string;
  /**
   * @example
   * abc
   */
  processInstCode?: string;
  /**
   * @example
   * abc
   */
  processInstType?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  /**
   * @example
   * 建行
   */
  purchaserBankNameAccount?: string;
  /**
   * @example
   * 张三
   */
  purchaserName?: string;
  /**
   * @example
   * 155655
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 1333333333
   */
  purchaserTel?: string;
  receiverEmail?: string;
  receiverName?: string;
  receiverTel?: string;
  /**
   * @example
   * abc
   */
  remark?: string;
  reviewer?: string;
  secondHandCarInvoiceDetailList?: BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  /**
   * @example
   * 8852
   */
  sellerAddress?: string;
  sellerBankAccount?: string;
  /**
   * @example
   * 招商银行
   */
  sellerBankNameAccount?: string;
  /**
   * @example
   * 李四
   */
  sellerName?: string;
  /**
   * @example
   * 2202
   */
  sellerTaxNo?: string;
  /**
   * @example
   * 13355222222
   */
  sellerTel?: string;
  spaceId?: string;
  /**
   * @example
   * abc
   */
  supplySign?: string;
  /**
   * @example
   * 20
   */
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: BatchAddInvoiceRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: BatchAddInvoiceRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
  /**
   * @example
   * abc
   */
  verifyStatus?: string;
  /**
   * @example
   * abc
   */
  voucherCode?: string;
  /**
   * @example
   * abc
   */
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
      fileId: 'fileId',
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
      receiverEmail: 'receiverEmail',
      receiverName: 'receiverName',
      receiverTel: 'receiverTel',
      remark: 'remark',
      reviewer: 'reviewer',
      secondHandCarInvoiceDetailList: 'secondHandCarInvoiceDetailList',
      sellerAddress: 'sellerAddress',
      sellerBankAccount: 'sellerBankAccount',
      sellerBankNameAccount: 'sellerBankNameAccount',
      sellerName: 'sellerName',
      sellerTaxNo: 'sellerTaxNo',
      sellerTel: 'sellerTel',
      spaceId: 'spaceId',
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
      fileId: 'string',
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
      receiverEmail: 'string',
      receiverName: 'string',
      receiverTel: 'string',
      remark: 'string',
      reviewer: 'string',
      secondHandCarInvoiceDetailList: { 'type': 'array', 'itemType': BatchAddInvoiceRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList },
      sellerAddress: 'string',
      sellerBankAccount: 'string',
      sellerBankNameAccount: 'string',
      sellerName: 'string',
      sellerTaxNo: 'string',
      sellerTel: 'string',
      spaceId: 'string',
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
  /**
   * @example
   * abc
   */
  errorKey?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * abc
   */
  description?: string;
  /**
   * @example
   * www.abc.com
   */
  drawerEmail?: string;
  /**
   * @example
   * 1234567890
   */
  drawerTelephone?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  name?: string;
  /**
   * @example
   * abc
   */
  purchaserAccount?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  /**
   * @example
   * 建行
   */
  purchaserBankName?: string;
  /**
   * @example
   * 李四
   */
  purchaserName?: string;
  /**
   * @example
   * 1333
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 13333333333
   */
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

export class BeginConsumeResponseBodyResult extends $tea.Model {
  isSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccess: 'isSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelConsumeResponseBodyResult extends $tea.Model {
  isSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccess: 'isSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CommitConsumeResponseBodyResult extends $tea.Model {
  isSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      isSuccess: 'isSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateReceiptRequestReceipts extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4.44
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INC_XXX
   */
  categoryCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd_efgh
   */
  code?: string;
  /**
   * @example
   * 1636445218000
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * emp_xxx
   */
  createUserId?: string;
  /**
   * @example
   * CUS_XXX
   */
  customerCode?: string;
  /**
   * @example
   * ACC_XXX
   */
  enterpriseAcountCode?: string;
  /**
   * @example
   * 1636445218000
   */
  occurDate?: number;
  /**
   * @example
   * emp_xxx
   */
  principalId?: string;
  /**
   * @example
   * PROJ_XXX
   */
  projectCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  receiptType?: number;
  /**
   * @example
   * 测试
   */
  remark?: string;
  /**
   * @example
   * SUP_XXX
   */
  supplierCode?: string;
  /**
   * @example
   * 收款单
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcef-efgh-123
   */
  code?: string;
  /**
   * @example
   * success
   */
  errorCode?: string;
  /**
   * @example
   * 成功
   */
  errorMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd_efgh
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * emp_xxx
   */
  deleteUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd_efgh
   */
  code?: string;
  /**
   * @example
   * success
   */
  errorCode?: string;
  /**
   * @example
   * 成功
   */
  errorMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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

export class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList extends $tea.Model {
  /**
   * @example
   * \"100\"
   */
  bindingVal?: string;
  /**
   * @example
   * \"xxx\"
   */
  code?: string;
  /**
   * @example
   * "报销金额"
   */
  name?: string;
  /**
   * @example
   * \"amount\"
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      bindingVal: 'bindingVal',
      code: 'code',
      name: 'name',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindingVal: 'string',
      code: 'string',
      name: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoList extends $tea.Model {
  componentList?: GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList[];
  /**
   * @example
   * "报销套件"
   */
  name?: string;
  /**
   * @example
   * "PROC-EB81447A-B0E3-4A2F-A719-0A85EFD09184"
   */
  processCode?: string;
  /**
   * @example
   * "invalid"
   */
  status?: string;
  suiteId?: string;
  static names(): { [key: string]: string } {
    return {
      componentList: 'componentList',
      name: 'name',
      processCode: 'processCode',
      status: 'status',
      suiteId: 'suiteId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      componentList: { 'type': 'array', 'itemType': GetFormTemplateInfoResponseBodyReceiptFormTemplateInfoListComponentList },
      name: 'string',
      processCode: 'string',
      status: 'string',
      suiteId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInvoiceByPageRequestRequest extends $tea.Model {
  /**
   * @example
   * abc
   */
  accountantBookId?: string;
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * abc
   */
  endTime?: number;
  /**
   * @example
   * abc
   */
  financeType?: string;
  /**
   * @example
   * 2
   */
  pageNumber?: number;
  /**
   * @example
   * 1
   */
  pageSize?: number;
  /**
   * @example
   * 2022-07-11
   */
  startTime?: number;
  /**
   * @example
   * 1111111111
   */
  taxNo?: string;
  /**
   * @example
   * ABC
   */
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
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * relateedInvoice
   */
  advancedSettingKey?: string;
  /**
   * @example
   * 关联发票
   */
  advancedSettingName?: string;
  /**
   * @example
   * 123456789
   */
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

export class QueryBenefitResponseBodyResult extends $tea.Model {
  remainQuota?: number;
  totalQuota?: number;
  static names(): { [key: string]: string } {
    return {
      remainQuota: 'remainQuota',
      totalQuota: 'totalQuota',
    };
  }

  static types(): { [key: string]: any } {
    return {
      remainQuota: 'number',
      totalQuota: 'number',
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

export class QueryCustomerInfoResponseBodyList extends $tea.Model {
  /**
   * @example
   * CUS_xxxxxxxx
   */
  code?: string;
  contactAddress?: string;
  contactCompanyTelephone?: string;
  contactEmail?: string;
  contactName?: string;
  contactTelephone?: string;
  /**
   * @example
   * abc
   */
  description?: string;
  /**
   * @example
   * www.abc.com
   */
  drawerEmail?: string;
  /**
   * @example
   * 12345678901
   */
  drawerTelephone?: string;
  /**
   * @example
   * 张三
   */
  name?: string;
  /**
   * @example
   * abc
   */
  purchaserAccount?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  /**
   * @example
   * abc
   */
  purchaserName?: string;
  /**
   * @example
   * 123
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 13333333333
   */
  purchaserTel?: string;
  /**
   * @example
   * 建行
   */
  purchaserrBankName?: string;
  /**
   * @example
   * valid
   */
  status?: string;
  /**
   * @example
   * 199200
   */
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

export class QueryMultiCompanyInfoResponseBodyListAdvancedSettingList extends $tea.Model {
  /**
   * @example
   * relatedInvoice
   */
  advancedSettingKey?: string;
  /**
   * @example
   * 关联发票
   */
  advancedSettingName?: string;
  /**
   * @example
   * 123456789
   */
  endDate?: number;
  valid?: boolean;
  value?: boolean;
  static names(): { [key: string]: string } {
    return {
      advancedSettingKey: 'advancedSettingKey',
      advancedSettingName: 'advancedSettingName',
      endDate: 'endDate',
      valid: 'valid',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      advancedSettingKey: 'string',
      advancedSettingName: 'string',
      endDate: 'number',
      valid: 'boolean',
      value: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMultiCompanyInfoResponseBodyList extends $tea.Model {
  advancedSettingList?: QueryMultiCompanyInfoResponseBodyListAdvancedSettingList[];
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * 钉钉
   */
  companyName?: string;
  /**
   * @example
   * 123456789
   */
  createTime?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @example
   * valid
   */
  status?: string;
  /**
   * @example
   * generalTaxpayer
   */
  taxNature?: string;
  /**
   * @example
   * 123456789012345
   */
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
  information?: string;
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
      information: 'information',
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
      information: 'string',
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

export class QueryReceiptDetailForInvoiceResponseBodyResultCreator extends $tea.Model {
  /**
   * @example
   * https://xxxx
   */
  avatarUrl?: string;
  /**
   * @example
   * 测试名字
   */
  nick?: string;
  /**
   * @example
   * 1231
   */
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
  /**
   * @example
   * CUS_xxxxx
   */
  code?: string;
  /**
   * @example
   * 李四
   */
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
  /**
   * @example
   * 12.3
   */
  amountWithTax?: string;
  /**
   * @example
   * 100
   */
  amountWithoutTax?: string;
  /**
   * @example
   * 10
   */
  discountAmount?: string;
  /**
   * @example
   * 鱼
   */
  name?: string;
  /**
   * @example
   * 2
   */
  quantity?: string;
  /**
   * @example
   * 大型
   */
  specification?: string;
  /**
   * @example
   * XXX
   */
  taxClassificationCode?: string;
  /**
   * @example
   * 0.3
   */
  taxRate?: string;
  /**
   * @example
   * 千克
   */
  unit?: string;
  /**
   * @example
   * 12.3
   */
  unitPriceWithTax?: string;
  /**
   * @example
   * 100
   */
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
      taxClassificationCode: 'taxClassificationCode',
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
      taxClassificationCode: 'string',
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
  /**
   * @example
   * abc
   */
  accountantBookId?: string;
  /**
   * @example
   * 4000
   */
  amount?: string;
  /**
   * @example
   * applied
   */
  applyStatus?: string;
  /**
   * @example
   * invoicing
   */
  bizStatus?: string;
  /**
   * @example
   * 123
   */
  businessId?: string;
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * 123000
   */
  createTime?: string;
  creator?: QueryReceiptDetailForInvoiceResponseBodyResultCreator;
  customer?: QueryReceiptDetailForInvoiceResponseBodyResultCustomer;
  /**
   * @example
   * www.abc.com
   */
  drawerEmail?: string;
  /**
   * @example
   * 12345678901
   */
  drawerTelephone?: string;
  /**
   * @example
   * VAT_NORMAL_E
   */
  invoiceType?: string;
  /**
   * @example
   * EM-xxxxx
   */
  modelId?: string;
  productInfoList?: QueryReceiptDetailForInvoiceResponseBodyResultProductInfoList[];
  /**
   * @example
   * 32131131231
   */
  purchaserAccount?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  /**
   * @example
   * 工商银行XX支行
   */
  purchaserBankName?: string;
  /**
   * @example
   * 钉有限公司
   */
  purchaserName?: string;
  /**
   * @example
   * 123456
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 12345678901
   */
  purchaserTel?: string;
  /**
   * @example
   * abc
   */
  receiptId?: string;
  /**
   * @example
   * 16000000
   */
  recordTime?: string;
  /**
   * @example
   * 备注信息
   */
  remark?: string;
  /**
   * @example
   * approval
   */
  source?: string;
  /**
   * @example
   * agree
   */
  status?: string;
  /**
   * @example
   * 张三提交的开票申请单
   */
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
  /**
   * @example
   * https://xxxx
   */
  avatarUrl?: string;
  /**
   * @example
   * 测试名字
   */
  nick?: string;
  /**
   * @example
   * 1231
   */
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
  /**
   * @example
   * CUS_xxxxx
   */
  code?: string;
  /**
   * @example
   * 李四
   */
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
  /**
   * @example
   * 12.3
   */
  amountWithTax?: string;
  /**
   * @example
   * 100
   */
  amountWithoutTax?: string;
  /**
   * @example
   * 10
   */
  discountAmount?: string;
  /**
   * @example
   * 鱼
   */
  name?: string;
  /**
   * @example
   * 2
   */
  quantity?: string;
  /**
   * @example
   * 大型
   */
  specification?: string;
  /**
   * @example
   * XXX
   */
  taxClassificationCode?: string;
  /**
   * @example
   * 0.3
   */
  taxRate?: string;
  /**
   * @example
   * 千克
   */
  unit?: string;
  /**
   * @example
   * 12.3
   */
  unitPriceWithTax?: string;
  /**
   * @example
   * 100
   */
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
      taxClassificationCode: 'taxClassificationCode',
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
      taxClassificationCode: 'string',
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
  /**
   * @example
   * abc
   */
  accountantBookId?: string;
  /**
   * @example
   * 5000
   */
  amount?: string;
  /**
   * @example
   * applied
   */
  applyStatus?: string;
  /**
   * @example
   * invoicing
   */
  bizStatus?: string;
  /**
   * @example
   * 123
   */
  businessId?: string;
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  createTime?: string;
  creator?: QueryReceiptForInvoiceResponseBodyListCreator;
  customer?: QueryReceiptForInvoiceResponseBodyListCustomer;
  /**
   * @example
   * www.abc.com
   */
  drawerEmail?: string;
  /**
   * @example
   * 12345678901
   */
  drawerTelephone?: string;
  /**
   * @example
   * 增值税发票
   */
  invoiceType?: string;
  /**
   * @example
   * EM-xxxxx
   */
  modelId?: string;
  productInfoList?: QueryReceiptForInvoiceResponseBodyListProductInfoList[];
  /**
   * @example
   * abc
   */
  purchaserAccount?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  /**
   * @example
   * 建设银行
   */
  purchaserBankName?: string;
  /**
   * @example
   * 钉有限公司
   */
  purchaserName?: string;
  /**
   * @example
   * 123456
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 13333333333
   */
  purchaserTel?: string;
  /**
   * @example
   * abc
   */
  receiptId?: string;
  /**
   * @example
   * 16000000
   */
  recordTime?: string;
  /**
   * @example
   * 备注信息
   */
  remark?: string;
  /**
   * @example
   * approval
   */
  source?: string;
  /**
   * @example
   * agree
   */
  status?: string;
  /**
   * @example
   * 张三提交的开票申请单
   */
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
  /**
   * @example
   * https://xxxx
   */
  avatarUrl?: string;
  /**
   * @example
   * 测试名字
   */
  nick?: string;
  /**
   * @example
   * 1231
   */
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
  /**
   * @example
   * CUS_xxxxx
   */
  code?: string;
  /**
   * @example
   * 李四
   */
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
  /**
   * @example
   * abc
   */
  accountantBookId?: string;
  /**
   * @example
   * 5000
   */
  amount?: string;
  /**
   * @example
   * 1714973165000
   */
  approvedAt?: string;
  /**
   * @example
   * 123
   */
  businessId?: string;
  /**
   * @example
   * COM_DEFAULT
   */
  companyCode?: string;
  /**
   * @example
   * 1714973165000
   */
  createTime?: string;
  creator?: QueryReceiptsBaseInfoResponseBodyListCreator;
  customer?: QueryReceiptsBaseInfoResponseBodyListCustomer;
  /**
   * @example
   * https://abc.com
   */
  instanceJumpUrl?: string;
  /**
   * @example
   * EM-xxxxx
   */
  modelId?: string;
  principal?: QueryReceiptsBaseInfoResponseBodyListPrincipal;
  project?: QueryReceiptsBaseInfoResponseBodyListProject;
  /**
   * @example
   * abc
   */
  receiptId?: string;
  /**
   * @example
   * 16000000
   */
  recordTime?: string;
  /**
   * @example
   * 备注信息
   */
  remark?: string;
  /**
   * @example
   * approval
   */
  source?: string;
  /**
   * @example
   * agree
   */
  status?: string;
  supplier?: QueryReceiptsBaseInfoResponseBodyListSupplier;
  /**
   * @example
   * 张三提交的开票申请单
   */
  title?: string;
  voucherStatus?: string;
  static names(): { [key: string]: string } {
    return {
      accountantBookId: 'accountantBookId',
      amount: 'amount',
      approvedAt: 'approvedAt',
      businessId: 'businessId',
      companyCode: 'companyCode',
      createTime: 'createTime',
      creator: 'creator',
      customer: 'customer',
      instanceJumpUrl: 'instanceJumpUrl',
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
      approvedAt: 'string',
      businessId: 'string',
      companyCode: 'string',
      createTime: 'string',
      creator: QueryReceiptsBaseInfoResponseBodyListCreator,
      customer: QueryReceiptsBaseInfoResponseBodyListCustomer,
      instanceJumpUrl: 'string',
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

export class UnbindApplyReceiptAndInvoiceRelatedRequestInvoiceKeyVOList extends $tea.Model {
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * abc
   */
  accountPeriod?: string;
  /**
   * @example
   * 100
   */
  amount?: string;
  /**
   * @example
   * 120
   */
  amountWithTax?: string;
  /**
   * @example
   * 1111
   */
  checkCode?: string;
  /**
   * @example
   * 2010-12-12
   */
  checkTime?: string;
  /**
   * @example
   * 张三
   */
  drawerName?: string;
  /**
   * @example
   * 2022-12-10
   */
  drewDate?: string;
  /**
   * @example
   * abc
   */
  electronicUrl?: string;
  /**
   * @example
   * INPUT_VAT
   */
  financeType?: string;
  /**
   * @example
   * RED
   */
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  /**
   * @example
   * http://XXX.jpg
   */
  imageUrl?: string;
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
  invoiceNo?: string;
  /**
   * @example
   * abc
   */
  invoiceStatus?: string;
  /**
   * @example
   * INTPUT_VAT
   */
  invoiceType?: string;
  /**
   * @example
   * 1111
   */
  machineCode?: string;
  /**
   * @example
   * abc
   */
  oilFlag?: string;
  /**
   * @example
   * abc
   */
  payee?: string;
  /**
   * @example
   * abc
   */
  processInstCode?: string;
  /**
   * @example
   * abc
   */
  processInstType?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  /**
   * @example
   * 建行
   */
  purchaserBankNameAccount?: string;
  /**
   * @example
   * 张三
   */
  purchaserName?: string;
  /**
   * @example
   * 155655
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 1333333333
   */
  purchaserTel?: string;
  receiverEmail?: string;
  receiverName?: string;
  receiverTel?: string;
  /**
   * @example
   * abc
   */
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  /**
   * @example
   * 8852
   */
  sellerAddress?: string;
  sellerBankAccount?: string;
  /**
   * @example
   * 招商银行
   */
  sellerBankNameAccount?: string;
  /**
   * @example
   * 李四
   */
  sellerName?: string;
  /**
   * @example
   * 2202
   */
  sellerTaxNo?: string;
  /**
   * @example
   * 13355222222
   */
  sellerTel?: string;
  /**
   * @example
   * abc
   */
  supplySign?: string;
  /**
   * @example
   * 20
   */
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateApplyReceiptAndInvoiceRelatedRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
  /**
   * @example
   * abc
   */
  verifyStatus?: string;
  /**
   * @example
   * abc
   */
  voucherCode?: string;
  /**
   * @example
   * abc
   */
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
      receiverEmail: 'receiverEmail',
      receiverName: 'receiverName',
      receiverTel: 'receiverTel',
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
      receiverEmail: 'string',
      receiverName: 'string',
      receiverTel: 'string',
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
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 111
   */
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
  /**
   * @example
   * 张三
   */
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOGeneralInvoiceDetailVOList[];
  /**
   * @example
   * http://XXX.jpg
   */
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
  /**
   * @example
   * 111
   */
  purchaserBankAccount?: string;
  /**
   * @example
   * 111
   */
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAbandonStatusRequestBlueGeneralInvoiceVOSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  /**
   * @example
   * 111
   */
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
  /**
   * @example
   * 111
   */
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
  /**
   * @example
   * 111
   */
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
  /**
   * @example
   * 张三
   */
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  financeType?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOGeneralInvoiceDetailVOList[];
  /**
   * @example
   * http://XXX.jpg
   */
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
  /**
   * @example
   * aaa
   */
  purchaserBankAccount?: string;
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAbandonStatusRequestRedGeneralInvoiceVOSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  /**
   * @example
   * 111
   */
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
  /**
   * @example
   * abc
   */
  accountPeriod?: string;
  /**
   * @example
   * 100
   */
  amount?: string;
  /**
   * @example
   * 120
   */
  amountWithTax?: string;
  /**
   * @example
   * 1111
   */
  checkCode?: string;
  /**
   * @example
   * 2010-12-12
   */
  checkTime?: string;
  /**
   * @example
   * 张三
   */
  drawerName?: string;
  /**
   * @example
   * 2022-12-10
   */
  drewDate?: string;
  /**
   * @example
   * abc
   */
  electronicUrl?: string;
  /**
   * @example
   * INPUT_VAT
   */
  financeType?: string;
  /**
   * @example
   * RED
   */
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  /**
   * @example
   * http://XXX.jpg
   */
  imageUrl?: string;
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
  invoiceNo?: string;
  /**
   * @example
   * abc
   */
  invoiceStatus?: string;
  /**
   * @example
   * INTPUT_VAT
   */
  invoiceType?: string;
  /**
   * @example
   * 1111
   */
  machineCode?: string;
  /**
   * @example
   * abc
   */
  oilFlag?: string;
  /**
   * @example
   * abc
   */
  payee?: string;
  /**
   * @example
   * abc
   */
  processInstCode?: string;
  /**
   * @example
   * abc
   */
  processInstType?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  /**
   * @example
   * 建行
   */
  purchaserBankNameAccount?: string;
  /**
   * @example
   * 张三
   */
  purchaserName?: string;
  /**
   * @example
   * 155655
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 1333333333
   */
  purchaserTel?: string;
  /**
   * @example
   * abc
   */
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  /**
   * @example
   * 8852
   */
  sellerAddress?: string;
  sellerBankAccount?: string;
  /**
   * @example
   * 招商银行
   */
  sellerBankNameAccount?: string;
  /**
   * @example
   * 李四
   */
  sellerName?: string;
  /**
   * @example
   * 2202
   */
  sellerTaxNo?: string;
  /**
   * @example
   * 13355222222
   */
  sellerTel?: string;
  /**
   * @example
   * abc
   */
  supplySign?: string;
  /**
   * @example
   * 20
   */
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateInvoiceAccountPeriodRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
  /**
   * @example
   * abc
   */
  verifyStatus?: string;
  /**
   * @example
   * abc
   */
  voucherCode?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * 1001
   */
  invoiceCode?: string;
  /**
   * @example
   * 2202
   */
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
  /**
   * @example
   * abc
   */
  errorKey?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * 2022-02-03
   */
  accountingPeriodData?: string;
  /**
   * @example
   * 2202020
   */
  invoiceCode?: string;
  /**
   * @example
   * 220200200
   */
  invoiceNo?: string;
  /**
   * @example
   * VAT_DIGITAL_NORMAL
   */
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
  /**
   * @example
   * 50001
   */
  errorCode?: string;
  /**
   * @example
   * invoice not exist
   */
  errorMsg?: string;
  /**
   * @example
   * 1231231231
   */
  invoiceCode?: string;
  /**
   * @example
   * 1231231231
   */
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
  /**
   * @example
   * 100
   */
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
  /**
   * @example
   * in_account
   */
  accountingStatus?: string;
  /**
   * @example
   * 2022002022
   */
  invoiceCode?: string;
  /**
   * @example
   * 20022
   */
  invoiceNo?: string;
  /**
   * @example
   * VAT_DIGITAL_NORMAL
   */
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
  /**
   * @example
   * 50001
   */
  errorCode?: string;
  /**
   * @example
   * invoice not exist
   */
  errorMsg?: string;
  /**
   * @example
   * 123123123
   */
  invoiceCode?: string;
  /**
   * @example
   * 123123123123
   */
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
  /**
   * @example
   * 100
   */
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
  /**
   * @example
   * 北京国际机场
   */
  carrier?: string;
  /**
   * @example
   * AA1234
   */
  flightNumber?: string;
  /**
   * @example
   * 2023-05-11
   */
  flyDate?: string;
  /**
   * @example
   * 杭州
   */
  flyFrom?: string;
  /**
   * @example
   * 16:00
   */
  flyTime?: string;
  /**
   * @example
   * 北京
   */
  flyTo?: string;
  /**
   * @example
   * 头等舱
   */
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
  /**
   * @example
   * 1
   */
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
  /**
   * @example
   * 123
   */
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
  /**
   * @example
   * ABC
   */
  agentCode?: string;
  amount?: string;
  amountWithTax?: string;
  /**
   * @example
   * 123
   */
  caacDevelopmentFund?: string;
  checkCode?: string;
  checkTime?: string;
  /**
   * @example
   * 杭州
   */
  city?: string;
  /**
   * @example
   * 北京
   */
  destination?: string;
  /**
   * @example
   * 123KM
   */
  distance?: string;
  /**
   * @example
   * 张三
   */
  drawerName?: string;
  drewDate?: string;
  electronicUrl?: string;
  /**
   * @example
   * 杭州北
   */
  entrance?: string;
  /**
   * @example
   * 杭州北
   */
  exit?: string;
  financeType?: string;
  flightItineraryDetails?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOFlightItineraryDetails[];
  /**
   * @example
   * 123
   */
  fuelSurcharge?: string;
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOGeneralInvoiceDetailVOList[];
  /**
   * @example
   * 18:00
   */
  getOffTime?: string;
  /**
   * @example
   * 17:00
   */
  getOnTime?: string;
  /**
   * @example
   * http://XXX.jpg
   */
  imageUrl?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: string;
  invoiceType?: string;
  /**
   * @example
   * ABCD
   */
  issueBy?: string;
  machineCode?: string;
  oilFlag?: string;
  /**
   * @example
   * 杭州
   */
  origin?: string;
  /**
   * @example
   * 张三
   */
  passenger?: string;
  /**
   * @example
   * 330781****1234
   */
  passengerUserId?: string;
  payee?: string;
  /**
   * @example
   * 123
   */
  printSerialNumber?: string;
  processInstCode?: string;
  processInstType?: string;
  purchaserAddress?: string;
  /**
   * @example
   * abc
   */
  purchaserBankAccount?: string;
  /**
   * @example
   * abc
   */
  purchaserBankNameAccount?: string;
  purchaserName?: string;
  purchaserTaxNo?: string;
  purchaserTel?: string;
  /**
   * @example
   * abc@test.com
   */
  receiverEmail?: string;
  /**
   * @example
   * 张三
   */
  receiverName?: string;
  /**
   * @example
   * 1234567809
   */
  receiverTel?: string;
  remark?: string;
  /**
   * @example
   * 2023-09-01
   */
  seatClass?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceAndReceiptRelatedRequestGeneralInvoiceVOSecondHandCarInvoiceDetailList[];
  sellerAddress?: string;
  /**
   * @example
   * abc
   */
  sellerBankAccount?: string;
  /**
   * @example
   * abc
   */
  sellerBankNameAccount?: string;
  sellerName?: string;
  sellerTaxNo?: string;
  sellerTel?: string;
  /**
   * @example
   * 杭州
   */
  serialNo?: string;
  /**
   * @example
   * 杭州
   */
  startTime?: string;
  supplySign?: string;
  /**
   * @example
   * 123
   */
  surcharge?: string;
  taxAmount?: string;
  /**
   * @example
   * G1234
   */
  trainNo?: string;
  /**
   * @example
   * 2023-09-01
   */
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
      receiverEmail: 'receiverEmail',
      receiverName: 'receiverName',
      receiverTel: 'receiverTel',
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
      receiverEmail: 'string',
      receiverName: 'string',
      receiverTel: 'string',
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
  /**
   * @example
   * abc
   */
  accountPeriod?: string;
  /**
   * @example
   * 100
   */
  amount?: string;
  /**
   * @example
   * 120
   */
  amountWithTax?: string;
  /**
   * @example
   * 1111
   */
  checkCode?: string;
  /**
   * @example
   * 2010-12-12
   */
  checkTime?: string;
  /**
   * @example
   * 张三
   */
  drawerName?: string;
  /**
   * @example
   * 2022-12-10
   */
  drewDate?: string;
  /**
   * @example
   * abc
   */
  electronicUrl?: string;
  /**
   * @example
   * INPUT_VAT
   */
  financeType?: string;
  /**
   * @example
   * RED
   */
  fundType?: string;
  generalInvoiceDetailVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListGeneralInvoiceDetailVOList[];
  /**
   * @example
   * http://XXX.jpg
   */
  imageUrl?: string;
  /**
   * @example
   * abc
   */
  invoiceCode?: string;
  /**
   * @example
   * abc
   */
  invoiceNo?: string;
  /**
   * @example
   * abc
   */
  invoiceStatus?: string;
  /**
   * @example
   * INTPUT_VAT
   */
  invoiceType?: string;
  /**
   * @example
   * 1111
   */
  machineCode?: string;
  /**
   * @example
   * abc
   */
  oilFlag?: string;
  /**
   * @example
   * abc
   */
  payee?: string;
  /**
   * @example
   * abc
   */
  processInstCode?: string;
  /**
   * @example
   * abc
   */
  processInstType?: string;
  /**
   * @example
   * 杭州市
   */
  purchaserAddress?: string;
  purchaserBankAccount?: string;
  /**
   * @example
   * 建行
   */
  purchaserBankNameAccount?: string;
  /**
   * @example
   * 张三
   */
  purchaserName?: string;
  /**
   * @example
   * 155655
   */
  purchaserTaxNo?: string;
  /**
   * @example
   * 1333333333
   */
  purchaserTel?: string;
  /**
   * @example
   * abc
   */
  remark?: string;
  secondHandCarInvoiceDetailList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListSecondHandCarInvoiceDetailList[];
  /**
   * @example
   * 8852
   */
  sellerAddress?: string;
  sellerBankAccount?: string;
  /**
   * @example
   * 招商银行
   */
  sellerBankNameAccount?: string;
  /**
   * @example
   * 李四
   */
  sellerName?: string;
  /**
   * @example
   * 2202
   */
  sellerTaxNo?: string;
  /**
   * @example
   * 13355222222
   */
  sellerTel?: string;
  /**
   * @example
   * abc
   */
  supplySign?: string;
  /**
   * @example
   * 20
   */
  taxAmount?: string;
  usedVehicleSaleDetailVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListUsedVehicleSaleDetailVOList[];
  vehicleSaleDetailVOList?: UpdateInvoiceVerifyStatusRequestGeneralInvoiceVOListVehicleSaleDetailVOList[];
  /**
   * @example
   * abc
   */
  verifyStatus?: string;
  /**
   * @example
   * abc
   */
  voucherCode?: string;
  /**
   * @example
   * abc
   */
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
  /**
   * @example
   * 1001
   */
  invoiceCode?: string;
  /**
   * @example
   * 2202
   */
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
  /**
   * @example
   * 2.44
   */
  amount?: string;
  /**
   * @example
   * INC_XXX
   */
  categoryCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd_efgh
   */
  code?: string;
  /**
   * @example
   * CUS_XXX
   */
  customerCode?: string;
  /**
   * @example
   * ACC_XXX
   */
  enterpriseAcountCode?: string;
  /**
   * @example
   * 1636445218000
   */
  occurDate?: number;
  /**
   * @example
   * emp_xxx
   */
  principalId?: string;
  /**
   * @example
   * PROJ_XXX
   */
  projectCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  receiptType?: number;
  /**
   * @example
   * 测试单据
   */
  remark?: string;
  /**
   * @example
   * SUP_XXX
   */
  supplierCode?: string;
  /**
   * @example
   * 付款单
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1636445218000
   */
  updateTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * emp_xxx
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcd_efgh_1234
   */
  code?: string;
  /**
   * @example
   * success
   */
  errorCode?: string;
  /**
   * @example
   * 成功
   */
  errorMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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
   * 追加角色权限点
   * 
   * @param tmpReq - AppendRolePermissionRequest
   * @param headers - AppendRolePermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AppendRolePermissionResponse
   */
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

  /**
   * 追加角色权限点
   * 
   * @param request - AppendRolePermissionRequest
   * @returns AppendRolePermissionResponse
   */
  async appendRolePermission(request: AppendRolePermissionRequest): Promise<AppendRolePermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AppendRolePermissionHeaders({ });
    return await this.appendRolePermissionWithOptions(request, headers, runtime);
  }

  /**
   * 发票数据批量写入
   * 
   * @param request - BatchAddInvoiceRequest
   * @param headers - BatchAddInvoiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchAddInvoiceResponse
   */
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

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
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

  /**
   * 发票数据批量写入
   * 
   * @param request - BatchAddInvoiceRequest
   * @returns BatchAddInvoiceResponse
   */
  async batchAddInvoice(request: BatchAddInvoiceRequest): Promise<BatchAddInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchAddInvoiceHeaders({ });
    return await this.batchAddInvoiceWithOptions(request, headers, runtime);
  }

  /**
   * 批量增加用户信息
   * 
   * @param request - BatchCreateCustomerRequest
   * @param headers - BatchCreateCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchCreateCustomerResponse
   */
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

  /**
   * 批量增加用户信息
   * 
   * @param request - BatchCreateCustomerRequest
   * @returns BatchCreateCustomerResponse
   */
  async batchCreateCustomer(request: BatchCreateCustomerRequest): Promise<BatchCreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchCreateCustomerHeaders({ });
    return await this.batchCreateCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 预核销智能财务的权益
   * 
   * @param request - BeginConsumeRequest
   * @param headers - BeginConsumeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BeginConsumeResponse
   */
  async beginConsumeWithOptions(request: BeginConsumeRequest, headers: BeginConsumeHeaders, runtime: $Util.RuntimeOptions): Promise<BeginConsumeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      query["benefitCode"] = request.benefitCode;
    }

    if (!Util.isUnset(request.bizRequestId)) {
      query["bizRequestId"] = request.bizRequestId;
    }

    if (!Util.isUnset(request.quota)) {
      query["quota"] = request.quota;
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
      action: "BeginConsume",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/consumedBenefits/prepare`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BeginConsumeResponse>(await this.execute(params, req, runtime), new BeginConsumeResponse({}));
  }

  /**
   * 预核销智能财务的权益
   * 
   * @param request - BeginConsumeRequest
   * @returns BeginConsumeResponse
   */
  async beginConsume(request: BeginConsumeRequest): Promise<BeginConsumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BeginConsumeHeaders({ });
    return await this.beginConsumeWithOptions(request, headers, runtime);
  }

  /**
   * 绑定钉钉智能财务企业主体的账套信息
   * 
   * @param request - BindCompanyAccountantBookRequest
   * @param headers - BindCompanyAccountantBookHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BindCompanyAccountantBookResponse
   */
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

  /**
   * 绑定钉钉智能财务企业主体的账套信息
   * 
   * @param request - BindCompanyAccountantBookRequest
   * @returns BindCompanyAccountantBookResponse
   */
  async bindCompanyAccountantBook(request: BindCompanyAccountantBookRequest): Promise<BindCompanyAccountantBookResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BindCompanyAccountantBookHeaders({ });
    return await this.bindCompanyAccountantBookWithOptions(request, headers, runtime);
  }

  /**
   * 取消核销智能财务的权益
   * 
   * @param request - CancelConsumeRequest
   * @param headers - CancelConsumeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CancelConsumeResponse
   */
  async cancelConsumeWithOptions(request: CancelConsumeRequest, headers: CancelConsumeHeaders, runtime: $Util.RuntimeOptions): Promise<CancelConsumeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      query["benefitCode"] = request.benefitCode;
    }

    if (!Util.isUnset(request.bizRequestId)) {
      query["bizRequestId"] = request.bizRequestId;
    }

    if (!Util.isUnset(request.quota)) {
      query["quota"] = request.quota;
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
      action: "CancelConsume",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/consumedBenefits/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CancelConsumeResponse>(await this.execute(params, req, runtime), new CancelConsumeResponse({}));
  }

  /**
   * 取消核销智能财务的权益
   * 
   * @param request - CancelConsumeRequest
   * @returns CancelConsumeResponse
   */
  async cancelConsume(request: CancelConsumeRequest): Promise<CancelConsumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelConsumeHeaders({ });
    return await this.cancelConsumeWithOptions(request, headers, runtime);
  }

  /**
   * 查验发票是否生成凭证
   * 
   * @param request - CheckVoucherStatusRequest
   * @param headers - CheckVoucherStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckVoucherStatusResponse
   */
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

  /**
   * 查验发票是否生成凭证
   * 
   * @param request - CheckVoucherStatusRequest
   * @returns CheckVoucherStatusResponse
   */
  async checkVoucherStatus(request: CheckVoucherStatusRequest): Promise<CheckVoucherStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckVoucherStatusHeaders({ });
    return await this.checkVoucherStatusWithOptions(request, headers, runtime);
  }

  /**
   * 确认核销智能财务的权益
   * 
   * @param request - CommitConsumeRequest
   * @param headers - CommitConsumeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CommitConsumeResponse
   */
  async commitConsumeWithOptions(request: CommitConsumeRequest, headers: CommitConsumeHeaders, runtime: $Util.RuntimeOptions): Promise<CommitConsumeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      query["benefitCode"] = request.benefitCode;
    }

    if (!Util.isUnset(request.bizRequestId)) {
      query["bizRequestId"] = request.bizRequestId;
    }

    if (!Util.isUnset(request.quota)) {
      query["quota"] = request.quota;
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
      action: "CommitConsume",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/consumedBenefits/commit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CommitConsumeResponse>(await this.execute(params, req, runtime), new CommitConsumeResponse({}));
  }

  /**
   * 确认核销智能财务的权益
   * 
   * @param request - CommitConsumeRequest
   * @returns CommitConsumeResponse
   */
  async commitConsume(request: CommitConsumeRequest): Promise<CommitConsumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CommitConsumeHeaders({ });
    return await this.commitConsumeWithOptions(request, headers, runtime);
  }

  /**
   * 创建智能财务的客户信息
   * 
   * @param request - CreateCustomerRequest
   * @param headers - CreateCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateCustomerResponse
   */
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

  /**
   * 创建智能财务的客户信息
   * 
   * @param request - CreateCustomerRequest
   * @returns CreateCustomerResponse
   */
  async createCustomer(request: CreateCustomerRequest): Promise<CreateCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCustomerHeaders({ });
    return await this.createCustomerWithOptions(request, headers, runtime);
  }

  /**
   * 创建智能财务单据
   * 
   * @param request - CreateReceiptRequest
   * @param headers - CreateReceiptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateReceiptResponse
   */
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

  /**
   * 创建智能财务单据
   * 
   * @param request - CreateReceiptRequest
   * @returns CreateReceiptResponse
   */
  async createReceipt(request: CreateReceiptRequest): Promise<CreateReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateReceiptHeaders({ });
    return await this.createReceiptWithOptions(request, headers, runtime);
  }

  /**
   * 删除智能财务单据
   * 
   * @param request - DeleteReceiptRequest
   * @param headers - DeleteReceiptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteReceiptResponse
   */
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

  /**
   * 删除智能财务单据
   * 
   * @param request - DeleteReceiptRequest
   * @returns DeleteReceiptResponse
   */
  async deleteReceipt(request: DeleteReceiptRequest): Promise<DeleteReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteReceiptHeaders({ });
    return await this.deleteReceiptWithOptions(request, headers, runtime);
  }

  /**
   * 获取可以查看账本的用户列表
   * 
   * @param headers - GetBookkeepingUserListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetBookkeepingUserListResponse
   */
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

  /**
   * 获取可以查看账本的用户列表
   * @returns GetBookkeepingUserListResponse
   */
  async getBookkeepingUserList(): Promise<GetBookkeepingUserListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBookkeepingUserListHeaders({ });
    return await this.getBookkeepingUserListWithOptions(headers, runtime);
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
   * 获取智能财务应用内维护的客户信息
   * 
   * @param request - GetCustomerRequest
   * @param headers - GetCustomerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCustomerResponse
   */
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

  /**
   * 获取智能财务应用内维护的客户信息
   * 
   * @param request - GetCustomerRequest
   * @returns GetCustomerResponse
   */
  async getCustomer(request: GetCustomerRequest): Promise<GetCustomerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCustomerHeaders({ });
    return await this.getCustomerWithOptions(request, headers, runtime);
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
   * 获取智能财务套件模版信息
   * 
   * @param headers - GetFormTemplateInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFormTemplateInfoResponse
   */
  async getFormTemplateInfoWithOptions(headers: GetFormTemplateInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFormTemplateInfoResponse> {
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
      action: "GetFormTemplateInfo",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/formTemplates/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFormTemplateInfoResponse>(await this.execute(params, req, runtime), new GetFormTemplateInfoResponse({}));
  }

  /**
   * 获取智能财务套件模版信息
   * @returns GetFormTemplateInfoResponse
   */
  async getFormTemplateInfo(): Promise<GetFormTemplateInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFormTemplateInfoHeaders({ });
    return await this.getFormTemplateInfoWithOptions(headers, runtime);
  }

  /**
   * 发票分页查询接口
   * 
   * @param tmpReq - GetInvoiceByPageRequest
   * @param headers - GetInvoiceByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInvoiceByPageResponse
   */
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

  /**
   * 发票分页查询接口
   * 
   * @param request - GetInvoiceByPageRequest
   * @returns GetInvoiceByPageResponse
   */
  async getInvoiceByPage(request: GetInvoiceByPageRequest): Promise<GetInvoiceByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInvoiceByPageHeaders({ });
    return await this.getInvoiceByPageWithOptions(request, headers, runtime);
  }

  /**
   * 用来给isv提供是否使用智能账本的判断接口
   * 
   * @param headers - GetIsNewVersionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetIsNewVersionResponse
   */
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

  /**
   * 用来给isv提供是否使用智能账本的判断接口
   * @returns GetIsNewVersionResponse
   */
  async getIsNewVersion(): Promise<GetIsNewVersionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIsNewVersionHeaders({ });
    return await this.getIsNewVersionWithOptions(headers, runtime);
  }

  /**
   * 根据comanyCode查询钉钉智能财务多主体信息
   * 
   * @param headers - GetMultiCompanyInfoByCodeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMultiCompanyInfoByCodeResponse
   */
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

  /**
   * 根据comanyCode查询钉钉智能财务多主体信息
   * @returns GetMultiCompanyInfoByCodeResponse
   */
  async getMultiCompanyInfoByCode(companyCode: string): Promise<GetMultiCompanyInfoByCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMultiCompanyInfoByCodeHeaders({ });
    return await this.getMultiCompanyInfoByCodeWithOptions(companyCode, headers, runtime);
  }

  /**
   * 获取商品信息
   * 
   * @param request - GetProductRequest
   * @param headers - GetProductHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProductResponse
   */
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

  /**
   * 获取商品信息
   * 
   * @param request - GetProductRequest
   * @returns GetProductResponse
   */
  async getProduct(request: GetProductRequest): Promise<GetProductResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProductHeaders({ });
    return await this.getProductWithOptions(request, headers, runtime);
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
   * 获取用友开放平台接口鉴权信息
   * 
   * @param request - GetYongYouOpenApiTokenRequest
   * @param headers - GetYongYouOpenApiTokenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetYongYouOpenApiTokenResponse
   */
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

  /**
   * 获取用友开放平台接口鉴权信息
   * 
   * @param request - GetYongYouOpenApiTokenRequest
   * @returns GetYongYouOpenApiTokenResponse
   */
  async getYongYouOpenApiToken(request: GetYongYouOpenApiTokenRequest): Promise<GetYongYouOpenApiTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetYongYouOpenApiTokenHeaders({ });
    return await this.getYongYouOpenApiTokenWithOptions(request, headers, runtime);
  }

  /**
   * 查询钉钉组织绑定的畅捷通组织
   * 
   * @param headers - GetYongYouOrgRelationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetYongYouOrgRelationResponse
   */
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

  /**
   * 查询钉钉组织绑定的畅捷通组织
   * @returns GetYongYouOrgRelationResponse
   */
  async getYongYouOrgRelation(): Promise<GetYongYouOrgRelationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetYongYouOrgRelationHeaders({ });
    return await this.getYongYouOrgRelationWithOptions(headers, runtime);
  }

  /**
   * 权益核销
   * 
   * @param request - ProfessionBenefitConsumeRequest
   * @param headers - ProfessionBenefitConsumeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ProfessionBenefitConsumeResponse
   */
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

  /**
   * 权益核销
   * 
   * @param request - ProfessionBenefitConsumeRequest
   * @returns ProfessionBenefitConsumeResponse
   */
  async professionBenefitConsume(request: ProfessionBenefitConsumeRequest): Promise<ProfessionBenefitConsumeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProfessionBenefitConsumeHeaders({ });
    return await this.professionBenefitConsumeWithOptions(request, headers, runtime);
  }

  /**
   * 触发单据同步给有成
   * 
   * @param request - PushHistoricalReceiptsRequest
   * @param headers - PushHistoricalReceiptsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PushHistoricalReceiptsResponse
   */
  async pushHistoricalReceiptsWithOptions(request: PushHistoricalReceiptsRequest, headers: PushHistoricalReceiptsHeaders, runtime: $Util.RuntimeOptions): Promise<PushHistoricalReceiptsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.endTime)) {
      body["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.forcedIgnoreDup)) {
      body["forcedIgnoreDup"] = request.forcedIgnoreDup;
    }

    if (!Util.isUnset(request.formCodeList)) {
      body["formCodeList"] = request.formCodeList;
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
      action: "PushHistoricalReceipts",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/budgets/historicalReceipts/push`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushHistoricalReceiptsResponse>(await this.execute(params, req, runtime), new PushHistoricalReceiptsResponse({}));
  }

  /**
   * 触发单据同步给有成
   * 
   * @param request - PushHistoricalReceiptsRequest
   * @returns PushHistoricalReceiptsResponse
   */
  async pushHistoricalReceipts(request: PushHistoricalReceiptsRequest): Promise<PushHistoricalReceiptsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushHistoricalReceiptsHeaders({ });
    return await this.pushHistoricalReceiptsWithOptions(request, headers, runtime);
  }

  /**
   * 查询智能财务计量型权益
   * 
   * @param request - QueryBenefitRequest
   * @param headers - QueryBenefitHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBenefitResponse
   */
  async queryBenefitWithOptions(request: QueryBenefitRequest, headers: QueryBenefitHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBenefitResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.benefitCode)) {
      query["benefitCode"] = request.benefitCode;
    }

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
      action: "QueryBenefit",
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/benefits`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBenefitResponse>(await this.execute(params, req, runtime), new QueryBenefitResponse({}));
  }

  /**
   * 查询智能财务计量型权益
   * 
   * @param request - QueryBenefitRequest
   * @returns QueryBenefitResponse
   */
  async queryBenefit(request: QueryBenefitRequest): Promise<QueryBenefitResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBenefitHeaders({ });
    return await this.queryBenefitWithOptions(request, headers, runtime);
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
      version: "bizfinance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bizfinance/categories/list`,
      method: "GET",
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
   * 查询某个主体的开票申请单的提单数量
   * 
   * @param request - QueryCompanyInvoiceRelationCountRequest
   * @param headers - QueryCompanyInvoiceRelationCountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCompanyInvoiceRelationCountResponse
   */
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

  /**
   * 查询某个主体的开票申请单的提单数量
   * 
   * @param request - QueryCompanyInvoiceRelationCountRequest
   * @returns QueryCompanyInvoiceRelationCountResponse
   */
  async queryCompanyInvoiceRelationCount(request: QueryCompanyInvoiceRelationCountRequest): Promise<QueryCompanyInvoiceRelationCountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCompanyInvoiceRelationCountHeaders({ });
    return await this.queryCompanyInvoiceRelationCountWithOptions(request, headers, runtime);
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
   * 提供给合作伙伴，查询智能财务的客户配置信息
   * 
   * @param request - QueryCustomerInfoRequest
   * @param headers - QueryCustomerInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCustomerInfoResponse
   */
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

  /**
   * 提供给合作伙伴，查询智能财务的客户配置信息
   * 
   * @param request - QueryCustomerInfoRequest
   * @returns QueryCustomerInfoResponse
   */
  async queryCustomerInfo(request: QueryCustomerInfoRequest): Promise<QueryCustomerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerInfoHeaders({ });
    return await this.queryCustomerInfoWithOptions(request, headers, runtime);
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
   * 查询智能财务配置的企业信息
   * 
   * @param headers - QueryFinanceCompanyInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryFinanceCompanyInfoResponse
   */
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

  /**
   * 查询智能财务配置的企业信息
   * @returns QueryFinanceCompanyInfoResponse
   */
  async queryFinanceCompanyInfo(): Promise<QueryFinanceCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFinanceCompanyInfoHeaders({ });
    return await this.queryFinanceCompanyInfoWithOptions(headers, runtime);
  }

  /**
   * 查询开票申请单的提单数量
   * 
   * @param headers - QueryInvoiceRelationCountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryInvoiceRelationCountResponse
   */
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

  /**
   * 查询开票申请单的提单数量
   * @returns QueryInvoiceRelationCountResponse
   */
  async queryInvoiceRelationCount(): Promise<QueryInvoiceRelationCountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInvoiceRelationCountHeaders({ });
    return await this.queryInvoiceRelationCountWithOptions(headers, runtime);
  }

  /**
   * 查询钉钉智能财务多主体信息
   * 
   * @param headers - QueryMultiCompanyInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMultiCompanyInfoResponse
   */
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

  /**
   * 查询钉钉智能财务多主体信息
   * @returns QueryMultiCompanyInfoResponse
   */
  async queryMultiCompanyInfo(): Promise<QueryMultiCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMultiCompanyInfoHeaders({ });
    return await this.queryMultiCompanyInfoWithOptions(headers, runtime);
  }

  /**
   * 提供给小望，查询当前用户所具有的的小望权限点信息
   * 
   * @param request - QueryPermissionByUserIdRequest
   * @param headers - QueryPermissionByUserIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryPermissionByUserIdResponse
   */
  async queryPermissionByUserIdWithOptions(request: QueryPermissionByUserIdRequest, headers: QueryPermissionByUserIdHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPermissionByUserIdResponse> {
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

  /**
   * 提供给小望，查询当前用户所具有的的小望权限点信息
   * 
   * @param request - QueryPermissionByUserIdRequest
   * @returns QueryPermissionByUserIdResponse
   */
  async queryPermissionByUserId(request: QueryPermissionByUserIdRequest): Promise<QueryPermissionByUserIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPermissionByUserIdHeaders({ });
    return await this.queryPermissionByUserIdWithOptions(request, headers, runtime);
  }

  /**
   * 查询智能财务角色下的成员信息
   * 
   * @param request - QueryPermissionRoleMemberRequest
   * @param headers - QueryPermissionRoleMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryPermissionRoleMemberResponse
   */
  async queryPermissionRoleMemberWithOptions(request: QueryPermissionRoleMemberRequest, headers: QueryPermissionRoleMemberHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPermissionRoleMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      body["companyCode"] = request.companyCode;
    }

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

  /**
   * 查询智能财务角色下的成员信息
   * 
   * @param request - QueryPermissionRoleMemberRequest
   * @returns QueryPermissionRoleMemberResponse
   */
  async queryPermissionRoleMember(request: QueryPermissionRoleMemberRequest): Promise<QueryPermissionRoleMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPermissionRoleMemberHeaders({ });
    return await this.queryPermissionRoleMemberWithOptions(request, headers, runtime);
  }

  /**
   * 批量获取商品信息
   * 
   * @param request - QueryProductByPageRequest
   * @param headers - QueryProductByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryProductByPageResponse
   */
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

  /**
   * 批量获取商品信息
   * 
   * @param request - QueryProductByPageRequest
   * @returns QueryProductByPageResponse
   */
  async queryProductByPage(request: QueryProductByPageRequest): Promise<QueryProductByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryProductByPageHeaders({ });
    return await this.queryProductByPageWithOptions(request, headers, runtime);
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
   * 查询开票申请单详情
   * 
   * @param request - QueryReceiptDetailForInvoiceRequest
   * @param headers - QueryReceiptDetailForInvoiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryReceiptDetailForInvoiceResponse
   */
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

  /**
   * 查询开票申请单详情
   * 
   * @param request - QueryReceiptDetailForInvoiceRequest
   * @returns QueryReceiptDetailForInvoiceResponse
   */
  async queryReceiptDetailForInvoice(request: QueryReceiptDetailForInvoiceRequest): Promise<QueryReceiptDetailForInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptDetailForInvoiceHeaders({ });
    return await this.queryReceiptDetailForInvoiceWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询智能财务单据主数据信息
   * 
   * @param request - QueryReceiptForInvoiceRequest
   * @param headers - QueryReceiptForInvoiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryReceiptForInvoiceResponse
   */
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

  /**
   * 批量查询智能财务单据主数据信息
   * 
   * @param request - QueryReceiptForInvoiceRequest
   * @returns QueryReceiptForInvoiceResponse
   */
  async queryReceiptForInvoice(request: QueryReceiptForInvoiceRequest): Promise<QueryReceiptForInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptForInvoiceHeaders({ });
    return await this.queryReceiptForInvoiceWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询智能财务的单据主数据基本信息
   * 
   * @param request - QueryReceiptsBaseInfoRequest
   * @param headers - QueryReceiptsBaseInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryReceiptsBaseInfoResponse
   */
  async queryReceiptsBaseInfoWithOptions(request: QueryReceiptsBaseInfoRequest, headers: QueryReceiptsBaseInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryReceiptsBaseInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountantBookId)) {
      query["accountantBookId"] = request.accountantBookId;
    }

    if (!Util.isUnset(request.amountEnd)) {
      query["amountEnd"] = request.amountEnd;
    }

    if (!Util.isUnset(request.amountStart)) {
      query["amountStart"] = request.amountStart;
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

  /**
   * 批量查询智能财务的单据主数据基本信息
   * 
   * @param request - QueryReceiptsBaseInfoRequest
   * @returns QueryReceiptsBaseInfoResponse
   */
  async queryReceiptsBaseInfo(request: QueryReceiptsBaseInfoRequest): Promise<QueryReceiptsBaseInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptsBaseInfoHeaders({ });
    return await this.queryReceiptsBaseInfoWithOptions(request, headers, runtime);
  }

  /**
   * 分页获取智能财务单据详情列表
   * 
   * @param request - QueryReceiptsByPageRequest
   * @param headers - QueryReceiptsByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryReceiptsByPageResponse
   */
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

  /**
   * 分页获取智能财务单据详情列表
   * 
   * @param request - QueryReceiptsByPageRequest
   * @returns QueryReceiptsByPageResponse
   */
  async queryReceiptsByPage(request: QueryReceiptsByPageRequest): Promise<QueryReceiptsByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryReceiptsByPageHeaders({ });
    return await this.queryReceiptsByPageWithOptions(request, headers, runtime);
  }

  /**
   * 分页查询智能财务角色下的成员信息
   * 
   * @param request - QueryRoleMemberByPageRequest
   * @param headers - QueryRoleMemberByPageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRoleMemberByPageResponse
   */
  async queryRoleMemberByPageWithOptions(request: QueryRoleMemberByPageRequest, headers: QueryRoleMemberByPageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRoleMemberByPageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.companyCode)) {
      query["companyCode"] = request.companyCode;
    }

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

  /**
   * 分页查询智能财务角色下的成员信息
   * 
   * @param request - QueryRoleMemberByPageRequest
   * @returns QueryRoleMemberByPageResponse
   */
  async queryRoleMemberByPage(request: QueryRoleMemberByPageRequest): Promise<QueryRoleMemberByPageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRoleMemberByPageHeaders({ });
    return await this.queryRoleMemberByPageWithOptions(request, headers, runtime);
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
   * 查询用户角色
   * 
   * @param request - QueryUserRoleListRequest
   * @param headers - QueryUserRoleListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUserRoleListResponse
   */
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

  /**
   * 查询用户角色
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
   * 解绑开票申请单关联的发票
   * 
   * @param request - UnbindApplyReceiptAndInvoiceRelatedRequest
   * @param headers - UnbindApplyReceiptAndInvoiceRelatedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UnbindApplyReceiptAndInvoiceRelatedResponse
   */
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

  /**
   * 解绑开票申请单关联的发票
   * 
   * @param request - UnbindApplyReceiptAndInvoiceRelatedRequest
   * @returns UnbindApplyReceiptAndInvoiceRelatedResponse
   */
  async unbindApplyReceiptAndInvoiceRelated(request: UnbindApplyReceiptAndInvoiceRelatedRequest): Promise<UnbindApplyReceiptAndInvoiceRelatedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders({ });
    return await this.unbindApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
  }

  /**
   * 开票申请单关联发票
   * 
   * @param request - UpdateApplyReceiptAndInvoiceRelatedRequest
   * @param headers - UpdateApplyReceiptAndInvoiceRelatedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateApplyReceiptAndInvoiceRelatedResponse
   */
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

  /**
   * 开票申请单关联发票
   * 
   * @param request - UpdateApplyReceiptAndInvoiceRelatedRequest
   * @returns UpdateApplyReceiptAndInvoiceRelatedResponse
   */
  async updateApplyReceiptAndInvoiceRelated(request: UpdateApplyReceiptAndInvoiceRelatedRequest): Promise<UpdateApplyReceiptAndInvoiceRelatedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders({ });
    return await this.updateApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
  }

  /**
   * 更新全电发票企业信息
   * 
   * @param request - UpdateDigitalInvoiceOrgInfoRequest
   * @param headers - UpdateDigitalInvoiceOrgInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateDigitalInvoiceOrgInfoResponse
   */
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

  /**
   * 更新全电发票企业信息
   * 
   * @param request - UpdateDigitalInvoiceOrgInfoRequest
   * @returns UpdateDigitalInvoiceOrgInfoResponse
   */
  async updateDigitalInvoiceOrgInfo(request: UpdateDigitalInvoiceOrgInfoRequest): Promise<UpdateDigitalInvoiceOrgInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateDigitalInvoiceOrgInfoHeaders({ });
    return await this.updateDigitalInvoiceOrgInfoWithOptions(request, headers, runtime);
  }

  /**
   * 更新智能财务配置的企业信息
   * 
   * @param request - UpdateFinanceCompanyInfoRequest
   * @param headers - UpdateFinanceCompanyInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateFinanceCompanyInfoResponse
   */
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

    if (!Util.isUnset(request.taxOrInvoiceHasInit)) {
      query["taxOrInvoiceHasInit"] = request.taxOrInvoiceHasInit;
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

  /**
   * 更新智能财务配置的企业信息
   * 
   * @param request - UpdateFinanceCompanyInfoRequest
   * @returns UpdateFinanceCompanyInfoResponse
   */
  async updateFinanceCompanyInfo(request: UpdateFinanceCompanyInfoRequest): Promise<UpdateFinanceCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFinanceCompanyInfoHeaders({ });
    return await this.updateFinanceCompanyInfoWithOptions(request, headers, runtime);
  }

  /**
   * 更新钉钉智能财务多主体信息
   * 
   * @param request - UpdateFinanceMultiCompanyInfoRequest
   * @param headers - UpdateFinanceMultiCompanyInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateFinanceMultiCompanyInfoResponse
   */
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

    if (!Util.isUnset(request.taxOrInvoiceHasInit)) {
      query["taxOrInvoiceHasInit"] = request.taxOrInvoiceHasInit;
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

  /**
   * 更新钉钉智能财务多主体信息
   * 
   * @param request - UpdateFinanceMultiCompanyInfoRequest
   * @returns UpdateFinanceMultiCompanyInfoResponse
   */
  async updateFinanceMultiCompanyInfo(request: UpdateFinanceMultiCompanyInfoRequest): Promise<UpdateFinanceMultiCompanyInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateFinanceMultiCompanyInfoHeaders({ });
    return await this.updateFinanceMultiCompanyInfoWithOptions(request, headers, runtime);
  }

  /**
   * 发票红冲/废弃状态变更接口
   * 
   * @param request - UpdateInvoiceAbandonStatusRequest
   * @param headers - UpdateInvoiceAbandonStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceAbandonStatusResponse
   */
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

  /**
   * 发票红冲/废弃状态变更接口
   * 
   * @param request - UpdateInvoiceAbandonStatusRequest
   * @returns UpdateInvoiceAbandonStatusResponse
   */
  async updateInvoiceAbandonStatus(request: UpdateInvoiceAbandonStatusRequest): Promise<UpdateInvoiceAbandonStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAbandonStatusHeaders({ });
    return await this.updateInvoiceAbandonStatusWithOptions(request, headers, runtime);
  }

  /**
   * 更新发票账期状态
   * 
   * @param request - UpdateInvoiceAccountPeriodRequest
   * @param headers - UpdateInvoiceAccountPeriodHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceAccountPeriodResponse
   */
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

  /**
   * 更新发票账期状态
   * 
   * @param request - UpdateInvoiceAccountPeriodRequest
   * @returns UpdateInvoiceAccountPeriodResponse
   */
  async updateInvoiceAccountPeriod(request: UpdateInvoiceAccountPeriodRequest): Promise<UpdateInvoiceAccountPeriodResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAccountPeriodHeaders({ });
    return await this.updateInvoiceAccountPeriodWithOptions(request, headers, runtime);
  }

  /**
   * 更新全电企业入账时间
   * 
   * @param request - UpdateInvoiceAccountingPeriodDateRequest
   * @param headers - UpdateInvoiceAccountingPeriodDateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceAccountingPeriodDateResponse
   */
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

  /**
   * 更新全电企业入账时间
   * 
   * @param request - UpdateInvoiceAccountingPeriodDateRequest
   * @returns UpdateInvoiceAccountingPeriodDateResponse
   */
  async updateInvoiceAccountingPeriodDate(request: UpdateInvoiceAccountingPeriodDateRequest): Promise<UpdateInvoiceAccountingPeriodDateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAccountingPeriodDateHeaders({ });
    return await this.updateInvoiceAccountingPeriodDateWithOptions(request, headers, runtime);
  }

  /**
   * 更新全电企业入账状态
   * 
   * @param request - UpdateInvoiceAccountingStatusRequest
   * @param headers - UpdateInvoiceAccountingStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceAccountingStatusResponse
   */
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

  /**
   * 更新全电企业入账状态
   * 
   * @param request - UpdateInvoiceAccountingStatusRequest
   * @returns UpdateInvoiceAccountingStatusResponse
   */
  async updateInvoiceAccountingStatus(request: UpdateInvoiceAccountingStatusRequest): Promise<UpdateInvoiceAccountingStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAccountingStatusHeaders({ });
    return await this.updateInvoiceAccountingStatusWithOptions(request, headers, runtime);
  }

  /**
   * 更新发票关联审批单
   * 
   * @param request - UpdateInvoiceAndReceiptRelatedRequest
   * @param headers - UpdateInvoiceAndReceiptRelatedHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceAndReceiptRelatedResponse
   */
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

  /**
   * 更新发票关联审批单
   * 
   * @param request - UpdateInvoiceAndReceiptRelatedRequest
   * @returns UpdateInvoiceAndReceiptRelatedResponse
   */
  async updateInvoiceAndReceiptRelated(request: UpdateInvoiceAndReceiptRelatedRequest): Promise<UpdateInvoiceAndReceiptRelatedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceAndReceiptRelatedHeaders({ });
    return await this.updateInvoiceAndReceiptRelatedWithOptions(request, headers, runtime);
  }

  /**
   * 更新发票忽略状态
   * 
   * @param request - UpdateInvoiceIgnoreStatusRequest
   * @param headers - UpdateInvoiceIgnoreStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceIgnoreStatusResponse
   */
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

  /**
   * 更新发票忽略状态
   * 
   * @param request - UpdateInvoiceIgnoreStatusRequest
   * @returns UpdateInvoiceIgnoreStatusResponse
   */
  async updateInvoiceIgnoreStatus(request: UpdateInvoiceIgnoreStatusRequest): Promise<UpdateInvoiceIgnoreStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceIgnoreStatusHeaders({ });
    return await this.updateInvoiceIgnoreStatusWithOptions(request, headers, runtime);
  }

  /**
   * 发票认证状态变更接口
   * 
   * @param request - UpdateInvoiceVerifyStatusRequest
   * @param headers - UpdateInvoiceVerifyStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceVerifyStatusResponse
   */
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

  /**
   * 发票认证状态变更接口
   * 
   * @param request - UpdateInvoiceVerifyStatusRequest
   * @returns UpdateInvoiceVerifyStatusResponse
   */
  async updateInvoiceVerifyStatus(request: UpdateInvoiceVerifyStatusRequest): Promise<UpdateInvoiceVerifyStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceVerifyStatusHeaders({ });
    return await this.updateInvoiceVerifyStatusWithOptions(request, headers, runtime);
  }

  /**
   * 更新发票生成凭证状态
   * 
   * @param request - UpdateInvoiceVoucherStatusRequest
   * @param headers - UpdateInvoiceVoucherStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceVoucherStatusResponse
   */
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

  /**
   * 更新发票生成凭证状态
   * 
   * @param request - UpdateInvoiceVoucherStatusRequest
   * @returns UpdateInvoiceVoucherStatusResponse
   */
  async updateInvoiceVoucherStatus(request: UpdateInvoiceVoucherStatusRequest): Promise<UpdateInvoiceVoucherStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceVoucherStatusHeaders({ });
    return await this.updateInvoiceVoucherStatusWithOptions(request, headers, runtime);
  }

  /**
   * 更新智能财务单据
   * 
   * @param request - UpdateReceiptRequest
   * @param headers - UpdateReceiptHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateReceiptResponse
   */
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

  /**
   * 更新智能财务单据
   * 
   * @param request - UpdateReceiptRequest
   * @returns UpdateReceiptResponse
   */
  async updateReceipt(request: UpdateReceiptRequest): Promise<UpdateReceiptResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateReceiptHeaders({ });
    return await this.updateReceiptWithOptions(request, headers, runtime);
  }

  /**
   * 更新智能财务审批单的凭证状态
   * 
   * @param request - UpdateReceiptVoucherStatusRequest
   * @param headers - UpdateReceiptVoucherStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateReceiptVoucherStatusResponse
   */
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

    if (!Util.isUnset(request.voucherNo)) {
      body["voucherNo"] = request.voucherNo;
    }

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

  /**
   * 更新智能财务审批单的凭证状态
   * 
   * @param request - UpdateReceiptVoucherStatusRequest
   * @returns UpdateReceiptVoucherStatusResponse
   */
  async updateReceiptVoucherStatus(request: UpdateReceiptVoucherStatusRequest): Promise<UpdateReceiptVoucherStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateReceiptVoucherStatusHeaders({ });
    return await this.updateReceiptVoucherStatusWithOptions(request, headers, runtime);
  }

}
