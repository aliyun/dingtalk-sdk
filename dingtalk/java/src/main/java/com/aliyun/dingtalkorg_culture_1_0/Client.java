// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkorg_culture_1_0.models.*;
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


    public AssignOrgHoldingToEmpHoldingBatchResponse assignOrgHoldingToEmpHoldingBatch(AssignOrgHoldingToEmpHoldingBatchRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AssignOrgHoldingToEmpHoldingBatchHeaders headers = new AssignOrgHoldingToEmpHoldingBatchHeaders();
        return this.assignOrgHoldingToEmpHoldingBatchWithOptions(request, headers, runtime);
    }

    public AssignOrgHoldingToEmpHoldingBatchResponse assignOrgHoldingToEmpHoldingBatchWithOptions(AssignOrgHoldingToEmpHoldingBatchRequest request, AssignOrgHoldingToEmpHoldingBatchHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AssignOrgHoldingToEmpHoldingBatch", "orgCulture_1.0", "HTTP", "POST", "AK", "/v1.0/orgCulture/organizations/points/assign", "json", req, runtime), new AssignOrgHoldingToEmpHoldingBatchResponse());
    }

    public ConsumeUserPointsResponse consumeUserPoints(String userId, ConsumeUserPointsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ConsumeUserPointsHeaders headers = new ConsumeUserPointsHeaders();
        return this.consumeUserPointsWithOptions(userId, request, headers, runtime);
    }

    public ConsumeUserPointsResponse consumeUserPointsWithOptions(String userId, ConsumeUserPointsRequest request, ConsumeUserPointsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ConsumeUserPoints", "orgCulture_1.0", "HTTP", "POST", "AK", "/v1.0/orgCulture/users/" + userId + "/points/deduct", "json", req, runtime), new ConsumeUserPointsResponse());
    }

    public DeductionPointBatchResponse deductionPointBatch(DeductionPointBatchRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeductionPointBatchHeaders headers = new DeductionPointBatchHeaders();
        return this.deductionPointBatchWithOptions(request, headers, runtime);
    }

    public DeductionPointBatchResponse deductionPointBatchWithOptions(DeductionPointBatchRequest request, DeductionPointBatchHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeductionPointBatch", "orgCulture_1.0", "HTTP", "POST", "AK", "/v1.0/orgCulture/users/points/deduct", "json", req, runtime), new DeductionPointBatchResponse());
    }

    public ExportPointOpenResponse exportPointOpen(ExportPointOpenRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ExportPointOpenHeaders headers = new ExportPointOpenHeaders();
        return this.exportPointOpenWithOptions(request, headers, runtime);
    }

    public ExportPointOpenResponse exportPointOpenWithOptions(ExportPointOpenRequest request, ExportPointOpenHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ExportPointOpen", "orgCulture_1.0", "HTTP", "POST", "AK", "/v1.0/orgCulture/users/points/export", "json", req, runtime), new ExportPointOpenResponse());
    }

    public GrantHonorResponse grantHonor(String honorId, GrantHonorRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GrantHonorHeaders headers = new GrantHonorHeaders();
        return this.grantHonorWithOptions(honorId, request, headers, runtime);
    }

    public GrantHonorResponse grantHonorWithOptions(String honorId, GrantHonorRequest request, GrantHonorHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        honorId = com.aliyun.openapiutil.Client.getEncodeParam(honorId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GrantHonor", "orgCulture_1.0", "HTTP", "POST", "AK", "/v1.0/orgCulture/honors/" + honorId + "/grant", "json", req, runtime), new GrantHonorResponse());
    }

    public QueryCorpPointsResponse queryCorpPoints(QueryCorpPointsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryCorpPointsHeaders headers = new QueryCorpPointsHeaders();
        return this.queryCorpPointsWithOptions(request, headers, runtime);
    }

    public QueryCorpPointsResponse queryCorpPointsWithOptions(QueryCorpPointsRequest request, QueryCorpPointsHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryCorpPoints", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/organizations/points", "json", req, runtime), new QueryCorpPointsResponse());
    }

    public QueryEmpPointDetailsResponse queryEmpPointDetails(QueryEmpPointDetailsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryEmpPointDetailsHeaders headers = new QueryEmpPointDetailsHeaders();
        return this.queryEmpPointDetailsWithOptions(request, headers, runtime);
    }

    public QueryEmpPointDetailsResponse queryEmpPointDetailsWithOptions(QueryEmpPointDetailsRequest request, QueryEmpPointDetailsHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryEmpPointDetails", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/points/empDetails", "json", req, runtime), new QueryEmpPointDetailsResponse());
    }

    public QueryOrgHonorsResponse queryOrgHonors(QueryOrgHonorsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOrgHonorsHeaders headers = new QueryOrgHonorsHeaders();
        return this.queryOrgHonorsWithOptions(request, headers, runtime);
    }

    public QueryOrgHonorsResponse queryOrgHonorsWithOptions(QueryOrgHonorsRequest request, QueryOrgHonorsHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryOrgHonors", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/organizations/honors", "json", req, runtime), new QueryOrgHonorsResponse());
    }

    public QueryOrgPointDetailsResponse queryOrgPointDetails(QueryOrgPointDetailsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryOrgPointDetailsHeaders headers = new QueryOrgPointDetailsHeaders();
        return this.queryOrgPointDetailsWithOptions(request, headers, runtime);
    }

    public QueryOrgPointDetailsResponse queryOrgPointDetailsWithOptions(QueryOrgPointDetailsRequest request, QueryOrgPointDetailsHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryOrgPointDetails", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/points/orgDetails", "json", req, runtime), new QueryOrgPointDetailsResponse());
    }

    public QueryPointActionAutoAssignRuleResponse queryPointActionAutoAssignRule() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryPointActionAutoAssignRuleHeaders headers = new QueryPointActionAutoAssignRuleHeaders();
        return this.queryPointActionAutoAssignRuleWithOptions(headers, runtime);
    }

    public QueryPointActionAutoAssignRuleResponse queryPointActionAutoAssignRuleWithOptions(QueryPointActionAutoAssignRuleHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryPointActionAutoAssignRule", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/users/points/actionRules", "json", req, runtime), new QueryPointActionAutoAssignRuleResponse());
    }

    public QueryPointAutoIssueSettingResponse queryPointAutoIssueSetting() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryPointAutoIssueSettingHeaders headers = new QueryPointAutoIssueSettingHeaders();
        return this.queryPointAutoIssueSettingWithOptions(headers, runtime);
    }

    public QueryPointAutoIssueSettingResponse queryPointAutoIssueSettingWithOptions(QueryPointAutoIssueSettingHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryPointAutoIssueSetting", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/users/points", "json", req, runtime), new QueryPointAutoIssueSettingResponse());
    }

    public QueryUserHonorsResponse queryUserHonors(String userId, QueryUserHonorsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserHonorsHeaders headers = new QueryUserHonorsHeaders();
        return this.queryUserHonorsWithOptions(userId, request, headers, runtime);
    }

    public QueryUserHonorsResponse queryUserHonorsWithOptions(String userId, QueryUserHonorsRequest request, QueryUserHonorsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("QueryUserHonors", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/honors/users/" + userId + "", "json", req, runtime), new QueryUserHonorsResponse());
    }

    public QueryUserPointsResponse queryUserPoints(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserPointsHeaders headers = new QueryUserPointsHeaders();
        return this.queryUserPointsWithOptions(userId, headers, runtime);
    }

    public QueryUserPointsResponse queryUserPointsWithOptions(String userId, QueryUserPointsHeaders headers, RuntimeOptions runtime) throws Exception {
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryUserPoints", "orgCulture_1.0", "HTTP", "GET", "AK", "/v1.0/orgCulture/users/" + userId + "/points", "json", req, runtime), new QueryUserPointsResponse());
    }

    public UpdateAutoIssuePointResponse updateAutoIssuePoint(UpdateAutoIssuePointRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateAutoIssuePointHeaders headers = new UpdateAutoIssuePointHeaders();
        return this.updateAutoIssuePointWithOptions(request, headers, runtime);
    }

    public UpdateAutoIssuePointResponse updateAutoIssuePointWithOptions(UpdateAutoIssuePointRequest request, UpdateAutoIssuePointHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateAutoIssuePoint", "orgCulture_1.0", "HTTP", "POST", "AK", "/v1.0/orgCulture/users/points/set", "json", req, runtime), new UpdateAutoIssuePointResponse());
    }

    public UpdatePointActionAutoAssignRuleResponse updatePointActionAutoAssignRule(UpdatePointActionAutoAssignRuleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdatePointActionAutoAssignRuleHeaders headers = new UpdatePointActionAutoAssignRuleHeaders();
        return this.updatePointActionAutoAssignRuleWithOptions(request, headers, runtime);
    }

    public UpdatePointActionAutoAssignRuleResponse updatePointActionAutoAssignRuleWithOptions(UpdatePointActionAutoAssignRuleRequest request, UpdatePointActionAutoAssignRuleHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdatePointActionAutoAssignRule", "orgCulture_1.0", "HTTP", "PUT", "AK", "/v1.0/orgCulture/users/points/actionRules", "json", req, runtime), new UpdatePointActionAutoAssignRuleResponse());
    }
}
