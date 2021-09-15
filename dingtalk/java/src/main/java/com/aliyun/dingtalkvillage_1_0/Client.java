// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkvillage_1_0.models.*;
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


    public ListSubCorpsResponse listSubCorps(ListSubCorpsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSubCorpsHeaders headers = new ListSubCorpsHeaders();
        return this.listSubCorpsWithOptions(request, headers, runtime);
    }

    public ListSubCorpsResponse listSubCorpsWithOptions(ListSubCorpsRequest request, ListSubCorpsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.types)) {
            query.put("types", request.types);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isOnlyDirect)) {
            query.put("isOnlyDirect", request.isOnlyDirect);
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
        return TeaModel.toModel(this.doROARequest("ListSubCorps", "village_1.0", "HTTP", "POST", "AK", "/v1.0/village/corps/subCorps", "json", req, runtime), new ListSubCorpsResponse());
    }

    public GetVillageOrgInfoResponse getVillageOrgInfo(String subCorpId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetVillageOrgInfoHeaders headers = new GetVillageOrgInfoHeaders();
        return this.getVillageOrgInfoWithOptions(subCorpId, headers, runtime);
    }

    public GetVillageOrgInfoResponse getVillageOrgInfoWithOptions(String subCorpId, GetVillageOrgInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        subCorpId = com.aliyun.openapiutil.Client.getEncodeParam(subCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetVillageOrgInfo", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/corps/" + subCorpId + "", "json", req, runtime), new GetVillageOrgInfoResponse());
    }

    public ListResidentDeptUsersResponse listResidentDeptUsers(String departmentId, ListResidentDeptUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListResidentDeptUsersHeaders headers = new ListResidentDeptUsersHeaders();
        return this.listResidentDeptUsersWithOptions(departmentId, request, headers, runtime);
    }

    public ListResidentDeptUsersResponse listResidentDeptUsersWithOptions(String departmentId, ListResidentDeptUsersRequest request, ListResidentDeptUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            query.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
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
        return TeaModel.toModel(this.doROARequest("ListResidentDeptUsers", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/" + departmentId + "/users", "json", req, runtime), new ListResidentDeptUsersResponse());
    }

    public ListDeptSimpleUsersResponse listDeptSimpleUsers(String departmentId, ListDeptSimpleUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListDeptSimpleUsersHeaders headers = new ListDeptSimpleUsersHeaders();
        return this.listDeptSimpleUsersWithOptions(departmentId, request, headers, runtime);
    }

    public ListDeptSimpleUsersResponse listDeptSimpleUsersWithOptions(String departmentId, ListDeptSimpleUsersRequest request, ListDeptSimpleUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.containAccessLimit)) {
            query.put("containAccessLimit", request.containAccessLimit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderField)) {
            query.put("orderField", request.orderField);
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
        return TeaModel.toModel(this.doROARequest("ListDeptSimpleUsers", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/simpleUsers", "json", req, runtime), new ListDeptSimpleUsersResponse());
    }

    public GetUserByUnionIdResponse getUserByUnionId(GetUserByUnionIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserByUnionIdHeaders headers = new GetUserByUnionIdHeaders();
        return this.getUserByUnionIdWithOptions(request, headers, runtime);
    }

    public GetUserByUnionIdResponse getUserByUnionIdWithOptions(GetUserByUnionIdRequest request, GetUserByUnionIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
        return TeaModel.toModel(this.doROARequest("GetUserByUnionId", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/users/getByUnionId", "json", req, runtime), new GetUserByUnionIdResponse());
    }

    public GetResidentDeptResponse getResidentDept(String departmentId, GetResidentDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetResidentDeptHeaders headers = new GetResidentDeptHeaders();
        return this.getResidentDeptWithOptions(departmentId, request, headers, runtime);
    }

    public GetResidentDeptResponse getResidentDeptWithOptions(String departmentId, GetResidentDeptRequest request, GetResidentDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetResidentDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/departments/" + departmentId + "", "json", req, runtime), new GetResidentDeptResponse());
    }

    public GetResidentUserInfoResponse getResidentUserInfo(String departmentId, String userId, GetResidentUserInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetResidentUserInfoHeaders headers = new GetResidentUserInfoHeaders();
        return this.getResidentUserInfoWithOptions(departmentId, userId, request, headers, runtime);
    }

    public GetResidentUserInfoResponse getResidentUserInfoWithOptions(String departmentId, String userId, GetResidentUserInfoRequest request, GetResidentUserInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetResidentUserInfo", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/" + departmentId + "/users/" + userId + "", "json", req, runtime), new GetResidentUserInfoResponse());
    }

    public GetDeptResponse getDept(String departmentId, GetDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDeptHeaders headers = new GetDeptHeaders();
        return this.getDeptWithOptions(departmentId, request, headers, runtime);
    }

    public GetDeptResponse getDeptWithOptions(String departmentId, GetDeptRequest request, GetDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
        return TeaModel.toModel(this.doROARequest("GetDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/deptartments/" + departmentId + "", "json", req, runtime), new GetDeptResponse());
    }

    public ListParentByDeptResponse listParentByDept(ListParentByDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListParentByDeptHeaders headers = new ListParentByDeptHeaders();
        return this.listParentByDeptWithOptions(request, headers, runtime);
    }

    public ListParentByDeptResponse listParentByDeptWithOptions(ListParentByDeptRequest request, ListParentByDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
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
        return TeaModel.toModel(this.doROARequest("ListParentByDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/listParentByDepartment", "json", req, runtime), new ListParentByDeptResponse());
    }

    public ListDeptUserIdsResponse listDeptUserIds(String departmentId, ListDeptUserIdsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListDeptUserIdsHeaders headers = new ListDeptUserIdsHeaders();
        return this.listDeptUserIdsWithOptions(departmentId, request, headers, runtime);
    }

    public ListDeptUserIdsResponse listDeptUserIdsWithOptions(String departmentId, ListDeptUserIdsRequest request, ListDeptUserIdsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListDeptUserIds", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/userIds", "json", req, runtime), new ListDeptUserIdsResponse());
    }

    public ListSimpleUsersByRoleResponse listSimpleUsersByRole(ListSimpleUsersByRoleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSimpleUsersByRoleHeaders headers = new ListSimpleUsersByRoleHeaders();
        return this.listSimpleUsersByRoleWithOptions(request, headers, runtime);
    }

    public ListSimpleUsersByRoleResponse listSimpleUsersByRoleWithOptions(ListSimpleUsersByRoleRequest request, ListSimpleUsersByRoleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            query.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            query.put("roleId", request.roleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListSimpleUsersByRole", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/users/listByRole", "json", req, runtime), new ListSimpleUsersByRoleResponse());
    }

    public ListResidentSubDeptsResponse listResidentSubDepts(String departmentId, ListResidentSubDeptsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListResidentSubDeptsHeaders headers = new ListResidentSubDeptsHeaders();
        return this.listResidentSubDeptsWithOptions(departmentId, request, headers, runtime);
    }

    public ListResidentSubDeptsResponse listResidentSubDeptsWithOptions(String departmentId, ListResidentSubDeptsRequest request, ListResidentSubDeptsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
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
        return TeaModel.toModel(this.doROARequest("ListResidentSubDepts", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/" + departmentId + "/subDepartments", "json", req, runtime), new ListResidentSubDeptsResponse());
    }

    public ListParentByUserResponse listParentByUser(ListParentByUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListParentByUserHeaders headers = new ListParentByUserHeaders();
        return this.listParentByUserWithOptions(request, headers, runtime);
    }

    public ListParentByUserResponse listParentByUserWithOptions(ListParentByUserRequest request, ListParentByUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListParentByUser", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/listParentByUser", "json", req, runtime), new ListParentByUserResponse());
    }

    public ListSubDeptResponse listSubDept(String departmentId, ListSubDeptRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSubDeptHeaders headers = new ListSubDeptHeaders();
        return this.listSubDeptWithOptions(departmentId, request, headers, runtime);
    }

    public ListSubDeptResponse listSubDeptWithOptions(String departmentId, ListSubDeptRequest request, ListSubDeptHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
        return TeaModel.toModel(this.doROARequest("ListSubDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/subDepartments", "json", req, runtime), new ListSubDeptResponse());
    }

    public GetUserResponse getUser(String userId, GetUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(userId, request, headers, runtime);
    }

    public GetUserResponse getUserWithOptions(String userId, GetUserRequest request, GetUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
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
        return TeaModel.toModel(this.doROARequest("GetUser", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/users/getByUserId", "json", req, runtime), new GetUserResponse());
    }

    public ListDeptUsersResponse listDeptUsers(String departmentId, ListDeptUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListDeptUsersHeaders headers = new ListDeptUsersHeaders();
        return this.listDeptUsersWithOptions(departmentId, request, headers, runtime);
    }

    public ListDeptUsersResponse listDeptUsersWithOptions(String departmentId, ListDeptUsersRequest request, ListDeptUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.containAccessLimit)) {
            query.put("containAccessLimit", request.containAccessLimit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderField)) {
            query.put("orderField", request.orderField);
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
        return TeaModel.toModel(this.doROARequest("ListDeptUsers", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/users", "json", req, runtime), new ListDeptUsersResponse());
    }

    public ListResidentUserInfosResponse listResidentUserInfos(ListResidentUserInfosRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListResidentUserInfosHeaders headers = new ListResidentUserInfosHeaders();
        return this.listResidentUserInfosWithOptions(request, headers, runtime);
    }

    public ListResidentUserInfosResponse listResidentUserInfosWithOptions(ListResidentUserInfosRequest tmpReq, ListResidentUserInfosHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(tmpReq);
        ListResidentUserInfosShrinkRequest request = new ListResidentUserInfosShrinkRequest();
        com.aliyun.openapiutil.Client.convert(tmpReq, request);
        if (!com.aliyun.teautil.Common.isUnset(tmpReq.userIds)) {
            request.userIdsShrink = com.aliyun.openapiutil.Client.arrayToStringWithSpecifiedStyle(tmpReq.userIds, "userIds", "json");
        }

        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdsShrink)) {
            query.put("userIds", request.userIdsShrink);
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
        return TeaModel.toModel(this.doROARequest("ListResidentUserInfos", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentUsers/getByUserIds", "json", req, runtime), new ListResidentUserInfosResponse());
    }

    public ListSubDeptIdsResponse listSubDeptIds(String departmentId, ListSubDeptIdsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSubDeptIdsHeaders headers = new ListSubDeptIdsHeaders();
        return this.listSubDeptIdsWithOptions(departmentId, request, headers, runtime);
    }

    public ListSubDeptIdsResponse listSubDeptIdsWithOptions(String departmentId, ListSubDeptIdsRequest request, ListSubDeptIdsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListSubDeptIds", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/subDepartmentIds", "json", req, runtime), new ListSubDeptIdsResponse());
    }
}
