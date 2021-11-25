// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AssignTicketHeaders extends $tea.Model {
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

export class AssignTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  operatorUnionId?: string;
  openTicketId?: string;
  processorUnionIds?: string[];
  ticketMemo?: AssignTicketRequestTicketMemo;
  notify?: AssignTicketRequestNotify;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      operatorUnionId: 'operatorUnionId',
      openTicketId: 'openTicketId',
      processorUnionIds: 'processorUnionIds',
      ticketMemo: 'ticketMemo',
      notify: 'notify',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      operatorUnionId: 'string',
      openTicketId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      ticketMemo: AssignTicketRequestTicketMemo,
      notify: AssignTicketRequestNotify,
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignTicketResponse extends $tea.Model {
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

export class UpdateTicketHeaders extends $tea.Model {
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

export class UpdateTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  processorUnionId?: string;
  openTicketId?: string;
  customFields?: string;
  ticketMemo?: UpdateTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      processorUnionId: 'processorUnionId',
      openTicketId: 'openTicketId',
      customFields: 'customFields',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      processorUnionId: 'string',
      openTicketId: 'string',
      customFields: 'string',
      ticketMemo: UpdateTicketRequestTicketMemo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTicketResponse extends $tea.Model {
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

export class UpgradeNormalGroupHeaders extends $tea.Model {
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

export class UpgradeNormalGroupRequest extends $tea.Model {
  openGroupSetId?: string;
  templateId?: string;
  openConversationId?: string;
  openTeamId?: string;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  static names(): { [key: string]: string } {
    return {
      openGroupSetId: 'openGroupSetId',
      templateId: 'templateId',
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openGroupSetId: 'string',
      templateId: 'string',
      openConversationId: 'string',
      openTeamId: 'string',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeNormalGroupResponse extends $tea.Model {
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
  extTitle?: string;
  keyword?: string;
  attachmentList?: AddKnowledgeRequestAttachmentList[];
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
      extTitle: 'extTitle',
      keyword: 'keyword',
      attachmentList: 'attachmentList',
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
      extTitle: 'string',
      keyword: 'string',
      attachmentList: { 'type': 'array', 'itemType': AddKnowledgeRequestAttachmentList },
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

export class BatchGetGroupSetConfigHeaders extends $tea.Model {
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

export class BatchGetGroupSetConfigRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  openGroupSetId?: string;
  configKeys?: string[];
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      openGroupSetId: 'openGroupSetId',
      configKeys: 'configKeys',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      openGroupSetId: 'string',
      configKeys: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetGroupSetConfigResponseBody extends $tea.Model {
  groupSetConfigs?: BatchGetGroupSetConfigResponseBodyGroupSetConfigs[];
  static names(): { [key: string]: string } {
    return {
      groupSetConfigs: 'groupSetConfigs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupSetConfigs: { 'type': 'array', 'itemType': BatchGetGroupSetConfigResponseBodyGroupSetConfigs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetGroupSetConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchGetGroupSetConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchGetGroupSetConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordHeaders extends $tea.Model {
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

export class ListTicketOperateRecordRequest extends $tea.Model {
  openTeamId?: string;
  openTicketId?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      openTicketId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponseBody extends $tea.Model {
  records?: ListTicketOperateRecordResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      records: { 'type': 'array', 'itemType': ListTicketOperateRecordResponseBodyRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListTicketOperateRecordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListTicketOperateRecordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetractTicketHeaders extends $tea.Model {
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

export class RetractTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  openTeamId?: string;
  openTicketId?: string;
  operatorUnionId?: string;
  ticketMemo?: RetractTicketRequestTicketMemo;
  notify?: RetractTicketRequestNotify;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      operatorUnionId: 'operatorUnionId',
      ticketMemo: 'ticketMemo',
      notify: 'notify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      openTeamId: 'string',
      openTicketId: 'string',
      operatorUnionId: 'string',
      ticketMemo: RetractTicketRequestTicketMemo,
      notify: RetractTicketRequestNotify,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetractTicketResponse extends $tea.Model {
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
  openTeamId?: string;
  openConversationId?: string;
  bizId?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
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
      openTeamId: 'string',
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
  bizId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      groupName: 'groupName',
      openTeamId: 'openTeamId',
      openGroupSetId: 'openGroupSetId',
      groupUrl: 'groupUrl',
      robotCode: 'robotCode',
      robotName: 'robotName',
      bizId: 'bizId',
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
      bizId: 'string',
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

export class CloseHumanSessionHeaders extends $tea.Model {
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

export class CloseHumanSessionRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  openConversationId?: string;
  visitorUnionId?: number;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      openConversationId: 'openConversationId',
      visitorUnionId: 'visitorUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      openConversationId: 'string',
      visitorUnionId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseHumanSessionResponseBody extends $tea.Model {
  sessionId?: number;
  static names(): { [key: string]: string } {
    return {
      sessionId: 'sessionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sessionId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseHumanSessionResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CloseHumanSessionResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CloseHumanSessionResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UrgeTicketHeaders extends $tea.Model {
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

export class UrgeTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  operatorUnionId?: string;
  openTicketId?: string;
  ticketMemo?: UrgeTicketRequestTicketMemo;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      operatorUnionId: 'operatorUnionId',
      openTicketId: 'openTicketId',
      ticketMemo: 'ticketMemo',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      operatorUnionId: 'string',
      openTicketId: 'string',
      ticketMemo: UrgeTicketRequestTicketMemo,
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UrgeTicketResponse extends $tea.Model {
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

export class GetTicketHeaders extends $tea.Model {
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

export class GetTicketRequest extends $tea.Model {
  openTeamId?: string;
  openTicketId?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      openTicketId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBody extends $tea.Model {
  openTicketId?: string;
  createTime?: string;
  updateTime?: string;
  openConversationId?: string;
  creator?: GetTicketResponseBodyCreator;
  processor?: GetTicketResponseBodyProcessor;
  takers?: GetTicketResponseBodyTakers[];
  stage?: string;
  title?: string;
  customFields?: string;
  scene?: string;
  sceneContext?: string;
  template?: GetTicketResponseBodyTemplate;
  static names(): { [key: string]: string } {
    return {
      openTicketId: 'openTicketId',
      createTime: 'createTime',
      updateTime: 'updateTime',
      openConversationId: 'openConversationId',
      creator: 'creator',
      processor: 'processor',
      takers: 'takers',
      stage: 'stage',
      title: 'title',
      customFields: 'customFields',
      scene: 'scene',
      sceneContext: 'sceneContext',
      template: 'template',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTicketId: 'string',
      createTime: 'string',
      updateTime: 'string',
      openConversationId: 'string',
      creator: GetTicketResponseBodyCreator,
      processor: GetTicketResponseBodyProcessor,
      takers: { 'type': 'array', 'itemType': GetTicketResponseBodyTakers },
      stage: 'string',
      title: 'string',
      customFields: 'string',
      scene: 'string',
      sceneContext: 'string',
      template: GetTicketResponseBodyTemplate,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTicketResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TakeTicketHeaders extends $tea.Model {
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

export class TakeTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  takerUnionId?: string;
  openTicketId?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      takerUnionId: 'takerUnionId',
      openTicketId: 'openTicketId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      takerUnionId: 'string',
      openTicketId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TakeTicketResponse extends $tea.Model {
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
  hasContentLinks?: boolean;
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
      hasContentLinks: 'hasContentLinks',
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
      hasContentLinks: 'boolean',
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

export class UpgradeCloudGroupHeaders extends $tea.Model {
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

export class UpgradeCloudGroupRequest extends $tea.Model {
  openConversationId?: string;
  templateId?: string;
  openGroupSetId?: string;
  ccsInstanceId?: string;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      templateId: 'templateId',
      openGroupSetId: 'openGroupSetId',
      ccsInstanceId: 'ccsInstanceId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      templateId: 'string',
      openGroupSetId: 'string',
      ccsInstanceId: 'string',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpgradeCloudGroupResponse extends $tea.Model {
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

export class ResubmitTicketHeaders extends $tea.Model {
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

export class ResubmitTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  openTeamId?: string;
  creatorUnionId?: string;
  processorUnionIds?: string[];
  scene?: string;
  sceneContext?: ResubmitTicketRequestSceneContext;
  title?: string;
  openTemplateBizId?: string;
  customFields?: string;
  notify?: ResubmitTicketRequestNotify;
  openTicketId?: string;
  ticketMemo?: ResubmitTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      openTeamId: 'openTeamId',
      creatorUnionId: 'creatorUnionId',
      processorUnionIds: 'processorUnionIds',
      scene: 'scene',
      sceneContext: 'sceneContext',
      title: 'title',
      openTemplateBizId: 'openTemplateBizId',
      customFields: 'customFields',
      notify: 'notify',
      openTicketId: 'openTicketId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      openTeamId: 'string',
      creatorUnionId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      scene: 'string',
      sceneContext: ResubmitTicketRequestSceneContext,
      title: 'string',
      openTemplateBizId: 'string',
      customFields: 'string',
      notify: ResubmitTicketRequestNotify,
      openTicketId: 'string',
      ticketMemo: ResubmitTicketRequestTicketMemo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketResponse extends $tea.Model {
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

export class AddTicketMemoHeaders extends $tea.Model {
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

export class AddTicketMemoRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  processorUnionId?: string;
  openTicketId?: string;
  ticketMemo?: AddTicketMemoRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      processorUnionId: 'processorUnionId',
      openTicketId: 'openTicketId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      processorUnionId: 'string',
      openTicketId: 'string',
      ticketMemo: AddTicketMemoRequestTicketMemo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTicketMemoResponse extends $tea.Model {
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

export class QueryGroupSetHeaders extends $tea.Model {
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

export class QueryGroupSetRequest extends $tea.Model {
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupSetResponseBody extends $tea.Model {
  records?: QueryGroupSetResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      records: { 'type': 'array', 'itemType': QueryGroupSetResponseBodyRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryGroupSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGroupSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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

export class CreateTicketHeaders extends $tea.Model {
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

export class CreateTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  creatorUnionId?: string;
  processorUnionIds?: string[];
  scene?: string;
  sceneContext?: CreateTicketRequestSceneContext;
  openTemplateBizId?: string;
  title?: string;
  customFields?: string;
  notify?: CreateTicketRequestNotify;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      creatorUnionId: 'creatorUnionId',
      processorUnionIds: 'processorUnionIds',
      scene: 'scene',
      sceneContext: 'sceneContext',
      openTemplateBizId: 'openTemplateBizId',
      title: 'title',
      customFields: 'customFields',
      notify: 'notify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      creatorUnionId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      scene: 'string',
      sceneContext: CreateTicketRequestSceneContext,
      openTemplateBizId: 'string',
      title: 'string',
      customFields: 'string',
      notify: CreateTicketRequestNotify,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketResponseBody extends $tea.Model {
  openTicketId?: string;
  static names(): { [key: string]: string } {
    return {
      openTicketId: 'openTicketId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTicketId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTicketResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishTicketHeaders extends $tea.Model {
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

export class FinishTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  processorUnionId?: string;
  openTicketId?: string;
  ticketMemo?: FinishTicketRequestTicketMemo;
  notify?: FinishTicketRequestNotify;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      processorUnionId: 'processorUnionId',
      openTicketId: 'openTicketId',
      ticketMemo: 'ticketMemo',
      notify: 'notify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      processorUnionId: 'string',
      openTicketId: 'string',
      ticketMemo: FinishTicketRequestTicketMemo,
      notify: FinishTicketRequestNotify,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishTicketResponse extends $tea.Model {
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
  searchType?: string;
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
      searchType: 'searchType',
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
      searchType: 'string',
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
  groupTagNames?: string[];
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
      groupTagNames: 'groupTagNames',
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
      groupTagNames: { 'type': 'array', 'itemType': 'string' },
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

export class TransferTicketHeaders extends $tea.Model {
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

export class TransferTicketRequest extends $tea.Model {
  processorUnionId?: string;
  openTicketId?: string;
  processorUnionIds?: string[];
  ticketMemo?: TransferTicketRequestTicketMemo;
  notify?: TransferTicketRequestNotify;
  openTeamId?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      processorUnionId: 'processorUnionId',
      openTicketId: 'openTicketId',
      processorUnionIds: 'processorUnionIds',
      ticketMemo: 'ticketMemo',
      notify: 'notify',
      openTeamId: 'openTeamId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processorUnionId: 'string',
      openTicketId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      ticketMemo: TransferTicketRequestTicketMemo,
      notify: TransferTicketRequestNotify,
      openTeamId: 'string',
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

export class TransferTicketResponse extends $tea.Model {
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

export class AddOpenLibraryHeaders extends $tea.Model {
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

export class AddOpenLibraryRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  dingOrgId?: number;
  openTeamId?: string;
  userId?: string;
  userName?: string;
  title?: string;
  description?: string;
  type?: string;
  source?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      dingOrgId: 'dingOrgId',
      openTeamId: 'openTeamId',
      userId: 'userId',
      userName: 'userName',
      title: 'title',
      description: 'description',
      type: 'type',
      source: 'source',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      dingOrgId: 'number',
      openTeamId: 'string',
      userId: 'string',
      userName: 'string',
      title: 'string',
      description: 'string',
      type: 'string',
      source: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenLibraryResponseBody extends $tea.Model {
  success?: boolean;
  result?: AddOpenLibraryResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: AddOpenLibraryResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenLibraryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddOpenLibraryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddOpenLibraryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUsersHeaders extends $tea.Model {
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

export class QueryActiveUsersRequest extends $tea.Model {
  openTeamId?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUsersResponseBody extends $tea.Model {
  activeUserInfos?: QueryActiveUsersResponseBodyActiveUserInfos[];
  static names(): { [key: string]: string } {
    return {
      activeUserInfos: 'activeUserInfos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeUserInfos: { 'type': 'array', 'itemType': QueryActiveUsersResponseBodyActiveUserInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryActiveUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryActiveUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenCategoryHeaders extends $tea.Model {
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

export class AddOpenCategoryRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingTokenGrantType?: number;
  dingSuiteKey?: string;
  dingOrgId?: number;
  openTeamId?: string;
  userId?: string;
  userName?: string;
  title?: string;
  parentId?: number;
  libraryId?: number;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingSuiteKey: 'dingSuiteKey',
      dingOrgId: 'dingOrgId',
      openTeamId: 'openTeamId',
      userId: 'userId',
      userName: 'userName',
      title: 'title',
      parentId: 'parentId',
      libraryId: 'libraryId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingTokenGrantType: 'number',
      dingSuiteKey: 'string',
      dingOrgId: 'number',
      openTeamId: 'string',
      userId: 'string',
      userName: 'string',
      title: 'string',
      parentId: 'number',
      libraryId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenCategoryResponseBody extends $tea.Model {
  success?: boolean;
  result?: AddOpenCategoryResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: AddOpenCategoryResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenCategoryResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddOpenCategoryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddOpenCategoryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetHeaders extends $tea.Model {
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

export class CreateGroupSetRequest extends $tea.Model {
  openTeamId?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  groupSetName?: string;
  groupTemplateId?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      groupSetName: 'groupSetName',
      groupTemplateId: 'groupTemplateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      groupSetName: 'string',
      groupTemplateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupSetResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateGroupSetResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateGroupSetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BoundTemplateToTeamHeaders extends $tea.Model {
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

export class BoundTemplateToTeamRequest extends $tea.Model {
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  openTeamId?: string;
  templateId?: string;
  templateName?: string;
  templateType?: string;
  templateDesc?: string;
  robotConfig?: string;
  static names(): { [key: string]: string } {
    return {
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
      openTeamId: 'openTeamId',
      templateId: 'templateId',
      templateName: 'templateName',
      templateType: 'templateType',
      templateDesc: 'templateDesc',
      robotConfig: 'robotConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
      openTeamId: 'string',
      templateId: 'string',
      templateName: 'string',
      templateType: 'string',
      templateDesc: 'string',
      robotConfig: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BoundTemplateToTeamResponseBody extends $tea.Model {
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

export class BoundTemplateToTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BoundTemplateToTeamResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BoundTemplateToTeamResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOssTempUrlHeaders extends $tea.Model {
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

export class GetOssTempUrlRequest extends $tea.Model {
  openTeamId?: string;
  key?: string;
  fileName?: string;
  fetchMode?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      key: 'key',
      fileName: 'fileName',
      fetchMode: 'fetchMode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      key: 'string',
      fileName: 'string',
      fetchMode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOssTempUrlResponseBody extends $tea.Model {
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

export class GetOssTempUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetOssTempUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetOssTempUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelTicketHeaders extends $tea.Model {
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

export class CancelTicketRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  openTicketId?: string;
  operatorUnionId?: string;
  ticketMemo?: CancelTicketRequestTicketMemo;
  notify?: CancelTicketRequestNotify;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      operatorUnionId: 'operatorUnionId',
      ticketMemo: 'ticketMemo',
      notify: 'notify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      openTicketId: 'string',
      operatorUnionId: 'string',
      ticketMemo: CancelTicketRequestTicketMemo,
      notify: CancelTicketRequestNotify,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelTicketResponse extends $tea.Model {
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

export class UpdateGroupTagHeaders extends $tea.Model {
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

export class UpdateGroupTagRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openConversationIds?: string[];
  tagNames?: string[];
  updateType?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openConversationIds: 'openConversationIds',
      tagNames: 'tagNames',
      updateType: 'updateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      tagNames: { 'type': 'array', 'itemType': 'string' },
      updateType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupTagResponse extends $tea.Model {
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

export class AddOpenKnowledgeHeaders extends $tea.Model {
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

export class AddOpenKnowledgeRequest extends $tea.Model {
  dingTokenGrantType?: number;
  dingIsvOrgId?: number;
  dingSuiteKey?: string;
  dingOrgId?: number;
  openTeamId?: string;
  userId?: string;
  userName?: string;
  attachments?: AddOpenKnowledgeRequestAttachments[];
  libraryId?: number;
  source?: string;
  title?: string;
  type?: string;
  content?: string;
  extTitle?: string;
  keyword?: string;
  tags?: string;
  effectTimestart?: string;
  effectTimeend?: string;
  categoryId?: number;
  static names(): { [key: string]: string } {
    return {
      dingTokenGrantType: 'dingTokenGrantType',
      dingIsvOrgId: 'dingIsvOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingOrgId: 'dingOrgId',
      openTeamId: 'openTeamId',
      userId: 'userId',
      userName: 'userName',
      attachments: 'attachments',
      libraryId: 'libraryId',
      source: 'source',
      title: 'title',
      type: 'type',
      content: 'content',
      extTitle: 'extTitle',
      keyword: 'keyword',
      tags: 'tags',
      effectTimestart: 'effectTimestart',
      effectTimeend: 'effectTimeend',
      categoryId: 'categoryId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingTokenGrantType: 'number',
      dingIsvOrgId: 'number',
      dingSuiteKey: 'string',
      dingOrgId: 'number',
      openTeamId: 'string',
      userId: 'string',
      userName: 'string',
      attachments: { 'type': 'array', 'itemType': AddOpenKnowledgeRequestAttachments },
      libraryId: 'number',
      source: 'string',
      title: 'string',
      type: 'string',
      content: 'string',
      extTitle: 'string',
      keyword: 'string',
      tags: 'string',
      effectTimestart: 'string',
      effectTimeend: 'string',
      categoryId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenKnowledgeResponseBody extends $tea.Model {
  success?: boolean;
  result?: AddOpenKnowledgeResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: AddOpenKnowledgeResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenKnowledgeResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddOpenKnowledgeResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddOpenKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTeamHeaders extends $tea.Model {
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

export class CreateTeamRequest extends $tea.Model {
  creatorDingUnionId?: string;
  teamName?: string;
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  static names(): { [key: string]: string } {
    return {
      creatorDingUnionId: 'creatorDingUnionId',
      teamName: 'teamName',
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorDingUnionId: 'string',
      teamName: 'string',
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

export class CreateTeamResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTeamResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTeamResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTeamResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStoragePolicyHeaders extends $tea.Model {
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

export class GetStoragePolicyRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openTeamId?: string;
  bizType?: string;
  fileSize?: number;
  fileName?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openTeamId: 'openTeamId',
      bizType: 'bizType',
      fileSize: 'fileSize',
      fileName: 'fileName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openTeamId: 'string',
      bizType: 'string',
      fileSize: 'number',
      fileName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStoragePolicyResponseBody extends $tea.Model {
  key?: string;
  policy?: string;
  accessKeyId?: string;
  endpoint?: string;
  signature?: string;
  static names(): { [key: string]: string } {
    return {
      key: 'key',
      policy: 'policy',
      accessKeyId: 'accessKeyId',
      endpoint: 'endpoint',
      signature: 'signature',
    };
  }

  static types(): { [key: string]: any } {
    return {
      key: 'string',
      policy: 'string',
      accessKeyId: 'string',
      endpoint: 'string',
      signature: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStoragePolicyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetStoragePolicyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetStoragePolicyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: AssignTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': AssignTicketRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignTicketRequestNotify extends $tea.Model {
  workNoticeReceiverUnionIds?: string[];
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  static names(): { [key: string]: string } {
    return {
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: UpdateTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': UpdateTicketRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddKnowledgeRequestAttachmentList extends $tea.Model {
  title?: string;
  path?: string;
  size?: number;
  suffix?: string;
  mimeType?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      path: 'path',
      size: 'size',
      suffix: 'suffix',
      mimeType: 'mime_type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      path: 'string',
      size: 'number',
      suffix: 'string',
      mimeType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchGetGroupSetConfigResponseBodyGroupSetConfigs extends $tea.Model {
  configKey?: string;
  configValue?: string;
  static names(): { [key: string]: string } {
    return {
      configKey: 'configKey',
      configValue: 'configValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      configKey: 'string',
      configValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponseBodyRecordsOperator extends $tea.Model {
  unionId?: string;
  nickName?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      nickName: 'nickName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      nickName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponseBodyRecordsTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponseBodyRecords extends $tea.Model {
  openTicketId?: string;
  operateTime?: string;
  operation?: string;
  operationDisplayName?: string;
  operator?: ListTicketOperateRecordResponseBodyRecordsOperator;
  ticketMemo?: ListTicketOperateRecordResponseBodyRecordsTicketMemo;
  operateData?: string;
  static names(): { [key: string]: string } {
    return {
      openTicketId: 'openTicketId',
      operateTime: 'operateTime',
      operation: 'operation',
      operationDisplayName: 'operationDisplayName',
      operator: 'operator',
      ticketMemo: 'ticketMemo',
      operateData: 'operateData',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTicketId: 'string',
      operateTime: 'string',
      operation: 'string',
      operationDisplayName: 'string',
      operator: ListTicketOperateRecordResponseBodyRecordsOperator,
      ticketMemo: ListTicketOperateRecordResponseBodyRecordsTicketMemo,
      operateData: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetractTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetractTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: RetractTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': RetractTicketRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetractTicketRequestNotify extends $tea.Model {
  workNoticeReceiverUnionIds?: string[];
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  static names(): { [key: string]: string } {
    return {
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
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
  sendTimeStr?: string;
  readTimeStr?: string;
  static names(): { [key: string]: string } {
    return {
      receiverUserId: 'receiverUserId',
      receiverUnionId: 'receiverUnionId',
      readStatus: 'readStatus',
      receiverName: 'receiverName',
      receiverDingTalkId: 'receiverDingTalkId',
      sendTimeStr: 'sendTimeStr',
      readTimeStr: 'readTimeStr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      receiverUserId: 'string',
      receiverUnionId: 'string',
      readStatus: 'number',
      receiverName: 'string',
      receiverDingTalkId: 'string',
      sendTimeStr: 'string',
      readTimeStr: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UrgeTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UrgeTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: UrgeTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': UrgeTicketRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyCreator extends $tea.Model {
  unionId?: string;
  nickName?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      nickName: 'nickName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      nickName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyProcessor extends $tea.Model {
  unionId?: string;
  nickName?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      nickName: 'nickName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      nickName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyTakers extends $tea.Model {
  unionId?: string;
  nickName?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      nickName: 'nickName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      nickName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyTemplate extends $tea.Model {
  openTemplateId?: string;
  openTemplateBizId?: string;
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      openTemplateId: 'openTemplateId',
      openTemplateBizId: 'openTemplateBizId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTemplateId: 'string',
      openTemplateBizId: 'string',
      templateName: 'string',
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

export class ResubmitTicketRequestSceneContextGroupMsgs extends $tea.Model {
  openMsgId?: string;
  anchor?: boolean;
  topicId?: string;
  static names(): { [key: string]: string } {
    return {
      openMsgId: 'openMsgId',
      anchor: 'anchor',
      topicId: 'topicId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openMsgId: 'string',
      anchor: 'boolean',
      topicId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketRequestSceneContext extends $tea.Model {
  openConversationId?: string;
  relevantorUnionIds?: string[];
  groupMsgs?: ResubmitTicketRequestSceneContextGroupMsgs[];
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      relevantorUnionIds: 'relevantorUnionIds',
      groupMsgs: 'groupMsgs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      relevantorUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupMsgs: { 'type': 'array', 'itemType': ResubmitTicketRequestSceneContextGroupMsgs },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketRequestNotify extends $tea.Model {
  workNoticeReceiverUnionIds?: string[];
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  static names(): { [key: string]: string } {
    return {
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: ResubmitTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': ResubmitTicketRequestTicketMemoAttachments },
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

export class AddTicketMemoRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddTicketMemoRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: AddTicketMemoRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': AddTicketMemoRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupSetResponseBodyRecords extends $tea.Model {
  openGroupSetId?: string;
  groupSetName?: string;
  templateId?: string;
  gmtCreate?: string;
  gmtModified?: string;
  static names(): { [key: string]: string } {
    return {
      openGroupSetId: 'openGroupSetId',
      groupSetName: 'groupSetName',
      templateId: 'templateId',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openGroupSetId: 'string',
      groupSetName: 'string',
      templateId: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketRequestSceneContextGroupMsgs extends $tea.Model {
  openMsgId?: string;
  anchor?: boolean;
  static names(): { [key: string]: string } {
    return {
      openMsgId: 'openMsgId',
      anchor: 'anchor',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openMsgId: 'string',
      anchor: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketRequestSceneContext extends $tea.Model {
  openConversationId?: string;
  relevantorUnionIds?: string[];
  groupMsgs?: CreateTicketRequestSceneContextGroupMsgs[];
  topicId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      relevantorUnionIds: 'relevantorUnionIds',
      groupMsgs: 'groupMsgs',
      topicId: 'topicId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      relevantorUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupMsgs: { 'type': 'array', 'itemType': CreateTicketRequestSceneContextGroupMsgs },
      topicId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketRequestNotify extends $tea.Model {
  workNoticeReceiverUnionIds?: string[];
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  static names(): { [key: string]: string } {
    return {
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: FinishTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': FinishTicketRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishTicketRequestNotify extends $tea.Model {
  workNoticeReceiverUnionIds?: string[];
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  static names(): { [key: string]: string } {
    return {
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
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
  groupUrl?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      groupName: 'groupName',
      openTeamId: 'openTeamId',
      openGroupSetId: 'openGroupSetId',
      groupUrl: 'groupUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      groupName: 'string',
      openTeamId: 'string',
      openGroupSetId: 'string',
      groupUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: TransferTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': TransferTicketRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferTicketRequestNotify extends $tea.Model {
  workNoticeReceiverUnionIds?: string[];
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  static names(): { [key: string]: string } {
    return {
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenLibraryResponseBodyResult extends $tea.Model {
  success?: boolean;
  id?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      id: 'id',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      id: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryActiveUsersResponseBodyActiveUserInfos extends $tea.Model {
  unionId?: string;
  nickName?: string;
  actionIndexL7d?: number;
  actionIndexL14d?: number;
  actionIndexL30d?: number;
  activeScore?: number;
  ranking?: number;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
      nickName: 'nickName',
      actionIndexL7d: 'actionIndexL7d',
      actionIndexL14d: 'actionIndexL14d',
      actionIndexL30d: 'actionIndexL30d',
      activeScore: 'activeScore',
      ranking: 'ranking',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
      nickName: 'string',
      actionIndexL7d: 'number',
      actionIndexL14d: 'number',
      actionIndexL30d: 'number',
      activeScore: 'number',
      ranking: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenCategoryResponseBodyResult extends $tea.Model {
  success?: boolean;
  id?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      id: 'id',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      id: 'number',
      message: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelTicketRequestTicketMemoAttachments extends $tea.Model {
  fileName?: string;
  key?: string;
  static names(): { [key: string]: string } {
    return {
      fileName: 'fileName',
      key: 'key',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fileName: 'string',
      key: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelTicketRequestTicketMemo extends $tea.Model {
  memo?: string;
  attachments?: CancelTicketRequestTicketMemoAttachments[];
  static names(): { [key: string]: string } {
    return {
      memo: 'memo',
      attachments: 'attachments',
    };
  }

  static types(): { [key: string]: any } {
    return {
      memo: 'string',
      attachments: { 'type': 'array', 'itemType': CancelTicketRequestTicketMemoAttachments },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelTicketRequestNotify extends $tea.Model {
  workNoticeReceiverUnionIds?: string[];
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  static names(): { [key: string]: string } {
    return {
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
    };
  }

  static types(): { [key: string]: any } {
    return {
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenKnowledgeRequestAttachments extends $tea.Model {
  title?: string;
  path?: string;
  size?: number;
  suffix?: string;
  mimeType?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      path: 'path',
      size: 'size',
      suffix: 'suffix',
      mimeType: 'mimeType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      path: 'string',
      size: 'number',
      suffix: 'string',
      mimeType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenKnowledgeResponseBodyResult extends $tea.Model {
  success?: boolean;
  id?: number;
  message?: string;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      id: 'id',
      message: 'message',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      id: 'number',
      message: 'string',
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


  async assignTicket(request: AssignTicketRequest): Promise<AssignTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AssignTicketHeaders({ });
    return await this.assignTicketWithOptions(request, headers, runtime);
  }

  async assignTicketWithOptions(request: AssignTicketRequest, headers: AssignTicketHeaders, runtime: $Util.RuntimeOptions): Promise<AssignTicketResponse> {
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

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.processorUnionIds)) {
      body["processorUnionIds"] = request.processorUnionIds;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<AssignTicketResponse>(await this.doROARequest("AssignTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/assign`, "none", req, runtime), new AssignTicketResponse({}));
  }

  async updateTicket(request: UpdateTicketRequest): Promise<UpdateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTicketHeaders({ });
    return await this.updateTicketWithOptions(request, headers, runtime);
  }

  async updateTicketWithOptions(request: UpdateTicketRequest, headers: UpdateTicketHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTicketResponse> {
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

    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<UpdateTicketResponse>(await this.doROARequest("UpdateTicket", "serviceGroup_1.0", "HTTP", "PUT", "AK", `/v1.0/serviceGroup/tickets`, "none", req, runtime), new UpdateTicketResponse({}));
  }

  async upgradeNormalGroup(request: UpgradeNormalGroupRequest): Promise<UpgradeNormalGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeNormalGroupHeaders({ });
    return await this.upgradeNormalGroupWithOptions(request, headers, runtime);
  }

  async upgradeNormalGroupWithOptions(request: UpgradeNormalGroupRequest, headers: UpgradeNormalGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpgradeNormalGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
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
    return $tea.cast<UpgradeNormalGroupResponse>(await this.doROARequest("UpgradeNormalGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/normalGroups/upgrade`, "none", req, runtime), new UpgradeNormalGroupResponse({}));
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

    if (!Util.isUnset(request.extTitle)) {
      body["extTitle"] = request.extTitle;
    }

    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.attachmentList)) {
      body["attachmentList"] = request.attachmentList;
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

  async batchGetGroupSetConfig(request: BatchGetGroupSetConfigRequest): Promise<BatchGetGroupSetConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetGroupSetConfigHeaders({ });
    return await this.batchGetGroupSetConfigWithOptions(request, headers, runtime);
  }

  async batchGetGroupSetConfigWithOptions(request: BatchGetGroupSetConfigRequest, headers: BatchGetGroupSetConfigHeaders, runtime: $Util.RuntimeOptions): Promise<BatchGetGroupSetConfigResponse> {
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

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.configKeys)) {
      body["configKeys"] = request.configKeys;
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
    return $tea.cast<BatchGetGroupSetConfigResponse>(await this.doROARequest("BatchGetGroupSetConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groupSetConfigs/batchQuery`, "json", req, runtime), new BatchGetGroupSetConfigResponse({}));
  }

  async listTicketOperateRecord(request: ListTicketOperateRecordRequest): Promise<ListTicketOperateRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTicketOperateRecordHeaders({ });
    return await this.listTicketOperateRecordWithOptions(request, headers, runtime);
  }

  async listTicketOperateRecordWithOptions(request: ListTicketOperateRecordRequest, headers: ListTicketOperateRecordHeaders, runtime: $Util.RuntimeOptions): Promise<ListTicketOperateRecordResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      query["openTicketId"] = request.openTicketId;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListTicketOperateRecordResponse>(await this.doROARequest("ListTicketOperateRecord", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/tickets/operateRecords`, "json", req, runtime), new ListTicketOperateRecordResponse({}));
  }

  async retractTicket(request: RetractTicketRequest): Promise<RetractTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetractTicketHeaders({ });
    return await this.retractTicketWithOptions(request, headers, runtime);
  }

  async retractTicketWithOptions(request: RetractTicketRequest, headers: RetractTicketHeaders, runtime: $Util.RuntimeOptions): Promise<RetractTicketResponse> {
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

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
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
    return $tea.cast<RetractTicketResponse>(await this.doROARequest("RetractTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/retract`, "none", req, runtime), new RetractTicketResponse({}));
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

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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

  async closeHumanSession(request: CloseHumanSessionRequest): Promise<CloseHumanSessionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseHumanSessionHeaders({ });
    return await this.closeHumanSessionWithOptions(request, headers, runtime);
  }

  async closeHumanSessionWithOptions(request: CloseHumanSessionRequest, headers: CloseHumanSessionHeaders, runtime: $Util.RuntimeOptions): Promise<CloseHumanSessionResponse> {
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

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.visitorUnionId)) {
      body["visitorUnionId"] = request.visitorUnionId;
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
    return $tea.cast<CloseHumanSessionResponse>(await this.doROARequest("CloseHumanSession", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/humanSessions/close`, "json", req, runtime), new CloseHumanSessionResponse({}));
  }

  async urgeTicket(request: UrgeTicketRequest): Promise<UrgeTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UrgeTicketHeaders({ });
    return await this.urgeTicketWithOptions(request, headers, runtime);
  }

  async urgeTicketWithOptions(request: UrgeTicketRequest, headers: UrgeTicketHeaders, runtime: $Util.RuntimeOptions): Promise<UrgeTicketResponse> {
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

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<UrgeTicketResponse>(await this.doROARequest("UrgeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/urge`, "none", req, runtime), new UrgeTicketResponse({}));
  }

  async getTicket(request: GetTicketRequest): Promise<GetTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTicketHeaders({ });
    return await this.getTicketWithOptions(request, headers, runtime);
  }

  async getTicketWithOptions(request: GetTicketRequest, headers: GetTicketHeaders, runtime: $Util.RuntimeOptions): Promise<GetTicketResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      query["openTicketId"] = request.openTicketId;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetTicketResponse>(await this.doROARequest("GetTicket", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/tickets`, "json", req, runtime), new GetTicketResponse({}));
  }

  async takeTicket(request: TakeTicketRequest): Promise<TakeTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TakeTicketHeaders({ });
    return await this.takeTicketWithOptions(request, headers, runtime);
  }

  async takeTicketWithOptions(request: TakeTicketRequest, headers: TakeTicketHeaders, runtime: $Util.RuntimeOptions): Promise<TakeTicketResponse> {
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

    if (!Util.isUnset(request.takerUnionId)) {
      body["takerUnionId"] = request.takerUnionId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
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
    return $tea.cast<TakeTicketResponse>(await this.doROARequest("TakeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/apply`, "none", req, runtime), new TakeTicketResponse({}));
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

    if (!Util.isUnset(request.hasContentLinks)) {
      body["hasContentLinks"] = request.hasContentLinks;
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

  async upgradeCloudGroup(request: UpgradeCloudGroupRequest): Promise<UpgradeCloudGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeCloudGroupHeaders({ });
    return await this.upgradeCloudGroupWithOptions(request, headers, runtime);
  }

  async upgradeCloudGroupWithOptions(request: UpgradeCloudGroupRequest, headers: UpgradeCloudGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpgradeCloudGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.ccsInstanceId)) {
      body["ccsInstanceId"] = request.ccsInstanceId;
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

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<UpgradeCloudGroupResponse>(await this.doROARequest("UpgradeCloudGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/cloudGroups/upgrade`, "none", req, runtime), new UpgradeCloudGroupResponse({}));
  }

  async resubmitTicket(request: ResubmitTicketRequest): Promise<ResubmitTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ResubmitTicketHeaders({ });
    return await this.resubmitTicketWithOptions(request, headers, runtime);
  }

  async resubmitTicketWithOptions(request: ResubmitTicketRequest, headers: ResubmitTicketHeaders, runtime: $Util.RuntimeOptions): Promise<ResubmitTicketResponse> {
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

    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.processorUnionIds)) {
      body["processorUnionIds"] = request.processorUnionIds;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset($tea.toMap(request.sceneContext))) {
      body["sceneContext"] = request.sceneContext;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.openTemplateBizId)) {
      body["openTemplateBizId"] = request.openTemplateBizId;
    }

    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<ResubmitTicketResponse>(await this.doROARequest("ResubmitTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/resubmit`, "none", req, runtime), new ResubmitTicketResponse({}));
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

  async addTicketMemo(request: AddTicketMemoRequest): Promise<AddTicketMemoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddTicketMemoHeaders({ });
    return await this.addTicketMemoWithOptions(request, headers, runtime);
  }

  async addTicketMemoWithOptions(request: AddTicketMemoRequest, headers: AddTicketMemoHeaders, runtime: $Util.RuntimeOptions): Promise<AddTicketMemoResponse> {
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

    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<AddTicketMemoResponse>(await this.doROARequest("AddTicketMemo", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/memos`, "none", req, runtime), new AddTicketMemoResponse({}));
  }

  async queryGroupSet(request: QueryGroupSetRequest): Promise<QueryGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupSetHeaders({ });
    return await this.queryGroupSetWithOptions(request, headers, runtime);
  }

  async queryGroupSetWithOptions(request: QueryGroupSetRequest, headers: QueryGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupSetResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryGroupSetResponse>(await this.doROARequest("QueryGroupSet", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/groupSets`, "json", req, runtime), new QueryGroupSetResponse({}));
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

  async createTicket(request: CreateTicketRequest): Promise<CreateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTicketHeaders({ });
    return await this.createTicketWithOptions(request, headers, runtime);
  }

  async createTicketWithOptions(request: CreateTicketRequest, headers: CreateTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTicketResponse> {
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

    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.processorUnionIds)) {
      body["processorUnionIds"] = request.processorUnionIds;
    }

    if (!Util.isUnset(request.scene)) {
      body["scene"] = request.scene;
    }

    if (!Util.isUnset($tea.toMap(request.sceneContext))) {
      body["sceneContext"] = request.sceneContext;
    }

    if (!Util.isUnset(request.openTemplateBizId)) {
      body["openTemplateBizId"] = request.openTemplateBizId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
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
    return $tea.cast<CreateTicketResponse>(await this.doROARequest("CreateTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets`, "json", req, runtime), new CreateTicketResponse({}));
  }

  async finishTicket(request: FinishTicketRequest): Promise<FinishTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishTicketHeaders({ });
    return await this.finishTicketWithOptions(request, headers, runtime);
  }

  async finishTicketWithOptions(request: FinishTicketRequest, headers: FinishTicketHeaders, runtime: $Util.RuntimeOptions): Promise<FinishTicketResponse> {
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

    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
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
    return $tea.cast<FinishTicketResponse>(await this.doROARequest("FinishTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/finish`, "none", req, runtime), new FinishTicketResponse({}));
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

    if (!Util.isUnset(request.searchType)) {
      body["searchType"] = request.searchType;
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

    if (!Util.isUnset(request.groupTagNames)) {
      body["groupTagNames"] = request.groupTagNames;
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

  async transferTicket(request: TransferTicketRequest): Promise<TransferTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransferTicketHeaders({ });
    return await this.transferTicketWithOptions(request, headers, runtime);
  }

  async transferTicketWithOptions(request: TransferTicketRequest, headers: TransferTicketHeaders, runtime: $Util.RuntimeOptions): Promise<TransferTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.processorUnionIds)) {
      body["processorUnionIds"] = request.processorUnionIds;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<TransferTicketResponse>(await this.doROARequest("TransferTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/transfer`, "none", req, runtime), new TransferTicketResponse({}));
  }

  async addOpenLibrary(request: AddOpenLibraryRequest): Promise<AddOpenLibraryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenLibraryHeaders({ });
    return await this.addOpenLibraryWithOptions(request, headers, runtime);
  }

  async addOpenLibraryWithOptions(request: AddOpenLibraryRequest, headers: AddOpenLibraryHeaders, runtime: $Util.RuntimeOptions): Promise<AddOpenLibraryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
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
    return $tea.cast<AddOpenLibraryResponse>(await this.doROARequest("AddOpenLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/openLibraries`, "json", req, runtime), new AddOpenLibraryResponse({}));
  }

  async queryActiveUsers(request: QueryActiveUsersRequest): Promise<QueryActiveUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryActiveUsersHeaders({ });
    return await this.queryActiveUsersWithOptions(request, headers, runtime);
  }

  async queryActiveUsersWithOptions(request: QueryActiveUsersRequest, headers: QueryActiveUsersHeaders, runtime: $Util.RuntimeOptions): Promise<QueryActiveUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryActiveUsersResponse>(await this.doROARequest("QueryActiveUsers", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/groups/queryActiveUsers`, "json", req, runtime), new QueryActiveUsersResponse({}));
  }

  async addOpenCategory(request: AddOpenCategoryRequest): Promise<AddOpenCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenCategoryHeaders({ });
    return await this.addOpenCategoryWithOptions(request, headers, runtime);
  }

  async addOpenCategoryWithOptions(request: AddOpenCategoryRequest, headers: AddOpenCategoryHeaders, runtime: $Util.RuntimeOptions): Promise<AddOpenCategoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.libraryId)) {
      body["libraryId"] = request.libraryId;
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
    return $tea.cast<AddOpenCategoryResponse>(await this.doROARequest("AddOpenCategory", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/openCategories`, "json", req, runtime), new AddOpenCategoryResponse({}));
  }

  async createGroupSet(request: CreateGroupSetRequest): Promise<CreateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupSetHeaders({ });
    return await this.createGroupSetWithOptions(request, headers, runtime);
  }

  async createGroupSetWithOptions(request: CreateGroupSetRequest, headers: CreateGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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

    if (!Util.isUnset(request.groupSetName)) {
      body["groupSetName"] = request.groupSetName;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
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
    return $tea.cast<CreateGroupSetResponse>(await this.doROARequest("CreateGroupSet", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groupSets`, "json", req, runtime), new CreateGroupSetResponse({}));
  }

  async boundTemplateToTeam(request: BoundTemplateToTeamRequest): Promise<BoundTemplateToTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BoundTemplateToTeamHeaders({ });
    return await this.boundTemplateToTeamWithOptions(request, headers, runtime);
  }

  async boundTemplateToTeamWithOptions(request: BoundTemplateToTeamRequest, headers: BoundTemplateToTeamHeaders, runtime: $Util.RuntimeOptions): Promise<BoundTemplateToTeamResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.templateName)) {
      body["templateName"] = request.templateName;
    }

    if (!Util.isUnset(request.templateType)) {
      body["templateType"] = request.templateType;
    }

    if (!Util.isUnset(request.templateDesc)) {
      body["templateDesc"] = request.templateDesc;
    }

    if (!Util.isUnset(request.robotConfig)) {
      body["robotConfig"] = request.robotConfig;
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
    return $tea.cast<BoundTemplateToTeamResponse>(await this.doROARequest("BoundTemplateToTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/teams/templates/bound`, "json", req, runtime), new BoundTemplateToTeamResponse({}));
  }

  async getOssTempUrl(request: GetOssTempUrlRequest): Promise<GetOssTempUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOssTempUrlHeaders({ });
    return await this.getOssTempUrlWithOptions(request, headers, runtime);
  }

  async getOssTempUrlWithOptions(request: GetOssTempUrlRequest, headers: GetOssTempUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetOssTempUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.key)) {
      query["key"] = request.key;
    }

    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fetchMode)) {
      query["fetchMode"] = request.fetchMode;
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
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetOssTempUrlResponse>(await this.doROARequest("GetOssTempUrl", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/ossServices/tempUrls`, "json", req, runtime), new GetOssTempUrlResponse({}));
  }

  async cancelTicket(request: CancelTicketRequest): Promise<CancelTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelTicketHeaders({ });
    return await this.cancelTicketWithOptions(request, headers, runtime);
  }

  async cancelTicketWithOptions(request: CancelTicketRequest, headers: CancelTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CancelTicketResponse> {
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

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
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
    return $tea.cast<CancelTicketResponse>(await this.doROARequest("CancelTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/cancel`, "none", req, runtime), new CancelTicketResponse({}));
  }

  async updateGroupTag(request: UpdateGroupTagRequest): Promise<UpdateGroupTagResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupTagHeaders({ });
    return await this.updateGroupTagWithOptions(request, headers, runtime);
  }

  async updateGroupTagWithOptions(request: UpdateGroupTagRequest, headers: UpdateGroupTagHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupTagResponse> {
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

    if (!Util.isUnset(request.openConversationIds)) {
      body["openConversationIds"] = request.openConversationIds;
    }

    if (!Util.isUnset(request.tagNames)) {
      body["tagNames"] = request.tagNames;
    }

    if (!Util.isUnset(request.updateType)) {
      body["updateType"] = request.updateType;
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
    return $tea.cast<UpdateGroupTagResponse>(await this.doROARequest("UpdateGroupTag", "serviceGroup_1.0", "HTTP", "PUT", "AK", `/v1.0/serviceGroup/tags`, "none", req, runtime), new UpdateGroupTagResponse({}));
  }

  async addOpenKnowledge(request: AddOpenKnowledgeRequest): Promise<AddOpenKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenKnowledgeHeaders({ });
    return await this.addOpenKnowledgeWithOptions(request, headers, runtime);
  }

  async addOpenKnowledgeWithOptions(request: AddOpenKnowledgeRequest, headers: AddOpenKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<AddOpenKnowledgeResponse> {
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

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
    }

    if (!Util.isUnset(request.attachments)) {
      body["attachments"] = request.attachments;
    }

    if (!Util.isUnset(request.libraryId)) {
      body["libraryId"] = request.libraryId;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.extTitle)) {
      body["extTitle"] = request.extTitle;
    }

    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.tags)) {
      body["tags"] = request.tags;
    }

    if (!Util.isUnset(request.effectTimestart)) {
      body["effectTimestart"] = request.effectTimestart;
    }

    if (!Util.isUnset(request.effectTimeend)) {
      body["effectTimeend"] = request.effectTimeend;
    }

    if (!Util.isUnset(request.categoryId)) {
      body["categoryId"] = request.categoryId;
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
    return $tea.cast<AddOpenKnowledgeResponse>(await this.doROARequest("AddOpenKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/openKnowledges`, "json", req, runtime), new AddOpenKnowledgeResponse({}));
  }

  async createTeam(request: CreateTeamRequest): Promise<CreateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTeamHeaders({ });
    return await this.createTeamWithOptions(request, headers, runtime);
  }

  async createTeamWithOptions(request: CreateTeamRequest, headers: CreateTeamHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTeamResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorDingUnionId)) {
      body["creatorDingUnionId"] = request.creatorDingUnionId;
    }

    if (!Util.isUnset(request.teamName)) {
      body["teamName"] = request.teamName;
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
    return $tea.cast<CreateTeamResponse>(await this.doROARequest("CreateTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/teams`, "json", req, runtime), new CreateTeamResponse({}));
  }

  async getStoragePolicy(request: GetStoragePolicyRequest): Promise<GetStoragePolicyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStoragePolicyHeaders({ });
    return await this.getStoragePolicyWithOptions(request, headers, runtime);
  }

  async getStoragePolicyWithOptions(request: GetStoragePolicyRequest, headers: GetStoragePolicyHeaders, runtime: $Util.RuntimeOptions): Promise<GetStoragePolicyResponse> {
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

    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.fileSize)) {
      body["fileSize"] = request.fileSize;
    }

    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
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
    return $tea.cast<GetStoragePolicyResponse>(await this.doROARequest("GetStoragePolicy", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/ossServices/policies`, "json", req, runtime), new GetStoragePolicyResponse({}));
  }

}
