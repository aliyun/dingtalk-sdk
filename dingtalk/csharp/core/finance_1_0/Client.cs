// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkfinance_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkfinance_1_0
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
         * @summary 批量付款
         *
         * @param request ApplyBatchPayRequest
         * @param headers ApplyBatchPayHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyBatchPayResponse
         */
        public ApplyBatchPayResponse ApplyBatchPayWithOptions(ApplyBatchPayRequest request, ApplyBatchPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassBackParams))
            {
                body["passBackParams"] = request.PassBackParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTerminal))
            {
                body["payTerminal"] = request.PayTerminal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                body["returnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                body["staffId"] = request.StaffId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransAmount))
            {
                body["transAmount"] = request.TransAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransExpireTime))
            {
                body["transExpireTime"] = request.TransExpireTime;
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
                Action = "ApplyBatchPay",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/orders/pay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyBatchPayResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 批量付款
         *
         * @param request ApplyBatchPayRequest
         * @param headers ApplyBatchPayHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApplyBatchPayResponse
         */
        public async Task<ApplyBatchPayResponse> ApplyBatchPayWithOptionsAsync(ApplyBatchPayRequest request, ApplyBatchPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PassBackParams))
            {
                body["passBackParams"] = request.PassBackParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayTerminal))
            {
                body["payTerminal"] = request.PayTerminal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                body["returnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                body["staffId"] = request.StaffId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransAmount))
            {
                body["transAmount"] = request.TransAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransExpireTime))
            {
                body["transExpireTime"] = request.TransExpireTime;
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
                Action = "ApplyBatchPay",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/orders/pay",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyBatchPayResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 批量付款
         *
         * @param request ApplyBatchPayRequest
         * @return ApplyBatchPayResponse
         */
        public ApplyBatchPayResponse ApplyBatchPay(ApplyBatchPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyBatchPayHeaders headers = new ApplyBatchPayHeaders();
            return ApplyBatchPayWithOptions(request, headers, runtime);
        }

        /**
         * @summary 批量付款
         *
         * @param request ApplyBatchPayRequest
         * @return ApplyBatchPayResponse
         */
        public async Task<ApplyBatchPayResponse> ApplyBatchPayAsync(ApplyBatchPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyBatchPayHeaders headers = new ApplyBatchPayHeaders();
            return await ApplyBatchPayWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 助贷业务关闭借款入口
         *
         * @param request CloseLoanEntranceRequest
         * @param headers CloseLoanEntranceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseLoanEntranceResponse
         */
        public CloseLoanEntranceResponse CloseLoanEntranceWithOptions(CloseLoanEntranceRequest request, CloseLoanEntranceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CloseLoanEntrance",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/loans/entrances/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseLoanEntranceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 助贷业务关闭借款入口
         *
         * @param request CloseLoanEntranceRequest
         * @param headers CloseLoanEntranceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloseLoanEntranceResponse
         */
        public async Task<CloseLoanEntranceResponse> CloseLoanEntranceWithOptionsAsync(CloseLoanEntranceRequest request, CloseLoanEntranceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
                Action = "CloseLoanEntrance",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/loans/entrances/close",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloseLoanEntranceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 助贷业务关闭借款入口
         *
         * @param request CloseLoanEntranceRequest
         * @return CloseLoanEntranceResponse
         */
        public CloseLoanEntranceResponse CloseLoanEntrance(CloseLoanEntranceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseLoanEntranceHeaders headers = new CloseLoanEntranceHeaders();
            return CloseLoanEntranceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 助贷业务关闭借款入口
         *
         * @param request CloseLoanEntranceRequest
         * @return CloseLoanEntranceResponse
         */
        public async Task<CloseLoanEntranceResponse> CloseLoanEntranceAsync(CloseLoanEntranceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CloseLoanEntranceHeaders headers = new CloseLoanEntranceHeaders();
            return await CloseLoanEntranceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 子机构创建进件预校验
         *
         * @param request ConsultCreateSubInstitutionRequest
         * @param headers ConsultCreateSubInstitutionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsultCreateSubInstitutionResponse
         */
        public ConsultCreateSubInstitutionResponse ConsultCreateSubInstitutionWithOptions(ConsultCreateSubInstitutionRequest request, ConsultCreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo))
            {
                body["legalPersonCertInfo"] = request.LegalPersonCertInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationInfos))
            {
                body["qualificationInfos"] = request.QualificationInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                body["services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo))
            {
                body["subInstShopInfo"] = request.SubInstShopInfo;
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
                Action = "ConsultCreateSubInstitution",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions/consult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsultCreateSubInstitutionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 子机构创建进件预校验
         *
         * @param request ConsultCreateSubInstitutionRequest
         * @param headers ConsultCreateSubInstitutionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsultCreateSubInstitutionResponse
         */
        public async Task<ConsultCreateSubInstitutionResponse> ConsultCreateSubInstitutionWithOptionsAsync(ConsultCreateSubInstitutionRequest request, ConsultCreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo))
            {
                body["legalPersonCertInfo"] = request.LegalPersonCertInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationInfos))
            {
                body["qualificationInfos"] = request.QualificationInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                body["services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo))
            {
                body["subInstShopInfo"] = request.SubInstShopInfo;
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
                Action = "ConsultCreateSubInstitution",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions/consult",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConsultCreateSubInstitutionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 子机构创建进件预校验
         *
         * @param request ConsultCreateSubInstitutionRequest
         * @return ConsultCreateSubInstitutionResponse
         */
        public ConsultCreateSubInstitutionResponse ConsultCreateSubInstitution(ConsultCreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsultCreateSubInstitutionHeaders headers = new ConsultCreateSubInstitutionHeaders();
            return ConsultCreateSubInstitutionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 子机构创建进件预校验
         *
         * @param request ConsultCreateSubInstitutionRequest
         * @return ConsultCreateSubInstitutionResponse
         */
        public async Task<ConsultCreateSubInstitutionResponse> ConsultCreateSubInstitutionAsync(ConsultCreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsultCreateSubInstitutionHeaders headers = new ConsultCreateSubInstitutionHeaders();
            return await ConsultCreateSubInstitutionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发起代扣交易
         *
         * @param request CreatWithholdingOrderAndPayRequest
         * @param headers CreatWithholdingOrderAndPayHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatWithholdingOrderAndPayResponse
         */
        public CreatWithholdingOrderAndPayResponse CreatWithholdingOrderAndPayWithOptions(CreatWithholdingOrderAndPayRequest request, CreatWithholdingOrderAndPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPayChannelDetailInfoList))
            {
                body["otherPayChannelDetailInfoList"] = request.OtherPayChannelDetailInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerUserId))
            {
                body["payerUserId"] = request.PayerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeOutExpress))
            {
                body["timeOutExpress"] = request.TimeOutExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreatWithholdingOrderAndPay",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/withholdingOrders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatWithholdingOrderAndPayResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 发起代扣交易
         *
         * @param request CreatWithholdingOrderAndPayRequest
         * @param headers CreatWithholdingOrderAndPayHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatWithholdingOrderAndPayResponse
         */
        public async Task<CreatWithholdingOrderAndPayResponse> CreatWithholdingOrderAndPayWithOptionsAsync(CreatWithholdingOrderAndPayRequest request, CreatWithholdingOrderAndPayHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPayChannelDetailInfoList))
            {
                body["otherPayChannelDetailInfoList"] = request.OtherPayChannelDetailInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayerUserId))
            {
                body["payerUserId"] = request.PayerUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeOutExpress))
            {
                body["timeOutExpress"] = request.TimeOutExpress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreatWithholdingOrderAndPay",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/withholdingOrders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatWithholdingOrderAndPayResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 发起代扣交易
         *
         * @param request CreatWithholdingOrderAndPayRequest
         * @return CreatWithholdingOrderAndPayResponse
         */
        public CreatWithholdingOrderAndPayResponse CreatWithholdingOrderAndPay(CreatWithholdingOrderAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatWithholdingOrderAndPayHeaders headers = new CreatWithholdingOrderAndPayHeaders();
            return CreatWithholdingOrderAndPayWithOptions(request, headers, runtime);
        }

        /**
         * @summary 发起代扣交易
         *
         * @param request CreatWithholdingOrderAndPayRequest
         * @return CreatWithholdingOrderAndPayResponse
         */
        public async Task<CreatWithholdingOrderAndPayResponse> CreatWithholdingOrderAndPayAsync(CreatWithholdingOrderAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatWithholdingOrderAndPayHeaders headers = new CreatWithholdingOrderAndPayHeaders();
            return await CreatWithholdingOrderAndPayWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 收单退款交易
         *
         * @param request CreateAcquireRefundOrderRequest
         * @param headers CreateAcquireRefundOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAcquireRefundOrderResponse
         */
        public CreateAcquireRefundOrderResponse CreateAcquireRefundOrderWithOptions(CreateAcquireRefundOrderRequest request, CreateAcquireRefundOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginOutTradeNo))
            {
                body["originOutTradeNo"] = request.OriginOutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPayChannelDetailInfoList))
            {
                body["otherPayChannelDetailInfoList"] = request.OtherPayChannelDetailInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRefundNo))
            {
                body["outRefundNo"] = request.OutRefundNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateAcquireRefundOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/acquireOrders/refund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAcquireRefundOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 收单退款交易
         *
         * @param request CreateAcquireRefundOrderRequest
         * @param headers CreateAcquireRefundOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAcquireRefundOrderResponse
         */
        public async Task<CreateAcquireRefundOrderResponse> CreateAcquireRefundOrderWithOptionsAsync(CreateAcquireRefundOrderRequest request, CreateAcquireRefundOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUserId))
            {
                body["operatorUserId"] = request.OperatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OriginOutTradeNo))
            {
                body["originOutTradeNo"] = request.OriginOutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtherPayChannelDetailInfoList))
            {
                body["otherPayChannelDetailInfoList"] = request.OtherPayChannelDetailInfoList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRefundNo))
            {
                body["outRefundNo"] = request.OutRefundNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
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
                Action = "CreateAcquireRefundOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/acquireOrders/refund",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAcquireRefundOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 收单退款交易
         *
         * @param request CreateAcquireRefundOrderRequest
         * @return CreateAcquireRefundOrderResponse
         */
        public CreateAcquireRefundOrderResponse CreateAcquireRefundOrder(CreateAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAcquireRefundOrderHeaders headers = new CreateAcquireRefundOrderHeaders();
            return CreateAcquireRefundOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 收单退款交易
         *
         * @param request CreateAcquireRefundOrderRequest
         * @return CreateAcquireRefundOrderResponse
         */
        public async Task<CreateAcquireRefundOrderResponse> CreateAcquireRefundOrderAsync(CreateAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAcquireRefundOrderHeaders headers = new CreateAcquireRefundOrderHeaders();
            return await CreateAcquireRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建批量支付单
         *
         * @param request CreateBatchTradeOrderRequest
         * @param headers CreateBatchTradeOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBatchTradeOrderResponse
         */
        public CreateBatchTradeOrderResponse CreateBatchTradeOrderWithOptions(CreateBatchTradeOrderRequest request, CreateBatchTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["accountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchRemark))
            {
                body["batchRemark"] = request.BatchRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTradeDetails))
            {
                body["batchTradeDetails"] = request.BatchTradeDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBatchNo))
            {
                body["outBatchNo"] = request.OutBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                body["staffId"] = request.StaffId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalCount))
            {
                body["totalCount"] = request.TotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTitle))
            {
                body["tradeTitle"] = request.TradeTitle;
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
                Action = "CreateBatchTradeOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchTradeOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建批量支付单
         *
         * @param request CreateBatchTradeOrderRequest
         * @param headers CreateBatchTradeOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBatchTradeOrderResponse
         */
        public async Task<CreateBatchTradeOrderResponse> CreateBatchTradeOrderWithOptionsAsync(CreateBatchTradeOrderRequest request, CreateBatchTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["accountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountNo))
            {
                body["accountNo"] = request.AccountNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchRemark))
            {
                body["batchRemark"] = request.BatchRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchTradeDetails))
            {
                body["batchTradeDetails"] = request.BatchTradeDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBatchNo))
            {
                body["outBatchNo"] = request.OutBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StaffId))
            {
                body["staffId"] = request.StaffId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalCount))
            {
                body["totalCount"] = request.TotalCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTitle))
            {
                body["tradeTitle"] = request.TradeTitle;
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
                Action = "CreateBatchTradeOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/orders",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBatchTradeOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建批量支付单
         *
         * @param request CreateBatchTradeOrderRequest
         * @return CreateBatchTradeOrderResponse
         */
        public CreateBatchTradeOrderResponse CreateBatchTradeOrder(CreateBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBatchTradeOrderHeaders headers = new CreateBatchTradeOrderHeaders();
            return CreateBatchTradeOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建批量支付单
         *
         * @param request CreateBatchTradeOrderRequest
         * @return CreateBatchTradeOrderResponse
         */
        public async Task<CreateBatchTradeOrderResponse> CreateBatchTradeOrderAsync(CreateBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBatchTradeOrderHeaders headers = new CreateBatchTradeOrderHeaders();
            return await CreateBatchTradeOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建子机构
         *
         * @param request CreateSubInstitutionRequest
         * @param headers CreateSubInstitutionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubInstitutionResponse
         */
        public CreateSubInstitutionResponse CreateSubInstitutionWithOptions(CreateSubInstitutionRequest request, CreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo))
            {
                body["legalPersonCertInfo"] = request.LegalPersonCertInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationInfos))
            {
                body["qualificationInfos"] = request.QualificationInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                body["services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo))
            {
                body["subInstShopInfo"] = request.SubInstShopInfo;
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
                Action = "CreateSubInstitution",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubInstitutionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建子机构
         *
         * @param request CreateSubInstitutionRequest
         * @param headers CreateSubInstitutionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSubInstitutionResponse
         */
        public async Task<CreateSubInstitutionResponse> CreateSubInstitutionWithOptionsAsync(CreateSubInstitutionRequest request, CreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo))
            {
                body["legalPersonCertInfo"] = request.LegalPersonCertInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationInfos))
            {
                body["qualificationInfos"] = request.QualificationInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                body["services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo))
            {
                body["subInstShopInfo"] = request.SubInstShopInfo;
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
                Action = "CreateSubInstitution",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSubInstitutionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建子机构
         *
         * @param request CreateSubInstitutionRequest
         * @return CreateSubInstitutionResponse
         */
        public CreateSubInstitutionResponse CreateSubInstitution(CreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubInstitutionHeaders headers = new CreateSubInstitutionHeaders();
            return CreateSubInstitutionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建子机构
         *
         * @param request CreateSubInstitutionRequest
         * @return CreateSubInstitutionResponse
         */
        public async Task<CreateSubInstitutionResponse> CreateSubInstitutionAsync(CreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubInstitutionHeaders headers = new CreateSubInstitutionHeaders();
            return await CreateSubInstitutionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建用户码实例
         *
         * @param request CreateUserCodeInstanceRequest
         * @param headers CreateUserCodeInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserCodeInstanceResponse
         */
        public CreateUserCodeInstanceResponse CreateUserCodeInstanceWithOptions(CreateUserCodeInstanceRequest request, CreateUserCodeInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvailableTimes))
            {
                body["availableTimes"] = request.AvailableTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeIdentity))
            {
                body["codeIdentity"] = request.CodeIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValue))
            {
                body["codeValue"] = request.CodeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValueType))
            {
                body["codeValueType"] = request.CodeValueType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtExpired))
            {
                body["gmtExpired"] = request.GmtExpired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
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
                Action = "CreateUserCodeInstance",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/userInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserCodeInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建用户码实例
         *
         * @param request CreateUserCodeInstanceRequest
         * @param headers CreateUserCodeInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserCodeInstanceResponse
         */
        public async Task<CreateUserCodeInstanceResponse> CreateUserCodeInstanceWithOptionsAsync(CreateUserCodeInstanceRequest request, CreateUserCodeInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvailableTimes))
            {
                body["availableTimes"] = request.AvailableTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeIdentity))
            {
                body["codeIdentity"] = request.CodeIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValue))
            {
                body["codeValue"] = request.CodeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValueType))
            {
                body["codeValueType"] = request.CodeValueType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtExpired))
            {
                body["gmtExpired"] = request.GmtExpired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
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
                Action = "CreateUserCodeInstance",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/userInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserCodeInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建用户码实例
         *
         * @param request CreateUserCodeInstanceRequest
         * @return CreateUserCodeInstanceResponse
         */
        public CreateUserCodeInstanceResponse CreateUserCodeInstance(CreateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserCodeInstanceHeaders headers = new CreateUserCodeInstanceHeaders();
            return CreateUserCodeInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建用户码实例
         *
         * @param request CreateUserCodeInstanceRequest
         * @return CreateUserCodeInstanceResponse
         */
        public async Task<CreateUserCodeInstanceResponse> CreateUserCodeInstanceAsync(CreateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserCodeInstanceHeaders headers = new CreateUserCodeInstanceHeaders();
            return await CreateUserCodeInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 解码付款码
         *
         * @param request DecodePayCodeRequest
         * @param headers DecodePayCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecodePayCodeResponse
         */
        public DecodePayCodeResponse DecodePayCodeWithOptions(DecodePayCodeRequest request, DecodePayCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
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
                Action = "DecodePayCode",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/decode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodePayCodeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 解码付款码
         *
         * @param request DecodePayCodeRequest
         * @param headers DecodePayCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecodePayCodeResponse
         */
        public async Task<DecodePayCodeResponse> DecodePayCodeWithOptionsAsync(DecodePayCodeRequest request, DecodePayCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
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
                Action = "DecodePayCode",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/decode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodePayCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 解码付款码
         *
         * @param request DecodePayCodeRequest
         * @return DecodePayCodeResponse
         */
        public DecodePayCodeResponse DecodePayCode(DecodePayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DecodePayCodeHeaders headers = new DecodePayCodeHeaders();
            return DecodePayCodeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 解码付款码
         *
         * @param request DecodePayCodeRequest
         * @return DecodePayCodeResponse
         */
        public async Task<DecodePayCodeResponse> DecodePayCodeAsync(DecodePayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DecodePayCodeHeaders headers = new DecodePayCodeHeaders();
            return await DecodePayCodeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 企业金融助贷业务进件通知接口
         *
         * @param request FinanceLoanNotifyRegisterRequest
         * @param headers FinanceLoanNotifyRegisterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinanceLoanNotifyRegisterResponse
         */
        public FinanceLoanNotifyRegisterResponse FinanceLoanNotifyRegisterWithOptions(FinanceLoanNotifyRegisterRequest request, FinanceLoanNotifyRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompleteTime))
            {
                body["completeTime"] = request.CompleteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNo))
            {
                body["idCardNo"] = request.IdCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenChannelName))
            {
                body["openChannelName"] = request.OpenChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProductCode))
            {
                body["openProductCode"] = request.OpenProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProductName))
            {
                body["openProductName"] = request.OpenProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProductType))
            {
                body["openProductType"] = request.OpenProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessingStatus))
            {
                body["processingStatus"] = request.ProcessingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefuseCode))
            {
                body["refuseCode"] = request.RefuseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefuseReason))
            {
                body["refuseReason"] = request.RefuseReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNo))
            {
                body["registerNo"] = request.RegisterNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                body["submitTime"] = request.SubmitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMobile))
            {
                body["userMobile"] = request.UserMobile;
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
                Action = "FinanceLoanNotifyRegister",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/loans/notifications/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinanceLoanNotifyRegisterResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 企业金融助贷业务进件通知接口
         *
         * @param request FinanceLoanNotifyRegisterRequest
         * @param headers FinanceLoanNotifyRegisterHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return FinanceLoanNotifyRegisterResponse
         */
        public async Task<FinanceLoanNotifyRegisterResponse> FinanceLoanNotifyRegisterWithOptionsAsync(FinanceLoanNotifyRegisterRequest request, FinanceLoanNotifyRegisterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompleteTime))
            {
                body["completeTime"] = request.CompleteTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdCardNo))
            {
                body["idCardNo"] = request.IdCardNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenChannelName))
            {
                body["openChannelName"] = request.OpenChannelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProductCode))
            {
                body["openProductCode"] = request.OpenProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProductName))
            {
                body["openProductName"] = request.OpenProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenProductType))
            {
                body["openProductType"] = request.OpenProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessingStatus))
            {
                body["processingStatus"] = request.ProcessingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefuseCode))
            {
                body["refuseCode"] = request.RefuseCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefuseReason))
            {
                body["refuseReason"] = request.RefuseReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegisterNo))
            {
                body["registerNo"] = request.RegisterNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubmitTime))
            {
                body["submitTime"] = request.SubmitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserMobile))
            {
                body["userMobile"] = request.UserMobile;
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
                Action = "FinanceLoanNotifyRegister",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/loans/notifications/register",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinanceLoanNotifyRegisterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 企业金融助贷业务进件通知接口
         *
         * @param request FinanceLoanNotifyRegisterRequest
         * @return FinanceLoanNotifyRegisterResponse
         */
        public FinanceLoanNotifyRegisterResponse FinanceLoanNotifyRegister(FinanceLoanNotifyRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinanceLoanNotifyRegisterHeaders headers = new FinanceLoanNotifyRegisterHeaders();
            return FinanceLoanNotifyRegisterWithOptions(request, headers, runtime);
        }

        /**
         * @summary 企业金融助贷业务进件通知接口
         *
         * @param request FinanceLoanNotifyRegisterRequest
         * @return FinanceLoanNotifyRegisterResponse
         */
        public async Task<FinanceLoanNotifyRegisterResponse> FinanceLoanNotifyRegisterAsync(FinanceLoanNotifyRegisterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            FinanceLoanNotifyRegisterHeaders headers = new FinanceLoanNotifyRegisterHeaders();
            return await FinanceLoanNotifyRegisterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 修改子机构信息
         *
         * @param request ModifySubInstitutionRequest
         * @param headers ModifySubInstitutionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySubInstitutionResponse
         */
        public ModifySubInstitutionResponse ModifySubInstitutionWithOptions(ModifySubInstitutionRequest request, ModifySubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo))
            {
                body["legalPersonCertInfo"] = request.LegalPersonCertInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationInfos))
            {
                body["qualificationInfos"] = request.QualificationInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                body["services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo))
            {
                body["subInstShopInfo"] = request.SubInstShopInfo;
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
                Action = "ModifySubInstitution",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubInstitutionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 修改子机构信息
         *
         * @param request ModifySubInstitutionRequest
         * @param headers ModifySubInstitutionHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifySubInstitutionResponse
         */
        public async Task<ModifySubInstitutionResponse> ModifySubInstitutionWithOptionsAsync(ModifySubInstitutionRequest request, ModifySubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo))
            {
                body["legalPersonCertInfo"] = request.LegalPersonCertInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                body["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualificationInfos))
            {
                body["qualificationInfos"] = request.QualificationInfos;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Services))
            {
                body["services"] = request.Services;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo))
            {
                body["subInstShopInfo"] = request.SubInstShopInfo;
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
                Action = "ModifySubInstitution",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions/modify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySubInstitutionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 修改子机构信息
         *
         * @param request ModifySubInstitutionRequest
         * @return ModifySubInstitutionResponse
         */
        public ModifySubInstitutionResponse ModifySubInstitution(ModifySubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifySubInstitutionHeaders headers = new ModifySubInstitutionHeaders();
            return ModifySubInstitutionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 修改子机构信息
         *
         * @param request ModifySubInstitutionRequest
         * @return ModifySubInstitutionResponse
         */
        public async Task<ModifySubInstitutionResponse> ModifySubInstitutionAsync(ModifySubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifySubInstitutionHeaders headers = new ModifySubInstitutionHeaders();
            return await ModifySubInstitutionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通知付款码支付结果
         *
         * @param request NotifyPayCodePayResultRequest
         * @param headers NotifyPayCodePayResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NotifyPayCodePayResultResponse
         */
        public NotifyPayCodePayResultResponse NotifyPayCodePayResultWithOptions(NotifyPayCodePayResultRequest request, NotifyPayCodePayResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeAmount))
            {
                body["chargeAmount"] = request.ChargeAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtTradeCreate))
            {
                body["gmtTradeCreate"] = request.GmtTradeCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtTradeFinish))
            {
                body["gmtTradeFinish"] = request.GmtTradeFinish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantName))
            {
                body["merchantName"] = request.MerchantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannelDetailList))
            {
                body["payChannelDetailList"] = request.PayChannelDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionAmount))
            {
                body["promotionAmount"] = request.PromotionAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeErrorCode))
            {
                body["tradeErrorCode"] = request.TradeErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeErrorMsg))
            {
                body["tradeErrorMsg"] = request.TradeErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["tradeNo"] = request.TradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeStatus))
            {
                body["tradeStatus"] = request.TradeStatus;
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
                Action = "NotifyPayCodePayResult",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/payResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyPayCodePayResultResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通知付款码支付结果
         *
         * @param request NotifyPayCodePayResultRequest
         * @param headers NotifyPayCodePayResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NotifyPayCodePayResultResponse
         */
        public async Task<NotifyPayCodePayResultResponse> NotifyPayCodePayResultWithOptionsAsync(NotifyPayCodePayResultRequest request, NotifyPayCodePayResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                body["amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeAmount))
            {
                body["chargeAmount"] = request.ChargeAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtTradeCreate))
            {
                body["gmtTradeCreate"] = request.GmtTradeCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtTradeFinish))
            {
                body["gmtTradeFinish"] = request.GmtTradeFinish;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantName))
            {
                body["merchantName"] = request.MerchantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannelDetailList))
            {
                body["payChannelDetailList"] = request.PayChannelDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PromotionAmount))
            {
                body["promotionAmount"] = request.PromotionAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeErrorCode))
            {
                body["tradeErrorCode"] = request.TradeErrorCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeErrorMsg))
            {
                body["tradeErrorMsg"] = request.TradeErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["tradeNo"] = request.TradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeStatus))
            {
                body["tradeStatus"] = request.TradeStatus;
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
                Action = "NotifyPayCodePayResult",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/payResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyPayCodePayResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通知付款码支付结果
         *
         * @param request NotifyPayCodePayResultRequest
         * @return NotifyPayCodePayResultResponse
         */
        public NotifyPayCodePayResultResponse NotifyPayCodePayResult(NotifyPayCodePayResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodePayResultHeaders headers = new NotifyPayCodePayResultHeaders();
            return NotifyPayCodePayResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通知付款码支付结果
         *
         * @param request NotifyPayCodePayResultRequest
         * @return NotifyPayCodePayResultResponse
         */
        public async Task<NotifyPayCodePayResultResponse> NotifyPayCodePayResultAsync(NotifyPayCodePayResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodePayResultHeaders headers = new NotifyPayCodePayResultHeaders();
            return await NotifyPayCodePayResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通知付款码退款结果
         *
         * @param request NotifyPayCodeRefundResultRequest
         * @param headers NotifyPayCodeRefundResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NotifyPayCodeRefundResultResponse
         */
        public NotifyPayCodeRefundResultResponse NotifyPayCodeRefundResultWithOptions(NotifyPayCodeRefundResultRequest request, NotifyPayCodeRefundResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtRefund))
            {
                body["gmtRefund"] = request.GmtRefund;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannelDetailList))
            {
                body["payChannelDetailList"] = request.PayChannelDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundOrderNo))
            {
                body["refundOrderNo"] = request.RefundOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundPromotionAmount))
            {
                body["refundPromotionAmount"] = request.RefundPromotionAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["tradeNo"] = request.TradeNo;
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
                Action = "NotifyPayCodeRefundResult",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/refundResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyPayCodeRefundResultResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通知付款码退款结果
         *
         * @param request NotifyPayCodeRefundResultRequest
         * @param headers NotifyPayCodeRefundResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NotifyPayCodeRefundResultResponse
         */
        public async Task<NotifyPayCodeRefundResultResponse> NotifyPayCodeRefundResultWithOptionsAsync(NotifyPayCodeRefundResultRequest request, NotifyPayCodeRefundResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtRefund))
            {
                body["gmtRefund"] = request.GmtRefund;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannelDetailList))
            {
                body["payChannelDetailList"] = request.PayChannelDetailList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundOrderNo))
            {
                body["refundOrderNo"] = request.RefundOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundPromotionAmount))
            {
                body["refundPromotionAmount"] = request.RefundPromotionAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeNo))
            {
                body["tradeNo"] = request.TradeNo;
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
                Action = "NotifyPayCodeRefundResult",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/refundResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyPayCodeRefundResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通知付款码退款结果
         *
         * @param request NotifyPayCodeRefundResultRequest
         * @return NotifyPayCodeRefundResultResponse
         */
        public NotifyPayCodeRefundResultResponse NotifyPayCodeRefundResult(NotifyPayCodeRefundResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodeRefundResultHeaders headers = new NotifyPayCodeRefundResultHeaders();
            return NotifyPayCodeRefundResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通知付款码退款结果
         *
         * @param request NotifyPayCodeRefundResultRequest
         * @return NotifyPayCodeRefundResultResponse
         */
        public async Task<NotifyPayCodeRefundResultResponse> NotifyPayCodeRefundResultAsync(NotifyPayCodeRefundResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodeRefundResultHeaders headers = new NotifyPayCodeRefundResultHeaders();
            return await NotifyPayCodeRefundResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 上报码验证结果
         *
         * @param request NotifyVerifyResultRequest
         * @param headers NotifyVerifyResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NotifyVerifyResultResponse
         */
        public NotifyVerifyResultResponse NotifyVerifyResultWithOptions(NotifyVerifyResultRequest request, NotifyVerifyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyEvent))
            {
                body["verifyEvent"] = request.VerifyEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyLocation))
            {
                body["verifyLocation"] = request.VerifyLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyNo))
            {
                body["verifyNo"] = request.VerifyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyResult))
            {
                body["verifyResult"] = request.VerifyResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyTime))
            {
                body["verifyTime"] = request.VerifyTime;
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
                Action = "NotifyVerifyResult",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/verifyResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyVerifyResultResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 上报码验证结果
         *
         * @param request NotifyVerifyResultRequest
         * @param headers NotifyVerifyResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return NotifyVerifyResultResponse
         */
        public async Task<NotifyVerifyResultResponse> NotifyVerifyResultWithOptionsAsync(NotifyVerifyResultRequest request, NotifyVerifyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyEvent))
            {
                body["verifyEvent"] = request.VerifyEvent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyLocation))
            {
                body["verifyLocation"] = request.VerifyLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyNo))
            {
                body["verifyNo"] = request.VerifyNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyResult))
            {
                body["verifyResult"] = request.VerifyResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyTime))
            {
                body["verifyTime"] = request.VerifyTime;
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
                Action = "NotifyVerifyResult",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/verifyResults/notify",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyVerifyResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 上报码验证结果
         *
         * @param request NotifyVerifyResultRequest
         * @return NotifyVerifyResultResponse
         */
        public NotifyVerifyResultResponse NotifyVerifyResult(NotifyVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyVerifyResultHeaders headers = new NotifyVerifyResultHeaders();
            return NotifyVerifyResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary 上报码验证结果
         *
         * @param request NotifyVerifyResultRequest
         * @return NotifyVerifyResultResponse
         */
        public async Task<NotifyVerifyResultResponse> NotifyVerifyResultAsync(NotifyVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyVerifyResultHeaders headers = new NotifyVerifyResultHeaders();
            return await NotifyVerifyResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 预创建群收款订单返回订单号
         *
         * @param request PreCreateGroupBillOrderRequest
         * @param headers PreCreateGroupBillOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreCreateGroupBillOrderResponse
         */
        public PreCreateGroupBillOrderResponse PreCreateGroupBillOrderWithOptions(PreCreateGroupBillOrderRequest request, PreCreateGroupBillOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillItemList))
            {
                body["billItemList"] = request.BillItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                body["extParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadCount))
            {
                body["headCount"] = request.HeadCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAverageAmount))
            {
                body["isAverageAmount"] = request.IsAverageAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["merchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCid))
            {
                body["openCid"] = request.OpenCid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNo))
            {
                body["outBizNo"] = request.OutBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeCorpId))
            {
                body["payeeCorpId"] = request.PayeeCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeUnionId))
            {
                body["payeeUnionId"] = request.PayeeUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
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
                Action = "PreCreateGroupBillOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/groupbills/preCreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCreateGroupBillOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 预创建群收款订单返回订单号
         *
         * @param request PreCreateGroupBillOrderRequest
         * @param headers PreCreateGroupBillOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return PreCreateGroupBillOrderResponse
         */
        public async Task<PreCreateGroupBillOrderResponse> PreCreateGroupBillOrderWithOptionsAsync(PreCreateGroupBillOrderRequest request, PreCreateGroupBillOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillItemList))
            {
                body["billItemList"] = request.BillItemList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtParams))
            {
                body["extParams"] = request.ExtParams;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HeadCount))
            {
                body["headCount"] = request.HeadCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAverageAmount))
            {
                body["isAverageAmount"] = request.IsAverageAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MerchantId))
            {
                body["merchantId"] = request.MerchantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenCid))
            {
                body["openCid"] = request.OpenCid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizNo))
            {
                body["outBizNo"] = request.OutBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeCorpId))
            {
                body["payeeCorpId"] = request.PayeeCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayeeUnionId))
            {
                body["payeeUnionId"] = request.PayeeUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
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
                Action = "PreCreateGroupBillOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/groupbills/preCreate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCreateGroupBillOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 预创建群收款订单返回订单号
         *
         * @param request PreCreateGroupBillOrderRequest
         * @return PreCreateGroupBillOrderResponse
         */
        public PreCreateGroupBillOrderResponse PreCreateGroupBillOrder(PreCreateGroupBillOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreCreateGroupBillOrderHeaders headers = new PreCreateGroupBillOrderHeaders();
            return PreCreateGroupBillOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 预创建群收款订单返回订单号
         *
         * @param request PreCreateGroupBillOrderRequest
         * @return PreCreateGroupBillOrderResponse
         */
        public async Task<PreCreateGroupBillOrderResponse> PreCreateGroupBillOrderAsync(PreCreateGroupBillOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreCreateGroupBillOrderHeaders headers = new PreCreateGroupBillOrderHeaders();
            return await PreCreateGroupBillOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询收单退款交易
         *
         * @param request QueryAcquireRefundOrderRequest
         * @param headers QueryAcquireRefundOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAcquireRefundOrderResponse
         */
        public QueryAcquireRefundOrderResponse QueryAcquireRefundOrderWithOptions(QueryAcquireRefundOrderRequest request, QueryAcquireRefundOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRefundNo))
            {
                query["outRefundNo"] = request.OutRefundNo;
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
                Action = "QueryAcquireRefundOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/acquireOrders/refunds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAcquireRefundOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询收单退款交易
         *
         * @param request QueryAcquireRefundOrderRequest
         * @param headers QueryAcquireRefundOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryAcquireRefundOrderResponse
         */
        public async Task<QueryAcquireRefundOrderResponse> QueryAcquireRefundOrderWithOptionsAsync(QueryAcquireRefundOrderRequest request, QueryAcquireRefundOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutRefundNo))
            {
                query["outRefundNo"] = request.OutRefundNo;
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
                Action = "QueryAcquireRefundOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/acquireOrders/refunds",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAcquireRefundOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询收单退款交易
         *
         * @param request QueryAcquireRefundOrderRequest
         * @return QueryAcquireRefundOrderResponse
         */
        public QueryAcquireRefundOrderResponse QueryAcquireRefundOrder(QueryAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcquireRefundOrderHeaders headers = new QueryAcquireRefundOrderHeaders();
            return QueryAcquireRefundOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询收单退款交易
         *
         * @param request QueryAcquireRefundOrderRequest
         * @return QueryAcquireRefundOrderResponse
         */
        public async Task<QueryAcquireRefundOrderResponse> QueryAcquireRefundOrderAsync(QueryAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcquireRefundOrderHeaders headers = new QueryAcquireRefundOrderHeaders();
            return await QueryAcquireRefundOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询批量付款明细列表
         *
         * @param request QueryBatchTradeDetailListRequest
         * @param headers QueryBatchTradeDetailListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBatchTradeDetailListResponse
         */
        public QueryBatchTradeDetailListResponse QueryBatchTradeDetailListWithOptions(QueryBatchTradeDetailListRequest request, QueryBatchTradeDetailListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBatchNo))
            {
                query["outBatchNo"] = request.OutBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryBatchTradeDetailList",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTradeDetailListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询批量付款明细列表
         *
         * @param request QueryBatchTradeDetailListRequest
         * @param headers QueryBatchTradeDetailListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBatchTradeDetailListResponse
         */
        public async Task<QueryBatchTradeDetailListResponse> QueryBatchTradeDetailListWithOptionsAsync(QueryBatchTradeDetailListRequest request, QueryBatchTradeDetailListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBatchNo))
            {
                query["outBatchNo"] = request.OutBatchNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryBatchTradeDetailList",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/details",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTradeDetailListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询批量付款明细列表
         *
         * @param request QueryBatchTradeDetailListRequest
         * @return QueryBatchTradeDetailListResponse
         */
        public QueryBatchTradeDetailListResponse QueryBatchTradeDetailList(QueryBatchTradeDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeDetailListHeaders headers = new QueryBatchTradeDetailListHeaders();
            return QueryBatchTradeDetailListWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询批量付款明细列表
         *
         * @param request QueryBatchTradeDetailListRequest
         * @return QueryBatchTradeDetailListResponse
         */
        public async Task<QueryBatchTradeDetailListResponse> QueryBatchTradeDetailListAsync(QueryBatchTradeDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeDetailListHeaders headers = new QueryBatchTradeDetailListHeaders();
            return await QueryBatchTradeDetailListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 根据请求对象查询批量交易订单信息
         *
         * @param request QueryBatchTradeOrderRequest
         * @param headers QueryBatchTradeOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBatchTradeOrderResponse
         */
        public QueryBatchTradeOrderResponse QueryBatchTradeOrderWithOptions(QueryBatchTradeOrderRequest request, QueryBatchTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBatchNos))
            {
                body["outBatchNos"] = request.OutBatchNos;
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
                Action = "QueryBatchTradeOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/orders/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTradeOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 根据请求对象查询批量交易订单信息
         *
         * @param request QueryBatchTradeOrderRequest
         * @param headers QueryBatchTradeOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryBatchTradeOrderResponse
         */
        public async Task<QueryBatchTradeOrderResponse> QueryBatchTradeOrderWithOptionsAsync(QueryBatchTradeOrderRequest request, QueryBatchTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBatchNos))
            {
                body["outBatchNos"] = request.OutBatchNos;
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
                Action = "QueryBatchTradeOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/batchTrades/orders/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBatchTradeOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 根据请求对象查询批量交易订单信息
         *
         * @param request QueryBatchTradeOrderRequest
         * @return QueryBatchTradeOrderResponse
         */
        public QueryBatchTradeOrderResponse QueryBatchTradeOrder(QueryBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeOrderHeaders headers = new QueryBatchTradeOrderHeaders();
            return QueryBatchTradeOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 根据请求对象查询批量交易订单信息
         *
         * @param request QueryBatchTradeOrderRequest
         * @return QueryBatchTradeOrderResponse
         */
        public async Task<QueryBatchTradeOrderResponse> QueryBatchTradeOrderAsync(QueryBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeOrderHeaders headers = new QueryBatchTradeOrderHeaders();
            return await QueryBatchTradeOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询付款账号列表
         *
         * @param headers QueryPayAccountListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPayAccountListResponse
         */
        public QueryPayAccountListResponse QueryPayAccountListWithOptions(QueryPayAccountListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPayAccountList",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payAccounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPayAccountListResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询付款账号列表
         *
         * @param headers QueryPayAccountListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryPayAccountListResponse
         */
        public async Task<QueryPayAccountListResponse> QueryPayAccountListWithOptionsAsync(QueryPayAccountListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPayAccountList",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payAccounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPayAccountListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询付款账号列表
         *
         * @return QueryPayAccountListResponse
         */
        public QueryPayAccountListResponse QueryPayAccountList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPayAccountListHeaders headers = new QueryPayAccountListHeaders();
            return QueryPayAccountListWithOptions(headers, runtime);
        }

        /**
         * @summary 查询付款账号列表
         *
         * @return QueryPayAccountListResponse
         */
        public async Task<QueryPayAccountListResponse> QueryPayAccountListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPayAccountListHeaders headers = new QueryPayAccountListHeaders();
            return await QueryPayAccountListWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询子机构申请单状态
         *
         * @param request QueryRegisterOrderRequest
         * @param headers QueryRegisterOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRegisterOrderResponse
         */
        public QueryRegisterOrderResponse QueryRegisterOrderWithOptions(QueryRegisterOrderRequest request, QueryRegisterOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                query["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                query["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                query["subInstId"] = request.SubInstId;
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
                Action = "QueryRegisterOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegisterOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询子机构申请单状态
         *
         * @param request QueryRegisterOrderRequest
         * @param headers QueryRegisterOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryRegisterOrderResponse
         */
        public async Task<QueryRegisterOrderResponse> QueryRegisterOrderWithOptionsAsync(QueryRegisterOrderRequest request, QueryRegisterOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                query["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                query["outTradeNo"] = request.OutTradeNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                query["subInstId"] = request.SubInstId;
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
                Action = "QueryRegisterOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/subInstitutions/orders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRegisterOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询子机构申请单状态
         *
         * @param request QueryRegisterOrderRequest
         * @return QueryRegisterOrderResponse
         */
        public QueryRegisterOrderResponse QueryRegisterOrder(QueryRegisterOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRegisterOrderHeaders headers = new QueryRegisterOrderHeaders();
            return QueryRegisterOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询子机构申请单状态
         *
         * @param request QueryRegisterOrderRequest
         * @return QueryRegisterOrderResponse
         */
        public async Task<QueryRegisterOrderResponse> QueryRegisterOrderAsync(QueryRegisterOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRegisterOrderHeaders headers = new QueryRegisterOrderHeaders();
            return await QueryRegisterOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询用户协议
         *
         * @param request QueryUserAgreementRequest
         * @param headers QueryUserAgreementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserAgreementResponse
         */
        public QueryUserAgreementResponse QueryUserAgreementWithOptions(QueryUserAgreementRequest request, QueryUserAgreementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizScene))
            {
                query["bizScene"] = request.BizScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                query["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                query["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "QueryUserAgreement",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAgreements",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAgreementResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询用户协议
         *
         * @param request QueryUserAgreementRequest
         * @param headers QueryUserAgreementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserAgreementResponse
         */
        public async Task<QueryUserAgreementResponse> QueryUserAgreementWithOptionsAsync(QueryUserAgreementRequest request, QueryUserAgreementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                query["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizScene))
            {
                query["bizScene"] = request.BizScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                query["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                query["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["userId"] = request.UserId;
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
                Action = "QueryUserAgreement",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAgreements",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAgreementResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询用户协议
         *
         * @param request QueryUserAgreementRequest
         * @return QueryUserAgreementResponse
         */
        public QueryUserAgreementResponse QueryUserAgreement(QueryUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAgreementHeaders headers = new QueryUserAgreementHeaders();
            return QueryUserAgreementWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询用户协议
         *
         * @param request QueryUserAgreementRequest
         * @return QueryUserAgreementResponse
         */
        public async Task<QueryUserAgreementResponse> QueryUserAgreementAsync(QueryUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAgreementHeaders headers = new QueryUserAgreementHeaders();
            return await QueryUserAgreementWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取用户绑定支付宝信息
         *
         * @param headers QueryUserAlipayAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserAlipayAccountResponse
         */
        public QueryUserAlipayAccountResponse QueryUserAlipayAccountWithOptions(QueryUserAlipayAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserAlipayAccount",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAlipayAccounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAlipayAccountResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取用户绑定支付宝信息
         *
         * @param headers QueryUserAlipayAccountHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryUserAlipayAccountResponse
         */
        public async Task<QueryUserAlipayAccountResponse> QueryUserAlipayAccountWithOptionsAsync(QueryUserAlipayAccountHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryUserAlipayAccount",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAlipayAccounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserAlipayAccountResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取用户绑定支付宝信息
         *
         * @return QueryUserAlipayAccountResponse
         */
        public QueryUserAlipayAccountResponse QueryUserAlipayAccount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAlipayAccountHeaders headers = new QueryUserAlipayAccountHeaders();
            return QueryUserAlipayAccountWithOptions(headers, runtime);
        }

        /**
         * @summary 获取用户绑定支付宝信息
         *
         * @return QueryUserAlipayAccountResponse
         */
        public async Task<QueryUserAlipayAccountResponse> QueryUserAlipayAccountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAlipayAccountHeaders headers = new QueryUserAlipayAccountHeaders();
            return await QueryUserAlipayAccountWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询代扣交易订单信息
         *
         * @param request QueryWithholdingOrderRequest
         * @param headers QueryWithholdingOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWithholdingOrderResponse
         */
        public QueryWithholdingOrderResponse QueryWithholdingOrderWithOptions(QueryWithholdingOrderRequest request, QueryWithholdingOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                query["outTradeNo"] = request.OutTradeNo;
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
                Action = "QueryWithholdingOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/withholdingOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWithholdingOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询代扣交易订单信息
         *
         * @param request QueryWithholdingOrderRequest
         * @param headers QueryWithholdingOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryWithholdingOrderResponse
         */
        public async Task<QueryWithholdingOrderResponse> QueryWithholdingOrderWithOptionsAsync(QueryWithholdingOrderRequest request, QueryWithholdingOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutTradeNo))
            {
                query["outTradeNo"] = request.OutTradeNo;
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
                Action = "QueryWithholdingOrder",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/withholdingOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryWithholdingOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询代扣交易订单信息
         *
         * @param request QueryWithholdingOrderRequest
         * @return QueryWithholdingOrderResponse
         */
        public QueryWithholdingOrderResponse QueryWithholdingOrder(QueryWithholdingOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryWithholdingOrderHeaders headers = new QueryWithholdingOrderHeaders();
            return QueryWithholdingOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询代扣交易订单信息
         *
         * @param request QueryWithholdingOrderRequest
         * @return QueryWithholdingOrderResponse
         */
        public async Task<QueryWithholdingOrderResponse> QueryWithholdingOrderAsync(QueryWithholdingOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryWithholdingOrderHeaders headers = new QueryWithholdingOrderHeaders();
            return await QueryWithholdingOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 保存付款码企业配置信息
         *
         * @param request SaveCorpPayCodeRequest
         * @param headers SaveCorpPayCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveCorpPayCodeResponse
         */
        public SaveCorpPayCodeResponse SaveCorpPayCodeWithOptions(SaveCorpPayCodeRequest request, SaveCorpPayCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeIdentity))
            {
                body["codeIdentity"] = request.CodeIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "SaveCorpPayCode",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/corpSettings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCorpPayCodeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 保存付款码企业配置信息
         *
         * @param request SaveCorpPayCodeRequest
         * @param headers SaveCorpPayCodeHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return SaveCorpPayCodeResponse
         */
        public async Task<SaveCorpPayCodeResponse> SaveCorpPayCodeWithOptionsAsync(SaveCorpPayCodeRequest request, SaveCorpPayCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeIdentity))
            {
                body["codeIdentity"] = request.CodeIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
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
                Action = "SaveCorpPayCode",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/corpSettings",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveCorpPayCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 保存付款码企业配置信息
         *
         * @param request SaveCorpPayCodeRequest
         * @return SaveCorpPayCodeResponse
         */
        public SaveCorpPayCodeResponse SaveCorpPayCode(SaveCorpPayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCorpPayCodeHeaders headers = new SaveCorpPayCodeHeaders();
            return SaveCorpPayCodeWithOptions(request, headers, runtime);
        }

        /**
         * @summary 保存付款码企业配置信息
         *
         * @param request SaveCorpPayCodeRequest
         * @return SaveCorpPayCodeResponse
         */
        public async Task<SaveCorpPayCodeResponse> SaveCorpPayCodeAsync(SaveCorpPayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCorpPayCodeHeaders headers = new SaveCorpPayCodeHeaders();
            return await SaveCorpPayCodeWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 解约用户协议
         *
         * @param request UnsignUserAgreementRequest
         * @param headers UnsignUserAgreementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsignUserAgreementResponse
         */
        public UnsignUserAgreementResponse UnsignUserAgreementWithOptions(UnsignUserAgreementRequest request, UnsignUserAgreementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["agreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizScene))
            {
                body["bizScene"] = request.BizScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
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
                Action = "UnsignUserAgreement",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAgreements/unsign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnsignUserAgreementResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 解约用户协议
         *
         * @param request UnsignUserAgreementRequest
         * @param headers UnsignUserAgreementHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsignUserAgreementResponse
         */
        public async Task<UnsignUserAgreementResponse> UnsignUserAgreementWithOptionsAsync(UnsignUserAgreementRequest request, UnsignUserAgreementHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgreementNo))
            {
                body["agreementNo"] = request.AgreementNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizScene))
            {
                body["bizScene"] = request.BizScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
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
                Action = "UnsignUserAgreement",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAgreements/unsign",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnsignUserAgreementResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 解约用户协议
         *
         * @param request UnsignUserAgreementRequest
         * @return UnsignUserAgreementResponse
         */
        public UnsignUserAgreementResponse UnsignUserAgreement(UnsignUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsignUserAgreementHeaders headers = new UnsignUserAgreementHeaders();
            return UnsignUserAgreementWithOptions(request, headers, runtime);
        }

        /**
         * @summary 解约用户协议
         *
         * @param request UnsignUserAgreementRequest
         * @return UnsignUserAgreementResponse
         */
        public async Task<UnsignUserAgreementResponse> UnsignUserAgreementAsync(UnsignUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsignUserAgreementHeaders headers = new UnsignUserAgreementHeaders();
            return await UnsignUserAgreementWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新用户码实例
         *
         * @param request UpateUserCodeInstanceRequest
         * @param headers UpateUserCodeInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpateUserCodeInstanceResponse
         */
        public UpateUserCodeInstanceResponse UpateUserCodeInstanceWithOptions(UpateUserCodeInstanceRequest request, UpateUserCodeInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvailableTimes))
            {
                body["availableTimes"] = request.AvailableTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeId))
            {
                body["codeId"] = request.CodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeIdentity))
            {
                body["codeIdentity"] = request.CodeIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValue))
            {
                body["codeValue"] = request.CodeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtExpired))
            {
                body["gmtExpired"] = request.GmtExpired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
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
                Action = "UpateUserCodeInstance",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/userInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpateUserCodeInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新用户码实例
         *
         * @param request UpateUserCodeInstanceRequest
         * @param headers UpateUserCodeInstanceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpateUserCodeInstanceResponse
         */
        public async Task<UpateUserCodeInstanceResponse> UpateUserCodeInstanceWithOptionsAsync(UpateUserCodeInstanceRequest request, UpateUserCodeInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AvailableTimes))
            {
                body["availableTimes"] = request.AvailableTimes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeId))
            {
                body["codeId"] = request.CodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeIdentity))
            {
                body["codeIdentity"] = request.CodeIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeValue))
            {
                body["codeValue"] = request.CodeValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtInfo))
            {
                body["extInfo"] = request.ExtInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtExpired))
            {
                body["gmtExpired"] = request.GmtExpired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
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
                Action = "UpateUserCodeInstance",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/payCodes/userInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpateUserCodeInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新用户码实例
         *
         * @param request UpateUserCodeInstanceRequest
         * @return UpateUserCodeInstanceResponse
         */
        public UpateUserCodeInstanceResponse UpateUserCodeInstance(UpateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpateUserCodeInstanceHeaders headers = new UpateUserCodeInstanceHeaders();
            return UpateUserCodeInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新用户码实例
         *
         * @param request UpateUserCodeInstanceRequest
         * @return UpateUserCodeInstanceResponse
         */
        public async Task<UpateUserCodeInstanceResponse> UpateUserCodeInstanceAsync(UpateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpateUserCodeInstanceHeaders headers = new UpateUserCodeInstanceHeaders();
            return await UpateUserCodeInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用来给第三方企业提供发票验真结果更新的oapi
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @param headers UpdateInvoiceVerifyStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceVerifyStatusResponse
         */
        public UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatusWithOptions(UpdateInvoiceVerifyStatusRequest request, UpdateInvoiceVerifyStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckingResult))
            {
                body["checkingResult"] = request.CheckingResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckingStatus))
            {
                body["checkingStatus"] = request.CheckingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceStatus))
            {
                body["invoiceStatus"] = request.InvoiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceVerifyId))
            {
                body["invoiceVerifyId"] = request.InvoiceVerifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["msg"] = request.Msg;
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
                Action = "UpdateInvoiceVerifyStatus",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/verifyStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceVerifyStatusResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 用来给第三方企业提供发票验真结果更新的oapi
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @param headers UpdateInvoiceVerifyStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInvoiceVerifyStatusResponse
         */
        public async Task<UpdateInvoiceVerifyStatusResponse> UpdateInvoiceVerifyStatusWithOptionsAsync(UpdateInvoiceVerifyStatusRequest request, UpdateInvoiceVerifyStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckingResult))
            {
                body["checkingResult"] = request.CheckingResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckingStatus))
            {
                body["checkingStatus"] = request.CheckingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceCode))
            {
                body["invoiceCode"] = request.InvoiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceNo))
            {
                body["invoiceNo"] = request.InvoiceNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceStatus))
            {
                body["invoiceStatus"] = request.InvoiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceVerifyId))
            {
                body["invoiceVerifyId"] = request.InvoiceVerifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["msg"] = request.Msg;
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
                Action = "UpdateInvoiceVerifyStatus",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/verifyStatus",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInvoiceVerifyStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 用来给第三方企业提供发票验真结果更新的oapi
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @return UpdateInvoiceVerifyStatusResponse
         */
        public UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatus(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return UpdateInvoiceVerifyStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用来给第三方企业提供发票验真结果更新的oapi
         *
         * @param request UpdateInvoiceVerifyStatusRequest
         * @return UpdateInvoiceVerifyStatusResponse
         */
        public async Task<UpdateInvoiceVerifyStatusResponse> UpdateInvoiceVerifyStatusAsync(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return await UpdateInvoiceVerifyStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 上传发票
         *
         * @param request UploadInvoiceRequest
         * @param headers UploadInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadInvoiceResponse
         */
        public UploadInvoiceResponse UploadInvoiceWithOptions(UploadInvoiceRequest request, UploadInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoices))
            {
                body["invoices"] = request.Invoices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
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
                Action = "UploadInvoice",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadInvoiceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 上传发票
         *
         * @param request UploadInvoiceRequest
         * @param headers UploadInvoiceHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadInvoiceResponse
         */
        public async Task<UploadInvoiceResponse> UploadInvoiceWithOptionsAsync(UploadInvoiceRequest request, UploadInvoiceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoices))
            {
                body["invoices"] = request.Invoices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
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
                Action = "UploadInvoice",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadInvoiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 上传发票
         *
         * @param request UploadInvoiceRequest
         * @return UploadInvoiceResponse
         */
        public UploadInvoiceResponse UploadInvoice(UploadInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceHeaders headers = new UploadInvoiceHeaders();
            return UploadInvoiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary 上传发票
         *
         * @param request UploadInvoiceRequest
         * @return UploadInvoiceResponse
         */
        public async Task<UploadInvoiceResponse> UploadInvoiceAsync(UploadInvoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceHeaders headers = new UploadInvoiceHeaders();
            return await UploadInvoiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用户授权上传发票oapi
         *
         * @param request UploadInvoiceByAuthRequest
         * @param headers UploadInvoiceByAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadInvoiceByAuthResponse
         */
        public UploadInvoiceByAuthResponse UploadInvoiceByAuthWithOptions(UploadInvoiceByAuthRequest request, UploadInvoiceByAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoices))
            {
                body["invoices"] = request.Invoices;
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
                Action = "UploadInvoiceByAuth",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/authorizations/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadInvoiceByAuthResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 用户授权上传发票oapi
         *
         * @param request UploadInvoiceByAuthRequest
         * @param headers UploadInvoiceByAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadInvoiceByAuthResponse
         */
        public async Task<UploadInvoiceByAuthResponse> UploadInvoiceByAuthWithOptionsAsync(UploadInvoiceByAuthRequest request, UploadInvoiceByAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extension))
            {
                body["extension"] = request.Extension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoices))
            {
                body["invoices"] = request.Invoices;
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
                Action = "UploadInvoiceByAuth",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/authorizations/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadInvoiceByAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 用户授权上传发票oapi
         *
         * @param request UploadInvoiceByAuthRequest
         * @return UploadInvoiceByAuthResponse
         */
        public UploadInvoiceByAuthResponse UploadInvoiceByAuth(UploadInvoiceByAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByAuthHeaders headers = new UploadInvoiceByAuthHeaders();
            return UploadInvoiceByAuthWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用户授权上传发票oapi
         *
         * @param request UploadInvoiceByAuthRequest
         * @return UploadInvoiceByAuthResponse
         */
        public async Task<UploadInvoiceByAuthResponse> UploadInvoiceByAuthAsync(UploadInvoiceByAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByAuthHeaders headers = new UploadInvoiceByAuthHeaders();
            return await UploadInvoiceByAuthWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过手机号上传发票
         *
         * @param request UploadInvoiceByMobileRequest
         * @param headers UploadInvoiceByMobileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadInvoiceByMobileResponse
         */
        public UploadInvoiceByMobileResponse UploadInvoiceByMobileWithOptions(UploadInvoiceByMobileRequest request, UploadInvoiceByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoices))
            {
                body["invoices"] = request.Invoices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileStateCode))
            {
                body["mobileStateCode"] = request.MobileStateCode;
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
                Action = "UploadInvoiceByMobile",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/mobiles/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadInvoiceByMobileResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过手机号上传发票
         *
         * @param request UploadInvoiceByMobileRequest
         * @param headers UploadInvoiceByMobileHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadInvoiceByMobileResponse
         */
        public async Task<UploadInvoiceByMobileResponse> UploadInvoiceByMobileWithOptionsAsync(UploadInvoiceByMobileRequest request, UploadInvoiceByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Invoices))
            {
                body["invoices"] = request.Invoices;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileStateCode))
            {
                body["mobileStateCode"] = request.MobileStateCode;
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
                Action = "UploadInvoiceByMobile",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/invoices/mobiles/upload",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadInvoiceByMobileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过手机号上传发票
         *
         * @param request UploadInvoiceByMobileRequest
         * @return UploadInvoiceByMobileResponse
         */
        public UploadInvoiceByMobileResponse UploadInvoiceByMobile(UploadInvoiceByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByMobileHeaders headers = new UploadInvoiceByMobileHeaders();
            return UploadInvoiceByMobileWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过手机号上传发票
         *
         * @param request UploadInvoiceByMobileRequest
         * @return UploadInvoiceByMobileResponse
         */
        public async Task<UploadInvoiceByMobileResponse> UploadInvoiceByMobileAsync(UploadInvoiceByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByMobileHeaders headers = new UploadInvoiceByMobileHeaders();
            return await UploadInvoiceByMobileWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 上传进件中的图片获得图片链接
         *
         * @param request UploadRegisterImageRequest
         * @param headers UploadRegisterImageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadRegisterImageResponse
         */
        public UploadRegisterImageResponse UploadRegisterImageWithOptions(UploadRegisterImageRequest request, UploadRegisterImageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageContent))
            {
                body["imageContent"] = request.ImageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["imageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["imageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
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
                Action = "UploadRegisterImage",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/images",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRegisterImageResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 上传进件中的图片获得图片链接
         *
         * @param request UploadRegisterImageRequest
         * @param headers UploadRegisterImageHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UploadRegisterImageResponse
         */
        public async Task<UploadRegisterImageResponse> UploadRegisterImageWithOptionsAsync(UploadRegisterImageRequest request, UploadRegisterImageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageContent))
            {
                body["imageContent"] = request.ImageContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                body["imageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["imageType"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
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
                Action = "UploadRegisterImage",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/institutions/images",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadRegisterImageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 上传进件中的图片获得图片链接
         *
         * @param request UploadRegisterImageRequest
         * @return UploadRegisterImageResponse
         */
        public UploadRegisterImageResponse UploadRegisterImage(UploadRegisterImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadRegisterImageHeaders headers = new UploadRegisterImageHeaders();
            return UploadRegisterImageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 上传进件中的图片获得图片链接
         *
         * @param request UploadRegisterImageRequest
         * @return UploadRegisterImageResponse
         */
        public async Task<UploadRegisterImageResponse> UploadRegisterImageAsync(UploadRegisterImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadRegisterImageHeaders headers = new UploadRegisterImageHeaders();
            return await UploadRegisterImageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用户协议签约
         *
         * @param request UserAgreementPageSignRequest
         * @param headers UserAgreementPageSignHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UserAgreementPageSignResponse
         */
        public UserAgreementPageSignResponse UserAgreementPageSignWithOptions(UserAgreementPageSignRequest request, UserAgreementPageSignHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizScene))
            {
                body["bizScene"] = request.BizScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                body["returnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignScene))
            {
                body["signScene"] = request.SignScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMerchantName))
            {
                body["subMerchantName"] = request.SubMerchantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMerchantServiceDesc))
            {
                body["subMerchantServiceDesc"] = request.SubMerchantServiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMerchantServiceName))
            {
                body["subMerchantServiceName"] = request.SubMerchantServiceName;
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
                Action = "UserAgreementPageSign",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAgreements",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UserAgreementPageSignResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 用户协议签约
         *
         * @param request UserAgreementPageSignRequest
         * @param headers UserAgreementPageSignHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UserAgreementPageSignResponse
         */
        public async Task<UserAgreementPageSignResponse> UserAgreementPageSignWithOptionsAsync(UserAgreementPageSignRequest request, UserAgreementPageSignHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizCode))
            {
                body["bizCode"] = request.BizCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizScene))
            {
                body["bizScene"] = request.BizScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayChannel))
            {
                body["payChannel"] = request.PayChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReturnUrl))
            {
                body["returnUrl"] = request.ReturnUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignScene))
            {
                body["signScene"] = request.SignScene;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMerchantName))
            {
                body["subMerchantName"] = request.SubMerchantName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMerchantServiceDesc))
            {
                body["subMerchantServiceDesc"] = request.SubMerchantServiceDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubMerchantServiceName))
            {
                body["subMerchantServiceName"] = request.SubMerchantServiceName;
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
                Action = "UserAgreementPageSign",
                Version = "finance_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/finance/userAgreements",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<UserAgreementPageSignResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 用户协议签约
         *
         * @param request UserAgreementPageSignRequest
         * @return UserAgreementPageSignResponse
         */
        public UserAgreementPageSignResponse UserAgreementPageSign(UserAgreementPageSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserAgreementPageSignHeaders headers = new UserAgreementPageSignHeaders();
            return UserAgreementPageSignWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用户协议签约
         *
         * @param request UserAgreementPageSignRequest
         * @return UserAgreementPageSignResponse
         */
        public async Task<UserAgreementPageSignResponse> UserAgreementPageSignAsync(UserAgreementPageSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserAgreementPageSignHeaders headers = new UserAgreementPageSignHeaders();
            return await UserAgreementPageSignWithOptionsAsync(request, headers, runtime);
        }

    }
}
