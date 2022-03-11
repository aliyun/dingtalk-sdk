// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  accountId?: string;
  orderNo?: string;
  passBackParams?: { [key: string]: any };
  payTerminal?: string;
  returnUrl?: string;
  staffId?: string;
  transAmount?: string;
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
  orderNo?: string;
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
  headers: { [key: string]: string };
  body: ApplyBatchPayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ApplyBatchPayResponseBody,
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
  bindingAlipayLogonId?: string;
  contactInfo?: ConsultCreateSubInstitutionRequestContactInfo;
  instId?: string;
  legalPersonCertInfo?: ConsultCreateSubInstitutionRequestLegalPersonCertInfo;
  outTradeNo?: string;
  payChannel?: string;
  qualificationInfos?: ConsultCreateSubInstitutionRequestQualificationInfos[];
  services?: string[];
  settleInfo?: ConsultCreateSubInstitutionRequestSettleInfo;
  solution?: string;
  subInstAddressInfo?: ConsultCreateSubInstitutionRequestSubInstAddressInfo;
  subInstAuthInfo?: ConsultCreateSubInstitutionRequestSubInstAuthInfo;
  subInstBasicInfo?: ConsultCreateSubInstitutionRequestSubInstBasicInfo;
  subInstCertifyInfo?: ConsultCreateSubInstitutionRequestSubInstCertifyInfo;
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
  headers: { [key: string]: string };
  body: ConsultCreateSubInstitutionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  amount?: string;
  instId?: string;
  otherPayChannelDetailInfoList?: CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList[];
  outTradeNo?: string;
  payChannel?: string;
  payerUserId?: string;
  remark?: string;
  subInstId?: string;
  timeOutExpress?: string;
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
  amount?: string;
  gmtPay?: string;
  instId?: string;
  orderNo?: string;
  outTradeNo?: string;
  payChannel?: string;
  payChannelAccountNo?: string;
  payerStaffId?: string;
  remark?: string;
  status?: string;
  subInstId?: string;
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
  headers: { [key: string]: string };
  body: CreatWithholdingOrderAndPayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  instId?: string;
  operatorUserId?: string;
  originOutTradeNo?: string;
  otherPayChannelDetailInfoList?: CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoList[];
  outRefundNo?: string;
  refundAmount?: string;
  remark?: string;
  subInstId?: string;
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
  outRefundNo?: string;
  refundOrderNo?: string;
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
  headers: { [key: string]: string };
  body: CreateAcquireRefundOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  accountId?: string;
  accountNo?: string;
  batchRemark?: string;
  batchTradeDetails?: CreateBatchTradeOrderRequestBatchTradeDetails[];
  outBatchNo?: string;
  staffId?: string;
  totalAmount?: string;
  totalCount?: number;
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
  orderStatus?: string;
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
  headers: { [key: string]: string };
  body: CreateBatchTradeOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  bindingAlipayLogonId?: string;
  contactInfo?: CreateSubInstitutionRequestContactInfo;
  instId?: string;
  legalPersonCertInfo?: CreateSubInstitutionRequestLegalPersonCertInfo;
  outTradeNo?: string;
  payChannel?: string;
  qualificationInfos?: CreateSubInstitutionRequestQualificationInfos[];
  services?: string[];
  settleInfo?: CreateSubInstitutionRequestSettleInfo;
  solution?: string;
  subInstAddressInfo?: CreateSubInstitutionRequestSubInstAddressInfo;
  subInstAuthInfo?: CreateSubInstitutionRequestSubInstAuthInfo;
  subInstBasicInfo?: CreateSubInstitutionRequestSubInstBasicInfo;
  subInstCertifyInfo?: CreateSubInstitutionRequestSubInstCertifyInfo;
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
  headers: { [key: string]: string };
  body: CreateSubInstitutionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  availableTimes?: CreateUserCodeInstanceRequestAvailableTimes[];
  codeIdentity?: string;
  codeValue?: string;
  codeValueType?: string;
  corpId?: string;
  extInfo?: { [key: string]: any };
  gmtExpired?: string;
  requestId?: string;
  status?: string;
  userCorpRelationType?: string;
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
  headers: { [key: string]: string };
  body: CreateUserCodeInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  alipayCode?: string;
  codeId?: string;
  codeIdentity?: string;
  codeType?: string;
  corpId?: string;
  extInfo?: string;
  outBizId?: string;
  userCorpRelationType?: string;
  userId?: string;
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
  headers: { [key: string]: string };
  body: DecodePayCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DecodePayCodeResponseBody,
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
  bindingAlipayLogonId?: string;
  contactInfo?: ModifySubInstitutionRequestContactInfo;
  instId?: string;
  legalPersonCertInfo?: ModifySubInstitutionRequestLegalPersonCertInfo;
  outTradeNo?: string;
  payChannel?: string;
  qualificationInfos?: ModifySubInstitutionRequestQualificationInfos[];
  services?: string[];
  settleInfo?: ModifySubInstitutionRequestSettleInfo;
  subInstAddressInfo?: ModifySubInstitutionRequestSubInstAddressInfo;
  subInstAuthInfo?: ModifySubInstitutionRequestSubInstAuthInfo;
  subInstBasicInfo?: ModifySubInstitutionRequestSubInstBasicInfo;
  subInstCertifyInfo?: ModifySubInstitutionRequestSubInstCertifyInfo;
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
  headers: { [key: string]: string };
  body: ModifySubInstitutionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  amount?: string;
  chargeAmount?: string;
  corpId?: string;
  extInfo?: string;
  gmtTradeCreate?: string;
  gmtTradeFinish?: string;
  merchantName?: string;
  payChannelDetailList?: NotifyPayCodePayResultRequestPayChannelDetailList[];
  payCode?: string;
  promotionAmount?: string;
  remark?: string;
  title?: string;
  tradeErrorCode?: string;
  tradeErrorMsg?: string;
  tradeNo?: string;
  tradeStatus?: string;
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
  headers: { [key: string]: string };
  body: NotifyPayCodePayResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  corpId?: string;
  gmtRefund?: string;
  payChannelDetailList?: NotifyPayCodeRefundResultRequestPayChannelDetailList[];
  payCode?: string;
  refundAmount?: string;
  refundOrderNo?: string;
  refundPromotionAmount?: string;
  remark?: string;
  tradeNo?: string;
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
  headers: { [key: string]: string };
  body: NotifyPayCodeRefundResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  corpId?: string;
  payCode?: string;
  remark?: string;
  userCorpRelationType?: string;
  userIdentity?: string;
  verifyEvent?: string;
  verifyLocation?: string;
  verifyNo?: string;
  verifyResult?: boolean;
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
  headers: { [key: string]: string };
  body: NotifyVerifyResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: NotifyVerifyResultResponseBody,
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
  amount?: string;
  gmtCreate?: string;
  gmtRefund?: string;
  instId?: string;
  orderNo?: string;
  originOutTradeNo?: string;
  outRefundNo?: string;
  payChannel?: string;
  payChannelAccountNo?: string;
  payerUserId?: string;
  remark?: string;
  status?: string;
  subInstId?: string;
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
  headers: { [key: string]: string };
  body: QueryAcquireRefundOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  outBatchNo?: string;
  pageNumber?: number;
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
  batchTradeDetailList?: QueryBatchTradeDetailListResponseBodyBatchTradeDetailList[];
  pageNumber?: number;
  pageSize?: number;
  total?: number;
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
  headers: { [key: string]: string };
  body: QueryBatchTradeDetailListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: QueryBatchTradeOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: QueryPayAccountListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  instId?: string;
  orderId?: string;
  outTradeNo?: string;
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
  headers: { [key: string]: string };
  body: QueryRegisterOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  bizCode?: string;
  bizScene?: string;
  instId?: string;
  subInstId?: string;
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
  agreementNo?: string;
  corpId?: string;
  gmtExpire?: string;
  gmtSign?: string;
  gmtValid?: string;
  instId?: string;
  payChannel?: string;
  payChannelAccountName?: string;
  payChannelAccountNo?: string;
  status?: string;
  subInstId?: string;
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
  headers: { [key: string]: string };
  body: QueryUserAgreementResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: QueryUserAlipayAccountResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  amount?: string;
  gmtCreate?: string;
  gmtPay?: string;
  instId?: string;
  orderNo?: string;
  outTradeNo?: string;
  payChannel?: string;
  payChannelAccountNo?: string;
  payerUserId?: string;
  remark?: string;
  status?: string;
  subInstId?: string;
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
  headers: { [key: string]: string };
  body: QueryWithholdingOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: SaveCorpPayCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  agreementNo?: string;
  bizCode?: string;
  bizScene?: string;
  instId?: string;
  subInstId?: string;
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
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  availableTimes?: UpateUserCodeInstanceRequestAvailableTimes[];
  codeId?: string;
  codeIdentity?: string;
  codeValue?: string;
  corpId?: string;
  extInfo?: { [key: string]: any };
  gmtExpired?: string;
  status?: string;
  userCorpRelationType?: string;
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
  headers: { [key: string]: string };
  body: UpateUserCodeInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  bizId?: string;
  checkingResult?: number;
  checkingStatus?: number;
  code?: string;
  corpId?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  invoiceStatus?: number;
  invoiceVerifyId?: string;
  msg?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      checkingResult: 'checkingResult',
      checkingStatus: 'checkingStatus',
      code: 'code',
      corpId: 'corpId',
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
  invoices?: UploadInvoiceByAuthRequestInvoices[];
  static names(): { [key: string]: string } {
    return {
      invoices: 'invoices',
    };
  }

  static types(): { [key: string]: any } {
    return {
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
  headers: { [key: string]: string };
  body: UploadInvoiceByAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  invoices?: UploadInvoiceByMobileRequestInvoices[];
  mobile?: string;
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
  headers: { [key: string]: string };
  body: UploadInvoiceByMobileResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  imageContent?: string;
  imageName?: string;
  imageType?: string;
  instId?: string;
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
  headers: { [key: string]: string };
  body: UploadRegisterImageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  bizCode?: string;
  bizScene?: string;
  instId?: string;
  payChannel?: string;
  remark?: string;
  returnUrl?: string;
  signScene?: string;
  subInstId?: string;
  subMerchantName?: string;
  subMerchantServiceDesc?: string;
  subMerchantServiceName?: string;
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
  headers: { [key: string]: string };
  body: UserAgreementPageSignResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UserAgreementPageSignResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestContactInfo extends $tea.Model {
  contactName?: string;
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
  certBackImage?: string;
  certFrontImage?: string;
  certName?: string;
  certType?: string;
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
  qualificationImage?: string;
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
  accountId?: string;
  accountName?: string;
  accountType?: string;
  bankBranchName?: string;
  bankCity?: string;
  bankCode?: string;
  bankName?: string;
  bankProvince?: string;
  bankShortNameCode?: string;
  type?: string;
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
  address?: string;
  cityCode?: string;
  districtCode?: string;
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
  aliasName?: string;
  mcc?: string;
  subInstName?: string;
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
  certImage?: string;
  certNo?: string;
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
  address?: string;
  cityCode?: string;
  districtCode?: string;
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
  acceptElectronic?: boolean;
  address?: string;
  autoInvoice?: boolean;
  bankAccount?: string;
  bankName?: string;
  mailAddress?: ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress;
  mailName?: string;
  mailPhone?: string;
  taxNo?: string;
  taxPayerQualification?: string;
  taxPayerValidDate?: string;
  telephone?: string;
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
  amount?: string;
  extInfo?: string;
  fundToolName?: string;
  gmtCreate?: string;
  gmtFinish?: string;
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
  amount?: string;
  fundToolDetailInfoList?: CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList[];
  payChannelName?: string;
  payChannelOrderNo?: string;
  payChannelType?: string;
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
  amount?: string;
  extInfo?: string;
  fundToolName?: string;
  gmtCreate?: string;
  gmtFinish?: string;
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
  amount?: string;
  fundToolDetailInfoList?: CreateAcquireRefundOrderRequestOtherPayChannelDetailInfoListFundToolDetailInfoList[];
  payChannelName?: string;
  payChannelOrderNo?: string;
  payChannelType?: string;
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
  amount?: string;
  memo?: string;
  payeeAccountName?: string;
  payeeAccountNo?: string;
  payeeAccountType?: string;
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
  contactName?: string;
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
  certBackImage?: string;
  certFrontImage?: string;
  certName?: string;
  certType?: string;
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
  qualificationImage?: string;
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
  accountId?: string;
  accountName?: string;
  accountType?: string;
  bankBranchName?: string;
  bankCity?: string;
  bankCode?: string;
  bankName?: string;
  bankProvince?: string;
  bankShortNameCode?: string;
  type?: string;
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
  address?: string;
  cityCode?: string;
  districtCode?: string;
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
  aliasName?: string;
  mcc?: string;
  subInstName?: string;
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
  certImage?: string;
  certNo?: string;
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
  address?: string;
  cityCode?: string;
  districtCode?: string;
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
  acceptElectronic?: boolean;
  address?: string;
  autoInvoice?: boolean;
  bankAccount?: string;
  bankName?: string;
  mailAddress?: CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress;
  mailName?: string;
  mailPhone?: string;
  taxNo?: string;
  taxPayerQualification?: string;
  taxPayerValidDate?: string;
  telephone?: string;
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
  gmtEnd?: string;
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
  contactName?: string;
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
  certBackImage?: string;
  certFrontImage?: string;
  certName?: string;
  certType?: string;
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
  qualificationImage?: string;
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
  accountId?: string;
  accountName?: string;
  accountType?: string;
  bankBranchName?: string;
  bankCity?: string;
  bankCode?: string;
  bankName?: string;
  bankProvince?: string;
  bankShortNameCode?: string;
  type?: string;
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
  address?: string;
  cityCode?: string;
  districtCode?: string;
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
  aliasName?: string;
  mcc?: string;
  subInstName?: string;
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
  certImage?: string;
  certNo?: string;
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
  address?: string;
  cityCode?: string;
  districtCode?: string;
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
  acceptElectronic?: boolean;
  address?: string;
  autoInvoice?: boolean;
  bankAccount?: string;
  bankName?: string;
  mailAddress?: ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress;
  mailName?: string;
  mailPhone?: string;
  taxNo?: string;
  taxPayerQualification?: string;
  taxPayerValidDate?: string;
  telephone?: string;
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
  amount?: string;
  extInfo?: string;
  fundToolName?: string;
  gmtCreate?: string;
  gmtFinish?: string;
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
  amount?: string;
  fundToolDetailList?: NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList[];
  gmtCreate?: string;
  gmtFinish?: string;
  payChannelName?: string;
  payChannelOrderNo?: string;
  payChannelType?: string;
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
  amount?: string;
  extInfo?: string;
  fundToolName?: string;
  gmtCreate?: string;
  gmtFinish?: string;
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
  amount?: string;
  fundToolDetailList?: NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList[];
  payChannelName?: string;
  payChannelOrderNo?: string;
  payChannelRefundOrderNo?: string;
  payChannelType?: string;
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

export class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList extends $tea.Model {
  amount?: string;
  detailNo?: string;
  gmtCreate?: string;
  gmtFinish?: string;
  memo?: string;
  payeeAccountName?: string;
  payeeAccountNo?: string;
  payeeAccountType?: string;
  serialNo?: number;
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
  alipayTransId?: string;
  failAmount?: string;
  failCount?: number;
  failReason?: string;
  gmtFinish?: string;
  gmtSubmit?: string;
  outBatchNo?: string;
  payerStaffId?: string;
  paymentAmount?: string;
  paymentCurrency?: string;
  status?: string;
  successAmount?: string;
  successCount?: number;
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
  accountClass?: string;
  accountId?: string;
  accountName?: string;
  accountNo?: string;
  accountRemark?: string;
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
  gmtEnd?: string;
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

export class UploadInvoiceByAuthRequestInvoices extends $tea.Model {
  invoiceAmount?: string;
  invoiceCode?: string;
  invoiceDate?: string;
  invoiceNo?: string;
  invoiceType?: string;
  logoUrl?: string;
  payeeName?: string;
  payeeTaxNo?: string;
  payerName?: string;
  payerTaxNo?: string;
  pdfUrl?: string;
  taxAmount?: string;
  verifyCode?: string;
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
  errCode?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  reason?: string;
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
  invoiceAmount?: string;
  invoiceCode?: string;
  invoiceDate?: string;
  invoiceNo?: string;
  invoiceType?: string;
  logoUrl?: string;
  payeeName?: string;
  payeeTaxNo?: string;
  payerName?: string;
  payerTaxNo?: string;
  pdfUrl?: string;
  taxAmount?: string;
  verifyCode?: string;
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
  errCode?: string;
  invoiceCode?: string;
  invoiceNo?: string;
  reason?: string;
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
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async applyBatchPay(request: ApplyBatchPayRequest): Promise<ApplyBatchPayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApplyBatchPayHeaders({ });
    return await this.applyBatchPayWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<ApplyBatchPayResponse>(await this.doROARequest("ApplyBatchPay", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/batchTrades/orders/pay`, "json", req, runtime), new ApplyBatchPayResponse({}));
  }

  async consultCreateSubInstitution(request: ConsultCreateSubInstitutionRequest): Promise<ConsultCreateSubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsultCreateSubInstitutionHeaders({ });
    return await this.consultCreateSubInstitutionWithOptions(request, headers, runtime);
  }

  async consultCreateSubInstitutionWithOptions(request: ConsultCreateSubInstitutionRequest, headers: ConsultCreateSubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<ConsultCreateSubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset($tea.toMap(request.contactInfo))) {
      body["contactInfo"] = request.contactInfo;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset($tea.toMap(request.legalPersonCertInfo))) {
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

    if (!Util.isUnset($tea.toMap(request.settleInfo))) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset(request.solution)) {
      body["solution"] = request.solution;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAddressInfo))) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAuthInfo))) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstBasicInfo))) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstCertifyInfo))) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset($tea.toMap(request.subInstInvoiceInfo))) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstShopInfo))) {
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
    return $tea.cast<ConsultCreateSubInstitutionResponse>(await this.doROARequest("ConsultCreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/subInstitutions/consult`, "json", req, runtime), new ConsultCreateSubInstitutionResponse({}));
  }

  async creatWithholdingOrderAndPay(request: CreatWithholdingOrderAndPayRequest): Promise<CreatWithholdingOrderAndPayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatWithholdingOrderAndPayHeaders({ });
    return await this.creatWithholdingOrderAndPayWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreatWithholdingOrderAndPayResponse>(await this.doROARequest("CreatWithholdingOrderAndPay", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/withholdingOrders`, "json", req, runtime), new CreatWithholdingOrderAndPayResponse({}));
  }

  async createAcquireRefundOrder(request: CreateAcquireRefundOrderRequest): Promise<CreateAcquireRefundOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAcquireRefundOrderHeaders({ });
    return await this.createAcquireRefundOrderWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateAcquireRefundOrderResponse>(await this.doROARequest("CreateAcquireRefundOrder", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/acquireOrders/refund`, "json", req, runtime), new CreateAcquireRefundOrderResponse({}));
  }

  async createBatchTradeOrder(request: CreateBatchTradeOrderRequest): Promise<CreateBatchTradeOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBatchTradeOrderHeaders({ });
    return await this.createBatchTradeOrderWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateBatchTradeOrderResponse>(await this.doROARequest("CreateBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/batchTrades/orders`, "json", req, runtime), new CreateBatchTradeOrderResponse({}));
  }

  async createSubInstitution(request: CreateSubInstitutionRequest): Promise<CreateSubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSubInstitutionHeaders({ });
    return await this.createSubInstitutionWithOptions(request, headers, runtime);
  }

  async createSubInstitutionWithOptions(request: CreateSubInstitutionRequest, headers: CreateSubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset($tea.toMap(request.contactInfo))) {
      body["contactInfo"] = request.contactInfo;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset($tea.toMap(request.legalPersonCertInfo))) {
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

    if (!Util.isUnset($tea.toMap(request.settleInfo))) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset(request.solution)) {
      body["solution"] = request.solution;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAddressInfo))) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAuthInfo))) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstBasicInfo))) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstCertifyInfo))) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset($tea.toMap(request.subInstInvoiceInfo))) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstShopInfo))) {
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
    return $tea.cast<CreateSubInstitutionResponse>(await this.doROARequest("CreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/subInstitutions`, "json", req, runtime), new CreateSubInstitutionResponse({}));
  }

  async createUserCodeInstance(request: CreateUserCodeInstanceRequest): Promise<CreateUserCodeInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUserCodeInstanceHeaders({ });
    return await this.createUserCodeInstanceWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateUserCodeInstanceResponse>(await this.doROARequest("CreateUserCodeInstance", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/userInstances`, "json", req, runtime), new CreateUserCodeInstanceResponse({}));
  }

  async decodePayCode(request: DecodePayCodeRequest): Promise<DecodePayCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DecodePayCodeHeaders({ });
    return await this.decodePayCodeWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<DecodePayCodeResponse>(await this.doROARequest("DecodePayCode", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/decode`, "json", req, runtime), new DecodePayCodeResponse({}));
  }

  async modifySubInstitution(request: ModifySubInstitutionRequest): Promise<ModifySubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifySubInstitutionHeaders({ });
    return await this.modifySubInstitutionWithOptions(request, headers, runtime);
  }

  async modifySubInstitutionWithOptions(request: ModifySubInstitutionRequest, headers: ModifySubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<ModifySubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset($tea.toMap(request.contactInfo))) {
      body["contactInfo"] = request.contactInfo;
    }

    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset($tea.toMap(request.legalPersonCertInfo))) {
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

    if (!Util.isUnset($tea.toMap(request.settleInfo))) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAddressInfo))) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAuthInfo))) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstBasicInfo))) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstCertifyInfo))) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset($tea.toMap(request.subInstInvoiceInfo))) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstShopInfo))) {
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
    return $tea.cast<ModifySubInstitutionResponse>(await this.doROARequest("ModifySubInstitution", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/subInstitutions/modify`, "json", req, runtime), new ModifySubInstitutionResponse({}));
  }

  async notifyPayCodePayResult(request: NotifyPayCodePayResultRequest): Promise<NotifyPayCodePayResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyPayCodePayResultHeaders({ });
    return await this.notifyPayCodePayResultWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<NotifyPayCodePayResultResponse>(await this.doROARequest("NotifyPayCodePayResult", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/payResults/notify`, "json", req, runtime), new NotifyPayCodePayResultResponse({}));
  }

  async notifyPayCodeRefundResult(request: NotifyPayCodeRefundResultRequest): Promise<NotifyPayCodeRefundResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyPayCodeRefundResultHeaders({ });
    return await this.notifyPayCodeRefundResultWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<NotifyPayCodeRefundResultResponse>(await this.doROARequest("NotifyPayCodeRefundResult", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/refundResults/notify`, "json", req, runtime), new NotifyPayCodeRefundResultResponse({}));
  }

  async notifyVerifyResult(request: NotifyVerifyResultRequest): Promise<NotifyVerifyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyVerifyResultHeaders({ });
    return await this.notifyVerifyResultWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<NotifyVerifyResultResponse>(await this.doROARequest("NotifyVerifyResult", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/verifyResults/notify`, "json", req, runtime), new NotifyVerifyResultResponse({}));
  }

  async queryAcquireRefundOrder(request: QueryAcquireRefundOrderRequest): Promise<QueryAcquireRefundOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAcquireRefundOrderHeaders({ });
    return await this.queryAcquireRefundOrderWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryAcquireRefundOrderResponse>(await this.doROARequest("QueryAcquireRefundOrder", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/acquireOrders/refunds`, "json", req, runtime), new QueryAcquireRefundOrderResponse({}));
  }

  async queryBatchTradeDetailList(request: QueryBatchTradeDetailListRequest): Promise<QueryBatchTradeDetailListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBatchTradeDetailListHeaders({ });
    return await this.queryBatchTradeDetailListWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryBatchTradeDetailListResponse>(await this.doROARequest("QueryBatchTradeDetailList", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/batchTrades/details`, "json", req, runtime), new QueryBatchTradeDetailListResponse({}));
  }

  async queryBatchTradeOrder(request: QueryBatchTradeOrderRequest): Promise<QueryBatchTradeOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBatchTradeOrderHeaders({ });
    return await this.queryBatchTradeOrderWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryBatchTradeOrderResponse>(await this.doROARequest("QueryBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/batchTrades/orders/query`, "json", req, runtime), new QueryBatchTradeOrderResponse({}));
  }

  async queryPayAccountList(): Promise<QueryPayAccountListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPayAccountListHeaders({ });
    return await this.queryPayAccountListWithOptions(headers, runtime);
  }

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
    return $tea.cast<QueryPayAccountListResponse>(await this.doROARequest("QueryPayAccountList", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/payAccounts`, "json", req, runtime), new QueryPayAccountListResponse({}));
  }

  async queryRegisterOrder(request: QueryRegisterOrderRequest): Promise<QueryRegisterOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRegisterOrderHeaders({ });
    return await this.queryRegisterOrderWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryRegisterOrderResponse>(await this.doROARequest("QueryRegisterOrder", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/institutions/subInstitutions/orders`, "json", req, runtime), new QueryRegisterOrderResponse({}));
  }

  async queryUserAgreement(request: QueryUserAgreementRequest): Promise<QueryUserAgreementResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserAgreementHeaders({ });
    return await this.queryUserAgreementWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryUserAgreementResponse>(await this.doROARequest("QueryUserAgreement", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/userAgreements`, "json", req, runtime), new QueryUserAgreementResponse({}));
  }

  async queryUserAlipayAccount(): Promise<QueryUserAlipayAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserAlipayAccountHeaders({ });
    return await this.queryUserAlipayAccountWithOptions(headers, runtime);
  }

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
    return $tea.cast<QueryUserAlipayAccountResponse>(await this.doROARequest("QueryUserAlipayAccount", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/userAlipayAccounts`, "json", req, runtime), new QueryUserAlipayAccountResponse({}));
  }

  async queryWithholdingOrder(request: QueryWithholdingOrderRequest): Promise<QueryWithholdingOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryWithholdingOrderHeaders({ });
    return await this.queryWithholdingOrderWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryWithholdingOrderResponse>(await this.doROARequest("QueryWithholdingOrder", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/withholdingOrders`, "json", req, runtime), new QueryWithholdingOrderResponse({}));
  }

  async saveCorpPayCode(request: SaveCorpPayCodeRequest): Promise<SaveCorpPayCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveCorpPayCodeHeaders({ });
    return await this.saveCorpPayCodeWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<SaveCorpPayCodeResponse>(await this.doROARequest("SaveCorpPayCode", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/corpSettings`, "json", req, runtime), new SaveCorpPayCodeResponse({}));
  }

  async unsignUserAgreement(request: UnsignUserAgreementRequest): Promise<UnsignUserAgreementResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsignUserAgreementHeaders({ });
    return await this.unsignUserAgreementWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UnsignUserAgreementResponse>(await this.doROARequest("UnsignUserAgreement", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/userAgreements/unsign`, "none", req, runtime), new UnsignUserAgreementResponse({}));
  }

  async upateUserCodeInstance(request: UpateUserCodeInstanceRequest): Promise<UpateUserCodeInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpateUserCodeInstanceHeaders({ });
    return await this.upateUserCodeInstanceWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpateUserCodeInstanceResponse>(await this.doROARequest("UpateUserCodeInstance", "finance_1.0", "HTTP", "PUT", "AK", `/v1.0/finance/payCodes/userInstances`, "json", req, runtime), new UpateUserCodeInstanceResponse({}));
  }

  async updateInvoiceVerifyStatus(request: UpdateInvoiceVerifyStatusRequest): Promise<UpdateInvoiceVerifyStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInvoiceVerifyStatusHeaders({ });
    return await this.updateInvoiceVerifyStatusWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateInvoiceVerifyStatusResponse>(await this.doROARequest("UpdateInvoiceVerifyStatus", "finance_1.0", "HTTP", "PUT", "AK", `/v1.0/finance/invoices/verifyStatus`, "json", req, runtime), new UpdateInvoiceVerifyStatusResponse({}));
  }

  async uploadInvoiceByAuth(request: UploadInvoiceByAuthRequest): Promise<UploadInvoiceByAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadInvoiceByAuthHeaders({ });
    return await this.uploadInvoiceByAuthWithOptions(request, headers, runtime);
  }

  async uploadInvoiceByAuthWithOptions(request: UploadInvoiceByAuthRequest, headers: UploadInvoiceByAuthHeaders, runtime: $Util.RuntimeOptions): Promise<UploadInvoiceByAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    return $tea.cast<UploadInvoiceByAuthResponse>(await this.doROARequest("UploadInvoiceByAuth", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/invoices/authorizations/upload`, "json", req, runtime), new UploadInvoiceByAuthResponse({}));
  }

  async uploadInvoiceByMobile(request: UploadInvoiceByMobileRequest): Promise<UploadInvoiceByMobileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadInvoiceByMobileHeaders({ });
    return await this.uploadInvoiceByMobileWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UploadInvoiceByMobileResponse>(await this.doROARequest("UploadInvoiceByMobile", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/invoices/mobiles/upload`, "json", req, runtime), new UploadInvoiceByMobileResponse({}));
  }

  async uploadRegisterImage(request: UploadRegisterImageRequest): Promise<UploadRegisterImageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadRegisterImageHeaders({ });
    return await this.uploadRegisterImageWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UploadRegisterImageResponse>(await this.doROARequest("UploadRegisterImage", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/images`, "json", req, runtime), new UploadRegisterImageResponse({}));
  }

  async userAgreementPageSign(request: UserAgreementPageSignRequest): Promise<UserAgreementPageSignResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserAgreementPageSignHeaders({ });
    return await this.userAgreementPageSignWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UserAgreementPageSignResponse>(await this.doROARequest("UserAgreementPageSign", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/userAgreements`, "json", req, runtime), new UserAgreementPageSignResponse({}));
  }

}
