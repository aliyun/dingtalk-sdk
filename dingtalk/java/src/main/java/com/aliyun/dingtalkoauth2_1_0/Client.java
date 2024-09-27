// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkoauth2_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>生成jsapi ticket</p>
     * 
     * @param headers CreateJsapiTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateJsapiTicketResponse
     */
    public CreateJsapiTicketResponse createJsapiTicketWithOptions(CreateJsapiTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateJsapiTicket"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/jsapiTickets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateJsapiTicketResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生成jsapi ticket</p>
     * @return CreateJsapiTicketResponse
     */
    public CreateJsapiTicketResponse createJsapiTicket() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateJsapiTicketHeaders headers = new CreateJsapiTicketHeaders();
        return this.createJsapiTicketWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业accessToken(企业内部应用)</p>
     * 
     * @param request GetAccessTokenRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAccessTokenResponse
     */
    public GetAccessTokenResponse getAccessTokenWithOptions(GetAccessTokenRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appSecret)) {
            body.put("appSecret", request.appSecret);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAccessToken"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/accessToken"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new GetAccessTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业accessToken(企业内部应用)</p>
     * 
     * @param request GetAccessTokenRequest
     * @return GetAccessTokenResponse
     */
    public GetAccessTokenResponse getAccessToken(GetAccessTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getAccessTokenWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业开通应用后的授权信息</p>
     * 
     * @param request GetAuthInfoRequest
     * @param headers GetAuthInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAuthInfoResponse
     */
    public GetAuthInfoResponse getAuthInfoWithOptions(GetAuthInfoRequest request, GetAuthInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCorpId)) {
            query.put("authCorpId", request.authCorpId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAuthInfo"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/apps/authInfo"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAuthInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业开通应用后的授权信息</p>
     * 
     * @param request GetAuthInfoRequest
     * @return GetAuthInfoResponse
     */
    public GetAuthInfoResponse getAuthInfo(GetAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAuthInfoHeaders headers = new GetAuthInfoHeaders();
        return this.getAuthInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业accessToken(应用商店应用)</p>
     * 
     * @param request GetCorpAccessTokenRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCorpAccessTokenResponse
     */
    public GetCorpAccessTokenResponse getCorpAccessTokenWithOptions(GetCorpAccessTokenRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCorpId)) {
            body.put("authCorpId", request.authCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteSecret)) {
            body.put("suiteSecret", request.suiteSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteTicket)) {
            body.put("suiteTicket", request.suiteTicket);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetCorpAccessToken"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/corpAccessToken"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new GetCorpAccessTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业accessToken(应用商店应用)</p>
     * 
     * @param request GetCorpAccessTokenRequest
     * @return GetCorpAccessTokenResponse
     */
    public GetCorpAccessTokenResponse getCorpAccessToken(GetCorpAccessTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getCorpAccessTokenWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询个人授权记录</p>
     * 
     * @param headers GetPersonalAuthRuleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPersonalAuthRuleResponse
     */
    public GetPersonalAuthRuleResponse getPersonalAuthRuleWithOptions(GetPersonalAuthRuleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetPersonalAuthRule"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/authRules/user"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPersonalAuthRuleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询个人授权记录</p>
     * @return GetPersonalAuthRuleResponse
     */
    public GetPersonalAuthRuleResponse getPersonalAuthRule() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPersonalAuthRuleHeaders headers = new GetPersonalAuthRuleHeaders();
        return this.getPersonalAuthRuleWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生成微应用管理后台accessToken</p>
     * 
     * @param request GetSsoAccessTokenRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSsoAccessTokenResponse
     */
    public GetSsoAccessTokenResponse getSsoAccessTokenWithOptions(GetSsoAccessTokenRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpid)) {
            body.put("corpid", request.corpid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ssoSecret)) {
            body.put("ssoSecret", request.ssoSecret);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSsoAccessToken"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/ssoAccessToken"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequest(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new GetSsoAccessTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生成微应用管理后台accessToken</p>
     * 
     * @param request GetSsoAccessTokenRequest
     * @return GetSsoAccessTokenResponse
     */
    public GetSsoAccessTokenResponse getSsoAccessToken(GetSsoAccessTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getSsoAccessTokenWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询微应用后台免登的用户信息</p>
     * 
     * @param request GetSsoUserInfoRequest
     * @param headers GetSsoUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSsoUserInfoResponse
     */
    public GetSsoUserInfoResponse getSsoUserInfoWithOptions(GetSsoUserInfoRequest request, GetSsoUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSsoUserInfo"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/ssoUserInfo"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSsoUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询微应用后台免登的用户信息</p>
     * 
     * @param request GetSsoUserInfoRequest
     * @return GetSsoUserInfoResponse
     */
    public GetSsoUserInfoResponse getSsoUserInfo(GetSsoUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSsoUserInfoHeaders headers = new GetSsoUserInfoHeaders();
        return this.getSsoUserInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取isvAccessToken（三方企业应用）</p>
     * 
     * @param request GetSuiteAccessTokenRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSuiteAccessTokenResponse
     */
    public GetSuiteAccessTokenResponse getSuiteAccessTokenWithOptions(GetSuiteAccessTokenRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteSecret)) {
            body.put("suiteSecret", request.suiteSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteTicket)) {
            body.put("suiteTicket", request.suiteTicket);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetSuiteAccessToken"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/suiteAccessToken"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequest(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new GetSuiteAccessTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取isvAccessToken（三方企业应用）</p>
     * 
     * @param request GetSuiteAccessTokenRequest
     * @return GetSuiteAccessTokenResponse
     */
    public GetSuiteAccessTokenResponse getSuiteAccessToken(GetSuiteAccessTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getSuiteAccessTokenWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取Access Token</p>
     * 
     * @param request GetTokenRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTokenResponse
     */
    public GetTokenResponse getTokenWithOptions(String corpId, GetTokenRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.clientId)) {
            body.put("client_id", request.clientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.clientSecret)) {
            body.put("client_secret", request.clientSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.grantType)) {
            body.put("grant_type", request.grantType);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetToken"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/" + corpId + "/token"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new GetTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取Access Token</p>
     * 
     * @param request GetTokenRequest
     * @return GetTokenResponse
     */
    public GetTokenResponse getToken(String corpId, GetTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getTokenWithOptions(corpId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户token</p>
     * 
     * @param request GetUserTokenRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserTokenResponse
     */
    public GetUserTokenResponse getUserTokenWithOptions(GetUserTokenRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.clientId)) {
            body.put("clientId", request.clientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.clientSecret)) {
            body.put("clientSecret", request.clientSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.grantType)) {
            body.put("grantType", request.grantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refreshToken)) {
            body.put("refreshToken", request.refreshToken);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserToken"),
            new TeaPair("version", "oauth2_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/oauth2/userAccessToken"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequest(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new GetUserTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户token</p>
     * 
     * @param request GetUserTokenRequest
     * @return GetUserTokenResponse
     */
    public GetUserTokenResponse getUserToken(GetUserTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getUserTokenWithOptions(request, headers, runtime);
    }
}
