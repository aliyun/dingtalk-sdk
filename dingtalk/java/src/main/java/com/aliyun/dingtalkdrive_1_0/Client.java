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


    public AddFileResponse addFile(String unionId, String spaceId, AddFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddFileHeaders headers = new AddFileHeaders();
        return this.addFileWithOptions(unionId, spaceId, request, headers, runtime);
    }

    public AddFileResponse addFileWithOptions(String unionId, String spaceId, AddFileRequest request, AddFileHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("AddFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files", "json", req, runtime), new AddFileResponse());
    }

    public RecoverRecycleFilesResponse recoverRecycleFiles(String unionId, RecoverRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RecoverRecycleFilesHeaders headers = new RecoverRecycleFilesHeaders();
        return this.recoverRecycleFilesWithOptions(unionId, request, headers, runtime);
    }

    public RecoverRecycleFilesResponse recoverRecycleFilesWithOptions(String unionId, RecoverRecycleFilesRequest request, RecoverRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleItemIdList)) {
            body.put("recycleItemIdList", request.recycleItemIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            body.put("recycleType", request.recycleType);
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
        return TeaModel.toModel(this.doROARequest("RecoverRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/recover", "none", req, runtime), new RecoverRecycleFilesResponse());
    }

    public DeleteRecycleFilesResponse deleteRecycleFiles(String unionId, DeleteRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteRecycleFilesHeaders headers = new DeleteRecycleFilesHeaders();
        return this.deleteRecycleFilesWithOptions(unionId, request, headers, runtime);
    }

    public DeleteRecycleFilesResponse deleteRecycleFilesWithOptions(String unionId, DeleteRecycleFilesRequest request, DeleteRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleItemIdList)) {
            body.put("recycleItemIdList", request.recycleItemIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            body.put("recycleType", request.recycleType);
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
        return TeaModel.toModel(this.doROARequest("DeleteRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/delete", "none", req, runtime), new DeleteRecycleFilesResponse());
    }

    public GetFileInfoResponse getFileInfo(String unionId, String spaceId, String fileId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFileInfoHeaders headers = new GetFileInfoHeaders();
        return this.getFileInfoWithOptions(unionId, spaceId, fileId, headers, runtime);
    }

    public GetFileInfoResponse getFileInfoWithOptions(String unionId, String spaceId, String fileId, GetFileInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetFileInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "", "json", req, runtime), new GetFileInfoResponse());
    }

    public ListRecycleFilesResponse listRecycleFiles(String unionId, ListRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListRecycleFilesHeaders headers = new ListRecycleFilesHeaders();
        return this.listRecycleFilesWithOptions(unionId, request, headers, runtime);
    }

    public ListRecycleFilesResponse listRecycleFilesWithOptions(String unionId, ListRecycleFilesRequest request, ListRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("ListRecycleFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems", "json", req, runtime), new ListRecycleFilesResponse());
    }

    public RenameFileResponse renameFile(String unionId, String spaceId, String fileId, RenameFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RenameFileHeaders headers = new RenameFileHeaders();
        return this.renameFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
    }

    public RenameFileResponse renameFileWithOptions(String unionId, String spaceId, String fileId, RenameFileRequest request, RenameFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.newFileName)) {
            body.put("newFileName", request.newFileName);
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
        return TeaModel.toModel(this.doROARequest("RenameFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/rename", "json", req, runtime), new RenameFileResponse());
    }

    public ListFilesResponse listFiles(String unionId, String spaceId, ListFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListFilesHeaders headers = new ListFilesHeaders();
        return this.listFilesWithOptions(unionId, spaceId, request, headers, runtime);
    }

    public ListFilesResponse listFilesWithOptions(String unionId, String spaceId, ListFilesRequest request, ListFilesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("ListFiles", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files", "json", req, runtime), new ListFilesResponse());
    }

    public MoveFileResponse moveFile(String unionId, String spaceId, String fileId, MoveFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        MoveFileHeaders headers = new MoveFileHeaders();
        return this.moveFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
    }

    public MoveFileResponse moveFileWithOptions(String unionId, String spaceId, String fileId, MoveFileRequest request, MoveFileHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("MoveFile", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/move", "json", req, runtime), new MoveFileResponse());
    }

    public GetDownloadInfoResponse getDownloadInfo(String unionId, String spaceId, String fileId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDownloadInfoHeaders headers = new GetDownloadInfoHeaders();
        return this.getDownloadInfoWithOptions(unionId, spaceId, fileId, headers, runtime);
    }

    public GetDownloadInfoResponse getDownloadInfoWithOptions(String unionId, String spaceId, String fileId, GetDownloadInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetDownloadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "/downloadInfos", "json", req, runtime), new GetDownloadInfoResponse());
    }

    public GetUploadInfoResponse getUploadInfo(String unionId, String spaceId, String parentId, GetUploadInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUploadInfoHeaders headers = new GetUploadInfoHeaders();
        return this.getUploadInfoWithOptions(unionId, spaceId, parentId, request, headers, runtime);
    }

    public GetUploadInfoResponse getUploadInfoWithOptions(String unionId, String spaceId, String parentId, GetUploadInfoRequest request, GetUploadInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("GetUploadInfo", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + parentId + "/uploadInfos", "json", req, runtime), new GetUploadInfoResponse());
    }

    public ListSpacesResponse listSpaces(String unionId, ListSpacesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSpacesHeaders headers = new ListSpacesHeaders();
        return this.listSpacesWithOptions(unionId, request, headers, runtime);
    }

    public ListSpacesResponse listSpacesWithOptions(String unionId, ListSpacesRequest request, ListSpacesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("ListSpaces", "drive_1.0", "HTTP", "GET", "AK", "/v1.0/drive/users/" + unionId + "/spaces", "json", req, runtime), new ListSpacesResponse());
    }

    public ClearRecycleFilesResponse clearRecycleFiles(String unionId, ClearRecycleFilesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ClearRecycleFilesHeaders headers = new ClearRecycleFilesHeaders();
        return this.clearRecycleFilesWithOptions(unionId, request, headers, runtime);
    }

    public ClearRecycleFilesResponse clearRecycleFilesWithOptions(String unionId, ClearRecycleFilesRequest request, ClearRecycleFilesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.recycleType)) {
            body.put("recycleType", request.recycleType);
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
        return TeaModel.toModel(this.doROARequest("ClearRecycleFiles", "drive_1.0", "HTTP", "POST", "AK", "/v1.0/drive/users/" + unionId + "/recycleItems/clear", "none", req, runtime), new ClearRecycleFilesResponse());
    }

    public DeleteFileResponse deleteFile(String unionId, String spaceId, String fileId, DeleteFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteFileHeaders headers = new DeleteFileHeaders();
        return this.deleteFileWithOptions(unionId, spaceId, fileId, request, headers, runtime);
    }

    public DeleteFileResponse deleteFileWithOptions(String unionId, String spaceId, String fileId, DeleteFileRequest request, DeleteFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("DeleteFile", "drive_1.0", "HTTP", "DELETE", "AK", "/v1.0/drive/users/" + unionId + "/spaces/" + spaceId + "/files/" + fileId + "", "json", req, runtime), new DeleteFileResponse());
    }
}
