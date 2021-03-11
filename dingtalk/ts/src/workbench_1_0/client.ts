// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import * as $tea from '@alicloud/tea-typescript';

export class QueryShortcutScopesHeaders extends $tea.Model {
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

export class QueryShortcutScopesResponseBody extends $tea.Model {
  userVisibleScopes?: string[];
  deptVisibleScopes?: string[];
  static names(): { [key: string]: string } {
    return {
      userVisibleScopes: 'userVisibleScopes',
      deptVisibleScopes: 'deptVisibleScopes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userVisibleScopes: { 'type': 'array', 'itemType': 'string' },
      deptVisibleScopes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryShortcutScopesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryShortcutScopesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryShortcutScopesResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryComponentScopesHeaders extends $tea.Model {
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

export class QueryComponentScopesResponseBody extends $tea.Model {
  userVisibleScopes?: string[];
  deptVisibleScopes?: string[];
  static names(): { [key: string]: string } {
    return {
      userVisibleScopes: 'userVisibleScopes',
      deptVisibleScopes: 'deptVisibleScopes',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userVisibleScopes: { 'type': 'array', 'itemType': 'string' },
      deptVisibleScopes: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryComponentScopesResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryComponentScopesResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryComponentScopesResponseBody,
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


  async queryShortcutScopes(shortcutKey: string): Promise<QueryShortcutScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryShortcutScopesHeaders({ });
    return await this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
  }

  async queryShortcutScopesWithOptions(shortcutKey: string, headers: QueryShortcutScopesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryShortcutScopesResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryShortcutScopesResponse>(await this.doROARequest("QueryShortcutScopes", "workbench_1.0", "HTTP", "GET", "AK", `/v1.0/workbench/shortcuts/${shortcutKey}/scopes`, "json", req, runtime), new QueryShortcutScopesResponse({}));
  }

  async queryComponentScopes(componentId: string): Promise<QueryComponentScopesResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryComponentScopesHeaders({ });
    return await this.queryComponentScopesWithOptions(componentId, headers, runtime);
  }

  async queryComponentScopesWithOptions(componentId: string, headers: QueryComponentScopesHeaders, runtime: $Util.RuntimeOptions): Promise<QueryComponentScopesResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryComponentScopesResponse>(await this.doROARequest("QueryComponentScopes", "workbench_1.0", "HTTP", "GET", "AK", `/v1.0/workbench/components/${componentId}/scopes`, "json", req, runtime), new QueryComponentScopesResponse({}));
  }

}
