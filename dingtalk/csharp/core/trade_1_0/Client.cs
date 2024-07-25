// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalktrade_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalktrade_1_0
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
         * @summary isv检查商机创建是否符合预期
         *
         * @param request CheckOpportunityResultRequest
         * @param headers CheckOpportunityResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckOpportunityResultResponse
         */
        public CheckOpportunityResultResponse CheckOpportunityResultWithOptions(CheckOpportunityResultRequest request, CheckOpportunityResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongToPhoneNum))
            {
                query["belongToPhoneNum"] = request.BelongToPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhoneNum))
            {
                query["contactPhoneNum"] = request.ContactPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketCode))
            {
                query["marketCode"] = request.MarketCode;
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
                Action = "CheckOpportunityResult",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/opportunity/check",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckOpportunityResultResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary isv检查商机创建是否符合预期
         *
         * @param request CheckOpportunityResultRequest
         * @param headers CheckOpportunityResultHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckOpportunityResultResponse
         */
        public async Task<CheckOpportunityResultResponse> CheckOpportunityResultWithOptionsAsync(CheckOpportunityResultRequest request, CheckOpportunityResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongToPhoneNum))
            {
                query["belongToPhoneNum"] = request.BelongToPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhoneNum))
            {
                query["contactPhoneNum"] = request.ContactPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                query["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketCode))
            {
                query["marketCode"] = request.MarketCode;
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
                Action = "CheckOpportunityResult",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/opportunity/check",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckOpportunityResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary isv检查商机创建是否符合预期
         *
         * @param request CheckOpportunityResultRequest
         * @return CheckOpportunityResultResponse
         */
        public CheckOpportunityResultResponse CheckOpportunityResult(CheckOpportunityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckOpportunityResultHeaders headers = new CheckOpportunityResultHeaders();
            return CheckOpportunityResultWithOptions(request, headers, runtime);
        }

        /**
         * @summary isv检查商机创建是否符合预期
         *
         * @param request CheckOpportunityResultRequest
         * @return CheckOpportunityResultResponse
         */
        public async Task<CheckOpportunityResultResponse> CheckOpportunityResultAsync(CheckOpportunityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckOpportunityResultHeaders headers = new CheckOpportunityResultHeaders();
            return await CheckOpportunityResultWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建小记
         *
         * @param request CreateNoteForIsvRequest
         * @param headers CreateNoteForIsvHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNoteForIsvResponse
         */
        public CreateNoteForIsvResponse CreateNoteForIsvWithOptions(CreateNoteForIsvRequest request, CreateNoteForIsvHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["contactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhoneNum))
            {
                body["contactPhoneNum"] = request.ContactPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTitle))
            {
                body["contactTitle"] = request.ContactTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputPhoneNum))
            {
                body["inputPhoneNum"] = request.InputPhoneNum;
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
                Action = "CreateNoteForIsv",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/notes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNoteForIsvResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建小记
         *
         * @param request CreateNoteForIsvRequest
         * @param headers CreateNoteForIsvHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNoteForIsvResponse
         */
        public async Task<CreateNoteForIsvResponse> CreateNoteForIsvWithOptionsAsync(CreateNoteForIsvRequest request, CreateNoteForIsvHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactName))
            {
                body["contactName"] = request.ContactName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhoneNum))
            {
                body["contactPhoneNum"] = request.ContactPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactTitle))
            {
                body["contactTitle"] = request.ContactTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputPhoneNum))
            {
                body["inputPhoneNum"] = request.InputPhoneNum;
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
                Action = "CreateNoteForIsv",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/notes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNoteForIsvResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建小记
         *
         * @param request CreateNoteForIsvRequest
         * @return CreateNoteForIsvResponse
         */
        public CreateNoteForIsvResponse CreateNoteForIsv(CreateNoteForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateNoteForIsvHeaders headers = new CreateNoteForIsvHeaders();
            return CreateNoteForIsvWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建小记
         *
         * @param request CreateNoteForIsvRequest
         * @return CreateNoteForIsvResponse
         */
        public async Task<CreateNoteForIsvResponse> CreateNoteForIsvAsync(CreateNoteForIsvRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateNoteForIsvHeaders headers = new CreateNoteForIsvHeaders();
            return await CreateNoteForIsvWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary isv创建商机
         *
         * @param request CreateOpportunityRequest
         * @param headers CreateOpportunityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOpportunityResponse
         */
        public CreateOpportunityResponse CreateOpportunityWithOptions(CreateOpportunityRequest request, CreateOpportunityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongToPhoneNum))
            {
                body["belongToPhoneNum"] = request.BelongToPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhoneNum))
            {
                body["contactPhoneNum"] = request.ContactPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketCode))
            {
                body["marketCode"] = request.MarketCode;
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
                Action = "CreateOpportunity",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/opportunities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpportunityResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary isv创建商机
         *
         * @param request CreateOpportunityRequest
         * @param headers CreateOpportunityHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOpportunityResponse
         */
        public async Task<CreateOpportunityResponse> CreateOpportunityWithOptionsAsync(CreateOpportunityRequest request, CreateOpportunityHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongToPhoneNum))
            {
                body["belongToPhoneNum"] = request.BelongToPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactPhoneNum))
            {
                body["contactPhoneNum"] = request.ContactPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MarketCode))
            {
                body["marketCode"] = request.MarketCode;
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
                Action = "CreateOpportunity",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/opportunities",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpportunityResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary isv创建商机
         *
         * @param request CreateOpportunityRequest
         * @return CreateOpportunityResponse
         */
        public CreateOpportunityResponse CreateOpportunity(CreateOpportunityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOpportunityHeaders headers = new CreateOpportunityHeaders();
            return CreateOpportunityWithOptions(request, headers, runtime);
        }

        /**
         * @summary isv创建商机
         *
         * @param request CreateOpportunityRequest
         * @return CreateOpportunityResponse
         */
        public async Task<CreateOpportunityResponse> CreateOpportunityAsync(CreateOpportunityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOpportunityHeaders headers = new CreateOpportunityHeaders();
            return await CreateOpportunityWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询订单信息
         *
         * @param request QueryTradeOrderRequest
         * @param headers QueryTradeOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTradeOrderResponse
         */
        public QueryTradeOrderResponse QueryTradeOrderWithOptions(QueryTradeOrderRequest request, QueryTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderId))
            {
                body["outerOrderId"] = request.OuterOrderId;
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
                Action = "QueryTradeOrder",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/orders/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeOrderResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询订单信息
         *
         * @param request QueryTradeOrderRequest
         * @param headers QueryTradeOrderHeaders
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryTradeOrderResponse
         */
        public async Task<QueryTradeOrderResponse> QueryTradeOrderWithOptionsAsync(QueryTradeOrderRequest request, QueryTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                body["orderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OuterOrderId))
            {
                body["outerOrderId"] = request.OuterOrderId;
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
                Action = "QueryTradeOrder",
                Version = "trade_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/trade/orders/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTradeOrderResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询订单信息
         *
         * @param request QueryTradeOrderRequest
         * @return QueryTradeOrderResponse
         */
        public QueryTradeOrderResponse QueryTradeOrder(QueryTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTradeOrderHeaders headers = new QueryTradeOrderHeaders();
            return QueryTradeOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询订单信息
         *
         * @param request QueryTradeOrderRequest
         * @return QueryTradeOrderResponse
         */
        public async Task<QueryTradeOrderResponse> QueryTradeOrderAsync(QueryTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTradeOrderHeaders headers = new QueryTradeOrderHeaders();
            return await QueryTradeOrderWithOptionsAsync(request, headers, runtime);
        }

    }
}
