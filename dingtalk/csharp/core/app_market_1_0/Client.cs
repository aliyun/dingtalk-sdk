// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkapp_market_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkapp_market_1_0
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
        /// <para>创建应用商品服务群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppGoodsServiceConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateAppGoodsServiceConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppGoodsServiceConversationResponse
        /// </returns>
        public CreateAppGoodsServiceConversationResponse CreateAppGoodsServiceConversationWithOptions(CreateAppGoodsServiceConversationRequest request, CreateAppGoodsServiceConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvUserId))
            {
                body["isvUserId"] = request.IsvUserId;
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
                Action = "CreateAppGoodsServiceConversation",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/orders/serviceGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppGoodsServiceConversationResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用商品服务群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppGoodsServiceConversationRequest
        /// </param>
        /// <param name="headers">
        /// CreateAppGoodsServiceConversationHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppGoodsServiceConversationResponse
        /// </returns>
        public async Task<CreateAppGoodsServiceConversationResponse> CreateAppGoodsServiceConversationWithOptionsAsync(CreateAppGoodsServiceConversationRequest request, CreateAppGoodsServiceConversationHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvUserId))
            {
                body["isvUserId"] = request.IsvUserId;
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
                Action = "CreateAppGoodsServiceConversation",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/orders/serviceGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppGoodsServiceConversationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用商品服务群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppGoodsServiceConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppGoodsServiceConversationResponse
        /// </returns>
        public CreateAppGoodsServiceConversationResponse CreateAppGoodsServiceConversation(CreateAppGoodsServiceConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
            return CreateAppGoodsServiceConversationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建应用商品服务群</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppGoodsServiceConversationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppGoodsServiceConversationResponse
        /// </returns>
        public async Task<CreateAppGoodsServiceConversationResponse> CreateAppGoodsServiceConversationAsync(CreateAppGoodsServiceConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
            return await CreateAppGoodsServiceConversationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酷应用访问状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoolAppAccessStatusRequest
        /// </param>
        /// <param name="headers">
        /// GetCoolAppAccessStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCoolAppAccessStatusResponse
        /// </returns>
        public GetCoolAppAccessStatusResponse GetCoolAppAccessStatusWithOptions(GetCoolAppAccessStatusRequest request, GetCoolAppAccessStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncFieldBizCode))
            {
                body["encFieldBizCode"] = request.EncFieldBizCode;
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
                Action = "GetCoolAppAccessStatus",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/coolApps/accessions/statuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCoolAppAccessStatusResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酷应用访问状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoolAppAccessStatusRequest
        /// </param>
        /// <param name="headers">
        /// GetCoolAppAccessStatusHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCoolAppAccessStatusResponse
        /// </returns>
        public async Task<GetCoolAppAccessStatusResponse> GetCoolAppAccessStatusWithOptionsAsync(GetCoolAppAccessStatusRequest request, GetCoolAppAccessStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthCode))
            {
                body["authCode"] = request.AuthCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolAppCode))
            {
                body["coolAppCode"] = request.CoolAppCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncFieldBizCode))
            {
                body["encFieldBizCode"] = request.EncFieldBizCode;
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
                Action = "GetCoolAppAccessStatus",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/coolApps/accessions/statuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCoolAppAccessStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酷应用访问状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoolAppAccessStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCoolAppAccessStatusResponse
        /// </returns>
        public GetCoolAppAccessStatusResponse GetCoolAppAccessStatus(GetCoolAppAccessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCoolAppAccessStatusHeaders headers = new GetCoolAppAccessStatusHeaders();
            return GetCoolAppAccessStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取酷应用访问状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoolAppAccessStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCoolAppAccessStatusResponse
        /// </returns>
        public async Task<GetCoolAppAccessStatusResponse> GetCoolAppAccessStatusAsync(GetCoolAppAccessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCoolAppAccessStatusHeaders headers = new GetCoolAppAccessStatusHeaders();
            return await GetCoolAppAccessStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品SKU页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppSkuUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetInAppSkuUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInAppSkuUrlResponse
        /// </returns>
        public GetInAppSkuUrlResponse GetInAppSkuUrlWithOptions(GetInAppSkuUrlRequest request, GetInAppSkuUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackPage))
            {
                body["callbackPage"] = request.CallbackPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendParam))
            {
                body["extendParam"] = request.ExtendParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                body["goodsCode"] = request.GoodsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCode))
            {
                body["itemCode"] = request.ItemCode;
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
                Action = "GetInAppSkuUrl",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/internals/skuPages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInAppSkuUrlResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品SKU页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppSkuUrlRequest
        /// </param>
        /// <param name="headers">
        /// GetInAppSkuUrlHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInAppSkuUrlResponse
        /// </returns>
        public async Task<GetInAppSkuUrlResponse> GetInAppSkuUrlWithOptionsAsync(GetInAppSkuUrlRequest request, GetInAppSkuUrlHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackPage))
            {
                body["callbackPage"] = request.CallbackPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendParam))
            {
                body["extendParam"] = request.ExtendParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GoodsCode))
            {
                body["goodsCode"] = request.GoodsCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ItemCode))
            {
                body["itemCode"] = request.ItemCode;
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
                Action = "GetInAppSkuUrl",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/internals/skuPages/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInAppSkuUrlResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品SKU页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppSkuUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInAppSkuUrlResponse
        /// </returns>
        public GetInAppSkuUrlResponse GetInAppSkuUrl(GetInAppSkuUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInAppSkuUrlHeaders headers = new GetInAppSkuUrlHeaders();
            return GetInAppSkuUrlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取内购商品SKU页面地址</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInAppSkuUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInAppSkuUrlResponse
        /// </returns>
        public async Task<GetInAppSkuUrlResponse> GetInAppSkuUrlAsync(GetInAppSkuUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInAppSkuUrlHeaders headers = new GetInAppSkuUrlHeaders();
            return await GetInAppSkuUrlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取个人体验相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPersonalExperienceInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPersonalExperienceInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPersonalExperienceInfoResponse
        /// </returns>
        public GetPersonalExperienceInfoResponse GetPersonalExperienceInfoWithOptions(GetPersonalExperienceInfoRequest request, GetPersonalExperienceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetPersonalExperienceInfo",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/personalExperiences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonalExperienceInfoResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取个人体验相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPersonalExperienceInfoRequest
        /// </param>
        /// <param name="headers">
        /// GetPersonalExperienceInfoHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPersonalExperienceInfoResponse
        /// </returns>
        public async Task<GetPersonalExperienceInfoResponse> GetPersonalExperienceInfoWithOptionsAsync(GetPersonalExperienceInfoRequest request, GetPersonalExperienceInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetPersonalExperienceInfo",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/personalExperiences",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPersonalExperienceInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取个人体验相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPersonalExperienceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPersonalExperienceInfoResponse
        /// </returns>
        public GetPersonalExperienceInfoResponse GetPersonalExperienceInfo(GetPersonalExperienceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
            return GetPersonalExperienceInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取个人体验相关信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPersonalExperienceInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPersonalExperienceInfoResponse
        /// </returns>
        public async Task<GetPersonalExperienceInfoResponse> GetPersonalExperienceInfoAsync(GetPersonalExperienceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
            return await GetPersonalExperienceInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用市场订单查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryMarketOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMarketOrderResponse
        /// </returns>
        public QueryMarketOrderResponse QueryMarketOrderWithOptions(string orderId, QueryMarketOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMarketOrder",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/orders/" + orderId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMarketOrderResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用市场订单查询</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// QueryMarketOrderHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMarketOrderResponse
        /// </returns>
        public async Task<QueryMarketOrderResponse> QueryMarketOrderWithOptionsAsync(string orderId, QueryMarketOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMarketOrder",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/orders/" + orderId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMarketOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用市场订单查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryMarketOrderResponse
        /// </returns>
        public QueryMarketOrderResponse QueryMarketOrder(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
            return QueryMarketOrderWithOptions(orderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>应用市场订单查询</para>
        /// </summary>
        /// 
        /// <returns>
        /// QueryMarketOrderResponse
        /// </returns>
        public async Task<QueryMarketOrderResponse> QueryMarketOrderAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
            return await QueryMarketOrderWithOptionsAsync(orderId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app内用户操作任务同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTaskReportRequest
        /// </param>
        /// <param name="headers">
        /// UserTaskReportHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UserTaskReportResponse
        /// </returns>
        public UserTaskReportResponse UserTaskReportWithOptions(UserTaskReportRequest request, UserTaskReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                body["bizNo"] = request.BizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateDate))
            {
                body["operateDate"] = request.OperateDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTag))
            {
                body["taskTag"] = request.TaskTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
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
                Action = "UserTaskReport",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UserTaskReportResponse>(Execute(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app内用户操作任务同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTaskReportRequest
        /// </param>
        /// <param name="headers">
        /// UserTaskReportHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UserTaskReportResponse
        /// </returns>
        public async Task<UserTaskReportResponse> UserTaskReportWithOptionsAsync(UserTaskReportRequest request, UserTaskReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizNo))
            {
                body["bizNo"] = request.BizNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperateDate))
            {
                body["operateDate"] = request.OperateDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskTag))
            {
                body["taskTag"] = request.TaskTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Userid))
            {
                body["userid"] = request.Userid;
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
                Action = "UserTaskReport",
                Version = "appMarket_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/appMarket/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "boolean",
            };
            return TeaModel.ToObject<UserTaskReportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app内用户操作任务同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTaskReportRequest
        /// </param>
        /// 
        /// <returns>
        /// UserTaskReportResponse
        /// </returns>
        public UserTaskReportResponse UserTaskReport(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return UserTaskReportWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>app内用户操作任务同步</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UserTaskReportRequest
        /// </param>
        /// 
        /// <returns>
        /// UserTaskReportResponse
        /// </returns>
        public async Task<UserTaskReportResponse> UserTaskReportAsync(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return await UserTaskReportWithOptionsAsync(request, headers, runtime);
        }

    }
}
