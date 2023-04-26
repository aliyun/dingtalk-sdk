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
  content?: string;
  openConversationId?: string;
  sendDing?: boolean;
  sticky?: boolean;
  uniqueId?: string;
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
  dataId?: string;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateGroupBlackboardResponseBody;
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
  dataId?: string;
  openConversationId?: string;
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
  isDeleted?: boolean;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: DeleteGroupBlackboardResponseBody;
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

  async createGroupBlackboard(request: CreateGroupBlackboardRequest): Promise<CreateGroupBlackboardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateGroupBlackboardHeaders({ });
    return await this.createGroupBlackboardWithOptions(request, headers, runtime);
  }

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

  async deleteGroupBlackboard(request: DeleteGroupBlackboardRequest): Promise<DeleteGroupBlackboardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteGroupBlackboardHeaders({ });
    return await this.deleteGroupBlackboardWithOptions(request, headers, runtime);
  }

}
