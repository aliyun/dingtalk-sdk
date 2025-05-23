// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkbadge_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkbadge_1_0
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
        /// <para>创建钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeCodeUserInstanceRequest
        /// </param>
        /// <param name="headers">
        /// CreateBadgeCodeUserInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeCodeUserInstanceResponse
        /// </returns>
        public CreateBadgeCodeUserInstanceResponse CreateBadgeCodeUserInstanceWithOptions(CreateBadgeCodeUserInstanceRequest request, CreateBadgeCodeUserInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateBadgeCodeUserInstance",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/userInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBadgeCodeUserInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeCodeUserInstanceRequest
        /// </param>
        /// <param name="headers">
        /// CreateBadgeCodeUserInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeCodeUserInstanceResponse
        /// </returns>
        public async Task<CreateBadgeCodeUserInstanceResponse> CreateBadgeCodeUserInstanceWithOptionsAsync(CreateBadgeCodeUserInstanceRequest request, CreateBadgeCodeUserInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CreateBadgeCodeUserInstance",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/userInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBadgeCodeUserInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeCodeUserInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeCodeUserInstanceResponse
        /// </returns>
        public CreateBadgeCodeUserInstanceResponse CreateBadgeCodeUserInstance(CreateBadgeCodeUserInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBadgeCodeUserInstanceHeaders headers = new CreateBadgeCodeUserInstanceHeaders();
            return CreateBadgeCodeUserInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeCodeUserInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeCodeUserInstanceResponse
        /// </returns>
        public async Task<CreateBadgeCodeUserInstanceResponse> CreateBadgeCodeUserInstanceAsync(CreateBadgeCodeUserInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBadgeCodeUserInstanceHeaders headers = new CreateBadgeCodeUserInstanceHeaders();
            return await CreateBadgeCodeUserInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉工牌通知消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeNotifyRequest
        /// </param>
        /// <param name="headers">
        /// CreateBadgeNotifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeNotifyResponse
        /// </returns>
        public CreateBadgeNotifyResponse CreateBadgeNotifyWithOptions(CreateBadgeNotifyRequest request, CreateBadgeNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["msgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                body["msgType"] = request.MsgType;
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
                Action = "CreateBadgeNotify",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/notices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBadgeNotifyResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉工牌通知消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeNotifyRequest
        /// </param>
        /// <param name="headers">
        /// CreateBadgeNotifyHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeNotifyResponse
        /// </returns>
        public async Task<CreateBadgeNotifyResponse> CreateBadgeNotifyWithOptionsAsync(CreateBadgeNotifyRequest request, CreateBadgeNotifyHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["msgId"] = request.MsgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgType))
            {
                body["msgType"] = request.MsgType;
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
                Action = "CreateBadgeNotify",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/notices",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBadgeNotifyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉工牌通知消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeNotifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeNotifyResponse
        /// </returns>
        public CreateBadgeNotifyResponse CreateBadgeNotify(CreateBadgeNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBadgeNotifyHeaders headers = new CreateBadgeNotifyHeaders();
            return CreateBadgeNotifyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建钉工牌通知消息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBadgeNotifyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBadgeNotifyResponse
        /// </returns>
        public async Task<CreateBadgeNotifyResponse> CreateBadgeNotifyAsync(CreateBadgeNotifyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateBadgeNotifyHeaders headers = new CreateBadgeNotifyHeaders();
            return await CreateBadgeNotifyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉工牌解码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DecodeBadgeCodeRequest
        /// </param>
        /// <param name="headers">
        /// DecodeBadgeCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DecodeBadgeCodeResponse
        /// </returns>
        public DecodeBadgeCodeResponse DecodeBadgeCodeWithOptions(DecodeBadgeCodeRequest request, DecodeBadgeCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DecodeBadgeCode",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/decode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodeBadgeCodeResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉工牌解码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DecodeBadgeCodeRequest
        /// </param>
        /// <param name="headers">
        /// DecodeBadgeCodeHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DecodeBadgeCodeResponse
        /// </returns>
        public async Task<DecodeBadgeCodeResponse> DecodeBadgeCodeWithOptionsAsync(DecodeBadgeCodeRequest request, DecodeBadgeCodeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DecodeBadgeCode",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/decode",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecodeBadgeCodeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉工牌解码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DecodeBadgeCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DecodeBadgeCodeResponse
        /// </returns>
        public DecodeBadgeCodeResponse DecodeBadgeCode(DecodeBadgeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DecodeBadgeCodeHeaders headers = new DecodeBadgeCodeHeaders();
            return DecodeBadgeCodeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉工牌解码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DecodeBadgeCodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DecodeBadgeCodeResponse
        /// </returns>
        public async Task<DecodeBadgeCodeResponse> DecodeBadgeCodeAsync(DecodeBadgeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DecodeBadgeCodeHeaders headers = new DecodeBadgeCodeHeaders();
            return await DecodeBadgeCodeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码付款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodePayResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyBadgeCodePayResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodePayResultResponse
        /// </returns>
        public NotifyBadgeCodePayResultResponse NotifyBadgeCodePayResultWithOptions(NotifyBadgeCodePayResultRequest request, NotifyBadgeCodePayResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "NotifyBadgeCodePayResult",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/payResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyBadgeCodePayResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码付款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodePayResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyBadgeCodePayResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodePayResultResponse
        /// </returns>
        public async Task<NotifyBadgeCodePayResultResponse> NotifyBadgeCodePayResultWithOptionsAsync(NotifyBadgeCodePayResultRequest request, NotifyBadgeCodePayResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "NotifyBadgeCodePayResult",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/payResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyBadgeCodePayResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码付款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodePayResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodePayResultResponse
        /// </returns>
        public NotifyBadgeCodePayResultResponse NotifyBadgeCodePayResult(NotifyBadgeCodePayResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyBadgeCodePayResultHeaders headers = new NotifyBadgeCodePayResultHeaders();
            return NotifyBadgeCodePayResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码付款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodePayResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodePayResultResponse
        /// </returns>
        public async Task<NotifyBadgeCodePayResultResponse> NotifyBadgeCodePayResultAsync(NotifyBadgeCodePayResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyBadgeCodePayResultHeaders headers = new NotifyBadgeCodePayResultHeaders();
            return await NotifyBadgeCodePayResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码退款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeRefundResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyBadgeCodeRefundResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeRefundResultResponse
        /// </returns>
        public NotifyBadgeCodeRefundResultResponse NotifyBadgeCodeRefundResultWithOptions(NotifyBadgeCodeRefundResultRequest request, NotifyBadgeCodeRefundResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "NotifyBadgeCodeRefundResult",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/refundResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyBadgeCodeRefundResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码退款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeRefundResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyBadgeCodeRefundResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeRefundResultResponse
        /// </returns>
        public async Task<NotifyBadgeCodeRefundResultResponse> NotifyBadgeCodeRefundResultWithOptionsAsync(NotifyBadgeCodeRefundResultRequest request, NotifyBadgeCodeRefundResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "NotifyBadgeCodeRefundResult",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/refundResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyBadgeCodeRefundResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码退款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeRefundResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeRefundResultResponse
        /// </returns>
        public NotifyBadgeCodeRefundResultResponse NotifyBadgeCodeRefundResult(NotifyBadgeCodeRefundResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyBadgeCodeRefundResultHeaders headers = new NotifyBadgeCodeRefundResultHeaders();
            return NotifyBadgeCodeRefundResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码退款结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeRefundResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeRefundResultResponse
        /// </returns>
        public async Task<NotifyBadgeCodeRefundResultResponse> NotifyBadgeCodeRefundResultAsync(NotifyBadgeCodeRefundResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyBadgeCodeRefundResultHeaders headers = new NotifyBadgeCodeRefundResultHeaders();
            return await NotifyBadgeCodeRefundResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码验证结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeVerifyResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyBadgeCodeVerifyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeVerifyResultResponse
        /// </returns>
        public NotifyBadgeCodeVerifyResultResponse NotifyBadgeCodeVerifyResultWithOptions(NotifyBadgeCodeVerifyResultRequest request, NotifyBadgeCodeVerifyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "NotifyBadgeCodeVerifyResult",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/verifyResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyBadgeCodeVerifyResultResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码验证结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeVerifyResultRequest
        /// </param>
        /// <param name="headers">
        /// NotifyBadgeCodeVerifyResultHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeVerifyResultResponse
        /// </returns>
        public async Task<NotifyBadgeCodeVerifyResultResponse> NotifyBadgeCodeVerifyResultWithOptionsAsync(NotifyBadgeCodeVerifyResultRequest request, NotifyBadgeCodeVerifyResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "NotifyBadgeCodeVerifyResult",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/verifyResults",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<NotifyBadgeCodeVerifyResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码验证结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeVerifyResultResponse
        /// </returns>
        public NotifyBadgeCodeVerifyResultResponse NotifyBadgeCodeVerifyResult(NotifyBadgeCodeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyBadgeCodeVerifyResultHeaders headers = new NotifyBadgeCodeVerifyResultHeaders();
            return NotifyBadgeCodeVerifyResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通知钉工牌码验证结果</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// NotifyBadgeCodeVerifyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// NotifyBadgeCodeVerifyResultResponse
        /// </returns>
        public async Task<NotifyBadgeCodeVerifyResultResponse> NotifyBadgeCodeVerifyResultAsync(NotifyBadgeCodeVerifyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            NotifyBadgeCodeVerifyResultHeaders headers = new NotifyBadgeCodeVerifyResultHeaders();
            return await NotifyBadgeCodeVerifyResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存钉工牌企业实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBadgeCodeCorpInstanceRequest
        /// </param>
        /// <param name="headers">
        /// SaveBadgeCodeCorpInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBadgeCodeCorpInstanceResponse
        /// </returns>
        public SaveBadgeCodeCorpInstanceResponse SaveBadgeCodeCorpInstanceWithOptions(SaveBadgeCodeCorpInstanceRequest request, SaveBadgeCodeCorpInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveBadgeCodeCorpInstance",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/corpInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBadgeCodeCorpInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存钉工牌企业实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBadgeCodeCorpInstanceRequest
        /// </param>
        /// <param name="headers">
        /// SaveBadgeCodeCorpInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveBadgeCodeCorpInstanceResponse
        /// </returns>
        public async Task<SaveBadgeCodeCorpInstanceResponse> SaveBadgeCodeCorpInstanceWithOptionsAsync(SaveBadgeCodeCorpInstanceRequest request, SaveBadgeCodeCorpInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "SaveBadgeCodeCorpInstance",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/corpInstances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveBadgeCodeCorpInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存钉工牌企业实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBadgeCodeCorpInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBadgeCodeCorpInstanceResponse
        /// </returns>
        public SaveBadgeCodeCorpInstanceResponse SaveBadgeCodeCorpInstance(SaveBadgeCodeCorpInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveBadgeCodeCorpInstanceHeaders headers = new SaveBadgeCodeCorpInstanceHeaders();
            return SaveBadgeCodeCorpInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>保存钉工牌企业实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveBadgeCodeCorpInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveBadgeCodeCorpInstanceResponse
        /// </returns>
        public async Task<SaveBadgeCodeCorpInstanceResponse> SaveBadgeCodeCorpInstanceAsync(SaveBadgeCodeCorpInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveBadgeCodeCorpInstanceHeaders headers = new SaveBadgeCodeCorpInstanceHeaders();
            return await SaveBadgeCodeCorpInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBadgeCodeUserInstanceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBadgeCodeUserInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBadgeCodeUserInstanceResponse
        /// </returns>
        public UpdateBadgeCodeUserInstanceResponse UpdateBadgeCodeUserInstanceWithOptions(UpdateBadgeCodeUserInstanceRequest request, UpdateBadgeCodeUserInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateBadgeCodeUserInstance",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/userInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBadgeCodeUserInstanceResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBadgeCodeUserInstanceRequest
        /// </param>
        /// <param name="headers">
        /// UpdateBadgeCodeUserInstanceHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBadgeCodeUserInstanceResponse
        /// </returns>
        public async Task<UpdateBadgeCodeUserInstanceResponse> UpdateBadgeCodeUserInstanceWithOptionsAsync(UpdateBadgeCodeUserInstanceRequest request, UpdateBadgeCodeUserInstanceHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateBadgeCodeUserInstance",
                Version = "badge_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/badge/codes/userInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBadgeCodeUserInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBadgeCodeUserInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBadgeCodeUserInstanceResponse
        /// </returns>
        public UpdateBadgeCodeUserInstanceResponse UpdateBadgeCodeUserInstance(UpdateBadgeCodeUserInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBadgeCodeUserInstanceHeaders headers = new UpdateBadgeCodeUserInstanceHeaders();
            return UpdateBadgeCodeUserInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新钉工牌码用户实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBadgeCodeUserInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBadgeCodeUserInstanceResponse
        /// </returns>
        public async Task<UpdateBadgeCodeUserInstanceResponse> UpdateBadgeCodeUserInstanceAsync(UpdateBadgeCodeUserInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateBadgeCodeUserInstanceHeaders headers = new UpdateBadgeCodeUserInstanceHeaders();
            return await UpdateBadgeCodeUserInstanceWithOptionsAsync(request, headers, runtime);
        }

    }
}
