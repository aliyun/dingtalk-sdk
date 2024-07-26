// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import * as $tea from '@alicloud/tea-typescript';

export class AddAttendeeToEventGroupHeaders extends $tea.Model {
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

export class AddAttendeeToEventGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: {[key: string]: any};
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
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateEventGroupHeaders extends $tea.Model {
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

export class CreateEventGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: {[key: string]: any};
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
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendInteractiveCardHeaders extends $tea.Model {
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

export class SendInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: {[key: string]: any};
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
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendSingleInteractiveCardHeaders extends $tea.Model {
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

export class SendSingleInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: {[key: string]: any};
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
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateInteractiveCardHeaders extends $tea.Model {
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

export class UpdateInteractiveCardResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: {[key: string]: any};
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
      body: { 'type': 'map', 'keyType': 'string', 'valueType': 'any' },
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
   * 在项目事件会话中加人
   * 
   * @param headers - AddAttendeeToEventGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns AddAttendeeToEventGroupResponse
   */
  async addAttendeeToEventGroupWithOptions(userId: string, groupId: string, headers: AddAttendeeToEventGroupHeaders, runtime: $Util.RuntimeOptions): Promise<AddAttendeeToEventGroupResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "AddAttendeeToEventGroup",
      version: "projectIntegration_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/projectIntegration/users/${userId}/eventGroups/${groupId}/members`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<AddAttendeeToEventGroupResponse>(await this.execute(params, req, runtime), new AddAttendeeToEventGroupResponse({}));
  }

  /**
   * 在项目事件会话中加人
   * @returns AddAttendeeToEventGroupResponse
   */
  async addAttendeeToEventGroup(userId: string, groupId: string): Promise<AddAttendeeToEventGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddAttendeeToEventGroupHeaders({ });
    return await this.addAttendeeToEventGroupWithOptions(userId, groupId, headers, runtime);
  }

  /**
   * 创建项目事件会话
   * 
   * @param headers - CreateEventGroupHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateEventGroupResponse
   */
  async createEventGroupWithOptions(userId: string, headers: CreateEventGroupHeaders, runtime: $Util.RuntimeOptions): Promise<CreateEventGroupResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "CreateEventGroup",
      version: "projectIntegration_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/projectIntegration/users/${userId}/eventGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateEventGroupResponse>(await this.execute(params, req, runtime), new CreateEventGroupResponse({}));
  }

  /**
   * 创建项目事件会话
   * @returns CreateEventGroupResponse
   */
  async createEventGroup(userId: string): Promise<CreateEventGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateEventGroupHeaders({ });
    return await this.createEventGroupWithOptions(userId, headers, runtime);
  }

  /**
   * 在群会话发送项目卡片消息
   * 
   * @param headers - SendInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendInteractiveCardResponse
   */
  async sendInteractiveCardWithOptions(userId: string, headers: SendInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendInteractiveCardResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "SendInteractiveCard",
      version: "projectIntegration_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/projectIntegration/users/${userId}/groupChatCardMessages`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SendInteractiveCardResponse>(await this.execute(params, req, runtime), new SendInteractiveCardResponse({}));
  }

  /**
   * 在群会话发送项目卡片消息
   * @returns SendInteractiveCardResponse
   */
  async sendInteractiveCard(userId: string): Promise<SendInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendInteractiveCardHeaders({ });
    return await this.sendInteractiveCardWithOptions(userId, headers, runtime);
  }

  /**
   * 单聊会话发送项目卡片消息
   * 
   * @param headers - SendSingleInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns SendSingleInteractiveCardResponse
   */
  async sendSingleInteractiveCardWithOptions(userId: string, headers: SendSingleInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<SendSingleInteractiveCardResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "SendSingleInteractiveCard",
      version: "projectIntegration_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/projectIntegration/users/${userId}/singleChatCardMessages`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<SendSingleInteractiveCardResponse>(await this.execute(params, req, runtime), new SendSingleInteractiveCardResponse({}));
  }

  /**
   * 单聊会话发送项目卡片消息
   * @returns SendSingleInteractiveCardResponse
   */
  async sendSingleInteractiveCard(userId: string): Promise<SendSingleInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SendSingleInteractiveCardHeaders({ });
    return await this.sendSingleInteractiveCardWithOptions(userId, headers, runtime);
  }

  /**
   * 更新项目卡片消息
   * 
   * @param headers - UpdateInteractiveCardHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateInteractiveCardResponse
   */
  async updateInteractiveCardWithOptions(userId: string, headers: UpdateInteractiveCardHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateInteractiveCardResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "UpdateInteractiveCard",
      version: "projectIntegration_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/projectIntegration/users/${userId}/cardMessages`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<UpdateInteractiveCardResponse>(await this.execute(params, req, runtime), new UpdateInteractiveCardResponse({}));
  }

  /**
   * 更新项目卡片消息
   * @returns UpdateInteractiveCardResponse
   */
  async updateInteractiveCard(userId: string): Promise<UpdateInteractiveCardResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateInteractiveCardHeaders({ });
    return await this.updateInteractiveCardWithOptions(userId, headers, runtime);
  }

}
