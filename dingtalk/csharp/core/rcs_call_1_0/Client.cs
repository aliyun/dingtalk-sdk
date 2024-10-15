// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkrcs_call_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkrcs_call_1_0
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
        /// <para>主叫方发起免费电话给授权企业人员，关联订单id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCallUserRequest
        /// </param>
        /// <param name="headers">
        /// RunCallUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCallUserResponse
        /// </returns>
        public RunCallUserResponse RunCallUserWithOptions(RunCallUserRequest request, RunCallUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeCorpId))
            {
                query["authorizeCorpId"] = request.AuthorizeCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserId))
            {
                query["authorizeUserId"] = request.AuthorizeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "RunCallUser",
                Version = "rcsCall_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rcsCall/users/call",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCallUserResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主叫方发起免费电话给授权企业人员，关联订单id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCallUserRequest
        /// </param>
        /// <param name="headers">
        /// RunCallUserHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCallUserResponse
        /// </returns>
        public async Task<RunCallUserResponse> RunCallUserWithOptionsAsync(RunCallUserRequest request, RunCallUserHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeCorpId))
            {
                query["authorizeCorpId"] = request.AuthorizeCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizeUserId))
            {
                query["authorizeUserId"] = request.AuthorizeUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "RunCallUser",
                Version = "rcsCall_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/rcsCall/users/call",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunCallUserResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主叫方发起免费电话给授权企业人员，关联订单id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCallUserRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCallUserResponse
        /// </returns>
        public RunCallUserResponse RunCallUser(RunCallUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RunCallUserHeaders headers = new RunCallUserHeaders();
            return RunCallUserWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>主叫方发起免费电话给授权企业人员，关联订单id</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunCallUserRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCallUserResponse
        /// </returns>
        public async Task<RunCallUserResponse> RunCallUserAsync(RunCallUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RunCallUserHeaders headers = new RunCallUserHeaders();
            return await RunCallUserWithOptionsAsync(request, headers, runtime);
        }

    }
}
