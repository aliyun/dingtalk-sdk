// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcool_ops_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcool_ops_1_0
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
        /// <para>ISV批量查询商机标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOpportunityTagRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryOpportunityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOpportunityTagResponse
        /// </returns>
        public BatchQueryOpportunityTagResponse BatchQueryOpportunityTagWithOptions(BatchQueryOpportunityTagRequest request, BatchQueryOpportunityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpIdList))
            {
                body["corpIdList"] = request.CorpIdList;
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
                Action = "BatchQueryOpportunityTag",
                Version = "coolOps_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolOps/isvOpportunities/opportunityTags/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryOpportunityTagResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV批量查询商机标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOpportunityTagRequest
        /// </param>
        /// <param name="headers">
        /// BatchQueryOpportunityTagHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOpportunityTagResponse
        /// </returns>
        public async Task<BatchQueryOpportunityTagResponse> BatchQueryOpportunityTagWithOptionsAsync(BatchQueryOpportunityTagRequest request, BatchQueryOpportunityTagHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpIdList))
            {
                body["corpIdList"] = request.CorpIdList;
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
                Action = "BatchQueryOpportunityTag",
                Version = "coolOps_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolOps/isvOpportunities/opportunityTags/batchQuery",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryOpportunityTagResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV批量查询商机标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOpportunityTagRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOpportunityTagResponse
        /// </returns>
        public BatchQueryOpportunityTagResponse BatchQueryOpportunityTag(BatchQueryOpportunityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryOpportunityTagHeaders headers = new BatchQueryOpportunityTagHeaders();
            return BatchQueryOpportunityTagWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV批量查询商机标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryOpportunityTagRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryOpportunityTagResponse
        /// </returns>
        public async Task<BatchQueryOpportunityTagResponse> BatchQueryOpportunityTagAsync(BatchQueryOpportunityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryOpportunityTagHeaders headers = new BatchQueryOpportunityTagHeaders();
            return await BatchQueryOpportunityTagWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV商机状态同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIsvOppStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateIsvOppStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIsvOppStatusResponse
        /// </returns>
        public UpdateIsvOppStatusResponse UpdateIsvOppStatusWithOptions(UpdateIsvOppStatusRequest request, UpdateIsvOppStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOpportunityStatusList))
            {
                body["isvOpportunityStatusList"] = request.IsvOpportunityStatusList;
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
                Action = "UpdateIsvOppStatus",
                Version = "coolOps_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolOps/isvOpportunities/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIsvOppStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV商机状态同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIsvOppStatusRequest
        /// </param>
        /// <param name="headers">
        /// UpdateIsvOppStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIsvOppStatusResponse
        /// </returns>
        public async Task<UpdateIsvOppStatusResponse> UpdateIsvOppStatusWithOptionsAsync(UpdateIsvOppStatusRequest request, UpdateIsvOppStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOpportunityStatusList))
            {
                body["isvOpportunityStatusList"] = request.IsvOpportunityStatusList;
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
                Action = "UpdateIsvOppStatus",
                Version = "coolOps_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/coolOps/isvOpportunities/statuses",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIsvOppStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV商机状态同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIsvOppStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIsvOppStatusResponse
        /// </returns>
        public UpdateIsvOppStatusResponse UpdateIsvOppStatus(UpdateIsvOppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIsvOppStatusHeaders headers = new UpdateIsvOppStatusHeaders();
            return UpdateIsvOppStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ISV商机状态同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIsvOppStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIsvOppStatusResponse
        /// </returns>
        public async Task<UpdateIsvOppStatusResponse> UpdateIsvOppStatusAsync(UpdateIsvOppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIsvOppStatusHeaders headers = new UpdateIsvOppStatusHeaders();
            return await UpdateIsvOppStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
