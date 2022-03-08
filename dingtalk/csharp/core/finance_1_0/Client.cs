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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public ApplyBatchPayResponse ApplyBatchPay(ApplyBatchPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyBatchPayHeaders headers = new ApplyBatchPayHeaders();
            return ApplyBatchPayWithOptions(request, headers, runtime);
        }

        public async Task<ApplyBatchPayResponse> ApplyBatchPayAsync(ApplyBatchPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApplyBatchPayHeaders headers = new ApplyBatchPayHeaders();
            return await ApplyBatchPayWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<ApplyBatchPayResponse>(DoROARequest("ApplyBatchPay", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders/pay", "json", req, runtime));
        }

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
            return TeaModel.ToObject<ApplyBatchPayResponse>(await DoROARequestAsync("ApplyBatchPay", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders/pay", "json", req, runtime));
        }

        public ConsultCreateSubInstitutionResponse ConsultCreateSubInstitution(ConsultCreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsultCreateSubInstitutionHeaders headers = new ConsultCreateSubInstitutionHeaders();
            return ConsultCreateSubInstitutionWithOptions(request, headers, runtime);
        }

        public async Task<ConsultCreateSubInstitutionResponse> ConsultCreateSubInstitutionAsync(ConsultCreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ConsultCreateSubInstitutionHeaders headers = new ConsultCreateSubInstitutionHeaders();
            return await ConsultCreateSubInstitutionWithOptionsAsync(request, headers, runtime);
        }

        public ConsultCreateSubInstitutionResponse ConsultCreateSubInstitutionWithOptions(ConsultCreateSubInstitutionRequest request, ConsultCreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo.ToMap()))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo.ToMap()))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo.ToMap()))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo.ToMap()))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo.ToMap()))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo.ToMap()))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo.ToMap()))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo.ToMap()))
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
            return TeaModel.ToObject<ConsultCreateSubInstitutionResponse>(DoROARequest("ConsultCreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/subInstitutions/consult", "json", req, runtime));
        }

        public async Task<ConsultCreateSubInstitutionResponse> ConsultCreateSubInstitutionWithOptionsAsync(ConsultCreateSubInstitutionRequest request, ConsultCreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo.ToMap()))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo.ToMap()))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo.ToMap()))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo.ToMap()))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo.ToMap()))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo.ToMap()))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo.ToMap()))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo.ToMap()))
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
            return TeaModel.ToObject<ConsultCreateSubInstitutionResponse>(await DoROARequestAsync("ConsultCreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/subInstitutions/consult", "json", req, runtime));
        }

        public CreatWithholdingOrderAndPayResponse CreatWithholdingOrderAndPay(CreatWithholdingOrderAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatWithholdingOrderAndPayHeaders headers = new CreatWithholdingOrderAndPayHeaders();
            return CreatWithholdingOrderAndPayWithOptions(request, headers, runtime);
        }

        public async Task<CreatWithholdingOrderAndPayResponse> CreatWithholdingOrderAndPayAsync(CreatWithholdingOrderAndPayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreatWithholdingOrderAndPayHeaders headers = new CreatWithholdingOrderAndPayHeaders();
            return await CreatWithholdingOrderAndPayWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreatWithholdingOrderAndPayResponse>(DoROARequest("CreatWithholdingOrderAndPay", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/withholdingOrders", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreatWithholdingOrderAndPayResponse>(await DoROARequestAsync("CreatWithholdingOrderAndPay", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/withholdingOrders", "json", req, runtime));
        }

        public CreateAcquireRefundOrderResponse CreateAcquireRefundOrder(CreateAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAcquireRefundOrderHeaders headers = new CreateAcquireRefundOrderHeaders();
            return CreateAcquireRefundOrderWithOptions(request, headers, runtime);
        }

        public async Task<CreateAcquireRefundOrderResponse> CreateAcquireRefundOrderAsync(CreateAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAcquireRefundOrderHeaders headers = new CreateAcquireRefundOrderHeaders();
            return await CreateAcquireRefundOrderWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateAcquireRefundOrderResponse>(DoROARequest("CreateAcquireRefundOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/acquireOrders/refund", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateAcquireRefundOrderResponse>(await DoROARequestAsync("CreateAcquireRefundOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/acquireOrders/refund", "json", req, runtime));
        }

        public CreateBatchTradeOrderResponse CreateBatchTradeOrder(CreateBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBatchTradeOrderHeaders headers = new CreateBatchTradeOrderHeaders();
            return CreateBatchTradeOrderWithOptions(request, headers, runtime);
        }

        public async Task<CreateBatchTradeOrderResponse> CreateBatchTradeOrderAsync(CreateBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBatchTradeOrderHeaders headers = new CreateBatchTradeOrderHeaders();
            return await CreateBatchTradeOrderWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateBatchTradeOrderResponse>(DoROARequest("CreateBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateBatchTradeOrderResponse>(await DoROARequestAsync("CreateBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders", "json", req, runtime));
        }

        public CreateSubInstitutionResponse CreateSubInstitution(CreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubInstitutionHeaders headers = new CreateSubInstitutionHeaders();
            return CreateSubInstitutionWithOptions(request, headers, runtime);
        }

        public async Task<CreateSubInstitutionResponse> CreateSubInstitutionAsync(CreateSubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSubInstitutionHeaders headers = new CreateSubInstitutionHeaders();
            return await CreateSubInstitutionWithOptionsAsync(request, headers, runtime);
        }

        public CreateSubInstitutionResponse CreateSubInstitutionWithOptions(CreateSubInstitutionRequest request, CreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo.ToMap()))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo.ToMap()))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo.ToMap()))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo.ToMap()))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo.ToMap()))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo.ToMap()))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo.ToMap()))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo.ToMap()))
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
            return TeaModel.ToObject<CreateSubInstitutionResponse>(DoROARequest("CreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/subInstitutions", "json", req, runtime));
        }

        public async Task<CreateSubInstitutionResponse> CreateSubInstitutionWithOptionsAsync(CreateSubInstitutionRequest request, CreateSubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo.ToMap()))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo.ToMap()))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Solution))
            {
                body["solution"] = request.Solution;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo.ToMap()))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo.ToMap()))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo.ToMap()))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo.ToMap()))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo.ToMap()))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo.ToMap()))
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
            return TeaModel.ToObject<CreateSubInstitutionResponse>(await DoROARequestAsync("CreateSubInstitution", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/subInstitutions", "json", req, runtime));
        }

        public CreateUserCodeInstanceResponse CreateUserCodeInstance(CreateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserCodeInstanceHeaders headers = new CreateUserCodeInstanceHeaders();
            return CreateUserCodeInstanceWithOptions(request, headers, runtime);
        }

        public async Task<CreateUserCodeInstanceResponse> CreateUserCodeInstanceAsync(CreateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateUserCodeInstanceHeaders headers = new CreateUserCodeInstanceHeaders();
            return await CreateUserCodeInstanceWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateUserCodeInstanceResponse>(DoROARequest("CreateUserCodeInstance", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/userInstances", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateUserCodeInstanceResponse>(await DoROARequestAsync("CreateUserCodeInstance", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/userInstances", "json", req, runtime));
        }

        public DecodePayCodeResponse DecodePayCode(DecodePayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DecodePayCodeHeaders headers = new DecodePayCodeHeaders();
            return DecodePayCodeWithOptions(request, headers, runtime);
        }

        public async Task<DecodePayCodeResponse> DecodePayCodeAsync(DecodePayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DecodePayCodeHeaders headers = new DecodePayCodeHeaders();
            return await DecodePayCodeWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<DecodePayCodeResponse>(DoROARequest("DecodePayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/decode", "json", req, runtime));
        }

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
            return TeaModel.ToObject<DecodePayCodeResponse>(await DoROARequestAsync("DecodePayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/decode", "json", req, runtime));
        }

        public ModifySubInstitutionResponse ModifySubInstitution(ModifySubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifySubInstitutionHeaders headers = new ModifySubInstitutionHeaders();
            return ModifySubInstitutionWithOptions(request, headers, runtime);
        }

        public async Task<ModifySubInstitutionResponse> ModifySubInstitutionAsync(ModifySubInstitutionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ModifySubInstitutionHeaders headers = new ModifySubInstitutionHeaders();
            return await ModifySubInstitutionWithOptionsAsync(request, headers, runtime);
        }

        public ModifySubInstitutionResponse ModifySubInstitutionWithOptions(ModifySubInstitutionRequest request, ModifySubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo.ToMap()))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo.ToMap()))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo.ToMap()))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo.ToMap()))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo.ToMap()))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo.ToMap()))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo.ToMap()))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo.ToMap()))
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
            return TeaModel.ToObject<ModifySubInstitutionResponse>(DoROARequest("ModifySubInstitution", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/subInstitutions/modify", "json", req, runtime));
        }

        public async Task<ModifySubInstitutionResponse> ModifySubInstitutionWithOptionsAsync(ModifySubInstitutionRequest request, ModifySubInstitutionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingAlipayLogonId))
            {
                body["bindingAlipayLogonId"] = request.BindingAlipayLogonId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactInfo.ToMap()))
            {
                body["contactInfo"] = request.ContactInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstId))
            {
                body["instId"] = request.InstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LegalPersonCertInfo.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SettleInfo.ToMap()))
            {
                body["settleInfo"] = request.SettleInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAddressInfo.ToMap()))
            {
                body["subInstAddressInfo"] = request.SubInstAddressInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstAuthInfo.ToMap()))
            {
                body["subInstAuthInfo"] = request.SubInstAuthInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstBasicInfo.ToMap()))
            {
                body["subInstBasicInfo"] = request.SubInstBasicInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstCertifyInfo.ToMap()))
            {
                body["subInstCertifyInfo"] = request.SubInstCertifyInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstId))
            {
                body["subInstId"] = request.SubInstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstInvoiceInfo.ToMap()))
            {
                body["subInstInvoiceInfo"] = request.SubInstInvoiceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubInstShopInfo.ToMap()))
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
            return TeaModel.ToObject<ModifySubInstitutionResponse>(await DoROARequestAsync("ModifySubInstitution", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/subInstitutions/modify", "json", req, runtime));
        }

        public NotifyPayCodePayResultResponse NotifyPayCodePayResult(NotifyPayCodePayResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodePayResultHeaders headers = new NotifyPayCodePayResultHeaders();
            return NotifyPayCodePayResultWithOptions(request, headers, runtime);
        }

        public async Task<NotifyPayCodePayResultResponse> NotifyPayCodePayResultAsync(NotifyPayCodePayResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodePayResultHeaders headers = new NotifyPayCodePayResultHeaders();
            return await NotifyPayCodePayResultWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<NotifyPayCodePayResultResponse>(DoROARequest("NotifyPayCodePayResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/payResults/notify", "json", req, runtime));
        }

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
            return TeaModel.ToObject<NotifyPayCodePayResultResponse>(await DoROARequestAsync("NotifyPayCodePayResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/payResults/notify", "json", req, runtime));
        }

        public NotifyPayCodeRefundResultResponse NotifyPayCodeRefundResult(NotifyPayCodeRefundResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodeRefundResultHeaders headers = new NotifyPayCodeRefundResultHeaders();
            return NotifyPayCodeRefundResultWithOptions(request, headers, runtime);
        }

        public async Task<NotifyPayCodeRefundResultResponse> NotifyPayCodeRefundResultAsync(NotifyPayCodeRefundResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyPayCodeRefundResultHeaders headers = new NotifyPayCodeRefundResultHeaders();
            return await NotifyPayCodeRefundResultWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<NotifyPayCodeRefundResultResponse>(DoROARequest("NotifyPayCodeRefundResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/refundResults/notify", "json", req, runtime));
        }

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
            return TeaModel.ToObject<NotifyPayCodeRefundResultResponse>(await DoROARequestAsync("NotifyPayCodeRefundResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/refundResults/notify", "json", req, runtime));
        }

        public NotifyVerifyResultResponse NotifyVerifyResult(NotifyVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyVerifyResultHeaders headers = new NotifyVerifyResultHeaders();
            return NotifyVerifyResultWithOptions(request, headers, runtime);
        }

        public async Task<NotifyVerifyResultResponse> NotifyVerifyResultAsync(NotifyVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyVerifyResultHeaders headers = new NotifyVerifyResultHeaders();
            return await NotifyVerifyResultWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<NotifyVerifyResultResponse>(DoROARequest("NotifyVerifyResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/verifyResults/notify", "json", req, runtime));
        }

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
            return TeaModel.ToObject<NotifyVerifyResultResponse>(await DoROARequestAsync("NotifyVerifyResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/verifyResults/notify", "json", req, runtime));
        }

        public QueryAcquireRefundOrderResponse QueryAcquireRefundOrder(QueryAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcquireRefundOrderHeaders headers = new QueryAcquireRefundOrderHeaders();
            return QueryAcquireRefundOrderWithOptions(request, headers, runtime);
        }

        public async Task<QueryAcquireRefundOrderResponse> QueryAcquireRefundOrderAsync(QueryAcquireRefundOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAcquireRefundOrderHeaders headers = new QueryAcquireRefundOrderHeaders();
            return await QueryAcquireRefundOrderWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryAcquireRefundOrderResponse>(DoROARequest("QueryAcquireRefundOrder", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/acquireOrders/refunds", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryAcquireRefundOrderResponse>(await DoROARequestAsync("QueryAcquireRefundOrder", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/acquireOrders/refunds", "json", req, runtime));
        }

        public QueryBatchTradeDetailListResponse QueryBatchTradeDetailList(QueryBatchTradeDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeDetailListHeaders headers = new QueryBatchTradeDetailListHeaders();
            return QueryBatchTradeDetailListWithOptions(request, headers, runtime);
        }

        public async Task<QueryBatchTradeDetailListResponse> QueryBatchTradeDetailListAsync(QueryBatchTradeDetailListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeDetailListHeaders headers = new QueryBatchTradeDetailListHeaders();
            return await QueryBatchTradeDetailListWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryBatchTradeDetailListResponse>(DoROARequest("QueryBatchTradeDetailList", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/batchTrades/details", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryBatchTradeDetailListResponse>(await DoROARequestAsync("QueryBatchTradeDetailList", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/batchTrades/details", "json", req, runtime));
        }

        public QueryBatchTradeOrderResponse QueryBatchTradeOrder(QueryBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeOrderHeaders headers = new QueryBatchTradeOrderHeaders();
            return QueryBatchTradeOrderWithOptions(request, headers, runtime);
        }

        public async Task<QueryBatchTradeOrderResponse> QueryBatchTradeOrderAsync(QueryBatchTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBatchTradeOrderHeaders headers = new QueryBatchTradeOrderHeaders();
            return await QueryBatchTradeOrderWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryBatchTradeOrderResponse>(DoROARequest("QueryBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryBatchTradeOrderResponse>(await DoROARequestAsync("QueryBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders/query", "json", req, runtime));
        }

        public QueryPayAccountListResponse QueryPayAccountList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPayAccountListHeaders headers = new QueryPayAccountListHeaders();
            return QueryPayAccountListWithOptions(headers, runtime);
        }

        public async Task<QueryPayAccountListResponse> QueryPayAccountListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryPayAccountListHeaders headers = new QueryPayAccountListHeaders();
            return await QueryPayAccountListWithOptionsAsync(headers, runtime);
        }

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
            return TeaModel.ToObject<QueryPayAccountListResponse>(DoROARequest("QueryPayAccountList", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/payAccounts", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryPayAccountListResponse>(await DoROARequestAsync("QueryPayAccountList", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/payAccounts", "json", req, runtime));
        }

        public QueryRegisterOrderResponse QueryRegisterOrder(QueryRegisterOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRegisterOrderHeaders headers = new QueryRegisterOrderHeaders();
            return QueryRegisterOrderWithOptions(request, headers, runtime);
        }

        public async Task<QueryRegisterOrderResponse> QueryRegisterOrderAsync(QueryRegisterOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRegisterOrderHeaders headers = new QueryRegisterOrderHeaders();
            return await QueryRegisterOrderWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryRegisterOrderResponse>(DoROARequest("QueryRegisterOrder", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/institutions/subInstitutions/orders", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryRegisterOrderResponse>(await DoROARequestAsync("QueryRegisterOrder", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/institutions/subInstitutions/orders", "json", req, runtime));
        }

        public QueryUserAgreementResponse QueryUserAgreement(QueryUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAgreementHeaders headers = new QueryUserAgreementHeaders();
            return QueryUserAgreementWithOptions(request, headers, runtime);
        }

        public async Task<QueryUserAgreementResponse> QueryUserAgreementAsync(QueryUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAgreementHeaders headers = new QueryUserAgreementHeaders();
            return await QueryUserAgreementWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryUserAgreementResponse>(DoROARequest("QueryUserAgreement", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/userAgreements", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryUserAgreementResponse>(await DoROARequestAsync("QueryUserAgreement", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/userAgreements", "json", req, runtime));
        }

        public QueryUserAlipayAccountResponse QueryUserAlipayAccount()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAlipayAccountHeaders headers = new QueryUserAlipayAccountHeaders();
            return QueryUserAlipayAccountWithOptions(headers, runtime);
        }

        public async Task<QueryUserAlipayAccountResponse> QueryUserAlipayAccountAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserAlipayAccountHeaders headers = new QueryUserAlipayAccountHeaders();
            return await QueryUserAlipayAccountWithOptionsAsync(headers, runtime);
        }

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
            return TeaModel.ToObject<QueryUserAlipayAccountResponse>(DoROARequest("QueryUserAlipayAccount", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/userAlipayAccounts", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryUserAlipayAccountResponse>(await DoROARequestAsync("QueryUserAlipayAccount", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/userAlipayAccounts", "json", req, runtime));
        }

        public QueryWithholdingOrderResponse QueryWithholdingOrder(QueryWithholdingOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryWithholdingOrderHeaders headers = new QueryWithholdingOrderHeaders();
            return QueryWithholdingOrderWithOptions(request, headers, runtime);
        }

        public async Task<QueryWithholdingOrderResponse> QueryWithholdingOrderAsync(QueryWithholdingOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryWithholdingOrderHeaders headers = new QueryWithholdingOrderHeaders();
            return await QueryWithholdingOrderWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<QueryWithholdingOrderResponse>(DoROARequest("QueryWithholdingOrder", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/withholdingOrders", "json", req, runtime));
        }

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
            return TeaModel.ToObject<QueryWithholdingOrderResponse>(await DoROARequestAsync("QueryWithholdingOrder", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/withholdingOrders", "json", req, runtime));
        }

        public SaveCorpPayCodeResponse SaveCorpPayCode(SaveCorpPayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCorpPayCodeHeaders headers = new SaveCorpPayCodeHeaders();
            return SaveCorpPayCodeWithOptions(request, headers, runtime);
        }

        public async Task<SaveCorpPayCodeResponse> SaveCorpPayCodeAsync(SaveCorpPayCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveCorpPayCodeHeaders headers = new SaveCorpPayCodeHeaders();
            return await SaveCorpPayCodeWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<SaveCorpPayCodeResponse>(DoROARequest("SaveCorpPayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/corpSettings", "json", req, runtime));
        }

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
            return TeaModel.ToObject<SaveCorpPayCodeResponse>(await DoROARequestAsync("SaveCorpPayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/corpSettings", "json", req, runtime));
        }

        public UnsignUserAgreementResponse UnsignUserAgreement(UnsignUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsignUserAgreementHeaders headers = new UnsignUserAgreementHeaders();
            return UnsignUserAgreementWithOptions(request, headers, runtime);
        }

        public async Task<UnsignUserAgreementResponse> UnsignUserAgreementAsync(UnsignUserAgreementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UnsignUserAgreementHeaders headers = new UnsignUserAgreementHeaders();
            return await UnsignUserAgreementWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UnsignUserAgreementResponse>(DoROARequest("UnsignUserAgreement", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/userAgreements/unsign", "none", req, runtime));
        }

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
            return TeaModel.ToObject<UnsignUserAgreementResponse>(await DoROARequestAsync("UnsignUserAgreement", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/userAgreements/unsign", "none", req, runtime));
        }

        public UpateUserCodeInstanceResponse UpateUserCodeInstance(UpateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpateUserCodeInstanceHeaders headers = new UpateUserCodeInstanceHeaders();
            return UpateUserCodeInstanceWithOptions(request, headers, runtime);
        }

        public async Task<UpateUserCodeInstanceResponse> UpateUserCodeInstanceAsync(UpateUserCodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpateUserCodeInstanceHeaders headers = new UpateUserCodeInstanceHeaders();
            return await UpateUserCodeInstanceWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UpateUserCodeInstanceResponse>(DoROARequest("UpateUserCodeInstance", "finance_1.0", "HTTP", "PUT", "AK", "/v1.0/finance/payCodes/userInstances", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UpateUserCodeInstanceResponse>(await DoROARequestAsync("UpateUserCodeInstance", "finance_1.0", "HTTP", "PUT", "AK", "/v1.0/finance/payCodes/userInstances", "json", req, runtime));
        }

        public UpdateInvoiceVerifyStatusResponse UpdateInvoiceVerifyStatus(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return UpdateInvoiceVerifyStatusWithOptions(request, headers, runtime);
        }

        public async Task<UpdateInvoiceVerifyStatusResponse> UpdateInvoiceVerifyStatusAsync(UpdateInvoiceVerifyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateInvoiceVerifyStatusHeaders headers = new UpdateInvoiceVerifyStatusHeaders();
            return await UpdateInvoiceVerifyStatusWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UpdateInvoiceVerifyStatusResponse>(DoROARequest("UpdateInvoiceVerifyStatus", "finance_1.0", "HTTP", "PUT", "AK", "/v1.0/finance/invoices/verifyStatus", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UpdateInvoiceVerifyStatusResponse>(await DoROARequestAsync("UpdateInvoiceVerifyStatus", "finance_1.0", "HTTP", "PUT", "AK", "/v1.0/finance/invoices/verifyStatus", "json", req, runtime));
        }

        public UploadInvoiceByAuthResponse UploadInvoiceByAuth(UploadInvoiceByAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByAuthHeaders headers = new UploadInvoiceByAuthHeaders();
            return UploadInvoiceByAuthWithOptions(request, headers, runtime);
        }

        public async Task<UploadInvoiceByAuthResponse> UploadInvoiceByAuthAsync(UploadInvoiceByAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByAuthHeaders headers = new UploadInvoiceByAuthHeaders();
            return await UploadInvoiceByAuthWithOptionsAsync(request, headers, runtime);
        }

        public UploadInvoiceByAuthResponse UploadInvoiceByAuthWithOptions(UploadInvoiceByAuthRequest request, UploadInvoiceByAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<UploadInvoiceByAuthResponse>(DoROARequest("UploadInvoiceByAuth", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/invoices/authorizations/upload", "json", req, runtime));
        }

        public async Task<UploadInvoiceByAuthResponse> UploadInvoiceByAuthWithOptionsAsync(UploadInvoiceByAuthRequest request, UploadInvoiceByAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<UploadInvoiceByAuthResponse>(await DoROARequestAsync("UploadInvoiceByAuth", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/invoices/authorizations/upload", "json", req, runtime));
        }

        public UploadInvoiceByMobileResponse UploadInvoiceByMobile(UploadInvoiceByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByMobileHeaders headers = new UploadInvoiceByMobileHeaders();
            return UploadInvoiceByMobileWithOptions(request, headers, runtime);
        }

        public async Task<UploadInvoiceByMobileResponse> UploadInvoiceByMobileAsync(UploadInvoiceByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadInvoiceByMobileHeaders headers = new UploadInvoiceByMobileHeaders();
            return await UploadInvoiceByMobileWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UploadInvoiceByMobileResponse>(DoROARequest("UploadInvoiceByMobile", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/invoices/mobiles/upload", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UploadInvoiceByMobileResponse>(await DoROARequestAsync("UploadInvoiceByMobile", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/invoices/mobiles/upload", "json", req, runtime));
        }

        public UploadRegisterImageResponse UploadRegisterImage(UploadRegisterImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadRegisterImageHeaders headers = new UploadRegisterImageHeaders();
            return UploadRegisterImageWithOptions(request, headers, runtime);
        }

        public async Task<UploadRegisterImageResponse> UploadRegisterImageAsync(UploadRegisterImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UploadRegisterImageHeaders headers = new UploadRegisterImageHeaders();
            return await UploadRegisterImageWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UploadRegisterImageResponse>(DoROARequest("UploadRegisterImage", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/images", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UploadRegisterImageResponse>(await DoROARequestAsync("UploadRegisterImage", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/institutions/images", "json", req, runtime));
        }

        public UserAgreementPageSignResponse UserAgreementPageSign(UserAgreementPageSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserAgreementPageSignHeaders headers = new UserAgreementPageSignHeaders();
            return UserAgreementPageSignWithOptions(request, headers, runtime);
        }

        public async Task<UserAgreementPageSignResponse> UserAgreementPageSignAsync(UserAgreementPageSignRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserAgreementPageSignHeaders headers = new UserAgreementPageSignHeaders();
            return await UserAgreementPageSignWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UserAgreementPageSignResponse>(DoROARequest("UserAgreementPageSign", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/userAgreements", "json", req, runtime));
        }

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
            return TeaModel.ToObject<UserAgreementPageSignResponse>(await DoROARequestAsync("UserAgreementPageSign", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/userAgreements", "json", req, runtime));
        }

    }
}
