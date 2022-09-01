// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktrip_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public SyncBusinessSignInfoResponse syncBusinessSignInfo(SyncBusinessSignInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncBusinessSignInfoHeaders headers = new SyncBusinessSignInfoHeaders();
        return this.syncBusinessSignInfoWithOptions(request, headers, runtime);
    }

    public SyncBusinessSignInfoResponse syncBusinessSignInfoWithOptions(SyncBusinessSignInfoRequest request, SyncBusinessSignInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizTypeList)) {
            body.put("bizTypeList", request.bizTypeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtOrgPay)) {
            body.put("gmtOrgPay", request.gmtOrgPay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtSign)) {
            body.put("gmtSign", request.gmtSign);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgPayStatus)) {
            body.put("orgPayStatus", request.orgPayStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signStatus)) {
            body.put("signStatus", request.signStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
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
        return TeaModel.toModel(this.doROARequest("SyncBusinessSignInfo", "trip_1.0", "HTTP", "POST", "AK", "/v1.0/trip/businessSignInfos/sync", "json", req, runtime), new SyncBusinessSignInfoResponse());
    }

    public SyncSecretKeyResponse syncSecretKey(SyncSecretKeyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncSecretKeyHeaders headers = new SyncSecretKeyHeaders();
        return this.syncSecretKeyWithOptions(request, headers, runtime);
    }

    public SyncSecretKeyResponse syncSecretKeyWithOptions(SyncSecretKeyRequest request, SyncSecretKeyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            body.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.secretString)) {
            body.put("secretString", request.secretString);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tripAppKey)) {
            body.put("tripAppKey", request.tripAppKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tripAppSecurity)) {
            body.put("tripAppSecurity", request.tripAppSecurity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tripCorpId)) {
            body.put("tripCorpId", request.tripCorpId);
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
        return TeaModel.toModel(this.doROARequest("SyncSecretKey", "trip_1.0", "HTTP", "POST", "AK", "/v1.0/trip/secretKeys/sync", "json", req, runtime), new SyncSecretKeyResponse());
    }

    public SyncTripOrderResponse syncTripOrder(SyncTripOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncTripOrderHeaders headers = new SyncTripOrderHeaders();
        return this.syncTripOrderWithOptions(request, headers, runtime);
    }

    public SyncTripOrderResponse syncTripOrderWithOptions(SyncTripOrderRequest request, SyncTripOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.currency)) {
            body.put("currency", request.currency);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            body.put("dingUserId", request.dingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.discountAmount)) {
            body.put("discountAmount", request.discountAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endorseFlag)) {
            body.put("endorseFlag", request.endorseFlag);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.event))) {
            body.put("event", request.event);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtOrder)) {
            body.put("gmtOrder", request.gmtOrder);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtPay)) {
            body.put("gmtPay", request.gmtPay);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtRefund)) {
            body.put("gmtRefund", request.gmtRefund);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceApplyUrl)) {
            body.put("invoiceApplyUrl", request.invoiceApplyUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.journeyBizNo)) {
            body.put("journeyBizNo", request.journeyBizNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderDetails)) {
            body.put("orderDetails", request.orderDetails);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderUrl)) {
            body.put("orderUrl", request.orderUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.realAmount)) {
            body.put("realAmount", request.realAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundAmount)) {
            body.put("refundAmount", request.refundAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relativeOrderNo)) {
            body.put("relativeOrderNo", request.relativeOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetCorpId)) {
            body.put("targetCorpId", request.targetCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalAmount)) {
            body.put("totalAmount", request.totalAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
        return TeaModel.toModel(this.doROARequest("SyncTripOrder", "trip_1.0", "HTTP", "POST", "AK", "/v1.0/trip/tripOrders/sync", "json", req, runtime), new SyncTripOrderResponse());
    }
}
