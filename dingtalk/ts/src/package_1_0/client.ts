// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetUploadTokenHeaders extends $tea.Model {
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

export class GetUploadTokenRequest extends $tea.Model {
  miniAppId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadTokenResponseBody extends $tea.Model {
  accessKeyId?: string;
  accessKeySecret?: string;
  bucket?: string;
  endpoint?: string;
  expiration?: string;
  name?: string;
  region?: string;
  stsToken?: string;
  static names(): { [key: string]: string } {
    return {
      accessKeyId: 'accessKeyId',
      accessKeySecret: 'accessKeySecret',
      bucket: 'bucket',
      endpoint: 'endpoint',
      expiration: 'expiration',
      name: 'name',
      region: 'region',
      stsToken: 'stsToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessKeyId: 'string',
      accessKeySecret: 'string',
      bucket: 'string',
      endpoint: 'string',
      expiration: 'string',
      name: 'string',
      region: 'string',
      stsToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUploadTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUploadTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUploadTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPublishPackageHeaders extends $tea.Model {
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

export class HPublishPackageRequest extends $tea.Model {
  miniAppId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HPublishPackageResponseBody extends $tea.Model {
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

export class HPublishPackageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HPublishPackageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HPublishPackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageHeaders extends $tea.Model {
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

export class HUploadPackageRequest extends $tea.Model {
  miniAppId?: string;
  ossObjectKey?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      ossObjectKey: 'ossObjectKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      ossObjectKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageResponseBody extends $tea.Model {
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HUploadPackageResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HUploadPackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageStatusHeaders extends $tea.Model {
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

export class HUploadPackageStatusRequest extends $tea.Model {
  miniAppId?: string;
  taskId?: string;
  static names(): { [key: string]: string } {
    return {
      miniAppId: 'miniAppId',
      taskId: 'taskId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      miniAppId: 'string',
      taskId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageStatusResponseBody extends $tea.Model {
  buildTime?: number;
  finished?: boolean;
  packageSize?: number;
  status?: string;
  taskId?: string;
  version?: string;
  static names(): { [key: string]: string } {
    return {
      buildTime: 'buildTime',
      finished: 'finished',
      packageSize: 'packageSize',
      status: 'status',
      taskId: 'taskId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      buildTime: 'number',
      finished: 'boolean',
      packageSize: 'number',
      status: 'string',
      taskId: 'string',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class HUploadPackageStatusResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: HUploadPackageStatusResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: HUploadPackageStatusResponseBody,
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


  async getUploadToken(request: GetUploadTokenRequest): Promise<GetUploadTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetUploadTokenHeaders({ });
    return await this.getUploadTokenWithOptions(request, headers, runtime);
  }

  async getUploadTokenWithOptions(request: GetUploadTokenRequest, headers: GetUploadTokenHeaders, runtime: $Util.RuntimeOptions): Promise<GetUploadTokenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
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
    return $tea.cast<GetUploadTokenResponse>(await this.doROARequest("GetUploadToken", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/uploadTokens`, "json", req, runtime), new GetUploadTokenResponse({}));
  }

  async hPublishPackage(request: HPublishPackageRequest): Promise<HPublishPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HPublishPackageHeaders({ });
    return await this.hPublishPackageWithOptions(request, headers, runtime);
  }

  async hPublishPackageWithOptions(request: HPublishPackageRequest, headers: HPublishPackageHeaders, runtime: $Util.RuntimeOptions): Promise<HPublishPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.version)) {
      body["version"] = request.version;
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
    return $tea.cast<HPublishPackageResponse>(await this.doROARequest("HPublishPackage", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/h5/publish`, "json", req, runtime), new HPublishPackageResponse({}));
  }

  async hUploadPackage(request: HUploadPackageRequest): Promise<HUploadPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HUploadPackageHeaders({ });
    return await this.hUploadPackageWithOptions(request, headers, runtime);
  }

  async hUploadPackageWithOptions(request: HUploadPackageRequest, headers: HUploadPackageHeaders, runtime: $Util.RuntimeOptions): Promise<HUploadPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      body["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.ossObjectKey)) {
      body["ossObjectKey"] = request.ossObjectKey;
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
    return $tea.cast<HUploadPackageResponse>(await this.doROARequest("HUploadPackage", "package_1.0", "HTTP", "POST", "AK", `/v1.0/package/h5/asyncUpload`, "json", req, runtime), new HUploadPackageResponse({}));
  }

  async hUploadPackageStatus(request: HUploadPackageStatusRequest): Promise<HUploadPackageStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new HUploadPackageStatusHeaders({ });
    return await this.hUploadPackageStatusWithOptions(request, headers, runtime);
  }

  async hUploadPackageStatusWithOptions(request: HUploadPackageStatusRequest, headers: HUploadPackageStatusHeaders, runtime: $Util.RuntimeOptions): Promise<HUploadPackageStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.miniAppId)) {
      query["miniAppId"] = request.miniAppId;
    }

    if (!Util.isUnset(request.taskId)) {
      query["taskId"] = request.taskId;
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
    return $tea.cast<HUploadPackageStatusResponse>(await this.doROARequest("HUploadPackageStatus", "package_1.0", "HTTP", "GET", "AK", `/v1.0/package/h5/uploadStatus`, "json", req, runtime), new HUploadPackageStatusResponse({}));
  }

}
