// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GrantHonorHeaders extends $tea.Model {
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

export class GrantHonorRequest extends $tea.Model {
  expirationTime?: string;
  grantReason?: string;
  granterName?: string;
  noticeAnnouncer?: boolean;
  noticeSingle?: boolean;
  receiverUserIds?: string[];
  senderUserId?: string;
  static names(): { [key: string]: string } {
    return {
      expirationTime: 'expirationTime',
      grantReason: 'grantReason',
      granterName: 'granterName',
      noticeAnnouncer: 'noticeAnnouncer',
      noticeSingle: 'noticeSingle',
      receiverUserIds: 'receiverUserIds',
      senderUserId: 'senderUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationTime: 'string',
      grantReason: 'string',
      granterName: 'string',
      noticeAnnouncer: 'boolean',
      noticeSingle: 'boolean',
      receiverUserIds: { 'type': 'array', 'itemType': 'string' },
      senderUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorResponseBody extends $tea.Model {
  result?: GrantHonorResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GrantHonorResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GrantHonorResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GrantHonorResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsHeaders extends $tea.Model {
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

export class QueryOrgHonorsRequest extends $tea.Model {
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

export class QueryOrgHonorsResponseBody extends $tea.Model {
  result?: QueryOrgHonorsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryOrgHonorsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryOrgHonorsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryOrgHonorsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsHeaders extends $tea.Model {
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

export class QueryUserHonorsRequest extends $tea.Model {
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

export class QueryUserHonorsResponseBody extends $tea.Model {
  result?: QueryUserHonorsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryUserHonorsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserHonorsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserHonorsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GrantHonorResponseBodyResult extends $tea.Model {
  failedUserIds?: string[];
  successUserIds?: string[];
  static names(): { [key: string]: string } {
    return {
      failedUserIds: 'failedUserIds',
      successUserIds: 'successUserIds',
    };
  }

  static types(): { [key: string]: any } {
    return {
      failedUserIds: { 'type': 'array', 'itemType': 'string' },
      successUserIds: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsResponseBodyResultOpenHonors extends $tea.Model {
  honorDesc?: string;
  honorId?: number;
  honorImgUrl?: string;
  honorName?: string;
  honorPendantImgUrl?: string;
  static names(): { [key: string]: string } {
    return {
      honorDesc: 'honorDesc',
      honorId: 'honorId',
      honorImgUrl: 'honorImgUrl',
      honorName: 'honorName',
      honorPendantImgUrl: 'honorPendantImgUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      honorDesc: 'string',
      honorId: 'number',
      honorImgUrl: 'string',
      honorName: 'string',
      honorPendantImgUrl: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryOrgHonorsResponseBodyResult extends $tea.Model {
  nextToken?: string;
  openHonors?: QueryOrgHonorsResponseBodyResultOpenHonors[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      openHonors: 'openHonors',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      openHonors: { 'type': 'array', 'itemType': QueryOrgHonorsResponseBodyResultOpenHonors },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponseBodyResultHonorsGrantHistory extends $tea.Model {
  grantTime?: number;
  senderUserid?: string;
  static names(): { [key: string]: string } {
    return {
      grantTime: 'grantTime',
      senderUserid: 'senderUserid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      grantTime: 'number',
      senderUserid: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponseBodyResultHonors extends $tea.Model {
  expirationTime?: number;
  grantHistory?: QueryUserHonorsResponseBodyResultHonorsGrantHistory[];
  honorDesc?: string;
  honorId?: string;
  honorName?: string;
  static names(): { [key: string]: string } {
    return {
      expirationTime: 'expirationTime',
      grantHistory: 'grantHistory',
      honorDesc: 'honorDesc',
      honorId: 'honorId',
      honorName: 'honorName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expirationTime: 'number',
      grantHistory: { 'type': 'array', 'itemType': QueryUserHonorsResponseBodyResultHonorsGrantHistory },
      honorDesc: 'string',
      honorId: 'string',
      honorName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserHonorsResponseBodyResult extends $tea.Model {
  honors?: QueryUserHonorsResponseBodyResultHonors[];
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      honors: 'honors',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      honors: { 'type': 'array', 'itemType': QueryUserHonorsResponseBodyResultHonors },
      nextToken: 'string',
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


  async grantHonor(honorId: string, request: GrantHonorRequest): Promise<GrantHonorResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GrantHonorHeaders({ });
    return await this.grantHonorWithOptions(honorId, request, headers, runtime);
  }

  async grantHonorWithOptions(honorId: string, request: GrantHonorRequest, headers: GrantHonorHeaders, runtime: $Util.RuntimeOptions): Promise<GrantHonorResponse> {
    Util.validateModel(request);
    honorId = OpenApiUtil.getEncodeParam(honorId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.expirationTime)) {
      body["expirationTime"] = request.expirationTime;
    }

    if (!Util.isUnset(request.grantReason)) {
      body["grantReason"] = request.grantReason;
    }

    if (!Util.isUnset(request.granterName)) {
      body["granterName"] = request.granterName;
    }

    if (!Util.isUnset(request.noticeAnnouncer)) {
      body["noticeAnnouncer"] = request.noticeAnnouncer;
    }

    if (!Util.isUnset(request.noticeSingle)) {
      body["noticeSingle"] = request.noticeSingle;
    }

    if (!Util.isUnset(request.receiverUserIds)) {
      body["receiverUserIds"] = request.receiverUserIds;
    }

    if (!Util.isUnset(request.senderUserId)) {
      body["senderUserId"] = request.senderUserId;
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
    return $tea.cast<GrantHonorResponse>(await this.doROARequest("GrantHonor", "orgCulture_1.0", "HTTP", "POST", "AK", `/v1.0/orgCulture/honors/${honorId}/grant`, "json", req, runtime), new GrantHonorResponse({}));
  }

  async queryOrgHonors(request: QueryOrgHonorsRequest): Promise<QueryOrgHonorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryOrgHonorsHeaders({ });
    return await this.queryOrgHonorsWithOptions(request, headers, runtime);
  }

  async queryOrgHonorsWithOptions(request: QueryOrgHonorsRequest, headers: QueryOrgHonorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryOrgHonorsResponse> {
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
    return $tea.cast<QueryOrgHonorsResponse>(await this.doROARequest("QueryOrgHonors", "orgCulture_1.0", "HTTP", "GET", "AK", `/v1.0/orgCulture/organizations/honors`, "json", req, runtime), new QueryOrgHonorsResponse({}));
  }

  async queryUserHonors(userId: string, request: QueryUserHonorsRequest): Promise<QueryUserHonorsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserHonorsHeaders({ });
    return await this.queryUserHonorsWithOptions(userId, request, headers, runtime);
  }

  async queryUserHonorsWithOptions(userId: string, request: QueryUserHonorsRequest, headers: QueryUserHonorsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserHonorsResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
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
    return $tea.cast<QueryUserHonorsResponse>(await this.doROARequest("QueryUserHonors", "orgCulture_1.0", "HTTP", "GET", "AK", `/v1.0/orgCulture/honors/users/${userId}`, "json", req, runtime), new QueryUserHonorsResponse({}));
  }

}
