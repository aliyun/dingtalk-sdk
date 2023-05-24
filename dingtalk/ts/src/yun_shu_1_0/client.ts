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

export class SaveOpenExternalLogHeaders extends $tea.Model {
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

export class SaveOpenExternalLogRequest extends $tea.Model {
  corpId?: string;
  logSource?: string;
  logType?: string;
  openExt?: string;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      logSource: 'logSource',
      logType: 'logType',
      openExt: 'openExt',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      logSource: 'string',
      logType: 'string',
      openExt: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SaveOpenExternalLogResponseBody extends $tea.Model {
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

export class SaveOpenExternalLogResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: SaveOpenExternalLogResponseBody;
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
      body: SaveOpenExternalLogResponseBody,
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


  async saveOpenExternalLogWithOptions(request: SaveOpenExternalLogRequest, headers: SaveOpenExternalLogHeaders, runtime: $Util.RuntimeOptions): Promise<SaveOpenExternalLogResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpId)) {
      body["corpId"] = request.corpId;
    }

    if (!Util.isUnset(request.logSource)) {
      body["logSource"] = request.logSource;
    }

    if (!Util.isUnset(request.logType)) {
      body["logType"] = request.logType;
    }

    if (!Util.isUnset(request.openExt)) {
      body["openExt"] = request.openExt;
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
      action: "SaveOpenExternalLog",
      version: "yunShu_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/yunShu/externalLogs/save`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<SaveOpenExternalLogResponse>(await this.execute(params, req, runtime), new SaveOpenExternalLogResponse({}));
  }

  async saveOpenExternalLog(request: SaveOpenExternalLogRequest): Promise<SaveOpenExternalLogResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new SaveOpenExternalLogHeaders({ });
    return await this.saveOpenExternalLogWithOptions(request, headers, runtime);
  }

}
