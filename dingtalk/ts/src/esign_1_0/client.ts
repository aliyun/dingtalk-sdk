// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AuthUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlRequest extends $tea.Model {
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

export class AuthUrlResponseBody extends $tea.Model {
  code?: number;
  data?: AuthUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: AuthUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AuthUrlResponseBody;
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
      body: AuthUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthResponseBody extends $tea.Model {
  code?: number;
  data?: CancelCorpAuthResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: CancelCorpAuthResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelCorpAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CancelCorpAuthResponseBody;
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

export class ChannelOrderHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrderRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  itemCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  itemName?: string;
  orderCreateTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  orderId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  payFee?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class ChannelOrderResponseBody extends $tea.Model {
  code?: number;
  data?: ChannelOrderResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: ChannelOrderResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChannelOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ChannelOrderResponseBody;
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
      body: ChannelOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractMarginHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractMarginResponseBody extends $tea.Model {
  code?: number;
  data?: ContractMarginResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: ContractMarginResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ContractMarginResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ContractMarginResponseBody;
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
      body: ContractMarginResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpConsoleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpConsoleResponseBody extends $tea.Model {
  code?: number;
  data?: CorpConsoleResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: CorpConsoleResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpConsoleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CorpConsoleResponseBody;
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
      body: CorpConsoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpInfoResponseBody extends $tea.Model {
  code?: number;
  data?: CorpInfoResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: CorpInfoResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CorpInfoResponseBody;
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
      body: CorpInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperRequest extends $tea.Model {
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

export class CreateDeveloperResponseBody extends $tea.Model {
  code?: number;
  data?: boolean;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: 'boolean',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateDeveloperResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateDeveloperResponseBody;
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
      body: CreateDeveloperResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
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

export class GetCorpRealnameUrlResponseBody extends $tea.Model {
  code?: number;
  data?: GetCorpRealnameUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetCorpRealnameUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCorpRealnameUrlResponseBody;
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
      body: GetCorpRealnameUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCropStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCropStatusResponseBody extends $tea.Model {
  code?: number;
  data?: GetCropStatusResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetCropStatusResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCropStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCropStatusResponseBody;
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
      body: GetCropStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileResponseBody extends $tea.Model {
  code?: number;
  data?: GetFileResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetFileResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFileResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFileResponseBody;
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
      body: GetFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailRequest extends $tea.Model {
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

export class GetFlowDetailResponseBody extends $tea.Model {
  code?: number;
  data?: GetFlowDetailResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetFlowDetailResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFlowDetailResponseBody;
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

export class GetFlowSignDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailRequest extends $tea.Model {
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

export class GetFlowSignDetailResponseBody extends $tea.Model {
  code?: number;
  data?: GetFlowSignDetailResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetFlowSignDetailResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFlowSignDetailResponseBody;
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
      body: GetFlowSignDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlRequest extends $tea.Model {
  ccs?: GetProcessStartUrlRequestCcs[];
  files?: GetProcessStartUrlRequestFiles[];
  initiatorUserId?: string;
  participants?: GetProcessStartUrlRequestParticipants[];
  redirectUrl?: string;
  sourceInfo?: GetProcessStartUrlRequestSourceInfo;
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
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
      ccs: { 'type': 'array', 'itemType': GetProcessStartUrlRequestCcs },
      files: { 'type': 'array', 'itemType': GetProcessStartUrlRequestFiles },
      initiatorUserId: 'string',
      participants: { 'type': 'array', 'itemType': GetProcessStartUrlRequestParticipants },
      redirectUrl: 'string',
      sourceInfo: GetProcessStartUrlRequestSourceInfo,
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlResponseBody extends $tea.Model {
  code?: number;
  data?: GetProcessStartUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetProcessStartUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetProcessStartUrlResponseBody;
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
      body: GetProcessStartUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignNoticeUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignNoticeUrlRequest extends $tea.Model {
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

export class GetSignNoticeUrlResponseBody extends $tea.Model {
  code?: number;
  data?: GetSignNoticeUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetSignNoticeUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSignNoticeUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSignNoticeUrlResponseBody;
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
      body: GetSignNoticeUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  contentMd5?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contentType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  convert2Pdf?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class GetUploadUrlResponseBody extends $tea.Model {
  code?: number;
  data?: GetUploadUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetUploadUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUploadUrlResponseBody;
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
      body: GetUploadUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoResponseBody extends $tea.Model {
  code?: number;
  data?: GetUserInfoResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetUserInfoResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserInfoResponseBody;
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

export class GetUserRealnameUrlHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlRequest extends $tea.Model {
  redirectUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class GetUserRealnameUrlResponseBody extends $tea.Model {
  code?: number;
  data?: GetUserRealnameUrlResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: GetUserRealnameUrlResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserRealnameUrlResponseBody;
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
      body: GetUserRealnameUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsRequest extends $tea.Model {
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

export class ListFlowDocsResponseBody extends $tea.Model {
  code?: number;
  data?: ListFlowDocsResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: { 'type': 'array', 'itemType': ListFlowDocsResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFlowDocsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListFlowDocsResponseBody;
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
      body: ListFlowDocsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalRequest extends $tea.Model {
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

export class ListSealApprovalResponseBody extends $tea.Model {
  code?: number;
  data?: ListSealApprovalResponseBodyData[];
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: { 'type': 'array', 'itemType': ListSealApprovalResponseBodyData },
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListSealApprovalResponseBody;
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
      body: ListSealApprovalResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  orderCreateTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  orderId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  quantity?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  serviceStartTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class OrderResaleResponseBody extends $tea.Model {
  code?: number;
  data?: OrderResaleResponseBodyData;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      data: 'data',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      data: OrderResaleResponseBodyData,
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrderResaleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OrderResaleResponseBody;
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
      body: OrderResaleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AuthUrlResponseBodyData extends $tea.Model {
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

export class CancelCorpAuthResponseBodyData extends $tea.Model {
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

export class ChannelOrderResponseBodyData extends $tea.Model {
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

export class ContractMarginResponseBodyData extends $tea.Model {
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

export class CorpConsoleResponseBodyData extends $tea.Model {
  orgConsoleUrl?: number;
  static names(): { [key: string]: string } {
    return {
      orgConsoleUrl: 'orgConsoleUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgConsoleUrl: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CorpInfoResponseBodyData extends $tea.Model {
  orgRealName?: string;
  realName?: boolean;
  static names(): { [key: string]: string } {
    return {
      orgRealName: 'orgRealName',
      realName: 'realName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orgRealName: 'string',
      realName: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpRealnameUrlResponseBodyData extends $tea.Model {
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

export class GetCropStatusResponseBodyData extends $tea.Model {
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

export class GetFileResponseBodyData extends $tea.Model {
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

export class GetFlowDetailResponseBodyDataLogs extends $tea.Model {
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

export class GetFlowDetailResponseBodyData extends $tea.Model {
  businessSense?: string;
  flowStatus?: number;
  initiatorAuthorizedName?: string;
  initiatorName?: string;
  logs?: GetFlowDetailResponseBodyDataLogs[];
  static names(): { [key: string]: string } {
    return {
      businessSense: 'businessSense',
      flowStatus: 'flowStatus',
      initiatorAuthorizedName: 'initiatorAuthorizedName',
      initiatorName: 'initiatorName',
      logs: 'logs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessSense: 'string',
      flowStatus: 'number',
      initiatorAuthorizedName: 'string',
      initiatorName: 'string',
      logs: { 'type': 'array', 'itemType': GetFlowDetailResponseBodyDataLogs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFlowSignDetailResponseBodyDataSigners extends $tea.Model {
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

export class GetFlowSignDetailResponseBodyData extends $tea.Model {
  businessSense?: string;
  flowStatus?: number;
  signers?: GetFlowSignDetailResponseBodyDataSigners[];
  static names(): { [key: string]: string } {
    return {
      businessSense: 'businessSense',
      flowStatus: 'flowStatus',
      signers: 'signers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      businessSense: 'string',
      flowStatus: 'number',
      signers: { 'type': 'array', 'itemType': GetFlowSignDetailResponseBodyDataSigners },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProcessStartUrlRequestCcs extends $tea.Model {
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

export class GetProcessStartUrlRequestFiles extends $tea.Model {
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

export class GetProcessStartUrlRequestParticipants extends $tea.Model {
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

export class GetProcessStartUrlRequestSourceInfo extends $tea.Model {
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

export class GetProcessStartUrlResponseBodyData extends $tea.Model {
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

export class GetSignNoticeUrlResponseBodyData extends $tea.Model {
  mobileUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mobileUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadUrlResponseBodyData extends $tea.Model {
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

export class GetUserInfoResponseBodyData extends $tea.Model {
  realName?: boolean;
  userRealName?: string;
  static names(): { [key: string]: string } {
    return {
      realName: 'realName',
      userRealName: 'userRealName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      realName: 'boolean',
      userRealName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserRealnameUrlResponseBodyData extends $tea.Model {
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

export class ListFlowDocsResponseBodyData extends $tea.Model {
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

export class ListSealApprovalResponseBodyDataApprovalNodes extends $tea.Model {
  approvalTime?: number;
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
      approvalTime: 'number',
      approverName: 'string',
      startTime: 'number',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSealApprovalResponseBodyData extends $tea.Model {
  approvalName?: string;
  approvalNodes?: ListSealApprovalResponseBodyDataApprovalNodes[];
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
      approvalNodes: { 'type': 'array', 'itemType': ListSealApprovalResponseBodyDataApprovalNodes },
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

export class OrderResaleResponseBodyData extends $tea.Model {
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
   * 获取授权的页面地址
   * 
   * @param request - AuthUrlRequest
   * @param headers - AuthUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AuthUrlResponse
   */
  async authUrlWithOptions(request: AuthUrlRequest, headers: AuthUrlHeaders, runtime: $Util.RuntimeOptions): Promise<AuthUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
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
      action: "AuthUrl",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/auths/url`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AuthUrlResponse>(await this.execute(params, req, runtime), new AuthUrlResponse({}));
  }

  /**
   * 获取授权的页面地址
   * 
   * @param request - AuthUrlRequest
   * @returns AuthUrlResponse
   */
  async authUrl(request: AuthUrlRequest): Promise<AuthUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AuthUrlHeaders({ });
    return await this.authUrlWithOptions(request, headers, runtime);
  }

  /**
   * 取消企业的授权
   * 
   * @param headers - CancelCorpAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CancelCorpAuthResponse
   */
  async cancelCorpAuthWithOptions(headers: CancelCorpAuthHeaders, runtime: $Util.RuntimeOptions): Promise<CancelCorpAuthResponse> {
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
      action: "CancelCorpAuth",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/corps/auth/cancel`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CancelCorpAuthResponse>(await this.execute(params, req, runtime), new CancelCorpAuthResponse({}));
  }

  /**
   * 取消企业的授权
   * @returns CancelCorpAuthResponse
   */
  async cancelCorpAuth(): Promise<CancelCorpAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelCorpAuthHeaders({ });
    return await this.cancelCorpAuthWithOptions(headers, runtime);
  }

  /**
   * 套餐转售1（分润模式）
   * 
   * @param request - ChannelOrderRequest
   * @param headers - ChannelOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ChannelOrderResponse
   */
  async channelOrderWithOptions(request: ChannelOrderRequest, headers: ChannelOrderHeaders, runtime: $Util.RuntimeOptions): Promise<ChannelOrderResponse> {
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

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ChannelOrder",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/orders/channel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ChannelOrderResponse>(await this.execute(params, req, runtime), new ChannelOrderResponse({}));
  }

  /**
   * 套餐转售1（分润模式）
   * 
   * @param request - ChannelOrderRequest
   * @returns ChannelOrderResponse
   */
  async channelOrder(request: ChannelOrderRequest): Promise<ChannelOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChannelOrderHeaders({ });
    return await this.channelOrderWithOptions(request, headers, runtime);
  }

  /**
   * 查询套餐余量
   * 
   * @param headers - ContractMarginHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ContractMarginResponse
   */
  async contractMarginWithOptions(headers: ContractMarginHeaders, runtime: $Util.RuntimeOptions): Promise<ContractMarginResponse> {
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
      action: "ContractMargin",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/contracts/margin`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ContractMarginResponse>(await this.execute(params, req, runtime), new ContractMarginResponse({}));
  }

  /**
   * 查询套餐余量
   * @returns ContractMarginResponse
   */
  async contractMargin(): Promise<ContractMarginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ContractMarginHeaders({ });
    return await this.contractMarginWithOptions(headers, runtime);
  }

  /**
   * 查询个人信息
   * 
   * @param headers - CorpConsoleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CorpConsoleResponse
   */
  async corpConsoleWithOptions(headers: CorpConsoleHeaders, runtime: $Util.RuntimeOptions): Promise<CorpConsoleResponse> {
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
      action: "CorpConsole",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/corps/console`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CorpConsoleResponse>(await this.execute(params, req, runtime), new CorpConsoleResponse({}));
  }

  /**
   * 查询个人信息
   * @returns CorpConsoleResponse
   */
  async corpConsole(): Promise<CorpConsoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CorpConsoleHeaders({ });
    return await this.corpConsoleWithOptions(headers, runtime);
  }

  /**
   * 查询企业信息
   * 
   * @param headers - CorpInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CorpInfoResponse
   */
  async corpInfoWithOptions(headers: CorpInfoHeaders, runtime: $Util.RuntimeOptions): Promise<CorpInfoResponse> {
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
      action: "CorpInfo",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/corps/info`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CorpInfoResponse>(await this.execute(params, req, runtime), new CorpInfoResponse({}));
  }

  /**
   * 查询企业信息
   * @returns CorpInfoResponse
   */
  async corpInfo(): Promise<CorpInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CorpInfoHeaders({ });
    return await this.corpInfoWithOptions(headers, runtime);
  }

  /**
   * 钉钉ISV服务商的数据初始化
   * 
   * @param request - CreateDeveloperRequest
   * @param headers - CreateDeveloperHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateDeveloperResponse
   */
  async createDeveloperWithOptions(request: CreateDeveloperRequest, headers: CreateDeveloperHeaders, runtime: $Util.RuntimeOptions): Promise<CreateDeveloperResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.redirectUrl)) {
      body["redirectUrl"] = request.redirectUrl;
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
      action: "CreateDeveloper",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/developers/create`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateDeveloperResponse>(await this.execute(params, req, runtime), new CreateDeveloperResponse({}));
  }

  /**
   * 钉钉ISV服务商的数据初始化
   * 
   * @param request - CreateDeveloperRequest
   * @returns CreateDeveloperResponse
   */
  async createDeveloper(request: CreateDeveloperRequest): Promise<CreateDeveloperResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateDeveloperHeaders({ });
    return await this.createDeveloperWithOptions(request, headers, runtime);
  }

  /**
   * 获取跳转到个人实名的地址
   * 
   * @param request - GetCorpRealnameUrlRequest
   * @param headers - GetCorpRealnameUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCorpRealnameUrlResponse
   */
  async getCorpRealnameUrlWithOptions(request: GetCorpRealnameUrlRequest, headers: GetCorpRealnameUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetCorpRealnameUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      action: "GetCorpRealnameUrl",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/corps/realname`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetCorpRealnameUrlResponse>(await this.execute(params, req, runtime), new GetCorpRealnameUrlResponse({}));
  }

  /**
   * 获取跳转到个人实名的地址
   * 
   * @param request - GetCorpRealnameUrlRequest
   * @returns GetCorpRealnameUrlResponse
   */
  async getCorpRealnameUrl(request: GetCorpRealnameUrlRequest): Promise<GetCorpRealnameUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCorpRealnameUrlHeaders({ });
    return await this.getCorpRealnameUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业e签宝微应用状态
   * 
   * @param headers - GetCropStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCropStatusResponse
   */
  async getCropStatusWithOptions(headers: GetCropStatusHeaders, runtime: $Util.RuntimeOptions): Promise<GetCropStatusResponse> {
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
      action: "GetCropStatus",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/corps/statuses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetCropStatusResponse>(await this.execute(params, req, runtime), new GetCropStatusResponse({}));
  }

  /**
   * 获取企业e签宝微应用状态
   * @returns GetCropStatusResponse
   */
  async getCropStatus(): Promise<GetCropStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCropStatusHeaders({ });
    return await this.getCropStatusWithOptions(headers, runtime);
  }

  /**
   * 查询文件详情/下载文件
   * 
   * @param headers - GetFileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFileResponse
   */
  async getFileWithOptions(fileId: string, headers: GetFileHeaders, runtime: $Util.RuntimeOptions): Promise<GetFileResponse> {
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
      action: "GetFile",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/files/${fileId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFileResponse>(await this.execute(params, req, runtime), new GetFileResponse({}));
  }

  /**
   * 查询文件详情/下载文件
   * @returns GetFileResponse
   */
  async getFile(fileId: string): Promise<GetFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFileHeaders({ });
    return await this.getFileWithOptions(fileId, headers, runtime);
  }

  /**
   * 获取对应流程任务详情
   * 
   * @param request - GetFlowDetailRequest
   * @param headers - GetFlowDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFlowDetailResponse
   */
  async getFlowDetailWithOptions(request: GetFlowDetailRequest, headers: GetFlowDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlowDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
      action: "GetFlowDetail",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/flows/detail`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFlowDetailResponse>(await this.execute(params, req, runtime), new GetFlowDetailResponse({}));
  }

  /**
   * 获取对应流程任务详情
   * 
   * @param request - GetFlowDetailRequest
   * @returns GetFlowDetailResponse
   */
  async getFlowDetail(request: GetFlowDetailRequest): Promise<GetFlowDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowDetailHeaders({ });
    return await this.getFlowDetailWithOptions(request, headers, runtime);
  }

  /**
   * 获取对应流程任务详情
   * 
   * @param request - GetFlowSignDetailRequest
   * @param headers - GetFlowSignDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFlowSignDetailResponse
   */
  async getFlowSignDetailWithOptions(request: GetFlowSignDetailRequest, headers: GetFlowSignDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetFlowSignDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
      action: "GetFlowSignDetail",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/flows/sign/detail`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetFlowSignDetailResponse>(await this.execute(params, req, runtime), new GetFlowSignDetailResponse({}));
  }

  /**
   * 获取对应流程任务详情
   * 
   * @param request - GetFlowSignDetailRequest
   * @returns GetFlowSignDetailResponse
   */
  async getFlowSignDetail(request: GetFlowSignDetailRequest): Promise<GetFlowSignDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFlowSignDetailHeaders({ });
    return await this.getFlowSignDetailWithOptions(request, headers, runtime);
  }

  /**
   * 发起签署的地址
   * 
   * @param request - GetProcessStartUrlRequest
   * @param headers - GetProcessStartUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetProcessStartUrlResponse
   */
  async getProcessStartUrlWithOptions(request: GetProcessStartUrlRequest, headers: GetProcessStartUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetProcessStartUrlResponse> {
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
      action: "GetProcessStartUrl",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/process/start`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetProcessStartUrlResponse>(await this.execute(params, req, runtime), new GetProcessStartUrlResponse({}));
  }

  /**
   * 发起签署的地址
   * 
   * @param request - GetProcessStartUrlRequest
   * @returns GetProcessStartUrlResponse
   */
  async getProcessStartUrl(request: GetProcessStartUrlRequest): Promise<GetProcessStartUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetProcessStartUrlHeaders({ });
    return await this.getProcessStartUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取签署人签署地址
   * 
   * @param request - GetSignNoticeUrlRequest
   * @param headers - GetSignNoticeUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSignNoticeUrlResponse
   */
  async getSignNoticeUrlWithOptions(request: GetSignNoticeUrlRequest, headers: GetSignNoticeUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetSignNoticeUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      action: "GetSignNoticeUrl",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/signs/notice/url`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetSignNoticeUrlResponse>(await this.execute(params, req, runtime), new GetSignNoticeUrlResponse({}));
  }

  /**
   * 获取签署人签署地址
   * 
   * @param request - GetSignNoticeUrlRequest
   * @returns GetSignNoticeUrlResponse
   */
  async getSignNoticeUrl(request: GetSignNoticeUrlRequest): Promise<GetSignNoticeUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSignNoticeUrlHeaders({ });
    return await this.getSignNoticeUrlWithOptions(request, headers, runtime);
  }

  /**
   * 通过上传方式创建文件
   * 
   * @param request - GetUploadUrlRequest
   * @param headers - GetUploadUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUploadUrlResponse
   */
  async getUploadUrlWithOptions(request: GetUploadUrlRequest, headers: GetUploadUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadUrlResponse> {
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

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetUploadUrl",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/files/getUploadUrl`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUploadUrlResponse>(await this.execute(params, req, runtime), new GetUploadUrlResponse({}));
  }

  /**
   * 通过上传方式创建文件
   * 
   * @param request - GetUploadUrlRequest
   * @returns GetUploadUrlResponse
   */
  async getUploadUrl(request: GetUploadUrlRequest): Promise<GetUploadUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadUrlHeaders({ });
    return await this.getUploadUrlWithOptions(request, headers, runtime);
  }

  /**
   * 查询个人信息
   * 
   * @param headers - GetUserInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserInfoResponse
   */
  async getUserInfoWithOptions(userId: string, headers: GetUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserInfoResponse> {
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
      action: "GetUserInfo",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/users/${userId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserInfoResponse>(await this.execute(params, req, runtime), new GetUserInfoResponse({}));
  }

  /**
   * 查询个人信息
   * @returns GetUserInfoResponse
   */
  async getUserInfo(userId: string): Promise<GetUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserInfoHeaders({ });
    return await this.getUserInfoWithOptions(userId, headers, runtime);
  }

  /**
   * 获取跳转到个人实名的地址
   * 
   * @param request - GetUserRealnameUrlRequest
   * @param headers - GetUserRealnameUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserRealnameUrlResponse
   */
  async getUserRealnameUrlWithOptions(request: GetUserRealnameUrlRequest, headers: GetUserRealnameUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserRealnameUrlResponse> {
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

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetUserRealnameUrl",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/users/realname`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserRealnameUrlResponse>(await this.execute(params, req, runtime), new GetUserRealnameUrlResponse({}));
  }

  /**
   * 获取跳转到个人实名的地址
   * 
   * @param request - GetUserRealnameUrlRequest
   * @returns GetUserRealnameUrlResponse
   */
  async getUserRealnameUrl(request: GetUserRealnameUrlRequest): Promise<GetUserRealnameUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserRealnameUrlHeaders({ });
    return await this.getUserRealnameUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取流程任务合同列表
   * 
   * @param request - ListFlowDocsRequest
   * @param headers - ListFlowDocsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListFlowDocsResponse
   */
  async listFlowDocsWithOptions(request: ListFlowDocsRequest, headers: ListFlowDocsHeaders, runtime: $Util.RuntimeOptions): Promise<ListFlowDocsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
      action: "ListFlowDocs",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/flows/docs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListFlowDocsResponse>(await this.execute(params, req, runtime), new ListFlowDocsResponse({}));
  }

  /**
   * 获取流程任务合同列表
   * 
   * @param request - ListFlowDocsRequest
   * @returns ListFlowDocsResponse
   */
  async listFlowDocs(request: ListFlowDocsRequest): Promise<ListFlowDocsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFlowDocsHeaders({ });
    return await this.listFlowDocsWithOptions(request, headers, runtime);
  }

  /**
   * 获取流程任务用印审批列表
   * 
   * @param request - ListSealApprovalRequest
   * @param headers - ListSealApprovalHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListSealApprovalResponse
   */
  async listSealApprovalWithOptions(request: ListSealApprovalRequest, headers: ListSealApprovalHeaders, runtime: $Util.RuntimeOptions): Promise<ListSealApprovalResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
      action: "ListSealApproval",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/seals/approval/list`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListSealApprovalResponse>(await this.execute(params, req, runtime), new ListSealApprovalResponse({}));
  }

  /**
   * 获取流程任务用印审批列表
   * 
   * @param request - ListSealApprovalRequest
   * @returns ListSealApprovalResponse
   */
  async listSealApproval(request: ListSealApprovalRequest): Promise<ListSealApprovalResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSealApprovalHeaders({ });
    return await this.listSealApprovalWithOptions(request, headers, runtime);
  }

  /**
   * 套餐转售2（底价结算模式）
   * 
   * @param request - OrderResaleRequest
   * @param headers - OrderResaleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OrderResaleResponse
   */
  async orderResaleWithOptions(request: OrderResaleRequest, headers: OrderResaleHeaders, runtime: $Util.RuntimeOptions): Promise<OrderResaleResponse> {
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

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "OrderResale",
      version: "esign_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/esign/orders/resale`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<OrderResaleResponse>(await this.execute(params, req, runtime), new OrderResaleResponse({}));
  }

  /**
   * 套餐转售2（底价结算模式）
   * 
   * @param request - OrderResaleRequest
   * @returns OrderResaleResponse
   */
  async orderResale(request: OrderResaleRequest): Promise<OrderResaleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrderResaleHeaders({ });
    return await this.orderResaleWithOptions(request, headers, runtime);
  }

}
