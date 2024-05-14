// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgroup_blackboard_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkgroup_blackboard_1_0.models.*;

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
     * @summary 创建群公告
     *
     * @param request CreateGroupBlackboardRequest
     * @param headers CreateGroupBlackboardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateGroupBlackboardResponse
     */
    public CreateGroupBlackboardResponse createGroupBlackboardWithOptions(CreateGroupBlackboardRequest request, CreateGroupBlackboardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateGroupBlackboard"),
            new TeaPair("version", "groupBlackboard_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/groupBlackboard/blackboards"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateGroupBlackboardResponse());
    }

    /**
     * @summary 创建群公告
     *
     * @param request CreateGroupBlackboardRequest
     * @return CreateGroupBlackboardResponse
     */
    public CreateGroupBlackboardResponse createGroupBlackboard(CreateGroupBlackboardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateGroupBlackboardHeaders headers = new CreateGroupBlackboardHeaders();
        return this.createGroupBlackboardWithOptions(request, headers, runtime);
    }

    /**
     * @summary 删除群公告
     *
     * @param request DeleteGroupBlackboardRequest
     * @param headers DeleteGroupBlackboardHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteGroupBlackboardResponse
     */
    public DeleteGroupBlackboardResponse deleteGroupBlackboardWithOptions(DeleteGroupBlackboardRequest request, DeleteGroupBlackboardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeleteGroupBlackboard"),
            new TeaPair("version", "groupBlackboard_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/groupBlackboard/blackboards/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteGroupBlackboardResponse());
    }

    /**
     * @summary 删除群公告
     *
     * @param request DeleteGroupBlackboardRequest
     * @return DeleteGroupBlackboardResponse
     */
    public DeleteGroupBlackboardResponse deleteGroupBlackboard(DeleteGroupBlackboardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteGroupBlackboardHeaders headers = new DeleteGroupBlackboardHeaders();
        return this.deleteGroupBlackboardWithOptions(request, headers, runtime);
    }
}
