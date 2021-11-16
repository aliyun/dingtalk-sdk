// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcontact_1_0.models.*;
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


    public SortUserResponse sortUser(SortUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SortUserHeaders headers = new SortUserHeaders();
        return this.sortUserWithOptions(request, headers, runtime);
    }

    public SortUserResponse sortUserWithOptions(SortUserRequest request, SortUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortType)) {
            body.put("sortType", request.sortType);
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
        return TeaModel.toModel(this.doROARequest("SortUser", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/users/sort", "json", req, runtime), new SortUserResponse());
    }

    public SignOutResponse signOut(SignOutRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SignOutHeaders headers = new SignOutHeaders();
        return this.signOutWithOptions(request, headers, runtime);
    }

    public SignOutResponse signOutWithOptions(SignOutRequest request, SignOutHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reason)) {
            body.put("reason", request.reason);
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
        return TeaModel.toModel(this.doROARequest("SignOut", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/orgAccounts/signOut", "none", req, runtime), new SignOutResponse());
    }

    public ListContactHideSettingsResponse listContactHideSettings(ListContactHideSettingsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListContactHideSettingsHeaders headers = new ListContactHideSettingsHeaders();
        return this.listContactHideSettingsWithOptions(request, headers, runtime);
    }

    public ListContactHideSettingsResponse listContactHideSettingsWithOptions(ListContactHideSettingsRequest request, ListContactHideSettingsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("ListContactHideSettings", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/contactHideSettings", "json", req, runtime), new ListContactHideSettingsResponse());
    }

    public UpdateContactHideSettingResponse updateContactHideSetting(UpdateContactHideSettingRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateContactHideSettingHeaders headers = new UpdateContactHideSettingHeaders();
        return this.updateContactHideSettingWithOptions(request, headers, runtime);
    }

    public UpdateContactHideSettingResponse updateContactHideSettingWithOptions(UpdateContactHideSettingRequest request, UpdateContactHideSettingHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectStaffIds)) {
            body.put("objectStaffIds", request.objectStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeStaffIds)) {
            body.put("excludeStaffIds", request.excludeStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.active)) {
            body.put("active", request.active);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
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
        return TeaModel.toModel(this.doROARequest("UpdateContactHideSetting", "contact_1.0", "HTTP", "PUT", "AK", "/v1.0/contact/contactHideSettings", "json", req, runtime), new UpdateContactHideSettingResponse());
    }

    public UpdateDeptSettngTailFirstResponse updateDeptSettngTailFirst(UpdateDeptSettngTailFirstRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateDeptSettngTailFirstHeaders headers = new UpdateDeptSettngTailFirstHeaders();
        return this.updateDeptSettngTailFirstWithOptions(request, headers, runtime);
    }

    public UpdateDeptSettngTailFirstResponse updateDeptSettngTailFirstWithOptions(UpdateDeptSettngTailFirstRequest request, UpdateDeptSettngTailFirstHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.enable)) {
            body.put("enable", request.enable);
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
        return TeaModel.toModel(this.doROARequest("UpdateDeptSettngTailFirst", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/depts/settings/priorities", "none", req, runtime), new UpdateDeptSettngTailFirstResponse());
    }

    public UpdateEmpAttrbuteVisibilitySettingResponse updateEmpAttrbuteVisibilitySetting(UpdateEmpAttrbuteVisibilitySettingRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateEmpAttrbuteVisibilitySettingHeaders headers = new UpdateEmpAttrbuteVisibilitySettingHeaders();
        return this.updateEmpAttrbuteVisibilitySettingWithOptions(request, headers, runtime);
    }

    public UpdateEmpAttrbuteVisibilitySettingResponse updateEmpAttrbuteVisibilitySettingWithOptions(UpdateEmpAttrbuteVisibilitySettingRequest request, UpdateEmpAttrbuteVisibilitySettingHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.description)) {
            body.put("description", request.description);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectStaffIds)) {
            body.put("objectStaffIds", request.objectStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectDeptIds)) {
            body.put("objectDeptIds", request.objectDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.objectTagIds)) {
            body.put("objectTagIds", request.objectTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.hideFields)) {
            body.put("hideFields", request.hideFields);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeStaffIds)) {
            body.put("excludeStaffIds", request.excludeStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeDeptIds)) {
            body.put("excludeDeptIds", request.excludeDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.excludeTagIds)) {
            body.put("excludeTagIds", request.excludeTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.active)) {
            body.put("active", request.active);
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
        return TeaModel.toModel(this.doROARequest("UpdateEmpAttrbuteVisibilitySetting", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/staffAttributes/visibilitySettings", "json", req, runtime), new UpdateEmpAttrbuteVisibilitySettingResponse());
    }

    public DeleteEmpAttributeVisibilityResponse deleteEmpAttributeVisibility(String settingId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteEmpAttributeVisibilityHeaders headers = new DeleteEmpAttributeVisibilityHeaders();
        return this.deleteEmpAttributeVisibilityWithOptions(settingId, headers, runtime);
    }

    public DeleteEmpAttributeVisibilityResponse deleteEmpAttributeVisibilityWithOptions(String settingId, DeleteEmpAttributeVisibilityHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DeleteEmpAttributeVisibility", "contact_1.0", "HTTP", "DELETE", "AK", "/v1.0/contact/staffAttributes/visibilitySettings/" + settingId + "", "none", req, runtime), new DeleteEmpAttributeVisibilityResponse());
    }

    public SearchDepartmentResponse searchDepartment(SearchDepartmentRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchDepartmentHeaders headers = new SearchDepartmentHeaders();
        return this.searchDepartmentWithOptions(request, headers, runtime);
    }

    public SearchDepartmentResponse searchDepartmentWithOptions(SearchDepartmentRequest request, SearchDepartmentHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryWord)) {
            body.put("queryWord", request.queryWord);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            body.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            body.put("size", request.size);
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
        return TeaModel.toModel(this.doROARequest("SearchDepartment", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/departments/search", "json", req, runtime), new SearchDepartmentResponse());
    }

    public ListManagementGroupsResponse listManagementGroups(ListManagementGroupsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListManagementGroupsHeaders headers = new ListManagementGroupsHeaders();
        return this.listManagementGroupsWithOptions(request, headers, runtime);
    }

    public ListManagementGroupsResponse listManagementGroupsWithOptions(ListManagementGroupsRequest request, ListManagementGroupsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("ListManagementGroups", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/managementGroups", "json", req, runtime), new ListManagementGroupsResponse());
    }

    public ListSeniorSettingsResponse listSeniorSettings(ListSeniorSettingsRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListSeniorSettingsHeaders headers = new ListSeniorSettingsHeaders();
        return this.listSeniorSettingsWithOptions(request, headers, runtime);
    }

    public ListSeniorSettingsResponse listSeniorSettingsWithOptions(ListSeniorSettingsRequest request, ListSeniorSettingsHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.seniorStaffId)) {
            query.put("seniorStaffId", request.seniorStaffId);
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
        return TeaModel.toModel(this.doROARequest("ListSeniorSettings", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/seniorSettings", "json", req, runtime), new ListSeniorSettingsResponse());
    }

    public ListEmpAttributeVisibilityResponse listEmpAttributeVisibility(ListEmpAttributeVisibilityRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListEmpAttributeVisibilityHeaders headers = new ListEmpAttributeVisibilityHeaders();
        return this.listEmpAttributeVisibilityWithOptions(request, headers, runtime);
    }

    public ListEmpAttributeVisibilityResponse listEmpAttributeVisibilityWithOptions(ListEmpAttributeVisibilityRequest request, ListEmpAttributeVisibilityHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("ListEmpAttributeVisibility", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/staffAttributes/visibilitySettings", "json", req, runtime), new ListEmpAttributeVisibilityResponse());
    }

    public SearchUserResponse searchUser(SearchUserRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SearchUserHeaders headers = new SearchUserHeaders();
        return this.searchUserWithOptions(request, headers, runtime);
    }

    public SearchUserResponse searchUserWithOptions(SearchUserRequest request, SearchUserHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.queryWord)) {
            body.put("queryWord", request.queryWord);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.offset)) {
            body.put("offset", request.offset);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            body.put("size", request.size);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.fullMatchField)) {
            body.put("fullMatchField", request.fullMatchField);
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
        return TeaModel.toModel(this.doROARequest("SearchUser", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/users/search", "json", req, runtime), new SearchUserResponse());
    }

    public GetTranslateFileJobResultResponse getTranslateFileJobResult(GetTranslateFileJobResultRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetTranslateFileJobResultHeaders headers = new GetTranslateFileJobResultHeaders();
        return this.getTranslateFileJobResultWithOptions(request, headers, runtime);
    }

    public GetTranslateFileJobResultResponse getTranslateFileJobResultWithOptions(GetTranslateFileJobResultRequest request, GetTranslateFileJobResultHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.jobId)) {
            query.put("jobId", request.jobId);
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
        return TeaModel.toModel(this.doROARequest("GetTranslateFileJobResult", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/files/translateResults", "json", req, runtime), new GetTranslateFileJobResultResponse());
    }

    public QueryStatusResponse queryStatus(QueryStatusRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryStatusHeaders headers = new QueryStatusHeaders();
        return this.queryStatusWithOptions(request, headers, runtime);
    }

    public QueryStatusResponse queryStatusWithOptions(QueryStatusRequest request, QueryStatusHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
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
        return TeaModel.toModel(this.doROARequest("QueryStatus", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/orgAccounts/status", "json", req, runtime), new QueryStatusResponse());
    }

    public QueryUserManagementResourcesResponse queryUserManagementResources(String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryUserManagementResourcesHeaders headers = new QueryUserManagementResourcesHeaders();
        return this.queryUserManagementResourcesWithOptions(userId, headers, runtime);
    }

    public QueryUserManagementResourcesResponse queryUserManagementResourcesWithOptions(String userId, QueryUserManagementResourcesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryUserManagementResources", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/users/" + userId + "/managemementResources", "json", req, runtime), new QueryUserManagementResourcesResponse());
    }

    public DeleteContactHideSettingResponse deleteContactHideSetting(String settingId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteContactHideSettingHeaders headers = new DeleteContactHideSettingHeaders();
        return this.deleteContactHideSettingWithOptions(settingId, headers, runtime);
    }

    public DeleteContactHideSettingResponse deleteContactHideSettingWithOptions(String settingId, DeleteContactHideSettingHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DeleteContactHideSetting", "contact_1.0", "HTTP", "DELETE", "AK", "/v1.0/contact/contactHideSettings/" + settingId + "", "none", req, runtime), new DeleteContactHideSettingResponse());
    }

    public UpdateUserOwnnessResponse updateUserOwnness(String userId, UpdateUserOwnnessRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateUserOwnnessHeaders headers = new UpdateUserOwnnessHeaders();
        return this.updateUserOwnnessWithOptions(userId, request, headers, runtime);
    }

    public UpdateUserOwnnessResponse updateUserOwnnessWithOptions(String userId, UpdateUserOwnnessRequest request, UpdateUserOwnnessHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ownenssType)) {
            body.put("ownenssType", request.ownenssType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.id)) {
            body.put("id", request.id);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.startTime)) {
            body.put("startTime", request.startTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.endTime)) {
            body.put("endTime", request.endTime);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deletedFlag)) {
            body.put("deletedFlag", request.deletedFlag);
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
        return TeaModel.toModel(this.doROARequest("UpdateUserOwnness", "contact_1.0", "HTTP", "PUT", "AK", "/v1.0/contact/user/" + userId + "/ownness", "json", req, runtime), new UpdateUserOwnnessResponse());
    }

    public GetMigrationUnionIdByUnionIdResponse getMigrationUnionIdByUnionId(GetMigrationUnionIdByUnionIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetMigrationUnionIdByUnionIdHeaders headers = new GetMigrationUnionIdByUnionIdHeaders();
        return this.getMigrationUnionIdByUnionIdWithOptions(request, headers, runtime);
    }

    public GetMigrationUnionIdByUnionIdResponse getMigrationUnionIdByUnionIdWithOptions(GetMigrationUnionIdByUnionIdRequest request, GetMigrationUnionIdByUnionIdHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetMigrationUnionIdByUnionId", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/orgAccount/getMigrationUnionIdByUnionIds", "json", req, runtime), new GetMigrationUnionIdByUnionIdResponse());
    }

    public GetDingIdByMigrationDingIdResponse getDingIdByMigrationDingId(GetDingIdByMigrationDingIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDingIdByMigrationDingIdHeaders headers = new GetDingIdByMigrationDingIdHeaders();
        return this.getDingIdByMigrationDingIdWithOptions(request, headers, runtime);
    }

    public GetDingIdByMigrationDingIdResponse getDingIdByMigrationDingIdWithOptions(GetDingIdByMigrationDingIdRequest request, GetDingIdByMigrationDingIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.migrationDingId)) {
            query.put("migrationDingId", request.migrationDingId);
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
        return TeaModel.toModel(this.doROARequest("GetDingIdByMigrationDingId", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/orgAccount/getDingIdByMigrationDingIds", "json", req, runtime), new GetDingIdByMigrationDingIdResponse());
    }

    public GetCooperateOrgInviteInfoResponse getCooperateOrgInviteInfo(String cooperateCorpId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetCooperateOrgInviteInfoHeaders headers = new GetCooperateOrgInviteInfoHeaders();
        return this.getCooperateOrgInviteInfoWithOptions(cooperateCorpId, headers, runtime);
    }

    public GetCooperateOrgInviteInfoResponse getCooperateOrgInviteInfoWithOptions(String cooperateCorpId, GetCooperateOrgInviteInfoHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetCooperateOrgInviteInfo", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/cooperateCorps/" + cooperateCorpId + "/inviteInfos", "json", req, runtime), new GetCooperateOrgInviteInfoResponse());
    }

    public UpdateManagementGroupResponse updateManagementGroup(String groupId, UpdateManagementGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateManagementGroupHeaders headers = new UpdateManagementGroupHeaders();
        return this.updateManagementGroupWithOptions(groupId, request, headers, runtime);
    }

    public UpdateManagementGroupResponse updateManagementGroupWithOptions(String groupId, UpdateManagementGroupRequest request, UpdateManagementGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.scope))) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourceIds)) {
            body.put("resourceIds", request.resourceIds);
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
        return TeaModel.toModel(this.doROARequest("UpdateManagementGroup", "contact_1.0", "HTTP", "PUT", "AK", "/v1.0/contact/managementGroups/" + groupId + "", "none", req, runtime), new UpdateManagementGroupResponse());
    }

    public GetBranchAuthDataResponse getBranchAuthData(GetBranchAuthDataRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetBranchAuthDataHeaders headers = new GetBranchAuthDataHeaders();
        return this.getBranchAuthDataWithOptions(request, headers, runtime);
    }

    public GetBranchAuthDataResponse getBranchAuthDataWithOptions(GetBranchAuthDataRequest request, GetBranchAuthDataHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.branchCorpId)) {
            query.put("branchCorpId", request.branchCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.code)) {
            query.put("code", request.code);
        }

        java.util.Map<String, String> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.body)) {
            body = request.body;
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
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query)),
            new TeaPair("body", com.aliyun.openapiutil.Client.parseToMap(body))
        ));
        return TeaModel.toModel(this.doROARequest("GetBranchAuthData", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/branchAuthDatas/search", "json", req, runtime), new GetBranchAuthDataResponse());
    }

    public GetUserResponse getUser(String unionId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUserHeaders headers = new GetUserHeaders();
        return this.getUserWithOptions(unionId, headers, runtime);
    }

    public GetUserResponse getUserWithOptions(String unionId, GetUserHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetUser", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/users/" + unionId + "", "json", req, runtime), new GetUserResponse());
    }

    public QueryResourceManagementMembersResponse queryResourceManagementMembers(String resourceId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryResourceManagementMembersHeaders headers = new QueryResourceManagementMembersHeaders();
        return this.queryResourceManagementMembersWithOptions(resourceId, headers, runtime);
    }

    public QueryResourceManagementMembersResponse queryResourceManagementMembersWithOptions(String resourceId, QueryResourceManagementMembersHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryResourceManagementMembers", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/resources/" + resourceId + "/managementMembers", "json", req, runtime), new QueryResourceManagementMembersResponse());
    }

    public TranslateFileResponse translateFile(TranslateFileRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TranslateFileHeaders headers = new TranslateFileHeaders();
        return this.translateFileWithOptions(request, headers, runtime);
    }

    public TranslateFileResponse translateFileWithOptions(TranslateFileRequest request, TranslateFileHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingTokenGrantType)) {
            body.put("dingTokenGrantType", request.dingTokenGrantType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingOrgId)) {
            body.put("dingOrgId", request.dingOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingIsvOrgId)) {
            body.put("dingIsvOrgId", request.dingIsvOrgId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.dingSuiteKey)) {
            body.put("dingSuiteKey", request.dingSuiteKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.medias)) {
            body.put("medias", request.medias);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.outputFileName)) {
            body.put("outputFileName", request.outputFileName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unionId)) {
            body.put("unionId", request.unionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.requestId)) {
            body.put("RequestId", request.requestId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.eagleEyeTraceId)) {
            body.put("eagleEyeTraceId", request.eagleEyeTraceId);
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
        return TeaModel.toModel(this.doROARequest("TranslateFile", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/files/translate", "json", req, runtime), new TranslateFileResponse());
    }

    public UpdateSeniorSettingResponse updateSeniorSetting(UpdateSeniorSettingRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateSeniorSettingHeaders headers = new UpdateSeniorSettingHeaders();
        return this.updateSeniorSettingWithOptions(request, headers, runtime);
    }

    public UpdateSeniorSettingResponse updateSeniorSettingWithOptions(UpdateSeniorSettingRequest request, UpdateSeniorSettingHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.seniorStaffId)) {
            body.put("seniorStaffId", request.seniorStaffId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.open)) {
            body.put("open", request.open);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permitStaffIds)) {
            body.put("permitStaffIds", request.permitStaffIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permitDeptIds)) {
            body.put("permitDeptIds", request.permitDeptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.permitTagIds)) {
            body.put("permitTagIds", request.permitTagIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.protectScenes)) {
            body.put("protectScenes", request.protectScenes);
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
        return TeaModel.toModel(this.doROARequest("UpdateSeniorSetting", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/seniorSettings", "none", req, runtime), new UpdateSeniorSettingResponse());
    }

    public SetDisableResponse setDisable(SetDisableRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SetDisableHeaders headers = new SetDisableHeaders();
        return this.setDisableWithOptions(request, headers, runtime);
    }

    public SetDisableResponse setDisableWithOptions(SetDisableRequest request, SetDisableHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.reason)) {
            body.put("reason", request.reason);
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
        return TeaModel.toModel(this.doROARequest("SetDisable", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/orgAccounts/disable", "none", req, runtime), new SetDisableResponse());
    }

    public GetApplyInviteInfoResponse getApplyInviteInfo(GetApplyInviteInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetApplyInviteInfoHeaders headers = new GetApplyInviteInfoHeaders();
        return this.getApplyInviteInfoWithOptions(request, headers, runtime);
    }

    public GetApplyInviteInfoResponse getApplyInviteInfoWithOptions(GetApplyInviteInfoRequest request, GetApplyInviteInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.inviterUserId)) {
            query.put("inviterUserId", request.inviterUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptId)) {
            query.put("deptId", request.deptId);
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
        return TeaModel.toModel(this.doROARequest("GetApplyInviteInfo", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/invites/infos", "json", req, runtime), new GetApplyInviteInfoResponse());
    }

    public CreateCooperateOrgResponse createCooperateOrg(CreateCooperateOrgRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateCooperateOrgHeaders headers = new CreateCooperateOrgHeaders();
        return this.createCooperateOrgWithOptions(request, headers, runtime);
    }

    public CreateCooperateOrgResponse createCooperateOrgWithOptions(CreateCooperateOrgRequest request, CreateCooperateOrgHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.orgName)) {
            body.put("orgName", request.orgName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.logoMediaId)) {
            body.put("logoMediaId", request.logoMediaId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.industryCode)) {
            body.put("industryCode", request.industryCode);
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
        return TeaModel.toModel(this.doROARequest("CreateCooperateOrg", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/cooperateCorps", "json", req, runtime), new CreateCooperateOrgResponse());
    }

    public GetMigrationDingIdByDingIdResponse getMigrationDingIdByDingId(GetMigrationDingIdByDingIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetMigrationDingIdByDingIdHeaders headers = new GetMigrationDingIdByDingIdHeaders();
        return this.getMigrationDingIdByDingIdWithOptions(request, headers, runtime);
    }

    public GetMigrationDingIdByDingIdResponse getMigrationDingIdByDingIdWithOptions(GetMigrationDingIdByDingIdRequest request, GetMigrationDingIdByDingIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.dingId)) {
            query.put("dingId", request.dingId);
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
        return TeaModel.toModel(this.doROARequest("GetMigrationDingIdByDingId", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/orgAccount/getMigrationDingIdByDingIds", "json", req, runtime), new GetMigrationDingIdByDingIdResponse());
    }

    public SetEnableResponse setEnable(SetEnableRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        SetEnableHeaders headers = new SetEnableHeaders();
        return this.setEnableWithOptions(request, headers, runtime);
    }

    public SetEnableResponse setEnableWithOptions(SetEnableRequest request, SetEnableHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("SetEnable", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/orgAccounts/enable", "none", req, runtime), new SetEnableResponse());
    }

    public CreateManagementGroupResponse createManagementGroup(CreateManagementGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateManagementGroupHeaders headers = new CreateManagementGroupHeaders();
        return this.createManagementGroupWithOptions(request, headers, runtime);
    }

    public CreateManagementGroupResponse createManagementGroupWithOptions(CreateManagementGroupRequest request, CreateManagementGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.groupName)) {
            body.put("groupName", request.groupName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.members)) {
            body.put("members", request.members);
        }

        if (!com.aliyun.teautil.Common.isUnset(TeaModel.buildMap(request.scope))) {
            body.put("scope", request.scope);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.resourceIds)) {
            body.put("resourceIds", request.resourceIds);
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
        return TeaModel.toModel(this.doROARequest("CreateManagementGroup", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/managementGroups", "json", req, runtime), new CreateManagementGroupResponse());
    }

    public DeleteManagementGroupResponse deleteManagementGroup(String groupId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteManagementGroupHeaders headers = new DeleteManagementGroupHeaders();
        return this.deleteManagementGroupWithOptions(groupId, headers, runtime);
    }

    public DeleteManagementGroupResponse deleteManagementGroupWithOptions(String groupId, DeleteManagementGroupHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("DeleteManagementGroup", "contact_1.0", "HTTP", "DELETE", "AK", "/v1.0/contact/managementGroups/" + groupId + "", "none", req, runtime), new DeleteManagementGroupResponse());
    }

    public TransformToExclusiveAccountResponse transformToExclusiveAccount(TransformToExclusiveAccountRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        TransformToExclusiveAccountHeaders headers = new TransformToExclusiveAccountHeaders();
        return this.transformToExclusiveAccountWithOptions(request, headers, runtime);
    }

    public TransformToExclusiveAccountResponse transformToExclusiveAccountWithOptions(TransformToExclusiveAccountRequest request, TransformToExclusiveAccountHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.transformType)) {
            body.put("transformType", request.transformType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.idpDingTalk)) {
            body.put("idpDingTalk", request.idpDingTalk);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.loginId)) {
            body.put("loginId", request.loginId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.initPassword)) {
            body.put("initPassword", request.initPassword);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userId)) {
            body.put("userId", request.userId);
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
        return TeaModel.toModel(this.doROARequest("TransformToExclusiveAccount", "contact_1.0", "HTTP", "POST", "AK", "/v1.0/contact/orgAccount/transformToExclusiveAccounts", "none", req, runtime), new TransformToExclusiveAccountResponse());
    }

    public GetUnionIdByMigrationUnionIdResponse getUnionIdByMigrationUnionId(GetUnionIdByMigrationUnionIdRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetUnionIdByMigrationUnionIdHeaders headers = new GetUnionIdByMigrationUnionIdHeaders();
        return this.getUnionIdByMigrationUnionIdWithOptions(request, headers, runtime);
    }

    public GetUnionIdByMigrationUnionIdResponse getUnionIdByMigrationUnionIdWithOptions(GetUnionIdByMigrationUnionIdRequest request, GetUnionIdByMigrationUnionIdHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.migrationUnionId)) {
            query.put("migrationUnionId", request.migrationUnionId);
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
        return TeaModel.toModel(this.doROARequest("GetUnionIdByMigrationUnionId", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/orgAccount/getUnionIdByMigrationUnionIds", "json", req, runtime), new GetUnionIdByMigrationUnionIdResponse());
    }

    public GetLatestDingIndexResponse getLatestDingIndex() throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetLatestDingIndexHeaders headers = new GetLatestDingIndexHeaders();
        return this.getLatestDingIndexWithOptions(headers, runtime);
    }

    public GetLatestDingIndexResponse getLatestDingIndexWithOptions(GetLatestDingIndexHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetLatestDingIndex", "contact_1.0", "HTTP", "GET", "AK", "/v1.0/contact/dingIndexs", "json", req, runtime), new GetLatestDingIndexResponse());
    }
}
