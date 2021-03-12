// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class StartCloudFeedHeaders extends $tea.Model {
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

export class StartCloudFeedRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudFeedResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StartCloudFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StartCloudFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StartCloudFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudFeedHeaders extends $tea.Model {
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

export class StopCloudFeedRequest extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudFeedResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class StopCloudFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: StopCloudFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: StopCloudFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCloudFeedHeaders extends $tea.Model {
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

export class CreateCloudFeedRequest extends $tea.Model {
  title?: string;
  intro?: string;
  userId?: string;
  startTime?: number;
  coverUrl?: string;
  videoUrl?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'title',
      intro: 'intro',
      userId: 'userId',
      startTime: 'startTime',
      coverUrl: 'coverUrl',
      videoUrl: 'videoUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      intro: 'string',
      userId: 'string',
      startTime: 'number',
      coverUrl: 'string',
      videoUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCloudFeedResponseBody extends $tea.Model {
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateCloudFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateCloudFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateCloudFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddShareCidListHeaders extends $tea.Model {
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

export class AddShareCidListRequest extends $tea.Model {
  userId?: string;
  groupIds?: string[];
  groupIdType?: number;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      groupIds: 'groupIds',
      groupIdType: 'groupIdType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      groupIds: { 'type': 'array', 'itemType': 'string' },
      groupIdType: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddShareCidListResponseBody extends $tea.Model {
  hasShareSuccess?: boolean;
  shareSuccessGroupList?: string[];
  static names(): { [key: string]: string } {
    return {
      hasShareSuccess: 'hasShareSuccess',
      shareSuccessGroupList: 'shareSuccessGroupList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasShareSuccess: 'boolean',
      shareSuccessGroupList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class AddShareCidListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: AddShareCidListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: AddShareCidListResponseBody,
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


  async startCloudFeed(feedId: string, request: StartCloudFeedRequest): Promise<StartCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCloudFeedHeaders({ });
    return await this.startCloudFeedWithOptions(feedId, request, headers, runtime);
  }

  async startCloudFeedWithOptions(feedId: string, request: StartCloudFeedRequest, headers: StartCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<StartCloudFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<StartCloudFeedResponse>(await this.doROARequest("StartCloudFeed", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds/${feedId}/start`, "json", req, runtime), new StartCloudFeedResponse({}));
  }

  async stopCloudFeed(feedId: string, request: StopCloudFeedRequest): Promise<StopCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopCloudFeedHeaders({ });
    return await this.stopCloudFeedWithOptions(feedId, request, headers, runtime);
  }

  async stopCloudFeedWithOptions(feedId: string, request: StopCloudFeedRequest, headers: StopCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<StopCloudFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
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
    return $tea.cast<StopCloudFeedResponse>(await this.doROARequest("StopCloudFeed", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds/${feedId}/stop`, "json", req, runtime), new StopCloudFeedResponse({}));
  }

  async createCloudFeed(request: CreateCloudFeedRequest): Promise<CreateCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCloudFeedHeaders({ });
    return await this.createCloudFeedWithOptions(request, headers, runtime);
  }

  async createCloudFeedWithOptions(request: CreateCloudFeedRequest, headers: CreateCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCloudFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.intro)) {
      body["intro"] = request.intro;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.coverUrl)) {
      body["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.videoUrl)) {
      body["videoUrl"] = request.videoUrl;
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
    return $tea.cast<CreateCloudFeedResponse>(await this.doROARequest("CreateCloudFeed", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds`, "json", req, runtime), new CreateCloudFeedResponse({}));
  }

  async addShareCidList(feedId: string, request: AddShareCidListRequest): Promise<AddShareCidListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddShareCidListHeaders({ });
    return await this.addShareCidListWithOptions(feedId, request, headers, runtime);
  }

  async addShareCidListWithOptions(feedId: string, request: AddShareCidListRequest, headers: AddShareCidListHeaders, runtime: $Util.RuntimeOptions): Promise<AddShareCidListResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.groupIds)) {
      body["groupIds"] = request.groupIds;
    }

    if (!Util.isUnset(request.groupIdType)) {
      body["groupIdType"] = request.groupIdType;
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
    return $tea.cast<AddShareCidListResponse>(await this.doROARequest("AddShareCidList", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds/${feedId}/share`, "json", req, runtime), new AddShareCidListResponse({}));
  }

}
