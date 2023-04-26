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

export class CreateBadgeCodeUserInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBadgeCodeUserInstanceRequest extends $tea.Model {
  availableTimes?: CreateBadgeCodeUserInstanceRequestAvailableTimes[];
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
      availableTimes: { 'type': 'array', 'itemType': CreateBadgeCodeUserInstanceRequestAvailableTimes },
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

export class CreateBadgeCodeUserInstanceResponseBody extends $tea.Model {
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

export class CreateBadgeCodeUserInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateBadgeCodeUserInstanceResponseBody;
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
      body: CreateBadgeCodeUserInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBadgeNotifyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBadgeNotifyRequest extends $tea.Model {
  content?: string;
  msgId?: string;
  msgType?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      msgId: 'msgId',
      msgType: 'msgType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      msgId: 'string',
      msgType: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBadgeNotifyResponseBody extends $tea.Model {
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

export class CreateBadgeNotifyResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateBadgeNotifyResponseBody;
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
      body: CreateBadgeNotifyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodeBadgeCodeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodeBadgeCodeRequest extends $tea.Model {
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

export class DecodeBadgeCodeResponseBody extends $tea.Model {
  alipayCode?: string;
  codeId?: string;
  codeIdentity?: string;
  codeType?: string;
  corpId?: string;
  extInfo?: string;
  outBizId?: string;
  userCorpRelationType?: string;
  userId?: string;
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
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodeBadgeCodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DecodeBadgeCodeResponseBody;
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
      body: DecodeBadgeCodeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyBadgeCodePayResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyBadgeCodePayResultRequest extends $tea.Model {
  amount?: string;
  chargeAmount?: string;
  corpId?: string;
  extInfo?: string;
  gmtTradeCreate?: string;
  gmtTradeFinish?: string;
  merchantName?: string;
  payChannelDetailList?: NotifyBadgeCodePayResultRequestPayChannelDetailList[];
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
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodePayResultRequestPayChannelDetailList },
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

export class NotifyBadgeCodePayResultResponseBody extends $tea.Model {
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

export class NotifyBadgeCodePayResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: NotifyBadgeCodePayResultResponseBody;
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
      body: NotifyBadgeCodePayResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyBadgeCodeRefundResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyBadgeCodeRefundResultRequest extends $tea.Model {
  corpId?: string;
  gmtRefund?: string;
  payChannelDetailList?: NotifyBadgeCodeRefundResultRequestPayChannelDetailList[];
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
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodeRefundResultRequestPayChannelDetailList },
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

export class NotifyBadgeCodeRefundResultResponseBody extends $tea.Model {
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

export class NotifyBadgeCodeRefundResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: NotifyBadgeCodeRefundResultResponseBody;
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
      body: NotifyBadgeCodeRefundResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyBadgeCodeVerifyResultHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyBadgeCodeVerifyResultRequest extends $tea.Model {
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

export class NotifyBadgeCodeVerifyResultResponseBody extends $tea.Model {
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

export class NotifyBadgeCodeVerifyResultResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: NotifyBadgeCodeVerifyResultResponseBody;
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
      body: NotifyBadgeCodeVerifyResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBadgeCodeCorpInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBadgeCodeCorpInstanceRequest extends $tea.Model {
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

export class SaveBadgeCodeCorpInstanceResponseBody extends $tea.Model {
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

export class SaveBadgeCodeCorpInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SaveBadgeCodeCorpInstanceResponseBody;
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
      body: SaveBadgeCodeCorpInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBadgeCodeUserInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBadgeCodeUserInstanceRequest extends $tea.Model {
  availableTimes?: UpdateBadgeCodeUserInstanceRequestAvailableTimes[];
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
      availableTimes: { 'type': 'array', 'itemType': UpdateBadgeCodeUserInstanceRequestAvailableTimes },
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

export class UpdateBadgeCodeUserInstanceResponseBody extends $tea.Model {
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

export class UpdateBadgeCodeUserInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateBadgeCodeUserInstanceResponseBody;
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
      body: UpdateBadgeCodeUserInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBadgeCodeUserInstanceRequestAvailableTimes extends $tea.Model {
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

export class NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
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

export class NotifyBadgeCodePayResultRequestPayChannelDetailList extends $tea.Model {
  amount?: string;
  fundToolDetailList?: NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList[];
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
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList },
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

export class NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
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

export class NotifyBadgeCodeRefundResultRequestPayChannelDetailList extends $tea.Model {
  amount?: string;
  fundToolDetailList?: NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList[];
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
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList },
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

export class UpdateBadgeCodeUserInstanceRequestAvailableTimes extends $tea.Model {
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


  async createBadgeCodeUserInstanceWithOptions(request: CreateBadgeCodeUserInstanceRequest, headers: CreateBadgeCodeUserInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateBadgeCodeUserInstanceResponse> {
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
      action: "CreateBadgeCodeUserInstance",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/codes/userInstances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateBadgeCodeUserInstanceResponse>(await this.execute(params, req, runtime), new CreateBadgeCodeUserInstanceResponse({}));
  }

  async createBadgeCodeUserInstance(request: CreateBadgeCodeUserInstanceRequest): Promise<CreateBadgeCodeUserInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBadgeCodeUserInstanceHeaders({ });
    return await this.createBadgeCodeUserInstanceWithOptions(request, headers, runtime);
  }

  async createBadgeNotifyWithOptions(request: CreateBadgeNotifyRequest, headers: CreateBadgeNotifyHeaders, runtime: $Util.RuntimeOptions): Promise<CreateBadgeNotifyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.msgId)) {
      body["msgId"] = request.msgId;
    }

    if (!Util.isUnset(request.msgType)) {
      body["msgType"] = request.msgType;
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
      action: "CreateBadgeNotify",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/notices`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateBadgeNotifyResponse>(await this.execute(params, req, runtime), new CreateBadgeNotifyResponse({}));
  }

  async createBadgeNotify(request: CreateBadgeNotifyRequest): Promise<CreateBadgeNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBadgeNotifyHeaders({ });
    return await this.createBadgeNotifyWithOptions(request, headers, runtime);
  }

  async decodeBadgeCodeWithOptions(request: DecodeBadgeCodeRequest, headers: DecodeBadgeCodeHeaders, runtime: $Util.RuntimeOptions): Promise<DecodeBadgeCodeResponse> {
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
      action: "DecodeBadgeCode",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/codes/decode`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DecodeBadgeCodeResponse>(await this.execute(params, req, runtime), new DecodeBadgeCodeResponse({}));
  }

  async decodeBadgeCode(request: DecodeBadgeCodeRequest): Promise<DecodeBadgeCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DecodeBadgeCodeHeaders({ });
    return await this.decodeBadgeCodeWithOptions(request, headers, runtime);
  }

  async notifyBadgeCodePayResultWithOptions(request: NotifyBadgeCodePayResultRequest, headers: NotifyBadgeCodePayResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyBadgeCodePayResultResponse> {
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
      action: "NotifyBadgeCodePayResult",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/codes/payResults`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<NotifyBadgeCodePayResultResponse>(await this.execute(params, req, runtime), new NotifyBadgeCodePayResultResponse({}));
  }

  async notifyBadgeCodePayResult(request: NotifyBadgeCodePayResultRequest): Promise<NotifyBadgeCodePayResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyBadgeCodePayResultHeaders({ });
    return await this.notifyBadgeCodePayResultWithOptions(request, headers, runtime);
  }

  async notifyBadgeCodeRefundResultWithOptions(request: NotifyBadgeCodeRefundResultRequest, headers: NotifyBadgeCodeRefundResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyBadgeCodeRefundResultResponse> {
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
      action: "NotifyBadgeCodeRefundResult",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/codes/refundResults`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<NotifyBadgeCodeRefundResultResponse>(await this.execute(params, req, runtime), new NotifyBadgeCodeRefundResultResponse({}));
  }

  async notifyBadgeCodeRefundResult(request: NotifyBadgeCodeRefundResultRequest): Promise<NotifyBadgeCodeRefundResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyBadgeCodeRefundResultHeaders({ });
    return await this.notifyBadgeCodeRefundResultWithOptions(request, headers, runtime);
  }

  async notifyBadgeCodeVerifyResultWithOptions(request: NotifyBadgeCodeVerifyResultRequest, headers: NotifyBadgeCodeVerifyResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyBadgeCodeVerifyResultResponse> {
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
      action: "NotifyBadgeCodeVerifyResult",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/codes/verifyResults`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<NotifyBadgeCodeVerifyResultResponse>(await this.execute(params, req, runtime), new NotifyBadgeCodeVerifyResultResponse({}));
  }

  async notifyBadgeCodeVerifyResult(request: NotifyBadgeCodeVerifyResultRequest): Promise<NotifyBadgeCodeVerifyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyBadgeCodeVerifyResultHeaders({ });
    return await this.notifyBadgeCodeVerifyResultWithOptions(request, headers, runtime);
  }

  async saveBadgeCodeCorpInstanceWithOptions(request: SaveBadgeCodeCorpInstanceRequest, headers: SaveBadgeCodeCorpInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<SaveBadgeCodeCorpInstanceResponse> {
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
      action: "SaveBadgeCodeCorpInstance",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/codes/corpInstances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveBadgeCodeCorpInstanceResponse>(await this.execute(params, req, runtime), new SaveBadgeCodeCorpInstanceResponse({}));
  }

  async saveBadgeCodeCorpInstance(request: SaveBadgeCodeCorpInstanceRequest): Promise<SaveBadgeCodeCorpInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveBadgeCodeCorpInstanceHeaders({ });
    return await this.saveBadgeCodeCorpInstanceWithOptions(request, headers, runtime);
  }

  async updateBadgeCodeUserInstanceWithOptions(request: UpdateBadgeCodeUserInstanceRequest, headers: UpdateBadgeCodeUserInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateBadgeCodeUserInstanceResponse> {
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
      action: "UpdateBadgeCodeUserInstance",
      version: "badge_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/badge/codes/userInstances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateBadgeCodeUserInstanceResponse>(await this.execute(params, req, runtime), new UpdateBadgeCodeUserInstanceResponse({}));
  }

  async updateBadgeCodeUserInstance(request: UpdateBadgeCodeUserInstanceRequest): Promise<UpdateBadgeCodeUserInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateBadgeCodeUserInstanceHeaders({ });
    return await this.updateBadgeCodeUserInstanceWithOptions(request, headers, runtime);
  }

}
