// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_integration_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkproject_integration_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public SendInteractiveCardResponse sendInteractiveCard(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
        return this.sendInteractiveCardWithOptions(userId, headers, runtime);
    }

    public SendInteractiveCardResponse sendInteractiveCardWithOptions(String userId, SendInteractiveCardHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("SendInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/groupChatCardMessages", "json", req, runtime), new SendInteractiveCardResponse());
    }

    public UpdateInteractiveCardResponse updateInteractiveCard(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
        return this.updateInteractiveCardWithOptions(userId, headers, runtime);
    }

    public UpdateInteractiveCardResponse updateInteractiveCardWithOptions(String userId, UpdateInteractiveCardHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("UpdateInteractiveCard", "projectIntegration_1.0", "HTTP", "PUT", "AK", "/v1.0/projectIntegration/users/" + userId + "/cardMessages", "json", req, runtime), new UpdateInteractiveCardResponse());
    }

    public SendSingleInteractiveCardResponse sendSingleInteractiveCard(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
        return this.sendSingleInteractiveCardWithOptions(userId, headers, runtime);
    }

    public SendSingleInteractiveCardResponse sendSingleInteractiveCardWithOptions(String userId, SendSingleInteractiveCardHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("SendSingleInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/singleChatCardMessages", "json", req, runtime), new SendSingleInteractiveCardResponse());
    }

    public SendMessageToEventGroupResponse sendMessageToEventGroup(String userId, String groupId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendMessageToEventGroupHeaders headers = new SendMessageToEventGroupHeaders();
        return this.sendMessageToEventGroupWithOptions(userId, groupId, headers, runtime);
    }

    public SendMessageToEventGroupResponse sendMessageToEventGroupWithOptions(String userId, String groupId, SendMessageToEventGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("SendMessageToEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/messages", "json", req, runtime), new SendMessageToEventGroupResponse());
    }

    public AddAttendeeToEventGroupResponse addAttendeeToEventGroup(String userId, String groupId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
        return this.addAttendeeToEventGroupWithOptions(userId, groupId, headers, runtime);
    }

    public AddAttendeeToEventGroupResponse addAttendeeToEventGroupWithOptions(String userId, String groupId, AddAttendeeToEventGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("AddAttendeeToEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/members", "json", req, runtime), new AddAttendeeToEventGroupResponse());
    }

    public CreateEventGroupResponse createEventGroup(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
        return this.createEventGroupWithOptions(userId, headers, runtime);
    }

    public CreateEventGroupResponse createEventGroupWithOptions(String userId, CreateEventGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("CreateEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups", "json", req, runtime), new CreateEventGroupResponse());
    }
}
