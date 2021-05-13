// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class DeleteKnowledgeHeaders extends $tea.Model {
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

export class DeleteKnowledgeRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  libraryKey?: string;
  source?: string;
  sourcePrimaryKey?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      libraryKey: 'libraryKey',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      libraryKey: 'string',
      source: 'string',
      sourcePrimaryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteKnowledgeResponseBody extends $tea.Model {
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

export class DeleteKnowledgeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteKnowledgeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchGroupHeaders extends $tea.Model {
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

export class SearchGroupRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openConversationId?: string;
  groupName?: string;
  openTeamId?: string;
  openGroupSetId?: string;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openConversationId: 'openConversationId',
      groupName: 'groupName',
      openTeamId: 'openTeamId',
      openGroupSetId: 'openGroupSetId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openConversationId: 'string',
      groupName: 'string',
      openTeamId: 'string',
      openGroupSetId: 'string',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchGroupResponseBody extends $tea.Model {
  totalCount?: number;
  nextToken?: string;
  maxResults?: number;
  records?: SearchGroupResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      nextToken: 'string',
      maxResults: 'number',
      records: { 'type': 'array', 'itemType': SearchGroupResponseBodyRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SearchGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SearchGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupHeaders extends $tea.Model {
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

export class CreateGroupRequest extends $tea.Model {
  groupBizId?: string;
  openTeamId?: string;
  openGroupSetId?: string;
  groupName?: string;
  ownerStaffId?: string;
  memberStaffIds?: string[];
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      groupBizId: 'groupBizId',
      openTeamId: 'openTeamId',
      openGroupSetId: 'openGroupSetId',
      groupName: 'groupName',
      ownerStaffId: 'ownerStaffId',
      memberStaffIds: 'memberStaffIds',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupBizId: 'string',
      openTeamId: 'string',
      openGroupSetId: 'string',
      groupName: 'string',
      ownerStaffId: 'string',
      memberStaffIds: { 'type': 'array', 'itemType': 'string' },
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponseBody extends $tea.Model {
  openConversationId?: string;
  groupUrl?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      groupUrl: 'groupUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      groupUrl: 'string',
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

export class SendServiceGroupMessageHeaders extends $tea.Model {
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

export class SendServiceGroupMessageRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  targetOpenConversationId?: string;
  title?: string;
  content?: string;
  isAtAll?: boolean;
  atMobiles?: string[];
  atDingtalkIds?: string[];
  atUnionIds?: string[];
  receiverMobiles?: string[];
  receiverDingtalkIds?: string[];
  receiverUnionIds?: string[];
  messageType?: string;
  btnOrientation?: string;
  btns?: SendServiceGroupMessageRequestBtns[];
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      targetOpenConversationId: 'targetOpenConversationId',
      title: 'title',
      content: 'content',
      isAtAll: 'isAtAll',
      atMobiles: 'atMobiles',
      atDingtalkIds: 'atDingtalkIds',
      atUnionIds: 'atUnionIds',
      receiverMobiles: 'receiverMobiles',
      receiverDingtalkIds: 'receiverDingtalkIds',
      receiverUnionIds: 'receiverUnionIds',
      messageType: 'messageType',
      btnOrientation: 'btnOrientation',
      btns: 'btns',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      targetOpenConversationId: 'string',
      title: 'string',
      content: 'string',
      isAtAll: 'boolean',
      atMobiles: { 'type': 'array', 'itemType': 'string' },
      atDingtalkIds: { 'type': 'array', 'itemType': 'string' },
      atUnionIds: { 'type': 'array', 'itemType': 'string' },
      receiverMobiles: { 'type': 'array', 'itemType': 'string' },
      receiverDingtalkIds: { 'type': 'array', 'itemType': 'string' },
      receiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      messageType: 'string',
      btnOrientation: 'string',
      btns: { 'type': 'array', 'itemType': SendServiceGroupMessageRequestBtns },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendServiceGroupMessageResponseBody extends $tea.Model {
  openMsgTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      openMsgTaskId: 'openMsgTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openMsgTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendServiceGroupMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendServiceGroupMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendServiceGroupMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeHeaders extends $tea.Model {
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

export class AddKnowledgeRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  libraryKey?: string;
  source?: string;
  sourcePrimaryKey?: string;
  type?: string;
  title?: string;
  content?: string;
  linkUrl?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      libraryKey: 'libraryKey',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
      type: 'type',
      title: 'title',
      content: 'content',
      linkUrl: 'linkUrl',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      libraryKey: 'string',
      source: 'string',
      sourcePrimaryKey: 'string',
      type: 'string',
      title: 'string',
      content: 'string',
      linkUrl: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeResponseBody extends $tea.Model {
  openKnowledgeId?: string;
  static names(): { [key: string]: string } {
    return {
      openKnowledgeId: 'openKnowledgeId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openKnowledgeId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddKnowledgeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceGroupMessageReadStatusHeaders extends $tea.Model {
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

export class QueryServiceGroupMessageReadStatusRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  openTeamId?: string;
  openConversationId?: string;
  openMsgTaskId?: string;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      openTeamId: 'openTeamId',
      openConversationId: 'openConversationId',
      openMsgTaskId: 'openMsgTaskId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      openTeamId: 'string',
      openConversationId: 'string',
      openMsgTaskId: 'string',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceGroupMessageReadStatusResponseBody extends $tea.Model {
  totalCount?: number;
  nextToken?: string;
  maxResults?: number;
  records?: QueryServiceGroupMessageReadStatusResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      totalCount: 'totalCount',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      totalCount: 'number',
      nextToken: 'string',
      maxResults: 'number',
      records: { 'type': 'array', 'itemType': QueryServiceGroupMessageReadStatusResponseBodyRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceGroupMessageReadStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryServiceGroupMessageReadStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryServiceGroupMessageReadStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLibraryHeaders extends $tea.Model {
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

export class AddLibraryRequest extends $tea.Model {
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingOrgId?: number;
  openTeamIds?: string[];
  title?: string;
  description?: string;
  type?: string;
  source?: string;
  sourcePrimaryKey?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingOrgId: 'dingOrgId',
      openTeamIds: 'openTeamIds',
      title: 'title',
      description: 'description',
      type: 'type',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingOrgId: 'number',
      openTeamIds: { 'type': 'array', 'itemType': 'string' },
      title: 'string',
      description: 'string',
      type: 'string',
      source: 'string',
      sourcePrimaryKey: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddLibraryResponseBody extends $tea.Model {
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

export class AddLibraryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddLibraryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddLibraryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserTeamsHeaders extends $tea.Model {
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

export class ListUserTeamsResponseBody extends $tea.Model {
  teams?: ListUserTeamsResponseBodyTeams[];
  static names(): { [key: string]: string } {
    return {
      teams: 'teams',
    };
  }

  static types(): { [key: string]: any } {
    return {
      teams: { 'type': 'array', 'itemType': ListUserTeamsResponseBodyTeams },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserTeamsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListUserTeamsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListUserTeamsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupHeaders extends $tea.Model {
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

export class QueryGroupRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openConversationId?: string;
  bizId?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openConversationId: 'openConversationId',
      bizId: 'bizId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openConversationId: 'string',
      bizId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupResponseBody extends $tea.Model {
  openConversationId?: string;
  groupName?: string;
  openTeamId?: string;
  openGroupSetId?: string;
  groupUrl?: string;
  robotCode?: string;
  robotName?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      groupName: 'groupName',
      openTeamId: 'openTeamId',
      openGroupSetId: 'openGroupSetId',
      groupUrl: 'groupUrl',
      robotCode: 'robotCode',
      robotName: 'robotName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      groupName: 'string',
      openTeamId: 'string',
      openGroupSetId: 'string',
      groupUrl: 'string',
      robotCode: 'string',
      robotName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchGroupResponseBodyRecords extends $tea.Model {
  openConversationId?: string;
  groupName?: string;
  openTeamId?: string;
  openGroupSetId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      groupName: 'groupName',
      openTeamId: 'openTeamId',
      openGroupSetId: 'openGroupSetId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      groupName: 'string',
      openTeamId: 'string',
      openGroupSetId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendServiceGroupMessageRequestBtns extends $tea.Model {
  actionURL?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionURL: 'actionURL',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionURL: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceGroupMessageReadStatusResponseBodyRecords extends $tea.Model {
  receiverUserId?: string;
  receiverUnionId?: string;
  readStatus?: number;
  receiverName?: string;
  receiverDingTalkId?: string;
  static names(): { [key: string]: string } {
    return {
      receiverUserId: 'receiverUserId',
      receiverUnionId: 'receiverUnionId',
      readStatus: 'readStatus',
      receiverName: 'receiverName',
      receiverDingTalkId: 'receiverDingTalkId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receiverUserId: 'string',
      receiverUnionId: 'string',
      readStatus: 'number',
      receiverName: 'string',
      receiverDingTalkId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListUserTeamsResponseBodyTeams extends $tea.Model {
  openTeamId?: string;
  teamName?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      teamName: 'teamName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      teamName: 'string',
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


  async deleteKnowledge(request: DeleteKnowledgeRequest): Promise<DeleteKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKnowledgeHeaders({ });
    return await this.deleteKnowledgeWithOptions(request, headers, runtime);
  }

  async deleteKnowledgeWithOptions(request: DeleteKnowledgeRequest, headers: DeleteKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.libraryKey)) {
      body["libraryKey"] = request.libraryKey;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
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
    return $tea.cast<DeleteKnowledgeResponse>(await this.doROARequest("DeleteKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/knowledges/batchDelete`, "json", req, runtime), new DeleteKnowledgeResponse({}));
  }

  async searchGroup(request: SearchGroupRequest): Promise<SearchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchGroupHeaders({ });
    return await this.searchGroupWithOptions(request, headers, runtime);
  }

  async searchGroupWithOptions(request: SearchGroupRequest, headers: SearchGroupHeaders, runtime: $Util.RuntimeOptions): Promise<SearchGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
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
    return $tea.cast<SearchGroupResponse>(await this.doROARequest("SearchGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups/search`, "json", req, runtime), new SearchGroupResponse({}));
  }

  async createGroup(request: CreateGroupRequest): Promise<CreateGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupHeaders({ });
    return await this.createGroupWithOptions(request, headers, runtime);
  }

  async createGroupWithOptions(request: CreateGroupRequest, headers: CreateGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupBizId)) {
      body["groupBizId"] = request.groupBizId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.ownerStaffId)) {
      body["ownerStaffId"] = request.ownerStaffId;
    }

    if (!Util.isUnset(request.memberStaffIds)) {
      body["memberStaffIds"] = request.memberStaffIds;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
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
    return $tea.cast<CreateGroupResponse>(await this.doROARequest("CreateGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups`, "json", req, runtime), new CreateGroupResponse({}));
  }

  async sendServiceGroupMessage(request: SendServiceGroupMessageRequest): Promise<SendServiceGroupMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendServiceGroupMessageHeaders({ });
    return await this.sendServiceGroupMessageWithOptions(request, headers, runtime);
  }

  async sendServiceGroupMessageWithOptions(request: SendServiceGroupMessageRequest, headers: SendServiceGroupMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendServiceGroupMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.targetOpenConversationId)) {
      body["targetOpenConversationId"] = request.targetOpenConversationId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.isAtAll)) {
      body["isAtAll"] = request.isAtAll;
    }

    if (!Util.isUnset(request.atMobiles)) {
      body["atMobiles"] = request.atMobiles;
    }

    if (!Util.isUnset(request.atDingtalkIds)) {
      body["atDingtalkIds"] = request.atDingtalkIds;
    }

    if (!Util.isUnset(request.atUnionIds)) {
      body["atUnionIds"] = request.atUnionIds;
    }

    if (!Util.isUnset(request.receiverMobiles)) {
      body["receiverMobiles"] = request.receiverMobiles;
    }

    if (!Util.isUnset(request.receiverDingtalkIds)) {
      body["receiverDingtalkIds"] = request.receiverDingtalkIds;
    }

    if (!Util.isUnset(request.receiverUnionIds)) {
      body["receiverUnionIds"] = request.receiverUnionIds;
    }

    if (!Util.isUnset(request.messageType)) {
      body["messageType"] = request.messageType;
    }

    if (!Util.isUnset(request.btnOrientation)) {
      body["btnOrientation"] = request.btnOrientation;
    }

    if (!Util.isUnset(request.btns)) {
      body["btns"] = request.btns;
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
    return $tea.cast<SendServiceGroupMessageResponse>(await this.doROARequest("SendServiceGroupMessage", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/messages/send`, "json", req, runtime), new SendServiceGroupMessageResponse({}));
  }

  async addKnowledge(request: AddKnowledgeRequest): Promise<AddKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddKnowledgeHeaders({ });
    return await this.addKnowledgeWithOptions(request, headers, runtime);
  }

  async addKnowledgeWithOptions(request: AddKnowledgeRequest, headers: AddKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<AddKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.libraryKey)) {
      body["libraryKey"] = request.libraryKey;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.linkUrl)) {
      body["linkUrl"] = request.linkUrl;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<AddKnowledgeResponse>(await this.doROARequest("AddKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/knowledges`, "json", req, runtime), new AddKnowledgeResponse({}));
  }

  async queryServiceGroupMessageReadStatus(request: QueryServiceGroupMessageReadStatusRequest): Promise<QueryServiceGroupMessageReadStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryServiceGroupMessageReadStatusHeaders({ });
    return await this.queryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
  }

  async queryServiceGroupMessageReadStatusWithOptions(request: QueryServiceGroupMessageReadStatusRequest, headers: QueryServiceGroupMessageReadStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryServiceGroupMessageReadStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openMsgTaskId)) {
      body["openMsgTaskId"] = request.openMsgTaskId;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
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
    return $tea.cast<QueryServiceGroupMessageReadStatusResponse>(await this.doROARequest("QueryServiceGroupMessageReadStatus", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/messages/readStatus/query`, "json", req, runtime), new QueryServiceGroupMessageReadStatusResponse({}));
  }

  async addLibrary(request: AddLibraryRequest): Promise<AddLibraryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLibraryHeaders({ });
    return await this.addLibraryWithOptions(request, headers, runtime);
  }

  async addLibraryWithOptions(request: AddLibraryRequest, headers: AddLibraryHeaders, runtime: $Util.RuntimeOptions): Promise<AddLibraryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.openTeamIds)) {
      body["openTeamIds"] = request.openTeamIds;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<AddLibraryResponse>(await this.doROARequest("AddLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/librarys`, "json", req, runtime), new AddLibraryResponse({}));
  }

  async listUserTeams(userId: string): Promise<ListUserTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserTeamsHeaders({ });
    return await this.listUserTeamsWithOptions(userId, headers, runtime);
  }

  async listUserTeamsWithOptions(userId: string, headers: ListUserTeamsHeaders, runtime: $Util.RuntimeOptions): Promise<ListUserTeamsResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<ListUserTeamsResponse>(await this.doROARequest("ListUserTeams", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/users/${userId}/teams`, "json", req, runtime), new ListUserTeamsResponse({}));
  }

  async queryGroup(request: QueryGroupRequest): Promise<QueryGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupHeaders({ });
    return await this.queryGroupWithOptions(request, headers, runtime);
  }

  async queryGroupWithOptions(request: QueryGroupRequest, headers: QueryGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
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
    return $tea.cast<QueryGroupResponse>(await this.doROARequest("QueryGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups/query`, "json", req, runtime), new QueryGroupResponse({}));
  }

}
