// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkhrbrain_1_0.models.*;
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


    public SyncDataResponse syncData(SyncDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SyncDataHeaders headers = new SyncDataHeaders();
        return this.syncDataWithOptions(request, headers, runtime);
    }

    public SyncDataResponse syncDataWithOptions(SyncDataRequest request, SyncDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaId)) {
            body.put("schemaId", request.schemaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dataId)) {
            body.put("dataId", request.dataId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.etlTime)) {
            body.put("etlTime", request.etlTime);
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
        return TeaModel.toModel(this.doROARequest("SyncData", "hrbrain_1.0", "HTTP", "POST", "AK", "/v1.0/hrbrain/datas", "json", req, runtime), new SyncDataResponse());
    }
}
