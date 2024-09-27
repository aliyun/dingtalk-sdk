// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkvillage_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._productId = "dingtalk";
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>获取部门详情</p>
     * 
     * @param request GetDeptRequest
     * @param headers GetDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDeptResponse
     */
    public GetDeptResponse getDeptWithOptions(String departmentId, GetDeptRequest request, GetDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetDept"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/deptartments/" + departmentId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取部门详情</p>
     * 
     * @param request GetDeptRequest
     * @return GetDeptResponse
     */
    public GetDeptResponse getDept(String departmentId, GetDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDeptHeaders headers = new GetDeptHeaders();
        return this.getDeptWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取部门信息</p>
     * 
     * @param request GetResidentDeptRequest
     * @param headers GetResidentDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetResidentDeptResponse
     */
    public GetResidentDeptResponse getResidentDeptWithOptions(String departmentId, GetResidentDeptRequest request, GetResidentDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetResidentDept"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/residentDepartments/departments/" + departmentId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetResidentDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取部门信息</p>
     * 
     * @param request GetResidentDeptRequest
     * @return GetResidentDeptResponse
     */
    public GetResidentDeptResponse getResidentDept(String departmentId, GetResidentDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetResidentDeptHeaders headers = new GetResidentDeptHeaders();
        return this.getResidentDeptWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取部门下某个人的详细信息</p>
     * 
     * @param request GetResidentUserInfoRequest
     * @param headers GetResidentUserInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetResidentUserInfoResponse
     */
    public GetResidentUserInfoResponse getResidentUserInfoWithOptions(String departmentId, String userId, GetResidentUserInfoRequest request, GetResidentUserInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetResidentUserInfo"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/residentDepartments/" + departmentId + "/users/" + userId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetResidentUserInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取部门下某个人的详细信息</p>
     * 
     * @param request GetResidentUserInfoRequest
     * @return GetResidentUserInfoResponse
     */
    public GetResidentUserInfoResponse getResidentUserInfo(String departmentId, String userId, GetResidentUserInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetResidentUserInfoHeaders headers = new GetResidentUserInfoHeaders();
        return this.getResidentUserInfoWithOptions(departmentId, userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户详情</p>
     * 
     * @param request GetUserRequest
     * @param headers GetUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserResponse
     */
    public GetUserResponse getUserWithOptions(String userId, GetUserRequest request, GetUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUser"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/users/getByUserId"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户详情</p>
     * 
     * @param request GetUserRequest
     * @return GetUserResponse
     */
    public GetUserResponse getUser(String userId, GetUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(userId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据unionId查询用户详情</p>
     * 
     * @param request GetUserByUnionIdRequest
     * @param headers GetUserByUnionIdHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUserByUnionIdResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetUserByUnionId"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/users/getByUnionId"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUserByUnionIdResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据unionId查询用户详情</p>
     * 
     * @param request GetUserByUnionIdRequest
     * @return GetUserByUnionIdResponse
     */
    public GetUserByUnionIdResponse getUserByUnionId(GetUserByUnionIdRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUserByUnionIdHeaders headers = new GetUserByUnionIdHeaders();
        return this.getUserByUnionIdWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取对外开放的企业信息</p>
     * 
     * @param headers GetVillageOrgInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetVillageOrgInfoResponse
     */
    public GetVillageOrgInfoResponse getVillageOrgInfoWithOptions(String subCorpId, GetVillageOrgInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetVillageOrgInfo"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/corps/" + subCorpId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetVillageOrgInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取对外开放的企业信息</p>
     * @return GetVillageOrgInfoResponse
     */
    public GetVillageOrgInfoResponse getVillageOrgInfo(String subCorpId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetVillageOrgInfoHeaders headers = new GetVillageOrgInfoHeaders();
        return this.getVillageOrgInfoWithOptions(subCorpId, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下简略用户列表</p>
     * 
     * @param request ListDeptSimpleUsersRequest
     * @param headers ListDeptSimpleUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListDeptSimpleUsersResponse
     */
    public ListDeptSimpleUsersResponse listDeptSimpleUsersWithOptions(String departmentId, ListDeptSimpleUsersRequest request, ListDeptSimpleUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListDeptSimpleUsers"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/departments/" + departmentId + "/simpleUsers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListDeptSimpleUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下简略用户列表</p>
     * 
     * @param request ListDeptSimpleUsersRequest
     * @return ListDeptSimpleUsersResponse
     */
    public ListDeptSimpleUsersResponse listDeptSimpleUsers(String departmentId, ListDeptSimpleUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDeptSimpleUsersHeaders headers = new ListDeptSimpleUsersHeaders();
        return this.listDeptSimpleUsersWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下userid列表</p>
     * 
     * @param request ListDeptUserIdsRequest
     * @param headers ListDeptUserIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListDeptUserIdsResponse
     */
    public ListDeptUserIdsResponse listDeptUserIdsWithOptions(String departmentId, ListDeptUserIdsRequest request, ListDeptUserIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListDeptUserIds"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/departments/" + departmentId + "/userIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListDeptUserIdsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下userid列表</p>
     * 
     * @param request ListDeptUserIdsRequest
     * @return ListDeptUserIdsResponse
     */
    public ListDeptUserIdsResponse listDeptUserIds(String departmentId, ListDeptUserIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDeptUserIdsHeaders headers = new ListDeptUserIdsHeaders();
        return this.listDeptUserIdsWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下user完整信息</p>
     * 
     * @param request ListDeptUsersRequest
     * @param headers ListDeptUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListDeptUsersResponse
     */
    public ListDeptUsersResponse listDeptUsersWithOptions(String departmentId, ListDeptUsersRequest request, ListDeptUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListDeptUsers"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/departments/" + departmentId + "/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListDeptUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下user完整信息</p>
     * 
     * @param request ListDeptUsersRequest
     * @return ListDeptUsersResponse
     */
    public ListDeptUsersResponse listDeptUsers(String departmentId, ListDeptUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDeptUsersHeaders headers = new ListDeptUsersHeaders();
        return this.listDeptUsersWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门所有父部门列表</p>
     * 
     * @param request ListParentByDeptRequest
     * @param headers ListParentByDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListParentByDeptResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListParentByDept"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/departments/listParentByDepartment"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListParentByDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门所有父部门列表</p>
     * 
     * @param request ListParentByDeptRequest
     * @return ListParentByDeptResponse
     */
    public ListParentByDeptResponse listParentByDept(ListParentByDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListParentByDeptHeaders headers = new ListParentByDeptHeaders();
        return this.listParentByDeptWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户所有父部门列表</p>
     * 
     * @param request ListParentByUserRequest
     * @param headers ListParentByUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListParentByUserResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListParentByUser"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/departments/listParentByUser"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListParentByUserResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询用户所有父部门列表</p>
     * 
     * @param request ListParentByUserRequest
     * @return ListParentByUserResponse
     */
    public ListParentByUserResponse listParentByUser(ListParentByUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListParentByUserHeaders headers = new ListParentByUserHeaders();
        return this.listParentByUserWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取部门下人员信息</p>
     * 
     * @param request ListResidentDeptUsersRequest
     * @param headers ListResidentDeptUsersHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListResidentDeptUsersResponse
     */
    public ListResidentDeptUsersResponse listResidentDeptUsersWithOptions(String departmentId, ListResidentDeptUsersRequest request, ListResidentDeptUsersHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListResidentDeptUsers"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/residentDepartments/" + departmentId + "/users"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListResidentDeptUsersResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取部门下人员信息</p>
     * 
     * @param request ListResidentDeptUsersRequest
     * @return ListResidentDeptUsersResponse
     */
    public ListResidentDeptUsersResponse listResidentDeptUsers(String departmentId, ListResidentDeptUsersRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListResidentDeptUsersHeaders headers = new ListResidentDeptUsersHeaders();
        return this.listResidentDeptUsersWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取子部门列表</p>
     * 
     * @param request ListResidentSubDeptsRequest
     * @param headers ListResidentSubDeptsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListResidentSubDeptsResponse
     */
    public ListResidentSubDeptsResponse listResidentSubDeptsWithOptions(String departmentId, ListResidentSubDeptsRequest request, ListResidentSubDeptsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListResidentSubDepts"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/residentDepartments/" + departmentId + "/subDepartments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListResidentSubDeptsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录获取子部门列表</p>
     * 
     * @param request ListResidentSubDeptsRequest
     * @return ListResidentSubDeptsResponse
     */
    public ListResidentSubDeptsResponse listResidentSubDepts(String departmentId, ListResidentSubDeptsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListResidentSubDeptsHeaders headers = new ListResidentSubDeptsHeaders();
        return this.listResidentSubDeptsWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录批量获取用户详细信息</p>
     * 
     * @param tmpReq ListResidentUserInfosRequest
     * @param headers ListResidentUserInfosHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListResidentUserInfosResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListResidentUserInfos"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/residentUsers/getByUserIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListResidentUserInfosResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>居民通讯录批量获取用户详细信息</p>
     * 
     * @param request ListResidentUserInfosRequest
     * @return ListResidentUserInfosResponse
     */
    public ListResidentUserInfosResponse listResidentUserInfos(ListResidentUserInfosRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListResidentUserInfosHeaders headers = new ListResidentUserInfosHeaders();
        return this.listResidentUserInfosWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>根据角色获取用户列表</p>
     * 
     * @param request ListSimpleUsersByRoleRequest
     * @param headers ListSimpleUsersByRoleHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSimpleUsersByRoleResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListSimpleUsersByRole"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/users/listByRole"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSimpleUsersByRoleResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>根据角色获取用户列表</p>
     * 
     * @param request ListSimpleUsersByRoleRequest
     * @return ListSimpleUsersByRoleResponse
     */
    public ListSimpleUsersByRoleResponse listSimpleUsersByRole(ListSimpleUsersByRoleRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSimpleUsersByRoleHeaders headers = new ListSimpleUsersByRoleHeaders();
        return this.listSimpleUsersByRoleWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取下级指定区域层级组织</p>
     * 
     * @param request ListSubCorpsRequest
     * @param headers ListSubCorpsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSubCorpsResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListSubCorps"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/corps/subCorps"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSubCorpsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取下级指定区域层级组织</p>
     * 
     * @param request ListSubCorpsRequest
     * @return ListSubCorpsResponse
     */
    public ListSubCorpsResponse listSubCorps(ListSubCorpsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSubCorpsHeaders headers = new ListSubCorpsHeaders();
        return this.listSubCorpsWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询子部门列表</p>
     * 
     * @param request ListSubDeptRequest
     * @param headers ListSubDeptHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSubDeptResponse
     */
    public ListSubDeptResponse listSubDeptWithOptions(String departmentId, ListSubDeptRequest request, ListSubDeptHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListSubDept"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/departments/" + departmentId + "/subDepartments"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSubDeptResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询子部门列表</p>
     * 
     * @param request ListSubDeptRequest
     * @return ListSubDeptResponse
     */
    public ListSubDeptResponse listSubDept(String departmentId, ListSubDeptRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSubDeptHeaders headers = new ListSubDeptHeaders();
        return this.listSubDeptWithOptions(departmentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下的子部门ID列表，不会递归查询，只包含ID</p>
     * 
     * @param request ListSubDeptIdsRequest
     * @param headers ListSubDeptIdsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSubDeptIdsResponse
     */
    public ListSubDeptIdsResponse listSubDeptIdsWithOptions(String departmentId, ListSubDeptIdsRequest request, ListSubDeptIdsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListSubDeptIds"),
            new TeaPair("version", "village_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/village/departments/" + departmentId + "/subDepartmentIds"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSubDeptIdsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询部门下的子部门ID列表，不会递归查询，只包含ID</p>
     * 
     * @param request ListSubDeptIdsRequest
     * @return ListSubDeptIdsResponse
     */
    public ListSubDeptIdsResponse listSubDeptIds(String departmentId, ListSubDeptIdsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSubDeptIdsHeaders headers = new ListSubDeptIdsHeaders();
        return this.listSubDeptIdsWithOptions(departmentId, request, headers, runtime);
    }
}
