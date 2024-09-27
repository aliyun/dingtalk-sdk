// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkalitrip_1_0.models.*;

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
     * <p>同步第三方市内用车申请单</p>
     * 
     * @param request AddCityCarApplyRequest
     * @param headers AddCityCarApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCityCarApplyResponse
     */
    public AddCityCarApplyResponse addCityCarApplyWithOptions(AddCityCarApplyRequest request, AddCityCarApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.finishedDate)) {
            body.put("finishedDate", request.finishedDate);
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
            new TeaPair("action", "AddCityCarApply"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/cityCarApprovals"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCityCarApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>同步第三方市内用车申请单</p>
     * 
     * @param request AddCityCarApplyRequest
     * @return AddCityCarApplyResponse
     */
    public AddCityCarApplyResponse addCityCarApply(AddCityCarApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCityCarApplyHeaders headers = new AddCityCarApplyHeaders();
        return this.addCityCarApplyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>三方市内用车申请单审批</p>
     * 
     * @param request ApproveCityCarApplyRequest
     * @param headers ApproveCityCarApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ApproveCityCarApplyResponse
     */
    public ApproveCityCarApplyResponse approveCityCarApplyWithOptions(ApproveCityCarApplyRequest request, ApproveCityCarApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ApproveCityCarApply"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/cityCarApprovals"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ApproveCityCarApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>三方市内用车申请单审批</p>
     * 
     * @param request ApproveCityCarApplyRequest
     * @return ApproveCityCarApplyResponse
     */
    public ApproveCityCarApplyResponse approveCityCarApply(ApproveCityCarApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ApproveCityCarApplyHeaders headers = new ApproveCityCarApplyHeaders();
        return this.approveCityCarApplyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>商旅火车票结算记账查询接口</p>
     * 
     * @param request BillSettementBtripTrainRequest
     * @param headers BillSettementBtripTrainHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BillSettementBtripTrainResponse
     */
    public BillSettementBtripTrainResponse billSettementBtripTrainWithOptions(BillSettementBtripTrainRequest request, BillSettementBtripTrainHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
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
            new TeaPair("action", "BillSettementBtripTrain"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/billSettlements/btripTrains"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BillSettementBtripTrainResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>商旅火车票结算记账查询接口</p>
     * 
     * @param request BillSettementBtripTrainRequest
     * @return BillSettementBtripTrainResponse
     */
    public BillSettementBtripTrainResponse billSettementBtripTrain(BillSettementBtripTrainRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BillSettementBtripTrainHeaders headers = new BillSettementBtripTrainHeaders();
        return this.billSettementBtripTrainWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>用车结算记账查询接口</p>
     * 
     * @param request BillSettementCarRequest
     * @param headers BillSettementCarHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BillSettementCarResponse
     */
    public BillSettementCarResponse billSettementCarWithOptions(BillSettementCarRequest request, BillSettementCarHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
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
            new TeaPair("action", "BillSettementCar"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/billSettlements/cars"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BillSettementCarResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>用车结算记账查询接口</p>
     * 
     * @param request BillSettementCarRequest
     * @return BillSettementCarResponse
     */
    public BillSettementCarResponse billSettementCar(BillSettementCarRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BillSettementCarHeaders headers = new BillSettementCarHeaders();
        return this.billSettementCarWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>机票结算记账查询接口</p>
     * 
     * @param request BillSettementFlightRequest
     * @param headers BillSettementFlightHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BillSettementFlightResponse
     */
    public BillSettementFlightResponse billSettementFlightWithOptions(BillSettementFlightRequest request, BillSettementFlightHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
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
            new TeaPair("action", "BillSettementFlight"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/billSettlements/flights"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BillSettementFlightResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>机票结算记账查询接口</p>
     * 
     * @param request BillSettementFlightRequest
     * @return BillSettementFlightResponse
     */
    public BillSettementFlightResponse billSettementFlight(BillSettementFlightRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BillSettementFlightHeaders headers = new BillSettementFlightHeaders();
        return this.billSettementFlightWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>酒店结算记账查询接口</p>
     * 
     * @param request BillSettementHotelRequest
     * @param headers BillSettementHotelHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BillSettementHotelResponse
     */
    public BillSettementHotelResponse billSettementHotelWithOptions(BillSettementHotelRequest request, BillSettementHotelHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            query.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodEnd)) {
            query.put("periodEnd", request.periodEnd);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodStart)) {
            query.put("periodStart", request.periodStart);
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
            new TeaPair("action", "BillSettementHotel"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/billSettlements/hotels"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BillSettementHotelResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>酒店结算记账查询接口</p>
     * 
     * @param request BillSettementHotelRequest
     * @return BillSettementHotelResponse
     */
    public BillSettementHotelResponse billSettementHotel(BillSettementHotelRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BillSettementHotelHeaders headers = new BillSettementHotelHeaders();
        return this.billSettementHotelWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>商旅机票第三方超标审批单搜索接口</p>
     * 
     * @param request GetFlightExceedApplyRequest
     * @param headers GetFlightExceedApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFlightExceedApplyResponse
     */
    public GetFlightExceedApplyResponse getFlightExceedApplyWithOptions(GetFlightExceedApplyRequest request, GetFlightExceedApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
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
            new TeaPair("action", "GetFlightExceedApply"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/exceedapply/getFlight"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFlightExceedApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>商旅机票第三方超标审批单搜索接口</p>
     * 
     * @param request GetFlightExceedApplyRequest
     * @return GetFlightExceedApplyResponse
     */
    public GetFlightExceedApplyResponse getFlightExceedApply(GetFlightExceedApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFlightExceedApplyHeaders headers = new GetFlightExceedApplyHeaders();
        return this.getFlightExceedApplyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>搜索酒店超标审批单</p>
     * 
     * @param request GetHotelExceedApplyRequest
     * @param headers GetHotelExceedApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetHotelExceedApplyResponse
     */
    public GetHotelExceedApplyResponse getHotelExceedApplyWithOptions(GetHotelExceedApplyRequest request, GetHotelExceedApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
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
            new TeaPair("action", "GetHotelExceedApply"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/exceedapply/getHotel"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetHotelExceedApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>搜索酒店超标审批单</p>
     * 
     * @param request GetHotelExceedApplyRequest
     * @return GetHotelExceedApplyResponse
     */
    public GetHotelExceedApplyResponse getHotelExceedApply(GetHotelExceedApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetHotelExceedApplyHeaders headers = new GetHotelExceedApplyHeaders();
        return this.getHotelExceedApplyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>商旅火车票第三方超标审批单搜索接口</p>
     * 
     * @param request GetTrainExceedApplyRequest
     * @param headers GetTrainExceedApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTrainExceedApplyResponse
     */
    public GetTrainExceedApplyResponse getTrainExceedApplyWithOptions(GetTrainExceedApplyRequest request, GetTrainExceedApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
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
            new TeaPair("action", "GetTrainExceedApply"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/exceedapply/getTrain"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTrainExceedApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>商旅火车票第三方超标审批单搜索接口</p>
     * 
     * @param request GetTrainExceedApplyRequest
     * @return GetTrainExceedApplyResponse
     */
    public GetTrainExceedApplyResponse getTrainExceedApply(GetTrainExceedApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTrainExceedApplyHeaders headers = new GetTrainExceedApplyHeaders();
        return this.getTrainExceedApplyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>三方市内用车申请单查询</p>
     * 
     * @param request QueryCityCarApplyRequest
     * @param headers QueryCityCarApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCityCarApplyResponse
     */
    public QueryCityCarApplyResponse queryCityCarApplyWithOptions(QueryCityCarApplyRequest request, QueryCityCarApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryCityCarApply"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/cityCarApprovals"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCityCarApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>三方市内用车申请单查询</p>
     * 
     * @param request QueryCityCarApplyRequest
     * @return QueryCityCarApplyResponse
     */
    public QueryCityCarApplyResponse queryCityCarApply(QueryCityCarApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCityCarApplyHeaders headers = new QueryCityCarApplyHeaders();
        return this.queryCityCarApplyWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>申请单关联单号查询相关订单信息</p>
     * 
     * @param request QueryUnionOrderRequest
     * @param headers QueryUnionOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUnionOrderResponse
     */
    public QueryUnionOrderResponse queryUnionOrderWithOptions(QueryUnionOrderRequest request, QueryUnionOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryUnionOrder"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/unionOrders"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUnionOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>申请单关联单号查询相关订单信息</p>
     * 
     * @param request QueryUnionOrderRequest
     * @return QueryUnionOrderResponse
     */
    public QueryUnionOrderResponse queryUnionOrder(QueryUnionOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUnionOrderHeaders headers = new QueryUnionOrderHeaders();
        return this.queryUnionOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>同步超标审批结果</p>
     * 
     * @param request SyncExceedApplyRequest
     * @param headers SyncExceedApplyHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SyncExceedApplyResponse
     */
    public SyncExceedApplyResponse syncExceedApplyWithOptions(SyncExceedApplyRequest request, SyncExceedApplyHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.applyId)) {
            query.put("applyId", request.applyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            query.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            query.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            query.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.thirdpartyFlowId)) {
            query.put("thirdpartyFlowId", request.thirdpartyFlowId);
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
            new TeaPair("action", "SyncExceedApply"),
            new TeaPair("version", "alitrip_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/alitrip/exceedapply/sync"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SyncExceedApplyResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>同步超标审批结果</p>
     * 
     * @param request SyncExceedApplyRequest
     * @return SyncExceedApplyResponse
     */
    public SyncExceedApplyResponse syncExceedApply(SyncExceedApplyRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SyncExceedApplyHeaders headers = new SyncExceedApplyHeaders();
        return this.syncExceedApplyWithOptions(request, headers, runtime);
    }
}
