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

export class CreateJsapiTicketHeaders extends $tea.Model {
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

export class CreateJsapiTicketResponseBody extends $tea.Model {
  expireIn?: number;
  jsapiTicket?: string;
  static names(): { [key: string]: string } {
    return {
      expireIn: 'expireIn',
      jsapiTicket: 'jsapiTicket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      expireIn: 'number',
      jsapiTicket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateJsapiTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: CreateJsapiTicketResponseBody;
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
      body: CreateJsapiTicketResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenRequest extends $tea.Model {
  appKey?: string;
  appSecret?: string;
  static names(): { [key: string]: string } {
    return {
      appKey: 'appKey',
      appSecret: 'appSecret',
    };
  }

  static types(): { [key: string]: any } {
    return {
      appKey: 'string',
      appSecret: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenResponseBody extends $tea.Model {
  accessToken?: string;
  expireIn?: number;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'accessToken',
      expireIn: 'expireIn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      expireIn: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAccessTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAccessTokenResponseBody;
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

export class GetAuthInfoHeaders extends $tea.Model {
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

export class GetAuthInfoRequest extends $tea.Model {
  authCorpId?: string;
  static names(): { [key: string]: string } {
    return {
      authCorpId: 'authCorpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCorpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthInfoResponseBody extends $tea.Model {
  authAppInfo?: GetAuthInfoResponseBodyAuthAppInfo;
  authCorpInfo?: GetAuthInfoResponseBodyAuthCorpInfo;
  authUserInfo?: GetAuthInfoResponseBodyAuthUserInfo;
  static names(): { [key: string]: string } {
    return {
      authAppInfo: 'authAppInfo',
      authCorpInfo: 'authCorpInfo',
      authUserInfo: 'authUserInfo',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authAppInfo: GetAuthInfoResponseBodyAuthAppInfo,
      authCorpInfo: GetAuthInfoResponseBodyAuthCorpInfo,
      authUserInfo: GetAuthInfoResponseBodyAuthUserInfo,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetAuthInfoResponseBody;
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
      body: GetAuthInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccessTokenRequest extends $tea.Model {
  authCorpId?: string;
  suiteKey?: string;
  suiteSecret?: string;
  suiteTicket?: string;
  static names(): { [key: string]: string } {
    return {
      authCorpId: 'authCorpId',
      suiteKey: 'suiteKey',
      suiteSecret: 'suiteSecret',
      suiteTicket: 'suiteTicket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authCorpId: 'string',
      suiteKey: 'string',
      suiteSecret: 'string',
      suiteTicket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccessTokenResponseBody extends $tea.Model {
  accessToken?: string;
  expireIn?: number;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'accessToken',
      expireIn: 'expireIn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      expireIn: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccessTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetCorpAccessTokenResponseBody;
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
      body: GetCorpAccessTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalAuthRuleHeaders extends $tea.Model {
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

export class GetPersonalAuthRuleResponseBody extends $tea.Model {
  result?: GetPersonalAuthRuleResponseBodyResult[];
  static names(): { [key: string]: string } {
    return {
      result: 'result',
    };
  }

  static types(): { [key: string]: any } {
    return {
      result: { 'type': 'array', 'itemType': GetPersonalAuthRuleResponseBodyResult },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalAuthRuleResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetPersonalAuthRuleResponseBody;
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
      body: GetPersonalAuthRuleResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSsoAccessTokenRequest extends $tea.Model {
  corpid?: string;
  ssoSecret?: string;
  static names(): { [key: string]: string } {
    return {
      corpid: 'corpid',
      ssoSecret: 'ssoSecret',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpid: 'string',
      ssoSecret: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSsoAccessTokenResponseBody extends $tea.Model {
  accessToken?: string;
  expireIn?: number;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'accessToken',
      expireIn: 'expireIn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      expireIn: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSsoAccessTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSsoAccessTokenResponseBody;
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
      body: GetSsoAccessTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSsoUserInfoHeaders extends $tea.Model {
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

export class GetSsoUserInfoRequest extends $tea.Model {
  code?: string;
  static names(): { [key: string]: string } {
    return {
      code: 'code',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSsoUserInfoResponseBody extends $tea.Model {
  avatar?: string;
  corpId?: string;
  corpName?: string;
  email?: string;
  isAdmin?: boolean;
  userId?: string;
  userName?: string;
  static names(): { [key: string]: string } {
    return {
      avatar: 'avatar',
      corpId: 'corpId',
      corpName: 'corpName',
      email: 'email',
      isAdmin: 'isAdmin',
      userId: 'userId',
      userName: 'userName',
    };
  }

  static types(): { [key: string]: any } {
    return {
      avatar: 'string',
      corpId: 'string',
      corpName: 'string',
      email: 'string',
      isAdmin: 'boolean',
      userId: 'string',
      userName: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSsoUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSsoUserInfoResponseBody;
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
      body: GetSsoUserInfoResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSuiteAccessTokenRequest extends $tea.Model {
  suiteKey?: string;
  suiteSecret?: string;
  suiteTicket?: string;
  static names(): { [key: string]: string } {
    return {
      suiteKey: 'suiteKey',
      suiteSecret: 'suiteSecret',
      suiteTicket: 'suiteTicket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      suiteKey: 'string',
      suiteSecret: 'string',
      suiteTicket: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSuiteAccessTokenResponseBody extends $tea.Model {
  accessToken?: string;
  expireIn?: number;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'accessToken',
      expireIn: 'expireIn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      expireIn: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSuiteAccessTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetSuiteAccessTokenResponseBody;
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
      body: GetSuiteAccessTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTokenRequest extends $tea.Model {
  clientId?: string;
  clientSecret?: string;
  code?: string;
  grantType?: string;
  refreshToken?: string;
  static names(): { [key: string]: string } {
    return {
      clientId: 'clientId',
      clientSecret: 'clientSecret',
      code: 'code',
      grantType: 'grantType',
      refreshToken: 'refreshToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clientId: 'string',
      clientSecret: 'string',
      code: 'string',
      grantType: 'string',
      refreshToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTokenResponseBody extends $tea.Model {
  accessToken?: string;
  corpId?: string;
  expireIn?: number;
  refreshToken?: string;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'accessToken',
      corpId: 'corpId',
      expireIn: 'expireIn',
      refreshToken: 'refreshToken',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      corpId: 'string',
      expireIn: 'number',
      refreshToken: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  statusCode: number;
  body: GetUserTokenResponseBody;
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
      body: GetUserTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthInfoResponseBodyAuthAppInfoAgentList extends $tea.Model {
  adminList?: string[];
  agentId?: number;
  agentName?: string;
  appId?: number;
  static names(): { [key: string]: string } {
    return {
      adminList: 'adminList',
      agentId: 'agentId',
      agentName: 'agentName',
      appId: 'appId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      adminList: { 'type': 'array', 'itemType': 'string' },
      agentId: 'number',
      agentName: 'string',
      appId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthInfoResponseBodyAuthAppInfo extends $tea.Model {
  agentList?: GetAuthInfoResponseBodyAuthAppInfoAgentList[];
  static names(): { [key: string]: string } {
    return {
      agentList: 'agentList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentList: { 'type': 'array', 'itemType': GetAuthInfoResponseBodyAuthAppInfoAgentList },
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthInfoResponseBodyAuthCorpInfo extends $tea.Model {
  authChannel?: string;
  authChannelType?: string;
  authLevel?: number;
  corpLogoUrl?: string;
  corpName?: string;
  industry?: string;
  inviteCode?: string;
  inviteUrl?: string;
  licenseCode?: string;
  static names(): { [key: string]: string } {
    return {
      authChannel: 'authChannel',
      authChannelType: 'authChannelType',
      authLevel: 'authLevel',
      corpLogoUrl: 'corpLogoUrl',
      corpName: 'corpName',
      industry: 'industry',
      inviteCode: 'inviteCode',
      inviteUrl: 'inviteUrl',
      licenseCode: 'licenseCode',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authChannel: 'string',
      authChannelType: 'string',
      authLevel: 'number',
      corpLogoUrl: 'string',
      corpName: 'string',
      industry: 'string',
      inviteCode: 'string',
      inviteUrl: 'string',
      licenseCode: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthInfoResponseBodyAuthUserInfo extends $tea.Model {
  userId?: string;
  static names(): { [key: string]: string } {
    return {
      userId: 'userId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      userId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetPersonalAuthRuleResponseBodyResult extends $tea.Model {
  authItems?: string[];
  resource?: string;
  static names(): { [key: string]: string } {
    return {
      authItems: 'authItems',
      resource: 'resource',
    };
  }

  static types(): { [key: string]: any } {
    return {
      authItems: { 'type': 'array', 'itemType': 'string' },
      resource: 'string',
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
    this._signatureAlgorithm = "v2";
    this._endpointRule = "";
    if (Util.empty(this._endpoint)) {
      this._endpoint = "api.dingtalk.com";
    }

  }


  async createJsapiTicketWithOptions(headers: CreateJsapiTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CreateJsapiTicketResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "CreateJsapiTicket",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/jsapiTickets`,
      method: "POST",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<CreateJsapiTicketResponse>(await this.execute(params, req, runtime), new CreateJsapiTicketResponse({}));
  }

  async createJsapiTicket(): Promise<CreateJsapiTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateJsapiTicketHeaders({ });
    return await this.createJsapiTicketWithOptions(headers, runtime);
  }

  async getAccessTokenWithOptions(request: GetAccessTokenRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<GetAccessTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.appKey)) {
      body["appKey"] = request.appKey;
    }

    if (!Util.isUnset(request.appSecret)) {
      body["appSecret"] = request.appSecret;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetAccessToken",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/accessToken`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetAccessTokenResponse>(await this.execute(params, req, runtime), new GetAccessTokenResponse({}));
  }

  async getAccessToken(request: GetAccessTokenRequest): Promise<GetAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getAccessTokenWithOptions(request, headers, runtime);
  }

  async getAuthInfoWithOptions(request: GetAuthInfoRequest, headers: GetAuthInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetAuthInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCorpId)) {
      query["authCorpId"] = request.authCorpId;
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
      action: "GetAuthInfo",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/apps/authInfo`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetAuthInfoResponse>(await this.execute(params, req, runtime), new GetAuthInfoResponse({}));
  }

  async getAuthInfo(request: GetAuthInfoRequest): Promise<GetAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAuthInfoHeaders({ });
    return await this.getAuthInfoWithOptions(request, headers, runtime);
  }

  async getCorpAccessTokenWithOptions(request: GetCorpAccessTokenRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<GetCorpAccessTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.authCorpId)) {
      body["authCorpId"] = request.authCorpId;
    }

    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.suiteSecret)) {
      body["suiteSecret"] = request.suiteSecret;
    }

    if (!Util.isUnset(request.suiteTicket)) {
      body["suiteTicket"] = request.suiteTicket;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetCorpAccessToken",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/corpAccessToken`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetCorpAccessTokenResponse>(await this.execute(params, req, runtime), new GetCorpAccessTokenResponse({}));
  }

  async getCorpAccessToken(request: GetCorpAccessTokenRequest): Promise<GetCorpAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getCorpAccessTokenWithOptions(request, headers, runtime);
  }

  async getPersonalAuthRuleWithOptions(headers: GetPersonalAuthRuleHeaders, runtime: $Util.RuntimeOptions): Promise<GetPersonalAuthRuleResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = Util.toJSONString(headers.xAcsDingtalkAccessToken);
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    let params = new $OpenApi.Params({
      action: "GetPersonalAuthRule",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/authRules/user`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetPersonalAuthRuleResponse>(await this.execute(params, req, runtime), new GetPersonalAuthRuleResponse({}));
  }

  async getPersonalAuthRule(): Promise<GetPersonalAuthRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPersonalAuthRuleHeaders({ });
    return await this.getPersonalAuthRuleWithOptions(headers, runtime);
  }

  async getSsoAccessTokenWithOptions(request: GetSsoAccessTokenRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<GetSsoAccessTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.corpid)) {
      body["corpid"] = request.corpid;
    }

    if (!Util.isUnset(request.ssoSecret)) {
      body["ssoSecret"] = request.ssoSecret;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetSsoAccessToken",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/ssoAccessToken`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetSsoAccessTokenResponse>(await this.execute(params, req, runtime), new GetSsoAccessTokenResponse({}));
  }

  async getSsoAccessToken(request: GetSsoAccessTokenRequest): Promise<GetSsoAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getSsoAccessTokenWithOptions(request, headers, runtime);
  }

  async getSsoUserInfoWithOptions(request: GetSsoUserInfoRequest, headers: GetSsoUserInfoHeaders, runtime: $Util.RuntimeOptions): Promise<GetSsoUserInfoResponse> {
    Util.validateModel(request);
    let query : {[key: string ]: any} = { };
    if (!Util.isUnset(request.code)) {
      query["code"] = request.code;
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
      action: "GetSsoUserInfo",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/ssoUserInfo`,
      method: "GET",
      authType: "AK",
      style: "ROA",
      reqBodyType: "none",
      bodyType: "json",
    });
    return $tea.cast<GetSsoUserInfoResponse>(await this.execute(params, req, runtime), new GetSsoUserInfoResponse({}));
  }

  async getSsoUserInfo(request: GetSsoUserInfoRequest): Promise<GetSsoUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSsoUserInfoHeaders({ });
    return await this.getSsoUserInfoWithOptions(request, headers, runtime);
  }

  async getSuiteAccessTokenWithOptions(request: GetSuiteAccessTokenRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<GetSuiteAccessTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.suiteSecret)) {
      body["suiteSecret"] = request.suiteSecret;
    }

    if (!Util.isUnset(request.suiteTicket)) {
      body["suiteTicket"] = request.suiteTicket;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetSuiteAccessToken",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/suiteAccessToken`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetSuiteAccessTokenResponse>(await this.execute(params, req, runtime), new GetSuiteAccessTokenResponse({}));
  }

  async getSuiteAccessToken(request: GetSuiteAccessTokenRequest): Promise<GetSuiteAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getSuiteAccessTokenWithOptions(request, headers, runtime);
  }

  async getUserTokenWithOptions(request: GetUserTokenRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<GetUserTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.clientId)) {
      body["clientId"] = request.clientId;
    }

    if (!Util.isUnset(request.clientSecret)) {
      body["clientSecret"] = request.clientSecret;
    }

    if (!Util.isUnset(request.code)) {
      body["code"] = request.code;
    }

    if (!Util.isUnset(request.grantType)) {
      body["grantType"] = request.grantType;
    }

    if (!Util.isUnset(request.refreshToken)) {
      body["refreshToken"] = request.refreshToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    let params = new $OpenApi.Params({
      action: "GetUserToken",
      version: "oauth2_1.0",
      protocol: "HTTP",
      pathname: `/v1.0/oauth2/userAccessToken`,
      method: "POST",
      authType: "Anonymous",
      style: "ROA",
      reqBodyType: "json",
      bodyType: "json",
    });
    return $tea.cast<GetUserTokenResponse>(await this.execute(params, req, runtime), new GetUserTokenResponse({}));
  }

  async getUserToken(request: GetUserTokenRequest): Promise<GetUserTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getUserTokenWithOptions(request, headers, runtime);
  }

}
