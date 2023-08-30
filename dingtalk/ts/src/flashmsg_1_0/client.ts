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

export class PrivateFieldMapValue extends $tea.Model {
  tipTitle?: string;
  isDingSend?: boolean;
  isRead?: boolean;
  buttonStatus?: string;
  extension?: { [key: string]: string };
  static names(): { [key: string]: string } {
    return {
      tipTitle: 'tipTitle',
      isDingSend: 'isDingSend',
      isRead: 'isRead',
      buttonStatus: 'buttonStatus',
      extension: 'extension',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tipTitle: 'string',
      isDingSend: 'boolean',
      isRead: 'boolean',
      buttonStatus: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListHeaders extends $tea.Model {
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

export class GetBaseProfileListRequest extends $tea.Model {
  body?: string[];
  static names(): { [key: string]: string } {
    return {
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      body: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListResponseBody extends $tea.Model {
  result?: GetBaseProfileListResponseBodyResult[];
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetBaseProfileListResponseBodyResult },
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetBaseProfileListResponseBody;
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
      body: GetBaseProfileListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationHeaders extends $tea.Model {
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

export class GetConversationRequest extends $tea.Model {
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

export class GetConversationResponseBody extends $tea.Model {
  result?: GetConversationResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetConversationResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetConversationResponseBody;
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
      body: GetConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMemberListHeaders extends $tea.Model {
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

export class GetMemberListRequest extends $tea.Model {
  openConversationId?: string;
  pageNumber?: number;
  pageSize?: number;
  static names(): { [key: string]: string } {
    return {
      openConversationId: 'openConversationId',
      pageNumber: 'pageNumber',
      pageSize: 'pageSize',
    };
  }

  static types(): { [key: string]: any } {
    return {
      openConversationId: 'string',
      pageNumber: 'number',
      pageSize: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMemberListResponseBody extends $tea.Model {
  result?: string[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetMemberListResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetMemberListResponseBody;
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
      body: GetMemberListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingTipHeaders extends $tea.Model {
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

export class SendDingTipRequest extends $tea.Model {
  extension?: { [key: string]: string };
  link?: SendDingTipRequestLink;
  messageId?: string;
  receiverUserId?: string[];
  textContent?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      link: 'link',
      messageId: 'messageId',
      receiverUserId: 'receiverUserId',
      textContent: 'textContent',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      link: SendDingTipRequestLink,
      messageId: 'string',
      receiverUserId: { 'type': 'array', 'itemType': 'string' },
      textContent: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingTipResponseBody extends $tea.Model {
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

export class SendDingTipResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendDingTipResponseBody;
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
      body: SendDingTipResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipHeaders extends $tea.Model {
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

export class SendMessageTipRequest extends $tea.Model {
  defaultView?: SendMessageTipRequestDefaultView;
  messageId?: string;
  openConversationId?: string;
  privateFieldMap?: { [key: string]: PrivateFieldMapValue };
  publicField?: SendMessageTipRequestPublicField;
  receiverUserId?: string[];
  static names(): { [key: string]: string } {
    return {
      defaultView: 'defaultView',
      messageId: 'messageId',
      openConversationId: 'openConversationId',
      privateFieldMap: 'privateFieldMap',
      publicField: 'publicField',
      receiverUserId: 'receiverUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      defaultView: SendMessageTipRequestDefaultView,
      messageId: 'string',
      openConversationId: 'string',
      privateFieldMap: { 'type': 'map', 'keyType': 'string', 'valueType': PrivateFieldMapValue },
      publicField: SendMessageTipRequestPublicField,
      receiverUserId: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipResponseBody extends $tea.Model {
  result?: SendMessageTipResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SendMessageTipResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SendMessageTipResponseBody;
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
      body: SendMessageTipResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetBaseProfileListResponseBodyResult extends $tea.Model {
  avatarMediaId?: string;
  nick?: string;
  nickPinyin?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      avatarMediaId: 'avatarMediaId',
      nick: 'nick',
      nickPinyin: 'nickPinyin',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatarMediaId: 'string',
      nick: 'string',
      nickPinyin: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetConversationResponseBodyResult extends $tea.Model {
  corpId?: string;
  memberCount?: number;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      memberCount: 'memberCount',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      memberCount: 'number',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendDingTipRequestLink extends $tea.Model {
  extension?: { [key: string]: string };
  linkUrl?: string;
  picMediaId?: string;
  text?: string;
  static names(): { [key: string]: string } {
    return {
      extension: 'extension',
      linkUrl: 'linkUrl',
      picMediaId: 'picMediaId',
      text: 'text',
    };
  }

  static types(): { [key: string]: any } {
    return {
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      linkUrl: 'string',
      picMediaId: 'string',
      text: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipRequestDefaultView extends $tea.Model {
  actionName?: string;
  actionUrl?: string;
  authCode?: string;
  authMediaId?: string;
  cardTitle?: string;
  cardTitleColor?: string;
  desc?: string;
  mediaId?: string;
  needShowUpdateTail?: string;
  summary?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      actionName: 'actionName',
      actionUrl: 'actionUrl',
      authCode: 'authCode',
      authMediaId: 'authMediaId',
      cardTitle: 'cardTitle',
      cardTitleColor: 'cardTitleColor',
      desc: 'desc',
      mediaId: 'mediaId',
      needShowUpdateTail: 'needShowUpdateTail',
      summary: 'summary',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      actionName: 'string',
      actionUrl: 'string',
      authCode: 'string',
      authMediaId: 'string',
      cardTitle: 'string',
      cardTitleColor: 'string',
      desc: 'string',
      mediaId: 'string',
      needShowUpdateTail: 'string',
      summary: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipRequestPublicField extends $tea.Model {
  detailUrl?: string;
  durationDesc?: string;
  extension?: { [key: string]: string };
  isExpired?: boolean;
  readActionUrl?: string;
  readProgressDesc?: string;
  static names(): { [key: string]: string } {
    return {
      detailUrl: 'detailUrl',
      durationDesc: 'durationDesc',
      extension: 'extension',
      isExpired: 'isExpired',
      readActionUrl: 'readActionUrl',
      readProgressDesc: 'readProgressDesc',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detailUrl: 'string',
      durationDesc: 'string',
      extension: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      isExpired: 'boolean',
      readActionUrl: 'string',
      readProgressDesc: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendMessageTipResponseBodyResult extends $tea.Model {
  bizId?: string;
  cardInstanceId?: string;
  static names(): { [key: string]: string } {
    return {
      bizId: 'bizId',
      cardInstanceId: 'cardInstanceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizId: 'string',
      cardInstanceId: 'string',
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


  async getBaseProfileListWithOptions(request: GetBaseProfileListRequest, headers: GetBaseProfileListHeaders, runtime: $Util.RuntimeOptions): Promise<GetBaseProfileListResponse> {
    Util.validateModel(request);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      body: request.body,
    });
    let params = new $OpenApi.Params({
      action: "GetBaseProfileList",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/users/baseInfos/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetBaseProfileListResponse>(await this.execute(params, req, runtime), new GetBaseProfileListResponse({}));
  }

  async getBaseProfileList(request: GetBaseProfileListRequest): Promise<GetBaseProfileListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetBaseProfileListHeaders({ });
    return await this.getBaseProfileListWithOptions(request, headers, runtime);
  }

  async getConversationWithOptions(request: GetConversationRequest, headers: GetConversationHeaders, runtime: $Util.RuntimeOptions): Promise<GetConversationResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
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
      action: "GetConversation",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/conversations/infos`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetConversationResponse>(await this.execute(params, req, runtime), new GetConversationResponse({}));
  }

  async getConversation(request: GetConversationRequest): Promise<GetConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetConversationHeaders({ });
    return await this.getConversationWithOptions(request, headers, runtime);
  }

  async getMemberListWithOptions(request: GetMemberListRequest, headers: GetMemberListHeaders, runtime: $Util.RuntimeOptions): Promise<GetMemberListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.openConversationId)) {
      query["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.pageNumber)) {
      query["pageNumber"] = request.pageNumber;
    }

    if (!Util.isUnset(request.pageSize)) {
      query["pageSize"] = request.pageSize;
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
      action: "GetMemberList",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/conversations/memberIdLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetMemberListResponse>(await this.execute(params, req, runtime), new GetMemberListResponse({}));
  }

  async getMemberList(request: GetMemberListRequest): Promise<GetMemberListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetMemberListHeaders({ });
    return await this.getMemberListWithOptions(request, headers, runtime);
  }

  async sendDingTipWithOptions(request: SendDingTipRequest, headers: SendDingTipHeaders, runtime: $Util.RuntimeOptions): Promise<SendDingTipResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.extension)) {
      body["extension"] = request.extension;
    }

    if (!Util.isUnset(request.link)) {
      body["link"] = request.link;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.receiverUserId)) {
      body["receiverUserId"] = request.receiverUserId;
    }

    if (!Util.isUnset(request.textContent)) {
      body["textContent"] = request.textContent;
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
      action: "SendDingTip",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/ding/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendDingTipResponse>(await this.execute(params, req, runtime), new SendDingTipResponse({}));
  }

  async sendDingTip(request: SendDingTipRequest): Promise<SendDingTipResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendDingTipHeaders({ });
    return await this.sendDingTipWithOptions(request, headers, runtime);
  }

  async sendMessageTipWithOptions(request: SendMessageTipRequest, headers: SendMessageTipHeaders, runtime: $Util.RuntimeOptions): Promise<SendMessageTipResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.defaultView)) {
      body["defaultView"] = request.defaultView;
    }

    if (!Util.isUnset(request.messageId)) {
      body["messageId"] = request.messageId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.privateFieldMap)) {
      body["privateFieldMap"] = request.privateFieldMap;
    }

    if (!Util.isUnset(request.publicField)) {
      body["publicField"] = request.publicField;
    }

    if (!Util.isUnset(request.receiverUserId)) {
      body["receiverUserId"] = request.receiverUserId;
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
      action: "SendMessageTip",
      version: "flashmsg_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/flashmsg/messages/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendMessageTipResponse>(await this.execute(params, req, runtime), new SendMessageTipResponse({}));
  }

  async sendMessageTip(request: SendMessageTipRequest): Promise<SendMessageTipResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendMessageTipHeaders({ });
    return await this.sendMessageTipWithOptions(request, headers, runtime);
  }

}
