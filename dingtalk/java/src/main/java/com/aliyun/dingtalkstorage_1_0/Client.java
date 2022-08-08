// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkstorage_1_0.models.*;
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


    public AddFolderResponse addFolder(String spaceId, String parentId, AddFolderRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddFolderHeaders headers = new AddFolderHeaders();
        return this.addFolderWithOptions(spaceId, parentId, request, headers, runtime);
    }

    public AddFolderResponse addFolderWithOptions(String spaceId, String parentId, AddFolderRequest request, AddFolderHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        parentId = com.aliyun.openapiutil.Client.getEncodeParam(parentId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
            body.put("option", request.option);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddFolder", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + parentId + "/folders", "json", req, runtime), new AddFolderResponse());
    }

    public AddPermissionResponse addPermission(String spaceId, String dentryId, AddPermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddPermissionHeaders headers = new AddPermissionHeaders();
        return this.addPermissionWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public AddPermissionResponse addPermissionWithOptions(String spaceId, String dentryId, AddPermissionRequest request, AddPermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddPermission", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions", "json", req, runtime), new AddPermissionResponse());
    }

    public AddSpaceResponse addSpace(AddSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddSpaceHeaders headers = new AddSpaceHeaders();
        return this.addSpaceWithOptions(request, headers, runtime);
    }

    public AddSpaceResponse addSpaceWithOptions(AddSpaceRequest request, AddSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
            body.put("option", request.option);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("AddSpace", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces", "json", req, runtime), new AddSpaceResponse());
    }

    public ClearRecycleBinResponse clearRecycleBin(String recycleBinId, ClearRecycleBinRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ClearRecycleBinHeaders headers = new ClearRecycleBinHeaders();
        return this.clearRecycleBinWithOptions(recycleBinId, request, headers, runtime);
    }

    public ClearRecycleBinResponse clearRecycleBinWithOptions(String recycleBinId, ClearRecycleBinRequest request, ClearRecycleBinHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        recycleBinId = com.aliyun.openapiutil.Client.getEncodeParam(recycleBinId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ClearRecycleBin", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/clear", "json", req, runtime), new ClearRecycleBinResponse());
    }

    public CommitFileResponse commitFile(String spaceId, CommitFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CommitFileHeaders headers = new CommitFileHeaders();
        return this.commitFileWithOptions(spaceId, request, headers, runtime);
    }

    public CommitFileResponse commitFileWithOptions(String spaceId, CommitFileRequest request, CommitFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CommitFile", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/files/commit", "json", req, runtime), new CommitFileResponse());
    }

    public CopyDentryResponse copyDentry(String spaceId, String dentryId, CopyDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CopyDentryHeaders headers = new CopyDentryHeaders();
        return this.copyDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public CopyDentryResponse copyDentryWithOptions(String spaceId, String dentryId, CopyDentryRequest request, CopyDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CopyDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/copy", "json", req, runtime), new CopyDentryResponse());
    }

    public DeleteDentryResponse deleteDentry(String spaceId, String dentryId, DeleteDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteDentryHeaders headers = new DeleteDentryHeaders();
        return this.deleteDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public DeleteDentryResponse deleteDentryWithOptions(String spaceId, String dentryId, DeleteDentryRequest request, DeleteDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteDentry", "storage_1.0", "HTTP", "DELETE", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "", "json", req, runtime), new DeleteDentryResponse());
    }

    public DeleteDentryAppPropertiesResponse deleteDentryAppProperties(String spaceId, String dentryId, DeleteDentryAppPropertiesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteDentryAppPropertiesHeaders headers = new DeleteDentryAppPropertiesHeaders();
        return this.deleteDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public DeleteDentryAppPropertiesResponse deleteDentryAppPropertiesWithOptions(String spaceId, String dentryId, DeleteDentryAppPropertiesRequest request, DeleteDentryAppPropertiesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteDentryAppProperties", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties/remove", "json", req, runtime), new DeleteDentryAppPropertiesResponse());
    }

    public DeletePermissionResponse deletePermission(String spaceId, String dentryId, DeletePermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeletePermissionHeaders headers = new DeletePermissionHeaders();
        return this.deletePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public DeletePermissionResponse deletePermissionWithOptions(String spaceId, String dentryId, DeletePermissionRequest request, DeletePermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeletePermission", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/remove", "json", req, runtime), new DeletePermissionResponse());
    }

    public DeleteRecycleItemResponse deleteRecycleItem(String recycleBinId, String recycleItemId, DeleteRecycleItemRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteRecycleItemHeaders headers = new DeleteRecycleItemHeaders();
        return this.deleteRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
    }

    public DeleteRecycleItemResponse deleteRecycleItemWithOptions(String recycleBinId, String recycleItemId, DeleteRecycleItemRequest request, DeleteRecycleItemHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        recycleBinId = com.aliyun.openapiutil.Client.getEncodeParam(recycleBinId);
        recycleItemId = com.aliyun.openapiutil.Client.getEncodeParam(recycleItemId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteRecycleItem", "storage_1.0", "HTTP", "DELETE", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "", "json", req, runtime), new DeleteRecycleItemResponse());
    }

    public DeleteRecycleItemsResponse deleteRecycleItems(String recycleBinId, DeleteRecycleItemsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteRecycleItemsHeaders headers = new DeleteRecycleItemsHeaders();
        return this.deleteRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
    }

    public DeleteRecycleItemsResponse deleteRecycleItemsWithOptions(String recycleBinId, DeleteRecycleItemsRequest request, DeleteRecycleItemsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        recycleBinId = com.aliyun.openapiutil.Client.getEncodeParam(recycleBinId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("DeleteRecycleItems", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/batchRemove", "json", req, runtime), new DeleteRecycleItemsResponse());
    }

    public GetCurrentAppResponse getCurrentApp(GetCurrentAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCurrentAppHeaders headers = new GetCurrentAppHeaders();
        return this.getCurrentAppWithOptions(request, headers, runtime);
    }

    public GetCurrentAppResponse getCurrentAppWithOptions(GetCurrentAppRequest request, GetCurrentAppHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetCurrentApp", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/currentApps/query", "json", req, runtime), new GetCurrentAppResponse());
    }

    public GetDentryResponse getDentry(String spaceId, String dentryId, GetDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDentryHeaders headers = new GetDentryHeaders();
        return this.getDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public GetDentryResponse getDentryWithOptions(String spaceId, String dentryId, GetDentryRequest request, GetDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/query", "json", req, runtime), new GetDentryResponse());
    }

    public GetFileDownloadInfoResponse getFileDownloadInfo(String spaceId, String dentryId, GetFileDownloadInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFileDownloadInfoHeaders headers = new GetFileDownloadInfoHeaders();
        return this.getFileDownloadInfoWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public GetFileDownloadInfoResponse getFileDownloadInfoWithOptions(String spaceId, String dentryId, GetFileDownloadInfoRequest request, GetFileDownloadInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
            body.put("option", request.option);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetFileDownloadInfo", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/downloadInfos/query", "json", req, runtime), new GetFileDownloadInfoResponse());
    }

    public GetFileUploadInfoResponse getFileUploadInfo(String spaceId, GetFileUploadInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetFileUploadInfoHeaders headers = new GetFileUploadInfoHeaders();
        return this.getFileUploadInfoWithOptions(spaceId, request, headers, runtime);
    }

    public GetFileUploadInfoResponse getFileUploadInfoWithOptions(String spaceId, GetFileUploadInfoRequest request, GetFileUploadInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.multipart)) {
            body.put("multipart", request.multipart);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetFileUploadInfo", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/files/uploadInfos/query", "json", req, runtime), new GetFileUploadInfoResponse());
    }

    public GetRecycleBinResponse getRecycleBin(GetRecycleBinRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetRecycleBinHeaders headers = new GetRecycleBinHeaders();
        return this.getRecycleBinWithOptions(request, headers, runtime);
    }

    public GetRecycleBinResponse getRecycleBinWithOptions(GetRecycleBinRequest request, GetRecycleBinHeaders headers, RuntimeOptions runtime) throws Exception {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetRecycleBin", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins", "json", req, runtime), new GetRecycleBinResponse());
    }

    public GetRecycleItemResponse getRecycleItem(String recycleBinId, String recycleItemId, GetRecycleItemRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetRecycleItemHeaders headers = new GetRecycleItemHeaders();
        return this.getRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
    }

    public GetRecycleItemResponse getRecycleItemWithOptions(String recycleBinId, String recycleItemId, GetRecycleItemRequest request, GetRecycleItemHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        recycleBinId = com.aliyun.openapiutil.Client.getEncodeParam(recycleBinId);
        recycleItemId = com.aliyun.openapiutil.Client.getEncodeParam(recycleItemId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetRecycleItem", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "", "json", req, runtime), new GetRecycleItemResponse());
    }

    public GetSpaceResponse getSpace(String spaceId, GetSpaceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetSpaceHeaders headers = new GetSpaceHeaders();
        return this.getSpaceWithOptions(spaceId, request, headers, runtime);
    }

    public GetSpaceResponse getSpaceWithOptions(String spaceId, GetSpaceRequest request, GetSpaceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetSpace", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId + "", "json", req, runtime), new GetSpaceResponse());
    }

    public ListDentriesResponse listDentries(String spaceId, ListDentriesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListDentriesHeaders headers = new ListDentriesHeaders();
        return this.listDentriesWithOptions(spaceId, request, headers, runtime);
    }

    public ListDentriesResponse listDentriesWithOptions(String spaceId, ListDentriesRequest request, ListDentriesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
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

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListDentries", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries", "json", req, runtime), new ListDentriesResponse());
    }

    public ListDentryVersionsResponse listDentryVersions(String spaceId, String dentryId, ListDentryVersionsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListDentryVersionsHeaders headers = new ListDentryVersionsHeaders();
        return this.listDentryVersionsWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public ListDentryVersionsResponse listDentryVersionsWithOptions(String spaceId, String dentryId, ListDentryVersionsRequest request, ListDentryVersionsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListDentryVersions", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions", "json", req, runtime), new ListDentryVersionsResponse());
    }

    public ListPermissionsResponse listPermissions(String spaceId, String dentryId, ListPermissionsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListPermissionsHeaders headers = new ListPermissionsHeaders();
        return this.listPermissionsWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public ListPermissionsResponse listPermissionsWithOptions(String spaceId, String dentryId, ListPermissionsRequest request, ListPermissionsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
            body.put("option", request.option);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("ListPermissions", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions/query", "json", req, runtime), new ListPermissionsResponse());
    }

    public ListRecycleItemsResponse listRecycleItems(String recycleBinId, ListRecycleItemsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListRecycleItemsHeaders headers = new ListRecycleItemsHeaders();
        return this.listRecycleItemsWithOptions(recycleBinId, request, headers, runtime);
    }

    public ListRecycleItemsResponse listRecycleItemsWithOptions(String recycleBinId, ListRecycleItemsRequest request, ListRecycleItemsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        recycleBinId = com.aliyun.openapiutil.Client.getEncodeParam(recycleBinId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("ListRecycleItems", "storage_1.0", "HTTP", "GET", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems", "json", req, runtime), new ListRecycleItemsResponse());
    }

    public MoveDentryResponse moveDentry(String spaceId, String dentryId, MoveDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        MoveDentryHeaders headers = new MoveDentryHeaders();
        return this.moveDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public MoveDentryResponse moveDentryWithOptions(String spaceId, String dentryId, MoveDentryRequest request, MoveDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("MoveDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/move", "json", req, runtime), new MoveDentryResponse());
    }

    public RenameDentryResponse renameDentry(String spaceId, String dentryId, RenameDentryRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RenameDentryHeaders headers = new RenameDentryHeaders();
        return this.renameDentryWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public RenameDentryResponse renameDentryWithOptions(String spaceId, String dentryId, RenameDentryRequest request, RenameDentryHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RenameDentry", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/rename", "json", req, runtime), new RenameDentryResponse());
    }

    public RestoreRecycleItemResponse restoreRecycleItem(String recycleBinId, String recycleItemId, RestoreRecycleItemRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RestoreRecycleItemHeaders headers = new RestoreRecycleItemHeaders();
        return this.restoreRecycleItemWithOptions(recycleBinId, recycleItemId, request, headers, runtime);
    }

    public RestoreRecycleItemResponse restoreRecycleItemWithOptions(String recycleBinId, String recycleItemId, RestoreRecycleItemRequest request, RestoreRecycleItemHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        recycleBinId = com.aliyun.openapiutil.Client.getEncodeParam(recycleBinId);
        recycleItemId = com.aliyun.openapiutil.Client.getEncodeParam(recycleItemId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
            body.put("option", request.option);
        }

        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("RestoreRecycleItem", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/recycleBins/" + recycleBinId + "/recycleItems/" + recycleItemId + "/restore", "json", req, runtime), new RestoreRecycleItemResponse());
    }

    public RevertDentryVersionResponse revertDentryVersion(String spaceId, String dentryId, String version, RevertDentryVersionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RevertDentryVersionHeaders headers = new RevertDentryVersionHeaders();
        return this.revertDentryVersionWithOptions(spaceId, dentryId, version, request, headers, runtime);
    }

    public RevertDentryVersionResponse revertDentryVersionWithOptions(String spaceId, String dentryId, String version, RevertDentryVersionRequest request, RevertDentryVersionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        version = com.aliyun.openapiutil.Client.getEncodeParam(version);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("RevertDentryVersion", "storage_1.0", "HTTP", "POST", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/versions/" + version + "/revert", "json", req, runtime), new RevertDentryVersionResponse());
    }

    public UpdateDentryAppPropertiesResponse updateDentryAppProperties(String spaceId, String dentryId, UpdateDentryAppPropertiesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateDentryAppPropertiesHeaders headers = new UpdateDentryAppPropertiesHeaders();
        return this.updateDentryAppPropertiesWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public UpdateDentryAppPropertiesResponse updateDentryAppPropertiesWithOptions(String spaceId, String dentryId, UpdateDentryAppPropertiesRequest request, UpdateDentryAppPropertiesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateDentryAppProperties", "storage_1.0", "HTTP", "PUT", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/appProperties", "json", req, runtime), new UpdateDentryAppPropertiesResponse());
    }

    public UpdatePermissionResponse updatePermission(String spaceId, String dentryId, UpdatePermissionRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdatePermissionHeaders headers = new UpdatePermissionHeaders();
        return this.updatePermissionWithOptions(spaceId, dentryId, request, headers, runtime);
    }

    public UpdatePermissionResponse updatePermissionWithOptions(String spaceId, String dentryId, UpdatePermissionRequest request, UpdatePermissionHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        spaceId = com.aliyun.openapiutil.Client.getEncodeParam(spaceId);
        dentryId = com.aliyun.openapiutil.Client.getEncodeParam(dentryId);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            query.put("unionId", request.unionId);
        }

        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.option))) {
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

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdatePermission", "storage_1.0", "HTTP", "PUT", "AK", "/v1.0/storage/spaces/" + spaceId + "/dentries/" + dentryId + "/permissions", "json", req, runtime), new UpdatePermissionResponse());
    }
}
