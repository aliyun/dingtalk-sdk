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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


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

        public SendLiveActivityResponse SendLiveActivity(SendLiveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLiveActivityHeaders headers = new SendLiveActivityHeaders();
            return SendLiveActivityWithOptions(request, headers, runtime);
        }

        public async Task<SendLiveActivityResponse> SendLiveActivityAsync(SendLiveActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendLiveActivityHeaders headers = new SendLiveActivityHeaders();
            return await SendLiveActivityWithOptionsAsync(request, headers, runtime);
        }

    }
}
