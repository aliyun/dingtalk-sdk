// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkding_one_1_0.models.*;

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
     * <p>投放钉钉one中feed流资讯内容</p>
     * 
     * @param request DeliverOneFeedRequest
     * @param headers DeliverOneFeedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeliverOneFeedResponse
     */
    public DeliverOneFeedResponse deliverOneFeedWithOptions(DeliverOneFeedRequest request, DeliverOneFeedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coverMediaId)) {
            body.put("coverMediaId", request.coverMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.expireTime)) {
            body.put("expireTime", request.expireTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.summary)) {
            body.put("summary", request.summary);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.videoMediaId)) {
            body.put("videoMediaId", request.videoMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.videoTags)) {
            body.put("videoTags", request.videoTags);
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
            new TeaPair("action", "DeliverOneFeed"),
            new TeaPair("version", "dingOne_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/dingOne/feed/deliver"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeliverOneFeedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>投放钉钉one中feed流资讯内容</p>
     * 
     * @param request DeliverOneFeedRequest
     * @return DeliverOneFeedResponse
     */
    public DeliverOneFeedResponse deliverOneFeed(DeliverOneFeedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeliverOneFeedHeaders headers = new DeliverOneFeedHeaders();
        return this.deliverOneFeedWithOptions(request, headers, runtime);
    }
}
