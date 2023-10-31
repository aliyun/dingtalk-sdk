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

export class QueryScoreHeaders extends $tea.Model {
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

export class QueryScoreRequest extends $tea.Model {
  encryption?: string;
  fullName?: string;
  idCardCode?: string;
  mobile?: string;
  orgName?: string;
  uniScCode?: string;
  static names(): { [key: string]: string } {
    return {
      encryption: 'encryption',
      fullName: 'fullName',
      idCardCode: 'idCardCode',
      mobile: 'mobile',
      orgName: 'orgName',
      uniScCode: 'uniScCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      encryption: 'string',
      fullName: 'string',
      idCardCode: 'string',
      mobile: 'string',
      orgName: 'string',
      uniScCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScoreResponseBody extends $tea.Model {
  result?: QueryScoreResponseBodyResult;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
      success: 'success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: QueryScoreResponseBodyResult,
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScoreResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: QueryScoreResponseBody;
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
      body: QueryScoreResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryScoreResponseBodyResult extends $tea.Model {
  ccocScore?: number;
  cityChangeCnt3y?: number;
  cityChangeTrend2y?: number;
  classificationOfOrg?: string;
  growthRateLoginDays180d?: number;
  indChangeCnt3y?: number;
  indChangeTrend2y?: number;
  jobChangeCnt3y?: number;
  jobTitle?: string;
  joinDays?: number;
  loginDays14dPct?: number;
  loginDays365dPct?: number;
  orgCnt?: number;
  orgIndustrySubNameNew?: string;
  orgIndustryUpNameNew?: string;
  static names(): { [key: string]: string } {
    return {
      ccocScore: 'ccocScore',
      cityChangeCnt3y: 'cityChangeCnt3y',
      cityChangeTrend2y: 'cityChangeTrend2y',
      classificationOfOrg: 'classificationOfOrg',
      growthRateLoginDays180d: 'growthRateLoginDays180d',
      indChangeCnt3y: 'indChangeCnt3y',
      indChangeTrend2y: 'indChangeTrend2y',
      jobChangeCnt3y: 'jobChangeCnt3y',
      jobTitle: 'jobTitle',
      joinDays: 'joinDays',
      loginDays14dPct: 'loginDays14dPct',
      loginDays365dPct: 'loginDays365dPct',
      orgCnt: 'orgCnt',
      orgIndustrySubNameNew: 'orgIndustrySubNameNew',
      orgIndustryUpNameNew: 'orgIndustryUpNameNew',
    };
  }

  static types(): { [key: string]: any } {
    return {
      ccocScore: 'number',
      cityChangeCnt3y: 'number',
      cityChangeTrend2y: 'number',
      classificationOfOrg: 'string',
      growthRateLoginDays180d: 'number',
      indChangeCnt3y: 'number',
      indChangeTrend2y: 'number',
      jobChangeCnt3y: 'number',
      jobTitle: 'string',
      joinDays: 'number',
      loginDays14dPct: 'number',
      loginDays365dPct: 'number',
      orgCnt: 'number',
      orgIndustrySubNameNew: 'string',
      orgIndustryUpNameNew: 'string',
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


  async queryScoreWithOptions(request: QueryScoreRequest, headers: QueryScoreHeaders, runtime: $Util.RuntimeOptions): Promise<QueryScoreResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.encryption)) {
      query["encryption"] = request.encryption;
    }

    if (!Util.isUnset(request.fullName)) {
      query["fullName"] = request.fullName;
    }

    if (!Util.isUnset(request.idCardCode)) {
      query["idCardCode"] = request.idCardCode;
    }

    if (!Util.isUnset(request.mobile)) {
      query["mobile"] = request.mobile;
    }

    if (!Util.isUnset(request.orgName)) {
      query["orgName"] = request.orgName;
    }

    if (!Util.isUnset(request.uniScCode)) {
      query["uniScCode"] = request.uniScCode;
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
      action: "QueryScore",
      version: "credit_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/credit/scores`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryScoreResponse>(await this.execute(params, req, runtime), new QueryScoreResponse({}));
  }

  async queryScore(request: QueryScoreRequest): Promise<QueryScoreResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryScoreHeaders({ });
    return await this.queryScoreWithOptions(request, headers, runtime);
  }

}
