// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalkindustry_1_0.Models;

namespace AlibabaCloud.SDK.Dingtalkindustry_1_0
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


        public BusinessMatchResponse BusinessMatchWithOptions(BusinessMatchRequest request, BusinessMatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                body["businessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corpName"] = request.CorpName;
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
                Action = "BusinessMatch",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/me/businesses/matching",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BusinessMatchResponse>(Execute(params_, req, runtime));
        }

        public async Task<BusinessMatchResponse> BusinessMatchWithOptionsAsync(BusinessMatchRequest request, BusinessMatchHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessInfo))
            {
                body["businessInfo"] = request.BusinessInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpName))
            {
                body["corpName"] = request.CorpName;
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
                Action = "BusinessMatch",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/me/businesses/matching",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BusinessMatchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BusinessMatchResponse BusinessMatch(BusinessMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchHeaders headers = new BusinessMatchHeaders();
            return BusinessMatchWithOptions(request, headers, runtime);
        }

        public async Task<BusinessMatchResponse> BusinessMatchAsync(BusinessMatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchHeaders headers = new BusinessMatchHeaders();
            return await BusinessMatchWithOptionsAsync(request, headers, runtime);
        }

        public BusinessMatchResultResponse BusinessMatchResultWithOptions(BusinessMatchResultRequest request, BusinessMatchResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
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
                Action = "BusinessMatchResult",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/me/businesses/matchingResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BusinessMatchResultResponse>(Execute(params_, req, runtime));
        }

        public async Task<BusinessMatchResultResponse> BusinessMatchResultWithOptionsAsync(BusinessMatchResultRequest request, BusinessMatchResultHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
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
                Action = "BusinessMatchResult",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/me/businesses/matchingResults",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<BusinessMatchResultResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public BusinessMatchResultResponse BusinessMatchResult(BusinessMatchResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchResultHeaders headers = new BusinessMatchResultHeaders();
            return BusinessMatchResultWithOptions(request, headers, runtime);
        }

        public async Task<BusinessMatchResultResponse> BusinessMatchResultAsync(BusinessMatchResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            BusinessMatchResultHeaders headers = new BusinessMatchResultHeaders();
            return await BusinessMatchResultWithOptionsAsync(request, headers, runtime);
        }

        public CampusAddRenterMemberResponse CampusAddRenterMemberWithOptions(CampusAddRenterMemberRequest request, CampusAddRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                body["renterId"] = request.RenterId;
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
                Action = "CampusAddRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusAddRenterMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusAddRenterMemberResponse> CampusAddRenterMemberWithOptionsAsync(CampusAddRenterMemberRequest request, CampusAddRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                body["renterId"] = request.RenterId;
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
                Action = "CampusAddRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusAddRenterMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusAddRenterMemberResponse CampusAddRenterMember(CampusAddRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusAddRenterMemberHeaders headers = new CampusAddRenterMemberHeaders();
            return CampusAddRenterMemberWithOptions(request, headers, runtime);
        }

        public async Task<CampusAddRenterMemberResponse> CampusAddRenterMemberAsync(CampusAddRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusAddRenterMemberHeaders headers = new CampusAddRenterMemberHeaders();
            return await CampusAddRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        public CampusCreateCampusResponse CampusCreateCampusWithOptions(CampusCreateCampusRequest request, CampusCreateCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                body["area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongProjectGroupId))
            {
                body["belongProjectGroupId"] = request.BelongProjectGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusName))
            {
                body["campusName"] = request.CampusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                body["capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityId))
            {
                body["cityId"] = request.CityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                body["country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyId))
            {
                body["countyId"] = request.CountyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderEndTime))
            {
                body["orderEndTime"] = request.OrderEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInfo))
            {
                body["orderInfo"] = request.OrderInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStartTime))
            {
                body["orderStartTime"] = request.OrderStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvId))
            {
                body["provId"] = request.ProvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
                Action = "CampusCreateCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusCreateCampusResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusCreateCampusResponse> CampusCreateCampusWithOptionsAsync(CampusCreateCampusRequest request, CampusCreateCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                body["area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongProjectGroupId))
            {
                body["belongProjectGroupId"] = request.BelongProjectGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusName))
            {
                body["campusName"] = request.CampusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                body["capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityId))
            {
                body["cityId"] = request.CityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                body["country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyId))
            {
                body["countyId"] = request.CountyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatorUnionId))
            {
                body["creatorUnionId"] = request.CreatorUnionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Location))
            {
                body["location"] = request.Location;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderEndTime))
            {
                body["orderEndTime"] = request.OrderEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInfo))
            {
                body["orderInfo"] = request.OrderInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStartTime))
            {
                body["orderStartTime"] = request.OrderStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvId))
            {
                body["provId"] = request.ProvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
                Action = "CampusCreateCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusCreateCampusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusCreateCampusResponse CampusCreateCampus(CampusCreateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusHeaders headers = new CampusCreateCampusHeaders();
            return CampusCreateCampusWithOptions(request, headers, runtime);
        }

        public async Task<CampusCreateCampusResponse> CampusCreateCampusAsync(CampusCreateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusHeaders headers = new CampusCreateCampusHeaders();
            return await CampusCreateCampusWithOptionsAsync(request, headers, runtime);
        }

        public CampusCreateCampusGroupResponse CampusCreateCampusGroupWithOptions(CampusCreateCampusGroupRequest request, CampusCreateCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CampusCreateCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusCreateCampusGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusCreateCampusGroupResponse> CampusCreateCampusGroupWithOptionsAsync(CampusCreateCampusGroupRequest request, CampusCreateCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CampusCreateCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusCreateCampusGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusCreateCampusGroupResponse CampusCreateCampusGroup(CampusCreateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusGroupHeaders headers = new CampusCreateCampusGroupHeaders();
            return CampusCreateCampusGroupWithOptions(request, headers, runtime);
        }

        public async Task<CampusCreateCampusGroupResponse> CampusCreateCampusGroupAsync(CampusCreateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateCampusGroupHeaders headers = new CampusCreateCampusGroupHeaders();
            return await CampusCreateCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        public CampusCreateRenterResponse CampusCreateRenterWithOptions(CampusCreateRenterRequest request, CampusCreateRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                body["creditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "CampusCreateRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusCreateRenterResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusCreateRenterResponse> CampusCreateRenterWithOptionsAsync(CampusCreateRenterRequest request, CampusCreateRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                body["creditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "CampusCreateRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusCreateRenterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusCreateRenterResponse CampusCreateRenter(CampusCreateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateRenterHeaders headers = new CampusCreateRenterHeaders();
            return CampusCreateRenterWithOptions(request, headers, runtime);
        }

        public async Task<CampusCreateRenterResponse> CampusCreateRenterAsync(CampusCreateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusCreateRenterHeaders headers = new CampusCreateRenterHeaders();
            return await CampusCreateRenterWithOptionsAsync(request, headers, runtime);
        }

        public CampusDelRenterMemberResponse CampusDelRenterMemberWithOptions(CampusDelRenterMemberRequest request, CampusDelRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "CampusDelRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusDelRenterMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusDelRenterMemberResponse> CampusDelRenterMemberWithOptionsAsync(CampusDelRenterMemberRequest request, CampusDelRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "CampusDelRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusDelRenterMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusDelRenterMemberResponse CampusDelRenterMember(CampusDelRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDelRenterMemberHeaders headers = new CampusDelRenterMemberHeaders();
            return CampusDelRenterMemberWithOptions(request, headers, runtime);
        }

        public async Task<CampusDelRenterMemberResponse> CampusDelRenterMemberAsync(CampusDelRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDelRenterMemberHeaders headers = new CampusDelRenterMemberHeaders();
            return await CampusDelRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        public CampusDeleteCampusGroupResponse CampusDeleteCampusGroupWithOptions(CampusDeleteCampusGroupRequest request, CampusDeleteCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusProjectGroupId))
            {
                query["campusProjectGroupId"] = request.CampusProjectGroupId;
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
                Action = "CampusDeleteCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusDeleteCampusGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusDeleteCampusGroupResponse> CampusDeleteCampusGroupWithOptionsAsync(CampusDeleteCampusGroupRequest request, CampusDeleteCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusProjectGroupId))
            {
                query["campusProjectGroupId"] = request.CampusProjectGroupId;
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
                Action = "CampusDeleteCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusDeleteCampusGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusDeleteCampusGroupResponse CampusDeleteCampusGroup(CampusDeleteCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteCampusGroupHeaders headers = new CampusDeleteCampusGroupHeaders();
            return CampusDeleteCampusGroupWithOptions(request, headers, runtime);
        }

        public async Task<CampusDeleteCampusGroupResponse> CampusDeleteCampusGroupAsync(CampusDeleteCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteCampusGroupHeaders headers = new CampusDeleteCampusGroupHeaders();
            return await CampusDeleteCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        public CampusDeleteRenterResponse CampusDeleteRenterWithOptions(CampusDeleteRenterRequest request, CampusDeleteRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
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
                Action = "CampusDeleteRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<CampusDeleteRenterResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusDeleteRenterResponse> CampusDeleteRenterWithOptionsAsync(CampusDeleteRenterRequest request, CampusDeleteRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
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
                Action = "CampusDeleteRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "none",
            };
            return TeaModel.ToObject<CampusDeleteRenterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusDeleteRenterResponse CampusDeleteRenter(CampusDeleteRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteRenterHeaders headers = new CampusDeleteRenterHeaders();
            return CampusDeleteRenterWithOptions(request, headers, runtime);
        }

        public async Task<CampusDeleteRenterResponse> CampusDeleteRenterAsync(CampusDeleteRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusDeleteRenterHeaders headers = new CampusDeleteRenterHeaders();
            return await CampusDeleteRenterWithOptionsAsync(request, headers, runtime);
        }

        public CampusGetCampusResponse CampusGetCampusWithOptions(CampusGetCampusRequest request, CampusGetCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusDeptId))
            {
                query["campusDeptId"] = request.CampusDeptId;
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
                Action = "CampusGetCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projectInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetCampusResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusGetCampusResponse> CampusGetCampusWithOptionsAsync(CampusGetCampusRequest request, CampusGetCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusDeptId))
            {
                query["campusDeptId"] = request.CampusDeptId;
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
                Action = "CampusGetCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projectInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetCampusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusGetCampusResponse CampusGetCampus(CampusGetCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusHeaders headers = new CampusGetCampusHeaders();
            return CampusGetCampusWithOptions(request, headers, runtime);
        }

        public async Task<CampusGetCampusResponse> CampusGetCampusAsync(CampusGetCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusHeaders headers = new CampusGetCampusHeaders();
            return await CampusGetCampusWithOptionsAsync(request, headers, runtime);
        }

        public CampusGetCampusGroupResponse CampusGetCampusGroupWithOptions(CampusGetCampusGroupRequest request, CampusGetCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
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
                Action = "CampusGetCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetCampusGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusGetCampusGroupResponse> CampusGetCampusGroupWithOptionsAsync(CampusGetCampusGroupRequest request, CampusGetCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
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
                Action = "CampusGetCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetCampusGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusGetCampusGroupResponse CampusGetCampusGroup(CampusGetCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusGroupHeaders headers = new CampusGetCampusGroupHeaders();
            return CampusGetCampusGroupWithOptions(request, headers, runtime);
        }

        public async Task<CampusGetCampusGroupResponse> CampusGetCampusGroupAsync(CampusGetCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetCampusGroupHeaders headers = new CampusGetCampusGroupHeaders();
            return await CampusGetCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        public CampusGetRenterResponse CampusGetRenterWithOptions(CampusGetRenterRequest request, CampusGetRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
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
                Action = "CampusGetRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renterInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetRenterResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusGetRenterResponse> CampusGetRenterWithOptionsAsync(CampusGetRenterRequest request, CampusGetRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
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
                Action = "CampusGetRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renterInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetRenterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusGetRenterResponse CampusGetRenter(CampusGetRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterHeaders headers = new CampusGetRenterHeaders();
            return CampusGetRenterWithOptions(request, headers, runtime);
        }

        public async Task<CampusGetRenterResponse> CampusGetRenterAsync(CampusGetRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterHeaders headers = new CampusGetRenterHeaders();
            return await CampusGetRenterWithOptionsAsync(request, headers, runtime);
        }

        public CampusGetRenterMemberResponse CampusGetRenterMemberWithOptions(CampusGetRenterMemberRequest request, CampusGetRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "CampusGetRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/memberInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetRenterMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusGetRenterMemberResponse> CampusGetRenterMemberWithOptionsAsync(CampusGetRenterMemberRequest request, CampusGetRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
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
                Action = "CampusGetRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/memberInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusGetRenterMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusGetRenterMemberResponse CampusGetRenterMember(CampusGetRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterMemberHeaders headers = new CampusGetRenterMemberHeaders();
            return CampusGetRenterMemberWithOptions(request, headers, runtime);
        }

        public async Task<CampusGetRenterMemberResponse> CampusGetRenterMemberAsync(CampusGetRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusGetRenterMemberHeaders headers = new CampusGetRenterMemberHeaders();
            return await CampusGetRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        public CampusListCampusResponse CampusListCampusWithOptions(CampusListCampusRequest request, CampusListCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeptId))
            {
                query["groupDeptId"] = request.GroupDeptId;
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
                Action = "CampusListCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListCampusResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusListCampusResponse> CampusListCampusWithOptionsAsync(CampusListCampusRequest request, CampusListCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupDeptId))
            {
                query["groupDeptId"] = request.GroupDeptId;
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
                Action = "CampusListCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListCampusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusListCampusResponse CampusListCampus(CampusListCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusHeaders headers = new CampusListCampusHeaders();
            return CampusListCampusWithOptions(request, headers, runtime);
        }

        public async Task<CampusListCampusResponse> CampusListCampusAsync(CampusListCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusHeaders headers = new CampusListCampusHeaders();
            return await CampusListCampusWithOptionsAsync(request, headers, runtime);
        }

        public CampusListCampusGroupResponse CampusListCampusGroupWithOptions(CampusListCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CampusListCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListCampusGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusListCampusGroupResponse> CampusListCampusGroupWithOptionsAsync(CampusListCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CampusListCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListCampusGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusListCampusGroupResponse CampusListCampusGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusGroupHeaders headers = new CampusListCampusGroupHeaders();
            return CampusListCampusGroupWithOptions(headers, runtime);
        }

        public async Task<CampusListCampusGroupResponse> CampusListCampusGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListCampusGroupHeaders headers = new CampusListCampusGroupHeaders();
            return await CampusListCampusGroupWithOptionsAsync(headers, runtime);
        }

        public CampusListRenterResponse CampusListRenterWithOptions(CampusListRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CampusListRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListRenterResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusListRenterResponse> CampusListRenterWithOptionsAsync(CampusListRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CampusListRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListRenterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusListRenterResponse CampusListRenter()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterHeaders headers = new CampusListRenterHeaders();
            return CampusListRenterWithOptions(headers, runtime);
        }

        public async Task<CampusListRenterResponse> CampusListRenterAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterHeaders headers = new CampusListRenterHeaders();
            return await CampusListRenterWithOptionsAsync(headers, runtime);
        }

        public CampusListRenterMembersResponse CampusListRenterMembersWithOptions(CampusListRenterMembersRequest request, CampusListRenterMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
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
                Action = "CampusListRenterMembers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListRenterMembersResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusListRenterMembersResponse> CampusListRenterMembersWithOptionsAsync(CampusListRenterMembersRequest request, CampusListRenterMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                query["renterId"] = request.RenterId;
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
                Action = "CampusListRenterMembers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusListRenterMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusListRenterMembersResponse CampusListRenterMembers(CampusListRenterMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterMembersHeaders headers = new CampusListRenterMembersHeaders();
            return CampusListRenterMembersWithOptions(request, headers, runtime);
        }

        public async Task<CampusListRenterMembersResponse> CampusListRenterMembersAsync(CampusListRenterMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusListRenterMembersHeaders headers = new CampusListRenterMembersHeaders();
            return await CampusListRenterMembersWithOptionsAsync(request, headers, runtime);
        }

        public CampusUpdateCampusResponse CampusUpdateCampusWithOptions(CampusUpdateCampusRequest request, CampusUpdateCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                body["area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongProjectGroupId))
            {
                body["belongProjectGroupId"] = request.BelongProjectGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusDeptId))
            {
                body["campusDeptId"] = request.CampusDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusName))
            {
                body["campusName"] = request.CampusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                body["capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityId))
            {
                body["cityId"] = request.CityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                body["country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyId))
            {
                body["countyId"] = request.CountyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderEndTime))
            {
                body["orderEndTime"] = request.OrderEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInfo))
            {
                body["orderInfo"] = request.OrderInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStartTime))
            {
                body["orderStartTime"] = request.OrderStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvId))
            {
                body["provId"] = request.ProvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
                Action = "CampusUpdateCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateCampusResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusUpdateCampusResponse> CampusUpdateCampusWithOptionsAsync(CampusUpdateCampusRequest request, CampusUpdateCampusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Address))
            {
                body["address"] = request.Address;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Area))
            {
                body["area"] = request.Area;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BelongProjectGroupId))
            {
                body["belongProjectGroupId"] = request.BelongProjectGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusDeptId))
            {
                body["campusDeptId"] = request.CampusDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusName))
            {
                body["campusName"] = request.CampusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Capacity))
            {
                body["capacity"] = request.Capacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CityId))
            {
                body["cityId"] = request.CityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Country))
            {
                body["country"] = request.Country;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CountyId))
            {
                body["countyId"] = request.CountyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderEndTime))
            {
                body["orderEndTime"] = request.OrderEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderInfo))
            {
                body["orderInfo"] = request.OrderInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderStartTime))
            {
                body["orderStartTime"] = request.OrderStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvId))
            {
                body["provId"] = request.ProvId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Telephone))
            {
                body["telephone"] = request.Telephone;
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
                Action = "CampusUpdateCampus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateCampusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusUpdateCampusResponse CampusUpdateCampus(CampusUpdateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusHeaders headers = new CampusUpdateCampusHeaders();
            return CampusUpdateCampusWithOptions(request, headers, runtime);
        }

        public async Task<CampusUpdateCampusResponse> CampusUpdateCampusAsync(CampusUpdateCampusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusHeaders headers = new CampusUpdateCampusHeaders();
            return await CampusUpdateCampusWithOptionsAsync(request, headers, runtime);
        }

        public CampusUpdateCampusGroupResponse CampusUpdateCampusGroupWithOptions(CampusUpdateCampusGroupRequest request, CampusUpdateCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusProjectGroupId))
            {
                body["campusProjectGroupId"] = request.CampusProjectGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CampusUpdateCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateCampusGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusUpdateCampusGroupResponse> CampusUpdateCampusGroupWithOptionsAsync(CampusUpdateCampusGroupRequest request, CampusUpdateCampusGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CampusProjectGroupId))
            {
                body["campusProjectGroupId"] = request.CampusProjectGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CampusUpdateCampusGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/projects/groups",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateCampusGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusUpdateCampusGroupResponse CampusUpdateCampusGroup(CampusUpdateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusGroupHeaders headers = new CampusUpdateCampusGroupHeaders();
            return CampusUpdateCampusGroupWithOptions(request, headers, runtime);
        }

        public async Task<CampusUpdateCampusGroupResponse> CampusUpdateCampusGroupAsync(CampusUpdateCampusGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateCampusGroupHeaders headers = new CampusUpdateCampusGroupHeaders();
            return await CampusUpdateCampusGroupWithOptionsAsync(request, headers, runtime);
        }

        public CampusUpdateRenterResponse CampusUpdateRenterWithOptions(CampusUpdateRenterRequest request, CampusUpdateRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                body["creditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                body["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "CampusUpdateRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateRenterResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusUpdateRenterResponse> CampusUpdateRenterWithOptionsAsync(CampusUpdateRenterRequest request, CampusUpdateRenterHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreditCode))
            {
                body["creditCode"] = request.CreditCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                body["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                body["state"] = request.State;
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
                Action = "CampusUpdateRenter",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateRenterResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusUpdateRenterResponse CampusUpdateRenter(CampusUpdateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterHeaders headers = new CampusUpdateRenterHeaders();
            return CampusUpdateRenterWithOptions(request, headers, runtime);
        }

        public async Task<CampusUpdateRenterResponse> CampusUpdateRenterAsync(CampusUpdateRenterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterHeaders headers = new CampusUpdateRenterHeaders();
            return await CampusUpdateRenterWithOptionsAsync(request, headers, runtime);
        }

        public CampusUpdateRenterMemberResponse CampusUpdateRenterMemberWithOptions(CampusUpdateRenterMemberRequest request, CampusUpdateRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                body["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "CampusUpdateRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateRenterMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<CampusUpdateRenterMemberResponse> CampusUpdateRenterMemberWithOptionsAsync(CampusUpdateRenterMemberRequest request, CampusUpdateRenterMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Extend))
            {
                body["extend"] = request.Extend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenterId))
            {
                body["renterId"] = request.RenterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "CampusUpdateRenterMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/campuses/renters/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CampusUpdateRenterMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CampusUpdateRenterMemberResponse CampusUpdateRenterMember(CampusUpdateRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterMemberHeaders headers = new CampusUpdateRenterMemberHeaders();
            return CampusUpdateRenterMemberWithOptions(request, headers, runtime);
        }

        public async Task<CampusUpdateRenterMemberResponse> CampusUpdateRenterMemberAsync(CampusUpdateRenterMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CampusUpdateRenterMemberHeaders headers = new CampusUpdateRenterMemberHeaders();
            return await CampusUpdateRenterMemberWithOptionsAsync(request, headers, runtime);
        }

        public ChatFormGetDataForApiAccessResponse ChatFormGetDataForApiAccessWithOptions(ChatFormGetDataForApiAccessRequest request, ChatFormGetDataForApiAccessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTalkTraceId))
            {
                query["dingTalkTraceId"] = request.DingTalkTraceId;
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
                Action = "ChatFormGetDataForApiAccess",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatform/datas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatFormGetDataForApiAccessResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatFormGetDataForApiAccessResponse> ChatFormGetDataForApiAccessWithOptionsAsync(ChatFormGetDataForApiAccessRequest request, ChatFormGetDataForApiAccessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingTalkTraceId))
            {
                query["dingTalkTraceId"] = request.DingTalkTraceId;
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
                Action = "ChatFormGetDataForApiAccess",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatform/datas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatFormGetDataForApiAccessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatFormGetDataForApiAccessResponse ChatFormGetDataForApiAccess(ChatFormGetDataForApiAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatFormGetDataForApiAccessHeaders headers = new ChatFormGetDataForApiAccessHeaders();
            return ChatFormGetDataForApiAccessWithOptions(request, headers, runtime);
        }

        public async Task<ChatFormGetDataForApiAccessResponse> ChatFormGetDataForApiAccessAsync(ChatFormGetDataForApiAccessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatFormGetDataForApiAccessHeaders headers = new ChatFormGetDataForApiAccessHeaders();
            return await ChatFormGetDataForApiAccessWithOptionsAsync(request, headers, runtime);
        }

        public ChatMemoAddGeneralFileResponse ChatMemoAddGeneralFileWithOptions(ChatMemoAddGeneralFileRequest request, ChatMemoAddGeneralFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                body["downloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDesc))
            {
                body["fileDesc"] = request.FileDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                body["tagList"] = request.TagList;
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
                Action = "ChatMemoAddGeneralFile",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoAddGeneralFileResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatMemoAddGeneralFileResponse> ChatMemoAddGeneralFileWithOptionsAsync(ChatMemoAddGeneralFileRequest request, ChatMemoAddGeneralFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DownloadUrl))
            {
                body["downloadUrl"] = request.DownloadUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileDesc))
            {
                body["fileDesc"] = request.FileDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                body["fileName"] = request.FileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagList))
            {
                body["tagList"] = request.TagList;
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
                Action = "ChatMemoAddGeneralFile",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/files",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoAddGeneralFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatMemoAddGeneralFileResponse ChatMemoAddGeneralFile(ChatMemoAddGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoAddGeneralFileHeaders headers = new ChatMemoAddGeneralFileHeaders();
            return ChatMemoAddGeneralFileWithOptions(request, headers, runtime);
        }

        public async Task<ChatMemoAddGeneralFileResponse> ChatMemoAddGeneralFileAsync(ChatMemoAddGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoAddGeneralFileHeaders headers = new ChatMemoAddGeneralFileHeaders();
            return await ChatMemoAddGeneralFileWithOptionsAsync(request, headers, runtime);
        }

        public ChatMemoDeleteGeneralFileResponse ChatMemoDeleteGeneralFileWithOptions(ChatMemoDeleteGeneralFileRequest request, ChatMemoDeleteGeneralFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "ChatMemoDeleteGeneralFile",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/files/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoDeleteGeneralFileResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatMemoDeleteGeneralFileResponse> ChatMemoDeleteGeneralFileWithOptionsAsync(ChatMemoDeleteGeneralFileRequest request, ChatMemoDeleteGeneralFileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "ChatMemoDeleteGeneralFile",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/files/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoDeleteGeneralFileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatMemoDeleteGeneralFileResponse ChatMemoDeleteGeneralFile(ChatMemoDeleteGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoDeleteGeneralFileHeaders headers = new ChatMemoDeleteGeneralFileHeaders();
            return ChatMemoDeleteGeneralFileWithOptions(request, headers, runtime);
        }

        public async Task<ChatMemoDeleteGeneralFileResponse> ChatMemoDeleteGeneralFileAsync(ChatMemoDeleteGeneralFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoDeleteGeneralFileHeaders headers = new ChatMemoDeleteGeneralFileHeaders();
            return await ChatMemoDeleteGeneralFileWithOptionsAsync(request, headers, runtime);
        }

        public ChatMemoFaqAddResponse ChatMemoFaqAddWithOptions(ChatMemoFaqAddRequest request, ChatMemoFaqAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answer))
            {
                body["answer"] = request.Answer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Redirection))
            {
                body["redirection"] = request.Redirection;
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
                Action = "ChatMemoFaqAdd",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/faq",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoFaqAddResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatMemoFaqAddResponse> ChatMemoFaqAddWithOptionsAsync(ChatMemoFaqAddRequest request, ChatMemoFaqAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Answer))
            {
                body["answer"] = request.Answer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["bizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Redirection))
            {
                body["redirection"] = request.Redirection;
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
                Action = "ChatMemoFaqAdd",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/faq",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoFaqAddResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatMemoFaqAddResponse ChatMemoFaqAdd(ChatMemoFaqAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqAddHeaders headers = new ChatMemoFaqAddHeaders();
            return ChatMemoFaqAddWithOptions(request, headers, runtime);
        }

        public async Task<ChatMemoFaqAddResponse> ChatMemoFaqAddAsync(ChatMemoFaqAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqAddHeaders headers = new ChatMemoFaqAddHeaders();
            return await ChatMemoFaqAddWithOptionsAsync(request, headers, runtime);
        }

        public ChatMemoFaqDeleteResponse ChatMemoFaqDeleteWithOptions(ChatMemoFaqDeleteRequest request, ChatMemoFaqDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "ChatMemoFaqDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/faq/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoFaqDeleteResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatMemoFaqDeleteResponse> ChatMemoFaqDeleteWithOptionsAsync(ChatMemoFaqDeleteRequest request, ChatMemoFaqDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "ChatMemoFaqDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/faq/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoFaqDeleteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatMemoFaqDeleteResponse ChatMemoFaqDelete(ChatMemoFaqDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqDeleteHeaders headers = new ChatMemoFaqDeleteHeaders();
            return ChatMemoFaqDeleteWithOptions(request, headers, runtime);
        }

        public async Task<ChatMemoFaqDeleteResponse> ChatMemoFaqDeleteAsync(ChatMemoFaqDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqDeleteHeaders headers = new ChatMemoFaqDeleteHeaders();
            return await ChatMemoFaqDeleteWithOptionsAsync(request, headers, runtime);
        }

        public ChatMemoFaqListResponse ChatMemoFaqListWithOptions(ChatMemoFaqListRequest request, ChatMemoFaqListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ChatMemoFaqList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/faq/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoFaqListResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatMemoFaqListResponse> ChatMemoFaqListWithOptionsAsync(ChatMemoFaqListRequest request, ChatMemoFaqListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ChatMemoFaqList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/faq/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoFaqListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatMemoFaqListResponse ChatMemoFaqList(ChatMemoFaqListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqListHeaders headers = new ChatMemoFaqListHeaders();
            return ChatMemoFaqListWithOptions(request, headers, runtime);
        }

        public async Task<ChatMemoFaqListResponse> ChatMemoFaqListAsync(ChatMemoFaqListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoFaqListHeaders headers = new ChatMemoFaqListHeaders();
            return await ChatMemoFaqListWithOptionsAsync(request, headers, runtime);
        }

        public ChatMemoGetFileListResponse ChatMemoGetFileListWithOptions(ChatMemoGetFileListRequest request, ChatMemoGetFileListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ChatMemoGetFileList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/file/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoGetFileListResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatMemoGetFileListResponse> ChatMemoGetFileListWithOptionsAsync(ChatMemoGetFileListRequest request, ChatMemoGetFileListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "ChatMemoGetFileList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/file/lists",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoGetFileListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatMemoGetFileListResponse ChatMemoGetFileList(ChatMemoGetFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileListHeaders headers = new ChatMemoGetFileListHeaders();
            return ChatMemoGetFileListWithOptions(request, headers, runtime);
        }

        public async Task<ChatMemoGetFileListResponse> ChatMemoGetFileListAsync(ChatMemoGetFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileListHeaders headers = new ChatMemoGetFileListHeaders();
            return await ChatMemoGetFileListWithOptionsAsync(request, headers, runtime);
        }

        public ChatMemoGetFileStatusResponse ChatMemoGetFileStatusWithOptions(ChatMemoGetFileStatusRequest request, ChatMemoGetFileStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "ChatMemoGetFileStatus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/files/statuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoGetFileStatusResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChatMemoGetFileStatusResponse> ChatMemoGetFileStatusWithOptionsAsync(ChatMemoGetFileStatusRequest request, ChatMemoGetFileStatusHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                body["datasetId"] = request.DatasetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MediaId))
            {
                body["mediaId"] = request.MediaId;
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
                Action = "ChatMemoGetFileStatus",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/chatmemo/files/statuses/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMemoGetFileStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChatMemoGetFileStatusResponse ChatMemoGetFileStatus(ChatMemoGetFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileStatusHeaders headers = new ChatMemoGetFileStatusHeaders();
            return ChatMemoGetFileStatusWithOptions(request, headers, runtime);
        }

        public async Task<ChatMemoGetFileStatusResponse> ChatMemoGetFileStatusAsync(ChatMemoGetFileStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ChatMemoGetFileStatusHeaders headers = new ChatMemoGetFileStatusHeaders();
            return await ChatMemoGetFileStatusWithOptionsAsync(request, headers, runtime);
        }

        public CollegeActiveCollegeDeptGroupResponse CollegeActiveCollegeDeptGroupWithOptions(CollegeActiveCollegeDeptGroupRequest request, CollegeActiveCollegeDeptGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeActiveCollegeDeptGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeActiveCollegeDeptGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeActiveCollegeDeptGroupResponse> CollegeActiveCollegeDeptGroupWithOptionsAsync(CollegeActiveCollegeDeptGroupRequest request, CollegeActiveCollegeDeptGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeActiveCollegeDeptGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts/groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeActiveCollegeDeptGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeActiveCollegeDeptGroupResponse CollegeActiveCollegeDeptGroup(CollegeActiveCollegeDeptGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeActiveCollegeDeptGroupHeaders headers = new CollegeActiveCollegeDeptGroupHeaders();
            return CollegeActiveCollegeDeptGroupWithOptions(request, headers, runtime);
        }

        public async Task<CollegeActiveCollegeDeptGroupResponse> CollegeActiveCollegeDeptGroupAsync(CollegeActiveCollegeDeptGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeActiveCollegeDeptGroupHeaders headers = new CollegeActiveCollegeDeptGroupHeaders();
            return await CollegeActiveCollegeDeptGroupWithOptionsAsync(request, headers, runtime);
        }

        public CollegeAddCollegeDeptResponse CollegeAddCollegeDeptWithOptions(CollegeAddCollegeDeptRequest request, CollegeAddCollegeDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                query["deptName"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptType))
            {
                query["deptType"] = request.DeptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFactor))
            {
                query["sortFactor"] = request.SortFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "CollegeAddCollegeDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeAddCollegeDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeAddCollegeDeptResponse> CollegeAddCollegeDeptWithOptionsAsync(CollegeAddCollegeDeptRequest request, CollegeAddCollegeDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                query["deptName"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptType))
            {
                query["deptType"] = request.DeptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFactor))
            {
                query["sortFactor"] = request.SortFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "CollegeAddCollegeDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeAddCollegeDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeAddCollegeDeptResponse CollegeAddCollegeDept(CollegeAddCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddCollegeDeptHeaders headers = new CollegeAddCollegeDeptHeaders();
            return CollegeAddCollegeDeptWithOptions(request, headers, runtime);
        }

        public async Task<CollegeAddCollegeDeptResponse> CollegeAddCollegeDeptAsync(CollegeAddCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddCollegeDeptHeaders headers = new CollegeAddCollegeDeptHeaders();
            return await CollegeAddCollegeDeptWithOptionsAsync(request, headers, runtime);
        }

        public CollegeAddManagerResponse CollegeAddManagerWithOptions(CollegeAddManagerRequest request, CollegeAddManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
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
                Action = "CollegeAddManager",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/managers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeAddManagerResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeAddManagerResponse> CollegeAddManagerWithOptionsAsync(CollegeAddManagerRequest request, CollegeAddManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
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
                Action = "CollegeAddManager",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/managers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeAddManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeAddManagerResponse CollegeAddManager(CollegeAddManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddManagerHeaders headers = new CollegeAddManagerHeaders();
            return CollegeAddManagerWithOptions(request, headers, runtime);
        }

        public async Task<CollegeAddManagerResponse> CollegeAddManagerAsync(CollegeAddManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddManagerHeaders headers = new CollegeAddManagerHeaders();
            return await CollegeAddManagerWithOptionsAsync(request, headers, runtime);
        }

        public CollegeAddStudentResponse CollegeAddStudentWithOptions(CollegeAddStudentRequest request, CollegeAddStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpExtension))
            {
                body["empExtension"] = request.EmpExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyId))
            {
                body["identifyId"] = request.IdentifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartYear))
            {
                body["startYear"] = request.StartYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentName))
            {
                body["studentName"] = request.StudentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentNumber))
            {
                body["studentNumber"] = request.StudentNumber;
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
                Action = "CollegeAddStudent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeAddStudentResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeAddStudentResponse> CollegeAddStudentWithOptionsAsync(CollegeAddStudentRequest request, CollegeAddStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpExtension))
            {
                body["empExtension"] = request.EmpExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyId))
            {
                body["identifyId"] = request.IdentifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartYear))
            {
                body["startYear"] = request.StartYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentName))
            {
                body["studentName"] = request.StudentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentNumber))
            {
                body["studentNumber"] = request.StudentNumber;
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
                Action = "CollegeAddStudent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeAddStudentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeAddStudentResponse CollegeAddStudent(CollegeAddStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddStudentHeaders headers = new CollegeAddStudentHeaders();
            return CollegeAddStudentWithOptions(request, headers, runtime);
        }

        public async Task<CollegeAddStudentResponse> CollegeAddStudentAsync(CollegeAddStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeAddStudentHeaders headers = new CollegeAddStudentHeaders();
            return await CollegeAddStudentWithOptionsAsync(request, headers, runtime);
        }

        public CollegeChangeStudentDeptResponse CollegeChangeStudentDeptWithOptions(CollegeChangeStudentDeptRequest request, CollegeChangeStudentDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDeptId))
            {
                query["newDeptId"] = request.NewDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeChangeStudentDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeChangeStudentDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeChangeStudentDeptResponse> CollegeChangeStudentDeptWithOptionsAsync(CollegeChangeStudentDeptRequest request, CollegeChangeStudentDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDeptId))
            {
                query["newDeptId"] = request.NewDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeChangeStudentDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students/move",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeChangeStudentDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeChangeStudentDeptResponse CollegeChangeStudentDept(CollegeChangeStudentDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeChangeStudentDeptHeaders headers = new CollegeChangeStudentDeptHeaders();
            return CollegeChangeStudentDeptWithOptions(request, headers, runtime);
        }

        public async Task<CollegeChangeStudentDeptResponse> CollegeChangeStudentDeptAsync(CollegeChangeStudentDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeChangeStudentDeptHeaders headers = new CollegeChangeStudentDeptHeaders();
            return await CollegeChangeStudentDeptWithOptionsAsync(request, headers, runtime);
        }

        public CollegeDeleteCollegeDeptResponse CollegeDeleteCollegeDeptWithOptions(CollegeDeleteCollegeDeptRequest request, CollegeDeleteCollegeDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeDeleteCollegeDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeDeleteCollegeDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeDeleteCollegeDeptResponse> CollegeDeleteCollegeDeptWithOptionsAsync(CollegeDeleteCollegeDeptRequest request, CollegeDeleteCollegeDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeDeleteCollegeDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeDeleteCollegeDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeDeleteCollegeDeptResponse CollegeDeleteCollegeDept(CollegeDeleteCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeDeleteCollegeDeptHeaders headers = new CollegeDeleteCollegeDeptHeaders();
            return CollegeDeleteCollegeDeptWithOptions(request, headers, runtime);
        }

        public async Task<CollegeDeleteCollegeDeptResponse> CollegeDeleteCollegeDeptAsync(CollegeDeleteCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeDeleteCollegeDeptHeaders headers = new CollegeDeleteCollegeDeptHeaders();
            return await CollegeDeleteCollegeDeptWithOptionsAsync(request, headers, runtime);
        }

        public CollegeListCollegeSubDeptResponse CollegeListCollegeSubDeptWithOptions(CollegeListCollegeSubDeptRequest request, CollegeListCollegeSubDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeListCollegeSubDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/subDepts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListCollegeSubDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeListCollegeSubDeptResponse> CollegeListCollegeSubDeptWithOptionsAsync(CollegeListCollegeSubDeptRequest request, CollegeListCollegeSubDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeListCollegeSubDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/subDepts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListCollegeSubDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeListCollegeSubDeptResponse CollegeListCollegeSubDept(CollegeListCollegeSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListCollegeSubDeptHeaders headers = new CollegeListCollegeSubDeptHeaders();
            return CollegeListCollegeSubDeptWithOptions(request, headers, runtime);
        }

        public async Task<CollegeListCollegeSubDeptResponse> CollegeListCollegeSubDeptAsync(CollegeListCollegeSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListCollegeSubDeptHeaders headers = new CollegeListCollegeSubDeptHeaders();
            return await CollegeListCollegeSubDeptWithOptionsAsync(request, headers, runtime);
        }

        public CollegeListDeptManagerResponse CollegeListDeptManagerWithOptions(CollegeListDeptManagerRequest request, CollegeListDeptManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "CollegeListDeptManager",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/managers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListDeptManagerResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeListDeptManagerResponse> CollegeListDeptManagerWithOptionsAsync(CollegeListDeptManagerRequest request, CollegeListDeptManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "CollegeListDeptManager",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/managers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListDeptManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeListDeptManagerResponse CollegeListDeptManager(CollegeListDeptManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListDeptManagerHeaders headers = new CollegeListDeptManagerHeaders();
            return CollegeListDeptManagerWithOptions(request, headers, runtime);
        }

        public async Task<CollegeListDeptManagerResponse> CollegeListDeptManagerAsync(CollegeListDeptManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListDeptManagerHeaders headers = new CollegeListDeptManagerHeaders();
            return await CollegeListDeptManagerWithOptionsAsync(request, headers, runtime);
        }

        public CollegeListStudentInfoResponse CollegeListStudentInfoWithOptions(CollegeListStudentInfoRequest request, CollegeListStudentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingStudentStatus))
            {
                query["dingStudentStatus"] = request.DingStudentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "CollegeListStudentInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListStudentInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeListStudentInfoResponse> CollegeListStudentInfoWithOptionsAsync(CollegeListStudentInfoRequest request, CollegeListStudentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DingStudentStatus))
            {
                query["dingStudentStatus"] = request.DingStudentStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "CollegeListStudentInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListStudentInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeListStudentInfoResponse CollegeListStudentInfo(CollegeListStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListStudentInfoHeaders headers = new CollegeListStudentInfoHeaders();
            return CollegeListStudentInfoWithOptions(request, headers, runtime);
        }

        public async Task<CollegeListStudentInfoResponse> CollegeListStudentInfoAsync(CollegeListStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListStudentInfoHeaders headers = new CollegeListStudentInfoHeaders();
            return await CollegeListStudentInfoWithOptionsAsync(request, headers, runtime);
        }

        public CollegeListUncheckedStudentResponse CollegeListUncheckedStudentWithOptions(CollegeListUncheckedStudentRequest request, CollegeListUncheckedStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "CollegeListUncheckedStudent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/organizations/unjoinedStudents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListUncheckedStudentResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeListUncheckedStudentResponse> CollegeListUncheckedStudentWithOptionsAsync(CollegeListUncheckedStudentRequest request, CollegeListUncheckedStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "CollegeListUncheckedStudent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/organizations/unjoinedStudents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeListUncheckedStudentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeListUncheckedStudentResponse CollegeListUncheckedStudent(CollegeListUncheckedStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListUncheckedStudentHeaders headers = new CollegeListUncheckedStudentHeaders();
            return CollegeListUncheckedStudentWithOptions(request, headers, runtime);
        }

        public async Task<CollegeListUncheckedStudentResponse> CollegeListUncheckedStudentAsync(CollegeListUncheckedStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeListUncheckedStudentHeaders headers = new CollegeListUncheckedStudentHeaders();
            return await CollegeListUncheckedStudentWithOptionsAsync(request, headers, runtime);
        }

        public CollegeQueryCollegeDeptGroupInfoResponse CollegeQueryCollegeDeptGroupInfoWithOptions(CollegeQueryCollegeDeptGroupInfoRequest request, CollegeQueryCollegeDeptGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeQueryCollegeDeptGroupInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts/groupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryCollegeDeptGroupInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeQueryCollegeDeptGroupInfoResponse> CollegeQueryCollegeDeptGroupInfoWithOptionsAsync(CollegeQueryCollegeDeptGroupInfoRequest request, CollegeQueryCollegeDeptGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeQueryCollegeDeptGroupInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts/groupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryCollegeDeptGroupInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeQueryCollegeDeptGroupInfoResponse CollegeQueryCollegeDeptGroupInfo(CollegeQueryCollegeDeptGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptGroupInfoHeaders headers = new CollegeQueryCollegeDeptGroupInfoHeaders();
            return CollegeQueryCollegeDeptGroupInfoWithOptions(request, headers, runtime);
        }

        public async Task<CollegeQueryCollegeDeptGroupInfoResponse> CollegeQueryCollegeDeptGroupInfoAsync(CollegeQueryCollegeDeptGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptGroupInfoHeaders headers = new CollegeQueryCollegeDeptGroupInfoHeaders();
            return await CollegeQueryCollegeDeptGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        public CollegeQueryCollegeDeptInfoResponse CollegeQueryCollegeDeptInfoWithOptions(CollegeQueryCollegeDeptInfoRequest request, CollegeQueryCollegeDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeQueryCollegeDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/deptInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryCollegeDeptInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeQueryCollegeDeptInfoResponse> CollegeQueryCollegeDeptInfoWithOptionsAsync(CollegeQueryCollegeDeptInfoRequest request, CollegeQueryCollegeDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CollegeQueryCollegeDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/deptInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryCollegeDeptInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeQueryCollegeDeptInfoResponse CollegeQueryCollegeDeptInfo(CollegeQueryCollegeDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptInfoHeaders headers = new CollegeQueryCollegeDeptInfoHeaders();
            return CollegeQueryCollegeDeptInfoWithOptions(request, headers, runtime);
        }

        public async Task<CollegeQueryCollegeDeptInfoResponse> CollegeQueryCollegeDeptInfoAsync(CollegeQueryCollegeDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryCollegeDeptInfoHeaders headers = new CollegeQueryCollegeDeptInfoHeaders();
            return await CollegeQueryCollegeDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        public CollegeQueryStudentInfoByDeptResponse CollegeQueryStudentInfoByDeptWithOptions(CollegeQueryStudentInfoByDeptRequest request, CollegeQueryStudentInfoByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeQueryStudentInfoByDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/studentinfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryStudentInfoByDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeQueryStudentInfoByDeptResponse> CollegeQueryStudentInfoByDeptWithOptionsAsync(CollegeQueryStudentInfoByDeptRequest request, CollegeQueryStudentInfoByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeQueryStudentInfoByDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/studentinfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryStudentInfoByDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeQueryStudentInfoByDeptResponse CollegeQueryStudentInfoByDept(CollegeQueryStudentInfoByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByDeptHeaders headers = new CollegeQueryStudentInfoByDeptHeaders();
            return CollegeQueryStudentInfoByDeptWithOptions(request, headers, runtime);
        }

        public async Task<CollegeQueryStudentInfoByDeptResponse> CollegeQueryStudentInfoByDeptAsync(CollegeQueryStudentInfoByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByDeptHeaders headers = new CollegeQueryStudentInfoByDeptHeaders();
            return await CollegeQueryStudentInfoByDeptWithOptionsAsync(request, headers, runtime);
        }

        public CollegeQueryStudentInfoByMobileResponse CollegeQueryStudentInfoByMobileWithOptions(CollegeQueryStudentInfoByMobileRequest request, CollegeQueryStudentInfoByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
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
                Action = "CollegeQueryStudentInfoByMobile",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/students/mobiles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryStudentInfoByMobileResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeQueryStudentInfoByMobileResponse> CollegeQueryStudentInfoByMobileWithOptionsAsync(CollegeQueryStudentInfoByMobileRequest request, CollegeQueryStudentInfoByMobileHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
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
                Action = "CollegeQueryStudentInfoByMobile",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/students/mobiles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryStudentInfoByMobileResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeQueryStudentInfoByMobileResponse CollegeQueryStudentInfoByMobile(CollegeQueryStudentInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByMobileHeaders headers = new CollegeQueryStudentInfoByMobileHeaders();
            return CollegeQueryStudentInfoByMobileWithOptions(request, headers, runtime);
        }

        public async Task<CollegeQueryStudentInfoByMobileResponse> CollegeQueryStudentInfoByMobileAsync(CollegeQueryStudentInfoByMobileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByMobileHeaders headers = new CollegeQueryStudentInfoByMobileHeaders();
            return await CollegeQueryStudentInfoByMobileWithOptionsAsync(request, headers, runtime);
        }

        public CollegeQueryStudentInfoByStudentIdResponse CollegeQueryStudentInfoByStudentIdWithOptions(CollegeQueryStudentInfoByStudentIdRequest request, CollegeQueryStudentInfoByStudentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeQueryStudentInfoByStudentId",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/students",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryStudentInfoByStudentIdResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeQueryStudentInfoByStudentIdResponse> CollegeQueryStudentInfoByStudentIdWithOptionsAsync(CollegeQueryStudentInfoByStudentIdRequest request, CollegeQueryStudentInfoByStudentIdHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeQueryStudentInfoByStudentId",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/students",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeQueryStudentInfoByStudentIdResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeQueryStudentInfoByStudentIdResponse CollegeQueryStudentInfoByStudentId(CollegeQueryStudentInfoByStudentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByStudentIdHeaders headers = new CollegeQueryStudentInfoByStudentIdHeaders();
            return CollegeQueryStudentInfoByStudentIdWithOptions(request, headers, runtime);
        }

        public async Task<CollegeQueryStudentInfoByStudentIdResponse> CollegeQueryStudentInfoByStudentIdAsync(CollegeQueryStudentInfoByStudentIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeQueryStudentInfoByStudentIdHeaders headers = new CollegeQueryStudentInfoByStudentIdHeaders();
            return await CollegeQueryStudentInfoByStudentIdWithOptionsAsync(request, headers, runtime);
        }

        public CollegeRemoveManagerResponse CollegeRemoveManagerWithOptions(CollegeRemoveManagerRequest request, CollegeRemoveManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForce))
            {
                query["isForce"] = request.IsForce;
            }
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
                Action = "CollegeRemoveManager",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/managers",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeRemoveManagerResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeRemoveManagerResponse> CollegeRemoveManagerWithOptionsAsync(CollegeRemoveManagerRequest request, CollegeRemoveManagerHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForce))
            {
                query["isForce"] = request.IsForce;
            }
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
                Action = "CollegeRemoveManager",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/managers",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeRemoveManagerResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeRemoveManagerResponse CollegeRemoveManager(CollegeRemoveManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveManagerHeaders headers = new CollegeRemoveManagerHeaders();
            return CollegeRemoveManagerWithOptions(request, headers, runtime);
        }

        public async Task<CollegeRemoveManagerResponse> CollegeRemoveManagerAsync(CollegeRemoveManagerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveManagerHeaders headers = new CollegeRemoveManagerHeaders();
            return await CollegeRemoveManagerWithOptionsAsync(request, headers, runtime);
        }

        public CollegeRemoveStudentResponse CollegeRemoveStudentWithOptions(CollegeRemoveStudentRequest request, CollegeRemoveStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeRemoveStudent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeRemoveStudentResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeRemoveStudentResponse> CollegeRemoveStudentWithOptionsAsync(CollegeRemoveStudentRequest request, CollegeRemoveStudentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeRemoveStudent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeRemoveStudentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeRemoveStudentResponse CollegeRemoveStudent(CollegeRemoveStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveStudentHeaders headers = new CollegeRemoveStudentHeaders();
            return CollegeRemoveStudentWithOptions(request, headers, runtime);
        }

        public async Task<CollegeRemoveStudentResponse> CollegeRemoveStudentAsync(CollegeRemoveStudentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeRemoveStudentHeaders headers = new CollegeRemoveStudentHeaders();
            return await CollegeRemoveStudentWithOptionsAsync(request, headers, runtime);
        }

        public CollegeUpdateCollegeDeptResponse CollegeUpdateCollegeDeptWithOptions(CollegeUpdateCollegeDeptRequest request, CollegeUpdateCollegeDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                query["deptName"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFactor))
            {
                query["sortFactor"] = request.SortFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "CollegeUpdateCollegeDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateCollegeDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeUpdateCollegeDeptResponse> CollegeUpdateCollegeDeptWithOptionsAsync(CollegeUpdateCollegeDeptRequest request, CollegeUpdateCollegeDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                query["deptName"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortFactor))
            {
                query["sortFactor"] = request.SortFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "CollegeUpdateCollegeDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/depts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateCollegeDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeUpdateCollegeDeptResponse CollegeUpdateCollegeDept(CollegeUpdateCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateCollegeDeptHeaders headers = new CollegeUpdateCollegeDeptHeaders();
            return CollegeUpdateCollegeDeptWithOptions(request, headers, runtime);
        }

        public async Task<CollegeUpdateCollegeDeptResponse> CollegeUpdateCollegeDeptAsync(CollegeUpdateCollegeDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateCollegeDeptHeaders headers = new CollegeUpdateCollegeDeptHeaders();
            return await CollegeUpdateCollegeDeptWithOptionsAsync(request, headers, runtime);
        }

        public CollegeUpdateStudentDeptInfoResponse CollegeUpdateStudentDeptInfoWithOptions(CollegeUpdateStudentDeptInfoRequest request, CollegeUpdateStudentDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentNumber))
            {
                query["studentNumber"] = request.StudentNumber;
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
                Action = "CollegeUpdateStudentDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/deptInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateStudentDeptInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeUpdateStudentDeptInfoResponse> CollegeUpdateStudentDeptInfoWithOptionsAsync(CollegeUpdateStudentDeptInfoRequest request, CollegeUpdateStudentDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentNumber))
            {
                query["studentNumber"] = request.StudentNumber;
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
                Action = "CollegeUpdateStudentDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/deptInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateStudentDeptInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeUpdateStudentDeptInfoResponse CollegeUpdateStudentDeptInfo(CollegeUpdateStudentDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentDeptInfoHeaders headers = new CollegeUpdateStudentDeptInfoHeaders();
            return CollegeUpdateStudentDeptInfoWithOptions(request, headers, runtime);
        }

        public async Task<CollegeUpdateStudentDeptInfoResponse> CollegeUpdateStudentDeptInfoAsync(CollegeUpdateStudentDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentDeptInfoHeaders headers = new CollegeUpdateStudentDeptInfoHeaders();
            return await CollegeUpdateStudentDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        public CollegeUpdateStudentInfoResponse CollegeUpdateStudentInfoWithOptions(CollegeUpdateStudentInfoRequest request, CollegeUpdateStudentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpExtension))
            {
                body["empExtension"] = request.EmpExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyId))
            {
                body["identifyId"] = request.IdentifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartYear))
            {
                body["startYear"] = request.StartYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                body["studentId"] = request.StudentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentName))
            {
                body["studentName"] = request.StudentName;
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
                Action = "CollegeUpdateStudentInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateStudentInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeUpdateStudentInfoResponse> CollegeUpdateStudentInfoWithOptionsAsync(CollegeUpdateStudentInfoRequest request, CollegeUpdateStudentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EmpExtension))
            {
                body["empExtension"] = request.EmpExtension;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gender))
            {
                body["gender"] = request.Gender;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdentifyId))
            {
                body["identifyId"] = request.IdentifyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartYear))
            {
                body["startYear"] = request.StartYear;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                body["studentId"] = request.StudentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentName))
            {
                body["studentName"] = request.StudentName;
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
                Action = "CollegeUpdateStudentInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/depts/students",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateStudentInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeUpdateStudentInfoResponse CollegeUpdateStudentInfo(CollegeUpdateStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentInfoHeaders headers = new CollegeUpdateStudentInfoHeaders();
            return CollegeUpdateStudentInfoWithOptions(request, headers, runtime);
        }

        public async Task<CollegeUpdateStudentInfoResponse> CollegeUpdateStudentInfoAsync(CollegeUpdateStudentInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentInfoHeaders headers = new CollegeUpdateStudentInfoHeaders();
            return await CollegeUpdateStudentInfoWithOptionsAsync(request, headers, runtime);
        }

        public CollegeUpdateStudentMoblieResponse CollegeUpdateStudentMoblieWithOptions(CollegeUpdateStudentMoblieRequest request, CollegeUpdateStudentMoblieHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForce))
            {
                query["isForce"] = request.IsForce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobile))
            {
                query["newMobile"] = request.NewMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeUpdateStudentMoblie",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/students/mobiles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateStudentMoblieResponse>(Execute(params_, req, runtime));
        }

        public async Task<CollegeUpdateStudentMoblieResponse> CollegeUpdateStudentMoblieWithOptionsAsync(CollegeUpdateStudentMoblieRequest request, CollegeUpdateStudentMoblieHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForce))
            {
                query["isForce"] = request.IsForce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewMobile))
            {
                query["newMobile"] = request.NewMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StudentId))
            {
                query["studentId"] = request.StudentId;
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
                Action = "CollegeUpdateStudentMoblie",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/colleges/members/students/mobiles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CollegeUpdateStudentMoblieResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CollegeUpdateStudentMoblieResponse CollegeUpdateStudentMoblie(CollegeUpdateStudentMoblieRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentMoblieHeaders headers = new CollegeUpdateStudentMoblieHeaders();
            return CollegeUpdateStudentMoblieWithOptions(request, headers, runtime);
        }

        public async Task<CollegeUpdateStudentMoblieResponse> CollegeUpdateStudentMoblieAsync(CollegeUpdateStudentMoblieRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CollegeUpdateStudentMoblieHeaders headers = new CollegeUpdateStudentMoblieHeaders();
            return await CollegeUpdateStudentMoblieWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactCreateResponse CustomizeContactCreateWithOptions(CustomizeContactCreateRequest request, CustomizeContactCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
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
                Action = "CustomizeContactCreate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactCreateResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactCreateResponse> CustomizeContactCreateWithOptionsAsync(CustomizeContactCreateRequest request, CustomizeContactCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
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
                Action = "CustomizeContactCreate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactCreateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactCreateResponse CustomizeContactCreate(CustomizeContactCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
            return CustomizeContactCreateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactCreateResponse> CustomizeContactCreateAsync(CustomizeContactCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactCreateHeaders headers = new CustomizeContactCreateHeaders();
            return await CustomizeContactCreateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeleteResponse CustomizeContactDeleteWithOptions(CustomizeContactDeleteRequest request, CustomizeContactDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                Action = "CustomizeContactDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeleteResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactDeleteResponse> CustomizeContactDeleteWithOptionsAsync(CustomizeContactDeleteRequest request, CustomizeContactDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
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
                Action = "CustomizeContactDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeleteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactDeleteResponse CustomizeContactDelete(CustomizeContactDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
            return CustomizeContactDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeleteResponse> CustomizeContactDeleteAsync(CustomizeContactDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeleteHeaders headers = new CustomizeContactDeleteHeaders();
            return await CustomizeContactDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptCreateResponse CustomizeContactDeptCreateWithOptions(CustomizeContactDeptCreateRequest request, CustomizeContactDeptCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefId))
            {
                body["refId"] = request.RefId;
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
                Action = "CustomizeContactDeptCreate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptCreateResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactDeptCreateResponse> CustomizeContactDeptCreateWithOptionsAsync(CustomizeContactDeptCreateRequest request, CustomizeContactDeptCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefId))
            {
                body["refId"] = request.RefId;
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
                Action = "CustomizeContactDeptCreate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptCreateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactDeptCreateResponse CustomizeContactDeptCreate(CustomizeContactDeptCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
            return CustomizeContactDeptCreateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptCreateResponse> CustomizeContactDeptCreateAsync(CustomizeContactDeptCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptCreateHeaders headers = new CustomizeContactDeptCreateHeaders();
            return await CustomizeContactDeptCreateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptDeleteResponse CustomizeContactDeptDeleteWithOptions(CustomizeContactDeptDeleteRequest request, CustomizeContactDeptDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptDeleteResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactDeptDeleteResponse> CustomizeContactDeptDeleteWithOptionsAsync(CustomizeContactDeptDeleteRequest request, CustomizeContactDeptDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptDeleteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactDeptDeleteResponse CustomizeContactDeptDelete(CustomizeContactDeptDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
            return CustomizeContactDeptDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptDeleteResponse> CustomizeContactDeptDeleteAsync(CustomizeContactDeptDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptDeleteHeaders headers = new CustomizeContactDeptDeleteHeaders();
            return await CustomizeContactDeptDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptGroupCreateResponse CustomizeContactDeptGroupCreateWithOptions(CustomizeContactDeptGroupCreateRequest request, CustomizeContactDeptGroupCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptGroupCreate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departmentGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptGroupCreateResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactDeptGroupCreateResponse> CustomizeContactDeptGroupCreateWithOptionsAsync(CustomizeContactDeptGroupCreateRequest request, CustomizeContactDeptGroupCreateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptGroupCreate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departmentGroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptGroupCreateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactDeptGroupCreateResponse CustomizeContactDeptGroupCreate(CustomizeContactDeptGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptGroupCreateHeaders headers = new CustomizeContactDeptGroupCreateHeaders();
            return CustomizeContactDeptGroupCreateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptGroupCreateResponse> CustomizeContactDeptGroupCreateAsync(CustomizeContactDeptGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptGroupCreateHeaders headers = new CustomizeContactDeptGroupCreateHeaders();
            return await CustomizeContactDeptGroupCreateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptInfoResponse CustomizeContactDeptInfoWithOptions(CustomizeContactDeptInfoRequest request, CustomizeContactDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactDeptInfoResponse> CustomizeContactDeptInfoWithOptionsAsync(CustomizeContactDeptInfoRequest request, CustomizeContactDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactDeptInfoResponse CustomizeContactDeptInfo(CustomizeContactDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
            return CustomizeContactDeptInfoWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptInfoResponse> CustomizeContactDeptInfoAsync(CustomizeContactDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptInfoHeaders headers = new CustomizeContactDeptInfoHeaders();
            return await CustomizeContactDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptListResponse CustomizeContactDeptListWithOptions(CustomizeContactDeptListRequest request, CustomizeContactDeptListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/subsidiaryDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptListResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactDeptListResponse> CustomizeContactDeptListWithOptionsAsync(CustomizeContactDeptListRequest request, CustomizeContactDeptListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactDeptList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/subsidiaryDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactDeptListResponse CustomizeContactDeptList(CustomizeContactDeptListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
            return CustomizeContactDeptListWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptListResponse> CustomizeContactDeptListAsync(CustomizeContactDeptListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptListHeaders headers = new CustomizeContactDeptListHeaders();
            return await CustomizeContactDeptListWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactDeptUpdateResponse CustomizeContactDeptUpdateWithOptions(CustomizeContactDeptUpdateRequest request, CustomizeContactDeptUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
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
                Action = "CustomizeContactDeptUpdate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptUpdateResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactDeptUpdateResponse> CustomizeContactDeptUpdateWithOptionsAsync(CustomizeContactDeptUpdateRequest request, CustomizeContactDeptUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentDeptId))
            {
                body["parentDeptId"] = request.ParentDeptId;
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
                Action = "CustomizeContactDeptUpdate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/departments",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactDeptUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactDeptUpdateResponse CustomizeContactDeptUpdate(CustomizeContactDeptUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
            return CustomizeContactDeptUpdateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactDeptUpdateResponse> CustomizeContactDeptUpdateAsync(CustomizeContactDeptUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactDeptUpdateHeaders headers = new CustomizeContactDeptUpdateHeaders();
            return await CustomizeContactDeptUpdateWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactEmpAddResponse CustomizeContactEmpAddWithOptions(CustomizeContactEmpAddRequest request, CustomizeContactEmpAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "CustomizeContactEmpAdd",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactEmpAddResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactEmpAddResponse> CustomizeContactEmpAddWithOptionsAsync(CustomizeContactEmpAddRequest request, CustomizeContactEmpAddHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "CustomizeContactEmpAdd",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/users",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactEmpAddResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactEmpAddResponse CustomizeContactEmpAdd(CustomizeContactEmpAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
            return CustomizeContactEmpAddWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactEmpAddResponse> CustomizeContactEmpAddAsync(CustomizeContactEmpAddRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpAddHeaders headers = new CustomizeContactEmpAddHeaders();
            return await CustomizeContactEmpAddWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactEmpDeleteResponse CustomizeContactEmpDeleteWithOptions(CustomizeContactEmpDeleteRequest request, CustomizeContactEmpDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "CustomizeContactEmpDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/users/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactEmpDeleteResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactEmpDeleteResponse> CustomizeContactEmpDeleteWithOptionsAsync(CustomizeContactEmpDeleteRequest request, CustomizeContactEmpDeleteHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                body["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "CustomizeContactEmpDelete",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/users/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactEmpDeleteResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactEmpDeleteResponse CustomizeContactEmpDelete(CustomizeContactEmpDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
            return CustomizeContactEmpDeleteWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactEmpDeleteResponse> CustomizeContactEmpDeleteAsync(CustomizeContactEmpDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpDeleteHeaders headers = new CustomizeContactEmpDeleteHeaders();
            return await CustomizeContactEmpDeleteWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactEmpListResponse CustomizeContactEmpListWithOptions(CustomizeContactEmpListRequest request, CustomizeContactEmpListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactEmpList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactEmpListResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactEmpListResponse> CustomizeContactEmpListWithOptionsAsync(CustomizeContactEmpListRequest request, CustomizeContactEmpListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "CustomizeContactEmpList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactEmpListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactEmpListResponse CustomizeContactEmpList(CustomizeContactEmpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
            return CustomizeContactEmpListWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactEmpListResponse> CustomizeContactEmpListAsync(CustomizeContactEmpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactEmpListHeaders headers = new CustomizeContactEmpListHeaders();
            return await CustomizeContactEmpListWithOptionsAsync(request, headers, runtime);
        }

        public CustomizeContactListResponse CustomizeContactListWithOptions(CustomizeContactListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CustomizeContactList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactListResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactListResponse> CustomizeContactListWithOptionsAsync(CustomizeContactListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "CustomizeContactList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactListResponse CustomizeContactList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
            return CustomizeContactListWithOptions(headers, runtime);
        }

        public async Task<CustomizeContactListResponse> CustomizeContactListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactListHeaders headers = new CustomizeContactListHeaders();
            return await CustomizeContactListWithOptionsAsync(headers, runtime);
        }

        public CustomizeContactUpdateResponse CustomizeContactUpdateWithOptions(CustomizeContactUpdateRequest request, CustomizeContactUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
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
                Action = "CustomizeContactUpdate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactUpdateResponse>(Execute(params_, req, runtime));
        }

        public async Task<CustomizeContactUpdateResponse> CustomizeContactUpdateWithOptionsAsync(CustomizeContactUpdateRequest request, CustomizeContactUpdateHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerIdList))
            {
                body["managerIdList"] = request.ManagerIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
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
                Action = "CustomizeContactUpdate",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/customizations/contacts",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<CustomizeContactUpdateResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CustomizeContactUpdateResponse CustomizeContactUpdate(CustomizeContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
            return CustomizeContactUpdateWithOptions(request, headers, runtime);
        }

        public async Task<CustomizeContactUpdateResponse> CustomizeContactUpdateAsync(CustomizeContactUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CustomizeContactUpdateHeaders headers = new CustomizeContactUpdateHeaders();
            return await CustomizeContactUpdateWithOptionsAsync(request, headers, runtime);
        }

        public DIgitalStoreMessagePushResponse DIgitalStoreMessagePushWithOptions(DIgitalStoreMessagePushRequest tmpReq, DIgitalStoreMessagePushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DIgitalStoreMessagePushShrinkRequest request = new DIgitalStoreMessagePushShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MessageDataList))
            {
                request.MessageDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MessageDataList, "messageDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageDataListShrink))
            {
                query["messageDataList"] = request.MessageDataListShrink;
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
                Action = "DIgitalStoreMessagePush",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/messages/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DIgitalStoreMessagePushResponse>(Execute(params_, req, runtime));
        }

        public async Task<DIgitalStoreMessagePushResponse> DIgitalStoreMessagePushWithOptionsAsync(DIgitalStoreMessagePushRequest tmpReq, DIgitalStoreMessagePushHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DIgitalStoreMessagePushShrinkRequest request = new DIgitalStoreMessagePushShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MessageDataList))
            {
                request.MessageDataListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MessageDataList, "messageDataList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageDataListShrink))
            {
                query["messageDataList"] = request.MessageDataListShrink;
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
                Action = "DIgitalStoreMessagePush",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/messages/push",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DIgitalStoreMessagePushResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DIgitalStoreMessagePushResponse DIgitalStoreMessagePush(DIgitalStoreMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DIgitalStoreMessagePushHeaders headers = new DIgitalStoreMessagePushHeaders();
            return DIgitalStoreMessagePushWithOptions(request, headers, runtime);
        }

        public async Task<DIgitalStoreMessagePushResponse> DIgitalStoreMessagePushAsync(DIgitalStoreMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DIgitalStoreMessagePushHeaders headers = new DIgitalStoreMessagePushHeaders();
            return await DIgitalStoreMessagePushWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreCardRecordResponse DigitalStoreCardRecordWithOptions(DigitalStoreCardRecordRequest request, DigitalStoreCardRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCardName))
            {
                body["sceneCardName"] = request.SceneCardName;
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
                Action = "DigitalStoreCardRecord",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/cardSendRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreCardRecordResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreCardRecordResponse> DigitalStoreCardRecordWithOptionsAsync(DigitalStoreCardRecordRequest request, DigitalStoreCardRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCardName))
            {
                body["sceneCardName"] = request.SceneCardName;
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
                Action = "DigitalStoreCardRecord",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/cardSendRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreCardRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreCardRecordResponse DigitalStoreCardRecord(DigitalStoreCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreCardRecordHeaders headers = new DigitalStoreCardRecordHeaders();
            return DigitalStoreCardRecordWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreCardRecordResponse> DigitalStoreCardRecordAsync(DigitalStoreCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreCardRecordHeaders headers = new DigitalStoreCardRecordHeaders();
            return await DigitalStoreCardRecordWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreContactInfoResponse DigitalStoreContactInfoWithOptions(DigitalStoreContactInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreContactInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/contactInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreContactInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreContactInfoResponse> DigitalStoreContactInfoWithOptionsAsync(DigitalStoreContactInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreContactInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/contactInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreContactInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreContactInfoResponse DigitalStoreContactInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreContactInfoHeaders headers = new DigitalStoreContactInfoHeaders();
            return DigitalStoreContactInfoWithOptions(headers, runtime);
        }

        public async Task<DigitalStoreContactInfoResponse> DigitalStoreContactInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreContactInfoHeaders headers = new DigitalStoreContactInfoHeaders();
            return await DigitalStoreContactInfoWithOptionsAsync(headers, runtime);
        }

        public DigitalStoreConversationsResponse DigitalStoreConversationsWithOptions(DigitalStoreConversationsRequest request, DigitalStoreConversationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationTitle))
            {
                query["conversationTitle"] = request.ConversationTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                query["conversationType"] = request.ConversationType;
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
                Action = "DigitalStoreConversations",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreConversationsResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreConversationsResponse> DigitalStoreConversationsWithOptionsAsync(DigitalStoreConversationsRequest request, DigitalStoreConversationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationTitle))
            {
                query["conversationTitle"] = request.ConversationTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationType))
            {
                query["conversationType"] = request.ConversationType;
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
                Action = "DigitalStoreConversations",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/conversations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreConversationsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreConversationsResponse DigitalStoreConversations(DigitalStoreConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreConversationsHeaders headers = new DigitalStoreConversationsHeaders();
            return DigitalStoreConversationsWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreConversationsResponse> DigitalStoreConversationsAsync(DigitalStoreConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreConversationsHeaders headers = new DigitalStoreConversationsHeaders();
            return await DigitalStoreConversationsWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreExportCardRecordResponse DigitalStoreExportCardRecordWithOptions(DigitalStoreExportCardRecordRequest request, DigitalStoreExportCardRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCardName))
            {
                body["sceneCardName"] = request.SceneCardName;
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
                Action = "DigitalStoreExportCardRecord",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/cardRecords/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreExportCardRecordResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreExportCardRecordResponse> DigitalStoreExportCardRecordWithOptionsAsync(DigitalStoreExportCardRecordRequest request, DigitalStoreExportCardRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCardName))
            {
                body["sceneCardName"] = request.SceneCardName;
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
                Action = "DigitalStoreExportCardRecord",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/cardRecords/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreExportCardRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreExportCardRecordResponse DigitalStoreExportCardRecord(DigitalStoreExportCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordHeaders headers = new DigitalStoreExportCardRecordHeaders();
            return DigitalStoreExportCardRecordWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreExportCardRecordResponse> DigitalStoreExportCardRecordAsync(DigitalStoreExportCardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordHeaders headers = new DigitalStoreExportCardRecordHeaders();
            return await DigitalStoreExportCardRecordWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreExportCardRecordDetailResponse DigitalStoreExportCardRecordDetailWithOptions(DigitalStoreExportCardRecordDetailRequest request, DigitalStoreExportCardRecordDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCardName))
            {
                body["sceneCardName"] = request.SceneCardName;
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
                Action = "DigitalStoreExportCardRecordDetail",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/cardRecordDetails/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreExportCardRecordDetailResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreExportCardRecordDetailResponse> DigitalStoreExportCardRecordDetailWithOptionsAsync(DigitalStoreExportCardRecordDetailRequest request, DigitalStoreExportCardRecordDetailHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                body["beginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                body["ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCardName))
            {
                body["sceneCardName"] = request.SceneCardName;
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
                Action = "DigitalStoreExportCardRecordDetail",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/cardRecordDetails/export",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreExportCardRecordDetailResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreExportCardRecordDetailResponse DigitalStoreExportCardRecordDetail(DigitalStoreExportCardRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordDetailHeaders headers = new DigitalStoreExportCardRecordDetailHeaders();
            return DigitalStoreExportCardRecordDetailWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreExportCardRecordDetailResponse> DigitalStoreExportCardRecordDetailAsync(DigitalStoreExportCardRecordDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreExportCardRecordDetailHeaders headers = new DigitalStoreExportCardRecordDetailHeaders();
            return await DigitalStoreExportCardRecordDetailWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreGroupInfoResponse DigitalStoreGroupInfoWithOptions(DigitalStoreGroupInfoRequest request, DigitalStoreGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
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
                Action = "DigitalStoreGroupInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/groupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreGroupInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreGroupInfoResponse> DigitalStoreGroupInfoWithOptionsAsync(DigitalStoreGroupInfoRequest request, DigitalStoreGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
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
                Action = "DigitalStoreGroupInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/groupInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreGroupInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreGroupInfoResponse DigitalStoreGroupInfo(DigitalStoreGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupInfoHeaders headers = new DigitalStoreGroupInfoHeaders();
            return DigitalStoreGroupInfoWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreGroupInfoResponse> DigitalStoreGroupInfoAsync(DigitalStoreGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupInfoHeaders headers = new DigitalStoreGroupInfoHeaders();
            return await DigitalStoreGroupInfoWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreGroupsResponse DigitalStoreGroupsWithOptions(DigitalStoreGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreGroups",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreGroupsResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreGroupsResponse> DigitalStoreGroupsWithOptionsAsync(DigitalStoreGroupsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreGroups",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreGroupsResponse DigitalStoreGroups()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupsHeaders headers = new DigitalStoreGroupsHeaders();
            return DigitalStoreGroupsWithOptions(headers, runtime);
        }

        public async Task<DigitalStoreGroupsResponse> DigitalStoreGroupsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreGroupsHeaders headers = new DigitalStoreGroupsHeaders();
            return await DigitalStoreGroupsWithOptionsAsync(headers, runtime);
        }

        public DigitalStoreNodeInfoResponse DigitalStoreNodeInfoWithOptions(DigitalStoreNodeInfoRequest request, DigitalStoreNodeInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["nodeId"] = request.NodeId;
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
                Action = "DigitalStoreNodeInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/nodeInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreNodeInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreNodeInfoResponse> DigitalStoreNodeInfoWithOptionsAsync(DigitalStoreNodeInfoRequest request, DigitalStoreNodeInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["nodeId"] = request.NodeId;
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
                Action = "DigitalStoreNodeInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/nodeInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreNodeInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreNodeInfoResponse DigitalStoreNodeInfo(DigitalStoreNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreNodeInfoHeaders headers = new DigitalStoreNodeInfoHeaders();
            return DigitalStoreNodeInfoWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreNodeInfoResponse> DigitalStoreNodeInfoAsync(DigitalStoreNodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreNodeInfoHeaders headers = new DigitalStoreNodeInfoHeaders();
            return await DigitalStoreNodeInfoWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreRightsInfoResponse DigitalStoreRightsInfoWithOptions(DigitalStoreRightsInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreRightsInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/rightsInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreRightsInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreRightsInfoResponse> DigitalStoreRightsInfoWithOptionsAsync(DigitalStoreRightsInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreRightsInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/rightsInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreRightsInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreRightsInfoResponse DigitalStoreRightsInfo()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRightsInfoHeaders headers = new DigitalStoreRightsInfoHeaders();
            return DigitalStoreRightsInfoWithOptions(headers, runtime);
        }

        public async Task<DigitalStoreRightsInfoResponse> DigitalStoreRightsInfoAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRightsInfoHeaders headers = new DigitalStoreRightsInfoHeaders();
            return await DigitalStoreRightsInfoWithOptionsAsync(headers, runtime);
        }

        public DigitalStoreRolesResponse DigitalStoreRolesWithOptions(DigitalStoreRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreRoles",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreRolesResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreRolesResponse> DigitalStoreRolesWithOptionsAsync(DigitalStoreRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DigitalStoreRoles",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreRolesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreRolesResponse DigitalStoreRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRolesHeaders headers = new DigitalStoreRolesHeaders();
            return DigitalStoreRolesWithOptions(headers, runtime);
        }

        public async Task<DigitalStoreRolesResponse> DigitalStoreRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreRolesHeaders headers = new DigitalStoreRolesHeaders();
            return await DigitalStoreRolesWithOptionsAsync(headers, runtime);
        }

        public DigitalStoreSceneScopeResponse DigitalStoreSceneScopeWithOptions(DigitalStoreSceneScopeRequest request, DigitalStoreSceneScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["sceneCode"] = request.SceneCode;
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
                Action = "DigitalStoreSceneScope",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/sceneScopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreSceneScopeResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreSceneScopeResponse> DigitalStoreSceneScopeWithOptionsAsync(DigitalStoreSceneScopeRequest request, DigitalStoreSceneScopeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpenConversationId))
            {
                query["openConversationId"] = request.OpenConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneCode))
            {
                query["sceneCode"] = request.SceneCode;
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
                Action = "DigitalStoreSceneScope",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/sceneScopes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreSceneScopeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreSceneScopeResponse DigitalStoreSceneScope(DigitalStoreSceneScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSceneScopeHeaders headers = new DigitalStoreSceneScopeHeaders();
            return DigitalStoreSceneScopeWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreSceneScopeResponse> DigitalStoreSceneScopeAsync(DigitalStoreSceneScopeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSceneScopeHeaders headers = new DigitalStoreSceneScopeHeaders();
            return await DigitalStoreSceneScopeWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreStoreInfoResponse DigitalStoreStoreInfoWithOptions(DigitalStoreStoreInfoRequest request, DigitalStoreStoreInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                query["storeId"] = request.StoreId;
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
                Action = "DigitalStoreStoreInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/storeInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreStoreInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreStoreInfoResponse> DigitalStoreStoreInfoWithOptionsAsync(DigitalStoreStoreInfoRequest request, DigitalStoreStoreInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreId))
            {
                query["storeId"] = request.StoreId;
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
                Action = "DigitalStoreStoreInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/storeInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreStoreInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreStoreInfoResponse DigitalStoreStoreInfo(DigitalStoreStoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreStoreInfoHeaders headers = new DigitalStoreStoreInfoHeaders();
            return DigitalStoreStoreInfoWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreStoreInfoResponse> DigitalStoreStoreInfoAsync(DigitalStoreStoreInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreStoreInfoHeaders headers = new DigitalStoreStoreInfoHeaders();
            return await DigitalStoreStoreInfoWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreSubNodesResponse DigitalStoreSubNodesWithOptions(DigitalStoreSubNodesRequest request, DigitalStoreSubNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["nodeId"] = request.NodeId;
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
                Action = "DigitalStoreSubNodes",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/subsidiaryNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreSubNodesResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreSubNodesResponse> DigitalStoreSubNodesWithOptionsAsync(DigitalStoreSubNodesRequest request, DigitalStoreSubNodesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["nodeId"] = request.NodeId;
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
                Action = "DigitalStoreSubNodes",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/subsidiaryNodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreSubNodesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreSubNodesResponse DigitalStoreSubNodes(DigitalStoreSubNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSubNodesHeaders headers = new DigitalStoreSubNodesHeaders();
            return DigitalStoreSubNodesWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreSubNodesResponse> DigitalStoreSubNodesAsync(DigitalStoreSubNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreSubNodesHeaders headers = new DigitalStoreSubNodesHeaders();
            return await DigitalStoreSubNodesWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreUpdateAuthInfoResponse DigitalStoreUpdateAuthInfoWithOptions(DigitalStoreUpdateAuthInfoRequest request, DigitalStoreUpdateAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateUserList))
            {
                body["updateUserList"] = request.UpdateUserList;
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
                Action = "DigitalStoreUpdateAuthInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/authInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreUpdateAuthInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreUpdateAuthInfoResponse> DigitalStoreUpdateAuthInfoWithOptionsAsync(DigitalStoreUpdateAuthInfoRequest request, DigitalStoreUpdateAuthInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateUserList))
            {
                body["updateUserList"] = request.UpdateUserList;
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
                Action = "DigitalStoreUpdateAuthInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/authInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreUpdateAuthInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreUpdateAuthInfoResponse DigitalStoreUpdateAuthInfo(DigitalStoreUpdateAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUpdateAuthInfoHeaders headers = new DigitalStoreUpdateAuthInfoHeaders();
            return DigitalStoreUpdateAuthInfoWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreUpdateAuthInfoResponse> DigitalStoreUpdateAuthInfoAsync(DigitalStoreUpdateAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUpdateAuthInfoHeaders headers = new DigitalStoreUpdateAuthInfoHeaders();
            return await DigitalStoreUpdateAuthInfoWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreUserInfoResponse DigitalStoreUserInfoWithOptions(DigitalStoreUserInfoRequest request, DigitalStoreUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
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
                Action = "DigitalStoreUserInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/userInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreUserInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreUserInfoResponse> DigitalStoreUserInfoWithOptionsAsync(DigitalStoreUserInfoRequest request, DigitalStoreUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
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
                Action = "DigitalStoreUserInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/userInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreUserInfoResponse DigitalStoreUserInfo(DigitalStoreUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUserInfoHeaders headers = new DigitalStoreUserInfoHeaders();
            return DigitalStoreUserInfoWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreUserInfoResponse> DigitalStoreUserInfoAsync(DigitalStoreUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUserInfoHeaders headers = new DigitalStoreUserInfoHeaders();
            return await DigitalStoreUserInfoWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStoreUsersResponse DigitalStoreUsersWithOptions(DigitalStoreUsersRequest request, DigitalStoreUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["nodeId"] = request.NodeId;
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
                Action = "DigitalStoreUsers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/nodes/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreUsersResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStoreUsersResponse> DigitalStoreUsersWithOptionsAsync(DigitalStoreUsersRequest request, DigitalStoreUsersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["nodeId"] = request.NodeId;
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
                Action = "DigitalStoreUsers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/nodes/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStoreUsersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStoreUsersResponse DigitalStoreUsers(DigitalStoreUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUsersHeaders headers = new DigitalStoreUsersHeaders();
            return DigitalStoreUsersWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStoreUsersResponse> DigitalStoreUsersAsync(DigitalStoreUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStoreUsersHeaders headers = new DigitalStoreUsersHeaders();
            return await DigitalStoreUsersWithOptionsAsync(request, headers, runtime);
        }

        public DigitalStorelistExportTaskRecordResponse DigitalStorelistExportTaskRecordWithOptions(DigitalStorelistExportTaskRecordRequest request, DigitalStorelistExportTaskRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "DigitalStorelistExportTaskRecord",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/exportTaskRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStorelistExportTaskRecordResponse>(Execute(params_, req, runtime));
        }

        public async Task<DigitalStorelistExportTaskRecordResponse> DigitalStorelistExportTaskRecordWithOptionsAsync(DigitalStorelistExportTaskRecordRequest request, DigitalStorelistExportTaskRecordHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "DigitalStorelistExportTaskRecord",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/digitalStores/exportTaskRecords",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<DigitalStorelistExportTaskRecordResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DigitalStorelistExportTaskRecordResponse DigitalStorelistExportTaskRecord(DigitalStorelistExportTaskRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStorelistExportTaskRecordHeaders headers = new DigitalStorelistExportTaskRecordHeaders();
            return DigitalStorelistExportTaskRecordWithOptions(request, headers, runtime);
        }

        public async Task<DigitalStorelistExportTaskRecordResponse> DigitalStorelistExportTaskRecordAsync(DigitalStorelistExportTaskRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DigitalStorelistExportTaskRecordHeaders headers = new DigitalStorelistExportTaskRecordHeaders();
            return await DigitalStorelistExportTaskRecordWithOptionsAsync(request, headers, runtime);
        }

        public ExternalQueryExternalAppOrgsResponse ExternalQueryExternalAppOrgsWithOptions(ExternalQueryExternalAppOrgsRequest request, ExternalQueryExternalAppOrgsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalType))
            {
                query["externalType"] = request.ExternalType;
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
                Action = "ExternalQueryExternalAppOrgs",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/externals/apps/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExternalQueryExternalAppOrgsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ExternalQueryExternalAppOrgsResponse> ExternalQueryExternalAppOrgsWithOptionsAsync(ExternalQueryExternalAppOrgsRequest request, ExternalQueryExternalAppOrgsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalType))
            {
                query["externalType"] = request.ExternalType;
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
                Action = "ExternalQueryExternalAppOrgs",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/externals/apps/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExternalQueryExternalAppOrgsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ExternalQueryExternalAppOrgsResponse ExternalQueryExternalAppOrgs(ExternalQueryExternalAppOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalAppOrgsHeaders headers = new ExternalQueryExternalAppOrgsHeaders();
            return ExternalQueryExternalAppOrgsWithOptions(request, headers, runtime);
        }

        public async Task<ExternalQueryExternalAppOrgsResponse> ExternalQueryExternalAppOrgsAsync(ExternalQueryExternalAppOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalAppOrgsHeaders headers = new ExternalQueryExternalAppOrgsHeaders();
            return await ExternalQueryExternalAppOrgsWithOptionsAsync(request, headers, runtime);
        }

        public ExternalQueryExternalBelongMainOrgResponse ExternalQueryExternalBelongMainOrgWithOptions(ExternalQueryExternalBelongMainOrgRequest request, ExternalQueryExternalBelongMainOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalType))
            {
                query["externalType"] = request.ExternalType;
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
                Action = "ExternalQueryExternalBelongMainOrg",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/externals/attributions/masterOrganizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExternalQueryExternalBelongMainOrgResponse>(Execute(params_, req, runtime));
        }

        public async Task<ExternalQueryExternalBelongMainOrgResponse> ExternalQueryExternalBelongMainOrgWithOptionsAsync(ExternalQueryExternalBelongMainOrgRequest request, ExternalQueryExternalBelongMainOrgHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalType))
            {
                query["externalType"] = request.ExternalType;
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
                Action = "ExternalQueryExternalBelongMainOrg",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/externals/attributions/masterOrganizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExternalQueryExternalBelongMainOrgResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ExternalQueryExternalBelongMainOrgResponse ExternalQueryExternalBelongMainOrg(ExternalQueryExternalBelongMainOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalBelongMainOrgHeaders headers = new ExternalQueryExternalBelongMainOrgHeaders();
            return ExternalQueryExternalBelongMainOrgWithOptions(request, headers, runtime);
        }

        public async Task<ExternalQueryExternalBelongMainOrgResponse> ExternalQueryExternalBelongMainOrgAsync(ExternalQueryExternalBelongMainOrgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalBelongMainOrgHeaders headers = new ExternalQueryExternalBelongMainOrgHeaders();
            return await ExternalQueryExternalBelongMainOrgWithOptionsAsync(request, headers, runtime);
        }

        public ExternalQueryExternalOrgsResponse ExternalQueryExternalOrgsWithOptions(ExternalQueryExternalOrgsRequest request, ExternalQueryExternalOrgsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalType))
            {
                query["externalType"] = request.ExternalType;
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
                Action = "ExternalQueryExternalOrgs",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/externals/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExternalQueryExternalOrgsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ExternalQueryExternalOrgsResponse> ExternalQueryExternalOrgsWithOptionsAsync(ExternalQueryExternalOrgsRequest request, ExternalQueryExternalOrgsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalType))
            {
                query["externalType"] = request.ExternalType;
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
                Action = "ExternalQueryExternalOrgs",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/externals/organizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExternalQueryExternalOrgsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ExternalQueryExternalOrgsResponse ExternalQueryExternalOrgs(ExternalQueryExternalOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalOrgsHeaders headers = new ExternalQueryExternalOrgsHeaders();
            return ExternalQueryExternalOrgsWithOptions(request, headers, runtime);
        }

        public async Task<ExternalQueryExternalOrgsResponse> ExternalQueryExternalOrgsAsync(ExternalQueryExternalOrgsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ExternalQueryExternalOrgsHeaders headers = new ExternalQueryExternalOrgsHeaders();
            return await ExternalQueryExternalOrgsWithOptionsAsync(request, headers, runtime);
        }

        public HospitalDataCheckResponse HospitalDataCheckWithOptions(HospitalDataCheckRequest request, HospitalDataCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDeptCount))
            {
                body["allDeptCount"] = request.AllDeptCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDeptUserCount))
            {
                body["allDeptUserCount"] = request.AllDeptUserCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroupCount))
            {
                body["allGroupCount"] = request.AllGroupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroupUserCount))
            {
                body["allGroupUserCount"] = request.AllGroupUserCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCount))
            {
                body["deptCount"] = request.DeptCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptUserCount))
            {
                body["deptUserCount"] = request.DeptUserCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCount))
            {
                body["groupCount"] = request.GroupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUserCount))
            {
                body["groupUserCount"] = request.GroupUserCount;
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
                Action = "HospitalDataCheck",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/datas/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HospitalDataCheckResponse>(Execute(params_, req, runtime));
        }

        public async Task<HospitalDataCheckResponse> HospitalDataCheckWithOptionsAsync(HospitalDataCheckRequest request, HospitalDataCheckHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDeptCount))
            {
                body["allDeptCount"] = request.AllDeptCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllDeptUserCount))
            {
                body["allDeptUserCount"] = request.AllDeptUserCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroupCount))
            {
                body["allGroupCount"] = request.AllGroupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllGroupUserCount))
            {
                body["allGroupUserCount"] = request.AllGroupUserCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCount))
            {
                body["deptCount"] = request.DeptCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptUserCount))
            {
                body["deptUserCount"] = request.DeptUserCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupCount))
            {
                body["groupCount"] = request.GroupCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupUserCount))
            {
                body["groupUserCount"] = request.GroupUserCount;
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
                Action = "HospitalDataCheck",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/datas/check",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<HospitalDataCheckResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public HospitalDataCheckResponse HospitalDataCheck(HospitalDataCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HospitalDataCheckHeaders headers = new HospitalDataCheckHeaders();
            return HospitalDataCheckWithOptions(request, headers, runtime);
        }

        public async Task<HospitalDataCheckResponse> HospitalDataCheckAsync(HospitalDataCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            HospitalDataCheckHeaders headers = new HospitalDataCheckHeaders();
            return await HospitalDataCheckWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureCommonEventResponse IndustryManufactureCommonEventWithOptions(IndustryManufactureCommonEventRequest request, IndustryManufactureCommonEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["bizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
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
                Action = "IndustryManufactureCommonEvent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturing/bases/commons/events",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureCommonEventResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureCommonEventResponse> IndustryManufactureCommonEventWithOptionsAsync(IndustryManufactureCommonEventRequest request, IndustryManufactureCommonEventHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizData))
            {
                body["bizData"] = request.BizData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                body["eventType"] = request.EventType;
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
                Action = "IndustryManufactureCommonEvent",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturing/bases/commons/events",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureCommonEventResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureCommonEventResponse IndustryManufactureCommonEvent(IndustryManufactureCommonEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCommonEventHeaders headers = new IndustryManufactureCommonEventHeaders();
            return IndustryManufactureCommonEventWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureCommonEventResponse> IndustryManufactureCommonEventAsync(IndustryManufactureCommonEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCommonEventHeaders headers = new IndustryManufactureCommonEventHeaders();
            return await IndustryManufactureCommonEventWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureCostRecordListGetResponse IndustryManufactureCostRecordListGetWithOptions(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureCostRecordListGet",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/materialCostRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureCostRecordListGetResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureCostRecordListGetResponse> IndustryManufactureCostRecordListGetWithOptionsAsync(IndustryManufactureCostRecordListGetRequest request, IndustryManufactureCostRecordListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderNo))
            {
                body["orderNo"] = request.OrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureCostRecordListGet",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/materialCostRecords/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureCostRecordListGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureCostRecordListGetResponse IndustryManufactureCostRecordListGet(IndustryManufactureCostRecordListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
            return IndustryManufactureCostRecordListGetWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureCostRecordListGetResponse> IndustryManufactureCostRecordListGetAsync(IndustryManufactureCostRecordListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureCostRecordListGetHeaders headers = new IndustryManufactureCostRecordListGetHeaders();
            return await IndustryManufactureCostRecordListGetWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureFeeListGetResponse IndustryManufactureFeeListGetWithOptions(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureFeeListGet",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/fees/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureFeeListGetResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureFeeListGetResponse> IndustryManufactureFeeListGetWithOptionsAsync(IndustryManufactureFeeListGetRequest request, IndustryManufactureFeeListGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionTaskNo))
            {
                body["productionTaskNo"] = request.ProductionTaskNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureFeeListGet",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/fees/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureFeeListGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureFeeListGetResponse IndustryManufactureFeeListGet(IndustryManufactureFeeListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
            return IndustryManufactureFeeListGetWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureFeeListGetResponse> IndustryManufactureFeeListGetAsync(IndustryManufactureFeeListGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureFeeListGetHeaders headers = new IndustryManufactureFeeListGetHeaders();
            return await IndustryManufactureFeeListGetWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureLabourCostResponse IndustryManufactureLabourCostWithOptions(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNo))
            {
                body["processNo"] = request.ProcessNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureLabourCost",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/labourCosts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureLabourCostResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureLabourCostResponse> IndustryManufactureLabourCostWithOptionsAsync(IndustryManufactureLabourCostRequest request, IndustryManufactureLabourCostHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNo))
            {
                body["processNo"] = request.ProcessNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureLabourCost",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/labourCosts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureLabourCostResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureLabourCostResponse IndustryManufactureLabourCost(IndustryManufactureLabourCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
            return IndustryManufactureLabourCostWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureLabourCostResponse> IndustryManufactureLabourCostAsync(IndustryManufactureLabourCostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureLabourCostHeaders headers = new IndustryManufactureLabourCostHeaders();
            return await IndustryManufactureLabourCostWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMaterialListResponse IndustryManufactureMaterialListWithOptions(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureMaterialList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/materials/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMaterialListResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMaterialListResponse> IndustryManufactureMaterialListWithOptionsAsync(IndustryManufactureMaterialListRequest request, IndustryManufactureMaterialListHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["currentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryManufactureMaterialList",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/materials/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMaterialListResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMaterialListResponse IndustryManufactureMaterialList(IndustryManufactureMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
            return IndustryManufactureMaterialListWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMaterialListResponse> IndustryManufactureMaterialListAsync(IndustryManufactureMaterialListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMaterialListHeaders headers = new IndustryManufactureMaterialListHeaders();
            return await IndustryManufactureMaterialListWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesDispatchTaskResponse IndustryManufactureMesDispatchTaskWithOptions(IndustryManufactureMesDispatchTaskRequest request, IndustryManufactureMesDispatchTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefectsAmount))
            {
                body["defectsAmount"] = request.DefectsAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchStaffName))
            {
                body["dispatchStaffName"] = request.DispatchStaffName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchStaffNo))
            {
                body["dispatchStaffNo"] = request.DispatchStaffNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineAmount))
            {
                body["fineAmount"] = request.FineAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overdue))
            {
                body["overdue"] = request.Overdue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanQuantity))
            {
                body["planQuantity"] = request.PlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuid))
            {
                body["processUuid"] = request.ProcessUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectStatus))
            {
                body["projectStatus"] = request.ProjectStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOperators))
            {
                body["taskOperators"] = request.TaskOperators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanEndTime))
            {
                body["taskPlanEndTime"] = request.TaskPlanEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanStartTime))
            {
                body["taskPlanStartTime"] = request.TaskPlanStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["taskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["teamId"] = request.TeamId;
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
                Action = "IndustryManufactureMesDispatchTask",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/dispatchTasks/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesDispatchTaskResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesDispatchTaskResponse> IndustryManufactureMesDispatchTaskWithOptionsAsync(IndustryManufactureMesDispatchTaskRequest request, IndustryManufactureMesDispatchTaskHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefectsAmount))
            {
                body["defectsAmount"] = request.DefectsAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchStaffName))
            {
                body["dispatchStaffName"] = request.DispatchStaffName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DispatchStaffNo))
            {
                body["dispatchStaffNo"] = request.DispatchStaffNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineAmount))
            {
                body["fineAmount"] = request.FineAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overdue))
            {
                body["overdue"] = request.Overdue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanQuantity))
            {
                body["planQuantity"] = request.PlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuid))
            {
                body["processUuid"] = request.ProcessUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectStatus))
            {
                body["projectStatus"] = request.ProjectStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskOperators))
            {
                body["taskOperators"] = request.TaskOperators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanEndTime))
            {
                body["taskPlanEndTime"] = request.TaskPlanEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanStartTime))
            {
                body["taskPlanStartTime"] = request.TaskPlanStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["taskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["teamId"] = request.TeamId;
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
                Action = "IndustryManufactureMesDispatchTask",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/dispatchTasks/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesDispatchTaskResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesDispatchTaskResponse IndustryManufactureMesDispatchTask(IndustryManufactureMesDispatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesDispatchTaskHeaders headers = new IndustryManufactureMesDispatchTaskHeaders();
            return IndustryManufactureMesDispatchTaskWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesDispatchTaskResponse> IndustryManufactureMesDispatchTaskAsync(IndustryManufactureMesDispatchTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesDispatchTaskHeaders headers = new IndustryManufactureMesDispatchTaskHeaders();
            return await IndustryManufactureMesDispatchTaskWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesMaterialResponse IndustryManufactureMesMaterialWithOptions(IndustryManufactureMesMaterialRequest request, IndustryManufactureMesMaterialHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prop))
            {
                body["prop"] = request.Prop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                body["unit"] = request.Unit;
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
                Action = "IndustryManufactureMesMaterial",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/materials/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesMaterialResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesMaterialResponse> IndustryManufactureMesMaterialWithOptionsAsync(IndustryManufactureMesMaterialRequest request, IndustryManufactureMesMaterialHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prop))
            {
                body["prop"] = request.Prop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                body["unit"] = request.Unit;
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
                Action = "IndustryManufactureMesMaterial",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/materials/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesMaterialResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesMaterialResponse IndustryManufactureMesMaterial(IndustryManufactureMesMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesMaterialHeaders headers = new IndustryManufactureMesMaterialHeaders();
            return IndustryManufactureMesMaterialWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesMaterialResponse> IndustryManufactureMesMaterialAsync(IndustryManufactureMesMaterialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesMaterialHeaders headers = new IndustryManufactureMesMaterialHeaders();
            return await IndustryManufactureMesMaterialWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesOutPlanResponse IndustryManufactureMesOutPlanWithOptions(IndustryManufactureMesOutPlanRequest request, IndustryManufactureMesOutPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                body["approvalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Approver))
            {
                body["approver"] = request.Approver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSourceProjectCode))
            {
                body["outSourceProjectCode"] = request.OutSourceProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSourceTeamId))
            {
                body["outSourceTeamId"] = request.OutSourceTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIdentificationCode))
            {
                body["processIdentificationCode"] = request.ProcessIdentificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuids))
            {
                body["processUuids"] = request.ProcessUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendPlanQuantity))
            {
                body["sendPlanQuantity"] = request.SendPlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplierCode"] = request.SupplierCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierName))
            {
                body["supplierName"] = request.SupplierName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalWage))
            {
                body["totalWage"] = request.TotalWage;
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
                Action = "IndustryManufactureMesOutPlan",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/outPlans/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesOutPlanResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesOutPlanResponse> IndustryManufactureMesOutPlanWithOptionsAsync(IndustryManufactureMesOutPlanRequest request, IndustryManufactureMesOutPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalStatus))
            {
                body["approvalStatus"] = request.ApprovalStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Approver))
            {
                body["approver"] = request.Approver;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSourceProjectCode))
            {
                body["outSourceProjectCode"] = request.OutSourceProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutSourceTeamId))
            {
                body["outSourceTeamId"] = request.OutSourceTeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIdentificationCode))
            {
                body["processIdentificationCode"] = request.ProcessIdentificationCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuids))
            {
                body["processUuids"] = request.ProcessUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SendPlanQuantity))
            {
                body["sendPlanQuantity"] = request.SendPlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierCode))
            {
                body["supplierCode"] = request.SupplierCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierName))
            {
                body["supplierName"] = request.SupplierName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TotalWage))
            {
                body["totalWage"] = request.TotalWage;
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
                Action = "IndustryManufactureMesOutPlan",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/outPlans/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesOutPlanResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesOutPlanResponse IndustryManufactureMesOutPlan(IndustryManufactureMesOutPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutPlanHeaders headers = new IndustryManufactureMesOutPlanHeaders();
            return IndustryManufactureMesOutPlanWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesOutPlanResponse> IndustryManufactureMesOutPlanAsync(IndustryManufactureMesOutPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutPlanHeaders headers = new IndustryManufactureMesOutPlanHeaders();
            return await IndustryManufactureMesOutPlanWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesOutputResponse IndustryManufactureMesOutputWithOptions(IndustryManufactureMesOutputRequest request, IndustryManufactureMesOutputHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStatus))
            {
                body["approveStatus"] = request.ApproveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefectsAmount))
            {
                body["defectsAmount"] = request.DefectsAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefectsReason))
            {
                body["defectsReason"] = request.DefectsReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineAmount))
            {
                body["fineAmount"] = request.FineAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasQualityTest))
            {
                body["hasQualityTest"] = request.HasQualityTest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overdue))
            {
                body["overdue"] = request.Overdue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanQuantity))
            {
                body["planQuantity"] = request.PlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuid))
            {
                body["processUuid"] = request.ProcessUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectStatus))
            {
                body["projectStatus"] = request.ProjectStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityTestStatus))
            {
                body["qualityTestStatus"] = request.QualityTestStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanEndTime))
            {
                body["taskPlanEndTime"] = request.TaskPlanEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanStartTime))
            {
                body["taskPlanStartTime"] = request.TaskPlanStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["taskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                body["taskUuid"] = request.TaskUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["teamId"] = request.TeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "IndustryManufactureMesOutput",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/outputs/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesOutputResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesOutputResponse> IndustryManufactureMesOutputWithOptionsAsync(IndustryManufactureMesOutputRequest request, IndustryManufactureMesOutputHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApproveStatus))
            {
                body["approveStatus"] = request.ApproveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefectsAmount))
            {
                body["defectsAmount"] = request.DefectsAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefectsReason))
            {
                body["defectsReason"] = request.DefectsReason;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FineAmount))
            {
                body["fineAmount"] = request.FineAmount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasQualityTest))
            {
                body["hasQualityTest"] = request.HasQualityTest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overdue))
            {
                body["overdue"] = request.Overdue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanQuantity))
            {
                body["planQuantity"] = request.PlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["processName"] = request.ProcessName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuid))
            {
                body["processUuid"] = request.ProcessUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectCode))
            {
                body["projectCode"] = request.ProjectCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectStatus))
            {
                body["projectStatus"] = request.ProjectStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualityTestStatus))
            {
                body["qualityTestStatus"] = request.QualityTestStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanEndTime))
            {
                body["taskPlanEndTime"] = request.TaskPlanEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPlanStartTime))
            {
                body["taskPlanStartTime"] = request.TaskPlanStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                body["taskStatus"] = request.TaskStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskUuid))
            {
                body["taskUuid"] = request.TaskUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamId))
            {
                body["teamId"] = request.TeamId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                body["userId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
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
                Action = "IndustryManufactureMesOutput",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/outputs/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesOutputResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesOutputResponse IndustryManufactureMesOutput(IndustryManufactureMesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutputHeaders headers = new IndustryManufactureMesOutputHeaders();
            return IndustryManufactureMesOutputWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesOutputResponse> IndustryManufactureMesOutputAsync(IndustryManufactureMesOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesOutputHeaders headers = new IndustryManufactureMesOutputHeaders();
            return await IndustryManufactureMesOutputWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesProcessResponse IndustryManufactureMesProcessWithOptions(IndustryManufactureMesProcessRequest request, IndustryManufactureMesProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDispatch))
            {
                body["needDispatch"] = request.NeedDispatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedQualityTest))
            {
                body["needQualityTest"] = request.NeedQualityTest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.No))
            {
                body["no"] = request.No;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prop))
            {
                body["prop"] = request.Prop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sop))
            {
                body["sop"] = request.Sop;
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
                Action = "IndustryManufactureMesProcess",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/processes/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesProcessResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesProcessResponse> IndustryManufactureMesProcessWithOptionsAsync(IndustryManufactureMesProcessRequest request, IndustryManufactureMesProcessHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedDispatch))
            {
                body["needDispatch"] = request.NeedDispatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedQualityTest))
            {
                body["needQualityTest"] = request.NeedQualityTest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.No))
            {
                body["no"] = request.No;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prop))
            {
                body["prop"] = request.Prop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sop))
            {
                body["sop"] = request.Sop;
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
                Action = "IndustryManufactureMesProcess",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/processes/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesProcessResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesProcessResponse IndustryManufactureMesProcess(IndustryManufactureMesProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProcessHeaders headers = new IndustryManufactureMesProcessHeaders();
            return IndustryManufactureMesProcessWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesProcessResponse> IndustryManufactureMesProcessAsync(IndustryManufactureMesProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProcessHeaders headers = new IndustryManufactureMesProcessHeaders();
            return await IndustryManufactureMesProcessWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesProductionPlanResponse IndustryManufactureMesProductionPlanWithOptions(IndustryManufactureMesProductionPlanRequest request, IndustryManufactureMesProductionPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualEndTime))
            {
                body["actualEndTime"] = request.ActualEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualStartTime))
            {
                body["actualStartTime"] = request.ActualStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BomUuid))
            {
                body["bomUuid"] = request.BomUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.No))
            {
                body["no"] = request.No;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overdue))
            {
                body["overdue"] = request.Overdue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanEndTime))
            {
                body["planEndTime"] = request.PlanEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanQuantity))
            {
                body["planQuantity"] = request.PlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanStartTime))
            {
                body["planStartTime"] = request.PlanStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuids))
            {
                body["processUuids"] = request.ProcessUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellOrderNo))
            {
                body["sellOrderNo"] = request.SellOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamList))
            {
                body["teamList"] = request.TeamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                body["unit"] = request.Unit;
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
                Action = "IndustryManufactureMesProductionPlan",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/productionPlans/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesProductionPlanResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesProductionPlanResponse> IndustryManufactureMesProductionPlanWithOptionsAsync(IndustryManufactureMesProductionPlanRequest request, IndustryManufactureMesProductionPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualEndTime))
            {
                body["actualEndTime"] = request.ActualEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActualStartTime))
            {
                body["actualStartTime"] = request.ActualStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BomUuid))
            {
                body["bomUuid"] = request.BomUuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.No))
            {
                body["no"] = request.No;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Overdue))
            {
                body["overdue"] = request.Overdue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanEndTime))
            {
                body["planEndTime"] = request.PlanEndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanQuantity))
            {
                body["planQuantity"] = request.PlanQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanStartTime))
            {
                body["planStartTime"] = request.PlanStartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessUuids))
            {
                body["processUuids"] = request.ProcessUuids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                body["productName"] = request.ProductName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductSpecification))
            {
                body["productSpecification"] = request.ProductSpecification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QualifiedQuantity))
            {
                body["qualifiedQuantity"] = request.QualifiedQuantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SellOrderNo))
            {
                body["sellOrderNo"] = request.SellOrderNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeamList))
            {
                body["teamList"] = request.TeamList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Unit))
            {
                body["unit"] = request.Unit;
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
                Action = "IndustryManufactureMesProductionPlan",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/productionPlans/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesProductionPlanResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesProductionPlanResponse IndustryManufactureMesProductionPlan(IndustryManufactureMesProductionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProductionPlanHeaders headers = new IndustryManufactureMesProductionPlanHeaders();
            return IndustryManufactureMesProductionPlanWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesProductionPlanResponse> IndustryManufactureMesProductionPlanAsync(IndustryManufactureMesProductionPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesProductionPlanHeaders headers = new IndustryManufactureMesProductionPlanHeaders();
            return await IndustryManufactureMesProductionPlanWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesSubCooperationTeamResponse IndustryManufactureMesSubCooperationTeamWithOptions(IndustryManufactureMesSubCooperationTeamRequest request, IndustryManufactureMesSubCooperationTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupPlugins))
            {
                body["groupPlugins"] = request.GroupPlugins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Leaders))
            {
                body["leaders"] = request.Leaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCorpId))
            {
                body["outCorpId"] = request.OutCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIds))
            {
                body["processIds"] = request.ProcessIds;
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
                Action = "IndustryManufactureMesSubCooperationTeam",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/outTeams/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesSubCooperationTeamResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesSubCooperationTeamResponse> IndustryManufactureMesSubCooperationTeamWithOptionsAsync(IndustryManufactureMesSubCooperationTeamRequest request, IndustryManufactureMesSubCooperationTeamHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupPlugins))
            {
                body["groupPlugins"] = request.GroupPlugins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Leaders))
            {
                body["leaders"] = request.Leaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutCorpId))
            {
                body["outCorpId"] = request.OutCorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIds))
            {
                body["processIds"] = request.ProcessIds;
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
                Action = "IndustryManufactureMesSubCooperationTeam",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturings/outTeams/manage",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesSubCooperationTeamResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesSubCooperationTeamResponse IndustryManufactureMesSubCooperationTeam(IndustryManufactureMesSubCooperationTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesSubCooperationTeamHeaders headers = new IndustryManufactureMesSubCooperationTeamHeaders();
            return IndustryManufactureMesSubCooperationTeamWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesSubCooperationTeamResponse> IndustryManufactureMesSubCooperationTeamAsync(IndustryManufactureMesSubCooperationTeamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesSubCooperationTeamHeaders headers = new IndustryManufactureMesSubCooperationTeamHeaders();
            return await IndustryManufactureMesSubCooperationTeamWithOptionsAsync(request, headers, runtime);
        }

        public IndustryManufactureMesTeamMgmtResponse IndustryManufactureMesTeamMgmtWithOptions(IndustryManufactureMesTeamMgmtRequest request, IndustryManufactureMesTeamMgmtHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupConfig))
            {
                body["groupConfig"] = request.GroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupPlugins))
            {
                body["groupPlugins"] = request.GroupPlugins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Leaders))
            {
                body["leaders"] = request.Leaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIds))
            {
                body["processIds"] = request.ProcessIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["tagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValues))
            {
                body["tagValues"] = request.TagValues;
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
                Action = "IndustryManufactureMesTeamMgmt",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturing/base/data/team",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesTeamMgmtResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryManufactureMesTeamMgmtResponse> IndustryManufactureMesTeamMgmtWithOptionsAsync(IndustryManufactureMesTeamMgmtRequest request, IndustryManufactureMesTeamMgmtHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppKey))
            {
                body["appKey"] = request.AppKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseDataName))
            {
                body["baseDataName"] = request.BaseDataName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Events))
            {
                body["events"] = request.Events;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendData))
            {
                body["extendData"] = request.ExtendData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupConfig))
            {
                body["groupConfig"] = request.GroupConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupPlugins))
            {
                body["groupPlugins"] = request.GroupPlugins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                body["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Leaders))
            {
                body["leaders"] = request.Leaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Members))
            {
                body["members"] = request.Members;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIds))
            {
                body["processIds"] = request.ProcessIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                body["tagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValues))
            {
                body["tagValues"] = request.TagValues;
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
                Action = "IndustryManufactureMesTeamMgmt",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufacturing/base/data/team",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryManufactureMesTeamMgmtResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryManufactureMesTeamMgmtResponse IndustryManufactureMesTeamMgmt(IndustryManufactureMesTeamMgmtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesTeamMgmtHeaders headers = new IndustryManufactureMesTeamMgmtHeaders();
            return IndustryManufactureMesTeamMgmtWithOptions(request, headers, runtime);
        }

        public async Task<IndustryManufactureMesTeamMgmtResponse> IndustryManufactureMesTeamMgmtAsync(IndustryManufactureMesTeamMgmtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryManufactureMesTeamMgmtHeaders headers = new IndustryManufactureMesTeamMgmtHeaders();
            return await IndustryManufactureMesTeamMgmtWithOptionsAsync(request, headers, runtime);
        }

        public IndustryMmanufactureMaterialCostGetResponse IndustryMmanufactureMaterialCostGetWithOptions(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryMmanufactureMaterialCostGet",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/base/materialCosts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryMmanufactureMaterialCostGetResponse>(Execute(params_, req, runtime));
        }

        public async Task<IndustryMmanufactureMaterialCostGetResponse> IndustryMmanufactureMaterialCostGetWithOptionsAsync(IndustryMmanufactureMaterialCostGetRequest request, IndustryMmanufactureMaterialCostGetHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                body["appIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                body["appName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorpId))
            {
                body["corpId"] = request.CorpId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                body["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsvOrgId))
            {
                body["isvOrgId"] = request.IsvOrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaterialNo))
            {
                body["materialNo"] = request.MaterialNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroappAgentId))
            {
                body["microappAgentId"] = request.MicroappAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrgId))
            {
                body["orgId"] = request.OrgId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuiteKey))
            {
                body["suiteKey"] = request.SuiteKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenGrantType))
            {
                body["tokenGrantType"] = request.TokenGrantType;
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
                Action = "IndustryMmanufactureMaterialCostGet",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/manufactures/base/materialCosts/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<IndustryMmanufactureMaterialCostGetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public IndustryMmanufactureMaterialCostGetResponse IndustryMmanufactureMaterialCostGet(IndustryMmanufactureMaterialCostGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
            return IndustryMmanufactureMaterialCostGetWithOptions(request, headers, runtime);
        }

        public async Task<IndustryMmanufactureMaterialCostGetResponse> IndustryMmanufactureMaterialCostGetAsync(IndustryMmanufactureMaterialCostGetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            IndustryMmanufactureMaterialCostGetHeaders headers = new IndustryMmanufactureMaterialCostGetHeaders();
            return await IndustryMmanufactureMaterialCostGetWithOptionsAsync(request, headers, runtime);
        }

        public PushDingMessageResponse PushDingMessageWithOptions(PushDingMessageRequest request, PushDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageUrl))
            {
                body["messageUrl"] = request.MessageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureUrl))
            {
                body["pictureUrl"] = request.PictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleTitle))
            {
                body["singleTitle"] = request.SingleTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleUrl))
            {
                body["singleUrl"] = request.SingleUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "PushDingMessage",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/works/notice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDingMessageResponse>(Execute(params_, req, runtime));
        }

        public async Task<PushDingMessageResponse> PushDingMessageWithOptionsAsync(PushDingMessageRequest request, PushDingMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                body["appId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageUrl))
            {
                body["messageUrl"] = request.MessageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PictureUrl))
            {
                body["pictureUrl"] = request.PictureUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleTitle))
            {
                body["singleTitle"] = request.SingleTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SingleUrl))
            {
                body["singleUrl"] = request.SingleUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                body["userIdList"] = request.UserIdList;
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
                Action = "PushDingMessage",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/works/notice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDingMessageResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PushDingMessageResponse PushDingMessage(PushDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushDingMessageHeaders headers = new PushDingMessageHeaders();
            return PushDingMessageWithOptions(request, headers, runtime);
        }

        public async Task<PushDingMessageResponse> PushDingMessageAsync(PushDingMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushDingMessageHeaders headers = new PushDingMessageHeaders();
            return await PushDingMessageWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllDepartmentResponse QueryAllDepartmentWithOptions(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllDepartment",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllDepartmentResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryAllDepartmentResponse> QueryAllDepartmentWithOptionsAsync(QueryAllDepartmentRequest request, QueryAllDepartmentHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllDepartment",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllDepartmentResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryAllDepartmentResponse QueryAllDepartment(QueryAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
            return QueryAllDepartmentWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllDepartmentResponse> QueryAllDepartmentAsync(QueryAllDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDepartmentHeaders headers = new QueryAllDepartmentHeaders();
            return await QueryAllDepartmentWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllDoctorsResponse QueryAllDoctorsWithOptions(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllDoctors",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/doctors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllDoctorsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryAllDoctorsResponse> QueryAllDoctorsWithOptionsAsync(QueryAllDoctorsRequest request, QueryAllDoctorsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllDoctors",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/doctors",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllDoctorsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryAllDoctorsResponse QueryAllDoctors(QueryAllDoctorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
            return QueryAllDoctorsWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllDoctorsResponse> QueryAllDoctorsAsync(QueryAllDoctorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllDoctorsHeaders headers = new QueryAllDoctorsHeaders();
            return await QueryAllDoctorsWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllGroupResponse QueryAllGroupWithOptions(QueryAllGroupRequest request, QueryAllGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryAllGroupResponse> QueryAllGroupWithOptionsAsync(QueryAllGroupRequest request, QueryAllGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryAllGroupResponse QueryAllGroup(QueryAllGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
            return QueryAllGroupWithOptions(request, headers, runtime);
        }

        public async Task<QueryAllGroupResponse> QueryAllGroupAsync(QueryAllGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupHeaders headers = new QueryAllGroupHeaders();
            return await QueryAllGroupWithOptionsAsync(request, headers, runtime);
        }

        public QueryAllGroupsInDeptResponse QueryAllGroupsInDeptWithOptions(string deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllGroupsInDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/" + deptId + "/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryAllGroupsInDeptResponse> QueryAllGroupsInDeptWithOptionsAsync(string deptId, QueryAllGroupsInDeptRequest request, QueryAllGroupsInDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllGroupsInDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/" + deptId + "/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllGroupsInDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryAllGroupsInDeptResponse QueryAllGroupsInDept(string deptId, QueryAllGroupsInDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
            return QueryAllGroupsInDeptWithOptions(deptId, request, headers, runtime);
        }

        public async Task<QueryAllGroupsInDeptResponse> QueryAllGroupsInDeptAsync(string deptId, QueryAllGroupsInDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllGroupsInDeptHeaders headers = new QueryAllGroupsInDeptHeaders();
            return await QueryAllGroupsInDeptWithOptionsAsync(deptId, request, headers, runtime);
        }

        public QueryAllMemberByDeptResponse QueryAllMemberByDeptWithOptions(string deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllMemberByDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/" + deptId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllMemberByDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryAllMemberByDeptResponse> QueryAllMemberByDeptWithOptionsAsync(string deptId, QueryAllMemberByDeptRequest request, QueryAllMemberByDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllMemberByDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/" + deptId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllMemberByDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryAllMemberByDeptResponse QueryAllMemberByDept(string deptId, QueryAllMemberByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
            return QueryAllMemberByDeptWithOptions(deptId, request, headers, runtime);
        }

        public async Task<QueryAllMemberByDeptResponse> QueryAllMemberByDeptAsync(string deptId, QueryAllMemberByDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByDeptHeaders headers = new QueryAllMemberByDeptHeaders();
            return await QueryAllMemberByDeptWithOptionsAsync(deptId, request, headers, runtime);
        }

        public QueryAllMemberByGroupResponse QueryAllMemberByGroupWithOptions(string groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllMemberByGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/groups/" + groupId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryAllMemberByGroupResponse> QueryAllMemberByGroupWithOptionsAsync(string groupId, QueryAllMemberByGroupRequest request, QueryAllMemberByGroupHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryAllMemberByGroup",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/groups/" + groupId + "/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllMemberByGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryAllMemberByGroupResponse QueryAllMemberByGroup(string groupId, QueryAllMemberByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
            return QueryAllMemberByGroupWithOptions(groupId, request, headers, runtime);
        }

        public async Task<QueryAllMemberByGroupResponse> QueryAllMemberByGroupAsync(string groupId, QueryAllMemberByGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryAllMemberByGroupHeaders headers = new QueryAllMemberByGroupHeaders();
            return await QueryAllMemberByGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        public QueryBizOptLogResponse QueryBizOptLogWithOptions(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryBizOptLog",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/bizOptLogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizOptLogResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryBizOptLogResponse> QueryBizOptLogWithOptionsAsync(QueryBizOptLogRequest request, QueryBizOptLogHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
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
                Action = "QueryBizOptLog",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/bizOptLogs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBizOptLogResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryBizOptLogResponse QueryBizOptLog(QueryBizOptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
            return QueryBizOptLogWithOptions(request, headers, runtime);
        }

        public async Task<QueryBizOptLogResponse> QueryBizOptLogAsync(QueryBizOptLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryBizOptLogHeaders headers = new QueryBizOptLogHeaders();
            return await QueryBizOptLogWithOptionsAsync(request, headers, runtime);
        }

        public QueryDepartmentExtendInfoResponse QueryDepartmentExtendInfoWithOptions(QueryDepartmentExtendInfoRequest request, QueryDepartmentExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropCode))
            {
                query["propCode"] = request.PropCode;
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
                Action = "QueryDepartmentExtendInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/extensions/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDepartmentExtendInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryDepartmentExtendInfoResponse> QueryDepartmentExtendInfoWithOptionsAsync(QueryDepartmentExtendInfoRequest request, QueryDepartmentExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptCode))
            {
                query["deptCode"] = request.DeptCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PropCode))
            {
                query["propCode"] = request.PropCode;
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
                Action = "QueryDepartmentExtendInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/extensions/infos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDepartmentExtendInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryDepartmentExtendInfoResponse QueryDepartmentExtendInfo(QueryDepartmentExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentExtendInfoHeaders headers = new QueryDepartmentExtendInfoHeaders();
            return QueryDepartmentExtendInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryDepartmentExtendInfoResponse> QueryDepartmentExtendInfoAsync(QueryDepartmentExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentExtendInfoHeaders headers = new QueryDepartmentExtendInfoHeaders();
            return await QueryDepartmentExtendInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryDepartmentInfoResponse QueryDepartmentInfoWithOptions(string deptId, QueryDepartmentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDepartmentInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/" + deptId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryDepartmentInfoResponse> QueryDepartmentInfoWithOptionsAsync(string deptId, QueryDepartmentInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryDepartmentInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/departments/" + deptId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDepartmentInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryDepartmentInfoResponse QueryDepartmentInfo(string deptId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
            return QueryDepartmentInfoWithOptions(deptId, headers, runtime);
        }

        public async Task<QueryDepartmentInfoResponse> QueryDepartmentInfoAsync(string deptId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDepartmentInfoHeaders headers = new QueryDepartmentInfoHeaders();
            return await QueryDepartmentInfoWithOptionsAsync(deptId, headers, runtime);
        }

        public QueryDoctorDetailsByJobNumberResponse QueryDoctorDetailsByJobNumberWithOptions(string jobNumber, QueryDoctorDetailsByJobNumberRequest request, QueryDoctorDetailsByJobNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
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
                Action = "QueryDoctorDetailsByJobNumber",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/doctors/" + jobNumber,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDoctorDetailsByJobNumberResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryDoctorDetailsByJobNumberResponse> QueryDoctorDetailsByJobNumberWithOptionsAsync(string jobNumber, QueryDoctorDetailsByJobNumberRequest request, QueryDoctorDetailsByJobNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
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
                Action = "QueryDoctorDetailsByJobNumber",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/doctors/" + jobNumber,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDoctorDetailsByJobNumberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryDoctorDetailsByJobNumberResponse QueryDoctorDetailsByJobNumber(string jobNumber, QueryDoctorDetailsByJobNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDoctorDetailsByJobNumberHeaders headers = new QueryDoctorDetailsByJobNumberHeaders();
            return QueryDoctorDetailsByJobNumberWithOptions(jobNumber, request, headers, runtime);
        }

        public async Task<QueryDoctorDetailsByJobNumberResponse> QueryDoctorDetailsByJobNumberAsync(string jobNumber, QueryDoctorDetailsByJobNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryDoctorDetailsByJobNumberHeaders headers = new QueryDoctorDetailsByJobNumberHeaders();
            return await QueryDoctorDetailsByJobNumberWithOptionsAsync(jobNumber, request, headers, runtime);
        }

        public QueryGroupInfoResponse QueryGroupInfoWithOptions(string groupId, QueryGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryGroupInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/groups/" + groupId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryGroupInfoResponse> QueryGroupInfoWithOptionsAsync(string groupId, QueryGroupInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryGroupInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/groups/" + groupId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryGroupInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryGroupInfoResponse QueryGroupInfo(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
            return QueryGroupInfoWithOptions(groupId, headers, runtime);
        }

        public async Task<QueryGroupInfoResponse> QueryGroupInfoAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryGroupInfoHeaders headers = new QueryGroupInfoHeaders();
            return await QueryGroupInfoWithOptionsAsync(groupId, headers, runtime);
        }

        public QueryHospitalDistrictInfoResponse QueryHospitalDistrictInfoWithOptions(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryHospitalDistrictInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/districts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHospitalDistrictInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryHospitalDistrictInfoResponse> QueryHospitalDistrictInfoWithOptionsAsync(QueryHospitalDistrictInfoRequest request, QueryHospitalDistrictInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryHospitalDistrictInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/districts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHospitalDistrictInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryHospitalDistrictInfoResponse QueryHospitalDistrictInfo(QueryHospitalDistrictInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
            return QueryHospitalDistrictInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryHospitalDistrictInfoResponse> QueryHospitalDistrictInfoAsync(QueryHospitalDistrictInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalDistrictInfoHeaders headers = new QueryHospitalDistrictInfoHeaders();
            return await QueryHospitalDistrictInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryHospitalRoleUserInfoResponse QueryHospitalRoleUserInfoWithOptions(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryHospitalRoleUserInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/roles/userInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHospitalRoleUserInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryHospitalRoleUserInfoResponse> QueryHospitalRoleUserInfoWithOptionsAsync(QueryHospitalRoleUserInfoRequest request, QueryHospitalRoleUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
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
                Action = "QueryHospitalRoleUserInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/roles/userInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHospitalRoleUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryHospitalRoleUserInfoResponse QueryHospitalRoleUserInfo(QueryHospitalRoleUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
            return QueryHospitalRoleUserInfoWithOptions(request, headers, runtime);
        }

        public async Task<QueryHospitalRoleUserInfoResponse> QueryHospitalRoleUserInfoAsync(QueryHospitalRoleUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRoleUserInfoHeaders headers = new QueryHospitalRoleUserInfoHeaders();
            return await QueryHospitalRoleUserInfoWithOptionsAsync(request, headers, runtime);
        }

        public QueryHospitalRolesResponse QueryHospitalRolesWithOptions(QueryHospitalRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryHospitalRoles",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHospitalRolesResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryHospitalRolesResponse> QueryHospitalRolesWithOptionsAsync(QueryHospitalRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryHospitalRoles",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryHospitalRolesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryHospitalRolesResponse QueryHospitalRoles()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
            return QueryHospitalRolesWithOptions(headers, runtime);
        }

        public async Task<QueryHospitalRolesResponse> QueryHospitalRolesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryHospitalRolesHeaders headers = new QueryHospitalRolesHeaders();
            return await QueryHospitalRolesWithOptionsAsync(headers, runtime);
        }

        public QueryJobCodeDictionaryResponse QueryJobCodeDictionaryWithOptions(QueryJobCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryJobCodeDictionary",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/jobCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobCodeDictionaryResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryJobCodeDictionaryResponse> QueryJobCodeDictionaryWithOptionsAsync(QueryJobCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryJobCodeDictionary",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/jobCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobCodeDictionaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryJobCodeDictionaryResponse QueryJobCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
            return QueryJobCodeDictionaryWithOptions(headers, runtime);
        }

        public async Task<QueryJobCodeDictionaryResponse> QueryJobCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobCodeDictionaryHeaders headers = new QueryJobCodeDictionaryHeaders();
            return await QueryJobCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        public QueryJobStatusCodeDictionaryResponse QueryJobStatusCodeDictionaryWithOptions(QueryJobStatusCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryJobStatusCodeDictionary",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/jobStatusCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobStatusCodeDictionaryResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryJobStatusCodeDictionaryResponse> QueryJobStatusCodeDictionaryWithOptionsAsync(QueryJobStatusCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryJobStatusCodeDictionary",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/jobStatusCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryJobStatusCodeDictionaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryJobStatusCodeDictionaryResponse QueryJobStatusCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
            return QueryJobStatusCodeDictionaryWithOptions(headers, runtime);
        }

        public async Task<QueryJobStatusCodeDictionaryResponse> QueryJobStatusCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryJobStatusCodeDictionaryHeaders headers = new QueryJobStatusCodeDictionaryHeaders();
            return await QueryJobStatusCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        public QueryMedicalEventsResponse QueryMedicalEventsWithOptions(QueryMedicalEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMedicalEvents",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMedicalEventsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryMedicalEventsResponse> QueryMedicalEventsWithOptionsAsync(QueryMedicalEventsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryMedicalEvents",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMedicalEventsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryMedicalEventsResponse QueryMedicalEvents()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
            return QueryMedicalEventsWithOptions(headers, runtime);
        }

        public async Task<QueryMedicalEventsResponse> QueryMedicalEventsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryMedicalEventsHeaders headers = new QueryMedicalEventsHeaders();
            return await QueryMedicalEventsWithOptionsAsync(headers, runtime);
        }

        public QueryUserCredentialsResponse QueryUserCredentialsWithOptions(QueryUserCredentialsRequest request, QueryUserCredentialsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "QueryUserCredentials",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/credentials/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserCredentialsResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserCredentialsResponse> QueryUserCredentialsWithOptionsAsync(QueryUserCredentialsRequest request, QueryUserCredentialsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "QueryUserCredentials",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/credentials/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserCredentialsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserCredentialsResponse QueryUserCredentials(QueryUserCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
            return QueryUserCredentialsWithOptions(request, headers, runtime);
        }

        public async Task<QueryUserCredentialsResponse> QueryUserCredentialsAsync(QueryUserCredentialsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserCredentialsHeaders headers = new QueryUserCredentialsHeaders();
            return await QueryUserCredentialsWithOptionsAsync(request, headers, runtime);
        }

        public QueryUserExtInfoResponse QueryUserExtInfoWithOptions(string userId, QueryUserExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserExtInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/extInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserExtInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserExtInfoResponse> QueryUserExtInfoWithOptionsAsync(string userId, QueryUserExtInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserExtInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/extInfos",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserExtInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserExtInfoResponse QueryUserExtInfo(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
            return QueryUserExtInfoWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserExtInfoResponse> QueryUserExtInfoAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtInfoHeaders headers = new QueryUserExtInfoHeaders();
            return await QueryUserExtInfoWithOptionsAsync(userId, headers, runtime);
        }

        public QueryUserExtendValuesResponse QueryUserExtendValuesWithOptions(QueryUserExtendValuesRequest request, QueryUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                body["userExtendKey"] = request.UserExtendKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "QueryUserExtendValues",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/extends/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserExtendValuesResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserExtendValuesResponse> QueryUserExtendValuesWithOptionsAsync(QueryUserExtendValuesRequest request, QueryUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                body["userExtendKey"] = request.UserExtendKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIds))
            {
                body["userIds"] = request.UserIds;
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
                Action = "QueryUserExtendValues",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/extends/query",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserExtendValuesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserExtendValuesResponse QueryUserExtendValues(QueryUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
            return QueryUserExtendValuesWithOptions(request, headers, runtime);
        }

        public async Task<QueryUserExtendValuesResponse> QueryUserExtendValuesAsync(QueryUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserExtendValuesHeaders headers = new QueryUserExtendValuesHeaders();
            return await QueryUserExtendValuesWithOptionsAsync(request, headers, runtime);
        }

        public QueryUserInfoResponse QueryUserInfoWithOptions(string userId, QueryUserInfoRequest request, QueryUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
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
                Action = "QueryUserInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserInfoResponse> QueryUserInfoWithOptionsAsync(string userId, QueryUserInfoRequest request, QueryUserInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonthMark))
            {
                query["monthMark"] = request.MonthMark;
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
                Action = "QueryUserInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserInfoResponse QueryUserInfo(string userId, QueryUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return QueryUserInfoWithOptions(userId, request, headers, runtime);
        }

        public async Task<QueryUserInfoResponse> QueryUserInfoAsync(string userId, QueryUserInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserInfoHeaders headers = new QueryUserInfoHeaders();
            return await QueryUserInfoWithOptionsAsync(userId, request, headers, runtime);
        }

        public QueryUserProbCodeDictionaryResponse QueryUserProbCodeDictionaryWithOptions(QueryUserProbCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserProbCodeDictionary",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/userProbCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserProbCodeDictionaryResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserProbCodeDictionaryResponse> QueryUserProbCodeDictionaryWithOptionsAsync(QueryUserProbCodeDictionaryHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserProbCodeDictionary",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/userProbCodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserProbCodeDictionaryResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserProbCodeDictionaryResponse QueryUserProbCodeDictionary()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
            return QueryUserProbCodeDictionaryWithOptions(headers, runtime);
        }

        public async Task<QueryUserProbCodeDictionaryResponse> QueryUserProbCodeDictionaryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserProbCodeDictionaryHeaders headers = new QueryUserProbCodeDictionaryHeaders();
            return await QueryUserProbCodeDictionaryWithOptionsAsync(headers, runtime);
        }

        public QueryUserRolesResponse QueryUserRolesWithOptions(string userId, QueryUserRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserRoles",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserRolesResponse>(Execute(params_, req, runtime));
        }

        public async Task<QueryUserRolesResponse> QueryUserRolesWithOptionsAsync(string userId, QueryUserRolesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "QueryUserRoles",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryUserRolesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public QueryUserRolesResponse QueryUserRoles(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
            return QueryUserRolesWithOptions(userId, headers, runtime);
        }

        public async Task<QueryUserRolesResponse> QueryUserRolesAsync(string userId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            QueryUserRolesHeaders headers = new QueryUserRolesHeaders();
            return await QueryUserRolesWithOptionsAsync(userId, headers, runtime);
        }

        public SaveUserExtendValuesResponse SaveUserExtendValuesWithOptions(string userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDisplayName))
            {
                query["userDisplayName"] = request.UserDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                query["userExtendKey"] = request.UserExtendKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendValue))
            {
                query["userExtendValue"] = request.UserExtendValue;
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
                Action = "SaveUserExtendValues",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/extends",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveUserExtendValuesResponse>(Execute(params_, req, runtime));
        }

        public async Task<SaveUserExtendValuesResponse> SaveUserExtendValuesWithOptionsAsync(string userId, SaveUserExtendValuesRequest request, SaveUserExtendValuesHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserDisplayName))
            {
                query["userDisplayName"] = request.UserDisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendKey))
            {
                query["userExtendKey"] = request.UserExtendKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserExtendValue))
            {
                query["userExtendValue"] = request.UserExtendValue;
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
                Action = "SaveUserExtendValues",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/extends",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveUserExtendValuesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SaveUserExtendValuesResponse SaveUserExtendValues(string userId, SaveUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
            return SaveUserExtendValuesWithOptions(userId, request, headers, runtime);
        }

        public async Task<SaveUserExtendValuesResponse> SaveUserExtendValuesAsync(string userId, SaveUserExtendValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SaveUserExtendValuesHeaders headers = new SaveUserExtendValuesHeaders();
            return await SaveUserExtendValuesWithOptionsAsync(userId, request, headers, runtime);
        }

        public SupplAddRoleResponse SupplAddRoleWithOptions(SupplAddRoleRequest request, SupplAddRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentRoleGroupId))
            {
                query["parentRoleGroupId"] = request.ParentRoleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["roleName"] = request.RoleName;
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
                Action = "SupplAddRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplAddRoleResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplAddRoleResponse> SupplAddRoleWithOptionsAsync(SupplAddRoleRequest request, SupplAddRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentRoleGroupId))
            {
                query["parentRoleGroupId"] = request.ParentRoleGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["roleName"] = request.RoleName;
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
                Action = "SupplAddRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplAddRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplAddRoleResponse SupplAddRole(SupplAddRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplAddRoleHeaders headers = new SupplAddRoleHeaders();
            return SupplAddRoleWithOptions(request, headers, runtime);
        }

        public async Task<SupplAddRoleResponse> SupplAddRoleAsync(SupplAddRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplAddRoleHeaders headers = new SupplAddRoleHeaders();
            return await SupplAddRoleWithOptionsAsync(request, headers, runtime);
        }

        public SupplyAddDeptResponse SupplyAddDeptWithOptions(SupplyAddDeptRequest request, SupplyAddDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                query["deptName"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNumber))
            {
                query["partnerNumber"] = request.PartnerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperDeptId))
            {
                query["superDeptId"] = request.SuperDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptType))
            {
                query["supplyDeptType"] = request.SupplyDeptType;
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
                Action = "SupplyAddDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyAddDeptResponse> SupplyAddDeptWithOptionsAsync(SupplyAddDeptRequest request, SupplyAddDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptName))
            {
                query["deptName"] = request.DeptName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNumber))
            {
                query["partnerNumber"] = request.PartnerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperDeptId))
            {
                query["superDeptId"] = request.SuperDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptType))
            {
                query["supplyDeptType"] = request.SupplyDeptType;
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
                Action = "SupplyAddDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyAddDeptResponse SupplyAddDept(SupplyAddDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddDeptHeaders headers = new SupplyAddDeptHeaders();
            return SupplyAddDeptWithOptions(request, headers, runtime);
        }

        public async Task<SupplyAddDeptResponse> SupplyAddDeptAsync(SupplyAddDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddDeptHeaders headers = new SupplyAddDeptHeaders();
            return await SupplyAddDeptWithOptionsAsync(request, headers, runtime);
        }

        public SupplyAddMemberResponse SupplyAddMemberWithOptions(SupplyAddMemberRequest request, SupplyAddMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPartnerManager))
            {
                query["isPartnerManager"] = request.IsPartnerManager;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberMobile))
            {
                query["memberMobile"] = request.MemberMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["memberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberTitle))
            {
                query["memberTitle"] = request.MemberTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberWorkNumber))
            {
                query["memberWorkNumber"] = request.MemberWorkNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyAddMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyAddMemberResponse> SupplyAddMemberWithOptionsAsync(SupplyAddMemberRequest request, SupplyAddMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPartnerManager))
            {
                query["isPartnerManager"] = request.IsPartnerManager;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberMobile))
            {
                query["memberMobile"] = request.MemberMobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["memberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberTitle))
            {
                query["memberTitle"] = request.MemberTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberWorkNumber))
            {
                query["memberWorkNumber"] = request.MemberWorkNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyAddMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyAddMemberResponse SupplyAddMember(SupplyAddMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddMemberHeaders headers = new SupplyAddMemberHeaders();
            return SupplyAddMemberWithOptions(request, headers, runtime);
        }

        public async Task<SupplyAddMemberResponse> SupplyAddMemberAsync(SupplyAddMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddMemberHeaders headers = new SupplyAddMemberHeaders();
            return await SupplyAddMemberWithOptionsAsync(request, headers, runtime);
        }

        public SupplyAddPartnerAdminsResponse SupplyAddPartnerAdminsWithOptions(SupplyAddPartnerAdminsRequest request, SupplyAddPartnerAdminsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
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
                Action = "SupplyAddPartnerAdmins",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerAdministrators",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddPartnerAdminsResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyAddPartnerAdminsResponse> SupplyAddPartnerAdminsWithOptionsAsync(SupplyAddPartnerAdminsRequest request, SupplyAddPartnerAdminsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
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
                Action = "SupplyAddPartnerAdmins",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerAdministrators",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddPartnerAdminsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyAddPartnerAdminsResponse SupplyAddPartnerAdmins(SupplyAddPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerAdminsHeaders headers = new SupplyAddPartnerAdminsHeaders();
            return SupplyAddPartnerAdminsWithOptions(request, headers, runtime);
        }

        public async Task<SupplyAddPartnerAdminsResponse> SupplyAddPartnerAdminsAsync(SupplyAddPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerAdminsHeaders headers = new SupplyAddPartnerAdminsHeaders();
            return await SupplyAddPartnerAdminsWithOptionsAsync(request, headers, runtime);
        }

        public SupplyAddPartnerManagersResponse SupplyAddPartnerManagersWithOptions(SupplyAddPartnerManagersRequest request, SupplyAddPartnerManagersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceId))
            {
                query["interfaceId"] = request.InterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceType))
            {
                query["interfaceType"] = request.InterfaceType;
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
                Action = "SupplyAddPartnerManagers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerInterfaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddPartnerManagersResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyAddPartnerManagersResponse> SupplyAddPartnerManagersWithOptionsAsync(SupplyAddPartnerManagersRequest request, SupplyAddPartnerManagersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceId))
            {
                query["interfaceId"] = request.InterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceType))
            {
                query["interfaceType"] = request.InterfaceType;
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
                Action = "SupplyAddPartnerManagers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerInterfaces",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddPartnerManagersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyAddPartnerManagersResponse SupplyAddPartnerManagers(SupplyAddPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerManagersHeaders headers = new SupplyAddPartnerManagersHeaders();
            return SupplyAddPartnerManagersWithOptions(request, headers, runtime);
        }

        public async Task<SupplyAddPartnerManagersResponse> SupplyAddPartnerManagersAsync(SupplyAddPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerManagersHeaders headers = new SupplyAddPartnerManagersHeaders();
            return await SupplyAddPartnerManagersWithOptionsAsync(request, headers, runtime);
        }

        public SupplyAddPartnerTypeResponse SupplyAddPartnerTypeWithOptions(SupplyAddPartnerTypeRequest request, SupplyAddPartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "SupplyAddPartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddPartnerTypeResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyAddPartnerTypeResponse> SupplyAddPartnerTypeWithOptionsAsync(SupplyAddPartnerTypeRequest request, SupplyAddPartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "SupplyAddPartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyAddPartnerTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyAddPartnerTypeResponse SupplyAddPartnerType(SupplyAddPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerTypeHeaders headers = new SupplyAddPartnerTypeHeaders();
            return SupplyAddPartnerTypeWithOptions(request, headers, runtime);
        }

        public async Task<SupplyAddPartnerTypeResponse> SupplyAddPartnerTypeAsync(SupplyAddPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyAddPartnerTypeHeaders headers = new SupplyAddPartnerTypeHeaders();
            return await SupplyAddPartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        public SupplyChainDeleteDeptResponse SupplyChainDeleteDeptWithOptions(SupplyChainDeleteDeptRequest request, SupplyChainDeleteDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyChainDeleteDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyChainDeleteDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyChainDeleteDeptResponse> SupplyChainDeleteDeptWithOptionsAsync(SupplyChainDeleteDeptRequest request, SupplyChainDeleteDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyChainDeleteDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyChainDeleteDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyChainDeleteDeptResponse SupplyChainDeleteDept(SupplyChainDeleteDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainDeleteDeptHeaders headers = new SupplyChainDeleteDeptHeaders();
            return SupplyChainDeleteDeptWithOptions(request, headers, runtime);
        }

        public async Task<SupplyChainDeleteDeptResponse> SupplyChainDeleteDeptAsync(SupplyChainDeleteDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainDeleteDeptHeaders headers = new SupplyChainDeleteDeptHeaders();
            return await SupplyChainDeleteDeptWithOptionsAsync(request, headers, runtime);
        }

        public SupplyChainQueryDeptInfoResponse SupplyChainQueryDeptInfoWithOptions(SupplyChainQueryDeptInfoRequest request, SupplyChainQueryDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyChainQueryDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyChainQueryDeptInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyChainQueryDeptInfoResponse> SupplyChainQueryDeptInfoWithOptionsAsync(SupplyChainQueryDeptInfoRequest request, SupplyChainQueryDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyChainQueryDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyChainQueryDeptInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyChainQueryDeptInfoResponse SupplyChainQueryDeptInfo(SupplyChainQueryDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainQueryDeptInfoHeaders headers = new SupplyChainQueryDeptInfoHeaders();
            return SupplyChainQueryDeptInfoWithOptions(request, headers, runtime);
        }

        public async Task<SupplyChainQueryDeptInfoResponse> SupplyChainQueryDeptInfoAsync(SupplyChainQueryDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainQueryDeptInfoHeaders headers = new SupplyChainQueryDeptInfoHeaders();
            return await SupplyChainQueryDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        public SupplyChainUpdateDeptInfoResponse SupplyChainUpdateDeptInfoWithOptions(SupplyChainUpdateDeptInfoRequest request, SupplyChainUpdateDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNumber))
            {
                body["partnerNumber"] = request.PartnerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerTypeList))
            {
                body["partnerTypeList"] = request.PartnerTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                body["superId"] = request.SuperId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                body["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyChainUpdateDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyChainUpdateDeptInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyChainUpdateDeptInfoResponse> SupplyChainUpdateDeptInfoWithOptionsAsync(SupplyChainUpdateDeptInfoRequest request, SupplyChainUpdateDeptInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerNumber))
            {
                body["partnerNumber"] = request.PartnerNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerTypeList))
            {
                body["partnerTypeList"] = request.PartnerTypeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                body["superId"] = request.SuperId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                body["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyChainUpdateDeptInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyChainUpdateDeptInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyChainUpdateDeptInfoResponse SupplyChainUpdateDeptInfo(SupplyChainUpdateDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainUpdateDeptInfoHeaders headers = new SupplyChainUpdateDeptInfoHeaders();
            return SupplyChainUpdateDeptInfoWithOptions(request, headers, runtime);
        }

        public async Task<SupplyChainUpdateDeptInfoResponse> SupplyChainUpdateDeptInfoAsync(SupplyChainUpdateDeptInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyChainUpdateDeptInfoHeaders headers = new SupplyChainUpdateDeptInfoHeaders();
            return await SupplyChainUpdateDeptInfoWithOptionsAsync(request, headers, runtime);
        }

        public SupplyDeleteMemberResponse SupplyDeleteMemberWithOptions(SupplyDeleteMemberRequest request, SupplyDeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
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
                Action = "SupplyDeleteMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeleteMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyDeleteMemberResponse> SupplyDeleteMemberWithOptionsAsync(SupplyDeleteMemberRequest request, SupplyDeleteMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
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
                Action = "SupplyDeleteMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeleteMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyDeleteMemberResponse SupplyDeleteMember(SupplyDeleteMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteMemberHeaders headers = new SupplyDeleteMemberHeaders();
            return SupplyDeleteMemberWithOptions(request, headers, runtime);
        }

        public async Task<SupplyDeleteMemberResponse> SupplyDeleteMemberAsync(SupplyDeleteMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteMemberHeaders headers = new SupplyDeleteMemberHeaders();
            return await SupplyDeleteMemberWithOptionsAsync(request, headers, runtime);
        }

        public SupplyDeletePartnerAdminsResponse SupplyDeletePartnerAdminsWithOptions(SupplyDeletePartnerAdminsRequest request, SupplyDeletePartnerAdminsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
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
                Action = "SupplyDeletePartnerAdmins",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerAdministrators",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeletePartnerAdminsResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyDeletePartnerAdminsResponse> SupplyDeletePartnerAdminsWithOptionsAsync(SupplyDeletePartnerAdminsRequest request, SupplyDeletePartnerAdminsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
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
                Action = "SupplyDeletePartnerAdmins",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerAdministrators",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeletePartnerAdminsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyDeletePartnerAdminsResponse SupplyDeletePartnerAdmins(SupplyDeletePartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerAdminsHeaders headers = new SupplyDeletePartnerAdminsHeaders();
            return SupplyDeletePartnerAdminsWithOptions(request, headers, runtime);
        }

        public async Task<SupplyDeletePartnerAdminsResponse> SupplyDeletePartnerAdminsAsync(SupplyDeletePartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerAdminsHeaders headers = new SupplyDeletePartnerAdminsHeaders();
            return await SupplyDeletePartnerAdminsWithOptionsAsync(request, headers, runtime);
        }

        public SupplyDeletePartnerManagersResponse SupplyDeletePartnerManagersWithOptions(SupplyDeletePartnerManagersRequest request, SupplyDeletePartnerManagersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceId))
            {
                query["interfaceId"] = request.InterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceType))
            {
                query["interfaceType"] = request.InterfaceType;
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
                Action = "SupplyDeletePartnerManagers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerInterfaces",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeletePartnerManagersResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyDeletePartnerManagersResponse> SupplyDeletePartnerManagersWithOptionsAsync(SupplyDeletePartnerManagersRequest request, SupplyDeletePartnerManagersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceId))
            {
                query["interfaceId"] = request.InterfaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterfaceType))
            {
                query["interfaceType"] = request.InterfaceType;
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
                Action = "SupplyDeletePartnerManagers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerInterfaces",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeletePartnerManagersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyDeletePartnerManagersResponse SupplyDeletePartnerManagers(SupplyDeletePartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerManagersHeaders headers = new SupplyDeletePartnerManagersHeaders();
            return SupplyDeletePartnerManagersWithOptions(request, headers, runtime);
        }

        public async Task<SupplyDeletePartnerManagersResponse> SupplyDeletePartnerManagersAsync(SupplyDeletePartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerManagersHeaders headers = new SupplyDeletePartnerManagersHeaders();
            return await SupplyDeletePartnerManagersWithOptionsAsync(request, headers, runtime);
        }

        public SupplyDeletePartnerTypeResponse SupplyDeletePartnerTypeWithOptions(SupplyDeletePartnerTypeRequest request, SupplyDeletePartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
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
                Action = "SupplyDeletePartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeletePartnerTypeResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyDeletePartnerTypeResponse> SupplyDeletePartnerTypeWithOptionsAsync(SupplyDeletePartnerTypeRequest request, SupplyDeletePartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
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
                Action = "SupplyDeletePartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeletePartnerTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyDeletePartnerTypeResponse SupplyDeletePartnerType(SupplyDeletePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerTypeHeaders headers = new SupplyDeletePartnerTypeHeaders();
            return SupplyDeletePartnerTypeWithOptions(request, headers, runtime);
        }

        public async Task<SupplyDeletePartnerTypeResponse> SupplyDeletePartnerTypeAsync(SupplyDeletePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeletePartnerTypeHeaders headers = new SupplyDeletePartnerTypeHeaders();
            return await SupplyDeletePartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        public SupplyDeleteRoleResponse SupplyDeleteRoleWithOptions(SupplyDeleteRoleRequest request, SupplyDeleteRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRoleGroup))
            {
                query["isRoleGroup"] = request.IsRoleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
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
                Action = "SupplyDeleteRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeleteRoleResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyDeleteRoleResponse> SupplyDeleteRoleWithOptionsAsync(SupplyDeleteRoleRequest request, SupplyDeleteRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRoleGroup))
            {
                query["isRoleGroup"] = request.IsRoleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
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
                Action = "SupplyDeleteRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyDeleteRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyDeleteRoleResponse SupplyDeleteRole(SupplyDeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteRoleHeaders headers = new SupplyDeleteRoleHeaders();
            return SupplyDeleteRoleWithOptions(request, headers, runtime);
        }

        public async Task<SupplyDeleteRoleResponse> SupplyDeleteRoleAsync(SupplyDeleteRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyDeleteRoleHeaders headers = new SupplyDeleteRoleHeaders();
            return await SupplyDeleteRoleWithOptionsAsync(request, headers, runtime);
        }

        public SupplyGetMemberResponse SupplyGetMemberWithOptions(SupplyGetMemberRequest request, SupplyGetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
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
                Action = "SupplyGetMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyGetMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyGetMemberResponse> SupplyGetMemberWithOptionsAsync(SupplyGetMemberRequest request, SupplyGetMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                query["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                query["unionId"] = request.UnionId;
            }
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
                Action = "SupplyGetMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyGetMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyGetMemberResponse SupplyGetMember(SupplyGetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyGetMemberHeaders headers = new SupplyGetMemberHeaders();
            return SupplyGetMemberWithOptions(request, headers, runtime);
        }

        public async Task<SupplyGetMemberResponse> SupplyGetMemberAsync(SupplyGetMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyGetMemberHeaders headers = new SupplyGetMemberHeaders();
            return await SupplyGetMemberWithOptionsAsync(request, headers, runtime);
        }

        public SupplyListDeptMembersResponse SupplyListDeptMembersWithOptions(SupplyListDeptMembersRequest request, SupplyListDeptMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyListDeptMembers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListDeptMembersResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyListDeptMembersResponse> SupplyListDeptMembersWithOptionsAsync(SupplyListDeptMembersRequest request, SupplyListDeptMembersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyListDeptMembers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/departments/members",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListDeptMembersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyListDeptMembersResponse SupplyListDeptMembers(SupplyListDeptMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListDeptMembersHeaders headers = new SupplyListDeptMembersHeaders();
            return SupplyListDeptMembersWithOptions(request, headers, runtime);
        }

        public async Task<SupplyListDeptMembersResponse> SupplyListDeptMembersAsync(SupplyListDeptMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListDeptMembersHeaders headers = new SupplyListDeptMembersHeaders();
            return await SupplyListDeptMembersWithOptionsAsync(request, headers, runtime);
        }

        public SupplyListPartnerAdminsResponse SupplyListPartnerAdminsWithOptions(SupplyListPartnerAdminsRequest request, SupplyListPartnerAdminsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "SupplyListPartnerAdmins",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerAdministrators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListPartnerAdminsResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyListPartnerAdminsResponse> SupplyListPartnerAdminsWithOptionsAsync(SupplyListPartnerAdminsRequest request, SupplyListPartnerAdminsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "SupplyListPartnerAdmins",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerAdministrators",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListPartnerAdminsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyListPartnerAdminsResponse SupplyListPartnerAdmins(SupplyListPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerAdminsHeaders headers = new SupplyListPartnerAdminsHeaders();
            return SupplyListPartnerAdminsWithOptions(request, headers, runtime);
        }

        public async Task<SupplyListPartnerAdminsResponse> SupplyListPartnerAdminsAsync(SupplyListPartnerAdminsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerAdminsHeaders headers = new SupplyListPartnerAdminsHeaders();
            return await SupplyListPartnerAdminsWithOptionsAsync(request, headers, runtime);
        }

        public SupplyListPartnerManagersResponse SupplyListPartnerManagersWithOptions(SupplyListPartnerManagersRequest request, SupplyListPartnerManagersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "SupplyListPartnerManagers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerInterfaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListPartnerManagersResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyListPartnerManagersResponse> SupplyListPartnerManagersWithOptionsAsync(SupplyListPartnerManagersRequest request, SupplyListPartnerManagersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeptId))
            {
                query["deptId"] = request.DeptId;
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
                Action = "SupplyListPartnerManagers",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerInterfaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListPartnerManagersResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyListPartnerManagersResponse SupplyListPartnerManagers(SupplyListPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerManagersHeaders headers = new SupplyListPartnerManagersHeaders();
            return SupplyListPartnerManagersWithOptions(request, headers, runtime);
        }

        public async Task<SupplyListPartnerManagersResponse> SupplyListPartnerManagersAsync(SupplyListPartnerManagersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerManagersHeaders headers = new SupplyListPartnerManagersHeaders();
            return await SupplyListPartnerManagersWithOptionsAsync(request, headers, runtime);
        }

        public SupplyListPartnerTypeResponse SupplyListPartnerTypeWithOptions(SupplyListPartnerTypeRequest request, SupplyListPartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
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
                Action = "SupplyListPartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels/subLabels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListPartnerTypeResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyListPartnerTypeResponse> SupplyListPartnerTypeWithOptionsAsync(SupplyListPartnerTypeRequest request, SupplyListPartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
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
                Action = "SupplyListPartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels/subLabels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListPartnerTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyListPartnerTypeResponse SupplyListPartnerType(SupplyListPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerTypeHeaders headers = new SupplyListPartnerTypeHeaders();
            return SupplyListPartnerTypeWithOptions(request, headers, runtime);
        }

        public async Task<SupplyListPartnerTypeResponse> SupplyListPartnerTypeAsync(SupplyListPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListPartnerTypeHeaders headers = new SupplyListPartnerTypeHeaders();
            return await SupplyListPartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        public SupplyListRoleResponse SupplyListRoleWithOptions(SupplyListRoleRequest request, SupplyListRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentRoleId))
            {
                query["parentRoleId"] = request.ParentRoleId;
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
                Action = "SupplyListRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListRoleResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyListRoleResponse> SupplyListRoleWithOptionsAsync(SupplyListRoleRequest request, SupplyListRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentRoleId))
            {
                query["parentRoleId"] = request.ParentRoleId;
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
                Action = "SupplyListRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyListRoleResponse SupplyListRole(SupplyListRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListRoleHeaders headers = new SupplyListRoleHeaders();
            return SupplyListRoleWithOptions(request, headers, runtime);
        }

        public async Task<SupplyListRoleResponse> SupplyListRoleAsync(SupplyListRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListRoleHeaders headers = new SupplyListRoleHeaders();
            return await SupplyListRoleWithOptionsAsync(request, headers, runtime);
        }

        public SupplyListSubDeptResponse SupplyListSubDeptWithOptions(SupplyListSubDeptRequest request, SupplyListSubDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyListSubDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/subDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListSubDeptResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyListSubDeptResponse> SupplyListSubDeptWithOptionsAsync(SupplyListSubDeptRequest request, SupplyListSubDeptHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplyDeptId))
            {
                query["supplyDeptId"] = request.SupplyDeptId;
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
                Action = "SupplyListSubDept",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/subDepartments",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyListSubDeptResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyListSubDeptResponse SupplyListSubDept(SupplyListSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListSubDeptHeaders headers = new SupplyListSubDeptHeaders();
            return SupplyListSubDeptWithOptions(request, headers, runtime);
        }

        public async Task<SupplyListSubDeptResponse> SupplyListSubDeptAsync(SupplyListSubDeptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyListSubDeptHeaders headers = new SupplyListSubDeptHeaders();
            return await SupplyListSubDeptWithOptionsAsync(request, headers, runtime);
        }

        public SupplyQueryPartnerTypeResponse SupplyQueryPartnerTypeWithOptions(SupplyQueryPartnerTypeRequest request, SupplyQueryPartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
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
                Action = "SupplyQueryPartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyQueryPartnerTypeResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyQueryPartnerTypeResponse> SupplyQueryPartnerTypeWithOptionsAsync(SupplyQueryPartnerTypeRequest request, SupplyQueryPartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
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
                Action = "SupplyQueryPartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyQueryPartnerTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyQueryPartnerTypeResponse SupplyQueryPartnerType(SupplyQueryPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyQueryPartnerTypeHeaders headers = new SupplyQueryPartnerTypeHeaders();
            return SupplyQueryPartnerTypeWithOptions(request, headers, runtime);
        }

        public async Task<SupplyQueryPartnerTypeResponse> SupplyQueryPartnerTypeAsync(SupplyQueryPartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyQueryPartnerTypeHeaders headers = new SupplyQueryPartnerTypeHeaders();
            return await SupplyQueryPartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        public SupplyUpdateMemberResponse SupplyUpdateMemberWithOptions(SupplyUpdateMemberRequest request, SupplyUpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCopyDept))
            {
                body["isCopyDept"] = request.IsCopyDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberTitle))
            {
                body["memberTitle"] = request.MemberTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberWorkNumber))
            {
                body["memberWorkNumber"] = request.MemberWorkNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDeptId))
            {
                body["newDeptId"] = request.NewDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldDeptId))
            {
                body["oldDeptId"] = request.OldDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdList))
            {
                body["roleIdList"] = request.RoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "SupplyUpdateMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyUpdateMemberResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyUpdateMemberResponse> SupplyUpdateMemberWithOptionsAsync(SupplyUpdateMemberRequest request, SupplyUpdateMemberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsCopyDept))
            {
                body["isCopyDept"] = request.IsCopyDept;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberTitle))
            {
                body["memberTitle"] = request.MemberTitle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberWorkNumber))
            {
                body["memberWorkNumber"] = request.MemberWorkNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mobile))
            {
                body["mobile"] = request.Mobile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewDeptId))
            {
                body["newDeptId"] = request.NewDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OldDeptId))
            {
                body["oldDeptId"] = request.OldDeptId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleIdList))
            {
                body["roleIdList"] = request.RoleIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnionId))
            {
                body["unionId"] = request.UnionId;
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
                Action = "SupplyUpdateMember",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/members",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyUpdateMemberResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyUpdateMemberResponse SupplyUpdateMember(SupplyUpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateMemberHeaders headers = new SupplyUpdateMemberHeaders();
            return SupplyUpdateMemberWithOptions(request, headers, runtime);
        }

        public async Task<SupplyUpdateMemberResponse> SupplyUpdateMemberAsync(SupplyUpdateMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateMemberHeaders headers = new SupplyUpdateMemberHeaders();
            return await SupplyUpdateMemberWithOptionsAsync(request, headers, runtime);
        }

        public SupplyUpdatePartnerTypeResponse SupplyUpdatePartnerTypeWithOptions(SupplyUpdatePartnerTypeRequest request, SupplyUpdatePartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "SupplyUpdatePartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyUpdatePartnerTypeResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyUpdatePartnerTypeResponse> SupplyUpdatePartnerTypeWithOptionsAsync(SupplyUpdatePartnerTypeRequest request, SupplyUpdatePartnerTypeHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelId))
            {
                query["labelId"] = request.LabelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuperId))
            {
                query["superId"] = request.SuperId;
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
                Action = "SupplyUpdatePartnerType",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/partnerLabels",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyUpdatePartnerTypeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyUpdatePartnerTypeResponse SupplyUpdatePartnerType(SupplyUpdatePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdatePartnerTypeHeaders headers = new SupplyUpdatePartnerTypeHeaders();
            return SupplyUpdatePartnerTypeWithOptions(request, headers, runtime);
        }

        public async Task<SupplyUpdatePartnerTypeResponse> SupplyUpdatePartnerTypeAsync(SupplyUpdatePartnerTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdatePartnerTypeHeaders headers = new SupplyUpdatePartnerTypeHeaders();
            return await SupplyUpdatePartnerTypeWithOptionsAsync(request, headers, runtime);
        }

        public SupplyUpdateRoleResponse SupplyUpdateRoleWithOptions(SupplyUpdateRoleRequest request, SupplyUpdateRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRoleGroup))
            {
                query["isRoleGroup"] = request.IsRoleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["roleName"] = request.RoleName;
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
                Action = "SupplyUpdateRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyUpdateRoleResponse>(Execute(params_, req, runtime));
        }

        public async Task<SupplyUpdateRoleResponse> SupplyUpdateRoleWithOptionsAsync(SupplyUpdateRoleRequest request, SupplyUpdateRoleHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRoleGroup))
            {
                query["isRoleGroup"] = request.IsRoleGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleId))
            {
                query["roleId"] = request.RoleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["roleName"] = request.RoleName;
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
                Action = "SupplyUpdateRole",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/supplyChains/roles",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "none",
                BodyType = "json",
            };
            return TeaModel.ToObject<SupplyUpdateRoleResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SupplyUpdateRoleResponse SupplyUpdateRole(SupplyUpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateRoleHeaders headers = new SupplyUpdateRoleHeaders();
            return SupplyUpdateRoleWithOptions(request, headers, runtime);
        }

        public async Task<SupplyUpdateRoleResponse> SupplyUpdateRoleAsync(SupplyUpdateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SupplyUpdateRoleHeaders headers = new SupplyUpdateRoleHeaders();
            return await SupplyUpdateRoleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateUserExtendInfoResponse UpdateUserExtendInfoWithOptions(string userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                body["jobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusCode))
            {
                body["jobStatusCode"] = request.JobStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProbCode))
            {
                body["userProbCode"] = request.UserProbCode;
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
                Action = "UpdateUserExtendInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/extInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateUserExtendInfoResponse> UpdateUserExtendInfoWithOptionsAsync(string userId, UpdateUserExtendInfoRequest request, UpdateUserExtendInfoHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comments))
            {
                body["comments"] = request.Comments;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobCode))
            {
                body["jobCode"] = request.JobCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobStatusCode))
            {
                body["jobStatusCode"] = request.JobStatusCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserProbCode))
            {
                body["userProbCode"] = request.UserProbCode;
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
                Action = "UpdateUserExtendInfo",
                Version = "industry_1.0",
                Protocol = "HTTP",
                Pathname = "/v1.0/industry/medicals/users/" + userId + "/extInfos",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserExtendInfoResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateUserExtendInfoResponse UpdateUserExtendInfo(string userId, UpdateUserExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
            return UpdateUserExtendInfoWithOptions(userId, request, headers, runtime);
        }

        public async Task<UpdateUserExtendInfoResponse> UpdateUserExtendInfoAsync(string userId, UpdateUserExtendInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateUserExtendInfoHeaders headers = new UpdateUserExtendInfoHeaders();
            return await UpdateUserExtendInfoWithOptionsAsync(userId, request, headers, runtime);
        }

    }
}
