// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  dingOrgId?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      payCode: 'payCode',
      requestId: 'requestId',
      dingOrgId: 'dingOrgId',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      payCode: 'string',
      requestId: 'string',
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodeBadgeCodeResponseBody extends $tea.Model {
  corpId?: string;
  userId?: string;
  codeType?: string;
  alipayCode?: string;
  userCorpRelationType?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      userId: 'userId',
      codeType: 'codeType',
      alipayCode: 'alipayCode',
      userCorpRelationType: 'userCorpRelationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      userId: 'string',
      codeType: 'string',
      alipayCode: 'string',
      userCorpRelationType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DecodeBadgeCodeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DecodeBadgeCodeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DecodeBadgeCodeResponseBody,
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
  codeId?: string;
  codeIdentity?: string;
  codeValue?: string;
  status?: string;
  corpId?: string;
  userCorpRelationType?: string;
  userIdentity?: string;
  gmtExpired?: string;
  availableTimes?: UpdateBadgeCodeUserInstanceRequestAvailableTimes[];
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
      availableTimes: { 'type': 'array', 'itemType': UpdateBadgeCodeUserInstanceRequestAvailableTimes },
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
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
  body: UpdateBadgeCodeUserInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateBadgeCodeUserInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  requestId?: string;
  codeIdentity?: string;
  codeValue?: string;
  status?: string;
  corpId?: string;
  userCorpRelationType?: string;
  userIdentity?: string;
  gmtExpired?: string;
  availableTimes?: CreateBadgeCodeUserInstanceRequestAvailableTimes[];
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
      availableTimes: { 'type': 'array', 'itemType': CreateBadgeCodeUserInstanceRequestAvailableTimes },
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateBadgeCodeUserInstanceResponseBody extends $tea.Model {
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

export class CreateBadgeCodeUserInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateBadgeCodeUserInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateBadgeCodeUserInstanceResponseBody,
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
  payChannelDetailList?: NotifyBadgeCodePayResultRequestPayChannelDetailList[];
  tradeErrorCode?: string;
  tradeErrorMsg?: string;
  extInfo?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
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
      dingOrgId: 'dingOrgId',
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
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodePayResultRequestPayChannelDetailList },
      tradeErrorCode: 'string',
      tradeErrorMsg: 'string',
      extInfo: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      merchantName: 'string',
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
  body: NotifyBadgeCodePayResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: NotifyBadgeCodePayResultResponseBody,
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
  status?: string;
  extInfo?: { [key: string]: any };
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
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      dingOrgId: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveBadgeCodeCorpInstanceResponseBody extends $tea.Model {
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

export class SaveBadgeCodeCorpInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SaveBadgeCodeCorpInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SaveBadgeCodeCorpInstanceResponseBody,
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
  userId?: string;
  tradeNo?: string;
  refundOrderNo?: string;
  remark?: string;
  refundAmount?: string;
  refundPromotionAmount?: string;
  gmtRefund?: string;
  payChannelDetailList?: NotifyBadgeCodeRefundResultRequestPayChannelDetailList[];
  dingIsvOrgId?: number;
  dingOrgId?: number;
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
      dingOrgId: 'dingOrgId',
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
      payChannelDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodeRefundResultRequestPayChannelDetailList },
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      payCode: 'string',
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
  body: NotifyBadgeCodeRefundResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: NotifyBadgeCodeVerifyResultResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: NotifyBadgeCodeVerifyResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateBadgeCodeUserInstanceRequestAvailableTimes extends $tea.Model {
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

export class CreateBadgeCodeUserInstanceRequestAvailableTimes extends $tea.Model {
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

export class NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
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

export class NotifyBadgeCodePayResultRequestPayChannelDetailList extends $tea.Model {
  payChannelName?: string;
  gmtCreate?: string;
  gmtFinish?: string;
  payChannelType?: string;
  amount?: string;
  payChannelOrderNo?: string;
  promotionAmount?: string;
  fundToolDetailList?: NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList[];
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
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodePayResultRequestPayChannelDetailListFundToolDetailList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList extends $tea.Model {
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

export class NotifyBadgeCodeRefundResultRequestPayChannelDetailList extends $tea.Model {
  payChannelName?: string;
  payChannelType?: string;
  amount?: string;
  payChannelOrderNo?: string;
  payChannelRefundOrderNo?: string;
  promotionAmount?: string;
  fundToolDetailList?: NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList[];
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
      fundToolDetailList: { 'type': 'array', 'itemType': NotifyBadgeCodeRefundResultRequestPayChannelDetailListFundToolDetailList },
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


  async decodeBadgeCode(request: DecodeBadgeCodeRequest): Promise<DecodeBadgeCodeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DecodeBadgeCodeHeaders({ });
    return await this.decodeBadgeCodeWithOptions(request, headers, runtime);
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
    return $tea.cast<DecodeBadgeCodeResponse>(await this.doROARequest("DecodeBadgeCode", "badge_1.0", "HTTP", "POST", "AK", `/v1.0/badge/codes/decode`, "json", req, runtime), new DecodeBadgeCodeResponse({}));
  }

  async updateBadgeCodeUserInstance(request: UpdateBadgeCodeUserInstanceRequest): Promise<UpdateBadgeCodeUserInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateBadgeCodeUserInstanceHeaders({ });
    return await this.updateBadgeCodeUserInstanceWithOptions(request, headers, runtime);
  }

  async updateBadgeCodeUserInstanceWithOptions(request: UpdateBadgeCodeUserInstanceRequest, headers: UpdateBadgeCodeUserInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateBadgeCodeUserInstanceResponse> {
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
    return $tea.cast<UpdateBadgeCodeUserInstanceResponse>(await this.doROARequest("UpdateBadgeCodeUserInstance", "badge_1.0", "HTTP", "PUT", "AK", `/v1.0/badge/codes/userInstances`, "json", req, runtime), new UpdateBadgeCodeUserInstanceResponse({}));
  }

  async createBadgeCodeUserInstance(request: CreateBadgeCodeUserInstanceRequest): Promise<CreateBadgeCodeUserInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateBadgeCodeUserInstanceHeaders({ });
    return await this.createBadgeCodeUserInstanceWithOptions(request, headers, runtime);
  }

  async createBadgeCodeUserInstanceWithOptions(request: CreateBadgeCodeUserInstanceRequest, headers: CreateBadgeCodeUserInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateBadgeCodeUserInstanceResponse> {
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
    return $tea.cast<CreateBadgeCodeUserInstanceResponse>(await this.doROARequest("CreateBadgeCodeUserInstance", "badge_1.0", "HTTP", "POST", "AK", `/v1.0/badge/codes/userInstances`, "json", req, runtime), new CreateBadgeCodeUserInstanceResponse({}));
  }

  async notifyBadgeCodePayResult(request: NotifyBadgeCodePayResultRequest): Promise<NotifyBadgeCodePayResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyBadgeCodePayResultHeaders({ });
    return await this.notifyBadgeCodePayResultWithOptions(request, headers, runtime);
  }

  async notifyBadgeCodePayResultWithOptions(request: NotifyBadgeCodePayResultRequest, headers: NotifyBadgeCodePayResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyBadgeCodePayResultResponse> {
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

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
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
    return $tea.cast<NotifyBadgeCodePayResultResponse>(await this.doROARequest("NotifyBadgeCodePayResult", "badge_1.0", "HTTP", "POST", "AK", `/v1.0/badge/codes/payResults`, "json", req, runtime), new NotifyBadgeCodePayResultResponse({}));
  }

  async saveBadgeCodeCorpInstance(request: SaveBadgeCodeCorpInstanceRequest): Promise<SaveBadgeCodeCorpInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveBadgeCodeCorpInstanceHeaders({ });
    return await this.saveBadgeCodeCorpInstanceWithOptions(request, headers, runtime);
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
    return $tea.cast<SaveBadgeCodeCorpInstanceResponse>(await this.doROARequest("SaveBadgeCodeCorpInstance", "badge_1.0", "HTTP", "POST", "AK", `/v1.0/badge/codes/corpInstances`, "json", req, runtime), new SaveBadgeCodeCorpInstanceResponse({}));
  }

  async notifyBadgeCodeRefundResult(request: NotifyBadgeCodeRefundResultRequest): Promise<NotifyBadgeCodeRefundResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyBadgeCodeRefundResultHeaders({ });
    return await this.notifyBadgeCodeRefundResultWithOptions(request, headers, runtime);
  }

  async notifyBadgeCodeRefundResultWithOptions(request: NotifyBadgeCodeRefundResultRequest, headers: NotifyBadgeCodeRefundResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyBadgeCodeRefundResultResponse> {
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

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
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
    return $tea.cast<NotifyBadgeCodeRefundResultResponse>(await this.doROARequest("NotifyBadgeCodeRefundResult", "badge_1.0", "HTTP", "POST", "AK", `/v1.0/badge/codes/refundResults`, "json", req, runtime), new NotifyBadgeCodeRefundResultResponse({}));
  }

  async notifyBadgeCodeVerifyResult(request: NotifyBadgeCodeVerifyResultRequest): Promise<NotifyBadgeCodeVerifyResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NotifyBadgeCodeVerifyResultHeaders({ });
    return await this.notifyBadgeCodeVerifyResultWithOptions(request, headers, runtime);
  }

  async notifyBadgeCodeVerifyResultWithOptions(request: NotifyBadgeCodeVerifyResultRequest, headers: NotifyBadgeCodeVerifyResultHeaders, runtime: $Util.RuntimeOptions): Promise<NotifyBadgeCodeVerifyResultResponse> {
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
    return $tea.cast<NotifyBadgeCodeVerifyResultResponse>(await this.doROARequest("NotifyBadgeCodeVerifyResult", "badge_1.0", "HTTP", "POST", "AK", `/v1.0/badge/codes/verifyResults`, "json", req, runtime), new NotifyBadgeCodeVerifyResultResponse({}));
  }

}
