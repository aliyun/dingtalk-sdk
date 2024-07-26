// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryGoodsListHeaders extends $tea.Model {
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

export class QueryGoodsListRequest extends $tea.Model {
  /**
   * @example
   * 1631289600000
   */
  endTimeInMills?: number;
  /**
   * @example
   * 10
   */
  maxResults?: number;
  /**
   * @example
   * 1
   */
  nextToken?: number;
  /**
   * @example
   * 1631289600000
   */
  startTimeInMills?: number;
  static names(): { [key: string]: string } {
    return {
      endTimeInMills: 'endTimeInMills',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
      startTimeInMills: 'startTimeInMills',
    };
  }

  static types(): { [key: string]: any } {
    return {
      endTimeInMills: 'number',
      maxResults: 'number',
      nextToken: 'number',
      startTimeInMills: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponseBody extends $tea.Model {
  result?: QueryGoodsListResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryGoodsListResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryGoodsListResponseBody;
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
      body: QueryGoodsListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponseBodyResultList extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 衣服
   */
  goodsName?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0001
   */
  goodsNo?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * abcdse-dse-example
   */
  instanceId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * XXL
   */
  productSpecs?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 件
   */
  unit?: string;
  static names(): { [key: string]: string } {
    return {
      goodsName: 'goodsName',
      goodsNo: 'goodsNo',
      instanceId: 'instanceId',
      productSpecs: 'productSpecs',
      unit: 'unit',
    };
  }

  static types(): { [key: string]: any } {
    return {
      goodsName: 'string',
      goodsNo: 'string',
      instanceId: 'string',
      productSpecs: 'string',
      unit: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponseBodyResult extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * true
   */
  hasMore?: boolean;
  list?: QueryGoodsListResponseBodyResultList[];
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 20
   */
  maxResults?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 10
   */
  nextToken?: string;
  static names(): { [key: string]: string } {
    return {
      hasMore: 'hasMore',
      list: 'list',
      maxResults: 'maxResults',
      nextToken: 'nextToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      hasMore: 'boolean',
      list: { 'type': 'array', 'itemType': QueryGoodsListResponseBodyResultList },
      maxResults: 'number',
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
    let gatewayClient = new GatewayClient();
    this._spi = gatewayClient;
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  /**
   * 获取物料列表
   * 
   * @param request - QueryGoodsListRequest
   * @param headers - QueryGoodsListHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryGoodsListResponse
   */
  async queryGoodsListWithOptions(request: QueryGoodsListRequest, headers: QueryGoodsListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGoodsListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.endTimeInMills)) {
      query["endTimeInMills"] = request.endTimeInMills;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.startTimeInMills)) {
      query["startTimeInMills"] = request.startTimeInMills;
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
      action: "QueryGoodsList",
      version: "wms_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/wms/goods`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryGoodsListResponse>(await this.execute(params, req, runtime), new QueryGoodsListResponse({}));
  }

  /**
   * 获取物料列表
   * 
   * @param request - QueryGoodsListRequest
   * @returns QueryGoodsListResponse
   */
  async queryGoodsList(request: QueryGoodsListRequest): Promise<QueryGoodsListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGoodsListHeaders({ });
    return await this.queryGoodsListWithOptions(request, headers, runtime);
  }

}
