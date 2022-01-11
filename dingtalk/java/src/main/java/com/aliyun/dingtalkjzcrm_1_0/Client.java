// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkjzcrm_1_0.models.*;
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


    public EditContactResponse editContact(EditContactRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditContactHeaders headers = new EditContactHeaders();
        return this.editContactWithOptions(request, headers, runtime);
    }

    public EditContactResponse editContactWithOptions(EditContactRequest request, EditContactHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditContact", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/contacts", "json", req, runtime), new EditContactResponse());
    }

    public EditCustomerResponse editCustomer(EditCustomerRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditCustomerHeaders headers = new EditCustomerHeaders();
        return this.editCustomerWithOptions(request, headers, runtime);
    }

    public EditCustomerResponse editCustomerWithOptions(EditCustomerRequest request, EditCustomerHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditCustomer", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/customers", "json", req, runtime), new EditCustomerResponse());
    }

    public EditCustomerPoolResponse editCustomerPool(EditCustomerPoolRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditCustomerPoolHeaders headers = new EditCustomerPoolHeaders();
        return this.editCustomerPoolWithOptions(request, headers, runtime);
    }

    public EditCustomerPoolResponse editCustomerPoolWithOptions(EditCustomerPoolRequest request, EditCustomerPoolHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditCustomerPool", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/customerPools", "json", req, runtime), new EditCustomerPoolResponse());
    }

    public EditExchangeResponse editExchange(EditExchangeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditExchangeHeaders headers = new EditExchangeHeaders();
        return this.editExchangeWithOptions(request, headers, runtime);
    }

    public EditExchangeResponse editExchangeWithOptions(EditExchangeRequest request, EditExchangeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditExchange", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/exchanges", "json", req, runtime), new EditExchangeResponse());
    }

    public EditGoodsResponse editGoods(EditGoodsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditGoodsHeaders headers = new EditGoodsHeaders();
        return this.editGoodsWithOptions(request, headers, runtime);
    }

    public EditGoodsResponse editGoodsWithOptions(EditGoodsRequest request, EditGoodsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditGoods", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/goods", "json", req, runtime), new EditGoodsResponse());
    }

    public EditIntostockResponse editIntostock(EditIntostockRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditIntostockHeaders headers = new EditIntostockHeaders();
        return this.editIntostockWithOptions(request, headers, runtime);
    }

    public EditIntostockResponse editIntostockWithOptions(EditIntostockRequest request, EditIntostockHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditIntostock", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/intostocks", "json", req, runtime), new EditIntostockResponse());
    }

    public EditInvoiceResponse editInvoice(EditInvoiceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditInvoiceHeaders headers = new EditInvoiceHeaders();
        return this.editInvoiceWithOptions(request, headers, runtime);
    }

    public EditInvoiceResponse editInvoiceWithOptions(EditInvoiceRequest request, EditInvoiceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditInvoice", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/invoices", "json", req, runtime), new EditInvoiceResponse());
    }

    public EditOrderResponse editOrder(EditOrderRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditOrderHeaders headers = new EditOrderHeaders();
        return this.editOrderWithOptions(request, headers, runtime);
    }

    public EditOrderResponse editOrderWithOptions(EditOrderRequest request, EditOrderHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditOrder", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/orders", "json", req, runtime), new EditOrderResponse());
    }

    public EditOutstockResponse editOutstock(EditOutstockRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditOutstockHeaders headers = new EditOutstockHeaders();
        return this.editOutstockWithOptions(request, headers, runtime);
    }

    public EditOutstockResponse editOutstockWithOptions(EditOutstockRequest request, EditOutstockHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditOutstock", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/outstocks", "json", req, runtime), new EditOutstockResponse());
    }

    public EditProductionResponse editProduction(EditProductionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditProductionHeaders headers = new EditProductionHeaders();
        return this.editProductionWithOptions(request, headers, runtime);
    }

    public EditProductionResponse editProductionWithOptions(EditProductionRequest request, EditProductionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditProduction", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/productions", "json", req, runtime), new EditProductionResponse());
    }

    public EditPurchaseResponse editPurchase(EditPurchaseRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditPurchaseHeaders headers = new EditPurchaseHeaders();
        return this.editPurchaseWithOptions(request, headers, runtime);
    }

    public EditPurchaseResponse editPurchaseWithOptions(EditPurchaseRequest request, EditPurchaseHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditPurchase", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/purchases", "json", req, runtime), new EditPurchaseResponse());
    }

    public EditQuotationRecordResponse editQuotationRecord(EditQuotationRecordRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditQuotationRecordHeaders headers = new EditQuotationRecordHeaders();
        return this.editQuotationRecordWithOptions(request, headers, runtime);
    }

    public EditQuotationRecordResponse editQuotationRecordWithOptions(EditQuotationRecordRequest request, EditQuotationRecordHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditQuotationRecord", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/quotationRecords", "json", req, runtime), new EditQuotationRecordResponse());
    }

    public EditSalesResponse editSales(EditSalesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        EditSalesHeaders headers = new EditSalesHeaders();
        return this.editSalesWithOptions(request, headers, runtime);
    }

    public EditSalesResponse editSalesWithOptions(EditSalesRequest request, EditSalesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.data))) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            body.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            body.put("msgid", request.msgid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.stamp)) {
            body.put("stamp", request.stamp);
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
        return TeaModel.toModel(this.doROARequest("EditSales", "jzcrm_1.0", "HTTP", "POST", "AK", "/v1.0/jzcrm/sales", "json", req, runtime), new EditSalesResponse());
    }

    public GetDataListResponse getDataList(GetDataListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDataListHeaders headers = new GetDataListHeaders();
        return this.getDataListWithOptions(request, headers, runtime);
    }

    public GetDataListResponse getDataListWithOptions(GetDataListRequest request, GetDataListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            query.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.page)) {
            query.put("page", request.page);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pagesize)) {
            query.put("pagesize", request.pagesize);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetDataList", "jzcrm_1.0", "HTTP", "GET", "AK", "/v1.0/jzcrm/data", "json", req, runtime), new GetDataListResponse());
    }

    public GetDataViewResponse getDataView(GetDataViewRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDataViewHeaders headers = new GetDataViewHeaders();
        return this.getDataViewWithOptions(request, headers, runtime);
    }

    public GetDataViewResponse getDataViewWithOptions(GetDataViewRequest request, GetDataViewHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datatype)) {
            query.put("datatype", request.datatype);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.msgid)) {
            query.put("msgid", request.msgid);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetDataView", "jzcrm_1.0", "HTTP", "GET", "AK", "/v1.0/jzcrm/dataView", "json", req, runtime), new GetDataViewResponse());
    }
}
