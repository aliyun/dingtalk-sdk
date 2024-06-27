// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkdpaas_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkdpaas_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 群酷应用排序
         *
         * @param request InstallCoolAppOrderToGroupRequest
         * @param headers InstallCoolAppOrderToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallCoolAppOrderToGroupResponse
         */
        public InstallCoolAppOrderToGroupResponse InstallCoolAppOrderToGroupWithOptions(InstallCoolAppOrderToGroupRequest request, InstallCoolAppOrderToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortedPluginIdList))
            {
                body["sortedPluginIdList"] = request.SortedPluginIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsortedPluginIdList))
            {
                body["unsortedPluginIdList"] = request.UnsortedPluginIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallCoolAppOrderToGroup",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppOrderToGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 群酷应用排序
         *
         * @param request InstallCoolAppOrderToGroupRequest
         * @param headers InstallCoolAppOrderToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallCoolAppOrderToGroupResponse
         */
        public async Task<InstallCoolAppOrderToGroupResponse> InstallCoolAppOrderToGroupWithOptionsAsync(InstallCoolAppOrderToGroupRequest request, InstallCoolAppOrderToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortedPluginIdList))
            {
                body["sortedPluginIdList"] = request.SortedPluginIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnsortedPluginIdList))
            {
                body["unsortedPluginIdList"] = request.UnsortedPluginIdList;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallCoolAppOrderToGroup",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppOrderToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 群酷应用排序
         *
         * @param request InstallCoolAppOrderToGroupRequest
         * @return InstallCoolAppOrderToGroupResponse
         */
        public InstallCoolAppOrderToGroupResponse InstallCoolAppOrderToGroup(InstallCoolAppOrderToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppOrderToGroupHeaders headers = new InstallCoolAppOrderToGroupHeaders();
            return InstallCoolAppOrderToGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 群酷应用排序
         *
         * @param request InstallCoolAppOrderToGroupRequest
         * @return InstallCoolAppOrderToGroupResponse
         */
        public async Task<InstallCoolAppOrderToGroupResponse> InstallCoolAppOrderToGroupAsync(InstallCoolAppOrderToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppOrderToGroupHeaders headers = new InstallCoolAppOrderToGroupHeaders();
            return await InstallCoolAppOrderToGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 安装酷应用到群
         *
         * @param request InstallCoolAppToGroupRequest
         * @param headers InstallCoolAppToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallCoolAppToGroupResponse
         */
        public InstallCoolAppToGroupResponse InstallCoolAppToGroupWithOptions(InstallCoolAppToGroupRequest request, InstallCoolAppToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCoolAppCode))
            {
                body["operateCoolAppCode"] = request.OperateCoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallCoolAppToGroup",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppToGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 安装酷应用到群
         *
         * @param request InstallCoolAppToGroupRequest
         * @param headers InstallCoolAppToGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallCoolAppToGroupResponse
         */
        public async Task<InstallCoolAppToGroupResponse> InstallCoolAppToGroupWithOptionsAsync(InstallCoolAppToGroupRequest request, InstallCoolAppToGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCoolAppCode))
            {
                body["operateCoolAppCode"] = request.OperateCoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallCoolAppToGroup",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 安装酷应用到群
         *
         * @param request InstallCoolAppToGroupRequest
         * @return InstallCoolAppToGroupResponse
         */
        public InstallCoolAppToGroupResponse InstallCoolAppToGroup(InstallCoolAppToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppToGroupHeaders headers = new InstallCoolAppToGroupHeaders();
            return InstallCoolAppToGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 安装酷应用到群
         *
         * @param request InstallCoolAppToGroupRequest
         * @return InstallCoolAppToGroupResponse
         */
        public async Task<InstallCoolAppToGroupResponse> InstallCoolAppToGroupAsync(InstallCoolAppToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppToGroupHeaders headers = new InstallCoolAppToGroupHeaders();
            return await InstallCoolAppToGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询群插件栏
         *
         * @param request QueryCoolAppShortcutOrderRequest
         * @param headers QueryCoolAppShortcutOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCoolAppShortcutOrderResponse
         */
        public QueryCoolAppShortcutOrderResponse QueryCoolAppShortcutOrderWithOptions(QueryCoolAppShortcutOrderRequest request, QueryCoolAppShortcutOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCoolAppShortcutOrder",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCoolAppShortcutOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询群插件栏
         *
         * @param request QueryCoolAppShortcutOrderRequest
         * @param headers QueryCoolAppShortcutOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryCoolAppShortcutOrderResponse
         */
        public async Task<QueryCoolAppShortcutOrderResponse> QueryCoolAppShortcutOrderWithOptionsAsync(QueryCoolAppShortcutOrderRequest request, QueryCoolAppShortcutOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCoolAppShortcutOrder",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCoolAppShortcutOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询群插件栏
         *
         * @param request QueryCoolAppShortcutOrderRequest
         * @return QueryCoolAppShortcutOrderResponse
         */
        public QueryCoolAppShortcutOrderResponse QueryCoolAppShortcutOrder(QueryCoolAppShortcutOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCoolAppShortcutOrderHeaders headers = new QueryCoolAppShortcutOrderHeaders();
            return QueryCoolAppShortcutOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询群插件栏
         *
         * @param request QueryCoolAppShortcutOrderRequest
         * @return QueryCoolAppShortcutOrderResponse
         */
        public async Task<QueryCoolAppShortcutOrderResponse> QueryCoolAppShortcutOrderAsync(QueryCoolAppShortcutOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCoolAppShortcutOrderHeaders headers = new QueryCoolAppShortcutOrderHeaders();
            return await QueryCoolAppShortcutOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 从群内卸载酷应用
         *
         * @param request UninstallCoolAppFromGroupRequest
         * @param headers UninstallCoolAppFromGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallCoolAppFromGroupResponse
         */
        public UninstallCoolAppFromGroupResponse UninstallCoolAppFromGroupWithOptions(UninstallCoolAppFromGroupRequest request, UninstallCoolAppFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCoolAppCode))
            {
                body["operateCoolAppCode"] = request.OperateCoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallCoolAppFromGroup",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallCoolAppFromGroupResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 从群内卸载酷应用
         *
         * @param request UninstallCoolAppFromGroupRequest
         * @param headers UninstallCoolAppFromGroupHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallCoolAppFromGroupResponse
         */
        public async Task<UninstallCoolAppFromGroupResponse> UninstallCoolAppFromGroupWithOptionsAsync(UninstallCoolAppFromGroupRequest request, UninstallCoolAppFromGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                body["conversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateCoolAppCode))
            {
                body["operateCoolAppCode"] = request.OperateCoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                body["templateId"] = request.TemplateId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsDingtalkAccessToken))
            {
                realHeaders["x-acs-dingtalk-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsDingtalkAccessToken);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallCoolAppFromGroup",
                Version = "dpaas_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/dpaas/coolApps/shortcuts/plugins/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallCoolAppFromGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 从群内卸载酷应用
         *
         * @param request UninstallCoolAppFromGroupRequest
         * @return UninstallCoolAppFromGroupResponse
         */
        public UninstallCoolAppFromGroupResponse UninstallCoolAppFromGroup(UninstallCoolAppFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallCoolAppFromGroupHeaders headers = new UninstallCoolAppFromGroupHeaders();
            return UninstallCoolAppFromGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 从群内卸载酷应用
         *
         * @param request UninstallCoolAppFromGroupRequest
         * @return UninstallCoolAppFromGroupResponse
         */
        public async Task<UninstallCoolAppFromGroupResponse> UninstallCoolAppFromGroupAsync(UninstallCoolAppFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallCoolAppFromGroupHeaders headers = new UninstallCoolAppFromGroupHeaders();
            return await UninstallCoolAppFromGroupWithOptionsAsync(request, headers, runtime);
        }

    }
}
