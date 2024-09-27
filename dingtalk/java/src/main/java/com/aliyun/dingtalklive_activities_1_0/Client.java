// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_activities_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalklive_activities_1_0.models.*;

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
     * <p>实时活动发送接口</p>
     * 
     * @param request PushLiveActivityRequest
     * @param headers PushLiveActivityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PushLiveActivityResponse
     */
    public PushLiveActivityResponse pushLiveActivityWithOptions(PushLiveActivityRequest request, PushLiveActivityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.activityEventData)) {
            body.put("activityEventData", request.activityEventData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.activityEventOption)) {
            body.put("activityEventOption", request.activityEventOption);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.activityId)) {
            body.put("activityId", request.activityId);
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
            new TeaPair("action", "PushLiveActivity"),
            new TeaPair("version", "liveActivities_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/liveActivities/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PushLiveActivityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>实时活动发送接口</p>
     * 
     * @param request PushLiveActivityRequest
     * @return PushLiveActivityResponse
     */
    public PushLiveActivityResponse pushLiveActivity(PushLiveActivityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PushLiveActivityHeaders headers = new PushLiveActivityHeaders();
        return this.pushLiveActivityWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送实时活动</p>
     * 
     * @param request SendLiveActivityRequest
     * @param headers SendLiveActivityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SendLiveActivityResponse
     */
    public SendLiveActivityResponse sendLiveActivityWithOptions(SendLiveActivityRequest request, SendLiveActivityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.activityEventData)) {
            body.put("activityEventData", request.activityEventData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.activityEventOption)) {
            body.put("activityEventOption", request.activityEventOption);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.activityId)) {
            body.put("activityId", request.activityId);
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
            new TeaPair("action", "SendLiveActivity"),
            new TeaPair("version", "liveActivities_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/liveActivities/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SendLiveActivityResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发送实时活动</p>
     * 
     * @param request SendLiveActivityRequest
     * @return SendLiveActivityResponse
     */
    public SendLiveActivityResponse sendLiveActivity(SendLiveActivityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendLiveActivityHeaders headers = new SendLiveActivityHeaders();
        return this.sendLiveActivityWithOptions(request, headers, runtime);
    }
}
