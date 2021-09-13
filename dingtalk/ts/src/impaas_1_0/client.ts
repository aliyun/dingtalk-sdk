// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  userId?: string;
  appUid?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      appUid: 'appUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      appUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: GetConversationIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetConversationIdResponseBody,
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
  operatorUid?: string;
  messageId?: string;
  type?: number;
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      messageId: 'messageId',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      messageId: 'string',
      type: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallMessageResponse extends $tea.Model {
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
  operatorUid?: string;
  conversationId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      conversationId: 'conversationId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      conversationId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupNameResponse extends $tea.Model {
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
  uuid?: string;
  creatorUid?: string;
  name?: string;
  iconMediaId?: string;
  channel?: string;
  properties?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      uuid: 'uuid',
      creatorUid: 'creatorUid',
      name: 'name',
      iconMediaId: 'iconMediaId',
      channel: 'channel',
      properties: 'properties',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uuid: 'string',
      creatorUid: 'string',
      name: 'string',
      iconMediaId: 'string',
      channel: 'string',
      properties: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponseBody extends $tea.Model {
  conversationId?: string;
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      createTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupOwnerHeaders extends $tea.Model {
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

export class UpdateGroupOwnerRequest extends $tea.Model {
  ownerId?: string;
  operatorUid?: string;
  conversationId?: string;
  static names(): { [key: string]: string } {
    return {
      ownerId: 'ownerId',
      operatorUid: 'operatorUid',
      conversationId: 'conversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ownerId: 'string',
      operatorUid: 'string',
      conversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupOwnerResponse extends $tea.Model {
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
  operatorUid?: string;
  conversationId?: string;
  memberUids?: string[];
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      conversationId: 'conversationId',
      memberUids: 'memberUids',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      conversationId: 'string',
      memberUids: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveGroupMembersResponse extends $tea.Model {
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
  mediaId?: string;
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
  headers: { [key: string]: string };
  body: GetMediaUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMediaUrlResponseBody,
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
  operatorUid?: string;
  messageId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      messageId: 'messageId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      messageId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReadMessageResponse extends $tea.Model {
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
  operatorUid?: string;
  conversationId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      conversationId: 'conversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      conversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DismissGroupResponse extends $tea.Model {
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
  nick?: string;
  avatarMediaId?: string;
  appUid?: string;
  mobileNumber?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      avatarMediaId: 'avatarMediaId',
      appUid: 'appUid',
      mobileNumber: 'mobileNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      avatarMediaId: 'string',
      appUid: 'string',
      mobileNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProfileResponse extends $tea.Model {
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
  operatorUid?: string;
  conversationId?: string;
  members?: AddGroupMembersRequestMembers[];
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      conversationId: 'conversationId',
      members: 'members',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      conversationId: 'string',
      members: { 'type': 'array', 'itemType': AddGroupMembersRequestMembers },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddGroupMembersResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: AddGroupMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddGroupMembersResponseBody,
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
  userId?: string;
  appUids?: string[];
  content?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      appUids: 'appUids',
      content: 'content',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      appUids: { 'type': 'array', 'itemType': 'string' },
      content: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendResponseBody extends $tea.Model {
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
  headers: { [key: string]: string };
  body: BatchSendResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchSendResponseBody,
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
  headers: { [key: string]: string };
  body: ListGroupStaffMembersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListGroupStaffMembersResponseBody,
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
  senderUid?: string;
  receiverUid?: string;
  conversationId?: string;
  content?: string;
  uuid?: string;
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      senderUid: 'senderUid',
      receiverUid: 'receiverUid',
      conversationId: 'conversationId',
      content: 'content',
      uuid: 'uuid',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      senderUid: 'string',
      receiverUid: 'string',
      conversationId: 'string',
      content: 'string',
      uuid: 'string',
      createTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageResponseBody extends $tea.Model {
  msgId?: string;
  createTime?: number;
  messageId?: string;
  static names(): { [key: string]: string } {
    return {
      msgId: 'msgId',
      createTime: 'createTime',
      messageId: 'messageId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgId: 'string',
      createTime: 'number',
      messageId: 'string',
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

export class AddGroupMembersRequestMembers extends $tea.Model {
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
  uid?: string;
  nick?: string;
  static names(): { [key: string]: string } {
    return {
      uid: 'uid',
      nick: 'nick',
    };
  }

  static types(): { [key: string]: any } {
    return {
      uid: 'string',
      nick: 'string',
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


  async getConversationId(request: GetConversationIdRequest): Promise<GetConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationIdHeaders({ });
    return await this.getConversationIdWithOptions(request, headers, runtime);
  }

  async getConversationIdWithOptions(request: GetConversationIdRequest, headers: GetConversationIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationIdResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.appUid)) {
      body["appUid"] = request.appUid;
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
    return $tea.cast<GetConversationIdResponse>(await this.doROARequest("GetConversationId", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/conversations`, "json", req, runtime), new GetConversationIdResponse({}));
  }

  async recallMessage(request: RecallMessageRequest): Promise<RecallMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallMessageHeaders({ });
    return await this.recallMessageWithOptions(request, headers, runtime);
  }

  async recallMessageWithOptions(request: RecallMessageRequest, headers: RecallMessageHeaders, runtime: $Util.RuntimeOptions): Promise<RecallMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RecallMessageResponse>(await this.doROARequest("RecallMessage", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/messages/recall`, "none", req, runtime), new RecallMessageResponse({}));
  }

  async updateGroupName(request: UpdateGroupNameRequest): Promise<UpdateGroupNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupNameHeaders({ });
    return await this.updateGroupNameWithOptions(request, headers, runtime);
  }

  async updateGroupNameWithOptions(request: UpdateGroupNameRequest, headers: UpdateGroupNameHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupNameResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateGroupNameResponse>(await this.doROARequest("UpdateGroupName", "impaas_1.0", "HTTP", "PUT", "AK", `/v1.0/impaas/interconnections/groups/names`, "none", req, runtime), new UpdateGroupNameResponse({}));
  }

  async createGroup(request: CreateGroupRequest): Promise<CreateGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupHeaders({ });
    return await this.createGroupWithOptions(request, headers, runtime);
  }

  async createGroupWithOptions(request: CreateGroupRequest, headers: CreateGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.creatorUid)) {
      body["creatorUid"] = request.creatorUid;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.iconMediaId)) {
      body["iconMediaId"] = request.iconMediaId;
    }

    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.properties)) {
      body["properties"] = request.properties;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateGroupResponse>(await this.doROARequest("CreateGroup", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/groups`, "json", req, runtime), new CreateGroupResponse({}));
  }

  async updateGroupOwner(request: UpdateGroupOwnerRequest): Promise<UpdateGroupOwnerResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupOwnerHeaders({ });
    return await this.updateGroupOwnerWithOptions(request, headers, runtime);
  }

  async updateGroupOwnerWithOptions(request: UpdateGroupOwnerRequest, headers: UpdateGroupOwnerHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupOwnerResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ownerId)) {
      body["ownerId"] = request.ownerId;
    }

    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateGroupOwnerResponse>(await this.doROARequest("UpdateGroupOwner", "impaas_1.0", "HTTP", "PUT", "AK", `/v1.0/impaas/interconnections/groups/owners`, "none", req, runtime), new UpdateGroupOwnerResponse({}));
  }

  async removeGroupMembers(request: RemoveGroupMembersRequest): Promise<RemoveGroupMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveGroupMembersHeaders({ });
    return await this.removeGroupMembersWithOptions(request, headers, runtime);
  }

  async removeGroupMembersWithOptions(request: RemoveGroupMembersRequest, headers: RemoveGroupMembersHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveGroupMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.memberUids)) {
      body["memberUids"] = request.memberUids;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<RemoveGroupMembersResponse>(await this.doROARequest("RemoveGroupMembers", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/groups/members/batchRemove`, "none", req, runtime), new RemoveGroupMembersResponse({}));
  }

  async getMediaUrl(request: GetMediaUrlRequest): Promise<GetMediaUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMediaUrlHeaders({ });
    return await this.getMediaUrlWithOptions(request, headers, runtime);
  }

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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetMediaUrlResponse>(await this.doROARequest("GetMediaUrl", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/medium/urls`, "json", req, runtime), new GetMediaUrlResponse({}));
  }

  async readMessage(request: ReadMessageRequest): Promise<ReadMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReadMessageHeaders({ });
    return await this.readMessageWithOptions(request, headers, runtime);
  }

  async readMessageWithOptions(request: ReadMessageRequest, headers: ReadMessageHeaders, runtime: $Util.RuntimeOptions): Promise<ReadMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ReadMessageResponse>(await this.doROARequest("ReadMessage", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/messages/read`, "none", req, runtime), new ReadMessageResponse({}));
  }

  async dismissGroup(request: DismissGroupRequest): Promise<DismissGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DismissGroupHeaders({ });
    return await this.dismissGroupWithOptions(request, headers, runtime);
  }

  async dismissGroupWithOptions(request: DismissGroupRequest, headers: DismissGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DismissGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<DismissGroupResponse>(await this.doROARequest("DismissGroup", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/groups/dismiss`, "none", req, runtime), new DismissGroupResponse({}));
  }

  async addProfile(request: AddProfileRequest): Promise<AddProfileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddProfileHeaders({ });
    return await this.addProfileWithOptions(request, headers, runtime);
  }

  async addProfileWithOptions(request: AddProfileRequest, headers: AddProfileHeaders, runtime: $Util.RuntimeOptions): Promise<AddProfileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nick)) {
      body["nick"] = request.nick;
    }

    if (!Util.isUnset(request.avatarMediaId)) {
      body["avatarMediaId"] = request.avatarMediaId;
    }

    if (!Util.isUnset(request.appUid)) {
      body["appUid"] = request.appUid;
    }

    if (!Util.isUnset(request.mobileNumber)) {
      body["mobileNumber"] = request.mobileNumber;
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
    return $tea.cast<AddProfileResponse>(await this.doROARequest("AddProfile", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/users/profiles`, "none", req, runtime), new AddProfileResponse({}));
  }

  async addGroupMembers(request: AddGroupMembersRequest): Promise<AddGroupMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddGroupMembersHeaders({ });
    return await this.addGroupMembersWithOptions(request, headers, runtime);
  }

  async addGroupMembersWithOptions(request: AddGroupMembersRequest, headers: AddGroupMembersHeaders, runtime: $Util.RuntimeOptions): Promise<AddGroupMembersResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.members)) {
      body["members"] = request.members;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<AddGroupMembersResponse>(await this.doROARequest("AddGroupMembers", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/groups/members/batchAdd`, "json", req, runtime), new AddGroupMembersResponse({}));
  }

  async batchSend(request: BatchSendRequest): Promise<BatchSendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendHeaders({ });
    return await this.batchSendWithOptions(request, headers, runtime);
  }

  async batchSendWithOptions(request: BatchSendRequest, headers: BatchSendHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.appUids)) {
      body["appUids"] = request.appUids;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
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
    return $tea.cast<BatchSendResponse>(await this.doROARequest("BatchSend", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/messages/batchSend`, "json", req, runtime), new BatchSendResponse({}));
  }

  async listGroupStaffMembers(request: ListGroupStaffMembersRequest): Promise<ListGroupStaffMembersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListGroupStaffMembersHeaders({ });
    return await this.listGroupStaffMembersWithOptions(request, headers, runtime);
  }

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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<ListGroupStaffMembersResponse>(await this.doROARequest("ListGroupStaffMembers", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/groups/staffMemers/query`, "json", req, runtime), new ListGroupStaffMembersResponse({}));
  }

  async sendMessage(request: SendMessageRequest): Promise<SendMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageHeaders({ });
    return await this.sendMessageWithOptions(request, headers, runtime);
  }

  async sendMessageWithOptions(request: SendMessageRequest, headers: SendMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.senderUid)) {
      body["senderUid"] = request.senderUid;
    }

    if (!Util.isUnset(request.receiverUid)) {
      body["receiverUid"] = request.receiverUid;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.createTime)) {
      body["createTime"] = request.createTime;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.operationSource)) {
      realHeaders["operationSource"] = headers.operationSource;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<SendMessageResponse>(await this.doROARequest("SendMessage", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/messages/send`, "json", req, runtime), new SendMessageResponse({}));
  }

}
