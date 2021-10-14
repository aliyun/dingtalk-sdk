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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public CheckOpportunityResultResponse CheckOpportunityResult(CheckOpportunityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckOpportunityResultHeaders headers = new CheckOpportunityResultHeaders();
            return CheckOpportunityResultWithOptions(request, headers, runtime);
        }

        public async Task<CheckOpportunityResultResponse> CheckOpportunityResultAsync(CheckOpportunityResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckOpportunityResultHeaders headers = new CheckOpportunityResultHeaders();
            return await CheckOpportunityResultWithOptionsAsync(request, headers, runtime);
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CheckOpportunityResultResponse>(DoROARequest("CheckOpportunityResult", "trade_1.0", "HTTP", "GET", "AK", "/v1.0/trade/opportunity/check", "json", req, runtime));
        }

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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<CheckOpportunityResultResponse>(await DoROARequestAsync("CheckOpportunityResult", "trade_1.0", "HTTP", "GET", "AK", "/v1.0/trade/opportunity/check", "json", req, runtime));
        }

        public CreateOpportunityResponse CreateOpportunity(CreateOpportunityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOpportunityHeaders headers = new CreateOpportunityHeaders();
            return CreateOpportunityWithOptions(request, headers, runtime);
        }

        public async Task<CreateOpportunityResponse> CreateOpportunityAsync(CreateOpportunityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateOpportunityHeaders headers = new CreateOpportunityHeaders();
            return await CreateOpportunityWithOptionsAsync(request, headers, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateOpportunityResponse>(DoROARequest("CreateOpportunity", "trade_1.0", "HTTP", "POST", "AK", "/v1.0/trade/opportunities", "none", req, runtime));
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateOpportunityResponse>(await DoROARequestAsync("CreateOpportunity", "trade_1.0", "HTTP", "POST", "AK", "/v1.0/trade/opportunities", "none", req, runtime));
        }

        public QueryTradeOrderResponse QueryTradeOrder(QueryTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTradeOrderHeaders headers = new QueryTradeOrderHeaders();
            return QueryTradeOrderWithOptions(request, headers, runtime);
        }

        public async Task<QueryTradeOrderResponse> QueryTradeOrderAsync(QueryTradeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryTradeOrderHeaders headers = new QueryTradeOrderHeaders();
            return await QueryTradeOrderWithOptionsAsync(request, headers, runtime);
        }

        public QueryTradeOrderResponse QueryTradeOrderWithOptions(QueryTradeOrderRequest request, QueryTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryTradeOrderResponse>(DoROARequest("QueryTradeOrder", "trade_1.0", "HTTP", "POST", "AK", "/v1.0/trade/orders/query", "json", req, runtime));
        }

        public async Task<QueryTradeOrderResponse> QueryTradeOrderWithOptionsAsync(QueryTradeOrderRequest request, QueryTradeOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingIsvOrgId))
            {
                body["dingIsvOrgId"] = request.DingIsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingSuiteKey))
            {
                body["dingSuiteKey"] = request.DingSuiteKey;
            }
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
                realHeaders["x-acs-dingtalk-access-token"] = headers.XAcsDingtalkAccessToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<QueryTradeOrderResponse>(await DoROARequestAsync("QueryTradeOrder", "trade_1.0", "HTTP", "POST", "AK", "/v1.0/trade/orders/query", "json", req, runtime));
        }

    }
}
