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


    public UpdatePermissionForUsersResponse updatePermissionForUsers(String taskId, UpdatePermissionForUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdatePermissionForUsersHeaders headers = new UpdatePermissionForUsersHeaders();
        return this.updatePermissionForUsersWithOptions(taskId, request, headers, runtime);
    }

    public UpdatePermissionForUsersResponse updatePermissionForUsersWithOptions(String taskId, UpdatePermissionForUsersRequest request, UpdatePermissionForUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        taskId = com.aliyun.openapiutil.Client.getEncodeParam(taskId);
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

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
        return TeaModel.toModel(this.doROARequest("UpdatePermissionForUsers", "transcribe_1.0", "HTTP", "PUT", "AK", "/v1.0/transcribe/tasks/" + taskId + "/permissions", "json", req, runtime), new UpdatePermissionForUsersResponse());
    }
}
