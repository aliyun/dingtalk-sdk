// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkservice_group_1_0.models.*;

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


    public AddContactMemberToGroupResponse addContactMemberToGroupWithOptions(AddContactMemberToGroupRequest request, AddContactMemberToGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fissionType)) {
            body.put("fissionType", request.fissionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberUnionId)) {
            body.put("memberUnionId", request.memberUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberUserId)) {
            body.put("memberUserId", request.memberUserId);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddContactMemberToGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/contacts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddContactMemberToGroupResponse());
    }

    public AddContactMemberToGroupResponse addContactMemberToGroup(AddContactMemberToGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddContactMemberToGroupHeaders headers = new AddContactMemberToGroupHeaders();
        return this.addContactMemberToGroupWithOptions(request, headers, runtime);
    }

    public AddKnowledgeResponse addKnowledgeWithOptions(AddKnowledgeRequest request, AddKnowledgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.questionIds)) {
            body.put("questionIds", request.questionIds);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddKnowledge"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/knowledges"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddKnowledgeResponse());
    }

    public AddKnowledgeResponse addKnowledge(AddKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddKnowledgeHeaders headers = new AddKnowledgeHeaders();
        return this.addKnowledgeWithOptions(request, headers, runtime);
    }

    public AddLibraryResponse addLibraryWithOptions(AddLibraryRequest request, AddLibraryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddLibrary"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/librarys"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddLibraryResponse());
    }

    public AddLibraryResponse addLibrary(AddLibraryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddLibraryHeaders headers = new AddLibraryHeaders();
        return this.addLibraryWithOptions(request, headers, runtime);
    }

    public AddMemberToServiceGroupResponse addMemberToServiceGroupWithOptions(AddMemberToServiceGroupRequest request, AddMemberToServiceGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "AddMemberToServiceGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddMemberToServiceGroupResponse());
    }

    public AddMemberToServiceGroupResponse addMemberToServiceGroup(AddMemberToServiceGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddMemberToServiceGroupHeaders headers = new AddMemberToServiceGroupHeaders();
        return this.addMemberToServiceGroupWithOptions(request, headers, runtime);
    }

    public AddOpenCategoryResponse addOpenCategoryWithOptions(AddOpenCategoryRequest request, AddOpenCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddOpenCategory"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/openCategories"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddOpenCategoryResponse());
    }

    public AddOpenCategoryResponse addOpenCategory(AddOpenCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOpenCategoryHeaders headers = new AddOpenCategoryHeaders();
        return this.addOpenCategoryWithOptions(request, headers, runtime);
    }

    public AddOpenKnowledgeResponse addOpenKnowledgeWithOptions(AddOpenKnowledgeRequest request, AddOpenKnowledgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddOpenKnowledge"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/openKnowledges"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddOpenKnowledgeResponse());
    }

    public AddOpenKnowledgeResponse addOpenKnowledge(AddOpenKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOpenKnowledgeHeaders headers = new AddOpenKnowledgeHeaders();
        return this.addOpenKnowledgeWithOptions(request, headers, runtime);
    }

    public AddOpenLibraryResponse addOpenLibraryWithOptions(AddOpenLibraryRequest request, AddOpenLibraryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddOpenLibrary"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/openLibraries"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddOpenLibraryResponse());
    }

    public AddOpenLibraryResponse addOpenLibrary(AddOpenLibraryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOpenLibraryHeaders headers = new AddOpenLibraryHeaders();
        return this.addOpenLibraryWithOptions(request, headers, runtime);
    }

    public AddTicketMemoResponse addTicketMemoWithOptions(AddTicketMemoRequest request, AddTicketMemoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "AddTicketMemo"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/memos"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddTicketMemoResponse());
    }

    public AddTicketMemoResponse addTicketMemo(AddTicketMemoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddTicketMemoHeaders headers = new AddTicketMemoHeaders();
        return this.addTicketMemoWithOptions(request, headers, runtime);
    }

    public AssignTicketResponse assignTicketWithOptions(AssignTicketRequest request, AssignTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "AssignTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/assign"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AssignTicketResponse());
    }

    public AssignTicketResponse assignTicket(AssignTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AssignTicketHeaders headers = new AssignTicketHeaders();
        return this.assignTicketWithOptions(request, headers, runtime);
    }

    public BatchBindingGroupBizIdsResponse batchBindingGroupBizIdsWithOptions(BatchBindingGroupBizIdsRequest request, BatchBindingGroupBizIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchBindingGroupBizIds"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/bind"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchBindingGroupBizIdsResponse());
    }

    public BatchBindingGroupBizIdsResponse batchBindingGroupBizIds(BatchBindingGroupBizIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchBindingGroupBizIdsHeaders headers = new BatchBindingGroupBizIdsHeaders();
        return this.batchBindingGroupBizIdsWithOptions(request, headers, runtime);
    }

    public BatchGetGroupSetConfigResponse batchGetGroupSetConfigWithOptions(BatchGetGroupSetConfigRequest request, BatchGetGroupSetConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchGetGroupSetConfig"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groupSetConfigs/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchGetGroupSetConfigResponse());
    }

    public BatchGetGroupSetConfigResponse batchGetGroupSetConfig(BatchGetGroupSetConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchGetGroupSetConfigHeaders headers = new BatchGetGroupSetConfigHeaders();
        return this.batchGetGroupSetConfigWithOptions(request, headers, runtime);
    }

    public BatchQueryCustomerSendTaskResponse batchQueryCustomerSendTaskWithOptions(BatchQueryCustomerSendTaskRequest request, BatchQueryCustomerSendTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.gmtCreateEnd)) {
            body.put("gmtCreateEnd", request.gmtCreateEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtCreateStart)) {
            body.put("gmtCreateStart", request.gmtCreateStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needRichStatistics)) {
            body.put("needRichStatistics", request.needRichStatistics);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openBatchTaskIds)) {
            body.put("openBatchTaskIds", request.openBatchTaskIds);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchQueryCustomerSendTask"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customers/tasks/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryCustomerSendTaskResponse());
    }

    public BatchQueryCustomerSendTaskResponse batchQueryCustomerSendTask(BatchQueryCustomerSendTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryCustomerSendTaskHeaders headers = new BatchQueryCustomerSendTaskHeaders();
        return this.batchQueryCustomerSendTaskWithOptions(request, headers, runtime);
    }

    public BatchQueryGroupMemberResponse batchQueryGroupMemberWithOptions(BatchQueryGroupMemberRequest request, BatchQueryGroupMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchQueryGroupMember"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/members/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryGroupMemberResponse());
    }

    public BatchQueryGroupMemberResponse batchQueryGroupMember(BatchQueryGroupMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
        return this.batchQueryGroupMemberWithOptions(request, headers, runtime);
    }

    public BatchQuerySendMessageTaskResponse batchQuerySendMessageTaskWithOptions(BatchQuerySendMessageTaskRequest request, BatchQuerySendMessageTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchQuerySendMessageTask"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tasks/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQuerySendMessageTaskResponse());
    }

    public BatchQuerySendMessageTaskResponse batchQuerySendMessageTask(BatchQuerySendMessageTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQuerySendMessageTaskHeaders headers = new BatchQuerySendMessageTaskHeaders();
        return this.batchQuerySendMessageTaskWithOptions(request, headers, runtime);
    }

    public BoundTemplateToTeamResponse boundTemplateToTeamWithOptions(BoundTemplateToTeamRequest request, BoundTemplateToTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BoundTemplateToTeam"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/teams/templates/bound"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BoundTemplateToTeamResponse());
    }

    public BoundTemplateToTeamResponse boundTemplateToTeam(BoundTemplateToTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BoundTemplateToTeamHeaders headers = new BoundTemplateToTeamHeaders();
        return this.boundTemplateToTeamWithOptions(request, headers, runtime);
    }

    public CancelTicketResponse cancelTicketWithOptions(CancelTicketRequest request, CancelTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "CancelTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelTicketResponse());
    }

    public CancelTicketResponse cancelTicket(CancelTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelTicketHeaders headers = new CancelTicketHeaders();
        return this.cancelTicketWithOptions(request, headers, runtime);
    }

    public CategoryStatisticsResponse categoryStatisticsWithOptions(CategoryStatisticsRequest request, CategoryStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CategoryStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/dashboards/categories/statistics"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CategoryStatisticsResponse());
    }

    public CategoryStatisticsResponse categoryStatistics(CategoryStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CategoryStatisticsHeaders headers = new CategoryStatisticsHeaders();
        return this.categoryStatisticsWithOptions(request, headers, runtime);
    }

    public CloseConversationResponse closeConversationWithOptions(CloseConversationRequest request, CloseConversationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CloseConversation"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/conversions"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CloseConversationResponse());
    }

    public CloseConversationResponse closeConversation(CloseConversationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseConversationHeaders headers = new CloseConversationHeaders();
        return this.closeConversationWithOptions(request, headers, runtime);
    }

    public CloseHumanSessionResponse closeHumanSessionWithOptions(CloseHumanSessionRequest request, CloseHumanSessionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CloseHumanSession"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/humanSessions/close"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CloseHumanSessionResponse());
    }

    public CloseHumanSessionResponse closeHumanSession(CloseHumanSessionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseHumanSessionHeaders headers = new CloseHumanSessionHeaders();
        return this.closeHumanSessionWithOptions(request, headers, runtime);
    }

    public ConversationCreatedNotifyResponse conversationCreatedNotifyWithOptions(ConversationCreatedNotifyRequest request, ConversationCreatedNotifyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ConversationCreatedNotify"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConversationCreatedNotifyResponse());
    }

    public ConversationCreatedNotifyResponse conversationCreatedNotify(ConversationCreatedNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConversationCreatedNotifyHeaders headers = new ConversationCreatedNotifyHeaders();
        return this.conversationCreatedNotifyWithOptions(request, headers, runtime);
    }

    public ConversationTransferBeginNotifyResponse conversationTransferBeginNotifyWithOptions(ConversationTransferBeginNotifyRequest request, ConversationTransferBeginNotifyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ConversationTransferBeginNotify"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/transfers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConversationTransferBeginNotifyResponse());
    }

    public ConversationTransferBeginNotifyResponse conversationTransferBeginNotify(ConversationTransferBeginNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConversationTransferBeginNotifyHeaders headers = new ConversationTransferBeginNotifyHeaders();
        return this.conversationTransferBeginNotifyWithOptions(request, headers, runtime);
    }

    public ConversationTransferCompleteNotifyResponse conversationTransferCompleteNotifyWithOptions(ConversationTransferCompleteNotifyRequest request, ConversationTransferCompleteNotifyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ConversationTransferCompleteNotify"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/completes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConversationTransferCompleteNotifyResponse());
    }

    public ConversationTransferCompleteNotifyResponse conversationTransferCompleteNotify(ConversationTransferCompleteNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConversationTransferCompleteNotifyHeaders headers = new ConversationTransferCompleteNotifyHeaders();
        return this.conversationTransferCompleteNotifyWithOptions(request, headers, runtime);
    }

    public CreateGroupResponse createGroupWithOptions(CreateGroupRequest request, CreateGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateGroupResponse());
    }

    public CreateGroupResponse createGroup(CreateGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupHeaders headers = new CreateGroupHeaders();
        return this.createGroupWithOptions(request, headers, runtime);
    }

    public CreateGroupConversationResponse createGroupConversationWithOptions(CreateGroupConversationRequest request, CreateGroupConversationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateGroupConversation"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/create/conversations"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateGroupConversationResponse());
    }

    public CreateGroupConversationResponse createGroupConversation(CreateGroupConversationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
        return this.createGroupConversationWithOptions(request, headers, runtime);
    }

    public CreateGroupSetResponse createGroupSetWithOptions(CreateGroupSetRequest request, CreateGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateGroupSet"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groupSets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateGroupSetResponse());
    }

    public CreateGroupSetResponse createGroupSet(CreateGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
        return this.createGroupSetWithOptions(request, headers, runtime);
    }

    public CreateInstanceResponse createInstanceWithOptions(CreateInstanceRequest request, CreateInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.channel)) {
            body.put("channel", request.channel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.externalBizId)) {
            body.put("externalBizId", request.externalBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            body.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataList)) {
            body.put("formDataList", request.formDataList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUnionId)) {
            body.put("ownerUnionId", request.ownerUnionId);
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
            new TeaPair("action", "CreateInstance"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customForms/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateInstanceResponse());
    }

    public CreateInstanceResponse createInstance(CreateInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateInstanceHeaders headers = new CreateInstanceHeaders();
        return this.createInstanceWithOptions(request, headers, runtime);
    }

    public CreateTeamResponse createTeamWithOptions(CreateTeamRequest request, CreateTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateTeam"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/teams"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTeamResponse());
    }

    public CreateTeamResponse createTeam(CreateTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTeamHeaders headers = new CreateTeamHeaders();
        return this.createTeamWithOptions(request, headers, runtime);
    }

    public CreateTicketResponse createTicketWithOptions(CreateTicketRequest request, CreateTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFields)) {
            body.put("customFields", request.customFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.sceneContext)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTicketResponse());
    }

    public CreateTicketResponse createTicket(CreateTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTicketHeaders headers = new CreateTicketHeaders();
        return this.createTicketWithOptions(request, headers, runtime);
    }

    public CustomerSendMsgTaskResponse customerSendMsgTaskWithOptions(CustomerSendMsgTaskRequest request, CustomerSendMsgTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.messageContent)) {
            body.put("messageContent", request.messageContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryCustomer)) {
            body.put("queryCustomer", request.queryCustomer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendConfig)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CustomerSendMsgTask"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customers/tasks/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomerSendMsgTaskResponse());
    }

    public CustomerSendMsgTaskResponse customerSendMsgTask(CustomerSendMsgTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomerSendMsgTaskHeaders headers = new CustomerSendMsgTaskHeaders();
        return this.customerSendMsgTaskWithOptions(request, headers, runtime);
    }

    public DeleteGroupMembersFromGroupResponse deleteGroupMembersFromGroupWithOptions(DeleteGroupMembersFromGroupRequest request, DeleteGroupMembersFromGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deleteGroupType)) {
            body.put("deleteGroupType", request.deleteGroupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberUnionId)) {
            body.put("memberUnionId", request.memberUnionId);
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
            new TeaPair("action", "DeleteGroupMembersFromGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/members/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteGroupMembersFromGroupResponse());
    }

    public DeleteGroupMembersFromGroupResponse deleteGroupMembersFromGroup(DeleteGroupMembersFromGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteGroupMembersFromGroupHeaders headers = new DeleteGroupMembersFromGroupHeaders();
        return this.deleteGroupMembersFromGroupWithOptions(request, headers, runtime);
    }

    public DeleteInstanceResponse deleteInstanceWithOptions(DeleteInstanceRequest request, DeleteInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            body.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openDataInstanceId)) {
            body.put("openDataInstanceId", request.openDataInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
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
            new TeaPair("action", "DeleteInstance"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customForms/instances/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteInstanceResponse());
    }

    public DeleteInstanceResponse deleteInstance(DeleteInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteInstanceHeaders headers = new DeleteInstanceHeaders();
        return this.deleteInstanceWithOptions(request, headers, runtime);
    }

    public DeleteKnowledgeResponse deleteKnowledgeWithOptions(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteKnowledge"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/knowledges/batchDelete"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteKnowledgeResponse());
    }

    public DeleteKnowledgeResponse deleteKnowledge(DeleteKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
        return this.deleteKnowledgeWithOptions(request, headers, runtime);
    }

    public EmotionStatisticsResponse emotionStatisticsWithOptions(EmotionStatisticsRequest request, EmotionStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EmotionStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/emotions/statistics"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EmotionStatisticsResponse());
    }

    public EmotionStatisticsResponse emotionStatistics(EmotionStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EmotionStatisticsHeaders headers = new EmotionStatisticsHeaders();
        return this.emotionStatisticsWithOptions(request, headers, runtime);
    }

    public FinishTicketResponse finishTicketWithOptions(FinishTicketRequest request, FinishTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "FinishTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/finish"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FinishTicketResponse());
    }

    public FinishTicketResponse finishTicket(FinishTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FinishTicketHeaders headers = new FinishTicketHeaders();
        return this.finishTicketWithOptions(request, headers, runtime);
    }

    public GetAuthTokenResponse getAuthTokenWithOptions(GetAuthTokenRequest request, GetAuthTokenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetAuthToken"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/get/tokens"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAuthTokenResponse());
    }

    public GetAuthTokenResponse getAuthToken(GetAuthTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAuthTokenHeaders headers = new GetAuthTokenHeaders();
        return this.getAuthTokenWithOptions(request, headers, runtime);
    }

    public GetInstancesByIdsResponse getInstancesByIdsWithOptions(GetInstancesByIdsRequest request, GetInstancesByIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            body.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openDataInstanceIdList)) {
            body.put("openDataInstanceIdList", request.openDataInstanceIdList);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetInstancesByIds"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customForms/instances/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInstancesByIdsResponse());
    }

    public GetInstancesByIdsResponse getInstancesByIds(GetInstancesByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstancesByIdsHeaders headers = new GetInstancesByIdsHeaders();
        return this.getInstancesByIdsWithOptions(request, headers, runtime);
    }

    public GetNegativeWordCloudResponse getNegativeWordCloudWithOptions(GetNegativeWordCloudRequest request, GetNegativeWordCloudHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetNegativeWordCloud"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/negatives/wordClouds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetNegativeWordCloudResponse());
    }

    public GetNegativeWordCloudResponse getNegativeWordCloud(GetNegativeWordCloudRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetNegativeWordCloudHeaders headers = new GetNegativeWordCloudHeaders();
        return this.getNegativeWordCloudWithOptions(request, headers, runtime);
    }

    public GetOssTempUrlResponse getOssTempUrlWithOptions(GetOssTempUrlRequest request, GetOssTempUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetOssTempUrl"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/ossServices/tempUrls"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOssTempUrlResponse());
    }

    public GetOssTempUrlResponse getOssTempUrl(GetOssTempUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOssTempUrlHeaders headers = new GetOssTempUrlHeaders();
        return this.getOssTempUrlWithOptions(request, headers, runtime);
    }

    public GetStoragePolicyResponse getStoragePolicyWithOptions(GetStoragePolicyRequest request, GetStoragePolicyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetStoragePolicy"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/ossServices/policies"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetStoragePolicyResponse());
    }

    public GetStoragePolicyResponse getStoragePolicy(GetStoragePolicyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetStoragePolicyHeaders headers = new GetStoragePolicyHeaders();
        return this.getStoragePolicyWithOptions(request, headers, runtime);
    }

    public GetTicketResponse getTicketWithOptions(GetTicketRequest request, GetTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTicketResponse());
    }

    public GetTicketResponse getTicket(GetTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTicketHeaders headers = new GetTicketHeaders();
        return this.getTicketWithOptions(request, headers, runtime);
    }

    public GetWordCloudResponse getWordCloudWithOptions(GetWordCloudRequest request, GetWordCloudHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetWordCloud"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/wordClouds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetWordCloudResponse());
    }

    public GetWordCloudResponse getWordCloud(GetWordCloudRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetWordCloudHeaders headers = new GetWordCloudHeaders();
        return this.getWordCloudWithOptions(request, headers, runtime);
    }

    public GroupStatisticsResponse groupStatisticsWithOptions(GroupStatisticsRequest request, GroupStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GroupStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/dashboards/groups/statistics"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GroupStatisticsResponse());
    }

    public GroupStatisticsResponse groupStatistics(GroupStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupStatisticsHeaders headers = new GroupStatisticsHeaders();
        return this.groupStatisticsWithOptions(request, headers, runtime);
    }

    public IntentionCategoryStatisticsResponse intentionCategoryStatisticsWithOptions(IntentionCategoryStatisticsRequest request, IntentionCategoryStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "IntentionCategoryStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/dashboards/intentionCategories/statistics"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IntentionCategoryStatisticsResponse());
    }

    public IntentionCategoryStatisticsResponse intentionCategoryStatistics(IntentionCategoryStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IntentionCategoryStatisticsHeaders headers = new IntentionCategoryStatisticsHeaders();
        return this.intentionCategoryStatisticsWithOptions(request, headers, runtime);
    }

    public IntentionStatisticsResponse intentionStatisticsWithOptions(IntentionStatisticsRequest request, IntentionStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "IntentionStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/dashboards/intentions/statistics"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IntentionStatisticsResponse());
    }

    public IntentionStatisticsResponse intentionStatistics(IntentionStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IntentionStatisticsHeaders headers = new IntentionStatisticsHeaders();
        return this.intentionStatisticsWithOptions(request, headers, runtime);
    }

    public ListTicketOperateRecordResponse listTicketOperateRecordWithOptions(ListTicketOperateRecordRequest request, ListTicketOperateRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListTicketOperateRecord"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/operateRecords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListTicketOperateRecordResponse());
    }

    public ListTicketOperateRecordResponse listTicketOperateRecord(ListTicketOperateRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListTicketOperateRecordHeaders headers = new ListTicketOperateRecordHeaders();
        return this.listTicketOperateRecordWithOptions(request, headers, runtime);
    }

    public ListUserTeamsResponse listUserTeamsWithOptions(String userId, ListUserTeamsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListUserTeams"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/users/" + userId + "/teams"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListUserTeamsResponse());
    }

    public ListUserTeamsResponse listUserTeams(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListUserTeamsHeaders headers = new ListUserTeamsHeaders();
        return this.listUserTeamsWithOptions(userId, headers, runtime);
    }

    public QueryActiveUsersResponse queryActiveUsersWithOptions(QueryActiveUsersRequest request, QueryActiveUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryActiveUsers"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/queryActiveUsers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryActiveUsersResponse());
    }

    public QueryActiveUsersResponse queryActiveUsers(QueryActiveUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryActiveUsersHeaders headers = new QueryActiveUsersHeaders();
        return this.queryActiveUsersWithOptions(request, headers, runtime);
    }

    public QueryCrmGroupContactResponse queryCrmGroupContactWithOptions(QueryCrmGroupContactRequest request, QueryCrmGroupContactHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.minResult)) {
            body.put("minResult", request.minResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchFields)) {
            body.put("searchFields", request.searchFields);
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
            new TeaPair("action", "QueryCrmGroupContact"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/contacts/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCrmGroupContactResponse());
    }

    public QueryCrmGroupContactResponse queryCrmGroupContact(QueryCrmGroupContactRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCrmGroupContactHeaders headers = new QueryCrmGroupContactHeaders();
        return this.queryCrmGroupContactWithOptions(request, headers, runtime);
    }

    public QueryCustomerCardResponse queryCustomerCardWithOptions(QueryCustomerCardRequest request, QueryCustomerCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryCustomerCard"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/userDetials"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCustomerCardResponse());
    }

    public QueryCustomerCardResponse queryCustomerCard(QueryCustomerCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomerCardHeaders headers = new QueryCustomerCardHeaders();
        return this.queryCustomerCardWithOptions(request, headers, runtime);
    }

    public QueryCustomerTaskUserDetailResponse queryCustomerTaskUserDetailWithOptions(QueryCustomerTaskUserDetailRequest request, QueryCustomerTaskUserDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUnionIds)) {
            body.put("receiverUnionIds", request.receiverUnionIds);
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
            new TeaPair("action", "QueryCustomerTaskUserDetail"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customers/tasks/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCustomerTaskUserDetailResponse());
    }

    public QueryCustomerTaskUserDetailResponse queryCustomerTaskUserDetail(QueryCustomerTaskUserDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomerTaskUserDetailHeaders headers = new QueryCustomerTaskUserDetailHeaders();
        return this.queryCustomerTaskUserDetailWithOptions(request, headers, runtime);
    }

    public QueryGroupResponse queryGroupWithOptions(QueryGroupRequest request, QueryGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGroupResponse());
    }

    public QueryGroupResponse queryGroup(QueryGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupHeaders headers = new QueryGroupHeaders();
        return this.queryGroupWithOptions(request, headers, runtime);
    }

    public QueryGroupMemberResponse queryGroupMemberWithOptions(QueryGroupMemberRequest request, QueryGroupMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryGroupMember"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/members/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGroupMemberResponse());
    }

    public QueryGroupMemberResponse queryGroupMember(QueryGroupMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
        return this.queryGroupMemberWithOptions(request, headers, runtime);
    }

    public QueryGroupSetResponse queryGroupSetWithOptions(QueryGroupSetRequest request, QueryGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryGroupSet"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groupSets"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGroupSetResponse());
    }

    public QueryGroupSetResponse queryGroupSet(QueryGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupSetHeaders headers = new QueryGroupSetHeaders();
        return this.queryGroupSetWithOptions(request, headers, runtime);
    }

    public QueryInstancesByMultiConditionsResponse queryInstancesByMultiConditionsWithOptions(QueryInstancesByMultiConditionsRequest request, QueryInstancesByMultiConditionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            body.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchFields)) {
            body.put("searchFields", request.searchFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortFields)) {
            body.put("sortFields", request.sortFields);
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
            new TeaPair("action", "QueryInstancesByMultiConditions"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customForms/instances/multiConditions/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryInstancesByMultiConditionsResponse());
    }

    public QueryInstancesByMultiConditionsResponse queryInstancesByMultiConditions(QueryInstancesByMultiConditionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryInstancesByMultiConditionsHeaders headers = new QueryInstancesByMultiConditionsHeaders();
        return this.queryInstancesByMultiConditionsWithOptions(request, headers, runtime);
    }

    public QuerySendMsgTaskStatisticsResponse querySendMsgTaskStatisticsWithOptions(QuerySendMsgTaskStatisticsRequest request, QuerySendMsgTaskStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QuerySendMsgTaskStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tasks/statistics/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySendMsgTaskStatisticsResponse());
    }

    public QuerySendMsgTaskStatisticsResponse querySendMsgTaskStatistics(QuerySendMsgTaskStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySendMsgTaskStatisticsHeaders headers = new QuerySendMsgTaskStatisticsHeaders();
        return this.querySendMsgTaskStatisticsWithOptions(request, headers, runtime);
    }

    public QuerySendMsgTaskStatisticsDetailResponse querySendMsgTaskStatisticsDetailWithOptions(QuerySendMsgTaskStatisticsDetailRequest request, QuerySendMsgTaskStatisticsDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QuerySendMsgTaskStatisticsDetail"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tasks/statistics/details/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySendMsgTaskStatisticsDetailResponse());
    }

    public QuerySendMsgTaskStatisticsDetailResponse querySendMsgTaskStatisticsDetail(QuerySendMsgTaskStatisticsDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySendMsgTaskStatisticsDetailHeaders headers = new QuerySendMsgTaskStatisticsDetailHeaders();
        return this.querySendMsgTaskStatisticsDetailWithOptions(request, headers, runtime);
    }

    public QueryServiceGroupMessageReadStatusResponse queryServiceGroupMessageReadStatusWithOptions(QueryServiceGroupMessageReadStatusRequest request, QueryServiceGroupMessageReadStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryServiceGroupMessageReadStatus"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/messages/readStatus/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryServiceGroupMessageReadStatusResponse());
    }

    public QueryServiceGroupMessageReadStatusResponse queryServiceGroupMessageReadStatus(QueryServiceGroupMessageReadStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryServiceGroupMessageReadStatusHeaders headers = new QueryServiceGroupMessageReadStatusHeaders();
        return this.queryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
    }

    public QueueNotifyResponse queueNotifyWithOptions(QueueNotifyRequest request, QueueNotifyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueueNotify"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/dts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueueNotifyResponse());
    }

    public QueueNotifyResponse queueNotify(QueueNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueueNotifyHeaders headers = new QueueNotifyHeaders();
        return this.queueNotifyWithOptions(request, headers, runtime);
    }

    public RemoveContactFromOrgResponse removeContactFromOrgWithOptions(RemoveContactFromOrgRequest request, RemoveContactFromOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contactUnionId)) {
            body.put("contactUnionId", request.contactUnionId);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RemoveContactFromOrg"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/organizations/contacts/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemoveContactFromOrgResponse());
    }

    public RemoveContactFromOrgResponse removeContactFromOrg(RemoveContactFromOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveContactFromOrgHeaders headers = new RemoveContactFromOrgHeaders();
        return this.removeContactFromOrgWithOptions(request, headers, runtime);
    }

    public ReportCustomerDetailResponse reportCustomerDetailWithOptions(ReportCustomerDetailRequest request, ReportCustomerDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReportCustomerDetail"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customers/activities/details/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReportCustomerDetailResponse());
    }

    public ReportCustomerDetailResponse reportCustomerDetail(ReportCustomerDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReportCustomerDetailHeaders headers = new ReportCustomerDetailHeaders();
        return this.reportCustomerDetailWithOptions(request, headers, runtime);
    }

    public ReportCustomerStatisticsResponse reportCustomerStatisticsWithOptions(ReportCustomerStatisticsRequest request, ReportCustomerStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ReportCustomerStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customers/activities/statistics/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ReportCustomerStatisticsResponse());
    }

    public ReportCustomerStatisticsResponse reportCustomerStatistics(ReportCustomerStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReportCustomerStatisticsHeaders headers = new ReportCustomerStatisticsHeaders();
        return this.reportCustomerStatisticsWithOptions(request, headers, runtime);
    }

    public ResubmitTicketResponse resubmitTicketWithOptions(ResubmitTicketRequest request, ResubmitTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.customFields)) {
            body.put("customFields", request.customFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.sceneContext)) {
            body.put("sceneContext", request.sceneContext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ResubmitTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/resubmit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ResubmitTicketResponse());
    }

    public ResubmitTicketResponse resubmitTicket(ResubmitTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ResubmitTicketHeaders headers = new ResubmitTicketHeaders();
        return this.resubmitTicketWithOptions(request, headers, runtime);
    }

    public RetractTicketResponse retractTicketWithOptions(RetractTicketRequest request, RetractTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "RetractTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/retract"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RetractTicketResponse());
    }

    public RetractTicketResponse retractTicket(RetractTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetractTicketHeaders headers = new RetractTicketHeaders();
        return this.retractTicketWithOptions(request, headers, runtime);
    }

    public RobotMessageRecallResponse robotMessageRecallWithOptions(RobotMessageRecallRequest request, RobotMessageRecallHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openMsgId)) {
            body.put("openMsgId", request.openMsgId);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RobotMessageRecall"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/robots/messages/recall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RobotMessageRecallResponse());
    }

    public RobotMessageRecallResponse robotMessageRecall(RobotMessageRecallRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RobotMessageRecallHeaders headers = new RobotMessageRecallHeaders();
        return this.robotMessageRecallWithOptions(request, headers, runtime);
    }

    public SaveFormInstanceResponse saveFormInstanceWithOptions(SaveFormInstanceRequest request, SaveFormInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.formDataList)) {
            body.put("formDataList", request.formDataList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUnionId)) {
            body.put("ownerUnionId", request.ownerUnionId);
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
            new TeaPair("action", "SaveFormInstance"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/forms/instances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveFormInstanceResponse());
    }

    public SaveFormInstanceResponse saveFormInstance(SaveFormInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveFormInstanceHeaders headers = new SaveFormInstanceHeaders();
        return this.saveFormInstanceWithOptions(request, headers, runtime);
    }

    public SearchGroupResponse searchGroupWithOptions(SearchGroupRequest request, SearchGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchGroupResponse());
    }

    public SearchGroupResponse searchGroup(SearchGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchGroupHeaders headers = new SearchGroupHeaders();
        return this.searchGroupWithOptions(request, headers, runtime);
    }

    public SendMsgByTaskResponse sendMsgByTaskWithOptions(SendMsgByTaskRequest request, SendMsgByTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.messageContent)) {
            body.put("messageContent", request.messageContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryGroup)) {
            body.put("queryGroup", request.queryGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendConfig)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SendMsgByTask"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/messages/tasks/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendMsgByTaskResponse());
    }

    public SendMsgByTaskResponse sendMsgByTask(SendMsgByTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendMsgByTaskHeaders headers = new SendMsgByTaskHeaders();
        return this.sendMsgByTaskWithOptions(request, headers, runtime);
    }

    public SendServiceGroupMessageResponse sendServiceGroupMessageWithOptions(SendServiceGroupMessageRequest request, SendServiceGroupMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SendServiceGroupMessage"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/messages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendServiceGroupMessageResponse());
    }

    public SendServiceGroupMessageResponse sendServiceGroupMessage(SendServiceGroupMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendServiceGroupMessageHeaders headers = new SendServiceGroupMessageHeaders();
        return this.sendServiceGroupMessageWithOptions(request, headers, runtime);
    }

    public SetRobotConfigResponse setRobotConfigWithOptions(SetRobotConfigRequest request, SetRobotConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SetRobotConfig"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/configs/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetRobotConfigResponse());
    }

    public SetRobotConfigResponse setRobotConfig(SetRobotConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetRobotConfigHeaders headers = new SetRobotConfigHeaders();
        return this.setRobotConfigWithOptions(request, headers, runtime);
    }

    public TakeTicketResponse takeTicketWithOptions(TakeTicketRequest request, TakeTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TakeTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/apply"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TakeTicketResponse());
    }

    public TakeTicketResponse takeTicket(TakeTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TakeTicketHeaders headers = new TakeTicketHeaders();
        return this.takeTicketWithOptions(request, headers, runtime);
    }

    public TopicStatisticsResponse topicStatisticsWithOptions(TopicStatisticsRequest request, TopicStatisticsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "TopicStatistics"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/voices/topics/statistics"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TopicStatisticsResponse());
    }

    public TopicStatisticsResponse topicStatistics(TopicStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TopicStatisticsHeaders headers = new TopicStatisticsHeaders();
        return this.topicStatisticsWithOptions(request, headers, runtime);
    }

    public TransferTicketResponse transferTicketWithOptions(TransferTicketRequest request, TransferTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.notify)) {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "TransferTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/transfer"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new TransferTicketResponse());
    }

    public TransferTicketResponse transferTicket(TransferTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TransferTicketHeaders headers = new TransferTicketHeaders();
        return this.transferTicketWithOptions(request, headers, runtime);
    }

    public UpdateGroupSetResponse updateGroupSetWithOptions(UpdateGroupSetRequest request, UpdateGroupSetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "UpdateGroupSet"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/groups/configurations"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateGroupSetResponse());
    }

    public UpdateGroupSetResponse updateGroupSet(UpdateGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
        return this.updateGroupSetWithOptions(request, headers, runtime);
    }

    public UpdateGroupTagResponse updateGroupTagWithOptions(UpdateGroupTagRequest request, UpdateGroupTagHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateGroupTag"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tags"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateGroupTagResponse());
    }

    public UpdateGroupTagResponse updateGroupTag(UpdateGroupTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateGroupTagHeaders headers = new UpdateGroupTagHeaders();
        return this.updateGroupTagWithOptions(request, headers, runtime);
    }

    public UpdateInstanceResponse updateInstanceWithOptions(UpdateInstanceRequest request, UpdateInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.externalBizId)) {
            body.put("externalBizId", request.externalBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCode)) {
            body.put("formCode", request.formCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formDataList)) {
            body.put("formDataList", request.formDataList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openDataInstanceId)) {
            body.put("openDataInstanceId", request.openDataInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUnionId)) {
            body.put("operatorUnionId", request.operatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerUnionId)) {
            body.put("ownerUnionId", request.ownerUnionId);
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
            new TeaPair("action", "UpdateInstance"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customForms/instances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInstanceResponse());
    }

    public UpdateInstanceResponse updateInstance(UpdateInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInstanceHeaders headers = new UpdateInstanceHeaders();
        return this.updateInstanceWithOptions(request, headers, runtime);
    }

    public UpdateTicketResponse updateTicketWithOptions(UpdateTicketRequest request, UpdateTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "UpdateTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateTicketResponse());
    }

    public UpdateTicketResponse updateTicket(UpdateTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTicketHeaders headers = new UpdateTicketHeaders();
        return this.updateTicketWithOptions(request, headers, runtime);
    }

    public UpgradeCloudGroupResponse upgradeCloudGroupWithOptions(UpgradeCloudGroupRequest request, UpgradeCloudGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpgradeCloudGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/cloudGroups/upgrade"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpgradeCloudGroupResponse());
    }

    public UpgradeCloudGroupResponse upgradeCloudGroup(UpgradeCloudGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpgradeCloudGroupHeaders headers = new UpgradeCloudGroupHeaders();
        return this.upgradeCloudGroupWithOptions(request, headers, runtime);
    }

    public UpgradeNormalGroupResponse upgradeNormalGroupWithOptions(UpgradeNormalGroupRequest request, UpgradeNormalGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpgradeNormalGroup"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/normalGroups/upgrade"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpgradeNormalGroupResponse());
    }

    public UpgradeNormalGroupResponse upgradeNormalGroup(UpgradeNormalGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpgradeNormalGroupHeaders headers = new UpgradeNormalGroupHeaders();
        return this.upgradeNormalGroupWithOptions(request, headers, runtime);
    }

    public UrgeTicketResponse urgeTicketWithOptions(UrgeTicketRequest request, UrgeTicketHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.ticketMemo)) {
            body.put("ticketMemo", request.ticketMemo);
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
            new TeaPair("action", "UrgeTicket"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/tickets/urge"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UrgeTicketResponse());
    }

    public UrgeTicketResponse urgeTicket(UrgeTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UrgeTicketHeaders headers = new UrgeTicketHeaders();
        return this.urgeTicketWithOptions(request, headers, runtime);
    }
}
