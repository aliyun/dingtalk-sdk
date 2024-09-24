// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class RegisterCategorySourceConfigHeaders extends $tea.Model {
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

export class RegisterCategorySourceConfigRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1001
   */
  bizCategoryId?: string;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 财务_审批_考勤
   */
  bizCategoryName?: string;
  /**
   * @example
   * 张三
   */
  operatorId?: string;
  static names(): { [key: string]: string } {
    return {
      bizCategoryId: 'bizCategoryId',
      bizCategoryName: 'bizCategoryName',
      operatorId: 'operatorId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      bizCategoryId: 'string',
      bizCategoryName: 'string',
      operatorId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class RegisterCategorySourceConfigResponseBody extends $tea.Model {
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

export class RegisterCategorySourceConfigResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: RegisterCategorySourceConfigResponseBody;
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
      body: RegisterCategorySourceConfigResponseBody,
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
   * 注册应用类目信息
   * 
   * @param request - RegisterCategorySourceConfigRequest
   * @param headers - RegisterCategorySourceConfigHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns RegisterCategorySourceConfigResponse
   */
  async registerCategorySourceConfigWithOptions(request: RegisterCategorySourceConfigRequest, headers: RegisterCategorySourceConfigHeaders, runtime: $Util.RuntimeOptions): Promise<RegisterCategorySourceConfigResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.bizCategoryId)) {
      body["bizCategoryId"] = request.bizCategoryId;
    }

    if (!Util.isUnset(request.bizCategoryName)) {
      body["bizCategoryName"] = request.bizCategoryName;
    }

    if (!Util.isUnset(request.operatorId)) {
      body["operatorId"] = request.operatorId;
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
      action: "RegisterCategorySourceConfig",
      version: "todoEE_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/todoEE/apps/categories/sourceConfigs/register`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<RegisterCategorySourceConfigResponse>(await this.execute(params, req, runtime), new RegisterCategorySourceConfigResponse({}));
  }

  /**
   * 注册应用类目信息
   * 
   * @param request - RegisterCategorySourceConfigRequest
   * @returns RegisterCategorySourceConfigResponse
   */
  async registerCategorySourceConfig(request: RegisterCategorySourceConfigRequest): Promise<RegisterCategorySourceConfigResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new RegisterCategorySourceConfigHeaders({ });
    return await this.registerCategorySourceConfigWithOptions(request, headers, runtime);
  }

}
