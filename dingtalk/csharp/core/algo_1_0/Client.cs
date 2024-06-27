// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkalgo_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkalgo_1_0
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


        /**
         * @summary 自然语言处理之关键词识别
         *
         * @param request NlpWordDistinguishRequest
         * @param headers NlpWordDistinguishHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NlpWordDistinguishResponse
         */
        public NlpWordDistinguishResponse NlpWordDistinguishWithOptions(NlpWordDistinguishRequest request, NlpWordDistinguishHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachExtractDecisionInfo))
            {
                body["attachExtractDecisionInfo"] = request.AttachExtractDecisionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvAppId))
            {
                body["isvAppId"] = request.IsvAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
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
                Action = "NlpWordDistinguish",
                Version = "algo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/algo/okrs/keywords/extract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NlpWordDistinguishResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 自然语言处理之关键词识别
         *
         * @param request NlpWordDistinguishRequest
         * @param headers NlpWordDistinguishHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NlpWordDistinguishResponse
         */
        public async Task<NlpWordDistinguishResponse> NlpWordDistinguishWithOptionsAsync(NlpWordDistinguishRequest request, NlpWordDistinguishHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachExtractDecisionInfo))
            {
                body["attachExtractDecisionInfo"] = request.AttachExtractDecisionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvAppId))
            {
                body["isvAppId"] = request.IsvAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Text))
            {
                body["text"] = request.Text;
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
                Action = "NlpWordDistinguish",
                Version = "algo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/algo/okrs/keywords/extract",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NlpWordDistinguishResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 自然语言处理之关键词识别
         *
         * @param request NlpWordDistinguishRequest
         * @return NlpWordDistinguishResponse
         */
        public NlpWordDistinguishResponse NlpWordDistinguish(NlpWordDistinguishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NlpWordDistinguishHeaders headers = new NlpWordDistinguishHeaders();
            return NlpWordDistinguishWithOptions(request, headers, runtime);
        }

        /**
         * @summary 自然语言处理之关键词识别
         *
         * @param request NlpWordDistinguishRequest
         * @return NlpWordDistinguishResponse
         */
        public async Task<NlpWordDistinguishResponse> NlpWordDistinguishAsync(NlpWordDistinguishRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NlpWordDistinguishHeaders headers = new NlpWordDistinguishHeaders();
            return await NlpWordDistinguishWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Okr内容推荐
         *
         * @param request OkrOpenRecommendRequest
         * @param headers OkrOpenRecommendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OkrOpenRecommendResponse
         */
        public OkrOpenRecommendResponse OkrOpenRecommendWithOptions(OkrOpenRecommendRequest request, OkrOpenRecommendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateOkrItems))
            {
                body["candidateOkrItems"] = request.CandidateOkrItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvAppId))
            {
                body["isvAppId"] = request.IsvAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Words))
            {
                body["words"] = request.Words;
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
                Action = "OkrOpenRecommend",
                Version = "algo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/algo/okrs/recommend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrOpenRecommendResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Okr内容推荐
         *
         * @param request OkrOpenRecommendRequest
         * @param headers OkrOpenRecommendHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return OkrOpenRecommendResponse
         */
        public async Task<OkrOpenRecommendResponse> OkrOpenRecommendWithOptionsAsync(OkrOpenRecommendRequest request, OkrOpenRecommendHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CandidateOkrItems))
            {
                body["candidateOkrItems"] = request.CandidateOkrItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptIds))
            {
                body["deptIds"] = request.DeptIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvAppId))
            {
                body["isvAppId"] = request.IsvAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Words))
            {
                body["words"] = request.Words;
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
                Action = "OkrOpenRecommend",
                Version = "algo_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/algo/okrs/recommend",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OkrOpenRecommendResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Okr内容推荐
         *
         * @param request OkrOpenRecommendRequest
         * @return OkrOpenRecommendResponse
         */
        public OkrOpenRecommendResponse OkrOpenRecommend(OkrOpenRecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrOpenRecommendHeaders headers = new OkrOpenRecommendHeaders();
            return OkrOpenRecommendWithOptions(request, headers, runtime);
        }

        /**
         * @summary Okr内容推荐
         *
         * @param request OkrOpenRecommendRequest
         * @return OkrOpenRecommendResponse
         */
        public async Task<OkrOpenRecommendResponse> OkrOpenRecommendAsync(OkrOpenRecommendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OkrOpenRecommendHeaders headers = new OkrOpenRecommendHeaders();
            return await OkrOpenRecommendWithOptionsAsync(request, headers, runtime);
        }

    }
}
