// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkgateway_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkgateway_1_0
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
        /// <para>云上网关注册长连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenConnectionResponse
        /// </returns>
        public OpenConnectionResponse OpenConnectionWithOptions(OpenConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["clientSecret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extras))
            {
                body["extras"] = request.Extras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalIp))
            {
                body["localIp"] = request.LocalIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subscriptions))
            {
                body["subscriptions"] = request.Subscriptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenConnection",
                Version = "gateway_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/gateway/connections/open",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenConnectionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云上网关注册长连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenConnectionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenConnectionResponse
        /// </returns>
        public async Task<OpenConnectionResponse> OpenConnectionWithOptionsAsync(OpenConnectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                body["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientSecret))
            {
                body["clientSecret"] = request.ClientSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extras))
            {
                body["extras"] = request.Extras;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalIp))
            {
                body["localIp"] = request.LocalIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Subscriptions))
            {
                body["subscriptions"] = request.Subscriptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenConnection",
                Version = "gateway_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/gateway/connections/open",
                Method = "POST",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenConnectionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云上网关注册长连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenConnectionResponse
        /// </returns>
        public OpenConnectionResponse OpenConnection(OpenConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenConnectionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云上网关注册长连接</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenConnectionResponse
        /// </returns>
        public async Task<OpenConnectionResponse> OpenConnectionAsync(OpenConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenConnectionWithOptionsAsync(request, headers, runtime);
        }

    }
}
