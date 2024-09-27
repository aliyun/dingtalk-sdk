// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkjzcrm_1_0.models.*;

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
     * <p>编辑联系人数据</p>
     * 
     * @param request EditContactRequest
     * @param headers EditContactHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditContactResponse
     */
    public EditContactResponse editContactWithOptions(EditContactRequest request, EditContactHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditContact"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/contacts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditContactResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑联系人数据</p>
     * 
     * @param request EditContactRequest
     * @return EditContactResponse
     */
    public EditContactResponse editContact(EditContactRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditContactHeaders headers = new EditContactHeaders();
        return this.editContactWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑客户数据</p>
     * 
     * @param request EditCustomerRequest
     * @param headers EditCustomerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditCustomerResponse
     */
    public EditCustomerResponse editCustomerWithOptions(EditCustomerRequest request, EditCustomerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditCustomer"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/customers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditCustomerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑客户数据</p>
     * 
     * @param request EditCustomerRequest
     * @return EditCustomerResponse
     */
    public EditCustomerResponse editCustomer(EditCustomerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditCustomerHeaders headers = new EditCustomerHeaders();
        return this.editCustomerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑客户公共池数据</p>
     * 
     * @param request EditCustomerPoolRequest
     * @param headers EditCustomerPoolHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditCustomerPoolResponse
     */
    public EditCustomerPoolResponse editCustomerPoolWithOptions(EditCustomerPoolRequest request, EditCustomerPoolHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditCustomerPool"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/customerPools"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditCustomerPoolResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑客户公共池数据</p>
     * 
     * @param request EditCustomerPoolRequest
     * @return EditCustomerPoolResponse
     */
    public EditCustomerPoolResponse editCustomerPool(EditCustomerPoolRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditCustomerPoolHeaders headers = new EditCustomerPoolHeaders();
        return this.editCustomerPoolWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑销售换货单数据</p>
     * 
     * @param request EditExchangeRequest
     * @param headers EditExchangeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditExchangeResponse
     */
    public EditExchangeResponse editExchangeWithOptions(EditExchangeRequest request, EditExchangeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditExchange"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/exchanges"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditExchangeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑销售换货单数据</p>
     * 
     * @param request EditExchangeRequest
     * @return EditExchangeResponse
     */
    public EditExchangeResponse editExchange(EditExchangeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditExchangeHeaders headers = new EditExchangeHeaders();
        return this.editExchangeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑产品数据</p>
     * 
     * @param request EditGoodsRequest
     * @param headers EditGoodsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditGoodsResponse
     */
    public EditGoodsResponse editGoodsWithOptions(EditGoodsRequest request, EditGoodsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditGoods"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/goods"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditGoodsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑产品数据</p>
     * 
     * @param request EditGoodsRequest
     * @return EditGoodsResponse
     */
    public EditGoodsResponse editGoods(EditGoodsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditGoodsHeaders headers = new EditGoodsHeaders();
        return this.editGoodsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑入库单数据</p>
     * 
     * @param request EditIntostockRequest
     * @param headers EditIntostockHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditIntostockResponse
     */
    public EditIntostockResponse editIntostockWithOptions(EditIntostockRequest request, EditIntostockHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditIntostock"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/intostocks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditIntostockResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑入库单数据</p>
     * 
     * @param request EditIntostockRequest
     * @return EditIntostockResponse
     */
    public EditIntostockResponse editIntostock(EditIntostockRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditIntostockHeaders headers = new EditIntostockHeaders();
        return this.editIntostockWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑发货单数据</p>
     * 
     * @param request EditInvoiceRequest
     * @param headers EditInvoiceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditInvoiceResponse
     */
    public EditInvoiceResponse editInvoiceWithOptions(EditInvoiceRequest request, EditInvoiceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditInvoice"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/invoices"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditInvoiceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑发货单数据</p>
     * 
     * @param request EditInvoiceRequest
     * @return EditInvoiceResponse
     */
    public EditInvoiceResponse editInvoice(EditInvoiceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditInvoiceHeaders headers = new EditInvoiceHeaders();
        return this.editInvoiceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑合同订单数据</p>
     * 
     * @param request EditOrderRequest
     * @param headers EditOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditOrderResponse
     */
    public EditOrderResponse editOrderWithOptions(EditOrderRequest request, EditOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditOrder"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/orders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑合同订单数据</p>
     * 
     * @param request EditOrderRequest
     * @return EditOrderResponse
     */
    public EditOrderResponse editOrder(EditOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditOrderHeaders headers = new EditOrderHeaders();
        return this.editOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑出库单信息</p>
     * 
     * @param request EditOutstockRequest
     * @param headers EditOutstockHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditOutstockResponse
     */
    public EditOutstockResponse editOutstockWithOptions(EditOutstockRequest request, EditOutstockHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditOutstock"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/outstocks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditOutstockResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑出库单信息</p>
     * 
     * @param request EditOutstockRequest
     * @return EditOutstockResponse
     */
    public EditOutstockResponse editOutstock(EditOutstockRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditOutstockHeaders headers = new EditOutstockHeaders();
        return this.editOutstockWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑生产单数据</p>
     * 
     * @param request EditProductionRequest
     * @param headers EditProductionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditProductionResponse
     */
    public EditProductionResponse editProductionWithOptions(EditProductionRequest request, EditProductionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditProduction"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/productions"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditProductionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑生产单数据</p>
     * 
     * @param request EditProductionRequest
     * @return EditProductionResponse
     */
    public EditProductionResponse editProduction(EditProductionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditProductionHeaders headers = new EditProductionHeaders();
        return this.editProductionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑采购单数据</p>
     * 
     * @param request EditPurchaseRequest
     * @param headers EditPurchaseHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditPurchaseResponse
     */
    public EditPurchaseResponse editPurchaseWithOptions(EditPurchaseRequest request, EditPurchaseHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditPurchase"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/purchases"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditPurchaseResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑采购单数据</p>
     * 
     * @param request EditPurchaseRequest
     * @return EditPurchaseResponse
     */
    public EditPurchaseResponse editPurchase(EditPurchaseRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditPurchaseHeaders headers = new EditPurchaseHeaders();
        return this.editPurchaseWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑报价记录数据</p>
     * 
     * @param request EditQuotationRecordRequest
     * @param headers EditQuotationRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditQuotationRecordResponse
     */
    public EditQuotationRecordResponse editQuotationRecordWithOptions(EditQuotationRecordRequest request, EditQuotationRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditQuotationRecord"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/quotationRecords"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditQuotationRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑报价记录数据</p>
     * 
     * @param request EditQuotationRecordRequest
     * @return EditQuotationRecordResponse
     */
    public EditQuotationRecordResponse editQuotationRecord(EditQuotationRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditQuotationRecordHeaders headers = new EditQuotationRecordHeaders();
        return this.editQuotationRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑销售机会数据</p>
     * 
     * @param request EditSalesRequest
     * @param headers EditSalesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return EditSalesResponse
     */
    public EditSalesResponse editSalesWithOptions(EditSalesRequest request, EditSalesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "EditSales"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/sales"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new EditSalesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑销售机会数据</p>
     * 
     * @param request EditSalesRequest
     * @return EditSalesResponse
     */
    public EditSalesResponse editSales(EditSalesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        EditSalesHeaders headers = new EditSalesHeaders();
        return this.editSalesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取数据列表</p>
     * 
     * @param request GetDataListRequest
     * @param headers GetDataListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDataListResponse
     */
    public GetDataListResponse getDataListWithOptions(GetDataListRequest request, GetDataListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetDataList"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/data"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDataListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取数据列表</p>
     * 
     * @param request GetDataListRequest
     * @return GetDataListResponse
     */
    public GetDataListResponse getDataList(GetDataListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDataListHeaders headers = new GetDataListHeaders();
        return this.getDataListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取数据详情</p>
     * 
     * @param request GetDataViewRequest
     * @param headers GetDataViewHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDataViewResponse
     */
    public GetDataViewResponse getDataViewWithOptions(GetDataViewRequest request, GetDataViewHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetDataView"),
            new TeaPair("version", "jzcrm_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/jzcrm/dataView"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDataViewResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取数据详情</p>
     * 
     * @param request GetDataViewRequest
     * @return GetDataViewResponse
     */
    public GetDataViewResponse getDataView(GetDataViewRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDataViewHeaders headers = new GetDataViewHeaders();
        return this.getDataViewWithOptions(request, headers, runtime);
    }
}
