// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddContactMemberToGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactMemberToGroupRequest extends $tea.Model {
  /**
   * @example
   * 不裂变：STANDARD；裂变：FISSION
   */
  fissionType?: string;
  /**
   * @example
   * 888
   */
  memberUnionId?: string;
  /**
   * @example
   * 1
   */
  memberUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid***
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888
   */
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      fissionType: 'fissionType',
      memberUnionId: 'memberUnionId',
      memberUserId: 'memberUserId',
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fissionType: 'string',
      memberUnionId: 'string',
      memberUserId: 'string',
      openConversationId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddContactMemberToGroupResponseBody extends $tea.Model {
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

export class AddContactMemberToGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddContactMemberToGroupResponseBody;
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
      body: AddContactMemberToGroupResponseBody,
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
  attachmentList?: AddKnowledgeRequestAttachmentList[];
  /**
   * @example
   * 测试内容
   */
  content?: string;
  effectTimeend?: number;
  effectTimestart?: number;
  extTitle?: string;
  keyword?: string;
  /**
   * @example
   * xuvw1245
   */
  libraryKey?: string;
  /**
   * @example
   * http://www.test.com/xxxxx
   */
  linkUrl?: string;
  /**
   * @example
   * Jxi12wo3qxoa
   */
  openTeamId?: string;
  questionIds?: number[];
  /**
   * @example
   * CCM
   */
  source?: string;
  /**
   * @example
   * CCM-123
   */
  sourcePrimaryKey?: string;
  /**
   * @example
   * 测试
   */
  title?: string;
  /**
   * @example
   * CONDITION
   */
  type?: string;
  /**
   * @example
   * V0193859102
   */
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
  /**
   * @example
   * J23suw1irs
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddKnowledgeResponseBody;
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
  /**
   * @example
   * 测试库描述
   */
  description?: string;
  openTeamIds?: string[];
  /**
   * @example
   * CCM
   */
  source?: string;
  /**
   * @example
   * CCM-123
   */
  sourcePrimaryKey?: string;
  /**
   * @example
   * 测试库
   */
  title?: string;
  /**
   * @example
   * EXTERNAL
   */
  type?: string;
  /**
   * @example
   * manager123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddLibraryResponseBody;
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
      body: AddLibraryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMemberToServiceGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMemberToServiceGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxxxx==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jciwnfw
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openTeamId: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddMemberToServiceGroupResponseBody extends $tea.Model {
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

export class AddMemberToServiceGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddMemberToServiceGroupResponseBody;
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
      body: AddMemberToServiceGroupResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5555
   */
  libraryId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jxi12wo3qxoa
   */
  openTeamId?: string;
  /**
   * @example
   * 0
   */
  parentId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试类目
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0159003451667222
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉三多
   */
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
  /**
   * @example
   * 2
   */
  result?: AddOpenCategoryResponseBodyResult;
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddOpenCategoryResponseBody;
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
  /**
   * @example
   * 1
   */
  attachments?: AddOpenKnowledgeRequestAttachments[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 44555
   */
  categoryId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 这是服务群的介绍
   */
  content?: string;
  /**
   * @example
   * 2100-01-01 23:59:59
   */
  effectTimeend?: string;
  /**
   * @example
   * 1980-01-01 00:00:00
   */
  effectTimestart?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 这是问法1,这是问法2
   */
  extTitle?: string;
  /**
   * @example
   * 服务群,智能场景群
   */
  keyword?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  libraryId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jxi12wo3qxoa
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XMD
   */
  source?: string;
  /**
   * @example
   * 服务群,智能场景群
   */
  tags?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 服务群是什么
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * EXTERNAL
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0159003451667222
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉三多
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 22
   */
  result?: AddOpenKnowledgeResponseBodyResult;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddOpenKnowledgeResponseBody;
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
  /**
   * @example
   * 这个是业务知识库
   * 
   * **if can be null:**
   * true
   */
  description?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jxi12wo3qxoa
   * 
   * **if can be null:**
   * false
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XMD
   */
  source?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试库
   */
  title?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * EXTERNAL
   */
  type?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0159003451667222
   */
  userId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉三多
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  result?: AddOpenLibraryResponseBodyResult;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddOpenLibraryResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a8iS4X94TgtgiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hNiPO2OVktNMiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  bindingGroupBizIds?: BatchBindingGroupBizIdsRequestBindingGroupBizIds[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jciwnfw
   */
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
  /**
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

export class BatchBindingGroupBizIdsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchBindingGroupBizIdsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  configKeys?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchGetGroupSetConfigResponseBody;
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
      body: BatchGetGroupSetConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryCustomerSendTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryCustomerSendTaskRequest extends $tea.Model {
  /**
   * @example
   * 2023-06-02 00:00:00
   */
  gmtCreateEnd?: string;
  /**
   * @example
   * 2023-06-01 00:00:00
   */
  gmtCreateStart?: string;
  /**
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  needRichStatistics?: boolean;
  /**
   * @example
   * 1
   */
  nextToken?: string;
  openBatchTaskIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
  openTeamId?: string;
  /**
   * @example
   * 哈哈哈
   */
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreateEnd: 'gmtCreateEnd',
      gmtCreateStart: 'gmtCreateStart',
      maxResults: 'maxResults',
      needRichStatistics: 'needRichStatistics',
      nextToken: 'nextToken',
      openBatchTaskIds: 'openBatchTaskIds',
      openTeamId: 'openTeamId',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreateEnd: 'string',
      gmtCreateStart: 'string',
      maxResults: 'number',
      needRichStatistics: 'boolean',
      nextToken: 'string',
      openBatchTaskIds: { 'type': 'array', 'itemType': 'string' },
      openTeamId: 'string',
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryCustomerSendTaskResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  nextToken?: string;
  records?: BatchQueryCustomerSendTaskResponseBodyRecords[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
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
      records: { 'type': 'array', 'itemType': BatchQueryCustomerSendTaskResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryCustomerSendTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchQueryCustomerSendTaskResponseBody;
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
      body: BatchQueryCustomerSendTaskResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @example
   * ***
   */
  nextToken?: string;
  /**
   * @example
   * cid***
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888
   */
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openConversationId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryGroupMemberResponseBody extends $tea.Model {
  hasMore?: boolean;
  nextToken?: string;
  openConversationId?: string;
  records?: BatchQueryGroupMemberResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      openConversationId: 'string',
      records: { 'type': 'array', 'itemType': BatchQueryGroupMemberResponseBodyRecords },
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
  /**
   * @example
   * false
   */
  getReadCount?: boolean;
  /**
   * @example
   * 2022-04-02 00:00:00
   */
  gmtCreateEnd?: string;
  /**
   * @example
   * 2022-04-01 00:00:00
   */
  gmtCreateStart?: string;
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 首页传递空
   */
  nextToken?: string;
  /**
   * @example
   * fwPuycdHiiI
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jciwnfw
   */
  openTeamId?: string;
  /**
   * @example
   * 群发任务双11
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchQuerySendMessageTaskResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * btkoYsadwyQiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * [{"robotCode":"123ITJovyMHtmi216233798228941001","robotName":"服务小钉"}]
   */
  robotConfig?: string;
  templateDesc?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  templateId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  templateName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0普通群模板，1内部群模板
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BoundTemplateToTeamResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a8iS4X94TgtgiE
   */
  openTicketId?: string;
  /**
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  maxDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  categoryStatisticsRecords?: CategoryStatisticsResponseBodyCategoryStatisticsRecords[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CategoryStatisticsResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CloseConversationResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CloseHumanSessionResponseBody;
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
  /**
   * @example
   * eWaJSqDcLsoiE
   */
  openTeamId?: string;
  serverName?: string;
  serverTips?: string;
  /**
   * @example
   * 对应外部渠道的会话ID
   */
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
  /**
   * @example
   * true
   */
  result?: boolean;
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConversationCreatedNotifyResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConversationTransferBeginNotifyResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ConversationTransferCompleteNotifyResponseBody;
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
  /**
   * @example
   * PID123cjj2
   */
  groupBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试服务群
   */
  groupName?: string;
  groupTagNames?: string[];
  memberStaffIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jciwnfw
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jciwnfw
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * manager123
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * http://qr.dingtalk.com/xxxxx
   */
  groupUrl?: string;
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
  /**
   * @example
   * dingadc88253b4d581bd35c2f4657eb6378f
   */
  corpId?: string;
  /**
   * @example
   * fsfsfadfasfdasdfsaf
   */
  dingGroupId?: string;
  dingSuiteKey?: string;
  dingTokenGrantType?: number;
  /**
   * @example
   * 57675657
   */
  dingUserId?: string;
  /**
   * @example
   * 张三
   */
  dingUserName?: string;
  /**
   * @example
   * {"isServerInitiative":"true"}
   */
  extValues?: string;
  openTeamId?: string;
  /**
   * @example
   * 3434
   */
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
  /**
   * @example
   * 500
   */
  dingOpenErrcode?: number;
  /**
   * @example
   * SYSTEM_ERROR
   */
  errorMsg?: string;
  /**
   * @example
   * true
   */
  result?: string;
  /**
   * @example
   * true
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  groupSetName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  groupTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateGroupSetResponseBody;
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
  /**
   * @example
   * DOU_YIN
   */
  channel?: string;
  /**
   * @example
   * 888888
   */
  externalBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DING_CUSTOMER
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"node_1111":"hahha"}
   */
  formDataList?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 88444***
   */
  openTeamId?: string;
  /**
   * @example
   * 88855
   */
  operatorUnionId?: string;
  /**
   * @example
   * 88855
   */
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
  /**
   * @example
   * 8888***
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateInstanceResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  creatorDingUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateTeamResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
  creatorUnionId?: string;
  /**
   * @example
   * [{\"identifier\":\"input1\",\"value\":\"123\"}]
   */
  customFields?: string;
  notify?: CreateTicketRequestNotify;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * bLkvfXKiSngQiE
   */
  openTemplateBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processorUnionIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SG
   */
  scene?: string;
  sceneContext?: CreateTicketRequestSceneContext;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 工单标题
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateTicketResponseBody;
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
      body: CreateTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomerSendMsgTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomerSendMsgTaskRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageContent?: CustomerSendMsgTaskRequestMessageContent;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  openTeamId?: string;
  queryCustomer?: CustomerSendMsgTaskRequestQueryCustomer;
  sendConfig?: CustomerSendMsgTaskRequestSendConfig;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 任务名称
   */
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      messageContent: 'messageContent',
      openTeamId: 'openTeamId',
      queryCustomer: 'queryCustomer',
      sendConfig: 'sendConfig',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageContent: CustomerSendMsgTaskRequestMessageContent,
      openTeamId: 'string',
      queryCustomer: CustomerSendMsgTaskRequestQueryCustomer,
      sendConfig: CustomerSendMsgTaskRequestSendConfig,
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomerSendMsgTaskResponseBody extends $tea.Model {
  /**
   * @example
   * 88888
   */
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

export class CustomerSendMsgTaskResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CustomerSendMsgTaskResponseBody;
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
      body: CustomerSendMsgTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGroupMembersFromGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGroupMembersFromGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * GROUP：从群中删除；GROUP_SET：从群组中删除
   */
  deleteGroupType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  memberUnionId?: string;
  /**
   * @example
   * cid**
   */
  openConversationId?: string;
  /**
   * @example
   * 8888
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      deleteGroupType: 'deleteGroupType',
      memberUnionId: 'memberUnionId',
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deleteGroupType: 'string',
      memberUnionId: 'string',
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGroupMembersFromGroupResponseBody extends $tea.Model {
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

export class DeleteGroupMembersFromGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteGroupMembersFromGroupResponseBody;
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
      body: DeleteGroupMembersFromGroupResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DING_CUSTOMER
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888***
   */
  openDataInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888**
   */
  openTeamId?: string;
  /**
   * @example
   * 8889999
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteInstanceResponseBody;
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
  /**
   * @example
   * xuvw1245
   */
  libraryKey?: string;
  /**
   * @example
   * Js1i0w3k
   */
  openTeamId?: string;
  /**
   * @example
   * CCM
   */
  source?: string;
  /**
   * @example
   * CCM-123
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteKnowledgeResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  maxDt?: string;
  /**
   * @example
   * 0.8
   */
  maxEmotion?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * @example
   * 0
   */
  minEmotion?: number;
  /**
   * @example
   * cidXX,cidYY
   */
  openConversationIds?: string;
  /**
   * @example
   * ksdfosd
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: EmotionStatisticsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a8iS4X94TgtgiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
  processorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAuthTokenResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DING_CUSTOMER
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openDataInstanceIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888***
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInstancesByIdsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetNegativeWordCloudResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  fetchMode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  key?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetOssTempUrlResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * TICKET_IMAGE
   */
  bizType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * wahah.txt
   */
  fileName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10000
   */
  fileSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetStoragePolicyResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetTicketResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetWordCloudResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  maxDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  groupCount?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  groupTrend?: GroupStatisticsResponseBodyGroupTrend[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  increaseGroupCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.1
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GroupStatisticsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  maxDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: IntentionCategoryStatisticsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  maxDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  intentionStatisticsRecords?: IntentionStatisticsResponseBodyIntentionStatisticsRecords[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: IntentionStatisticsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListTicketOperateRecordResponseBody;
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListUserTeamsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxxxx==
   */
  openConversationId?: string;
  /**
   * @example
   * KxisoOk
   * 
   * **if can be null:**
   * true
   */
  openTeamId?: string;
  /**
   * @example
   * 5
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryActiveUsersResponseBody;
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
      body: QueryActiveUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupContactHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupContactRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  minResult?: number;
  /**
   * @example
   * 8888
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid888
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  searchFields?: string;
  static names(): { [key: string]: string } {
    return {
      minResult: 'minResult',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      openTeamId: 'openTeamId',
      searchFields: 'searchFields',
    };
  }

  static types(): { [key: string]: any } {
    return {
      minResult: 'number',
      nextToken: 'string',
      openConversationId: 'string',
      openTeamId: 'string',
      searchFields: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupContactResponseBody extends $tea.Model {
  /**
   * @example
   * token****
   */
  nextToken?: string;
  /**
   * @example
   * cid****
   */
  openConversationId?: string;
  records?: QueryCrmGroupContactResponseBodyRecords[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      records: 'records',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      openConversationId: 'string',
      records: { 'type': 'array', 'itemType': QueryCrmGroupContactResponseBodyRecords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCrmGroupContactResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCrmGroupContactResponseBody;
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
      body: QueryCrmGroupContactResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCustomerCardResponseBody;
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
      body: QueryCustomerCardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerTaskUserDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerTaskUserDetailRequest extends $tea.Model {
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 8888
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  openBatchTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  openTeamId?: string;
  receiverUnionIds?: string[];
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openBatchTaskId: 'openBatchTaskId',
      openTeamId: 'openTeamId',
      receiverUnionIds: 'receiverUnionIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openBatchTaskId: 'string',
      openTeamId: 'string',
      receiverUnionIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerTaskUserDetailResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nextToken?: string;
  records?: QueryCustomerTaskUserDetailResponseBodyRecords[];
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
      records: { 'type': 'array', 'itemType': QueryCustomerTaskUserDetailResponseBodyRecords },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerTaskUserDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCustomerTaskUserDetailResponseBody;
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
      body: QueryCustomerTaskUserDetailResponseBody,
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
  /**
   * @example
   * 101813123123
   */
  bizId?: string;
  /**
   * @example
   * cidxxxxxx==
   */
  openConversationId?: string;
  /**
   * @example
   * KxisoOk
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 234
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉专属服务群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * https://qr.dingtalk.com/xxxxxxx
   */
  groupUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxxx==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xjfjdsiw
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xkjhfker
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * jikwrjcowa
   */
  robotCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 服务小钉
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupResponseBody;
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
  /**
   * @example
   * cidxxxxxx==
   */
  openConversationId?: string;
  /**
   * @example
   * KxisoOk
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGroupSetResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DING_CUSTOMER
   */
  formCode?: string;
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 0
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888**
   */
  openTeamId?: string;
  /**
   * @example
   * [     {         "fieldCode":"contact_name",         "fieldOperatorType":"like",         "value":"测试api"     } ]
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  maxResults?: number;
  nextToken?: string;
  records?: QueryInstancesByMultiConditionsResponseBodyRecords[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryInstancesByMultiConditionsResponseBody;
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
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 1
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jci333
   */
  openBatchTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jciwnfw
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySendMsgTaskStatisticsResponseBody;
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
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 1
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * J22222
   */
  openBatchTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid1111
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Jciwnfw
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QuerySendMsgTaskStatisticsDetailResponseBody;
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
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * CXiw
   */
  nextToken?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxxxx==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * msgxxxxxx==
   */
  openMsgTaskId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * EifWwis
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryServiceGroupMessageReadStatusResponseBody;
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
  /**
   * @example
   * 5
   */
  estimateWaitMin?: number;
  /**
   * @example
   * eWaJSqDcLsoiE
   */
  openTeamId?: string;
  /**
   * @example
   * 11
   */
  queuePlace?: number;
  /**
   * @example
   * 3333333333
   */
  serviceToken?: string;
  /**
   * @example
   * SourceTypeEnum
   */
  targetChannel?: string;
  /**
   * @example
   * 你好，欢迎来到这里
   */
  tips?: string;
  /**
   * @example
   * eeeeeeeeerrrrr
   */
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
  /**
   * @example
   * true
   */
  result?: boolean;
  /**
   * @example
   * true
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueueNotifyResponseBody;
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
      body: QueueNotifyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveContactFromOrgHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveContactFromOrgRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 88888
   */
  contactUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      contactUnionId: 'contactUnionId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactUnionId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RemoveContactFromOrgResponseBody extends $tea.Model {
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

export class RemoveContactFromOrgResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RemoveContactFromOrgResponseBody;
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
      body: RemoveContactFromOrgResponseBody,
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
  /**
   * @example
   * true
   */
  hasLogin?: boolean;
  /**
   * @example
   * true
   */
  hasOpenConv?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220102
   */
  maxDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iSoqrhLQDtK
   */
  openTeamId?: string;
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
   * 20
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  currentPage?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  records?: ReportCustomerDetailResponseBodyRecords[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReportCustomerDetailResponseBody;
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
  /**
   * **if can be null:**
   * true
   */
  groupOwnerUserIds?: string[];
  /**
   * **if can be null:**
   * true
   */
  groupTags?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220102
   */
  maxDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * **if can be null:**
   * true
   */
  openConversationIds?: string[];
  /**
   * @example
   * iFoqrhLQDtK
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iSoqrhLQDtK
   */
  openTeamId?: string;
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
   * 20
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  currentPage?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  records?: ReportCustomerStatisticsResponseBodyRecords[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReportCustomerStatisticsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
  creatorUnionId?: string;
  /**
   * @example
   * [{\"identifier\":\"input1\",\"value\":\"123\"}]
   */
  customFields?: string;
  notify?: ResubmitTicketRequestNotify;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * bLkvfXKiSngQiE
   */
  openTemplateBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iPbrfXjdNjRoiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processorUnionIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * SG
   */
  scene?: string;
  sceneContext?: ResubmitTicketRequestSceneContext;
  ticketMemo?: ResubmitTicketRequestTicketMemo;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 工单标题
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a8iS4X94TgtgiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * msgU87r5gnMP43JTDAZg/ETyQ==
   */
  openMsgId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iSoqrhLQDtK
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RobotMessageRecallResponseBody;
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
      body: RobotMessageRecallResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormInstanceHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormInstanceRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {}
   */
  formDataList?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 8888
   */
  openTeamId?: string;
  /**
   * @example
   * 88888
   */
  operatorUnionId?: string;
  /**
   * @example
   * 8888
   */
  ownerUnionId?: string;
  static names(): { [key: string]: string } {
    return {
      formDataList: 'formDataList',
      openTeamId: 'openTeamId',
      operatorUnionId: 'operatorUnionId',
      ownerUnionId: 'ownerUnionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
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

export class SaveFormInstanceResponseBody extends $tea.Model {
  /**
   * @example
   * 99999
   */
  openContactId?: string;
  /**
   * @example
   * 88888
   */
  openCustomerId?: string;
  static names(): { [key: string]: string } {
    return {
      openContactId: 'openContactId',
      openCustomerId: 'openCustomerId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openContactId: 'string',
      openCustomerId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveFormInstanceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SaveFormInstanceResponseBody;
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
      body: SaveFormInstanceResponseBody,
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
  /**
   * @example
   * 钉钉专属服务群
   */
  groupName?: string;
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * CXiw
   */
  nextToken?: string;
  /**
   * @example
   * cidxxxx==
   */
  openConversationId?: string;
  /**
   * @example
   * sjfuwid
   */
  openGroupSetId?: string;
  /**
   * @example
   * jfuwida
   */
  openTeamId?: string;
  /**
   * @example
   * 目前支持PAGE 和 SCROLL，默认PAGE类型
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SearchGroupResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  messageContent?: SendMsgByTaskRequestMessageContent;
  /**
   * @remarks
   * This parameter is required.
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  queryGroup?: SendMsgByTaskRequestQueryGroup;
  /**
   * @remarks
   * This parameter is required.
   */
  sendConfig?: SendMsgByTaskRequestSendConfig;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendMsgByTaskResponseBody;
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
      body: SendMsgByTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskSupportInviteJoinOrgHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskSupportInviteJoinOrgRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  messageContent?: SendMsgByTaskSupportInviteJoinOrgRequestMessageContent;
  /**
   * @remarks
   * This parameter is required.
   */
  mobilePhones?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  needUrlTrack?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 88888
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 发送渠道      * 工作通知：WORK_NOTICE      * 机器人：SINGLE_ROBOT
   */
  sendChannel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 群发任务
   */
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      messageContent: 'messageContent',
      mobilePhones: 'mobilePhones',
      needUrlTrack: 'needUrlTrack',
      openTeamId: 'openTeamId',
      sendChannel: 'sendChannel',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageContent: SendMsgByTaskSupportInviteJoinOrgRequestMessageContent,
      mobilePhones: { 'type': 'array', 'itemType': 'string' },
      needUrlTrack: 'boolean',
      openTeamId: 'string',
      sendChannel: 'string',
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMsgByTaskSupportInviteJoinOrgResponseBody extends $tea.Model {
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

export class SendMsgByTaskSupportInviteJoinOrgResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendMsgByTaskSupportInviteJoinOrgResponseBody;
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
      body: SendMsgByTaskSupportInviteJoinOrgResponseBody,
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
  /**
   * @example
   * 0
   */
  btnOrientation?: string;
  btns?: SendServiceGroupMessageRequestBtns[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 你有新的任务待审批
   */
  content?: string;
  /**
   * @example
   * false
   */
  hasContentLinks?: boolean;
  /**
   * @example
   * false
   */
  isAtAll?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * MARKDOWN
   */
  messageType?: string;
  receiverDingtalkIds?: string[];
  receiverMobiles?: string[];
  receiverUnionIds?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxxx==
   */
  targetOpenConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 服务提醒
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * msgxxxxxx==
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendServiceGroupMessageResponseBody;
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
  /**
   * @example
   * 0
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SetRobotConfigResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * a8iS4X94TgtgiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  maxDt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  minDt?: string;
  /**
   * @example
   * cidXX,cidYY
   */
  openConversationIds?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * KxisoOk
   */
  openTeamId?: string;
  /**
   * @example
   * 工单
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: TopicStatisticsResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iPFWCyMGWPiiIiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
  processorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class UpdateGroupSetHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupSetRequest extends $tea.Model {
  /**
   * @example
   * cidkeQXxEC9VaGQ2M6nTlhNWQ==
   */
  openConversationId?: string;
  /**
   * @example
   * iPnLAZk8oV4AiE
   */
  openGroupSetId?: string;
  /**
   * @example
   * u9iSGISL3bqIiE
   */
  openTeamId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      openGroupSetId: 'openGroupSetId',
      openTeamId: 'openTeamId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      openGroupSetId: 'string',
      openTeamId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateGroupSetResponseBody extends $tea.Model {
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

export class UpdateGroupSetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateGroupSetResponseBody;
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
      body: UpdateGroupSetResponseBody,
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
  /**
   * @remarks
   * This parameter is required.
   */
  openConversationIds?: string[];
  tagNames?: string[];
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * hhdhg
   */
  externalBizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * DING_CUSTOMER
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"node_888":"hhhh"}
   */
  formDataList?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888555
   */
  openDataInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 888***
   */
  openTeamId?: string;
  /**
   * @example
   * 8888
   */
  operatorUnionId?: string;
  /**
   * @example
   * 88888
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInstanceResponseBody;
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
  /**
   * @example
   * [{\"identifier\":\"input1\",\"value\":\"openAPI更新了值\"}]
   */
  customFields?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * eKWh3GBwsKEiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iPFWCyMGWPiiIiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * p8VdSjm884SvQ6l05nCe5wiEiE
   */
  processorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sdfdfser
   */
  ccsInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidrQnTVXH/X+ERaVqGaH+asw==
   */
  openConversationId?: string;
  /**
   * @example
   * oPnDlfVYYIUia
   */
  openGroupSetId?: string;
  /**
   * @example
   * btkoYsadwyQiE
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * bLkvfXKiSngQiE
   */
  openTeamId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iPbrfXjdNjRoiE
   */
  openTicketId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Dq9hP8Sk2v6vQ6l05nCe5wiEiE
   */
  operatorUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class AddKnowledgeRequestAttachmentList extends $tea.Model {
  /**
   * @example
   * doc
   */
  mimeType?: string;
  path?: string;
  /**
   * @example
   * 655
   */
  size?: number;
  /**
   * @example
   * pdf
   */
  suffix?: string;
  /**
   * @example
   * 测试附件
   */
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
  /**
   * @example
   * 111
   */
  id?: number;
  /**
   * @example
   * title不能为空
   */
  message?: string;
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * PDF
   */
  mimeType?: string;
  /**
   * @example
   * https://dtapp-pub.dingtalk.com/dingtalkdesktop/test.pdf
   */
  path?: string;
  /**
   * @example
   * 444556
   */
  size?: number;
  /**
   * @example
   * pdf
   */
  suffix?: string;
  /**
   * @example
   * 这是一个附件文档
   */
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
  /**
   * @example
   * 111
   */
  id?: number;
  /**
   * @example
   * 知识标问不能为空
   */
  message?: string;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 22
   */
  id?: number;
  message?: string;
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
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
  fileName?: string;
  /**
   * @example
   * wahaha.txt
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备注
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
  fileName?: string;
  /**
   * @example
   * wahaha.txt
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备注
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * hghhghghhg
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid123
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ROBOT_SWITCH
   */
  configKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
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

export class BatchQueryCustomerSendTaskResponseBodyRecords extends $tea.Model {
  /**
   * @example
   * 张三
   */
  createName?: string;
  /**
   * @example
   * 2023-07-14 10:00:00
   */
  createTimeStr?: string;
  /**
   * @example
   * 88888
   */
  createUnionId?: string;
  /**
   * @example
   * 88888
   */
  openBatchTaskId?: string;
  /**
   * @example
   * 90
   */
  readCustomerInc?: number;
  /**
   * @example
   * 100
   */
  readUserInc?: number;
  /**
   * @example
   * 100
   */
  sendCustomerInc?: number;
  /**
   * @example
   * UNFINISH 未完成 FINISHED 已发送 CANCELED 已取消 CREATE_TASK_FAILED 创建任务失败  SENDING 发送中
   */
  sendMessageStatus?: string;
  /**
   * @example
   * 2023-07-14 11:00:00
   */
  sendTaskTimeStr?: string;
  /**
   * @example
   * 200
   */
  sendUserInc?: number;
  /**
   * @example
   * 任务名称
   */
  taskName?: string;
  static names(): { [key: string]: string } {
    return {
      createName: 'createName',
      createTimeStr: 'createTimeStr',
      createUnionId: 'createUnionId',
      openBatchTaskId: 'openBatchTaskId',
      readCustomerInc: 'readCustomerInc',
      readUserInc: 'readUserInc',
      sendCustomerInc: 'sendCustomerInc',
      sendMessageStatus: 'sendMessageStatus',
      sendTaskTimeStr: 'sendTaskTimeStr',
      sendUserInc: 'sendUserInc',
      taskName: 'taskName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createName: 'string',
      createTimeStr: 'string',
      createUnionId: 'string',
      openBatchTaskId: 'string',
      readCustomerInc: 'number',
      readUserInc: 'number',
      sendCustomerInc: 'number',
      sendMessageStatus: 'string',
      sendTaskTimeStr: 'string',
      sendUserInc: 'number',
      taskName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryGroupMemberResponseBodyRecords extends $tea.Model {
  innerStaff?: boolean;
  nickName?: string;
  owner?: boolean;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      innerStaff: 'innerStaff',
      nickName: 'nickName',
      owner: 'owner',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      innerStaff: 'boolean',
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

export class BatchQuerySendMessageTaskResponseBodyRecords extends $tea.Model {
  createName?: string;
  createTimeStr?: string;
  createUnionId?: string;
  openBatchTaskId?: string;
  readGroupInc?: number;
  sendGroupInc?: number;
  sendMessageStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * wahaha.txt
   */
  fileName?: string;
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
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
  /**
   * @example
   * 备注
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 9
   */
  lastCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 工单类
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  dt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 工单类
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * true
   */
  anchor?: boolean;
  /**
   * @example
   * msgsbY4BzTCNX0/ClUwoTTs7w==
   */
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
  /**
   * @example
   * cidZBSNlUi/Jq9x76PAXUCrAA==
   */
  openConversationId?: string;
  relevantorUnionIds?: string[];
  /**
   * @example
   * a0ba57d5d29a48b51d0eca48da6b1d09
   */
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

export class CustomerSendMsgTaskRequestMessageContentBtns extends $tea.Model {
  /**
   * @example
   * http://www.baidu.com
   */
  actionURL?: string;
  /**
   * @example
   * 百度
   */
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

export class CustomerSendMsgTaskRequestMessageContent extends $tea.Model {
  btns?: CustomerSendMsgTaskRequestMessageContentBtns[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 内容
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ACTIONCAR：卡片消息
   */
  messageType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 标题
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      btns: 'btns',
      content: 'content',
      messageType: 'messageType',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      btns: { 'type': 'array', 'itemType': CustomerSendMsgTaskRequestMessageContentBtns },
      content: 'string',
      messageType: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomerSendMsgTaskRequestQueryCustomer extends $tea.Model {
  openContactIds?: string[];
  /**
   * @example
   * AIMED
   */
  queryType?: string;
  /**
   * @example
   * {}
   */
  searchContactConditions?: string;
  /**
   * @example
   * {}
   */
  searchCustomerConditions?: string;
  static names(): { [key: string]: string } {
    return {
      openContactIds: 'openContactIds',
      queryType: 'queryType',
      searchContactConditions: 'searchContactConditions',
      searchCustomerConditions: 'searchCustomerConditions',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openContactIds: { 'type': 'array', 'itemType': 'string' },
      queryType: 'string',
      searchContactConditions: 'string',
      searchCustomerConditions: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CustomerSendMsgTaskRequestSendConfigUrlTrackConfig extends $tea.Model {
  /**
   * @example
   * 百度
   */
  title?: string;
  /**
   * @example
   * 88888
   */
  trackId?: string;
  /**
   * @example
   * http://www.baidu.com
   */
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

export class CustomerSendMsgTaskRequestSendConfig extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  needUrlTrack?: boolean;
  /**
   * @example
   * 2023-06-01 00:00:00
   */
  sendTime?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * INSTANT
   */
  sendType?: string;
  urlTrackConfig?: CustomerSendMsgTaskRequestSendConfigUrlTrackConfig[];
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
      urlTrackConfig: { 'type': 'array', 'itemType': CustomerSendMsgTaskRequestSendConfigUrlTrackConfig },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EmotionStatisticsResponseBodyEmotionStatisticsRecords extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  dt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.3
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * wahaha.txt
   */
  fileName?: string;
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备注
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  modifiedUnionId?: string;
  openDataInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 销售
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 销售
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  askCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 工单类
   */
  categoryName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  dissatisfiedCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  errorCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  praiseCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 产品异常类
   */
  intention?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 9
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  count?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  dt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 产品异常类
   */
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
  /**
   * @example
   * Jxi12wo3qxoa
   */
  openTeamId?: string;
  /**
   * @example
   * 测试团队
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  actionIndexL14d?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  actionIndexL30d?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  actionIndexL7d?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  activeScore?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  nickName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  ranking?: number;
  /**
   * @remarks
   * This parameter is required.
   */
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

export class QueryCrmGroupContactResponseBodyRecords extends $tea.Model {
  /**
   * @example
   * {} ,具体字段取决于客户管理-字段管理-联系人字段设置
   */
  contactData?: string;
  /**
   * @example
   * ahghgg
   */
  memberUnionId?: string;
  /**
   * @example
   * 张三
   */
  nickName?: string;
  /**
   * @example
   * 88888
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      contactData: 'contactData',
      memberUnionId: 'memberUnionId',
      nickName: 'nickName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactData: 'string',
      memberUnionId: 'string',
      nickName: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses extends $tea.Model {
  /**
   * @example
   * 2023-07-14 00:00:00
   */
  clickTime?: string;
  /**
   * @example
   * 88888
   */
  eventTrackId?: string;
  /**
   * @example
   * true
   */
  onClick?: boolean;
  /**
   * @example
   * 标题名称
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      clickTime: 'clickTime',
      eventTrackId: 'eventTrackId',
      onClick: 'onClick',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clickTime: 'string',
      eventTrackId: 'string',
      onClick: 'boolean',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCustomerTaskUserDetailResponseBodyRecords extends $tea.Model {
  /**
   * @example
   * 客户名称
   */
  customerNames?: string;
  /**
   * @example
   * 11111
   */
  errorCode?: string;
  /**
   * @example
   * 错误信息
   */
  errorDetail?: string;
  eventTrackResponses?: QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses[];
  /**
   * @example
   * 8888
   */
  openBatchTaskId?: string;
  /**
   * @example
   * 1
   */
  readStatus?: number;
  /**
   * @example
   * 2023-07-14 00:00:00
   */
  readTime?: string;
  /**
   * @example
   * 接收人姓名
   */
  receiverName?: string;
  /**
   * @example
   * 接收人ID
   */
  receiverUnionId?: string;
  /**
   * @example
   * 2023-07-14 00:00:00
   */
  sendTime?: string;
  /**
   * @example
   * UNSEND未发；SEND_SUCCESS成功；SEND_FAILED失败；EXCEED_LIMIT被限流
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      customerNames: 'customerNames',
      errorCode: 'errorCode',
      errorDetail: 'errorDetail',
      eventTrackResponses: 'eventTrackResponses',
      openBatchTaskId: 'openBatchTaskId',
      readStatus: 'readStatus',
      readTime: 'readTime',
      receiverName: 'receiverName',
      receiverUnionId: 'receiverUnionId',
      sendTime: 'sendTime',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      customerNames: 'string',
      errorCode: 'string',
      errorDetail: 'string',
      eventTrackResponses: { 'type': 'array', 'itemType': QueryCustomerTaskUserDetailResponseBodyRecordsEventTrackResponses },
      openBatchTaskId: 'string',
      readStatus: 'number',
      readTime: 'string',
      receiverName: 'string',
      receiverUnionId: 'string',
      sendTime: 'string',
      status: 'string',
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
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  groupSetName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * gmt_create
   */
  fieldCode?: string;
  /**
   * @example
   * asc升序；desc降序
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  formCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtCreate?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  gmtModified?: string;
  modifiedUnionId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  openDataInstanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @example
   * 1
   */
  readStatus?: number;
  /**
   * @example
   * 2021-09-01 00:00:00
   */
  readTimeStr?: string;
  /**
   * @example
   * $:LWCP_v1:xxxx==
   */
  receiverDingTalkId?: string;
  /**
   * @example
   * 张三
   */
  receiverName?: string;
  /**
   * @example
   * Kxiwk2
   */
  receiverUnionId?: string;
  /**
   * @example
   * manager123
   */
  receiverUserId?: string;
  /**
   * @example
   * 2021-09-01 00:00:00
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  atRobotCnt?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 张三
   */
  customerName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasLogin?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasOpenConv?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  sendMsgCnt?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xcjlsdf
   */
  unionId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 56789
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  atRobotCnt?: number;
  /**
   * @example
   * bizXX
   */
  bizId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  customerCnt?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试群分组
   */
  groupSetName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  loginCnt?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  openConvCnt?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidXXX
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * iSoqrhLQDtK
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
  sendMsgCnt?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * msgsbY4BzTCNX0/ClUwoTTs7w==
   */
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
  /**
   * @example
   * cidZBSNlUi/Jq9x76PAXUCrAA==
   */
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
  /**
   * @example
   * wahaha.txt
   */
  fileName?: string;
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
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
  /**
   * @example
   * 备注
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * 备注
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 钉钉专属服务群
   */
  groupName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingtalk:xxx
   */
  groupUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidxxxxx==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xjfjdsiw
   */
  openGroupSetId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xkjhfker
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
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

export class SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns extends $tea.Model {
  /**
   * @example
   * http://www.baidu.com
   */
  actionURL?: string;
  /**
   * @example
   * 按钮标题
   */
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

export class SendMsgByTaskSupportInviteJoinOrgRequestMessageContent extends $tea.Model {
  btns?: SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 内容
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ACTIONCARD：卡片消息
   */
  messageType?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 标题内容
   */
  title?: string;
  static names(): { [key: string]: string } {
    return {
      btns: 'btns',
      content: 'content',
      messageType: 'messageType',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      btns: { 'type': 'array', 'itemType': SendMsgByTaskSupportInviteJoinOrgRequestMessageContentBtns },
      content: 'string',
      messageType: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendServiceGroupMessageRequestBtns extends $tea.Model {
  /**
   * @example
   * http://www.dingtalk.com
   */
  actionURL?: string;
  /**
   * @example
   * 测试按钮
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20220101
   */
  dt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  msgCount?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 3
   */
  participantsNum?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
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
  /**
   * @example
   * true
   */
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
  /**
   * @example
   * wahaha.txt
   */
  fileName?: string;
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
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
  /**
   * @example
   * 备注
   */
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
  /**
   * @example
   * wahaha.txt
   */
  fileName?: string;
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备注
   */
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
  /**
   * @example
   * wahaha.txt
   */
  fileName?: string;
  /**
   * @example
   * ticket/image/44708069/43003/e27204b382c04832aec4243e940a1367_1625831640499.txt
   */
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 备注
   */
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 添加联系人到群里
   * 
   * @param request - AddContactMemberToGroupRequest
   * @param headers - AddContactMemberToGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddContactMemberToGroupResponse
   */
  async addContactMemberToGroupWithOptions(request: AddContactMemberToGroupRequest, headers: AddContactMemberToGroupHeaders, runtime: $Util.RuntimeOptions): Promise<AddContactMemberToGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fissionType)) {
      body["fissionType"] = request.fissionType;
    }

    if (!Util.isUnset(request.memberUnionId)) {
      body["memberUnionId"] = request.memberUnionId;
    }

    if (!Util.isUnset(request.memberUserId)) {
      body["memberUserId"] = request.memberUserId;
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
    let params = new $OpenApi.Params({
      action: "AddContactMemberToGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/contacts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddContactMemberToGroupResponse>(await this.execute(params, req, runtime), new AddContactMemberToGroupResponse({}));
  }

  /**
   * 添加联系人到群里
   * 
   * @param request - AddContactMemberToGroupRequest
   * @returns AddContactMemberToGroupResponse
   */
  async addContactMemberToGroup(request: AddContactMemberToGroupRequest): Promise<AddContactMemberToGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddContactMemberToGroupHeaders({ });
    return await this.addContactMemberToGroupWithOptions(request, headers, runtime);
  }

  /**
   * 添加知识点
   * 
   * @param request - AddKnowledgeRequest
   * @param headers - AddKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddKnowledgeResponse
   */
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
    let params = new $OpenApi.Params({
      action: "AddKnowledge",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/knowledges`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddKnowledgeResponse>(await this.execute(params, req, runtime), new AddKnowledgeResponse({}));
  }

  /**
   * 添加知识点
   * 
   * @param request - AddKnowledgeRequest
   * @returns AddKnowledgeResponse
   */
  async addKnowledge(request: AddKnowledgeRequest): Promise<AddKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddKnowledgeHeaders({ });
    return await this.addKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * 添加服务群知识库
   * 
   * @param request - AddLibraryRequest
   * @param headers - AddLibraryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddLibraryResponse
   */
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
    let params = new $OpenApi.Params({
      action: "AddLibrary",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/librarys`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddLibraryResponse>(await this.execute(params, req, runtime), new AddLibraryResponse({}));
  }

  /**
   * 添加服务群知识库
   * 
   * @param request - AddLibraryRequest
   * @returns AddLibraryResponse
   */
  async addLibrary(request: AddLibraryRequest): Promise<AddLibraryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddLibraryHeaders({ });
    return await this.addLibraryWithOptions(request, headers, runtime);
  }

  /**
   * 添加服务群群成员
   * 
   * @param request - AddMemberToServiceGroupRequest
   * @param headers - AddMemberToServiceGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddMemberToServiceGroupResponse
   */
  async addMemberToServiceGroupWithOptions(request: AddMemberToServiceGroupRequest, headers: AddMemberToServiceGroupHeaders, runtime: $Util.RuntimeOptions): Promise<AddMemberToServiceGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
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
      action: "AddMemberToServiceGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddMemberToServiceGroupResponse>(await this.execute(params, req, runtime), new AddMemberToServiceGroupResponse({}));
  }

  /**
   * 添加服务群群成员
   * 
   * @param request - AddMemberToServiceGroupRequest
   * @returns AddMemberToServiceGroupResponse
   */
  async addMemberToServiceGroup(request: AddMemberToServiceGroupRequest): Promise<AddMemberToServiceGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddMemberToServiceGroupHeaders({ });
    return await this.addMemberToServiceGroupWithOptions(request, headers, runtime);
  }

  /**
   * OpenApi添加知识点类目
   * 
   * @param request - AddOpenCategoryRequest
   * @param headers - AddOpenCategoryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddOpenCategoryResponse
   */
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
    let params = new $OpenApi.Params({
      action: "AddOpenCategory",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/openCategories`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddOpenCategoryResponse>(await this.execute(params, req, runtime), new AddOpenCategoryResponse({}));
  }

  /**
   * OpenApi添加知识点类目
   * 
   * @param request - AddOpenCategoryRequest
   * @returns AddOpenCategoryResponse
   */
  async addOpenCategory(request: AddOpenCategoryRequest): Promise<AddOpenCategoryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenCategoryHeaders({ });
    return await this.addOpenCategoryWithOptions(request, headers, runtime);
  }

  /**
   * OpenApi添加知识入库
   * 
   * @param request - AddOpenKnowledgeRequest
   * @param headers - AddOpenKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddOpenKnowledgeResponse
   */
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
    let params = new $OpenApi.Params({
      action: "AddOpenKnowledge",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/openKnowledges`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddOpenKnowledgeResponse>(await this.execute(params, req, runtime), new AddOpenKnowledgeResponse({}));
  }

  /**
   * OpenApi添加知识入库
   * 
   * @param request - AddOpenKnowledgeRequest
   * @returns AddOpenKnowledgeResponse
   */
  async addOpenKnowledge(request: AddOpenKnowledgeRequest): Promise<AddOpenKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenKnowledgeHeaders({ });
    return await this.addOpenKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * 智能服务群知识库创建
   * 
   * @param request - AddOpenLibraryRequest
   * @param headers - AddOpenLibraryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddOpenLibraryResponse
   */
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
    let params = new $OpenApi.Params({
      action: "AddOpenLibrary",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/openLibraries`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddOpenLibraryResponse>(await this.execute(params, req, runtime), new AddOpenLibraryResponse({}));
  }

  /**
   * 智能服务群知识库创建
   * 
   * @param request - AddOpenLibraryRequest
   * @returns AddOpenLibraryResponse
   */
  async addOpenLibrary(request: AddOpenLibraryRequest): Promise<AddOpenLibraryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddOpenLibraryHeaders({ });
    return await this.addOpenLibraryWithOptions(request, headers, runtime);
  }

  /**
   * 添加工单备注
   * 
   * @param request - AddTicketMemoRequest
   * @param headers - AddTicketMemoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddTicketMemoResponse
   */
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "AddTicketMemo",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/memos`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddTicketMemoResponse>(await this.execute(params, req, runtime), new AddTicketMemoResponse({}));
  }

  /**
   * 添加工单备注
   * 
   * @param request - AddTicketMemoRequest
   * @returns AddTicketMemoResponse
   */
  async addTicketMemo(request: AddTicketMemoRequest): Promise<AddTicketMemoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddTicketMemoHeaders({ });
    return await this.addTicketMemoWithOptions(request, headers, runtime);
  }

  /**
   * 工单指派
   * 
   * @param request - AssignTicketRequest
   * @param headers - AssignTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AssignTicketResponse
   */
  async assignTicketWithOptions(request: AssignTicketRequest, headers: AssignTicketHeaders, runtime: $Util.RuntimeOptions): Promise<AssignTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.notify)) {
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "AssignTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/assign`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AssignTicketResponse>(await this.execute(params, req, runtime), new AssignTicketResponse({}));
  }

  /**
   * 工单指派
   * 
   * @param request - AssignTicketRequest
   * @returns AssignTicketResponse
   */
  async assignTicket(request: AssignTicketRequest): Promise<AssignTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AssignTicketHeaders({ });
    return await this.assignTicketWithOptions(request, headers, runtime);
  }

  /**
   * 批量绑定服务群业务ID
   * 
   * @param request - BatchBindingGroupBizIdsRequest
   * @param headers - BatchBindingGroupBizIdsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchBindingGroupBizIdsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BatchBindingGroupBizIds",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/bind`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchBindingGroupBizIdsResponse>(await this.execute(params, req, runtime), new BatchBindingGroupBizIdsResponse({}));
  }

  /**
   * 批量绑定服务群业务ID
   * 
   * @param request - BatchBindingGroupBizIdsRequest
   * @returns BatchBindingGroupBizIdsResponse
   */
  async batchBindingGroupBizIds(request: BatchBindingGroupBizIdsRequest): Promise<BatchBindingGroupBizIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchBindingGroupBizIdsHeaders({ });
    return await this.batchBindingGroupBizIdsWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询群组配置
   * 
   * @param request - BatchGetGroupSetConfigRequest
   * @param headers - BatchGetGroupSetConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchGetGroupSetConfigResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BatchGetGroupSetConfig",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groupSetConfigs/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<BatchGetGroupSetConfigResponse>(await this.execute(params, req, runtime), new BatchGetGroupSetConfigResponse({}));
  }

  /**
   * 批量查询群组配置
   * 
   * @param request - BatchGetGroupSetConfigRequest
   * @returns BatchGetGroupSetConfigResponse
   */
  async batchGetGroupSetConfig(request: BatchGetGroupSetConfigRequest): Promise<BatchGetGroupSetConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchGetGroupSetConfigHeaders({ });
    return await this.batchGetGroupSetConfigWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询客户群发任务
   * 
   * @param request - BatchQueryCustomerSendTaskRequest
   * @param headers - BatchQueryCustomerSendTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQueryCustomerSendTaskResponse
   */
  async batchQueryCustomerSendTaskWithOptions(request: BatchQueryCustomerSendTaskRequest, headers: BatchQueryCustomerSendTaskHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryCustomerSendTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.gmtCreateEnd)) {
      body["gmtCreateEnd"] = request.gmtCreateEnd;
    }

    if (!Util.isUnset(request.gmtCreateStart)) {
      body["gmtCreateStart"] = request.gmtCreateStart;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.needRichStatistics)) {
      body["needRichStatistics"] = request.needRichStatistics;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openBatchTaskIds)) {
      body["openBatchTaskIds"] = request.openBatchTaskIds;
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
    let params = new $OpenApi.Params({
      action: "BatchQueryCustomerSendTask",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customers/tasks/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQueryCustomerSendTaskResponse>(await this.execute(params, req, runtime), new BatchQueryCustomerSendTaskResponse({}));
  }

  /**
   * 批量查询客户群发任务
   * 
   * @param request - BatchQueryCustomerSendTaskRequest
   * @returns BatchQueryCustomerSendTaskResponse
   */
  async batchQueryCustomerSendTask(request: BatchQueryCustomerSendTaskRequest): Promise<BatchQueryCustomerSendTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryCustomerSendTaskHeaders({ });
    return await this.batchQueryCustomerSendTaskWithOptions(request, headers, runtime);
  }

  /**
   * 批量查询群成员
   * 
   * @param request - BatchQueryGroupMemberRequest
   * @param headers - BatchQueryGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQueryGroupMemberResponse
   */
  async batchQueryGroupMemberWithOptions(request: BatchQueryGroupMemberRequest, headers: BatchQueryGroupMemberHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryGroupMemberResponse> {
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
    let params = new $OpenApi.Params({
      action: "BatchQueryGroupMember",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/members/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQueryGroupMemberResponse>(await this.execute(params, req, runtime), new BatchQueryGroupMemberResponse({}));
  }

  /**
   * 批量查询群成员
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
   * 群发任务批量查询
   * 
   * @param request - BatchQuerySendMessageTaskRequest
   * @param headers - BatchQuerySendMessageTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQuerySendMessageTaskResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BatchQuerySendMessageTask",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tasks/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQuerySendMessageTaskResponse>(await this.execute(params, req, runtime), new BatchQuerySendMessageTaskResponse({}));
  }

  /**
   * 群发任务批量查询
   * 
   * @param request - BatchQuerySendMessageTaskRequest
   * @returns BatchQuerySendMessageTaskResponse
   */
  async batchQuerySendMessageTask(request: BatchQuerySendMessageTaskRequest): Promise<BatchQuerySendMessageTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQuerySendMessageTaskHeaders({ });
    return await this.batchQuerySendMessageTaskWithOptions(request, headers, runtime);
  }

  /**
   * 绑定服务群模板到团队
   * 
   * @param request - BoundTemplateToTeamRequest
   * @param headers - BoundTemplateToTeamHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BoundTemplateToTeamResponse
   */
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
    let params = new $OpenApi.Params({
      action: "BoundTemplateToTeam",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/teams/templates/bound`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<BoundTemplateToTeamResponse>(await this.execute(params, req, runtime), new BoundTemplateToTeamResponse({}));
  }

  /**
   * 绑定服务群模板到团队
   * 
   * @param request - BoundTemplateToTeamRequest
   * @returns BoundTemplateToTeamResponse
   */
  async boundTemplateToTeam(request: BoundTemplateToTeamRequest): Promise<BoundTemplateToTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BoundTemplateToTeamHeaders({ });
    return await this.boundTemplateToTeamWithOptions(request, headers, runtime);
  }

  /**
   * 撤销工单
   * 
   * @param request - CancelTicketRequest
   * @param headers - CancelTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CancelTicketResponse
   */
  async cancelTicketWithOptions(request: CancelTicketRequest, headers: CancelTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CancelTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.notify)) {
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "CancelTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/cancel`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CancelTicketResponse>(await this.execute(params, req, runtime), new CancelTicketResponse({}));
  }

  /**
   * 撤销工单
   * 
   * @param request - CancelTicketRequest
   * @returns CancelTicketResponse
   */
  async cancelTicket(request: CancelTicketRequest): Promise<CancelTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CancelTicketHeaders({ });
    return await this.cancelTicketWithOptions(request, headers, runtime);
  }

  /**
   * 心声总览自定义分类统计
   * 
   * @param request - CategoryStatisticsRequest
   * @param headers - CategoryStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CategoryStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CategoryStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/dashboards/categories/statistics`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CategoryStatisticsResponse>(await this.execute(params, req, runtime), new CategoryStatisticsResponse({}));
  }

  /**
   * 心声总览自定义分类统计
   * 
   * @param request - CategoryStatisticsRequest
   * @returns CategoryStatisticsResponse
   */
  async categoryStatistics(request: CategoryStatisticsRequest): Promise<CategoryStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CategoryStatisticsHeaders({ });
    return await this.categoryStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 关闭会话回调
   * 
   * @param request - CloseConversationRequest
   * @param headers - CloseConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CloseConversationResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CloseConversation",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/conversions`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CloseConversationResponse>(await this.execute(params, req, runtime), new CloseConversationResponse({}));
  }

  /**
   * 关闭会话回调
   * 
   * @param request - CloseConversationRequest
   * @returns CloseConversationResponse
   */
  async closeConversation(request: CloseConversationRequest): Promise<CloseConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseConversationHeaders({ });
    return await this.closeConversationWithOptions(request, headers, runtime);
  }

  /**
   * 关闭人工会话
   * 
   * @param request - CloseHumanSessionRequest
   * @param headers - CloseHumanSessionHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CloseHumanSessionResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CloseHumanSession",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/humanSessions/close`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CloseHumanSessionResponse>(await this.execute(params, req, runtime), new CloseHumanSessionResponse({}));
  }

  /**
   * 关闭人工会话
   * 
   * @param request - CloseHumanSessionRequest
   * @returns CloseHumanSessionResponse
   */
  async closeHumanSession(request: CloseHumanSessionRequest): Promise<CloseHumanSessionResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseHumanSessionHeaders({ });
    return await this.closeHumanSessionWithOptions(request, headers, runtime);
  }

  /**
   * 客服分配成功通知回调
   * 
   * @param request - ConversationCreatedNotifyRequest
   * @param headers - ConversationCreatedNotifyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConversationCreatedNotifyResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ConversationCreatedNotify",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConversationCreatedNotifyResponse>(await this.execute(params, req, runtime), new ConversationCreatedNotifyResponse({}));
  }

  /**
   * 客服分配成功通知回调
   * 
   * @param request - ConversationCreatedNotifyRequest
   * @returns ConversationCreatedNotifyResponse
   */
  async conversationCreatedNotify(request: ConversationCreatedNotifyRequest): Promise<ConversationCreatedNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConversationCreatedNotifyHeaders({ });
    return await this.conversationCreatedNotifyWithOptions(request, headers, runtime);
  }

  /**
   * 会话转接开始通知回调
   * 
   * @param request - ConversationTransferBeginNotifyRequest
   * @param headers - ConversationTransferBeginNotifyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConversationTransferBeginNotifyResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ConversationTransferBeginNotify",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/transfers`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConversationTransferBeginNotifyResponse>(await this.execute(params, req, runtime), new ConversationTransferBeginNotifyResponse({}));
  }

  /**
   * 会话转接开始通知回调
   * 
   * @param request - ConversationTransferBeginNotifyRequest
   * @returns ConversationTransferBeginNotifyResponse
   */
  async conversationTransferBeginNotify(request: ConversationTransferBeginNotifyRequest): Promise<ConversationTransferBeginNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConversationTransferBeginNotifyHeaders({ });
    return await this.conversationTransferBeginNotifyWithOptions(request, headers, runtime);
  }

  /**
   * 会话转接完成通知回调
   * 
   * @param request - ConversationTransferCompleteNotifyRequest
   * @param headers - ConversationTransferCompleteNotifyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ConversationTransferCompleteNotifyResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ConversationTransferCompleteNotify",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/completes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ConversationTransferCompleteNotifyResponse>(await this.execute(params, req, runtime), new ConversationTransferCompleteNotifyResponse({}));
  }

  /**
   * 会话转接完成通知回调
   * 
   * @param request - ConversationTransferCompleteNotifyRequest
   * @returns ConversationTransferCompleteNotifyResponse
   */
  async conversationTransferCompleteNotify(request: ConversationTransferCompleteNotifyRequest): Promise<ConversationTransferCompleteNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConversationTransferCompleteNotifyHeaders({ });
    return await this.conversationTransferCompleteNotifyWithOptions(request, headers, runtime);
  }

  /**
   * 创建服务群
   * 
   * @param request - CreateGroupRequest
   * @param headers - CreateGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupResponse>(await this.execute(params, req, runtime), new CreateGroupResponse({}));
  }

  /**
   * 创建服务群
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
   * 创建主动会话接口
   * 
   * @param request - CreateGroupConversationRequest
   * @param headers - CreateGroupConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupConversationResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateGroupConversation",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/create/conversations`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupConversationResponse>(await this.execute(params, req, runtime), new CreateGroupConversationResponse({}));
  }

  /**
   * 创建主动会话接口
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
   * 创建服务群群分组
   * 
   * @param request - CreateGroupSetRequest
   * @param headers - CreateGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupSetResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateGroupSet",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groupSets`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupSetResponse>(await this.execute(params, req, runtime), new CreateGroupSetResponse({}));
  }

  /**
   * 创建服务群群分组
   * 
   * @param request - CreateGroupSetRequest
   * @returns CreateGroupSetResponse
   */
  async createGroupSet(request: CreateGroupSetRequest): Promise<CreateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupSetHeaders({ });
    return await this.createGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 服务群新增表单实例
   * 
   * @param request - CreateInstanceRequest
   * @param headers - CreateInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateInstanceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateInstance",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customForms/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateInstanceResponse>(await this.execute(params, req, runtime), new CreateInstanceResponse({}));
  }

  /**
   * 服务群新增表单实例
   * 
   * @param request - CreateInstanceRequest
   * @returns CreateInstanceResponse
   */
  async createInstance(request: CreateInstanceRequest): Promise<CreateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateInstanceHeaders({ });
    return await this.createInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 创建服务群团队
   * 
   * @param request - CreateTeamRequest
   * @param headers - CreateTeamHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateTeamResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateTeam",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/teams`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateTeamResponse>(await this.execute(params, req, runtime), new CreateTeamResponse({}));
  }

  /**
   * 创建服务群团队
   * 
   * @param request - CreateTeamRequest
   * @returns CreateTeamResponse
   */
  async createTeam(request: CreateTeamRequest): Promise<CreateTeamResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTeamHeaders({ });
    return await this.createTeamWithOptions(request, headers, runtime);
  }

  /**
   * 创建工单
   * 
   * @param request - CreateTicketRequest
   * @param headers - CreateTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateTicketResponse
   */
  async createTicketWithOptions(request: CreateTicketRequest, headers: CreateTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset(request.notify)) {
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

    if (!Util.isUnset(request.sceneContext)) {
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
    let params = new $OpenApi.Params({
      action: "CreateTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateTicketResponse>(await this.execute(params, req, runtime), new CreateTicketResponse({}));
  }

  /**
   * 创建工单
   * 
   * @param request - CreateTicketRequest
   * @returns CreateTicketResponse
   */
  async createTicket(request: CreateTicketRequest): Promise<CreateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTicketHeaders({ });
    return await this.createTicketWithOptions(request, headers, runtime);
  }

  /**
   * 客户群发任务
   * 
   * @param request - CustomerSendMsgTaskRequest
   * @param headers - CustomerSendMsgTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CustomerSendMsgTaskResponse
   */
  async customerSendMsgTaskWithOptions(request: CustomerSendMsgTaskRequest, headers: CustomerSendMsgTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CustomerSendMsgTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.messageContent)) {
      body["messageContent"] = request.messageContent;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.queryCustomer)) {
      body["queryCustomer"] = request.queryCustomer;
    }

    if (!Util.isUnset(request.sendConfig)) {
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
    let params = new $OpenApi.Params({
      action: "CustomerSendMsgTask",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customers/tasks/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CustomerSendMsgTaskResponse>(await this.execute(params, req, runtime), new CustomerSendMsgTaskResponse({}));
  }

  /**
   * 客户群发任务
   * 
   * @param request - CustomerSendMsgTaskRequest
   * @returns CustomerSendMsgTaskResponse
   */
  async customerSendMsgTask(request: CustomerSendMsgTaskRequest): Promise<CustomerSendMsgTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CustomerSendMsgTaskHeaders({ });
    return await this.customerSendMsgTaskWithOptions(request, headers, runtime);
  }

  /**
   * 从群或者群组剔除成员
   * 
   * @param request - DeleteGroupMembersFromGroupRequest
   * @param headers - DeleteGroupMembersFromGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteGroupMembersFromGroupResponse
   */
  async deleteGroupMembersFromGroupWithOptions(request: DeleteGroupMembersFromGroupRequest, headers: DeleteGroupMembersFromGroupHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteGroupMembersFromGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.deleteGroupType)) {
      body["deleteGroupType"] = request.deleteGroupType;
    }

    if (!Util.isUnset(request.memberUnionId)) {
      body["memberUnionId"] = request.memberUnionId;
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
      action: "DeleteGroupMembersFromGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/members/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteGroupMembersFromGroupResponse>(await this.execute(params, req, runtime), new DeleteGroupMembersFromGroupResponse({}));
  }

  /**
   * 从群或者群组剔除成员
   * 
   * @param request - DeleteGroupMembersFromGroupRequest
   * @returns DeleteGroupMembersFromGroupResponse
   */
  async deleteGroupMembersFromGroup(request: DeleteGroupMembersFromGroupRequest): Promise<DeleteGroupMembersFromGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteGroupMembersFromGroupHeaders({ });
    return await this.deleteGroupMembersFromGroupWithOptions(request, headers, runtime);
  }

  /**
   * 服务群删除表单实例
   * 
   * @param request - DeleteInstanceRequest
   * @param headers - DeleteInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteInstanceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "DeleteInstance",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customForms/instances/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteInstanceResponse>(await this.execute(params, req, runtime), new DeleteInstanceResponse({}));
  }

  /**
   * 服务群删除表单实例
   * 
   * @param request - DeleteInstanceRequest
   * @returns DeleteInstanceResponse
   */
  async deleteInstance(request: DeleteInstanceRequest): Promise<DeleteInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteInstanceHeaders({ });
    return await this.deleteInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 服务群删除知识点
   * 
   * @param request - DeleteKnowledgeRequest
   * @param headers - DeleteKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteKnowledgeResponse
   */
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
    let params = new $OpenApi.Params({
      action: "DeleteKnowledge",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/knowledges/batchDelete`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<DeleteKnowledgeResponse>(await this.execute(params, req, runtime), new DeleteKnowledgeResponse({}));
  }

  /**
   * 服务群删除知识点
   * 
   * @param request - DeleteKnowledgeRequest
   * @returns DeleteKnowledgeResponse
   */
  async deleteKnowledge(request: DeleteKnowledgeRequest): Promise<DeleteKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteKnowledgeHeaders({ });
    return await this.deleteKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * 客户心声负面情绪统计
   * 
   * @param request - EmotionStatisticsRequest
   * @param headers - EmotionStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns EmotionStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "EmotionStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/emotions/statistics`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<EmotionStatisticsResponse>(await this.execute(params, req, runtime), new EmotionStatisticsResponse({}));
  }

  /**
   * 客户心声负面情绪统计
   * 
   * @param request - EmotionStatisticsRequest
   * @returns EmotionStatisticsResponse
   */
  async emotionStatistics(request: EmotionStatisticsRequest): Promise<EmotionStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EmotionStatisticsHeaders({ });
    return await this.emotionStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 结单
   * 
   * @param request - FinishTicketRequest
   * @param headers - FinishTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns FinishTicketResponse
   */
  async finishTicketWithOptions(request: FinishTicketRequest, headers: FinishTicketHeaders, runtime: $Util.RuntimeOptions): Promise<FinishTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.notify)) {
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "FinishTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/finish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<FinishTicketResponse>(await this.execute(params, req, runtime), new FinishTicketResponse({}));
  }

  /**
   * 结单
   * 
   * @param request - FinishTicketRequest
   * @returns FinishTicketResponse
   */
  async finishTicket(request: FinishTicketRequest): Promise<FinishTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishTicketHeaders({ });
    return await this.finishTicketWithOptions(request, headers, runtime);
  }

  /**
   * 获取签权Token
   * 
   * @param request - GetAuthTokenRequest
   * @param headers - GetAuthTokenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAuthTokenResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetAuthToken",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/get/tokens`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAuthTokenResponse>(await this.execute(params, req, runtime), new GetAuthTokenResponse({}));
  }

  /**
   * 获取签权Token
   * 
   * @param request - GetAuthTokenRequest
   * @returns GetAuthTokenResponse
   */
  async getAuthToken(request: GetAuthTokenRequest): Promise<GetAuthTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAuthTokenHeaders({ });
    return await this.getAuthTokenWithOptions(request, headers, runtime);
  }

  /**
   * 服务群通过实例ID集合批量查询表单实例数据
   * 
   * @param request - GetInstancesByIdsRequest
   * @param headers - GetInstancesByIdsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInstancesByIdsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetInstancesByIds",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customForms/instances/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInstancesByIdsResponse>(await this.execute(params, req, runtime), new GetInstancesByIdsResponse({}));
  }

  /**
   * 服务群通过实例ID集合批量查询表单实例数据
   * 
   * @param request - GetInstancesByIdsRequest
   * @returns GetInstancesByIdsResponse
   */
  async getInstancesByIds(request: GetInstancesByIdsRequest): Promise<GetInstancesByIdsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInstancesByIdsHeaders({ });
    return await this.getInstancesByIdsWithOptions(request, headers, runtime);
  }

  /**
   * 获取负面心声词云
   * 
   * @param request - GetNegativeWordCloudRequest
   * @param headers - GetNegativeWordCloudHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetNegativeWordCloudResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetNegativeWordCloud",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/negatives/wordClouds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetNegativeWordCloudResponse>(await this.execute(params, req, runtime), new GetNegativeWordCloudResponse({}));
  }

  /**
   * 获取负面心声词云
   * 
   * @param request - GetNegativeWordCloudRequest
   * @returns GetNegativeWordCloudResponse
   */
  async getNegativeWordCloud(request: GetNegativeWordCloudRequest): Promise<GetNegativeWordCloudResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetNegativeWordCloudHeaders({ });
    return await this.getNegativeWordCloudWithOptions(request, headers, runtime);
  }

  /**
   * 获取临时访问链接
   * 
   * @param request - GetOssTempUrlRequest
   * @param headers - GetOssTempUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetOssTempUrlResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetOssTempUrl",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/ossServices/tempUrls`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetOssTempUrlResponse>(await this.execute(params, req, runtime), new GetOssTempUrlResponse({}));
  }

  /**
   * 获取临时访问链接
   * 
   * @param request - GetOssTempUrlRequest
   * @returns GetOssTempUrlResponse
   */
  async getOssTempUrl(request: GetOssTempUrlRequest): Promise<GetOssTempUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOssTempUrlHeaders({ });
    return await this.getOssTempUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取表单上传凭证
   * 
   * @param request - GetStoragePolicyRequest
   * @param headers - GetStoragePolicyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetStoragePolicyResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetStoragePolicy",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/ossServices/policies`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetStoragePolicyResponse>(await this.execute(params, req, runtime), new GetStoragePolicyResponse({}));
  }

  /**
   * 获取表单上传凭证
   * 
   * @param request - GetStoragePolicyRequest
   * @returns GetStoragePolicyResponse
   */
  async getStoragePolicy(request: GetStoragePolicyRequest): Promise<GetStoragePolicyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetStoragePolicyHeaders({ });
    return await this.getStoragePolicyWithOptions(request, headers, runtime);
  }

  /**
   * 查询工单详情
   * 
   * @param request - GetTicketRequest
   * @param headers - GetTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetTicketResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetTicketResponse>(await this.execute(params, req, runtime), new GetTicketResponse({}));
  }

  /**
   * 查询工单详情
   * 
   * @param request - GetTicketRequest
   * @returns GetTicketResponse
   */
  async getTicket(request: GetTicketRequest): Promise<GetTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTicketHeaders({ });
    return await this.getTicketWithOptions(request, headers, runtime);
  }

  /**
   * 获取心声词云
   * 
   * @param request - GetWordCloudRequest
   * @param headers - GetWordCloudHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetWordCloudResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetWordCloud",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/wordClouds`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWordCloudResponse>(await this.execute(params, req, runtime), new GetWordCloudResponse({}));
  }

  /**
   * 获取心声词云
   * 
   * @param request - GetWordCloudRequest
   * @returns GetWordCloudResponse
   */
  async getWordCloud(request: GetWordCloudRequest): Promise<GetWordCloudResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWordCloudHeaders({ });
    return await this.getWordCloudWithOptions(request, headers, runtime);
  }

  /**
   * 心声总览群统计
   * 
   * @param request - GroupStatisticsRequest
   * @param headers - GroupStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GroupStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GroupStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/dashboards/groups/statistics`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GroupStatisticsResponse>(await this.execute(params, req, runtime), new GroupStatisticsResponse({}));
  }

  /**
   * 心声总览群统计
   * 
   * @param request - GroupStatisticsRequest
   * @returns GroupStatisticsResponse
   */
  async groupStatistics(request: GroupStatisticsRequest): Promise<GroupStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GroupStatisticsHeaders({ });
    return await this.groupStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 心声总览意图&自定义分类统计
   * 
   * @param request - IntentionCategoryStatisticsRequest
   * @param headers - IntentionCategoryStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns IntentionCategoryStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "IntentionCategoryStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IntentionCategoryStatisticsResponse>(await this.execute(params, req, runtime), new IntentionCategoryStatisticsResponse({}));
  }

  /**
   * 心声总览意图&自定义分类统计
   * 
   * @param request - IntentionCategoryStatisticsRequest
   * @returns IntentionCategoryStatisticsResponse
   */
  async intentionCategoryStatistics(request: IntentionCategoryStatisticsRequest): Promise<IntentionCategoryStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IntentionCategoryStatisticsHeaders({ });
    return await this.intentionCategoryStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 心声总览意图统计
   * 
   * @param request - IntentionStatisticsRequest
   * @param headers - IntentionStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns IntentionStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "IntentionStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/dashboards/intentions/statistics`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<IntentionStatisticsResponse>(await this.execute(params, req, runtime), new IntentionStatisticsResponse({}));
  }

  /**
   * 心声总览意图统计
   * 
   * @param request - IntentionStatisticsRequest
   * @returns IntentionStatisticsResponse
   */
  async intentionStatistics(request: IntentionStatisticsRequest): Promise<IntentionStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new IntentionStatisticsHeaders({ });
    return await this.intentionStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 查询工单操作记录
   * 
   * @param request - ListTicketOperateRecordRequest
   * @param headers - ListTicketOperateRecordHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListTicketOperateRecordResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ListTicketOperateRecord",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/operateRecords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListTicketOperateRecordResponse>(await this.execute(params, req, runtime), new ListTicketOperateRecordResponse({}));
  }

  /**
   * 查询工单操作记录
   * 
   * @param request - ListTicketOperateRecordRequest
   * @returns ListTicketOperateRecordResponse
   */
  async listTicketOperateRecord(request: ListTicketOperateRecordRequest): Promise<ListTicketOperateRecordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListTicketOperateRecordHeaders({ });
    return await this.listTicketOperateRecordWithOptions(request, headers, runtime);
  }

  /**
   * 查询用户所在团队
   * 
   * @param headers - ListUserTeamsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListUserTeamsResponse
   */
  async listUserTeamsWithOptions(userId: string, headers: ListUserTeamsHeaders, runtime: $Util.RuntimeOptions): Promise<ListUserTeamsResponse> {
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
      action: "ListUserTeams",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/users/${userId}/teams`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ListUserTeamsResponse>(await this.execute(params, req, runtime), new ListUserTeamsResponse({}));
  }

  /**
   * 查询用户所在团队
   * @returns ListUserTeamsResponse
   */
  async listUserTeams(userId: string): Promise<ListUserTeamsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListUserTeamsHeaders({ });
    return await this.listUserTeamsWithOptions(userId, headers, runtime);
  }

  /**
   * 查询服务群活跃成员
   * 
   * @param request - QueryActiveUsersRequest
   * @param headers - QueryActiveUsersHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryActiveUsersResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryActiveUsers",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/queryActiveUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryActiveUsersResponse>(await this.execute(params, req, runtime), new QueryActiveUsersResponse({}));
  }

  /**
   * 查询服务群活跃成员
   * 
   * @param request - QueryActiveUsersRequest
   * @returns QueryActiveUsersResponse
   */
  async queryActiveUsers(request: QueryActiveUsersRequest): Promise<QueryActiveUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryActiveUsersHeaders({ });
    return await this.queryActiveUsersWithOptions(request, headers, runtime);
  }

  /**
   * 群联系人画像检索
   * 
   * @param request - QueryCrmGroupContactRequest
   * @param headers - QueryCrmGroupContactHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCrmGroupContactResponse
   */
  async queryCrmGroupContactWithOptions(request: QueryCrmGroupContactRequest, headers: QueryCrmGroupContactHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCrmGroupContactResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.minResult)) {
      body["minResult"] = request.minResult;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.searchFields)) {
      body["searchFields"] = request.searchFields;
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
      action: "QueryCrmGroupContact",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/contacts/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCrmGroupContactResponse>(await this.execute(params, req, runtime), new QueryCrmGroupContactResponse({}));
  }

  /**
   * 群联系人画像检索
   * 
   * @param request - QueryCrmGroupContactRequest
   * @returns QueryCrmGroupContactResponse
   */
  async queryCrmGroupContact(request: QueryCrmGroupContactRequest): Promise<QueryCrmGroupContactResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCrmGroupContactHeaders({ });
    return await this.queryCrmGroupContactWithOptions(request, headers, runtime);
  }

  /**
   * 查询客户信息
   * 
   * @param request - QueryCustomerCardRequest
   * @param headers - QueryCustomerCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCustomerCardResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryCustomerCard",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/userDetials`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCustomerCardResponse>(await this.execute(params, req, runtime), new QueryCustomerCardResponse({}));
  }

  /**
   * 查询客户信息
   * 
   * @param request - QueryCustomerCardRequest
   * @returns QueryCustomerCardResponse
   */
  async queryCustomerCard(request: QueryCustomerCardRequest): Promise<QueryCustomerCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerCardHeaders({ });
    return await this.queryCustomerCardWithOptions(request, headers, runtime);
  }

  /**
   * 查询客户群发任务客户触达详情
   * 
   * @param request - QueryCustomerTaskUserDetailRequest
   * @param headers - QueryCustomerTaskUserDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryCustomerTaskUserDetailResponse
   */
  async queryCustomerTaskUserDetailWithOptions(request: QueryCustomerTaskUserDetailRequest, headers: QueryCustomerTaskUserDetailHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCustomerTaskUserDetailResponse> {
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

    if (!Util.isUnset(request.receiverUnionIds)) {
      body["receiverUnionIds"] = request.receiverUnionIds;
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
      action: "QueryCustomerTaskUserDetail",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customers/tasks/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCustomerTaskUserDetailResponse>(await this.execute(params, req, runtime), new QueryCustomerTaskUserDetailResponse({}));
  }

  /**
   * 查询客户群发任务客户触达详情
   * 
   * @param request - QueryCustomerTaskUserDetailRequest
   * @returns QueryCustomerTaskUserDetailResponse
   */
  async queryCustomerTaskUserDetail(request: QueryCustomerTaskUserDetailRequest): Promise<QueryCustomerTaskUserDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCustomerTaskUserDetailHeaders({ });
    return await this.queryCustomerTaskUserDetailWithOptions(request, headers, runtime);
  }

  /**
   * 查询单个服务群信息
   * 
   * @param request - QueryGroupRequest
   * @param headers - QueryGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupResponse>(await this.execute(params, req, runtime), new QueryGroupResponse({}));
  }

  /**
   * 查询单个服务群信息
   * 
   * @param request - QueryGroupRequest
   * @returns QueryGroupResponse
   */
  async queryGroup(request: QueryGroupRequest): Promise<QueryGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupHeaders({ });
    return await this.queryGroupWithOptions(request, headers, runtime);
  }

  /**
   * 查询指定群成员
   * 
   * @param request - QueryGroupMemberRequest
   * @param headers - QueryGroupMemberHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupMemberResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryGroupMember",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/members/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupMemberResponse>(await this.execute(params, req, runtime), new QueryGroupMemberResponse({}));
  }

  /**
   * 查询指定群成员
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
   * 查询服务群群组信息
   * 
   * @param request - QueryGroupSetRequest
   * @param headers - QueryGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGroupSetResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryGroupSet",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groupSets`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryGroupSetResponse>(await this.execute(params, req, runtime), new QueryGroupSetResponse({}));
  }

  /**
   * 查询服务群群组信息
   * 
   * @param request - QueryGroupSetRequest
   * @returns QueryGroupSetResponse
   */
  async queryGroupSet(request: QueryGroupSetRequest): Promise<QueryGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGroupSetHeaders({ });
    return await this.queryGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 服务群通过多添件进行组合检索表单数据实例集合
   * 
   * @param request - QueryInstancesByMultiConditionsRequest
   * @param headers - QueryInstancesByMultiConditionsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryInstancesByMultiConditionsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryInstancesByMultiConditions",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryInstancesByMultiConditionsResponse>(await this.execute(params, req, runtime), new QueryInstancesByMultiConditionsResponse({}));
  }

  /**
   * 服务群通过多添件进行组合检索表单数据实例集合
   * 
   * @param request - QueryInstancesByMultiConditionsRequest
   * @returns QueryInstancesByMultiConditionsResponse
   */
  async queryInstancesByMultiConditions(request: QueryInstancesByMultiConditionsRequest): Promise<QueryInstancesByMultiConditionsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryInstancesByMultiConditionsHeaders({ });
    return await this.queryInstancesByMultiConditionsWithOptions(request, headers, runtime);
  }

  /**
   * 群发任务统计查询
   * 
   * @param request - QuerySendMsgTaskStatisticsRequest
   * @param headers - QuerySendMsgTaskStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySendMsgTaskStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QuerySendMsgTaskStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tasks/statistics/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySendMsgTaskStatisticsResponse>(await this.execute(params, req, runtime), new QuerySendMsgTaskStatisticsResponse({}));
  }

  /**
   * 群发任务统计查询
   * 
   * @param request - QuerySendMsgTaskStatisticsRequest
   * @returns QuerySendMsgTaskStatisticsResponse
   */
  async querySendMsgTaskStatistics(request: QuerySendMsgTaskStatisticsRequest): Promise<QuerySendMsgTaskStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySendMsgTaskStatisticsHeaders({ });
    return await this.querySendMsgTaskStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 群发任务群维度的统计数据
   * 
   * @param request - QuerySendMsgTaskStatisticsDetailRequest
   * @param headers - QuerySendMsgTaskStatisticsDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QuerySendMsgTaskStatisticsDetailResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QuerySendMsgTaskStatisticsDetail",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tasks/statistics/details/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QuerySendMsgTaskStatisticsDetailResponse>(await this.execute(params, req, runtime), new QuerySendMsgTaskStatisticsDetailResponse({}));
  }

  /**
   * 群发任务群维度的统计数据
   * 
   * @param request - QuerySendMsgTaskStatisticsDetailRequest
   * @returns QuerySendMsgTaskStatisticsDetailResponse
   */
  async querySendMsgTaskStatisticsDetail(request: QuerySendMsgTaskStatisticsDetailRequest): Promise<QuerySendMsgTaskStatisticsDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QuerySendMsgTaskStatisticsDetailHeaders({ });
    return await this.querySendMsgTaskStatisticsDetailWithOptions(request, headers, runtime);
  }

  /**
   * 查消息的已读/未读列表
   * 
   * @param request - QueryServiceGroupMessageReadStatusRequest
   * @param headers - QueryServiceGroupMessageReadStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryServiceGroupMessageReadStatusResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueryServiceGroupMessageReadStatus",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/messages/readStatus/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryServiceGroupMessageReadStatusResponse>(await this.execute(params, req, runtime), new QueryServiceGroupMessageReadStatusResponse({}));
  }

  /**
   * 查消息的已读/未读列表
   * 
   * @param request - QueryServiceGroupMessageReadStatusRequest
   * @returns QueryServiceGroupMessageReadStatusResponse
   */
  async queryServiceGroupMessageReadStatus(request: QueryServiceGroupMessageReadStatusRequest): Promise<QueryServiceGroupMessageReadStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryServiceGroupMessageReadStatusHeaders({ });
    return await this.queryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
  }

  /**
   * 外部DT工作台排队通知回调
   * 
   * @param request - QueueNotifyRequest
   * @param headers - QueueNotifyHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueueNotifyResponse
   */
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
    let params = new $OpenApi.Params({
      action: "QueueNotify",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/dts`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueueNotifyResponse>(await this.execute(params, req, runtime), new QueueNotifyResponse({}));
  }

  /**
   * 外部DT工作台排队通知回调
   * 
   * @param request - QueueNotifyRequest
   * @returns QueueNotifyResponse
   */
  async queueNotify(request: QueueNotifyRequest): Promise<QueueNotifyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueueNotifyHeaders({ });
    return await this.queueNotifyWithOptions(request, headers, runtime);
  }

  /**
   * 组织剔除联系人
   * 
   * @param request - RemoveContactFromOrgRequest
   * @param headers - RemoveContactFromOrgHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RemoveContactFromOrgResponse
   */
  async removeContactFromOrgWithOptions(request: RemoveContactFromOrgRequest, headers: RemoveContactFromOrgHeaders, runtime: $Util.RuntimeOptions): Promise<RemoveContactFromOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.contactUnionId)) {
      body["contactUnionId"] = request.contactUnionId;
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
    let params = new $OpenApi.Params({
      action: "RemoveContactFromOrg",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/organizations/contacts/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RemoveContactFromOrgResponse>(await this.execute(params, req, runtime), new RemoveContactFromOrgResponse({}));
  }

  /**
   * 组织剔除联系人
   * 
   * @param request - RemoveContactFromOrgRequest
   * @returns RemoveContactFromOrgResponse
   */
  async removeContactFromOrg(request: RemoveContactFromOrgRequest): Promise<RemoveContactFromOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RemoveContactFromOrgHeaders({ });
    return await this.removeContactFromOrgWithOptions(request, headers, runtime);
  }

  /**
   * 指定群的客户活跃明细查询
   * 
   * @param request - ReportCustomerDetailRequest
   * @param headers - ReportCustomerDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReportCustomerDetailResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ReportCustomerDetail",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customers/activities/details/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReportCustomerDetailResponse>(await this.execute(params, req, runtime), new ReportCustomerDetailResponse({}));
  }

  /**
   * 指定群的客户活跃明细查询
   * 
   * @param request - ReportCustomerDetailRequest
   * @returns ReportCustomerDetailResponse
   */
  async reportCustomerDetail(request: ReportCustomerDetailRequest): Promise<ReportCustomerDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportCustomerDetailHeaders({ });
    return await this.reportCustomerDetailWithOptions(request, headers, runtime);
  }

  /**
   * 客户活跃明细指标查询
   * 
   * @param request - ReportCustomerStatisticsRequest
   * @param headers - ReportCustomerStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ReportCustomerStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "ReportCustomerStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customers/activities/statistics/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReportCustomerStatisticsResponse>(await this.execute(params, req, runtime), new ReportCustomerStatisticsResponse({}));
  }

  /**
   * 客户活跃明细指标查询
   * 
   * @param request - ReportCustomerStatisticsRequest
   * @returns ReportCustomerStatisticsResponse
   */
  async reportCustomerStatistics(request: ReportCustomerStatisticsRequest): Promise<ReportCustomerStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReportCustomerStatisticsHeaders({ });
    return await this.reportCustomerStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 重新提交工单
   * 
   * @param request - ResubmitTicketRequest
   * @param headers - ResubmitTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ResubmitTicketResponse
   */
  async resubmitTicketWithOptions(request: ResubmitTicketRequest, headers: ResubmitTicketHeaders, runtime: $Util.RuntimeOptions): Promise<ResubmitTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.creatorUnionId)) {
      body["creatorUnionId"] = request.creatorUnionId;
    }

    if (!Util.isUnset(request.customFields)) {
      body["customFields"] = request.customFields;
    }

    if (!Util.isUnset(request.notify)) {
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

    if (!Util.isUnset(request.sceneContext)) {
      body["sceneContext"] = request.sceneContext;
    }

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "ResubmitTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/resubmit`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ResubmitTicketResponse>(await this.execute(params, req, runtime), new ResubmitTicketResponse({}));
  }

  /**
   * 重新提交工单
   * 
   * @param request - ResubmitTicketRequest
   * @returns ResubmitTicketResponse
   */
  async resubmitTicket(request: ResubmitTicketRequest): Promise<ResubmitTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ResubmitTicketHeaders({ });
    return await this.resubmitTicketWithOptions(request, headers, runtime);
  }

  /**
   * 撤回工单
   * 
   * @param request - RetractTicketRequest
   * @param headers - RetractTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RetractTicketResponse
   */
  async retractTicketWithOptions(request: RetractTicketRequest, headers: RetractTicketHeaders, runtime: $Util.RuntimeOptions): Promise<RetractTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.notify)) {
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "RetractTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/retract`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<RetractTicketResponse>(await this.execute(params, req, runtime), new RetractTicketResponse({}));
  }

  /**
   * 撤回工单
   * 
   * @param request - RetractTicketRequest
   * @returns RetractTicketResponse
   */
  async retractTicket(request: RetractTicketRequest): Promise<RetractTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetractTicketHeaders({ });
    return await this.retractTicketWithOptions(request, headers, runtime);
  }

  /**
   * 指定群的机器人消息撤回
   * 
   * @param request - RobotMessageRecallRequest
   * @param headers - RobotMessageRecallHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RobotMessageRecallResponse
   */
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
    let params = new $OpenApi.Params({
      action: "RobotMessageRecall",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/robots/messages/recall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RobotMessageRecallResponse>(await this.execute(params, req, runtime), new RobotMessageRecallResponse({}));
  }

  /**
   * 指定群的机器人消息撤回
   * 
   * @param request - RobotMessageRecallRequest
   * @returns RobotMessageRecallResponse
   */
  async robotMessageRecall(request: RobotMessageRecallRequest): Promise<RobotMessageRecallResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RobotMessageRecallHeaders({ });
    return await this.robotMessageRecallWithOptions(request, headers, runtime);
  }

  /**
   * 服务群新增表单实例
   * 
   * @param request - SaveFormInstanceRequest
   * @param headers - SaveFormInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SaveFormInstanceResponse
   */
  async saveFormInstanceWithOptions(request: SaveFormInstanceRequest, headers: SaveFormInstanceHeaders, runtime: $Util.RuntimeOptions): Promise<SaveFormInstanceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "SaveFormInstance",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/forms/instances`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveFormInstanceResponse>(await this.execute(params, req, runtime), new SaveFormInstanceResponse({}));
  }

  /**
   * 服务群新增表单实例
   * 
   * @param request - SaveFormInstanceRequest
   * @returns SaveFormInstanceResponse
   */
  async saveFormInstance(request: SaveFormInstanceRequest): Promise<SaveFormInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveFormInstanceHeaders({ });
    return await this.saveFormInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 搜索服务群
   * 
   * @param request - SearchGroupRequest
   * @param headers - SearchGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SearchGroupResponse
   */
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
    let params = new $OpenApi.Params({
      action: "SearchGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/search`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SearchGroupResponse>(await this.execute(params, req, runtime), new SearchGroupResponse({}));
  }

  /**
   * 搜索服务群
   * 
   * @param request - SearchGroupRequest
   * @returns SearchGroupResponse
   */
  async searchGroup(request: SearchGroupRequest): Promise<SearchGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SearchGroupHeaders({ });
    return await this.searchGroupWithOptions(request, headers, runtime);
  }

  /**
   * 服务群发任务
   * 
   * @param request - SendMsgByTaskRequest
   * @param headers - SendMsgByTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendMsgByTaskResponse
   */
  async sendMsgByTaskWithOptions(request: SendMsgByTaskRequest, headers: SendMsgByTaskHeaders, runtime: $Util.RuntimeOptions): Promise<SendMsgByTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.messageContent)) {
      body["messageContent"] = request.messageContent;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.queryGroup)) {
      body["queryGroup"] = request.queryGroup;
    }

    if (!Util.isUnset(request.sendConfig)) {
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
    let params = new $OpenApi.Params({
      action: "SendMsgByTask",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/messages/tasks/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMsgByTaskResponse>(await this.execute(params, req, runtime), new SendMsgByTaskResponse({}));
  }

  /**
   * 服务群发任务
   * 
   * @param request - SendMsgByTaskRequest
   * @returns SendMsgByTaskResponse
   */
  async sendMsgByTask(request: SendMsgByTaskRequest): Promise<SendMsgByTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMsgByTaskHeaders({ });
    return await this.sendMsgByTaskWithOptions(request, headers, runtime);
  }

  /**
   * 增强版客户群发
   * 
   * @param request - SendMsgByTaskSupportInviteJoinOrgRequest
   * @param headers - SendMsgByTaskSupportInviteJoinOrgHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendMsgByTaskSupportInviteJoinOrgResponse
   */
  async sendMsgByTaskSupportInviteJoinOrgWithOptions(request: SendMsgByTaskSupportInviteJoinOrgRequest, headers: SendMsgByTaskSupportInviteJoinOrgHeaders, runtime: $Util.RuntimeOptions): Promise<SendMsgByTaskSupportInviteJoinOrgResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.messageContent)) {
      body["messageContent"] = request.messageContent;
    }

    if (!Util.isUnset(request.mobilePhones)) {
      body["mobilePhones"] = request.mobilePhones;
    }

    if (!Util.isUnset(request.needUrlTrack)) {
      body["needUrlTrack"] = request.needUrlTrack;
    }

    if (!Util.isUnset(request.openTeamId)) {
      body["openTeamId"] = request.openTeamId;
    }

    if (!Util.isUnset(request.sendChannel)) {
      body["sendChannel"] = request.sendChannel;
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
    let params = new $OpenApi.Params({
      action: "SendMsgByTaskSupportInviteJoinOrg",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customers/tasks/groupSend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMsgByTaskSupportInviteJoinOrgResponse>(await this.execute(params, req, runtime), new SendMsgByTaskSupportInviteJoinOrgResponse({}));
  }

  /**
   * 增强版客户群发
   * 
   * @param request - SendMsgByTaskSupportInviteJoinOrgRequest
   * @returns SendMsgByTaskSupportInviteJoinOrgResponse
   */
  async sendMsgByTaskSupportInviteJoinOrg(request: SendMsgByTaskSupportInviteJoinOrgRequest): Promise<SendMsgByTaskSupportInviteJoinOrgResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMsgByTaskSupportInviteJoinOrgHeaders({ });
    return await this.sendMsgByTaskSupportInviteJoinOrgWithOptions(request, headers, runtime);
  }

  /**
   * 服务群发消息
   * 
   * @param request - SendServiceGroupMessageRequest
   * @param headers - SendServiceGroupMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendServiceGroupMessageResponse
   */
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
    let params = new $OpenApi.Params({
      action: "SendServiceGroupMessage",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendServiceGroupMessageResponse>(await this.execute(params, req, runtime), new SendServiceGroupMessageResponse({}));
  }

  /**
   * 服务群发消息
   * 
   * @param request - SendServiceGroupMessageRequest
   * @returns SendServiceGroupMessageResponse
   */
  async sendServiceGroupMessage(request: SendServiceGroupMessageRequest): Promise<SendServiceGroupMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendServiceGroupMessageHeaders({ });
    return await this.sendServiceGroupMessageWithOptions(request, headers, runtime);
  }

  /**
   * 执行阿里内部用户群组机器人服务开关
   * 
   * @param request - SetRobotConfigRequest
   * @param headers - SetRobotConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SetRobotConfigResponse
   */
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
    let params = new $OpenApi.Params({
      action: "SetRobotConfig",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/configs/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetRobotConfigResponse>(await this.execute(params, req, runtime), new SetRobotConfigResponse({}));
  }

  /**
   * 执行阿里内部用户群组机器人服务开关
   * 
   * @param request - SetRobotConfigRequest
   * @returns SetRobotConfigResponse
   */
  async setRobotConfig(request: SetRobotConfigRequest): Promise<SetRobotConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetRobotConfigHeaders({ });
    return await this.setRobotConfigWithOptions(request, headers, runtime);
  }

  /**
   * 申领工单
   * 
   * @param request - TakeTicketRequest
   * @param headers - TakeTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TakeTicketResponse
   */
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
    let params = new $OpenApi.Params({
      action: "TakeTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/apply`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<TakeTicketResponse>(await this.execute(params, req, runtime), new TakeTicketResponse({}));
  }

  /**
   * 申领工单
   * 
   * @param request - TakeTicketRequest
   * @returns TakeTicketResponse
   */
  async takeTicket(request: TakeTicketRequest): Promise<TakeTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TakeTicketHeaders({ });
    return await this.takeTicketWithOptions(request, headers, runtime);
  }

  /**
   * 客户心声热门话题统计
   * 
   * @param request - TopicStatisticsRequest
   * @param headers - TopicStatisticsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TopicStatisticsResponse
   */
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
    let params = new $OpenApi.Params({
      action: "TopicStatistics",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/voices/topics/statistics`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<TopicStatisticsResponse>(await this.execute(params, req, runtime), new TopicStatisticsResponse({}));
  }

  /**
   * 客户心声热门话题统计
   * 
   * @param request - TopicStatisticsRequest
   * @returns TopicStatisticsResponse
   */
  async topicStatistics(request: TopicStatisticsRequest): Promise<TopicStatisticsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TopicStatisticsHeaders({ });
    return await this.topicStatisticsWithOptions(request, headers, runtime);
  }

  /**
   * 转交工单
   * 
   * @param request - TransferTicketRequest
   * @param headers - TransferTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns TransferTicketResponse
   */
  async transferTicketWithOptions(request: TransferTicketRequest, headers: TransferTicketHeaders, runtime: $Util.RuntimeOptions): Promise<TransferTicketResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.notify)) {
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "TransferTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/transfer`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<TransferTicketResponse>(await this.execute(params, req, runtime), new TransferTicketResponse({}));
  }

  /**
   * 转交工单
   * 
   * @param request - TransferTicketRequest
   * @returns TransferTicketResponse
   */
  async transferTicket(request: TransferTicketRequest): Promise<TransferTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new TransferTicketHeaders({ });
    return await this.transferTicketWithOptions(request, headers, runtime);
  }

  /**
   * 变更群的群组配置信息
   * 
   * @param request - UpdateGroupSetRequest
   * @param headers - UpdateGroupSetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupSetResponse
   */
  async updateGroupSetWithOptions(request: UpdateGroupSetRequest, headers: UpdateGroupSetHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateGroupSetResponse> {
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
      action: "UpdateGroupSet",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/groups/configurations`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateGroupSetResponse>(await this.execute(params, req, runtime), new UpdateGroupSetResponse({}));
  }

  /**
   * 变更群的群组配置信息
   * 
   * @param request - UpdateGroupSetRequest
   * @returns UpdateGroupSetResponse
   */
  async updateGroupSet(request: UpdateGroupSetRequest): Promise<UpdateGroupSetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupSetHeaders({ });
    return await this.updateGroupSetWithOptions(request, headers, runtime);
  }

  /**
   * 更新服务群标签
   * 
   * @param request - UpdateGroupTagRequest
   * @param headers - UpdateGroupTagHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateGroupTagResponse
   */
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
    let params = new $OpenApi.Params({
      action: "UpdateGroupTag",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tags`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateGroupTagResponse>(await this.execute(params, req, runtime), new UpdateGroupTagResponse({}));
  }

  /**
   * 更新服务群标签
   * 
   * @param request - UpdateGroupTagRequest
   * @returns UpdateGroupTagResponse
   */
  async updateGroupTag(request: UpdateGroupTagRequest): Promise<UpdateGroupTagResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateGroupTagHeaders({ });
    return await this.updateGroupTagWithOptions(request, headers, runtime);
  }

  /**
   * 服务群更新表单实例
   * 
   * @param request - UpdateInstanceRequest
   * @param headers - UpdateInstanceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInstanceResponse
   */
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
    let params = new $OpenApi.Params({
      action: "UpdateInstance",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/customForms/instances`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInstanceResponse>(await this.execute(params, req, runtime), new UpdateInstanceResponse({}));
  }

  /**
   * 服务群更新表单实例
   * 
   * @param request - UpdateInstanceRequest
   * @returns UpdateInstanceResponse
   */
  async updateInstance(request: UpdateInstanceRequest): Promise<UpdateInstanceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstanceHeaders({ });
    return await this.updateInstanceWithOptions(request, headers, runtime);
  }

  /**
   * 更新工单自定义字段
   * 
   * @param request - UpdateTicketRequest
   * @param headers - UpdateTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateTicketResponse
   */
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "UpdateTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateTicketResponse>(await this.execute(params, req, runtime), new UpdateTicketResponse({}));
  }

  /**
   * 更新工单自定义字段
   * 
   * @param request - UpdateTicketRequest
   * @returns UpdateTicketResponse
   */
  async updateTicket(request: UpdateTicketRequest): Promise<UpdateTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTicketHeaders({ });
    return await this.updateTicketWithOptions(request, headers, runtime);
  }

  /**
   * 将智能云客服下的旧版服务群升级为钉钉智能服务群
   * 
   * @param request - UpgradeCloudGroupRequest
   * @param headers - UpgradeCloudGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpgradeCloudGroupResponse
   */
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
    let params = new $OpenApi.Params({
      action: "UpgradeCloudGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/cloudGroups/upgrade`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpgradeCloudGroupResponse>(await this.execute(params, req, runtime), new UpgradeCloudGroupResponse({}));
  }

  /**
   * 将智能云客服下的旧版服务群升级为钉钉智能服务群
   * 
   * @param request - UpgradeCloudGroupRequest
   * @returns UpgradeCloudGroupResponse
   */
  async upgradeCloudGroup(request: UpgradeCloudGroupRequest): Promise<UpgradeCloudGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeCloudGroupHeaders({ });
    return await this.upgradeCloudGroupWithOptions(request, headers, runtime);
  }

  /**
   * 将常规钉群升级为钉钉智能服务群
   * 
   * @param request - UpgradeNormalGroupRequest
   * @param headers - UpgradeNormalGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpgradeNormalGroupResponse
   */
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
    let params = new $OpenApi.Params({
      action: "UpgradeNormalGroup",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/normalGroups/upgrade`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpgradeNormalGroupResponse>(await this.execute(params, req, runtime), new UpgradeNormalGroupResponse({}));
  }

  /**
   * 将常规钉群升级为钉钉智能服务群
   * 
   * @param request - UpgradeNormalGroupRequest
   * @returns UpgradeNormalGroupResponse
   */
  async upgradeNormalGroup(request: UpgradeNormalGroupRequest): Promise<UpgradeNormalGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpgradeNormalGroupHeaders({ });
    return await this.upgradeNormalGroupWithOptions(request, headers, runtime);
  }

  /**
   * 工单催办
   * 
   * @param request - UrgeTicketRequest
   * @param headers - UrgeTicketHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UrgeTicketResponse
   */
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

    if (!Util.isUnset(request.ticketMemo)) {
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
    let params = new $OpenApi.Params({
      action: "UrgeTicket",
      version: "serviceGroup_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/serviceGroup/tickets/urge`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UrgeTicketResponse>(await this.execute(params, req, runtime), new UrgeTicketResponse({}));
  }

  /**
   * 工单催办
   * 
   * @param request - UrgeTicketRequest
   * @returns UrgeTicketResponse
   */
  async urgeTicket(request: UrgeTicketRequest): Promise<UrgeTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UrgeTicketHeaders({ });
    return await this.urgeTicketWithOptions(request, headers, runtime);
  }

}
