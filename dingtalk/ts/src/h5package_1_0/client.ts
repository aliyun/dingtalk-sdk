// This file is auto-generated, don't edit it
/**
 */
import Util, * as $Util from '@alicloud/tea-util';
import GatewayClient from '@alicloud/gateway-dingtalk';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class CreatePackageHeaders extends $tea.Model {
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

export class CreatePackageRequest extends $tea.Model {
  /**
   * @example
   * 1234
   */
  agentId?: number;
  /**
   * @example
   * 1234
   */
  appId?: number;
  /**
   * @example
   * https://example.com/myapp/index.html
   */
  homeUrl?: string;
  /**
   * @example
   * aaaaaa/bbbbbb
   */
  ossObjectKey?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appId: 'appId',
      homeUrl: 'homeUrl',
      ossObjectKey: 'ossObjectKey',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appId: 'number',
      homeUrl: 'string',
      ossObjectKey: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreatePackageResponseBody extends $tea.Model {
  /**
   * @example
   * 1663748308644pjpF
   */
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

export class CreatePackageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: CreatePackageResponseBody;
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
      body: CreatePackageResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenHeaders extends $tea.Model {
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

export class GetAccessTokenRequest extends $tea.Model {
  agentId?: number;
  appId?: number;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appId: 'appId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenResponseBody extends $tea.Model {
  /**
   * @example
   * STS.NUPjgnMhCVWvo1HSxfftf
   */
  accessKeyId?: string;
  /**
   * @example
   * ASviryNDy9tTuS5KiYMA6fCYf81vHg4KdoX7CVHz4CSx
   */
  accessKeySecret?: string;
  /**
   * @example
   * dingtalk-bucket
   */
  bucket?: string;
  /**
   * @example
   * oss-cn-shanghai.aliyuncs.com
   */
  endpoint?: string;
  /**
   * @example
   * 2022-09-21T09:32:16Z
   */
  expiration?: string;
  /**
   * @example
   * 5000000002761167/1663751835956
   */
  name?: string;
  /**
   * @example
   * oss-cn-shanghai
   */
  region?: string;
  /**
   * @example
   * CAIS0QJ1q6Ft5B2yfSjIr5blId3aoLdi4ZWdbRf5t3gzavt...
   */
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

export class GetAccessTokenResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetAccessTokenResponseBody;
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
      body: GetAccessTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCreateStatusHeaders extends $tea.Model {
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

export class GetCreateStatusRequest extends $tea.Model {
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 1663748308644pjpF
   */
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

export class GetCreateStatusResponseBody extends $tea.Model {
  /**
   * @example
   * 1663743241146
   */
  buildTime?: number;
  finished?: boolean;
  /**
   * @example
   * 0
   */
  packageSize?: number;
  /**
   * @example
   * 2
   */
  status?: string;
  /**
   * @example
   * 1663748308644pjpF
   */
  taskId?: string;
  /**
   * @example
   * 0.0.1
   */
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

export class GetCreateStatusResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: GetCreateStatusResponseBody;
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
      body: GetCreateStatusResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PublishPackageHeaders extends $tea.Model {
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

export class PublishPackageRequest extends $tea.Model {
  /**
   * @example
   * 1234
   */
  agentId?: number;
  /**
   * @example
   * 1234
   */
  appId?: number;
  /**
   * @remarks
   * This parameter is required.
   * 
   * @example
   * 0.0.1
   */
  version?: string;
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      appId: 'appId',
      version: 'version',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      appId: 'number',
      version: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class PublishPackageResponseBody extends $tea.Model {
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

export class PublishPackageResponse extends $tea.Model {
  headers?: { [key: string]: string };
  statusCode?: number;
  body?: PublishPackageResponseBody;
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
      body: PublishPackageResponseBody,
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
   * 上传H5离线包
   * 
   * @param request - CreatePackageRequest
   * @param headers - CreatePackageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns CreatePackageResponse
   */
  async createPackageWithOptions(request: CreatePackageRequest, headers: CreatePackageHeaders, runtime: $Util.RuntimeOptions): Promise<CreatePackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
    }

    if (!Util.isUnset(request.homeUrl)) {
      body["homeUrl"] = request.homeUrl;
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
    let params = new $OpenApi.Params({
      action: "CreatePackage",
      version: "h5package_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h5package/asyncUpload`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreatePackageResponse>(await this.execute(params, req, runtime), new CreatePackageResponse({}));
  }

  /**
   * 上传H5离线包
   * 
   * @param request - CreatePackageRequest
   * @returns CreatePackageResponse
   */
  async createPackage(request: CreatePackageRequest): Promise<CreatePackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreatePackageHeaders({ });
    return await this.createPackageWithOptions(request, headers, runtime);
  }

  /**
   * 获取包上传一次性AccessToken
   * 
   * @param request - GetAccessTokenRequest
   * @param headers - GetAccessTokenHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetAccessTokenResponse
   */
  async getAccessTokenWithOptions(request: GetAccessTokenRequest, headers: GetAccessTokenHeaders, runtime: $Util.RuntimeOptions): Promise<GetAccessTokenResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      query["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.appId)) {
      query["appId"] = request.appId;
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
      action: "GetAccessToken",
      version: "h5package_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h5package/uploadTokens`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAccessTokenResponse>(await this.execute(params, req, runtime), new GetAccessTokenResponse({}));
  }

  /**
   * 获取包上传一次性AccessToken
   * 
   * @param request - GetAccessTokenRequest
   * @returns GetAccessTokenResponse
   */
  async getAccessToken(request: GetAccessTokenRequest): Promise<GetAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAccessTokenHeaders({ });
    return await this.getAccessTokenWithOptions(request, headers, runtime);
  }

  /**
   * 获取H5离线包版本创建状态
   * 
   * @param request - GetCreateStatusRequest
   * @param headers - GetCreateStatusHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns GetCreateStatusResponse
   */
  async getCreateStatusWithOptions(request: GetCreateStatusRequest, headers: GetCreateStatusHeaders, runtime: $Util.RuntimeOptions): Promise<GetCreateStatusResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
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
    let params = new $OpenApi.Params({
      action: "GetCreateStatus",
      version: "h5package_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h5package/uploadStatus`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCreateStatusResponse>(await this.execute(params, req, runtime), new GetCreateStatusResponse({}));
  }

  /**
   * 获取H5离线包版本创建状态
   * 
   * @param request - GetCreateStatusRequest
   * @returns GetCreateStatusResponse
   */
  async getCreateStatus(request: GetCreateStatusRequest): Promise<GetCreateStatusResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetCreateStatusHeaders({ });
    return await this.getCreateStatusWithOptions(request, headers, runtime);
  }

  /**
   * 发布离线包
   * 
   * @param request - PublishPackageRequest
   * @param headers - PublishPackageHeaders
   * @param runtime - runtime options for this request RuntimeOptions
   * @returns PublishPackageResponse
   */
  async publishPackageWithOptions(request: PublishPackageRequest, headers: PublishPackageHeaders, runtime: $Util.RuntimeOptions): Promise<PublishPackageResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.agentId)) {
      body["agentId"] = request.agentId;
    }

    if (!Util.isUnset(request.appId)) {
      body["appId"] = request.appId;
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
    let params = new $OpenApi.Params({
      action: "PublishPackage",
      version: "h5package_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/h5package/publish`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<PublishPackageResponse>(await this.execute(params, req, runtime), new PublishPackageResponse({}));
  }

  /**
   * 发布离线包
   * 
   * @param request - PublishPackageRequest
   * @returns PublishPackageResponse
   */
  async publishPackage(request: PublishPackageRequest): Promise<PublishPackageResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new PublishPackageHeaders({ });
    return await this.publishPackageWithOptions(request, headers, runtime);
  }

}
