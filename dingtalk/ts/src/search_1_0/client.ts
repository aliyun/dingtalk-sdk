// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetSearchTabHeaders extends $tea.Model {
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

export class GetSearchTabResponseBody extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  tabId?: number;
  name?: string;
  priority?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      tabId: 'tabId',
      name: 'name',
      priority: 'priority',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      tabId: 'number',
      name: 'string',
      priority: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchTabResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSearchTabResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSearchTabResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemHeaders extends $tea.Model {
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

export class GetSearchItemResponseBody extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  tabId?: number;
  itemId?: string;
  title?: string;
  footer?: string;
  summary?: string;
  icon?: string;
  url?: string;
  mobileUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      tabId: 'tabId',
      itemId: 'itemId',
      title: 'title',
      footer: 'footer',
      summary: 'summary',
      icon: 'icon',
      url: 'url',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      tabId: 'number',
      itemId: 'string',
      title: 'string',
      footer: 'string',
      summary: 'string',
      icon: 'string',
      url: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSearchItemResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSearchItemResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSearchTabsByOrgIdHeaders extends $tea.Model {
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

export class ListSearchTabsByOrgIdResponseBody extends $tea.Model {
  searchTabResult?: ListSearchTabsByOrgIdResponseBodySearchTabResult[];
  static names(): { [key: string]: string } {
    return {
      searchTabResult: 'searchTabResult',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchTabResult: { 'type': 'array', 'itemType': ListSearchTabsByOrgIdResponseBodySearchTabResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSearchTabsByOrgIdResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ListSearchTabsByOrgIdResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ListSearchTabsByOrgIdResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSearchItemHeaders extends $tea.Model {
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

export class DeleteSearchItemResponse extends $tea.Model {
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

export class InsertSearchItemHeaders extends $tea.Model {
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

export class InsertSearchItemRequest extends $tea.Model {
  itemId?: string;
  title?: string;
  footer?: string;
  summary?: string;
  icon?: string;
  url?: string;
  mobileUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
      title: 'title',
      footer: 'footer',
      summary: 'summary',
      icon: 'icon',
      url: 'url',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
      title: 'string',
      footer: 'string',
      summary: 'string',
      icon: 'string',
      url: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class InsertSearchItemResponse extends $tea.Model {
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

export class BatchInsertSearchItemHeaders extends $tea.Model {
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

export class BatchInsertSearchItemRequest extends $tea.Model {
  searchItemModels?: BatchInsertSearchItemRequestSearchItemModels[];
  static names(): { [key: string]: string } {
    return {
      searchItemModels: 'searchItemModels',
    };
  }

  static types(): { [key: string]: any } {
    return {
      searchItemModels: { 'type': 'array', 'itemType': BatchInsertSearchItemRequestSearchItemModels },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertSearchItemResponse extends $tea.Model {
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

export class CreateSearchTabHeaders extends $tea.Model {
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

export class CreateSearchTabRequest extends $tea.Model {
  name?: string;
  priority?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      priority: 'priority',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      priority: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSearchTabResponseBody extends $tea.Model {
  tabId?: number;
  static names(): { [key: string]: string } {
    return {
      tabId: 'tabId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      tabId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateSearchTabResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateSearchTabResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateSearchTabResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteSearchTabHeaders extends $tea.Model {
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

export class DeleteSearchTabResponse extends $tea.Model {
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

export class UpdateSearchTabHeaders extends $tea.Model {
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

export class UpdateSearchTabRequest extends $tea.Model {
  name?: string;
  priority?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      name: 'name',
      priority: 'priority',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      name: 'string',
      priority: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateSearchTabResponse extends $tea.Model {
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

export class GetSearchItemsByKeyWordHeaders extends $tea.Model {
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

export class GetSearchItemsByKeyWordRequest extends $tea.Model {
  keyWord?: string;
  nextToken?: string;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      keyWord: 'keyWord',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      keyWord: 'string',
      nextToken: 'string',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemsByKeyWordResponseBody extends $tea.Model {
  value?: GetSearchItemsByKeyWordResponseBodyValue[];
  nextToken?: string;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      value: 'value',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      value: { 'type': 'array', 'itemType': GetSearchItemsByKeyWordResponseBodyValue },
      nextToken: 'string',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemsByKeyWordResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSearchItemsByKeyWordResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSearchItemsByKeyWordResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListSearchTabsByOrgIdResponseBodySearchTabResult extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  tabId?: number;
  name?: string;
  priority?: number;
  status?: number;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      tabId: 'tabId',
      name: 'name',
      priority: 'priority',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      tabId: 'number',
      name: 'string',
      priority: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchInsertSearchItemRequestSearchItemModels extends $tea.Model {
  itemId?: string;
  title?: string;
  footer?: string;
  summary?: string;
  icon?: string;
  url?: string;
  mobileUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      itemId: 'itemId',
      title: 'title',
      footer: 'footer',
      summary: 'summary',
      icon: 'icon',
      url: 'url',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      itemId: 'string',
      title: 'string',
      footer: 'string',
      summary: 'string',
      icon: 'string',
      url: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSearchItemsByKeyWordResponseBodyValue extends $tea.Model {
  gmtCreate?: string;
  gmtModified?: string;
  tabId?: number;
  itemId?: string;
  title?: string;
  footer?: string;
  summary?: string;
  icon?: string;
  url?: string;
  mobileUrl?: string;
  pcUrl?: string;
  static names(): { [key: string]: string } {
    return {
      gmtCreate: 'gmtCreate',
      gmtModified: 'gmtModified',
      tabId: 'tabId',
      itemId: 'itemId',
      title: 'title',
      footer: 'footer',
      summary: 'summary',
      icon: 'icon',
      url: 'url',
      mobileUrl: 'mobileUrl',
      pcUrl: 'pcUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      gmtCreate: 'string',
      gmtModified: 'string',
      tabId: 'number',
      itemId: 'string',
      title: 'string',
      footer: 'string',
      summary: 'string',
      icon: 'string',
      url: 'string',
      mobileUrl: 'string',
      pcUrl: 'string',
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


  async getSearchTab(tabId: string): Promise<GetSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSearchTabHeaders({ });
    return await this.getSearchTabWithOptions(tabId, headers, runtime);
  }

  async getSearchTabWithOptions(tabId: string, headers: GetSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<GetSearchTabResponse> {
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
    return $tea.cast<GetSearchTabResponse>(await this.doROARequest("GetSearchTab", "search_1.0", "HTTP", "GET", "AK", `/v1.0/search/tabs/${tabId}`, "json", req, runtime), new GetSearchTabResponse({}));
  }

  async getSearchItem(tabId: string, itemId: string): Promise<GetSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSearchItemHeaders({ });
    return await this.getSearchItemWithOptions(tabId, itemId, headers, runtime);
  }

  async getSearchItemWithOptions(tabId: string, itemId: string, headers: GetSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<GetSearchItemResponse> {
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
    return $tea.cast<GetSearchItemResponse>(await this.doROARequest("GetSearchItem", "search_1.0", "HTTP", "GET", "AK", `/v1.0/search/tabs/${tabId}/items/${itemId}`, "json", req, runtime), new GetSearchItemResponse({}));
  }

  async listSearchTabsByOrgId(): Promise<ListSearchTabsByOrgIdResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListSearchTabsByOrgIdHeaders({ });
    return await this.listSearchTabsByOrgIdWithOptions(headers, runtime);
  }

  async listSearchTabsByOrgIdWithOptions(headers: ListSearchTabsByOrgIdHeaders, runtime: $Util.RuntimeOptions): Promise<ListSearchTabsByOrgIdResponse> {
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
    return $tea.cast<ListSearchTabsByOrgIdResponse>(await this.doROARequest("ListSearchTabsByOrgId", "search_1.0", "HTTP", "GET", "AK", `/v1.0/search/tabs`, "json", req, runtime), new ListSearchTabsByOrgIdResponse({}));
  }

  async deleteSearchItem(tabId: string, itemId: string): Promise<DeleteSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSearchItemHeaders({ });
    return await this.deleteSearchItemWithOptions(tabId, itemId, headers, runtime);
  }

  async deleteSearchItemWithOptions(tabId: string, itemId: string, headers: DeleteSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSearchItemResponse> {
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
    return $tea.cast<DeleteSearchItemResponse>(await this.doROARequest("DeleteSearchItem", "search_1.0", "HTTP", "DELETE", "AK", `/v1.0/search/tabs/${tabId}/items/${itemId}`, "none", req, runtime), new DeleteSearchItemResponse({}));
  }

  async insertSearchItem(tabId: string, request: InsertSearchItemRequest): Promise<InsertSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new InsertSearchItemHeaders({ });
    return await this.insertSearchItemWithOptions(tabId, request, headers, runtime);
  }

  async insertSearchItemWithOptions(tabId: string, request: InsertSearchItemRequest, headers: InsertSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<InsertSearchItemResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.itemId)) {
      body["itemId"] = request.itemId;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.footer)) {
      body["footer"] = request.footer;
    }

    if (!Util.isUnset(request.summary)) {
      body["summary"] = request.summary;
    }

    if (!Util.isUnset(request.icon)) {
      body["icon"] = request.icon;
    }

    if (!Util.isUnset(request.url)) {
      body["url"] = request.url;
    }

    if (!Util.isUnset(request.mobileUrl)) {
      body["mobileUrl"] = request.mobileUrl;
    }

    if (!Util.isUnset(request.pcUrl)) {
      body["pcUrl"] = request.pcUrl;
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
    return $tea.cast<InsertSearchItemResponse>(await this.doROARequest("InsertSearchItem", "search_1.0", "HTTP", "POST", "AK", `/v1.0/search/tabs/${tabId}/items`, "none", req, runtime), new InsertSearchItemResponse({}));
  }

  async batchInsertSearchItem(tabId: string, request: BatchInsertSearchItemRequest): Promise<BatchInsertSearchItemResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchInsertSearchItemHeaders({ });
    return await this.batchInsertSearchItemWithOptions(tabId, request, headers, runtime);
  }

  async batchInsertSearchItemWithOptions(tabId: string, request: BatchInsertSearchItemRequest, headers: BatchInsertSearchItemHeaders, runtime: $Util.RuntimeOptions): Promise<BatchInsertSearchItemResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.searchItemModels)) {
      body["searchItemModels"] = request.searchItemModels;
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
    return $tea.cast<BatchInsertSearchItemResponse>(await this.doROARequest("BatchInsertSearchItem", "search_1.0", "HTTP", "POST", "AK", `/v1.0/search/tabs/${tabId}/items/batch`, "none", req, runtime), new BatchInsertSearchItemResponse({}));
  }

  async createSearchTab(request: CreateSearchTabRequest): Promise<CreateSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateSearchTabHeaders({ });
    return await this.createSearchTabWithOptions(request, headers, runtime);
  }

  async createSearchTabWithOptions(request: CreateSearchTabRequest, headers: CreateSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<CreateSearchTabResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
    return $tea.cast<CreateSearchTabResponse>(await this.doROARequest("CreateSearchTab", "search_1.0", "HTTP", "POST", "AK", `/v1.0/search/tabs`, "json", req, runtime), new CreateSearchTabResponse({}));
  }

  async deleteSearchTab(tabId: string): Promise<DeleteSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteSearchTabHeaders({ });
    return await this.deleteSearchTabWithOptions(tabId, headers, runtime);
  }

  async deleteSearchTabWithOptions(tabId: string, headers: DeleteSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteSearchTabResponse> {
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
    return $tea.cast<DeleteSearchTabResponse>(await this.doROARequest("DeleteSearchTab", "search_1.0", "HTTP", "DELETE", "AK", `/v1.0/search/tabs/${tabId}`, "none", req, runtime), new DeleteSearchTabResponse({}));
  }

  async updateSearchTab(tabId: string, request: UpdateSearchTabRequest): Promise<UpdateSearchTabResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateSearchTabHeaders({ });
    return await this.updateSearchTabWithOptions(tabId, request, headers, runtime);
  }

  async updateSearchTabWithOptions(tabId: string, request: UpdateSearchTabRequest, headers: UpdateSearchTabHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateSearchTabResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.name)) {
      body["name"] = request.name;
    }

    if (!Util.isUnset(request.priority)) {
      body["priority"] = request.priority;
    }

    if (!Util.isUnset(request.status)) {
      body["status"] = request.status;
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
    return $tea.cast<UpdateSearchTabResponse>(await this.doROARequest("UpdateSearchTab", "search_1.0", "HTTP", "PUT", "AK", `/v1.0/search/tabs/${tabId}`, "none", req, runtime), new UpdateSearchTabResponse({}));
  }

  async getSearchItemsByKeyWord(tabId: string, request: GetSearchItemsByKeyWordRequest): Promise<GetSearchItemsByKeyWordResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSearchItemsByKeyWordHeaders({ });
    return await this.getSearchItemsByKeyWordWithOptions(tabId, request, headers, runtime);
  }

  async getSearchItemsByKeyWordWithOptions(tabId: string, request: GetSearchItemsByKeyWordRequest, headers: GetSearchItemsByKeyWordHeaders, runtime: $Util.RuntimeOptions): Promise<GetSearchItemsByKeyWordResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.keyWord)) {
      query["keyWord"] = request.keyWord;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
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
    return $tea.cast<GetSearchItemsByKeyWordResponse>(await this.doROARequest("GetSearchItemsByKeyWord", "search_1.0", "HTTP", "GET", "AK", `/v1.0/search/tabs/${tabId}/items`, "json", req, runtime), new GetSearchItemsByKeyWordResponse({}));
  }

}
