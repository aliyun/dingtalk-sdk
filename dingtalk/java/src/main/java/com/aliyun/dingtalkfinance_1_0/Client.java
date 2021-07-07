// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkfinance_1_0.models.*;
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


    public NotifyPayCodePayResultResponse notifyPayCodePayResult(NotifyPayCodePayResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        NotifyPayCodePayResultHeaders headers = new NotifyPayCodePayResultHeaders();
        return this.notifyPayCodePayResultWithOptions(request, headers, runtime);
    }

    public NotifyPayCodePayResultResponse notifyPayCodePayResultWithOptions(NotifyPayCodePayResultRequest request, NotifyPayCodePayResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.payCode)) {
            body.put("payCode", request.payCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtTradeCreate)) {
            body.put("gmtTradeCreate", request.gmtTradeCreate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtTradeFinish)) {
            body.put("gmtTradeFinish", request.gmtTradeFinish);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeNo)) {
            body.put("tradeNo", request.tradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeStatus)) {
            body.put("tradeStatus", request.tradeStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.amount)) {
            body.put("amount", request.amount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.promotionAmount)) {
            body.put("promotionAmount", request.promotionAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.chargeAmount)) {
            body.put("chargeAmount", request.chargeAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannelDetailList)) {
            body.put("payChannelDetailList", request.payChannelDetailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeErrorCode)) {
            body.put("tradeErrorCode", request.tradeErrorCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeErrorMsg)) {
            body.put("tradeErrorMsg", request.tradeErrorMsg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantName)) {
            body.put("merchantName", request.merchantName);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("NotifyPayCodePayResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/payResults/notify", "json", req, runtime), new NotifyPayCodePayResultResponse());
    }

    public NotifyPayCodeRefundResultResponse notifyPayCodeRefundResult(NotifyPayCodeRefundResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        NotifyPayCodeRefundResultHeaders headers = new NotifyPayCodeRefundResultHeaders();
        return this.notifyPayCodeRefundResultWithOptions(request, headers, runtime);
    }

    public NotifyPayCodeRefundResultResponse notifyPayCodeRefundResultWithOptions(NotifyPayCodeRefundResultRequest request, NotifyPayCodeRefundResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeNo)) {
            body.put("tradeNo", request.tradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundOrderNo)) {
            body.put("refundOrderNo", request.refundOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundAmount)) {
            body.put("refundAmount", request.refundAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundPromotionAmount)) {
            body.put("refundPromotionAmount", request.refundPromotionAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtRefund)) {
            body.put("gmtRefund", request.gmtRefund);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannelDetailList)) {
            body.put("payChannelDetailList", request.payChannelDetailList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payCode)) {
            body.put("payCode", request.payCode);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("NotifyPayCodeRefundResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/refundResults/notify", "json", req, runtime), new NotifyPayCodeRefundResultResponse());
    }

    public DecodePayCodeResponse decodePayCode(DecodePayCodeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DecodePayCodeHeaders headers = new DecodePayCodeHeaders();
        return this.decodePayCodeWithOptions(request, headers, runtime);
    }

    public DecodePayCodeResponse decodePayCodeWithOptions(DecodePayCodeRequest request, DecodePayCodeHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DecodePayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/decode", "json", req, runtime), new DecodePayCodeResponse());
    }

    public SaveCorpPayCodeResponse saveCorpPayCode(SaveCorpPayCodeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SaveCorpPayCodeHeaders headers = new SaveCorpPayCodeHeaders();
        return this.saveCorpPayCodeWithOptions(request, headers, runtime);
    }

    public SaveCorpPayCodeResponse saveCorpPayCodeWithOptions(SaveCorpPayCodeRequest request, SaveCorpPayCodeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.codeIdentity)) {
            body.put("codeIdentity", request.codeIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingClientId)) {
            body.put("dingClientId", request.dingClientId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("SaveCorpPayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/corpSettings", "json", req, runtime), new SaveCorpPayCodeResponse());
    }
}
