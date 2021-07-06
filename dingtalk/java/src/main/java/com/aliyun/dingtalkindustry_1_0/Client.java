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
