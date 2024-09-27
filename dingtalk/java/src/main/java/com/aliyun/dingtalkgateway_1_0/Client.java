// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkgateway_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkgateway_1_0.models.*;

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
     * <p>云上网关注册长连接</p>
     * 
     * @param request OpenConnectionRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return OpenConnectionResponse
     */
    public OpenConnectionResponse openConnectionWithOptions(OpenConnectionRequest request, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.clientId)) {
            body.put("clientId", request.clientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.clientSecret)) {
            body.put("clientSecret", request.clientSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extras)) {
            body.put("extras", request.extras);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.localIp)) {
            body.put("localIp", request.localIp);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subscriptions)) {
            body.put("subscriptions", request.subscriptions);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "OpenConnection"),
            new TeaPair("version", "gateway_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/gateway/connections/open"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.doROARequestWithForm(params.action, params.version, params.protocol, params.method, params.authType, params.pathname, params.bodyType, req, runtime), new OpenConnectionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>云上网关注册长连接</p>
     * 
     * @param request OpenConnectionRequest
     * @return OpenConnectionResponse
     */
    public OpenConnectionResponse openConnection(OpenConnectionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.openConnectionWithOptions(request, headers, runtime);
    }
}
