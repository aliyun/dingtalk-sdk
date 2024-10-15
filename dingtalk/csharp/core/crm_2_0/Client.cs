// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcrm_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcrm_2_0
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
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetRelationUkSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public GetRelationUkSettingResponse GetRelationUkSettingWithOptions(GetRelationUkSettingRequest request, GetRelationUkSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "GetRelationUkSetting",
                Version = "crm_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/crm/relationUkSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationUkSettingResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// <param name="headers">
        /// GetRelationUkSettingHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public async Task<GetRelationUkSettingResponse> GetRelationUkSettingWithOptionsAsync(GetRelationUkSettingRequest request, GetRelationUkSettingHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelationType))
            {
                query["relationType"] = request.RelationType;
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
                Action = "GetRelationUkSetting",
                Version = "crm_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/crm/relationUkSettings",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRelationUkSettingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public GetRelationUkSettingResponse GetRelationUkSetting(GetRelationUkSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationUkSettingHeaders headers = new GetRelationUkSettingHeaders();
            return GetRelationUkSettingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取关系数据查重规则</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRelationUkSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRelationUkSettingResponse
        /// </returns>
        public async Task<GetRelationUkSettingResponse> GetRelationUkSettingAsync(GetRelationUkSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetRelationUkSettingHeaders headers = new GetRelationUkSettingHeaders();
            return await GetRelationUkSettingWithOptionsAsync(request, headers, runtime);
        }

    }
}
