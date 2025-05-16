// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkbizfinance_2_0.models.*;

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
     * <p>新增智能财务的企业账户</p>
     * 
     * @param request AddFinanceEnterpriseAccountRequest
     * @param headers AddFinanceEnterpriseAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddFinanceEnterpriseAccountResponse
     */
    public AddFinanceEnterpriseAccountResponse addFinanceEnterpriseAccountWithOptions(AddFinanceEnterpriseAccountRequest request, AddFinanceEnterpriseAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountName)) {
            body.put("accountName", request.accountName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountType)) {
            body.put("accountType", request.accountType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankCardNo)) {
            body.put("bankCardNo", request.bankCardNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankCode)) {
            body.put("bankCode", request.bankCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankName)) {
            body.put("bankName", request.bankName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.city)) {
            body.put("city", request.city);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.officialName)) {
            body.put("officialName", request.officialName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.officialNumber)) {
            body.put("officialNumber", request.officialNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.province)) {
            body.put("province", request.province);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNature)) {
            body.put("taxNature", request.taxNature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNo)) {
            body.put("taxNo", request.taxNo);
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
            new TeaPair("action", "AddFinanceEnterpriseAccount"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/enterpriseAccounts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddFinanceEnterpriseAccountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增智能财务的企业账户</p>
     * 
     * @param request AddFinanceEnterpriseAccountRequest
     * @return AddFinanceEnterpriseAccountResponse
     */
    public AddFinanceEnterpriseAccountResponse addFinanceEnterpriseAccount(AddFinanceEnterpriseAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddFinanceEnterpriseAccountHeaders headers = new AddFinanceEnterpriseAccountHeaders();
        return this.addFinanceEnterpriseAccountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>银行接入层通用接口</p>
     * 
     * @param request BankGatewayInvokeRequest
     * @param headers BankGatewayInvokeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BankGatewayInvokeResponse
     */
    public BankGatewayInvokeResponse bankGatewayInvokeWithOptions(BankGatewayInvokeRequest request, BankGatewayInvokeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            body.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.inputData)) {
            body.put("inputData", request.inputData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.url)) {
            body.put("url", request.url);
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
            new TeaPair("action", "BankGatewayInvoke"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/bankGateways/invoke"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BankGatewayInvokeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>银行接入层通用接口</p>
     * 
     * @param request BankGatewayInvokeRequest
     * @return BankGatewayInvokeResponse
     */
    public BankGatewayInvokeResponse bankGatewayInvoke(BankGatewayInvokeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BankGatewayInvokeHeaders headers = new BankGatewayInvokeHeaders();
        return this.bankGatewayInvokeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除智能财务单据</p>
     * 
     * @param request BatchDeleteReceiptRequest
     * @param headers BatchDeleteReceiptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchDeleteReceiptResponse
     */
    public BatchDeleteReceiptResponse batchDeleteReceiptWithOptions(BatchDeleteReceiptRequest request, BatchDeleteReceiptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceIdList)) {
            body.put("instanceIdList", request.instanceIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "BatchDeleteReceipt"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/instances/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchDeleteReceiptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除智能财务单据</p>
     * 
     * @param request BatchDeleteReceiptRequest
     * @return BatchDeleteReceiptResponse
     */
    public BatchDeleteReceiptResponse batchDeleteReceipt(BatchDeleteReceiptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchDeleteReceiptHeaders headers = new BatchDeleteReceiptHeaders();
        return this.batchDeleteReceiptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询企业票池发票下载链接</p>
     * 
     * @param request BatchQueryOrgInvoiceUrlRequest
     * @param headers BatchQueryOrgInvoiceUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryOrgInvoiceUrlResponse
     */
    public BatchQueryOrgInvoiceUrlResponse batchQueryOrgInvoiceUrlWithOptions(BatchQueryOrgInvoiceUrlRequest request, BatchQueryOrgInvoiceUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceKeyVOList)) {
            body.put("invoiceKeyVOList", request.invoiceKeyVOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "BatchQueryOrgInvoiceUrl"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/invoices/urls/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryOrgInvoiceUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询企业票池发票下载链接</p>
     * 
     * @param request BatchQueryOrgInvoiceUrlRequest
     * @return BatchQueryOrgInvoiceUrlResponse
     */
    public BatchQueryOrgInvoiceUrlResponse batchQueryOrgInvoiceUrl(BatchQueryOrgInvoiceUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryOrgInvoiceUrlHeaders headers = new BatchQueryOrgInvoiceUrlHeaders();
        return this.batchQueryOrgInvoiceUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询支付回单文件</p>
     * 
     * @param request BatchQueryPaymentRecallFileRequest
     * @param headers BatchQueryPaymentRecallFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchQueryPaymentRecallFileResponse
     */
    public BatchQueryPaymentRecallFileResponse batchQueryPaymentRecallFileWithOptions(BatchQueryPaymentRecallFileRequest request, BatchQueryPaymentRecallFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.detailIdList)) {
            body.put("detailIdList", request.detailIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "BatchQueryPaymentRecallFile"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/recallFiles/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchQueryPaymentRecallFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询支付回单文件</p>
     * 
     * @param request BatchQueryPaymentRecallFileRequest
     * @return BatchQueryPaymentRecallFileResponse
     */
    public BatchQueryPaymentRecallFileResponse batchQueryPaymentRecallFile(BatchQueryPaymentRecallFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchQueryPaymentRecallFileHeaders headers = new BatchQueryPaymentRecallFileHeaders();
        return this.batchQueryPaymentRecallFileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量同步银行回单</p>
     * 
     * @param request BatchSyncBankReceiptRequest
     * @param headers BatchSyncBankReceiptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchSyncBankReceiptResponse
     */
    public BatchSyncBankReceiptResponse batchSyncBankReceiptWithOptions(BatchSyncBankReceiptRequest request, BatchSyncBankReceiptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "BatchSyncBankReceipt"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/receipts/batchSync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchSyncBankReceiptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量同步银行回单</p>
     * 
     * @param request BatchSyncBankReceiptRequest
     * @return BatchSyncBankReceiptResponse
     */
    public BatchSyncBankReceiptResponse batchSyncBankReceipt(BatchSyncBankReceiptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchSyncBankReceiptHeaders headers = new BatchSyncBankReceiptHeaders();
        return this.batchSyncBankReceiptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查验发票是否生成凭证</p>
     * 
     * @param request CheckVoucherStatusRequest
     * @param headers CheckVoucherStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckVoucherStatusResponse
     */
    public CheckVoucherStatusResponse checkVoucherStatusWithOptions(CheckVoucherStatusRequest request, CheckVoucherStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.financeType)) {
            body.put("financeType", request.financeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceCode)) {
            body.put("invoiceCode", request.invoiceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceNo)) {
            body.put("invoiceNo", request.invoiceNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNo)) {
            body.put("taxNo", request.taxNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.verifyStatus)) {
            body.put("verifyStatus", request.verifyStatus);
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
            new TeaPair("action", "CheckVoucherStatus"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/invoices/checkVoucherStatus/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckVoucherStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查验发票是否生成凭证</p>
     * 
     * @param request CheckVoucherStatusRequest
     * @return CheckVoucherStatusResponse
     */
    public CheckVoucherStatusResponse checkVoucherStatus(CheckVoucherStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckVoucherStatusHeaders headers = new CheckVoucherStatusHeaders();
        return this.checkVoucherStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取唤起智能财务收银台的地址</p>
     * 
     * @param request ConfirmPaymentOrderRequest
     * @param headers ConfirmPaymentOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConfirmPaymentOrderResponse
     */
    public ConfirmPaymentOrderResponse confirmPaymentOrderWithOptions(ConfirmPaymentOrderRequest request, ConfirmPaymentOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outBizNoList)) {
            body.put("outBizNoList", request.outBizNoList);
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
            new TeaPair("action", "ConfirmPaymentOrder"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/confirm"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConfirmPaymentOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取唤起智能财务收银台的地址</p>
     * 
     * @param request ConfirmPaymentOrderRequest
     * @return ConfirmPaymentOrderResponse
     */
    public ConfirmPaymentOrderResponse confirmPaymentOrder(ConfirmPaymentOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConfirmPaymentOrderHeaders headers = new ConfirmPaymentOrderHeaders();
        return this.confirmPaymentOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建收款订单</p>
     * 
     * @param request CreateCollectionOrderRequest
     * @param headers CreateCollectionOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCollectionOrderResponse
     */
    public CreateCollectionOrderResponse createCollectionOrderWithOptions(CreateCollectionOrderRequest request, CreateCollectionOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.amount)) {
            query.put("amount", request.amount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.collectionInfoId)) {
            query.put("collectionInfoId", request.collectionInfoId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            query.put("remark", request.remark);
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
            new TeaPair("action", "CreateCollectionOrder"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/me/collections/orders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCollectionOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建收款订单</p>
     * 
     * @param request CreateCollectionOrderRequest
     * @return CreateCollectionOrderResponse
     */
    public CreateCollectionOrderResponse createCollectionOrder(CreateCollectionOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCollectionOrderHeaders headers = new CreateCollectionOrderHeaders();
        return this.createCollectionOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建智能财务待支付订单</p>
     * 
     * @param request CreatePaymentOrderRequest
     * @param headers CreatePaymentOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreatePaymentOrderResponse
     */
    public CreatePaymentOrderResponse createPaymentOrderWithOptions(CreatePaymentOrderRequest request, CreatePaymentOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.amount)) {
            body.put("amount", request.amount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.expireTime)) {
            body.put("expireTime", request.expireTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outBizNo)) {
            body.put("outBizNo", request.outBizNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payeeAccountDTO)) {
            body.put("payeeAccountDTO", request.payeeAccountDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payerAccountDTO)) {
            body.put("payerAccountDTO", request.payerAccountDTO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.paymentOrderTitle)) {
            body.put("paymentOrderTitle", request.paymentOrderTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.usage)) {
            body.put("usage", request.usage);
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
            new TeaPair("action", "CreatePaymentOrder"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/orders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreatePaymentOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建智能财务待支付订单</p>
     * 
     * @param request CreatePaymentOrderRequest
     * @return CreatePaymentOrderResponse
     */
    public CreatePaymentOrderResponse createPaymentOrder(CreatePaymentOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreatePaymentOrderHeaders headers = new CreatePaymentOrderHeaders();
        return this.createPaymentOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取费用类别</p>
     * 
     * @param request GetCategoryRequest
     * @param headers GetCategoryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCategoryResponse
     */
    public GetCategoryResponse getCategoryWithOptions(GetCategoryRequest request, GetCategoryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
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
            new TeaPair("action", "GetCategory"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/categories"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCategoryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取费用类别</p>
     * 
     * @param request GetCategoryRequest
     * @return GetCategoryResponse
     */
    public GetCategoryResponse getCategory(GetCategoryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCategoryHeaders headers = new GetCategoryHeaders();
        return this.getCategoryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业内自定义辅助档案信息</p>
     * 
     * @param request GetDefineRequest
     * @param headers GetDefineHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDefineResponse
     */
    public GetDefineResponse getDefineWithOptions(GetDefineRequest request, GetDefineHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
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
            new TeaPair("action", "GetDefine"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/customInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDefineResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业内自定义辅助档案信息</p>
     * 
     * @param request GetDefineRequest
     * @return GetDefineResponse
     */
    public GetDefineResponse getDefine(GetDefineRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDefineHeaders headers = new GetDefineHeaders();
        return this.getDefineWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业内自定义辅助档案数据信息</p>
     * 
     * @param request GetDefineDataRequest
     * @param headers GetDefineDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDefineDataResponse
     */
    public GetDefineDataResponse getDefineDataWithOptions(GetDefineDataRequest request, GetDefineDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
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
            new TeaPair("action", "GetDefineData"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/customDatas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDefineDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询企业内自定义辅助档案数据信息</p>
     * 
     * @param request GetDefineDataRequest
     * @return GetDefineDataResponse
     */
    public GetDefineDataResponse getDefineData(GetDefineDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDefineDataHeaders headers = new GetDefineDataHeaders();
        return this.getDefineDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业账户</p>
     * 
     * @param request GetFinanceAccountRequest
     * @param headers GetFinanceAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFinanceAccountResponse
     */
    public GetFinanceAccountResponse getFinanceAccountWithOptions(GetFinanceAccountRequest request, GetFinanceAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountCode)) {
            query.put("accountCode", request.accountCode);
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
            new TeaPair("action", "GetFinanceAccount"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/financeAccounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFinanceAccountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取企业账户</p>
     * 
     * @param request GetFinanceAccountRequest
     * @return GetFinanceAccountResponse
     */
    public GetFinanceAccountResponse getFinanceAccount(GetFinanceAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFinanceAccountHeaders headers = new GetFinanceAccountHeaders();
        return this.getFinanceAccountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取单条项目</p>
     * 
     * @param request GetProjectRequest
     * @param headers GetProjectHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProjectResponse
     */
    public GetProjectResponse getProjectWithOptions(GetProjectRequest request, GetProjectHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
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
            new TeaPair("action", "GetProject"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/projects"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProjectResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取单条项目</p>
     * 
     * @param request GetProjectRequest
     * @return GetProjectResponse
     */
    public GetProjectResponse getProject(GetProjectRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProjectHeaders headers = new GetProjectHeaders();
        return this.getProjectWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务单据详情</p>
     * 
     * @param request GetReceiptRequest
     * @param headers GetReceiptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetReceiptResponse
     */
    public GetReceiptResponse getReceiptWithOptions(GetReceiptRequest request, GetReceiptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modelId)) {
            query.put("modelId", request.modelId);
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
            new TeaPair("action", "GetReceipt"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/receipts/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetReceiptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务单据详情</p>
     * 
     * @param request GetReceiptRequest
     * @return GetReceiptResponse
     */
    public GetReceiptResponse getReceipt(GetReceiptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetReceiptHeaders headers = new GetReceiptHeaders();
        return this.getReceiptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务应用内维护的供应商信息</p>
     * 
     * @param request GetSupplierRequest
     * @param headers GetSupplierHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSupplierResponse
     */
    public GetSupplierResponse getSupplierWithOptions(GetSupplierRequest request, GetSupplierHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
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
            new TeaPair("action", "GetSupplier"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/suppliers/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSupplierResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务应用内维护的供应商信息</p>
     * 
     * @param request GetSupplierRequest
     * @return GetSupplierResponse
     */
    public GetSupplierResponse getSupplier(GetSupplierRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSupplierHeaders headers = new GetSupplierHeaders();
        return this.getSupplierWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>订单开票</p>
     * 
     * @param request IssueInvoiceWithOrderRequest
     * @param headers IssueInvoiceWithOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IssueInvoiceWithOrderResponse
     */
    public IssueInvoiceWithOrderResponse issueInvoiceWithOrderWithOptions(IssueInvoiceWithOrderRequest request, IssueInvoiceWithOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.financeAppKey)) {
            body.put("financeAppKey", request.financeAppKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
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
            new TeaPair("action", "IssueInvoiceWithOrder"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/issueInvoices/order"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IssueInvoiceWithOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>订单开票</p>
     * 
     * @param request IssueInvoiceWithOrderRequest
     * @return IssueInvoiceWithOrderResponse
     */
    public IssueInvoiceWithOrderResponse issueInvoiceWithOrder(IssueInvoiceWithOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IssueInvoiceWithOrderHeaders headers = new IssueInvoiceWithOrderHeaders();
        return this.issueInvoiceWithOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据不同的bizType查询不同的数据</p>
     * 
     * @param request LinkCommonInvokeRequest
     * @param headers LinkCommonInvokeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return LinkCommonInvokeResponse
     */
    public LinkCommonInvokeResponse linkCommonInvokeWithOptions(LinkCommonInvokeRequest request, LinkCommonInvokeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invokeId)) {
            body.put("invokeId", request.invokeId);
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
            new TeaPair("action", "LinkCommonInvoke"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/link/bizTypes/invoke"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new LinkCommonInvokeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据不同的bizType查询不同的数据</p>
     * 
     * @param request LinkCommonInvokeRequest
     * @return LinkCommonInvokeResponse
     */
    public LinkCommonInvokeResponse linkCommonInvoke(LinkCommonInvokeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        LinkCommonInvokeHeaders headers = new LinkCommonInvokeHeaders();
        return this.linkCommonInvokeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>订单开票</p>
     * 
     * @param request OrderBillingRequest
     * @param headers OrderBillingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return OrderBillingResponse
     */
    public OrderBillingResponse orderBillingWithOptions(OrderBillingRequest request, OrderBillingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.additionInfos)) {
            body.put("additionInfos", request.additionInfos);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applyPerson)) {
            body.put("applyPerson", request.applyPerson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceRemark)) {
            body.put("invoiceRemark", request.invoiceRemark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceType)) {
            body.put("invoiceType", request.invoiceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isNaturalPerson)) {
            body.put("isNaturalPerson", request.isNaturalPerson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payee)) {
            body.put("payee", request.payee);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.phone)) {
            body.put("phone", request.phone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.products)) {
            body.put("products", request.products);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserAddress)) {
            body.put("purchaserAddress", request.purchaserAddress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserBankAccount)) {
            body.put("purchaserBankAccount", request.purchaserBankAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserBankName)) {
            body.put("purchaserBankName", request.purchaserBankName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserName)) {
            body.put("purchaserName", request.purchaserName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserTaxNo)) {
            body.put("purchaserTaxNo", request.purchaserTaxNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserTel)) {
            body.put("purchaserTel", request.purchaserTel);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reviewer)) {
            body.put("reviewer", request.reviewer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signature)) {
            body.put("signature", request.signature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxSign)) {
            body.put("taxSign", request.taxSign);
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
            new TeaPair("action", "OrderBilling"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/billings/order"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new OrderBillingResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>订单开票</p>
     * 
     * @param request OrderBillingRequest
     * @return OrderBillingResponse
     */
    public OrderBillingResponse orderBilling(OrderBillingRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        OrderBillingHeaders headers = new OrderBillingHeaders();
        return this.orderBillingWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询账户的银行交易流水</p>
     * 
     * @param request QueryAccountTradeByPageRequest
     * @param headers QueryAccountTradeByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAccountTradeByPageResponse
     */
    public QueryAccountTradeByPageResponse queryAccountTradeByPageWithOptions(QueryAccountTradeByPageRequest request, QueryAccountTradeByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountId)) {
            body.put("accountId", request.accountId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endDate)) {
            body.put("endDate", request.endDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.filter)) {
            body.put("filter", request.filter);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startDate)) {
            body.put("startDate", request.startDate);
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
            new TeaPair("action", "QueryAccountTradeByPage"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/trades/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAccountTradeByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询账户的银行交易流水</p>
     * 
     * @param request QueryAccountTradeByPageRequest
     * @return QueryAccountTradeByPageResponse
     */
    public QueryAccountTradeByPageResponse queryAccountTradeByPage(QueryAccountTradeByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAccountTradeByPageHeaders headers = new QueryAccountTradeByPageHeaders();
        return this.queryAccountTradeByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取费用类别</p>
     * 
     * @param request QueryCategoryByPageRequest
     * @param headers QueryCategoryByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCategoryByPageResponse
     */
    public QueryCategoryByPageResponse queryCategoryByPageWithOptions(QueryCategoryByPageRequest request, QueryCategoryByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            query.put("type", request.type);
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
            new TeaPair("action", "QueryCategoryByPage"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/categories/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCategoryByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取费用类别</p>
     * 
     * @param request QueryCategoryByPageRequest
     * @return QueryCategoryByPageResponse
     */
    public QueryCategoryByPageResponse queryCategoryByPage(QueryCategoryByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCategoryByPageHeaders headers = new QueryCategoryByPageHeaders();
        return this.queryCategoryByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询进件信息</p>
     * 
     * @param request QueryCollectionInfoListRequest
     * @param headers QueryCollectionInfoListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCollectionInfoListResponse
     */
    public QueryCollectionInfoListResponse queryCollectionInfoListWithOptions(QueryCollectionInfoListRequest request, QueryCollectionInfoListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
            new TeaPair("action", "QueryCollectionInfoList"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/me/collections/accounts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCollectionInfoListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询进件信息</p>
     * 
     * @param request QueryCollectionInfoListRequest
     * @return QueryCollectionInfoListResponse
     */
    public QueryCollectionInfoListResponse queryCollectionInfoList(QueryCollectionInfoListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCollectionInfoListHeaders headers = new QueryCollectionInfoListHeaders();
        return this.queryCollectionInfoListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询收款订单</p>
     * 
     * @param request QueryCollectionOrderRequest
     * @param headers QueryCollectionOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCollectionOrderResponse
     */
    public QueryCollectionOrderResponse queryCollectionOrderWithOptions(QueryCollectionOrderRequest request, QueryCollectionOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
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
            new TeaPair("action", "QueryCollectionOrder"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/me/collections/orders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCollectionOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询收款订单</p>
     * 
     * @param request QueryCollectionOrderRequest
     * @return QueryCollectionOrderResponse
     */
    public QueryCollectionOrderResponse queryCollectionOrder(QueryCollectionOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCollectionOrderHeaders headers = new QueryCollectionOrderHeaders();
        return this.queryCollectionOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页批量获取智能财务应用内维护的客户信息</p>
     * 
     * @param request QueryCustomerByPageRequest
     * @param headers QueryCustomerByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCustomerByPageResponse
     */
    public QueryCustomerByPageResponse queryCustomerByPageWithOptions(QueryCustomerByPageRequest request, QueryCustomerByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryCustomerByPage"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/customers/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCustomerByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页批量获取智能财务应用内维护的客户信息</p>
     * 
     * @param request QueryCustomerByPageRequest
     * @return QueryCustomerByPageResponse
     */
    public QueryCustomerByPageResponse queryCustomerByPage(QueryCustomerByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomerByPageHeaders headers = new QueryCustomerByPageHeaders();
        return this.queryCustomerByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取企业账户</p>
     * 
     * @param request QueryEnterpriseAccountByPageRequest
     * @param headers QueryEnterpriseAccountByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryEnterpriseAccountByPageResponse
     */
    public QueryEnterpriseAccountByPageResponse queryEnterpriseAccountByPageWithOptions(QueryEnterpriseAccountByPageRequest request, QueryEnterpriseAccountByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryEnterpriseAccountByPage"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/financeAccounts/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryEnterpriseAccountByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取企业账户</p>
     * 
     * @param request QueryEnterpriseAccountByPageRequest
     * @return QueryEnterpriseAccountByPageResponse
     */
    public QueryEnterpriseAccountByPageResponse queryEnterpriseAccountByPage(QueryEnterpriseAccountByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryEnterpriseAccountByPageHeaders headers = new QueryEnterpriseAccountByPageHeaders();
        return this.queryEnterpriseAccountByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务企业账户签约地址</p>
     * 
     * @param request QueryEnterpriseAccountSignUrlRequest
     * @param headers QueryEnterpriseAccountSignUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryEnterpriseAccountSignUrlResponse
     */
    public QueryEnterpriseAccountSignUrlResponse queryEnterpriseAccountSignUrlWithOptions(QueryEnterpriseAccountSignUrlRequest request, QueryEnterpriseAccountSignUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountCode)) {
            query.put("accountCode", request.accountCode);
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
            new TeaPair("action", "QueryEnterpriseAccountSignUrl"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/enterpriseAccounts/sign"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryEnterpriseAccountSignUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务企业账户签约地址</p>
     * 
     * @param request QueryEnterpriseAccountSignUrlRequest
     * @return QueryEnterpriseAccountSignUrlResponse
     */
    public QueryEnterpriseAccountSignUrlResponse queryEnterpriseAccountSignUrl(QueryEnterpriseAccountSignUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryEnterpriseAccountSignUrlHeaders headers = new QueryEnterpriseAccountSignUrlHeaders();
        return this.queryEnterpriseAccountSignUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付订单详情</p>
     * 
     * @param request QueryInstancePaymentOrderDetailRequest
     * @param headers QueryInstancePaymentOrderDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryInstancePaymentOrderDetailResponse
     */
    public QueryInstancePaymentOrderDetailResponse queryInstancePaymentOrderDetailWithOptions(String instanceId, QueryInstancePaymentOrderDetailRequest request, QueryInstancePaymentOrderDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            query.put("orderNo", request.orderNo);
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
            new TeaPair("action", "QueryInstancePaymentOrderDetail"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/instances/" + instanceId + "/paymentOrders/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryInstancePaymentOrderDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付订单详情</p>
     * 
     * @param request QueryInstancePaymentOrderDetailRequest
     * @return QueryInstancePaymentOrderDetailResponse
     */
    public QueryInstancePaymentOrderDetailResponse queryInstancePaymentOrderDetail(String instanceId, QueryInstancePaymentOrderDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryInstancePaymentOrderDetailHeaders headers = new QueryInstancePaymentOrderDetailHeaders();
        return this.queryInstancePaymentOrderDetailWithOptions(instanceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发票数据迁移，根据数据key查询具体数据data</p>
     * 
     * @param tmpReq QueryInvoiceTransferDataRequest
     * @param headers QueryInvoiceTransferDataHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryInvoiceTransferDataResponse
     */
    public QueryInvoiceTransferDataResponse queryInvoiceTransferDataWithOptions(QueryInvoiceTransferDataRequest tmpReq, QueryInvoiceTransferDataHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryInvoiceTransferDataShrinkRequest request = new QueryInvoiceTransferDataShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "QueryInvoiceTransferData"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/invoices/transferredDatas/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryInvoiceTransferDataResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发票数据迁移，根据数据key查询具体数据data</p>
     * 
     * @param request QueryInvoiceTransferDataRequest
     * @return QueryInvoiceTransferDataResponse
     */
    public QueryInvoiceTransferDataResponse queryInvoiceTransferData(QueryInvoiceTransferDataRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryInvoiceTransferDataHeaders headers = new QueryInvoiceTransferDataHeaders();
        return this.queryInvoiceTransferDataWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付的权益使用信息</p>
     * 
     * @param request QueryPaymentBenefitRequest
     * @param headers QueryPaymentBenefitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPaymentBenefitResponse
     */
    public QueryPaymentBenefitResponse queryPaymentBenefitWithOptions(QueryPaymentBenefitRequest request, QueryPaymentBenefitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryPaymentBenefit"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/benefits"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPaymentBenefitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付的权益使用信息</p>
     * 
     * @param request QueryPaymentBenefitRequest
     * @return QueryPaymentBenefitResponse
     */
    public QueryPaymentBenefitResponse queryPaymentBenefit(QueryPaymentBenefitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPaymentBenefitHeaders headers = new QueryPaymentBenefitHeaders();
        return this.queryPaymentBenefitWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询智能财务支付订单信息</p>
     * 
     * @param tmpReq QueryPaymentOrderDetailRequest
     * @param headers QueryPaymentOrderDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPaymentOrderDetailResponse
     */
    public QueryPaymentOrderDetailResponse queryPaymentOrderDetailWithOptions(QueryPaymentOrderDetailRequest tmpReq, QueryPaymentOrderDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        QueryPaymentOrderDetailShrinkRequest request = new QueryPaymentOrderDetailShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.outBizNoList)) {
            request.outBizNoListShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.outBizNoList, "outBizNoList", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outBizNoListShrink)) {
            query.put("outBizNoList", request.outBizNoListShrink);
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
            new TeaPair("action", "QueryPaymentOrderDetail"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/orders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPaymentOrderDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询智能财务支付订单信息</p>
     * 
     * @param request QueryPaymentOrderDetailRequest
     * @return QueryPaymentOrderDetailResponse
     */
    public QueryPaymentOrderDetailResponse queryPaymentOrderDetail(QueryPaymentOrderDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPaymentOrderDetailHeaders headers = new QueryPaymentOrderDetailHeaders();
        return this.queryPaymentOrderDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付回单信息</p>
     * 
     * @param request QueryPaymentRecallFileRequest
     * @param headers QueryPaymentRecallFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPaymentRecallFileResponse
     */
    public QueryPaymentRecallFileResponse queryPaymentRecallFileWithOptions(String instanceId, QueryPaymentRecallFileRequest request, QueryPaymentRecallFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryPaymentRecallFile"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/recallFiles/" + instanceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPaymentRecallFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付回单信息</p>
     * 
     * @param request QueryPaymentRecallFileRequest
     * @return QueryPaymentRecallFileResponse
     */
    public QueryPaymentRecallFileResponse queryPaymentRecallFile(String instanceId, QueryPaymentRecallFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPaymentRecallFileHeaders headers = new QueryPaymentRecallFileHeaders();
        return this.queryPaymentRecallFileWithOptions(instanceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付订单的状态</p>
     * 
     * @param request QueryPaymentStatusRequest
     * @param headers QueryPaymentStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPaymentStatusResponse
     */
    public QueryPaymentStatusResponse queryPaymentStatusWithOptions(QueryPaymentStatusRequest request, QueryPaymentStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            query.put("orderNo", request.orderNo);
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
            new TeaPair("action", "QueryPaymentStatus"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/payments/statuses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPaymentStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询支付订单的状态</p>
     * 
     * @param request QueryPaymentStatusRequest
     * @return QueryPaymentStatusResponse
     */
    public QueryPaymentStatusResponse queryPaymentStatus(QueryPaymentStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPaymentStatusHeaders headers = new QueryPaymentStatusHeaders();
        return this.queryPaymentStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取商品信息</p>
     * 
     * @param request QueryProductByPageRequest
     * @param headers QueryProductByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryProductByPageResponse
     */
    public QueryProductByPageResponse queryProductByPageWithOptions(QueryProductByPageRequest request, QueryProductByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryProductByPage"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/products/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryProductByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取商品信息</p>
     * 
     * @param request QueryProductByPageRequest
     * @return QueryProductByPageResponse
     */
    public QueryProductByPageResponse queryProductByPage(QueryProductByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryProductByPageHeaders headers = new QueryProductByPageHeaders();
        return this.queryProductByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取项目信息</p>
     * 
     * @param request QueryProjectByPageRequest
     * @param headers QueryProjectByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryProjectByPageResponse
     */
    public QueryProjectByPageResponse queryProjectByPageWithOptions(QueryProjectByPageRequest request, QueryProjectByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QueryProjectByPage"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/projects/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryProjectByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量获取项目信息</p>
     * 
     * @param request QueryProjectByPageRequest
     * @return QueryProjectByPageResponse
     */
    public QueryProjectByPageResponse queryProjectByPage(QueryProjectByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryProjectByPageHeaders headers = new QueryProjectByPageHeaders();
        return this.queryProjectByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询智能财务单据主数据信息</p>
     * 
     * @param request QueryReceiptForInvoiceRequest
     * @param headers QueryReceiptForInvoiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryReceiptForInvoiceResponse
     */
    public QueryReceiptForInvoiceResponse queryReceiptForInvoiceWithOptions(QueryReceiptForInvoiceRequest request, QueryReceiptForInvoiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountantBookId)) {
            body.put("accountantBookId", request.accountantBookId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applyStatusList)) {
            body.put("applyStatusList", request.applyStatusList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizStatusList)) {
            body.put("bizStatusList", request.bizStatusList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiptStatusList)) {
            body.put("receiptStatusList", request.receiptStatusList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.searchParams)) {
            body.put("searchParams", request.searchParams);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
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
            new TeaPair("action", "QueryReceiptForInvoice"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/invoices/receipts/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryReceiptForInvoiceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询智能财务单据主数据信息</p>
     * 
     * @param request QueryReceiptForInvoiceRequest
     * @return QueryReceiptForInvoiceResponse
     */
    public QueryReceiptForInvoiceResponse queryReceiptForInvoice(QueryReceiptForInvoiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryReceiptForInvoiceHeaders headers = new QueryReceiptForInvoiceHeaders();
        return this.queryReceiptForInvoiceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页批量获取智能财务应用内维护的供应商信息</p>
     * 
     * @param request QuerySupplierByPageRequest
     * @param headers QuerySupplierByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QuerySupplierByPageResponse
     */
    public QuerySupplierByPageResponse querySupplierByPageWithOptions(QuerySupplierByPageRequest request, QuerySupplierByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "QuerySupplierByPage"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/suppliers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QuerySupplierByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页批量获取智能财务应用内维护的供应商信息</p>
     * 
     * @param request QuerySupplierByPageRequest
     * @return QuerySupplierByPageResponse
     */
    public QuerySupplierByPageResponse querySupplierByPage(QuerySupplierByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QuerySupplierByPageHeaders headers = new QuerySupplierByPageHeaders();
        return this.querySupplierByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织是否命中走新发票应用</p>
     * 
     * @param headers QueryUseNewInvoiceAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUseNewInvoiceAppResponse
     */
    public QueryUseNewInvoiceAppResponse queryUseNewInvoiceAppWithOptions(QueryUseNewInvoiceAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUseNewInvoiceApp"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/invoice/appGray"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUseNewInvoiceAppResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织是否命中走新发票应用</p>
     * @return QueryUseNewInvoiceAppResponse
     */
    public QueryUseNewInvoiceAppResponse queryUseNewInvoiceApp() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUseNewInvoiceAppHeaders headers = new QueryUseNewInvoiceAppHeaders();
        return this.queryUseNewInvoiceAppWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户角色成员，支持分页，可获取某个企业主体下的角色成员</p>
     * 
     * @param request QueryUserRoleListRequest
     * @param headers QueryUserRoleListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserRoleListResponse
     */
    public QueryUserRoleListResponse queryUserRoleListWithOptions(QueryUserRoleListRequest request, QueryUserRoleListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            query.put("companyCode", request.companyCode);
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
            new TeaPair("action", "QueryUserRoleList"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/users/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserRoleListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户角色成员，支持分页，可获取某个企业主体下的角色成员</p>
     * 
     * @param request QueryUserRoleListRequest
     * @return QueryUserRoleListResponse
     */
    public QueryUserRoleListResponse queryUserRoleList(QueryUserRoleListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserRoleListHeaders headers = new QueryUserRoleListHeaders();
        return this.queryUserRoleListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>签约企业账户</p>
     * 
     * @param request SignEnterpriseAccountRequest
     * @param headers SignEnterpriseAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SignEnterpriseAccountResponse
     */
    public SignEnterpriseAccountResponse signEnterpriseAccountWithOptions(SignEnterpriseAccountRequest request, SignEnterpriseAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountCode)) {
            query.put("accountCode", request.accountCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankCardNo)) {
            query.put("bankCardNo", request.bankCardNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankOpenId)) {
            query.put("bankOpenId", request.bankOpenId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.channelType)) {
            query.put("channelType", request.channelType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.feeItemCode)) {
            query.put("feeItemCode", request.feeItemCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.issueNo)) {
            query.put("issueNo", request.issueNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.signOperateType)) {
            query.put("signOperateType", request.signOperateType);
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
            new TeaPair("action", "SignEnterpriseAccount"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/enterpriseAccounts/sign"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SignEnterpriseAccountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>签约企业账户</p>
     * 
     * @param request SignEnterpriseAccountRequest
     * @return SignEnterpriseAccountResponse
     */
    public SignEnterpriseAccountResponse signEnterpriseAccount(SignEnterpriseAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SignEnterpriseAccountHeaders headers = new SignEnterpriseAccountHeaders();
        return this.signEnterpriseAccountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发送银企支付回单文件信息</p>
     * 
     * @param request SyncReceiptRecallRequest
     * @param headers SyncReceiptRecallHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SyncReceiptRecallResponse
     */
    public SyncReceiptRecallResponse syncReceiptRecallWithOptions(SyncReceiptRecallRequest request, SyncReceiptRecallHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.fileDownloadUrl)) {
            query.put("fileDownloadUrl", request.fileDownloadUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            query.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            query.put("orderNo", request.orderNo);
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
            new TeaPair("action", "SyncReceiptRecall"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/receipts/syncRecall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncReceiptRecallResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发送银企支付回单文件信息</p>
     * 
     * @param request SyncReceiptRecallRequest
     * @return SyncReceiptRecallResponse
     */
    public SyncReceiptRecallResponse syncReceiptRecall(SyncReceiptRecallRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncReceiptRecallHeaders headers = new SyncReceiptRecallHeaders();
        return this.syncReceiptRecallWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务档案的状态</p>
     * 
     * @param request UpdateAuxiliaryStatusRequest
     * @param headers UpdateAuxiliaryStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateAuxiliaryStatusResponse
     */
    public UpdateAuxiliaryStatusResponse updateAuxiliaryStatusWithOptions(UpdateAuxiliaryStatusRequest request, UpdateAuxiliaryStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.auxiliaryId)) {
            query.put("auxiliaryId", request.auxiliaryId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.auxiliaryType)) {
            query.put("auxiliaryType", request.auxiliaryType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateType)) {
            query.put("operateType", request.operateType);
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
            new TeaPair("action", "UpdateAuxiliaryStatus"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/auxiliaries/status"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateAuxiliaryStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务档案的状态</p>
     * 
     * @param request UpdateAuxiliaryStatusRequest
     * @return UpdateAuxiliaryStatusResponse
     */
    public UpdateAuxiliaryStatusResponse updateAuxiliaryStatus(UpdateAuxiliaryStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateAuxiliaryStatusHeaders headers = new UpdateAuxiliaryStatusHeaders();
        return this.updateAuxiliaryStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务的企业账户</p>
     * 
     * @param request UpdateFinanceEnterpriseAccountRequest
     * @param headers UpdateFinanceEnterpriseAccountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateFinanceEnterpriseAccountResponse
     */
    public UpdateFinanceEnterpriseAccountResponse updateFinanceEnterpriseAccountWithOptions(UpdateFinanceEnterpriseAccountRequest request, UpdateFinanceEnterpriseAccountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountCode)) {
            body.put("accountCode", request.accountCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountName)) {
            body.put("accountName", request.accountName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.accountType)) {
            body.put("accountType", request.accountType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankCardNo)) {
            body.put("bankCardNo", request.bankCardNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankCode)) {
            body.put("bankCode", request.bankCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bankName)) {
            body.put("bankName", request.bankName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.city)) {
            body.put("city", request.city);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.officialName)) {
            body.put("officialName", request.officialName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.officialNumber)) {
            body.put("officialNumber", request.officialNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.province)) {
            body.put("province", request.province);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNature)) {
            body.put("taxNature", request.taxNature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNo)) {
            body.put("taxNo", request.taxNo);
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
            new TeaPair("action", "UpdateFinanceEnterpriseAccount"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/enterpriseAccounts"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateFinanceEnterpriseAccountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务的企业账户</p>
     * 
     * @param request UpdateFinanceEnterpriseAccountRequest
     * @return UpdateFinanceEnterpriseAccountResponse
     */
    public UpdateFinanceEnterpriseAccountResponse updateFinanceEnterpriseAccount(UpdateFinanceEnterpriseAccountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateFinanceEnterpriseAccountHeaders headers = new UpdateFinanceEnterpriseAccountHeaders();
        return this.updateFinanceEnterpriseAccountWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新单据的支付状态</p>
     * 
     * @param tmpReq UpdateInstanceOrderInfoRequest
     * @param headers UpdateInstanceOrderInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInstanceOrderInfoResponse
     */
    public UpdateInstanceOrderInfoResponse updateInstanceOrderInfoWithOptions(String instanceId, UpdateInstanceOrderInfoRequest tmpReq, UpdateInstanceOrderInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        UpdateInstanceOrderInfoShrinkRequest request = new UpdateInstanceOrderInfoShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.payerBank)) {
            request.payerBankShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.payerBank, "payerBank", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.failReason)) {
            query.put("failReason", request.failReason);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            query.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outOrderNo)) {
            query.put("outOrderNo", request.outOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.payerBankShrink)) {
            query.put("payerBank", request.payerBankShrink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.paymentTime)) {
            query.put("paymentTime", request.paymentTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
            new TeaPair("action", "UpdateInstanceOrderInfo"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/instances/" + instanceId + "/paymentOrders/states"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInstanceOrderInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新单据的支付状态</p>
     * 
     * @param request UpdateInstanceOrderInfoRequest
     * @return UpdateInstanceOrderInfoResponse
     */
    public UpdateInstanceOrderInfoResponse updateInstanceOrderInfo(String instanceId, UpdateInstanceOrderInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInstanceOrderInfoHeaders headers = new UpdateInstanceOrderInfoHeaders();
        return this.updateInstanceOrderInfoWithOptions(instanceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发票数据迁移，新发票应用上报已成功搬移数据</p>
     * 
     * @param headers UpdateInvoiceDataTransferDoneHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceDataTransferDoneResponse
     */
    public UpdateInvoiceDataTransferDoneResponse updateInvoiceDataTransferDoneWithOptions(UpdateInvoiceDataTransferDoneHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "UpdateInvoiceDataTransferDone"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/invoices/transferredDatas/statuses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceDataTransferDoneResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发票数据迁移，新发票应用上报已成功搬移数据</p>
     * @return UpdateInvoiceDataTransferDoneResponse
     */
    public UpdateInvoiceDataTransferDoneResponse updateInvoiceDataTransferDone() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceDataTransferDoneHeaders headers = new UpdateInvoiceDataTransferDoneHeaders();
        return this.updateInvoiceDataTransferDoneWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用于更新智能财务企业票池内对应发票的下载链接</p>
     * 
     * @param tmpReq UpdateInvoiceUrlRequest
     * @param headers UpdateInvoiceUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceUrlResponse
     */
    public UpdateInvoiceUrlResponse updateInvoiceUrlWithOptions(UpdateInvoiceUrlRequest tmpReq, UpdateInvoiceUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        UpdateInvoiceUrlShrinkRequest request = new UpdateInvoiceUrlShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "UpdateInvoiceUrl"),
            new TeaPair("version", "bizfinance_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/bizfinance/invoices/urls"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用于更新智能财务企业票池内对应发票的下载链接</p>
     * 
     * @param request UpdateInvoiceUrlRequest
     * @return UpdateInvoiceUrlResponse
     */
    public UpdateInvoiceUrlResponse updateInvoiceUrl(UpdateInvoiceUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceUrlHeaders headers = new UpdateInvoiceUrlHeaders();
        return this.updateInvoiceUrlWithOptions(request, headers, runtime);
    }
}
