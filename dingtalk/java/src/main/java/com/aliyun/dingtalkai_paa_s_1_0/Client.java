// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_paa_s_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkai_paa_s_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public QueryConversationMessageForAIResponse queryConversationMessageForAIWithOptions(String cid, QueryConversationMessageForAIRequest tmpReq, QueryConversationMessageForAIHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryConversationMessageForAIShrinkRequest request = new QueryConversationMessageForAIShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.openMsgIds)) {
            request.openMsgIdsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.openMsgIds, "openMsgIds", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openMsgIdsShrink)) {
            query.put("openMsgIds", request.openMsgIdsShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recentDays)) {
            query.put("recentDays", request.recentDays);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recentHours)) {
            query.put("recentHours", request.recentHours);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recentN)) {
            query.put("recentN", request.recentN);
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
            new TeaPair("action", "QueryConversationMessageForAI"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/me/memory/im/" + cid + "/messages"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryConversationMessageForAIResponse());
    }

    public QueryConversationMessageForAIResponse queryConversationMessageForAI(String cid, QueryConversationMessageForAIRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryConversationMessageForAIHeaders headers = new QueryConversationMessageForAIHeaders();
        return this.queryConversationMessageForAIWithOptions(cid, request, headers, runtime);
    }

    public QueryMemoryLearningTaskResponse queryMemoryLearningTaskWithOptions(QueryMemoryLearningTaskRequest request, QueryMemoryLearningTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentCode)) {
            query.put("agentCode", request.agentCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.learningCode)) {
            query.put("learningCode", request.learningCode);
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
            new TeaPair("action", "QueryMemoryLearningTask"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/me/memory/learningTask/get"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMemoryLearningTaskResponse());
    }

    public QueryMemoryLearningTaskResponse queryMemoryLearningTask(QueryMemoryLearningTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMemoryLearningTaskHeaders headers = new QueryMemoryLearningTaskHeaders();
        return this.queryMemoryLearningTaskWithOptions(request, headers, runtime);
    }

    public SubmitMemoryLearningTaskResponse submitMemoryLearningTaskWithOptions(SubmitMemoryLearningTaskRequest tmpReq, SubmitMemoryLearningTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        SubmitMemoryLearningTaskShrinkRequest request = new SubmitMemoryLearningTaskShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.content)) {
            request.contentShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.content, "content", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentCode)) {
            query.put("agentCode", request.agentCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contentShrink)) {
            query.put("content", request.contentShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.learningMode)) {
            query.put("learningMode", request.learningMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memoryKey)) {
            query.put("memoryKey", request.memoryKey);
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
            new TeaPair("action", "SubmitMemoryLearningTask"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/me/memory/learningTask/put"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubmitMemoryLearningTaskResponse());
    }

    public SubmitMemoryLearningTaskResponse submitMemoryLearningTask(SubmitMemoryLearningTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubmitMemoryLearningTaskHeaders headers = new SubmitMemoryLearningTaskHeaders();
        return this.submitMemoryLearningTaskWithOptions(request, headers, runtime);
    }
}
