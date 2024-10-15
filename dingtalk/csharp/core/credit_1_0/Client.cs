// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcredit_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcredit_1_0
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
        /// <para>查询用户金融评分数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScoreRequest
        /// </param>
        /// <param name="headers">
        /// QueryScoreHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScoreResponse
        /// </returns>
        public QueryScoreResponse QueryScoreWithOptions(QueryScoreRequest request, QueryScoreHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullName))
            {
                query["fullName"] = request.FullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardCode))
            {
                query["idCardCode"] = request.IdCardCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniScCode))
            {
                query["uniScCode"] = request.UniScCode;
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
                Action = "QueryScore",
                Version = "credit_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/credit/scores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScoreResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户金融评分数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScoreRequest
        /// </param>
        /// <param name="headers">
        /// QueryScoreHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryScoreResponse
        /// </returns>
        public async Task<QueryScoreResponse> QueryScoreWithOptionsAsync(QueryScoreRequest request, QueryScoreHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Encryption))
            {
                query["encryption"] = request.Encryption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FullName))
            {
                query["fullName"] = request.FullName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardCode))
            {
                query["idCardCode"] = request.IdCardCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgName))
            {
                query["orgName"] = request.OrgName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniScCode))
            {
                query["uniScCode"] = request.UniScCode;
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
                Action = "QueryScore",
                Version = "credit_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/credit/scores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryScoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户金融评分数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScoreResponse
        /// </returns>
        public QueryScoreResponse QueryScore(QueryScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScoreHeaders headers = new QueryScoreHeaders();
            return QueryScoreWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户金融评分数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryScoreRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryScoreResponse
        /// </returns>
        public async Task<QueryScoreResponse> QueryScoreAsync(QueryScoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryScoreHeaders headers = new QueryScoreHeaders();
            return await QueryScoreWithOptionsAsync(request, headers, runtime);
        }

    }
}
