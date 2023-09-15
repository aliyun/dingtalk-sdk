// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  category?: string;
  fromDueTime?: number;
  isDone?: boolean;
  isRecycled?: boolean;
  roleTypes?: string[][];
  toDueTime?: number;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      fromDueTime: 'fromDueTime',
      isDone: 'isDone',
      isRecycled: 'isRecycled',
      roleTypes: 'roleTypes',
      toDueTime: 'toDueTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      fromDueTime: 'number',
      isDone: 'boolean',
      isRecycled: 'boolean',
      roleTypes: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      toDueTime: 'number',
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
  statusCode: number;
  body: CountTodoTasksResponseBody;
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
      body: CountTodoTasksResponseBody,
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
  actionList?: CreateTodoTaskRequestActionList[];
  bizCategoryId?: string;
  contentFieldList?: CreateTodoTaskRequestContentFieldList[];
  creatorId?: string;
  description?: string;
  detailUrl?: CreateTodoTaskRequestDetailUrl;
  dueTime?: number;
  executorIds?: string[];
  isOnlyShowExecutor?: boolean;
  notifyConfigs?: CreateTodoTaskRequestNotifyConfigs;
  participantIds?: string[];
  priority?: number;
  sourceId?: string;
  subject?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      actionList: 'actionList',
      bizCategoryId: 'bizCategoryId',
      contentFieldList: 'contentFieldList',
      creatorId: 'creatorId',
      description: 'description',
      detailUrl: 'detailUrl',
      dueTime: 'dueTime',
      executorIds: 'executorIds',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      notifyConfigs: 'notifyConfigs',
      participantIds: 'participantIds',
      priority: 'priority',
      sourceId: 'sourceId',
      subject: 'subject',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionList: { 'type': 'array', 'itemType': CreateTodoTaskRequestActionList },
      bizCategoryId: 'string',
      contentFieldList: { 'type': 'array', 'itemType': CreateTodoTaskRequestContentFieldList },
      creatorId: 'string',
      description: 'string',
      detailUrl: CreateTodoTaskRequestDetailUrl,
      dueTime: 'number',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      isOnlyShowExecutor: 'boolean',
      notifyConfigs: CreateTodoTaskRequestNotifyConfigs,
      participantIds: { 'type': 'array', 'itemType': 'string' },
      priority: 'number',
      sourceId: 'string',
      subject: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskResponseBody extends $tea.Model {
  bizTag?: string;
  contentFieldList?: CreateTodoTaskResponseBodyContentFieldList[];
  createdTime?: number;
  creatorId?: string;
  description?: string;
  detailUrl?: CreateTodoTaskResponseBodyDetailUrl;
  done?: boolean;
  dueTime?: number;
  executorIds?: string[];
  finishTime?: number;
  id?: string;
  isOnlyShowExecutor?: boolean;
  modifiedTime?: number;
  modifierId?: string;
  notifyConfigs?: CreateTodoTaskResponseBodyNotifyConfigs;
  participantIds?: string[];
  priority?: number;
  requestId?: string;
  source?: string;
  sourceId?: string;
  startTime?: number;
  subject?: string;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      contentFieldList: 'contentFieldList',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      description: 'description',
      detailUrl: 'detailUrl',
      done: 'done',
      dueTime: 'dueTime',
      executorIds: 'executorIds',
      finishTime: 'finishTime',
      id: 'id',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      notifyConfigs: 'notifyConfigs',
      participantIds: 'participantIds',
      priority: 'priority',
      requestId: 'requestId',
      source: 'source',
      sourceId: 'sourceId',
      startTime: 'startTime',
      subject: 'subject',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      contentFieldList: { 'type': 'array', 'itemType': CreateTodoTaskResponseBodyContentFieldList },
      createdTime: 'number',
      creatorId: 'string',
      description: 'string',
      detailUrl: CreateTodoTaskResponseBodyDetailUrl,
      done: 'boolean',
      dueTime: 'number',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      finishTime: 'number',
      id: 'string',
      isOnlyShowExecutor: 'boolean',
      modifiedTime: 'number',
      modifierId: 'string',
      notifyConfigs: CreateTodoTaskResponseBodyNotifyConfigs,
      participantIds: { 'type': 'array', 'itemType': 'string' },
      priority: 'number',
      requestId: 'string',
      source: 'string',
      sourceId: 'string',
      startTime: 'number',
      subject: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateTodoTaskResponseBody;
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
      body: CreateTodoTaskResponseBody,
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
  actionList?: CreateTodoTypeConfigRequestActionList[];
  cardType?: number;
  contentFieldList?: CreateTodoTypeConfigRequestContentFieldList[];
  description?: string;
  icon?: string;
  pcDetailUrlOpenMode?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      actionList: 'actionList',
      cardType: 'cardType',
      contentFieldList: 'contentFieldList',
      description: 'description',
      icon: 'icon',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionList: { 'type': 'array', 'itemType': CreateTodoTypeConfigRequestActionList },
      cardType: 'number',
      contentFieldList: { 'type': 'array', 'itemType': CreateTodoTypeConfigRequestContentFieldList },
      description: 'string',
      icon: 'string',
      pcDetailUrlOpenMode: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigResponseBody extends $tea.Model {
  actionList?: CreateTodoTypeConfigResponseBodyActionList[];
  bizTag?: string;
  cardType?: number;
  contentFieldList?: CreateTodoTypeConfigResponseBodyContentFieldList[];
  createdTime?: number;
  creatorId?: string;
  description?: string;
  icon?: string;
  id?: string;
  modifiedTime?: number;
  modifierId?: string;
  pcDetailUrlOpenMode?: string;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      actionList: 'actionList',
      bizTag: 'bizTag',
      cardType: 'cardType',
      contentFieldList: 'contentFieldList',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionList: { 'type': 'array', 'itemType': CreateTodoTypeConfigResponseBodyActionList },
      bizTag: 'string',
      cardType: 'number',
      contentFieldList: { 'type': 'array', 'itemType': CreateTodoTypeConfigResponseBodyContentFieldList },
      createdTime: 'number',
      creatorId: 'string',
      description: 'string',
      icon: 'string',
      id: 'string',
      modifiedTime: 'number',
      modifierId: 'string',
      pcDetailUrlOpenMode: 'string',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateTodoTypeConfigResponseBody;
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
      body: CreateTodoTypeConfigResponseBody,
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
  requestId?: string;
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteTodoTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteTodoTaskResponseBody;
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
      body: DeleteTodoTaskResponseBody,
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
  bizTag?: string;
  cardTypeId?: string;
  createdTime?: number;
  creatorId?: string;
  description?: string;
  detailUrl?: GetTodoTaskResponseBodyDetailUrl;
  done?: boolean;
  dueTime?: number;
  executorIds?: string[];
  finishTime?: number;
  id?: string;
  isOnlyShowExecutor?: boolean;
  modifiedTime?: number;
  modifierId?: string;
  participantIds?: string[];
  priority?: number;
  requestId?: string;
  source?: string;
  sourceId?: string;
  startTime?: number;
  subject?: string;
  tenantId?: string;
  tenantType?: string;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      cardTypeId: 'cardTypeId',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      description: 'description',
      detailUrl: 'detailUrl',
      done: 'done',
      dueTime: 'dueTime',
      executorIds: 'executorIds',
      finishTime: 'finishTime',
      id: 'id',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      participantIds: 'participantIds',
      priority: 'priority',
      requestId: 'requestId',
      source: 'source',
      sourceId: 'sourceId',
      startTime: 'startTime',
      subject: 'subject',
      tenantId: 'tenantId',
      tenantType: 'tenantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      cardTypeId: 'string',
      createdTime: 'number',
      creatorId: 'string',
      description: 'string',
      detailUrl: GetTodoTaskResponseBodyDetailUrl,
      done: 'boolean',
      dueTime: 'number',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      finishTime: 'number',
      id: 'string',
      isOnlyShowExecutor: 'boolean',
      modifiedTime: 'number',
      modifierId: 'string',
      participantIds: { 'type': 'array', 'itemType': 'string' },
      priority: 'number',
      requestId: 'string',
      source: 'string',
      sourceId: 'string',
      startTime: 'number',
      subject: 'string',
      tenantId: 'string',
      tenantType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTodoTaskResponseBody;
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
  bizTag?: string;
  createdTime?: number;
  creatorId?: string;
  description?: string;
  detailUrl?: GetTodoTaskBySourceIdResponseBodyDetailUrl;
  done?: boolean;
  dueTime?: number;
  executorIds?: string[];
  finishTime?: number;
  id?: string;
  isOnlyShowExecutor?: boolean;
  modifiedTime?: number;
  modifierId?: string;
  participantIds?: string[];
  priority?: number;
  requestId?: string;
  source?: string;
  sourceId?: string;
  startTime?: number;
  subject?: string;
  tenantId?: string;
  tenantType?: string;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      description: 'description',
      detailUrl: 'detailUrl',
      done: 'done',
      dueTime: 'dueTime',
      executorIds: 'executorIds',
      finishTime: 'finishTime',
      id: 'id',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      participantIds: 'participantIds',
      priority: 'priority',
      requestId: 'requestId',
      source: 'source',
      sourceId: 'sourceId',
      startTime: 'startTime',
      subject: 'subject',
      tenantId: 'tenantId',
      tenantType: 'tenantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      createdTime: 'number',
      creatorId: 'string',
      description: 'string',
      detailUrl: GetTodoTaskBySourceIdResponseBodyDetailUrl,
      done: 'boolean',
      dueTime: 'number',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      finishTime: 'number',
      id: 'string',
      isOnlyShowExecutor: 'boolean',
      modifiedTime: 'number',
      modifierId: 'string',
      participantIds: { 'type': 'array', 'itemType': 'string' },
      priority: 'number',
      requestId: 'string',
      source: 'string',
      sourceId: 'string',
      startTime: 'number',
      subject: 'string',
      tenantId: 'string',
      tenantType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskBySourceIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTodoTaskBySourceIdResponseBody;
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
      body: GetTodoTaskBySourceIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  bizTag?: string;
  category?: string;
  createdTime?: number;
  creatorId?: string;
  description?: string;
  detailUrl?: GetTodoTaskDetailResponseBodyDetailUrl;
  done?: boolean;
  dueTime?: number;
  executorIds?: string[];
  executorStatus?: GetTodoTaskDetailResponseBodyExecutorStatus[];
  finishTime?: number;
  id?: string;
  isOnlyShowExecutor?: boolean;
  modifiedTime?: number;
  modifierId?: string;
  orgInfo?: GetTodoTaskDetailResponseBodyOrgInfo;
  participantIds?: string[];
  priority?: number;
  requestId?: string;
  source?: string;
  sourceId?: string;
  startTime?: number;
  subject?: string;
  tenantId?: string;
  tenantType?: string;
  todoCardView?: GetTodoTaskDetailResponseBodyTodoCardView;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      category: 'category',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      description: 'description',
      detailUrl: 'detailUrl',
      done: 'done',
      dueTime: 'dueTime',
      executorIds: 'executorIds',
      executorStatus: 'executorStatus',
      finishTime: 'finishTime',
      id: 'id',
      isOnlyShowExecutor: 'isOnlyShowExecutor',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      orgInfo: 'orgInfo',
      participantIds: 'participantIds',
      priority: 'priority',
      requestId: 'requestId',
      source: 'source',
      sourceId: 'sourceId',
      startTime: 'startTime',
      subject: 'subject',
      tenantId: 'tenantId',
      tenantType: 'tenantType',
      todoCardView: 'todoCardView',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      category: 'string',
      createdTime: 'number',
      creatorId: 'string',
      description: 'string',
      detailUrl: GetTodoTaskDetailResponseBodyDetailUrl,
      done: 'boolean',
      dueTime: 'number',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      executorStatus: { 'type': 'array', 'itemType': GetTodoTaskDetailResponseBodyExecutorStatus },
      finishTime: 'number',
      id: 'string',
      isOnlyShowExecutor: 'boolean',
      modifiedTime: 'number',
      modifierId: 'string',
      orgInfo: GetTodoTaskDetailResponseBodyOrgInfo,
      participantIds: { 'type': 'array', 'itemType': 'string' },
      priority: 'number',
      requestId: 'string',
      source: 'string',
      sourceId: 'string',
      startTime: 'number',
      subject: 'string',
      tenantId: 'string',
      tenantType: 'string',
      todoCardView: GetTodoTaskDetailResponseBodyTodoCardView,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTaskDetailResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTodoTaskDetailResponseBody;
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
      body: GetTodoTaskDetailResponseBody,
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
  actionList?: GetTodoTypeConfigResponseBodyActionList[];
  bizTag?: string;
  cardType?: number;
  contentFieldList?: GetTodoTypeConfigResponseBodyContentFieldList[];
  createdTime?: number;
  creatorId?: string;
  description?: string;
  icon?: string;
  id?: string;
  modifiedTime?: number;
  modifierId?: string;
  pcDetailUrlOpenMode?: string;
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      actionList: 'actionList',
      bizTag: 'bizTag',
      cardType: 'cardType',
      contentFieldList: 'contentFieldList',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      description: 'description',
      icon: 'icon',
      id: 'id',
      modifiedTime: 'modifiedTime',
      modifierId: 'modifierId',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      requestId: 'requestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionList: { 'type': 'array', 'itemType': GetTodoTypeConfigResponseBodyActionList },
      bizTag: 'string',
      cardType: 'number',
      contentFieldList: { 'type': 'array', 'itemType': GetTodoTypeConfigResponseBodyContentFieldList },
      createdTime: 'number',
      creatorId: 'string',
      description: 'string',
      icon: 'string',
      id: 'string',
      modifiedTime: 'number',
      modifierId: 'string',
      pcDetailUrlOpenMode: 'string',
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTypeConfigResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetTodoTypeConfigResponseBody;
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
      body: GetTodoTypeConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoByUserHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoByUserRequest extends $tea.Model {
  fromDueTime?: number;
  isDone?: boolean;
  maxResults?: number;
  nextToken?: string;
  orderBy?: string;
  orderDirection?: string;
  roleTypes?: string[][];
  subject?: string;
  toDueTime?: number;
  static names(): { [key: string]: string } {
    return {
      fromDueTime: 'fromDueTime',
      isDone: 'isDone',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      orderBy: 'orderBy',
      orderDirection: 'orderDirection',
      roleTypes: 'roleTypes',
      subject: 'subject',
      toDueTime: 'toDueTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fromDueTime: 'number',
      isDone: 'boolean',
      maxResults: 'number',
      nextToken: 'string',
      orderBy: 'string',
      orderDirection: 'string',
      roleTypes: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      subject: 'string',
      toDueTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoByUserResponseBody extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  todoCards?: QueryOrgTodoByUserResponseBodyTodoCards[];
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      todoCards: 'todoCards',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      todoCards: { 'type': 'array', 'itemType': QueryOrgTodoByUserResponseBodyTodoCards },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgTodoByUserResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryOrgTodoByUserResponseBody;
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
      body: QueryOrgTodoByUserResponseBody,
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
  isDone?: boolean;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      isDone: 'isDone',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isDone: 'boolean',
      nextToken: 'string',
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
  statusCode: number;
  body: QueryOrgTodoTasksResponseBody;
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
      body: QueryOrgTodoTasksResponseBody,
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
  category?: string;
  fromDueTime?: number;
  isDone?: boolean;
  isRecycled?: boolean;
  nextToken?: string;
  orderBy?: string;
  orderDirection?: string;
  roleTypes?: string[][];
  toDueTime?: number;
  static names(): { [key: string]: string } {
    return {
      category: 'category',
      fromDueTime: 'fromDueTime',
      isDone: 'isDone',
      isRecycled: 'isRecycled',
      nextToken: 'nextToken',
      orderBy: 'orderBy',
      orderDirection: 'orderDirection',
      roleTypes: 'roleTypes',
      toDueTime: 'toDueTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      category: 'string',
      fromDueTime: 'number',
      isDone: 'boolean',
      isRecycled: 'boolean',
      nextToken: 'string',
      orderBy: 'string',
      orderDirection: 'string',
      roleTypes: { 'type': 'array', 'itemType': { 'type': 'array', 'itemType': 'string' } },
      toDueTime: 'number',
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
  statusCode: number;
  body: QueryTodoTasksResponseBody;
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
      body: QueryTodoTasksResponseBody,
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
  description?: string;
  done?: boolean;
  dueTime?: number;
  executorIds?: string[];
  participantIds?: string[];
  subject?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'description',
      done: 'done',
      dueTime: 'dueTime',
      executorIds: 'executorIds',
      participantIds: 'participantIds',
      subject: 'subject',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      done: 'boolean',
      dueTime: 'number',
      executorIds: { 'type': 'array', 'itemType': 'string' },
      participantIds: { 'type': 'array', 'itemType': 'string' },
      subject: 'string',
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
  statusCode: number;
  body: UpdateTodoTaskResponseBody;
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
      body: UpdateTodoTaskResponseBody,
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
  statusCode: number;
  body: UpdateTodoTaskExecutorStatusResponseBody;
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
      body: UpdateTodoTaskExecutorStatusResponseBody,
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
  actionList?: UpdateTodoTypeConfigRequestActionList[];
  cardType?: number;
  contentFieldList?: UpdateTodoTypeConfigRequestContentFieldList[];
  description?: string;
  icon?: string;
  pcDetailUrlOpenMode?: string;
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      actionList: 'actionList',
      cardType: 'cardType',
      contentFieldList: 'contentFieldList',
      description: 'description',
      icon: 'icon',
      pcDetailUrlOpenMode: 'pcDetailUrlOpenMode',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionList: { 'type': 'array', 'itemType': UpdateTodoTypeConfigRequestActionList },
      cardType: 'number',
      contentFieldList: { 'type': 'array', 'itemType': UpdateTodoTypeConfigRequestContentFieldList },
      description: 'string',
      icon: 'string',
      pcDetailUrlOpenMode: 'string',
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
  statusCode: number;
  body: UpdateTodoTypeConfigResponseBody;
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
      body: UpdateTodoTypeConfigResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskRequestActionListParam extends $tea.Model {
  body?: string;
  header?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      body: 'body',
      header: 'header',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: 'string',
      header: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskRequestActionList extends $tea.Model {
  actionKey?: string;
  actionType?: number;
  buttonStyleType?: number;
  param?: CreateTodoTaskRequestActionListParam;
  pcUrl?: string;
  title?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      actionType: 'actionType',
      buttonStyleType: 'buttonStyleType',
      param: 'param',
      pcUrl: 'pcUrl',
      title: 'title',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      actionType: 'number',
      buttonStyleType: 'number',
      param: CreateTodoTaskRequestActionListParam,
      pcUrl: 'string',
      title: 'string',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskRequestContentFieldList extends $tea.Model {
  fieldKey?: string;
  fieldValue?: string;
  static names(): { [key: string]: string } {
    return {
      fieldKey: 'fieldKey',
      fieldValue: 'fieldValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldKey: 'string',
      fieldValue: 'string',
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
  dingNotify?: string;
  static names(): { [key: string]: string } {
    return {
      dingNotify: 'dingNotify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingNotify: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskResponseBodyContentFieldList extends $tea.Model {
  fieldKey?: string;
  fieldValue?: string;
  static names(): { [key: string]: string } {
    return {
      fieldKey: 'fieldKey',
      fieldValue: 'fieldValue',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fieldKey: 'string',
      fieldValue: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTaskResponseBodyDetailUrl extends $tea.Model {
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

export class CreateTodoTaskResponseBodyNotifyConfigs extends $tea.Model {
  dingNotify?: string;
  static names(): { [key: string]: string } {
    return {
      dingNotify: 'dingNotify',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingNotify: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateTodoTypeConfigRequestActionList extends $tea.Model {
  actionKey?: string;
  actionType?: number;
  buttonStyleType?: number;
  nameI18n?: { [key: string]: any };
  url?: string;
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      actionType: 'actionType',
      buttonStyleType: 'buttonStyleType',
      nameI18n: 'nameI18n',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      actionType: 'number',
      buttonStyleType: 'number',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      url: 'string',
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

export class CreateTodoTypeConfigResponseBodyActionList extends $tea.Model {
  actionKey?: string;
  actionType?: number;
  buttonStyleType?: number;
  nameI18n?: { [key: string]: any };
  url?: string;
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      actionType: 'actionType',
      buttonStyleType: 'buttonStyleType',
      nameI18n: 'nameI18n',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      actionType: 'number',
      buttonStyleType: 'number',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      url: 'string',
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

export class GetTodoTaskResponseBodyDetailUrl extends $tea.Model {
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

export class GetTodoTaskBySourceIdResponseBodyDetailUrl extends $tea.Model {
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

export class GetTodoTaskDetailResponseBodyDetailUrl extends $tea.Model {
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

export class GetTodoTaskDetailResponseBodyExecutorStatus extends $tea.Model {
  isDone?: boolean;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      isDone: 'isDone',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isDone: 'boolean',
      userId: 'string',
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

export class GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList extends $tea.Model {
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

export class GetTodoTaskDetailResponseBodyTodoCardView extends $tea.Model {
  actionType?: string;
  cardType?: string;
  circleELType?: string;
  contentType?: string;
  icon?: string;
  todoCardContentList?: GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList[];
  todoCardTitle?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      cardType: 'cardType',
      circleELType: 'circleELType',
      contentType: 'contentType',
      icon: 'icon',
      todoCardContentList: 'todoCardContentList',
      todoCardTitle: 'todoCardTitle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'string',
      cardType: 'string',
      circleELType: 'string',
      contentType: 'string',
      icon: 'string',
      todoCardContentList: { 'type': 'array', 'itemType': GetTodoTaskDetailResponseBodyTodoCardViewTodoCardContentList },
      todoCardTitle: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetTodoTypeConfigResponseBodyActionList extends $tea.Model {
  actionKey?: string;
  actionType?: number;
  buttonStyleType?: number;
  nameI18n?: { [key: string]: any };
  url?: string;
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      actionType: 'actionType',
      buttonStyleType: 'buttonStyleType',
      nameI18n: 'nameI18n',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      actionType: 'number',
      buttonStyleType: 'number',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      url: 'string',
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

export class QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl extends $tea.Model {
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

export class QueryOrgTodoByUserResponseBodyTodoCards extends $tea.Model {
  bizTag?: string;
  createdTime?: number;
  creatorId?: string;
  detailUrl?: QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl;
  dueTime?: number;
  isDone?: boolean;
  modifiedTime?: number;
  priority?: number;
  sourceExt?: string;
  sourceId?: string;
  subject?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      detailUrl: 'detailUrl',
      dueTime: 'dueTime',
      isDone: 'isDone',
      modifiedTime: 'modifiedTime',
      priority: 'priority',
      sourceExt: 'sourceExt',
      sourceId: 'sourceId',
      subject: 'subject',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      createdTime: 'number',
      creatorId: 'string',
      detailUrl: QueryOrgTodoByUserResponseBodyTodoCardsDetailUrl,
      dueTime: 'number',
      isDone: 'boolean',
      modifiedTime: 'number',
      priority: 'number',
      sourceExt: 'string',
      sourceId: 'string',
      subject: 'string',
      taskId: 'string',
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
  bizTag?: string;
  createdTime?: number;
  creatorId?: string;
  detailUrl?: QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl;
  dueTime?: number;
  isDone?: boolean;
  modifiedTime?: number;
  priority?: number;
  sourceId?: string;
  subject?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      detailUrl: 'detailUrl',
      dueTime: 'dueTime',
      isDone: 'isDone',
      modifiedTime: 'modifiedTime',
      priority: 'priority',
      sourceId: 'sourceId',
      subject: 'subject',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      createdTime: 'number',
      creatorId: 'string',
      detailUrl: QueryOrgTodoTasksResponseBodyTodoCardsDetailUrl,
      dueTime: 'number',
      isDone: 'boolean',
      modifiedTime: 'number',
      priority: 'number',
      sourceId: 'string',
      subject: 'string',
      taskId: 'string',
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
  actionType?: string;
  cardType?: string;
  circleELType?: string;
  contentType?: string;
  icon?: string;
  todoCardContentList?: QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList[];
  todoCardTitle?: string;
  static names(): { [key: string]: string } {
    return {
      actionType: 'actionType',
      cardType: 'cardType',
      circleELType: 'circleELType',
      contentType: 'contentType',
      icon: 'icon',
      todoCardContentList: 'todoCardContentList',
      todoCardTitle: 'todoCardTitle',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionType: 'string',
      cardType: 'string',
      circleELType: 'string',
      contentType: 'string',
      icon: 'string',
      todoCardContentList: { 'type': 'array', 'itemType': QueryTodoTasksResponseBodyTodoCardsTodoCardViewTodoCardContentList },
      todoCardTitle: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTodoTasksResponseBodyTodoCards extends $tea.Model {
  bizTag?: string;
  category?: string;
  createdTime?: number;
  creatorId?: string;
  detailUrl?: QueryTodoTasksResponseBodyTodoCardsDetailUrl;
  dueTime?: number;
  isDone?: boolean;
  modifiedTime?: number;
  orgInfo?: QueryTodoTasksResponseBodyTodoCardsOrgInfo;
  originalSource?: QueryTodoTasksResponseBodyTodoCardsOriginalSource;
  priority?: number;
  sourceId?: string;
  subject?: string;
  taskId?: string;
  todoCardView?: QueryTodoTasksResponseBodyTodoCardsTodoCardView;
  todoStatus?: string;
  static names(): { [key: string]: string } {
    return {
      bizTag: 'bizTag',
      category: 'category',
      createdTime: 'createdTime',
      creatorId: 'creatorId',
      detailUrl: 'detailUrl',
      dueTime: 'dueTime',
      isDone: 'isDone',
      modifiedTime: 'modifiedTime',
      orgInfo: 'orgInfo',
      originalSource: 'originalSource',
      priority: 'priority',
      sourceId: 'sourceId',
      subject: 'subject',
      taskId: 'taskId',
      todoCardView: 'todoCardView',
      todoStatus: 'todoStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizTag: 'string',
      category: 'string',
      createdTime: 'number',
      creatorId: 'string',
      detailUrl: QueryTodoTasksResponseBodyTodoCardsDetailUrl,
      dueTime: 'number',
      isDone: 'boolean',
      modifiedTime: 'number',
      orgInfo: QueryTodoTasksResponseBodyTodoCardsOrgInfo,
      originalSource: QueryTodoTasksResponseBodyTodoCardsOriginalSource,
      priority: 'number',
      sourceId: 'string',
      subject: 'string',
      taskId: 'string',
      todoCardView: QueryTodoTasksResponseBodyTodoCardsTodoCardView,
      todoStatus: 'string',
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

export class UpdateTodoTypeConfigRequestActionList extends $tea.Model {
  actionKey?: string;
  actionType?: number;
  buttonStyleType?: number;
  nameI18n?: { [key: string]: any };
  url?: string;
  static names(): { [key: string]: string } {
    return {
      actionKey: 'actionKey',
      actionType: 'actionType',
      buttonStyleType: 'buttonStyleType',
      nameI18n: 'nameI18n',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionKey: 'string',
      actionType: 'number',
      buttonStyleType: 'number',
      nameI18n: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      url: 'string',
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


export default class Client extends OpenApi {
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async countTodoTasksWithOptions(unionId: string, request: CountTodoTasksRequest, headers: CountTodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<CountTodoTasksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.fromDueTime)) {
      body["fromDueTime"] = request.fromDueTime;
    }

    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
    }

    if (!Util.isUnset(request.isRecycled)) {
      body["isRecycled"] = request.isRecycled;
    }

    if (!Util.isUnset(request.roleTypes)) {
      body["roleTypes"] = request.roleTypes;
    }

    if (!Util.isUnset(request.toDueTime)) {
      body["toDueTime"] = request.toDueTime;
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
      action: "CountTodoTasks",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks/count`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CountTodoTasksResponse>(await this.execute(params, req, runtime), new CountTodoTasksResponse({}));
  }

  async countTodoTasks(unionId: string, request: CountTodoTasksRequest): Promise<CountTodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CountTodoTasksHeaders({ });
    return await this.countTodoTasksWithOptions(unionId, request, headers, runtime);
  }

  async createTodoTaskWithOptions(unionId: string, request: CreateTodoTaskRequest, headers: CreateTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTodoTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionList)) {
      body["actionList"] = request.actionList;
    }

    if (!Util.isUnset(request.bizCategoryId)) {
      body["bizCategoryId"] = request.bizCategoryId;
    }

    if (!Util.isUnset(request.contentFieldList)) {
      body["contentFieldList"] = request.contentFieldList;
    }

    if (!Util.isUnset(request.creatorId)) {
      body["creatorId"] = request.creatorId;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.detailUrl)) {
      body["detailUrl"] = request.detailUrl;
    }

    if (!Util.isUnset(request.dueTime)) {
      body["dueTime"] = request.dueTime;
    }

    if (!Util.isUnset(request.executorIds)) {
      body["executorIds"] = request.executorIds;
    }

    if (!Util.isUnset(request.isOnlyShowExecutor)) {
      body["isOnlyShowExecutor"] = request.isOnlyShowExecutor;
    }

    if (!Util.isUnset(request.notifyConfigs)) {
      body["notifyConfigs"] = request.notifyConfigs;
    }

    if (!Util.isUnset(request.participantIds)) {
      body["participantIds"] = request.participantIds;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.sourceId)) {
      body["sourceId"] = request.sourceId;
    }

    if (!Util.isUnset(request.subject)) {
      body["subject"] = request.subject;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateTodoTask",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTodoTaskResponse>(await this.execute(params, req, runtime), new CreateTodoTaskResponse({}));
  }

  async createTodoTask(unionId: string, request: CreateTodoTaskRequest): Promise<CreateTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTodoTaskHeaders({ });
    return await this.createTodoTaskWithOptions(unionId, request, headers, runtime);
  }

  async createTodoTypeConfigWithOptions(unionId: string, request: CreateTodoTypeConfigRequest, headers: CreateTodoTypeConfigHeaders, runtime: $Util.RuntimeOptions): Promise<CreateTodoTypeConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionList)) {
      body["actionList"] = request.actionList;
    }

    if (!Util.isUnset(request.cardType)) {
      body["cardType"] = request.cardType;
    }

    if (!Util.isUnset(request.contentFieldList)) {
      body["contentFieldList"] = request.contentFieldList;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.pcDetailUrlOpenMode)) {
      body["pcDetailUrlOpenMode"] = request.pcDetailUrlOpenMode;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "CreateTodoTypeConfig",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/configs/types`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateTodoTypeConfigResponse>(await this.execute(params, req, runtime), new CreateTodoTypeConfigResponse({}));
  }

  async createTodoTypeConfig(unionId: string, request: CreateTodoTypeConfigRequest): Promise<CreateTodoTypeConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateTodoTypeConfigHeaders({ });
    return await this.createTodoTypeConfigWithOptions(unionId, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    let params = new $OpenApi.Params({
      action: "DeleteTodoTask",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks/${taskId}`,
      method: "DELETE",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteTodoTaskResponse>(await this.execute(params, req, runtime), new DeleteTodoTaskResponse({}));
  }

  async deleteTodoTask(unionId: string, taskId: string, request: DeleteTodoTaskRequest): Promise<DeleteTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteTodoTaskHeaders({ });
    return await this.deleteTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
  }

  async getTodoTaskWithOptions(unionId: string, taskId: string, headers: GetTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTaskResponse> {
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
      action: "GetTodoTask",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks/${taskId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTodoTaskResponse>(await this.execute(params, req, runtime), new GetTodoTaskResponse({}));
  }

  async getTodoTask(unionId: string, taskId: string): Promise<GetTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTaskHeaders({ });
    return await this.getTodoTaskWithOptions(unionId, taskId, headers, runtime);
  }

  async getTodoTaskBySourceIdWithOptions(unionId: string, sourceId: string, headers: GetTodoTaskBySourceIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTaskBySourceIdResponse> {
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
      action: "GetTodoTaskBySourceId",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks/sources/${sourceId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTodoTaskBySourceIdResponse>(await this.execute(params, req, runtime), new GetTodoTaskBySourceIdResponse({}));
  }

  async getTodoTaskBySourceId(unionId: string, sourceId: string): Promise<GetTodoTaskBySourceIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTaskBySourceIdHeaders({ });
    return await this.getTodoTaskBySourceIdWithOptions(unionId, sourceId, headers, runtime);
  }

  async getTodoTaskDetailWithOptions(taskId: string, unionId: string, headers: GetTodoTaskDetailHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTaskDetailResponse> {
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
      action: "GetTodoTaskDetail",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/exclusive/users/${unionId}/tasks/${taskId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTodoTaskDetailResponse>(await this.execute(params, req, runtime), new GetTodoTaskDetailResponse({}));
  }

  async getTodoTaskDetail(taskId: string, unionId: string): Promise<GetTodoTaskDetailResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTaskDetailHeaders({ });
    return await this.getTodoTaskDetailWithOptions(taskId, unionId, headers, runtime);
  }

  async getTodoTypeConfigWithOptions(unionId: string, cardTypeId: string, headers: GetTodoTypeConfigHeaders, runtime: $Util.RuntimeOptions): Promise<GetTodoTypeConfigResponse> {
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
      action: "GetTodoTypeConfig",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/configs/types/${cardTypeId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetTodoTypeConfigResponse>(await this.execute(params, req, runtime), new GetTodoTypeConfigResponse({}));
  }

  async getTodoTypeConfig(unionId: string, cardTypeId: string): Promise<GetTodoTypeConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetTodoTypeConfigHeaders({ });
    return await this.getTodoTypeConfigWithOptions(unionId, cardTypeId, headers, runtime);
  }

  async queryOrgTodoByUserWithOptions(unionId: string, request: QueryOrgTodoByUserRequest, headers: QueryOrgTodoByUserHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgTodoByUserResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.fromDueTime)) {
      body["fromDueTime"] = request.fromDueTime;
    }

    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
    }

    if (!Util.isUnset(request.maxResults)) {
      body["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.orderBy)) {
      body["orderBy"] = request.orderBy;
    }

    if (!Util.isUnset(request.orderDirection)) {
      body["orderDirection"] = request.orderDirection;
    }

    if (!Util.isUnset(request.roleTypes)) {
      body["roleTypes"] = request.roleTypes;
    }

    if (!Util.isUnset(request.subject)) {
      body["subject"] = request.subject;
    }

    if (!Util.isUnset(request.toDueTime)) {
      body["toDueTime"] = request.toDueTime;
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
      action: "QueryOrgTodoByUser",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/organizations/tasks/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOrgTodoByUserResponse>(await this.execute(params, req, runtime), new QueryOrgTodoByUserResponse({}));
  }

  async queryOrgTodoByUser(unionId: string, request: QueryOrgTodoByUserRequest): Promise<QueryOrgTodoByUserResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgTodoByUserHeaders({ });
    return await this.queryOrgTodoByUserWithOptions(unionId, request, headers, runtime);
  }

  async queryOrgTodoTasksWithOptions(unionId: string, request: QueryOrgTodoTasksRequest, headers: QueryOrgTodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgTodoTasksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
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
      action: "QueryOrgTodoTasks",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/org/tasks/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryOrgTodoTasksResponse>(await this.execute(params, req, runtime), new QueryOrgTodoTasksResponse({}));
  }

  async queryOrgTodoTasks(unionId: string, request: QueryOrgTodoTasksRequest): Promise<QueryOrgTodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgTodoTasksHeaders({ });
    return await this.queryOrgTodoTasksWithOptions(unionId, request, headers, runtime);
  }

  async queryTodoTasksWithOptions(unionId: string, request: QueryTodoTasksRequest, headers: QueryTodoTasksHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTodoTasksResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.category)) {
      body["category"] = request.category;
    }

    if (!Util.isUnset(request.fromDueTime)) {
      body["fromDueTime"] = request.fromDueTime;
    }

    if (!Util.isUnset(request.isDone)) {
      body["isDone"] = request.isDone;
    }

    if (!Util.isUnset(request.isRecycled)) {
      body["isRecycled"] = request.isRecycled;
    }

    if (!Util.isUnset(request.nextToken)) {
      body["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.orderBy)) {
      body["orderBy"] = request.orderBy;
    }

    if (!Util.isUnset(request.orderDirection)) {
      body["orderDirection"] = request.orderDirection;
    }

    if (!Util.isUnset(request.roleTypes)) {
      body["roleTypes"] = request.roleTypes;
    }

    if (!Util.isUnset(request.toDueTime)) {
      body["toDueTime"] = request.toDueTime;
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
      action: "QueryTodoTasks",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks/list`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryTodoTasksResponse>(await this.execute(params, req, runtime), new QueryTodoTasksResponse({}));
  }

  async queryTodoTasks(unionId: string, request: QueryTodoTasksRequest): Promise<QueryTodoTasksResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTodoTasksHeaders({ });
    return await this.queryTodoTasksWithOptions(unionId, request, headers, runtime);
  }

  async updateTodoTaskWithOptions(unionId: string, taskId: string, request: UpdateTodoTaskRequest, headers: UpdateTodoTaskHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTodoTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.done)) {
      body["done"] = request.done;
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

    if (!Util.isUnset(request.subject)) {
      body["subject"] = request.subject;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateTodoTask",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks/${taskId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTodoTaskResponse>(await this.execute(params, req, runtime), new UpdateTodoTaskResponse({}));
  }

  async updateTodoTask(unionId: string, taskId: string, request: UpdateTodoTaskRequest): Promise<UpdateTodoTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTodoTaskHeaders({ });
    return await this.updateTodoTaskWithOptions(unionId, taskId, request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateTodoTaskExecutorStatus",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/tasks/${taskId}/executorStatus`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTodoTaskExecutorStatusResponse>(await this.execute(params, req, runtime), new UpdateTodoTaskExecutorStatusResponse({}));
  }

  async updateTodoTaskExecutorStatus(unionId: string, taskId: string, request: UpdateTodoTaskExecutorStatusRequest): Promise<UpdateTodoTaskExecutorStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTodoTaskExecutorStatusHeaders({ });
    return await this.updateTodoTaskExecutorStatusWithOptions(unionId, taskId, request, headers, runtime);
  }

  async updateTodoTypeConfigWithOptions(unionId: string, cardTypeId: string, request: UpdateTodoTypeConfigRequest, headers: UpdateTodoTypeConfigHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateTodoTypeConfigResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorId)) {
      query["operatorId"] = request.operatorId;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.actionList)) {
      body["actionList"] = request.actionList;
    }

    if (!Util.isUnset(request.cardType)) {
      body["cardType"] = request.cardType;
    }

    if (!Util.isUnset(request.contentFieldList)) {
      body["contentFieldList"] = request.contentFieldList;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.pcDetailUrlOpenMode)) {
      body["pcDetailUrlOpenMode"] = request.pcDetailUrlOpenMode;
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
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "UpdateTodoTypeConfig",
      version: "todo_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todo/users/${unionId}/configs/types/${cardTypeId}`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateTodoTypeConfigResponse>(await this.execute(params, req, runtime), new UpdateTodoTypeConfigResponse({}));
  }

  async updateTodoTypeConfig(unionId: string, cardTypeId: string, request: UpdateTodoTypeConfigRequest): Promise<UpdateTodoTypeConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateTodoTypeConfigHeaders({ });
    return await this.updateTodoTypeConfigWithOptions(unionId, cardTypeId, request, headers, runtime);
  }

}
