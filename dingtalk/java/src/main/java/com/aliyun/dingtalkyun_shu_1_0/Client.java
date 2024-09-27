// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyun_shu_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkyun_shu_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>生态日志数据互通</p>
     * 
     * @param request SaveOpenExternalLogRequest
     * @param headers SaveOpenExternalLogHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveOpenExternalLogResponse
     */
    public SaveOpenExternalLogResponse saveOpenExternalLogWithOptions(SaveOpenExternalLogRequest request, SaveOpenExternalLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logSource)) {
            body.put("logSource", request.logSource);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logType)) {
            body.put("logType", request.logType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openExt)) {
            body.put("openExt", request.openExt);
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
            new TeaPair("action", "SaveOpenExternalLog"),
            new TeaPair("version", "yunShu_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/yunShu/externalLogs/save"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveOpenExternalLogResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生态日志数据互通</p>
     * 
     * @param request SaveOpenExternalLogRequest
     * @return SaveOpenExternalLogResponse
     */
    public SaveOpenExternalLogResponse saveOpenExternalLog(SaveOpenExternalLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveOpenExternalLogHeaders headers = new SaveOpenExternalLogHeaders();
        return this.saveOpenExternalLogWithOptions(request, headers, runtime);
    }
}
