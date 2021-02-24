// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdingisv_roa_20201225.models.*;
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


    public RoaDuheYsTestResponse roaDuheYsTest(RoaDuheYsTestRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RoaDuheYsTestHeaders headers = new RoaDuheYsTestHeaders();
        return this.roaDuheYsTestWithOptions(request, headers, runtime);
    }

    public RoaDuheYsTestResponse roaDuheYsTestWithOptions(RoaDuheYsTestRequest request, RoaDuheYsTestHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizGenericParameters)) {
            body.put("bizGenericParameters", request.bizGenericParameters);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizSystemParameters)) {
            body.put("bizSystemParameters", request.bizSystemParameters);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invokeInfomation)) {
            body.put("invokeInfomation", request.invokeInfomation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gatewayInfomation)) {
            body.put("gatewayInfomation", request.gatewayInfomation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizContext)) {
            body.put("bizContext", request.bizContext);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
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
        return TeaModel.toModel(this.doROARequest("RoaDuheYsTest", "dingisvRoa_2020-12-25", "HTTP", "POST", "AK", "/v2020-12-25/dingisvRoa/users/test", "json", req, runtime), new RoaDuheYsTestResponse());
    }

    public TestLstDuheResponse testLstDuhe() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TestLstDuheHeaders headers = new TestLstDuheHeaders();
        return this.testLstDuheWithOptions(headers, runtime);
    }

    public TestLstDuheResponse testLstDuheWithOptions(TestLstDuheHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("TestLstDuhe", "dingisvRoa_2020-12-25", "HTTPS", "POST", "AK", "/v2020-12-25/dingisvRoa/users/ekfeke", "json", req, runtime), new TestLstDuheResponse());
    }
}
