// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  sucject?: string;
  description?: string;
  dueTime?: number;
  done?: boolean;
  executorIds?: string[];
  participantIds?: string[];
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      sucject: 'sucject',
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
      sucject: 'string',
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
  tenantId?: string;
  tenantType?: string;
  bizTag?: string;
  requestId?: string;
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
      tenantId: 'tenantId',
      tenantType: 'tenantType',
      bizTag: 'bizTag',
      requestId: 'requestId',
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
      tenantId: 'string',
      tenantType: 'string',
      bizTag: 'string',
      requestId: 'string',
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

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
    if (!Util.isUnset(request.sucject)) {
      body["sucject"] = request.sucject;
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

}
