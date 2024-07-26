// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  /**
   * @remarks
   * This parameter is required.
   */
  agentCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExecuteAgentResponseBody;
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

export class LiandanTextImageGetHeaders extends $tea.Model {
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

export class LiandanTextImageGetRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * IMAGE
   */
  module?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 123
   */
  taskId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      module: 'module',
      taskId: 'taskId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      module: 'string',
      taskId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanTextImageGetResponseBody extends $tea.Model {
  result?: { [key: string]: any }[];
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
      result: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'any' } },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanTextImageGetResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LiandanTextImageGetResponseBody;
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
      body: LiandanTextImageGetResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanluExclusiveModelHeaders extends $tea.Model {
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

export class LiandanluExclusiveModelRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * maas1234
   */
  modelId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * GENERAL
   */
  module?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * OKR是什么
   */
  prompt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 使用该功能的用户id
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      modelId: 'modelId',
      module: 'module',
      prompt: 'prompt',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      modelId: 'string',
      module: 'string',
      prompt: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanluExclusiveModelResponseBody extends $tea.Model {
  /**
   * @example
   * requestId_123
   */
  requestId?: string;
  /**
   * @example
   * {        "content":"OKR 全称为 Objective and Key Results，即目标与关键结果法，是一套明确和跟踪目标及其完成情况的管理工具和方法。"   }
   */
  result?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      result: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanluExclusiveModelResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LiandanluExclusiveModelResponseBody;
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
      body: LiandanluExclusiveModelResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanluTextToImageModelHeaders extends $tea.Model {
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

export class LiandanluTextToImageModelRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * IMAGE
   */
  module?: string;
  /**
   * @example
   * 1
   */
  number?: number;
  parameters?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 画一副风景画
   */
  prompt?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      module: 'module',
      number: 'number',
      parameters: 'parameters',
      prompt: 'prompt',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      module: 'string',
      number: 'number',
      parameters: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      prompt: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanluTextToImageModelResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  result?: LiandanluTextToImageModelResponseBodyResult;
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
      result: LiandanluTextToImageModelResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class LiandanluTextToImageModelResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: LiandanluTextToImageModelResponseBody;
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
      body: LiandanluTextToImageModelResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NLToFrameServiceHeaders extends $tea.Model {
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

export class NLToFrameServiceRequest extends $tea.Model {
  extensionStr?: string;
  isNewModel?: boolean;
  /**
   * @remarks
   * This parameter is required.
   */
  modelId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  modelName?: string;
  userId?: number;
  static names(): { [key: string]: string } {
    return {
      extensionStr: 'extensionStr',
      isNewModel: 'isNewModel',
      modelId: 'modelId',
      modelName: 'modelName',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extensionStr: 'string',
      isNewModel: 'boolean',
      modelId: 'string',
      modelName: 'string',
      userId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class NLToFrameServiceResponseBody extends $tea.Model {
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

export class NLToFrameServiceResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: NLToFrameServiceResponseBody;
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
      body: NLToFrameServiceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBaymaxSkillLogHeaders extends $tea.Model {
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

export class QueryBaymaxSkillLogRequest extends $tea.Model {
  from?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  logLevel?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  skillExecuteId?: string;
  to?: number;
  static names(): { [key: string]: string } {
    return {
      from: 'from',
      logLevel: 'logLevel',
      skillExecuteId: 'skillExecuteId',
      to: 'to',
    };
  }

  static types(): { [key: string]: any } {
    return {
      from: 'number',
      logLevel: 'string',
      skillExecuteId: 'string',
      to: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBaymaxSkillLogResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
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

export class QueryBaymaxSkillLogResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBaymaxSkillLogResponseBody;
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
      body: QueryBaymaxSkillLogResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryConversationMessageForAIResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  agentCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMemoryLearningTaskResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   */
  agentCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  content?: SubmitMemoryLearningTaskRequestContent;
  /**
   * @remarks
   * This parameter is required.
   */
  learningMode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  /**
   * @remarks
   * This parameter is required.
   */
  agentCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contentShrink?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  learningMode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SubmitMemoryLearningTaskResponseBody;
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

export class LiandanluTextToImageModelResponseBodyResult extends $tea.Model {
  /**
   * @example
   * 0112_1222
   */
  requestId?: string;
  /**
   * @example
   * 123
   */
  taskId?: string;
  /**
   * @example
   * SUCCEEDED
   */
  taskStatus?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'requestId',
      taskId: 'taskId',
      taskStatus: 'taskStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      taskId: 'string',
      taskStatus: 'string',
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
   * 执行AI技能
   * 
   * @param request - ExecuteAgentRequest
   * @param headers - ExecuteAgentHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExecuteAgentResponse
   */
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

  /**
   * 执行AI技能
   * 
   * @param request - ExecuteAgentRequest
   * @returns ExecuteAgentResponse
   */
  async executeAgent(request: ExecuteAgentRequest): Promise<ExecuteAgentResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteAgentHeaders({ });
    return await this.executeAgentWithOptions(request, headers, runtime);
  }

  /**
   * 炼丹炉文生图任务结果获取
   * 
   * @param request - LiandanTextImageGetRequest
   * @param headers - LiandanTextImageGetHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LiandanTextImageGetResponse
   */
  async liandanTextImageGetWithOptions(request: LiandanTextImageGetRequest, headers: LiandanTextImageGetHeaders, runtime: $Util.RuntimeOptions): Promise<LiandanTextImageGetResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.module)) {
      body["module"] = request.module;
    }

    if (!Util.isUnset(request.taskId)) {
      body["taskId"] = request.taskId;
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
      action: "LiandanTextImageGet",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/ai/textToImage/results/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LiandanTextImageGetResponse>(await this.execute(params, req, runtime), new LiandanTextImageGetResponse({}));
  }

  /**
   * 炼丹炉文生图任务结果获取
   * 
   * @param request - LiandanTextImageGetRequest
   * @returns LiandanTextImageGetResponse
   */
  async liandanTextImageGet(request: LiandanTextImageGetRequest): Promise<LiandanTextImageGetResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LiandanTextImageGetHeaders({ });
    return await this.liandanTextImageGetWithOptions(request, headers, runtime);
  }

  /**
   * 炼丹炉专属模型接口
   * 
   * @param request - LiandanluExclusiveModelRequest
   * @param headers - LiandanluExclusiveModelHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LiandanluExclusiveModelResponse
   */
  async liandanluExclusiveModelWithOptions(request: LiandanluExclusiveModelRequest, headers: LiandanluExclusiveModelHeaders, runtime: $Util.RuntimeOptions): Promise<LiandanluExclusiveModelResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.modelId)) {
      body["modelId"] = request.modelId;
    }

    if (!Util.isUnset(request.module)) {
      body["module"] = request.module;
    }

    if (!Util.isUnset(request.prompt)) {
      body["prompt"] = request.prompt;
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
      action: "LiandanluExclusiveModel",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/ai/generate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LiandanluExclusiveModelResponse>(await this.execute(params, req, runtime), new LiandanluExclusiveModelResponse({}));
  }

  /**
   * 炼丹炉专属模型接口
   * 
   * @param request - LiandanluExclusiveModelRequest
   * @returns LiandanluExclusiveModelResponse
   */
  async liandanluExclusiveModel(request: LiandanluExclusiveModelRequest): Promise<LiandanluExclusiveModelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LiandanluExclusiveModelHeaders({ });
    return await this.liandanluExclusiveModelWithOptions(request, headers, runtime);
  }

  /**
   * 炼丹炉通过提示词生成图片
   * 
   * @param request - LiandanluTextToImageModelRequest
   * @param headers - LiandanluTextToImageModelHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns LiandanluTextToImageModelResponse
   */
  async liandanluTextToImageModelWithOptions(request: LiandanluTextToImageModelRequest, headers: LiandanluTextToImageModelHeaders, runtime: $Util.RuntimeOptions): Promise<LiandanluTextToImageModelResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.module)) {
      body["module"] = request.module;
    }

    if (!Util.isUnset(request.number)) {
      body["number"] = request.number;
    }

    if (!Util.isUnset(request.parameters)) {
      body["parameters"] = request.parameters;
    }

    if (!Util.isUnset(request.prompt)) {
      body["prompt"] = request.prompt;
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
      action: "LiandanluTextToImageModel",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/ai/textToImage/generate`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<LiandanluTextToImageModelResponse>(await this.execute(params, req, runtime), new LiandanluTextToImageModelResponse({}));
  }

  /**
   * 炼丹炉通过提示词生成图片
   * 
   * @param request - LiandanluTextToImageModelRequest
   * @returns LiandanluTextToImageModelResponse
   */
  async liandanluTextToImageModel(request: LiandanluTextToImageModelRequest): Promise<LiandanluTextToImageModelResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new LiandanluTextToImageModelHeaders({ });
    return await this.liandanluTextToImageModelWithOptions(request, headers, runtime);
  }

  /**
   * 通过配置的指令，连接用户和系统，训练大模型
   * 
   * @param request - NLToFrameServiceRequest
   * @param headers - NLToFrameServiceHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns NLToFrameServiceResponse
   */
  async nLToFrameServiceWithOptions(request: NLToFrameServiceRequest, headers: NLToFrameServiceHeaders, runtime: $Util.RuntimeOptions): Promise<NLToFrameServiceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extensionStr)) {
      body["extensionStr"] = request.extensionStr;
    }

    if (!Util.isUnset(request.isNewModel)) {
      body["isNewModel"] = request.isNewModel;
    }

    if (!Util.isUnset(request.modelId)) {
      body["modelId"] = request.modelId;
    }

    if (!Util.isUnset(request.modelName)) {
      body["modelName"] = request.modelName;
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
      action: "NLToFrameService",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/ai/nl2frame`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<NLToFrameServiceResponse>(await this.execute(params, req, runtime), new NLToFrameServiceResponse({}));
  }

  /**
   * 通过配置的指令，连接用户和系统，训练大模型
   * 
   * @param request - NLToFrameServiceRequest
   * @returns NLToFrameServiceResponse
   */
  async nLToFrameService(request: NLToFrameServiceRequest): Promise<NLToFrameServiceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new NLToFrameServiceHeaders({ });
    return await this.nLToFrameServiceWithOptions(request, headers, runtime);
  }

  /**
   * Baymax技能执行日志
   * 
   * @param request - QueryBaymaxSkillLogRequest
   * @param headers - QueryBaymaxSkillLogHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBaymaxSkillLogResponse
   */
  async queryBaymaxSkillLogWithOptions(request: QueryBaymaxSkillLogRequest, headers: QueryBaymaxSkillLogHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBaymaxSkillLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.from)) {
      query["from"] = request.from;
    }

    if (!Util.isUnset(request.logLevel)) {
      query["logLevel"] = request.logLevel;
    }

    if (!Util.isUnset(request.skillExecuteId)) {
      query["skillExecuteId"] = request.skillExecuteId;
    }

    if (!Util.isUnset(request.to)) {
      query["to"] = request.to;
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
      action: "QueryBaymaxSkillLog",
      version: "aiPaaS_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiPaaS/skills/logs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBaymaxSkillLogResponse>(await this.execute(params, req, runtime), new QueryBaymaxSkillLogResponse({}));
  }

  /**
   * Baymax技能执行日志
   * 
   * @param request - QueryBaymaxSkillLogRequest
   * @returns QueryBaymaxSkillLogResponse
   */
  async queryBaymaxSkillLog(request: QueryBaymaxSkillLogRequest): Promise<QueryBaymaxSkillLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBaymaxSkillLogHeaders({ });
    return await this.queryBaymaxSkillLogWithOptions(request, headers, runtime);
  }

  /**
   * 查询会话消息并以大模型友好的协议返回
   * 
   * @param tmpReq - QueryConversationMessageForAIRequest
   * @param headers - QueryConversationMessageForAIHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryConversationMessageForAIResponse
   */
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

  /**
   * 查询会话消息并以大模型友好的协议返回
   * 
   * @param request - QueryConversationMessageForAIRequest
   * @returns QueryConversationMessageForAIResponse
   */
  async queryConversationMessageForAI(cid: string, request: QueryConversationMessageForAIRequest): Promise<QueryConversationMessageForAIResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConversationMessageForAIHeaders({ });
    return await this.queryConversationMessageForAIWithOptions(cid, request, headers, runtime);
  }

  /**
   * 查询记忆学习进度
   * 
   * @param request - QueryMemoryLearningTaskRequest
   * @param headers - QueryMemoryLearningTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMemoryLearningTaskResponse
   */
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

  /**
   * 查询记忆学习进度
   * 
   * @param request - QueryMemoryLearningTaskRequest
   * @returns QueryMemoryLearningTaskResponse
   */
  async queryMemoryLearningTask(request: QueryMemoryLearningTaskRequest): Promise<QueryMemoryLearningTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMemoryLearningTaskHeaders({ });
    return await this.queryMemoryLearningTaskWithOptions(request, headers, runtime);
  }

  /**
   * 提交记忆学习任务
   * 
   * @param tmpReq - SubmitMemoryLearningTaskRequest
   * @param headers - SubmitMemoryLearningTaskHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SubmitMemoryLearningTaskResponse
   */
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

  /**
   * 提交记忆学习任务
   * 
   * @param request - SubmitMemoryLearningTaskRequest
   * @returns SubmitMemoryLearningTaskResponse
   */
  async submitMemoryLearningTask(request: SubmitMemoryLearningTaskRequest): Promise<SubmitMemoryLearningTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SubmitMemoryLearningTaskHeaders({ });
    return await this.submitMemoryLearningTaskWithOptions(request, headers, runtime);
  }

}
