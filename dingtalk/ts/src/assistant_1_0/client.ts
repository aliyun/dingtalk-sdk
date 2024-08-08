// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class AddDomainWordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDomainWordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  domainWords?: AddDomainWordsRequestDomainWords[];
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      domainWords: 'domainWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      domainWords: { 'type': 'array', 'itemType': AddDomainWordsRequestDomainWords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDomainWordsResponseBody extends $tea.Model {
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

export class AddDomainWordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: AddDomainWordsResponseBody;
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
      body: AddDomainWordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  metadata?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  role?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      metadata: 'metadata',
      role: 'role',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      role: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantMessageResponseBody extends $tea.Model {
  assistantId?: string;
  content?: any[];
  createdAt?: number;
  id?: string;
  metadata?: { [key: string]: any };
  object?: string;
  role?: string;
  runId?: string;
  threadId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      content: 'content',
      createdAt: 'createdAt',
      id: 'id',
      metadata: 'metadata',
      object: 'object',
      role: 'role',
      runId: 'runId',
      threadId: 'threadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      content: { 'type': 'array', 'itemType': 'any' },
      createdAt: 'number',
      id: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
      role: 'string',
      runId: 'string',
      threadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAssistantMessageResponseBody;
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
      body: CreateAssistantMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantRunHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantRunRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  instructions?: string;
  metadata?: { [key: string]: any };
  stream?: boolean;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      instructions: 'instructions',
      metadata: 'metadata',
      stream: 'stream',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      instructions: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      stream: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantRunResponseBody extends $tea.Model {
  assistantId?: string;
  cancelledAt?: number;
  completedAt?: number;
  createdAt?: number;
  expiresAt?: number;
  failedAt?: number;
  id?: string;
  lastErrorMsg?: string;
  metadata?: { [key: string]: any };
  object?: string;
  startedAt?: number;
  status?: string;
  threadId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      cancelledAt: 'cancelledAt',
      completedAt: 'completedAt',
      createdAt: 'createdAt',
      expiresAt: 'expiresAt',
      failedAt: 'failedAt',
      id: 'id',
      lastErrorMsg: 'lastErrorMsg',
      metadata: 'metadata',
      object: 'object',
      startedAt: 'startedAt',
      status: 'status',
      threadId: 'threadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      cancelledAt: 'number',
      completedAt: 'number',
      createdAt: 'number',
      expiresAt: 'number',
      failedAt: 'number',
      id: 'string',
      lastErrorMsg: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
      startedAt: 'number',
      status: 'string',
      threadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantRunResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAssistantRunResponseBody;
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
      body: CreateAssistantRunResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantThreadHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantThreadRequest extends $tea.Model {
  /**
   * **if can be null:**
   * true
   */
  metadata?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      metadata: 'metadata',
    };
  }

  static types(): { [key: string]: any } {
    return {
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantThreadResponseBody extends $tea.Model {
  createdAt?: number;
  id?: string;
  metadata?: { [key: string]: any };
  object?: string;
  static names(): { [key: string]: string } {
    return {
      createdAt: 'createdAt',
      id: 'id',
      metadata: 'metadata',
      object: 'object',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdAt: 'number',
      id: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAssistantThreadResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAssistantThreadResponseBody;
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
      body: CreateAssistantThreadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAssistantMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAssistantMessageResponseBody extends $tea.Model {
  deleted?: boolean;
  id?: string;
  object?: string;
  static names(): { [key: string]: string } {
    return {
      deleted: 'deleted',
      id: 'id',
      object: 'object',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deleted: 'boolean',
      id: 'string',
      object: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAssistantMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteAssistantMessageResponseBody;
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
      body: DeleteAssistantMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAssistantThreadHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAssistantThreadResponseBody extends $tea.Model {
  deleted?: boolean;
  id?: string;
  object?: string;
  static names(): { [key: string]: string } {
    return {
      deleted: 'deleted',
      id: 'id',
      object: 'object',
    };
  }

  static types(): { [key: string]: any } {
    return {
      deleted: 'boolean',
      id: 'string',
      object: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteAssistantThreadResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteAssistantThreadResponseBody;
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
      body: DeleteAssistantThreadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainWordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainWordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  domainWords?: DeleteDomainWordsRequestDomainWords[];
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      domainWords: 'domainWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      domainWords: { 'type': 'array', 'itemType': DeleteDomainWordsRequestDomainWords },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainWordsResponseBody extends $tea.Model {
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

export class DeleteDomainWordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteDomainWordsResponseBody;
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
      body: DeleteDomainWordsResponseBody,
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
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  studyId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      studyId: 'studyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      studyId: 'string',
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

export class GetAskDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  endTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  offset?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  startTime?: number;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      endTime: 'endTime',
      offset: 'offset',
      pageSize: 'pageSize',
      startTime: 'startTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      endTime: 'number',
      offset: 'number',
      pageSize: 'number',
      startTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBody extends $tea.Model {
  result?: GetAskDetailResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetAskDetailResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAskDetailResponseBody;
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
      body: GetAskDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainWordsHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainWordsRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainWordsResponseBody extends $tea.Model {
  result?: string[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDomainWordsResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetDomainWordsResponseBody;
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
      body: GetDomainWordsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListRequest extends $tea.Model {
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListResponseBody extends $tea.Model {
  result?: GetKnowledgeListResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetKnowledgeListResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetKnowledgeListResponseBody;
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
      body: GetKnowledgeListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAssistantHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAssistantRequest extends $tea.Model {
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallAssistantResponseBody extends $tea.Model {
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

export class InstallAssistantResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InstallAssistantResponseBody;
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
      body: InstallAssistantResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LearnKnowledgeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LearnKnowledgeRequest extends $tea.Model {
  assistantId?: string;
  docUrl?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      docUrl: 'docUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      docUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LearnKnowledgeResponseBody extends $tea.Model {
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

export class LearnKnowledgeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LearnKnowledgeResponseBody;
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
      body: LearnKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantRequest extends $tea.Model {
  cursor?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      cursor: 'cursor',
      pageSize: 'pageSize',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cursor: 'number',
      pageSize: 'number',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: ListAssistantResponseBodyList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': ListAssistantResponseBodyList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAssistantResponseBody;
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
      body: ListAssistantResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantMessageRequest extends $tea.Model {
  limit?: number;
  order?: string;
  runId?: string;
  static names(): { [key: string]: string } {
    return {
      limit: 'limit',
      order: 'order',
      runId: 'runId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      limit: 'number',
      order: 'string',
      runId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantMessageResponseBody extends $tea.Model {
  data?: ListAssistantMessageResponseBodyData[];
  object?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      object: 'object',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': ListAssistantMessageResponseBodyData },
      object: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAssistantMessageResponseBody;
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
      body: ListAssistantMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantRunHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantRunRequest extends $tea.Model {
  limit?: number;
  order?: string;
  static names(): { [key: string]: string } {
    return {
      limit: 'limit',
      order: 'order',
    };
  }

  static types(): { [key: string]: any } {
    return {
      limit: 'number',
      order: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantRunResponseBody extends $tea.Model {
  data?: ListAssistantRunResponseBodyData[];
  object?: string;
  static names(): { [key: string]: string } {
    return {
      data: 'data',
      object: 'object',
    };
  }

  static types(): { [key: string]: any } {
    return {
      data: { 'type': 'array', 'itemType': ListAssistantRunResponseBodyData },
      object: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantRunResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ListAssistantRunResponseBody;
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
      body: ListAssistantRunResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelearnKnowledgeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelearnKnowledgeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RelearnKnowledgeResponseBody extends $tea.Model {
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

export class RelearnKnowledgeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RelearnKnowledgeResponseBody;
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
      body: RelearnKnowledgeResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantBasicInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantBasicInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantBasicInfoResponseBody extends $tea.Model {
  actionNames?: string[];
  assistantId?: string;
  createdAt?: number;
  creatorUnionId?: string;
  description?: string;
  fallbackContent?: string;
  icon?: string;
  instructions?: string;
  knowledgeFileNames?: string[];
  model?: string;
  name?: string;
  recommendPrompts?: string[];
  unifiedAppId?: string;
  welcomeContent?: string;
  static names(): { [key: string]: string } {
    return {
      actionNames: 'actionNames',
      assistantId: 'assistantId',
      createdAt: 'createdAt',
      creatorUnionId: 'creatorUnionId',
      description: 'description',
      fallbackContent: 'fallbackContent',
      icon: 'icon',
      instructions: 'instructions',
      knowledgeFileNames: 'knowledgeFileNames',
      model: 'model',
      name: 'name',
      recommendPrompts: 'recommendPrompts',
      unifiedAppId: 'unifiedAppId',
      welcomeContent: 'welcomeContent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionNames: { 'type': 'array', 'itemType': 'string' },
      assistantId: 'string',
      createdAt: 'number',
      creatorUnionId: 'string',
      description: 'string',
      fallbackContent: 'string',
      icon: 'string',
      instructions: 'string',
      knowledgeFileNames: { 'type': 'array', 'itemType': 'string' },
      model: 'string',
      name: 'string',
      recommendPrompts: { 'type': 'array', 'itemType': 'string' },
      unifiedAppId: 'string',
      welcomeContent: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantBasicInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RetrieveAssistantBasicInfoResponseBody;
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
      body: RetrieveAssistantBasicInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantMessageResponseBody extends $tea.Model {
  assisantId?: string;
  content?: any[];
  createdAt?: number;
  id?: string;
  metadata?: { [key: string]: any };
  object?: string;
  role?: string;
  runId?: string;
  threadId?: string;
  static names(): { [key: string]: string } {
    return {
      assisantId: 'assisantId',
      content: 'content',
      createdAt: 'createdAt',
      id: 'id',
      metadata: 'metadata',
      object: 'object',
      role: 'role',
      runId: 'runId',
      threadId: 'threadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assisantId: 'string',
      content: { 'type': 'array', 'itemType': 'any' },
      createdAt: 'number',
      id: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
      role: 'string',
      runId: 'string',
      threadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RetrieveAssistantMessageResponseBody;
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
      body: RetrieveAssistantMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantRunHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantRunResponseBody extends $tea.Model {
  assistantId?: string;
  cancelledAt?: number;
  completedAt?: number;
  createdAt?: number;
  expiresAt?: number;
  failedAt?: number;
  id?: string;
  lastErrorMsg?: string;
  metadata?: { [key: string]: any };
  object?: string;
  startedAt?: number;
  status?: string;
  threadId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      cancelledAt: 'cancelledAt',
      completedAt: 'completedAt',
      createdAt: 'createdAt',
      expiresAt: 'expiresAt',
      failedAt: 'failedAt',
      id: 'id',
      lastErrorMsg: 'lastErrorMsg',
      metadata: 'metadata',
      object: 'object',
      startedAt: 'startedAt',
      status: 'status',
      threadId: 'threadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      cancelledAt: 'number',
      completedAt: 'number',
      createdAt: 'number',
      expiresAt: 'number',
      failedAt: 'number',
      id: 'string',
      lastErrorMsg: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
      startedAt: 'number',
      status: 'string',
      threadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantRunResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RetrieveAssistantRunResponseBody;
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
      body: RetrieveAssistantRunResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantThreadHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantThreadResponseBody extends $tea.Model {
  createdAt?: number;
  id?: string;
  metadata?: { [key: string]: any };
  object?: string;
  static names(): { [key: string]: string } {
    return {
      createdAt: 'createdAt',
      id: 'id',
      metadata: 'metadata',
      object: 'object',
    };
  }

  static types(): { [key: string]: any } {
    return {
      createdAt: 'number',
      id: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RetrieveAssistantThreadResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RetrieveAssistantThreadResponseBody;
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
      body: RetrieveAssistantThreadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAssistantScopeHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAssistantScopeRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  assistantId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operatorUnionId?: string;
  sharing?: boolean;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      operatorUnionId: 'operatorUnionId',
      sharing: 'sharing',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      operatorUnionId: 'string',
      sharing: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateAssistantScopeResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: any;
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
      body: 'any',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddDomainWordsRequestDomainWords extends $tea.Model {
  description?: string;
  domainWord?: string;
  formalWords?: string[];
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      domainWord: 'domainWord',
      formalWords: 'formalWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      domainWord: 'string',
      formalWords: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteDomainWordsRequestDomainWords extends $tea.Model {
  description?: string;
  domainWord?: string;
  formalWords?: string[];
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      domainWord: 'domainWord',
      formalWords: 'formalWords',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      domainWord: 'string',
      formalWords: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBodyResultListReferences extends $tea.Model {
  name?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBodyResultList extends $tea.Model {
  answer?: string;
  answerResult?: string;
  commentTags?: string[];
  isMarkResolved?: boolean;
  nick?: string;
  question?: string;
  references?: GetAskDetailResponseBodyResultListReferences[];
  time?: number;
  static names(): { [key: string]: string } {
    return {
      answer: 'answer',
      answerResult: 'answerResult',
      commentTags: 'commentTags',
      isMarkResolved: 'isMarkResolved',
      nick: 'nick',
      question: 'question',
      references: 'references',
      time: 'time',
    };
  }

  static types(): { [key: string]: any } {
    return {
      answer: 'string',
      answerResult: 'string',
      commentTags: { 'type': 'array', 'itemType': 'string' },
      isMarkResolved: 'boolean',
      nick: 'string',
      question: 'string',
      references: { 'type': 'array', 'itemType': GetAskDetailResponseBodyResultListReferences },
      time: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAskDetailResponseBodyResult extends $tea.Model {
  hasMore?: boolean;
  list?: GetAskDetailResponseBodyResultList[];
  nextCursor?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextCursor: 'nextCursor',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': GetAskDetailResponseBodyResultList },
      nextCursor: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetKnowledgeListResponseBodyResult extends $tea.Model {
  docFormat?: string;
  docName?: string;
  docUrl?: string;
  status?: string;
  studyId?: string;
  static names(): { [key: string]: string } {
    return {
      docFormat: 'docFormat',
      docName: 'docName',
      docUrl: 'docUrl',
      status: 'status',
      studyId: 'studyId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      docFormat: 'string',
      docName: 'string',
      docUrl: 'string',
      status: 'string',
      studyId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantResponseBodyList extends $tea.Model {
  assistantId?: string;
  createdAt?: number;
  creatorUnionId?: string;
  description?: string;
  icon?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      createdAt: 'createdAt',
      creatorUnionId: 'creatorUnionId',
      description: 'description',
      icon: 'icon',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      createdAt: 'number',
      creatorUnionId: 'string',
      description: 'string',
      icon: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantMessageResponseBodyData extends $tea.Model {
  assistantId?: string;
  content?: any[];
  createdAt?: number;
  id?: string;
  metadata?: { [key: string]: any };
  object?: string;
  role?: string;
  runId?: string;
  threadId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      content: 'content',
      createdAt: 'createdAt',
      id: 'id',
      metadata: 'metadata',
      object: 'object',
      role: 'role',
      runId: 'runId',
      threadId: 'threadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      content: { 'type': 'array', 'itemType': 'any' },
      createdAt: 'number',
      id: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
      role: 'string',
      runId: 'string',
      threadId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListAssistantRunResponseBodyData extends $tea.Model {
  assistantId?: string;
  cancelledAt?: number;
  completedAt?: number;
  createdAt?: number;
  expiresAt?: number;
  failedAt?: number;
  id?: string;
  lastErrorMsg?: string;
  metadata?: { [key: string]: any };
  object?: string;
  startedAt?: number;
  status?: string;
  threadId?: string;
  static names(): { [key: string]: string } {
    return {
      assistantId: 'assistantId',
      cancelledAt: 'cancelledAt',
      completedAt: 'completedAt',
      createdAt: 'createdAt',
      expiresAt: 'expiresAt',
      failedAt: 'failedAt',
      id: 'id',
      lastErrorMsg: 'lastErrorMsg',
      metadata: 'metadata',
      object: 'object',
      startedAt: 'startedAt',
      status: 'status',
      threadId: 'threadId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      assistantId: 'string',
      cancelledAt: 'number',
      completedAt: 'number',
      createdAt: 'number',
      expiresAt: 'number',
      failedAt: 'number',
      id: 'string',
      lastErrorMsg: 'string',
      metadata: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      object: 'string',
      startedAt: 'number',
      status: 'string',
      threadId: 'string',
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
   * 助理添加专业词汇
   * 
   * @param request - AddDomainWordsRequest
   * @param headers - AddDomainWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddDomainWordsResponse
   */
  async addDomainWordsWithOptions(request: AddDomainWordsRequest, headers: AddDomainWordsHeaders, runtime: $Util.RuntimeOptions): Promise<AddDomainWordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.domainWords)) {
      body["domainWords"] = request.domainWords;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "AddDomainWords",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/domainWords`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AddDomainWordsResponse>(await this.execute(params, req, runtime), new AddDomainWordsResponse({}));
  }

  /**
   * 助理添加专业词汇
   * 
   * @param request - AddDomainWordsRequest
   * @returns AddDomainWordsResponse
   */
  async addDomainWords(request: AddDomainWordsRequest): Promise<AddDomainWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddDomainWordsHeaders({ });
    return await this.addDomainWordsWithOptions(request, headers, runtime);
  }

  /**
   * 创建AI助理的消息体
   * 
   * @param request - CreateAssistantMessageRequest
   * @param headers - CreateAssistantMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateAssistantMessageResponse
   */
  async createAssistantMessageWithOptions(threadId: string, request: CreateAssistantMessageRequest, headers: CreateAssistantMessageHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAssistantMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.metadata)) {
      body["metadata"] = request.metadata;
    }

    if (!Util.isUnset(request.role)) {
      body["role"] = request.role;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "CreateAssistantMessage",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}/messages`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAssistantMessageResponse>(await this.execute(params, req, runtime), new CreateAssistantMessageResponse({}));
  }

  /**
   * 创建AI助理的消息体
   * 
   * @param request - CreateAssistantMessageRequest
   * @returns CreateAssistantMessageResponse
   */
  async createAssistantMessage(threadId: string, request: CreateAssistantMessageRequest): Promise<CreateAssistantMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAssistantMessageHeaders({ });
    return await this.createAssistantMessageWithOptions(threadId, request, headers, runtime);
  }

  /**
   * 创建AI助理的运行任务
   * 
   * @param request - CreateAssistantRunRequest
   * @param headers - CreateAssistantRunHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateAssistantRunResponse
   */
  async createAssistantRunWithOptions(threadId: string, request: CreateAssistantRunRequest, headers: CreateAssistantRunHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAssistantRunResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.instructions)) {
      body["instructions"] = request.instructions;
    }

    if (!Util.isUnset(request.metadata)) {
      body["metadata"] = request.metadata;
    }

    if (!Util.isUnset(request.stream)) {
      body["stream"] = request.stream;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "CreateAssistantRun",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}/runs`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAssistantRunResponse>(await this.execute(params, req, runtime), new CreateAssistantRunResponse({}));
  }

  /**
   * 创建AI助理的运行任务
   * 
   * @param request - CreateAssistantRunRequest
   * @returns CreateAssistantRunResponse
   */
  async createAssistantRun(threadId: string, request: CreateAssistantRunRequest): Promise<CreateAssistantRunResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAssistantRunHeaders({ });
    return await this.createAssistantRunWithOptions(threadId, request, headers, runtime);
  }

  /**
   * 创建AI助理线程实例
   * 
   * @param request - CreateAssistantThreadRequest
   * @param headers - CreateAssistantThreadHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateAssistantThreadResponse
   */
  async createAssistantThreadWithOptions(request: CreateAssistantThreadRequest, headers: CreateAssistantThreadHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAssistantThreadResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.metadata)) {
      body["metadata"] = request.metadata;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "CreateAssistantThread",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateAssistantThreadResponse>(await this.execute(params, req, runtime), new CreateAssistantThreadResponse({}));
  }

  /**
   * 创建AI助理线程实例
   * 
   * @param request - CreateAssistantThreadRequest
   * @returns CreateAssistantThreadResponse
   */
  async createAssistantThread(request: CreateAssistantThreadRequest): Promise<CreateAssistantThreadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAssistantThreadHeaders({ });
    return await this.createAssistantThreadWithOptions(request, headers, runtime);
  }

  /**
   * 删除AI助理的消息体
   * 
   * @param headers - DeleteAssistantMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteAssistantMessageResponse
   */
  async deleteAssistantMessageWithOptions(threadId: string, messageId: string, headers: DeleteAssistantMessageHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAssistantMessageResponse> {
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
      action: "DeleteAssistantMessage",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}/messages/${messageId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteAssistantMessageResponse>(await this.execute(params, req, runtime), new DeleteAssistantMessageResponse({}));
  }

  /**
   * 删除AI助理的消息体
   * @returns DeleteAssistantMessageResponse
   */
  async deleteAssistantMessage(threadId: string, messageId: string): Promise<DeleteAssistantMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAssistantMessageHeaders({ });
    return await this.deleteAssistantMessageWithOptions(threadId, messageId, headers, runtime);
  }

  /**
   * 删除AI助理线程实例
   * 
   * @param headers - DeleteAssistantThreadHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteAssistantThreadResponse
   */
  async deleteAssistantThreadWithOptions(threadId: string, headers: DeleteAssistantThreadHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteAssistantThreadResponse> {
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
      action: "DeleteAssistantThread",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteAssistantThreadResponse>(await this.execute(params, req, runtime), new DeleteAssistantThreadResponse({}));
  }

  /**
   * 删除AI助理线程实例
   * @returns DeleteAssistantThreadResponse
   */
  async deleteAssistantThread(threadId: string): Promise<DeleteAssistantThreadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteAssistantThreadHeaders({ });
    return await this.deleteAssistantThreadWithOptions(threadId, headers, runtime);
  }

  /**
   * 助理删除专业词汇
   * 
   * @param request - DeleteDomainWordsRequest
   * @param headers - DeleteDomainWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteDomainWordsResponse
   */
  async deleteDomainWordsWithOptions(request: DeleteDomainWordsRequest, headers: DeleteDomainWordsHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteDomainWordsResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.domainWords)) {
      body["domainWords"] = request.domainWords;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "DeleteDomainWords",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/domainWords/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteDomainWordsResponse>(await this.execute(params, req, runtime), new DeleteDomainWordsResponse({}));
  }

  /**
   * 助理删除专业词汇
   * 
   * @param request - DeleteDomainWordsRequest
   * @returns DeleteDomainWordsResponse
   */
  async deleteDomainWords(request: DeleteDomainWordsRequest): Promise<DeleteDomainWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteDomainWordsHeaders({ });
    return await this.deleteDomainWordsWithOptions(request, headers, runtime);
  }

  /**
   * 删除助理知识
   * 
   * @param request - DeleteKnowledgeRequest
   * @param headers - DeleteKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteKnowledgeResponse
   */
  async deleteKnowledgeWithOptions(request: DeleteKnowledgeRequest, headers: DeleteKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteKnowledgeResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.studyId)) {
      query["studyId"] = request.studyId;
    }

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
      action: "DeleteKnowledge",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/items`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteKnowledgeResponse>(await this.execute(params, req, runtime), new DeleteKnowledgeResponse({}));
  }

  /**
   * 删除助理知识
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
   * 获取助理问答明细
   * 
   * @param request - GetAskDetailRequest
   * @param headers - GetAskDetailHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAskDetailResponse
   */
  async getAskDetailWithOptions(request: GetAskDetailRequest, headers: GetAskDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetAskDetailResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.offset)) {
      query["offset"] = request.offset;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

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
      action: "GetAskDetail",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/askDetails`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAskDetailResponse>(await this.execute(params, req, runtime), new GetAskDetailResponse({}));
  }

  /**
   * 获取助理问答明细
   * 
   * @param request - GetAskDetailRequest
   * @returns GetAskDetailResponse
   */
  async getAskDetail(request: GetAskDetailRequest): Promise<GetAskDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAskDetailHeaders({ });
    return await this.getAskDetailWithOptions(request, headers, runtime);
  }

  /**
   * 获取助理专业词汇
   * 
   * @param request - GetDomainWordsRequest
   * @param headers - GetDomainWordsHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetDomainWordsResponse
   */
  async getDomainWordsWithOptions(request: GetDomainWordsRequest, headers: GetDomainWordsHeaders, runtime: $Util.RuntimeOptions): Promise<GetDomainWordsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
    }

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
      action: "GetDomainWords",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/domainWords`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetDomainWordsResponse>(await this.execute(params, req, runtime), new GetDomainWordsResponse({}));
  }

  /**
   * 获取助理专业词汇
   * 
   * @param request - GetDomainWordsRequest
   * @returns GetDomainWordsResponse
   */
  async getDomainWords(request: GetDomainWordsRequest): Promise<GetDomainWordsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDomainWordsHeaders({ });
    return await this.getDomainWordsWithOptions(request, headers, runtime);
  }

  /**
   * 获取助理知识列表
   * 
   * @param request - GetKnowledgeListRequest
   * @param headers - GetKnowledgeListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetKnowledgeListResponse
   */
  async getKnowledgeListWithOptions(request: GetKnowledgeListRequest, headers: GetKnowledgeListHeaders, runtime: $Util.RuntimeOptions): Promise<GetKnowledgeListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
    }

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
      action: "GetKnowledgeList",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/items`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetKnowledgeListResponse>(await this.execute(params, req, runtime), new GetKnowledgeListResponse({}));
  }

  /**
   * 获取助理知识列表
   * 
   * @param request - GetKnowledgeListRequest
   * @returns GetKnowledgeListResponse
   */
  async getKnowledgeList(request: GetKnowledgeListRequest): Promise<GetKnowledgeListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetKnowledgeListHeaders({ });
    return await this.getKnowledgeListWithOptions(request, headers, runtime);
  }

  /**
   * 安装助理
   * 
   * @param request - InstallAssistantRequest
   * @param headers - InstallAssistantHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns InstallAssistantResponse
   */
  async installAssistantWithOptions(request: InstallAssistantRequest, headers: InstallAssistantHeaders, runtime: $Util.RuntimeOptions): Promise<InstallAssistantResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "InstallAssistant",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/install`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallAssistantResponse>(await this.execute(params, req, runtime), new InstallAssistantResponse({}));
  }

  /**
   * 安装助理
   * 
   * @param request - InstallAssistantRequest
   * @returns InstallAssistantResponse
   */
  async installAssistant(request: InstallAssistantRequest): Promise<InstallAssistantResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallAssistantHeaders({ });
    return await this.installAssistantWithOptions(request, headers, runtime);
  }

  /**
   * 助理学习知识
   * 
   * @param request - LearnKnowledgeRequest
   * @param headers - LearnKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LearnKnowledgeResponse
   */
  async learnKnowledgeWithOptions(request: LearnKnowledgeRequest, headers: LearnKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<LearnKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.docUrl)) {
      body["docUrl"] = request.docUrl;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "LearnKnowledge",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/items`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LearnKnowledgeResponse>(await this.execute(params, req, runtime), new LearnKnowledgeResponse({}));
  }

  /**
   * 助理学习知识
   * 
   * @param request - LearnKnowledgeRequest
   * @returns LearnKnowledgeResponse
   */
  async learnKnowledge(request: LearnKnowledgeRequest): Promise<LearnKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LearnKnowledgeHeaders({ });
    return await this.learnKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * 获取AI助理列表
   * 
   * @param request - ListAssistantRequest
   * @param headers - ListAssistantHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAssistantResponse
   */
  async listAssistantWithOptions(request: ListAssistantRequest, headers: ListAssistantHeaders, runtime: $Util.RuntimeOptions): Promise<ListAssistantResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cursor)) {
      query["cursor"] = request.cursor;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

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
      action: "ListAssistant",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/list`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAssistantResponse>(await this.execute(params, req, runtime), new ListAssistantResponse({}));
  }

  /**
   * 获取AI助理列表
   * 
   * @param request - ListAssistantRequest
   * @returns ListAssistantResponse
   */
  async listAssistant(request: ListAssistantRequest): Promise<ListAssistantResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAssistantHeaders({ });
    return await this.listAssistantWithOptions(request, headers, runtime);
  }

  /**
   * 获取AI助理消息列表
   * 
   * @param request - ListAssistantMessageRequest
   * @param headers - ListAssistantMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAssistantMessageResponse
   */
  async listAssistantMessageWithOptions(threadId: string, request: ListAssistantMessageRequest, headers: ListAssistantMessageHeaders, runtime: $Util.RuntimeOptions): Promise<ListAssistantMessageResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.limit)) {
      query["limit"] = request.limit;
    }

    if (!Util.isUnset(request.order)) {
      query["order"] = request.order;
    }

    if (!Util.isUnset(request.runId)) {
      query["runId"] = request.runId;
    }

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
      action: "ListAssistantMessage",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}/messages`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAssistantMessageResponse>(await this.execute(params, req, runtime), new ListAssistantMessageResponse({}));
  }

  /**
   * 获取AI助理消息列表
   * 
   * @param request - ListAssistantMessageRequest
   * @returns ListAssistantMessageResponse
   */
  async listAssistantMessage(threadId: string, request: ListAssistantMessageRequest): Promise<ListAssistantMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAssistantMessageHeaders({ });
    return await this.listAssistantMessageWithOptions(threadId, request, headers, runtime);
  }

  /**
   * 获取AI助理的运行任务的列表
   * 
   * @param request - ListAssistantRunRequest
   * @param headers - ListAssistantRunHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ListAssistantRunResponse
   */
  async listAssistantRunWithOptions(threadId: string, request: ListAssistantRunRequest, headers: ListAssistantRunHeaders, runtime: $Util.RuntimeOptions): Promise<ListAssistantRunResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.limit)) {
      query["limit"] = request.limit;
    }

    if (!Util.isUnset(request.order)) {
      query["order"] = request.order;
    }

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
      action: "ListAssistantRun",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}/runs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListAssistantRunResponse>(await this.execute(params, req, runtime), new ListAssistantRunResponse({}));
  }

  /**
   * 获取AI助理的运行任务的列表
   * 
   * @param request - ListAssistantRunRequest
   * @returns ListAssistantRunResponse
   */
  async listAssistantRun(threadId: string, request: ListAssistantRunRequest): Promise<ListAssistantRunResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListAssistantRunHeaders({ });
    return await this.listAssistantRunWithOptions(threadId, request, headers, runtime);
  }

  /**
   * 助理学习增量知识
   * 
   * @param request - RelearnKnowledgeRequest
   * @param headers - RelearnKnowledgeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RelearnKnowledgeResponse
   */
  async relearnKnowledgeWithOptions(request: RelearnKnowledgeRequest, headers: RelearnKnowledgeHeaders, runtime: $Util.RuntimeOptions): Promise<RelearnKnowledgeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "RelearnKnowledge",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/knowledges/incrLearning`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RelearnKnowledgeResponse>(await this.execute(params, req, runtime), new RelearnKnowledgeResponse({}));
  }

  /**
   * 助理学习增量知识
   * 
   * @param request - RelearnKnowledgeRequest
   * @returns RelearnKnowledgeResponse
   */
  async relearnKnowledge(request: RelearnKnowledgeRequest): Promise<RelearnKnowledgeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RelearnKnowledgeHeaders({ });
    return await this.relearnKnowledgeWithOptions(request, headers, runtime);
  }

  /**
   * 查询 AI 助理的基本信息
   * 
   * @param request - RetrieveAssistantBasicInfoRequest
   * @param headers - RetrieveAssistantBasicInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RetrieveAssistantBasicInfoResponse
   */
  async retrieveAssistantBasicInfoWithOptions(request: RetrieveAssistantBasicInfoRequest, headers: RetrieveAssistantBasicInfoHeaders, runtime: $Util.RuntimeOptions): Promise<RetrieveAssistantBasicInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      query["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
    }

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
      action: "RetrieveAssistantBasicInfo",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/basicInfo`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RetrieveAssistantBasicInfoResponse>(await this.execute(params, req, runtime), new RetrieveAssistantBasicInfoResponse({}));
  }

  /**
   * 查询 AI 助理的基本信息
   * 
   * @param request - RetrieveAssistantBasicInfoRequest
   * @returns RetrieveAssistantBasicInfoResponse
   */
  async retrieveAssistantBasicInfo(request: RetrieveAssistantBasicInfoRequest): Promise<RetrieveAssistantBasicInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetrieveAssistantBasicInfoHeaders({ });
    return await this.retrieveAssistantBasicInfoWithOptions(request, headers, runtime);
  }

  /**
   * 获取AI助理的消息体
   * 
   * @param headers - RetrieveAssistantMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RetrieveAssistantMessageResponse
   */
  async retrieveAssistantMessageWithOptions(threadId: string, messageId: string, headers: RetrieveAssistantMessageHeaders, runtime: $Util.RuntimeOptions): Promise<RetrieveAssistantMessageResponse> {
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
      action: "RetrieveAssistantMessage",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}/messages/${messageId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RetrieveAssistantMessageResponse>(await this.execute(params, req, runtime), new RetrieveAssistantMessageResponse({}));
  }

  /**
   * 获取AI助理的消息体
   * @returns RetrieveAssistantMessageResponse
   */
  async retrieveAssistantMessage(threadId: string, messageId: string): Promise<RetrieveAssistantMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetrieveAssistantMessageHeaders({ });
    return await this.retrieveAssistantMessageWithOptions(threadId, messageId, headers, runtime);
  }

  /**
   * 检索AI助理的运行任务
   * 
   * @param headers - RetrieveAssistantRunHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RetrieveAssistantRunResponse
   */
  async retrieveAssistantRunWithOptions(threadId: string, runId: string, headers: RetrieveAssistantRunHeaders, runtime: $Util.RuntimeOptions): Promise<RetrieveAssistantRunResponse> {
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
      action: "RetrieveAssistantRun",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}/runs/${runId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RetrieveAssistantRunResponse>(await this.execute(params, req, runtime), new RetrieveAssistantRunResponse({}));
  }

  /**
   * 检索AI助理的运行任务
   * @returns RetrieveAssistantRunResponse
   */
  async retrieveAssistantRun(threadId: string, runId: string): Promise<RetrieveAssistantRunResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetrieveAssistantRunHeaders({ });
    return await this.retrieveAssistantRunWithOptions(threadId, runId, headers, runtime);
  }

  /**
   * 检索AI助理线程实例
   * 
   * @param headers - RetrieveAssistantThreadHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RetrieveAssistantThreadResponse
   */
  async retrieveAssistantThreadWithOptions(threadId: string, headers: RetrieveAssistantThreadHeaders, runtime: $Util.RuntimeOptions): Promise<RetrieveAssistantThreadResponse> {
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
      action: "RetrieveAssistantThread",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/threads/${threadId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RetrieveAssistantThreadResponse>(await this.execute(params, req, runtime), new RetrieveAssistantThreadResponse({}));
  }

  /**
   * 检索AI助理线程实例
   * @returns RetrieveAssistantThreadResponse
   */
  async retrieveAssistantThread(threadId: string): Promise<RetrieveAssistantThreadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RetrieveAssistantThreadHeaders({ });
    return await this.retrieveAssistantThreadWithOptions(threadId, headers, runtime);
  }

  /**
   * 更新 AI 助理使用范围
   * 
   * @param request - UpdateAssistantScopeRequest
   * @param headers - UpdateAssistantScopeHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateAssistantScopeResponse
   */
  async updateAssistantScopeWithOptions(request: UpdateAssistantScopeRequest, headers: UpdateAssistantScopeHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateAssistantScopeResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.assistantId)) {
      body["assistantId"] = request.assistantId;
    }

    if (!Util.isUnset(request.operatorUnionId)) {
      body["operatorUnionId"] = request.operatorUnionId;
    }

    if (!Util.isUnset(request.sharing)) {
      body["sharing"] = request.sharing;
    }

    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
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
      action: "UpdateAssistantScope",
      version: "assistant_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/assistant/scope`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "any",
    });
    return $tea.cast<UpdateAssistantScopeResponse>(await this.execute(params, req, runtime), new UpdateAssistantScopeResponse({}));
  }

  /**
   * 更新 AI 助理使用范围
   * 
   * @param request - UpdateAssistantScopeRequest
   * @returns UpdateAssistantScopeResponse
   */
  async updateAssistantScope(request: UpdateAssistantScopeRequest): Promise<UpdateAssistantScopeResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateAssistantScopeHeaders({ });
    return await this.updateAssistantScopeWithOptions(request, headers, runtime);
  }

}
