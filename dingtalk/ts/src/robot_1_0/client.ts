// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  processQueryKey?: string;
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
  headers: { [key: string]: string };
  body: BatchOTOQueryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  chatbotId?: string;
  openConversationId?: string;
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

export class BatchRecallGroupResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: BatchRecallGroupResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  processQueryKeys?: string[];
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
  headers: { [key: string]: string };
  body: BatchRecallOTOResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchRecallOTOResponseBody,
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
  msgKey?: string;
  msgParam?: string;
  robotCode?: string;
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
  headers: { [key: string]: string };
  body: BatchSendOTOResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: BatchSendOTOResponseBody,
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
  maxResults?: number;
  nextToken?: string;
  openConversationId?: string;
  processQueryKey?: string;
  robotCode?: string;
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
  hasMore?: boolean;
  nextToken?: string;
  readUserIds?: string[];
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
  headers: { [key: string]: string };
  body: OrgGroupQueryResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  openConversationId?: string;
  processQueryKeys?: string[];
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

export class OrgGroupRecallResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: OrgGroupRecallResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  coolAppCode?: string;
  msgKey?: string;
  msgParam?: string;
  openConversationId?: string;
  robotCode?: string;
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
  headers: { [key: string]: string };
  body: OrgGroupSendResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: OrgGroupSendResponseBody,
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
  contentParams?: { [key: string]: string };
  dingTemplateId?: string;
  openConversationId?: string;
  receiverUserIdList?: string[];
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
  headers: { [key: string]: string };
  body: SendRobotDingMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendRobotDingMessageResponseBody,
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
  brief?: string;
  description?: string;
  icon?: string;
  name?: string;
  robotCode?: string;
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
  headers: { [key: string]: string };
  body: UpdateInstalledRobotResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateInstalledRobotResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOTOQueryResponseBodyMessageReadInfoList extends $tea.Model {
  name?: string;
  readStatus?: string;
  readTimestamp?: number;
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


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async batchOTOQuery(request: BatchOTOQueryRequest): Promise<BatchOTOQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchOTOQueryHeaders({ });
    return await this.batchOTOQueryWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchOTOQueryResponse>(await this.doROARequest("BatchOTOQuery", "robot_1.0", "HTTP", "GET", "AK", `/v1.0/robot/oToMessages/readStatus`, "json", req, runtime), new BatchOTOQueryResponse({}));
  }

  async batchRecallGroup(request: BatchRecallGroupRequest): Promise<BatchRecallGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRecallGroupHeaders({ });
    return await this.batchRecallGroupWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchRecallGroupResponse>(await this.doROARequest("BatchRecallGroup", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/groupMessages/batchRecall`, "json", req, runtime), new BatchRecallGroupResponse({}));
  }

  async batchRecallOTO(request: BatchRecallOTORequest): Promise<BatchRecallOTOResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchRecallOTOHeaders({ });
    return await this.batchRecallOTOWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchRecallOTOResponse>(await this.doROARequest("BatchRecallOTO", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/otoMessages/batchRecall`, "json", req, runtime), new BatchRecallOTOResponse({}));
  }

  async batchSendOTO(request: BatchSendOTORequest): Promise<BatchSendOTOResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendOTOHeaders({ });
    return await this.batchSendOTOWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<BatchSendOTOResponse>(await this.doROARequest("BatchSendOTO", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/oToMessages/batchSend`, "json", req, runtime), new BatchSendOTOResponse({}));
  }

  async orgGroupQuery(request: OrgGroupQueryRequest): Promise<OrgGroupQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrgGroupQueryHeaders({ });
    return await this.orgGroupQueryWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<OrgGroupQueryResponse>(await this.doROARequest("OrgGroupQuery", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/groupMessages/query`, "json", req, runtime), new OrgGroupQueryResponse({}));
  }

  async orgGroupRecall(request: OrgGroupRecallRequest): Promise<OrgGroupRecallResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrgGroupRecallHeaders({ });
    return await this.orgGroupRecallWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<OrgGroupRecallResponse>(await this.doROARequest("OrgGroupRecall", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/groupMessages/recall`, "json", req, runtime), new OrgGroupRecallResponse({}));
  }

  async orgGroupSend(request: OrgGroupSendRequest): Promise<OrgGroupSendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new OrgGroupSendHeaders({ });
    return await this.orgGroupSendWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<OrgGroupSendResponse>(await this.doROARequest("OrgGroupSend", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/groupMessages/send`, "json", req, runtime), new OrgGroupSendResponse({}));
  }

  async sendRobotDingMessage(request: SendRobotDingMessageRequest): Promise<SendRobotDingMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendRobotDingMessageHeaders({ });
    return await this.sendRobotDingMessageWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<SendRobotDingMessageResponse>(await this.doROARequest("SendRobotDingMessage", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/dingMessages/send`, "json", req, runtime), new SendRobotDingMessageResponse({}));
  }

  async updateInstalledRobot(request: UpdateInstalledRobotRequest): Promise<UpdateInstalledRobotResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInstalledRobotHeaders({ });
    return await this.updateInstalledRobotWithOptions(request, headers, runtime);
  }

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
    return $tea.cast<UpdateInstalledRobotResponse>(await this.doROARequest("UpdateInstalledRobot", "robot_1.0", "HTTP", "PUT", "AK", `/v1.0/robot/managements/infos`, "json", req, runtime), new UpdateInstalledRobotResponse({}));
  }

}
