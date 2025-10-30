// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkai_global_e_c_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>全渠道运营客服tiktok消息接入</p>
     * 
     * @param request ConnectionOmniChannelTiktokMessageRequest
     * @param headers ConnectionOmniChannelTiktokMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConnectionOmniChannelTiktokMessageResponse
     */
    public ConnectionOmniChannelTiktokMessageResponse connectionOmniChannelTiktokMessageWithOptions(ConnectionOmniChannelTiktokMessageRequest request, ConnectionOmniChannelTiktokMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tiktokContentJsonString)) {
            body.put("tiktokContentJsonString", request.tiktokContentJsonString);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ConnectionOmniChannelTiktokMessage"),
            new TeaPair("version", "aiGlobalEC_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiGlobalEC/omniChannel/tiktok/im/message/process"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConnectionOmniChannelTiktokMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>全渠道运营客服tiktok消息接入</p>
     * 
     * @param request ConnectionOmniChannelTiktokMessageRequest
     * @return ConnectionOmniChannelTiktokMessageResponse
     */
    public ConnectionOmniChannelTiktokMessageResponse connectionOmniChannelTiktokMessage(ConnectionOmniChannelTiktokMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConnectionOmniChannelTiktokMessageHeaders headers = new ConnectionOmniChannelTiktokMessageHeaders();
        return this.connectionOmniChannelTiktokMessageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前登录用户版本信息</p>
     * 
     * @param request GetLoginUserRequest
     * @param headers GetLoginUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetLoginUserResponse
     */
    public GetLoginUserResponse getLoginUserWithOptions(GetLoginUserRequest request, GetLoginUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetLoginUser"),
            new TeaPair("version", "aiGlobalEC_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiGlobalEC/authCode/getLoginUser"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetLoginUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前登录用户版本信息</p>
     * 
     * @param request GetLoginUserRequest
     * @return GetLoginUserResponse
     */
    public GetLoginUserResponse getLoginUser(GetLoginUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetLoginUserHeaders headers = new GetLoginUserHeaders();
        return this.getLoginUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>刊登的对外开放Api</p>
     * 
     * @param request LaunchRequest
     * @param headers LaunchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LaunchResponse
     */
    public LaunchResponse launchWithOptions(LaunchRequest request, LaunchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingAgentId)) {
            query.put("dingAgentId", request.dingAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingClientId)) {
            query.put("dingClientId", request.dingClientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            query.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            query.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            query.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            query.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingUid)) {
            query.put("dingUid", request.dingUid);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imageUrls)) {
            body.put("imageUrls", request.imageUrls);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platform)) {
            body.put("platform", request.platform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sellingPoints)) {
            body.put("sellingPoints", request.sellingPoints);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceData)) {
            body.put("sourceData", request.sourceData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.variants)) {
            body.put("variants", request.variants);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.videoUrls)) {
            body.put("videoUrls", request.videoUrls);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "Launch"),
            new TeaPair("version", "aiGlobalEC_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiGlobalEC/launch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LaunchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>刊登的对外开放Api</p>
     * 
     * @param request LaunchRequest
     * @return LaunchResponse
     */
    public LaunchResponse launch(LaunchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LaunchHeaders headers = new LaunchHeaders();
        return this.launchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>全渠道AI表格业务信息</p>
     * 
     * @param request QueryNotableInfoRequest
     * @param headers QueryNotableInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryNotableInfoResponse
     */
    public QueryNotableInfoResponse queryNotableInfoWithOptions(QueryNotableInfoRequest request, QueryNotableInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sceneCode)) {
            query.put("sceneCode", request.sceneCode);
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
            new TeaPair("action", "QueryNotableInfo"),
            new TeaPair("version", "aiGlobalEC_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiGlobalEC/omniChannel/notable"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryNotableInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>全渠道AI表格业务信息</p>
     * 
     * @param request QueryNotableInfoRequest
     * @return QueryNotableInfoResponse
     */
    public QueryNotableInfoResponse queryNotableInfo(QueryNotableInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryNotableInfoHeaders headers = new QueryNotableInfoHeaders();
        return this.queryNotableInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>平台店铺授权回调</p>
     * 
     * @param request TiktokShopAuthCallbackRequest
     * @param headers TiktokShopAuthCallbackHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TiktokShopAuthCallbackResponse
     */
    public TiktokShopAuthCallbackResponse tiktokShopAuthCallbackWithOptions(TiktokShopAuthCallbackRequest request, TiktokShopAuthCallbackHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.sellerType)) {
            body.put("sellerType", request.sellerType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shopId)) {
            body.put("shopId", request.shopId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shopName)) {
            body.put("shopName", request.shopName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shopRegion)) {
            body.put("shopRegion", request.shopRegion);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TiktokShopAuthCallback"),
            new TeaPair("version", "aiGlobalEC_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiGlobalEC/omniChannel/tiktok/shop/authCallback"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TiktokShopAuthCallbackResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>平台店铺授权回调</p>
     * 
     * @param request TiktokShopAuthCallbackRequest
     * @return TiktokShopAuthCallbackResponse
     */
    public TiktokShopAuthCallbackResponse tiktokShopAuthCallback(TiktokShopAuthCallbackRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TiktokShopAuthCallbackHeaders headers = new TiktokShopAuthCallbackHeaders();
        return this.tiktokShopAuthCallbackWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>全渠道运营Tiktok的Webhook信息写入</p>
     * 
     * @param request TiktokWebhookProcessRequest
     * @param headers TiktokWebhookProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TiktokWebhookProcessResponse
     */
    public TiktokWebhookProcessResponse tiktokWebhookProcessWithOptions(TiktokWebhookProcessRequest request, TiktokWebhookProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tiktokContentJsonString)) {
            body.put("tiktokContentJsonString", request.tiktokContentJsonString);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TiktokWebhookProcess"),
            new TeaPair("version", "aiGlobalEC_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiGlobalEC/omniChannel/tiktok/webhook/process"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TiktokWebhookProcessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>全渠道运营Tiktok的Webhook信息写入</p>
     * 
     * @param request TiktokWebhookProcessRequest
     * @return TiktokWebhookProcessResponse
     */
    public TiktokWebhookProcessResponse tiktokWebhookProcess(TiktokWebhookProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TiktokWebhookProcessHeaders headers = new TiktokWebhookProcessHeaders();
        return this.tiktokWebhookProcessWithOptions(request, headers, runtime);
    }
}
