// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkdrive_1_0.models.*;
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


    public AddFileResponse addFile(String spaceId, AddFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddFileHeaders headers = new AddFileHeaders();
        return this.addFileWithOptions(spaceId, request, headers, runtime);
    }

    public AddFileResponse addFileWithOptions(String spaceId, AddFileRequest request, AddFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            body.put("parentId", request.parentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileType)) {
            body.put("fileType", request.fileType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileName)) {
            body.put("fileName", request.fileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            body.put("mediaId", request.mediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            body.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("AddFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files", "json", req, runtime), new AddFileResponse());
    }

    public RecoverRecycleFilesResponse recoverRecycleFiles(RecoverRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
        return this.recoverRecycleFilesWithOptions(request, headers, runtime);
    }

    public RecoverRecycleFilesResponse recoverRecycleFilesWithOptions(RecoverRecycleFilesRequest request, RecoverRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/recover", "none", req, runtime), new RecoverRecycleFilesResponse());
    }

    public AddSpaceResponse addSpace(AddSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddSpaceHeaders headers = new AddSpaceHeaders();
        return this.addSpaceWithOptions(request, headers, runtime);
    }

    public AddSpaceResponse addSpaceWithOptions(AddSpaceRequest request, AddSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces", "json", req, runtime), new AddSpaceResponse());
    }

    public DeleteRecycleFilesResponse deleteRecycleFiles(DeleteRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
        return this.deleteRecycleFilesWithOptions(request, headers, runtime);
    }

    public DeleteRecycleFilesResponse deleteRecycleFilesWithOptions(DeleteRecycleFilesRequest request, DeleteRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/delete", "none", req, runtime), new DeleteRecycleFilesResponse());
    }

    public AddPermissionResponse addPermission(String spaceId, String fileId, AddPermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddPermissionHeaders headers = new AddPermissionHeaders();
        return this.addPermissionWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public AddPermissionResponse addPermissionWithOptions(String spaceId, String fileId, AddPermissionRequest request, AddPermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("AddPermission", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "none", req, runtime), new AddPermissionResponse());
    }

    public GetFileInfoResponse getFileInfo(String spaceId, String fileId, GetFileInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFileInfoHeaders headers = new GetFileInfoHeaders();
        return this.getFileInfoWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public GetFileInfoResponse getFileInfoWithOptions(String spaceId, String fileId, GetFileInfoRequest request, GetFileInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "", "json", req, runtime), new GetFileInfoResponse());
    }

    public InfoSpaceResponse infoSpace(String spaceId, InfoSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        InfoSpaceHeaders headers = new InfoSpaceHeaders();
        return this.infoSpaceWithOptions(spaceId, request, headers, runtime);
    }

    public InfoSpaceResponse infoSpaceWithOptions(String spaceId, InfoSpaceRequest request, InfoSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("InfoSpace", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "", "json", req, runtime), new InfoSpaceResponse());
    }

    public ListRecycleFilesResponse listRecycleFiles(ListRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
        return this.listRecycleFilesWithOptions(request, headers, runtime);
    }

    public ListRecycleFilesResponse listRecycleFilesWithOptions(ListRecycleFilesRequest request, ListRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            query.put("recycleType", request.recycleType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.maxResults)) {
            query.put("maxResults", request.maxResults);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.orderType)) {
            query.put("orderType", request.orderType);
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
        return TeaModel.toModel(this.doROARequest("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/recycleItems", "json", req, runtime), new ListRecycleFilesResponse());
    }

    public RenameFileResponse renameFile(String spaceId, String fileId, RenameFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RenameFileHeaders headers = new RenameFileHeaders();
        return this.renameFileWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public RenameFileResponse renameFileWithOptions(String spaceId, String fileId, RenameFileRequest request, RenameFileHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RenameFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/rename", "json", req, runtime), new RenameFileResponse());
    }

    public ListFilesResponse listFiles(String spaceId, ListFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListFilesHeaders headers = new ListFilesHeaders();
        return this.listFilesWithOptions(spaceId, request, headers, runtime);
    }

    public ListFilesResponse listFilesWithOptions(String spaceId, ListFilesRequest request, ListFilesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.parentId)) {
            query.put("parentId", request.parentId);
        }

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
        return TeaModel.toModel(this.doROARequest("ListFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files", "json", req, runtime), new ListFilesResponse());
    }

    public ModifyPermissionResponse modifyPermission(String spaceId, String fileId, ModifyPermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ModifyPermissionHeaders headers = new ModifyPermissionHeaders();
        return this.modifyPermissionWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public ModifyPermissionResponse modifyPermissionWithOptions(String spaceId, String fileId, ModifyPermissionRequest request, ModifyPermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("ModifyPermission", "drive_1.0", "HTTP", "PUT", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "none", req, runtime), new ModifyPermissionResponse());
    }

    public ListPermissionsResponse listPermissions(String spaceId, String fileId, ListPermissionsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListPermissionsHeaders headers = new ListPermissionsHeaders();
        return this.listPermissionsWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public ListPermissionsResponse listPermissionsWithOptions(String spaceId, String fileId, ListPermissionsRequest request, ListPermissionsHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListPermissions", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions", "json", req, runtime), new ListPermissionsResponse());
    }

    public GrantPrivilegeOfCustomSpaceResponse grantPrivilegeOfCustomSpace(String spaceId, GrantPrivilegeOfCustomSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GrantPrivilegeOfCustomSpaceHeaders headers = new GrantPrivilegeOfCustomSpaceHeaders();
        return this.grantPrivilegeOfCustomSpaceWithOptions(spaceId, request, headers, runtime);
    }

    public GrantPrivilegeOfCustomSpaceResponse grantPrivilegeOfCustomSpaceWithOptions(String spaceId, GrantPrivilegeOfCustomSpaceRequest request, GrantPrivilegeOfCustomSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.type)) {
            body.put("type", request.type);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fileIds)) {
            body.put("fileIds", request.fileIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.duration)) {
            body.put("duration", request.duration);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("GrantPrivilegeOfCustomSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/customSpacePrivileges", "none", req, runtime), new GrantPrivilegeOfCustomSpaceResponse());
    }

    public MoveFileResponse moveFile(String spaceId, String fileId, MoveFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        MoveFileHeaders headers = new MoveFileHeaders();
        return this.moveFileWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public MoveFileResponse moveFileWithOptions(String spaceId, String fileId, MoveFileRequest request, MoveFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.targetSpaceId)) {
            body.put("targetSpaceId", request.targetSpaceId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.targetParentId)) {
            body.put("targetParentId", request.targetParentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            body.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("MoveFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/move", "json", req, runtime), new MoveFileResponse());
    }

    public GetDownloadInfoResponse getDownloadInfo(String spaceId, String fileId, GetDownloadInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
        return this.getDownloadInfoWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public GetDownloadInfoResponse getDownloadInfoWithOptions(String spaceId, String fileId, GetDownloadInfoRequest request, GetDownloadInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos", "json", req, runtime), new GetDownloadInfoResponse());
    }

    public GetUploadInfoResponse getUploadInfo(String spaceId, String parentId, GetUploadInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
        return this.getUploadInfoWithOptions(spaceId, parentId, request, headers, runtime);
    }

    public GetUploadInfoResponse getUploadInfoWithOptions(String spaceId, String parentId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
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

        if (!com.aliyun.teautil.Common.isUnset(request.addConflictPolicy)) {
            query.put("addConflictPolicy", request.addConflictPolicy);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.mediaId)) {
            query.put("mediaId", request.mediaId);
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
        return TeaModel.toModel(this.doROARequest("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos", "json", req, runtime), new GetUploadInfoResponse());
    }

    public ListSpacesResponse listSpaces(ListSpacesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSpacesHeaders headers = new ListSpacesHeaders();
        return this.listSpacesWithOptions(request, headers, runtime);
    }

    public ListSpacesResponse listSpacesWithOptions(ListSpacesRequest request, ListSpacesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.spaceType)) {
            query.put("spaceType", request.spaceType);
        }

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
        return TeaModel.toModel(this.doROARequest("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/spaces", "json", req, runtime), new ListSpacesResponse());
    }

    public DeletePermissionResponse deletePermission(String spaceId, String fileId, DeletePermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeletePermissionHeaders headers = new DeletePermissionHeaders();
        return this.deletePermissionWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public DeletePermissionResponse deletePermissionWithOptions(String spaceId, String fileId, DeletePermissionRequest request, DeletePermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.role)) {
            body.put("role", request.role);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("DeletePermission", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "/permissions/delete", "none", req, runtime), new DeletePermissionResponse());
    }

    public AddCustomSpaceResponse addCustomSpace(AddCustomSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddCustomSpaceHeaders headers = new AddCustomSpaceHeaders();
        return this.addCustomSpaceWithOptions(request, headers, runtime);
    }

    public AddCustomSpaceResponse addCustomSpaceWithOptions(AddCustomSpaceRequest request, AddCustomSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.identifier)) {
            body.put("identifier", request.identifier);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
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
        return TeaModel.toModel(this.doROARequest("AddCustomSpace", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/spaces/customSpaces", "json", req, runtime), new AddCustomSpaceResponse());
    }

    public DeleteSpaceResponse deleteSpace(String spaceId, DeleteSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteSpaceHeaders headers = new DeleteSpaceHeaders();
        return this.deleteSpaceWithOptions(spaceId, request, headers, runtime);
    }

    public DeleteSpaceResponse deleteSpaceWithOptions(String spaceId, DeleteSpaceRequest request, DeleteSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteSpace", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/spaces/" + spaceId + "", "none", req, runtime), new DeleteSpaceResponse());
    }

    public ClearRecycleFilesResponse clearRecycleFiles(ClearRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
        return this.clearRecycleFilesWithOptions(request, headers, runtime);
    }

    public ClearRecycleFilesResponse clearRecycleFilesWithOptions(ClearRecycleFilesRequest request, ClearRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", headers.xAcsDingtalkAccessToken);
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/recycleItems/clear", "none", req, runtime), new ClearRecycleFilesResponse());
    }

    public DeleteFileResponse deleteFile(String spaceId, String fileId, DeleteFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteFileHeaders headers = new DeleteFileHeaders();
        return this.deleteFileWithOptions(spaceId, fileId, request, headers, runtime);
    }

    public DeleteFileResponse deleteFileWithOptions(String spaceId, String fileId, DeleteFileRequest request, DeleteFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deletePolicy)) {
            query.put("deletePolicy", request.deletePolicy);
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
        return TeaModel.toModel(this.doROARequest("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/spaces/" + spaceId + "/files/" + fileId + "", "json", req, runtime), new DeleteFileResponse());
    }
}
