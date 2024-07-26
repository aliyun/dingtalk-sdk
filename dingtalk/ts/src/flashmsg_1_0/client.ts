// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class PrivateFieldMapValue extends $tea.Model {
  /**
   * @example
   * XXX发了一条闪读消息，请于今天 12:00前查看
   */
  tipTitle?: string;
  isDingSend?: boolean;
  isRead?: boolean;
  buttonStatus?: string;
  extension?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      tipTitle: 'tipTitle',
      isDingSend: 'isDingSend',
      isRead: 'isRead',
      buttonStatus: 'buttonStatus',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tipTitle: 'string',
      isDingSend: 'boolean',
      isRead: 'boolean',
      buttonStatus: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPluginRuleHeaders extends $tea.Model {
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

export class AddPluginRuleRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * group_chat
   */
  chatType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * -10050
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * group
   */
  itemType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  rules?: AddPluginRuleRequestRules[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0847493113802787
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      chatType: 'chatType',
      code: 'code',
      itemType: 'itemType',
      rules: 'rules',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatType: 'string',
      code: 'string',
      itemType: 'string',
      rules: { 'type': 'array', 'itemType': AddPluginRuleRequestRules },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPluginRuleResponseBody extends $tea.Model {
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

export class AddPluginRuleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddPluginRuleResponseBody;
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
      body: AddPluginRuleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePlguinRuleHeaders extends $tea.Model {
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

export class DeletePlguinRuleRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  bizIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0847493113802787
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      bizIdList: 'bizIdList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizIdList: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeletePlguinRuleResponseBody extends $tea.Model {
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

export class DeletePlguinRuleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeletePlguinRuleResponseBody;
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
      body: DeletePlguinRuleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListHeaders extends $tea.Model {
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

export class GetBaseProfileListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  body?: string[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListResponseBody extends $tea.Model {
  result?: GetBaseProfileListResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetBaseProfileListResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetBaseProfileListResponseBody;
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
      body: GetBaseProfileListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationHeaders extends $tea.Model {
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

export class GetConversationRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidjyErBTyw0FnIQQigHAbcGCg==
   */
  openConversationId?: string;
  /**
   * @example
   * 080854121612617211
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationResponseBody extends $tea.Model {
  result?: GetConversationResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetConversationResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConversationResponseBody;
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
      body: GetConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMemberListHeaders extends $tea.Model {
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

export class GetMemberListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidjyErBTyw0FnIQQXXX2223==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
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
   * @example
   * 08474931138022787
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMemberListResponseBody extends $tea.Model {
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

export class GetMemberListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMemberListResponseBody;
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
      body: GetMemberListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPluginRuleHeaders extends $tea.Model {
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

export class QueryPluginRuleRequest extends $tea.Model {
  /**
   * @example
   * group_chat
   */
  chatType?: string;
  /**
   * @example
   * -10050
   */
  code?: string;
  /**
   * @example
   * 100
   */
  itemId?: string;
  /**
   * @example
   * group
   */
  itemType?: string;
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
      chatType: 'chatType',
      code: 'code',
      itemId: 'itemId',
      itemType: 'itemType',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatType: 'string',
      code: 'string',
      itemId: 'string',
      itemType: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPluginRuleResponseBody extends $tea.Model {
  result?: QueryPluginRuleResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryPluginRuleResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPluginRuleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryPluginRuleResponseBody;
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
      body: QueryPluginRuleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingTipHeaders extends $tea.Model {
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

export class SendDingTipRequest extends $tea.Model {
  extension?: { [key: string]: string };
  link?: SendDingTipRequestLink;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * msg_f9aae78558b34e20a5badead4c29244c_223
   */
  messageId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  receiverUserId?: string[];
  /**
   * @example
   * 080854121612261721
   */
  senderUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 您有一条闪读消息，请注意查收XX
   */
  textContent?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      link: 'link',
      messageId: 'messageId',
      receiverUserId: 'receiverUserId',
      senderUserId: 'senderUserId',
      textContent: 'textContent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      link: SendDingTipRequestLink,
      messageId: 'string',
      receiverUserId: { 'type': 'array', 'itemType': 'string' },
      senderUserId: 'string',
      textContent: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingTipResponseBody extends $tea.Model {
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

export class SendDingTipResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendDingTipResponseBody;
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
      body: SendDingTipResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipHeaders extends $tea.Model {
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

export class SendMessageTipRequest extends $tea.Model {
  defaultView?: SendMessageTipRequestDefaultView;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * msg_f9aae78558b34e20a5badead4c29244c_123
   */
  messageId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidVcYPzxnAySJOMhYX2QDbLwUA==
   */
  openConversationId?: string;
  privateFieldMap?: { [key: string]: PrivateFieldMapValue };
  publicField?: SendMessageTipRequestPublicField;
  /**
   * @remarks
   * This parameter is required.
   */
  receiverUserId?: string[];
  /**
   * @example
   * 0808541222161261721
   */
  senderUserId?: string;
  static names(): { [key: string]: string } {
    return {
      defaultView: 'defaultView',
      messageId: 'messageId',
      openConversationId: 'openConversationId',
      privateFieldMap: 'privateFieldMap',
      publicField: 'publicField',
      receiverUserId: 'receiverUserId',
      senderUserId: 'senderUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      defaultView: SendMessageTipRequestDefaultView,
      messageId: 'string',
      openConversationId: 'string',
      privateFieldMap: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateFieldMapValue },
      publicField: SendMessageTipRequestPublicField,
      receiverUserId: { 'type': 'array', 'itemType': 'string' },
      senderUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipResponseBody extends $tea.Model {
  result?: SendMessageTipResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SendMessageTipResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendMessageTipResponseBody;
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
      body: SendMessageTipResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddPluginRuleRequestRules extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  itemId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 管理员角色
   */
  itemName?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
      itemName: 'itemName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
      itemName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListResponseBodyResult extends $tea.Model {
  avatarMediaId?: string;
  nick?: string;
  nickPinyin?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      nick: 'nick',
      nickPinyin: 'nickPinyin',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'string',
      nick: 'string',
      nickPinyin: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationResponseBodyResult extends $tea.Model {
  corpId?: string;
  memberCount?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberCount: 'memberCount',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberCount: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPluginRuleResponseBodyResultData extends $tea.Model {
  bizId?: string;
  chatType?: string;
  code?: string;
  gmtCreate?: string;
  itemId?: string;
  itemName?: string;
  itemType?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      chatType: 'chatType',
      code: 'code',
      gmtCreate: 'gmtCreate',
      itemId: 'itemId',
      itemName: 'itemName',
      itemType: 'itemType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      chatType: 'string',
      code: 'string',
      gmtCreate: 'string',
      itemId: 'string',
      itemName: 'string',
      itemType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPluginRuleResponseBodyResult extends $tea.Model {
  data?: QueryPluginRuleResponseBodyResultData[];
  total?: number;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      total: 'total',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': QueryPluginRuleResponseBodyResultData },
      total: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingTipRequestLink extends $tea.Model {
  extension?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingtalk://dingtalkclient/page/link?pc_slide=true
   */
  linkUrl?: string;
  /**
   * @example
   * @lQLPDhrngMo4hi3NAZDNAZCwqp0RL2MfbesBqImWncBnAA2BCD
   */
  picMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 今天 10:00后超期
   */
  text?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      linkUrl: 'linkUrl',
      picMediaId: 'picMediaId',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      linkUrl: 'string',
      picMediaId: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipRequestDefaultView extends $tea.Model {
  actionName?: string;
  actionUrl?: string;
  authCode?: string;
  authMediaId?: string;
  /**
   * @example
   * 闪读消息卡片1
   */
  cardTitle?: string;
  cardTitleColor?: string;
  /**
   * @example
   * 查看详情
   */
  desc?: string;
  mediaId?: string;
  needShowUpdateTail?: string;
  summary?: string;
  /**
   * @example
   * 闪读消息卡片2
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      actionUrl: 'actionUrl',
      authCode: 'authCode',
      authMediaId: 'authMediaId',
      cardTitle: 'cardTitle',
      cardTitleColor: 'cardTitleColor',
      desc: 'desc',
      mediaId: 'mediaId',
      needShowUpdateTail: 'needShowUpdateTail',
      summary: 'summary',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      actionUrl: 'string',
      authCode: 'string',
      authMediaId: 'string',
      cardTitle: 'string',
      cardTitleColor: 'string',
      desc: 'string',
      mediaId: 'string',
      needShowUpdateTail: 'string',
      summary: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipRequestPublicField extends $tea.Model {
  /**
   * @example
   * dingtalk://dingtalkclient/page/link33
   */
  detailUrl?: string;
  /**
   * @example
   * 限时阅读5分钟
   */
  durationDesc?: string;
  extension?: { [key: string]: string };
  isExpired?: boolean;
  /**
   * @example
   * dingtalk://dingtalkclient/page/linkxx
   */
  readActionUrl?: string;
  /**
   * @example
   * 已查收 0/1
   */
  readProgressDesc?: string;
  static names(): { [key: string]: string } {
    return {
      detailUrl: 'detailUrl',
      durationDesc: 'durationDesc',
      extension: 'extension',
      isExpired: 'isExpired',
      readActionUrl: 'readActionUrl',
      readProgressDesc: 'readProgressDesc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detailUrl: 'string',
      durationDesc: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      isExpired: 'boolean',
      readActionUrl: 'string',
      readProgressDesc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipResponseBodyResult extends $tea.Model {
  bizId?: string;
  cardInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      cardInstanceId: 'cardInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      cardInstanceId: 'string',
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
   * 添加插件规则
   * 
   * @param request - AddPluginRuleRequest
   * @param headers - AddPluginRuleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddPluginRuleResponse
   */
  async addPluginRuleWithOptions(request: AddPluginRuleRequest, headers: AddPluginRuleHeaders, runtime: $Util.RuntimeOptions): Promise<AddPluginRuleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatType)) {
      body["chatType"] = request.chatType;
    }

    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.itemType)) {
      body["itemType"] = request.itemType;
    }

    if (!Util.isUnset(request.rules)) {
      body["rules"] = request.rules;
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
      action: "AddPluginRule",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/plugins`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddPluginRuleResponse>(await this.execute(params, req, runtime), new AddPluginRuleResponse({}));
  }

  /**
   * 添加插件规则
   * 
   * @param request - AddPluginRuleRequest
   * @returns AddPluginRuleResponse
   */
  async addPluginRule(request: AddPluginRuleRequest): Promise<AddPluginRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddPluginRuleHeaders({ });
    return await this.addPluginRuleWithOptions(request, headers, runtime);
  }

  /**
   * 删除插件规则
   * 
   * @param request - DeletePlguinRuleRequest
   * @param headers - DeletePlguinRuleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeletePlguinRuleResponse
   */
  async deletePlguinRuleWithOptions(request: DeletePlguinRuleRequest, headers: DeletePlguinRuleHeaders, runtime: $Util.RuntimeOptions): Promise<DeletePlguinRuleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizIdList)) {
      body["bizIdList"] = request.bizIdList;
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
      action: "DeletePlguinRule",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/plugins/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeletePlguinRuleResponse>(await this.execute(params, req, runtime), new DeletePlguinRuleResponse({}));
  }

  /**
   * 删除插件规则
   * 
   * @param request - DeletePlguinRuleRequest
   * @returns DeletePlguinRuleResponse
   */
  async deletePlguinRule(request: DeletePlguinRuleRequest): Promise<DeletePlguinRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeletePlguinRuleHeaders({ });
    return await this.deletePlguinRuleWithOptions(request, headers, runtime);
  }

  /**
   * 闪读用户基础信息查询
   * 
   * @param request - GetBaseProfileListRequest
   * @param headers - GetBaseProfileListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetBaseProfileListResponse
   */
  async getBaseProfileListWithOptions(request: GetBaseProfileListRequest, headers: GetBaseProfileListHeaders, runtime: $Util.RuntimeOptions): Promise<GetBaseProfileListResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "GetBaseProfileList",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/users/baseInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBaseProfileListResponse>(await this.execute(params, req, runtime), new GetBaseProfileListResponse({}));
  }

  /**
   * 闪读用户基础信息查询
   * 
   * @param request - GetBaseProfileListRequest
   * @returns GetBaseProfileListResponse
   */
  async getBaseProfileList(request: GetBaseProfileListRequest): Promise<GetBaseProfileListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBaseProfileListHeaders({ });
    return await this.getBaseProfileListWithOptions(request, headers, runtime);
  }

  /**
   * 获得闪读会话信息
   * 
   * @param request - GetConversationRequest
   * @param headers - GetConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConversationResponse
   */
  async getConversationWithOptions(request: GetConversationRequest, headers: GetConversationHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
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
      action: "GetConversation",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/conversations/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConversationResponse>(await this.execute(params, req, runtime), new GetConversationResponse({}));
  }

  /**
   * 获得闪读会话信息
   * 
   * @param request - GetConversationRequest
   * @returns GetConversationResponse
   */
  async getConversation(request: GetConversationRequest): Promise<GetConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationHeaders({ });
    return await this.getConversationWithOptions(request, headers, runtime);
  }

  /**
   * 获得成员ID列表
   * 
   * @param request - GetMemberListRequest
   * @param headers - GetMemberListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMemberListResponse
   */
  async getMemberListWithOptions(request: GetMemberListRequest, headers: GetMemberListHeaders, runtime: $Util.RuntimeOptions): Promise<GetMemberListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
      action: "GetMemberList",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/conversations/memberIdLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMemberListResponse>(await this.execute(params, req, runtime), new GetMemberListResponse({}));
  }

  /**
   * 获得成员ID列表
   * 
   * @param request - GetMemberListRequest
   * @returns GetMemberListResponse
   */
  async getMemberList(request: GetMemberListRequest): Promise<GetMemberListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMemberListHeaders({ });
    return await this.getMemberListWithOptions(request, headers, runtime);
  }

  /**
   * 查询插件规则
   * 
   * @param request - QueryPluginRuleRequest
   * @param headers - QueryPluginRuleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryPluginRuleResponse
   */
  async queryPluginRuleWithOptions(request: QueryPluginRuleRequest, headers: QueryPluginRuleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPluginRuleResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatType)) {
      query["chatType"] = request.chatType;
    }

    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
    }

    if (!Util.isUnset(request.itemId)) {
      query["itemId"] = request.itemId;
    }

    if (!Util.isUnset(request.itemType)) {
      query["itemType"] = request.itemType;
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
      action: "QueryPluginRule",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/plugins`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPluginRuleResponse>(await this.execute(params, req, runtime), new QueryPluginRuleResponse({}));
  }

  /**
   * 查询插件规则
   * 
   * @param request - QueryPluginRuleRequest
   * @returns QueryPluginRuleResponse
   */
  async queryPluginRule(request: QueryPluginRuleRequest): Promise<QueryPluginRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPluginRuleHeaders({ });
    return await this.queryPluginRuleWithOptions(request, headers, runtime);
  }

  /**
   * 发送Ding提示消息
   * 
   * @param request - SendDingTipRequest
   * @param headers - SendDingTipHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendDingTipResponse
   */
  async sendDingTipWithOptions(request: SendDingTipRequest, headers: SendDingTipHeaders, runtime: $Util.RuntimeOptions): Promise<SendDingTipResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.link)) {
      body["link"] = request.link;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.receiverUserId)) {
      body["receiverUserId"] = request.receiverUserId;
    }

    if (!Util.isUnset(request.senderUserId)) {
      body["senderUserId"] = request.senderUserId;
    }

    if (!Util.isUnset(request.textContent)) {
      body["textContent"] = request.textContent;
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
      action: "SendDingTip",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/ding/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendDingTipResponse>(await this.execute(params, req, runtime), new SendDingTipResponse({}));
  }

  /**
   * 发送Ding提示消息
   * 
   * @param request - SendDingTipRequest
   * @returns SendDingTipResponse
   */
  async sendDingTip(request: SendDingTipRequest): Promise<SendDingTipResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendDingTipHeaders({ });
    return await this.sendDingTipWithOptions(request, headers, runtime);
  }

  /**
   * 发送闪读消息提示
   * 
   * @param request - SendMessageTipRequest
   * @param headers - SendMessageTipHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendMessageTipResponse
   */
  async sendMessageTipWithOptions(request: SendMessageTipRequest, headers: SendMessageTipHeaders, runtime: $Util.RuntimeOptions): Promise<SendMessageTipResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.defaultView)) {
      body["defaultView"] = request.defaultView;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.privateFieldMap)) {
      body["privateFieldMap"] = request.privateFieldMap;
    }

    if (!Util.isUnset(request.publicField)) {
      body["publicField"] = request.publicField;
    }

    if (!Util.isUnset(request.receiverUserId)) {
      body["receiverUserId"] = request.receiverUserId;
    }

    if (!Util.isUnset(request.senderUserId)) {
      body["senderUserId"] = request.senderUserId;
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
      action: "SendMessageTip",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMessageTipResponse>(await this.execute(params, req, runtime), new SendMessageTipResponse({}));
  }

  /**
   * 发送闪读消息提示
   * 
   * @param request - SendMessageTipRequest
   * @returns SendMessageTipResponse
   */
  async sendMessageTip(request: SendMessageTipRequest): Promise<SendMessageTipResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageTipHeaders({ });
    return await this.sendMessageTipWithOptions(request, headers, runtime);
  }

}
