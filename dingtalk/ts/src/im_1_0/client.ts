// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class PrivateDataValue extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  cardMediaIdParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
      cardMediaIdParamMap: 'cardMediaIdParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOrgTextEmotionHeaders extends $tea.Model {
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

export class AddOrgTextEmotionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @123xxx
   */
  backgroundMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @345xxx
   */
  backgroundMediaIdForPanel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * -1
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 企业表情1
   */
  emotionName?: string;
  static names(): { [key: string]: string } {
    return {
      backgroundMediaId: 'backgroundMediaId',
      backgroundMediaIdForPanel: 'backgroundMediaIdForPanel',
      deptId: 'deptId',
      emotionName: 'emotionName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundMediaId: 'string',
      backgroundMediaIdForPanel: 'string',
      deptId: 'number',
      emotionName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOrgTextEmotionResponseBody extends $tea.Model {
  result?: AddOrgTextEmotionResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AddOrgTextEmotionResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOrgTextEmotionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddOrgTextEmotionResponseBody;
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
      body: AddOrgTextEmotionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRobotToConversationHeaders extends $tea.Model {
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

export class AddRobotToConversationRequest extends $tea.Model {
  /**
   * @example
   * @lALPDe7s26Bre
   */
  icon?: string;
  /**
   * @example
   * 小加
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid123cd
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      name: 'name',
      openConversationId: 'openConversationId',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      name: 'string',
      openConversationId: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRobotToConversationResponseBody extends $tea.Model {
  chatBotUserId?: string;
  static names(): { [key: string]: string } {
    return {
      chatBotUserId: 'chatBotUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatBotUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRobotToConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddRobotToConversationResponseBody;
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
      body: AddRobotToConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddUnfurlingRegisterHeaders extends $tea.Model {
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

export class AddUnfurlingRegisterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  apiSecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://xxx.xxx.com/api/dingtalk/link_unfurling
   */
  callbackUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * d7b9xxx-xxx-xxxx-xxxx-xxxxxxx.schema
   */
  cardTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.dingtalk.com
   */
  domain?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * /
   */
  path?: string;
  /**
   * @example
   * 规则描述
   */
  ruleDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  ruleMatchType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 37xxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      apiSecret: 'apiSecret',
      appId: 'appId',
      callbackUrl: 'callbackUrl',
      cardTemplateId: 'cardTemplateId',
      domain: 'domain',
      path: 'path',
      ruleDesc: 'ruleDesc',
      ruleMatchType: 'ruleMatchType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiSecret: 'string',
      appId: 'string',
      callbackUrl: 'string',
      cardTemplateId: 'string',
      domain: 'string',
      path: 'string',
      ruleDesc: 'string',
      ruleMatchType: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddUnfurlingRegisterResponseBody extends $tea.Model {
  /**
   * @example
   * 1
   */
  id?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddUnfurlingRegisterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddUnfurlingRegisterResponseBody;
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
      body: AddUnfurlingRegisterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AutoOpenDingTalkConnectHeaders extends $tea.Model {
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

export class AutoOpenDingTalkConnectResponseBody extends $tea.Model {
  message?: string;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AutoOpenDingTalkConnectResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AutoOpenDingTalkConnectResponseBody;
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
      body: AutoOpenDingTalkConnectResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryFamilySchoolMessageHeaders extends $tea.Model {
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

export class BatchQueryFamilySchoolMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxx
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openMessageIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openMessageIds: 'openMessageIds',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openMessageIds: { 'type': 'array', 'itemType': 'string' },
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryFamilySchoolMessageResponseBody extends $tea.Model {
  messages?: BatchQueryFamilySchoolMessageResponseBodyMessages[];
  static names(): { [key: string]: string } {
    return {
      messages: 'messages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messages: { 'type': 'array', 'itemType': BatchQueryFamilySchoolMessageResponseBodyMessages },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryFamilySchoolMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchQueryFamilySchoolMessageResponseBody;
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
      body: BatchQueryFamilySchoolMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryGroupMemberHeaders extends $tea.Model {
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

export class BatchQueryGroupMemberRequest extends $tea.Model {
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 200
   */
  maxResults?: number;
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      maxResults: 'number',
      nextToken: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryGroupMemberResponseBody extends $tea.Model {
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @example
   * cidXXXXXXXXX==
   */
  memberUserIds?: string[];
  /**
   * @example
   * 92233720368
   */
  nextToken?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      memberUserIds: 'memberUserIds',
      nextToken: 'nextToken',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      memberUserIds: { 'type': 'array', 'itemType': 'string' },
      nextToken: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryGroupMemberResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchQueryGroupMemberResponseBody;
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
      body: BatchQueryGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardTemplateBuildActionHeaders extends $tea.Model {
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

export class CardTemplateBuildActionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  action?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * merge
   */
  cardTemplateJson?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      cardTemplateJson: 'cardTemplateJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'string',
      cardTemplateJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardTemplateBuildActionResponseBody extends $tea.Model {
  /**
   * @example
   * {"xxx":"xxx"}
   */
  cardTemplateJson?: string;
  static names(): { [key: string]: string } {
    return {
      cardTemplateJson: 'cardTemplateJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardTemplateJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CardTemplateBuildActionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CardTemplateBuildActionResponseBody;
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
      body: CardTemplateBuildActionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangeGroupOwnerHeaders extends $tea.Model {
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

export class ChangeGroupOwnerRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  groupOwnerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  groupOwnerType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      groupOwnerId: 'groupOwnerId',
      groupOwnerType: 'groupOwnerType',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupOwnerId: 'string',
      groupOwnerType: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangeGroupOwnerResponseBody extends $tea.Model {
  newGroupOwnerId?: string;
  newGroupOwnerType?: number;
  static names(): { [key: string]: string } {
    return {
      newGroupOwnerId: 'newGroupOwnerId',
      newGroupOwnerType: 'newGroupOwnerType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      newGroupOwnerId: 'string',
      newGroupOwnerType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChangeGroupOwnerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ChangeGroupOwnerResponseBody;
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
      body: ChangeGroupOwnerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChatIdToOpenConversationIdHeaders extends $tea.Model {
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

export class ChatIdToOpenConversationIdResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidl1B8RVUFmkO50OC9uEbySQ==
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChatIdToOpenConversationIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ChatIdToOpenConversationIdResponseBody;
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
      body: ChatIdToOpenConversationIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChatSubAdminUpdateHeaders extends $tea.Model {
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

export class ChatSubAdminUpdateRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidVwhmrlxsR3sL3+JdH1LjUA==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  role?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      role: 'role',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      role: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChatSubAdminUpdateResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  success?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ChatSubAdminUpdateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ChatSubAdminUpdateResponseBody;
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
      body: ChatSubAdminUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckUserIsGroupMemberHeaders extends $tea.Model {
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

export class CheckUserIsGroupMemberRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidD2y*****==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 015*****
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

export class CheckUserIsGroupMemberResponseBody extends $tea.Model {
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

export class CheckUserIsGroupMemberResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckUserIsGroupMemberResponseBody;
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
      body: CheckUserIsGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyUnfurlingRegisterHeaders extends $tea.Model {
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

export class CopyUnfurlingRegisterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  id?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 37xxxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      id: 'id',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      id: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CopyUnfurlingRegisterResponseBody extends $tea.Model {
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

export class CopyUnfurlingRegisterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CopyUnfurlingRegisterResponseBody;
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
      body: CopyUnfurlingRegisterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountOpenMsgSceneGroupsHeaders extends $tea.Model {
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

export class CountOpenMsgSceneGroupsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * f6xxxxx
   */
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountOpenMsgSceneGroupsResponseBody extends $tea.Model {
  result?: CountOpenMsgSceneGroupsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: CountOpenMsgSceneGroupsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountOpenMsgSceneGroupsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CountOpenMsgSceneGroupsResponseBody;
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
      body: CountOpenMsgSceneGroupsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupConversationHeaders extends $tea.Model {
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

export class CreateCoupleGroupConversationRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2121
   */
  appUserId?: string;
  /**
   * @example
   * http://***.png
   */
  groupAvatar?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 客户群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  groupOwnerId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8d42****nkld
   */
  groupTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      groupAvatar: 'groupAvatar',
      groupName: 'groupName',
      groupOwnerId: 'groupOwnerId',
      groupTemplateId: 'groupTemplateId',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      groupAvatar: 'string',
      groupName: 'string',
      groupOwnerId: 'string',
      groupTemplateId: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupConversationResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid****8Q==
   */
  conversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateCoupleGroupConversationResponseBody;
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
      body: CreateCoupleGroupConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupConversationHeaders extends $tea.Model {
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

export class CreateGroupConversationRequest extends $tea.Model {
  appUserIds?: string[];
  /**
   * @example
   * http://***.png
   */
  groupAvatar?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 客户群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8777
   */
  groupOwnerId?: string;
  /**
   * @example
   * 3
   */
  groupOwnerType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8d42****nkld
   */
  groupTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8777
   */
  operatorId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      groupAvatar: 'groupAvatar',
      groupName: 'groupName',
      groupOwnerId: 'groupOwnerId',
      groupOwnerType: 'groupOwnerType',
      groupTemplateId: 'groupTemplateId',
      operatorId: 'operatorId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      groupAvatar: 'string',
      groupName: 'string',
      groupOwnerId: 'string',
      groupOwnerType: 'number',
      groupTemplateId: 'string',
      operatorId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupConversationResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appUserIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidpZ****Vcp4g==
   */
  conversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      conversationId: 'conversationId',
      openConversationId: 'openConversationId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      conversationId: 'string',
      openConversationId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateGroupConversationResponseBody;
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
      body: CreateGroupConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInterconnectionHeaders extends $tea.Model {
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

export class CreateInterconnectionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  interconnections?: CreateInterconnectionRequestInterconnections[];
  static names(): { [key: string]: string } {
    return {
      interconnections: 'interconnections',
    };
  }

  static types(): { [key: string]: any } {
    return {
      interconnections: { 'type': 'array', 'itemType': CreateInterconnectionRequestInterconnections },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInterconnectionResponseBody extends $tea.Model {
  results?: CreateInterconnectionResponseBodyResults[];
  static names(): { [key: string]: string } {
    return {
      results: 'results',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': CreateInterconnectionResponseBodyResults },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInterconnectionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateInterconnectionResponseBody;
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
      body: CreateInterconnectionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSceneGroupConversationHeaders extends $tea.Model {
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

export class CreateSceneGroupConversationRequest extends $tea.Model {
  features?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 客户群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  groupOwnerId?: string;
  /**
   * @example
   * http://***.png
   */
  icon?: string;
  managementOptions?: CreateSceneGroupConversationRequestManagementOptions;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8d42****nkld
   */
  templateId?: string;
  userIdList?: string[];
  /**
   * @example
   * asdazxc
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      features: 'features',
      groupName: 'groupName',
      groupOwnerId: 'groupOwnerId',
      icon: 'icon',
      managementOptions: 'managementOptions',
      templateId: 'templateId',
      userIdList: 'userIdList',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      features: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      groupName: 'string',
      groupOwnerId: 'string',
      icon: 'string',
      managementOptions: CreateSceneGroupConversationRequestManagementOptions,
      templateId: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSceneGroupConversationResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxxxx==
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSceneGroupConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateSceneGroupConversationResponseBody;
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
      body: CreateSceneGroupConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStoreGroupConversationHeaders extends $tea.Model {
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

export class CreateStoreGroupConversationRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  appUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * store1
   */
  businessUniqueKey?: string;
  /**
   * @example
   * http://***.png
   */
  groupAvatar?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 客户群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8d42****nkld
   */
  groupTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  operatorId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      businessUniqueKey: 'businessUniqueKey',
      groupAvatar: 'groupAvatar',
      groupName: 'groupName',
      groupTemplateId: 'groupTemplateId',
      operatorId: 'operatorId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      businessUniqueKey: 'string',
      groupAvatar: 'string',
      groupName: 'string',
      groupTemplateId: 'string',
      operatorId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStoreGroupConversationResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid****8Q==
   */
  conversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStoreGroupConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateStoreGroupConversationResponseBody;
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
      body: CreateStoreGroupConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DebugUnfurlingRegisterHeaders extends $tea.Model {
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

export class DebugUnfurlingRegisterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  grayGroupIdList?: string[];
  grayUserIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 37xxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      grayGroupIdList: 'grayGroupIdList',
      grayUserIdList: 'grayUserIdList',
      id: 'id',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      grayGroupIdList: { 'type': 'array', 'itemType': 'string' },
      grayUserIdList: { 'type': 'array', 'itemType': 'string' },
      id: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DebugUnfurlingRegisterResponseBody extends $tea.Model {
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

export class DebugUnfurlingRegisterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DebugUnfurlingRegisterResponseBody;
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
      body: DebugUnfurlingRegisterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgTextEmotionHeaders extends $tea.Model {
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

export class DeleteOrgTextEmotionRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * -1
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  emotionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      emotionIds: 'emotionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      emotionIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteOrgTextEmotionResponseBody extends $tea.Model {
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

export class DeleteOrgTextEmotionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteOrgTextEmotionResponseBody;
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
      body: DeleteOrgTextEmotionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DismissGroupConversationHeaders extends $tea.Model {
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

export class DismissGroupConversationRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DismissGroupConversationResponseBody extends $tea.Model {
  /**
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DismissGroupConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DismissGroupConversationResponseBody;
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
      body: DismissGroupConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationUrlHeaders extends $tea.Model {
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

export class GetConversationUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  appUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * oK4e****qER2
   */
  channelCode?: string;
  /**
   * @example
   * 123**789
   */
  deviceId?: string;
  /**
   * @example
   * f67b****8a0f
   */
  openConversationId?: string;
  /**
   * @example
   * 1745****8777
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      channelCode: 'channelCode',
      deviceId: 'deviceId',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      channelCode: 'string',
      deviceId: 'string',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationUrlResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
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

export class GetConversationUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConversationUrlResponseBody;
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
      body: GetConversationUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationMsgHeaders extends $tea.Model {
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

export class GetFamilySchoolConversationMsgRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  msgTypes?: number[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1666671122000
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxx
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      msgTypes: 'msgTypes',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      msgTypes: { 'type': 'array', 'itemType': 'number' },
      nextToken: 'number',
      openConversationId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationMsgResponseBody extends $tea.Model {
  /**
   * @example
   * corp123
   */
  corpId?: string;
  /**
   * @example
   * false
   */
  hasMore?: string;
  messages?: GetFamilySchoolConversationMsgResponseBodyMessages[];
  /**
   * @example
   * 1666671122000
   */
  nextToken?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      hasMore: 'hasMore',
      messages: 'messages',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      hasMore: 'string',
      messages: { 'type': 'array', 'itemType': GetFamilySchoolConversationMsgResponseBodyMessages },
      nextToken: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationMsgResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFamilySchoolConversationMsgResponseBody;
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
      body: GetFamilySchoolConversationMsgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationsHeaders extends $tea.Model {
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

export class GetFamilySchoolConversationsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationsResponseBody extends $tea.Model {
  groupInfoList?: GetFamilySchoolConversationsResponseBodyGroupInfoList[];
  /**
   * @example
   * false
   */
  hasMore?: string;
  /**
   * @example
   * 1666671122000
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      groupInfoList: 'groupInfoList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupInfoList: { 'type': 'array', 'itemType': GetFamilySchoolConversationsResponseBodyGroupInfoList },
      hasMore: 'string',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetFamilySchoolConversationsResponseBody;
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
      body: GetFamilySchoolConversationsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerGroupMembersHeaders extends $tea.Model {
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

export class GetInnerGroupMembersRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  /**
   * @example
   * UZr*****
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid1e*****==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 015*****
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerGroupMembersResponseBody extends $tea.Model {
  hasMore?: boolean;
  /**
   * @example
   * UZr*****
   */
  nextToken?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInnerGroupMembersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInnerGroupMembersResponseBody;
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
      body: GetInnerGroupMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInterconnectionUrlHeaders extends $tea.Model {
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

export class GetInterconnectionUrlRequest extends $tea.Model {
  appUserAvatar?: string;
  appUserAvatarType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  appUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  appUserMobileNumber?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  appUserName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  msgPageType?: number;
  qrCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  signature?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  sourceCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  sourceType?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserAvatar: 'appUserAvatar',
      appUserAvatarType: 'appUserAvatarType',
      appUserId: 'appUserId',
      appUserMobileNumber: 'appUserMobileNumber',
      appUserName: 'appUserName',
      msgPageType: 'msgPageType',
      qrCode: 'qrCode',
      signature: 'signature',
      sourceCode: 'sourceCode',
      sourceType: 'sourceType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserAvatar: 'string',
      appUserAvatarType: 'number',
      appUserId: 'string',
      appUserMobileNumber: 'string',
      appUserName: 'string',
      msgPageType: 'number',
      qrCode: 'string',
      signature: 'string',
      sourceCode: 'string',
      sourceType: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInterconnectionUrlResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
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

export class GetInterconnectionUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInterconnectionUrlResponseBody;
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
      body: GetInterconnectionUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNewestInnerGroupsHeaders extends $tea.Model {
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

export class GetNewestInnerGroupsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 015*****
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

export class GetNewestInnerGroupsResponseBody extends $tea.Model {
  groupInfos?: GetNewestInnerGroupsResponseBodyGroupInfos[];
  static names(): { [key: string]: string } {
    return {
      groupInfos: 'groupInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupInfos: { 'type': 'array', 'itemType': GetNewestInnerGroupsResponseBodyGroupInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNewestInnerGroupsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetNewestInnerGroupsResponseBody;
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
      body: GetNewestInnerGroupsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSceneGroupInfoHeaders extends $tea.Model {
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

export class GetSceneGroupInfoRequest extends $tea.Model {
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSceneGroupInfoResponseBody extends $tea.Model {
  groupUrl?: string;
  icon?: string;
  /**
   * @example
   * cidXXXXXXXXX==
   */
  openConversationId?: string;
  ownerUserId?: string;
  status?: number;
  success?: boolean;
  templateId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      groupUrl: 'groupUrl',
      icon: 'icon',
      openConversationId: 'openConversationId',
      ownerUserId: 'ownerUserId',
      status: 'status',
      success: 'success',
      templateId: 'templateId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupUrl: 'string',
      icon: 'string',
      openConversationId: 'string',
      ownerUserId: 'string',
      status: 'number',
      success: 'boolean',
      templateId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSceneGroupInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSceneGroupInfoResponseBody;
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
      body: GetSceneGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSceneGroupMembersHeaders extends $tea.Model {
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

export class GetSceneGroupMembersRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * false
   */
  cursor?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 200
   */
  size?: number;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      cursor: 'cursor',
      openConversationId: 'openConversationId',
      size: 'size',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      cursor: 'string',
      openConversationId: 'string',
      size: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSceneGroupMembersResponseBody extends $tea.Model {
  /**
   * @example
   * false
   */
  hasMore?: boolean;
  /**
   * @example
   * cidXXXXXXXXX==
   */
  memberUserIds?: string[];
  /**
   * @example
   * 92233720368
   */
  nextCursor?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      memberUserIds: 'memberUserIds',
      nextCursor: 'nextCursor',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      memberUserIds: { 'type': 'array', 'itemType': 'string' },
      nextCursor: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSceneGroupMembersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSceneGroupMembersResponseBody;
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
      body: GetSceneGroupMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupBanWordsHeaders extends $tea.Model {
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

export class GroupBanWordsRequest extends $tea.Model {
  /**
   * @example
   * 1
   */
  banWordsMode?: number;
  /**
   * @example
   * cidnvcxzklxv
   */
  openConversationId?: string;
  options?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      banWordsMode: 'banWordsMode',
      openConversationId: 'openConversationId',
      options: 'options',
    };
  }

  static types(): { [key: string]: any } {
    return {
      banWordsMode: 'number',
      openConversationId: 'string',
      options: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupBanWordsResponse extends $tea.Model {
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

export class GroupCapacityInquiryHeaders extends $tea.Model {
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

export class GroupCapacityInquiryRequest extends $tea.Model {
  /**
   * @example
   * 1Y
   */
  effectiveDuration?: string;
  /**
   * @example
   * ciddmslasdfxcvbxcvgidnxsd==
   */
  openConversationId?: string;
  /**
   * @example
   * 5782431748978293
   */
  operator?: string;
  options?: { [key: string]: any };
  /**
   * @example
   * 2000
   */
  targetCapacity?: number;
  static names(): { [key: string]: string } {
    return {
      effectiveDuration: 'effectiveDuration',
      openConversationId: 'openConversationId',
      operator: 'operator',
      options: 'options',
      targetCapacity: 'targetCapacity',
    };
  }

  static types(): { [key: string]: any } {
    return {
      effectiveDuration: 'string',
      openConversationId: 'string',
      operator: 'string',
      options: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      targetCapacity: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupCapacityInquiryResponseBody extends $tea.Model {
  /**
   * @example
   * 85000
   */
  actualPrice?: number;
  /**
   * @example
   * 1652183395772
   */
  createdAt?: number;
  /**
   * @example
   * 500
   */
  currentCapacity?: number;
  /**
   * @example
   * 1652183395772
   */
  currentEffectUntil?: number;
  /**
   * @example
   * 85
   */
  discount?: number;
  extInfo?: { [key: string]: any };
  /**
   * @example
   * 678912390478123
   */
  groupOwner?: string;
  /**
   * @example
   * 今天吃肘子群
   */
  groupTitle?: string;
  /**
   * @example
   * 10000
   */
  markedPrice?: number;
  /**
   * @example
   * 500
   */
  memberCount?: number;
  /**
   * @example
   * cidoondswfakscdviouhao==
   */
  openConversationId?: string;
  /**
   * @example
   * 32453245234523425
   */
  operator?: string;
  /**
   * @example
   * 10000
   */
  targetCapacity?: number;
  /**
   * @example
   * 1652183395772
   */
  targetEffectUntil?: number;
  /**
   * @example
   * jklasdhjfasdjkfkh421jk5bb243b523
   */
  token?: string;
  static names(): { [key: string]: string } {
    return {
      actualPrice: 'actualPrice',
      createdAt: 'createdAt',
      currentCapacity: 'currentCapacity',
      currentEffectUntil: 'currentEffectUntil',
      discount: 'discount',
      extInfo: 'extInfo',
      groupOwner: 'groupOwner',
      groupTitle: 'groupTitle',
      markedPrice: 'markedPrice',
      memberCount: 'memberCount',
      openConversationId: 'openConversationId',
      operator: 'operator',
      targetCapacity: 'targetCapacity',
      targetEffectUntil: 'targetEffectUntil',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualPrice: 'number',
      createdAt: 'number',
      currentCapacity: 'number',
      currentEffectUntil: 'number',
      discount: 'number',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      groupOwner: 'string',
      groupTitle: 'string',
      markedPrice: 'number',
      memberCount: 'number',
      openConversationId: 'string',
      operator: 'string',
      targetCapacity: 'number',
      targetEffectUntil: 'number',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupCapacityInquiryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GroupCapacityInquiryResponseBody;
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
      body: GroupCapacityInquiryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupCapacityOrderConfirmHeaders extends $tea.Model {
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

export class GroupCapacityOrderConfirmRequest extends $tea.Model {
  /**
   * @example
   * 066224
   */
  operator?: string;
  /**
   * @example
   * FAKE:0-28937rufhjdkslnawdkjsfk
   */
  orderId?: string;
  static names(): { [key: string]: string } {
    return {
      operator: 'operator',
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operator: 'string',
      orderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupCapacityOrderConfirmResponseBody extends $tea.Model {
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

export class GroupCapacityOrderConfirmResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GroupCapacityOrderConfirmResponseBody;
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
      body: GroupCapacityOrderConfirmResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupCapacityOrderPlaceHeaders extends $tea.Model {
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

export class GroupCapacityOrderPlaceRequest extends $tea.Model {
  /**
   * @example
   * 123
   */
  actualPrice?: number;
  /**
   * @example
   * 500
   */
  currentCapacity?: number;
  /**
   * @example
   * 1651751906
   */
  currentEffectUntil?: number;
  /**
   * @example
   * 85
   */
  discount?: number;
  extInfo?: { [key: string]: any };
  /**
   * @example
   * 123
   */
  markedPrice?: number;
  /**
   * @example
   * ciddmslidnxsd==
   */
  openConversationId?: string;
  /**
   * @example
   * 531781123123
   */
  operator?: string;
  /**
   * @example
   * 1000
   */
  targetCapacity?: number;
  /**
   * @example
   * 1651751906
   */
  targetEffectUntil?: number;
  /**
   * @example
   * dfsafsd
   */
  token?: string;
  static names(): { [key: string]: string } {
    return {
      actualPrice: 'actualPrice',
      currentCapacity: 'currentCapacity',
      currentEffectUntil: 'currentEffectUntil',
      discount: 'discount',
      extInfo: 'extInfo',
      markedPrice: 'markedPrice',
      openConversationId: 'openConversationId',
      operator: 'operator',
      targetCapacity: 'targetCapacity',
      targetEffectUntil: 'targetEffectUntil',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualPrice: 'number',
      currentCapacity: 'number',
      currentEffectUntil: 'number',
      discount: 'number',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      markedPrice: 'number',
      openConversationId: 'string',
      operator: 'string',
      targetCapacity: 'number',
      targetEffectUntil: 'number',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupCapacityOrderPlaceResponseBody extends $tea.Model {
  /**
   * @example
   * 85000
   */
  actualPrice?: number;
  /**
   * @example
   * 500
   */
  currentCapacity?: number;
  /**
   * @example
   * 1652669110553
   */
  currentEffectUntil?: number;
  /**
   * @example
   * 85
   */
  discount?: number;
  extInfo?: { [key: string]: string };
  /**
   * @example
   * 10000
   */
  markedPrice?: number;
  /**
   * @example
   * ciddfasvc
   */
  openConversationId?: string;
  /**
   * @example
   * 033333
   */
  operator?: string;
  /**
   * @example
   * 12389023745345500
   */
  orderId?: string;
  /**
   * @example
   * 10000
   */
  targetCapacity?: number;
  /**
   * @example
   * 1652669110553
   */
  targetEffectUntil?: number;
  /**
   * @example
   * 90ji34ontgrefv98u0ijo3q4awefg90rej
   */
  token?: string;
  static names(): { [key: string]: string } {
    return {
      actualPrice: 'actualPrice',
      currentCapacity: 'currentCapacity',
      currentEffectUntil: 'currentEffectUntil',
      discount: 'discount',
      extInfo: 'extInfo',
      markedPrice: 'markedPrice',
      openConversationId: 'openConversationId',
      operator: 'operator',
      orderId: 'orderId',
      targetCapacity: 'targetCapacity',
      targetEffectUntil: 'targetEffectUntil',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actualPrice: 'number',
      currentCapacity: 'number',
      currentEffectUntil: 'number',
      discount: 'number',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      markedPrice: 'number',
      openConversationId: 'string',
      operator: 'string',
      orderId: 'string',
      targetCapacity: 'number',
      targetEffectUntil: 'number',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupCapacityOrderPlaceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GroupCapacityOrderPlaceResponseBody;
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
      body: GroupCapacityOrderPlaceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManageQueryHeaders extends $tea.Model {
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

export class GroupManageQueryRequest extends $tea.Model {
  /**
   * @example
   * 1652183395772
   */
  createdAfter?: number;
  /**
   * @example
   * 53364321
   */
  groupId?: string;
  groupMemberSamples?: string[];
  /**
   * @example
   * 4122134
   */
  groupOwner?: string;
  groupTitleKeywords?: string[];
  /**
   * @example
   * https://h5.dingtalk.com/circle/healthCheckin.html?dtaction=os&corpId=ding91766asjkldhfkjklasdjkfjkhajksdjkfhjkla811&5fd5e=db2ed&cbdbhh=qwertyuiop
   */
  groupUrl?: string;
  /**
   * @example
   * 500
   */
  maxResults?: number;
  /**
   * @example
   * 1
   */
  membersOver?: number;
  /**
   * @example
   * 500
   */
  nextToken?: string;
  /**
   * @example
   * cidnvcxzklxv23jhkg412hj==
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      createdAfter: 'createdAfter',
      groupId: 'groupId',
      groupMemberSamples: 'groupMemberSamples',
      groupOwner: 'groupOwner',
      groupTitleKeywords: 'groupTitleKeywords',
      groupUrl: 'groupUrl',
      maxResults: 'maxResults',
      membersOver: 'membersOver',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdAfter: 'number',
      groupId: 'string',
      groupMemberSamples: { 'type': 'array', 'itemType': 'string' },
      groupOwner: 'string',
      groupTitleKeywords: { 'type': 'array', 'itemType': 'string' },
      groupUrl: 'string',
      maxResults: 'number',
      membersOver: 'number',
      nextToken: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManageQueryResponseBody extends $tea.Model {
  groupInfoList?: GroupManageQueryResponseBodyGroupInfoList[];
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * 500
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      groupInfoList: 'groupInfoList',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupInfoList: { 'type': 'array', 'itemType': GroupManageQueryResponseBodyGroupInfoList },
      hasMore: 'boolean',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManageQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GroupManageQueryResponseBody;
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
      body: GroupManageQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManageReduceHeaders extends $tea.Model {
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

export class GroupManageReduceRequest extends $tea.Model {
  /**
   * @example
   * 200
   */
  capacityLimit?: number;
  /**
   * @example
   * cidnvcxzklxv
   */
  openConversationId?: string;
  options?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      capacityLimit: 'capacityLimit',
      openConversationId: 'openConversationId',
      options: 'options',
    };
  }

  static types(): { [key: string]: any } {
    return {
      capacityLimit: 'number',
      openConversationId: 'string',
      options: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManageReduceResponse extends $tea.Model {
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

export class InstallRobotToOrgHeaders extends $tea.Model {
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

export class InstallRobotToOrgRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 这是小丁
   */
  brief?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 我是小丁
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @lALPDe7s26Bre
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 小丁
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  outgoingToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://*.com
   */
  outgoingUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @lALPDe7s26Bre
   */
  previewMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      brief: 'brief',
      description: 'description',
      icon: 'icon',
      name: 'name',
      outgoingToken: 'outgoingToken',
      outgoingUrl: 'outgoingUrl',
      previewMediaId: 'previewMediaId',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brief: 'string',
      description: 'string',
      icon: 'string',
      name: 'string',
      outgoingToken: 'string',
      outgoingUrl: 'string',
      previewMediaId: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallRobotToOrgResponseBody extends $tea.Model {
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallRobotToOrgResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InstallRobotToOrgResponseBody;
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
      body: InstallRobotToOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InteractiveCardCreateInstanceHeaders extends $tea.Model {
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

export class InteractiveCardCreateInstanceRequest extends $tea.Model {
  callbackRouteKey?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  cardData?: InteractiveCardCreateInstanceRequestCardData;
  /**
   * @remarks
   * This parameter is required.
   */
  cardTemplateId?: string;
  chatBotId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  conversationType?: number;
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  pullStrategy?: boolean;
  receiverUserIdList?: string[];
  robotCode?: string;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      chatBotId: 'chatBotId',
      conversationType: 'conversationType',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      pullStrategy: 'pullStrategy',
      receiverUserIdList: 'receiverUserIdList',
      robotCode: 'robotCode',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackRouteKey: 'string',
      cardData: InteractiveCardCreateInstanceRequestCardData,
      cardTemplateId: 'string',
      chatBotId: 'string',
      conversationType: 'number',
      openConversationId: 'string',
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      pullStrategy: 'boolean',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InteractiveCardCreateInstanceResponseBody extends $tea.Model {
  /**
   * @example
   * xxxxxx
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InteractiveCardCreateInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InteractiveCardCreateInstanceResponseBody;
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
      body: InteractiveCardCreateInstanceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrgTextEmotionHeaders extends $tea.Model {
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

export class ListOrgTextEmotionResponseBody extends $tea.Model {
  result?: ListOrgTextEmotionResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ListOrgTextEmotionResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrgTextEmotionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListOrgTextEmotionResponseBody;
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
      body: ListOrgTextEmotionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OfflineUnfurlingRegisterHeaders extends $tea.Model {
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

export class OfflineUnfurlingRegisterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: number;
  /**
   * @example
   * 37xxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      id: 'id',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      id: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OfflineUnfurlingRegisterResponseBody extends $tea.Model {
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

export class OfflineUnfurlingRegisterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OfflineUnfurlingRegisterResponseBody;
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
      body: OfflineUnfurlingRegisterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleAddHeaders extends $tea.Model {
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

export class OpenGroupRoleAddRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  roleName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      roleName: 'roleName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      roleName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleAddResponseBody extends $tea.Model {
  result?: OpenGroupRoleAddResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: OpenGroupRoleAddResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleAddResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenGroupRoleAddResponseBody;
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
      body: OpenGroupRoleAddResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleQueryHeaders extends $tea.Model {
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

export class OpenGroupRoleQueryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
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

export class OpenGroupRoleQueryResponseBody extends $tea.Model {
  result?: OpenGroupRoleQueryResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: OpenGroupRoleQueryResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenGroupRoleQueryResponseBody;
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
      body: OpenGroupRoleQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleRemoveHeaders extends $tea.Model {
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

export class OpenGroupRoleRemoveRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openRoleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openRoleId: 'openRoleId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openRoleId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleRemoveResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleRemoveResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenGroupRoleRemoveResponseBody;
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
      body: OpenGroupRoleRemoveResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleUpdateHeaders extends $tea.Model {
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

export class OpenGroupRoleUpdateRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openRoleId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  roleName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openRoleId: 'openRoleId',
      roleName: 'roleName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openRoleId: 'string',
      roleName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleUpdateResponseBody extends $tea.Model {
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleUpdateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenGroupRoleUpdateResponseBody;
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
      body: OpenGroupRoleUpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupUserRoleQueryHeaders extends $tea.Model {
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

export class OpenGroupUserRoleQueryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  viewedUserId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      userId: 'userId',
      viewedUserId: 'viewedUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      userId: 'string',
      viewedUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupUserRoleQueryResponseBody extends $tea.Model {
  result?: OpenGroupUserRoleQueryResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: OpenGroupUserRoleQueryResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupUserRoleQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenGroupUserRoleQueryResponseBody;
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
      body: OpenGroupUserRoleQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenInnerGroupTransferToDeptGroupHeaders extends $tea.Model {
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

export class OpenInnerGroupTransferToDeptGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidD2y*****==
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      deptId: 'deptId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deptId: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenInnerGroupTransferToDeptGroupResponseBody extends $tea.Model {
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

export class OpenInnerGroupTransferToDeptGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenInnerGroupTransferToDeptGroupResponseBody;
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
      body: OpenInnerGroupTransferToDeptGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenSearchGroupListHeaders extends $tea.Model {
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

export class OpenSearchGroupListRequest extends $tea.Model {
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      keyword: 'keyword',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyword: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenSearchGroupListResponseBody extends $tea.Model {
  result?: OpenSearchGroupListResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: OpenSearchGroupListResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenSearchGroupListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenSearchGroupListResponseBody;
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
      body: OpenSearchGroupListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserSendCardMessageHeaders extends $tea.Model {
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

export class OpenUserSendCardMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  cardContent?: OpenUserSendCardMessageRequestCardContent;
  openConversationId?: string;
  receiveUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      cardContent: 'cardContent',
      openConversationId: 'openConversationId',
      receiveUserId: 'receiveUserId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardContent: OpenUserSendCardMessageRequestCardContent,
      openConversationId: 'string',
      receiveUserId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserSendCardMessageResponseBody extends $tea.Model {
  result?: OpenUserSendCardMessageResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: OpenUserSendCardMessageResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserSendCardMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OpenUserSendCardMessageResponseBody;
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
      body: OpenUserSendCardMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PersonalSendCardMessageHeaders extends $tea.Model {
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

export class PersonalSendCardMessageRequest extends $tea.Model {
  atUserIds?: string[];
  cardContent?: PersonalSendCardMessageRequestCardContent;
  openConversationId?: string;
  receiveUserId?: string;
  static names(): { [key: string]: string } {
    return {
      atUserIds: 'atUserIds',
      cardContent: 'cardContent',
      openConversationId: 'openConversationId',
      receiveUserId: 'receiveUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atUserIds: { 'type': 'array', 'itemType': 'string' },
      cardContent: PersonalSendCardMessageRequestCardContent,
      openConversationId: 'string',
      receiveUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PersonalSendCardMessageResponseBody extends $tea.Model {
  result?: PersonalSendCardMessageResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PersonalSendCardMessageResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PersonalSendCardMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PersonalSendCardMessageResponseBody;
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
      body: PersonalSendCardMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoByMemberAuthHeaders extends $tea.Model {
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

export class QueryGroupInfoByMemberAuthRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COOLAPP-XXX
   */
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXX
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoByMemberAuthResponseBody extends $tea.Model {
  /**
   * @example
   * 99
   */
  memberCount?: number;
  static names(): { [key: string]: string } {
    return {
      memberCount: 'memberCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupInfoByMemberAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupInfoByMemberAuthResponseBody;
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
      body: QueryGroupInfoByMemberAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberHeaders extends $tea.Model {
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

export class QueryGroupMemberRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  groupMembers?: QueryGroupMemberResponseBodyGroupMembers[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      groupMembers: 'groupMembers',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMembers: { 'type': 'array', 'itemType': QueryGroupMemberResponseBodyGroupMembers },
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupMemberResponseBody;
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
      body: QueryGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberByMemberAuthHeaders extends $tea.Model {
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

export class QueryGroupMemberByMemberAuthRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COOLAPP-XXX
   */
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXX
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberByMemberAuthResponseBody extends $tea.Model {
  groupMemberList?: QueryGroupMemberByMemberAuthResponseBodyGroupMemberList[];
  static names(): { [key: string]: string } {
    return {
      groupMemberList: 'groupMemberList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMemberList: { 'type': 'array', 'itemType': QueryGroupMemberByMemberAuthResponseBodyGroupMemberList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberByMemberAuthResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupMemberByMemberAuthResponseBody;
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
      body: QueryGroupMemberByMemberAuthResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMuteStatusHeaders extends $tea.Model {
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

export class QueryGroupMuteStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidCtneF+XyQjcyF2ROdgSeIg==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 004741900
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

export class QueryGroupMuteStatusResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  groupMuteMode?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  userMuteResult?: QueryGroupMuteStatusResponseBodyUserMuteResult;
  static names(): { [key: string]: string } {
    return {
      groupMuteMode: 'groupMuteMode',
      userMuteResult: 'userMuteResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMuteMode: 'boolean',
      userMuteResult: QueryGroupMuteStatusResponseBodyUserMuteResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMuteStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupMuteStatusResponseBody;
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
      body: QueryGroupMuteStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInnerGroupMemberListHeaders extends $tea.Model {
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

export class QueryInnerGroupMemberListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  nextToken?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'number',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInnerGroupMemberListResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryInnerGroupMemberListResponseBodyList[];
  nextToken?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryInnerGroupMemberListResponseBodyList },
      nextToken: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInnerGroupMemberListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryInnerGroupMemberListResponseBody;
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
      body: QueryInnerGroupMemberListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInnerGroupRecentListHeaders extends $tea.Model {
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

export class QueryInnerGroupRecentListRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 015*****
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

export class QueryInnerGroupRecentListResponseBody extends $tea.Model {
  groupInfos?: QueryInnerGroupRecentListResponseBodyGroupInfos[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      groupInfos: 'groupInfos',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupInfos: { 'type': 'array', 'itemType': QueryInnerGroupRecentListResponseBodyGroupInfos },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInnerGroupRecentListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryInnerGroupRecentListResponseBody;
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
      body: QueryInnerGroupRecentListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMembersOfGroupRoleHeaders extends $tea.Model {
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

export class QueryMembersOfGroupRoleRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * roleXXXXX
   */
  openRoleId?: string;
  /**
   * @example
   * 1621502140000
   */
  timestamp?: number;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openRoleId: 'openRoleId',
      timestamp: 'timestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openRoleId: 'string',
      timestamp: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMembersOfGroupRoleResponseBody extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMembersOfGroupRoleResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMembersOfGroupRoleResponseBody;
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
      body: QueryMembersOfGroupRoleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMessageSendResultHeaders extends $tea.Model {
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

export class QueryMessageSendResultRequest extends $tea.Model {
  /**
   * @example
   * dhowhi23ohdh==
   */
  openTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      openTaskId: 'openTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMessageSendResultResponseBody extends $tea.Model {
  result?: QueryMessageSendResultResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryMessageSendResultResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMessageSendResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMessageSendResultResponseBody;
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
      body: QueryMessageSendResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenConversationReceiveUserHeaders extends $tea.Model {
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

export class QueryOpenConversationReceiveUserRequest extends $tea.Model {
  openConversationId?: string;
  sendUserId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      sendUserId: 'sendUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      sendUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenConversationReceiveUserResponseBody extends $tea.Model {
  result?: QueryOpenConversationReceiveUserResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOpenConversationReceiveUserResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenConversationReceiveUserResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOpenConversationReceiveUserResponseBody;
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
      body: QueryOpenConversationReceiveUserResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenGroupBaseInfoHeaders extends $tea.Model {
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

export class QueryOpenGroupBaseInfoRequest extends $tea.Model {
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenGroupBaseInfoResponseBody extends $tea.Model {
  result?: QueryOpenGroupBaseInfoResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOpenGroupBaseInfoResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenGroupBaseInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryOpenGroupBaseInfoResponseBody;
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
      body: QueryOpenGroupBaseInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPersonalMessageReadStatusHeaders extends $tea.Model {
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

export class QueryPersonalMessageReadStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidQGfKJCXMfVxZxxx3ZL0Qlw==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * msghnezLi8wb6pGqMsadhj9n0yw==
   */
  openMessageId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openMessageId: 'openMessageId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openMessageId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPersonalMessageReadStatusResponseBody extends $tea.Model {
  result?: QueryPersonalMessageReadStatusResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryPersonalMessageReadStatusResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPersonalMessageReadStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryPersonalMessageReadStatusResponseBody;
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
      body: QueryPersonalMessageReadStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentConversationsHeaders extends $tea.Model {
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

export class QueryRecentConversationsRequest extends $tea.Model {
  onlyHuman?: boolean;
  onlyInnerGroup?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      onlyHuman: 'onlyHuman',
      onlyInnerGroup: 'onlyInnerGroup',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      onlyHuman: 'boolean',
      onlyInnerGroup: 'boolean',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentConversationsResponseBody extends $tea.Model {
  result?: QueryRecentConversationsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryRecentConversationsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentConversationsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRecentConversationsResponseBody;
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
      body: QueryRecentConversationsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySceneGroupTemplateRobotHeaders extends $tea.Model {
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

export class QuerySceneGroupTemplateRobotRequest extends $tea.Model {
  /**
   * @example
   * cidCtneF+XyQjcyF2ROdgSeIg==
   */
  openConversationId?: string;
  /**
   * @example
   * ding5nbbeXXXXXXX
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySceneGroupTemplateRobotResponseBody extends $tea.Model {
  result?: QuerySceneGroupTemplateRobotResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QuerySceneGroupTemplateRobotResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySceneGroupTemplateRobotResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySceneGroupTemplateRobotResponseBody;
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
      body: QuerySceneGroupTemplateRobotResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleGroupHeaders extends $tea.Model {
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

export class QuerySingleGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8777
   */
  groupMembers?: QuerySingleGroupRequestGroupMembers[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  groupTemplateId?: string;
  static names(): { [key: string]: string } {
    return {
      groupMembers: 'groupMembers',
      groupTemplateId: 'groupTemplateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMembers: { 'type': 'array', 'itemType': QuerySingleGroupRequestGroupMembers },
      groupTemplateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleGroupResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openConversations?: QuerySingleGroupResponseBodyOpenConversations[];
  static names(): { [key: string]: string } {
    return {
      openConversations: 'openConversations',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversations: { 'type': 'array', 'itemType': QuerySingleGroupResponseBodyOpenConversations },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySingleGroupResponseBody;
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
      body: QuerySingleGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnReadMessageHeaders extends $tea.Model {
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

export class QueryUnReadMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  appUserId?: string;
  /**
   * @example
   * 1745****8777
   */
  openConversationIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      openConversationIds: 'openConversationIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnReadMessageResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  unReadCount?: number;
  unReadItems?: QueryUnReadMessageResponseBodyUnReadItems[];
  static names(): { [key: string]: string } {
    return {
      unReadCount: 'unReadCount',
      unReadItems: 'unReadItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unReadCount: 'number',
      unReadItems: { 'type': 'array', 'itemType': QueryUnReadMessageResponseBodyUnReadItems },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnReadMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUnReadMessageResponseBody;
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
      body: QueryUnReadMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterCreatorHeaders extends $tea.Model {
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

export class QueryUnfurlingRegisterCreatorRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.dingtalk.com
   */
  domain?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * /a
   */
  path?: string;
  static names(): { [key: string]: string } {
    return {
      domain: 'domain',
      path: 'path',
    };
  }

  static types(): { [key: string]: any } {
    return {
      domain: 'string',
      path: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterCreatorResponseBody extends $tea.Model {
  data?: QueryUnfurlingRegisterCreatorResponseBodyData;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: QueryUnfurlingRegisterCreatorResponseBodyData,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterCreatorResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUnfurlingRegisterCreatorResponseBody;
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
      body: QueryUnfurlingRegisterCreatorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterInfoHeaders extends $tea.Model {
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

export class QueryUnfurlingRegisterInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  /**
   * @example
   * 100
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      maxResults: 'number',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterInfoResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryUnfurlingRegisterInfoResponseBodyList[];
  nextToken?: number;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryUnfurlingRegisterInfoResponseBodyList },
      nextToken: 'number',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryUnfurlingRegisterInfoResponseBody;
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
      body: QueryUnfurlingRegisterInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseUnfurlingRegisterHeaders extends $tea.Model {
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

export class ReleaseUnfurlingRegisterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 37xxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      id: 'id',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      id: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReleaseUnfurlingRegisterResponseBody extends $tea.Model {
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

export class ReleaseUnfurlingRegisterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReleaseUnfurlingRegisterResponseBody;
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
      body: ReleaseUnfurlingRegisterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveRobotFromConversationHeaders extends $tea.Model {
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

export class RemoveRobotFromConversationRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  chatBotUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid123cd
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatBotUserId: 'chatBotUserId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatBotUserId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveRobotFromConversationResponseBody extends $tea.Model {
  chatBotUserId?: string;
  static names(): { [key: string]: string } {
    return {
      chatBotUserId: 'chatBotUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatBotUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveRobotFromConversationResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveRobotFromConversationResponseBody;
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
      body: RemoveRobotFromConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchInnerGroupsHeaders extends $tea.Model {
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

export class SearchInnerGroupsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试关键词
   */
  searchKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 015*****
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      searchKey: 'searchKey',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      searchKey: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchInnerGroupsResponseBody extends $tea.Model {
  groupInfos?: SearchInnerGroupsResponseBodyGroupInfos[];
  static names(): { [key: string]: string } {
    return {
      groupInfos: 'groupInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupInfos: { 'type': 'array', 'itemType': SearchInnerGroupsResponseBodyGroupInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchInnerGroupsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchInnerGroupsResponseBody;
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
      body: SearchInnerGroupsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardHeaders extends $tea.Model {
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

export class SendInteractiveCardRequest extends $tea.Model {
  atOpenIds?: { [key: string]: string };
  callbackRouteKey?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  cardData?: SendInteractiveCardRequestCardData;
  cardOptions?: SendInteractiveCardRequestCardOptions;
  /**
   * @remarks
   * This parameter is required.
   */
  cardTemplateId?: string;
  chatBotId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  conversationType?: number;
  digitalWorkerCode?: string;
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  pullStrategy?: boolean;
  receiverUserIdList?: string[];
  robotCode?: string;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      atOpenIds: 'atOpenIds',
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      cardOptions: 'cardOptions',
      cardTemplateId: 'cardTemplateId',
      chatBotId: 'chatBotId',
      conversationType: 'conversationType',
      digitalWorkerCode: 'digitalWorkerCode',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      pullStrategy: 'pullStrategy',
      receiverUserIdList: 'receiverUserIdList',
      robotCode: 'robotCode',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atOpenIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      callbackRouteKey: 'string',
      cardData: SendInteractiveCardRequestCardData,
      cardOptions: SendInteractiveCardRequestCardOptions,
      cardTemplateId: 'string',
      chatBotId: 'string',
      conversationType: 'number',
      digitalWorkerCode: 'string',
      openConversationId: 'string',
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      pullStrategy: 'boolean',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardResponseBody extends $tea.Model {
  result?: SendInteractiveCardResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SendInteractiveCardResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendInteractiveCardResponseBody;
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
      body: SendInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOTOInteractiveCardHeaders extends $tea.Model {
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

export class SendOTOInteractiveCardRequest extends $tea.Model {
  atOpenIds?: { [key: string]: string };
  callbackRouteKey?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  cardData?: SendOTOInteractiveCardRequestCardData;
  cardOptions?: SendOTOInteractiveCardRequestCardOptions;
  /**
   * @remarks
   * This parameter is required.
   */
  cardTemplateId?: string;
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  pullStrategy?: boolean;
  receiverUserIdList?: string[];
  robotCode?: string;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      atOpenIds: 'atOpenIds',
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      cardOptions: 'cardOptions',
      cardTemplateId: 'cardTemplateId',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      pullStrategy: 'pullStrategy',
      receiverUserIdList: 'receiverUserIdList',
      robotCode: 'robotCode',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atOpenIds: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      callbackRouteKey: 'string',
      cardData: SendOTOInteractiveCardRequestCardData,
      cardOptions: SendOTOInteractiveCardRequestCardOptions,
      cardTemplateId: 'string',
      openConversationId: 'string',
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      pullStrategy: 'boolean',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOTOInteractiveCardResponseBody extends $tea.Model {
  result?: SendOTOInteractiveCardResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SendOTOInteractiveCardResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOTOInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendOTOInteractiveCardResponseBody;
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
      body: SendOTOInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPersonalMessageHeaders extends $tea.Model {
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

export class SendPersonalMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"content":"月会通知<@all> ","at":{"atUserIds":[],"isAtAll":true}}
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  msgType?: string;
  /**
   * @example
   * cidc4iLyQBuHFQRvzxznz204Q==
   */
  openConversationId?: string;
  /**
   * @example
   * 1662055829854977
   */
  receiverUid?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      msgType: 'msgType',
      openConversationId: 'openConversationId',
      receiverUid: 'receiverUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      msgType: 'string',
      openConversationId: 'string',
      receiverUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPersonalMessageResponseBody extends $tea.Model {
  result?: SendPersonalMessageResponseBodyResult;
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SendPersonalMessageResponseBodyResult,
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPersonalMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendPersonalMessageResponseBody;
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
      body: SendPersonalMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotInteractiveCardHeaders extends $tea.Model {
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

export class SendRobotInteractiveCardRequest extends $tea.Model {
  /**
   * @example
   * https://xxx
   */
  callbackUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cardXXXX01
   */
  cardBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 根据具体的cardTemplateId参考文档格式
   */
  cardData?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxxxx
   */
  cardTemplateId?: string;
  /**
   * @example
   * cidXXXX
   */
  openConversationId?: string;
  pullStrategy?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxx
   */
  robotCode?: string;
  sendOptions?: SendRobotInteractiveCardRequestSendOptions;
  /**
   * @example
   * 以userId为例：{"userId":"userId0001"}；以unionId为例{"unionId":"unionId001"}
   */
  singleChatReceiver?: string;
  unionIdPrivateDataMap?: string;
  userIdPrivateDataMap?: string;
  static names(): { [key: string]: string } {
    return {
      callbackUrl: 'callbackUrl',
      cardBizId: 'cardBizId',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      openConversationId: 'openConversationId',
      pullStrategy: 'pullStrategy',
      robotCode: 'robotCode',
      sendOptions: 'sendOptions',
      singleChatReceiver: 'singleChatReceiver',
      unionIdPrivateDataMap: 'unionIdPrivateDataMap',
      userIdPrivateDataMap: 'userIdPrivateDataMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackUrl: 'string',
      cardBizId: 'string',
      cardData: 'string',
      cardTemplateId: 'string',
      openConversationId: 'string',
      pullStrategy: 'boolean',
      robotCode: 'string',
      sendOptions: SendRobotInteractiveCardRequestSendOptions,
      singleChatReceiver: 'string',
      unionIdPrivateDataMap: 'string',
      userIdPrivateDataMap: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotInteractiveCardResponseBody extends $tea.Model {
  /**
   * @example
   * xxxxxx
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendRobotInteractiveCardResponseBody;
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
      body: SendRobotInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotMessageHeaders extends $tea.Model {
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

export class SendRobotMessageRequest extends $tea.Model {
  atAll?: boolean;
  /**
   * @example
   * 1107****2120
   */
  atAppUserId?: string;
  /**
   * @example
   * 1107****2120
   */
  atDingUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * { "content": "我就是我, 是不一样的烟火"}
   */
  msgContent?: string;
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
   */
  openConversationIds?: string[];
  /**
   * @example
   * kelian-custom-service-robot-101
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      atAll: 'atAll',
      atAppUserId: 'atAppUserId',
      atDingUserId: 'atDingUserId',
      msgContent: 'msgContent',
      msgType: 'msgType',
      openConversationIds: 'openConversationIds',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAll: 'boolean',
      atAppUserId: 'string',
      atDingUserId: 'string',
      msgContent: 'string',
      msgType: 'string',
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotMessageResponseBody extends $tea.Model {
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

export class SendRobotMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendRobotMessageResponseBody;
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
      body: SendRobotMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTemplateInteractiveCardHeaders extends $tea.Model {
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

export class SendTemplateInteractiveCardRequest extends $tea.Model {
  /**
   * @example
   * https://xxxx.com/.../
   */
  callbackUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 根据具体的cardTemplateId参考文档格式
   */
  cardData?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TuWenCard01
   */
  cardTemplateId?: string;
  /**
   * @example
   * cidXXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cardXXXX01
   */
  outTrackId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxx
   */
  robotCode?: string;
  sendOptions?: SendTemplateInteractiveCardRequestSendOptions;
  /**
   * @example
   * 以userId为例：{"userId":"userId0001"}；以unionId为例{"unionId":"unionId001"}
   */
  singleChatReceiver?: string;
  static names(): { [key: string]: string } {
    return {
      callbackUrl: 'callbackUrl',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      robotCode: 'robotCode',
      sendOptions: 'sendOptions',
      singleChatReceiver: 'singleChatReceiver',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackUrl: 'string',
      cardData: 'string',
      cardTemplateId: 'string',
      openConversationId: 'string',
      outTrackId: 'string',
      robotCode: 'string',
      sendOptions: SendTemplateInteractiveCardRequestSendOptions,
      singleChatReceiver: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTemplateInteractiveCardResponseBody extends $tea.Model {
  /**
   * @example
   * xxxxxx
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTemplateInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendTemplateInteractiveCardResponseBody;
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
      body: SendTemplateInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRightPanelHeaders extends $tea.Model {
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

export class SetRightPanelRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ciddjxhgdDXSAAXXXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  rightPanelClosePermitted?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  rightPanelOpenStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 侧边栏标题
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  webWndParams?: SetRightPanelRequestWebWndParams;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 500
   */
  width?: number;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      rightPanelClosePermitted: 'rightPanelClosePermitted',
      rightPanelOpenStatus: 'rightPanelOpenStatus',
      title: 'title',
      webWndParams: 'webWndParams',
      width: 'width',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      rightPanelClosePermitted: 'boolean',
      rightPanelOpenStatus: 'number',
      title: 'string',
      webWndParams: SetRightPanelRequestWebWndParams,
      width: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRightPanelResponseBody extends $tea.Model {
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

export class SetRightPanelResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SetRightPanelResponseBody;
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
      body: SetRightPanelResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopboxCloseHeaders extends $tea.Model {
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

export class TopboxCloseRequest extends $tea.Model {
  conversationType?: number;
  coolAppCode?: string;
  /**
   * @example
   * xxxx
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx
   */
  outTrackId?: string;
  receiverUserIdList?: string[];
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      conversationType: 'conversationType',
      coolAppCode: 'coolAppCode',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      receiverUserIdList: 'receiverUserIdList',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationType: 'number',
      coolAppCode: 'string',
      openConversationId: 'string',
      outTrackId: 'string',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopboxCloseResponse extends $tea.Model {
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

export class TopboxOpenHeaders extends $tea.Model {
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

export class TopboxOpenRequest extends $tea.Model {
  conversationType?: number;
  coolAppCode?: string;
  /**
   * @example
   * 1850042969000
   */
  expiredTime?: number;
  /**
   * @example
   * xxxx
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxx
   */
  outTrackId?: string;
  /**
   * @example
   * ios|win
   */
  platforms?: string;
  /**
   * **if can be null:**
   * true
   */
  receiverUserIdList?: string[];
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      conversationType: 'conversationType',
      coolAppCode: 'coolAppCode',
      expiredTime: 'expiredTime',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      platforms: 'platforms',
      receiverUserIdList: 'receiverUserIdList',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationType: 'number',
      coolAppCode: 'string',
      expiredTime: 'number',
      openConversationId: 'string',
      outTrackId: 'string',
      platforms: 'string',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopboxOpenResponse extends $tea.Model {
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

export class UpdateGroupAvatarHeaders extends $tea.Model {
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

export class UpdateGroupAvatarRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * http://***.png
   */
  groupAvatar?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      groupAvatar: 'groupAvatar',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupAvatar: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupAvatarResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  newGroupAvatar?: string;
  static names(): { [key: string]: string } {
    return {
      newGroupAvatar: 'newGroupAvatar',
    };
  }

  static types(): { [key: string]: any } {
    return {
      newGroupAvatar: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupAvatarResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateGroupAvatarResponseBody;
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
      body: UpdateGroupAvatarResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupNameHeaders extends $tea.Model {
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

export class UpdateGroupNameRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupNameResponseBody extends $tea.Model {
  newGroupName?: string;
  static names(): { [key: string]: string } {
    return {
      newGroupName: 'newGroupName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      newGroupName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupNameResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateGroupNameResponseBody;
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
      body: UpdateGroupNameResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupPermissionHeaders extends $tea.Model {
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

export class UpdateGroupPermissionRequest extends $tea.Model {
  /**
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  permissionGroup?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      permissionGroup: 'permissionGroup',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      permissionGroup: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupPermissionResponseBody extends $tea.Model {
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

export class UpdateGroupPermissionResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateGroupPermissionResponseBody;
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
      body: UpdateGroupPermissionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupSubAdminHeaders extends $tea.Model {
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

export class UpdateGroupSubAdminRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  role?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      role: 'role',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      role: 'number',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupSubAdminResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
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

export class UpdateGroupSubAdminResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateGroupSubAdminResponseBody;
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
      body: UpdateGroupSubAdminResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardHeaders extends $tea.Model {
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

export class UpdateInteractiveCardRequest extends $tea.Model {
  cardData?: UpdateInteractiveCardRequestCardData;
  cardOptions?: UpdateInteractiveCardRequestCardOptions;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      cardData: 'cardData',
      cardOptions: 'cardOptions',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
      userIdType: 'userIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardData: UpdateInteractiveCardRequestCardData,
      cardOptions: UpdateInteractiveCardRequestCardOptions,
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
      userIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardResponseBody extends $tea.Model {
  success?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInteractiveCardResponseBody;
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
      body: UpdateInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMemberBanWordsHeaders extends $tea.Model {
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

export class UpdateMemberBanWordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 300000
   */
  muteDuration?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  muteStatus?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid5d5uM3XEw3gxbNc/n7EQ4g==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      muteDuration: 'muteDuration',
      muteStatus: 'muteStatus',
      openConversationId: 'openConversationId',
      userIdList: 'userIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      muteDuration: 'number',
      muteStatus: 'number',
      openConversationId: 'string',
      userIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMemberBanWordsResponse extends $tea.Model {
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

export class UpdateMemberGroupNickHeaders extends $tea.Model {
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

export class UpdateMemberGroupNickRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  groupNick?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      groupNick: 'groupNick',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNick: 'string',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateMemberGroupNickResponseBody extends $tea.Model {
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

export class UpdateMemberGroupNickResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateMemberGroupNickResponseBody;
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
      body: UpdateMemberGroupNickResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRobotInOrgHeaders extends $tea.Model {
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

export class UpdateRobotInOrgRequest extends $tea.Model {
  /**
   * @example
   * 小加
   */
  brief?: string;
  /**
   * @example
   * 小加
   */
  description?: string;
  /**
   * @example
   * @lALPDe7s26Bre
   */
  icon?: string;
  /**
   * @example
   * 小加
   */
  name?: string;
  /**
   * @example
   * 123
   */
  outgoingToken?: string;
  /**
   * @example
   * https://*.com
   */
  outgoingUrl?: string;
  /**
   * @example
   * @lALPDe7s26Bre
   */
  previewMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      brief: 'brief',
      description: 'description',
      icon: 'icon',
      name: 'name',
      outgoingToken: 'outgoingToken',
      outgoingUrl: 'outgoingUrl',
      previewMediaId: 'previewMediaId',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brief: 'string',
      description: 'string',
      icon: 'string',
      name: 'string',
      outgoingToken: 'string',
      outgoingUrl: 'string',
      previewMediaId: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRobotInOrgResponseBody extends $tea.Model {
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRobotInOrgResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateRobotInOrgResponseBody;
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
      body: UpdateRobotInOrgResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRobotInteractiveCardHeaders extends $tea.Model {
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

export class UpdateRobotInteractiveCardRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cardXXXX01
   */
  cardBizId?: string;
  /**
   * @example
   * 根据具体的cardTemplateId参考文档格式
   */
  cardData?: string;
  unionIdPrivateDataMap?: string;
  updateOptions?: UpdateRobotInteractiveCardRequestUpdateOptions;
  userIdPrivateDataMap?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizId: 'cardBizId',
      cardData: 'cardData',
      unionIdPrivateDataMap: 'unionIdPrivateDataMap',
      updateOptions: 'updateOptions',
      userIdPrivateDataMap: 'userIdPrivateDataMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizId: 'string',
      cardData: 'string',
      unionIdPrivateDataMap: 'string',
      updateOptions: UpdateRobotInteractiveCardRequestUpdateOptions,
      userIdPrivateDataMap: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRobotInteractiveCardResponseBody extends $tea.Model {
  /**
   * @example
   * xxxxxx
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateRobotInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateRobotInteractiveCardResponseBody;
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
      body: UpdateRobotInteractiveCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTheGroupRolesOfGroupMemberHeaders extends $tea.Model {
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

export class UpdateTheGroupRolesOfGroupMemberRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXXXXXX
   */
  openConversationId?: string;
  openRoleIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openRoleIds: 'openRoleIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openRoleIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTheGroupRolesOfGroupMemberResponseBody extends $tea.Model {
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

export class UpdateTheGroupRolesOfGroupMemberResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateTheGroupRolesOfGroupMemberResponseBody;
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
      body: UpdateTheGroupRolesOfGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUnfurlingRegisterHeaders extends $tea.Model {
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

export class UpdateUnfurlingRegisterRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123xxxx
   */
  apiSecret?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://xxx.xxx.com/api/dingtalk/link_unfurling
   */
  callbackUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * d7b9xxx-xxx-xxxx-xxxx-xxxxxxx.schema
   */
  cardTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * www.dingtalk.com
   */
  domain?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * /a
   */
  path?: string;
  /**
   * @example
   * 规则描述
   */
  ruleDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  ruleMatchType?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 37xxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      apiSecret: 'apiSecret',
      appId: 'appId',
      callbackUrl: 'callbackUrl',
      cardTemplateId: 'cardTemplateId',
      domain: 'domain',
      id: 'id',
      path: 'path',
      ruleDesc: 'ruleDesc',
      ruleMatchType: 'ruleMatchType',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiSecret: 'string',
      appId: 'string',
      callbackUrl: 'string',
      cardTemplateId: 'string',
      domain: 'string',
      id: 'number',
      path: 'string',
      ruleDesc: 'string',
      ruleMatchType: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUnfurlingRegisterResponseBody extends $tea.Model {
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

export class UpdateUnfurlingRegisterResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateUnfurlingRegisterResponseBody;
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
      body: UpdateUnfurlingRegisterResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUnfurlingRegisterStatusHeaders extends $tea.Model {
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

export class UpdateUnfurlingRegisterStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3102xxxxxxx
   */
  appId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  id?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  status?: number;
  /**
   * @example
   * 37xxxxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      id: 'id',
      status: 'status',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      id: 'number',
      status: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateUnfurlingRegisterStatusResponseBody extends $tea.Model {
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

export class UpdateUnfurlingRegisterStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateUnfurlingRegisterStatusResponseBody;
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
      body: UpdateUnfurlingRegisterStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMemberHeaders extends $tea.Model {
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

export class AddGroupMemberRequest extends $tea.Model {
  appUserIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8777
   */
  operatorId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      openConversationId: 'openConversationId',
      operatorId: 'operatorId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      openConversationId: 'string',
      operatorId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMemberResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appUserIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMemberResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddGroupMemberResponseBody;
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
      body: AddGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveGroupMemberHeaders extends $tea.Model {
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

export class RemoveGroupMemberRequest extends $tea.Model {
  appUserIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8777
   */
  operatorId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      openConversationId: 'openConversationId',
      operatorId: 'operatorId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      openConversationId: 'string',
      operatorId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveGroupMemberResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 移除成功
   */
  message?: string;
  static names(): { [key: string]: string } {
    return {
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveGroupMemberResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveGroupMemberResponseBody;
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
      body: RemoveGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingMessageHeaders extends $tea.Model {
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

export class SendDingMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  code?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"msg_type":"text","text":"hello world"}
   */
  message?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  messageType?: string;
  openConversationId?: string;
  /**
   * @example
   * 1107****2120
   */
  receiverId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8777
   */
  senderId?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      message: 'message',
      messageType: 'messageType',
      openConversationId: 'openConversationId',
      receiverId: 'receiverId',
      senderId: 'senderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      message: 'string',
      messageType: 'string',
      openConversationId: 'string',
      receiverId: 'string',
      senderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingMessageResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
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

export class SendDingMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendDingMessageResponseBody;
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
      body: SendDingMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageHeaders extends $tea.Model {
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

export class SendMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"msg_type":"text","text":"hello world"}
   */
  message?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * text
   */
  messageType?: string;
  openConversationId?: string;
  /**
   * @example
   * 1745****8777
   */
  receiverId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  senderId?: string;
  /**
   * @example
   * {     "9d801647a64******59c9da0207":"[{\"action_url\":\"http://www.baidu.com\",\"title\":\"一个按钮\"},{\"action_url\":\"http://www.baidu.com\",\"title\":\"两个按钮\"}]",     "9d801647a6******59c9da020342":"[{\"action_url\":\"http://www.baidu.com\",\"title\":\"一个按钮\"},{\"action_url\":\"http://www.baidu.com\",\"title\":\"两个按钮\"}]" }
   */
  sourceInfos?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      message: 'message',
      messageType: 'messageType',
      openConversationId: 'openConversationId',
      receiverId: 'receiverId',
      senderId: 'senderId',
      sourceInfos: 'sourceInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      message: 'string',
      messageType: 'string',
      openConversationId: 'string',
      receiverId: 'string',
      senderId: 'string',
      sourceInfos: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
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

export class SendMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendMessageResponseBody;
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
      body: SendMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOrgTextEmotionResponseBodyResult extends $tea.Model {
  /**
   * @example
   * corp_123456
   */
  emotionId?: string;
  static names(): { [key: string]: string } {
    return {
      emotionId: 'emotionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      emotionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels extends $tea.Model {
  /**
   * @example
   * aa.png
   */
  fileName?: string;
  /**
   * @example
   * png
   */
  fileType?: string;
  /**
   * @example
   * @12xxx34
   */
  mediaId?: string;
  /**
   * @example
   * 1234
   */
  size?: string;
  /**
   * @example
   * https://wukong-xxxx
   */
  url?: string;
  /**
   * @example
   * @12xx34
   */
  videoPicMediaId?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileType: 'fileType',
      mediaId: 'mediaId',
      size: 'size',
      url: 'url',
      videoPicMediaId: 'videoPicMediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      fileType: 'string',
      mediaId: 'string',
      size: 'string',
      url: 'string',
      videoPicMediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryFamilySchoolMessageResponseBodyMessages extends $tea.Model {
  contentType?: number;
  createAt?: number;
  mediaModels?: BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels[];
  /**
   * @example
   * msgxxx
   */
  openMsgId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createAt: 'createAt',
      mediaModels: 'mediaModels',
      openMsgId: 'openMsgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'number',
      createAt: 'number',
      mediaModels: { 'type': 'array', 'itemType': BatchQueryFamilySchoolMessageResponseBodyMessagesMediaModels },
      openMsgId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountOpenMsgSceneGroupsResponseBodyResult extends $tea.Model {
  count?: number;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInterconnectionRequestInterconnections extends $tea.Model {
  /**
   * @example
   * http://***.png
   */
  appUserAvatar?: string;
  /**
   * @example
   * 1
   */
  appUserAvatarMediaType?: number;
  /**
   * @example
   * 认真工作,快乐生活
   */
  appUserDynamics?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  appUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 188****8655
   */
  appUserMobile?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Foo
   */
  appUserName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  channelCode?: string;
  /**
   * @example
   * 1745****8777
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserAvatar: 'appUserAvatar',
      appUserAvatarMediaType: 'appUserAvatarMediaType',
      appUserDynamics: 'appUserDynamics',
      appUserId: 'appUserId',
      appUserMobile: 'appUserMobile',
      appUserName: 'appUserName',
      channelCode: 'channelCode',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserAvatar: 'string',
      appUserAvatarMediaType: 'number',
      appUserDynamics: 'string',
      appUserId: 'string',
      appUserMobile: 'string',
      appUserName: 'string',
      channelCode: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInterconnectionResponseBodyResults extends $tea.Model {
  appUserId?: string;
  message?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      message: 'message',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      message: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSceneGroupConversationRequestManagementOptions extends $tea.Model {
  chatBannedType?: number;
  managementType?: number;
  mentionAllAuthority?: number;
  searchable?: number;
  showHistoryType?: number;
  validationType?: number;
  static names(): { [key: string]: string } {
    return {
      chatBannedType: 'chatBannedType',
      managementType: 'managementType',
      mentionAllAuthority: 'mentionAllAuthority',
      searchable: 'searchable',
      showHistoryType: 'showHistoryType',
      validationType: 'validationType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatBannedType: 'number',
      managementType: 'number',
      mentionAllAuthority: 'number',
      searchable: 'number',
      showHistoryType: 'number',
      validationType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels extends $tea.Model {
  /**
   * @example
   * aa.png
   */
  fileName?: string;
  /**
   * @example
   * png
   */
  fileType?: string;
  /**
   * @example
   * @12xxx34
   */
  mediaId?: string;
  /**
   * @example
   * 1234
   */
  size?: string;
  /**
   * @example
   * https://wukong-xxxx
   */
  url?: string;
  /**
   * @example
   * @12xx34
   */
  videoPicMediaId?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileType: 'fileType',
      mediaId: 'mediaId',
      size: 'size',
      url: 'url',
      videoPicMediaId: 'videoPicMediaId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      fileType: 'string',
      mediaId: 'string',
      size: 'string',
      url: 'string',
      videoPicMediaId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationMsgResponseBodyMessages extends $tea.Model {
  contentType?: number;
  createAt?: number;
  mediaModels?: GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels[];
  /**
   * @example
   * msgxxx
   */
  openMsgId?: string;
  static names(): { [key: string]: string } {
    return {
      contentType: 'contentType',
      createAt: 'createAt',
      mediaModels: 'mediaModels',
      openMsgId: 'openMsgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentType: 'number',
      createAt: 'number',
      mediaModels: { 'type': 'array', 'itemType': GetFamilySchoolConversationMsgResponseBodyMessagesMediaModels },
      openMsgId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetFamilySchoolConversationsResponseBodyGroupInfoList extends $tea.Model {
  /**
   * @example
   * corp123
   */
  corpId?: string;
  deptNameChain?: string[];
  /**
   * @example
   * 小王的家校群
   */
  groupName?: string;
  /**
   * @example
   * 2
   */
  groupType?: string;
  joinGroupTime?: number;
  /**
   * @example
   * cidxxx
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      deptNameChain: 'deptNameChain',
      groupName: 'groupName',
      groupType: 'groupType',
      joinGroupTime: 'joinGroupTime',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      deptNameChain: { 'type': 'array', 'itemType': 'string' },
      groupName: 'string',
      groupType: 'string',
      joinGroupTime: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNewestInnerGroupsResponseBodyGroupInfos extends $tea.Model {
  /**
   * @example
   * @lADOADma*****QKA
   */
  icon?: string;
  /**
   * @example
   * 10
   */
  memberAmount?: string;
  /**
   * @example
   * cid1e*****==
   */
  openConversationId?: string;
  /**
   * @example
   * 测试群名称
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      memberAmount: 'memberAmount',
      openConversationId: 'openConversationId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      memberAmount: 'string',
      openConversationId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupManageQueryResponseBodyGroupInfoList extends $tea.Model {
  /**
   * @example
   * 0
   */
  banWordsMode?: number;
  /**
   * @example
   * 1000
   */
  capacity?: number;
  /**
   * @example
   * 1652183395772
   */
  createdAt?: number;
  extInfo?: { [key: string]: any };
  groupAdminList?: string[];
  /**
   * @example
   * 574892167781263748
   */
  groupOwner?: string;
  /**
   * @example
   * 今天吃肘子群
   */
  groupTitle?: string;
  /**
   * @example
   * 500
   */
  memberCount?: number;
  /**
   * @example
   * cidnvcxzklxv23jhkg412hj==
   */
  openConversationId?: string;
  /**
   * @example
   * INNER
   */
  type?: string;
  static names(): { [key: string]: string } {
    return {
      banWordsMode: 'banWordsMode',
      capacity: 'capacity',
      createdAt: 'createdAt',
      extInfo: 'extInfo',
      groupAdminList: 'groupAdminList',
      groupOwner: 'groupOwner',
      groupTitle: 'groupTitle',
      memberCount: 'memberCount',
      openConversationId: 'openConversationId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      banWordsMode: 'number',
      capacity: 'number',
      createdAt: 'number',
      extInfo: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      groupAdminList: { 'type': 'array', 'itemType': 'string' },
      groupOwner: 'string',
      groupTitle: 'string',
      memberCount: 'number',
      openConversationId: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InteractiveCardCreateInstanceRequestCardData extends $tea.Model {
  cardMediaIdParamMap?: { [key: string]: string };
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardMediaIdParamMap: 'cardMediaIdParamMap',
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrgTextEmotionResponseBodyResultEmotions extends $tea.Model {
  /**
   * @example
   * @234xxx
   */
  backgroundMediaId?: string;
  /**
   * @example
   * @123xxx
   */
  backgroundMediaIdForPanel?: string;
  /**
   * @example
   * -1
   */
  deptId?: number;
  /**
   * @example
   * corp_131xxx
   */
  emotionId?: string;
  /**
   * @example
   * 企业表情1
   */
  emotionName?: string;
  /**
   * @example
   * 1
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      backgroundMediaId: 'backgroundMediaId',
      backgroundMediaIdForPanel: 'backgroundMediaIdForPanel',
      deptId: 'deptId',
      emotionId: 'emotionId',
      emotionName: 'emotionName',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      backgroundMediaId: 'string',
      backgroundMediaIdForPanel: 'string',
      deptId: 'number',
      emotionId: 'string',
      emotionName: 'string',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListOrgTextEmotionResponseBodyResult extends $tea.Model {
  emotions?: ListOrgTextEmotionResponseBodyResultEmotions[];
  static names(): { [key: string]: string } {
    return {
      emotions: 'emotions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      emotions: { 'type': 'array', 'itemType': ListOrgTextEmotionResponseBodyResultEmotions },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleAddResponseBodyResult extends $tea.Model {
  openRoleId?: string;
  static names(): { [key: string]: string } {
    return {
      openRoleId: 'openRoleId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openRoleId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleQueryResponseBodyResultGroupRoles extends $tea.Model {
  openRoleId?: string;
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      openRoleId: 'openRoleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openRoleId: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupRoleQueryResponseBodyResult extends $tea.Model {
  groupRoles?: OpenGroupRoleQueryResponseBodyResultGroupRoles[];
  static names(): { [key: string]: string } {
    return {
      groupRoles: 'groupRoles',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupRoles: { 'type': 'array', 'itemType': OpenGroupRoleQueryResponseBodyResultGroupRoles },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupUserRoleQueryResponseBodyResultGroupRoles extends $tea.Model {
  /**
   * @example
   * rolexxxxxxx
   */
  openRoleId?: string;
  /**
   * @example
   * 小美
   */
  roleName?: string;
  static names(): { [key: string]: string } {
    return {
      openRoleId: 'openRoleId',
      roleName: 'roleName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openRoleId: 'string',
      roleName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenGroupUserRoleQueryResponseBodyResult extends $tea.Model {
  groupRoles?: OpenGroupUserRoleQueryResponseBodyResultGroupRoles[];
  static names(): { [key: string]: string } {
    return {
      groupRoles: 'groupRoles',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupRoles: { 'type': 'array', 'itemType': OpenGroupUserRoleQueryResponseBodyResultGroupRoles },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenSearchGroupListResponseBodyResultGroupList extends $tea.Model {
  icon?: string;
  memberCount?: number;
  openConversationId?: string;
  tag?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      memberCount: 'memberCount',
      openConversationId: 'openConversationId',
      tag: 'tag',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      memberCount: 'number',
      openConversationId: 'string',
      tag: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenSearchGroupListResponseBodyResult extends $tea.Model {
  groupList?: OpenSearchGroupListResponseBodyResultGroupList[];
  static names(): { [key: string]: string } {
    return {
      groupList: 'groupList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupList: { 'type': 'array', 'itemType': OpenSearchGroupListResponseBodyResultGroupList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserSendCardMessageRequestCardContent extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  lastMessage?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  outTrackId?: string;
  static names(): { [key: string]: string } {
    return {
      lastMessage: 'lastMessage',
      outTrackId: 'outTrackId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessage: 'string',
      outTrackId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OpenUserSendCardMessageResponseBodyResult extends $tea.Model {
  openTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      openTaskId: 'openTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PersonalSendCardMessageRequestCardContent extends $tea.Model {
  lastMessage?: string;
  outTrackId?: string;
  static names(): { [key: string]: string } {
    return {
      lastMessage: 'lastMessage',
      outTrackId: 'outTrackId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      lastMessage: 'string',
      outTrackId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PersonalSendCardMessageResponseBodyResult extends $tea.Model {
  openTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      openTaskId: 'openTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberResponseBodyGroupMembers extends $tea.Model {
  /**
   * @example
   * http://****.png
   */
  groupMemberAvatar?: string;
  /**
   * @example
   * 认真工作,快乐生活
   */
  groupMemberDynamics?: string;
  /**
   * @example
   * 1107****2120
   */
  groupMemberId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Foo
   */
  groupMemberName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  groupMemberType?: number;
  static names(): { [key: string]: string } {
    return {
      groupMemberAvatar: 'groupMemberAvatar',
      groupMemberDynamics: 'groupMemberDynamics',
      groupMemberId: 'groupMemberId',
      groupMemberName: 'groupMemberName',
      groupMemberType: 'groupMemberType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMemberAvatar: 'string',
      groupMemberDynamics: 'string',
      groupMemberId: 'string',
      groupMemberName: 'string',
      groupMemberType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberByMemberAuthResponseBodyGroupMemberList extends $tea.Model {
  /**
   * @example
   * 张三
   */
  groupNickName?: string;
  /**
   * @example
   * 张某某
   */
  orgName?: string;
  /**
   * @example
   * https://xxx
   */
  profilePhotoUrl?: string;
  /**
   * @example
   * xxx
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      groupNickName: 'groupNickName',
      orgName: 'orgName',
      profilePhotoUrl: 'profilePhotoUrl',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNickName: 'string',
      orgName: 'string',
      profilePhotoUrl: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMuteStatusResponseBodyUserMuteResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1645315682000
   */
  muteEndTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1645315682000
   */
  muteStartTime?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  userMuteMode?: boolean;
  static names(): { [key: string]: string } {
    return {
      muteEndTime: 'muteEndTime',
      muteStartTime: 'muteStartTime',
      userMuteMode: 'userMuteMode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      muteEndTime: 'number',
      muteStartTime: 'number',
      userMuteMode: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInnerGroupMemberListResponseBodyList extends $tea.Model {
  icon?: string;
  name?: string;
  nickName?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      name: 'name',
      nickName: 'nickName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      name: 'string',
      nickName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInnerGroupRecentListResponseBodyGroupInfos extends $tea.Model {
  /**
   * @example
   * https://static.xxxxxxx
   */
  icon?: string;
  /**
   * @example
   * 10
   */
  memberAmount?: string;
  /**
   * @example
   * cid1e*****==
   */
  openConversationId?: string;
  /**
   * @example
   * 测试群名称
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      memberAmount: 'memberAmount',
      openConversationId: 'openConversationId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      memberAmount: 'string',
      openConversationId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMessageSendResultResponseBodyResult extends $tea.Model {
  /**
   * @example
   * msghcuh234
   */
  openMessageId?: string;
  /**
   * @example
   * 1
   */
  sendStatus?: number;
  static names(): { [key: string]: string } {
    return {
      openMessageId: 'openMessageId',
      sendStatus: 'sendStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openMessageId: 'string',
      sendStatus: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenConversationReceiveUserResponseBodyResultReceiveUser extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  nickName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      name: 'name',
      nickName: 'nickName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      name: 'string',
      nickName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenConversationReceiveUserResponseBodyResult extends $tea.Model {
  receiveUser?: QueryOpenConversationReceiveUserResponseBodyResultReceiveUser;
  static names(): { [key: string]: string } {
    return {
      receiveUser: 'receiveUser',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receiveUser: QueryOpenConversationReceiveUserResponseBodyResultReceiveUser,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOpenGroupBaseInfoResponseBodyResult extends $tea.Model {
  icon?: string;
  memberCount?: number;
  openConversationId?: string;
  tag?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      memberCount: 'memberCount',
      openConversationId: 'openConversationId',
      tag: 'tag',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      memberCount: 'number',
      openConversationId: 'string',
      tag: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList extends $tea.Model {
  readStatus?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      readStatus: 'readStatus',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readStatus: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPersonalMessageReadStatusResponseBodyResult extends $tea.Model {
  messageReadInfoList?: QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList[];
  static names(): { [key: string]: string } {
    return {
      messageReadInfoList: 'messageReadInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageReadInfoList: { 'type': 'array', 'itemType': QueryPersonalMessageReadStatusResponseBodyResultMessageReadInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentConversationsResponseBodyResultConversationList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  conversationType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  icon?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  memberCount?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  nickName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationType: 'conversationType',
      icon: 'icon',
      memberCount: 'memberCount',
      name: 'name',
      nickName: 'nickName',
      openConversationId: 'openConversationId',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationType: 'number',
      icon: 'string',
      memberCount: 'string',
      name: 'string',
      nickName: 'string',
      openConversationId: 'string',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRecentConversationsResponseBodyResult extends $tea.Model {
  conversationList?: QueryRecentConversationsResponseBodyResultConversationList[];
  static names(): { [key: string]: string } {
    return {
      conversationList: 'conversationList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationList: { 'type': 'array', 'itemType': QueryRecentConversationsResponseBodyResultConversationList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySceneGroupTemplateRobotResponseBodyResult extends $tea.Model {
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleGroupRequestGroupMembers extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  appUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8778
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySingleGroupResponseBodyOpenConversations extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1107****2120
   */
  appUserId?: string;
  /**
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1745****8778
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnReadMessageResponseBodyUnReadItems extends $tea.Model {
  /**
   * @example
   * 14da****2760
   */
  openConversationId?: string;
  /**
   * @example
   * 10
   */
  unReadCount?: number;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      unReadCount: 'unReadCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      unReadCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterCreatorResponseBodyData extends $tea.Model {
  appId?: string;
  creatorUserId?: string;
  id?: number;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      creatorUserId: 'creatorUserId',
      id: 'id',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'string',
      creatorUserId: 'string',
      id: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUnfurlingRegisterInfoResponseBodyList extends $tea.Model {
  apiSecret?: string;
  appId?: string;
  appName?: string;
  callbackType?: number;
  callbackUrl?: string;
  cardTemplateId?: string;
  creatorUserId?: string;
  domain?: string;
  grayGroupIdList?: string[];
  grayUserIdList?: string[];
  hsfMethodName?: string;
  hsfServiceName?: string;
  hsfVersion?: string;
  id?: number;
  path?: string;
  ruleDesc?: string;
  ruleMatchType?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      apiSecret: 'apiSecret',
      appId: 'appId',
      appName: 'appName',
      callbackType: 'callbackType',
      callbackUrl: 'callbackUrl',
      cardTemplateId: 'cardTemplateId',
      creatorUserId: 'creatorUserId',
      domain: 'domain',
      grayGroupIdList: 'grayGroupIdList',
      grayUserIdList: 'grayUserIdList',
      hsfMethodName: 'hsfMethodName',
      hsfServiceName: 'hsfServiceName',
      hsfVersion: 'hsfVersion',
      id: 'id',
      path: 'path',
      ruleDesc: 'ruleDesc',
      ruleMatchType: 'ruleMatchType',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      apiSecret: 'string',
      appId: 'string',
      appName: 'string',
      callbackType: 'number',
      callbackUrl: 'string',
      cardTemplateId: 'string',
      creatorUserId: 'string',
      domain: 'string',
      grayGroupIdList: { 'type': 'array', 'itemType': 'string' },
      grayUserIdList: { 'type': 'array', 'itemType': 'string' },
      hsfMethodName: 'string',
      hsfServiceName: 'string',
      hsfVersion: 'string',
      id: 'number',
      path: 'string',
      ruleDesc: 'string',
      ruleMatchType: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchInnerGroupsResponseBodyGroupInfos extends $tea.Model {
  /**
   * @example
   * @lAD*****
   */
  icon?: string;
  /**
   * @example
   * 10
   */
  memberAmount?: string;
  /**
   * @example
   * cid13*****==
   */
  openConversationId?: string;
  /**
   * @example
   * 测试群名称
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      memberAmount: 'memberAmount',
      openConversationId: 'openConversationId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      memberAmount: 'string',
      openConversationId: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardRequestCardData extends $tea.Model {
  cardMediaIdParamMap?: { [key: string]: string };
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardMediaIdParamMap: 'cardMediaIdParamMap',
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardRequestCardOptions extends $tea.Model {
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxx
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOTOInteractiveCardRequestCardData extends $tea.Model {
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOTOInteractiveCardRequestCardOptions extends $tea.Model {
  supportForward?: boolean;
  static names(): { [key: string]: string } {
    return {
      supportForward: 'supportForward',
    };
  }

  static types(): { [key: string]: any } {
    return {
      supportForward: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendOTOInteractiveCardResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxxxxx
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendPersonalMessageResponseBodyResult extends $tea.Model {
  openTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      openTaskId: 'openTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotInteractiveCardRequestSendOptions extends $tea.Model {
  /**
   * @example
   * true
   */
  atAll?: boolean;
  /**
   * @example
   * [{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
   */
  atUserListJson?: string;
  /**
   * @example
   * {}
   */
  cardPropertyJson?: string;
  /**
   * @example
   * [{"userId":"userId0001"},{"unionId":"unionId001"}]
   */
  receiverListJson?: string;
  static names(): { [key: string]: string } {
    return {
      atAll: 'atAll',
      atUserListJson: 'atUserListJson',
      cardPropertyJson: 'cardPropertyJson',
      receiverListJson: 'receiverListJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAll: 'boolean',
      atUserListJson: 'string',
      cardPropertyJson: 'string',
      receiverListJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendTemplateInteractiveCardRequestSendOptions extends $tea.Model {
  /**
   * @example
   * true
   */
  atAll?: boolean;
  /**
   * @example
   * [{"nickName":"张三","userId":"userId0001"},{"nickName":"李四","unionId":"unionId001"}]
   */
  atUserListJson?: string;
  /**
   * @example
   * {}
   */
  cardPropertyJson?: string;
  /**
   * @example
   * [{"userId":"userId0001"},{"unionId":"unionId001"}]
   */
  receiverListJson?: string;
  static names(): { [key: string]: string } {
    return {
      atAll: 'atAll',
      atUserListJson: 'atUserListJson',
      cardPropertyJson: 'cardPropertyJson',
      receiverListJson: 'receiverListJson',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAll: 'boolean',
      atUserListJson: 'string',
      cardPropertyJson: 'string',
      receiverListJson: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRightPanelRequestWebWndParams extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://www.dingtalk.com/
   */
  targetURL?: string;
  static names(): { [key: string]: string } {
    return {
      targetURL: 'targetURL',
    };
  }

  static types(): { [key: string]: any } {
    return {
      targetURL: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardRequestCardData extends $tea.Model {
  cardMediaIdParamMap?: { [key: string]: string };
  cardParamMap?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      cardMediaIdParamMap: 'cardMediaIdParamMap',
      cardParamMap: 'cardParamMap',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      cardParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardRequestCardOptions extends $tea.Model {
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

export class UpdateRobotInteractiveCardRequestUpdateOptions extends $tea.Model {
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
   * 添加企业文字表情
   * 
   * @param request - AddOrgTextEmotionRequest
   * @param headers - AddOrgTextEmotionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddOrgTextEmotionResponse
   */
  async addOrgTextEmotionWithOptions(request: AddOrgTextEmotionRequest, headers: AddOrgTextEmotionHeaders, runtime: $Util.RuntimeOptions): Promise<AddOrgTextEmotionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.backgroundMediaId)) {
      body["backgroundMediaId"] = request.backgroundMediaId;
    }

    if (!Util.isUnset(request.backgroundMediaIdForPanel)) {
      body["backgroundMediaIdForPanel"] = request.backgroundMediaIdForPanel;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.emotionName)) {
      body["emotionName"] = request.emotionName;
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
      action: "AddOrgTextEmotion",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/organizations/textEmotions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddOrgTextEmotionResponse>(await this.execute(params, req, runtime), new AddOrgTextEmotionResponse({}));
  }

  /**
   * 添加企业文字表情
   * 
   * @param request - AddOrgTextEmotionRequest
   * @returns AddOrgTextEmotionResponse
   */
  async addOrgTextEmotion(request: AddOrgTextEmotionRequest): Promise<AddOrgTextEmotionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOrgTextEmotionHeaders({ });
    return await this.addOrgTextEmotionWithOptions(request, headers, runtime);
  }

  /**
   * 添加机器人到会话
   * 
   * @param request - AddRobotToConversationRequest
   * @param headers - AddRobotToConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddRobotToConversationResponse
   */
  async addRobotToConversationWithOptions(request: AddRobotToConversationRequest, headers: AddRobotToConversationHeaders, runtime: $Util.RuntimeOptions): Promise<AddRobotToConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "AddRobotToConversation",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/conversations/robots`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddRobotToConversationResponse>(await this.execute(params, req, runtime), new AddRobotToConversationResponse({}));
  }

  /**
   * 添加机器人到会话
   * 
   * @param request - AddRobotToConversationRequest
   * @returns AddRobotToConversationResponse
   */
  async addRobotToConversation(request: AddRobotToConversationRequest): Promise<AddRobotToConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRobotToConversationHeaders({ });
    return await this.addRobotToConversationWithOptions(request, headers, runtime);
  }

  /**
   * 新增链接增强注册规则
   * 
   * @param request - AddUnfurlingRegisterRequest
   * @param headers - AddUnfurlingRegisterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddUnfurlingRegisterResponse
   */
  async addUnfurlingRegisterWithOptions(request: AddUnfurlingRegisterRequest, headers: AddUnfurlingRegisterHeaders, runtime: $Util.RuntimeOptions): Promise<AddUnfurlingRegisterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.apiSecret)) {
      body["apiSecret"] = request.apiSecret;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.callbackUrl)) {
      body["callbackUrl"] = request.callbackUrl;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.domain)) {
      body["domain"] = request.domain;
    }

    if (!Util.isUnset(request.path)) {
      body["path"] = request.path;
    }

    if (!Util.isUnset(request.ruleDesc)) {
      body["ruleDesc"] = request.ruleDesc;
    }

    if (!Util.isUnset(request.ruleMatchType)) {
      body["ruleMatchType"] = request.ruleMatchType;
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
      action: "AddUnfurlingRegister",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddUnfurlingRegisterResponse>(await this.execute(params, req, runtime), new AddUnfurlingRegisterResponse({}));
  }

  /**
   * 新增链接增强注册规则
   * 
   * @param request - AddUnfurlingRegisterRequest
   * @returns AddUnfurlingRegisterResponse
   */
  async addUnfurlingRegister(request: AddUnfurlingRegisterRequest): Promise<AddUnfurlingRegisterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddUnfurlingRegisterHeaders({ });
    return await this.addUnfurlingRegisterWithOptions(request, headers, runtime);
  }

  /**
   * 自动开通钉钉客联微应用
   * 
   * @param headers - AutoOpenDingTalkConnectHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AutoOpenDingTalkConnectResponse
   */
  async autoOpenDingTalkConnectWithOptions(headers: AutoOpenDingTalkConnectHeaders, runtime: $Util.RuntimeOptions): Promise<AutoOpenDingTalkConnectResponse> {
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
      action: "AutoOpenDingTalkConnect",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/apps/open`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AutoOpenDingTalkConnectResponse>(await this.execute(params, req, runtime), new AutoOpenDingTalkConnectResponse({}));
  }

  /**
   * 自动开通钉钉客联微应用
   * @returns AutoOpenDingTalkConnectResponse
   */
  async autoOpenDingTalkConnect(): Promise<AutoOpenDingTalkConnectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AutoOpenDingTalkConnectHeaders({ });
    return await this.autoOpenDingTalkConnectWithOptions(headers, runtime);
  }

  /**
   * 批量查询家校群消息详情
   * 
   * @param request - BatchQueryFamilySchoolMessageRequest
   * @param headers - BatchQueryFamilySchoolMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQueryFamilySchoolMessageResponse
   */
  async batchQueryFamilySchoolMessageWithOptions(request: BatchQueryFamilySchoolMessageRequest, headers: BatchQueryFamilySchoolMessageHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryFamilySchoolMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openMessageIds)) {
      body["openMessageIds"] = request.openMessageIds;
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
      action: "BatchQueryFamilySchoolMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/conversations/familySchools/messages/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQueryFamilySchoolMessageResponse>(await this.execute(params, req, runtime), new BatchQueryFamilySchoolMessageResponse({}));
  }

  /**
   * 批量查询家校群消息详情
   * 
   * @param request - BatchQueryFamilySchoolMessageRequest
   * @returns BatchQueryFamilySchoolMessageResponse
   */
  async batchQueryFamilySchoolMessage(request: BatchQueryFamilySchoolMessageRequest): Promise<BatchQueryFamilySchoolMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryFamilySchoolMessageHeaders({ });
    return await this.batchQueryFamilySchoolMessageWithOptions(request, headers, runtime);
  }

  /**
   * 查询群成员
   * 
   * @param request - BatchQueryGroupMemberRequest
   * @param headers - BatchQueryGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQueryGroupMemberResponse
   */
  async batchQueryGroupMemberWithOptions(request: BatchQueryGroupMemberRequest, headers: BatchQueryGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryGroupMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "BatchQueryGroupMember",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/members/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQueryGroupMemberResponse>(await this.execute(params, req, runtime), new BatchQueryGroupMemberResponse({}));
  }

  /**
   * 查询群成员
   * 
   * @param request - BatchQueryGroupMemberRequest
   * @returns BatchQueryGroupMemberResponse
   */
  async batchQueryGroupMember(request: BatchQueryGroupMemberRequest): Promise<BatchQueryGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryGroupMemberHeaders({ });
    return await this.batchQueryGroupMemberWithOptions(request, headers, runtime);
  }

  /**
   * 钉钉互动卡片模板构建动作
   * 
   * @param request - CardTemplateBuildActionRequest
   * @param headers - CardTemplateBuildActionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CardTemplateBuildActionResponse
   */
  async cardTemplateBuildActionWithOptions(request: CardTemplateBuildActionRequest, headers: CardTemplateBuildActionHeaders, runtime: $Util.RuntimeOptions): Promise<CardTemplateBuildActionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      body["action"] = request.action;
    }

    if (!Util.isUnset(request.cardTemplateJson)) {
      body["cardTemplateJson"] = request.cardTemplateJson;
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
      action: "CardTemplateBuildAction",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interactiveCards/templates/buildAction`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CardTemplateBuildActionResponse>(await this.execute(params, req, runtime), new CardTemplateBuildActionResponse({}));
  }

  /**
   * 钉钉互动卡片模板构建动作
   * 
   * @param request - CardTemplateBuildActionRequest
   * @returns CardTemplateBuildActionResponse
   */
  async cardTemplateBuildAction(request: CardTemplateBuildActionRequest): Promise<CardTemplateBuildActionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardTemplateBuildActionHeaders({ });
    return await this.cardTemplateBuildActionWithOptions(request, headers, runtime);
  }

  /**
   * 更换群主
   * 
   * @param request - ChangeGroupOwnerRequest
   * @param headers - ChangeGroupOwnerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ChangeGroupOwnerResponse
   */
  async changeGroupOwnerWithOptions(request: ChangeGroupOwnerRequest, headers: ChangeGroupOwnerHeaders, runtime: $Util.RuntimeOptions): Promise<ChangeGroupOwnerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupOwnerId)) {
      body["groupOwnerId"] = request.groupOwnerId;
    }

    if (!Util.isUnset(request.groupOwnerType)) {
      body["groupOwnerType"] = request.groupOwnerType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "ChangeGroupOwner",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/groups/owners`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ChangeGroupOwnerResponse>(await this.execute(params, req, runtime), new ChangeGroupOwnerResponse({}));
  }

  /**
   * 更换群主
   * 
   * @param request - ChangeGroupOwnerRequest
   * @returns ChangeGroupOwnerResponse
   */
  async changeGroupOwner(request: ChangeGroupOwnerRequest): Promise<ChangeGroupOwnerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChangeGroupOwnerHeaders({ });
    return await this.changeGroupOwnerWithOptions(request, headers, runtime);
  }

  /**
   * 会话开放的ChatId转OpenConversationId
   * 
   * @param headers - ChatIdToOpenConversationIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ChatIdToOpenConversationIdResponse
   */
  async chatIdToOpenConversationIdWithOptions(chatId: string, headers: ChatIdToOpenConversationIdHeaders, runtime: $Util.RuntimeOptions): Promise<ChatIdToOpenConversationIdResponse> {
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
      action: "ChatIdToOpenConversationId",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/chat/${chatId}/convertToOpenConversationId`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ChatIdToOpenConversationIdResponse>(await this.execute(params, req, runtime), new ChatIdToOpenConversationIdResponse({}));
  }

  /**
   * 会话开放的ChatId转OpenConversationId
   * @returns ChatIdToOpenConversationIdResponse
   */
  async chatIdToOpenConversationId(chatId: string): Promise<ChatIdToOpenConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChatIdToOpenConversationIdHeaders({ });
    return await this.chatIdToOpenConversationIdWithOptions(chatId, headers, runtime);
  }

  /**
   * 设置群管理员
   * 
   * @param request - ChatSubAdminUpdateRequest
   * @param headers - ChatSubAdminUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ChatSubAdminUpdateResponse
   */
  async chatSubAdminUpdateWithOptions(request: ChatSubAdminUpdateRequest, headers: ChatSubAdminUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<ChatSubAdminUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "ChatSubAdminUpdate",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/subAdministrators`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ChatSubAdminUpdateResponse>(await this.execute(params, req, runtime), new ChatSubAdminUpdateResponse({}));
  }

  /**
   * 设置群管理员
   * 
   * @param request - ChatSubAdminUpdateRequest
   * @returns ChatSubAdminUpdateResponse
   */
  async chatSubAdminUpdate(request: ChatSubAdminUpdateRequest): Promise<ChatSubAdminUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChatSubAdminUpdateHeaders({ });
    return await this.chatSubAdminUpdateWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户是否为企业内部群成员
   * 
   * @param request - CheckUserIsGroupMemberRequest
   * @param headers - CheckUserIsGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckUserIsGroupMemberResponse
   */
  async checkUserIsGroupMemberWithOptions(request: CheckUserIsGroupMemberRequest, headers: CheckUserIsGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<CheckUserIsGroupMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "CheckUserIsGroupMember",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/innerGroups/members/check`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CheckUserIsGroupMemberResponse>(await this.execute(params, req, runtime), new CheckUserIsGroupMemberResponse({}));
  }

  /**
   * 查询用户是否为企业内部群成员
   * 
   * @param request - CheckUserIsGroupMemberRequest
   * @returns CheckUserIsGroupMemberResponse
   */
  async checkUserIsGroupMember(request: CheckUserIsGroupMemberRequest): Promise<CheckUserIsGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckUserIsGroupMemberHeaders({ });
    return await this.checkUserIsGroupMemberWithOptions(request, headers, runtime);
  }

  /**
   * 链接增强规则拷贝
   * 
   * @param request - CopyUnfurlingRegisterRequest
   * @param headers - CopyUnfurlingRegisterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CopyUnfurlingRegisterResponse
   */
  async copyUnfurlingRegisterWithOptions(request: CopyUnfurlingRegisterRequest, headers: CopyUnfurlingRegisterHeaders, runtime: $Util.RuntimeOptions): Promise<CopyUnfurlingRegisterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
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
      action: "CopyUnfurlingRegister",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules/copy`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CopyUnfurlingRegisterResponse>(await this.execute(params, req, runtime), new CopyUnfurlingRegisterResponse({}));
  }

  /**
   * 链接增强规则拷贝
   * 
   * @param request - CopyUnfurlingRegisterRequest
   * @returns CopyUnfurlingRegisterResponse
   */
  async copyUnfurlingRegister(request: CopyUnfurlingRegisterRequest): Promise<CopyUnfurlingRegisterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CopyUnfurlingRegisterHeaders({ });
    return await this.copyUnfurlingRegisterWithOptions(request, headers, runtime);
  }

  /**
   * 查询消息开放群模板下群计数
   * 
   * @param request - CountOpenMsgSceneGroupsRequest
   * @param headers - CountOpenMsgSceneGroupsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CountOpenMsgSceneGroupsResponse
   */
  async countOpenMsgSceneGroupsWithOptions(request: CountOpenMsgSceneGroupsRequest, headers: CountOpenMsgSceneGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<CountOpenMsgSceneGroupsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
      action: "CountOpenMsgSceneGroups",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/openMsgSceneGroups/templates/counts/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CountOpenMsgSceneGroupsResponse>(await this.execute(params, req, runtime), new CountOpenMsgSceneGroupsResponse({}));
  }

  /**
   * 查询消息开放群模板下群计数
   * 
   * @param request - CountOpenMsgSceneGroupsRequest
   * @returns CountOpenMsgSceneGroupsResponse
   */
  async countOpenMsgSceneGroups(request: CountOpenMsgSceneGroupsRequest): Promise<CountOpenMsgSceneGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CountOpenMsgSceneGroupsHeaders({ });
    return await this.countOpenMsgSceneGroupsWithOptions(request, headers, runtime);
  }

  /**
   * 创建钉外两人群
   * 
   * @param request - CreateCoupleGroupConversationRequest
   * @param headers - CreateCoupleGroupConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateCoupleGroupConversationResponse
   */
  async createCoupleGroupConversationWithOptions(request: CreateCoupleGroupConversationRequest, headers: CreateCoupleGroupConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCoupleGroupConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserId)) {
      body["appUserId"] = request.appUserId;
    }

    if (!Util.isUnset(request.groupAvatar)) {
      body["groupAvatar"] = request.groupAvatar;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.groupOwnerId)) {
      body["groupOwnerId"] = request.groupOwnerId;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
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
      action: "CreateCoupleGroupConversation",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/coupleGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateCoupleGroupConversationResponse>(await this.execute(params, req, runtime), new CreateCoupleGroupConversationResponse({}));
  }

  /**
   * 创建钉外两人群
   * 
   * @param request - CreateCoupleGroupConversationRequest
   * @returns CreateCoupleGroupConversationResponse
   */
  async createCoupleGroupConversation(request: CreateCoupleGroupConversationRequest): Promise<CreateCoupleGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCoupleGroupConversationHeaders({ });
    return await this.createCoupleGroupConversationWithOptions(request, headers, runtime);
  }

  /**
   * 创建互通群（支持普通互通群、跨钉两人群）
   * 
   * @param request - CreateGroupConversationRequest
   * @param headers - CreateGroupConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupConversationResponse
   */
  async createGroupConversationWithOptions(request: CreateGroupConversationRequest, headers: CreateGroupConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserIds)) {
      body["appUserIds"] = request.appUserIds;
    }

    if (!Util.isUnset(request.groupAvatar)) {
      body["groupAvatar"] = request.groupAvatar;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.groupOwnerId)) {
      body["groupOwnerId"] = request.groupOwnerId;
    }

    if (!Util.isUnset(request.groupOwnerType)) {
      body["groupOwnerType"] = request.groupOwnerType;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "CreateGroupConversation",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupConversationResponse>(await this.execute(params, req, runtime), new CreateGroupConversationResponse({}));
  }

  /**
   * 创建互通群（支持普通互通群、跨钉两人群）
   * 
   * @param request - CreateGroupConversationRequest
   * @returns CreateGroupConversationResponse
   */
  async createGroupConversation(request: CreateGroupConversationRequest): Promise<CreateGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupConversationHeaders({ });
    return await this.createGroupConversationWithOptions(request, headers, runtime);
  }

  /**
   * 创建钉外账号
   * 
   * @param request - CreateInterconnectionRequest
   * @param headers - CreateInterconnectionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateInterconnectionResponse
   */
  async createInterconnectionWithOptions(request: CreateInterconnectionRequest, headers: CreateInterconnectionHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInterconnectionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.interconnections)) {
      body["interconnections"] = request.interconnections;
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
      action: "CreateInterconnection",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateInterconnectionResponse>(await this.execute(params, req, runtime), new CreateInterconnectionResponse({}));
  }

  /**
   * 创建钉外账号
   * 
   * @param request - CreateInterconnectionRequest
   * @returns CreateInterconnectionResponse
   */
  async createInterconnection(request: CreateInterconnectionRequest): Promise<CreateInterconnectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInterconnectionHeaders({ });
    return await this.createInterconnectionWithOptions(request, headers, runtime);
  }

  /**
   * 创建场景群会话
   * 
   * @param request - CreateSceneGroupConversationRequest
   * @param headers - CreateSceneGroupConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateSceneGroupConversationResponse
   */
  async createSceneGroupConversationWithOptions(request: CreateSceneGroupConversationRequest, headers: CreateSceneGroupConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSceneGroupConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.features)) {
      body["features"] = request.features;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.groupOwnerId)) {
      body["groupOwnerId"] = request.groupOwnerId;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.managementOptions)) {
      body["managementOptions"] = request.managementOptions;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
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
      action: "CreateSceneGroupConversation",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateSceneGroupConversationResponse>(await this.execute(params, req, runtime), new CreateSceneGroupConversationResponse({}));
  }

  /**
   * 创建场景群会话
   * 
   * @param request - CreateSceneGroupConversationRequest
   * @returns CreateSceneGroupConversationResponse
   */
  async createSceneGroupConversation(request: CreateSceneGroupConversationRequest): Promise<CreateSceneGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSceneGroupConversationHeaders({ });
    return await this.createSceneGroupConversationWithOptions(request, headers, runtime);
  }

  /**
   * 创建店铺群
   * 
   * @param request - CreateStoreGroupConversationRequest
   * @param headers - CreateStoreGroupConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateStoreGroupConversationResponse
   */
  async createStoreGroupConversationWithOptions(request: CreateStoreGroupConversationRequest, headers: CreateStoreGroupConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CreateStoreGroupConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserId)) {
      body["appUserId"] = request.appUserId;
    }

    if (!Util.isUnset(request.businessUniqueKey)) {
      body["businessUniqueKey"] = request.businessUniqueKey;
    }

    if (!Util.isUnset(request.groupAvatar)) {
      body["groupAvatar"] = request.groupAvatar;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "CreateStoreGroupConversation",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/storeGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateStoreGroupConversationResponse>(await this.execute(params, req, runtime), new CreateStoreGroupConversationResponse({}));
  }

  /**
   * 创建店铺群
   * 
   * @param request - CreateStoreGroupConversationRequest
   * @returns CreateStoreGroupConversationResponse
   */
  async createStoreGroupConversation(request: CreateStoreGroupConversationRequest): Promise<CreateStoreGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateStoreGroupConversationHeaders({ });
    return await this.createStoreGroupConversationWithOptions(request, headers, runtime);
  }

  /**
   * 链接增强规则调试
   * 
   * @param request - DebugUnfurlingRegisterRequest
   * @param headers - DebugUnfurlingRegisterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DebugUnfurlingRegisterResponse
   */
  async debugUnfurlingRegisterWithOptions(request: DebugUnfurlingRegisterRequest, headers: DebugUnfurlingRegisterHeaders, runtime: $Util.RuntimeOptions): Promise<DebugUnfurlingRegisterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.grayGroupIdList)) {
      body["grayGroupIdList"] = request.grayGroupIdList;
    }

    if (!Util.isUnset(request.grayUserIdList)) {
      body["grayUserIdList"] = request.grayUserIdList;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
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
      action: "DebugUnfurlingRegister",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules/debug`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DebugUnfurlingRegisterResponse>(await this.execute(params, req, runtime), new DebugUnfurlingRegisterResponse({}));
  }

  /**
   * 链接增强规则调试
   * 
   * @param request - DebugUnfurlingRegisterRequest
   * @returns DebugUnfurlingRegisterResponse
   */
  async debugUnfurlingRegister(request: DebugUnfurlingRegisterRequest): Promise<DebugUnfurlingRegisterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DebugUnfurlingRegisterHeaders({ });
    return await this.debugUnfurlingRegisterWithOptions(request, headers, runtime);
  }

  /**
   * 删除企业文字表情
   * 
   * @param request - DeleteOrgTextEmotionRequest
   * @param headers - DeleteOrgTextEmotionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteOrgTextEmotionResponse
   */
  async deleteOrgTextEmotionWithOptions(request: DeleteOrgTextEmotionRequest, headers: DeleteOrgTextEmotionHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteOrgTextEmotionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.emotionIds)) {
      body["emotionIds"] = request.emotionIds;
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
      action: "DeleteOrgTextEmotion",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/organizations/textEmotions/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteOrgTextEmotionResponse>(await this.execute(params, req, runtime), new DeleteOrgTextEmotionResponse({}));
  }

  /**
   * 删除企业文字表情
   * 
   * @param request - DeleteOrgTextEmotionRequest
   * @returns DeleteOrgTextEmotionResponse
   */
  async deleteOrgTextEmotion(request: DeleteOrgTextEmotionRequest): Promise<DeleteOrgTextEmotionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteOrgTextEmotionHeaders({ });
    return await this.deleteOrgTextEmotionWithOptions(request, headers, runtime);
  }

  /**
   * 解散互通群
   * 
   * @param request - DismissGroupConversationRequest
   * @param headers - DismissGroupConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DismissGroupConversationResponse
   */
  async dismissGroupConversationWithOptions(request: DismissGroupConversationRequest, headers: DismissGroupConversationHeaders, runtime: $Util.RuntimeOptions): Promise<DismissGroupConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "DismissGroupConversation",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/groups/dismiss`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DismissGroupConversationResponse>(await this.execute(params, req, runtime), new DismissGroupConversationResponse({}));
  }

  /**
   * 解散互通群
   * 
   * @param request - DismissGroupConversationRequest
   * @returns DismissGroupConversationResponse
   */
  async dismissGroupConversation(request: DismissGroupConversationRequest): Promise<DismissGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DismissGroupConversationHeaders({ });
    return await this.dismissGroupConversationWithOptions(request, headers, runtime);
  }

  /**
   * 创建ToB会话地址
   * 
   * @param request - GetConversationUrlRequest
   * @param headers - GetConversationUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConversationUrlResponse
   */
  async getConversationUrlWithOptions(request: GetConversationUrlRequest, headers: GetConversationUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserId)) {
      body["appUserId"] = request.appUserId;
    }

    if (!Util.isUnset(request.channelCode)) {
      body["channelCode"] = request.channelCode;
    }

    if (!Util.isUnset(request.deviceId)) {
      body["deviceId"] = request.deviceId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GetConversationUrl",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/conversations/urls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConversationUrlResponse>(await this.execute(params, req, runtime), new GetConversationUrlResponse({}));
  }

  /**
   * 创建ToB会话地址
   * 
   * @param request - GetConversationUrlRequest
   * @returns GetConversationUrlResponse
   */
  async getConversationUrl(request: GetConversationUrlRequest): Promise<GetConversationUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationUrlHeaders({ });
    return await this.getConversationUrlWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户家校群消息(图片&视频Z&富文本)
   * 
   * @param request - GetFamilySchoolConversationMsgRequest
   * @param headers - GetFamilySchoolConversationMsgHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFamilySchoolConversationMsgResponse
   */
  async getFamilySchoolConversationMsgWithOptions(request: GetFamilySchoolConversationMsgRequest, headers: GetFamilySchoolConversationMsgHeaders, runtime: $Util.RuntimeOptions): Promise<GetFamilySchoolConversationMsgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.msgTypes)) {
      body["msgTypes"] = request.msgTypes;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GetFamilySchoolConversationMsg",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/conversations/familySchools/messages/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFamilySchoolConversationMsgResponse>(await this.execute(params, req, runtime), new GetFamilySchoolConversationMsgResponse({}));
  }

  /**
   * 查询用户家校群消息(图片&视频Z&富文本)
   * 
   * @param request - GetFamilySchoolConversationMsgRequest
   * @returns GetFamilySchoolConversationMsgResponse
   */
  async getFamilySchoolConversationMsg(request: GetFamilySchoolConversationMsgRequest): Promise<GetFamilySchoolConversationMsgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFamilySchoolConversationMsgHeaders({ });
    return await this.getFamilySchoolConversationMsgWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户家校群
   * 
   * @param request - GetFamilySchoolConversationsRequest
   * @param headers - GetFamilySchoolConversationsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetFamilySchoolConversationsResponse
   */
  async getFamilySchoolConversationsWithOptions(request: GetFamilySchoolConversationsRequest, headers: GetFamilySchoolConversationsHeaders, runtime: $Util.RuntimeOptions): Promise<GetFamilySchoolConversationsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
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
      action: "GetFamilySchoolConversations",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/conversations/familySchools/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetFamilySchoolConversationsResponse>(await this.execute(params, req, runtime), new GetFamilySchoolConversationsResponse({}));
  }

  /**
   * 查询用户家校群
   * 
   * @param request - GetFamilySchoolConversationsRequest
   * @returns GetFamilySchoolConversationsResponse
   */
  async getFamilySchoolConversations(request: GetFamilySchoolConversationsRequest): Promise<GetFamilySchoolConversationsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetFamilySchoolConversationsHeaders({ });
    return await this.getFamilySchoolConversationsWithOptions(request, headers, runtime);
  }

  /**
   * 查询企业内部群成员
   * 
   * @param request - GetInnerGroupMembersRequest
   * @param headers - GetInnerGroupMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInnerGroupMembersResponse
   */
  async getInnerGroupMembersWithOptions(request: GetInnerGroupMembersRequest, headers: GetInnerGroupMembersHeaders, runtime: $Util.RuntimeOptions): Promise<GetInnerGroupMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GetInnerGroupMembers",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/innerGroups/members/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInnerGroupMembersResponse>(await this.execute(params, req, runtime), new GetInnerGroupMembersResponse({}));
  }

  /**
   * 查询企业内部群成员
   * 
   * @param request - GetInnerGroupMembersRequest
   * @returns GetInnerGroupMembersResponse
   */
  async getInnerGroupMembers(request: GetInnerGroupMembersRequest): Promise<GetInnerGroupMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInnerGroupMembersHeaders({ });
    return await this.getInnerGroupMembersWithOptions(request, headers, runtime);
  }

  /**
   * 创建客联互通会话地址
   * 
   * @param request - GetInterconnectionUrlRequest
   * @param headers - GetInterconnectionUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInterconnectionUrlResponse
   */
  async getInterconnectionUrlWithOptions(request: GetInterconnectionUrlRequest, headers: GetInterconnectionUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetInterconnectionUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserAvatar)) {
      body["appUserAvatar"] = request.appUserAvatar;
    }

    if (!Util.isUnset(request.appUserAvatarType)) {
      body["appUserAvatarType"] = request.appUserAvatarType;
    }

    if (!Util.isUnset(request.appUserId)) {
      body["appUserId"] = request.appUserId;
    }

    if (!Util.isUnset(request.appUserMobileNumber)) {
      body["appUserMobileNumber"] = request.appUserMobileNumber;
    }

    if (!Util.isUnset(request.appUserName)) {
      body["appUserName"] = request.appUserName;
    }

    if (!Util.isUnset(request.msgPageType)) {
      body["msgPageType"] = request.msgPageType;
    }

    if (!Util.isUnset(request.qrCode)) {
      body["qrCode"] = request.qrCode;
    }

    if (!Util.isUnset(request.signature)) {
      body["signature"] = request.signature;
    }

    if (!Util.isUnset(request.sourceCode)) {
      body["sourceCode"] = request.sourceCode;
    }

    if (!Util.isUnset(request.sourceType)) {
      body["sourceType"] = request.sourceType;
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
      action: "GetInterconnectionUrl",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/sessions/urls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInterconnectionUrlResponse>(await this.execute(params, req, runtime), new GetInterconnectionUrlResponse({}));
  }

  /**
   * 创建客联互通会话地址
   * 
   * @param request - GetInterconnectionUrlRequest
   * @returns GetInterconnectionUrlResponse
   */
  async getInterconnectionUrl(request: GetInterconnectionUrlRequest): Promise<GetInterconnectionUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInterconnectionUrlHeaders({ });
    return await this.getInterconnectionUrlWithOptions(request, headers, runtime);
  }

  /**
   * 查询最近活跃的企业内部群列表
   * 
   * @param request - GetNewestInnerGroupsRequest
   * @param headers - GetNewestInnerGroupsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetNewestInnerGroupsResponse
   */
  async getNewestInnerGroupsWithOptions(request: GetNewestInnerGroupsRequest, headers: GetNewestInnerGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<GetNewestInnerGroupsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      action: "GetNewestInnerGroups",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/activities/innerGroups`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetNewestInnerGroupsResponse>(await this.execute(params, req, runtime), new GetNewestInnerGroupsResponse({}));
  }

  /**
   * 查询最近活跃的企业内部群列表
   * 
   * @param request - GetNewestInnerGroupsRequest
   * @returns GetNewestInnerGroupsResponse
   */
  async getNewestInnerGroups(request: GetNewestInnerGroupsRequest): Promise<GetNewestInnerGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNewestInnerGroupsHeaders({ });
    return await this.getNewestInnerGroupsWithOptions(request, headers, runtime);
  }

  /**
   * 查询群简要信息
   * 
   * @param request - GetSceneGroupInfoRequest
   * @param headers - GetSceneGroupInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSceneGroupInfoResponse
   */
  async getSceneGroupInfoWithOptions(request: GetSceneGroupInfoRequest, headers: GetSceneGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetSceneGroupInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GetSceneGroupInfo",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSceneGroupInfoResponse>(await this.execute(params, req, runtime), new GetSceneGroupInfoResponse({}));
  }

  /**
   * 查询群简要信息
   * 
   * @param request - GetSceneGroupInfoRequest
   * @returns GetSceneGroupInfoResponse
   */
  async getSceneGroupInfo(request: GetSceneGroupInfoRequest): Promise<GetSceneGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSceneGroupInfoHeaders({ });
    return await this.getSceneGroupInfoWithOptions(request, headers, runtime);
  }

  /**
   * 查询群成员
   * 
   * @param request - GetSceneGroupMembersRequest
   * @param headers - GetSceneGroupMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSceneGroupMembersResponse
   */
  async getSceneGroupMembersWithOptions(request: GetSceneGroupMembersRequest, headers: GetSceneGroupMembersHeaders, runtime: $Util.RuntimeOptions): Promise<GetSceneGroupMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.cursor)) {
      body["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.size)) {
      body["size"] = request.size;
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
      action: "GetSceneGroupMembers",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/members/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSceneGroupMembersResponse>(await this.execute(params, req, runtime), new GetSceneGroupMembersResponse({}));
  }

  /**
   * 查询群成员
   * 
   * @param request - GetSceneGroupMembersRequest
   * @returns GetSceneGroupMembersResponse
   */
  async getSceneGroupMembers(request: GetSceneGroupMembersRequest): Promise<GetSceneGroupMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSceneGroupMembersHeaders({ });
    return await this.getSceneGroupMembersWithOptions(request, headers, runtime);
  }

  /**
   * 群禁言
   * 
   * @param request - GroupBanWordsRequest
   * @param headers - GroupBanWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupBanWordsResponse
   */
  async groupBanWordsWithOptions(request: GroupBanWordsRequest, headers: GroupBanWordsHeaders, runtime: $Util.RuntimeOptions): Promise<GroupBanWordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.banWordsMode)) {
      body["banWordsMode"] = request.banWordsMode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.options)) {
      body["options"] = request.options;
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
      action: "GroupBanWords",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/words/ban`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<GroupBanWordsResponse>(await this.execute(params, req, runtime), new GroupBanWordsResponse({}));
  }

  /**
   * 群禁言
   * 
   * @param request - GroupBanWordsRequest
   * @returns GroupBanWordsResponse
   */
  async groupBanWords(request: GroupBanWordsRequest): Promise<GroupBanWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupBanWordsHeaders({ });
    return await this.groupBanWordsWithOptions(request, headers, runtime);
  }

  /**
   * 群容量扩容询价
   * 
   * @param request - GroupCapacityInquiryRequest
   * @param headers - GroupCapacityInquiryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupCapacityInquiryResponse
   */
  async groupCapacityInquiryWithOptions(request: GroupCapacityInquiryRequest, headers: GroupCapacityInquiryHeaders, runtime: $Util.RuntimeOptions): Promise<GroupCapacityInquiryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.effectiveDuration)) {
      body["effectiveDuration"] = request.effectiveDuration;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.options)) {
      body["options"] = request.options;
    }

    if (!Util.isUnset(request.targetCapacity)) {
      body["targetCapacity"] = request.targetCapacity;
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
      action: "GroupCapacityInquiry",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/capacities/inquiries/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupCapacityInquiryResponse>(await this.execute(params, req, runtime), new GroupCapacityInquiryResponse({}));
  }

  /**
   * 群容量扩容询价
   * 
   * @param request - GroupCapacityInquiryRequest
   * @returns GroupCapacityInquiryResponse
   */
  async groupCapacityInquiry(request: GroupCapacityInquiryRequest): Promise<GroupCapacityInquiryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupCapacityInquiryHeaders({ });
    return await this.groupCapacityInquiryWithOptions(request, headers, runtime);
  }

  /**
   * 群容量扩容确认下单
   * 
   * @param request - GroupCapacityOrderConfirmRequest
   * @param headers - GroupCapacityOrderConfirmHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupCapacityOrderConfirmResponse
   */
  async groupCapacityOrderConfirmWithOptions(request: GroupCapacityOrderConfirmRequest, headers: GroupCapacityOrderConfirmHeaders, runtime: $Util.RuntimeOptions): Promise<GroupCapacityOrderConfirmResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
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
      action: "GroupCapacityOrderConfirm",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/capacities/orders/confirm`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupCapacityOrderConfirmResponse>(await this.execute(params, req, runtime), new GroupCapacityOrderConfirmResponse({}));
  }

  /**
   * 群容量扩容确认下单
   * 
   * @param request - GroupCapacityOrderConfirmRequest
   * @returns GroupCapacityOrderConfirmResponse
   */
  async groupCapacityOrderConfirm(request: GroupCapacityOrderConfirmRequest): Promise<GroupCapacityOrderConfirmResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupCapacityOrderConfirmHeaders({ });
    return await this.groupCapacityOrderConfirmWithOptions(request, headers, runtime);
  }

  /**
   * 群容量请求扩容下单
   * 
   * @param request - GroupCapacityOrderPlaceRequest
   * @param headers - GroupCapacityOrderPlaceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupCapacityOrderPlaceResponse
   */
  async groupCapacityOrderPlaceWithOptions(request: GroupCapacityOrderPlaceRequest, headers: GroupCapacityOrderPlaceHeaders, runtime: $Util.RuntimeOptions): Promise<GroupCapacityOrderPlaceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actualPrice)) {
      body["actualPrice"] = request.actualPrice;
    }

    if (!Util.isUnset(request.currentCapacity)) {
      body["currentCapacity"] = request.currentCapacity;
    }

    if (!Util.isUnset(request.currentEffectUntil)) {
      body["currentEffectUntil"] = request.currentEffectUntil;
    }

    if (!Util.isUnset(request.discount)) {
      body["discount"] = request.discount;
    }

    if (!Util.isUnset(request.extInfo)) {
      body["extInfo"] = request.extInfo;
    }

    if (!Util.isUnset(request.markedPrice)) {
      body["markedPrice"] = request.markedPrice;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.operator)) {
      body["operator"] = request.operator;
    }

    if (!Util.isUnset(request.targetCapacity)) {
      body["targetCapacity"] = request.targetCapacity;
    }

    if (!Util.isUnset(request.targetEffectUntil)) {
      body["targetEffectUntil"] = request.targetEffectUntil;
    }

    if (!Util.isUnset(request.token)) {
      body["token"] = request.token;
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
      action: "GroupCapacityOrderPlace",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/capacities/orders/place`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupCapacityOrderPlaceResponse>(await this.execute(params, req, runtime), new GroupCapacityOrderPlaceResponse({}));
  }

  /**
   * 群容量请求扩容下单
   * 
   * @param request - GroupCapacityOrderPlaceRequest
   * @returns GroupCapacityOrderPlaceResponse
   */
  async groupCapacityOrderPlace(request: GroupCapacityOrderPlaceRequest): Promise<GroupCapacityOrderPlaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupCapacityOrderPlaceHeaders({ });
    return await this.groupCapacityOrderPlaceWithOptions(request, headers, runtime);
  }

  /**
   * 根据群链接、群号等检索条件，查询群信息
   * 
   * @param request - GroupManageQueryRequest
   * @param headers - GroupManageQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupManageQueryResponse
   */
  async groupManageQueryWithOptions(request: GroupManageQueryRequest, headers: GroupManageQueryHeaders, runtime: $Util.RuntimeOptions): Promise<GroupManageQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.createdAfter)) {
      body["createdAfter"] = request.createdAfter;
    }

    if (!Util.isUnset(request.groupId)) {
      body["groupId"] = request.groupId;
    }

    if (!Util.isUnset(request.groupMemberSamples)) {
      body["groupMemberSamples"] = request.groupMemberSamples;
    }

    if (!Util.isUnset(request.groupOwner)) {
      body["groupOwner"] = request.groupOwner;
    }

    if (!Util.isUnset(request.groupTitleKeywords)) {
      body["groupTitleKeywords"] = request.groupTitleKeywords;
    }

    if (!Util.isUnset(request.groupUrl)) {
      body["groupUrl"] = request.groupUrl;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.membersOver)) {
      body["membersOver"] = request.membersOver;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GroupManageQuery",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/managements/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupManageQueryResponse>(await this.execute(params, req, runtime), new GroupManageQueryResponse({}));
  }

  /**
   * 根据群链接、群号等检索条件，查询群信息
   * 
   * @param request - GroupManageQueryRequest
   * @returns GroupManageQueryResponse
   */
  async groupManageQuery(request: GroupManageQueryRequest): Promise<GroupManageQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupManageQueryHeaders({ });
    return await this.groupManageQueryWithOptions(request, headers, runtime);
  }

  /**
   * 群管理缩容
   * 
   * @param request - GroupManageReduceRequest
   * @param headers - GroupManageReduceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupManageReduceResponse
   */
  async groupManageReduceWithOptions(request: GroupManageReduceRequest, headers: GroupManageReduceHeaders, runtime: $Util.RuntimeOptions): Promise<GroupManageReduceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.capacityLimit)) {
      body["capacityLimit"] = request.capacityLimit;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.options)) {
      body["options"] = request.options;
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
      action: "GroupManageReduce",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/capacities/reduce`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<GroupManageReduceResponse>(await this.execute(params, req, runtime), new GroupManageReduceResponse({}));
  }

  /**
   * 群管理缩容
   * 
   * @param request - GroupManageReduceRequest
   * @returns GroupManageReduceResponse
   */
  async groupManageReduce(request: GroupManageReduceRequest): Promise<GroupManageReduceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupManageReduceHeaders({ });
    return await this.groupManageReduceWithOptions(request, headers, runtime);
  }

  /**
   * 安装机器人到组织
   * 
   * @param request - InstallRobotToOrgRequest
   * @param headers - InstallRobotToOrgHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InstallRobotToOrgResponse
   */
  async installRobotToOrgWithOptions(request: InstallRobotToOrgRequest, headers: InstallRobotToOrgHeaders, runtime: $Util.RuntimeOptions): Promise<InstallRobotToOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.brief)) {
      body["brief"] = request.brief;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.outgoingToken)) {
      body["outgoingToken"] = request.outgoingToken;
    }

    if (!Util.isUnset(request.outgoingUrl)) {
      body["outgoingUrl"] = request.outgoingUrl;
    }

    if (!Util.isUnset(request.previewMediaId)) {
      body["previewMediaId"] = request.previewMediaId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "InstallRobotToOrg",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/organizations/robots/install`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallRobotToOrgResponse>(await this.execute(params, req, runtime), new InstallRobotToOrgResponse({}));
  }

  /**
   * 安装机器人到组织
   * 
   * @param request - InstallRobotToOrgRequest
   * @returns InstallRobotToOrgResponse
   */
  async installRobotToOrg(request: InstallRobotToOrgRequest): Promise<InstallRobotToOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallRobotToOrgHeaders({ });
    return await this.installRobotToOrgWithOptions(request, headers, runtime);
  }

  /**
   * 创建可交互式实例
   * 
   * @param request - InteractiveCardCreateInstanceRequest
   * @param headers - InteractiveCardCreateInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InteractiveCardCreateInstanceResponse
   */
  async interactiveCardCreateInstanceWithOptions(request: InteractiveCardCreateInstanceRequest, headers: InteractiveCardCreateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<InteractiveCardCreateInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.chatBotId)) {
      body["chatBotId"] = request.chatBotId;
    }

    if (!Util.isUnset(request.conversationType)) {
      body["conversationType"] = request.conversationType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.pullStrategy)) {
      body["pullStrategy"] = request.pullStrategy;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "InteractiveCardCreateInstance",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interactiveCards/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InteractiveCardCreateInstanceResponse>(await this.execute(params, req, runtime), new InteractiveCardCreateInstanceResponse({}));
  }

  /**
   * 创建可交互式实例
   * 
   * @param request - InteractiveCardCreateInstanceRequest
   * @returns InteractiveCardCreateInstanceResponse
   */
  async interactiveCardCreateInstance(request: InteractiveCardCreateInstanceRequest): Promise<InteractiveCardCreateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InteractiveCardCreateInstanceHeaders({ });
    return await this.interactiveCardCreateInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
   * 
   * @param headers - ListOrgTextEmotionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListOrgTextEmotionResponse
   */
  async listOrgTextEmotionWithOptions(headers: ListOrgTextEmotionHeaders, runtime: $Util.RuntimeOptions): Promise<ListOrgTextEmotionResponse> {
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
      action: "ListOrgTextEmotion",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/organizations/textEmotions`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListOrgTextEmotionResponse>(await this.execute(params, req, runtime), new ListOrgTextEmotionResponse({}));
  }

  /**
   * 拉取企业的所有文字表情，包含正常使用的、已经删除了的、安全审核不通过的文字表情
   * @returns ListOrgTextEmotionResponse
   */
  async listOrgTextEmotion(): Promise<ListOrgTextEmotionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListOrgTextEmotionHeaders({ });
    return await this.listOrgTextEmotionWithOptions(headers, runtime);
  }

  /**
   * 链接增强规则下线
   * 
   * @param request - OfflineUnfurlingRegisterRequest
   * @param headers - OfflineUnfurlingRegisterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OfflineUnfurlingRegisterResponse
   */
  async offlineUnfurlingRegisterWithOptions(request: OfflineUnfurlingRegisterRequest, headers: OfflineUnfurlingRegisterHeaders, runtime: $Util.RuntimeOptions): Promise<OfflineUnfurlingRegisterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
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
      action: "OfflineUnfurlingRegister",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OfflineUnfurlingRegisterResponse>(await this.execute(params, req, runtime), new OfflineUnfurlingRegisterResponse({}));
  }

  /**
   * 链接增强规则下线
   * 
   * @param request - OfflineUnfurlingRegisterRequest
   * @returns OfflineUnfurlingRegisterResponse
   */
  async offlineUnfurlingRegister(request: OfflineUnfurlingRegisterRequest): Promise<OfflineUnfurlingRegisterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OfflineUnfurlingRegisterHeaders({ });
    return await this.offlineUnfurlingRegisterWithOptions(request, headers, runtime);
  }

  /**
   * 开放场景群新增群角色
   * 
   * @param request - OpenGroupRoleAddRequest
   * @param headers - OpenGroupRoleAddHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenGroupRoleAddResponse
   */
  async openGroupRoleAddWithOptions(request: OpenGroupRoleAddRequest, headers: OpenGroupRoleAddHeaders, runtime: $Util.RuntimeOptions): Promise<OpenGroupRoleAddResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.roleName)) {
      body["roleName"] = request.roleName;
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
      action: "OpenGroupRoleAdd",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/roles`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenGroupRoleAddResponse>(await this.execute(params, req, runtime), new OpenGroupRoleAddResponse({}));
  }

  /**
   * 开放场景群新增群角色
   * 
   * @param request - OpenGroupRoleAddRequest
   * @returns OpenGroupRoleAddResponse
   */
  async openGroupRoleAdd(request: OpenGroupRoleAddRequest): Promise<OpenGroupRoleAddResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenGroupRoleAddHeaders({ });
    return await this.openGroupRoleAddWithOptions(request, headers, runtime);
  }

  /**
   * 开放场景群群角色查询
   * 
   * @param request - OpenGroupRoleQueryRequest
   * @param headers - OpenGroupRoleQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenGroupRoleQueryResponse
   */
  async openGroupRoleQueryWithOptions(request: OpenGroupRoleQueryRequest, headers: OpenGroupRoleQueryHeaders, runtime: $Util.RuntimeOptions): Promise<OpenGroupRoleQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "OpenGroupRoleQuery",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/roles/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenGroupRoleQueryResponse>(await this.execute(params, req, runtime), new OpenGroupRoleQueryResponse({}));
  }

  /**
   * 开放场景群群角色查询
   * 
   * @param request - OpenGroupRoleQueryRequest
   * @returns OpenGroupRoleQueryResponse
   */
  async openGroupRoleQuery(request: OpenGroupRoleQueryRequest): Promise<OpenGroupRoleQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenGroupRoleQueryHeaders({ });
    return await this.openGroupRoleQueryWithOptions(request, headers, runtime);
  }

  /**
   * 开放场景群群角色移除
   * 
   * @param request - OpenGroupRoleRemoveRequest
   * @param headers - OpenGroupRoleRemoveHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenGroupRoleRemoveResponse
   */
  async openGroupRoleRemoveWithOptions(request: OpenGroupRoleRemoveRequest, headers: OpenGroupRoleRemoveHeaders, runtime: $Util.RuntimeOptions): Promise<OpenGroupRoleRemoveResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openRoleId)) {
      body["openRoleId"] = request.openRoleId;
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
      action: "OpenGroupRoleRemove",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/roles/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenGroupRoleRemoveResponse>(await this.execute(params, req, runtime), new OpenGroupRoleRemoveResponse({}));
  }

  /**
   * 开放场景群群角色移除
   * 
   * @param request - OpenGroupRoleRemoveRequest
   * @returns OpenGroupRoleRemoveResponse
   */
  async openGroupRoleRemove(request: OpenGroupRoleRemoveRequest): Promise<OpenGroupRoleRemoveResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenGroupRoleRemoveHeaders({ });
    return await this.openGroupRoleRemoveWithOptions(request, headers, runtime);
  }

  /**
   * 开放场景群群角色变更
   * 
   * @param request - OpenGroupRoleUpdateRequest
   * @param headers - OpenGroupRoleUpdateHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenGroupRoleUpdateResponse
   */
  async openGroupRoleUpdateWithOptions(request: OpenGroupRoleUpdateRequest, headers: OpenGroupRoleUpdateHeaders, runtime: $Util.RuntimeOptions): Promise<OpenGroupRoleUpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openRoleId)) {
      body["openRoleId"] = request.openRoleId;
    }

    if (!Util.isUnset(request.roleName)) {
      body["roleName"] = request.roleName;
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
      action: "OpenGroupRoleUpdate",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/roles`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenGroupRoleUpdateResponse>(await this.execute(params, req, runtime), new OpenGroupRoleUpdateResponse({}));
  }

  /**
   * 开放场景群群角色变更
   * 
   * @param request - OpenGroupRoleUpdateRequest
   * @returns OpenGroupRoleUpdateResponse
   */
  async openGroupRoleUpdate(request: OpenGroupRoleUpdateRequest): Promise<OpenGroupRoleUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenGroupRoleUpdateHeaders({ });
    return await this.openGroupRoleUpdateWithOptions(request, headers, runtime);
  }

  /**
   * 开放场景群群成员的群角色信息查询
   * 
   * @param request - OpenGroupUserRoleQueryRequest
   * @param headers - OpenGroupUserRoleQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenGroupUserRoleQueryResponse
   */
  async openGroupUserRoleQueryWithOptions(request: OpenGroupUserRoleQueryRequest, headers: OpenGroupUserRoleQueryHeaders, runtime: $Util.RuntimeOptions): Promise<OpenGroupUserRoleQueryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.viewedUserId)) {
      body["viewedUserId"] = request.viewedUserId;
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
      action: "OpenGroupUserRoleQuery",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/users/roles/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenGroupUserRoleQueryResponse>(await this.execute(params, req, runtime), new OpenGroupUserRoleQueryResponse({}));
  }

  /**
   * 开放场景群群成员的群角色信息查询
   * 
   * @param request - OpenGroupUserRoleQueryRequest
   * @returns OpenGroupUserRoleQueryResponse
   */
  async openGroupUserRoleQuery(request: OpenGroupUserRoleQueryRequest): Promise<OpenGroupUserRoleQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenGroupUserRoleQueryHeaders({ });
    return await this.openGroupUserRoleQueryWithOptions(request, headers, runtime);
  }

  /**
   * 内部群转部门群
   * 
   * @param request - OpenInnerGroupTransferToDeptGroupRequest
   * @param headers - OpenInnerGroupTransferToDeptGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenInnerGroupTransferToDeptGroupResponse
   */
  async openInnerGroupTransferToDeptGroupWithOptions(request: OpenInnerGroupTransferToDeptGroupRequest, headers: OpenInnerGroupTransferToDeptGroupHeaders, runtime: $Util.RuntimeOptions): Promise<OpenInnerGroupTransferToDeptGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "OpenInnerGroupTransferToDeptGroup",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/innerGroups/transferToDeptGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenInnerGroupTransferToDeptGroupResponse>(await this.execute(params, req, runtime), new OpenInnerGroupTransferToDeptGroupResponse({}));
  }

  /**
   * 内部群转部门群
   * 
   * @param request - OpenInnerGroupTransferToDeptGroupRequest
   * @returns OpenInnerGroupTransferToDeptGroupResponse
   */
  async openInnerGroupTransferToDeptGroup(request: OpenInnerGroupTransferToDeptGroupRequest): Promise<OpenInnerGroupTransferToDeptGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenInnerGroupTransferToDeptGroupHeaders({ });
    return await this.openInnerGroupTransferToDeptGroupWithOptions(request, headers, runtime);
  }

  /**
   * 群搜索
   * 
   * @param request - OpenSearchGroupListRequest
   * @param headers - OpenSearchGroupListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenSearchGroupListResponse
   */
  async openSearchGroupListWithOptions(request: OpenSearchGroupListRequest, headers: OpenSearchGroupListHeaders, runtime: $Util.RuntimeOptions): Promise<OpenSearchGroupListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
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
      action: "OpenSearchGroupList",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenSearchGroupListResponse>(await this.execute(params, req, runtime), new OpenSearchGroupListResponse({}));
  }

  /**
   * 群搜索
   * 
   * @param request - OpenSearchGroupListRequest
   * @returns OpenSearchGroupListResponse
   */
  async openSearchGroupList(request: OpenSearchGroupListRequest): Promise<OpenSearchGroupListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenSearchGroupListHeaders({ });
    return await this.openSearchGroupListWithOptions(request, headers, runtime);
  }

  /**
   * 以个人身份发送卡片消息
   * 
   * @param request - OpenUserSendCardMessageRequest
   * @param headers - OpenUserSendCardMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OpenUserSendCardMessageResponse
   */
  async openUserSendCardMessageWithOptions(request: OpenUserSendCardMessageRequest, headers: OpenUserSendCardMessageHeaders, runtime: $Util.RuntimeOptions): Promise<OpenUserSendCardMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardContent)) {
      body["cardContent"] = request.cardContent;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiveUserId)) {
      body["receiveUserId"] = request.receiveUserId;
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
      action: "OpenUserSendCardMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/cardMessages/users/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OpenUserSendCardMessageResponse>(await this.execute(params, req, runtime), new OpenUserSendCardMessageResponse({}));
  }

  /**
   * 以个人身份发送卡片消息
   * 
   * @param request - OpenUserSendCardMessageRequest
   * @returns OpenUserSendCardMessageResponse
   */
  async openUserSendCardMessage(request: OpenUserSendCardMessageRequest): Promise<OpenUserSendCardMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OpenUserSendCardMessageHeaders({ });
    return await this.openUserSendCardMessageWithOptions(request, headers, runtime);
  }

  /**
   * 以用户身份发送卡片消息
   * 
   * @param request - PersonalSendCardMessageRequest
   * @param headers - PersonalSendCardMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PersonalSendCardMessageResponse
   */
  async personalSendCardMessageWithOptions(request: PersonalSendCardMessageRequest, headers: PersonalSendCardMessageHeaders, runtime: $Util.RuntimeOptions): Promise<PersonalSendCardMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.atUserIds)) {
      body["atUserIds"] = request.atUserIds;
    }

    if (!Util.isUnset(request.cardContent)) {
      body["cardContent"] = request.cardContent;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiveUserId)) {
      body["receiveUserId"] = request.receiveUserId;
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
      action: "PersonalSendCardMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/me/messages/cards/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PersonalSendCardMessageResponse>(await this.execute(params, req, runtime), new PersonalSendCardMessageResponse({}));
  }

  /**
   * 以用户身份发送卡片消息
   * 
   * @param request - PersonalSendCardMessageRequest
   * @returns PersonalSendCardMessageResponse
   */
  async personalSendCardMessage(request: PersonalSendCardMessageRequest): Promise<PersonalSendCardMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PersonalSendCardMessageHeaders({ });
    return await this.personalSendCardMessageWithOptions(request, headers, runtime);
  }

  /**
   * 成员授权场景下查询群信息
   * 
   * @param request - QueryGroupInfoByMemberAuthRequest
   * @param headers - QueryGroupInfoByMemberAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupInfoByMemberAuthResponse
   */
  async queryGroupInfoByMemberAuthWithOptions(request: QueryGroupInfoByMemberAuthRequest, headers: QueryGroupInfoByMemberAuthHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupInfoByMemberAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "QueryGroupInfoByMemberAuth",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/memberAuthorizations/groups/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupInfoByMemberAuthResponse>(await this.execute(params, req, runtime), new QueryGroupInfoByMemberAuthResponse({}));
  }

  /**
   * 成员授权场景下查询群信息
   * 
   * @param request - QueryGroupInfoByMemberAuthRequest
   * @returns QueryGroupInfoByMemberAuthResponse
   */
  async queryGroupInfoByMemberAuth(request: QueryGroupInfoByMemberAuthRequest): Promise<QueryGroupInfoByMemberAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupInfoByMemberAuthHeaders({ });
    return await this.queryGroupInfoByMemberAuthWithOptions(request, headers, runtime);
  }

  /**
   * 查询群成员列表
   * 
   * @param request - QueryGroupMemberRequest
   * @param headers - QueryGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupMemberResponse
   */
  async queryGroupMemberWithOptions(request: QueryGroupMemberRequest, headers: QueryGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupMemberResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
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
      action: "QueryGroupMember",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/conversations/members`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupMemberResponse>(await this.execute(params, req, runtime), new QueryGroupMemberResponse({}));
  }

  /**
   * 查询群成员列表
   * 
   * @param request - QueryGroupMemberRequest
   * @returns QueryGroupMemberResponse
   */
  async queryGroupMember(request: QueryGroupMemberRequest): Promise<QueryGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMemberHeaders({ });
    return await this.queryGroupMemberWithOptions(request, headers, runtime);
  }

  /**
   * 成员授权场景下查询群成员
   * 
   * @param request - QueryGroupMemberByMemberAuthRequest
   * @param headers - QueryGroupMemberByMemberAuthHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupMemberByMemberAuthResponse
   */
  async queryGroupMemberByMemberAuthWithOptions(request: QueryGroupMemberByMemberAuthRequest, headers: QueryGroupMemberByMemberAuthHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupMemberByMemberAuthResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "QueryGroupMemberByMemberAuth",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/memberAuthorizations/groups/members/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupMemberByMemberAuthResponse>(await this.execute(params, req, runtime), new QueryGroupMemberByMemberAuthResponse({}));
  }

  /**
   * 成员授权场景下查询群成员
   * 
   * @param request - QueryGroupMemberByMemberAuthRequest
   * @returns QueryGroupMemberByMemberAuthResponse
   */
  async queryGroupMemberByMemberAuth(request: QueryGroupMemberByMemberAuthRequest): Promise<QueryGroupMemberByMemberAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMemberByMemberAuthHeaders({ });
    return await this.queryGroupMemberByMemberAuthWithOptions(request, headers, runtime);
  }

  /**
   * 查询群禁言状态
   * 
   * @param request - QueryGroupMuteStatusRequest
   * @param headers - QueryGroupMuteStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupMuteStatusResponse
   */
  async queryGroupMuteStatusWithOptions(request: QueryGroupMuteStatusRequest, headers: QueryGroupMuteStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupMuteStatusResponse> {
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
      action: "QueryGroupMuteStatus",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/muteSettings`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupMuteStatusResponse>(await this.execute(params, req, runtime), new QueryGroupMuteStatusResponse({}));
  }

  /**
   * 查询群禁言状态
   * 
   * @param request - QueryGroupMuteStatusRequest
   * @returns QueryGroupMuteStatusResponse
   */
  async queryGroupMuteStatus(request: QueryGroupMuteStatusRequest): Promise<QueryGroupMuteStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMuteStatusHeaders({ });
    return await this.queryGroupMuteStatusWithOptions(request, headers, runtime);
  }

  /**
   * 读取群成员列表
   * 
   * @param request - QueryInnerGroupMemberListRequest
   * @param headers - QueryInnerGroupMemberListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryInnerGroupMemberListResponse
   */
  async queryInnerGroupMemberListWithOptions(request: QueryInnerGroupMemberListRequest, headers: QueryInnerGroupMemberListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryInnerGroupMemberListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "QueryInnerGroupMemberList",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/innerGroups/memberLists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryInnerGroupMemberListResponse>(await this.execute(params, req, runtime), new QueryInnerGroupMemberListResponse({}));
  }

  /**
   * 读取群成员列表
   * 
   * @param request - QueryInnerGroupMemberListRequest
   * @returns QueryInnerGroupMemberListResponse
   */
  async queryInnerGroupMemberList(request: QueryInnerGroupMemberListRequest): Promise<QueryInnerGroupMemberListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInnerGroupMemberListHeaders({ });
    return await this.queryInnerGroupMemberListWithOptions(request, headers, runtime);
  }

  /**
   * 查询最近活跃的企业内部群列表
   * 
   * @param request - QueryInnerGroupRecentListRequest
   * @param headers - QueryInnerGroupRecentListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryInnerGroupRecentListResponse
   */
  async queryInnerGroupRecentListWithOptions(request: QueryInnerGroupRecentListRequest, headers: QueryInnerGroupRecentListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryInnerGroupRecentListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
      action: "QueryInnerGroupRecentList",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/innerGroups/recentLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryInnerGroupRecentListResponse>(await this.execute(params, req, runtime), new QueryInnerGroupRecentListResponse({}));
  }

  /**
   * 查询最近活跃的企业内部群列表
   * 
   * @param request - QueryInnerGroupRecentListRequest
   * @returns QueryInnerGroupRecentListResponse
   */
  async queryInnerGroupRecentList(request: QueryInnerGroupRecentListRequest): Promise<QueryInnerGroupRecentListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInnerGroupRecentListHeaders({ });
    return await this.queryInnerGroupRecentListWithOptions(request, headers, runtime);
  }

  /**
   * 查询群内具有指定群角色的所有群成员
   * 
   * @param request - QueryMembersOfGroupRoleRequest
   * @param headers - QueryMembersOfGroupRoleHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMembersOfGroupRoleResponse
   */
  async queryMembersOfGroupRoleWithOptions(request: QueryMembersOfGroupRoleRequest, headers: QueryMembersOfGroupRoleHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMembersOfGroupRoleResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openRoleId)) {
      body["openRoleId"] = request.openRoleId;
    }

    if (!Util.isUnset(request.timestamp)) {
      body["timestamp"] = request.timestamp;
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
      action: "QueryMembersOfGroupRole",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/roles/members/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryMembersOfGroupRoleResponse>(await this.execute(params, req, runtime), new QueryMembersOfGroupRoleResponse({}));
  }

  /**
   * 查询群内具有指定群角色的所有群成员
   * 
   * @param request - QueryMembersOfGroupRoleRequest
   * @returns QueryMembersOfGroupRoleResponse
   */
  async queryMembersOfGroupRole(request: QueryMembersOfGroupRoleRequest): Promise<QueryMembersOfGroupRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMembersOfGroupRoleHeaders({ });
    return await this.queryMembersOfGroupRoleWithOptions(request, headers, runtime);
  }

  /**
   * 根据openTaskId查询消息发送结果
   * 
   * @param request - QueryMessageSendResultRequest
   * @param headers - QueryMessageSendResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMessageSendResultResponse
   */
  async queryMessageSendResultWithOptions(request: QueryMessageSendResultRequest, headers: QueryMessageSendResultHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMessageSendResultResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTaskId)) {
      body["openTaskId"] = request.openTaskId;
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
      action: "QueryMessageSendResult",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/messages/sendResults/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMessageSendResultResponse>(await this.execute(params, req, runtime), new QueryMessageSendResultResponse({}));
  }

  /**
   * 根据openTaskId查询消息发送结果
   * 
   * @param request - QueryMessageSendResultRequest
   * @returns QueryMessageSendResultResponse
   */
  async queryMessageSendResult(request: QueryMessageSendResultRequest): Promise<QueryMessageSendResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMessageSendResultHeaders({ });
    return await this.queryMessageSendResultWithOptions(request, headers, runtime);
  }

  /**
   * 根据单聊会话及发送方获取接收方用户信息
   * 
   * @param request - QueryOpenConversationReceiveUserRequest
   * @param headers - QueryOpenConversationReceiveUserHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOpenConversationReceiveUserResponse
   */
  async queryOpenConversationReceiveUserWithOptions(request: QueryOpenConversationReceiveUserRequest, headers: QueryOpenConversationReceiveUserHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOpenConversationReceiveUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.sendUserId)) {
      body["sendUserId"] = request.sendUserId;
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
      action: "QueryOpenConversationReceiveUser",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/otoChat/receiveUsers/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOpenConversationReceiveUserResponse>(await this.execute(params, req, runtime), new QueryOpenConversationReceiveUserResponse({}));
  }

  /**
   * 根据单聊会话及发送方获取接收方用户信息
   * 
   * @param request - QueryOpenConversationReceiveUserRequest
   * @returns QueryOpenConversationReceiveUserResponse
   */
  async queryOpenConversationReceiveUser(request: QueryOpenConversationReceiveUserRequest): Promise<QueryOpenConversationReceiveUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOpenConversationReceiveUserHeaders({ });
    return await this.queryOpenConversationReceiveUserWithOptions(request, headers, runtime);
  }

  /**
   * 获取群基础信息
   * 
   * @param request - QueryOpenGroupBaseInfoRequest
   * @param headers - QueryOpenGroupBaseInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryOpenGroupBaseInfoResponse
   */
  async queryOpenGroupBaseInfoWithOptions(request: QueryOpenGroupBaseInfoRequest, headers: QueryOpenGroupBaseInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOpenGroupBaseInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "QueryOpenGroupBaseInfo",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/groups/baseInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOpenGroupBaseInfoResponse>(await this.execute(params, req, runtime), new QueryOpenGroupBaseInfoResponse({}));
  }

  /**
   * 获取群基础信息
   * 
   * @param request - QueryOpenGroupBaseInfoRequest
   * @returns QueryOpenGroupBaseInfoResponse
   */
  async queryOpenGroupBaseInfo(request: QueryOpenGroupBaseInfoRequest): Promise<QueryOpenGroupBaseInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOpenGroupBaseInfoHeaders({ });
    return await this.queryOpenGroupBaseInfoWithOptions(request, headers, runtime);
  }

  /**
   * 用户身份查询消息已读未读状态
   * 
   * @param request - QueryPersonalMessageReadStatusRequest
   * @param headers - QueryPersonalMessageReadStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryPersonalMessageReadStatusResponse
   */
  async queryPersonalMessageReadStatusWithOptions(request: QueryPersonalMessageReadStatusRequest, headers: QueryPersonalMessageReadStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPersonalMessageReadStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openMessageId)) {
      body["openMessageId"] = request.openMessageId;
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
      action: "QueryPersonalMessageReadStatus",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/me/messages/readStatuses/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPersonalMessageReadStatusResponse>(await this.execute(params, req, runtime), new QueryPersonalMessageReadStatusResponse({}));
  }

  /**
   * 用户身份查询消息已读未读状态
   * 
   * @param request - QueryPersonalMessageReadStatusRequest
   * @returns QueryPersonalMessageReadStatusResponse
   */
  async queryPersonalMessageReadStatus(request: QueryPersonalMessageReadStatusRequest): Promise<QueryPersonalMessageReadStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPersonalMessageReadStatusHeaders({ });
    return await this.queryPersonalMessageReadStatusWithOptions(request, headers, runtime);
  }

  /**
   * 获取最近联系人及群组
   * 
   * @param request - QueryRecentConversationsRequest
   * @param headers - QueryRecentConversationsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRecentConversationsResponse
   */
  async queryRecentConversationsWithOptions(request: QueryRecentConversationsRequest, headers: QueryRecentConversationsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRecentConversationsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.onlyHuman)) {
      body["onlyHuman"] = request.onlyHuman;
    }

    if (!Util.isUnset(request.onlyInnerGroup)) {
      body["onlyInnerGroup"] = request.onlyInnerGroup;
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
      action: "QueryRecentConversations",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/conversations/recentLists/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRecentConversationsResponse>(await this.execute(params, req, runtime), new QueryRecentConversationsResponse({}));
  }

  /**
   * 获取最近联系人及群组
   * 
   * @param request - QueryRecentConversationsRequest
   * @returns QueryRecentConversationsResponse
   */
  async queryRecentConversations(request: QueryRecentConversationsRequest): Promise<QueryRecentConversationsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRecentConversationsHeaders({ });
    return await this.queryRecentConversationsWithOptions(request, headers, runtime);
  }

  /**
   * 查询群内群模板机器人
   * 
   * @param request - QuerySceneGroupTemplateRobotRequest
   * @param headers - QuerySceneGroupTemplateRobotHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySceneGroupTemplateRobotResponse
   */
  async querySceneGroupTemplateRobotWithOptions(request: QuerySceneGroupTemplateRobotRequest, headers: QuerySceneGroupTemplateRobotHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySceneGroupTemplateRobotResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.robotCode)) {
      query["robotCode"] = request.robotCode;
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
      action: "QuerySceneGroupTemplateRobot",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/templates/robots`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySceneGroupTemplateRobotResponse>(await this.execute(params, req, runtime), new QuerySceneGroupTemplateRobotResponse({}));
  }

  /**
   * 查询群内群模板机器人
   * 
   * @param request - QuerySceneGroupTemplateRobotRequest
   * @returns QuerySceneGroupTemplateRobotResponse
   */
  async querySceneGroupTemplateRobot(request: QuerySceneGroupTemplateRobotRequest): Promise<QuerySceneGroupTemplateRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySceneGroupTemplateRobotHeaders({ });
    return await this.querySceneGroupTemplateRobotWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询群信息
   * 
   * @param request - QuerySingleGroupRequest
   * @param headers - QuerySingleGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySingleGroupResponse
   */
  async querySingleGroupWithOptions(request: QuerySingleGroupRequest, headers: QuerySingleGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySingleGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupMembers)) {
      body["groupMembers"] = request.groupMembers;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
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
      action: "QuerySingleGroup",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/doubleGroups/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySingleGroupResponse>(await this.execute(params, req, runtime), new QuerySingleGroupResponse({}));
  }

  /**
   * 批量查询群信息
   * 
   * @param request - QuerySingleGroupRequest
   * @returns QuerySingleGroupResponse
   */
  async querySingleGroup(request: QuerySingleGroupRequest): Promise<QuerySingleGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySingleGroupHeaders({ });
    return await this.querySingleGroupWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询未读消息数
   * 
   * @param request - QueryUnReadMessageRequest
   * @param headers - QueryUnReadMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUnReadMessageResponse
   */
  async queryUnReadMessageWithOptions(request: QueryUnReadMessageRequest, headers: QueryUnReadMessageHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUnReadMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserId)) {
      body["appUserId"] = request.appUserId;
    }

    if (!Util.isUnset(request.openConversationIds)) {
      body["openConversationIds"] = request.openConversationIds;
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
      action: "QueryUnReadMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/unReadMsgs/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUnReadMessageResponse>(await this.execute(params, req, runtime), new QueryUnReadMessageResponse({}));
  }

  /**
   * 批量查询未读消息数
   * 
   * @param request - QueryUnReadMessageRequest
   * @returns QueryUnReadMessageResponse
   */
  async queryUnReadMessage(request: QueryUnReadMessageRequest): Promise<QueryUnReadMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUnReadMessageHeaders({ });
    return await this.queryUnReadMessageWithOptions(request, headers, runtime);
  }

  /**
   * 查询链接查询链接增强注册信息创建者
   * 
   * @param request - QueryUnfurlingRegisterCreatorRequest
   * @param headers - QueryUnfurlingRegisterCreatorHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUnfurlingRegisterCreatorResponse
   */
  async queryUnfurlingRegisterCreatorWithOptions(request: QueryUnfurlingRegisterCreatorRequest, headers: QueryUnfurlingRegisterCreatorHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUnfurlingRegisterCreatorResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.domain)) {
      query["domain"] = request.domain;
    }

    if (!Util.isUnset(request.path)) {
      query["path"] = request.path;
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
      action: "QueryUnfurlingRegisterCreator",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules/creators`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUnfurlingRegisterCreatorResponse>(await this.execute(params, req, runtime), new QueryUnfurlingRegisterCreatorResponse({}));
  }

  /**
   * 查询链接查询链接增强注册信息创建者
   * 
   * @param request - QueryUnfurlingRegisterCreatorRequest
   * @returns QueryUnfurlingRegisterCreatorResponse
   */
  async queryUnfurlingRegisterCreator(request: QueryUnfurlingRegisterCreatorRequest): Promise<QueryUnfurlingRegisterCreatorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUnfurlingRegisterCreatorHeaders({ });
    return await this.queryUnfurlingRegisterCreatorWithOptions(request, headers, runtime);
  }

  /**
   * 查询链接增强注册信息列表
   * 
   * @param request - QueryUnfurlingRegisterInfoRequest
   * @param headers - QueryUnfurlingRegisterInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryUnfurlingRegisterInfoResponse
   */
  async queryUnfurlingRegisterInfoWithOptions(request: QueryUnfurlingRegisterInfoRequest, headers: QueryUnfurlingRegisterInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUnfurlingRegisterInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
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
      action: "QueryUnfurlingRegisterInfo",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryUnfurlingRegisterInfoResponse>(await this.execute(params, req, runtime), new QueryUnfurlingRegisterInfoResponse({}));
  }

  /**
   * 查询链接增强注册信息列表
   * 
   * @param request - QueryUnfurlingRegisterInfoRequest
   * @returns QueryUnfurlingRegisterInfoResponse
   */
  async queryUnfurlingRegisterInfo(request: QueryUnfurlingRegisterInfoRequest): Promise<QueryUnfurlingRegisterInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUnfurlingRegisterInfoHeaders({ });
    return await this.queryUnfurlingRegisterInfoWithOptions(request, headers, runtime);
  }

  /**
   * 链接增强规则发布
   * 
   * @param request - ReleaseUnfurlingRegisterRequest
   * @param headers - ReleaseUnfurlingRegisterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReleaseUnfurlingRegisterResponse
   */
  async releaseUnfurlingRegisterWithOptions(request: ReleaseUnfurlingRegisterRequest, headers: ReleaseUnfurlingRegisterHeaders, runtime: $Util.RuntimeOptions): Promise<ReleaseUnfurlingRegisterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
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
      action: "ReleaseUnfurlingRegister",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules/publish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReleaseUnfurlingRegisterResponse>(await this.execute(params, req, runtime), new ReleaseUnfurlingRegisterResponse({}));
  }

  /**
   * 链接增强规则发布
   * 
   * @param request - ReleaseUnfurlingRegisterRequest
   * @returns ReleaseUnfurlingRegisterResponse
   */
  async releaseUnfurlingRegister(request: ReleaseUnfurlingRegisterRequest): Promise<ReleaseUnfurlingRegisterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReleaseUnfurlingRegisterHeaders({ });
    return await this.releaseUnfurlingRegisterWithOptions(request, headers, runtime);
  }

  /**
   * 移除会话机器人
   * 
   * @param request - RemoveRobotFromConversationRequest
   * @param headers - RemoveRobotFromConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveRobotFromConversationResponse
   */
  async removeRobotFromConversationWithOptions(request: RemoveRobotFromConversationRequest, headers: RemoveRobotFromConversationHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveRobotFromConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatBotUserId)) {
      body["chatBotUserId"] = request.chatBotUserId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "RemoveRobotFromConversation",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/conversations/robots/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveRobotFromConversationResponse>(await this.execute(params, req, runtime), new RemoveRobotFromConversationResponse({}));
  }

  /**
   * 移除会话机器人
   * 
   * @param request - RemoveRobotFromConversationRequest
   * @returns RemoveRobotFromConversationResponse
   */
  async removeRobotFromConversation(request: RemoveRobotFromConversationRequest): Promise<RemoveRobotFromConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveRobotFromConversationHeaders({ });
    return await this.removeRobotFromConversationWithOptions(request, headers, runtime);
  }

  /**
   * 根据关键词搜索企业内部群
   * 
   * @param request - SearchInnerGroupsRequest
   * @param headers - SearchInnerGroupsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchInnerGroupsResponse
   */
  async searchInnerGroupsWithOptions(request: SearchInnerGroupsRequest, headers: SearchInnerGroupsHeaders, runtime: $Util.RuntimeOptions): Promise<SearchInnerGroupsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.searchKey)) {
      body["searchKey"] = request.searchKey;
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
      action: "SearchInnerGroups",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/innerGroups/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SearchInnerGroupsResponse>(await this.execute(params, req, runtime), new SearchInnerGroupsResponse({}));
  }

  /**
   * 根据关键词搜索企业内部群
   * 
   * @param request - SearchInnerGroupsRequest
   * @returns SearchInnerGroupsResponse
   */
  async searchInnerGroups(request: SearchInnerGroupsRequest): Promise<SearchInnerGroupsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchInnerGroupsHeaders({ });
    return await this.searchInnerGroupsWithOptions(request, headers, runtime);
  }

  /**
   * 发送可交互式动态卡片
   * 
   * @param request - SendInteractiveCardRequest
   * @param headers - SendInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendInteractiveCardResponse
   */
  async sendInteractiveCardWithOptions(request: SendInteractiveCardRequest, headers: SendInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.atOpenIds)) {
      body["atOpenIds"] = request.atOpenIds;
    }

    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardOptions)) {
      body["cardOptions"] = request.cardOptions;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.chatBotId)) {
      body["chatBotId"] = request.chatBotId;
    }

    if (!Util.isUnset(request.conversationType)) {
      body["conversationType"] = request.conversationType;
    }

    if (!Util.isUnset(request.digitalWorkerCode)) {
      body["digitalWorkerCode"] = request.digitalWorkerCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.pullStrategy)) {
      body["pullStrategy"] = request.pullStrategy;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "SendInteractiveCard",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interactiveCards/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendInteractiveCardResponse>(await this.execute(params, req, runtime), new SendInteractiveCardResponse({}));
  }

  /**
   * 发送可交互式动态卡片
   * 
   * @param request - SendInteractiveCardRequest
   * @returns SendInteractiveCardResponse
   */
  async sendInteractiveCard(request: SendInteractiveCardRequest): Promise<SendInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInteractiveCardHeaders({ });
    return await this.sendInteractiveCardWithOptions(request, headers, runtime);
  }

  /**
   * 人与人单聊发送可交互式动态卡片
   * 
   * @param request - SendOTOInteractiveCardRequest
   * @param headers - SendOTOInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendOTOInteractiveCardResponse
   */
  async sendOTOInteractiveCardWithOptions(request: SendOTOInteractiveCardRequest, headers: SendOTOInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendOTOInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.atOpenIds)) {
      body["atOpenIds"] = request.atOpenIds;
    }

    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardOptions)) {
      body["cardOptions"] = request.cardOptions;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.pullStrategy)) {
      body["pullStrategy"] = request.pullStrategy;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "SendOTOInteractiveCard",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/privateChat/interactiveCards/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendOTOInteractiveCardResponse>(await this.execute(params, req, runtime), new SendOTOInteractiveCardResponse({}));
  }

  /**
   * 人与人单聊发送可交互式动态卡片
   * 
   * @param request - SendOTOInteractiveCardRequest
   * @returns SendOTOInteractiveCardResponse
   */
  async sendOTOInteractiveCard(request: SendOTOInteractiveCardRequest): Promise<SendOTOInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendOTOInteractiveCardHeaders({ });
    return await this.sendOTOInteractiveCardWithOptions(request, headers, runtime);
  }

  /**
   * 委托权限发消息
   * 
   * @param request - SendPersonalMessageRequest
   * @param headers - SendPersonalMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendPersonalMessageResponse
   */
  async sendPersonalMessageWithOptions(request: SendPersonalMessageRequest, headers: SendPersonalMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendPersonalMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.msgType)) {
      body["msgType"] = request.msgType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiverUid)) {
      body["receiverUid"] = request.receiverUid;
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
      action: "SendPersonalMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/me/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendPersonalMessageResponse>(await this.execute(params, req, runtime), new SendPersonalMessageResponse({}));
  }

  /**
   * 委托权限发消息
   * 
   * @param request - SendPersonalMessageRequest
   * @returns SendPersonalMessageResponse
   */
  async sendPersonalMessage(request: SendPersonalMessageRequest): Promise<SendPersonalMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendPersonalMessageHeaders({ });
    return await this.sendPersonalMessageWithOptions(request, headers, runtime);
  }

  /**
   * 机器人发送互动卡片（普通版）
   * 
   * @param request - SendRobotInteractiveCardRequest
   * @param headers - SendRobotInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendRobotInteractiveCardResponse
   */
  async sendRobotInteractiveCardWithOptions(request: SendRobotInteractiveCardRequest, headers: SendRobotInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendRobotInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackUrl)) {
      body["callbackUrl"] = request.callbackUrl;
    }

    if (!Util.isUnset(request.cardBizId)) {
      body["cardBizId"] = request.cardBizId;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.pullStrategy)) {
      body["pullStrategy"] = request.pullStrategy;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.sendOptions)) {
      body["sendOptions"] = request.sendOptions;
    }

    if (!Util.isUnset(request.singleChatReceiver)) {
      body["singleChatReceiver"] = request.singleChatReceiver;
    }

    if (!Util.isUnset(request.unionIdPrivateDataMap)) {
      body["unionIdPrivateDataMap"] = request.unionIdPrivateDataMap;
    }

    if (!Util.isUnset(request.userIdPrivateDataMap)) {
      body["userIdPrivateDataMap"] = request.userIdPrivateDataMap;
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
      action: "SendRobotInteractiveCard",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/v1.0/robot/interactiveCards/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendRobotInteractiveCardResponse>(await this.execute(params, req, runtime), new SendRobotInteractiveCardResponse({}));
  }

  /**
   * 机器人发送互动卡片（普通版）
   * 
   * @param request - SendRobotInteractiveCardRequest
   * @returns SendRobotInteractiveCardResponse
   */
  async sendRobotInteractiveCard(request: SendRobotInteractiveCardRequest): Promise<SendRobotInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendRobotInteractiveCardHeaders({ });
    return await this.sendRobotInteractiveCardWithOptions(request, headers, runtime);
  }

  /**
   * 机器人发送消息
   * 
   * @param request - SendRobotMessageRequest
   * @param headers - SendRobotMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendRobotMessageResponse
   */
  async sendRobotMessageWithOptions(request: SendRobotMessageRequest, headers: SendRobotMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendRobotMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.atAll)) {
      body["atAll"] = request.atAll;
    }

    if (!Util.isUnset(request.atAppUserId)) {
      body["atAppUserId"] = request.atAppUserId;
    }

    if (!Util.isUnset(request.atDingUserId)) {
      body["atDingUserId"] = request.atDingUserId;
    }

    if (!Util.isUnset(request.msgContent)) {
      body["msgContent"] = request.msgContent;
    }

    if (!Util.isUnset(request.msgType)) {
      body["msgType"] = request.msgType;
    }

    if (!Util.isUnset(request.openConversationIds)) {
      body["openConversationIds"] = request.openConversationIds;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "SendRobotMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/robotMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendRobotMessageResponse>(await this.execute(params, req, runtime), new SendRobotMessageResponse({}));
  }

  /**
   * 机器人发送消息
   * 
   * @param request - SendRobotMessageRequest
   * @returns SendRobotMessageResponse
   */
  async sendRobotMessage(request: SendRobotMessageRequest): Promise<SendRobotMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendRobotMessageHeaders({ });
    return await this.sendRobotMessageWithOptions(request, headers, runtime);
  }

  /**
   * 发送模板响应式可交互式卡片
   * 
   * @param request - SendTemplateInteractiveCardRequest
   * @param headers - SendTemplateInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendTemplateInteractiveCardResponse
   */
  async sendTemplateInteractiveCardWithOptions(request: SendTemplateInteractiveCardRequest, headers: SendTemplateInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendTemplateInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackUrl)) {
      body["callbackUrl"] = request.callbackUrl;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.sendOptions)) {
      body["sendOptions"] = request.sendOptions;
    }

    if (!Util.isUnset(request.singleChatReceiver)) {
      body["singleChatReceiver"] = request.singleChatReceiver;
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
      action: "SendTemplateInteractiveCard",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interactiveCards/templates/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendTemplateInteractiveCardResponse>(await this.execute(params, req, runtime), new SendTemplateInteractiveCardResponse({}));
  }

  /**
   * 发送模板响应式可交互式卡片
   * 
   * @param request - SendTemplateInteractiveCardRequest
   * @returns SendTemplateInteractiveCardResponse
   */
  async sendTemplateInteractiveCard(request: SendTemplateInteractiveCardRequest): Promise<SendTemplateInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendTemplateInteractiveCardHeaders({ });
    return await this.sendTemplateInteractiveCardWithOptions(request, headers, runtime);
  }

  /**
   * 设置侧边栏
   * 
   * @param request - SetRightPanelRequest
   * @param headers - SetRightPanelHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SetRightPanelResponse
   */
  async setRightPanelWithOptions(request: SetRightPanelRequest, headers: SetRightPanelHeaders, runtime: $Util.RuntimeOptions): Promise<SetRightPanelResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.rightPanelClosePermitted)) {
      body["rightPanelClosePermitted"] = request.rightPanelClosePermitted;
    }

    if (!Util.isUnset(request.rightPanelOpenStatus)) {
      body["rightPanelOpenStatus"] = request.rightPanelOpenStatus;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.webWndParams)) {
      body["webWndParams"] = request.webWndParams;
    }

    if (!Util.isUnset(request.width)) {
      body["width"] = request.width;
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
      action: "SetRightPanel",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/rightPanels/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetRightPanelResponse>(await this.execute(params, req, runtime), new SetRightPanelResponse({}));
  }

  /**
   * 设置侧边栏
   * 
   * @param request - SetRightPanelRequest
   * @returns SetRightPanelResponse
   */
  async setRightPanel(request: SetRightPanelRequest): Promise<SetRightPanelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetRightPanelHeaders({ });
    return await this.setRightPanelWithOptions(request, headers, runtime);
  }

  /**
   * 钉钉吊顶卡片关闭
   * 
   * @param request - TopboxCloseRequest
   * @param headers - TopboxCloseHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TopboxCloseResponse
   */
  async topboxCloseWithOptions(request: TopboxCloseRequest, headers: TopboxCloseHeaders, runtime: $Util.RuntimeOptions): Promise<TopboxCloseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationType)) {
      body["conversationType"] = request.conversationType;
    }

    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "TopboxClose",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/topBoxes/close`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<TopboxCloseResponse>(await this.execute(params, req, runtime), new TopboxCloseResponse({}));
  }

  /**
   * 钉钉吊顶卡片关闭
   * 
   * @param request - TopboxCloseRequest
   * @returns TopboxCloseResponse
   */
  async topboxClose(request: TopboxCloseRequest): Promise<TopboxCloseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TopboxCloseHeaders({ });
    return await this.topboxCloseWithOptions(request, headers, runtime);
  }

  /**
   * 钉钉吊顶卡片开启
   * 
   * @param request - TopboxOpenRequest
   * @param headers - TopboxOpenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TopboxOpenResponse
   */
  async topboxOpenWithOptions(request: TopboxOpenRequest, headers: TopboxOpenHeaders, runtime: $Util.RuntimeOptions): Promise<TopboxOpenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationType)) {
      body["conversationType"] = request.conversationType;
    }

    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.expiredTime)) {
      body["expiredTime"] = request.expiredTime;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.platforms)) {
      body["platforms"] = request.platforms;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "TopboxOpen",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/topBoxes/open`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<TopboxOpenResponse>(await this.execute(params, req, runtime), new TopboxOpenResponse({}));
  }

  /**
   * 钉钉吊顶卡片开启
   * 
   * @param request - TopboxOpenRequest
   * @returns TopboxOpenResponse
   */
  async topboxOpen(request: TopboxOpenRequest): Promise<TopboxOpenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TopboxOpenHeaders({ });
    return await this.topboxOpenWithOptions(request, headers, runtime);
  }

  /**
   * 修改群头像
   * 
   * @param request - UpdateGroupAvatarRequest
   * @param headers - UpdateGroupAvatarHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupAvatarResponse
   */
  async updateGroupAvatarWithOptions(request: UpdateGroupAvatarRequest, headers: UpdateGroupAvatarHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupAvatarResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupAvatar)) {
      body["groupAvatar"] = request.groupAvatar;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "UpdateGroupAvatar",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/groups/avatars`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateGroupAvatarResponse>(await this.execute(params, req, runtime), new UpdateGroupAvatarResponse({}));
  }

  /**
   * 修改群头像
   * 
   * @param request - UpdateGroupAvatarRequest
   * @returns UpdateGroupAvatarResponse
   */
  async updateGroupAvatar(request: UpdateGroupAvatarRequest): Promise<UpdateGroupAvatarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupAvatarHeaders({ });
    return await this.updateGroupAvatarWithOptions(request, headers, runtime);
  }

  /**
   * 修改群名称
   * 
   * @param request - UpdateGroupNameRequest
   * @param headers - UpdateGroupNameHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupNameResponse
   */
  async updateGroupNameWithOptions(request: UpdateGroupNameRequest, headers: UpdateGroupNameHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupNameResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "UpdateGroupName",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/groups/names`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateGroupNameResponse>(await this.execute(params, req, runtime), new UpdateGroupNameResponse({}));
  }

  /**
   * 修改群名称
   * 
   * @param request - UpdateGroupNameRequest
   * @returns UpdateGroupNameResponse
   */
  async updateGroupName(request: UpdateGroupNameRequest): Promise<UpdateGroupNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupNameHeaders({ });
    return await this.updateGroupNameWithOptions(request, headers, runtime);
  }

  /**
   * 设置场景群权限项
   * 
   * @param request - UpdateGroupPermissionRequest
   * @param headers - UpdateGroupPermissionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupPermissionResponse
   */
  async updateGroupPermissionWithOptions(request: UpdateGroupPermissionRequest, headers: UpdateGroupPermissionHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupPermissionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.permissionGroup)) {
      body["permissionGroup"] = request.permissionGroup;
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
      action: "UpdateGroupPermission",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/permissions`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateGroupPermissionResponse>(await this.execute(params, req, runtime), new UpdateGroupPermissionResponse({}));
  }

  /**
   * 设置场景群权限项
   * 
   * @param request - UpdateGroupPermissionRequest
   * @returns UpdateGroupPermissionResponse
   */
  async updateGroupPermission(request: UpdateGroupPermissionRequest): Promise<UpdateGroupPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupPermissionHeaders({ });
    return await this.updateGroupPermissionWithOptions(request, headers, runtime);
  }

  /**
   * 更新群管理员
   * 
   * @param request - UpdateGroupSubAdminRequest
   * @param headers - UpdateGroupSubAdminHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupSubAdminResponse
   */
  async updateGroupSubAdminWithOptions(request: UpdateGroupSubAdminRequest, headers: UpdateGroupSubAdminHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupSubAdminResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "UpdateGroupSubAdmin",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/subAdmins`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateGroupSubAdminResponse>(await this.execute(params, req, runtime), new UpdateGroupSubAdminResponse({}));
  }

  /**
   * 更新群管理员
   * 
   * @param request - UpdateGroupSubAdminRequest
   * @returns UpdateGroupSubAdminResponse
   */
  async updateGroupSubAdmin(request: UpdateGroupSubAdminRequest): Promise<UpdateGroupSubAdminResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupSubAdminHeaders({ });
    return await this.updateGroupSubAdminWithOptions(request, headers, runtime);
  }

  /**
   * 更新可交互式动态卡片
   * 
   * @param request - UpdateInteractiveCardRequest
   * @param headers - UpdateInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInteractiveCardResponse
   */
  async updateInteractiveCardWithOptions(request: UpdateInteractiveCardRequest, headers: UpdateInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.cardOptions)) {
      body["cardOptions"] = request.cardOptions;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
    }

    if (!Util.isUnset(request.privateData)) {
      body["privateData"] = request.privateData;
    }

    if (!Util.isUnset(request.userIdType)) {
      body["userIdType"] = request.userIdType;
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
      action: "UpdateInteractiveCard",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interactiveCards`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInteractiveCardResponse>(await this.execute(params, req, runtime), new UpdateInteractiveCardResponse({}));
  }

  /**
   * 更新可交互式动态卡片
   * 
   * @param request - UpdateInteractiveCardRequest
   * @returns UpdateInteractiveCardResponse
   */
  async updateInteractiveCard(request: UpdateInteractiveCardRequest): Promise<UpdateInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInteractiveCardHeaders({ });
    return await this.updateInteractiveCardWithOptions(request, headers, runtime);
  }

  /**
   * 设置群成员禁言状态
   * 
   * @param request - UpdateMemberBanWordsRequest
   * @param headers - UpdateMemberBanWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateMemberBanWordsResponse
   */
  async updateMemberBanWordsWithOptions(request: UpdateMemberBanWordsRequest, headers: UpdateMemberBanWordsHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMemberBanWordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.muteDuration)) {
      body["muteDuration"] = request.muteDuration;
    }

    if (!Util.isUnset(request.muteStatus)) {
      body["muteStatus"] = request.muteStatus;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.userIdList)) {
      body["userIdList"] = request.userIdList;
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
      action: "UpdateMemberBanWords",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/muteMembers/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<UpdateMemberBanWordsResponse>(await this.execute(params, req, runtime), new UpdateMemberBanWordsResponse({}));
  }

  /**
   * 设置群成员禁言状态
   * 
   * @param request - UpdateMemberBanWordsRequest
   * @returns UpdateMemberBanWordsResponse
   */
  async updateMemberBanWords(request: UpdateMemberBanWordsRequest): Promise<UpdateMemberBanWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMemberBanWordsHeaders({ });
    return await this.updateMemberBanWordsWithOptions(request, headers, runtime);
  }

  /**
   * 更新群成员的群昵称
   * 
   * @param request - UpdateMemberGroupNickRequest
   * @param headers - UpdateMemberGroupNickHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateMemberGroupNickResponse
   */
  async updateMemberGroupNickWithOptions(request: UpdateMemberGroupNickRequest, headers: UpdateMemberGroupNickHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateMemberGroupNickResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupNick)) {
      body["groupNick"] = request.groupNick;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "UpdateMemberGroupNick",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/members/groupNicks`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateMemberGroupNickResponse>(await this.execute(params, req, runtime), new UpdateMemberGroupNickResponse({}));
  }

  /**
   * 更新群成员的群昵称
   * 
   * @param request - UpdateMemberGroupNickRequest
   * @returns UpdateMemberGroupNickResponse
   */
  async updateMemberGroupNick(request: UpdateMemberGroupNickRequest): Promise<UpdateMemberGroupNickResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMemberGroupNickHeaders({ });
    return await this.updateMemberGroupNickWithOptions(request, headers, runtime);
  }

  /**
   * 修改组织里的机器人
   * 
   * @param request - UpdateRobotInOrgRequest
   * @param headers - UpdateRobotInOrgHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateRobotInOrgResponse
   */
  async updateRobotInOrgWithOptions(request: UpdateRobotInOrgRequest, headers: UpdateRobotInOrgHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRobotInOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.brief)) {
      body["brief"] = request.brief;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.outgoingToken)) {
      body["outgoingToken"] = request.outgoingToken;
    }

    if (!Util.isUnset(request.outgoingUrl)) {
      body["outgoingUrl"] = request.outgoingUrl;
    }

    if (!Util.isUnset(request.previewMediaId)) {
      body["previewMediaId"] = request.previewMediaId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "UpdateRobotInOrg",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/organizations/robots`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateRobotInOrgResponse>(await this.execute(params, req, runtime), new UpdateRobotInOrgResponse({}));
  }

  /**
   * 修改组织里的机器人
   * 
   * @param request - UpdateRobotInOrgRequest
   * @returns UpdateRobotInOrgResponse
   */
  async updateRobotInOrg(request: UpdateRobotInOrgRequest): Promise<UpdateRobotInOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRobotInOrgHeaders({ });
    return await this.updateRobotInOrgWithOptions(request, headers, runtime);
  }

  /**
   * 机器人更新可交互式卡片(个人、企业)
   * 
   * @param request - UpdateRobotInteractiveCardRequest
   * @param headers - UpdateRobotInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateRobotInteractiveCardResponse
   */
  async updateRobotInteractiveCardWithOptions(request: UpdateRobotInteractiveCardRequest, headers: UpdateRobotInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateRobotInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardBizId)) {
      body["cardBizId"] = request.cardBizId;
    }

    if (!Util.isUnset(request.cardData)) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset(request.unionIdPrivateDataMap)) {
      body["unionIdPrivateDataMap"] = request.unionIdPrivateDataMap;
    }

    if (!Util.isUnset(request.updateOptions)) {
      body["updateOptions"] = request.updateOptions;
    }

    if (!Util.isUnset(request.userIdPrivateDataMap)) {
      body["userIdPrivateDataMap"] = request.userIdPrivateDataMap;
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
      action: "UpdateRobotInteractiveCard",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/robots/interactiveCards`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateRobotInteractiveCardResponse>(await this.execute(params, req, runtime), new UpdateRobotInteractiveCardResponse({}));
  }

  /**
   * 机器人更新可交互式卡片(个人、企业)
   * 
   * @param request - UpdateRobotInteractiveCardRequest
   * @returns UpdateRobotInteractiveCardResponse
   */
  async updateRobotInteractiveCard(request: UpdateRobotInteractiveCardRequest): Promise<UpdateRobotInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRobotInteractiveCardHeaders({ });
    return await this.updateRobotInteractiveCardWithOptions(request, headers, runtime);
  }

  /**
   * 设置群成员的群角色
   * 
   * @param request - UpdateTheGroupRolesOfGroupMemberRequest
   * @param headers - UpdateTheGroupRolesOfGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateTheGroupRolesOfGroupMemberResponse
   */
  async updateTheGroupRolesOfGroupMemberWithOptions(request: UpdateTheGroupRolesOfGroupMemberRequest, headers: UpdateTheGroupRolesOfGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTheGroupRolesOfGroupMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openRoleIds)) {
      body["openRoleIds"] = request.openRoleIds;
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
      action: "UpdateTheGroupRolesOfGroupMember",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/sceneGroups/members/groupRoles`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTheGroupRolesOfGroupMemberResponse>(await this.execute(params, req, runtime), new UpdateTheGroupRolesOfGroupMemberResponse({}));
  }

  /**
   * 设置群成员的群角色
   * 
   * @param request - UpdateTheGroupRolesOfGroupMemberRequest
   * @returns UpdateTheGroupRolesOfGroupMemberResponse
   */
  async updateTheGroupRolesOfGroupMember(request: UpdateTheGroupRolesOfGroupMemberRequest): Promise<UpdateTheGroupRolesOfGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTheGroupRolesOfGroupMemberHeaders({ });
    return await this.updateTheGroupRolesOfGroupMemberWithOptions(request, headers, runtime);
  }

  /**
   * 编辑链接增强注册规则
   * 
   * @param request - UpdateUnfurlingRegisterRequest
   * @param headers - UpdateUnfurlingRegisterHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateUnfurlingRegisterResponse
   */
  async updateUnfurlingRegisterWithOptions(request: UpdateUnfurlingRegisterRequest, headers: UpdateUnfurlingRegisterHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUnfurlingRegisterResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.apiSecret)) {
      body["apiSecret"] = request.apiSecret;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.callbackUrl)) {
      body["callbackUrl"] = request.callbackUrl;
    }

    if (!Util.isUnset(request.cardTemplateId)) {
      body["cardTemplateId"] = request.cardTemplateId;
    }

    if (!Util.isUnset(request.domain)) {
      body["domain"] = request.domain;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.path)) {
      body["path"] = request.path;
    }

    if (!Util.isUnset(request.ruleDesc)) {
      body["ruleDesc"] = request.ruleDesc;
    }

    if (!Util.isUnset(request.ruleMatchType)) {
      body["ruleMatchType"] = request.ruleMatchType;
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
      action: "UpdateUnfurlingRegister",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateUnfurlingRegisterResponse>(await this.execute(params, req, runtime), new UpdateUnfurlingRegisterResponse({}));
  }

  /**
   * 编辑链接增强注册规则
   * 
   * @param request - UpdateUnfurlingRegisterRequest
   * @returns UpdateUnfurlingRegisterResponse
   */
  async updateUnfurlingRegister(request: UpdateUnfurlingRegisterRequest): Promise<UpdateUnfurlingRegisterResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUnfurlingRegisterHeaders({ });
    return await this.updateUnfurlingRegisterWithOptions(request, headers, runtime);
  }

  /**
   * 链接增强规则状态更新
   * 
   * @param request - UpdateUnfurlingRegisterStatusRequest
   * @param headers - UpdateUnfurlingRegisterStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateUnfurlingRegisterStatusResponse
   */
  async updateUnfurlingRegisterStatusWithOptions(request: UpdateUnfurlingRegisterStatusRequest, headers: UpdateUnfurlingRegisterStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateUnfurlingRegisterStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.id)) {
      body["id"] = request.id;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
      action: "UpdateUnfurlingRegisterStatus",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/unfurling/rules/statuses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateUnfurlingRegisterStatusResponse>(await this.execute(params, req, runtime), new UpdateUnfurlingRegisterStatusResponse({}));
  }

  /**
   * 链接增强规则状态更新
   * 
   * @param request - UpdateUnfurlingRegisterStatusRequest
   * @returns UpdateUnfurlingRegisterStatusResponse
   */
  async updateUnfurlingRegisterStatus(request: UpdateUnfurlingRegisterStatusRequest): Promise<UpdateUnfurlingRegisterStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateUnfurlingRegisterStatusHeaders({ });
    return await this.updateUnfurlingRegisterStatusWithOptions(request, headers, runtime);
  }

  /**
   * 添加群成员
   * 
   * @param request - AddGroupMemberRequest
   * @param headers - AddGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddGroupMemberResponse
   */
  async addGroupMemberWithOptions(request: AddGroupMemberRequest, headers: AddGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<AddGroupMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserIds)) {
      body["appUserIds"] = request.appUserIds;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "addGroupMember",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/groups/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddGroupMemberResponse>(await this.execute(params, req, runtime), new AddGroupMemberResponse({}));
  }

  /**
   * 添加群成员
   * 
   * @param request - AddGroupMemberRequest
   * @returns AddGroupMemberResponse
   */
  async addGroupMember(request: AddGroupMemberRequest): Promise<AddGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddGroupMemberHeaders({ });
    return await this.addGroupMemberWithOptions(request, headers, runtime);
  }

  /**
   * 移除群成员
   * 
   * @param request - RemoveGroupMemberRequest
   * @param headers - RemoveGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveGroupMemberResponse
   */
  async removeGroupMemberWithOptions(request: RemoveGroupMemberRequest, headers: RemoveGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveGroupMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserIds)) {
      body["appUserIds"] = request.appUserIds;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "removeGroupMember",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/groups/members/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveGroupMemberResponse>(await this.execute(params, req, runtime), new RemoveGroupMemberResponse({}));
  }

  /**
   * 移除群成员
   * 
   * @param request - RemoveGroupMemberRequest
   * @returns RemoveGroupMemberResponse
   */
  async removeGroupMember(request: RemoveGroupMemberRequest): Promise<RemoveGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveGroupMemberHeaders({ });
    return await this.removeGroupMemberWithOptions(request, headers, runtime);
  }

  /**
   * 发送ToC消息
   * 
   * @param request - SendDingMessageRequest
   * @param headers - SendDingMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendDingMessageResponse
   */
  async sendDingMessageWithOptions(request: SendDingMessageRequest, headers: SendDingMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendDingMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.message)) {
      body["message"] = request.message;
    }

    if (!Util.isUnset(request.messageType)) {
      body["messageType"] = request.messageType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiverId)) {
      body["receiverId"] = request.receiverId;
    }

    if (!Util.isUnset(request.senderId)) {
      body["senderId"] = request.senderId;
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
      action: "sendDingMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/dingMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendDingMessageResponse>(await this.execute(params, req, runtime), new SendDingMessageResponse({}));
  }

  /**
   * 发送ToC消息
   * 
   * @param request - SendDingMessageRequest
   * @returns SendDingMessageResponse
   */
  async sendDingMessage(request: SendDingMessageRequest): Promise<SendDingMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendDingMessageHeaders({ });
    return await this.sendDingMessageWithOptions(request, headers, runtime);
  }

  /**
   * 发送ToB消息
   * 
   * @param request - SendMessageRequest
   * @param headers - SendMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendMessageResponse
   */
  async sendMessageWithOptions(request: SendMessageRequest, headers: SendMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.message)) {
      body["message"] = request.message;
    }

    if (!Util.isUnset(request.messageType)) {
      body["messageType"] = request.messageType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiverId)) {
      body["receiverId"] = request.receiverId;
    }

    if (!Util.isUnset(request.senderId)) {
      body["senderId"] = request.senderId;
    }

    if (!Util.isUnset(request.sourceInfos)) {
      body["sourceInfos"] = request.sourceInfos;
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
      action: "sendMessage",
      version: "im_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/im/interconnections/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMessageResponse>(await this.execute(params, req, runtime), new SendMessageResponse({}));
  }

  /**
   * 发送ToB消息
   * 
   * @param request - SendMessageRequest
   * @returns SendMessageResponse
   */
  async sendMessage(request: SendMessageRequest): Promise<SendMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageHeaders({ });
    return await this.sendMessageWithOptions(request, headers, runtime);
  }

}
