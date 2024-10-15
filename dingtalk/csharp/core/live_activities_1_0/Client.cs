// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalklive_activities_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalklive_activities_1_0
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
        /// <para>实时活动发送接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushLiveActivityRequest
        /// </param>
        /// <param name="headers">
        /// PushLiveActivityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushLiveActivityResponse
        /// </returns>
        public PushLiveActivityResponse PushLiveActivityWithOptions(PushLiveActivityRequest request, PushLiveActivityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventData))
            {
                body["activityEventData"] = request.ActivityEventData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventOption))
            {
                body["activityEventOption"] = request.ActivityEventOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
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
                Action = "PushLiveActivity",
                Version = "liveActivities_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/liveActivities/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushLiveActivityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时活动发送接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushLiveActivityRequest
        /// </param>
        /// <param name="headers">
        /// PushLiveActivityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushLiveActivityResponse
        /// </returns>
        public async Task<PushLiveActivityResponse> PushLiveActivityWithOptionsAsync(PushLiveActivityRequest request, PushLiveActivityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventData))
            {
                body["activityEventData"] = request.ActivityEventData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventOption))
            {
                body["activityEventOption"] = request.ActivityEventOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
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
                Action = "PushLiveActivity",
                Version = "liveActivities_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/liveActivities/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushLiveActivityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时活动发送接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushLiveActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// PushLiveActivityResponse
        /// </returns>
        public PushLiveActivityResponse PushLiveActivity(PushLiveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushLiveActivityHeaders headers = new PushLiveActivityHeaders();
            return PushLiveActivityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>实时活动发送接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushLiveActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// PushLiveActivityResponse
        /// </returns>
        public async Task<PushLiveActivityResponse> PushLiveActivityAsync(PushLiveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushLiveActivityHeaders headers = new PushLiveActivityHeaders();
            return await PushLiveActivityWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送实时活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveActivityRequest
        /// </param>
        /// <param name="headers">
        /// SendLiveActivityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLiveActivityResponse
        /// </returns>
        public SendLiveActivityResponse SendLiveActivityWithOptions(SendLiveActivityRequest request, SendLiveActivityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventData))
            {
                body["activityEventData"] = request.ActivityEventData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventOption))
            {
                body["activityEventOption"] = request.ActivityEventOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
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
                Action = "SendLiveActivity",
                Version = "liveActivities_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/liveActivities/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveActivityResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送实时活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveActivityRequest
        /// </param>
        /// <param name="headers">
        /// SendLiveActivityHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendLiveActivityResponse
        /// </returns>
        public async Task<SendLiveActivityResponse> SendLiveActivityWithOptionsAsync(SendLiveActivityRequest request, SendLiveActivityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventData))
            {
                body["activityEventData"] = request.ActivityEventData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityEventOption))
            {
                body["activityEventOption"] = request.ActivityEventOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                body["activityId"] = request.ActivityId;
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
                Action = "SendLiveActivity",
                Version = "liveActivities_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/liveActivities/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendLiveActivityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送实时活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLiveActivityResponse
        /// </returns>
        public SendLiveActivityResponse SendLiveActivity(SendLiveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLiveActivityHeaders headers = new SendLiveActivityHeaders();
            return SendLiveActivityWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送实时活动</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendLiveActivityRequest
        /// </param>
        /// 
        /// <returns>
        /// SendLiveActivityResponse
        /// </returns>
        public async Task<SendLiveActivityResponse> SendLiveActivityAsync(SendLiveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLiveActivityHeaders headers = new SendLiveActivityHeaders();
            return await SendLiveActivityWithOptionsAsync(request, headers, runtime);
        }

    }
}
