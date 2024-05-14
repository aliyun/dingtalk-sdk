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

export class FinishHeaders extends $tea.Model {
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

export class FinishRequest extends $tea.Model {
  conversationToken?: string;
  static names(): { [key: string]: string } {
    return {
      conversationToken: 'conversationToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishResponseBody extends $tea.Model {
  result?: FinishResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: FinishResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: FinishResponseBody;
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
      body: FinishResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrepareHeaders extends $tea.Model {
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

export class PrepareRequest extends $tea.Model {
  content?: string;
  contentType?: string;
  openConversationId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      contentType: 'contentType',
      openConversationId: 'openConversationId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      contentType: 'string',
      openConversationId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrepareResponseBody extends $tea.Model {
  result?: PrepareResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: PrepareResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PrepareResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PrepareResponseBody;
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
      body: PrepareResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReplyHeaders extends $tea.Model {
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

export class ReplyRequest extends $tea.Model {
  content?: string;
  contentType?: string;
  conversationToken?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      contentType: 'contentType',
      conversationToken: 'conversationToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      contentType: 'string',
      conversationToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReplyResponseBody extends $tea.Model {
  result?: ReplyResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ReplyResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReplyResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: ReplyResponseBody;
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
      body: ReplyResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendHeaders extends $tea.Model {
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

export class SendRequest extends $tea.Model {
  content?: string;
  contentType?: string;
  openConversationId?: string;
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      contentType: 'contentType',
      openConversationId: 'openConversationId',
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      contentType: 'string',
      openConversationId: 'string',
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendResponseBody extends $tea.Model {
  result?: SendResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: SendResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: SendResponseBody;
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
      body: SendResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateHeaders extends $tea.Model {
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

export class UpdateRequest extends $tea.Model {
  content?: string;
  contentType?: string;
  conversationToken?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      contentType: 'contentType',
      conversationToken: 'conversationToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      contentType: 'string',
      conversationToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResponseBody extends $tea.Model {
  result?: UpdateResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: UpdateResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateResponseBody;
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
      body: UpdateResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class FinishResponseBodyResult extends $tea.Model {
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

export class PrepareResponseBodyResult extends $tea.Model {
  conversationToken?: string;
  static names(): { [key: string]: string } {
    return {
      conversationToken: 'conversationToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ReplyResponseBodyResult extends $tea.Model {
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

export class SendResponseBodyResult extends $tea.Model {
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

export class UpdateResponseBodyResult extends $tea.Model {
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


  /**
   * @summary 在主动模式下完结会话框
   *
   * @param request FinishRequest
   * @param headers FinishHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return FinishResponse
   */
  async finishWithOptions(request: FinishRequest, headers: FinishHeaders, runtime: $Util.RuntimeOptions): Promise<FinishResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationToken)) {
      body["conversationToken"] = request.conversationToken;
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
      action: "Finish",
      version: "aiInteraction_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiInteraction/finish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<FinishResponse>(await this.execute(params, req, runtime), new FinishResponse({}));
  }

  /**
   * @summary 在主动模式下完结会话框
   *
   * @param request FinishRequest
   * @return FinishResponse
   */
  async finish(request: FinishRequest): Promise<FinishResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new FinishHeaders({ });
    return await this.finishWithOptions(request, headers, runtime);
  }

  /**
   * @summary 在主动模式下准备会话框
   *
   * @param request PrepareRequest
   * @param headers PrepareHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return PrepareResponse
   */
  async prepareWithOptions(request: PrepareRequest, headers: PrepareHeaders, runtime: $Util.RuntimeOptions): Promise<PrepareResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.contentType)) {
      body["contentType"] = request.contentType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "Prepare",
      version: "aiInteraction_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiInteraction/prepare`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PrepareResponse>(await this.execute(params, req, runtime), new PrepareResponse({}));
  }

  /**
   * @summary 在主动模式下准备会话框
   *
   * @param request PrepareRequest
   * @return PrepareResponse
   */
  async prepare(request: PrepareRequest): Promise<PrepareResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PrepareHeaders({ });
    return await this.prepareWithOptions(request, headers, runtime);
  }

  /**
   * @summary 在回复模式下更新会话框
   *
   * @param request ReplyRequest
   * @param headers ReplyHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return ReplyResponse
   */
  async replyWithOptions(request: ReplyRequest, headers: ReplyHeaders, runtime: $Util.RuntimeOptions): Promise<ReplyResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.contentType)) {
      body["contentType"] = request.contentType;
    }

    if (!Util.isUnset(request.conversationToken)) {
      body["conversationToken"] = request.conversationToken;
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
      action: "Reply",
      version: "aiInteraction_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiInteraction/reply`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ReplyResponse>(await this.execute(params, req, runtime), new ReplyResponse({}));
  }

  /**
   * @summary 在回复模式下更新会话框
   *
   * @param request ReplyRequest
   * @return ReplyResponse
   */
  async reply(request: ReplyRequest): Promise<ReplyResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ReplyHeaders({ });
    return await this.replyWithOptions(request, headers, runtime);
  }

  /**
   * @summary 直接发送消息
   *
   * @param request SendRequest
   * @param headers SendHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return SendResponse
   */
  async sendWithOptions(request: SendRequest, headers: SendHeaders, runtime: $Util.RuntimeOptions): Promise<SendResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.contentType)) {
      body["contentType"] = request.contentType;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.unionId)) {
      body["unionId"] = request.unionId;
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
      action: "Send",
      version: "aiInteraction_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiInteraction/send`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SendResponse>(await this.execute(params, req, runtime), new SendResponse({}));
  }

  /**
   * @summary 直接发送消息
   *
   * @param request SendRequest
   * @return SendResponse
   */
  async send(request: SendRequest): Promise<SendResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendHeaders({ });
    return await this.sendWithOptions(request, headers, runtime);
  }

  /**
   * @summary 在主动模式下更新会话框
   *
   * @param request UpdateRequest
   * @param headers UpdateHeaders
   * @param runtime runtime options for this request RuntimeOptions
   * @return UpdateResponse
   */
  async updateWithOptions(request: UpdateRequest, headers: UpdateHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.contentType)) {
      body["contentType"] = request.contentType;
    }

    if (!Util.isUnset(request.conversationToken)) {
      body["conversationToken"] = request.conversationToken;
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
      action: "Update",
      version: "aiInteraction_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/aiInteraction/update`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateResponse>(await this.execute(params, req, runtime), new UpdateResponse({}));
  }

  /**
   * @summary 在主动模式下更新会话框
   *
   * @param request UpdateRequest
   * @return UpdateResponse
   */
  async update(request: UpdateRequest): Promise<UpdateResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateHeaders({ });
    return await this.updateWithOptions(request, headers, runtime);
  }

}
