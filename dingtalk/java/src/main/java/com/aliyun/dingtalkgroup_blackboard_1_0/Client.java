// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkgroup_blackboard_1_0.models.*;
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


    public CreateGroupBlackboardResponse createGroupBlackboard(CreateGroupBlackboardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateGroupBlackboardHeaders headers = new CreateGroupBlackboardHeaders();
        return this.createGroupBlackboardWithOptions(request, headers, runtime);
    }

    public CreateGroupBlackboardResponse createGroupBlackboardWithOptions(CreateGroupBlackboardRequest request, CreateGroupBlackboardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendDing)) {
            body.put("sendDing", request.sendDing);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sticky)) {
            body.put("sticky", request.sticky);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uniqueId)) {
            body.put("uniqueId", request.uniqueId);
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
        return TeaModel.toModel(this.doROARequest("CreateGroupBlackboard", "groupBlackboard_1.0", "HTTP", "POST", "AK", "/v1.0/groupBlackboard/blackboards", "json", req, runtime), new CreateGroupBlackboardResponse());
    }

    public DeleteGroupBlackboardResponse deleteGroupBlackboard(DeleteGroupBlackboardRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteGroupBlackboardHeaders headers = new DeleteGroupBlackboardHeaders();
        return this.deleteGroupBlackboardWithOptions(request, headers, runtime);
    }

    public DeleteGroupBlackboardResponse deleteGroupBlackboardWithOptions(DeleteGroupBlackboardRequest request, DeleteGroupBlackboardHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dataId)) {
            body.put("dataId", request.dataId);
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
        return TeaModel.toModel(this.doROARequest("DeleteGroupBlackboard", "groupBlackboard_1.0", "HTTP", "POST", "AK", "/v1.0/groupBlackboard/blackboards/remove", "json", req, runtime), new DeleteGroupBlackboardResponse());
    }
}
