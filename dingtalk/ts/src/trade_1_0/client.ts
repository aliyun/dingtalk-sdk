// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import SPI from '@alicloud/gateway-spi';
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
  belongToPhoneNum?: string;
  contactPhoneNum?: string;
  corpId?: string;
  deptId?: number;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: CheckOpportunityResultResponseBody;
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
  belongToPhoneNum?: string;
  contactPhoneNum?: string;
  corpId?: string;
  deptId?: number;
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
  headers: { [key: string]: string };
  statusCode: number;
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
  articleCode?: string;
  articleItemCode?: string;
  articleItemName?: string;
  articleName?: string;
  closeTime?: number;
  createTime?: number;
  fee?: number;
  isvCropId?: string;
  orderId?: number;
  outerOrderId?: string;
  payFee?: number;
  payTime?: number;
  quantity?: number;
  refundTime?: number;
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
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryTradeOrderResponseBody;
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
  _client: SPI;

  constructor(config: $OpenApi.Config) {
    super(config);
    this._client = new GatewayClient();
    this._spi = this._client;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


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

  async checkOpportunityResult(request: CheckOpportunityResultRequest): Promise<CheckOpportunityResultResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CheckOpportunityResultHeaders({ });
    return await this.checkOpportunityResultWithOptions(request, headers, runtime);
  }

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

  async createOpportunity(request: CreateOpportunityRequest): Promise<CreateOpportunityResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateOpportunityHeaders({ });
    return await this.createOpportunityWithOptions(request, headers, runtime);
  }

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

  async queryTradeOrder(request: QueryTradeOrderRequest): Promise<QueryTradeOrderResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryTradeOrderHeaders({ });
    return await this.queryTradeOrderWithOptions(request, headers, runtime);
  }

}
