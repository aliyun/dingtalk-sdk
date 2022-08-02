// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  attachmentList?: AddKnowledgeRequestAttachmentList[];
  content?: string;
  effectTimeend?: number;
  effectTimestart?: number;
  extTitle?: string;
  keyword?: string;
  libraryKey?: string;
  linkUrl?: string;
  openTeamId?: string;
  questionIds?: number[];
  source?: string;
  sourcePrimaryKey?: string;
  title?: string;
  type?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      attachmentList: 'attachmentList',
      content: 'content',
      effectTimeend: 'effectTimeend',
      effectTimestart: 'effectTimestart',
      extTitle: 'extTitle',
      keyword: 'keyword',
      libraryKey: 'libraryKey',
      linkUrl: 'linkUrl',
      openTeamId: 'openTeamId',
      questionIds: 'questionIds',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
      title: 'title',
      type: 'type',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachmentList: { 'type': 'array', 'itemType': AddKnowledgeRequestAttachmentList },
      content: 'string',
      effectTimeend: 'number',
      effectTimestart: 'number',
      extTitle: 'string',
      keyword: 'string',
      libraryKey: 'string',
      linkUrl: 'string',
      openTeamId: 'string',
      questionIds: { 'type': 'array', 'itemType': 'number' },
      source: 'string',
      sourcePrimaryKey: 'string',
      title: 'string',
      type: 'string',
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
  description?: string;
  openTeamIds?: string[];
  source?: string;
  sourcePrimaryKey?: string;
  title?: string;
  type?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      openTeamIds: 'openTeamIds',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
      title: 'title',
      type: 'type',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      openTeamIds: { 'type': 'array', 'itemType': 'string' },
      source: 'string',
      sourcePrimaryKey: 'string',
      title: 'string',
      type: 'string',
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
  libraryId?: number;
  openTeamId?: string;
  parentId?: number;
  title?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      libraryId: 'libraryId',
      openTeamId: 'openTeamId',
      parentId: 'parentId',
      title: 'title',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      libraryId: 'number',
      openTeamId: 'string',
      parentId: 'number',
      title: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenCategoryResponseBody extends $tea.Model {
  result?: AddOpenCategoryResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AddOpenCategoryResponseBodyResult,
      success: 'boolean',
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
  attachments?: AddOpenKnowledgeRequestAttachments[];
  categoryId?: number;
  content?: string;
  effectTimeend?: string;
  effectTimestart?: string;
  extTitle?: string;
  keyword?: string;
  libraryId?: number;
  openTeamId?: string;
  source?: string;
  tags?: string;
  title?: string;
  type?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      categoryId: 'categoryId',
      content: 'content',
      effectTimeend: 'effectTimeend',
      effectTimestart: 'effectTimestart',
      extTitle: 'extTitle',
      keyword: 'keyword',
      libraryId: 'libraryId',
      openTeamId: 'openTeamId',
      source: 'source',
      tags: 'tags',
      title: 'title',
      type: 'type',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': AddOpenKnowledgeRequestAttachments },
      categoryId: 'number',
      content: 'string',
      effectTimeend: 'string',
      effectTimestart: 'string',
      extTitle: 'string',
      keyword: 'string',
      libraryId: 'number',
      openTeamId: 'string',
      source: 'string',
      tags: 'string',
      title: 'string',
      type: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenKnowledgeResponseBody extends $tea.Model {
  result?: AddOpenKnowledgeResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AddOpenKnowledgeResponseBodyResult,
      success: 'boolean',
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
  description?: string;
  openTeamId?: string;
  source?: string;
  title?: string;
  type?: string;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      openTeamId: 'openTeamId',
      source: 'source',
      title: 'title',
      type: 'type',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      openTeamId: 'string',
      source: 'string',
      title: 'string',
      type: 'string',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenLibraryResponseBody extends $tea.Model {
  result?: AddOpenLibraryResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: AddOpenLibraryResponseBodyResult,
      success: 'boolean',
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
  openTeamId?: string;
  openTicketId?: string;
  processorUnionId?: string;
  ticketMemo?: AddTicketMemoRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      processorUnionId: 'processorUnionId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      openTicketId: 'string',
      processorUnionId: 'string',
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
  notify?: AssignTicketRequestNotify;
  openTeamId?: string;
  openTicketId?: string;
  operatorUnionId?: string;
  processorUnionIds?: string[];
  ticketMemo?: AssignTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      notify: 'notify',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      operatorUnionId: 'operatorUnionId',
      processorUnionIds: 'processorUnionIds',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notify: AssignTicketRequestNotify,
      openTeamId: 'string',
      openTicketId: 'string',
      operatorUnionId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      ticketMemo: AssignTicketRequestTicketMemo,
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

export class BatchBindingGroupBizIdsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchBindingGroupBizIdsRequest extends $tea.Model {
  bindingGroupBizIds?: BatchBindingGroupBizIdsRequestBindingGroupBizIds[];
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      bindingGroupBizIds: 'bindingGroupBizIds',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bindingGroupBizIds: { 'type': 'array', 'itemType': BatchBindingGroupBizIdsRequestBindingGroupBizIds },
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchBindingGroupBizIdsResponseBody extends $tea.Model {
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

export class BatchBindingGroupBizIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchBindingGroupBizIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchBindingGroupBizIdsResponseBody,
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
  configKeys?: string[];
  openGroupSetId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      configKeys: 'configKeys',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      configKeys: { 'type': 'array', 'itemType': 'string' },
      openGroupSetId: 'string',
      openTeamId: 'string',
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

export class BatchQuerySendMessageTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQuerySendMessageTaskRequest extends $tea.Model {
  getReadCount?: boolean;
  gmtCreateEnd?: string;
  gmtCreateStart?: string;
  maxResults?: number;
  nextToken?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      getReadCount: 'getReadCount',
      gmtCreateEnd: 'gmtCreateEnd',
      gmtCreateStart: 'gmtCreateStart',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      getReadCount: 'boolean',
      gmtCreateEnd: 'string',
      gmtCreateStart: 'string',
      maxResults: 'number',
      nextToken: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQuerySendMessageTaskResponseBody extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  records?: BatchQuerySendMessageTaskResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': BatchQuerySendMessageTaskResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQuerySendMessageTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchQuerySendMessageTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchQuerySendMessageTaskResponseBody,
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
  openTeamId?: string;
  robotConfig?: string;
  templateDesc?: string;
  templateId?: string;
  templateName?: string;
  templateType?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      robotConfig: 'robotConfig',
      templateDesc: 'templateDesc',
      templateId: 'templateId',
      templateName: 'templateName',
      templateType: 'templateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      robotConfig: 'string',
      templateDesc: 'string',
      templateId: 'string',
      templateName: 'string',
      templateType: 'string',
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
  notify?: CancelTicketRequestNotify;
  openTeamId?: string;
  openTicketId?: string;
  operatorUnionId?: string;
  ticketMemo?: CancelTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      notify: 'notify',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      operatorUnionId: 'operatorUnionId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notify: CancelTicketRequestNotify,
      openTeamId: 'string',
      openTicketId: 'string',
      operatorUnionId: 'string',
      ticketMemo: CancelTicketRequestTicketMemo,
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

export class CategoryStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryStatisticsRequest extends $tea.Model {
  maxDt?: string;
  minDt?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxDt: 'maxDt',
      minDt: 'minDt',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxDt: 'string',
      minDt: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryStatisticsResponseBody extends $tea.Model {
  categoryStatisticsRecords?: CategoryStatisticsResponseBodyCategoryStatisticsRecords[];
  categoryTrend?: CategoryStatisticsResponseBodyCategoryTrend[];
  static names(): { [key: string]: string } {
    return {
      categoryStatisticsRecords: 'categoryStatisticsRecords',
      categoryTrend: 'categoryTrend',
    };
  }

  static types(): { [key: string]: any } {
    return {
      categoryStatisticsRecords: { 'type': 'array', 'itemType': CategoryStatisticsResponseBodyCategoryStatisticsRecords },
      categoryTrend: { 'type': 'array', 'itemType': CategoryStatisticsResponseBodyCategoryTrend },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CategoryStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CategoryStatisticsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseConversationHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseConversationRequest extends $tea.Model {
  conversationId?: string;
  openTeamId?: string;
  serverTips?: string;
  serviceToken?: string;
  targetChannel?: string;
  visitorToken?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      openTeamId: 'openTeamId',
      serverTips: 'serverTips',
      serviceToken: 'serviceToken',
      targetChannel: 'targetChannel',
      visitorToken: 'visitorToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      openTeamId: 'string',
      serverTips: 'string',
      serviceToken: 'string',
      targetChannel: 'string',
      visitorToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseConversationResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseConversationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CloseConversationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CloseConversationResponseBody,
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
  openConversationId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openTeamId: 'string',
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

export class ConversationCreatedNotifyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationCreatedNotifyRequest extends $tea.Model {
  alipayUserId?: string;
  conversationId?: string;
  nickName?: string;
  openTeamId?: string;
  serverName?: string;
  serverTips?: string;
  serviceToken?: string;
  timeoutRemindTips?: string;
  userId?: string;
  visitorToken?: string;
  static names(): { [key: string]: string } {
    return {
      alipayUserId: 'alipayUserId',
      conversationId: 'conversationId',
      nickName: 'nickName',
      openTeamId: 'openTeamId',
      serverName: 'serverName',
      serverTips: 'serverTips',
      serviceToken: 'serviceToken',
      timeoutRemindTips: 'timeoutRemindTips',
      userId: 'userId',
      visitorToken: 'visitorToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayUserId: 'string',
      conversationId: 'string',
      nickName: 'string',
      openTeamId: 'string',
      serverName: 'string',
      serverTips: 'string',
      serviceToken: 'string',
      timeoutRemindTips: 'string',
      userId: 'string',
      visitorToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationCreatedNotifyResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationCreatedNotifyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ConversationCreatedNotifyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ConversationCreatedNotifyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferBeginNotifyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferBeginNotifyRequest extends $tea.Model {
  conversationId?: string;
  memo?: string;
  openTeamId?: string;
  serviceToken?: string;
  sourceSkillGroupId?: string;
  targetSkillGroupId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      memo: 'memo',
      openTeamId: 'openTeamId',
      serviceToken: 'serviceToken',
      sourceSkillGroupId: 'sourceSkillGroupId',
      targetSkillGroupId: 'targetSkillGroupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      memo: 'string',
      openTeamId: 'string',
      serviceToken: 'string',
      sourceSkillGroupId: 'string',
      targetSkillGroupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferBeginNotifyResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferBeginNotifyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ConversationTransferBeginNotifyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ConversationTransferBeginNotifyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferCompleteNotifyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferCompleteNotifyRequest extends $tea.Model {
  alipayUserId?: string;
  conversationId?: string;
  nickName?: string;
  openTeamId?: string;
  serviceToken?: string;
  userId?: string;
  visitorToken?: string;
  static names(): { [key: string]: string } {
    return {
      alipayUserId: 'alipayUserId',
      conversationId: 'conversationId',
      nickName: 'nickName',
      openTeamId: 'openTeamId',
      serviceToken: 'serviceToken',
      userId: 'userId',
      visitorToken: 'visitorToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      alipayUserId: 'string',
      conversationId: 'string',
      nickName: 'string',
      openTeamId: 'string',
      serviceToken: 'string',
      userId: 'string',
      visitorToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferCompleteNotifyResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConversationTransferCompleteNotifyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ConversationTransferCompleteNotifyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ConversationTransferCompleteNotifyResponseBody,
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
  groupName?: string;
  groupTagNames?: string[];
  memberStaffIds?: string[];
  openGroupSetId?: string;
  openTeamId?: string;
  ownerStaffId?: string;
  static names(): { [key: string]: string } {
    return {
      groupBizId: 'groupBizId',
      groupName: 'groupName',
      groupTagNames: 'groupTagNames',
      memberStaffIds: 'memberStaffIds',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      ownerStaffId: 'ownerStaffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupBizId: 'string',
      groupName: 'string',
      groupTagNames: { 'type': 'array', 'itemType': 'string' },
      memberStaffIds: { 'type': 'array', 'itemType': 'string' },
      openGroupSetId: 'string',
      openTeamId: 'string',
      ownerStaffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupResponseBody extends $tea.Model {
  groupUrl?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      groupUrl: 'groupUrl',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupUrl: 'string',
      openConversationId: 'string',
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
  corpId?: string;
  dingGroupId?: string;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  dingUserId?: string;
  dingUserName?: string;
  extValues?: string;
  openTeamId?: string;
  serverGroupId?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      dingGroupId: 'dingGroupId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      dingUserId: 'dingUserId',
      dingUserName: 'dingUserName',
      extValues: 'extValues',
      openTeamId: 'openTeamId',
      serverGroupId: 'serverGroupId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      dingGroupId: 'string',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      dingUserId: 'string',
      dingUserName: 'string',
      extValues: 'string',
      openTeamId: 'string',
      serverGroupId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupConversationResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: 'string',
      success: 'boolean',
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
  groupSetName?: string;
  groupTemplateId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      groupSetName: 'groupSetName',
      groupTemplateId: 'groupTemplateId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupSetName: 'string',
      groupTemplateId: 'string',
      openTeamId: 'string',
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

export class CreateInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInstanceRequest extends $tea.Model {
  channel?: string;
  externalBizId?: string;
  formCode?: string;
  formDataList?: string;
  openTeamId?: string;
  operatorUnionId?: string;
  ownerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      channel: 'channel',
      externalBizId: 'externalBizId',
      formCode: 'formCode',
      formDataList: 'formDataList',
      openTeamId: 'openTeamId',
      operatorUnionId: 'operatorUnionId',
      ownerUnionId: 'ownerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channel: 'string',
      externalBizId: 'string',
      formCode: 'string',
      formDataList: 'string',
      openTeamId: 'string',
      operatorUnionId: 'string',
      ownerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInstanceResponseBody extends $tea.Model {
  openDataInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      openDataInstanceId: 'openDataInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openDataInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateInstanceResponseBody,
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
  static names(): { [key: string]: string } {
    return {
      creatorDingUnionId: 'creatorDingUnionId',
      teamName: 'teamName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorDingUnionId: 'string',
      teamName: 'string',
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
  creatorUnionId?: string;
  customFields?: string;
  notify?: CreateTicketRequestNotify;
  openTeamId?: string;
  openTemplateBizId?: string;
  processorUnionIds?: string[];
  scene?: string;
  sceneContext?: CreateTicketRequestSceneContext;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      customFields: 'customFields',
      notify: 'notify',
      openTeamId: 'openTeamId',
      openTemplateBizId: 'openTemplateBizId',
      processorUnionIds: 'processorUnionIds',
      scene: 'scene',
      sceneContext: 'sceneContext',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      customFields: 'string',
      notify: CreateTicketRequestNotify,
      openTeamId: 'string',
      openTemplateBizId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      scene: 'string',
      sceneContext: CreateTicketRequestSceneContext,
      title: 'string',
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

export class DeleteInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceRequest extends $tea.Model {
  formCode?: string;
  openDataInstanceId?: string;
  openTeamId?: string;
  operatorUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      openDataInstanceId: 'openDataInstanceId',
      openTeamId: 'openTeamId',
      operatorUnionId: 'operatorUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      openDataInstanceId: 'string',
      openTeamId: 'string',
      operatorUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceResponseBody extends $tea.Model {
  openDataInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      openDataInstanceId: 'openDataInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openDataInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteInstanceResponseBody,
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
  libraryKey?: string;
  openTeamId?: string;
  source?: string;
  sourcePrimaryKey?: string;
  static names(): { [key: string]: string } {
    return {
      libraryKey: 'libraryKey',
      openTeamId: 'openTeamId',
      source: 'source',
      sourcePrimaryKey: 'sourcePrimaryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      libraryKey: 'string',
      openTeamId: 'string',
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

export class EmotionStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmotionStatisticsRequest extends $tea.Model {
  maxDt?: string;
  maxEmotion?: number;
  minDt?: string;
  minEmotion?: number;
  openConversationIds?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxDt: 'maxDt',
      maxEmotion: 'maxEmotion',
      minDt: 'minDt',
      minEmotion: 'minEmotion',
      openConversationIds: 'openConversationIds',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxDt: 'string',
      maxEmotion: 'number',
      minDt: 'string',
      minEmotion: 'number',
      openConversationIds: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmotionStatisticsResponseBody extends $tea.Model {
  emotionStatisticsRecords?: EmotionStatisticsResponseBodyEmotionStatisticsRecords[];
  static names(): { [key: string]: string } {
    return {
      emotionStatisticsRecords: 'emotionStatisticsRecords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      emotionStatisticsRecords: { 'type': 'array', 'itemType': EmotionStatisticsResponseBodyEmotionStatisticsRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmotionStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EmotionStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EmotionStatisticsResponseBody,
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
  notify?: FinishTicketRequestNotify;
  openTeamId?: string;
  openTicketId?: string;
  processorUnionId?: string;
  ticketMemo?: FinishTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      notify: 'notify',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      processorUnionId: 'processorUnionId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notify: FinishTicketRequestNotify,
      openTeamId: 'string',
      openTicketId: 'string',
      processorUnionId: 'string',
      ticketMemo: FinishTicketRequestTicketMemo,
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

export class GetAuthTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthTokenRequest extends $tea.Model {
  channel?: string;
  effectiveTime?: number;
  openTeamId?: string;
  serverId?: string;
  serverName?: string;
  static names(): { [key: string]: string } {
    return {
      channel: 'channel',
      effectiveTime: 'effectiveTime',
      openTeamId: 'openTeamId',
      serverId: 'serverId',
      serverName: 'serverName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      channel: 'string',
      effectiveTime: 'number',
      openTeamId: 'string',
      serverId: 'string',
      serverName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthTokenResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: GetAuthTokenResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: GetAuthTokenResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAuthTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAuthTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdsRequest extends $tea.Model {
  formCode?: string;
  openDataInstanceIdList?: string[];
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      openDataInstanceIdList: 'openDataInstanceIdList',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      openDataInstanceIdList: { 'type': 'array', 'itemType': 'string' },
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdsResponseBody extends $tea.Model {
  customFormInstanceResponseList?: GetInstancesByIdsResponseBodyCustomFormInstanceResponseList[];
  static names(): { [key: string]: string } {
    return {
      customFormInstanceResponseList: 'customFormInstanceResponseList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFormInstanceResponseList: { 'type': 'array', 'itemType': GetInstancesByIdsResponseBodyCustomFormInstanceResponseList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetInstancesByIdsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetInstancesByIdsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNegativeWordCloudHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNegativeWordCloudRequest extends $tea.Model {
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

export class GetNegativeWordCloudResponseBody extends $tea.Model {
  words?: GetNegativeWordCloudResponseBodyWords[];
  static names(): { [key: string]: string } {
    return {
      words: 'words',
    };
  }

  static types(): { [key: string]: any } {
    return {
      words: { 'type': 'array', 'itemType': GetNegativeWordCloudResponseBodyWords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNegativeWordCloudResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetNegativeWordCloudResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetNegativeWordCloudResponseBody,
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
  fetchMode?: string;
  fileName?: string;
  key?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      fetchMode: 'fetchMode',
      fileName: 'fileName',
      key: 'key',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fetchMode: 'string',
      fileName: 'string',
      key: 'string',
      openTeamId: 'string',
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
  bizType?: string;
  fileName?: string;
  fileSize?: number;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      bizType: 'bizType',
      fileName: 'fileName',
      fileSize: 'fileSize',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizType: 'string',
      fileName: 'string',
      fileSize: 'number',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetStoragePolicyResponseBody extends $tea.Model {
  accessKeyId?: string;
  endpoint?: string;
  key?: string;
  policy?: string;
  signature?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      endpoint: 'endpoint',
      key: 'key',
      policy: 'policy',
      signature: 'signature',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      endpoint: 'string',
      key: 'string',
      policy: 'string',
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
  createTime?: string;
  creator?: GetTicketResponseBodyCreator;
  customFields?: string;
  openConversationId?: string;
  openTicketId?: string;
  processor?: GetTicketResponseBodyProcessor;
  scene?: string;
  sceneContext?: string;
  stage?: string;
  takers?: GetTicketResponseBodyTakers[];
  template?: GetTicketResponseBodyTemplate;
  title?: string;
  updateTime?: string;
  static names(): { [key: string]: string } {
    return {
      createTime: 'createTime',
      creator: 'creator',
      customFields: 'customFields',
      openConversationId: 'openConversationId',
      openTicketId: 'openTicketId',
      processor: 'processor',
      scene: 'scene',
      sceneContext: 'sceneContext',
      stage: 'stage',
      takers: 'takers',
      template: 'template',
      title: 'title',
      updateTime: 'updateTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createTime: 'string',
      creator: GetTicketResponseBodyCreator,
      customFields: 'string',
      openConversationId: 'string',
      openTicketId: 'string',
      processor: GetTicketResponseBodyProcessor,
      scene: 'string',
      sceneContext: 'string',
      stage: 'string',
      takers: { 'type': 'array', 'itemType': GetTicketResponseBodyTakers },
      template: GetTicketResponseBodyTemplate,
      title: 'string',
      updateTime: 'string',
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

export class GetWordCloudHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWordCloudRequest extends $tea.Model {
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

export class GetWordCloudResponseBody extends $tea.Model {
  words?: GetWordCloudResponseBodyWords[];
  static names(): { [key: string]: string } {
    return {
      words: 'words',
    };
  }

  static types(): { [key: string]: any } {
    return {
      words: { 'type': 'array', 'itemType': GetWordCloudResponseBodyWords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWordCloudResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetWordCloudResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetWordCloudResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupStatisticsRequest extends $tea.Model {
  maxDt?: string;
  minDt?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxDt: 'maxDt',
      minDt: 'minDt',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxDt: 'string',
      minDt: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupStatisticsResponseBody extends $tea.Model {
  groupCount?: number;
  groupTrend?: GroupStatisticsResponseBodyGroupTrend[];
  increaseGroupCount?: number;
  increaseRate?: string;
  static names(): { [key: string]: string } {
    return {
      groupCount: 'groupCount',
      groupTrend: 'groupTrend',
      increaseGroupCount: 'increaseGroupCount',
      increaseRate: 'increaseRate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupCount: 'number',
      groupTrend: { 'type': 'array', 'itemType': GroupStatisticsResponseBodyGroupTrend },
      increaseGroupCount: 'number',
      increaseRate: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GroupStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GroupStatisticsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionCategoryStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionCategoryStatisticsRequest extends $tea.Model {
  maxDt?: string;
  minDt?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxDt: 'maxDt',
      minDt: 'minDt',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxDt: 'string',
      minDt: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionCategoryStatisticsResponseBody extends $tea.Model {
  intentionCategoryRecords?: IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords[];
  static names(): { [key: string]: string } {
    return {
      intentionCategoryRecords: 'intentionCategoryRecords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      intentionCategoryRecords: { 'type': 'array', 'itemType': IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionCategoryStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IntentionCategoryStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IntentionCategoryStatisticsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionStatisticsRequest extends $tea.Model {
  maxDt?: string;
  minDt?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxDt: 'maxDt',
      minDt: 'minDt',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxDt: 'string',
      minDt: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionStatisticsResponseBody extends $tea.Model {
  intentionStatisticsRecords?: IntentionStatisticsResponseBodyIntentionStatisticsRecords[];
  intentionTrend?: IntentionStatisticsResponseBodyIntentionTrend[];
  static names(): { [key: string]: string } {
    return {
      intentionStatisticsRecords: 'intentionStatisticsRecords',
      intentionTrend: 'intentionTrend',
    };
  }

  static types(): { [key: string]: any } {
    return {
      intentionStatisticsRecords: { 'type': 'array', 'itemType': IntentionStatisticsResponseBodyIntentionStatisticsRecords },
      intentionTrend: { 'type': 'array', 'itemType': IntentionStatisticsResponseBodyIntentionTrend },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: IntentionStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: IntentionStatisticsResponseBody,
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
  openConversationId?: string;
  openTeamId?: string;
  topN?: number;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
      topN: 'topN',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openTeamId: 'string',
      topN: 'number',
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

export class QueryCustomerCardHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerCardRequest extends $tea.Model {
  jsonParams?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      jsonParams: 'jsonParams',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jsonParams: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerCardResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerCardResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCustomerCardResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCustomerCardResponseBody,
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
  bizId?: string;
  openConversationId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      openConversationId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupResponseBody extends $tea.Model {
  bizId?: string;
  groupName?: string;
  groupUrl?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  robotCode?: string;
  robotName?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      groupName: 'groupName',
      groupUrl: 'groupUrl',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      robotCode: 'robotCode',
      robotName: 'robotName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      groupName: 'string',
      groupUrl: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
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
  openTeamId?: string;
  targetCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
      targetCorpId: 'targetCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openTeamId: 'string',
      targetCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberResponseBody extends $tea.Model {
  result?: QueryGroupMemberResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryGroupMemberResponseBodyResult,
      success: 'boolean',
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

export class QueryInstancesByMultiConditionsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancesByMultiConditionsRequest extends $tea.Model {
  formCode?: string;
  maxResults?: number;
  nextToken?: string;
  openTeamId?: string;
  searchFields?: string;
  sortFields?: QueryInstancesByMultiConditionsRequestSortFields[];
  static names(): { [key: string]: string } {
    return {
      formCode: 'formCode',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openTeamId: 'openTeamId',
      searchFields: 'searchFields',
      sortFields: 'sortFields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      formCode: 'string',
      maxResults: 'number',
      nextToken: 'string',
      openTeamId: 'string',
      searchFields: 'string',
      sortFields: { 'type': 'array', 'itemType': QueryInstancesByMultiConditionsRequestSortFields },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancesByMultiConditionsResponseBody extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  records?: QueryInstancesByMultiConditionsResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': QueryInstancesByMultiConditionsResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancesByMultiConditionsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryInstancesByMultiConditionsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryInstancesByMultiConditionsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  openBatchTaskId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openBatchTaskId: 'openBatchTaskId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openBatchTaskId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsResponseBody extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  records?: QuerySendMsgTaskStatisticsResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': QuerySendMsgTaskStatisticsResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QuerySendMsgTaskStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QuerySendMsgTaskStatisticsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsDetailRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  openBatchTaskId?: string;
  openConversationId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openBatchTaskId: 'openBatchTaskId',
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openBatchTaskId: 'string',
      openConversationId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsDetailResponseBody extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  records?: QuerySendMsgTaskStatisticsDetailResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': QuerySendMsgTaskStatisticsDetailResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QuerySendMsgTaskStatisticsDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QuerySendMsgTaskStatisticsDetailResponseBody,
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
  maxResults?: number;
  nextToken?: string;
  openConversationId?: string;
  openMsgTaskId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      openMsgTaskId: 'openMsgTaskId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openConversationId: 'string',
      openMsgTaskId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceGroupMessageReadStatusResponseBody extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  records?: QueryServiceGroupMessageReadStatusResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': QueryServiceGroupMessageReadStatusResponseBodyRecords },
      totalCount: 'number',
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

export class QueueNotifyHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueueNotifyRequest extends $tea.Model {
  estimateWaitMin?: number;
  openTeamId?: string;
  queuePlace?: number;
  serviceToken?: string;
  targetChannel?: string;
  tips?: string;
  visitorToken?: string;
  static names(): { [key: string]: string } {
    return {
      estimateWaitMin: 'estimateWaitMin',
      openTeamId: 'openTeamId',
      queuePlace: 'queuePlace',
      serviceToken: 'serviceToken',
      targetChannel: 'targetChannel',
      tips: 'tips',
      visitorToken: 'visitorToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      estimateWaitMin: 'number',
      openTeamId: 'string',
      queuePlace: 'number',
      serviceToken: 'string',
      targetChannel: 'string',
      tips: 'string',
      visitorToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueueNotifyResponseBody extends $tea.Model {
  dingOpenErrcode?: number;
  errorMsg?: string;
  result?: boolean;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      dingOpenErrcode: 'dingOpenErrcode',
      errorMsg: 'errorMsg',
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingOpenErrcode: 'number',
      errorMsg: 'string',
      result: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueueNotifyResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueueNotifyResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueueNotifyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerDetailRequest extends $tea.Model {
  hasLogin?: boolean;
  hasOpenConv?: boolean;
  maxDt?: string;
  minDt?: string;
  openConversationId?: string;
  openTeamId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      hasLogin: 'hasLogin',
      hasOpenConv: 'hasOpenConv',
      maxDt: 'maxDt',
      minDt: 'minDt',
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasLogin: 'boolean',
      hasOpenConv: 'boolean',
      maxDt: 'string',
      minDt: 'string',
      openConversationId: 'string',
      openTeamId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerDetailResponseBody extends $tea.Model {
  currentPage?: number;
  pageSize?: number;
  records?: ReportCustomerDetailResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      pageSize: 'pageSize',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      pageSize: 'number',
      records: { 'type': 'array', 'itemType': ReportCustomerDetailResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReportCustomerDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReportCustomerDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerStatisticsRequest extends $tea.Model {
  groupOwnerUserIds?: string[];
  groupTags?: string[];
  maxDt?: string;
  minDt?: string;
  openConversationIds?: string[];
  openGroupSetId?: string;
  openTeamId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      groupOwnerUserIds: 'groupOwnerUserIds',
      groupTags: 'groupTags',
      maxDt: 'maxDt',
      minDt: 'minDt',
      openConversationIds: 'openConversationIds',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupOwnerUserIds: { 'type': 'array', 'itemType': 'string' },
      groupTags: { 'type': 'array', 'itemType': 'string' },
      maxDt: 'string',
      minDt: 'string',
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      openGroupSetId: 'string',
      openTeamId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerStatisticsResponseBody extends $tea.Model {
  currentPage?: number;
  pageSize?: number;
  records?: ReportCustomerStatisticsResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      currentPage: 'currentPage',
      pageSize: 'pageSize',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      currentPage: 'number',
      pageSize: 'number',
      records: { 'type': 'array', 'itemType': ReportCustomerStatisticsResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ReportCustomerStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ReportCustomerStatisticsResponseBody,
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
  creatorUnionId?: string;
  customFields?: string;
  notify?: ResubmitTicketRequestNotify;
  openTeamId?: string;
  openTemplateBizId?: string;
  openTicketId?: string;
  processorUnionIds?: string[];
  scene?: string;
  sceneContext?: ResubmitTicketRequestSceneContext;
  ticketMemo?: ResubmitTicketRequestTicketMemo;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      customFields: 'customFields',
      notify: 'notify',
      openTeamId: 'openTeamId',
      openTemplateBizId: 'openTemplateBizId',
      openTicketId: 'openTicketId',
      processorUnionIds: 'processorUnionIds',
      scene: 'scene',
      sceneContext: 'sceneContext',
      ticketMemo: 'ticketMemo',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      customFields: 'string',
      notify: ResubmitTicketRequestNotify,
      openTeamId: 'string',
      openTemplateBizId: 'string',
      openTicketId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      scene: 'string',
      sceneContext: ResubmitTicketRequestSceneContext,
      ticketMemo: ResubmitTicketRequestTicketMemo,
      title: 'string',
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
  notify?: RetractTicketRequestNotify;
  openTeamId?: string;
  openTicketId?: string;
  operatorUnionId?: string;
  ticketMemo?: RetractTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      notify: 'notify',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      operatorUnionId: 'operatorUnionId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notify: RetractTicketRequestNotify,
      openTeamId: 'string',
      openTicketId: 'string',
      operatorUnionId: 'string',
      ticketMemo: RetractTicketRequestTicketMemo,
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

export class RobotMessageRecallHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotMessageRecallRequest extends $tea.Model {
  openConversationId?: string;
  openMsgId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openMsgId: 'openMsgId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openMsgId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotMessageRecallResponseBody extends $tea.Model {
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

export class RobotMessageRecallResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: RobotMessageRecallResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: RobotMessageRecallResponseBody,
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
  groupName?: string;
  maxResults?: number;
  nextToken?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  searchType?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      searchType: 'searchType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      maxResults: 'number',
      nextToken: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
      searchType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchGroupResponseBody extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  records?: SearchGroupResponseBodyRecords[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      records: 'records',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      records: { 'type': 'array', 'itemType': SearchGroupResponseBodyRecords },
      totalCount: 'number',
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

export class SendMsgByTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskRequest extends $tea.Model {
  messageContent?: SendMsgByTaskRequestMessageContent;
  openTeamId?: string;
  queryGroup?: SendMsgByTaskRequestQueryGroup;
  sendConfig?: SendMsgByTaskRequestSendConfig;
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      messageContent: 'messageContent',
      openTeamId: 'openTeamId',
      queryGroup: 'queryGroup',
      sendConfig: 'sendConfig',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageContent: SendMsgByTaskRequestMessageContent,
      openTeamId: 'string',
      queryGroup: SendMsgByTaskRequestQueryGroup,
      sendConfig: SendMsgByTaskRequestSendConfig,
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskResponseBody extends $tea.Model {
  openBatchTaskId?: string;
  static names(): { [key: string]: string } {
    return {
      openBatchTaskId: 'openBatchTaskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openBatchTaskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendMsgByTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendMsgByTaskResponseBody,
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
  atDingtalkIds?: string[];
  atMobiles?: string[];
  atUnionIds?: string[];
  btnOrientation?: string;
  btns?: SendServiceGroupMessageRequestBtns[];
  content?: string;
  hasContentLinks?: boolean;
  isAtAll?: boolean;
  messageType?: string;
  receiverDingtalkIds?: string[];
  receiverMobiles?: string[];
  receiverUnionIds?: string[];
  targetOpenConversationId?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      atDingtalkIds: 'atDingtalkIds',
      atMobiles: 'atMobiles',
      atUnionIds: 'atUnionIds',
      btnOrientation: 'btnOrientation',
      btns: 'btns',
      content: 'content',
      hasContentLinks: 'hasContentLinks',
      isAtAll: 'isAtAll',
      messageType: 'messageType',
      receiverDingtalkIds: 'receiverDingtalkIds',
      receiverMobiles: 'receiverMobiles',
      receiverUnionIds: 'receiverUnionIds',
      targetOpenConversationId: 'targetOpenConversationId',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atDingtalkIds: { 'type': 'array', 'itemType': 'string' },
      atMobiles: { 'type': 'array', 'itemType': 'string' },
      atUnionIds: { 'type': 'array', 'itemType': 'string' },
      btnOrientation: 'string',
      btns: { 'type': 'array', 'itemType': SendServiceGroupMessageRequestBtns },
      content: 'string',
      hasContentLinks: 'boolean',
      isAtAll: 'boolean',
      messageType: 'string',
      receiverDingtalkIds: { 'type': 'array', 'itemType': 'string' },
      receiverMobiles: { 'type': 'array', 'itemType': 'string' },
      receiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      targetOpenConversationId: 'string',
      title: 'string',
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

export class SetRobotConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRobotConfigRequest extends $tea.Model {
  dingIsvOrgId?: number;
  dingOrgId?: number;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  openGroupSetId?: string;
  openTeamId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      dingIsvOrgId: 'dingIsvOrgId',
      dingOrgId: 'dingOrgId',
      dingSuiteKey: 'dingSuiteKey',
      dingTokenGrantType: 'dingTokenGrantType',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingIsvOrgId: 'number',
      dingOrgId: 'number',
      dingSuiteKey: 'string',
      dingTokenGrantType: 'number',
      openGroupSetId: 'string',
      openTeamId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRobotConfigResponseBody extends $tea.Model {
  result?: SetRobotConfigResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SetRobotConfigResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRobotConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SetRobotConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SetRobotConfigResponseBody,
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
  openTeamId?: string;
  openTicketId?: string;
  takerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      takerUnionId: 'takerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      openTicketId: 'string',
      takerUnionId: 'string',
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

export class TopicStatisticsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopicStatisticsRequest extends $tea.Model {
  maxDt?: string;
  minDt?: string;
  openConversationIds?: string;
  openTeamId?: string;
  searchContent?: string;
  static names(): { [key: string]: string } {
    return {
      maxDt: 'maxDt',
      minDt: 'minDt',
      openConversationIds: 'openConversationIds',
      openTeamId: 'openTeamId',
      searchContent: 'searchContent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxDt: 'string',
      minDt: 'string',
      openConversationIds: 'string',
      openTeamId: 'string',
      searchContent: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopicStatisticsResponseBody extends $tea.Model {
  topicStatisticsRecords?: TopicStatisticsResponseBodyTopicStatisticsRecords[];
  static names(): { [key: string]: string } {
    return {
      topicStatisticsRecords: 'topicStatisticsRecords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      topicStatisticsRecords: { 'type': 'array', 'itemType': TopicStatisticsResponseBodyTopicStatisticsRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TopicStatisticsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: TopicStatisticsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: TopicStatisticsResponseBody,
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
  notify?: TransferTicketRequestNotify;
  openTeamId?: string;
  openTicketId?: string;
  processorUnionId?: string;
  processorUnionIds?: string[];
  ticketMemo?: TransferTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      notify: 'notify',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      processorUnionId: 'processorUnionId',
      processorUnionIds: 'processorUnionIds',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      notify: TransferTicketRequestNotify,
      openTeamId: 'string',
      openTicketId: 'string',
      processorUnionId: 'string',
      processorUnionIds: { 'type': 'array', 'itemType': 'string' },
      ticketMemo: TransferTicketRequestTicketMemo,
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
  openConversationIds?: string[];
  tagNames?: string[];
  updateType?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationIds: 'openConversationIds',
      tagNames: 'tagNames',
      updateType: 'updateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
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

export class UpdateInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceRequest extends $tea.Model {
  externalBizId?: string;
  formCode?: string;
  formDataList?: string;
  openDataInstanceId?: string;
  openTeamId?: string;
  operatorUnionId?: string;
  ownerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      externalBizId: 'externalBizId',
      formCode: 'formCode',
      formDataList: 'formDataList',
      openDataInstanceId: 'openDataInstanceId',
      openTeamId: 'openTeamId',
      operatorUnionId: 'operatorUnionId',
      ownerUnionId: 'ownerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      externalBizId: 'string',
      formCode: 'string',
      formDataList: 'string',
      openDataInstanceId: 'string',
      openTeamId: 'string',
      operatorUnionId: 'string',
      ownerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceResponseBody extends $tea.Model {
  openDataInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      openDataInstanceId: 'openDataInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openDataInstanceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstanceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateInstanceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInstanceResponseBody,
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
  customFields?: string;
  openTeamId?: string;
  openTicketId?: string;
  processorUnionId?: string;
  ticketMemo?: UpdateTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      customFields: 'customFields',
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      processorUnionId: 'processorUnionId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customFields: 'string',
      openTeamId: 'string',
      openTicketId: 'string',
      processorUnionId: 'string',
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
  ccsInstanceId?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      ccsInstanceId: 'ccsInstanceId',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ccsInstanceId: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
      templateId: 'string',
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
  openConversationId?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
      templateId: 'string',
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
  openTeamId?: string;
  openTicketId?: string;
  operatorUnionId?: string;
  ticketMemo?: UrgeTicketRequestTicketMemo;
  static names(): { [key: string]: string } {
    return {
      openTeamId: 'openTeamId',
      openTicketId: 'openTicketId',
      operatorUnionId: 'operatorUnionId',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTeamId: 'string',
      openTicketId: 'string',
      operatorUnionId: 'string',
      ticketMemo: UrgeTicketRequestTicketMemo,
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

export class AddKnowledgeRequestAttachmentList extends $tea.Model {
  mimeType?: string;
  path?: string;
  size?: number;
  suffix?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      mimeType: 'mime_type',
      path: 'path',
      size: 'size',
      suffix: 'suffix',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mimeType: 'string',
      path: 'string',
      size: 'number',
      suffix: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenCategoryResponseBodyResult extends $tea.Model {
  id?: number;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenKnowledgeRequestAttachments extends $tea.Model {
  mimeType?: string;
  path?: string;
  size?: number;
  suffix?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      mimeType: 'mimeType',
      path: 'path',
      size: 'size',
      suffix: 'suffix',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mimeType: 'string',
      path: 'string',
      size: 'number',
      suffix: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenKnowledgeResponseBodyResult extends $tea.Model {
  id?: number;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      message: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddOpenLibraryResponseBodyResult extends $tea.Model {
  id?: number;
  message?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      message: 'message',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'number',
      message: 'string',
      success: 'boolean',
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
  attachments?: AddTicketMemoRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': AddTicketMemoRequestTicketMemoAttachments },
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AssignTicketRequestNotify extends $tea.Model {
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  workNoticeReceiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
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
  attachments?: AssignTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': AssignTicketRequestTicketMemoAttachments },
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchBindingGroupBizIdsRequestBindingGroupBizIds extends $tea.Model {
  bizId?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      openConversationId: 'string',
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

export class BatchQuerySendMessageTaskResponseBodyRecords extends $tea.Model {
  createName?: string;
  createTimeStr?: string;
  createUnionId?: string;
  openBatchTaskId?: string;
  readGroupInc?: number;
  sendGroupInc?: number;
  sendMessageStatus?: string;
  sendTaskTimeStr?: string;
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      createName: 'createName',
      createTimeStr: 'createTimeStr',
      createUnionId: 'createUnionId',
      openBatchTaskId: 'openBatchTaskId',
      readGroupInc: 'readGroupInc',
      sendGroupInc: 'sendGroupInc',
      sendMessageStatus: 'sendMessageStatus',
      sendTaskTimeStr: 'sendTaskTimeStr',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createName: 'string',
      createTimeStr: 'string',
      createUnionId: 'string',
      openBatchTaskId: 'string',
      readGroupInc: 'number',
      sendGroupInc: 'number',
      sendMessageStatus: 'string',
      sendTaskTimeStr: 'string',
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CancelTicketRequestNotify extends $tea.Model {
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  workNoticeReceiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
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
  attachments?: CancelTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': CancelTicketRequestTicketMemoAttachments },
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryStatisticsResponseBodyCategoryStatisticsRecords extends $tea.Model {
  count?: number;
  lastCount?: number;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      lastCount: 'lastCount',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      lastCount: 'number',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CategoryStatisticsResponseBodyCategoryTrend extends $tea.Model {
  count?: number;
  dt?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      dt: 'dt',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      dt: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketRequestNotify extends $tea.Model {
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  workNoticeReceiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketRequestSceneContextGroupMsgs extends $tea.Model {
  anchor?: boolean;
  openMsgId?: string;
  static names(): { [key: string]: string } {
    return {
      anchor: 'anchor',
      openMsgId: 'openMsgId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      anchor: 'boolean',
      openMsgId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTicketRequestSceneContext extends $tea.Model {
  groupMsgs?: CreateTicketRequestSceneContextGroupMsgs[];
  openConversationId?: string;
  relevantorUnionIds?: string[];
  topicId?: string;
  static names(): { [key: string]: string } {
    return {
      groupMsgs: 'groupMsgs',
      openConversationId: 'openConversationId',
      relevantorUnionIds: 'relevantorUnionIds',
      topicId: 'topicId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMsgs: { 'type': 'array', 'itemType': CreateTicketRequestSceneContextGroupMsgs },
      openConversationId: 'string',
      relevantorUnionIds: { 'type': 'array', 'itemType': 'string' },
      topicId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmotionStatisticsResponseBodyEmotionStatisticsRecords extends $tea.Model {
  count?: number;
  dt?: string;
  emotionScore?: number;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      dt: 'dt',
      emotionScore: 'emotionScore',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      dt: 'string',
      emotionScore: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishTicketRequestNotify extends $tea.Model {
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  workNoticeReceiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
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
  attachments?: FinishTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': FinishTicketRequestTicketMemoAttachments },
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthTokenResponseBodyResult extends $tea.Model {
  authToken?: string;
  channel?: string;
  effectiveTime?: number;
  serverId?: string;
  serverName?: string;
  static names(): { [key: string]: string } {
    return {
      authToken: 'authToken',
      channel: 'channel',
      effectiveTime: 'effectiveTime',
      serverId: 'serverId',
      serverName: 'serverName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authToken: 'string',
      channel: 'string',
      effectiveTime: 'number',
      serverId: 'string',
      serverName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInstancesByIdsResponseBodyCustomFormInstanceResponseList extends $tea.Model {
  creatorUnionId?: string;
  fields?: string;
  formCode?: string;
  gmtCreate?: string;
  gmtModified?: string;
  modifiedUnionId?: string;
  openDataInstanceId?: string;
  openTeamId?: string;
  ownerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      fields: 'fields',
      formCode: 'formCode',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      modifiedUnionId: 'modifiedUnionId',
      openDataInstanceId: 'openDataInstanceId',
      openTeamId: 'openTeamId',
      ownerUnionId: 'ownerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      fields: 'string',
      formCode: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      modifiedUnionId: 'string',
      openDataInstanceId: 'string',
      openTeamId: 'string',
      ownerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetNegativeWordCloudResponseBodyWords extends $tea.Model {
  count?: number;
  word?: string;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      word: 'word',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      word: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyCreator extends $tea.Model {
  nickName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      nickName: 'nickName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nickName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyProcessor extends $tea.Model {
  nickName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      nickName: 'nickName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nickName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyTakers extends $tea.Model {
  nickName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      nickName: 'nickName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nickName: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTicketResponseBodyTemplate extends $tea.Model {
  openTemplateBizId?: string;
  openTemplateId?: string;
  templateName?: string;
  static names(): { [key: string]: string } {
    return {
      openTemplateBizId: 'openTemplateBizId',
      openTemplateId: 'openTemplateId',
      templateName: 'templateName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTemplateBizId: 'string',
      openTemplateId: 'string',
      templateName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWordCloudResponseBodyWords extends $tea.Model {
  count?: number;
  word?: string;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      word: 'word',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      word: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GroupStatisticsResponseBodyGroupTrend extends $tea.Model {
  count?: number;
  dt?: string;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      dt: 'dt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      dt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionCategoryStatisticsResponseBodyIntentionCategoryRecords extends $tea.Model {
  askCount?: number;
  categoryName?: string;
  dissatisfiedCount?: number;
  errorCount?: number;
  praiseCount?: number;
  suggestCount?: number;
  static names(): { [key: string]: string } {
    return {
      askCount: 'askCount',
      categoryName: 'categoryName',
      dissatisfiedCount: 'dissatisfiedCount',
      errorCount: 'errorCount',
      praiseCount: 'praiseCount',
      suggestCount: 'suggestCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      askCount: 'number',
      categoryName: 'string',
      dissatisfiedCount: 'number',
      errorCount: 'number',
      praiseCount: 'number',
      suggestCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionStatisticsResponseBodyIntentionStatisticsRecords extends $tea.Model {
  count?: number;
  intention?: string;
  lastCount?: number;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      intention: 'intention',
      lastCount: 'lastCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      intention: 'string',
      lastCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class IntentionStatisticsResponseBodyIntentionTrend extends $tea.Model {
  count?: number;
  dt?: string;
  intention?: string;
  static names(): { [key: string]: string } {
    return {
      count: 'count',
      dt: 'dt',
      intention: 'intention',
    };
  }

  static types(): { [key: string]: any } {
    return {
      count: 'number',
      dt: 'string',
      intention: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponseBodyRecordsOperator extends $tea.Model {
  nickName?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      nickName: 'nickName',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nickName: 'string',
      unionId: 'string',
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
  attachments?: ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': ListTicketOperateRecordResponseBodyRecordsTicketMemoAttachments },
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListTicketOperateRecordResponseBodyRecords extends $tea.Model {
  openTicketId?: string;
  operateData?: string;
  operateTime?: string;
  operation?: string;
  operationDisplayName?: string;
  operator?: ListTicketOperateRecordResponseBodyRecordsOperator;
  ticketMemo?: ListTicketOperateRecordResponseBodyRecordsTicketMemo;
  static names(): { [key: string]: string } {
    return {
      openTicketId: 'openTicketId',
      operateData: 'operateData',
      operateTime: 'operateTime',
      operation: 'operation',
      operationDisplayName: 'operationDisplayName',
      operator: 'operator',
      ticketMemo: 'ticketMemo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openTicketId: 'string',
      operateData: 'string',
      operateTime: 'string',
      operation: 'string',
      operationDisplayName: 'string',
      operator: ListTicketOperateRecordResponseBodyRecordsOperator,
      ticketMemo: ListTicketOperateRecordResponseBodyRecordsTicketMemo,
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

export class QueryActiveUsersResponseBodyActiveUserInfos extends $tea.Model {
  actionIndexL14d?: number;
  actionIndexL30d?: number;
  actionIndexL7d?: number;
  activeScore?: number;
  nickName?: string;
  ranking?: number;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      actionIndexL14d: 'actionIndexL14d',
      actionIndexL30d: 'actionIndexL30d',
      actionIndexL7d: 'actionIndexL7d',
      activeScore: 'activeScore',
      nickName: 'nickName',
      ranking: 'ranking',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionIndexL14d: 'number',
      actionIndexL30d: 'number',
      actionIndexL7d: 'number',
      activeScore: 'number',
      nickName: 'string',
      ranking: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberResponseBodyResultGroupMemberList extends $tea.Model {
  avatarMediaId?: string;
  isUser?: boolean;
  nickName?: string;
  owner?: boolean;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      isUser: 'isUser',
      nickName: 'nickName',
      owner: 'owner',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'string',
      isUser: 'boolean',
      nickName: 'string',
      owner: 'boolean',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupMemberResponseBodyResult extends $tea.Model {
  groupMemberList?: QueryGroupMemberResponseBodyResultGroupMemberList[];
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      groupMemberList: 'groupMemberList',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMemberList: { 'type': 'array', 'itemType': QueryGroupMemberResponseBodyResultGroupMemberList },
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGroupSetResponseBodyRecords extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  groupSetName?: string;
  openGroupSetId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      groupSetName: 'groupSetName',
      openGroupSetId: 'openGroupSetId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      groupSetName: 'string',
      openGroupSetId: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancesByMultiConditionsRequestSortFields extends $tea.Model {
  fieldCode?: string;
  sortBy?: string;
  static names(): { [key: string]: string } {
    return {
      fieldCode: 'fieldCode',
      sortBy: 'sortBy',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldCode: 'string',
      sortBy: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryInstancesByMultiConditionsResponseBodyRecords extends $tea.Model {
  creatorUnionId?: string;
  fields?: string;
  formCode?: string;
  gmtCreate?: string;
  gmtModified?: string;
  modifiedUnionId?: string;
  openDataInstanceId?: string;
  openTeamId?: string;
  ownerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      creatorUnionId: 'creatorUnionId',
      fields: 'fields',
      formCode: 'formCode',
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      modifiedUnionId: 'modifiedUnionId',
      openDataInstanceId: 'openDataInstanceId',
      openTeamId: 'openTeamId',
      ownerUnionId: 'ownerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      creatorUnionId: 'string',
      fields: 'string',
      formCode: 'string',
      gmtCreate: 'string',
      gmtModified: 'string',
      modifiedUnionId: 'string',
      openDataInstanceId: 'string',
      openTeamId: 'string',
      ownerUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsResponseBodyRecordsGroup extends $tea.Model {
  bizId?: string;
  groupName?: string;
  groupSetName?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      groupName: 'groupName',
      groupSetName: 'groupSetName',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      groupName: 'string',
      groupSetName: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics extends $tea.Model {
  openBatchTaskId?: string;
  openConversationId?: string;
  readUserInc?: number;
  sendUserInc?: number;
  unReadUserInc?: number;
  static names(): { [key: string]: string } {
    return {
      openBatchTaskId: 'openBatchTaskId',
      openConversationId: 'openConversationId',
      readUserInc: 'readUserInc',
      sendUserInc: 'sendUserInc',
      unReadUserInc: 'unReadUserInc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openBatchTaskId: 'string',
      openConversationId: 'string',
      readUserInc: 'number',
      sendUserInc: 'number',
      unReadUserInc: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsResponseBodyRecords extends $tea.Model {
  errorDetail?: string;
  group?: QuerySendMsgTaskStatisticsResponseBodyRecordsGroup;
  groupUserReadStatistics?: QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics;
  openMsgId?: string;
  status?: string;
  static names(): { [key: string]: string } {
    return {
      errorDetail: 'errorDetail',
      group: 'group',
      groupUserReadStatistics: 'groupUserReadStatistics',
      openMsgId: 'openMsgId',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      errorDetail: 'string',
      group: QuerySendMsgTaskStatisticsResponseBodyRecordsGroup,
      groupUserReadStatistics: QuerySendMsgTaskStatisticsResponseBodyRecordsGroupUserReadStatistics,
      openMsgId: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QuerySendMsgTaskStatisticsDetailResponseBodyRecords extends $tea.Model {
  openBatchTaskId?: string;
  openConversationId?: string;
  readStatus?: number;
  readTimeStr?: string;
  receiverName?: string;
  receiverUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      openBatchTaskId: 'openBatchTaskId',
      openConversationId: 'openConversationId',
      readStatus: 'readStatus',
      readTimeStr: 'readTimeStr',
      receiverName: 'receiverName',
      receiverUnionId: 'receiverUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openBatchTaskId: 'string',
      openConversationId: 'string',
      readStatus: 'number',
      readTimeStr: 'string',
      receiverName: 'string',
      receiverUnionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryServiceGroupMessageReadStatusResponseBodyRecords extends $tea.Model {
  readStatus?: number;
  readTimeStr?: string;
  receiverDingTalkId?: string;
  receiverName?: string;
  receiverUnionId?: string;
  receiverUserId?: string;
  sendTimeStr?: string;
  static names(): { [key: string]: string } {
    return {
      readStatus: 'readStatus',
      readTimeStr: 'readTimeStr',
      receiverDingTalkId: 'receiverDingTalkId',
      receiverName: 'receiverName',
      receiverUnionId: 'receiverUnionId',
      receiverUserId: 'receiverUserId',
      sendTimeStr: 'sendTimeStr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      readStatus: 'number',
      readTimeStr: 'string',
      receiverDingTalkId: 'string',
      receiverName: 'string',
      receiverUnionId: 'string',
      receiverUserId: 'string',
      sendTimeStr: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerDetailResponseBodyRecords extends $tea.Model {
  atRobotCnt?: number;
  customerName?: string;
  groupName?: string;
  hasLogin?: boolean;
  hasOpenConv?: boolean;
  sendMsgCnt?: number;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      atRobotCnt: 'atRobotCnt',
      customerName: 'customerName',
      groupName: 'groupName',
      hasLogin: 'hasLogin',
      hasOpenConv: 'hasOpenConv',
      sendMsgCnt: 'sendMsgCnt',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atRobotCnt: 'number',
      customerName: 'string',
      groupName: 'string',
      hasLogin: 'boolean',
      hasOpenConv: 'boolean',
      sendMsgCnt: 'number',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReportCustomerStatisticsResponseBodyRecords extends $tea.Model {
  atRobotCnt?: number;
  bizId?: string;
  customerCnt?: number;
  groupName?: string;
  groupSetName?: string;
  loginCnt?: number;
  openConvCnt?: number;
  openConversationId?: string;
  openGroupSetId?: string;
  sendMsgCnt?: number;
  senderCnt?: number;
  static names(): { [key: string]: string } {
    return {
      atRobotCnt: 'atRobotCnt',
      bizId: 'bizId',
      customerCnt: 'customerCnt',
      groupName: 'groupName',
      groupSetName: 'groupSetName',
      loginCnt: 'loginCnt',
      openConvCnt: 'openConvCnt',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      sendMsgCnt: 'sendMsgCnt',
      senderCnt: 'senderCnt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atRobotCnt: 'number',
      bizId: 'string',
      customerCnt: 'number',
      groupName: 'string',
      groupSetName: 'string',
      loginCnt: 'number',
      openConvCnt: 'number',
      openConversationId: 'string',
      openGroupSetId: 'string',
      sendMsgCnt: 'number',
      senderCnt: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketRequestNotify extends $tea.Model {
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  workNoticeReceiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketRequestSceneContextGroupMsgs extends $tea.Model {
  anchor?: boolean;
  openMsgId?: string;
  topicId?: string;
  static names(): { [key: string]: string } {
    return {
      anchor: 'anchor',
      openMsgId: 'openMsgId',
      topicId: 'topicId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      anchor: 'boolean',
      openMsgId: 'string',
      topicId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ResubmitTicketRequestSceneContext extends $tea.Model {
  groupMsgs?: ResubmitTicketRequestSceneContextGroupMsgs[];
  openConversationId?: string;
  relevantorUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupMsgs: 'groupMsgs',
      openConversationId: 'openConversationId',
      relevantorUnionIds: 'relevantorUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupMsgs: { 'type': 'array', 'itemType': ResubmitTicketRequestSceneContextGroupMsgs },
      openConversationId: 'string',
      relevantorUnionIds: { 'type': 'array', 'itemType': 'string' },
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
  attachments?: ResubmitTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': ResubmitTicketRequestTicketMemoAttachments },
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetractTicketRequestNotify extends $tea.Model {
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  workNoticeReceiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
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
  attachments?: RetractTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': RetractTicketRequestTicketMemoAttachments },
      memo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SearchGroupResponseBodyRecords extends $tea.Model {
  groupName?: string;
  groupUrl?: string;
  openConversationId?: string;
  openGroupSetId?: string;
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      groupName: 'groupName',
      groupUrl: 'groupUrl',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupName: 'string',
      groupUrl: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskRequestMessageContentBtns extends $tea.Model {
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

export class SendMsgByTaskRequestMessageContent extends $tea.Model {
  atActiveMemberNum?: number;
  atActiveUser?: boolean;
  atAll?: boolean;
  btns?: SendMsgByTaskRequestMessageContentBtns[];
  content?: string;
  images?: string[];
  messageType?: string;
  remind?: boolean;
  title?: string;
  top?: boolean;
  static names(): { [key: string]: string } {
    return {
      atActiveMemberNum: 'atActiveMemberNum',
      atActiveUser: 'atActiveUser',
      atAll: 'atAll',
      btns: 'btns',
      content: 'content',
      images: 'images',
      messageType: 'messageType',
      remind: 'remind',
      title: 'title',
      top: 'top',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atActiveMemberNum: 'number',
      atActiveUser: 'boolean',
      atAll: 'boolean',
      btns: { 'type': 'array', 'itemType': SendMsgByTaskRequestMessageContentBtns },
      content: 'string',
      images: { 'type': 'array', 'itemType': 'string' },
      messageType: 'string',
      remind: 'boolean',
      title: 'string',
      top: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskRequestQueryGroup extends $tea.Model {
  groupTagNames?: string[];
  lastActiveDateFilterType?: string;
  lastActiveTimeEnd?: string;
  lastActiveTimeStart?: string;
  openConversationIds?: string[];
  openGroupSetId?: string;
  queryType?: string;
  static names(): { [key: string]: string } {
    return {
      groupTagNames: 'groupTagNames',
      lastActiveDateFilterType: 'lastActiveDateFilterType',
      lastActiveTimeEnd: 'lastActiveTimeEnd',
      lastActiveTimeStart: 'lastActiveTimeStart',
      openConversationIds: 'openConversationIds',
      openGroupSetId: 'openGroupSetId',
      queryType: 'queryType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupTagNames: { 'type': 'array', 'itemType': 'string' },
      lastActiveDateFilterType: 'string',
      lastActiveTimeEnd: 'string',
      lastActiveTimeStart: 'string',
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
      openGroupSetId: 'string',
      queryType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskRequestSendConfigUrlTrackConfig extends $tea.Model {
  title?: string;
  trackId?: string;
  trackUrl?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      trackId: 'trackId',
      trackUrl: 'trackUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      trackId: 'string',
      trackUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskRequestSendConfig extends $tea.Model {
  needUrlTrack?: boolean;
  sendTime?: string;
  sendType?: string;
  urlTrackConfig?: SendMsgByTaskRequestSendConfigUrlTrackConfig[];
  static names(): { [key: string]: string } {
    return {
      needUrlTrack: 'needUrlTrack',
      sendTime: 'sendTime',
      sendType: 'sendType',
      urlTrackConfig: 'urlTrackConfig',
    };
  }

  static types(): { [key: string]: any } {
    return {
      needUrlTrack: 'boolean',
      sendTime: 'string',
      sendType: 'string',
      urlTrackConfig: { 'type': 'array', 'itemType': SendMsgByTaskRequestSendConfigUrlTrackConfig },
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

export class SetRobotConfigResponseBodyResult extends $tea.Model {
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

export class TopicStatisticsResponseBodyTopicStatisticsRecords extends $tea.Model {
  dt?: string;
  msgCount?: number;
  participantsNum?: number;
  topicNum?: number;
  static names(): { [key: string]: string } {
    return {
      dt: 'dt',
      msgCount: 'msgCount',
      participantsNum: 'participantsNum',
      topicNum: 'topicNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dt: 'string',
      msgCount: 'number',
      participantsNum: 'number',
      topicNum: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class TransferTicketRequestNotify extends $tea.Model {
  groupNoticeReceiverUnionIds?: string[];
  noticeAllGroupMember?: boolean;
  workNoticeReceiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      groupNoticeReceiverUnionIds: 'groupNoticeReceiverUnionIds',
      noticeAllGroupMember: 'noticeAllGroupMember',
      workNoticeReceiverUnionIds: 'workNoticeReceiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
      noticeAllGroupMember: 'boolean',
      workNoticeReceiverUnionIds: { 'type': 'array', 'itemType': 'string' },
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
  attachments?: TransferTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': TransferTicketRequestTicketMemoAttachments },
      memo: 'string',
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
  attachments?: UpdateTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': UpdateTicketRequestTicketMemoAttachments },
      memo: 'string',
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
  attachments?: UrgeTicketRequestTicketMemoAttachments[];
  memo?: string;
  static names(): { [key: string]: string } {
    return {
      attachments: 'attachments',
      memo: 'memo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      attachments: { 'type': 'array', 'itemType': UrgeTicketRequestTicketMemoAttachments },
      memo: 'string',
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


  async addKnowledge(request: AddKnowledgeRequest): Promise<AddKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddKnowledgeHeaders({ });
    return await this.addKnowledgeWithOptions(request, headers, runtime);
  }

  async addKnowledgeWithOptions(request: AddKnowledgeRequest, headers: AddKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<AddKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attachmentList)) {
      body["attachmentList"] = request.attachmentList;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.effectTimeend)) {
      body["effectTimeend"] = request.effectTimeend;
    }

    if (!Util.isUnset(request.effectTimestart)) {
      body["effectTimestart"] = request.effectTimestart;
    }

    if (!Util.isUnset(request.extTitle)) {
      body["extTitle"] = request.extTitle;
    }

    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.libraryKey)) {
      body["libraryKey"] = request.libraryKey;
    }

    if (!Util.isUnset(request.linkUrl)) {
      body["linkUrl"] = request.linkUrl;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.questionIds)) {
      body["questionIds"] = request.questionIds;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<AddKnowledgeResponse>(await this.doROARequest("AddKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/knowledges`, "json", req, runtime), new AddKnowledgeResponse({}));
  }

  async addLibrary(request: AddLibraryRequest): Promise<AddLibraryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLibraryHeaders({ });
    return await this.addLibraryWithOptions(request, headers, runtime);
  }

  async addLibraryWithOptions(request: AddLibraryRequest, headers: AddLibraryHeaders, runtime: $Util.RuntimeOptions): Promise<AddLibraryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.openTeamIds)) {
      body["openTeamIds"] = request.openTeamIds;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.sourcePrimaryKey)) {
      body["sourcePrimaryKey"] = request.sourcePrimaryKey;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
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
    return $tea.cast<AddLibraryResponse>(await this.doROARequest("AddLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/librarys`, "json", req, runtime), new AddLibraryResponse({}));
  }

  async addOpenCategory(request: AddOpenCategoryRequest): Promise<AddOpenCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenCategoryHeaders({ });
    return await this.addOpenCategoryWithOptions(request, headers, runtime);
  }

  async addOpenCategoryWithOptions(request: AddOpenCategoryRequest, headers: AddOpenCategoryHeaders, runtime: $Util.RuntimeOptions): Promise<AddOpenCategoryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.libraryId)) {
      body["libraryId"] = request.libraryId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.parentId)) {
      body["parentId"] = request.parentId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
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
    return $tea.cast<AddOpenCategoryResponse>(await this.doROARequest("AddOpenCategory", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/openCategories`, "json", req, runtime), new AddOpenCategoryResponse({}));
  }

  async addOpenKnowledge(request: AddOpenKnowledgeRequest): Promise<AddOpenKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenKnowledgeHeaders({ });
    return await this.addOpenKnowledgeWithOptions(request, headers, runtime);
  }

  async addOpenKnowledgeWithOptions(request: AddOpenKnowledgeRequest, headers: AddOpenKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<AddOpenKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.attachments)) {
      body["attachments"] = request.attachments;
    }

    if (!Util.isUnset(request.categoryId)) {
      body["categoryId"] = request.categoryId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.effectTimeend)) {
      body["effectTimeend"] = request.effectTimeend;
    }

    if (!Util.isUnset(request.effectTimestart)) {
      body["effectTimestart"] = request.effectTimestart;
    }

    if (!Util.isUnset(request.extTitle)) {
      body["extTitle"] = request.extTitle;
    }

    if (!Util.isUnset(request.keyword)) {
      body["keyword"] = request.keyword;
    }

    if (!Util.isUnset(request.libraryId)) {
      body["libraryId"] = request.libraryId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
    }

    if (!Util.isUnset(request.tags)) {
      body["tags"] = request.tags;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.type)) {
      body["type"] = request.type;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
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
    return $tea.cast<AddOpenKnowledgeResponse>(await this.doROARequest("AddOpenKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/openKnowledges`, "json", req, runtime), new AddOpenKnowledgeResponse({}));
  }

  async addOpenLibrary(request: AddOpenLibraryRequest): Promise<AddOpenLibraryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenLibraryHeaders({ });
    return await this.addOpenLibraryWithOptions(request, headers, runtime);
  }

  async addOpenLibraryWithOptions(request: AddOpenLibraryRequest, headers: AddOpenLibraryHeaders, runtime: $Util.RuntimeOptions): Promise<AddOpenLibraryResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.userName)) {
      body["userName"] = request.userName;
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
    return $tea.cast<AddOpenLibraryResponse>(await this.doROARequest("AddOpenLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/openLibraries`, "json", req, runtime), new AddOpenLibraryResponse({}));
  }

  async addTicketMemo(request: AddTicketMemoRequest): Promise<AddTicketMemoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddTicketMemoHeaders({ });
    return await this.addTicketMemoWithOptions(request, headers, runtime);
  }

  async addTicketMemoWithOptions(request: AddTicketMemoRequest, headers: AddTicketMemoHeaders, runtime: $Util.RuntimeOptions): Promise<AddTicketMemoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<AddTicketMemoResponse>(await this.doROARequest("AddTicketMemo", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/memos`, "none", req, runtime), new AddTicketMemoResponse({}));
  }

  async assignTicket(request: AssignTicketRequest): Promise<AssignTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AssignTicketHeaders({ });
    return await this.assignTicketWithOptions(request, headers, runtime);
  }

  async assignTicketWithOptions(request: AssignTicketRequest, headers: AssignTicketHeaders, runtime: $Util.RuntimeOptions): Promise<AssignTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
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

    if (!Util.isUnset(request.processorUnionIds)) {
      body["processorUnionIds"] = request.processorUnionIds;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<AssignTicketResponse>(await this.doROARequest("AssignTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/assign`, "none", req, runtime), new AssignTicketResponse({}));
  }

  async batchBindingGroupBizIds(request: BatchBindingGroupBizIdsRequest): Promise<BatchBindingGroupBizIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchBindingGroupBizIdsHeaders({ });
    return await this.batchBindingGroupBizIdsWithOptions(request, headers, runtime);
  }

  async batchBindingGroupBizIdsWithOptions(request: BatchBindingGroupBizIdsRequest, headers: BatchBindingGroupBizIdsHeaders, runtime: $Util.RuntimeOptions): Promise<BatchBindingGroupBizIdsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bindingGroupBizIds)) {
      body["bindingGroupBizIds"] = request.bindingGroupBizIds;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<BatchBindingGroupBizIdsResponse>(await this.doROARequest("BatchBindingGroupBizIds", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups/bind`, "json", req, runtime), new BatchBindingGroupBizIdsResponse({}));
  }

  async batchGetGroupSetConfig(request: BatchGetGroupSetConfigRequest): Promise<BatchGetGroupSetConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetGroupSetConfigHeaders({ });
    return await this.batchGetGroupSetConfigWithOptions(request, headers, runtime);
  }

  async batchGetGroupSetConfigWithOptions(request: BatchGetGroupSetConfigRequest, headers: BatchGetGroupSetConfigHeaders, runtime: $Util.RuntimeOptions): Promise<BatchGetGroupSetConfigResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.configKeys)) {
      body["configKeys"] = request.configKeys;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<BatchGetGroupSetConfigResponse>(await this.doROARequest("BatchGetGroupSetConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groupSetConfigs/batchQuery`, "json", req, runtime), new BatchGetGroupSetConfigResponse({}));
  }

  async batchQuerySendMessageTask(request: BatchQuerySendMessageTaskRequest): Promise<BatchQuerySendMessageTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQuerySendMessageTaskHeaders({ });
    return await this.batchQuerySendMessageTaskWithOptions(request, headers, runtime);
  }

  async batchQuerySendMessageTaskWithOptions(request: BatchQuerySendMessageTaskRequest, headers: BatchQuerySendMessageTaskHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQuerySendMessageTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.getReadCount)) {
      body["getReadCount"] = request.getReadCount;
    }

    if (!Util.isUnset(request.gmtCreateEnd)) {
      body["gmtCreateEnd"] = request.gmtCreateEnd;
    }

    if (!Util.isUnset(request.gmtCreateStart)) {
      body["gmtCreateStart"] = request.gmtCreateStart;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<BatchQuerySendMessageTaskResponse>(await this.doROARequest("BatchQuerySendMessageTask", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tasks/query`, "json", req, runtime), new BatchQuerySendMessageTaskResponse({}));
  }

  async boundTemplateToTeam(request: BoundTemplateToTeamRequest): Promise<BoundTemplateToTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BoundTemplateToTeamHeaders({ });
    return await this.boundTemplateToTeamWithOptions(request, headers, runtime);
  }

  async boundTemplateToTeamWithOptions(request: BoundTemplateToTeamRequest, headers: BoundTemplateToTeamHeaders, runtime: $Util.RuntimeOptions): Promise<BoundTemplateToTeamResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.robotConfig)) {
      body["robotConfig"] = request.robotConfig;
    }

    if (!Util.isUnset(request.templateDesc)) {
      body["templateDesc"] = request.templateDesc;
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
    return $tea.cast<BoundTemplateToTeamResponse>(await this.doROARequest("BoundTemplateToTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/teams/templates/bound`, "json", req, runtime), new BoundTemplateToTeamResponse({}));
  }

  async cancelTicket(request: CancelTicketRequest): Promise<CancelTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelTicketHeaders({ });
    return await this.cancelTicketWithOptions(request, headers, runtime);
  }

  async cancelTicketWithOptions(request: CancelTicketRequest, headers: CancelTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CancelTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
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
    return $tea.cast<CancelTicketResponse>(await this.doROARequest("CancelTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/cancel`, "none", req, runtime), new CancelTicketResponse({}));
  }

  async categoryStatistics(request: CategoryStatisticsRequest): Promise<CategoryStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CategoryStatisticsHeaders({ });
    return await this.categoryStatisticsWithOptions(request, headers, runtime);
  }

  async categoryStatisticsWithOptions(request: CategoryStatisticsRequest, headers: CategoryStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<CategoryStatisticsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxDt)) {
      query["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.minDt)) {
      query["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
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
    return $tea.cast<CategoryStatisticsResponse>(await this.doROARequest("CategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/dashboards/categories/statistics`, "json", req, runtime), new CategoryStatisticsResponse({}));
  }

  async closeConversation(request: CloseConversationRequest): Promise<CloseConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseConversationHeaders({ });
    return await this.closeConversationWithOptions(request, headers, runtime);
  }

  async closeConversationWithOptions(request: CloseConversationRequest, headers: CloseConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CloseConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.serverTips)) {
      body["serverTips"] = request.serverTips;
    }

    if (!Util.isUnset(request.serviceToken)) {
      body["serviceToken"] = request.serviceToken;
    }

    if (!Util.isUnset(request.targetChannel)) {
      body["targetChannel"] = request.targetChannel;
    }

    if (!Util.isUnset(request.visitorToken)) {
      body["visitorToken"] = request.visitorToken;
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
    return $tea.cast<CloseConversationResponse>(await this.doROARequest("CloseConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/conversions`, "json", req, runtime), new CloseConversationResponse({}));
  }

  async closeHumanSession(request: CloseHumanSessionRequest): Promise<CloseHumanSessionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseHumanSessionHeaders({ });
    return await this.closeHumanSessionWithOptions(request, headers, runtime);
  }

  async closeHumanSessionWithOptions(request: CloseHumanSessionRequest, headers: CloseHumanSessionHeaders, runtime: $Util.RuntimeOptions): Promise<CloseHumanSessionResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<CloseHumanSessionResponse>(await this.doROARequest("CloseHumanSession", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/humanSessions/close`, "json", req, runtime), new CloseHumanSessionResponse({}));
  }

  async conversationCreatedNotify(request: ConversationCreatedNotifyRequest): Promise<ConversationCreatedNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConversationCreatedNotifyHeaders({ });
    return await this.conversationCreatedNotifyWithOptions(request, headers, runtime);
  }

  async conversationCreatedNotifyWithOptions(request: ConversationCreatedNotifyRequest, headers: ConversationCreatedNotifyHeaders, runtime: $Util.RuntimeOptions): Promise<ConversationCreatedNotifyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.alipayUserId)) {
      body["alipayUserId"] = request.alipayUserId;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.nickName)) {
      body["nickName"] = request.nickName;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.serverName)) {
      body["serverName"] = request.serverName;
    }

    if (!Util.isUnset(request.serverTips)) {
      body["serverTips"] = request.serverTips;
    }

    if (!Util.isUnset(request.serviceToken)) {
      body["serviceToken"] = request.serviceToken;
    }

    if (!Util.isUnset(request.timeoutRemindTips)) {
      body["timeoutRemindTips"] = request.timeoutRemindTips;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.visitorToken)) {
      body["visitorToken"] = request.visitorToken;
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
    return $tea.cast<ConversationCreatedNotifyResponse>(await this.doROARequest("ConversationCreatedNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/customers`, "json", req, runtime), new ConversationCreatedNotifyResponse({}));
  }

  async conversationTransferBeginNotify(request: ConversationTransferBeginNotifyRequest): Promise<ConversationTransferBeginNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConversationTransferBeginNotifyHeaders({ });
    return await this.conversationTransferBeginNotifyWithOptions(request, headers, runtime);
  }

  async conversationTransferBeginNotifyWithOptions(request: ConversationTransferBeginNotifyRequest, headers: ConversationTransferBeginNotifyHeaders, runtime: $Util.RuntimeOptions): Promise<ConversationTransferBeginNotifyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.memo)) {
      body["memo"] = request.memo;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.serviceToken)) {
      body["serviceToken"] = request.serviceToken;
    }

    if (!Util.isUnset(request.sourceSkillGroupId)) {
      body["sourceSkillGroupId"] = request.sourceSkillGroupId;
    }

    if (!Util.isUnset(request.targetSkillGroupId)) {
      body["targetSkillGroupId"] = request.targetSkillGroupId;
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
    return $tea.cast<ConversationTransferBeginNotifyResponse>(await this.doROARequest("ConversationTransferBeginNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/transfers`, "json", req, runtime), new ConversationTransferBeginNotifyResponse({}));
  }

  async conversationTransferCompleteNotify(request: ConversationTransferCompleteNotifyRequest): Promise<ConversationTransferCompleteNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConversationTransferCompleteNotifyHeaders({ });
    return await this.conversationTransferCompleteNotifyWithOptions(request, headers, runtime);
  }

  async conversationTransferCompleteNotifyWithOptions(request: ConversationTransferCompleteNotifyRequest, headers: ConversationTransferCompleteNotifyHeaders, runtime: $Util.RuntimeOptions): Promise<ConversationTransferCompleteNotifyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.alipayUserId)) {
      body["alipayUserId"] = request.alipayUserId;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.nickName)) {
      body["nickName"] = request.nickName;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.serviceToken)) {
      body["serviceToken"] = request.serviceToken;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.visitorToken)) {
      body["visitorToken"] = request.visitorToken;
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
    return $tea.cast<ConversationTransferCompleteNotifyResponse>(await this.doROARequest("ConversationTransferCompleteNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/completes`, "json", req, runtime), new ConversationTransferCompleteNotifyResponse({}));
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

    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
    }

    if (!Util.isUnset(request.groupTagNames)) {
      body["groupTagNames"] = request.groupTagNames;
    }

    if (!Util.isUnset(request.memberStaffIds)) {
      body["memberStaffIds"] = request.memberStaffIds;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.ownerStaffId)) {
      body["ownerStaffId"] = request.ownerStaffId;
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
    return $tea.cast<CreateGroupResponse>(await this.doROARequest("CreateGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups`, "json", req, runtime), new CreateGroupResponse({}));
  }

  async createGroupConversation(request: CreateGroupConversationRequest): Promise<CreateGroupConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupConversationHeaders({ });
    return await this.createGroupConversationWithOptions(request, headers, runtime);
  }

  async createGroupConversationWithOptions(request: CreateGroupConversationRequest, headers: CreateGroupConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.dingGroupId)) {
      body["dingGroupId"] = request.dingGroupId;
    }

    if (!Util.isUnset(request.dingSuiteKey)) {
      body["dingSuiteKey"] = request.dingSuiteKey;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingUserId)) {
      body["dingUserId"] = request.dingUserId;
    }

    if (!Util.isUnset(request.dingUserName)) {
      body["dingUserName"] = request.dingUserName;
    }

    if (!Util.isUnset(request.extValues)) {
      body["extValues"] = request.extValues;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.serverGroupId)) {
      body["serverGroupId"] = request.serverGroupId;
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
    return $tea.cast<CreateGroupConversationResponse>(await this.doROARequest("CreateGroupConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/create/conversations`, "json", req, runtime), new CreateGroupConversationResponse({}));
  }

  async createGroupSet(request: CreateGroupSetRequest): Promise<CreateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupSetHeaders({ });
    return await this.createGroupSetWithOptions(request, headers, runtime);
  }

  async createGroupSetWithOptions(request: CreateGroupSetRequest, headers: CreateGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupSetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupSetName)) {
      body["groupSetName"] = request.groupSetName;
    }

    if (!Util.isUnset(request.groupTemplateId)) {
      body["groupTemplateId"] = request.groupTemplateId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<CreateGroupSetResponse>(await this.doROARequest("CreateGroupSet", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groupSets`, "json", req, runtime), new CreateGroupSetResponse({}));
  }

  async createInstance(request: CreateInstanceRequest): Promise<CreateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInstanceHeaders({ });
    return await this.createInstanceWithOptions(request, headers, runtime);
  }

  async createInstanceWithOptions(request: CreateInstanceRequest, headers: CreateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.externalBizId)) {
      body["externalBizId"] = request.externalBizId;
    }

    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.formDataList)) {
      body["formDataList"] = request.formDataList;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset(request.ownerUnionId)) {
      body["ownerUnionId"] = request.ownerUnionId;
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
    return $tea.cast<CreateInstanceResponse>(await this.doROARequest("CreateInstance", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/customForms/instances`, "json", req, runtime), new CreateInstanceResponse({}));
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
    return $tea.cast<CreateTeamResponse>(await this.doROARequest("CreateTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/teams`, "json", req, runtime), new CreateTeamResponse({}));
  }

  async createTicket(request: CreateTicketRequest): Promise<CreateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTicketHeaders({ });
    return await this.createTicketWithOptions(request, headers, runtime);
  }

  async createTicketWithOptions(request: CreateTicketRequest, headers: CreateTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTemplateBizId)) {
      body["openTemplateBizId"] = request.openTemplateBizId;
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
    return $tea.cast<CreateTicketResponse>(await this.doROARequest("CreateTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets`, "json", req, runtime), new CreateTicketResponse({}));
  }

  async deleteInstance(request: DeleteInstanceRequest): Promise<DeleteInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInstanceHeaders({ });
    return await this.deleteInstanceWithOptions(request, headers, runtime);
  }

  async deleteInstanceWithOptions(request: DeleteInstanceRequest, headers: DeleteInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.openDataInstanceId)) {
      body["openDataInstanceId"] = request.openDataInstanceId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
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
    return $tea.cast<DeleteInstanceResponse>(await this.doROARequest("DeleteInstance", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/customForms/instances/remove`, "json", req, runtime), new DeleteInstanceResponse({}));
  }

  async deleteKnowledge(request: DeleteKnowledgeRequest): Promise<DeleteKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKnowledgeHeaders({ });
    return await this.deleteKnowledgeWithOptions(request, headers, runtime);
  }

  async deleteKnowledgeWithOptions(request: DeleteKnowledgeRequest, headers: DeleteKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.libraryKey)) {
      body["libraryKey"] = request.libraryKey;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<DeleteKnowledgeResponse>(await this.doROARequest("DeleteKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/knowledges/batchDelete`, "json", req, runtime), new DeleteKnowledgeResponse({}));
  }

  async emotionStatistics(request: EmotionStatisticsRequest): Promise<EmotionStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EmotionStatisticsHeaders({ });
    return await this.emotionStatisticsWithOptions(request, headers, runtime);
  }

  async emotionStatisticsWithOptions(request: EmotionStatisticsRequest, headers: EmotionStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<EmotionStatisticsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxDt)) {
      query["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.maxEmotion)) {
      query["maxEmotion"] = request.maxEmotion;
    }

    if (!Util.isUnset(request.minDt)) {
      query["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.minEmotion)) {
      query["minEmotion"] = request.minEmotion;
    }

    if (!Util.isUnset(request.openConversationIds)) {
      query["openConversationIds"] = request.openConversationIds;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      query["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
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
    return $tea.cast<EmotionStatisticsResponse>(await this.doROARequest("EmotionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/emotions/statistics`, "json", req, runtime), new EmotionStatisticsResponse({}));
  }

  async finishTicket(request: FinishTicketRequest): Promise<FinishTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishTicketHeaders({ });
    return await this.finishTicketWithOptions(request, headers, runtime);
  }

  async finishTicketWithOptions(request: FinishTicketRequest, headers: FinishTicketHeaders, runtime: $Util.RuntimeOptions): Promise<FinishTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<FinishTicketResponse>(await this.doROARequest("FinishTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/finish`, "none", req, runtime), new FinishTicketResponse({}));
  }

  async getAuthToken(request: GetAuthTokenRequest): Promise<GetAuthTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAuthTokenHeaders({ });
    return await this.getAuthTokenWithOptions(request, headers, runtime);
  }

  async getAuthTokenWithOptions(request: GetAuthTokenRequest, headers: GetAuthTokenHeaders, runtime: $Util.RuntimeOptions): Promise<GetAuthTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.channel)) {
      body["channel"] = request.channel;
    }

    if (!Util.isUnset(request.effectiveTime)) {
      body["effectiveTime"] = request.effectiveTime;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.serverId)) {
      body["serverId"] = request.serverId;
    }

    if (!Util.isUnset(request.serverName)) {
      body["serverName"] = request.serverName;
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
    return $tea.cast<GetAuthTokenResponse>(await this.doROARequest("GetAuthToken", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/get/tokens`, "json", req, runtime), new GetAuthTokenResponse({}));
  }

  async getInstancesByIds(request: GetInstancesByIdsRequest): Promise<GetInstancesByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesByIdsHeaders({ });
    return await this.getInstancesByIdsWithOptions(request, headers, runtime);
  }

  async getInstancesByIdsWithOptions(request: GetInstancesByIdsRequest, headers: GetInstancesByIdsHeaders, runtime: $Util.RuntimeOptions): Promise<GetInstancesByIdsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.openDataInstanceIdList)) {
      body["openDataInstanceIdList"] = request.openDataInstanceIdList;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<GetInstancesByIdsResponse>(await this.doROARequest("GetInstancesByIds", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/customForms/instances/batchQuery`, "json", req, runtime), new GetInstancesByIdsResponse({}));
  }

  async getNegativeWordCloud(request: GetNegativeWordCloudRequest): Promise<GetNegativeWordCloudResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNegativeWordCloudHeaders({ });
    return await this.getNegativeWordCloudWithOptions(request, headers, runtime);
  }

  async getNegativeWordCloudWithOptions(request: GetNegativeWordCloudRequest, headers: GetNegativeWordCloudHeaders, runtime: $Util.RuntimeOptions): Promise<GetNegativeWordCloudResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetNegativeWordCloudResponse>(await this.doROARequest("GetNegativeWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/negatives/wordClouds`, "json", req, runtime), new GetNegativeWordCloudResponse({}));
  }

  async getOssTempUrl(request: GetOssTempUrlRequest): Promise<GetOssTempUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOssTempUrlHeaders({ });
    return await this.getOssTempUrlWithOptions(request, headers, runtime);
  }

  async getOssTempUrlWithOptions(request: GetOssTempUrlRequest, headers: GetOssTempUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetOssTempUrlResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fetchMode)) {
      query["fetchMode"] = request.fetchMode;
    }

    if (!Util.isUnset(request.fileName)) {
      query["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.key)) {
      query["key"] = request.key;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
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
    return $tea.cast<GetOssTempUrlResponse>(await this.doROARequest("GetOssTempUrl", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/ossServices/tempUrls`, "json", req, runtime), new GetOssTempUrlResponse({}));
  }

  async getStoragePolicy(request: GetStoragePolicyRequest): Promise<GetStoragePolicyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStoragePolicyHeaders({ });
    return await this.getStoragePolicyWithOptions(request, headers, runtime);
  }

  async getStoragePolicyWithOptions(request: GetStoragePolicyRequest, headers: GetStoragePolicyHeaders, runtime: $Util.RuntimeOptions): Promise<GetStoragePolicyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizType)) {
      body["bizType"] = request.bizType;
    }

    if (!Util.isUnset(request.fileName)) {
      body["fileName"] = request.fileName;
    }

    if (!Util.isUnset(request.fileSize)) {
      body["fileSize"] = request.fileSize;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<GetStoragePolicyResponse>(await this.doROARequest("GetStoragePolicy", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/ossServices/policies`, "json", req, runtime), new GetStoragePolicyResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetTicketResponse>(await this.doROARequest("GetTicket", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/tickets`, "json", req, runtime), new GetTicketResponse({}));
  }

  async getWordCloud(request: GetWordCloudRequest): Promise<GetWordCloudResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWordCloudHeaders({ });
    return await this.getWordCloudWithOptions(request, headers, runtime);
  }

  async getWordCloudWithOptions(request: GetWordCloudRequest, headers: GetWordCloudHeaders, runtime: $Util.RuntimeOptions): Promise<GetWordCloudResponse> {
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetWordCloudResponse>(await this.doROARequest("GetWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/wordClouds`, "json", req, runtime), new GetWordCloudResponse({}));
  }

  async groupStatistics(request: GroupStatisticsRequest): Promise<GroupStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupStatisticsHeaders({ });
    return await this.groupStatisticsWithOptions(request, headers, runtime);
  }

  async groupStatisticsWithOptions(request: GroupStatisticsRequest, headers: GroupStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<GroupStatisticsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxDt)) {
      query["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.minDt)) {
      query["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
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
    return $tea.cast<GroupStatisticsResponse>(await this.doROARequest("GroupStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/dashboards/groups/statistics`, "json", req, runtime), new GroupStatisticsResponse({}));
  }

  async intentionCategoryStatistics(request: IntentionCategoryStatisticsRequest): Promise<IntentionCategoryStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IntentionCategoryStatisticsHeaders({ });
    return await this.intentionCategoryStatisticsWithOptions(request, headers, runtime);
  }

  async intentionCategoryStatisticsWithOptions(request: IntentionCategoryStatisticsRequest, headers: IntentionCategoryStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<IntentionCategoryStatisticsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxDt)) {
      query["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.minDt)) {
      query["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
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
    return $tea.cast<IntentionCategoryStatisticsResponse>(await this.doROARequest("IntentionCategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics`, "json", req, runtime), new IntentionCategoryStatisticsResponse({}));
  }

  async intentionStatistics(request: IntentionStatisticsRequest): Promise<IntentionStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IntentionStatisticsHeaders({ });
    return await this.intentionStatisticsWithOptions(request, headers, runtime);
  }

  async intentionStatisticsWithOptions(request: IntentionStatisticsRequest, headers: IntentionStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<IntentionStatisticsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxDt)) {
      query["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.minDt)) {
      query["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
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
    return $tea.cast<IntentionStatisticsResponse>(await this.doROARequest("IntentionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/dashboards/intentions/statistics`, "json", req, runtime), new IntentionStatisticsResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<ListTicketOperateRecordResponse>(await this.doROARequest("ListTicketOperateRecord", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/tickets/operateRecords`, "json", req, runtime), new ListTicketOperateRecordResponse({}));
  }

  async listUserTeams(userId: string): Promise<ListUserTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserTeamsHeaders({ });
    return await this.listUserTeamsWithOptions(userId, headers, runtime);
  }

  async listUserTeamsWithOptions(userId: string, headers: ListUserTeamsHeaders, runtime: $Util.RuntimeOptions): Promise<ListUserTeamsResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<ListUserTeamsResponse>(await this.doROARequest("ListUserTeams", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/users/${userId}/teams`, "json", req, runtime), new ListUserTeamsResponse({}));
  }

  async queryActiveUsers(request: QueryActiveUsersRequest): Promise<QueryActiveUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryActiveUsersHeaders({ });
    return await this.queryActiveUsersWithOptions(request, headers, runtime);
  }

  async queryActiveUsersWithOptions(request: QueryActiveUsersRequest, headers: QueryActiveUsersHeaders, runtime: $Util.RuntimeOptions): Promise<QueryActiveUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.topN)) {
      query["topN"] = request.topN;
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
    return $tea.cast<QueryActiveUsersResponse>(await this.doROARequest("QueryActiveUsers", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/groups/queryActiveUsers`, "json", req, runtime), new QueryActiveUsersResponse({}));
  }

  async queryCustomerCard(request: QueryCustomerCardRequest): Promise<QueryCustomerCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerCardHeaders({ });
    return await this.queryCustomerCardWithOptions(request, headers, runtime);
  }

  async queryCustomerCardWithOptions(request: QueryCustomerCardRequest, headers: QueryCustomerCardHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomerCardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.jsonParams)) {
      body["jsonParams"] = request.jsonParams;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<QueryCustomerCardResponse>(await this.doROARequest("QueryCustomerCard", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/userDetials`, "json", req, runtime), new QueryCustomerCardResponse({}));
  }

  async queryGroup(request: QueryGroupRequest): Promise<QueryGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupHeaders({ });
    return await this.queryGroupWithOptions(request, headers, runtime);
  }

  async queryGroupWithOptions(request: QueryGroupRequest, headers: QueryGroupHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizId)) {
      body["bizId"] = request.bizId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<QueryGroupResponse>(await this.doROARequest("QueryGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups/query`, "json", req, runtime), new QueryGroupResponse({}));
  }

  async queryGroupMember(request: QueryGroupMemberRequest): Promise<QueryGroupMemberResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupMemberHeaders({ });
    return await this.queryGroupMemberWithOptions(request, headers, runtime);
  }

  async queryGroupMemberWithOptions(request: QueryGroupMemberRequest, headers: QueryGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGroupMemberResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.targetCorpId)) {
      body["targetCorpId"] = request.targetCorpId;
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
    return $tea.cast<QueryGroupMemberResponse>(await this.doROARequest("QueryGroupMember", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups/members/query`, "json", req, runtime), new QueryGroupMemberResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<QueryGroupSetResponse>(await this.doROARequest("QueryGroupSet", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/groupSets`, "json", req, runtime), new QueryGroupSetResponse({}));
  }

  async queryInstancesByMultiConditions(request: QueryInstancesByMultiConditionsRequest): Promise<QueryInstancesByMultiConditionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInstancesByMultiConditionsHeaders({ });
    return await this.queryInstancesByMultiConditionsWithOptions(request, headers, runtime);
  }

  async queryInstancesByMultiConditionsWithOptions(request: QueryInstancesByMultiConditionsRequest, headers: QueryInstancesByMultiConditionsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryInstancesByMultiConditionsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.searchFields)) {
      body["searchFields"] = request.searchFields;
    }

    if (!Util.isUnset(request.sortFields)) {
      body["sortFields"] = request.sortFields;
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
    return $tea.cast<QueryInstancesByMultiConditionsResponse>(await this.doROARequest("QueryInstancesByMultiConditions", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery`, "json", req, runtime), new QueryInstancesByMultiConditionsResponse({}));
  }

  async querySendMsgTaskStatistics(request: QuerySendMsgTaskStatisticsRequest): Promise<QuerySendMsgTaskStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySendMsgTaskStatisticsHeaders({ });
    return await this.querySendMsgTaskStatisticsWithOptions(request, headers, runtime);
  }

  async querySendMsgTaskStatisticsWithOptions(request: QuerySendMsgTaskStatisticsRequest, headers: QuerySendMsgTaskStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySendMsgTaskStatisticsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openBatchTaskId)) {
      body["openBatchTaskId"] = request.openBatchTaskId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<QuerySendMsgTaskStatisticsResponse>(await this.doROARequest("QuerySendMsgTaskStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tasks/statistics/query`, "json", req, runtime), new QuerySendMsgTaskStatisticsResponse({}));
  }

  async querySendMsgTaskStatisticsDetail(request: QuerySendMsgTaskStatisticsDetailRequest): Promise<QuerySendMsgTaskStatisticsDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySendMsgTaskStatisticsDetailHeaders({ });
    return await this.querySendMsgTaskStatisticsDetailWithOptions(request, headers, runtime);
  }

  async querySendMsgTaskStatisticsDetailWithOptions(request: QuerySendMsgTaskStatisticsDetailRequest, headers: QuerySendMsgTaskStatisticsDetailHeaders, runtime: $Util.RuntimeOptions): Promise<QuerySendMsgTaskStatisticsDetailResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openBatchTaskId)) {
      body["openBatchTaskId"] = request.openBatchTaskId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<QuerySendMsgTaskStatisticsDetailResponse>(await this.doROARequest("QuerySendMsgTaskStatisticsDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tasks/statistics/details/query`, "json", req, runtime), new QuerySendMsgTaskStatisticsDetailResponse({}));
  }

  async queryServiceGroupMessageReadStatus(request: QueryServiceGroupMessageReadStatusRequest): Promise<QueryServiceGroupMessageReadStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryServiceGroupMessageReadStatusHeaders({ });
    return await this.queryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
  }

  async queryServiceGroupMessageReadStatusWithOptions(request: QueryServiceGroupMessageReadStatusRequest, headers: QueryServiceGroupMessageReadStatusHeaders, runtime: $Util.RuntimeOptions): Promise<QueryServiceGroupMessageReadStatusResponse> {
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

    if (!Util.isUnset(request.openMsgTaskId)) {
      body["openMsgTaskId"] = request.openMsgTaskId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<QueryServiceGroupMessageReadStatusResponse>(await this.doROARequest("QueryServiceGroupMessageReadStatus", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/messages/readStatus/query`, "json", req, runtime), new QueryServiceGroupMessageReadStatusResponse({}));
  }

  async queueNotify(request: QueueNotifyRequest): Promise<QueueNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueueNotifyHeaders({ });
    return await this.queueNotifyWithOptions(request, headers, runtime);
  }

  async queueNotifyWithOptions(request: QueueNotifyRequest, headers: QueueNotifyHeaders, runtime: $Util.RuntimeOptions): Promise<QueueNotifyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.estimateWaitMin)) {
      body["estimateWaitMin"] = request.estimateWaitMin;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.queuePlace)) {
      body["queuePlace"] = request.queuePlace;
    }

    if (!Util.isUnset(request.serviceToken)) {
      body["serviceToken"] = request.serviceToken;
    }

    if (!Util.isUnset(request.targetChannel)) {
      body["targetChannel"] = request.targetChannel;
    }

    if (!Util.isUnset(request.tips)) {
      body["tips"] = request.tips;
    }

    if (!Util.isUnset(request.visitorToken)) {
      body["visitorToken"] = request.visitorToken;
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
    return $tea.cast<QueueNotifyResponse>(await this.doROARequest("QueueNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/dts`, "json", req, runtime), new QueueNotifyResponse({}));
  }

  async reportCustomerDetail(request: ReportCustomerDetailRequest): Promise<ReportCustomerDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportCustomerDetailHeaders({ });
    return await this.reportCustomerDetailWithOptions(request, headers, runtime);
  }

  async reportCustomerDetailWithOptions(request: ReportCustomerDetailRequest, headers: ReportCustomerDetailHeaders, runtime: $Util.RuntimeOptions): Promise<ReportCustomerDetailResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.hasLogin)) {
      body["hasLogin"] = request.hasLogin;
    }

    if (!Util.isUnset(request.hasOpenConv)) {
      body["hasOpenConv"] = request.hasOpenConv;
    }

    if (!Util.isUnset(request.maxDt)) {
      body["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.minDt)) {
      body["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
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
    return $tea.cast<ReportCustomerDetailResponse>(await this.doROARequest("ReportCustomerDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/customers/activities/details/query`, "json", req, runtime), new ReportCustomerDetailResponse({}));
  }

  async reportCustomerStatistics(request: ReportCustomerStatisticsRequest): Promise<ReportCustomerStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportCustomerStatisticsHeaders({ });
    return await this.reportCustomerStatisticsWithOptions(request, headers, runtime);
  }

  async reportCustomerStatisticsWithOptions(request: ReportCustomerStatisticsRequest, headers: ReportCustomerStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<ReportCustomerStatisticsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupOwnerUserIds)) {
      body["groupOwnerUserIds"] = request.groupOwnerUserIds;
    }

    if (!Util.isUnset(request.groupTags)) {
      body["groupTags"] = request.groupTags;
    }

    if (!Util.isUnset(request.maxDt)) {
      body["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.minDt)) {
      body["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.openConversationIds)) {
      body["openConversationIds"] = request.openConversationIds;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
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
    return $tea.cast<ReportCustomerStatisticsResponse>(await this.doROARequest("ReportCustomerStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/customers/activities/statistics/query`, "json", req, runtime), new ReportCustomerStatisticsResponse({}));
  }

  async resubmitTicket(request: ResubmitTicketRequest): Promise<ResubmitTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ResubmitTicketHeaders({ });
    return await this.resubmitTicketWithOptions(request, headers, runtime);
  }

  async resubmitTicketWithOptions(request: ResubmitTicketRequest, headers: ResubmitTicketHeaders, runtime: $Util.RuntimeOptions): Promise<ResubmitTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTemplateBizId)) {
      body["openTemplateBizId"] = request.openTemplateBizId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
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

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
    return $tea.cast<ResubmitTicketResponse>(await this.doROARequest("ResubmitTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/resubmit`, "none", req, runtime), new ResubmitTicketResponse({}));
  }

  async retractTicket(request: RetractTicketRequest): Promise<RetractTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetractTicketHeaders({ });
    return await this.retractTicketWithOptions(request, headers, runtime);
  }

  async retractTicketWithOptions(request: RetractTicketRequest, headers: RetractTicketHeaders, runtime: $Util.RuntimeOptions): Promise<RetractTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
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
    return $tea.cast<RetractTicketResponse>(await this.doROARequest("RetractTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/retract`, "none", req, runtime), new RetractTicketResponse({}));
  }

  async robotMessageRecall(request: RobotMessageRecallRequest): Promise<RobotMessageRecallResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RobotMessageRecallHeaders({ });
    return await this.robotMessageRecallWithOptions(request, headers, runtime);
  }

  async robotMessageRecallWithOptions(request: RobotMessageRecallRequest, headers: RobotMessageRecallHeaders, runtime: $Util.RuntimeOptions): Promise<RobotMessageRecallResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openMsgId)) {
      body["openMsgId"] = request.openMsgId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<RobotMessageRecallResponse>(await this.doROARequest("RobotMessageRecall", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/robots/messages/recall`, "json", req, runtime), new RobotMessageRecallResponse({}));
  }

  async searchGroup(request: SearchGroupRequest): Promise<SearchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchGroupHeaders({ });
    return await this.searchGroupWithOptions(request, headers, runtime);
  }

  async searchGroupWithOptions(request: SearchGroupRequest, headers: SearchGroupHeaders, runtime: $Util.RuntimeOptions): Promise<SearchGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupName)) {
      body["groupName"] = request.groupName;
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

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.searchType)) {
      body["searchType"] = request.searchType;
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
    return $tea.cast<SearchGroupResponse>(await this.doROARequest("SearchGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups/search`, "json", req, runtime), new SearchGroupResponse({}));
  }

  async sendMsgByTask(request: SendMsgByTaskRequest): Promise<SendMsgByTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMsgByTaskHeaders({ });
    return await this.sendMsgByTaskWithOptions(request, headers, runtime);
  }

  async sendMsgByTaskWithOptions(request: SendMsgByTaskRequest, headers: SendMsgByTaskHeaders, runtime: $Util.RuntimeOptions): Promise<SendMsgByTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.messageContent))) {
      body["messageContent"] = request.messageContent;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset($tea.toMap(request.queryGroup))) {
      body["queryGroup"] = request.queryGroup;
    }

    if (!Util.isUnset($tea.toMap(request.sendConfig))) {
      body["sendConfig"] = request.sendConfig;
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
    return $tea.cast<SendMsgByTaskResponse>(await this.doROARequest("SendMsgByTask", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/messages/tasks/send`, "json", req, runtime), new SendMsgByTaskResponse({}));
  }

  async sendServiceGroupMessage(request: SendServiceGroupMessageRequest): Promise<SendServiceGroupMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendServiceGroupMessageHeaders({ });
    return await this.sendServiceGroupMessageWithOptions(request, headers, runtime);
  }

  async sendServiceGroupMessageWithOptions(request: SendServiceGroupMessageRequest, headers: SendServiceGroupMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendServiceGroupMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.atDingtalkIds)) {
      body["atDingtalkIds"] = request.atDingtalkIds;
    }

    if (!Util.isUnset(request.atMobiles)) {
      body["atMobiles"] = request.atMobiles;
    }

    if (!Util.isUnset(request.atUnionIds)) {
      body["atUnionIds"] = request.atUnionIds;
    }

    if (!Util.isUnset(request.btnOrientation)) {
      body["btnOrientation"] = request.btnOrientation;
    }

    if (!Util.isUnset(request.btns)) {
      body["btns"] = request.btns;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.hasContentLinks)) {
      body["hasContentLinks"] = request.hasContentLinks;
    }

    if (!Util.isUnset(request.isAtAll)) {
      body["isAtAll"] = request.isAtAll;
    }

    if (!Util.isUnset(request.messageType)) {
      body["messageType"] = request.messageType;
    }

    if (!Util.isUnset(request.receiverDingtalkIds)) {
      body["receiverDingtalkIds"] = request.receiverDingtalkIds;
    }

    if (!Util.isUnset(request.receiverMobiles)) {
      body["receiverMobiles"] = request.receiverMobiles;
    }

    if (!Util.isUnset(request.receiverUnionIds)) {
      body["receiverUnionIds"] = request.receiverUnionIds;
    }

    if (!Util.isUnset(request.targetOpenConversationId)) {
      body["targetOpenConversationId"] = request.targetOpenConversationId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
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
    return $tea.cast<SendServiceGroupMessageResponse>(await this.doROARequest("SendServiceGroupMessage", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/messages/send`, "json", req, runtime), new SendServiceGroupMessageResponse({}));
  }

  async setRobotConfig(request: SetRobotConfigRequest): Promise<SetRobotConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetRobotConfigHeaders({ });
    return await this.setRobotConfigWithOptions(request, headers, runtime);
  }

  async setRobotConfigWithOptions(request: SetRobotConfigRequest, headers: SetRobotConfigHeaders, runtime: $Util.RuntimeOptions): Promise<SetRobotConfigResponse> {
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

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
    return $tea.cast<SetRobotConfigResponse>(await this.doROARequest("SetRobotConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/groups/configs/set`, "json", req, runtime), new SetRobotConfigResponse({}));
  }

  async takeTicket(request: TakeTicketRequest): Promise<TakeTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TakeTicketHeaders({ });
    return await this.takeTicketWithOptions(request, headers, runtime);
  }

  async takeTicketWithOptions(request: TakeTicketRequest, headers: TakeTicketHeaders, runtime: $Util.RuntimeOptions): Promise<TakeTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.takerUnionId)) {
      body["takerUnionId"] = request.takerUnionId;
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
    return $tea.cast<TakeTicketResponse>(await this.doROARequest("TakeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/apply`, "none", req, runtime), new TakeTicketResponse({}));
  }

  async topicStatistics(request: TopicStatisticsRequest): Promise<TopicStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TopicStatisticsHeaders({ });
    return await this.topicStatisticsWithOptions(request, headers, runtime);
  }

  async topicStatisticsWithOptions(request: TopicStatisticsRequest, headers: TopicStatisticsHeaders, runtime: $Util.RuntimeOptions): Promise<TopicStatisticsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxDt)) {
      query["maxDt"] = request.maxDt;
    }

    if (!Util.isUnset(request.minDt)) {
      query["minDt"] = request.minDt;
    }

    if (!Util.isUnset(request.openConversationIds)) {
      query["openConversationIds"] = request.openConversationIds;
    }

    if (!Util.isUnset(request.openTeamId)) {
      query["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.searchContent)) {
      query["searchContent"] = request.searchContent;
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
    return $tea.cast<TopicStatisticsResponse>(await this.doROARequest("TopicStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", `/v1.0/serviceGroup/voices/topics/statistics`, "json", req, runtime), new TopicStatisticsResponse({}));
  }

  async transferTicket(request: TransferTicketRequest): Promise<TransferTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransferTicketHeaders({ });
    return await this.transferTicketWithOptions(request, headers, runtime);
  }

  async transferTicketWithOptions(request: TransferTicketRequest, headers: TransferTicketHeaders, runtime: $Util.RuntimeOptions): Promise<TransferTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset($tea.toMap(request.notify))) {
      body["notify"] = request.notify;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset(request.processorUnionIds)) {
      body["processorUnionIds"] = request.processorUnionIds;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<TransferTicketResponse>(await this.doROARequest("TransferTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/transfer`, "none", req, runtime), new TransferTicketResponse({}));
  }

  async updateGroupTag(request: UpdateGroupTagRequest): Promise<UpdateGroupTagResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupTagHeaders({ });
    return await this.updateGroupTagWithOptions(request, headers, runtime);
  }

  async updateGroupTagWithOptions(request: UpdateGroupTagRequest, headers: UpdateGroupTagHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupTagResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateGroupTagResponse>(await this.doROARequest("UpdateGroupTag", "serviceGroup_1.0", "HTTP", "PUT", "AK", `/v1.0/serviceGroup/tags`, "none", req, runtime), new UpdateGroupTagResponse({}));
  }

  async updateInstance(request: UpdateInstanceRequest): Promise<UpdateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceHeaders({ });
    return await this.updateInstanceWithOptions(request, headers, runtime);
  }

  async updateInstanceWithOptions(request: UpdateInstanceRequest, headers: UpdateInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.externalBizId)) {
      body["externalBizId"] = request.externalBizId;
    }

    if (!Util.isUnset(request.formCode)) {
      body["formCode"] = request.formCode;
    }

    if (!Util.isUnset(request.formDataList)) {
      body["formDataList"] = request.formDataList;
    }

    if (!Util.isUnset(request.openDataInstanceId)) {
      body["openDataInstanceId"] = request.openDataInstanceId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset(request.ownerUnionId)) {
      body["ownerUnionId"] = request.ownerUnionId;
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
    return $tea.cast<UpdateInstanceResponse>(await this.doROARequest("UpdateInstance", "serviceGroup_1.0", "HTTP", "PUT", "AK", `/v1.0/serviceGroup/customForms/instances`, "json", req, runtime), new UpdateInstanceResponse({}));
  }

  async updateTicket(request: UpdateTicketRequest): Promise<UpdateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTicketHeaders({ });
    return await this.updateTicketWithOptions(request, headers, runtime);
  }

  async updateTicketWithOptions(request: UpdateTicketRequest, headers: UpdateTicketHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.openTicketId)) {
      body["openTicketId"] = request.openTicketId;
    }

    if (!Util.isUnset(request.processorUnionId)) {
      body["processorUnionId"] = request.processorUnionId;
    }

    if (!Util.isUnset($tea.toMap(request.ticketMemo))) {
      body["ticketMemo"] = request.ticketMemo;
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
    return $tea.cast<UpdateTicketResponse>(await this.doROARequest("UpdateTicket", "serviceGroup_1.0", "HTTP", "PUT", "AK", `/v1.0/serviceGroup/tickets`, "none", req, runtime), new UpdateTicketResponse({}));
  }

  async upgradeCloudGroup(request: UpgradeCloudGroupRequest): Promise<UpgradeCloudGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeCloudGroupHeaders({ });
    return await this.upgradeCloudGroupWithOptions(request, headers, runtime);
  }

  async upgradeCloudGroupWithOptions(request: UpgradeCloudGroupRequest, headers: UpgradeCloudGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpgradeCloudGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.ccsInstanceId)) {
      body["ccsInstanceId"] = request.ccsInstanceId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

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
    return $tea.cast<UpgradeCloudGroupResponse>(await this.doROARequest("UpgradeCloudGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/cloudGroups/upgrade`, "none", req, runtime), new UpgradeCloudGroupResponse({}));
  }

  async upgradeNormalGroup(request: UpgradeNormalGroupRequest): Promise<UpgradeNormalGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeNormalGroupHeaders({ });
    return await this.upgradeNormalGroupWithOptions(request, headers, runtime);
  }

  async upgradeNormalGroupWithOptions(request: UpgradeNormalGroupRequest, headers: UpgradeNormalGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UpgradeNormalGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openGroupSetId)) {
      body["openGroupSetId"] = request.openGroupSetId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

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
    return $tea.cast<UpgradeNormalGroupResponse>(await this.doROARequest("UpgradeNormalGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/normalGroups/upgrade`, "none", req, runtime), new UpgradeNormalGroupResponse({}));
  }

  async urgeTicket(request: UrgeTicketRequest): Promise<UrgeTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UrgeTicketHeaders({ });
    return await this.urgeTicketWithOptions(request, headers, runtime);
  }

  async urgeTicketWithOptions(request: UrgeTicketRequest, headers: UrgeTicketHeaders, runtime: $Util.RuntimeOptions): Promise<UrgeTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    return $tea.cast<UrgeTicketResponse>(await this.doROARequest("UrgeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", `/v1.0/serviceGroup/tickets/urge`, "none", req, runtime), new UrgeTicketResponse({}));
  }

}
