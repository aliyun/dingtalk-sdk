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
        /// <para>取消审查工单接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelReviewOrderRequest
        /// </param>
        /// <param name="headers">
        /// CancelReviewOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelReviewOrderResponse
        /// </returns>
        public CancelReviewOrderResponse CancelReviewOrderWithOptions(CancelReviewOrderRequest request, CancelReviewOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelReviewOrder",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviews/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelReviewOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审查工单接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelReviewOrderRequest
        /// </param>
        /// <param name="headers">
        /// CancelReviewOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelReviewOrderResponse
        /// </returns>
        public async Task<CancelReviewOrderResponse> CancelReviewOrderWithOptionsAsync(CancelReviewOrderRequest request, CancelReviewOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CancelReviewOrder",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviews/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelReviewOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审查工单接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelReviewOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelReviewOrderResponse
        /// </returns>
        public CancelReviewOrderResponse CancelReviewOrder(CancelReviewOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelReviewOrderHeaders headers = new CancelReviewOrderHeaders();
            return CancelReviewOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消审查工单接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelReviewOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelReviewOrderResponse
        /// </returns>
        public async Task<CancelReviewOrderResponse> CancelReviewOrderAsync(CancelReviewOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelReviewOrderHeaders headers = new CancelReviewOrderHeaders();
            return await CancelReviewOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询esign文件是否正常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckEsignFileRequest
        /// </param>
        /// <param name="headers">
        /// CheckEsignFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckEsignFileResponse
        /// </returns>
        public CheckEsignFileResponse CheckEsignFileWithOptions(CheckEsignFileRequest request, CheckEsignFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "CheckEsignFile",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esignFiles/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckEsignFileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询esign文件是否正常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckEsignFileRequest
        /// </param>
        /// <param name="headers">
        /// CheckEsignFileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckEsignFileResponse
        /// </returns>
        public async Task<CheckEsignFileResponse> CheckEsignFileWithOptionsAsync(CheckEsignFileRequest request, CheckEsignFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["fileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpaceId))
            {
                body["spaceId"] = request.SpaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
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
                Action = "CheckEsignFile",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esignFiles/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckEsignFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询esign文件是否正常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckEsignFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckEsignFileResponse
        /// </returns>
        public CheckEsignFileResponse CheckEsignFile(CheckEsignFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckEsignFileHeaders headers = new CheckEsignFileHeaders();
            return CheckEsignFileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询esign文件是否正常</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckEsignFileRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckEsignFileResponse
        /// </returns>
        public async Task<CheckEsignFileResponse> CheckEsignFileAsync(CheckEsignFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckEsignFileHeaders headers = new CheckEsignFileHeaders();
            return await CheckEsignFileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai合同审查结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractAiReviewResultNotifyRequest
        /// </param>
        /// <param name="headers">
        /// ContractAiReviewResultNotifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContractAiReviewResultNotifyResponse
        /// </returns>
        public ContractAiReviewResultNotifyResponse ContractAiReviewResultNotifyWithOptions(ContractAiReviewResultNotifyRequest request, ContractAiReviewResultNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractAiReviewCorpId))
            {
                body["contractAiReviewCorpId"] = request.ContractAiReviewCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractAiReviewId))
            {
                body["contractAiReviewId"] = request.ContractAiReviewId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["errorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                body["success"] = request.Success;
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
                Action = "ContractAiReviewResultNotify",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/aiReviews/results/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractAiReviewResultNotifyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai合同审查结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractAiReviewResultNotifyRequest
        /// </param>
        /// <param name="headers">
        /// ContractAiReviewResultNotifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ContractAiReviewResultNotifyResponse
        /// </returns>
        public async Task<ContractAiReviewResultNotifyResponse> ContractAiReviewResultNotifyWithOptionsAsync(ContractAiReviewResultNotifyRequest request, ContractAiReviewResultNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                body["annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractAiReviewCorpId))
            {
                body["contractAiReviewCorpId"] = request.ContractAiReviewCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractAiReviewId))
            {
                body["contractAiReviewId"] = request.ContractAiReviewId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorCode))
            {
                body["errorCode"] = request.ErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                body["errorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Success))
            {
                body["success"] = request.Success;
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
                Action = "ContractAiReviewResultNotify",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/aiReviews/results/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ContractAiReviewResultNotifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai合同审查结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractAiReviewResultNotifyRequest
        /// </param>
        /// 
        /// <returns>
        /// ContractAiReviewResultNotifyResponse
        /// </returns>
        public ContractAiReviewResultNotifyResponse ContractAiReviewResultNotify(ContractAiReviewResultNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractAiReviewResultNotifyHeaders headers = new ContractAiReviewResultNotifyHeaders();
            return ContractAiReviewResultNotifyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ai合同审查结果回调</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ContractAiReviewResultNotifyRequest
        /// </param>
        /// 
        /// <returns>
        /// ContractAiReviewResultNotifyResponse
        /// </returns>
        public async Task<ContractAiReviewResultNotifyResponse> ContractAiReviewResultNotifyAsync(ContractAiReviewResultNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ContractAiReviewResultNotifyHeaders headers = new ContractAiReviewResultNotifyHeaders();
            return await ContractAiReviewResultNotifyWithOptionsAsync(request, headers, runtime);
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
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsCompareTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsCompareTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsCompareTaskResponse
        /// </returns>
        public CreateContractAppsCompareTaskResponse CreateContractAppsCompareTaskWithOptions(CreateContractAppsCompareTaskRequest request, CreateContractAppsCompareTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFile))
            {
                body["comparativeFile"] = request.ComparativeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileDownloadUrl))
            {
                body["comparativeFileDownloadUrl"] = request.ComparativeFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileName))
            {
                body["comparativeFileName"] = request.ComparativeFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFile))
            {
                body["standardFile"] = request.StandardFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileDownloadUrl))
            {
                body["standardFileDownloadUrl"] = request.StandardFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileName))
            {
                body["standardFileName"] = request.StandardFileName;
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
                Action = "CreateContractAppsCompareTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/comparisonTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsCompareTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsCompareTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsCompareTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsCompareTaskResponse
        /// </returns>
        public async Task<CreateContractAppsCompareTaskResponse> CreateContractAppsCompareTaskWithOptionsAsync(CreateContractAppsCompareTaskRequest request, CreateContractAppsCompareTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFile))
            {
                body["comparativeFile"] = request.ComparativeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileDownloadUrl))
            {
                body["comparativeFileDownloadUrl"] = request.ComparativeFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileName))
            {
                body["comparativeFileName"] = request.ComparativeFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFile))
            {
                body["standardFile"] = request.StandardFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileDownloadUrl))
            {
                body["standardFileDownloadUrl"] = request.StandardFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileName))
            {
                body["standardFileName"] = request.StandardFileName;
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
                Action = "CreateContractAppsCompareTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/comparisonTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsCompareTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsCompareTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsCompareTaskResponse
        /// </returns>
        public CreateContractAppsCompareTaskResponse CreateContractAppsCompareTask(CreateContractAppsCompareTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsCompareTaskHeaders headers = new CreateContractAppsCompareTaskHeaders();
            return CreateContractAppsCompareTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsCompareTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsCompareTaskResponse
        /// </returns>
        public async Task<CreateContractAppsCompareTaskResponse> CreateContractAppsCompareTaskAsync(CreateContractAppsCompareTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsCompareTaskHeaders headers = new CreateContractAppsCompareTaskHeaders();
            return await CreateContractAppsCompareTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsExtractTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsExtractTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsExtractTaskResponse
        /// </returns>
        public CreateContractAppsExtractTaskResponse CreateContractAppsExtractTaskWithOptions(CreateContractAppsExtractTaskRequest request, CreateContractAppsExtractTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractKeys))
            {
                body["extractKeys"] = request.ExtractKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "CreateContractAppsExtractTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/extractTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsExtractTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsExtractTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsExtractTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsExtractTaskResponse
        /// </returns>
        public async Task<CreateContractAppsExtractTaskResponse> CreateContractAppsExtractTaskWithOptionsAsync(CreateContractAppsExtractTaskRequest request, CreateContractAppsExtractTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractKeys))
            {
                body["extractKeys"] = request.ExtractKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "CreateContractAppsExtractTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/extractTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsExtractTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsExtractTaskResponse
        /// </returns>
        public CreateContractAppsExtractTaskResponse CreateContractAppsExtractTask(CreateContractAppsExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsExtractTaskHeaders headers = new CreateContractAppsExtractTaskHeaders();
            return CreateContractAppsExtractTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsExtractTaskResponse
        /// </returns>
        public async Task<CreateContractAppsExtractTaskResponse> CreateContractAppsExtractTaskAsync(CreateContractAppsExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsExtractTaskHeaders headers = new CreateContractAppsExtractTaskHeaders();
            return await CreateContractAppsExtractTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsReviewTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsReviewTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsReviewTaskResponse
        /// </returns>
        public CreateContractAppsReviewTaskResponse CreateContractAppsReviewTaskWithOptions(CreateContractAppsReviewTaskRequest request, CreateContractAppsReviewTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewCustomRules))
            {
                body["reviewCustomRules"] = request.ReviewCustomRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Standpoint))
            {
                body["standpoint"] = request.Standpoint;
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
                Action = "CreateContractAppsReviewTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/reviewTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsReviewTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsReviewTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsReviewTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsReviewTaskResponse
        /// </returns>
        public async Task<CreateContractAppsReviewTaskResponse> CreateContractAppsReviewTaskWithOptionsAsync(CreateContractAppsReviewTaskRequest request, CreateContractAppsReviewTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewCustomRules))
            {
                body["reviewCustomRules"] = request.ReviewCustomRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Standpoint))
            {
                body["standpoint"] = request.Standpoint;
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
                Action = "CreateContractAppsReviewTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/reviewTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsReviewTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsReviewTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsReviewTaskResponse
        /// </returns>
        public CreateContractAppsReviewTaskResponse CreateContractAppsReviewTask(CreateContractAppsReviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsReviewTaskHeaders headers = new CreateContractAppsReviewTaskHeaders();
            return CreateContractAppsReviewTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsReviewTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsReviewTaskResponse
        /// </returns>
        public async Task<CreateContractAppsReviewTaskResponse> CreateContractAppsReviewTaskAsync(CreateContractAppsReviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsReviewTaskHeaders headers = new CreateContractAppsReviewTaskHeaders();
            return await CreateContractAppsReviewTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同条款抽取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsTermsExtractEaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsTermsExtractEaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsTermsExtractEaskResponse
        /// </returns>
        public CreateContractAppsTermsExtractEaskResponse CreateContractAppsTermsExtractEaskWithOptions(CreateContractAppsTermsExtractEaskRequest request, CreateContractAppsTermsExtractEaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractRules))
            {
                body["extractRules"] = request.ExtractRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "CreateContractAppsTermsExtractEask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/termsExtractTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsTermsExtractEaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同条款抽取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsTermsExtractEaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractAppsTermsExtractEaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsTermsExtractEaskResponse
        /// </returns>
        public async Task<CreateContractAppsTermsExtractEaskResponse> CreateContractAppsTermsExtractEaskWithOptionsAsync(CreateContractAppsTermsExtractEaskRequest request, CreateContractAppsTermsExtractEaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractRules))
            {
                body["extractRules"] = request.ExtractRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "CreateContractAppsTermsExtractEask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/termsExtractTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractAppsTermsExtractEaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同条款抽取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsTermsExtractEaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsTermsExtractEaskResponse
        /// </returns>
        public CreateContractAppsTermsExtractEaskResponse CreateContractAppsTermsExtractEask(CreateContractAppsTermsExtractEaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsTermsExtractEaskHeaders headers = new CreateContractAppsTermsExtractEaskHeaders();
            return CreateContractAppsTermsExtractEaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同条款抽取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractAppsTermsExtractEaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractAppsTermsExtractEaskResponse
        /// </returns>
        public async Task<CreateContractAppsTermsExtractEaskResponse> CreateContractAppsTermsExtractEaskAsync(CreateContractAppsTermsExtractEaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractAppsTermsExtractEaskHeaders headers = new CreateContractAppsTermsExtractEaskHeaders();
            return await CreateContractAppsTermsExtractEaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractCompareTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractCompareTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractCompareTaskResponse
        /// </returns>
        public CreateContractCompareTaskResponse CreateContractCompareTaskWithOptions(CreateContractCompareTaskRequest request, CreateContractCompareTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFile))
            {
                body["comparativeFile"] = request.ComparativeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileDownloadUrl))
            {
                body["comparativeFileDownloadUrl"] = request.ComparativeFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileName))
            {
                body["comparativeFileName"] = request.ComparativeFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFile))
            {
                body["standardFile"] = request.StandardFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileDownloadUrl))
            {
                body["standardFileDownloadUrl"] = request.StandardFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileName))
            {
                body["standardFileName"] = request.StandardFileName;
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
                Action = "CreateContractCompareTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/comparisonTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractCompareTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractCompareTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractCompareTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractCompareTaskResponse
        /// </returns>
        public async Task<CreateContractCompareTaskResponse> CreateContractCompareTaskWithOptionsAsync(CreateContractCompareTaskRequest request, CreateContractCompareTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFile))
            {
                body["comparativeFile"] = request.ComparativeFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileDownloadUrl))
            {
                body["comparativeFileDownloadUrl"] = request.ComparativeFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComparativeFileName))
            {
                body["comparativeFileName"] = request.ComparativeFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFile))
            {
                body["standardFile"] = request.StandardFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileDownloadUrl))
            {
                body["standardFileDownloadUrl"] = request.StandardFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardFileName))
            {
                body["standardFileName"] = request.StandardFileName;
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
                Action = "CreateContractCompareTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/comparisonTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractCompareTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractCompareTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractCompareTaskResponse
        /// </returns>
        public CreateContractCompareTaskResponse CreateContractCompareTask(CreateContractCompareTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractCompareTaskHeaders headers = new CreateContractCompareTaskHeaders();
            return CreateContractCompareTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同比对任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractCompareTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractCompareTaskResponse
        /// </returns>
        public async Task<CreateContractCompareTaskResponse> CreateContractCompareTaskAsync(CreateContractCompareTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractCompareTaskHeaders headers = new CreateContractCompareTaskHeaders();
            return await CreateContractCompareTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractExtractTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractExtractTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractExtractTaskResponse
        /// </returns>
        public CreateContractExtractTaskResponse CreateContractExtractTaskWithOptions(CreateContractExtractTaskRequest request, CreateContractExtractTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractKeys))
            {
                body["extractKeys"] = request.ExtractKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "CreateContractExtractTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/extractTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractExtractTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractExtractTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractExtractTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractExtractTaskResponse
        /// </returns>
        public async Task<CreateContractExtractTaskResponse> CreateContractExtractTaskWithOptionsAsync(CreateContractExtractTaskRequest request, CreateContractExtractTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractKeys))
            {
                body["extractKeys"] = request.ExtractKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "CreateContractExtractTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/extractTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractExtractTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractExtractTaskResponse
        /// </returns>
        public CreateContractExtractTaskResponse CreateContractExtractTask(CreateContractExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractExtractTaskHeaders headers = new CreateContractExtractTaskHeaders();
            return CreateContractExtractTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractExtractTaskResponse
        /// </returns>
        public async Task<CreateContractExtractTaskResponse> CreateContractExtractTaskAsync(CreateContractExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractExtractTaskHeaders headers = new CreateContractExtractTaskHeaders();
            return await CreateContractExtractTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractReviewTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractReviewTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractReviewTaskResponse
        /// </returns>
        public CreateContractReviewTaskResponse CreateContractReviewTaskWithOptions(CreateContractReviewTaskRequest request, CreateContractReviewTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewCustomRules))
            {
                body["reviewCustomRules"] = request.ReviewCustomRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Standpoint))
            {
                body["standpoint"] = request.Standpoint;
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
                Action = "CreateContractReviewTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviewTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractReviewTaskResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractReviewTaskRequest
        /// </param>
        /// <param name="headers">
        /// CreateContractReviewTaskHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContractReviewTaskResponse
        /// </returns>
        public async Task<CreateContractReviewTaskResponse> CreateContractReviewTaskWithOptionsAsync(CreateContractReviewTaskRequest request, CreateContractReviewTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFile))
            {
                body["contractFile"] = request.ContractFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileDownloadUrl))
            {
                body["contractFileDownloadUrl"] = request.ContractFileDownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractFileName))
            {
                body["contractFileName"] = request.ContractFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSource))
            {
                body["fileSource"] = request.FileSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewCustomRules))
            {
                body["reviewCustomRules"] = request.ReviewCustomRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleType))
            {
                body["ruleType"] = request.RuleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Standpoint))
            {
                body["standpoint"] = request.Standpoint;
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
                Action = "CreateContractReviewTask",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviewTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContractReviewTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractReviewTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractReviewTaskResponse
        /// </returns>
        public CreateContractReviewTaskResponse CreateContractReviewTask(CreateContractReviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractReviewTaskHeaders headers = new CreateContractReviewTaskHeaders();
            return CreateContractReviewTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建合同审查任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateContractReviewTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContractReviewTaskResponse
        /// </returns>
        public async Task<CreateContractReviewTaskResponse> CreateContractReviewTaskAsync(CreateContractReviewTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateContractReviewTaskHeaders headers = new CreateContractReviewTaskHeaders();
            return await CreateContractReviewTaskWithOptionsAsync(request, headers, runtime);
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
        /// <para>校验钉钉用户能否访问e签宝页面接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignUserVerifyRequest
        /// </param>
        /// <param name="headers">
        /// EsignUserVerifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignUserVerifyResponse
        /// </returns>
        public EsignUserVerifyResponse EsignUserVerifyWithOptions(EsignUserVerifyRequest request, EsignUserVerifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
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
                Action = "EsignUserVerify",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/user/verify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignUserVerifyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验钉钉用户能否访问e签宝页面接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignUserVerifyRequest
        /// </param>
        /// <param name="headers">
        /// EsignUserVerifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EsignUserVerifyResponse
        /// </returns>
        public async Task<EsignUserVerifyResponse> EsignUserVerifyWithOptionsAsync(EsignUserVerifyRequest request, EsignUserVerifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
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
                Action = "EsignUserVerify",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/esign/user/verify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<EsignUserVerifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验钉钉用户能否访问e签宝页面接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignUserVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignUserVerifyResponse
        /// </returns>
        public EsignUserVerifyResponse EsignUserVerify(EsignUserVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignUserVerifyHeaders headers = new EsignUserVerifyHeaders();
            return EsignUserVerifyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验钉钉用户能否访问e签宝页面接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EsignUserVerifyRequest
        /// </param>
        /// 
        /// <returns>
        /// EsignUserVerifyResponse
        /// </returns>
        public async Task<EsignUserVerifyResponse> EsignUserVerifyAsync(EsignUserVerifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            EsignUserVerifyHeaders headers = new EsignUserVerifyHeaders();
            return await EsignUserVerifyWithOptionsAsync(request, headers, runtime);
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
        /// <para>开通电子签免费试用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenEsignFreeTrailRequest
        /// </param>
        /// <param name="headers">
        /// OpenEsignFreeTrailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenEsignFreeTrailResponse
        /// </returns>
        public OpenEsignFreeTrailResponse OpenEsignFreeTrailWithOptions(OpenEsignFreeTrailRequest request, OpenEsignFreeTrailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenEsignFreeTrail",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/openEsignFreeTrail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenEsignFreeTrailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通电子签免费试用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenEsignFreeTrailRequest
        /// </param>
        /// <param name="headers">
        /// OpenEsignFreeTrailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenEsignFreeTrailResponse
        /// </returns>
        public async Task<OpenEsignFreeTrailResponse> OpenEsignFreeTrailWithOptionsAsync(OpenEsignFreeTrailRequest request, OpenEsignFreeTrailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "OpenEsignFreeTrail",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/openEsignFreeTrail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenEsignFreeTrailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通电子签免费试用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenEsignFreeTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenEsignFreeTrailResponse
        /// </returns>
        public OpenEsignFreeTrailResponse OpenEsignFreeTrail(OpenEsignFreeTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenEsignFreeTrailHeaders headers = new OpenEsignFreeTrailHeaders();
            return OpenEsignFreeTrailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通电子签免费试用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenEsignFreeTrailRequest
        /// </param>
        /// 
        /// <returns>
        /// OpenEsignFreeTrailResponse
        /// </returns>
        public async Task<OpenEsignFreeTrailResponse> OpenEsignFreeTrailAsync(OpenEsignFreeTrailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            OpenEsignFreeTrailHeaders headers = new OpenEsignFreeTrailHeaders();
            return await OpenEsignFreeTrailWithOptionsAsync(request, headers, runtime);
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
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsCompareResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsCompareResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsCompareResultResponse
        /// </returns>
        public QueryContractAppsCompareResultResponse QueryContractAppsCompareResultWithOptions(QueryContractAppsCompareResultRequest request, QueryContractAppsCompareResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareTaskId))
            {
                body["compareTaskId"] = request.CompareTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractAppsCompareResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/comparisonResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsCompareResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsCompareResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsCompareResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsCompareResultResponse
        /// </returns>
        public async Task<QueryContractAppsCompareResultResponse> QueryContractAppsCompareResultWithOptionsAsync(QueryContractAppsCompareResultRequest request, QueryContractAppsCompareResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareTaskId))
            {
                body["compareTaskId"] = request.CompareTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractAppsCompareResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/comparisonResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsCompareResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsCompareResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsCompareResultResponse
        /// </returns>
        public QueryContractAppsCompareResultResponse QueryContractAppsCompareResult(QueryContractAppsCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsCompareResultHeaders headers = new QueryContractAppsCompareResultHeaders();
            return QueryContractAppsCompareResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsCompareResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsCompareResultResponse
        /// </returns>
        public async Task<QueryContractAppsCompareResultResponse> QueryContractAppsCompareResultAsync(QueryContractAppsCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsCompareResultHeaders headers = new QueryContractAppsCompareResultHeaders();
            return await QueryContractAppsCompareResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsExtractResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsExtractResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsExtractResultResponse
        /// </returns>
        public QueryContractAppsExtractResultResponse QueryContractAppsExtractResultWithOptions(QueryContractAppsExtractResultRequest request, QueryContractAppsExtractResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractTaskId))
            {
                body["extractTaskId"] = request.ExtractTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractAppsExtractResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/extractResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsExtractResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsExtractResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsExtractResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsExtractResultResponse
        /// </returns>
        public async Task<QueryContractAppsExtractResultResponse> QueryContractAppsExtractResultWithOptionsAsync(QueryContractAppsExtractResultRequest request, QueryContractAppsExtractResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractTaskId))
            {
                body["extractTaskId"] = request.ExtractTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractAppsExtractResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/extractResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsExtractResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsExtractResultResponse
        /// </returns>
        public QueryContractAppsExtractResultResponse QueryContractAppsExtractResult(QueryContractAppsExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsExtractResultHeaders headers = new QueryContractAppsExtractResultHeaders();
            return QueryContractAppsExtractResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsExtractResultResponse
        /// </returns>
        public async Task<QueryContractAppsExtractResultResponse> QueryContractAppsExtractResultAsync(QueryContractAppsExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsExtractResultHeaders headers = new QueryContractAppsExtractResultHeaders();
            return await QueryContractAppsExtractResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsReviewResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsReviewResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsReviewResultResponse
        /// </returns>
        public QueryContractAppsReviewResultResponse QueryContractAppsReviewResultWithOptions(QueryContractAppsReviewResultRequest request, QueryContractAppsReviewResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewTaskId))
            {
                body["reviewTaskId"] = request.ReviewTaskId;
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
                Action = "QueryContractAppsReviewResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/reviewResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsReviewResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsReviewResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsReviewResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsReviewResultResponse
        /// </returns>
        public async Task<QueryContractAppsReviewResultResponse> QueryContractAppsReviewResultWithOptionsAsync(QueryContractAppsReviewResultRequest request, QueryContractAppsReviewResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewTaskId))
            {
                body["reviewTaskId"] = request.ReviewTaskId;
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
                Action = "QueryContractAppsReviewResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/reviewResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsReviewResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsReviewResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsReviewResultResponse
        /// </returns>
        public QueryContractAppsReviewResultResponse QueryContractAppsReviewResult(QueryContractAppsReviewResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsReviewResultHeaders headers = new QueryContractAppsReviewResultHeaders();
            return QueryContractAppsReviewResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsReviewResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsReviewResultResponse
        /// </returns>
        public async Task<QueryContractAppsReviewResultResponse> QueryContractAppsReviewResultAsync(QueryContractAppsReviewResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsReviewResultHeaders headers = new QueryContractAppsReviewResultHeaders();
            return await QueryContractAppsReviewResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同条款抽取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsTermsExtractResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsTermsExtractResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsTermsExtractResultResponse
        /// </returns>
        public QueryContractAppsTermsExtractResultResponse QueryContractAppsTermsExtractResultWithOptions(QueryContractAppsTermsExtractResultRequest request, QueryContractAppsTermsExtractResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractTaskId))
            {
                body["extractTaskId"] = request.ExtractTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractAppsTermsExtractResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/termsExtractResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsTermsExtractResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同条款抽取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsTermsExtractResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractAppsTermsExtractResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsTermsExtractResultResponse
        /// </returns>
        public async Task<QueryContractAppsTermsExtractResultResponse> QueryContractAppsTermsExtractResultWithOptionsAsync(QueryContractAppsTermsExtractResultRequest request, QueryContractAppsTermsExtractResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractTaskId))
            {
                body["extractTaskId"] = request.ExtractTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractAppsTermsExtractResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/apps/termsExtractResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractAppsTermsExtractResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同条款抽取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsTermsExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsTermsExtractResultResponse
        /// </returns>
        public QueryContractAppsTermsExtractResultResponse QueryContractAppsTermsExtractResult(QueryContractAppsTermsExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsTermsExtractResultHeaders headers = new QueryContractAppsTermsExtractResultHeaders();
            return QueryContractAppsTermsExtractResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同条款抽取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractAppsTermsExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractAppsTermsExtractResultResponse
        /// </returns>
        public async Task<QueryContractAppsTermsExtractResultResponse> QueryContractAppsTermsExtractResultAsync(QueryContractAppsTermsExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractAppsTermsExtractResultHeaders headers = new QueryContractAppsTermsExtractResultHeaders();
            return await QueryContractAppsTermsExtractResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractCompareResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractCompareResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractCompareResultResponse
        /// </returns>
        public QueryContractCompareResultResponse QueryContractCompareResultWithOptions(QueryContractCompareResultRequest request, QueryContractCompareResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareTaskId))
            {
                body["compareTaskId"] = request.CompareTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractCompareResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/comparisonResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractCompareResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractCompareResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractCompareResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractCompareResultResponse
        /// </returns>
        public async Task<QueryContractCompareResultResponse> QueryContractCompareResultWithOptionsAsync(QueryContractCompareResultRequest request, QueryContractCompareResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompareTaskId))
            {
                body["compareTaskId"] = request.CompareTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractCompareResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/comparisonResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractCompareResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractCompareResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractCompareResultResponse
        /// </returns>
        public QueryContractCompareResultResponse QueryContractCompareResult(QueryContractCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractCompareResultHeaders headers = new QueryContractCompareResultHeaders();
            return QueryContractCompareResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同比对结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractCompareResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractCompareResultResponse
        /// </returns>
        public async Task<QueryContractCompareResultResponse> QueryContractCompareResultAsync(QueryContractCompareResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractCompareResultHeaders headers = new QueryContractCompareResultHeaders();
            return await QueryContractCompareResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractExtractResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractExtractResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractExtractResultResponse
        /// </returns>
        public QueryContractExtractResultResponse QueryContractExtractResultWithOptions(QueryContractExtractResultRequest request, QueryContractExtractResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractTaskId))
            {
                body["extractTaskId"] = request.ExtractTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractExtractResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/extractResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractExtractResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractExtractResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractExtractResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractExtractResultResponse
        /// </returns>
        public async Task<QueryContractExtractResultResponse> QueryContractExtractResultWithOptionsAsync(QueryContractExtractResultRequest request, QueryContractExtractResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtractTaskId))
            {
                body["extractTaskId"] = request.ExtractTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
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
                Action = "QueryContractExtractResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/extractResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractExtractResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractExtractResultResponse
        /// </returns>
        public QueryContractExtractResultResponse QueryContractExtractResult(QueryContractExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractExtractResultHeaders headers = new QueryContractExtractResultHeaders();
            return QueryContractExtractResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同提取结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractExtractResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractExtractResultResponse
        /// </returns>
        public async Task<QueryContractExtractResultResponse> QueryContractExtractResultAsync(QueryContractExtractResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractExtractResultHeaders headers = new QueryContractExtractResultHeaders();
            return await QueryContractExtractResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractReviewResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractReviewResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractReviewResultResponse
        /// </returns>
        public QueryContractReviewResultResponse QueryContractReviewResultWithOptions(QueryContractReviewResultRequest request, QueryContractReviewResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewTaskId))
            {
                body["reviewTaskId"] = request.ReviewTaskId;
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
                Action = "QueryContractReviewResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviewResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractReviewResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractReviewResultRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractReviewResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractReviewResultResponse
        /// </returns>
        public async Task<QueryContractReviewResultResponse> QueryContractReviewResultWithOptionsAsync(QueryContractReviewResultRequest request, QueryContractReviewResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReviewTaskId))
            {
                body["reviewTaskId"] = request.ReviewTaskId;
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
                Action = "QueryContractReviewResult",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/reviewResults/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractReviewResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractReviewResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractReviewResultResponse
        /// </returns>
        public QueryContractReviewResultResponse QueryContractReviewResult(QueryContractReviewResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractReviewResultHeaders headers = new QueryContractReviewResultHeaders();
            return QueryContractReviewResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同审查结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractReviewResultRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractReviewResultResponse
        /// </returns>
        public async Task<QueryContractReviewResultResponse> QueryContractReviewResultAsync(QueryContractReviewResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractReviewResultHeaders headers = new QueryContractReviewResultHeaders();
            return await QueryContractReviewResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同电子签相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractSignInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractSignInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractSignInfoResponse
        /// </returns>
        public QueryContractSignInfoResponse QueryContractSignInfoWithOptions(QueryContractSignInfoRequest request, QueryContractSignInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractBizId))
            {
                query["contractBizId"] = request.ContractBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                query["staffId"] = request.StaffId;
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
                Action = "QueryContractSignInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/queryContractSignInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractSignInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同电子签相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractSignInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryContractSignInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryContractSignInfoResponse
        /// </returns>
        public async Task<QueryContractSignInfoResponse> QueryContractSignInfoWithOptionsAsync(QueryContractSignInfoRequest request, QueryContractSignInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractBizId))
            {
                query["contractBizId"] = request.ContractBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                query["staffId"] = request.StaffId;
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
                Action = "QueryContractSignInfo",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/queryContractSignInfo",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryContractSignInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同电子签相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractSignInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractSignInfoResponse
        /// </returns>
        public QueryContractSignInfoResponse QueryContractSignInfo(QueryContractSignInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractSignInfoHeaders headers = new QueryContractSignInfoHeaders();
            return QueryContractSignInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询合同电子签相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryContractSignInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryContractSignInfoResponse
        /// </returns>
        public async Task<QueryContractSignInfoResponse> QueryContractSignInfoAsync(QueryContractSignInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryContractSignInfoHeaders headers = new QueryContractSignInfoHeaders();
            return await QueryContractSignInfoWithOptionsAsync(request, headers, runtime);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步签署事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncSignEventRequest
        /// </param>
        /// <param name="headers">
        /// SyncSignEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSignEventResponse
        /// </returns>
        public SyncSignEventResponse SyncSignEventWithOptions(SyncSignEventRequest tmpReq, SyncSignEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncSignEventShrinkRequest request = new SyncSignEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "extInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SealType))
            {
                request.SealTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SealType, "sealType", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SignFileList))
            {
                request.SignFileListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SignFileList, "signFileList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractBizId))
            {
                query["contractBizId"] = request.ContractBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                query["extInfo"] = request.ExtInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SealTypeShrink))
            {
                query["sealType"] = request.SealTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignDate))
            {
                query["signDate"] = request.SignDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignFileListShrink))
            {
                query["signFileList"] = request.SignFileListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                query["staffId"] = request.StaffId;
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
                Action = "SyncSignEvent",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/syncSignEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSignEventResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步签署事件</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SyncSignEventRequest
        /// </param>
        /// <param name="headers">
        /// SyncSignEventHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSignEventResponse
        /// </returns>
        public async Task<SyncSignEventResponse> SyncSignEventWithOptionsAsync(SyncSignEventRequest tmpReq, SyncSignEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncSignEventShrinkRequest request = new SyncSignEventShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtInfo))
            {
                request.ExtInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtInfo, "extInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SealType))
            {
                request.SealTypeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SealType, "sealType", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SignFileList))
            {
                request.SignFileListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SignFileList, "signFileList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContractBizId))
            {
                query["contractBizId"] = request.ContractBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfoShrink))
            {
                query["extInfo"] = request.ExtInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SealTypeShrink))
            {
                query["sealType"] = request.SealTypeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignDate))
            {
                query["signDate"] = request.SignDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignFileListShrink))
            {
                query["signFileList"] = request.SignFileListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                query["staffId"] = request.StaffId;
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
                Action = "SyncSignEvent",
                Version = "contract_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/contract/syncSignEvent",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSignEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步签署事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSignEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSignEventResponse
        /// </returns>
        public SyncSignEventResponse SyncSignEvent(SyncSignEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSignEventHeaders headers = new SyncSignEventHeaders();
            return SyncSignEventWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>同步签署事件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncSignEventRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSignEventResponse
        /// </returns>
        public async Task<SyncSignEventResponse> SyncSignEventAsync(SyncSignEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSignEventHeaders headers = new SyncSignEventHeaders();
            return await SyncSignEventWithOptionsAsync(request, headers, runtime);
        }

    }
}
