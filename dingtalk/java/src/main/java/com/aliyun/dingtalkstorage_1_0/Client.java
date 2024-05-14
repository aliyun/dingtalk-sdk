// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkstorage_1_0.models.*;

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
     * @summary 添加文件夹
     *
     * @param request AddFolderRequest
     * @param headers AddFolderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddFolderResponse
     */
    public AddFolderResponse addFolderWithOptions(String spaceId, String parentId, AddFolderRequest request, AddFolderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "AddFolder"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + parentId + "/folders"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddFolderResponse());
    }

    /**
     * @summary 添加文件夹
     *
     * @param request AddFolderRequest
     * @return AddFolderResponse
     */
    public AddFolderResponse addFolder(String spaceId, String parentId, AddFolderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddFolderHeaders headers = new AddFolderHeaders();
        return this.addFolderWithOptions(spaceId, parentId, request, headers, runtime);
    }

    /**
     * @summary 添加权限
     *
     * @param request AddPermissionRequest
     * @param headers AddPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddPermissionResponse
     */
    public AddPermissionResponse addPermissionWithOptions(String spaceId, String dentryId, AddPermissionRequest request, AddPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions"),
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
    public AddPermissionResponse addPermission(String spaceId, String dentryId, AddPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddPermissionHeaders headers = new AddPermissionHeaders();
        return this.addPermissionWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 添加空间
     *
     * @param request AddSpaceRequest
     * @param headers AddSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddSpaceResponse
     */
    public AddSpaceResponse addSpaceWithOptions(AddSpaceRequest request, AddSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "AddSpace"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddSpaceResponse());
    }

    /**
     * @summary 添加空间
     *
     * @param request AddSpaceRequest
     * @return AddSpaceResponse
     */
    public AddSpaceResponse addSpace(AddSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddSpaceHeaders headers = new AddSpaceHeaders();
        return this.addSpaceWithOptions(request, headers, runtime);
    }

    /**
     * @summary 清空回收站
     *
     * @param request ClearRecycleBinRequest
     * @param headers ClearRecycleBinHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ClearRecycleBinResponse
     */
    public ClearRecycleBinResponse clearRecycleBinWithOptions(String recycleBinId, ClearRecycleBinRequest request, ClearRecycleBinHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ClearRecycleBin"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins/" + recycleBinId + "/clear"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ClearRecycleBinResponse());
    }

    /**
     * @summary 清空回收站
     *
     * @param request ClearRecycleBinRequest
     * @return ClearRecycleBinResponse
     */
    public ClearRecycleBinResponse clearRecycleBin(String recycleBinId, ClearRecycleBinRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ClearRecycleBinHeaders headers = new ClearRecycleBinHeaders();
        return this.clearRecycleBinWithOptions(recycleBinId, request, headers, runtime);
    }

    /**
     * @summary 提交文件
     *
     * @param request CommitFileRequest
     * @param headers CommitFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CommitFileResponse
     */
    public CommitFileResponse commitFileWithOptions(String spaceId, CommitFileRequest request, CommitFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
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
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/files/commit"),
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
    public CommitFileResponse commitFile(String spaceId, CommitFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CommitFileHeaders headers = new CommitFileHeaders();
        return this.commitFileWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 批量拷贝文件或文件夹
     *
     * @param request CopyDentriesRequest
     * @param headers CopyDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CopyDentriesResponse
     */
    public CopyDentriesResponse copyDentriesWithOptions(String spaceId, CopyDentriesRequest request, CopyDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryIds)) {
            body.put("dentryIds", request.dentryIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetFolderId)) {
            body.put("targetFolderId", request.targetFolderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
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
            new TeaPair("action", "CopyDentries"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/batchCopy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CopyDentriesResponse());
    }

    /**
     * @summary 批量拷贝文件或文件夹
     *
     * @param request CopyDentriesRequest
     * @return CopyDentriesResponse
     */
    public CopyDentriesResponse copyDentries(String spaceId, CopyDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CopyDentriesHeaders headers = new CopyDentriesHeaders();
        return this.copyDentriesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 拷贝文件或文件夹
     *
     * @param request CopyDentryRequest
     * @param headers CopyDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CopyDentryResponse
     */
    public CopyDentryResponse copyDentryWithOptions(String spaceId, String dentryId, CopyDentryRequest request, CopyDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetFolderId)) {
            body.put("targetFolderId", request.targetFolderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
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
            new TeaPair("action", "CopyDentry"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/copy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CopyDentryResponse());
    }

    /**
     * @summary 拷贝文件或文件夹
     *
     * @param request CopyDentryRequest
     * @return CopyDentryResponse
     */
    public CopyDentryResponse copyDentry(String spaceId, String dentryId, CopyDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CopyDentryHeaders headers = new CopyDentryHeaders();
        return this.copyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 批量删除文件或文件夹
     *
     * @param request DeleteDentriesRequest
     * @param headers DeleteDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDentriesResponse
     */
    public DeleteDentriesResponse deleteDentriesWithOptions(String spaceId, DeleteDentriesRequest request, DeleteDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryIds)) {
            body.put("dentryIds", request.dentryIds);
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
            new TeaPair("action", "DeleteDentries"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDentriesResponse());
    }

    /**
     * @summary 批量删除文件或文件夹
     *
     * @param request DeleteDentriesRequest
     * @return DeleteDentriesResponse
     */
    public DeleteDentriesResponse deleteDentries(String spaceId, DeleteDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDentriesHeaders headers = new DeleteDentriesHeaders();
        return this.deleteDentriesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 删除文件或文件夹
     *
     * @param request DeleteDentryRequest
     * @param headers DeleteDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDentryResponse
     */
    public DeleteDentryResponse deleteDentryWithOptions(String spaceId, String dentryId, DeleteDentryRequest request, DeleteDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.toRecycleBin)) {
            query.put("toRecycleBin", request.toRecycleBin);
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
            new TeaPair("action", "DeleteDentry"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDentryResponse());
    }

    /**
     * @summary 删除文件或文件夹
     *
     * @param request DeleteDentryRequest
     * @return DeleteDentryResponse
     */
    public DeleteDentryResponse deleteDentry(String spaceId, String dentryId, DeleteDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDentryHeaders headers = new DeleteDentryHeaders();
        return this.deleteDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 删除文件上的App属性值
     *
     * @param request DeleteDentryAppPropertiesRequest
     * @param headers DeleteDentryAppPropertiesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteDentryAppPropertiesResponse
     */
    public DeleteDentryAppPropertiesResponse deleteDentryAppPropertiesWithOptions(String spaceId, String dentryId, DeleteDentryAppPropertiesRequest request, DeleteDentryAppPropertiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.propertyNames)) {
            body.put("propertyNames", request.propertyNames);
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
            new TeaPair("action", "DeleteDentryAppProperties"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties/remove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteDentryAppPropertiesResponse());
    }

    /**
     * @summary 删除文件上的App属性值
     *
     * @param request DeleteDentryAppPropertiesRequest
     * @return DeleteDentryAppPropertiesResponse
     */
    public DeleteDentryAppPropertiesResponse deleteDentryAppProperties(String spaceId, String dentryId, DeleteDentryAppPropertiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteDentryAppPropertiesHeaders headers = new DeleteDentryAppPropertiesHeaders();
        return this.deleteDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 删除权限
     *
     * @param request DeletePermissionRequest
     * @param headers DeletePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeletePermissionResponse
     */
    public DeletePermissionResponse deletePermissionWithOptions(String spaceId, String dentryId, DeletePermissionRequest request, DeletePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/remove"),
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
    public DeletePermissionResponse deletePermission(String spaceId, String dentryId, DeletePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeletePermissionHeaders headers = new DeletePermissionHeaders();
        return this.deletePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
     *
     * @param request DeleteRecycleItemRequest
     * @param headers DeleteRecycleItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRecycleItemResponse
     */
    public DeleteRecycleItemResponse deleteRecycleItemWithOptions(String recycleBinId, String recycleItemId, DeleteRecycleItemRequest request, DeleteRecycleItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteRecycleItem"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRecycleItemResponse());
    }

    /**
     * @summary 删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
     *
     * @param request DeleteRecycleItemRequest
     * @return DeleteRecycleItemResponse
     */
    public DeleteRecycleItemResponse deleteRecycleItem(String recycleBinId, String recycleItemId, DeleteRecycleItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRecycleItemHeaders headers = new DeleteRecycleItemHeaders();
        return this.deleteRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
    }

    /**
     * @summary 批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
     *
     * @param request DeleteRecycleItemsRequest
     * @param headers DeleteRecycleItemsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRecycleItemsResponse
     */
    public DeleteRecycleItemsResponse deleteRecycleItemsWithOptions(String recycleBinId, DeleteRecycleItemsRequest request, DeleteRecycleItemsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleItemIds)) {
            body.put("recycleItemIds", request.recycleItemIds);
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
            new TeaPair("action", "DeleteRecycleItems"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRemove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRecycleItemsResponse());
    }

    /**
     * @summary 批量删除回收项, 删除之后该记录从回收站删除, 后续文件就无法恢复了
     *
     * @param request DeleteRecycleItemsRequest
     * @return DeleteRecycleItemsResponse
     */
    public DeleteRecycleItemsResponse deleteRecycleItems(String recycleBinId, DeleteRecycleItemsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRecycleItemsHeaders headers = new DeleteRecycleItemsHeaders();
        return this.deleteRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
    }

    /**
     * @summary 获取开放平台应用在企业存储中的相关应用信息
     *
     * @param request GetCurrentAppRequest
     * @param headers GetCurrentAppHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetCurrentAppResponse
     */
    public GetCurrentAppResponse getCurrentAppWithOptions(GetCurrentAppRequest request, GetCurrentAppHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetCurrentApp"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/currentApps/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetCurrentAppResponse());
    }

    /**
     * @summary 获取开放平台应用在企业存储中的相关应用信息
     *
     * @param request GetCurrentAppRequest
     * @return GetCurrentAppResponse
     */
    public GetCurrentAppResponse getCurrentApp(GetCurrentAppRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetCurrentAppHeaders headers = new GetCurrentAppHeaders();
        return this.getCurrentAppWithOptions(request, headers, runtime);
    }

    /**
     * @summary 批量获取文件(夹)信息
     *
     * @param request GetDentriesRequest
     * @param headers GetDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDentriesResponse
     */
    public GetDentriesResponse getDentriesWithOptions(String spaceId, GetDentriesRequest request, GetDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryIds)) {
            body.put("dentryIds", request.dentryIds);
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
            new TeaPair("action", "GetDentries"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDentriesResponse());
    }

    /**
     * @summary 批量获取文件(夹)信息
     *
     * @param request GetDentriesRequest
     * @return GetDentriesResponse
     */
    public GetDentriesResponse getDentries(String spaceId, GetDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDentriesHeaders headers = new GetDentriesHeaders();
        return this.getDentriesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取文件(夹)信息
     *
     * @param request GetDentryRequest
     * @param headers GetDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDentryResponse
     */
    public GetDentryResponse getDentryWithOptions(String spaceId, String dentryId, GetDentryRequest request, GetDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDentry"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDentryResponse());
    }

    /**
     * @summary 获取文件(夹)信息
     *
     * @param request GetDentryRequest
     * @return GetDentryResponse
     */
    public GetDentryResponse getDentry(String spaceId, String dentryId, GetDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDentryHeaders headers = new GetDentryHeaders();
        return this.getDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 获取文件打开链接
     *
     * @param request GetDentryOpenInfoRequest
     * @param headers GetDentryOpenInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDentryOpenInfoResponse
     */
    public GetDentryOpenInfoResponse getDentryOpenInfoWithOptions(String spaceId, String dentryId, GetDentryOpenInfoRequest request, GetDentryOpenInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetDentryOpenInfo"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/openInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDentryOpenInfoResponse());
    }

    /**
     * @summary 获取文件打开链接
     *
     * @param request GetDentryOpenInfoRequest
     * @return GetDentryOpenInfoResponse
     */
    public GetDentryOpenInfoResponse getDentryOpenInfo(String spaceId, String dentryId, GetDentryOpenInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDentryOpenInfoHeaders headers = new GetDentryOpenInfoHeaders();
        return this.getDentryOpenInfoWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 批量获取文件缩略图
     *
     * @param request GetDentryThumbnailsRequest
     * @param headers GetDentryThumbnailsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDentryThumbnailsResponse
     */
    public GetDentryThumbnailsResponse getDentryThumbnailsWithOptions(String spaceId, GetDentryThumbnailsRequest request, GetDentryThumbnailsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryIds)) {
            body.put("dentryIds", request.dentryIds);
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
            new TeaPair("action", "GetDentryThumbnails"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/thumbnails/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDentryThumbnailsResponse());
    }

    /**
     * @summary 批量获取文件缩略图
     *
     * @param request GetDentryThumbnailsRequest
     * @return GetDentryThumbnailsResponse
     */
    public GetDentryThumbnailsResponse getDentryThumbnails(String spaceId, GetDentryThumbnailsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDentryThumbnailsHeaders headers = new GetDentryThumbnailsHeaders();
        return this.getDentryThumbnailsWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取文件下载信息
     *
     * @param request GetFileDownloadInfoRequest
     * @param headers GetFileDownloadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileDownloadInfoResponse
     */
    public GetFileDownloadInfoResponse getFileDownloadInfoWithOptions(String spaceId, String dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFileDownloadInfo"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileDownloadInfoResponse());
    }

    /**
     * @summary 获取文件下载信息
     *
     * @param request GetFileDownloadInfoRequest
     * @return GetFileDownloadInfoResponse
     */
    public GetFileDownloadInfoResponse getFileDownloadInfo(String spaceId, String dentryId, GetFileDownloadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
        return this.getFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 获取文件上传信息
     *
     * @param request GetFileUploadInfoRequest
     * @param headers GetFileUploadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileUploadInfoResponse
     */
    public GetFileUploadInfoResponse getFileUploadInfoWithOptions(String spaceId, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.multipart)) {
            body.put("multipart", request.multipart);
        }

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
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/files/uploadInfos/query"),
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
    public GetFileUploadInfoResponse getFileUploadInfo(String spaceId, GetFileUploadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
        return this.getFileUploadInfoWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取文件上传信息(分片上传)
     *
     * @param request GetMultipartFileUploadInfosRequest
     * @param headers GetMultipartFileUploadInfosHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMultipartFileUploadInfosResponse
     */
    public GetMultipartFileUploadInfosResponse getMultipartFileUploadInfosWithOptions(GetMultipartFileUploadInfosRequest request, GetMultipartFileUploadInfosHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.partNumbers)) {
            body.put("partNumbers", request.partNumbers);
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
            new TeaPair("action", "GetMultipartFileUploadInfos"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/files/multiPartUploadInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMultipartFileUploadInfosResponse());
    }

    /**
     * @summary 获取文件上传信息(分片上传)
     *
     * @param request GetMultipartFileUploadInfosRequest
     * @return GetMultipartFileUploadInfosResponse
     */
    public GetMultipartFileUploadInfosResponse getMultipartFileUploadInfos(GetMultipartFileUploadInfosRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMultipartFileUploadInfosHeaders headers = new GetMultipartFileUploadInfosHeaders();
        return this.getMultipartFileUploadInfosWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取企业存储中企业维度的信息
     *
     * @param request GetOrgRequest
     * @param headers GetOrgHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetOrgResponse
     */
    public GetOrgResponse getOrgWithOptions(String corpId, GetOrgRequest request, GetOrgHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetOrg"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/orgs/" + corpId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetOrgResponse());
    }

    /**
     * @summary 获取企业存储中企业维度的信息
     *
     * @param request GetOrgRequest
     * @return GetOrgResponse
     */
    public GetOrgResponse getOrg(String corpId, GetOrgRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetOrgHeaders headers = new GetOrgHeaders();
        return this.getOrgWithOptions(corpId, request, headers, runtime);
    }

    /**
     * @summary 获取回收站信息
     *
     * @param request GetRecycleBinRequest
     * @param headers GetRecycleBinHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRecycleBinResponse
     */
    public GetRecycleBinResponse getRecycleBinWithOptions(GetRecycleBinRequest request, GetRecycleBinHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleBinScope)) {
            query.put("recycleBinScope", request.recycleBinScope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeId)) {
            query.put("scopeId", request.scopeId);
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
            new TeaPair("action", "GetRecycleBin"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRecycleBinResponse());
    }

    /**
     * @summary 获取回收站信息
     *
     * @param request GetRecycleBinRequest
     * @return GetRecycleBinResponse
     */
    public GetRecycleBinResponse getRecycleBin(GetRecycleBinRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRecycleBinHeaders headers = new GetRecycleBinHeaders();
        return this.getRecycleBinWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取回收项详情
     *
     * @param request GetRecycleItemRequest
     * @param headers GetRecycleItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetRecycleItemResponse
     */
    public GetRecycleItemResponse getRecycleItemWithOptions(String recycleBinId, String recycleItemId, GetRecycleItemRequest request, GetRecycleItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetRecycleItem"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetRecycleItemResponse());
    }

    /**
     * @summary 获取回收项详情
     *
     * @param request GetRecycleItemRequest
     * @return GetRecycleItemResponse
     */
    public GetRecycleItemResponse getRecycleItem(String recycleBinId, String recycleItemId, GetRecycleItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetRecycleItemHeaders headers = new GetRecycleItemHeaders();
        return this.getRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
    }

    /**
     * @summary 获取空间信息
     *
     * @param request GetSpaceRequest
     * @param headers GetSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetSpaceResponse
     */
    public GetSpaceResponse getSpaceWithOptions(String spaceId, GetSpaceRequest request, GetSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetSpace"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetSpaceResponse());
    }

    /**
     * @summary 获取空间信息
     *
     * @param request GetSpaceRequest
     * @return GetSpaceResponse
     */
    public GetSpaceResponse getSpace(String spaceId, GetSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetSpaceHeaders headers = new GetSpaceHeaders();
        return this.getSpaceWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取异步任务信息
     *
     * @param request GetTaskRequest
     * @param headers GetTaskHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetTaskResponse
     */
    public GetTaskResponse getTaskWithOptions(String taskId, GetTaskRequest request, GetTaskHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetTask"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/tasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetTaskResponse());
    }

    /**
     * @summary 获取异步任务信息
     *
     * @param request GetTaskRequest
     * @return GetTaskResponse
     */
    public GetTaskResponse getTask(String taskId, GetTaskRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetTaskHeaders headers = new GetTaskHeaders();
        return this.getTaskWithOptions(taskId, request, headers, runtime);
    }

    /**
     * @summary 初始化文件分片上传
     *
     * @param request InitMultipartFileUploadRequest
     * @param headers InitMultipartFileUploadHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InitMultipartFileUploadResponse
     */
    public InitMultipartFileUploadResponse initMultipartFileUploadWithOptions(String spaceId, InitMultipartFileUploadRequest request, InitMultipartFileUploadHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "InitMultipartFileUpload"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/files/multiPartUploadInfos/init"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InitMultipartFileUploadResponse());
    }

    /**
     * @summary 初始化文件分片上传
     *
     * @param request InitMultipartFileUploadRequest
     * @return InitMultipartFileUploadResponse
     */
    public InitMultipartFileUploadResponse initMultipartFileUpload(String spaceId, InitMultipartFileUploadRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InitMultipartFileUploadHeaders headers = new InitMultipartFileUploadHeaders();
        return this.initMultipartFileUploadWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取文件列表
     *
     * @param request ListAllDentriesRequest
     * @param headers ListAllDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListAllDentriesResponse
     */
    public ListAllDentriesResponse listAllDentriesWithOptions(String spaceId, ListAllDentriesRequest request, ListAllDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListAllDentries"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/listAll"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListAllDentriesResponse());
    }

    /**
     * @summary 获取文件列表
     *
     * @param request ListAllDentriesRequest
     * @return ListAllDentriesResponse
     */
    public ListAllDentriesResponse listAllDentries(String spaceId, ListAllDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListAllDentriesHeaders headers = new ListAllDentriesHeaders();
        return this.listAllDentriesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取文件列表
     *
     * @param request ListDentriesRequest
     * @param headers ListDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListDentriesResponse
     */
    public ListDentriesResponse listDentriesWithOptions(String spaceId, ListDentriesRequest request, ListDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            query.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderBy)) {
            query.put("orderBy", request.orderBy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            query.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withThumbnail)) {
            query.put("withThumbnail", request.withThumbnail);
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
            new TeaPair("action", "ListDentries"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListDentriesResponse());
    }

    /**
     * @summary 获取文件列表
     *
     * @param request ListDentriesRequest
     * @return ListDentriesResponse
     */
    public ListDentriesResponse listDentries(String spaceId, ListDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDentriesHeaders headers = new ListDentriesHeaders();
        return this.listDentriesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 获取文件历史版本
     *
     * @param request ListDentryVersionsRequest
     * @param headers ListDentryVersionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListDentryVersionsResponse
     */
    public ListDentryVersionsResponse listDentryVersionsWithOptions(String spaceId, String dentryId, ListDentryVersionsRequest request, ListDentryVersionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
            new TeaPair("action", "ListDentryVersions"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListDentryVersionsResponse());
    }

    /**
     * @summary 获取文件历史版本
     *
     * @param request ListDentryVersionsRequest
     * @return ListDentryVersionsResponse
     */
    public ListDentryVersionsResponse listDentryVersions(String spaceId, String dentryId, ListDentryVersionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListDentryVersionsHeaders headers = new ListDentryVersionsHeaders();
        return this.listDentryVersionsWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 获取权限列表
     *
     * @param request ListPermissionsRequest
     * @param headers ListPermissionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListPermissionsResponse
     */
    public ListPermissionsResponse listPermissionsWithOptions(String spaceId, String dentryId, ListPermissionsRequest request, ListPermissionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/query"),
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
    public ListPermissionsResponse listPermissions(String spaceId, String dentryId, ListPermissionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPermissionsHeaders headers = new ListPermissionsHeaders();
        return this.listPermissionsWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 获取回收项列表
     *
     * @param request ListRecycleItemsRequest
     * @param headers ListRecycleItemsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRecycleItemsResponse
     */
    public ListRecycleItemsResponse listRecycleItemsWithOptions(String recycleBinId, ListRecycleItemsRequest request, ListRecycleItemsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
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
            new TeaPair("action", "ListRecycleItems"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRecycleItemsResponse());
    }

    /**
     * @summary 获取回收项列表
     *
     * @param request ListRecycleItemsRequest
     * @return ListRecycleItemsResponse
     */
    public ListRecycleItemsResponse listRecycleItems(String recycleBinId, ListRecycleItemsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRecycleItemsHeaders headers = new ListRecycleItemsHeaders();
        return this.listRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
    }

    /**
     * @summary 批量移动文件或文件夹
     *
     * @param request MoveDentriesRequest
     * @param headers MoveDentriesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MoveDentriesResponse
     */
    public MoveDentriesResponse moveDentriesWithOptions(String spaceId, MoveDentriesRequest request, MoveDentriesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dentryIds)) {
            body.put("dentryIds", request.dentryIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetFolderId)) {
            body.put("targetFolderId", request.targetFolderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
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
            new TeaPair("action", "MoveDentries"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/batchMove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MoveDentriesResponse());
    }

    /**
     * @summary 批量移动文件或文件夹
     *
     * @param request MoveDentriesRequest
     * @return MoveDentriesResponse
     */
    public MoveDentriesResponse moveDentries(String spaceId, MoveDentriesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MoveDentriesHeaders headers = new MoveDentriesHeaders();
        return this.moveDentriesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * @summary 移动文件或文件夹
     *
     * @param request MoveDentryRequest
     * @param headers MoveDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MoveDentryResponse
     */
    public MoveDentryResponse moveDentryWithOptions(String spaceId, String dentryId, MoveDentryRequest request, MoveDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetFolderId)) {
            body.put("targetFolderId", request.targetFolderId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
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
            new TeaPair("action", "MoveDentry"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/move"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MoveDentryResponse());
    }

    /**
     * @summary 移动文件或文件夹
     *
     * @param request MoveDentryRequest
     * @return MoveDentryResponse
     */
    public MoveDentryResponse moveDentry(String spaceId, String dentryId, MoveDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MoveDentryHeaders headers = new MoveDentryHeaders();
        return this.moveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 注册文件预览或编辑链接
     *
     * @param request RegisterOpenInfoRequest
     * @param headers RegisterOpenInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RegisterOpenInfoResponse
     */
    public RegisterOpenInfoResponse registerOpenInfoWithOptions(String spaceId, String dentryId, RegisterOpenInfoRequest request, RegisterOpenInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.openInfos)) {
            body.put("openInfos", request.openInfos);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.provider)) {
            body.put("provider", request.provider);
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
            new TeaPair("action", "RegisterOpenInfo"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/openInfos/register"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RegisterOpenInfoResponse());
    }

    /**
     * @summary 注册文件预览或编辑链接
     *
     * @param request RegisterOpenInfoRequest
     * @return RegisterOpenInfoResponse
     */
    public RegisterOpenInfoResponse registerOpenInfo(String spaceId, String dentryId, RegisterOpenInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RegisterOpenInfoHeaders headers = new RegisterOpenInfoHeaders();
        return this.registerOpenInfoWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 重命名文件或文件夹
     *
     * @param request RenameDentryRequest
     * @param headers RenameDentryHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RenameDentryResponse
     */
    public RenameDentryResponse renameDentryWithOptions(String spaceId, String dentryId, RenameDentryRequest request, RenameDentryHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.newName)) {
            body.put("newName", request.newName);
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
            new TeaPair("action", "RenameDentry"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/rename"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RenameDentryResponse());
    }

    /**
     * @summary 重命名文件或文件夹
     *
     * @param request RenameDentryRequest
     * @return RenameDentryResponse
     */
    public RenameDentryResponse renameDentry(String spaceId, String dentryId, RenameDentryRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RenameDentryHeaders headers = new RenameDentryHeaders();
        return this.renameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 还原回收站中的回收项
     *
     * @param request RestoreRecycleItemRequest
     * @param headers RestoreRecycleItemHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RestoreRecycleItemResponse
     */
    public RestoreRecycleItemResponse restoreRecycleItemWithOptions(String recycleBinId, String recycleItemId, RestoreRecycleItemRequest request, RestoreRecycleItemHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "RestoreRecycleItem"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "/restore"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RestoreRecycleItemResponse());
    }

    /**
     * @summary 还原回收站中的回收项
     *
     * @param request RestoreRecycleItemRequest
     * @return RestoreRecycleItemResponse
     */
    public RestoreRecycleItemResponse restoreRecycleItem(String recycleBinId, String recycleItemId, RestoreRecycleItemRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RestoreRecycleItemHeaders headers = new RestoreRecycleItemHeaders();
        return this.restoreRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
    }

    /**
     * @summary 批量还原回收站中的回收项
     *
     * @param request RestoreRecycleItemsRequest
     * @param headers RestoreRecycleItemsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RestoreRecycleItemsResponse
     */
    public RestoreRecycleItemsResponse restoreRecycleItemsWithOptions(String recycleBinId, RestoreRecycleItemsRequest request, RestoreRecycleItemsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.option)) {
            body.put("option", request.option);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recycleItemIds)) {
            body.put("recycleItemIds", request.recycleItemIds);
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
            new TeaPair("action", "RestoreRecycleItems"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRestore"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RestoreRecycleItemsResponse());
    }

    /**
     * @summary 批量还原回收站中的回收项
     *
     * @param request RestoreRecycleItemsRequest
     * @return RestoreRecycleItemsResponse
     */
    public RestoreRecycleItemsResponse restoreRecycleItems(String recycleBinId, RestoreRecycleItemsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RestoreRecycleItemsHeaders headers = new RestoreRecycleItemsHeaders();
        return this.restoreRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
    }

    /**
     * @summary 恢复文件历史版本
     *
     * @param request RevertDentryVersionRequest
     * @param headers RevertDentryVersionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RevertDentryVersionResponse
     */
    public RevertDentryVersionResponse revertDentryVersionWithOptions(String spaceId, String dentryId, String version, RevertDentryVersionRequest request, RevertDentryVersionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "RevertDentryVersion"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions/" + version + "/revert"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RevertDentryVersionResponse());
    }

    /**
     * @summary 恢复文件历史版本
     *
     * @param request RevertDentryVersionRequest
     * @return RevertDentryVersionResponse
     */
    public RevertDentryVersionResponse revertDentryVersion(String spaceId, String dentryId, String version, RevertDentryVersionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RevertDentryVersionHeaders headers = new RevertDentryVersionHeaders();
        return this.revertDentryVersionWithOptions(spaceId, dentryId, version, request, headers, runtime);
    }

    /**
     * @summary 订阅文件变更事件
     *
     * @param request SubscribeEventRequest
     * @param headers SubscribeEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return SubscribeEventResponse
     */
    public SubscribeEventResponse subscribeEventWithOptions(SubscribeEventRequest request, SubscribeEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeId)) {
            body.put("scopeId", request.scopeId);
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
            new TeaPair("action", "SubscribeEvent"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/events/subscribe"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new SubscribeEventResponse());
    }

    /**
     * @summary 订阅文件变更事件
     *
     * @param request SubscribeEventRequest
     * @return SubscribeEventResponse
     */
    public SubscribeEventResponse subscribeEvent(SubscribeEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        SubscribeEventHeaders headers = new SubscribeEventHeaders();
        return this.subscribeEventWithOptions(request, headers, runtime);
    }

    /**
     * @summary 取消订阅文件变更事件
     *
     * @param request UnsubscribeEventRequest
     * @param headers UnsubscribeEventHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UnsubscribeEventResponse
     */
    public UnsubscribeEventResponse unsubscribeEventWithOptions(UnsubscribeEventRequest request, UnsubscribeEventHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.scope)) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeId)) {
            body.put("scopeId", request.scopeId);
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
            new TeaPair("action", "UnsubscribeEvent"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/events/unsubscribe"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UnsubscribeEventResponse());
    }

    /**
     * @summary 取消订阅文件变更事件
     *
     * @param request UnsubscribeEventRequest
     * @return UnsubscribeEventResponse
     */
    public UnsubscribeEventResponse unsubscribeEvent(UnsubscribeEventRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UnsubscribeEventHeaders headers = new UnsubscribeEventHeaders();
        return this.unsubscribeEventWithOptions(request, headers, runtime);
    }

    /**
     * @summary 修改文件上的App属性值
     *
     * @param request UpdateDentryAppPropertiesRequest
     * @param headers UpdateDentryAppPropertiesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateDentryAppPropertiesResponse
     */
    public UpdateDentryAppPropertiesResponse updateDentryAppPropertiesWithOptions(String spaceId, String dentryId, UpdateDentryAppPropertiesRequest request, UpdateDentryAppPropertiesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appProperties)) {
            body.put("appProperties", request.appProperties);
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
            new TeaPair("action", "UpdateDentryAppProperties"),
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateDentryAppPropertiesResponse());
    }

    /**
     * @summary 修改文件上的App属性值
     *
     * @param request UpdateDentryAppPropertiesRequest
     * @return UpdateDentryAppPropertiesResponse
     */
    public UpdateDentryAppPropertiesResponse updateDentryAppProperties(String spaceId, String dentryId, UpdateDentryAppPropertiesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateDentryAppPropertiesHeaders headers = new UpdateDentryAppPropertiesHeaders();
        return this.updateDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    /**
     * @summary 修改权限
     *
     * @param request UpdatePermissionRequest
     * @param headers UpdatePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdatePermissionResponse
     */
    public UpdatePermissionResponse updatePermissionWithOptions(String spaceId, String dentryId, UpdatePermissionRequest request, UpdatePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("version", "storage_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions"),
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
    public UpdatePermissionResponse updatePermission(String spaceId, String dentryId, UpdatePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
        return this.updatePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
    }
}
