// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkmicro_app_1_0.models.*;
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


    public CreateInnerAppResponse createInnerApp(CreateInnerAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
        return this.createInnerAppWithOptions(request, headers, runtime);
    }

    public CreateInnerAppResponse createInnerAppWithOptions(CreateInnerAppRequest request, CreateInnerAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            body.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageLink)) {
            body.put("homepageLink", request.homepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageLink)) {
            body.put("pcHomepageLink", request.pcHomepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ompLink)) {
            body.put("ompLink", request.ompLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ipWhiteList)) {
            body.put("ipWhiteList", request.ipWhiteList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeType)) {
            body.put("scopeType", request.scopeType);
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
        return TeaModel.toModel(this.doROARequest("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps", "json", req, runtime), new CreateInnerAppResponse());
    }
}
