// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkesign_2_0.Models;

namespace AlibabaCloud.SDK.Dingtalkesign_2_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "dingtalk";
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
        /// <para>获取流程任务用印审批列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ApprovalListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApprovalListResponse
        /// </returns>
        public ApprovalListResponse ApprovalListWithOptions(string taskId, ApprovalListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ApprovalList",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/approvals/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApprovalListResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程任务用印审批列表</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// ApprovalListHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApprovalListResponse
        /// </returns>
        public async Task<ApprovalListResponse> ApprovalListWithOptionsAsync(string taskId, ApprovalListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ApprovalList",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/approvals/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApprovalListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程任务用印审批列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ApprovalListResponse
        /// </returns>
        public ApprovalListResponse ApprovalList(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApprovalListHeaders headers = new ApprovalListHeaders();
            return ApprovalListWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程任务用印审批列表</para>
        /// </summary>
        /// 
        /// <returns>
        /// ApprovalListResponse
        /// </returns>
        public async Task<ApprovalListResponse> ApprovalListAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApprovalListHeaders headers = new ApprovalListHeaders();
            return await ApprovalListWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消企业的授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCorpAuthRequest
        /// </param>
        /// <param name="headers">
        /// CancelCorpAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelCorpAuthResponse
        /// </returns>
        public CancelCorpAuthResponse CancelCorpAuthWithOptions(CancelCorpAuthRequest request, CancelCorpAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "CancelCorpAuth",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/auths/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCorpAuthResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消企业的授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCorpAuthRequest
        /// </param>
        /// <param name="headers">
        /// CancelCorpAuthHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelCorpAuthResponse
        /// </returns>
        public async Task<CancelCorpAuthResponse> CancelCorpAuthWithOptionsAsync(CancelCorpAuthRequest request, CancelCorpAuthHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "CancelCorpAuth",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/auths/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCorpAuthResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消企业的授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCorpAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelCorpAuthResponse
        /// </returns>
        public CancelCorpAuthResponse CancelCorpAuth(CancelCorpAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return CancelCorpAuthWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消企业的授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCorpAuthRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelCorpAuthResponse
        /// </returns>
        public async Task<CancelCorpAuthResponse> CancelCorpAuthAsync(CancelCorpAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return await CancelCorpAuthWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售1（分润模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChannelOrdersRequest
        /// </param>
        /// <param name="headers">
        /// ChannelOrdersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChannelOrdersResponse
        /// </returns>
        public ChannelOrdersResponse ChannelOrdersWithOptions(ChannelOrdersRequest request, ChannelOrdersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCode))
            {
                body["itemCode"] = request.ItemCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemName))
            {
                body["itemName"] = request.ItemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayFee))
            {
                body["payFee"] = request.PayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ChannelOrders",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/orders/channel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChannelOrdersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售1（分润模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChannelOrdersRequest
        /// </param>
        /// <param name="headers">
        /// ChannelOrdersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChannelOrdersResponse
        /// </returns>
        public async Task<ChannelOrdersResponse> ChannelOrdersWithOptionsAsync(ChannelOrdersRequest request, ChannelOrdersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCode))
            {
                body["itemCode"] = request.ItemCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemName))
            {
                body["itemName"] = request.ItemName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayFee))
            {
                body["payFee"] = request.PayFee;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ChannelOrders",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/orders/channel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChannelOrdersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售1（分润模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChannelOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ChannelOrdersResponse
        /// </returns>
        public ChannelOrdersResponse ChannelOrders(ChannelOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrdersHeaders headers = new ChannelOrdersHeaders();
            return ChannelOrdersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售1（分润模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChannelOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ChannelOrdersResponse
        /// </returns>
        public async Task<ChannelOrdersResponse> ChannelOrdersAsync(ChannelOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrdersHeaders headers = new ChannelOrdersHeaders();
            return await ChannelOrdersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成企业实名的跳转地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CorpRealnameRequest
        /// </param>
        /// <param name="headers">
        /// CorpRealnameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CorpRealnameResponse
        /// </returns>
        public CorpRealnameResponse CorpRealnameWithOptions(CorpRealnameRequest request, CorpRealnameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "CorpRealname",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/realnames",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpRealnameResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成企业实名的跳转地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CorpRealnameRequest
        /// </param>
        /// <param name="headers">
        /// CorpRealnameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CorpRealnameResponse
        /// </returns>
        public async Task<CorpRealnameResponse> CorpRealnameWithOptionsAsync(CorpRealnameRequest request, CorpRealnameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "CorpRealname",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/realnames",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CorpRealnameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成企业实名的跳转地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CorpRealnameRequest
        /// </param>
        /// 
        /// <returns>
        /// CorpRealnameResponse
        /// </returns>
        public CorpRealnameResponse CorpRealname(CorpRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpRealnameHeaders headers = new CorpRealnameHeaders();
            return CorpRealnameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成企业实名的跳转地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CorpRealnameRequest
        /// </param>
        /// 
        /// <returns>
        /// CorpRealnameResponse
        /// </returns>
        public async Task<CorpRealnameResponse> CorpRealnameAsync(CorpRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpRealnameHeaders headers = new CorpRealnameHeaders();
            return await CorpRealnameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉ISV服务商数据初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDevelopersRequest
        /// </param>
        /// <param name="headers">
        /// CreateDevelopersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDevelopersResponse
        /// </returns>
        public CreateDevelopersResponse CreateDevelopersWithOptions(CreateDevelopersRequest request, CreateDevelopersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeUrl))
            {
                body["noticeUrl"] = request.NoticeUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "CreateDevelopers",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/developers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDevelopersResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉ISV服务商数据初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDevelopersRequest
        /// </param>
        /// <param name="headers">
        /// CreateDevelopersHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDevelopersResponse
        /// </returns>
        public async Task<CreateDevelopersResponse> CreateDevelopersWithOptionsAsync(CreateDevelopersRequest request, CreateDevelopersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoticeUrl))
            {
                body["noticeUrl"] = request.NoticeUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "CreateDevelopers",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/developers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDevelopersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉ISV服务商数据初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDevelopersRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDevelopersResponse
        /// </returns>
        public CreateDevelopersResponse CreateDevelopers(CreateDevelopersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDevelopersHeaders headers = new CreateDevelopersHeaders();
            return CreateDevelopersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>钉钉ISV服务商数据初始化</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDevelopersRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDevelopersResponse
        /// </returns>
        public async Task<CreateDevelopersResponse> CreateDevelopersAsync(CreateDevelopersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDevelopersHeaders headers = new CreateDevelopersHeaders();
            return await CreateDevelopersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API发起签署流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessRequest
        /// </param>
        /// <param name="headers">
        /// CreateProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessResponse
        /// </returns>
        public CreateProcessResponse CreateProcessWithOptions(CreateProcessRequest request, CreateProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorUserId))
            {
                body["initiatorUserId"] = request.InitiatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participants))
            {
                body["participants"] = request.Participants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignEndTime))
            {
                body["signEndTime"] = request.SignEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo))
            {
                body["sourceInfo"] = request.SourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateProcess",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/process/startAtOnce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProcessResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API发起签署流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessRequest
        /// </param>
        /// <param name="headers">
        /// CreateProcessHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessResponse
        /// </returns>
        public async Task<CreateProcessResponse> CreateProcessWithOptionsAsync(CreateProcessRequest request, CreateProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorUserId))
            {
                body["initiatorUserId"] = request.InitiatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participants))
            {
                body["participants"] = request.Participants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignEndTime))
            {
                body["signEndTime"] = request.SignEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo))
            {
                body["sourceInfo"] = request.SourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
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
                Action = "CreateProcess",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/process/startAtOnce",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API发起签署流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessResponse
        /// </returns>
        public CreateProcessResponse CreateProcess(CreateProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessHeaders headers = new CreateProcessHeaders();
            return CreateProcessWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过API发起签署流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProcessResponse
        /// </returns>
        public async Task<CreateProcessResponse> CreateProcessAsync(CreateProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessHeaders headers = new CreateProcessHeaders();
            return await CreateProcessWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉钉审批实例-电子附件信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAttachsApprovalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachsApprovalResponse
        /// </returns>
        public GetAttachsApprovalResponse GetAttachsApprovalWithOptions(string instanceId, GetAttachsApprovalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TsignOpenAppId))
            {
                realHeaders["tsignOpenAppId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TsignOpenAppId);
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
                Action = "GetAttachsApproval",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/dingInstances/" + instanceId + "/attachments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachsApprovalResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉钉审批实例-电子附件信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetAttachsApprovalHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachsApprovalResponse
        /// </returns>
        public async Task<GetAttachsApprovalResponse> GetAttachsApprovalWithOptionsAsync(string instanceId, GetAttachsApprovalHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.TsignOpenAppId))
            {
                realHeaders["tsignOpenAppId"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.TsignOpenAppId);
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
                Action = "GetAttachsApproval",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/dingInstances/" + instanceId + "/attachments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachsApprovalResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉钉审批实例-电子附件信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAttachsApprovalResponse
        /// </returns>
        public GetAttachsApprovalResponse GetAttachsApproval(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachsApprovalHeaders headers = new GetAttachsApprovalHeaders();
            return GetAttachsApprovalWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取钉钉审批实例-电子附件信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetAttachsApprovalResponse
        /// </returns>
        public async Task<GetAttachsApprovalResponse> GetAttachsApprovalAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachsApprovalHeaders headers = new GetAttachsApprovalHeaders();
            return await GetAttachsApprovalWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成授权页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetAuthUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthUrlResponse
        /// </returns>
        public GetAuthUrlResponse GetAuthUrlWithOptions(GetAuthUrlRequest request, GetAuthUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetAuthUrl",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/auths/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成授权页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetAuthUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAuthUrlResponse
        /// </returns>
        public async Task<GetAuthUrlResponse> GetAuthUrlWithOptionsAsync(GetAuthUrlRequest request, GetAuthUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetAuthUrl",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/auths/urls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAuthUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成授权页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthUrlResponse
        /// </returns>
        public GetAuthUrlResponse GetAuthUrl(GetAuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthUrlHeaders headers = new GetAuthUrlHeaders();
            return GetAuthUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>生成授权页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAuthUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAuthUrlResponse
        /// </returns>
        public async Task<GetAuthUrlResponse> GetAuthUrlAsync(GetAuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthUrlHeaders headers = new GetAuthUrlHeaders();
            return await GetAuthUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐余量</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetContractMarginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContractMarginResponse
        /// </returns>
        public GetContractMarginResponse GetContractMarginWithOptions(GetContractMarginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetContractMargin",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/margins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContractMarginResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐余量</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetContractMarginHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContractMarginResponse
        /// </returns>
        public async Task<GetContractMarginResponse> GetContractMarginWithOptionsAsync(GetContractMarginHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetContractMargin",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/margins",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContractMarginResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐余量</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetContractMarginResponse
        /// </returns>
        public GetContractMarginResponse GetContractMargin()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContractMarginHeaders headers = new GetContractMarginHeaders();
            return GetContractMarginWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询套餐余量</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetContractMarginResponse
        /// </returns>
        public async Task<GetContractMarginResponse> GetContractMarginAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContractMarginHeaders headers = new GetContractMarginHeaders();
            return await GetContractMarginWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业控制台地址</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCorpConsoleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpConsoleResponse
        /// </returns>
        public GetCorpConsoleResponse GetCorpConsoleWithOptions(GetCorpConsoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetCorpConsole",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/consoles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpConsoleResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业控制台地址</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCorpConsoleHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpConsoleResponse
        /// </returns>
        public async Task<GetCorpConsoleResponse> GetCorpConsoleWithOptionsAsync(GetCorpConsoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetCorpConsole",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/consoles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpConsoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业控制台地址</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCorpConsoleResponse
        /// </returns>
        public GetCorpConsoleResponse GetCorpConsole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpConsoleHeaders headers = new GetCorpConsoleHeaders();
            return GetCorpConsoleWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业控制台地址</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCorpConsoleResponse
        /// </returns>
        public async Task<GetCorpConsoleResponse> GetCorpConsoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpConsoleHeaders headers = new GetCorpConsoleHeaders();
            return await GetCorpConsoleWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCorpInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpInfoResponse
        /// </returns>
        public GetCorpInfoResponse GetCorpInfoWithOptions(GetCorpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetCorpInfo",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetCorpInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCorpInfoResponse
        /// </returns>
        public async Task<GetCorpInfoResponse> GetCorpInfoWithOptionsAsync(GetCorpInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetCorpInfo",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCorpInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCorpInfoResponse
        /// </returns>
        public GetCorpInfoResponse GetCorpInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpInfoHeaders headers = new GetCorpInfoHeaders();
            return GetCorpInfoWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询企业信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetCorpInfoResponse
        /// </returns>
        public async Task<GetCorpInfoResponse> GetCorpInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpInfoHeaders headers = new GetCorpInfoHeaders();
            return await GetCorpInfoWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签署人签署地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecuteUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetExecuteUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExecuteUrlResponse
        /// </returns>
        public GetExecuteUrlResponse GetExecuteUrlWithOptions(GetExecuteUrlRequest request, GetExecuteUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignContainer))
            {
                body["signContainer"] = request.SignContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetExecuteUrl",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/process/executeUrls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecuteUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签署人签署地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecuteUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetExecuteUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExecuteUrlResponse
        /// </returns>
        public async Task<GetExecuteUrlResponse> GetExecuteUrlWithOptionsAsync(GetExecuteUrlRequest request, GetExecuteUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                body["account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignContainer))
            {
                body["signContainer"] = request.SignContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetExecuteUrl",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/process/executeUrls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExecuteUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签署人签署地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecuteUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExecuteUrlResponse
        /// </returns>
        public GetExecuteUrlResponse GetExecuteUrl(GetExecuteUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExecuteUrlHeaders headers = new GetExecuteUrlHeaders();
            return GetExecuteUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取签署人签署地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExecuteUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExecuteUrlResponse
        /// </returns>
        public async Task<GetExecuteUrlResponse> GetExecuteUrlAsync(GetExecuteUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExecuteUrlHeaders headers = new GetExecuteUrlHeaders();
            return await GetExecuteUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFileInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileInfoResponse
        /// </returns>
        public GetFileInfoResponse GetFileInfoWithOptions(string fileId, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFileInfo",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/files/" + fileId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFileInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileInfoResponse
        /// </returns>
        public async Task<GetFileInfoResponse> GetFileInfoWithOptionsAsync(string fileId, GetFileInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFileInfo",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/files/" + fileId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFileInfoResponse
        /// </returns>
        public GetFileInfoResponse GetFileInfo(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return GetFileInfoWithOptions(fileId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFileInfoResponse
        /// </returns>
        public async Task<GetFileInfoResponse> GetFileInfoAsync(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return await GetFileInfoWithOptionsAsync(fileId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetFileUploadUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadUrlResponse
        /// </returns>
        public GetFileUploadUrlResponse GetFileUploadUrlWithOptions(GetFileUploadUrlRequest request, GetFileUploadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentMd5))
            {
                body["contentMd5"] = request.ContentMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Convert2Pdf))
            {
                body["convert2Pdf"] = request.Convert2Pdf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFileUploadUrl",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/files/uploadUrls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetFileUploadUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadUrlResponse
        /// </returns>
        public async Task<GetFileUploadUrlResponse> GetFileUploadUrlWithOptionsAsync(GetFileUploadUrlRequest request, GetFileUploadUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentMd5))
            {
                body["contentMd5"] = request.ContentMd5;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentType))
            {
                body["contentType"] = request.ContentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Convert2Pdf))
            {
                body["convert2Pdf"] = request.Convert2Pdf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSize))
            {
                body["fileSize"] = request.FileSize;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFileUploadUrl",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/files/uploadUrls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFileUploadUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadUrlResponse
        /// </returns>
        public GetFileUploadUrlResponse GetFileUploadUrl(GetFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadUrlHeaders headers = new GetFileUploadUrlHeaders();
            return GetFileUploadUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取文件上传地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetFileUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetFileUploadUrlResponse
        /// </returns>
        public async Task<GetFileUploadUrlResponse> GetFileUploadUrlAsync(GetFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadUrlHeaders headers = new GetFileUploadUrlHeaders();
            return await GetFileUploadUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程详细信息及操作记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFlowDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDetailResponse
        /// </returns>
        public GetFlowDetailResponse GetFlowDetailWithOptions(string taskId, GetFlowDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFlowDetail",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/flowTasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程详细信息及操作记录</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFlowDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDetailResponse
        /// </returns>
        public async Task<GetFlowDetailResponse> GetFlowDetailWithOptionsAsync(string taskId, GetFlowDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFlowDetail",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/flowTasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程详细信息及操作记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFlowDetailResponse
        /// </returns>
        public GetFlowDetailResponse GetFlowDetail(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return GetFlowDetailWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程详细信息及操作记录</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFlowDetailResponse
        /// </returns>
        public async Task<GetFlowDetailResponse> GetFlowDetailAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return await GetFlowDetailWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程任务的所有合同列表，收到签署完成消息后查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFlowDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDocsResponse
        /// </returns>
        public GetFlowDocsResponse GetFlowDocsWithOptions(string taskId, GetFlowDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFlowDocs",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/flowTasks/" + taskId + "/docs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDocsResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程任务的所有合同列表，收到签署完成消息后查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetFlowDocsHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetFlowDocsResponse
        /// </returns>
        public async Task<GetFlowDocsResponse> GetFlowDocsWithOptionsAsync(string taskId, GetFlowDocsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetFlowDocs",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/flowTasks/" + taskId + "/docs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetFlowDocsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程任务的所有合同列表，收到签署完成消息后查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFlowDocsResponse
        /// </returns>
        public GetFlowDocsResponse GetFlowDocs(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDocsHeaders headers = new GetFlowDocsHeaders();
            return GetFlowDocsWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程任务的所有合同列表，收到签署完成消息后查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetFlowDocsResponse
        /// </returns>
        public async Task<GetFlowDocsResponse> GetFlowDocsAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDocsHeaders headers = new GetFlowDocsHeaders();
            return await GetFlowDocsWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的e签宝微应用当前状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetIsvStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIsvStatusResponse
        /// </returns>
        public GetIsvStatusResponse GetIsvStatusWithOptions(GetIsvStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetIsvStatus",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/appStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIsvStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的e签宝微应用当前状态</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetIsvStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIsvStatusResponse
        /// </returns>
        public async Task<GetIsvStatusResponse> GetIsvStatusWithOptionsAsync(GetIsvStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetIsvStatus",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/corps/appStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIsvStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的e签宝微应用当前状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIsvStatusResponse
        /// </returns>
        public GetIsvStatusResponse GetIsvStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsvStatusHeaders headers = new GetIsvStatusHeaders();
            return GetIsvStatusWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取企业的e签宝微应用当前状态</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetIsvStatusResponse
        /// </returns>
        public async Task<GetIsvStatusResponse> GetIsvStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsvStatusHeaders headers = new GetIsvStatusHeaders();
            return await GetIsvStatusWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程签署的详细信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSignDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignDetailResponse
        /// </returns>
        public GetSignDetailResponse GetSignDetailWithOptions(string taskId, GetSignDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetSignDetail",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/signTasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignDetailResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程签署的详细信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetSignDetailHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSignDetailResponse
        /// </returns>
        public async Task<GetSignDetailResponse> GetSignDetailWithOptionsAsync(string taskId, GetSignDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetSignDetail",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/signTasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSignDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程签署的详细信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSignDetailResponse
        /// </returns>
        public GetSignDetailResponse GetSignDetail(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignDetailHeaders headers = new GetSignDetailHeaders();
            return GetSignDetailWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取流程签署的详细信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetSignDetailResponse
        /// </returns>
        public async Task<GetSignDetailResponse> GetSignDetailAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignDetailHeaders headers = new GetSignDetailHeaders();
            return await GetSignDetailWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public GetUserInfoResponse GetUserInfoWithOptions(string userId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetUserInfo",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人信息</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// GetUserInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public async Task<GetUserInfoResponse> GetUserInfoWithOptionsAsync(string userId, GetUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "GetUserInfo",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public GetUserInfoResponse GetUserInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return GetUserInfoWithOptions(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询个人信息</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetUserInfoResponse
        /// </returns>
        public async Task<GetUserInfoResponse> GetUserInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return await GetUserInfoWithOptionsAsync(userId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发起签署任务的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessStartRequest
        /// </param>
        /// <param name="headers">
        /// ProcessStartHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessStartResponse
        /// </returns>
        public ProcessStartResponse ProcessStartWithOptions(ProcessStartRequest request, ProcessStartHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                body["autoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorUserId))
            {
                body["initiatorUserId"] = request.InitiatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participants))
            {
                body["participants"] = request.Participants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo))
            {
                body["sourceInfo"] = request.SourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ProcessStart",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/processes/startUrls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessStartResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发起签署任务的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessStartRequest
        /// </param>
        /// <param name="headers">
        /// ProcessStartHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ProcessStartResponse
        /// </returns>
        public async Task<ProcessStartResponse> ProcessStartWithOptionsAsync(ProcessStartRequest request, ProcessStartHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoStart))
            {
                body["autoStart"] = request.AutoStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ccs))
            {
                body["ccs"] = request.Ccs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                body["files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorUserId))
            {
                body["initiatorUserId"] = request.InitiatorUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Participants))
            {
                body["participants"] = request.Participants;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceInfo))
            {
                body["sourceInfo"] = request.SourceInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskName))
            {
                body["taskName"] = request.TaskName;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ProcessStart",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/processes/startUrls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ProcessStartResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发起签署任务的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessStartRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessStartResponse
        /// </returns>
        public ProcessStartResponse ProcessStart(ProcessStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessStartHeaders headers = new ProcessStartHeaders();
            return ProcessStartWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取发起签署任务的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ProcessStartRequest
        /// </param>
        /// 
        /// <returns>
        /// ProcessStartResponse
        /// </returns>
        public async Task<ProcessStartResponse> ProcessStartAsync(ProcessStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessStartHeaders headers = new ProcessStartHeaders();
            return await ProcessStartWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售2（底价结算模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResaleOrderRequest
        /// </param>
        /// <param name="headers">
        /// ResaleOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResaleOrderResponse
        /// </returns>
        public ResaleOrderResponse ResaleOrderWithOptions(ResaleOrderRequest request, ResaleOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStartTime))
            {
                body["serviceStartTime"] = request.ServiceStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStopTime))
            {
                body["serviceStopTime"] = request.ServiceStopTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ResaleOrder",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/orders/resale",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResaleOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售2（底价结算模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResaleOrderRequest
        /// </param>
        /// <param name="headers">
        /// ResaleOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResaleOrderResponse
        /// </returns>
        public async Task<ResaleOrderResponse> ResaleOrderWithOptionsAsync(ResaleOrderRequest request, ResaleOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderCreateTime))
            {
                body["orderCreateTime"] = request.OrderCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                body["quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStartTime))
            {
                body["serviceStartTime"] = request.ServiceStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStopTime))
            {
                body["serviceStopTime"] = request.ServiceStopTime;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "ResaleOrder",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/orders/resale",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResaleOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售2（底价结算模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResaleOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ResaleOrderResponse
        /// </returns>
        public ResaleOrderResponse ResaleOrder(ResaleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResaleOrderHeaders headers = new ResaleOrderHeaders();
            return ResaleOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>套餐转售2（底价结算模式）</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResaleOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// ResaleOrderResponse
        /// </returns>
        public async Task<ResaleOrderResponse> ResaleOrderAsync(ResaleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResaleOrderHeaders headers = new ResaleOrderHeaders();
            return await ResaleOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取跳转到个人实名的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UsersRealnameRequest
        /// </param>
        /// <param name="headers">
        /// UsersRealnameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UsersRealnameResponse
        /// </returns>
        public UsersRealnameResponse UsersRealnameWithOptions(UsersRealnameRequest request, UsersRealnameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "UsersRealname",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/users/realnames",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UsersRealnameResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取跳转到个人实名的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UsersRealnameRequest
        /// </param>
        /// <param name="headers">
        /// UsersRealnameHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UsersRealnameResponse
        /// </returns>
        public async Task<UsersRealnameResponse> UsersRealnameWithOptionsAsync(UsersRealnameRequest request, UsersRealnameHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedirectUrl))
            {
                body["redirectUrl"] = request.RedirectUrl;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.ServiceGroup))
            {
                realHeaders["serviceGroup"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.ServiceGroup);
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
                Action = "UsersRealname",
                Version = "esign_2.0",
                Protocol = "HTTP",
                Pathname = "/v2.0/esign/users/realnames",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UsersRealnameResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取跳转到个人实名的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UsersRealnameRequest
        /// </param>
        /// 
        /// <returns>
        /// UsersRealnameResponse
        /// </returns>
        public UsersRealnameResponse UsersRealname(UsersRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UsersRealnameHeaders headers = new UsersRealnameHeaders();
            return UsersRealnameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取跳转到个人实名的地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UsersRealnameRequest
        /// </param>
        /// 
        /// <returns>
        /// UsersRealnameResponse
        /// </returns>
        public async Task<UsersRealnameResponse> UsersRealnameAsync(UsersRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UsersRealnameHeaders headers = new UsersRealnameHeaders();
            return await UsersRealnameWithOptionsAsync(request, headers, runtime);
        }

    }
}
