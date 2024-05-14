// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktrade_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public com.aliyun.gateway.spi.Client _client;
    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._client = new com.aliyun.gateway.dingtalk.Client();
        this._spi = _client;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * @summary isv检查商机创建是否符合预期
     *
     * @param request CheckOpportunityResultRequest
     * @param headers CheckOpportunityResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CheckOpportunityResultResponse
     */
    public CheckOpportunityResultResponse checkOpportunityResultWithOptions(CheckOpportunityResultRequest request, CheckOpportunityResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.belongToPhoneNum)) {
            query.put("belongToPhoneNum", request.belongToPhoneNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactPhoneNum)) {
            query.put("contactPhoneNum", request.contactPhoneNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.marketCode)) {
            query.put("marketCode", request.marketCode);
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
            new TeaPair("action", "CheckOpportunityResult"),
            new TeaPair("version", "trade_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trade/opportunity/check"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CheckOpportunityResultResponse());
    }

    /**
     * @summary isv检查商机创建是否符合预期
     *
     * @param request CheckOpportunityResultRequest
     * @return CheckOpportunityResultResponse
     */
    public CheckOpportunityResultResponse checkOpportunityResult(CheckOpportunityResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CheckOpportunityResultHeaders headers = new CheckOpportunityResultHeaders();
        return this.checkOpportunityResultWithOptions(request, headers, runtime);
    }

    /**
     * @summary isv创建商机
     *
     * @param request CreateOpportunityRequest
     * @param headers CreateOpportunityHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateOpportunityResponse
     */
    public CreateOpportunityResponse createOpportunityWithOptions(CreateOpportunityRequest request, CreateOpportunityHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.belongToPhoneNum)) {
            body.put("belongToPhoneNum", request.belongToPhoneNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactPhoneNum)) {
            body.put("contactPhoneNum", request.contactPhoneNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.marketCode)) {
            body.put("marketCode", request.marketCode);
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
            new TeaPair("action", "CreateOpportunity"),
            new TeaPair("version", "trade_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trade/opportunities"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateOpportunityResponse());
    }

    /**
     * @summary isv创建商机
     *
     * @param request CreateOpportunityRequest
     * @return CreateOpportunityResponse
     */
    public CreateOpportunityResponse createOpportunity(CreateOpportunityRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateOpportunityHeaders headers = new CreateOpportunityHeaders();
        return this.createOpportunityWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询订单信息
     *
     * @param request QueryTradeOrderRequest
     * @param headers QueryTradeOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryTradeOrderResponse
     */
    public QueryTradeOrderResponse queryTradeOrderWithOptions(QueryTradeOrderRequest request, QueryTradeOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outerOrderId)) {
            body.put("outerOrderId", request.outerOrderId);
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
            new TeaPair("action", "QueryTradeOrder"),
            new TeaPair("version", "trade_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/trade/orders/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryTradeOrderResponse());
    }

    /**
     * @summary 查询订单信息
     *
     * @param request QueryTradeOrderRequest
     * @return QueryTradeOrderResponse
     */
    public QueryTradeOrderResponse queryTradeOrder(QueryTradeOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryTradeOrderHeaders headers = new QueryTradeOrderHeaders();
        return this.queryTradeOrderWithOptions(request, headers, runtime);
    }
}
