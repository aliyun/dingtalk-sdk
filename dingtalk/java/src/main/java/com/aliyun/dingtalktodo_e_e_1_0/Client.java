// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktodo_e_e_1_0.models.*;

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
     * <p>注册应用类目信息</p>
     * 
     * @param request RegisterCategorySourceConfigRequest
     * @param headers RegisterCategorySourceConfigHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterCategorySourceConfigResponse
     */
    public RegisterCategorySourceConfigResponse registerCategorySourceConfigWithOptions(RegisterCategorySourceConfigRequest request, RegisterCategorySourceConfigHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryId)) {
            body.put("bizCategoryId", request.bizCategoryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCategoryName)) {
            body.put("bizCategoryName", request.bizCategoryName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
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
            new TeaPair("action", "RegisterCategorySourceConfig"),
            new TeaPair("version", "todoEE_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/todoEE/apps/categories/sourceConfigs/register"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterCategorySourceConfigResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>注册应用类目信息</p>
     * 
     * @param request RegisterCategorySourceConfigRequest
     * @return RegisterCategorySourceConfigResponse
     */
    public RegisterCategorySourceConfigResponse registerCategorySourceConfig(RegisterCategorySourceConfigRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterCategorySourceConfigHeaders headers = new RegisterCategorySourceConfigHeaders();
        return this.registerCategorySourceConfigWithOptions(request, headers, runtime);
    }
}
