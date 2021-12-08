// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import * as $tea from '@alicloud/tea-typescript';

export class GetUserTokenRequest extends $tea.Model {
  clientId?: string;
  clientSecret?: string;
  code?: string;
  refreshToken?: string;
  grantType?: string;
  static names(): { [key: string]: string } {
    return {
      clientId: 'clientId',
      clientSecret: 'clientSecret',
      code: 'code',
      refreshToken: 'refreshToken',
      grantType: 'grantType',
    };
  }

  static types(): { [key: string]: any } {
    return {
      clientId: 'string',
      clientSecret: 'string',
      code: 'string',
      refreshToken: 'string',
      grantType: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTokenResponseBody extends $tea.Model {
  accessToken?: string;
  refreshToken?: string;
  expireIn?: number;
  corpId?: string;
  static names(): { [key: string]: string } {
    return {
      accessToken: 'accessToken',
      refreshToken: 'refreshToken',
      expireIn: 'expireIn',
      corpId: 'corpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      accessToken: 'string',
      refreshToken: 'string',
      expireIn: 'number',
      corpId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetUserTokenResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetUserTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetUserTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

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
  jsapiTicket?: string;
  expireIn?: number;
  static names(): { [key: string]: string } {
    return {
      jsapiTicket: 'jsapiTicket',
      expireIn: 'expireIn',
    };
  }

  static types(): { [key: string]: any } {
    return {
      jsapiTicket: 'string',
      expireIn: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class CreateJsapiTicketResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: CreateJsapiTicketResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: CreateJsapiTicketResponseBody,
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
  body: GetAuthInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAuthInfoResponseBody,
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
  corpId?: string;
  corpName?: string;
  userId?: string;
  email?: string;
  userName?: string;
  avatar?: string;
  isAdmin?: boolean;
  static names(): { [key: string]: string } {
    return {
      corpId: 'corpId',
      corpName: 'corpName',
      userId: 'userId',
      email: 'email',
      userName: 'userName',
      avatar: 'avatar',
      isAdmin: 'isAdmin',
    };
  }

  static types(): { [key: string]: any } {
    return {
      corpId: 'string',
      corpName: 'string',
      userId: 'string',
      email: 'string',
      userName: 'string',
      avatar: 'string',
      isAdmin: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetSsoUserInfoResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetSsoUserInfoResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSsoUserInfoResponseBody,
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
  body: GetAccessTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAccessTokenResponseBody,
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
  body: GetSuiteAccessTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSuiteAccessTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetCorpAccessTokenRequest extends $tea.Model {
  suiteKey?: string;
  suiteSecret?: string;
  authCorpId?: string;
  suiteTicket?: string;
  static names(): { [key: string]: string } {
    return {
      suiteKey: 'suiteKey',
      suiteSecret: 'suiteSecret',
      authCorpId: 'authCorpId',
      suiteTicket: 'suiteTicket',
    };
  }

  static types(): { [key: string]: any } {
    return {
      suiteKey: 'string',
      suiteSecret: 'string',
      authCorpId: 'string',
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
  body: GetCorpAccessTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetPersonalAuthRuleResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
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
  body: GetSsoAccessTokenResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetSsoAccessTokenResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAuthInfoResponseBodyAuthAppInfoAgentList extends $tea.Model {
  agentId?: number;
  agentName?: string;
  appId?: number;
  adminList?: string[];
  static names(): { [key: string]: string } {
    return {
      agentId: 'agentId',
      agentName: 'agentName',
      appId: 'appId',
      adminList: 'adminList',
    };
  }

  static types(): { [key: string]: any } {
    return {
      agentId: 'number',
      agentName: 'string',
      appId: 'number',
      adminList: { 'type': 'array', 'itemType': 'string' },
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
  inviteCode?: string;
  industry?: string;
  corpName?: string;
  licenseCode?: string;
  authChannel?: string;
  authChannelType?: string;
  authLevel?: number;
  inviteUrl?: string;
  corpLogoUrl?: string;
  static names(): { [key: string]: string } {
    return {
      inviteCode: 'inviteCode',
      industry: 'industry',
      corpName: 'corpName',
      licenseCode: 'licenseCode',
      authChannel: 'authChannel',
      authChannelType: 'authChannelType',
      authLevel: 'authLevel',
      inviteUrl: 'inviteUrl',
      corpLogoUrl: 'corpLogoUrl',
    };
  }

  static types(): { [key: string]: any } {
    return {
      inviteCode: 'string',
      industry: 'string',
      corpName: 'string',
      licenseCode: 'string',
      authChannel: 'string',
      authChannelType: 'string',
      authLevel: 'number',
      inviteUrl: 'string',
      corpLogoUrl: 'string',
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
  resource?: string;
  authItems?: string[];
  static names(): { [key: string]: string } {
    return {
      resource: 'resource',
      authItems: 'authItems',
    };
  }

  static types(): { [key: string]: any } {
    return {
      resource: 'string',
      authItems: { 'type': 'array', 'itemType': 'string' },
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


  async getUserToken(request: GetUserTokenRequest): Promise<GetUserTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getUserTokenWithOptions(request, headers, runtime);
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

    if (!Util.isUnset(request.refreshToken)) {
      body["refreshToken"] = request.refreshToken;
    }

    if (!Util.isUnset(request.grantType)) {
      body["grantType"] = request.grantType;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetUserTokenResponse>(await this.doROARequest("GetUserToken", "oauth2_1.0", "HTTP", "POST", "AK", `/v1.0/oauth2/userAccessToken`, "json", req, runtime), new GetUserTokenResponse({}));
  }

  async createJsapiTicket(): Promise<CreateJsapiTicketResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new CreateJsapiTicketHeaders({ });
    return await this.createJsapiTicketWithOptions(headers, runtime);
  }

  async createJsapiTicketWithOptions(headers: CreateJsapiTicketHeaders, runtime: $Util.RuntimeOptions): Promise<CreateJsapiTicketResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<CreateJsapiTicketResponse>(await this.doROARequest("CreateJsapiTicket", "oauth2_1.0", "HTTP", "POST", "AK", `/v1.0/oauth2/jsapiTickets`, "json", req, runtime), new CreateJsapiTicketResponse({}));
  }

  async getAuthInfo(request: GetAuthInfoRequest): Promise<GetAuthInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetAuthInfoHeaders({ });
    return await this.getAuthInfoWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetAuthInfoResponse>(await this.doROARequest("GetAuthInfo", "oauth2_1.0", "HTTP", "GET", "AK", `/v1.0/oauth2/apps/authInfo`, "json", req, runtime), new GetAuthInfoResponse({}));
  }

  async getSsoUserInfo(request: GetSsoUserInfoRequest): Promise<GetSsoUserInfoResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetSsoUserInfoHeaders({ });
    return await this.getSsoUserInfoWithOptions(request, headers, runtime);
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
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
      query: OpenApiUtil.query(query),
    });
    return $tea.cast<GetSsoUserInfoResponse>(await this.doROARequest("GetSsoUserInfo", "oauth2_1.0", "HTTP", "GET", "AK", `/v1.0/oauth2/ssoUserInfo`, "json", req, runtime), new GetSsoUserInfoResponse({}));
  }

  async getAccessToken(request: GetAccessTokenRequest): Promise<GetAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getAccessTokenWithOptions(request, headers, runtime);
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
    return $tea.cast<GetAccessTokenResponse>(await this.doROARequest("GetAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", `/v1.0/oauth2/accessToken`, "json", req, runtime), new GetAccessTokenResponse({}));
  }

  async getSuiteAccessToken(request: GetSuiteAccessTokenRequest): Promise<GetSuiteAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getSuiteAccessTokenWithOptions(request, headers, runtime);
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
    return $tea.cast<GetSuiteAccessTokenResponse>(await this.doROARequest("GetSuiteAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", `/v1.0/oauth2/suiteAccessToken`, "json", req, runtime), new GetSuiteAccessTokenResponse({}));
  }

  async getCorpAccessToken(request: GetCorpAccessTokenRequest): Promise<GetCorpAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getCorpAccessTokenWithOptions(request, headers, runtime);
  }

  async getCorpAccessTokenWithOptions(request: GetCorpAccessTokenRequest, headers: {[key: string ]: string}, runtime: $Util.RuntimeOptions): Promise<GetCorpAccessTokenResponse> {
    Util.validateModel(request);
    let body : {[key: string ]: any} = { };
    if (!Util.isUnset(request.suiteKey)) {
      body["suiteKey"] = request.suiteKey;
    }

    if (!Util.isUnset(request.suiteSecret)) {
      body["suiteSecret"] = request.suiteSecret;
    }

    if (!Util.isUnset(request.authCorpId)) {
      body["authCorpId"] = request.authCorpId;
    }

    if (!Util.isUnset(request.suiteTicket)) {
      body["suiteTicket"] = request.suiteTicket;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: headers,
      body: OpenApiUtil.parseToMap(body),
    });
    return $tea.cast<GetCorpAccessTokenResponse>(await this.doROARequest("GetCorpAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", `/v1.0/oauth2/corpAccessToken`, "json", req, runtime), new GetCorpAccessTokenResponse({}));
  }

  async getPersonalAuthRule(): Promise<GetPersonalAuthRuleResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers = new GetPersonalAuthRuleHeaders({ });
    return await this.getPersonalAuthRuleWithOptions(headers, runtime);
  }

  async getPersonalAuthRuleWithOptions(headers: GetPersonalAuthRuleHeaders, runtime: $Util.RuntimeOptions): Promise<GetPersonalAuthRuleResponse> {
    let realHeaders : {[key: string ]: string} = { };
    if (!Util.isUnset(headers.commonHeaders)) {
      realHeaders = headers.commonHeaders;
    }

    if (!Util.isUnset(headers.xAcsDingtalkAccessToken)) {
      realHeaders["x-acs-dingtalk-access-token"] = headers.xAcsDingtalkAccessToken;
    }

    let req = new $OpenApi.OpenApiRequest({
      headers: realHeaders,
    });
    return $tea.cast<GetPersonalAuthRuleResponse>(await this.doROARequest("GetPersonalAuthRule", "oauth2_1.0", "HTTP", "GET", "AK", `/v1.0/oauth2/authRules/user`, "json", req, runtime), new GetPersonalAuthRuleResponse({}));
  }

  async getSsoAccessToken(request: GetSsoAccessTokenRequest): Promise<GetSsoAccessTokenResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    let headers : {[key: string ]: string} = { };
    return await this.getSsoAccessTokenWithOptions(request, headers, runtime);
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
    return $tea.cast<GetSsoAccessTokenResponse>(await this.doROARequest("GetSsoAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", `/v1.0/oauth2/ssoAccessToken`, "json", req, runtime), new GetSsoAccessTokenResponse({}));
  }

}
