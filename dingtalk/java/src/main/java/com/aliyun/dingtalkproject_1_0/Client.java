// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkproject_1_0.models.*;
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


    public GetTbProjectSourceResponse getTbProjectSource() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTbProjectSourceHeaders headers = new GetTbProjectSourceHeaders();
        return this.getTbProjectSourceWithOptions(headers, runtime);
    }

    public GetTbProjectSourceResponse getTbProjectSourceWithOptions(GetTbProjectSourceHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingOrgId)) {
            realHeaders.put("dingOrgId", headers.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingIsvOrgId)) {
            realHeaders.put("dingIsvOrgId", headers.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingCorpId)) {
            realHeaders.put("dingCorpId", headers.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingSuiteKey)) {
            realHeaders.put("dingSuiteKey", headers.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingAccessTokenType)) {
            realHeaders.put("dingAccessTokenType", headers.dingAccessTokenType);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetTbProjectSource", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/source", "json", req, runtime), new GetTbProjectSourceResponse());
    }

    public GetTbProjectGrayResponse getTbProjectGray(GetTbProjectGrayRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTbProjectGrayHeaders headers = new GetTbProjectGrayHeaders();
        return this.getTbProjectGrayWithOptions(request, headers, runtime);
    }

    public GetTbProjectGrayResponse getTbProjectGrayWithOptions(GetTbProjectGrayRequest request, GetTbProjectGrayHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.label)) {
            body.put("label", request.label);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingAccessTokenType)) {
            realHeaders.put("dingAccessTokenType", headers.dingAccessTokenType);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingSuiteKey)) {
            realHeaders.put("dingSuiteKey", headers.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingIsvOrgId)) {
            realHeaders.put("dingIsvOrgId", headers.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingOrgId)) {
            realHeaders.put("dingOrgId", headers.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.dingCorpId)) {
            realHeaders.put("dingCorpId", headers.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetTbProjectGray", "project_1.0", "HTTP", "POST", "AK", "/v1.0/project/projects/gray", "json", req, runtime), new GetTbProjectGrayResponse());
    }
}
