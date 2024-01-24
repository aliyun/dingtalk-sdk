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


    public ExecuteAgentResponse executeAgentWithOptions(ExecuteAgentRequest request, ExecuteAgentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agentCode)) {
            body.put("agentCode", request.agentCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inputs)) {
            body.put("inputs", request.inputs);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scenarioCode)) {
            body.put("scenarioCode", request.scenarioCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scenarioInstanceId)) {
            body.put("scenarioInstanceId", request.scenarioInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skillId)) {
            body.put("skillId", request.skillId);
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
            new TeaPair("action", "ExecuteAgent"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/me/agents/execute"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExecuteAgentResponse());
    }

    public ExecuteAgentResponse executeAgent(ExecuteAgentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExecuteAgentHeaders headers = new ExecuteAgentHeaders();
        return this.executeAgentWithOptions(request, headers, runtime);
    }

    public LiandanTextImageGetResponse liandanTextImageGetWithOptions(LiandanTextImageGetRequest request, LiandanTextImageGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.module)) {
            body.put("module", request.module);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "LiandanTextImageGet"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/ai/textToImage/results/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LiandanTextImageGetResponse());
    }

    public LiandanTextImageGetResponse liandanTextImageGet(LiandanTextImageGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LiandanTextImageGetHeaders headers = new LiandanTextImageGetHeaders();
        return this.liandanTextImageGetWithOptions(request, headers, runtime);
    }

    public LiandanluExclusiveModelResponse liandanluExclusiveModelWithOptions(LiandanluExclusiveModelRequest request, LiandanluExclusiveModelHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.modelId)) {
            body.put("modelId", request.modelId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.module)) {
            body.put("module", request.module);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prompt)) {
            body.put("prompt", request.prompt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "LiandanluExclusiveModel"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/ai/generate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LiandanluExclusiveModelResponse());
    }

    public LiandanluExclusiveModelResponse liandanluExclusiveModel(LiandanluExclusiveModelRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LiandanluExclusiveModelHeaders headers = new LiandanluExclusiveModelHeaders();
        return this.liandanluExclusiveModelWithOptions(request, headers, runtime);
    }

    public LiandanluTextToImageModelResponse liandanluTextToImageModelWithOptions(LiandanluTextToImageModelRequest request, LiandanluTextToImageModelHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.module)) {
            body.put("module", request.module);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.number)) {
            body.put("number", request.number);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parameters)) {
            body.put("parameters", request.parameters);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prompt)) {
            body.put("prompt", request.prompt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
            new TeaPair("action", "LiandanluTextToImageModel"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/ai/textToImage/generate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LiandanluTextToImageModelResponse());
    }

    public LiandanluTextToImageModelResponse liandanluTextToImageModel(LiandanluTextToImageModelRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LiandanluTextToImageModelHeaders headers = new LiandanluTextToImageModelHeaders();
        return this.liandanluTextToImageModelWithOptions(request, headers, runtime);
    }

    public QueryBaymaxSkillLogResponse queryBaymaxSkillLogWithOptions(QueryBaymaxSkillLogRequest request, QueryBaymaxSkillLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.from)) {
            query.put("from", request.from);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logLevel)) {
            query.put("logLevel", request.logLevel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.skillExecuteId)) {
            query.put("skillExecuteId", request.skillExecuteId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.to)) {
            query.put("to", request.to);
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
            new TeaPair("action", "QueryBaymaxSkillLog"),
            new TeaPair("version", "aiPaaS_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/aiPaaS/skills/logs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBaymaxSkillLogResponse());
    }

    public QueryBaymaxSkillLogResponse queryBaymaxSkillLog(QueryBaymaxSkillLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBaymaxSkillLogHeaders headers = new QueryBaymaxSkillLogHeaders();
        return this.queryBaymaxSkillLogWithOptions(request, headers, runtime);
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
