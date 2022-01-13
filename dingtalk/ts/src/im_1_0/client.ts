// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  appUserId?: string;
  appUserMobileNumber?: string;
  appUserName?: string;
  dingCorpId?: string;
  dingUserId?: string;
  msgPageSettingId?: number;
  static names(): { [key: string]: string } {
    return {
      appUserAvatar: 'appUserAvatar',
      appUserAvatarType: 'appUserAvatarType',
      appUserId: 'appUserId',
      appUserMobileNumber: 'appUserMobileNumber',
      appUserName: 'appUserName',
      dingCorpId: 'dingCorpId',
      dingUserId: 'dingUserId',
      msgPageSettingId: 'msgPageSettingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserAvatar: 'string',
      appUserAvatarType: 'number',
      appUserId: 'string',
      appUserMobileNumber: 'string',
      appUserName: 'string',
      dingCorpId: 'string',
      dingUserId: 'string',
      msgPageSettingId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInterconnectionUrlResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: GetInterconnectionUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInterconnectionUrlResponseBody,
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
  openConversationId?: string;
  ownerUserId?: string;
  success?: boolean;
  templateId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      groupUrl: 'groupUrl',
      icon: 'icon',
      openConversationId: 'openConversationId',
      ownerUserId: 'ownerUserId',
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
  headers: { [key: string]: string };
  body: GetSceneGroupInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  coolAppCode?: string;
  cursor?: string;
  openConversationId?: string;
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
  hasMore?: boolean;
  memberUserIds?: string[];
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
  headers: { [key: string]: string };
  body: GetSceneGroupMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSceneGroupMembersResponseBody,
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
  cardData?: InteractiveCardCreateInstanceRequestCardData;
  cardTemplateId?: string;
  chatBotId?: string;
  conversationType?: number;
  openConversationId?: string;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
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
  headers: { [key: string]: string };
  body: InteractiveCardCreateInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: InteractiveCardCreateInstanceResponseBody,
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
  openConversationId?: string;
  openRoleId?: string;
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
  headers: { [key: string]: string };
  body: QueryMembersOfGroupRoleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMembersOfGroupRoleResponseBody,
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
  cardData?: SendInteractiveCardRequestCardData;
  cardTemplateId?: string;
  chatBotId?: string;
  conversationType?: number;
  openConversationId?: string;
  outTrackId?: string;
  privateData?: { [key: string]: PrivateDataValue };
  receiverUserIdList?: string[];
  robotCode?: string;
  userIdType?: number;
  static names(): { [key: string]: string } {
    return {
      atOpenIds: 'atOpenIds',
      callbackRouteKey: 'callbackRouteKey',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      chatBotId: 'chatBotId',
      conversationType: 'conversationType',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      privateData: 'privateData',
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
      cardTemplateId: 'string',
      chatBotId: 'string',
      conversationType: 'number',
      openConversationId: 'string',
      outTrackId: 'string',
      privateData: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateDataValue },
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
  headers: { [key: string]: string };
  body: SendInteractiveCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendInteractiveCardResponseBody,
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
  cardBizId?: string;
  cardData?: string;
  cardTemplateId?: string;
  openConversationId?: string;
  robotCode?: string;
  sendOptions?: SendRobotInteractiveCardRequestSendOptions;
  singleChatReceiver?: string;
  static names(): { [key: string]: string } {
    return {
      cardBizId: 'cardBizId',
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      openConversationId: 'openConversationId',
      robotCode: 'robotCode',
      sendOptions: 'sendOptions',
      singleChatReceiver: 'singleChatReceiver',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardBizId: 'string',
      cardData: 'string',
      cardTemplateId: 'string',
      openConversationId: 'string',
      robotCode: 'string',
      sendOptions: SendRobotInteractiveCardRequestSendOptions,
      singleChatReceiver: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotInteractiveCardResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: SendRobotInteractiveCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendRobotInteractiveCardResponseBody,
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
  callbackUrl?: string;
  cardData?: string;
  cardTemplateId?: string;
  openConversationId?: string;
  outTrackId?: string;
  robotCode?: string;
  sendOptions?: SendTemplateInteractiveCardRequestSendOptions;
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
  headers: { [key: string]: string };
  body: SendTemplateInteractiveCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendTemplateInteractiveCardResponseBody,
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
  coolAppCode?: string;
  openConversationId?: string;
  outTrackId?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      openConversationId: 'string',
      outTrackId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopboxCloseResponse extends $tea.Model {
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
  coolAppCode?: string;
  expiredTime?: number;
  openConversationId?: string;
  outTrackId?: string;
  platforms?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      expiredTime: 'expiredTime',
      openConversationId: 'openConversationId',
      outTrackId: 'outTrackId',
      platforms: 'platforms',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      expiredTime: 'number',
      openConversationId: 'string',
      outTrackId: 'string',
      platforms: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopboxOpenResponse extends $tea.Model {
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
  headers: { [key: string]: string };
  body: UpdateGroupPermissionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  openConversationId?: string;
  role?: number;
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
  headers: { [key: string]: string };
  body: UpdateGroupSubAdminResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: UpdateInteractiveCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInteractiveCardResponseBody,
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
  groupNick?: string;
  openConversationId?: string;
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
  headers: { [key: string]: string };
  body: UpdateMemberGroupNickResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateMemberGroupNickResponseBody,
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
  openConversationId?: string;
  openRoleIds?: string[];
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
  headers: { [key: string]: string };
  body: UpdateTheGroupRolesOfGroupMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateTheGroupRolesOfGroupMemberResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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

export class SendInteractiveCardResponseBodyResult extends $tea.Model {
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

export class SendRobotInteractiveCardRequestSendOptions extends $tea.Model {
  atAll?: boolean;
  atUserListJson?: string;
  cardPropertyJson?: string;
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
  atAll?: boolean;
  atUserListJson?: string;
  cardPropertyJson?: string;
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async getInterconnectionUrl(request: GetInterconnectionUrlRequest): Promise<GetInterconnectionUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInterconnectionUrlHeaders({ });
    return await this.getInterconnectionUrlWithOptions(request, headers, runtime);
  }

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

    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.dingUserId)) {
      body["dingUserId"] = request.dingUserId;
    }

    if (!Util.isUnset(request.msgPageSettingId)) {
      body["msgPageSettingId"] = request.msgPageSettingId;
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
    return $tea.cast<GetInterconnectionUrlResponse>(await this.doROARequest("GetInterconnectionUrl", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/sessions/urls`, "json", req, runtime), new GetInterconnectionUrlResponse({}));
  }

  async getSceneGroupInfo(request: GetSceneGroupInfoRequest): Promise<GetSceneGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSceneGroupInfoHeaders({ });
    return await this.getSceneGroupInfoWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetSceneGroupInfoResponse>(await this.doROARequest("GetSceneGroupInfo", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/sceneGroups/query`, "json", req, runtime), new GetSceneGroupInfoResponse({}));
  }

  async getSceneGroupMembers(request: GetSceneGroupMembersRequest): Promise<GetSceneGroupMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSceneGroupMembersHeaders({ });
    return await this.getSceneGroupMembersWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GetSceneGroupMembersResponse>(await this.doROARequest("GetSceneGroupMembers", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/sceneGroups/members/query`, "json", req, runtime), new GetSceneGroupMembersResponse({}));
  }

  async interactiveCardCreateInstance(request: InteractiveCardCreateInstanceRequest): Promise<InteractiveCardCreateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InteractiveCardCreateInstanceHeaders({ });
    return await this.interactiveCardCreateInstanceWithOptions(request, headers, runtime);
  }

  async interactiveCardCreateInstanceWithOptions(request: InteractiveCardCreateInstanceRequest, headers: InteractiveCardCreateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<InteractiveCardCreateInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset($tea.toMap(request.cardData))) {
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
    return $tea.cast<InteractiveCardCreateInstanceResponse>(await this.doROARequest("InteractiveCardCreateInstance", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interactiveCards/instances`, "json", req, runtime), new InteractiveCardCreateInstanceResponse({}));
  }

  async queryMembersOfGroupRole(request: QueryMembersOfGroupRoleRequest): Promise<QueryMembersOfGroupRoleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMembersOfGroupRoleHeaders({ });
    return await this.queryMembersOfGroupRoleWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryMembersOfGroupRoleResponse>(await this.doROARequest("QueryMembersOfGroupRole", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/sceneGroups/roles/members/query`, "json", req, runtime), new QueryMembersOfGroupRoleResponse({}));
  }

  async sendInteractiveCard(request: SendInteractiveCardRequest): Promise<SendInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInteractiveCardHeaders({ });
    return await this.sendInteractiveCardWithOptions(request, headers, runtime);
  }

  async sendInteractiveCardWithOptions(request: SendInteractiveCardRequest, headers: SendInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.atOpenIds)) {
      body["atOpenIds"] = request.atOpenIds;
    }

    if (!Util.isUnset(request.callbackRouteKey)) {
      body["callbackRouteKey"] = request.callbackRouteKey;
    }

    if (!Util.isUnset($tea.toMap(request.cardData))) {
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
    return $tea.cast<SendInteractiveCardResponse>(await this.doROARequest("SendInteractiveCard", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interactiveCards/send`, "json", req, runtime), new SendInteractiveCardResponse({}));
  }

  async sendRobotInteractiveCard(request: SendRobotInteractiveCardRequest): Promise<SendRobotInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendRobotInteractiveCardHeaders({ });
    return await this.sendRobotInteractiveCardWithOptions(request, headers, runtime);
  }

  async sendRobotInteractiveCardWithOptions(request: SendRobotInteractiveCardRequest, headers: SendRobotInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendRobotInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset($tea.toMap(request.sendOptions))) {
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
    return $tea.cast<SendRobotInteractiveCardResponse>(await this.doROARequest("SendRobotInteractiveCard", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/v1.0/robot/interactiveCards/send`, "json", req, runtime), new SendRobotInteractiveCardResponse({}));
  }

  async sendTemplateInteractiveCard(request: SendTemplateInteractiveCardRequest): Promise<SendTemplateInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendTemplateInteractiveCardHeaders({ });
    return await this.sendTemplateInteractiveCardWithOptions(request, headers, runtime);
  }

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

    if (!Util.isUnset($tea.toMap(request.sendOptions))) {
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
    return $tea.cast<SendTemplateInteractiveCardResponse>(await this.doROARequest("SendTemplateInteractiveCard", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interactiveCards/templates/send`, "json", req, runtime), new SendTemplateInteractiveCardResponse({}));
  }

  async topboxClose(request: TopboxCloseRequest): Promise<TopboxCloseResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TopboxCloseHeaders({ });
    return await this.topboxCloseWithOptions(request, headers, runtime);
  }

  async topboxCloseWithOptions(request: TopboxCloseRequest, headers: TopboxCloseHeaders, runtime: $Util.RuntimeOptions): Promise<TopboxCloseResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.outTrackId)) {
      body["outTrackId"] = request.outTrackId;
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
    return $tea.cast<TopboxCloseResponse>(await this.doROARequest("TopboxClose", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/topBoxes/close`, "none", req, runtime), new TopboxCloseResponse({}));
  }

  async topboxOpen(request: TopboxOpenRequest): Promise<TopboxOpenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TopboxOpenHeaders({ });
    return await this.topboxOpenWithOptions(request, headers, runtime);
  }

  async topboxOpenWithOptions(request: TopboxOpenRequest, headers: TopboxOpenHeaders, runtime: $Util.RuntimeOptions): Promise<TopboxOpenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    return $tea.cast<TopboxOpenResponse>(await this.doROARequest("TopboxOpen", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/topBoxes/open`, "none", req, runtime), new TopboxOpenResponse({}));
  }

  async updateGroupPermission(request: UpdateGroupPermissionRequest): Promise<UpdateGroupPermissionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupPermissionHeaders({ });
    return await this.updateGroupPermissionWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateGroupPermissionResponse>(await this.doROARequest("UpdateGroupPermission", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/sceneGroups/permissions`, "json", req, runtime), new UpdateGroupPermissionResponse({}));
  }

  async updateGroupSubAdmin(request: UpdateGroupSubAdminRequest): Promise<UpdateGroupSubAdminResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupSubAdminHeaders({ });
    return await this.updateGroupSubAdminWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateGroupSubAdminResponse>(await this.doROARequest("UpdateGroupSubAdmin", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/sceneGroups/subAdmins`, "json", req, runtime), new UpdateGroupSubAdminResponse({}));
  }

  async updateInteractiveCard(request: UpdateInteractiveCardRequest): Promise<UpdateInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInteractiveCardHeaders({ });
    return await this.updateInteractiveCardWithOptions(request, headers, runtime);
  }

  async updateInteractiveCardWithOptions(request: UpdateInteractiveCardRequest, headers: UpdateInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInteractiveCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.cardData))) {
      body["cardData"] = request.cardData;
    }

    if (!Util.isUnset($tea.toMap(request.cardOptions))) {
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
    return $tea.cast<UpdateInteractiveCardResponse>(await this.doROARequest("UpdateInteractiveCard", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/interactiveCards`, "json", req, runtime), new UpdateInteractiveCardResponse({}));
  }

  async updateMemberGroupNick(request: UpdateMemberGroupNickRequest): Promise<UpdateMemberGroupNickResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMemberGroupNickHeaders({ });
    return await this.updateMemberGroupNickWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateMemberGroupNickResponse>(await this.doROARequest("UpdateMemberGroupNick", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/sceneGroups/members/groupNicks`, "json", req, runtime), new UpdateMemberGroupNickResponse({}));
  }

  async updateTheGroupRolesOfGroupMember(request: UpdateTheGroupRolesOfGroupMemberRequest): Promise<UpdateTheGroupRolesOfGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTheGroupRolesOfGroupMemberHeaders({ });
    return await this.updateTheGroupRolesOfGroupMemberWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateTheGroupRolesOfGroupMemberResponse>(await this.doROARequest("UpdateTheGroupRolesOfGroupMember", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/sceneGroups/members/groupRoles`, "json", req, runtime), new UpdateTheGroupRolesOfGroupMemberResponse({}));
  }

}
