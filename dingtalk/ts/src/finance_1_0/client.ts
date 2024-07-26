// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class ApplyBatchPayHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyBatchPayRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021070712440326300185114
   */
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210909153300000002734753314700
   */
  orderNo?: string;
  /**
   * @example
   * map
   */
  passBackParams?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * PC
   */
  payTerminal?: string;
  /**
   * @example
   * http://xx
   */
  returnUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8754214873
   */
  staffId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10.00
   */
  transAmount?: string;
  /**
   * @example
   * yyyy-MM-dd HH:mm:ss
   */
  transExpireTime?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      orderNo: 'orderNo',
      passBackParams: 'passBackParams',
      payTerminal: 'payTerminal',
      returnUrl: 'returnUrl',
      staffId: 'staffId',
      transAmount: 'transAmount',
      transExpireTime: 'transExpireTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      orderNo: 'string',
      passBackParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      payTerminal: 'string',
      returnUrl: 'string',
      staffId: 'string',
      transAmount: 'string',
      transExpireTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyBatchPayResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210909153300000002734753314700
   */
  orderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * payData
   */
  payData?: string;
  static names(): { [key: string]: string } {
    return {
      orderNo: 'orderNo',
      payData: 'payData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderNo: 'string',
      payData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyBatchPayResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ApplyBatchPayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ApplyBatchPayResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseLoanEntranceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseLoanEntranceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1a23qdfa
   * 
   * **if can be null:**
   * true
   */
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

export class CloseLoanEntranceResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1a23qdfa
   */
  requestId?: string;
  /**
   * @example
   * Y
   */
  result?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseLoanEntranceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CloseLoanEntranceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CloseLoanEntranceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequest extends $tea.Model {
  /**
   * @example
   * asdf@163.com
   */
  bindingAlipayLogonId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contactInfo?: ConsultCreateSubInstitutionRequestContactInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  legalPersonCertInfo?: ConsultCreateSubInstitutionRequestLegalPersonCertInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021000001
   */
  outTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  qualificationInfos?: ConsultCreateSubInstitutionRequestQualificationInfos[];
  /**
   * @remarks
   * This parameter is required.
   */
  services?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  settleInfo?: ConsultCreateSubInstitutionRequestSettleInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * S001
   */
  solution?: string;
  subInstAddressInfo?: ConsultCreateSubInstitutionRequestSubInstAddressInfo;
  subInstAuthInfo?: ConsultCreateSubInstitutionRequestSubInstAuthInfo;
  /**
   * @remarks
   * This parameter is required.
   */
  subInstBasicInfo?: ConsultCreateSubInstitutionRequestSubInstBasicInfo;
  /**
   * @remarks
   * This parameter is required.
   */
  subInstCertifyInfo?: ConsultCreateSubInstitutionRequestSubInstCertifyInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  subInstInvoiceInfo?: ConsultCreateSubInstitutionRequestSubInstInvoiceInfo;
  subInstShopInfo?: ConsultCreateSubInstitutionRequestSubInstShopInfo;
  static names(): { [key: string]: string } {
    return {
      bindingAlipayLogonId: 'bindingAlipayLogonId',
      contactInfo: 'contactInfo',
      instId: 'instId',
      legalPersonCertInfo: 'legalPersonCertInfo',
      outTradeNo: 'outTradeNo',
      payChannel: 'payChannel',
      qualificationInfos: 'qualificationInfos',
      services: 'services',
      settleInfo: 'settleInfo',
      solution: 'solution',
      subInstAddressInfo: 'subInstAddressInfo',
      subInstAuthInfo: 'subInstAuthInfo',
      subInstBasicInfo: 'subInstBasicInfo',
      subInstCertifyInfo: 'subInstCertifyInfo',
      subInstId: 'subInstId',
      subInstInvoiceInfo: 'subInstInvoiceInfo',
      subInstShopInfo: 'subInstShopInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindingAlipayLogonId: 'string',
      contactInfo: ConsultCreateSubInstitutionRequestContactInfo,
      instId: 'string',
      legalPersonCertInfo: ConsultCreateSubInstitutionRequestLegalPersonCertInfo,
      outTradeNo: 'string',
      payChannel: 'string',
      qualificationInfos: { 'type': 'array', 'itemType': ConsultCreateSubInstitutionRequestQualificationInfos },
      services: { 'type': 'array', 'itemType': 'string' },
      settleInfo: ConsultCreateSubInstitutionRequestSettleInfo,
      solution: 'string',
      subInstAddressInfo: ConsultCreateSubInstitutionRequestSubInstAddressInfo,
      subInstAuthInfo: ConsultCreateSubInstitutionRequestSubInstAuthInfo,
      subInstBasicInfo: ConsultCreateSubInstitutionRequestSubInstBasicInfo,
      subInstCertifyInfo: ConsultCreateSubInstitutionRequestSubInstCertifyInfo,
      subInstId: 'string',
      subInstInvoiceInfo: ConsultCreateSubInstitutionRequestSubInstInvoiceInfo,
      subInstShopInfo: ConsultCreateSubInstitutionRequestSubInstShopInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202110110000001
   */
  orderId?: string;
  static names(): { [key: string]: string } {
    return {
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConsultCreateSubInstitutionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ConsultCreateSubInstitutionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatWithholdingOrderAndPayHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatWithholdingOrderAndPayRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10.01
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  otherPayChannelDetailInfoList?: CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021113000001
   */
  outTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2120493284
   */
  payerUserId?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @example
   * 15m
   */
  timeOutExpress?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 餐费
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      instId: 'instId',
      otherPayChannelDetailInfoList: 'otherPayChannelDetailInfoList',
      outTradeNo: 'outTradeNo',
      payChannel: 'payChannel',
      payerUserId: 'payerUserId',
      remark: 'remark',
      subInstId: 'subInstId',
      timeOutExpress: 'timeOutExpress',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      instId: 'string',
      otherPayChannelDetailInfoList: { 'type': 'array', 'itemType': CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList },
      outTradeNo: 'string',
      payChannel: 'string',
      payerUserId: 'string',
      remark: 'string',
      subInstId: 'string',
      timeOutExpress: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatWithholdingOrderAndPayResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10.01
   */
  amount?: string;
  /**
   * @example
   * 2021-11-15 10:10:10
   */
  gmtPay?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111010001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202121241343151
   */
  orderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111020001
   */
  outTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13****09
   */
  payChannelAccountNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123124
   */
  payerStaffId?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 餐费
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      gmtPay: 'gmtPay',
      instId: 'instId',
      orderNo: 'orderNo',
      outTradeNo: 'outTradeNo',
      payChannel: 'payChannel',
      payChannelAccountNo: 'payChannelAccountNo',
      payerStaffId: 'payerStaffId',
      remark: 'remark',
      status: 'status',
      subInstId: 'subInstId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      gmtPay: 'string',
      instId: 'string',
      orderNo: 'string',
      outTradeNo: 'string',
      payChannel: 'string',
      payChannelAccountNo: 'string',
      payerStaffId: 'string',
      remark: 'string',
      status: 'string',
      subInstId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatWithholdingOrderAndPayResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreatWithholdingOrderAndPayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreatWithholdingOrderAndPayResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAcquireRefundOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAcquireRefundOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @example
   * 2120493284
   */
  operatorUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021113000001
   */
  originOutTradeNo?: string;
  otherPayChannelDetailInfoList?: CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * r2021113000001
   */
  outRefundNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10.01
   */
  refundAmount?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 餐费
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      operatorUserId: 'operatorUserId',
      originOutTradeNo: 'originOutTradeNo',
      otherPayChannelDetailInfoList: 'otherPayChannelDetailInfoList',
      outRefundNo: 'outRefundNo',
      refundAmount: 'refundAmount',
      remark: 'remark',
      subInstId: 'subInstId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      operatorUserId: 'string',
      originOutTradeNo: 'string',
      otherPayChannelDetailInfoList: { 'type': 'array', 'itemType': CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList },
      outRefundNo: 'string',
      refundAmount: 'string',
      remark: 'string',
      subInstId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAcquireRefundOrderResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * r2021113000001
   */
  outRefundNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111110000111
   */
  refundOrderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      outRefundNo: 'outRefundNo',
      refundOrderNo: 'refundOrderNo',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outRefundNo: 'string',
      refundOrderNo: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAcquireRefundOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAcquireRefundOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateAcquireRefundOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBatchTradeOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBatchTradeOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021070712440326300185114
   */
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13****9
   */
  accountNo?: string;
  /**
   * @example
   * 备注
   */
  batchRemark?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  batchTradeDetails?: CreateBatchTradeOrderRequestBatchTradeDetails[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210901001
   */
  outBatchNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8476212471
   */
  staffId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  totalAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  totalCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 工资
   */
  tradeTitle?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      accountNo: 'accountNo',
      batchRemark: 'batchRemark',
      batchTradeDetails: 'batchTradeDetails',
      outBatchNo: 'outBatchNo',
      staffId: 'staffId',
      totalAmount: 'totalAmount',
      totalCount: 'totalCount',
      tradeTitle: 'tradeTitle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      accountNo: 'string',
      batchRemark: 'string',
      batchTradeDetails: { 'type': 'array', 'itemType': CreateBatchTradeOrderRequestBatchTradeDetails },
      outBatchNo: 'string',
      staffId: 'string',
      totalAmount: 'string',
      totalCount: 'number',
      tradeTitle: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBatchTradeOrderResponseBody extends $tea.Model {
  orderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  orderStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  outBatchNo?: string;
  static names(): { [key: string]: string } {
    return {
      orderNo: 'orderNo',
      orderStatus: 'orderStatus',
      outBatchNo: 'outBatchNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderNo: 'string',
      orderStatus: 'string',
      outBatchNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBatchTradeOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateBatchTradeOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateBatchTradeOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequest extends $tea.Model {
  /**
   * @example
   * asdf@163.com
   */
  bindingAlipayLogonId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contactInfo?: CreateSubInstitutionRequestContactInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  legalPersonCertInfo?: CreateSubInstitutionRequestLegalPersonCertInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021000001
   */
  outTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  qualificationInfos?: CreateSubInstitutionRequestQualificationInfos[];
  /**
   * @remarks
   * This parameter is required.
   */
  services?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  settleInfo?: CreateSubInstitutionRequestSettleInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * S001
   */
  solution?: string;
  subInstAddressInfo?: CreateSubInstitutionRequestSubInstAddressInfo;
  subInstAuthInfo?: CreateSubInstitutionRequestSubInstAuthInfo;
  /**
   * @remarks
   * This parameter is required.
   */
  subInstBasicInfo?: CreateSubInstitutionRequestSubInstBasicInfo;
  /**
   * @remarks
   * This parameter is required.
   */
  subInstCertifyInfo?: CreateSubInstitutionRequestSubInstCertifyInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  subInstInvoiceInfo?: CreateSubInstitutionRequestSubInstInvoiceInfo;
  subInstShopInfo?: CreateSubInstitutionRequestSubInstShopInfo;
  static names(): { [key: string]: string } {
    return {
      bindingAlipayLogonId: 'bindingAlipayLogonId',
      contactInfo: 'contactInfo',
      instId: 'instId',
      legalPersonCertInfo: 'legalPersonCertInfo',
      outTradeNo: 'outTradeNo',
      payChannel: 'payChannel',
      qualificationInfos: 'qualificationInfos',
      services: 'services',
      settleInfo: 'settleInfo',
      solution: 'solution',
      subInstAddressInfo: 'subInstAddressInfo',
      subInstAuthInfo: 'subInstAuthInfo',
      subInstBasicInfo: 'subInstBasicInfo',
      subInstCertifyInfo: 'subInstCertifyInfo',
      subInstId: 'subInstId',
      subInstInvoiceInfo: 'subInstInvoiceInfo',
      subInstShopInfo: 'subInstShopInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindingAlipayLogonId: 'string',
      contactInfo: CreateSubInstitutionRequestContactInfo,
      instId: 'string',
      legalPersonCertInfo: CreateSubInstitutionRequestLegalPersonCertInfo,
      outTradeNo: 'string',
      payChannel: 'string',
      qualificationInfos: { 'type': 'array', 'itemType': CreateSubInstitutionRequestQualificationInfos },
      services: { 'type': 'array', 'itemType': 'string' },
      settleInfo: CreateSubInstitutionRequestSettleInfo,
      solution: 'string',
      subInstAddressInfo: CreateSubInstitutionRequestSubInstAddressInfo,
      subInstAuthInfo: CreateSubInstitutionRequestSubInstAuthInfo,
      subInstBasicInfo: CreateSubInstitutionRequestSubInstBasicInfo,
      subInstCertifyInfo: CreateSubInstitutionRequestSubInstCertifyInfo,
      subInstId: 'string',
      subInstInvoiceInfo: CreateSubInstitutionRequestSubInstInvoiceInfo,
      subInstShopInfo: CreateSubInstitutionRequestSubInstShopInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202110110000001
   */
  orderId?: string;
  static names(): { [key: string]: string } {
    return {
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateSubInstitutionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateSubInstitutionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserCodeInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserCodeInstanceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  availableTimes?: CreateUserCodeInstanceRequestAvailableTimes[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TEST
   */
  codeIdentity?: string;
  codeValue?: string;
  /**
   * @example
   * DING_STATIC
   */
  codeValueType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * corpid1234
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  extInfo?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * yyyy-MM-dd HH:mm:ss
   */
  gmtExpired?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202102021212
   */
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * OPEN
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INTERNAL_STAFF
   */
  userCorpRelationType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 86-xxxxxx
   */
  userIdentity?: string;
  static names(): { [key: string]: string } {
    return {
      availableTimes: 'availableTimes',
      codeIdentity: 'codeIdentity',
      codeValue: 'codeValue',
      codeValueType: 'codeValueType',
      corpId: 'corpId',
      extInfo: 'extInfo',
      gmtExpired: 'gmtExpired',
      requestId: 'requestId',
      status: 'status',
      userCorpRelationType: 'userCorpRelationType',
      userIdentity: 'userIdentity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      availableTimes: { 'type': 'array', 'itemType': CreateUserCodeInstanceRequestAvailableTimes },
      codeIdentity: 'string',
      codeValue: 'string',
      codeValueType: 'string',
      corpId: 'string',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gmtExpired: 'string',
      requestId: 'string',
      status: 'string',
      userCorpRelationType: 'string',
      userIdentity: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserCodeInstanceResponseBody extends $tea.Model {
  codeDetailUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * codexxxxxx
   */
  codeId?: string;
  static names(): { [key: string]: string } {
    return {
      codeDetailUrl: 'codeDetailUrl',
      codeId: 'codeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeDetailUrl: 'string',
      codeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserCodeInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateUserCodeInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: CreateUserCodeInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodePayCodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodePayCodeRequest extends $tea.Model {
  payCode?: string;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      payCode: 'payCode',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payCode: 'string',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodePayCodeResponseBody extends $tea.Model {
  /**
   * @example
   * 2512345678
   */
  alipayCode?: string;
  /**
   * @example
   * codeIdxxxxx
   */
  codeId?: string;
  /**
   * @example
   * DT_VISITOR
   */
  codeIdentity?: string;
  /**
   * @example
   * PURE_IDENTIFY_CODE
   */
  codeType?: string;
  /**
   * @example
   * ding1234
   */
  corpId?: string;
  /**
   * @example
   * {"authRules":{}}
   */
  extInfo?: string;
  /**
   * @example
   * xxxxx
   */
  outBizId?: string;
  /**
   * @example
   * INTERNAL_STAFF
   */
  userCorpRelationType?: string;
  /**
   * @example
   * staffId
   */
  userId?: string;
  /**
   * @example
   * true
   */
  userInCorp?: boolean;
  static names(): { [key: string]: string } {
    return {
      alipayCode: 'alipayCode',
      codeId: 'codeId',
      codeIdentity: 'codeIdentity',
      codeType: 'codeType',
      corpId: 'corpId',
      extInfo: 'extInfo',
      outBizId: 'outBizId',
      userCorpRelationType: 'userCorpRelationType',
      userId: 'userId',
      userInCorp: 'userInCorp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayCode: 'string',
      codeId: 'string',
      codeIdentity: 'string',
      codeType: 'string',
      corpId: 'string',
      extInfo: 'string',
      outBizId: 'string',
      userCorpRelationType: 'string',
      userId: 'string',
      userInCorp: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodePayCodeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DecodePayCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: DecodePayCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinanceLoanNotifyRegisterHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinanceLoanNotifyRegisterRequest extends $tea.Model {
  /**
   * @example
   * 2024-06-18 14:53:33
   */
  completeTime?: string;
  /**
   * @example
   * {}
   */
  extension?: string;
  /**
   * @example
   * 330725189509101234
   */
  idCardNo?: string;
  /**
   * @example
   * 中原消费金融
   */
  openChannelName?: string;
  /**
   * @example
   * XFD201909210001
   */
  openProductCode?: string;
  /**
   * @example
   * 员工贷
   */
  openProductName?: string;
  /**
   * @example
   * ZYXJ_XFD
   */
  openProductType?: string;
  /**
   * @example
   * 0
   */
  processingStatus?: string;
  /**
   * @example
   * ZRSB2020
   */
  refuseCode?: string;
  /**
   * @example
   * 进件准入失败
   */
  refuseReason?: string;
  /**
   * @example
   * 2024061814654041710801
   */
  registerNo?: string;
  /**
   * @example
   * 0
   */
  status?: string;
  /**
   * @example
   * 2024-06-18 14:53:33
   */
  submitTime?: string;
  /**
   * @example
   * 18092149430
   */
  userMobile?: string;
  static names(): { [key: string]: string } {
    return {
      completeTime: 'completeTime',
      extension: 'extension',
      idCardNo: 'idCardNo',
      openChannelName: 'openChannelName',
      openProductCode: 'openProductCode',
      openProductName: 'openProductName',
      openProductType: 'openProductType',
      processingStatus: 'processingStatus',
      refuseCode: 'refuseCode',
      refuseReason: 'refuseReason',
      registerNo: 'registerNo',
      status: 'status',
      submitTime: 'submitTime',
      userMobile: 'userMobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      completeTime: 'string',
      extension: 'string',
      idCardNo: 'string',
      openChannelName: 'string',
      openProductCode: 'string',
      openProductName: 'string',
      openProductType: 'string',
      processingStatus: 'string',
      refuseCode: 'string',
      refuseReason: 'string',
      registerNo: 'string',
      status: 'string',
      submitTime: 'string',
      userMobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinanceLoanNotifyRegisterResponseBody extends $tea.Model {
  requestId?: string;
  result?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinanceLoanNotifyRegisterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FinanceLoanNotifyRegisterResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: FinanceLoanNotifyRegisterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequest extends $tea.Model {
  /**
   * @example
   * asdf@163.com
   */
  bindingAlipayLogonId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contactInfo?: ModifySubInstitutionRequestContactInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  legalPersonCertInfo?: ModifySubInstitutionRequestLegalPersonCertInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021000001
   */
  outTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  qualificationInfos?: ModifySubInstitutionRequestQualificationInfos[];
  /**
   * @remarks
   * This parameter is required.
   */
  services?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  settleInfo?: ModifySubInstitutionRequestSettleInfo;
  subInstAddressInfo?: ModifySubInstitutionRequestSubInstAddressInfo;
  subInstAuthInfo?: ModifySubInstitutionRequestSubInstAuthInfo;
  /**
   * @remarks
   * This parameter is required.
   */
  subInstBasicInfo?: ModifySubInstitutionRequestSubInstBasicInfo;
  /**
   * @remarks
   * This parameter is required.
   */
  subInstCertifyInfo?: ModifySubInstitutionRequestSubInstCertifyInfo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  subInstInvoiceInfo?: ModifySubInstitutionRequestSubInstInvoiceInfo;
  subInstShopInfo?: ModifySubInstitutionRequestSubInstShopInfo;
  static names(): { [key: string]: string } {
    return {
      bindingAlipayLogonId: 'bindingAlipayLogonId',
      contactInfo: 'contactInfo',
      instId: 'instId',
      legalPersonCertInfo: 'legalPersonCertInfo',
      outTradeNo: 'outTradeNo',
      payChannel: 'payChannel',
      qualificationInfos: 'qualificationInfos',
      services: 'services',
      settleInfo: 'settleInfo',
      subInstAddressInfo: 'subInstAddressInfo',
      subInstAuthInfo: 'subInstAuthInfo',
      subInstBasicInfo: 'subInstBasicInfo',
      subInstCertifyInfo: 'subInstCertifyInfo',
      subInstId: 'subInstId',
      subInstInvoiceInfo: 'subInstInvoiceInfo',
      subInstShopInfo: 'subInstShopInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindingAlipayLogonId: 'string',
      contactInfo: ModifySubInstitutionRequestContactInfo,
      instId: 'string',
      legalPersonCertInfo: ModifySubInstitutionRequestLegalPersonCertInfo,
      outTradeNo: 'string',
      payChannel: 'string',
      qualificationInfos: { 'type': 'array', 'itemType': ModifySubInstitutionRequestQualificationInfos },
      services: { 'type': 'array', 'itemType': 'string' },
      settleInfo: ModifySubInstitutionRequestSettleInfo,
      subInstAddressInfo: ModifySubInstitutionRequestSubInstAddressInfo,
      subInstAuthInfo: ModifySubInstitutionRequestSubInstAuthInfo,
      subInstBasicInfo: ModifySubInstitutionRequestSubInstBasicInfo,
      subInstCertifyInfo: ModifySubInstitutionRequestSubInstCertifyInfo,
      subInstId: 'string',
      subInstInvoiceInfo: ModifySubInstitutionRequestSubInstInvoiceInfo,
      subInstShopInfo: ModifySubInstitutionRequestSubInstShopInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionResponseBody extends $tea.Model {
  /**
   * @example
   * 202110110000001
   */
  orderId?: string;
  static names(): { [key: string]: string } {
    return {
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ModifySubInstitutionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: ModifySubInstitutionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodePayResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodePayResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234.56
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00, 没有传0.00
   */
  chargeAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding1234
   */
  corpId?: string;
  /**
   * @example
   * { "akey": "avalue“}
   */
  extInfo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-01-01 11:11:11
   */
  gmtTradeCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-01-01 11:11:11
   */
  gmtTradeFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XX公司食堂
   */
  merchantName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  payChannelDetailList?: NotifyPayCodePayResultRequestPayChannelDetailList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 261234567890
   */
  payCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.23，没有传0.00
   */
  promotionAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 晚餐100.0元
   */
  title?: string;
  /**
   * @example
   * BALANCE_NOT_ENOUGH
   */
  tradeErrorCode?: string;
  /**
   * @example
   * 余额不足，请充值
   */
  tradeErrorMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202101012345678
   */
  tradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS/FAIL
   */
  tradeStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * userId1234
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      chargeAmount: 'chargeAmount',
      corpId: 'corpId',
      extInfo: 'extInfo',
      gmtTradeCreate: 'gmtTradeCreate',
      gmtTradeFinish: 'gmtTradeFinish',
      merchantName: 'merchantName',
      payChannelDetailList: 'payChannelDetailList',
      payCode: 'payCode',
      promotionAmount: 'promotionAmount',
      remark: 'remark',
      title: 'title',
      tradeErrorCode: 'tradeErrorCode',
      tradeErrorMsg: 'tradeErrorMsg',
      tradeNo: 'tradeNo',
      tradeStatus: 'tradeStatus',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      chargeAmount: 'string',
      corpId: 'string',
      extInfo: 'string',
      gmtTradeCreate: 'string',
      gmtTradeFinish: 'string',
      merchantName: 'string',
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyPayCodePayResultRequestPayChannelDetailList },
      payCode: 'string',
      promotionAmount: 'string',
      remark: 'string',
      title: 'string',
      tradeErrorCode: 'string',
      tradeErrorMsg: 'string',
      tradeNo: 'string',
      tradeStatus: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodePayResultResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
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

export class NotifyPayCodePayResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: NotifyPayCodePayResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: NotifyPayCodePayResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodeRefundResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodeRefundResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding1234
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-11 11:11:11
   */
  gmtRefund?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  payChannelDetailList?: NotifyPayCodeRefundResultRequestPayChannelDetailList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * payCode
   */
  payCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  refundAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * refundOrderNo
   */
  refundOrderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.00
   */
  refundPromotionAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 晚餐退款
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * tradeNo
   */
  tradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * userId
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      gmtRefund: 'gmtRefund',
      payChannelDetailList: 'payChannelDetailList',
      payCode: 'payCode',
      refundAmount: 'refundAmount',
      refundOrderNo: 'refundOrderNo',
      refundPromotionAmount: 'refundPromotionAmount',
      remark: 'remark',
      tradeNo: 'tradeNo',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      gmtRefund: 'string',
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyPayCodeRefundResultRequestPayChannelDetailList },
      payCode: 'string',
      refundAmount: 'string',
      refundOrderNo: 'string',
      refundPromotionAmount: 'string',
      remark: 'string',
      tradeNo: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodeRefundResultResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
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

export class NotifyPayCodeRefundResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: NotifyPayCodeRefundResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: NotifyPayCodeRefundResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyVerifyResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyVerifyResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * corpxxxx
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 261234567890
   */
  payCode?: string;
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INTERNAL_STAFF
   */
  userCorpRelationType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxx
   */
  userIdentity?: string;
  /**
   * @example
   * 门禁验证
   */
  verifyEvent?: string;
  /**
   * @example
   * 1号食堂
   */
  verifyLocation?: string;
  /**
   * @example
   * 202112120003232
   */
  verifyNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 是否通过
   */
  verifyResult?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-01-01 12:12:12
   */
  verifyTime?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      payCode: 'payCode',
      remark: 'remark',
      userCorpRelationType: 'userCorpRelationType',
      userIdentity: 'userIdentity',
      verifyEvent: 'verifyEvent',
      verifyLocation: 'verifyLocation',
      verifyNo: 'verifyNo',
      verifyResult: 'verifyResult',
      verifyTime: 'verifyTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      payCode: 'string',
      remark: 'string',
      userCorpRelationType: 'string',
      userIdentity: 'string',
      verifyEvent: 'string',
      verifyLocation: 'string',
      verifyNo: 'string',
      verifyResult: 'boolean',
      verifyTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyVerifyResultResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
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

export class NotifyVerifyResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: NotifyVerifyResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: NotifyVerifyResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCreateGroupBillOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCreateGroupBillOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  billItemList?: PreCreateGroupBillOrderRequestBillItemList[];
  extParams?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  headCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  isAverageAmount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dhqhadsnkj2qweqsw2
   */
  merchantId?: string;
  /**
   * @example
   * opemcesdjuwqw2uwnedj==
   */
  openCid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20230918291921929193911
   */
  outBizNo?: string;
  /**
   * @example
   * ding32fff839a3e0105d
   */
  payeeCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ECEjwiiwenwnw2q2sdd
   */
  payeeUnionId?: string;
  /**
   * @example
   * 饿了么拼单-测试
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10.24
   */
  totalAmount?: string;
  static names(): { [key: string]: string } {
    return {
      billItemList: 'billItemList',
      extParams: 'extParams',
      headCount: 'headCount',
      isAverageAmount: 'isAverageAmount',
      merchantId: 'merchantId',
      openCid: 'openCid',
      outBizNo: 'outBizNo',
      payeeCorpId: 'payeeCorpId',
      payeeUnionId: 'payeeUnionId',
      remark: 'remark',
      totalAmount: 'totalAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      billItemList: { 'type': 'array', 'itemType': PreCreateGroupBillOrderRequestBillItemList },
      extParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      headCount: 'number',
      isAverageAmount: 'number',
      merchantId: 'string',
      openCid: 'string',
      outBizNo: 'string',
      payeeCorpId: 'string',
      payeeUnionId: 'string',
      remark: 'string',
      totalAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCreateGroupBillOrderResponseBody extends $tea.Model {
  result?: PreCreateGroupBillOrderResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PreCreateGroupBillOrderResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCreateGroupBillOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PreCreateGroupBillOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: PreCreateGroupBillOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAcquireRefundOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAcquireRefundOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202100001
   */
  outRefundNo?: string;
  static names(): { [key: string]: string } {
    return {
      outRefundNo: 'outRefundNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outRefundNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAcquireRefundOrderResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10.01
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-15 10:10:09
   */
  gmtCreate?: string;
  /**
   * @example
   * 2021-11-15 10:10:10
   */
  gmtRefund?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111010001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202121241343151
   */
  orderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111020001
   */
  originOutTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * r202111020001
   */
  outRefundNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13****09
   */
  payChannelAccountNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123124
   */
  payerUserId?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 餐费
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      gmtCreate: 'gmtCreate',
      gmtRefund: 'gmtRefund',
      instId: 'instId',
      orderNo: 'orderNo',
      originOutTradeNo: 'originOutTradeNo',
      outRefundNo: 'outRefundNo',
      payChannel: 'payChannel',
      payChannelAccountNo: 'payChannelAccountNo',
      payerUserId: 'payerUserId',
      remark: 'remark',
      status: 'status',
      subInstId: 'subInstId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      gmtCreate: 'string',
      gmtRefund: 'string',
      instId: 'string',
      orderNo: 'string',
      originOutTradeNo: 'string',
      outRefundNo: 'string',
      payChannel: 'string',
      payChannelAccountNo: 'string',
      payerUserId: 'string',
      remark: 'string',
      status: 'string',
      subInstId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAcquireRefundOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryAcquireRefundOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryAcquireRefundOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeDetailListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeDetailListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210901001
   */
  outBatchNo?: string;
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
   * 50
   */
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      outBatchNo: 'outBatchNo',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outBatchNo: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeDetailListResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  batchTradeDetailList?: QueryBatchTradeDetailListResponseBodyBatchTradeDetailList[];
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
   * 1
   */
  pageSize?: number;
  /**
   * @example
   * 1
   */
  total?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  totalPageNumber?: number;
  static names(): { [key: string]: string } {
    return {
      batchTradeDetailList: 'batchTradeDetailList',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      total: 'total',
      totalPageNumber: 'totalPageNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      batchTradeDetailList: { 'type': 'array', 'itemType': QueryBatchTradeDetailListResponseBodyBatchTradeDetailList },
      pageNumber: 'number',
      pageSize: 'number',
      total: 'number',
      totalPageNumber: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeDetailListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBatchTradeDetailListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryBatchTradeDetailListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  outBatchNos?: string[];
  static names(): { [key: string]: string } {
    return {
      outBatchNos: 'outBatchNos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outBatchNos: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeOrderResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  batchTradeOrderVOs?: QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs[];
  static names(): { [key: string]: string } {
    return {
      batchTradeOrderVOs: 'batchTradeOrderVOs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      batchTradeOrderVOs: { 'type': 'array', 'itemType': QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBatchTradeOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryBatchTradeOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayAccountListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayAccountListResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  payAccountVOList?: QueryPayAccountListResponseBodyPayAccountVOList[];
  static names(): { [key: string]: string } {
    return {
      payAccountVOList: 'payAccountVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payAccountVOList: { 'type': 'array', 'itemType': QueryPayAccountListResponseBodyPayAccountVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayAccountListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryPayAccountListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryPayAccountListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRegisterOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRegisterOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @example
   * 20211222000000001
   */
  orderId?: string;
  /**
   * @example
   * 202112220001
   */
  outTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  subInstId?: string;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      orderId: 'orderId',
      outTradeNo: 'outTradeNo',
      subInstId: 'subInstId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      orderId: 'string',
      outTradeNo: 'string',
      subInstId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRegisterOrderResponseBody extends $tea.Model {
  failReason?: string;
  gmtAudit?: string;
  instId?: string;
  orderId?: string;
  outTradeNo?: string;
  status?: string;
  subInstId?: string;
  subInstName?: string;
  static names(): { [key: string]: string } {
    return {
      failReason: 'failReason',
      gmtAudit: 'gmtAudit',
      instId: 'instId',
      orderId: 'orderId',
      outTradeNo: 'outTradeNo',
      status: 'status',
      subInstId: 'subInstId',
      subInstName: 'subInstName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failReason: 'string',
      gmtAudit: 'string',
      instId: 'string',
      orderId: 'string',
      outTradeNo: 'string',
      status: 'string',
      subInstId: 'string',
      subInstName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRegisterOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRegisterOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryRegisterOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAgreementHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAgreementRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TRADE
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * WITHHOLDING
   */
  bizScene?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2120493284
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      bizScene: 'bizScene',
      instId: 'instId',
      subInstId: 'subInstId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      bizScene: 'string',
      instId: 'string',
      subInstId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAgreementResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 201220123212312
   */
  agreementNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding123123234234
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-11 10:10:10
   */
  gmtExpire?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-11 10:10:10
   */
  gmtSign?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-11 10:10:10
   */
  gmtValid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021000001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * *川
   */
  payChannelAccountName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 139*****0
   */
  payChannelAccountNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 101
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 54646545
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      agreementNo: 'agreementNo',
      corpId: 'corpId',
      gmtExpire: 'gmtExpire',
      gmtSign: 'gmtSign',
      gmtValid: 'gmtValid',
      instId: 'instId',
      payChannel: 'payChannel',
      payChannelAccountName: 'payChannelAccountName',
      payChannelAccountNo: 'payChannelAccountNo',
      status: 'status',
      subInstId: 'subInstId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agreementNo: 'string',
      corpId: 'string',
      gmtExpire: 'string',
      gmtSign: 'string',
      gmtValid: 'string',
      instId: 'string',
      payChannel: 'string',
      payChannelAccountName: 'string',
      payChannelAccountNo: 'string',
      status: 'string',
      subInstId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAgreementResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUserAgreementResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUserAgreementResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAlipayAccountHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAlipayAccountResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2088894773487
   */
  alipayUid?: string;
  static names(): { [key: string]: string } {
    return {
      alipayUid: 'alipayUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAlipayAccountResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUserAlipayAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryUserAlipayAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryWithholdingOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryWithholdingOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202100001
   */
  outTradeNo?: string;
  static names(): { [key: string]: string } {
    return {
      outTradeNo: 'outTradeNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outTradeNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryWithholdingOrderResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10.01
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-15 10:10:09
   */
  gmtCreate?: string;
  /**
   * @example
   * 2021-11-15 10:10:10
   */
  gmtPay?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111010001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202121241343151
   */
  orderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111020001
   */
  outTradeNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13****09
   */
  payChannelAccountNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123124
   */
  payerUserId?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 餐费
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      gmtCreate: 'gmtCreate',
      gmtPay: 'gmtPay',
      instId: 'instId',
      orderNo: 'orderNo',
      outTradeNo: 'outTradeNo',
      payChannel: 'payChannel',
      payChannelAccountNo: 'payChannelAccountNo',
      payerUserId: 'payerUserId',
      remark: 'remark',
      status: 'status',
      subInstId: 'subInstId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      gmtCreate: 'string',
      gmtPay: 'string',
      instId: 'string',
      orderNo: 'string',
      outTradeNo: 'string',
      payChannel: 'string',
      payChannelAccountNo: 'string',
      payerUserId: 'string',
      remark: 'string',
      status: 'string',
      subInstId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryWithholdingOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryWithholdingOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: QueryWithholdingOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCorpPayCodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCorpPayCodeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * H_FISH_CANTEEN
   */
  codeIdentity?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxx
   */
  corpId?: string;
  extInfo?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * OPEN
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      codeIdentity: 'codeIdentity',
      corpId: 'corpId',
      extInfo: 'extInfo',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeIdentity: 'string',
      corpId: 'string',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCorpPayCodeResponseBody extends $tea.Model {
  codeIdentity?: string;
  corpId?: string;
  extInfo?: { [key: string]: string };
  status?: string;
  static names(): { [key: string]: string } {
    return {
      codeIdentity: 'codeIdentity',
      corpId: 'corpId',
      extInfo: 'extInfo',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeIdentity: 'string',
      corpId: 'string',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCorpPayCodeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveCorpPayCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: SaveCorpPayCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsignUserAgreementHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsignUserAgreementRequest extends $tea.Model {
  /**
   * @example
   * 23021_12342134
   */
  agreementNo?: string;
  /**
   * @example
   * TRADE
   */
  bizCode?: string;
  /**
   * @example
   * WITHHOLDING
   */
  bizScene?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2120493284
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      agreementNo: 'agreementNo',
      bizCode: 'bizCode',
      bizScene: 'bizScene',
      instId: 'instId',
      subInstId: 'subInstId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agreementNo: 'string',
      bizCode: 'string',
      bizScene: 'string',
      instId: 'string',
      subInstId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UnsignUserAgreementResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpateUserCodeInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpateUserCodeInstanceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  availableTimes?: UpateUserCodeInstanceRequestAvailableTimes[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ccodexxxxx
   */
  codeId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TEST
   */
  codeIdentity?: string;
  codeValue?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * corpIdxxxx
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  extInfo?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  gmtExpired?: string;
  /**
   * @example
   * OPEN
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INTERNAL_STAFF
   */
  userCorpRelationType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 86-xxxxxx
   */
  userIdentity?: string;
  static names(): { [key: string]: string } {
    return {
      availableTimes: 'availableTimes',
      codeId: 'codeId',
      codeIdentity: 'codeIdentity',
      codeValue: 'codeValue',
      corpId: 'corpId',
      extInfo: 'extInfo',
      gmtExpired: 'gmtExpired',
      status: 'status',
      userCorpRelationType: 'userCorpRelationType',
      userIdentity: 'userIdentity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      availableTimes: { 'type': 'array', 'itemType': UpateUserCodeInstanceRequestAvailableTimes },
      codeId: 'string',
      codeIdentity: 'string',
      codeValue: 'string',
      corpId: 'string',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      gmtExpired: 'string',
      status: 'string',
      userCorpRelationType: 'string',
      userIdentity: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpateUserCodeInstanceResponseBody extends $tea.Model {
  /**
   * @example
   * codexxxxxx
   */
  codeId?: string;
  static names(): { [key: string]: string } {
    return {
      codeId: 'codeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpateUserCodeInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpateUserCodeInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UpateUserCodeInstanceResponseBody,
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
   * @remarks
   * This parameter is required.
   * 
   * @example
   * lpKgSTzGSy
   */
  bizId?: string;
  /**
   * @example
   * 1
   */
  checkingResult?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  checkingStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 200
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding673cxxxxxxxxxxxx85
   */
  corpId?: string;
  /**
   * @example
   * {"restCheckTimes":10,"noticeFlag":1}
   */
  extension?: string;
  /**
   * @example
   * 034012100111
   */
  invoiceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 61235725
   */
  invoiceNo?: string;
  /**
   * @example
   * 1
   */
  invoiceStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1299999
   */
  invoiceVerifyId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  msg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * BPq7qiSIH8PJHlB9kPuii1NQiEiE
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      checkingResult: 'checkingResult',
      checkingStatus: 'checkingStatus',
      code: 'code',
      corpId: 'corpId',
      extension: 'extension',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      invoiceStatus: 'invoiceStatus',
      invoiceVerifyId: 'invoiceVerifyId',
      msg: 'msg',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      checkingResult: 'number',
      checkingStatus: 'number',
      code: 'string',
      corpId: 'string',
      extension: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      invoiceStatus: 'number',
      invoiceVerifyId: 'string',
      msg: 'string',
      unionId: 'string',
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

export class UploadInvoiceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceRequest extends $tea.Model {
  extension?: UploadInvoiceRequestExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  invoices?: UploadInvoiceRequestInvoices[];
  userIdentity?: UploadInvoiceRequestUserIdentity;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      invoices: 'invoices',
      userIdentity: 'userIdentity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: UploadInvoiceRequestExtension,
      invoices: { 'type': 'array', 'itemType': UploadInvoiceRequestInvoices },
      userIdentity: UploadInvoiceRequestUserIdentity,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceResponseBody extends $tea.Model {
  result?: UploadInvoiceResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UploadInvoiceResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UploadInvoiceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UploadInvoiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthRequest extends $tea.Model {
  extension?: UploadInvoiceByAuthRequestExtension;
  /**
   * @remarks
   * This parameter is required.
   */
  invoices?: UploadInvoiceByAuthRequestInvoices[];
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      invoices: 'invoices',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: UploadInvoiceByAuthRequestExtension,
      invoices: { 'type': 'array', 'itemType': UploadInvoiceByAuthRequestInvoices },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthResponseBody extends $tea.Model {
  result?: UploadInvoiceByAuthResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UploadInvoiceByAuthResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UploadInvoiceByAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UploadInvoiceByAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByMobileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByMobileRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  invoices?: UploadInvoiceByMobileRequestInvoices[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13600000000
   */
  mobile?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 86
   */
  mobileStateCode?: string;
  static names(): { [key: string]: string } {
    return {
      invoices: 'invoices',
      mobile: 'mobile',
      mobileStateCode: 'mobileStateCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoices: { 'type': 'array', 'itemType': UploadInvoiceByMobileRequestInvoices },
      mobile: 'string',
      mobileStateCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByMobileResponseBody extends $tea.Model {
  result?: UploadInvoiceByMobileResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UploadInvoiceByMobileResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByMobileResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UploadInvoiceByMobileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UploadInvoiceByMobileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadRegisterImageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadRegisterImageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * byte[]转Base64
   */
  imageContent?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * test
   */
  imageName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * JPG
   */
  imageType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 12020001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannel?: string;
  static names(): { [key: string]: string } {
    return {
      imageContent: 'imageContent',
      imageName: 'imageName',
      imageType: 'imageType',
      instId: 'instId',
      payChannel: 'payChannel',
    };
  }

  static types(): { [key: string]: any } {
    return {
      imageContent: 'string',
      imageName: 'string',
      imageType: 'string',
      instId: 'string',
      payChannel: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadRegisterImageResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ossUrl
   */
  ossUrl?: string;
  static names(): { [key: string]: string } {
    return {
      ossUrl: 'ossUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ossUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadRegisterImageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UploadRegisterImageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UploadRegisterImageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserAgreementPageSignHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserAgreementPageSignRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TRADE
   */
  bizCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * WITHHOLDING
   */
  bizScene?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 202111090001
   */
  instId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 支付宝
   */
  payChannel?: string;
  /**
   * @example
   * 备注
   */
  remark?: string;
  /**
   * @example
   * http://****.com
   */
  returnUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 详见支付宝接口文档https://opendocs.alipay.com/open/20190319114403226822/signscene
   */
  signScene?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  subInstId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 滴滴出行
   */
  subMerchantName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 免密付车费，单次最高500元
   */
  subMerchantServiceDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 滴滴出行免密支付
   */
  subMerchantServiceName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2120493284
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      bizScene: 'bizScene',
      instId: 'instId',
      payChannel: 'payChannel',
      remark: 'remark',
      returnUrl: 'returnUrl',
      signScene: 'signScene',
      subInstId: 'subInstId',
      subMerchantName: 'subMerchantName',
      subMerchantServiceDesc: 'subMerchantServiceDesc',
      subMerchantServiceName: 'subMerchantServiceName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      bizScene: 'string',
      instId: 'string',
      payChannel: 'string',
      remark: 'string',
      returnUrl: 'string',
      signScene: 'string',
      subInstId: 'string',
      subMerchantName: 'string',
      subMerchantServiceDesc: 'string',
      subMerchantServiceName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserAgreementPageSignResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 略
   */
  pageData?: string;
  static names(): { [key: string]: string } {
    return {
      pageData: 'pageData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserAgreementPageSignResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UserAgreementPageSignResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
      body: UserAgreementPageSignResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestContactInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 李某某
   */
  contactName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13900000000
   */
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      contactName: 'contactName',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactName: 'string',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestLegalPersonCertInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  certBackImage?: string;
  /**
   * @example
   * ossUrl
   */
  certFrontImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 李某某
   */
  certName?: string;
  /**
   * @example
   * 100
   */
  certType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 330104200010109999
   */
  idCardNo?: string;
  static names(): { [key: string]: string } {
    return {
      certBackImage: 'certBackImage',
      certFrontImage: 'certFrontImage',
      certName: 'certName',
      certType: 'certType',
      idCardNo: 'idCardNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certBackImage: 'string',
      certFrontImage: 'string',
      certName: 'string',
      certType: 'string',
      idCardNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestQualificationInfos extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ossUrl
   */
  qualificationImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 301
   */
  qualificationType?: string;
  static names(): { [key: string]: string } {
    return {
      qualificationImage: 'qualificationImage',
      qualificationType: 'qualificationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      qualificationImage: 'string',
      qualificationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSettleInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 622202120200000000
   */
  accountId?: string;
  /**
   * @example
   * 李某某
   */
  accountName?: string;
  /**
   * @example
   * DEBIT_CARD
   */
  accountType?: string;
  /**
   * @example
   * 城东支行
   */
  bankBranchName?: string;
  /**
   * @example
   * 杭州市
   */
  bankCity?: string;
  /**
   * @example
   * 313791000023
   */
  bankCode?: string;
  /**
   * @example
   * 工商银行
   */
  bankName?: string;
  /**
   * @example
   * 浙江省
   */
  bankProvince?: string;
  /**
   * @example
   * ICBC
   */
  bankShortNameCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  type?: string;
  /**
   * @example
   * TO_PRI
   */
  usageType?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      accountName: 'accountName',
      accountType: 'accountType',
      bankBranchName: 'bankBranchName',
      bankCity: 'bankCity',
      bankCode: 'bankCode',
      bankName: 'bankName',
      bankProvince: 'bankProvince',
      bankShortNameCode: 'bankShortNameCode',
      type: 'type',
      usageType: 'usageType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      accountName: 'string',
      accountType: 'string',
      bankBranchName: 'string',
      bankCity: 'string',
      bankCode: 'string',
      bankName: 'string',
      bankProvince: 'string',
      bankShortNameCode: 'string',
      type: 'string',
      usageType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstAddressInfo extends $tea.Model {
  /**
   * @example
   * 未来park
   */
  address?: string;
  /**
   * @example
   * 330100
   */
  cityCode?: string;
  /**
   * @example
   * 330104
   */
  districtCode?: string;
  /**
   * @example
   * 330000
   */
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      cityCode: 'string',
      districtCode: 'string',
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstAuthInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  authorizationLetterUrl?: string;
  static names(): { [key: string]: string } {
    return {
      authorizationLetterUrl: 'authorizationLetterUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorizationLetterUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstBasicInfo extends $tea.Model {
  /**
   * @example
   * 一食堂
   */
  aliasName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5812
   */
  mcc?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 食堂
   */
  subInstName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 01
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      aliasName: 'aliasName',
      mcc: 'mcc',
      subInstName: 'subInstName',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aliasName: 'string',
      mcc: 'string',
      subInstName: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstCertifyInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  certImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 331081198611111111
   */
  certNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 201
   */
  certType?: string;
  static names(): { [key: string]: string } {
    return {
      certImage: 'certImage',
      certNo: 'certNo',
      certType: 'certType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certImage: 'string',
      certNo: 'string',
      certType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress extends $tea.Model {
  /**
   * @example
   * 未来park
   */
  address?: string;
  /**
   * @example
   * 330100
   */
  cityCode?: string;
  /**
   * @example
   * 330104
   */
  districtCode?: string;
  /**
   * @example
   * 330000
   */
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      cityCode: 'string',
      districtCode: 'string',
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstInvoiceInfo extends $tea.Model {
  /**
   * @example
   * true
   */
  acceptElectronic?: boolean;
  /**
   * @example
   * 浙江省杭州市西湖区西溪路蚂蚁金服
   */
  address?: string;
  /**
   * @example
   * false
   */
  autoInvoice?: boolean;
  /**
   * @example
   * 1234567812345678123
   */
  bankAccount?: string;
  /**
   * @example
   * 中国银行
   */
  bankName?: string;
  mailAddress?: ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress;
  /**
   * @example
   * 张三
   */
  mailName?: string;
  /**
   * @example
   * 057162288888
   */
  mailPhone?: string;
  /**
   * @example
   * 51010482542598631219
   */
  taxNo?: string;
  /**
   * @example
   * 01
   */
  taxPayerQualification?: string;
  /**
   * @example
   * 19981011
   */
  taxPayerValidDate?: string;
  /**
   * @example
   * 057162288888
   */
  telephone?: string;
  /**
   * @example
   * **有限公司
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      acceptElectronic: 'acceptElectronic',
      address: 'address',
      autoInvoice: 'autoInvoice',
      bankAccount: 'bankAccount',
      bankName: 'bankName',
      mailAddress: 'mailAddress',
      mailName: 'mailName',
      mailPhone: 'mailPhone',
      taxNo: 'taxNo',
      taxPayerQualification: 'taxPayerQualification',
      taxPayerValidDate: 'taxPayerValidDate',
      telephone: 'telephone',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      acceptElectronic: 'boolean',
      address: 'string',
      autoInvoice: 'boolean',
      bankAccount: 'string',
      bankName: 'string',
      mailAddress: ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress,
      mailName: 'string',
      mailPhone: 'string',
      taxNo: 'string',
      taxPayerQualification: 'string',
      taxPayerValidDate: 'string',
      telephone: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstShopInfo extends $tea.Model {
  inDoorImages?: string[];
  outDoorImages?: string[];
  static names(): { [key: string]: string } {
    return {
      inDoorImages: 'inDoorImages',
      outDoorImages: 'outDoorImages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inDoorImages: { 'type': 'array', 'itemType': 'string' },
      outDoorImages: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5.00
   */
  amount?: string;
  extInfo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 余额
   */
  fundToolName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-15 10:10:10
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-15 10:10:11
   */
  gmtFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  promotionFundTool?: boolean;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      extInfo: 'extInfo',
      fundToolName: 'fundToolName',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      promotionFundTool: 'promotionFundTool',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      extInfo: 'string',
      fundToolName: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      promotionFundTool: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5.00
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fundToolDetailInfoList?: CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 支付宝
   */
  payChannelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021110100001
   */
  payChannelOrderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannelType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4.00
   */
  promotionAmount?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      fundToolDetailInfoList: 'fundToolDetailInfoList',
      payChannelName: 'payChannelName',
      payChannelOrderNo: 'payChannelOrderNo',
      payChannelType: 'payChannelType',
      promotionAmount: 'promotionAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      fundToolDetailInfoList: { 'type': 'array', 'itemType': CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList },
      payChannelName: 'string',
      payChannelOrderNo: 'string',
      payChannelType: 'string',
      promotionAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5.00
   */
  amount?: string;
  extInfo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 余额
   */
  fundToolName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-15 10:10:10
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-11-15 10:10:11
   */
  gmtFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  promotionFundTool?: boolean;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      extInfo: 'extInfo',
      fundToolName: 'fundToolName',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      promotionFundTool: 'promotionFundTool',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      extInfo: 'string',
      fundToolName: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      promotionFundTool: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5.00
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fundToolDetailInfoList?: CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 支付宝
   */
  payChannelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021110100001
   */
  payChannelOrderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannelType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 4.00
   */
  promotionAmount?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      fundToolDetailInfoList: 'fundToolDetailInfoList',
      payChannelName: 'payChannelName',
      payChannelOrderNo: 'payChannelOrderNo',
      payChannelType: 'payChannelType',
      promotionAmount: 'promotionAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      fundToolDetailInfoList: { 'type': 'array', 'itemType': CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList },
      payChannelName: 'string',
      payChannelOrderNo: 'string',
      payChannelType: 'string',
      promotionAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBatchTradeOrderRequestBatchTradeDetails extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  amount?: string;
  /**
   * @example
   * 工资
   */
  memo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试
   */
  payeeAccountName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13000000000
   */
  payeeAccountNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payeeAccountType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  serialNo?: number;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      memo: 'memo',
      payeeAccountName: 'payeeAccountName',
      payeeAccountNo: 'payeeAccountNo',
      payeeAccountType: 'payeeAccountType',
      serialNo: 'serialNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      memo: 'string',
      payeeAccountName: 'string',
      payeeAccountNo: 'string',
      payeeAccountType: 'string',
      serialNo: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestContactInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 李某某
   */
  contactName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13900000000
   */
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      contactName: 'contactName',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactName: 'string',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestLegalPersonCertInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  certBackImage?: string;
  /**
   * @example
   * ossUrl
   */
  certFrontImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 李某某
   */
  certName?: string;
  /**
   * @example
   * 100
   */
  certType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 330104200010109999
   */
  idCardNo?: string;
  static names(): { [key: string]: string } {
    return {
      certBackImage: 'certBackImage',
      certFrontImage: 'certFrontImage',
      certName: 'certName',
      certType: 'certType',
      idCardNo: 'idCardNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certBackImage: 'string',
      certFrontImage: 'string',
      certName: 'string',
      certType: 'string',
      idCardNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestQualificationInfos extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ossUrl
   */
  qualificationImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 301
   */
  qualificationType?: string;
  static names(): { [key: string]: string } {
    return {
      qualificationImage: 'qualificationImage',
      qualificationType: 'qualificationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      qualificationImage: 'string',
      qualificationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSettleInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 622202120200000000
   */
  accountId?: string;
  /**
   * @example
   * 李某某
   */
  accountName?: string;
  /**
   * @example
   * DEBIT_CARD
   */
  accountType?: string;
  /**
   * @example
   * 城东支行
   */
  bankBranchName?: string;
  /**
   * @example
   * 杭州市
   */
  bankCity?: string;
  /**
   * @example
   * 313791000023
   */
  bankCode?: string;
  /**
   * @example
   * 工商银行
   */
  bankName?: string;
  /**
   * @example
   * 浙江省
   */
  bankProvince?: string;
  /**
   * @example
   * ICBC
   */
  bankShortNameCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  type?: string;
  /**
   * @example
   * TO_PRI
   */
  usageType?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      accountName: 'accountName',
      accountType: 'accountType',
      bankBranchName: 'bankBranchName',
      bankCity: 'bankCity',
      bankCode: 'bankCode',
      bankName: 'bankName',
      bankProvince: 'bankProvince',
      bankShortNameCode: 'bankShortNameCode',
      type: 'type',
      usageType: 'usageType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      accountName: 'string',
      accountType: 'string',
      bankBranchName: 'string',
      bankCity: 'string',
      bankCode: 'string',
      bankName: 'string',
      bankProvince: 'string',
      bankShortNameCode: 'string',
      type: 'string',
      usageType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstAddressInfo extends $tea.Model {
  /**
   * @example
   * 未来park
   */
  address?: string;
  /**
   * @example
   * 330100
   */
  cityCode?: string;
  /**
   * @example
   * 330104
   */
  districtCode?: string;
  /**
   * @example
   * 330000
   */
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      cityCode: 'string',
      districtCode: 'string',
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstAuthInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  authorizationLetterUrl?: string;
  static names(): { [key: string]: string } {
    return {
      authorizationLetterUrl: 'authorizationLetterUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorizationLetterUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstBasicInfo extends $tea.Model {
  /**
   * @example
   * 一食堂
   */
  aliasName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5812
   */
  mcc?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 食堂
   */
  subInstName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 01
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      aliasName: 'aliasName',
      mcc: 'mcc',
      subInstName: 'subInstName',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aliasName: 'string',
      mcc: 'string',
      subInstName: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstCertifyInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  certImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 331081198611111111
   */
  certNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 201
   */
  certType?: string;
  static names(): { [key: string]: string } {
    return {
      certImage: 'certImage',
      certNo: 'certNo',
      certType: 'certType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certImage: 'string',
      certNo: 'string',
      certType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress extends $tea.Model {
  /**
   * @example
   * 未来park
   */
  address?: string;
  /**
   * @example
   * 330100
   */
  cityCode?: string;
  /**
   * @example
   * 330104
   */
  districtCode?: string;
  /**
   * @example
   * 330000
   */
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      cityCode: 'string',
      districtCode: 'string',
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstInvoiceInfo extends $tea.Model {
  /**
   * @example
   * true
   */
  acceptElectronic?: boolean;
  /**
   * @example
   * 浙江省杭州市西湖区西溪路蚂蚁金服
   */
  address?: string;
  /**
   * @example
   * false
   */
  autoInvoice?: boolean;
  /**
   * @example
   * 1234567812345678123
   */
  bankAccount?: string;
  /**
   * @example
   * 中国银行
   */
  bankName?: string;
  mailAddress?: CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress;
  /**
   * @example
   * 张三
   */
  mailName?: string;
  /**
   * @example
   * 057162288888
   */
  mailPhone?: string;
  /**
   * @example
   * 51010482542598631219
   */
  taxNo?: string;
  /**
   * @example
   * 01
   */
  taxPayerQualification?: string;
  /**
   * @example
   * 19981011
   */
  taxPayerValidDate?: string;
  /**
   * @example
   * 057162288888
   */
  telephone?: string;
  /**
   * @example
   * **有限公司
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      acceptElectronic: 'acceptElectronic',
      address: 'address',
      autoInvoice: 'autoInvoice',
      bankAccount: 'bankAccount',
      bankName: 'bankName',
      mailAddress: 'mailAddress',
      mailName: 'mailName',
      mailPhone: 'mailPhone',
      taxNo: 'taxNo',
      taxPayerQualification: 'taxPayerQualification',
      taxPayerValidDate: 'taxPayerValidDate',
      telephone: 'telephone',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      acceptElectronic: 'boolean',
      address: 'string',
      autoInvoice: 'boolean',
      bankAccount: 'string',
      bankName: 'string',
      mailAddress: CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress,
      mailName: 'string',
      mailPhone: 'string',
      taxNo: 'string',
      taxPayerQualification: 'string',
      taxPayerValidDate: 'string',
      telephone: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstShopInfo extends $tea.Model {
  inDoorImages?: string[];
  outDoorImages?: string[];
  static names(): { [key: string]: string } {
    return {
      inDoorImages: 'inDoorImages',
      outDoorImages: 'outDoorImages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inDoorImages: { 'type': 'array', 'itemType': 'string' },
      outDoorImages: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserCodeInstanceRequestAvailableTimes extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * yyyy-MM-dd HH:mm:ss
   */
  gmtEnd?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * yyyy-MM-dd HH:mm:ss
   */
  gmtStart?: string;
  static names(): { [key: string]: string } {
    return {
      gmtEnd: 'gmtEnd',
      gmtStart: 'gmtStart',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtEnd: 'string',
      gmtStart: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestContactInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 李某某
   */
  contactName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13900000000
   */
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      contactName: 'contactName',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactName: 'string',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestLegalPersonCertInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  certBackImage?: string;
  /**
   * @example
   * ossUrl
   */
  certFrontImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 李某某
   */
  certName?: string;
  /**
   * @example
   * 100
   */
  certType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 330104200010109999
   */
  idCardNo?: string;
  static names(): { [key: string]: string } {
    return {
      certBackImage: 'certBackImage',
      certFrontImage: 'certFrontImage',
      certName: 'certName',
      certType: 'certType',
      idCardNo: 'idCardNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certBackImage: 'string',
      certFrontImage: 'string',
      certName: 'string',
      certType: 'string',
      idCardNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestQualificationInfos extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ossUrl
   */
  qualificationImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 301
   */
  qualificationType?: string;
  static names(): { [key: string]: string } {
    return {
      qualificationImage: 'qualificationImage',
      qualificationType: 'qualificationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      qualificationImage: 'string',
      qualificationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSettleInfo extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 622202120200000000
   */
  accountId?: string;
  /**
   * @example
   * 李某某
   */
  accountName?: string;
  /**
   * @example
   * DEBIT_CARD
   */
  accountType?: string;
  /**
   * @example
   * 城东支行
   */
  bankBranchName?: string;
  /**
   * @example
   * 杭州市
   */
  bankCity?: string;
  /**
   * @example
   * 313791000023
   */
  bankCode?: string;
  /**
   * @example
   * 工商银行
   */
  bankName?: string;
  /**
   * @example
   * 浙江省
   */
  bankProvince?: string;
  /**
   * @example
   * ICBC
   */
  bankShortNameCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  type?: string;
  /**
   * @example
   * TO_PRI
   */
  usageType?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      accountName: 'accountName',
      accountType: 'accountType',
      bankBranchName: 'bankBranchName',
      bankCity: 'bankCity',
      bankCode: 'bankCode',
      bankName: 'bankName',
      bankProvince: 'bankProvince',
      bankShortNameCode: 'bankShortNameCode',
      type: 'type',
      usageType: 'usageType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      accountName: 'string',
      accountType: 'string',
      bankBranchName: 'string',
      bankCity: 'string',
      bankCode: 'string',
      bankName: 'string',
      bankProvince: 'string',
      bankShortNameCode: 'string',
      type: 'string',
      usageType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstAddressInfo extends $tea.Model {
  /**
   * @example
   * 未来park
   */
  address?: string;
  /**
   * @example
   * 330100
   */
  cityCode?: string;
  /**
   * @example
   * 330104
   */
  districtCode?: string;
  /**
   * @example
   * 330000
   */
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      cityCode: 'string',
      districtCode: 'string',
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstAuthInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  authorizationLetterUrl?: string;
  static names(): { [key: string]: string } {
    return {
      authorizationLetterUrl: 'authorizationLetterUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorizationLetterUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstBasicInfo extends $tea.Model {
  /**
   * @example
   * 一食堂
   */
  aliasName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5812
   */
  mcc?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 食堂
   */
  subInstName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 01
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      aliasName: 'aliasName',
      mcc: 'mcc',
      subInstName: 'subInstName',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      aliasName: 'string',
      mcc: 'string',
      subInstName: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstCertifyInfo extends $tea.Model {
  /**
   * @example
   * ossUrl
   */
  certImage?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 331081198611111111
   */
  certNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 201
   */
  certType?: string;
  static names(): { [key: string]: string } {
    return {
      certImage: 'certImage',
      certNo: 'certNo',
      certType: 'certType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certImage: 'string',
      certNo: 'string',
      certType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress extends $tea.Model {
  /**
   * @example
   * 未来park
   */
  address?: string;
  /**
   * @example
   * 330100
   */
  cityCode?: string;
  /**
   * @example
   * 330104
   */
  districtCode?: string;
  /**
   * @example
   * 330000
   */
  provinceCode?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      provinceCode: 'provinceCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: 'string',
      cityCode: 'string',
      districtCode: 'string',
      provinceCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstInvoiceInfo extends $tea.Model {
  /**
   * @example
   * true
   */
  acceptElectronic?: boolean;
  /**
   * @example
   * 浙江省杭州市西湖区西溪路蚂蚁金服
   */
  address?: string;
  /**
   * @example
   * false
   */
  autoInvoice?: boolean;
  /**
   * @example
   * 1234567812345678123
   */
  bankAccount?: string;
  /**
   * @example
   * 中国银行
   */
  bankName?: string;
  mailAddress?: ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress;
  /**
   * @example
   * 张三
   */
  mailName?: string;
  /**
   * @example
   * 057162288888
   */
  mailPhone?: string;
  /**
   * @example
   * 51010482542598631219
   */
  taxNo?: string;
  /**
   * @example
   * 01
   */
  taxPayerQualification?: string;
  /**
   * @example
   * 19981011
   */
  taxPayerValidDate?: string;
  /**
   * @example
   * 057162288888
   */
  telephone?: string;
  /**
   * @example
   * **有限公司
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      acceptElectronic: 'acceptElectronic',
      address: 'address',
      autoInvoice: 'autoInvoice',
      bankAccount: 'bankAccount',
      bankName: 'bankName',
      mailAddress: 'mailAddress',
      mailName: 'mailName',
      mailPhone: 'mailPhone',
      taxNo: 'taxNo',
      taxPayerQualification: 'taxPayerQualification',
      taxPayerValidDate: 'taxPayerValidDate',
      telephone: 'telephone',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      acceptElectronic: 'boolean',
      address: 'string',
      autoInvoice: 'boolean',
      bankAccount: 'string',
      bankName: 'string',
      mailAddress: ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress,
      mailName: 'string',
      mailPhone: 'string',
      taxNo: 'string',
      taxPayerQualification: 'string',
      taxPayerValidDate: 'string',
      telephone: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstShopInfo extends $tea.Model {
  inDoorImages?: string[];
  outDoorImages?: string[];
  static names(): { [key: string]: string } {
    return {
      inDoorImages: 'inDoorImages',
      outDoorImages: 'outDoorImages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inDoorImages: { 'type': 'array', 'itemType': 'string' },
      outDoorImages: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 金额
   */
  amount?: string;
  /**
   * @example
   * {"key":"value"}
   */
  extInfo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 优惠券
   */
  fundToolName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-01-01
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-01-01 11:11:11
   */
  gmtFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  promotionFundTool?: boolean;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      extInfo: 'extInfo',
      fundToolName: 'fundToolName',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      promotionFundTool: 'promotionFundTool',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      extInfo: 'string',
      fundToolName: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      promotionFundTool: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodePayResultRequestPayChannelDetailList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.23
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fundToolDetailList?: NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList[];
  /**
   * @example
   * 2021-01-01 11:11:11
   */
  gmtCreate?: string;
  /**
   * @example
   * 2021-01-01 11:11:11
   */
  gmtFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 卡余额
   */
  payChannelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20211234
   */
  payChannelOrderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY|BALANCE
   */
  payChannelType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.00
   */
  promotionAmount?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      fundToolDetailList: 'fundToolDetailList',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      payChannelName: 'payChannelName',
      payChannelOrderNo: 'payChannelOrderNo',
      payChannelType: 'payChannelType',
      promotionAmount: 'promotionAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList },
      gmtCreate: 'string',
      gmtFinish: 'string',
      payChannelName: 'string',
      payChannelOrderNo: 'string',
      payChannelType: 'string',
      promotionAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  amount?: string;
  extInfo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 余额
   */
  fundToolName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-05-31 11:11:11
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-05-31 11:11:11
   */
  gmtFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  promotionFundTool?: boolean;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      extInfo: 'extInfo',
      fundToolName: 'fundToolName',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      promotionFundTool: 'promotionFundTool',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      extInfo: 'string',
      fundToolName: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      promotionFundTool: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodeRefundResultRequestPayChannelDetailList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fundToolDetailList?: NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannelName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210531123456
   */
  payChannelOrderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021053112345678
   */
  payChannelRefundOrderNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payChannelType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.00
   */
  promotionAmount?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      fundToolDetailList: 'fundToolDetailList',
      payChannelName: 'payChannelName',
      payChannelOrderNo: 'payChannelOrderNo',
      payChannelRefundOrderNo: 'payChannelRefundOrderNo',
      payChannelType: 'payChannelType',
      promotionAmount: 'promotionAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList },
      payChannelName: 'string',
      payChannelOrderNo: 'string',
      payChannelRefundOrderNo: 'string',
      payChannelType: 'string',
      promotionAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCreateGroupBillOrderRequestBillItemList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5.12
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cshadbikahdksnajhada
   */
  payerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      payerUnionId: 'payerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      payerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PreCreateGroupBillOrderResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 2023100914312930910100002107362525
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

export class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  amount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210909153300000002734746770740
   */
  detailNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-29 14:46:48
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-29 16:05:00
   */
  gmtFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试
   */
  memo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 收款人
   */
  payeeAccountName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 13900000000
   */
  payeeAccountNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ALIPAY
   */
  payeeAccountType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  serialNo?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      detailNo: 'detailNo',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      memo: 'memo',
      payeeAccountName: 'payeeAccountName',
      payeeAccountNo: 'payeeAccountNo',
      payeeAccountType: 'payeeAccountType',
      serialNo: 'serialNo',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'string',
      detailNo: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      memo: 'string',
      payeeAccountName: 'string',
      payeeAccountNo: 'string',
      payeeAccountType: 'string',
      serialNo: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021090102102122200002121
   */
  alipayTransId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  failAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  failCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 收款人不存在
   */
  failReason?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-01 12:00:00
   */
  gmtFinish?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2021-09-01 11:00:00
   */
  gmtSubmit?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210901001
   */
  outBatchNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 213654465
   */
  payerStaffId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  paymentAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * CNY
   */
  paymentCurrency?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SUCCESS
   */
  status?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  successAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  successCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1.00
   */
  totalAmount?: string;
  static names(): { [key: string]: string } {
    return {
      alipayTransId: 'alipayTransId',
      failAmount: 'failAmount',
      failCount: 'failCount',
      failReason: 'failReason',
      gmtFinish: 'gmtFinish',
      gmtSubmit: 'gmtSubmit',
      outBatchNo: 'outBatchNo',
      payerStaffId: 'payerStaffId',
      paymentAmount: 'paymentAmount',
      paymentCurrency: 'paymentCurrency',
      status: 'status',
      successAmount: 'successAmount',
      successCount: 'successCount',
      totalAmount: 'totalAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayTransId: 'string',
      failAmount: 'string',
      failCount: 'number',
      failReason: 'string',
      gmtFinish: 'string',
      gmtSubmit: 'string',
      outBatchNo: 'string',
      payerStaffId: 'string',
      paymentAmount: 'string',
      paymentCurrency: 'string',
      status: 'string',
      successAmount: 'string',
      successCount: 'number',
      totalAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayAccountListResponseBodyPayAccountVOList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * B
   */
  accountClass?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20210912001
   */
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * test
   */
  accountName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 139****1
   */
  accountNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备注
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
  static names(): { [key: string]: string } {
    return {
      accountClass: 'accountClass',
      accountId: 'accountId',
      accountName: 'accountName',
      accountNo: 'accountNo',
      accountRemark: 'accountRemark',
      accountType: 'accountType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountClass: 'string',
      accountId: 'string',
      accountName: 'string',
      accountNo: 'string',
      accountRemark: 'string',
      accountType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpateUserCodeInstanceRequestAvailableTimes extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * yyyy-MM-dd HH:mm:ss
   */
  gmtEnd?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * yyyy-MM-dd HH:mm:ss
   */
  gmtStart?: string;
  static names(): { [key: string]: string } {
    return {
      gmtEnd: 'gmtEnd',
      gmtStart: 'gmtStart',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtEnd: 'string',
      gmtStart: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceRequestExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TRIP
   */
  bizCode?: string;
  /**
   * @example
   * 111924191922
   * 
   * @deprecated
   */
  orderNo?: string;
  orderNoList?: string[];
  /**
   * @example
   * HOTEL
   */
  orderType?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      orderNo: 'orderNo',
      orderNoList: 'orderNoList',
      orderType: 'orderType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      orderNo: 'string',
      orderNoList: { 'type': 'array', 'itemType': 'string' },
      orderType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceRequestInvoices extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100.00
   */
  invoiceAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 033002000712
   */
  invoiceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-02-21
   */
  invoiceDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20532643
   */
  invoiceNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  invoiceType?: string;
  logoUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 小钉科技有限公司
   */
  payeeName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 91330100MA28XNB274
   */
  payeeTaxNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 小钉科技有限公司
   */
  payerName?: string;
  /**
   * @example
   * 91330100MA28XNB274
   */
  payerTaxNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pdfUrl?: string;
  /**
   * @example
   * 0.50
   */
  taxAmount?: string;
  /**
   * @example
   * 增值税普通发票必填，示例：52501101414266612380
   */
  verifyCode?: string;
  /**
   * @example
   * 99.50
   */
  withoutTaxAmount?: string;
  static names(): { [key: string]: string } {
    return {
      invoiceAmount: 'invoiceAmount',
      invoiceCode: 'invoiceCode',
      invoiceDate: 'invoiceDate',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      logoUrl: 'logoUrl',
      payeeName: 'payeeName',
      payeeTaxNo: 'payeeTaxNo',
      payerName: 'payerName',
      payerTaxNo: 'payerTaxNo',
      pdfUrl: 'pdfUrl',
      taxAmount: 'taxAmount',
      verifyCode: 'verifyCode',
      withoutTaxAmount: 'withoutTaxAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoiceAmount: 'string',
      invoiceCode: 'string',
      invoiceDate: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      logoUrl: 'string',
      payeeName: 'string',
      payeeTaxNo: 'string',
      payerName: 'string',
      payerTaxNo: 'string',
      pdfUrl: 'string',
      taxAmount: 'string',
      verifyCode: 'string',
      withoutTaxAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceRequestUserIdentity extends $tea.Model {
  /**
   * @example
   * 95188
   */
  mobile?: string;
  /**
   * @example
   * 86
   */
  mobileStateCode?: string;
  /**
   * @example
   * dinng1123434
   */
  targetCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * STAFF_ID
   */
  type?: string;
  /**
   * @example
   * akdfwiiw
   */
  unionId?: string;
  /**
   * @example
   * 02734930
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      mobile: 'mobile',
      mobileStateCode: 'mobileStateCode',
      targetCorpId: 'targetCorpId',
      type: 'type',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobile: 'string',
      mobileStateCode: 'string',
      targetCorpId: 'string',
      type: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceResponseBodyResultResults extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20006
   */
  errCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 033002000712
   */
  invoiceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20532643
   */
  invoiceNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * duplicateInvoice
   */
  reason?: string;
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
      errCode: 'errCode',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      reason: 'reason',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errCode: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      reason: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  results?: UploadInvoiceResponseBodyResultResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': UploadInvoiceResponseBodyResultResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthRequestExtension extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TRIP
   */
  bizCode?: string;
  /**
   * @example
   * 111924191922
   */
  orderNo?: string;
  /**
   * @example
   * HOTEL
   */
  orderType?: string;
  static names(): { [key: string]: string } {
    return {
      bizCode: 'bizCode',
      orderNo: 'orderNo',
      orderType: 'orderType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCode: 'string',
      orderNo: 'string',
      orderType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthRequestInvoices extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100.00
   */
  invoiceAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 033002000712
   */
  invoiceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-02-21
   */
  invoiceDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20532643
   */
  invoiceNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  invoiceType?: string;
  logoUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 小钉科技有限公司
   */
  payeeName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 91330100MA28XNB274
   */
  payeeTaxNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 小钉科技有限公司
   */
  payerName?: string;
  /**
   * @example
   * 91330100MA28XNB274
   */
  payerTaxNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pdfUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.50
   */
  taxAmount?: string;
  /**
   * @example
   * 增值税普通发票必填，示例：52501101414266612380
   */
  verifyCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 99.50
   */
  withoutTaxAmount?: string;
  static names(): { [key: string]: string } {
    return {
      invoiceAmount: 'invoiceAmount',
      invoiceCode: 'invoiceCode',
      invoiceDate: 'invoiceDate',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      logoUrl: 'logoUrl',
      payeeName: 'payeeName',
      payeeTaxNo: 'payeeTaxNo',
      payerName: 'payerName',
      payerTaxNo: 'payerTaxNo',
      pdfUrl: 'pdfUrl',
      taxAmount: 'taxAmount',
      verifyCode: 'verifyCode',
      withoutTaxAmount: 'withoutTaxAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoiceAmount: 'string',
      invoiceCode: 'string',
      invoiceDate: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      logoUrl: 'string',
      payeeName: 'string',
      payeeTaxNo: 'string',
      payerName: 'string',
      payerTaxNo: 'string',
      pdfUrl: 'string',
      taxAmount: 'string',
      verifyCode: 'string',
      withoutTaxAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthResponseBodyResultResults extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20006
   */
  errCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 033002000712
   */
  invoiceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20532643
   */
  invoiceNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * duplicateInvoice
   */
  reason?: string;
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
      errCode: 'errCode',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      reason: 'reason',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errCode: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      reason: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByAuthResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  results?: UploadInvoiceByAuthResponseBodyResultResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': UploadInvoiceByAuthResponseBodyResultResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByMobileRequestInvoices extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100.00
   */
  invoiceAmount?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 033002000712
   */
  invoiceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2022-02-21
   */
  invoiceDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20532643
   */
  invoiceNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  invoiceType?: string;
  logoUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 小钉科技有限公司
   */
  payeeName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 91330100MA28XNB274
   */
  payeeTaxNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 小钉科技有限公司
   */
  payerName?: string;
  /**
   * @example
   * 91330100MA28XNB274
   */
  payerTaxNo?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  pdfUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.50
   */
  taxAmount?: string;
  /**
   * @example
   * 增值税普通发票必填，示例：52501101414266612380
   */
  verifyCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 99.50
   */
  withoutTaxAmount?: string;
  static names(): { [key: string]: string } {
    return {
      invoiceAmount: 'invoiceAmount',
      invoiceCode: 'invoiceCode',
      invoiceDate: 'invoiceDate',
      invoiceNo: 'invoiceNo',
      invoiceType: 'invoiceType',
      logoUrl: 'logoUrl',
      payeeName: 'payeeName',
      payeeTaxNo: 'payeeTaxNo',
      payerName: 'payerName',
      payerTaxNo: 'payerTaxNo',
      pdfUrl: 'pdfUrl',
      taxAmount: 'taxAmount',
      verifyCode: 'verifyCode',
      withoutTaxAmount: 'withoutTaxAmount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      invoiceAmount: 'string',
      invoiceCode: 'string',
      invoiceDate: 'string',
      invoiceNo: 'string',
      invoiceType: 'string',
      logoUrl: 'string',
      payeeName: 'string',
      payeeTaxNo: 'string',
      payerName: 'string',
      payerTaxNo: 'string',
      pdfUrl: 'string',
      taxAmount: 'string',
      verifyCode: 'string',
      withoutTaxAmount: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByMobileResponseBodyResultResults extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20006
   */
  errCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 033002000712
   */
  invoiceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20532643
   */
  invoiceNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * duplicateInvoice
   */
  reason?: string;
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
      errCode: 'errCode',
      invoiceCode: 'invoiceCode',
      invoiceNo: 'invoiceNo',
      reason: 'reason',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errCode: 'string',
      invoiceCode: 'string',
      invoiceNo: 'string',
      reason: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadInvoiceByMobileResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  results?: UploadInvoiceByMobileResponseBodyResultResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': UploadInvoiceByMobileResponseBodyResultResults },
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
   * 批量付款
   * 
   * @param request - ApplyBatchPayRequest
   * @param headers - ApplyBatchPayHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ApplyBatchPayResponse
   */
  async applyBatchPayWithOptions(request: ApplyBatchPayRequest, headers: ApplyBatchPayHeaders, runtime: $Util.RuntimeOptions): Promise<ApplyBatchPayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.passBackParams)) {
      body["passBackParams"] = request.passBackParams;
    }

    if (!Util.isUnset(request.payTerminal)) {
      body["payTerminal"] = request.payTerminal;
    }

    if (!Util.isUnset(request.returnUrl)) {
      body["returnUrl"] = request.returnUrl;
    }

    if (!Util.isUnset(request.staffId)) {
      body["staffId"] = request.staffId;
    }

    if (!Util.isUnset(request.transAmount)) {
      body["transAmount"] = request.transAmount;
    }

    if (!Util.isUnset(request.transExpireTime)) {
      body["transExpireTime"] = request.transExpireTime;
    }

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
      action: "ApplyBatchPay",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/batchTrades/orders/pay`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ApplyBatchPayResponse>(await this.execute(params, req, runtime), new ApplyBatchPayResponse({}));
  }

  /**
   * 批量付款
   * 
   * @param request - ApplyBatchPayRequest
   * @returns ApplyBatchPayResponse
   */
  async applyBatchPay(request: ApplyBatchPayRequest): Promise<ApplyBatchPayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApplyBatchPayHeaders({ });
    return await this.applyBatchPayWithOptions(request, headers, runtime);
  }

  /**
   * 助贷业务关闭借款入口
   * 
   * @param request - CloseLoanEntranceRequest
   * @param headers - CloseLoanEntranceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CloseLoanEntranceResponse
   */
  async closeLoanEntranceWithOptions(request: CloseLoanEntranceRequest, headers: CloseLoanEntranceHeaders, runtime: $Util.RuntimeOptions): Promise<CloseLoanEntranceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.requestId)) {
      body["requestId"] = request.requestId;
    }

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
      action: "CloseLoanEntrance",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/loans/entrances/close`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CloseLoanEntranceResponse>(await this.execute(params, req, runtime), new CloseLoanEntranceResponse({}));
  }

  /**
   * 助贷业务关闭借款入口
   * 
   * @param request - CloseLoanEntranceRequest
   * @returns CloseLoanEntranceResponse
   */
  async closeLoanEntrance(request: CloseLoanEntranceRequest): Promise<CloseLoanEntranceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseLoanEntranceHeaders({ });
    return await this.closeLoanEntranceWithOptions(request, headers, runtime);
  }

  /**
   * 子机构创建进件预校验
   * 
   * @param request - ConsultCreateSubInstitutionRequest
   * @param headers - ConsultCreateSubInstitutionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConsultCreateSubInstitutionResponse
   */
  async consultCreateSubInstitutionWithOptions(request: ConsultCreateSubInstitutionRequest, headers: ConsultCreateSubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<ConsultCreateSubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset(request.contactInfo)) {
      body["contactInfo"] = request.contactInfo;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.legalPersonCertInfo)) {
      body["legalPersonCertInfo"] = request.legalPersonCertInfo;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.qualificationInfos)) {
      body["qualificationInfos"] = request.qualificationInfos;
    }

    if (!Util.isUnset(request.services)) {
      body["services"] = request.services;
    }

    if (!Util.isUnset(request.settleInfo)) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset(request.solution)) {
      body["solution"] = request.solution;
    }

    if (!Util.isUnset(request.subInstAddressInfo)) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset(request.subInstAuthInfo)) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset(request.subInstBasicInfo)) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset(request.subInstCertifyInfo)) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.subInstInvoiceInfo)) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset(request.subInstShopInfo)) {
      body["subInstShopInfo"] = request.subInstShopInfo;
    }

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
      action: "ConsultCreateSubInstitution",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/institutions/subInstitutions/consult`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConsultCreateSubInstitutionResponse>(await this.execute(params, req, runtime), new ConsultCreateSubInstitutionResponse({}));
  }

  /**
   * 子机构创建进件预校验
   * 
   * @param request - ConsultCreateSubInstitutionRequest
   * @returns ConsultCreateSubInstitutionResponse
   */
  async consultCreateSubInstitution(request: ConsultCreateSubInstitutionRequest): Promise<ConsultCreateSubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsultCreateSubInstitutionHeaders({ });
    return await this.consultCreateSubInstitutionWithOptions(request, headers, runtime);
  }

  /**
   * 发起代扣交易
   * 
   * @param request - CreatWithholdingOrderAndPayRequest
   * @param headers - CreatWithholdingOrderAndPayHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreatWithholdingOrderAndPayResponse
   */
  async creatWithholdingOrderAndPayWithOptions(request: CreatWithholdingOrderAndPayRequest, headers: CreatWithholdingOrderAndPayHeaders, runtime: $Util.RuntimeOptions): Promise<CreatWithholdingOrderAndPayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.amount)) {
      body["amount"] = request.amount;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.otherPayChannelDetailInfoList)) {
      body["otherPayChannelDetailInfoList"] = request.otherPayChannelDetailInfoList;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.payerUserId)) {
      body["payerUserId"] = request.payerUserId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.timeOutExpress)) {
      body["timeOutExpress"] = request.timeOutExpress;
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
      action: "CreatWithholdingOrderAndPay",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/withholdingOrders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreatWithholdingOrderAndPayResponse>(await this.execute(params, req, runtime), new CreatWithholdingOrderAndPayResponse({}));
  }

  /**
   * 发起代扣交易
   * 
   * @param request - CreatWithholdingOrderAndPayRequest
   * @returns CreatWithholdingOrderAndPayResponse
   */
  async creatWithholdingOrderAndPay(request: CreatWithholdingOrderAndPayRequest): Promise<CreatWithholdingOrderAndPayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatWithholdingOrderAndPayHeaders({ });
    return await this.creatWithholdingOrderAndPayWithOptions(request, headers, runtime);
  }

  /**
   * 收单退款交易
   * 
   * @param request - CreateAcquireRefundOrderRequest
   * @param headers - CreateAcquireRefundOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateAcquireRefundOrderResponse
   */
  async createAcquireRefundOrderWithOptions(request: CreateAcquireRefundOrderRequest, headers: CreateAcquireRefundOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAcquireRefundOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.operatorUserId)) {
      body["operatorUserId"] = request.operatorUserId;
    }

    if (!Util.isUnset(request.originOutTradeNo)) {
      body["originOutTradeNo"] = request.originOutTradeNo;
    }

    if (!Util.isUnset(request.otherPayChannelDetailInfoList)) {
      body["otherPayChannelDetailInfoList"] = request.otherPayChannelDetailInfoList;
    }

    if (!Util.isUnset(request.outRefundNo)) {
      body["outRefundNo"] = request.outRefundNo;
    }

    if (!Util.isUnset(request.refundAmount)) {
      body["refundAmount"] = request.refundAmount;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
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
      action: "CreateAcquireRefundOrder",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/acquireOrders/refund`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAcquireRefundOrderResponse>(await this.execute(params, req, runtime), new CreateAcquireRefundOrderResponse({}));
  }

  /**
   * 收单退款交易
   * 
   * @param request - CreateAcquireRefundOrderRequest
   * @returns CreateAcquireRefundOrderResponse
   */
  async createAcquireRefundOrder(request: CreateAcquireRefundOrderRequest): Promise<CreateAcquireRefundOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAcquireRefundOrderHeaders({ });
    return await this.createAcquireRefundOrderWithOptions(request, headers, runtime);
  }

  /**
   * 创建批量支付单
   * 
   * @param request - CreateBatchTradeOrderRequest
   * @param headers - CreateBatchTradeOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateBatchTradeOrderResponse
   */
  async createBatchTradeOrderWithOptions(request: CreateBatchTradeOrderRequest, headers: CreateBatchTradeOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CreateBatchTradeOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.accountNo)) {
      body["accountNo"] = request.accountNo;
    }

    if (!Util.isUnset(request.batchRemark)) {
      body["batchRemark"] = request.batchRemark;
    }

    if (!Util.isUnset(request.batchTradeDetails)) {
      body["batchTradeDetails"] = request.batchTradeDetails;
    }

    if (!Util.isUnset(request.outBatchNo)) {
      body["outBatchNo"] = request.outBatchNo;
    }

    if (!Util.isUnset(request.staffId)) {
      body["staffId"] = request.staffId;
    }

    if (!Util.isUnset(request.totalAmount)) {
      body["totalAmount"] = request.totalAmount;
    }

    if (!Util.isUnset(request.totalCount)) {
      body["totalCount"] = request.totalCount;
    }

    if (!Util.isUnset(request.tradeTitle)) {
      body["tradeTitle"] = request.tradeTitle;
    }

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
      action: "CreateBatchTradeOrder",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/batchTrades/orders`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateBatchTradeOrderResponse>(await this.execute(params, req, runtime), new CreateBatchTradeOrderResponse({}));
  }

  /**
   * 创建批量支付单
   * 
   * @param request - CreateBatchTradeOrderRequest
   * @returns CreateBatchTradeOrderResponse
   */
  async createBatchTradeOrder(request: CreateBatchTradeOrderRequest): Promise<CreateBatchTradeOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBatchTradeOrderHeaders({ });
    return await this.createBatchTradeOrderWithOptions(request, headers, runtime);
  }

  /**
   * 创建子机构
   * 
   * @param request - CreateSubInstitutionRequest
   * @param headers - CreateSubInstitutionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateSubInstitutionResponse
   */
  async createSubInstitutionWithOptions(request: CreateSubInstitutionRequest, headers: CreateSubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset(request.contactInfo)) {
      body["contactInfo"] = request.contactInfo;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.legalPersonCertInfo)) {
      body["legalPersonCertInfo"] = request.legalPersonCertInfo;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.qualificationInfos)) {
      body["qualificationInfos"] = request.qualificationInfos;
    }

    if (!Util.isUnset(request.services)) {
      body["services"] = request.services;
    }

    if (!Util.isUnset(request.settleInfo)) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset(request.solution)) {
      body["solution"] = request.solution;
    }

    if (!Util.isUnset(request.subInstAddressInfo)) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset(request.subInstAuthInfo)) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset(request.subInstBasicInfo)) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset(request.subInstCertifyInfo)) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.subInstInvoiceInfo)) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset(request.subInstShopInfo)) {
      body["subInstShopInfo"] = request.subInstShopInfo;
    }

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
      action: "CreateSubInstitution",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/institutions/subInstitutions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSubInstitutionResponse>(await this.execute(params, req, runtime), new CreateSubInstitutionResponse({}));
  }

  /**
   * 创建子机构
   * 
   * @param request - CreateSubInstitutionRequest
   * @returns CreateSubInstitutionResponse
   */
  async createSubInstitution(request: CreateSubInstitutionRequest): Promise<CreateSubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSubInstitutionHeaders({ });
    return await this.createSubInstitutionWithOptions(request, headers, runtime);
  }

  /**
   * 创建用户码实例
   * 
   * @param request - CreateUserCodeInstanceRequest
   * @param headers - CreateUserCodeInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateUserCodeInstanceResponse
   */
  async createUserCodeInstanceWithOptions(request: CreateUserCodeInstanceRequest, headers: CreateUserCodeInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUserCodeInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.availableTimes)) {
      body["availableTimes"] = request.availableTimes;
    }

    if (!Util.isUnset(request.codeIdentity)) {
      body["codeIdentity"] = request.codeIdentity;
    }

    if (!Util.isUnset(request.codeValue)) {
      body["codeValue"] = request.codeValue;
    }

    if (!Util.isUnset(request.codeValueType)) {
      body["codeValueType"] = request.codeValueType;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.gmtExpired)) {
      body["gmtExpired"] = request.gmtExpired;
    }

    if (!Util.isUnset(request.requestId)) {
      body["requestId"] = request.requestId;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.userCorpRelationType)) {
      body["userCorpRelationType"] = request.userCorpRelationType;
    }

    if (!Util.isUnset(request.userIdentity)) {
      body["userIdentity"] = request.userIdentity;
    }

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
      action: "CreateUserCodeInstance",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payCodes/userInstances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateUserCodeInstanceResponse>(await this.execute(params, req, runtime), new CreateUserCodeInstanceResponse({}));
  }

  /**
   * 创建用户码实例
   * 
   * @param request - CreateUserCodeInstanceRequest
   * @returns CreateUserCodeInstanceResponse
   */
  async createUserCodeInstance(request: CreateUserCodeInstanceRequest): Promise<CreateUserCodeInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUserCodeInstanceHeaders({ });
    return await this.createUserCodeInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 解码付款码
   * 
   * @param request - DecodePayCodeRequest
   * @param headers - DecodePayCodeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DecodePayCodeResponse
   */
  async decodePayCodeWithOptions(request: DecodePayCodeRequest, headers: DecodePayCodeHeaders, runtime: $Util.RuntimeOptions): Promise<DecodePayCodeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.payCode)) {
      body["payCode"] = request.payCode;
    }

    if (!Util.isUnset(request.requestId)) {
      body["requestId"] = request.requestId;
    }

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
      action: "DecodePayCode",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payCodes/decode`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DecodePayCodeResponse>(await this.execute(params, req, runtime), new DecodePayCodeResponse({}));
  }

  /**
   * 解码付款码
   * 
   * @param request - DecodePayCodeRequest
   * @returns DecodePayCodeResponse
   */
  async decodePayCode(request: DecodePayCodeRequest): Promise<DecodePayCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DecodePayCodeHeaders({ });
    return await this.decodePayCodeWithOptions(request, headers, runtime);
  }

  /**
   * 企业金融助贷业务进件通知接口
   * 
   * @param request - FinanceLoanNotifyRegisterRequest
   * @param headers - FinanceLoanNotifyRegisterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FinanceLoanNotifyRegisterResponse
   */
  async financeLoanNotifyRegisterWithOptions(request: FinanceLoanNotifyRegisterRequest, headers: FinanceLoanNotifyRegisterHeaders, runtime: $Util.RuntimeOptions): Promise<FinanceLoanNotifyRegisterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.completeTime)) {
      body["completeTime"] = request.completeTime;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.idCardNo)) {
      body["idCardNo"] = request.idCardNo;
    }

    if (!Util.isUnset(request.openChannelName)) {
      body["openChannelName"] = request.openChannelName;
    }

    if (!Util.isUnset(request.openProductCode)) {
      body["openProductCode"] = request.openProductCode;
    }

    if (!Util.isUnset(request.openProductName)) {
      body["openProductName"] = request.openProductName;
    }

    if (!Util.isUnset(request.openProductType)) {
      body["openProductType"] = request.openProductType;
    }

    if (!Util.isUnset(request.processingStatus)) {
      body["processingStatus"] = request.processingStatus;
    }

    if (!Util.isUnset(request.refuseCode)) {
      body["refuseCode"] = request.refuseCode;
    }

    if (!Util.isUnset(request.refuseReason)) {
      body["refuseReason"] = request.refuseReason;
    }

    if (!Util.isUnset(request.registerNo)) {
      body["registerNo"] = request.registerNo;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.submitTime)) {
      body["submitTime"] = request.submitTime;
    }

    if (!Util.isUnset(request.userMobile)) {
      body["userMobile"] = request.userMobile;
    }

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
      action: "FinanceLoanNotifyRegister",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/loans/notifications/register`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FinanceLoanNotifyRegisterResponse>(await this.execute(params, req, runtime), new FinanceLoanNotifyRegisterResponse({}));
  }

  /**
   * 企业金融助贷业务进件通知接口
   * 
   * @param request - FinanceLoanNotifyRegisterRequest
   * @returns FinanceLoanNotifyRegisterResponse
   */
  async financeLoanNotifyRegister(request: FinanceLoanNotifyRegisterRequest): Promise<FinanceLoanNotifyRegisterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinanceLoanNotifyRegisterHeaders({ });
    return await this.financeLoanNotifyRegisterWithOptions(request, headers, runtime);
  }

  /**
   * 修改子机构信息
   * 
   * @param request - ModifySubInstitutionRequest
   * @param headers - ModifySubInstitutionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ModifySubInstitutionResponse
   */
  async modifySubInstitutionWithOptions(request: ModifySubInstitutionRequest, headers: ModifySubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<ModifySubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset(request.contactInfo)) {
      body["contactInfo"] = request.contactInfo;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.legalPersonCertInfo)) {
      body["legalPersonCertInfo"] = request.legalPersonCertInfo;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.qualificationInfos)) {
      body["qualificationInfos"] = request.qualificationInfos;
    }

    if (!Util.isUnset(request.services)) {
      body["services"] = request.services;
    }

    if (!Util.isUnset(request.settleInfo)) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset(request.subInstAddressInfo)) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset(request.subInstAuthInfo)) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset(request.subInstBasicInfo)) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset(request.subInstCertifyInfo)) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.subInstInvoiceInfo)) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset(request.subInstShopInfo)) {
      body["subInstShopInfo"] = request.subInstShopInfo;
    }

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
      action: "ModifySubInstitution",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/institutions/subInstitutions/modify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ModifySubInstitutionResponse>(await this.execute(params, req, runtime), new ModifySubInstitutionResponse({}));
  }

  /**
   * 修改子机构信息
   * 
   * @param request - ModifySubInstitutionRequest
   * @returns ModifySubInstitutionResponse
   */
  async modifySubInstitution(request: ModifySubInstitutionRequest): Promise<ModifySubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifySubInstitutionHeaders({ });
    return await this.modifySubInstitutionWithOptions(request, headers, runtime);
  }

  /**
   * 通知付款码支付结果
   * 
   * @param request - NotifyPayCodePayResultRequest
   * @param headers - NotifyPayCodePayResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns NotifyPayCodePayResultResponse
   */
  async notifyPayCodePayResultWithOptions(request: NotifyPayCodePayResultRequest, headers: NotifyPayCodePayResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyPayCodePayResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.amount)) {
      body["amount"] = request.amount;
    }

    if (!Util.isUnset(request.chargeAmount)) {
      body["chargeAmount"] = request.chargeAmount;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.gmtTradeCreate)) {
      body["gmtTradeCreate"] = request.gmtTradeCreate;
    }

    if (!Util.isUnset(request.gmtTradeFinish)) {
      body["gmtTradeFinish"] = request.gmtTradeFinish;
    }

    if (!Util.isUnset(request.merchantName)) {
      body["merchantName"] = request.merchantName;
    }

    if (!Util.isUnset(request.payChannelDetailList)) {
      body["payChannelDetailList"] = request.payChannelDetailList;
    }

    if (!Util.isUnset(request.payCode)) {
      body["payCode"] = request.payCode;
    }

    if (!Util.isUnset(request.promotionAmount)) {
      body["promotionAmount"] = request.promotionAmount;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.tradeErrorCode)) {
      body["tradeErrorCode"] = request.tradeErrorCode;
    }

    if (!Util.isUnset(request.tradeErrorMsg)) {
      body["tradeErrorMsg"] = request.tradeErrorMsg;
    }

    if (!Util.isUnset(request.tradeNo)) {
      body["tradeNo"] = request.tradeNo;
    }

    if (!Util.isUnset(request.tradeStatus)) {
      body["tradeStatus"] = request.tradeStatus;
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
      action: "NotifyPayCodePayResult",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payCodes/payResults/notify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<NotifyPayCodePayResultResponse>(await this.execute(params, req, runtime), new NotifyPayCodePayResultResponse({}));
  }

  /**
   * 通知付款码支付结果
   * 
   * @param request - NotifyPayCodePayResultRequest
   * @returns NotifyPayCodePayResultResponse
   */
  async notifyPayCodePayResult(request: NotifyPayCodePayResultRequest): Promise<NotifyPayCodePayResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyPayCodePayResultHeaders({ });
    return await this.notifyPayCodePayResultWithOptions(request, headers, runtime);
  }

  /**
   * 通知付款码退款结果
   * 
   * @param request - NotifyPayCodeRefundResultRequest
   * @param headers - NotifyPayCodeRefundResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns NotifyPayCodeRefundResultResponse
   */
  async notifyPayCodeRefundResultWithOptions(request: NotifyPayCodeRefundResultRequest, headers: NotifyPayCodeRefundResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyPayCodeRefundResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.gmtRefund)) {
      body["gmtRefund"] = request.gmtRefund;
    }

    if (!Util.isUnset(request.payChannelDetailList)) {
      body["payChannelDetailList"] = request.payChannelDetailList;
    }

    if (!Util.isUnset(request.payCode)) {
      body["payCode"] = request.payCode;
    }

    if (!Util.isUnset(request.refundAmount)) {
      body["refundAmount"] = request.refundAmount;
    }

    if (!Util.isUnset(request.refundOrderNo)) {
      body["refundOrderNo"] = request.refundOrderNo;
    }

    if (!Util.isUnset(request.refundPromotionAmount)) {
      body["refundPromotionAmount"] = request.refundPromotionAmount;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.tradeNo)) {
      body["tradeNo"] = request.tradeNo;
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
      action: "NotifyPayCodeRefundResult",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payCodes/refundResults/notify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<NotifyPayCodeRefundResultResponse>(await this.execute(params, req, runtime), new NotifyPayCodeRefundResultResponse({}));
  }

  /**
   * 通知付款码退款结果
   * 
   * @param request - NotifyPayCodeRefundResultRequest
   * @returns NotifyPayCodeRefundResultResponse
   */
  async notifyPayCodeRefundResult(request: NotifyPayCodeRefundResultRequest): Promise<NotifyPayCodeRefundResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyPayCodeRefundResultHeaders({ });
    return await this.notifyPayCodeRefundResultWithOptions(request, headers, runtime);
  }

  /**
   * 上报码验证结果
   * 
   * @param request - NotifyVerifyResultRequest
   * @param headers - NotifyVerifyResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns NotifyVerifyResultResponse
   */
  async notifyVerifyResultWithOptions(request: NotifyVerifyResultRequest, headers: NotifyVerifyResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyVerifyResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.payCode)) {
      body["payCode"] = request.payCode;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.userCorpRelationType)) {
      body["userCorpRelationType"] = request.userCorpRelationType;
    }

    if (!Util.isUnset(request.userIdentity)) {
      body["userIdentity"] = request.userIdentity;
    }

    if (!Util.isUnset(request.verifyEvent)) {
      body["verifyEvent"] = request.verifyEvent;
    }

    if (!Util.isUnset(request.verifyLocation)) {
      body["verifyLocation"] = request.verifyLocation;
    }

    if (!Util.isUnset(request.verifyNo)) {
      body["verifyNo"] = request.verifyNo;
    }

    if (!Util.isUnset(request.verifyResult)) {
      body["verifyResult"] = request.verifyResult;
    }

    if (!Util.isUnset(request.verifyTime)) {
      body["verifyTime"] = request.verifyTime;
    }

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
      action: "NotifyVerifyResult",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payCodes/verifyResults/notify`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<NotifyVerifyResultResponse>(await this.execute(params, req, runtime), new NotifyVerifyResultResponse({}));
  }

  /**
   * 上报码验证结果
   * 
   * @param request - NotifyVerifyResultRequest
   * @returns NotifyVerifyResultResponse
   */
  async notifyVerifyResult(request: NotifyVerifyResultRequest): Promise<NotifyVerifyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyVerifyResultHeaders({ });
    return await this.notifyVerifyResultWithOptions(request, headers, runtime);
  }

  /**
   * 预创建群收款订单返回订单号
   * 
   * @param request - PreCreateGroupBillOrderRequest
   * @param headers - PreCreateGroupBillOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PreCreateGroupBillOrderResponse
   */
  async preCreateGroupBillOrderWithOptions(request: PreCreateGroupBillOrderRequest, headers: PreCreateGroupBillOrderHeaders, runtime: $Util.RuntimeOptions): Promise<PreCreateGroupBillOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.billItemList)) {
      body["billItemList"] = request.billItemList;
    }

    if (!Util.isUnset(request.extParams)) {
      body["extParams"] = request.extParams;
    }

    if (!Util.isUnset(request.headCount)) {
      body["headCount"] = request.headCount;
    }

    if (!Util.isUnset(request.isAverageAmount)) {
      body["isAverageAmount"] = request.isAverageAmount;
    }

    if (!Util.isUnset(request.merchantId)) {
      body["merchantId"] = request.merchantId;
    }

    if (!Util.isUnset(request.openCid)) {
      body["openCid"] = request.openCid;
    }

    if (!Util.isUnset(request.outBizNo)) {
      body["outBizNo"] = request.outBizNo;
    }

    if (!Util.isUnset(request.payeeCorpId)) {
      body["payeeCorpId"] = request.payeeCorpId;
    }

    if (!Util.isUnset(request.payeeUnionId)) {
      body["payeeUnionId"] = request.payeeUnionId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.totalAmount)) {
      body["totalAmount"] = request.totalAmount;
    }

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
      action: "PreCreateGroupBillOrder",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/groupbills/preCreate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PreCreateGroupBillOrderResponse>(await this.execute(params, req, runtime), new PreCreateGroupBillOrderResponse({}));
  }

  /**
   * 预创建群收款订单返回订单号
   * 
   * @param request - PreCreateGroupBillOrderRequest
   * @returns PreCreateGroupBillOrderResponse
   */
  async preCreateGroupBillOrder(request: PreCreateGroupBillOrderRequest): Promise<PreCreateGroupBillOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PreCreateGroupBillOrderHeaders({ });
    return await this.preCreateGroupBillOrderWithOptions(request, headers, runtime);
  }

  /**
   * 查询收单退款交易
   * 
   * @param request - QueryAcquireRefundOrderRequest
   * @param headers - QueryAcquireRefundOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryAcquireRefundOrderResponse
   */
  async queryAcquireRefundOrderWithOptions(request: QueryAcquireRefundOrderRequest, headers: QueryAcquireRefundOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAcquireRefundOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outRefundNo)) {
      query["outRefundNo"] = request.outRefundNo;
    }

    let realHeaders : {[key: string ]: string} = { };
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
      action: "QueryAcquireRefundOrder",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/acquireOrders/refunds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryAcquireRefundOrderResponse>(await this.execute(params, req, runtime), new QueryAcquireRefundOrderResponse({}));
  }

  /**
   * 查询收单退款交易
   * 
   * @param request - QueryAcquireRefundOrderRequest
   * @returns QueryAcquireRefundOrderResponse
   */
  async queryAcquireRefundOrder(request: QueryAcquireRefundOrderRequest): Promise<QueryAcquireRefundOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAcquireRefundOrderHeaders({ });
    return await this.queryAcquireRefundOrderWithOptions(request, headers, runtime);
  }

  /**
   * 查询批量付款明细列表
   * 
   * @param request - QueryBatchTradeDetailListRequest
   * @param headers - QueryBatchTradeDetailListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBatchTradeDetailListResponse
   */
  async queryBatchTradeDetailListWithOptions(request: QueryBatchTradeDetailListRequest, headers: QueryBatchTradeDetailListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBatchTradeDetailListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outBatchNo)) {
      query["outBatchNo"] = request.outBatchNo;
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
      action: "QueryBatchTradeDetailList",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/batchTrades/details`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryBatchTradeDetailListResponse>(await this.execute(params, req, runtime), new QueryBatchTradeDetailListResponse({}));
  }

  /**
   * 查询批量付款明细列表
   * 
   * @param request - QueryBatchTradeDetailListRequest
   * @returns QueryBatchTradeDetailListResponse
   */
  async queryBatchTradeDetailList(request: QueryBatchTradeDetailListRequest): Promise<QueryBatchTradeDetailListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBatchTradeDetailListHeaders({ });
    return await this.queryBatchTradeDetailListWithOptions(request, headers, runtime);
  }

  /**
   * 根据请求对象查询批量交易订单信息
   * 
   * @param request - QueryBatchTradeOrderRequest
   * @param headers - QueryBatchTradeOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBatchTradeOrderResponse
   */
  async queryBatchTradeOrderWithOptions(request: QueryBatchTradeOrderRequest, headers: QueryBatchTradeOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBatchTradeOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outBatchNos)) {
      body["outBatchNos"] = request.outBatchNos;
    }

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
      action: "QueryBatchTradeOrder",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/batchTrades/orders/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryBatchTradeOrderResponse>(await this.execute(params, req, runtime), new QueryBatchTradeOrderResponse({}));
  }

  /**
   * 根据请求对象查询批量交易订单信息
   * 
   * @param request - QueryBatchTradeOrderRequest
   * @returns QueryBatchTradeOrderResponse
   */
  async queryBatchTradeOrder(request: QueryBatchTradeOrderRequest): Promise<QueryBatchTradeOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBatchTradeOrderHeaders({ });
    return await this.queryBatchTradeOrderWithOptions(request, headers, runtime);
  }

  /**
   * 查询付款账号列表
   * 
   * @param headers - QueryPayAccountListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryPayAccountListResponse
   */
  async queryPayAccountListWithOptions(headers: QueryPayAccountListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPayAccountListResponse> {
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
      action: "QueryPayAccountList",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payAccounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryPayAccountListResponse>(await this.execute(params, req, runtime), new QueryPayAccountListResponse({}));
  }

  /**
   * 查询付款账号列表
   * @returns QueryPayAccountListResponse
   */
  async queryPayAccountList(): Promise<QueryPayAccountListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPayAccountListHeaders({ });
    return await this.queryPayAccountListWithOptions(headers, runtime);
  }

  /**
   * 查询子机构申请单状态
   * 
   * @param request - QueryRegisterOrderRequest
   * @param headers - QueryRegisterOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRegisterOrderResponse
   */
  async queryRegisterOrderWithOptions(request: QueryRegisterOrderRequest, headers: QueryRegisterOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRegisterOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      query["instId"] = request.instId;
    }

    if (!Util.isUnset(request.orderId)) {
      query["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      query["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.subInstId)) {
      query["subInstId"] = request.subInstId;
    }

    let realHeaders : {[key: string ]: string} = { };
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
      action: "QueryRegisterOrder",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/institutions/subInstitutions/orders`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRegisterOrderResponse>(await this.execute(params, req, runtime), new QueryRegisterOrderResponse({}));
  }

  /**
   * 查询子机构申请单状态
   * 
   * @param request - QueryRegisterOrderRequest
   * @returns QueryRegisterOrderResponse
   */
  async queryRegisterOrder(request: QueryRegisterOrderRequest): Promise<QueryRegisterOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRegisterOrderHeaders({ });
    return await this.queryRegisterOrderWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户协议
   * 
   * @param request - QueryUserAgreementRequest
   * @param headers - QueryUserAgreementHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUserAgreementResponse
   */
  async queryUserAgreementWithOptions(request: QueryUserAgreementRequest, headers: QueryUserAgreementHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserAgreementResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.bizScene)) {
      query["bizScene"] = request.bizScene;
    }

    if (!Util.isUnset(request.instId)) {
      query["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      query["subInstId"] = request.subInstId;
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
      action: "QueryUserAgreement",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/userAgreements`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserAgreementResponse>(await this.execute(params, req, runtime), new QueryUserAgreementResponse({}));
  }

  /**
   * 查询用户协议
   * 
   * @param request - QueryUserAgreementRequest
   * @returns QueryUserAgreementResponse
   */
  async queryUserAgreement(request: QueryUserAgreementRequest): Promise<QueryUserAgreementResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserAgreementHeaders({ });
    return await this.queryUserAgreementWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户绑定支付宝信息
   * 
   * @param headers - QueryUserAlipayAccountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUserAlipayAccountResponse
   */
  async queryUserAlipayAccountWithOptions(headers: QueryUserAlipayAccountHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserAlipayAccountResponse> {
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
      action: "QueryUserAlipayAccount",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/userAlipayAccounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserAlipayAccountResponse>(await this.execute(params, req, runtime), new QueryUserAlipayAccountResponse({}));
  }

  /**
   * 获取用户绑定支付宝信息
   * @returns QueryUserAlipayAccountResponse
   */
  async queryUserAlipayAccount(): Promise<QueryUserAlipayAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserAlipayAccountHeaders({ });
    return await this.queryUserAlipayAccountWithOptions(headers, runtime);
  }

  /**
   * 查询代扣交易订单信息
   * 
   * @param request - QueryWithholdingOrderRequest
   * @param headers - QueryWithholdingOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryWithholdingOrderResponse
   */
  async queryWithholdingOrderWithOptions(request: QueryWithholdingOrderRequest, headers: QueryWithholdingOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryWithholdingOrderResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.outTradeNo)) {
      query["outTradeNo"] = request.outTradeNo;
    }

    let realHeaders : {[key: string ]: string} = { };
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
      action: "QueryWithholdingOrder",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/withholdingOrders`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryWithholdingOrderResponse>(await this.execute(params, req, runtime), new QueryWithholdingOrderResponse({}));
  }

  /**
   * 查询代扣交易订单信息
   * 
   * @param request - QueryWithholdingOrderRequest
   * @returns QueryWithholdingOrderResponse
   */
  async queryWithholdingOrder(request: QueryWithholdingOrderRequest): Promise<QueryWithholdingOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryWithholdingOrderHeaders({ });
    return await this.queryWithholdingOrderWithOptions(request, headers, runtime);
  }

  /**
   * 保存付款码企业配置信息
   * 
   * @param request - SaveCorpPayCodeRequest
   * @param headers - SaveCorpPayCodeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveCorpPayCodeResponse
   */
  async saveCorpPayCodeWithOptions(request: SaveCorpPayCodeRequest, headers: SaveCorpPayCodeHeaders, runtime: $Util.RuntimeOptions): Promise<SaveCorpPayCodeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.codeIdentity)) {
      body["codeIdentity"] = request.codeIdentity;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
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
    let params = new $OpenApi.Params({
      action: "SaveCorpPayCode",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payCodes/corpSettings`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveCorpPayCodeResponse>(await this.execute(params, req, runtime), new SaveCorpPayCodeResponse({}));
  }

  /**
   * 保存付款码企业配置信息
   * 
   * @param request - SaveCorpPayCodeRequest
   * @returns SaveCorpPayCodeResponse
   */
  async saveCorpPayCode(request: SaveCorpPayCodeRequest): Promise<SaveCorpPayCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveCorpPayCodeHeaders({ });
    return await this.saveCorpPayCodeWithOptions(request, headers, runtime);
  }

  /**
   * 解约用户协议
   * 
   * @param request - UnsignUserAgreementRequest
   * @param headers - UnsignUserAgreementHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UnsignUserAgreementResponse
   */
  async unsignUserAgreementWithOptions(request: UnsignUserAgreementRequest, headers: UnsignUserAgreementHeaders, runtime: $Util.RuntimeOptions): Promise<UnsignUserAgreementResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agreementNo)) {
      body["agreementNo"] = request.agreementNo;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.bizScene)) {
      body["bizScene"] = request.bizScene;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
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
      action: "UnsignUserAgreement",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/userAgreements/unsign`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UnsignUserAgreementResponse>(await this.execute(params, req, runtime), new UnsignUserAgreementResponse({}));
  }

  /**
   * 解约用户协议
   * 
   * @param request - UnsignUserAgreementRequest
   * @returns UnsignUserAgreementResponse
   */
  async unsignUserAgreement(request: UnsignUserAgreementRequest): Promise<UnsignUserAgreementResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsignUserAgreementHeaders({ });
    return await this.unsignUserAgreementWithOptions(request, headers, runtime);
  }

  /**
   * 更新用户码实例
   * 
   * @param request - UpateUserCodeInstanceRequest
   * @param headers - UpateUserCodeInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpateUserCodeInstanceResponse
   */
  async upateUserCodeInstanceWithOptions(request: UpateUserCodeInstanceRequest, headers: UpateUserCodeInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpateUserCodeInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.availableTimes)) {
      body["availableTimes"] = request.availableTimes;
    }

    if (!Util.isUnset(request.codeId)) {
      body["codeId"] = request.codeId;
    }

    if (!Util.isUnset(request.codeIdentity)) {
      body["codeIdentity"] = request.codeIdentity;
    }

    if (!Util.isUnset(request.codeValue)) {
      body["codeValue"] = request.codeValue;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.gmtExpired)) {
      body["gmtExpired"] = request.gmtExpired;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.userCorpRelationType)) {
      body["userCorpRelationType"] = request.userCorpRelationType;
    }

    if (!Util.isUnset(request.userIdentity)) {
      body["userIdentity"] = request.userIdentity;
    }

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
      action: "UpateUserCodeInstance",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/payCodes/userInstances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpateUserCodeInstanceResponse>(await this.execute(params, req, runtime), new UpateUserCodeInstanceResponse({}));
  }

  /**
   * 更新用户码实例
   * 
   * @param request - UpateUserCodeInstanceRequest
   * @returns UpateUserCodeInstanceResponse
   */
  async upateUserCodeInstance(request: UpateUserCodeInstanceRequest): Promise<UpateUserCodeInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpateUserCodeInstanceHeaders({ });
    return await this.upateUserCodeInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 用来给第三方企业提供发票验真结果更新的oapi
   * 
   * @param request - UpdateInvoiceVerifyStatusRequest
   * @param headers - UpdateInvoiceVerifyStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInvoiceVerifyStatusResponse
   */
  async updateInvoiceVerifyStatusWithOptions(request: UpdateInvoiceVerifyStatusRequest, headers: UpdateInvoiceVerifyStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInvoiceVerifyStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.checkingResult)) {
      body["checkingResult"] = request.checkingResult;
    }

    if (!Util.isUnset(request.checkingStatus)) {
      body["checkingStatus"] = request.checkingStatus;
    }

    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.invoiceCode)) {
      body["invoiceCode"] = request.invoiceCode;
    }

    if (!Util.isUnset(request.invoiceNo)) {
      body["invoiceNo"] = request.invoiceNo;
    }

    if (!Util.isUnset(request.invoiceStatus)) {
      body["invoiceStatus"] = request.invoiceStatus;
    }

    if (!Util.isUnset(request.invoiceVerifyId)) {
      body["invoiceVerifyId"] = request.invoiceVerifyId;
    }

    if (!Util.isUnset(request.msg)) {
      body["msg"] = request.msg;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
    }

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
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/invoices/verifyStatus`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInvoiceVerifyStatusResponse>(await this.execute(params, req, runtime), new UpdateInvoiceVerifyStatusResponse({}));
  }

  /**
   * 用来给第三方企业提供发票验真结果更新的oapi
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
   * 上传发票
   * 
   * @param request - UploadInvoiceRequest
   * @param headers - UploadInvoiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UploadInvoiceResponse
   */
  async uploadInvoiceWithOptions(request: UploadInvoiceRequest, headers: UploadInvoiceHeaders, runtime: $Util.RuntimeOptions): Promise<UploadInvoiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.invoices)) {
      body["invoices"] = request.invoices;
    }

    if (!Util.isUnset(request.userIdentity)) {
      body["userIdentity"] = request.userIdentity;
    }

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
      action: "UploadInvoice",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/invoices/upload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadInvoiceResponse>(await this.execute(params, req, runtime), new UploadInvoiceResponse({}));
  }

  /**
   * 上传发票
   * 
   * @param request - UploadInvoiceRequest
   * @returns UploadInvoiceResponse
   */
  async uploadInvoice(request: UploadInvoiceRequest): Promise<UploadInvoiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadInvoiceHeaders({ });
    return await this.uploadInvoiceWithOptions(request, headers, runtime);
  }

  /**
   * 用户授权上传发票oapi
   * 
   * @param request - UploadInvoiceByAuthRequest
   * @param headers - UploadInvoiceByAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UploadInvoiceByAuthResponse
   */
  async uploadInvoiceByAuthWithOptions(request: UploadInvoiceByAuthRequest, headers: UploadInvoiceByAuthHeaders, runtime: $Util.RuntimeOptions): Promise<UploadInvoiceByAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.invoices)) {
      body["invoices"] = request.invoices;
    }

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
      action: "UploadInvoiceByAuth",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/invoices/authorizations/upload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadInvoiceByAuthResponse>(await this.execute(params, req, runtime), new UploadInvoiceByAuthResponse({}));
  }

  /**
   * 用户授权上传发票oapi
   * 
   * @param request - UploadInvoiceByAuthRequest
   * @returns UploadInvoiceByAuthResponse
   */
  async uploadInvoiceByAuth(request: UploadInvoiceByAuthRequest): Promise<UploadInvoiceByAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadInvoiceByAuthHeaders({ });
    return await this.uploadInvoiceByAuthWithOptions(request, headers, runtime);
  }

  /**
   * 通过手机号上传发票
   * 
   * @param request - UploadInvoiceByMobileRequest
   * @param headers - UploadInvoiceByMobileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UploadInvoiceByMobileResponse
   */
  async uploadInvoiceByMobileWithOptions(request: UploadInvoiceByMobileRequest, headers: UploadInvoiceByMobileHeaders, runtime: $Util.RuntimeOptions): Promise<UploadInvoiceByMobileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.invoices)) {
      body["invoices"] = request.invoices;
    }

    if (!Util.isUnset(request.mobile)) {
      body["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.mobileStateCode)) {
      body["mobileStateCode"] = request.mobileStateCode;
    }

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
      action: "UploadInvoiceByMobile",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/invoices/mobiles/upload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadInvoiceByMobileResponse>(await this.execute(params, req, runtime), new UploadInvoiceByMobileResponse({}));
  }

  /**
   * 通过手机号上传发票
   * 
   * @param request - UploadInvoiceByMobileRequest
   * @returns UploadInvoiceByMobileResponse
   */
  async uploadInvoiceByMobile(request: UploadInvoiceByMobileRequest): Promise<UploadInvoiceByMobileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadInvoiceByMobileHeaders({ });
    return await this.uploadInvoiceByMobileWithOptions(request, headers, runtime);
  }

  /**
   * 上传进件中的图片获得图片链接
   * 
   * @param request - UploadRegisterImageRequest
   * @param headers - UploadRegisterImageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UploadRegisterImageResponse
   */
  async uploadRegisterImageWithOptions(request: UploadRegisterImageRequest, headers: UploadRegisterImageHeaders, runtime: $Util.RuntimeOptions): Promise<UploadRegisterImageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.imageContent)) {
      body["imageContent"] = request.imageContent;
    }

    if (!Util.isUnset(request.imageName)) {
      body["imageName"] = request.imageName;
    }

    if (!Util.isUnset(request.imageType)) {
      body["imageType"] = request.imageType;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

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
      action: "UploadRegisterImage",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/institutions/images`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadRegisterImageResponse>(await this.execute(params, req, runtime), new UploadRegisterImageResponse({}));
  }

  /**
   * 上传进件中的图片获得图片链接
   * 
   * @param request - UploadRegisterImageRequest
   * @returns UploadRegisterImageResponse
   */
  async uploadRegisterImage(request: UploadRegisterImageRequest): Promise<UploadRegisterImageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadRegisterImageHeaders({ });
    return await this.uploadRegisterImageWithOptions(request, headers, runtime);
  }

  /**
   * 用户协议签约
   * 
   * @param request - UserAgreementPageSignRequest
   * @param headers - UserAgreementPageSignHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UserAgreementPageSignResponse
   */
  async userAgreementPageSignWithOptions(request: UserAgreementPageSignRequest, headers: UserAgreementPageSignHeaders, runtime: $Util.RuntimeOptions): Promise<UserAgreementPageSignResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.bizScene)) {
      body["bizScene"] = request.bizScene;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.returnUrl)) {
      body["returnUrl"] = request.returnUrl;
    }

    if (!Util.isUnset(request.signScene)) {
      body["signScene"] = request.signScene;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.subMerchantName)) {
      body["subMerchantName"] = request.subMerchantName;
    }

    if (!Util.isUnset(request.subMerchantServiceDesc)) {
      body["subMerchantServiceDesc"] = request.subMerchantServiceDesc;
    }

    if (!Util.isUnset(request.subMerchantServiceName)) {
      body["subMerchantServiceName"] = request.subMerchantServiceName;
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
      action: "UserAgreementPageSign",
      version: "finance_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/finance/userAgreements`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UserAgreementPageSignResponse>(await this.execute(params, req, runtime), new UserAgreementPageSignResponse({}));
  }

  /**
   * 用户协议签约
   * 
   * @param request - UserAgreementPageSignRequest
   * @returns UserAgreementPageSignResponse
   */
  async userAgreementPageSign(request: UserAgreementPageSignRequest): Promise<UserAgreementPageSignResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserAgreementPageSignHeaders({ });
    return await this.userAgreementPageSignWithOptions(request, headers, runtime);
  }

}
