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
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = _client;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


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

        public GetCallBackFaileResultResponse GetCallBackFaileResult(GetCallBackFaileResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCallBackFaileResultHeaders headers = new GetCallBackFaileResultHeaders();
            return GetCallBackFaileResultWithOptions(request, headers, runtime);
        }

        public async Task<GetCallBackFaileResultResponse> GetCallBackFaileResultAsync(GetCallBackFaileResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCallBackFaileResultHeaders headers = new GetCallBackFaileResultHeaders();
            return await GetCallBackFaileResultWithOptionsAsync(request, headers, runtime);
        }

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

        public RePushSuiteTicketResponse RePushSuiteTicket(RePushSuiteTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RePushSuiteTicketWithOptions(request, headers, runtime);
        }

        public async Task<RePushSuiteTicketResponse> RePushSuiteTicketAsync(RePushSuiteTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RePushSuiteTicketWithOptionsAsync(request, headers, runtime);
        }

    }
}
