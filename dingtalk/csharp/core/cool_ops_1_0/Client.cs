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


        /**
         * @summary ISV批量查询商机标签
         *
         * @param request BatchQueryOpportunityTagRequest
         * @param headers BatchQueryOpportunityTagHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQueryOpportunityTagResponse
         */
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

        /**
         * @summary ISV批量查询商机标签
         *
         * @param request BatchQueryOpportunityTagRequest
         * @param headers BatchQueryOpportunityTagHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchQueryOpportunityTagResponse
         */
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

        /**
         * @summary ISV批量查询商机标签
         *
         * @param request BatchQueryOpportunityTagRequest
         * @return BatchQueryOpportunityTagResponse
         */
        public BatchQueryOpportunityTagResponse BatchQueryOpportunityTag(BatchQueryOpportunityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryOpportunityTagHeaders headers = new BatchQueryOpportunityTagHeaders();
            return BatchQueryOpportunityTagWithOptions(request, headers, runtime);
        }

        /**
         * @summary ISV批量查询商机标签
         *
         * @param request BatchQueryOpportunityTagRequest
         * @return BatchQueryOpportunityTagResponse
         */
        public async Task<BatchQueryOpportunityTagResponse> BatchQueryOpportunityTagAsync(BatchQueryOpportunityTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BatchQueryOpportunityTagHeaders headers = new BatchQueryOpportunityTagHeaders();
            return await BatchQueryOpportunityTagWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary ISV商机状态同步
         *
         * @param request UpdateIsvOppStatusRequest
         * @param headers UpdateIsvOppStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIsvOppStatusResponse
         */
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

        /**
         * @summary ISV商机状态同步
         *
         * @param request UpdateIsvOppStatusRequest
         * @param headers UpdateIsvOppStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIsvOppStatusResponse
         */
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

        /**
         * @summary ISV商机状态同步
         *
         * @param request UpdateIsvOppStatusRequest
         * @return UpdateIsvOppStatusResponse
         */
        public UpdateIsvOppStatusResponse UpdateIsvOppStatus(UpdateIsvOppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIsvOppStatusHeaders headers = new UpdateIsvOppStatusHeaders();
            return UpdateIsvOppStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary ISV商机状态同步
         *
         * @param request UpdateIsvOppStatusRequest
         * @return UpdateIsvOppStatusResponse
         */
        public async Task<UpdateIsvOppStatusResponse> UpdateIsvOppStatusAsync(UpdateIsvOppStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateIsvOppStatusHeaders headers = new UpdateIsvOppStatusHeaders();
            return await UpdateIsvOppStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
