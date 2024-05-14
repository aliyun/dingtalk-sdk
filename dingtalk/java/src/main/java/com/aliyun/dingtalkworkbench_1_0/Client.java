// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkworkbench_1_0.models.*;

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
     * @summary 批量添加最近使用记录
     *
     * @param request AddRecentUserAppListRequest
     * @param headers AddRecentUserAppListHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return AddRecentUserAppListResponse
     */
    public AddRecentUserAppListResponse addRecentUserAppListWithOptions(AddRecentUserAppListRequest request, AddRecentUserAppListHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.corpId)) {
            body.put("corpId", request.corpId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.usedAppDetailList)) {
            body.put("usedAppDetailList", request.usedAppDetailList);
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
            new TeaPair("action", "AddRecentUserAppList"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/components/recentUsed/batch"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new AddRecentUserAppListResponse());
    }

    /**
     * @summary 批量添加最近使用记录
     *
     * @param request AddRecentUserAppListRequest
     * @return AddRecentUserAppListResponse
     */
    public AddRecentUserAppListResponse addRecentUserAppList(AddRecentUserAppListRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        AddRecentUserAppListHeaders headers = new AddRecentUserAppListHeaders();
        return this.addRecentUserAppListWithOptions(request, headers, runtime);
    }

    /**
     * @summary 查询自定义工作台
     *
     * @param headers GetDingPortalDetailHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetDingPortalDetailResponse
     */
    public GetDingPortalDetailResponse getDingPortalDetailWithOptions(String appUuid, GetDingPortalDetailHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetDingPortalDetail"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/dingPortals/" + appUuid + ""),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetDingPortalDetailResponse());
    }

    /**
     * @summary 查询自定义工作台
     *
     * @return GetDingPortalDetailResponse
     */
    public GetDingPortalDetailResponse getDingPortalDetail(String appUuid) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetDingPortalDetailHeaders headers = new GetDingPortalDetailHeaders();
        return this.getDingPortalDetailWithOptions(appUuid, headers, runtime);
    }

    /**
     * @summary 获取工作台插件的权限点
     *
     * @param request GetPluginPermissionPointRequest
     * @param headers GetPluginPermissionPointHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPluginPermissionPointResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetPluginPermissionPoint"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/plugins/permissions"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPluginPermissionPointResponse());
    }

    /**
     * @summary 获取工作台插件的权限点
     *
     * @param request GetPluginPermissionPointRequest
     * @return GetPluginPermissionPointResponse
     */
    public GetPluginPermissionPointResponse getPluginPermissionPoint(GetPluginPermissionPointRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPluginPermissionPointHeaders headers = new GetPluginPermissionPointHeaders();
        return this.getPluginPermissionPointWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取插件的校验规则
     *
     * @param request GetPluginRuleCheckInfoRequest
     * @param headers GetPluginRuleCheckInfoHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return GetPluginRuleCheckInfoResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "GetPluginRuleCheckInfo"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/plugins/validationRules"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new GetPluginRuleCheckInfoResponse());
    }

    /**
     * @summary 获取插件的校验规则
     *
     * @param request GetPluginRuleCheckInfoRequest
     * @return GetPluginRuleCheckInfoResponse
     */
    public GetPluginRuleCheckInfoResponse getPluginRuleCheckInfo(GetPluginRuleCheckInfoRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        GetPluginRuleCheckInfoHeaders headers = new GetPluginRuleCheckInfoHeaders();
        return this.getPluginRuleCheckInfoWithOptions(request, headers, runtime);
    }

    /**
     * @summary 获取工作台分组列表
     *
     * @param request ListWorkBenchGroupRequest
     * @param headers ListWorkBenchGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ListWorkBenchGroupResponse
     */
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "ListWorkBenchGroup"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/groups"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ListWorkBenchGroupResponse());
    }

    /**
     * @summary 获取工作台分组列表
     *
     * @param request ListWorkBenchGroupRequest
     * @return ListWorkBenchGroupResponse
     */
    public ListWorkBenchGroupResponse listWorkBenchGroup(ListWorkBenchGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ListWorkBenchGroupHeaders headers = new ListWorkBenchGroupHeaders();
        return this.listWorkBenchGroupWithOptions(request, headers, runtime);
    }

    /**
     * @summary 工作台支持数字红点
     *
     * @param request ModifyWorkbenchBadgeRequest
     * @param headers ModifyWorkbenchBadgeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return ModifyWorkbenchBadgeResponse
     */
    public ModifyWorkbenchBadgeResponse modifyWorkbenchBadgeWithOptions(ModifyWorkbenchBadgeRequest request, ModifyWorkbenchBadgeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizIdList)) {
            body.put("bizIdList", request.bizIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.isAdded)) {
            body.put("isAdded", request.isAdded);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.modifyMode)) {
            body.put("modifyMode", request.modifyMode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redDotRelationId)) {
            body.put("redDotRelationId", request.redDotRelationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redDotType)) {
            body.put("redDotType", request.redDotType);
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
            new TeaPair("action", "ModifyWorkbenchBadge"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/badges/modify"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new ModifyWorkbenchBadgeResponse());
    }

    /**
     * @summary 工作台支持数字红点
     *
     * @param request ModifyWorkbenchBadgeRequest
     * @return ModifyWorkbenchBadgeResponse
     */
    public ModifyWorkbenchBadgeResponse modifyWorkbenchBadge(ModifyWorkbenchBadgeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        ModifyWorkbenchBadgeHeaders headers = new ModifyWorkbenchBadgeHeaders();
        return this.modifyWorkbenchBadgeWithOptions(request, headers, runtime);
    }

    /**
     * @summary 工作台组件授权范围查询
     *
     * @param headers QueryComponentScopesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryComponentScopesResponse
     */
    public QueryComponentScopesResponse queryComponentScopesWithOptions(String componentId, QueryComponentScopesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryComponentScopes"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/components/" + componentId + "/scopes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryComponentScopesResponse());
    }

    /**
     * @summary 工作台组件授权范围查询
     *
     * @return QueryComponentScopesResponse
     */
    public QueryComponentScopesResponse queryComponentScopes(String componentId) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
        return this.queryComponentScopesWithOptions(componentId, headers, runtime);
    }

    /**
     * @summary 查询快捷方式可见范围
     *
     * @param headers QueryShortcutScopesHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryShortcutScopesResponse
     */
    public QueryShortcutScopesResponse queryShortcutScopesWithOptions(String shortcutKey, QueryShortcutScopesHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "QueryShortcutScopes"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes"),
            new TeaPair("method", "GET"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryShortcutScopesResponse());
    }

    /**
     * @summary 查询快捷方式可见范围
     *
     * @return QueryShortcutScopesResponse
     */
    public QueryShortcutScopesResponse queryShortcutScopes(String shortcutKey) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
        return this.queryShortcutScopesWithOptions(shortcutKey, headers, runtime);
    }

    /**
     * @summary 工作台数字红点支持撤销已被删除的资源
     *
     * @param request UndoDeletionRequest
     * @param headers UndoDeletionHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UndoDeletionResponse
     */
    public UndoDeletionResponse undoDeletionWithOptions(UndoDeletionRequest request, UndoDeletionHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.bizIdList)) {
            body.put("bizIdList", request.bizIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redDotRelationId)) {
            body.put("redDotRelationId", request.redDotRelationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.redDotType)) {
            body.put("redDotType", request.redDotType);
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
            new TeaPair("action", "UndoDeletion"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/badges/undoDeleted"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UndoDeletionResponse());
    }

    /**
     * @summary 工作台数字红点支持撤销已被删除的资源
     *
     * @param request UndoDeletionRequest
     * @return UndoDeletionResponse
     */
    public UndoDeletionResponse undoDeletion(UndoDeletionRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UndoDeletionHeaders headers = new UndoDeletionHeaders();
        return this.undoDeletionWithOptions(request, headers, runtime);
    }

    /**
     * @summary 更新自定义工作台页面可见性
     *
     * @param request UpdateDingPortalPageScopeRequest
     * @param headers UpdateDingPortalPageScopeHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UpdateDingPortalPageScopeResponse
     */
    public UpdateDingPortalPageScopeResponse updateDingPortalPageScopeWithOptions(String pageUuid, String appUuid, UpdateDingPortalPageScopeRequest request, UpdateDingPortalPageScopeHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
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
        com.aliyun.teaopenapi.models.Params params = com.aliyun.teaopenapi.models.Params.build(TeaConverter.buildMap(
            new TeaPair("action", "UpdateDingPortalPageScope"),
            new TeaPair("version", "workbench_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/workbench/dingPortals/" + appUuid + "/pageScopes/" + pageUuid + ""),
            new TeaPair("method", "PUT"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "json"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UpdateDingPortalPageScopeResponse());
    }

    /**
     * @summary 更新自定义工作台页面可见性
     *
     * @param request UpdateDingPortalPageScopeRequest
     * @return UpdateDingPortalPageScopeResponse
     */
    public UpdateDingPortalPageScopeResponse updateDingPortalPageScope(String pageUuid, String appUuid, UpdateDingPortalPageScopeRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UpdateDingPortalPageScopeHeaders headers = new UpdateDingPortalPageScopeHeaders();
        return this.updateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
    }
}
