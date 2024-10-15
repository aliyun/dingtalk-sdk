// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkworkbench_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkworkbench_1_0
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


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加最近使用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecentUserAppListRequest
        /// </param>
        /// <param name="headers">
        /// AddRecentUserAppListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRecentUserAppListResponse
        /// </returns>
        public AddRecentUserAppListResponse AddRecentUserAppListWithOptions(AddRecentUserAppListRequest request, AddRecentUserAppListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedAppDetailList))
            {
                body["usedAppDetailList"] = request.UsedAppDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "AddRecentUserAppList",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/components/recentUsed/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecentUserAppListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加最近使用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecentUserAppListRequest
        /// </param>
        /// <param name="headers">
        /// AddRecentUserAppListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddRecentUserAppListResponse
        /// </returns>
        public async Task<AddRecentUserAppListResponse> AddRecentUserAppListWithOptionsAsync(AddRecentUserAppListRequest request, AddRecentUserAppListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsedAppDetailList))
            {
                body["usedAppDetailList"] = request.UsedAppDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "AddRecentUserAppList",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/components/recentUsed/batch",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddRecentUserAppListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加最近使用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecentUserAppListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRecentUserAppListResponse
        /// </returns>
        public AddRecentUserAppListResponse AddRecentUserAppList(AddRecentUserAppListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRecentUserAppListHeaders headers = new AddRecentUserAppListHeaders();
            return AddRecentUserAppListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量添加最近使用记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddRecentUserAppListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddRecentUserAppListResponse
        /// </returns>
        public async Task<AddRecentUserAppListResponse> AddRecentUserAppListAsync(AddRecentUserAppListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AddRecentUserAppListHeaders headers = new AddRecentUserAppListHeaders();
            return await AddRecentUserAppListWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义工作台</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDingPortalDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingPortalDetailResponse
        /// </returns>
        public GetDingPortalDetailResponse GetDingPortalDetailWithOptions(string appUuid, GetDingPortalDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDingPortalDetail",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/dingPortals/" + appUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingPortalDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义工作台</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetDingPortalDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDingPortalDetailResponse
        /// </returns>
        public async Task<GetDingPortalDetailResponse> GetDingPortalDetailWithOptionsAsync(string appUuid, GetDingPortalDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDingPortalDetail",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/dingPortals/" + appUuid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDingPortalDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义工作台</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDingPortalDetailResponse
        /// </returns>
        public GetDingPortalDetailResponse GetDingPortalDetail(string appUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingPortalDetailHeaders headers = new GetDingPortalDetailHeaders();
            return GetDingPortalDetailWithOptions(appUuid, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义工作台</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetDingPortalDetailResponse
        /// </returns>
        public async Task<GetDingPortalDetailResponse> GetDingPortalDetailAsync(string appUuid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetDingPortalDetailHeaders headers = new GetDingPortalDetailHeaders();
            return await GetDingPortalDetailWithOptionsAsync(appUuid, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台插件的权限点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginPermissionPointRequest
        /// </param>
        /// <param name="headers">
        /// GetPluginPermissionPointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPluginPermissionPointResponse
        /// </returns>
        public GetPluginPermissionPointResponse GetPluginPermissionPointWithOptions(GetPluginPermissionPointRequest request, GetPluginPermissionPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPluginPermissionPoint",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/plugins/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPluginPermissionPointResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台插件的权限点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginPermissionPointRequest
        /// </param>
        /// <param name="headers">
        /// GetPluginPermissionPointHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPluginPermissionPointResponse
        /// </returns>
        public async Task<GetPluginPermissionPointResponse> GetPluginPermissionPointWithOptionsAsync(GetPluginPermissionPointRequest request, GetPluginPermissionPointHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPluginPermissionPoint",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/plugins/permissions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPluginPermissionPointResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台插件的权限点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginPermissionPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPluginPermissionPointResponse
        /// </returns>
        public GetPluginPermissionPointResponse GetPluginPermissionPoint(GetPluginPermissionPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginPermissionPointHeaders headers = new GetPluginPermissionPointHeaders();
            return GetPluginPermissionPointWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台插件的权限点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginPermissionPointRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPluginPermissionPointResponse
        /// </returns>
        public async Task<GetPluginPermissionPointResponse> GetPluginPermissionPointAsync(GetPluginPermissionPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginPermissionPointHeaders headers = new GetPluginPermissionPointHeaders();
            return await GetPluginPermissionPointWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取插件的校验规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginRuleCheckInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPluginRuleCheckInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPluginRuleCheckInfoResponse
        /// </returns>
        public GetPluginRuleCheckInfoResponse GetPluginRuleCheckInfoWithOptions(GetPluginRuleCheckInfoRequest request, GetPluginRuleCheckInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPluginRuleCheckInfo",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/plugins/validationRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPluginRuleCheckInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取插件的校验规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginRuleCheckInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPluginRuleCheckInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPluginRuleCheckInfoResponse
        /// </returns>
        public async Task<GetPluginRuleCheckInfoResponse> GetPluginRuleCheckInfoWithOptionsAsync(GetPluginRuleCheckInfoRequest request, GetPluginRuleCheckInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MiniAppId))
            {
                query["miniAppId"] = request.MiniAppId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPluginRuleCheckInfo",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/plugins/validationRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPluginRuleCheckInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取插件的校验规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginRuleCheckInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPluginRuleCheckInfoResponse
        /// </returns>
        public GetPluginRuleCheckInfoResponse GetPluginRuleCheckInfo(GetPluginRuleCheckInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginRuleCheckInfoHeaders headers = new GetPluginRuleCheckInfoHeaders();
            return GetPluginRuleCheckInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取插件的校验规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPluginRuleCheckInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPluginRuleCheckInfoResponse
        /// </returns>
        public async Task<GetPluginRuleCheckInfoResponse> GetPluginRuleCheckInfoAsync(GetPluginRuleCheckInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPluginRuleCheckInfoHeaders headers = new GetPluginRuleCheckInfoHeaders();
            return await GetPluginRuleCheckInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkBenchGroupRequest
        /// </param>
        /// <param name="headers">
        /// ListWorkBenchGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkBenchGroupResponse
        /// </returns>
        public ListWorkBenchGroupResponse ListWorkBenchGroupWithOptions(ListWorkBenchGroupRequest request, ListWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkBenchGroup",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkBenchGroupResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkBenchGroupRequest
        /// </param>
        /// <param name="headers">
        /// ListWorkBenchGroupHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWorkBenchGroupResponse
        /// </returns>
        public async Task<ListWorkBenchGroupResponse> ListWorkBenchGroupWithOptionsAsync(ListWorkBenchGroupRequest request, ListWorkBenchGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcologicalCorpId))
            {
                query["ecologicalCorpId"] = request.EcologicalCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpUnionId))
            {
                query["opUnionId"] = request.OpUnionId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWorkBenchGroup",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWorkBenchGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkBenchGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkBenchGroupResponse
        /// </returns>
        public ListWorkBenchGroupResponse ListWorkBenchGroup(ListWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkBenchGroupHeaders headers = new ListWorkBenchGroupHeaders();
            return ListWorkBenchGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取工作台分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListWorkBenchGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWorkBenchGroupResponse
        /// </returns>
        public async Task<ListWorkBenchGroupResponse> ListWorkBenchGroupAsync(ListWorkBenchGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListWorkBenchGroupHeaders headers = new ListWorkBenchGroupHeaders();
            return await ListWorkBenchGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台支持数字红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWorkbenchBadgeRequest
        /// </param>
        /// <param name="headers">
        /// ModifyWorkbenchBadgeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyWorkbenchBadgeResponse
        /// </returns>
        public ModifyWorkbenchBadgeResponse ModifyWorkbenchBadgeWithOptions(ModifyWorkbenchBadgeRequest request, ModifyWorkbenchBadgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdList))
            {
                body["bizIdList"] = request.BizIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAdded))
            {
                body["isAdded"] = request.IsAdded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                body["modifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotRelationId))
            {
                body["redDotRelationId"] = request.RedDotRelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotType))
            {
                body["redDotType"] = request.RedDotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "ModifyWorkbenchBadge",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/badges/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWorkbenchBadgeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台支持数字红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWorkbenchBadgeRequest
        /// </param>
        /// <param name="headers">
        /// ModifyWorkbenchBadgeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyWorkbenchBadgeResponse
        /// </returns>
        public async Task<ModifyWorkbenchBadgeResponse> ModifyWorkbenchBadgeWithOptionsAsync(ModifyWorkbenchBadgeRequest request, ModifyWorkbenchBadgeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdList))
            {
                body["bizIdList"] = request.BizIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAdded))
            {
                body["isAdded"] = request.IsAdded;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                body["modifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotRelationId))
            {
                body["redDotRelationId"] = request.RedDotRelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotType))
            {
                body["redDotType"] = request.RedDotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "ModifyWorkbenchBadge",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/badges/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWorkbenchBadgeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台支持数字红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWorkbenchBadgeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyWorkbenchBadgeResponse
        /// </returns>
        public ModifyWorkbenchBadgeResponse ModifyWorkbenchBadge(ModifyWorkbenchBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyWorkbenchBadgeHeaders headers = new ModifyWorkbenchBadgeHeaders();
            return ModifyWorkbenchBadgeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台支持数字红点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyWorkbenchBadgeRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyWorkbenchBadgeResponse
        /// </returns>
        public async Task<ModifyWorkbenchBadgeResponse> ModifyWorkbenchBadgeAsync(ModifyWorkbenchBadgeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifyWorkbenchBadgeHeaders headers = new ModifyWorkbenchBadgeHeaders();
            return await ModifyWorkbenchBadgeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台组件授权范围查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryComponentScopesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryComponentScopesResponse
        /// </returns>
        public QueryComponentScopesResponse QueryComponentScopesWithOptions(string componentId, QueryComponentScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryComponentScopes",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/components/" + componentId + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryComponentScopesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台组件授权范围查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryComponentScopesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryComponentScopesResponse
        /// </returns>
        public async Task<QueryComponentScopesResponse> QueryComponentScopesWithOptionsAsync(string componentId, QueryComponentScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryComponentScopes",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/components/" + componentId + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryComponentScopesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台组件授权范围查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryComponentScopesResponse
        /// </returns>
        public QueryComponentScopesResponse QueryComponentScopes(string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
            return QueryComponentScopesWithOptions(componentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台组件授权范围查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryComponentScopesResponse
        /// </returns>
        public async Task<QueryComponentScopesResponse> QueryComponentScopesAsync(string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryComponentScopesHeaders headers = new QueryComponentScopesHeaders();
            return await QueryComponentScopesWithOptionsAsync(componentId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询快捷方式可见范围</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryShortcutScopesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryShortcutScopesResponse
        /// </returns>
        public QueryShortcutScopesResponse QueryShortcutScopesWithOptions(string shortcutKey, QueryShortcutScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryShortcutScopes",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryShortcutScopesResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询快捷方式可见范围</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryShortcutScopesHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryShortcutScopesResponse
        /// </returns>
        public async Task<QueryShortcutScopesResponse> QueryShortcutScopesWithOptionsAsync(string shortcutKey, QueryShortcutScopesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryShortcutScopes",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/shortcuts/" + shortcutKey + "/scopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryShortcutScopesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询快捷方式可见范围</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryShortcutScopesResponse
        /// </returns>
        public QueryShortcutScopesResponse QueryShortcutScopes(string shortcutKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
            return QueryShortcutScopesWithOptions(shortcutKey, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询快捷方式可见范围</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryShortcutScopesResponse
        /// </returns>
        public async Task<QueryShortcutScopesResponse> QueryShortcutScopesAsync(string shortcutKey)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryShortcutScopesHeaders headers = new QueryShortcutScopesHeaders();
            return await QueryShortcutScopesWithOptionsAsync(shortcutKey, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台数字红点支持撤销已被删除的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndoDeletionRequest
        /// </param>
        /// <param name="headers">
        /// UndoDeletionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UndoDeletionResponse
        /// </returns>
        public UndoDeletionResponse UndoDeletionWithOptions(UndoDeletionRequest request, UndoDeletionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdList))
            {
                body["bizIdList"] = request.BizIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotRelationId))
            {
                body["redDotRelationId"] = request.RedDotRelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotType))
            {
                body["redDotType"] = request.RedDotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "UndoDeletion",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/badges/undoDeleted",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UndoDeletionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台数字红点支持撤销已被删除的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndoDeletionRequest
        /// </param>
        /// <param name="headers">
        /// UndoDeletionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UndoDeletionResponse
        /// </returns>
        public async Task<UndoDeletionResponse> UndoDeletionWithOptionsAsync(UndoDeletionRequest request, UndoDeletionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdList))
            {
                body["bizIdList"] = request.BizIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotRelationId))
            {
                body["redDotRelationId"] = request.RedDotRelationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedDotType))
            {
                body["redDotType"] = request.RedDotType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "UndoDeletion",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/badges/undoDeleted",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UndoDeletionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台数字红点支持撤销已被删除的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndoDeletionRequest
        /// </param>
        /// 
        /// <returns>
        /// UndoDeletionResponse
        /// </returns>
        public UndoDeletionResponse UndoDeletion(UndoDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UndoDeletionHeaders headers = new UndoDeletionHeaders();
            return UndoDeletionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>工作台数字红点支持撤销已被删除的资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UndoDeletionRequest
        /// </param>
        /// 
        /// <returns>
        /// UndoDeletionResponse
        /// </returns>
        public async Task<UndoDeletionResponse> UndoDeletionAsync(UndoDeletionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UndoDeletionHeaders headers = new UndoDeletionHeaders();
            return await UndoDeletionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义工作台页面可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDingPortalPageScopeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDingPortalPageScopeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDingPortalPageScopeResponse
        /// </returns>
        public UpdateDingPortalPageScopeResponse UpdateDingPortalPageScopeWithOptions(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request, UpdateDingPortalPageScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllVisible))
            {
                body["allVisible"] = request.AllVisible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["roleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
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
                Action = "UpdateDingPortalPageScope",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/dingPortals/" + appUuid + "/pageScopes/" + pageUuid,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDingPortalPageScopeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义工作台页面可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDingPortalPageScopeRequest
        /// </param>
        /// <param name="headers">
        /// UpdateDingPortalPageScopeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDingPortalPageScopeResponse
        /// </returns>
        public async Task<UpdateDingPortalPageScopeResponse> UpdateDingPortalPageScopeWithOptionsAsync(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request, UpdateDingPortalPageScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllVisible))
            {
                body["allVisible"] = request.AllVisible;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIds))
            {
                body["roleIds"] = request.RoleIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userids))
            {
                body["userids"] = request.Userids;
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
                Action = "UpdateDingPortalPageScope",
                Version = "workbench_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/workbench/dingPortals/" + appUuid + "/pageScopes/" + pageUuid,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDingPortalPageScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义工作台页面可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDingPortalPageScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDingPortalPageScopeResponse
        /// </returns>
        public UpdateDingPortalPageScopeResponse UpdateDingPortalPageScope(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDingPortalPageScopeHeaders headers = new UpdateDingPortalPageScopeHeaders();
            return UpdateDingPortalPageScopeWithOptions(pageUuid, appUuid, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自定义工作台页面可见性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDingPortalPageScopeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDingPortalPageScopeResponse
        /// </returns>
        public async Task<UpdateDingPortalPageScopeResponse> UpdateDingPortalPageScopeAsync(string pageUuid, string appUuid, UpdateDingPortalPageScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateDingPortalPageScopeHeaders headers = new UpdateDingPortalPageScopeHeaders();
            return await UpdateDingPortalPageScopeWithOptionsAsync(pageUuid, appUuid, request, headers, runtime);
        }

    }
}
