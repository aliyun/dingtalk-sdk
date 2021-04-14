// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingmi_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdingmi_1_0.models.*;
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


    public GetDingMeBaseDataResponse getDingMeBaseData(GetDingMeBaseDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDingMeBaseDataHeaders headers = new GetDingMeBaseDataHeaders();
        return this.getDingMeBaseDataWithOptions(request, headers, runtime);
    }

    public GetDingMeBaseDataResponse getDingMeBaseDataWithOptions(GetDingMeBaseDataRequest request, GetDingMeBaseDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            query.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDay)) {
            query.put("startDay", request.startDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endDay)) {
            query.put("endDay", request.endDay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.byDay)) {
            query.put("byDay", request.byDay);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetDingMeBaseData", "dingmi_1.0", "HTTP", "GET", "AK", "/v1.0/dingmi/robots/data", "json", req, runtime), new GetDingMeBaseDataResponse());
    }
}
