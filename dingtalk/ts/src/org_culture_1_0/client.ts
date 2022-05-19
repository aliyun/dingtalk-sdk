// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class ConsumeUserPointsHeaders extends $tea.Model {
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

export class ConsumeUserPointsRequest extends $tea.Model {
  amount?: number;
  outId?: string;
  remark?: string;
  usage?: string;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
      outId: 'outId',
      remark: 'remark',
      usage: 'usage',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
      outId: 'string',
      remark: 'string',
      usage: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsResponseBody extends $tea.Model {
  result?: ConsumeUserPointsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: ConsumeUserPointsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: ConsumeUserPointsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: ConsumeUserPointsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  expirationTime?: number;
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
      expirationTime: 'number',
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

export class QueryCorpPointsHeaders extends $tea.Model {
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

export class QueryCorpPointsRequest extends $tea.Model {
  optUserId?: string;
  static names(): { [key: string]: string } {
    return {
      optUserId: 'optUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      optUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpPointsResponseBody extends $tea.Model {
  result?: QueryCorpPointsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryCorpPointsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryCorpPointsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryCorpPointsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryCorpPointsResponseBody,
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

export class QueryUserPointsHeaders extends $tea.Model {
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

export class QueryUserPointsResponseBody extends $tea.Model {
  result?: QueryUserPointsResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryUserPointsResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryUserPointsResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryUserPointsResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryUserPointsResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class ConsumeUserPointsResponseBodyResult extends $tea.Model {
  amount?: number;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
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

export class QueryCorpPointsResponseBodyResult extends $tea.Model {
  amount?: number;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
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

export class QueryUserPointsResponseBodyResult extends $tea.Model {
  amount?: number;
  static names(): { [key: string]: string } {
    return {
      amount: 'amount',
    };
  }

  static types(): { [key: string]: any } {
    return {
      amount: 'number',
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


  async consumeUserPoints(userId: string, request: ConsumeUserPointsRequest): Promise<ConsumeUserPointsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new ConsumeUserPointsHeaders({ });
    return await this.consumeUserPointsWithOptions(userId, request, headers, runtime);
  }

  async consumeUserPointsWithOptions(userId: string, request: ConsumeUserPointsRequest, headers: ConsumeUserPointsHeaders, runtime: $Util.RuntimeOptions): Promise<ConsumeUserPointsResponse> {
    Util.validateModel(request);
    userId = OpenApiUtil.getEncodeParam(userId);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.amount)) {
      body["amount"] = request.amount;
    }

    if (!Util.isUnset(request.outId)) {
      body["outId"] = request.outId;
    }

    if (!Util.isUnset(request.remark)) {
      body["remark"] = request.remark;
    }

    if (!Util.isUnset(request.usage)) {
      body["usage"] = request.usage;
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
    return $tea.cast<ConsumeUserPointsResponse>(await this.doROARequest("ConsumeUserPoints", "orgCulture_1.0", "HTTP", "POST", "AK", `/v1.0/orgCulture/users/${userId}/points/deduct`, "json", req, runtime), new ConsumeUserPointsResponse({}));
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

  async queryCorpPoints(request: QueryCorpPointsRequest): Promise<QueryCorpPointsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryCorpPointsHeaders({ });
    return await this.queryCorpPointsWithOptions(request, headers, runtime);
  }

  async queryCorpPointsWithOptions(request: QueryCorpPointsRequest, headers: QueryCorpPointsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryCorpPointsResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.optUserId)) {
      query["optUserId"] = request.optUserId;
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
    return $tea.cast<QueryCorpPointsResponse>(await this.doROARequest("QueryCorpPoints", "orgCulture_1.0", "HTTP", "GET", "AK", `/v1.0/orgCulture/organizations/points`, "json", req, runtime), new QueryCorpPointsResponse({}));
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

  async queryUserPoints(userId: string): Promise<QueryUserPointsResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryUserPointsHeaders({ });
    return await this.queryUserPointsWithOptions(userId, headers, runtime);
  }

  async queryUserPointsWithOptions(userId: string, headers: QueryUserPointsHeaders, runtime: $Util.RuntimeOptions): Promise<QueryUserPointsResponse> {
    userId = OpenApiUtil.getEncodeParam(userId);
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<QueryUserPointsResponse>(await this.doROARequest("QueryUserPoints", "orgCulture_1.0", "HTTP", "GET", "AK", `/v1.0/orgCulture/users/${userId}/points`, "json", req, runtime), new QueryUserPointsResponse({}));
  }

}
