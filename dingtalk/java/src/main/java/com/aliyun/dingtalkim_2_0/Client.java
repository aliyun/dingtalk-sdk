// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkim_2_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CloseTopboxResponse closeTopbox(CloseTopboxRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseTopboxHeaders headers = new CloseTopboxHeaders();
        return this.closeTopboxWithOptions(request, headers, runtime);
    }

    public CloseTopboxResponse closeTopboxWithOptions(CloseTopboxRequest request, CloseTopboxHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationType)) {
            body.put("conversationType", request.conversationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupTemplateId)) {
            body.put("groupTemplateId", request.groupTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unoinId)) {
            body.put("unoinId", request.unoinId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("CloseTopbox", "im_2.0", "HTTP", "POST", "AK", "/v2.0/im/topBoxes/close", "json", req, runtime), new CloseTopboxResponse());
    }

    public CreateTopboxResponse createTopbox(CreateTopboxRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateTopboxHeaders headers = new CreateTopboxHeaders();
        return this.createTopboxWithOptions(request, headers, runtime);
    }

    public CreateTopboxResponse createTopboxWithOptions(CreateTopboxRequest request, CreateTopboxHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackRouteKey)) {
            body.put("callbackRouteKey", request.callbackRouteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardData))) {
            body.put("cardData", request.cardData);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.cardSettings))) {
            body.put("cardSettings", request.cardSettings);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cardTemplateId)) {
            body.put("cardTemplateId", request.cardTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conversationType)) {
            body.put("conversationType", request.conversationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.expiredTime)) {
            body.put("expiredTime", request.expiredTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupTemplateId)) {
            body.put("groupTemplateId", request.groupTemplateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            body.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTrackId)) {
            body.put("outTrackId", request.outTrackId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.platforms)) {
            body.put("platforms", request.platforms);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUnionIdList)) {
            body.put("receiverUnionIdList", request.receiverUnionIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIdList)) {
            body.put("receiverUserIdList", request.receiverUserIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.robotCode)) {
            body.put("robotCode", request.robotCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionIdPrivateDataMap)) {
            body.put("unionIdPrivateDataMap", request.unionIdPrivateDataMap);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unoinId)) {
            body.put("unoinId", request.unoinId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdPrivateDataMap)) {
            body.put("userIdPrivateDataMap", request.userIdPrivateDataMap);
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
        return TeaModel.toModel(this.doROARequest("CreateTopbox", "im_2.0", "HTTP", "POST", "AK", "/v2.0/im/topBoxes", "json", req, runtime), new CreateTopboxResponse());
    }
}
