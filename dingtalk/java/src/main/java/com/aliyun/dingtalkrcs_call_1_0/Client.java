// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrcs_call_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkrcs_call_1_0.models.*;

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
     * <p>主叫方发起免费电话给授权企业人员，关联订单id</p>
     * 
     * @param request RunCallUserRequest
     * @param headers RunCallUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RunCallUserResponse
     */
    public RunCallUserResponse runCallUserWithOptions(RunCallUserRequest request, RunCallUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authorizeCorpId)) {
            query.put("authorizeCorpId", request.authorizeCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authorizeUserId)) {
            query.put("authorizeUserId", request.authorizeUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            query.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "RunCallUser"),
            new TeaPair("version", "rcsCall_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/rcsCall/users/call"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RunCallUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>主叫方发起免费电话给授权企业人员，关联订单id</p>
     * 
     * @param request RunCallUserRequest
     * @return RunCallUserResponse
     */
    public RunCallUserResponse runCallUser(RunCallUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RunCallUserHeaders headers = new RunCallUserHeaders();
        return this.runCallUserWithOptions(request, headers, runtime);
    }
}
