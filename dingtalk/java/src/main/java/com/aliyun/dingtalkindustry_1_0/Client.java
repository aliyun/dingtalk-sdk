// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkindustry_1_0.models.*;

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
     * <p>批量查询任务结果</p>
     * 
     * @param request BatchGetTaskResultRequest
     * @param headers BatchGetTaskResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BatchGetTaskResultResponse
     */
    public BatchGetTaskResultResponse batchGetTaskResultWithOptions(BatchGetTaskResultRequest request, BatchGetTaskResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskIds)) {
            body.put("taskIds", request.taskIds);
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
            new TeaPair("action", "BatchGetTaskResult"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/ai/taskResults/batchQuery"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BatchGetTaskResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量查询任务结果</p>
     * 
     * @param request BatchGetTaskResultRequest
     * @return BatchGetTaskResultResponse
     */
    public BatchGetTaskResultResponse batchGetTaskResult(BatchGetTaskResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BatchGetTaskResultHeaders headers = new BatchGetTaskResultHeaders();
        return this.batchGetTaskResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>商机匹配</p>
     * 
     * @param request BusinessMatchRequest
     * @param headers BusinessMatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BusinessMatchResponse
     */
    public BusinessMatchResponse businessMatchWithOptions(BusinessMatchRequest request, BusinessMatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.businessInfo)) {
            body.put("businessInfo", request.businessInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpName)) {
            body.put("corpName", request.corpName);
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
            new TeaPair("action", "BusinessMatch"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/me/businesses/matching"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BusinessMatchResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>商机匹配</p>
     * 
     * @param request BusinessMatchRequest
     * @return BusinessMatchResponse
     */
    public BusinessMatchResponse businessMatch(BusinessMatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BusinessMatchHeaders headers = new BusinessMatchHeaders();
        return this.businessMatchWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>商机匹配结果查询</p>
     * 
     * @param request BusinessMatchResultRequest
     * @param headers BusinessMatchResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return BusinessMatchResultResponse
     */
    public BusinessMatchResultResponse businessMatchResultWithOptions(BusinessMatchResultRequest request, BusinessMatchResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.taskId)) {
            query.put("taskId", request.taskId);
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
            new TeaPair("action", "BusinessMatchResult"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/me/businesses/matchingResults"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new BusinessMatchResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>商机匹配结果查询</p>
     * 
     * @param request BusinessMatchResultRequest
     * @return BusinessMatchResultResponse
     */
    public BusinessMatchResultResponse businessMatchResult(BusinessMatchResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        BusinessMatchResultHeaders headers = new BusinessMatchResultHeaders();
        return this.businessMatchResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加租客下成员</p>
     * 
     * @param request CampusAddRenterMemberRequest
     * @param headers CampusAddRenterMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusAddRenterMemberResponse
     */
    public CampusAddRenterMemberResponse campusAddRenterMemberWithOptions(CampusAddRenterMemberRequest request, CampusAddRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            body.put("renterId", request.renterId);
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
            new TeaPair("action", "CampusAddRenterMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusAddRenterMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加租客下成员</p>
     * 
     * @param request CampusAddRenterMemberRequest
     * @return CampusAddRenterMemberResponse
     */
    public CampusAddRenterMemberResponse campusAddRenterMember(CampusAddRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusAddRenterMemberHeaders headers = new CampusAddRenterMemberHeaders();
        return this.campusAddRenterMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建园区</p>
     * 
     * @param request CampusCreateCampusRequest
     * @param headers CampusCreateCampusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusCreateCampusResponse
     */
    public CampusCreateCampusResponse campusCreateCampusWithOptions(CampusCreateCampusRequest request, CampusCreateCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.area)) {
            body.put("area", request.area);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.belongProjectGroupId)) {
            body.put("belongProjectGroupId", request.belongProjectGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.campusName)) {
            body.put("campusName", request.campusName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.capacity)) {
            body.put("capacity", request.capacity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cityId)) {
            body.put("cityId", request.cityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.country)) {
            body.put("country", request.country);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.countyId)) {
            body.put("countyId", request.countyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.creatorUnionId)) {
            body.put("creatorUnionId", request.creatorUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.location)) {
            body.put("location", request.location);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderEndTime)) {
            body.put("orderEndTime", request.orderEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderInfo)) {
            body.put("orderInfo", request.orderInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderStartTime)) {
            body.put("orderStartTime", request.orderStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.provId)) {
            body.put("provId", request.provId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
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
            new TeaPair("action", "CampusCreateCampus"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusCreateCampusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建园区</p>
     * 
     * @param request CampusCreateCampusRequest
     * @return CampusCreateCampusResponse
     */
    public CampusCreateCampusResponse campusCreateCampus(CampusCreateCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusCreateCampusHeaders headers = new CampusCreateCampusHeaders();
        return this.campusCreateCampusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建园区项目组</p>
     * 
     * @param request CampusCreateCampusGroupRequest
     * @param headers CampusCreateCampusGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusCreateCampusGroupResponse
     */
    public CampusCreateCampusGroupResponse campusCreateCampusGroupWithOptions(CampusCreateCampusGroupRequest request, CampusCreateCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
            new TeaPair("action", "CampusCreateCampusGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects/groups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusCreateCampusGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建园区项目组</p>
     * 
     * @param request CampusCreateCampusGroupRequest
     * @return CampusCreateCampusGroupResponse
     */
    public CampusCreateCampusGroupResponse campusCreateCampusGroup(CampusCreateCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusCreateCampusGroupHeaders headers = new CampusCreateCampusGroupHeaders();
        return this.campusCreateCampusGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建租客</p>
     * 
     * @param request CampusCreateRenterRequest
     * @param headers CampusCreateRenterHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusCreateRenterResponse
     */
    public CampusCreateRenterResponse campusCreateRenterWithOptions(CampusCreateRenterRequest request, CampusCreateRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creditCode)) {
            body.put("creditCode", request.creditCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
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
            new TeaPair("action", "CampusCreateRenter"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusCreateRenterResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建租客</p>
     * 
     * @param request CampusCreateRenterRequest
     * @return CampusCreateRenterResponse
     */
    public CampusCreateRenterResponse campusCreateRenter(CampusCreateRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusCreateRenterHeaders headers = new CampusCreateRenterHeaders();
        return this.campusCreateRenterWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>移除租客人员</p>
     * 
     * @param request CampusDelRenterMemberRequest
     * @param headers CampusDelRenterMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusDelRenterMemberResponse
     */
    public CampusDelRenterMemberResponse campusDelRenterMemberWithOptions(CampusDelRenterMemberRequest request, CampusDelRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "CampusDelRenterMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters/members"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusDelRenterMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>移除租客人员</p>
     * 
     * @param request CampusDelRenterMemberRequest
     * @return CampusDelRenterMemberResponse
     */
    public CampusDelRenterMemberResponse campusDelRenterMember(CampusDelRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusDelRenterMemberHeaders headers = new CampusDelRenterMemberHeaders();
        return this.campusDelRenterMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除园区项目组</p>
     * 
     * @param request CampusDeleteCampusGroupRequest
     * @param headers CampusDeleteCampusGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusDeleteCampusGroupResponse
     */
    public CampusDeleteCampusGroupResponse campusDeleteCampusGroupWithOptions(CampusDeleteCampusGroupRequest request, CampusDeleteCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.campusProjectGroupId)) {
            query.put("campusProjectGroupId", request.campusProjectGroupId);
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
            new TeaPair("action", "CampusDeleteCampusGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects/groups"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusDeleteCampusGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除园区项目组</p>
     * 
     * @param request CampusDeleteCampusGroupRequest
     * @return CampusDeleteCampusGroupResponse
     */
    public CampusDeleteCampusGroupResponse campusDeleteCampusGroup(CampusDeleteCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusDeleteCampusGroupHeaders headers = new CampusDeleteCampusGroupHeaders();
        return this.campusDeleteCampusGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除租客</p>
     * 
     * @param request CampusDeleteRenterRequest
     * @param headers CampusDeleteRenterHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusDeleteRenterResponse
     */
    public CampusDeleteRenterResponse campusDeleteRenterWithOptions(CampusDeleteRenterRequest request, CampusDeleteRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
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
            new TeaPair("action", "CampusDeleteRenter"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusDeleteRenterResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除租客</p>
     * 
     * @param request CampusDeleteRenterRequest
     * @return CampusDeleteRenterResponse
     */
    public CampusDeleteRenterResponse campusDeleteRenter(CampusDeleteRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusDeleteRenterHeaders headers = new CampusDeleteRenterHeaders();
        return this.campusDeleteRenterWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区详情</p>
     * 
     * @param request CampusGetCampusRequest
     * @param headers CampusGetCampusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusGetCampusResponse
     */
    public CampusGetCampusResponse campusGetCampusWithOptions(CampusGetCampusRequest request, CampusGetCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.campusDeptId)) {
            query.put("campusDeptId", request.campusDeptId);
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
            new TeaPair("action", "CampusGetCampus"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projectInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusGetCampusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区详情</p>
     * 
     * @param request CampusGetCampusRequest
     * @return CampusGetCampusResponse
     */
    public CampusGetCampusResponse campusGetCampus(CampusGetCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetCampusHeaders headers = new CampusGetCampusHeaders();
        return this.campusGetCampusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区项目组详情</p>
     * 
     * @param request CampusGetCampusGroupRequest
     * @param headers CampusGetCampusGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusGetCampusGroupResponse
     */
    public CampusGetCampusGroupResponse campusGetCampusGroupWithOptions(CampusGetCampusGroupRequest request, CampusGetCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            query.put("groupId", request.groupId);
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
            new TeaPair("action", "CampusGetCampusGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects/groupInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusGetCampusGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区项目组详情</p>
     * 
     * @param request CampusGetCampusGroupRequest
     * @return CampusGetCampusGroupResponse
     */
    public CampusGetCampusGroupResponse campusGetCampusGroup(CampusGetCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetCampusGroupHeaders headers = new CampusGetCampusGroupHeaders();
        return this.campusGetCampusGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取租客详情</p>
     * 
     * @param request CampusGetRenterRequest
     * @param headers CampusGetRenterHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusGetRenterResponse
     */
    public CampusGetRenterResponse campusGetRenterWithOptions(CampusGetRenterRequest request, CampusGetRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
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
            new TeaPair("action", "CampusGetRenter"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renterInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusGetRenterResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取租客详情</p>
     * 
     * @param request CampusGetRenterRequest
     * @return CampusGetRenterResponse
     */
    public CampusGetRenterResponse campusGetRenter(CampusGetRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetRenterHeaders headers = new CampusGetRenterHeaders();
        return this.campusGetRenterWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询租客指定成员信息</p>
     * 
     * @param request CampusGetRenterMemberRequest
     * @param headers CampusGetRenterMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusGetRenterMemberResponse
     */
    public CampusGetRenterMemberResponse campusGetRenterMemberWithOptions(CampusGetRenterMemberRequest request, CampusGetRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "CampusGetRenterMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters/memberInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusGetRenterMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询租客指定成员信息</p>
     * 
     * @param request CampusGetRenterMemberRequest
     * @return CampusGetRenterMemberResponse
     */
    public CampusGetRenterMemberResponse campusGetRenterMember(CampusGetRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusGetRenterMemberHeaders headers = new CampusGetRenterMemberHeaders();
        return this.campusGetRenterMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区列表</p>
     * 
     * @param request CampusListCampusRequest
     * @param headers CampusListCampusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusListCampusResponse
     */
    public CampusListCampusResponse campusListCampusWithOptions(CampusListCampusRequest request, CampusListCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupDeptId)) {
            query.put("groupDeptId", request.groupDeptId);
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
            new TeaPair("action", "CampusListCampus"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusListCampusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区列表</p>
     * 
     * @param request CampusListCampusRequest
     * @return CampusListCampusResponse
     */
    public CampusListCampusResponse campusListCampus(CampusListCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListCampusHeaders headers = new CampusListCampusHeaders();
        return this.campusListCampusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区项目组列表</p>
     * 
     * @param headers CampusListCampusGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusListCampusGroupResponse
     */
    public CampusListCampusGroupResponse campusListCampusGroupWithOptions(CampusListCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CampusListCampusGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects/groups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusListCampusGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询园区项目组列表</p>
     * @return CampusListCampusGroupResponse
     */
    public CampusListCampusGroupResponse campusListCampusGroup() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListCampusGroupHeaders headers = new CampusListCampusGroupHeaders();
        return this.campusListCampusGroupWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取租客列表</p>
     * 
     * @param headers CampusListRenterHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusListRenterResponse
     */
    public CampusListRenterResponse campusListRenterWithOptions(CampusListRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CampusListRenter"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusListRenterResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取租客列表</p>
     * @return CampusListRenterResponse
     */
    public CampusListRenterResponse campusListRenter() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListRenterHeaders headers = new CampusListRenterHeaders();
        return this.campusListRenterWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询租客下所有成员</p>
     * 
     * @param request CampusListRenterMembersRequest
     * @param headers CampusListRenterMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusListRenterMembersResponse
     */
    public CampusListRenterMembersResponse campusListRenterMembersWithOptions(CampusListRenterMembersRequest request, CampusListRenterMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            query.put("renterId", request.renterId);
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
            new TeaPair("action", "CampusListRenterMembers"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusListRenterMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询租客下所有成员</p>
     * 
     * @param request CampusListRenterMembersRequest
     * @return CampusListRenterMembersResponse
     */
    public CampusListRenterMembersResponse campusListRenterMembers(CampusListRenterMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusListRenterMembersHeaders headers = new CampusListRenterMembersHeaders();
        return this.campusListRenterMembersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新园区项目</p>
     * 
     * @param request CampusUpdateCampusRequest
     * @param headers CampusUpdateCampusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusUpdateCampusResponse
     */
    public CampusUpdateCampusResponse campusUpdateCampusWithOptions(CampusUpdateCampusRequest request, CampusUpdateCampusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.address)) {
            body.put("address", request.address);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.area)) {
            body.put("area", request.area);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.belongProjectGroupId)) {
            body.put("belongProjectGroupId", request.belongProjectGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.campusDeptId)) {
            body.put("campusDeptId", request.campusDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.campusName)) {
            body.put("campusName", request.campusName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.capacity)) {
            body.put("capacity", request.capacity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cityId)) {
            body.put("cityId", request.cityId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.country)) {
            body.put("country", request.country);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.countyId)) {
            body.put("countyId", request.countyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderEndTime)) {
            body.put("orderEndTime", request.orderEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderInfo)) {
            body.put("orderInfo", request.orderInfo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderStartTime)) {
            body.put("orderStartTime", request.orderStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.provId)) {
            body.put("provId", request.provId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.telephone)) {
            body.put("telephone", request.telephone);
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
            new TeaPair("action", "CampusUpdateCampus"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusUpdateCampusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新园区项目</p>
     * 
     * @param request CampusUpdateCampusRequest
     * @return CampusUpdateCampusResponse
     */
    public CampusUpdateCampusResponse campusUpdateCampus(CampusUpdateCampusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateCampusHeaders headers = new CampusUpdateCampusHeaders();
        return this.campusUpdateCampusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新园区项目组</p>
     * 
     * @param request CampusUpdateCampusGroupRequest
     * @param headers CampusUpdateCampusGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusUpdateCampusGroupResponse
     */
    public CampusUpdateCampusGroupResponse campusUpdateCampusGroupWithOptions(CampusUpdateCampusGroupRequest request, CampusUpdateCampusGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.campusProjectGroupId)) {
            body.put("campusProjectGroupId", request.campusProjectGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
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
            new TeaPair("action", "CampusUpdateCampusGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/projects/groups"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusUpdateCampusGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新园区项目组</p>
     * 
     * @param request CampusUpdateCampusGroupRequest
     * @return CampusUpdateCampusGroupResponse
     */
    public CampusUpdateCampusGroupResponse campusUpdateCampusGroup(CampusUpdateCampusGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateCampusGroupHeaders headers = new CampusUpdateCampusGroupHeaders();
        return this.campusUpdateCampusGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新租客</p>
     * 
     * @param request CampusUpdateRenterRequest
     * @param headers CampusUpdateRenterHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusUpdateRenterResponse
     */
    public CampusUpdateRenterResponse campusUpdateRenterWithOptions(CampusUpdateRenterRequest request, CampusUpdateRenterHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.creditCode)) {
            body.put("creditCode", request.creditCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            body.put("renterId", request.renterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.state)) {
            body.put("state", request.state);
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
            new TeaPair("action", "CampusUpdateRenter"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusUpdateRenterResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新租客</p>
     * 
     * @param request CampusUpdateRenterRequest
     * @return CampusUpdateRenterResponse
     */
    public CampusUpdateRenterResponse campusUpdateRenter(CampusUpdateRenterRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateRenterHeaders headers = new CampusUpdateRenterHeaders();
        return this.campusUpdateRenterWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新租客下成员</p>
     * 
     * @param request CampusUpdateRenterMemberRequest
     * @param headers CampusUpdateRenterMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CampusUpdateRenterMemberResponse
     */
    public CampusUpdateRenterMemberResponse campusUpdateRenterMemberWithOptions(CampusUpdateRenterMemberRequest request, CampusUpdateRenterMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.extend)) {
            body.put("extend", request.extend);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.renterId)) {
            body.put("renterId", request.renterId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "CampusUpdateRenterMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/campuses/renters/members"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CampusUpdateRenterMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新租客下成员</p>
     * 
     * @param request CampusUpdateRenterMemberRequest
     * @return CampusUpdateRenterMemberResponse
     */
    public CampusUpdateRenterMemberResponse campusUpdateRenterMember(CampusUpdateRenterMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CampusUpdateRenterMemberHeaders headers = new CampusUpdateRenterMemberHeaders();
        return this.campusUpdateRenterMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加数据集权限</p>
     * 
     * @param request ChatAIAddDatasetPermissionRequest
     * @param headers ChatAIAddDatasetPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatAIAddDatasetPermissionResponse
     */
    public ChatAIAddDatasetPermissionResponse chatAIAddDatasetPermissionWithOptions(ChatAIAddDatasetPermissionRequest request, ChatAIAddDatasetPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authorizationType)) {
            body.put("authorizationType", request.authorizationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authorizedObjectId)) {
            body.put("authorizedObjectId", request.authorizedObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUser)) {
            body.put("optUser", request.optUser);
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
            new TeaPair("action", "ChatAIAddDatasetPermission"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatai/dataset/permissions/add"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatAIAddDatasetPermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加数据集权限</p>
     * 
     * @param request ChatAIAddDatasetPermissionRequest
     * @return ChatAIAddDatasetPermissionResponse
     */
    public ChatAIAddDatasetPermissionResponse chatAIAddDatasetPermission(ChatAIAddDatasetPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatAIAddDatasetPermissionHeaders headers = new ChatAIAddDatasetPermissionHeaders();
        return this.chatAIAddDatasetPermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取chatAI应用下的数据集列表</p>
     * 
     * @param request ChatAIListDatasetRequest
     * @param headers ChatAIListDatasetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatAIListDatasetResponse
     */
    public ChatAIListDatasetResponse chatAIListDatasetWithOptions(ChatAIListDatasetRequest request, ChatAIListDatasetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            query.put("appId", request.appId);
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
            new TeaPair("action", "ChatAIListDataset"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatai/datasets"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatAIListDatasetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取chatAI应用下的数据集列表</p>
     * 
     * @param request ChatAIListDatasetRequest
     * @return ChatAIListDatasetResponse
     */
    public ChatAIListDatasetResponse chatAIListDataset(ChatAIListDatasetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatAIListDatasetHeaders headers = new ChatAIListDatasetHeaders();
        return this.chatAIListDatasetWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询数据集权限明细</p>
     * 
     * @param request ChatAIQueryDatasetPermissionRequest
     * @param headers ChatAIQueryDatasetPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatAIQueryDatasetPermissionResponse
     */
    public ChatAIQueryDatasetPermissionResponse chatAIQueryDatasetPermissionWithOptions(ChatAIQueryDatasetPermissionRequest request, ChatAIQueryDatasetPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            query.put("datasetId", request.datasetId);
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
            new TeaPair("action", "ChatAIQueryDatasetPermission"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatai/dataset/permissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatAIQueryDatasetPermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询数据集权限明细</p>
     * 
     * @param request ChatAIQueryDatasetPermissionRequest
     * @return ChatAIQueryDatasetPermissionResponse
     */
    public ChatAIQueryDatasetPermissionResponse chatAIQueryDatasetPermission(ChatAIQueryDatasetPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatAIQueryDatasetPermissionHeaders headers = new ChatAIQueryDatasetPermissionHeaders();
        return this.chatAIQueryDatasetPermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据集权限</p>
     * 
     * @param request ChatAIRemoveDatasetPermissionRequest
     * @param headers ChatAIRemoveDatasetPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatAIRemoveDatasetPermissionResponse
     */
    public ChatAIRemoveDatasetPermissionResponse chatAIRemoveDatasetPermissionWithOptions(ChatAIRemoveDatasetPermissionRequest request, ChatAIRemoveDatasetPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.authorizationType)) {
            body.put("authorizationType", request.authorizationType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.authorizedObjectId)) {
            body.put("authorizedObjectId", request.authorizedObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.optUser)) {
            body.put("optUser", request.optUser);
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
            new TeaPair("action", "ChatAIRemoveDatasetPermission"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatai/dataset/permissions/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatAIRemoveDatasetPermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除数据集权限</p>
     * 
     * @param request ChatAIRemoveDatasetPermissionRequest
     * @return ChatAIRemoveDatasetPermissionResponse
     */
    public ChatAIRemoveDatasetPermissionResponse chatAIRemoveDatasetPermission(ChatAIRemoveDatasetPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatAIRemoveDatasetPermissionHeaders headers = new ChatAIRemoveDatasetPermissionHeaders();
        return this.chatAIRemoveDatasetPermissionWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>Chai文本情感分析</p>
     * 
     * @param request ChatAITextSentimentAnalysisRequest
     * @param headers ChatAITextSentimentAnalysisHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatAITextSentimentAnalysisResponse
     */
    public ChatAITextSentimentAnalysisResponse chatAITextSentimentAnalysisWithOptions(ChatAITextSentimentAnalysisRequest request, ChatAITextSentimentAnalysisHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.history)) {
            body.put("history", request.history);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.text)) {
            body.put("text", request.text);
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
            new TeaPair("action", "ChatAITextSentimentAnalysis"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatai/abilities/sentiments/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatAITextSentimentAnalysisResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>Chai文本情感分析</p>
     * 
     * @param request ChatAITextSentimentAnalysisRequest
     * @return ChatAITextSentimentAnalysisResponse
     */
    public ChatAITextSentimentAnalysisResponse chatAITextSentimentAnalysis(ChatAITextSentimentAnalysisRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatAITextSentimentAnalysisHeaders headers = new ChatAITextSentimentAnalysisHeaders();
        return this.chatAITextSentimentAnalysisWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取差旅单列表</p>
     * 
     * @param request ChatAiTravelListRequest
     * @param headers ChatAiTravelListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatAiTravelListResponse
     */
    public ChatAiTravelListResponse chatAiTravelListWithOptions(ChatAiTravelListRequest request, ChatAiTravelListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.paramList)) {
            body.put("paramList", request.paramList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.travelId)) {
            body.put("travelId", request.travelId);
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
            new TeaPair("action", "ChatAiTravelList"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/ai/travelLists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatAiTravelListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取差旅单列表</p>
     * 
     * @param request ChatAiTravelListRequest
     * @return ChatAiTravelListResponse
     */
    public ChatAiTravelListResponse chatAiTravelList(ChatAiTravelListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatAiTravelListHeaders headers = new ChatAiTravelListHeaders();
        return this.chatAiTravelListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>ChatForm查询表单识别结果</p>
     * 
     * @param request ChatFormGetDataForApiAccessRequest
     * @param headers ChatFormGetDataForApiAccessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatFormGetDataForApiAccessResponse
     */
    public ChatFormGetDataForApiAccessResponse chatFormGetDataForApiAccessWithOptions(ChatFormGetDataForApiAccessRequest request, ChatFormGetDataForApiAccessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTalkTraceId)) {
            query.put("dingTalkTraceId", request.dingTalkTraceId);
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
            new TeaPair("action", "ChatFormGetDataForApiAccess"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatform/datas"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatFormGetDataForApiAccessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>ChatForm查询表单识别结果</p>
     * 
     * @param request ChatFormGetDataForApiAccessRequest
     * @return ChatFormGetDataForApiAccessResponse
     */
    public ChatFormGetDataForApiAccessResponse chatFormGetDataForApiAccess(ChatFormGetDataForApiAccessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatFormGetDataForApiAccessHeaders headers = new ChatFormGetDataForApiAccessHeaders();
        return this.chatFormGetDataForApiAccessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增普通文件</p>
     * 
     * @param request ChatMemoAddGeneralFileRequest
     * @param headers ChatMemoAddGeneralFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoAddGeneralFileResponse
     */
    public ChatMemoAddGeneralFileResponse chatMemoAddGeneralFileWithOptions(ChatMemoAddGeneralFileRequest request, ChatMemoAddGeneralFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.downloadUrl)) {
            body.put("downloadUrl", request.downloadUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileDesc)) {
            body.put("fileDesc", request.fileDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagList)) {
            body.put("tagList", request.tagList);
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
            new TeaPair("action", "ChatMemoAddGeneralFile"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/files"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoAddGeneralFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增普通文件</p>
     * 
     * @param request ChatMemoAddGeneralFileRequest
     * @return ChatMemoAddGeneralFileResponse
     */
    public ChatMemoAddGeneralFileResponse chatMemoAddGeneralFile(ChatMemoAddGeneralFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoAddGeneralFileHeaders headers = new ChatMemoAddGeneralFileHeaders();
        return this.chatMemoAddGeneralFileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增知识图谱节点</p>
     * 
     * @param request ChatMemoAddKnowledgeGraphNodeRequest
     * @param headers ChatMemoAddKnowledgeGraphNodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoAddKnowledgeGraphNodeResponse
     */
    public ChatMemoAddKnowledgeGraphNodeResponse chatMemoAddKnowledgeGraphNodeWithOptions(ChatMemoAddKnowledgeGraphNodeRequest request, ChatMemoAddKnowledgeGraphNodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeInfo)) {
            body.put("nodeInfo", request.nodeInfo);
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
            new TeaPair("action", "ChatMemoAddKnowledgeGraphNode"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/nodes"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoAddKnowledgeGraphNodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增知识图谱节点</p>
     * 
     * @param request ChatMemoAddKnowledgeGraphNodeRequest
     * @return ChatMemoAddKnowledgeGraphNodeResponse
     */
    public ChatMemoAddKnowledgeGraphNodeResponse chatMemoAddKnowledgeGraphNode(ChatMemoAddKnowledgeGraphNodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoAddKnowledgeGraphNodeHeaders headers = new ChatMemoAddKnowledgeGraphNodeHeaders();
        return this.chatMemoAddKnowledgeGraphNodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增知识图谱关系</p>
     * 
     * @param request ChatMemoAddKnowledgeGraphRelationRequest
     * @param headers ChatMemoAddKnowledgeGraphRelationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoAddKnowledgeGraphRelationResponse
     */
    public ChatMemoAddKnowledgeGraphRelationResponse chatMemoAddKnowledgeGraphRelationWithOptions(ChatMemoAddKnowledgeGraphRelationRequest request, ChatMemoAddKnowledgeGraphRelationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationInfo)) {
            body.put("relationInfo", request.relationInfo);
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
            new TeaPair("action", "ChatMemoAddKnowledgeGraphRelation"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/relations"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoAddKnowledgeGraphRelationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增知识图谱关系</p>
     * 
     * @param request ChatMemoAddKnowledgeGraphRelationRequest
     * @return ChatMemoAddKnowledgeGraphRelationResponse
     */
    public ChatMemoAddKnowledgeGraphRelationResponse chatMemoAddKnowledgeGraphRelation(ChatMemoAddKnowledgeGraphRelationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoAddKnowledgeGraphRelationHeaders headers = new ChatMemoAddKnowledgeGraphRelationHeaders();
        return this.chatMemoAddKnowledgeGraphRelationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除普通文件</p>
     * 
     * @param request ChatMemoDeleteGeneralFileRequest
     * @param headers ChatMemoDeleteGeneralFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoDeleteGeneralFileResponse
     */
    public ChatMemoDeleteGeneralFileResponse chatMemoDeleteGeneralFileWithOptions(ChatMemoDeleteGeneralFileRequest request, ChatMemoDeleteGeneralFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "ChatMemoDeleteGeneralFile"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/files/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoDeleteGeneralFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除普通文件</p>
     * 
     * @param request ChatMemoDeleteGeneralFileRequest
     * @return ChatMemoDeleteGeneralFileResponse
     */
    public ChatMemoDeleteGeneralFileResponse chatMemoDeleteGeneralFile(ChatMemoDeleteGeneralFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoDeleteGeneralFileHeaders headers = new ChatMemoDeleteGeneralFileHeaders();
        return this.chatMemoDeleteGeneralFileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除知识图谱节点</p>
     * 
     * @param request ChatMemoDeleteKnowledgeGraphNodeRequest
     * @param headers ChatMemoDeleteKnowledgeGraphNodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoDeleteKnowledgeGraphNodeResponse
     */
    public ChatMemoDeleteKnowledgeGraphNodeResponse chatMemoDeleteKnowledgeGraphNodeWithOptions(ChatMemoDeleteKnowledgeGraphNodeRequest request, ChatMemoDeleteKnowledgeGraphNodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "ChatMemoDeleteKnowledgeGraphNode"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/nodes/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoDeleteKnowledgeGraphNodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除知识图谱节点</p>
     * 
     * @param request ChatMemoDeleteKnowledgeGraphNodeRequest
     * @return ChatMemoDeleteKnowledgeGraphNodeResponse
     */
    public ChatMemoDeleteKnowledgeGraphNodeResponse chatMemoDeleteKnowledgeGraphNode(ChatMemoDeleteKnowledgeGraphNodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoDeleteKnowledgeGraphNodeHeaders headers = new ChatMemoDeleteKnowledgeGraphNodeHeaders();
        return this.chatMemoDeleteKnowledgeGraphNodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除知识图谱关系</p>
     * 
     * @param request ChatMemoDeleteKnowledgeGraphRelationRequest
     * @param headers ChatMemoDeleteKnowledgeGraphRelationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoDeleteKnowledgeGraphRelationResponse
     */
    public ChatMemoDeleteKnowledgeGraphRelationResponse chatMemoDeleteKnowledgeGraphRelationWithOptions(ChatMemoDeleteKnowledgeGraphRelationRequest request, ChatMemoDeleteKnowledgeGraphRelationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "ChatMemoDeleteKnowledgeGraphRelation"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/relations/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoDeleteKnowledgeGraphRelationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除知识图谱关系</p>
     * 
     * @param request ChatMemoDeleteKnowledgeGraphRelationRequest
     * @return ChatMemoDeleteKnowledgeGraphRelationResponse
     */
    public ChatMemoDeleteKnowledgeGraphRelationResponse chatMemoDeleteKnowledgeGraphRelation(ChatMemoDeleteKnowledgeGraphRelationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoDeleteKnowledgeGraphRelationHeaders headers = new ChatMemoDeleteKnowledgeGraphRelationHeaders();
        return this.chatMemoDeleteKnowledgeGraphRelationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增 FAQ</p>
     * 
     * @param request ChatMemoFaqAddRequest
     * @param headers ChatMemoFaqAddHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoFaqAddResponse
     */
    public ChatMemoFaqAddResponse chatMemoFaqAddWithOptions(ChatMemoFaqAddRequest request, ChatMemoFaqAddHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.answer)) {
            body.put("answer", request.answer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.question)) {
            body.put("question", request.question);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redirection)) {
            body.put("redirection", request.redirection);
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
            new TeaPair("action", "ChatMemoFaqAdd"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/faq"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoFaqAddResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增 FAQ</p>
     * 
     * @param request ChatMemoFaqAddRequest
     * @return ChatMemoFaqAddResponse
     */
    public ChatMemoFaqAddResponse chatMemoFaqAdd(ChatMemoFaqAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoFaqAddHeaders headers = new ChatMemoFaqAddHeaders();
        return this.chatMemoFaqAddWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定数据集中的FAQ</p>
     * 
     * @param request ChatMemoFaqDeleteRequest
     * @param headers ChatMemoFaqDeleteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoFaqDeleteResponse
     */
    public ChatMemoFaqDeleteResponse chatMemoFaqDeleteWithOptions(ChatMemoFaqDeleteRequest request, ChatMemoFaqDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "ChatMemoFaqDelete"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/faq/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoFaqDeleteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除指定数据集中的FAQ</p>
     * 
     * @param request ChatMemoFaqDeleteRequest
     * @return ChatMemoFaqDeleteResponse
     */
    public ChatMemoFaqDeleteResponse chatMemoFaqDelete(ChatMemoFaqDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoFaqDeleteHeaders headers = new ChatMemoFaqDeleteHeaders();
        return this.chatMemoFaqDeleteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定数据集中的FAQ列表</p>
     * 
     * @param request ChatMemoFaqListRequest
     * @param headers ChatMemoFaqListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoFaqListResponse
     */
    public ChatMemoFaqListResponse chatMemoFaqListWithOptions(ChatMemoFaqListRequest request, ChatMemoFaqListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            query.put("datasetId", request.datasetId);
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
            new TeaPair("action", "ChatMemoFaqList"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/faq/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoFaqListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定数据集中的FAQ列表</p>
     * 
     * @param request ChatMemoFaqListRequest
     * @return ChatMemoFaqListResponse
     */
    public ChatMemoFaqListResponse chatMemoFaqList(ChatMemoFaqListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoFaqListHeaders headers = new ChatMemoFaqListHeaders();
        return this.chatMemoFaqListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定数据集中的文件列表</p>
     * 
     * @param request ChatMemoGetFileListRequest
     * @param headers ChatMemoGetFileListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoGetFileListResponse
     */
    public ChatMemoGetFileListResponse chatMemoGetFileListWithOptions(ChatMemoGetFileListRequest request, ChatMemoGetFileListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            query.put("datasetId", request.datasetId);
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
            new TeaPair("action", "ChatMemoGetFileList"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/file/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoGetFileListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询指定数据集中的文件列表</p>
     * 
     * @param request ChatMemoGetFileListRequest
     * @return ChatMemoGetFileListResponse
     */
    public ChatMemoGetFileListResponse chatMemoGetFileList(ChatMemoGetFileListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoGetFileListHeaders headers = new ChatMemoGetFileListHeaders();
        return this.chatMemoGetFileListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件状态</p>
     * 
     * @param request ChatMemoGetFileStatusRequest
     * @param headers ChatMemoGetFileStatusHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoGetFileStatusResponse
     */
    public ChatMemoGetFileStatusResponse chatMemoGetFileStatusWithOptions(ChatMemoGetFileStatusRequest request, ChatMemoGetFileStatusHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "ChatMemoGetFileStatus"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/files/statuses/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoGetFileStatusResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件状态</p>
     * 
     * @param request ChatMemoGetFileStatusRequest
     * @return ChatMemoGetFileStatusResponse
     */
    public ChatMemoGetFileStatusResponse chatMemoGetFileStatus(ChatMemoGetFileStatusRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoGetFileStatusHeaders headers = new ChatMemoGetFileStatusHeaders();
        return this.chatMemoGetFileStatusWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询知识图谱节点</p>
     * 
     * @param request ChatMemoQueryKnowledgeGraphNodeRequest
     * @param headers ChatMemoQueryKnowledgeGraphNodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoQueryKnowledgeGraphNodeResponse
     */
    public ChatMemoQueryKnowledgeGraphNodeResponse chatMemoQueryKnowledgeGraphNodeWithOptions(ChatMemoQueryKnowledgeGraphNodeRequest request, ChatMemoQueryKnowledgeGraphNodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "ChatMemoQueryKnowledgeGraphNode"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/nodes/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoQueryKnowledgeGraphNodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询知识图谱节点</p>
     * 
     * @param request ChatMemoQueryKnowledgeGraphNodeRequest
     * @return ChatMemoQueryKnowledgeGraphNodeResponse
     */
    public ChatMemoQueryKnowledgeGraphNodeResponse chatMemoQueryKnowledgeGraphNode(ChatMemoQueryKnowledgeGraphNodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoQueryKnowledgeGraphNodeHeaders headers = new ChatMemoQueryKnowledgeGraphNodeHeaders();
        return this.chatMemoQueryKnowledgeGraphNodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询知识图谱关系</p>
     * 
     * @param request ChatMemoQueryKnowledgeGraphRelationRequest
     * @param headers ChatMemoQueryKnowledgeGraphRelationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoQueryKnowledgeGraphRelationResponse
     */
    public ChatMemoQueryKnowledgeGraphRelationResponse chatMemoQueryKnowledgeGraphRelationWithOptions(ChatMemoQueryKnowledgeGraphRelationRequest request, ChatMemoQueryKnowledgeGraphRelationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
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
            new TeaPair("action", "ChatMemoQueryKnowledgeGraphRelation"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/relations/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoQueryKnowledgeGraphRelationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询知识图谱关系</p>
     * 
     * @param request ChatMemoQueryKnowledgeGraphRelationRequest
     * @return ChatMemoQueryKnowledgeGraphRelationResponse
     */
    public ChatMemoQueryKnowledgeGraphRelationResponse chatMemoQueryKnowledgeGraphRelation(ChatMemoQueryKnowledgeGraphRelationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoQueryKnowledgeGraphRelationHeaders headers = new ChatMemoQueryKnowledgeGraphRelationHeaders();
        return this.chatMemoQueryKnowledgeGraphRelationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新知识图谱节点</p>
     * 
     * @param request ChatMemoUpdateKnowledgeGraphNodeRequest
     * @param headers ChatMemoUpdateKnowledgeGraphNodeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoUpdateKnowledgeGraphNodeResponse
     */
    public ChatMemoUpdateKnowledgeGraphNodeResponse chatMemoUpdateKnowledgeGraphNodeWithOptions(ChatMemoUpdateKnowledgeGraphNodeRequest request, ChatMemoUpdateKnowledgeGraphNodeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeInfo)) {
            body.put("nodeInfo", request.nodeInfo);
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
            new TeaPair("action", "ChatMemoUpdateKnowledgeGraphNode"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/nodes"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoUpdateKnowledgeGraphNodeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新知识图谱节点</p>
     * 
     * @param request ChatMemoUpdateKnowledgeGraphNodeRequest
     * @return ChatMemoUpdateKnowledgeGraphNodeResponse
     */
    public ChatMemoUpdateKnowledgeGraphNodeResponse chatMemoUpdateKnowledgeGraphNode(ChatMemoUpdateKnowledgeGraphNodeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoUpdateKnowledgeGraphNodeHeaders headers = new ChatMemoUpdateKnowledgeGraphNodeHeaders();
        return this.chatMemoUpdateKnowledgeGraphNodeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新知识图谱关系</p>
     * 
     * @param request ChatMemoUpdateKnowledgeGraphRelationRequest
     * @param headers ChatMemoUpdateKnowledgeGraphRelationHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ChatMemoUpdateKnowledgeGraphRelationResponse
     */
    public ChatMemoUpdateKnowledgeGraphRelationResponse chatMemoUpdateKnowledgeGraphRelationWithOptions(ChatMemoUpdateKnowledgeGraphRelationRequest request, ChatMemoUpdateKnowledgeGraphRelationHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizId)) {
            body.put("bizId", request.bizId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.datasetId)) {
            body.put("datasetId", request.datasetId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.relationInfo)) {
            body.put("relationInfo", request.relationInfo);
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
            new TeaPair("action", "ChatMemoUpdateKnowledgeGraphRelation"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatmemo/relations"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ChatMemoUpdateKnowledgeGraphRelationResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新知识图谱关系</p>
     * 
     * @param request ChatMemoUpdateKnowledgeGraphRelationRequest
     * @return ChatMemoUpdateKnowledgeGraphRelationResponse
     */
    public ChatMemoUpdateKnowledgeGraphRelationResponse chatMemoUpdateKnowledgeGraphRelation(ChatMemoUpdateKnowledgeGraphRelationRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ChatMemoUpdateKnowledgeGraphRelationHeaders headers = new ChatMemoUpdateKnowledgeGraphRelationHeaders();
        return this.chatMemoUpdateKnowledgeGraphRelationWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>开启学段/学院/年级/专业\系/班级群</p>
     * 
     * @param request CollegeActiveCollegeDeptGroupRequest
     * @param headers CollegeActiveCollegeDeptGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeActiveCollegeDeptGroupResponse
     */
    public CollegeActiveCollegeDeptGroupResponse collegeActiveCollegeDeptGroupWithOptions(CollegeActiveCollegeDeptGroupRequest request, CollegeActiveCollegeDeptGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeActiveCollegeDeptGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/depts/groups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeActiveCollegeDeptGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>开启学段/学院/年级/专业\系/班级群</p>
     * 
     * @param request CollegeActiveCollegeDeptGroupRequest
     * @return CollegeActiveCollegeDeptGroupResponse
     */
    public CollegeActiveCollegeDeptGroupResponse collegeActiveCollegeDeptGroup(CollegeActiveCollegeDeptGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeActiveCollegeDeptGroupHeaders headers = new CollegeActiveCollegeDeptGroupHeaders();
        return this.collegeActiveCollegeDeptGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建学段/学院/年级/专业\系/班级</p>
     * 
     * @param request CollegeAddCollegeDeptRequest
     * @param headers CollegeAddCollegeDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeAddCollegeDeptResponse
     */
    public CollegeAddCollegeDeptResponse collegeAddCollegeDeptWithOptions(CollegeAddCollegeDeptRequest request, CollegeAddCollegeDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptName)) {
            query.put("deptName", request.deptName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptType)) {
            query.put("deptType", request.deptType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortFactor)) {
            query.put("sortFactor", request.sortFactor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            query.put("superId", request.superId);
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
            new TeaPair("action", "CollegeAddCollegeDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/depts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeAddCollegeDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建学段/学院/年级/专业\系/班级</p>
     * 
     * @param request CollegeAddCollegeDeptRequest
     * @return CollegeAddCollegeDeptResponse
     */
    public CollegeAddCollegeDeptResponse collegeAddCollegeDept(CollegeAddCollegeDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeAddCollegeDeptHeaders headers = new CollegeAddCollegeDeptHeaders();
        return this.collegeAddCollegeDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>往部门中添加负责人</p>
     * 
     * @param request CollegeAddManagerRequest
     * @param headers CollegeAddManagerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeAddManagerResponse
     */
    public CollegeAddManagerResponse collegeAddManagerWithOptions(CollegeAddManagerRequest request, CollegeAddManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeAddManager"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/managers"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeAddManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>往部门中添加负责人</p>
     * 
     * @param request CollegeAddManagerRequest
     * @return CollegeAddManagerResponse
     */
    public CollegeAddManagerResponse collegeAddManager(CollegeAddManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeAddManagerHeaders headers = new CollegeAddManagerHeaders();
        return this.collegeAddManagerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>在班级中添加人员</p>
     * 
     * @param request CollegeAddStudentRequest
     * @param headers CollegeAddStudentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeAddStudentResponse
     */
    public CollegeAddStudentResponse collegeAddStudentWithOptions(CollegeAddStudentRequest request, CollegeAddStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.empExtension)) {
            body.put("empExtension", request.empExtension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gender)) {
            body.put("gender", request.gender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifyId)) {
            body.put("identifyId", request.identifyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startYear)) {
            body.put("startYear", request.startYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentName)) {
            body.put("studentName", request.studentName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentNumber)) {
            body.put("studentNumber", request.studentNumber);
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
            new TeaPair("action", "CollegeAddStudent"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/students"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeAddStudentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>在班级中添加人员</p>
     * 
     * @param request CollegeAddStudentRequest
     * @return CollegeAddStudentResponse
     */
    public CollegeAddStudentResponse collegeAddStudent(CollegeAddStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeAddStudentHeaders headers = new CollegeAddStudentHeaders();
        return this.collegeAddStudentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>移动学生到其他部门</p>
     * 
     * @param request CollegeChangeStudentDeptRequest
     * @param headers CollegeChangeStudentDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeChangeStudentDeptResponse
     */
    public CollegeChangeStudentDeptResponse collegeChangeStudentDeptWithOptions(CollegeChangeStudentDeptRequest request, CollegeChangeStudentDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newDeptId)) {
            query.put("newDeptId", request.newDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
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
            new TeaPair("action", "CollegeChangeStudentDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/students/move"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeChangeStudentDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>移动学生到其他部门</p>
     * 
     * @param request CollegeChangeStudentDeptRequest
     * @return CollegeChangeStudentDeptResponse
     */
    public CollegeChangeStudentDeptResponse collegeChangeStudentDept(CollegeChangeStudentDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeChangeStudentDeptHeaders headers = new CollegeChangeStudentDeptHeaders();
        return this.collegeChangeStudentDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除学段/学院/年级/专业\系/班级</p>
     * 
     * @param request CollegeDeleteCollegeDeptRequest
     * @param headers CollegeDeleteCollegeDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeDeleteCollegeDeptResponse
     */
    public CollegeDeleteCollegeDeptResponse collegeDeleteCollegeDeptWithOptions(CollegeDeleteCollegeDeptRequest request, CollegeDeleteCollegeDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeDeleteCollegeDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/depts"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeDeleteCollegeDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除学段/学院/年级/专业\系/班级</p>
     * 
     * @param request CollegeDeleteCollegeDeptRequest
     * @return CollegeDeleteCollegeDeptResponse
     */
    public CollegeDeleteCollegeDeptResponse collegeDeleteCollegeDept(CollegeDeleteCollegeDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeDeleteCollegeDeptHeaders headers = new CollegeDeleteCollegeDeptHeaders();
        return this.collegeDeleteCollegeDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取下级节点列表</p>
     * 
     * @param request CollegeListCollegeSubDeptRequest
     * @param headers CollegeListCollegeSubDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeListCollegeSubDeptResponse
     */
    public CollegeListCollegeSubDeptResponse collegeListCollegeSubDeptWithOptions(CollegeListCollegeSubDeptRequest request, CollegeListCollegeSubDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeListCollegeSubDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/subDepts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeListCollegeSubDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取下级节点列表</p>
     * 
     * @param request CollegeListCollegeSubDeptRequest
     * @return CollegeListCollegeSubDeptResponse
     */
    public CollegeListCollegeSubDeptResponse collegeListCollegeSubDept(CollegeListCollegeSubDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListCollegeSubDeptHeaders headers = new CollegeListCollegeSubDeptHeaders();
        return this.collegeListCollegeSubDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门下所有负责人列表</p>
     * 
     * @param request CollegeListDeptManagerRequest
     * @param headers CollegeListDeptManagerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeListDeptManagerResponse
     */
    public CollegeListDeptManagerResponse collegeListDeptManagerWithOptions(CollegeListDeptManagerRequest request, CollegeListDeptManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeListDeptManager"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/managers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeListDeptManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门下所有负责人列表</p>
     * 
     * @param request CollegeListDeptManagerRequest
     * @return CollegeListDeptManagerResponse
     */
    public CollegeListDeptManagerResponse collegeListDeptManager(CollegeListDeptManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListDeptManagerHeaders headers = new CollegeListDeptManagerHeaders();
        return this.collegeListDeptManagerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取班级下所有学生列表</p>
     * 
     * @param request CollegeListStudentInfoRequest
     * @param headers CollegeListStudentInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeListStudentInfoResponse
     */
    public CollegeListStudentInfoResponse collegeListStudentInfoWithOptions(CollegeListStudentInfoRequest request, CollegeListStudentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingStudentStatus)) {
            query.put("dingStudentStatus", request.dingStudentStatus);
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
            new TeaPair("action", "CollegeListStudentInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/students"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeListStudentInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页获取班级下所有学生列表</p>
     * 
     * @param request CollegeListStudentInfoRequest
     * @return CollegeListStudentInfoResponse
     */
    public CollegeListStudentInfoResponse collegeListStudentInfo(CollegeListStudentInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListStudentInfoHeaders headers = new CollegeListStudentInfoHeaders();
        return this.collegeListStudentInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询未加入组织的学生列表</p>
     * 
     * @param request CollegeListUncheckedStudentRequest
     * @param headers CollegeListUncheckedStudentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeListUncheckedStudentResponse
     */
    public CollegeListUncheckedStudentResponse collegeListUncheckedStudentWithOptions(CollegeListUncheckedStudentRequest request, CollegeListUncheckedStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeListUncheckedStudent"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/organizations/unjoinedStudents"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeListUncheckedStudentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>分页查询未加入组织的学生列表</p>
     * 
     * @param request CollegeListUncheckedStudentRequest
     * @return CollegeListUncheckedStudentResponse
     */
    public CollegeListUncheckedStudentResponse collegeListUncheckedStudent(CollegeListUncheckedStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeListUncheckedStudentHeaders headers = new CollegeListUncheckedStudentHeaders();
        return this.collegeListUncheckedStudentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取学段/学院/年级/专业\系/班级群群信息</p>
     * 
     * @param request CollegeQueryCollegeDeptGroupInfoRequest
     * @param headers CollegeQueryCollegeDeptGroupInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeQueryCollegeDeptGroupInfoResponse
     */
    public CollegeQueryCollegeDeptGroupInfoResponse collegeQueryCollegeDeptGroupInfoWithOptions(CollegeQueryCollegeDeptGroupInfoRequest request, CollegeQueryCollegeDeptGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeQueryCollegeDeptGroupInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/depts/groupInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeQueryCollegeDeptGroupInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取学段/学院/年级/专业\系/班级群群信息</p>
     * 
     * @param request CollegeQueryCollegeDeptGroupInfoRequest
     * @return CollegeQueryCollegeDeptGroupInfoResponse
     */
    public CollegeQueryCollegeDeptGroupInfoResponse collegeQueryCollegeDeptGroupInfo(CollegeQueryCollegeDeptGroupInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryCollegeDeptGroupInfoHeaders headers = new CollegeQueryCollegeDeptGroupInfoHeaders();
        return this.collegeQueryCollegeDeptGroupInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取学段/学院/年级/专业\系/班级信息</p>
     * 
     * @param request CollegeQueryCollegeDeptInfoRequest
     * @param headers CollegeQueryCollegeDeptInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeQueryCollegeDeptInfoResponse
     */
    public CollegeQueryCollegeDeptInfoResponse collegeQueryCollegeDeptInfoWithOptions(CollegeQueryCollegeDeptInfoRequest request, CollegeQueryCollegeDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CollegeQueryCollegeDeptInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/deptInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeQueryCollegeDeptInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取学段/学院/年级/专业\系/班级信息</p>
     * 
     * @param request CollegeQueryCollegeDeptInfoRequest
     * @return CollegeQueryCollegeDeptInfoResponse
     */
    public CollegeQueryCollegeDeptInfoResponse collegeQueryCollegeDeptInfo(CollegeQueryCollegeDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryCollegeDeptInfoHeaders headers = new CollegeQueryCollegeDeptInfoHeaders();
        return this.collegeQueryCollegeDeptInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定部门下指定学生的信息</p>
     * 
     * @param request CollegeQueryStudentInfoByDeptRequest
     * @param headers CollegeQueryStudentInfoByDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeQueryStudentInfoByDeptResponse
     */
    public CollegeQueryStudentInfoByDeptResponse collegeQueryStudentInfoByDeptWithOptions(CollegeQueryStudentInfoByDeptRequest request, CollegeQueryStudentInfoByDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
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
            new TeaPair("action", "CollegeQueryStudentInfoByDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/studentinfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeQueryStudentInfoByDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指定部门下指定学生的信息</p>
     * 
     * @param request CollegeQueryStudentInfoByDeptRequest
     * @return CollegeQueryStudentInfoByDeptResponse
     */
    public CollegeQueryStudentInfoByDeptResponse collegeQueryStudentInfoByDept(CollegeQueryStudentInfoByDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryStudentInfoByDeptHeaders headers = new CollegeQueryStudentInfoByDeptHeaders();
        return this.collegeQueryStudentInfoByDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据手机号查询学生信息</p>
     * 
     * @param request CollegeQueryStudentInfoByMobileRequest
     * @param headers CollegeQueryStudentInfoByMobileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeQueryStudentInfoByMobileResponse
     */
    public CollegeQueryStudentInfoByMobileResponse collegeQueryStudentInfoByMobileWithOptions(CollegeQueryStudentInfoByMobileRequest request, CollegeQueryStudentInfoByMobileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
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
            new TeaPair("action", "CollegeQueryStudentInfoByMobile"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/students/mobiles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeQueryStudentInfoByMobileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据手机号查询学生信息</p>
     * 
     * @param request CollegeQueryStudentInfoByMobileRequest
     * @return CollegeQueryStudentInfoByMobileResponse
     */
    public CollegeQueryStudentInfoByMobileResponse collegeQueryStudentInfoByMobile(CollegeQueryStudentInfoByMobileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryStudentInfoByMobileHeaders headers = new CollegeQueryStudentInfoByMobileHeaders();
        return this.collegeQueryStudentInfoByMobileWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据studentId查询学生信息</p>
     * 
     * @param request CollegeQueryStudentInfoByStudentIdRequest
     * @param headers CollegeQueryStudentInfoByStudentIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeQueryStudentInfoByStudentIdResponse
     */
    public CollegeQueryStudentInfoByStudentIdResponse collegeQueryStudentInfoByStudentIdWithOptions(CollegeQueryStudentInfoByStudentIdRequest request, CollegeQueryStudentInfoByStudentIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
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
            new TeaPair("action", "CollegeQueryStudentInfoByStudentId"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/students"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeQueryStudentInfoByStudentIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据studentId查询学生信息</p>
     * 
     * @param request CollegeQueryStudentInfoByStudentIdRequest
     * @return CollegeQueryStudentInfoByStudentIdResponse
     */
    public CollegeQueryStudentInfoByStudentIdResponse collegeQueryStudentInfoByStudentId(CollegeQueryStudentInfoByStudentIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeQueryStudentInfoByStudentIdHeaders headers = new CollegeQueryStudentInfoByStudentIdHeaders();
        return this.collegeQueryStudentInfoByStudentIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>从部门中移除负责人</p>
     * 
     * @param request CollegeRemoveManagerRequest
     * @param headers CollegeRemoveManagerHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeRemoveManagerResponse
     */
    public CollegeRemoveManagerResponse collegeRemoveManagerWithOptions(CollegeRemoveManagerRequest request, CollegeRemoveManagerHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isForce)) {
            query.put("isForce", request.isForce);
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
            new TeaPair("action", "CollegeRemoveManager"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/managers"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeRemoveManagerResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>从部门中移除负责人</p>
     * 
     * @param request CollegeRemoveManagerRequest
     * @return CollegeRemoveManagerResponse
     */
    public CollegeRemoveManagerResponse collegeRemoveManager(CollegeRemoveManagerRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeRemoveManagerHeaders headers = new CollegeRemoveManagerHeaders();
        return this.collegeRemoveManagerWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>从部门中移除学生</p>
     * 
     * @param request CollegeRemoveStudentRequest
     * @param headers CollegeRemoveStudentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeRemoveStudentResponse
     */
    public CollegeRemoveStudentResponse collegeRemoveStudentWithOptions(CollegeRemoveStudentRequest request, CollegeRemoveStudentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
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
            new TeaPair("action", "CollegeRemoveStudent"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/students"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeRemoveStudentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>从部门中移除学生</p>
     * 
     * @param request CollegeRemoveStudentRequest
     * @return CollegeRemoveStudentResponse
     */
    public CollegeRemoveStudentResponse collegeRemoveStudent(CollegeRemoveStudentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeRemoveStudentHeaders headers = new CollegeRemoveStudentHeaders();
        return this.collegeRemoveStudentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>编辑学段/学院/年级/专业\系/班级</p>
     * 
     * @param request CollegeUpdateCollegeDeptRequest
     * @param headers CollegeUpdateCollegeDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeUpdateCollegeDeptResponse
     */
    public CollegeUpdateCollegeDeptResponse collegeUpdateCollegeDeptWithOptions(CollegeUpdateCollegeDeptRequest request, CollegeUpdateCollegeDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptName)) {
            query.put("deptName", request.deptName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortFactor)) {
            query.put("sortFactor", request.sortFactor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            query.put("superId", request.superId);
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
            new TeaPair("action", "CollegeUpdateCollegeDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/depts"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeUpdateCollegeDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>编辑学段/学院/年级/专业\系/班级</p>
     * 
     * @param request CollegeUpdateCollegeDeptRequest
     * @return CollegeUpdateCollegeDeptResponse
     */
    public CollegeUpdateCollegeDeptResponse collegeUpdateCollegeDept(CollegeUpdateCollegeDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateCollegeDeptHeaders headers = new CollegeUpdateCollegeDeptHeaders();
        return this.collegeUpdateCollegeDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新学生的部门相关信息</p>
     * 
     * @param request CollegeUpdateStudentDeptInfoRequest
     * @param headers CollegeUpdateStudentDeptInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeUpdateStudentDeptInfoResponse
     */
    public CollegeUpdateStudentDeptInfoResponse collegeUpdateStudentDeptInfoWithOptions(CollegeUpdateStudentDeptInfoRequest request, CollegeUpdateStudentDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentNumber)) {
            query.put("studentNumber", request.studentNumber);
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
            new TeaPair("action", "CollegeUpdateStudentDeptInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/deptInfos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeUpdateStudentDeptInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新学生的部门相关信息</p>
     * 
     * @param request CollegeUpdateStudentDeptInfoRequest
     * @return CollegeUpdateStudentDeptInfoResponse
     */
    public CollegeUpdateStudentDeptInfoResponse collegeUpdateStudentDeptInfo(CollegeUpdateStudentDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateStudentDeptInfoHeaders headers = new CollegeUpdateStudentDeptInfoHeaders();
        return this.collegeUpdateStudentDeptInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新班级下学生信息</p>
     * 
     * @param request CollegeUpdateStudentInfoRequest
     * @param headers CollegeUpdateStudentInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeUpdateStudentInfoResponse
     */
    public CollegeUpdateStudentInfoResponse collegeUpdateStudentInfoWithOptions(CollegeUpdateStudentInfoRequest request, CollegeUpdateStudentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.empExtension)) {
            body.put("empExtension", request.empExtension);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.gender)) {
            body.put("gender", request.gender);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifyId)) {
            body.put("identifyId", request.identifyId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startYear)) {
            body.put("startYear", request.startYear);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            body.put("studentId", request.studentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentName)) {
            body.put("studentName", request.studentName);
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
            new TeaPair("action", "CollegeUpdateStudentInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/depts/students"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeUpdateStudentInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新班级下学生信息</p>
     * 
     * @param request CollegeUpdateStudentInfoRequest
     * @return CollegeUpdateStudentInfoResponse
     */
    public CollegeUpdateStudentInfoResponse collegeUpdateStudentInfo(CollegeUpdateStudentInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateStudentInfoHeaders headers = new CollegeUpdateStudentInfoHeaders();
        return this.collegeUpdateStudentInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改学生手机号</p>
     * 
     * @param request CollegeUpdateStudentMoblieRequest
     * @param headers CollegeUpdateStudentMoblieHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CollegeUpdateStudentMoblieResponse
     */
    public CollegeUpdateStudentMoblieResponse collegeUpdateStudentMoblieWithOptions(CollegeUpdateStudentMoblieRequest request, CollegeUpdateStudentMoblieHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isForce)) {
            query.put("isForce", request.isForce);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newMobile)) {
            query.put("newMobile", request.newMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.studentId)) {
            query.put("studentId", request.studentId);
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
            new TeaPair("action", "CollegeUpdateStudentMoblie"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/colleges/members/students/mobiles"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CollegeUpdateStudentMoblieResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改学生手机号</p>
     * 
     * @param request CollegeUpdateStudentMoblieRequest
     * @return CollegeUpdateStudentMoblieResponse
     */
    public CollegeUpdateStudentMoblieResponse collegeUpdateStudentMoblie(CollegeUpdateStudentMoblieRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CollegeUpdateStudentMoblieHeaders headers = new CollegeUpdateStudentMoblieHeaders();
        return this.collegeUpdateStudentMoblieWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义通讯录</p>
     * 
     * @param request CustomizeContactCreateRequest
     * @param headers CustomizeContactCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactCreateResponse
     */
    public CustomizeContactCreateResponse customizeContactCreateWithOptions(CustomizeContactCreateRequest request, CustomizeContactCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
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
            new TeaPair("action", "CustomizeContactCreate"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/contacts"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactCreateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义通讯录</p>
     * 
     * @param request CustomizeContactCreateRequest
     * @return CustomizeContactCreateResponse
     */
    public CustomizeContactCreateResponse customizeContactCreate(CustomizeContactCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
        return this.customizeContactCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除自定义通讯录</p>
     * 
     * @param request CustomizeContactDeleteRequest
     * @param headers CustomizeContactDeleteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactDeleteResponse
     */
    public CustomizeContactDeleteResponse customizeContactDeleteWithOptions(CustomizeContactDeleteRequest request, CustomizeContactDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CustomizeContactDelete"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/contacts"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactDeleteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除自定义通讯录</p>
     * 
     * @param request CustomizeContactDeleteRequest
     * @return CustomizeContactDeleteResponse
     */
    public CustomizeContactDeleteResponse customizeContactDelete(CustomizeContactDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
        return this.customizeContactDeleteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建部门</p>
     * 
     * @param request CustomizeContactDeptCreateRequest
     * @param headers CustomizeContactDeptCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactDeptCreateResponse
     */
    public CustomizeContactDeptCreateResponse customizeContactDeptCreateWithOptions(CustomizeContactDeptCreateRequest request, CustomizeContactDeptCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDeptId)) {
            body.put("parentDeptId", request.parentDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.refId)) {
            body.put("refId", request.refId);
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
            new TeaPair("action", "CustomizeContactDeptCreate"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/departments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactDeptCreateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建部门</p>
     * 
     * @param request CustomizeContactDeptCreateRequest
     * @return CustomizeContactDeptCreateResponse
     */
    public CustomizeContactDeptCreateResponse customizeContactDeptCreate(CustomizeContactDeptCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
        return this.customizeContactDeptCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除部门</p>
     * 
     * @param request CustomizeContactDeptDeleteRequest
     * @param headers CustomizeContactDeptDeleteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactDeptDeleteResponse
     */
    public CustomizeContactDeptDeleteResponse customizeContactDeptDeleteWithOptions(CustomizeContactDeptDeleteRequest request, CustomizeContactDeptDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CustomizeContactDeptDelete"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/departments"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactDeptDeleteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除部门</p>
     * 
     * @param request CustomizeContactDeptDeleteRequest
     * @return CustomizeContactDeptDeleteResponse
     */
    public CustomizeContactDeptDeleteResponse customizeContactDeptDelete(CustomizeContactDeptDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
        return this.customizeContactDeptDeleteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义通讯录某个部门的部门群</p>
     * 
     * @param request CustomizeContactDeptGroupCreateRequest
     * @param headers CustomizeContactDeptGroupCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactDeptGroupCreateResponse
     */
    public CustomizeContactDeptGroupCreateResponse customizeContactDeptGroupCreateWithOptions(CustomizeContactDeptGroupCreateRequest request, CustomizeContactDeptGroupCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
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
            new TeaPair("action", "CustomizeContactDeptGroupCreate"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/departmentGroups"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactDeptGroupCreateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建自定义通讯录某个部门的部门群</p>
     * 
     * @param request CustomizeContactDeptGroupCreateRequest
     * @return CustomizeContactDeptGroupCreateResponse
     */
    public CustomizeContactDeptGroupCreateResponse customizeContactDeptGroupCreate(CustomizeContactDeptGroupCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptGroupCreateHeaders headers = new CustomizeContactDeptGroupCreateHeaders();
        return this.customizeContactDeptGroupCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门详情</p>
     * 
     * @param request CustomizeContactDeptInfoRequest
     * @param headers CustomizeContactDeptInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactDeptInfoResponse
     */
    public CustomizeContactDeptInfoResponse customizeContactDeptInfoWithOptions(CustomizeContactDeptInfoRequest request, CustomizeContactDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CustomizeContactDeptInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/departments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactDeptInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门详情</p>
     * 
     * @param request CustomizeContactDeptInfoRequest
     * @return CustomizeContactDeptInfoResponse
     */
    public CustomizeContactDeptInfoResponse customizeContactDeptInfo(CustomizeContactDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
        return this.customizeContactDeptInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取子部门列表</p>
     * 
     * @param request CustomizeContactDeptListRequest
     * @param headers CustomizeContactDeptListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactDeptListResponse
     */
    public CustomizeContactDeptListResponse customizeContactDeptListWithOptions(CustomizeContactDeptListRequest request, CustomizeContactDeptListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CustomizeContactDeptList"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/subsidiaryDepartments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactDeptListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取子部门列表</p>
     * 
     * @param request CustomizeContactDeptListRequest
     * @return CustomizeContactDeptListResponse
     */
    public CustomizeContactDeptListResponse customizeContactDeptList(CustomizeContactDeptListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
        return this.customizeContactDeptListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新部门</p>
     * 
     * @param request CustomizeContactDeptUpdateRequest
     * @param headers CustomizeContactDeptUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactDeptUpdateResponse
     */
    public CustomizeContactDeptUpdateResponse customizeContactDeptUpdateWithOptions(CustomizeContactDeptUpdateRequest request, CustomizeContactDeptUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentDeptId)) {
            body.put("parentDeptId", request.parentDeptId);
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
            new TeaPair("action", "CustomizeContactDeptUpdate"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/departments"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactDeptUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新部门</p>
     * 
     * @param request CustomizeContactDeptUpdateRequest
     * @return CustomizeContactDeptUpdateResponse
     */
    public CustomizeContactDeptUpdateResponse customizeContactDeptUpdate(CustomizeContactDeptUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
        return this.customizeContactDeptUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>普通部门下添加人员</p>
     * 
     * @param request CustomizeContactEmpAddRequest
     * @param headers CustomizeContactEmpAddHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactEmpAddResponse
     */
    public CustomizeContactEmpAddResponse customizeContactEmpAddWithOptions(CustomizeContactEmpAddRequest request, CustomizeContactEmpAddHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
            new TeaPair("action", "CustomizeContactEmpAdd"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/users"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactEmpAddResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>普通部门下添加人员</p>
     * 
     * @param request CustomizeContactEmpAddRequest
     * @return CustomizeContactEmpAddResponse
     */
    public CustomizeContactEmpAddResponse customizeContactEmpAdd(CustomizeContactEmpAddRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
        return this.customizeContactEmpAddWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>普通部门下移除人员</p>
     * 
     * @param request CustomizeContactEmpDeleteRequest
     * @param headers CustomizeContactEmpDeleteHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactEmpDeleteResponse
     */
    public CustomizeContactEmpDeleteResponse customizeContactEmpDeleteWithOptions(CustomizeContactEmpDeleteRequest request, CustomizeContactEmpDeleteHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            body.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
            new TeaPair("action", "CustomizeContactEmpDelete"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/users/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactEmpDeleteResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>普通部门下移除人员</p>
     * 
     * @param request CustomizeContactEmpDeleteRequest
     * @return CustomizeContactEmpDeleteResponse
     */
    public CustomizeContactEmpDeleteResponse customizeContactEmpDelete(CustomizeContactEmpDeleteRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
        return this.customizeContactEmpDeleteWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下人员</p>
     * 
     * @param request CustomizeContactEmpListRequest
     * @param headers CustomizeContactEmpListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactEmpListResponse
     */
    public CustomizeContactEmpListResponse customizeContactEmpListWithOptions(CustomizeContactEmpListRequest request, CustomizeContactEmpListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "CustomizeContactEmpList"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactEmpListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下人员</p>
     * 
     * @param request CustomizeContactEmpListRequest
     * @return CustomizeContactEmpListResponse
     */
    public CustomizeContactEmpListResponse customizeContactEmpList(CustomizeContactEmpListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
        return this.customizeContactEmpListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取自定义通讯录列表</p>
     * 
     * @param headers CustomizeContactListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactListResponse
     */
    public CustomizeContactListResponse customizeContactListWithOptions(CustomizeContactListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "CustomizeContactList"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/contacts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取自定义通讯录列表</p>
     * @return CustomizeContactListResponse
     */
    public CustomizeContactListResponse customizeContactList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
        return this.customizeContactListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新自定义通讯录</p>
     * 
     * @param request CustomizeContactUpdateRequest
     * @param headers CustomizeContactUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CustomizeContactUpdateResponse
     */
    public CustomizeContactUpdateResponse customizeContactUpdateWithOptions(CustomizeContactUpdateRequest request, CustomizeContactUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.managerIdList)) {
            body.put("managerIdList", request.managerIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
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
            new TeaPair("action", "CustomizeContactUpdate"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/customizations/contacts"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CustomizeContactUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新自定义通讯录</p>
     * 
     * @param request CustomizeContactUpdateRequest
     * @return CustomizeContactUpdateResponse
     */
    public CustomizeContactUpdateResponse customizeContactUpdate(CustomizeContactUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
        return this.customizeContactUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>门店通业务消息推送</p>
     * 
     * @param tmpReq DIgitalStoreMessagePushRequest
     * @param headers DIgitalStoreMessagePushHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DIgitalStoreMessagePushResponse
     */
    public DIgitalStoreMessagePushResponse dIgitalStoreMessagePushWithOptions(DIgitalStoreMessagePushRequest tmpReq, DIgitalStoreMessagePushHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        DIgitalStoreMessagePushShrinkRequest request = new DIgitalStoreMessagePushShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.messageDataList)) {
            request.messageDataListShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.messageDataList, "messageDataList", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.messageDataListShrink)) {
            query.put("messageDataList", request.messageDataListShrink);
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
            new TeaPair("action", "DIgitalStoreMessagePush"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/messages/push"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DIgitalStoreMessagePushResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>门店通业务消息推送</p>
     * 
     * @param request DIgitalStoreMessagePushRequest
     * @return DIgitalStoreMessagePushResponse
     */
    public DIgitalStoreMessagePushResponse dIgitalStoreMessagePush(DIgitalStoreMessagePushRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DIgitalStoreMessagePushHeaders headers = new DIgitalStoreMessagePushHeaders();
        return this.dIgitalStoreMessagePushWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-场景卡片发送记录列表</p>
     * 
     * @param request DigitalStoreCardRecordRequest
     * @param headers DigitalStoreCardRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreCardRecordResponse
     */
    public DigitalStoreCardRecordResponse digitalStoreCardRecordWithOptions(DigitalStoreCardRecordRequest request, DigitalStoreCardRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.beginTime)) {
            body.put("beginTime", request.beginTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ids)) {
            body.put("ids", request.ids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneCardName)) {
            body.put("sceneCardName", request.sceneCardName);
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
            new TeaPair("action", "DigitalStoreCardRecord"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/cardSendRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreCardRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-场景卡片发送记录列表</p>
     * 
     * @param request DigitalStoreCardRecordRequest
     * @return DigitalStoreCardRecordResponse
     */
    public DigitalStoreCardRecordResponse digitalStoreCardRecord(DigitalStoreCardRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreCardRecordHeaders headers = new DigitalStoreCardRecordHeaders();
        return this.digitalStoreCardRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织中门店通通讯录基础信息</p>
     * 
     * @param headers DigitalStoreContactInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreContactInfoResponse
     */
    public DigitalStoreContactInfoResponse digitalStoreContactInfoWithOptions(DigitalStoreContactInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DigitalStoreContactInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/contactInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreContactInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织中门店通通讯录基础信息</p>
     * @return DigitalStoreContactInfoResponse
     */
    public DigitalStoreContactInfoResponse digitalStoreContactInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreContactInfoHeaders headers = new DigitalStoreContactInfoHeaders();
        return this.digitalStoreContactInfoWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取门店通相关会话列表（区域群、门店群）</p>
     * 
     * @param request DigitalStoreConversationsRequest
     * @param headers DigitalStoreConversationsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreConversationsResponse
     */
    public DigitalStoreConversationsResponse digitalStoreConversationsWithOptions(DigitalStoreConversationsRequest request, DigitalStoreConversationsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationTitle)) {
            query.put("conversationTitle", request.conversationTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.conversationType)) {
            query.put("conversationType", request.conversationType);
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
            new TeaPair("action", "DigitalStoreConversations"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/conversations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreConversationsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取门店通相关会话列表（区域群、门店群）</p>
     * 
     * @param request DigitalStoreConversationsRequest
     * @return DigitalStoreConversationsResponse
     */
    public DigitalStoreConversationsResponse digitalStoreConversations(DigitalStoreConversationsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreConversationsHeaders headers = new DigitalStoreConversationsHeaders();
        return this.digitalStoreConversationsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-数据监控-导出列表</p>
     * 
     * @param request DigitalStoreExportCardRecordRequest
     * @param headers DigitalStoreExportCardRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreExportCardRecordResponse
     */
    public DigitalStoreExportCardRecordResponse digitalStoreExportCardRecordWithOptions(DigitalStoreExportCardRecordRequest request, DigitalStoreExportCardRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.beginTime)) {
            body.put("beginTime", request.beginTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ids)) {
            body.put("ids", request.ids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneCardName)) {
            body.put("sceneCardName", request.sceneCardName);
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
            new TeaPair("action", "DigitalStoreExportCardRecord"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/cardRecords/export"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreExportCardRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-数据监控-导出列表</p>
     * 
     * @param request DigitalStoreExportCardRecordRequest
     * @return DigitalStoreExportCardRecordResponse
     */
    public DigitalStoreExportCardRecordResponse digitalStoreExportCardRecord(DigitalStoreExportCardRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreExportCardRecordHeaders headers = new DigitalStoreExportCardRecordHeaders();
        return this.digitalStoreExportCardRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-数据监控-导出明细</p>
     * 
     * @param request DigitalStoreExportCardRecordDetailRequest
     * @param headers DigitalStoreExportCardRecordDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreExportCardRecordDetailResponse
     */
    public DigitalStoreExportCardRecordDetailResponse digitalStoreExportCardRecordDetailWithOptions(DigitalStoreExportCardRecordDetailRequest request, DigitalStoreExportCardRecordDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.beginTime)) {
            body.put("beginTime", request.beginTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ids)) {
            body.put("ids", request.ids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneCardName)) {
            body.put("sceneCardName", request.sceneCardName);
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
            new TeaPair("action", "DigitalStoreExportCardRecordDetail"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/cardRecordDetails/export"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreExportCardRecordDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-数据监控-导出明细</p>
     * 
     * @param request DigitalStoreExportCardRecordDetailRequest
     * @return DigitalStoreExportCardRecordDetailResponse
     */
    public DigitalStoreExportCardRecordDetailResponse digitalStoreExportCardRecordDetail(DigitalStoreExportCardRecordDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreExportCardRecordDetailHeaders headers = new DigitalStoreExportCardRecordDetailHeaders();
        return this.digitalStoreExportCardRecordDetailWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的门店分组详情</p>
     * 
     * @param request DigitalStoreGroupInfoRequest
     * @param headers DigitalStoreGroupInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreGroupInfoResponse
     */
    public DigitalStoreGroupInfoResponse digitalStoreGroupInfoWithOptions(DigitalStoreGroupInfoRequest request, DigitalStoreGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupId)) {
            query.put("groupId", request.groupId);
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
            new TeaPair("action", "DigitalStoreGroupInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/groupInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreGroupInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的门店分组详情</p>
     * 
     * @param request DigitalStoreGroupInfoRequest
     * @return DigitalStoreGroupInfoResponse
     */
    public DigitalStoreGroupInfoResponse digitalStoreGroupInfo(DigitalStoreGroupInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreGroupInfoHeaders headers = new DigitalStoreGroupInfoHeaders();
        return this.digitalStoreGroupInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的分组列表</p>
     * 
     * @param headers DigitalStoreGroupsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreGroupsResponse
     */
    public DigitalStoreGroupsResponse digitalStoreGroupsWithOptions(DigitalStoreGroupsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DigitalStoreGroups"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/groups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreGroupsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的分组列表</p>
     * @return DigitalStoreGroupsResponse
     */
    public DigitalStoreGroupsResponse digitalStoreGroups() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreGroupsHeaders headers = new DigitalStoreGroupsHeaders();
        return this.digitalStoreGroupsWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录某个节点信息</p>
     * 
     * @param request DigitalStoreNodeInfoRequest
     * @param headers DigitalStoreNodeInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreNodeInfoResponse
     */
    public DigitalStoreNodeInfoResponse digitalStoreNodeInfoWithOptions(DigitalStoreNodeInfoRequest request, DigitalStoreNodeInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeId)) {
            query.put("nodeId", request.nodeId);
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
            new TeaPair("action", "DigitalStoreNodeInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/nodeInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreNodeInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录某个节点信息</p>
     * 
     * @param request DigitalStoreNodeInfoRequest
     * @return DigitalStoreNodeInfoResponse
     */
    public DigitalStoreNodeInfoResponse digitalStoreNodeInfo(DigitalStoreNodeInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreNodeInfoHeaders headers = new DigitalStoreNodeInfoHeaders();
        return this.digitalStoreNodeInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>门店通权益信息查询</p>
     * 
     * @param headers DigitalStoreRightsInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreRightsInfoResponse
     */
    public DigitalStoreRightsInfoResponse digitalStoreRightsInfoWithOptions(DigitalStoreRightsInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DigitalStoreRightsInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/rightsInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreRightsInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>门店通权益信息查询</p>
     * @return DigitalStoreRightsInfoResponse
     */
    public DigitalStoreRightsInfoResponse digitalStoreRightsInfo() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreRightsInfoHeaders headers = new DigitalStoreRightsInfoHeaders();
        return this.digitalStoreRightsInfoWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的角色列表</p>
     * 
     * @param headers DigitalStoreRolesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreRolesResponse
     */
    public DigitalStoreRolesResponse digitalStoreRolesWithOptions(DigitalStoreRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DigitalStoreRoles"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreRolesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的角色列表</p>
     * @return DigitalStoreRolesResponse
     */
    public DigitalStoreRolesResponse digitalStoreRoles() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreRolesHeaders headers = new DigitalStoreRolesHeaders();
        return this.digitalStoreRolesWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取门店通场景群的业务范围</p>
     * 
     * @param request DigitalStoreSceneScopeRequest
     * @param headers DigitalStoreSceneScopeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreSceneScopeResponse
     */
    public DigitalStoreSceneScopeResponse digitalStoreSceneScopeWithOptions(DigitalStoreSceneScopeRequest request, DigitalStoreSceneScopeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openConversationId)) {
            query.put("openConversationId", request.openConversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sceneCode)) {
            query.put("sceneCode", request.sceneCode);
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
            new TeaPair("action", "DigitalStoreSceneScope"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/sceneScopes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreSceneScopeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取门店通场景群的业务范围</p>
     * 
     * @param request DigitalStoreSceneScopeRequest
     * @return DigitalStoreSceneScopeResponse
     */
    public DigitalStoreSceneScopeResponse digitalStoreSceneScope(DigitalStoreSceneScopeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreSceneScopeHeaders headers = new DigitalStoreSceneScopeHeaders();
        return this.digitalStoreSceneScopeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的门店详情</p>
     * 
     * @param request DigitalStoreStoreInfoRequest
     * @param headers DigitalStoreStoreInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreStoreInfoResponse
     */
    public DigitalStoreStoreInfoResponse digitalStoreStoreInfoWithOptions(DigitalStoreStoreInfoRequest request, DigitalStoreStoreInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.storeId)) {
            query.put("storeId", request.storeId);
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
            new TeaPair("action", "DigitalStoreStoreInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/storeInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreStoreInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通中的门店详情</p>
     * 
     * @param request DigitalStoreStoreInfoRequest
     * @return DigitalStoreStoreInfoResponse
     */
    public DigitalStoreStoreInfoResponse digitalStoreStoreInfo(DigitalStoreStoreInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreStoreInfoHeaders headers = new DigitalStoreStoreInfoHeaders();
        return this.digitalStoreStoreInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录某个节点下的子节点</p>
     * 
     * @param request DigitalStoreSubNodesRequest
     * @param headers DigitalStoreSubNodesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreSubNodesResponse
     */
    public DigitalStoreSubNodesResponse digitalStoreSubNodesWithOptions(DigitalStoreSubNodesRequest request, DigitalStoreSubNodesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeId)) {
            query.put("nodeId", request.nodeId);
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
            new TeaPair("action", "DigitalStoreSubNodes"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/subsidiaryNodes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreSubNodesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录某个节点下的子节点</p>
     * 
     * @param request DigitalStoreSubNodesRequest
     * @return DigitalStoreSubNodesResponse
     */
    public DigitalStoreSubNodesResponse digitalStoreSubNodes(DigitalStoreSubNodesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreSubNodesHeaders headers = new DigitalStoreSubNodesHeaders();
        return this.digitalStoreSubNodesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改人员管辖范围以及所属角色</p>
     * 
     * @param request DigitalStoreUpdateAuthInfoRequest
     * @param headers DigitalStoreUpdateAuthInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreUpdateAuthInfoResponse
     */
    public DigitalStoreUpdateAuthInfoResponse digitalStoreUpdateAuthInfoWithOptions(DigitalStoreUpdateAuthInfoRequest request, DigitalStoreUpdateAuthInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.updateUserList)) {
            body.put("updateUserList", request.updateUserList);
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
            new TeaPair("action", "DigitalStoreUpdateAuthInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/authInfos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreUpdateAuthInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改人员管辖范围以及所属角色</p>
     * 
     * @param request DigitalStoreUpdateAuthInfoRequest
     * @return DigitalStoreUpdateAuthInfoResponse
     */
    public DigitalStoreUpdateAuthInfoResponse digitalStoreUpdateAuthInfo(DigitalStoreUpdateAuthInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreUpdateAuthInfoHeaders headers = new DigitalStoreUpdateAuthInfoHeaders();
        return this.digitalStoreUpdateAuthInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录人员信息</p>
     * 
     * @param request DigitalStoreUserInfoRequest
     * @param headers DigitalStoreUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreUserInfoResponse
     */
    public DigitalStoreUserInfoResponse digitalStoreUserInfoWithOptions(DigitalStoreUserInfoRequest request, DigitalStoreUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
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
            new TeaPair("action", "DigitalStoreUserInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/userInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录人员信息</p>
     * 
     * @param request DigitalStoreUserInfoRequest
     * @return DigitalStoreUserInfoResponse
     */
    public DigitalStoreUserInfoResponse digitalStoreUserInfo(DigitalStoreUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreUserInfoHeaders headers = new DigitalStoreUserInfoHeaders();
        return this.digitalStoreUserInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录某个节点下的所有人员</p>
     * 
     * @param request DigitalStoreUsersRequest
     * @param headers DigitalStoreUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStoreUsersResponse
     */
    public DigitalStoreUsersResponse digitalStoreUsersWithOptions(DigitalStoreUsersRequest request, DigitalStoreUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nodeId)) {
            query.put("nodeId", request.nodeId);
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
            new TeaPair("action", "DigitalStoreUsers"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/nodes/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStoreUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询门店通讯录某个节点下的所有人员</p>
     * 
     * @param request DigitalStoreUsersRequest
     * @return DigitalStoreUsersResponse
     */
    public DigitalStoreUsersResponse digitalStoreUsers(DigitalStoreUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStoreUsersHeaders headers = new DigitalStoreUsersHeaders();
        return this.digitalStoreUsersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-数据监控-查询导出任务的记录列表</p>
     * 
     * @param request DigitalStorelistExportTaskRecordRequest
     * @param headers DigitalStorelistExportTaskRecordHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DigitalStorelistExportTaskRecordResponse
     */
    public DigitalStorelistExportTaskRecordResponse digitalStorelistExportTaskRecordWithOptions(DigitalStorelistExportTaskRecordRequest request, DigitalStorelistExportTaskRecordHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DigitalStorelistExportTaskRecord"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/digitalStores/exportTaskRecords"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DigitalStorelistExportTaskRecordResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>群运营-数据监控-查询导出任务的记录列表</p>
     * 
     * @param request DigitalStorelistExportTaskRecordRequest
     * @return DigitalStorelistExportTaskRecordResponse
     */
    public DigitalStorelistExportTaskRecordResponse digitalStorelistExportTaskRecord(DigitalStorelistExportTaskRecordRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DigitalStorelistExportTaskRecordHeaders headers = new DigitalStorelistExportTaskRecordHeaders();
        return this.digitalStorelistExportTaskRecordWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询启用了当前应用的外部协作组织</p>
     * 
     * @param request ExternalQueryExternalAppOrgsRequest
     * @param headers ExternalQueryExternalAppOrgsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExternalQueryExternalAppOrgsResponse
     */
    public ExternalQueryExternalAppOrgsResponse externalQueryExternalAppOrgsWithOptions(ExternalQueryExternalAppOrgsRequest request, ExternalQueryExternalAppOrgsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.externalType)) {
            query.put("externalType", request.externalType);
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
            new TeaPair("action", "ExternalQueryExternalAppOrgs"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/externals/apps/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExternalQueryExternalAppOrgsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询启用了当前应用的外部协作组织</p>
     * 
     * @param request ExternalQueryExternalAppOrgsRequest
     * @return ExternalQueryExternalAppOrgsResponse
     */
    public ExternalQueryExternalAppOrgsResponse externalQueryExternalAppOrgs(ExternalQueryExternalAppOrgsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExternalQueryExternalAppOrgsHeaders headers = new ExternalQueryExternalAppOrgsHeaders();
        return this.externalQueryExternalAppOrgsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询归属的主组织</p>
     * 
     * @param request ExternalQueryExternalBelongMainOrgRequest
     * @param headers ExternalQueryExternalBelongMainOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExternalQueryExternalBelongMainOrgResponse
     */
    public ExternalQueryExternalBelongMainOrgResponse externalQueryExternalBelongMainOrgWithOptions(ExternalQueryExternalBelongMainOrgRequest request, ExternalQueryExternalBelongMainOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.externalType)) {
            query.put("externalType", request.externalType);
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
            new TeaPair("action", "ExternalQueryExternalBelongMainOrg"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/externals/attributions/masterOrganizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExternalQueryExternalBelongMainOrgResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询归属的主组织</p>
     * 
     * @param request ExternalQueryExternalBelongMainOrgRequest
     * @return ExternalQueryExternalBelongMainOrgResponse
     */
    public ExternalQueryExternalBelongMainOrgResponse externalQueryExternalBelongMainOrg(ExternalQueryExternalBelongMainOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExternalQueryExternalBelongMainOrgHeaders headers = new ExternalQueryExternalBelongMainOrgHeaders();
        return this.externalQueryExternalBelongMainOrgWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询外部协作组织</p>
     * 
     * @param request ExternalQueryExternalOrgsRequest
     * @param headers ExternalQueryExternalOrgsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExternalQueryExternalOrgsResponse
     */
    public ExternalQueryExternalOrgsResponse externalQueryExternalOrgsWithOptions(ExternalQueryExternalOrgsRequest request, ExternalQueryExternalOrgsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.externalType)) {
            query.put("externalType", request.externalType);
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
            new TeaPair("action", "ExternalQueryExternalOrgs"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/externals/organizations"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExternalQueryExternalOrgsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询外部协作组织</p>
     * 
     * @param request ExternalQueryExternalOrgsRequest
     * @return ExternalQueryExternalOrgsResponse
     */
    public ExternalQueryExternalOrgsResponse externalQueryExternalOrgs(ExternalQueryExternalOrgsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExternalQueryExternalOrgsHeaders headers = new ExternalQueryExternalOrgsHeaders();
        return this.externalQueryExternalOrgsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>getTaskPackageResult</p>
     * 
     * @param request GetTaskPackageResultRequest
     * @param headers GetTaskPackageResultHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTaskPackageResultResponse
     */
    public GetTaskPackageResultResponse getTaskPackageResultWithOptions(GetTaskPackageResultRequest request, GetTaskPackageResultHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPackageId)) {
            body.put("taskPackageId", request.taskPackageId);
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
            new TeaPair("action", "GetTaskPackageResult"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/ai/taskPackages/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTaskPackageResultResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>getTaskPackageResult</p>
     * 
     * @param request GetTaskPackageResultRequest
     * @return GetTaskPackageResultResponse
     */
    public GetTaskPackageResultResponse getTaskPackageResult(GetTaskPackageResultRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTaskPackageResultHeaders headers = new GetTaskPackageResultHeaders();
        return this.getTaskPackageResultWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>医疗数据对账</p>
     * 
     * @param request HospitalDataCheckRequest
     * @param headers HospitalDataCheckHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return HospitalDataCheckResponse
     */
    public HospitalDataCheckResponse hospitalDataCheckWithOptions(HospitalDataCheckRequest request, HospitalDataCheckHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.allDeptCount)) {
            body.put("allDeptCount", request.allDeptCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allDeptUserCount)) {
            body.put("allDeptUserCount", request.allDeptUserCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allGroupCount)) {
            body.put("allGroupCount", request.allGroupCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allGroupUserCount)) {
            body.put("allGroupUserCount", request.allGroupUserCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptCount)) {
            body.put("deptCount", request.deptCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptUserCount)) {
            body.put("deptUserCount", request.deptUserCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupCount)) {
            body.put("groupCount", request.groupCount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupUserCount)) {
            body.put("groupUserCount", request.groupUserCount);
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
            new TeaPair("action", "HospitalDataCheck"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/datas/check"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new HospitalDataCheckResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>医疗数据对账</p>
     * 
     * @param request HospitalDataCheckRequest
     * @return HospitalDataCheckResponse
     */
    public HospitalDataCheckResponse hospitalDataCheck(HospitalDataCheckRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        HospitalDataCheckHeaders headers = new HospitalDataCheckHeaders();
        return this.hospitalDataCheckWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>行业化制造业事件中心</p>
     * 
     * @param request IndustryManufactureCommonEventRequest
     * @param headers IndustryManufactureCommonEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureCommonEventResponse
     */
    public IndustryManufactureCommonEventResponse industryManufactureCommonEventWithOptions(IndustryManufactureCommonEventRequest request, IndustryManufactureCommonEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizData)) {
            body.put("bizData", request.bizData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eventType)) {
            body.put("eventType", request.eventType);
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
            new TeaPair("action", "IndustryManufactureCommonEvent"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturing/bases/commons/events"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureCommonEventResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>行业化制造业事件中心</p>
     * 
     * @param request IndustryManufactureCommonEventRequest
     * @return IndustryManufactureCommonEventResponse
     */
    public IndustryManufactureCommonEventResponse industryManufactureCommonEvent(IndustryManufactureCommonEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureCommonEventHeaders headers = new IndustryManufactureCommonEventHeaders();
        return this.industryManufactureCommonEventWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>物料成本开放服务</p>
     * 
     * @param request IndustryManufactureCostRecordListGetRequest
     * @param headers IndustryManufactureCostRecordListGetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureCostRecordListGetResponse
     */
    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGetWithOptions(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionTaskNo)) {
            body.put("productionTaskNo", request.productionTaskNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
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
            new TeaPair("action", "IndustryManufactureCostRecordListGet"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufactures/materialCostRecords/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureCostRecordListGetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>物料成本开放服务</p>
     * 
     * @param request IndustryManufactureCostRecordListGetRequest
     * @return IndustryManufactureCostRecordListGetResponse
     */
    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGet(IndustryManufactureCostRecordListGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
        return this.industryManufactureCostRecordListGetWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>费用服务</p>
     * 
     * @param request IndustryManufactureFeeListGetRequest
     * @param headers IndustryManufactureFeeListGetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureFeeListGetResponse
     */
    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGetWithOptions(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionTaskNo)) {
            body.put("productionTaskNo", request.productionTaskNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
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
            new TeaPair("action", "IndustryManufactureFeeListGet"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufactures/fees/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureFeeListGetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>费用服务</p>
     * 
     * @param request IndustryManufactureFeeListGetRequest
     * @return IndustryManufactureFeeListGetResponse
     */
    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGet(IndustryManufactureFeeListGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
        return this.industryManufactureFeeListGetWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>行业化-制造业工价接口</p>
     * 
     * @param request IndustryManufactureLabourCostRequest
     * @param headers IndustryManufactureLabourCostHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureLabourCostResponse
     */
    public IndustryManufactureLabourCostResponse industryManufactureLabourCostWithOptions(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processNo)) {
            body.put("processNo", request.processNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
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
            new TeaPair("action", "IndustryManufactureLabourCost"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufactures/labourCosts/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureLabourCostResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>行业化-制造业工价接口</p>
     * 
     * @param request IndustryManufactureLabourCostRequest
     * @return IndustryManufactureLabourCostResponse
     */
    public IndustryManufactureLabourCostResponse industryManufactureLabourCost(IndustryManufactureLabourCostRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
        return this.industryManufactureLabourCostWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询行业物料列表</p>
     * 
     * @param request IndustryManufactureMaterialListRequest
     * @param headers IndustryManufactureMaterialListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMaterialListResponse
     */
    public IndustryManufactureMaterialListResponse industryManufactureMaterialListWithOptions(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.currentPage)) {
            body.put("currentPage", request.currentPage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
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
            new TeaPair("action", "IndustryManufactureMaterialList"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufactures/materials/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMaterialListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询行业物料列表</p>
     * 
     * @param request IndustryManufactureMaterialListRequest
     * @return IndustryManufactureMaterialListResponse
     */
    public IndustryManufactureMaterialListResponse industryManufactureMaterialList(IndustryManufactureMaterialListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
        return this.industryManufactureMaterialListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>派工任务管理</p>
     * 
     * @param request IndustryManufactureMesDispatchTaskRequest
     * @param headers IndustryManufactureMesDispatchTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesDispatchTaskResponse
     */
    public IndustryManufactureMesDispatchTaskResponse industryManufactureMesDispatchTaskWithOptions(IndustryManufactureMesDispatchTaskRequest request, IndustryManufactureMesDispatchTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defectsAmount)) {
            body.put("defectsAmount", request.defectsAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dispatchStaffName)) {
            body.put("dispatchStaffName", request.dispatchStaffName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dispatchStaffNo)) {
            body.put("dispatchStaffNo", request.dispatchStaffNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fineAmount)) {
            body.put("fineAmount", request.fineAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overdue)) {
            body.put("overdue", request.overdue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planQuantity)) {
            body.put("planQuantity", request.planQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processName)) {
            body.put("processName", request.processName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuid)) {
            body.put("processUuid", request.processUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectStatus)) {
            body.put("projectStatus", request.projectStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskOperators)) {
            body.put("taskOperators", request.taskOperators);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanEndTime)) {
            body.put("taskPlanEndTime", request.taskPlanEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanStartTime)) {
            body.put("taskPlanStartTime", request.taskPlanStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskStatus)) {
            body.put("taskStatus", request.taskStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamId)) {
            body.put("teamId", request.teamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "IndustryManufactureMesDispatchTask"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturings/dispatchTasks/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesDispatchTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>派工任务管理</p>
     * 
     * @param request IndustryManufactureMesDispatchTaskRequest
     * @return IndustryManufactureMesDispatchTaskResponse
     */
    public IndustryManufactureMesDispatchTaskResponse industryManufactureMesDispatchTask(IndustryManufactureMesDispatchTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesDispatchTaskHeaders headers = new IndustryManufactureMesDispatchTaskHeaders();
        return this.industryManufactureMesDispatchTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>MES系统物料管理</p>
     * 
     * @param request IndustryManufactureMesMaterialRequest
     * @param headers IndustryManufactureMesMaterialHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesMaterialResponse
     */
    public IndustryManufactureMesMaterialResponse industryManufactureMesMaterialWithOptions(IndustryManufactureMesMaterialRequest request, IndustryManufactureMesMaterialHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.category)) {
            body.put("category", request.category);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prop)) {
            body.put("prop", request.prop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unit)) {
            body.put("unit", request.unit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "IndustryManufactureMesMaterial"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturings/materials/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesMaterialResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>MES系统物料管理</p>
     * 
     * @param request IndustryManufactureMesMaterialRequest
     * @return IndustryManufactureMesMaterialResponse
     */
    public IndustryManufactureMesMaterialResponse industryManufactureMesMaterial(IndustryManufactureMesMaterialRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesMaterialHeaders headers = new IndustryManufactureMesMaterialHeaders();
        return this.industryManufactureMesMaterialWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生产委外工单管理</p>
     * 
     * @param request IndustryManufactureMesOutPlanRequest
     * @param headers IndustryManufactureMesOutPlanHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesOutPlanResponse
     */
    public IndustryManufactureMesOutPlanResponse industryManufactureMesOutPlanWithOptions(IndustryManufactureMesOutPlanRequest request, IndustryManufactureMesOutPlanHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.approvalStatus)) {
            body.put("approvalStatus", request.approvalStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approver)) {
            body.put("approver", request.approver);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outSourceProjectCode)) {
            body.put("outSourceProjectCode", request.outSourceProjectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outSourceTeamId)) {
            body.put("outSourceTeamId", request.outSourceTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.price)) {
            body.put("price", request.price);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processIdentificationCode)) {
            body.put("processIdentificationCode", request.processIdentificationCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuids)) {
            body.put("processUuids", request.processUuids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendPlanQuantity)) {
            body.put("sendPlanQuantity", request.sendPlanQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplierCode)) {
            body.put("supplierCode", request.supplierCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplierName)) {
            body.put("supplierName", request.supplierName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.totalWage)) {
            body.put("totalWage", request.totalWage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "IndustryManufactureMesOutPlan"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturings/outPlans/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesOutPlanResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生产委外工单管理</p>
     * 
     * @param request IndustryManufactureMesOutPlanRequest
     * @return IndustryManufactureMesOutPlanResponse
     */
    public IndustryManufactureMesOutPlanResponse industryManufactureMesOutPlan(IndustryManufactureMesOutPlanRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesOutPlanHeaders headers = new IndustryManufactureMesOutPlanHeaders();
        return this.industryManufactureMesOutPlanWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生产报工管理</p>
     * 
     * @param request IndustryManufactureMesOutputRequest
     * @param headers IndustryManufactureMesOutputHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesOutputResponse
     */
    public IndustryManufactureMesOutputResponse industryManufactureMesOutputWithOptions(IndustryManufactureMesOutputRequest request, IndustryManufactureMesOutputHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.approveStatus)) {
            body.put("approveStatus", request.approveStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defectsAmount)) {
            body.put("defectsAmount", request.defectsAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defectsReason)) {
            body.put("defectsReason", request.defectsReason);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fineAmount)) {
            body.put("fineAmount", request.fineAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hasQualityTest)) {
            body.put("hasQualityTest", request.hasQualityTest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overdue)) {
            body.put("overdue", request.overdue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planQuantity)) {
            body.put("planQuantity", request.planQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.priority)) {
            body.put("priority", request.priority);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processName)) {
            body.put("processName", request.processName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuid)) {
            body.put("processUuid", request.processUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectCode)) {
            body.put("projectCode", request.projectCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectId)) {
            body.put("projectId", request.projectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.projectStatus)) {
            body.put("projectStatus", request.projectStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualityTestStatus)) {
            body.put("qualityTestStatus", request.qualityTestStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanEndTime)) {
            body.put("taskPlanEndTime", request.taskPlanEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPlanStartTime)) {
            body.put("taskPlanStartTime", request.taskPlanStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskStatus)) {
            body.put("taskStatus", request.taskStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskType)) {
            body.put("taskType", request.taskType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskUuid)) {
            body.put("taskUuid", request.taskUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamId)) {
            body.put("teamId", request.teamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userName)) {
            body.put("userName", request.userName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "IndustryManufactureMesOutput"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturings/outputs/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesOutputResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生产报工管理</p>
     * 
     * @param request IndustryManufactureMesOutputRequest
     * @return IndustryManufactureMesOutputResponse
     */
    public IndustryManufactureMesOutputResponse industryManufactureMesOutput(IndustryManufactureMesOutputRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesOutputHeaders headers = new IndustryManufactureMesOutputHeaders();
        return this.industryManufactureMesOutputWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>MES系统工序管理</p>
     * 
     * @param request IndustryManufactureMesProcessRequest
     * @param headers IndustryManufactureMesProcessHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesProcessResponse
     */
    public IndustryManufactureMesProcessResponse industryManufactureMesProcessWithOptions(IndustryManufactureMesProcessRequest request, IndustryManufactureMesProcessHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needDispatch)) {
            body.put("needDispatch", request.needDispatch);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.needQualityTest)) {
            body.put("needQualityTest", request.needQualityTest);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.no)) {
            body.put("no", request.no);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.price)) {
            body.put("price", request.price);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.prop)) {
            body.put("prop", request.prop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sop)) {
            body.put("sop", request.sop);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "IndustryManufactureMesProcess"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturings/processes/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesProcessResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>MES系统工序管理</p>
     * 
     * @param request IndustryManufactureMesProcessRequest
     * @return IndustryManufactureMesProcessResponse
     */
    public IndustryManufactureMesProcessResponse industryManufactureMesProcess(IndustryManufactureMesProcessRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesProcessHeaders headers = new IndustryManufactureMesProcessHeaders();
        return this.industryManufactureMesProcessWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生产工单管理</p>
     * 
     * @param request IndustryManufactureMesProductionPlanRequest
     * @param headers IndustryManufactureMesProductionPlanHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesProductionPlanResponse
     */
    public IndustryManufactureMesProductionPlanResponse industryManufactureMesProductionPlanWithOptions(IndustryManufactureMesProductionPlanRequest request, IndustryManufactureMesProductionPlanHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actualEndTime)) {
            body.put("actualEndTime", request.actualEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.actualStartTime)) {
            body.put("actualStartTime", request.actualStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bomUuid)) {
            body.put("bomUuid", request.bomUuid);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.events)) {
            body.put("events", request.events);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.no)) {
            body.put("no", request.no);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.overdue)) {
            body.put("overdue", request.overdue);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planEndTime)) {
            body.put("planEndTime", request.planEndTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planQuantity)) {
            body.put("planQuantity", request.planQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.planStartTime)) {
            body.put("planStartTime", request.planStartTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processUuids)) {
            body.put("processUuids", request.processUuids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productCode)) {
            body.put("productCode", request.productCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productName)) {
            body.put("productName", request.productName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productSpecification)) {
            body.put("productSpecification", request.productSpecification);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.qualifiedQuantity)) {
            body.put("qualifiedQuantity", request.qualifiedQuantity);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sellOrderNo)) {
            body.put("sellOrderNo", request.sellOrderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.status)) {
            body.put("status", request.status);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.teamList)) {
            body.put("teamList", request.teamList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unit)) {
            body.put("unit", request.unit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "IndustryManufactureMesProductionPlan"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturings/productionPlans/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesProductionPlanResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生产工单管理</p>
     * 
     * @param request IndustryManufactureMesProductionPlanRequest
     * @return IndustryManufactureMesProductionPlanResponse
     */
    public IndustryManufactureMesProductionPlanResponse industryManufactureMesProductionPlan(IndustryManufactureMesProductionPlanRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesProductionPlanHeaders headers = new IndustryManufactureMesProductionPlanHeaders();
        return this.industryManufactureMesProductionPlanWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>生产委外合作班组管理</p>
     * 
     * @param request IndustryManufactureMesSubCooperationTeamRequest
     * @param headers IndustryManufactureMesSubCooperationTeamHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesSubCooperationTeamResponse
     */
    public IndustryManufactureMesSubCooperationTeamResponse industryManufactureMesSubCooperationTeamWithOptions(IndustryManufactureMesSubCooperationTeamRequest request, IndustryManufactureMesSubCooperationTeamHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.events)) {
            body.put("events", request.events);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupPlugins)) {
            body.put("groupPlugins", request.groupPlugins);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            body.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaders)) {
            body.put("leaders", request.leaders);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outCorpId)) {
            body.put("outCorpId", request.outCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processIds)) {
            body.put("processIds", request.processIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uuid)) {
            body.put("uuid", request.uuid);
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
            new TeaPair("action", "IndustryManufactureMesSubCooperationTeam"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturings/outTeams/manage"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesSubCooperationTeamResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>生产委外合作班组管理</p>
     * 
     * @param request IndustryManufactureMesSubCooperationTeamRequest
     * @return IndustryManufactureMesSubCooperationTeamResponse
     */
    public IndustryManufactureMesSubCooperationTeamResponse industryManufactureMesSubCooperationTeam(IndustryManufactureMesSubCooperationTeamRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesSubCooperationTeamHeaders headers = new IndustryManufactureMesSubCooperationTeamHeaders();
        return this.industryManufactureMesSubCooperationTeamWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>MES系统班组管理</p>
     * 
     * @param request IndustryManufactureMesTeamMgmtRequest
     * @param headers IndustryManufactureMesTeamMgmtHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryManufactureMesTeamMgmtResponse
     */
    public IndustryManufactureMesTeamMgmtResponse industryManufactureMesTeamMgmtWithOptions(IndustryManufactureMesTeamMgmtRequest request, IndustryManufactureMesTeamMgmtHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.action)) {
            body.put("action", request.action);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appKey)) {
            body.put("appKey", request.appKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.baseDataName)) {
            body.put("baseDataName", request.baseDataName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.events)) {
            body.put("events", request.events);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.extendData)) {
            body.put("extendData", request.extendData);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupConfig)) {
            body.put("groupConfig", request.groupConfig);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupPlugins)) {
            body.put("groupPlugins", request.groupPlugins);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            body.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.leaders)) {
            body.put("leaders", request.leaders);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processIds)) {
            body.put("processIds", request.processIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagKey)) {
            body.put("tagKey", request.tagKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tagValues)) {
            body.put("tagValues", request.tagValues);
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
            new TeaPair("action", "IndustryManufactureMesTeamMgmt"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufacturing/base/data/team"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryManufactureMesTeamMgmtResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>MES系统班组管理</p>
     * 
     * @param request IndustryManufactureMesTeamMgmtRequest
     * @return IndustryManufactureMesTeamMgmtResponse
     */
    public IndustryManufactureMesTeamMgmtResponse industryManufactureMesTeamMgmt(IndustryManufactureMesTeamMgmtRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryManufactureMesTeamMgmtHeaders headers = new IndustryManufactureMesTeamMgmtHeaders();
        return this.industryManufactureMesTeamMgmtWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>物料成本查询服务</p>
     * 
     * @param request IndustryMmanufactureMaterialCostGetRequest
     * @param headers IndustryMmanufactureMaterialCostGetHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return IndustryMmanufactureMaterialCostGetResponse
     */
    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGetWithOptions(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
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

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
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
            new TeaPair("action", "IndustryMmanufactureMaterialCostGet"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/manufactures/base/materialCosts/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new IndustryMmanufactureMaterialCostGetResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>物料成本查询服务</p>
     * 
     * @param request IndustryMmanufactureMaterialCostGetRequest
     * @return IndustryMmanufactureMaterialCostGetResponse
     */
    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGet(IndustryMmanufactureMaterialCostGetRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
        return this.industryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>提供text和card两种形式工作通知消息</p>
     * 
     * @param request PushDingMessageRequest
     * @param headers PushDingMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return PushDingMessageResponse
     */
    public PushDingMessageResponse pushDingMessageWithOptions(PushDingMessageRequest request, PushDingMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.content)) {
            body.put("content", request.content);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageType)) {
            body.put("messageType", request.messageType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.messageUrl)) {
            body.put("messageUrl", request.messageUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pictureUrl)) {
            body.put("pictureUrl", request.pictureUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.singleTitle)) {
            body.put("singleTitle", request.singleTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.singleUrl)) {
            body.put("singleUrl", request.singleUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.title)) {
            body.put("title", request.title);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
            new TeaPair("action", "PushDingMessage"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/works/notice"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new PushDingMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>提供text和card两种形式工作通知消息</p>
     * 
     * @param request PushDingMessageRequest
     * @return PushDingMessageResponse
     */
    public PushDingMessageResponse pushDingMessage(PushDingMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        PushDingMessageHeaders headers = new PushDingMessageHeaders();
        return this.pushDingMessageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前组织下的所有科室</p>
     * 
     * @param request QueryAllDepartmentRequest
     * @param headers QueryAllDepartmentHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllDepartmentResponse
     */
    public QueryAllDepartmentResponse queryAllDepartmentWithOptions(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryAllDepartment"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/departments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllDepartmentResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前组织下的所有科室</p>
     * 
     * @param request QueryAllDepartmentRequest
     * @return QueryAllDepartmentResponse
     */
    public QueryAllDepartmentResponse queryAllDepartment(QueryAllDepartmentRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
        return this.queryAllDepartmentWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院下的所有医生</p>
     * 
     * @param request QueryAllDoctorsRequest
     * @param headers QueryAllDoctorsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllDoctorsResponse
     */
    public QueryAllDoctorsResponse queryAllDoctorsWithOptions(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNum)) {
            query.put("pageNum", request.pageNum);
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
            new TeaPair("action", "QueryAllDoctors"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/doctors"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllDoctorsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院下的所有医生</p>
     * 
     * @param request QueryAllDoctorsRequest
     * @return QueryAllDoctorsResponse
     */
    public QueryAllDoctorsResponse queryAllDoctors(QueryAllDoctorsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
        return this.queryAllDoctorsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询所有医疗组</p>
     * 
     * @param request QueryAllGroupRequest
     * @param headers QueryAllGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllGroupResponse
     */
    public QueryAllGroupResponse queryAllGroupWithOptions(QueryAllGroupRequest request, QueryAllGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryAllGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/groups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询所有医疗组</p>
     * 
     * @param request QueryAllGroupRequest
     * @return QueryAllGroupResponse
     */
    public QueryAllGroupResponse queryAllGroup(QueryAllGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
        return this.queryAllGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询科室下的所有医疗组</p>
     * 
     * @param request QueryAllGroupsInDeptRequest
     * @param headers QueryAllGroupsInDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllGroupsInDeptResponse
     */
    public QueryAllGroupsInDeptResponse queryAllGroupsInDeptWithOptions(String deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryAllGroupsInDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/departments/" + deptId + "/groups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllGroupsInDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询科室下的所有医疗组</p>
     * 
     * @param request QueryAllGroupsInDeptRequest
     * @return QueryAllGroupsInDeptResponse
     */
    public QueryAllGroupsInDeptResponse queryAllGroupsInDept(String deptId, QueryAllGroupsInDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
        return this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询科室下的所有人员</p>
     * 
     * @param request QueryAllMemberByDeptRequest
     * @param headers QueryAllMemberByDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllMemberByDeptResponse
     */
    public QueryAllMemberByDeptResponse queryAllMemberByDeptWithOptions(String deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
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
            new TeaPair("action", "QueryAllMemberByDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/departments/" + deptId + "/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllMemberByDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询科室下的所有人员</p>
     * 
     * @param request QueryAllMemberByDeptRequest
     * @return QueryAllMemberByDeptResponse
     */
    public QueryAllMemberByDeptResponse queryAllMemberByDept(String deptId, QueryAllMemberByDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
        return this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取医疗组下面的所有成员</p>
     * 
     * @param request QueryAllMemberByGroupRequest
     * @param headers QueryAllMemberByGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryAllMemberByGroupResponse
     */
    public QueryAllMemberByGroupResponse queryAllMemberByGroupWithOptions(String groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
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
            new TeaPair("action", "QueryAllMemberByGroup"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/groups/" + groupId + "/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryAllMemberByGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取医疗组下面的所有成员</p>
     * 
     * @param request QueryAllMemberByGroupRequest
     * @return QueryAllMemberByGroupResponse
     */
    public QueryAllMemberByGroupResponse queryAllMemberByGroup(String groupId, QueryAllMemberByGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
        return this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前企业医疗通讯录的业务操作日志</p>
     * 
     * @param request QueryBizOptLogRequest
     * @param headers QueryBizOptLogHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryBizOptLogResponse
     */
    public QueryBizOptLogResponse queryBizOptLogWithOptions(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
            new TeaPair("action", "QueryBizOptLog"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/bizOptLogs"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryBizOptLogResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取当前企业医疗通讯录的业务操作日志</p>
     * 
     * @param request QueryBizOptLogRequest
     * @return QueryBizOptLogResponse
     */
    public QueryBizOptLogResponse queryBizOptLog(QueryBizOptLogRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
        return this.queryBizOptLogWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取专属AI平台信息</p>
     * 
     * @param request QueryChatAIOXMInfoRequest
     * @param headers QueryChatAIOXMInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryChatAIOXMInfoResponse
     */
    public QueryChatAIOXMInfoResponse queryChatAIOXMInfoWithOptions(QueryChatAIOXMInfoRequest request, QueryChatAIOXMInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            body.put("code", request.code);
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
            new TeaPair("action", "QueryChatAIOXMInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/chatai/oxm/infos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryChatAIOXMInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取专属AI平台信息</p>
     * 
     * @param request QueryChatAIOXMInfoRequest
     * @return QueryChatAIOXMInfoResponse
     */
    public QueryChatAIOXMInfoResponse queryChatAIOXMInfo(QueryChatAIOXMInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryChatAIOXMInfoHeaders headers = new QueryChatAIOXMInfoHeaders();
        return this.queryChatAIOXMInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询科室和医疗组的扩展信息</p>
     * 
     * @param request QueryDepartmentExtendInfoRequest
     * @param headers QueryDepartmentExtendInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDepartmentExtendInfoResponse
     */
    public QueryDepartmentExtendInfoResponse queryDepartmentExtendInfoWithOptions(QueryDepartmentExtendInfoRequest request, QueryDepartmentExtendInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptCode)) {
            query.put("deptCode", request.deptCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.propCode)) {
            query.put("propCode", request.propCode);
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
            new TeaPair("action", "QueryDepartmentExtendInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/departments/extensions/infos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDepartmentExtendInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询科室和医疗组的扩展信息</p>
     * 
     * @param request QueryDepartmentExtendInfoRequest
     * @return QueryDepartmentExtendInfoResponse
     */
    public QueryDepartmentExtendInfoResponse queryDepartmentExtendInfo(QueryDepartmentExtendInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDepartmentExtendInfoHeaders headers = new QueryDepartmentExtendInfoHeaders();
        return this.queryDepartmentExtendInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门详情</p>
     * 
     * @param headers QueryDepartmentInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDepartmentInfoResponse
     */
    public QueryDepartmentInfoResponse queryDepartmentInfoWithOptions(String deptId, QueryDepartmentInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryDepartmentInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/departments/" + deptId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDepartmentInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门详情</p>
     * @return QueryDepartmentInfoResponse
     */
    public QueryDepartmentInfoResponse queryDepartmentInfo(String deptId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
        return this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>通过工号查询人员信息</p>
     * 
     * @param request QueryDoctorDetailsByJobNumberRequest
     * @param headers QueryDoctorDetailsByJobNumberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryDoctorDetailsByJobNumberResponse
     */
    public QueryDoctorDetailsByJobNumberResponse queryDoctorDetailsByJobNumberWithOptions(String jobNumber, QueryDoctorDetailsByJobNumberRequest request, QueryDoctorDetailsByJobNumberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
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
            new TeaPair("action", "QueryDoctorDetailsByJobNumber"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/doctors/" + jobNumber + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryDoctorDetailsByJobNumberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>通过工号查询人员信息</p>
     * 
     * @param request QueryDoctorDetailsByJobNumberRequest
     * @return QueryDoctorDetailsByJobNumberResponse
     */
    public QueryDoctorDetailsByJobNumberResponse queryDoctorDetailsByJobNumber(String jobNumber, QueryDoctorDetailsByJobNumberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryDoctorDetailsByJobNumberHeaders headers = new QueryDoctorDetailsByJobNumberHeaders();
        return this.queryDoctorDetailsByJobNumberWithOptions(jobNumber, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取医疗组详情</p>
     * 
     * @param headers QueryGroupInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryGroupInfoResponse
     */
    public QueryGroupInfoResponse queryGroupInfoWithOptions(String groupId, QueryGroupInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryGroupInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/groups/" + groupId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryGroupInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取医疗组详情</p>
     * @return QueryGroupInfoResponse
     */
    public QueryGroupInfoResponse queryGroupInfo(String groupId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
        return this.queryGroupInfoWithOptions(groupId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院的院区和病区信息</p>
     * 
     * @param request QueryHospitalDistrictInfoRequest
     * @param headers QueryHospitalDistrictInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryHospitalDistrictInfoResponse
     */
    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfoWithOptions(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryHospitalDistrictInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/districts"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryHospitalDistrictInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院的院区和病区信息</p>
     * 
     * @param request QueryHospitalDistrictInfoRequest
     * @return QueryHospitalDistrictInfoResponse
     */
    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfo(QueryHospitalDistrictInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
        return this.queryHospitalDistrictInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院所有角色的人员</p>
     * 
     * @param request QueryHospitalRoleUserInfoRequest
     * @param headers QueryHospitalRoleUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryHospitalRoleUserInfoResponse
     */
    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfoWithOptions(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryHospitalRoleUserInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/roles/userInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryHospitalRoleUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院所有角色的人员</p>
     * 
     * @param request QueryHospitalRoleUserInfoRequest
     * @return QueryHospitalRoleUserInfoResponse
     */
    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfo(QueryHospitalRoleUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
        return this.queryHospitalRoleUserInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院的角色</p>
     * 
     * @param headers QueryHospitalRolesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryHospitalRolesResponse
     */
    public QueryHospitalRolesResponse queryHospitalRolesWithOptions(QueryHospitalRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryHospitalRoles"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryHospitalRolesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询医院的角色</p>
     * @return QueryHospitalRolesResponse
     */
    public QueryHospitalRolesResponse queryHospitalRoles() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
        return this.queryHospitalRolesWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询职称字典表</p>
     * 
     * @param headers QueryJobCodeDictionaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryJobCodeDictionaryResponse
     */
    public QueryJobCodeDictionaryResponse queryJobCodeDictionaryWithOptions(QueryJobCodeDictionaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryJobCodeDictionary"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/jobCodes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryJobCodeDictionaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询职称字典表</p>
     * @return QueryJobCodeDictionaryResponse
     */
    public QueryJobCodeDictionaryResponse queryJobCodeDictionary() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
        return this.queryJobCodeDictionaryWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询工作状态字典表</p>
     * 
     * @param headers QueryJobStatusCodeDictionaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryJobStatusCodeDictionaryResponse
     */
    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionaryWithOptions(QueryJobStatusCodeDictionaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryJobStatusCodeDictionary"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/jobStatusCodes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryJobStatusCodeDictionaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询工作状态字典表</p>
     * @return QueryJobStatusCodeDictionaryResponse
     */
    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionary() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
        return this.queryJobStatusCodeDictionaryWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询医疗行业事件</p>
     * 
     * @param headers QueryMedicalEventsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryMedicalEventsResponse
     */
    public QueryMedicalEventsResponse queryMedicalEventsWithOptions(QueryMedicalEventsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryMedicalEvents"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/events"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryMedicalEventsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询医疗行业事件</p>
     * @return QueryMedicalEventsResponse
     */
    public QueryMedicalEventsResponse queryMedicalEvents() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
        return this.queryMedicalEventsWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户的证书</p>
     * 
     * @param request QueryUserCredentialsRequest
     * @param headers QueryUserCredentialsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserCredentialsResponse
     */
    public QueryUserCredentialsResponse queryUserCredentialsWithOptions(QueryUserCredentialsRequest request, QueryUserCredentialsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "QueryUserCredentials"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/users/credentials/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserCredentialsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户的证书</p>
     * 
     * @param request QueryUserCredentialsRequest
     * @return QueryUserCredentialsResponse
     */
    public QueryUserCredentialsResponse queryUserCredentials(QueryUserCredentialsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
        return this.queryUserCredentialsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员的扩展信息</p>
     * 
     * @param headers QueryUserExtInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserExtInfoResponse
     */
    public QueryUserExtInfoResponse queryUserExtInfoWithOptions(String userId, QueryUserExtInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserExtInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/users/" + userId + "/extInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserExtInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员的扩展信息</p>
     * @return QueryUserExtInfoResponse
     */
    public QueryUserExtInfoResponse queryUserExtInfo(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
        return this.queryUserExtInfoWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户拓展字段</p>
     * 
     * @param request QueryUserExtendValuesRequest
     * @param headers QueryUserExtendValuesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserExtendValuesResponse
     */
    public QueryUserExtendValuesResponse queryUserExtendValuesWithOptions(QueryUserExtendValuesRequest request, QueryUserExtendValuesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userExtendKey)) {
            body.put("userExtendKey", request.userExtendKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIds)) {
            body.put("userIds", request.userIds);
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
            new TeaPair("action", "QueryUserExtendValues"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/users/extends/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserExtendValuesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取用户拓展字段</p>
     * 
     * @param request QueryUserExtendValuesRequest
     * @return QueryUserExtendValuesResponse
     */
    public QueryUserExtendValuesResponse queryUserExtendValues(QueryUserExtendValuesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
        return this.queryUserExtendValuesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员详情</p>
     * 
     * @param request QueryUserInfoRequest
     * @param headers QueryUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserInfoResponse
     */
    public QueryUserInfoResponse queryUserInfoWithOptions(String userId, QueryUserInfoRequest request, QueryUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.monthMark)) {
            query.put("monthMark", request.monthMark);
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
            new TeaPair("action", "QueryUserInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/users/" + userId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员详情</p>
     * 
     * @param request QueryUserInfoRequest
     * @return QueryUserInfoResponse
     */
    public QueryUserInfoResponse queryUserInfo(String userId, QueryUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
        return this.queryUserInfoWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员属性字典表</p>
     * 
     * @param headers QueryUserProbCodeDictionaryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserProbCodeDictionaryResponse
     */
    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionaryWithOptions(QueryUserProbCodeDictionaryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserProbCodeDictionary"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/userProbCodes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserProbCodeDictionaryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员属性字典表</p>
     * @return QueryUserProbCodeDictionaryResponse
     */
    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionary() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
        return this.queryUserProbCodeDictionaryWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员权限</p>
     * 
     * @param headers QueryUserRolesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserRolesResponse
     */
    public QueryUserRolesResponse queryUserRolesWithOptions(String userId, QueryUserRolesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserRoles"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/users/" + userId + "/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserRolesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询人员权限</p>
     * @return QueryUserRolesResponse
     */
    public QueryUserRolesResponse queryUserRoles(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
        return this.queryUserRolesWithOptions(userId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>保存用户拓展字段</p>
     * 
     * @param request SaveUserExtendValuesRequest
     * @param headers SaveUserExtendValuesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SaveUserExtendValuesResponse
     */
    public SaveUserExtendValuesResponse saveUserExtendValuesWithOptions(String userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userDisplayName)) {
            query.put("userDisplayName", request.userDisplayName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userExtendKey)) {
            query.put("userExtendKey", request.userExtendKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userExtendValue)) {
            query.put("userExtendValue", request.userExtendValue);
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
            new TeaPair("action", "SaveUserExtendValues"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/users/" + userId + "/extends"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SaveUserExtendValuesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>保存用户拓展字段</p>
     * 
     * @param request SaveUserExtendValuesRequest
     * @return SaveUserExtendValuesResponse
     */
    public SaveUserExtendValuesResponse saveUserExtendValues(String userId, SaveUserExtendValuesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
        return this.saveUserExtendValuesWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>提交ai解析任务</p>
     * 
     * @param request SubmitTaskRequest
     * @param headers SubmitTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubmitTaskResponse
     */
    public SubmitTaskResponse submitTaskWithOptions(SubmitTaskRequest request, SubmitTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
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
            new TeaPair("action", "SubmitTask"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/ai/tasks/submit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubmitTaskResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>提交ai解析任务</p>
     * 
     * @param request SubmitTaskRequest
     * @return SubmitTaskResponse
     */
    public SubmitTaskResponse submitTask(SubmitTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubmitTaskHeaders headers = new SubmitTaskHeaders();
        return this.submitTaskWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>submitTaskPackage</p>
     * 
     * @param request SubmitTaskPackageRequest
     * @param headers SubmitTaskPackageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubmitTaskPackageResponse
     */
    public SubmitTaskPackageResponse submitTaskPackageWithOptions(SubmitTaskPackageRequest request, SubmitTaskPackageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appSecret)) {
            body.put("appSecret", request.appSecret);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizCode)) {
            body.put("bizCode", request.bizCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.data)) {
            body.put("data", request.data);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileType)) {
            body.put("fileType", request.fileType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.taskPackageName)) {
            body.put("taskPackageName", request.taskPackageName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            body.put("version", request.version);
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
            new TeaPair("action", "SubmitTaskPackage"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/ai/taskPackages/submit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubmitTaskPackageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>submitTaskPackage</p>
     * 
     * @param request SubmitTaskPackageRequest
     * @return SubmitTaskPackageResponse
     */
    public SubmitTaskPackageResponse submitTaskPackage(SubmitTaskPackageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubmitTaskPackageHeaders headers = new SubmitTaskPackageHeaders();
        return this.submitTaskPackageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>增加角色或角色组</p>
     * 
     * @param request SupplAddRoleRequest
     * @param headers SupplAddRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplAddRoleResponse
     */
    public SupplAddRoleResponse supplAddRoleWithOptions(SupplAddRoleRequest request, SupplAddRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.parentRoleGroupId)) {
            query.put("parentRoleGroupId", request.parentRoleGroupId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleName)) {
            query.put("roleName", request.roleName);
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
            new TeaPair("action", "SupplAddRole"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/roles"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplAddRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>增加角色或角色组</p>
     * 
     * @param request SupplAddRoleRequest
     * @return SupplAddRoleResponse
     */
    public SupplAddRoleResponse supplAddRole(SupplAddRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplAddRoleHeaders headers = new SupplAddRoleHeaders();
        return this.supplAddRoleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新增供应链节点</p>
     * 
     * @param request SupplyAddDeptRequest
     * @param headers SupplyAddDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyAddDeptResponse
     */
    public SupplyAddDeptResponse supplyAddDeptWithOptions(SupplyAddDeptRequest request, SupplyAddDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptName)) {
            query.put("deptName", request.deptName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partnerNumber)) {
            query.put("partnerNumber", request.partnerNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superDeptId)) {
            query.put("superDeptId", request.superDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplyDeptType)) {
            query.put("supplyDeptType", request.supplyDeptType);
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
            new TeaPair("action", "SupplyAddDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/departments"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyAddDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新增供应链节点</p>
     * 
     * @param request SupplyAddDeptRequest
     * @return SupplyAddDeptResponse
     */
    public SupplyAddDeptResponse supplyAddDept(SupplyAddDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyAddDeptHeaders headers = new SupplyAddDeptHeaders();
        return this.supplyAddDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加供应商人员</p>
     * 
     * @param request SupplyAddMemberRequest
     * @param headers SupplyAddMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyAddMemberResponse
     */
    public SupplyAddMemberResponse supplyAddMemberWithOptions(SupplyAddMemberRequest request, SupplyAddMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isPartnerManager)) {
            query.put("isPartnerManager", request.isPartnerManager);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberMobile)) {
            query.put("memberMobile", request.memberMobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberName)) {
            query.put("memberName", request.memberName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberTitle)) {
            query.put("memberTitle", request.memberTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberWorkNumber)) {
            query.put("memberWorkNumber", request.memberWorkNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplyDeptId)) {
            query.put("supplyDeptId", request.supplyDeptId);
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
            new TeaPair("action", "SupplyAddMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/members"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyAddMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加供应商人员</p>
     * 
     * @param request SupplyAddMemberRequest
     * @return SupplyAddMemberResponse
     */
    public SupplyAddMemberResponse supplyAddMember(SupplyAddMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyAddMemberHeaders headers = new SupplyAddMemberHeaders();
        return this.supplyAddMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加伙伴负责人</p>
     * 
     * @param request SupplyAddPartnerAdminsRequest
     * @param headers SupplyAddPartnerAdminsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyAddPartnerAdminsResponse
     */
    public SupplyAddPartnerAdminsResponse supplyAddPartnerAdminsWithOptions(SupplyAddPartnerAdminsRequest request, SupplyAddPartnerAdminsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "SupplyAddPartnerAdmins"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerAdministrators"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyAddPartnerAdminsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加伙伴负责人</p>
     * 
     * @param request SupplyAddPartnerAdminsRequest
     * @return SupplyAddPartnerAdminsResponse
     */
    public SupplyAddPartnerAdminsResponse supplyAddPartnerAdmins(SupplyAddPartnerAdminsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyAddPartnerAdminsHeaders headers = new SupplyAddPartnerAdminsHeaders();
        return this.supplyAddPartnerAdminsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加伙伴的对接人或对接部门</p>
     * 
     * @param request SupplyAddPartnerManagersRequest
     * @param headers SupplyAddPartnerManagersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyAddPartnerManagersResponse
     */
    public SupplyAddPartnerManagersResponse supplyAddPartnerManagersWithOptions(SupplyAddPartnerManagersRequest request, SupplyAddPartnerManagersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.interfaceId)) {
            query.put("interfaceId", request.interfaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.interfaceType)) {
            query.put("interfaceType", request.interfaceType);
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
            new TeaPair("action", "SupplyAddPartnerManagers"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerInterfaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyAddPartnerManagersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加伙伴的对接人或对接部门</p>
     * 
     * @param request SupplyAddPartnerManagersRequest
     * @return SupplyAddPartnerManagersResponse
     */
    public SupplyAddPartnerManagersResponse supplyAddPartnerManagers(SupplyAddPartnerManagersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyAddPartnerManagersHeaders headers = new SupplyAddPartnerManagersHeaders();
        return this.supplyAddPartnerManagersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加伙伴标签</p>
     * 
     * @param request SupplyAddPartnerTypeRequest
     * @param headers SupplyAddPartnerTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyAddPartnerTypeResponse
     */
    public SupplyAddPartnerTypeResponse supplyAddPartnerTypeWithOptions(SupplyAddPartnerTypeRequest request, SupplyAddPartnerTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            query.put("superId", request.superId);
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
            new TeaPair("action", "SupplyAddPartnerType"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerLabels"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyAddPartnerTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加伙伴标签</p>
     * 
     * @param request SupplyAddPartnerTypeRequest
     * @return SupplyAddPartnerTypeResponse
     */
    public SupplyAddPartnerTypeResponse supplyAddPartnerType(SupplyAddPartnerTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyAddPartnerTypeHeaders headers = new SupplyAddPartnerTypeHeaders();
        return this.supplyAddPartnerTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除上下游节点</p>
     * 
     * @param request SupplyChainDeleteDeptRequest
     * @param headers SupplyChainDeleteDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyChainDeleteDeptResponse
     */
    public SupplyChainDeleteDeptResponse supplyChainDeleteDeptWithOptions(SupplyChainDeleteDeptRequest request, SupplyChainDeleteDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.supplyDeptId)) {
            query.put("supplyDeptId", request.supplyDeptId);
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
            new TeaPair("action", "SupplyChainDeleteDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/departments"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyChainDeleteDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除上下游节点</p>
     * 
     * @param request SupplyChainDeleteDeptRequest
     * @return SupplyChainDeleteDeptResponse
     */
    public SupplyChainDeleteDeptResponse supplyChainDeleteDept(SupplyChainDeleteDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyChainDeleteDeptHeaders headers = new SupplyChainDeleteDeptHeaders();
        return this.supplyChainDeleteDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询上下游节点信息</p>
     * 
     * @param request SupplyChainQueryDeptInfoRequest
     * @param headers SupplyChainQueryDeptInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyChainQueryDeptInfoResponse
     */
    public SupplyChainQueryDeptInfoResponse supplyChainQueryDeptInfoWithOptions(SupplyChainQueryDeptInfoRequest request, SupplyChainQueryDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.supplyDeptId)) {
            query.put("supplyDeptId", request.supplyDeptId);
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
            new TeaPair("action", "SupplyChainQueryDeptInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/departments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyChainQueryDeptInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询上下游节点信息</p>
     * 
     * @param request SupplyChainQueryDeptInfoRequest
     * @return SupplyChainQueryDeptInfoResponse
     */
    public SupplyChainQueryDeptInfoResponse supplyChainQueryDeptInfo(SupplyChainQueryDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyChainQueryDeptInfoHeaders headers = new SupplyChainQueryDeptInfoHeaders();
        return this.supplyChainQueryDeptInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新上下游节点信息</p>
     * 
     * @param request SupplyChainUpdateDeptInfoRequest
     * @param headers SupplyChainUpdateDeptInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyChainUpdateDeptInfoResponse
     */
    public SupplyChainUpdateDeptInfoResponse supplyChainUpdateDeptInfoWithOptions(SupplyChainUpdateDeptInfoRequest request, SupplyChainUpdateDeptInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partnerNumber)) {
            body.put("partnerNumber", request.partnerNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partnerTypeList)) {
            body.put("partnerTypeList", request.partnerTypeList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            body.put("superId", request.superId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplyDeptId)) {
            body.put("supplyDeptId", request.supplyDeptId);
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
            new TeaPair("action", "SupplyChainUpdateDeptInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/departments"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyChainUpdateDeptInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新上下游节点信息</p>
     * 
     * @param request SupplyChainUpdateDeptInfoRequest
     * @return SupplyChainUpdateDeptInfoResponse
     */
    public SupplyChainUpdateDeptInfoResponse supplyChainUpdateDeptInfo(SupplyChainUpdateDeptInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyChainUpdateDeptInfoHeaders headers = new SupplyChainUpdateDeptInfoHeaders();
        return this.supplyChainUpdateDeptInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除伙伴成员</p>
     * 
     * @param request SupplyDeleteMemberRequest
     * @param headers SupplyDeleteMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyDeleteMemberResponse
     */
    public SupplyDeleteMemberResponse supplyDeleteMemberWithOptions(SupplyDeleteMemberRequest request, SupplyDeleteMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "SupplyDeleteMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/members"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyDeleteMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除伙伴成员</p>
     * 
     * @param request SupplyDeleteMemberRequest
     * @return SupplyDeleteMemberResponse
     */
    public SupplyDeleteMemberResponse supplyDeleteMember(SupplyDeleteMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyDeleteMemberHeaders headers = new SupplyDeleteMemberHeaders();
        return this.supplyDeleteMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除伙伴负责人</p>
     * 
     * @param request SupplyDeletePartnerAdminsRequest
     * @param headers SupplyDeletePartnerAdminsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyDeletePartnerAdminsResponse
     */
    public SupplyDeletePartnerAdminsResponse supplyDeletePartnerAdminsWithOptions(SupplyDeletePartnerAdminsRequest request, SupplyDeletePartnerAdminsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "SupplyDeletePartnerAdmins"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerAdministrators"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyDeletePartnerAdminsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除伙伴负责人</p>
     * 
     * @param request SupplyDeletePartnerAdminsRequest
     * @return SupplyDeletePartnerAdminsResponse
     */
    public SupplyDeletePartnerAdminsResponse supplyDeletePartnerAdmins(SupplyDeletePartnerAdminsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyDeletePartnerAdminsHeaders headers = new SupplyDeletePartnerAdminsHeaders();
        return this.supplyDeletePartnerAdminsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>移除伙伴的对接人或对接部门</p>
     * 
     * @param request SupplyDeletePartnerManagersRequest
     * @param headers SupplyDeletePartnerManagersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyDeletePartnerManagersResponse
     */
    public SupplyDeletePartnerManagersResponse supplyDeletePartnerManagersWithOptions(SupplyDeletePartnerManagersRequest request, SupplyDeletePartnerManagersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.interfaceId)) {
            query.put("interfaceId", request.interfaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.interfaceType)) {
            query.put("interfaceType", request.interfaceType);
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
            new TeaPair("action", "SupplyDeletePartnerManagers"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerInterfaces"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyDeletePartnerManagersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>移除伙伴的对接人或对接部门</p>
     * 
     * @param request SupplyDeletePartnerManagersRequest
     * @return SupplyDeletePartnerManagersResponse
     */
    public SupplyDeletePartnerManagersResponse supplyDeletePartnerManagers(SupplyDeletePartnerManagersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyDeletePartnerManagersHeaders headers = new SupplyDeletePartnerManagersHeaders();
        return this.supplyDeletePartnerManagersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除伙伴标签</p>
     * 
     * @param request SupplyDeletePartnerTypeRequest
     * @param headers SupplyDeletePartnerTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyDeletePartnerTypeResponse
     */
    public SupplyDeletePartnerTypeResponse supplyDeletePartnerTypeWithOptions(SupplyDeletePartnerTypeRequest request, SupplyDeletePartnerTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.labelId)) {
            query.put("labelId", request.labelId);
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
            new TeaPair("action", "SupplyDeletePartnerType"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerLabels"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyDeletePartnerTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除伙伴标签</p>
     * 
     * @param request SupplyDeletePartnerTypeRequest
     * @return SupplyDeletePartnerTypeResponse
     */
    public SupplyDeletePartnerTypeResponse supplyDeletePartnerType(SupplyDeletePartnerTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyDeletePartnerTypeHeaders headers = new SupplyDeletePartnerTypeHeaders();
        return this.supplyDeletePartnerTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除角色或角色组</p>
     * 
     * @param request SupplyDeleteRoleRequest
     * @param headers SupplyDeleteRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyDeleteRoleResponse
     */
    public SupplyDeleteRoleResponse supplyDeleteRoleWithOptions(SupplyDeleteRoleRequest request, SupplyDeleteRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isRoleGroup)) {
            query.put("isRoleGroup", request.isRoleGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            query.put("roleId", request.roleId);
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
            new TeaPair("action", "SupplyDeleteRole"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/roles"),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyDeleteRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除角色或角色组</p>
     * 
     * @param request SupplyDeleteRoleRequest
     * @return SupplyDeleteRoleResponse
     */
    public SupplyDeleteRoleResponse supplyDeleteRole(SupplyDeleteRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyDeleteRoleHeaders headers = new SupplyDeleteRoleHeaders();
        return this.supplyDeleteRoleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取供应链成员信息</p>
     * 
     * @param request SupplyGetMemberRequest
     * @param headers SupplyGetMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyGetMemberResponse
     */
    public SupplyGetMemberResponse supplyGetMemberWithOptions(SupplyGetMemberRequest request, SupplyGetMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            query.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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
            new TeaPair("action", "SupplyGetMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyGetMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取供应链成员信息</p>
     * 
     * @param request SupplyGetMemberRequest
     * @return SupplyGetMemberResponse
     */
    public SupplyGetMemberResponse supplyGetMember(SupplyGetMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyGetMemberHeaders headers = new SupplyGetMemberHeaders();
        return this.supplyGetMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取供应链部门下成员</p>
     * 
     * @param request SupplyListDeptMembersRequest
     * @param headers SupplyListDeptMembersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyListDeptMembersResponse
     */
    public SupplyListDeptMembersResponse supplyListDeptMembersWithOptions(SupplyListDeptMembersRequest request, SupplyListDeptMembersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.supplyDeptId)) {
            query.put("supplyDeptId", request.supplyDeptId);
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
            new TeaPair("action", "SupplyListDeptMembers"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/departments/members"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyListDeptMembersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取供应链部门下成员</p>
     * 
     * @param request SupplyListDeptMembersRequest
     * @return SupplyListDeptMembersResponse
     */
    public SupplyListDeptMembersResponse supplyListDeptMembers(SupplyListDeptMembersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyListDeptMembersHeaders headers = new SupplyListDeptMembersHeaders();
        return this.supplyListDeptMembersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取伙伴负责人列表</p>
     * 
     * @param request SupplyListPartnerAdminsRequest
     * @param headers SupplyListPartnerAdminsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyListPartnerAdminsResponse
     */
    public SupplyListPartnerAdminsResponse supplyListPartnerAdminsWithOptions(SupplyListPartnerAdminsRequest request, SupplyListPartnerAdminsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "SupplyListPartnerAdmins"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerAdministrators"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyListPartnerAdminsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取伙伴负责人列表</p>
     * 
     * @param request SupplyListPartnerAdminsRequest
     * @return SupplyListPartnerAdminsResponse
     */
    public SupplyListPartnerAdminsResponse supplyListPartnerAdmins(SupplyListPartnerAdminsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyListPartnerAdminsHeaders headers = new SupplyListPartnerAdminsHeaders();
        return this.supplyListPartnerAdminsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取伙伴的对接人/对接部门</p>
     * 
     * @param request SupplyListPartnerManagersRequest
     * @param headers SupplyListPartnerManagersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyListPartnerManagersResponse
     */
    public SupplyListPartnerManagersResponse supplyListPartnerManagersWithOptions(SupplyListPartnerManagersRequest request, SupplyListPartnerManagersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
            new TeaPair("action", "SupplyListPartnerManagers"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerInterfaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyListPartnerManagersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取伙伴的对接人/对接部门</p>
     * 
     * @param request SupplyListPartnerManagersRequest
     * @return SupplyListPartnerManagersResponse
     */
    public SupplyListPartnerManagersResponse supplyListPartnerManagers(SupplyListPartnerManagersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyListPartnerManagersHeaders headers = new SupplyListPartnerManagersHeaders();
        return this.supplyListPartnerManagersWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询下级伙伴标签</p>
     * 
     * @param request SupplyListPartnerTypeRequest
     * @param headers SupplyListPartnerTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyListPartnerTypeResponse
     */
    public SupplyListPartnerTypeResponse supplyListPartnerTypeWithOptions(SupplyListPartnerTypeRequest request, SupplyListPartnerTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.labelId)) {
            query.put("labelId", request.labelId);
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
            new TeaPair("action", "SupplyListPartnerType"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerLabels/subLabels"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyListPartnerTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询下级伙伴标签</p>
     * 
     * @param request SupplyListPartnerTypeRequest
     * @return SupplyListPartnerTypeResponse
     */
    public SupplyListPartnerTypeResponse supplyListPartnerType(SupplyListPartnerTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyListPartnerTypeHeaders headers = new SupplyListPartnerTypeHeaders();
        return this.supplyListPartnerTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询角色组或角色</p>
     * 
     * @param request SupplyListRoleRequest
     * @param headers SupplyListRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyListRoleResponse
     */
    public SupplyListRoleResponse supplyListRoleWithOptions(SupplyListRoleRequest request, SupplyListRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.parentRoleId)) {
            query.put("parentRoleId", request.parentRoleId);
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
            new TeaPair("action", "SupplyListRole"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/roles"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyListRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询角色组或角色</p>
     * 
     * @param request SupplyListRoleRequest
     * @return SupplyListRoleResponse
     */
    public SupplyListRoleResponse supplyListRole(SupplyListRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyListRoleHeaders headers = new SupplyListRoleHeaders();
        return this.supplyListRoleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询下级节点列表</p>
     * 
     * @param request SupplyListSubDeptRequest
     * @param headers SupplyListSubDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyListSubDeptResponse
     */
    public SupplyListSubDeptResponse supplyListSubDeptWithOptions(SupplyListSubDeptRequest request, SupplyListSubDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.supplyDeptId)) {
            query.put("supplyDeptId", request.supplyDeptId);
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
            new TeaPair("action", "SupplyListSubDept"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/subDepartments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyListSubDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询下级节点列表</p>
     * 
     * @param request SupplyListSubDeptRequest
     * @return SupplyListSubDeptResponse
     */
    public SupplyListSubDeptResponse supplyListSubDept(SupplyListSubDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyListSubDeptHeaders headers = new SupplyListSubDeptHeaders();
        return this.supplyListSubDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询伙伴标签</p>
     * 
     * @param request SupplyQueryPartnerTypeRequest
     * @param headers SupplyQueryPartnerTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyQueryPartnerTypeResponse
     */
    public SupplyQueryPartnerTypeResponse supplyQueryPartnerTypeWithOptions(SupplyQueryPartnerTypeRequest request, SupplyQueryPartnerTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.labelId)) {
            query.put("labelId", request.labelId);
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
            new TeaPair("action", "SupplyQueryPartnerType"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerLabels"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyQueryPartnerTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询伙伴标签</p>
     * 
     * @param request SupplyQueryPartnerTypeRequest
     * @return SupplyQueryPartnerTypeResponse
     */
    public SupplyQueryPartnerTypeResponse supplyQueryPartnerType(SupplyQueryPartnerTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyQueryPartnerTypeHeaders headers = new SupplyQueryPartnerTypeHeaders();
        return this.supplyQueryPartnerTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新供应商人员信息</p>
     * 
     * @param request SupplyUpdateMemberRequest
     * @param headers SupplyUpdateMemberHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyUpdateMemberResponse
     */
    public SupplyUpdateMemberResponse supplyUpdateMemberWithOptions(SupplyUpdateMemberRequest request, SupplyUpdateMemberHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isCopyDept)) {
            body.put("isCopyDept", request.isCopyDept);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberTitle)) {
            body.put("memberTitle", request.memberTitle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberWorkNumber)) {
            body.put("memberWorkNumber", request.memberWorkNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mobile)) {
            body.put("mobile", request.mobile);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newDeptId)) {
            body.put("newDeptId", request.newDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.oldDeptId)) {
            body.put("oldDeptId", request.oldDeptId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleIdList)) {
            body.put("roleIdList", request.roleIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "SupplyUpdateMember"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/members"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyUpdateMemberResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新供应商人员信息</p>
     * 
     * @param request SupplyUpdateMemberRequest
     * @return SupplyUpdateMemberResponse
     */
    public SupplyUpdateMemberResponse supplyUpdateMember(SupplyUpdateMemberRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyUpdateMemberHeaders headers = new SupplyUpdateMemberHeaders();
        return this.supplyUpdateMemberWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新伙伴标签</p>
     * 
     * @param request SupplyUpdatePartnerTypeRequest
     * @param headers SupplyUpdatePartnerTypeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyUpdatePartnerTypeResponse
     */
    public SupplyUpdatePartnerTypeResponse supplyUpdatePartnerTypeWithOptions(SupplyUpdatePartnerTypeRequest request, SupplyUpdatePartnerTypeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.labelId)) {
            query.put("labelId", request.labelId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            query.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.superId)) {
            query.put("superId", request.superId);
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
            new TeaPair("action", "SupplyUpdatePartnerType"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/partnerLabels"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyUpdatePartnerTypeResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新伙伴标签</p>
     * 
     * @param request SupplyUpdatePartnerTypeRequest
     * @return SupplyUpdatePartnerTypeResponse
     */
    public SupplyUpdatePartnerTypeResponse supplyUpdatePartnerType(SupplyUpdatePartnerTypeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyUpdatePartnerTypeHeaders headers = new SupplyUpdatePartnerTypeHeaders();
        return this.supplyUpdatePartnerTypeWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新角色或角色组</p>
     * 
     * @param request SupplyUpdateRoleRequest
     * @param headers SupplyUpdateRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SupplyUpdateRoleResponse
     */
    public SupplyUpdateRoleResponse supplyUpdateRoleWithOptions(SupplyUpdateRoleRequest request, SupplyUpdateRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isRoleGroup)) {
            query.put("isRoleGroup", request.isRoleGroup);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            query.put("roleId", request.roleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleName)) {
            query.put("roleName", request.roleName);
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
            new TeaPair("action", "SupplyUpdateRole"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/supplyChains/roles"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SupplyUpdateRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新角色或角色组</p>
     * 
     * @param request SupplyUpdateRoleRequest
     * @return SupplyUpdateRoleResponse
     */
    public SupplyUpdateRoleResponse supplyUpdateRole(SupplyUpdateRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SupplyUpdateRoleHeaders headers = new SupplyUpdateRoleHeaders();
        return this.supplyUpdateRoleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新医疗用户扩展信息</p>
     * 
     * @param request UpdateUserExtendInfoRequest
     * @param headers UpdateUserExtendInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateUserExtendInfoResponse
     */
    public UpdateUserExtendInfoResponse updateUserExtendInfoWithOptions(String userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.comments)) {
            body.put("comments", request.comments);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobCode)) {
            body.put("jobCode", request.jobCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobStatusCode)) {
            body.put("jobStatusCode", request.jobStatusCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userProbCode)) {
            body.put("userProbCode", request.userProbCode);
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
            new TeaPair("action", "UpdateUserExtendInfo"),
            new TeaPair("version", "industry_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/industry/medicals/users/" + userId + "/extInfos"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateUserExtendInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新医疗用户扩展信息</p>
     * 
     * @param request UpdateUserExtendInfoRequest
     * @return UpdateUserExtendInfoResponse
     */
    public UpdateUserExtendInfoResponse updateUserExtendInfo(String userId, UpdateUserExtendInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
        return this.updateUserExtendInfoWithOptions(userId, request, headers, runtime);
    }
}
