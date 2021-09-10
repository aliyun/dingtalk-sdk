// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoauth2_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkoauth2_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public GetUserTokenResponse getUserToken(GetUserTokenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getUserTokenWithOptions(request, headers, runtime);
    }

    public GetUserTokenResponse getUserTokenWithOptions(GetUserTokenRequest request, java.util.Map<String, String> headers, RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.refreshToken)) {
            body.put("refreshToken", request.refreshToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.grantType)) {
            body.put("grantType", request.grantType);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetUserToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/userAccessToken", "json", req, runtime), new GetUserTokenResponse());
    }

    public GetAccessTokenResponse getAccessToken(GetAccessTokenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getAccessTokenWithOptions(request, headers, runtime);
    }

    public GetAccessTokenResponse getAccessTokenWithOptions(GetAccessTokenRequest request, java.util.Map<String, String> headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appSecret)) {
            body.put("appSecret", request.appSecret);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/accessToken", "json", req, runtime), new GetAccessTokenResponse());
    }

    public GetSuiteAccessTokenResponse getSuiteAccessToken(GetSuiteAccessTokenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getSuiteAccessTokenWithOptions(request, headers, runtime);
    }

    public GetSuiteAccessTokenResponse getSuiteAccessTokenWithOptions(GetSuiteAccessTokenRequest request, java.util.Map<String, String> headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetSuiteAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/suiteAccessToken", "json", req, runtime), new GetSuiteAccessTokenResponse());
    }

    public GetCorpAccessTokenResponse getCorpAccessToken(GetCorpAccessTokenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.getCorpAccessTokenWithOptions(request, headers, runtime);
    }

    public GetCorpAccessTokenResponse getCorpAccessTokenWithOptions(GetCorpAccessTokenRequest request, java.util.Map<String, String> headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteSecret)) {
            body.put("suiteSecret", request.suiteSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authCorpId)) {
            body.put("authCorpId", request.authCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteTicket)) {
            body.put("suiteTicket", request.suiteTicket);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetCorpAccessToken", "oauth2_1.0", "HTTP", "POST", "AK", "/v1.0/oauth2/corpAccessToken", "json", req, runtime), new GetCorpAccessTokenResponse());
    }

    public GetPersonalAuthRuleResponse getPersonalAuthRule() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetPersonalAuthRuleHeaders headers = new GetPersonalAuthRuleHeaders();
        return this.getPersonalAuthRuleWithOptions(headers, runtime);
    }

    public GetPersonalAuthRuleResponse getPersonalAuthRuleWithOptions(GetPersonalAuthRuleHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetPersonalAuthRule", "oauth2_1.0", "HTTP", "GET", "AK", "/v1.0/oauth2/authRules/user", "json", req, runtime), new GetPersonalAuthRuleResponse());
    }
}
