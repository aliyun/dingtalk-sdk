// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrcs_call_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkrcs_call_1_0.models.*;
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


    public RunCallUserResponse runCallUser(RunCallUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RunCallUserHeaders headers = new RunCallUserHeaders();
        return this.runCallUserWithOptions(request, headers, runtime);
    }

    public RunCallUserResponse runCallUserWithOptions(RunCallUserRequest request, RunCallUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authorizeCorpId)) {
            query.put("authorizeCorpId", request.authorizeCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authorizeUserId)) {
            query.put("authorizeUserId", request.authorizeUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            query.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("RunCallUser", "rcsCall_1.0", "HTTP", "POST", "AK", "/v1.0/rcsCall/users/call", "json", req, runtime), new RunCallUserResponse());
    }
}
