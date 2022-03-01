// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkim_1_0.models.*;
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


    public CardTemplateBuildActionResponse cardTemplateBuildAction(CardTemplateBuildActionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CardTemplateBuildActionHeaders headers = new CardTemplateBuildActionHeaders();
        return this.cardTemplateBuildActionWithOptions(request, headers, runtime);
    }

    public CardTemplateBuildActionResponse cardTemplateBuildActionWithOptions(CardTemplateBuildActionRequest request, CardTemplateBuildActionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateJson)) {
            body.put("cardTemplateJson", request.cardTemplateJson);
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
        return TeaModel.toModel(this.doROARequest("CardTemplateBuildAction", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/interactiveCards/templates/buildAction", "json", req, runtime), new CardTemplateBuildActionResponse());
    }

    public ChatIdToOpenConversationIdResponse chatIdToOpenConversationId(String chatId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ChatIdToOpenConversationIdHeaders headers = new ChatIdToOpenConversationIdHeaders();
        return this.chatIdToOpenConversationIdWithOptions(chatId, headers, runtime);
    }

    public ChatIdToOpenConversationIdResponse chatIdToOpenConversationIdWithOptions(String chatId, ChatIdToOpenConversationIdHeaders headers, RuntimeOptions runtime) throws Exception {
        chatId = com.aliyun.openapiutil.Client.getEncodeParam(chatId);
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
        return TeaModel.toModel(this.doROARequest("ChatIdToOpenConversationId", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/chat/" + chatId + "/convertToOpenConversationId", "json", req, runtime), new ChatIdToOpenConversationIdResponse());
    }

    public GetInterconnectionUrlResponse getInterconnectionUrl(GetInterconnectionUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetInterconnectionUrlHeaders headers = new GetInterconnectionUrlHeaders();
        return this.getInterconnectionUrlWithOptions(request, headers, runtime);
    }

    public GetInterconnectionUrlResponse getInterconnectionUrlWithOptions(GetInterconnectionUrlRequest request, GetInterconnectionUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appUserAvatar)) {
            body.put("appUserAvatar", request.appUserAvatar);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appUserAvatarType)) {
            body.put("appUserAvatarType", request.appUserAvatarType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appUserId)) {
            body.put("appUserId", request.appUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appUserMobileNumber)) {
            body.put("appUserMobileNumber", request.appUserMobileNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appUserName)) {
            body.put("appUserName", request.appUserName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgPageType)) {
            body.put("msgPageType", request.msgPageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qrCode)) {
            body.put("qrCode", request.qrCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceCode)) {
            body.put("sourceCode", request.sourceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceType)) {
            body.put("sourceType", request.sourceType);
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
        return TeaModel.toModel(this.doROARequest("GetInterconnectionUrl", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/interconnections/sessions/urls", "json", req, runtime), new GetInterconnectionUrlResponse());
    }

    public GetSceneGroupInfoResponse getSceneGroupInfo(GetSceneGroupInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSceneGroupInfoHeaders headers = new GetSceneGroupInfoHeaders();
        return this.getSceneGroupInfoWithOptions(request, headers, runtime);
    }

    public GetSceneGroupInfoResponse getSceneGroupInfoWithOptions(GetSceneGroupInfoRequest request, GetSceneGroupInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
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
        return TeaModel.toModel(this.doROARequest("GetSceneGroupInfo", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/sceneGroups/query", "json", req, runtime), new GetSceneGroupInfoResponse());
    }

    public GetSceneGroupMembersResponse getSceneGroupMembers(GetSceneGroupMembersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSceneGroupMembersHeaders headers = new GetSceneGroupMembersHeaders();
        return this.getSceneGroupMembersWithOptions(request, headers, runtime);
    }

    public GetSceneGroupMembersResponse getSceneGroupMembersWithOptions(GetSceneGroupMembersRequest request, GetSceneGroupMembersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            body.put("size", request.size);
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
        return TeaModel.toModel(this.doROARequest("GetSceneGroupMembers", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/sceneGroups/members/query", "json", req, runtime), new GetSceneGroupMembersResponse());
    }

    public InteractiveCardCreateInstanceResponse interactiveCardCreateInstance(InteractiveCardCreateInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        InteractiveCardCreateInstanceHeaders headers = new InteractiveCardCreateInstanceHeaders();
        return this.interactiveCardCreateInstanceWithOptions(request, headers, runtime);
    }

    public InteractiveCardCreateInstanceResponse interactiveCardCreateInstanceWithOptions(InteractiveCardCreateInstanceRequest request, InteractiveCardCreateInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardData))) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chatBotId)) {
            body.put("chatBotId", request.chatBotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conversationType)) {
            body.put("conversationType", request.conversationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIdList)) {
            body.put("receiverUserIdList", request.receiverUserIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
        return TeaModel.toModel(this.doROARequest("InteractiveCardCreateInstance", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/interactiveCards/instances", "json", req, runtime), new InteractiveCardCreateInstanceResponse());
    }

    public QueryMembersOfGroupRoleResponse queryMembersOfGroupRole(QueryMembersOfGroupRoleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryMembersOfGroupRoleHeaders headers = new QueryMembersOfGroupRoleHeaders();
        return this.queryMembersOfGroupRoleWithOptions(request, headers, runtime);
    }

    public QueryMembersOfGroupRoleResponse queryMembersOfGroupRoleWithOptions(QueryMembersOfGroupRoleRequest request, QueryMembersOfGroupRoleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openRoleId)) {
            body.put("openRoleId", request.openRoleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timestamp)) {
            body.put("timestamp", request.timestamp);
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
        return TeaModel.toModel(this.doROARequest("QueryMembersOfGroupRole", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/sceneGroups/roles/members/query", "json", req, runtime), new QueryMembersOfGroupRoleResponse());
    }

    public SendInteractiveCardResponse sendInteractiveCard(SendInteractiveCardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
        return this.sendInteractiveCardWithOptions(request, headers, runtime);
    }

    public SendInteractiveCardResponse sendInteractiveCardWithOptions(SendInteractiveCardRequest request, SendInteractiveCardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.atOpenIds)) {
            body.put("atOpenIds", request.atOpenIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardData))) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardOptions))) {
            body.put("cardOptions", request.cardOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chatBotId)) {
            body.put("chatBotId", request.chatBotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conversationType)) {
            body.put("conversationType", request.conversationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIdList)) {
            body.put("receiverUserIdList", request.receiverUserIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
        return TeaModel.toModel(this.doROARequest("SendInteractiveCard", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/interactiveCards/send", "json", req, runtime), new SendInteractiveCardResponse());
    }

    public SendRobotInteractiveCardResponse sendRobotInteractiveCard(SendRobotInteractiveCardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendRobotInteractiveCardHeaders headers = new SendRobotInteractiveCardHeaders();
        return this.sendRobotInteractiveCardWithOptions(request, headers, runtime);
    }

    public SendRobotInteractiveCardResponse sendRobotInteractiveCardWithOptions(SendRobotInteractiveCardRequest request, SendRobotInteractiveCardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardBizId)) {
            body.put("cardBizId", request.cardBizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sendOptions))) {
            body.put("sendOptions", request.sendOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.singleChatReceiver)) {
            body.put("singleChatReceiver", request.singleChatReceiver);
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
        return TeaModel.toModel(this.doROARequest("SendRobotInteractiveCard", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/v1.0/robot/interactiveCards/send", "json", req, runtime), new SendRobotInteractiveCardResponse());
    }

    public SendTemplateInteractiveCardResponse sendTemplateInteractiveCard(SendTemplateInteractiveCardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendTemplateInteractiveCardHeaders headers = new SendTemplateInteractiveCardHeaders();
        return this.sendTemplateInteractiveCardWithOptions(request, headers, runtime);
    }

    public SendTemplateInteractiveCardResponse sendTemplateInteractiveCardWithOptions(SendTemplateInteractiveCardRequest request, SendTemplateInteractiveCardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackUrl)) {
            body.put("callbackUrl", request.callbackUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardData)) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.sendOptions))) {
            body.put("sendOptions", request.sendOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.singleChatReceiver)) {
            body.put("singleChatReceiver", request.singleChatReceiver);
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
        return TeaModel.toModel(this.doROARequest("SendTemplateInteractiveCard", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/interactiveCards/templates/send", "json", req, runtime), new SendTemplateInteractiveCardResponse());
    }

    public TopboxCloseResponse topboxClose(TopboxCloseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TopboxCloseHeaders headers = new TopboxCloseHeaders();
        return this.topboxCloseWithOptions(request, headers, runtime);
    }

    public TopboxCloseResponse topboxCloseWithOptions(TopboxCloseRequest request, TopboxCloseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
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
        return TeaModel.toModel(this.doROARequest("TopboxClose", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/topBoxes/close", "none", req, runtime), new TopboxCloseResponse());
    }

    public TopboxOpenResponse topboxOpen(TopboxOpenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TopboxOpenHeaders headers = new TopboxOpenHeaders();
        return this.topboxOpenWithOptions(request, headers, runtime);
    }

    public TopboxOpenResponse topboxOpenWithOptions(TopboxOpenRequest request, TopboxOpenHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.expiredTime)) {
            body.put("expiredTime", request.expiredTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platforms)) {
            body.put("platforms", request.platforms);
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
        return TeaModel.toModel(this.doROARequest("TopboxOpen", "im_1.0", "HTTP", "POST", "AK", "/v1.0/im/topBoxes/open", "none", req, runtime), new TopboxOpenResponse());
    }

    public UpdateGroupPermissionResponse updateGroupPermission(UpdateGroupPermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateGroupPermissionHeaders headers = new UpdateGroupPermissionHeaders();
        return this.updateGroupPermissionWithOptions(request, headers, runtime);
    }

    public UpdateGroupPermissionResponse updateGroupPermissionWithOptions(UpdateGroupPermissionRequest request, UpdateGroupPermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permissionGroup)) {
            body.put("permissionGroup", request.permissionGroup);
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
        return TeaModel.toModel(this.doROARequest("UpdateGroupPermission", "im_1.0", "HTTP", "PUT", "AK", "/v1.0/im/sceneGroups/permissions", "json", req, runtime), new UpdateGroupPermissionResponse());
    }

    public UpdateGroupSubAdminResponse updateGroupSubAdmin(UpdateGroupSubAdminRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateGroupSubAdminHeaders headers = new UpdateGroupSubAdminHeaders();
        return this.updateGroupSubAdminWithOptions(request, headers, runtime);
    }

    public UpdateGroupSubAdminResponse updateGroupSubAdminWithOptions(UpdateGroupSubAdminRequest request, UpdateGroupSubAdminHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateGroupSubAdmin", "im_1.0", "HTTP", "PUT", "AK", "/v1.0/im/sceneGroups/subAdmins", "json", req, runtime), new UpdateGroupSubAdminResponse());
    }

    public UpdateInteractiveCardResponse updateInteractiveCard(UpdateInteractiveCardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
        return this.updateInteractiveCardWithOptions(request, headers, runtime);
    }

    public UpdateInteractiveCardResponse updateInteractiveCardWithOptions(UpdateInteractiveCardRequest request, UpdateInteractiveCardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardData))) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardOptions))) {
            body.put("cardOptions", request.cardOptions);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.privateData)) {
            body.put("privateData", request.privateData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdType)) {
            body.put("userIdType", request.userIdType);
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
        return TeaModel.toModel(this.doROARequest("UpdateInteractiveCard", "im_1.0", "HTTP", "PUT", "AK", "/v1.0/im/interactiveCards", "json", req, runtime), new UpdateInteractiveCardResponse());
    }

    public UpdateMemberGroupNickResponse updateMemberGroupNick(UpdateMemberGroupNickRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateMemberGroupNickHeaders headers = new UpdateMemberGroupNickHeaders();
        return this.updateMemberGroupNickWithOptions(request, headers, runtime);
    }

    public UpdateMemberGroupNickResponse updateMemberGroupNickWithOptions(UpdateMemberGroupNickRequest request, UpdateMemberGroupNickHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupNick)) {
            body.put("groupNick", request.groupNick);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
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
        return TeaModel.toModel(this.doROARequest("UpdateMemberGroupNick", "im_1.0", "HTTP", "PUT", "AK", "/v1.0/im/sceneGroups/members/groupNicks", "json", req, runtime), new UpdateMemberGroupNickResponse());
    }

    public UpdateTheGroupRolesOfGroupMemberResponse updateTheGroupRolesOfGroupMember(UpdateTheGroupRolesOfGroupMemberRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateTheGroupRolesOfGroupMemberHeaders headers = new UpdateTheGroupRolesOfGroupMemberHeaders();
        return this.updateTheGroupRolesOfGroupMemberWithOptions(request, headers, runtime);
    }

    public UpdateTheGroupRolesOfGroupMemberResponse updateTheGroupRolesOfGroupMemberWithOptions(UpdateTheGroupRolesOfGroupMemberRequest request, UpdateTheGroupRolesOfGroupMemberHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openRoleIds)) {
            body.put("openRoleIds", request.openRoleIds);
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
        return TeaModel.toModel(this.doROARequest("UpdateTheGroupRolesOfGroupMember", "im_1.0", "HTTP", "PUT", "AK", "/v1.0/im/sceneGroups/members/groupRoles", "json", req, runtime), new UpdateTheGroupRolesOfGroupMemberResponse());
    }
}
