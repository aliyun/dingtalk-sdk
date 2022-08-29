// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_integration_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkproject_integration_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public AddAttendeeToEventGroupResponse addAttendeeToEventGroup(String userId, String groupId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddAttendeeToEventGroupHeaders headers = new AddAttendeeToEventGroupHeaders();
        return this.addAttendeeToEventGroupWithOptions(userId, groupId, headers, runtime);
    }

    public AddAttendeeToEventGroupResponse addAttendeeToEventGroupWithOptions(String userId, String groupId, AddAttendeeToEventGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        groupId = com.aliyun.openapiutil.Client.getEncodeParam(groupId);
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
        return TeaModel.toModel(this.doROARequest("AddAttendeeToEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups/" + groupId + "/members", "json", req, runtime), new AddAttendeeToEventGroupResponse());
    }

    public CreateEventGroupResponse createEventGroup(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateEventGroupHeaders headers = new CreateEventGroupHeaders();
        return this.createEventGroupWithOptions(userId, headers, runtime);
    }

    public CreateEventGroupResponse createEventGroupWithOptions(String userId, CreateEventGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("CreateEventGroup", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/eventGroups", "json", req, runtime), new CreateEventGroupResponse());
    }

    public SendInteractiveCardResponse sendInteractiveCard(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendInteractiveCardHeaders headers = new SendInteractiveCardHeaders();
        return this.sendInteractiveCardWithOptions(userId, headers, runtime);
    }

    public SendInteractiveCardResponse sendInteractiveCardWithOptions(String userId, SendInteractiveCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("SendInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/groupChatCardMessages", "json", req, runtime), new SendInteractiveCardResponse());
    }

    public SendSingleInteractiveCardResponse sendSingleInteractiveCard(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendSingleInteractiveCardHeaders headers = new SendSingleInteractiveCardHeaders();
        return this.sendSingleInteractiveCardWithOptions(userId, headers, runtime);
    }

    public SendSingleInteractiveCardResponse sendSingleInteractiveCardWithOptions(String userId, SendSingleInteractiveCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("SendSingleInteractiveCard", "projectIntegration_1.0", "HTTP", "POST", "AK", "/v1.0/projectIntegration/users/" + userId + "/singleChatCardMessages", "json", req, runtime), new SendSingleInteractiveCardResponse());
    }

    public UpdateInteractiveCardResponse updateInteractiveCard(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInteractiveCardHeaders headers = new UpdateInteractiveCardHeaders();
        return this.updateInteractiveCardWithOptions(userId, headers, runtime);
    }

    public UpdateInteractiveCardResponse updateInteractiveCardWithOptions(String userId, UpdateInteractiveCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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
        return TeaModel.toModel(this.doROARequest("UpdateInteractiveCard", "projectIntegration_1.0", "HTTP", "PUT", "AK", "/v1.0/projectIntegration/users/" + userId + "/cardMessages", "json", req, runtime), new UpdateInteractiveCardResponse());
    }
}
