// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktranscribe_1_0.models.*;

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
     * @summary 获取闪记任务的概要信息
     *
     * @param headers GetTranscribeBriefHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTranscribeBriefResponse
     */
    public GetTranscribeBriefResponse getTranscribeBriefWithOptions(String taskUuid, GetTranscribeBriefHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetTranscribeBrief"),
            new TeaPair("version", "transcribe_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/transcribe/tasks/" + taskUuid + "/briefInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTranscribeBriefResponse());
    }

    /**
     * @summary 获取闪记任务的概要信息
     *
     * @return GetTranscribeBriefResponse
     */
    public GetTranscribeBriefResponse getTranscribeBrief(String taskUuid) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTranscribeBriefHeaders headers = new GetTranscribeBriefHeaders();
        return this.getTranscribeBriefWithOptions(taskUuid, headers, runtime);
    }

    /**
     * @summary 移除指定用户对闪记任务的权限
     *
     * @param request RemovePermissionRequest
     * @param headers RemovePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RemovePermissionResponse
     */
    public RemovePermissionResponse removePermissionWithOptions(String taskUuid, RemovePermissionRequest request, RemovePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskCreator)) {
            body.put("taskCreator", request.taskCreator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            body.put("taskId", request.taskId);
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
            new TeaPair("action", "RemovePermission"),
            new TeaPair("version", "transcribe_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions/remove"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RemovePermissionResponse());
    }

    /**
     * @summary 移除指定用户对闪记任务的权限
     *
     * @param request RemovePermissionRequest
     * @return RemovePermissionResponse
     */
    public RemovePermissionResponse removePermission(String taskUuid, RemovePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RemovePermissionHeaders headers = new RemovePermissionHeaders();
        return this.removePermissionWithOptions(taskUuid, request, headers, runtime);
    }

    /**
     * @summary 针对指定的闪记，修改或者授予指定用户权限
     *
     * @param request UpdatePermissionForUsersRequest
     * @param headers UpdatePermissionForUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePermissionForUsersResponse
     */
    public UpdatePermissionForUsersResponse updatePermissionForUsersWithOptions(String taskUuid, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorUid)) {
            query.put("operatorUid", request.operatorUid);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskCreator)) {
            body.put("taskCreator", request.taskCreator);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdatePermissionForUsers"),
            new TeaPair("version", "transcribe_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdatePermissionForUsersResponse());
    }

    /**
     * @summary 针对指定的闪记，修改或者授予指定用户权限
     *
     * @param request UpdatePermissionForUsersRequest
     * @return UpdatePermissionForUsersResponse
     */
    public UpdatePermissionForUsersResponse updatePermissionForUsers(String taskUuid, UpdatePermissionForUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
        return this.updatePermissionForUsersWithOptions(taskUuid, request, headers, runtime);
    }
}
