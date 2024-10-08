// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkalgo_1_0.models.*;

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
     * <p>自然语言处理之关键词识别</p>
     * 
     * @param request NlpWordDistinguishRequest
     * @param headers NlpWordDistinguishHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return NlpWordDistinguishResponse
     */
    public NlpWordDistinguishResponse nlpWordDistinguishWithOptions(NlpWordDistinguishRequest request, NlpWordDistinguishHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachExtractDecisionInfo)) {
            body.put("attachExtractDecisionInfo", request.attachExtractDecisionInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvAppId)) {
            body.put("isvAppId", request.isvAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
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
            new TeaPair("action", "NlpWordDistinguish"),
            new TeaPair("version", "algo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/algo/okrs/keywords/extract"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new NlpWordDistinguishResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>自然语言处理之关键词识别</p>
     * 
     * @param request NlpWordDistinguishRequest
     * @return NlpWordDistinguishResponse
     */
    public NlpWordDistinguishResponse nlpWordDistinguish(NlpWordDistinguishRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        NlpWordDistinguishHeaders headers = new NlpWordDistinguishHeaders();
        return this.nlpWordDistinguishWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>Okr内容推荐</p>
     * 
     * @param request OkrOpenRecommendRequest
     * @param headers OkrOpenRecommendHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OkrOpenRecommendResponse
     */
    public OkrOpenRecommendResponse okrOpenRecommendWithOptions(OkrOpenRecommendRequest request, OkrOpenRecommendHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.candidateOkrItems)) {
            body.put("candidateOkrItems", request.candidateOkrItems);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvAppId)) {
            body.put("isvAppId", request.isvAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.words)) {
            body.put("words", request.words);
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
            new TeaPair("action", "OkrOpenRecommend"),
            new TeaPair("version", "algo_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/algo/okrs/recommend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OkrOpenRecommendResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>Okr内容推荐</p>
     * 
     * @param request OkrOpenRecommendRequest
     * @return OkrOpenRecommendResponse
     */
    public OkrOpenRecommendResponse okrOpenRecommend(OkrOpenRecommendRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OkrOpenRecommendHeaders headers = new OkrOpenRecommendHeaders();
        return this.okrOpenRecommendWithOptions(request, headers, runtime);
    }
}
