// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateGroupBlackboardHeaders extends $tea.Model {
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

export class CreateGroupBlackboardRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 这是一条群公告
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid123456
   */
  openConversationId?: string;
  /**
   * @example
   * false
   */
  sendDing?: boolean;
  /**
   * @example
   * false
   */
  sticky?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * xxx
   */
  uniqueId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      content: 'content',
      openConversationId: 'openConversationId',
      sendDing: 'sendDing',
      sticky: 'sticky',
      uniqueId: 'uniqueId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      content: 'string',
      openConversationId: 'string',
      sendDing: 'boolean',
      sticky: 'boolean',
      uniqueId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupBlackboardResponseBody extends $tea.Model {
  /**
   * @example
   * 123456
   */
  dataId?: string;
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
      dataId: 'dataId',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateGroupBlackboardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateGroupBlackboardResponseBody;
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
      body: CreateGroupBlackboardResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGroupBlackboardHeaders extends $tea.Model {
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

export class DeleteGroupBlackboardRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * e3b4f5
   */
  dataId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid123456
   */
  openConversationId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 001
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      dataId: 'dataId',
      openConversationId: 'openConversationId',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dataId: 'string',
      openConversationId: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGroupBlackboardResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  isDeleted?: boolean;
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
      isDeleted: 'isDeleted',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isDeleted: 'boolean',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteGroupBlackboardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: DeleteGroupBlackboardResponseBody;
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
      body: DeleteGroupBlackboardResponseBody,
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
   * 创建群公告
   * 
   * @param request - CreateGroupBlackboardRequest
   * @param headers - CreateGroupBlackboardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateGroupBlackboardResponse
   */
  async createGroupBlackboardWithOptions(request: CreateGroupBlackboardRequest, headers: CreateGroupBlackboardHeaders, runtime: $Util.RuntimeOptions): Promise<CreateGroupBlackboardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
    }

    if (!Util.isUnset(request.sendDing)) {
      body["sendDing"] = request.sendDing;
    }

    if (!Util.isUnset(request.sticky)) {
      body["sticky"] = request.sticky;
    }

    if (!Util.isUnset(request.uniqueId)) {
      body["uniqueId"] = request.uniqueId;
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
      action: "CreateGroupBlackboard",
      version: "groupBlackboard_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/groupBlackboard/blackboards`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateGroupBlackboardResponse>(await this.execute(params, req, runtime), new CreateGroupBlackboardResponse({}));
  }

  /**
   * 创建群公告
   * 
   * @param request - CreateGroupBlackboardRequest
   * @returns CreateGroupBlackboardResponse
   */
  async createGroupBlackboard(request: CreateGroupBlackboardRequest): Promise<CreateGroupBlackboardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupBlackboardHeaders({ });
    return await this.createGroupBlackboardWithOptions(request, headers, runtime);
  }

  /**
   * 删除群公告
   * 
   * @param request - DeleteGroupBlackboardRequest
   * @param headers - DeleteGroupBlackboardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns DeleteGroupBlackboardResponse
   */
  async deleteGroupBlackboardWithOptions(request: DeleteGroupBlackboardRequest, headers: DeleteGroupBlackboardHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteGroupBlackboardResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dataId)) {
      body["dataId"] = request.dataId;
    }

    if (!Util.isUnset(request.openConversationId)) {
      body["openConversationId"] = request.openConversationId;
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
      action: "DeleteGroupBlackboard",
      version: "groupBlackboard_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/groupBlackboard/blackboards/remove`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<DeleteGroupBlackboardResponse>(await this.execute(params, req, runtime), new DeleteGroupBlackboardResponse({}));
  }

  /**
   * 删除群公告
   * 
   * @param request - DeleteGroupBlackboardRequest
   * @returns DeleteGroupBlackboardResponse
   */
  async deleteGroupBlackboard(request: DeleteGroupBlackboardRequest): Promise<DeleteGroupBlackboardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteGroupBlackboardHeaders({ });
    return await this.deleteGroupBlackboardWithOptions(request, headers, runtime);
  }

}
