// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CheckOpportunityResultHeaders extends $tea.Model {
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

export class CheckOpportunityResultRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  belongToPhoneNum?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contactPhoneNum?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  marketCode?: string;
  static names(): { [key: string]: string } {
    return {
      belongToPhoneNum: 'belongToPhoneNum',
      contactPhoneNum: 'contactPhoneNum',
      corpId: 'corpId',
      deptId: 'deptId',
      marketCode: 'marketCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongToPhoneNum: 'string',
      contactPhoneNum: 'string',
      corpId: 'string',
      deptId: 'number',
      marketCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckOpportunityResultResponseBody extends $tea.Model {
  /**
   * @example
   * true
   */
  bizSuccess?: boolean;
  static names(): { [key: string]: string } {
    return {
      bizSuccess: 'bizSuccess',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizSuccess: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CheckOpportunityResultResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CheckOpportunityResultResponseBody;
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
      body: CheckOpportunityResultResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateNoteForIsvHeaders extends $tea.Model {
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

export class CreateNoteForIsvRequest extends $tea.Model {
  contactName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contactPhoneNum?: string;
  contactTitle?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * **if can be null:**
   * false
   */
  content?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  inputPhoneNum?: string;
  static names(): { [key: string]: string } {
    return {
      contactName: 'contactName',
      contactPhoneNum: 'contactPhoneNum',
      contactTitle: 'contactTitle',
      content: 'content',
      corpId: 'corpId',
      inputPhoneNum: 'inputPhoneNum',
    };
  }

  static types(): { [key: string]: any } {
    return {
      contactName: 'string',
      contactPhoneNum: 'string',
      contactTitle: 'string',
      content: 'string',
      corpId: 'string',
      inputPhoneNum: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateNoteForIsvResponseBody extends $tea.Model {
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateNoteForIsvResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreateNoteForIsvResponseBody;
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
      body: CreateNoteForIsvResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOpportunityHeaders extends $tea.Model {
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

export class CreateOpportunityRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  belongToPhoneNum?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  contactPhoneNum?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  corpId?: string;
  deptId?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  marketCode?: string;
  static names(): { [key: string]: string } {
    return {
      belongToPhoneNum: 'belongToPhoneNum',
      contactPhoneNum: 'contactPhoneNum',
      corpId: 'corpId',
      deptId: 'deptId',
      marketCode: 'marketCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      belongToPhoneNum: 'string',
      contactPhoneNum: 'string',
      corpId: 'string',
      deptId: 'number',
      marketCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateOpportunityResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      statusCode: 'statusCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      statusCode: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTradeOrderHeaders extends $tea.Model {
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

export class QueryTradeOrderRequest extends $tea.Model {
  orderId?: number;
  outerOrderId?: string;
  static names(): { [key: string]: string } {
    return {
      orderId: 'orderId',
      outerOrderId: 'outerOrderId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      orderId: 'number',
      outerOrderId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTradeOrderResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   */
  articleCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  articleItemCode?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  articleItemName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  articleName?: string;
  closeTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  createTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  fee?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  isvCropId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  orderId?: number;
  outerOrderId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  payFee?: number;
  payTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  quantity?: number;
  refundTime?: number;
  /**
   * @remarks
   * This parameter is required.
   */
  status?: number;
  static names(): { [key: string]: string } {
    return {
      articleCode: 'articleCode',
      articleItemCode: 'articleItemCode',
      articleItemName: 'articleItemName',
      articleName: 'articleName',
      closeTime: 'closeTime',
      createTime: 'createTime',
      fee: 'fee',
      isvCropId: 'isvCropId',
      orderId: 'orderId',
      outerOrderId: 'outerOrderId',
      payFee: 'payFee',
      payTime: 'payTime',
      quantity: 'quantity',
      refundTime: 'refundTime',
      status: 'status',
    };
  }

  static types(): { [key: string]: any } {
    return {
      articleCode: 'string',
      articleItemCode: 'string',
      articleItemName: 'string',
      articleName: 'string',
      closeTime: 'number',
      createTime: 'number',
      fee: 'number',
      isvCropId: 'string',
      orderId: 'number',
      outerOrderId: 'string',
      payFee: 'number',
      payTime: 'number',
      quantity: 'number',
      refundTime: 'number',
      status: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryTradeOrderResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryTradeOrderResponseBody;
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
      body: QueryTradeOrderResponseBody,
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
   * isv检查商机创建是否符合预期
   * 
   * @param request - CheckOpportunityResultRequest
   * @param headers - CheckOpportunityResultHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CheckOpportunityResultResponse
   */
  async checkOpportunityResultWithOptions(request: CheckOpportunityResultRequest, headers: CheckOpportunityResultHeaders, runtime: $Util.RuntimeOptions): Promise<CheckOpportunityResultResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.belongToPhoneNum)) {
      query["belongToPhoneNum"] = request.belongToPhoneNum;
    }

    if (!Util.isUnset(request.contactPhoneNum)) {
      query["contactPhoneNum"] = request.contactPhoneNum;
    }

    if (!Util.isUnset(request.corpId)) {
      query["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deptId)) {
      query["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.marketCode)) {
      query["marketCode"] = request.marketCode;
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
      action: "CheckOpportunityResult",
      version: "trade_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trade/opportunity/check`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CheckOpportunityResultResponse>(await this.execute(params, req, runtime), new CheckOpportunityResultResponse({}));
  }

  /**
   * isv检查商机创建是否符合预期
   * 
   * @param request - CheckOpportunityResultRequest
   * @returns CheckOpportunityResultResponse
   */
  async checkOpportunityResult(request: CheckOpportunityResultRequest): Promise<CheckOpportunityResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckOpportunityResultHeaders({ });
    return await this.checkOpportunityResultWithOptions(request, headers, runtime);
  }

  /**
   * 创建小记
   * 
   * @param request - CreateNoteForIsvRequest
   * @param headers - CreateNoteForIsvHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateNoteForIsvResponse
   */
  async createNoteForIsvWithOptions(request: CreateNoteForIsvRequest, headers: CreateNoteForIsvHeaders, runtime: $Util.RuntimeOptions): Promise<CreateNoteForIsvResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.contactName)) {
      body["contactName"] = request.contactName;
    }

    if (!Util.isUnset(request.contactPhoneNum)) {
      body["contactPhoneNum"] = request.contactPhoneNum;
    }

    if (!Util.isUnset(request.contactTitle)) {
      body["contactTitle"] = request.contactTitle;
    }

    if (!Util.isUnset(request.content)) {
      body["content"] = request.content;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.inputPhoneNum)) {
      body["inputPhoneNum"] = request.inputPhoneNum;
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
      action: "CreateNoteForIsv",
      version: "trade_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trade/notes`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateNoteForIsvResponse>(await this.execute(params, req, runtime), new CreateNoteForIsvResponse({}));
  }

  /**
   * 创建小记
   * 
   * @param request - CreateNoteForIsvRequest
   * @returns CreateNoteForIsvResponse
   */
  async createNoteForIsv(request: CreateNoteForIsvRequest): Promise<CreateNoteForIsvResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateNoteForIsvHeaders({ });
    return await this.createNoteForIsvWithOptions(request, headers, runtime);
  }

  /**
   * isv创建商机
   * 
   * @param request - CreateOpportunityRequest
   * @param headers - CreateOpportunityHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreateOpportunityResponse
   */
  async createOpportunityWithOptions(request: CreateOpportunityRequest, headers: CreateOpportunityHeaders, runtime: $Util.RuntimeOptions): Promise<CreateOpportunityResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.belongToPhoneNum)) {
      body["belongToPhoneNum"] = request.belongToPhoneNum;
    }

    if (!Util.isUnset(request.contactPhoneNum)) {
      body["contactPhoneNum"] = request.contactPhoneNum;
    }

    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.deptId)) {
      body["deptId"] = request.deptId;
    }

    if (!Util.isUnset(request.marketCode)) {
      body["marketCode"] = request.marketCode;
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
      action: "CreateOpportunity",
      version: "trade_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trade/opportunities`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<CreateOpportunityResponse>(await this.execute(params, req, runtime), new CreateOpportunityResponse({}));
  }

  /**
   * isv创建商机
   * 
   * @param request - CreateOpportunityRequest
   * @returns CreateOpportunityResponse
   */
  async createOpportunity(request: CreateOpportunityRequest): Promise<CreateOpportunityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOpportunityHeaders({ });
    return await this.createOpportunityWithOptions(request, headers, runtime);
  }

  /**
   * 查询订单信息
   * 
   * @param request - QueryTradeOrderRequest
   * @param headers - QueryTradeOrderHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryTradeOrderResponse
   */
  async queryTradeOrderWithOptions(request: QueryTradeOrderRequest, headers: QueryTradeOrderHeaders, runtime: $Util.RuntimeOptions): Promise<QueryTradeOrderResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.orderId)) {
      body["orderId"] = request.orderId;
    }

    if (!Util.isUnset(request.outerOrderId)) {
      body["outerOrderId"] = request.outerOrderId;
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
      action: "QueryTradeOrder",
      version: "trade_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/trade/orders/query`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<QueryTradeOrderResponse>(await this.execute(params, req, runtime), new QueryTradeOrderResponse({}));
  }

  /**
   * 查询订单信息
   * 
   * @param request - QueryTradeOrderRequest
   * @returns QueryTradeOrderResponse
   */
  async queryTradeOrder(request: QueryTradeOrderRequest): Promise<QueryTradeOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTradeOrderHeaders({ });
    return await this.queryTradeOrderWithOptions(request, headers, runtime);
  }

}
