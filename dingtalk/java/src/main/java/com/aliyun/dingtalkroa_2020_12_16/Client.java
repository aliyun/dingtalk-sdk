// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkroa_2020_12_16;

import com.aliyun.tea.*;
import com.aliyun.dingtalkroa_2020_12_16.models.*;
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


    public ApiTestDuheResponse apiTestDuhe(ApiTestDuheRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ApiTestDuheHeaders headers = new ApiTestDuheHeaders();
        return this.apiTestDuheWithOptions(request, headers, runtime);
    }

    public ApiTestDuheResponse apiTestDuheWithOptions(ApiTestDuheRequest request, ApiTestDuheHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accessToken)) {
            body.put("AccessToken", request.accessToken);
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
        return TeaModel.toModel(this.doROARequestWithForm("ApiTestDuhe", "roa_2020_12_16", "HTTPS", "POST", "AK", "/v2020/roa/teste111", "json", req, runtime), new ApiTestDuheResponse());
    }
}
