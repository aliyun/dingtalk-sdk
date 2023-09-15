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

export class ExecuteAgentHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteAgentRequest extends $tea.Model {
  agentCode?: string;
  inputs?: ExecuteAgentRequestInputs;
  scenarioCode?: string;
  scenarioInstanceId?: string;
  skillId?: string;
  static names(): { [key: string]: string } {
    return {
      agentCode: 'agentCode',
      inputs: 'inputs',
      scenarioCode: 'scenarioCode',
      scenarioInstanceId: 'scenarioInstanceId',
      skillId: 'skillId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentCode: 'string',
      inputs: ExecuteAgentRequestInputs,
      scenarioCode: 'string',
      scenarioInstanceId: 'string',
      skillId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteAgentResponseBody extends $tea.Model {
  result?: ExecuteAgentResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ExecuteAgentResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteAgentResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ExecuteAgentResponseBody;
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
      body: ExecuteAgentResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIRequest extends $tea.Model {
  openMsgIds?: string[];
  recentDays?: number;
  recentHours?: number;
  recentN?: number;
  static names(): { [key: string]: string } {
    return {
      openMsgIds: 'openMsgIds',
      recentDays: 'recentDays',
      recentHours: 'recentHours',
      recentN: 'recentN',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openMsgIds: { 'type': 'array', 'itemType': 'string' },
      recentDays: 'number',
      recentHours: 'number',
      recentN: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIShrinkRequest extends $tea.Model {
  openMsgIdsShrink?: string;
  recentDays?: number;
  recentHours?: number;
  recentN?: number;
  static names(): { [key: string]: string } {
    return {
      openMsgIdsShrink: 'openMsgIds',
      recentDays: 'recentDays',
      recentHours: 'recentHours',
      recentN: 'recentN',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openMsgIdsShrink: 'string',
      recentDays: 'number',
      recentHours: 'number',
      recentN: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIResponseBody extends $tea.Model {
  messages?: QueryConversationMessageForAIResponseBodyMessages[];
  static names(): { [key: string]: string } {
    return {
      messages: 'messages',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messages: { 'type': 'array', 'itemType': QueryConversationMessageForAIResponseBodyMessages },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryConversationMessageForAIResponseBody;
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
      body: QueryConversationMessageForAIResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMemoryLearningTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMemoryLearningTaskRequest extends $tea.Model {
  agentCode?: string;
  learningCode?: string;
  static names(): { [key: string]: string } {
    return {
      agentCode: 'agentCode',
      learningCode: 'learningCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentCode: 'string',
      learningCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMemoryLearningTaskResponseBody extends $tea.Model {
  result?: QueryMemoryLearningTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryMemoryLearningTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMemoryLearningTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryMemoryLearningTaskResponseBody;
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
      body: QueryMemoryLearningTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubmitMemoryLearningTaskHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubmitMemoryLearningTaskRequest extends $tea.Model {
  agentCode?: string;
  content?: SubmitMemoryLearningTaskRequestContent;
  learningMode?: string;
  memoryKey?: string;
  static names(): { [key: string]: string } {
    return {
      agentCode: 'agentCode',
      content: 'content',
      learningMode: 'learningMode',
      memoryKey: 'memoryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentCode: 'string',
      content: SubmitMemoryLearningTaskRequestContent,
      learningMode: 'string',
      memoryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubmitMemoryLearningTaskShrinkRequest extends $tea.Model {
  agentCode?: string;
  contentShrink?: string;
  learningMode?: string;
  memoryKey?: string;
  static names(): { [key: string]: string } {
    return {
      agentCode: 'agentCode',
      contentShrink: 'content',
      learningMode: 'learningMode',
      memoryKey: 'memoryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentCode: 'string',
      contentShrink: 'string',
      learningMode: 'string',
      memoryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubmitMemoryLearningTaskResponseBody extends $tea.Model {
  result?: SubmitMemoryLearningTaskResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SubmitMemoryLearningTaskResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubmitMemoryLearningTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SubmitMemoryLearningTaskResponseBody;
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
      body: SubmitMemoryLearningTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteAgentRequestInputs extends $tea.Model {
  cardData?: any;
  cardTemplateId?: string;
  input?: string;
  static names(): { [key: string]: string } {
    return {
      cardData: 'cardData',
      cardTemplateId: 'cardTemplateId',
      input: 'input',
    };
  }

  static types(): { [key: string]: any } {
    return {
      cardData: 'any',
      cardTemplateId: 'string',
      input: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteAgentResponseBodyResult extends $tea.Model {
  executeResult?: string;
  skillId?: string;
  static names(): { [key: string]: string } {
    return {
      executeResult: 'executeResult',
      skillId: 'skillId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      executeResult: 'string',
      skillId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIResponseBodyMessagesAtUsers extends $tea.Model {
  agentCode?: string;
  nick?: string;
  type?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      agentCode: 'agentCode',
      nick: 'nick',
      type: 'type',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentCode: 'string',
      nick: 'string',
      type: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIResponseBodyMessagesSender extends $tea.Model {
  agentCode?: string;
  nick?: string;
  type?: string;
  unionId?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      agentCode: 'agentCode',
      nick: 'nick',
      type: 'type',
      unionId: 'unionId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentCode: 'string',
      nick: 'string',
      type: 'string',
      unionId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConversationMessageForAIResponseBodyMessages extends $tea.Model {
  atAll?: boolean;
  atUsers?: QueryConversationMessageForAIResponseBodyMessagesAtUsers[];
  msgContent?: string;
  msgType?: string;
  sendTime?: string;
  sender?: QueryConversationMessageForAIResponseBodyMessagesSender;
  summary?: string;
  static names(): { [key: string]: string } {
    return {
      atAll: 'atAll',
      atUsers: 'atUsers',
      msgContent: 'msgContent',
      msgType: 'msgType',
      sendTime: 'sendTime',
      sender: 'sender',
      summary: 'summary',
    };
  }

  static types(): { [key: string]: any } {
    return {
      atAll: 'boolean',
      atUsers: { 'type': 'array', 'itemType': QueryConversationMessageForAIResponseBodyMessagesAtUsers },
      msgContent: 'string',
      msgType: 'string',
      sendTime: 'string',
      sender: QueryConversationMessageForAIResponseBodyMessagesSender,
      summary: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMemoryLearningTaskResponseBodyResult extends $tea.Model {
  status?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubmitMemoryLearningTaskRequestContent extends $tea.Model {
  knowledgeBaseUrl?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      knowledgeBaseUrl: 'knowledgeBaseUrl',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      knowledgeBaseUrl: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SubmitMemoryLearningTaskResponseBodyResult extends $tea.Model {
  learningCode?: string;
  status?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      learningCode: 'learningCode',
      status: 'status',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      learningCode: 'string',
      status: 'string',
      success: 'boolean',
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


  async executeAgentWithOptions(request: ExecuteAgentRequest, headers: ExecuteAgentHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteAgentResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentCode)) {
      body["agentCode"] = request.agentCode;
    }

    if (!Util.isUnset(request.inputs)) {
      body["inputs"] = request.inputs;
    }

    if (!Util.isUnset(request.scenarioCode)) {
      body["scenarioCode"] = request.scenarioCode;
    }

    if (!Util.isUnset(request.scenarioInstanceId)) {
      body["scenarioInstanceId"] = request.scenarioInstanceId;
    }

    if (!Util.isUnset(request.skillId)) {
      body["skillId"] = request.skillId;
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
      action: "ExecuteAgent",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/me/agents/execute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExecuteAgentResponse>(await this.execute(params, req, runtime), new ExecuteAgentResponse({}));
  }

  async executeAgent(request: ExecuteAgentRequest): Promise<ExecuteAgentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteAgentHeaders({ });
    return await this.executeAgentWithOptions(request, headers, runtime);
  }

  async queryConversationMessageForAIWithOptions(cid: string, tmpReq: QueryConversationMessageForAIRequest, headers: QueryConversationMessageForAIHeaders, runtime: $Util.RuntimeOptions): Promise<QueryConversationMessageForAIResponse> {
    Util.validateModel(tmpReq);
    let request = new QueryConversationMessageForAIShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.openMsgIds)) {
      request.openMsgIdsShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.openMsgIds, "openMsgIds", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openMsgIdsShrink)) {
      query["openMsgIds"] = request.openMsgIdsShrink;
    }

    if (!Util.isUnset(request.recentDays)) {
      query["recentDays"] = request.recentDays;
    }

    if (!Util.isUnset(request.recentHours)) {
      query["recentHours"] = request.recentHours;
    }

    if (!Util.isUnset(request.recentN)) {
      query["recentN"] = request.recentN;
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
      action: "QueryConversationMessageForAI",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/me/memory/im/${cid}/messages`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryConversationMessageForAIResponse>(await this.execute(params, req, runtime), new QueryConversationMessageForAIResponse({}));
  }

  async queryConversationMessageForAI(cid: string, request: QueryConversationMessageForAIRequest): Promise<QueryConversationMessageForAIResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConversationMessageForAIHeaders({ });
    return await this.queryConversationMessageForAIWithOptions(cid, request, headers, runtime);
  }

  async queryMemoryLearningTaskWithOptions(request: QueryMemoryLearningTaskRequest, headers: QueryMemoryLearningTaskHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMemoryLearningTaskResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentCode)) {
      query["agentCode"] = request.agentCode;
    }

    if (!Util.isUnset(request.learningCode)) {
      query["learningCode"] = request.learningCode;
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
      action: "QueryMemoryLearningTask",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/me/memory/learningTask/get`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryMemoryLearningTaskResponse>(await this.execute(params, req, runtime), new QueryMemoryLearningTaskResponse({}));
  }

  async queryMemoryLearningTask(request: QueryMemoryLearningTaskRequest): Promise<QueryMemoryLearningTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMemoryLearningTaskHeaders({ });
    return await this.queryMemoryLearningTaskWithOptions(request, headers, runtime);
  }

  async submitMemoryLearningTaskWithOptions(tmpReq: SubmitMemoryLearningTaskRequest, headers: SubmitMemoryLearningTaskHeaders, runtime: $Util.RuntimeOptions): Promise<SubmitMemoryLearningTaskResponse> {
    Util.validateModel(tmpReq);
    let request = new SubmitMemoryLearningTaskShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.content)) {
      request.contentShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.content, "content", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentCode)) {
      query["agentCode"] = request.agentCode;
    }

    if (!Util.isUnset(request.contentShrink)) {
      query["content"] = request.contentShrink;
    }

    if (!Util.isUnset(request.learningMode)) {
      query["learningMode"] = request.learningMode;
    }

    if (!Util.isUnset(request.memoryKey)) {
      query["memoryKey"] = request.memoryKey;
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
      action: "SubmitMemoryLearningTask",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/me/memory/learningTask/put`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SubmitMemoryLearningTaskResponse>(await this.execute(params, req, runtime), new SubmitMemoryLearningTaskResponse({}));
  }

  async submitMemoryLearningTask(request: SubmitMemoryLearningTaskRequest): Promise<SubmitMemoryLearningTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubmitMemoryLearningTaskHeaders({ });
    return await this.submitMemoryLearningTaskWithOptions(request, headers, runtime);
  }

}
