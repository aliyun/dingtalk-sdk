// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkbadge_1_0.models.*;
import com.aliyun.teautil.*;
import com.aliyun.teautil.models.*;
import com.aliyun.teaopenapi.*;
import com.aliyun.teaopenapi.models.*;
import com.aliyun.openapiutil.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public CreateBadgeCodeUserInstanceResponse createBadgeCodeUserInstance(CreateBadgeCodeUserInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateBadgeCodeUserInstanceHeaders headers = new CreateBadgeCodeUserInstanceHeaders();
        return this.createBadgeCodeUserInstanceWithOptions(request, headers, runtime);
    }

    public CreateBadgeCodeUserInstanceResponse createBadgeCodeUserInstanceWithOptions(CreateBadgeCodeUserInstanceRequest request, CreateBadgeCodeUserInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.availableTimes)) {
            body.put("availableTimes", request.availableTimes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeIdentity)) {
            body.put("codeIdentity", request.codeIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeValue)) {
            body.put("codeValue", request.codeValue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeValueType)) {
            body.put("codeValueType", request.codeValueType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtExpired)) {
            body.put("gmtExpired", request.gmtExpired);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userCorpRelationType)) {
            body.put("userCorpRelationType", request.userCorpRelationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentity)) {
            body.put("userIdentity", request.userIdentity);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateBadgeCodeUserInstance", "badge_1.0", "HTTP", "POST", "AK", "/v1.0/badge/codes/userInstances", "json", req, runtime), new CreateBadgeCodeUserInstanceResponse());
    }

    public CreateBadgeNotifyResponse createBadgeNotify(CreateBadgeNotifyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateBadgeNotifyHeaders headers = new CreateBadgeNotifyHeaders();
        return this.createBadgeNotifyWithOptions(request, headers, runtime);
    }

    public CreateBadgeNotifyResponse createBadgeNotifyWithOptions(CreateBadgeNotifyRequest request, CreateBadgeNotifyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgId)) {
            body.put("msgId", request.msgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgType)) {
            body.put("msgType", request.msgType);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateBadgeNotify", "badge_1.0", "HTTP", "POST", "AK", "/v1.0/badge/notices", "json", req, runtime), new CreateBadgeNotifyResponse());
    }

    public DecodeBadgeCodeResponse decodeBadgeCode(DecodeBadgeCodeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DecodeBadgeCodeHeaders headers = new DecodeBadgeCodeHeaders();
        return this.decodeBadgeCodeWithOptions(request, headers, runtime);
    }

    public DecodeBadgeCodeResponse decodeBadgeCodeWithOptions(DecodeBadgeCodeRequest request, DecodeBadgeCodeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.payCode)) {
            body.put("payCode", request.payCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DecodeBadgeCode", "badge_1.0", "HTTP", "POST", "AK", "/v1.0/badge/codes/decode", "json", req, runtime), new DecodeBadgeCodeResponse());
    }

    public NotifyBadgeCodePayResultResponse notifyBadgeCodePayResult(NotifyBadgeCodePayResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        NotifyBadgeCodePayResultHeaders headers = new NotifyBadgeCodePayResultHeaders();
        return this.notifyBadgeCodePayResultWithOptions(request, headers, runtime);
    }

    public NotifyBadgeCodePayResultResponse notifyBadgeCodePayResultWithOptions(NotifyBadgeCodePayResultRequest request, NotifyBadgeCodePayResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.amount)) {
            body.put("amount", request.amount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chargeAmount)) {
            body.put("chargeAmount", request.chargeAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtTradeCreate)) {
            body.put("gmtTradeCreate", request.gmtTradeCreate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtTradeFinish)) {
            body.put("gmtTradeFinish", request.gmtTradeFinish);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantName)) {
            body.put("merchantName", request.merchantName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannelDetailList)) {
            body.put("payChannelDetailList", request.payChannelDetailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payCode)) {
            body.put("payCode", request.payCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.promotionAmount)) {
            body.put("promotionAmount", request.promotionAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeErrorCode)) {
            body.put("tradeErrorCode", request.tradeErrorCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeErrorMsg)) {
            body.put("tradeErrorMsg", request.tradeErrorMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeNo)) {
            body.put("tradeNo", request.tradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeStatus)) {
            body.put("tradeStatus", request.tradeStatus);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("NotifyBadgeCodePayResult", "badge_1.0", "HTTP", "POST", "AK", "/v1.0/badge/codes/payResults", "json", req, runtime), new NotifyBadgeCodePayResultResponse());
    }

    public NotifyBadgeCodeRefundResultResponse notifyBadgeCodeRefundResult(NotifyBadgeCodeRefundResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        NotifyBadgeCodeRefundResultHeaders headers = new NotifyBadgeCodeRefundResultHeaders();
        return this.notifyBadgeCodeRefundResultWithOptions(request, headers, runtime);
    }

    public NotifyBadgeCodeRefundResultResponse notifyBadgeCodeRefundResultWithOptions(NotifyBadgeCodeRefundResultRequest request, NotifyBadgeCodeRefundResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtRefund)) {
            body.put("gmtRefund", request.gmtRefund);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannelDetailList)) {
            body.put("payChannelDetailList", request.payChannelDetailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payCode)) {
            body.put("payCode", request.payCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundAmount)) {
            body.put("refundAmount", request.refundAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundOrderNo)) {
            body.put("refundOrderNo", request.refundOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundPromotionAmount)) {
            body.put("refundPromotionAmount", request.refundPromotionAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeNo)) {
            body.put("tradeNo", request.tradeNo);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("NotifyBadgeCodeRefundResult", "badge_1.0", "HTTP", "POST", "AK", "/v1.0/badge/codes/refundResults", "json", req, runtime), new NotifyBadgeCodeRefundResultResponse());
    }

    public NotifyBadgeCodeVerifyResultResponse notifyBadgeCodeVerifyResult(NotifyBadgeCodeVerifyResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        NotifyBadgeCodeVerifyResultHeaders headers = new NotifyBadgeCodeVerifyResultHeaders();
        return this.notifyBadgeCodeVerifyResultWithOptions(request, headers, runtime);
    }

    public NotifyBadgeCodeVerifyResultResponse notifyBadgeCodeVerifyResultWithOptions(NotifyBadgeCodeVerifyResultRequest request, NotifyBadgeCodeVerifyResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payCode)) {
            body.put("payCode", request.payCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userCorpRelationType)) {
            body.put("userCorpRelationType", request.userCorpRelationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentity)) {
            body.put("userIdentity", request.userIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyEvent)) {
            body.put("verifyEvent", request.verifyEvent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyLocation)) {
            body.put("verifyLocation", request.verifyLocation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyNo)) {
            body.put("verifyNo", request.verifyNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyResult)) {
            body.put("verifyResult", request.verifyResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyTime)) {
            body.put("verifyTime", request.verifyTime);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("NotifyBadgeCodeVerifyResult", "badge_1.0", "HTTP", "POST", "AK", "/v1.0/badge/codes/verifyResults", "json", req, runtime), new NotifyBadgeCodeVerifyResultResponse());
    }

    public SaveBadgeCodeCorpInstanceResponse saveBadgeCodeCorpInstance(SaveBadgeCodeCorpInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SaveBadgeCodeCorpInstanceHeaders headers = new SaveBadgeCodeCorpInstanceHeaders();
        return this.saveBadgeCodeCorpInstanceWithOptions(request, headers, runtime);
    }

    public SaveBadgeCodeCorpInstanceResponse saveBadgeCodeCorpInstanceWithOptions(SaveBadgeCodeCorpInstanceRequest request, SaveBadgeCodeCorpInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.codeIdentity)) {
            body.put("codeIdentity", request.codeIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SaveBadgeCodeCorpInstance", "badge_1.0", "HTTP", "POST", "AK", "/v1.0/badge/codes/corpInstances", "json", req, runtime), new SaveBadgeCodeCorpInstanceResponse());
    }

    public UpdateBadgeCodeUserInstanceResponse updateBadgeCodeUserInstance(UpdateBadgeCodeUserInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateBadgeCodeUserInstanceHeaders headers = new UpdateBadgeCodeUserInstanceHeaders();
        return this.updateBadgeCodeUserInstanceWithOptions(request, headers, runtime);
    }

    public UpdateBadgeCodeUserInstanceResponse updateBadgeCodeUserInstanceWithOptions(UpdateBadgeCodeUserInstanceRequest request, UpdateBadgeCodeUserInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.availableTimes)) {
            body.put("availableTimes", request.availableTimes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeId)) {
            body.put("codeId", request.codeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeIdentity)) {
            body.put("codeIdentity", request.codeIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeValue)) {
            body.put("codeValue", request.codeValue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtExpired)) {
            body.put("gmtExpired", request.gmtExpired);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userCorpRelationType)) {
            body.put("userCorpRelationType", request.userCorpRelationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentity)) {
            body.put("userIdentity", request.userIdentity);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateBadgeCodeUserInstance", "badge_1.0", "HTTP", "PUT", "AK", "/v1.0/badge/codes/userInstances", "json", req, runtime), new UpdateBadgeCodeUserInstanceResponse());
    }
}
