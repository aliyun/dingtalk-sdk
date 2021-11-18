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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<ApplyBatchPayResponse>(await DoROARequestAsync("ApplyBatchPay", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders/pay", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateBatchTradeOrderResponse>(await DoROARequestAsync("CreateBatchTradeOrder", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/batchTrades/orders", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<DecodePayCodeResponse>(await DoROARequestAsync("DecodePayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/decode", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyLocation))
            {
                body["verifyLocation"] = request.VerifyLocation;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayCode))
            {
                body["payCode"] = request.PayCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCorpRelationType))
            {
                body["userCorpRelationType"] = request.UserCorpRelationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdentity))
            {
                body["userIdentity"] = request.UserIdentity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VerifyLocation))
            {
                body["verifyLocation"] = request.VerifyLocation;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<NotifyVerifyResultResponse>(await DoROARequestAsync("NotifyVerifyResult", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/verifyResults/notify", "json", req, runtime));
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            return TeaModel.ToObject<QueryPayAccountListResponse>(await DoROARequestAsync("QueryPayAccountList", "finance_1.0", "HTTP", "GET", "AK", "/v1.0/finance/payAccounts", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<SaveCorpPayCodeResponse>(await DoROARequestAsync("SaveCorpPayCode", "finance_1.0", "HTTP", "POST", "AK", "/v1.0/finance/payCodes/corpSettings", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingOrgId))
            {
                body["dingOrgId"] = request.DingOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<UpateUserCodeInstanceResponse>(await DoROARequestAsync("UpateUserCodeInstance", "finance_1.0", "HTTP", "PUT", "AK", "/v1.0/finance/payCodes/userInstances", "json", req, runtime));
        }

    }
}
