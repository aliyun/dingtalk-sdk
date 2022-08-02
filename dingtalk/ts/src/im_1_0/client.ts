// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  headers: { [key: string]: string };
  body: AutoOpenDingTalkConnectResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AutoOpenDingTalkConnectResponseBody,
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
  maxResults?: number;
  nextToken?: string;
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
  hasMore?: boolean;
  memberUserIds?: string[];
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
  headers: { [key: string]: string };
  body: BatchQueryGroupMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  action?: string;
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
  headers: { [key: string]: string };
  body: CardTemplateBuildActionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CardTemplateBuildActionResponseBody,
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
  headers: { [key: string]: string };
  body: ChatIdToOpenConversationIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class ChatSubAdminUpdateResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: ChatSubAdminUpdateResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ChatSubAdminUpdateResponseBody,
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
  appUserId?: string;
  groupAvatar?: string;
  groupName?: string;
  groupOwnerId?: string;
  groupTemplateId?: string;
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
  chatId?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCoupleGroupConversationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCoupleGroupConversationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  groupAvatar?: string;
  groupName?: string;
  groupOwnerId?: string;
  groupTemplateId?: string;
  operatorId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      groupAvatar: 'groupAvatar',
      groupName: 'groupName',
      groupOwnerId: 'groupOwnerId',
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
  appUserIds?: string[];
  chatId?: string;
  openConversationId?: string;
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      appUserIds: 'appUserIds',
      chatId: 'chatId',
      openConversationId: 'openConversationId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserIds: { 'type': 'array', 'itemType': 'string' },
      chatId: 'string',
      openConversationId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupConversationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateGroupConversationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: CreateInterconnectionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateInterconnectionResponseBody,
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
  appUserId?: string;
  businessUniqueKey?: string;
  groupAvatar?: string;
  groupName?: string;
  groupTemplateId?: string;
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
  chatId?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateStoreGroupConversationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateStoreGroupConversationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateStoreGroupConversationResponseBody,
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
  appUserId?: string;
  channelCode?: string;
  openConversationId?: string;
  sourceCode?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUserId: 'appUserId',
      channelCode: 'channelCode',
      openConversationId: 'openConversationId',
      sourceCode: 'sourceCode',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUserId: 'string',
      channelCode: 'string',
      openConversationId: 'string',
      sourceCode: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationUrlResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: GetConversationUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetConversationUrlResponseBody,
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
  appUserId?: string;
  appUserMobileNumber?: string;
  appUserName?: string;
  msgPageType?: number;
  qrCode?: string;
  signature?: string;
  sourceCode?: string;
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
  banWordsMode?: number;
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
  effectiveDuration?: string;
  openConversationId?: string;
  operator?: string;
  options?: { [key: string]: any };
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
  actualPrice?: number;
  createdAt?: number;
  currentCapacity?: number;
  currentEffectUntil?: number;
  discount?: number;
  extInfo?: { [key: string]: any };
  groupOwner?: string;
  groupTitle?: string;
  markedPrice?: number;
  memberCount?: number;
  openConversationId?: string;
  operator?: string;
  targetCapacity?: number;
  targetEffectUntil?: number;
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
  headers: { [key: string]: string };
  body: GroupCapacityInquiryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  operator?: string;
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

export class GroupCapacityOrderConfirmResponse extends $tea.Model {
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
  actualPrice?: number;
  currentCapacity?: number;
  currentEffectUntil?: number;
  discount?: number;
  extInfo?: { [key: string]: any };
  markedPrice?: number;
  openConversationId?: string;
  operator?: string;
  targetCapacity?: number;
  targetEffectUntil?: number;
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
  actualPrice?: number;
  currentCapacity?: number;
  currentEffectUntil?: number;
  discount?: number;
  extInfo?: { [key: string]: string };
  markedPrice?: number;
  openConversationId?: string;
  operator?: string;
  orderId?: string;
  targetCapacity?: number;
  targetEffectUntil?: number;
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
  headers: { [key: string]: string };
  body: GroupCapacityOrderPlaceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  createdAfter?: number;
  groupId?: string;
  groupMemberSamples?: string[];
  groupOwner?: string;
  groupTitleKeywords?: string[];
  groupUrl?: string;
  maxResults?: number;
  membersOver?: number;
  nextToken?: string;
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
  hasMore?: boolean;
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
  headers: { [key: string]: string };
  body: GroupManageQueryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  capacityLimit?: number;
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

export class QueryGroupInfoByMemberAuthResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: QueryGroupInfoByMemberAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  groupMembers?: QueryGroupMemberResponseBodyGroupMembers[];
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
  headers: { [key: string]: string };
  body: QueryGroupMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  headers: { [key: string]: string };
  body: QueryGroupMemberByMemberAuthResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  openConversationId?: string;
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
  groupMuteMode?: boolean;
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
  headers: { [key: string]: string };
  body: QueryGroupMuteStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGroupMuteStatusResponseBody,
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
  groupMembers?: QuerySingleGroupRequestGroupMembers[];
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
  headers: { [key: string]: string };
  body: QuerySingleGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  appUserId?: string;
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
  headers: { [key: string]: string };
  body: QueryUnReadMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUnReadMessageResponseBody,
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
  cardOptions?: SendInteractiveCardRequestCardOptions;
  cardTemplateId?: string;
  chatBotId?: string;
  conversationType?: number;
  openConversationId?: string;
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
  callbackUrl?: string;
  cardBizId?: string;
  cardData?: string;
  cardTemplateId?: string;
  openConversationId?: string;
  pullStrategy?: boolean;
  robotCode?: string;
  sendOptions?: SendRobotInteractiveCardRequestSendOptions;
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
  atAppUserId?: string;
  atDingUserId?: string;
  msgContent?: string;
  msgType?: string;
  openConversationIds?: string[];
  static names(): { [key: string]: string } {
    return {
      atAll: 'atAll',
      atAppUserId: 'atAppUserId',
      atDingUserId: 'atDingUserId',
      msgContent: 'msgContent',
      msgType: 'msgType',
      openConversationIds: 'openConversationIds',
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
  headers: { [key: string]: string };
  body: SendRobotMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  conversationType?: number;
  coolAppCode?: string;
  openConversationId?: string;
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
  conversationType?: number;
  coolAppCode?: string;
  expiredTime?: number;
  openConversationId?: string;
  outTrackId?: string;
  platforms?: string;
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
  groupAvatar?: string;
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
  headers: { [key: string]: string };
  body: UpdateGroupAvatarResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  groupName?: string;
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
  headers: { [key: string]: string };
  body: UpdateGroupNameResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  muteDuration?: number;
  muteStatus?: number;
  openConversationId?: string;
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
  cardBizId?: string;
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
  headers: { [key: string]: string };
  body: UpdateRobotInteractiveCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  openConversationId?: string;
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
  appUserIds?: string[];
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
  headers: { [key: string]: string };
  body: AddGroupMemberResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  openConversationId?: string;
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

export class RemoveGroupMemberResponse extends $tea.Model {
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
  code?: string;
  message?: string;
  messageType?: string;
  openConversationId?: string;
  receiverId?: string;
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
  headers: { [key: string]: string };
  body: SendDingMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  message?: string;
  messageType?: string;
  openConversationId?: string;
  receiverId?: string;
  senderId?: string;
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
  headers: { [key: string]: string };
  body: SendMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendMessageResponseBody,
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

export class CreateInterconnectionRequestInterconnections extends $tea.Model {
  appUserAvatar?: string;
  appUserAvatarMediaType?: number;
  appUserDynamics?: string;
  appUserId?: string;
  appUserMobile?: string;
  appUserName?: string;
  channelCode?: string;
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

export class GroupManageQueryResponseBodyGroupInfoList extends $tea.Model {
  banWordsMode?: number;
  capacity?: number;
  createdAt?: number;
  extInfo?: { [key: string]: any };
  groupAdminList?: string[];
  groupOwner?: string;
  groupTitle?: string;
  memberCount?: number;
  openConversationId?: string;
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

export class QueryGroupMemberResponseBodyGroupMembers extends $tea.Model {
  groupMemberAvatar?: string;
  groupMemberDynamics?: string;
  groupMemberId?: string;
  groupMemberName?: string;
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
  groupNickName?: string;
  orgName?: string;
  profilePhotoUrl?: string;
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
  muteEndTime?: number;
  muteStartTime?: number;
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

export class QuerySingleGroupRequestGroupMembers extends $tea.Model {
  appUserId?: string;
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
  appUserId?: string;
  openConversationId?: string;
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
  openConversationId?: string;
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
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async autoOpenDingTalkConnect(): Promise<AutoOpenDingTalkConnectResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AutoOpenDingTalkConnectHeaders({ });
    return await this.autoOpenDingTalkConnectWithOptions(headers, runtime);
  }

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
    return $tea.cast<AutoOpenDingTalkConnectResponse>(await this.doROARequest("AutoOpenDingTalkConnect", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/apps/open`, "json", req, runtime), new AutoOpenDingTalkConnectResponse({}));
  }

  async batchQueryGroupMember(request: BatchQueryGroupMemberRequest): Promise<BatchQueryGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryGroupMemberHeaders({ });
    return await this.batchQueryGroupMemberWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchQueryGroupMemberResponse>(await this.doROARequest("BatchQueryGroupMember", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/sceneGroups/members/batchQuery`, "json", req, runtime), new BatchQueryGroupMemberResponse({}));
  }

  async cardTemplateBuildAction(request: CardTemplateBuildActionRequest): Promise<CardTemplateBuildActionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CardTemplateBuildActionHeaders({ });
    return await this.cardTemplateBuildActionWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CardTemplateBuildActionResponse>(await this.doROARequest("CardTemplateBuildAction", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interactiveCards/templates/buildAction`, "json", req, runtime), new CardTemplateBuildActionResponse({}));
  }

  async chatIdToOpenConversationId(chatId: string): Promise<ChatIdToOpenConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChatIdToOpenConversationIdHeaders({ });
    return await this.chatIdToOpenConversationIdWithOptions(chatId, headers, runtime);
  }

  async chatIdToOpenConversationIdWithOptions(chatId: string, headers: ChatIdToOpenConversationIdHeaders, runtime: $Util.RuntimeOptions): Promise<ChatIdToOpenConversationIdResponse> {
    chatId = OpenApiUtil.getEncodeParam(chatId);
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
    return $tea.cast<ChatIdToOpenConversationIdResponse>(await this.doROARequest("ChatIdToOpenConversationId", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/chat/${chatId}/convertToOpenConversationId`, "json", req, runtime), new ChatIdToOpenConversationIdResponse({}));
  }

  async chatSubAdminUpdate(request: ChatSubAdminUpdateRequest): Promise<ChatSubAdminUpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ChatSubAdminUpdateHeaders({ });
    return await this.chatSubAdminUpdateWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<ChatSubAdminUpdateResponse>(await this.doROARequest("ChatSubAdminUpdate", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/subAdministrators`, "json", req, runtime), new ChatSubAdminUpdateResponse({}));
  }

  async createCoupleGroupConversation(request: CreateCoupleGroupConversationRequest): Promise<CreateCoupleGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCoupleGroupConversationHeaders({ });
    return await this.createCoupleGroupConversationWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateCoupleGroupConversationResponse>(await this.doROARequest("CreateCoupleGroupConversation", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/coupleGroups`, "json", req, runtime), new CreateCoupleGroupConversationResponse({}));
  }

  async createGroupConversation(request: CreateGroupConversationRequest): Promise<CreateGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupConversationHeaders({ });
    return await this.createGroupConversationWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateGroupConversationResponse>(await this.doROARequest("CreateGroupConversation", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/groups`, "json", req, runtime), new CreateGroupConversationResponse({}));
  }

  async createInterconnection(request: CreateInterconnectionRequest): Promise<CreateInterconnectionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInterconnectionHeaders({ });
    return await this.createInterconnectionWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateInterconnectionResponse>(await this.doROARequest("CreateInterconnection", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections`, "json", req, runtime), new CreateInterconnectionResponse({}));
  }

  async createStoreGroupConversation(request: CreateStoreGroupConversationRequest): Promise<CreateStoreGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateStoreGroupConversationHeaders({ });
    return await this.createStoreGroupConversationWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<CreateStoreGroupConversationResponse>(await this.doROARequest("CreateStoreGroupConversation", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/storeGroups`, "json", req, runtime), new CreateStoreGroupConversationResponse({}));
  }

  async getConversationUrl(request: GetConversationUrlRequest): Promise<GetConversationUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationUrlHeaders({ });
    return await this.getConversationUrlWithOptions(request, headers, runtime);
  }

  async getConversationUrlWithOptions(request: GetConversationUrlRequest, headers: GetConversationUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUserId)) {
      body["appUserId"] = request.appUserId;
    }

    if (!Util.isUnset(request.channelCode)) {
      body["channelCode"] = request.channelCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.sourceCode)) {
      body["sourceCode"] = request.sourceCode;
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
    return $tea.cast<GetConversationUrlResponse>(await this.doROARequest("GetConversationUrl", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/conversations/urls`, "json", req, runtime), new GetConversationUrlResponse({}));
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

  async groupBanWords(request: GroupBanWordsRequest): Promise<GroupBanWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupBanWordsHeaders({ });
    return await this.groupBanWordsWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GroupBanWordsResponse>(await this.doROARequest("GroupBanWords", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/groups/words/ban`, "none", req, runtime), new GroupBanWordsResponse({}));
  }

  async groupCapacityInquiry(request: GroupCapacityInquiryRequest): Promise<GroupCapacityInquiryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupCapacityInquiryHeaders({ });
    return await this.groupCapacityInquiryWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GroupCapacityInquiryResponse>(await this.doROARequest("GroupCapacityInquiry", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/groups/capacities/inquiries/query`, "json", req, runtime), new GroupCapacityInquiryResponse({}));
  }

  async groupCapacityOrderConfirm(request: GroupCapacityOrderConfirmRequest): Promise<GroupCapacityOrderConfirmResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupCapacityOrderConfirmHeaders({ });
    return await this.groupCapacityOrderConfirmWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GroupCapacityOrderConfirmResponse>(await this.doROARequest("GroupCapacityOrderConfirm", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/groups/capacities/orders/confirm`, "none", req, runtime), new GroupCapacityOrderConfirmResponse({}));
  }

  async groupCapacityOrderPlace(request: GroupCapacityOrderPlaceRequest): Promise<GroupCapacityOrderPlaceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupCapacityOrderPlaceHeaders({ });
    return await this.groupCapacityOrderPlaceWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GroupCapacityOrderPlaceResponse>(await this.doROARequest("GroupCapacityOrderPlace", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/groups/capacities/orders/place`, "json", req, runtime), new GroupCapacityOrderPlaceResponse({}));
  }

  async groupManageQuery(request: GroupManageQueryRequest): Promise<GroupManageQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupManageQueryHeaders({ });
    return await this.groupManageQueryWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GroupManageQueryResponse>(await this.doROARequest("GroupManageQuery", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/groups/managements/query`, "json", req, runtime), new GroupManageQueryResponse({}));
  }

  async groupManageReduce(request: GroupManageReduceRequest): Promise<GroupManageReduceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupManageReduceHeaders({ });
    return await this.groupManageReduceWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<GroupManageReduceResponse>(await this.doROARequest("GroupManageReduce", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/groups/capacities/reduce`, "none", req, runtime), new GroupManageReduceResponse({}));
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
    return $tea.cast<InteractiveCardCreateInstanceResponse>(await this.doROARequest("InteractiveCardCreateInstance", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interactiveCards/instances`, "json", req, runtime), new InteractiveCardCreateInstanceResponse({}));
  }

  async queryGroupInfoByMemberAuth(request: QueryGroupInfoByMemberAuthRequest): Promise<QueryGroupInfoByMemberAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupInfoByMemberAuthHeaders({ });
    return await this.queryGroupInfoByMemberAuthWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryGroupInfoByMemberAuthResponse>(await this.doROARequest("QueryGroupInfoByMemberAuth", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/memberAuthorizations/groups/query`, "json", req, runtime), new QueryGroupInfoByMemberAuthResponse({}));
  }

  async queryGroupMember(request: QueryGroupMemberRequest): Promise<QueryGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMemberHeaders({ });
    return await this.queryGroupMemberWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryGroupMemberResponse>(await this.doROARequest("QueryGroupMember", "im_1.0", "HTTP", "GET", "AK", `/v1.0/im/interconnections/conversations/members`, "json", req, runtime), new QueryGroupMemberResponse({}));
  }

  async queryGroupMemberByMemberAuth(request: QueryGroupMemberByMemberAuthRequest): Promise<QueryGroupMemberByMemberAuthResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMemberByMemberAuthHeaders({ });
    return await this.queryGroupMemberByMemberAuthWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryGroupMemberByMemberAuthResponse>(await this.doROARequest("QueryGroupMemberByMemberAuth", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/memberAuthorizations/groups/members/query`, "json", req, runtime), new QueryGroupMemberByMemberAuthResponse({}));
  }

  async queryGroupMuteStatus(request: QueryGroupMuteStatusRequest): Promise<QueryGroupMuteStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMuteStatusHeaders({ });
    return await this.queryGroupMuteStatusWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryGroupMuteStatusResponse>(await this.doROARequest("QueryGroupMuteStatus", "im_1.0", "HTTP", "GET", "AK", `/v1.0/im/sceneGroups/muteSettings`, "json", req, runtime), new QueryGroupMuteStatusResponse({}));
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

  async querySingleGroup(request: QuerySingleGroupRequest): Promise<QuerySingleGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySingleGroupHeaders({ });
    return await this.querySingleGroupWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QuerySingleGroupResponse>(await this.doROARequest("QuerySingleGroup", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/doubleGroups/query`, "json", req, runtime), new QuerySingleGroupResponse({}));
  }

  async queryUnReadMessage(request: QueryUnReadMessageRequest): Promise<QueryUnReadMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUnReadMessageHeaders({ });
    return await this.queryUnReadMessageWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<QueryUnReadMessageResponse>(await this.doROARequest("QueryUnReadMessage", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/unReadMsgs/query`, "json", req, runtime), new QueryUnReadMessageResponse({}));
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

    if (!Util.isUnset($tea.toMap(request.cardOptions))) {
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

    if (!Util.isUnset($tea.toMap(request.sendOptions))) {
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
    return $tea.cast<SendRobotInteractiveCardResponse>(await this.doROARequest("SendRobotInteractiveCard", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/v1.0/robot/interactiveCards/send`, "json", req, runtime), new SendRobotInteractiveCardResponse({}));
  }

  async sendRobotMessage(request: SendRobotMessageRequest): Promise<SendRobotMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendRobotMessageHeaders({ });
    return await this.sendRobotMessageWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<SendRobotMessageResponse>(await this.doROARequest("SendRobotMessage", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/robotMessages/send`, "json", req, runtime), new SendRobotMessageResponse({}));
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
    return $tea.cast<TopboxOpenResponse>(await this.doROARequest("TopboxOpen", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/topBoxes/open`, "none", req, runtime), new TopboxOpenResponse({}));
  }

  async updateGroupAvatar(request: UpdateGroupAvatarRequest): Promise<UpdateGroupAvatarResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupAvatarHeaders({ });
    return await this.updateGroupAvatarWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateGroupAvatarResponse>(await this.doROARequest("UpdateGroupAvatar", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/interconnections/groups/avatars`, "json", req, runtime), new UpdateGroupAvatarResponse({}));
  }

  async updateGroupName(request: UpdateGroupNameRequest): Promise<UpdateGroupNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupNameHeaders({ });
    return await this.updateGroupNameWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateGroupNameResponse>(await this.doROARequest("UpdateGroupName", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/interconnections/groups/names`, "json", req, runtime), new UpdateGroupNameResponse({}));
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

  async updateMemberBanWords(request: UpdateMemberBanWordsRequest): Promise<UpdateMemberBanWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateMemberBanWordsHeaders({ });
    return await this.updateMemberBanWordsWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateMemberBanWordsResponse>(await this.doROARequest("UpdateMemberBanWords", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/sceneGroups/muteMembers/set`, "none", req, runtime), new UpdateMemberBanWordsResponse({}));
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

  async updateRobotInteractiveCard(request: UpdateRobotInteractiveCardRequest): Promise<UpdateRobotInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateRobotInteractiveCardHeaders({ });
    return await this.updateRobotInteractiveCardWithOptions(request, headers, runtime);
  }

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

    if (!Util.isUnset($tea.toMap(request.updateOptions))) {
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
    return $tea.cast<UpdateRobotInteractiveCardResponse>(await this.doROARequest("UpdateRobotInteractiveCard", "im_1.0", "HTTP", "PUT", "AK", `/v1.0/im/robots/interactiveCards`, "json", req, runtime), new UpdateRobotInteractiveCardResponse({}));
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

  async addGroupMember(request: AddGroupMemberRequest): Promise<AddGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddGroupMemberHeaders({ });
    return await this.addGroupMemberWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<AddGroupMemberResponse>(await this.doROARequest("addGroupMember", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/groups/members`, "json", req, runtime), new AddGroupMemberResponse({}));
  }

  async removeGroupMember(request: RemoveGroupMemberRequest): Promise<RemoveGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveGroupMemberHeaders({ });
    return await this.removeGroupMemberWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<RemoveGroupMemberResponse>(await this.doROARequest("removeGroupMember", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/groups/members/remove`, "none", req, runtime), new RemoveGroupMemberResponse({}));
  }

  async sendDingMessage(request: SendDingMessageRequest): Promise<SendDingMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendDingMessageHeaders({ });
    return await this.sendDingMessageWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<SendDingMessageResponse>(await this.doROARequest("sendDingMessage", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/dingMessages/send`, "json", req, runtime), new SendDingMessageResponse({}));
  }

  async sendMessage(request: SendMessageRequest): Promise<SendMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageHeaders({ });
    return await this.sendMessageWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<SendMessageResponse>(await this.doROARequest("sendMessage", "im_1.0", "HTTP", "POST", "AK", `/v1.0/im/interconnections/messages/send`, "json", req, runtime), new SendMessageResponse({}));
  }

}
