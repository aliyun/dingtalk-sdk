// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

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
  isvUserId?: string;
  orderId?: number;
  static names(): { [key: string]: string } {
    return {
      isvUserId: 'isvUserId',
      orderId: 'orderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isvUserId: 'string',
      orderId: 'number',
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

export class GetCoolAppAccessStatusHeaders extends $tea.Model {
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

export class GetCoolAppAccessStatusRequest extends $tea.Model {
  authCode?: string;
  coolAppCode?: string;
  encFieldBizCode?: string;
  static names(): { [key: string]: string } {
    return {
      authCode: 'authCode',
      coolAppCode: 'coolAppCode',
      encFieldBizCode: 'encFieldBizCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCode: 'string',
      coolAppCode: 'string',
      encFieldBizCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCoolAppAccessStatusResponseBody extends $tea.Model {
  status?: string;
  static names(): { [key: string]: string } {
    return {
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      status: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCoolAppAccessStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetCoolAppAccessStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetCoolAppAccessStatusResponseBody,
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

export class QueryMarketOrderHeaders extends $tea.Model {
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

export class QueryMarketOrderResponseBody extends $tea.Model {
  bizOrderId?: number;
  corpId?: string;
  createTimestamp?: number;
  endTimestamp?: number;
  goodsCode?: string;
  goodsName?: string;
  inAppOrder?: boolean;
  itemCode?: string;
  itemName?: string;
  paidTimestamp?: number;
  quantity?: number;
  startTimestamp?: number;
  status?: number;
  totalActualPayFee?: number;
  static names(): { [key: string]: string } {
    return {
      bizOrderId: 'bizOrderId',
      corpId: 'corpId',
      createTimestamp: 'createTimestamp',
      endTimestamp: 'endTimestamp',
      goodsCode: 'goodsCode',
      goodsName: 'goodsName',
      inAppOrder: 'inAppOrder',
      itemCode: 'itemCode',
      itemName: 'itemName',
      paidTimestamp: 'paidTimestamp',
      quantity: 'quantity',
      startTimestamp: 'startTimestamp',
      status: 'status',
      totalActualPayFee: 'totalActualPayFee',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizOrderId: 'number',
      corpId: 'string',
      createTimestamp: 'number',
      endTimestamp: 'number',
      goodsCode: 'string',
      goodsName: 'string',
      inAppOrder: 'boolean',
      itemCode: 'string',
      itemName: 'string',
      paidTimestamp: 'number',
      quantity: 'number',
      startTimestamp: 'number',
      status: 'number',
      totalActualPayFee: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryMarketOrderResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryMarketOrderResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryMarketOrderResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  bizNo?: string;
  operateDate?: string;
  taskTag?: string;
  userid?: string;
  static names(): { [key: string]: string } {
    return {
      bizNo: 'bizNo',
      operateDate: 'operateDate',
      taskTag: 'taskTag',
      userid: 'userid',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizNo: 'string',
      operateDate: 'string',
      taskTag: 'string',
      userid: 'string',
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


  async createAppGoodsServiceConversation(request: CreateAppGoodsServiceConversationRequest): Promise<CreateAppGoodsServiceConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAppGoodsServiceConversationHeaders({ });
    return await this.createAppGoodsServiceConversationWithOptions(request, headers, runtime);
  }

  async createAppGoodsServiceConversationWithOptions(request: CreateAppGoodsServiceConversationRequest, headers: CreateAppGoodsServiceConversationHeaders, runtime: $Util.RuntimeOptions): Promise<CreateAppGoodsServiceConversationResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isvUserId)) {
      body["isvUserId"] = request.isvUserId;
    }

    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
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
    return $tea.cast<CreateAppGoodsServiceConversationResponse>(await this.doROARequest("CreateAppGoodsServiceConversation", "appMarket_1.0", "HTTP", "POST", "AK", `/v1.0/appMarket/orders/serviceGroups`, "json", req, runtime), new CreateAppGoodsServiceConversationResponse({}));
  }

  async getCoolAppAccessStatus(request: GetCoolAppAccessStatusRequest): Promise<GetCoolAppAccessStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCoolAppAccessStatusHeaders({ });
    return await this.getCoolAppAccessStatusWithOptions(request, headers, runtime);
  }

  async getCoolAppAccessStatusWithOptions(request: GetCoolAppAccessStatusRequest, headers: GetCoolAppAccessStatusHeaders, runtime: $Util.RuntimeOptions): Promise<GetCoolAppAccessStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCode)) {
      body["authCode"] = request.authCode;
    }

    if (!Util.isUnset(request.coolAppCode)) {
      body["coolAppCode"] = request.coolAppCode;
    }

    if (!Util.isUnset(request.encFieldBizCode)) {
      body["encFieldBizCode"] = request.encFieldBizCode;
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
    return $tea.cast<GetCoolAppAccessStatusResponse>(await this.doROARequest("GetCoolAppAccessStatus", "appMarket_1.0", "HTTP", "POST", "AK", `/v1.0/appMarket/coolApps/accessions/statuses/query`, "json", req, runtime), new GetCoolAppAccessStatusResponse({}));
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
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetPersonalExperienceInfoResponse>(await this.doROARequest("GetPersonalExperienceInfo", "appMarket_1.0", "HTTP", "GET", "AK", `/v1.0/appMarket/personalExperiences`, "json", req, runtime), new GetPersonalExperienceInfoResponse({}));
  }

  async queryMarketOrder(orderId: string): Promise<QueryMarketOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMarketOrderHeaders({ });
    return await this.queryMarketOrderWithOptions(orderId, headers, runtime);
  }

  async queryMarketOrderWithOptions(orderId: string, headers: QueryMarketOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMarketOrderResponse> {
    orderId = OpenApiUtil.getEncodeParam(orderId);
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
    return $tea.cast<QueryMarketOrderResponse>(await this.doROARequest("QueryMarketOrder", "appMarket_1.0", "HTTP", "GET", "AK", `/v1.0/appMarket/orders/${orderId}`, "json", req, runtime), new QueryMarketOrderResponse({}));
  }

  async userTaskReport(request: UserTaskReportRequest): Promise<UserTaskReportResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserTaskReportHeaders({ });
    return await this.userTaskReportWithOptions(request, headers, runtime);
  }

  async userTaskReportWithOptions(request: UserTaskReportRequest, headers: UserTaskReportHeaders, runtime: $Util.RuntimeOptions): Promise<UserTaskReportResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizNo)) {
      body["bizNo"] = request.bizNo;
    }

    if (!Util.isUnset(request.operateDate)) {
      body["operateDate"] = request.operateDate;
    }

    if (!Util.isUnset(request.taskTag)) {
      body["taskTag"] = request.taskTag;
    }

    if (!Util.isUnset(request.userid)) {
      body["userid"] = request.userid;
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
    return $tea.cast<UserTaskReportResponse>(await this.doROARequest("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", `/v1.0/appMarket/tasks`, "boolean", req, runtime), new UserTaskReportResponse({}));
  }

}
