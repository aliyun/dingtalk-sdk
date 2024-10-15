// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkevent_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkevent_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本获取推送失败的变更事件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallBackFaileResultRequest
        /// </param>
        /// <param name="headers">
        /// GetCallBackFaileResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallBackFaileResultResponse
        /// </returns>
        public GetCallBackFaileResultResponse GetCallBackFaileResultWithOptions(GetCallBackFaileResultRequest request, GetCallBackFaileResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "GetCallBackFaileResult",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/callbacks/failedResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallBackFaileResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本获取推送失败的变更事件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallBackFaileResultRequest
        /// </param>
        /// <param name="headers">
        /// GetCallBackFaileResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCallBackFaileResultResponse
        /// </returns>
        public async Task<GetCallBackFaileResultResponse> GetCallBackFaileResultWithOptionsAsync(GetCallBackFaileResultRequest request, GetCallBackFaileResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
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
                Action = "GetCallBackFaileResult",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/callbacks/failedResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCallBackFaileResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本获取推送失败的变更事件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallBackFaileResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallBackFaileResultResponse
        /// </returns>
        public GetCallBackFaileResultResponse GetCallBackFaileResult(GetCallBackFaileResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCallBackFaileResultHeaders headers = new GetCallBackFaileResultHeaders();
            return GetCallBackFaileResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>调用本获取推送失败的变更事件。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCallBackFaileResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCallBackFaileResultResponse
        /// </returns>
        public async Task<GetCallBackFaileResultResponse> GetCallBackFaileResultAsync(GetCallBackFaileResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCallBackFaileResultHeaders headers = new GetCallBackFaileResultHeaders();
            return await GetCallBackFaileResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装一方应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// <param name="headers">
        /// InstallAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public InstallAppResponse InstallAppWithOptions(InstallAppRequest request, InstallAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                query["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteId))
            {
                query["suiteId"] = request.SuiteId;
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
                Action = "InstallApp",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/elm/apps/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装一方应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// <param name="headers">
        /// InstallAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public async Task<InstallAppResponse> InstallAppWithOptionsAsync(InstallAppRequest request, InstallAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                query["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteId))
            {
                query["suiteId"] = request.SuiteId;
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
                Action = "InstallApp",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/elm/apps/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装一方应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public InstallAppResponse InstallApp(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return InstallAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装一方应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAppResponse
        /// </returns>
        public async Task<InstallAppResponse> InstallAppAsync(InstallAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallAppHeaders headers = new InstallAppHeaders();
            return await InstallAppWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InstallCoolAppRequest
        /// </param>
        /// <param name="headers">
        /// InstallCoolAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppResponse
        /// </returns>
        public InstallCoolAppResponse InstallCoolAppWithOptions(InstallCoolAppRequest tmpReq, InstallCoolAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallCoolAppShrinkRequest request = new InstallCoolAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Feature))
            {
                request.FeatureShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Feature, "feature", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                query["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureShrink))
            {
                query["feature"] = request.FeatureShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallUid))
            {
                query["installUid"] = request.InstallUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteId))
            {
                query["suiteId"] = request.SuiteId;
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
                Action = "InstallCoolApp",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/elm/coolApps/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// InstallCoolAppRequest
        /// </param>
        /// <param name="headers">
        /// InstallCoolAppHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppResponse
        /// </returns>
        public async Task<InstallCoolAppResponse> InstallCoolAppWithOptionsAsync(InstallCoolAppRequest tmpReq, InstallCoolAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallCoolAppShrinkRequest request = new InstallCoolAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Feature))
            {
                request.FeatureShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Feature, "feature", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Options))
            {
                request.OptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Options, "options", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                query["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FeatureShrink))
            {
                query["feature"] = request.FeatureShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstallUid))
            {
                query["installUid"] = request.InstallUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptionsShrink))
            {
                query["options"] = request.OptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteId))
            {
                query["suiteId"] = request.SuiteId;
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
                Action = "InstallCoolApp",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/elm/coolApps/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallCoolAppResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppResponse
        /// </returns>
        public InstallCoolAppResponse InstallCoolApp(InstallCoolAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppHeaders headers = new InstallCoolAppHeaders();
            return InstallCoolAppWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>安装酷应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCoolAppRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCoolAppResponse
        /// </returns>
        public async Task<InstallCoolAppResponse> InstallCoolAppAsync(InstallCoolAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InstallCoolAppHeaders headers = new InstallCoolAppHeaders();
            return await InstallCoolAppWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新获取suiteTicket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RePushSuiteTicketRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RePushSuiteTicketResponse
        /// </returns>
        public RePushSuiteTicketResponse RePushSuiteTicketWithOptions(RePushSuiteTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteId))
            {
                query["suiteId"] = request.SuiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteSecret))
            {
                query["suiteSecret"] = request.SuiteSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RePushSuiteTicket",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/suiteTicket/rePush",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RePushSuiteTicketResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新获取suiteTicket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RePushSuiteTicketRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RePushSuiteTicketResponse
        /// </returns>
        public async Task<RePushSuiteTicketResponse> RePushSuiteTicketWithOptionsAsync(RePushSuiteTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteId))
            {
                query["suiteId"] = request.SuiteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteSecret))
            {
                query["suiteSecret"] = request.SuiteSecret;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RePushSuiteTicket",
                Version = "event_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/event/suiteTicket/rePush",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RePushSuiteTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新获取suiteTicket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RePushSuiteTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// RePushSuiteTicketResponse
        /// </returns>
        public RePushSuiteTicketResponse RePushSuiteTicket(RePushSuiteTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RePushSuiteTicketWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>重新获取suiteTicket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RePushSuiteTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// RePushSuiteTicketResponse
        /// </returns>
        public async Task<RePushSuiteTicketResponse> RePushSuiteTicketAsync(RePushSuiteTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RePushSuiteTicketWithOptionsAsync(request, headers, runtime);
        }

    }
}
