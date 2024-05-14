// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkstorage_2_0.models.*;

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
     * @summary 添加权限
     *
     * @param request AddPermissionRequest
     * @param headers AddPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddPermissionResponse
     */
    public AddPermissionResponse addPermissionWithOptions(String dentryUuid, AddPermissionRequest request, AddPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            body.put("roleId", request.roleId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "AddPermission"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddPermissionResponse());
    }

    /**
     * @summary 添加权限
     *
     * @param request AddPermissionRequest
     * @return AddPermissionResponse
     */
    public AddPermissionResponse addPermission(String dentryUuid, AddPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddPermissionHeaders headers = new AddPermissionHeaders();
        return this.addPermissionWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 提交文件
     *
     * @param request CommitFileRequest
     * @param headers CommitFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CommitFileResponse
     */
    public CommitFileResponse commitFileWithOptions(String parentDentryUuid, CommitFileRequest request, CommitFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.uploadKey)) {
            body.put("uploadKey", request.uploadKey);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "CommitFile"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/files/" + parentDentryUuid + "/commit"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CommitFileResponse());
    }

    /**
     * @summary 提交文件
     *
     * @param request CommitFileRequest
     * @return CommitFileResponse
     */
    public CommitFileResponse commitFile(String parentDentryUuid, CommitFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CommitFileHeaders headers = new CommitFileHeaders();
        return this.commitFileWithOptions(parentDentryUuid, request, headers, runtime);
    }

    /**
     * @summary 删除权限
     *
     * @param request DeletePermissionRequest
     * @param headers DeletePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeletePermissionResponse
     */
    public DeletePermissionResponse deletePermissionWithOptions(String dentryUuid, DeletePermissionRequest request, DeletePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            body.put("roleId", request.roleId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "DeletePermission"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeletePermissionResponse());
    }

    /**
     * @summary 删除权限
     *
     * @param request DeletePermissionRequest
     * @return DeletePermissionResponse
     */
    public DeletePermissionResponse deletePermission(String dentryUuid, DeletePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeletePermissionHeaders headers = new DeletePermissionHeaders();
        return this.deletePermissionWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 获取文件上传信息
     *
     * @param request GetFileUploadInfoRequest
     * @param headers GetFileUploadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileUploadInfoResponse
     */
    public GetFileUploadInfoResponse getFileUploadInfoWithOptions(String parentDentryUuid, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.protocol)) {
            body.put("protocol", request.protocol);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetFileUploadInfo"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/files/" + parentDentryUuid + "/uploadInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileUploadInfoResponse());
    }

    /**
     * @summary 获取文件上传信息
     *
     * @param request GetFileUploadInfoRequest
     * @return GetFileUploadInfoResponse
     */
    public GetFileUploadInfoResponse getFileUploadInfo(String parentDentryUuid, GetFileUploadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
        return this.getFileUploadInfoWithOptions(parentDentryUuid, request, headers, runtime);
    }

    /**
     * @summary 获取权限继承模式
     *
     * @param request GetPermissionInheritanceRequest
     * @param headers GetPermissionInheritanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPermissionInheritanceResponse
     */
    public GetPermissionInheritanceResponse getPermissionInheritanceWithOptions(String dentryUuid, GetPermissionInheritanceRequest request, GetPermissionInheritanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
            new TeaPair("action", "GetPermissionInheritance"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/inheritances"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPermissionInheritanceResponse());
    }

    /**
     * @summary 获取权限继承模式
     *
     * @param request GetPermissionInheritanceRequest
     * @return GetPermissionInheritanceResponse
     */
    public GetPermissionInheritanceResponse getPermissionInheritance(String dentryUuid, GetPermissionInheritanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPermissionInheritanceHeaders headers = new GetPermissionInheritanceHeaders();
        return this.getPermissionInheritanceWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 获取权限列表
     *
     * @param request ListPermissionsRequest
     * @param headers ListPermissionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListPermissionsResponse
     */
    public ListPermissionsResponse listPermissionsWithOptions(String dentryUuid, ListPermissionsRequest request, ListPermissionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListPermissions"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListPermissionsResponse());
    }

    /**
     * @summary 获取权限列表
     *
     * @param request ListPermissionsRequest
     * @return ListPermissionsResponse
     */
    public ListPermissionsResponse listPermissions(String dentryUuid, ListPermissionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPermissionsHeaders headers = new ListPermissionsHeaders();
        return this.listPermissionsWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 查询员工离职时空间默认转交人(管理员)
     *
     * @param request ManagerGetDefaultHandOverUserRequest
     * @param headers ManagerGetDefaultHandOverUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ManagerGetDefaultHandOverUserResponse
     */
    public ManagerGetDefaultHandOverUserResponse managerGetDefaultHandOverUserWithOptions(ManagerGetDefaultHandOverUserRequest request, ManagerGetDefaultHandOverUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
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
            new TeaPair("action", "ManagerGetDefaultHandOverUser"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/managementSettings/defaultHandOverUsers"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ManagerGetDefaultHandOverUserResponse());
    }

    /**
     * @summary 查询员工离职时空间默认转交人(管理员)
     *
     * @param request ManagerGetDefaultHandOverUserRequest
     * @return ManagerGetDefaultHandOverUserResponse
     */
    public ManagerGetDefaultHandOverUserResponse managerGetDefaultHandOverUser(ManagerGetDefaultHandOverUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ManagerGetDefaultHandOverUserHeaders headers = new ManagerGetDefaultHandOverUserHeaders();
        return this.managerGetDefaultHandOverUserWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设置员工离职时空间默认转交人(管理员)
     *
     * @param request ManagerSetDefaultHandOverUserRequest
     * @param headers ManagerSetDefaultHandOverUserHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ManagerSetDefaultHandOverUserResponse
     */
    public ManagerSetDefaultHandOverUserResponse managerSetDefaultHandOverUserWithOptions(ManagerSetDefaultHandOverUserRequest request, ManagerSetDefaultHandOverUserHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.defaultHandoverUserId)) {
            body.put("defaultHandoverUserId", request.defaultHandoverUserId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ManagerSetDefaultHandOverUser"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/managementSettings/defaultHandOverUsers/set"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ManagerSetDefaultHandOverUserResponse());
    }

    /**
     * @summary 设置员工离职时空间默认转交人(管理员)
     *
     * @param request ManagerSetDefaultHandOverUserRequest
     * @return ManagerSetDefaultHandOverUserResponse
     */
    public ManagerSetDefaultHandOverUserResponse managerSetDefaultHandOverUser(ManagerSetDefaultHandOverUserRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ManagerSetDefaultHandOverUserHeaders headers = new ManagerSetDefaultHandOverUserHeaders();
        return this.managerSetDefaultHandOverUserWithOptions(request, headers, runtime);
    }

    /**
     * @summary 搜索文件
     *
     * @param request SearchDentriesRequest
     * @param headers SearchDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchDentriesResponse
     */
    public SearchDentriesResponse searchDentriesWithOptions(SearchDentriesRequest request, SearchDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            body.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchDentries"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/dentries/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchDentriesResponse());
    }

    /**
     * @summary 搜索文件
     *
     * @param request SearchDentriesRequest
     * @return SearchDentriesResponse
     */
    public SearchDentriesResponse searchDentries(SearchDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchDentriesHeaders headers = new SearchDentriesHeaders();
        return this.searchDentriesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 搜索公开发布文件
     *
     * @param request SearchPublishDentriesRequest
     * @param headers SearchPublishDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchPublishDentriesResponse
     */
    public SearchPublishDentriesResponse searchPublishDentriesWithOptions(SearchPublishDentriesRequest request, SearchPublishDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            body.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.workspaceId)) {
            body.put("workspaceId", request.workspaceId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchPublishDentries"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/publishDentries/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchPublishDentriesResponse());
    }

    /**
     * @summary 搜索公开发布文件
     *
     * @param request SearchPublishDentriesRequest
     * @return SearchPublishDentriesResponse
     */
    public SearchPublishDentriesResponse searchPublishDentries(SearchPublishDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchPublishDentriesHeaders headers = new SearchPublishDentriesHeaders();
        return this.searchPublishDentriesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 搜索知识库
     *
     * @param request SearchWorkspacesRequest
     * @param headers SearchWorkspacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SearchWorkspacesResponse
     */
    public SearchWorkspacesResponse searchWorkspacesWithOptions(SearchWorkspacesRequest request, SearchWorkspacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            query.put("operatorId", request.operatorId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.keyword)) {
            body.put("keyword", request.keyword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SearchWorkspaces"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/workspaces/search"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SearchWorkspacesResponse());
    }

    /**
     * @summary 搜索知识库
     *
     * @param request SearchWorkspacesRequest
     * @return SearchWorkspacesResponse
     */
    public SearchWorkspacesResponse searchWorkspaces(SearchWorkspacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SearchWorkspacesHeaders headers = new SearchWorkspacesHeaders();
        return this.searchWorkspacesWithOptions(request, headers, runtime);
    }

    /**
     * @summary 设置权限继承模式
     *
     * @param request SetPermissionInheritanceRequest
     * @param headers SetPermissionInheritanceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SetPermissionInheritanceResponse
     */
    public SetPermissionInheritanceResponse setPermissionInheritanceWithOptions(String dentryUuid, SetPermissionInheritanceRequest request, SetPermissionInheritanceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.inheritance)) {
            body.put("inheritance", request.inheritance);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "SetPermissionInheritance"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions/inheritances"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SetPermissionInheritanceResponse());
    }

    /**
     * @summary 设置权限继承模式
     *
     * @param request SetPermissionInheritanceRequest
     * @return SetPermissionInheritanceResponse
     */
    public SetPermissionInheritanceResponse setPermissionInheritance(String dentryUuid, SetPermissionInheritanceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SetPermissionInheritanceHeaders headers = new SetPermissionInheritanceHeaders();
        return this.setPermissionInheritanceWithOptions(dentryUuid, request, headers, runtime);
    }

    /**
     * @summary 修改权限
     *
     * @param request UpdatePermissionRequest
     * @param headers UpdatePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePermissionResponse
     */
    public UpdatePermissionResponse updatePermissionWithOptions(String dentryUuid, UpdatePermissionRequest request, UpdatePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            body.put("roleId", request.roleId);
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdatePermission"),
            new TeaPair("version", "storage_2.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v2.0/storage/spaces/dentries/" + dentryUuid + "/permissions"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdatePermissionResponse());
    }

    /**
     * @summary 修改权限
     *
     * @param request UpdatePermissionRequest
     * @return UpdatePermissionResponse
     */
    public UpdatePermissionResponse updatePermission(String dentryUuid, UpdatePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
        return this.updatePermissionWithOptions(dentryUuid, request, headers, runtime);
    }
}
