// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcool_app_1_0;

import com.aliyun.tea.*;
import com.aliyun.dingtalkcool_app_1_0.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        com.aliyun.gateway.dingtalk.Client gatewayClient = new com.aliyun.gateway.dingtalk.Client();
        this._spi = gatewayClient;
        this._endpointRule = "";
        if (com.aliyun.teautil.Common.empty(_endpoint)) {
            this._endpoint = "api.dingtalk.com";
        }

    }


    /**
     * <b>summary</b> : 
     * <p>群酷应用排序</p>
     * 
     * @param request InstallCoolAppOrderToGroupRequest
     * @param headers InstallCoolAppOrderToGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InstallCoolAppOrderToGroupResponse
     */
    public InstallCoolAppOrderToGroupResponse installCoolAppOrderToGroupWithOptions(InstallCoolAppOrderToGroupRequest request, InstallCoolAppOrderToGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.sortedPluginIdList)) {
            body.put("sortedPluginIdList", request.sortedPluginIdList);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.unsortedPluginIdList)) {
            body.put("unsortedPluginIdList", request.unsortedPluginIdList);
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
            new TeaPair("action", "InstallCoolAppOrderToGroup"),
            new TeaPair("version", "coolApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/coolApp/shortcuts/plugins/order"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InstallCoolAppOrderToGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>群酷应用排序</p>
     * 
     * @param request InstallCoolAppOrderToGroupRequest
     * @return InstallCoolAppOrderToGroupResponse
     */
    public InstallCoolAppOrderToGroupResponse installCoolAppOrderToGroup(InstallCoolAppOrderToGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InstallCoolAppOrderToGroupHeaders headers = new InstallCoolAppOrderToGroupHeaders();
        return this.installCoolAppOrderToGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>安装酷应用到群</p>
     * 
     * @param request InstallCoolAppToGroupRequest
     * @param headers InstallCoolAppToGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return InstallCoolAppToGroupResponse
     */
    public InstallCoolAppToGroupResponse installCoolAppToGroupWithOptions(InstallCoolAppToGroupRequest request, InstallCoolAppToGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateCoolAppCode)) {
            body.put("operateCoolAppCode", request.operateCoolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "InstallCoolAppToGroup"),
            new TeaPair("version", "coolApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/coolApp/shortcuts/plugins/install"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new InstallCoolAppToGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>安装酷应用到群</p>
     * 
     * @param request InstallCoolAppToGroupRequest
     * @return InstallCoolAppToGroupResponse
     */
    public InstallCoolAppToGroupResponse installCoolAppToGroup(InstallCoolAppToGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        InstallCoolAppToGroupHeaders headers = new InstallCoolAppToGroupHeaders();
        return this.installCoolAppToGroupWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>查询群插件栏</p>
     * 
     * @param request QueryCoolAppShortcutOrderRequest
     * @param headers QueryCoolAppShortcutOrderHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return QueryCoolAppShortcutOrderResponse
     */
    public QueryCoolAppShortcutOrderResponse queryCoolAppShortcutOrderWithOptions(QueryCoolAppShortcutOrderRequest request, QueryCoolAppShortcutOrderHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "QueryCoolAppShortcutOrder"),
            new TeaPair("version", "coolApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/coolApp/shortcuts/plugins/query"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new QueryCoolAppShortcutOrderResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>查询群插件栏</p>
     * 
     * @param request QueryCoolAppShortcutOrderRequest
     * @return QueryCoolAppShortcutOrderResponse
     */
    public QueryCoolAppShortcutOrderResponse queryCoolAppShortcutOrder(QueryCoolAppShortcutOrderRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        QueryCoolAppShortcutOrderHeaders headers = new QueryCoolAppShortcutOrderHeaders();
        return this.queryCoolAppShortcutOrderWithOptions(request, headers, runtime);
    }

    /**
     * <b>summary</b> : 
     * <p>从群内卸载酷应用</p>
     * 
     * @param request UninstallCoolAppFromGroupRequest
     * @param headers UninstallCoolAppFromGroupHeaders
     * @param runtime runtime options for this request RuntimeOptions
     * @return UninstallCoolAppFromGroupResponse
     */
    public UninstallCoolAppFromGroupResponse uninstallCoolAppFromGroupWithOptions(UninstallCoolAppFromGroupRequest request, UninstallCoolAppFromGroupHeaders headers, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, Object> body = new java.util.HashMap<>();
        if (!com.aliyun.teautil.Common.isUnset(request.conversationId)) {
            body.put("conversationId", request.conversationId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operateCoolAppCode)) {
            body.put("operateCoolAppCode", request.operateCoolAppCode);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.operatorId)) {
            body.put("operatorId", request.operatorId);
        }

        if (!com.aliyun.teautil.Common.isUnset(request.templateId)) {
            body.put("templateId", request.templateId);
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
            new TeaPair("action", "UninstallCoolAppFromGroup"),
            new TeaPair("version", "coolApp_1.0"),
            new TeaPair("protocol", "HTTP"),
            new TeaPair("pathname", "/v1.0/coolApp/shortcuts/plugins/uninstall"),
            new TeaPair("method", "POST"),
            new TeaPair("authType", "AK"),
            new TeaPair("style", "ROA"),
            new TeaPair("reqBodyType", "none"),
            new TeaPair("bodyType", "json")
        ));
        return TeaModel.toModel(this.execute(params, req, runtime), new UninstallCoolAppFromGroupResponse());
    }

    /**
     * <b>summary</b> : 
     * <p>从群内卸载酷应用</p>
     * 
     * @param request UninstallCoolAppFromGroupRequest
     * @return UninstallCoolAppFromGroupResponse
     */
    public UninstallCoolAppFromGroupResponse uninstallCoolAppFromGroup(UninstallCoolAppFromGroupRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        UninstallCoolAppFromGroupHeaders headers = new UninstallCoolAppFromGroupHeaders();
        return this.uninstallCoolAppFromGroupWithOptions(request, headers, runtime);
    }
}
