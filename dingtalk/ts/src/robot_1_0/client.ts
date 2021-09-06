// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  robotCode?: string;
  userIds?: string[];
  msgKey?: string;
  msgParam?: string;
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
      userIds: 'userIds',
      msgKey: 'msgKey',
      msgParam: 'msgParam',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
      userIds: { 'type': 'array', 'itemType': 'string' },
      msgKey: 'string',
      msgParam: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchSendOTOResponseBody extends $tea.Model {
  processQueryKey?: string;
  invalidStaffIdList?: string[];
  flowControlledStaffIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      processQueryKey: 'processQueryKey',
      invalidStaffIdList: 'invalidStaffIdList',
      flowControlledStaffIdList: 'flowControlledStaffIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      processQueryKey: 'string',
      invalidStaffIdList: { 'type': 'array', 'itemType': 'string' },
      flowControlledStaffIdList: { 'type': 'array', 'itemType': 'string' },
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
  robotCode?: string;
  processQueryKey?: string;
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
      processQueryKey: 'processQueryKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
      processQueryKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchOTOQueryResponseBody extends $tea.Model {
  sendStatus?: string;
  messageReadInfoList?: BatchOTOQueryResponseBodyMessageReadInfoList[];
  static names(): { [key: string]: string } {
    return {
      sendStatus: 'sendStatus',
      messageReadInfoList: 'messageReadInfoList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      sendStatus: 'string',
      messageReadInfoList: { 'type': 'array', 'itemType': BatchOTOQueryResponseBodyMessageReadInfoList },
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
  robotCode?: string;
  openConversationId?: string;
  receiverUserIdList?: string[];
  dingTemplateId?: string;
  contentParams?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      robotCode: 'robotCode',
      openConversationId: 'openConversationId',
      receiverUserIdList: 'receiverUserIdList',
      dingTemplateId: 'dingTemplateId',
      contentParams: 'contentParams',
    };
  }

  static types(): { [key: string]: any } {
    return {
      robotCode: 'string',
      openConversationId: 'string',
      receiverUserIdList: { 'type': 'array', 'itemType': 'string' },
      dingTemplateId: 'string',
      contentParams: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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

export class BatchOTOQueryResponseBodyMessageReadInfoList extends $tea.Model {
  name?: string;
  userId?: string;
  readStatus?: string;
  readTimestamp?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      userId: 'userId',
      readStatus: 'readStatus',
      readTimestamp: 'readTimestamp',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      userId: 'string',
      readStatus: 'string',
      readTimestamp: 'number',
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


  async batchSendOTO(request: BatchSendOTORequest): Promise<BatchSendOTOResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchSendOTOHeaders({ });
    return await this.batchSendOTOWithOptions(request, headers, runtime);
  }

  async batchSendOTOWithOptions(request: BatchSendOTORequest, headers: BatchSendOTOHeaders, runtime: $Util.RuntimeOptions): Promise<BatchSendOTOResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<BatchSendOTOResponse>(await this.doROARequest("BatchSendOTO", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/oToMessages/batchSend`, "json", req, runtime), new BatchSendOTOResponse({}));
  }

  async batchOTOQuery(request: BatchOTOQueryRequest): Promise<BatchOTOQueryResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchOTOQueryHeaders({ });
    return await this.batchOTOQueryWithOptions(request, headers, runtime);
  }

  async batchOTOQueryWithOptions(request: BatchOTOQueryRequest, headers: BatchOTOQueryHeaders, runtime: $Util.RuntimeOptions): Promise<BatchOTOQueryResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.robotCode)) {
      query["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.processQueryKey)) {
      query["processQueryKey"] = request.processQueryKey;
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
    return $tea.cast<BatchOTOQueryResponse>(await this.doROARequest("BatchOTOQuery", "robot_1.0", "HTTP", "GET", "AK", `/v1.0/robot/oToMessages/readStatus`, "json", req, runtime), new BatchOTOQueryResponse({}));
  }

  async sendRobotDingMessage(request: SendRobotDingMessageRequest): Promise<SendRobotDingMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendRobotDingMessageHeaders({ });
    return await this.sendRobotDingMessageWithOptions(request, headers, runtime);
  }

  async sendRobotDingMessageWithOptions(request: SendRobotDingMessageRequest, headers: SendRobotDingMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendRobotDingMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.robotCode)) {
      body["robotCode"] = request.robotCode;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.receiverUserIdList)) {
      body["receiverUserIdList"] = request.receiverUserIdList;
    }

    if (!Util.isUnset(request.dingTemplateId)) {
      body["dingTemplateId"] = request.dingTemplateId;
    }

    if (!Util.isUnset(request.contentParams)) {
      body["contentParams"] = request.contentParams;
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
    return $tea.cast<SendRobotDingMessageResponse>(await this.doROARequest("SendRobotDingMessage", "robot_1.0", "HTTP", "POST", "AK", `/v1.0/robot/dingMessages/send`, "json", req, runtime), new SendRobotDingMessageResponse({}));
  }

}
