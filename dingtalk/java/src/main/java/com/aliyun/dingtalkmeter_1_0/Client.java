// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmeter_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkmeter_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>获取开放平台当月资源用量</p>
     * 
     * @param request GetResourceUseInfoRequest
     * @param headers GetResourceUseInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetResourceUseInfoResponse
     */
    public GetResourceUseInfoResponse getResourceUseInfoWithOptions(GetResourceUseInfoRequest request, GetResourceUseInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCodeList)) {
            body.put("benefitCodeList", request.benefitCodeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.period)) {
            body.put("period", request.period);
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
            new TeaPair("action", "GetResourceUseInfo"),
            new TeaPair("version", "meter_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/meter/resources/useInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetResourceUseInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取开放平台当月资源用量</p>
     * 
     * @param request GetResourceUseInfoRequest
     * @return GetResourceUseInfoResponse
     */
    public GetResourceUseInfoResponse getResourceUseInfo(GetResourceUseInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetResourceUseInfoHeaders headers = new GetResourceUseInfoHeaders();
        return this.getResourceUseInfoWithOptions(request, headers, runtime);
    }
}
