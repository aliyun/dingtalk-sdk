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

export class AddRobotInstanceToGroupHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRobotInstanceToGroupRequest extends $tea.Model {
  chatbotId?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatbotId: 'chatbotId',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatbotId: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddRobotInstanceToGroupResponseBody extends $tea.Model {
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

export class AddRobotInstanceToGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AddRobotInstanceToGroupResponseBody;
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
      body: AddRobotInstanceToGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AskRobotHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AskRobotRequest extends $tea.Model {
  dingUserId?: string;
  question?: string;
  robotAppKey?: string;
  sessionUuid?: string;
  static names(): { [key: string]: string } {
    return {
      dingUserId: 'dingUserId',
      question: 'question',
      robotAppKey: 'robotAppKey',
      sessionUuid: 'sessionUuid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingUserId: 'string',
      question: 'string',
      robotAppKey: 'string',
      sessionUuid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AskRobotResponseBody extends $tea.Model {
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

export class AskRobotResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: AskRobotResponseBody;
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
      body: AskRobotResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingMeBaseDataHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingMeBaseDataRequest extends $tea.Model {
  appKey?: string;
  byDay?: boolean;
  endDay?: string;
  startDay?: string;
  static names(): { [key: string]: string } {
    return {
      appKey: 'appKey',
      byDay: 'byDay',
      endDay: 'endDay',
      startDay: 'startDay',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appKey: 'string',
      byDay: 'boolean',
      endDay: 'string',
      startDay: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingMeBaseDataResponseBody extends $tea.Model {
  fromCache?: boolean;
  rawset?: { [key: string]: string }[];
  runtime?: number;
  tips?: { [key: string]: any };
  static names(): { [key: string]: string } {
    return {
      fromCache: 'fromCache',
      rawset: 'rawset',
      runtime: 'runtime',
      tips: 'tips',
    };
  }

  static types(): { [key: string]: any } {
    return {
      fromCache: 'boolean',
      rawset: { 'type': 'array', 'itemType': { 'type': 'map', 'keyType': 'string', 'valueType': 'string' } },
      runtime: 'number',
      tips: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetDingMeBaseDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetDingMeBaseDataResponseBody;
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
      body: GetDingMeBaseDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntelligentRobotInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntelligentRobotInfoRequest extends $tea.Model {
  robotAppKey?: string;
  static names(): { [key: string]: string } {
    return {
      robotAppKey: 'robotAppKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotAppKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetIntelligentRobotInfoResponseBody extends $tea.Model {
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

export class GetIntelligentRobotInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetIntelligentRobotInfoResponseBody;
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
      body: GetIntelligentRobotInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountRobotInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountRobotInfoRequest extends $tea.Model {
  type?: string;
  static names(): { [key: string]: string } {
    return {
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountRobotInfoResponseBody extends $tea.Model {
  appId?: number;
  brief?: string;
  description?: string;
  icon?: string;
  name?: string;
  previewMediaUrl?: string;
  static names(): { [key: string]: string } {
    return {
      appId: 'appId',
      brief: 'brief',
      description: 'description',
      icon: 'icon',
      name: 'name',
      previewMediaUrl: 'previewMediaUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appId: 'number',
      brief: 'string',
      description: 'string',
      icon: 'string',
      name: 'string',
      previewMediaUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetOfficialAccountRobotInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetOfficialAccountRobotInfoResponseBody;
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
      body: GetOfficialAccountRobotInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWebChannelUserTokenHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWebChannelUserTokenRequest extends $tea.Model {
  foreignId?: string;
  nick?: string;
  source?: number;
  static names(): { [key: string]: string } {
    return {
      foreignId: 'foreignId',
      nick: 'nick',
      source: 'source',
    };
  }

  static types(): { [key: string]: any } {
    return {
      foreignId: 'string',
      nick: 'string',
      source: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetWebChannelUserTokenResponseBody extends $tea.Model {
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

export class GetWebChannelUserTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetWebChannelUserTokenResponseBody;
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
      body: GetWebChannelUserTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushCustomerGroupMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushCustomerGroupMessageRequest extends $tea.Model {
  conversationId?: string;
  msgKey?: string;
  msgParam?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      msgKey: 'msgKey',
      msgParam: 'msgParam',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      msgKey: 'string',
      msgParam: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushCustomerGroupMessageResponseBody extends $tea.Model {
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

export class PushCustomerGroupMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PushCustomerGroupMessageResponseBody;
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
      body: PushCustomerGroupMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushIntelligentRobotGroupMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushIntelligentRobotGroupMessageRequest extends $tea.Model {
  chatbotId?: string;
  msgKey?: string;
  msgParam?: string;
  openConversationId?: string;
  static names(): { [key: string]: string } {
    return {
      chatbotId: 'chatbotId',
      msgKey: 'msgKey',
      msgParam: 'msgParam',
      openConversationId: 'openConversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatbotId: 'string',
      msgKey: 'string',
      msgParam: 'string',
      openConversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushIntelligentRobotGroupMessageResponseBody extends $tea.Model {
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

export class PushIntelligentRobotGroupMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PushIntelligentRobotGroupMessageResponseBody;
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
      body: PushIntelligentRobotGroupMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushIntelligentRobotMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushIntelligentRobotMessageRequest extends $tea.Model {
  chatbotId?: string;
  msgKey?: string;
  msgParam?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      chatbotId: 'chatbotId',
      msgKey: 'msgKey',
      msgParam: 'msgParam',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatbotId: 'string',
      msgKey: 'string',
      msgParam: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushIntelligentRobotMessageResponseBody extends $tea.Model {
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

export class PushIntelligentRobotMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PushIntelligentRobotMessageResponseBody;
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
      body: PushIntelligentRobotMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushOfficialAccountMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushOfficialAccountMessageRequest extends $tea.Model {
  msgKey?: string;
  msgParam?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      msgKey: 'msgKey',
      msgParam: 'msgParam',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgKey: 'string',
      msgParam: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushOfficialAccountMessageResponseBody extends $tea.Model {
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

export class PushOfficialAccountMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PushOfficialAccountMessageResponseBody;
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
      body: PushOfficialAccountMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushRobotMessageHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushRobotMessageRequest extends $tea.Model {
  chatbotId?: string;
  msgKey?: string;
  msgParam?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      chatbotId: 'chatbotId',
      msgKey: 'msgKey',
      msgParam: 'msgParam',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      chatbotId: 'string',
      msgKey: 'string',
      msgParam: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PushRobotMessageResponseBody extends $tea.Model {
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

export class PushRobotMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: PushRobotMessageResponseBody;
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
      body: PushRobotMessageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReplyRobotHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReplyRobotRequest extends $tea.Model {
  proxyMessageStr?: string;
  static names(): { [key: string]: string } {
    return {
      proxyMessageStr: 'proxyMessageStr',
    };
  }

  static types(): { [key: string]: any } {
    return {
      proxyMessageStr: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReplyRobotResponseBody extends $tea.Model {
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

export class ReplyRobotResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ReplyRobotResponseBody;
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
      body: ReplyRobotResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOfficialAccountRobotInfoHeaders extends $tea.Model {
  commonHeaders?: { [key: string]: string };
  xAcsDingtalkAccessToken?: string;
  static names(): { [key: string]: string } {
    return {
      commonHeaders: 'commonHeaders',
      xAcsDingtalkAccessToken: 'x-acs-dingtalk-access-token',
    };
  }

  static types(): { [key: string]: any } {
    return {
      commonHeaders: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      xAcsDingtalkAccessToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOfficialAccountRobotInfoRequest extends $tea.Model {
  avatar?: string;
  brief?: string;
  description?: string;
  name?: string;
  previewMediaUrl?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      brief: 'brief',
      description: 'description',
      name: 'name',
      previewMediaUrl: 'previewMediaUrl',
      type: 'type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      brief: 'string',
      description: 'string',
      name: 'string',
      previewMediaUrl: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateOfficialAccountRobotInfoResponseBody extends $tea.Model {
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

export class UpdateOfficialAccountRobotInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateOfficialAccountRobotInfoResponseBody;
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
      body: UpdateOfficialAccountRobotInfoResponseBody,
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


  async addRobotInstanceToGroupWithOptions(request: AddRobotInstanceToGroupRequest, headers: AddRobotInstanceToGroupHeaders, runtime: $Util.RuntimeOptions): Promise<AddRobotInstanceToGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatbotId)) {
      body["chatbotId"] = request.chatbotId;
    }

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
      action: "AddRobotInstanceToGroup",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/intelligentRobots/groups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddRobotInstanceToGroupResponse>(await this.execute(params, req, runtime), new AddRobotInstanceToGroupResponse({}));
  }

  async addRobotInstanceToGroup(request: AddRobotInstanceToGroupRequest): Promise<AddRobotInstanceToGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddRobotInstanceToGroupHeaders({ });
    return await this.addRobotInstanceToGroupWithOptions(request, headers, runtime);
  }

  async askRobotWithOptions(request: AskRobotRequest, headers: AskRobotHeaders, runtime: $Util.RuntimeOptions): Promise<AskRobotResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingUserId)) {
      body["dingUserId"] = request.dingUserId;
    }

    if (!Util.isUnset(request.question)) {
      body["question"] = request.question;
    }

    if (!Util.isUnset(request.robotAppKey)) {
      body["robotAppKey"] = request.robotAppKey;
    }

    if (!Util.isUnset(request.sessionUuid)) {
      body["sessionUuid"] = request.sessionUuid;
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
      action: "AskRobot",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/robots/ask`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<AskRobotResponse>(await this.execute(params, req, runtime), new AskRobotResponse({}));
  }

  async askRobot(request: AskRobotRequest): Promise<AskRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AskRobotHeaders({ });
    return await this.askRobotWithOptions(request, headers, runtime);
  }

  async getDingMeBaseDataWithOptions(request: GetDingMeBaseDataRequest, headers: GetDingMeBaseDataHeaders, runtime: $Util.RuntimeOptions): Promise<GetDingMeBaseDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appKey)) {
      query["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.byDay)) {
      query["byDay"] = request.byDay;
    }

    if (!Util.isUnset(request.endDay)) {
      query["endDay"] = request.endDay;
    }

    if (!Util.isUnset(request.startDay)) {
      query["startDay"] = request.startDay;
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
      action: "GetDingMeBaseData",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/robots/data`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetDingMeBaseDataResponse>(await this.execute(params, req, runtime), new GetDingMeBaseDataResponse({}));
  }

  async getDingMeBaseData(request: GetDingMeBaseDataRequest): Promise<GetDingMeBaseDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetDingMeBaseDataHeaders({ });
    return await this.getDingMeBaseDataWithOptions(request, headers, runtime);
  }

  async getIntelligentRobotInfoWithOptions(request: GetIntelligentRobotInfoRequest, headers: GetIntelligentRobotInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetIntelligentRobotInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.robotAppKey)) {
      query["robotAppKey"] = request.robotAppKey;
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
      action: "GetIntelligentRobotInfo",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/intelligentRobots/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetIntelligentRobotInfoResponse>(await this.execute(params, req, runtime), new GetIntelligentRobotInfoResponse({}));
  }

  async getIntelligentRobotInfo(request: GetIntelligentRobotInfoRequest): Promise<GetIntelligentRobotInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetIntelligentRobotInfoHeaders({ });
    return await this.getIntelligentRobotInfoWithOptions(request, headers, runtime);
  }

  async getOfficialAccountRobotInfoWithOptions(request: GetOfficialAccountRobotInfoRequest, headers: GetOfficialAccountRobotInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetOfficialAccountRobotInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
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
      action: "GetOfficialAccountRobotInfo",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/officialAccounts/robots`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetOfficialAccountRobotInfoResponse>(await this.execute(params, req, runtime), new GetOfficialAccountRobotInfoResponse({}));
  }

  async getOfficialAccountRobotInfo(request: GetOfficialAccountRobotInfoRequest): Promise<GetOfficialAccountRobotInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetOfficialAccountRobotInfoHeaders({ });
    return await this.getOfficialAccountRobotInfoWithOptions(request, headers, runtime);
  }

  async getWebChannelUserTokenWithOptions(request: GetWebChannelUserTokenRequest, headers: GetWebChannelUserTokenHeaders, runtime: $Util.RuntimeOptions): Promise<GetWebChannelUserTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.foreignId)) {
      body["foreignId"] = request.foreignId;
    }

    if (!Util.isUnset(request.nick)) {
      body["nick"] = request.nick;
    }

    if (!Util.isUnset(request.source)) {
      body["source"] = request.source;
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
      action: "GetWebChannelUserToken",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/webChannels/userTokens`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetWebChannelUserTokenResponse>(await this.execute(params, req, runtime), new GetWebChannelUserTokenResponse({}));
  }

  async getWebChannelUserToken(request: GetWebChannelUserTokenRequest): Promise<GetWebChannelUserTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetWebChannelUserTokenHeaders({ });
    return await this.getWebChannelUserTokenWithOptions(request, headers, runtime);
  }

  async pushCustomerGroupMessageWithOptions(request: PushCustomerGroupMessageRequest, headers: PushCustomerGroupMessageHeaders, runtime: $Util.RuntimeOptions): Promise<PushCustomerGroupMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.msgKey)) {
      body["msgKey"] = request.msgKey;
    }

    if (!Util.isUnset(request.msgParam)) {
      body["msgParam"] = request.msgParam;
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
      action: "PushCustomerGroupMessage",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/officialAccounts/robots/groupMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushCustomerGroupMessageResponse>(await this.execute(params, req, runtime), new PushCustomerGroupMessageResponse({}));
  }

  async pushCustomerGroupMessage(request: PushCustomerGroupMessageRequest): Promise<PushCustomerGroupMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushCustomerGroupMessageHeaders({ });
    return await this.pushCustomerGroupMessageWithOptions(request, headers, runtime);
  }

  async pushIntelligentRobotGroupMessageWithOptions(request: PushIntelligentRobotGroupMessageRequest, headers: PushIntelligentRobotGroupMessageHeaders, runtime: $Util.RuntimeOptions): Promise<PushIntelligentRobotGroupMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatbotId)) {
      body["chatbotId"] = request.chatbotId;
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
      action: "PushIntelligentRobotGroupMessage",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/intelligentRobots/groupMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushIntelligentRobotGroupMessageResponse>(await this.execute(params, req, runtime), new PushIntelligentRobotGroupMessageResponse({}));
  }

  async pushIntelligentRobotGroupMessage(request: PushIntelligentRobotGroupMessageRequest): Promise<PushIntelligentRobotGroupMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushIntelligentRobotGroupMessageHeaders({ });
    return await this.pushIntelligentRobotGroupMessageWithOptions(request, headers, runtime);
  }

  async pushIntelligentRobotMessageWithOptions(request: PushIntelligentRobotMessageRequest, headers: PushIntelligentRobotMessageHeaders, runtime: $Util.RuntimeOptions): Promise<PushIntelligentRobotMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatbotId)) {
      body["chatbotId"] = request.chatbotId;
    }

    if (!Util.isUnset(request.msgKey)) {
      body["msgKey"] = request.msgKey;
    }

    if (!Util.isUnset(request.msgParam)) {
      body["msgParam"] = request.msgParam;
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
      action: "PushIntelligentRobotMessage",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/intelligentRobots/oToMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushIntelligentRobotMessageResponse>(await this.execute(params, req, runtime), new PushIntelligentRobotMessageResponse({}));
  }

  async pushIntelligentRobotMessage(request: PushIntelligentRobotMessageRequest): Promise<PushIntelligentRobotMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushIntelligentRobotMessageHeaders({ });
    return await this.pushIntelligentRobotMessageWithOptions(request, headers, runtime);
  }

  async pushOfficialAccountMessageWithOptions(request: PushOfficialAccountMessageRequest, headers: PushOfficialAccountMessageHeaders, runtime: $Util.RuntimeOptions): Promise<PushOfficialAccountMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.msgKey)) {
      body["msgKey"] = request.msgKey;
    }

    if (!Util.isUnset(request.msgParam)) {
      body["msgParam"] = request.msgParam;
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
      action: "PushOfficialAccountMessage",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/officialAccounts/robots/oToMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushOfficialAccountMessageResponse>(await this.execute(params, req, runtime), new PushOfficialAccountMessageResponse({}));
  }

  async pushOfficialAccountMessage(request: PushOfficialAccountMessageRequest): Promise<PushOfficialAccountMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushOfficialAccountMessageHeaders({ });
    return await this.pushOfficialAccountMessageWithOptions(request, headers, runtime);
  }

  async pushRobotMessageWithOptions(request: PushRobotMessageRequest, headers: PushRobotMessageHeaders, runtime: $Util.RuntimeOptions): Promise<PushRobotMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.chatbotId)) {
      body["chatbotId"] = request.chatbotId;
    }

    if (!Util.isUnset(request.msgKey)) {
      body["msgKey"] = request.msgKey;
    }

    if (!Util.isUnset(request.msgParam)) {
      body["msgParam"] = request.msgParam;
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
      action: "PushRobotMessage",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/robots/oToMessages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PushRobotMessageResponse>(await this.execute(params, req, runtime), new PushRobotMessageResponse({}));
  }

  async pushRobotMessage(request: PushRobotMessageRequest): Promise<PushRobotMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PushRobotMessageHeaders({ });
    return await this.pushRobotMessageWithOptions(request, headers, runtime);
  }

  async replyRobotWithOptions(request: ReplyRobotRequest, headers: ReplyRobotHeaders, runtime: $Util.RuntimeOptions): Promise<ReplyRobotResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.proxyMessageStr)) {
      body["proxyMessageStr"] = request.proxyMessageStr;
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
      action: "ReplyRobot",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/robots/reply`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<ReplyRobotResponse>(await this.execute(params, req, runtime), new ReplyRobotResponse({}));
  }

  async replyRobot(request: ReplyRobotRequest): Promise<ReplyRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReplyRobotHeaders({ });
    return await this.replyRobotWithOptions(request, headers, runtime);
  }

  async updateOfficialAccountRobotInfoWithOptions(request: UpdateOfficialAccountRobotInfoRequest, headers: UpdateOfficialAccountRobotInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateOfficialAccountRobotInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.type)) {
      query["type"] = request.type;
    }

    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.avatar)) {
      body["avatar"] = request.avatar;
    }

    if (!Util.isUnset(request.brief)) {
      body["brief"] = request.brief;
    }

    if (!Util.isUnset(request.description)) {
      body["description"] = request.description;
    }

    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.previewMediaUrl)) {
      body["previewMediaUrl"] = request.previewMediaUrl;
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
      action: "UpdateOfficialAccountRobotInfo",
      version: "dingmi_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dingmi/officialAccounts/robots`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateOfficialAccountRobotInfoResponse>(await this.execute(params, req, runtime), new UpdateOfficialAccountRobotInfoResponse({}));
  }

  async updateOfficialAccountRobotInfo(request: UpdateOfficialAccountRobotInfoRequest): Promise<UpdateOfficialAccountRobotInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateOfficialAccountRobotInfoHeaders({ });
    return await this.updateOfficialAccountRobotInfoWithOptions(request, headers, runtime);
  }

}
