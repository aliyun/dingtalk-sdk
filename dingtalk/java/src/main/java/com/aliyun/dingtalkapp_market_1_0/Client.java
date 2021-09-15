// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkapp_market_1_0.models.*;
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


    public CreateAppGoodsServiceConversationResponse createAppGoodsServiceConversation(CreateAppGoodsServiceConversationRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
        return this.createAppGoodsServiceConversationWithOptions(request, headers, runtime);
    }

    public CreateAppGoodsServiceConversationResponse createAppGoodsServiceConversationWithOptions(CreateAppGoodsServiceConversationRequest request, CreateAppGoodsServiceConversationHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvUserId)) {
            body.put("isvUserId", request.isvUserId);
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
        return TeaModel.toModel(this.doROARequest("CreateAppGoodsServiceConversation", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/orders/serviceGroups", "json", req, runtime), new CreateAppGoodsServiceConversationResponse());
    }

    public QueryMarketOrderResponse queryMarketOrder(String orderId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
        return this.queryMarketOrderWithOptions(orderId, headers, runtime);
    }

    public QueryMarketOrderResponse queryMarketOrderWithOptions(String orderId, QueryMarketOrderHeaders headers, RuntimeOptions runtime) throws Exception {
        orderId = com.aliyun.openapiutil.Client.getEncodeParam(orderId);
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
        return TeaModel.toModel(this.doROARequest("QueryMarketOrder", "appMarket_1.0", "HTTP", "GET", "AK", "/v1.0/appMarket/orders/" + orderId + "", "json", req, runtime), new QueryMarketOrderResponse());
    }

    public UserTaskReportResponse userTaskReport(UserTaskReportRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UserTaskReportHeaders headers = new UserTaskReportHeaders();
        return this.userTaskReportWithOptions(request, headers, runtime);
    }

    public UserTaskReportResponse userTaskReportWithOptions(UserTaskReportRequest request, UserTaskReportHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingCorpId)) {
            body.put("dingCorpId", request.dingCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskTag)) {
            body.put("taskTag", request.taskTag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateDate)) {
            body.put("operateDate", request.operateDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizNo)) {
            body.put("bizNo", request.bizNo);
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
        return TeaModel.toModel(this.doROARequest("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/tasks", "boolean", req, runtime), new UserTaskReportResponse());
    }

    public GetPersonalExperienceInfoResponse getPersonalExperienceInfo(GetPersonalExperienceInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
        return this.getPersonalExperienceInfoWithOptions(request, headers, runtime);
    }

    public GetPersonalExperienceInfoResponse getPersonalExperienceInfoWithOptions(GetPersonalExperienceInfoRequest request, GetPersonalExperienceInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetPersonalExperienceInfo", "appMarket_1.0", "HTTP", "GET", "AK", "/v1.0/appMarket/personalExperiences", "json", req, runtime), new GetPersonalExperienceInfoResponse());
    }
}
