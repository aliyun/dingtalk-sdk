// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkmicro_app_1_0.models.*;
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


    public CreateInnerAppResponse createInnerApp(CreateInnerAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateInnerAppHeaders headers = new CreateInnerAppHeaders();
        return this.createInnerAppWithOptions(request, headers, runtime);
    }

    public CreateInnerAppResponse createInnerAppWithOptions(CreateInnerAppRequest request, CreateInnerAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            body.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageLink)) {
            body.put("homepageLink", request.homepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageLink)) {
            body.put("pcHomepageLink", request.pcHomepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ompLink)) {
            body.put("ompLink", request.ompLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ipWhiteList)) {
            body.put("ipWhiteList", request.ipWhiteList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeType)) {
            body.put("scopeType", request.scopeType);
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
        return TeaModel.toModel(this.doROARequest("CreateInnerApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps", "json", req, runtime), new CreateInnerAppResponse());
    }

    public GetInnerAppResponse getInnerApp(String agentId, GetInnerAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetInnerAppHeaders headers = new GetInnerAppHeaders();
        return this.getInnerAppWithOptions(agentId, request, headers, runtime);
    }

    public GetInnerAppResponse getInnerAppWithOptions(String agentId, GetInnerAppRequest request, GetInnerAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            query.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            query.put("ecologicalCorpId", request.ecologicalCorpId);
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
        return TeaModel.toModel(this.doROARequest("GetInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "", "json", req, runtime), new GetInnerAppResponse());
    }

    public RegisterCustomAppRoleResponse registerCustomAppRole(String agentId, RegisterCustomAppRoleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RegisterCustomAppRoleHeaders headers = new RegisterCustomAppRoleHeaders();
        return this.registerCustomAppRoleWithOptions(agentId, request, headers, runtime);
    }

    public RegisterCustomAppRoleResponse registerCustomAppRoleWithOptions(String agentId, RegisterCustomAppRoleRequest request, RegisterCustomAppRoleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleName)) {
            body.put("roleName", request.roleName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.canManageRole)) {
            body.put("canManageRole", request.canManageRole);
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
        return TeaModel.toModel(this.doROARequest("RegisterCustomAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles", "json", req, runtime), new RegisterCustomAppRoleResponse());
    }

    public UpdateApaasAppResponse updateApaasApp(UpdateApaasAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateApaasAppHeaders headers = new UpdateApaasAppHeaders();
        return this.updateApaasAppWithOptions(request, headers, runtime);
    }

    public UpdateApaasAppResponse updateApaasAppWithOptions(UpdateApaasAppRequest request, UpdateApaasAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIcon)) {
            body.put("appIcon", request.appIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appStatus)) {
            body.put("appStatus", request.appStatus);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizAppId)) {
            body.put("bizAppId", request.bizAppId);
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
        return TeaModel.toModel(this.doROARequest("UpdateApaasApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apaasApps", "json", req, runtime), new UpdateApaasAppResponse());
    }

    public AddAppRolesToMemberResponse addAppRolesToMember(String agentId, AddAppRolesToMemberRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddAppRolesToMemberHeaders headers = new AddAppRolesToMemberHeaders();
        return this.addAppRolesToMemberWithOptions(agentId, request, headers, runtime);
    }

    public AddAppRolesToMemberResponse addAppRolesToMemberWithOptions(String agentId, AddAppRolesToMemberRequest request, AddAppRolesToMemberHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberId)) {
            body.put("memberId", request.memberId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.memberType)) {
            body.put("memberType", request.memberType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleList)) {
            body.put("roleList", request.roleList);
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
        return TeaModel.toModel(this.doROARequest("AddAppRolesToMember", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId + "/members/roles", "json", req, runtime), new AddAppRolesToMemberResponse());
    }

    public GetAppRoleScopeByRoleIdResponse getAppRoleScopeByRoleId(String agentId, String roleId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetAppRoleScopeByRoleIdHeaders headers = new GetAppRoleScopeByRoleIdHeaders();
        return this.getAppRoleScopeByRoleIdWithOptions(agentId, roleId, headers, runtime);
    }

    public GetAppRoleScopeByRoleIdResponse getAppRoleScopeByRoleIdWithOptions(String agentId, String roleId, GetAppRoleScopeByRoleIdHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetAppRoleScopeByRoleId", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes", "json", req, runtime), new GetAppRoleScopeByRoleIdResponse());
    }

    public ListRoleInfoByUserResponse listRoleInfoByUser(String agentId, String userId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListRoleInfoByUserHeaders headers = new ListRoleInfoByUserHeaders();
        return this.listRoleInfoByUserWithOptions(agentId, userId, headers, runtime);
    }

    public ListRoleInfoByUserResponse listRoleInfoByUserWithOptions(String agentId, String userId, ListRoleInfoByUserHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("ListRoleInfoByUser", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/users/" + userId + "/roles", "json", req, runtime), new ListRoleInfoByUserResponse());
    }

    public ListInnerAppResponse listInnerApp(ListInnerAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListInnerAppHeaders headers = new ListInnerAppHeaders();
        return this.listInnerAppWithOptions(request, headers, runtime);
    }

    public ListInnerAppResponse listInnerAppWithOptions(ListInnerAppRequest request, ListInnerAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            query.put("ecologicalCorpId", request.ecologicalCorpId);
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
        return TeaModel.toModel(this.doROARequest("ListInnerApp", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps", "json", req, runtime), new ListInnerAppResponse());
    }

    public RemoveMemberForAppRoleResponse removeMemberForAppRole(String agentId, String roleId, RemoveMemberForAppRoleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RemoveMemberForAppRoleHeaders headers = new RemoveMemberForAppRoleHeaders();
        return this.removeMemberForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    public RemoveMemberForAppRoleResponse removeMemberForAppRoleWithOptions(String agentId, String roleId, RemoveMemberForAppRoleRequest request, RemoveMemberForAppRoleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeVersion)) {
            body.put("scopeVersion", request.scopeVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
        return TeaModel.toModel(this.doROARequest("RemoveMemberForAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members/batchRemove", "json", req, runtime), new RemoveMemberForAppRoleResponse());
    }

    public UpdateInnerAppResponse updateInnerApp(String agentId, UpdateInnerAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateInnerAppHeaders headers = new UpdateInnerAppHeaders();
        return this.updateInnerAppWithOptions(agentId, request, headers, runtime);
    }

    public UpdateInnerAppResponse updateInnerAppWithOptions(String agentId, UpdateInnerAppRequest request, UpdateInnerAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            body.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.name)) {
            body.put("name", request.name);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.desc)) {
            body.put("desc", request.desc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.icon)) {
            body.put("icon", request.icon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageLink)) {
            body.put("homepageLink", request.homepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageLink)) {
            body.put("pcHomepageLink", request.pcHomepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ompLink)) {
            body.put("ompLink", request.ompLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ipWhiteList)) {
            body.put("ipWhiteList", request.ipWhiteList);
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
        return TeaModel.toModel(this.doROARequest("UpdateInnerApp", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId + "", "json", req, runtime), new UpdateInnerAppResponse());
    }

    public AddMemberToAppRoleResponse addMemberToAppRole(String agentId, String roleId, AddMemberToAppRoleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddMemberToAppRoleHeaders headers = new AddMemberToAppRoleHeaders();
        return this.addMemberToAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    public AddMemberToAppRoleResponse addMemberToAppRoleWithOptions(String agentId, String roleId, AddMemberToAppRoleRequest request, AddMemberToAppRoleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeVersion)) {
            body.put("scopeVersion", request.scopeVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
        return TeaModel.toModel(this.doROARequest("AddMemberToAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/members", "json", req, runtime), new AddMemberToAppRoleResponse());
    }

    public ListAppRoleScopesResponse listAppRoleScopes(String agentId, ListAppRoleScopesRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListAppRoleScopesHeaders headers = new ListAppRoleScopesHeaders();
        return this.listAppRoleScopesWithOptions(agentId, request, headers, runtime);
    }

    public ListAppRoleScopesResponse listAppRoleScopesWithOptions(String agentId, ListAppRoleScopesRequest request, ListAppRoleScopesHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.nextToken)) {
            query.put("nextToken", request.nextToken);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.size)) {
            query.put("size", request.size);
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
        return TeaModel.toModel(this.doROARequest("ListAppRoleScopes", "microApp_1.0", "HTTP", "GET", "AK", "/v1.0/microApp/apps/" + agentId + "/roles", "json", req, runtime), new ListAppRoleScopesResponse());
    }

    public AddAppToWorkBenchGroupResponse addAppToWorkBenchGroup(String agentId, AddAppToWorkBenchGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        AddAppToWorkBenchGroupHeaders headers = new AddAppToWorkBenchGroupHeaders();
        return this.addAppToWorkBenchGroupWithOptions(agentId, request, headers, runtime);
    }

    public AddAppToWorkBenchGroupResponse addAppToWorkBenchGroupWithOptions(String agentId, AddAppToWorkBenchGroupRequest request, AddAppToWorkBenchGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            body.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            body.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.componentId)) {
            body.put("componentId", request.componentId);
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
        return TeaModel.toModel(this.doROARequest("AddAppToWorkBenchGroup", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/addToWorkBenchGroup", "json", req, runtime), new AddAppToWorkBenchGroupResponse());
    }

    public RebuildRoleScopeForAppRoleResponse rebuildRoleScopeForAppRole(String agentId, String roleId, RebuildRoleScopeForAppRoleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RebuildRoleScopeForAppRoleHeaders headers = new RebuildRoleScopeForAppRoleHeaders();
        return this.rebuildRoleScopeForAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    public RebuildRoleScopeForAppRoleResponse rebuildRoleScopeForAppRoleWithOptions(String agentId, String roleId, RebuildRoleScopeForAppRoleRequest request, RebuildRoleScopeForAppRoleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeVersion)) {
            body.put("scopeVersion", request.scopeVersion);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.scopeType)) {
            body.put("scopeType", request.scopeType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIdList)) {
            body.put("deptIdList", request.deptIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userIdList)) {
            body.put("userIdList", request.userIdList);
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
        return TeaModel.toModel(this.doROARequest("RebuildRoleScopeForAppRole", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "/scopes/rebuild", "json", req, runtime), new RebuildRoleScopeForAppRoleResponse());
    }

    public RemoveApaasAppResponse removeApaasApp(RemoveApaasAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        RemoveApaasAppHeaders headers = new RemoveApaasAppHeaders();
        return this.removeApaasAppWithOptions(request, headers, runtime);
    }

    public RemoveApaasAppResponse removeApaasAppWithOptions(RemoveApaasAppRequest request, RemoveApaasAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizAppId)) {
            body.put("bizAppId", request.bizAppId);
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
        return TeaModel.toModel(this.doROARequest("RemoveApaasApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apaasApps/remove", "json", req, runtime), new RemoveApaasAppResponse());
    }

    public DeleteAppRoleResponse deleteAppRole(String agentId, String roleId, DeleteAppRoleRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteAppRoleHeaders headers = new DeleteAppRoleHeaders();
        return this.deleteAppRoleWithOptions(agentId, roleId, request, headers, runtime);
    }

    public DeleteAppRoleResponse deleteAppRoleWithOptions(String agentId, String roleId, DeleteAppRoleRequest request, DeleteAppRoleHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            query.put("opUserId", request.opUserId);
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
        return TeaModel.toModel(this.doROARequest("DeleteAppRole", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "", "json", req, runtime), new DeleteAppRoleResponse());
    }

    public CreateApaasAppResponse createApaasApp(CreateApaasAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        CreateApaasAppHeaders headers = new CreateApaasAppHeaders();
        return this.createApaasAppWithOptions(request, headers, runtime);
    }

    public CreateApaasAppResponse createApaasAppWithOptions(CreateApaasAppRequest request, CreateApaasAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.appName)) {
            body.put("appName", request.appName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appDesc)) {
            body.put("appDesc", request.appDesc);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.appIcon)) {
            body.put("appIcon", request.appIcon);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageLink)) {
            body.put("homepageLink", request.homepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageLink)) {
            body.put("pcHomepageLink", request.pcHomepageLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ompLink)) {
            body.put("ompLink", request.ompLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.homepageEditLink)) {
            body.put("homepageEditLink", request.homepageEditLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.pcHomepageEditLink)) {
            body.put("pcHomepageEditLink", request.pcHomepageEditLink);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.bizAppId)) {
            body.put("bizAppId", request.bizAppId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateKey)) {
            body.put("templateKey", request.templateKey);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isShortCut)) {
            body.put("isShortCut", request.isShortCut);
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
        return TeaModel.toModel(this.doROARequest("CreateApaasApp", "microApp_1.0", "HTTP", "POST", "AK", "/v1.0/microApp/apaasApps", "json", req, runtime), new CreateApaasAppResponse());
    }

    public DeleteInnerAppResponse deleteInnerApp(String agentId, DeleteInnerAppRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        DeleteInnerAppHeaders headers = new DeleteInnerAppHeaders();
        return this.deleteInnerAppWithOptions(agentId, request, headers, runtime);
    }

    public DeleteInnerAppResponse deleteInnerAppWithOptions(String agentId, DeleteInnerAppRequest request, DeleteInnerAppHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            query.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            query.put("ecologicalCorpId", request.ecologicalCorpId);
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
        return TeaModel.toModel(this.doROARequest("DeleteInnerApp", "microApp_1.0", "HTTP", "DELETE", "AK", "/v1.0/microApp/apps/" + agentId + "", "json", req, runtime), new DeleteInnerAppResponse());
    }

    public UpdateAppRoleInfoResponse updateAppRoleInfo(String agentId, String roleId, UpdateAppRoleInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateAppRoleInfoHeaders headers = new UpdateAppRoleInfoHeaders();
        return this.updateAppRoleInfoWithOptions(agentId, roleId, request, headers, runtime);
    }

    public UpdateAppRoleInfoResponse updateAppRoleInfoWithOptions(String agentId, String roleId, UpdateAppRoleInfoRequest request, UpdateAppRoleInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUserId)) {
            body.put("opUserId", request.opUserId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.newRoleName)) {
            body.put("newRoleName", request.newRoleName);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.canManageRole)) {
            body.put("canManageRole", request.canManageRole);
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
        return TeaModel.toModel(this.doROARequest("UpdateAppRoleInfo", "microApp_1.0", "HTTP", "PUT", "AK", "/v1.0/microApp/apps/" + agentId + "/roles/" + roleId + "", "json", req, runtime), new UpdateAppRoleInfoResponse());
    }
}
