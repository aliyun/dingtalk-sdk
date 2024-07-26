// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class QueryBaymaxSkillLogHeaders extends $tea.Model {
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

export class QueryBaymaxSkillLogRequest extends $tea.Model {
  from?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  skillExecuteId?: string;
  to?: number;
  static names(): { [key: string]: string } {
    return {
      from: 'from',
      skillExecuteId: 'skillExecuteId',
      to: 'to',
    };
  }

  static types(): { [key: string]: any } {
    return {
      from: 'number',
      skillExecuteId: 'string',
      to: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBaymaxSkillLogResponseBody extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 14da****2760
   */
  result?: string;
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class QueryBaymaxSkillLogResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: QueryBaymaxSkillLogResponseBody;
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
      body: QueryBaymaxSkillLogResponseBody,
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
   * Baymax技能执行日志
   * 
   * @param request - QueryBaymaxSkillLogRequest
   * @param headers - QueryBaymaxSkillLogHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns QueryBaymaxSkillLogResponse
   */
  async queryBaymaxSkillLogWithOptions(request: QueryBaymaxSkillLogRequest, headers: QueryBaymaxSkillLogHeaders, runtime: $Util.RuntimeOptions): Promise<QueryBaymaxSkillLogResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.from)) {
      query["from"] = request.from;
    }

    if (!Util.isUnset(request.skillExecuteId)) {
      query["skillExecuteId"] = request.skillExecuteId;
    }

    if (!Util.isUnset(request.to)) {
      query["to"] = request.to;
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
      action: "QueryBaymaxSkillLog",
      version: "bayMax_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/bayMax/skills/logs`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<QueryBaymaxSkillLogResponse>(await this.execute(params, req, runtime), new QueryBaymaxSkillLogResponse({}));
  }

  /**
   * Baymax技能执行日志
   * 
   * @param request - QueryBaymaxSkillLogRequest
   * @returns QueryBaymaxSkillLogResponse
   */
  async queryBaymaxSkillLog(request: QueryBaymaxSkillLogRequest): Promise<QueryBaymaxSkillLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new QueryBaymaxSkillLogHeaders({ });
    return await this.queryBaymaxSkillLogWithOptions(request, headers, runtime);
  }

}
