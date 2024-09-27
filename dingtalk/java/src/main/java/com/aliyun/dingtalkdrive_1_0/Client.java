// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdrive_1_0.models.*;

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
     * <p>新建自定义空间</p>
     * 
     * @param request AddCustomSpaceRequest
     * @param headers AddCustomSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddCustomSpaceResponse
     */
    public AddCustomSpaceResponse addCustomSpaceWithOptions(AddCustomSpaceRequest request, AddCustomSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizType)) {
            body.put("bizType", request.bizType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permissionMode)) {
            body.put("permissionMode", request.permissionMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "AddCustomSpace"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/customSpaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddCustomSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新建自定义空间</p>
     * 
     * @param request AddCustomSpaceRequest
     * @return AddCustomSpaceResponse
     */
    public AddCustomSpaceResponse addCustomSpace(AddCustomSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddCustomSpaceHeaders headers = new AddCustomSpaceHeaders();
        return this.addCustomSpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加文件</p>
     * 
     * @param request AddFileRequest
     * @param headers AddFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddFileResponse
     */
    public AddFileResponse addFileWithOptions(String spaceId, AddFileRequest request, AddFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            body.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileType)) {
            body.put("fileType", request.fileType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "AddFile"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加文件</p>
     * 
     * @param request AddFileRequest
     * @return AddFileResponse
     */
    public AddFileResponse addFile(String spaceId, AddFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddFileHeaders headers = new AddFileHeaders();
        return this.addFileWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加权限</p>
     * 
     * @param request AddPermissionRequest
     * @param headers AddPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddPermissionResponse
     */
    public AddPermissionResponse addPermissionWithOptions(String spaceId, String fileId, AddPermissionRequest request, AddPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "AddPermission"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddPermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加权限</p>
     * 
     * @param request AddPermissionRequest
     * @return AddPermissionResponse
     */
    public AddPermissionResponse addPermission(String spaceId, String fileId, AddPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddPermissionHeaders headers = new AddPermissionHeaders();
        return this.addPermissionWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>新建空间</p>
     * 
     * @param request AddSpaceRequest
     * @param headers AddSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddSpaceResponse
     */
    public AddSpaceResponse addSpaceWithOptions(AddSpaceRequest request, AddSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "AddSpace"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>新建空间</p>
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
     * <b>summary</b> : 
     * <p>清空回收站文件</p>
     * 
     * @param request ClearRecycleFilesRequest
     * @param headers ClearRecycleFilesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ClearRecycleFilesResponse
     */
    public ClearRecycleFilesResponse clearRecycleFilesWithOptions(ClearRecycleFilesRequest request, ClearRecycleFilesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            body.put("recycleType", request.recycleType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "ClearRecycleFiles"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/recycleItems/clear"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ClearRecycleFilesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>清空回收站文件</p>
     * 
     * @param request ClearRecycleFilesRequest
     * @return ClearRecycleFilesResponse
     */
    public ClearRecycleFilesResponse clearRecycleFiles(ClearRecycleFilesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
        return this.clearRecycleFilesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>拷贝文件</p>
     * 
     * @param request CopyFileRequest
     * @param headers CopyFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return CopyFileResponse
     */
    public CopyFileResponse copyFileWithOptions(String spaceId, String fileId, CopyFileRequest request, CopyFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            body.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetParentId)) {
            body.put("targetParentId", request.targetParentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "CopyFile"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/copy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new CopyFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>拷贝文件</p>
     * 
     * @param request CopyFileRequest
     * @return CopyFileResponse
     */
    public CopyFileResponse copyFile(String spaceId, String fileId, CopyFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        CopyFileHeaders headers = new CopyFileHeaders();
        return this.copyFileWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除文件</p>
     * 
     * @param request DeleteFileRequest
     * @param headers DeleteFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteFileResponse
     */
    public DeleteFileResponse deleteFileWithOptions(String spaceId, String fileId, DeleteFileRequest request, DeleteFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deletePolicy)) {
            query.put("deletePolicy", request.deletePolicy);
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
            new TeaPair("action", "DeleteFile"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除文件</p>
     * 
     * @param request DeleteFileRequest
     * @return DeleteFileResponse
     */
    public DeleteFileResponse deleteFile(String spaceId, String fileId, DeleteFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteFileHeaders headers = new DeleteFileHeaders();
        return this.deleteFileWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除文件（夹）</p>
     * 
     * @param request DeleteFilesRequest
     * @param headers DeleteFilesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteFilesResponse
     */
    public DeleteFilesResponse deleteFilesWithOptions(String spaceId, DeleteFilesRequest request, DeleteFilesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.deletePolicy)) {
            body.put("deletePolicy", request.deletePolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileIds)) {
            body.put("fileIds", request.fileIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "DeleteFiles"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/batchDelete"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteFilesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量删除文件（夹）</p>
     * 
     * @param request DeleteFilesRequest
     * @return DeleteFilesResponse
     */
    public DeleteFilesResponse deleteFiles(String spaceId, DeleteFilesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteFilesHeaders headers = new DeleteFilesHeaders();
        return this.deleteFilesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除权限</p>
     * 
     * @param request DeletePermissionRequest
     * @param headers DeletePermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeletePermissionResponse
     */
    public DeletePermissionResponse deletePermissionWithOptions(String spaceId, String fileId, DeletePermissionRequest request, DeletePermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "DeletePermission"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions/delete"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeletePermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除权限</p>
     * 
     * @param request DeletePermissionRequest
     * @return DeletePermissionResponse
     */
    public DeletePermissionResponse deletePermission(String spaceId, String fileId, DeletePermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeletePermissionHeaders headers = new DeletePermissionHeaders();
        return this.deletePermissionWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>彻底删除回收站文件</p>
     * 
     * @param request DeleteRecycleFilesRequest
     * @param headers DeleteRecycleFilesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteRecycleFilesResponse
     */
    public DeleteRecycleFilesResponse deleteRecycleFilesWithOptions(DeleteRecycleFilesRequest request, DeleteRecycleFilesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleItemIdList)) {
            body.put("recycleItemIdList", request.recycleItemIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            body.put("recycleType", request.recycleType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "DeleteRecycleFiles"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/recycleItems/delete"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteRecycleFilesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>彻底删除回收站文件</p>
     * 
     * @param request DeleteRecycleFilesRequest
     * @return DeleteRecycleFilesResponse
     */
    public DeleteRecycleFilesResponse deleteRecycleFiles(DeleteRecycleFilesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
        return this.deleteRecycleFilesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>删除空间</p>
     * 
     * @param request DeleteSpaceRequest
     * @param headers DeleteSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return DeleteSpaceResponse
     */
    public DeleteSpaceResponse deleteSpaceWithOptions(String spaceId, DeleteSpaceRequest request, DeleteSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "DeleteSpace"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + ""),
            new TeaPair("method", "DELETE"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new DeleteSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>删除空间</p>
     * 
     * @param request DeleteSpaceRequest
     * @return DeleteSpaceResponse
     */
    public DeleteSpaceResponse deleteSpace(String spaceId, DeleteSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
        return this.deleteSpaceWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取异步任务信息</p>
     * 
     * @param request GetAsyncTaskInfoRequest
     * @param headers GetAsyncTaskInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetAsyncTaskInfoResponse
     */
    public GetAsyncTaskInfoResponse getAsyncTaskInfoWithOptions(String taskId, GetAsyncTaskInfoRequest request, GetAsyncTaskInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetAsyncTaskInfo"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/tasks/" + taskId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetAsyncTaskInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取异步任务信息</p>
     * 
     * @param request GetAsyncTaskInfoRequest
     * @return GetAsyncTaskInfoResponse
     */
    public GetAsyncTaskInfoResponse getAsyncTaskInfo(String taskId, GetAsyncTaskInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetAsyncTaskInfoHeaders headers = new GetAsyncTaskInfoHeaders();
        return this.getAsyncTaskInfoWithOptions(taskId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取下载信息</p>
     * 
     * @param request GetDownloadInfoRequest
     * @param headers GetDownloadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDownloadInfoResponse
     */
    public GetDownloadInfoResponse getDownloadInfoWithOptions(String spaceId, String fileId, GetDownloadInfoRequest request, GetDownloadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withInternalResourceUrl)) {
            query.put("withInternalResourceUrl", request.withInternalResourceUrl);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withRegion)) {
            query.put("withRegion", request.withRegion);
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
            new TeaPair("action", "GetDownloadInfo"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDownloadInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取下载信息</p>
     * 
     * @param request GetDownloadInfoRequest
     * @return GetDownloadInfoResponse
     */
    public GetDownloadInfoResponse getDownloadInfo(String spaceId, String fileId, GetDownloadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
        return this.getDownloadInfoWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件信息</p>
     * 
     * @param request GetFileInfoRequest
     * @param headers GetFileInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetFileInfoResponse
     */
    public GetFileInfoResponse getFileInfoWithOptions(String spaceId, String fileId, GetFileInfoRequest request, GetFileInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetFileInfo"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetFileInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件信息</p>
     * 
     * @param request GetFileInfoRequest
     * @return GetFileInfoResponse
     */
    public GetFileInfoResponse getFileInfo(String spaceId, String fileId, GetFileInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetFileInfoHeaders headers = new GetFileInfoHeaders();
        return this.getFileInfoWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取我的工作空间信息</p>
     * 
     * @param request GetMySpaceInfoRequest
     * @param headers GetMySpaceInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetMySpaceInfoResponse
     */
    public GetMySpaceInfoResponse getMySpaceInfoWithOptions(GetMySpaceInfoRequest request, GetMySpaceInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetMySpaceInfo"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/mySpaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetMySpaceInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取我的工作空间信息</p>
     * 
     * @param request GetMySpaceInfoRequest
     * @return GetMySpaceInfoResponse
     */
    public GetMySpaceInfoResponse getMySpaceInfo(GetMySpaceInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetMySpaceInfoHeaders headers = new GetMySpaceInfoHeaders();
        return this.getMySpaceInfoWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取预览信息</p>
     * 
     * @param request GetPreviewInfoRequest
     * @param headers GetPreviewInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPreviewInfoResponse
     */
    public GetPreviewInfoResponse getPreviewInfoWithOptions(String spaceId, String fileId, GetPreviewInfoRequest request, GetPreviewInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.version)) {
            query.put("version", request.version);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.watermark)) {
            query.put("watermark", request.watermark);
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
            new TeaPair("action", "GetPreviewInfo"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/previewInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPreviewInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取预览信息</p>
     * 
     * @param request GetPreviewInfoRequest
     * @return GetPreviewInfoResponse
     */
    public GetPreviewInfoResponse getPreviewInfo(String spaceId, String fileId, GetPreviewInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPreviewInfoHeaders headers = new GetPreviewInfoHeaders();
        return this.getPreviewInfoWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限点信息</p>
     * 
     * @param request GetPrivilegeInfoRequest
     * @param headers GetPrivilegeInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPrivilegeInfoResponse
     */
    public GetPrivilegeInfoResponse getPrivilegeInfoWithOptions(String spaceId, String fileId, GetPrivilegeInfoRequest request, GetPrivilegeInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "GetPrivilegeInfo"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/privileges"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPrivilegeInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限点信息</p>
     * 
     * @param request GetPrivilegeInfoRequest
     * @return GetPrivilegeInfoResponse
     */
    public GetPrivilegeInfoResponse getPrivilegeInfo(String spaceId, String fileId, GetPrivilegeInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPrivilegeInfoHeaders headers = new GetPrivilegeInfoHeaders();
        return this.getPrivilegeInfoWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取容量信息列表</p>
     * 
     * @param request GetQuotaInfosRequest
     * @param headers GetQuotaInfosHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetQuotaInfosResponse
     */
    public GetQuotaInfosResponse getQuotaInfosWithOptions(GetQuotaInfosRequest request, GetQuotaInfosHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.identifiers)) {
            body.put("identifiers", request.identifiers);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "GetQuotaInfos"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/quotaInfos/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetQuotaInfosResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取容量信息列表</p>
     * 
     * @param request GetQuotaInfosRequest
     * @return GetQuotaInfosResponse
     */
    public GetQuotaInfosResponse getQuotaInfos(GetQuotaInfosRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetQuotaInfosHeaders headers = new GetQuotaInfosHeaders();
        return this.getQuotaInfosWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取上传信息</p>
     * 
     * @param request GetUploadInfoRequest
     * @param headers GetUploadInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetUploadInfoResponse
     */
    public GetUploadInfoResponse getUploadInfoWithOptions(String spaceId, String parentId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            query.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.callerRegion)) {
            query.put("callerRegion", request.callerRegion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            query.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileSize)) {
            query.put("fileSize", request.fileSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.md5)) {
            query.put("md5", request.md5);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withInternalEndPoint)) {
            query.put("withInternalEndPoint", request.withInternalEndPoint);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withRegion)) {
            query.put("withRegion", request.withRegion);
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
            new TeaPair("action", "GetUploadInfo"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetUploadInfoResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取上传信息</p>
     * 
     * @param request GetUploadInfoRequest
     * @return GetUploadInfoResponse
     */
    public GetUploadInfoResponse getUploadInfo(String spaceId, String parentId, GetUploadInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
        return this.getUploadInfoWithOptions(spaceId, parentId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>添加自定义空间权限</p>
     * 
     * @param request GrantPrivilegeOfCustomSpaceRequest
     * @param headers GrantPrivilegeOfCustomSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GrantPrivilegeOfCustomSpaceResponse
     */
    public GrantPrivilegeOfCustomSpaceResponse grantPrivilegeOfCustomSpaceWithOptions(String spaceId, GrantPrivilegeOfCustomSpaceRequest request, GrantPrivilegeOfCustomSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.duration)) {
            body.put("duration", request.duration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileIds)) {
            body.put("fileIds", request.fileIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "GrantPrivilegeOfCustomSpace"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/customSpacePrivileges"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GrantPrivilegeOfCustomSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>添加自定义空间权限</p>
     * 
     * @param request GrantPrivilegeOfCustomSpaceRequest
     * @return GrantPrivilegeOfCustomSpaceResponse
     */
    public GrantPrivilegeOfCustomSpaceResponse grantPrivilegeOfCustomSpace(String spaceId, GrantPrivilegeOfCustomSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GrantPrivilegeOfCustomSpaceHeaders headers = new GrantPrivilegeOfCustomSpaceHeaders();
        return this.grantPrivilegeOfCustomSpaceWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取空间信息</p>
     * 
     * @param request InfoSpaceRequest
     * @param headers InfoSpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InfoSpaceResponse
     */
    public InfoSpaceResponse infoSpaceWithOptions(String spaceId, InfoSpaceRequest request, InfoSpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "InfoSpace"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InfoSpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取空间信息</p>
     * 
     * @param request InfoSpaceRequest
     * @return InfoSpaceResponse
     */
    public InfoSpaceResponse infoSpace(String spaceId, InfoSpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InfoSpaceHeaders headers = new InfoSpaceHeaders();
        return this.infoSpaceWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件列表</p>
     * 
     * @param request ListFilesRequest
     * @param headers ListFilesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListFilesResponse
     */
    public ListFilesResponse listFilesWithOptions(String spaceId, ListFilesRequest request, ListFilesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderType)) {
            query.put("orderType", request.orderType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            query.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.withIcon)) {
            query.put("withIcon", request.withIcon);
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
            new TeaPair("action", "ListFiles"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListFilesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取文件列表</p>
     * 
     * @param request ListFilesRequest
     * @return ListFilesResponse
     */
    public ListFilesResponse listFiles(String spaceId, ListFilesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListFilesHeaders headers = new ListFilesHeaders();
        return this.listFilesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限列表</p>
     * 
     * @param request ListPermissionsRequest
     * @param headers ListPermissionsHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListPermissionsResponse
     */
    public ListPermissionsResponse listPermissionsWithOptions(String spaceId, String fileId, ListPermissionsRequest request, ListPermissionsHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            new TeaPair("action", "ListPermissions"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListPermissionsResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取权限列表</p>
     * 
     * @param request ListPermissionsRequest
     * @return ListPermissionsResponse
     */
    public ListPermissionsResponse listPermissions(String spaceId, String fileId, ListPermissionsRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListPermissionsHeaders headers = new ListPermissionsHeaders();
        return this.listPermissionsWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取回收站文件列表</p>
     * 
     * @param request ListRecycleFilesRequest
     * @param headers ListRecycleFilesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListRecycleFilesResponse
     */
    public ListRecycleFilesResponse listRecycleFilesWithOptions(ListRecycleFilesRequest request, ListRecycleFilesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderType)) {
            query.put("orderType", request.orderType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            query.put("recycleType", request.recycleType);
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
            new TeaPair("action", "ListRecycleFiles"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/recycleItems"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListRecycleFilesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取回收站文件列表</p>
     * 
     * @param request ListRecycleFilesRequest
     * @return ListRecycleFilesResponse
     */
    public ListRecycleFilesResponse listRecycleFiles(ListRecycleFilesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
        return this.listRecycleFilesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>获取空间列表</p>
     * 
     * @param request ListSpacesRequest
     * @param headers ListSpacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListSpacesResponse
     */
    public ListSpacesResponse listSpacesWithOptions(ListSpacesRequest request, ListSpacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceType)) {
            query.put("spaceType", request.spaceType);
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
            new TeaPair("action", "ListSpaces"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListSpacesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>获取空间列表</p>
     * 
     * @param request ListSpacesRequest
     * @return ListSpacesResponse
     */
    public ListSpacesResponse listSpaces(ListSpacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListSpacesHeaders headers = new ListSpacesHeaders();
        return this.listSpacesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>管理侧购买容量</p>
     * 
     * @param request ManagementBuyQuotaRequest
     * @param headers ManagementBuyQuotaHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ManagementBuyQuotaResponse
     */
    public ManagementBuyQuotaResponse managementBuyQuotaWithOptions(ManagementBuyQuotaRequest request, ManagementBuyQuotaHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.order)) {
            body.put("order", request.order);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.token)) {
            body.put("token", request.token);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "ManagementBuyQuota"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/managements/quotas/buy"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ManagementBuyQuotaResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>管理侧购买容量</p>
     * 
     * @param request ManagementBuyQuotaRequest
     * @return ManagementBuyQuotaResponse
     */
    public ManagementBuyQuotaResponse managementBuyQuota(ManagementBuyQuotaRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ManagementBuyQuotaHeaders headers = new ManagementBuyQuotaHeaders();
        return this.managementBuyQuotaWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>管理侧获取空间列表</p>
     * 
     * @param request ManagementListSpacesRequest
     * @param headers ManagementListSpacesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ManagementListSpacesResponse
     */
    public ManagementListSpacesResponse managementListSpacesWithOptions(ManagementListSpacesRequest request, ManagementListSpacesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.spaceIds)) {
            body.put("spaceIds", request.spaceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "ManagementListSpaces"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/managements/spaces/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ManagementListSpacesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>管理侧获取空间列表</p>
     * 
     * @param request ManagementListSpacesRequest
     * @return ManagementListSpacesResponse
     */
    public ManagementListSpacesResponse managementListSpaces(ManagementListSpacesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ManagementListSpacesHeaders headers = new ManagementListSpacesHeaders();
        return this.managementListSpacesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>管理侧修改空间信息</p>
     * 
     * @param request ManagementModifySpaceRequest
     * @param headers ManagementModifySpaceHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ManagementModifySpaceResponse
     */
    public ManagementModifySpaceResponse managementModifySpaceWithOptions(ManagementModifySpaceRequest request, ManagementModifySpaceHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.quota)) {
            body.put("quota", request.quota);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceIds)) {
            body.put("spaceIds", request.spaceIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "ManagementModifySpace"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/managements/spaces"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ManagementModifySpaceResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>管理侧修改空间信息</p>
     * 
     * @param request ManagementModifySpaceRequest
     * @return ManagementModifySpaceResponse
     */
    public ManagementModifySpaceResponse managementModifySpace(ManagementModifySpaceRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ManagementModifySpaceHeaders headers = new ManagementModifySpaceHeaders();
        return this.managementModifySpaceWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>修改权限</p>
     * 
     * @param request ModifyPermissionRequest
     * @param headers ModifyPermissionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ModifyPermissionResponse
     */
    public ModifyPermissionResponse modifyPermissionWithOptions(String spaceId, String fileId, ModifyPermissionRequest request, ModifyPermissionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "ModifyPermission"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions"),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ModifyPermissionResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>修改权限</p>
     * 
     * @param request ModifyPermissionRequest
     * @return ModifyPermissionResponse
     */
    public ModifyPermissionResponse modifyPermission(String spaceId, String fileId, ModifyPermissionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ModifyPermissionHeaders headers = new ModifyPermissionHeaders();
        return this.modifyPermissionWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>移动文件</p>
     * 
     * @param request MoveFileRequest
     * @param headers MoveFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MoveFileResponse
     */
    public MoveFileResponse moveFileWithOptions(String spaceId, String fileId, MoveFileRequest request, MoveFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            body.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetParentId)) {
            body.put("targetParentId", request.targetParentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "MoveFile"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/move"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MoveFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>移动文件</p>
     * 
     * @param request MoveFileRequest
     * @return MoveFileResponse
     */
    public MoveFileResponse moveFile(String spaceId, String fileId, MoveFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MoveFileHeaders headers = new MoveFileHeaders();
        return this.moveFileWithOptions(spaceId, fileId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>批量移动文件（夹）</p>
     * 
     * @param request MoveFilesRequest
     * @param headers MoveFilesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return MoveFilesResponse
     */
    public MoveFilesResponse moveFilesWithOptions(String spaceId, MoveFilesRequest request, MoveFilesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            body.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileIds)) {
            body.put("fileIds", request.fileIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetParentId)) {
            body.put("targetParentId", request.targetParentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "MoveFiles"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/batchMove"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new MoveFilesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>批量移动文件（夹）</p>
     * 
     * @param request MoveFilesRequest
     * @return MoveFilesResponse
     */
    public MoveFilesResponse moveFiles(String spaceId, MoveFilesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        MoveFilesHeaders headers = new MoveFilesHeaders();
        return this.moveFilesWithOptions(spaceId, request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>还原回收站文件</p>
     * 
     * @param request RecoverRecycleFilesRequest
     * @param headers RecoverRecycleFilesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RecoverRecycleFilesResponse
     */
    public RecoverRecycleFilesResponse recoverRecycleFilesWithOptions(RecoverRecycleFilesRequest request, RecoverRecycleFilesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleItemIdList)) {
            body.put("recycleItemIdList", request.recycleItemIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            body.put("recycleType", request.recycleType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "RecoverRecycleFiles"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/recycleItems/recover"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "none")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RecoverRecycleFilesResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>还原回收站文件</p>
     * 
     * @param request RecoverRecycleFilesRequest
     * @return RecoverRecycleFilesResponse
     */
    public RecoverRecycleFilesResponse recoverRecycleFiles(RecoverRecycleFilesRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
        return this.recoverRecycleFilesWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>重命名文件</p>
     * 
     * @param request RenameFileRequest
     * @param headers RenameFileHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return RenameFileResponse
     */
    public RenameFileResponse renameFileWithOptions(String spaceId, String fileId, RenameFileRequest request, RenameFileHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.newFileName)) {
            body.put("newFileName", request.newFileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
            new TeaPair("action", "RenameFile"),
            new TeaPair("version", "drive_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/rename"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new RenameFileResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>重命名文件</p>
     * 
     * @param request RenameFileRequest
     * @return RenameFileResponse
     */
    public RenameFileResponse renameFile(String spaceId, String fileId, RenameFileRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        RenameFileHeaders headers = new RenameFileHeaders();
        return this.renameFileWithOptions(spaceId, fileId, request, headers, runtime);
    }
}
