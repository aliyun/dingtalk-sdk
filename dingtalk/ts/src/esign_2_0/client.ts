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

export class ApprovalListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApprovalListResponseBody extends $tea.Model {
  data?: ApprovalListResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': ApprovalListResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApprovalListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ApprovalListResponseBody;
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
      body: ApprovalListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthRequest extends $tea.Model {
  static names(): { [key: string]: string } {
    return {
    };
  }

  static types(): { [key: string]: any } {
    return {
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthResponseBody extends $tea.Model {
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

export class CancelCorpAuthResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CancelCorpAuthResponseBody;
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
      body: CancelCorpAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrdersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrdersRequest extends $tea.Model {
  itemCode?: string;
  itemName?: string;
  orderCreateTime?: number;
  orderId?: string;
  payFee?: number;
  quantity?: number;
  static names(): { [key: string]: string } {
    return {
      itemCode: 'itemCode',
      itemName: 'itemName',
      orderCreateTime: 'orderCreateTime',
      orderId: 'orderId',
      payFee: 'payFee',
      quantity: 'quantity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemCode: 'string',
      itemName: 'string',
      orderCreateTime: 'number',
      orderId: 'string',
      payFee: 'number',
      quantity: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrdersResponseBody extends $tea.Model {
  esignOrderId?: string;
  static names(): { [key: string]: string } {
    return {
      esignOrderId: 'esignOrderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      esignOrderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrdersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ChannelOrdersResponseBody;
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
      body: ChannelOrdersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpRealnameHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpRealnameRequest extends $tea.Model {
  redirectUrl?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      redirectUrl: 'redirectUrl',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      redirectUrl: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpRealnameResponseBody extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpRealnameResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CorpRealnameResponseBody;
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
      body: CorpRealnameResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDevelopersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDevelopersRequest extends $tea.Model {
  noticeUrl?: string;
  static names(): { [key: string]: string } {
    return {
      noticeUrl: 'noticeUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      noticeUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDevelopersResponseBody extends $tea.Model {
  data?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDevelopersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateDevelopersResponseBody;
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
      body: CreateDevelopersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessRequest extends $tea.Model {
  ccs?: CreateProcessRequestCcs[];
  files?: CreateProcessRequestFiles[];
  initiatorUserId?: string;
  participants?: CreateProcessRequestParticipants[];
  redirectUrl?: string;
  signEndTime?: number;
  sourceInfo?: CreateProcessRequestSourceInfo;
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      ccs: 'ccs',
      files: 'files',
      initiatorUserId: 'initiatorUserId',
      participants: 'participants',
      redirectUrl: 'redirectUrl',
      signEndTime: 'signEndTime',
      sourceInfo: 'sourceInfo',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ccs: { 'type': 'array', 'itemType': CreateProcessRequestCcs },
      files: { 'type': 'array', 'itemType': CreateProcessRequestFiles },
      initiatorUserId: 'string',
      participants: { 'type': 'array', 'itemType': CreateProcessRequestParticipants },
      redirectUrl: 'string',
      signEndTime: 'number',
      sourceInfo: CreateProcessRequestSourceInfo,
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessResponseBody extends $tea.Model {
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

export class CreateProcessResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateProcessResponseBody;
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
      body: CreateProcessResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachsApprovalHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  tsignOpenAppId?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      tsignOpenAppId: 'tsignOpenAppId',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      tsignOpenAppId: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachsApprovalResponseBody extends $tea.Model {
  data?: GetAttachsApprovalResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetAttachsApprovalResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachsApprovalResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAttachsApprovalResponseBody;
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
      body: GetAttachsApprovalResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthUrlRequest extends $tea.Model {
  redirectUrl?: string;
  static names(): { [key: string]: string } {
    return {
      redirectUrl: 'redirectUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      redirectUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthUrlResponseBody extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAuthUrlResponseBody;
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
      body: GetAuthUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContractMarginHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContractMarginResponseBody extends $tea.Model {
  margin?: number;
  static names(): { [key: string]: string } {
    return {
      margin: 'margin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      margin: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetContractMarginResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetContractMarginResponseBody;
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
      body: GetContractMarginResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpConsoleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpConsoleResponseBody extends $tea.Model {
  orgConsoleUrl?: string;
  static names(): { [key: string]: string } {
    return {
      orgConsoleUrl: 'orgConsoleUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgConsoleUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpConsoleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCorpConsoleResponseBody;
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
      body: GetCorpConsoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpInfoResponseBody extends $tea.Model {
  isRealName?: string;
  orgRealName?: string;
  static names(): { [key: string]: string } {
    return {
      isRealName: 'isRealName',
      orgRealName: 'orgRealName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isRealName: 'string',
      orgRealName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCorpInfoResponseBody;
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
      body: GetCorpInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetExecuteUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetExecuteUrlRequest extends $tea.Model {
  account?: string;
  signContainer?: number;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      account: 'account',
      signContainer: 'signContainer',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      account: 'string',
      signContainer: 'number',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetExecuteUrlResponseBody extends $tea.Model {
  longUrl?: string;
  mobileUrl?: string;
  pcUrl?: string;
  shortUrl?: string;
  static names(): { [key: string]: string } {
    return {
      longUrl: 'longUrl',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      shortUrl: 'shortUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      longUrl: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
      shortUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetExecuteUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetExecuteUrlResponseBody;
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
      body: GetExecuteUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileInfoResponseBody extends $tea.Model {
  downloadUrl?: string;
  fileId?: string;
  name?: string;
  pdfTotalPages?: number;
  size?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      downloadUrl: 'downloadUrl',
      fileId: 'fileId',
      name: 'name',
      pdfTotalPages: 'pdfTotalPages',
      size: 'size',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadUrl: 'string',
      fileId: 'string',
      name: 'string',
      pdfTotalPages: 'number',
      size: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFileInfoResponseBody;
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
      body: GetFileInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadUrlRequest extends $tea.Model {
  contentMd5?: string;
  contentType?: string;
  convert2Pdf?: boolean;
  fileName?: string;
  fileSize?: number;
  static names(): { [key: string]: string } {
    return {
      contentMd5: 'contentMd5',
      contentType: 'contentType',
      convert2Pdf: 'convert2Pdf',
      fileName: 'fileName',
      fileSize: 'fileSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentMd5: 'string',
      contentType: 'string',
      convert2Pdf: 'boolean',
      fileName: 'string',
      fileSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadUrlResponseBody extends $tea.Model {
  fileId?: string;
  uploadUrl?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      uploadUrl: 'uploadUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      uploadUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileUploadUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFileUploadUrlResponseBody;
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
      body: GetFileUploadUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponseBody extends $tea.Model {
  businessScene?: string;
  flowStatus?: number;
  initiatorAuthorizedName?: string;
  initiatorName?: string;
  logs?: GetFlowDetailResponseBodyLogs[];
  static names(): { [key: string]: string } {
    return {
      businessScene: 'businessScene',
      flowStatus: 'flowStatus',
      initiatorAuthorizedName: 'initiatorAuthorizedName',
      initiatorName: 'initiatorName',
      logs: 'logs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessScene: 'string',
      flowStatus: 'number',
      initiatorAuthorizedName: 'string',
      initiatorName: 'string',
      logs: { 'type': 'array', 'itemType': GetFlowDetailResponseBodyLogs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFlowDetailResponseBody;
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
      body: GetFlowDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDocsResponseBody extends $tea.Model {
  data?: GetFlowDocsResponseBodyData[];
  static names(): { [key: string]: string } {
    return {
      data: 'data',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': GetFlowDocsResponseBodyData },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDocsResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetFlowDocsResponseBody;
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
      body: GetFlowDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIsvStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIsvStatusResponseBody extends $tea.Model {
  authStatus?: string;
  installStatus?: string;
  static names(): { [key: string]: string } {
    return {
      authStatus: 'authStatus',
      installStatus: 'installStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authStatus: 'string',
      installStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIsvStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetIsvStatusResponseBody;
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
      body: GetIsvStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignDetailResponseBody extends $tea.Model {
  businessScene?: string;
  flowStatus?: number;
  signers?: GetSignDetailResponseBodySigners[];
  static names(): { [key: string]: string } {
    return {
      businessScene: 'businessScene',
      flowStatus: 'flowStatus',
      signers: 'signers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessScene: 'string',
      flowStatus: 'number',
      signers: { 'type': 'array', 'itemType': GetSignDetailResponseBodySigners },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSignDetailResponseBody;
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
      body: GetSignDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoResponseBody extends $tea.Model {
  isRealName?: string;
  userRealName?: string;
  static names(): { [key: string]: string } {
    return {
      isRealName: 'isRealName',
      userRealName: 'userRealName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isRealName: 'string',
      userRealName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserInfoResponseBody;
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
      body: GetUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartRequest extends $tea.Model {
  autoStart?: string;
  ccs?: ProcessStartRequestCcs[];
  files?: ProcessStartRequestFiles[];
  initiatorUserId?: string;
  participants?: ProcessStartRequestParticipants[];
  redirectUrl?: string;
  sourceInfo?: ProcessStartRequestSourceInfo;
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      autoStart: 'autoStart',
      ccs: 'ccs',
      files: 'files',
      initiatorUserId: 'initiatorUserId',
      participants: 'participants',
      redirectUrl: 'redirectUrl',
      sourceInfo: 'sourceInfo',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      autoStart: 'string',
      ccs: { 'type': 'array', 'itemType': ProcessStartRequestCcs },
      files: { 'type': 'array', 'itemType': ProcessStartRequestFiles },
      initiatorUserId: 'string',
      participants: { 'type': 'array', 'itemType': ProcessStartRequestParticipants },
      redirectUrl: 'string',
      sourceInfo: ProcessStartRequestSourceInfo,
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartResponseBody extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ProcessStartResponseBody;
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
      body: ProcessStartResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResaleOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResaleOrderRequest extends $tea.Model {
  orderCreateTime?: number;
  orderId?: string;
  quantity?: number;
  serviceStartTime?: number;
  serviceStopTime?: number;
  static names(): { [key: string]: string } {
    return {
      orderCreateTime: 'orderCreateTime',
      orderId: 'orderId',
      quantity: 'quantity',
      serviceStartTime: 'serviceStartTime',
      serviceStopTime: 'serviceStopTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderCreateTime: 'number',
      orderId: 'string',
      quantity: 'number',
      serviceStartTime: 'number',
      serviceStopTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResaleOrderResponseBody extends $tea.Model {
  esignOrderId?: string;
  static names(): { [key: string]: string } {
    return {
      esignOrderId: 'esignOrderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      esignOrderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResaleOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ResaleOrderResponseBody;
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
      body: ResaleOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UsersRealnameHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  serviceGroup?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      serviceGroup: 'serviceGroup',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      serviceGroup: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UsersRealnameRequest extends $tea.Model {
  redirectUrl?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      redirectUrl: 'redirectUrl',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      redirectUrl: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UsersRealnameResponseBody extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UsersRealnameResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UsersRealnameResponseBody;
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
      body: UsersRealnameResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApprovalListResponseBodyDataApprovalNodes extends $tea.Model {
  approvalTime?: string;
  approverName?: string;
  startTime?: number;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      approvalTime: 'approvalTime',
      approverName: 'approverName',
      startTime: 'startTime',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approvalTime: 'string',
      approverName: 'string',
      startTime: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApprovalListResponseBodyData extends $tea.Model {
  approvalName?: string;
  approvalNodes?: ApprovalListResponseBodyDataApprovalNodes[];
  endTime?: number;
  refuseReason?: string;
  sealIdImg?: string;
  sponsorAccountName?: string;
  startTime?: number;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      approvalName: 'approvalName',
      approvalNodes: 'approvalNodes',
      endTime: 'endTime',
      refuseReason: 'refuseReason',
      sealIdImg: 'sealIdImg',
      sponsorAccountName: 'sponsorAccountName',
      startTime: 'startTime',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      approvalName: 'string',
      approvalNodes: { 'type': 'array', 'itemType': ApprovalListResponseBodyDataApprovalNodes },
      endTime: 'number',
      refuseReason: 'string',
      sealIdImg: 'string',
      sponsorAccountName: 'string',
      startTime: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessRequestCcs extends $tea.Model {
  account?: string;
  accountName?: string;
  accountType?: string;
  orgName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      account: 'account',
      accountName: 'accountName',
      accountType: 'accountType',
      orgName: 'orgName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      account: 'string',
      accountName: 'string',
      accountType: 'string',
      orgName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessRequestFiles extends $tea.Model {
  fileId?: string;
  fileName?: string;
  fileType?: number;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileType: 'fileType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessRequestParticipantsSignPosListSignDate extends $tea.Model {
  format?: string;
  static names(): { [key: string]: string } {
    return {
      format: 'format',
    };
  }

  static types(): { [key: string]: any } {
    return {
      format: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessRequestParticipantsSignPosList extends $tea.Model {
  fileId?: string;
  isCrossPage?: boolean;
  needSignDate?: boolean;
  page?: string;
  signDate?: CreateProcessRequestParticipantsSignPosListSignDate;
  signRequirement?: string;
  x?: number;
  y?: number;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      isCrossPage: 'isCrossPage',
      needSignDate: 'needSignDate',
      page: 'page',
      signDate: 'signDate',
      signRequirement: 'signRequirement',
      x: 'x',
      y: 'y',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      isCrossPage: 'boolean',
      needSignDate: 'boolean',
      page: 'string',
      signDate: CreateProcessRequestParticipantsSignPosListSignDate,
      signRequirement: 'string',
      x: 'number',
      y: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessRequestParticipants extends $tea.Model {
  account?: string;
  accountName?: string;
  accountType?: string;
  orgName?: string;
  signOrder?: number;
  signPosList?: CreateProcessRequestParticipantsSignPosList[];
  signRequirements?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      account: 'account',
      accountName: 'accountName',
      accountType: 'accountType',
      orgName: 'orgName',
      signOrder: 'signOrder',
      signPosList: 'signPosList',
      signRequirements: 'signRequirements',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      account: 'string',
      accountName: 'string',
      accountType: 'string',
      orgName: 'string',
      signOrder: 'number',
      signPosList: { 'type': 'array', 'itemType': CreateProcessRequestParticipantsSignPosList },
      signRequirements: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateProcessRequestSourceInfo extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  showText?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      showText: 'showText',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
      showText: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachsApprovalResponseBodyDataFiles extends $tea.Model {
  fileName?: string;
  originalFileUrl?: string;
  signFinishFileUrl?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      originalFileUrl: 'originalFileUrl',
      signFinishFileUrl: 'signFinishFileUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      originalFileUrl: 'string',
      signFinishFileUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAttachsApprovalResponseBodyData extends $tea.Model {
  files?: GetAttachsApprovalResponseBodyDataFiles[];
  flowId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      files: 'files',
      flowId: 'flowId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      files: { 'type': 'array', 'itemType': GetAttachsApprovalResponseBodyDataFiles },
      flowId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponseBodyLogs extends $tea.Model {
  logType?: string;
  operateDescription?: string;
  operateTime?: number;
  operatorAccountName?: string;
  static names(): { [key: string]: string } {
    return {
      logType: 'logType',
      operateDescription: 'operateDescription',
      operateTime: 'operateTime',
      operatorAccountName: 'operatorAccountName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      logType: 'string',
      operateDescription: 'string',
      operateTime: 'number',
      operatorAccountName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDocsResponseBodyData extends $tea.Model {
  fileId?: string;
  fileName?: string;
  fileUrl?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
      fileUrl: 'fileUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
      fileUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignDetailResponseBodySigners extends $tea.Model {
  signStatus?: number;
  signerName?: string;
  static names(): { [key: string]: string } {
    return {
      signStatus: 'signStatus',
      signerName: 'signerName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      signStatus: 'number',
      signerName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartRequestCcs extends $tea.Model {
  account?: string;
  accountName?: string;
  accountType?: string;
  orgName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      account: 'account',
      accountName: 'accountName',
      accountType: 'accountType',
      orgName: 'orgName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      account: 'string',
      accountName: 'string',
      accountType: 'string',
      orgName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartRequestFiles extends $tea.Model {
  fileId?: string;
  fileName?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      fileName: 'fileName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      fileName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartRequestParticipants extends $tea.Model {
  account?: string;
  accountName?: string;
  accountType?: string;
  orgName?: string;
  signRequirements?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      account: 'account',
      accountName: 'accountName',
      accountType: 'accountType',
      orgName: 'orgName',
      signRequirements: 'signRequirements',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      account: 'string',
      accountName: 'string',
      accountType: 'string',
      orgName: 'string',
      signRequirements: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ProcessStartRequestSourceInfo extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  showText?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
      showText: 'showText',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
      showText: 'string',
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


  async approvalListWithOptions(taskId: string, headers: ApprovalListHeaders, runtime: $Util.RuntimeOptions): Promise<ApprovalListResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "ApprovalList",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/approvals/${taskId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ApprovalListResponse>(await this.execute(params, req, runtime), new ApprovalListResponse({}));
  }

  async approvalList(taskId: string): Promise<ApprovalListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApprovalListHeaders({ });
    return await this.approvalListWithOptions(taskId, headers, runtime);
  }

  async cancelCorpAuthWithOptions(request: CancelCorpAuthRequest, headers: CancelCorpAuthHeaders, runtime: $Util.RuntimeOptions): Promise<CancelCorpAuthResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "CancelCorpAuth",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/auths/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CancelCorpAuthResponse>(await this.execute(params, req, runtime), new CancelCorpAuthResponse({}));
  }

  async cancelCorpAuth(request: CancelCorpAuthRequest): Promise<CancelCorpAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelCorpAuthHeaders({ });
    return await this.cancelCorpAuthWithOptions(request, headers, runtime);
  }

  async channelOrdersWithOptions(request: ChannelOrdersRequest, headers: ChannelOrdersHeaders, runtime: $Util.RuntimeOptions): Promise<ChannelOrdersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.itemCode)) {
      body["itemCode"] = request.itemCode;
    }

    if (!Util.isUnset(request.itemName)) {
      body["itemName"] = request.itemName;
    }

    if (!Util.isUnset(request.orderCreateTime)) {
      body["orderCreateTime"] = request.orderCreateTime;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.payFee)) {
      body["payFee"] = request.payFee;
    }

    if (!Util.isUnset(request.quantity)) {
      body["quantity"] = request.quantity;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ChannelOrders",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/orders/channel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ChannelOrdersResponse>(await this.execute(params, req, runtime), new ChannelOrdersResponse({}));
  }

  async channelOrders(request: ChannelOrdersRequest): Promise<ChannelOrdersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChannelOrdersHeaders({ });
    return await this.channelOrdersWithOptions(request, headers, runtime);
  }

  async corpRealnameWithOptions(request: CorpRealnameRequest, headers: CorpRealnameHeaders, runtime: $Util.RuntimeOptions): Promise<CorpRealnameResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CorpRealname",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/corps/realnames`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CorpRealnameResponse>(await this.execute(params, req, runtime), new CorpRealnameResponse({}));
  }

  async corpRealname(request: CorpRealnameRequest): Promise<CorpRealnameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CorpRealnameHeaders({ });
    return await this.corpRealnameWithOptions(request, headers, runtime);
  }

  async createDevelopersWithOptions(request: CreateDevelopersRequest, headers: CreateDevelopersHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDevelopersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.noticeUrl)) {
      body["noticeUrl"] = request.noticeUrl;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateDevelopers",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/developers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateDevelopersResponse>(await this.execute(params, req, runtime), new CreateDevelopersResponse({}));
  }

  async createDevelopers(request: CreateDevelopersRequest): Promise<CreateDevelopersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDevelopersHeaders({ });
    return await this.createDevelopersWithOptions(request, headers, runtime);
  }

  async createProcessWithOptions(request: CreateProcessRequest, headers: CreateProcessHeaders, runtime: $Util.RuntimeOptions): Promise<CreateProcessResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ccs)) {
      body["ccs"] = request.ccs;
    }

    if (!Util.isUnset(request.files)) {
      body["files"] = request.files;
    }

    if (!Util.isUnset(request.initiatorUserId)) {
      body["initiatorUserId"] = request.initiatorUserId;
    }

    if (!Util.isUnset(request.participants)) {
      body["participants"] = request.participants;
    }

    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset(request.signEndTime)) {
      body["signEndTime"] = request.signEndTime;
    }

    if (!Util.isUnset(request.sourceInfo)) {
      body["sourceInfo"] = request.sourceInfo;
    }

    if (!Util.isUnset(request.taskName)) {
      body["taskName"] = request.taskName;
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
      action: "CreateProcess",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/process/startAtOnce`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateProcessResponse>(await this.execute(params, req, runtime), new CreateProcessResponse({}));
  }

  async createProcess(request: CreateProcessRequest): Promise<CreateProcessResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateProcessHeaders({ });
    return await this.createProcessWithOptions(request, headers, runtime);
  }

  async getAttachsApprovalWithOptions(instanceId: string, headers: GetAttachsApprovalHeaders, runtime: $Util.RuntimeOptions): Promise<GetAttachsApprovalResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.tsignOpenAppId)) {
      realHeaders["tsignOpenAppId"] = Util.toJSONString(headers.tsignOpenAppId);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetAttachsApproval",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/dingInstances/${instanceId}/attachments`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetAttachsApprovalResponse>(await this.execute(params, req, runtime), new GetAttachsApprovalResponse({}));
  }

  async getAttachsApproval(instanceId: string): Promise<GetAttachsApprovalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAttachsApprovalHeaders({ });
    return await this.getAttachsApprovalWithOptions(instanceId, headers, runtime);
  }

  async getAuthUrlWithOptions(request: GetAuthUrlRequest, headers: GetAuthUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetAuthUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetAuthUrl",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/auths/urls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetAuthUrlResponse>(await this.execute(params, req, runtime), new GetAuthUrlResponse({}));
  }

  async getAuthUrl(request: GetAuthUrlRequest): Promise<GetAuthUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAuthUrlHeaders({ });
    return await this.getAuthUrlWithOptions(request, headers, runtime);
  }

  async getContractMarginWithOptions(headers: GetContractMarginHeaders, runtime: $Util.RuntimeOptions): Promise<GetContractMarginResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetContractMargin",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/margins`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetContractMarginResponse>(await this.execute(params, req, runtime), new GetContractMarginResponse({}));
  }

  async getContractMargin(): Promise<GetContractMarginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetContractMarginHeaders({ });
    return await this.getContractMarginWithOptions(headers, runtime);
  }

  async getCorpConsoleWithOptions(headers: GetCorpConsoleHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpConsoleResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetCorpConsole",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/corps/consoles`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetCorpConsoleResponse>(await this.execute(params, req, runtime), new GetCorpConsoleResponse({}));
  }

  async getCorpConsole(): Promise<GetCorpConsoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpConsoleHeaders({ });
    return await this.getCorpConsoleWithOptions(headers, runtime);
  }

  async getCorpInfoWithOptions(headers: GetCorpInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpInfoResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetCorpInfo",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/corps/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetCorpInfoResponse>(await this.execute(params, req, runtime), new GetCorpInfoResponse({}));
  }

  async getCorpInfo(): Promise<GetCorpInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpInfoHeaders({ });
    return await this.getCorpInfoWithOptions(headers, runtime);
  }

  async getExecuteUrlWithOptions(request: GetExecuteUrlRequest, headers: GetExecuteUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetExecuteUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.account)) {
      body["account"] = request.account;
    }

    if (!Util.isUnset(request.signContainer)) {
      body["signContainer"] = request.signContainer;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetExecuteUrl",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/process/executeUrls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetExecuteUrlResponse>(await this.execute(params, req, runtime), new GetExecuteUrlResponse({}));
  }

  async getExecuteUrl(request: GetExecuteUrlRequest): Promise<GetExecuteUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetExecuteUrlHeaders({ });
    return await this.getExecuteUrlWithOptions(request, headers, runtime);
  }

  async getFileInfoWithOptions(fileId: string, headers: GetFileInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileInfoResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetFileInfo",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/files/${fileId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFileInfoResponse>(await this.execute(params, req, runtime), new GetFileInfoResponse({}));
  }

  async getFileInfo(fileId: string): Promise<GetFileInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileInfoHeaders({ });
    return await this.getFileInfoWithOptions(fileId, headers, runtime);
  }

  async getFileUploadUrlWithOptions(request: GetFileUploadUrlRequest, headers: GetFileUploadUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileUploadUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.contentMd5)) {
      body["contentMd5"] = request.contentMd5;
    }

    if (!Util.isUnset(request.contentType)) {
      body["contentType"] = request.contentType;
    }

    if (!Util.isUnset(request.convert2Pdf)) {
      body["convert2Pdf"] = request.convert2Pdf;
    }

    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileSize)) {
      body["fileSize"] = request.fileSize;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetFileUploadUrl",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/files/uploadUrls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFileUploadUrlResponse>(await this.execute(params, req, runtime), new GetFileUploadUrlResponse({}));
  }

  async getFileUploadUrl(request: GetFileUploadUrlRequest): Promise<GetFileUploadUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileUploadUrlHeaders({ });
    return await this.getFileUploadUrlWithOptions(request, headers, runtime);
  }

  async getFlowDetailWithOptions(taskId: string, headers: GetFlowDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlowDetailResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetFlowDetail",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/flowTasks/${taskId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFlowDetailResponse>(await this.execute(params, req, runtime), new GetFlowDetailResponse({}));
  }

  async getFlowDetail(taskId: string): Promise<GetFlowDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowDetailHeaders({ });
    return await this.getFlowDetailWithOptions(taskId, headers, runtime);
  }

  async getFlowDocsWithOptions(taskId: string, headers: GetFlowDocsHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlowDocsResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetFlowDocs",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/flowTasks/${taskId}/docs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFlowDocsResponse>(await this.execute(params, req, runtime), new GetFlowDocsResponse({}));
  }

  async getFlowDocs(taskId: string): Promise<GetFlowDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowDocsHeaders({ });
    return await this.getFlowDocsWithOptions(taskId, headers, runtime);
  }

  async getIsvStatusWithOptions(headers: GetIsvStatusHeaders, runtime: $Util.RuntimeOptions): Promise<GetIsvStatusResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetIsvStatus",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/corps/appStatus`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetIsvStatusResponse>(await this.execute(params, req, runtime), new GetIsvStatusResponse({}));
  }

  async getIsvStatus(): Promise<GetIsvStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIsvStatusHeaders({ });
    return await this.getIsvStatusWithOptions(headers, runtime);
  }

  async getSignDetailWithOptions(taskId: string, headers: GetSignDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignDetailResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetSignDetail",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/signTasks/${taskId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetSignDetailResponse>(await this.execute(params, req, runtime), new GetSignDetailResponse({}));
  }

  async getSignDetail(taskId: string): Promise<GetSignDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignDetailHeaders({ });
    return await this.getSignDetailWithOptions(taskId, headers, runtime);
  }

  async getUserInfoWithOptions(userId: string, headers: GetUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserInfoResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetUserInfo",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/users/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserInfoResponse>(await this.execute(params, req, runtime), new GetUserInfoResponse({}));
  }

  async getUserInfo(userId: string): Promise<GetUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserInfoHeaders({ });
    return await this.getUserInfoWithOptions(userId, headers, runtime);
  }

  async processStartWithOptions(request: ProcessStartRequest, headers: ProcessStartHeaders, runtime: $Util.RuntimeOptions): Promise<ProcessStartResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.autoStart)) {
      body["autoStart"] = request.autoStart;
    }

    if (!Util.isUnset(request.ccs)) {
      body["ccs"] = request.ccs;
    }

    if (!Util.isUnset(request.files)) {
      body["files"] = request.files;
    }

    if (!Util.isUnset(request.initiatorUserId)) {
      body["initiatorUserId"] = request.initiatorUserId;
    }

    if (!Util.isUnset(request.participants)) {
      body["participants"] = request.participants;
    }

    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset(request.sourceInfo)) {
      body["sourceInfo"] = request.sourceInfo;
    }

    if (!Util.isUnset(request.taskName)) {
      body["taskName"] = request.taskName;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ProcessStart",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/processes/startUrls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ProcessStartResponse>(await this.execute(params, req, runtime), new ProcessStartResponse({}));
  }

  async processStart(request: ProcessStartRequest): Promise<ProcessStartResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ProcessStartHeaders({ });
    return await this.processStartWithOptions(request, headers, runtime);
  }

  async resaleOrderWithOptions(request: ResaleOrderRequest, headers: ResaleOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ResaleOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.orderCreateTime)) {
      body["orderCreateTime"] = request.orderCreateTime;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.quantity)) {
      body["quantity"] = request.quantity;
    }

    if (!Util.isUnset(request.serviceStartTime)) {
      body["serviceStartTime"] = request.serviceStartTime;
    }

    if (!Util.isUnset(request.serviceStopTime)) {
      body["serviceStopTime"] = request.serviceStopTime;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ResaleOrder",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/orders/resale`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ResaleOrderResponse>(await this.execute(params, req, runtime), new ResaleOrderResponse({}));
  }

  async resaleOrder(request: ResaleOrderRequest): Promise<ResaleOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ResaleOrderHeaders({ });
    return await this.resaleOrderWithOptions(request, headers, runtime);
  }

  async usersRealnameWithOptions(request: UsersRealnameRequest, headers: UsersRealnameHeaders, runtime: $Util.RuntimeOptions): Promise<UsersRealnameResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.serviceGroup)) {
      realHeaders["serviceGroup"] = Util.toJSONString(headers.serviceGroup);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UsersRealname",
      version: "esign_2.0",
      protocol: "HTTP",
      pathname: `/v2.0/esign/users/realnames`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UsersRealnameResponse>(await this.execute(params, req, runtime), new UsersRealnameResponse({}));
  }

  async usersRealname(request: UsersRealnameRequest): Promise<UsersRealnameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UsersRealnameHeaders({ });
    return await this.usersRealnameWithOptions(request, headers, runtime);
  }

}
