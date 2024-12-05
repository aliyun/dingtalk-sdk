// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkapp_market_1_0.models.*;

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
     * <p>创建应用商品服务群</p>
     * 
     * @param request CreateAppGoodsServiceConversationRequest
     * @param headers CreateAppGoodsServiceConversationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateAppGoodsServiceConversationResponse
     */
    public CreateAppGoodsServiceConversationResponse createAppGoodsServiceConversationWithOptions(CreateAppGoodsServiceConversationRequest request, CreateAppGoodsServiceConversationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isvUserId)) {
            body.put("isvUserId", request.isvUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderId)) {
            body.put("orderId", request.orderId);
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
            new TeaPair("action", "CreateAppGoodsServiceConversation"),
            new TeaPair("version", "appMarket_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/appMarket/orders/serviceGroups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateAppGoodsServiceConversationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建应用商品服务群</p>
     * 
     * @param request CreateAppGoodsServiceConversationRequest
     * @return CreateAppGoodsServiceConversationResponse
     */
    public CreateAppGoodsServiceConversationResponse createAppGoodsServiceConversation(CreateAppGoodsServiceConversationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
        return this.createAppGoodsServiceConversationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取酷应用访问状态</p>
     * 
     * @param request GetCoolAppAccessStatusRequest
     * @param headers GetCoolAppAccessStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCoolAppAccessStatusResponse
     */
    public GetCoolAppAccessStatusResponse getCoolAppAccessStatusWithOptions(GetCoolAppAccessStatusRequest request, GetCoolAppAccessStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authCode)) {
            body.put("authCode", request.authCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.coolAppCode)) {
            body.put("coolAppCode", request.coolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.encFieldBizCode)) {
            body.put("encFieldBizCode", request.encFieldBizCode);
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
            new TeaPair("action", "GetCoolAppAccessStatus"),
            new TeaPair("version", "appMarket_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/appMarket/coolApps/accessions/statuses/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCoolAppAccessStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取酷应用访问状态</p>
     * 
     * @param request GetCoolAppAccessStatusRequest
     * @return GetCoolAppAccessStatusResponse
     */
    public GetCoolAppAccessStatusResponse getCoolAppAccessStatus(GetCoolAppAccessStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCoolAppAccessStatusHeaders headers = new GetCoolAppAccessStatusHeaders();
        return this.getCoolAppAccessStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取内购商品SKU页面地址</p>
     * 
     * @param request GetInAppSkuUrlRequest
     * @param headers GetInAppSkuUrlHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetInAppSkuUrlResponse
     */
    public GetInAppSkuUrlResponse getInAppSkuUrlWithOptions(GetInAppSkuUrlRequest request, GetInAppSkuUrlHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.callbackPage)) {
            body.put("callbackPage", request.callbackPage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendParam)) {
            body.put("extendParam", request.extendParam);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.goodsCode)) {
            body.put("goodsCode", request.goodsCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.itemCode)) {
            body.put("itemCode", request.itemCode);
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
            new TeaPair("action", "GetInAppSkuUrl"),
            new TeaPair("version", "appMarket_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/appMarket/internals/skuPages/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetInAppSkuUrlResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取内购商品SKU页面地址</p>
     * 
     * @param request GetInAppSkuUrlRequest
     * @return GetInAppSkuUrlResponse
     */
    public GetInAppSkuUrlResponse getInAppSkuUrl(GetInAppSkuUrlRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetInAppSkuUrlHeaders headers = new GetInAppSkuUrlHeaders();
        return this.getInAppSkuUrlWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取个人体验相关信息</p>
     * 
     * @param request GetPersonalExperienceInfoRequest
     * @param headers GetPersonalExperienceInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPersonalExperienceInfoResponse
     */
    public GetPersonalExperienceInfoResponse getPersonalExperienceInfoWithOptions(GetPersonalExperienceInfoRequest request, GetPersonalExperienceInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetPersonalExperienceInfo"),
            new TeaPair("version", "appMarket_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/appMarket/personalExperiences"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPersonalExperienceInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取个人体验相关信息</p>
     * 
     * @param request GetPersonalExperienceInfoRequest
     * @return GetPersonalExperienceInfoResponse
     */
    public GetPersonalExperienceInfoResponse getPersonalExperienceInfo(GetPersonalExperienceInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
        return this.getPersonalExperienceInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>销售助理CRM数据变更回调通知</p>
     * 
     * @param request NotifyOnCrmDataChangeRequest
     * @param headers NotifyOnCrmDataChangeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return NotifyOnCrmDataChangeResponse
     */
    public NotifyOnCrmDataChangeResponse notifyOnCrmDataChangeWithOptions(NotifyOnCrmDataChangeRequest request, NotifyOnCrmDataChangeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dataId)) {
            body.put("dataId", request.dataId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extension)) {
            body.put("extension", request.extension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operate)) {
            body.put("operate", request.operate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
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
            new TeaPair("action", "NotifyOnCrmDataChange"),
            new TeaPair("version", "appMarket_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/appMarket/saleAssistants/crmDataChanges/notify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new NotifyOnCrmDataChangeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>销售助理CRM数据变更回调通知</p>
     * 
     * @param request NotifyOnCrmDataChangeRequest
     * @return NotifyOnCrmDataChangeResponse
     */
    public NotifyOnCrmDataChangeResponse notifyOnCrmDataChange(NotifyOnCrmDataChangeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        NotifyOnCrmDataChangeHeaders headers = new NotifyOnCrmDataChangeHeaders();
        return this.notifyOnCrmDataChangeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>应用市场订单查询</p>
     * 
     * @param headers QueryMarketOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMarketOrderResponse
     */
    public QueryMarketOrderResponse queryMarketOrderWithOptions(String orderId, QueryMarketOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryMarketOrder"),
            new TeaPair("version", "appMarket_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/appMarket/orders/" + orderId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMarketOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>应用市场订单查询</p>
     * @return QueryMarketOrderResponse
     */
    public QueryMarketOrderResponse queryMarketOrder(String orderId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
        return this.queryMarketOrderWithOptions(orderId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>app内用户操作任务同步</p>
     * 
     * @param request UserTaskReportRequest
     * @param headers UserTaskReportHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UserTaskReportResponse
     */
    public UserTaskReportResponse userTaskReportWithOptions(UserTaskReportRequest request, UserTaskReportHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizNo)) {
            body.put("bizNo", request.bizNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateDate)) {
            body.put("operateDate", request.operateDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskTag)) {
            body.put("taskTag", request.taskTag);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userid)) {
            body.put("userid", request.userid);
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
            new TeaPair("action", "UserTaskReport"),
            new TeaPair("version", "appMarket_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/appMarket/tasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "boolean")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UserTaskReportResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>app内用户操作任务同步</p>
     * 
     * @param request UserTaskReportRequest
     * @return UserTaskReportResponse
     */
    public UserTaskReportResponse userTaskReport(UserTaskReportRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UserTaskReportHeaders headers = new UserTaskReportHeaders();
        return this.userTaskReportWithOptions(request, headers, runtime);
    }
}
