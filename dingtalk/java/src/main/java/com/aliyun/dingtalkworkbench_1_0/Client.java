// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkworkbench_1_0.models.*;
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


    public ListWorkBenchGroupResponse listWorkBenchGroup(ListWorkBenchGroupRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        ListWorkBenchGroupHeaders headers = new ListWorkBenchGroupHeaders();
        return this.listWorkBenchGroupWithOptions(request, headers, runtime);
    }

    public ListWorkBenchGroupResponse listWorkBenchGroupWithOptions(ListWorkBenchGroupRequest request, ListWorkBenchGroupHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            query.put("opUnionId", request.opUnionId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            query.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            query.put("groupType", request.groupType);
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
        return TeaModel.toModel(this.doROARequest("ListWorkBenchGroup", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/groups", "json", req, runtime), new ListWorkBenchGroupResponse());
    }

    public QueryComponentScopesResponse queryComponentScopes(String componentId) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
        return this.queryComponentScopesWithOptions(componentId, headers, runtime);
    }

    public QueryComponentScopesResponse queryComponentScopesWithOptions(String componentId, QueryComponentScopesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryComponentScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/components/" + componentId + "/scopes", "json", req, runtime), new QueryComponentScopesResponse());
    }

    public QueryShortcutScopesResponse queryShortcutScopes(String shortcutKey) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
        return this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
    }

    public QueryShortcutScopesResponse queryShortcutScopesWithOptions(String shortcutKey, QueryShortcutScopesHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("QueryShortcutScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes", "json", req, runtime), new QueryShortcutScopesResponse());
    }

    public GetPluginPermissionPointResponse getPluginPermissionPoint(GetPluginPermissionPointRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetPluginPermissionPointHeaders headers = new GetPluginPermissionPointHeaders();
        return this.getPluginPermissionPointWithOptions(request, headers, runtime);
    }

    public GetPluginPermissionPointResponse getPluginPermissionPointWithOptions(GetPluginPermissionPointRequest request, GetPluginPermissionPointHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
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
        return TeaModel.toModel(this.doROARequest("GetPluginPermissionPoint", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/permissions", "json", req, runtime), new GetPluginPermissionPointResponse());
    }

    public GetPluginRuleCheckInfoResponse getPluginRuleCheckInfo(GetPluginRuleCheckInfoRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetPluginRuleCheckInfoHeaders headers = new GetPluginRuleCheckInfoHeaders();
        return this.getPluginRuleCheckInfoWithOptions(request, headers, runtime);
    }

    public GetPluginRuleCheckInfoResponse getPluginRuleCheckInfoWithOptions(GetPluginRuleCheckInfoRequest request, GetPluginRuleCheckInfoHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.miniAppId)) {
            query.put("miniAppId", request.miniAppId);
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
        return TeaModel.toModel(this.doROARequest("GetPluginRuleCheckInfo", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/validationRules", "json", req, runtime), new GetPluginRuleCheckInfoResponse());
    }

    public UpdateDingPortalPageScopeResponse updateDingPortalPageScope(String pageUuid, String appUuid, UpdateDingPortalPageScopeRequest request) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        UpdateDingPortalPageScopeHeaders headers = new UpdateDingPortalPageScopeHeaders();
        return this.updateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
    }

    public UpdateDingPortalPageScopeResponse updateDingPortalPageScopeWithOptions(String pageUuid, String appUuid, UpdateDingPortalPageScopeRequest request, UpdateDingPortalPageScopeHeaders headers, RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.userids)) {
            body.put("userids", request.userids);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleIds)) {
            body.put("roleIds", request.roleIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.allVisible)) {
            body.put("allVisible", request.allVisible);
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
        return TeaModel.toModel(this.doROARequest("UpdateDingPortalPageScope", "workbench_1.0", "HTTP", "PUT", "AK", "/v1.0/workbench/dingPortals/" + appUuid + "/pageScopes/" + pageUuid + "", "none", req, runtime), new UpdateDingPortalPageScopeResponse());
    }

    public GetDingPortalDetailResponse getDingPortalDetail(String appUuid) throws Exception {
        RuntimeOptions runtime = new RuntimeOptions();
        GetDingPortalDetailHeaders headers = new GetDingPortalDetailHeaders();
        return this.getDingPortalDetailWithOptions(appUuid, headers, runtime);
    }

    public GetDingPortalDetailResponse getDingPortalDetailWithOptions(String appUuid, GetDingPortalDetailHeaders headers, RuntimeOptions runtime) throws Exception {
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
        return TeaModel.toModel(this.doROARequest("GetDingPortalDetail", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/dingPortals/" + appUuid + "", "json", req, runtime), new GetDingPortalDetailResponse());
    }
}
