// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcustomer_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._signatureAlgorithm = "v2";
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>大客户ltcPRC接口调用</p>
     * 
     * @param tmpReq CustomeRpcCallRequest
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomeRpcCallResponse
     */
    public CustomeRpcCallResponse customeRpcCallWithOptions(CustomeRpcCallRequest tmpReq, java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        CustomeRpcCallShrinkRequest request = new CustomeRpcCallShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.params)) {
            request.paramsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.params, "params", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.methodName)) {
            query.put("methodName", request.methodName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.paramsShrink)) {
            query.put("params", request.paramsShrink);
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CustomeRpcCall"),
            new TeaPair("version", "customer_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customer/rpcCall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomeRpcCallResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>大客户ltcPRC接口调用</p>
     * 
     * @param request CustomeRpcCallRequest
     * @return CustomeRpcCallResponse
     */
    public CustomeRpcCallResponse customeRpcCall(CustomeRpcCallRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.customeRpcCallWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>直签立项审批</p>
     * 
     * @param headers map
     * @param runtime runtime options for this request RuntimeOptions
     * @return ProjectSetupResponse
     */
    public ProjectSetupResponse projectSetupWithOptions(java.util.Map<String, String> headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", headers)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ProjectSetup"),
            new TeaPair("version", "customer_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/customer/project/setup"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "Anonymous"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ProjectSetupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>直签立项审批</p>
     * @return ProjectSetupResponse
     */
    public ProjectSetupResponse projectSetup() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        java.util.Map<String, String> headers = new java.util.HashMap<>();
        return this.projectSetupWithOptions(headers, runtime);
    }
}
