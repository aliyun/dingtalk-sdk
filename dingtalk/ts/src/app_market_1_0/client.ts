// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
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
  /**
   * @remarks
   * This parameter is required.
   */
  isvUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateAppGoodsServiceConversationResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * b195bb70dde337aabf3bcc020bf6250c
   */
  authCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * COOLAPP-1-1019F4BBC7D6212C5861000T
   */
  coolAppCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * cid5uZRmigtVWpjcKPLrp5Pag==
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCoolAppAccessStatusResponseBody;
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
      body: GetCoolAppAccessStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppSkuUrlHeaders extends $tea.Model {
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

export class GetInAppSkuUrlRequest extends $tea.Model {
  callbackPage?: string;
  extendParam?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  goodsCode?: string;
  itemCode?: string;
  static names(): { [key: string]: string } {
    return {
      callbackPage: 'callbackPage',
      extendParam: 'extendParam',
      goodsCode: 'goodsCode',
      itemCode: 'itemCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      callbackPage: 'string',
      extendParam: 'string',
      goodsCode: 'string',
      itemCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppSkuUrlResponseBody extends $tea.Model {
  url?: string;
  static names(): { [key: string]: string } {
    return {
      url: 'url',
    };
  }

  static types(): { [key: string]: any } {
    return {
      url: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetInAppSkuUrlResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetInAppSkuUrlResponseBody;
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
      body: GetInAppSkuUrlResponseBody,
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetPersonalExperienceInfoResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2092310001312
   */
  bizOrderId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * ding23219001
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10003298001
   */
  createTimestamp?: number;
  endTimestamp?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FW_GOODS_12319001
   */
  goodsCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试商品001
   */
  goodsName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  inAppOrder?: boolean;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * FW_GOODS_31001
   */
  itemCode?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 测试规格001
   */
  itemName?: string;
  /**
   * @example
   * 10003299001
   */
  paidTimestamp?: number;
  /**
   * @example
   * 1
   */
  quantity?: number;
  /**
   * @example
   * 10003298003
   */
  startTimestamp?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1
   */
  status?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 100
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryMarketOrderResponseBody;
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
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * biz1231231231abcd
   */
  bizNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2020-12-12 12:00:00
   */
  operateDate?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * task-create
   */
  taskTag?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 2312
   */
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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: boolean;
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
      body: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalExperienceInfoResponseBodyResult extends $tea.Model {
  /**
   * @example
   * ding1234
   */
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 创建应用商品服务群
   * 
   * @param request - CreateAppGoodsServiceConversationRequest
   * @param headers - CreateAppGoodsServiceConversationHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateAppGoodsServiceConversationResponse
   */
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
    let params = new $OpenApi.Params({
      action: "CreateAppGoodsServiceConversation",
      version: "appMarket_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/appMarket/orders/serviceGroups`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateAppGoodsServiceConversationResponse>(await this.execute(params, req, runtime), new CreateAppGoodsServiceConversationResponse({}));
  }

  /**
   * 创建应用商品服务群
   * 
   * @param request - CreateAppGoodsServiceConversationRequest
   * @returns CreateAppGoodsServiceConversationResponse
   */
  async createAppGoodsServiceConversation(request: CreateAppGoodsServiceConversationRequest): Promise<CreateAppGoodsServiceConversationResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateAppGoodsServiceConversationHeaders({ });
    return await this.createAppGoodsServiceConversationWithOptions(request, headers, runtime);
  }

  /**
   * 获取酷应用访问状态
   * 
   * @param request - GetCoolAppAccessStatusRequest
   * @param headers - GetCoolAppAccessStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCoolAppAccessStatusResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetCoolAppAccessStatus",
      version: "appMarket_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/appMarket/coolApps/accessions/statuses/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCoolAppAccessStatusResponse>(await this.execute(params, req, runtime), new GetCoolAppAccessStatusResponse({}));
  }

  /**
   * 获取酷应用访问状态
   * 
   * @param request - GetCoolAppAccessStatusRequest
   * @returns GetCoolAppAccessStatusResponse
   */
  async getCoolAppAccessStatus(request: GetCoolAppAccessStatusRequest): Promise<GetCoolAppAccessStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCoolAppAccessStatusHeaders({ });
    return await this.getCoolAppAccessStatusWithOptions(request, headers, runtime);
  }

  /**
   * 获取内购商品SKU页面地址
   * 
   * @param request - GetInAppSkuUrlRequest
   * @param headers - GetInAppSkuUrlHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetInAppSkuUrlResponse
   */
  async getInAppSkuUrlWithOptions(request: GetInAppSkuUrlRequest, headers: GetInAppSkuUrlHeaders, runtime: $Util.RuntimeOptions): Promise<GetInAppSkuUrlResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.callbackPage)) {
      body["callbackPage"] = request.callbackPage;
    }

    if (!Util.isUnset(request.extendParam)) {
      body["extendParam"] = request.extendParam;
    }

    if (!Util.isUnset(request.goodsCode)) {
      body["goodsCode"] = request.goodsCode;
    }

    if (!Util.isUnset(request.itemCode)) {
      body["itemCode"] = request.itemCode;
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
      action: "GetInAppSkuUrl",
      version: "appMarket_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/appMarket/internals/skuPages/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetInAppSkuUrlResponse>(await this.execute(params, req, runtime), new GetInAppSkuUrlResponse({}));
  }

  /**
   * 获取内购商品SKU页面地址
   * 
   * @param request - GetInAppSkuUrlRequest
   * @returns GetInAppSkuUrlResponse
   */
  async getInAppSkuUrl(request: GetInAppSkuUrlRequest): Promise<GetInAppSkuUrlResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetInAppSkuUrlHeaders({ });
    return await this.getInAppSkuUrlWithOptions(request, headers, runtime);
  }

  /**
   * 获取个人体验相关信息
   * 
   * @param request - GetPersonalExperienceInfoRequest
   * @param headers - GetPersonalExperienceInfoHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetPersonalExperienceInfoResponse
   */
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
    let params = new $OpenApi.Params({
      action: "GetPersonalExperienceInfo",
      version: "appMarket_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/appMarket/personalExperiences`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetPersonalExperienceInfoResponse>(await this.execute(params, req, runtime), new GetPersonalExperienceInfoResponse({}));
  }

  /**
   * 获取个人体验相关信息
   * 
   * @param request - GetPersonalExperienceInfoRequest
   * @returns GetPersonalExperienceInfoResponse
   */
  async getPersonalExperienceInfo(request: GetPersonalExperienceInfoRequest): Promise<GetPersonalExperienceInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPersonalExperienceInfoHeaders({ });
    return await this.getPersonalExperienceInfoWithOptions(request, headers, runtime);
  }

  /**
   * 应用市场订单查询
   * 
   * @param headers - QueryMarketOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryMarketOrderResponse
   */
  async queryMarketOrderWithOptions(orderId: string, headers: QueryMarketOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryMarketOrderResponse> {
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
    let params = new $OpenApi.Params({
      action: "QueryMarketOrder",
      version: "appMarket_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/appMarket/orders/${orderId}`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryMarketOrderResponse>(await this.execute(params, req, runtime), new QueryMarketOrderResponse({}));
  }

  /**
   * 应用市场订单查询
   * @returns QueryMarketOrderResponse
   */
  async queryMarketOrder(orderId: string): Promise<QueryMarketOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryMarketOrderHeaders({ });
    return await this.queryMarketOrderWithOptions(orderId, headers, runtime);
  }

  /**
   * app内用户操作任务同步
   * 
   * @param request - UserTaskReportRequest
   * @param headers - UserTaskReportHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UserTaskReportResponse
   */
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
    let params = new $OpenApi.Params({
      action: "UserTaskReport",
      version: "appMarket_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/appMarket/tasks`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "boolean",
    });
    return $tea.cast<UserTaskReportResponse>(await this.execute(params, req, runtime), new UserTaskReportResponse({}));
  }

  /**
   * app内用户操作任务同步
   * 
   * @param request - UserTaskReportRequest
   * @returns UserTaskReportResponse
   */
  async userTaskReport(request: UserTaskReportRequest): Promise<UserTaskReportResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UserTaskReportHeaders({ });
    return await this.userTaskReportWithOptions(request, headers, runtime);
  }

}
