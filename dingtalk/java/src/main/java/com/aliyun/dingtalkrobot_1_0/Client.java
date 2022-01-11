// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkrobot_1_0.models.*;
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


    public BatchOTOQueryResponse batchOTOQuery(BatchOTOQueryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchOTOQueryHeaders headers = new BatchOTOQueryHeaders();
        return this.batchOTOQueryWithOptions(request, headers, runtime);
    }

    public BatchOTOQueryResponse batchOTOQueryWithOptions(BatchOTOQueryRequest request, BatchOTOQueryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKey)) {
            query.put("processQueryKey", request.processQueryKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            query.put("robotCode", request.robotCode);
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
        return TeaModel.toModel(this.doROARequest("BatchOTOQuery", "robot_1.0", "HTTP", "GET", "AK", "/v1.0/robot/oToMessages/readStatus", "json", req, runtime), new BatchOTOQueryResponse());
    }

    public BatchRecallGroupResponse batchRecallGroup(BatchRecallGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchRecallGroupHeaders headers = new BatchRecallGroupHeaders();
        return this.batchRecallGroupWithOptions(request, headers, runtime);
    }

    public BatchRecallGroupResponse batchRecallGroupWithOptions(BatchRecallGroupRequest request, BatchRecallGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.chatbotId)) {
            body.put("chatbotId", request.chatbotId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKeys)) {
            body.put("processQueryKeys", request.processQueryKeys);
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
        return TeaModel.toModel(this.doROARequest("BatchRecallGroup", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/groupMessages/batchRecall", "json", req, runtime), new BatchRecallGroupResponse());
    }

    public BatchRecallOTOResponse batchRecallOTO(BatchRecallOTORequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchRecallOTOHeaders headers = new BatchRecallOTOHeaders();
        return this.batchRecallOTOWithOptions(request, headers, runtime);
    }

    public BatchRecallOTOResponse batchRecallOTOWithOptions(BatchRecallOTORequest request, BatchRecallOTOHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processQueryKeys)) {
            body.put("processQueryKeys", request.processQueryKeys);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
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
        return TeaModel.toModel(this.doROARequest("BatchRecallOTO", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/otoMessages/batchRecall", "json", req, runtime), new BatchRecallOTOResponse());
    }

    public BatchSendOTOResponse batchSendOTO(BatchSendOTORequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchSendOTOHeaders headers = new BatchSendOTOHeaders();
        return this.batchSendOTOWithOptions(request, headers, runtime);
    }

    public BatchSendOTOResponse batchSendOTOWithOptions(BatchSendOTORequest request, BatchSendOTOHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
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
        return TeaModel.toModel(this.doROARequest("BatchSendOTO", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/oToMessages/batchSend", "json", req, runtime), new BatchSendOTOResponse());
    }

    public OrgGroupSendResponse orgGroupSend(OrgGroupSendRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        OrgGroupSendHeaders headers = new OrgGroupSendHeaders();
        return this.orgGroupSendWithOptions(request, headers, runtime);
    }

    public OrgGroupSendResponse orgGroupSendWithOptions(OrgGroupSendRequest request, OrgGroupSendHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgKey)) {
            body.put("msgKey", request.msgKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgParam)) {
            body.put("msgParam", request.msgParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
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
        return TeaModel.toModel(this.doROARequest("OrgGroupSend", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/groupMessages/send", "json", req, runtime), new OrgGroupSendResponse());
    }

    public SendRobotDingMessageResponse sendRobotDingMessage(SendRobotDingMessageRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SendRobotDingMessageHeaders headers = new SendRobotDingMessageHeaders();
        return this.sendRobotDingMessageWithOptions(request, headers, runtime);
    }

    public SendRobotDingMessageResponse sendRobotDingMessageWithOptions(SendRobotDingMessageRequest request, SendRobotDingMessageHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.contentParams)) {
            body.put("contentParams", request.contentParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTemplateId)) {
            body.put("dingTemplateId", request.dingTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIdList)) {
            body.put("receiverUserIdList", request.receiverUserIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
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
        return TeaModel.toModel(this.doROARequest("SendRobotDingMessage", "robot_1.0", "HTTP", "POST", "AK", "/v1.0/robot/dingMessages/send", "json", req, runtime), new SendRobotDingMessageResponse());
    }
}
