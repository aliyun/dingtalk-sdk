// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkfinance_1_0.models.*;

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
     * <p>批量付款</p>
     * 
     * @param request ApplyBatchPayRequest
     * @param headers ApplyBatchPayHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ApplyBatchPayResponse
     */
    public ApplyBatchPayResponse applyBatchPayWithOptions(ApplyBatchPayRequest request, ApplyBatchPayHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.passBackParams)) {
            body.put("passBackParams", request.passBackParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payTerminal)) {
            body.put("payTerminal", request.payTerminal);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.returnUrl)) {
            body.put("returnUrl", request.returnUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.staffId)) {
            body.put("staffId", request.staffId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transAmount)) {
            body.put("transAmount", request.transAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.transExpireTime)) {
            body.put("transExpireTime", request.transExpireTime);
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
            new TeaPair("action", "ApplyBatchPay"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/batchTrades/orders/pay"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ApplyBatchPayResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量付款</p>
     * 
     * @param request ApplyBatchPayRequest
     * @return ApplyBatchPayResponse
     */
    public ApplyBatchPayResponse applyBatchPay(ApplyBatchPayRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ApplyBatchPayHeaders headers = new ApplyBatchPayHeaders();
        return this.applyBatchPayWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>助贷业务关闭借款入口</p>
     * 
     * @param request CloseLoanEntranceRequest
     * @param headers CloseLoanEntranceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CloseLoanEntranceResponse
     */
    public CloseLoanEntranceResponse closeLoanEntranceWithOptions(CloseLoanEntranceRequest request, CloseLoanEntranceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CloseLoanEntrance"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/loans/entrances/close"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CloseLoanEntranceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>助贷业务关闭借款入口</p>
     * 
     * @param request CloseLoanEntranceRequest
     * @return CloseLoanEntranceResponse
     */
    public CloseLoanEntranceResponse closeLoanEntrance(CloseLoanEntranceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CloseLoanEntranceHeaders headers = new CloseLoanEntranceHeaders();
        return this.closeLoanEntranceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>子机构创建进件预校验</p>
     * 
     * @param request ConsultCreateSubInstitutionRequest
     * @param headers ConsultCreateSubInstitutionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConsultCreateSubInstitutionResponse
     */
    public ConsultCreateSubInstitutionResponse consultCreateSubInstitutionWithOptions(ConsultCreateSubInstitutionRequest request, ConsultCreateSubInstitutionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bindingAlipayLogonId)) {
            body.put("bindingAlipayLogonId", request.bindingAlipayLogonId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactInfo)) {
            body.put("contactInfo", request.contactInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPersonCertInfo)) {
            body.put("legalPersonCertInfo", request.legalPersonCertInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTradeNo)) {
            body.put("outTradeNo", request.outTradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannel)) {
            body.put("payChannel", request.payChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualificationInfos)) {
            body.put("qualificationInfos", request.qualificationInfos);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.services)) {
            body.put("services", request.services);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.settleInfo)) {
            body.put("settleInfo", request.settleInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.solution)) {
            body.put("solution", request.solution);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstAddressInfo)) {
            body.put("subInstAddressInfo", request.subInstAddressInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstAuthInfo)) {
            body.put("subInstAuthInfo", request.subInstAuthInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstBasicInfo)) {
            body.put("subInstBasicInfo", request.subInstBasicInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstCertifyInfo)) {
            body.put("subInstCertifyInfo", request.subInstCertifyInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            body.put("subInstId", request.subInstId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstInvoiceInfo)) {
            body.put("subInstInvoiceInfo", request.subInstInvoiceInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstShopInfo)) {
            body.put("subInstShopInfo", request.subInstShopInfo);
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
            new TeaPair("action", "ConsultCreateSubInstitution"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/institutions/subInstitutions/consult"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConsultCreateSubInstitutionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>子机构创建进件预校验</p>
     * 
     * @param request ConsultCreateSubInstitutionRequest
     * @return ConsultCreateSubInstitutionResponse
     */
    public ConsultCreateSubInstitutionResponse consultCreateSubInstitution(ConsultCreateSubInstitutionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConsultCreateSubInstitutionHeaders headers = new ConsultCreateSubInstitutionHeaders();
        return this.consultCreateSubInstitutionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发起代扣交易</p>
     * 
     * @param request CreatWithholdingOrderAndPayRequest
     * @param headers CreatWithholdingOrderAndPayHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreatWithholdingOrderAndPayResponse
     */
    public CreatWithholdingOrderAndPayResponse creatWithholdingOrderAndPayWithOptions(CreatWithholdingOrderAndPayRequest request, CreatWithholdingOrderAndPayHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.amount)) {
            body.put("amount", request.amount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.otherPayChannelDetailInfoList)) {
            body.put("otherPayChannelDetailInfoList", request.otherPayChannelDetailInfoList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTradeNo)) {
            body.put("outTradeNo", request.outTradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannel)) {
            body.put("payChannel", request.payChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payerUserId)) {
            body.put("payerUserId", request.payerUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            body.put("subInstId", request.subInstId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeOutExpress)) {
            body.put("timeOutExpress", request.timeOutExpress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "CreatWithholdingOrderAndPay"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/withholdingOrders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreatWithholdingOrderAndPayResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发起代扣交易</p>
     * 
     * @param request CreatWithholdingOrderAndPayRequest
     * @return CreatWithholdingOrderAndPayResponse
     */
    public CreatWithholdingOrderAndPayResponse creatWithholdingOrderAndPay(CreatWithholdingOrderAndPayRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreatWithholdingOrderAndPayHeaders headers = new CreatWithholdingOrderAndPayHeaders();
        return this.creatWithholdingOrderAndPayWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>收单退款交易</p>
     * 
     * @param request CreateAcquireRefundOrderRequest
     * @param headers CreateAcquireRefundOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAcquireRefundOrderResponse
     */
    public CreateAcquireRefundOrderResponse createAcquireRefundOrderWithOptions(CreateAcquireRefundOrderRequest request, CreateAcquireRefundOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorUserId)) {
            body.put("operatorUserId", request.operatorUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.originOutTradeNo)) {
            body.put("originOutTradeNo", request.originOutTradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.otherPayChannelDetailInfoList)) {
            body.put("otherPayChannelDetailInfoList", request.otherPayChannelDetailInfoList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outRefundNo)) {
            body.put("outRefundNo", request.outRefundNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refundAmount)) {
            body.put("refundAmount", request.refundAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            body.put("subInstId", request.subInstId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
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
            new TeaPair("action", "CreateAcquireRefundOrder"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/acquireOrders/refund"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAcquireRefundOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>收单退款交易</p>
     * 
     * @param request CreateAcquireRefundOrderRequest
     * @return CreateAcquireRefundOrderResponse
     */
    public CreateAcquireRefundOrderResponse createAcquireRefundOrder(CreateAcquireRefundOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAcquireRefundOrderHeaders headers = new CreateAcquireRefundOrderHeaders();
        return this.createAcquireRefundOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建批量支付单</p>
     * 
     * @param request CreateBatchTradeOrderRequest
     * @param headers CreateBatchTradeOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateBatchTradeOrderResponse
     */
    public CreateBatchTradeOrderResponse createBatchTradeOrderWithOptions(CreateBatchTradeOrderRequest request, CreateBatchTradeOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountNo)) {
            body.put("accountNo", request.accountNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.batchRemark)) {
            body.put("batchRemark", request.batchRemark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.batchTradeDetails)) {
            body.put("batchTradeDetails", request.batchTradeDetails);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outBatchNo)) {
            body.put("outBatchNo", request.outBatchNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.staffId)) {
            body.put("staffId", request.staffId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalAmount)) {
            body.put("totalAmount", request.totalAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalCount)) {
            body.put("totalCount", request.totalCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tradeTitle)) {
            body.put("tradeTitle", request.tradeTitle);
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
            new TeaPair("action", "CreateBatchTradeOrder"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/batchTrades/orders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateBatchTradeOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建批量支付单</p>
     * 
     * @param request CreateBatchTradeOrderRequest
     * @return CreateBatchTradeOrderResponse
     */
    public CreateBatchTradeOrderResponse createBatchTradeOrder(CreateBatchTradeOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateBatchTradeOrderHeaders headers = new CreateBatchTradeOrderHeaders();
        return this.createBatchTradeOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建子机构</p>
     * 
     * @param request CreateSubInstitutionRequest
     * @param headers CreateSubInstitutionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateSubInstitutionResponse
     */
    public CreateSubInstitutionResponse createSubInstitutionWithOptions(CreateSubInstitutionRequest request, CreateSubInstitutionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bindingAlipayLogonId)) {
            body.put("bindingAlipayLogonId", request.bindingAlipayLogonId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactInfo)) {
            body.put("contactInfo", request.contactInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPersonCertInfo)) {
            body.put("legalPersonCertInfo", request.legalPersonCertInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTradeNo)) {
            body.put("outTradeNo", request.outTradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannel)) {
            body.put("payChannel", request.payChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualificationInfos)) {
            body.put("qualificationInfos", request.qualificationInfos);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.services)) {
            body.put("services", request.services);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.settleInfo)) {
            body.put("settleInfo", request.settleInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.solution)) {
            body.put("solution", request.solution);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstAddressInfo)) {
            body.put("subInstAddressInfo", request.subInstAddressInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstAuthInfo)) {
            body.put("subInstAuthInfo", request.subInstAuthInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstBasicInfo)) {
            body.put("subInstBasicInfo", request.subInstBasicInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstCertifyInfo)) {
            body.put("subInstCertifyInfo", request.subInstCertifyInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            body.put("subInstId", request.subInstId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstInvoiceInfo)) {
            body.put("subInstInvoiceInfo", request.subInstInvoiceInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstShopInfo)) {
            body.put("subInstShopInfo", request.subInstShopInfo);
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
            new TeaPair("action", "CreateSubInstitution"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/institutions/subInstitutions"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateSubInstitutionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建子机构</p>
     * 
     * @param request CreateSubInstitutionRequest
     * @return CreateSubInstitutionResponse
     */
    public CreateSubInstitutionResponse createSubInstitution(CreateSubInstitutionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateSubInstitutionHeaders headers = new CreateSubInstitutionHeaders();
        return this.createSubInstitutionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建用户码实例</p>
     * 
     * @param request CreateUserCodeInstanceRequest
     * @param headers CreateUserCodeInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateUserCodeInstanceResponse
     */
    public CreateUserCodeInstanceResponse createUserCodeInstanceWithOptions(CreateUserCodeInstanceRequest request, CreateUserCodeInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CreateUserCodeInstance"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payCodes/userInstances"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateUserCodeInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建用户码实例</p>
     * 
     * @param request CreateUserCodeInstanceRequest
     * @return CreateUserCodeInstanceResponse
     */
    public CreateUserCodeInstanceResponse createUserCodeInstance(CreateUserCodeInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateUserCodeInstanceHeaders headers = new CreateUserCodeInstanceHeaders();
        return this.createUserCodeInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>解码付款码</p>
     * 
     * @param request DecodePayCodeRequest
     * @param headers DecodePayCodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DecodePayCodeResponse
     */
    public DecodePayCodeResponse decodePayCodeWithOptions(DecodePayCodeRequest request, DecodePayCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DecodePayCode"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payCodes/decode"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DecodePayCodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>解码付款码</p>
     * 
     * @param request DecodePayCodeRequest
     * @return DecodePayCodeResponse
     */
    public DecodePayCodeResponse decodePayCode(DecodePayCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DecodePayCodeHeaders headers = new DecodePayCodeHeaders();
        return this.decodePayCodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>企业金融助贷业务进件通知接口</p>
     * 
     * @param request FinanceLoanNotifyRegisterRequest
     * @param headers FinanceLoanNotifyRegisterHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return FinanceLoanNotifyRegisterResponse
     */
    public FinanceLoanNotifyRegisterResponse financeLoanNotifyRegisterWithOptions(FinanceLoanNotifyRegisterRequest request, FinanceLoanNotifyRegisterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.completeTime)) {
            body.put("completeTime", request.completeTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.idCardNo)) {
            body.put("idCardNo", request.idCardNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openChannelName)) {
            body.put("openChannelName", request.openChannelName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openProductCode)) {
            body.put("openProductCode", request.openProductCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openProductName)) {
            body.put("openProductName", request.openProductName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openProductType)) {
            body.put("openProductType", request.openProductType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processingStatus)) {
            body.put("processingStatus", request.processingStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refuseCode)) {
            body.put("refuseCode", request.refuseCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refuseReason)) {
            body.put("refuseReason", request.refuseReason);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.registerNo)) {
            body.put("registerNo", request.registerNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.submitTime)) {
            body.put("submitTime", request.submitTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userMobile)) {
            body.put("userMobile", request.userMobile);
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
            new TeaPair("action", "FinanceLoanNotifyRegister"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/loans/notifications/register"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new FinanceLoanNotifyRegisterResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>企业金融助贷业务进件通知接口</p>
     * 
     * @param request FinanceLoanNotifyRegisterRequest
     * @return FinanceLoanNotifyRegisterResponse
     */
    public FinanceLoanNotifyRegisterResponse financeLoanNotifyRegister(FinanceLoanNotifyRegisterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        FinanceLoanNotifyRegisterHeaders headers = new FinanceLoanNotifyRegisterHeaders();
        return this.financeLoanNotifyRegisterWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改子机构信息</p>
     * 
     * @param request ModifySubInstitutionRequest
     * @param headers ModifySubInstitutionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ModifySubInstitutionResponse
     */
    public ModifySubInstitutionResponse modifySubInstitutionWithOptions(ModifySubInstitutionRequest request, ModifySubInstitutionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bindingAlipayLogonId)) {
            body.put("bindingAlipayLogonId", request.bindingAlipayLogonId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactInfo)) {
            body.put("contactInfo", request.contactInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.legalPersonCertInfo)) {
            body.put("legalPersonCertInfo", request.legalPersonCertInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTradeNo)) {
            body.put("outTradeNo", request.outTradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannel)) {
            body.put("payChannel", request.payChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualificationInfos)) {
            body.put("qualificationInfos", request.qualificationInfos);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.services)) {
            body.put("services", request.services);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.settleInfo)) {
            body.put("settleInfo", request.settleInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstAddressInfo)) {
            body.put("subInstAddressInfo", request.subInstAddressInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstAuthInfo)) {
            body.put("subInstAuthInfo", request.subInstAuthInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstBasicInfo)) {
            body.put("subInstBasicInfo", request.subInstBasicInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstCertifyInfo)) {
            body.put("subInstCertifyInfo", request.subInstCertifyInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            body.put("subInstId", request.subInstId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstInvoiceInfo)) {
            body.put("subInstInvoiceInfo", request.subInstInvoiceInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstShopInfo)) {
            body.put("subInstShopInfo", request.subInstShopInfo);
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
            new TeaPair("action", "ModifySubInstitution"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/institutions/subInstitutions/modify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ModifySubInstitutionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改子机构信息</p>
     * 
     * @param request ModifySubInstitutionRequest
     * @return ModifySubInstitutionResponse
     */
    public ModifySubInstitutionResponse modifySubInstitution(ModifySubInstitutionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ModifySubInstitutionHeaders headers = new ModifySubInstitutionHeaders();
        return this.modifySubInstitutionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通知付款码支付结果</p>
     * 
     * @param request NotifyPayCodePayResultRequest
     * @param headers NotifyPayCodePayResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return NotifyPayCodePayResultResponse
     */
    public NotifyPayCodePayResultResponse notifyPayCodePayResultWithOptions(NotifyPayCodePayResultRequest request, NotifyPayCodePayResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "NotifyPayCodePayResult"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payCodes/payResults/notify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new NotifyPayCodePayResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通知付款码支付结果</p>
     * 
     * @param request NotifyPayCodePayResultRequest
     * @return NotifyPayCodePayResultResponse
     */
    public NotifyPayCodePayResultResponse notifyPayCodePayResult(NotifyPayCodePayResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        NotifyPayCodePayResultHeaders headers = new NotifyPayCodePayResultHeaders();
        return this.notifyPayCodePayResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通知付款码退款结果</p>
     * 
     * @param request NotifyPayCodeRefundResultRequest
     * @param headers NotifyPayCodeRefundResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return NotifyPayCodeRefundResultResponse
     */
    public NotifyPayCodeRefundResultResponse notifyPayCodeRefundResultWithOptions(NotifyPayCodeRefundResultRequest request, NotifyPayCodeRefundResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "NotifyPayCodeRefundResult"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payCodes/refundResults/notify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new NotifyPayCodeRefundResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通知付款码退款结果</p>
     * 
     * @param request NotifyPayCodeRefundResultRequest
     * @return NotifyPayCodeRefundResultResponse
     */
    public NotifyPayCodeRefundResultResponse notifyPayCodeRefundResult(NotifyPayCodeRefundResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        NotifyPayCodeRefundResultHeaders headers = new NotifyPayCodeRefundResultHeaders();
        return this.notifyPayCodeRefundResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>上报码验证结果</p>
     * 
     * @param request NotifyVerifyResultRequest
     * @param headers NotifyVerifyResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return NotifyVerifyResultResponse
     */
    public NotifyVerifyResultResponse notifyVerifyResultWithOptions(NotifyVerifyResultRequest request, NotifyVerifyResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "NotifyVerifyResult"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payCodes/verifyResults/notify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new NotifyVerifyResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>上报码验证结果</p>
     * 
     * @param request NotifyVerifyResultRequest
     * @return NotifyVerifyResultResponse
     */
    public NotifyVerifyResultResponse notifyVerifyResult(NotifyVerifyResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        NotifyVerifyResultHeaders headers = new NotifyVerifyResultHeaders();
        return this.notifyVerifyResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>预创建群收款订单返回订单号</p>
     * 
     * @param request PreCreateGroupBillOrderRequest
     * @param headers PreCreateGroupBillOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PreCreateGroupBillOrderResponse
     */
    public PreCreateGroupBillOrderResponse preCreateGroupBillOrderWithOptions(PreCreateGroupBillOrderRequest request, PreCreateGroupBillOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.billItemList)) {
            body.put("billItemList", request.billItemList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extParams)) {
            body.put("extParams", request.extParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.headCount)) {
            body.put("headCount", request.headCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAverageAmount)) {
            body.put("isAverageAmount", request.isAverageAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.merchantId)) {
            body.put("merchantId", request.merchantId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openCid)) {
            body.put("openCid", request.openCid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outBizNo)) {
            body.put("outBizNo", request.outBizNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payeeCorpId)) {
            body.put("payeeCorpId", request.payeeCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payeeUnionId)) {
            body.put("payeeUnionId", request.payeeUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalAmount)) {
            body.put("totalAmount", request.totalAmount);
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
            new TeaPair("action", "PreCreateGroupBillOrder"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/groupbills/preCreate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PreCreateGroupBillOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>预创建群收款订单返回订单号</p>
     * 
     * @param request PreCreateGroupBillOrderRequest
     * @return PreCreateGroupBillOrderResponse
     */
    public PreCreateGroupBillOrderResponse preCreateGroupBillOrder(PreCreateGroupBillOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PreCreateGroupBillOrderHeaders headers = new PreCreateGroupBillOrderHeaders();
        return this.preCreateGroupBillOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询收单退款交易</p>
     * 
     * @param request QueryAcquireRefundOrderRequest
     * @param headers QueryAcquireRefundOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAcquireRefundOrderResponse
     */
    public QueryAcquireRefundOrderResponse queryAcquireRefundOrderWithOptions(QueryAcquireRefundOrderRequest request, QueryAcquireRefundOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outRefundNo)) {
            query.put("outRefundNo", request.outRefundNo);
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
            new TeaPair("action", "QueryAcquireRefundOrder"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/acquireOrders/refunds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAcquireRefundOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询收单退款交易</p>
     * 
     * @param request QueryAcquireRefundOrderRequest
     * @return QueryAcquireRefundOrderResponse
     */
    public QueryAcquireRefundOrderResponse queryAcquireRefundOrder(QueryAcquireRefundOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAcquireRefundOrderHeaders headers = new QueryAcquireRefundOrderHeaders();
        return this.queryAcquireRefundOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询批量付款明细列表</p>
     * 
     * @param request QueryBatchTradeDetailListRequest
     * @param headers QueryBatchTradeDetailListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBatchTradeDetailListResponse
     */
    public QueryBatchTradeDetailListResponse queryBatchTradeDetailListWithOptions(QueryBatchTradeDetailListRequest request, QueryBatchTradeDetailListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryBatchTradeDetailList"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/batchTrades/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBatchTradeDetailListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询批量付款明细列表</p>
     * 
     * @param request QueryBatchTradeDetailListRequest
     * @return QueryBatchTradeDetailListResponse
     */
    public QueryBatchTradeDetailListResponse queryBatchTradeDetailList(QueryBatchTradeDetailListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBatchTradeDetailListHeaders headers = new QueryBatchTradeDetailListHeaders();
        return this.queryBatchTradeDetailListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据请求对象查询批量交易订单信息</p>
     * 
     * @param request QueryBatchTradeOrderRequest
     * @param headers QueryBatchTradeOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBatchTradeOrderResponse
     */
    public QueryBatchTradeOrderResponse queryBatchTradeOrderWithOptions(QueryBatchTradeOrderRequest request, QueryBatchTradeOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryBatchTradeOrder"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/batchTrades/orders/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBatchTradeOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据请求对象查询批量交易订单信息</p>
     * 
     * @param request QueryBatchTradeOrderRequest
     * @return QueryBatchTradeOrderResponse
     */
    public QueryBatchTradeOrderResponse queryBatchTradeOrder(QueryBatchTradeOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBatchTradeOrderHeaders headers = new QueryBatchTradeOrderHeaders();
        return this.queryBatchTradeOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询付款账号列表</p>
     * 
     * @param headers QueryPayAccountListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPayAccountListResponse
     */
    public QueryPayAccountListResponse queryPayAccountListWithOptions(QueryPayAccountListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryPayAccountList"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payAccounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPayAccountListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询付款账号列表</p>
     * @return QueryPayAccountListResponse
     */
    public QueryPayAccountListResponse queryPayAccountList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPayAccountListHeaders headers = new QueryPayAccountListHeaders();
        return this.queryPayAccountListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询子机构申请单状态</p>
     * 
     * @param request QueryRegisterOrderRequest
     * @param headers QueryRegisterOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRegisterOrderResponse
     */
    public QueryRegisterOrderResponse queryRegisterOrderWithOptions(QueryRegisterOrderRequest request, QueryRegisterOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            query.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            query.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outTradeNo)) {
            query.put("outTradeNo", request.outTradeNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            query.put("subInstId", request.subInstId);
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
            new TeaPair("action", "QueryRegisterOrder"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/institutions/subInstitutions/orders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRegisterOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询子机构申请单状态</p>
     * 
     * @param request QueryRegisterOrderRequest
     * @return QueryRegisterOrderResponse
     */
    public QueryRegisterOrderResponse queryRegisterOrder(QueryRegisterOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRegisterOrderHeaders headers = new QueryRegisterOrderHeaders();
        return this.queryRegisterOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户协议</p>
     * 
     * @param request QueryUserAgreementRequest
     * @param headers QueryUserAgreementHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserAgreementResponse
     */
    public QueryUserAgreementResponse queryUserAgreementWithOptions(QueryUserAgreementRequest request, QueryUserAgreementHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            query.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizScene)) {
            query.put("bizScene", request.bizScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            query.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            query.put("subInstId", request.subInstId);
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
            new TeaPair("action", "QueryUserAgreement"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/userAgreements"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserAgreementResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户协议</p>
     * 
     * @param request QueryUserAgreementRequest
     * @return QueryUserAgreementResponse
     */
    public QueryUserAgreementResponse queryUserAgreement(QueryUserAgreementRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserAgreementHeaders headers = new QueryUserAgreementHeaders();
        return this.queryUserAgreementWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户绑定支付宝信息</p>
     * 
     * @param headers QueryUserAlipayAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserAlipayAccountResponse
     */
    public QueryUserAlipayAccountResponse queryUserAlipayAccountWithOptions(QueryUserAlipayAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryUserAlipayAccount"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/userAlipayAccounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserAlipayAccountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户绑定支付宝信息</p>
     * @return QueryUserAlipayAccountResponse
     */
    public QueryUserAlipayAccountResponse queryUserAlipayAccount() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserAlipayAccountHeaders headers = new QueryUserAlipayAccountHeaders();
        return this.queryUserAlipayAccountWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询代扣交易订单信息</p>
     * 
     * @param request QueryWithholdingOrderRequest
     * @param headers QueryWithholdingOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryWithholdingOrderResponse
     */
    public QueryWithholdingOrderResponse queryWithholdingOrderWithOptions(QueryWithholdingOrderRequest request, QueryWithholdingOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outTradeNo)) {
            query.put("outTradeNo", request.outTradeNo);
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
            new TeaPair("action", "QueryWithholdingOrder"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/withholdingOrders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryWithholdingOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询代扣交易订单信息</p>
     * 
     * @param request QueryWithholdingOrderRequest
     * @return QueryWithholdingOrderResponse
     */
    public QueryWithholdingOrderResponse queryWithholdingOrder(QueryWithholdingOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryWithholdingOrderHeaders headers = new QueryWithholdingOrderHeaders();
        return this.queryWithholdingOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存付款码企业配置信息</p>
     * 
     * @param request SaveCorpPayCodeRequest
     * @param headers SaveCorpPayCodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveCorpPayCodeResponse
     */
    public SaveCorpPayCodeResponse saveCorpPayCodeWithOptions(SaveCorpPayCodeRequest request, SaveCorpPayCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SaveCorpPayCode"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payCodes/corpSettings"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveCorpPayCodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存付款码企业配置信息</p>
     * 
     * @param request SaveCorpPayCodeRequest
     * @return SaveCorpPayCodeResponse
     */
    public SaveCorpPayCodeResponse saveCorpPayCode(SaveCorpPayCodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveCorpPayCodeHeaders headers = new SaveCorpPayCodeHeaders();
        return this.saveCorpPayCodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>解约用户协议</p>
     * 
     * @param request UnsignUserAgreementRequest
     * @param headers UnsignUserAgreementHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnsignUserAgreementResponse
     */
    public UnsignUserAgreementResponse unsignUserAgreementWithOptions(UnsignUserAgreementRequest request, UnsignUserAgreementHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.agreementNo)) {
            body.put("agreementNo", request.agreementNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizScene)) {
            body.put("bizScene", request.bizScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            body.put("subInstId", request.subInstId);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UnsignUserAgreement"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/userAgreements/unsign"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnsignUserAgreementResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>解约用户协议</p>
     * 
     * @param request UnsignUserAgreementRequest
     * @return UnsignUserAgreementResponse
     */
    public UnsignUserAgreementResponse unsignUserAgreement(UnsignUserAgreementRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnsignUserAgreementHeaders headers = new UnsignUserAgreementHeaders();
        return this.unsignUserAgreementWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新用户码实例</p>
     * 
     * @param request UpateUserCodeInstanceRequest
     * @param headers UpateUserCodeInstanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpateUserCodeInstanceResponse
     */
    public UpateUserCodeInstanceResponse upateUserCodeInstanceWithOptions(UpateUserCodeInstanceRequest request, UpateUserCodeInstanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpateUserCodeInstance"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/payCodes/userInstances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpateUserCodeInstanceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新用户码实例</p>
     * 
     * @param request UpateUserCodeInstanceRequest
     * @return UpateUserCodeInstanceResponse
     */
    public UpateUserCodeInstanceResponse upateUserCodeInstance(UpateUserCodeInstanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpateUserCodeInstanceHeaders headers = new UpateUserCodeInstanceHeaders();
        return this.upateUserCodeInstanceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用来给第三方企业提供发票验真结果更新的oapi</p>
     * 
     * @param request UpdateInvoiceVerifyStatusRequest
     * @param headers UpdateInvoiceVerifyStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceVerifyStatusResponse
     */
    public UpdateInvoiceVerifyStatusResponse updateInvoiceVerifyStatusWithOptions(UpdateInvoiceVerifyStatusRequest request, UpdateInvoiceVerifyStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.checkingResult)) {
            body.put("checkingResult", request.checkingResult);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.checkingStatus)) {
            body.put("checkingStatus", request.checkingStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceCode)) {
            body.put("invoiceCode", request.invoiceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceNo)) {
            body.put("invoiceNo", request.invoiceNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceStatus)) {
            body.put("invoiceStatus", request.invoiceStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceVerifyId)) {
            body.put("invoiceVerifyId", request.invoiceVerifyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msg)) {
            body.put("msg", request.msg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "UpdateInvoiceVerifyStatus"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/invoices/verifyStatus"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceVerifyStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用来给第三方企业提供发票验真结果更新的oapi</p>
     * 
     * @param request UpdateInvoiceVerifyStatusRequest
     * @return UpdateInvoiceVerifyStatusResponse
     */
    public UpdateInvoiceVerifyStatusResponse updateInvoiceVerifyStatus(UpdateInvoiceVerifyStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
        return this.updateInvoiceVerifyStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>上传发票</p>
     * 
     * @param request UploadInvoiceRequest
     * @param headers UploadInvoiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UploadInvoiceResponse
     */
    public UploadInvoiceResponse uploadInvoiceWithOptions(UploadInvoiceRequest request, UploadInvoiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoices)) {
            body.put("invoices", request.invoices);
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UploadInvoice"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/invoices/upload"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UploadInvoiceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>上传发票</p>
     * 
     * @param request UploadInvoiceRequest
     * @return UploadInvoiceResponse
     */
    public UploadInvoiceResponse uploadInvoice(UploadInvoiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UploadInvoiceHeaders headers = new UploadInvoiceHeaders();
        return this.uploadInvoiceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用户授权上传发票oapi</p>
     * 
     * @param request UploadInvoiceByAuthRequest
     * @param headers UploadInvoiceByAuthHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UploadInvoiceByAuthResponse
     */
    public UploadInvoiceByAuthResponse uploadInvoiceByAuthWithOptions(UploadInvoiceByAuthRequest request, UploadInvoiceByAuthHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoices)) {
            body.put("invoices", request.invoices);
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
            new TeaPair("action", "UploadInvoiceByAuth"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/invoices/authorizations/upload"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UploadInvoiceByAuthResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用户授权上传发票oapi</p>
     * 
     * @param request UploadInvoiceByAuthRequest
     * @return UploadInvoiceByAuthResponse
     */
    public UploadInvoiceByAuthResponse uploadInvoiceByAuth(UploadInvoiceByAuthRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UploadInvoiceByAuthHeaders headers = new UploadInvoiceByAuthHeaders();
        return this.uploadInvoiceByAuthWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过手机号上传发票</p>
     * 
     * @param request UploadInvoiceByMobileRequest
     * @param headers UploadInvoiceByMobileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UploadInvoiceByMobileResponse
     */
    public UploadInvoiceByMobileResponse uploadInvoiceByMobileWithOptions(UploadInvoiceByMobileRequest request, UploadInvoiceByMobileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.invoices)) {
            body.put("invoices", request.invoices);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobileStateCode)) {
            body.put("mobileStateCode", request.mobileStateCode);
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
            new TeaPair("action", "UploadInvoiceByMobile"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/invoices/mobiles/upload"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UploadInvoiceByMobileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过手机号上传发票</p>
     * 
     * @param request UploadInvoiceByMobileRequest
     * @return UploadInvoiceByMobileResponse
     */
    public UploadInvoiceByMobileResponse uploadInvoiceByMobile(UploadInvoiceByMobileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UploadInvoiceByMobileHeaders headers = new UploadInvoiceByMobileHeaders();
        return this.uploadInvoiceByMobileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>上传进件中的图片获得图片链接</p>
     * 
     * @param request UploadRegisterImageRequest
     * @param headers UploadRegisterImageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UploadRegisterImageResponse
     */
    public UploadRegisterImageResponse uploadRegisterImageWithOptions(UploadRegisterImageRequest request, UploadRegisterImageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.imageContent)) {
            body.put("imageContent", request.imageContent);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imageName)) {
            body.put("imageName", request.imageName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.imageType)) {
            body.put("imageType", request.imageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannel)) {
            body.put("payChannel", request.payChannel);
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
            new TeaPair("action", "UploadRegisterImage"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/institutions/images"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UploadRegisterImageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>上传进件中的图片获得图片链接</p>
     * 
     * @param request UploadRegisterImageRequest
     * @return UploadRegisterImageResponse
     */
    public UploadRegisterImageResponse uploadRegisterImage(UploadRegisterImageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UploadRegisterImageHeaders headers = new UploadRegisterImageHeaders();
        return this.uploadRegisterImageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用户协议签约</p>
     * 
     * @param request UserAgreementPageSignRequest
     * @param headers UserAgreementPageSignHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UserAgreementPageSignResponse
     */
    public UserAgreementPageSignResponse userAgreementPageSignWithOptions(UserAgreementPageSignRequest request, UserAgreementPageSignHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizScene)) {
            body.put("bizScene", request.bizScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instId)) {
            body.put("instId", request.instId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payChannel)) {
            body.put("payChannel", request.payChannel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.returnUrl)) {
            body.put("returnUrl", request.returnUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signScene)) {
            body.put("signScene", request.signScene);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subInstId)) {
            body.put("subInstId", request.subInstId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subMerchantName)) {
            body.put("subMerchantName", request.subMerchantName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subMerchantServiceDesc)) {
            body.put("subMerchantServiceDesc", request.subMerchantServiceDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subMerchantServiceName)) {
            body.put("subMerchantServiceName", request.subMerchantServiceName);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UserAgreementPageSign"),
            new TeaPair("version", "finance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/finance/userAgreements"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UserAgreementPageSignResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用户协议签约</p>
     * 
     * @param request UserAgreementPageSignRequest
     * @return UserAgreementPageSignResponse
     */
    public UserAgreementPageSignResponse userAgreementPageSign(UserAgreementPageSignRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UserAgreementPageSignHeaders headers = new UserAgreementPageSignHeaders();
        return this.userAgreementPageSignWithOptions(request, headers, runtime);
    }
}
