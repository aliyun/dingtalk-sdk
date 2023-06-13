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

export class CreateActivityHeaders extends $tea.Model {
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

export class CreateActivityRequest extends $tea.Model {
  detail?: CreateActivityRequestDetail;
  static names(): { [key: string]: string } {
    return {
      detail: 'detail',
    };
  }

  static types(): { [key: string]: any } {
    return {
      detail: CreateActivityRequestDetail,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActivityResponseBody extends $tea.Model {
  activityId?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActivityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateActivityResponseBody;
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
      body: CreateActivityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivityHeaders extends $tea.Model {
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

export class ListActivityRequest extends $tea.Model {
  maxResults?: number;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivityResponseBody extends $tea.Model {
  list?: ListActivityResponseBodyList[];
  maxResults?: string;
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': ListActivityResponseBodyList },
      maxResults: 'string',
      nextToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivityResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: ListActivityResponseBody;
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
      body: ListActivityResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActivityRequestDetailAddress extends $tea.Model {
  district?: string;
  lat?: string;
  lng?: string;
  name?: string;
  static names(): { [key: string]: string } {
    return {
      district: 'district',
      lat: 'lat',
      lng: 'lng',
      name: 'name',
    };
  }

  static types(): { [key: string]: any } {
    return {
      district: 'string',
      lat: 'string',
      lng: 'string',
      name: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateActivityRequestDetail extends $tea.Model {
  address?: CreateActivityRequestDetailAddress;
  bannerMediaId?: string;
  endTime?: number;
  foreignId?: string;
  industry?: string;
  roleName?: string;
  source?: string;
  startTime?: number;
  title?: string;
  type?: number;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      address: 'address',
      bannerMediaId: 'bannerMediaId',
      endTime: 'endTime',
      foreignId: 'foreignId',
      industry: 'industry',
      roleName: 'roleName',
      source: 'source',
      startTime: 'startTime',
      title: 'title',
      type: 'type',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      address: CreateActivityRequestDetailAddress,
      bannerMediaId: 'string',
      endTime: 'number',
      foreignId: 'string',
      industry: 'string',
      roleName: 'string',
      source: 'string',
      startTime: 'number',
      title: 'string',
      type: 'number',
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ListActivityResponseBodyList extends $tea.Model {
  activityId?: string;
  bannerMediaId?: string;
  endTime?: number;
  foreignId?: string;
  startTime?: number;
  status?: string;
  title?: string;
  type?: string;
  url?: string;
  static names(): { [key: string]: string } {
    return {
      activityId: 'activityId',
      bannerMediaId: 'bannerMediaId',
      endTime: 'endTime',
      foreignId: 'foreignId',
      startTime: 'startTime',
      status: 'status',
      title: 'title',
      type: 'type',
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activityId: 'string',
      bannerMediaId: 'string',
      endTime: 'number',
      foreignId: 'string',
      startTime: 'number',
      status: 'string',
      title: 'string',
      type: 'string',
      url: 'string',
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


  async createActivityWithOptions(request: CreateActivityRequest, headers: CreateActivityHeaders, runtime: $Util.RuntimeOptions): Promise<CreateActivityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.detail)) {
      body["detail"] = request.detail;
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
      action: "CreateActivity",
      version: "activity_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/activity/meta`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateActivityResponse>(await this.execute(params, req, runtime), new CreateActivityResponse({}));
  }

  async createActivity(request: CreateActivityRequest): Promise<CreateActivityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateActivityHeaders({ });
    return await this.createActivityWithOptions(request, headers, runtime);
  }

  async listActivityWithOptions(request: ListActivityRequest, headers: ListActivityHeaders, runtime: $Util.RuntimeOptions): Promise<ListActivityResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
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
      action: "ListActivity",
      version: "activity_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/activity/metaLists`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<ListActivityResponse>(await this.execute(params, req, runtime), new ListActivityResponse({}));
  }

  async listActivity(request: ListActivityRequest): Promise<ListActivityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ListActivityHeaders({ });
    return await this.listActivityWithOptions(request, headers, runtime);
  }

}
