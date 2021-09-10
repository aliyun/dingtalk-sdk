// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetTodoTaskDetailHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskDetailResponseBody extends $tea.Model {
  id?: string;
  subject?: string;
  description?: string;
  startTime?: number;
  dueTime?: number;
  finishTime?: number;
  done?: boolean;
  executorIds?: string[];
  participantIds?: string[];
  detailUrl?: GetTodoTaskDetailResponseBodyDetailUrl;
  sourceId?: string;
  source?: string;
  createdTime?: number;
  modifiedTime?: number;
  creatorId?: string;
  modifierId?: string;
  tenantId?: string;
  tenantType?: string;
  bizTag?: string;
  requestId?: string;
  isOnlyShowExecutor?: boolean;
  priority?: number;
  category?: string;
  orgInfo?: GetTodoTaskDetailResponseBodyOrgInfo;
  executorStatus?: GetTodoTaskDetailResponseBodyExecutorStatus[];
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      subject: 'subject',
      description: 'description',
      startTime: 'startTime',
      dueTime: 'dueTime',
      finishTime: 'finishTime',
      done: 'done',
      executorIds: 'executorIds',
      participantIds: 'participantIds',
      detailUrl: 'detailUrl',
      sourceId: 'sourceId',
      source: 'source',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      creatorId: 'creatorId',
      modifierId: 'modifierId',
      tenantId: 'tenantId',
      tenantType: 'tenantType',
      bizTag: 'bizTag',
      requestId: 'requestId',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      priority: 'priority',
      category: 'category',
      orgInfo: 'orgInfo',
      executorStatus: 'executorStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      subject: 'string',
      description: 'string',
      startTime: 'number',
      dueTime: 'number',
      finishTime: 'number',
      done: 'boolean',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      participantIds: { 'type': 'array', 'itemType': 'string' },
      detailUrl: GetTodoTaskDetailResponseBodyDetailUrl,
      sourceId: 'string',
      source: 'string',
      createdTime: 'number',
      modifiedTime: 'number',
      creatorId: 'string',
      modifierId: 'string',
      tenantId: 'string',
      tenantType: 'string',
      bizTag: 'string',
      requestId: 'string',
      isOnlyShowExecutor: 'boolean',
      priority: 'number',
      category: 'string',
      orgInfo: GetTodoTaskDetailResponseBodyOrgInfo,
      executorStatus: { 'type': 'array', 'itemType': GetTodoTaskDetailResponseBodyExecutorStatus },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTodoTaskDetailResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTodoTaskDetailResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskResponseBody extends $tea.Model {
  id?: string;
  subject?: string;
  description?: string;
  startTime?: number;
  dueTime?: number;
  finishTime?: number;
  done?: boolean;
  executorIds?: string[];
  participantIds?: string[];
  detailUrl?: GetTodoTaskResponseBodyDetailUrl;
  sourceId?: string;
  source?: string;
  createdTime?: number;
  modifiedTime?: number;
  creatorId?: string;
  modifierId?: string;
  tenantId?: string;
  tenantType?: string;
  bizTag?: string;
  requestId?: string;
  cardTypeId?: string;
  isOnlyShowExecutor?: boolean;
  priority?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      subject: 'subject',
      description: 'description',
      startTime: 'startTime',
      dueTime: 'dueTime',
      finishTime: 'finishTime',
      done: 'done',
      executorIds: 'executorIds',
      participantIds: 'participantIds',
      detailUrl: 'detailUrl',
      sourceId: 'sourceId',
      source: 'source',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      creatorId: 'creatorId',
      modifierId: 'modifierId',
      tenantId: 'tenantId',
      tenantType: 'tenantType',
      bizTag: 'bizTag',
      requestId: 'requestId',
      cardTypeId: 'cardTypeId',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      priority: 'priority',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      subject: 'string',
      description: 'string',
      startTime: 'number',
      dueTime: 'number',
      finishTime: 'number',
      done: 'boolean',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      participantIds: { 'type': 'array', 'itemType': 'string' },
      detailUrl: GetTodoTaskResponseBodyDetailUrl,
      sourceId: 'string',
      source: 'string',
      createdTime: 'number',
      modifiedTime: 'number',
      creatorId: 'string',
      modifierId: 'string',
      tenantId: 'string',
      tenantType: 'string',
      bizTag: 'string',
      requestId: 'string',
      cardTypeId: 'string',
      isOnlyShowExecutor: 'boolean',
      priority: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTodoTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTodoTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskBySourceIdHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskBySourceIdResponseBody extends $tea.Model {
  id?: string;
  subject?: string;
  description?: string;
  startTime?: number;
  dueTime?: number;
  finishTime?: number;
  done?: boolean;
  executorIds?: string[];
  participantIds?: string[];
  detailUrl?: GetTodoTaskBySourceIdResponseBodyDetailUrl;
  sourceId?: string;
  source?: string;
  createdTime?: number;
  modifiedTime?: number;
  creatorId?: string;
  modifierId?: string;
  tenantId?: string;
  tenantType?: string;
  bizTag?: string;
  requestId?: string;
  isOnlyShowExecutor?: boolean;
  priority?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      subject: 'subject',
      description: 'description',
      startTime: 'startTime',
      dueTime: 'dueTime',
      finishTime: 'finishTime',
      done: 'done',
      executorIds: 'executorIds',
      participantIds: 'participantIds',
      detailUrl: 'detailUrl',
      sourceId: 'sourceId',
      source: 'source',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      creatorId: 'creatorId',
      modifierId: 'modifierId',
      tenantId: 'tenantId',
      tenantType: 'tenantType',
      bizTag: 'bizTag',
      requestId: 'requestId',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      priority: 'priority',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      subject: 'string',
      description: 'string',
      startTime: 'number',
      dueTime: 'number',
      finishTime: 'number',
      done: 'boolean',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      participantIds: { 'type': 'array', 'itemType': 'string' },
      detailUrl: GetTodoTaskBySourceIdResponseBodyDetailUrl,
      sourceId: 'string',
      source: 'string',
      createdTime: 'number',
      modifiedTime: 'number',
      creatorId: 'string',
      modifierId: 'string',
      tenantId: 'string',
      tenantType: 'string',
      bizTag: 'string',
      requestId: 'string',
      isOnlyShowExecutor: 'boolean',
      priority: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskBySourceIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTodoTaskBySourceIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTodoTaskBySourceIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountTodoTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountTodoTasksRequest extends $tea.Model {
  isDone?: boolean;
  roleTypes?: string[][];
  fromDueTime?: number;
  toDueTime?: number;
  category?: string;
  isRecycled?: boolean;
  static names(): { [key: string]: string } {
    return {
      isDone: 'isDone',
      roleTypes: 'roleTypes',
      fromDueTime: 'fromDueTime',
      toDueTime: 'toDueTime',
      category: 'category',
      isRecycled: 'isRecycled',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isDone: 'boolean',
      roleTypes: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      fromDueTime: 'number',
      toDueTime: 'number',
      category: 'string',
      isRecycled: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountTodoTasksResponseBody extends $tea.Model {
  result?: number;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CountTodoTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CountTodoTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CountTodoTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoTasksRequest extends $tea.Model {
  nextToken?: string;
  isDone?: boolean;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      isDone: 'isDone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      isDone: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoTasksResponseBody extends $tea.Model {
  nextToken?: string;
  todoCards?: QueryOrgTodoTasksResponseBodyTodoCards[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      todoCards: 'todoCards',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      todoCards: { 'type': 'array', 'itemType': QueryOrgTodoTasksResponseBodyTodoCards },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryOrgTodoTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryOrgTodoTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskRequest extends $tea.Model {
  sourceId?: string;
  subject?: string;
  creatorId?: string;
  description?: string;
  dueTime?: number;
  executorIds?: string[];
  participantIds?: string[];
  detailUrl?: CreateTodoTaskRequestDetailUrl;
  isOnlyShowExecutor?: boolean;
  priority?: number;
  notifyConfigs?: CreateTodoTaskRequestNotifyConfigs;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      sourceId: 'sourceId',
      subject: 'subject',
      creatorId: 'creatorId',
      description: 'description',
      dueTime: 'dueTime',
      executorIds: 'executorIds',
      participantIds: 'participantIds',
      detailUrl: 'detailUrl',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      priority: 'priority',
      notifyConfigs: 'notifyConfigs',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sourceId: 'string',
      subject: 'string',
      creatorId: 'string',
      description: 'string',
      dueTime: 'number',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      participantIds: { 'type': 'array', 'itemType': 'string' },
      detailUrl: CreateTodoTaskRequestDetailUrl,
      isOnlyShowExecutor: 'boolean',
      priority: 'number',
      notifyConfigs: CreateTodoTaskRequestNotifyConfigs,
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskResponseBody extends $tea.Model {
  id?: string;
  subject?: string;
  description?: string;
  startTime?: number;
  dueTime?: number;
  finishTime?: number;
  done?: boolean;
  executorIds?: string[];
  participantIds?: string[];
  detailUrl?: CreateTodoTaskResponseBodyDetailUrl;
  source?: string;
  sourceId?: string;
  createdTime?: number;
  modifiedTime?: number;
  creatorId?: string;
  modifierId?: string;
  bizTag?: string;
  requestId?: string;
  isOnlyShowExecutor?: boolean;
  priority?: number;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      subject: 'subject',
      description: 'description',
      startTime: 'startTime',
      dueTime: 'dueTime',
      finishTime: 'finishTime',
      done: 'done',
      executorIds: 'executorIds',
      participantIds: 'participantIds',
      detailUrl: 'detailUrl',
      source: 'source',
      sourceId: 'sourceId',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      creatorId: 'creatorId',
      modifierId: 'modifierId',
      bizTag: 'bizTag',
      requestId: 'requestId',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      priority: 'priority',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      subject: 'string',
      description: 'string',
      startTime: 'number',
      dueTime: 'number',
      finishTime: 'number',
      done: 'boolean',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      participantIds: { 'type': 'array', 'itemType': 'string' },
      detailUrl: CreateTodoTaskResponseBodyDetailUrl,
      source: 'string',
      sourceId: 'string',
      createdTime: 'number',
      modifiedTime: 'number',
      creatorId: 'string',
      modifierId: 'string',
      bizTag: 'string',
      requestId: 'string',
      isOnlyShowExecutor: 'boolean',
      priority: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTodoTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTodoTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTypeConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTypeConfigResponseBody extends $tea.Model {
  id?: string;
  createdTime?: number;
  modifiedTime?: number;
  creatorId?: string;
  modifierId?: string;
  bizTag?: string;
  requestId?: string;
  cardType?: number;
  icon?: string;
  description?: string;
  pcDetailUrlOpenMode?: string;
  contentFieldList?: GetTodoTypeConfigResponseBodyContentFieldList[];
  actionList?: GetTodoTypeConfigResponseBodyActionList[];
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      creatorId: 'creatorId',
      modifierId: 'modifierId',
      bizTag: 'bizTag',
      requestId: 'requestId',
      cardType: 'cardType',
      icon: 'icon',
      description: 'description',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      contentFieldList: 'contentFieldList',
      actionList: 'actionList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      createdTime: 'number',
      modifiedTime: 'number',
      creatorId: 'string',
      modifierId: 'string',
      bizTag: 'string',
      requestId: 'string',
      cardType: 'number',
      icon: 'string',
      description: 'string',
      pcDetailUrlOpenMode: 'string',
      contentFieldList: { 'type': 'array', 'itemType': GetTodoTypeConfigResponseBodyContentFieldList },
      actionList: { 'type': 'array', 'itemType': GetTodoTypeConfigResponseBodyActionList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTypeConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetTodoTypeConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetTodoTypeConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksRequest extends $tea.Model {
  nextToken?: string;
  orderBy?: string;
  orderDirection?: string;
  isDone?: boolean;
  roleTypes?: string[][];
  fromDueTime?: number;
  toDueTime?: number;
  category?: string;
  isRecycled?: boolean;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      orderBy: 'orderBy',
      orderDirection: 'orderDirection',
      isDone: 'isDone',
      roleTypes: 'roleTypes',
      fromDueTime: 'fromDueTime',
      toDueTime: 'toDueTime',
      category: 'category',
      isRecycled: 'isRecycled',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      orderBy: 'string',
      orderDirection: 'string',
      isDone: 'boolean',
      roleTypes: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      fromDueTime: 'number',
      toDueTime: 'number',
      category: 'string',
      isRecycled: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBody extends $tea.Model {
  nextToken?: string;
  todoCards?: QueryTodoTasksResponseBodyTodoCards[];
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      todoCards: 'todoCards',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      todoCards: { 'type': 'array', 'itemType': QueryTodoTasksResponseBodyTodoCards },
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryTodoTasksResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryTodoTasksResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTypeConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTypeConfigRequest extends $tea.Model {
  cardType?: number;
  icon?: string;
  description?: string;
  pcDetailUrlOpenMode?: string;
  contentFieldList?: UpdateTodoTypeConfigRequestContentFieldList[];
  actionList?: UpdateTodoTypeConfigRequestActionList[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      cardType: 'cardType',
      icon: 'icon',
      description: 'description',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      contentFieldList: 'contentFieldList',
      actionList: 'actionList',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardType: 'number',
      icon: 'string',
      description: 'string',
      pcDetailUrlOpenMode: 'string',
      contentFieldList: { 'type': 'array', 'itemType': UpdateTodoTypeConfigRequestContentFieldList },
      actionList: { 'type': 'array', 'itemType': UpdateTodoTypeConfigRequestActionList },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTypeConfigResponseBody extends $tea.Model {
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

export class UpdateTodoTypeConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateTodoTypeConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateTodoTypeConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTodoTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTodoTaskRequest extends $tea.Model {
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTodoTaskResponseBody extends $tea.Model {
  result?: boolean;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTodoTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteTodoTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteTodoTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTaskExecutorStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTaskExecutorStatusRequest extends $tea.Model {
  executorStatusList?: UpdateTodoTaskExecutorStatusRequestExecutorStatusList[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      executorStatusList: 'executorStatusList',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executorStatusList: { 'type': 'array', 'itemType': UpdateTodoTaskExecutorStatusRequestExecutorStatusList },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTaskExecutorStatusResponseBody extends $tea.Model {
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

export class UpdateTodoTaskExecutorStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateTodoTaskExecutorStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateTodoTaskExecutorStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigRequest extends $tea.Model {
  cardType?: number;
  icon?: string;
  description?: string;
  pcDetailUrlOpenMode?: string;
  contentFieldList?: CreateTodoTypeConfigRequestContentFieldList[];
  actionList?: CreateTodoTypeConfigRequestActionList[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      cardType: 'cardType',
      icon: 'icon',
      description: 'description',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      contentFieldList: 'contentFieldList',
      actionList: 'actionList',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardType: 'number',
      icon: 'string',
      description: 'string',
      pcDetailUrlOpenMode: 'string',
      contentFieldList: { 'type': 'array', 'itemType': CreateTodoTypeConfigRequestContentFieldList },
      actionList: { 'type': 'array', 'itemType': CreateTodoTypeConfigRequestActionList },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigResponseBody extends $tea.Model {
  id?: string;
  createdTime?: number;
  modifiedTime?: number;
  creatorId?: string;
  modifierId?: string;
  bizTag?: string;
  requestId?: string;
  cardType?: number;
  icon?: string;
  description?: string;
  pcDetailUrlOpenMode?: string;
  contentFieldList?: CreateTodoTypeConfigResponseBodyContentFieldList[];
  actionList?: CreateTodoTypeConfigResponseBodyActionList[];
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      creatorId: 'creatorId',
      modifierId: 'modifierId',
      bizTag: 'bizTag',
      requestId: 'requestId',
      cardType: 'cardType',
      icon: 'icon',
      description: 'description',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      contentFieldList: 'contentFieldList',
      actionList: 'actionList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      createdTime: 'number',
      modifiedTime: 'number',
      creatorId: 'string',
      modifierId: 'string',
      bizTag: 'string',
      requestId: 'string',
      cardType: 'number',
      icon: 'string',
      description: 'string',
      pcDetailUrlOpenMode: 'string',
      contentFieldList: { 'type': 'array', 'itemType': CreateTodoTypeConfigResponseBodyContentFieldList },
      actionList: { 'type': 'array', 'itemType': CreateTodoTypeConfigResponseBodyActionList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateTodoTypeConfigResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateTodoTypeConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTaskRequest extends $tea.Model {
  subject?: string;
  description?: string;
  dueTime?: number;
  done?: boolean;
  executorIds?: string[];
  participantIds?: string[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      subject: 'subject',
      description: 'description',
      dueTime: 'dueTime',
      done: 'done',
      executorIds: 'executorIds',
      participantIds: 'participantIds',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      subject: 'string',
      description: 'string',
      dueTime: 'number',
      done: 'boolean',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      participantIds: { 'type': 'array', 'itemType': 'string' },
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTaskResponseBody extends $tea.Model {
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

export class UpdateTodoTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateTodoTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateTodoTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskDetailResponseBodyDetailUrl extends $tea.Model {
  pcUrl?: string;
  appUrl?: string;
  static names(): { [key: string]: string } {
    return {
      pcUrl: 'pcUrl',
      appUrl: 'appUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pcUrl: 'string',
      appUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskDetailResponseBodyOrgInfo extends $tea.Model {
  corpId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskDetailResponseBodyExecutorStatus extends $tea.Model {
  userId?: string;
  isDone?: boolean;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      isDone: 'isDone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      isDone: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskResponseBodyDetailUrl extends $tea.Model {
  pcUrl?: string;
  appUrl?: string;
  static names(): { [key: string]: string } {
    return {
      pcUrl: 'pcUrl',
      appUrl: 'appUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pcUrl: 'string',
      appUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskBySourceIdResponseBodyDetailUrl extends $tea.Model {
  pcUrl?: string;
  appUrl?: string;
  static names(): { [key: string]: string } {
    return {
      pcUrl: 'pcUrl',
      appUrl: 'appUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pcUrl: 'string',
      appUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl extends $tea.Model {
  appUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      appUrl: 'appUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoTasksResponseBodyTodoCards extends $tea.Model {
  taskId?: string;
  subject?: string;
  dueTime?: number;
  detailUrl?: QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl;
  priority?: number;
  createdTime?: number;
  modifiedTime?: number;
  creatorId?: string;
  sourceId?: string;
  bizTag?: string;
  isDone?: boolean;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      subject: 'subject',
      dueTime: 'dueTime',
      detailUrl: 'detailUrl',
      priority: 'priority',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      creatorId: 'creatorId',
      sourceId: 'sourceId',
      bizTag: 'bizTag',
      isDone: 'isDone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
      subject: 'string',
      dueTime: 'number',
      detailUrl: QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl,
      priority: 'number',
      createdTime: 'number',
      modifiedTime: 'number',
      creatorId: 'string',
      sourceId: 'string',
      bizTag: 'string',
      isDone: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskRequestDetailUrl extends $tea.Model {
  appUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      appUrl: 'appUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskRequestNotifyConfigs extends $tea.Model {
  static names(): { [key: string]: string } {
    return {
    };
  }

  static types(): { [key: string]: any } {
    return {
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskResponseBodyDetailUrl extends $tea.Model {
  pcUrl?: string;
  appUrl?: string;
  static names(): { [key: string]: string } {
    return {
      pcUrl: 'pcUrl',
      appUrl: 'appUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pcUrl: 'string',
      appUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTypeConfigResponseBodyContentFieldList extends $tea.Model {
  fieldKey?: string;
  fieldType?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      fieldKey: 'fieldKey',
      fieldType: 'fieldType',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldKey: 'string',
      fieldType: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTypeConfigResponseBodyActionList extends $tea.Model {
  actionKey?: string;
  buttonStyleType?: number;
  actionType?: number;
  url?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      buttonStyleType: 'buttonStyleType',
      actionType: 'actionType',
      url: 'url',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      buttonStyleType: 'number',
      actionType: 'number',
      url: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBodyTodoCardsDetailUrl extends $tea.Model {
  appUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      appUrl: 'appUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList extends $tea.Model {
  name?: string;
  value?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      value: 'value',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      value: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBodyTodoCardsTodoCardView extends $tea.Model {
  cardType?: string;
  circleELType?: string;
  contentType?: string;
  actionType?: string;
  icon?: string;
  todoCardTitle?: string;
  todoCardContentList?: QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList[];
  static names(): { [key: string]: string } {
    return {
      cardType: 'cardType',
      circleELType: 'circleELType',
      contentType: 'contentType',
      actionType: 'actionType',
      icon: 'icon',
      todoCardTitle: 'todoCardTitle',
      todoCardContentList: 'todoCardContentList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardType: 'string',
      circleELType: 'string',
      contentType: 'string',
      actionType: 'string',
      icon: 'string',
      todoCardTitle: 'string',
      todoCardContentList: { 'type': 'array', 'itemType': QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBodyTodoCardsOriginalSource extends $tea.Model {
  sourceTitle?: string;
  static names(): { [key: string]: string } {
    return {
      sourceTitle: 'sourceTitle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sourceTitle: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBodyTodoCardsOrgInfo extends $tea.Model {
  corpId?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBodyTodoCards extends $tea.Model {
  taskId?: string;
  subject?: string;
  dueTime?: number;
  detailUrl?: QueryTodoTasksResponseBodyTodoCardsDetailUrl;
  todoCardView?: QueryTodoTasksResponseBodyTodoCardsTodoCardView;
  priority?: number;
  createdTime?: number;
  modifiedTime?: number;
  todoStatus?: string;
  creatorId?: string;
  sourceId?: string;
  category?: string;
  bizTag?: string;
  originalSource?: QueryTodoTasksResponseBodyTodoCardsOriginalSource;
  isDone?: boolean;
  orgInfo?: QueryTodoTasksResponseBodyTodoCardsOrgInfo;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
      subject: 'subject',
      dueTime: 'dueTime',
      detailUrl: 'detailUrl',
      todoCardView: 'todoCardView',
      priority: 'priority',
      createdTime: 'createdTime',
      modifiedTime: 'modifiedTime',
      todoStatus: 'todoStatus',
      creatorId: 'creatorId',
      sourceId: 'sourceId',
      category: 'category',
      bizTag: 'bizTag',
      originalSource: 'originalSource',
      isDone: 'isDone',
      orgInfo: 'orgInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
      subject: 'string',
      dueTime: 'number',
      detailUrl: QueryTodoTasksResponseBodyTodoCardsDetailUrl,
      todoCardView: QueryTodoTasksResponseBodyTodoCardsTodoCardView,
      priority: 'number',
      createdTime: 'number',
      modifiedTime: 'number',
      todoStatus: 'string',
      creatorId: 'string',
      sourceId: 'string',
      category: 'string',
      bizTag: 'string',
      originalSource: QueryTodoTasksResponseBodyTodoCardsOriginalSource,
      isDone: 'boolean',
      orgInfo: QueryTodoTasksResponseBodyTodoCardsOrgInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTypeConfigRequestContentFieldList extends $tea.Model {
  fieldKey?: string;
  fieldType?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      fieldKey: 'fieldKey',
      fieldType: 'fieldType',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldKey: 'string',
      fieldType: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTypeConfigRequestActionList extends $tea.Model {
  actionKey?: string;
  buttonStyleType?: number;
  actionType?: number;
  url?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      buttonStyleType: 'buttonStyleType',
      actionType: 'actionType',
      url: 'url',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      buttonStyleType: 'number',
      actionType: 'number',
      url: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateTodoTaskExecutorStatusRequestExecutorStatusList extends $tea.Model {
  id?: string;
  isDone?: boolean;
  static names(): { [key: string]: string } {
    return {
      id: 'id',
      isDone: 'isDone',
    };
  }

  static types(): { [key: string]: any } {
    return {
      id: 'string',
      isDone: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigRequestContentFieldList extends $tea.Model {
  fieldKey?: string;
  fieldType?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      fieldKey: 'fieldKey',
      fieldType: 'fieldType',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldKey: 'string',
      fieldType: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigRequestActionList extends $tea.Model {
  actionKey?: string;
  buttonStyleType?: number;
  actionType?: number;
  url?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      buttonStyleType: 'buttonStyleType',
      actionType: 'actionType',
      url: 'url',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      buttonStyleType: 'number',
      actionType: 'number',
      url: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigResponseBodyContentFieldList extends $tea.Model {
  fieldKey?: string;
  fieldType?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      fieldKey: 'fieldKey',
      fieldType: 'fieldType',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldKey: 'string',
      fieldType: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigResponseBodyActionList extends $tea.Model {
  actionKey?: string;
  buttonStyleType?: number;
  actionType?: number;
  url?: string;
  nameI18n?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      buttonStyleType: 'buttonStyleType',
      actionType: 'actionType',
      url: 'url',
      nameI18n: 'nameI18n',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      buttonStyleType: 'number',
      actionType: 'number',
      url: 'string',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
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


  async getTodoTaskDetail(taskId: string, unionId: string): Promise<GetTodoTaskDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTaskDetailHeaders({ });
    return await this.getTodoTaskDetailWithOptions(taskId, unionId, headers, runtime);
  }

  async getTodoTaskDetailWithOptions(taskId: string, unionId: string, headers: GetTodoTaskDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTaskDetailResponse> {
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
    return $tea.cast<GetTodoTaskDetailResponse>(await this.doROARequest("GetTodoTaskDetail", "todo_1.0", "HTTP", "GET", "AK", `/v1.0/todo/exclusive/users/${unionId}/tasks/${taskId}`, "json", req, runtime), new GetTodoTaskDetailResponse({}));
  }

  async getTodoTask(unionId: string, taskId: string): Promise<GetTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTaskHeaders({ });
    return await this.getTodoTaskWithOptions(unionId, taskId, headers, runtime);
  }

  async getTodoTaskWithOptions(unionId: string, taskId: string, headers: GetTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTaskResponse> {
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
    return $tea.cast<GetTodoTaskResponse>(await this.doROARequest("GetTodoTask", "todo_1.0", "HTTP", "GET", "AK", `/v1.0/todo/users/${unionId}/tasks/${taskId}`, "json", req, runtime), new GetTodoTaskResponse({}));
  }

  async getTodoTaskBySourceId(unionId: string, sourceId: string): Promise<GetTodoTaskBySourceIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTaskBySourceIdHeaders({ });
    return await this.getTodoTaskBySourceIdWithOptions(unionId, sourceId, headers, runtime);
  }

  async getTodoTaskBySourceIdWithOptions(unionId: string, sourceId: string, headers: GetTodoTaskBySourceIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTaskBySourceIdResponse> {
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
    return $tea.cast<GetTodoTaskBySourceIdResponse>(await this.doROARequest("GetTodoTaskBySourceId", "todo_1.0", "HTTP", "GET", "AK", `/v1.0/todo/users/${unionId}/tasks/sources/${sourceId}`, "json", req, runtime), new GetTodoTaskBySourceIdResponse({}));
  }

  async countTodoTasks(unionId: string, request: CountTodoTasksRequest): Promise<CountTodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CountTodoTasksHeaders({ });
    return await this.countTodoTasksWithOptions(unionId, request, headers, runtime);
  }

  async countTodoTasksWithOptions(unionId: string, request: CountTodoTasksRequest, headers: CountTodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<CountTodoTasksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
    }

    if (!Util.isUnset(request.roleTypes)) {
      body["roleTypes"] = request.roleTypes;
    }

    if (!Util.isUnset(request.fromDueTime)) {
      body["fromDueTime"] = request.fromDueTime;
    }

    if (!Util.isUnset(request.toDueTime)) {
      body["toDueTime"] = request.toDueTime;
    }

    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.isRecycled)) {
      body["isRecycled"] = request.isRecycled;
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
    return $tea.cast<CountTodoTasksResponse>(await this.doROARequest("CountTodoTasks", "todo_1.0", "HTTP", "POST", "AK", `/v1.0/todo/users/${unionId}/tasks/count`, "json", req, runtime), new CountTodoTasksResponse({}));
  }

  async queryOrgTodoTasks(unionId: string, request: QueryOrgTodoTasksRequest): Promise<QueryOrgTodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgTodoTasksHeaders({ });
    return await this.queryOrgTodoTasksWithOptions(unionId, request, headers, runtime);
  }

  async queryOrgTodoTasksWithOptions(unionId: string, request: QueryOrgTodoTasksRequest, headers: QueryOrgTodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgTodoTasksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
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
    return $tea.cast<QueryOrgTodoTasksResponse>(await this.doROARequest("QueryOrgTodoTasks", "todo_1.0", "HTTP", "POST", "AK", `/v1.0/todo/users/${unionId}/org/tasks/query`, "json", req, runtime), new QueryOrgTodoTasksResponse({}));
  }

  async createTodoTask(unionId: string, request: CreateTodoTaskRequest): Promise<CreateTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTodoTaskHeaders({ });
    return await this.createTodoTaskWithOptions(unionId, request, headers, runtime);
  }

  async createTodoTaskWithOptions(unionId: string, request: CreateTodoTaskRequest, headers: CreateTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTodoTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.sourceId)) {
      body["sourceId"] = request.sourceId;
    }

    if (!Util.isUnset(request.subject)) {
      body["subject"] = request.subject;
    }

    if (!Util.isUnset(request.creatorId)) {
      body["creatorId"] = request.creatorId;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.dueTime)) {
      body["dueTime"] = request.dueTime;
    }

    if (!Util.isUnset(request.executorIds)) {
      body["executorIds"] = request.executorIds;
    }

    if (!Util.isUnset(request.participantIds)) {
      body["participantIds"] = request.participantIds;
    }

    if (!Util.isUnset($tea.toMap(request.detailUrl))) {
      body["detailUrl"] = request.detailUrl;
    }

    if (!Util.isUnset(request.isOnlyShowExecutor)) {
      body["isOnlyShowExecutor"] = request.isOnlyShowExecutor;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset($tea.toMap(request.notifyConfigs))) {
      body["notifyConfigs"] = request.notifyConfigs;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateTodoTaskResponse>(await this.doROARequest("CreateTodoTask", "todo_1.0", "HTTP", "POST", "AK", `/v1.0/todo/users/${unionId}/tasks`, "json", req, runtime), new CreateTodoTaskResponse({}));
  }

  async getTodoTypeConfig(unionId: string, cardTypeId: string): Promise<GetTodoTypeConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTypeConfigHeaders({ });
    return await this.getTodoTypeConfigWithOptions(unionId, cardTypeId, headers, runtime);
  }

  async getTodoTypeConfigWithOptions(unionId: string, cardTypeId: string, headers: GetTodoTypeConfigHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTypeConfigResponse> {
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
    return $tea.cast<GetTodoTypeConfigResponse>(await this.doROARequest("GetTodoTypeConfig", "todo_1.0", "HTTP", "GET", "AK", `/v1.0/todo/users/${unionId}/configs/types/${cardTypeId}`, "json", req, runtime), new GetTodoTypeConfigResponse({}));
  }

  async queryTodoTasks(unionId: string, request: QueryTodoTasksRequest): Promise<QueryTodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTodoTasksHeaders({ });
    return await this.queryTodoTasksWithOptions(unionId, request, headers, runtime);
  }

  async queryTodoTasksWithOptions(unionId: string, request: QueryTodoTasksRequest, headers: QueryTodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTodoTasksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.orderBy)) {
      body["orderBy"] = request.orderBy;
    }

    if (!Util.isUnset(request.orderDirection)) {
      body["orderDirection"] = request.orderDirection;
    }

    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
    }

    if (!Util.isUnset(request.roleTypes)) {
      body["roleTypes"] = request.roleTypes;
    }

    if (!Util.isUnset(request.fromDueTime)) {
      body["fromDueTime"] = request.fromDueTime;
    }

    if (!Util.isUnset(request.toDueTime)) {
      body["toDueTime"] = request.toDueTime;
    }

    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.isRecycled)) {
      body["isRecycled"] = request.isRecycled;
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
    return $tea.cast<QueryTodoTasksResponse>(await this.doROARequest("QueryTodoTasks", "todo_1.0", "HTTP", "POST", "AK", `/v1.0/todo/users/${unionId}/tasks/list`, "json", req, runtime), new QueryTodoTasksResponse({}));
  }

  async updateTodoTypeConfig(unionId: string, cardTypeId: string, request: UpdateTodoTypeConfigRequest): Promise<UpdateTodoTypeConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTodoTypeConfigHeaders({ });
    return await this.updateTodoTypeConfigWithOptions(unionId, cardTypeId, request, headers, runtime);
  }

  async updateTodoTypeConfigWithOptions(unionId: string, cardTypeId: string, request: UpdateTodoTypeConfigRequest, headers: UpdateTodoTypeConfigHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTodoTypeConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardType)) {
      body["cardType"] = request.cardType;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.pcDetailUrlOpenMode)) {
      body["pcDetailUrlOpenMode"] = request.pcDetailUrlOpenMode;
    }

    if (!Util.isUnset(request.contentFieldList)) {
      body["contentFieldList"] = request.contentFieldList;
    }

    if (!Util.isUnset(request.actionList)) {
      body["actionList"] = request.actionList;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateTodoTypeConfigResponse>(await this.doROARequest("UpdateTodoTypeConfig", "todo_1.0", "HTTP", "PUT", "AK", `/v1.0/todo/users/${unionId}/configs/types/${cardTypeId}`, "json", req, runtime), new UpdateTodoTypeConfigResponse({}));
  }

  async deleteTodoTask(unionId: string, taskId: string, request: DeleteTodoTaskRequest): Promise<DeleteTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTodoTaskHeaders({ });
    return await this.deleteTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
  }

  async deleteTodoTaskWithOptions(unionId: string, taskId: string, request: DeleteTodoTaskRequest, headers: DeleteTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteTodoTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
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
    return $tea.cast<DeleteTodoTaskResponse>(await this.doROARequest("DeleteTodoTask", "todo_1.0", "HTTP", "DELETE", "AK", `/v1.0/todo/users/${unionId}/tasks/${taskId}`, "json", req, runtime), new DeleteTodoTaskResponse({}));
  }

  async updateTodoTaskExecutorStatus(unionId: string, taskId: string, request: UpdateTodoTaskExecutorStatusRequest): Promise<UpdateTodoTaskExecutorStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTodoTaskExecutorStatusHeaders({ });
    return await this.updateTodoTaskExecutorStatusWithOptions(unionId, taskId, request, headers, runtime);
  }

  async updateTodoTaskExecutorStatusWithOptions(unionId: string, taskId: string, request: UpdateTodoTaskExecutorStatusRequest, headers: UpdateTodoTaskExecutorStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTodoTaskExecutorStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.executorStatusList)) {
      body["executorStatusList"] = request.executorStatusList;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateTodoTaskExecutorStatusResponse>(await this.doROARequest("UpdateTodoTaskExecutorStatus", "todo_1.0", "HTTP", "PUT", "AK", `/v1.0/todo/users/${unionId}/tasks/${taskId}/executorStatus`, "json", req, runtime), new UpdateTodoTaskExecutorStatusResponse({}));
  }

  async createTodoTypeConfig(unionId: string, request: CreateTodoTypeConfigRequest): Promise<CreateTodoTypeConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTodoTypeConfigHeaders({ });
    return await this.createTodoTypeConfigWithOptions(unionId, request, headers, runtime);
  }

  async createTodoTypeConfigWithOptions(unionId: string, request: CreateTodoTypeConfigRequest, headers: CreateTodoTypeConfigHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTodoTypeConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.cardType)) {
      body["cardType"] = request.cardType;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.pcDetailUrlOpenMode)) {
      body["pcDetailUrlOpenMode"] = request.pcDetailUrlOpenMode;
    }

    if (!Util.isUnset(request.contentFieldList)) {
      body["contentFieldList"] = request.contentFieldList;
    }

    if (!Util.isUnset(request.actionList)) {
      body["actionList"] = request.actionList;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<CreateTodoTypeConfigResponse>(await this.doROARequest("CreateTodoTypeConfig", "todo_1.0", "HTTP", "POST", "AK", `/v1.0/todo/users/${unionId}/configs/types`, "json", req, runtime), new CreateTodoTypeConfigResponse({}));
  }

  async updateTodoTask(unionId: string, taskId: string, request: UpdateTodoTaskRequest): Promise<UpdateTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTodoTaskHeaders({ });
    return await this.updateTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
  }

  async updateTodoTaskWithOptions(unionId: string, taskId: string, request: UpdateTodoTaskRequest, headers: UpdateTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTodoTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.subject)) {
      body["subject"] = request.subject;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.dueTime)) {
      body["dueTime"] = request.dueTime;
    }

    if (!Util.isUnset(request.done)) {
      body["done"] = request.done;
    }

    if (!Util.isUnset(request.executorIds)) {
      body["executorIds"] = request.executorIds;
    }

    if (!Util.isUnset(request.participantIds)) {
      body["participantIds"] = request.participantIds;
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
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<UpdateTodoTaskResponse>(await this.doROARequest("UpdateTodoTask", "todo_1.0", "HTTP", "PUT", "AK", `/v1.0/todo/users/${unionId}/tasks/${taskId}`, "json", req, runtime), new UpdateTodoTaskResponse({}));
  }

}
