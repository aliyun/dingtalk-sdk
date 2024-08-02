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
}
