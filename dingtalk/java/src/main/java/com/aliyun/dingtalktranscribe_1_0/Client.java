// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktranscribe_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktranscribe_1_0.models.*;
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


    public GetTranscribeBriefResponse getTranscribeBrief(String taskUuid) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTranscribeBriefHeaders headers = new GetTranscribeBriefHeaders();
        return this.getTranscribeBriefWithOptions(taskUuid, headers, runtime);
    }

    public GetTranscribeBriefResponse getTranscribeBriefWithOptions(String taskUuid, GetTranscribeBriefHeaders headers, RuntimeOptions runtime) throws Exception {
        taskUuid = com.aliyun.openapiutil.Client.getEncodeParam(taskUuid);
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
        return TeaModel.toModel(this.doROARequest("GetTranscribeBrief", "transcribe_1.0", "HTTP", "GET", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/briefInfos", "json", req, runtime), new GetTranscribeBriefResponse());
    }

    public RemovePermissionResponse removePermission(String taskUuid, RemovePermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RemovePermissionHeaders headers = new RemovePermissionHeaders();
        return this.removePermissionWithOptions(taskUuid, request, headers, runtime);
    }

    public RemovePermissionResponse removePermissionWithOptions(String taskUuid, RemovePermissionRequest request, RemovePermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskUuid = com.aliyun.openapiutil.Client.getEncodeParam(taskUuid);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RemovePermission", "transcribe_1.0", "HTTP", "DELETE", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions/remove", "json", req, runtime), new RemovePermissionResponse());
    }

    public UpdatePermissionForUsersResponse updatePermissionForUsers(String taskUuid, UpdatePermissionForUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
        return this.updatePermissionForUsersWithOptions(taskUuid, request, headers, runtime);
    }

    public UpdatePermissionForUsersResponse updatePermissionForUsersWithOptions(String taskUuid, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskUuid = com.aliyun.openapiutil.Client.getEncodeParam(taskUuid);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdatePermissionForUsers", "transcribe_1.0", "HTTP", "PUT", "AK", "/v1.0/transcribe/tasks/" + taskUuid + "/permissions", "json", req, runtime), new UpdatePermissionForUsersResponse());
    }
}
