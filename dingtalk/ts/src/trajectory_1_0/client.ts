// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  needPositionInfo?: boolean;
  nextToken?: number;
  maxResults?: number;
  static names(): { [key: string]: string } {
    return {
      needPositionInfo: 'needPositionInfo',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
    };
  }

  static types(): { [key: string]: any } {
    return {
      needPositionInfo: 'boolean',
      nextToken: 'number',
      maxResults: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppActiveUsersResponseBody extends $tea.Model {
  hasMore?: boolean;
  totalCount?: number;
  list?: QueryAppActiveUsersResponseBodyList[];
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      totalCount: 'totalCount',
      list: 'list',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      totalCount: 'number',
      list: { 'type': 'array', 'itemType': QueryAppActiveUsersResponseBodyList },
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppActiveUsersResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryAppActiveUsersResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  dingIsvOrgId?: number;
  dingTokenGrantType?: number;
  dingClientId?: string;
  dingOrgId?: number;
  dingOauthAppId?: number;
  static names(): { [key: string]: string } {
    return {
      userIds: 'userIds',
      dingIsvOrgId: 'dingIsvOrgId',
      dingTokenGrantType: 'dingTokenGrantType',
      dingClientId: 'dingClientId',
      dingOrgId: 'dingOrgId',
      dingOauthAppId: 'dingOauthAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userIds: { 'type': 'array', 'itemType': 'string' },
      dingIsvOrgId: 'number',
      dingTokenGrantType: 'number',
      dingClientId: 'string',
      dingOrgId: 'number',
      dingOauthAppId: 'number',
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
  body: QueryCollectingTraceTaskResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  traceId?: string;
  nextToken?: number;
  maxResults?: number;
  startTime?: number;
  endTime?: number;
  staffId?: string;
  static names(): { [key: string]: string } {
    return {
      traceId: 'traceId',
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      startTime: 'startTime',
      endTime: 'endTime',
      staffId: 'staffId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      traceId: 'string',
      nextToken: 'number',
      maxResults: 'number',
      startTime: 'number',
      endTime: 'number',
      staffId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataResponseBody extends $tea.Model {
  list?: QueryPageTraceDataResponseBodyList[];
  hasMore?: boolean;
  nextToken?: number;
  static names(): { [key: string]: string } {
    return {
      list: 'list',
      hasMore: 'hasMore',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      list: { 'type': 'array', 'itemType': QueryPageTraceDataResponseBodyList },
      hasMore: 'boolean',
      nextToken: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryPageTraceDataResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryPageTraceDataResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryAppActiveUsersResponseBodyList extends $tea.Model {
  startTime?: number;
  appTraceId?: string;
  longitude?: number;
  latitude?: number;
  reportTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      startTime: 'startTime',
      appTraceId: 'appTraceId',
      longitude: 'longitude',
      latitude: 'latitude',
      reportTime: 'reportTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      startTime: 'number',
      appTraceId: 'string',
      longitude: 'number',
      latitude: 'number',
      reportTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCollectingTraceTaskResponseBodyList extends $tea.Model {
  appTraceId?: string;
  userId?: string;
  geoReportStatus?: number;
  geoReportPeriod?: number;
  geoCollectPeriod?: number;
  reportStartTime?: number;
  reportEndTime?: number;
  static names(): { [key: string]: string } {
    return {
      appTraceId: 'appTraceId',
      userId: 'userId',
      geoReportStatus: 'geoReportStatus',
      geoReportPeriod: 'geoReportPeriod',
      geoCollectPeriod: 'geoCollectPeriod',
      reportStartTime: 'reportStartTime',
      reportEndTime: 'reportEndTime',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appTraceId: 'string',
      userId: 'string',
      geoReportStatus: 'number',
      geoReportPeriod: 'number',
      geoCollectPeriod: 'number',
      reportStartTime: 'number',
      reportEndTime: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryPageTraceDataResponseBodyListCoordinates extends $tea.Model {
  longitude?: number;
  latitude?: number;
  static names(): { [key: string]: string } {
    return {
      longitude: 'longitude',
      latitude: 'latitude',
    };
  }

  static types(): { [key: string]: any } {
    return {
      longitude: 'number',
      latitude: 'number',
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

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async queryAppActiveUsers(request: QueryAppActiveUsersRequest): Promise<QueryAppActiveUsersResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryAppActiveUsersHeaders({ });
    return await this.queryAppActiveUsersWithOptions(request, headers, runtime);
  }

  async queryAppActiveUsersWithOptions(request: QueryAppActiveUsersRequest, headers: QueryAppActiveUsersHeaders, runtime: $Util.RuntimeOptions): Promise<QueryAppActiveUsersResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.needPositionInfo)) {
      query["needPositionInfo"] = request.needPositionInfo;
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
    return $tea.cast<QueryAppActiveUsersResponse>(await this.doROARequest("QueryAppActiveUsers", "trajectory_1.0", "HTTP", "GET", "AK", `/v1.0/trajectory/activeUsers`, "json", req, runtime), new QueryAppActiveUsersResponse({}));
  }

  async queryCollectingTraceTask(request: QueryCollectingTraceTaskRequest): Promise<QueryCollectingTraceTaskResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCollectingTraceTaskHeaders({ });
    return await this.queryCollectingTraceTaskWithOptions(request, headers, runtime);
  }

  async queryCollectingTraceTaskWithOptions(request: QueryCollectingTraceTaskRequest, headers: QueryCollectingTraceTaskHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCollectingTraceTaskResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userIds)) {
      body["userIds"] = request.userIds;
    }

    if (!Util.isUnset(request.dingIsvOrgId)) {
      body["dingIsvOrgId"] = request.dingIsvOrgId;
    }

    if (!Util.isUnset(request.dingTokenGrantType)) {
      body["dingTokenGrantType"] = request.dingTokenGrantType;
    }

    if (!Util.isUnset(request.dingClientId)) {
      body["dingClientId"] = request.dingClientId;
    }

    if (!Util.isUnset(request.dingOrgId)) {
      body["dingOrgId"] = request.dingOrgId;
    }

    if (!Util.isUnset(request.dingOauthAppId)) {
      body["dingOauthAppId"] = request.dingOauthAppId;
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
    return $tea.cast<QueryCollectingTraceTaskResponse>(await this.doROARequest("QueryCollectingTraceTask", "trajectory_1.0", "HTTP", "POST", "AK", `/v1.0/trajectory/currentTasks/queryByUserIds`, "json", req, runtime), new QueryCollectingTraceTaskResponse({}));
  }

  async queryPageTraceData(request: QueryPageTraceDataRequest): Promise<QueryPageTraceDataResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryPageTraceDataHeaders({ });
    return await this.queryPageTraceDataWithOptions(request, headers, runtime);
  }

  async queryPageTraceDataWithOptions(request: QueryPageTraceDataRequest, headers: QueryPageTraceDataHeaders, runtime: $Util.RuntimeOptions): Promise<QueryPageTraceDataResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.traceId)) {
      query["traceId"] = request.traceId;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.endTime)) {
      query["endTime"] = request.endTime;
    }

    if (!Util.isUnset(request.staffId)) {
      query["staffId"] = request.staffId;
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
    return $tea.cast<QueryPageTraceDataResponse>(await this.doROARequest("QueryPageTraceData", "trajectory_1.0", "HTTP", "GET", "AK", `/v1.0/trajectory/data`, "json", req, runtime), new QueryPageTraceDataResponse({}));
  }

}
