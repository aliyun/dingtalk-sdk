// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkservice_group_1_0.models.*;
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


    public AddKnowledgeResponse addKnowledge(AddKnowledgeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddKnowledgeHeaders headers = new AddKnowledgeHeaders();
        return this.addKnowledgeWithOptions(request, headers, runtime);
    }

    public AddKnowledgeResponse addKnowledgeWithOptions(AddKnowledgeRequest request, AddKnowledgeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachmentList)) {
            body.put("attachmentList", request.attachmentList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.effectTimeend)) {
            body.put("effectTimeend", request.effectTimeend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.effectTimestart)) {
            body.put("effectTimestart", request.effectTimestart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extTitle)) {
            body.put("extTitle", request.extTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            body.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.libraryKey)) {
            body.put("libraryKey", request.libraryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.linkUrl)) {
            body.put("linkUrl", request.linkUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourcePrimaryKey)) {
            body.put("sourcePrimaryKey", request.sourcePrimaryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
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
        return TeaModel.toModel(this.doROARequest("AddKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges", "json", req, runtime), new AddKnowledgeResponse());
    }

    public AddLibraryResponse addLibrary(AddLibraryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddLibraryHeaders headers = new AddLibraryHeaders();
        return this.addLibraryWithOptions(request, headers, runtime);
    }

    public AddLibraryResponse addLibraryWithOptions(AddLibraryRequest request, AddLibraryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamIds)) {
            body.put("openTeamIds", request.openTeamIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourcePrimaryKey)) {
            body.put("sourcePrimaryKey", request.sourcePrimaryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/librarys", "json", req, runtime), new AddLibraryResponse());
    }

    public AddOpenCategoryResponse addOpenCategory(AddOpenCategoryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddOpenCategoryHeaders headers = new AddOpenCategoryHeaders();
        return this.addOpenCategoryWithOptions(request, headers, runtime);
    }

    public AddOpenCategoryResponse addOpenCategoryWithOptions(AddOpenCategoryRequest request, AddOpenCategoryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.libraryId)) {
            body.put("libraryId", request.libraryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            body.put("userName", request.userName);
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
        return TeaModel.toModel(this.doROARequest("AddOpenCategory", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openCategories", "json", req, runtime), new AddOpenCategoryResponse());
    }

    public AddOpenKnowledgeResponse addOpenKnowledge(AddOpenKnowledgeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddOpenKnowledgeHeaders headers = new AddOpenKnowledgeHeaders();
        return this.addOpenKnowledgeWithOptions(request, headers, runtime);
    }

    public AddOpenKnowledgeResponse addOpenKnowledgeWithOptions(AddOpenKnowledgeRequest request, AddOpenKnowledgeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachments)) {
            body.put("attachments", request.attachments);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.categoryId)) {
            body.put("categoryId", request.categoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.effectTimeend)) {
            body.put("effectTimeend", request.effectTimeend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.effectTimestart)) {
            body.put("effectTimestart", request.effectTimestart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extTitle)) {
            body.put("extTitle", request.extTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            body.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.libraryId)) {
            body.put("libraryId", request.libraryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tags)) {
            body.put("tags", request.tags);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            body.put("userName", request.userName);
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
        return TeaModel.toModel(this.doROARequest("AddOpenKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openKnowledges", "json", req, runtime), new AddOpenKnowledgeResponse());
    }

    public AddOpenLibraryResponse addOpenLibrary(AddOpenLibraryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddOpenLibraryHeaders headers = new AddOpenLibraryHeaders();
        return this.addOpenLibraryWithOptions(request, headers, runtime);
    }

    public AddOpenLibraryResponse addOpenLibraryWithOptions(AddOpenLibraryRequest request, AddOpenLibraryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            body.put("userName", request.userName);
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
        return TeaModel.toModel(this.doROARequest("AddOpenLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/openLibraries", "json", req, runtime), new AddOpenLibraryResponse());
    }

    public AddTicketMemoResponse addTicketMemo(AddTicketMemoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddTicketMemoHeaders headers = new AddTicketMemoHeaders();
        return this.addTicketMemoWithOptions(request, headers, runtime);
    }

    public AddTicketMemoResponse addTicketMemoWithOptions(AddTicketMemoRequest request, AddTicketMemoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionId)) {
            body.put("processorUnionId", request.processorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("AddTicketMemo", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/memos", "none", req, runtime), new AddTicketMemoResponse());
    }

    public AssignTicketResponse assignTicket(AssignTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AssignTicketHeaders headers = new AssignTicketHeaders();
        return this.assignTicketWithOptions(request, headers, runtime);
    }

    public AssignTicketResponse assignTicketWithOptions(AssignTicketRequest request, AssignTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notify))) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionIds)) {
            body.put("processorUnionIds", request.processorUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("AssignTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/assign", "none", req, runtime), new AssignTicketResponse());
    }

    public BatchBindingGroupBizIdsResponse batchBindingGroupBizIds(BatchBindingGroupBizIdsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchBindingGroupBizIdsHeaders headers = new BatchBindingGroupBizIdsHeaders();
        return this.batchBindingGroupBizIdsWithOptions(request, headers, runtime);
    }

    public BatchBindingGroupBizIdsResponse batchBindingGroupBizIdsWithOptions(BatchBindingGroupBizIdsRequest request, BatchBindingGroupBizIdsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bindingGroupBizIds)) {
            body.put("bindingGroupBizIds", request.bindingGroupBizIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("BatchBindingGroupBizIds", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/bind", "json", req, runtime), new BatchBindingGroupBizIdsResponse());
    }

    public BatchGetGroupSetConfigResponse batchGetGroupSetConfig(BatchGetGroupSetConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchGetGroupSetConfigHeaders headers = new BatchGetGroupSetConfigHeaders();
        return this.batchGetGroupSetConfigWithOptions(request, headers, runtime);
    }

    public BatchGetGroupSetConfigResponse batchGetGroupSetConfigWithOptions(BatchGetGroupSetConfigRequest request, BatchGetGroupSetConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.configKeys)) {
            body.put("configKeys", request.configKeys);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("BatchGetGroupSetConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groupSetConfigs/batchQuery", "json", req, runtime), new BatchGetGroupSetConfigResponse());
    }

    public BatchQuerySendMessageTaskResponse batchQuerySendMessageTask(BatchQuerySendMessageTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchQuerySendMessageTaskHeaders headers = new BatchQuerySendMessageTaskHeaders();
        return this.batchQuerySendMessageTaskWithOptions(request, headers, runtime);
    }

    public BatchQuerySendMessageTaskResponse batchQuerySendMessageTaskWithOptions(BatchQuerySendMessageTaskRequest request, BatchQuerySendMessageTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.getReadCount)) {
            body.put("getReadCount", request.getReadCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtCreateEnd)) {
            body.put("gmtCreateEnd", request.gmtCreateEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtCreateStart)) {
            body.put("gmtCreateStart", request.gmtCreateStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskName)) {
            body.put("taskName", request.taskName);
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
        return TeaModel.toModel(this.doROARequest("BatchQuerySendMessageTask", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/query", "json", req, runtime), new BatchQuerySendMessageTaskResponse());
    }

    public BoundTemplateToTeamResponse boundTemplateToTeam(BoundTemplateToTeamRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BoundTemplateToTeamHeaders headers = new BoundTemplateToTeamHeaders();
        return this.boundTemplateToTeamWithOptions(request, headers, runtime);
    }

    public BoundTemplateToTeamResponse boundTemplateToTeamWithOptions(BoundTemplateToTeamRequest request, BoundTemplateToTeamHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotConfig)) {
            body.put("robotConfig", request.robotConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateDesc)) {
            body.put("templateDesc", request.templateDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateName)) {
            body.put("templateName", request.templateName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateType)) {
            body.put("templateType", request.templateType);
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
        return TeaModel.toModel(this.doROARequest("BoundTemplateToTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/teams/templates/bound", "json", req, runtime), new BoundTemplateToTeamResponse());
    }

    public CancelTicketResponse cancelTicket(CancelTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CancelTicketHeaders headers = new CancelTicketHeaders();
        return this.cancelTicketWithOptions(request, headers, runtime);
    }

    public CancelTicketResponse cancelTicketWithOptions(CancelTicketRequest request, CancelTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notify))) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("CancelTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/cancel", "none", req, runtime), new CancelTicketResponse());
    }

    public CategoryStatisticsResponse categoryStatistics(CategoryStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CategoryStatisticsHeaders headers = new CategoryStatisticsHeaders();
        return this.categoryStatisticsWithOptions(request, headers, runtime);
    }

    public CategoryStatisticsResponse categoryStatisticsWithOptions(CategoryStatisticsRequest request, CategoryStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            query.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            query.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/categories/statistics", "json", req, runtime), new CategoryStatisticsResponse());
    }

    public CloseConversationResponse closeConversation(CloseConversationRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CloseConversationHeaders headers = new CloseConversationHeaders();
        return this.closeConversationWithOptions(request, headers, runtime);
    }

    public CloseConversationResponse closeConversationWithOptions(CloseConversationRequest request, CloseConversationHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serverTips)) {
            body.put("serverTips", request.serverTips);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceToken)) {
            body.put("serviceToken", request.serviceToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetChannel)) {
            body.put("targetChannel", request.targetChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visitorToken)) {
            body.put("visitorToken", request.visitorToken);
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
        return TeaModel.toModel(this.doROARequest("CloseConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/conversions", "json", req, runtime), new CloseConversationResponse());
    }

    public CloseHumanSessionResponse closeHumanSession(CloseHumanSessionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CloseHumanSessionHeaders headers = new CloseHumanSessionHeaders();
        return this.closeHumanSessionWithOptions(request, headers, runtime);
    }

    public CloseHumanSessionResponse closeHumanSessionWithOptions(CloseHumanSessionRequest request, CloseHumanSessionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("CloseHumanSession", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/humanSessions/close", "json", req, runtime), new CloseHumanSessionResponse());
    }

    public ConversationCreatedNotifyResponse conversationCreatedNotify(ConversationCreatedNotifyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ConversationCreatedNotifyHeaders headers = new ConversationCreatedNotifyHeaders();
        return this.conversationCreatedNotifyWithOptions(request, headers, runtime);
    }

    public ConversationCreatedNotifyResponse conversationCreatedNotifyWithOptions(ConversationCreatedNotifyRequest request, ConversationCreatedNotifyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.alipayUserId)) {
            body.put("alipayUserId", request.alipayUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nickName)) {
            body.put("nickName", request.nickName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serverName)) {
            body.put("serverName", request.serverName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serverTips)) {
            body.put("serverTips", request.serverTips);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceToken)) {
            body.put("serviceToken", request.serviceToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeoutRemindTips)) {
            body.put("timeoutRemindTips", request.timeoutRemindTips);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visitorToken)) {
            body.put("visitorToken", request.visitorToken);
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
        return TeaModel.toModel(this.doROARequest("ConversationCreatedNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers", "json", req, runtime), new ConversationCreatedNotifyResponse());
    }

    public ConversationTransferBeginNotifyResponse conversationTransferBeginNotify(ConversationTransferBeginNotifyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ConversationTransferBeginNotifyHeaders headers = new ConversationTransferBeginNotifyHeaders();
        return this.conversationTransferBeginNotifyWithOptions(request, headers, runtime);
    }

    public ConversationTransferBeginNotifyResponse conversationTransferBeginNotifyWithOptions(ConversationTransferBeginNotifyRequest request, ConversationTransferBeginNotifyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memo)) {
            body.put("memo", request.memo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceToken)) {
            body.put("serviceToken", request.serviceToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceSkillGroupId)) {
            body.put("sourceSkillGroupId", request.sourceSkillGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSkillGroupId)) {
            body.put("targetSkillGroupId", request.targetSkillGroupId);
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
        return TeaModel.toModel(this.doROARequest("ConversationTransferBeginNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/transfers", "json", req, runtime), new ConversationTransferBeginNotifyResponse());
    }

    public ConversationTransferCompleteNotifyResponse conversationTransferCompleteNotify(ConversationTransferCompleteNotifyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ConversationTransferCompleteNotifyHeaders headers = new ConversationTransferCompleteNotifyHeaders();
        return this.conversationTransferCompleteNotifyWithOptions(request, headers, runtime);
    }

    public ConversationTransferCompleteNotifyResponse conversationTransferCompleteNotifyWithOptions(ConversationTransferCompleteNotifyRequest request, ConversationTransferCompleteNotifyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.alipayUserId)) {
            body.put("alipayUserId", request.alipayUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nickName)) {
            body.put("nickName", request.nickName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceToken)) {
            body.put("serviceToken", request.serviceToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visitorToken)) {
            body.put("visitorToken", request.visitorToken);
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
        return TeaModel.toModel(this.doROARequest("ConversationTransferCompleteNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/completes", "json", req, runtime), new ConversationTransferCompleteNotifyResponse());
    }

    public CreateGroupResponse createGroup(CreateGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateGroupHeaders headers = new CreateGroupHeaders();
        return this.createGroupWithOptions(request, headers, runtime);
    }

    public CreateGroupResponse createGroupWithOptions(CreateGroupRequest request, CreateGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupBizId)) {
            body.put("groupBizId", request.groupBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupTagNames)) {
            body.put("groupTagNames", request.groupTagNames);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberStaffIds)) {
            body.put("memberStaffIds", request.memberStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerStaffId)) {
            body.put("ownerStaffId", request.ownerStaffId);
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
        return TeaModel.toModel(this.doROARequest("CreateGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups", "json", req, runtime), new CreateGroupResponse());
    }

    public CreateGroupConversationResponse createGroupConversation(CreateGroupConversationRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
        return this.createGroupConversationWithOptions(request, headers, runtime);
    }

    public CreateGroupConversationResponse createGroupConversationWithOptions(CreateGroupConversationRequest request, CreateGroupConversationHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingGroupId)) {
            body.put("dingGroupId", request.dingGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            body.put("dingUserId", request.dingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingUserName)) {
            body.put("dingUserName", request.dingUserName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extValues)) {
            body.put("extValues", request.extValues);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serverGroupId)) {
            body.put("serverGroupId", request.serverGroupId);
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
        return TeaModel.toModel(this.doROARequest("CreateGroupConversation", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/create/conversations", "json", req, runtime), new CreateGroupConversationResponse());
    }

    public CreateGroupSetResponse createGroupSet(CreateGroupSetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
        return this.createGroupSetWithOptions(request, headers, runtime);
    }

    public CreateGroupSetResponse createGroupSetWithOptions(CreateGroupSetRequest request, CreateGroupSetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupSetName)) {
            body.put("groupSetName", request.groupSetName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupTemplateId)) {
            body.put("groupTemplateId", request.groupTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("CreateGroupSet", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groupSets", "json", req, runtime), new CreateGroupSetResponse());
    }

    public CreateTeamResponse createTeam(CreateTeamRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTeamHeaders headers = new CreateTeamHeaders();
        return this.createTeamWithOptions(request, headers, runtime);
    }

    public CreateTeamResponse createTeamWithOptions(CreateTeamRequest request, CreateTeamHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorDingUnionId)) {
            body.put("creatorDingUnionId", request.creatorDingUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamName)) {
            body.put("teamName", request.teamName);
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
        return TeaModel.toModel(this.doROARequest("CreateTeam", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/teams", "json", req, runtime), new CreateTeamResponse());
    }

    public CreateTicketResponse createTicket(CreateTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateTicketHeaders headers = new CreateTicketHeaders();
        return this.createTicketWithOptions(request, headers, runtime);
    }

    public CreateTicketResponse createTicketWithOptions(CreateTicketRequest request, CreateTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFields)) {
            body.put("customFields", request.customFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notify))) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTemplateBizId)) {
            body.put("openTemplateBizId", request.openTemplateBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionIds)) {
            body.put("processorUnionIds", request.processorUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sceneContext))) {
            body.put("sceneContext", request.sceneContext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
        return TeaModel.toModel(this.doROARequest("CreateTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets", "json", req, runtime), new CreateTicketResponse());
    }

    public DeleteKnowledgeResponse deleteKnowledge(DeleteKnowledgeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
        return this.deleteKnowledgeWithOptions(request, headers, runtime);
    }

    public DeleteKnowledgeResponse deleteKnowledgeWithOptions(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.libraryKey)) {
            body.put("libraryKey", request.libraryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourcePrimaryKey)) {
            body.put("sourcePrimaryKey", request.sourcePrimaryKey);
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
        return TeaModel.toModel(this.doROARequest("DeleteKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges/batchDelete", "json", req, runtime), new DeleteKnowledgeResponse());
    }

    public EmotionStatisticsResponse emotionStatistics(EmotionStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EmotionStatisticsHeaders headers = new EmotionStatisticsHeaders();
        return this.emotionStatisticsWithOptions(request, headers, runtime);
    }

    public EmotionStatisticsResponse emotionStatisticsWithOptions(EmotionStatisticsRequest request, EmotionStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            query.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxEmotion)) {
            query.put("maxEmotion", request.maxEmotion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            query.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minEmotion)) {
            query.put("minEmotion", request.minEmotion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationIds)) {
            query.put("openConversationIds", request.openConversationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            query.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("EmotionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/emotions/statistics", "json", req, runtime), new EmotionStatisticsResponse());
    }

    public FinishTicketResponse finishTicket(FinishTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        FinishTicketHeaders headers = new FinishTicketHeaders();
        return this.finishTicketWithOptions(request, headers, runtime);
    }

    public FinishTicketResponse finishTicketWithOptions(FinishTicketRequest request, FinishTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notify))) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionId)) {
            body.put("processorUnionId", request.processorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("FinishTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/finish", "none", req, runtime), new FinishTicketResponse());
    }

    public GetAuthTokenResponse getAuthToken(GetAuthTokenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetAuthTokenHeaders headers = new GetAuthTokenHeaders();
        return this.getAuthTokenWithOptions(request, headers, runtime);
    }

    public GetAuthTokenResponse getAuthTokenWithOptions(GetAuthTokenRequest request, GetAuthTokenHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.effectiveTime)) {
            body.put("effectiveTime", request.effectiveTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serverId)) {
            body.put("serverId", request.serverId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serverName)) {
            body.put("serverName", request.serverName);
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
        return TeaModel.toModel(this.doROARequest("GetAuthToken", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/get/tokens", "json", req, runtime), new GetAuthTokenResponse());
    }

    public GetNegativeWordCloudResponse getNegativeWordCloud(GetNegativeWordCloudRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetNegativeWordCloudHeaders headers = new GetNegativeWordCloudHeaders();
        return this.getNegativeWordCloudWithOptions(request, headers, runtime);
    }

    public GetNegativeWordCloudResponse getNegativeWordCloudWithOptions(GetNegativeWordCloudRequest request, GetNegativeWordCloudHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetNegativeWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/negatives/wordClouds", "json", req, runtime), new GetNegativeWordCloudResponse());
    }

    public GetOssTempUrlResponse getOssTempUrl(GetOssTempUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOssTempUrlHeaders headers = new GetOssTempUrlHeaders();
        return this.getOssTempUrlWithOptions(request, headers, runtime);
    }

    public GetOssTempUrlResponse getOssTempUrlWithOptions(GetOssTempUrlRequest request, GetOssTempUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fetchMode)) {
            query.put("fetchMode", request.fetchMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            query.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.key)) {
            query.put("key", request.key);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetOssTempUrl", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/ossServices/tempUrls", "json", req, runtime), new GetOssTempUrlResponse());
    }

    public GetStoragePolicyResponse getStoragePolicy(GetStoragePolicyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetStoragePolicyHeaders headers = new GetStoragePolicyHeaders();
        return this.getStoragePolicyWithOptions(request, headers, runtime);
    }

    public GetStoragePolicyResponse getStoragePolicyWithOptions(GetStoragePolicyRequest request, GetStoragePolicyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            body.put("fileSize", request.fileSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("GetStoragePolicy", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/ossServices/policies", "json", req, runtime), new GetStoragePolicyResponse());
    }

    public GetTicketResponse getTicket(GetTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTicketHeaders headers = new GetTicketHeaders();
        return this.getTicketWithOptions(request, headers, runtime);
    }

    public GetTicketResponse getTicketWithOptions(GetTicketRequest request, GetTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            query.put("openTicketId", request.openTicketId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetTicket", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/tickets", "json", req, runtime), new GetTicketResponse());
    }

    public GetWordCloudResponse getWordCloud(GetWordCloudRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetWordCloudHeaders headers = new GetWordCloudHeaders();
        return this.getWordCloudWithOptions(request, headers, runtime);
    }

    public GetWordCloudResponse getWordCloudWithOptions(GetWordCloudRequest request, GetWordCloudHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetWordCloud", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/wordClouds", "json", req, runtime), new GetWordCloudResponse());
    }

    public GroupStatisticsResponse groupStatistics(GroupStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GroupStatisticsHeaders headers = new GroupStatisticsHeaders();
        return this.groupStatisticsWithOptions(request, headers, runtime);
    }

    public GroupStatisticsResponse groupStatisticsWithOptions(GroupStatisticsRequest request, GroupStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            query.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            query.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GroupStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/groups/statistics", "json", req, runtime), new GroupStatisticsResponse());
    }

    public IntentionCategoryStatisticsResponse intentionCategoryStatistics(IntentionCategoryStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IntentionCategoryStatisticsHeaders headers = new IntentionCategoryStatisticsHeaders();
        return this.intentionCategoryStatisticsWithOptions(request, headers, runtime);
    }

    public IntentionCategoryStatisticsResponse intentionCategoryStatisticsWithOptions(IntentionCategoryStatisticsRequest request, IntentionCategoryStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            query.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            query.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("IntentionCategoryStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics", "json", req, runtime), new IntentionCategoryStatisticsResponse());
    }

    public IntentionStatisticsResponse intentionStatistics(IntentionStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IntentionStatisticsHeaders headers = new IntentionStatisticsHeaders();
        return this.intentionStatisticsWithOptions(request, headers, runtime);
    }

    public IntentionStatisticsResponse intentionStatisticsWithOptions(IntentionStatisticsRequest request, IntentionStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            query.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            query.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("IntentionStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/dashboards/intentions/statistics", "json", req, runtime), new IntentionStatisticsResponse());
    }

    public ListTicketOperateRecordResponse listTicketOperateRecord(ListTicketOperateRecordRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListTicketOperateRecordHeaders headers = new ListTicketOperateRecordHeaders();
        return this.listTicketOperateRecordWithOptions(request, headers, runtime);
    }

    public ListTicketOperateRecordResponse listTicketOperateRecordWithOptions(ListTicketOperateRecordRequest request, ListTicketOperateRecordHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            query.put("openTicketId", request.openTicketId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListTicketOperateRecord", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/tickets/operateRecords", "json", req, runtime), new ListTicketOperateRecordResponse());
    }

    public ListUserTeamsResponse listUserTeams(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListUserTeamsHeaders headers = new ListUserTeamsHeaders();
        return this.listUserTeamsWithOptions(userId, headers, runtime);
    }

    public ListUserTeamsResponse listUserTeamsWithOptions(String userId, ListUserTeamsHeaders headers, RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ListUserTeams", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/users/" + userId + "/teams", "json", req, runtime), new ListUserTeamsResponse());
    }

    public QueryActiveUsersResponse queryActiveUsers(QueryActiveUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryActiveUsersHeaders headers = new QueryActiveUsersHeaders();
        return this.queryActiveUsersWithOptions(request, headers, runtime);
    }

    public QueryActiveUsersResponse queryActiveUsersWithOptions(QueryActiveUsersRequest request, QueryActiveUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.topN)) {
            query.put("topN", request.topN);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryActiveUsers", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/groups/queryActiveUsers", "json", req, runtime), new QueryActiveUsersResponse());
    }

    public QueryCustomerCardResponse queryCustomerCard(QueryCustomerCardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCustomerCardHeaders headers = new QueryCustomerCardHeaders();
        return this.queryCustomerCardWithOptions(request, headers, runtime);
    }

    public QueryCustomerCardResponse queryCustomerCardWithOptions(QueryCustomerCardRequest request, QueryCustomerCardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jsonParams)) {
            body.put("jsonParams", request.jsonParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("QueryCustomerCard", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/userDetials", "json", req, runtime), new QueryCustomerCardResponse());
    }

    public QueryGroupResponse queryGroup(QueryGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupHeaders headers = new QueryGroupHeaders();
        return this.queryGroupWithOptions(request, headers, runtime);
    }

    public QueryGroupResponse queryGroupWithOptions(QueryGroupRequest request, QueryGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("QueryGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/query", "json", req, runtime), new QueryGroupResponse());
    }

    public QueryGroupMemberResponse queryGroupMember(QueryGroupMemberRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
        return this.queryGroupMemberWithOptions(request, headers, runtime);
    }

    public QueryGroupMemberResponse queryGroupMemberWithOptions(QueryGroupMemberRequest request, QueryGroupMemberHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
        return TeaModel.toModel(this.doROARequest("QueryGroupMember", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/members/query", "json", req, runtime), new QueryGroupMemberResponse());
    }

    public QueryGroupSetResponse queryGroupSet(QueryGroupSetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupSetHeaders headers = new QueryGroupSetHeaders();
        return this.queryGroupSetWithOptions(request, headers, runtime);
    }

    public QueryGroupSetResponse queryGroupSetWithOptions(QueryGroupSetRequest request, QueryGroupSetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryGroupSet", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/groupSets", "json", req, runtime), new QueryGroupSetResponse());
    }

    public QuerySendMsgTaskStatisticsResponse querySendMsgTaskStatistics(QuerySendMsgTaskStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QuerySendMsgTaskStatisticsHeaders headers = new QuerySendMsgTaskStatisticsHeaders();
        return this.querySendMsgTaskStatisticsWithOptions(request, headers, runtime);
    }

    public QuerySendMsgTaskStatisticsResponse querySendMsgTaskStatisticsWithOptions(QuerySendMsgTaskStatisticsRequest request, QuerySendMsgTaskStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openBatchTaskId)) {
            body.put("openBatchTaskId", request.openBatchTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("QuerySendMsgTaskStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/statistics/query", "json", req, runtime), new QuerySendMsgTaskStatisticsResponse());
    }

    public QuerySendMsgTaskStatisticsDetailResponse querySendMsgTaskStatisticsDetail(QuerySendMsgTaskStatisticsDetailRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QuerySendMsgTaskStatisticsDetailHeaders headers = new QuerySendMsgTaskStatisticsDetailHeaders();
        return this.querySendMsgTaskStatisticsDetailWithOptions(request, headers, runtime);
    }

    public QuerySendMsgTaskStatisticsDetailResponse querySendMsgTaskStatisticsDetailWithOptions(QuerySendMsgTaskStatisticsDetailRequest request, QuerySendMsgTaskStatisticsDetailHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openBatchTaskId)) {
            body.put("openBatchTaskId", request.openBatchTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("QuerySendMsgTaskStatisticsDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tasks/statistics/details/query", "json", req, runtime), new QuerySendMsgTaskStatisticsDetailResponse());
    }

    public QueryServiceGroupMessageReadStatusResponse queryServiceGroupMessageReadStatus(QueryServiceGroupMessageReadStatusRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryServiceGroupMessageReadStatusHeaders headers = new QueryServiceGroupMessageReadStatusHeaders();
        return this.queryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
    }

    public QueryServiceGroupMessageReadStatusResponse queryServiceGroupMessageReadStatusWithOptions(QueryServiceGroupMessageReadStatusRequest request, QueryServiceGroupMessageReadStatusHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openMsgTaskId)) {
            body.put("openMsgTaskId", request.openMsgTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
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
        return TeaModel.toModel(this.doROARequest("QueryServiceGroupMessageReadStatus", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/readStatus/query", "json", req, runtime), new QueryServiceGroupMessageReadStatusResponse());
    }

    public QueueNotifyResponse queueNotify(QueueNotifyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueueNotifyHeaders headers = new QueueNotifyHeaders();
        return this.queueNotifyWithOptions(request, headers, runtime);
    }

    public QueueNotifyResponse queueNotifyWithOptions(QueueNotifyRequest request, QueueNotifyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.estimateWaitMin)) {
            body.put("estimateWaitMin", request.estimateWaitMin);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queuePlace)) {
            body.put("queuePlace", request.queuePlace);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.serviceToken)) {
            body.put("serviceToken", request.serviceToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetChannel)) {
            body.put("targetChannel", request.targetChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tips)) {
            body.put("tips", request.tips);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.visitorToken)) {
            body.put("visitorToken", request.visitorToken);
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
        return TeaModel.toModel(this.doROARequest("QueueNotify", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/dts", "json", req, runtime), new QueueNotifyResponse());
    }

    public ReportCustomerDetailResponse reportCustomerDetail(ReportCustomerDetailRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ReportCustomerDetailHeaders headers = new ReportCustomerDetailHeaders();
        return this.reportCustomerDetailWithOptions(request, headers, runtime);
    }

    public ReportCustomerDetailResponse reportCustomerDetailWithOptions(ReportCustomerDetailRequest request, ReportCustomerDetailHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.hasLogin)) {
            body.put("hasLogin", request.hasLogin);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hasOpenConv)) {
            body.put("hasOpenConv", request.hasOpenConv);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            body.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            body.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("ReportCustomerDetail", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers/activities/details/query", "json", req, runtime), new ReportCustomerDetailResponse());
    }

    public ReportCustomerStatisticsResponse reportCustomerStatistics(ReportCustomerStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ReportCustomerStatisticsHeaders headers = new ReportCustomerStatisticsHeaders();
        return this.reportCustomerStatisticsWithOptions(request, headers, runtime);
    }

    public ReportCustomerStatisticsResponse reportCustomerStatisticsWithOptions(ReportCustomerStatisticsRequest request, ReportCustomerStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupOwnerUserIds)) {
            body.put("groupOwnerUserIds", request.groupOwnerUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupTags)) {
            body.put("groupTags", request.groupTags);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            body.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            body.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationIds)) {
            body.put("openConversationIds", request.openConversationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("ReportCustomerStatistics", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/customers/activities/statistics/query", "json", req, runtime), new ReportCustomerStatisticsResponse());
    }

    public ResubmitTicketResponse resubmitTicket(ResubmitTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ResubmitTicketHeaders headers = new ResubmitTicketHeaders();
        return this.resubmitTicketWithOptions(request, headers, runtime);
    }

    public ResubmitTicketResponse resubmitTicketWithOptions(ResubmitTicketRequest request, ResubmitTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFields)) {
            body.put("customFields", request.customFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notify))) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTemplateBizId)) {
            body.put("openTemplateBizId", request.openTemplateBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionIds)) {
            body.put("processorUnionIds", request.processorUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scene)) {
            body.put("scene", request.scene);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sceneContext))) {
            body.put("sceneContext", request.sceneContext);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
        return TeaModel.toModel(this.doROARequest("ResubmitTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/resubmit", "none", req, runtime), new ResubmitTicketResponse());
    }

    public RetractTicketResponse retractTicket(RetractTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RetractTicketHeaders headers = new RetractTicketHeaders();
        return this.retractTicketWithOptions(request, headers, runtime);
    }

    public RetractTicketResponse retractTicketWithOptions(RetractTicketRequest request, RetractTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notify))) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("RetractTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/retract", "none", req, runtime), new RetractTicketResponse());
    }

    public SearchGroupResponse searchGroup(SearchGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchGroupHeaders headers = new SearchGroupHeaders();
        return this.searchGroupWithOptions(request, headers, runtime);
    }

    public SearchGroupResponse searchGroupWithOptions(SearchGroupRequest request, SearchGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchType)) {
            body.put("searchType", request.searchType);
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
        return TeaModel.toModel(this.doROARequest("SearchGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/search", "json", req, runtime), new SearchGroupResponse());
    }

    public SendMsgByTaskResponse sendMsgByTask(SendMsgByTaskRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendMsgByTaskHeaders headers = new SendMsgByTaskHeaders();
        return this.sendMsgByTaskWithOptions(request, headers, runtime);
    }

    public SendMsgByTaskResponse sendMsgByTaskWithOptions(SendMsgByTaskRequest request, SendMsgByTaskHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.messageContent))) {
            body.put("messageContent", request.messageContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.queryGroup))) {
            body.put("queryGroup", request.queryGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sendConfig))) {
            body.put("sendConfig", request.sendConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskName)) {
            body.put("taskName", request.taskName);
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
        return TeaModel.toModel(this.doROARequest("SendMsgByTask", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/tasks/send", "json", req, runtime), new SendMsgByTaskResponse());
    }

    public SendServiceGroupMessageResponse sendServiceGroupMessage(SendServiceGroupMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendServiceGroupMessageHeaders headers = new SendServiceGroupMessageHeaders();
        return this.sendServiceGroupMessageWithOptions(request, headers, runtime);
    }

    public SendServiceGroupMessageResponse sendServiceGroupMessageWithOptions(SendServiceGroupMessageRequest request, SendServiceGroupMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.atDingtalkIds)) {
            body.put("atDingtalkIds", request.atDingtalkIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.atMobiles)) {
            body.put("atMobiles", request.atMobiles);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.atUnionIds)) {
            body.put("atUnionIds", request.atUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.btnOrientation)) {
            body.put("btnOrientation", request.btnOrientation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.btns)) {
            body.put("btns", request.btns);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hasContentLinks)) {
            body.put("hasContentLinks", request.hasContentLinks);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAtAll)) {
            body.put("isAtAll", request.isAtAll);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverDingtalkIds)) {
            body.put("receiverDingtalkIds", request.receiverDingtalkIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverMobiles)) {
            body.put("receiverMobiles", request.receiverMobiles);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUnionIds)) {
            body.put("receiverUnionIds", request.receiverUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetOpenConversationId)) {
            body.put("targetOpenConversationId", request.targetOpenConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
        return TeaModel.toModel(this.doROARequest("SendServiceGroupMessage", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/send", "json", req, runtime), new SendServiceGroupMessageResponse());
    }

    public SetRobotConfigResponse setRobotConfig(SetRobotConfigRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SetRobotConfigHeaders headers = new SetRobotConfigHeaders();
        return this.setRobotConfigWithOptions(request, headers, runtime);
    }

    public SetRobotConfigResponse setRobotConfigWithOptions(SetRobotConfigRequest request, SetRobotConfigHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
        return TeaModel.toModel(this.doROARequest("SetRobotConfig", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/configs/set", "json", req, runtime), new SetRobotConfigResponse());
    }

    public TakeTicketResponse takeTicket(TakeTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TakeTicketHeaders headers = new TakeTicketHeaders();
        return this.takeTicketWithOptions(request, headers, runtime);
    }

    public TakeTicketResponse takeTicketWithOptions(TakeTicketRequest request, TakeTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.takerUnionId)) {
            body.put("takerUnionId", request.takerUnionId);
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
        return TeaModel.toModel(this.doROARequest("TakeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/apply", "none", req, runtime), new TakeTicketResponse());
    }

    public TopicStatisticsResponse topicStatistics(TopicStatisticsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TopicStatisticsHeaders headers = new TopicStatisticsHeaders();
        return this.topicStatisticsWithOptions(request, headers, runtime);
    }

    public TopicStatisticsResponse topicStatisticsWithOptions(TopicStatisticsRequest request, TopicStatisticsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxDt)) {
            query.put("maxDt", request.maxDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minDt)) {
            query.put("minDt", request.minDt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationIds)) {
            query.put("openConversationIds", request.openConversationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            query.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchContent)) {
            query.put("searchContent", request.searchContent);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("TopicStatistics", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/voices/topics/statistics", "json", req, runtime), new TopicStatisticsResponse());
    }

    public TransferTicketResponse transferTicket(TransferTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TransferTicketHeaders headers = new TransferTicketHeaders();
        return this.transferTicketWithOptions(request, headers, runtime);
    }

    public TransferTicketResponse transferTicketWithOptions(TransferTicketRequest request, TransferTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.notify))) {
            body.put("notify", request.notify);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionId)) {
            body.put("processorUnionId", request.processorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionIds)) {
            body.put("processorUnionIds", request.processorUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("TransferTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/transfer", "none", req, runtime), new TransferTicketResponse());
    }

    public UpdateGroupTagResponse updateGroupTag(UpdateGroupTagRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateGroupTagHeaders headers = new UpdateGroupTagHeaders();
        return this.updateGroupTagWithOptions(request, headers, runtime);
    }

    public UpdateGroupTagResponse updateGroupTagWithOptions(UpdateGroupTagRequest request, UpdateGroupTagHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationIds)) {
            body.put("openConversationIds", request.openConversationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagNames)) {
            body.put("tagNames", request.tagNames);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.updateType)) {
            body.put("updateType", request.updateType);
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
        return TeaModel.toModel(this.doROARequest("UpdateGroupTag", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/tags", "none", req, runtime), new UpdateGroupTagResponse());
    }

    public UpdateTicketResponse updateTicket(UpdateTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateTicketHeaders headers = new UpdateTicketHeaders();
        return this.updateTicketWithOptions(request, headers, runtime);
    }

    public UpdateTicketResponse updateTicketWithOptions(UpdateTicketRequest request, UpdateTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.customFields)) {
            body.put("customFields", request.customFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processorUnionId)) {
            body.put("processorUnionId", request.processorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("UpdateTicket", "serviceGroup_1.0", "HTTP", "PUT", "AK", "/v1.0/serviceGroup/tickets", "none", req, runtime), new UpdateTicketResponse());
    }

    public UpgradeCloudGroupResponse upgradeCloudGroup(UpgradeCloudGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpgradeCloudGroupHeaders headers = new UpgradeCloudGroupHeaders();
        return this.upgradeCloudGroupWithOptions(request, headers, runtime);
    }

    public UpgradeCloudGroupResponse upgradeCloudGroupWithOptions(UpgradeCloudGroupRequest request, UpgradeCloudGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ccsInstanceId)) {
            body.put("ccsInstanceId", request.ccsInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
        return TeaModel.toModel(this.doROARequest("UpgradeCloudGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/cloudGroups/upgrade", "none", req, runtime), new UpgradeCloudGroupResponse());
    }

    public UpgradeNormalGroupResponse upgradeNormalGroup(UpgradeNormalGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpgradeNormalGroupHeaders headers = new UpgradeNormalGroupHeaders();
        return this.upgradeNormalGroupWithOptions(request, headers, runtime);
    }

    public UpgradeNormalGroupResponse upgradeNormalGroupWithOptions(UpgradeNormalGroupRequest request, UpgradeNormalGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
        return TeaModel.toModel(this.doROARequest("UpgradeNormalGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/normalGroups/upgrade", "none", req, runtime), new UpgradeNormalGroupResponse());
    }

    public UrgeTicketResponse urgeTicket(UrgeTicketRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UrgeTicketHeaders headers = new UrgeTicketHeaders();
        return this.urgeTicketWithOptions(request, headers, runtime);
    }

    public UrgeTicketResponse urgeTicketWithOptions(UrgeTicketRequest request, UrgeTicketHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTicketId)) {
            body.put("openTicketId", request.openTicketId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.ticketMemo))) {
            body.put("ticketMemo", request.ticketMemo);
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
        return TeaModel.toModel(this.doROARequest("UrgeTicket", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/tickets/urge", "none", req, runtime), new UrgeTicketResponse());
    }
}
