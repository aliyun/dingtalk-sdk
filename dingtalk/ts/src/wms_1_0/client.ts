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
  endTimeInMills?: number;
  maxResults?: number;
  nextToken?: number;
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
  goodsName?: string;
  goodsNo?: string;
  instanceId?: string;
  productSpecs?: string;
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
  hasMore?: boolean;
  list?: QueryGoodsListResponseBodyResultList[];
  maxResults?: number;
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
    return $tea.cast<QueryGoodsListResponse>(await this.doROARequest("QueryGoodsList", "wms_1.0", "HTTP", "GET", "AK", `/v1.0/wms/goods`, "json", req, runtime), new QueryGoodsListResponse({}));
  }

}
