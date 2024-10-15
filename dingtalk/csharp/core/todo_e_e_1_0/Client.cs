// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktodo_e_e_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktodo_e_e_1_0
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
        /// <para>注册应用类目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCategorySourceConfigRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCategorySourceConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCategorySourceConfigResponse
        /// </returns>
        public RegisterCategorySourceConfigResponse RegisterCategorySourceConfigWithOptions(RegisterCategorySourceConfigRequest request, RegisterCategorySourceConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategoryId))
            {
                body["bizCategoryId"] = request.BizCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategoryName))
            {
                body["bizCategoryName"] = request.BizCategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "RegisterCategorySourceConfig",
                Version = "todoEE_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todoEE/apps/categories/sourceConfigs/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCategorySourceConfigResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册应用类目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCategorySourceConfigRequest
        /// </param>
        /// <param name="headers">
        /// RegisterCategorySourceConfigHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RegisterCategorySourceConfigResponse
        /// </returns>
        public async Task<RegisterCategorySourceConfigResponse> RegisterCategorySourceConfigWithOptionsAsync(RegisterCategorySourceConfigRequest request, RegisterCategorySourceConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategoryId))
            {
                body["bizCategoryId"] = request.BizCategoryId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCategoryName))
            {
                body["bizCategoryName"] = request.BizCategoryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorId))
            {
                body["operatorId"] = request.OperatorId;
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
                Action = "RegisterCategorySourceConfig",
                Version = "todoEE_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/todoEE/apps/categories/sourceConfigs/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<RegisterCategorySourceConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册应用类目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCategorySourceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCategorySourceConfigResponse
        /// </returns>
        public RegisterCategorySourceConfigResponse RegisterCategorySourceConfig(RegisterCategorySourceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCategorySourceConfigHeaders headers = new RegisterCategorySourceConfigHeaders();
            return RegisterCategorySourceConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>注册应用类目信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RegisterCategorySourceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// RegisterCategorySourceConfigResponse
        /// </returns>
        public async Task<RegisterCategorySourceConfigResponse> RegisterCategorySourceConfigAsync(RegisterCategorySourceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            RegisterCategorySourceConfigHeaders headers = new RegisterCategorySourceConfigHeaders();
            return await RegisterCategorySourceConfigWithOptionsAsync(request, headers, runtime);
        }

    }
}
