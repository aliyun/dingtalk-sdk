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


    public DeleteKnowledgeResponse deleteKnowledge(DeleteKnowledgeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteKnowledgeHeaders headers = new DeleteKnowledgeHeaders();
        return this.deleteKnowledgeWithOptions(request, headers, runtime);
    }

    public DeleteKnowledgeResponse deleteKnowledgeWithOptions(DeleteKnowledgeRequest request, DeleteKnowledgeHeaders headers, RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.libraryKey)) {
            body.put("libraryKey", request.libraryKey);
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges/batchDelete", "json", req, runtime), new DeleteKnowledgeResponse());
    }

    public SearchGroupResponse searchGroup(SearchGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchGroupHeaders headers = new SearchGroupHeaders();
        return this.searchGroupWithOptions(request, headers, runtime);
    }

    public SearchGroupResponse searchGroupWithOptions(SearchGroupRequest request, SearchGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SearchGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/search", "json", req, runtime), new SearchGroupResponse());
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

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openGroupSetId)) {
            body.put("openGroupSetId", request.openGroupSetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ownerStaffId)) {
            body.put("ownerStaffId", request.ownerStaffId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberStaffIds)) {
            body.put("memberStaffIds", request.memberStaffIds);
        }

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

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups", "json", req, runtime), new CreateGroupResponse());
    }

    public SendServiceGroupMessageResponse sendServiceGroupMessage(SendServiceGroupMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendServiceGroupMessageHeaders headers = new SendServiceGroupMessageHeaders();
        return this.sendServiceGroupMessageWithOptions(request, headers, runtime);
    }

    public SendServiceGroupMessageResponse sendServiceGroupMessageWithOptions(SendServiceGroupMessageRequest request, SendServiceGroupMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetOpenConversationId)) {
            body.put("targetOpenConversationId", request.targetOpenConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAtAll)) {
            body.put("isAtAll", request.isAtAll);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.atMobiles)) {
            body.put("atMobiles", request.atMobiles);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.atDingtalkIds)) {
            body.put("atDingtalkIds", request.atDingtalkIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.atUnionIds)) {
            body.put("atUnionIds", request.atUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverMobiles)) {
            body.put("receiverMobiles", request.receiverMobiles);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverDingtalkIds)) {
            body.put("receiverDingtalkIds", request.receiverDingtalkIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUnionIds)) {
            body.put("receiverUnionIds", request.receiverUnionIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.btnOrientation)) {
            body.put("btnOrientation", request.btnOrientation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.btns)) {
            body.put("btns", request.btns);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SendServiceGroupMessage", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/send", "json", req, runtime), new SendServiceGroupMessageResponse());
    }

    public AddKnowledgeResponse addKnowledge(AddKnowledgeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddKnowledgeHeaders headers = new AddKnowledgeHeaders();
        return this.addKnowledgeWithOptions(request, headers, runtime);
    }

    public AddKnowledgeResponse addKnowledgeWithOptions(AddKnowledgeRequest request, AddKnowledgeHeaders headers, RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.libraryKey)) {
            body.put("libraryKey", request.libraryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourcePrimaryKey)) {
            body.put("sourcePrimaryKey", request.sourcePrimaryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.linkUrl)) {
            body.put("linkUrl", request.linkUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddKnowledge", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/knowledges", "json", req, runtime), new AddKnowledgeResponse());
    }

    public QueryServiceGroupMessageReadStatusResponse queryServiceGroupMessageReadStatus(QueryServiceGroupMessageReadStatusRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryServiceGroupMessageReadStatusHeaders headers = new QueryServiceGroupMessageReadStatusHeaders();
        return this.queryServiceGroupMessageReadStatusWithOptions(request, headers, runtime);
    }

    public QueryServiceGroupMessageReadStatusResponse queryServiceGroupMessageReadStatusWithOptions(QueryServiceGroupMessageReadStatusRequest request, QueryServiceGroupMessageReadStatusHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamId)) {
            body.put("openTeamId", request.openTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openMsgTaskId)) {
            body.put("openMsgTaskId", request.openMsgTaskId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            body.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            body.put("maxResults", request.maxResults);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryServiceGroupMessageReadStatus", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/messages/readStatus/query", "json", req, runtime), new QueryServiceGroupMessageReadStatusResponse());
    }

    public AddLibraryResponse addLibrary(AddLibraryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddLibraryHeaders headers = new AddLibraryHeaders();
        return this.addLibraryWithOptions(request, headers, runtime);
    }

    public AddLibraryResponse addLibraryWithOptions(AddLibraryRequest request, AddLibraryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openTeamIds)) {
            body.put("openTeamIds", request.openTeamIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourcePrimaryKey)) {
            body.put("sourcePrimaryKey", request.sourcePrimaryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddLibrary", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/librarys", "json", req, runtime), new AddLibraryResponse());
    }

    public ListUserTeamsResponse listUserTeams(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListUserTeamsHeaders headers = new ListUserTeamsHeaders();
        return this.listUserTeamsWithOptions(userId, headers, runtime);
    }

    public ListUserTeamsResponse listUserTeamsWithOptions(String userId, ListUserTeamsHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("ListUserTeams", "serviceGroup_1.0", "HTTP", "GET", "AK", "/v1.0/serviceGroup/users/" + userId + "/teams", "json", req, runtime), new ListUserTeamsResponse());
    }

    public QueryGroupResponse queryGroup(QueryGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupHeaders headers = new QueryGroupHeaders();
        return this.queryGroupWithOptions(request, headers, runtime);
    }

    public QueryGroupResponse queryGroupWithOptions(QueryGroupRequest request, QueryGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("QueryGroup", "serviceGroup_1.0", "HTTP", "POST", "AK", "/v1.0/serviceGroup/groups/query", "json", req, runtime), new QueryGroupResponse());
    }
}
