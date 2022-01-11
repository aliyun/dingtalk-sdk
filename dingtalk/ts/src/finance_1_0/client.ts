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
  instId?: string;
  subInstId?: string;
  payerUserId?: string;
  payChannel?: string;
  amount?: string;
  outTradeNo?: string;
  title?: string;
  remark?: string;
  timeOutExpress?: string;
  otherPayChannelDetailInfoList?: CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList[];
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      payerUserId: 'payerUserId',
      payChannel: 'payChannel',
      amount: 'amount',
      outTradeNo: 'outTradeNo',
      title: 'title',
      remark: 'remark',
      timeOutExpress: 'timeOutExpress',
      otherPayChannelDetailInfoList: 'otherPayChannelDetailInfoList',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      payerUserId: 'string',
      payChannel: 'string',
      amount: 'string',
      outTradeNo: 'string',
      title: 'string',
      remark: 'string',
      timeOutExpress: 'string',
      otherPayChannelDetailInfoList: { 'type': 'array', 'itemType': CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList },
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatWithholdingOrderAndPayResponseBody extends $tea.Model {
  instId?: string;
  subInstId?: string;
  payerStaffId?: string;
  payChannel?: string;
  amount?: string;
  outTradeNo?: string;
  title?: string;
  remark?: string;
  status?: string;
  orderNo?: string;
  gmtPay?: string;
  payChannelAccountNo?: string;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      payerStaffId: 'payerStaffId',
      payChannel: 'payChannel',
      amount: 'amount',
      outTradeNo: 'outTradeNo',
      title: 'title',
      remark: 'remark',
      status: 'status',
      orderNo: 'orderNo',
      gmtPay: 'gmtPay',
      payChannelAccountNo: 'payChannelAccountNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      payerStaffId: 'string',
      payChannel: 'string',
      amount: 'string',
      outTradeNo: 'string',
      title: 'string',
      remark: 'string',
      status: 'string',
      orderNo: 'string',
      gmtPay: 'string',
      payChannelAccountNo: 'string',
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
  instId?: string;
  subInstId?: string;
  userId?: string;
  remark?: string;
  payChannel?: string;
  subMerchantServiceName?: string;
  subMerchantServiceDesc?: string;
  subMerchantName?: string;
  bizCode?: string;
  bizScene?: string;
  signScene?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      userId: 'userId',
      remark: 'remark',
      payChannel: 'payChannel',
      subMerchantServiceName: 'subMerchantServiceName',
      subMerchantServiceDesc: 'subMerchantServiceDesc',
      subMerchantName: 'subMerchantName',
      bizCode: 'bizCode',
      bizScene: 'bizScene',
      signScene: 'signScene',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      userId: 'string',
      remark: 'string',
      payChannel: 'string',
      subMerchantServiceName: 'string',
      subMerchantServiceDesc: 'string',
      subMerchantName: 'string',
      bizCode: 'string',
      bizScene: 'string',
      signScene: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
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
  dingIsvOrgId?: number;
  dingOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      payCode: 'payCode',
      requestId: 'requestId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payCode: 'string',
      requestId: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
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
  codeIdentity?: string;
  codeId?: string;
  outBizId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      userInCorp: 'userInCorp',
      codeType: 'codeType',
      alipayCode: 'alipayCode',
      userCorpRelationType: 'userCorpRelationType',
      codeIdentity: 'codeIdentity',
      codeId: 'codeId',
      outBizId: 'outBizId',
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
      codeIdentity: 'string',
      codeId: 'string',
      outBizId: 'string',
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
  subInstId?: string;
  outTradeNo?: string;
  orderId?: string;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      outTradeNo: 'outTradeNo',
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      outTradeNo: 'string',
      orderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRegisterOrderResponseBody extends $tea.Model {
  instId?: string;
  subInstId?: string;
  outTradeNo?: string;
  orderId?: string;
  subInstName?: string;
  status?: string;
  gmtAudit?: string;
  failReason?: string;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      outTradeNo: 'outTradeNo',
      orderId: 'orderId',
      subInstName: 'subInstName',
      status: 'status',
      gmtAudit: 'gmtAudit',
      failReason: 'failReason',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      outTradeNo: 'string',
      orderId: 'string',
      subInstName: 'string',
      status: 'string',
      gmtAudit: 'string',
      failReason: 'string',
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
  instId?: string;
  subInstId?: string;
  userId?: string;
  bizCode?: string;
  bizScene?: string;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      userId: 'userId',
      bizCode: 'bizCode',
      bizScene: 'bizScene',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      userId: 'string',
      bizCode: 'string',
      bizScene: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserAgreementResponseBody extends $tea.Model {
  staffId?: string;
  corpId?: string;
  instId?: string;
  subInstId?: string;
  payChannel?: string;
  agreementNo?: string;
  payChannelAccountNo?: string;
  payChannelAccountName?: string;
  gmtSign?: string;
  status?: string;
  gmtValid?: string;
  gmtExpire?: string;
  static names(): { [key: string]: string } {
    return {
      staffId: 'staffId',
      corpId: 'corpId',
      instId: 'instId',
      subInstId: 'subInstId',
      payChannel: 'payChannel',
      agreementNo: 'agreementNo',
      payChannelAccountNo: 'payChannelAccountNo',
      payChannelAccountName: 'payChannelAccountName',
      gmtSign: 'gmtSign',
      status: 'status',
      gmtValid: 'gmtValid',
      gmtExpire: 'gmtExpire',
    };
  }

  static types(): { [key: string]: any } {
    return {
      staffId: 'string',
      corpId: 'string',
      instId: 'string',
      subInstId: 'string',
      payChannel: 'string',
      agreementNo: 'string',
      payChannelAccountNo: 'string',
      payChannelAccountName: 'string',
      gmtSign: 'string',
      status: 'string',
      gmtValid: 'string',
      gmtExpire: 'string',
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
  codeValueType?: string;
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
      codeValueType: 'codeValueType',
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
      codeValueType: 'string',
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
  codeDetailUrl?: string;
  static names(): { [key: string]: string } {
    return {
      codeId: 'codeId',
      codeDetailUrl: 'codeDetailUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeId: 'string',
      codeDetailUrl: 'string',
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
  instId?: string;
  payChannel?: string;
  imageType?: string;
  imageName?: string;
  imageContent?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      payChannel: 'payChannel',
      imageType: 'imageType',
      imageName: 'imageName',
      imageContent: 'imageContent',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      payChannel: 'string',
      imageType: 'string',
      imageName: 'string',
      imageContent: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
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
  extInfo?: { [key: string]: string };
  dingOrgId?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      codeIdentity: 'codeIdentity',
      corpId: 'corpId',
      status: 'status',
      extInfo: 'extInfo',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      codeIdentity: 'string',
      corpId: 'string',
      status: 'string',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingOrgId: 'number',
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
  extInfo?: { [key: string]: string };
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
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  verifyNo?: string;
  verifyEvent?: string;
  remark?: string;
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
      verifyNo: 'verifyNo',
      verifyEvent: 'verifyEvent',
      remark: 'remark',
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
      verifyNo: 'string',
      verifyEvent: 'string',
      remark: 'string',
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
  instId?: string;
  subInstId?: string;
  userId?: string;
  bizCode?: string;
  bizScene?: string;
  agreementNo?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      userId: 'userId',
      bizCode: 'bizCode',
      bizScene: 'bizScene',
      agreementNo: 'agreementNo',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      userId: 'string',
      bizCode: 'string',
      bizScene: 'string',
      agreementNo: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
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
  instId?: string;
  subInstId?: string;
  outTradeNo?: string;
  services?: string[];
  solution?: string;
  payChannel?: string;
  subInstBasicInfo?: ConsultCreateSubInstitutionRequestSubInstBasicInfo;
  subInstCertifyInfo?: ConsultCreateSubInstitutionRequestSubInstCertifyInfo;
  legalPersonCertInfo?: ConsultCreateSubInstitutionRequestLegalPersonCertInfo;
  settleInfo?: ConsultCreateSubInstitutionRequestSettleInfo;
  contractInfo?: ConsultCreateSubInstitutionRequestContractInfo;
  qualificationInfos?: ConsultCreateSubInstitutionRequestQualificationInfos[];
  subInstAuthInfo?: ConsultCreateSubInstitutionRequestSubInstAuthInfo;
  subInstAddressInfo?: ConsultCreateSubInstitutionRequestSubInstAddressInfo;
  subInstShopInfo?: ConsultCreateSubInstitutionRequestSubInstShopInfo;
  subInstInvoiceInfo?: ConsultCreateSubInstitutionRequestSubInstInvoiceInfo;
  bindingAlipayLogonId?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      outTradeNo: 'outTradeNo',
      services: 'services',
      solution: 'solution',
      payChannel: 'payChannel',
      subInstBasicInfo: 'subInstBasicInfo',
      subInstCertifyInfo: 'subInstCertifyInfo',
      legalPersonCertInfo: 'legalPersonCertInfo',
      settleInfo: 'settleInfo',
      contractInfo: 'contractInfo',
      qualificationInfos: 'qualificationInfos',
      subInstAuthInfo: 'subInstAuthInfo',
      subInstAddressInfo: 'subInstAddressInfo',
      subInstShopInfo: 'subInstShopInfo',
      subInstInvoiceInfo: 'subInstInvoiceInfo',
      bindingAlipayLogonId: 'bindingAlipayLogonId',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      outTradeNo: 'string',
      services: { 'type': 'array', 'itemType': 'string' },
      solution: 'string',
      payChannel: 'string',
      subInstBasicInfo: ConsultCreateSubInstitutionRequestSubInstBasicInfo,
      subInstCertifyInfo: ConsultCreateSubInstitutionRequestSubInstCertifyInfo,
      legalPersonCertInfo: ConsultCreateSubInstitutionRequestLegalPersonCertInfo,
      settleInfo: ConsultCreateSubInstitutionRequestSettleInfo,
      contractInfo: ConsultCreateSubInstitutionRequestContractInfo,
      qualificationInfos: { 'type': 'array', 'itemType': ConsultCreateSubInstitutionRequestQualificationInfos },
      subInstAuthInfo: ConsultCreateSubInstitutionRequestSubInstAuthInfo,
      subInstAddressInfo: ConsultCreateSubInstitutionRequestSubInstAddressInfo,
      subInstShopInfo: ConsultCreateSubInstitutionRequestSubInstShopInfo,
      subInstInvoiceInfo: ConsultCreateSubInstitutionRequestSubInstInvoiceInfo,
      bindingAlipayLogonId: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
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
  instId?: string;
  subInstId?: string;
  outTradeNo?: string;
  services?: string[];
  payChannel?: string;
  subInstBasicInfo?: ModifySubInstitutionRequestSubInstBasicInfo;
  subInstCertifyInfo?: ModifySubInstitutionRequestSubInstCertifyInfo;
  legalPersonCertInfo?: ModifySubInstitutionRequestLegalPersonCertInfo;
  settleInfo?: ModifySubInstitutionRequestSettleInfo;
  contractInfo?: ModifySubInstitutionRequestContractInfo;
  qualificationInfos?: ModifySubInstitutionRequestQualificationInfos[];
  subInstAuthInfo?: ModifySubInstitutionRequestSubInstAuthInfo;
  subInstAddressInfo?: ModifySubInstitutionRequestSubInstAddressInfo;
  subInstShopInfo?: ModifySubInstitutionRequestSubInstShopInfo;
  subInstInvoiceInfo?: ModifySubInstitutionRequestSubInstInvoiceInfo;
  bindingAlipayLogonId?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      outTradeNo: 'outTradeNo',
      services: 'services',
      payChannel: 'payChannel',
      subInstBasicInfo: 'subInstBasicInfo',
      subInstCertifyInfo: 'subInstCertifyInfo',
      legalPersonCertInfo: 'legalPersonCertInfo',
      settleInfo: 'settleInfo',
      contractInfo: 'contractInfo',
      qualificationInfos: 'qualificationInfos',
      subInstAuthInfo: 'subInstAuthInfo',
      subInstAddressInfo: 'subInstAddressInfo',
      subInstShopInfo: 'subInstShopInfo',
      subInstInvoiceInfo: 'subInstInvoiceInfo',
      bindingAlipayLogonId: 'bindingAlipayLogonId',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      outTradeNo: 'string',
      services: { 'type': 'array', 'itemType': 'string' },
      payChannel: 'string',
      subInstBasicInfo: ModifySubInstitutionRequestSubInstBasicInfo,
      subInstCertifyInfo: ModifySubInstitutionRequestSubInstCertifyInfo,
      legalPersonCertInfo: ModifySubInstitutionRequestLegalPersonCertInfo,
      settleInfo: ModifySubInstitutionRequestSettleInfo,
      contractInfo: ModifySubInstitutionRequestContractInfo,
      qualificationInfos: { 'type': 'array', 'itemType': ModifySubInstitutionRequestQualificationInfos },
      subInstAuthInfo: ModifySubInstitutionRequestSubInstAuthInfo,
      subInstAddressInfo: ModifySubInstitutionRequestSubInstAddressInfo,
      subInstShopInfo: ModifySubInstitutionRequestSubInstShopInfo,
      subInstInvoiceInfo: ModifySubInstitutionRequestSubInstInvoiceInfo,
      bindingAlipayLogonId: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
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
  instId?: string;
  subInstId?: string;
  outTradeNo?: string;
  services?: string[];
  solution?: string;
  payChannel?: string;
  subInstBasicInfo?: CreateSubInstitutionRequestSubInstBasicInfo;
  subInstCertifyInfo?: CreateSubInstitutionRequestSubInstCertifyInfo;
  legalPersonCertInfo?: CreateSubInstitutionRequestLegalPersonCertInfo;
  settleInfo?: CreateSubInstitutionRequestSettleInfo;
  contractInfo?: CreateSubInstitutionRequestContractInfo;
  qualificationInfos?: CreateSubInstitutionRequestQualificationInfos[];
  subInstAuthInfo?: CreateSubInstitutionRequestSubInstAuthInfo;
  subInstAddressInfo?: CreateSubInstitutionRequestSubInstAddressInfo;
  subInstShopInfo?: CreateSubInstitutionRequestSubInstShopInfo;
  subInstInvoiceInfo?: CreateSubInstitutionRequestSubInstInvoiceInfo;
  bindingAlipayLogonId?: string;
  dingOrgId?: number;
  dingIsvOrgId?: number;
  dingClientId?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      outTradeNo: 'outTradeNo',
      services: 'services',
      solution: 'solution',
      payChannel: 'payChannel',
      subInstBasicInfo: 'subInstBasicInfo',
      subInstCertifyInfo: 'subInstCertifyInfo',
      legalPersonCertInfo: 'legalPersonCertInfo',
      settleInfo: 'settleInfo',
      contractInfo: 'contractInfo',
      qualificationInfos: 'qualificationInfos',
      subInstAuthInfo: 'subInstAuthInfo',
      subInstAddressInfo: 'subInstAddressInfo',
      subInstShopInfo: 'subInstShopInfo',
      subInstInvoiceInfo: 'subInstInvoiceInfo',
      bindingAlipayLogonId: 'bindingAlipayLogonId',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingClientId: 'dingClientId',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      outTradeNo: 'string',
      services: { 'type': 'array', 'itemType': 'string' },
      solution: 'string',
      payChannel: 'string',
      subInstBasicInfo: CreateSubInstitutionRequestSubInstBasicInfo,
      subInstCertifyInfo: CreateSubInstitutionRequestSubInstCertifyInfo,
      legalPersonCertInfo: CreateSubInstitutionRequestLegalPersonCertInfo,
      settleInfo: CreateSubInstitutionRequestSettleInfo,
      contractInfo: CreateSubInstitutionRequestContractInfo,
      qualificationInfos: { 'type': 'array', 'itemType': CreateSubInstitutionRequestQualificationInfos },
      subInstAuthInfo: CreateSubInstitutionRequestSubInstAuthInfo,
      subInstAddressInfo: CreateSubInstitutionRequestSubInstAddressInfo,
      subInstShopInfo: CreateSubInstitutionRequestSubInstShopInfo,
      subInstInvoiceInfo: CreateSubInstitutionRequestSubInstInvoiceInfo,
      bindingAlipayLogonId: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
      dingClientId: 'string',
      dingTokenGrantType: 'number',
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
  instId?: string;
  subInstId?: string;
  payerStaffId?: string;
  payChannel?: string;
  amount?: string;
  outTradeNo?: string;
  title?: string;
  remark?: string;
  status?: string;
  orderNo?: string;
  gmtPay?: string;
  payChannelAccountNo?: string;
  gmtCreate?: string;
  static names(): { [key: string]: string } {
    return {
      instId: 'instId',
      subInstId: 'subInstId',
      payerStaffId: 'payerStaffId',
      payChannel: 'payChannel',
      amount: 'amount',
      outTradeNo: 'outTradeNo',
      title: 'title',
      remark: 'remark',
      status: 'status',
      orderNo: 'orderNo',
      gmtPay: 'gmtPay',
      payChannelAccountNo: 'payChannelAccountNo',
      gmtCreate: 'gmtCreate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instId: 'string',
      subInstId: 'string',
      payerStaffId: 'string',
      payChannel: 'string',
      amount: 'string',
      outTradeNo: 'string',
      title: 'string',
      remark: 'string',
      status: 'string',
      orderNo: 'string',
      gmtPay: 'string',
      payChannelAccountNo: 'string',
      gmtCreate: 'string',
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

export class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList extends $tea.Model {
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

export class CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoList extends $tea.Model {
  payChannelName?: string;
  payChannelType?: string;
  amount?: string;
  payChannelOrderNo?: string;
  promotionAmount?: string;
  fundToolDetailInfoList?: CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList[];
  static names(): { [key: string]: string } {
    return {
      payChannelName: 'payChannelName',
      payChannelType: 'payChannelType',
      amount: 'amount',
      payChannelOrderNo: 'payChannelOrderNo',
      promotionAmount: 'promotionAmount',
      fundToolDetailInfoList: 'fundToolDetailInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payChannelName: 'string',
      payChannelType: 'string',
      amount: 'string',
      payChannelOrderNo: 'string',
      promotionAmount: 'string',
      fundToolDetailInfoList: { 'type': 'array', 'itemType': CreatWithholdingOrderAndPayRequestOtherPayChannelDetailInfoListFundToolDetailInfoList },
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

export class ConsultCreateSubInstitutionRequestSubInstBasicInfo extends $tea.Model {
  subInstName?: string;
  aliasName?: string;
  type?: string;
  mcc?: string;
  static names(): { [key: string]: string } {
    return {
      subInstName: 'subInstName',
      aliasName: 'aliasName',
      type: 'type',
      mcc: 'mcc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subInstName: 'string',
      aliasName: 'string',
      type: 'string',
      mcc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstCertifyInfo extends $tea.Model {
  certNo?: string;
  certType?: string;
  certImage?: string;
  static names(): { [key: string]: string } {
    return {
      certNo: 'certNo',
      certType: 'certType',
      certImage: 'certImage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certNo: 'string',
      certType: 'string',
      certImage: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestLegalPersonCertInfo extends $tea.Model {
  certName?: string;
  idCardNo?: string;
  certFrontImage?: string;
  certBackImage?: string;
  certType?: string;
  static names(): { [key: string]: string } {
    return {
      certName: 'certName',
      idCardNo: 'idCardNo',
      certFrontImage: 'certFrontImage',
      certBackImage: 'certBackImage',
      certType: 'certType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certName: 'string',
      idCardNo: 'string',
      certFrontImage: 'string',
      certBackImage: 'string',
      certType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSettleInfo extends $tea.Model {
  type?: string;
  accountName?: string;
  accountId?: string;
  bankName?: string;
  bankBranchName?: string;
  bankShortNameCode?: string;
  bankCode?: string;
  bankProvince?: string;
  bankCity?: string;
  accountType?: string;
  usageType?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      accountName: 'accountName',
      accountId: 'accountId',
      bankName: 'bankName',
      bankBranchName: 'bankBranchName',
      bankShortNameCode: 'bankShortNameCode',
      bankCode: 'bankCode',
      bankProvince: 'bankProvince',
      bankCity: 'bankCity',
      accountType: 'accountType',
      usageType: 'usageType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      accountName: 'string',
      accountId: 'string',
      bankName: 'string',
      bankBranchName: 'string',
      bankShortNameCode: 'string',
      bankCode: 'string',
      bankProvince: 'string',
      bankCity: 'string',
      accountType: 'string',
      usageType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestContractInfo extends $tea.Model {
  contractName?: string;
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      contractName: 'contractName',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contractName: 'string',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestQualificationInfos extends $tea.Model {
  qualificationType?: string;
  qualificationImage?: string;
  static names(): { [key: string]: string } {
    return {
      qualificationType: 'qualificationType',
      qualificationImage: 'qualificationImage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      qualificationType: 'string',
      qualificationImage: 'string',
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

export class ConsultCreateSubInstitutionRequestSubInstAddressInfo extends $tea.Model {
  provinceCode?: string;
  cityCode?: string;
  districtCode?: string;
  address?: string;
  static names(): { [key: string]: string } {
    return {
      provinceCode: 'provinceCode',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      address: 'address',
    };
  }

  static types(): { [key: string]: any } {
    return {
      provinceCode: 'string',
      cityCode: 'string',
      districtCode: 'string',
      address: 'string',
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

export class ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress extends $tea.Model {
  provinceCode?: string;
  cityCode?: string;
  districtCode?: string;
  address?: string;
  static names(): { [key: string]: string } {
    return {
      provinceCode: 'provinceCode',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      address: 'address',
    };
  }

  static types(): { [key: string]: any } {
    return {
      provinceCode: 'string',
      cityCode: 'string',
      districtCode: 'string',
      address: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsultCreateSubInstitutionRequestSubInstInvoiceInfo extends $tea.Model {
  autoInvoice?: boolean;
  acceptElectronic?: boolean;
  taxPayerQualification?: string;
  title?: string;
  taxNo?: string;
  taxPayerValidDate?: string;
  address?: string;
  telephone?: string;
  bankAccount?: string;
  bankName?: string;
  mailName?: string;
  mailPhone?: string;
  mailAddress?: ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress;
  static names(): { [key: string]: string } {
    return {
      autoInvoice: 'autoInvoice',
      acceptElectronic: 'acceptElectronic',
      taxPayerQualification: 'taxPayerQualification',
      title: 'title',
      taxNo: 'taxNo',
      taxPayerValidDate: 'taxPayerValidDate',
      address: 'address',
      telephone: 'telephone',
      bankAccount: 'bankAccount',
      bankName: 'bankName',
      mailName: 'mailName',
      mailPhone: 'mailPhone',
      mailAddress: 'mailAddress',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoInvoice: 'boolean',
      acceptElectronic: 'boolean',
      taxPayerQualification: 'string',
      title: 'string',
      taxNo: 'string',
      taxPayerValidDate: 'string',
      address: 'string',
      telephone: 'string',
      bankAccount: 'string',
      bankName: 'string',
      mailName: 'string',
      mailPhone: 'string',
      mailAddress: ConsultCreateSubInstitutionRequestSubInstInvoiceInfoMailAddress,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstBasicInfo extends $tea.Model {
  subInstName?: string;
  aliasName?: string;
  type?: string;
  mcc?: string;
  static names(): { [key: string]: string } {
    return {
      subInstName: 'subInstName',
      aliasName: 'aliasName',
      type: 'type',
      mcc: 'mcc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subInstName: 'string',
      aliasName: 'string',
      type: 'string',
      mcc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstCertifyInfo extends $tea.Model {
  certNo?: string;
  certType?: string;
  certImage?: string;
  static names(): { [key: string]: string } {
    return {
      certNo: 'certNo',
      certType: 'certType',
      certImage: 'certImage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certNo: 'string',
      certType: 'string',
      certImage: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestLegalPersonCertInfo extends $tea.Model {
  certName?: string;
  idCardNo?: string;
  certFrontImage?: string;
  certBackImage?: string;
  certType?: string;
  static names(): { [key: string]: string } {
    return {
      certName: 'certName',
      idCardNo: 'idCardNo',
      certFrontImage: 'certFrontImage',
      certBackImage: 'certBackImage',
      certType: 'certType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certName: 'string',
      idCardNo: 'string',
      certFrontImage: 'string',
      certBackImage: 'string',
      certType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSettleInfo extends $tea.Model {
  type?: string;
  accountName?: string;
  accountId?: string;
  bankName?: string;
  bankBranchName?: string;
  bankShortNameCode?: string;
  bankCode?: string;
  bankProvince?: string;
  bankCity?: string;
  accountType?: string;
  usageType?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      accountName: 'accountName',
      accountId: 'accountId',
      bankName: 'bankName',
      bankBranchName: 'bankBranchName',
      bankShortNameCode: 'bankShortNameCode',
      bankCode: 'bankCode',
      bankProvince: 'bankProvince',
      bankCity: 'bankCity',
      accountType: 'accountType',
      usageType: 'usageType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      accountName: 'string',
      accountId: 'string',
      bankName: 'string',
      bankBranchName: 'string',
      bankShortNameCode: 'string',
      bankCode: 'string',
      bankProvince: 'string',
      bankCity: 'string',
      accountType: 'string',
      usageType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestContractInfo extends $tea.Model {
  contractName?: string;
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      contractName: 'contractName',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contractName: 'string',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestQualificationInfos extends $tea.Model {
  qualificationType?: string;
  qualificationImage?: string;
  static names(): { [key: string]: string } {
    return {
      qualificationType: 'qualificationType',
      qualificationImage: 'qualificationImage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      qualificationType: 'string',
      qualificationImage: 'string',
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

export class ModifySubInstitutionRequestSubInstAddressInfo extends $tea.Model {
  provinceCode?: string;
  cityCode?: string;
  districtCode?: string;
  address?: string;
  static names(): { [key: string]: string } {
    return {
      provinceCode: 'provinceCode',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      address: 'address',
    };
  }

  static types(): { [key: string]: any } {
    return {
      provinceCode: 'string',
      cityCode: 'string',
      districtCode: 'string',
      address: 'string',
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

export class ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress extends $tea.Model {
  provinceCode?: string;
  cityCode?: string;
  districtCode?: string;
  address?: string;
  static names(): { [key: string]: string } {
    return {
      provinceCode: 'provinceCode',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      address: 'address',
    };
  }

  static types(): { [key: string]: any } {
    return {
      provinceCode: 'string',
      cityCode: 'string',
      districtCode: 'string',
      address: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifySubInstitutionRequestSubInstInvoiceInfo extends $tea.Model {
  autoInvoice?: boolean;
  acceptElectronic?: boolean;
  taxPayerQualification?: string;
  title?: string;
  taxNo?: string;
  taxPayerValidDate?: string;
  address?: string;
  telephone?: string;
  bankAccount?: string;
  bankName?: string;
  mailName?: string;
  mailPhone?: string;
  mailAddress?: ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress;
  static names(): { [key: string]: string } {
    return {
      autoInvoice: 'autoInvoice',
      acceptElectronic: 'acceptElectronic',
      taxPayerQualification: 'taxPayerQualification',
      title: 'title',
      taxNo: 'taxNo',
      taxPayerValidDate: 'taxPayerValidDate',
      address: 'address',
      telephone: 'telephone',
      bankAccount: 'bankAccount',
      bankName: 'bankName',
      mailName: 'mailName',
      mailPhone: 'mailPhone',
      mailAddress: 'mailAddress',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoInvoice: 'boolean',
      acceptElectronic: 'boolean',
      taxPayerQualification: 'string',
      title: 'string',
      taxNo: 'string',
      taxPayerValidDate: 'string',
      address: 'string',
      telephone: 'string',
      bankAccount: 'string',
      bankName: 'string',
      mailName: 'string',
      mailPhone: 'string',
      mailAddress: ModifySubInstitutionRequestSubInstInvoiceInfoMailAddress,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstBasicInfo extends $tea.Model {
  subInstName?: string;
  aliasName?: string;
  type?: string;
  mcc?: string;
  static names(): { [key: string]: string } {
    return {
      subInstName: 'subInstName',
      aliasName: 'aliasName',
      type: 'type',
      mcc: 'mcc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subInstName: 'string',
      aliasName: 'string',
      type: 'string',
      mcc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstCertifyInfo extends $tea.Model {
  certNo?: string;
  certType?: string;
  certImage?: string;
  static names(): { [key: string]: string } {
    return {
      certNo: 'certNo',
      certType: 'certType',
      certImage: 'certImage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certNo: 'string',
      certType: 'string',
      certImage: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestLegalPersonCertInfo extends $tea.Model {
  certName?: string;
  idCardNo?: string;
  certFrontImage?: string;
  certBackImage?: string;
  certType?: string;
  static names(): { [key: string]: string } {
    return {
      certName: 'certName',
      idCardNo: 'idCardNo',
      certFrontImage: 'certFrontImage',
      certBackImage: 'certBackImage',
      certType: 'certType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      certName: 'string',
      idCardNo: 'string',
      certFrontImage: 'string',
      certBackImage: 'string',
      certType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSettleInfo extends $tea.Model {
  type?: string;
  accountName?: string;
  accountId?: string;
  bankName?: string;
  bankBranchName?: string;
  bankShortNameCode?: string;
  bankCode?: string;
  bankProvince?: string;
  bankCity?: string;
  accountType?: string;
  usageType?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
      accountName: 'accountName',
      accountId: 'accountId',
      bankName: 'bankName',
      bankBranchName: 'bankBranchName',
      bankShortNameCode: 'bankShortNameCode',
      bankCode: 'bankCode',
      bankProvince: 'bankProvince',
      bankCity: 'bankCity',
      accountType: 'accountType',
      usageType: 'usageType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
      accountName: 'string',
      accountId: 'string',
      bankName: 'string',
      bankBranchName: 'string',
      bankShortNameCode: 'string',
      bankCode: 'string',
      bankProvince: 'string',
      bankCity: 'string',
      accountType: 'string',
      usageType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestContractInfo extends $tea.Model {
  contractName?: string;
  mobile?: string;
  static names(): { [key: string]: string } {
    return {
      contractName: 'contractName',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contractName: 'string',
      mobile: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestQualificationInfos extends $tea.Model {
  qualificationType?: string;
  qualificationImage?: string;
  static names(): { [key: string]: string } {
    return {
      qualificationType: 'qualificationType',
      qualificationImage: 'qualificationImage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      qualificationType: 'string',
      qualificationImage: 'string',
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

export class CreateSubInstitutionRequestSubInstAddressInfo extends $tea.Model {
  provinceCode?: string;
  cityCode?: string;
  districtCode?: string;
  address?: string;
  static names(): { [key: string]: string } {
    return {
      provinceCode: 'provinceCode',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      address: 'address',
    };
  }

  static types(): { [key: string]: any } {
    return {
      provinceCode: 'string',
      cityCode: 'string',
      districtCode: 'string',
      address: 'string',
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

export class CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress extends $tea.Model {
  provinceCode?: string;
  cityCode?: string;
  districtCode?: string;
  address?: string;
  static names(): { [key: string]: string } {
    return {
      provinceCode: 'provinceCode',
      cityCode: 'cityCode',
      districtCode: 'districtCode',
      address: 'address',
    };
  }

  static types(): { [key: string]: any } {
    return {
      provinceCode: 'string',
      cityCode: 'string',
      districtCode: 'string',
      address: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSubInstitutionRequestSubInstInvoiceInfo extends $tea.Model {
  autoInvoice?: boolean;
  acceptElectronic?: boolean;
  taxPayerQualification?: string;
  title?: string;
  taxNo?: string;
  taxPayerValidDate?: string;
  address?: string;
  telephone?: string;
  bankAccount?: string;
  bankName?: string;
  mailName?: string;
  mailPhone?: string;
  mailAddress?: CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress;
  static names(): { [key: string]: string } {
    return {
      autoInvoice: 'autoInvoice',
      acceptElectronic: 'acceptElectronic',
      taxPayerQualification: 'taxPayerQualification',
      title: 'title',
      taxNo: 'taxNo',
      taxPayerValidDate: 'taxPayerValidDate',
      address: 'address',
      telephone: 'telephone',
      bankAccount: 'bankAccount',
      bankName: 'bankName',
      mailName: 'mailName',
      mailPhone: 'mailPhone',
      mailAddress: 'mailAddress',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoInvoice: 'boolean',
      acceptElectronic: 'boolean',
      taxPayerQualification: 'string',
      title: 'string',
      taxNo: 'string',
      taxPayerValidDate: 'string',
      address: 'string',
      telephone: 'string',
      bankAccount: 'string',
      bankName: 'string',
      mailName: 'string',
      mailPhone: 'string',
      mailAddress: CreateSubInstitutionRequestSubInstInvoiceInfoMailAddress,
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

  async creatWithholdingOrderAndPay(request: CreatWithholdingOrderAndPayRequest): Promise<CreatWithholdingOrderAndPayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatWithholdingOrderAndPayHeaders({ });
    return await this.creatWithholdingOrderAndPayWithOptions(request, headers, runtime);
  }

  async creatWithholdingOrderAndPayWithOptions(request: CreatWithholdingOrderAndPayRequest, headers: CreatWithholdingOrderAndPayHeaders, runtime: $Util.RuntimeOptions): Promise<CreatWithholdingOrderAndPayResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.payerUserId)) {
      body["payerUserId"] = request.payerUserId;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.amount)) {
      body["amount"] = request.amount;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.timeOutExpress)) {
      body["timeOutExpress"] = request.timeOutExpress;
    }

    if (!Util.isUnset(request.otherPayChannelDetailInfoList)) {
      body["otherPayChannelDetailInfoList"] = request.otherPayChannelDetailInfoList;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<CreatWithholdingOrderAndPayResponse>(await this.doROARequest("CreatWithholdingOrderAndPay", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/withholdingOrders`, "json", req, runtime), new CreatWithholdingOrderAndPayResponse({}));
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

  async userAgreementPageSign(request: UserAgreementPageSignRequest): Promise<UserAgreementPageSignResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserAgreementPageSignHeaders({ });
    return await this.userAgreementPageSignWithOptions(request, headers, runtime);
  }

  async userAgreementPageSignWithOptions(request: UserAgreementPageSignRequest, headers: UserAgreementPageSignHeaders, runtime: $Util.RuntimeOptions): Promise<UserAgreementPageSignResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.subMerchantServiceName)) {
      body["subMerchantServiceName"] = request.subMerchantServiceName;
    }

    if (!Util.isUnset(request.subMerchantServiceDesc)) {
      body["subMerchantServiceDesc"] = request.subMerchantServiceDesc;
    }

    if (!Util.isUnset(request.subMerchantName)) {
      body["subMerchantName"] = request.subMerchantName;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.bizScene)) {
      body["bizScene"] = request.bizScene;
    }

    if (!Util.isUnset(request.signScene)) {
      body["signScene"] = request.signScene;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<UserAgreementPageSignResponse>(await this.doROARequest("UserAgreementPageSign", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/userAgreements`, "json", req, runtime), new UserAgreementPageSignResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryUserAlipayAccountResponse>(await this.doROARequest("QueryUserAlipayAccount", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/userAlipayAccounts`, "json", req, runtime), new QueryUserAlipayAccountResponse({}));
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

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
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

    if (!Util.isUnset(request.subInstId)) {
      query["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      query["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.orderId)) {
      query["orderId"] = request.orderId;
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
    return $tea.cast<QueryRegisterOrderResponse>(await this.doROARequest("QueryRegisterOrder", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/institutions/subInstitutions/orders`, "json", req, runtime), new QueryRegisterOrderResponse({}));
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

  async queryUserAgreement(request: QueryUserAgreementRequest): Promise<QueryUserAgreementResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserAgreementHeaders({ });
    return await this.queryUserAgreementWithOptions(request, headers, runtime);
  }

  async queryUserAgreementWithOptions(request: QueryUserAgreementRequest, headers: QueryUserAgreementHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserAgreementResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      query["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      query["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
    }

    if (!Util.isUnset(request.bizCode)) {
      query["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.bizScene)) {
      query["bizScene"] = request.bizScene;
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
    return $tea.cast<QueryUserAgreementResponse>(await this.doROARequest("QueryUserAgreement", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/userAgreements`, "json", req, runtime), new QueryUserAgreementResponse({}));
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

    if (!Util.isUnset(request.codeValueType)) {
      body["codeValueType"] = request.codeValueType;
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

  async uploadRegisterImage(request: UploadRegisterImageRequest): Promise<UploadRegisterImageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadRegisterImageHeaders({ });
    return await this.uploadRegisterImageWithOptions(request, headers, runtime);
  }

  async uploadRegisterImageWithOptions(request: UploadRegisterImageRequest, headers: UploadRegisterImageHeaders, runtime: $Util.RuntimeOptions): Promise<UploadRegisterImageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset(request.imageType)) {
      body["imageType"] = request.imageType;
    }

    if (!Util.isUnset(request.imageName)) {
      body["imageName"] = request.imageName;
    }

    if (!Util.isUnset(request.imageContent)) {
      body["imageContent"] = request.imageContent;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<UploadRegisterImageResponse>(await this.doROARequest("UploadRegisterImage", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/images`, "json", req, runtime), new UploadRegisterImageResponse({}));
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

    if (!Util.isUnset(request.verifyNo)) {
      body["verifyNo"] = request.verifyNo;
    }

    if (!Util.isUnset(request.verifyEvent)) {
      body["verifyEvent"] = request.verifyEvent;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
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

  async unsignUserAgreement(request: UnsignUserAgreementRequest): Promise<UnsignUserAgreementResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UnsignUserAgreementHeaders({ });
    return await this.unsignUserAgreementWithOptions(request, headers, runtime);
  }

  async unsignUserAgreementWithOptions(request: UnsignUserAgreementRequest, headers: UnsignUserAgreementHeaders, runtime: $Util.RuntimeOptions): Promise<UnsignUserAgreementResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.bizCode)) {
      body["bizCode"] = request.bizCode;
    }

    if (!Util.isUnset(request.bizScene)) {
      body["bizScene"] = request.bizScene;
    }

    if (!Util.isUnset(request.agreementNo)) {
      body["agreementNo"] = request.agreementNo;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<UnsignUserAgreementResponse>(await this.doROARequest("UnsignUserAgreement", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/userAgreements/unsign`, "none", req, runtime), new UnsignUserAgreementResponse({}));
  }

  async consultCreateSubInstitution(request: ConsultCreateSubInstitutionRequest): Promise<ConsultCreateSubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsultCreateSubInstitutionHeaders({ });
    return await this.consultCreateSubInstitutionWithOptions(request, headers, runtime);
  }

  async consultCreateSubInstitutionWithOptions(request: ConsultCreateSubInstitutionRequest, headers: ConsultCreateSubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<ConsultCreateSubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.services)) {
      body["services"] = request.services;
    }

    if (!Util.isUnset(request.solution)) {
      body["solution"] = request.solution;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset($tea.toMap(request.subInstBasicInfo))) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstCertifyInfo))) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset($tea.toMap(request.legalPersonCertInfo))) {
      body["legalPersonCertInfo"] = request.legalPersonCertInfo;
    }

    if (!Util.isUnset($tea.toMap(request.settleInfo))) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset($tea.toMap(request.contractInfo))) {
      body["contractInfo"] = request.contractInfo;
    }

    if (!Util.isUnset(request.qualificationInfos)) {
      body["qualificationInfos"] = request.qualificationInfos;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAuthInfo))) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAddressInfo))) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstShopInfo))) {
      body["subInstShopInfo"] = request.subInstShopInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstInvoiceInfo))) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<ConsultCreateSubInstitutionResponse>(await this.doROARequest("ConsultCreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/subInstitutions/consult`, "json", req, runtime), new ConsultCreateSubInstitutionResponse({}));
  }

  async modifySubInstitution(request: ModifySubInstitutionRequest): Promise<ModifySubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifySubInstitutionHeaders({ });
    return await this.modifySubInstitutionWithOptions(request, headers, runtime);
  }

  async modifySubInstitutionWithOptions(request: ModifySubInstitutionRequest, headers: ModifySubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<ModifySubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.services)) {
      body["services"] = request.services;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset($tea.toMap(request.subInstBasicInfo))) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstCertifyInfo))) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset($tea.toMap(request.legalPersonCertInfo))) {
      body["legalPersonCertInfo"] = request.legalPersonCertInfo;
    }

    if (!Util.isUnset($tea.toMap(request.settleInfo))) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset($tea.toMap(request.contractInfo))) {
      body["contractInfo"] = request.contractInfo;
    }

    if (!Util.isUnset(request.qualificationInfos)) {
      body["qualificationInfos"] = request.qualificationInfos;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAuthInfo))) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAddressInfo))) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstShopInfo))) {
      body["subInstShopInfo"] = request.subInstShopInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstInvoiceInfo))) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<ModifySubInstitutionResponse>(await this.doROARequest("ModifySubInstitution", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/subInstitutions/modify`, "json", req, runtime), new ModifySubInstitutionResponse({}));
  }

  async createSubInstitution(request: CreateSubInstitutionRequest): Promise<CreateSubInstitutionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSubInstitutionHeaders({ });
    return await this.createSubInstitutionWithOptions(request, headers, runtime);
  }

  async createSubInstitutionWithOptions(request: CreateSubInstitutionRequest, headers: CreateSubInstitutionHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSubInstitutionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.instId)) {
      body["instId"] = request.instId;
    }

    if (!Util.isUnset(request.subInstId)) {
      body["subInstId"] = request.subInstId;
    }

    if (!Util.isUnset(request.outTradeNo)) {
      body["outTradeNo"] = request.outTradeNo;
    }

    if (!Util.isUnset(request.services)) {
      body["services"] = request.services;
    }

    if (!Util.isUnset(request.solution)) {
      body["solution"] = request.solution;
    }

    if (!Util.isUnset(request.payChannel)) {
      body["payChannel"] = request.payChannel;
    }

    if (!Util.isUnset($tea.toMap(request.subInstBasicInfo))) {
      body["subInstBasicInfo"] = request.subInstBasicInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstCertifyInfo))) {
      body["subInstCertifyInfo"] = request.subInstCertifyInfo;
    }

    if (!Util.isUnset($tea.toMap(request.legalPersonCertInfo))) {
      body["legalPersonCertInfo"] = request.legalPersonCertInfo;
    }

    if (!Util.isUnset($tea.toMap(request.settleInfo))) {
      body["settleInfo"] = request.settleInfo;
    }

    if (!Util.isUnset($tea.toMap(request.contractInfo))) {
      body["contractInfo"] = request.contractInfo;
    }

    if (!Util.isUnset(request.qualificationInfos)) {
      body["qualificationInfos"] = request.qualificationInfos;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAuthInfo))) {
      body["subInstAuthInfo"] = request.subInstAuthInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstAddressInfo))) {
      body["subInstAddressInfo"] = request.subInstAddressInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstShopInfo))) {
      body["subInstShopInfo"] = request.subInstShopInfo;
    }

    if (!Util.isUnset($tea.toMap(request.subInstInvoiceInfo))) {
      body["subInstInvoiceInfo"] = request.subInstInvoiceInfo;
    }

    if (!Util.isUnset(request.bindingAlipayLogonId)) {
      body["bindingAlipayLogonId"] = request.bindingAlipayLogonId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<CreateSubInstitutionResponse>(await this.doROARequest("CreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", `/v1.0/finance/institutions/subInstitutions`, "json", req, runtime), new CreateSubInstitutionResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryWithholdingOrderResponse>(await this.doROARequest("QueryWithholdingOrder", "finance_1.0", "HTTP", "GET", "AK", `/v1.0/finance/withholdingOrders`, "json", req, runtime), new QueryWithholdingOrderResponse({}));
  }

}
