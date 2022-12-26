// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcontract_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public SendContractCardResponse sendContractCard(SendContractCardRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SendContractCardHeaders headers = new SendContractCardHeaders();
        return this.sendContractCardWithOptions(request, headers, runtime);
    }

    public SendContractCardResponse sendContractCardWithOptions(SendContractCardRequest request, SendContractCardHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cardType)) {
            body.put("cardType", request.cardType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contractInfo)) {
            body.put("contractInfo", request.contractInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiveGroups)) {
            body.put("receiveGroups", request.receiveGroups);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receivers)) {
            body.put("receivers", request.receivers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sender)) {
            body.put("sender", request.sender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.syncSingleChat)) {
            body.put("syncSingleChat", request.syncSingleChat);
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
        return TeaModel.toModel(this.doROARequest("SendContractCard", "contract_1.0", "HTTP", "POST", "AK", "/v1.0/contract/cards/send", "json", req, runtime), new SendContractCardResponse());
    }
}
