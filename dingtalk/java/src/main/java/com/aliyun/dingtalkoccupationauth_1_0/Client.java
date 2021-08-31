// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkoccupationauth_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkoccupationauth_1_0.models.*;
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


    public CheckUserTaskStatusResponse checkUserTaskStatus(CheckUserTaskStatusRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CheckUserTaskStatusHeaders headers = new CheckUserTaskStatusHeaders();
        return this.checkUserTaskStatusWithOptions(request, headers, runtime);
    }

    public CheckUserTaskStatusResponse checkUserTaskStatusWithOptions(CheckUserTaskStatusRequest request, CheckUserTaskStatusHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.provinceCode)) {
            body.put("provinceCode", request.provinceCode);
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
        return TeaModel.toModel(this.doROARequest("CheckUserTaskStatus", "occupationauth_1.0", "HTTP", "POST", "AK", "/v1.0/occupationauth/auths/userTasks", "json", req, runtime), new CheckUserTaskStatusResponse());
    }
}
