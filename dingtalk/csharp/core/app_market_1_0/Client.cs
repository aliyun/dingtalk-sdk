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


        /**
         * @summary 创建应用商品服务群
         *
         * @param request CreateAppGoodsServiceConversationRequest
         * @param headers CreateAppGoodsServiceConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppGoodsServiceConversationResponse
         */
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

        /**
         * @summary 创建应用商品服务群
         *
         * @param request CreateAppGoodsServiceConversationRequest
         * @param headers CreateAppGoodsServiceConversationHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppGoodsServiceConversationResponse
         */
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

        /**
         * @summary 创建应用商品服务群
         *
         * @param request CreateAppGoodsServiceConversationRequest
         * @return CreateAppGoodsServiceConversationResponse
         */
        public CreateAppGoodsServiceConversationResponse CreateAppGoodsServiceConversation(CreateAppGoodsServiceConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
            return CreateAppGoodsServiceConversationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建应用商品服务群
         *
         * @param request CreateAppGoodsServiceConversationRequest
         * @return CreateAppGoodsServiceConversationResponse
         */
        public async Task<CreateAppGoodsServiceConversationResponse> CreateAppGoodsServiceConversationAsync(CreateAppGoodsServiceConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
            return await CreateAppGoodsServiceConversationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取酷应用访问状态
         *
         * @param request GetCoolAppAccessStatusRequest
         * @param headers GetCoolAppAccessStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCoolAppAccessStatusResponse
         */
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

        /**
         * @summary 获取酷应用访问状态
         *
         * @param request GetCoolAppAccessStatusRequest
         * @param headers GetCoolAppAccessStatusHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCoolAppAccessStatusResponse
         */
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

        /**
         * @summary 获取酷应用访问状态
         *
         * @param request GetCoolAppAccessStatusRequest
         * @return GetCoolAppAccessStatusResponse
         */
        public GetCoolAppAccessStatusResponse GetCoolAppAccessStatus(GetCoolAppAccessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCoolAppAccessStatusHeaders headers = new GetCoolAppAccessStatusHeaders();
            return GetCoolAppAccessStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取酷应用访问状态
         *
         * @param request GetCoolAppAccessStatusRequest
         * @return GetCoolAppAccessStatusResponse
         */
        public async Task<GetCoolAppAccessStatusResponse> GetCoolAppAccessStatusAsync(GetCoolAppAccessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCoolAppAccessStatusHeaders headers = new GetCoolAppAccessStatusHeaders();
            return await GetCoolAppAccessStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取内购商品SKU页面地址
         *
         * @param request GetInAppSkuUrlRequest
         * @param headers GetInAppSkuUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInAppSkuUrlResponse
         */
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

        /**
         * @summary 获取内购商品SKU页面地址
         *
         * @param request GetInAppSkuUrlRequest
         * @param headers GetInAppSkuUrlHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInAppSkuUrlResponse
         */
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

        /**
         * @summary 获取内购商品SKU页面地址
         *
         * @param request GetInAppSkuUrlRequest
         * @return GetInAppSkuUrlResponse
         */
        public GetInAppSkuUrlResponse GetInAppSkuUrl(GetInAppSkuUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInAppSkuUrlHeaders headers = new GetInAppSkuUrlHeaders();
            return GetInAppSkuUrlWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取内购商品SKU页面地址
         *
         * @param request GetInAppSkuUrlRequest
         * @return GetInAppSkuUrlResponse
         */
        public async Task<GetInAppSkuUrlResponse> GetInAppSkuUrlAsync(GetInAppSkuUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetInAppSkuUrlHeaders headers = new GetInAppSkuUrlHeaders();
            return await GetInAppSkuUrlWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取个人体验相关信息
         *
         * @param request GetPersonalExperienceInfoRequest
         * @param headers GetPersonalExperienceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonalExperienceInfoResponse
         */
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

        /**
         * @summary 获取个人体验相关信息
         *
         * @param request GetPersonalExperienceInfoRequest
         * @param headers GetPersonalExperienceInfoHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPersonalExperienceInfoResponse
         */
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

        /**
         * @summary 获取个人体验相关信息
         *
         * @param request GetPersonalExperienceInfoRequest
         * @return GetPersonalExperienceInfoResponse
         */
        public GetPersonalExperienceInfoResponse GetPersonalExperienceInfo(GetPersonalExperienceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
            return GetPersonalExperienceInfoWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取个人体验相关信息
         *
         * @param request GetPersonalExperienceInfoRequest
         * @return GetPersonalExperienceInfoResponse
         */
        public async Task<GetPersonalExperienceInfoResponse> GetPersonalExperienceInfoAsync(GetPersonalExperienceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
            return await GetPersonalExperienceInfoWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 应用市场订单查询
         *
         * @param headers QueryMarketOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMarketOrderResponse
         */
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

        /**
         * @summary 应用市场订单查询
         *
         * @param headers QueryMarketOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMarketOrderResponse
         */
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

        /**
         * @summary 应用市场订单查询
         *
         * @return QueryMarketOrderResponse
         */
        public QueryMarketOrderResponse QueryMarketOrder(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
            return QueryMarketOrderWithOptions(orderId, headers, runtime);
        }

        /**
         * @summary 应用市场订单查询
         *
         * @return QueryMarketOrderResponse
         */
        public async Task<QueryMarketOrderResponse> QueryMarketOrderAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
            return await QueryMarketOrderWithOptionsAsync(orderId, headers, runtime);
        }

        /**
         * @summary app内用户操作任务同步
         *
         * @param request UserTaskReportRequest
         * @param headers UserTaskReportHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UserTaskReportResponse
         */
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

        /**
         * @summary app内用户操作任务同步
         *
         * @param request UserTaskReportRequest
         * @param headers UserTaskReportHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return UserTaskReportResponse
         */
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

        /**
         * @summary app内用户操作任务同步
         *
         * @param request UserTaskReportRequest
         * @return UserTaskReportResponse
         */
        public UserTaskReportResponse UserTaskReport(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return UserTaskReportWithOptions(request, headers, runtime);
        }

        /**
         * @summary app内用户操作任务同步
         *
         * @param request UserTaskReportRequest
         * @return UserTaskReportResponse
         */
        public async Task<UserTaskReportResponse> UserTaskReportAsync(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return await UserTaskReportWithOptionsAsync(request, headers, runtime);
        }

    }
}
