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

    public UpateUserCodeInstanceResponse upateUserCodeInstance(UpateUserCodeInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpateUserCodeInstanceHeaders headers = new UpateUserCodeInstanceHeaders();
        return this.upateUserCodeInstanceWithOptions(request, headers, runtime);
    }

    public UpateUserCodeInstanceResponse upateUserCodeInstanceWithOptions(UpateUserCodeInstanceRequest request, UpateUserCodeInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.codeId)) {
            body.put("codeId", request.codeId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeIdentity)) {
            body.put("codeIdentity", request.codeIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeValue)) {
            body.put("codeValue", request.codeValue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userCorpRelationType)) {
            body.put("userCorpRelationType", request.userCorpRelationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentity)) {
            body.put("userIdentity", request.userIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtExpired)) {
            body.put("gmtExpired", request.gmtExpired);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.availableTimes)) {
            body.put("availableTimes", request.availableTimes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
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
        return TeaModel.toModel(this.doROARequest("UpateUserCodeInstance", "finance_1.0", "HTTP", "PUT", "AK", "/v1.0/finance/payCodes/userInstances", "json", req, runtime), new UpateUserCodeInstanceResponse());
    }

    public ApplyBatchPayResponse applyBatchPay(ApplyBatchPayRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ApplyBatchPayHeaders headers = new ApplyBatchPayHeaders();
        return this.applyBatchPayWithOptions(request, headers, runtime);
    }

    public ApplyBatchPayResponse applyBatchPayWithOptions(ApplyBatchPayRequest request, ApplyBatchPayHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.staffId)) {
            body.put("staffId", request.staffId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transAmount)) {
            body.put("transAmount", request.transAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.returnUrl)) {
            body.put("returnUrl", request.returnUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.passBackParams)) {
            body.put("passBackParams", request.passBackParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payTerminal)) {
            body.put("payTerminal", request.payTerminal);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transExpireTime)) {
            body.put("transExpireTime", request.transExpireTime);
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
        return TeaModel.toModel(this.doROARequest("ApplyBatchPay", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders/pay", "json", req, runtime), new ApplyBatchPayResponse());
    }

    public QueryBatchTradeOrderResponse queryBatchTradeOrder(QueryBatchTradeOrderRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryBatchTradeOrderHeaders headers = new QueryBatchTradeOrderHeaders();
        return this.queryBatchTradeOrderWithOptions(request, headers, runtime);
    }

    public QueryBatchTradeOrderResponse queryBatchTradeOrderWithOptions(QueryBatchTradeOrderRequest request, QueryBatchTradeOrderHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outBatchNos)) {
            body.put("outBatchNos", request.outBatchNos);
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
        return TeaModel.toModel(this.doROARequest("QueryBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders/query", "json", req, runtime), new QueryBatchTradeOrderResponse());
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

    public NotifyVerifyResultResponse notifyVerifyResult(NotifyVerifyResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        NotifyVerifyResultHeaders headers = new NotifyVerifyResultHeaders();
        return this.notifyVerifyResultWithOptions(request, headers, runtime);
    }

    public NotifyVerifyResultResponse notifyVerifyResultWithOptions(NotifyVerifyResultRequest request, NotifyVerifyResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.payCode)) {
            body.put("payCode", request.payCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userCorpRelationType)) {
            body.put("userCorpRelationType", request.userCorpRelationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentity)) {
            body.put("userIdentity", request.userIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyTime)) {
            body.put("verifyTime", request.verifyTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyResult)) {
            body.put("verifyResult", request.verifyResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyLocation)) {
            body.put("verifyLocation", request.verifyLocation);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
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
        return TeaModel.toModel(this.doROARequest("NotifyVerifyResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/verifyResults/notify", "json", req, runtime), new NotifyVerifyResultResponse());
    }

    public CreateBatchTradeOrderResponse createBatchTradeOrder(CreateBatchTradeOrderRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateBatchTradeOrderHeaders headers = new CreateBatchTradeOrderHeaders();
        return this.createBatchTradeOrderWithOptions(request, headers, runtime);
    }

    public CreateBatchTradeOrderResponse createBatchTradeOrderWithOptions(CreateBatchTradeOrderRequest request, CreateBatchTradeOrderHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.staffId)) {
            body.put("staffId", request.staffId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountNo)) {
            body.put("accountNo", request.accountNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeTitle)) {
            body.put("tradeTitle", request.tradeTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outBatchNo)) {
            body.put("outBatchNo", request.outBatchNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.batchRemark)) {
            body.put("batchRemark", request.batchRemark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalCount)) {
            body.put("totalCount", request.totalCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalAmount)) {
            body.put("totalAmount", request.totalAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.batchTradeDetails)) {
            body.put("batchTradeDetails", request.batchTradeDetails);
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
        return TeaModel.toModel(this.doROARequest("CreateBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders", "json", req, runtime), new CreateBatchTradeOrderResponse());
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

    public QueryBatchTradeDetailListResponse queryBatchTradeDetailList(QueryBatchTradeDetailListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryBatchTradeDetailListHeaders headers = new QueryBatchTradeDetailListHeaders();
        return this.queryBatchTradeDetailListWithOptions(request, headers, runtime);
    }

    public QueryBatchTradeDetailListResponse queryBatchTradeDetailListWithOptions(QueryBatchTradeDetailListRequest request, QueryBatchTradeDetailListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outBatchNo)) {
            query.put("outBatchNo", request.outBatchNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryBatchTradeDetailList", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/batchTrades/details", "json", req, runtime), new QueryBatchTradeDetailListResponse());
    }

    public QueryPayAccountListResponse queryPayAccountList() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryPayAccountListHeaders headers = new QueryPayAccountListHeaders();
        return this.queryPayAccountListWithOptions(headers, runtime);
    }

    public QueryPayAccountListResponse queryPayAccountListWithOptions(QueryPayAccountListHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryPayAccountList", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/payAccounts", "json", req, runtime), new QueryPayAccountListResponse());
    }

    public CreateUserCodeInstanceResponse createUserCodeInstance(CreateUserCodeInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateUserCodeInstanceHeaders headers = new CreateUserCodeInstanceHeaders();
        return this.createUserCodeInstanceWithOptions(request, headers, runtime);
    }

    public CreateUserCodeInstanceResponse createUserCodeInstanceWithOptions(CreateUserCodeInstanceRequest request, CreateUserCodeInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("requestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeIdentity)) {
            body.put("codeIdentity", request.codeIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.codeValue)) {
            body.put("codeValue", request.codeValue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userCorpRelationType)) {
            body.put("userCorpRelationType", request.userCorpRelationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdentity)) {
            body.put("userIdentity", request.userIdentity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gmtExpired)) {
            body.put("gmtExpired", request.gmtExpired);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.availableTimes)) {
            body.put("availableTimes", request.availableTimes);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extInfo)) {
            body.put("extInfo", request.extInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
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
        return TeaModel.toModel(this.doROARequest("CreateUserCodeInstance", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/userInstances", "json", req, runtime), new CreateUserCodeInstanceResponse());
    }
}
