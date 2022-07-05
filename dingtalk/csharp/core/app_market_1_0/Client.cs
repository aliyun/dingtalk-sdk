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
            this._endpointRule = "";
            if (AlibabaCloud.TeaUtil.Common.Empty(_endpoint))
            {
                this._endpoint = "api.dingtalk.com";
            }
        }


        public CreateAppGoodsServiceConversationResponse CreateAppGoodsServiceConversation(CreateAppGoodsServiceConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
            return CreateAppGoodsServiceConversationWithOptions(request, headers, runtime);
        }

        public async Task<CreateAppGoodsServiceConversationResponse> CreateAppGoodsServiceConversationAsync(CreateAppGoodsServiceConversationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateAppGoodsServiceConversationHeaders headers = new CreateAppGoodsServiceConversationHeaders();
            return await CreateAppGoodsServiceConversationWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<CreateAppGoodsServiceConversationResponse>(DoROARequest("CreateAppGoodsServiceConversation", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/orders/serviceGroups", "json", req, runtime));
        }

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
            return TeaModel.ToObject<CreateAppGoodsServiceConversationResponse>(await DoROARequestAsync("CreateAppGoodsServiceConversation", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/orders/serviceGroups", "json", req, runtime));
        }

        public GetCoolAppAccessStatusResponse GetCoolAppAccessStatus(GetCoolAppAccessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCoolAppAccessStatusHeaders headers = new GetCoolAppAccessStatusHeaders();
            return GetCoolAppAccessStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetCoolAppAccessStatusResponse> GetCoolAppAccessStatusAsync(GetCoolAppAccessStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetCoolAppAccessStatusHeaders headers = new GetCoolAppAccessStatusHeaders();
            return await GetCoolAppAccessStatusWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetCoolAppAccessStatusResponse>(DoROARequest("GetCoolAppAccessStatus", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/coolApps/accessions/statuses/query", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetCoolAppAccessStatusResponse>(await DoROARequestAsync("GetCoolAppAccessStatus", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/coolApps/accessions/statuses/query", "json", req, runtime));
        }

        public GetPersonalExperienceInfoResponse GetPersonalExperienceInfo(GetPersonalExperienceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
            return GetPersonalExperienceInfoWithOptions(request, headers, runtime);
        }

        public async Task<GetPersonalExperienceInfoResponse> GetPersonalExperienceInfoAsync(GetPersonalExperienceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPersonalExperienceInfoHeaders headers = new GetPersonalExperienceInfoHeaders();
            return await GetPersonalExperienceInfoWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<GetPersonalExperienceInfoResponse>(DoROARequest("GetPersonalExperienceInfo", "appMarket_1.0", "HTTP", "GET", "AK", "/v1.0/appMarket/personalExperiences", "json", req, runtime));
        }

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
            return TeaModel.ToObject<GetPersonalExperienceInfoResponse>(await DoROARequestAsync("GetPersonalExperienceInfo", "appMarket_1.0", "HTTP", "GET", "AK", "/v1.0/appMarket/personalExperiences", "json", req, runtime));
        }

        public QueryMarketOrderResponse QueryMarketOrder(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
            return QueryMarketOrderWithOptions(orderId, headers, runtime);
        }

        public async Task<QueryMarketOrderResponse> QueryMarketOrderAsync(string orderId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMarketOrderHeaders headers = new QueryMarketOrderHeaders();
            return await QueryMarketOrderWithOptionsAsync(orderId, headers, runtime);
        }

        public QueryMarketOrderResponse QueryMarketOrderWithOptions(string orderId, QueryMarketOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            orderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(orderId);
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
            return TeaModel.ToObject<QueryMarketOrderResponse>(DoROARequest("QueryMarketOrder", "appMarket_1.0", "HTTP", "GET", "AK", "/v1.0/appMarket/orders/" + orderId, "json", req, runtime));
        }

        public async Task<QueryMarketOrderResponse> QueryMarketOrderWithOptionsAsync(string orderId, QueryMarketOrderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            orderId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(orderId);
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
            return TeaModel.ToObject<QueryMarketOrderResponse>(await DoROARequestAsync("QueryMarketOrder", "appMarket_1.0", "HTTP", "GET", "AK", "/v1.0/appMarket/orders/" + orderId, "json", req, runtime));
        }

        public UserTaskReportResponse UserTaskReport(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return UserTaskReportWithOptions(request, headers, runtime);
        }

        public async Task<UserTaskReportResponse> UserTaskReportAsync(UserTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UserTaskReportHeaders headers = new UserTaskReportHeaders();
            return await UserTaskReportWithOptionsAsync(request, headers, runtime);
        }

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
            return TeaModel.ToObject<UserTaskReportResponse>(DoROARequest("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/tasks", "boolean", req, runtime));
        }

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
            return TeaModel.ToObject<UserTaskReportResponse>(await DoROARequestAsync("UserTaskReport", "appMarket_1.0", "HTTP", "POST", "AK", "/v1.0/appMarket/tasks", "boolean", req, runtime));
        }

    }
}
