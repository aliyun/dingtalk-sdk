// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class DetailUserIdPrivateDataMapValue extends $tea.Model {
  cardParamMap?: { [key: string]: any };
  cardMediaIdParamMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
      cardMediaIdParamMap: 'cardMediaIdParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyFollowerAuthInfoHeaders extends $tea.Model {
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

export class ApplyFollowerAuthInfoRequest extends $tea.Model {
  appAuthKey?: string;
  /**
   * @example
   * Contact.User.mobile
   */
  fieldScope?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sid22b31b4bf59ef2c783f7
   */
  sessionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * idzb26bxl64vqx2keyi
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appAuthKey: 'appAuthKey',
      fieldScope: 'fieldScope',
      sessionId: 'sessionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appAuthKey: 'string',
      fieldScope: 'string',
      sessionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyFollowerAuthInfoResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: ApplyFollowerAuthInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ApplyFollowerAuthInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyFollowerAuthInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ApplyFollowerAuthInfoResponseBody;
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
      body: ApplyFollowerAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CallbackRegiesterHeaders extends $tea.Model {
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

export class CallbackRegiesterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3b89df4dfaaccd5b8e1f9a2
   */
  apiSecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abc-123
   */
  callbackKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://www.your.com/callback
   */
  callbackUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * shortcut
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      apiSecret: 'apiSecret',
      callbackKey: 'callbackKey',
      callbackUrl: 'callbackUrl',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiSecret: 'string',
      callbackKey: 'string',
      callbackUrl: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CallbackRegiesterResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: CallbackRegiesterResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CallbackRegiesterResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CallbackRegiesterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CallbackRegiesterResponseBody;
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
      body: CallbackRegiesterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseTopBoxInteractiveOTOMessageHeaders extends $tea.Model {
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

export class CloseTopBoxInteractiveOTOMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: CloseTopBoxInteractiveOTOMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: CloseTopBoxInteractiveOTOMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseTopBoxInteractiveOTOMessageResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseTopBoxInteractiveOTOMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CloseTopBoxInteractiveOTOMessageResponseBody;
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
      body: CloseTopBoxInteractiveOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerAuthInfoHeaders extends $tea.Model {
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

export class GetFollowerAuthInfoRequest extends $tea.Model {
  /**
   * @example
   * ding1234
   */
  accountId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerAuthInfoResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: GetFollowerAuthInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetFollowerAuthInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerAuthInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFollowerAuthInfoResponseBody;
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
      body: GetFollowerAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerInfoHeaders extends $tea.Model {
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

export class GetFollowerInfoRequest extends $tea.Model {
  /**
   * @example
   * ding1234
   */
  accountId?: string;
  /**
   * @example
   * UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  unionId?: string;
  /**
   * @example
   * Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerInfoResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: GetFollowerInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: GetFollowerInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFollowerInfoResponseBody;
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
      body: GetFollowerInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPictureDownloadUrlHeaders extends $tea.Model {
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

export class GetPictureDownloadUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  downloadCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sid001234
   */
  sessionId?: string;
  static names(): { [key: string]: string } {
    return {
      downloadCode: 'downloadCode',
      sessionId: 'sessionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadCode: 'string',
      sessionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPictureDownloadUrlResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: GetPictureDownloadUrlResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: GetPictureDownloadUrlResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPictureDownloadUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPictureDownloadUrlResponseBody;
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
      body: GetPictureDownloadUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserFollowStatusHeaders extends $tea.Model {
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

export class GetUserFollowStatusRequest extends $tea.Model {
  /**
   * @example
   * ding1234
   */
  accountId?: string;
  /**
   * @example
   * UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  unionId?: string;
  /**
   * @example
   * Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserFollowStatusResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: GetUserFollowStatusResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetUserFollowStatusResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserFollowStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetUserFollowStatusResponseBody;
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
      body: GetUserFollowStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAccountHeaders extends $tea.Model {
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

export class ListAccountResponseBody extends $tea.Model {
  result?: ListAccountResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListAccountResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAccountResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAccountResponseBody;
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
      body: ListAccountResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAccountInfoHeaders extends $tea.Model {
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

export class ListAccountInfoResponseBody extends $tea.Model {
  result?: ListAccountInfoResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': ListAccountInfoResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAccountInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAccountInfoResponseBody;
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
      body: ListAccountInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFollowerHeaders extends $tea.Model {
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

export class ListFollowerRequest extends $tea.Model {
  /**
   * @example
   * ding1234
   */
  accountId?: string;
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFollowerResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: ListFollowerResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: ListFollowerResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFollowerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListFollowerResponseBody;
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
      body: ListFollowerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFollowStatusHeaders extends $tea.Model {
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

export class QueryUserFollowStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding1234
   */
  accountId?: string;
  /**
   * @example
   * UgIzXXo+Rp3Rqcts7BE08y49Jr6iu6xW4iQ
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFollowStatusResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: QueryUserFollowStatusResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryUserFollowStatusResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFollowStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUserFollowStatusResponseBody;
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
      body: QueryUserFollowStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageHeaders extends $tea.Model {
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

export class SendAgentOTOMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: SendAgentOTOMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: SendAgentOTOMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: SendAgentOTOMessageResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: SendAgentOTOMessageResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendAgentOTOMessageResponseBody;
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
      body: SendAgentOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveOTOMessageHeaders extends $tea.Model {
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

export class SendInteractiveOTOMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: SendInteractiveOTOMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: SendInteractiveOTOMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveOTOMessageResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: SendInteractiveOTOMessageResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: SendInteractiveOTOMessageResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveOTOMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendInteractiveOTOMessageResponseBody;
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
      body: SendInteractiveOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTopBoxInteractiveOTOMessageHeaders extends $tea.Model {
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

export class SendTopBoxInteractiveOTOMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: SendTopBoxInteractiveOTOMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: SendTopBoxInteractiveOTOMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTopBoxInteractiveOTOMessageResponseBody extends $tea.Model {
  requestId?: string;
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTopBoxInteractiveOTOMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendTopBoxInteractiveOTOMessageResponseBody;
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
      body: SendTopBoxInteractiveOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveOTOMessageHeaders extends $tea.Model {
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

export class UpdateInteractiveOTOMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  detail?: UpdateInteractiveOTOMessageRequestDetail;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: UpdateInteractiveOTOMessageRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveOTOMessageResponseBody extends $tea.Model {
  requestId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  result?: UpdateInteractiveOTOMessageResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: UpdateInteractiveOTOMessageResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveOTOMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInteractiveOTOMessageResponseBody;
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
      body: UpdateInteractiveOTOMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateShortcutsHeaders extends $tea.Model {
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

export class UpdateShortcutsRequest extends $tea.Model {
  details?: UpdateShortcutsRequestDetails[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sid001234
   */
  sessionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * idzb26bxl64vqx2keyi
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      details: 'details',
      sessionId: 'sessionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      details: { 'type': 'array', 'itemType': UpdateShortcutsRequestDetails },
      sessionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateShortcutsResponseBody extends $tea.Model {
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

export class UpdateShortcutsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateShortcutsResponseBody;
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
      body: UpdateShortcutsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ApplyFollowerAuthInfoResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openApplyId?: string;
  static names(): { [key: string]: string } {
    return {
      openApplyId: 'openApplyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openApplyId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CallbackRegiesterResponseBodyResult extends $tea.Model {
  apiSecret?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  callbackUrl?: string;
  static names(): { [key: string]: string } {
    return {
      apiSecret: 'apiSecret',
      callbackUrl: 'callbackUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiSecret: 'string',
      callbackUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseTopBoxInteractiveOTOMessageRequestDetail extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * service-card-20220824-001
   */
  cardBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3erkfi-42b0-4c83-bc56-ffhssde43
   */
  cardTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizId: 'cardBizId',
      cardTemplateId: 'cardTemplateId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizId: 'string',
      cardTemplateId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp extends $tea.Model {
  authorized?: boolean;
  corpName?: string;
  static names(): { [key: string]: string } {
    return {
      authorized: 'authorized',
      corpName: 'corpName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorized: 'boolean',
      corpName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerAuthInfoResponseBodyResultAuthInfoMobile extends $tea.Model {
  authorized?: boolean;
  mobile?: string;
  stateCode?: string;
  static names(): { [key: string]: string } {
    return {
      authorized: 'authorized',
      mobile: 'mobile',
      stateCode: 'stateCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authorized: 'boolean',
      mobile: 'string',
      stateCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerAuthInfoResponseBodyResultAuthInfo extends $tea.Model {
  mainCorp?: GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp;
  mobile?: GetFollowerAuthInfoResponseBodyResultAuthInfoMobile;
  static names(): { [key: string]: string } {
    return {
      mainCorp: 'mainCorp',
      mobile: 'mobile',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mainCorp: GetFollowerAuthInfoResponseBodyResultAuthInfoMainCorp,
      mobile: GetFollowerAuthInfoResponseBodyResultAuthInfoMobile,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerAuthInfoResponseBodyResult extends $tea.Model {
  authInfo?: GetFollowerAuthInfoResponseBodyResultAuthInfo;
  static names(): { [key: string]: string } {
    return {
      authInfo: 'authInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authInfo: GetFollowerAuthInfoResponseBodyResultAuthInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerInfoResponseBodyResultUser extends $tea.Model {
  /**
   * @example
   * 小钉
   */
  name?: string;
  /**
   * @example
   * 1661918406748
   */
  timestamp?: string;
  /**
   * @example
   * userId
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      timestamp: 'timestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      timestamp: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFollowerInfoResponseBodyResult extends $tea.Model {
  user?: GetFollowerInfoResponseBodyResultUser;
  static names(): { [key: string]: string } {
    return {
      user: 'user',
    };
  }

  static types(): { [key: string]: any } {
    return {
      user: GetFollowerInfoResponseBodyResultUser,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPictureDownloadUrlResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FOLLOWED
   */
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserFollowStatusResponseBodyResult extends $tea.Model {
  status?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAccountResponseBodyResult extends $tea.Model {
  accountId?: string;
  accountName?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      accountName: 'accountName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      accountName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAccountInfoResponseBodyResult extends $tea.Model {
  accountId?: string;
  accountName?: string;
  static names(): { [key: string]: string } {
    return {
      accountId: 'accountId',
      accountName: 'accountName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accountId: 'string',
      accountName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFollowerResponseBodyResultUserList extends $tea.Model {
  name?: string;
  timestamp?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      timestamp: 'timestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      timestamp: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListFollowerResponseBodyResult extends $tea.Model {
  nextToken?: string;
  userList?: ListFollowerResponseBodyResultUserList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      userList: { 'type': 'array', 'itemType': ListFollowerResponseBodyResultUserList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserFollowStatusResponseBodyResult extends $tea.Model {
  status?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList extends $tea.Model {
  /**
   * @example
   * https://www.dingtalk.com/
   */
  actionUrl?: string;
  /**
   * @example
   * 查看详情
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionUrl: 'actionUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBodyActionCard extends $tea.Model {
  buttonList?: SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList[];
  /**
   * @example
   * 1
   */
  buttonOrientation?: string;
  /**
   * @example
   * **提示信息**
   */
  markdown?: string;
  /**
   * @example
   * 查看详情
   */
  singleTitle?: string;
  /**
   * @example
   * https://www.yourdomain.com
   */
  singleUrl?: string;
  /**
   * @example
   * 欢迎使用
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      buttonList: 'buttonList',
      buttonOrientation: 'buttonOrientation',
      markdown: 'markdown',
      singleTitle: 'singleTitle',
      singleUrl: 'singleUrl',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buttonList: { 'type': 'array', 'itemType': SendAgentOTOMessageRequestDetailMessageBodyActionCardButtonList },
      buttonOrientation: 'string',
      markdown: 'string',
      singleTitle: 'string',
      singleUrl: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBodyImage extends $tea.Model {
  mediaId?: string;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage extends $tea.Model {
  callbackUrl?: string;
  cardBizId?: string;
  cardData?: string;
  cardTemplateId?: string;
  static names(): { [key: string]: string } {
    return {
      callbackUrl: 'callbackUrl',
      cardBizId: 'cardBizId',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackUrl: 'string',
      cardBizId: 'string',
      cardData: 'string',
      cardTemplateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBodyLink extends $tea.Model {
  /**
   * @example
   * https://www.yourdomain.com
   */
  messageUrl?: string;
  /**
   * @example
   * @1234-456
   */
  picUrl?: string;
  /**
   * @example
   * 欢迎使用
   */
  text?: string;
  /**
   * @example
   * 点击查看
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      messageUrl: 'messageUrl',
      picUrl: 'picUrl',
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageUrl: 'string',
      picUrl: 'string',
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBodyMarkdown extends $tea.Model {
  /**
   * @example
   * 欢迎使用。
   */
  text?: string;
  /**
   * @example
   * 欢迎使用。
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      text: 'text',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      text: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBodyText extends $tea.Model {
  /**
   * @example
   * 你好，欢迎使用服务窗。
   */
  content?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetailMessageBody extends $tea.Model {
  actionCard?: SendAgentOTOMessageRequestDetailMessageBodyActionCard;
  image?: SendAgentOTOMessageRequestDetailMessageBodyImage;
  interactiveMessage?: SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage;
  link?: SendAgentOTOMessageRequestDetailMessageBodyLink;
  markdown?: SendAgentOTOMessageRequestDetailMessageBodyMarkdown;
  text?: SendAgentOTOMessageRequestDetailMessageBodyText;
  static names(): { [key: string]: string } {
    return {
      actionCard: 'actionCard',
      image: 'image',
      interactiveMessage: 'interactiveMessage',
      link: 'link',
      markdown: 'markdown',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionCard: SendAgentOTOMessageRequestDetailMessageBodyActionCard,
      image: SendAgentOTOMessageRequestDetailMessageBodyImage,
      interactiveMessage: SendAgentOTOMessageRequestDetailMessageBodyInteractiveMessage,
      link: SendAgentOTOMessageRequestDetailMessageBodyLink,
      markdown: SendAgentOTOMessageRequestDetailMessageBodyMarkdown,
      text: SendAgentOTOMessageRequestDetailMessageBodyText,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageRequestDetail extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageBody?: SendAgentOTOMessageRequestDetailMessageBody;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  msgType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sid002b6dbb4f963e93e0
   */
  sessionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user0001
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234-5678-000
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      messageBody: 'messageBody',
      msgType: 'msgType',
      sessionId: 'sessionId',
      userId: 'userId',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageBody: SendAgentOTOMessageRequestDetailMessageBody,
      msgType: 'string',
      sessionId: 'string',
      userId: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendAgentOTOMessageResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveOTOMessageRequestDetail extends $tea.Model {
  /**
   * @example
   * https://www.youurl.com/callback/card
   */
  callbackUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * service-card-20220824-001
   */
  cardBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  cardData?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3erkfi-42b0-4c83-bc56-ffhssde43
   */
  cardTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user0001
   */
  userId?: string;
  /**
   * @example
   * {"user001":""}
   */
  userIdPrivateDataMap?: string;
  static names(): { [key: string]: string } {
    return {
      callbackUrl: 'callbackUrl',
      cardBizId: 'cardBizId',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      userId: 'userId',
      userIdPrivateDataMap: 'userIdPrivateDataMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackUrl: 'string',
      cardBizId: 'string',
      cardData: 'string',
      cardTemplateId: 'string',
      userId: 'string',
      userIdPrivateDataMap: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveOTOMessageResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTopBoxInteractiveOTOMessageRequestDetailCardData extends $tea.Model {
  cardMediaIdParamMap?: { [key: string]: any };
  cardParamMap?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      cardMediaIdParamMap: 'cardMediaIdParamMap',
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTopBoxInteractiveOTOMessageRequestDetail extends $tea.Model {
  /**
   * @example
   * https://www.youurl.com/callback/card
   */
  callbackUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * service-card-20220824-001
   */
  cardBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  cardData?: SendTopBoxInteractiveOTOMessageRequestDetailCardData;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3erkfi-42b0-4c83-bc56-ffhssde43
   */
  cardTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  expiredTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * user001
   */
  userId?: string;
  userIdPrivateDataMap?: { [key: string]: DetailUserIdPrivateDataMapValue };
  static names(): { [key: string]: string } {
    return {
      callbackUrl: 'callbackUrl',
      cardBizId: 'cardBizId',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      expiredTime: 'expiredTime',
      userId: 'userId',
      userIdPrivateDataMap: 'userIdPrivateDataMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackUrl: 'string',
      cardBizId: 'string',
      cardData: SendTopBoxInteractiveOTOMessageRequestDetailCardData,
      cardTemplateId: 'string',
      expiredTime: 'number',
      userId: 'string',
      userIdPrivateDataMap: { 'type': 'map', 'keyType': 'string', 'valueType': DetailUserIdPrivateDataMapValue },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveOTOMessageRequestDetailUpdateOptions extends $tea.Model {
  updateCardDataByKey?: boolean;
  updatePrivateDataByKey?: boolean;
  static names(): { [key: string]: string } {
    return {
      updateCardDataByKey: 'updateCardDataByKey',
      updatePrivateDataByKey: 'updatePrivateDataByKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      updateCardDataByKey: 'boolean',
      updatePrivateDataByKey: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveOTOMessageRequestDetail extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * service-card-202208240001
   */
  cardBizId?: string;
  /**
   * @example
   * {"like":1}
   */
  cardData?: string;
  updateOptions?: UpdateInteractiveOTOMessageRequestDetailUpdateOptions;
  /**
   * @example
   * {"userI":""}
   */
  userIdPrivateDataMap?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizId: 'cardBizId',
      cardData: 'cardData',
      updateOptions: 'updateOptions',
      userIdPrivateDataMap: 'userIdPrivateDataMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizId: 'string',
      cardData: 'string',
      updateOptions: UpdateInteractiveOTOMessageRequestDetailUpdateOptions,
      userIdPrivateDataMap: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveOTOMessageResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openPushId?: string;
  static names(): { [key: string]: string } {
    return {
      openPushId: 'openPushId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openPushId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateShortcutsRequestDetails extends $tea.Model {
  /**
   * @example
   * https://dingtalk.com
   */
  actionUrl?: string;
  /**
   * @example
   * 033bd94b1168d7e4f0d644c3c95e35bf
   */
  callbackKey?: string;
  /**
   * @example
   * e73e
   */
  iconFont?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @lADPDg7mWPzw0i_NArzNArw
   */
  iconMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * test123456
   */
  shortcutId?: string;
  /**
   * @example
   * @lADPDg7mWPzw0i_NArzNArw
   */
  slideIconMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionUrl: 'actionUrl',
      callbackKey: 'callbackKey',
      iconFont: 'iconFont',
      iconMediaId: 'iconMediaId',
      shortcutId: 'shortcutId',
      slideIconMediaId: 'slideIconMediaId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionUrl: 'string',
      callbackKey: 'string',
      iconFont: 'string',
      iconMediaId: 'string',
      shortcutId: 'string',
      slideIconMediaId: 'string',
      title: 'string',
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
   * 发送用户授权信息申请
   * 
   * @param request - ApplyFollowerAuthInfoRequest
   * @param headers - ApplyFollowerAuthInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ApplyFollowerAuthInfoResponse
   */
  async applyFollowerAuthInfoWithOptions(request: ApplyFollowerAuthInfoRequest, headers: ApplyFollowerAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<ApplyFollowerAuthInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appAuthKey)) {
      body["appAuthKey"] = request.appAuthKey;
    }

    if (!Util.isUnset(request.fieldScope)) {
      body["fieldScope"] = request.fieldScope;
    }

    if (!Util.isUnset(request.sessionId)) {
      body["sessionId"] = request.sessionId;
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
      action: "ApplyFollowerAuthInfo",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/followers/authInfos/apply`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ApplyFollowerAuthInfoResponse>(await this.execute(params, req, runtime), new ApplyFollowerAuthInfoResponse({}));
  }

  /**
   * 发送用户授权信息申请
   * 
   * @param request - ApplyFollowerAuthInfoRequest
   * @returns ApplyFollowerAuthInfoResponse
   */
  async applyFollowerAuthInfo(request: ApplyFollowerAuthInfoRequest): Promise<ApplyFollowerAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ApplyFollowerAuthInfoHeaders({ });
    return await this.applyFollowerAuthInfoWithOptions(request, headers, runtime);
  }

  /**
   * 注册服务窗消息回调服务
   * 
   * @param request - CallbackRegiesterRequest
   * @param headers - CallbackRegiesterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CallbackRegiesterResponse
   */
  async callbackRegiesterWithOptions(request: CallbackRegiesterRequest, headers: CallbackRegiesterHeaders, runtime: $Util.RuntimeOptions): Promise<CallbackRegiesterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.apiSecret)) {
      body["apiSecret"] = request.apiSecret;
    }

    if (!Util.isUnset(request.callbackKey)) {
      body["callbackKey"] = request.callbackKey;
    }

    if (!Util.isUnset(request.callbackUrl)) {
      body["callbackUrl"] = request.callbackUrl;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
      action: "CallbackRegiester",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/callbacks/regiester`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CallbackRegiesterResponse>(await this.execute(params, req, runtime), new CallbackRegiesterResponse({}));
  }

  /**
   * 注册服务窗消息回调服务
   * 
   * @param request - CallbackRegiesterRequest
   * @returns CallbackRegiesterResponse
   */
  async callbackRegiester(request: CallbackRegiesterRequest): Promise<CallbackRegiesterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CallbackRegiesterHeaders({ });
    return await this.callbackRegiesterWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗吊顶卡片关闭接口
   * 
   * @param request - CloseTopBoxInteractiveOTOMessageRequest
   * @param headers - CloseTopBoxInteractiveOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CloseTopBoxInteractiveOTOMessageResponse
   */
  async closeTopBoxInteractiveOTOMessageWithOptions(request: CloseTopBoxInteractiveOTOMessageRequest, headers: CloseTopBoxInteractiveOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<CloseTopBoxInteractiveOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "CloseTopBoxInteractiveOTOMessage",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/oToMessages/topBoxes/close`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CloseTopBoxInteractiveOTOMessageResponse>(await this.execute(params, req, runtime), new CloseTopBoxInteractiveOTOMessageResponse({}));
  }

  /**
   * 服务窗吊顶卡片关闭接口
   * 
   * @param request - CloseTopBoxInteractiveOTOMessageRequest
   * @returns CloseTopBoxInteractiveOTOMessageResponse
   */
  async closeTopBoxInteractiveOTOMessage(request: CloseTopBoxInteractiveOTOMessageRequest): Promise<CloseTopBoxInteractiveOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseTopBoxInteractiveOTOMessageHeaders({ });
    return await this.closeTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户授权信息
   * 
   * @param request - GetFollowerAuthInfoRequest
   * @param headers - GetFollowerAuthInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFollowerAuthInfoResponse
   */
  async getFollowerAuthInfoWithOptions(request: GetFollowerAuthInfoRequest, headers: GetFollowerAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFollowerAuthInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
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
      action: "GetFollowerAuthInfo",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/followers/authInfos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFollowerAuthInfoResponse>(await this.execute(params, req, runtime), new GetFollowerAuthInfoResponse({}));
  }

  /**
   * 获取用户授权信息
   * 
   * @param request - GetFollowerAuthInfoRequest
   * @returns GetFollowerAuthInfoResponse
   */
  async getFollowerAuthInfo(request: GetFollowerAuthInfoRequest): Promise<GetFollowerAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFollowerAuthInfoHeaders({ });
    return await this.getFollowerAuthInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取服务窗关注人信息
   * 
   * @param request - GetFollowerInfoRequest
   * @param headers - GetFollowerInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFollowerInfoResponse
   */
  async getFollowerInfoWithOptions(request: GetFollowerInfoRequest, headers: GetFollowerInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetFollowerInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetFollowerInfo",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/followers/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFollowerInfoResponse>(await this.execute(params, req, runtime), new GetFollowerInfoResponse({}));
  }

  /**
   * 获取服务窗关注人信息
   * 
   * @param request - GetFollowerInfoRequest
   * @returns GetFollowerInfoResponse
   */
  async getFollowerInfo(request: GetFollowerInfoRequest): Promise<GetFollowerInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFollowerInfoHeaders({ });
    return await this.getFollowerInfoWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗图片消息下载地址获取接口
   * 
   * @param request - GetPictureDownloadUrlRequest
   * @param headers - GetPictureDownloadUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPictureDownloadUrlResponse
   */
  async getPictureDownloadUrlWithOptions(request: GetPictureDownloadUrlRequest, headers: GetPictureDownloadUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetPictureDownloadUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.downloadCode)) {
      query["downloadCode"] = request.downloadCode;
    }

    if (!Util.isUnset(request.sessionId)) {
      query["sessionId"] = request.sessionId;
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
      action: "GetPictureDownloadUrl",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/oToMessages/pictures/downloadUrls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetPictureDownloadUrlResponse>(await this.execute(params, req, runtime), new GetPictureDownloadUrlResponse({}));
  }

  /**
   * 服务窗图片消息下载地址获取接口
   * 
   * @param request - GetPictureDownloadUrlRequest
   * @returns GetPictureDownloadUrlResponse
   */
  async getPictureDownloadUrl(request: GetPictureDownloadUrlRequest): Promise<GetPictureDownloadUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPictureDownloadUrlHeaders({ });
    return await this.getPictureDownloadUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取用户关注状态
   * 
   * @param request - GetUserFollowStatusRequest
   * @param headers - GetUserFollowStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetUserFollowStatusResponse
   */
  async getUserFollowStatusWithOptions(request: GetUserFollowStatusRequest, headers: GetUserFollowStatusHeaders, runtime: $Util.RuntimeOptions): Promise<GetUserFollowStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "GetUserFollowStatus",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/followers/statuses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetUserFollowStatusResponse>(await this.execute(params, req, runtime), new GetUserFollowStatusResponse({}));
  }

  /**
   * 获取用户关注状态
   * 
   * @param request - GetUserFollowStatusRequest
   * @returns GetUserFollowStatusResponse
   */
  async getUserFollowStatus(request: GetUserFollowStatusRequest): Promise<GetUserFollowStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUserFollowStatusHeaders({ });
    return await this.getUserFollowStatusWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业下服务窗帐号列表
   * 
   * @param headers - ListAccountHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAccountResponse
   */
  async listAccountWithOptions(headers: ListAccountHeaders, runtime: $Util.RuntimeOptions): Promise<ListAccountResponse> {
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
      action: "ListAccount",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/accounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAccountResponse>(await this.execute(params, req, runtime), new ListAccountResponse({}));
  }

  /**
   * 获取企业下服务窗帐号列表
   * @returns ListAccountResponse
   */
  async listAccount(): Promise<ListAccountResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAccountHeaders({ });
    return await this.listAccountWithOptions(headers, runtime);
  }

  /**
   * 第三方企业应用查询服务窗帐号列表
   * 
   * @param headers - ListAccountInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAccountInfoResponse
   */
  async listAccountInfoWithOptions(headers: ListAccountInfoHeaders, runtime: $Util.RuntimeOptions): Promise<ListAccountInfoResponse> {
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
      action: "ListAccountInfo",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/isv/accounts`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAccountInfoResponse>(await this.execute(params, req, runtime), new ListAccountInfoResponse({}));
  }

  /**
   * 第三方企业应用查询服务窗帐号列表
   * @returns ListAccountInfoResponse
   */
  async listAccountInfo(): Promise<ListAccountInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAccountInfoHeaders({ });
    return await this.listAccountInfoWithOptions(headers, runtime);
  }

  /**
   * 批量获取服务窗关注人列表
   * 
   * @param request - ListFollowerRequest
   * @param headers - ListFollowerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListFollowerResponse
   */
  async listFollowerWithOptions(request: ListFollowerRequest, headers: ListFollowerHeaders, runtime: $Util.RuntimeOptions): Promise<ListFollowerResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      action: "ListFollower",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/followers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListFollowerResponse>(await this.execute(params, req, runtime), new ListFollowerResponse({}));
  }

  /**
   * 批量获取服务窗关注人列表
   * 
   * @param request - ListFollowerRequest
   * @returns ListFollowerResponse
   */
  async listFollower(request: ListFollowerRequest): Promise<ListFollowerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListFollowerHeaders({ });
    return await this.listFollowerWithOptions(request, headers, runtime);
  }

  /**
   * 第三方企业应用查询用户是否关注服务窗
   * 
   * @param request - QueryUserFollowStatusRequest
   * @param headers - QueryUserFollowStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUserFollowStatusResponse
   */
  async queryUserFollowStatusWithOptions(request: QueryUserFollowStatusRequest, headers: QueryUserFollowStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserFollowStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.accountId)) {
      query["accountId"] = request.accountId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
      action: "QueryUserFollowStatus",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/isv/followers/statuses`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUserFollowStatusResponse>(await this.execute(params, req, runtime), new QueryUserFollowStatusResponse({}));
  }

  /**
   * 第三方企业应用查询用户是否关注服务窗
   * 
   * @param request - QueryUserFollowStatusRequest
   * @returns QueryUserFollowStatusResponse
   */
  async queryUserFollowStatus(request: QueryUserFollowStatusRequest): Promise<QueryUserFollowStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserFollowStatusHeaders({ });
    return await this.queryUserFollowStatusWithOptions(request, headers, runtime);
  }

  /**
   * 发送服务窗客服消息
   * 
   * @param request - SendAgentOTOMessageRequest
   * @param headers - SendAgentOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendAgentOTOMessageResponse
   */
  async sendAgentOTOMessageWithOptions(request: SendAgentOTOMessageRequest, headers: SendAgentOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendAgentOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "SendAgentOTOMessage",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/oToMessages/agentMessages`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendAgentOTOMessageResponse>(await this.execute(params, req, runtime), new SendAgentOTOMessageResponse({}));
  }

  /**
   * 发送服务窗客服消息
   * 
   * @param request - SendAgentOTOMessageRequest
   * @returns SendAgentOTOMessageResponse
   */
  async sendAgentOTOMessage(request: SendAgentOTOMessageRequest): Promise<SendAgentOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendAgentOTOMessageHeaders({ });
    return await this.sendAgentOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗互动卡片单发接口
   * 
   * @param request - SendInteractiveOTOMessageRequest
   * @param headers - SendInteractiveOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendInteractiveOTOMessageResponse
   */
  async sendInteractiveOTOMessageWithOptions(request: SendInteractiveOTOMessageRequest, headers: SendInteractiveOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendInteractiveOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "SendInteractiveOTOMessage",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/oToMessages/interactiveMessages`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendInteractiveOTOMessageResponse>(await this.execute(params, req, runtime), new SendInteractiveOTOMessageResponse({}));
  }

  /**
   * 服务窗互动卡片单发接口
   * 
   * @param request - SendInteractiveOTOMessageRequest
   * @returns SendInteractiveOTOMessageResponse
   */
  async sendInteractiveOTOMessage(request: SendInteractiveOTOMessageRequest): Promise<SendInteractiveOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInteractiveOTOMessageHeaders({ });
    return await this.sendInteractiveOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗吊顶卡片发送接口
   * 
   * @param request - SendTopBoxInteractiveOTOMessageRequest
   * @param headers - SendTopBoxInteractiveOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendTopBoxInteractiveOTOMessageResponse
   */
  async sendTopBoxInteractiveOTOMessageWithOptions(request: SendTopBoxInteractiveOTOMessageRequest, headers: SendTopBoxInteractiveOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendTopBoxInteractiveOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "SendTopBoxInteractiveOTOMessage",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/oToMessages/topBoxes/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendTopBoxInteractiveOTOMessageResponse>(await this.execute(params, req, runtime), new SendTopBoxInteractiveOTOMessageResponse({}));
  }

  /**
   * 服务窗吊顶卡片发送接口
   * 
   * @param request - SendTopBoxInteractiveOTOMessageRequest
   * @returns SendTopBoxInteractiveOTOMessageResponse
   */
  async sendTopBoxInteractiveOTOMessage(request: SendTopBoxInteractiveOTOMessageRequest): Promise<SendTopBoxInteractiveOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendTopBoxInteractiveOTOMessageHeaders({ });
    return await this.sendTopBoxInteractiveOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗互动卡片修改接口
   * 
   * @param request - UpdateInteractiveOTOMessageRequest
   * @param headers - UpdateInteractiveOTOMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInteractiveOTOMessageResponse
   */
  async updateInteractiveOTOMessageWithOptions(request: UpdateInteractiveOTOMessageRequest, headers: UpdateInteractiveOTOMessageHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInteractiveOTOMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "UpdateInteractiveOTOMessage",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/oToMessages/interactiveMessages`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInteractiveOTOMessageResponse>(await this.execute(params, req, runtime), new UpdateInteractiveOTOMessageResponse({}));
  }

  /**
   * 服务窗互动卡片修改接口
   * 
   * @param request - UpdateInteractiveOTOMessageRequest
   * @returns UpdateInteractiveOTOMessageResponse
   */
  async updateInteractiveOTOMessage(request: UpdateInteractiveOTOMessageRequest): Promise<UpdateInteractiveOTOMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInteractiveOTOMessageHeaders({ });
    return await this.updateInteractiveOTOMessageWithOptions(request, headers, runtime);
  }

  /**
   * 服务窗会话窗口快捷栏配置接口
   * 
   * @param request - UpdateShortcutsRequest
   * @param headers - UpdateShortcutsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateShortcutsResponse
   */
  async updateShortcutsWithOptions(request: UpdateShortcutsRequest, headers: UpdateShortcutsHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateShortcutsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.details)) {
      body["details"] = request.details;
    }

    if (!Util.isUnset(request.sessionId)) {
      body["sessionId"] = request.sessionId;
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
      action: "UpdateShortcuts",
      version: "link_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/link/shortcuts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateShortcutsResponse>(await this.execute(params, req, runtime), new UpdateShortcutsResponse({}));
  }

  /**
   * 服务窗会话窗口快捷栏配置接口
   * 
   * @param request - UpdateShortcutsRequest
   * @returns UpdateShortcutsResponse
   */
  async updateShortcuts(request: UpdateShortcutsRequest): Promise<UpdateShortcutsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateShortcutsHeaders({ });
    return await this.updateShortcutsWithOptions(request, headers, runtime);
  }

}
