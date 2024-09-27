// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkbizfinance_1_0.models.*;

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
     * <p>追加角色权限点</p>
     * 
     * @param tmpReq AppendRolePermissionRequest
     * @param headers AppendRolePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AppendRolePermissionResponse
     */
    public AppendRolePermissionResponse appendRolePermissionWithOptions(AppendRolePermissionRequest tmpReq, AppendRolePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        AppendRolePermissionShrinkRequest request = new AppendRolePermissionShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.rolePermissionItemList)) {
            request.rolePermissionItemListShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.rolePermissionItemList, "rolePermissionItemList", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.rolePermissionItemListShrink)) {
            query.put("rolePermissionItemList", request.rolePermissionItemListShrink);
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
            new TeaPair("action", "AppendRolePermission"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/roles/permissions"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AppendRolePermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>追加角色权限点</p>
     * 
     * @param request AppendRolePermissionRequest
     * @return AppendRolePermissionResponse
     */
    public AppendRolePermissionResponse appendRolePermission(AppendRolePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AppendRolePermissionHeaders headers = new AppendRolePermissionHeaders();
        return this.appendRolePermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发票数据批量写入</p>
     * 
     * @param request BatchAddInvoiceRequest
     * @param headers BatchAddInvoiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchAddInvoiceResponse
     */
    public BatchAddInvoiceResponse batchAddInvoiceWithOptions(BatchAddInvoiceRequest request, BatchAddInvoiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.generalInvoiceVOList)) {
            body.put("generalInvoiceVOList", request.generalInvoiceVOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.source)) {
            body.put("source", request.source);
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
            new TeaPair("action", "BatchAddInvoice"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchAddInvoiceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发票数据批量写入</p>
     * 
     * @param request BatchAddInvoiceRequest
     * @return BatchAddInvoiceResponse
     */
    public BatchAddInvoiceResponse batchAddInvoice(BatchAddInvoiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchAddInvoiceHeaders headers = new BatchAddInvoiceHeaders();
        return this.batchAddInvoiceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量增加用户信息</p>
     * 
     * @param request BatchCreateCustomerRequest
     * @param headers BatchCreateCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchCreateCustomerResponse
     */
    public BatchCreateCustomerResponse batchCreateCustomerWithOptions(BatchCreateCustomerRequest request, BatchCreateCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.createCustomerRequestList)) {
            body.put("createCustomerRequestList", request.createCustomerRequestList);
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
            new TeaPair("action", "BatchCreateCustomer"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/auxiliaries/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchCreateCustomerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量增加用户信息</p>
     * 
     * @param request BatchCreateCustomerRequest
     * @return BatchCreateCustomerResponse
     */
    public BatchCreateCustomerResponse batchCreateCustomer(BatchCreateCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchCreateCustomerHeaders headers = new BatchCreateCustomerHeaders();
        return this.batchCreateCustomerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>预核销智能财务的权益</p>
     * 
     * @param request BeginConsumeRequest
     * @param headers BeginConsumeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BeginConsumeResponse
     */
    public BeginConsumeResponse beginConsumeWithOptions(BeginConsumeRequest request, BeginConsumeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCode)) {
            query.put("benefitCode", request.benefitCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            query.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quota)) {
            query.put("quota", request.quota);
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
            new TeaPair("action", "BeginConsume"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/consumedBenefits/prepare"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BeginConsumeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>预核销智能财务的权益</p>
     * 
     * @param request BeginConsumeRequest
     * @return BeginConsumeResponse
     */
    public BeginConsumeResponse beginConsume(BeginConsumeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BeginConsumeHeaders headers = new BeginConsumeHeaders();
        return this.beginConsumeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>绑定钉钉智能财务企业主体的账套信息</p>
     * 
     * @param request BindCompanyAccountantBookRequest
     * @param headers BindCompanyAccountantBookHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BindCompanyAccountantBookResponse
     */
    public BindCompanyAccountantBookResponse bindCompanyAccountantBookWithOptions(BindCompanyAccountantBookRequest request, BindCompanyAccountantBookHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountantBookId)) {
            query.put("accountantBookId", request.accountantBookId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            query.put("companyCode", request.companyCode);
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
            new TeaPair("action", "BindCompanyAccountantBook"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/companies/accountantBooks/bind"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BindCompanyAccountantBookResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>绑定钉钉智能财务企业主体的账套信息</p>
     * 
     * @param request BindCompanyAccountantBookRequest
     * @return BindCompanyAccountantBookResponse
     */
    public BindCompanyAccountantBookResponse bindCompanyAccountantBook(BindCompanyAccountantBookRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BindCompanyAccountantBookHeaders headers = new BindCompanyAccountantBookHeaders();
        return this.bindCompanyAccountantBookWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>取消核销智能财务的权益</p>
     * 
     * @param request CancelConsumeRequest
     * @param headers CancelConsumeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CancelConsumeResponse
     */
    public CancelConsumeResponse cancelConsumeWithOptions(CancelConsumeRequest request, CancelConsumeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCode)) {
            query.put("benefitCode", request.benefitCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            query.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quota)) {
            query.put("quota", request.quota);
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
            new TeaPair("action", "CancelConsume"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/consumedBenefits/cancel"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CancelConsumeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>取消核销智能财务的权益</p>
     * 
     * @param request CancelConsumeRequest
     * @return CancelConsumeResponse
     */
    public CancelConsumeResponse cancelConsume(CancelConsumeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CancelConsumeHeaders headers = new CancelConsumeHeaders();
        return this.cancelConsumeWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/checkVoucherStatus/query"),
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
     * <p>确认核销智能财务的权益</p>
     * 
     * @param request CommitConsumeRequest
     * @param headers CommitConsumeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CommitConsumeResponse
     */
    public CommitConsumeResponse commitConsumeWithOptions(CommitConsumeRequest request, CommitConsumeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCode)) {
            query.put("benefitCode", request.benefitCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            query.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quota)) {
            query.put("quota", request.quota);
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
            new TeaPair("action", "CommitConsume"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/consumedBenefits/commit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CommitConsumeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>确认核销智能财务的权益</p>
     * 
     * @param request CommitConsumeRequest
     * @return CommitConsumeResponse
     */
    public CommitConsumeResponse commitConsume(CommitConsumeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CommitConsumeHeaders headers = new CommitConsumeHeaders();
        return this.commitConsumeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建智能财务的客户信息</p>
     * 
     * @param request CreateCustomerRequest
     * @param headers CreateCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateCustomerResponse
     */
    public CreateCustomerResponse createCustomerWithOptions(CreateCustomerRequest request, CreateCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creator)) {
            body.put("creator", request.creator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.drawerEmail)) {
            body.put("drawerEmail", request.drawerEmail);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.drawerTelephone)) {
            body.put("drawerTelephone", request.drawerTelephone);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserAccount)) {
            body.put("purchaserAccount", request.purchaserAccount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.purchaserAddress)) {
            body.put("purchaserAddress", request.purchaserAddress);
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
            new TeaPair("action", "CreateCustomer"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/auxiliaries/customers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateCustomerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建智能财务的客户信息</p>
     * 
     * @param request CreateCustomerRequest
     * @return CreateCustomerResponse
     */
    public CreateCustomerResponse createCustomer(CreateCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateCustomerHeaders headers = new CreateCustomerHeaders();
        return this.createCustomerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建智能财务单据</p>
     * 
     * @param request CreateReceiptRequest
     * @param headers CreateReceiptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateReceiptResponse
     */
    public CreateReceiptResponse createReceiptWithOptions(CreateReceiptRequest request, CreateReceiptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.receipts)) {
            body.put("receipts", request.receipts);
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
            new TeaPair("action", "CreateReceipt"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/receipts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateReceiptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建智能财务单据</p>
     * 
     * @param request CreateReceiptRequest
     * @return CreateReceiptResponse
     */
    public CreateReceiptResponse createReceipt(CreateReceiptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateReceiptHeaders headers = new CreateReceiptHeaders();
        return this.createReceiptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除智能财务单据</p>
     * 
     * @param request DeleteReceiptRequest
     * @param headers DeleteReceiptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteReceiptResponse
     */
    public DeleteReceiptResponse deleteReceiptWithOptions(DeleteReceiptRequest request, DeleteReceiptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.receipts)) {
            body.put("receipts", request.receipts);
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
            new TeaPair("action", "DeleteReceipt"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/receipts/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteReceiptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除智能财务单据</p>
     * 
     * @param request DeleteReceiptRequest
     * @return DeleteReceiptResponse
     */
    public DeleteReceiptResponse deleteReceipt(DeleteReceiptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteReceiptHeaders headers = new DeleteReceiptHeaders();
        return this.deleteReceiptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取可以查看账本的用户列表</p>
     * 
     * @param headers GetBookkeepingUserListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetBookkeepingUserListResponse
     */
    public GetBookkeepingUserListResponse getBookkeepingUserListWithOptions(GetBookkeepingUserListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetBookkeepingUserList"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/bookkeeping/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetBookkeepingUserListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取可以查看账本的用户列表</p>
     * @return GetBookkeepingUserListResponse
     */
    public GetBookkeepingUserListResponse getBookkeepingUserList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetBookkeepingUserListHeaders headers = new GetBookkeepingUserListHeaders();
        return this.getBookkeepingUserListWithOptions(headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/categories/get"),
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
     * <p>获取智能财务应用内维护的客户信息</p>
     * 
     * @param request GetCustomerRequest
     * @param headers GetCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCustomerResponse
     */
    public GetCustomerResponse getCustomerWithOptions(GetCustomerRequest request, GetCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCustomer"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/customers/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCustomerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务应用内维护的客户信息</p>
     * 
     * @param request GetCustomerRequest
     * @return GetCustomerResponse
     */
    public GetCustomerResponse getCustomer(GetCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCustomerHeaders headers = new GetCustomerHeaders();
        return this.getCustomerWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/financeAccounts/get"),
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
     * <p>获取智能财务套件模版信息</p>
     * 
     * @param headers GetFormTemplateInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFormTemplateInfoResponse
     */
    public GetFormTemplateInfoResponse getFormTemplateInfoWithOptions(GetFormTemplateInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFormTemplateInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/formTemplates/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFormTemplateInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取智能财务套件模版信息</p>
     * @return GetFormTemplateInfoResponse
     */
    public GetFormTemplateInfoResponse getFormTemplateInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFormTemplateInfoHeaders headers = new GetFormTemplateInfoHeaders();
        return this.getFormTemplateInfoWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发票分页查询接口</p>
     * 
     * @param tmpReq GetInvoiceByPageRequest
     * @param headers GetInvoiceByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInvoiceByPageResponse
     */
    public GetInvoiceByPageResponse getInvoiceByPageWithOptions(GetInvoiceByPageRequest tmpReq, GetInvoiceByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        GetInvoiceByPageShrinkRequest request = new GetInvoiceByPageShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.request)) {
            request.requestShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.request, "request", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.requestShrink)) {
            query.put("request", request.requestShrink);
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
            new TeaPair("action", "GetInvoiceByPage"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInvoiceByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发票分页查询接口</p>
     * 
     * @param request GetInvoiceByPageRequest
     * @return GetInvoiceByPageResponse
     */
    public GetInvoiceByPageResponse getInvoiceByPage(GetInvoiceByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInvoiceByPageHeaders headers = new GetInvoiceByPageHeaders();
        return this.getInvoiceByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用来给isv提供是否使用智能账本的判断接口</p>
     * 
     * @param headers GetIsNewVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetIsNewVersionResponse
     */
    public GetIsNewVersionResponse getIsNewVersionWithOptions(GetIsNewVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetIsNewVersion"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/accounts/uses"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetIsNewVersionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用来给isv提供是否使用智能账本的判断接口</p>
     * @return GetIsNewVersionResponse
     */
    public GetIsNewVersionResponse getIsNewVersion() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetIsNewVersionHeaders headers = new GetIsNewVersionHeaders();
        return this.getIsNewVersionWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据comanyCode查询钉钉智能财务多主体信息</p>
     * 
     * @param headers GetMultiCompanyInfoByCodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMultiCompanyInfoByCodeResponse
     */
    public GetMultiCompanyInfoByCodeResponse getMultiCompanyInfoByCodeWithOptions(String companyCode, GetMultiCompanyInfoByCodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetMultiCompanyInfoByCode"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/multiCompanies/" + companyCode + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMultiCompanyInfoByCodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据comanyCode查询钉钉智能财务多主体信息</p>
     * @return GetMultiCompanyInfoByCodeResponse
     */
    public GetMultiCompanyInfoByCodeResponse getMultiCompanyInfoByCode(String companyCode) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMultiCompanyInfoByCodeHeaders headers = new GetMultiCompanyInfoByCodeHeaders();
        return this.getMultiCompanyInfoByCodeWithOptions(companyCode, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取商品信息</p>
     * 
     * @param request GetProductRequest
     * @param headers GetProductHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetProductResponse
     */
    public GetProductResponse getProductWithOptions(GetProductRequest request, GetProductHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetProduct"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/products"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetProductResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取商品信息</p>
     * 
     * @param request GetProductRequest
     * @return GetProductResponse
     */
    public GetProductResponse getProduct(GetProductRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetProductHeaders headers = new GetProductHeaders();
        return this.getProductWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/projects/get"),
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/receipts/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/suppliers/details"),
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
     * <p>获取用友开放平台接口鉴权信息</p>
     * 
     * @param request GetYongYouOpenApiTokenRequest
     * @param headers GetYongYouOpenApiTokenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetYongYouOpenApiTokenResponse
     */
    public GetYongYouOpenApiTokenResponse getYongYouOpenApiTokenWithOptions(GetYongYouOpenApiTokenRequest request, GetYongYouOpenApiTokenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetYongYouOpenApiToken"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/yongyou/token"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetYongYouOpenApiTokenResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用友开放平台接口鉴权信息</p>
     * 
     * @param request GetYongYouOpenApiTokenRequest
     * @return GetYongYouOpenApiTokenResponse
     */
    public GetYongYouOpenApiTokenResponse getYongYouOpenApiToken(GetYongYouOpenApiTokenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetYongYouOpenApiTokenHeaders headers = new GetYongYouOpenApiTokenHeaders();
        return this.getYongYouOpenApiTokenWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询钉钉组织绑定的畅捷通组织</p>
     * 
     * @param headers GetYongYouOrgRelationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetYongYouOrgRelationResponse
     */
    public GetYongYouOrgRelationResponse getYongYouOrgRelationWithOptions(GetYongYouOrgRelationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetYongYouOrgRelation"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/yongyou/relations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetYongYouOrgRelationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询钉钉组织绑定的畅捷通组织</p>
     * @return GetYongYouOrgRelationResponse
     */
    public GetYongYouOrgRelationResponse getYongYouOrgRelation() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetYongYouOrgRelationHeaders headers = new GetYongYouOrgRelationHeaders();
        return this.getYongYouOrgRelationWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>权益核销</p>
     * 
     * @param request ProfessionBenefitConsumeRequest
     * @param headers ProfessionBenefitConsumeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ProfessionBenefitConsumeResponse
     */
    public ProfessionBenefitConsumeResponse professionBenefitConsumeWithOptions(ProfessionBenefitConsumeRequest request, ProfessionBenefitConsumeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCode)) {
            body.put("benefitCode", request.benefitCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizRequestId)) {
            body.put("bizRequestId", request.bizRequestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.quota)) {
            body.put("quota", request.quota);
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
            new TeaPair("action", "ProfessionBenefitConsume"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/professions/benefits/consume"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ProfessionBenefitConsumeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>权益核销</p>
     * 
     * @param request ProfessionBenefitConsumeRequest
     * @return ProfessionBenefitConsumeResponse
     */
    public ProfessionBenefitConsumeResponse professionBenefitConsume(ProfessionBenefitConsumeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ProfessionBenefitConsumeHeaders headers = new ProfessionBenefitConsumeHeaders();
        return this.professionBenefitConsumeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>触发单据同步给有成</p>
     * 
     * @param request PushHistoricalReceiptsRequest
     * @param headers PushHistoricalReceiptsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PushHistoricalReceiptsResponse
     */
    public PushHistoricalReceiptsResponse pushHistoricalReceiptsWithOptions(PushHistoricalReceiptsRequest request, PushHistoricalReceiptsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.forcedIgnoreDup)) {
            body.put("forcedIgnoreDup", request.forcedIgnoreDup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.formCodeList)) {
            body.put("formCodeList", request.formCodeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
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
            new TeaPair("action", "PushHistoricalReceipts"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/budgets/historicalReceipts/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PushHistoricalReceiptsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>触发单据同步给有成</p>
     * 
     * @param request PushHistoricalReceiptsRequest
     * @return PushHistoricalReceiptsResponse
     */
    public PushHistoricalReceiptsResponse pushHistoricalReceipts(PushHistoricalReceiptsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PushHistoricalReceiptsHeaders headers = new PushHistoricalReceiptsHeaders();
        return this.pushHistoricalReceiptsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询智能财务计量型权益</p>
     * 
     * @param request QueryBenefitRequest
     * @param headers QueryBenefitHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBenefitResponse
     */
    public QueryBenefitResponse queryBenefitWithOptions(QueryBenefitRequest request, QueryBenefitHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.benefitCode)) {
            query.put("benefitCode", request.benefitCode);
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
            new TeaPair("action", "QueryBenefit"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/benefits"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBenefitResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询智能财务计量型权益</p>
     * 
     * @param request QueryBenefitRequest
     * @return QueryBenefitResponse
     */
    public QueryBenefitResponse queryBenefit(QueryBenefitRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBenefitHeaders headers = new QueryBenefitHeaders();
        return this.queryBenefitWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/categories/list"),
            new TeaPair("method", "GET"),
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
     * <p>查询某个主体的开票申请单的提单数量</p>
     * 
     * @param request QueryCompanyInvoiceRelationCountRequest
     * @param headers QueryCompanyInvoiceRelationCountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCompanyInvoiceRelationCountResponse
     */
    public QueryCompanyInvoiceRelationCountResponse queryCompanyInvoiceRelationCountWithOptions(QueryCompanyInvoiceRelationCountRequest request, QueryCompanyInvoiceRelationCountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            query.put("companyCode", request.companyCode);
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
            new TeaPair("action", "QueryCompanyInvoiceRelationCount"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/companyRelationReceipts/counts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCompanyInvoiceRelationCountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询某个主体的开票申请单的提单数量</p>
     * 
     * @param request QueryCompanyInvoiceRelationCountRequest
     * @return QueryCompanyInvoiceRelationCountResponse
     */
    public QueryCompanyInvoiceRelationCountResponse queryCompanyInvoiceRelationCount(QueryCompanyInvoiceRelationCountRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCompanyInvoiceRelationCountHeaders headers = new QueryCompanyInvoiceRelationCountHeaders();
        return this.queryCompanyInvoiceRelationCountWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/customers"),
            new TeaPair("method", "GET"),
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
     * <p>提供给合作伙伴，查询智能财务的客户配置信息</p>
     * 
     * @param request QueryCustomerInfoRequest
     * @param headers QueryCustomerInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCustomerInfoResponse
     */
    public QueryCustomerInfoResponse queryCustomerInfoWithOptions(QueryCustomerInfoRequest request, QueryCustomerInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            query.put("keyword", request.keyword);
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
            new TeaPair("action", "QueryCustomerInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/auxiliaries/customers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCustomerInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>提供给合作伙伴，查询智能财务的客户配置信息</p>
     * 
     * @param request QueryCustomerInfoRequest
     * @return QueryCustomerInfoResponse
     */
    public QueryCustomerInfoResponse queryCustomerInfo(QueryCustomerInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCustomerInfoHeaders headers = new QueryCustomerInfoHeaders();
        return this.queryCustomerInfoWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/financeAccounts/list"),
            new TeaPair("method", "GET"),
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
     * <p>查询智能财务配置的企业信息</p>
     * 
     * @param headers QueryFinanceCompanyInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryFinanceCompanyInfoResponse
     */
    public QueryFinanceCompanyInfoResponse queryFinanceCompanyInfoWithOptions(QueryFinanceCompanyInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryFinanceCompanyInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/companies"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryFinanceCompanyInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询智能财务配置的企业信息</p>
     * @return QueryFinanceCompanyInfoResponse
     */
    public QueryFinanceCompanyInfoResponse queryFinanceCompanyInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryFinanceCompanyInfoHeaders headers = new QueryFinanceCompanyInfoHeaders();
        return this.queryFinanceCompanyInfoWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询开票申请单的提单数量</p>
     * 
     * @param headers QueryInvoiceRelationCountHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryInvoiceRelationCountResponse
     */
    public QueryInvoiceRelationCountResponse queryInvoiceRelationCountWithOptions(QueryInvoiceRelationCountHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryInvoiceRelationCount"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/relationReceipts/counts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryInvoiceRelationCountResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询开票申请单的提单数量</p>
     * @return QueryInvoiceRelationCountResponse
     */
    public QueryInvoiceRelationCountResponse queryInvoiceRelationCount() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryInvoiceRelationCountHeaders headers = new QueryInvoiceRelationCountHeaders();
        return this.queryInvoiceRelationCountWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询钉钉智能财务多主体信息</p>
     * 
     * @param headers QueryMultiCompanyInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMultiCompanyInfoResponse
     */
    public QueryMultiCompanyInfoResponse queryMultiCompanyInfoWithOptions(QueryMultiCompanyInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryMultiCompanyInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/multiCompanies"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMultiCompanyInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询钉钉智能财务多主体信息</p>
     * @return QueryMultiCompanyInfoResponse
     */
    public QueryMultiCompanyInfoResponse queryMultiCompanyInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMultiCompanyInfoHeaders headers = new QueryMultiCompanyInfoHeaders();
        return this.queryMultiCompanyInfoWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>提供给小望，查询当前用户所具有的的小望权限点信息</p>
     * 
     * @param request QueryPermissionByUserIdRequest
     * @param headers QueryPermissionByUserIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPermissionByUserIdResponse
     */
    public QueryPermissionByUserIdResponse queryPermissionByUserIdWithOptions(QueryPermissionByUserIdRequest request, QueryPermissionByUserIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryPermissionByUserId"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/permissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPermissionByUserIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>提供给小望，查询当前用户所具有的的小望权限点信息</p>
     * 
     * @param request QueryPermissionByUserIdRequest
     * @return QueryPermissionByUserIdResponse
     */
    public QueryPermissionByUserIdResponse queryPermissionByUserId(QueryPermissionByUserIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPermissionByUserIdHeaders headers = new QueryPermissionByUserIdHeaders();
        return this.queryPermissionByUserIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询智能财务角色下的成员信息</p>
     * 
     * @param request QueryPermissionRoleMemberRequest
     * @param headers QueryPermissionRoleMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPermissionRoleMemberResponse
     */
    public QueryPermissionRoleMemberResponse queryPermissionRoleMemberWithOptions(QueryPermissionRoleMemberRequest request, QueryPermissionRoleMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleCodeList)) {
            body.put("roleCodeList", request.roleCodeList);
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
            new TeaPair("action", "QueryPermissionRoleMember"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/roles/members/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPermissionRoleMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询智能财务角色下的成员信息</p>
     * 
     * @param request QueryPermissionRoleMemberRequest
     * @return QueryPermissionRoleMemberResponse
     */
    public QueryPermissionRoleMemberResponse queryPermissionRoleMember(QueryPermissionRoleMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPermissionRoleMemberHeaders headers = new QueryPermissionRoleMemberHeaders();
        return this.queryPermissionRoleMemberWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/products/query"),
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/projects/list"),
            new TeaPair("method", "GET"),
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
     * <p>查询开票申请单详情</p>
     * 
     * @param request QueryReceiptDetailForInvoiceRequest
     * @param headers QueryReceiptDetailForInvoiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryReceiptDetailForInvoiceResponse
     */
    public QueryReceiptDetailForInvoiceResponse queryReceiptDetailForInvoiceWithOptions(QueryReceiptDetailForInvoiceRequest request, QueryReceiptDetailForInvoiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryReceiptDetailForInvoice"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/receipts/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryReceiptDetailForInvoiceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询开票申请单详情</p>
     * 
     * @param request QueryReceiptDetailForInvoiceRequest
     * @return QueryReceiptDetailForInvoiceResponse
     */
    public QueryReceiptDetailForInvoiceResponse queryReceiptDetailForInvoice(QueryReceiptDetailForInvoiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryReceiptDetailForInvoiceHeaders headers = new QueryReceiptDetailForInvoiceHeaders();
        return this.queryReceiptDetailForInvoiceWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/receipts/query"),
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
     * <p>批量查询智能财务的单据主数据基本信息</p>
     * 
     * @param request QueryReceiptsBaseInfoRequest
     * @param headers QueryReceiptsBaseInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryReceiptsBaseInfoResponse
     */
    public QueryReceiptsBaseInfoResponse queryReceiptsBaseInfoWithOptions(QueryReceiptsBaseInfoRequest request, QueryReceiptsBaseInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountantBookId)) {
            query.put("accountantBookId", request.accountantBookId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.amountEnd)) {
            query.put("amountEnd", request.amountEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.amountStart)) {
            query.put("amountStart", request.amountStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            query.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeFilterField)) {
            query.put("timeFilterField", request.timeFilterField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            query.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.voucherStatus)) {
            query.put("voucherStatus", request.voucherStatus);
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
            new TeaPair("action", "QueryReceiptsBaseInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/receipts/dataInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryReceiptsBaseInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询智能财务的单据主数据基本信息</p>
     * 
     * @param request QueryReceiptsBaseInfoRequest
     * @return QueryReceiptsBaseInfoResponse
     */
    public QueryReceiptsBaseInfoResponse queryReceiptsBaseInfo(QueryReceiptsBaseInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryReceiptsBaseInfoHeaders headers = new QueryReceiptsBaseInfoHeaders();
        return this.queryReceiptsBaseInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取智能财务单据详情列表</p>
     * 
     * @param request QueryReceiptsByPageRequest
     * @param headers QueryReceiptsByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryReceiptsByPageResponse
     */
    public QueryReceiptsByPageResponse queryReceiptsByPageWithOptions(QueryReceiptsByPageRequest request, QueryReceiptsByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            query.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modelId)) {
            query.put("modelId", request.modelId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            query.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timeFilterField)) {
            query.put("timeFilterField", request.timeFilterField);
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
            new TeaPair("action", "QueryReceiptsByPage"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/receipts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryReceiptsByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取智能财务单据详情列表</p>
     * 
     * @param request QueryReceiptsByPageRequest
     * @return QueryReceiptsByPageResponse
     */
    public QueryReceiptsByPageResponse queryReceiptsByPage(QueryReceiptsByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryReceiptsByPageHeaders headers = new QueryReceiptsByPageHeaders();
        return this.queryReceiptsByPageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询智能财务角色下的成员信息</p>
     * 
     * @param request QueryRoleMemberByPageRequest
     * @param headers QueryRoleMemberByPageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryRoleMemberByPageResponse
     */
    public QueryRoleMemberByPageResponse queryRoleMemberByPageWithOptions(QueryRoleMemberByPageRequest request, QueryRoleMemberByPageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            query.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleCode)) {
            query.put("roleCode", request.roleCode);
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
            new TeaPair("action", "QueryRoleMemberByPage"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/roles/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryRoleMemberByPageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询智能财务角色下的成员信息</p>
     * 
     * @param request QueryRoleMemberByPageRequest
     * @return QueryRoleMemberByPageResponse
     */
    public QueryRoleMemberByPageResponse queryRoleMemberByPage(QueryRoleMemberByPageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryRoleMemberByPageHeaders headers = new QueryRoleMemberByPageHeaders();
        return this.queryRoleMemberByPageWithOptions(request, headers, runtime);
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
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/suppliers"),
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
     * <p>查询用户角色</p>
     * 
     * @param request QueryUserRoleListRequest
     * @param headers QueryUserRoleListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserRoleListResponse
     */
    public QueryUserRoleListResponse queryUserRoleListWithOptions(QueryUserRoleListRequest request, QueryUserRoleListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserRoleList"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/users/roles"),
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
     * <p>查询用户角色</p>
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
     * <p>解绑开票申请单关联的发票</p>
     * 
     * @param request UnbindApplyReceiptAndInvoiceRelatedRequest
     * @param headers UnbindApplyReceiptAndInvoiceRelatedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnbindApplyReceiptAndInvoiceRelatedResponse
     */
    public UnbindApplyReceiptAndInvoiceRelatedResponse unbindApplyReceiptAndInvoiceRelatedWithOptions(UnbindApplyReceiptAndInvoiceRelatedRequest request, UnbindApplyReceiptAndInvoiceRelatedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
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
            new TeaPair("action", "UnbindApplyReceiptAndInvoiceRelated"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/unbind"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnbindApplyReceiptAndInvoiceRelatedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>解绑开票申请单关联的发票</p>
     * 
     * @param request UnbindApplyReceiptAndInvoiceRelatedRequest
     * @return UnbindApplyReceiptAndInvoiceRelatedResponse
     */
    public UnbindApplyReceiptAndInvoiceRelatedResponse unbindApplyReceiptAndInvoiceRelated(UnbindApplyReceiptAndInvoiceRelatedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnbindApplyReceiptAndInvoiceRelatedHeaders headers = new UnbindApplyReceiptAndInvoiceRelatedHeaders();
        return this.unbindApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>开票申请单关联发票</p>
     * 
     * @param request UpdateApplyReceiptAndInvoiceRelatedRequest
     * @param headers UpdateApplyReceiptAndInvoiceRelatedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateApplyReceiptAndInvoiceRelatedResponse
     */
    public UpdateApplyReceiptAndInvoiceRelatedResponse updateApplyReceiptAndInvoiceRelatedWithOptions(UpdateApplyReceiptAndInvoiceRelatedRequest request, UpdateApplyReceiptAndInvoiceRelatedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.generalInvoiceVOList)) {
            body.put("generalInvoiceVOList", request.generalInvoiceVOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
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
            new TeaPair("action", "UpdateApplyReceiptAndInvoiceRelated"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/applyReceipts/relate"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateApplyReceiptAndInvoiceRelatedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>开票申请单关联发票</p>
     * 
     * @param request UpdateApplyReceiptAndInvoiceRelatedRequest
     * @return UpdateApplyReceiptAndInvoiceRelatedResponse
     */
    public UpdateApplyReceiptAndInvoiceRelatedResponse updateApplyReceiptAndInvoiceRelated(UpdateApplyReceiptAndInvoiceRelatedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateApplyReceiptAndInvoiceRelatedHeaders headers = new UpdateApplyReceiptAndInvoiceRelatedHeaders();
        return this.updateApplyReceiptAndInvoiceRelatedWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新全电发票企业信息</p>
     * 
     * @param request UpdateDigitalInvoiceOrgInfoRequest
     * @param headers UpdateDigitalInvoiceOrgInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateDigitalInvoiceOrgInfoResponse
     */
    public UpdateDigitalInvoiceOrgInfoResponse updateDigitalInvoiceOrgInfoWithOptions(UpdateDigitalInvoiceOrgInfoRequest request, UpdateDigitalInvoiceOrgInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.digitalInvoiceType)) {
            body.put("digitalInvoiceType", request.digitalInvoiceType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDigitalOrg)) {
            body.put("isDigitalOrg", request.isDigitalOrg);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
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
            new TeaPair("action", "UpdateDigitalInvoiceOrgInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/organizationInfos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateDigitalInvoiceOrgInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新全电发票企业信息</p>
     * 
     * @param request UpdateDigitalInvoiceOrgInfoRequest
     * @return UpdateDigitalInvoiceOrgInfoResponse
     */
    public UpdateDigitalInvoiceOrgInfoResponse updateDigitalInvoiceOrgInfo(UpdateDigitalInvoiceOrgInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateDigitalInvoiceOrgInfoHeaders headers = new UpdateDigitalInvoiceOrgInfoHeaders();
        return this.updateDigitalInvoiceOrgInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务配置的企业信息</p>
     * 
     * @param request UpdateFinanceCompanyInfoRequest
     * @param headers UpdateFinanceCompanyInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateFinanceCompanyInfoResponse
     */
    public UpdateFinanceCompanyInfoResponse updateFinanceCompanyInfoWithOptions(UpdateFinanceCompanyInfoRequest request, UpdateFinanceCompanyInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyName)) {
            query.put("companyName", request.companyName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNature)) {
            query.put("taxNature", request.taxNature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNo)) {
            query.put("taxNo", request.taxNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxOrInvoiceHasInit)) {
            query.put("taxOrInvoiceHasInit", request.taxOrInvoiceHasInit);
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
            new TeaPair("action", "UpdateFinanceCompanyInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/companies"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateFinanceCompanyInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务配置的企业信息</p>
     * 
     * @param request UpdateFinanceCompanyInfoRequest
     * @return UpdateFinanceCompanyInfoResponse
     */
    public UpdateFinanceCompanyInfoResponse updateFinanceCompanyInfo(UpdateFinanceCompanyInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateFinanceCompanyInfoHeaders headers = new UpdateFinanceCompanyInfoHeaders();
        return this.updateFinanceCompanyInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新钉钉智能财务多主体信息</p>
     * 
     * @param request UpdateFinanceMultiCompanyInfoRequest
     * @param headers UpdateFinanceMultiCompanyInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateFinanceMultiCompanyInfoResponse
     */
    public UpdateFinanceMultiCompanyInfoResponse updateFinanceMultiCompanyInfoWithOptions(UpdateFinanceMultiCompanyInfoRequest request, UpdateFinanceMultiCompanyInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            query.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.companyName)) {
            query.put("companyName", request.companyName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNature)) {
            query.put("taxNature", request.taxNature);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxNo)) {
            query.put("taxNo", request.taxNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taxOrInvoiceHasInit)) {
            query.put("taxOrInvoiceHasInit", request.taxOrInvoiceHasInit);
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
            new TeaPair("action", "UpdateFinanceMultiCompanyInfo"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/multiCompanies"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateFinanceMultiCompanyInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新钉钉智能财务多主体信息</p>
     * 
     * @param request UpdateFinanceMultiCompanyInfoRequest
     * @return UpdateFinanceMultiCompanyInfoResponse
     */
    public UpdateFinanceMultiCompanyInfoResponse updateFinanceMultiCompanyInfo(UpdateFinanceMultiCompanyInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateFinanceMultiCompanyInfoHeaders headers = new UpdateFinanceMultiCompanyInfoHeaders();
        return this.updateFinanceMultiCompanyInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发票红冲/废弃状态变更接口</p>
     * 
     * @param request UpdateInvoiceAbandonStatusRequest
     * @param headers UpdateInvoiceAbandonStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceAbandonStatusResponse
     */
    public UpdateInvoiceAbandonStatusResponse updateInvoiceAbandonStatusWithOptions(UpdateInvoiceAbandonStatusRequest request, UpdateInvoiceAbandonStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.blueGeneralInvoiceVO)) {
            body.put("blueGeneralInvoiceVO", request.blueGeneralInvoiceVO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.blueInvoiceCode)) {
            body.put("blueInvoiceCode", request.blueInvoiceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.blueInvoiceNo)) {
            body.put("blueInvoiceNo", request.blueInvoiceNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.blueInvoiceStatus)) {
            body.put("blueInvoiceStatus", request.blueInvoiceStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redGeneralInvoiceVO)) {
            body.put("redGeneralInvoiceVO", request.redGeneralInvoiceVO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redInvoiceCode)) {
            body.put("redInvoiceCode", request.redInvoiceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redInvoiceNo)) {
            body.put("redInvoiceNo", request.redInvoiceNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redInvoiceStatus)) {
            body.put("redInvoiceStatus", request.redInvoiceStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetInvoice)) {
            body.put("targetInvoice", request.targetInvoice);
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
            new TeaPair("action", "UpdateInvoiceAbandonStatus"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/abandonStatus"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceAbandonStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>发票红冲/废弃状态变更接口</p>
     * 
     * @param request UpdateInvoiceAbandonStatusRequest
     * @return UpdateInvoiceAbandonStatusResponse
     */
    public UpdateInvoiceAbandonStatusResponse updateInvoiceAbandonStatus(UpdateInvoiceAbandonStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceAbandonStatusHeaders headers = new UpdateInvoiceAbandonStatusHeaders();
        return this.updateInvoiceAbandonStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新发票账期状态</p>
     * 
     * @param request UpdateInvoiceAccountPeriodRequest
     * @param headers UpdateInvoiceAccountPeriodHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceAccountPeriodResponse
     */
    public UpdateInvoiceAccountPeriodResponse updateInvoiceAccountPeriodWithOptions(UpdateInvoiceAccountPeriodRequest request, UpdateInvoiceAccountPeriodHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountPeriod)) {
            body.put("accountPeriod", request.accountPeriod);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.generalInvoiceVOList)) {
            body.put("generalInvoiceVOList", request.generalInvoiceVOList);
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
            new TeaPair("action", "UpdateInvoiceAccountPeriod"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/accountPeriods"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceAccountPeriodResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新发票账期状态</p>
     * 
     * @param request UpdateInvoiceAccountPeriodRequest
     * @return UpdateInvoiceAccountPeriodResponse
     */
    public UpdateInvoiceAccountPeriodResponse updateInvoiceAccountPeriod(UpdateInvoiceAccountPeriodRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceAccountPeriodHeaders headers = new UpdateInvoiceAccountPeriodHeaders();
        return this.updateInvoiceAccountPeriodWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新全电企业入账时间</p>
     * 
     * @param request UpdateInvoiceAccountingPeriodDateRequest
     * @param headers UpdateInvoiceAccountingPeriodDateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceAccountingPeriodDateResponse
     */
    public UpdateInvoiceAccountingPeriodDateResponse updateInvoiceAccountingPeriodDateWithOptions(UpdateInvoiceAccountingPeriodDateRequest request, UpdateInvoiceAccountingPeriodDateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceFinanceInfoVOList)) {
            body.put("invoiceFinanceInfoVOList", request.invoiceFinanceInfoVOList);
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
            new TeaPair("action", "UpdateInvoiceAccountingPeriodDate"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/accounts/periodDates"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceAccountingPeriodDateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新全电企业入账时间</p>
     * 
     * @param request UpdateInvoiceAccountingPeriodDateRequest
     * @return UpdateInvoiceAccountingPeriodDateResponse
     */
    public UpdateInvoiceAccountingPeriodDateResponse updateInvoiceAccountingPeriodDate(UpdateInvoiceAccountingPeriodDateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceAccountingPeriodDateHeaders headers = new UpdateInvoiceAccountingPeriodDateHeaders();
        return this.updateInvoiceAccountingPeriodDateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新全电企业入账状态</p>
     * 
     * @param request UpdateInvoiceAccountingStatusRequest
     * @param headers UpdateInvoiceAccountingStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceAccountingStatusResponse
     */
    public UpdateInvoiceAccountingStatusResponse updateInvoiceAccountingStatusWithOptions(UpdateInvoiceAccountingStatusRequest request, UpdateInvoiceAccountingStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceFinanceInfoVOList)) {
            body.put("invoiceFinanceInfoVOList", request.invoiceFinanceInfoVOList);
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
            new TeaPair("action", "UpdateInvoiceAccountingStatus"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/accounts/statuses"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceAccountingStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新全电企业入账状态</p>
     * 
     * @param request UpdateInvoiceAccountingStatusRequest
     * @return UpdateInvoiceAccountingStatusResponse
     */
    public UpdateInvoiceAccountingStatusResponse updateInvoiceAccountingStatus(UpdateInvoiceAccountingStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceAccountingStatusHeaders headers = new UpdateInvoiceAccountingStatusHeaders();
        return this.updateInvoiceAccountingStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新发票关联审批单</p>
     * 
     * @param request UpdateInvoiceAndReceiptRelatedRequest
     * @param headers UpdateInvoiceAndReceiptRelatedHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceAndReceiptRelatedResponse
     */
    public UpdateInvoiceAndReceiptRelatedResponse updateInvoiceAndReceiptRelatedWithOptions(UpdateInvoiceAndReceiptRelatedRequest request, UpdateInvoiceAndReceiptRelatedHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.generalInvoiceVO)) {
            body.put("generalInvoiceVO", request.generalInvoiceVO);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceCode)) {
            body.put("invoiceCode", request.invoiceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceNo)) {
            body.put("invoiceNo", request.invoiceNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiptCode)) {
            body.put("receiptCode", request.receiptCode);
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
            new TeaPair("action", "UpdateInvoiceAndReceiptRelated"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/approvalReceipts"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceAndReceiptRelatedResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新发票关联审批单</p>
     * 
     * @param request UpdateInvoiceAndReceiptRelatedRequest
     * @return UpdateInvoiceAndReceiptRelatedResponse
     */
    public UpdateInvoiceAndReceiptRelatedResponse updateInvoiceAndReceiptRelated(UpdateInvoiceAndReceiptRelatedRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceAndReceiptRelatedHeaders headers = new UpdateInvoiceAndReceiptRelatedHeaders();
        return this.updateInvoiceAndReceiptRelatedWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新发票忽略状态</p>
     * 
     * @param request UpdateInvoiceIgnoreStatusRequest
     * @param headers UpdateInvoiceIgnoreStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceIgnoreStatusResponse
     */
    public UpdateInvoiceIgnoreStatusResponse updateInvoiceIgnoreStatusWithOptions(UpdateInvoiceIgnoreStatusRequest request, UpdateInvoiceIgnoreStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            query.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            query.put("operator", request.operator);
        }

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
            new TeaPair("action", "UpdateInvoiceIgnoreStatus"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/ignoreStatus"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceIgnoreStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新发票忽略状态</p>
     * 
     * @param request UpdateInvoiceIgnoreStatusRequest
     * @return UpdateInvoiceIgnoreStatusResponse
     */
    public UpdateInvoiceIgnoreStatusResponse updateInvoiceIgnoreStatus(UpdateInvoiceIgnoreStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceIgnoreStatusHeaders headers = new UpdateInvoiceIgnoreStatusHeaders();
        return this.updateInvoiceIgnoreStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>发票认证状态变更接口</p>
     * 
     * @param request UpdateInvoiceVerifyStatusRequest
     * @param headers UpdateInvoiceVerifyStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceVerifyStatusResponse
     */
    public UpdateInvoiceVerifyStatusResponse updateInvoiceVerifyStatusWithOptions(UpdateInvoiceVerifyStatusRequest request, UpdateInvoiceVerifyStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.companyCode)) {
            body.put("companyCode", request.companyCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deductStatus)) {
            body.put("deductStatus", request.deductStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.generalInvoiceVOList)) {
            body.put("generalInvoiceVOList", request.generalInvoiceVOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceKeyVOList)) {
            body.put("invoiceKeyVOList", request.invoiceKeyVOList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
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
            new TeaPair("action", "UpdateInvoiceVerifyStatus"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/verifyStatus"),
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
     * <p>发票认证状态变更接口</p>
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
     * <p>更新发票生成凭证状态</p>
     * 
     * @param request UpdateInvoiceVoucherStatusRequest
     * @param headers UpdateInvoiceVoucherStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateInvoiceVoucherStatusResponse
     */
    public UpdateInvoiceVoucherStatusResponse updateInvoiceVoucherStatusWithOptions(UpdateInvoiceVoucherStatusRequest request, UpdateInvoiceVoucherStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountantBookId)) {
            body.put("accountantBookId", request.accountantBookId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            body.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceCode)) {
            body.put("invoiceCode", request.invoiceCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.invoiceNo)) {
            body.put("invoiceNo", request.invoiceNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operator)) {
            body.put("operator", request.operator);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.voucherId)) {
            body.put("voucherId", request.voucherId);
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
            new TeaPair("action", "UpdateInvoiceVoucherStatus"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/invoices/vouchers/states"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateInvoiceVoucherStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新发票生成凭证状态</p>
     * 
     * @param request UpdateInvoiceVoucherStatusRequest
     * @return UpdateInvoiceVoucherStatusResponse
     */
    public UpdateInvoiceVoucherStatusResponse updateInvoiceVoucherStatus(UpdateInvoiceVoucherStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateInvoiceVoucherStatusHeaders headers = new UpdateInvoiceVoucherStatusHeaders();
        return this.updateInvoiceVoucherStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务单据</p>
     * 
     * @param request UpdateReceiptRequest
     * @param headers UpdateReceiptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateReceiptResponse
     */
    public UpdateReceiptResponse updateReceiptWithOptions(UpdateReceiptRequest request, UpdateReceiptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.receipts)) {
            body.put("receipts", request.receipts);
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
            new TeaPair("action", "UpdateReceipt"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/receipts"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateReceiptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务单据</p>
     * 
     * @param request UpdateReceiptRequest
     * @return UpdateReceiptResponse
     */
    public UpdateReceiptResponse updateReceipt(UpdateReceiptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateReceiptHeaders headers = new UpdateReceiptHeaders();
        return this.updateReceiptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务审批单的凭证状态</p>
     * 
     * @param request UpdateReceiptVoucherStatusRequest
     * @param headers UpdateReceiptVoucherStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateReceiptVoucherStatusResponse
     */
    public UpdateReceiptVoucherStatusResponse updateReceiptVoucherStatusWithOptions(UpdateReceiptVoucherStatusRequest request, UpdateReceiptVoucherStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountPeriod)) {
            body.put("accountPeriod", request.accountPeriod);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actionType)) {
            body.put("actionType", request.actionType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiptId)) {
            body.put("receiptId", request.receiptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.voucherCode)) {
            body.put("voucherCode", request.voucherCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.voucherId)) {
            body.put("voucherId", request.voucherId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.voucherNo)) {
            body.put("voucherNo", request.voucherNo);
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
            new TeaPair("action", "UpdateReceiptVoucherStatus"),
            new TeaPair("version", "bizfinance_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/bizfinance/vouchers/recepits"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateReceiptVoucherStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新智能财务审批单的凭证状态</p>
     * 
     * @param request UpdateReceiptVoucherStatusRequest
     * @return UpdateReceiptVoucherStatusResponse
     */
    public UpdateReceiptVoucherStatusResponse updateReceiptVoucherStatus(UpdateReceiptVoucherStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateReceiptVoucherStatusHeaders headers = new UpdateReceiptVoucherStatusHeaders();
        return this.updateReceiptVoucherStatusWithOptions(request, headers, runtime);
    }
}
