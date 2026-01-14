// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkshangou_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkshangou_1_0.models.*;

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
     * <p>新增餐饮评价数据</p>
     * 
     * @param request AddCateringCommentRequest
     * @param headers AddCateringCommentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCateringCommentResponse
     */
    public AddCateringCommentResponse addCateringCommentWithOptions(AddCateringCommentRequest request, AddCateringCommentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.commentId)) {
            body.put("commentId", request.commentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rateContent)) {
            body.put("rateContent", request.rateContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ratedAt)) {
            body.put("ratedAt", request.ratedAt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.rating)) {
            body.put("rating", request.rating);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.shopId)) {
            body.put("shopId", request.shopId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
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
            new TeaPair("action", "AddCateringComment"),
            new TeaPair("version", "shangou_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/shangou/comment/create"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCateringCommentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增餐饮评价数据</p>
     * 
     * @param request AddCateringCommentRequest
     * @return AddCateringCommentResponse
     */
    public AddCateringCommentResponse addCateringComment(AddCateringCommentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCateringCommentHeaders headers = new AddCateringCommentHeaders();
        return this.addCateringCommentWithOptions(request, headers, runtime);
    }
}
