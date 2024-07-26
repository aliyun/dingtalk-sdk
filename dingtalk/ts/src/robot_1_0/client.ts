// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BatchOTOQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOTOQueryRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * asdfasdfasdf
   */
  processQueryKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingcxx5317
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOTOQueryResponseBody extends $tea.Model {
  messageReadInfoList?: BatchOTOQueryResponseBodyMessageReadInfoList[];
  /**
   * @example
   * SUCESS
   */
  sendStatus?: string;
  static names(): { [key: string]: string } {
    return {
      messageReadInfoList: 'messageReadInfoList',
      sendStatus: 'sendStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      messageReadInfoList: { 'type': 'array', 'itemType': BatchOTOQueryResponseBodyMessageReadInfoList },
      sendStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOTOQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchOTOQueryResponseBody;
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
      body: BatchOTOQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingXXXXXXXXXX
   */
  chatbotId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidfCSpXXXXXXXXXXXchatbotId
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processQueryKeys?: string[];
  static names(): { [key: string]: string } {
    return {
      chatbotId: 'chatbotId',
      openConversationId: 'openConversationId',
      processQueryKeys: 'processQueryKeys',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatbotId: 'string',
      openConversationId: 'string',
      processQueryKeys: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallGroupResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5fe11095f46315d8d30d3f8XXXXXX:SYSTEM_ERROR
   */
  failedResult?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  successResult?: string[];
  static names(): { [key: string]: string } {
    return {
      failedResult: 'failedResult',
      successResult: 'successResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedResult: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      successResult: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchRecallGroupResponseBody;
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
      body: BatchRecallGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallOTOHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallOTORequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  processQueryKeys?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingXXXXXX
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKeys: 'processQueryKeys',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKeys: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallOTOResponseBody extends $tea.Model {
  /**
   * @example
   * b5fe11095f46315d8d30d3f8XXXXXX:system error
   */
  failedResult?: { [key: string]: string };
  successResult?: string[];
  static names(): { [key: string]: string } {
    return {
      failedResult: 'failedResult',
      successResult: 'successResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedResult: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      successResult: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallOTOResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchRecallOTOResponseBody;
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
      body: BatchRecallOTOResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallPrivateChatHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallPrivateChatRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidfCSpXXXXXXXXXXXchatbotId
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processQueryKeys?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingXXXXXXXXXX
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      processQueryKeys: 'processQueryKeys',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      processQueryKeys: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallPrivateChatResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5fe11095f46315d8d30d3f8XXXXXX:SYSTEM_ERROR
   */
  failedResult?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  successResult?: string[];
  static names(): { [key: string]: string } {
    return {
      failedResult: 'failedResult',
      successResult: 'successResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedResult: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      successResult: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchRecallPrivateChatResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchRecallPrivateChatResponseBody;
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
      body: BatchRecallPrivateChatResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOTOHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOTORequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleMarkdown
   */
  msgKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"text": "hello dafu","title": "hello title"}
   */
  msgParam?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingxxxxxx
   */
  robotCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      msgKey: 'msgKey',
      msgParam: 'msgParam',
      robotCode: 'robotCode',
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgKey: 'string',
      msgParam: 'string',
      robotCode: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOTOResponseBody extends $tea.Model {
  flowControlledStaffIdList?: string[];
  invalidStaffIdList?: string[];
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      flowControlledStaffIdList: 'flowControlledStaffIdList',
      invalidStaffIdList: 'invalidStaffIdList',
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      flowControlledStaffIdList: { 'type': 'array', 'itemType': 'string' },
      invalidStaffIdList: { 'type': 'array', 'itemType': 'string' },
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOTOResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchSendOTOResponseBody;
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
      body: BatchSendOTOResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRobotPluginHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRobotPluginRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingkxnemxbqkifzl
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ClearRobotPluginResponseBody extends $tea.Model {
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

export class ClearRobotPluginResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ClearRobotPluginResponseBody;
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
      body: ClearRobotPluginResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteRobotAiSkillHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteRobotAiSkillRequest extends $tea.Model {
  context?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  input?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  robotCode?: string;
  skillId?: string;
  static names(): { [key: string]: string } {
    return {
      context: 'context',
      input: 'input',
      robotCode: 'robotCode',
      skillId: 'skillId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      context: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      input: 'string',
      robotCode: 'string',
      skillId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteRobotAiSkillResponseBody extends $tea.Model {
  result?: string;
  skillExecuteId?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      skillExecuteId: 'skillExecuteId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      skillExecuteId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ExecuteRobotAiSkillResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ExecuteRobotAiSkillResponseBody;
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
      body: ExecuteRobotAiSkillResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBotListInGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBotListInGroupRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidjknasndcbaXXXXX
   */
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBotListInGroupResponseBody extends $tea.Model {
  chatbotInstanceVOList?: GetBotListInGroupResponseBodyChatbotInstanceVOList[];
  static names(): { [key: string]: string } {
    return {
      chatbotInstanceVOList: 'chatbotInstanceVOList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatbotInstanceVOList: { 'type': 'array', 'itemType': GetBotListInGroupResponseBodyChatbotInstanceVOList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBotListInGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetBotListInGroupResponseBody;
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
      body: GetBotListInGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManageSingleChatRobotStatusHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManageSingleChatRobotStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingykcdkjnwpcll27gm
   */
  robotCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * enable
   */
  status?: string;
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ManageSingleChatRobotStatusResponseBody extends $tea.Model {
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

export class ManageSingleChatRobotStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ManageSingleChatRobotStatusResponseBody;
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
      body: ManageSingleChatRobotStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupQueryRequest extends $tea.Model {
  /**
   * @example
   * 50
   */
  maxResults?: number;
  /**
   * @example
   * 50
   */
  nextToken?: string;
  /**
   * @example
   * cid6KeBBLoveMJOGXoYKF5x7EeiodoA==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=
   */
  processQueryKey?: string;
  /**
   * @example
   * dingue4kfzdxbyn0pjqd
   */
  robotCode?: string;
  /**
   * @example
   * 02feb1cd4ncmed92998723813a6bfa89eea1df91a750721979992870dd90bdfa
   */
  token?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      processQueryKey: 'processQueryKey',
      robotCode: 'robotCode',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openConversationId: 'string',
      processQueryKey: 'string',
      robotCode: 'string',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupQueryResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=
   */
  nextToken?: string;
  readUserIds?: string[];
  /**
   * @example
   * SUCCESS
   */
  sendStatus?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      readUserIds: 'readUserIds',
      sendStatus: 'sendStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      readUserIds: { 'type': 'array', 'itemType': 'string' },
      sendStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OrgGroupQueryResponseBody;
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
      body: OrgGroupQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupRecallHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupRecallRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidfCSpXXXXXXXXXXXchatbotId
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  processQueryKeys?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingXXXXXXXXXX
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      processQueryKeys: 'processQueryKeys',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      processQueryKeys: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupRecallResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 5fe11095f46315d8d30d3f8XXXXXX:SYSTEM_ERROR
   */
  failedResult?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   */
  successResult?: string[];
  static names(): { [key: string]: string } {
    return {
      failedResult: 'failedResult',
      successResult: 'successResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedResult: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      successResult: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupRecallResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OrgGroupRecallResponseBody;
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
      body: OrgGroupRecallResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupSendHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupSendRequest extends $tea.Model {
  /**
   * @example
   * COOLAPP-1-10182EEDD1AC0BA600D9000J
   */
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleText
   */
  msgKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"content":"今天吃肘子"}
   */
  msgParam?: string;
  /**
   * @example
   * cid6KeBBLoveMJOGXoYKF5x7EeiodoA==
   */
  openConversationId?: string;
  /**
   * @example
   * dingue4kfzdxbyn0pjqd
   */
  robotCode?: string;
  /**
   * @example
   * 02feb1cd4ncmed92998723813a6bfa89eea1df91a750721979992870dd90bdfa
   */
  token?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      msgKey: 'msgKey',
      msgParam: 'msgParam',
      openConversationId: 'openConversationId',
      robotCode: 'robotCode',
      token: 'token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      msgKey: 'string',
      msgParam: 'string',
      openConversationId: 'string',
      robotCode: 'string',
      token: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupSendResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class OrgGroupSendResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: OrgGroupSendResponseBody;
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
      body: OrgGroupSendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatQueryHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatQueryRequest extends $tea.Model {
  /**
   * @example
   * 50
   */
  maxResults?: number;
  /**
   * @example
   * 50
   */
  nextToken?: string;
  /**
   * @example
   * cid6KeBBLoveMJOGXoYKF5x7EeiodoA==
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=
   */
  processQueryKey?: string;
  /**
   * @example
   * dingue4kfzdxbyn0pjqd
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      openConversationId: 'openConversationId',
      processQueryKey: 'processQueryKey',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
      openConversationId: 'string',
      processQueryKey: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatQueryResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  hasMore?: boolean;
  /**
   * @example
   * Kna29Ra5pdJznx1ghavbumkQKwDzgfxZLapw55G7x0Q=
   */
  nextToken?: string;
  readUserIds?: string[];
  /**
   * @example
   * SUCCESS
   */
  sendStatus?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      nextToken: 'nextToken',
      readUserIds: 'readUserIds',
      sendStatus: 'sendStatus',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      nextToken: 'string',
      readUserIds: { 'type': 'array', 'itemType': 'string' },
      sendStatus: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatQueryResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PrivateChatQueryResponseBody;
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
      body: PrivateChatQueryResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatSendHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatSendRequest extends $tea.Model {
  /**
   * @example
   * COOLAPP-1-10182EEDD1AC0BA600D9000J
   */
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * sampleText
   */
  msgKey?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * {"content":"今天吃肘子"}
   */
  msgParam?: string;
  /**
   * @example
   * cid6KeBBLoveMJOGXoYKF5x7EeiodoA==
   */
  openConversationId?: string;
  /**
   * @example
   * dingue4kfzdxbyn0pjqd
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      coolAppCode: 'coolAppCode',
      msgKey: 'msgKey',
      msgParam: 'msgParam',
      openConversationId: 'openConversationId',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coolAppCode: 'string',
      msgKey: 'string',
      msgParam: 'string',
      openConversationId: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatSendResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrivateChatSendResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PrivateChatSendResponseBody;
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
      body: PrivateChatSendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBotInstanceInGroupInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBotInstanceInGroupInfoRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0
   */
  pageNumber?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  pageSize?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingykcdkjnwpcll27gm
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pageNumber: 'number',
      pageSize: 'number',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBotInstanceInGroupInfoResponseBody extends $tea.Model {
  hasMore?: boolean;
  openConversationIds?: string[];
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      openConversationIds: 'openConversationIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      openConversationIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBotInstanceInGroupInfoResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBotInstanceInGroupInfoResponseBody;
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
      body: QueryBotInstanceInGroupInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRobotPluginHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRobotPluginRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingykcdkjnwpcll27gm
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRobotPluginResponseBody extends $tea.Model {
  pluginInfoList?: QueryRobotPluginResponseBodyPluginInfoList[];
  static names(): { [key: string]: string } {
    return {
      pluginInfoList: 'pluginInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pluginInfoList: { 'type': 'array', 'itemType': QueryRobotPluginResponseBodyPluginInfoList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRobotPluginResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryRobotPluginResponseBody;
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
      body: QueryRobotPluginResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotMessageFileDownloadHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotMessageFileDownloadRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * mIofN681YE3f/+m+NntqpZSvSH2iMD6xP7Ow/ezdb1Wgn38tqVwL+zoRgzXipAMzmV5uhVKUlBdjKugAIvsm+TrvaPI0JYCMjvFMAlXvMWnMJsi2nZ9a0+N2c9CoV90hiB/B+fEThASPz+jmIa4J6x4WTsmmU3E/AopGsSGugE+hkHBcu52o76Yd2SCpPNUqenvdySSqjowEt1+Ddz55/9Qj8Y8ZhTryqsb7tYwzLFB+F3lsWCotXBOQvEgy3e/bEQtOyV6YrP3KG6YNSb3Q==
   */
  downloadCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingue4kfzdxbyn0pjqd
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      downloadCode: 'downloadCode',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadCode: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotMessageFileDownloadResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  downloadUrl?: string;
  static names(): { [key: string]: string } {
    return {
      downloadUrl: 'downloadUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotMessageFileDownloadResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RobotMessageFileDownloadResponseBody;
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
      body: RobotMessageFileDownloadResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotRecallDingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotRecallDingRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  openDingId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      openDingId: 'openDingId',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openDingId: 'string',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotRecallDingResponseBody extends $tea.Model {
  openDingId?: string;
  static names(): { [key: string]: string } {
    return {
      openDingId: 'openDingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openDingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotRecallDingResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RobotRecallDingResponseBody;
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
      body: RobotRecallDingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotSendDingHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotSendDingRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  receiverUserIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1:APP，2:短信，3:电话
   */
  remindType?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      receiverUserIdList: 'receiverUserIdList',
      remindType: 'remindType',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      remindType: 'number',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotSendDingResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  failedList?: { [key: string]: any };
  /**
   * @remarks
   * This parameter is required.
   */
  openDingId?: string;
  static names(): { [key: string]: string } {
    return {
      failedList: 'failedList',
      openDingId: 'openDingId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedList: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
      openDingId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RobotSendDingResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RobotSendDingResponseBody;
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
      body: RobotSendDingResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotDingMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotDingMessageRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  contentParams?: { [key: string]: string };
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * template_ding_diot_monitor
   */
  dingTemplateId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cidfCSpXXXXXXXXXXXchatbotId
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  receiverUserIdList?: string[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * qF9j5G8hmFLiqJ11629XXXXXXXX
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      contentParams: 'contentParams',
      dingTemplateId: 'dingTemplateId',
      openConversationId: 'openConversationId',
      receiverUserIdList: 'receiverUserIdList',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contentParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      dingTemplateId: 'string',
      openConversationId: 'string',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotDingMessageResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  dingSendResultId?: string;
  static names(): { [key: string]: string } {
    return {
      dingSendResultId: 'dingSendResultId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingSendResultId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendRobotDingMessageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendRobotDingMessageResponseBody;
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
      body: SendRobotDingMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRobotPluginHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRobotPluginRequest extends $tea.Model {
  pluginInfoList?: SetRobotPluginRequestPluginInfoList[];
  /**
   * @example
   * dingncjdnfpkN7dsh
   */
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      pluginInfoList: 'pluginInfoList',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      pluginInfoList: { 'type': 'array', 'itemType': SetRobotPluginRequestPluginInfoList },
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRobotPluginResponseBody extends $tea.Model {
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

export class SetRobotPluginResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SetRobotPluginResponseBody;
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
      body: SetRobotPluginResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstalledRobotHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstalledRobotRequest extends $tea.Model {
  /**
   * @example
   * 钉钉的助手机器人
   */
  brief?: string;
  /**
   * @example
   * 钉钉的助手机器人的详细描述
   */
  description?: string;
  /**
   * @example
   * @IAfnkdsanfnkljn
   */
  icon?: string;
  /**
   * @example
   * 钉钉助手
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * dingXXXXXXXXXX
   */
  robotCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  updateType?: number;
  static names(): { [key: string]: string } {
    return {
      brief: 'brief',
      description: 'description',
      icon: 'icon',
      name: 'name',
      robotCode: 'robotCode',
      updateType: 'updateType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      brief: 'string',
      description: 'string',
      icon: 'string',
      name: 'string',
      robotCode: 'string',
      updateType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInstalledRobotResponseBody extends $tea.Model {
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

export class UpdateInstalledRobotResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateInstalledRobotResponseBody;
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
      body: UpdateInstalledRobotResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOTOQueryResponseBodyMessageReadInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 曲大岳
   */
  name?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * READ
   */
  readStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1433138400000
   */
  readTimestamp?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 201382020
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      readStatus: 'readStatus',
      readTimestamp: 'readTimestamp',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      readStatus: 'string',
      readTimestamp: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBotListInGroupResponseBodyChatbotInstanceVOList extends $tea.Model {
  downloadIconURL?: string;
  name?: string;
  openRobotType?: number;
  robotCode?: string;
  static names(): { [key: string]: string } {
    return {
      downloadIconURL: 'downloadIconURL',
      name: 'name',
      openRobotType: 'openRobotType',
      robotCode: 'robotCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      downloadIconURL: 'string',
      name: 'string',
      openRobotType: 'number',
      robotCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryRobotPluginResponseBodyPluginInfoList extends $tea.Model {
  /**
   * @example
   * @lALPDtXaDkO3j7hgYA
   */
  icon?: string;
  /**
   * @example
   * https://www.dingtalk.com
   */
  mobileUrl?: string;
  /**
   * @example
   * 快捷入口名称
   */
  name?: string;
  /**
   * @example
   * https://www.dingtalk.com
   */
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      mobileUrl: 'mobileUrl',
      name: 'name',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      mobileUrl: 'string',
      name: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SetRobotPluginRequestPluginInfoList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * @lALPDtXaDkO3j7hgYA
   */
  icon?: string;
  /**
   * @example
   * https://www.dingtalk.com
   */
  mobileUrl?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 快捷入口名字
   */
  name?: string;
  /**
   * @example
   * https://www.dingtalk.com
   */
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      icon: 'icon',
      mobileUrl: 'mobileUrl',
      name: 'name',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      icon: 'string',
      mobileUrl: 'string',
      name: 'string',
      pcUrl: 'string',
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
   * 批量查询人与机器人会话机器人消息是否已读
   * 
   * @param request - BatchOTOQueryRequest
   * @param headers - BatchOTOQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchOTOQueryResponse
   */
  async batchOTOQueryWithOptions(request: BatchOTOQueryRequest, headers: BatchOTOQueryHeaders, runtime: $Util.RuntimeOptions): Promise<BatchOTOQueryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processQueryKey)) {
      query["processQueryKey"] = request.processQueryKey;
    }

    if (!Util.isUnset(request.robotCode)) {
      query["robotCode"] = request.robotCode;
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
      action: "BatchOTOQuery",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/oToMessages/readStatus`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchOTOQueryResponse>(await this.execute(params, req, runtime), new BatchOTOQueryResponse({}));
  }

  /**
   * 批量查询人与机器人会话机器人消息是否已读
   * 
   * @param request - BatchOTOQueryRequest
   * @returns BatchOTOQueryResponse
   */
  async batchOTOQuery(request: BatchOTOQueryRequest): Promise<BatchOTOQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchOTOQueryHeaders({ });
    return await this.batchOTOQueryWithOptions(request, headers, runtime);
  }

  /**
   * 批量撤回群聊机器人消息
   * 
   * @param request - BatchRecallGroupRequest
   * @param headers - BatchRecallGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchRecallGroupResponse
   */
  async batchRecallGroupWithOptions(request: BatchRecallGroupRequest, headers: BatchRecallGroupHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRecallGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatbotId)) {
      body["chatbotId"] = request.chatbotId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.processQueryKeys)) {
      body["processQueryKeys"] = request.processQueryKeys;
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
      action: "BatchRecallGroup",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/groupMessages/batchRecall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchRecallGroupResponse>(await this.execute(params, req, runtime), new BatchRecallGroupResponse({}));
  }

  /**
   * 批量撤回群聊机器人消息
   * 
   * @param request - BatchRecallGroupRequest
   * @returns BatchRecallGroupResponse
   */
  async batchRecallGroup(request: BatchRecallGroupRequest): Promise<BatchRecallGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRecallGroupHeaders({ });
    return await this.batchRecallGroupWithOptions(request, headers, runtime);
  }

  /**
   * 批量撤回人与机器人会话中机器人消息
   * 
   * @param request - BatchRecallOTORequest
   * @param headers - BatchRecallOTOHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchRecallOTOResponse
   */
  async batchRecallOTOWithOptions(request: BatchRecallOTORequest, headers: BatchRecallOTOHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRecallOTOResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.processQueryKeys)) {
      body["processQueryKeys"] = request.processQueryKeys;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "BatchRecallOTO",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/otoMessages/batchRecall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchRecallOTOResponse>(await this.execute(params, req, runtime), new BatchRecallOTOResponse({}));
  }

  /**
   * 批量撤回人与机器人会话中机器人消息
   * 
   * @param request - BatchRecallOTORequest
   * @returns BatchRecallOTOResponse
   */
  async batchRecallOTO(request: BatchRecallOTORequest): Promise<BatchRecallOTOResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRecallOTOHeaders({ });
    return await this.batchRecallOTOWithOptions(request, headers, runtime);
  }

  /**
   * 批量撤回人与人会话中机器人消息
   * 
   * @param request - BatchRecallPrivateChatRequest
   * @param headers - BatchRecallPrivateChatHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchRecallPrivateChatResponse
   */
  async batchRecallPrivateChatWithOptions(request: BatchRecallPrivateChatRequest, headers: BatchRecallPrivateChatHeaders, runtime: $Util.RuntimeOptions): Promise<BatchRecallPrivateChatResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.processQueryKeys)) {
      body["processQueryKeys"] = request.processQueryKeys;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "BatchRecallPrivateChat",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/privateChatMessages/batchRecall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchRecallPrivateChatResponse>(await this.execute(params, req, runtime), new BatchRecallPrivateChatResponse({}));
  }

  /**
   * 批量撤回人与人会话中机器人消息
   * 
   * @param request - BatchRecallPrivateChatRequest
   * @returns BatchRecallPrivateChatResponse
   */
  async batchRecallPrivateChat(request: BatchRecallPrivateChatRequest): Promise<BatchRecallPrivateChatResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRecallPrivateChatHeaders({ });
    return await this.batchRecallPrivateChatWithOptions(request, headers, runtime);
  }

  /**
   * 批量发送人与机器人会话中机器人消息
   * 
   * @param request - BatchSendOTORequest
   * @param headers - BatchSendOTOHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchSendOTOResponse
   */
  async batchSendOTOWithOptions(request: BatchSendOTORequest, headers: BatchSendOTOHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSendOTOResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.msgKey)) {
      body["msgKey"] = request.msgKey;
    }

    if (!Util.isUnset(request.msgParam)) {
      body["msgParam"] = request.msgParam;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "BatchSendOTO",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/oToMessages/batchSend`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchSendOTOResponse>(await this.execute(params, req, runtime), new BatchSendOTOResponse({}));
  }

  /**
   * 批量发送人与机器人会话中机器人消息
   * 
   * @param request - BatchSendOTORequest
   * @returns BatchSendOTOResponse
   */
  async batchSendOTO(request: BatchSendOTORequest): Promise<BatchSendOTOResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendOTOHeaders({ });
    return await this.batchSendOTOWithOptions(request, headers, runtime);
  }

  /**
   * 清空单聊机器人快捷入口
   * 
   * @param request - ClearRobotPluginRequest
   * @param headers - ClearRobotPluginHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ClearRobotPluginResponse
   */
  async clearRobotPluginWithOptions(request: ClearRobotPluginRequest, headers: ClearRobotPluginHeaders, runtime: $Util.RuntimeOptions): Promise<ClearRobotPluginResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "ClearRobotPlugin",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/plugins/clear`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ClearRobotPluginResponse>(await this.execute(params, req, runtime), new ClearRobotPluginResponse({}));
  }

  /**
   * 清空单聊机器人快捷入口
   * 
   * @param request - ClearRobotPluginRequest
   * @returns ClearRobotPluginResponse
   */
  async clearRobotPlugin(request: ClearRobotPluginRequest): Promise<ClearRobotPluginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ClearRobotPluginHeaders({ });
    return await this.clearRobotPluginWithOptions(request, headers, runtime);
  }

  /**
   * 执行机器人的AI技能
   * 
   * @param request - ExecuteRobotAiSkillRequest
   * @param headers - ExecuteRobotAiSkillHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ExecuteRobotAiSkillResponse
   */
  async executeRobotAiSkillWithOptions(request: ExecuteRobotAiSkillRequest, headers: ExecuteRobotAiSkillHeaders, runtime: $Util.RuntimeOptions): Promise<ExecuteRobotAiSkillResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.context)) {
      body["context"] = request.context;
    }

    if (!Util.isUnset(request.input)) {
      body["input"] = request.input;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "ExecuteRobotAiSkill",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/aiSkill/execute`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ExecuteRobotAiSkillResponse>(await this.execute(params, req, runtime), new ExecuteRobotAiSkillResponse({}));
  }

  /**
   * 执行机器人的AI技能
   * 
   * @param request - ExecuteRobotAiSkillRequest
   * @returns ExecuteRobotAiSkillResponse
   */
  async executeRobotAiSkill(request: ExecuteRobotAiSkillRequest): Promise<ExecuteRobotAiSkillResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ExecuteRobotAiSkillHeaders({ });
    return await this.executeRobotAiSkillWithOptions(request, headers, runtime);
  }

  /**
   * 查询群内的机器人列表
   * 
   * @param request - GetBotListInGroupRequest
   * @param headers - GetBotListInGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetBotListInGroupResponse
   */
  async getBotListInGroupWithOptions(request: GetBotListInGroupRequest, headers: GetBotListInGroupHeaders, runtime: $Util.RuntimeOptions): Promise<GetBotListInGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "GetBotListInGroup",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/groups/robots/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBotListInGroupResponse>(await this.execute(params, req, runtime), new GetBotListInGroupResponse({}));
  }

  /**
   * 查询群内的机器人列表
   * 
   * @param request - GetBotListInGroupRequest
   * @returns GetBotListInGroupResponse
   */
  async getBotListInGroup(request: GetBotListInGroupRequest): Promise<GetBotListInGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBotListInGroupHeaders({ });
    return await this.getBotListInGroupWithOptions(request, headers, runtime);
  }

  /**
   * 管理机器人启用，停用状态
   * 
   * @param request - ManageSingleChatRobotStatusRequest
   * @param headers - ManageSingleChatRobotStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns ManageSingleChatRobotStatusResponse
   */
  async manageSingleChatRobotStatusWithOptions(request: ManageSingleChatRobotStatusRequest, headers: ManageSingleChatRobotStatusHeaders, runtime: $Util.RuntimeOptions): Promise<ManageSingleChatRobotStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "ManageSingleChatRobotStatus",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/statuses/manage`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ManageSingleChatRobotStatusResponse>(await this.execute(params, req, runtime), new ManageSingleChatRobotStatusResponse({}));
  }

  /**
   * 管理机器人启用，停用状态
   * 
   * @param request - ManageSingleChatRobotStatusRequest
   * @returns ManageSingleChatRobotStatusResponse
   */
  async manageSingleChatRobotStatus(request: ManageSingleChatRobotStatusRequest): Promise<ManageSingleChatRobotStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ManageSingleChatRobotStatusHeaders({ });
    return await this.manageSingleChatRobotStatusWithOptions(request, headers, runtime);
  }

  /**
   * 查询企业机器人群聊消息用户已读状态
   * 
   * @param request - OrgGroupQueryRequest
   * @param headers - OrgGroupQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OrgGroupQueryResponse
   */
  async orgGroupQueryWithOptions(request: OrgGroupQueryRequest, headers: OrgGroupQueryHeaders, runtime: $Util.RuntimeOptions): Promise<OrgGroupQueryResponse> {
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

    if (!Util.isUnset(request.processQueryKey)) {
      body["processQueryKey"] = request.processQueryKey;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.token)) {
      body["token"] = request.token;
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
      action: "OrgGroupQuery",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/groupMessages/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OrgGroupQueryResponse>(await this.execute(params, req, runtime), new OrgGroupQueryResponse({}));
  }

  /**
   * 查询企业机器人群聊消息用户已读状态
   * 
   * @param request - OrgGroupQueryRequest
   * @returns OrgGroupQueryResponse
   */
  async orgGroupQuery(request: OrgGroupQueryRequest): Promise<OrgGroupQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrgGroupQueryHeaders({ });
    return await this.orgGroupQueryWithOptions(request, headers, runtime);
  }

  /**
   * 企业机器人撤回内部群消息
   * 
   * @param request - OrgGroupRecallRequest
   * @param headers - OrgGroupRecallHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OrgGroupRecallResponse
   */
  async orgGroupRecallWithOptions(request: OrgGroupRecallRequest, headers: OrgGroupRecallHeaders, runtime: $Util.RuntimeOptions): Promise<OrgGroupRecallResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.processQueryKeys)) {
      body["processQueryKeys"] = request.processQueryKeys;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "OrgGroupRecall",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/groupMessages/recall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OrgGroupRecallResponse>(await this.execute(params, req, runtime), new OrgGroupRecallResponse({}));
  }

  /**
   * 企业机器人撤回内部群消息
   * 
   * @param request - OrgGroupRecallRequest
   * @returns OrgGroupRecallResponse
   */
  async orgGroupRecall(request: OrgGroupRecallRequest): Promise<OrgGroupRecallResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrgGroupRecallHeaders({ });
    return await this.orgGroupRecallWithOptions(request, headers, runtime);
  }

  /**
   * 机器人发送群聊消息
   * 
   * @param request - OrgGroupSendRequest
   * @param headers - OrgGroupSendHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns OrgGroupSendResponse
   */
  async orgGroupSendWithOptions(request: OrgGroupSendRequest, headers: OrgGroupSendHeaders, runtime: $Util.RuntimeOptions): Promise<OrgGroupSendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.msgKey)) {
      body["msgKey"] = request.msgKey;
    }

    if (!Util.isUnset(request.msgParam)) {
      body["msgParam"] = request.msgParam;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.token)) {
      body["token"] = request.token;
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
      action: "OrgGroupSend",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/groupMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<OrgGroupSendResponse>(await this.execute(params, req, runtime), new OrgGroupSendResponse({}));
  }

  /**
   * 机器人发送群聊消息
   * 
   * @param request - OrgGroupSendRequest
   * @returns OrgGroupSendResponse
   */
  async orgGroupSend(request: OrgGroupSendRequest): Promise<OrgGroupSendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrgGroupSendHeaders({ });
    return await this.orgGroupSendWithOptions(request, headers, runtime);
  }

  /**
   * 查询人与人会话中机器人已读消息
   * 
   * @param request - PrivateChatQueryRequest
   * @param headers - PrivateChatQueryHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PrivateChatQueryResponse
   */
  async privateChatQueryWithOptions(request: PrivateChatQueryRequest, headers: PrivateChatQueryHeaders, runtime: $Util.RuntimeOptions): Promise<PrivateChatQueryResponse> {
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

    if (!Util.isUnset(request.processQueryKey)) {
      body["processQueryKey"] = request.processQueryKey;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "PrivateChatQuery",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/privateChatMessages/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PrivateChatQueryResponse>(await this.execute(params, req, runtime), new PrivateChatQueryResponse({}));
  }

  /**
   * 查询人与人会话中机器人已读消息
   * 
   * @param request - PrivateChatQueryRequest
   * @returns PrivateChatQueryResponse
   */
  async privateChatQuery(request: PrivateChatQueryRequest): Promise<PrivateChatQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PrivateChatQueryHeaders({ });
    return await this.privateChatQueryWithOptions(request, headers, runtime);
  }

  /**
   * 人与人会话中机器人发送普通消息
   * 
   * @param request - PrivateChatSendRequest
   * @param headers - PrivateChatSendHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PrivateChatSendResponse
   */
  async privateChatSendWithOptions(request: PrivateChatSendRequest, headers: PrivateChatSendHeaders, runtime: $Util.RuntimeOptions): Promise<PrivateChatSendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.msgKey)) {
      body["msgKey"] = request.msgKey;
    }

    if (!Util.isUnset(request.msgParam)) {
      body["msgParam"] = request.msgParam;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "PrivateChatSend",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/privateChatMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PrivateChatSendResponse>(await this.execute(params, req, runtime), new PrivateChatSendResponse({}));
  }

  /**
   * 人与人会话中机器人发送普通消息
   * 
   * @param request - PrivateChatSendRequest
   * @returns PrivateChatSendResponse
   */
  async privateChatSend(request: PrivateChatSendRequest): Promise<PrivateChatSendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PrivateChatSendHeaders({ });
    return await this.privateChatSendWithOptions(request, headers, runtime);
  }

  /**
   * 获取机器人所在群信息
   * 
   * @param request - QueryBotInstanceInGroupInfoRequest
   * @param headers - QueryBotInstanceInGroupInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBotInstanceInGroupInfoResponse
   */
  async queryBotInstanceInGroupInfoWithOptions(request: QueryBotInstanceInGroupInfoRequest, headers: QueryBotInstanceInGroupInfoHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBotInstanceInGroupInfoResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pageNumber)) {
      body["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      body["pageSize"] = request.pageSize;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "QueryBotInstanceInGroupInfo",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/groups/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBotInstanceInGroupInfoResponse>(await this.execute(params, req, runtime), new QueryBotInstanceInGroupInfoResponse({}));
  }

  /**
   * 获取机器人所在群信息
   * 
   * @param request - QueryBotInstanceInGroupInfoRequest
   * @returns QueryBotInstanceInGroupInfoResponse
   */
  async queryBotInstanceInGroupInfo(request: QueryBotInstanceInGroupInfoRequest): Promise<QueryBotInstanceInGroupInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBotInstanceInGroupInfoHeaders({ });
    return await this.queryBotInstanceInGroupInfoWithOptions(request, headers, runtime);
  }

  /**
   * 查询单聊机器人快捷入口
   * 
   * @param request - QueryRobotPluginRequest
   * @param headers - QueryRobotPluginHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryRobotPluginResponse
   */
  async queryRobotPluginWithOptions(request: QueryRobotPluginRequest, headers: QueryRobotPluginHeaders, runtime: $Util.RuntimeOptions): Promise<QueryRobotPluginResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "QueryRobotPlugin",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/plugins/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryRobotPluginResponse>(await this.execute(params, req, runtime), new QueryRobotPluginResponse({}));
  }

  /**
   * 查询单聊机器人快捷入口
   * 
   * @param request - QueryRobotPluginRequest
   * @returns QueryRobotPluginResponse
   */
  async queryRobotPlugin(request: QueryRobotPluginRequest): Promise<QueryRobotPluginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryRobotPluginHeaders({ });
    return await this.queryRobotPluginWithOptions(request, headers, runtime);
  }

  /**
   * 获取机器人消息中文件下载链接
   * 
   * @param request - RobotMessageFileDownloadRequest
   * @param headers - RobotMessageFileDownloadHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RobotMessageFileDownloadResponse
   */
  async robotMessageFileDownloadWithOptions(request: RobotMessageFileDownloadRequest, headers: RobotMessageFileDownloadHeaders, runtime: $Util.RuntimeOptions): Promise<RobotMessageFileDownloadResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.downloadCode)) {
      body["downloadCode"] = request.downloadCode;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "RobotMessageFileDownload",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/messageFiles/download`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RobotMessageFileDownloadResponse>(await this.execute(params, req, runtime), new RobotMessageFileDownloadResponse({}));
  }

  /**
   * 获取机器人消息中文件下载链接
   * 
   * @param request - RobotMessageFileDownloadRequest
   * @returns RobotMessageFileDownloadResponse
   */
  async robotMessageFileDownload(request: RobotMessageFileDownloadRequest): Promise<RobotMessageFileDownloadResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RobotMessageFileDownloadHeaders({ });
    return await this.robotMessageFileDownloadWithOptions(request, headers, runtime);
  }

  /**
   * 撤回已经发送的DING消息
   * 
   * @param request - RobotRecallDingRequest
   * @param headers - RobotRecallDingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RobotRecallDingResponse
   */
  async robotRecallDingWithOptions(request: RobotRecallDingRequest, headers: RobotRecallDingHeaders, runtime: $Util.RuntimeOptions): Promise<RobotRecallDingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openDingId)) {
      body["openDingId"] = request.openDingId;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "RobotRecallDing",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/ding/recall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RobotRecallDingResponse>(await this.execute(params, req, runtime), new RobotRecallDingResponse({}));
  }

  /**
   * 撤回已经发送的DING消息
   * 
   * @param request - RobotRecallDingRequest
   * @returns RobotRecallDingResponse
   */
  async robotRecallDing(request: RobotRecallDingRequest): Promise<RobotRecallDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RobotRecallDingHeaders({ });
    return await this.robotRecallDingWithOptions(request, headers, runtime);
  }

  /**
   * 发送DING消息
   * 
   * @param request - RobotSendDingRequest
   * @param headers - RobotSendDingHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RobotSendDingResponse
   */
  async robotSendDingWithOptions(request: RobotSendDingRequest, headers: RobotSendDingHeaders, runtime: $Util.RuntimeOptions): Promise<RobotSendDingResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.remindType)) {
      body["remindType"] = request.remindType;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "RobotSendDing",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/ding/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RobotSendDingResponse>(await this.execute(params, req, runtime), new RobotSendDingResponse({}));
  }

  /**
   * 发送DING消息
   * 
   * @param request - RobotSendDingRequest
   * @returns RobotSendDingResponse
   */
  async robotSendDing(request: RobotSendDingRequest): Promise<RobotSendDingResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RobotSendDingHeaders({ });
    return await this.robotSendDingWithOptions(request, headers, runtime);
  }

  /**
   * 机器人发送DING消息
   * 
   * @param request - SendRobotDingMessageRequest
   * @param headers - SendRobotDingMessageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendRobotDingMessageResponse
   */
  async sendRobotDingMessageWithOptions(request: SendRobotDingMessageRequest, headers: SendRobotDingMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendRobotDingMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.contentParams)) {
      body["contentParams"] = request.contentParams;
    }

    if (!Util.isUnset(request.dingTemplateId)) {
      body["dingTemplateId"] = request.dingTemplateId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "SendRobotDingMessage",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/dingMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SendRobotDingMessageResponse>(await this.execute(params, req, runtime), new SendRobotDingMessageResponse({}));
  }

  /**
   * 机器人发送DING消息
   * 
   * @param request - SendRobotDingMessageRequest
   * @returns SendRobotDingMessageResponse
   */
  async sendRobotDingMessage(request: SendRobotDingMessageRequest): Promise<SendRobotDingMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendRobotDingMessageHeaders({ });
    return await this.sendRobotDingMessageWithOptions(request, headers, runtime);
  }

  /**
   * 设置单聊机器人快捷入口
   * 
   * @param request - SetRobotPluginRequest
   * @param headers - SetRobotPluginHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SetRobotPluginResponse
   */
  async setRobotPluginWithOptions(request: SetRobotPluginRequest, headers: SetRobotPluginHeaders, runtime: $Util.RuntimeOptions): Promise<SetRobotPluginResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.pluginInfoList)) {
      body["pluginInfoList"] = request.pluginInfoList;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "SetRobotPlugin",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/plugins/set`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SetRobotPluginResponse>(await this.execute(params, req, runtime), new SetRobotPluginResponse({}));
  }

  /**
   * 设置单聊机器人快捷入口
   * 
   * @param request - SetRobotPluginRequest
   * @returns SetRobotPluginResponse
   */
  async setRobotPlugin(request: SetRobotPluginRequest): Promise<SetRobotPluginResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SetRobotPluginHeaders({ });
    return await this.setRobotPluginWithOptions(request, headers, runtime);
  }

  /**
   * 更新安装到组织的机器人信息
   * 
   * @param request - UpdateInstalledRobotRequest
   * @param headers - UpdateInstalledRobotHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInstalledRobotResponse
   */
  async updateInstalledRobotWithOptions(request: UpdateInstalledRobotRequest, headers: UpdateInstalledRobotHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInstalledRobotResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.brief)) {
      body["brief"] = request.brief;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
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
      action: "UpdateInstalledRobot",
      version: "robot_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/robot/managements/infos`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateInstalledRobotResponse>(await this.execute(params, req, runtime), new UpdateInstalledRobotResponse({}));
  }

  /**
   * 更新安装到组织的机器人信息
   * 
   * @param request - UpdateInstalledRobotRequest
   * @returns UpdateInstalledRobotResponse
   */
  async updateInstalledRobot(request: UpdateInstalledRobotRequest): Promise<UpdateInstalledRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstalledRobotHeaders({ });
    return await this.updateInstalledRobotWithOptions(request, headers, runtime);
  }

}
