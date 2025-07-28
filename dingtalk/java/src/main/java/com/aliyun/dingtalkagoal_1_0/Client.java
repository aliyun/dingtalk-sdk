// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkagoal_1_0.models.*;

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
     * <p>创建目标进展</p>
     * 
     * @param request AgoalCreateProgressRequest
     * @param headers AgoalCreateProgressHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalCreateProgressResponse
     */
    public AgoalCreateProgressResponse agoalCreateProgressWithOptions(AgoalCreateProgressRequest request, AgoalCreateProgressHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.krId)) {
            body.put("krId", request.krId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mergeIntoLatestProgress)) {
            body.put("mergeIntoLatestProgress", request.mergeIntoLatestProgress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            body.put("objectiveId", request.objectiveId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.plainText)) {
            body.put("plainText", request.plainText);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.progress)) {
            body.put("progress", request.progress);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.progressMergePeriod)) {
            body.put("progressMergePeriod", request.progressMergePeriod);
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
            new TeaPair("action", "AgoalCreateProgress"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/objectives/progresses"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalCreateProgressResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建目标进展</p>
     * 
     * @param request AgoalCreateProgressRequest
     * @return AgoalCreateProgressResponse
     */
    public AgoalCreateProgressResponse agoalCreateProgress(AgoalCreateProgressRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalCreateProgressHeaders headers = new AgoalCreateProgressHeaders();
        return this.agoalCreateProgressWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建业务实体</p>
     * 
     * @param request AgoalEntityCreateRequest
     * @param headers AgoalEntityCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalEntityCreateResponse
     */
    public AgoalEntityCreateResponse agoalEntityCreateWithOptions(AgoalEntityCreateRequest request, AgoalEntityCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AgoalEntityCreate"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/entities"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalEntityCreateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建业务实体</p>
     * 
     * @param request AgoalEntityCreateRequest
     * @return AgoalEntityCreateResponse
     */
    public AgoalEntityCreateResponse agoalEntityCreate(AgoalEntityCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalEntityCreateHeaders headers = new AgoalEntityCreateHeaders();
        return this.agoalEntityCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新业务实体</p>
     * 
     * @param request AgoalEntityUpdateRequest
     * @param headers AgoalEntityUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalEntityUpdateResponse
     */
    public AgoalEntityUpdateResponse agoalEntityUpdateWithOptions(AgoalEntityUpdateRequest request, AgoalEntityUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AgoalEntityUpdate"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/entities"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalEntityUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新业务实体</p>
     * 
     * @param request AgoalEntityUpdateRequest
     * @return AgoalEntityUpdateResponse
     */
    public AgoalEntityUpdateResponse agoalEntityUpdate(AgoalEntityUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalEntityUpdateHeaders headers = new AgoalEntityUpdateHeaders();
        return this.agoalEntityUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新 Agoal 字段值</p>
     * 
     * @param tmpReq AgoalFieldUpdateRequest
     * @param headers AgoalFieldUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalFieldUpdateResponse
     */
    public AgoalFieldUpdateResponse agoalFieldUpdateWithOptions(AgoalFieldUpdateRequest tmpReq, AgoalFieldUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        AgoalFieldUpdateShrinkRequest request = new AgoalFieldUpdateShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "AgoalFieldUpdate"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/fields"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalFieldUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新 Agoal 字段值</p>
     * 
     * @param request AgoalFieldUpdateRequest
     * @return AgoalFieldUpdateResponse
     */
    public AgoalFieldUpdateResponse agoalFieldUpdate(AgoalFieldUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalFieldUpdateHeaders headers = new AgoalFieldUpdateHeaders();
        return this.agoalFieldUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal指定目标或者关键结果关联的关键行动</p>
     * 
     * @param request AgoalObjectiveKeyActionListRequest
     * @param headers AgoalObjectiveKeyActionListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalObjectiveKeyActionListResponse
     */
    public AgoalObjectiveKeyActionListResponse agoalObjectiveKeyActionListWithOptions(AgoalObjectiveKeyActionListRequest request, AgoalObjectiveKeyActionListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            query.put("dingUserId", request.dingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.keyResultId)) {
            query.put("keyResultId", request.keyResultId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            query.put("objectiveId", request.objectiveId);
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
            new TeaPair("action", "AgoalObjectiveKeyActionList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/objectives/keyActionLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalObjectiveKeyActionListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal指定目标或者关键结果关联的关键行动</p>
     * 
     * @param request AgoalObjectiveKeyActionListRequest
     * @return AgoalObjectiveKeyActionListResponse
     */
    public AgoalObjectiveKeyActionListResponse agoalObjectiveKeyActionList(AgoalObjectiveKeyActionListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalObjectiveKeyActionListHeaders headers = new AgoalObjectiveKeyActionListHeaders();
        return this.agoalObjectiveKeyActionListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal目标规则下的周期列表</p>
     * 
     * @param request AgoalObjectiveRulePeriodListRequest
     * @param headers AgoalObjectiveRulePeriodListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalObjectiveRulePeriodListResponse
     */
    public AgoalObjectiveRulePeriodListResponse agoalObjectiveRulePeriodListWithOptions(AgoalObjectiveRulePeriodListRequest request, AgoalObjectiveRulePeriodListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveRuleId)) {
            query.put("objectiveRuleId", request.objectiveRuleId);
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
            new TeaPair("action", "AgoalObjectiveRulePeriodList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/objectiveRules/periodLists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalObjectiveRulePeriodListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal目标规则下的周期列表</p>
     * 
     * @param request AgoalObjectiveRulePeriodListRequest
     * @return AgoalObjectiveRulePeriodListResponse
     */
    public AgoalObjectiveRulePeriodListResponse agoalObjectiveRulePeriodList(AgoalObjectiveRulePeriodListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalObjectiveRulePeriodListHeaders headers = new AgoalObjectiveRulePeriodListHeaders();
        return this.agoalObjectiveRulePeriodListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取 Agoal 组织目标列表</p>
     * 
     * @param request AgoalOrgObjectiveListRequest
     * @param headers AgoalOrgObjectiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalOrgObjectiveListResponse
     */
    public AgoalOrgObjectiveListResponse agoalOrgObjectiveListWithOptions(AgoalOrgObjectiveListRequest request, AgoalOrgObjectiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTeamId)) {
            query.put("dingTeamId", request.dingTeamId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodId)) {
            query.put("periodId", request.periodId);
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
            new TeaPair("action", "AgoalOrgObjectiveList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/orgObjectives/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalOrgObjectiveListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取 Agoal 组织目标列表</p>
     * 
     * @param request AgoalOrgObjectiveListRequest
     * @return AgoalOrgObjectiveListResponse
     */
    public AgoalOrgObjectiveListResponse agoalOrgObjectiveList(AgoalOrgObjectiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalOrgObjectiveListHeaders headers = new AgoalOrgObjectiveListHeaders();
        return this.agoalOrgObjectiveListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织目标详情</p>
     * 
     * @param request AgoalOrgObjectiveQueryRequest
     * @param headers AgoalOrgObjectiveQueryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalOrgObjectiveQueryResponse
     */
    public AgoalOrgObjectiveQueryResponse agoalOrgObjectiveQueryWithOptions(AgoalOrgObjectiveQueryRequest request, AgoalOrgObjectiveQueryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.objectiveId)) {
            query.put("objectiveId", request.objectiveId);
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
            new TeaPair("action", "AgoalOrgObjectiveQuery"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/orgObjectives"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalOrgObjectiveQueryResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询组织目标详情</p>
     * 
     * @param request AgoalOrgObjectiveQueryRequest
     * @return AgoalOrgObjectiveQueryResponse
     */
    public AgoalOrgObjectiveQueryResponse agoalOrgObjectiveQuery(AgoalOrgObjectiveQueryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalOrgObjectiveQueryHeaders headers = new AgoalOrgObjectiveQueryHeaders();
        return this.agoalOrgObjectiveQueryWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal目标规则列表</p>
     * 
     * @param headers AgoalOrgObjectiveRuleListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalOrgObjectiveRuleListResponse
     */
    public AgoalOrgObjectiveRuleListResponse agoalOrgObjectiveRuleListWithOptions(AgoalOrgObjectiveRuleListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "AgoalOrgObjectiveRuleList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/objectiveRules/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalOrgObjectiveRuleListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal目标规则列表</p>
     * @return AgoalOrgObjectiveRuleListResponse
     */
    public AgoalOrgObjectiveRuleListResponse agoalOrgObjectiveRuleList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalOrgObjectiveRuleListHeaders headers = new AgoalOrgObjectiveRuleListHeaders();
        return this.agoalOrgObjectiveRuleListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>创建考核任务</p>
     * 
     * @param request AgoalPerfTaskCreateRequest
     * @param headers AgoalPerfTaskCreateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalPerfTaskCreateResponse
     */
    public AgoalPerfTaskCreateResponse agoalPerfTaskCreateWithOptions(AgoalPerfTaskCreateRequest request, AgoalPerfTaskCreateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AgoalPerfTaskCreate"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/perfTasks"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalPerfTaskCreateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>创建考核任务</p>
     * 
     * @param request AgoalPerfTaskCreateRequest
     * @return AgoalPerfTaskCreateResponse
     */
    public AgoalPerfTaskCreateResponse agoalPerfTaskCreate(AgoalPerfTaskCreateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalPerfTaskCreateHeaders headers = new AgoalPerfTaskCreateHeaders();
        return this.agoalPerfTaskCreateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>更新考核任务</p>
     * 
     * @param request AgoalPerfTaskUpdateRequest
     * @param headers AgoalPerfTaskUpdateHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalPerfTaskUpdateResponse
     */
    public AgoalPerfTaskUpdateResponse agoalPerfTaskUpdateWithOptions(AgoalPerfTaskUpdateRequest request, AgoalPerfTaskUpdateHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.teautil.Common.toArray(request.body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AgoalPerfTaskUpdate"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/perfTasks"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalPerfTaskUpdateResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>更新考核任务</p>
     * 
     * @param request AgoalPerfTaskUpdateRequest
     * @return AgoalPerfTaskUpdateResponse
     */
    public AgoalPerfTaskUpdateResponse agoalPerfTaskUpdate(AgoalPerfTaskUpdateRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalPerfTaskUpdateHeaders headers = new AgoalPerfTaskUpdateHeaders();
        return this.agoalPerfTaskUpdateWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取 Agoal 周期列表</p>
     * 
     * @param tmpReq AgoalPeriodListRequest
     * @param headers AgoalPeriodListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalPeriodListResponse
     */
    public AgoalPeriodListResponse agoalPeriodListWithOptions(AgoalPeriodListRequest tmpReq, AgoalPeriodListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        AgoalPeriodListShrinkRequest request = new AgoalPeriodListShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.body)) {
            request.bodyShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.body, "body", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bodyShrink)) {
            query.put("body", request.bodyShrink);
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
            new TeaPair("action", "AgoalPeriodList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/periods/list"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalPeriodListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取 Agoal 周期列表</p>
     * 
     * @param request AgoalPeriodListRequest
     * @return AgoalPeriodListResponse
     */
    public AgoalPeriodListResponse agoalPeriodList(AgoalPeriodListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalPeriodListHeaders headers = new AgoalPeriodListHeaders();
        return this.agoalPeriodListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>Agoal消息发送</p>
     * 
     * @param request AgoalSendMessageRequest
     * @param headers AgoalSendMessageHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalSendMessageResponse
     */
    public AgoalSendMessageResponse agoalSendMessageWithOptions(AgoalSendMessageRequest request, AgoalSendMessageHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.mobileUrl)) {
            body.put("mobileUrl", request.mobileUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.params)) {
            body.put("params", request.params);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcUrl)) {
            body.put("pcUrl", request.pcUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceDingUserId)) {
            body.put("sourceDingUserId", request.sourceDingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetDingUserIds)) {
            body.put("targetDingUserIds", request.targetDingUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "AgoalSendMessage"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/messages/send"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalSendMessageResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>Agoal消息发送</p>
     * 
     * @param request AgoalSendMessageRequest
     * @return AgoalSendMessageResponse
     */
    public AgoalSendMessageResponse agoalSendMessage(AgoalSendMessageRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalSendMessageHeaders headers = new AgoalSendMessageHeaders();
        return this.agoalSendMessageWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal管理员列表</p>
     * 
     * @param headers AgoalUserAdminListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalUserAdminListResponse
     */
    public AgoalUserAdminListResponse agoalUserAdminListWithOptions(AgoalUserAdminListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "AgoalUserAdminList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/administrators/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalUserAdminListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal管理员列表</p>
     * @return AgoalUserAdminListResponse
     */
    public AgoalUserAdminListResponse agoalUserAdminList() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalUserAdminListHeaders headers = new AgoalUserAdminListHeaders();
        return this.agoalUserAdminListWithOptions(headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>Agoal用户目标列表</p>
     * 
     * @param request AgoalUserObjectiveListRequest
     * @param headers AgoalUserObjectiveListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalUserObjectiveListResponse
     */
    public AgoalUserObjectiveListResponse agoalUserObjectiveListWithOptions(AgoalUserObjectiveListRequest request, AgoalUserObjectiveListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingUserId)) {
            body.put("dingUserId", request.dingUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectiveRuleId)) {
            body.put("objectiveRuleId", request.objectiveRuleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.periodIds)) {
            body.put("periodIds", request.periodIds);
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
            new TeaPair("action", "AgoalUserObjectiveList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/users/objectiveLists/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalUserObjectiveListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>Agoal用户目标列表</p>
     * 
     * @param request AgoalUserObjectiveListRequest
     * @return AgoalUserObjectiveListResponse
     */
    public AgoalUserObjectiveListResponse agoalUserObjectiveList(AgoalUserObjectiveListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalUserObjectiveListHeaders headers = new AgoalUserObjectiveListHeaders();
        return this.agoalUserObjectiveListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal子管理员列表</p>
     * 
     * @param request AgoalUserSubAdminListRequest
     * @param headers AgoalUserSubAdminListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AgoalUserSubAdminListResponse
     */
    public AgoalUserSubAdminListResponse agoalUserSubAdminListWithOptions(AgoalUserSubAdminListRequest request, AgoalUserSubAdminListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.funcPermissionGroup)) {
            query.put("funcPermissionGroup", request.funcPermissionGroup);
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
            new TeaPair("action", "AgoalUserSubAdminList"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/administrators/sub/lists"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AgoalUserSubAdminListResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取Agoal子管理员列表</p>
     * 
     * @param request AgoalUserSubAdminListRequest
     * @return AgoalUserSubAdminListResponse
     */
    public AgoalUserSubAdminListResponse agoalUserSubAdminList(AgoalUserSubAdminListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AgoalUserSubAdminListHeaders headers = new AgoalUserSubAdminListHeaders();
        return this.agoalUserSubAdminListWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门下的维度和指标id</p>
     * 
     * @param request GetDeptScoreCardIndicatorRequest
     * @param headers GetDeptScoreCardIndicatorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDeptScoreCardIndicatorResponse
     */
    public GetDeptScoreCardIndicatorResponse getDeptScoreCardIndicatorWithOptions(GetDeptScoreCardIndicatorRequest request, GetDeptScoreCardIndicatorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTeamId)) {
            query.put("dingTeamId", request.dingTeamId);
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
            new TeaPair("action", "GetDeptScoreCardIndicator"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/scorecards/departments/indicators"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDeptScoreCardIndicatorResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门下的维度和指标id</p>
     * 
     * @param request GetDeptScoreCardIndicatorRequest
     * @return GetDeptScoreCardIndicatorResponse
     */
    public GetDeptScoreCardIndicatorResponse getDeptScoreCardIndicator(GetDeptScoreCardIndicatorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDeptScoreCardIndicatorHeaders headers = new GetDeptScoreCardIndicatorHeaders();
        return this.getDeptScoreCardIndicatorWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取指标详情</p>
     * 
     * @param request GetIndicatorDetailRequest
     * @param headers GetIndicatorDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetIndicatorDetailResponse
     */
    public GetIndicatorDetailResponse getIndicatorDetailWithOptions(GetIndicatorDetailRequest request, GetIndicatorDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.indicatorId)) {
            query.put("indicatorId", request.indicatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.monthNum)) {
            query.put("monthNum", request.monthNum);
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
            new TeaPair("action", "GetIndicatorDetail"),
            new TeaPair("version", "agoal_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/agoal/scorecards/indicators/details"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetIndicatorDetailResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取指标详情</p>
     * 
     * @param request GetIndicatorDetailRequest
     * @return GetIndicatorDetailResponse
     */
    public GetIndicatorDetailResponse getIndicatorDetail(GetIndicatorDetailRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetIndicatorDetailHeaders headers = new GetIndicatorDetailHeaders();
        return this.getIndicatorDetailWithOptions(request, headers, runtime);
    }
}
