// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreateVideoConferenceHeaders extends $tea.Model {
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

export class CreateVideoConferenceRequest extends $tea.Model {
  userId?: string;
  confTitle?: string;
  inviteUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      confTitle: 'confTitle',
      inviteUserIds: 'inviteUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      confTitle: 'string',
      inviteUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceResponseBody extends $tea.Model {
  conferenceId?: string;
  conferencePassword?: string;
  hostPassword?: string;
  externalLinkUrl?: string;
  phoneNumbers?: string[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      conferencePassword: 'conferencePassword',
      hostPassword: 'hostPassword',
      externalLinkUrl: 'externalLinkUrl',
      phoneNumbers: 'phoneNumbers',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      conferencePassword: 'string',
      hostPassword: 'string',
      externalLinkUrl: 'string',
      phoneNumbers: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateVideoConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateVideoConferenceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateVideoConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceExtInfoHeaders extends $tea.Model {
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

export class UpdateVideoConferenceExtInfoResponseBody extends $tea.Model {
  case?: string;
  code?: string;
  static names(): { [key: string]: string } {
    return {
      case: 'case',
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      case: 'string',
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateVideoConferenceExtInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateVideoConferenceExtInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateVideoConferenceExtInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceHeaders extends $tea.Model {
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

export class CloseVideoConferenceRequest extends $tea.Model {
  unionId?: string;
  static names(): { [key: string]: string } {
    return {
      unionId: 'unionId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      unionId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceResponseBody extends $tea.Model {
  code?: number;
  cause?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
      cause: 'cause',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'number',
      cause: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CloseVideoConferenceResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CloseVideoConferenceResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CloseVideoConferenceResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchHeaders extends $tea.Model {
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

export class QueryConferenceInfoBatchRequest extends $tea.Model {
  conferenceIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      conferenceIdList: 'conferenceIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBody extends $tea.Model {
  infos?: QueryConferenceInfoBatchResponseBodyInfos[];
  static names(): { [key: string]: string } {
    return {
      infos: 'infos',
    };
  }

  static types(): { [key: string]: any } {
    return {
      infos: { 'type': 'array', 'itemType': QueryConferenceInfoBatchResponseBodyInfos },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryConferenceInfoBatchResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryConferenceInfoBatchResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfosUserList extends $tea.Model {
  userId?: string;
  nick?: string;
  attendStatus?: number;
  cameraStatus?: number;
  micStatus?: number;
  rejectDescription?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
      nick: 'nick',
      attendStatus: 'attendStatus',
      cameraStatus: 'cameraStatus',
      micStatus: 'micStatus',
      rejectDescription: 'rejectDescription',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
      nick: 'string',
      attendStatus: 'number',
      cameraStatus: 'number',
      micStatus: 'number',
      rejectDescription: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryConferenceInfoBatchResponseBodyInfos extends $tea.Model {
  conferenceId?: string;
  title?: string;
  startTime?: number;
  status?: number;
  mediaStatus?: number;
  userList?: QueryConferenceInfoBatchResponseBodyInfosUserList[];
  static names(): { [key: string]: string } {
    return {
      conferenceId: 'conferenceId',
      title: 'title',
      startTime: 'startTime',
      status: 'status',
      mediaStatus: 'mediaStatus',
      userList: 'userList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conferenceId: 'string',
      title: 'string',
      startTime: 'number',
      status: 'number',
      mediaStatus: 'number',
      userList: { 'type': 'array', 'itemType': QueryConferenceInfoBatchResponseBodyInfosUserList },
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


  async createVideoConference(request: CreateVideoConferenceRequest): Promise<CreateVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateVideoConferenceHeaders({ });
    return await this.createVideoConferenceWithOptions(request, headers, runtime);
  }

  async createVideoConferenceWithOptions(request: CreateVideoConferenceRequest, headers: CreateVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CreateVideoConferenceResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      body["userId"] = request.userId;
    }

    if (!Util.isUnset(request.confTitle)) {
      body["confTitle"] = request.confTitle;
    }

    if (!Util.isUnset(request.inviteUserIds)) {
      body["inviteUserIds"] = request.inviteUserIds;
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
    return $tea.cast<CreateVideoConferenceResponse>(await this.doROARequest("CreateVideoConference", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences`, "json", req, runtime), new CreateVideoConferenceResponse({}));
  }

  async updateVideoConferenceExtInfo(conferenceId: string): Promise<UpdateVideoConferenceExtInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateVideoConferenceExtInfoHeaders({ });
    return await this.updateVideoConferenceExtInfoWithOptions(conferenceId, headers, runtime);
  }

  async updateVideoConferenceExtInfoWithOptions(conferenceId: string, headers: UpdateVideoConferenceExtInfoHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateVideoConferenceExtInfoResponse> {
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
    return $tea.cast<UpdateVideoConferenceExtInfoResponse>(await this.doROARequest("UpdateVideoConferenceExtInfo", "conference_1.0", "HTTP", "PUT", "AK", `/v1.0/conference/videoConferences/${conferenceId}/extInfo`, "json", req, runtime), new UpdateVideoConferenceExtInfoResponse({}));
  }

  async closeVideoConference(conferenceId: string, request: CloseVideoConferenceRequest): Promise<CloseVideoConferenceResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CloseVideoConferenceHeaders({ });
    return await this.closeVideoConferenceWithOptions(conferenceId, request, headers, runtime);
  }

  async closeVideoConferenceWithOptions(conferenceId: string, request: CloseVideoConferenceRequest, headers: CloseVideoConferenceHeaders, runtime: $Util.RuntimeOptions): Promise<CloseVideoConferenceResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.unionId)) {
      query["unionId"] = request.unionId;
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
    return $tea.cast<CloseVideoConferenceResponse>(await this.doROARequest("CloseVideoConference", "conference_1.0", "HTTP", "DELETE", "AK", `/v1.0/conference/videoConferences/${conferenceId}`, "json", req, runtime), new CloseVideoConferenceResponse({}));
  }

  async queryConferenceInfoBatch(request: QueryConferenceInfoBatchRequest): Promise<QueryConferenceInfoBatchResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryConferenceInfoBatchHeaders({ });
    return await this.queryConferenceInfoBatchWithOptions(request, headers, runtime);
  }

  async queryConferenceInfoBatchWithOptions(request: QueryConferenceInfoBatchRequest, headers: QueryConferenceInfoBatchHeaders, runtime: $Util.RuntimeOptions): Promise<QueryConferenceInfoBatchResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.conferenceIdList)) {
      body["conferenceIdList"] = request.conferenceIdList;
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
    return $tea.cast<QueryConferenceInfoBatchResponse>(await this.doROARequest("QueryConferenceInfoBatch", "conference_1.0", "HTTP", "POST", "AK", `/v1.0/conference/videoConferences/query`, "json", req, runtime), new QueryConferenceInfoBatchResponse({}));
  }

}
