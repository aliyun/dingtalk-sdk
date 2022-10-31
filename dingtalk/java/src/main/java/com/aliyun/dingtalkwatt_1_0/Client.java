// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwatt_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkwatt_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CheckInCrowdsByMobileResponse checkInCrowdsByMobile(CheckInCrowdsByMobileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.checkInCrowdsByMobileWithOptions(request, headers, runtime);
    }

    public CheckInCrowdsByMobileResponse checkInCrowdsByMobileWithOptions(CheckInCrowdsByMobileRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.crowdIds)) {
            query.put("crowdIds", request.crowdIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CheckInCrowdsByMobile", "watt_1.0", "HTTP", "POST", "AK", "/v1.0/watt/crowdIdentifications/query", "json", req, runtime), new CheckInCrowdsByMobileResponse());
    }
}
