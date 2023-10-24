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

export class UpdateIsvOppStatusHeaders extends $tea.Model {
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

export class UpdateIsvOppStatusRequest extends $tea.Model {
  isvOpportunityStatusList?: UpdateIsvOppStatusRequestIsvOpportunityStatusList[];
  static names(): { [key: string]: string } {
    return {
      isvOpportunityStatusList: 'isvOpportunityStatusList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isvOpportunityStatusList: { 'type': 'array', 'itemType': UpdateIsvOppStatusRequestIsvOpportunityStatusList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvOppStatusResponseBody extends $tea.Model {
  result?: boolean;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvOppStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: UpdateIsvOppStatusResponseBody;
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
      body: UpdateIsvOppStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvOppStatusRequestIsvOpportunityStatusList extends $tea.Model {
  isvCorpId?: string;
  microAppId?: string;
  name?: string;
  note?: string;
  operName?: string;
  operTime?: string;
  operUserId?: string;
  oppSourceCorpId?: string;
  opportunityStatus?: string;
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      isvCorpId: 'isvCorpId',
      microAppId: 'microAppId',
      name: 'name',
      note: 'note',
      operName: 'operName',
      operTime: 'operTime',
      operUserId: 'operUserId',
      oppSourceCorpId: 'oppSourceCorpId',
      opportunityStatus: 'opportunityStatus',
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      isvCorpId: 'string',
      microAppId: 'string',
      name: 'string',
      note: 'string',
      operName: 'string',
      operTime: 'string',
      operUserId: 'string',
      oppSourceCorpId: 'string',
      opportunityStatus: 'string',
      userId: 'string',
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


  async updateIsvOppStatusWithOptions(request: UpdateIsvOppStatusRequest, headers: UpdateIsvOppStatusHeaders, runtime: $Util.RuntimeOptions): Promise<UpdateIsvOppStatusResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.isvOpportunityStatusList)) {
      body["isvOpportunityStatusList"] = request.isvOpportunityStatusList;
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
      action: "UpdateIsvOppStatus",
      version: "coolOps_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/coolOps/isvOpportunities/statuses`,
      method: "PUT",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<UpdateIsvOppStatusResponse>(await this.execute(params, req, runtime), new UpdateIsvOppStatusResponse({}));
  }

  async updateIsvOppStatus(request: UpdateIsvOppStatusRequest): Promise<UpdateIsvOppStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateIsvOppStatusHeaders({ });
    return await this.updateIsvOppStatusWithOptions(request, headers, runtime);
  }

}
