// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkalitrip_1_0.models.*;
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


    public ApproveCityCarApplyResponse approveCityCarApply(ApproveCityCarApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ApproveCityCarApplyHeaders headers = new ApproveCityCarApplyHeaders();
        return this.approveCityCarApplyWithOptions(request, headers, runtime);
    }

    public ApproveCityCarApplyResponse approveCityCarApplyWithOptions(ApproveCityCarApplyRequest request, ApproveCityCarApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateTime)) {
            body.put("operateTime", request.operateTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartApplyId)) {
            body.put("thirdPartApplyId", request.thirdPartApplyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
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
        return TeaModel.toModel(this.doROARequest("ApproveCityCarApply", "alitrip_1.0", "HTTP", "PUT", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime), new ApproveCityCarApplyResponse());
    }

    public BillSettementHotelResponse billSettementHotel(BillSettementHotelRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BillSettementHotelHeaders headers = new BillSettementHotelHeaders();
        return this.billSettementHotelWithOptions(request, headers, runtime);
    }

    public BillSettementHotelResponse billSettementHotelWithOptions(BillSettementHotelRequest request, BillSettementHotelHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
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
        return TeaModel.toModel(this.doROARequest("BillSettementHotel", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/billSettlements/hotels", "json", req, runtime), new BillSettementHotelResponse());
    }

    public GetFlightExceedApplyResponse getFlightExceedApply(GetFlightExceedApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFlightExceedApplyHeaders headers = new GetFlightExceedApplyHeaders();
        return this.getFlightExceedApplyWithOptions(request, headers, runtime);
    }

    public GetFlightExceedApplyResponse getFlightExceedApplyWithOptions(GetFlightExceedApplyRequest request, GetFlightExceedApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
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
        return TeaModel.toModel(this.doROARequest("GetFlightExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getFlight", "json", req, runtime), new GetFlightExceedApplyResponse());
    }

    public BillSettementCarResponse billSettementCar(BillSettementCarRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BillSettementCarHeaders headers = new BillSettementCarHeaders();
        return this.billSettementCarWithOptions(request, headers, runtime);
    }

    public BillSettementCarResponse billSettementCarWithOptions(BillSettementCarRequest request, BillSettementCarHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
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
        return TeaModel.toModel(this.doROARequest("BillSettementCar", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/billSettlements/cars", "json", req, runtime), new BillSettementCarResponse());
    }

    public BillSettementBtripTrainResponse billSettementBtripTrain(BillSettementBtripTrainRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BillSettementBtripTrainHeaders headers = new BillSettementBtripTrainHeaders();
        return this.billSettementBtripTrainWithOptions(request, headers, runtime);
    }

    public BillSettementBtripTrainResponse billSettementBtripTrainWithOptions(BillSettementBtripTrainRequest request, BillSettementBtripTrainHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
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
        return TeaModel.toModel(this.doROARequest("BillSettementBtripTrain", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/billSettlements/btripTrains", "json", req, runtime), new BillSettementBtripTrainResponse());
    }

    public SyncExceedApplyResponse syncExceedApply(SyncExceedApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SyncExceedApplyHeaders headers = new SyncExceedApplyHeaders();
        return this.syncExceedApplyWithOptions(request, headers, runtime);
    }

    public SyncExceedApplyResponse syncExceedApplyWithOptions(SyncExceedApplyRequest request, SyncExceedApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            query.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdpartyFlowId)) {
            query.put("thirdpartyFlowId", request.thirdpartyFlowId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
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
        return TeaModel.toModel(this.doROARequest("SyncExceedApply", "alitrip_1.0", "HTTP", "POST", "AK", "/v1.0/alitrip/exceedapply/sync", "json", req, runtime), new SyncExceedApplyResponse());
    }

    public AddCityCarApplyResponse addCityCarApply(AddCityCarApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddCityCarApplyHeaders headers = new AddCityCarApplyHeaders();
        return this.addCityCarApplyWithOptions(request, headers, runtime);
    }

    public AddCityCarApplyResponse addCityCarApplyWithOptions(AddCityCarApplyRequest request, AddCityCarApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cause)) {
            body.put("cause", request.cause);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.city)) {
            body.put("city", request.city);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.date)) {
            body.put("date", request.date);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectName)) {
            body.put("projectName", request.projectName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartApplyId)) {
            body.put("thirdPartApplyId", request.thirdPartApplyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartCostCenterId)) {
            body.put("thirdPartCostCenterId", request.thirdPartCostCenterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartInvoiceId)) {
            body.put("thirdPartInvoiceId", request.thirdPartInvoiceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timesTotal)) {
            body.put("timesTotal", request.timesTotal);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timesType)) {
            body.put("timesType", request.timesType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.timesUsed)) {
            body.put("timesUsed", request.timesUsed);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.finishedDate)) {
            body.put("finishedDate", request.finishedDate);
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
        return TeaModel.toModel(this.doROARequest("AddCityCarApply", "alitrip_1.0", "HTTP", "POST", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime), new AddCityCarApplyResponse());
    }

    public BillSettementFlightResponse billSettementFlight(BillSettementFlightRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BillSettementFlightHeaders headers = new BillSettementFlightHeaders();
        return this.billSettementFlightWithOptions(request, headers, runtime);
    }

    public BillSettementFlightResponse billSettementFlightWithOptions(BillSettementFlightRequest request, BillSettementFlightHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
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
        return TeaModel.toModel(this.doROARequest("BillSettementFlight", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/billSettlements/flights", "json", req, runtime), new BillSettementFlightResponse());
    }

    public GetHotelExceedApplyResponse getHotelExceedApply(GetHotelExceedApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetHotelExceedApplyHeaders headers = new GetHotelExceedApplyHeaders();
        return this.getHotelExceedApplyWithOptions(request, headers, runtime);
    }

    public GetHotelExceedApplyResponse getHotelExceedApplyWithOptions(GetHotelExceedApplyRequest request, GetHotelExceedApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
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
        return TeaModel.toModel(this.doROARequest("GetHotelExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getHotel", "json", req, runtime), new GetHotelExceedApplyResponse());
    }

    public QueryUnionOrderResponse queryUnionOrder(QueryUnionOrderRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUnionOrderHeaders headers = new QueryUnionOrderHeaders();
        return this.queryUnionOrderWithOptions(request, headers, runtime);
    }

    public QueryUnionOrderResponse queryUnionOrderWithOptions(QueryUnionOrderRequest request, QueryUnionOrderHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartApplyId)) {
            query.put("thirdPartApplyId", request.thirdPartApplyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionNo)) {
            query.put("unionNo", request.unionNo);
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
        return TeaModel.toModel(this.doROARequest("QueryUnionOrder", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/unionOrders", "json", req, runtime), new QueryUnionOrderResponse());
    }

    public QueryCityCarApplyResponse queryCityCarApply(QueryCityCarApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCityCarApplyHeaders headers = new QueryCityCarApplyHeaders();
        return this.queryCityCarApplyWithOptions(request, headers, runtime);
    }

    public QueryCityCarApplyResponse queryCityCarApplyWithOptions(QueryCityCarApplyRequest request, QueryCityCarApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createdEndAt)) {
            query.put("createdEndAt", request.createdEndAt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.createdStartAt)) {
            query.put("createdStartAt", request.createdStartAt);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdPartApplyId)) {
            query.put("thirdPartApplyId", request.thirdPartApplyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            query.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("QueryCityCarApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/cityCarApprovals", "json", req, runtime), new QueryCityCarApplyResponse());
    }

    public GetTrainExceedApplyResponse getTrainExceedApply(GetTrainExceedApplyRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTrainExceedApplyHeaders headers = new GetTrainExceedApplyHeaders();
        return this.getTrainExceedApplyWithOptions(request, headers, runtime);
    }

    public GetTrainExceedApplyResponse getTrainExceedApplyWithOptions(GetTrainExceedApplyRequest request, GetTrainExceedApplyHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
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
        return TeaModel.toModel(this.doROARequest("GetTrainExceedApply", "alitrip_1.0", "HTTP", "GET", "AK", "/v1.0/alitrip/exceedapply/getTrain", "json", req, runtime), new GetTrainExceedApplyResponse());
    }
}
