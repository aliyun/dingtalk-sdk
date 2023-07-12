// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkreport_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkreport_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CreateTemplatesResponse createTemplatesWithOptions(CreateTemplatesRequest request, CreateTemplatesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.allowAddReceivers)) {
            body.put("allowAddReceivers", request.allowAddReceivers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allowEdit)) {
            body.put("allowEdit", request.allowEdit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allowGetLocation)) {
            body.put("allowGetLocation", request.allowGetLocation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authDeptIds)) {
            body.put("authDeptIds", request.authDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authUserIds)) {
            body.put("authUserIds", request.authUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creator)) {
            body.put("creator", request.creator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultReceivedCids)) {
            body.put("defaultReceivedCids", request.defaultReceivedCids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultReceivedMasterLevels)) {
            body.put("defaultReceivedMasterLevels", request.defaultReceivedMasterLevels);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultReceivers)) {
            body.put("defaultReceivers", request.defaultReceivers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fields)) {
            body.put("fields", request.fields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logo)) {
            body.put("logo", request.logo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxWordCount)) {
            body.put("maxWordCount", request.maxWordCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.minWordCount)) {
            body.put("minWordCount", request.minWordCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateManagers)) {
            body.put("templateManagers", request.templateManagers);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateTemplates"),
            new TeaPair("version", "report_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/report/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateTemplatesResponse());
    }

    public CreateTemplatesResponse createTemplates(CreateTemplatesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTemplatesHeaders headers = new CreateTemplatesHeaders();
        return this.createTemplatesWithOptions(request, headers, runtime);
    }
}
