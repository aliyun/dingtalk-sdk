// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktrip_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktrip_1_0
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


        public SyncBusinessSignInfoResponse SyncBusinessSignInfoWithOptions(SyncBusinessSignInfoRequest request, SyncBusinessSignInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                body["bizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrgPay))
            {
                body["gmtOrgPay"] = request.GmtOrgPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtSign))
            {
                body["gmtSign"] = request.GmtSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgPayStatus))
            {
                body["orgPayStatus"] = request.OrgPayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                body["signStatus"] = request.SignStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
                Action = "SyncBusinessSignInfo",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/businessSignInfos/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncBusinessSignInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<SyncBusinessSignInfoResponse> SyncBusinessSignInfoWithOptionsAsync(SyncBusinessSignInfoRequest request, SyncBusinessSignInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizTypeList))
            {
                body["bizTypeList"] = request.BizTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrgPay))
            {
                body["gmtOrgPay"] = request.GmtOrgPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtSign))
            {
                body["gmtSign"] = request.GmtSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgPayStatus))
            {
                body["orgPayStatus"] = request.OrgPayStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignStatus))
            {
                body["signStatus"] = request.SignStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
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
                Action = "SyncBusinessSignInfo",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/businessSignInfos/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncBusinessSignInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SyncBusinessSignInfoResponse SyncBusinessSignInfo(SyncBusinessSignInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncBusinessSignInfoHeaders headers = new SyncBusinessSignInfoHeaders();
            return SyncBusinessSignInfoWithOptions(request, headers, runtime);
        }

        public async Task<SyncBusinessSignInfoResponse> SyncBusinessSignInfoAsync(SyncBusinessSignInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncBusinessSignInfoHeaders headers = new SyncBusinessSignInfoHeaders();
            return await SyncBusinessSignInfoWithOptionsAsync(request, headers, runtime);
        }

        public SyncSecretKeyResponse SyncSecretKeyWithOptions(SyncSecretKeyRequest request, SyncSecretKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretString))
            {
                body["secretString"] = request.SecretString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppKey))
            {
                body["tripAppKey"] = request.TripAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppSecurity))
            {
                body["tripAppSecurity"] = request.TripAppSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCorpId))
            {
                body["tripCorpId"] = request.TripCorpId;
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
                Action = "SyncSecretKey",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/secretKeys/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSecretKeyResponse>(Execute(params_, req, runtime));
        }

        public async Task<SyncSecretKeyResponse> SyncSecretKeyWithOptionsAsync(SyncSecretKeyRequest request, SyncSecretKeyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                body["actionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretString))
            {
                body["secretString"] = request.SecretString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppKey))
            {
                body["tripAppKey"] = request.TripAppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripAppSecurity))
            {
                body["tripAppSecurity"] = request.TripAppSecurity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TripCorpId))
            {
                body["tripCorpId"] = request.TripCorpId;
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
                Action = "SyncSecretKey",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/secretKeys/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSecretKeyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SyncSecretKeyResponse SyncSecretKey(SyncSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSecretKeyHeaders headers = new SyncSecretKeyHeaders();
            return SyncSecretKeyWithOptions(request, headers, runtime);
        }

        public async Task<SyncSecretKeyResponse> SyncSecretKeyAsync(SyncSecretKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncSecretKeyHeaders headers = new SyncSecretKeyHeaders();
            return await SyncSecretKeyWithOptionsAsync(request, headers, runtime);
        }

        public SyncTripOrderResponse SyncTripOrderWithOptions(SyncTripOrderRequest request, SyncTripOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscountAmount))
            {
                body["discountAmount"] = request.DiscountAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorseFlag))
            {
                body["endorseFlag"] = request.EndorseFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrder))
            {
                body["gmtOrder"] = request.GmtOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtPay))
            {
                body["gmtPay"] = request.GmtPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtRefund))
            {
                body["gmtRefund"] = request.GmtRefund;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceApplyUrl))
            {
                body["invoiceApplyUrl"] = request.InvoiceApplyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JourneyBizNo))
            {
                body["journeyBizNo"] = request.JourneyBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDetails))
            {
                body["orderDetails"] = request.OrderDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUrl))
            {
                body["orderUrl"] = request.OrderUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["processId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealAmount))
            {
                body["realAmount"] = request.RealAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelativeOrderNo))
            {
                body["relativeOrderNo"] = request.RelativeOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyLogo))
            {
                body["supplyLogo"] = request.SupplyLogo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyName))
            {
                body["supplyName"] = request.SupplyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcCorpId))
            {
                body["tmcCorpId"] = request.TmcCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "SyncTripOrder",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/tripOrders/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTripOrderResponse>(Execute(params_, req, runtime));
        }

        public async Task<SyncTripOrderResponse> SyncTripOrderWithOptionsAsync(SyncTripOrderRequest request, SyncTripOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelType))
            {
                body["channelType"] = request.ChannelType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingUserId))
            {
                body["dingUserId"] = request.DingUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiscountAmount))
            {
                body["discountAmount"] = request.DiscountAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndorseFlag))
            {
                body["endorseFlag"] = request.EndorseFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtOrder))
            {
                body["gmtOrder"] = request.GmtOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtPay))
            {
                body["gmtPay"] = request.GmtPay;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtRefund))
            {
                body["gmtRefund"] = request.GmtRefund;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvoiceApplyUrl))
            {
                body["invoiceApplyUrl"] = request.InvoiceApplyUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JourneyBizNo))
            {
                body["journeyBizNo"] = request.JourneyBizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderDetails))
            {
                body["orderDetails"] = request.OrderDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderUrl))
            {
                body["orderUrl"] = request.OrderUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["processId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RealAmount))
            {
                body["realAmount"] = request.RealAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefundAmount))
            {
                body["refundAmount"] = request.RefundAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelativeOrderNo))
            {
                body["relativeOrderNo"] = request.RelativeOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyLogo))
            {
                body["supplyLogo"] = request.SupplyLogo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyName))
            {
                body["supplyName"] = request.SupplyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCorpId))
            {
                body["targetCorpId"] = request.TargetCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TmcCorpId))
            {
                body["tmcCorpId"] = request.TmcCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalAmount))
            {
                body["totalAmount"] = request.TotalAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
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
                Action = "SyncTripOrder",
                Version = "trip_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trip/tripOrders/sync",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncTripOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SyncTripOrderResponse SyncTripOrder(SyncTripOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTripOrderHeaders headers = new SyncTripOrderHeaders();
            return SyncTripOrderWithOptions(request, headers, runtime);
        }

        public async Task<SyncTripOrderResponse> SyncTripOrderAsync(SyncTripOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SyncTripOrderHeaders headers = new SyncTripOrderHeaders();
            return await SyncTripOrderWithOptionsAsync(request, headers, runtime);
        }

    }
}
