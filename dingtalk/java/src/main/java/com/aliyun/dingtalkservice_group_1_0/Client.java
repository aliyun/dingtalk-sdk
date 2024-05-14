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


    /**
     * @summary 添加联系人到群里
     *
     * @param request AddContactMemberToGroupRequest
     * @param headers AddContactMemberToGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddContactMemberToGroupResponse
     */
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

    /**
     * @summary 添加联系人到群里
     *
     * @param request AddContactMemberToGroupRequest
     * @return AddContactMemberToGroupResponse
     */
    public AddContactMemberToGroupResponse addContactMemberToGroup(AddContactMemberToGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddContactMemberToGroupHeaders headers = new AddContactMemberToGroupHeaders();
        return this.addContactMemberToGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加知识点
     *
     * @param request AddKnowledgeRequest
     * @param headers AddKnowledgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddKnowledgeResponse
     */
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

    /**
     * @summary 添加知识点
     *
     * @param request AddKnowledgeRequest
     * @return AddKnowledgeResponse
     */
    public AddKnowledgeResponse addKnowledge(AddKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddKnowledgeHeaders headers = new AddKnowledgeHeaders();
        return this.addKnowledgeWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加服务群知识库
     *
     * @param request AddLibraryRequest
     * @param headers AddLibraryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddLibraryResponse
     */
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

    /**
     * @summary 添加服务群知识库
     *
     * @param request AddLibraryRequest
     * @return AddLibraryResponse
     */
    public AddLibraryResponse addLibrary(AddLibraryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddLibraryHeaders headers = new AddLibraryHeaders();
        return this.addLibraryWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加服务群群成员
     *
     * @param request AddMemberToServiceGroupRequest
     * @param headers AddMemberToServiceGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddMemberToServiceGroupResponse
     */
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

    /**
     * @summary 添加服务群群成员
     *
     * @param request AddMemberToServiceGroupRequest
     * @return AddMemberToServiceGroupResponse
     */
    public AddMemberToServiceGroupResponse addMemberToServiceGroup(AddMemberToServiceGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddMemberToServiceGroupHeaders headers = new AddMemberToServiceGroupHeaders();
        return this.addMemberToServiceGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary OpenApi添加知识点类目
     *
     * @param request AddOpenCategoryRequest
     * @param headers AddOpenCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddOpenCategoryResponse
     */
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

    /**
     * @summary OpenApi添加知识点类目
     *
     * @param request AddOpenCategoryRequest
     * @return AddOpenCategoryResponse
     */
    public AddOpenCategoryResponse addOpenCategory(AddOpenCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOpenCategoryHeaders headers = new AddOpenCategoryHeaders();
        return this.addOpenCategoryWithOptions(request, headers, runtime);
    }

    /**
     * @summary OpenApi添加知识入库
     *
     * @param request AddOpenKnowledgeRequest
     * @param headers AddOpenKnowledgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddOpenKnowledgeResponse
     */
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

    /**
     * @summary OpenApi添加知识入库
     *
     * @param request AddOpenKnowledgeRequest
     * @return AddOpenKnowledgeResponse
     */
    public AddOpenKnowledgeResponse addOpenKnowledge(AddOpenKnowledgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOpenKnowledgeHeaders headers = new AddOpenKnowledgeHeaders();
        return this.addOpenKnowledgeWithOptions(request, headers, runtime);
    }

    /**
     * @summary 智能服务群知识库创建
     *
     * @param request AddOpenLibraryRequest
     * @param headers AddOpenLibraryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddOpenLibraryResponse
     */
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

    /**
     * @summary 智能服务群知识库创建
     *
     * @param request AddOpenLibraryRequest
     * @return AddOpenLibraryResponse
     */
    public AddOpenLibraryResponse addOpenLibrary(AddOpenLibraryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddOpenLibraryHeaders headers = new AddOpenLibraryHeaders();
        return this.addOpenLibraryWithOptions(request, headers, runtime);
    }

    /**
     * @summary 添加工单备注
     *
     * @param request AddTicketMemoRequest
     * @param headers AddTicketMemoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddTicketMemoResponse
     */
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

    /**
     * @summary 添加工单备注
     *
     * @param request AddTicketMemoRequest
     * @return AddTicketMemoResponse
     */
    public AddTicketMemoResponse addTicketMemo(AddTicketMemoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddTicketMemoHeaders headers = new AddTicketMemoHeaders();
        return this.addTicketMemoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 工单指派
     *
     * @param request AssignTicketRequest
     * @param headers AssignTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AssignTicketResponse
     */
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

    /**
     * @summary 工单指派
     *
     * @param request AssignTicketRequest
     * @return AssignTicketResponse
     */
    public AssignTicketResponse assignTicket(AssignTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AssignTicketHeaders headers = new AssignTicketHeaders();
        return this.assignTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量绑定服务群业务ID
     *
     * @param request BatchBindingGroupBizIdsRequest
     * @param headers BatchBindingGroupBizIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchBindingGroupBizIdsResponse
     */
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

    /**
     * @summary 批量绑定服务群业务ID
     *
     * @param request BatchBindingGroupBizIdsRequest
     * @return BatchBindingGroupBizIdsResponse
     */
    public BatchBindingGroupBizIdsResponse batchBindingGroupBizIds(BatchBindingGroupBizIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchBindingGroupBizIdsHeaders headers = new BatchBindingGroupBizIdsHeaders();
        return this.batchBindingGroupBizIdsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量查询群组配置
     *
     * @param request BatchGetGroupSetConfigRequest
     * @param headers BatchGetGroupSetConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchGetGroupSetConfigResponse
     */
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

    /**
     * @summary 批量查询群组配置
     *
     * @param request BatchGetGroupSetConfigRequest
     * @return BatchGetGroupSetConfigResponse
     */
    public BatchGetGroupSetConfigResponse batchGetGroupSetConfig(BatchGetGroupSetConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchGetGroupSetConfigHeaders headers = new BatchGetGroupSetConfigHeaders();
        return this.batchGetGroupSetConfigWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量查询客户群发任务
     *
     * @param request BatchQueryCustomerSendTaskRequest
     * @param headers BatchQueryCustomerSendTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryCustomerSendTaskResponse
     */
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

    /**
     * @summary 批量查询客户群发任务
     *
     * @param request BatchQueryCustomerSendTaskRequest
     * @return BatchQueryCustomerSendTaskResponse
     */
    public BatchQueryCustomerSendTaskResponse batchQueryCustomerSendTask(BatchQueryCustomerSendTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryCustomerSendTaskHeaders headers = new BatchQueryCustomerSendTaskHeaders();
        return this.batchQueryCustomerSendTaskWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量查询群成员
     *
     * @param request BatchQueryGroupMemberRequest
     * @param headers BatchQueryGroupMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryGroupMemberResponse
     */
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

    /**
     * @summary 批量查询群成员
     *
     * @param request BatchQueryGroupMemberRequest
     * @return BatchQueryGroupMemberResponse
     */
    public BatchQueryGroupMemberResponse batchQueryGroupMember(BatchQueryGroupMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryGroupMemberHeaders headers = new BatchQueryGroupMemberHeaders();
        return this.batchQueryGroupMemberWithOptions(request, headers, runtime);
    }

    /**
     * @summary 群发任务批量查询
     *
     * @param request BatchQuerySendMessageTaskRequest
     * @param headers BatchQuerySendMessageTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQuerySendMessageTaskResponse
     */
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

    /**
     * @summary 群发任务批量查询
     *
     * @param request BatchQuerySendMessageTaskRequest
     * @return BatchQuerySendMessageTaskResponse
     */
    public BatchQuerySendMessageTaskResponse batchQuerySendMessageTask(BatchQuerySendMessageTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQuerySendMessageTaskHeaders headers = new BatchQuerySendMessageTaskHeaders();
        return this.batchQuerySendMessageTaskWithOptions(request, headers, runtime);
    }

    /**
     * @summary 绑定服务群模板到团队
     *
     * @param request BoundTemplateToTeamRequest
     * @param headers BoundTemplateToTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BoundTemplateToTeamResponse
     */
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

    /**
     * @summary 绑定服务群模板到团队
     *
     * @param request BoundTemplateToTeamRequest
     * @return BoundTemplateToTeamResponse
     */
    public BoundTemplateToTeamResponse boundTemplateToTeam(BoundTemplateToTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BoundTemplateToTeamHeaders headers = new BoundTemplateToTeamHeaders();
        return this.boundTemplateToTeamWithOptions(request, headers, runtime);
    }

    /**
     * @summary 撤销工单
     *
     * @param request CancelTicketRequest
     * @param headers CancelTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelTicketResponse
     */
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

    /**
     * @summary 撤销工单
     *
     * @param request CancelTicketRequest
     * @return CancelTicketResponse
     */
    public CancelTicketResponse cancelTicket(CancelTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelTicketHeaders headers = new CancelTicketHeaders();
        return this.cancelTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 心声总览自定义分类统计
     *
     * @param request CategoryStatisticsRequest
     * @param headers CategoryStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CategoryStatisticsResponse
     */
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

    /**
     * @summary 心声总览自定义分类统计
     *
     * @param request CategoryStatisticsRequest
     * @return CategoryStatisticsResponse
     */
    public CategoryStatisticsResponse categoryStatistics(CategoryStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CategoryStatisticsHeaders headers = new CategoryStatisticsHeaders();
        return this.categoryStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 关闭会话回调
     *
     * @param request CloseConversationRequest
     * @param headers CloseConversationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CloseConversationResponse
     */
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

    /**
     * @summary 关闭会话回调
     *
     * @param request CloseConversationRequest
     * @return CloseConversationResponse
     */
    public CloseConversationResponse closeConversation(CloseConversationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseConversationHeaders headers = new CloseConversationHeaders();
        return this.closeConversationWithOptions(request, headers, runtime);
    }

    /**
     * @summary 关闭人工会话
     *
     * @param request CloseHumanSessionRequest
     * @param headers CloseHumanSessionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CloseHumanSessionResponse
     */
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

    /**
     * @summary 关闭人工会话
     *
     * @param request CloseHumanSessionRequest
     * @return CloseHumanSessionResponse
     */
    public CloseHumanSessionResponse closeHumanSession(CloseHumanSessionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseHumanSessionHeaders headers = new CloseHumanSessionHeaders();
        return this.closeHumanSessionWithOptions(request, headers, runtime);
    }

    /**
     * @summary 客服分配成功通知回调
     *
     * @param request ConversationCreatedNotifyRequest
     * @param headers ConversationCreatedNotifyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConversationCreatedNotifyResponse
     */
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

    /**
     * @summary 客服分配成功通知回调
     *
     * @param request ConversationCreatedNotifyRequest
     * @return ConversationCreatedNotifyResponse
     */
    public ConversationCreatedNotifyResponse conversationCreatedNotify(ConversationCreatedNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConversationCreatedNotifyHeaders headers = new ConversationCreatedNotifyHeaders();
        return this.conversationCreatedNotifyWithOptions(request, headers, runtime);
    }

    /**
     * @summary 会话转接开始通知回调
     *
     * @param request ConversationTransferBeginNotifyRequest
     * @param headers ConversationTransferBeginNotifyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConversationTransferBeginNotifyResponse
     */
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

    /**
     * @summary 会话转接开始通知回调
     *
     * @param request ConversationTransferBeginNotifyRequest
     * @return ConversationTransferBeginNotifyResponse
     */
    public ConversationTransferBeginNotifyResponse conversationTransferBeginNotify(ConversationTransferBeginNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConversationTransferBeginNotifyHeaders headers = new ConversationTransferBeginNotifyHeaders();
        return this.conversationTransferBeginNotifyWithOptions(request, headers, runtime);
    }

    /**
     * @summary 会话转接完成通知回调
     *
     * @param request ConversationTransferCompleteNotifyRequest
     * @param headers ConversationTransferCompleteNotifyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConversationTransferCompleteNotifyResponse
     */
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

    /**
     * @summary 会话转接完成通知回调
     *
     * @param request ConversationTransferCompleteNotifyRequest
     * @return ConversationTransferCompleteNotifyResponse
     */
    public ConversationTransferCompleteNotifyResponse conversationTransferCompleteNotify(ConversationTransferCompleteNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConversationTransferCompleteNotifyHeaders headers = new ConversationTransferCompleteNotifyHeaders();
        return this.conversationTransferCompleteNotifyWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建服务群
     *
     * @param request CreateGroupRequest
     * @param headers CreateGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateGroupResponse
     */
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

    /**
     * @summary 创建服务群
     *
     * @param request CreateGroupRequest
     * @return CreateGroupResponse
     */
    public CreateGroupResponse createGroup(CreateGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupHeaders headers = new CreateGroupHeaders();
        return this.createGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建主动会话接口
     *
     * @param request CreateGroupConversationRequest
     * @param headers CreateGroupConversationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateGroupConversationResponse
     */
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

    /**
     * @summary 创建主动会话接口
     *
     * @param request CreateGroupConversationRequest
     * @return CreateGroupConversationResponse
     */
    public CreateGroupConversationResponse createGroupConversation(CreateGroupConversationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupConversationHeaders headers = new CreateGroupConversationHeaders();
        return this.createGroupConversationWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建服务群群分组
     *
     * @param request CreateGroupSetRequest
     * @param headers CreateGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateGroupSetResponse
     */
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

    /**
     * @summary 创建服务群群分组
     *
     * @param request CreateGroupSetRequest
     * @return CreateGroupSetResponse
     */
    public CreateGroupSetResponse createGroupSet(CreateGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupSetHeaders headers = new CreateGroupSetHeaders();
        return this.createGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群新增表单实例
     *
     * @param request CreateInstanceRequest
     * @param headers CreateInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateInstanceResponse
     */
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

    /**
     * @summary 服务群新增表单实例
     *
     * @param request CreateInstanceRequest
     * @return CreateInstanceResponse
     */
    public CreateInstanceResponse createInstance(CreateInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateInstanceHeaders headers = new CreateInstanceHeaders();
        return this.createInstanceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建服务群团队
     *
     * @param request CreateTeamRequest
     * @param headers CreateTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTeamResponse
     */
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

    /**
     * @summary 创建服务群团队
     *
     * @param request CreateTeamRequest
     * @return CreateTeamResponse
     */
    public CreateTeamResponse createTeam(CreateTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTeamHeaders headers = new CreateTeamHeaders();
        return this.createTeamWithOptions(request, headers, runtime);
    }

    /**
     * @summary 创建工单
     *
     * @param request CreateTicketRequest
     * @param headers CreateTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateTicketResponse
     */
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

    /**
     * @summary 创建工单
     *
     * @param request CreateTicketRequest
     * @return CreateTicketResponse
     */
    public CreateTicketResponse createTicket(CreateTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTicketHeaders headers = new CreateTicketHeaders();
        return this.createTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 客户群发任务
     *
     * @param request CustomerSendMsgTaskRequest
     * @param headers CustomerSendMsgTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomerSendMsgTaskResponse
     */
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

    /**
     * @summary 客户群发任务
     *
     * @param request CustomerSendMsgTaskRequest
     * @return CustomerSendMsgTaskResponse
     */
    public CustomerSendMsgTaskResponse customerSendMsgTask(CustomerSendMsgTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomerSendMsgTaskHeaders headers = new CustomerSendMsgTaskHeaders();
        return this.customerSendMsgTaskWithOptions(request, headers, runtime);
    }

    /**
     * @summary 从群或者群组剔除成员
     *
     * @param request DeleteGroupMembersFromGroupRequest
     * @param headers DeleteGroupMembersFromGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteGroupMembersFromGroupResponse
     */
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

    /**
     * @summary 从群或者群组剔除成员
     *
     * @param request DeleteGroupMembersFromGroupRequest
     * @return DeleteGroupMembersFromGroupResponse
     */
    public DeleteGroupMembersFromGroupResponse deleteGroupMembersFromGroup(DeleteGroupMembersFromGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteGroupMembersFromGroupHeaders headers = new DeleteGroupMembersFromGroupHeaders();
        return this.deleteGroupMembersFromGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群删除表单实例
     *
     * @param request DeleteInstanceRequest
     * @param headers DeleteInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteInstanceResponse
     */
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

    /**
     * @summary 服务群删除表单实例
     *
     * @param request DeleteInstanceRequest
     * @return DeleteInstanceResponse
     */
    public DeleteInstanceResponse deleteInstance(DeleteInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteInstanceHeaders headers = new DeleteInstanceHeaders();
        return this.deleteInstanceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群删除知识点
     *
     * @param request DeleteKnowledgeRequest
     * @param headers DeleteKnowledgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteKnowledgeResponse
     */
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

    /**
     * @summary 服务群删除知识点
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
     * @summary 客户心声负面情绪统计
     *
     * @param request EmotionStatisticsRequest
     * @param headers EmotionStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EmotionStatisticsResponse
     */
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

    /**
     * @summary 客户心声负面情绪统计
     *
     * @param request EmotionStatisticsRequest
     * @return EmotionStatisticsResponse
     */
    public EmotionStatisticsResponse emotionStatistics(EmotionStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EmotionStatisticsHeaders headers = new EmotionStatisticsHeaders();
        return this.emotionStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 结单
     *
     * @param request FinishTicketRequest
     * @param headers FinishTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FinishTicketResponse
     */
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

    /**
     * @summary 结单
     *
     * @param request FinishTicketRequest
     * @return FinishTicketResponse
     */
    public FinishTicketResponse finishTicket(FinishTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FinishTicketHeaders headers = new FinishTicketHeaders();
        return this.finishTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取签权Token
     *
     * @param request GetAuthTokenRequest
     * @param headers GetAuthTokenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAuthTokenResponse
     */
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

    /**
     * @summary 获取签权Token
     *
     * @param request GetAuthTokenRequest
     * @return GetAuthTokenResponse
     */
    public GetAuthTokenResponse getAuthToken(GetAuthTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAuthTokenHeaders headers = new GetAuthTokenHeaders();
        return this.getAuthTokenWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群通过实例ID集合批量查询表单实例数据
     *
     * @param request GetInstancesByIdsRequest
     * @param headers GetInstancesByIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInstancesByIdsResponse
     */
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

    /**
     * @summary 服务群通过实例ID集合批量查询表单实例数据
     *
     * @param request GetInstancesByIdsRequest
     * @return GetInstancesByIdsResponse
     */
    public GetInstancesByIdsResponse getInstancesByIds(GetInstancesByIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInstancesByIdsHeaders headers = new GetInstancesByIdsHeaders();
        return this.getInstancesByIdsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取负面心声词云
     *
     * @param request GetNegativeWordCloudRequest
     * @param headers GetNegativeWordCloudHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetNegativeWordCloudResponse
     */
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

    /**
     * @summary 获取负面心声词云
     *
     * @param request GetNegativeWordCloudRequest
     * @return GetNegativeWordCloudResponse
     */
    public GetNegativeWordCloudResponse getNegativeWordCloud(GetNegativeWordCloudRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetNegativeWordCloudHeaders headers = new GetNegativeWordCloudHeaders();
        return this.getNegativeWordCloudWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取临时访问链接
     *
     * @param request GetOssTempUrlRequest
     * @param headers GetOssTempUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOssTempUrlResponse
     */
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

    /**
     * @summary 获取临时访问链接
     *
     * @param request GetOssTempUrlRequest
     * @return GetOssTempUrlResponse
     */
    public GetOssTempUrlResponse getOssTempUrl(GetOssTempUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOssTempUrlHeaders headers = new GetOssTempUrlHeaders();
        return this.getOssTempUrlWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取表单上传凭证
     *
     * @param request GetStoragePolicyRequest
     * @param headers GetStoragePolicyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetStoragePolicyResponse
     */
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

    /**
     * @summary 获取表单上传凭证
     *
     * @param request GetStoragePolicyRequest
     * @return GetStoragePolicyResponse
     */
    public GetStoragePolicyResponse getStoragePolicy(GetStoragePolicyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetStoragePolicyHeaders headers = new GetStoragePolicyHeaders();
        return this.getStoragePolicyWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询工单详情
     *
     * @param request GetTicketRequest
     * @param headers GetTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTicketResponse
     */
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

    /**
     * @summary 查询工单详情
     *
     * @param request GetTicketRequest
     * @return GetTicketResponse
     */
    public GetTicketResponse getTicket(GetTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTicketHeaders headers = new GetTicketHeaders();
        return this.getTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取心声词云
     *
     * @param request GetWordCloudRequest
     * @param headers GetWordCloudHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetWordCloudResponse
     */
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

    /**
     * @summary 获取心声词云
     *
     * @param request GetWordCloudRequest
     * @return GetWordCloudResponse
     */
    public GetWordCloudResponse getWordCloud(GetWordCloudRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetWordCloudHeaders headers = new GetWordCloudHeaders();
        return this.getWordCloudWithOptions(request, headers, runtime);
    }

    /**
     * @summary 心声总览群统计
     *
     * @param request GroupStatisticsRequest
     * @param headers GroupStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GroupStatisticsResponse
     */
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

    /**
     * @summary 心声总览群统计
     *
     * @param request GroupStatisticsRequest
     * @return GroupStatisticsResponse
     */
    public GroupStatisticsResponse groupStatistics(GroupStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GroupStatisticsHeaders headers = new GroupStatisticsHeaders();
        return this.groupStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 心声总览意图&自定义分类统计
     *
     * @param request IntentionCategoryStatisticsRequest
     * @param headers IntentionCategoryStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IntentionCategoryStatisticsResponse
     */
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

    /**
     * @summary 心声总览意图&自定义分类统计
     *
     * @param request IntentionCategoryStatisticsRequest
     * @return IntentionCategoryStatisticsResponse
     */
    public IntentionCategoryStatisticsResponse intentionCategoryStatistics(IntentionCategoryStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IntentionCategoryStatisticsHeaders headers = new IntentionCategoryStatisticsHeaders();
        return this.intentionCategoryStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 心声总览意图统计
     *
     * @param request IntentionStatisticsRequest
     * @param headers IntentionStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IntentionStatisticsResponse
     */
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

    /**
     * @summary 心声总览意图统计
     *
     * @param request IntentionStatisticsRequest
     * @return IntentionStatisticsResponse
     */
    public IntentionStatisticsResponse intentionStatistics(IntentionStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IntentionStatisticsHeaders headers = new IntentionStatisticsHeaders();
        return this.intentionStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询工单操作记录
     *
     * @param request ListTicketOperateRecordRequest
     * @param headers ListTicketOperateRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListTicketOperateRecordResponse
     */
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

    /**
     * @summary 查询工单操作记录
     *
     * @param request ListTicketOperateRecordRequest
     * @return ListTicketOperateRecordResponse
     */
    public ListTicketOperateRecordResponse listTicketOperateRecord(ListTicketOperateRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListTicketOperateRecordHeaders headers = new ListTicketOperateRecordHeaders();
        return this.listTicketOperateRecordWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询用户所在团队
     *
     * @param headers ListUserTeamsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListUserTeamsResponse
     */
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

    /**
     * @summary 查询用户所在团队
     *
     * @return ListUserTeamsResponse
     */
    public ListUserTeamsResponse listUserTeams(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListUserTeamsHeaders headers = new ListUserTeamsHeaders();
        return this.listUserTeamsWithOptions(userId, headers, runtime);
    }

    /**
     * @summary 查询服务群活跃成员
     *
     * @param request QueryActiveUsersRequest
     * @param headers QueryActiveUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryActiveUsersResponse
     */
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

    /**
     * @summary 查询服务群活跃成员
     *
     * @param request QueryActiveUsersRequest
     * @return QueryActiveUsersResponse
     */
    public QueryActiveUsersResponse queryActiveUsers(QueryActiveUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryActiveUsersHeaders headers = new QueryActiveUsersHeaders();
        return this.queryActiveUsersWithOptions(request, headers, runtime);
    }

    /**
     * @summary 群联系人画像检索
     *
     * @param request QueryCrmGroupContactRequest
     * @param headers QueryCrmGroupContactHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCrmGroupContactResponse
     */
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

    /**
     * @summary 群联系人画像检索
     *
     * @param request QueryCrmGroupContactRequest
     * @return QueryCrmGroupContactResponse
     */
    public QueryCrmGroupContactResponse queryCrmGroupContact(QueryCrmGroupContactRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCrmGroupContactHeaders headers = new QueryCrmGroupContactHeaders();
        return this.queryCrmGroupContactWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询客户信息
     *
     * @param request QueryCustomerCardRequest
     * @param headers QueryCustomerCardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCustomerCardResponse
     */
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

    /**
     * @summary 查询客户信息
     *
     * @param request QueryCustomerCardRequest
     * @return QueryCustomerCardResponse
     */
    public QueryCustomerCardResponse queryCustomerCard(QueryCustomerCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomerCardHeaders headers = new QueryCustomerCardHeaders();
        return this.queryCustomerCardWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询客户群发任务客户触达详情
     *
     * @param request QueryCustomerTaskUserDetailRequest
     * @param headers QueryCustomerTaskUserDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCustomerTaskUserDetailResponse
     */
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

    /**
     * @summary 查询客户群发任务客户触达详情
     *
     * @param request QueryCustomerTaskUserDetailRequest
     * @return QueryCustomerTaskUserDetailResponse
     */
    public QueryCustomerTaskUserDetailResponse queryCustomerTaskUserDetail(QueryCustomerTaskUserDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomerTaskUserDetailHeaders headers = new QueryCustomerTaskUserDetailHeaders();
        return this.queryCustomerTaskUserDetailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询单个服务群信息
     *
     * @param request QueryGroupRequest
     * @param headers QueryGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGroupResponse
     */
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

    /**
     * @summary 查询单个服务群信息
     *
     * @param request QueryGroupRequest
     * @return QueryGroupResponse
     */
    public QueryGroupResponse queryGroup(QueryGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupHeaders headers = new QueryGroupHeaders();
        return this.queryGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询指定群成员
     *
     * @param request QueryGroupMemberRequest
     * @param headers QueryGroupMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGroupMemberResponse
     */
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

    /**
     * @summary 查询指定群成员
     *
     * @param request QueryGroupMemberRequest
     * @return QueryGroupMemberResponse
     */
    public QueryGroupMemberResponse queryGroupMember(QueryGroupMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupMemberHeaders headers = new QueryGroupMemberHeaders();
        return this.queryGroupMemberWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询服务群群组信息
     *
     * @param request QueryGroupSetRequest
     * @param headers QueryGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGroupSetResponse
     */
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

    /**
     * @summary 查询服务群群组信息
     *
     * @param request QueryGroupSetRequest
     * @return QueryGroupSetResponse
     */
    public QueryGroupSetResponse queryGroupSet(QueryGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupSetHeaders headers = new QueryGroupSetHeaders();
        return this.queryGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群通过多添件进行组合检索表单数据实例集合
     *
     * @param request QueryInstancesByMultiConditionsRequest
     * @param headers QueryInstancesByMultiConditionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryInstancesByMultiConditionsResponse
     */
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

    /**
     * @summary 服务群通过多添件进行组合检索表单数据实例集合
     *
     * @param request QueryInstancesByMultiConditionsRequest
     * @return QueryInstancesByMultiConditionsResponse
     */
    public QueryInstancesByMultiConditionsResponse queryInstancesByMultiConditions(QueryInstancesByMultiConditionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryInstancesByMultiConditionsHeaders headers = new QueryInstancesByMultiConditionsHeaders();
        return this.queryInstancesByMultiConditionsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 群发任务统计查询
     *
     * @param request QuerySendMsgTaskStatisticsRequest
     * @param headers QuerySendMsgTaskStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySendMsgTaskStatisticsResponse
     */
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

    /**
     * @summary 群发任务统计查询
     *
     * @param request QuerySendMsgTaskStatisticsRequest
     * @return QuerySendMsgTaskStatisticsResponse
     */
    public QuerySendMsgTaskStatisticsResponse querySendMsgTaskStatistics(QuerySendMsgTaskStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySendMsgTaskStatisticsHeaders headers = new QuerySendMsgTaskStatisticsHeaders();
        return this.querySendMsgTaskStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 群发任务群维度的统计数据
     *
     * @param request QuerySendMsgTaskStatisticsDetailRequest
     * @param headers QuerySendMsgTaskStatisticsDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySendMsgTaskStatisticsDetailResponse
     */
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

    /**
     * @summary 群发任务群维度的统计数据
     *
     * @param request QuerySendMsgTaskStatisticsDetailRequest
     * @return QuerySendMsgTaskStatisticsDetailResponse
     */
    public QuerySendMsgTaskStatisticsDetailResponse querySendMsgTaskStatisticsDetail(QuerySendMsgTaskStatisticsDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySendMsgTaskStatisticsDetailHeaders headers = new QuerySendMsgTaskStatisticsDetailHeaders();
        return this.querySendMsgTaskStatisticsDetailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查消息的已读/未读列表
     *
     * @param request QueryServiceGroupMessageReadStatusRequest
     * @param headers QueryServiceGroupMessageReadStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryServiceGroupMessageReadStatusResponse
     */
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

    /**
     * @summary 查消息的已读/未读列表
     *
     * @param request QueryServiceGroupMessageReadStatusRequest
     * @return QueryServiceGroupMessageReadStatusResponse
     */
    public QueryServiceGroupMessageReadStatusResponse queryServiceGroupMessageReadStatus(QueryServiceGroupMessageReadStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryServiceGroupMessageReadStatusHeaders headers = new QueryServiceGroupMessageReadStatusHeaders();
        return this.queryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
    }

    /**
     * @summary 外部DT工作台排队通知回调
     *
     * @param request QueueNotifyRequest
     * @param headers QueueNotifyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueueNotifyResponse
     */
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

    /**
     * @summary 外部DT工作台排队通知回调
     *
     * @param request QueueNotifyRequest
     * @return QueueNotifyResponse
     */
    public QueueNotifyResponse queueNotify(QueueNotifyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueueNotifyHeaders headers = new QueueNotifyHeaders();
        return this.queueNotifyWithOptions(request, headers, runtime);
    }

    /**
     * @summary 组织剔除联系人
     *
     * @param request RemoveContactFromOrgRequest
     * @param headers RemoveContactFromOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemoveContactFromOrgResponse
     */
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

    /**
     * @summary 组织剔除联系人
     *
     * @param request RemoveContactFromOrgRequest
     * @return RemoveContactFromOrgResponse
     */
    public RemoveContactFromOrgResponse removeContactFromOrg(RemoveContactFromOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemoveContactFromOrgHeaders headers = new RemoveContactFromOrgHeaders();
        return this.removeContactFromOrgWithOptions(request, headers, runtime);
    }

    /**
     * @summary 指定群的客户活跃明细查询
     *
     * @param request ReportCustomerDetailRequest
     * @param headers ReportCustomerDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReportCustomerDetailResponse
     */
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

    /**
     * @summary 指定群的客户活跃明细查询
     *
     * @param request ReportCustomerDetailRequest
     * @return ReportCustomerDetailResponse
     */
    public ReportCustomerDetailResponse reportCustomerDetail(ReportCustomerDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReportCustomerDetailHeaders headers = new ReportCustomerDetailHeaders();
        return this.reportCustomerDetailWithOptions(request, headers, runtime);
    }

    /**
     * @summary 客户活跃明细指标查询
     *
     * @param request ReportCustomerStatisticsRequest
     * @param headers ReportCustomerStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ReportCustomerStatisticsResponse
     */
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

    /**
     * @summary 客户活跃明细指标查询
     *
     * @param request ReportCustomerStatisticsRequest
     * @return ReportCustomerStatisticsResponse
     */
    public ReportCustomerStatisticsResponse reportCustomerStatistics(ReportCustomerStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ReportCustomerStatisticsHeaders headers = new ReportCustomerStatisticsHeaders();
        return this.reportCustomerStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 重新提交工单
     *
     * @param request ResubmitTicketRequest
     * @param headers ResubmitTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ResubmitTicketResponse
     */
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

    /**
     * @summary 重新提交工单
     *
     * @param request ResubmitTicketRequest
     * @return ResubmitTicketResponse
     */
    public ResubmitTicketResponse resubmitTicket(ResubmitTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ResubmitTicketHeaders headers = new ResubmitTicketHeaders();
        return this.resubmitTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 撤回工单
     *
     * @param request RetractTicketRequest
     * @param headers RetractTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RetractTicketResponse
     */
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

    /**
     * @summary 撤回工单
     *
     * @param request RetractTicketRequest
     * @return RetractTicketResponse
     */
    public RetractTicketResponse retractTicket(RetractTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RetractTicketHeaders headers = new RetractTicketHeaders();
        return this.retractTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 指定群的机器人消息撤回
     *
     * @param request RobotMessageRecallRequest
     * @param headers RobotMessageRecallHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RobotMessageRecallResponse
     */
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

    /**
     * @summary 指定群的机器人消息撤回
     *
     * @param request RobotMessageRecallRequest
     * @return RobotMessageRecallResponse
     */
    public RobotMessageRecallResponse robotMessageRecall(RobotMessageRecallRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RobotMessageRecallHeaders headers = new RobotMessageRecallHeaders();
        return this.robotMessageRecallWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群新增表单实例
     *
     * @param request SaveFormInstanceRequest
     * @param headers SaveFormInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveFormInstanceResponse
     */
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

    /**
     * @summary 服务群新增表单实例
     *
     * @param request SaveFormInstanceRequest
     * @return SaveFormInstanceResponse
     */
    public SaveFormInstanceResponse saveFormInstance(SaveFormInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveFormInstanceHeaders headers = new SaveFormInstanceHeaders();
        return this.saveFormInstanceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 搜索服务群
     *
     * @param request SearchGroupRequest
     * @param headers SearchGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchGroupResponse
     */
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

    /**
     * @summary 搜索服务群
     *
     * @param request SearchGroupRequest
     * @return SearchGroupResponse
     */
    public SearchGroupResponse searchGroup(SearchGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchGroupHeaders headers = new SearchGroupHeaders();
        return this.searchGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群发任务
     *
     * @param request SendMsgByTaskRequest
     * @param headers SendMsgByTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendMsgByTaskResponse
     */
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

    /**
     * @summary 服务群发任务
     *
     * @param request SendMsgByTaskRequest
     * @return SendMsgByTaskResponse
     */
    public SendMsgByTaskResponse sendMsgByTask(SendMsgByTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendMsgByTaskHeaders headers = new SendMsgByTaskHeaders();
        return this.sendMsgByTaskWithOptions(request, headers, runtime);
    }

    /**
     * @summary 增强版客户群发
     *
     * @param request SendMsgByTaskSupportInviteJoinOrgRequest
     * @param headers SendMsgByTaskSupportInviteJoinOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendMsgByTaskSupportInviteJoinOrgResponse
     */
    public SendMsgByTaskSupportInviteJoinOrgResponse sendMsgByTaskSupportInviteJoinOrgWithOptions(SendMsgByTaskSupportInviteJoinOrgRequest request, SendMsgByTaskSupportInviteJoinOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.messageContent)) {
            body.put("messageContent", request.messageContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobilePhones)) {
            body.put("mobilePhones", request.mobilePhones);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needUrlTrack)) {
            body.put("needUrlTrack", request.needUrlTrack);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendChannel)) {
            body.put("sendChannel", request.sendChannel);
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
            new TeaPair("action", "SendMsgByTaskSupportInviteJoinOrg"),
            new TeaPair("version", "serviceGroup_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/serviceGroup/customers/tasks/groupSend"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendMsgByTaskSupportInviteJoinOrgResponse());
    }

    /**
     * @summary 增强版客户群发
     *
     * @param request SendMsgByTaskSupportInviteJoinOrgRequest
     * @return SendMsgByTaskSupportInviteJoinOrgResponse
     */
    public SendMsgByTaskSupportInviteJoinOrgResponse sendMsgByTaskSupportInviteJoinOrg(SendMsgByTaskSupportInviteJoinOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendMsgByTaskSupportInviteJoinOrgHeaders headers = new SendMsgByTaskSupportInviteJoinOrgHeaders();
        return this.sendMsgByTaskSupportInviteJoinOrgWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群发消息
     *
     * @param request SendServiceGroupMessageRequest
     * @param headers SendServiceGroupMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendServiceGroupMessageResponse
     */
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
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendServiceGroupMessageResponse());
    }

    /**
     * @summary 服务群发消息
     *
     * @param request SendServiceGroupMessageRequest
     * @return SendServiceGroupMessageResponse
     */
    public SendServiceGroupMessageResponse sendServiceGroupMessage(SendServiceGroupMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendServiceGroupMessageHeaders headers = new SendServiceGroupMessageHeaders();
        return this.sendServiceGroupMessageWithOptions(request, headers, runtime);
    }

    /**
     * @summary 执行阿里内部用户群组机器人服务开关
     *
     * @param request SetRobotConfigRequest
     * @param headers SetRobotConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetRobotConfigResponse
     */
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

    /**
     * @summary 执行阿里内部用户群组机器人服务开关
     *
     * @param request SetRobotConfigRequest
     * @return SetRobotConfigResponse
     */
    public SetRobotConfigResponse setRobotConfig(SetRobotConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetRobotConfigHeaders headers = new SetRobotConfigHeaders();
        return this.setRobotConfigWithOptions(request, headers, runtime);
    }

    /**
     * @summary 申领工单
     *
     * @param request TakeTicketRequest
     * @param headers TakeTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TakeTicketResponse
     */
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

    /**
     * @summary 申领工单
     *
     * @param request TakeTicketRequest
     * @return TakeTicketResponse
     */
    public TakeTicketResponse takeTicket(TakeTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TakeTicketHeaders headers = new TakeTicketHeaders();
        return this.takeTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 客户心声热门话题统计
     *
     * @param request TopicStatisticsRequest
     * @param headers TopicStatisticsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TopicStatisticsResponse
     */
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

    /**
     * @summary 客户心声热门话题统计
     *
     * @param request TopicStatisticsRequest
     * @return TopicStatisticsResponse
     */
    public TopicStatisticsResponse topicStatistics(TopicStatisticsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TopicStatisticsHeaders headers = new TopicStatisticsHeaders();
        return this.topicStatisticsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 转交工单
     *
     * @param request TransferTicketRequest
     * @param headers TransferTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return TransferTicketResponse
     */
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

    /**
     * @summary 转交工单
     *
     * @param request TransferTicketRequest
     * @return TransferTicketResponse
     */
    public TransferTicketResponse transferTicket(TransferTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        TransferTicketHeaders headers = new TransferTicketHeaders();
        return this.transferTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 变更群的群组配置信息
     *
     * @param request UpdateGroupSetRequest
     * @param headers UpdateGroupSetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateGroupSetResponse
     */
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

    /**
     * @summary 变更群的群组配置信息
     *
     * @param request UpdateGroupSetRequest
     * @return UpdateGroupSetResponse
     */
    public UpdateGroupSetResponse updateGroupSet(UpdateGroupSetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateGroupSetHeaders headers = new UpdateGroupSetHeaders();
        return this.updateGroupSetWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新服务群标签
     *
     * @param request UpdateGroupTagRequest
     * @param headers UpdateGroupTagHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateGroupTagResponse
     */
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

    /**
     * @summary 更新服务群标签
     *
     * @param request UpdateGroupTagRequest
     * @return UpdateGroupTagResponse
     */
    public UpdateGroupTagResponse updateGroupTag(UpdateGroupTagRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateGroupTagHeaders headers = new UpdateGroupTagHeaders();
        return this.updateGroupTagWithOptions(request, headers, runtime);
    }

    /**
     * @summary 服务群更新表单实例
     *
     * @param request UpdateInstanceRequest
     * @param headers UpdateInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInstanceResponse
     */
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

    /**
     * @summary 服务群更新表单实例
     *
     * @param request UpdateInstanceRequest
     * @return UpdateInstanceResponse
     */
    public UpdateInstanceResponse updateInstance(UpdateInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInstanceHeaders headers = new UpdateInstanceHeaders();
        return this.updateInstanceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新工单自定义字段
     *
     * @param request UpdateTicketRequest
     * @param headers UpdateTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateTicketResponse
     */
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

    /**
     * @summary 更新工单自定义字段
     *
     * @param request UpdateTicketRequest
     * @return UpdateTicketResponse
     */
    public UpdateTicketResponse updateTicket(UpdateTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateTicketHeaders headers = new UpdateTicketHeaders();
        return this.updateTicketWithOptions(request, headers, runtime);
    }

    /**
     * @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
     *
     * @param request UpgradeCloudGroupRequest
     * @param headers UpgradeCloudGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpgradeCloudGroupResponse
     */
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

    /**
     * @summary 将智能云客服下的旧版服务群升级为钉钉智能服务群
     *
     * @param request UpgradeCloudGroupRequest
     * @return UpgradeCloudGroupResponse
     */
    public UpgradeCloudGroupResponse upgradeCloudGroup(UpgradeCloudGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpgradeCloudGroupHeaders headers = new UpgradeCloudGroupHeaders();
        return this.upgradeCloudGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 将常规钉群升级为钉钉智能服务群
     *
     * @param request UpgradeNormalGroupRequest
     * @param headers UpgradeNormalGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpgradeNormalGroupResponse
     */
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

    /**
     * @summary 将常规钉群升级为钉钉智能服务群
     *
     * @param request UpgradeNormalGroupRequest
     * @return UpgradeNormalGroupResponse
     */
    public UpgradeNormalGroupResponse upgradeNormalGroup(UpgradeNormalGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpgradeNormalGroupHeaders headers = new UpgradeNormalGroupHeaders();
        return this.upgradeNormalGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 工单催办
     *
     * @param request UrgeTicketRequest
     * @param headers UrgeTicketHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UrgeTicketResponse
     */
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

    /**
     * @summary 工单催办
     *
     * @param request UrgeTicketRequest
     * @return UrgeTicketResponse
     */
    public UrgeTicketResponse urgeTicket(UrgeTicketRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UrgeTicketHeaders headers = new UrgeTicketHeaders();
        return this.urgeTicketWithOptions(request, headers, runtime);
    }
}
