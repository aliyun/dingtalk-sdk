// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddGroupMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMembersRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  conversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * true
   */
  members?: AddGroupMembersRequestMembers[];
  operatorUid?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      members: 'members',
      operatorUid: 'operatorUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      members: { 'type': 'array', 'itemType': AddGroupMembersRequestMembers },
      operatorUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMembersResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  memberUids?: string[];
  static names(): { [key: string]: string } {
    return {
      memberUids: 'memberUids',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memberUids: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMembersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddGroupMembersResponseBody;
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
      body: AddGroupMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProfileHeaders extends $tea.Model {
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

export class AddProfileRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appUid?: string;
  avatarMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  mobileNumber?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * usertest
   */
  nick?: string;
  static names(): { [key: string]: string } {
    return {
      appUid: 'appUid',
      avatarMediaId: 'avatarMediaId',
      mobileNumber: 'mobileNumber',
      nick: 'nick',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUid: 'string',
      avatarMediaId: 'string',
      mobileNumber: 'string',
      nick: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProfileResponse extends $tea.Model {
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

export class BatchSendHeaders extends $tea.Model {
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

export class BatchSendRequest extends $tea.Model {
  /**
   * **if can be null:**
   * true
   */
  appUids?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * **if can be null:**
   * true
   */
  conversationIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 234#dingxxx@dingding
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUids: 'appUids',
      content: 'content',
      conversationIds: 'conversationIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUids: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
      conversationIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 23233434
   */
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

export class BatchSendResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchSendResponseBody;
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
      body: BatchSendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  channel?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  creatorUid?: string;
  iconMediaId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  properties?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      channel: 'channel',
      creatorUid: 'creatorUid',
      iconMediaId: 'iconMediaId',
      name: 'name',
      properties: 'properties',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channel: 'string',
      creatorUid: 'string',
      iconMediaId: 'string',
      name: 'string',
      properties: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  chatId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  conversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      conversationId: 'conversationId',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      conversationId: 'string',
      createTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateGroupResponseBody;
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
      body: CreateGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTrustGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTrustGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * channel_abcd
   */
  channel?: string;
  /**
   * @example
   * @lALOKACADDA
   */
  iconMediaId?: string;
  members?: CreateTrustGroupRequestMembers[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试群名称XXX
   */
  name?: string;
  properties?: { [key: string]: string };
  /**
   * @example
   * 你有新的会话
   */
  systemMsg?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1657099913071
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      channel: 'channel',
      iconMediaId: 'iconMediaId',
      members: 'members',
      name: 'name',
      properties: 'properties',
      systemMsg: 'systemMsg',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channel: 'string',
      iconMediaId: 'string',
      members: { 'type': 'array', 'itemType': CreateTrustGroupRequestMembers },
      name: 'string',
      properties: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      systemMsg: 'string',
      uuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTrustGroupResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  chatId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatId: 'chatId',
      createTime: 'createTime',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatId: 'string',
      createTime: 'number',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTrustGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateTrustGroupResponseBody;
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
      body: CreateTrustGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DismissGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DismissGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  conversationId?: string;
  operatorUid?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      operatorUid: 'operatorUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      operatorUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DismissGroupResponse extends $tea.Model {
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

export class GetConversationIdHeaders extends $tea.Model {
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

export class GetConversationIdRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  appUid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appUid: 'appUid',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUid: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  conversationId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetConversationIdResponseBody;
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
      body: GetConversationIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlHeaders extends $tea.Model {
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

export class GetMediaUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @wesfsdfsfwe
   */
  mediaId?: string;
  /**
   * @example
   * 86399
   */
  urlExpireTime?: number;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      urlExpireTime: 'urlExpireTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      urlExpireTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlResponseBody extends $tea.Model {
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

export class GetMediaUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMediaUrlResponseBody;
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
      body: GetMediaUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlsHeaders extends $tea.Model {
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

export class GetMediaUrlsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  mediaIds?: string[];
  /**
   * @example
   * 86399
   */
  urlExpireTime?: number;
  static names(): { [key: string]: string } {
    return {
      mediaIds: 'mediaIds',
      urlExpireTime: 'urlExpireTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaIds: { 'type': 'array', 'itemType': 'string' },
      urlExpireTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlsResponseBody extends $tea.Model {
  urls?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      urls: 'urls',
    };
  }

  static types(): { [key: string]: any } {
    return {
      urls: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetMediaUrlsResponseBody;
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
      body: GetMediaUrlsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceFileUrlHeaders extends $tea.Model {
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

export class GetSpaceFileUrlRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  fileId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123#123@dingding
   */
  senderUid?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  spaceId?: string;
  static names(): { [key: string]: string } {
    return {
      fileId: 'fileId',
      senderUid: 'senderUid',
      spaceId: 'spaceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileId: 'string',
      senderUid: 'string',
      spaceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceFileUrlResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  headers?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  internalResourceUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  resourceUrl?: string;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      internalResourceUrl: 'internalResourceUrl',
      resourceUrl: 'resourceUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      internalResourceUrl: 'string',
      resourceUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSpaceFileUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetSpaceFileUrlResponseBody;
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
      body: GetSpaceFileUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupStaffMembersHeaders extends $tea.Model {
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

export class ListGroupStaffMembersRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  conversationId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupStaffMembersResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  members?: ListGroupStaffMembersResponseBodyMembers[];
  static names(): { [key: string]: string } {
    return {
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      members: { 'type': 'array', 'itemType': ListGroupStaffMembersResponseBodyMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupStaffMembersResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListGroupStaffMembersResponseBody;
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
      body: ListGroupStaffMembersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchSendResultHeaders extends $tea.Model {
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

export class QueryBatchSendResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 234#dingxxx@dingding
   */
  senderUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1234567890
   */
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      senderUserId: 'senderUserId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      senderUserId: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchSendResultResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  results?: QueryBatchSendResultResponseBodyResults[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      results: 'results',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      results: { 'type': 'array', 'itemType': QueryBatchSendResultResponseBodyResults },
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchSendResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBatchSendResultResponseBody;
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
      body: QueryBatchSendResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReadMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReadMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUid?: string;
  static names(): { [key: string]: string } {
    return {
      messageId: 'messageId',
      operatorUid: 'operatorUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageId: 'string',
      operatorUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReadMessageResponse extends $tea.Model {
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

export class RecallMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUid?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      messageId: 'messageId',
      operatorUid: 'operatorUid',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageId: 'string',
      operatorUid: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallMessageResponse extends $tea.Model {
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

export class RemoveGroupMembersHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveGroupMembersRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  conversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * true
   */
  memberUids?: string[];
  operatorUid?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      memberUids: 'memberUids',
      operatorUid: 'operatorUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      memberUids: { 'type': 'array', 'itemType': 'string' },
      operatorUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveGroupMembersResponse extends $tea.Model {
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

export class SendMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
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
   */
  content?: string;
  conversationId?: string;
  createTime?: number;
  receiverUid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  senderUid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uuid?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      conversationId: 'conversationId',
      createTime: 'createTime',
      receiverUid: 'receiverUid',
      senderUid: 'senderUid',
      uuid: 'uuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      conversationId: 'string',
      createTime: 'number',
      receiverUid: 'string',
      senderUid: 'string',
      uuid: 'string',
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
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  messageId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  msgId?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      messageId: 'messageId',
      msgId: 'msgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'number',
      messageId: 'string',
      msgId: 'string',
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
  /**
   * @example
   * false
   */
  atAll?: boolean;
  atAppUids?: string[];
  atMobiles?: string[];
  atUnionIds?: string[];
  atUsers?: string[];
  /**
   * @example
   * 123
   */
  channel?: string;
  /**
   * @example
   * {\"pic1\":\"@123\",\"pic2\":\"@456\"}
   */
  msgMediaIdParamMap?: { [key: string]: any };
  /**
   * @example
   * {\"text1\":\"hello\",\"text2\":\"world\"}
   */
  msgParamMap?: { [key: string]: any };
  /**
   * @example
   * 123
   */
  msgTemplateId?: string;
  receiverAppUids?: string[];
  receiverMobiles?: string[];
  receiverUnionIds?: string[];
  receiverUserIds?: string[];
  /**
   * @example
   * 123
   */
  robotCode?: string;
  /**
   * @example
   * 123
   */
  targetOpenConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      atAll: 'atAll',
      atAppUids: 'atAppUids',
      atMobiles: 'atMobiles',
      atUnionIds: 'atUnionIds',
      atUsers: 'atUsers',
      channel: 'channel',
      msgMediaIdParamMap: 'msgMediaIdParamMap',
      msgParamMap: 'msgParamMap',
      msgTemplateId: 'msgTemplateId',
      receiverAppUids: 'receiverAppUids',
      receiverMobiles: 'receiverMobiles',
      receiverUnionIds: 'receiverUnionIds',
      receiverUserIds: 'receiverUserIds',
      robotCode: 'robotCode',
      targetOpenConversationId: 'targetOpenConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAll: 'boolean',
      atAppUids: { 'type': 'array', 'itemType': 'string' },
      atMobiles: { 'type': 'array', 'itemType': 'string' },
      atUnionIds: { 'type': 'array', 'itemType': 'string' },
      atUsers: { 'type': 'array', 'itemType': 'string' },
      channel: 'string',
      msgMediaIdParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      msgParamMap: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      msgTemplateId: 'string',
      receiverAppUids: { 'type': 'array', 'itemType': 'string' },
      receiverMobiles: { 'type': 'array', 'itemType': 'string' },
      receiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      receiverUserIds: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
      targetOpenConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotMessageResponseBody extends $tea.Model {
  openMsgId?: string;
  static names(): { [key: string]: string } {
    return {
      openMsgId: 'openMsgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openMsgId: 'string',
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

export class UpdateGroupNameHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  operationSource?: string;
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      operationSource: 'operationSource',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      operationSource: 'string',
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
  conversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  operatorUid?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      name: 'name',
      operatorUid: 'operatorUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      name: 'string',
      operatorUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupNameResponse extends $tea.Model {
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

export class UpdateGroupOwnerHeaders extends $tea.Model {
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

export class UpdateGroupOwnerRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  conversationId?: string;
  operatorUid?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  ownerUid?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      operatorUid: 'operatorUid',
      ownerUid: 'ownerUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      operatorUid: 'string',
      ownerUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupOwnerResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
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

export class UpdateGroupOwnerResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateGroupOwnerResponseBody;
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
      body: UpdateGroupOwnerResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadFileHeaders extends $tea.Model {
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

export class UploadFileRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111.png
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * image
   */
  fileType?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fileUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 111@dingdingkelian
   */
  senderUid?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      fileType: 'fileType',
      fileUrl: 'fileUrl',
      senderUid: 'senderUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      fileType: 'string',
      fileUrl: 'string',
      senderUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UploadFileResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * $csvsvsdvsvdscs
   */
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

export class UploadFileResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UploadFileResponseBody;
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
      body: UploadFileResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMembersRequestMembers extends $tea.Model {
  nick?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uid?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      uid: 'uid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      uid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTrustGroupRequestMembers extends $tea.Model {
  nick?: string;
  uid?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      uid: 'uid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      uid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListGroupStaffMembersResponseBodyMembers extends $tea.Model {
  nick?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  uid?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      uid: 'uid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      uid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBatchSendResultResponseBodyResults extends $tea.Model {
  /**
   * @example
   * 123@channel
   */
  appUid?: string;
  /**
   * @example
   * cid1234567890==
   */
  conversationId?: string;
  /**
   * @example
   * 0
   */
  errorCode?: string;
  /**
   * @example
   * success
   */
  errorMessage?: string;
  /**
   * @example
   * msg1234567890==
   */
  msgId?: string;
  static names(): { [key: string]: string } {
    return {
      appUid: 'appUid',
      conversationId: 'conversationId',
      errorCode: 'errorCode',
      errorMessage: 'errorMessage',
      msgId: 'msgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUid: 'string',
      conversationId: 'string',
      errorCode: 'string',
      errorMessage: 'string',
      msgId: 'string',
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
   * 添加群成员
   * 
   * @param request - AddGroupMembersRequest
   * @param headers - AddGroupMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddGroupMembersResponse
   */
  async addGroupMembersWithOptions(request: AddGroupMembersRequest, headers: AddGroupMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddGroupMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "AddGroupMembers",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups/members/batchAdd`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddGroupMembersResponse>(await this.execute(params, req, runtime), new AddGroupMembersResponse({}));
  }

  /**
   * 添加群成员
   * 
   * @param request - AddGroupMembersRequest
   * @returns AddGroupMembersResponse
   */
  async addGroupMembers(request: AddGroupMembersRequest): Promise<AddGroupMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddGroupMembersHeaders({ });
    return await this.addGroupMembersWithOptions(request, headers, runtime);
  }

  /**
   * 外部用户导入profile
   * 
   * @param request - AddProfileRequest
   * @param headers - AddProfileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddProfileResponse
   */
  async addProfileWithOptions(request: AddProfileRequest, headers: AddProfileHeaders, runtime: $Util.RuntimeOptions): Promise<AddProfileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUid)) {
      body["appUid"] = request.appUid;
    }

    if (!Util.isUnset(request.avatarMediaId)) {
      body["avatarMediaId"] = request.avatarMediaId;
    }

    if (!Util.isUnset(request.mobileNumber)) {
      body["mobileNumber"] = request.mobileNumber;
    }

    if (!Util.isUnset(request.nick)) {
      body["nick"] = request.nick;
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
      action: "AddProfile",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/users/profiles`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<AddProfileResponse>(await this.execute(params, req, runtime), new AddProfileResponse({}));
  }

  /**
   * 外部用户导入profile
   * 
   * @param request - AddProfileRequest
   * @returns AddProfileResponse
   */
  async addProfile(request: AddProfileRequest): Promise<AddProfileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddProfileHeaders({ });
    return await this.addProfileWithOptions(request, headers, runtime);
  }

  /**
   * 消息批量接口
   * 
   * @param request - BatchSendRequest
   * @param headers - BatchSendHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchSendResponse
   */
  async batchSendWithOptions(request: BatchSendRequest, headers: BatchSendHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUids)) {
      body["appUids"] = request.appUids;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.conversationIds)) {
      body["conversationIds"] = request.conversationIds;
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
      action: "BatchSend",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/messages/batchSend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchSendResponse>(await this.execute(params, req, runtime), new BatchSendResponse({}));
  }

  /**
   * 消息批量接口
   * 
   * @param request - BatchSendRequest
   * @returns BatchSendResponse
   */
  async batchSend(request: BatchSendRequest): Promise<BatchSendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendHeaders({ });
    return await this.batchSendWithOptions(request, headers, runtime);
  }

  /**
   * 创建群
   * 
   * @param request - CreateGroupRequest
   * @param headers - CreateGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupResponse
   */
  async createGroupWithOptions(request: CreateGroupRequest, headers: CreateGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.creatorUid)) {
      body["creatorUid"] = request.creatorUid;
    }

    if (!Util.isUnset(request.iconMediaId)) {
      body["iconMediaId"] = request.iconMediaId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateGroup",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupResponse>(await this.execute(params, req, runtime), new CreateGroupResponse({}));
  }

  /**
   * 创建群
   * 
   * @param request - CreateGroupRequest
   * @returns CreateGroupResponse
   */
  async createGroup(request: CreateGroupRequest): Promise<CreateGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupHeaders({ });
    return await this.createGroupWithOptions(request, headers, runtime);
  }

  /**
   * 创建托管账号为群主的群
   * 
   * @param request - CreateTrustGroupRequest
   * @param headers - CreateTrustGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateTrustGroupResponse
   */
  async createTrustGroupWithOptions(request: CreateTrustGroupRequest, headers: CreateTrustGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTrustGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.iconMediaId)) {
      body["iconMediaId"] = request.iconMediaId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
    }

    if (!Util.isUnset(request.systemMsg)) {
      body["systemMsg"] = request.systemMsg;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateTrustGroup",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups/trusts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTrustGroupResponse>(await this.execute(params, req, runtime), new CreateTrustGroupResponse({}));
  }

  /**
   * 创建托管账号为群主的群
   * 
   * @param request - CreateTrustGroupRequest
   * @returns CreateTrustGroupResponse
   */
  async createTrustGroup(request: CreateTrustGroupRequest): Promise<CreateTrustGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTrustGroupHeaders({ });
    return await this.createTrustGroupWithOptions(request, headers, runtime);
  }

  /**
   * 解散群
   * 
   * @param request - DismissGroupRequest
   * @param headers - DismissGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DismissGroupResponse
   */
  async dismissGroupWithOptions(request: DismissGroupRequest, headers: DismissGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DismissGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "DismissGroup",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups/dismiss`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DismissGroupResponse>(await this.execute(params, req, runtime), new DismissGroupResponse({}));
  }

  /**
   * 解散群
   * 
   * @param request - DismissGroupRequest
   * @returns DismissGroupResponse
   */
  async dismissGroup(request: DismissGroupRequest): Promise<DismissGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DismissGroupHeaders({ });
    return await this.dismissGroupWithOptions(request, headers, runtime);
  }

  /**
   * 生成单聊会话Id
   * 
   * @param request - GetConversationIdRequest
   * @param headers - GetConversationIdHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetConversationIdResponse
   */
  async getConversationIdWithOptions(request: GetConversationIdRequest, headers: GetConversationIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationIdResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appUid)) {
      body["appUid"] = request.appUid;
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
      action: "GetConversationId",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/conversations`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConversationIdResponse>(await this.execute(params, req, runtime), new GetConversationIdResponse({}));
  }

  /**
   * 生成单聊会话Id
   * 
   * @param request - GetConversationIdRequest
   * @returns GetConversationIdResponse
   */
  async getConversationId(request: GetConversationIdRequest): Promise<GetConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationIdHeaders({ });
    return await this.getConversationIdWithOptions(request, headers, runtime);
  }

  /**
   * 多媒体文件下载
   * 
   * @param request - GetMediaUrlRequest
   * @param headers - GetMediaUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMediaUrlResponse
   */
  async getMediaUrlWithOptions(request: GetMediaUrlRequest, headers: GetMediaUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetMediaUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.urlExpireTime)) {
      body["urlExpireTime"] = request.urlExpireTime;
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
      action: "GetMediaUrl",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/medium/urls`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetMediaUrlResponse>(await this.execute(params, req, runtime), new GetMediaUrlResponse({}));
  }

  /**
   * 多媒体文件下载
   * 
   * @param request - GetMediaUrlRequest
   * @returns GetMediaUrlResponse
   */
  async getMediaUrl(request: GetMediaUrlRequest): Promise<GetMediaUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMediaUrlHeaders({ });
    return await this.getMediaUrlWithOptions(request, headers, runtime);
  }

  /**
   * 多媒体文件批量下载
   * 
   * @param request - GetMediaUrlsRequest
   * @param headers - GetMediaUrlsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetMediaUrlsResponse
   */
  async getMediaUrlsWithOptions(request: GetMediaUrlsRequest, headers: GetMediaUrlsHeaders, runtime: $Util.RuntimeOptions): Promise<GetMediaUrlsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mediaIds)) {
      body["mediaIds"] = request.mediaIds;
    }

    if (!Util.isUnset(request.urlExpireTime)) {
      body["urlExpireTime"] = request.urlExpireTime;
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
      action: "GetMediaUrls",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/mediaUrls/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMediaUrlsResponse>(await this.execute(params, req, runtime), new GetMediaUrlsResponse({}));
  }

  /**
   * 多媒体文件批量下载
   * 
   * @param request - GetMediaUrlsRequest
   * @returns GetMediaUrlsResponse
   */
  async getMediaUrls(request: GetMediaUrlsRequest): Promise<GetMediaUrlsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMediaUrlsHeaders({ });
    return await this.getMediaUrlsWithOptions(request, headers, runtime);
  }

  /**
   * 获取钉盘文件下载信息
   * 
   * @param request - GetSpaceFileUrlRequest
   * @param headers - GetSpaceFileUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetSpaceFileUrlResponse
   */
  async getSpaceFileUrlWithOptions(request: GetSpaceFileUrlRequest, headers: GetSpaceFileUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetSpaceFileUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileId)) {
      query["fileId"] = request.fileId;
    }

    if (!Util.isUnset(request.senderUid)) {
      query["senderUid"] = request.senderUid;
    }

    if (!Util.isUnset(request.spaceId)) {
      query["spaceId"] = request.spaceId;
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
      action: "GetSpaceFileUrl",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/spaces/files/urls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSpaceFileUrlResponse>(await this.execute(params, req, runtime), new GetSpaceFileUrlResponse({}));
  }

  /**
   * 获取钉盘文件下载信息
   * 
   * @param request - GetSpaceFileUrlRequest
   * @returns GetSpaceFileUrlResponse
   */
  async getSpaceFileUrl(request: GetSpaceFileUrlRequest): Promise<GetSpaceFileUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSpaceFileUrlHeaders({ });
    return await this.getSpaceFileUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取企业员工类型的群成员
   * 
   * @param request - ListGroupStaffMembersRequest
   * @param headers - ListGroupStaffMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListGroupStaffMembersResponse
   */
  async listGroupStaffMembersWithOptions(request: ListGroupStaffMembersRequest, headers: ListGroupStaffMembersHeaders, runtime: $Util.RuntimeOptions): Promise<ListGroupStaffMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
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
      action: "ListGroupStaffMembers",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups/staffMemers/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListGroupStaffMembersResponse>(await this.execute(params, req, runtime), new ListGroupStaffMembersResponse({}));
  }

  /**
   * 获取企业员工类型的群成员
   * 
   * @param request - ListGroupStaffMembersRequest
   * @returns ListGroupStaffMembersResponse
   */
  async listGroupStaffMembers(request: ListGroupStaffMembersRequest): Promise<ListGroupStaffMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListGroupStaffMembersHeaders({ });
    return await this.listGroupStaffMembersWithOptions(request, headers, runtime);
  }

  /**
   * 查询batchSend结果
   * 
   * @param request - QueryBatchSendResultRequest
   * @param headers - QueryBatchSendResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBatchSendResultResponse
   */
  async queryBatchSendResultWithOptions(request: QueryBatchSendResultRequest, headers: QueryBatchSendResultHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBatchSendResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.senderUserId)) {
      query["senderUserId"] = request.senderUserId;
    }

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
      action: "QueryBatchSendResult",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/messages/batchSendResults`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBatchSendResultResponse>(await this.execute(params, req, runtime), new QueryBatchSendResultResponse({}));
  }

  /**
   * 查询batchSend结果
   * 
   * @param request - QueryBatchSendResultRequest
   * @returns QueryBatchSendResultResponse
   */
  async queryBatchSendResult(request: QueryBatchSendResultRequest): Promise<QueryBatchSendResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBatchSendResultHeaders({ });
    return await this.queryBatchSendResultWithOptions(request, headers, runtime);
  }

  /**
   * 消息已读
   * 
   * @param request - ReadMessageRequest
   * @param headers - ReadMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReadMessageResponse
   */
  async readMessageWithOptions(request: ReadMessageRequest, headers: ReadMessageHeaders, runtime: $Util.RuntimeOptions): Promise<ReadMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "ReadMessage",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/messages/read`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<ReadMessageResponse>(await this.execute(params, req, runtime), new ReadMessageResponse({}));
  }

  /**
   * 消息已读
   * 
   * @param request - ReadMessageRequest
   * @returns ReadMessageResponse
   */
  async readMessage(request: ReadMessageRequest): Promise<ReadMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReadMessageHeaders({ });
    return await this.readMessageWithOptions(request, headers, runtime);
  }

  /**
   * 消息撤回
   * 
   * @param request - RecallMessageRequest
   * @param headers - RecallMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RecallMessageResponse
   */
  async recallMessageWithOptions(request: RecallMessageRequest, headers: RecallMessageHeaders, runtime: $Util.RuntimeOptions): Promise<RecallMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RecallMessage",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/messages/recall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "none",
    });
    return $tea.cast<RecallMessageResponse>(await this.execute(params, req, runtime), new RecallMessageResponse({}));
  }

  /**
   * 消息撤回
   * 
   * @param request - RecallMessageRequest
   * @returns RecallMessageResponse
   */
  async recallMessage(request: RecallMessageRequest): Promise<RecallMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallMessageHeaders({ });
    return await this.recallMessageWithOptions(request, headers, runtime);
  }

  /**
   * 移除群成员
   * 
   * @param request - RemoveGroupMembersRequest
   * @param headers - RemoveGroupMembersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveGroupMembersResponse
   */
  async removeGroupMembersWithOptions(request: RemoveGroupMembersRequest, headers: RemoveGroupMembersHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveGroupMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.memberUids)) {
      body["memberUids"] = request.memberUids;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "RemoveGroupMembers",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups/members/batchRemove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RemoveGroupMembersResponse>(await this.execute(params, req, runtime), new RemoveGroupMembersResponse({}));
  }

  /**
   * 移除群成员
   * 
   * @param request - RemoveGroupMembersRequest
   * @returns RemoveGroupMembersResponse
   */
  async removeGroupMembers(request: RemoveGroupMembersRequest): Promise<RemoveGroupMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveGroupMembersHeaders({ });
    return await this.removeGroupMembersWithOptions(request, headers, runtime);
  }

  /**
   * 消息发送
   * 
   * @param request - SendMessageRequest
   * @param headers - SendMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendMessageResponse
   */
  async sendMessageWithOptions(request: SendMessageRequest, headers: SendMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.createTime)) {
      body["createTime"] = request.createTime;
    }

    if (!Util.isUnset(request.receiverUid)) {
      body["receiverUid"] = request.receiverUid;
    }

    if (!Util.isUnset(request.senderUid)) {
      body["senderUid"] = request.senderUid;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "SendMessage",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMessageResponse>(await this.execute(params, req, runtime), new SendMessageResponse({}));
  }

  /**
   * 消息发送
   * 
   * @param request - SendMessageRequest
   * @returns SendMessageResponse
   */
  async sendMessage(request: SendMessageRequest): Promise<SendMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageHeaders({ });
    return await this.sendMessageWithOptions(request, headers, runtime);
  }

  /**
   * 通过群模板机器人发送消息
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

    if (!Util.isUnset(request.atAppUids)) {
      body["atAppUids"] = request.atAppUids;
    }

    if (!Util.isUnset(request.atMobiles)) {
      body["atMobiles"] = request.atMobiles;
    }

    if (!Util.isUnset(request.atUnionIds)) {
      body["atUnionIds"] = request.atUnionIds;
    }

    if (!Util.isUnset(request.atUsers)) {
      body["atUsers"] = request.atUsers;
    }

    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.msgMediaIdParamMap)) {
      body["msgMediaIdParamMap"] = request.msgMediaIdParamMap;
    }

    if (!Util.isUnset(request.msgParamMap)) {
      body["msgParamMap"] = request.msgParamMap;
    }

    if (!Util.isUnset(request.msgTemplateId)) {
      body["msgTemplateId"] = request.msgTemplateId;
    }

    if (!Util.isUnset(request.receiverAppUids)) {
      body["receiverAppUids"] = request.receiverAppUids;
    }

    if (!Util.isUnset(request.receiverMobiles)) {
      body["receiverMobiles"] = request.receiverMobiles;
    }

    if (!Util.isUnset(request.receiverUnionIds)) {
      body["receiverUnionIds"] = request.receiverUnionIds;
    }

    if (!Util.isUnset(request.receiverUserIds)) {
      body["receiverUserIds"] = request.receiverUserIds;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.targetOpenConversationId)) {
      body["targetOpenConversationId"] = request.targetOpenConversationId;
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
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/robots/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendRobotMessageResponse>(await this.execute(params, req, runtime), new SendRobotMessageResponse({}));
  }

  /**
   * 通过群模板机器人发送消息
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
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = Util.toJSONString(headers.operationSource);
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
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups/names`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
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
   * 转让群主
   * 
   * @param request - UpdateGroupOwnerRequest
   * @param headers - UpdateGroupOwnerHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupOwnerResponse
   */
  async updateGroupOwnerWithOptions(request: UpdateGroupOwnerRequest, headers: UpdateGroupOwnerHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupOwnerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.ownerUid)) {
      body["ownerUid"] = request.ownerUid;
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
      action: "UpdateGroupOwner",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/groups/owners`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateGroupOwnerResponse>(await this.execute(params, req, runtime), new UpdateGroupOwnerResponse({}));
  }

  /**
   * 转让群主
   * 
   * @param request - UpdateGroupOwnerRequest
   * @returns UpdateGroupOwnerResponse
   */
  async updateGroupOwner(request: UpdateGroupOwnerRequest): Promise<UpdateGroupOwnerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupOwnerHeaders({ });
    return await this.updateGroupOwnerWithOptions(request, headers, runtime);
  }

  /**
   * 互联互通上传文件
   * 
   * @param request - UploadFileRequest
   * @param headers - UploadFileHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UploadFileResponse
   */
  async uploadFileWithOptions(request: UploadFileRequest, headers: UploadFileHeaders, runtime: $Util.RuntimeOptions): Promise<UploadFileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileType)) {
      body["fileType"] = request.fileType;
    }

    if (!Util.isUnset(request.fileUrl)) {
      body["fileUrl"] = request.fileUrl;
    }

    if (!Util.isUnset(request.senderUid)) {
      body["senderUid"] = request.senderUid;
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
      action: "UploadFile",
      version: "impaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/impaas/interconnections/files/upload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UploadFileResponse>(await this.execute(params, req, runtime), new UploadFileResponse({}));
  }

  /**
   * 互联互通上传文件
   * 
   * @param request - UploadFileRequest
   * @returns UploadFileResponse
   */
  async uploadFile(request: UploadFileRequest): Promise<UploadFileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UploadFileHeaders({ });
    return await this.uploadFileWithOptions(request, headers, runtime);
  }

}
