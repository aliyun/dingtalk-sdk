// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  payCode?: string;
  corpId?: string;
  userId?: string;
  gmtTradeCreate?: string;
  gmtTradeFinish?: string;
  tradeNo?: string;
  tradeStatus?: string;
  title?: string;
  remark?: string;
  amount?: string;
  promotionAmount?: string;
  chargeAmount?: string;
  payChannelDetailList?: NotifyPayCodePayResultRequestPayChannelDetailList[];
  tradeErrorCode?: string;
  tradeErrorMsg?: string;
  extInfo?: string;
  dingIsvOrgId?: number;
  merchantName?: string;
  static names(): { [key: string]: string } {
    return {
      payCode: 'payCode',
      corpId: 'corpId',
      userId: 'userId',
      gmtTradeCreate: 'gmtTradeCreate',
      gmtTradeFinish: 'gmtTradeFinish',
      tradeNo: 'tradeNo',
      tradeStatus: 'tradeStatus',
      title: 'title',
      remark: 'remark',
      amount: 'amount',
      promotionAmount: 'promotionAmount',
      chargeAmount: 'chargeAmount',
      payChannelDetailList: 'payChannelDetailList',
      tradeErrorCode: 'tradeErrorCode',
      tradeErrorMsg: 'tradeErrorMsg',
      extInfo: 'extInfo',
      dingIsvOrgId: 'dingIsvOrgId',
      merchantName: 'merchantName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payCode: 'string',
      corpId: 'string',
      userId: 'string',
      gmtTradeCreate: 'string',
      gmtTradeFinish: 'string',
      tradeNo: 'string',
      tradeStatus: 'string',
      title: 'string',
      remark: 'string',
      amount: 'string',
      promotionAmount: 'string',
      chargeAmount: 'string',
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyPayCodePayResultRequestPayChannelDetailList },
      tradeErrorCode: 'string',
      tradeErrorMsg: 'string',
      extInfo: 'string',
      dingIsvOrgId: 'number',
      merchantName: 'string',
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
  codeId?: string;
  codeIdentity?: string;
  codeValue?: string;
  status?: string;
  corpId?: string;
  userCorpRelationType?: string;
  userIdentity?: string;
  gmtExpired?: string;
  availableTimes?: UpateUserCodeInstanceRequestAvailableTimes[];
  extInfo?: { [key: string]: any };
  dingOrgId?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      codeId: 'codeId',
      codeIdentity: 'codeIdentity',
      codeValue: 'codeValue',
      status: 'status',
      corpId: 'corpId',
      userCorpRelationType: 'userCorpRelationType',
      userIdentity: 'userIdentity',
      gmtExpired: 'gmtExpired',
      availableTimes: 'availableTimes',
      extInfo: 'extInfo',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeId: 'string',
      codeIdentity: 'string',
      codeValue: 'string',
      status: 'string',
      corpId: 'string',
      userCorpRelationType: 'string',
      userIdentity: 'string',
      gmtExpired: 'string',
      availableTimes: { 'type': 'array', 'itemType': UpateUserCodeInstanceRequestAvailableTimes },
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
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
  staffId?: string;
  accountId?: string;
  orderNo?: string;
  transAmount?: string;
  returnUrl?: string;
  passBackParams?: { [key: string]: any };
  payTerminal?: string;
  transExpireTime?: string;
  static names(): { [key: string]: string } {
    return {
      staffId: 'staffId',
      accountId: 'accountId',
      orderNo: 'orderNo',
      transAmount: 'transAmount',
      returnUrl: 'returnUrl',
      passBackParams: 'passBackParams',
      payTerminal: 'payTerminal',
      transExpireTime: 'transExpireTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      staffId: 'string',
      accountId: 'string',
      orderNo: 'string',
      transAmount: 'string',
      returnUrl: 'string',
      passBackParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      payTerminal: 'string',
      transExpireTime: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyBatchPayResponseBody extends $tea.Model {
  payData?: string;
  orderNo?: string;
  static names(): { [key: string]: string } {
    return {
      payData: 'payData',
      orderNo: 'orderNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payData: 'string',
      orderNo: 'string',
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
  corpId?: string;
  userId?: string;
  userInCorp?: boolean;
  codeType?: string;
  alipayCode?: string;
  userCorpRelationType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      userInCorp: 'userInCorp',
      codeType: 'codeType',
      alipayCode: 'alipayCode',
      userCorpRelationType: 'userCorpRelationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      userId: 'string',
      userInCorp: 'boolean',
      codeType: 'string',
      alipayCode: 'string',
      userCorpRelationType: 'string',
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
  status?: string;
  extInfo?: { [key: string]: any };
  dingOrgId?: number;
  dingClientId?: string;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      codeIdentity: 'codeIdentity',
      corpId: 'corpId',
      status: 'status',
      extInfo: 'extInfo',
      dingOrgId: 'dingOrgId',
      dingClientId: 'dingClientId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeIdentity: 'string',
      corpId: 'string',
      status: 'string',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dingOrgId: 'number',
      dingClientId: 'string',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveCorpPayCodeResponseBody extends $tea.Model {
  codeIdentity?: string;
  corpId?: string;
  status?: string;
  extInfo?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      codeIdentity: 'codeIdentity',
      corpId: 'corpId',
      status: 'status',
      extInfo: 'extInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeIdentity: 'string',
      corpId: 'string',
      status: 'string',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
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
  payCode?: string;
  corpId?: string;
  userCorpRelationType?: string;
  userIdentity?: string;
  verifyTime?: string;
  verifyResult?: boolean;
  verifyLocation?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      payCode: 'payCode',
      corpId: 'corpId',
      userCorpRelationType: 'userCorpRelationType',
      userIdentity: 'userIdentity',
      verifyTime: 'verifyTime',
      verifyResult: 'verifyResult',
      verifyLocation: 'verifyLocation',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payCode: 'string',
      corpId: 'string',
      userCorpRelationType: 'string',
      userIdentity: 'string',
      verifyTime: 'string',
      verifyResult: 'boolean',
      verifyLocation: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
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
  staffId?: string;
  accountId?: string;
  accountNo?: string;
  tradeTitle?: string;
  outBatchNo?: string;
  batchRemark?: string;
  totalCount?: number;
  totalAmount?: string;
  batchTradeDetails?: CreateBatchTradeOrderRequestBatchTradeDetails[];
  static names(): { [key: string]: string } {
    return {
      staffId: 'staffId',
      accountId: 'accountId',
      accountNo: 'accountNo',
      tradeTitle: 'tradeTitle',
      outBatchNo: 'outBatchNo',
      batchRemark: 'batchRemark',
      totalCount: 'totalCount',
      totalAmount: 'totalAmount',
      batchTradeDetails: 'batchTradeDetails',
    };
  }

  static types(): { [key: string]: any } {
    return {
      staffId: 'string',
      accountId: 'string',
      accountNo: 'string',
      tradeTitle: 'string',
      outBatchNo: 'string',
      batchRemark: 'string',
      totalCount: 'number',
      totalAmount: 'string',
      batchTradeDetails: { 'type': 'array', 'itemType': CreateBatchTradeOrderRequestBatchTradeDetails },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBatchTradeOrderResponseBody extends $tea.Model {
  orderNo?: string;
  outBatchNo?: string;
  orderStatus?: string;
  static names(): { [key: string]: string } {
    return {
      orderNo: 'orderNo',
      outBatchNo: 'outBatchNo',
      orderStatus: 'orderStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderNo: 'string',
      outBatchNo: 'string',
      orderStatus: 'string',
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
  userId?: string;
  tradeNo?: string;
  refundOrderNo?: string;
  remark?: string;
  refundAmount?: string;
  refundPromotionAmount?: string;
  gmtRefund?: string;
  payChannelDetailList?: NotifyPayCodeRefundResultRequestPayChannelDetailList[];
  dingIsvOrgId?: number;
  payCode?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      tradeNo: 'tradeNo',
      refundOrderNo: 'refundOrderNo',
      remark: 'remark',
      refundAmount: 'refundAmount',
      refundPromotionAmount: 'refundPromotionAmount',
      gmtRefund: 'gmtRefund',
      payChannelDetailList: 'payChannelDetailList',
      dingIsvOrgId: 'dingIsvOrgId',
      payCode: 'payCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      userId: 'string',
      tradeNo: 'string',
      refundOrderNo: 'string',
      remark: 'string',
      refundAmount: 'string',
      refundPromotionAmount: 'string',
      gmtRefund: 'string',
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyPayCodeRefundResultRequestPayChannelDetailList },
      dingIsvOrgId: 'number',
      payCode: 'string',
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
  total?: number;
  pageSize?: number;
  totalPageNumber?: number;
  pageNumber?: number;
  batchTradeDetailList?: QueryBatchTradeDetailListResponseBodyBatchTradeDetailList[];
  static names(): { [key: string]: string } {
    return {
      total: 'total',
      pageSize: 'pageSize',
      totalPageNumber: 'totalPageNumber',
      pageNumber: 'pageNumber',
      batchTradeDetailList: 'batchTradeDetailList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      total: 'number',
      pageSize: 'number',
      totalPageNumber: 'number',
      pageNumber: 'number',
      batchTradeDetailList: { 'type': 'array', 'itemType': QueryBatchTradeDetailListResponseBodyBatchTradeDetailList },
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
  requestId?: string;
  codeIdentity?: string;
  codeValue?: string;
  status?: string;
  corpId?: string;
  userCorpRelationType?: string;
  userIdentity?: string;
  gmtExpired?: string;
  availableTimes?: CreateUserCodeInstanceRequestAvailableTimes[];
  extInfo?: { [key: string]: any };
  dingOrgId?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      codeIdentity: 'codeIdentity',
      codeValue: 'codeValue',
      status: 'status',
      corpId: 'corpId',
      userCorpRelationType: 'userCorpRelationType',
      userIdentity: 'userIdentity',
      gmtExpired: 'gmtExpired',
      availableTimes: 'availableTimes',
      extInfo: 'extInfo',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      codeIdentity: 'string',
      codeValue: 'string',
      status: 'string',
      corpId: 'string',
      userCorpRelationType: 'string',
      userIdentity: 'string',
      gmtExpired: 'string',
      availableTimes: { 'type': 'array', 'itemType': CreateUserCodeInstanceRequestAvailableTimes },
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserCodeInstanceResponseBody extends $tea.Model {
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

export class NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
  fundToolName?: string;
  amount?: string;
  gmtCreate?: string;
  gmtFinish?: string;
  promotionFundTool?: boolean;
  extInfo?: string;
  static names(): { [key: string]: string } {
    return {
      fundToolName: 'fundToolName',
      amount: 'amount',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      promotionFundTool: 'promotionFundTool',
      extInfo: 'extInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fundToolName: 'string',
      amount: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      promotionFundTool: 'boolean',
      extInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodePayResultRequestPayChannelDetailList extends $tea.Model {
  payChannelName?: string;
  gmtCreate?: string;
  gmtFinish?: string;
  payChannelType?: string;
  amount?: string;
  payChannelOrderNo?: string;
  promotionAmount?: string;
  fundToolDetailList?: NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList[];
  static names(): { [key: string]: string } {
    return {
      payChannelName: 'payChannelName',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      payChannelType: 'payChannelType',
      amount: 'amount',
      payChannelOrderNo: 'payChannelOrderNo',
      promotionAmount: 'promotionAmount',
      fundToolDetailList: 'fundToolDetailList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payChannelName: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      payChannelType: 'string',
      amount: 'string',
      payChannelOrderNo: 'string',
      promotionAmount: 'string',
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyPayCodePayResultRequestPayChannelDetailListFundToolDetailList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpateUserCodeInstanceRequestAvailableTimes extends $tea.Model {
  gmtStart?: string;
  gmtEnd?: string;
  static names(): { [key: string]: string } {
    return {
      gmtStart: 'gmtStart',
      gmtEnd: 'gmtEnd',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtStart: 'string',
      gmtEnd: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeOrderResponseBodyBatchTradeOrderVOs extends $tea.Model {
  outBatchNo?: string;
  alipayTransId?: string;
  status?: string;
  successCount?: number;
  successAmount?: string;
  failCount?: number;
  failAmount?: string;
  totalAmount?: string;
  gmtFinish?: string;
  gmtSubmit?: string;
  failReason?: string;
  paymentAmount?: string;
  paymentCurrency?: string;
  payerStaffId?: string;
  static names(): { [key: string]: string } {
    return {
      outBatchNo: 'outBatchNo',
      alipayTransId: 'alipayTransId',
      status: 'status',
      successCount: 'successCount',
      successAmount: 'successAmount',
      failCount: 'failCount',
      failAmount: 'failAmount',
      totalAmount: 'totalAmount',
      gmtFinish: 'gmtFinish',
      gmtSubmit: 'gmtSubmit',
      failReason: 'failReason',
      paymentAmount: 'paymentAmount',
      paymentCurrency: 'paymentCurrency',
      payerStaffId: 'payerStaffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      outBatchNo: 'string',
      alipayTransId: 'string',
      status: 'string',
      successCount: 'number',
      successAmount: 'string',
      failCount: 'number',
      failAmount: 'string',
      totalAmount: 'string',
      gmtFinish: 'string',
      gmtSubmit: 'string',
      failReason: 'string',
      paymentAmount: 'string',
      paymentCurrency: 'string',
      payerStaffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBatchTradeOrderRequestBatchTradeDetails extends $tea.Model {
  serialNo?: number;
  amount?: string;
  payeeAccountName?: string;
  payeeAccountNo?: string;
  payeeAccountType?: string;
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      serialNo: 'serialNo',
      amount: 'amount',
      payeeAccountName: 'payeeAccountName',
      payeeAccountNo: 'payeeAccountNo',
      payeeAccountType: 'payeeAccountType',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      serialNo: 'number',
      amount: 'string',
      payeeAccountName: 'string',
      payeeAccountNo: 'string',
      payeeAccountType: 'string',
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
  fundToolName?: string;
  amount?: string;
  gmtCreate?: string;
  gmtFinish?: string;
  promotionFundTool?: boolean;
  extInfo?: string;
  static names(): { [key: string]: string } {
    return {
      fundToolName: 'fundToolName',
      amount: 'amount',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
      promotionFundTool: 'promotionFundTool',
      extInfo: 'extInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fundToolName: 'string',
      amount: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
      promotionFundTool: 'boolean',
      extInfo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyPayCodeRefundResultRequestPayChannelDetailList extends $tea.Model {
  payChannelName?: string;
  payChannelType?: string;
  amount?: string;
  payChannelOrderNo?: string;
  payChannelRefundOrderNo?: string;
  promotionAmount?: string;
  fundToolDetailList?: NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList[];
  static names(): { [key: string]: string } {
    return {
      payChannelName: 'payChannelName',
      payChannelType: 'payChannelType',
      amount: 'amount',
      payChannelOrderNo: 'payChannelOrderNo',
      payChannelRefundOrderNo: 'payChannelRefundOrderNo',
      promotionAmount: 'promotionAmount',
      fundToolDetailList: 'fundToolDetailList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payChannelName: 'string',
      payChannelType: 'string',
      amount: 'string',
      payChannelOrderNo: 'string',
      payChannelRefundOrderNo: 'string',
      promotionAmount: 'string',
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyPayCodeRefundResultRequestPayChannelDetailListFundToolDetailList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchTradeDetailListResponseBodyBatchTradeDetailList extends $tea.Model {
  serialNo?: number;
  detailNo?: string;
  payeeAccountNo?: string;
  payeeAccountType?: string;
  status?: string;
  payeeAccountName?: string;
  amount?: string;
  memo?: string;
  gmtCreate?: string;
  gmtFinish?: string;
  static names(): { [key: string]: string } {
    return {
      serialNo: 'serialNo',
      detailNo: 'detailNo',
      payeeAccountNo: 'payeeAccountNo',
      payeeAccountType: 'payeeAccountType',
      status: 'status',
      payeeAccountName: 'payeeAccountName',
      amount: 'amount',
      memo: 'memo',
      gmtCreate: 'gmtCreate',
      gmtFinish: 'gmtFinish',
    };
  }

  static types(): { [key: string]: any } {
    return {
      serialNo: 'number',
      detailNo: 'string',
      payeeAccountNo: 'string',
      payeeAccountType: 'string',
      status: 'string',
      payeeAccountName: 'string',
      amount: 'string',
      memo: 'string',
      gmtCreate: 'string',
      gmtFinish: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPayAccountListResponseBodyPayAccountVOList extends $tea.Model {
  accountNo?: string;
  accountName?: string;
  accountType?: string;
  accountRemark?: string;
  accountId?: string;
  accountClass?: string;
  static names(): { [key: string]: string } {
    return {
      accountNo: 'accountNo',
      accountName: 'accountName',
      accountType: 'accountType',
      accountRemark: 'accountRemark',
      accountId: 'accountId',
      accountClass: 'accountClass',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountNo: 'string',
      accountName: 'string',
      accountType: 'string',
      accountRemark: 'string',
      accountId: 'string',
      accountClass: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateUserCodeInstanceRequestAvailableTimes extends $tea.Model {
  gmtStart?: string;
  gmtEnd?: string;
  static names(): { [key: string]: string } {
    return {
      gmtStart: 'gmtStart',
      gmtEnd: 'gmtEnd',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtStart: 'string',
      gmtEnd: 'string',
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


  async notifyPayCodePayResult(request: NotifyPayCodePayResultRequest): Promise<NotifyPayCodePayResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyPayCodePayResultHeaders({ });
    return await this.notifyPayCodePayResultWithOptions(request, headers, runtime);
  }

  async notifyPayCodePayResultWithOptions(request: NotifyPayCodePayResultRequest, headers: NotifyPayCodePayResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyPayCodePayResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.payCode)) {
      body["payCode"] = request.payCode;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.gmtTradeCreate)) {
      body["gmtTradeCreate"] = request.gmtTradeCreate;
    }

    if (!Util.isUnset(request.gmtTradeFinish)) {
      body["gmtTradeFinish"] = request.gmtTradeFinish;
    }

    if (!Util.isUnset(request.tradeNo)) {
      body["tradeNo"] = request.tradeNo;
    }

    if (!Util.isUnset(request.tradeStatus)) {
      body["tradeStatus"] = request.tradeStatus;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.amount)) {
      body["amount"] = request.amount;
    }

    if (!Util.isUnset(request.promotionAmount)) {
      body["promotionAmount"] = request.promotionAmount;
    }

    if (!Util.isUnset(request.chargeAmount)) {
      body["chargeAmount"] = request.chargeAmount;
    }

    if (!Util.isUnset(request.payChannelDetailList)) {
      body["payChannelDetailList"] = request.payChannelDetailList;
    }

    if (!Util.isUnset(request.tradeErrorCode)) {
      body["tradeErrorCode"] = request.tradeErrorCode;
    }

    if (!Util.isUnset(request.tradeErrorMsg)) {
      body["tradeErrorMsg"] = request.tradeErrorMsg;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.merchantName)) {
      body["merchantName"] = request.merchantName;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<NotifyPayCodePayResultResponse>(await this.doROARequest("NotifyPayCodePayResult", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/payResults/notify`, "json", req, runtime), new NotifyPayCodePayResultResponse({}));
  }

  async upateUserCodeInstance(request: UpateUserCodeInstanceRequest): Promise<UpateUserCodeInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpateUserCodeInstanceHeaders({ });
    return await this.upateUserCodeInstanceWithOptions(request, headers, runtime);
  }

  async upateUserCodeInstanceWithOptions(request: UpateUserCodeInstanceRequest, headers: UpateUserCodeInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpateUserCodeInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.codeId)) {
      body["codeId"] = request.codeId;
    }

    if (!Util.isUnset(request.codeIdentity)) {
      body["codeIdentity"] = request.codeIdentity;
    }

    if (!Util.isUnset(request.codeValue)) {
      body["codeValue"] = request.codeValue;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.userCorpRelationType)) {
      body["userCorpRelationType"] = request.userCorpRelationType;
    }

    if (!Util.isUnset(request.userIdentity)) {
      body["userIdentity"] = request.userIdentity;
    }

    if (!Util.isUnset(request.gmtExpired)) {
      body["gmtExpired"] = request.gmtExpired;
    }

    if (!Util.isUnset(request.availableTimes)) {
      body["availableTimes"] = request.availableTimes;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpateUserCodeInstanceResponse>(await this.doROARequest("UpateUserCodeInstance", "finance_1.0", "HTTP", "PUT", "AK", `/v1.0/finance/payCodes/userInstances`, "json", req, runtime), new UpateUserCodeInstanceResponse({}));
  }

  async applyBatchPay(request: ApplyBatchPayRequest): Promise<ApplyBatchPayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApplyBatchPayHeaders({ });
    return await this.applyBatchPayWithOptions(request, headers, runtime);
  }

  async applyBatchPayWithOptions(request: ApplyBatchPayRequest, headers: ApplyBatchPayHeaders, runtime: $Util.RuntimeOptions): Promise<ApplyBatchPayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.staffId)) {
      body["staffId"] = request.staffId;
    }

    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.orderNo)) {
      body["orderNo"] = request.orderNo;
    }

    if (!Util.isUnset(request.transAmount)) {
      body["transAmount"] = request.transAmount;
    }

    if (!Util.isUnset(request.returnUrl)) {
      body["returnUrl"] = request.returnUrl;
    }

    if (!Util.isUnset(request.passBackParams)) {
      body["passBackParams"] = request.passBackParams;
    }

    if (!Util.isUnset(request.payTerminal)) {
      body["payTerminal"] = request.payTerminal;
    }

    if (!Util.isUnset(request.transExpireTime)) {
      body["transExpireTime"] = request.transExpireTime;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ApplyBatchPayResponse>(await this.doROARequest("ApplyBatchPay", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/batchTrades/orders/pay`, "json", req, runtime), new ApplyBatchPayResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<QueryBatchTradeOrderResponse>(await this.doROARequest("QueryBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/batchTrades/orders/query`, "json", req, runtime), new QueryBatchTradeOrderResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<DecodePayCodeResponse>(await this.doROARequest("DecodePayCode", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/decode`, "json", req, runtime), new DecodePayCodeResponse({}));
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

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<SaveCorpPayCodeResponse>(await this.doROARequest("SaveCorpPayCode", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/corpSettings`, "json", req, runtime), new SaveCorpPayCodeResponse({}));
  }

  async notifyVerifyResult(request: NotifyVerifyResultRequest): Promise<NotifyVerifyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyVerifyResultHeaders({ });
    return await this.notifyVerifyResultWithOptions(request, headers, runtime);
  }

  async notifyVerifyResultWithOptions(request: NotifyVerifyResultRequest, headers: NotifyVerifyResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyVerifyResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.payCode)) {
      body["payCode"] = request.payCode;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.userCorpRelationType)) {
      body["userCorpRelationType"] = request.userCorpRelationType;
    }

    if (!Util.isUnset(request.userIdentity)) {
      body["userIdentity"] = request.userIdentity;
    }

    if (!Util.isUnset(request.verifyTime)) {
      body["verifyTime"] = request.verifyTime;
    }

    if (!Util.isUnset(request.verifyResult)) {
      body["verifyResult"] = request.verifyResult;
    }

    if (!Util.isUnset(request.verifyLocation)) {
      body["verifyLocation"] = request.verifyLocation;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<NotifyVerifyResultResponse>(await this.doROARequest("NotifyVerifyResult", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/verifyResults/notify`, "json", req, runtime), new NotifyVerifyResultResponse({}));
  }

  async createBatchTradeOrder(request: CreateBatchTradeOrderRequest): Promise<CreateBatchTradeOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBatchTradeOrderHeaders({ });
    return await this.createBatchTradeOrderWithOptions(request, headers, runtime);
  }

  async createBatchTradeOrderWithOptions(request: CreateBatchTradeOrderRequest, headers: CreateBatchTradeOrderHeaders, runtime: $Util.RuntimeOptions): Promise<CreateBatchTradeOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.staffId)) {
      body["staffId"] = request.staffId;
    }

    if (!Util.isUnset(request.accountId)) {
      body["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.accountNo)) {
      body["accountNo"] = request.accountNo;
    }

    if (!Util.isUnset(request.tradeTitle)) {
      body["tradeTitle"] = request.tradeTitle;
    }

    if (!Util.isUnset(request.outBatchNo)) {
      body["outBatchNo"] = request.outBatchNo;
    }

    if (!Util.isUnset(request.batchRemark)) {
      body["batchRemark"] = request.batchRemark;
    }

    if (!Util.isUnset(request.totalCount)) {
      body["totalCount"] = request.totalCount;
    }

    if (!Util.isUnset(request.totalAmount)) {
      body["totalAmount"] = request.totalAmount;
    }

    if (!Util.isUnset(request.batchTradeDetails)) {
      body["batchTradeDetails"] = request.batchTradeDetails;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateBatchTradeOrderResponse>(await this.doROARequest("CreateBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/batchTrades/orders`, "json", req, runtime), new CreateBatchTradeOrderResponse({}));
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

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.tradeNo)) {
      body["tradeNo"] = request.tradeNo;
    }

    if (!Util.isUnset(request.refundOrderNo)) {
      body["refundOrderNo"] = request.refundOrderNo;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.refundAmount)) {
      body["refundAmount"] = request.refundAmount;
    }

    if (!Util.isUnset(request.refundPromotionAmount)) {
      body["refundPromotionAmount"] = request.refundPromotionAmount;
    }

    if (!Util.isUnset(request.gmtRefund)) {
      body["gmtRefund"] = request.gmtRefund;
    }

    if (!Util.isUnset(request.payChannelDetailList)) {
      body["payChannelDetailList"] = request.payChannelDetailList;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.payCode)) {
      body["payCode"] = request.payCode;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<NotifyPayCodeRefundResultResponse>(await this.doROARequest("NotifyPayCodeRefundResult", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/refundResults/notify`, "json", req, runtime), new NotifyPayCodeRefundResultResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryBatchTradeDetailListResponse>(await this.doROARequest("QueryBatchTradeDetailList", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/batchTrades/details`, "json", req, runtime), new QueryBatchTradeDetailListResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryPayAccountListResponse>(await this.doROARequest("QueryPayAccountList", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/payAccounts`, "json", req, runtime), new QueryPayAccountListResponse({}));
  }

  async createUserCodeInstance(request: CreateUserCodeInstanceRequest): Promise<CreateUserCodeInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateUserCodeInstanceHeaders({ });
    return await this.createUserCodeInstanceWithOptions(request, headers, runtime);
  }

  async createUserCodeInstanceWithOptions(request: CreateUserCodeInstanceRequest, headers: CreateUserCodeInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateUserCodeInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.requestId)) {
      body["requestId"] = request.requestId;
    }

    if (!Util.isUnset(request.codeIdentity)) {
      body["codeIdentity"] = request.codeIdentity;
    }

    if (!Util.isUnset(request.codeValue)) {
      body["codeValue"] = request.codeValue;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.userCorpRelationType)) {
      body["userCorpRelationType"] = request.userCorpRelationType;
    }

    if (!Util.isUnset(request.userIdentity)) {
      body["userIdentity"] = request.userIdentity;
    }

    if (!Util.isUnset(request.gmtExpired)) {
      body["gmtExpired"] = request.gmtExpired;
    }

    if (!Util.isUnset(request.availableTimes)) {
      body["availableTimes"] = request.availableTimes;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateUserCodeInstanceResponse>(await this.doROARequest("CreateUserCodeInstance", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/payCodes/userInstances`, "json", req, runtime), new CreateUserCodeInstanceResponse({}));
  }

}
