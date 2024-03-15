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

export class InstallCoolAppOrderToGroupHeaders extends $tea.Model {
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

export class InstallCoolAppOrderToGroupRequest extends $tea.Model {
  conversationId?: string;
  sortedPluginIdList?: number[];
  templateId?: string;
  unsortedPluginIdList?: number[];
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      sortedPluginIdList: 'sortedPluginIdList',
      templateId: 'templateId',
      unsortedPluginIdList: 'unsortedPluginIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      sortedPluginIdList: { 'type': 'array', 'itemType': 'number' },
      templateId: 'string',
      unsortedPluginIdList: { 'type': 'array', 'itemType': 'number' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppOrderToGroupResponseBody extends $tea.Model {
  result?: string;
  success?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppOrderToGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InstallCoolAppOrderToGroupResponseBody;
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
      body: InstallCoolAppOrderToGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppToGroupHeaders extends $tea.Model {
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

export class InstallCoolAppToGroupRequest extends $tea.Model {
  conversationId?: string;
  operateCoolAppCode?: string;
  operatorId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      operateCoolAppCode: 'operateCoolAppCode',
      operatorId: 'operatorId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      operateCoolAppCode: 'string',
      operatorId: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppToGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InstallCoolAppToGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: InstallCoolAppToGroupResponseBody;
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
      body: InstallCoolAppToGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCoolAppShortcutOrderHeaders extends $tea.Model {
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

export class QueryCoolAppShortcutOrderRequest extends $tea.Model {
  conversationId?: string;
  operatorId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      operatorId: 'operatorId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      operatorId: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCoolAppShortcutOrderResponseBody extends $tea.Model {
  result?: QueryCoolAppShortcutOrderResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryCoolAppShortcutOrderResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCoolAppShortcutOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryCoolAppShortcutOrderResponseBody;
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
      body: QueryCoolAppShortcutOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UninstallCoolAppFromGroupHeaders extends $tea.Model {
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

export class UninstallCoolAppFromGroupRequest extends $tea.Model {
  conversationId?: string;
  operateCoolAppCode?: string;
  operatorId?: string;
  templateId?: string;
  static names(): { [key: string]: string } {
    return {
      conversationId: 'conversationId',
      operateCoolAppCode: 'operateCoolAppCode',
      operatorId: 'operatorId',
      templateId: 'templateId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationId: 'string',
      operateCoolAppCode: 'string',
      operatorId: 'string',
      templateId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UninstallCoolAppFromGroupResponseBody extends $tea.Model {
  result?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UninstallCoolAppFromGroupResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UninstallCoolAppFromGroupResponseBody;
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
      body: UninstallCoolAppFromGroupResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList extends $tea.Model {
  appCode?: string;
  desc?: string;
  pluginId?: string;
  source?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      desc: 'desc',
      pluginId: 'pluginId',
      source: 'source',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      desc: 'string',
      pluginId: 'string',
      source: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCoolAppShortcutOrderResponseBodyResultMyPluginList extends $tea.Model {
  appCode?: string;
  desc?: string;
  pluginId?: string;
  source?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      desc: 'desc',
      pluginId: 'pluginId',
      source: 'source',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      desc: 'string',
      pluginId: 'string',
      source: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList extends $tea.Model {
  appCode?: string;
  desc?: string;
  pluginId?: string;
  source?: string;
  title?: string;
  static names(): { [key: string]: string } {
    return {
      appCode: 'appCode',
      desc: 'desc',
      pluginId: 'pluginId',
      source: 'source',
      title: 'title',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appCode: 'string',
      desc: 'string',
      pluginId: 'string',
      source: 'string',
      title: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCoolAppShortcutOrderResponseBodyResult extends $tea.Model {
  forbiddenPluginList?: QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList[];
  myPluginList?: QueryCoolAppShortcutOrderResponseBodyResultMyPluginList[];
  otherPluginList?: QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList[];
  static names(): { [key: string]: string } {
    return {
      forbiddenPluginList: 'forbiddenPluginList',
      myPluginList: 'myPluginList',
      otherPluginList: 'otherPluginList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      forbiddenPluginList: { 'type': 'array', 'itemType': QueryCoolAppShortcutOrderResponseBodyResultForbiddenPluginList },
      myPluginList: { 'type': 'array', 'itemType': QueryCoolAppShortcutOrderResponseBodyResultMyPluginList },
      otherPluginList: { 'type': 'array', 'itemType': QueryCoolAppShortcutOrderResponseBodyResultOtherPluginList },
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


  async installCoolAppOrderToGroupWithOptions(request: InstallCoolAppOrderToGroupRequest, headers: InstallCoolAppOrderToGroupHeaders, runtime: $Util.RuntimeOptions): Promise<InstallCoolAppOrderToGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.sortedPluginIdList)) {
      body["sortedPluginIdList"] = request.sortedPluginIdList;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
    }

    if (!Util.isUnset(request.unsortedPluginIdList)) {
      body["unsortedPluginIdList"] = request.unsortedPluginIdList;
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
      action: "InstallCoolAppOrderToGroup",
      version: "dpaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dpaas/coolApps/shortcuts/plugins/order`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallCoolAppOrderToGroupResponse>(await this.execute(params, req, runtime), new InstallCoolAppOrderToGroupResponse({}));
  }

  async installCoolAppOrderToGroup(request: InstallCoolAppOrderToGroupRequest): Promise<InstallCoolAppOrderToGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallCoolAppOrderToGroupHeaders({ });
    return await this.installCoolAppOrderToGroupWithOptions(request, headers, runtime);
  }

  async installCoolAppToGroupWithOptions(request: InstallCoolAppToGroupRequest, headers: InstallCoolAppToGroupHeaders, runtime: $Util.RuntimeOptions): Promise<InstallCoolAppToGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.operateCoolAppCode)) {
      body["operateCoolAppCode"] = request.operateCoolAppCode;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
      action: "InstallCoolAppToGroup",
      version: "dpaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dpaas/coolApps/shortcuts/plugins/install`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<InstallCoolAppToGroupResponse>(await this.execute(params, req, runtime), new InstallCoolAppToGroupResponse({}));
  }

  async installCoolAppToGroup(request: InstallCoolAppToGroupRequest): Promise<InstallCoolAppToGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InstallCoolAppToGroupHeaders({ });
    return await this.installCoolAppToGroupWithOptions(request, headers, runtime);
  }

  async queryCoolAppShortcutOrderWithOptions(request: QueryCoolAppShortcutOrderRequest, headers: QueryCoolAppShortcutOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCoolAppShortcutOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
      action: "QueryCoolAppShortcutOrder",
      version: "dpaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dpaas/coolApps/shortcuts/plugins/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryCoolAppShortcutOrderResponse>(await this.execute(params, req, runtime), new QueryCoolAppShortcutOrderResponse({}));
  }

  async queryCoolAppShortcutOrder(request: QueryCoolAppShortcutOrderRequest): Promise<QueryCoolAppShortcutOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCoolAppShortcutOrderHeaders({ });
    return await this.queryCoolAppShortcutOrderWithOptions(request, headers, runtime);
  }

  async uninstallCoolAppFromGroupWithOptions(request: UninstallCoolAppFromGroupRequest, headers: UninstallCoolAppFromGroupHeaders, runtime: $Util.RuntimeOptions): Promise<UninstallCoolAppFromGroupResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conversationId)) {
      body["conversationId"] = request.conversationId;
    }

    if (!Util.isUnset(request.operateCoolAppCode)) {
      body["operateCoolAppCode"] = request.operateCoolAppCode;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
    }

    if (!Util.isUnset(request.templateId)) {
      body["templateId"] = request.templateId;
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
      action: "UninstallCoolAppFromGroup",
      version: "dpaas_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/dpaas/coolApps/shortcuts/plugins/uninstall`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UninstallCoolAppFromGroupResponse>(await this.execute(params, req, runtime), new UninstallCoolAppFromGroupResponse({}));
  }

  async uninstallCoolAppFromGroup(request: UninstallCoolAppFromGroupRequest): Promise<UninstallCoolAppFromGroupResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UninstallCoolAppFromGroupHeaders({ });
    return await this.uninstallCoolAppFromGroupWithOptions(request, headers, runtime);
  }

}
