// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcarbon_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcarbon_1_0.models.*;
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


    public WriteAlibabaOrgCarbonResponse writeAlibabaOrgCarbon(WriteAlibabaOrgCarbonRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        WriteAlibabaOrgCarbonHeaders headers = new WriteAlibabaOrgCarbonHeaders();
        return this.writeAlibabaOrgCarbonWithOptions(request, headers, runtime);
    }

    public WriteAlibabaOrgCarbonResponse writeAlibabaOrgCarbonWithOptions(WriteAlibabaOrgCarbonRequest request, WriteAlibabaOrgCarbonHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orgDetailsList)) {
            body.put("orgDetailsList", request.orgDetailsList);
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
        return TeaModel.toModel(this.doROARequest("WriteAlibabaOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/alibabaOrgDetails/write", "json", req, runtime), new WriteAlibabaOrgCarbonResponse());
    }

    public WriteOrgCarbonResponse writeOrgCarbon(WriteOrgCarbonRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        WriteOrgCarbonHeaders headers = new WriteOrgCarbonHeaders();
        return this.writeOrgCarbonWithOptions(request, headers, runtime);
    }

    public WriteOrgCarbonResponse writeOrgCarbonWithOptions(WriteOrgCarbonRequest request, WriteOrgCarbonHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orgDetailsList)) {
            body.put("orgDetailsList", request.orgDetailsList);
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
        return TeaModel.toModel(this.doROARequest("WriteOrgCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/orgDetails/write", "json", req, runtime), new WriteOrgCarbonResponse());
    }

    public WriteUserCarbonResponse writeUserCarbon(WriteUserCarbonRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        WriteUserCarbonHeaders headers = new WriteUserCarbonHeaders();
        return this.writeUserCarbonWithOptions(request, headers, runtime);
    }

    public WriteUserCarbonResponse writeUserCarbonWithOptions(WriteUserCarbonRequest request, WriteUserCarbonHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userDetailsList)) {
            body.put("userDetailsList", request.userDetailsList);
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
        return TeaModel.toModel(this.doROARequest("WriteUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/userDetails/write", "json", req, runtime), new WriteUserCarbonResponse());
    }

    public WriteAlibabaUserCarbonResponse writeAlibabaUserCarbon(WriteAlibabaUserCarbonRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        WriteAlibabaUserCarbonHeaders headers = new WriteAlibabaUserCarbonHeaders();
        return this.writeAlibabaUserCarbonWithOptions(request, headers, runtime);
    }

    public WriteAlibabaUserCarbonResponse writeAlibabaUserCarbonWithOptions(WriteAlibabaUserCarbonRequest request, WriteAlibabaUserCarbonHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userDetailsList)) {
            body.put("userDetailsList", request.userDetailsList);
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
        return TeaModel.toModel(this.doROARequest("WriteAlibabaUserCarbon", "carbon_1.0", "HTTP", "POST", "AK", "/v1.0/carbon/alibabaUserDetails/write", "json", req, runtime), new WriteAlibabaUserCarbonResponse());
    }
}
