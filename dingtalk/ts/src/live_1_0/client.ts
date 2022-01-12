// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  groupIdType?: number;
  groupIds?: string[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      groupIdType: 'groupIdType',
      groupIds: 'groupIds',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      groupIdType: 'number',
      groupIds: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
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
  coverUrl?: string;
  intro?: string;
  startTime?: number;
  title?: string;
  userId?: string;
  videoUrl?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      intro: 'intro',
      startTime: 'startTime',
      title: 'title',
      userId: 'userId',
      videoUrl: 'videoUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      intro: 'string',
      startTime: 'number',
      title: 'string',
      userId: 'string',
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

export class DeleteLiveFeedHeaders extends $tea.Model {
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

export class DeleteLiveFeedRequest extends $tea.Model {
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

export class DeleteLiveFeedResponseBody extends $tea.Model {
  hasDelete?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasDelete: 'hasDelete',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasDelete: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class DeleteLiveFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: DeleteLiveFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: DeleteLiveFeedResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditFeedReplayHeaders extends $tea.Model {
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

export class EditFeedReplayRequest extends $tea.Model {
  editEndTime?: number;
  editStartTime?: number;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      editEndTime: 'editEndTime',
      editStartTime: 'editStartTime',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      editEndTime: 'number',
      editStartTime: 'number',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class EditFeedReplayResponseBody extends $tea.Model {
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

export class EditFeedReplayResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: EditFeedReplayResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: EditFeedReplayResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyFeedWhiteListHeaders extends $tea.Model {
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

export class ModifyFeedWhiteListRequest extends $tea.Model {
  action?: number;
  modifyUserList?: string[];
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      modifyUserList: 'modifyUserList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'number',
      modifyUserList: { 'type': 'array', 'itemType': 'string' },
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyFeedWhiteListShrinkRequest extends $tea.Model {
  action?: number;
  modifyUserListShrink?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      action: 'action',
      modifyUserListShrink: 'modifyUserList',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      action: 'number',
      modifyUserListShrink: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ModifyFeedWhiteListResponseBody extends $tea.Model {
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

export class ModifyFeedWhiteListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ModifyFeedWhiteListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ModifyFeedWhiteListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryFeedWhiteListHeaders extends $tea.Model {
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

export class QueryFeedWhiteListRequest extends $tea.Model {
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

export class QueryFeedWhiteListResponseBody extends $tea.Model {
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

export class QueryFeedWhiteListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryFeedWhiteListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryFeedWhiteListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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

export class UpdateLiveFeedHeaders extends $tea.Model {
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

export class UpdateLiveFeedRequest extends $tea.Model {
  coverUrl?: string;
  introduction?: string;
  startTime?: number;
  title?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      coverUrl: 'coverUrl',
      introduction: 'introduction',
      startTime: 'startTime',
      title: 'title',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      coverUrl: 'string',
      introduction: 'string',
      startTime: 'number',
      title: 'string',
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveFeedResponseBody extends $tea.Model {
  hasUpdate?: boolean;
  static names(): { [key: string]: string } {
    return {
      hasUpdate: 'hasUpdate',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasUpdate: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateLiveFeedResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateLiveFeedResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateLiveFeedResponseBody,
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


  async addShareCidList(feedId: string, request: AddShareCidListRequest): Promise<AddShareCidListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new AddShareCidListHeaders({ });
    return await this.addShareCidListWithOptions(feedId, request, headers, runtime);
  }

  async addShareCidListWithOptions(feedId: string, request: AddShareCidListRequest, headers: AddShareCidListHeaders, runtime: $Util.RuntimeOptions): Promise<AddShareCidListResponse> {
    Util.validateModel(request);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.groupIdType)) {
      body["groupIdType"] = request.groupIdType;
    }

    if (!Util.isUnset(request.groupIds)) {
      body["groupIds"] = request.groupIds;
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
    return $tea.cast<AddShareCidListResponse>(await this.doROARequest("AddShareCidList", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds/${feedId}/share`, "json", req, runtime), new AddShareCidListResponse({}));
  }

  async createCloudFeed(request: CreateCloudFeedRequest): Promise<CreateCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateCloudFeedHeaders({ });
    return await this.createCloudFeedWithOptions(request, headers, runtime);
  }

  async createCloudFeedWithOptions(request: CreateCloudFeedRequest, headers: CreateCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<CreateCloudFeedResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coverUrl)) {
      body["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.intro)) {
      body["intro"] = request.intro;
    }

    if (!Util.isUnset(request.startTime)) {
      body["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      body["title"] = request.title;
    }

    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.videoUrl)) {
      body["videoUrl"] = request.videoUrl;
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
    return $tea.cast<CreateCloudFeedResponse>(await this.doROARequest("CreateCloudFeed", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds`, "json", req, runtime), new CreateCloudFeedResponse({}));
  }

  async deleteLiveFeed(feedId: string, request: DeleteLiveFeedRequest): Promise<DeleteLiveFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new DeleteLiveFeedHeaders({ });
    return await this.deleteLiveFeedWithOptions(feedId, request, headers, runtime);
  }

  async deleteLiveFeedWithOptions(feedId: string, request: DeleteLiveFeedRequest, headers: DeleteLiveFeedHeaders, runtime: $Util.RuntimeOptions): Promise<DeleteLiveFeedResponse> {
    Util.validateModel(request);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<DeleteLiveFeedResponse>(await this.doROARequest("DeleteLiveFeed", "live_1.0", "HTTP", "DELETE", "AK", `/v1.0/live/openFeeds/${feedId}`, "json", req, runtime), new DeleteLiveFeedResponse({}));
  }

  async editFeedReplay(feedId: string, request: EditFeedReplayRequest): Promise<EditFeedReplayResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new EditFeedReplayHeaders({ });
    return await this.editFeedReplayWithOptions(feedId, request, headers, runtime);
  }

  async editFeedReplayWithOptions(feedId: string, request: EditFeedReplayRequest, headers: EditFeedReplayHeaders, runtime: $Util.RuntimeOptions): Promise<EditFeedReplayResponse> {
    Util.validateModel(request);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.editEndTime)) {
      body["editEndTime"] = request.editEndTime;
    }

    if (!Util.isUnset(request.editStartTime)) {
      body["editStartTime"] = request.editStartTime;
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
    return $tea.cast<EditFeedReplayResponse>(await this.doROARequest("EditFeedReplay", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/openFeeds/${feedId}/cutReplay`, "json", req, runtime), new EditFeedReplayResponse({}));
  }

  async modifyFeedWhiteList(feedId: string, request: ModifyFeedWhiteListRequest): Promise<ModifyFeedWhiteListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ModifyFeedWhiteListHeaders({ });
    return await this.modifyFeedWhiteListWithOptions(feedId, request, headers, runtime);
  }

  async modifyFeedWhiteListWithOptions(feedId: string, tmpReq: ModifyFeedWhiteListRequest, headers: ModifyFeedWhiteListHeaders, runtime: $Util.RuntimeOptions): Promise<ModifyFeedWhiteListResponse> {
    Util.validateModel(tmpReq);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let request = new ModifyFeedWhiteListShrinkRequest({ });
    OpenApiUtil.convert(tmpReq, request);
    if (!Util.isUnset(tmpReq.modifyUserList)) {
      request.modifyUserListShrink = OpenApiUtil.arrayToStringWithSpecifiedStyle(tmpReq.modifyUserList, "modifyUserList", "json");
    }

    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.action)) {
      query["action"] = request.action;
    }

    if (!Util.isUnset(request.modifyUserListShrink)) {
      query["modifyUserList"] = request.modifyUserListShrink;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<ModifyFeedWhiteListResponse>(await this.doROARequest("ModifyFeedWhiteList", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/openFeeds/${feedId}/whiteList`, "json", req, runtime), new ModifyFeedWhiteListResponse({}));
  }

  async queryFeedWhiteList(feedId: string, request: QueryFeedWhiteListRequest): Promise<QueryFeedWhiteListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryFeedWhiteListHeaders({ });
    return await this.queryFeedWhiteListWithOptions(feedId, request, headers, runtime);
  }

  async queryFeedWhiteListWithOptions(feedId: string, request: QueryFeedWhiteListRequest, headers: QueryFeedWhiteListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryFeedWhiteListResponse> {
    Util.validateModel(request);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<QueryFeedWhiteListResponse>(await this.doROARequest("QueryFeedWhiteList", "live_1.0", "HTTP", "GET", "AK", `/v1.0/live/openFeeds/${feedId}/whiteList`, "json", req, runtime), new QueryFeedWhiteListResponse({}));
  }

  async startCloudFeed(feedId: string, request: StartCloudFeedRequest): Promise<StartCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StartCloudFeedHeaders({ });
    return await this.startCloudFeedWithOptions(feedId, request, headers, runtime);
  }

  async startCloudFeedWithOptions(feedId: string, request: StartCloudFeedRequest, headers: StartCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<StartCloudFeedResponse> {
    Util.validateModel(request);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let body : {[key: string ]: any} = { };
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
    return $tea.cast<StartCloudFeedResponse>(await this.doROARequest("StartCloudFeed", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds/${feedId}/start`, "json", req, runtime), new StartCloudFeedResponse({}));
  }

  async stopCloudFeed(feedId: string, request: StopCloudFeedRequest): Promise<StopCloudFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new StopCloudFeedHeaders({ });
    return await this.stopCloudFeedWithOptions(feedId, request, headers, runtime);
  }

  async stopCloudFeedWithOptions(feedId: string, request: StopCloudFeedRequest, headers: StopCloudFeedHeaders, runtime: $Util.RuntimeOptions): Promise<StopCloudFeedResponse> {
    Util.validateModel(request);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let body : {[key: string ]: any} = { };
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
    return $tea.cast<StopCloudFeedResponse>(await this.doROARequest("StopCloudFeed", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/cloudFeeds/${feedId}/stop`, "json", req, runtime), new StopCloudFeedResponse({}));
  }

  async updateLiveFeed(feedId: string, request: UpdateLiveFeedRequest): Promise<UpdateLiveFeedResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateLiveFeedHeaders({ });
    return await this.updateLiveFeedWithOptions(feedId, request, headers, runtime);
  }

  async updateLiveFeedWithOptions(feedId: string, request: UpdateLiveFeedRequest, headers: UpdateLiveFeedHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateLiveFeedResponse> {
    Util.validateModel(request);
    feedId = OpenApiUtil.getEncodeParam(feedId);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.coverUrl)) {
      query["coverUrl"] = request.coverUrl;
    }

    if (!Util.isUnset(request.introduction)) {
      query["introduction"] = request.introduction;
    }

    if (!Util.isUnset(request.startTime)) {
      query["startTime"] = request.startTime;
    }

    if (!Util.isUnset(request.title)) {
      query["title"] = request.title;
    }

    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<UpdateLiveFeedResponse>(await this.doROARequest("UpdateLiveFeed", "live_1.0", "HTTP", "POST", "AK", `/v1.0/live/openFeeds/${feedId}`, "json", req, runtime), new UpdateLiveFeedResponse({}));
  }

}
