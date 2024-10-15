// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkhrbrain_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkhrbrain_1_0
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
        /// <para>集成奖励记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportAwardDetailRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportAwardDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportAwardDetailResponse
        /// </returns>
        public HrbrainImportAwardDetailResponse HrbrainImportAwardDetailWithOptions(HrbrainImportAwardDetailRequest request, HrbrainImportAwardDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportAwardDetail",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/awardDetails/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportAwardDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成奖励记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportAwardDetailRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportAwardDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportAwardDetailResponse
        /// </returns>
        public async Task<HrbrainImportAwardDetailResponse> HrbrainImportAwardDetailWithOptionsAsync(HrbrainImportAwardDetailRequest request, HrbrainImportAwardDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportAwardDetail",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/awardDetails/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportAwardDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成奖励记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportAwardDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportAwardDetailResponse
        /// </returns>
        public HrbrainImportAwardDetailResponse HrbrainImportAwardDetail(HrbrainImportAwardDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportAwardDetailHeaders headers = new HrbrainImportAwardDetailHeaders();
            return HrbrainImportAwardDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成奖励记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportAwardDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportAwardDetailResponse
        /// </returns>
        public async Task<HrbrainImportAwardDetailResponse> HrbrainImportAwardDetailAsync(HrbrainImportAwardDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportAwardDetailHeaders headers = new HrbrainImportAwardDetailHeaders();
            return await HrbrainImportAwardDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成组织架构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDeptInfoRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportDeptInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDeptInfoResponse
        /// </returns>
        public HrbrainImportDeptInfoResponse HrbrainImportDeptInfoWithOptions(HrbrainImportDeptInfoRequest request, HrbrainImportDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportDeptInfo",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/deptInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportDeptInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成组织架构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDeptInfoRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportDeptInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDeptInfoResponse
        /// </returns>
        public async Task<HrbrainImportDeptInfoResponse> HrbrainImportDeptInfoWithOptionsAsync(HrbrainImportDeptInfoRequest request, HrbrainImportDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportDeptInfo",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/deptInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportDeptInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成组织架构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDeptInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDeptInfoResponse
        /// </returns>
        public HrbrainImportDeptInfoResponse HrbrainImportDeptInfo(HrbrainImportDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportDeptInfoHeaders headers = new HrbrainImportDeptInfoHeaders();
            return HrbrainImportDeptInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成组织架构</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDeptInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDeptInfoResponse
        /// </returns>
        public async Task<HrbrainImportDeptInfoResponse> HrbrainImportDeptInfoAsync(HrbrainImportDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportDeptInfoHeaders headers = new HrbrainImportDeptInfoHeaders();
            return await HrbrainImportDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成离职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDimissionRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportDimissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDimissionResponse
        /// </returns>
        public HrbrainImportDimissionResponse HrbrainImportDimissionWithOptions(HrbrainImportDimissionRequest request, HrbrainImportDimissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportDimission",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/dimissionInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportDimissionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成离职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDimissionRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportDimissionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDimissionResponse
        /// </returns>
        public async Task<HrbrainImportDimissionResponse> HrbrainImportDimissionWithOptionsAsync(HrbrainImportDimissionRequest request, HrbrainImportDimissionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportDimission",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/dimissionInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportDimissionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成离职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDimissionRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDimissionResponse
        /// </returns>
        public HrbrainImportDimissionResponse HrbrainImportDimission(HrbrainImportDimissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportDimissionHeaders headers = new HrbrainImportDimissionHeaders();
            return HrbrainImportDimissionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成离职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportDimissionRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportDimissionResponse
        /// </returns>
        public async Task<HrbrainImportDimissionResponse> HrbrainImportDimissionAsync(HrbrainImportDimissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportDimissionHeaders headers = new HrbrainImportDimissionHeaders();
            return await HrbrainImportDimissionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成教育经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEduExpRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportEduExpHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEduExpResponse
        /// </returns>
        public HrbrainImportEduExpResponse HrbrainImportEduExpWithOptions(HrbrainImportEduExpRequest request, HrbrainImportEduExpHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportEduExp",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/eduExperiences/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportEduExpResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成教育经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEduExpRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportEduExpHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEduExpResponse
        /// </returns>
        public async Task<HrbrainImportEduExpResponse> HrbrainImportEduExpWithOptionsAsync(HrbrainImportEduExpRequest request, HrbrainImportEduExpHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportEduExp",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/eduExperiences/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportEduExpResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成教育经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEduExpRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEduExpResponse
        /// </returns>
        public HrbrainImportEduExpResponse HrbrainImportEduExp(HrbrainImportEduExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportEduExpHeaders headers = new HrbrainImportEduExpHeaders();
            return HrbrainImportEduExpWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成教育经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEduExpRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEduExpResponse
        /// </returns>
        public async Task<HrbrainImportEduExpResponse> HrbrainImportEduExpAsync(HrbrainImportEduExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportEduExpHeaders headers = new HrbrainImportEduExpHeaders();
            return await HrbrainImportEduExpWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEmpInfoRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportEmpInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEmpInfoResponse
        /// </returns>
        public HrbrainImportEmpInfoResponse HrbrainImportEmpInfoWithOptions(HrbrainImportEmpInfoRequest request, HrbrainImportEmpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportEmpInfo",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/empInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportEmpInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEmpInfoRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportEmpInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEmpInfoResponse
        /// </returns>
        public async Task<HrbrainImportEmpInfoResponse> HrbrainImportEmpInfoWithOptionsAsync(HrbrainImportEmpInfoRequest request, HrbrainImportEmpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportEmpInfo",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/empInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportEmpInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEmpInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEmpInfoResponse
        /// </returns>
        public HrbrainImportEmpInfoResponse HrbrainImportEmpInfo(HrbrainImportEmpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportEmpInfoHeaders headers = new HrbrainImportEmpInfoHeaders();
            return HrbrainImportEmpInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成人员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportEmpInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportEmpInfoResponse
        /// </returns>
        public async Task<HrbrainImportEmpInfoResponse> HrbrainImportEmpInfoAsync(HrbrainImportEmpInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportEmpInfoHeaders headers = new HrbrainImportEmpInfoHeaders();
            return await HrbrainImportEmpInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成基础标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelBaseRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelBaseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelBaseResponse
        /// </returns>
        public HrbrainImportLabelBaseResponse HrbrainImportLabelBaseWithOptions(HrbrainImportLabelBaseRequest request, HrbrainImportLabelBaseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelBase",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/baseLabels/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelBaseResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成基础标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelBaseRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelBaseHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelBaseResponse
        /// </returns>
        public async Task<HrbrainImportLabelBaseResponse> HrbrainImportLabelBaseWithOptionsAsync(HrbrainImportLabelBaseRequest request, HrbrainImportLabelBaseHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelBase",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/baseLabels/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelBaseResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成基础标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelBaseResponse
        /// </returns>
        public HrbrainImportLabelBaseResponse HrbrainImportLabelBase(HrbrainImportLabelBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelBaseHeaders headers = new HrbrainImportLabelBaseHeaders();
            return HrbrainImportLabelBaseWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成基础标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelBaseRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelBaseResponse
        /// </returns>
        public async Task<HrbrainImportLabelBaseResponse> HrbrainImportLabelBaseAsync(HrbrainImportLabelBaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelBaseHeaders headers = new HrbrainImportLabelBaseHeaders();
            return await HrbrainImportLabelBaseWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelCustomRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelCustomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelCustomResponse
        /// </returns>
        public HrbrainImportLabelCustomResponse HrbrainImportLabelCustomWithOptions(HrbrainImportLabelCustomRequest request, HrbrainImportLabelCustomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelCustom",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/customLabels/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelCustomResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelCustomRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelCustomHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelCustomResponse
        /// </returns>
        public async Task<HrbrainImportLabelCustomResponse> HrbrainImportLabelCustomWithOptionsAsync(HrbrainImportLabelCustomRequest request, HrbrainImportLabelCustomHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelCustom",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/customLabels/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelCustomResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelCustomResponse
        /// </returns>
        public HrbrainImportLabelCustomResponse HrbrainImportLabelCustom(HrbrainImportLabelCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelCustomHeaders headers = new HrbrainImportLabelCustomHeaders();
            return HrbrainImportLabelCustomWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成自定义标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelCustomRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelCustomResponse
        /// </returns>
        public async Task<HrbrainImportLabelCustomResponse> HrbrainImportLabelCustomAsync(HrbrainImportLabelCustomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelCustomHeaders headers = new HrbrainImportLabelCustomHeaders();
            return await HrbrainImportLabelCustomWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成领域经验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelIndustryRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelIndustryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelIndustryResponse
        /// </returns>
        public HrbrainImportLabelIndustryResponse HrbrainImportLabelIndustryWithOptions(HrbrainImportLabelIndustryRequest request, HrbrainImportLabelIndustryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelIndustry",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/industries/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelIndustryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成领域经验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelIndustryRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelIndustryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelIndustryResponse
        /// </returns>
        public async Task<HrbrainImportLabelIndustryResponse> HrbrainImportLabelIndustryWithOptionsAsync(HrbrainImportLabelIndustryRequest request, HrbrainImportLabelIndustryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelIndustry",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/industries/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelIndustryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成领域经验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelIndustryRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelIndustryResponse
        /// </returns>
        public HrbrainImportLabelIndustryResponse HrbrainImportLabelIndustry(HrbrainImportLabelIndustryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelIndustryHeaders headers = new HrbrainImportLabelIndustryHeaders();
            return HrbrainImportLabelIndustryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成领域经验</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelIndustryRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelIndustryResponse
        /// </returns>
        public async Task<HrbrainImportLabelIndustryResponse> HrbrainImportLabelIndustryAsync(HrbrainImportLabelIndustryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelIndustryHeaders headers = new HrbrainImportLabelIndustryHeaders();
            return await HrbrainImportLabelIndustryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成盘点数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelInventoryRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelInventoryResponse
        /// </returns>
        public HrbrainImportLabelInventoryResponse HrbrainImportLabelInventoryWithOptions(HrbrainImportLabelInventoryRequest request, HrbrainImportLabelInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelInventory",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/inventories/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelInventoryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成盘点数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelInventoryRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelInventoryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelInventoryResponse
        /// </returns>
        public async Task<HrbrainImportLabelInventoryResponse> HrbrainImportLabelInventoryWithOptionsAsync(HrbrainImportLabelInventoryRequest request, HrbrainImportLabelInventoryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelInventory",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/inventories/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelInventoryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成盘点数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelInventoryResponse
        /// </returns>
        public HrbrainImportLabelInventoryResponse HrbrainImportLabelInventory(HrbrainImportLabelInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelInventoryHeaders headers = new HrbrainImportLabelInventoryHeaders();
            return HrbrainImportLabelInventoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成盘点数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelInventoryRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelInventoryResponse
        /// </returns>
        public async Task<HrbrainImportLabelInventoryResponse> HrbrainImportLabelInventoryAsync(HrbrainImportLabelInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelInventoryHeaders headers = new HrbrainImportLabelInventoryHeaders();
            return await HrbrainImportLabelInventoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成专业技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelProfSkillRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelProfSkillHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelProfSkillResponse
        /// </returns>
        public HrbrainImportLabelProfSkillResponse HrbrainImportLabelProfSkillWithOptions(HrbrainImportLabelProfSkillRequest request, HrbrainImportLabelProfSkillHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelProfSkill",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/profSkills/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelProfSkillResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成专业技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelProfSkillRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportLabelProfSkillHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelProfSkillResponse
        /// </returns>
        public async Task<HrbrainImportLabelProfSkillResponse> HrbrainImportLabelProfSkillWithOptionsAsync(HrbrainImportLabelProfSkillRequest request, HrbrainImportLabelProfSkillHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportLabelProfSkill",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/profSkills/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportLabelProfSkillResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成专业技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelProfSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelProfSkillResponse
        /// </returns>
        public HrbrainImportLabelProfSkillResponse HrbrainImportLabelProfSkill(HrbrainImportLabelProfSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelProfSkillHeaders headers = new HrbrainImportLabelProfSkillHeaders();
            return HrbrainImportLabelProfSkillWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成专业技能</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportLabelProfSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportLabelProfSkillResponse
        /// </returns>
        public async Task<HrbrainImportLabelProfSkillResponse> HrbrainImportLabelProfSkillAsync(HrbrainImportLabelProfSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportLabelProfSkillHeaders headers = new HrbrainImportLabelProfSkillHeaders();
            return await HrbrainImportLabelProfSkillWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成绩效记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPerfEvalRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportPerfEvalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPerfEvalResponse
        /// </returns>
        public HrbrainImportPerfEvalResponse HrbrainImportPerfEvalWithOptions(HrbrainImportPerfEvalRequest request, HrbrainImportPerfEvalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportPerfEval",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/perfRecords/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportPerfEvalResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成绩效记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPerfEvalRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportPerfEvalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPerfEvalResponse
        /// </returns>
        public async Task<HrbrainImportPerfEvalResponse> HrbrainImportPerfEvalWithOptionsAsync(HrbrainImportPerfEvalRequest request, HrbrainImportPerfEvalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportPerfEval",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/perfRecords/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportPerfEvalResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成绩效记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPerfEvalRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPerfEvalResponse
        /// </returns>
        public HrbrainImportPerfEvalResponse HrbrainImportPerfEval(HrbrainImportPerfEvalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportPerfEvalHeaders headers = new HrbrainImportPerfEvalHeaders();
            return HrbrainImportPerfEvalWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成绩效记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPerfEvalRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPerfEvalResponse
        /// </returns>
        public async Task<HrbrainImportPerfEvalResponse> HrbrainImportPerfEvalAsync(HrbrainImportPerfEvalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportPerfEvalHeaders headers = new HrbrainImportPerfEvalHeaders();
            return await HrbrainImportPerfEvalWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成晋升记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPromEvalRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportPromEvalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPromEvalResponse
        /// </returns>
        public HrbrainImportPromEvalResponse HrbrainImportPromEvalWithOptions(HrbrainImportPromEvalRequest request, HrbrainImportPromEvalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportPromEval",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/promRecords/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportPromEvalResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成晋升记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPromEvalRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportPromEvalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPromEvalResponse
        /// </returns>
        public async Task<HrbrainImportPromEvalResponse> HrbrainImportPromEvalWithOptionsAsync(HrbrainImportPromEvalRequest request, HrbrainImportPromEvalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportPromEval",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/promRecords/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportPromEvalResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成晋升记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPromEvalRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPromEvalResponse
        /// </returns>
        public HrbrainImportPromEvalResponse HrbrainImportPromEval(HrbrainImportPromEvalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportPromEvalHeaders headers = new HrbrainImportPromEvalHeaders();
            return HrbrainImportPromEvalWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成晋升记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPromEvalRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPromEvalResponse
        /// </returns>
        public async Task<HrbrainImportPromEvalResponse> HrbrainImportPromEvalAsync(HrbrainImportPromEvalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportPromEvalHeaders headers = new HrbrainImportPromEvalHeaders();
            return await HrbrainImportPromEvalWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成处分记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPunDetailRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportPunDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPunDetailResponse
        /// </returns>
        public HrbrainImportPunDetailResponse HrbrainImportPunDetailWithOptions(HrbrainImportPunDetailRequest request, HrbrainImportPunDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportPunDetail",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/punDetails/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportPunDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成处分记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPunDetailRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportPunDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPunDetailResponse
        /// </returns>
        public async Task<HrbrainImportPunDetailResponse> HrbrainImportPunDetailWithOptionsAsync(HrbrainImportPunDetailRequest request, HrbrainImportPunDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportPunDetail",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/punDetails/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportPunDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成处分记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPunDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPunDetailResponse
        /// </returns>
        public HrbrainImportPunDetailResponse HrbrainImportPunDetail(HrbrainImportPunDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportPunDetailHeaders headers = new HrbrainImportPunDetailHeaders();
            return HrbrainImportPunDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成处分记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportPunDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportPunDetailResponse
        /// </returns>
        public async Task<HrbrainImportPunDetailResponse> HrbrainImportPunDetailAsync(HrbrainImportPunDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportPunDetailHeaders headers = new HrbrainImportPunDetailHeaders();
            return await HrbrainImportPunDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成入职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportRegistRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportRegistHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportRegistResponse
        /// </returns>
        public HrbrainImportRegistResponse HrbrainImportRegistWithOptions(HrbrainImportRegistRequest request, HrbrainImportRegistHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportRegist",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/registerInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportRegistResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成入职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportRegistRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportRegistHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportRegistResponse
        /// </returns>
        public async Task<HrbrainImportRegistResponse> HrbrainImportRegistWithOptionsAsync(HrbrainImportRegistRequest request, HrbrainImportRegistHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportRegist",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/registerInfos/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportRegistResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成入职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportRegistRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportRegistResponse
        /// </returns>
        public HrbrainImportRegistResponse HrbrainImportRegist(HrbrainImportRegistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportRegistHeaders headers = new HrbrainImportRegistHeaders();
            return HrbrainImportRegistWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成入职信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportRegistRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportRegistResponse
        /// </returns>
        public async Task<HrbrainImportRegistResponse> HrbrainImportRegistAsync(HrbrainImportRegistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportRegistHeaders headers = new HrbrainImportRegistHeaders();
            return await HrbrainImportRegistWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成异动记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportTransferEvalRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportTransferEvalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportTransferEvalResponse
        /// </returns>
        public HrbrainImportTransferEvalResponse HrbrainImportTransferEvalWithOptions(HrbrainImportTransferEvalRequest request, HrbrainImportTransferEvalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportTransferEval",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/changeRecords/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportTransferEvalResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成异动记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportTransferEvalRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportTransferEvalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportTransferEvalResponse
        /// </returns>
        public async Task<HrbrainImportTransferEvalResponse> HrbrainImportTransferEvalWithOptionsAsync(HrbrainImportTransferEvalRequest request, HrbrainImportTransferEvalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportTransferEval",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/changeRecords/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportTransferEvalResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成异动记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportTransferEvalRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportTransferEvalResponse
        /// </returns>
        public HrbrainImportTransferEvalResponse HrbrainImportTransferEval(HrbrainImportTransferEvalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportTransferEvalHeaders headers = new HrbrainImportTransferEvalHeaders();
            return HrbrainImportTransferEvalWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成异动记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportTransferEvalRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportTransferEvalResponse
        /// </returns>
        public async Task<HrbrainImportTransferEvalResponse> HrbrainImportTransferEvalAsync(HrbrainImportTransferEvalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportTransferEvalHeaders headers = new HrbrainImportTransferEvalHeaders();
            return await HrbrainImportTransferEvalWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成工作经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportWorkExpRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportWorkExpHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportWorkExpResponse
        /// </returns>
        public HrbrainImportWorkExpResponse HrbrainImportWorkExpWithOptions(HrbrainImportWorkExpRequest request, HrbrainImportWorkExpHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportWorkExp",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/workExperiences/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportWorkExpResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成工作经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportWorkExpRequest
        /// </param>
        /// <param name="headers">
        /// HrbrainImportWorkExpHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportWorkExpResponse
        /// </returns>
        public async Task<HrbrainImportWorkExpResponse> HrbrainImportWorkExpWithOptionsAsync(HrbrainImportWorkExpRequest request, HrbrainImportWorkExpHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "HrbrainImportWorkExp",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/workExperiences/import",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HrbrainImportWorkExpResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成工作经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportWorkExpRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportWorkExpResponse
        /// </returns>
        public HrbrainImportWorkExpResponse HrbrainImportWorkExp(HrbrainImportWorkExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportWorkExpHeaders headers = new HrbrainImportWorkExpHeaders();
            return HrbrainImportWorkExpWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>集成工作经历</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// HrbrainImportWorkExpRequest
        /// </param>
        /// 
        /// <returns>
        /// HrbrainImportWorkExpResponse
        /// </returns>
        public async Task<HrbrainImportWorkExpResponse> HrbrainImportWorkExpAsync(HrbrainImportWorkExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HrbrainImportWorkExpHeaders headers = new HrbrainImportWorkExpHeaders();
            return await HrbrainImportWorkExpWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员标签查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StaffLabelRecordsQueryRequest
        /// </param>
        /// <param name="headers">
        /// StaffLabelRecordsQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StaffLabelRecordsQueryResponse
        /// </returns>
        public StaffLabelRecordsQueryResponse StaffLabelRecordsQueryWithOptions(StaffLabelRecordsQueryRequest request, StaffLabelRecordsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                query["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StaffLabelRecordsQuery",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/labelRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StaffLabelRecordsQueryResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员标签查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StaffLabelRecordsQueryRequest
        /// </param>
        /// <param name="headers">
        /// StaffLabelRecordsQueryHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StaffLabelRecordsQueryResponse
        /// </returns>
        public async Task<StaffLabelRecordsQueryResponse> StaffLabelRecordsQueryWithOptionsAsync(StaffLabelRecordsQueryRequest request, StaffLabelRecordsQueryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingCorpId))
            {
                query["dingCorpId"] = request.DingCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StaffLabelRecordsQuery",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas/labelRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<StaffLabelRecordsQueryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员标签查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StaffLabelRecordsQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// StaffLabelRecordsQueryResponse
        /// </returns>
        public StaffLabelRecordsQueryResponse StaffLabelRecordsQuery(StaffLabelRecordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StaffLabelRecordsQueryHeaders headers = new StaffLabelRecordsQueryHeaders();
            return StaffLabelRecordsQueryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>人员标签查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StaffLabelRecordsQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// StaffLabelRecordsQueryResponse
        /// </returns>
        public async Task<StaffLabelRecordsQueryResponse> StaffLabelRecordsQueryAsync(StaffLabelRecordsQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            StaffLabelRecordsQueryHeaders headers = new StaffLabelRecordsQueryHeaders();
            return await StaffLabelRecordsQueryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步统计基础数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataRequest
        /// </param>
        /// <param name="headers">
        /// SyncDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDataResponse
        /// </returns>
        public SyncDataResponse SyncDataWithOptions(SyncDataRequest request, SyncDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtlTime))
            {
                body["etlTime"] = request.EtlTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaId))
            {
                body["schemaId"] = request.SchemaId;
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
                Action = "SyncData",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步统计基础数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataRequest
        /// </param>
        /// <param name="headers">
        /// SyncDataHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncDataResponse
        /// </returns>
        public async Task<SyncDataResponse> SyncDataWithOptionsAsync(SyncDataRequest request, SyncDataHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataId))
            {
                body["dataId"] = request.DataId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EtlTime))
            {
                body["etlTime"] = request.EtlTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaId))
            {
                body["schemaId"] = request.SchemaId;
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
                Action = "SyncData",
                Version = "hrbrain_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/hrbrain/datas",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步统计基础数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDataResponse
        /// </returns>
        public SyncDataResponse SyncData(SyncDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataHeaders headers = new SyncDataHeaders();
            return SyncDataWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步统计基础数据</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncDataRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncDataResponse
        /// </returns>
        public async Task<SyncDataResponse> SyncDataAsync(SyncDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncDataHeaders headers = new SyncDataHeaders();
            return await SyncDataWithOptionsAsync(request, headers, runtime);
        }

    }
}
