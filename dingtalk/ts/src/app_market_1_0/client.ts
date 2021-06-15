// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class UserTaskReportHeaders extends $tea.Model {
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

export class UserTaskReportRequest extends $tea.Model {
  dingCorpId?: string;
  taskTag?: string;
  operateDate?: string;
  userid?: string;
  bizNo?: string;
  static names(): { [key: string]: string } {
    return {
      dingCorpId: 'dingCorpId',
      taskTag: 'taskTag',
      operateDate: 'operateDate',
      userid: 'userid',
      bizNo: 'bizNo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      dingCorpId: 'string',
      taskTag: 'string',
      operateDate: 'string',
      userid: 'string',
      bizNo: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UserTaskReportResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: boolean;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppGoodsServiceConversationHeaders extends $tea.Model {
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

export class CreateAppGoodsServiceConversationRequest extends $tea.Model {
  orderId?: number;
  isvUserId?: string;
  static names(): { [key: string]: string } {
    return {
      orderId: 'orderId',
      isvUserId: 'isvUserId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderId: 'number',
      isvUserId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppGoodsServiceConversationResponseBody extends $tea.Model {
  conversationName?: string;
  newConversation?: boolean;
  static names(): { [key: string]: string } {
    return {
      conversationName: 'conversationName',
      newConversation: 'newConversation',
    };
  }

  static types(): { [key: string]: any } {
    return {
      conversationName: 'string',
      newConversation: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateAppGoodsServiceConversationResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateAppGoodsServiceConversationResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateAppGoodsServiceConversationResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalExperienceInfoHeaders extends $tea.Model {
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

export class GetPersonalExperienceInfoRequest extends $tea.Model {
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

export class GetPersonalExperienceInfoResponseBody extends $tea.Model {
  result?: GetPersonalExperienceInfoResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: GetPersonalExperienceInfoResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalExperienceInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetPersonalExperienceInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetPersonalExperienceInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalExperienceInfoResponseBodyResult extends $tea.Model {
  mainCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      mainCorpId: 'mainCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      mainCorpId: 'string',
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


  async userTaskReport(request: UserTaskReportRequest): Promise<UserTaskReportResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserTaskReportHeaders({ });
    return await this.userTaskReportWithOptions(request, headers, runtime);
  }

  async userTaskReportWithOptions(request: UserTaskReportRequest, headers: UserTaskReportHeaders, runtime: $Util.RuntimeOptions): Promise<UserTaskReportResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.dingCorpId)) {
      body["dingCorpId"] = request.dingCorpId;
    }

    if (!Util.isUnset(request.taskTag)) {
      body["taskTag"] = request.taskTag;
    }

    if (!Util.isUnset(request.operateDate)) {
      body["operateDate"] = request.operateDate;
    }

    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
    }

    if (!Util.isUnset(request.bizNo)) {
      body["bizNo"] = request.bizNo;
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
    return $tea.cast<UserTaskReportResponse>(await this.doROARequest("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", `/v1.0/appMarket/tasks`, "boolean", req, runtime), new UserTaskReportResponse({}));
  }

  async createAppGoodsServiceConversation(request: CreateAppGoodsServiceConversationRequest): Promise<CreateAppGoodsServiceConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAppGoodsServiceConversationHeaders({ });
    return await this.createAppGoodsServiceConversationWithOptions(request, headers, runtime);
  }

  async createAppGoodsServiceConversationWithOptions(request: CreateAppGoodsServiceConversationRequest, headers: CreateAppGoodsServiceConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAppGoodsServiceConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.isvUserId)) {
      body["isvUserId"] = request.isvUserId;
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
    return $tea.cast<CreateAppGoodsServiceConversationResponse>(await this.doROARequest("CreateAppGoodsServiceConversation", "appMarket_1.0", "HTTP", "POST", "AK", `/v1.0/appMarket/orders/serviceGroups`, "json", req, runtime), new CreateAppGoodsServiceConversationResponse({}));
  }

  async getPersonalExperienceInfo(request: GetPersonalExperienceInfoRequest): Promise<GetPersonalExperienceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPersonalExperienceInfoHeaders({ });
    return await this.getPersonalExperienceInfoWithOptions(request, headers, runtime);
  }

  async getPersonalExperienceInfoWithOptions(request: GetPersonalExperienceInfoRequest, headers: GetPersonalExperienceInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetPersonalExperienceInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.userId)) {
      query["userId"] = request.userId;
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
    return $tea.cast<GetPersonalExperienceInfoResponse>(await this.doROARequest("GetPersonalExperienceInfo", "appMarket_1.0", "HTTP", "GET", "AK", `/v1.0/appMarket/personalExperiences`, "json", req, runtime), new GetPersonalExperienceInfoResponse({}));
  }

}
