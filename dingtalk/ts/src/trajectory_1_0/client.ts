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

export class QueryAppActiveUsersHeaders extends $tea.Model {
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

export class QueryAppActiveUsersRequest extends $tea.Model {
  maxResults?: number;
  needPositionInfo?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      maxResults: 'maxResults',
      needPositionInfo: 'needPositionInfo',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      maxResults: 'number',
      needPositionInfo: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppActiveUsersResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryAppActiveUsersResponseBodyList[];
  nextToken?: number;
  totalCount?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
      totalCount: 'totalCount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryAppActiveUsersResponseBodyList },
      nextToken: 'number',
      totalCount: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppActiveUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryAppActiveUsersResponseBody;
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
      body: QueryAppActiveUsersResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCollectingTraceTaskHeaders extends $tea.Model {
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

export class QueryCollectingTraceTaskRequest extends $tea.Model {
  userIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCollectingTraceTaskResponseBody extends $tea.Model {
  list?: QueryCollectingTraceTaskResponseBodyList[];
  static names(): { [key: string]: string } {
    return {
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': QueryCollectingTraceTaskResponseBodyList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCollectingTraceTaskResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryCollectingTraceTaskResponseBody;
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
      body: QueryCollectingTraceTaskResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataHeaders extends $tea.Model {
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

export class QueryPageTraceDataRequest extends $tea.Model {
  endTime?: number;
  maxResults?: number;
  nextToken?: number;
  staffId?: string;
  startTime?: number;
  traceId?: string;
  static names(): { [key: string]: string } {
    return {
      endTime: 'endTime',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      staffId: 'staffId',
      startTime: 'startTime',
      traceId: 'traceId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTime: 'number',
      maxResults: 'number',
      nextToken: 'number',
      staffId: 'string',
      startTime: 'number',
      traceId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataResponseBody extends $tea.Model {
  hasMore?: boolean;
  list?: QueryPageTraceDataResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryPageTraceDataResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryPageTraceDataResponseBody;
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
      body: QueryPageTraceDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppActiveUsersResponseBodyList extends $tea.Model {
  appTraceId?: string;
  latitude?: number;
  longitude?: number;
  reportTime?: number;
  startTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appTraceId: 'appTraceId',
      latitude: 'latitude',
      longitude: 'longitude',
      reportTime: 'reportTime',
      startTime: 'startTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTraceId: 'string',
      latitude: 'number',
      longitude: 'number',
      reportTime: 'number',
      startTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCollectingTraceTaskResponseBodyList extends $tea.Model {
  appTraceId?: string;
  geoCollectPeriod?: number;
  geoReportPeriod?: number;
  geoReportStatus?: number;
  reportEndTime?: number;
  reportStartTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      appTraceId: 'appTraceId',
      geoCollectPeriod: 'geoCollectPeriod',
      geoReportPeriod: 'geoReportPeriod',
      geoReportStatus: 'geoReportStatus',
      reportEndTime: 'reportEndTime',
      reportStartTime: 'reportStartTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTraceId: 'string',
      geoCollectPeriod: 'number',
      geoReportPeriod: 'number',
      geoReportStatus: 'number',
      reportEndTime: 'number',
      reportStartTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataResponseBodyListCoordinates extends $tea.Model {
  latitude?: number;
  longitude?: number;
  static names(): { [key: string]: string } {
    return {
      latitude: 'latitude',
      longitude: 'longitude',
    };
  }

  static types(): { [key: string]: any } {
    return {
      latitude: 'number',
      longitude: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataResponseBodyList extends $tea.Model {
  coordinates?: QueryPageTraceDataResponseBodyListCoordinates;
  gmtLocation?: number;
  gmtUpload?: number;
  static names(): { [key: string]: string } {
    return {
      coordinates: 'coordinates',
      gmtLocation: 'gmtLocation',
      gmtUpload: 'gmtUpload',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coordinates: QueryPageTraceDataResponseBodyListCoordinates,
      gmtLocation: 'number',
      gmtUpload: 'number',
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


  async queryAppActiveUsersWithOptions(request: QueryAppActiveUsersRequest, headers: QueryAppActiveUsersHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAppActiveUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.needPositionInfo)) {
      query["needPositionInfo"] = request.needPositionInfo;
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
      action: "QueryAppActiveUsers",
      version: "trajectory_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trajectory/activeUsers`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryAppActiveUsersResponse>(await this.execute(params, req, runtime), new QueryAppActiveUsersResponse({}));
  }

  async queryAppActiveUsers(request: QueryAppActiveUsersRequest): Promise<QueryAppActiveUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAppActiveUsersHeaders({ });
    return await this.queryAppActiveUsersWithOptions(request, headers, runtime);
  }

  async queryCollectingTraceTaskWithOptions(request: QueryCollectingTraceTaskRequest, headers: QueryCollectingTraceTaskHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCollectingTraceTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
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
      action: "QueryCollectingTraceTask",
      version: "trajectory_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trajectory/currentTasks/queryByUserIds`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryCollectingTraceTaskResponse>(await this.execute(params, req, runtime), new QueryCollectingTraceTaskResponse({}));
  }

  async queryCollectingTraceTask(request: QueryCollectingTraceTaskRequest): Promise<QueryCollectingTraceTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCollectingTraceTaskHeaders({ });
    return await this.queryCollectingTraceTaskWithOptions(request, headers, runtime);
  }

  async queryPageTraceDataWithOptions(request: QueryPageTraceDataRequest, headers: QueryPageTraceDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPageTraceDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.staffId)) {
      query["staffId"] = request.staffId;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.traceId)) {
      query["traceId"] = request.traceId;
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
      action: "QueryPageTraceData",
      version: "trajectory_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trajectory/data`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryPageTraceDataResponse>(await this.execute(params, req, runtime), new QueryPageTraceDataResponse({}));
  }

  async queryPageTraceData(request: QueryPageTraceDataRequest): Promise<QueryPageTraceDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPageTraceDataHeaders({ });
    return await this.queryPageTraceDataWithOptions(request, headers, runtime);
  }

}
