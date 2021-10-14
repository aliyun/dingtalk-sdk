// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdingmi_1_0.models.*;
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


    public PushCustomerGroupMessageResponse pushCustomerGroupMessage(PushCustomerGroupMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PushCustomerGroupMessageHeaders headers = new PushCustomerGroupMessageHeaders();
        return this.pushCustomerGroupMessageWithOptions(request, headers, runtime);
    }

    public PushCustomerGroupMessageResponse pushCustomerGroupMessageWithOptions(PushCustomerGroupMessageRequest request, PushCustomerGroupMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
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
        return TeaModel.toModel(this.doROARequest("PushCustomerGroupMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/officialAccounts/robots/groupMessages/send", "json", req, runtime), new PushCustomerGroupMessageResponse());
    }

    public GetDingMeBaseDataResponse getDingMeBaseData(GetDingMeBaseDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDingMeBaseDataHeaders headers = new GetDingMeBaseDataHeaders();
        return this.getDingMeBaseDataWithOptions(request, headers, runtime);
    }

    public GetDingMeBaseDataResponse getDingMeBaseDataWithOptions(GetDingMeBaseDataRequest request, GetDingMeBaseDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            query.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDay)) {
            query.put("startDay", request.startDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endDay)) {
            query.put("endDay", request.endDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.byDay)) {
            query.put("byDay", request.byDay);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetDingMeBaseData", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/robots/data", "json", req, runtime), new GetDingMeBaseDataResponse());
    }

    public PushRobotMessageResponse pushRobotMessage(PushRobotMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PushRobotMessageHeaders headers = new PushRobotMessageHeaders();
        return this.pushRobotMessageWithOptions(request, headers, runtime);
    }

    public PushRobotMessageResponse pushRobotMessageWithOptions(PushRobotMessageRequest request, PushRobotMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chatbotId)) {
            body.put("chatbotId", request.chatbotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
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
        return TeaModel.toModel(this.doROARequest("PushRobotMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/oToMessages/send", "json", req, runtime), new PushRobotMessageResponse());
    }

    public PushOfficialAccountMessageResponse pushOfficialAccountMessage(PushOfficialAccountMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PushOfficialAccountMessageHeaders headers = new PushOfficialAccountMessageHeaders();
        return this.pushOfficialAccountMessageWithOptions(request, headers, runtime);
    }

    public PushOfficialAccountMessageResponse pushOfficialAccountMessageWithOptions(PushOfficialAccountMessageRequest request, PushOfficialAccountMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
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
        return TeaModel.toModel(this.doROARequest("PushOfficialAccountMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/officialAccounts/robots/oToMessages/send", "json", req, runtime), new PushOfficialAccountMessageResponse());
    }

    public GetWebChannelUserTokenResponse getWebChannelUserToken(GetWebChannelUserTokenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetWebChannelUserTokenHeaders headers = new GetWebChannelUserTokenHeaders();
        return this.getWebChannelUserTokenWithOptions(request, headers, runtime);
    }

    public GetWebChannelUserTokenResponse getWebChannelUserTokenWithOptions(GetWebChannelUserTokenRequest request, GetWebChannelUserTokenHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nick)) {
            body.put("nick", request.nick);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.foreignId)) {
            body.put("foreignId", request.foreignId);
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
        return TeaModel.toModel(this.doROARequest("GetWebChannelUserToken", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/webChannels/userTokens", "json", req, runtime), new GetWebChannelUserTokenResponse());
    }

    public GetIntelligentRobotInfoResponse getIntelligentRobotInfo(GetIntelligentRobotInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetIntelligentRobotInfoHeaders headers = new GetIntelligentRobotInfoHeaders();
        return this.getIntelligentRobotInfoWithOptions(request, headers, runtime);
    }

    public GetIntelligentRobotInfoResponse getIntelligentRobotInfoWithOptions(GetIntelligentRobotInfoRequest request, GetIntelligentRobotInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.robotAppKey)) {
            query.put("robotAppKey", request.robotAppKey);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetIntelligentRobotInfo", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/intelligentRobots/infos", "json", req, runtime), new GetIntelligentRobotInfoResponse());
    }

    public GetOfficialAccountRobotInfoResponse getOfficialAccountRobotInfo(GetOfficialAccountRobotInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOfficialAccountRobotInfoHeaders headers = new GetOfficialAccountRobotInfoHeaders();
        return this.getOfficialAccountRobotInfoWithOptions(request, headers, runtime);
    }

    public GetOfficialAccountRobotInfoResponse getOfficialAccountRobotInfoWithOptions(GetOfficialAccountRobotInfoRequest request, GetOfficialAccountRobotInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetOfficialAccountRobotInfo", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/officialAccounts/robots", "json", req, runtime), new GetOfficialAccountRobotInfoResponse());
    }

    public UpdateOfficialAccountRobotInfoResponse updateOfficialAccountRobotInfo(UpdateOfficialAccountRobotInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateOfficialAccountRobotInfoHeaders headers = new UpdateOfficialAccountRobotInfoHeaders();
        return this.updateOfficialAccountRobotInfoWithOptions(request, headers, runtime);
    }

    public UpdateOfficialAccountRobotInfoResponse updateOfficialAccountRobotInfoWithOptions(UpdateOfficialAccountRobotInfoRequest request, UpdateOfficialAccountRobotInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.avatar)) {
            body.put("avatar", request.avatar);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.brief)) {
            body.put("brief", request.brief);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.previewMediaUrl)) {
            body.put("previewMediaUrl", request.previewMediaUrl);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateOfficialAccountRobotInfo", "dingmi_1.0", "HTTP", "PUT", "AK", "/v1.0/dingmi/officialAccounts/robots", "json", req, runtime), new UpdateOfficialAccountRobotInfoResponse());
    }

    public PushIntelligentRobotMessageResponse pushIntelligentRobotMessage(PushIntelligentRobotMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PushIntelligentRobotMessageHeaders headers = new PushIntelligentRobotMessageHeaders();
        return this.pushIntelligentRobotMessageWithOptions(request, headers, runtime);
    }

    public PushIntelligentRobotMessageResponse pushIntelligentRobotMessageWithOptions(PushIntelligentRobotMessageRequest request, PushIntelligentRobotMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chatbotId)) {
            body.put("chatbotId", request.chatbotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
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
        return TeaModel.toModel(this.doROARequest("PushIntelligentRobotMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/oToMessages/send", "json", req, runtime), new PushIntelligentRobotMessageResponse());
    }

    public AddRobotInstanceToGroupResponse addRobotInstanceToGroup(AddRobotInstanceToGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.addRobotInstanceToGroupWithOptions(request, headers, runtime);
    }

    public AddRobotInstanceToGroupResponse addRobotInstanceToGroupWithOptions(AddRobotInstanceToGroupRequest request, java.util.Map<String, String> headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chatbotId)) {
            body.put("chatbotId", request.chatbotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddRobotInstanceToGroup", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/groups", "json", req, runtime), new AddRobotInstanceToGroupResponse());
    }

    public AskRobotResponse askRobot(AskRobotRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AskRobotHeaders headers = new AskRobotHeaders();
        return this.askRobotWithOptions(request, headers, runtime);
    }

    public AskRobotResponse askRobotWithOptions(AskRobotRequest request, AskRobotHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.question)) {
            body.put("question", request.question);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotAppKey)) {
            body.put("robotAppKey", request.robotAppKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sessionUuid)) {
            body.put("sessionUuid", request.sessionUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            body.put("dingUserId", request.dingUserId);
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
        return TeaModel.toModel(this.doROARequest("AskRobot", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/ask", "json", req, runtime), new AskRobotResponse());
    }

    public ReplyRobotResponse replyRobot(ReplyRobotRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ReplyRobotHeaders headers = new ReplyRobotHeaders();
        return this.replyRobotWithOptions(request, headers, runtime);
    }

    public ReplyRobotResponse replyRobotWithOptions(ReplyRobotRequest request, ReplyRobotHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.proxyMessageStr)) {
            body.put("proxyMessageStr", request.proxyMessageStr);
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
        return TeaModel.toModel(this.doROARequest("ReplyRobot", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/robots/reply", "json", req, runtime), new ReplyRobotResponse());
    }

    public PushIntelligentRobotGroupMessageResponse pushIntelligentRobotGroupMessage(PushIntelligentRobotGroupMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        PushIntelligentRobotGroupMessageHeaders headers = new PushIntelligentRobotGroupMessageHeaders();
        return this.pushIntelligentRobotGroupMessageWithOptions(request, headers, runtime);
    }

    public PushIntelligentRobotGroupMessageResponse pushIntelligentRobotGroupMessageWithOptions(PushIntelligentRobotGroupMessageRequest request, PushIntelligentRobotGroupMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chatbotId)) {
            body.put("chatbotId", request.chatbotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
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
        return TeaModel.toModel(this.doROARequest("PushIntelligentRobotGroupMessage", "dingmi_1.0", "HTTP", "POST", "AK", "/v1.0/dingmi/intelligentRobots/groupMessages/send", "json", req, runtime), new PushIntelligentRobotGroupMessageResponse());
    }
}
