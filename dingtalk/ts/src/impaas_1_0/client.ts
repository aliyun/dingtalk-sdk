// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetConversationIdHeaders extends $tea.Model {
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

export class GetConversationIdRequest extends $tea.Model {
  userId?: string;
  appUid?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      appUid: 'appUid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      appUid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdResponseBody extends $tea.Model {
  conversationId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetConversationIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetConversationIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallMessageHeaders extends $tea.Model {
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

export class RecallMessageRequest extends $tea.Model {
  operatorUid?: string;
  messageId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      messageId: 'messageId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      messageId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RecallMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlHeaders extends $tea.Model {
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

export class GetMediaUrlRequest extends $tea.Model {
  mediaId?: string;
  urlExpireTime?: number;
  static names(): { [key: string]: string } {
    return {
      mediaId: 'mediaId',
      urlExpireTime: 'urlExpireTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mediaId: 'string',
      urlExpireTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlResponseBody extends $tea.Model {
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMediaUrlResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetMediaUrlResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetMediaUrlResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReadMessageHeaders extends $tea.Model {
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

export class ReadMessageRequest extends $tea.Model {
  operatorUid?: string;
  messageId?: string;
  static names(): { [key: string]: string } {
    return {
      operatorUid: 'operatorUid',
      messageId: 'messageId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      operatorUid: 'string',
      messageId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReadMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProfileHeaders extends $tea.Model {
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

export class AddProfileRequest extends $tea.Model {
  nick?: string;
  avatarMediaId?: string;
  appUid?: string;
  mobileNumber?: string;
  static names(): { [key: string]: string } {
    return {
      nick: 'nick',
      avatarMediaId: 'avatarMediaId',
      appUid: 'appUid',
      mobileNumber: 'mobileNumber',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nick: 'string',
      avatarMediaId: 'string',
      appUid: 'string',
      mobileNumber: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddProfileResponse extends $tea.Model {
  headers: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageHeaders extends $tea.Model {
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

export class SendMessageRequest extends $tea.Model {
  senderUid?: string;
  receiverUid?: string;
  conversationId?: string;
  content?: string;
  uuid?: string;
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      senderUid: 'senderUid',
      receiverUid: 'receiverUid',
      conversationId: 'conversationId',
      content: 'content',
      uuid: 'uuid',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      senderUid: 'string',
      receiverUid: 'string',
      conversationId: 'string',
      content: 'string',
      uuid: 'string',
      createTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageResponseBody extends $tea.Model {
  msgId?: string;
  createTime?: number;
  static names(): { [key: string]: string } {
    return {
      msgId: 'msgId',
      createTime: 'createTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      msgId: 'string',
      createTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendMessageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendMessageResponseBody,
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


  async getConversationId(request: GetConversationIdRequest): Promise<GetConversationIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationIdHeaders({ });
    return await this.getConversationIdWithOptions(request, headers, runtime);
  }

  async getConversationIdWithOptions(request: GetConversationIdRequest, headers: GetConversationIdHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationIdResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.appUid)) {
      body["appUid"] = request.appUid;
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
    return $tea.cast<GetConversationIdResponse>(await this.doROARequest("GetConversationId", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/conversations`, "json", req, runtime), new GetConversationIdResponse({}));
  }

  async recallMessage(request: RecallMessageRequest): Promise<RecallMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RecallMessageHeaders({ });
    return await this.recallMessageWithOptions(request, headers, runtime);
  }

  async recallMessageWithOptions(request: RecallMessageRequest, headers: RecallMessageHeaders, runtime: $Util.RuntimeOptions): Promise<RecallMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
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
    return $tea.cast<RecallMessageResponse>(await this.doROARequest("RecallMessage", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/messages/recall`, "none", req, runtime), new RecallMessageResponse({}));
  }

  async getMediaUrl(request: GetMediaUrlRequest): Promise<GetMediaUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMediaUrlHeaders({ });
    return await this.getMediaUrlWithOptions(request, headers, runtime);
  }

  async getMediaUrlWithOptions(request: GetMediaUrlRequest, headers: GetMediaUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetMediaUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.mediaId)) {
      body["mediaId"] = request.mediaId;
    }

    if (!Util.isUnset(request.urlExpireTime)) {
      body["urlExpireTime"] = request.urlExpireTime;
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
    return $tea.cast<GetMediaUrlResponse>(await this.doROARequest("GetMediaUrl", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/medium/urls`, "json", req, runtime), new GetMediaUrlResponse({}));
  }

  async readMessage(request: ReadMessageRequest): Promise<ReadMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReadMessageHeaders({ });
    return await this.readMessageWithOptions(request, headers, runtime);
  }

  async readMessageWithOptions(request: ReadMessageRequest, headers: ReadMessageHeaders, runtime: $Util.RuntimeOptions): Promise<ReadMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.operatorUid)) {
      body["operatorUid"] = request.operatorUid;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
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
    return $tea.cast<ReadMessageResponse>(await this.doROARequest("ReadMessage", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/messages/read`, "none", req, runtime), new ReadMessageResponse({}));
  }

  async addProfile(request: AddProfileRequest): Promise<AddProfileResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddProfileHeaders({ });
    return await this.addProfileWithOptions(request, headers, runtime);
  }

  async addProfileWithOptions(request: AddProfileRequest, headers: AddProfileHeaders, runtime: $Util.RuntimeOptions): Promise<AddProfileResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nick)) {
      body["nick"] = request.nick;
    }

    if (!Util.isUnset(request.avatarMediaId)) {
      body["avatarMediaId"] = request.avatarMediaId;
    }

    if (!Util.isUnset(request.appUid)) {
      body["appUid"] = request.appUid;
    }

    if (!Util.isUnset(request.mobileNumber)) {
      body["mobileNumber"] = request.mobileNumber;
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
    return $tea.cast<AddProfileResponse>(await this.doROARequest("AddProfile", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/users/profiles`, "none", req, runtime), new AddProfileResponse({}));
  }

  async sendMessage(request: SendMessageRequest): Promise<SendMessageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageHeaders({ });
    return await this.sendMessageWithOptions(request, headers, runtime);
  }

  async sendMessageWithOptions(request: SendMessageRequest, headers: SendMessageHeaders, runtime: $Util.RuntimeOptions): Promise<SendMessageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.senderUid)) {
      body["senderUid"] = request.senderUid;
    }

    if (!Util.isUnset(request.receiverUid)) {
      body["receiverUid"] = request.receiverUid;
    }

    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.uuid)) {
      body["uuid"] = request.uuid;
    }

    if (!Util.isUnset(request.createTime)) {
      body["createTime"] = request.createTime;
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
    return $tea.cast<SendMessageResponse>(await this.doROARequest("SendMessage", "impaas_1.0", "HTTP", "POST", "AK", `/v1.0/impaas/interconnections/messages/send`, "json", req, runtime), new SendMessageResponse({}));
  }

}
