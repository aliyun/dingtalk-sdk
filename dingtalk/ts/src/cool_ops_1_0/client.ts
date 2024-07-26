// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class BatchQueryOpportunityTagHeaders extends $tea.Model {
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

export class BatchQueryOpportunityTagRequest extends $tea.Model {
  corpIdList?: string[];
  static names(): { [key: string]: string } {
    return {
      corpIdList: 'corpIdList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpIdList: { 'type': 'array', 'itemType': 'string' },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryOpportunityTagResponseBody extends $tea.Model {
  result?: BatchQueryOpportunityTagResponseBodyResult;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: BatchQueryOpportunityTagResponseBodyResult,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryOpportunityTagResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: BatchQueryOpportunityTagResponseBody;
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
      body: BatchQueryOpportunityTagResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: UpdateIsvOppStatusResponseBody;
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

export class BatchQueryOpportunityTagResponseBodyResultOpportunityList extends $tea.Model {
  /**
   * @example
   * 50
   */
  activeUserCnt7d?: number;
  /**
   * @example
   * c:近7日活跃
   */
  appActiveState?: string;
  /**
   * @example
   * ding939a85cb101e83b0
   */
  corpId?: string;
  /**
   * @example
   * 2-广场
   */
  fstFunnelsourceNameLv1?: string;
  /**
   * @example
   * 2-广场
   */
  funnelsourceNameLv1?: string;
  static names(): { [key: string]: string } {
    return {
      activeUserCnt7d: 'activeUserCnt7d',
      appActiveState: 'appActiveState',
      corpId: 'corpId',
      fstFunnelsourceNameLv1: 'fstFunnelsourceNameLv1',
      funnelsourceNameLv1: 'funnelsourceNameLv1',
    };
  }

  static types(): { [key: string]: any } {
    return {
      activeUserCnt7d: 'number',
      appActiveState: 'string',
      corpId: 'string',
      fstFunnelsourceNameLv1: 'string',
      funnelsourceNameLv1: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class BatchQueryOpportunityTagResponseBodyResult extends $tea.Model {
  opportunityList?: BatchQueryOpportunityTagResponseBodyResultOpportunityList[];
  static names(): { [key: string]: string } {
    return {
      opportunityList: 'opportunityList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      opportunityList: { 'type': 'array', 'itemType': BatchQueryOpportunityTagResponseBodyResultOpportunityList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateIsvOppStatusRequestIsvOpportunityStatusList extends $tea.Model {
  isvCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  microAppId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  name?: string;
  note?: string;
  operCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operName?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operTime?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  operUserId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  oppSourceCorpId?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  opportunityStatus?: string;
  /**
   * @remarks
   * This parameter is required.
   */
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      isvCorpId: 'isvCorpId',
      microAppId: 'microAppId',
      name: 'name',
      note: 'note',
      operCorpId: 'operCorpId',
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
      operCorpId: 'string',
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
   * ISV批量查询商机标签
   * 
   * @param request - BatchQueryOpportunityTagRequest
   * @param headers - BatchQueryOpportunityTagHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns BatchQueryOpportunityTagResponse
   */
  async batchQueryOpportunityTagWithOptions(request: BatchQueryOpportunityTagRequest, headers: BatchQueryOpportunityTagHeaders, runtime: $Util.RuntimeOptions): Promise<BatchQueryOpportunityTagResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpIdList)) {
      body["corpIdList"] = request.corpIdList;
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
      action: "BatchQueryOpportunityTag",
      version: "coolOps_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/coolOps/isvOpportunities/opportunityTags/batchQuery`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<BatchQueryOpportunityTagResponse>(await this.execute(params, req, runtime), new BatchQueryOpportunityTagResponse({}));
  }

  /**
   * ISV批量查询商机标签
   * 
   * @param request - BatchQueryOpportunityTagRequest
   * @returns BatchQueryOpportunityTagResponse
   */
  async batchQueryOpportunityTag(request: BatchQueryOpportunityTagRequest): Promise<BatchQueryOpportunityTagResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new BatchQueryOpportunityTagHeaders({ });
    return await this.batchQueryOpportunityTagWithOptions(request, headers, runtime);
  }

  /**
   * ISV商机状态同步
   * 
   * @param request - UpdateIsvOppStatusRequest
   * @param headers - UpdateIsvOppStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns UpdateIsvOppStatusResponse
   */
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

  /**
   * ISV商机状态同步
   * 
   * @param request - UpdateIsvOppStatusRequest
   * @returns UpdateIsvOppStatusResponse
   */
  async updateIsvOppStatus(request: UpdateIsvOppStatusRequest): Promise<UpdateIsvOppStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new UpdateIsvOppStatusHeaders({ });
    return await this.updateIsvOppStatusWithOptions(request, headers, runtime);
  }

}
