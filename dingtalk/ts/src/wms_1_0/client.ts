// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
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
  nextToken?: number;
  maxResults?: number;
  startTimeInMills?: number;
  endTimeInMills?: number;
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      maxResults: 'maxResults',
      startTimeInMills: 'startTimeInMills',
      endTimeInMills: 'endTimeInMills',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'number',
      maxResults: 'number',
      startTimeInMills: 'number',
      endTimeInMills: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponseBody extends $tea.Model {
  success?: boolean;
  result?: QueryGoodsListResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      success: 'success',
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      success: 'boolean',
      result: QueryGoodsListResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: QueryGoodsListResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: QueryGoodsListResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponseBodyResultList extends $tea.Model {
  instanceId?: string;
  goodsNo?: string;
  goodsName?: string;
  unit?: string;
  productSpecs?: string;
  static names(): { [key: string]: string } {
    return {
      instanceId: 'instanceId',
      goodsNo: 'goodsNo',
      goodsName: 'goodsName',
      unit: 'unit',
      productSpecs: 'productSpecs',
    };
  }

  static types(): { [key: string]: any } {
    return {
      instanceId: 'string',
      goodsNo: 'string',
      goodsName: 'string',
      unit: 'string',
      productSpecs: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryGoodsListResponseBodyResult extends $tea.Model {
  nextToken?: string;
  hasMore?: boolean;
  maxResults?: number;
  list?: QueryGoodsListResponseBodyResultList[];
  static names(): { [key: string]: string } {
    return {
      nextToken: 'nextToken',
      hasMore: 'hasMore',
      maxResults: 'maxResults',
      list: 'list',
    };
  }

  static types(): { [key: string]: any } {
    return {
      nextToken: 'string',
      hasMore: 'boolean',
      maxResults: 'number',
      list: { 'type': 'array', 'itemType': QueryGoodsListResponseBodyResultList },
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


  async queryGoodsList(request: QueryGoodsListRequest): Promise<QueryGoodsListResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryGoodsListHeaders({ });
    return await this.queryGoodsListWithOptions(request, headers, runtime);
  }

  async queryGoodsListWithOptions(request: QueryGoodsListRequest, headers: QueryGoodsListHeaders, runtime: $Util.RuntimeOptions): Promise<QueryGoodsListResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.nextToken)) {
      query["nextToken"] = request.nextToken;
    }

    if (!Util.isUnset(request.maxResults)) {
      query["maxResults"] = request.maxResults;
    }

    if (!Util.isUnset(request.startTimeInMills)) {
      query["startTimeInMills"] = request.startTimeInMills;
    }

    if (!Util.isUnset(request.endTimeInMills)) {
      query["endTimeInMills"] = request.endTimeInMills;
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
    return $tea.cast<QueryGoodsListResponse>(await this.doROARequest("QueryGoodsList", "wms_1.0", "HTTP", "GET", "AK", `/v1.0/wms/goods`, "json", req, runtime), new QueryGoodsListResponse({}));
  }

}
