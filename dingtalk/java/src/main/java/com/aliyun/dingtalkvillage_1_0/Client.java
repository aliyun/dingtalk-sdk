// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkvillage_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public GetDeptResponse getDept(String departmentId, GetDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDeptHeaders headers = new GetDeptHeaders();
        return this.getDeptWithOptions(departmentId, request, headers, runtime);
    }

    public GetDeptResponse getDeptWithOptions(String departmentId, GetDeptRequest request, GetDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/deptartments/" + departmentId + "", "json", req, runtime), new GetDeptResponse());
    }

    public GetResidentDeptResponse getResidentDept(String departmentId, GetResidentDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetResidentDeptHeaders headers = new GetResidentDeptHeaders();
        return this.getResidentDeptWithOptions(departmentId, request, headers, runtime);
    }

    public GetResidentDeptResponse getResidentDeptWithOptions(String departmentId, GetResidentDeptRequest request, GetResidentDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetResidentDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/departments/" + departmentId + "", "json", req, runtime), new GetResidentDeptResponse());
    }

    public GetResidentUserInfoResponse getResidentUserInfo(String departmentId, String userId, GetResidentUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetResidentUserInfoHeaders headers = new GetResidentUserInfoHeaders();
        return this.getResidentUserInfoWithOptions(departmentId, userId, request, headers, runtime);
    }

    public GetResidentUserInfoResponse getResidentUserInfoWithOptions(String departmentId, String userId, GetResidentUserInfoRequest request, GetResidentUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetResidentUserInfo", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/" + departmentId + "/users/" + userId + "", "json", req, runtime), new GetResidentUserInfoResponse());
    }

    public GetUserResponse getUser(String userId, GetUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(userId, request, headers, runtime);
    }

    public GetUserResponse getUserWithOptions(String userId, GetUserRequest request, GetUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        userId = com.aliyun.openapiutil.Client.getEncodeParam(userId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetUser", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/users/getByUserId", "json", req, runtime), new GetUserResponse());
    }

    public GetUserByUnionIdResponse getUserByUnionId(GetUserByUnionIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserByUnionIdHeaders headers = new GetUserByUnionIdHeaders();
        return this.getUserByUnionIdWithOptions(request, headers, runtime);
    }

    public GetUserByUnionIdResponse getUserByUnionIdWithOptions(GetUserByUnionIdRequest request, GetUserByUnionIdHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetUserByUnionId", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/users/getByUnionId", "json", req, runtime), new GetUserByUnionIdResponse());
    }

    public GetVillageOrgInfoResponse getVillageOrgInfo(String subCorpId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetVillageOrgInfoHeaders headers = new GetVillageOrgInfoHeaders();
        return this.getVillageOrgInfoWithOptions(subCorpId, headers, runtime);
    }

    public GetVillageOrgInfoResponse getVillageOrgInfoWithOptions(String subCorpId, GetVillageOrgInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        subCorpId = com.aliyun.openapiutil.Client.getEncodeParam(subCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetVillageOrgInfo", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/corps/" + subCorpId + "", "json", req, runtime), new GetVillageOrgInfoResponse());
    }

    public ListDeptSimpleUsersResponse listDeptSimpleUsers(String departmentId, ListDeptSimpleUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDeptSimpleUsersHeaders headers = new ListDeptSimpleUsersHeaders();
        return this.listDeptSimpleUsersWithOptions(departmentId, request, headers, runtime);
    }

    public ListDeptSimpleUsersResponse listDeptSimpleUsersWithOptions(String departmentId, ListDeptSimpleUsersRequest request, ListDeptSimpleUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.containAccessLimit)) {
            query.put("containAccessLimit", request.containAccessLimit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderField)) {
            query.put("orderField", request.orderField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListDeptSimpleUsers", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/simpleUsers", "json", req, runtime), new ListDeptSimpleUsersResponse());
    }

    public ListDeptUserIdsResponse listDeptUserIds(String departmentId, ListDeptUserIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDeptUserIdsHeaders headers = new ListDeptUserIdsHeaders();
        return this.listDeptUserIdsWithOptions(departmentId, request, headers, runtime);
    }

    public ListDeptUserIdsResponse listDeptUserIdsWithOptions(String departmentId, ListDeptUserIdsRequest request, ListDeptUserIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListDeptUserIds", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/userIds", "json", req, runtime), new ListDeptUserIdsResponse());
    }

    public ListDeptUsersResponse listDeptUsers(String departmentId, ListDeptUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDeptUsersHeaders headers = new ListDeptUsersHeaders();
        return this.listDeptUsersWithOptions(departmentId, request, headers, runtime);
    }

    public ListDeptUsersResponse listDeptUsersWithOptions(String departmentId, ListDeptUsersRequest request, ListDeptUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.containAccessLimit)) {
            query.put("containAccessLimit", request.containAccessLimit);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderField)) {
            query.put("orderField", request.orderField);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListDeptUsers", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/users", "json", req, runtime), new ListDeptUsersResponse());
    }

    public ListParentByDeptResponse listParentByDept(ListParentByDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListParentByDeptHeaders headers = new ListParentByDeptHeaders();
        return this.listParentByDeptWithOptions(request, headers, runtime);
    }

    public ListParentByDeptResponse listParentByDeptWithOptions(ListParentByDeptRequest request, ListParentByDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListParentByDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/listParentByDepartment", "json", req, runtime), new ListParentByDeptResponse());
    }

    public ListParentByUserResponse listParentByUser(ListParentByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListParentByUserHeaders headers = new ListParentByUserHeaders();
        return this.listParentByUserWithOptions(request, headers, runtime);
    }

    public ListParentByUserResponse listParentByUserWithOptions(ListParentByUserRequest request, ListParentByUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListParentByUser", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/listParentByUser", "json", req, runtime), new ListParentByUserResponse());
    }

    public ListResidentDeptUsersResponse listResidentDeptUsers(String departmentId, ListResidentDeptUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListResidentDeptUsersHeaders headers = new ListResidentDeptUsersHeaders();
        return this.listResidentDeptUsersWithOptions(departmentId, request, headers, runtime);
    }

    public ListResidentDeptUsersResponse listResidentDeptUsersWithOptions(String departmentId, ListResidentDeptUsersRequest request, ListResidentDeptUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            query.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListResidentDeptUsers", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/" + departmentId + "/users", "json", req, runtime), new ListResidentDeptUsersResponse());
    }

    public ListResidentSubDeptsResponse listResidentSubDepts(String departmentId, ListResidentSubDeptsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListResidentSubDeptsHeaders headers = new ListResidentSubDeptsHeaders();
        return this.listResidentSubDeptsWithOptions(departmentId, request, headers, runtime);
    }

    public ListResidentSubDeptsResponse listResidentSubDeptsWithOptions(String departmentId, ListResidentSubDeptsRequest request, ListResidentSubDeptsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.cursor)) {
            query.put("cursor", request.cursor);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListResidentSubDepts", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentDepartments/" + departmentId + "/subDepartments", "json", req, runtime), new ListResidentSubDeptsResponse());
    }

    public ListResidentUserInfosResponse listResidentUserInfos(ListResidentUserInfosRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListResidentUserInfosHeaders headers = new ListResidentUserInfosHeaders();
        return this.listResidentUserInfosWithOptions(request, headers, runtime);
    }

    public ListResidentUserInfosResponse listResidentUserInfosWithOptions(ListResidentUserInfosRequest tmpReq, ListResidentUserInfosHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListResidentUserInfos", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/residentUsers/getByUserIds", "json", req, runtime), new ListResidentUserInfosResponse());
    }

    public ListSimpleUsersByRoleResponse listSimpleUsersByRole(ListSimpleUsersByRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSimpleUsersByRoleHeaders headers = new ListSimpleUsersByRoleHeaders();
        return this.listSimpleUsersByRoleWithOptions(request, headers, runtime);
    }

    public ListSimpleUsersByRoleResponse listSimpleUsersByRoleWithOptions(ListSimpleUsersByRoleRequest request, ListSimpleUsersByRoleHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            query.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            query.put("roleId", request.roleId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListSimpleUsersByRole", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/users/listByRole", "json", req, runtime), new ListSimpleUsersByRoleResponse());
    }

    public ListSubCorpsResponse listSubCorps(ListSubCorpsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSubCorpsHeaders headers = new ListSubCorpsHeaders();
        return this.listSubCorpsWithOptions(request, headers, runtime);
    }

    public ListSubCorpsResponse listSubCorpsWithOptions(ListSubCorpsRequest request, ListSubCorpsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isOnlyDirect)) {
            query.put("isOnlyDirect", request.isOnlyDirect);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.types)) {
            query.put("types", request.types);
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
        return TeaModel.toModel(this.doROARequest("ListSubCorps", "village_1.0", "HTTP", "POST", "AK", "/v1.0/village/corps/subCorps", "json", req, runtime), new ListSubCorpsResponse());
    }

    public ListSubDeptResponse listSubDept(String departmentId, ListSubDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSubDeptHeaders headers = new ListSubDeptHeaders();
        return this.listSubDeptWithOptions(departmentId, request, headers, runtime);
    }

    public ListSubDeptResponse listSubDeptWithOptions(String departmentId, ListSubDeptRequest request, ListSubDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        departmentId = com.aliyun.openapiutil.Client.getEncodeParam(departmentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.language)) {
            query.put("language", request.language);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.subCorpId)) {
            query.put("subCorpId", request.subCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListSubDept", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/subDepartments", "json", req, runtime), new ListSubDeptResponse());
    }

    public ListSubDeptIdsResponse listSubDeptIds(String departmentId, ListSubDeptIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSubDeptIdsHeaders headers = new ListSubDeptIdsHeaders();
        return this.listSubDeptIdsWithOptions(departmentId, request, headers, runtime);
    }

    public ListSubDeptIdsResponse listSubDeptIdsWithOptions(String departmentId, ListSubDeptIdsRequest request, ListSubDeptIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListSubDeptIds", "village_1.0", "HTTP", "GET", "AK", "/v1.0/village/departments/" + departmentId + "/subDepartmentIds", "json", req, runtime), new ListSubDeptIdsResponse());
    }
}
