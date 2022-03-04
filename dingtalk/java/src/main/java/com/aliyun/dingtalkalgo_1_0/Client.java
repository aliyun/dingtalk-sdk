// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkalgo_1_0.models.*;
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


    public NlpWordDistinguishResponse nlpWordDistinguish(NlpWordDistinguishRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        NlpWordDistinguishHeaders headers = new NlpWordDistinguishHeaders();
        return this.nlpWordDistinguishWithOptions(request, headers, runtime);
    }

    public NlpWordDistinguishResponse nlpWordDistinguishWithOptions(NlpWordDistinguishRequest request, NlpWordDistinguishHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.attachExtractDecisionInfo))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("NlpWordDistinguish", "algo_1.0", "HTTP", "POST", "AK", "/v1.0/algo/okrs/keywords/extract", "json", req, runtime), new NlpWordDistinguishResponse());
    }

    public OkrOpenRecommendResponse okrOpenRecommend(OkrOpenRecommendRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        OkrOpenRecommendHeaders headers = new OkrOpenRecommendHeaders();
        return this.okrOpenRecommendWithOptions(request, headers, runtime);
    }

    public OkrOpenRecommendResponse okrOpenRecommendWithOptions(OkrOpenRecommendRequest request, OkrOpenRecommendHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("OkrOpenRecommend", "algo_1.0", "HTTP", "POST", "AK", "/v1.0/algo/okrs/recommend", "json", req, runtime), new OkrOpenRecommendResponse());
    }
}
