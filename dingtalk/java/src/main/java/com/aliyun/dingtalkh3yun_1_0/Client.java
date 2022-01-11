// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkh3yun_1_0.models.*;
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


    public BatchInsertBizObjectResponse batchInsertBizObject(BatchInsertBizObjectRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        BatchInsertBizObjectHeaders headers = new BatchInsertBizObjectHeaders();
        return this.batchInsertBizObjectWithOptions(request, headers, runtime);
    }

    public BatchInsertBizObjectResponse batchInsertBizObjectWithOptions(BatchInsertBizObjectRequest request, BatchInsertBizObjectHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectJsonArray)) {
            body.put("bizObjectJsonArray", request.bizObjectJsonArray);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDraft)) {
            body.put("isDraft", request.isDraft);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("BatchInsertBizObject", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances/batch", "json", req, runtime), new BatchInsertBizObjectResponse());
    }

    public CancelProcessInstanceResponse cancelProcessInstance(CancelProcessInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CancelProcessInstanceHeaders headers = new CancelProcessInstanceHeaders();
        return this.cancelProcessInstanceWithOptions(request, headers, runtime);
    }

    public CancelProcessInstanceResponse cancelProcessInstanceWithOptions(CancelProcessInstanceRequest request, CancelProcessInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            body.put("processInstanceId", request.processInstanceId);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CancelProcessInstance", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/processes/instances/cancel", "json", req, runtime), new CancelProcessInstanceResponse());
    }

    public CreateBizObjectResponse createBizObject(CreateBizObjectRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateBizObjectHeaders headers = new CreateBizObjectHeaders();
        return this.createBizObjectWithOptions(request, headers, runtime);
    }

    public CreateBizObjectResponse createBizObjectWithOptions(CreateBizObjectRequest request, CreateBizObjectHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectJson)) {
            body.put("bizObjectJson", request.bizObjectJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isDraft)) {
            body.put("isDraft", request.isDraft);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateBizObject", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime), new CreateBizObjectResponse());
    }

    public CreateProcessesInstanceResponse createProcessesInstance(CreateProcessesInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateProcessesInstanceHeaders headers = new CreateProcessesInstanceHeaders();
        return this.createProcessesInstanceWithOptions(request, headers, runtime);
    }

    public CreateProcessesInstanceResponse createProcessesInstanceWithOptions(CreateProcessesInstanceRequest request, CreateProcessesInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            body.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("CreateProcessesInstance", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime), new CreateProcessesInstanceResponse());
    }

    public DeleteBizObjectResponse deleteBizObject(DeleteBizObjectRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteBizObjectHeaders headers = new DeleteBizObjectHeaders();
        return this.deleteBizObjectWithOptions(request, headers, runtime);
    }

    public DeleteBizObjectResponse deleteBizObjectWithOptions(DeleteBizObjectRequest request, DeleteBizObjectHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
        return TeaModel.toModel(this.doROARequest("DeleteBizObject", "h3yun_1.0", "HTTP", "DELETE", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime), new DeleteBizObjectResponse());
    }

    public DeleteProcessesInstanceResponse deleteProcessesInstance(DeleteProcessesInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteProcessesInstanceHeaders headers = new DeleteProcessesInstanceHeaders();
        return this.deleteProcessesInstanceWithOptions(request, headers, runtime);
    }

    public DeleteProcessesInstanceResponse deleteProcessesInstanceWithOptions(DeleteProcessesInstanceRequest request, DeleteProcessesInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.isAutoUpdateBizObject)) {
            query.put("isAutoUpdateBizObject", request.isAutoUpdateBizObject);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
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
        return TeaModel.toModel(this.doROARequest("DeleteProcessesInstance", "h3yun_1.0", "HTTP", "DELETE", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime), new DeleteProcessesInstanceResponse());
    }

    public GetAppsResponse getApps(GetAppsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetAppsHeaders headers = new GetAppsHeaders();
        return this.getAppsWithOptions(request, headers, runtime);
    }

    public GetAppsResponse getAppsWithOptions(GetAppsRequest request, GetAppsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.queryType)) {
            body.put("queryType", request.queryType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.values)) {
            body.put("values", request.values);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetApps", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/apps/search", "json", req, runtime), new GetAppsResponse());
    }

    public GetAttachmentTemporaryUrlResponse getAttachmentTemporaryUrl(GetAttachmentTemporaryUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetAttachmentTemporaryUrlHeaders headers = new GetAttachmentTemporaryUrlHeaders();
        return this.getAttachmentTemporaryUrlWithOptions(request, headers, runtime);
    }

    public GetAttachmentTemporaryUrlResponse getAttachmentTemporaryUrlWithOptions(GetAttachmentTemporaryUrlRequest request, GetAttachmentTemporaryUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.attachmentId)) {
            query.put("attachmentId", request.attachmentId);
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
        return TeaModel.toModel(this.doROARequest("GetAttachmentTemporaryUrl", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/attachments/temporaryUrls", "json", req, runtime), new GetAttachmentTemporaryUrlResponse());
    }

    public GetOrganizationsResponse getOrganizations(GetOrganizationsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetOrganizationsHeaders headers = new GetOrganizationsHeaders();
        return this.getOrganizationsWithOptions(request, headers, runtime);
    }

    public GetOrganizationsResponse getOrganizationsWithOptions(GetOrganizationsRequest request, GetOrganizationsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
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
        return TeaModel.toModel(this.doROARequest("GetOrganizations", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/departments", "json", req, runtime), new GetOrganizationsResponse());
    }

    public GetRoleUsersResponse getRoleUsers(GetRoleUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetRoleUsersHeaders headers = new GetRoleUsersHeaders();
        return this.getRoleUsersWithOptions(request, headers, runtime);
    }

    public GetRoleUsersResponse getRoleUsersWithOptions(GetRoleUsersRequest request, GetRoleUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.roleId)) {
            query.put("roleId", request.roleId);
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
        return TeaModel.toModel(this.doROARequest("GetRoleUsers", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/roles/roleUsers", "json", req, runtime), new GetRoleUsersResponse());
    }

    public GetRolesResponse getRoles() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetRolesHeaders headers = new GetRolesHeaders();
        return this.getRolesWithOptions(headers, runtime);
    }

    public GetRolesResponse getRolesWithOptions(GetRolesHeaders headers, RuntimeOptions runtime) throws Exception {
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        OpenApiRequest req = OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetRoles", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/roles", "json", req, runtime), new GetRolesResponse());
    }

    public GetUploadUrlResponse getUploadUrl(GetUploadUrlRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUploadUrlHeaders headers = new GetUploadUrlHeaders();
        return this.getUploadUrlWithOptions(request, headers, runtime);
    }

    public GetUploadUrlResponse getUploadUrlWithOptions(GetUploadUrlRequest request, GetUploadUrlHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fieldName)) {
            query.put("fieldName", request.fieldName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isOverwrite)) {
            query.put("isOverwrite", request.isOverwrite);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
        return TeaModel.toModel(this.doROARequest("GetUploadUrl", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/attachments/uploadUrls", "json", req, runtime), new GetUploadUrlResponse());
    }

    public GetUsersResponse getUsers(GetUsersRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUsersHeaders headers = new GetUsersHeaders();
        return this.getUsersWithOptions(request, headers, runtime);
    }

    public GetUsersResponse getUsersWithOptions(GetUsersRequest request, GetUsersHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.departmentId)) {
            query.put("departmentId", request.departmentId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isRecursive)) {
            query.put("isRecursive", request.isRecursive);
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
        return TeaModel.toModel(this.doROARequest("GetUsers", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/users", "json", req, runtime), new GetUsersResponse());
    }

    public LoadBizFieldsResponse loadBizFields(LoadBizFieldsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        LoadBizFieldsHeaders headers = new LoadBizFieldsHeaders();
        return this.loadBizFieldsWithOptions(request, headers, runtime);
    }

    public LoadBizFieldsResponse loadBizFieldsWithOptions(LoadBizFieldsRequest request, LoadBizFieldsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
        return TeaModel.toModel(this.doROARequest("LoadBizFields", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/forms/loadBizFields", "json", req, runtime), new LoadBizFieldsResponse());
    }

    public LoadBizObjectResponse loadBizObject(LoadBizObjectRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        LoadBizObjectHeaders headers = new LoadBizObjectHeaders();
        return this.loadBizObjectWithOptions(request, headers, runtime);
    }

    public LoadBizObjectResponse loadBizObjectWithOptions(LoadBizObjectRequest request, LoadBizObjectHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
        return TeaModel.toModel(this.doROARequest("LoadBizObject", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/forms/instances/loadInstances", "json", req, runtime), new LoadBizObjectResponse());
    }

    public LoadBizObjectsResponse loadBizObjects(LoadBizObjectsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        LoadBizObjectsHeaders headers = new LoadBizObjectsHeaders();
        return this.loadBizObjectsWithOptions(request, headers, runtime);
    }

    public LoadBizObjectsResponse loadBizObjectsWithOptions(LoadBizObjectsRequest request, LoadBizObjectsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.matcherJson)) {
            body.put("matcherJson", request.matcherJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageNumber)) {
            body.put("pageNumber", request.pageNumber);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pageSize)) {
            body.put("pageSize", request.pageSize);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.returnFields)) {
            body.put("returnFields", request.returnFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortByFields)) {
            body.put("sortByFields", request.sortByFields);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("LoadBizObjects", "h3yun_1.0", "HTTP", "POST", "AK", "/v1.0/h3yun/forms/instances/search", "json", req, runtime), new LoadBizObjectsResponse());
    }

    public QueryAppFunctionNodesResponse queryAppFunctionNodes(QueryAppFunctionNodesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryAppFunctionNodesHeaders headers = new QueryAppFunctionNodesHeaders();
        return this.queryAppFunctionNodesWithOptions(request, headers, runtime);
    }

    public QueryAppFunctionNodesResponse queryAppFunctionNodesWithOptions(QueryAppFunctionNodesRequest request, QueryAppFunctionNodesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appCode)) {
            query.put("appCode", request.appCode);
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
        return TeaModel.toModel(this.doROARequest("QueryAppFunctionNodes", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/apps/functionNodes", "json", req, runtime), new QueryAppFunctionNodesResponse());
    }

    public QueryProcessesInstanceResponse queryProcessesInstance(QueryProcessesInstanceRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryProcessesInstanceHeaders headers = new QueryProcessesInstanceHeaders();
        return this.queryProcessesInstanceWithOptions(request, headers, runtime);
    }

    public QueryProcessesInstanceResponse queryProcessesInstanceWithOptions(QueryProcessesInstanceRequest request, QueryProcessesInstanceHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            query.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            query.put("schemaCode", request.schemaCode);
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
        return TeaModel.toModel(this.doROARequest("QueryProcessesInstance", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/processes/instances", "json", req, runtime), new QueryProcessesInstanceResponse());
    }

    public QueryProcessesWorkItemsResponse queryProcessesWorkItems(QueryProcessesWorkItemsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryProcessesWorkItemsHeaders headers = new QueryProcessesWorkItemsHeaders();
        return this.queryProcessesWorkItemsWithOptions(request, headers, runtime);
    }

    public QueryProcessesWorkItemsResponse queryProcessesWorkItemsWithOptions(QueryProcessesWorkItemsRequest request, QueryProcessesWorkItemsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.processInstanceId)) {
            query.put("processInstanceId", request.processInstanceId);
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
        return TeaModel.toModel(this.doROARequest("QueryProcessesWorkItems", "h3yun_1.0", "HTTP", "GET", "AK", "/v1.0/h3yun/processes/workItems", "json", req, runtime), new QueryProcessesWorkItemsResponse());
    }

    public UpdateBizObjectResponse updateBizObject(UpdateBizObjectRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateBizObjectHeaders headers = new UpdateBizObjectHeaders();
        return this.updateBizObjectWithOptions(request, headers, runtime);
    }

    public UpdateBizObjectResponse updateBizObjectWithOptions(UpdateBizObjectRequest request, UpdateBizObjectHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectId)) {
            body.put("bizObjectId", request.bizObjectId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizObjectJson)) {
            body.put("bizObjectJson", request.bizObjectJson);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.schemaCode)) {
            body.put("schemaCode", request.schemaCode);
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
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("UpdateBizObject", "h3yun_1.0", "HTTP", "PUT", "AK", "/v1.0/h3yun/forms/instances", "json", req, runtime), new UpdateBizObjectResponse());
    }
}
