// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkindustry_1_0.models.*;
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


    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfo(QueryHospitalDistrictInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
        return this.queryHospitalDistrictInfoWithOptions(request, headers, runtime);
    }

    public QueryHospitalDistrictInfoResponse queryHospitalDistrictInfoWithOptions(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("QueryHospitalDistrictInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/districts", "json", req, runtime), new QueryHospitalDistrictInfoResponse());
    }

    public QueryUserInfoResponse queryUserInfo(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
        return this.queryUserInfoWithOptions(userId, headers, runtime);
    }

    public QueryUserInfoResponse queryUserInfoWithOptions(String userId, QueryUserInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "", "json", req, runtime), new QueryUserInfoResponse());
    }

    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGet(IndustryManufactureCostRecordListGetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
        return this.industryManufactureCostRecordListGetWithOptions(request, headers, runtime);
    }

    public IndustryManufactureCostRecordListGetResponse industryManufactureCostRecordListGetWithOptions(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderNo)) {
            body.put("orderNo", request.orderNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.productionTaskNo)) {
            body.put("productionTaskNo", request.productionTaskNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureCostRecordListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materialCostRecords/query", "json", req, runtime), new IndustryManufactureCostRecordListGetResponse());
    }

    public QueryAllMemberByDeptResponse queryAllMemberByDept(String deptId, QueryAllMemberByDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
        return this.queryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
    }

    public QueryAllMemberByDeptResponse queryAllMemberByDeptWithOptions(String deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("QueryAllMemberByDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/members", "json", req, runtime), new QueryAllMemberByDeptResponse());
    }

    public QueryAllMemberByGroupResponse queryAllMemberByGroup(String groupId, QueryAllMemberByGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
        return this.queryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
    }

    public QueryAllMemberByGroupResponse queryAllMemberByGroupWithOptions(String groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("QueryAllMemberByGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "/members", "json", req, runtime), new QueryAllMemberByGroupResponse());
    }

    public QueryUserRolesResponse queryUserRoles(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
        return this.queryUserRolesWithOptions(userId, headers, runtime);
    }

    public QueryUserRolesResponse queryUserRolesWithOptions(String userId, QueryUserRolesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/roles", "json", req, runtime), new QueryUserRolesResponse());
    }

    public QueryHospitalRolesResponse queryHospitalRoles() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
        return this.queryHospitalRolesWithOptions(headers, runtime);
    }

    public QueryHospitalRolesResponse queryHospitalRolesWithOptions(QueryHospitalRolesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryHospitalRoles", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles", "json", req, runtime), new QueryHospitalRolesResponse());
    }

    public QueryAllGroupResponse queryAllGroup(QueryAllGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
        return this.queryAllGroupWithOptions(request, headers, runtime);
    }

    public QueryAllGroupResponse queryAllGroupWithOptions(QueryAllGroupRequest request, QueryAllGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("QueryAllGroup", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups", "json", req, runtime), new QueryAllGroupResponse());
    }

    public QueryAllGroupsInDeptResponse queryAllGroupsInDept(String deptId, QueryAllGroupsInDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
        return this.queryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
    }

    public QueryAllGroupsInDeptResponse queryAllGroupsInDeptWithOptions(String deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("QueryAllGroupsInDept", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "/groups", "json", req, runtime), new QueryAllGroupsInDeptResponse());
    }

    public QueryBizOptLogResponse queryBizOptLog(QueryBizOptLogRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
        return this.queryBizOptLogWithOptions(request, headers, runtime);
    }

    public QueryBizOptLogResponse queryBizOptLogWithOptions(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
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
        return TeaModel.toModel(this.doROARequest("QueryBizOptLog", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/bizOptLogs", "json", req, runtime), new QueryBizOptLogResponse());
    }

    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfo(QueryHospitalRoleUserInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
        return this.queryHospitalRoleUserInfoWithOptions(request, headers, runtime);
    }

    public QueryHospitalRoleUserInfoResponse queryHospitalRoleUserInfoWithOptions(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("QueryHospitalRoleUserInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/roles/userInfos", "json", req, runtime), new QueryHospitalRoleUserInfoResponse());
    }

    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionary() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
        return this.queryUserProbCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryUserProbCodeDictionaryResponse queryUserProbCodeDictionaryWithOptions(QueryUserProbCodeDictionaryHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserProbCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/userProbCodes", "json", req, runtime), new QueryUserProbCodeDictionaryResponse());
    }

    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionary() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
        return this.queryJobStatusCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryJobStatusCodeDictionaryResponse queryJobStatusCodeDictionaryWithOptions(QueryJobStatusCodeDictionaryHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryJobStatusCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobStatusCodes", "json", req, runtime), new QueryJobStatusCodeDictionaryResponse());
    }

    public QueryDepartmentInfoResponse queryDepartmentInfo(String deptId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
        return this.queryDepartmentInfoWithOptions(deptId, headers, runtime);
    }

    public QueryDepartmentInfoResponse queryDepartmentInfoWithOptions(String deptId, QueryDepartmentInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryDepartmentInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments/" + deptId + "", "json", req, runtime), new QueryDepartmentInfoResponse());
    }

    public IndustryManufactureMaterialListResponse industryManufactureMaterialList(IndustryManufactureMaterialListRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
        return this.industryManufactureMaterialListWithOptions(request, headers, runtime);
    }

    public IndustryManufactureMaterialListResponse industryManufactureMaterialListWithOptions(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.currentPage)) {
            body.put("currentPage", request.currentPage);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureMaterialList", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/materials/query", "json", req, runtime), new IndustryManufactureMaterialListResponse());
    }

    public UpdateUserExtendInfoResponse updateUserExtendInfo(String userId, UpdateUserExtendInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
        return this.updateUserExtendInfoWithOptions(userId, request, headers, runtime);
    }

    public UpdateUserExtendInfoResponse updateUserExtendInfoWithOptions(String userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobCode)) {
            body.put("jobCode", request.jobCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userProbCode)) {
            body.put("userProbCode", request.userProbCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.jobStatusCode)) {
            body.put("jobStatusCode", request.jobStatusCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.comments)) {
            body.put("comments", request.comments);
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
        return TeaModel.toModel(this.doROARequest("UpdateUserExtendInfo", "industry_1.0", "HTTP", "PUT", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "none", req, runtime), new UpdateUserExtendInfoResponse());
    }

    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGet(IndustryMmanufactureMaterialCostGetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
        return this.industryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
    }

    public IndustryMmanufactureMaterialCostGetResponse industryMmanufactureMaterialCostGetWithOptions(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.instanceId)) {
            body.put("instanceId", request.instanceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
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
        return TeaModel.toModel(this.doROARequest("IndustryMmanufactureMaterialCostGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/base/materialCosts/query", "json", req, runtime), new IndustryMmanufactureMaterialCostGetResponse());
    }

    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGet(IndustryManufactureFeeListGetRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
        return this.industryManufactureFeeListGetWithOptions(request, headers, runtime);
    }

    public IndustryManufactureFeeListGetResponse industryManufactureFeeListGetWithOptions(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.productionTaskNo)) {
            body.put("productionTaskNo", request.productionTaskNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureFeeListGet", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/fees/query", "json", req, runtime), new IndustryManufactureFeeListGetResponse());
    }

    public QueryAllDoctorsResponse queryAllDoctors(QueryAllDoctorsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
        return this.queryAllDoctorsWithOptions(request, headers, runtime);
    }

    public QueryAllDoctorsResponse queryAllDoctorsWithOptions(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNum)) {
            query.put("pageNum", request.pageNum);
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
        return TeaModel.toModel(this.doROARequest("QueryAllDoctors", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/doctors", "json", req, runtime), new QueryAllDoctorsResponse());
    }

    public QueryUserExtInfoResponse queryUserExtInfo(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
        return this.queryUserExtInfoWithOptions(userId, headers, runtime);
    }

    public QueryUserExtInfoResponse queryUserExtInfoWithOptions(String userId, QueryUserExtInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserExtInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/users/" + userId + "/extInfos", "json", req, runtime), new QueryUserExtInfoResponse());
    }

    public QueryJobCodeDictionaryResponse queryJobCodeDictionary() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
        return this.queryJobCodeDictionaryWithOptions(headers, runtime);
    }

    public QueryJobCodeDictionaryResponse queryJobCodeDictionaryWithOptions(QueryJobCodeDictionaryHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryJobCodeDictionary", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/jobCodes", "json", req, runtime), new QueryJobCodeDictionaryResponse());
    }

    public QueryAllDepartmentResponse queryAllDepartment(QueryAllDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
        return this.queryAllDepartmentWithOptions(request, headers, runtime);
    }

    public QueryAllDepartmentResponse queryAllDepartmentWithOptions(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            query.put("pageSize", request.pageSize);
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
        return TeaModel.toModel(this.doROARequest("QueryAllDepartment", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/departments", "json", req, runtime), new QueryAllDepartmentResponse());
    }

    public IndustryManufactureLabourCostResponse industryManufactureLabourCost(IndustryManufactureLabourCostRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
        return this.industryManufactureLabourCostWithOptions(request, headers, runtime);
    }

    public IndustryManufactureLabourCostResponse industryManufactureLabourCostWithOptions(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processNo)) {
            body.put("processNo", request.processNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.materialNo)) {
            body.put("materialNo", request.materialNo);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            body.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.tokenGrantType)) {
            body.put("tokenGrantType", request.tokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orgId)) {
            body.put("orgId", request.orgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isvOrgId)) {
            body.put("isvOrgId", request.isvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.suiteKey)) {
            body.put("suiteKey", request.suiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.microappAgentId)) {
            body.put("microappAgentId", request.microappAgentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIds)) {
            body.put("appIds", request.appIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appId)) {
            body.put("appId", request.appId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
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
        return TeaModel.toModel(this.doROARequest("IndustryManufactureLabourCost", "industry_1.0", "HTTP", "POST", "AK", "/v1.0/industry/manufactures/labourCosts/query", "json", req, runtime), new IndustryManufactureLabourCostResponse());
    }

    public QueryGroupInfoResponse queryGroupInfo(String groupId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
        return this.queryGroupInfoWithOptions(groupId, headers, runtime);
    }

    public QueryGroupInfoResponse queryGroupInfoWithOptions(String groupId, QueryGroupInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryGroupInfo", "industry_1.0", "HTTP", "GET", "AK", "/v1.0/industry/medicals/groups/" + groupId + "", "json", req, runtime), new QueryGroupInfoResponse());
    }
}
