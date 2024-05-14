// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkorg_culture_1_0.models.*;

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
     * @summary 批量发放积分或额度
     *
     * @param request AssignOrgHoldingToEmpHoldingBatchRequest
     * @param headers AssignOrgHoldingToEmpHoldingBatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AssignOrgHoldingToEmpHoldingBatchResponse
     */
    public AssignOrgHoldingToEmpHoldingBatchResponse assignOrgHoldingToEmpHoldingBatchWithOptions(AssignOrgHoldingToEmpHoldingBatchRequest request, AssignOrgHoldingToEmpHoldingBatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendOrgCultureInform)) {
            body.put("sendOrgCultureInform", request.sendOrgCultureInform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.singleAmount)) {
            body.put("singleAmount", request.singleAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sourceUsage)) {
            body.put("sourceUsage", request.sourceUsage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetUsage)) {
            body.put("targetUsage", request.targetUsage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetUserList)) {
            body.put("targetUserList", request.targetUserList);
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
            new TeaPair("action", "AssignOrgHoldingToEmpHoldingBatch"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/organizations/points/assign"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AssignOrgHoldingToEmpHoldingBatchResponse());
    }

    /**
     * @summary 批量发放积分或额度
     *
     * @param request AssignOrgHoldingToEmpHoldingBatchRequest
     * @return AssignOrgHoldingToEmpHoldingBatchResponse
     */
    public AssignOrgHoldingToEmpHoldingBatchResponse assignOrgHoldingToEmpHoldingBatch(AssignOrgHoldingToEmpHoldingBatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AssignOrgHoldingToEmpHoldingBatchHeaders headers = new AssignOrgHoldingToEmpHoldingBatchHeaders();
        return this.assignOrgHoldingToEmpHoldingBatchWithOptions(request, headers, runtime);
    }

    /**
     * @summary 扣减员工积分
     *
     * @param request ConsumeUserPointsRequest
     * @param headers ConsumeUserPointsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ConsumeUserPointsResponse
     */
    public ConsumeUserPointsResponse consumeUserPointsWithOptions(String userId, ConsumeUserPointsRequest request, ConsumeUserPointsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.amount)) {
            body.put("amount", request.amount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outId)) {
            body.put("outId", request.outId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.usage)) {
            body.put("usage", request.usage);
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
            new TeaPair("action", "ConsumeUserPoints"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/" + userId + "/points/deduct"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ConsumeUserPointsResponse());
    }

    /**
     * @summary 扣减员工积分
     *
     * @param request ConsumeUserPointsRequest
     * @return ConsumeUserPointsResponse
     */
    public ConsumeUserPointsResponse consumeUserPoints(String userId, ConsumeUserPointsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ConsumeUserPointsHeaders headers = new ConsumeUserPointsHeaders();
        return this.consumeUserPointsWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 创建荣誉勋章模板
     *
     * @param request CreateOrgHonorRequest
     * @param headers CreateOrgHonorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CreateOrgHonorResponse
     */
    public CreateOrgHonorResponse createOrgHonorWithOptions(CreateOrgHonorRequest request, CreateOrgHonorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.avatarFrameMediaId)) {
            body.put("avatarFrameMediaId", request.avatarFrameMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.defaultBgColor)) {
            body.put("defaultBgColor", request.defaultBgColor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.medalDesc)) {
            body.put("medalDesc", request.medalDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.medalMediaId)) {
            body.put("medalMediaId", request.medalMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.medalName)) {
            body.put("medalName", request.medalName);
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
            new TeaPair("action", "CreateOrgHonor"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/honors/templates"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CreateOrgHonorResponse());
    }

    /**
     * @summary 创建荣誉勋章模板
     *
     * @param request CreateOrgHonorRequest
     * @return CreateOrgHonorResponse
     */
    public CreateOrgHonorResponse createOrgHonor(CreateOrgHonorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CreateOrgHonorHeaders headers = new CreateOrgHonorHeaders();
        return this.createOrgHonorWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量扣减积分
     *
     * @param request DeductionPointBatchRequest
     * @param headers DeductionPointBatchHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeductionPointBatchResponse
     */
    public DeductionPointBatchResponse deductionPointBatchWithOptions(DeductionPointBatchRequest request, DeductionPointBatchHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deductionAmount)) {
            body.put("deductionAmount", request.deductionAmount);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.remark)) {
            body.put("remark", request.remark);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sendOrgCultureInform)) {
            body.put("sendOrgCultureInform", request.sendOrgCultureInform);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetUserList)) {
            body.put("targetUserList", request.targetUserList);
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
            new TeaPair("action", "DeductionPointBatch"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/points/deduct"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeductionPointBatchResponse());
    }

    /**
     * @summary 批量扣减积分
     *
     * @param request DeductionPointBatchRequest
     * @return DeductionPointBatchResponse
     */
    public DeductionPointBatchResponse deductionPointBatch(DeductionPointBatchRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeductionPointBatchHeaders headers = new DeductionPointBatchHeaders();
        return this.deductionPointBatchWithOptions(request, headers, runtime);
    }

    /**
     * @summary 积分榜单导出
     *
     * @param request ExportPointOpenRequest
     * @param headers ExportPointOpenHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ExportPointOpenResponse
     */
    public ExportPointOpenResponse exportPointOpenWithOptions(ExportPointOpenRequest request, ExportPointOpenHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.exportDate)) {
            body.put("exportDate", request.exportDate);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.exportType)) {
            body.put("exportType", request.exportType);
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
            new TeaPair("action", "ExportPointOpen"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/points/export"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ExportPointOpenResponse());
    }

    /**
     * @summary 积分榜单导出
     *
     * @param request ExportPointOpenRequest
     * @return ExportPointOpenResponse
     */
    public ExportPointOpenResponse exportPointOpen(ExportPointOpenRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ExportPointOpenHeaders headers = new ExportPointOpenHeaders();
        return this.exportPointOpenWithOptions(request, headers, runtime);
    }

    /**
     * @summary 授予荣誉 异步执行
     *
     * @param request GrantHonorRequest
     * @param headers GrantHonorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GrantHonorResponse
     */
    public GrantHonorResponse grantHonorWithOptions(String honorId, GrantHonorRequest request, GrantHonorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.expirationTime)) {
            body.put("expirationTime", request.expirationTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.grantReason)) {
            body.put("grantReason", request.grantReason);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.granterName)) {
            body.put("granterName", request.granterName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noticeAnnouncer)) {
            body.put("noticeAnnouncer", request.noticeAnnouncer);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.noticeSingle)) {
            body.put("noticeSingle", request.noticeSingle);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.openConversationIds)) {
            body.put("openConversationIds", request.openConversationIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.receiverUserIds)) {
            body.put("receiverUserIds", request.receiverUserIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.senderUserId)) {
            body.put("senderUserId", request.senderUserId);
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
            new TeaPair("action", "GrantHonor"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/honors/" + honorId + "/grant"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GrantHonorResponse());
    }

    /**
     * @summary 授予荣誉 异步执行
     *
     * @param request GrantHonorRequest
     * @return GrantHonorResponse
     */
    public GrantHonorResponse grantHonor(String honorId, GrantHonorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GrantHonorHeaders headers = new GrantHonorHeaders();
        return this.grantHonorWithOptions(honorId, request, headers, runtime);
    }

    /**
     * @summary 查询当前企业下可兑换的积分
     *
     * @param request QueryCorpPointsRequest
     * @param headers QueryCorpPointsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCorpPointsResponse
     */
    public QueryCorpPointsResponse queryCorpPointsWithOptions(QueryCorpPointsRequest request, QueryCorpPointsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.optUserId)) {
            query.put("optUserId", request.optUserId);
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
            new TeaPair("action", "QueryCorpPoints"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/organizations/points"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCorpPointsResponse());
    }

    /**
     * @summary 查询当前企业下可兑换的积分
     *
     * @param request QueryCorpPointsRequest
     * @return QueryCorpPointsResponse
     */
    public QueryCorpPointsResponse queryCorpPoints(QueryCorpPointsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCorpPointsHeaders headers = new QueryCorpPointsHeaders();
        return this.queryCorpPointsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询个人积分使用明细
     *
     * @param request QueryEmpPointDetailsRequest
     * @param headers QueryEmpPointDetailsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryEmpPointDetailsResponse
     */
    public QueryEmpPointDetailsResponse queryEmpPointDetailsWithOptions(QueryEmpPointDetailsRequest request, QueryEmpPointDetailsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
            new TeaPair("action", "QueryEmpPointDetails"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/points/empDetails"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryEmpPointDetailsResponse());
    }

    /**
     * @summary 查询个人积分使用明细
     *
     * @param request QueryEmpPointDetailsRequest
     * @return QueryEmpPointDetailsResponse
     */
    public QueryEmpPointDetailsResponse queryEmpPointDetails(QueryEmpPointDetailsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryEmpPointDetailsHeaders headers = new QueryEmpPointDetailsHeaders();
        return this.queryEmpPointDetailsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取组织荣誉
     *
     * @param request QueryOrgHonorsRequest
     * @param headers QueryOrgHonorsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgHonorsResponse
     */
    public QueryOrgHonorsResponse queryOrgHonorsWithOptions(QueryOrgHonorsRequest request, QueryOrgHonorsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryOrgHonors"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/organizations/honors"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgHonorsResponse());
    }

    /**
     * @summary 获取组织荣誉
     *
     * @param request QueryOrgHonorsRequest
     * @return QueryOrgHonorsResponse
     */
    public QueryOrgHonorsResponse queryOrgHonors(QueryOrgHonorsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgHonorsHeaders headers = new QueryOrgHonorsHeaders();
        return this.queryOrgHonorsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询组织发放扣除积分明细
     *
     * @param request QueryOrgPointDetailsRequest
     * @param headers QueryOrgPointDetailsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryOrgPointDetailsResponse
     */
    public QueryOrgPointDetailsResponse queryOrgPointDetailsWithOptions(QueryOrgPointDetailsRequest request, QueryOrgPointDetailsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.accountType)) {
            query.put("accountType", request.accountType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            query.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
            new TeaPair("action", "QueryOrgPointDetails"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/points/orgDetails"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryOrgPointDetailsResponse());
    }

    /**
     * @summary 查询组织发放扣除积分明细
     *
     * @param request QueryOrgPointDetailsRequest
     * @return QueryOrgPointDetailsResponse
     */
    public QueryOrgPointDetailsResponse queryOrgPointDetails(QueryOrgPointDetailsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryOrgPointDetailsHeaders headers = new QueryOrgPointDetailsHeaders();
        return this.queryOrgPointDetailsWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询积分自动发放行为规则
     *
     * @param headers QueryPointActionAutoAssignRuleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPointActionAutoAssignRuleResponse
     */
    public QueryPointActionAutoAssignRuleResponse queryPointActionAutoAssignRuleWithOptions(QueryPointActionAutoAssignRuleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryPointActionAutoAssignRule"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/points/actionRules"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPointActionAutoAssignRuleResponse());
    }

    /**
     * @summary 查询积分自动发放行为规则
     *
     * @return QueryPointActionAutoAssignRuleResponse
     */
    public QueryPointActionAutoAssignRuleResponse queryPointActionAutoAssignRule() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPointActionAutoAssignRuleHeaders headers = new QueryPointActionAutoAssignRuleHeaders();
        return this.queryPointActionAutoAssignRuleWithOptions(headers, runtime);
    }

    /**
     * @summary 每月自动发放额度查询
     *
     * @param headers QueryPointAutoIssueSettingHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryPointAutoIssueSettingResponse
     */
    public QueryPointAutoIssueSettingResponse queryPointAutoIssueSettingWithOptions(QueryPointAutoIssueSettingHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryPointAutoIssueSetting"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/points"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryPointAutoIssueSettingResponse());
    }

    /**
     * @summary 每月自动发放额度查询
     *
     * @return QueryPointAutoIssueSettingResponse
     */
    public QueryPointAutoIssueSettingResponse queryPointAutoIssueSetting() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryPointAutoIssueSettingHeaders headers = new QueryPointAutoIssueSettingHeaders();
        return this.queryPointAutoIssueSettingWithOptions(headers, runtime);
    }

    /**
     * @summary 查询员工已获得的组织荣誉列表
     *
     * @param request QueryUserHonorsRequest
     * @param headers QueryUserHonorsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserHonorsResponse
     */
    public QueryUserHonorsResponse queryUserHonorsWithOptions(String userId, QueryUserHonorsRequest request, QueryUserHonorsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserHonors"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/honors/users/" + userId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserHonorsResponse());
    }

    /**
     * @summary 查询员工已获得的组织荣誉列表
     *
     * @param request QueryUserHonorsRequest
     * @return QueryUserHonorsResponse
     */
    public QueryUserHonorsResponse queryUserHonors(String userId, QueryUserHonorsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserHonorsHeaders headers = new QueryUserHonorsHeaders();
        return this.queryUserHonorsWithOptions(userId, request, headers, runtime);
    }

    /**
     * @summary 查询员工已获得的积分
     *
     * @param headers QueryUserPointsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryUserPointsResponse
     */
    public QueryUserPointsResponse queryUserPointsWithOptions(String userId, QueryUserPointsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "QueryUserPoints"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/" + userId + "/points"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryUserPointsResponse());
    }

    /**
     * @summary 查询员工已获得的积分
     *
     * @return QueryUserPointsResponse
     */
    public QueryUserPointsResponse queryUserPoints(String userId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryUserPointsHeaders headers = new QueryUserPointsHeaders();
        return this.queryUserPointsWithOptions(userId, headers, runtime);
    }

    /**
     * @summary 撤销员工获得的荣誉勋章
     *
     * @param request RecallHonorRequest
     * @param headers RecallHonorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RecallHonorResponse
     */
    public RecallHonorResponse recallHonorWithOptions(String honorId, RecallHonorRequest request, RecallHonorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
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
            new TeaPair("action", "RecallHonor"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/honors/" + honorId + "/recall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RecallHonorResponse());
    }

    /**
     * @summary 撤销员工获得的荣誉勋章
     *
     * @param request RecallHonorRequest
     * @return RecallHonorResponse
     */
    public RecallHonorResponse recallHonor(String honorId, RecallHonorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RecallHonorHeaders headers = new RecallHonorHeaders();
        return this.recallHonorWithOptions(honorId, request, headers, runtime);
    }

    /**
     * @summary 每月自动发放额度修改
     *
     * @param request UpdateAutoIssuePointRequest
     * @param headers UpdateAutoIssuePointHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateAutoIssuePointResponse
     */
    public UpdateAutoIssuePointResponse updateAutoIssuePointWithOptions(UpdateAutoIssuePointRequest request, UpdateAutoIssuePointHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pointAutoNum)) {
            body.put("pointAutoNum", request.pointAutoNum);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pointAutoState)) {
            body.put("pointAutoState", request.pointAutoState);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pointAutoTime)) {
            body.put("pointAutoTime", request.pointAutoTime);
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
            new TeaPair("action", "UpdateAutoIssuePoint"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/points/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateAutoIssuePointResponse());
    }

    /**
     * @summary 每月自动发放额度修改
     *
     * @param request UpdateAutoIssuePointRequest
     * @return UpdateAutoIssuePointResponse
     */
    public UpdateAutoIssuePointResponse updateAutoIssuePoint(UpdateAutoIssuePointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateAutoIssuePointHeaders headers = new UpdateAutoIssuePointHeaders();
        return this.updateAutoIssuePointWithOptions(request, headers, runtime);
    }

    /**
     * @summary 修改积分系统行为规则
     *
     * @param request UpdatePointActionAutoAssignRuleRequest
     * @param headers UpdatePointActionAutoAssignRuleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePointActionAutoAssignRuleResponse
     */
    public UpdatePointActionAutoAssignRuleResponse updatePointActionAutoAssignRuleWithOptions(UpdatePointActionAutoAssignRuleRequest request, UpdatePointActionAutoAssignRuleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.updatePointRuleRequestDTOList)) {
            body.put("updatePointRuleRequestDTOList", request.updatePointRuleRequestDTOList);
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
            new TeaPair("action", "UpdatePointActionAutoAssignRule"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/users/points/actionRules"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdatePointActionAutoAssignRuleResponse());
    }

    /**
     * @summary 修改积分系统行为规则
     *
     * @param request UpdatePointActionAutoAssignRuleRequest
     * @return UpdatePointActionAutoAssignRuleResponse
     */
    public UpdatePointActionAutoAssignRuleResponse updatePointActionAutoAssignRule(UpdatePointActionAutoAssignRuleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePointActionAutoAssignRuleHeaders headers = new UpdatePointActionAutoAssignRuleHeaders();
        return this.updatePointActionAutoAssignRuleWithOptions(request, headers, runtime);
    }

    /**
     * @summary 佩戴/卸下荣誉勋章
     *
     * @param request WearOrgHonorRequest
     * @param headers WearOrgHonorHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return WearOrgHonorResponse
     */
    public WearOrgHonorResponse wearOrgHonorWithOptions(String honorId, WearOrgHonorRequest request, WearOrgHonorHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.wear)) {
            body.put("wear", request.wear);
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
            new TeaPair("action", "WearOrgHonor"),
            new TeaPair("version", "orgCulture_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/orgCulture/honors/" + honorId + "/wear"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new WearOrgHonorResponse());
    }

    /**
     * @summary 佩戴/卸下荣誉勋章
     *
     * @param request WearOrgHonorRequest
     * @return WearOrgHonorResponse
     */
    public WearOrgHonorResponse wearOrgHonor(String honorId, WearOrgHonorRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        WearOrgHonorHeaders headers = new WearOrgHonorHeaders();
        return this.wearOrgHonorWithOptions(honorId, request, headers, runtime);
    }
}
