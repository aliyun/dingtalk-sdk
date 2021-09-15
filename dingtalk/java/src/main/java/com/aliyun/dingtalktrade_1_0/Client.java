// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalktrade_1_0.models.*;
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


    public QueryTradeOrderResponse queryTradeOrder(QueryTradeOrderRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryTradeOrderHeaders headers = new QueryTradeOrderHeaders();
        return this.queryTradeOrderWithOptions(request, headers, runtime);
    }

    public QueryTradeOrderResponse queryTradeOrderWithOptions(QueryTradeOrderRequest request, QueryTradeOrderHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.outerOrderId)) {
            body.put("outerOrderId", request.outerOrderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
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
        return TeaModel.toModel(this.doROARequest("QueryTradeOrder", "trade_1.0", "HTTP", "POST", "AK", "/v1.0/trade/orders/query", "json", req, runtime), new QueryTradeOrderResponse());
    }

    public CreateOpportunityResponse createOpportunity(CreateOpportunityRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateOpportunityHeaders headers = new CreateOpportunityHeaders();
        return this.createOpportunityWithOptions(request, headers, runtime);
    }

    public CreateOpportunityResponse createOpportunityWithOptions(CreateOpportunityRequest request, CreateOpportunityHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.belongToPhoneNum)) {
            body.put("belongToPhoneNum", request.belongToPhoneNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactPhoneNum)) {
            body.put("contactPhoneNum", request.contactPhoneNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.marketCode)) {
            body.put("marketCode", request.marketCode);
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
        return TeaModel.toModel(this.doROARequest("CreateOpportunity", "trade_1.0", "HTTP", "POST", "AK", "/v1.0/trade/opportunities", "none", req, runtime), new CreateOpportunityResponse());
    }

    public CheckOpportunityResultResponse checkOpportunityResult(CheckOpportunityResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CheckOpportunityResultHeaders headers = new CheckOpportunityResultHeaders();
        return this.checkOpportunityResultWithOptions(request, headers, runtime);
    }

    public CheckOpportunityResultResponse checkOpportunityResultWithOptions(CheckOpportunityResultRequest request, CheckOpportunityResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.belongToPhoneNum)) {
            query.put("belongToPhoneNum", request.belongToPhoneNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.contactPhoneNum)) {
            query.put("contactPhoneNum", request.contactPhoneNum);
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("CheckOpportunityResult", "trade_1.0", "HTTP", "GET", "AK", "/v1.0/trade/opportunity/check", "json", req, runtime), new CheckOpportunityResultResponse());
    }
}
