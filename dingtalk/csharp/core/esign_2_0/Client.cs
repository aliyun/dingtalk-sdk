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
            AlibabaCloud.GatewayDingTalk.Client gatewayClient = new AlibabaCloud.GatewayDingTalk.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        /**
         * @summary 获取流程任务用印审批列表
         *
         * @param headers ApprovalListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApprovalListResponse
         */
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

        /**
         * @summary 获取流程任务用印审批列表
         *
         * @param headers ApprovalListHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ApprovalListResponse
         */
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

        /**
         * @summary 获取流程任务用印审批列表
         *
         * @return ApprovalListResponse
         */
        public ApprovalListResponse ApprovalList(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApprovalListHeaders headers = new ApprovalListHeaders();
            return ApprovalListWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary 获取流程任务用印审批列表
         *
         * @return ApprovalListResponse
         */
        public async Task<ApprovalListResponse> ApprovalListAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ApprovalListHeaders headers = new ApprovalListHeaders();
            return await ApprovalListWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @summary 取消企业的授权
         *
         * @param request CancelCorpAuthRequest
         * @param headers CancelCorpAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCorpAuthResponse
         */
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

        /**
         * @summary 取消企业的授权
         *
         * @param request CancelCorpAuthRequest
         * @param headers CancelCorpAuthHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelCorpAuthResponse
         */
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

        /**
         * @summary 取消企业的授权
         *
         * @param request CancelCorpAuthRequest
         * @return CancelCorpAuthResponse
         */
        public CancelCorpAuthResponse CancelCorpAuth(CancelCorpAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return CancelCorpAuthWithOptions(request, headers, runtime);
        }

        /**
         * @summary 取消企业的授权
         *
         * @param request CancelCorpAuthRequest
         * @return CancelCorpAuthResponse
         */
        public async Task<CancelCorpAuthResponse> CancelCorpAuthAsync(CancelCorpAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelCorpAuthHeaders headers = new CancelCorpAuthHeaders();
            return await CancelCorpAuthWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrdersRequest
         * @param headers ChannelOrdersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChannelOrdersResponse
         */
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

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrdersRequest
         * @param headers ChannelOrdersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChannelOrdersResponse
         */
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

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrdersRequest
         * @return ChannelOrdersResponse
         */
        public ChannelOrdersResponse ChannelOrders(ChannelOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrdersHeaders headers = new ChannelOrdersHeaders();
            return ChannelOrdersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 套餐转售1（分润模式）
         *
         * @param request ChannelOrdersRequest
         * @return ChannelOrdersResponse
         */
        public async Task<ChannelOrdersResponse> ChannelOrdersAsync(ChannelOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChannelOrdersHeaders headers = new ChannelOrdersHeaders();
            return await ChannelOrdersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 生成企业实名的跳转地址
         *
         * @param request CorpRealnameRequest
         * @param headers CorpRealnameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CorpRealnameResponse
         */
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

        /**
         * @summary 生成企业实名的跳转地址
         *
         * @param request CorpRealnameRequest
         * @param headers CorpRealnameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CorpRealnameResponse
         */
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

        /**
         * @summary 生成企业实名的跳转地址
         *
         * @param request CorpRealnameRequest
         * @return CorpRealnameResponse
         */
        public CorpRealnameResponse CorpRealname(CorpRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpRealnameHeaders headers = new CorpRealnameHeaders();
            return CorpRealnameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生成企业实名的跳转地址
         *
         * @param request CorpRealnameRequest
         * @return CorpRealnameResponse
         */
        public async Task<CorpRealnameResponse> CorpRealnameAsync(CorpRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CorpRealnameHeaders headers = new CorpRealnameHeaders();
            return await CorpRealnameWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 钉钉ISV服务商数据初始化
         *
         * @param request CreateDevelopersRequest
         * @param headers CreateDevelopersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDevelopersResponse
         */
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

        /**
         * @summary 钉钉ISV服务商数据初始化
         *
         * @param request CreateDevelopersRequest
         * @param headers CreateDevelopersHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDevelopersResponse
         */
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

        /**
         * @summary 钉钉ISV服务商数据初始化
         *
         * @param request CreateDevelopersRequest
         * @return CreateDevelopersResponse
         */
        public CreateDevelopersResponse CreateDevelopers(CreateDevelopersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDevelopersHeaders headers = new CreateDevelopersHeaders();
            return CreateDevelopersWithOptions(request, headers, runtime);
        }

        /**
         * @summary 钉钉ISV服务商数据初始化
         *
         * @param request CreateDevelopersRequest
         * @return CreateDevelopersResponse
         */
        public async Task<CreateDevelopersResponse> CreateDevelopersAsync(CreateDevelopersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateDevelopersHeaders headers = new CreateDevelopersHeaders();
            return await CreateDevelopersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过API发起签署流程
         *
         * @param request CreateProcessRequest
         * @param headers CreateProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProcessResponse
         */
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

        /**
         * @summary 通过API发起签署流程
         *
         * @param request CreateProcessRequest
         * @param headers CreateProcessHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProcessResponse
         */
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

        /**
         * @summary 通过API发起签署流程
         *
         * @param request CreateProcessRequest
         * @return CreateProcessResponse
         */
        public CreateProcessResponse CreateProcess(CreateProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessHeaders headers = new CreateProcessHeaders();
            return CreateProcessWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过API发起签署流程
         *
         * @param request CreateProcessRequest
         * @return CreateProcessResponse
         */
        public async Task<CreateProcessResponse> CreateProcessAsync(CreateProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateProcessHeaders headers = new CreateProcessHeaders();
            return await CreateProcessWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取钉钉审批实例-电子附件信息
         *
         * @param headers GetAttachsApprovalHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAttachsApprovalResponse
         */
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

        /**
         * @summary 获取钉钉审批实例-电子附件信息
         *
         * @param headers GetAttachsApprovalHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAttachsApprovalResponse
         */
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

        /**
         * @summary 获取钉钉审批实例-电子附件信息
         *
         * @return GetAttachsApprovalResponse
         */
        public GetAttachsApprovalResponse GetAttachsApproval(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachsApprovalHeaders headers = new GetAttachsApprovalHeaders();
            return GetAttachsApprovalWithOptions(instanceId, headers, runtime);
        }

        /**
         * @summary 获取钉钉审批实例-电子附件信息
         *
         * @return GetAttachsApprovalResponse
         */
        public async Task<GetAttachsApprovalResponse> GetAttachsApprovalAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAttachsApprovalHeaders headers = new GetAttachsApprovalHeaders();
            return await GetAttachsApprovalWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @summary 生成授权页面地址
         *
         * @param request GetAuthUrlRequest
         * @param headers GetAuthUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAuthUrlResponse
         */
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

        /**
         * @summary 生成授权页面地址
         *
         * @param request GetAuthUrlRequest
         * @param headers GetAuthUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAuthUrlResponse
         */
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

        /**
         * @summary 生成授权页面地址
         *
         * @param request GetAuthUrlRequest
         * @return GetAuthUrlResponse
         */
        public GetAuthUrlResponse GetAuthUrl(GetAuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthUrlHeaders headers = new GetAuthUrlHeaders();
            return GetAuthUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 生成授权页面地址
         *
         * @param request GetAuthUrlRequest
         * @return GetAuthUrlResponse
         */
        public async Task<GetAuthUrlResponse> GetAuthUrlAsync(GetAuthUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAuthUrlHeaders headers = new GetAuthUrlHeaders();
            return await GetAuthUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询套餐余量
         *
         * @param headers GetContractMarginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetContractMarginResponse
         */
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

        /**
         * @summary 查询套餐余量
         *
         * @param headers GetContractMarginHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetContractMarginResponse
         */
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

        /**
         * @summary 查询套餐余量
         *
         * @return GetContractMarginResponse
         */
        public GetContractMarginResponse GetContractMargin()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContractMarginHeaders headers = new GetContractMarginHeaders();
            return GetContractMarginWithOptions(headers, runtime);
        }

        /**
         * @summary 查询套餐余量
         *
         * @return GetContractMarginResponse
         */
        public async Task<GetContractMarginResponse> GetContractMarginAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetContractMarginHeaders headers = new GetContractMarginHeaders();
            return await GetContractMarginWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取企业控制台地址
         *
         * @param headers GetCorpConsoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCorpConsoleResponse
         */
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

        /**
         * @summary 获取企业控制台地址
         *
         * @param headers GetCorpConsoleHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCorpConsoleResponse
         */
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

        /**
         * @summary 获取企业控制台地址
         *
         * @return GetCorpConsoleResponse
         */
        public GetCorpConsoleResponse GetCorpConsole()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpConsoleHeaders headers = new GetCorpConsoleHeaders();
            return GetCorpConsoleWithOptions(headers, runtime);
        }

        /**
         * @summary 获取企业控制台地址
         *
         * @return GetCorpConsoleResponse
         */
        public async Task<GetCorpConsoleResponse> GetCorpConsoleAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpConsoleHeaders headers = new GetCorpConsoleHeaders();
            return await GetCorpConsoleWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询企业信息
         *
         * @param headers GetCorpInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCorpInfoResponse
         */
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

        /**
         * @summary 查询企业信息
         *
         * @param headers GetCorpInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCorpInfoResponse
         */
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

        /**
         * @summary 查询企业信息
         *
         * @return GetCorpInfoResponse
         */
        public GetCorpInfoResponse GetCorpInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpInfoHeaders headers = new GetCorpInfoHeaders();
            return GetCorpInfoWithOptions(headers, runtime);
        }

        /**
         * @summary 查询企业信息
         *
         * @return GetCorpInfoResponse
         */
        public async Task<GetCorpInfoResponse> GetCorpInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCorpInfoHeaders headers = new GetCorpInfoHeaders();
            return await GetCorpInfoWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetExecuteUrlRequest
         * @param headers GetExecuteUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExecuteUrlResponse
         */
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

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetExecuteUrlRequest
         * @param headers GetExecuteUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetExecuteUrlResponse
         */
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

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetExecuteUrlRequest
         * @return GetExecuteUrlResponse
         */
        public GetExecuteUrlResponse GetExecuteUrl(GetExecuteUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExecuteUrlHeaders headers = new GetExecuteUrlHeaders();
            return GetExecuteUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取签署人签署地址
         *
         * @param request GetExecuteUrlRequest
         * @return GetExecuteUrlResponse
         */
        public async Task<GetExecuteUrlResponse> GetExecuteUrlAsync(GetExecuteUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetExecuteUrlHeaders headers = new GetExecuteUrlHeaders();
            return await GetExecuteUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取文件详情
         *
         * @param headers GetFileInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileInfoResponse
         */
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

        /**
         * @summary 获取文件详情
         *
         * @param headers GetFileInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileInfoResponse
         */
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

        /**
         * @summary 获取文件详情
         *
         * @return GetFileInfoResponse
         */
        public GetFileInfoResponse GetFileInfo(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return GetFileInfoWithOptions(fileId, headers, runtime);
        }

        /**
         * @summary 获取文件详情
         *
         * @return GetFileInfoResponse
         */
        public async Task<GetFileInfoResponse> GetFileInfoAsync(string fileId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileInfoHeaders headers = new GetFileInfoHeaders();
            return await GetFileInfoWithOptionsAsync(fileId, headers, runtime);
        }

        /**
         * @summary 获取文件上传地址
         *
         * @param request GetFileUploadUrlRequest
         * @param headers GetFileUploadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileUploadUrlResponse
         */
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

        /**
         * @summary 获取文件上传地址
         *
         * @param request GetFileUploadUrlRequest
         * @param headers GetFileUploadUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFileUploadUrlResponse
         */
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

        /**
         * @summary 获取文件上传地址
         *
         * @param request GetFileUploadUrlRequest
         * @return GetFileUploadUrlResponse
         */
        public GetFileUploadUrlResponse GetFileUploadUrl(GetFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadUrlHeaders headers = new GetFileUploadUrlHeaders();
            return GetFileUploadUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取文件上传地址
         *
         * @param request GetFileUploadUrlRequest
         * @return GetFileUploadUrlResponse
         */
        public async Task<GetFileUploadUrlResponse> GetFileUploadUrlAsync(GetFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFileUploadUrlHeaders headers = new GetFileUploadUrlHeaders();
            return await GetFileUploadUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取流程详细信息及操作记录
         *
         * @param headers GetFlowDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowDetailResponse
         */
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

        /**
         * @summary 获取流程详细信息及操作记录
         *
         * @param headers GetFlowDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowDetailResponse
         */
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

        /**
         * @summary 获取流程详细信息及操作记录
         *
         * @return GetFlowDetailResponse
         */
        public GetFlowDetailResponse GetFlowDetail(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return GetFlowDetailWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary 获取流程详细信息及操作记录
         *
         * @return GetFlowDetailResponse
         */
        public async Task<GetFlowDetailResponse> GetFlowDetailAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDetailHeaders headers = new GetFlowDetailHeaders();
            return await GetFlowDetailWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
         *
         * @param headers GetFlowDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowDocsResponse
         */
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

        /**
         * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
         *
         * @param headers GetFlowDocsHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetFlowDocsResponse
         */
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

        /**
         * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
         *
         * @return GetFlowDocsResponse
         */
        public GetFlowDocsResponse GetFlowDocs(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDocsHeaders headers = new GetFlowDocsHeaders();
            return GetFlowDocsWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary 获取流程任务的所有合同列表，收到签署完成消息后查询
         *
         * @return GetFlowDocsResponse
         */
        public async Task<GetFlowDocsResponse> GetFlowDocsAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetFlowDocsHeaders headers = new GetFlowDocsHeaders();
            return await GetFlowDocsWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @summary 获取企业的e签宝微应用当前状态
         *
         * @param headers GetIsvStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIsvStatusResponse
         */
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

        /**
         * @summary 获取企业的e签宝微应用当前状态
         *
         * @param headers GetIsvStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIsvStatusResponse
         */
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

        /**
         * @summary 获取企业的e签宝微应用当前状态
         *
         * @return GetIsvStatusResponse
         */
        public GetIsvStatusResponse GetIsvStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsvStatusHeaders headers = new GetIsvStatusHeaders();
            return GetIsvStatusWithOptions(headers, runtime);
        }

        /**
         * @summary 获取企业的e签宝微应用当前状态
         *
         * @return GetIsvStatusResponse
         */
        public async Task<GetIsvStatusResponse> GetIsvStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetIsvStatusHeaders headers = new GetIsvStatusHeaders();
            return await GetIsvStatusWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 获取流程签署的详细信息
         *
         * @param headers GetSignDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignDetailResponse
         */
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

        /**
         * @summary 获取流程签署的详细信息
         *
         * @param headers GetSignDetailHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSignDetailResponse
         */
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

        /**
         * @summary 获取流程签署的详细信息
         *
         * @return GetSignDetailResponse
         */
        public GetSignDetailResponse GetSignDetail(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignDetailHeaders headers = new GetSignDetailHeaders();
            return GetSignDetailWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary 获取流程签署的详细信息
         *
         * @return GetSignDetailResponse
         */
        public async Task<GetSignDetailResponse> GetSignDetailAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetSignDetailHeaders headers = new GetSignDetailHeaders();
            return await GetSignDetailWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @summary 查询个人信息
         *
         * @param headers GetUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserInfoResponse
         */
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

        /**
         * @summary 查询个人信息
         *
         * @param headers GetUserInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserInfoResponse
         */
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

        /**
         * @summary 查询个人信息
         *
         * @return GetUserInfoResponse
         */
        public GetUserInfoResponse GetUserInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return GetUserInfoWithOptions(userId, headers, runtime);
        }

        /**
         * @summary 查询个人信息
         *
         * @return GetUserInfoResponse
         */
        public async Task<GetUserInfoResponse> GetUserInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetUserInfoHeaders headers = new GetUserInfoHeaders();
            return await GetUserInfoWithOptionsAsync(userId, headers, runtime);
        }

        /**
         * @summary 获取发起签署任务的地址
         *
         * @param request ProcessStartRequest
         * @param headers ProcessStartHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessStartResponse
         */
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

        /**
         * @summary 获取发起签署任务的地址
         *
         * @param request ProcessStartRequest
         * @param headers ProcessStartHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ProcessStartResponse
         */
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

        /**
         * @summary 获取发起签署任务的地址
         *
         * @param request ProcessStartRequest
         * @return ProcessStartResponse
         */
        public ProcessStartResponse ProcessStart(ProcessStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessStartHeaders headers = new ProcessStartHeaders();
            return ProcessStartWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取发起签署任务的地址
         *
         * @param request ProcessStartRequest
         * @return ProcessStartResponse
         */
        public async Task<ProcessStartResponse> ProcessStartAsync(ProcessStartRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ProcessStartHeaders headers = new ProcessStartHeaders();
            return await ProcessStartWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request ResaleOrderRequest
         * @param headers ResaleOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResaleOrderResponse
         */
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

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request ResaleOrderRequest
         * @param headers ResaleOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResaleOrderResponse
         */
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

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request ResaleOrderRequest
         * @return ResaleOrderResponse
         */
        public ResaleOrderResponse ResaleOrder(ResaleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResaleOrderHeaders headers = new ResaleOrderHeaders();
            return ResaleOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 套餐转售2（底价结算模式）
         *
         * @param request ResaleOrderRequest
         * @return ResaleOrderResponse
         */
        public async Task<ResaleOrderResponse> ResaleOrderAsync(ResaleOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ResaleOrderHeaders headers = new ResaleOrderHeaders();
            return await ResaleOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request UsersRealnameRequest
         * @param headers UsersRealnameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UsersRealnameResponse
         */
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

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request UsersRealnameRequest
         * @param headers UsersRealnameHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UsersRealnameResponse
         */
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

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request UsersRealnameRequest
         * @return UsersRealnameResponse
         */
        public UsersRealnameResponse UsersRealname(UsersRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UsersRealnameHeaders headers = new UsersRealnameHeaders();
            return UsersRealnameWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取跳转到个人实名的地址
         *
         * @param request UsersRealnameRequest
         * @return UsersRealnameResponse
         */
        public async Task<UsersRealnameResponse> UsersRealnameAsync(UsersRealnameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UsersRealnameHeaders headers = new UsersRealnameHeaders();
            return await UsersRealnameWithOptionsAsync(request, headers, runtime);
        }

    }
}
