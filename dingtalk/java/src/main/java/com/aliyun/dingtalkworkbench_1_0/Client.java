// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkworkbench_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    public GetDingPortalDetailResponse getDingPortalDetail(String appUuid) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDingPortalDetailHeaders headers = new GetDingPortalDetailHeaders();
        return this.getDingPortalDetailWithOptions(appUuid, headers, runtime);
    }

    public GetDingPortalDetailResponse getDingPortalDetailWithOptions(String appUuid, GetDingPortalDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        appUuid = com.aliyun.openapiutil.Client.getEncodeParam(appUuid);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("GetDingPortalDetail", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/dingPortals/" + appUuid + "", "json", req, runtime), new GetDingPortalDetailResponse());
    }

    public GetPluginPermissionPointResponse getPluginPermissionPoint(GetPluginPermissionPointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPluginPermissionPointHeaders headers = new GetPluginPermissionPointHeaders();
        return this.getPluginPermissionPointWithOptions(request, headers, runtime);
    }

    public GetPluginPermissionPointResponse getPluginPermissionPointWithOptions(GetPluginPermissionPointRequest request, GetPluginPermissionPointHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetPluginPermissionPoint", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/permissions", "json", req, runtime), new GetPluginPermissionPointResponse());
    }

    public GetPluginRuleCheckInfoResponse getPluginRuleCheckInfo(GetPluginRuleCheckInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPluginRuleCheckInfoHeaders headers = new GetPluginRuleCheckInfoHeaders();
        return this.getPluginRuleCheckInfoWithOptions(request, headers, runtime);
    }

    public GetPluginRuleCheckInfoResponse getPluginRuleCheckInfoWithOptions(GetPluginRuleCheckInfoRequest request, GetPluginRuleCheckInfoHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders),
            new TeaPair("query", com.aliyun.openapiutil.Client.query(query))
        ));
        return TeaModel.toModel(this.doROARequest("GetPluginRuleCheckInfo", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/plugins/validationRules", "json", req, runtime), new GetPluginRuleCheckInfoResponse());
    }

    public ListWorkBenchGroupResponse listWorkBenchGroup(ListWorkBenchGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListWorkBenchGroupHeaders headers = new ListWorkBenchGroupHeaders();
        return this.listWorkBenchGroupWithOptions(request, headers, runtime);
    }

    public ListWorkBenchGroupResponse listWorkBenchGroupWithOptions(ListWorkBenchGroupRequest request, ListWorkBenchGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> query = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.ecologicalCorpId)) {
            query.put("ecologicalCorpId", request.ecologicalCorpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.groupType)) {
            query.put("groupType", request.groupType);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.opUnionId)) {
            query.put("opUnionId", request.opUnionId);
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
        return TeaModel.toModel(this.doROARequest("ListWorkBenchGroup", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/groups", "json", req, runtime), new ListWorkBenchGroupResponse());
    }

    public QueryComponentScopesResponse queryComponentScopes(String componentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
        return this.queryComponentScopesWithOptions(componentId, headers, runtime);
    }

    public QueryComponentScopesResponse queryComponentScopesWithOptions(String componentId, QueryComponentScopesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        componentId = com.aliyun.openapiutil.Client.getEncodeParam(componentId);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryComponentScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/components/" + componentId + "/scopes", "json", req, runtime), new QueryComponentScopesResponse());
    }

    public QueryShortcutScopesResponse queryShortcutScopes(String shortcutKey) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
        return this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
    }

    public QueryShortcutScopesResponse queryShortcutScopesWithOptions(String shortcutKey, QueryShortcutScopesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        shortcutKey = com.aliyun.openapiutil.Client.getEncodeParam(shortcutKey);
        java.util.Map<String, String> realHeaders = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(headers.commonHeaders)) {
            realHeaders = headers.commonHeaders;
        }

        if (!com.aliyun.teautil.Common.isUnset(headers.xAcsDingtalkAccessToken)) {
            realHeaders.put("x-acs-dingtalk-access-token", com.aliyun.teautil.Common.toJSONString(headers.xAcsDingtalkAccessToken));
        }

        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("headers", realHeaders)
        ));
        return TeaModel.toModel(this.doROARequest("QueryShortcutScopes", "workbench_1.0", "HTTP", "GET", "AK", "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes", "json", req, runtime), new QueryShortcutScopesResponse());
    }

    public UpdateDingPortalPageScopeResponse updateDingPortalPageScope(String pageUuid, String appUuid, UpdateDingPortalPageScopeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateDingPortalPageScopeHeaders headers = new UpdateDingPortalPageScopeHeaders();
        return this.updateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
    }

    public UpdateDingPortalPageScopeResponse updateDingPortalPageScopeWithOptions(String pageUuid, String appUuid, UpdateDingPortalPageScopeRequest request, UpdateDingPortalPageScopeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        pageUuid = com.aliyun.openapiutil.Client.getEncodeParam(pageUuid);
        appUuid = com.aliyun.openapiutil.Client.getEncodeParam(appUuid);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.allVisible)) {
            body.put("allVisible", request.allVisible);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.deptIds)) {
            body.put("deptIds", request.deptIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.roleIds)) {
            body.put("roleIds", request.roleIds);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.userids)) {
            body.put("userids", request.userids);
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
        return TeaModel.toModel(this.doROARequest("UpdateDingPortalPageScope", "workbench_1.0", "HTTP", "PUT", "AK", "/v1.0/workbench/dingPortals/" + appUuid + "/pageScopes/" + pageUuid + "", "none", req, runtime), new UpdateDingPortalPageScopeResponse());
    }
}
