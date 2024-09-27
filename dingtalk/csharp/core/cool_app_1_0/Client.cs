// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcool_app_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcool_app_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群酷应用排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppOrderToGroupRequest
        /// </param>
        /// <param name="headers">
        /// InstallCoolAppOrderToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppOrderToGroupResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppOrderToGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群酷应用排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppOrderToGroupRequest
        /// </param>
        /// <param name="headers">
        /// InstallCoolAppOrderToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppOrderToGroupResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/order",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppOrderToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群酷应用排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppOrderToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppOrderToGroupResponse
        /// </returns>
        public InstallCoolAppOrderToGroupResponse InstallCoolAppOrderToGroup(InstallCoolAppOrderToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppOrderToGroupHeaders headers = new InstallCoolAppOrderToGroupHeaders();
            return InstallCoolAppOrderToGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>群酷应用排序</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppOrderToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppOrderToGroupResponse
        /// </returns>
        public async Task<InstallCoolAppOrderToGroupResponse> InstallCoolAppOrderToGroupAsync(InstallCoolAppOrderToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppOrderToGroupHeaders headers = new InstallCoolAppOrderToGroupHeaders();
            return await InstallCoolAppOrderToGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用到群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppToGroupRequest
        /// </param>
        /// <param name="headers">
        /// InstallCoolAppToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppToGroupResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppToGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用到群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppToGroupRequest
        /// </param>
        /// <param name="headers">
        /// InstallCoolAppToGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppToGroupResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppToGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用到群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppToGroupResponse
        /// </returns>
        public InstallCoolAppToGroupResponse InstallCoolAppToGroup(InstallCoolAppToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppToGroupHeaders headers = new InstallCoolAppToGroupHeaders();
            return InstallCoolAppToGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用到群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppToGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppToGroupResponse
        /// </returns>
        public async Task<InstallCoolAppToGroupResponse> InstallCoolAppToGroupAsync(InstallCoolAppToGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppToGroupHeaders headers = new InstallCoolAppToGroupHeaders();
            return await InstallCoolAppToGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群插件栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCoolAppShortcutOrderRequest
        /// </param>
        /// <param name="headers">
        /// QueryCoolAppShortcutOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCoolAppShortcutOrderResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCoolAppShortcutOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群插件栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCoolAppShortcutOrderRequest
        /// </param>
        /// <param name="headers">
        /// QueryCoolAppShortcutOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCoolAppShortcutOrderResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCoolAppShortcutOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群插件栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCoolAppShortcutOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCoolAppShortcutOrderResponse
        /// </returns>
        public QueryCoolAppShortcutOrderResponse QueryCoolAppShortcutOrder(QueryCoolAppShortcutOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCoolAppShortcutOrderHeaders headers = new QueryCoolAppShortcutOrderHeaders();
            return QueryCoolAppShortcutOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询群插件栏</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryCoolAppShortcutOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCoolAppShortcutOrderResponse
        /// </returns>
        public async Task<QueryCoolAppShortcutOrderResponse> QueryCoolAppShortcutOrderAsync(QueryCoolAppShortcutOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryCoolAppShortcutOrderHeaders headers = new QueryCoolAppShortcutOrderHeaders();
            return await QueryCoolAppShortcutOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从群内卸载酷应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallCoolAppFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// UninstallCoolAppFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallCoolAppFromGroupResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallCoolAppFromGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从群内卸载酷应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallCoolAppFromGroupRequest
        /// </param>
        /// <param name="headers">
        /// UninstallCoolAppFromGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallCoolAppFromGroupResponse
        /// </returns>
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
                Version = "coolApp_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolApp/shortcuts/plugins/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallCoolAppFromGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从群内卸载酷应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallCoolAppFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallCoolAppFromGroupResponse
        /// </returns>
        public UninstallCoolAppFromGroupResponse UninstallCoolAppFromGroup(UninstallCoolAppFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallCoolAppFromGroupHeaders headers = new UninstallCoolAppFromGroupHeaders();
            return UninstallCoolAppFromGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从群内卸载酷应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UninstallCoolAppFromGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallCoolAppFromGroupResponse
        /// </returns>
        public async Task<UninstallCoolAppFromGroupResponse> UninstallCoolAppFromGroupAsync(UninstallCoolAppFromGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UninstallCoolAppFromGroupHeaders headers = new UninstallCoolAppFromGroupHeaders();
            return await UninstallCoolAppFromGroupWithOptionsAsync(request, headers, runtime);
        }

    }
}
