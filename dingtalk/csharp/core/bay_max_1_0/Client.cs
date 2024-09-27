// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkbay_max_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkbay_max_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// <param name="headers">
        /// QueryBaymaxSkillLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public QueryBaymaxSkillLogResponse QueryBaymaxSkillLogWithOptions(QueryBaymaxSkillLogRequest request, QueryBaymaxSkillLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillExecuteId))
            {
                query["skillExecuteId"] = request.SkillExecuteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
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
                Action = "QueryBaymaxSkillLog",
                Version = "bayMax_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bayMax/skills/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBaymaxSkillLogResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// <param name="headers">
        /// QueryBaymaxSkillLogHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public async Task<QueryBaymaxSkillLogResponse> QueryBaymaxSkillLogWithOptionsAsync(QueryBaymaxSkillLogRequest request, QueryBaymaxSkillLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillExecuteId))
            {
                query["skillExecuteId"] = request.SkillExecuteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
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
                Action = "QueryBaymaxSkillLog",
                Version = "bayMax_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/bayMax/skills/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBaymaxSkillLogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public QueryBaymaxSkillLogResponse QueryBaymaxSkillLog(QueryBaymaxSkillLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBaymaxSkillLogHeaders headers = new QueryBaymaxSkillLogHeaders();
            return QueryBaymaxSkillLogWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Baymax技能执行日志</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBaymaxSkillLogRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBaymaxSkillLogResponse
        /// </returns>
        public async Task<QueryBaymaxSkillLogResponse> QueryBaymaxSkillLogAsync(QueryBaymaxSkillLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBaymaxSkillLogHeaders headers = new QueryBaymaxSkillLogHeaders();
            return await QueryBaymaxSkillLogWithOptionsAsync(request, headers, runtime);
        }

    }
}
