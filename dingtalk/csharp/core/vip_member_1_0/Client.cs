// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkvip_member_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkvip_member_1_0
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
        /// <para>通过手机号直充365会员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DirectRedeemVipMemberByMobileRequest
        /// </param>
        /// <param name="headers">
        /// DirectRedeemVipMemberByMobileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DirectRedeemVipMemberByMobileResponse
        /// </returns>
        public DirectRedeemVipMemberByMobileResponse DirectRedeemVipMemberByMobileWithOptions(DirectRedeemVipMemberByMobileRequest request, DirectRedeemVipMemberByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "DirectRedeemVipMemberByMobile",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/directRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DirectRedeemVipMemberByMobileResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号直充365会员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DirectRedeemVipMemberByMobileRequest
        /// </param>
        /// <param name="headers">
        /// DirectRedeemVipMemberByMobileHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DirectRedeemVipMemberByMobileResponse
        /// </returns>
        public async Task<DirectRedeemVipMemberByMobileResponse> DirectRedeemVipMemberByMobileWithOptionsAsync(DirectRedeemVipMemberByMobileRequest request, DirectRedeemVipMemberByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "DirectRedeemVipMemberByMobile",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/directRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DirectRedeemVipMemberByMobileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号直充365会员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DirectRedeemVipMemberByMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// DirectRedeemVipMemberByMobileResponse
        /// </returns>
        public DirectRedeemVipMemberByMobileResponse DirectRedeemVipMemberByMobile(DirectRedeemVipMemberByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DirectRedeemVipMemberByMobileHeaders headers = new DirectRedeemVipMemberByMobileHeaders();
            return DirectRedeemVipMemberByMobileWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过手机号直充365会员</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DirectRedeemVipMemberByMobileRequest
        /// </param>
        /// 
        /// <returns>
        /// DirectRedeemVipMemberByMobileResponse
        /// </returns>
        public async Task<DirectRedeemVipMemberByMobileResponse> DirectRedeemVipMemberByMobileAsync(DirectRedeemVipMemberByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DirectRedeemVipMemberByMobileHeaders headers = new DirectRedeemVipMemberByMobileHeaders();
            return await DirectRedeemVipMemberByMobileWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过虚拟订单号作废365会员权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvalidRedeemVipMemberByBizRequestIdRequest
        /// </param>
        /// <param name="headers">
        /// InvalidRedeemVipMemberByBizRequestIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidRedeemVipMemberByBizRequestIdResponse
        /// </returns>
        public InvalidRedeemVipMemberByBizRequestIdResponse InvalidRedeemVipMemberByBizRequestIdWithOptions(InvalidRedeemVipMemberByBizRequestIdRequest request, InvalidRedeemVipMemberByBizRequestIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "InvalidRedeemVipMemberByBizRequestId",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/invalidRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidRedeemVipMemberByBizRequestIdResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过虚拟订单号作废365会员权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvalidRedeemVipMemberByBizRequestIdRequest
        /// </param>
        /// <param name="headers">
        /// InvalidRedeemVipMemberByBizRequestIdHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvalidRedeemVipMemberByBizRequestIdResponse
        /// </returns>
        public async Task<InvalidRedeemVipMemberByBizRequestIdResponse> InvalidRedeemVipMemberByBizRequestIdWithOptionsAsync(InvalidRedeemVipMemberByBizRequestIdRequest request, InvalidRedeemVipMemberByBizRequestIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "InvalidRedeemVipMemberByBizRequestId",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/invalidRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<InvalidRedeemVipMemberByBizRequestIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过虚拟订单号作废365会员权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvalidRedeemVipMemberByBizRequestIdRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidRedeemVipMemberByBizRequestIdResponse
        /// </returns>
        public InvalidRedeemVipMemberByBizRequestIdResponse InvalidRedeemVipMemberByBizRequestId(InvalidRedeemVipMemberByBizRequestIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvalidRedeemVipMemberByBizRequestIdHeaders headers = new InvalidRedeemVipMemberByBizRequestIdHeaders();
            return InvalidRedeemVipMemberByBizRequestIdWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过虚拟订单号作废365会员权益</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InvalidRedeemVipMemberByBizRequestIdRequest
        /// </param>
        /// 
        /// <returns>
        /// InvalidRedeemVipMemberByBizRequestIdResponse
        /// </returns>
        public async Task<InvalidRedeemVipMemberByBizRequestIdResponse> InvalidRedeemVipMemberByBizRequestIdAsync(InvalidRedeemVipMemberByBizRequestIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            InvalidRedeemVipMemberByBizRequestIdHeaders headers = new InvalidRedeemVipMemberByBizRequestIdHeaders();
            return await InvalidRedeemVipMemberByBizRequestIdWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直充会员预校验是否满足条件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckRedeemVipMemberRequest
        /// </param>
        /// <param name="headers">
        /// PreCheckRedeemVipMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreCheckRedeemVipMemberResponse
        /// </returns>
        public PreCheckRedeemVipMemberResponse PreCheckRedeemVipMemberWithOptions(PreCheckRedeemVipMemberRequest request, PreCheckRedeemVipMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "PreCheckRedeemVipMember",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/preCheckRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCheckRedeemVipMemberResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直充会员预校验是否满足条件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckRedeemVipMemberRequest
        /// </param>
        /// <param name="headers">
        /// PreCheckRedeemVipMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PreCheckRedeemVipMemberResponse
        /// </returns>
        public async Task<PreCheckRedeemVipMemberResponse> PreCheckRedeemVipMemberWithOptionsAsync(PreCheckRedeemVipMemberRequest request, PreCheckRedeemVipMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "PreCheckRedeemVipMember",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/preCheckRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PreCheckRedeemVipMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直充会员预校验是否满足条件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckRedeemVipMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// PreCheckRedeemVipMemberResponse
        /// </returns>
        public PreCheckRedeemVipMemberResponse PreCheckRedeemVipMember(PreCheckRedeemVipMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreCheckRedeemVipMemberHeaders headers = new PreCheckRedeemVipMemberHeaders();
            return PreCheckRedeemVipMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>直充会员预校验是否满足条件</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PreCheckRedeemVipMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// PreCheckRedeemVipMemberResponse
        /// </returns>
        public async Task<PreCheckRedeemVipMemberResponse> PreCheckRedeemVipMemberAsync(PreCheckRedeemVipMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PreCheckRedeemVipMemberHeaders headers = new PreCheckRedeemVipMemberHeaders();
            return await PreCheckRedeemVipMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员直充信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemVipMemberRequest
        /// </param>
        /// <param name="headers">
        /// QueryRedeemVipMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemVipMemberResponse
        /// </returns>
        public QueryRedeemVipMemberResponse QueryRedeemVipMemberWithOptions(QueryRedeemVipMemberRequest request, QueryRedeemVipMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "QueryRedeemVipMember",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/queryRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedeemVipMemberResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员直充信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemVipMemberRequest
        /// </param>
        /// <param name="headers">
        /// QueryRedeemVipMemberHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemVipMemberResponse
        /// </returns>
        public async Task<QueryRedeemVipMemberResponse> QueryRedeemVipMemberWithOptionsAsync(QueryRedeemVipMemberRequest request, QueryRedeemVipMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizRequestId))
            {
                body["bizRequestId"] = request.BizRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingtalkId))
            {
                body["dingtalkId"] = request.DingtalkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                body["duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["uuid"] = request.Uuid;
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
                Action = "QueryRedeemVipMember",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/queryRedeemVip",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryRedeemVipMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员直充信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemVipMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemVipMemberResponse
        /// </returns>
        public QueryRedeemVipMemberResponse QueryRedeemVipMember(QueryRedeemVipMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedeemVipMemberHeaders headers = new QueryRedeemVipMemberHeaders();
            return QueryRedeemVipMemberWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员直充信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryRedeemVipMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryRedeemVipMemberResponse
        /// </returns>
        public async Task<QueryRedeemVipMemberResponse> QueryRedeemVipMemberAsync(QueryRedeemVipMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryRedeemVipMemberHeaders headers = new QueryRedeemVipMemberHeaders();
            return await QueryRedeemVipMemberWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVipMemberInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryVipMemberInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVipMemberInfoResponse
        /// </returns>
        public QueryVipMemberInfoResponse QueryVipMemberInfoWithOptions(QueryVipMemberInfoRequest request, QueryVipMemberInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
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
                Action = "QueryVipMemberInfo",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/memberInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVipMemberInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVipMemberInfoRequest
        /// </param>
        /// <param name="headers">
        /// QueryVipMemberInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryVipMemberInfoResponse
        /// </returns>
        public async Task<QueryVipMemberInfoResponse> QueryVipMemberInfoWithOptionsAsync(QueryVipMemberInfoRequest request, QueryVipMemberInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelCode))
            {
                body["channelCode"] = request.ChannelCode;
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
                Action = "QueryVipMemberInfo",
                Version = "vipMember_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/vipMember/users/memberInfos/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryVipMemberInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVipMemberInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVipMemberInfoResponse
        /// </returns>
        public QueryVipMemberInfoResponse QueryVipMemberInfo(QueryVipMemberInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVipMemberInfoHeaders headers = new QueryVipMemberInfoHeaders();
            return QueryVipMemberInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询365会员信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryVipMemberInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryVipMemberInfoResponse
        /// </returns>
        public async Task<QueryVipMemberInfoResponse> QueryVipMemberInfoAsync(QueryVipMemberInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryVipMemberInfoHeaders headers = new QueryVipMemberInfoHeaders();
            return await QueryVipMemberInfoWithOptionsAsync(request, headers, runtime);
        }

    }
}
