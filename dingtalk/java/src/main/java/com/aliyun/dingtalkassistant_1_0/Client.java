// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkassistant_1_0.models.*;

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
     * <p>助理添加专业词汇</p>
     * 
     * @param request AddDomainWordsRequest
     * @param headers AddDomainWordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddDomainWordsResponse
     */
    public AddDomainWordsResponse addDomainWordsWithOptions(AddDomainWordsRequest request, AddDomainWordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            body.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.domainWords)) {
            body.put("domainWords", request.domainWords);
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
            new TeaPair("action", "AddDomainWords"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/domainWords"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddDomainWordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>助理添加专业词汇</p>
     * 
     * @param request AddDomainWordsRequest
     * @return AddDomainWordsResponse
     */
    public AddDomainWordsResponse addDomainWords(AddDomainWordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddDomainWordsHeaders headers = new AddDomainWordsHeaders();
        return this.addDomainWordsWithOptions(request, headers, runtime);
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
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.metadata)) {
            body.put("metadata", request.metadata);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
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
            new TeaPair("action", "CreateAssistantMessage"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + "/messages"),
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
     * @param request CreateAssistantRunRequest
     * @param headers CreateAssistantRunHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAssistantRunResponse
     */
    public CreateAssistantRunResponse createAssistantRunWithOptions(String threadId, CreateAssistantRunRequest request, CreateAssistantRunHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            body.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instructions)) {
            body.put("instructions", request.instructions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.metadata)) {
            body.put("metadata", request.metadata);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stream)) {
            body.put("stream", request.stream);
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
            new TeaPair("action", "CreateAssistantRun"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + "/runs"),
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
     * 
     * @param request CreateAssistantRunRequest
     * @return CreateAssistantRunResponse
     */
    public CreateAssistantRunResponse createAssistantRun(String threadId, CreateAssistantRunRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAssistantRunHeaders headers = new CreateAssistantRunHeaders();
        return this.createAssistantRunWithOptions(threadId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建AI助理线程实例</p>
     * 
     * @param request CreateAssistantThreadRequest
     * @param headers CreateAssistantThreadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAssistantThreadResponse
     */
    public CreateAssistantThreadResponse createAssistantThreadWithOptions(CreateAssistantThreadRequest request, CreateAssistantThreadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.metadata)) {
            body.put("metadata", request.metadata);
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
            new TeaPair("action", "CreateAssistantThread"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads"),
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
     * 
     * @param request CreateAssistantThreadRequest
     * @return CreateAssistantThreadResponse
     */
    public CreateAssistantThreadResponse createAssistantThread(CreateAssistantThreadRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAssistantThreadHeaders headers = new CreateAssistantThreadHeaders();
        return this.createAssistantThreadWithOptions(request, headers, runtime);
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
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + "/messages/" + messageId + ""),
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
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + ""),
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
     * <p>助理删除专业词汇</p>
     * 
     * @param request DeleteDomainWordsRequest
     * @param headers DeleteDomainWordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDomainWordsResponse
     */
    public DeleteDomainWordsResponse deleteDomainWordsWithOptions(DeleteDomainWordsRequest request, DeleteDomainWordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            body.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.domainWords)) {
            body.put("domainWords", request.domainWords);
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
            new TeaPair("action", "DeleteDomainWords"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/domainWords/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDomainWordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>助理删除专业词汇</p>
     * 
     * @param request DeleteDomainWordsRequest
     * @return DeleteDomainWordsResponse
     */
    public DeleteDomainWordsResponse deleteDomainWords(DeleteDomainWordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDomainWordsHeaders headers = new DeleteDomainWordsHeaders();
        return this.deleteDomainWordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除助理知识</p>
     * 
     * @param request DeleteKnowledgeRequest
     * @param headers DeleteKnowledgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteKnowledgeResponse
     */
    public DeleteKnowledgeResponse deleteKnowledgeWithOptions(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            query.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studyId)) {
            query.put("studyId", request.studyId);
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
            new TeaPair("action", "DeleteKnowledge"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/knowledges/items"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteKnowledgeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除助理知识</p>
     * 
     * @param request DeleteKnowledgeRequest
     * @return DeleteKnowledgeResponse
     */
    public DeleteKnowledgeResponse deleteKnowledge(DeleteKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
        return this.deleteKnowledgeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取助理问答明细</p>
     * 
     * @param request GetAskDetailRequest
     * @param headers GetAskDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAskDetailResponse
     */
    public GetAskDetailResponse getAskDetailWithOptions(GetAskDetailRequest request, GetAskDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            query.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            query.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
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
            new TeaPair("action", "GetAskDetail"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/askDetails"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAskDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取助理问答明细</p>
     * 
     * @param request GetAskDetailRequest
     * @return GetAskDetailResponse
     */
    public GetAskDetailResponse getAskDetail(GetAskDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAskDetailHeaders headers = new GetAskDetailHeaders();
        return this.getAskDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取助理专业词汇</p>
     * 
     * @param request GetDomainWordsRequest
     * @param headers GetDomainWordsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDomainWordsResponse
     */
    public GetDomainWordsResponse getDomainWordsWithOptions(GetDomainWordsRequest request, GetDomainWordsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            query.put("assistantId", request.assistantId);
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
            new TeaPair("action", "GetDomainWords"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/domainWords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDomainWordsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取助理专业词汇</p>
     * 
     * @param request GetDomainWordsRequest
     * @return GetDomainWordsResponse
     */
    public GetDomainWordsResponse getDomainWords(GetDomainWordsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDomainWordsHeaders headers = new GetDomainWordsHeaders();
        return this.getDomainWordsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取助理知识列表</p>
     * 
     * @param request GetKnowledgeListRequest
     * @param headers GetKnowledgeListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetKnowledgeListResponse
     */
    public GetKnowledgeListResponse getKnowledgeListWithOptions(GetKnowledgeListRequest request, GetKnowledgeListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            query.put("assistantId", request.assistantId);
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
            new TeaPair("action", "GetKnowledgeList"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/knowledges/items"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetKnowledgeListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取助理知识列表</p>
     * 
     * @param request GetKnowledgeListRequest
     * @return GetKnowledgeListResponse
     */
    public GetKnowledgeListResponse getKnowledgeList(GetKnowledgeListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetKnowledgeListHeaders headers = new GetKnowledgeListHeaders();
        return this.getKnowledgeListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>安装助理</p>
     * 
     * @param request InstallAssistantRequest
     * @param headers InstallAssistantHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InstallAssistantResponse
     */
    public InstallAssistantResponse installAssistantWithOptions(InstallAssistantRequest request, InstallAssistantHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            body.put("assistantId", request.assistantId);
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
            new TeaPair("action", "InstallAssistant"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/install"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InstallAssistantResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>安装助理</p>
     * 
     * @param request InstallAssistantRequest
     * @return InstallAssistantResponse
     */
    public InstallAssistantResponse installAssistant(InstallAssistantRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InstallAssistantHeaders headers = new InstallAssistantHeaders();
        return this.installAssistantWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>助理学习知识</p>
     * 
     * @param request LearnKnowledgeRequest
     * @param headers LearnKnowledgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LearnKnowledgeResponse
     */
    public LearnKnowledgeResponse learnKnowledgeWithOptions(LearnKnowledgeRequest request, LearnKnowledgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            body.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.docUrl)) {
            body.put("docUrl", request.docUrl);
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
            new TeaPair("action", "LearnKnowledge"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/knowledges/items"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LearnKnowledgeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>助理学习知识</p>
     * 
     * @param request LearnKnowledgeRequest
     * @return LearnKnowledgeResponse
     */
    public LearnKnowledgeResponse learnKnowledge(LearnKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LearnKnowledgeHeaders headers = new LearnKnowledgeHeaders();
        return this.learnKnowledgeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取AI助理列表</p>
     * 
     * @param request ListAssistantRequest
     * @param headers ListAssistantHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAssistantResponse
     */
    public ListAssistantResponse listAssistantWithOptions(ListAssistantRequest request, ListAssistantHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "ListAssistant"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/list"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAssistantResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取AI助理列表</p>
     * 
     * @param request ListAssistantRequest
     * @return ListAssistantResponse
     */
    public ListAssistantResponse listAssistant(ListAssistantRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAssistantHeaders headers = new ListAssistantHeaders();
        return this.listAssistantWithOptions(request, headers, runtime);
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

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            query.put("order", request.order);
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
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + "/messages"),
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
     * <p>获取AI助理的运行任务的列表</p>
     * 
     * @param request ListAssistantRunRequest
     * @param headers ListAssistantRunHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAssistantRunResponse
     */
    public ListAssistantRunResponse listAssistantRunWithOptions(String threadId, ListAssistantRunRequest request, ListAssistantRunHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.limit)) {
            query.put("limit", request.limit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            query.put("order", request.order);
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
            new TeaPair("action", "ListAssistantRun"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + "/runs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAssistantRunResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取AI助理的运行任务的列表</p>
     * 
     * @param request ListAssistantRunRequest
     * @return ListAssistantRunResponse
     */
    public ListAssistantRunResponse listAssistantRun(String threadId, ListAssistantRunRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAssistantRunHeaders headers = new ListAssistantRunHeaders();
        return this.listAssistantRunWithOptions(threadId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>助理学习增量知识</p>
     * 
     * @param request RelearnKnowledgeRequest
     * @param headers RelearnKnowledgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RelearnKnowledgeResponse
     */
    public RelearnKnowledgeResponse relearnKnowledgeWithOptions(RelearnKnowledgeRequest request, RelearnKnowledgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            body.put("assistantId", request.assistantId);
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
            new TeaPair("action", "RelearnKnowledge"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/knowledges/incrLearning"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RelearnKnowledgeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>助理学习增量知识</p>
     * 
     * @param request RelearnKnowledgeRequest
     * @return RelearnKnowledgeResponse
     */
    public RelearnKnowledgeResponse relearnKnowledge(RelearnKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RelearnKnowledgeHeaders headers = new RelearnKnowledgeHeaders();
        return this.relearnKnowledgeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询 AI 助理的基本信息</p>
     * 
     * @param request RetrieveAssistantBasicInfoRequest
     * @param headers RetrieveAssistantBasicInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RetrieveAssistantBasicInfoResponse
     */
    public RetrieveAssistantBasicInfoResponse retrieveAssistantBasicInfoWithOptions(RetrieveAssistantBasicInfoRequest request, RetrieveAssistantBasicInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            query.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "RetrieveAssistantBasicInfo"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/basicInfo"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RetrieveAssistantBasicInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询 AI 助理的基本信息</p>
     * 
     * @param request RetrieveAssistantBasicInfoRequest
     * @return RetrieveAssistantBasicInfoResponse
     */
    public RetrieveAssistantBasicInfoResponse retrieveAssistantBasicInfo(RetrieveAssistantBasicInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetrieveAssistantBasicInfoHeaders headers = new RetrieveAssistantBasicInfoHeaders();
        return this.retrieveAssistantBasicInfoWithOptions(request, headers, runtime);
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
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + "/messages/" + messageId + ""),
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
     * <p>检索AI助理的运行任务</p>
     * 
     * @param headers RetrieveAssistantRunHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RetrieveAssistantRunResponse
     */
    public RetrieveAssistantRunResponse retrieveAssistantRunWithOptions(String threadId, String runId, RetrieveAssistantRunHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "RetrieveAssistantRun"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + "/runs/" + runId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RetrieveAssistantRunResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>检索AI助理的运行任务</p>
     * @return RetrieveAssistantRunResponse
     */
    public RetrieveAssistantRunResponse retrieveAssistantRun(String threadId, String runId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetrieveAssistantRunHeaders headers = new RetrieveAssistantRunHeaders();
        return this.retrieveAssistantRunWithOptions(threadId, runId, headers, runtime);
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
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/threads/" + threadId + ""),
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

    /**
     * <b>summary</b> : 
     * <p>更新 AI 助理使用范围</p>
     * 
     * @param request UpdateAssistantScopeRequest
     * @param headers UpdateAssistantScopeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateAssistantScopeResponse
     */
    public UpdateAssistantScopeResponse updateAssistantScopeWithOptions(UpdateAssistantScopeRequest request, UpdateAssistantScopeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.assistantId)) {
            body.put("assistantId", request.assistantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sharing)) {
            body.put("sharing", request.sharing);
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
            new TeaPair("action", "UpdateAssistantScope"),
            new TeaPair("version", "assistant_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/assistant/scope"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "any")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateAssistantScopeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新 AI 助理使用范围</p>
     * 
     * @param request UpdateAssistantScopeRequest
     * @return UpdateAssistantScopeResponse
     */
    public UpdateAssistantScopeResponse updateAssistantScope(UpdateAssistantScopeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateAssistantScopeHeaders headers = new UpdateAssistantScopeHeaders();
        return this.updateAssistantScopeWithOptions(request, headers, runtime);
    }
}
