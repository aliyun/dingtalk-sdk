// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkassistant_2_0.models.*;

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
     * <p>创建AI助理的消息体</p>
     * 
     * @param request CreateAssistantMessageRequest
     * @param headers CreateAssistantMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAssistantMessageResponse
     */
    public CreateAssistantMessageResponse createAssistantMessageWithOptions(String threadId, CreateAssistantMessageRequest request, CreateAssistantMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            query.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            query.put("role", request.role);
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
            new TeaPair("action", "CreateAssistantMessage"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads/" + threadId + "/messages"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAssistantMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建AI助理的消息体</p>
     * 
     * @param request CreateAssistantMessageRequest
     * @return CreateAssistantMessageResponse
     */
    public CreateAssistantMessageResponse createAssistantMessage(String threadId, CreateAssistantMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAssistantMessageHeaders headers = new CreateAssistantMessageHeaders();
        return this.createAssistantMessageWithOptions(threadId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建AI助理的运行任务</p>
     * 
     * @param headers CreateAssistantRunHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAssistantRunResponse
     */
    public CreateAssistantRunResponse createAssistantRunWithOptions(String threadId, CreateAssistantRunHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CreateAssistantRun"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads/" + threadId + "/runs"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAssistantRunResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建AI助理的运行任务</p>
     * @return CreateAssistantRunResponse
     */
    public CreateAssistantRunResponse createAssistantRun(String threadId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAssistantRunHeaders headers = new CreateAssistantRunHeaders();
        return this.createAssistantRunWithOptions(threadId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建AI助理线程实例</p>
     * 
     * @param headers CreateAssistantThreadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAssistantThreadResponse
     */
    public CreateAssistantThreadResponse createAssistantThreadWithOptions(CreateAssistantThreadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CreateAssistantThread"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAssistantThreadResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建AI助理线程实例</p>
     * @return CreateAssistantThreadResponse
     */
    public CreateAssistantThreadResponse createAssistantThread() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAssistantThreadHeaders headers = new CreateAssistantThreadHeaders();
        return this.createAssistantThreadWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除AI助理的消息体</p>
     * 
     * @param headers DeleteAssistantMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteAssistantMessageResponse
     */
    public DeleteAssistantMessageResponse deleteAssistantMessageWithOptions(String threadId, String messageId, DeleteAssistantMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteAssistantMessage"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads/" + threadId + "/messages/" + messageId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteAssistantMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除AI助理的消息体</p>
     * @return DeleteAssistantMessageResponse
     */
    public DeleteAssistantMessageResponse deleteAssistantMessage(String threadId, String messageId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteAssistantMessageHeaders headers = new DeleteAssistantMessageHeaders();
        return this.deleteAssistantMessageWithOptions(threadId, messageId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除AI助理线程实例</p>
     * 
     * @param headers DeleteAssistantThreadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteAssistantThreadResponse
     */
    public DeleteAssistantThreadResponse deleteAssistantThreadWithOptions(String threadId, DeleteAssistantThreadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteAssistantThread"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads/" + threadId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteAssistantThreadResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除AI助理线程实例</p>
     * @return DeleteAssistantThreadResponse
     */
    public DeleteAssistantThreadResponse deleteAssistantThread(String threadId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteAssistantThreadHeaders headers = new DeleteAssistantThreadHeaders();
        return this.deleteAssistantThreadWithOptions(threadId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取AI助理消息列表</p>
     * 
     * @param request ListAssistantMessageRequest
     * @param headers ListAssistantMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAssistantMessageResponse
     */
    public ListAssistantMessageResponse listAssistantMessageWithOptions(String threadId, ListAssistantMessageRequest request, ListAssistantMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.limit)) {
            query.put("limit", request.limit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.runId)) {
            query.put("runId", request.runId);
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
            new TeaPair("action", "ListAssistantMessage"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads/" + threadId + "/messages"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAssistantMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取AI助理消息列表</p>
     * 
     * @param request ListAssistantMessageRequest
     * @return ListAssistantMessageResponse
     */
    public ListAssistantMessageResponse listAssistantMessage(String threadId, ListAssistantMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAssistantMessageHeaders headers = new ListAssistantMessageHeaders();
        return this.listAssistantMessageWithOptions(threadId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取AI助理的消息体</p>
     * 
     * @param headers RetrieveAssistantMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RetrieveAssistantMessageResponse
     */
    public RetrieveAssistantMessageResponse retrieveAssistantMessageWithOptions(String threadId, String messageId, RetrieveAssistantMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "RetrieveAssistantMessage"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads/" + threadId + "/messages/" + messageId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RetrieveAssistantMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取AI助理的消息体</p>
     * @return RetrieveAssistantMessageResponse
     */
    public RetrieveAssistantMessageResponse retrieveAssistantMessage(String threadId, String messageId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetrieveAssistantMessageHeaders headers = new RetrieveAssistantMessageHeaders();
        return this.retrieveAssistantMessageWithOptions(threadId, messageId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>检索AI助理线程实例</p>
     * 
     * @param headers RetrieveAssistantThreadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RetrieveAssistantThreadResponse
     */
    public RetrieveAssistantThreadResponse retrieveAssistantThreadWithOptions(String threadId, RetrieveAssistantThreadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "RetrieveAssistantThread"),
            new TeaPair("version", "assistant_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/assistant/threads/" + threadId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RetrieveAssistantThreadResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>检索AI助理线程实例</p>
     * @return RetrieveAssistantThreadResponse
     */
    public RetrieveAssistantThreadResponse retrieveAssistantThread(String threadId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetrieveAssistantThreadHeaders headers = new RetrieveAssistantThreadHeaders();
        return this.retrieveAssistantThreadWithOptions(threadId, headers, runtime);
    }
}
