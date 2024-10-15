// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkcontract_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0
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
        /// <para>合同权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractBenefitConsumeRequest
        /// </param>
        /// <param name="headers">
        /// ContractBenefitConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContractBenefitConsumeResponse
        /// </returns>
        public ContractBenefitConsumeResponse ContractBenefitConsumeWithOptions(ContractBenefitConsumeRequest request, ContractBenefitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPoint))
            {
                body["benefitPoint"] = request.BenefitPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeQuota))
            {
                body["consumeQuota"] = request.ConsumeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                body["extParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCorpId))
            {
                body["isvCorpId"] = request.IsvCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUnionId))
            {
                body["optUnionId"] = request.OptUnionId;
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
                Action = "ContractBenefitConsume",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/benefits/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractBenefitConsumeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合同权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractBenefitConsumeRequest
        /// </param>
        /// <param name="headers">
        /// ContractBenefitConsumeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContractBenefitConsumeResponse
        /// </returns>
        public async Task<ContractBenefitConsumeResponse> ContractBenefitConsumeWithOptionsAsync(ContractBenefitConsumeRequest request, ContractBenefitConsumeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BenefitPoint))
            {
                body["benefitPoint"] = request.BenefitPoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeQuota))
            {
                body["consumeQuota"] = request.ConsumeQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                body["extParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvCorpId))
            {
                body["isvCorpId"] = request.IsvCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OptUnionId))
            {
                body["optUnionId"] = request.OptUnionId;
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
                Action = "ContractBenefitConsume",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/benefits/consume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractBenefitConsumeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合同权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractBenefitConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ContractBenefitConsumeResponse
        /// </returns>
        public ContractBenefitConsumeResponse ContractBenefitConsume(ContractBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractBenefitConsumeHeaders headers = new ContractBenefitConsumeHeaders();
            return ContractBenefitConsumeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合同权益核销</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractBenefitConsumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ContractBenefitConsumeResponse
        /// </returns>
        public async Task<ContractBenefitConsumeResponse> ContractBenefitConsumeAsync(ContractBenefitConsumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractBenefitConsumeHeaders headers = new ContractBenefitConsumeHeaders();
            return await ContractBenefitConsumeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryApprovalInfoRequest
        /// </param>
        /// <param name="headers">
        /// EsignQueryApprovalInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryApprovalInfoResponse
        /// </returns>
        public EsignQueryApprovalInfoResponse EsignQueryApprovalInfoWithOptions(EsignQueryApprovalInfoRequest request, EsignQueryApprovalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignFlowId))
            {
                body["esignFlowId"] = request.EsignFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "EsignQueryApprovalInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/approvalInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryApprovalInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryApprovalInfoRequest
        /// </param>
        /// <param name="headers">
        /// EsignQueryApprovalInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryApprovalInfoResponse
        /// </returns>
        public async Task<EsignQueryApprovalInfoResponse> EsignQueryApprovalInfoWithOptionsAsync(EsignQueryApprovalInfoRequest request, EsignQueryApprovalInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignFlowId))
            {
                body["esignFlowId"] = request.EsignFlowId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "EsignQueryApprovalInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/approvalInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryApprovalInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryApprovalInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryApprovalInfoResponse
        /// </returns>
        public EsignQueryApprovalInfoResponse EsignQueryApprovalInfo(EsignQueryApprovalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryApprovalInfoHeaders headers = new EsignQueryApprovalInfoHeaders();
            return EsignQueryApprovalInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询审批单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryApprovalInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryApprovalInfoResponse
        /// </returns>
        public async Task<EsignQueryApprovalInfoResponse> EsignQueryApprovalInfoAsync(EsignQueryApprovalInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryApprovalInfoHeaders headers = new EsignQueryApprovalInfoHeaders();
            return await EsignQueryApprovalInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询授权信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryGrantInfoRequest
        /// </param>
        /// <param name="headers">
        /// EsignQueryGrantInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryGrantInfoResponse
        /// </returns>
        public EsignQueryGrantInfoResponse EsignQueryGrantInfoWithOptions(EsignQueryGrantInfoRequest request, EsignQueryGrantInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "EsignQueryGrantInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/anthInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryGrantInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询授权信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryGrantInfoRequest
        /// </param>
        /// <param name="headers">
        /// EsignQueryGrantInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryGrantInfoResponse
        /// </returns>
        public async Task<EsignQueryGrantInfoResponse> EsignQueryGrantInfoWithOptionsAsync(EsignQueryGrantInfoRequest request, EsignQueryGrantInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "EsignQueryGrantInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/anthInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryGrantInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询授权信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryGrantInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryGrantInfoResponse
        /// </returns>
        public EsignQueryGrantInfoResponse EsignQueryGrantInfo(EsignQueryGrantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryGrantInfoHeaders headers = new EsignQueryGrantInfoHeaders();
            return EsignQueryGrantInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询授权信息接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryGrantInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryGrantInfoResponse
        /// </returns>
        public async Task<EsignQueryGrantInfoResponse> EsignQueryGrantInfoAsync(EsignQueryGrantInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryGrantInfoHeaders headers = new EsignQueryGrantInfoHeaders();
            return await EsignQueryGrantInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询获取免登信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryIdentityByTicketRequest
        /// </param>
        /// <param name="headers">
        /// EsignQueryIdentityByTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryIdentityByTicketResponse
        /// </returns>
        public EsignQueryIdentityByTicketResponse EsignQueryIdentityByTicketWithOptions(EsignQueryIdentityByTicketRequest request, EsignQueryIdentityByTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
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
                Action = "EsignQueryIdentityByTicket",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/tickets/identities/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryIdentityByTicketResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询获取免登信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryIdentityByTicketRequest
        /// </param>
        /// <param name="headers">
        /// EsignQueryIdentityByTicketHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryIdentityByTicketResponse
        /// </returns>
        public async Task<EsignQueryIdentityByTicketResponse> EsignQueryIdentityByTicketWithOptionsAsync(EsignQueryIdentityByTicketRequest request, EsignQueryIdentityByTicketHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                body["ticket"] = request.Ticket;
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
                Action = "EsignQueryIdentityByTicket",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/tickets/identities/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignQueryIdentityByTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询获取免登信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryIdentityByTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryIdentityByTicketResponse
        /// </returns>
        public EsignQueryIdentityByTicketResponse EsignQueryIdentityByTicket(EsignQueryIdentityByTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryIdentityByTicketHeaders headers = new EsignQueryIdentityByTicketHeaders();
            return EsignQueryIdentityByTicketWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>天谷侧查询获取免登信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignQueryIdentityByTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignQueryIdentityByTicketResponse
        /// </returns>
        public async Task<EsignQueryIdentityByTicketResponse> EsignQueryIdentityByTicketAsync(EsignQueryIdentityByTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignQueryIdentityByTicketHeaders headers = new EsignQueryIdentityByTicketHeaders();
            return await EsignQueryIdentityByTicketWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝电子签事件同步回传接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignSyncEventRequest
        /// </param>
        /// <param name="headers">
        /// EsignSyncEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignSyncEventResponse
        /// </returns>
        public EsignSyncEventResponse EsignSyncEventWithOptions(EsignSyncEventRequest request, EsignSyncEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignData))
            {
                body["esignData"] = request.EsignData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "EsignSyncEvent",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/events/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignSyncEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝电子签事件同步回传接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignSyncEventRequest
        /// </param>
        /// <param name="headers">
        /// EsignSyncEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignSyncEventResponse
        /// </returns>
        public async Task<EsignSyncEventResponse> EsignSyncEventWithOptionsAsync(EsignSyncEventRequest request, EsignSyncEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EsignData))
            {
                body["esignData"] = request.EsignData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "EsignSyncEvent",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/events/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignSyncEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝电子签事件同步回传接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignSyncEventRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignSyncEventResponse
        /// </returns>
        public EsignSyncEventResponse EsignSyncEvent(EsignSyncEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignSyncEventHeaders headers = new EsignSyncEventHeaders();
            return EsignSyncEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝电子签事件同步回传接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignSyncEventRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignSyncEventResponse
        /// </returns>
        public async Task<EsignSyncEventResponse> EsignSyncEventAsync(EsignSyncEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignSyncEventHeaders headers = new EsignSyncEventHeaders();
            return await EsignSyncEventWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成工单审查接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishReviewOrderRequest
        /// </param>
        /// <param name="headers">
        /// FinishReviewOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishReviewOrderResponse
        /// </returns>
        public FinishReviewOrderResponse FinishReviewOrderWithOptions(FinishReviewOrderRequest request, FinishReviewOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndFiles))
            {
                body["endFiles"] = request.EndFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
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
                Action = "FinishReviewOrder",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviews/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishReviewOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成工单审查接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishReviewOrderRequest
        /// </param>
        /// <param name="headers">
        /// FinishReviewOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishReviewOrderResponse
        /// </returns>
        public async Task<FinishReviewOrderResponse> FinishReviewOrderWithOptionsAsync(FinishReviewOrderRequest request, FinishReviewOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndFiles))
            {
                body["endFiles"] = request.EndFiles;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
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
                Action = "FinishReviewOrder",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviews/finish",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishReviewOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成工单审查接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishReviewOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishReviewOrderResponse
        /// </returns>
        public FinishReviewOrderResponse FinishReviewOrder(FinishReviewOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinishReviewOrderHeaders headers = new FinishReviewOrderHeaders();
            return FinishReviewOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>完成工单审查接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FinishReviewOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishReviewOrderResponse
        /// </returns>
        public async Task<FinishReviewOrderResponse> FinishReviewOrderAsync(FinishReviewOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinishReviewOrderHeaders headers = new FinishReviewOrderHeaders();
            return await FinishReviewOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝查询智能合同版本接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedContractVersionRequest
        /// </param>
        /// <param name="headers">
        /// QueryAdvancedContractVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedContractVersionResponse
        /// </returns>
        public QueryAdvancedContractVersionResponse QueryAdvancedContractVersionWithOptions(QueryAdvancedContractVersionRequest request, QueryAdvancedContractVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
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
                Action = "QueryAdvancedContractVersion",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/versions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvancedContractVersionResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝查询智能合同版本接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedContractVersionRequest
        /// </param>
        /// <param name="headers">
        /// QueryAdvancedContractVersionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedContractVersionResponse
        /// </returns>
        public async Task<QueryAdvancedContractVersionResponse> QueryAdvancedContractVersionWithOptionsAsync(QueryAdvancedContractVersionRequest request, QueryAdvancedContractVersionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
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
                Action = "QueryAdvancedContractVersion",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/versions/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAdvancedContractVersionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝查询智能合同版本接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedContractVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedContractVersionResponse
        /// </returns>
        public QueryAdvancedContractVersionResponse QueryAdvancedContractVersion(QueryAdvancedContractVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAdvancedContractVersionHeaders headers = new QueryAdvancedContractVersionHeaders();
            return QueryAdvancedContractVersionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>e签宝查询智能合同版本接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryAdvancedContractVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAdvancedContractVersionResponse
        /// </returns>
        public async Task<QueryAdvancedContractVersionResponse> QueryAdvancedContractVersionAsync(QueryAdvancedContractVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAdvancedContractVersionHeaders headers = new QueryAdvancedContractVersionHeaders();
            return await QueryAdvancedContractVersionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送合同相关卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendContractCardRequest
        /// </param>
        /// <param name="headers">
        /// SendContractCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendContractCardResponse
        /// </returns>
        public SendContractCardResponse SendContractCardWithOptions(SendContractCardRequest request, SendContractCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractInfo))
            {
                body["contractInfo"] = request.ContractInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveGroups))
            {
                body["receiveGroups"] = request.ReceiveGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receivers))
            {
                body["receivers"] = request.Receivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sender))
            {
                body["sender"] = request.Sender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncSingleChat))
            {
                body["syncSingleChat"] = request.SyncSingleChat;
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
                Action = "SendContractCard",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendContractCardResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送合同相关卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendContractCardRequest
        /// </param>
        /// <param name="headers">
        /// SendContractCardHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendContractCardResponse
        /// </returns>
        public async Task<SendContractCardResponse> SendContractCardWithOptionsAsync(SendContractCardRequest request, SendContractCardHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                body["cardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractInfo))
            {
                body["contractInfo"] = request.ContractInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessInstanceId))
            {
                body["processInstanceId"] = request.ProcessInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveGroups))
            {
                body["receiveGroups"] = request.ReceiveGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Receivers))
            {
                body["receivers"] = request.Receivers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sender))
            {
                body["sender"] = request.Sender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SyncSingleChat))
            {
                body["syncSingleChat"] = request.SyncSingleChat;
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
                Action = "SendContractCard",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/cards/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendContractCardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送合同相关卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendContractCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendContractCardResponse
        /// </returns>
        public SendContractCardResponse SendContractCard(SendContractCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendContractCardHeaders headers = new SendContractCardHeaders();
            return SendContractCardWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发送合同相关卡片</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SendContractCardRequest
        /// </param>
        /// 
        /// <returns>
        /// SendContractCardResponse
        /// </returns>
        public async Task<SendContractCardResponse> SendContractCardAsync(SendContractCardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendContractCardHeaders headers = new SendContractCardHeaders();
            return await SendContractCardWithOptionsAsync(request, headers, runtime);
        }

    }
}
